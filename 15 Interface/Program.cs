using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithProgression arithProgression = new ArithProgression();
            arithProgression.setStart(6);
            for (int i = 0; i < 5; i++)
            {
                arithProgression.getNext();
            }
            arithProgression.reset();
            arithProgression.getNext();
            Console.WriteLine();
            GeomProgression geomProgression = new GeomProgression();
            geomProgression.setStart(6);
            for (int i = 0; i < 5; i++)
            {
                geomProgression.getNext();
            }
            geomProgression.reset();
            geomProgression.getNext();
            Console.ReadKey();
        }
    }
    interface ISeries
    {
        void setStart(int x);
        void getNext();
        void reset();
    }
    class ArithProgression : ISeries
    {
        private const int step = 6;
        private int X;
        public int Unit { get; set; }
        public void getNext()
        {
            Unit += step;
            Console.WriteLine(Unit);
        }

        public void reset()
        {
            Unit = X;
        }

        public void setStart(int x)
        {
            X = x;
            Unit = X;
        }
    }
    class GeomProgression : ISeries
    {
        private const int step = 6;
        private int X;
        public int Unit { get; set; }
        public void getNext()
        {
            Unit *= step;
            Console.WriteLine(Unit);
        }

        public void reset()
        {
            Unit = X;
        }

        public void setStart(int x)
        {
            X = x;
            Unit = X;
        }
    }
}
