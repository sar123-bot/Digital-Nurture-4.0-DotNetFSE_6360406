using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET.Digital_Nurture_4._0_DotNetFSE_6360406.week1.E_commerce
{
    public static class SearchService
    {
        
        public static Product LinearSearch(Product[] products, int targetId)
        {
            foreach (var p in products)
            {
                if (p.ProductId == targetId) return p;
            }
            return null;
        }

       
        public static Product BinarySearch(Product[] products, int targetId)
        {
            int left = 0;
            int right = products.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (products[mid].ProductId == targetId) return products[mid];
                if (targetId < products[mid].ProductId) right = mid - 1;
                else left = mid + 1;
            }

            return null;
        }
    }

}
