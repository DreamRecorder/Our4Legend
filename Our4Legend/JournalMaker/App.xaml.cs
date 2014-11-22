using System . Reactive;
using System . Reactive . Linq;
using MVVMSidekick . ViewModels;
using MVVMSidekick . Views;
using MVVMSidekick . Reactive;
using MVVMSidekick . Services;
using MVVMSidekick . Commands;
using System;
using System . Collections . Generic;
using System . Configuration;
using System . Data;
using System . Linq;
using System . Threading . Tasks;
using System . Windows;

namespace JournalMaker
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        static App()
        {
            MVVMSidekick . Startups . StartupFunctions . RunAllConfig();
        }
    }
}
