using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfCours.MVVM.View;

namespace WpfCours.MVVM.ViewModel
{
    public class MainViewVM : BaseVM
    {
        //Called from view (With data binding)
        public ICommand RequestChangeViewCommand { get; set; }
        public MainViewVM()
        {
            //Configure command to callback "HandleRequestChangeViewCommand"
            //when command is called
            RequestChangeViewCommand = new RelayCommand(HandleRequestChangeViewCommand);
        }

        public void HandleRequestChangeViewCommand()
        {
            MainWindowVM.OnRequestVMChange?.Invoke(new GameVM());
        }

        //Override from BaseVM
        public override void OnShowVM()
        {
            //Display popup for information
            MessageBox.Show("Main view display");
        }
    }
}
