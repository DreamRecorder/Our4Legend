﻿using MVVMSidekick . Views;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Our4Legend
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class MainPage : MVVMPage
	{
		public MainPage ( )
		{

			this . InitializeComponent ( );

			Journal asd=Journal . Currect ( );

			foreach ( var Issues in asd . ListOfIssue )
			{
				foreach ( var Articles in Issues . ListOfArticle )
				{
					foreach ( var Authors in Articles.ListOfAuthor )
					{

					}
				}
			}
		}


	}
}
