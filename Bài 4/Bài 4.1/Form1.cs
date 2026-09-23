using System;
using System.Windows.Forms;

namespace LoginFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 1. Tích/Bỏ tích CheckBox -> Hiện/Ẩn mật khẩu
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            // Tích chọn -> Hiện mật khẩu (UseSystemPasswordChar = false)
            // Bỏ chọn -> Ẩn mật khẩu (*) (UseSystemPasswordChar = true)
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        // 2. Hàm kiểm tra hợp lệ dữ liệu bằng ErrorProvider
        private bool ValidateInputs()
        {
            bool isValid = true;
            errorProvider1.Clear(); // Xóa tất cả lỗi cũ trước khi kiểm tra lại

            // Kiểm tra Tên đăng nhập
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                errorProvider1.SetError(txtUsername, "Vui lòng nhập tên đăng nhập!");
                isValid = false;
            }

            // Kiểm tra Mật khẩu
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorProvider1.SetError(txtPassword, "Vui lòng nhập mật khẩu!");
                isValid = false;
            }

            return isValid;
        }

        // 3. Xử lý khi nhấn nút Đăng nhập (hoặc phím Enter)
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // 4. Xử lý khi nhấn nút Thoát (hoặc phím Esc)
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // 5. Hàm xử lý rỗng giúp sửa triệt để lỗi "textBox1_TextChanged" trong Designer
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Giữ hàm này rỗng để tránh lỗi mất liên kết Designer
        }
    }
}