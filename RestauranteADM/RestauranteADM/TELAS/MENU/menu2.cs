using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace RestauranteADM.TELAS._1._0._1
{
    public partial class menu2 : Form
    {
        public menu2()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 200)
            {
                MenuVertical.Width = 70;
            }
            else
                MenuVertical.Width = 200;
        }
        public void AbrirForminPanel(object Formhijo)
        {
            if (this.MenuVertical.Controls.Count > 0)
                this.MenuVertical.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.MenuVertical.Controls.Add(fh);
            this.MenuVertical.Tag = fh;
            fh.Show();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            //AbrirForminPanel(new ());
        }

        private void button2_Click(object sender, EventArgs e)
        {
          //  AbrirForminPanel(new MenuVendas());
        }

        private void MenuVertical_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btn1_Click_1(object sender, EventArgs e)
        {
            Menu_Cadastros form = new Menu_Cadastros();
            form.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
