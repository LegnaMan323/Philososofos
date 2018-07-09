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
            static Philosofos Hobo1 = new Philosofos(Table.Chopstick1, Table.Chopstick2, 1, 1);
          static  Philosofos Hobo2 = new Philosofos(Table.Chopstick2, Table.Chopstick3, 2, 1);
            static Philosofos Hobo3 = new Philosofos(Table.Chopstick3, Table.Chopstick4, 3, 2);
            static Philosofos Hobo4 = new Philosofos(Table.Chopstick4, Table.Chopstick5, 4, 1);
            static Philosofos thomas = new Philosofos(Table.Chopstick5, Table.Chopstick1, 5, 1);

            Thread T1 = new Thread(new ThreadStart(Hobo1.Eat));
        Thread T2 = new Thread(new ThreadStart(Hobo2.Think));
        Thread T3 = new Thread(new ThreadStart(Hobo3.Think));
        Thread T4 = new Thread(new ThreadStart(Hobo4.Eat));
        Thread T5 = new Thread(new ThreadStart(thomas.Think));




 void starthobos()
        {
            T1.Start();
            T2.Start();
            T3.Start();
            T4.Start();
            T5.Start();
   /*//     new Thread(Hobo1.Eat).Start()*/

            if (T1.ManagedThreadId == 1)
            {
                T1.Name = "pt1";
            }
            T1.Name = "pter";

   
            while (Thread.CurrentThread.ThreadState == ThreadState.Running)
            {

                if (T1.ThreadState == ThreadState.Running)

                {
                    pbx_phil1stat.Image = Image.FromFile("C:/Users/David/Documents/GitHub/Philososofos/Philososlocos/Philososlocos/Resources/run.png");
                }
                else 
                {
                   // pbx_phil1stat.Hide();
                }

                if (T1.ThreadState == ThreadState.Running)
                { }


                if (Hobo1.CState == phState.Eating)
                    {
                        pbx_phil1.Image = Image.FromFile("C:/Users/David/Documents/GitHub/Philososofos/Philososlocos/Philososlocos/Resources/hobo2.jpg");
                      //  lbl_phil1.Text = "Eating";
                    }
                else if (Hobo1.CState == phState.Thinking)
                {
                    pbx_phil1.Image = Image.FromFile("C:/Users/David/Documents/GitHub/Philososofos/Philososlocos/Philososlocos/Resources/hobo1.jpg");
                    //  lbl_phil1.Text = "Eating";
                }

                if (Hobo2.CState == phState.Eating)
                {
                    pbx_phil2.Image = Image.FromFile("C:/Users/David/Documents/GitHub/Philososofos/Philososlocos/Philososlocos/Resources/hobo2.jpg");
                    //  lbl_phil1.Text = "Eating";
                }
                else if (Hobo2.CState == phState.Thinking)
                {
                    pbx_phil2.Image = Image.FromFile("C:/Users/David/Documents/GitHub/Philososofos/Philososlocos/Philososlocos/Resources/hobo1.jpg");
                    //  lbl_phil1.Text = "Eating";
                }
                if (Hobo3.CState == phState.Eating)
                {
                    pbx_phil3.Image = Image.FromFile("C:/Users/David/Documents/GitHub/Philososofos/Philososlocos/Philososlocos/Resources/hobo2.jpg");
                    //  lbl_phil1.Text = "Eating";
                }
                else if (Hobo3.CState == phState.Thinking)
                {
                    pbx_phil3.Image = Image.FromFile("C:/Users/David/Documents/GitHub/Philososofos/Philososlocos/Philososlocos/Resources/hobo1.jpg");
                    //  lbl_phil1.Text = "Eating";
                }
                if (Hobo4.CState == phState.Eating)
                {
                    pbx_phil4.Image = Image.FromFile("C:/Users/David/Documents/GitHub/Philososofos/Philososlocos/Philososlocos/Resources/hobo2.jpg");
                    //  lbl_phil1.Text = "Eating";
                }
                else if (Hobo4.CState == phState.Thinking)
                {
                    pbx_phil4.Image = Image.FromFile("C:/Users/David/Documents/GitHub/Philososofos/Philososlocos/Philososlocos/Resources/hobo1.jpg");
                    //  lbl_phil1.Text = "Eating";
                }
                if (thomas.CState == phState.Eating)
                {
                    pbx_phil5.Image = Image.FromFile("C:/Users/David/Documents/GitHub/Philososofos/Philososlocos/Philososlocos/Resources/hobo2.jpg");
                    //  lbl_phil1.Text = "Eating";
                }
                else if (thomas.CState == phState.Thinking)
                {
                    pbx_phil5.Image = Image.FromFile("C:/Users/David/Documents/GitHub/Philososofos/Philososlocos/Philososlocos/Resources/hobo1.jpg");
                    //  lbl_phil1.Text = "Eating";
                }

            }



        }

        private void start_btn_Click(object sender, EventArgs e)
        {

        
            Stop_btn.Enabled = true;
            Enabled = false;
            Thread mt = new Thread(new ThreadStart(starthobos));
              mt.Start();
        //    starthobos();
           //mt.Join();
        if(mt.ThreadState == ThreadState.Running)
            {
                mt.Priority = ThreadPriority.Highest;
            }

        }

        private void Stop_btn_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.Interrupt();
        }
    }   


}
