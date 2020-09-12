using System;
using System.Collections.Generic;
using System.Text;

namespace Class1WebApi.Data
{
   public interface ICandidate
    {
        int CandidateId { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        int Age
        {
            get; set;
        }
        bool IsAvailable { get; set; }
        string GetFullName();
        void ReturnNothing();
    }
}