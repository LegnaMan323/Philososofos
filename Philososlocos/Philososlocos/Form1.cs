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
            static Philosofos Hobo1 = new Philosofos(Table.Chopstick5, Table.Chopstick1, 1, 8);
          static  Philosofos Hobo2 = new Philosofos(Table.Chopstick1, Table.Chopstick2, 2, 5);
            static Philosofos Hobo3 = new Philosofos(Table.Chopstick2, Table.Chopstick3, 3, 7);
            static Philosofos Hobo4 = new Philosofos(Table.Chopstick3, Table.Chopstick4, 4, 4);
            static Philosofos thomas = new Philosofos(Table.Chopstick4, Table.Chopstick5, 5, 6);

            Thread T1 = new Thread(new ThreadStart(Hobo1.Think));
        Thread T2 = new Thread(new ThreadStart(Hobo2.Think));
        Thread T3 = new Thread(new ThreadStart(Hobo3.Eat));
        Thread T4 = new Thread(new ThreadStart(Hobo4.Think));
        Thread T5 = new Thread(new ThreadStart(thomas.Eat));




 void starthobos()
        {
            T1.Start();
            if (T1.ThreadState == ThreadState.Running)

            {
                pbx_phil1stat.Image = Image.FromFile("C:/Users/David/Documents/GitHub/Philososofos/Philososlocos/Philososlocos/Resources/run.png");
            }
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
                                                                
                if (Hobo1.CState == phState.Eating && Hobo1.LeftChop.ChState == ChopState.InUse && Hobo1.RightChop.ChState == ChopState.InUse)
                    {
                        pbx_phil1.Image = Image.FromFile("C:/Users/David/Documents/GitHub/Philososofos/Philososlocos/Philososlocos/Resources/hobo2.jpg");
                      //  lbl_phil1.Text = "Eating";
          
        
                }

                if (Hobo1.CState == phState.Thinking)
                {
                    pbx_phil1.Image = Image.FromFile("C:/Users/David/Documents/GitHub/Philososofos/Philososlocos/Philososlocos/Resources/hobo1.jpg");
                    //  lbl_phil1.Text = "Eating";
                
                }
                if (Hobo1.CState == phState.Waiting)
                {
                    pbx_phil1.Image = Image.FromFile("C:/Users/David/Documents/GitHub/Philososofos/Philososlocos/Philososlocos/Resources/Pentagon.jpg");
                    //  lbl_phil1.Text = "Eating";
                }
                if (Hobo2.CState == phState.Eating && Hobo2.LeftChop.ChState == ChopState.InUse && Hobo2.RightChop.ChState == ChopState.InUse)
                {
                    pbx_phil2.Image = Image.FromFile("C:/Users/David/Documents/GitHub/Philososofos/Philososlocos/Philososlocos/Resources/hobo2.jpg");
                    //  lbl_phil1.Text = "Eating";
         
                }
                if (Hobo2.CState == phState.Thinking)
                {
                    pbx_phil2.Image = Image.FromFile("C:/Users/David/Documents/GitHub/Philososofos/Philososlocos/Philososlocos/Resources/hobo1.jpg");
                    //  lbl_phil1.Text = "Eating";
                }
                if (Hobo3.CState == phState.Eating && Hobo3.LeftChop.ChState == ChopState.InUse && Hobo3.RightChop.ChState == ChopState.InUse)
                {
                    pbx_phil3.Image = Image.FromFile("C:/Users/David/Documents/GitHub/Philososofos/Philososlocos/Philososlocos/Resources/hobo2.jpg");
                    //  lbl_phil1.Text = "Eating";
                }
                if (Hobo3.CState == phState.Thinking)
                {
                    pbx_phil3.Image = Image.FromFile("C:/Users/David/Documents/GitHub/Philososofos/Philososlocos/Philososlocos/Resources/hobo1.jpg");
                    //  lbl_phil1.Text = "Eating";
                }
                if (Hobo4.CState == phState.Eating)
                {
                    pbx_phil4.Image = Image.FromFile("C:/Users/David/Documents/GitHub/Philososofos/Philososlocos/Philososlocos/Resources/hobo2.jpg");
                    //  lbl_phil1.Text = "Eating";
                }
                if (Hobo4.CState == phState.Thinking)
                {
                    pbx_phil4.Image = Image.FromFile("C:/Users/David/Documents/GitHub/Philososofos/Philososlocos/Philososlocos/Resources/hobo1.jpg");
                    //  lbl_phil1.Text = "Eating";
                }
                if (thomas.CState == phState.Eating)
                {
                    pbx_phil5.Image = Image.FromFile("C:/Users/David/Documents/GitHub/Philososofos/Philososlocos/Philososlocos/Resources/hobo2.jpg");
                    //  lbl_phil1.Text = "Eating";
                }
                if (thomas.CState == phState.Thinking)
                {
                    pbx_phil5.Image = Image.FromFile("C:/Users/David/Documents/GitHub/Philososofos/Philososlocos/Philososlocos/Resources/hobo1.jpg");
                    //  lbl_phil1.Text = "Eating";
                }

            }



        }

        void checkchops()
        {
            while(Thread.CurrentThread.IsAlive)
            {
                pbx_chork5.Image = Image.FromFile("C:/Users/David/Documents/GitHub/Philososofos/Philososlocos/Philososlocos/Resources/chopo.png");
                pbx_chork1.Image = Image.FromFile("C:/Users/David/Documents/GitHub/Philososofos/Philososlocos/Philososlocos/Resources/chopo.png");
                pbx_chork2.Image = Image.FromFile("C:/Users/David/Documents/GitHub/Philososofos/Philososlocos/Philososlocos/Resources/chopo.png");
                pbx_chork3.Image = Image.FromFile("C:/Users/David/Documents/GitHub/Philososofos/Philososlocos/Philososlocos/Resources/chopo.png");
                pbx_chork4.Image = Image.FromFile("C:/Users/David/Documents/GitHub/Philososofos/Philososlocos/Philososlocos/Resources/chopo.png");


                if (Hobo1.CState == phState.Eating && Hobo1.LeftChop.ChState == ChopState.InUse && Hobo1.RightChop.ChState == ChopState.InUse)

                {


                    if (Hobo1.LeftChop.ChState == ChopState.InUse)
                    {
                      //  pbx_chork1.Image = Image.FromFile("C:/Users/David/Documents/GitHub/Philososofos/Philososlocos/Philososlocos/Resources/bnk.png");

                    }
                                      
                    if (Hobo1.RightChop.ChState == ChopState.InUse)
                    {
                        pbx_chork5.Image = Image.FromFile("C:/Users/David/Documents/GitHub/Philososofos/Philososlocos/Philososlocos/Resources/bnk.png");
                    }
                  

                    
                }
                if (Hobo2.CState == phState.Eating && Hobo2.LeftChop.ChState == ChopState.InUse && Hobo2.RightChop.ChState == ChopState.InUse)
                {
                    if (Hobo2.LeftChop.ChState == ChopState.InUse)
                    {
                        pbx_chork2.Image = Image.FromFile("C:/Users/David/Documents/GitHub/Philososofos/Philososlocos/Philososlocos/Resources/bnk.png");

                    }

                    if (Hobo2.RightChop.ChState == ChopState.InUse)
                    {
                        pbx_chork1.Image = Image.FromFile("C:/Users/David/Documents/GitHub/Philososofos/Philososlocos/Philososlocos/Resources/bnk.png");
                    }
                }
                if (Hobo3.CState == phState.Eating && Hobo3.LeftChop.ChState == ChopState.InUse && Hobo3.RightChop.ChState == ChopState.InUse)
                {
                    if (Hobo3.LeftChop.ChState == ChopState.InUse)
                    {
                        pbx_chork3.Image = Image.FromFile("C:/Users/David/Documents/GitHub/Philososofos/Philososlocos/Philososlocos/Resources/bnk.png");

                    }

                    if (Hobo3.RightChop.ChState == ChopState.InUse)
                    {
                        pbx_chork2.Image = Image.FromFile("C:/Users/David/Documents/GitHub/Philososofos/Philososlocos/Philososlocos/Resources/bnk.png");
                    }
                }
                if (Hobo4.CState == phState.Eating && Hobo4.LeftChop.ChState == ChopState.InUse && Hobo4.RightChop.ChState == ChopState.InUse)
                {
                    if (Hobo4.LeftChop.ChState == ChopState.InUse)
                    {
                        pbx_chork4.Image = Image.FromFile("C:/Users/David/Documents/GitHub/Philososofos/Philososlocos/Philososlocos/Resources/bnk.png");

                    }
                    
                    if (Hobo4.RightChop.ChState == ChopState.InUse)
                    {
                        pbx_chork3.Image = Image.FromFile("C:/Users/David/Documents/GitHub/Philososofos/Philososlocos/Philososlocos/Resources/bnk.png");
                    }
                }
                if (thomas.CState == phState.Eating && thomas.LeftChop.ChState == ChopState.InUse && thomas.RightChop.ChState == ChopState.InUse)
                {
                    if (thomas.LeftChop.ChState == ChopState.InUse)
                    {
                        pbx_chork5.Image = Image.FromFile("C:/Users/David/Documents/GitHub/Philososofos/Philososlocos/Philososlocos/Resources/bnk.png");

                    }
                    
                    if (Hobo3.RightChop.ChState == ChopState.InUse)
                    {
                        pbx_chork4.Image = Image.FromFile("C:/Users/David/Documents/GitHub/Philososofos/Philososlocos/Philososlocos/Resources/bnk.png");
                    }
                }
            }
        }

        private void start_btn_Click(object sender, EventArgs e)
        {

        
            Stop_btn.Enabled = true;
            Enabled = false;
            Thread mt = new Thread(new ThreadStart(starthobos));
              mt.Start();
            Thread pt = new Thread(new ThreadStart(checkchops));
            pt.Start();
          // pt.Join();
          
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
