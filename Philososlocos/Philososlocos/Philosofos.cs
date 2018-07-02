using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Philososlocos
{


        public enum phState
    {
        Eating,
        Waiting,
        Thinking
    }



    class Philosofos
    {


        Random rand = new Random();

        public int phID { get; set; }
       // bool thinking = false;
     //   bool eating = false;  
     

        readonly int StarvationThreshold;

        public phState CState { get; set; }


        int contThinkCount = 0;

        public Philosofos(Chops rightChop, Chops leftChop, int ID, int starvThreshold)
        {
            RightChop = rightChop;
            LeftChop = leftChop;
            phID = ID;
            CState = phState.Thinking;
            StarvationThreshold = starvThreshold;
        }

        public void PickSticks()
        {


        }



            public void Eat()
        { 
            
            if (TakeChopInRightHand())
            {
              
                if (TakeChopInLeftHand())
                {
                  
                    this.CState = phState.Eating;
                    
              //      Console.WriteLine("(:::) {0} is eating..with {1} and {2}", phID, RightChop.ForkID, LeftChop.ForkID);
                    Thread.Sleep(rand.Next(5000, 10000));

                    contThinkCount = 0;

                    // place the forks back
                    RightChop.Put();
                    LeftChop.Put();
                }
       
                else
                {
                  
                    Thread.Sleep(rand.Next(100, 400));
                    if (TakeChopInLeftHand())
                    {
            
                        this.CState = phState.Eating;
                  //      Console.WriteLine("(:::) {0} is eating..with {1} and {2}", phID, RightChop.ForkID, LeftChop.ForkID);
                        Thread.Sleep(rand.Next(5000, 10000));

                        contThinkCount = 0;

                        RightChop.Put();
                        LeftChop.Put();
                    }
         
                    else
                    {
                        RightChop.Put();
                    }
                }
            }
         
            else
            {
                if (TakeChopInLeftHand())
                {
              
                    Thread.Sleep(rand.Next(100, 400));
                    if (TakeChopInRightHand())
                    {
                      
                        this.CState = phState.Eating;
                      //  Console.WriteLine("(:::) {0} is eating..with {1} and {2}", Name, RightFork.ForkID, LeftFork.ForkID);
                        Thread.Sleep(rand.Next(5000, 10000));

                        contThinkCount = 0;

                        RightChop.Put();
                        LeftChop.Put();
                    }
                    else
                    {
                        LeftChop.Put();
                    }
                }
            }

            Think();
            
        }

        public void Think()
        {
            this.CState = phState.Thinking;
            Console.WriteLine("^^*^^ {0} is thinking...on {1}", phID, Thread.CurrentThread.Priority.ToString());
            Thread.Sleep(rand.Next(2500, 20000));
            contThinkCount++;

            if (contThinkCount > StarvationThreshold)
            {
                Console.WriteLine(":ooooooooooooooooooooooooooooooooooooooooooooooo: {0} is starving", phID);
            }

            Eat();

        }



        private bool TakeChopInLeftHand()
        {
            return LeftChop.Take(phID);
        }

        private bool TakeChopInRightHand()
        {
            return RightChop.Take(phID);
        }


        // defines the right and the left side fork of a philosopher
        public readonly Chops RightChop;
        public readonly Chops LeftChop;


      
    }


}
