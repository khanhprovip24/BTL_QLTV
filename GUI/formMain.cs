using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{

    public partial class formMain : Form

    {
        private int userId;
        
     BUSTaiKhoan busTk = new BUSTaiKhoan();
        public formMain(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          string temp = busTk.GetLoaiTKById(userId);
            string hoten = busTk.GetNameById(userId); 
            if (temp == "AD001  ") labelChaoMung.Text = "Chào mừng admin "+hoten;
            else labelChaoMung.Text = "Chào mừng thủ thư " + hoten;
        }
        

        private void gridTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            formLogin f = new formLogin();
            f.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void labelChaoMung_Click(object sender, EventArgs e)
        {

        }
    }
}
