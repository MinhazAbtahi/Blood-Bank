

namespace Blood_Bank.Entities
{
    public class UserEntity
    {
        private string firstName;
        private string lastName;
        private string password;
        private string gender;
        private string bloodGroup;
        private string dob;
        private int contactNo;
        private string email;
        private string address;

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string Gender
        {
            get
            {
                return gender;
            }

            set
            {
                gender = value;
            }
        }

        public string BloodGroup
        {
            get
            {
                return bloodGroup;
            }

            set
            {
                bloodGroup = value;
            }
        }

        public string Dob
        {
            get
            {
                return dob;
            }

            set
            {
                dob = value;
            }
        }

        public int ContactNo
        {
            get
            {
                return contactNo;
            }

            set
            {
                contactNo = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }
    }
}
