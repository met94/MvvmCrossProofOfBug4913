using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MvvmCross;
using MvvmCross.Navigation;

namespace MyXamarinApp.Core.ViewModels.Main
{
    public class MainViewModel : BaseViewModel
    {
        int navigationCounter = 0;

        public override async void ViewAppeared()
        {
            base.ViewAppeared();
            if(navigationCounter > 1)
            {
                return;
            }

            await Task.Delay(1000);
            await Mvx.IoCProvider.Resolve<IMvxNavigationService>().Navigate<MainContainerViewModel, string>(navigationCounter == 0 ? "Initial title" : "Other title");
            navigationCounter++;
        }
    }
}
