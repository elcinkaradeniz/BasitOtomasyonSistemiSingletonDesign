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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }


        private void sil_Click(object sender, EventArgs e)
        {
            int a = Form1.GetInstance().selected;
            if (a != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Silmek istediğinize emin misiniz?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Crud crud = new Crud();
                    crud.delete(a);
                    MessageBox.Show("öğrenci silindi");
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("öğrenci silinmedi");
                }
            }
        }
    }
}
