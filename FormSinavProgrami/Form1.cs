﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormSinavProgrami
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        { //http://www.programlamadersleri.com
            FormAdSoyad frm2 = new FormAdSoyad();// Form 2ye ulaşmak için yeni nesne oluşturuyoruz 
            frm2.Show();//Form 2'yi ekrana çıkartıyoruz.
            this.Hide();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
