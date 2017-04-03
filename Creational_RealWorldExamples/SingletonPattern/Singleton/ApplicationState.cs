using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonPattern.Singleton
{//http://www.blackwasp.co.uk/Singleton_2.aspx
    public sealed  class ApplicationState
    {
        private static volatile ApplicationState _instance;
        private static object _lockThis = new object();

        private ApplicationState() { }

        public static ApplicationState GetState()
        {
            if (_instance == null)
            {
                lock (_lockThis)
                {
                    if (_instance == null) _instance = new ApplicationState();
                }
            }
            return _instance;
        }

        // State Information
        public string LoginId { get; set; }
        public int MaxSize { get; set; }
    }
}
