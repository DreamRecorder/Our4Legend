using System;
using System . Collections . Generic;
using System . Linq;
using System . Text;
using System . IO;
using Windows . Storage;
using System . Threading . Tasks;
using System . Collections . ObjectModel;
using System . Runtime . Serialization;
using Windows . Storage . Streams;
using System . Reflection;
using System . Xml;
using System . Xml . Linq;

namespace Our4Legend
{
    public class JournalMaker
    {
        public static Journal GetJournal(IRandomAccessStream stream)
        {
            if ( stream == null )
            {
                return null;
            }
            else
            {


                var Reader=new StreamReader(stream . AsStream());

                var Doc=XDocument . Parse(Reader . ReadToEnd());

                Journal journal;
                try
                {
                    journal = (from Jou in Doc . Descendants("Journal")
                               select new Journal
                               {
                                   Name = ( string ) Jou . Attribute("Name") ,
                                   ListOfAuthor = from Aut in Jou . Descendants("Author")
                                                  select new Author
                                                  {
                                                      FirstName = ( string ) Aut . Attribute("FirstName") ,
                                                      FamilyName = ( string ) Aut . Attribute("FamilyName") ,
                                                      EmailAddress = ( string ) Aut . Attribute("EmailAddress") ,
                                                      Introduction = ( string ) Aut . Attribute("Introduction")
                                                  } ,
                                   ListOfIssue = from Iss in Jou . Descendants("Issue")
                                                 select new Issue
                                                 {
                                                     Number = ( long ) Iss . Attribute("Number") ,
                                                     PublishTime = Convert . ToDateTime(( string ) Iss . Attribute("PublishTime")) ,
                                                     Price = ( decimal ) Iss . Attribute("Price") ,
                                                     ListOfArticle = from Art in Iss . Descendants("Article")
                                                                     select new Article
                                                                     {
                                                                         Title = ( string ) Art . Attribute("Title") ,
                                                                         TextLine = from Lin in Art . Descendants("Text") . FirstOrDefault() . Descendants("Line")
                                                                                    select ( string ) Lin . Attribute("Run") ,
                                                                         ListOfAuthorName = from Aut in Art . Descendants("AuthorName")
                                                                                            select ( string ) Aut . Attribute("FirstName") + " " + ( string ) Aut . Attribute("FamilyName") ,

                                                                     }
                                                 }


                               }) . First();
                }
                catch ( System . Exception )
                {
                    return null;
                }
                foreach ( var Aut in journal . ListOfAuthor )
                {
                    foreach ( var Iss in journal . ListOfIssue )
                    {
                        foreach ( var Art in Iss . ListOfArticle )
                        {
                            foreach ( var aut in Art . ListOfAuthor )
                            {
                                if ( Aut == aut )
                                {
                                    Aut . ArticleHaveContribute . Add(Art);
                                }
                            }
                        }
                    }

                }
                return journal;
            }
        }
    }
}
