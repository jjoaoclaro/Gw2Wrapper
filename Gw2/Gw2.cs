using System;

namespace Gw2
{
    public class Gw2
    {
        private string _ApiKey = "";

        public static string ApiKey
        {
            get
            {
                return _ApiKey;
            }
            set
            {
                this._ApiKey = value;
            }
        }
    }
}
