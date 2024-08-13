using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EnglishWordsPlay
{
    public partial class Form1 : Form
    {
        int saniye = 60;
        int dakika = 0;
        int index;
        int puan = 0;
        int high_score = 0;
        int random_hak = 0;
        public Form1()
        {

          
            InitializeComponent();
        }
        string[] words = { "FALL","TRAP","DEVİL","MUD","DİSGRACE","EACHOTHER","FEAR","COURAGE","GRADUATED"
        ,"DORMİTORY","OCCUPATİON","MAKE A LİVİNG","CAPİTAL","SOUTH","COTTON","FLOSS","MANUFACTURES","PATH",
        "GOAT","REACH","ASİDE","SADDER","PİPE","LADDER","CUPBOARD","SHEET","HAY","ROUND","BLANCKET","SACK",
        "HERDER","PİCK","BATH","SHİNE","SİNKİNG","POCKET","FAİRYTALE","THOUGH","THROUGH","ALREADY","EVEN"
        ,"TRİGGER","CAUSE","NOSE","NURSE","NOİCE","MUD","EMOTİON","JAİL","MATTERS","CURSED","LANDSLİDE","DEVOTİON"
        ,"DRAWER","UPSTAİRS","UPTOWN","AMBUSH","CARRY ON","ACHİNG","MOTİON"};
        string[] mean = {"DÜSMEK","TUZAK","SEYTAN","CAMUR","REZALET","BIRBIRLERI","KORKU","CESARET","MEZUN","YURT"
        ,"MESLEK","GECİNMEK","BASKENT","GUNEY","PAMUK","IP","IMALAT","PATIKA","KECI","ULASMAK","BIR KENARI","DAHA UZGUN" 
             ,"BORU ","MERDIVEN","DOLAP","CARSAF","SAMAN","YUVARLAK","BATTANIYE","CUVAL","COBAN","TOPLAMAK","BANYO",
        "PARLAK","BATIYOR","CEP","MASAL","RAGMEN","BASTAN SONA","ZATEN-COKTAN","HATTA","TETIKLEMEK","SEBEP","BURUN",
        "HEMSIRE","GURULTU","CAMUR","DUYGU","HUCRE","ONEMLI","LANETLENMIS","HEYELAN-TOPRAK KAYMASI","BAGLILIK",
        "CEKMECE","YUKARIKAT","SEHİR DISI","PUSUYA DÜSÜRÜLMEK","DEVAM ETMEK","ACITIYOR","HAREKET"};
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         


        }

        private void button1_Click(object sender, EventArgs e)
        {
            label10.Text = "0";
            puan = 0;
            label10.Visible = true;
            if (engtr_btn.Checked || treng_btn.Checked)
            {
                timer_Gerisayim.Enabled = true;
                random_hak = 1;
            }
            else
            {
                MessageBox.Show("seciceğiniz dili gir", "error");
            }
          

      button1_Click_1(sender, e);

            if (Dakikasec.SelectedIndex == 0)
            {
                dakika = 0;
                saniye = 60;
            }
            if (Dakikasec.SelectedIndex == 1)
            {
                dakika = 2;
                saniye = 60;
            }
            if (Dakikasec.SelectedIndex == 2)
            {
                dakika = 4;
                saniye = 60;
            }
       
        }

        private void timer_Gerisayim_Tick(object sender, EventArgs e)
        {
         timer_Gerisayim.Interval = 1000;
            if (saniye > 0)
            {
                saniye--;
            }
            else
            {
              
               
                if (dakika == 0)
                {
                    timer_Gerisayim.Enabled = false;
                }
                else
                {
                    saniye = 59;
                    dakika--;
                }
            }
            High_score_lbl.Text = dakika.ToString();
            High_score_text_lbl.Text = saniye.ToString();
            if (saniye ==0&& dakika == 0)
            {
                if (puan > high_score)
                { 
                    
                    high_score = puan;
                    puan = 0;
                    sscore_lbl.Text=high_score.ToString();
                }
                else
                {
                    sscore_lbl.Text = high_score.ToString();
                }
             
            }


        }

        private void translate_btn_Click(object sender, EventArgs e)
        {
            random_hak = 1;
            richTextBox1.Text = words[index].ToString();
            richTextBox2.Text= mean[index].ToString();
            puan--;
            button1.Enabled = true;

            label10.Text=puan.ToString();
           
        }

        private void Checked_btn_Click(object sender, EventArgs e)
        {
          
            if (richTextBox2.Text.ToUpper() == mean[index])
            {
                puan = puan + 3;
                label10.Text = puan.ToString();
            }
            else
            {
                puan = puan - 2;
                label10.Text = puan.ToString();
            }

            random_hak = 1;
            
            button1_Click_1(sender,e);
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (random_hak != 0)
            {  
                richTextBox1.Text = "";
                richTextBox2.Text = "";

              
              
                Random Random = new Random();
                int rastegele = Random.Next(0, words.Length);     
             
                index = rastegele;
                if (engtr_btn.Checked)
                {
                    richTextBox1.Text = words[rastegele];
                }
                else if (treng_btn.Checked)
                {
                    richTextBox2.Text = mean[rastegele];
                }
                else
                {
                    MessageBox.Show("Cevirceginiz dili seciniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                random_hak = 0;
            }
            else
            {
              button1.Enabled = false;

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            puan = 0;
            timer_Gerisayim.Enabled = false;
            High_score_lbl.Text = "--";
            High_score_text_lbl.Text = "--";
            label10.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
    }
}
