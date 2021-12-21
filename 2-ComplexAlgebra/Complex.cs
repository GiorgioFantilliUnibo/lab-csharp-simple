namespace ComplexAlgebra
{
    /// TODO: Model Complex numbers in an object-oriented way and implement this class.
    /// TODO: In other words, you must provide a means for:
    /// TODO: * instantiating complex numbers
    /// TODO: * accessing a complex number's real, and imaginary parts
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
        /// <param name="name">the name of the card.</param>
        /// <param name="seed">the seed of the card.</param>
        /// <param name="ordinal">the ordinal number of the card.</param>
        public Complex(int real, int immaginary)
        {
            this.Real = real;
            this.Immaginary = immaginary;
        }

        public int Real { get; }
        public int Immaginary { get; }
    }
}