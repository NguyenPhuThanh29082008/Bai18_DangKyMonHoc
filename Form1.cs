using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai18_DangKyMonHoc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxNienkhoa.Items.Add("2020-2021");
            cbxNienkhoa.Items.Add("2021-2022");
            cbxNienkhoa.Items.Add("2022-2023");
            cbxNienkhoa.Items.Add("2023-2024");
            cbxNienkhoa.Items.Add("2024-2025");
            cbxNienkhoa.SelectedIndex = 0;

            cbxLop.Items.Add("Ứng dụng phần mềm 1");
            cbxLop.Items.Add("Ứng dụng phần mềm 2");
            cbxLop.Items.Add("Ứng dụng phần mềm 3");
            cbxLop.Items.Add("Thiết kế đồ họa 1");
            cbxLop.Items.Add("Thiết kế đồ họa 2");
            cbxLop.Items.Add("Quản trị mạng 1");
            cbxLop.Items.Add("Quản trị mạng 2");
            cbxLop.SelectedIndex = 0;

            rad1.Checked = true;

            clbMonhoc.Items.Add("LT WIN", CheckState.Checked);
            clbMonhoc.Items.Add("LT Internet", CheckState.Checked);
            clbMonhoc.Items.Add("Mạng máy tính", CheckState.Checked);
            clbMonhoc.Items.Add("UML", CheckState.Checked);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtHoten.Clear();
            txtMSSV.Clear();
            cbxNienkhoa.SelectedIndex = 0;
            cbxLop.SelectedIndex = 0;
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            string thongtin;
            thongtin = "Mã số sinh viên: " + txtMSSV.Text;
            thongtin += "\nHọ và tên: " + txtHoten.Text;
            thongtin += "\nNiên khóa: " + cbxNienkhoa.SelectedItem;
            thongtin += "\nLớp: " + cbxLop.SelectedItem;

            string hocky = "";
            if (rad1.Checked)
            {
                hocky = rad1.Text;
            }
            else if (rad2.Checked)
            {
                hocky = rad2.Text;
            }
            else if (rad3.Checked)
            {
                hocky = rad3.Text;
            }
            else if (rad4.Checked)
            {
                hocky = rad4.Text;
            }

            thongtin += "\nĐã đăng ký học Học kỳ " + hocky + " Các môn học sau: ";

            int stt = 1;
            foreach (var item in clbMonhoc.CheckedItems)
            {
                thongtin += "\n" + stt + ". " + item.ToString();
                stt++;
            }
            MessageBox.Show(thongtin, "Thông tin sinh viên");
        }
    }
}
