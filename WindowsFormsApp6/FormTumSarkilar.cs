using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mysqlx.Cursor;

namespace WindowsFormsApp6
{
    public partial class FormTumSarkilar : Form
    {
        string baglanti = "Server=localhost;Database=muzik;Uid=root;Pwd=;";
        public FormTumSarkilar()
        {
            InitializeComponent();
        }

        private void FormTumSarkilar_Load(object sender, EventArgs e)
        {

            DgwDoldur();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgwSarkilar.SelectedRows[0];
            int satirId = Convert.ToInt32(dr.Cells[0].Value);

            DialogResult cevap = MessageBox.Show("Şarkıyı Silmek İstediğinizden Emin Misiniz?",
                                "Şarkı Sil",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Error);

            if (cevap == DialogResult.Yes)
            {

                string sorgu = "DELETE FROM sarkilar where id = @satirid;";

                using (MySqlConnection baglan = new MySqlConnection(baglanti))
                {
                    baglan.Open();
                    MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                    cmd.Parameters.AddWithValue("@satirid", satirId);
                    cmd.ExecuteNonQuery();

                    DgwDoldur(); //tekrar doldurur
                }


            }
        }

        void DgwDoldur()
        {
            using (MySqlConnection baglan = new MySqlConnection(baglanti))
            {
                baglan.Open();
                string sorgu = "SELECT * FROM sarkilar;";

                MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();


                da.Fill(dt);
                dgwSarkilar.DataSource = dt;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE sarkilar SET ad =@sarkiad, sanatci=@sanatciad, yil=@yil, tur=@tur, sure=@sure, eklenme_tarihi=@tarih, favori=@favori  WHERE id = @satirid;";
            using (MySqlConnection baglan = new MySqlConnection(baglanti))
            {
                baglan.Open();
                MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                cmd.Parameters.AddWithValue("@sarkiad", txtSarki.Text);
                cmd.Parameters.AddWithValue("@sanatciad", txtSanatci.Text);
                cmd.Parameters.AddWithValue("@yil", txtYil.Text);
                cmd.Parameters.AddWithValue("@tur", cmbTur.SelectedValue);
                cmd.Parameters.AddWithValue("@sure", txtSure.Text);
                cmd.Parameters.AddWithValue("@tarih", dtTarih.Value);
                cmd.Parameters.AddWithValue("@favori", cbFavori.Checked);
                //id datagridview içinden alınacaktır.
                int id = Convert.ToInt32(dgwSarkilar.SelectedRows[0].Cells["id"].Value);
                cmd.Parameters.AddWithValue("@satirid", id);

                //güncelle
                cmd.ExecuteNonQuery();

                DgwDoldur(); //datagridviewi yenile
            }

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

        private void dgwSarkilar_SelectionChanged(object sender, EventArgs e)
        {
            if(dgwSarkilar.SelectedRows.Count > 0)
            {
                txtSarki.Text = dgwSarkilar.SelectedRows[0].Cells["ad"].Value.ToString();
                txtSanatci.Text = dgwSarkilar.SelectedRows[0].Cells["sanatci"].Value.ToString();
                txtSure.Text = dgwSarkilar.SelectedRows[0].Cells["sure"].Value.ToString();
                txtYil.Text = dgwSarkilar.SelectedRows[0].Cells["yil"].Value.ToString();
                dtTarih.Value = Convert.ToDateTime(dgwSarkilar.SelectedRows[0].Cells["eklenme_tarihi"].Value);
                cbFavori.Checked = Convert.ToBoolean(dgwSarkilar.SelectedRows[0].Cells["favori"].Value);
                cmbTur.SelectedValue = dgwSarkilar.SelectedRows[0].Cells["tur"].Value.ToString();
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM sarkilar WHERE ad LIKE @aranan;";

            if (rbSanatci.Checked)
            {
                sorgu = "SELECT * FROM sarkilar WHERE sanatci LIKE @aranan;";
            }

            using (MySqlConnection baglan = new MySqlConnection(baglanti))
            {
                baglan.Open();
                MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                cmd.Parameters.AddWithValue("@aranan", "%" +txtArama.Text+ "%"); //EN ÖNEMLİ KISIM
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgwSarkilar.DataSource = dt;
                
            }
        }
    }
}