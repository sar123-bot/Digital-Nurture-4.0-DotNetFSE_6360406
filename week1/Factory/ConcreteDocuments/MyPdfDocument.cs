using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOTNET.Digital_Nurture_4._0_DotNetFSE_6360406.week1.Factory.Interfaces;

namespace DOTNET.Digital_Nurture_4._0_DotNetFSE_6360406.week1.Factory.ConcreteDocuments
{

    public class MyPdfDocument : IPdfDocument
    {
        public void OpenPdf() => Console.WriteLine("Opening PDF document...");
        public void SavePdf() => Console.WriteLine("Saving PDF document...");
    }
}
