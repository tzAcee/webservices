using CalcService;
using System.ServiceModel;

namespace CalcService
{
    [ServiceContract]
    public interface ICalculator
    {
        [OperationContract]
        Result Add(Arguments arg);
    }

    public class Calculator : ICalculator
    {
        public Result Add(Arguments arg)
        {
            return new Result
            {
                Value = arg.Arg1 + arg.Arg2
            }; 
        }
    }
}