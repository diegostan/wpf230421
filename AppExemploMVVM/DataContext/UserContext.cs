using AppExemploMVVM.Models;
using System.Collections.Generic;

namespace AppExemploMVVM.DataContext
{
    class UserContext : IContext
    {
        //Aqui pode ser usado um repositório como um banco de dados etc
        //Criei uma repos do tipo generic só para fins didáticos
        public List<UserModel> GetUsers()
        {
            var listUsers = new List<UserModel>();

            listUsers.Add(
                new UserModel() { ID = 1, Name = "Christopher Nolan", Filme = "Batman Cavalheiro das Trevas", Role = "Manager" });
            
            listUsers.Add(
                new UserModel() { ID = 2, Name = "Zack Snyder", Filme = "Liga da Justiça 2021 SC", Role = "Director" });

            return listUsers;
        }
    }
}
