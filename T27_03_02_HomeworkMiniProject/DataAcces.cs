namespace T27_03_02_HomeworkMiniProject
{
    internal static class DataAcces
    {
        public static void SaveToCSV<T>(this List<T> items, string filePath)
        {
            var cols = typeof(T).GetProperties();

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

                foreach (var col in cols)
                {
                    string? val = col.GetValue(item)?.ToString();
                    row += $";{val}";
                }

                row = row[1..];
                rows.Add(row);
            }

            File.WriteAllLines(filePath, rows);
        }
    }
}
