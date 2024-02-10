using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // create linked list
        LinkedList<Student> list = new LinkedList<Student>();

        // menu in the loop
        while (true)
        {  
            Console.WriteLine("\nMenu");
            Console.WriteLine("---Students---");
            Console.WriteLine("1. Add New Student");
            Console.WriteLine("2. Remove Studnet");
            Console.WriteLine("3. Display All Students");
            Console.WriteLine("---Labs---");
            Console.WriteLine("4. Add Lab");
            Console.WriteLine("5. Remove Lab");
            Console.WriteLine("6. Update Lab");
            Console.WriteLine("7. Display Lab");
            Console.WriteLine("---Assignments---");
            Console.WriteLine("8. Add Assignment");
            Console.WriteLine("9. Remove Assignment");
            Console.WriteLine("10. Update Lab");
            Console.WriteLine("11. Display Assignment");
            Console.WriteLine("---Exit---");
            Console.WriteLine("0. Exit");

            Console.Write("\nEnter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddStudent(list);
                    break;
                case 2:
                    RemoveStudent(list);
                    break;
                case 3:
                    DisplayStudent(list);
                    break;
                case 4:
                    AddLab(FindStudent(list));
                    break;
                case 5:
                    RemoveLab(FindStudent(list));
                    break;
                case 6:
                    UpdateLab(FindStudent(list));
                    break;
                case 7:
                    DisplayLab(FindStudent(list));
                    break;
                case 8:
                    AddAssignment(FindStudent(list));
                    break;
                case 9:
                    RemoveAssignment(FindStudent(list));
                    break;
                case 10:
                    UpdateAssignment(FindStudent(list));
                    break;
                case 11:
                    DisplayAssignments(FindStudent(list));
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;

            }
        }
        
    }

    // method for menu 1, add student
    static void AddStudent(LinkedList<Student> list)
    {
        Student student = new Student();
        Console.Write("Enter first name: ");
        student.FirstName = Console.ReadLine();
        Console.Write("Enter last name: ");
        student.LastName = Console.ReadLine();

        bool exists = false;
        foreach (var existingStudent in list)
        {
            if (existingStudent.FirstName.Equals(student.FirstName, StringComparison.OrdinalIgnoreCase) &&
                existingStudent.LastName.Equals(student.LastName, StringComparison.OrdinalIgnoreCase))
            {
                exists = true;
                break;
            }
        }

        if (exists)
        {
            Console.WriteLine("Student with the same name already exists.");
        }
        else
        {
            list.AddLast(student);
            Console.WriteLine("Student added successfully.");
        }
    }

    // method for menu 2, remove student
    static void RemoveStudent(LinkedList<Student> list)
    {
        Console.Write("Enter first name: ");
        string FirstName = Console.ReadLine();
        Console.Write("Enter last name: ");
        string LastName = Console.ReadLine();

        Student studentToRemove = null;
        foreach (var existingStudent in list)
        {
            if (existingStudent.FirstName.Equals(FirstName, StringComparison.OrdinalIgnoreCase) &&
                existingStudent.LastName.Equals(LastName, StringComparison.OrdinalIgnoreCase))
            {
                studentToRemove = existingStudent;
                break;
            }
        }

        if (studentToRemove != null)
        {
            list.Remove(studentToRemove);
            Console.WriteLine($"Student {FirstName} {LastName} removed successfully.");
        }
        else
        {
            Console.WriteLine("Student not found. Please enter a valid name.");
        }
    }

    // method for menu 3, display student
    static void DisplayStudent(LinkedList<Student> list)
    {
        foreach (Student student in list)
        {
            Console.WriteLine(student.ToString());
        }
    }

    // method for menu 3 - 11, finding the exist student 
    static Student FindStudent(LinkedList<Student> list)
    {
        // find the student to add lab
        Console.Write("Enter first name: ");
        string FirstName = Console.ReadLine();
        Console.Write("Enter last name: ");
        string LastName = Console.ReadLine();

        Student student = null;
        foreach (var existingStudent in list)
        {
            if (existingStudent.FirstName.Equals(FirstName, StringComparison.OrdinalIgnoreCase) &&
                existingStudent.LastName.Equals(LastName, StringComparison.OrdinalIgnoreCase))
            {
                student = existingStudent;
                break;
            }
        }

        return student;
    }

    // method for menu 4, add lab
    static void AddLab(Student stu)
    {
        if (stu != null)
        {
            stu.AddLab();
        }
        else
        {
            Console.WriteLine("Student not found. Please enter a valid name.");
        }
    }

    // method for menu 5, remove lab
    static void RemoveLab(Student stu)
    {
        if (stu != null)
        {
            stu.RemoveLab();
        }
        else
        {
            Console.WriteLine("Student not found. Please enter a valid name.");
        }
    }

    // method for menu 6, update lab
    static void UpdateLab(Student stu)
    {
        if (stu != null)
        {
            stu.UpdateLab();
        }
        else
        {
            Console.WriteLine("Student not found. Please enter a valid name.");
        }
    }

    // method for menu 7, display lab
    static void DisplayLab(Student stu)
    {
        if (stu != null)
        {
            stu.DisplayLabs();
        }
        else
        {
            Console.WriteLine("Student not found. Please enter a valid name.");
        }
    }

    // method for menu 8, add assignment
    static void AddAssignment(Student stu)
    {
        if (stu != null)
        {
            stu.AddAssignment();
        }
        else
        {
            Console.WriteLine("Student not found. Please enter a valid name.");
        }
    }

    // method for menu 9, remove assignment
    static void RemoveAssignment(Student stu)
    {
        if (stu != null)
        {
            stu.RemoveAssignment();
        }
        else
        {
            Console.WriteLine("Student not found. Please enter a valid name.");
        }
    }

    // method for menu 10, update assignment
    static void UpdateAssignment(Student stu)
    {
        if (stu != null)
        {
            stu.UpdateAssignment();
        }
        else
        {
            Console.WriteLine("Student not found. Please enter a valid name.");
        }
    }

    // method for menu 11, display assignment
    static void DisplayAssignments(Student stu)
    {
        if (stu != null)
        {
            stu.DisplayAssignments();
        }
        else
        {
            Console.WriteLine("Student not found. Please enter a valid name.");
        }
    }

}
