using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Trial.entity;
namespace Trial.DAO
{
    interface ItemDAO
    {
        void inseritems(Items ItemsRef);
        void updateItems(Items ItemsRef);
        void deleteItems(Items ItemsRef);
        //   Items findbyprimaryKey(string ItemsName);
        List<Items> getItemsList(Items ItemsRef);
       // List<List<string>> getItemsListSample(Items ItemsRef);
        List<ArrayList> getItemsListSample(Items ItemsRef);
    }
}
