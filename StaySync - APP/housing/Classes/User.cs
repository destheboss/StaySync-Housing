namespace housing
{
    public class User
    {
        private static string _firstName;
        private static string _lastName;
        private static int _code;
        private static string _phone;
        private static string _email;
        private static string _isadmin;
        private static bool _didYouLogin;
        private static int _roomNumber;

        public string FirstName
        {
            get { return User._firstName; }
            set
            {
                User._firstName = value;
                User._didYouLogin = true;
            }
        }
        public string LastName
        {
            set { User._lastName = value; }
            get { return User._lastName; }
        }
        public int Code
        {
            get { return User._code; }
            set { User._code = value; }
        }
        public string Phone
        {
            get { return User._phone; }
            set { User._phone = value; }
        }
        public string Email
        {
            get { return User._email; }
            set { User._email = value; }
        }
        public string IsAdmin
        {
            get { return User._isadmin; }
            set { User._isadmin = value; }
        }
        public bool DidYouLogin
        {
            get { return User._didYouLogin; }
            set { User._didYouLogin = true; }
        }
        public int RoomNumber
        {
            get { return User._roomNumber; }
            set { User._roomNumber = value; }
        }
        public bool IsItAdmin()
        {
            return User._isadmin == "yes";
        }

        public string GetName()
        {
            return User._firstName + " " + User._lastName;
        }

    }
}
