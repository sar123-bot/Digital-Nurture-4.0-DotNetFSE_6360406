using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOTNET.Digital_Nurture_4._0_DotNetFSE_6360406.week1.Factory.Interfaces;


namespace DOTNET.Digital_Nurture_4._0_DotNetFSE_6360406.week1.Factory.ConcreteDocuments
{
    public class MyWordDocument : IWordDocument
    {
        public void OpenWord() => Console.WriteLine("Opening Word document...");
        public void SaveWord() => Console.WriteLine("Saving Word document...");
    }
}
