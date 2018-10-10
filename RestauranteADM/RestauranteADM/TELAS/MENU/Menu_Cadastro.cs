﻿using System;
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
    public partial class Menu_Cadastros : Form
    {
        public Menu_Cadastros()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        public void AbrirForminPanel(object Formhijo)
        {
            if (this.panelmenu.Controls.Count > 0)
                this.panelmenu.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelmenu.Controls.Add(fh);
            this.panelmenu.Tag = fh;
            fh.Show();
        }

        private void pctmenu_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 200)
            {
                MenuVertical.Width = 70;
            }
            else
                MenuVertical.Width = 200;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            AbrirForminPanel(new menu2());
        }

        private void btn1_Click_1(object sender, EventArgs e)
        {
            AbrirForminPanel(new Cadastrar_cliente());
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click_2(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }

}
