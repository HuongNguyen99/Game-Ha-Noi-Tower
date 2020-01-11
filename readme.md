<h2>Game C#: Tháp Hà Nội</h2>

1, Mô tả game
* Luật chơi: 
  Cho một bộ các đĩa kích thước khác nhau, có lỗ ở giữa, nằm xuyên trên 3 cái cọc.
  Bài toán đố bắt đầu bằng cách sắp xếp các đĩa theo trật tự kích thước vào một cọc sao cho đĩa nhỏ nhất nằm trên cùng, tức là tạo ra một 
  dạng hình nón.
  Yêu cầu của trò chơi là di chuyển toàn bộ số đĩa sang một cọc khác, tuân theo quy tắc sau: Chỉ có 3 cọc để di chuyển, một lần chỉ được
  di chuyển một đĩa (không được di chuyển đĩa nằm giữa). Một đĩa chỉ có thể được đặt lên một đĩa lớn hơn (không nhất thiết 2 đĩa phải có
  kích thước liền kề).
  
  <img src="/thap/image/img_main3.PNG" width="400">
* Các chức năng chính của game đã cài đặt:
  - Có thể lựa chọn số lượng đĩa để chơi
  - Đếm thời gian chơi
  - Game có 2 mức độ Dễ và Khó:
    + Mức độ "Dễ" cho phép người chơi di chuyển đĩa không giới hạn số lần dịch chuyển. Người chơi có thể chơi tới lúc nào thắng thì dừng.
    
       <img src="/thap/image/img_main1.PNG" width="400">
     
    + Mức độ "Khó" sẽ giới hạn số lần dịch đĩa, game sẽ cho 1 số lần dịch đĩa nhất định dựa vào số đĩa người chơi lựa chọn. Nếu hết số lần
      dịch đĩa tối đa thì game over.
      Số lần dịch đĩa tối đa được tính theo công thức: 2^n - 1 (với n đĩa)
      
       <img src="/thap/image/img_main2.PNG" width="400">
      
  - Có thể dừng (pause), tiếp tục/bắt đầu chơi (play).
  
 2, Hướng dẫn chi tiết
 * Game được xây dựng hoàn toàn bằng các thư viện của C#, đồ họa sử dụng Windows Forms
 * Project bao gồm: 
  - Thư mục Resources chứa ảnh/icon
  - File Form1.cs xử lý chính
  - File Menu_Form.cs xử lý các sự kiện khi click button tại menu.
  
    <img src="/thap/image/img_menu.PNG" width="400">
    
 
