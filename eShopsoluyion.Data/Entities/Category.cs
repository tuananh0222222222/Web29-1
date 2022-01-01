using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopsoluyion.Data.Entities
{
    public class Category
    {
       public int Id { get; set; }
       public int SortOder     { get; set; }
       public int IsShowOnHome { get; set; }
       public int ParentId     { get; set; }
       public int Status { get; set; }
    }
}
