using System;

namespace ConfigClass
{
    public class Config
    {
        private int type;
        private int typeString = 0;
        private int typeStringArray = 1;
        private int typeCredential = 2;

        //init get set
        public String StringValue { get; set; }
        public String[] StringArray { get; set; }
        public String Username { get; set; }
        public System.Security.SecureString SecureString { get; set; }

        //init Construct
        public Config()
        {
            this.StringValue = null;
            this.StringArray = null;
            this.Username = null;
            this.SecureString = null;
            this.type = 3;
        }
        public Config(String StringValue)
        {
            this.StringValue = StringValue;
            this.StringArray = new string[] { };
            this.Username = String.Empty;
            this.SecureString = new System.Security.SecureString();
            this.type = typeString;
        }
        public Config(String[] StringArray)
        {
            this.StringArray = StringArray;
            this.StringValue = String.Join(",", StringArray);
            this.Username = String.Empty;
            this.SecureString = new System.Security.SecureString();
            this.type = typeStringArray;
        }
        public Config(String Username, System.Security.SecureString Password)
        {
            this.StringValue = Username.Substring(0, 1) + "*";
            this.StringArray = new string[] { };
            this.Username = Username;
            this.SecureString = Password;
            this.type = typeCredential;
        }

        //method
        public bool IsEmpty()
        {
            /*if (type == typeString)
            {
                if (StringValue == null) return true; if (String.IsNullOrEmpty(StringValue) || String.IsNullOrWhiteSpace(StringValue)) return true; else return false;
            }
            else if (type == typeStringArray)
            {
                if (StringArray == null) return true; else if (StringArray.Length == 0) return true; else return false;
            }
            else if (type == typeCredential)
            {
                if (SecureString == null) return true; else return false;
            }
            else return true;*/
            switch (type)
            {
                case 0: if (StringValue == null) return true; if (String.IsNullOrEmpty(StringValue) || String.IsNullOrWhiteSpace(StringValue)) return true; else return false;
                case 1: if (StringArray == null) return true; else if (StringArray.Length == 0) return true; else return false;
                case 2: if (SecureString == null) return true;else return false;
                default: return true;
            }
        }
        public override string ToString()
        {
            return StringValue;
            //return base.ToString();
        }
    }
}
