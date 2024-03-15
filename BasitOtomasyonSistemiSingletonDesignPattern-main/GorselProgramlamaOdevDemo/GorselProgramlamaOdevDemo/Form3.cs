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

namespace GorselProgramlamaOdevDemo
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public int selected;
        public ListBox listbox1;


        private void Listele_Click(object sender, EventArgs e)
        {
            //veritabanından bilgi çek ve bir array oluştur
            Crud crud = new Crud();
            List<Ogrenci> ogrenciList = crud.SelectAll();

            listBox1.Items.Clear();
            for (int i = 0; i < ogrenciList.Count; i++)
            {
                if (!listBox1.Items.Contains(ogrenciList[i].ogrNo))
                {
                    listBox1.Items.Add(ogrenciList[i].ogrNo);
                }

            }



        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Crud crud = new Crud();
            if (listBox1.SelectedIndex != -1)
            {
                this.selected = (int)listBox1.SelectedItem;

            }
            string ogrenciString = "";
            //MessageBox.Show(((int)listBox1.SelectedItem).ToString());
            Ogrenci ogrenci = crud.Select(selected);
            ogrenciString += "Öğrenci numarası: " + ogrenci.ogrNo + "\nÖğrenci adı: " + ogrenci.ad + "\nÖğrenci soyadı: " + ogrenci.soyad +
                "\nFakülte: " + ogrenci.fakulte + "\nBölüm: " + ogrenci.bolum;
            label1.Text = "Seçilen öğrenci:\n" + ogrenciString;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
