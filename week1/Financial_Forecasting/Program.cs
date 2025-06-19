using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET.Digital_Nurture_4._0_DotNetFSE_6360406.week1.Financial_Forecasting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double presentValue = 1000.0;
            double growthRate = 0.05; 
            int years = 5;

            double futureValue = FinancialForecast.CalculateFutureValue(presentValue, growthRate, years);
            Console.WriteLine($"Future Value after {years} years at {growthRate * 100}% growth rate: {futureValue:F2}");
        }
    }
}
