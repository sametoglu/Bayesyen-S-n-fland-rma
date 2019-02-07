using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veri_odevi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-C97083V;Initial Catalog=stajproje;Integrated Security=True");


        private void Form2_Load(object sender, EventArgs e)
        {
            SqlDataAdapter data_tablogetir = new SqlDataAdapter("SELECT * from karar_agacı ", baglan);
            DataTable tbl_tablogetir = new DataTable();
            data_tablogetir.Fill(tbl_tablogetir);

            dgv_tablo.DataSource = tbl_tablogetir;
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlDataAdapter data_ekle = new SqlDataAdapter("exec proc_tabloekle '" + cb_fiyat.SelectedItem.ToString() + "','"+ cb_km_limiti.SelectedItem.ToString() + "','" + cb_uretim_yili.SelectedItem.ToString() + "','"+cb_degisim.SelectedItem.ToString()+"'", baglan);
            DataTable tbl_ekle = new DataTable();
            data_ekle.Fill(tbl_ekle);

            SqlDataAdapter data_tablogetir = new SqlDataAdapter("SELECT * from karar_agacı ", baglan);
            DataTable tbl_tablogetir = new DataTable();
            data_tablogetir.Fill(tbl_tablogetir);

            dgv_tablo.DataSource = tbl_tablogetir;
            dgv_tablo.Refresh();
            baglan.Close();
        }
    }
}
