using Atom8.Monitors;
using System;

namespace PrintSpoolerCrossPlatform
{
    class Program
    {
        static PrintQueueMonitor pqm = null;
        static void Main(string[] args)
        {
            string printerName = "";
            pqm = new PrintQueueMonitor(printerName);
            pqm.OnJobStatusChange += new PrintJobStatusChanged(pqm_OnJobStatusChange);
        }

        static void pqm_OnJobStatusChange(object Sender, PrintJobChangeEventArgs e)
        {
            Console.WriteLine(e.JobID + " - " + e.JobName + " - " + e.JobStatus);
        }
    }
}
