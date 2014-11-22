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
using System . Runtime . Serialization;

// “用户控件”项模板在 http://go.microsoft.com/fwlink/?LinkId=234236 上提供

namespace Our4Legend
{
    public sealed partial class O4LHS : HubSection
    {

        public string Text1
        {
            get
            {
                return (( O4LHS_Model ) this . DataContext) . Text1;
            }
            set
            {
                (( O4LHS_Model ) this . DataContext) . Text1 = value;
            }
        }

        public string Text2
        {
            get
            {
                return (( O4LHS_Model ) this . DataContext) . Text2;
            }
            set
            {
                (( O4LHS_Model ) this . DataContext) . Text2 = value;
            }
        }

        public ImageSource Image
        {
            get
            {
                return (( O4LHS_Model ) this . DataContext) . Image;
            }
            set
            {
                (( O4LHS_Model ) this . DataContext) . Image = value;
            }
        }


        public O4LHS()
        {
            this . InitializeComponent();
           
        }

    }

    [DataContract]
    public class O4LHS_Model
    {
        public string Text1 { get; set; }

        public string Text2 { get; set; }

        public ImageSource Image { get; set; }

    }
}
