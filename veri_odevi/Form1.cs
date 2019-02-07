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
    public partial class Form1 : Form
    {

        Form2 form_karar_agacı = new Form2();

        double px, pc1, pc2, pc3, pc4, pc5, pxc1, pxc2, pxc3, pxc4, pxc5, px1,pc1x1,pc2x1,pc3x1,pc4x1,pc5x1;

        public void sınıflandır(int fiyat, int limit, int yıl, int degisim, string tip) {

            if (fiyat<=50000)
            {
                fiyat = 1;
            }
            else if (fiyat>50000 && fiyat <= 100000)
            {
                fiyat = 2;
            }

            else if (fiyat >100000 && fiyat <= 150000)
            {
                fiyat = 3;   
            }
            else if (fiyat > 150000 && fiyat <=200000)
            {
                fiyat = 4;
            }
            else if(fiyat >200000)
            {
                fiyat = 5;
            }

            if (limit<=100000)
            {
                limit = 1;
            }
            else if (limit > 100000 && limit <=200000)
            {
                limit = 2;
            }
            else if(limit > 200000)
            {
                limit = 3;
            }

            if (yıl > 1990 && yıl <=2000)
            {
                yıl = 1;
            }
            else if (yıl > 2000 && yıl <= 2010)
            {
                yıl = 2;
            }
            else if (yıl > 2010)
            {
                yıl = 3;
            }

            if (degisim <= 33)
            {
                degisim = 1;
            }
            else if (degisim > 33 && degisim <= 66)
            {
                degisim = 2;
            }
            else if (degisim > 66)
            {
                degisim = 3;
            }
            if (tip == "otomobil")
            {
                tip = "1";
            }
            else if (tip == "arazi")
            {
                tip = "2";
            }
            else if (tip == "minivan")
            {
                tip = "3";
            }



            baglan.Open();
            SqlDataAdapter data_ekle = new SqlDataAdapter("exec proc_kayitekle '" + fiyat + "','" + tip + "','" + limit + "','" + yıl + "','" + degisim + "'", baglan);
            DataTable tbl_ekle = new DataTable();
            data_ekle.Fill(tbl_ekle);

            SqlDataAdapter data_tablogetir = new SqlDataAdapter("SELECT * from veri_madenciligi ", baglan);
            DataTable tbl_tablogetir = new DataTable();
            data_tablogetir.Fill(tbl_tablogetir);

            dgv_tablo.DataSource = tbl_tablogetir;
            dgv_tablo.Refresh();
            baglan.Close();
        }
        public void arama() {

            baglan.Open();
            SqlDataAdapter data_ara = new SqlDataAdapter("select fiyat,parca_degisim,kilometre_limiti,arac_tipi,uretim_yili from veri_madenciligi where id = '"+dgv_tablo.CurrentCell.Value.ToString()+"' ", baglan);
            DataTable tbl_ara = new DataTable();
            data_ara.Fill(tbl_ara);

            /*tabloda kactane  bunun gibi deger var*/
            SqlDataAdapter data_bul = new SqlDataAdapter("select COUNT(*) from veri_madenciligi where parca_Degisim='"+tbl_ara.Rows[0][1]+"' and kilometre_limiti='"+tbl_ara.Rows[0][2]+"' and arac_tipi = '"+tbl_ara.Rows[0][3]+"' and uretim_yili = '"+tbl_ara.Rows[0][4]+"'", baglan);
            DataTable tbl_bul = new DataTable();
            data_bul.Fill(tbl_bul);


            px=Convert.ToInt32(tbl_bul.Rows[0][0]);


            /*sınıfara*/
            SqlDataAdapter data_sınıfara = new SqlDataAdapter("SELECT fiyat, Count(*) FROM veri_madenciligi group by fiyat", baglan);
            DataTable tbl_sınıfara = new DataTable();
            data_sınıfara.Fill(tbl_sınıfara);

            pc1 = Convert.ToInt32(tbl_sınıfara.Rows[0][1]);
            pc2 = Convert.ToInt32(tbl_sınıfara.Rows[1][1]);
            pc3 = Convert.ToInt32(tbl_sınıfara.Rows[2][1]);
            pc4 = Convert.ToInt32(tbl_sınıfara.Rows[3][1]);
            pc5 = Convert.ToInt32(tbl_sınıfara.Rows[4][1]);

            int sayac=1;
            while (sayac<=5)
            {
                SqlDataAdapter data_sınıfdegerara = new SqlDataAdapter("SELECT Count(*) FROM veri_madenciligi where parca_Degisim='" + tbl_ara.Rows[0][1] + "' and kilometre_limiti='" + tbl_ara.Rows[0][2] + "' and arac_tipi ='" + tbl_ara.Rows[0][3] + "'  and uretim_yili = '" + tbl_ara.Rows[0][4] +"' and fiyat = '"+sayac+"'", baglan);
                DataTable tbl_sınıfdegerara = new DataTable();
                data_sınıfdegerara.Fill(tbl_sınıfdegerara);

                if (sayac == 1)
                {
                    pxc1 = Convert.ToInt32( tbl_sınıfdegerara.Rows[0][0]);
                }

                if (sayac == 2)
                {
                    pxc2 = Convert.ToInt32(tbl_sınıfdegerara.Rows[0][0]);
                }

                if (sayac == 3)
                {
                    pxc3 = Convert.ToInt32(tbl_sınıfdegerara.Rows[0][0]);
                }

                if (sayac == 4)
                {
                    pxc4 = Convert.ToInt32(tbl_sınıfdegerara.Rows[0][0]);
                }

                if (sayac == 5)
                {
                    pxc5 = Convert.ToInt32(tbl_sınıfdegerara.Rows[0][0]);
                }

                tbl_sınıfdegerara.Clear();
                sayac++;
            }
                

            
            baglan.Close();
        }


        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-C97083V;Initial Catalog=stajproje;Integrated Security=True");


        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             *px tabloda kac tane  bunun gibi deger var
             *pc sınıfların tabloda kac tane oldugu 
             *pxc1 sınıflarda kac tane bunun gibi deger  var
             *px1 = (pc1 / toplamsatır) * (pxc1 / pc1)) + ...
             *pc1x1 = (pc1 / toplamsatır) * (pxc1 / pc1)) / (px1)
             *
             * sınıflama
             * arama 
             */

            cb_aractip.SelectedIndex = 0;

            tb_yıl.MaxLength = DateTime.Now.Year;
            baglan.Open();

            SqlDataAdapter data_tablogetir = new SqlDataAdapter("SELECT * from veri_madenciligi order by (id) asc", baglan);
            DataTable tbl_tablogetir = new DataTable();
            data_tablogetir.Fill(tbl_tablogetir);

            dgv_tablo.DataSource = tbl_tablogetir;



            baglan.Close();


        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {


            if (tb_fiyat.Text==""||tb_yıl.Text==""||tb_limit.Text==""||nud_degisim.Text=="")
            {
                MessageBox.Show("veri girisi hatasi");
            }
            else
            {
                sınıflandır(Convert.ToInt32(tb_fiyat.Text), Convert.ToInt32(tb_limit.Text), Convert.ToInt32(tb_yıl.Text), Convert.ToInt32(nud_degisim.Text), cb_aractip.SelectedItem.ToString());
            }

            SqlDataAdapter data_tablogetir = new SqlDataAdapter("SELECT * from veri_madenciligi order by (id) asc", baglan);
            DataTable tbl_tablogetir = new DataTable();
            data_tablogetir.Fill(tbl_tablogetir);

        }

        private void dgv_tablo_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            arama();

            SqlDataAdapter data_satirsay = new SqlDataAdapter("SELECT Count(*) FROM veri_madenciligi ", baglan);
            DataTable tbl_satirsay = new DataTable();
            data_satirsay.Fill(tbl_satirsay);



            px1 = (((pc1 / (Convert.ToInt32(tbl_satirsay.Rows[0][0]))) * (pxc1 / pc1)) +
                   ((pc2 / (Convert.ToInt32(tbl_satirsay.Rows[0][0]))) * (pxc2 / pc2)) + 
                   ((pc3 / (Convert.ToInt32(tbl_satirsay.Rows[0][0]))) * (pxc3 / pc3)) + 
                   ((pc4 / (Convert.ToInt32(tbl_satirsay.Rows[0][0]))) * (pxc4 / pc4)) + 
                   ((pc5 / (Convert.ToInt32(tbl_satirsay.Rows[0][0]))) * (pxc5 / pc5)));

            pc1x1 = (pc1/(Convert.ToInt32(tbl_satirsay.Rows[0][0]))*(pxc1/pc1)) / (px1);
            pc2x1 = (pc2/(Convert.ToInt32(tbl_satirsay.Rows[0][0]))*(pxc2/pc2)) / (px1);
            pc3x1 = (pc3/(Convert.ToInt32(tbl_satirsay.Rows[0][0]))*(pxc3/pc3)) / (px1);
            pc4x1 = (pc4/(Convert.ToInt32(tbl_satirsay.Rows[0][0]))*(pxc4/pc4)) / (px1);
            pc5x1 = (pc5/(Convert.ToInt32(tbl_satirsay.Rows[0][0]))*(pxc5/pc5)) / (px1);

            lbl_pc1x1.Text = pc1x1.ToString();
            lbl_pc2x1.Text = pc2x1.ToString();
            lbl_pc3x1.Text = pc3x1.ToString();
            lbl_pc4x1.Text = pc4x1.ToString();
            lbl_pc5x1.Text = pc5x1.ToString();

            SqlDataAdapter data_tablogetir = new SqlDataAdapter("SELECT * from veri_madenciligi order by (id) asc", baglan);
            DataTable tbl_tablogetir = new DataTable();
            data_tablogetir.Fill(tbl_tablogetir);

            dgv_tablo.DataSource = tbl_tablogetir;

            gb_cikti.Visible = true;

        }

        private void btn_karar_agacı_Click(object sender, EventArgs e)
        {
            form_karar_agacı.Show();
            this.Hide();
        }


    }
}
