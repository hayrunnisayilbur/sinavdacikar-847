using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class FormSarkiEkle : Form
    {
        string baglanti = "Server=localhost;Database=muzik;Uid=root;Pwd=;";
        public FormSarkiEkle()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            using (MySqlConnection baglan = new MySqlConnection(baglanti))
            {
                baglan.Open();
                string sorgu = "INSERT INTO sarkilar VALUES(NULL,@sarkiAd,@sanatciAd,@yil,@tur,@sure,@tarih,@favori);";

                MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                cmd.Parameters.AddWithValue("@sarkiAd", txtSarki.Text);
                cmd.Parameters.AddWithValue("@sanatciAd", txtSanatci.Text);
                cmd.Parameters.AddWithValue("@yil", txtYil.Text);
                cmd.Parameters.AddWithValue("@tur", cmbTur.SelectedValue);
                cmd.Parameters.AddWithValue("@sure",txtSure.Text);
                cmd.Parameters.AddWithValue("@tarih",dtTarih.Value);
                cmd.Parameters.AddWithValue("@favori",cbFavori.Checked);
                
                //sorguyu çalıştırma komutu kayıt eklşenirse satır satıyısı döner
                if(cmd.ExecuteNonQuery() > 0)
                {
                    // MessageBox.Show("Kayıt Eklendi!");
                    // this.Close(); 
                }
             
            }
        }

        private void FormSarkiEkle_Load(object sender, EventArgs e)
        {
            CmbDoldur();
        }


        void CmbDoldur()
        {
            using (MySqlConnection baglan = new MySqlConnection(baglanti))
            {
                baglan.Open();
                string sorgu = "SELECT DISTINCT tur FROM sarkilar;";

                MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                


                da.Fill(dt);
                cmbTur.DataSource = dt;

                cmbTur.DisplayMember = "tur";   //ekranda kullanıcı görür
                cmbTur.ValueMember = "tur";     //veritabanına kayıt edilir
            }
        }

    }
}
