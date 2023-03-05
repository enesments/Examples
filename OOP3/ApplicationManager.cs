using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class ApplicationManager
    {

        //Method injection
        public void Application(ICreditBaseManager creditBaseManager,List<ILoggerService> loggerServices)
        {

            //Basvuran bilgilerini değerlendirme
            //
          
            creditBaseManager.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();

            }

        }
        public void CreditInformation(List<ICreditBaseManager> credits)
        {
            foreach (var credit  in credits)
            {
                credit.Calculate();
         
            }
        }
    }
}
