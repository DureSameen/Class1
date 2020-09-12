using System;

namespace Class1WebApi.Data
{
   public class Candidate : ICandidate
    {
        public string _myname;
        public int  CandidateId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {

                if (value < 13)
                    throw new Exception(" too young");
                else _age = value;
            }
        }
        public bool IsAvailable { get; set; }

        public Candidate()
        {
            FirstName = "firstname";
            LastName = "LastName";
            Age = 13;
            IsAvailable = true;


        }

        public Candidate(int id, string firstName, string lastname, int age, bool isAvailable)
        {
            FirstName = firstName;
            LastName = lastname;
            Age = age;
            IsAvailable = isAvailable;
            CandidateId = id;


        }
        public void ReturnNothing()
        { }

        public string GetFullName()
        { return FirstName + " " + LastName; }
    }
}
