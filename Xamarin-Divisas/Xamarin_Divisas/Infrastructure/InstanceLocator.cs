﻿
using Xamarin_Divisas.ViewModels;

namespace Xamarin_Divisas.Infrastructure
{
    public class InstanceLocator
    {
        public MainViewModel Main { get; set; }

        public InstanceLocator()
        {
            Main = new MainViewModel();
        }
    }
}
