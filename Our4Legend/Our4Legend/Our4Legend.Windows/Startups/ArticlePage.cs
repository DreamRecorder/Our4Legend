using System . Reactive;
using System . Reactive . Linq;
using MVVMSidekick . ViewModels;
using MVVMSidekick . Views;
using MVVMSidekick . Reactive;
using MVVMSidekick . Services;
using MVVMSidekick . Commands;
using Our4Legend;
using Our4Legend . ViewModels;
using System;
using System . Net;
using System . Windows;


namespace MVVMSidekick . Startups
{
	public static partial class StartupFunctions
	{
		static Action ArticlePageConfig =
			CreateAndAddToAllConfig ( ConfigArticlePage );

		public static void ConfigArticlePage ( )
		{
			ViewModelLocator<ArticlePage_Model>
				. Instance
				. Register ( context =>
					new ArticlePage_Model ( ) )
				. GetViewMapper ( )
				. MapToDefault<ArticlePage> ( );

		}
	}
}
