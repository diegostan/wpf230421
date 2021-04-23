using System.ComponentModel;
using System.Windows.Input;
using AppExemploMVVM.Models;
using AppExemploMVVM.Services;

namespace AppExemploMVVM.ViewModels
{
    class InicioViewModel : INotifyPropertyChanged
    {
        //Classe ViewModel da View Inicio, implementa INotifyPropertyChanged 
        //que comunica a view quando houver mudanças para atualização em tela

        public event PropertyChangedEventHandler PropertyChanged;
        
        //Propriedades
        public UserModel User { get; set; }
        public int FontSizeUser { get; set; }

        //Comandos via Binding da View
        public ICommand ShowUser1Command { get; set; }
        public ICommand ShowUser2Command { get; set; }
        public ICommand ClearUserCommand { get; set; }

        public InicioViewModel()
        {
            ShowUser1Command = new RelayCommand(ShowUser);
            ShowUser2Command = new RelayCommand(ShowUser2);
            ClearUserCommand = new RelayCommand(ClearUser);
            FontSizeUser = 20;            
            RaiseChange("FontSizeUser");
        }

        //Mostra os usuários, pode ser feito com injeção de dependencia 
        //e utilizar LINQ para retornar algo, mas esse não é o intuito do projeto
        void ShowUser(object obj)
        {
            
            User = new UserModel().GetUser()[0];            
            RaiseChange("User");
        }

        void ShowUser2(object obj)
        {
            User = new UserModel().GetUser()[1];
            RaiseChange("User");
        }

        //Limpa a propriedade
        void ClearUser(object obj)
        {
            User = null;
            RaiseChange("User");
        }

        //Comunica a View de alguma mudança, pode ser adaptado para receber um object com o 
        //nome do método ao invés da string com o nome da propriedade, questão de gosto.
        public void RaiseChange(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
