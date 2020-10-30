using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationsOfTwoIntegers
{
    class Calculator
    {
        int x;
        int y;

        // business logic
        // new Calculator(); <-- x = 0, y = 1 default constructor
        public Calculator()
        {
            this.x = 0;
            this.y = 0;
        }

        // new Calculator(10, 20); overloaded constructor
        // new Caclulator(10, 0); <--- do not crash
        public Calculator(int x, int y)
        {
            this.AssignFieldValues(x, y, false);
        }

        private void AssignFieldValues(int x, int y, bool useZero)
        {
            this.x = x;
            if (y == 0 && useZero)
            {
                this.y = 1;
            }
            else
            {
                this.y = y;
            }
        }

        // Add(); / Subtract(); / Multiply(); / Divide();
        public int Add()
        {
            this.AssignFieldValues(0, 0, false);
            return (this.x + this.y);
        }

        public int Add(int x, int y)
        {
            this.AssignFieldValues(x, y, false);
            return (this.x + this.y);
        }

        public int Subtract()
        {
            this.AssignFieldValues(0, 0, false);
            return (this.x - this.y);
        }

        public int Subtract(int x, int y)
        {
            this.AssignFieldValues(x, y, false);
            return (this.x - this.y);
        }

        public int Multiply()
        {
            this.AssignFieldValues(0, 0, false);
            return (this.x * this.y);
        }

        public int Multiply(int x, int y)
        {
            this.AssignFieldValues(x, y, false);
            return (this.x * this.y);
        }

        public int Divide()
        {
            this.AssignFieldValues(0, 0, true);
            return (this.x / this.y);
        }

        public int Divide(int x, int y)
        {
            this.AssignFieldValues(x, y, true);
            return (this.x / this.y);
        }

        // < new Calculator(10, 20); / new Calculator(); >

        // Add(10,20); / Subtract(10,20); / Multiply(10,20); / Divide(10,20);
        // < new Calculator(100, 200); / new Calculator(); >

        public void TellMePleaseTheValuesOfTheFields()
        {
            Console.WriteLine($"{x}, {y}");
        }
    }
}
