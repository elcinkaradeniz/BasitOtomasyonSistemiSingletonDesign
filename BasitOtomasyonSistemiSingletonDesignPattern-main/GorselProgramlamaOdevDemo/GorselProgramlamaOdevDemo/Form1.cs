using GorselProgramlamaOdevDemo.Models;
using GorselProgramlamaOdevDemo.Veritabani;

namespace GorselProgramlamaOdevDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static Form3 instance = new Form3();

        private bool flag = true;

        private void CrudMethods()
        {
            
            Crud crud = new Crud();
            Ogrenci ogrenci = new Ogrenci(7, "test1", "test2", "test3", "test4");
            /*
            crud.insert(ogrenci);
            crud.update(ogrenci);
            Ogrenci sonuc = crud.Select(ogrenci.ogrNo);
            MessageBox.Show(sonuc.ad.ToString());
            crud.delete(ogrenci.ogrNo);
            List<Ogrenci> ogrList = crud.SelectAll();
            foreach (Ogrenci ogr in ogrList)
            {
                MessageBox.Show(ogr.ogrNo.ToString());
            }
            crud.ExecuteQuery("select * from Ogrenci");
             */




        }

        public static Form3 GetInstance()
        {
            return instance;
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }


        private void button1_Click(object sender, EventArgs e)
        {
            //ogrenci ekle
            //MessageBox.Show("Ogrenci ekle butonuna týklandý");
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ogrenci listele
            //MessageBox.Show("Ogrenci listele týklandý");
            
            Form3 form3 = GetInstance();

            form3.Show();

        }



        private void button3_Click(object sender, EventArgs e)
        {
            //ogrenci sil
            //MessageBox.Show("Ogrenci sil butonuna týklandý");
            Form4 form4 = new Form4();
            form4.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //ogrenci duzenle
            Form5 form5 = new Form5();
            form5.Show();

        }

       
    }
}

