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

        IEnumerable<string> _ListOfAuthorName;

        public IEnumerable<string> ListOfAuthorName
        {
            get
            {
                return _ListOfAuthorName;
            }
            set
            {
                ListOfAuthor = new List<Author>();
                //if ( value != null )
                //{
                //    foreach ( var name in value )
                //    {
                //        foreach ( var author in Journal . Currect . ListOfAuthor )
                //        {
                //            if ( name == author . FirstName + " " + author . FamilyName )
                //            {
                //                ListOfAuthor . Add(author);
                //            }
                //        }
                //    }
                //}

                _ListOfAuthorName = value;
            }
        }

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
                    }
                }
                else
                {
                    Text = "";
                }
                _TextLine = value;
            }
        }

        public string Text { get; private set; }

        public string Title { get; set; }

        public List<Author> ListOfAuthor { get; set; }

    }

}
