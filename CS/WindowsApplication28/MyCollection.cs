using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace WindowsApplication28
{
    public class Record
    {
        int id, age;
        string name;
        List<Record> detail;
        List<Record> _coWorkers;
        public Record(int id, string name, int age, List<Record> detail, List<Record> coWorkers)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.detail = detail;
            _coWorkers = coWorkers;
        }
        public int ID { get { return id; } }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public List<Record> CoWorkers
        {
            get { return _coWorkers; }
            //set { detail = value; }
        }
        public List<Record> Detail
        {
            get { return detail; }
            //set { detail = value; }
        }
    }
}
