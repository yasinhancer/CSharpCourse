using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo1WindowsFormDama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //birden fazla buton yapmak için for döngüsü de kullanabilir. ancak üst üste olur hepsi.
            //burda array lerin çok boyutlu yapısından yararlanacağım.


            Button[,] buttons 0= new Button[8,8]; //8 sütun 8 satır toplam 64 tane buton oluşturdum.
            button.Width = 50; //eni
            button.Height = 50; //yükseklik / boy
            button.Text = "MyButton"; //buton üstüne bişey yazdım.
            this.Controls.Add(button); //bu kod sayesinde butonu ekrana koydum
        }
    }
}
