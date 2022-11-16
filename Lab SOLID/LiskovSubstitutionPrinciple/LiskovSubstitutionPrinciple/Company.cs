using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitutionPrinciple
{
    public class Company
    {
        List<IWorker> workers;
        List<IEmployee> employees;

        public Company( List<IWorker> workers, List<IEmployee> employees)
        {
            this.employees = employees;
            this.workers = workers;
        }

      

        public void MenageWorkers()
        {
            foreach  (IWorker worker in workers)
            {
                worker.Work();
            }
            foreach (IEmployee employee in employees)
            {
               
                employee.GetPaid();
                employee.Sleep();
            }
        }
    }
}
