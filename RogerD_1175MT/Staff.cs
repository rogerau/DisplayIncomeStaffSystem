using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogerD_1175MT
{
    class Staff
    {

        //1. Define auto properties
        public string StaffName //read-only property
        {
            get;
        }

        public char StaffRole //read-only property
        {
            get;
        }

        public double InitialSalary //read-only property
        {
            get;
        }

        public double RaiseRate //computed read-only property
        {
            get
            {
                //Set up a if else conditional to assign raise rate based on the type of staff (Junior or Senior)
                double flatRate = 0.95;
                double baseRate;

                if (StaffRole == 'S')
                {
                    baseRate = flatRate + 0.4;
                }
                else
                    baseRate = flatRate;
                return baseRate;
            }
        }


        public int Bonus //computed read-only property
        {
            get
            {
                //Set up a if else conditional to assign bonus base on the type of staff (Junior or Senior)
                int extraBonus;

                if (StaffRole == 'S')
                {
                    extraBonus = 5000;
                }
                else
                    extraBonus = 3000;
                return extraBonus;
            }
        }

        //2. Define constructors
        //Default constructor (add flexibility to the class)
        public Staff()
        {

        }

        //Constructor with 3 parameters
        public Staff(string staffName, char staffRole, double initialSalary)
        {
            StaffName = staffName;
            StaffRole = staffRole;
            InitialSalary = initialSalary;

        }

        //Define override method ToString
        public override string ToString()
        {
            string asterisk = new string('*', 80);
            string objectStr1 = String.Format(
                "*{0,35}: {1,-41}*", "Staff Name", StaffName);
            string objectStr2 = String.Format(
                "*{0,35}: {1,-41}*", "Staff Role", StaffRole);
            string objectStr3 = String.Format(
                "*{0,35}: {1,-41}*", "Initial Annual Salary", InitialSalary.ToString("C2"));
            string objectStr4 = String.Format(
                "*{0,35}: {1,-41}*", "Raise Rate", RaiseRate.ToString("F2"));
            string objectStr5 = String.Format(
                 "*{0,35}: {1,-41}*", "Bonus", Bonus.ToString("C2"));

            return asterisk + "\n" +
                   objectStr1 + "\n" +
                   objectStr2 + "\n" +
                   objectStr3 + "\n" +
                   objectStr4 + "\n" +
                   objectStr5 + "\n" +
                   asterisk;
        }
    }
}
