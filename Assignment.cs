class Assignment
{
    public int AssignmentNumber { get; set; }
    public double ScoreObtained { get; set; }
    public double MaxScore { get; set; }
    public Assignment(int assignmentNumber, double scoreObtained, double maxScore)
    {
        AssignmentNumber = assignmentNumber;
        ScoreObtained = scoreObtained;
        MaxScore = maxScore;
    }
}
