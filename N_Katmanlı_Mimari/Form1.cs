using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using DataAccessLayer;
using LogicLayer;

namespace N_Katmanlı_Mimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            List<EntityPersonel> perlist = LogicPersonel.LLPersonelListesi();
            dataGridView1.DataSource = perlist;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Ad = txtPersonelAdSoyad.Text;
            ent.Sehir = txtPersonelSehir.Text;
            ent.Gorev = txtPersonelGorev.Text;
            ent.Maas = int.Parse(txtPersonelMaas.Text);
            LogicPersonel.LLPersonelEkle(ent);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Id = Convert.ToInt32(textBox1.Text);
            LogicPersonel.LLPersonelSil(ent.Id);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Id = Convert.ToInt32(textBox1.Text);
            ent.Ad = txtPersonelAdSoyad.Text;
            ent.Sehir= txtPersonelSehir.Text;
            ent.Gorev= txtPersonelGorev.Text;
            ent.Maas = int.Parse(txtPersonelMaas.Text);
            LogicPersonel.LLPersonelGuncelle(ent);
        }
    }
}
