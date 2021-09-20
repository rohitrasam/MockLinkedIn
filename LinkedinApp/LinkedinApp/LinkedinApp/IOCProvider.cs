using System;
using System.Collections.Generic;
using SimpleInjector;
using System.Text;
using LinkedinApp.Services;

namespace LinkedinApp
{
    public class IOCProvider
    {

        private static Container container = new Container();
        
        public static T GetInstance<T>() where T : class
        {
            return container.GetInstance<T>();
        }

        public static void Register()
        {
            container.Register<IActivityFeedService, ActivityFeedService>();

        }
    }
}
