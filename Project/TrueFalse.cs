using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project
{
    class TrueFalse
    {
        bool colorFlg;
        bool positionFlg;
        bool sizeFlg;
        static public TrueFalse Singleton
        {
            get;
            private set;
        }

        static TrueFalse()
        {
            Singleton = new TrueFalse();
        }

        public bool ColorFlg
        {
            get 
            {
                return colorFlg;
            }

            set 
            {
                colorFlg = value;
            }
        }

        public bool PositionFlg
        {
            get
            {
                return positionFlg;
            }

            set
            {
                positionFlg = value;
            }
        }

        public bool SizeFlg
        {
            get
            {
                return sizeFlg;
            }

            set
            {
                sizeFlg = value;
            }
        }
    }
}
