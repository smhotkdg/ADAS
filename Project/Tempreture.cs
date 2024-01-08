using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project
{
    class Tempreture
    {
        int nowtempreture = 18;
        int keyvalue = 1;

        const int min_key = 1;
        const int max_key = 3;

        const int min_tempreture = 18;
        const int max_tempreture = 32;

        static public Tempreture Singleton
        {
            get;
            private set;
        }

        static Tempreture()
        {
            Singleton = new Tempreture();
        }

        public int KeyValue
        {
            get 
            {
                return keyvalue;
            }

            set 
            {
                keyvalue = value;
            }
        }


        public int NowTempreture
        {
            get
            {
                return nowtempreture;
            }

            set
            {
                if (value < min_tempreture)
                {
                    nowtempreture = min_tempreture;
                }
                else if (value > max_tempreture)
                {
                    nowtempreture = max_tempreture;
                }
                else
                {
                    nowtempreture = value;
                }
            }
        }
    }
}
