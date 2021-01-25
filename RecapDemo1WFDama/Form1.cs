using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo1WFDama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ButonOlustur();
        }

        private void ButonOlustur() //metot haline getirdim.
        {
            Button[,] buttons = new Button[8, 8];
            int top = 0; //butonların yukarıya olan uzaklıkları
            int left = 0; //butonların sola olan uzaklıkları
            //sütunlar için döngü kuruyorum
            for (int i = 0; i < buttons.GetUpperBound(0); i++) //sütun için
            {
                //satırlar için döngü kuruyorum
                for (int j = 0; j < buttons.GetUpperBound(1); j++) //satır için
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Top = top; //yukarıya olan uzaklığını kendi top değerime eşitledim.bu sayede ilk 8 satır yukarıya sıfır olacak.
                    buttons[i, j].Left = left; //sola olan uzaklığını kendi oluşturduğum lefte eşitledim.
                    left += 50; //her seferinde sola olan uzaklığı butonun genişliği kadar artırıyorum ki, yan yana gelsinler.

                    //aşağıdaki kodlar sayesinde siyah beyaz dama tahtası oluşturmuş oldum.
                    if ((i + j) % 2 == 0) // i+j'nin  2 ye olan modu 0 ise
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }


                    this.Controls.Add(buttons[i, j]); //bu kodlar sayesinde 8 satır 8 sütun toplam 64 buton oluşacak.
                }
                top += 50;
                //ilk 8 buton için yukarıya sıfır yazdım. 
                //8 satır bittikten sonra top 50 artacak bu sayede bir alt satırdan dizilmeye başlayacaklar.
                left = 0;  //yan yana 8 kere koyduktan sonra yanına devam etmesin diye bu kodu yazdım.
            }
        }
    }
}
