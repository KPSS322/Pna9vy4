using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Singleton
    {
            protected static Singleton _instance; 

            private Singleton()
            {
            }

            public static Singleton Instance()
            {
                //Ленивая не потокобезопасная инициализация

                if (_instance == null)
                {
                    _instance = new Singleton();
                }

                return _instance;
            }
        }
}
