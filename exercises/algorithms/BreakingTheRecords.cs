static List<int> BreakingRecords(List<int> scores)
{
    int minRecord = scores[0];
    int maxRecord = scores[0];
    int minCount = 0;
    int maxCount = 0;

    for (int i = 1; i < scores.Count; i++)
    {
        if (scores[i] > maxRecord)
        {
            maxRecord = scores[i];
            maxCount++;
        }
        else if (scores[i] < minRecord)
        {
            minRecord = scores[i];
            minCount++;
        }
    }

    return new List<int> { maxCount, minCount };
}

List<int> scores = [12, 24, 10, 24];
List<int> result = BreakingRecords(scores);
