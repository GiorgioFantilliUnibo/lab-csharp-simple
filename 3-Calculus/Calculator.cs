using ComplexAlgebra;

namespace Calculus
{
    /// <summary>
    /// A calculator for <see cref="Complex"/> numbers, supporting 2 operations ('+', '-').
    /// The calculator visualizes a single value at a time.
    /// Users may change the currently shown value as many times as they like.
    /// Whenever an operation button is chosen, the calculator memorises the currently shown value and resets it.
    /// Before resetting, it performs any pending operation.
    /// Whenever the final result is requested, all pending operations are performed and the final result is shown.
    /// The calculator also supports resetting.
    /// </summary>
    ///
    /// HINT: model the following _public_ properties methods
    /// HINT: - a property/method to let the user request an operation
    /// HINT: - the usual ToString() method, which is helpful for debugging
    /// HINT: - you may exploit as many _private_ fields/methods/properties as you like
    ///
    /// TODO: implement the calculator class in such a way that the Program below works as expected
    class Calculator
    {
        public const char OperationPlus = '+';
        public const char OperationMinus = '-';

        private Complex _intermediateValue = null;
        private char? _operation = null;

        /// <summary>
        /// Get/Set the currently shown value.
        /// </summary>
        public Complex Value { get; set; }

        /// <summary>
        /// Let to request the calculation of the final result.
        /// </summary>
        public void ComputeResult()
        {
            if (this.Value != null)
            {
                Complex ris;
                switch (this._operation)
                {
                    case OperationPlus:
                        ris = this._intermediateValue + this.Value;
                        break;
                    case OperationMinus:
                        ris = this._intermediateValue - this.Value;
                        break;
                    case null:
                        ris = null;
                        break;
                }
                this.Reset(ris);
            }
            else
                this.Reset();
        }

        /// <summary>
        /// Let to reset the calculator.
        /// </summary>
        public void Reset()
        {
            this._intermediateValue = null;
            this._operation = null;
            this.Value = null;
        }
    }
}