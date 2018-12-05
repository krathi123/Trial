using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trial.entity;

namespace Trial.DAO
{
    interface UserMasterDao
    {
        void insertUser(UserMaster userMasterRef);
        void updateUser(UserMaster userMasterRef);
        void deleteUser(UserMaster userMasterRef);
        UserMaster findbyprimaryKey(int userId);
        List<string> getRoleName();
        List<ArrayList> getUsrList(UserMaster usermasterRef);
        UserMaster login(UserMaster usermasterRef);
    }
}

