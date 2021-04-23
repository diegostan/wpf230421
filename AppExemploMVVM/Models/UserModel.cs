using AppExemploMVVM.DataContext;
using System.Collections.Generic;

namespace AppExemploMVVM.Models
{
    class UserModel
    {
        //Modelo de dominio do usuário
        public int ID { get; set; }
        public string Name { get; set; }
        public string Filme { get; set; }
        public string Role { get; set; }


        public List<UserModel> GetUser()
        {
            IContext user = new UserContext();
            return user.GetUsers();
        }
    }
}
