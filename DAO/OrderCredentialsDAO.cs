using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trial.entity;

namespace Trial.DAO
{
    interface OrderCredentialsDAO
    {
        void insertOrderCredentials(OrderCredentials orderCredentialsRef);
        void updateorderCredentials(OrderCredentials orderCredentialsRef);
        void deleteorderCredentials(OrderCredentials orderCredentialsRef);
        //   OrderCredentials findbyprimaryKey(string orderCredentialsName);
        List<ArrayList> getorderCredentialsList(OrderCredentials orderCredentialsRef);
    }
}
