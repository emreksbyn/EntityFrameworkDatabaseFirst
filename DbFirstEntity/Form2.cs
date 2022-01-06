using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbFirstEntity
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        DbSinavOgrenciEntities db = new DbSinavOgrenciEntities();

        private void btnLinq_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                var lst = db.TBLNOTLAR.Where(x => x.SINAV1 < 50).ToList();
                dgvTablolar.DataSource = lst;
            }
            if (radioButton2.Checked == true)
            {
                var lst = db.TBLOGRENCI.Where(x => x.AD == "Ali").ToList();
                dgvTablolar.DataSource = lst;
            }
            if (radioButton3.Checked == true)
            {
                var lst = db.TBLOGRENCI.Where(x => x.AD == txtAdveyaSoyad.Text || x.SOYAD == txtAdveyaSoyad.Text).ToList();
                dgvTablolar.DataSource = lst;
            }
            if (radioButton4.Checked == true)
            {
                var lst = db.TBLOGRENCI.Select(x => new
                {
                    SOYAD = x.SOYAD

                }).ToList();
                dgvTablolar.DataSource = lst;
            }
            if (radioButton5.Checked == true)
            {
                var lst = db.TBLOGRENCI.Select(x => new
                {
                    AD = x.AD.ToUpper(),
                    SOYAD = x.SOYAD.ToLower()

                }).ToList();
                dgvTablolar.DataSource = lst;
            }
            if (radioButton6.Checked == true)
            {
                var lst = db.TBLOGRENCI.Select(x => new
                {
                    ADI = x.AD.ToUpper(),
                    SOYADI = x.SOYAD.ToLower()

                }).Where(x => x.ADI != "ALİ").ToList();
                dgvTablolar.DataSource = lst;
            }
            if (radioButton7.Checked == true)
            {
                var lst = db.TBLNOTLAR.Select(x => new
                {
                    ÖğrenciAdSoyad = x.TBLOGRENCI.AD + " " + x.TBLOGRENCI.SOYAD,
                    Ortalama = x.ORTALAMA,
                    Durumu = x.DURUM == true ? "Geçti" : "Kaldı"

                }).ToList();
                dgvTablolar.DataSource = lst;
            }
            if (radioButton8.Checked == true)
            {
                var lst = db.TBLNOTLAR.SelectMany(x => db.TBLOGRENCI.Where(y => y.ID == x.OGR), (x, y) => new
                {
                    y.AD,
                    y.SOYAD,
                    x.TBLDERSLER.DERSAD,
                    x.SINAV1,
                    x.SINAV2,
                    x.ORTALAMA
                }).ToList();
                dgvTablolar.DataSource = lst;
            }
            if (radioButton9.Checked == true)
            {
                var lst = db.TBLNOTLAR.SelectMany(x => db.TBLOGRENCI.Where(y => y.ID == x.OGR), (x, y) => new
                {
                    y.AD,
                    y.SOYAD,
                    x.TBLDERSLER.DERSAD,
                    x.SINAV1,
                    x.SINAV2,
                    x.ORTALAMA
                }).OrderByDescending(x=>x.ORTALAMA).Take(3).ToList();
                dgvTablolar.DataSource = lst;

            }
            if (radioButton10.Checked == true)
            {
                var lst = db.TBLNOTLAR.SelectMany(x => db.TBLOGRENCI.Where(y => y.ID == x.OGR), (x, y) => new
                {
                    y.AD,
                    y.SOYAD,
                    x.TBLDERSLER.DERSAD,
                    x.SINAV1,
                    x.SINAV2,
                    x.ORTALAMA
                }).OrderBy(x => x.ORTALAMA).Take(3).ToList();
                dgvTablolar.DataSource = lst;
            }
            if (radioButton11.Checked == true)
            {
                var lst = db.TBLOGRENCI.OrderBy(x => x.AD).ToList();
                dgvTablolar.DataSource = lst;
            }
            if (radioButton12.Checked == true)
            {
                var lst = db.TBLOGRENCI.OrderBy(x => x.ID).Skip(5).ToList();
                dgvTablolar.DataSource = lst;
            }
        }
    }
}
