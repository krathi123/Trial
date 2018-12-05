using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial.entity
{
   public class Category
    {
      public string categoryName { set; get;}
     public string categoryDesc { set; get; }
    public Category(string name,string desc)
        {
            categoryName = name;
            categoryDesc = desc;
        }
        public Category()
        {
        }
    }
}
