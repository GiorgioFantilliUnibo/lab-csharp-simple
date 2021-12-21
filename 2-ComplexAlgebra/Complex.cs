namespace ComplexAlgebra
{
    using System;
    /// TODO: Model Complex numbers in an object-oriented way and implement this class.
    /// TODO: In other words, you must provide a means for:
    /// TODO: * summing up or subtracting two complex numbers
    /// TODO: * representing a complex number as a string or the form Re +/- iIm
    /// TODO:     - e.g. via the ToString() method
    /// TODO: * checking whether two complex numbers are equal or not
    /// TODO:     - e.g. via the Equals(object) method
    /// 
    /// <summary>
    /// A type for representing Complex numbers.
    /// </summary>
    public class Complex
    {
        /// <summary>
        /// Build a new <see cref="Complex"/> number.
        /// </summary>
        /// <param name="real">the real part of the number.</param>
        /// <param name="imaginary">the imaginary part of the number.</param>
        public Complex(double real, double imaginary)
        {
            this.Real = real;
            this.Imaginary = imaginary;
        }

        /// <summary>
        /// Get real part of the complex number.
        /// </summary>
        public double Real { get; }

        /// <summary>
        /// Get imaginary part of the complex number.
        /// </summary>
        public double Imaginary { get; }

        /// <summary>
        /// Get modulus of the complex number.
        /// </summary>
        /// <retuns>a double representing the complex number modulus.</retuns>
        public double Modulus => Math.Sqrt(Math.Pow(this.Real, 2) + Math.Pow(this.Imaginary, 2));

        /// <summary>
        /// Get phase of the complex number.
        /// </summary>
        /// <retuns>a double representing the complex number phase.</retuns>
        public double Phase => Math.Atan2(this.Imaginary, this.Real);

        /// <summary>
        /// Get the complementary complex number.
        /// </summary>
        /// <retuns>an instance of <see cref="Complex"/> class representing the complementary.</retuns>
        public Complex Complementary => new Complex(this.Real, -this.Imaginary);

        /// <summary>
        /// Perform subtraction with the given complex number.
        /// </summary>
        /// <param name="num">the complex number to subtrac.</param>
        /// <retuns>an instance of <see cref="Complex"/> class representing the result.</retuns>
        public Complex Minus(Complex num) => new Complex(this.Real - num.Real, this.Imaginary - num.Imaginary);

        /// <summary>
        /// Perform sum with the given complex number.
        /// </summary>
        /// <param name="num">the complex number to sum.</param>
        /// <retuns>an instance of <see cref="Complex"/> class representing the result.</retuns>
        public Complex Plus(Complex num) => new Complex(this.Real + num.Real, this.Imaginary + num.Imaginary);

        public static Complex operator -(Complex num) => new Complex(0, 0).Minus(num);
        public static Complex operator -(Complex num1, Complex num2) => num1.Minus(num2);
        public static Complex operator -(Complex num1, double num2) => num1.Minus(new Complex(num2, 0));
        public static Complex operator +(Complex num1, Complex num2) => num1.Plus(num2);
        public static Complex operator +(Complex num1, double num2) => num1.Plus(new Complex(num2, 0));
    }
}