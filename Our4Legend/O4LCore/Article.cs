using System;
using System . Collections . Generic;
using System . Linq;
using System . Text;
using System . Threading . Tasks;
using System . Collections . ObjectModel;
using System . Runtime . Serialization;

namespace Our4Legend
{
    public class Article
    {
        IEnumerable<string> _TextLine;

        public IEnumerable<string> TextLine
        {
            get
            {
                return _TextLine;
            }
            set
            {
                if ( value != null )
                {
                    foreach ( var item in value )
                    {
                        Text += item;
                        Text += Environment . NewLine;
                        //Text = Text . Trim();
                    }
                }
                else
                {
                    Text = "";
                }
                _TextLine = value;
            }
        }

        public string Text { get;private set; }

        public string Title { get; set; }

        public IEnumerable<Author> ListOfAuthor { get; set; }

    }

}
