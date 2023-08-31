using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace kütüphane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection dbbaglan = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = C:\\Db\\kitap.mdb");


        private void verileriGetir()
        {
            listViewList.Items.Clear();

            dbbaglan.Open();
        
            OleDbCommand getirKomut = new OleDbCommand();
            getirKomut.Connection = dbbaglan;
            getirKomut.CommandText = ("select top 100 * from Kitap");

            OleDbDataReader oku = getirKomut.ExecuteReader();

            while(oku.Read())

            {
                ListViewItem ekle = new ListViewItem();

                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["kitap"].ToString());
                ekle.SubItems.Add(oku["yazar"].ToString());
                listViewList.Items.Add(ekle);
            }

            dbbaglan.Close();
        }

        private void buttonGtr_Click(object sender, EventArgs e)
        {
            verileriGetir();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            dbbaglan.Open();

            OleDbCommand ekleKomut= new OleDbCommand();
            ekleKomut.Connection = dbbaglan;
            ekleKomut.CommandText= ("insert into Kitap(kitap,yazar) values('" +textBoxKtp.Text.ToString()+ "', '"+textBoxYzr.Text.ToString()+"')");
            ekleKomut.ExecuteNonQuery();
          

            dbbaglan.Close();

            verileriGetir();
        }
    }
}
