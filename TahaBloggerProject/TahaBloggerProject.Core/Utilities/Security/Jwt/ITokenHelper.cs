using System;
using System.Collections.Generic;
using System.Text;
using TahaBloggerProject.Core.Entities.Concrete;

namespace TahaBloggerProject.Core.Utilities.Security.Jwt
{
   public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
