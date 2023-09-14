using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutya
{
    internal class Dog
    {

        private int id;
        private int dogTypeId;
        private int dogNameId;
        private int age;
        private string[] doctorTime;

        public Dog(int id, int dogId, int nameId, int age, string[] doctorTime)
        {
            this.id = id;
            this.dogTypeId = dogId;
            this.dogNameId = nameId;
            this.age = age;
            this.doctorTime = doctorTime;
        }

        public int Id { get { return id; } }
        public int DogTypeId { get { return dogTypeId; } }
        public int DogNameId { get { return dogNameId; } }
        public int Age { get { return age; } }
        public string[] DoctorTime { get { return doctorTime; } }
    }
}
