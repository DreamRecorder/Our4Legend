using System;
using System . Collections . Generic;
using System . Text;
using System . Reflection;
using System . IO;
using System . Xml;
using System . Xml . Linq;
using System . Linq;
using Windows . ApplicationModel;
using Windows . Storage;
using Windows . Storage . Streams;

namespace Our4Legend
{
    public class Journal
    {
        public static Journal Currect;


        public IEnumerable<Issue> ListOfIssue { get; set; }

        public string Name { get; set; }

        public Journal()
        {

        }

        public Journal(IRandomAccessStream stream)
        {

            if ( stream == null )
            {
                throw new Exception();
            }
            var Reader=new StreamReader(stream . AsStream());

            var Doc=XDocument . Parse(Reader . ReadToEnd());

            var journal = (from Jou in Doc . Descendants("Journal")
                           select new Journal
                           {
                               Name = ( string ) Jou . Attribute("Name") ,

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
                                                                     ListOfAuthor = from Aut in Art . Descendants("Author")
                                                                                    select new Author
                                                                                    {
                                                                                        FirstName = ( string ) Aut . Attribute("FirstName") ,
                                                                                        FamilyName = ( string ) Aut . Attribute("FamilyName") ,
                                                                                        EmailAddress = ( string ) Aut . Attribute("EmailAddress")
                                                                                    }
                                                                 }
                                             }

                           }) . FirstOrDefault();
            Currect = journal;

        }
    }





}
