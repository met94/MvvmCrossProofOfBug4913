using System;
using System.Collections.Generic;
using System.Text;

namespace MyXamarinApp.Core.ViewModels.Main
{
    public class MainContainerViewModel : BaseViewModel<string>
    {
        public string Title { get; set; }
        public override void Prepare(string parameter) => Title = parameter;
    }
}
