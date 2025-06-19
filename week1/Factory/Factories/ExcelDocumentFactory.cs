using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOTNET.Digital_Nurture_4._0_DotNetFSE_6360406.week1.Factory.ConcreteDocuments;

namespace DOTNET.Digital_Nurture_4._0_DotNetFSE_6360406.week1.Factory.Factories
{
    public class ExcelDocumentFactory : DocumentFactory
    {
        public override object CreateDocument()
        {
            return new MyExcelDocument();
        }
    }
}
