class Paragraph
{
    string story = @"A Boy was given permission to put his hand into a, pitcher to get some filberts. But he took such a great fistful that he could not draw his hand out again. There he stood, unwillingto give up a single filbert and yet unable to get them all out at once? Vexed and disappointed he began to cry.";

    public void CountSentences()
    {
        char[] separators = { '.', '?' };
        string[] sentences = story.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        int noOfSenetances = sentences.Length;
       
        Console.WriteLine($"Sentence Counts: {noOfSenetances} and sentances are following:");
        foreach(var s in sentences)
        {
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine(s);
        }
    }

}