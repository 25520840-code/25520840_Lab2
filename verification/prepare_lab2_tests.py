from pathlib import Path
import shutil, json, hashlib

root=Path(r'D:\Doc\[Network Programming]')
src=root/'tmp/lab2-review'
dst=root/'tmp/lab2-tests'
dst.mkdir(exist_ok=True)
manifest={}
for p in src.iterdir():
    if not p.is_file(): continue
    if p.suffix not in ('.cs','.resx','.csproj'): continue
    manifest[p.name]=hashlib.sha256(p.read_bytes()).hexdigest()
    if p.suffix=='.cs':
        text=p.read_text(encoding='utf-8-sig')
        text=text.replace('MessageBox.Show(', 'TestHooks.ShowMessage(')
        text=text.replace('dialog.ShowDialog()', 'TestHooks.ShowDialog(dialog)')
        text=text.replace('Application.LocalUserAppDataPath','TestHooks.DataPath')
        (dst/p.name).write_text(text,encoding='utf-8')
    else: shutil.copy2(p,dst/p.name)
p=dst/'25520840_Lab2.csproj'
s=p.read_text(encoding='utf-8-sig').replace('<OutputType>WinExe</OutputType>','<OutputType>Exe</OutputType>\n<StartupObject>_25520840_Lab2.TestRunner</StartupObject>')
p.write_text(s,encoding='utf-8')
(dst/'source-hashes.json').write_text(json.dumps(manifest,indent=2),encoding='utf-8')
