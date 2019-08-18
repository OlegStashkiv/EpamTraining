namespace Partial_Task2_Task5
{
    using System;
    using Partial_Task2;

    class Task5 : IRun
    {
        public void Run()
        {
            double r1, r2, f1, f2;
            Console.Write("Введiть явну частину першого числа: ");
            r1 = Validation.Valid(Console.ReadLine());
            Console.Write("Введiть уявну частину першого числа (тiльки число): ");
            f1 = Validation.Valid(Console.ReadLine());
            Console.Write("Введiть явну частину другого числа: ");
            r2 = Validation.Valid(Console.ReadLine());
            Console.Write("Введiть уявну частину другого числа (тiльки число): ");
            f2 = Validation.Valid(Console.ReadLine());

            ComplexNumber a = new ComplexNumber(r1,f1);
            ComplexNumber b = new ComplexNumber(r2, f2);

            ComplexNumber multiplication = a * b;
            Console.WriteLine("Результат множення:  " + multiplication);
            
            ComplexNumber division = a / b;
            Console.WriteLine("Результат дiлення:  " + division);
        }
    }

    class ComplexNumber
    {
        #region variables
        public double real;
        double fiction;
        #endregion

        #region constructor
        public ComplexNumber()
        {
            this.real = 0.0;
            this.fiction = 0.0;
        }
        public ComplexNumber(double real, double fiction)
        {
            this.real = real;
            this.fiction = fiction;
        }
        #endregion

        #region overloaded methods
        public static ComplexNumber operator * (ComplexNumber a, ComplexNumber b)
        {
            ComplexNumber res = new ComplexNumber();
            res.real = a.real * b.real - a.fiction * b.fiction;
            res.fiction = a.real * b.fiction + a.fiction * b.real;
            return res;
        }
        public static ComplexNumber operator / (ComplexNumber a, ComplexNumber b)
        {
            ComplexNumber res = new ComplexNumber();
            res.real = (a.real * b.real + a.fiction * b.fiction) / (Math.Pow(b.real, 2) + Math.Pow(b.fiction, 2));
            res.fiction = (a.fiction * b.real - a.real * b.fiction) / (Math.Pow(b.real, 2) + Math.Pow(b.fiction, 2));
            return res;
        }
        #endregion

        #region overide methods
        public override string ToString()
        {
            if (this.fiction < 0)
            {
                return String.Format("{0:F2}{1:F2}i", this.real, this.fiction);
            }
            else if (this.fiction == 1)
            {
                return String.Format("{0:F2} + i", this.real);
            }
            return String.Format("{0:F2} + {1:F2}i", this.real, this.fiction);
        }
        #endregion
    }
}
