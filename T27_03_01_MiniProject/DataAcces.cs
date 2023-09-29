namespace T27_03_01_MiniProject
{
    public class DataAcces<T> where T : new()
    {
        public event EventHandler<T>? BadEntryFound;

        public void SaveToCSV(List<T> items, string filePath)
        {
            T entry = new();
            var cols = entry.GetType().GetProperties();

            List<string> rows = new();
            string row = "";

            foreach (var col in cols)
            {
                row += $",{col.Name}";
            }

            row = row[1..];
            rows.Add(row);

            foreach (var item in items)
            {
                row = "";
                bool badWordDetected = false;

                foreach (var col in cols)
                {
                    string? val = col.GetValue(item)?.ToString();
                    badWordDetected = BadWordDetector(val!);

                    if (badWordDetected)
                    {
                        BadEntryFound?.Invoke(this, item);
                        break;
                    }

                    row += $",{val}";
                }

                if (badWordDetected)
                {
                    continue;
                }

                row = row[1..];
                rows.Add(row);
            }

            File.WriteAllLines(filePath, rows);
        }

        private bool BadWordDetector(string stringToTest)
        {
            bool output = false;
            string lowerCaseTest = stringToTest.ToLower();

            if (lowerCaseTest.Contains("darn") || lowerCaseTest.Contains("heck"))
            {
                output = true;
            }

            return output;
        }
    }
}