using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WindowsFormsApp1
{
    class ComplexNumber
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }
        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }        
        public ComplexNumber Add(ComplexNumber other)
        {
            double real = Real + other.Real; double imaginary = Imaginary + other.Imaginary;
            return new ComplexNumber(real, imaginary);
        }
        public ComplexNumber Subtract(ComplexNumber other)
        {
            double real = Real - other.Real;
            double imaginary = Imaginary - other.Imaginary; return new ComplexNumber(real, imaginary);
        }
        public ComplexNumber Multiply(ComplexNumber other)
        {
            double real = Real * other.Real - Imaginary * other.Imaginary;
            double imaginary = Real * other.Imaginary + Imaginary * other.Real; return new ComplexNumber(real, imaginary);
        }
        public ComplexNumber Divide(ComplexNumber other)
        {
            double denominator = Math.Pow(other.Real, 2) + Math.Pow(other.Imaginary, 2);
            double real = (Real * other.Real + Imaginary * other.Imaginary) / denominator; double imaginary = (Imaginary * other.Real - Real * other.Imaginary) / denominator;
            return new ComplexNumber(real, imaginary);
        }
        public ComplexNumber Conjugate()
        {
            return new ComplexNumber(Real, -Imaginary);
        }
        public ComplexNumber Power(double exponent)
        {
            double modulus = Modulus(); double argument = Argument();
            double newModulus = Math.Pow(modulus, exponent); double newArgument = argument * exponent;
            double real = newModulus * Math.Cos(newArgument); double imaginary = newModulus * Math.Sin(newArgument);
            return new ComplexNumber(real, imaginary);
        }
        public ComplexNumber SquareRoot()
        {
            double modulus = Modulus(); double argument = Argument();
            double newModulus = Math.Sqrt(modulus); double newArgument = argument / 2;
            double real = newModulus * Math.Cos(newArgument); double imaginary = newModulus * Math.Sin(newArgument);
            return new ComplexNumber(real, imaginary);
        }
        public double Modulus()
        {
            return Math.Sqrt(Math.Pow(Real, 2) + Math.Pow(Imaginary, 2));
        }
        public double Argument()
        {
            return Math.Atan2(Imaginary, Real);
        }
        public string ToAlgebraic()
        {
            return $"{Real} + {Imaginary}i";
        }
        public string ToTrigonometric()
        {
            double modulus = Modulus(); double argument = Argument();
            return $"{modulus} * (cos({argument}) + i * sin({argument}))";
        }
        public string ToExponential()
        {
            double modulus = Modulus(); double argument = Argument();
            return $"{modulus} * e^(i * {argument})";
        }
    }
}