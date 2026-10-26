$ErrorActionPreference = 'Stop'
$repoRoot = Split-Path -Parent $PSScriptRoot
$testRoot = Join-Path ([System.IO.Path]::GetTempPath()) ('Lab2Tests-' + [guid]::NewGuid().ToString('N'))
New-Item -ItemType Directory -Path $testRoot | Out-Null

# Test only a copy. Dialogs are replaced by deterministic fixtures.
Get-ChildItem -LiteralPath $repoRoot -File | Where-Object {
    $_.Extension -in '.cs', '.resx', '.csproj'
} | ForEach-Object {
    $target = Join-Path $testRoot $_.Name
    if ($_.Extension -eq '.cs') {
        $text = [System.IO.File]::ReadAllText($_.FullName)
        $text = $text.Replace('MessageBox.Show(', 'TestHooks.ShowMessage(')
        $text = $text.Replace('dialog.ShowDialog()', 'TestHooks.ShowDialog(dialog)')
        $text = $text.Replace('Application.LocalUserAppDataPath', 'TestHooks.DataPath')
        [System.IO.File]::WriteAllText($target, $text)
    }
    else {
        Copy-Item -LiteralPath $_.FullName -Destination $target
    }
}

$projectPath = Join-Path $testRoot '25520840_Lab2.csproj'
$projectText = [System.IO.File]::ReadAllText($projectPath)
$projectText = $projectText.Replace('<OutputType>WinExe</OutputType>', '<OutputType>Exe</OutputType><StartupObject>_25520840_Lab2.TestRunner</StartupObject>')
[System.IO.File]::WriteAllText($projectPath, $projectText)
Copy-Item -LiteralPath (Join-Path $PSScriptRoot 'TestRunner.cs.txt') -Destination (Join-Path $testRoot 'TestRunner.cs')

Write-Output ('Running tests in isolated directory: ' + $testRoot)
& dotnet run --project $projectPath -p:NuGetAudit=false -v quiet
if ($LASTEXITCODE -ne 0) { throw 'The test executable failed.' }
Write-Output ('Results and form images: ' + (Join-Path $testRoot 'evidence'))
