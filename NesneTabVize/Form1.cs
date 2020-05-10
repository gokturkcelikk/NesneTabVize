using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NesneTabVize
{
    

    public partial class Form1 : Form
    {
        
        public Form1()
        {
           
            InitializeComponent();
            
        }
        public double drmaas = 240;
        public double hmsremaas = 160;
        public double hastabakıcımaas = 128;
        public double sekretermaas = 96;
        public double drmaas1 = 0;
        public double drmaas2 = 0;
        public double drmaas3 = 0;
        public double hmsremaas2 = 0;
        public double hastabakıcımaas2 = 0;
        public double sekretermaas2 = 0;
        public double hmsremaas1 = 0;
        public double hastabakıcımaas1 = 0;
        public double sekretermaas1 = 0;


        public DataTable tablo = new DataTable();
        private void Form1_Load(object sender, EventArgs e)
        {
            tablo.Columns.Add("Ad", typeof(string));
            tablo.Columns.Add("Soyad", typeof(string));
            tablo.Columns.Add("GünSayısı", typeof(int));
            tablo.Columns.Add("FazlaMesaiSaati", typeof(int));
            tablo.Columns.Add("Ameliyat", typeof(string));
            tablo.Columns.Add("Meslek", typeof(string));
            tablo.Columns.Add("Maaş", typeof(string));
            dataGridView1.DataSource = tablo;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
            if (comboBox2.Text=="Doktor")

            {
                
                drmaas1 = Convert.ToDouble(textBox3.Text)*240;

            }
            if (comboBox2.Text=="Hemşire")
            {
                hmsremaas1 = Convert.ToDouble(textBox3.Text) * 160;


            }
            if (comboBox2.Text=="Hasta Bakıcı")
            {

                hastabakıcımaas1 = Convert.ToDouble(textBox3.Text) * 128;

            }
            if (comboBox2.Text == "Sekreter")
            {

                sekretermaas1 = Convert.ToDouble(textBox3.Text) * 96;

            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if(Convert.ToDouble(textBox4.Text)<=40)
            {
                // drmaas = drmaas + (Convert.ToDouble(textBox4.Text)*60) ;
                drmaas2 =(Convert.ToDouble(textBox4.Text) * 60);
                //hmsremaas = hmsremaas + ((Convert.ToDouble(textBox4.Text) * 50));
                hmsremaas2 = (Convert.ToDouble(textBox4.Text) * 40);
                // hastabakıcımaas = hastabakıcımaas + ((Convert.ToDouble(textBox4.Text) * 32));
                hastabakıcımaas2 = (Convert.ToDouble(textBox4.Text) * 32);
                // sekretermaas = sekretermaas + ((Convert.ToDouble(textBox4.Text) * 24));
                sekretermaas2 = (Convert.ToDouble(textBox4.Text) * 24);

            }

            if(Convert.ToDouble(textBox4.Text)>40 && Convert.ToDouble(textBox4.Text)<=80)

            {
                // drmaas = drmaas + ((Convert.ToDouble(textBox4.Text) * 48));
                drmaas2 =  (Convert.ToDouble(textBox4.Text) * 48);
                hmsremaas2 = (Convert.ToDouble(textBox4.Text) * 40);
                hastabakıcımaas2 =  (Convert.ToDouble(textBox4.Text) * 25.6);
                sekretermaas2 =  (Convert.ToDouble(textBox4.Text) * 19.2);
                
                
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           if  ( Convert.ToString(comboBox1.Text)== "Ameliyat Yaptı")
            {
                //drmaas = drmaas + 300;
                drmaas3 =  300;
                hmsremaas = hmsremaas + 300;

            }
           if(Convert.ToString(comboBox1.Text)=="Ameliyat Yapmadı")
            {

                drmaas3 = drmaas3 + 0;
            }
            


            }



        private void button1_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || comboBox2.Text == "" || textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("boş alan bırakmayınız");


            }



            else if (comboBox2.Text == "Doktor")
            {
                drmaas = 240;
                drmaas = drmaas*(Convert.ToDouble(textBox3.Text))+drmaas2;
                drmaas += Convert.ToString(comboBox1.Text) == "Ameliyat Yaptı" ? 300 : 0;
                textBox5.Text = Convert.ToString(drmaas);
            }
            else if (comboBox2.Text == "Hemşire")
            {
                hmsremaas = 160;
                hmsremaas =hmsremaas * (Convert.ToDouble(textBox3.Text)) + hmsremaas2;
                hmsremaas += Convert.ToString(comboBox1.Text) == "Ameliyat Yaptı" ? 300 : 0;
                textBox5.Text = Convert.ToString(hmsremaas);
            }
            else if (comboBox2.Text == "Hasta Bakıcı")
            {
                hastabakıcımaas = 128;
                hastabakıcımaas = hastabakıcımaas * (Convert.ToDouble(textBox3.Text)) + hastabakıcımaas2;
                hastabakıcımaas += Convert.ToString(comboBox1.Text) == "Ameliyat Yaptı" ? 300 : 0;
                textBox5.Text = Convert.ToString(hastabakıcımaas);
            }
            else if (comboBox2.Text == "Sekreter")
            {
                sekretermaas = 96;
                sekretermaas = sekretermaas * (Convert.ToDouble(textBox3.Text)) + sekretermaas2;
                sekretermaas+= Convert.ToString(comboBox1.Text) == "Ameliyat Yaptı" ? 300 : 0;
                textBox5.Text = Convert.ToString(sekretermaas);
            }

            

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            {
                tablo.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, comboBox1.Text, comboBox2.Text, textBox5.Text);
                dataGridView1.DataSource = tablo;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Lüffen silinecek satırı seçin.");
            }

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if(Convert.ToString(comboBox2.SelectedItem)=="Sekreter")
            {

                comboBox1.Enabled = false;
            }
            if (Convert.ToString(comboBox2.SelectedItem) == "Hasta Bakıcı")
            {

                comboBox1.Enabled = false;
            }
            if (Convert.ToString(comboBox2.SelectedItem) == "Doktor")
            {

                comboBox1.Enabled = true;
            }
            if (Convert.ToString(comboBox2.SelectedItem) == "Hemşire")
            {

                comboBox1.Enabled = true;
            }



        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }
    }





    
}


