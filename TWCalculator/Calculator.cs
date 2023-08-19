using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcTW
{
    //Test Change file for testing not owner user 
    
    public enum Status
    {
        SUCCESS,
        ERROR
    }

    public struct Result
    {
        public Status status;
        public float Value;
    }

    public class Calculator
    {
        public Result Add(float a, float b)
        {
            Result result = new Result();
            result.Value = a + b;
            result.status = Status.SUCCESS;

            return result;
        }

        public Result Sub(float a, float b)
        {
            Result result = new Result();
            result.Value = a - b;
            result.status = Status.SUCCESS;

            return result;
        }

        public Result Mul(float a, float b)
        {
            Result result = new Result();
            result.Value = a * b;
            result.status = Status.SUCCESS;

            return result;
        }

        public Result Div(float a, float b)
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
