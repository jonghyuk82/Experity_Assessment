using Experity_Assessment.Interfaces;
using System.Collections.Generic;
using System.Windows;

namespace Experity_Assessment.Services
{
    public class PrintService : IPrintService
    {
        public List<string> GetPrintNumber(int start, int end, string type)
        {
            List<string> result = new List<string>();
            switch (type)
            {
                case "Register":
                    result = GetRegisterResult(start, end, type);
                    break;
                case "Diagnose":
                    result = GetDiagnoseResult(start, end, type);
                    break;
                default:
                    MessageBox.Show("Invalid type");
                    break;
            }

            return result;
        }

        public List<string> GetRegisterResult(int start, int end, string type)
        {
            var list = new List<string>();

            for (int i = start; i < end; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    list.Add("Register Patient");
                }
                else if (i % 3 == 0)
                {
                    list.Add("Register");
                }
                else if (i % 5 == 0)
                {
                    list.Add("Patient");
                }
                else
                {
                    list.Add(i.ToString());
                }
            }

            return list;
        }

        public List<string> GetDiagnoseResult(int start, int end, string type)
        {
            var list = new List<string>();

            for (int i = start; i < end; i++)
            {
                if (i % 2 == 0 && i % 7 == 0)
                {
                    list.Add("Diagnose Patient");
                }
                else if (i % 2 == 0)
                {
                    list.Add("Diagnose");
                }
                else if (i % 7 == 0)
                {
                    list.Add("Patient");
                }
                else
                {
                    list.Add(i.ToString());
                }
            }

            return list;
        }
    }
}
