using GorselProgramlamaOdevDemo.Models;
using GorselProgramlamaOdevDemo.Veritabani;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GorselProgramlamaOdevDemo
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Duzenle_Click(object sender, EventArgs e)
        {
            string ad;
            string soyad;
            string fakulte;
            string bolum;
            int a = Form1.GetInstance().selected;
            if (a != 0)
            {
                try
                {

                    ad = textBox2.Text;

                    soyad = textBox3.Text;

                    fakulte = textBox4.Text;

                    bolum = textBox5.Text;

                
                    DialogResult dialogResult = MessageBox.Show(a.ToString() + " numaralı öğrenciyi düzenlemek istediğinize emin misiniz?", "", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Crud crud = new Crud();
                        crud.update(new Ogrenci(a,ad,soyad,fakulte,bolum));

                        MessageBox.Show("öğrenci düzenlendi");
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("öğrenci düzenlenmedi");
                    }
                    

                }
                catch
                {
                    MessageBox.Show("Lütfen tüm boşlukları doldurunuz");
                }
            }
          
        }
    }
}
