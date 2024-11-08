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

    public partial class Form1 : Form

    {
        private int userId;
        
     
        public Form1(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            load();
        }
        private void load()
        {
            
        }

        private void gridTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
