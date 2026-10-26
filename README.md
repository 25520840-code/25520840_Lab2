# Lab 2 — File và I/O Stream trong C#

- Sinh viên: Nguyễn Đăng Khiêm — 25520840
- Lớp: NT106.R14.2
- Giảng viên: Lê Minh Khánh Hội
- Môn: Lập trình mạng căn bản

## Chạy chương trình

Windows, .NET 10 SDK và Visual Studio có workload .NET desktop development.

```powershell
dotnet restore 25520840_Lab2.csproj
dotnet run --project 25520840_Lab2.csproj
```

Project dùng Microsoft.Data.Sqlite 10.0.14. Menu mở Form1 đến Form7.
File mẫu ở `testdata/`. SQLite và ảnh sao chép được tạo tại Application.LocalUserAppDataPath; không đóng gói dữ liệu cá nhân cũ.

## Các bài

1. Đọc file và chuyển nội dung thành chữ hoa.
2. Metadata file và đếm dòng, từ, ký tự.
3. Tính biểu thức bằng hai stack, không dùng DataTable.Compute.
4. Lưu sinh viên bằng JSON và tính điểm trung bình.
5. Đọc/ghi thông tin phim và thống kê phòng vé.
6. Món ăn, ảnh và người đóng góp bằng SQLite.
7. Duyệt thư mục và xem trước file văn bản.

## Kiểm thử ngày 26/10/2026

40 test tự động trên bản sao có thay hộp thoại bằng dữ liệu fixture: 39 đạt, 1 chưa đạt.
Kết quả gốc: `verification/test-results.json`. Ảnh form sau xử lý: `evidence/`.
Ảnh là DrawToBitmap từ các WinForms đang chạy, không phải mockup hoặc ảnh chụp thao tác thủ công.
Các thay thế chỉ áp dụng bản kiểm thử: MessageBox.Show, FileDialog.ShowDialog và thư mục dữ liệu SQLite. Mã nguồn ứng dụng trong thư mục gốc không bị thay đổi.
Hàm xử lý được gọi qua PerformClick/reflection. Test xóa chỉ thao tác món kiểm thử trong database riêng.

Test 01-04 chưa đạt: hủy hộp thoại lưu Bài 1 vẫn hiện “Đã lưu file!”. Cần đặt thông báo thành công vào nhánh DialogResult.OK.
MSSV Bài 4 hiện giới hạn dạng xx52xxxx; Bài 5 lưu lịch sử bán vé trong phiên; Bài 7 chỉ xem trước các định dạng văn bản tối đa 2 MB.

## Tệp kiểm thử

`verification/TestRunner.cs.txt` chứa bộ kiểm thử. Chạy lại trên Windows bằng PowerShell: `& .\verification\run-tests.ps1`. Script tạo thư mục tạm riêng, sao chép nguồn và chỉ thay hộp thoại, thông báo, thư mục SQLite trong bản sao. Kết quả và ảnh được ghi vào thư mục evidence mới; không sửa nguồn gốc.
