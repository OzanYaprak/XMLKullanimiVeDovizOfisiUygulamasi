using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace XML_Kullanımı_Ve_Döviz_Ofisi_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            string bugunKur = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmlDosya = new XmlDocument();
            xmlDosya.Load(bugunKur);

            string dolarAlis = xmlDosya.SelectSingleNode("Tarih_Date/Currency[@CurrencyCode='USD']/BanknoteBuying").InnerXml;
            string dolarSatis = xmlDosya.SelectSingleNode("Tarih_Date/Currency[@CurrencyCode='USD']/BanknoteSelling").InnerXml;

            string euroAlis = xmlDosya.SelectSingleNode("Tarih_Date/Currency[@CurrencyCode='EUR']/BanknoteBuying").InnerXml;
            string euroSatis = xmlDosya.SelectSingleNode("Tarih_Date/Currency[@CurrencyCode='EUR']/BanknoteSelling").InnerXml;

            LabelDolarAlis.Text = dolarAlis;
            LabelDolarSatis.Text = dolarSatis;
            LabelEuroAlis.Text = euroAlis;
            LabelEuroSatis.Text = euroSatis;
        }

        private void ButtonDolarAlisKur_Click(object sender, EventArgs e)
        {
            textBoxKur.Text = LabelDolarAlis.Text;
        }

        private void ButtonDolarSatisKur_Click(object sender, EventArgs e)
        {
            textBoxKur.Text = LabelDolarSatis.Text;
        }

        private void ButtonEuroAlisKur_Click(object sender, EventArgs e)
        {
            textBoxKur.Text = LabelEuroAlis.Text;
        }

        private void ButtonEuroSatisKur_Click(object sender, EventArgs e)
        {
            textBoxKur.Text = LabelEuroSatis.Text;
        }

        private void ButtonDovizBoz_Click(object sender, EventArgs e)
        {
            if (textBoxMiktar.Text == "")
            {
                return;
            }

            double kur, miktar, toplam;
            kur = Convert.ToDouble(textBoxKur.Text);
            miktar = Convert.ToDouble(textBoxMiktar.Text);

            toplam = kur * miktar;
            textBoxToplam.Text = toplam.ToString();
        }

        #region Helpers

        // Kur kısmında olan xml verilerindeki nokta ondalık ayrımını virgül olacak şekilde replace ediyoruz.
        private void textBoxKur_TextChanged(object sender, EventArgs e)
        {
            textBoxKur.Text = textBoxKur.Text.Replace(".", ",");
        }

        #endregion

        private void Form1_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Eğer bir sorun yaşadıysanız lütfen bu numaradan iletişime geçiniz : (0212) 251 8000");
        }
    }
}
