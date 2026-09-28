using System;

public class HistoryItem
{
    public string Expression { get; set; }
    public string Result { get; set; }
    public DateTime Timestamp { get; set; }
    
    public HistoryItem(string expression, string result)
    {
        Expression = expression;
        Result = result;
        Timestamp = DateTime.Now;
    }
}

