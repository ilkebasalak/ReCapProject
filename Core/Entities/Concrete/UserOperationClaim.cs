using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Concrete
{
    public class UserOperationClaim:IEntity
    {
        public int UsersId { get; set; }
        public int Id { get; set; }
        
       public int OperationClaimId { get; set; }
    }
}
