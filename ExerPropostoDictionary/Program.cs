namespace ExerPropostoDictionary
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    Dictionary<string, int> votesForCandidates = new Dictionary<string, int>();

                    while (!sr.EndOfStream)
                    {
                        string[] votingRecord = sr.ReadLine().Split(",");
                        string candidate = votingRecord[0];
                        int votes = int.Parse(votingRecord[1]);

                        if (votesForCandidates.ContainsKey(candidate))
                        {
                            votesForCandidates[candidate] += votes;
                        }
                        else
                        {
                            votesForCandidates[candidate] = votes;
                        }
                    }

                    foreach (var item in votesForCandidates)
                    {
                        Console.WriteLine(item.Key + " : " + item.Value);
                    }
                }
            }
            catch (IOException error)
            {
                Console.WriteLine("An erro ocurred: " + error.Message);
            }
        }
    }
}