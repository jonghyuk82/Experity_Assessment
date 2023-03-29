namespace Experity_Assessment.Models
{
    public class EventModel
    {
        private string _eventType;
        public string EventType
        {
            get { return _eventType; }
            set { _eventType = value; }
        }

        //public List<ReturnModel> GetPrintNumber(int start, int end, string type)
        //{
        //    List<ReturnModel> result = new List<ReturnModel>();
        //    switch (type)
        //    {
        //        case "Register":
        //            result = GetRegisterResult(start, end, type);
        //            break;
        //        case "Diagnose":
        //            result = GetDiagnoseResult(start, end, type);
        //            break;
        //        default:
        //            result = new List<ReturnModel>();
        //            break;
        //    }

        //    return result;
        //}

        //public List<ReturnModel> GetRegisterResult(int start, int end, string type)
        //{
        //    var list = new List<ReturnModel>();

        //    for (int i = start; i < end; i++)
        //    {
        //        if (i % 3 == 0 && i % 5 == 0)
        //        {
        //            list.Add(new ReturnModel { Number = "Register Patient" });
        //        }
        //        else if (i % 3 == 0)
        //        {
        //            list.Add(new ReturnModel { Number = "Register" });
        //        }
        //        else if (i % 5 == 0)
        //        {
        //            list.Add(new ReturnModel { Number = "Patient" });
        //        }
        //        else
        //        {
        //            list.Add(new ReturnModel { Number = i.ToString() });
        //        }
        //    }

        //    return list;
        //}

        //public List<ReturnModel> GetDiagnoseResult(int start, int end, string type)
        //{
        //    var list = new List<ReturnModel>();

        //    for (int i = start; i < end; i++)
        //    {
        //        if (i % 2 == 0 && i % 7 == 0)
        //        {
        //            list.Add(new ReturnModel { Number = "Diagnose Patient" });
        //        }
        //        else if (i % 2 == 0)
        //        {
        //            list.Add(new ReturnModel { Number = "Diagnose" });
        //        }
        //        else if (i % 7 == 0)
        //        {
        //            list.Add(new ReturnModel { Number = "Patient" });
        //        }
        //        else
        //        {
        //            list.Add(new ReturnModel { Number = i.ToString() });
        //        }
        //    }

        //    return list;
        //}
    }
}
