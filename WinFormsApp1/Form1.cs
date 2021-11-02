using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
//using CodeFile1;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        List<Drinkables> DrinkablesList = new List<Drinkables>();
        public Form1()
        {
            InitializeComponent();
            ShowInfo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DrinkablesList.Clear();
          //  var r = new Random();
            



            var rnd = new Random();
            for (var i = 0; i < 10; ++i)
            {
                switch (rnd.Next() % 3) 
                {
                    case 0: 
                        this.DrinkablesList.Add(Juice.Generate());
                        break;
                    case 1: 
                        this.DrinkablesList.Add(Gas.Generate());
                        break;
                    case 2: 
                        this.DrinkablesList.Add(Alco.Generate());
                        break;
                        
                }
            }
            ShowInfo();
        }

        private void ShowInfo()
        {
            int JuiceCount = 0;
            int GasCount = 0;
            int AlcoCount = 0;

            foreach (var fruit in this.DrinkablesList)
            {

                if (fruit is Juice) 
                {
                    JuiceCount += 1;
                }
                else if (fruit is Gas)
                {
                    GasCount += 1;
                }
                else if (fruit is Alco)
                {
                    AlcoCount += 1;
                }
            }

            richTextBox1.Text = "Сок\tГазировка\tАлкоголь";
            richTextBox1.Text += "\n";
            richTextBox1.Text += String.Format("{0}\t{1}\t\t{2}", JuiceCount, GasCount, AlcoCount);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.DrinkablesList.Count == 0)
            {
                txtOut.Text = "Автомат пуст";
                return;
            }

            var Drinkable = this.DrinkablesList[0];
            this.DrinkablesList.RemoveAt(0);
            txtOut.Text = Drinkable.GetInfo();

            ShowInfo();
        }
    }
}
