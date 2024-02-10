class Student
{
    // variables
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Queue<Lab> Labs { get; set; }
    public Stack<Assignment> Assignments { get; set; }
    
    // constructor
    public Student() {
        Labs = new Queue<Lab>();
        Assignments = new Stack<Assignment>();
    }

    // add lab method
    public void AddLab()
    {
        // input the lab information
        Console.Write("Enter lab number: ");
        int labNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter obtained score: ");
        double scoreObtained = double.Parse(Console.ReadLine());
        Console.Write("Enter max score: ");
        double maxScore = double.Parse(Console.ReadLine());
        
        // Check if lab number already exists
        if (Labs.Any(l => l.LabNumber == labNumber))
        {
            Console.WriteLine($"Lab {labNumber} already exists for {FirstName} {LastName}.");
            return;
        }

        // add new lab
        Labs.Enqueue(new Lab(labNumber, scoreObtained, maxScore));
        Console.WriteLine($"Lab {labNumber} added for {FirstName} {LastName}.");
    }

    // remove lab
    public void RemoveLab()
    {
        // input lab number
        Console.Write("Enter lab number: ");
        int labNumber = int.Parse(Console.ReadLine());

        // Find lab with given lab number
        Lab labToRemove = Labs.FirstOrDefault(l => l.LabNumber == labNumber);
        if (labToRemove != null)
        {
            Labs = new Queue<Lab>(Labs.Where(l => l.LabNumber != labNumber));
            Console.WriteLine($"Lab {labNumber} removed for {FirstName} {LastName}.");
        }
        else
        {
            Console.WriteLine($"Lab {labNumber} not found for {FirstName} {LastName}.");
        }
    }

    // update lab
    public void UpdateLab()
    {
        // input the lab information
        Console.Write("Enter lab number: ");
        int labNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter obtained score: ");
        double newScoreObtained = double.Parse(Console.ReadLine());
        Console.Write("Enter max score: ");
        double newMaxScore = double.Parse(Console.ReadLine());

        // Find lab with given lab number
        Lab labToUpdate = Labs.FirstOrDefault(l => l.LabNumber == labNumber);
        if (labToUpdate != null)
        {
            labToUpdate.ScoreObtained = newScoreObtained;
            labToUpdate.MaxScore = newMaxScore;
            Console.WriteLine($"Lab {labNumber} updated for {FirstName} {LastName}.");
        }
        else
        {
            Console.WriteLine($"Lab {labNumber} not found for {FirstName} {LastName}.");
        }
    }

    // display labs
    public void DisplayLabs()
    {
        Console.WriteLine($"Lab Details for {FirstName} {LastName}:");
        foreach (var lab in Labs)
        {
            Console.WriteLine($"Lab Number: {lab.LabNumber}, Score Obtained: {lab.ScoreObtained}, Max Score: {lab.MaxScore}");
        }
    }

    // add assignment
    public void AddAssignment()
    {
        // input the assignment information
        Console.Write("Enter assignment number: ");
        int assignmentNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter obtained score: ");
        double scoreObtained = double.Parse(Console.ReadLine());
        Console.Write("Enter max score: ");
        double maxScore = double.Parse(Console.ReadLine());

        // Check if assignment number already exists
        if (Assignments.Any(a => a.AssignmentNumber == assignmentNumber))
        {
            Console.WriteLine($"Assignment {assignmentNumber} already exists for {FirstName} {LastName}.");
            return;
        }

        Assignments.Push(new Assignment(assignmentNumber, scoreObtained, maxScore));
        Console.WriteLine($"Assignment {assignmentNumber} added for {FirstName} {LastName}.");
    }

    public void RemoveAssignment()
    {
        Console.Write("Enter assignment number: ");
        int assignmentNumber = int.Parse(Console.ReadLine());

        // Find assignment with given assignment number
        Assignment assignmentToRemove = Assignments.FirstOrDefault(a => a.AssignmentNumber == assignmentNumber);
        if (assignmentToRemove != null)
        {
            Assignments = new Stack<Assignment>(new Stack<Assignment>(Assignments.Where(a => a.AssignmentNumber != assignmentNumber)));
            Console.WriteLine($"Assignment {assignmentNumber} removed for {FirstName} {LastName}.");
        }
        else
        {
            Console.WriteLine($"Assignment {assignmentNumber} not found for {FirstName} {LastName}.");
        }
    }

    // update assignemnt
    public void UpdateAssignment()
    {
        // input the assignment information
        Console.Write("Enter assignment number: ");
        int assignmentNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter obtained score: ");
        double newScoreObtained = double.Parse(Console.ReadLine());
        Console.Write("Enter max score: ");
        double newMaxScore = double.Parse(Console.ReadLine());

        // Find assignment with given assignment number
        Assignment assignmentToUpdate = Assignments.FirstOrDefault(a => a.AssignmentNumber == assignmentNumber);
        if (assignmentToUpdate != null)
        {
            assignmentToUpdate.ScoreObtained = newScoreObtained;
            assignmentToUpdate.MaxScore = newMaxScore;
            Console.WriteLine($"Assignment {assignmentNumber} updated for {FirstName} {LastName}.");
        }
        else
        {
            Console.WriteLine($"Assignment {assignmentNumber} not found for {FirstName} {LastName}.");
        }
    }

    // display assignement
    public void DisplayAssignments()
    {
        Console.WriteLine($"Assignment Details for {FirstName} {LastName}:");
        foreach (var assignment in Assignments)
        {
            Console.WriteLine($"Assignment Number: {assignment.AssignmentNumber}, Score Obtained: {assignment.ScoreObtained}, Max Score: {assignment.MaxScore}");
        }
    }


    // calculate %age of lab
    public double GetLabPercentageScore()
    {
        if (Labs.Count == 0)
            return 0;

        double totalScore = 0;
        double totalMaxScore = 0;

        foreach (var lab in Labs)
        {
            totalScore += lab.ScoreObtained;
            totalMaxScore += lab.MaxScore;
        }

        return Math.Round((totalScore / totalMaxScore) * 100);
    }

    // calculate %age of assignments
    public double GetAssignmentPercentageScore()
    {
        if (Assignments.Count == 0)
            return 0;

        double totalScore = 0;
        double totalMaxScore = 0;

        foreach (var assignment in Assignments)
        {
            totalScore += assignment.ScoreObtained;
            totalMaxScore += assignment.MaxScore;
        }

        return Math.Round((totalScore / totalMaxScore) * 100);
    }
    public override string ToString()
    {
        return $"\nName: {FirstName} {LastName}" +
                "\n%age Score of Labs: " + GetLabPercentageScore() + "%" +
                "\n%age Score of Assignments: " + GetAssignmentPercentageScore() + "%";
    }

}

