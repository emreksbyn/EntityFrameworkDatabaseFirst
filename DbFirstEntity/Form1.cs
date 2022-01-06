using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DbFirstEntity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DbSinavOgrenciEntities db = new DbSinavOgrenciEntities();

        private void btnDersListesi_Click(object sender, EventArgs e)
        {
            // ADO.NET ile Entity Framework arasındaki farkı görebilmek için Ders Listesini ADO.NET ile getirdik.

            SqlConnection conn = new SqlConnection("Server=.; Database=DbSinavOgrenci; Integrated Security = TRUE");
            SqlCommand cmd = new SqlCommand("SELECT * FROM TBLDERSLER", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvTablolar.DataSource = dt;
        }

        private void btnOgrenciListesi_Click(object sender, EventArgs e)
        {
            dgvTablolar.DataSource = db.TBLOGRENCI.ToList();
            dgvTablolar.Columns[3].Visible = false;
            dgvTablolar.Columns[4].Visible = false;
        }

        private void btnNotListesi_Click(object sender, EventArgs e)
        {
            //foreach (var item in collection)
            //{
            //}
            // Alta yazavaklarımız foreach yapısına benzemektedir.

            var query = from item in db.TBLNOTLAR
                        select new
                        {
                            item.NOTID,
                            item.TBLOGRENCI.AD,
                            item.TBLOGRENCI.SOYAD,
                            item.TBLDERSLER.DERSAD,
                            item.SINAV1,
                            item.SINAV2,
                            item.SINAV3,
                            item.ORTALAMA,
                            item.DURUM
                        };
            dgvTablolar.DataSource = query.ToList();
        }

        private void btnJoinIleGetir_Click(object sender, EventArgs e)
        {
            var sorgu = from d1 in db.TBLNOTLAR
                        join d2 in db.TBLOGRENCI
                        on d1.OGR equals d2.ID
                        join d3 in db.TBLDERSLER
                        on d1.DERS equals d3.DERSID
                        select new
                        {
                            Öğrenci = d2.AD + " " + d2.SOYAD,
                            Ders = d3.DERSAD,
                            Sınav1 = d1.SINAV1,
                            Sınav2 = d1.SINAV2,
                            Sınav3 = d1.SINAV3,
                            Ortalama = d1.ORTALAMA
                        };
            dgvTablolar.DataSource = sorgu.ToList();
        }
        private void btnOgrenciEkle_Click_1(object sender, EventArgs e)
        {
            TBLOGRENCI ogr = new TBLOGRENCI();
            ogr.AD = txtAd.Text;
            ogr.SOYAD = txtSoyad.Text;
            db.TBLOGRENCI.Add(ogr);
            db.SaveChanges();
            MessageBox.Show("Öğrenci listeye eklenmiştir.");
        }

        private void btnDersEkle_Click(object sender, EventArgs e)
        {
            TBLDERSLER ders = new TBLDERSLER();
            ders.DERSAD = txtDersAd.Text;
            db.TBLDERSLER.Add(ders);
            db.SaveChanges();
            MessageBox.Show("Ders başarıyla eklenmiştir.");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtOgrenciID.Text);
            var x = db.TBLOGRENCI.Find(id);
            db.TBLOGRENCI.Remove(x);
            db.SaveChanges();
            MessageBox.Show("Öğrenci başarıyla silinmiştir.");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtOgrenciID.Text);
            var x = db.TBLOGRENCI.Find(id);
            x.AD = txtAd.Text;
            x.SOYAD = txtSoyad.Text;
            x.FOTOGRAF = txtFoto.Text;
            db.SaveChanges();
            MessageBox.Show("Öğrenci bilgileri güncellendi");

        }

        private void btnPurosedur_Click(object sender, EventArgs e)
        {
            dgvTablolar.DataSource = db.NOTLISTESI();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            dgvTablolar.DataSource = db.TBLOGRENCI.Where(x => x.AD == txtAd.Text & x.SOYAD == txtSoyad.Text).ToList();
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            var degerler = from item in db.TBLOGRENCI
                           where item.AD.StartsWith(txtAd.Text)
                           select item;
            dgvTablolar.DataSource = degerler.ToList();
        }

        private void btnLinqEntity_Click(object sender, EventArgs e)
        {
            if (radioAd_A_Z.Checked == true)
            {
                List<TBLOGRENCI> liste1 = db.TBLOGRENCI.OrderBy(x => x.AD).ToList();
                dgvTablolar.DataSource = liste1;
            }
            else if (radioAd_Z_A.Checked == true)
            {
                List<TBLOGRENCI> liste2 = db.TBLOGRENCI.OrderByDescending(x => x.AD).ToList();
                dgvTablolar.DataSource = liste2;
            }
            else if (radioIlk3.Checked == true)
            {
                List<TBLOGRENCI> liste3 = db.TBLOGRENCI.OrderBy(x => x.AD).Take(3).ToList();
                dgvTablolar.DataSource = liste3;
            }
            else if (radioIcindeAOlan.Checked == true)
            {
                List<TBLOGRENCI> liste4 = db.TBLOGRENCI.Where(x => x.AD.Contains("A")).ToList();
                dgvTablolar.DataSource = liste4;
            }
            else if (radioGetToID.Checked == true)
            {
                List<TBLOGRENCI> liste5 = db.TBLOGRENCI.Where(x => x.ID == 5).ToList();
                dgvTablolar.DataSource = liste5;
            }
            else if (radioDegerVarMi.Checked == true)
            {
                bool deger = db.TBLKULUPLER.Any();
                MessageBox.Show(deger.ToString(), "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (radioOgrenciSayisi.Checked == true)
            {
                int toplam = db.TBLOGRENCI.Count();
                MessageBox.Show(toplam.ToString(), "Toplam Öğrenci Sayısı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (radioSinav1ToplamPuan.Checked == true)
            {
                var toplam = db.TBLNOTLAR.Sum(x => x.SINAV1);
                MessageBox.Show("1. sınav toplam puanları = " + toplam.ToString());
            }
            else if (radio1SınavOrt.Checked == true)
            {
                var ort = db.TBLNOTLAR.Average(x => x.SINAV1);
                MessageBox.Show("1. sınav ortalaması = " + ort.ToString());
            }
            else if (radioOrtUstu.Checked == true)
            {
                var ort = db.TBLNOTLAR.Average(x => x.SINAV1);
                List<TBLNOTLAR> liste6 = db.TBLNOTLAR.Where(s => s.SINAV1 > ort).ToList();
                dgvTablolar.DataSource = liste6;
            }
            else if (radio1EnYuksek.Checked == true)
            {
                var max = db.TBLNOTLAR.Max(x => x.SINAV1);
                MessageBox.Show("SINAV1 En Yüksek Notu = " + max.ToString());
            }
            else if (radio1EnDusuk.Checked == true)
            {
                var min = db.TBLNOTLAR.Min(x => x.SINAV1);
                MessageBox.Show("SINAV1 En Düşük Notu = " + min.ToString());
            }

        }

    }
}
