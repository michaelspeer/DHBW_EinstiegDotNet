using System;
using System.Collections.Generic;
using System.Linq;

namespace CSVViewer
{
    class Program
    {
        static void Main(string[] args)
        {
            var allLinesFromFile = System.IO.File.ReadAllLines(args[0]);

            var allLinesSplitToValues = GetAllLinesAndValues(allLinesFromFile);
            var columnHeaders = GetHeaderValues(allLinesSplitToValues);
            var allDataLines = GetAllDataLinesAndValue(allLinesSplitToValues);

            var columnMaxWidths = GetMaxWidthsForColumns(columnHeaders, allLinesSplitToValues);

            var output = new List<string>();

            output.Add(CreateOutputForHeader(columnHeaders, columnMaxWidths));
            output.Add(CreateOutputForHeaderUnderline(columnHeaders, columnMaxWidths));
            output.AddRange(CreateOutputForDataLines(allDataLines, columnMaxWidths));

            output.ForEach(Console.WriteLine);
        }

        private static string[][] GetAllLinesAndValues(string[] allLinesFromFile)
        {
            return allLinesFromFile.Select(line => line.Split(';')).ToArray();
        }

        private static string[] GetHeaderValues(string[][] allLinesSplitToValues)
        {
            return allLinesSplitToValues.First();
        }

        private static string[][] GetAllDataLinesAndValue(string[][] allLinesSplitToValues)
        {
            return allLinesSplitToValues.Skip(1).ToArray();
        }

        private static int[] GetMaxWidthsForColumns(string[] columnHeaders, string[][] allLinesSplitToValues)
        {
            return columnHeaders.Select((column, index) => allLinesSplitToValues.Max(line => line[index].Length)).ToArray();
        }

        private static string CreateOutputForHeader(string[] columnHeaders, int[] columnMaxWidths)
        {
            return String.Concat(columnHeaders.Select((columnHeader, columnIndex) => columnHeader.PadRight(columnMaxWidths[columnIndex]) + "|"));
        }

        private static string CreateOutputForHeaderUnderline(string[] columnHeaders, int[] columnMaxWidths)
        {
            return String.Concat(columnHeaders.Select((columnHeader, columnIndex) => new string('-', columnMaxWidths[columnIndex]) + "+"));
        }

        private static IEnumerable<string> CreateOutputForDataLines(string[][] allDataLines, int[] columnMaxWidths)
        {
            return allDataLines.Select(line => String.Concat(line.Select((value, index) => value.PadRight(columnMaxWidths[index]) + "|")));
        }
    }
}
