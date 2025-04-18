using System.Text.Json;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
namespace JsonHomework1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

          
            string jsonDosyaYolu = "urunler.json";
            if (File.Exists(jsonDosyaYolu))
            {
                string jsonString = File.ReadAllText(jsonDosyaYolu);

                
                List<Urun> urunler = JsonSerializer.Deserialize<List<Urun>>(jsonString);

                
                foreach (var urun in urunler)
                {
                    listBox1.Items.Add($"Ürün: {urun.UrunAdi} - Fiyat: {urun.Fiyat} TL - Kategori: {urun.Kategori}");
                    listBox1.Items.Add($"Marka: {urun.Marka}, Açıklama: {urun.Açıklama}, Stok: {urun.StokMiktari}");
                    listBox1.Items.Add($"Özellikler: {urun.Ozellikler.Islemci}, {urun.Ozellikler.RAM}, {urun.Ozellikler.Depolama}");
                    listBox1.Items.Add("--------------------------------------------------------");
                }
            }
            else
            {
                MessageBox.Show("JSON dosyası bulunamadı.");
            }
        }
    }
    public class Ozellikler
    {
        public string Islemci { get; set; }
        public string RAM { get; set; }
        public string Depolama { get; set; }
        public string EkranKarti { get; set; }
        public string Tasarim { get; set; }
        public string Renk { get; set; }
        public string KullaniciTipi { get; set; }
        public string EkranBoyutu { get; set; }
        public string Kamera { get; set; }
        public string PilKapasitesi { get; set; }
        public string SesTeknolojisi { get; set; }
        public string PilSüresi { get; set; }
        public string Baglantı { get; set; }
    }

    public class Urun
    {
        public string UrunAdi { get; set; }
        public decimal Fiyat { get; set; }
        public string Kategori { get; set; }
        public string Marka { get; set; }
        public string Açıklama { get; set; }
        public int StokMiktari { get; set; }
        public Ozellikler Ozellikler { get; set; }
    }


}
