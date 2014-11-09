using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Windows.Storage;

namespace IssueMaker
{
    public class IssueMaker
    {
        static void AUIUI()
        {
            StorageFolder Data = ApplicationData.Current.LocalFolder;

            var stream= (Data.CreateFileAsync("Our4LegendData.xml").GetResults()).OpenAsync(FileAccessMode.ReadWrite).GetResults();


        }

        public IssueMaker()
        {

        }
    }
}
