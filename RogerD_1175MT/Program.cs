using System;
using static System.Console;

namespace RogerD_1175MT
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask user to enter the student name and id and store the value entered.
            Write("Student Name and Id: ");
            string basicInfo = ReadLine();
            //Call method to obtain user inputs of variables staffName, staffRole, initialAnnualSalary and numYears
            GetStaffDetailsAndNumYears(out string staffName, out char staffRole, out double initialAnnualSalary, out int numYears);
            //Create an object using Staff class
            Staff staffObject = new Staff(staffName, staffRole, initialAnnualSalary);
            Write("\n\n");
            //Display the user inputs thought ToString method.
            WriteLine(staffObject);
            //Call method to obtain and display the income table for the staff
            DisplayIncomeTable(staffObject, numYears);
        }

        //Create a call by reference void method to obtain the user inputs for variables staffName, staffRole, initialAnnualSalary and numYears
        static void GetStaffDetailsAndNumYears(out string staffName, out char staffRole, out double initialAnnualSalary, out int numYears)
        {
            //Ask user for the staff name and store the value entered.
            Write("Enter the staff's name: ");
            staffName = ReadLine();
            //Set up a loop to validate user input in staffName variable.
            while (staffName == "")
            {
                Write("Staff name cannot be empty. Please re-enter the staff name: ");
                staffName = ReadLine();
            }

            //Ask user for the staff role.
            Write("Enter the staff role (J-Junior, S-Senior): ");
            //Set up a loop to validate user input in staffRole variable.
            while (!char.TryParse(ReadLine(), out staffRole) || (staffRole != 'J' && staffRole != 'S'))
            {
                //Validate if the user is entering the correct value. If it is entering the correct value store the value and go out the loop, if
                //not ask user to enter again.
                Write("Staff role must be valid character ('J' or 'S'), please re-enter the staff role (J-Junior, S-Senior): ");
            }

            //Ask user for the initial annual salary.
            Write("Enter the initial annual salary: ");
            //Set up a loop to validate user input in innitialAnnualSalary variable.
            while (!double.TryParse(ReadLine(), out initialAnnualSalary) || initialAnnualSalary <= 0)
            {
                //Validate if the user is entering the correct value. If it is entering the correct value store the value and go out the loop, if
                //not ask user to enter again.
                Write("Salary must a valid double > 0. Please re-enter the initial annual salary: ");
            }

            //Ask user for the number of years.
            Write("Enter the number of years to generate the income table: ");
            //Set up a loop to validate user input in numYears variable.
            while (!int.TryParse(ReadLine(), out numYears) || numYears <= 0)
            {
                //Validate if the user is entering the correct value. If it is entering the correct value store the value and go out the loop, if
                //not ask user to enter again.
                Write("Years should be a valid integer > 0. Please re-enter the number of years: ");
            }

        }

        //Create a void method to display the income table based on user inputs of object and method previously created.
        static void DisplayIncomeTable(Staff staffObj, int numYears)
        {
            //Create counter variable (yearCount) as well as salary and income variable.
            int yearCount = 1;
            double salary = staffObj.InitialSalary;
            double income;
            //Set up a loop to forecast income for the staff based on the years the user declared.
            while(yearCount <= numYears)
            {
                income = salary + staffObj.Bonus;
                salary = salary + (salary * (staffObj.RaiseRate / 100));
                Write("Income as of year " + yearCount + " is " + income.ToString("C2") + "\n");
                yearCount++;
            }

        }



    }
}
