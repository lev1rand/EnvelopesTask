using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnvelopesTask.Classes.Objects;

namespace EnvelopesTask
{
    class Program
    {
        static void Main(string[] args)
        {
           Parallelogram envelopeFirst = new Parallelogram(2, 3, 30, 150);
            /*Parallelogram envelopeSecond = new Parallelogram(4, 5, 60, 120);
            Square envelope1 = new Square(24, 24, 90, 90);
            Square envelope2 = new Square(5, 5, 90, 90);

            if (envelope1.CalculateDiagonal() <= envelope2.CalculateDiagonal() &&  //check 1st variant
                envelope1.CalculateHeight() <= envelope2.CalculateHeight())
            {
                Console.WriteLine("The first envelope can be placed in second");
            }
            else
            {
                if (envelope1.CalculateDiagonal() <= envelope2.CalculateHeight() && //turn figure over, then check again
                    envelope1.CalculateHeight() <= envelope2.CalculateDiagonal())
                {
                    Console.WriteLine("The first envelope can be placed in second");
                }
                else
                    if (envelope1.CalculateDiagonal() >= envelope2.CalculateDiagonal() && //check 2d variant
                        envelope1.CalculateHeight() >= envelope2.CalculateHeight())
                {
                    Console.WriteLine("The second envelope can be placed in first");
                }
                else
                {
                    if (envelope1.CalculateDiagonal() >= envelope2.CalculateHeight() &&//turn figure over, then check again
                        envelope1.CalculateHeight() >= envelope2.CalculateDiagonal())
                    {
                        Console.WriteLine("The second envelope can be placed in first");
                    }
                    else
                    {
                        Console.WriteLine("None of the envelopes can be placed in another!");
                    }
                }
            }*/
            Console.WriteLine(envelopeFirst.GetType());
            Console.ReadKey();
        }
    }
}