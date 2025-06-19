using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOTNET.Digital_Nurture_4._0_DotNetFSE_6360406.week1.Factory.Factories;
using DOTNET.Digital_Nurture_4._0_DotNetFSE_6360406.week1.Factory.Interfaces;
using DOTNET.Digital_Nurture_4._0_DotNetFSE_6360406.week1.Factory.ConcreteDocuments;
namespace DOTNET.Digital_Nurture_4._0_DotNetFSE_6360406.week1.Factory.Test
{

    class DocumentFactoryTest
    {
        static void Main(string[] args)
        {
            DocumentFactory wordFactory = new WordDocumentFactory();
            IWordDocument wordDoc = (IWordDocument)wordFactory.CreateDocument();
            wordDoc.OpenWord();
            wordDoc.SaveWord();

            DocumentFactory pdfFactory = new PdfDocumentFactory();
            IPdfDocument pdfDoc = (IPdfDocument)pdfFactory.CreateDocument();
            pdfDoc.OpenPdf();
            pdfDoc.SavePdf();

            DocumentFactory excelFactory = new ExcelDocumentFactory();
            IExcelDocument excelDoc = (IExcelDocument)excelFactory.CreateDocument();
            excelDoc.OpenExcel();
            excelDoc.SaveExcel();

            Console.ReadLine();
        }
    }
}
