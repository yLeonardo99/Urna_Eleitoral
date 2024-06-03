using System;

public class Candidate
{
    public int number {  get; private set; }
    public string name { get; private set; }
    public Bitmap image { get; private set; }
    public string party { get; private set; }
    public Position position { get; private set; }
    public int votes { get; private set; }

    public Candidate(int number, string name, string party, Bitmap image, Position position)
	{
        this.number = number;
        this.name = name;
        this.image = image;
        this.party = party;
        this.position = position;
        this.votes = 0;
	}

    public void addVote()
    {
        this.votes++;
    }
}
