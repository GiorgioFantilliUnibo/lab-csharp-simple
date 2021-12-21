namespace ComplexAlgebra
{
    using System;
    /// TODO: Model Complex numbers in an object-oriented way and implement this class.
    /// TODO: In other words, you must provide a means for:
    /// TODO: * accessing a complex number's modulus, and phase
    /// TODO: * complementing a complex number
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
        /// <param name="immaginary">the immaginary part of the number.</param>
        public Complex(double real, double immaginary)
        {
            this.Real = real;
            this.Immaginary = immaginary;
        }

        /// <summary>
        /// Get real part of the complex number.
        /// </summary>
        public double Real { get; }

        /// <summary>
        /// Get immaginary part of the complex number.
        /// </summary>
        public double Immaginary { get; }

        /// <summary>
        /// Get modulus of the complex number.
        /// </summary>
        /// <retuns>a double representing the complex number modulus.</retuns>
        public double Modulus => Math.Sqrt(Math.Pow(this.Real, 2) + Math.Pow(this.Immaginary, 2));

        /// <summary>
        /// Get phase of the complex number.
        /// </summary>
        /// <retuns>a double representing the complex number phase.</retuns>
        public double Phase => Math.Atan2(this.Immaginary, this.Real);
    }
}