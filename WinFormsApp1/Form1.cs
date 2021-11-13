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
            ochered();
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
                txtOut.Text = "Конец очереди. Автомат пуст";
                pictureBox1.Image = null;
                return;
            }

            var Drinkable = this.DrinkablesList[0];
            this.DrinkablesList.RemoveAt(0);
            txtOut.Text = Drinkable.GetInfo();

            switch (Drinkable.GetTYPE())
            {
                case "яблоко":              
                    pictureBox1.Image = Properties.Resources.apple;
                    break;
                case "виноград":
                    pictureBox1.Image = Properties.Resources.grape;
                    break;
                case "апельсин":
                    pictureBox1.Image = Properties.Resources.orange;
                    break;
                case "кола":
                    pictureBox1.Image = Properties.Resources.cola;              
                    break;
                case "спрайт":
                    pictureBox1.Image = Properties.Resources.sprite;
                    break;
                case "фанта":
                    pictureBox1.Image = Properties.Resources.fanta;
                    break;
                case "водка":
                    pictureBox1.Image = Properties.Resources.vodka;
                    break;
                case "вино":
                    pictureBox1.Image = Properties.Resources.wine;
                    break;
                case "пиво":
                    pictureBox1.Image = Properties.Resources.beer;
                    break;

            }

            ShowInfo();
            ochered();
        }
        
       private void ochered()
       {
            int count = 1;
            string s = "";
           
            foreach (var fruit in this.DrinkablesList)
            {

                if (fruit is Juice)
                {
                    s = s + count + " сок\n";
                    count++;
                }
                else if (fruit is Gas)
                {
                    s = s + count + " газировка\n";
                    count++;
                }
                else if (fruit is Alco)
                {
                    s = s + count + " алкоголь\n";
                    count++;
                }
            }
            richTextBox2.Text = s;

            if (this.DrinkablesList.Count == 0)
            {
                richTextBox2.Text = "Конец очереди. Автомат пуст";
            }
        }
       

    }
}
