using System.Collections.Generic;

namespace Experity_Assessment.Interfaces
{
    public interface IPrintService
    {
        List<string> GetPrintNumber(int start, int end, string type);
    }
}
