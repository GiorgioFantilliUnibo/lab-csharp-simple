using ComplexAlgebra;
using System;

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
        /// Get/Set the operation to perform.
        /// <para>
        /// If the calculator is reset, do nothing.
        /// If an operation has already been set, but not the second operand, the old operation
        /// will be replaced with the new one.
        /// If there is an operation pending it is executed and the result set as current value.
        /// </para>
        /// </summary>
        public char? Operation
        {
            get => this._operation;
            set
            {
                if (!this.HasValue())
                {
                    if (this.HasPendingOp()) this._operation = value;
                } else
                {
                    if (this.HasPendingOp()) this.ComputeResult();
                    this._operation = value;
                    this._intermediateValue = this.Value;
                    this.Value = null;
                }
            }
        }

        /// <summary>
        /// Let to request the calculation of the final result.
        /// <para>
        /// If the current value has not been set, the calculator will reset.
        /// If the operation to perform has not been set, the calculator will reset.
        /// </para>
        /// </summary>
        /// <exception cref="InvalidOperationException">Thrown if the operation setted is not supported.</exception>
        public void ComputeResult()
        {
            if (this.HasValue())
            {
                Complex ris = null;
                switch (this._operation)
                {
                    case OperationPlus:
                        ris = this._intermediateValue + this.Value;
                        break;
                    case OperationMinus:
                        ris = this._intermediateValue - this.Value;
                        break;
                    case null:
                        break;
                    default:
                        throw new InvalidOperationException();
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

        /// <summary>
        /// Get the internal status of the calculator.
        /// </summary>
        /// <retuns>a <see cref="String"/> representing the internal status of the calculator.</retuns>
        public override string ToString()
        {
            string val = this.HasValue() ? this.Value.ToString() : "null";
            string op = this.HasPendingOp() ? this._operation.ToString() : "null";
            return $"Value: {val}, Operation: {op}";
        }

        private void Reset(Complex ris)
        {
            this.Reset();
            this.Value = ris;
        }

        private bool HasValue() => this.Value != null;

        private bool HasPendingOp() => this._operation != null;
    }
}