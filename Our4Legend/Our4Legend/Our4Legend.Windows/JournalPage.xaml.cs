using MVVMSidekick . Views;
using System;
using System . Collections . Generic;
using System . IO;
using System . Linq;
using System . Runtime . InteropServices . WindowsRuntime;
using Windows . Foundation;
using Windows . Foundation . Collections;
using Windows . UI . Xaml;
using Windows . UI . Xaml . Controls;
using Windows . UI . Xaml . Controls . Primitives;
using Windows . UI . Xaml . Data;
using Windows . UI . Xaml . Input;
using Windows . UI . Xaml . Media;
using Windows . UI . Xaml . Navigation;
using System . Reflection;
using Our4Legend.ViewModels;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Our4Legend
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class JournalPage : MVVMPage
    {
        public JournalPage()
        {

            this . InitializeComponent();

        }

        private void Hub_Loaded(object sender , RoutedEventArgs e)
        {


            //foreach ( var item in Journal . Currect . ListOfIssue )
            //{
            //    var Temp=new O4LHS();

            //    Temp .  Text1 = item . Number.ToString();

            //    Temp .  Text2 = item . PublishTime . ToString();

            //    Temp . Height = Hub_Main . ActualHeight;

            //    Temp . Height = 600;

            //    Hub_Main . Sections . Add(Temp);

            //}

           //((JournalPage_Model) this.ViewModel)
            //var a= ImA . Source;

            //"ms-appx:/Assets/Logo.png";

        }


    }
}
