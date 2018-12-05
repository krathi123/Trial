using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Trial.entity;

namespace Trial.DAO
{
    public interface RoleMasterDAO
    {
         void insertRole(RoleMaster roleMasterRef);
         void updaterole(RoleMaster roleMasterRef);
         void deleteRole(RoleMaster roleMasterRef);
        RoleMaster  findbyprimaryKey(string roleName);
        
    }
}
