using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trial.entity;

namespace Trial.DAO
{
    interface CategoryDAO
    {
        void insertCatelog(Category CategoryRef);
        void updateCategory(Category CategoryRef);
        void deleteCategory(Category CategoryRef);
     //   Category findbyprimaryKey(string categoryName);
        List<Category> getcategoryList(Category categoryRef);
    }
}
