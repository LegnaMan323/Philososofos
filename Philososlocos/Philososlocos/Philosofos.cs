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


        Random random = new Random();

        public int phID { get; set; }
       // bool thinking = false;
     //   bool eating = false;  
     

        readonly int StarvationThreshold;

        public phState CState { get; set; }



        public readonly Chops RightChop;
        public readonly Chops LeftChop;



        int contThinkCount = 0;

        public Philosofos(Chops rightChop, Chops leftChop, int ID, int Starvationlim)
        {
            RightChop = rightChop;
            LeftChop = leftChop;
            phID = ID;
            CState = phState.Thinking;
            StarvationThreshold = Starvationlim;
        }



     
        public void Eat()
        { 
            
            if (TakeChopInRightHand())
            {
              
                if (TakeChopInLeftHand())
                {
                  
                    this.CState = phState.Eating;
                    
              //     a philoso is eating..with {chop} and {chop2}" phID
                    Thread.Sleep(random.Next(500000, 1000000));

                    contThinkCount = 0;

                    // place the forks back
                    RightChop.Put();
                    LeftChop.Put();
                }
       
                else
                {
                    //wait
                    this.CState = phState.Waiting;
              
                    if (TakeChopInLeftHand())
                    {
            //
                        this.CState = phState.Eating;
                        Thread.Sleep(random.Next(500000, 1000000));

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
                //wait for other chop
                if (TakeChopInLeftHand())
                {
                    this.CState = phState.Waiting;
                
                    if (TakeChopInRightHand())
                    {
                      
                        this.CState = phState.Eating;
          //
                        Thread.Sleep(random.Next(500000, 10000000));

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
        // philoso is thinking
            Thread.Sleep(random.Next(2500, 10000));
            contThinkCount++;

            if (contThinkCount > StarvationThreshold)
            {
               //starvingphiloso
            }

            Eat();

        }


      

        public void Wait()
        {
            this.CState = phState.Waiting;
            Thread.Sleep(random.Next(100, 400));
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

      
    }


}
