﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace Day2
{

    public enum SecurityLevel { Admin, Hr ,Officer }

    public class Employee 
    {

        int id;
        int age;
        string name;
        float target;
        SecurityLevel securityLevel;
        float salary;
        HireDate hireDate;
        Gender gender;

        public Employee()
        {
            id = 0;
            age = 22;
            name = "ahmed";
            target = 3000;
            securityLevel = SecurityLevel.Hr;
            salary = 6000;
            hireDate = new HireDate();
            gender = Gender.Male;
        }

        public Employee(int _id, int _age, string _name, float _target, SecurityLevel _securityLevel, float _salary , HireDate _hireDate, Gender _gender)
        {
            id = _id;
            age = _age;
            name = _name;
            target = _target;
            securityLevel = _securityLevel;
            salary = _salary;
            hireDate = _hireDate;
            gender = _gender;
        }



        public string Name
        {
            get { return name; }
            set { name = value; }

        }
        public int ID
        {
            get { return id; }
            set { id = value; }

        }
        public int Age 
        {
            get { return age; }
           
            set { age = value; }
        }

        public float Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public float Target
        {
            get { return target; }
            set { target = value; }
        }
        public Gender Gender
        {
            get { return gender; }
            set { gender = value; }

        }

        public HireDate HireDate
        {
            get { return hireDate; }
            set { hireDate = value; }

        }

        public SecurityLevel SecurityLevel
        {
            get { return securityLevel; }
            set { securityLevel = value; }

        }


        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Age: {Age}, Target: {Target}, Salary: {Salary}, " +
                   $"Security Level: {SecurityLevel}, Gender: {Gender}, Hire Date: {HireDate}";
        }

    }



   
}