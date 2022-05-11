using Reporting.Models.Database;
using Reporting.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Reporting.Models.Repository
{
    public class User : IUser
    {
        DatabaseContext Context;
        public User(DatabaseContext _context)
        {
            this.Context = _context;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(true);
        }

        public virtual void Dispose(bool val)
        {
            if (val)
            {
                Context.Dispose();
            }
        }
        public object empReport()
        {
            var list = (from p in Context.Employees select new { ID = p.id, empName = p.name, empPosition = p.position, empSalary = p.salary, empEmail = p.email_id, empContact = p.contact_no }).ToList();
            var salary = (from p in Context.Employees select p.salary).Sum();
            var count = (from p in Context.Employees select p).Count();
            employeedata data = new employeedata();
            data.data = list;
            data.salary = salary;
            data.totalemp = count;
            return data;
        }
        public object projectReport()
        {
            var list = (from p in Context.Projects select new { ID = p.id, Name = p.name, Budget =  p.budget, Cust_ID = p.customer_id }).ToList();
            var revenue = (from p in Context.Projects select p.budget).Sum();
            projectdata data = new projectdata();
            data.data = list;
            data.revenue = revenue;
            return data;
        }

        public object tsReport()
        {
            var list = (from p in Context.TaskAssignments select new { ID = p.id, taskID = p.task_id, empID = p.employee_id, msg = p.message, Status = p.is_completed == true ? "Completed" : "InProgress"  }).ToList();
            var completed = (from p in Context.TaskAssignments where p.is_completed==true  select p.is_completed).Count();
            tsdata data = new tsdata();
            data.data = list;
            data.completed = completed;
            return data;
        }
    }
}