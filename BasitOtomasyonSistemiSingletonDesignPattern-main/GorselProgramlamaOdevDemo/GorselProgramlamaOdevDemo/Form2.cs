using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GorselProgramlamaOdevDemo.Models;
using GorselProgramlamaOdevDemo.Veritabani;
using MySql.Data.MySqlClient;

namespace GorselProgramlamaOdevDemo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void OgrenciEkle_Click(object sender, EventArgs e)
        {

            int ogrNo;

            string ad;

            string soyad;

            string fakulte;

            string bolum;

            try
            {
                ogrNo = int.Parse(textBox1.Text);

                ad = textBox2.Text;

                soyad = textBox3.Text;

                fakulte = textBox4.Text;

                bolum = textBox5.Text;

                //MessageBox.Show(ogrNo.ToString());
                DialogResult dialogResult = MessageBox.Show("Eklemek istediğinize emin misiniz?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Crud crud = new Crud();
                    Ogrenci ogrenci = new Ogrenci(ogrNo, ad, soyad, fakulte, bolum);
     
                    crud.insert(ogrenci);

                    MessageBox.Show("öğrenci eklendi");
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("öğrenci eklenmedi");
                }

            }
            catch {
                MessageBox.Show("Lütfen tüm boşlukları doldurunuz");
            }
 




        }
    }
}
