using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Philososlocos
{

    public partial class Form1 : Form

    {

  

        public const int NumPhilos = 5;
        public const int Chopsticos = NumPhilos;
   
      //  private Thread[] philosThreads;
      //  private Chops[] chopsticks;




        public Form1()
        {
            InitializeComponent();
     

        }
  
            Philosofos Hobo1 = new Philosofos(Table.Chopstick1, Table.Chopstick2, 1, 1);
            Philosofos Hobo2 = new Philosofos(Table.Chopstick2, Table.Chopstick3, 2, 1);
            Philosofos Hobo3 = new Philosofos(Table.Chopstick3, Table.Chopstick4, 2, 2);
            Philosofos Hobo4 = new Philosofos(Table.Chopstick4, Table.Chopstick5, 3, 1);
            Philosofos thomas = new Philosofos(Table.Chopstick5, Table.Chopstick1, 4, 1);

        void starthobos()
        {

            new Thread(Hobo1.Eat).Start();
            new Thread(Hobo2.Think).Start(); 
            new Thread(Hobo3.Eat).Start();
            new Thread(Hobo4.Think).Start();
            new Thread(thomas.Think).Start();

            if (Thread.CurrentThread.IsAlive)
            {
                while (NumPhilos == 5)
                {
                    if (Hobo1.CState == phState.Eating)
                    {
                        pbPhil0.Image = Image.FromFile("C:/Users/David/Documents/GitHub/Philososofos/Philososlocos/Philososlocos/Resources/hobo2.jpg");
                        lbl1phil0.Text = "Eating";
                    }
                    else if (Hobo1.CState == phState.Thinking)
                    {
                        pbPhil0.Image = Image.FromFile("C:/Users/David/Documents/GitHub/Philososofos/Philososlocos/Philososlocos/Resources/hobo1.jpg");
                        lbl1phil0.Text = "Thinking";
                    }

                    if (Hobo2.CState == phState.Eating)
                    {
                        pbPhil1.Image = Image.FromFile("C:/Users/David/Documents/GitHub/Philososofos/Philososlocos/Philososlocos/Resources/hobo2.jpg");
                        lbl1phil1.Text = "Eating";
                    }
                    else if (Hobo2.CState == phState.Thinking)
                    {
                        pbPhil1.Image = Image.FromFile("C:/Users/David/Documents/GitHub/Philososofos/Philososlocos/Philososlocos/Resources/hobo1.jpg");
                        lbl1phil1.Text = "Thinking";
                    }
                    if (Hobo3.CState == phState.Eating)
                    {
                        pbPhil2.Image = Image.FromFile("C:/Users/David/Documents/GitHub/Philososofos/Philososlocos/Philososlocos/Resources/hobo2.jpg");
                        lbl1phil2.Text = "Eating";
                    }
                    else if (Hobo3.CState == phState.Thinking)
                    {
                        pbPhil2.Image = Image.FromFile("C:/Users/David/Documents/GitHub/Philososofos/Philososlocos/Philososlocos/Resources/hobo1.jpg");
                        lbl1phil2.Text = "Thinking";
                    }
                    if (Hobo4.CState == phState.Eating)
                    {
                        pbPhil3.Image = Image.FromFile("C:/Users/David/Documents/GitHub/Philososofos/Philososlocos/Philososlocos/Resources/hobo2.jpg");
                        lbl1phil4.Text = "Eating";
                    }
                    else if (Hobo4.CState == phState.Thinking)
                    {
                        pbPhil3.Image = Image.FromFile("C:/Users/David/Documents/GitHub/Philososofos/Philososlocos/Philososlocos/Resources/hobo1.jpg");
                        lbl1phil4.Text = "Thinking";
                    }
                    if (thomas.CState == phState.Eating)
                    {
                        pbPhil4.Image = Image.FromFile("C:/Users/David/Documents/GitHub/Philososofos/Philososlocos/Philososlocos/Resources/hobo2.jpg");
                        lbl1phil5.Text = "Eating";
                    }
                    else if (thomas.CState == phState.Thinking)
                    {
                        pbPhil4.Image = Image.FromFile("C:/Users/David/Documents/GitHub/Philososofos/Philososlocos/Philososlocos/Resources/hobo1.jpg");
                        lbl1phil5.Text = "Thinking";
                    }
                }
            }



        }


        private void bbybtn_Click(object sender, EventArgs e)
        {


            starthobos();
    



        }
    }   


}
