using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chart_Uygulama_Ornegi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Series["Kitap"].Points.AddXY("Akdeniz", 5);
            chart1.Series["Kitap"].Points.AddXY("Ege", 8);
            chart1.Series["Kitap"].Points.AddXY("Marmara", 9);
            chart1.Series["Kitap"].Points.AddXY("Karadeniz", 4);
            chart1.Series["Kitap"].Points.AddXY("İç Anadolu", 3);
            chart1.Series["Kitap"].Points.AddXY("Doğu", 2);
            chart1.Series["Kitap"].Points.AddXY("Güneydoğu", 1);

        }
    }
}
