using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.VisualBasic.FileIO;

namespace Sales
{
    static class CsvFile
    {
        public static void Export(
            SalesDatabaseContext dataContext, string filename)
        {
            Encoding encode = Encoding.GetEncoding("shift_jis");
            using (StreamWriter w = new StreamWriter(filename, false, encode))
            {
                string format = "\"{0}\", {1}, \"{2}\", \"{3}\",{4}";
                foreach (Result x in dataContext.Results)
                {
                    string s = string.Format(
                        format,
                        x.Date.ToString("yyyy/MM"),
                        x.SectionId,
                        x.Client,
                        x.Title,
                        x.Price);
                    string[] array = s.Split(',');
                    int i = 0;
                    foreach (string v in array)
                    {
                        if (i != 1)
                        {
                            w.Write(v);
                            if (i != 4)
                            {
                                w.Write(",");
                            }
                        }
                        i++;
                    }
                    w.WriteLine("");
                }
            }
        }

        public static void Import(
            SalesDatabaseContext dataContext,string filename)
        {
            List<Result> rows = GetImportRows(filename);
            foreach(Result x in rows)
            {
                dataContext.Results.Add(x);
            }
            dataContext.SaveChanges();
        }

        private static List<Result> GetImportRows(string filename)
        {
            List<Result> list = new List<Result>();
            Encoding encode = Encoding.GetEncoding("Shift_Jis");
            using(TextFieldParser p = new TextFieldParser(filename, encode))
            {
                p.TextFieldType = FieldType.Delimited;
                p.SetDelimiters(",");
                p.HasFieldsEnclosedInQuotes = true;
                p.TrimWhiteSpace = false;
                while (!p.EndOfData)
                {
                    string[] a = p.ReadFields();
                    int j = 0;
                    string[] b = new string[5];
                    foreach(string u in a)
                    {
                        if (j == 0)
                        {

                            b[0] = u + "/01";
                            b[1] = "1";
                            j = 2;
                        }
                        else if (j > 1)
                        {
                            b[j] = u;
                            j++;
                        }
                    }
                    Result row = CreateModel(b);
                    list.Add(row);
                }
            }
            return list;

        }

        private static Result CreateModel(string[] fields)
        {
            const int importFieldCount = 5;
            if (fields.Length != importFieldCount)
            {
                throw new ImportDataException(null);
            }
            var q =
                from x in fields
                where x == null
                select x;
            if (q.Any()) throw new ImportDataException(null);

            Result result = new Result();
            try
            {
                result.Date = DateTime.Parse(fields[0]);
                result.SectionId = byte.Parse(fields[1]);
                result.Client = fields[2];
                result.Title = fields[3];
                result.Price = int.Parse(fields[4]);
            }
            catch(Exception ex)
            {
                throw new ImportDataException(ex);
            }
            return result;
        }

    }
}
