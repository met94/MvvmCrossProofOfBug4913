using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MvvmCross;
using MvvmCross.Commands;
using MvvmCross.Navigation;

namespace MyXamarinApp.Core.ViewModels.Main
{
    public class MainViewModel : BaseViewModel
    {
        public IMvxNavigationService NavigationService => Mvx.IoCProvider.Resolve<IMvxNavigationService>();

        public MvxAsyncCommand NavigateCommand => new MvxAsyncCommand(() => NavigationService.Navigate<MainContainerViewModel, string>("Navigate1"));

        public MvxAsyncCommand Navigate2Command => new MvxAsyncCommand(() => NavigationService.Navigate<MainContainerViewModel, string>("Navigate2"));
    }
}
