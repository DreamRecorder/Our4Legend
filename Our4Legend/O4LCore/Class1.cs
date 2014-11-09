using System;
using System . Collections . Generic;
using System . Text;
using System . Reflection;
using System . IO;
using System . Xml;
using System . Xml . Linq;
using System . Linq;

namespace Our4Legend
{
	public class Class1
	{
		public static Journal asd ( )
		{
			var assembly=Assembly . GetExecutingAssembly ( );
			var stream=assembly . GetManifestResourceStream ( @"Our4LegendData.xml" );

			if ( stream == null )
			{
				throw new Exception ( );
			}
			var Reader=new StreamReader ( stream );

			var Doc=XDocument . Parse ( Reader . ReadToEnd ( ) );

			var journal= ( from Jou in Doc . Descendants ( "Journal" )
						   select new Journal
						   {
							   Name = ( string ) Jou . Attribute ( "Name" ) ,

							   ListOfIssue = from Iss in Jou . Descendants ( "Issue" )
											 select new Issue
											 {
												 Number = ( long ) Iss . Attribute ( "Number" ) ,
												 PublishTime = Convert . ToDateTime ( Iss . Attribute ( "PublishTime" ) ) ,
												 Price = ( decimal ) Iss . Attribute ( "Price" ) ,
												 ListOfArticle = from Art in Iss . Descendants ( "Article" )
																 select new Article
																 {
																	 Title = ( string ) Art . Attribute ( "Title" ) ,
																	 Text = ( string ) Art . Attribute ( "Text" ) ,
																	 ListOfAuthor = from Aut in Art . Descendants ( "Author" )
																					select new Author
																					{
																						FirstName = ( string ) Aut . Attribute ( "FirstName" ) ,
																						FamilyName = ( string ) Aut . Attribute ( "FamilyName" ) ,
																						EmailAddress = ( string ) Aut . Attribute ( "EmailAddress" )
																					}
																 }
											 }

						   } ) . FirstOrDefault ( );
			return journal;

		}
	}
}
