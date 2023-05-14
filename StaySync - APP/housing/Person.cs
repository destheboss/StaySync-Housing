namespace housing
{
    public class Person
    {
        private string _firstName;
        private string _lastName;
        private int _code;
        private string _phone;
        private string _email;
        private string _isAdmin;
        private int _roomNumber;
        private string _isPresent;

        public string FirstName
        {
            get { return this._firstName; }
            set { this._firstName = value; }
        }

        public string LastName
        {
            get { return this._lastName; }
            set { this._lastName = value; }
        }

        public int Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        public string Phone
        {
            get { return this._phone; }
            set { this._phone = value; }
        }

        public string Email
        {
            get { return this._email; }
            set { this._email = value; }
        }

        public string IsAdmin
        {
            get { return this._isAdmin; }
            set { this._isAdmin = value; }
        }

        public int RoomNumber
        {
            get { return this._roomNumber; }
            set { this._roomNumber = value; }
        }

        public string IsPresent
        {
            get { return this._isPresent; }
            set { this._isPresent = value; }
        }

        public bool DoesTheCodeMatch(int code)
        {
            return this._code == code;
        }

        public bool DoesThePhoneMatch(string phone)
        {
            return phone == this._phone;
        }

        public void CreateUser()
        {
            User user = new User();
            user.FirstName = this._firstName;
            user.LastName = this._lastName;
            user.Code = this._code;
            user.Phone = this._phone;
            user.Email = this._email;
            user.IsAdmin = this._isAdmin;
            user.DidYouLogin = true;
            user.RoomNumber = this._roomNumber;
        }

        public void GetReadyToMail()
        {
            ForgetManager forget = new ForgetManager();
            forget.ItIsMailTime(this._email, this._code);
        }

        public string AddTenantWriter()
        {
            return this._firstName + "," + this._lastName + "," + this._code + "," + this._phone + "," + this._email + "," + this._isAdmin + "," + this._roomNumber + "," + this._isPresent;
        }
    }
}
