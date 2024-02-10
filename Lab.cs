class Lab
{
    public int LabNumber { get; set; }
    public double ScoreObtained { get; set; }
    public double MaxScore { get; set; }
    public Lab(int labNumber, double scoreObtained, double maxScore)
    {
        LabNumber = labNumber;
        ScoreObtained = scoreObtained;
        MaxScore = maxScore;
    }
}
