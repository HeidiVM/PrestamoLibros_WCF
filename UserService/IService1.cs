using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using UserService.Models;

namespace UserService
{
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract] List<User> GetAllUsers();
        [OperationContract] User GetUserById(int id);
        [OperationContract] bool RegisterUser(User user);
        [OperationContract] bool UpdateUser(User user);
    }
}
