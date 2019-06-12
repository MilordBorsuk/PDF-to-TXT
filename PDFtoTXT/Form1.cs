using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
namespace PDFtoTXT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Wczytaj_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Wybierz plik PDF";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = fdlg.FileName;
            }

        }

        private void Zamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Wykonaj_Click(object sender, EventArgs e)
        {
           string Path = textBox1.Text;
            using (PdfReader reader = new PdfReader(Path))
            {
                StringBuilder text = new StringBuilder();
                for (int i = 1; i <= reader.NumberOfPages; i++)
                {
                    text.Append(PdfTextExtractor.GetTextFromPage(reader, i));
                }
                string lines = "";
               /* SaveFileDialog sdf = new SaveFileDialog();
                sdf.InitialDirectory = @"c:\";
                sdf.RestoreDirectory = true;
                sdf.FileName = ".txt";
                sdf.DefaultExt = ".txt";
                sdf.Filter = "txt files |*.txt||*.txt";
                if (sdf.ShowDialog()== DialogResult.OK)
                {
                    Stream filestream = sdf.OpenFile();
                    StreamWriter sw = new StreamWriter(filestream);

                    sw.Write(textBox1.Text);

                    sw.Close();
                    filestream.Close();

                    textBox1.Clear();
                }*/
               using (var file = new StreamWriter(sdf.InitialDirectory))
                {
                    file.WriteLine(lines);
                    file.Close();
                }
            }
        }
    }
}
