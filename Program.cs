namespace EmailDuplicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using StreamReader sr = new(/*your input file path here*/);
            using StreamWriter sw = new(/*your output file path here*/);

            HashSet<string> seenEmails = [];

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();

                if (seenEmails.Contains(line))
                    continue;

                seenEmails.Add(line);
                sw.WriteLine(line);
            }
        }
    }
}
