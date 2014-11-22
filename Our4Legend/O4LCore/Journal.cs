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
        public IEnumerable<Issue> ListOfIssue { get; set; }

        public IEnumerable<Author> ListOfAuthor { get; set; }

        public string Name { get; set; }

        //public Journal(IRandomAccessStream stream)
        //{
        //    if ( stream == null )
        //    {
        //        throw new Exception();
        //    }
        //    var Reader=new StreamReader(stream . AsStream());

        //    var Doc=XDocument . Parse(Reader . ReadToEnd());

        //    var journal_linq = (from Jou in Doc . Descendants("Journal")
        //                        select new Journal
        //                        {
        //                            Name = ( string ) Jou . Attribute("Name") ,
        //                            ListOfAuthor = from Aut in Jou . Descendants("Author")
        //                                           select new Author
        //                                           {
        //                                               FirstName = ( string ) Aut . Attribute("FirstName") ,
        //                                               FamilyName = ( string ) Aut . Attribute("FamilyName") ,
        //                                               EmailAddress = ( string ) Aut . Attribute("EmailAddress") ,
        //                                               Introduction = ( string ) Aut . Attribute("Introduction")
        //                                           } ,
        //                            ListOfIssue = from Iss in Jou . Descendants("Issue")
        //                                          select new Issue
        //                                          {
        //                                              Number = ( long ) Iss . Attribute("Number") ,
        //                                              PublishTime = Convert . ToDateTime(( string ) Iss . Attribute("PublishTime")) ,
        //                                              Price = ( decimal ) Iss . Attribute("Price") ,
        //                                              ListOfArticle = from Art in Iss . Descendants("Article")
        //                                                              select new Article
        //                                                              {
        //                                                                  Title = ( string ) Art . Attribute("Title") ,
        //                                                                  TextLine = from Lin in Art . Descendants("Text") . FirstOrDefault() . Descendants("Line")
        //                                                                             select ( string ) Lin . Attribute("Run") ,
        //                                                                  ListOfAuthorName = from Aut in Art . Descendants("AuthorName")
        //                                                                                     select ( string ) Aut . Attribute("FirstName") + " " + ( string ) Aut . Attribute("FamilyName") ,

        //                                                              }
        //                                          }


        //                        });
        //    List<Journal> journal=new List<Journal>();
        //    foreach ( var Jou in journal_linq )
        //    {
        //        foreach ( var Aut in Jou . ListOfAuthor )
        //        {
        //            foreach ( var Iss in Jou . ListOfIssue )
        //            {
        //                foreach ( var Art in Iss . ListOfArticle )
        //                {
        //                    foreach ( var aut in Art . ListOfAuthor )
        //                    {
        //                        if ( Aut == aut )
        //                        {
        //                            Aut . ArticleHaveContribute . Add(Art);
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //        journal . Add(Jou);
        //    }
        //    Currect = journal;

        //}
    }





}
