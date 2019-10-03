# Kiểm tra kết thúc môn
1. Tạo dự án WPF tên Kiemtraketthucmon
2. Chia sẻ đến github trong Repository: kiemtra
3. Viết tập tin Readme.md dùng ngôn ngữ Markdown
4. * Thêm lớp mói tên Dongvat với 1 phương thức là Keu() và 1 thuộc tính là MauLong
   * Thêm 2 lớp kế thừa lớp Dongvat là lớp Cho và Meo
Định nghĩa lại phương thức Keu()
5. Cập nhật Readme và dự án đến Github
6. Chỉnh sửa phương thức Keu() của lớp Meo và Cho
   * Lớp Meo: Hiển thị chuỗi:" Meo meo Tôi là mèo lông màu"+MauLong
   * Lớp Cho: Hiển thị chuỗi:" Gâu gâu Tôi là chó lông màu"+MauLong
   * Thêm 2 buttom đến form Ứng dụng
   - Butom 1: name: Meo, Text: Mèo
   - Buttom 2: name: Cho, Text: Chó 
   - Hàm Meo_Click
          Meo cat = new Meo();
                cat.Keu();
                MessageBox.Show(cat.m + tbmeo.Text);
    - Hàm Cho_Click
           Cho dog = new Cho();
            dog.Keu();
            MessageBox.Show(dog.c + tbcho.Text);
            
7. Cập nhật lên Github, cập nhật Readme
