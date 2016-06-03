using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace k_nn
{
    public partial class Form1 : Form
    {
        public List<Veri> satirlarEgitim = new List<Veri>();
          List<Veri> satirlarTest = new List<Veri>();
          List<string> dogruEtiket = new List<string>();
        public int rowCount;
        public int colCount;
        public double ortalama = 0;
        public double hesapla = 0;
        private Excel.Application ExcelNesnesi = null;
        public Form1()
        {
            InitializeComponent();
            ExcelNesnesi = new Excel.Application();
            if (ExcelNesnesi == null)
            {
                MessageBox.Show("Problem! Dosya Açılamadı.");
                System.Windows.Forms.Application.Exit();
            }
        }

       
        private void yazdirBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                uzakliklariHesapla();

                for (int k = 0; k <satirlarTest.Count; k++)
                {
                    int i = dataGridView1.Rows.Add();
                    i = 0;
                    int t;
                    for (t = 0; t < satirlarTest[k].degerler.Count; t++)
                    {
                        double deger = satirlarTest[k].degerlerGet(t);
                        dataGridView1.Rows[k].Cells[t].Value = deger.ToString();
                        
                    }
                    dataGridView1.Rows[k].Cells[t].Value = satirlarTest[k].etiketGet().ToString();
                    i++;
                }
                karsilastirma();

                
            }
            else
                MessageBox.Show("Lütfen k değerini boş girmeyiniz...");          

        }
        public void karsilastirma()
        {
            MessageBox.Show("Test Veri Sayısı ="+satirlarTest.Count);
            int sonucu=0;
            for (int i = 0; i < satirlarTest.Count; i++)
            {
                if (satirlarTest[i].etiketGet()==dogruEtiket[i])
                {
                    sonucu++;
                }
            }
            MessageBox.Show("Test Veri Etiketleme =" + satirlarTest.Count + " de " + sonucu+"YÜZDE-->%"+(Convert.ToDouble(sonucu)/(Convert.ToDouble( satirlarTest.Count))*100));
        }

        private void egitimBtn_Click(object sender, EventArgs e)
        {
            if (textBoxSutunS.Text != "" && comboBox1.Text != "" && textBox1.Text!="")
            {


                egitimBtn.Enabled = false;


                int sutunSayisi = 0;
                sutunSayisi = Convert.ToInt32(textBoxSutunS.Text);

                dataGridView1.ColumnCount = sutunSayisi;
                dataGridView1.ColumnHeadersVisible = true;

                // Sütun başlığına ait style tanımlıyoruz.
                DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

                columnHeaderStyle.BackColor = Color.Beige;
                columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
                dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

                for (int i = 0; i < sutunSayisi; i++)
                {
                    dataGridView1.Columns[i].Name = "X" + i;
                }
                

                this.openFileDialog1.FileName = "*.xls";
                if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Excel.Workbook theWorkbook =
                    ExcelNesnesi.Workbooks.Open(
                    openFileDialog1.FileName,
                    Type.Missing,
                    Type.Missing,
                    Type.Missing,
                    Type.Missing,
                    Type.Missing,
                    Type.Missing,
                    Type.Missing,
                    Type.Missing,
                    Type.Missing,
                    Type.Missing,
                    Type.Missing,
                    Type.Missing,
                    Type.Missing,
                    Type.Missing);


                    Excel.Sheets sheets = theWorkbook.Worksheets;

                    Excel.Worksheet worksheet = (Excel.Worksheet)sheets.get_Item(1);

                    Excel.Range xlRange = worksheet.UsedRange;
                    rowCount = xlRange.Rows.Count;
                    colCount = xlRange.Columns.Count;

                    for (int sat = 2; sat < rowCount + 1; sat++)
                    {

                        string dgr;
                        Veri veri = new Veri();
                        int sut;
                        for (sut = 1; sut <= colCount - 1; sut++)//Veri Sınıfındaki List ti dolduguruyor.
                        {
                            dgr = Convert.ToString(xlRange.Cells[sat, sut].Value2);
                            veri.degerlerSet(xlRange.Cells[sat, sut].Value2);
                        }

                        veri.etiketSet(Convert.ToString(xlRange.Cells[sat, sut].Value2));
                        satirlarEgitim.Add(veri);

                    }
                 
                }
            }
            else
                MessageBox.Show("Lütfen İlgili Alanları Giriniz...");

        }

        private void testBtn_Click(object sender, EventArgs e)
        {
            testBtn.Enabled = false;
              this.openFileDialog1.FileName = "*.xls";
              if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
              {
                  Excel.Workbook theWorkbook =
                  ExcelNesnesi.Workbooks.Open(
                  openFileDialog1.FileName,
                  Type.Missing,
                  Type.Missing,
                  Type.Missing,
                  Type.Missing,
                  Type.Missing,
                  Type.Missing,
                  Type.Missing,
                  Type.Missing,
                  Type.Missing,
                  Type.Missing,
                  Type.Missing,
                  Type.Missing,
                  Type.Missing,
                  Type.Missing);


                  Excel.Sheets sheets = theWorkbook.Worksheets;

                  Excel.Worksheet worksheet = (Excel.Worksheet)sheets.get_Item(1);

                  Excel.Range xlRange = worksheet.UsedRange;
                  rowCount = xlRange.Rows.Count;
                  colCount = xlRange.Columns.Count;

                  for (int sat = 2; sat < rowCount + 1; sat++)
                  {

                      string dgr;
                      Veri veri = new Veri();
                      int sut;
                      for (sut = 1; sut < colCount; sut++)//Veri Sınıfındaki List ti dolduguruyor.
                      {
                          dgr = Convert.ToString(xlRange.Cells[sat, sut].Value2);
                          veri.degerlerSet(xlRange.Cells[sat, sut].Value2);
                      }
                      dogruEtiket.Add(Convert.ToString(xlRange.Cells[sat, sut].Value2));
                     // veri.etiketSet(Convert.ToString(xlRange.Cells[sat, sut].Value2));
                      satirlarTest.Add(veri);

                  }
              }
        }
      
       
       public void uzakliklariHesapla()
        {
            for (int sat1 = 0; sat1 < satirlarTest.Count; sat1++)
            {

                for (int sat2 = 0; sat2 < satirlarEgitim.Count; sat2++)
                {
                    Oklit oklit = new Oklit();
                    Manhattan manhattan = new Manhattan();
                    Minkovski minkovski = new Minkovski();

                    oklit.sonrakiBaginti = manhattan;
                    manhattan.sonrakiBaginti = minkovski;

                    oklit.islem(comboBox1.Text, satirlarEgitim[sat2], satirlarTest[sat1]);

                }
                            
                UzaklikSirala siralama = new UzaklikSirala();
                siralama.sirala(satirlarEgitim);

                EtiketBelirle etiketle = new EtiketBelirle(this);
                int k = Convert.ToInt32(textBox1.Text);
                

                satirlarTest[sat1].etiketSet(etiketle.etiketBelirle(satirlarEgitim,k));

                
            }
           
        }
      

      
     
        
    }
   
}



