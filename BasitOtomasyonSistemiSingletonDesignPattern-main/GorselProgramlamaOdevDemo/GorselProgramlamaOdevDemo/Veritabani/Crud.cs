using GorselProgramlamaOdevDemo.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselProgramlamaOdevDemo.Veritabani
{
    internal class Crud
    {
        
        public Crud() { }
        public void insert(Ogrenci ogrenci)
        {
            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=12345";
   
                string Query = "insert into GorselProgramlama.Ogrenci(OgrNo,Ad,Soyad,Fakulte, Bolum) values('" +
                    ogrenci.ogrNo + "','" + ogrenci.ad + "','" + ogrenci.soyad + "','" + ogrenci.fakulte+ "','" +
                    ogrenci.bolum + "');";

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
           
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();    
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void delete(int ogrNo)
        {
         
                

            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=12345";

                string Query = "delete from GorselProgramlama.Ogrenci where OgrNo= " + ogrNo + ";";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    while (MyReader2.Read())
                    {
                    }
                    MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            
            }

           
            
        }

        public void update(Ogrenci ogrenci)
        {
            try
            {
                
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=12345";

                string Query = "update GorselProgramlama.Ogrenci set Ad='" + ogrenci.ad + "',Soyad='" + ogrenci.soyad + "',Fakulte='" + ogrenci.fakulte + "',Bolum='" + ogrenci.bolum +  "' where OgrNo='" + ogrenci.ogrNo + "';";

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();

                MyReader2 = MyCommand2.ExecuteReader();
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();//Connection closed here
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public Ogrenci Select(int ogrNo)
        {
            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=12345";

                string Query = "select * from GorselProgramlama.Ogrenci where OgrNo= " + ogrNo + ";";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();

                MyReader2 = MyCommand2.ExecuteReader();

                Ogrenci selectedOgrenci = null;

                while (MyReader2.Read())
                {
                    selectedOgrenci = new Ogrenci(
                        Convert.ToInt32(MyReader2["OgrNo"]),
                        MyReader2["Ad"].ToString(),
                        MyReader2["Soyad"].ToString(),
                        MyReader2["Fakulte"].ToString(),
                        MyReader2["Bolum"].ToString()
                    );
                }

                MyConn2.Close();

                return selectedOgrenci;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }


        public List<Ogrenci> SelectAll()
        {
            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=12345";

                string Query = "select * from GorselProgramlama.Ogrenci;";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();

                MyReader2 = MyCommand2.ExecuteReader();

                List<Ogrenci> ogrenciListesi = new List<Ogrenci>();

                while (MyReader2.Read())
                {
                    Ogrenci ogrenci = new Ogrenci(
                        Convert.ToInt32(MyReader2["OgrNo"]),
                        MyReader2["Ad"].ToString(),
                        MyReader2["Soyad"].ToString(),
                        MyReader2["Fakulte"].ToString(),
                        MyReader2["Bolum"].ToString()
                    );

                    ogrenciListesi.Add(ogrenci);
                }

                MyConn2.Close();

                return ogrenciListesi;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }


        public void ExecuteQuery(string Query)
        {
            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=12345";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }

    }

}

