using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcTW
{
    enum Status
    {
        SUCCESS,
        ERROR
    }

    internal class Calculator
    {
        internal struct Result
        {
            public Status status;
            public float Value;
        }

        internal Result Add(float a, float b)
        {
            Result result = new Result();
            result.Value = a + b;
            result.status = Status.SUCCESS;

            return result;
        }

        internal Result Sub(float a, float b)
        {
            Result result = new Result();
            result.Value = a - b;
            result.status = Status.SUCCESS;

            return result;
        }

        internal Result Mul(float a, float b)
        {
            Result result = new Result();
            result.Value = a * b;
            result.status = Status.SUCCESS;

            return result;
        }

        internal Result Div(float a, float b)
        {
            Result result = new Result();
            if (b != 0)
            {
                result.Value = a / b;
                result.status = Status.SUCCESS;
            }
            else
            {
                result.Value = a;
                result.status = Status.ERROR;
            }

            return result;
        }

    }
}
