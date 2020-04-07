using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppLifecycleTutorial
{
    public partial class App : Application
    {

        const string displayText = "displayText";

        public string DisplayText { get; set; }

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            Console.WriteLine("OnStart");
            Console.WriteLine("Start*************************************************************");
            if (Properties.ContainsKey(displayText))
            {
                DisplayText = (string)Properties[displayText];
            }
        }

        protected override void OnSleep()
        {
            Console.WriteLine("OnSleep");
            Console.WriteLine("Sleep*************************************************************");
            Properties[displayText] = DisplayText;
        }

        protected override void OnResume()
        {
            Console.WriteLine("OnResume");
            Console.WriteLine("Resume*************************************************************");
        }


    }
}
