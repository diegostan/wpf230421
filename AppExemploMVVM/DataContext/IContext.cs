using AppExemploMVVM.Models;
using System.Collections.Generic;

namespace AppExemploMVVM.DataContext
{
    interface IContext
    {
        //Interface para reduzir o acoplamento das classes Context
        List<UserModel> GetUsers();
    }
}
