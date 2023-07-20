using Foundation;
using System;
using UIKit;

namespace Xamarin
{
    internal class Forms
    {
        public static object Forms { get; internal set; }

        public class Platform
        {
            public class iOS
            {
                public class FormsApplicationDelegate
                {
                    internal bool FinishedLaunching(UIApplication app, NSDictionary options)
                    {
                        throw new NotImplementedException();
                    }
                }
            }
        }
    }
}