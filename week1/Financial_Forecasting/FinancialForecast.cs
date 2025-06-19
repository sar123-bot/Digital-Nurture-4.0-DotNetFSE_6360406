using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET.Digital_Nurture_4._0_DotNetFSE_6360406.week1.Financial_Forecasting
{
    public class FinancialForecast
    {
       
        public static double CalculateFutureValue(double presentValue, double growthRate, int years)
        {
            
            if (years == 0) return presentValue;

            
            return CalculateFutureValue(presentValue, growthRate, years - 1) * (1 + growthRate);
        }
    }

}
