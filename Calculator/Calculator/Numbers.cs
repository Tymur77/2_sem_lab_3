using System;
using Foundation;
using AppKit;

namespace Calculator
{
    partial class ViewController
    {
        double value1;
        double value2;
        char oper; // operator
        bool isDecimal;
        byte places; // after the decimal point

        private void CleanUp()
        {
            value1 = 0;
            value2 = 0;
            oper = '\0';
            isDecimal = false;
            places = 0;
        }

        partial void clear(NSObject sender)
        {
            CleanUp();
            ResultsField.StringValue = "0";
        }

        partial void coma(NSObject sender) => isDecimal = true;

        partial void _0(NSObject sender) => ModifyValue(0);
        partial void _1(NSObject sender) => ModifyValue(1);
        partial void _2(NSObject sender) => ModifyValue(2);
        partial void _3(NSObject sender) => ModifyValue(3);
        partial void _4(NSObject sender) => ModifyValue(4);
        partial void _5(NSObject sender) => ModifyValue(5);
        partial void _6(NSObject sender) => ModifyValue(6);
        partial void _7(NSObject sender) => ModifyValue(7);
        partial void _8(NSObject sender) => ModifyValue(8);
        partial void _9(NSObject sender) => ModifyValue(9);

        partial void divide(NSObject sender) => AssignOperator('/');
        partial void minus(NSObject sender) => AssignOperator('-');
        partial void multiply(NSObject sender) => AssignOperator('*');
        partial void plus(NSObject sender) => AssignOperator('+');

        partial void equals(NSObject sender)
        {
            double result;
            switch (oper)
            {
                case '+':
                    result = value1 + value2;
                    break;
                case '-':
                    result = value1 - value2;
                    break;
                case '*':
                    result = value1 * value2;
                    break;
                case '/':
                    if (value2 == 0)
                    {
                        CleanUp();
                        ResultsField.StringValue = "Error";
                        return;
                    }
                    result = value1 / value2;
                    break;
                default:
                    result = 0;
                    break;
            }
            CleanUp();
            ResultsField.StringValue = $"{result}";
        }




        private void ModifyValue(byte digit)
        {
            if (oper == '\0')
            {
                AppendDigit(ref value1, digit);
                DisplayValue(value1);
            }
            else
            {
                AppendDigit(ref value2, digit);
                DisplayValue(value2);
            }
        }

        private void AppendDigit(ref double value, byte digit)
        {
            if (!isDecimal)
            {
                value = value * 10;
                value += digit;
            }
            else if (isDecimal)
            {
                value += digit / Math.Pow(10, ++places);
            }
        }

        private void DisplayValue(double value) => ResultsField.StringValue = String.Format($"{{0:F{places}}}", value);

        private void AssignOperator(char oper)
        {
            this.oper = oper;
            isDecimal = false;
            places = 0;
        }

    }
}