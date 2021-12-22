namespace ComplexAlgebra
{
    using System;
    
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
        public Complex Complement() => new Complex(this.Real, -this.Imaginary);

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

        /// <summary>
        /// Get the string rappresentation of the complex number.
        /// </summary>
        /// <retuns>a string representing the complex number.</retuns>
        public override string ToString()
        {
            string re = this.Real.ToString();
            if (this.Imaginary == 0.0) return re;

            string sign = "";
            if (this.Imaginary < 0)
            {
                sign = "-";
            } else if (re != "0")
            {
                sign = "+";
            }
            if (re == "0") re = "";

            string im = Math.Abs(this.Imaginary).ToString();
            if (im == "1")
                im = sign + "i";
            else
                im = sign + im + "i";
            
            return re + im;
        }

        /// <summary>
        /// Determines whether two instances of the <see cref="Complex"/> class are equal.
        /// </summary>
        /// <param name="other">the instances of <see cref="Complex"/> class to compare.</param>
        /// <returns>true if the two instaces are equal, false otherwise</returns>
        public bool Equals(Complex other)
        {
            if (this == other)
                return true;
            else
                return this.Real == other.Real
                       && this.Imaginary == other.Imaginary;
        }

        /// <inheritdoc cref="object.Equals(object?)"/>
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != this.GetType()) return false;
            return this.Equals(obj as Complex);
        }

        /// <inheritdoc cref="object.GetHashCode()"/>
        public override int GetHashCode()
        {
            return HashCode.Combine(this.Real, this.Imaginary);
        }

        public static Complex operator -(Complex num) => new Complex(0, 0).Minus(num);
        public static Complex operator -(Complex num1, Complex num2) => num1.Minus(num2);
        public static Complex operator -(Complex num1, double num2) => num1.Minus(new Complex(num2, 0));
        public static Complex operator +(Complex num1, Complex num2) => num1.Plus(num2);
        public static Complex operator +(Complex num1, double num2) => num1.Plus(new Complex(num2, 0));
    }
}