using Foundation;
using UIKit;
using Microsoft.WindowsAzure.MobileServices;

namespace Tasky 
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		// class-level declarations
		UIWindow window;
		UINavigationController navController;
		//UITableViewController homeScreen;
		UITableViewController loginScreen;

		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			// create a new window instance based on the screen size
			window = new UIWindow (UIScreen.MainScreen.Bounds);
			
			// make the window visible
			window.MakeKeyAndVisible ();
			
			// create our nav controller
			navController = new UINavigationController ();

			// create our home controller 
			//homeScreen = new Tasky.Screens.HomeScreen();
			loginScreen = new Tasky.Screens.LoginScreen();

			// Styling
			UINavigationBar.Appearance.TintColor = UIColor.FromRGB (38, 117 ,255); // nice blue
			UITextAttributes ta = new UITextAttributes();
			ta.Font = UIFont.FromName ("AmericanTypewriter-Bold", 0f);
			UINavigationBar.Appearance.SetTitleTextAttributes(ta);
			ta.Font = UIFont.FromName ("AmericanTypewriter", 0f);
			UIBarButtonItem.Appearance.SetTitleTextAttributes(ta, UIControlState.Normal);
			

			// push the view controller onto the nav controller and show the window

			navController.PushViewController(loginScreen, false);
			//navController.PushViewController(homeScreen, false);

			window.RootViewController = navController;
			window.MakeKeyAndVisible ();
			
			return true;
		}

		/*
		public static MobileServiceClient MobileService = new MobileServiceClient(
			"https://taskybackend.azure-mobile.net/",
			"cFkLIXnUwMmaBXijvAcrYxCzJlmkZW54"
		);*/
	}
}