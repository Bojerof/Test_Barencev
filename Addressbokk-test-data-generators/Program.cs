namespace Addressbokk_test_data_generators;

using System.Xml.Serialization;
using Newtonsoft.Json;
using Excel = Microsoft.Office.Interop.Excel;
using Work_6.Work;

class Program
{
    static void Main(string[] args)
    {
        int count = Convert.ToInt32(args[0]);
        string filename = args[1];
        string format = args[2];

        List<GroupData> groups = new List<GroupData>();

        for (int i = 0; i < count; i++)
        {
            groups.Add(new GroupData(TestBase.GenerateRandomString(10))
            {
                Header = TestBase.GenerateRandomString(10),
                Footer = TestBase.GenerateRandomString(10)
            });

        }
        if (format == "excel")
        {
            WriteGroupsToExcelFile(groups, filename);
        }
        else
        {
            StreamWriter writer = new StreamWriter(filename);
            if (format == "csv") WriteGroupsToCsvFile(groups, writer);
            else if (format == "xml") WriteGroupsToXmlFile(groups, writer);
            else if (format == "json") WriteGroupsToJsonFile(groups, writer);
            else Console.WriteLine("Unrecognized format " + format);
            writer.Close();
        }

    }

    static void WriteGroupsToExcelFile(List<GroupData> groups, string filename)
    {
        Excel.Application app = new Excel.Application();
        app.Visible = true;
        Excel.Workbook wb = app.Workbooks.Add();
        Excel.Worksheet sheet = (Excel.Worksheet)wb.ActiveSheet;
        sheet.Cells[1, 1] = "test";

    }

    static void WriteGroupsToCsvFile(List<GroupData> groups, StreamWriter writer)
    {
        foreach (var group in groups)
        {
            writer.WriteLine(String.Format("{0}, {1}, {2}", group.Name, group.Header, group.Footer));
        }
    }

    static void WriteGroupsToXmlFile(List<GroupData> groups, StreamWriter writer)
    {
        new XmlSerializer(typeof(List<GroupData>)).Serialize(writer, groups);
    }

    static void WriteGroupsToJsonFile(List<GroupData> groups, StreamWriter writer)
    {
        writer.Write(JsonConvert.SerializeObject(groups, Formatting.Indented));
    }
}
