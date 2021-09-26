using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //Başvuru
    class ApplicationManager
    {
        //Başvuru Yap.
        //public void MakeAnApplication(ICreditManager creditManager, ILoggerService loggerService) // Tek bir veri yollamak için yazılan kod
        public void MakeAnApplication(ICreditManager creditManager, List <ILoggerService> loggerServices)
        {
            creditManager.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void CreditPreliminaryEvaluation (List<ICreditManager> credits) // krediOnBilgiDeğerlendirmesi Hesaplanması

        {
            foreach (var credit in credits)
            {
                credit.Calculate();

            }
        }


    }
}
