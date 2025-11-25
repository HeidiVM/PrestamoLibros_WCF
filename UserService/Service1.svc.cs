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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class UserService : IUserService
    {
        private static List<User> users = new List<User>()
    {
        new User { Id = 1, Name = "Juan" },
        new User { Id = 2, Name = "María" }
    };

        public List<User> GetAllUsers() => users;

        public User GetUserById(int id) => users.FirstOrDefault(u => u.Id == id);

        public bool RegisterUser(User user)
        {
            users.Add(user);
            return true;
        }

        public bool UpdateUser(User user)
        {
            var u = users.FirstOrDefault(x => x.Id == user.Id);
            if (u == null) return false;

            u.Name = user.Name;
            return true;
        }
    }

}
