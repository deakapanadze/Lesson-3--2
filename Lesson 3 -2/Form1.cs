using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lesson_3__2
{
    public partial class Form1 : Form
    {
        Guy joe;
        Guy bob;
        int bank = 100;

        public Form1()
        {
            InitializeComponent();

            bob = new Guy() {Cash = 100, Name = "Bob" };
            joe = new Guy() {Cash = 50, Name = "Joe" };
            UpdateForm();



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*  Clown oneClown = new Clown();
             oneClown.Name = "Boffo";
             oneClown.Height = 14;
             oneClown.TalkAboutYourself();

             Clown anotherClown = new Clown();
             anotherClown.Name = "dea";
             anotherClown.Height = 16;
             anotherClown.TalkAboutYourself();

             Clown Clown3 = new Clown();
             Clown3.Name = anotherClown.Name;
             Clown3.Height = oneClown.Height - 3;
             Clown3.TalkAboutYourself();

             int t = m.chkTemp();
             if (t> 160)
             {
                 T tb = new T();

             }
            */

        }

        public void UpdateForm()
        {
            joesCashLabel.Text = joe.Name + "has $" + joe.Cash;
            bobsCashLabel.Text = bob.Name + "has $" + bob.Cash;
            bankCashLabel.Text = "The bank has $" + bank;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bank >= 10)
            {
                bank -= joe.ReceiveCash(10);
                UpdateForm();
            }else
            {
                MessageBox.Show("the bank is out og money");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);
            UpdateForm();
        }


       
    }
}
