using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace housing.Classes
{
    internal class Chore
    {
        public int ID { get; set; }
        public string ChoreName { get; set; }
        public Person AssignedPerson { get; set; }
        public bool IsCompleted { get; set; }

        public Chore(int id, string choreName, Person assignedPerson)
        {
            ID = id;
            ChoreName = choreName;
            AssignedPerson = assignedPerson;
        }

        public string GetAssignedPersonFullName()
        {
            return $"{AssignedPerson?.FirstName} {AssignedPerson?.LastName}";
        }
        public string GetChoreInfoBasedOnId()
        {
            return $"{ChoreName}";
        }

        public string GetChoreStatusInfo()
        {
            string status = IsCompleted ? "Completed" : "Not Completed";
            string personInfo = AssignedPerson == null ? "No one" : GetAssignedPersonFullName();
            return $"{ID + 1}  ╠ {status} ■ {ChoreName} ⦿ {personInfo}  ";
        }
    }
}