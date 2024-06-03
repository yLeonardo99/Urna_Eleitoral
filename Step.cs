using System;

public class Step
{
	public int digits { get; private set; }
    public string title { get; private set; }
    public Position position { get; private set; }

    public Step(int digits, string title, Position position)
	{
		this.digits = digits;
		this.title = title;
		this.position = position;
	}
}
