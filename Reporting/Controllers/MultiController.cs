using Reporting.Models.Database;
using Reporting.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Reporting.Controllers
{
    public class MultiController : ApiController
    {
        private readonly IUser _UserType;
        public MultiController()
        {
            this._UserType = new User(new DatabaseContext());

        }

        [HttpGet]
        [Route("api/empReport")]
        public object emp()
        {
            try
            {
                var list = _UserType.empReport();
                return new
                {
                    list,
                    code = "00",
                    message = "Employee Report"
                };
            }
            catch (Exception)
            {
                return new
                {
                    code = "03",
                    message = "Cannot Process Request"
                };
            }
        }
        [HttpGet]
        [Route("api/projectReport")]
        public object project()
        {
            try
            {
                var list = _UserType.projectReport();
                return new
                {
                    list,
                    code = "00",
                    message = "Project Report"
                };
            }
            catch (Exception)
            {
                return new
                {
                    code = "03",
                    message = "Cannot Process Request"
                };
            }
        }
        [HttpGet]
        [Route("api/tsReport")]
        public object ts()
        {
            try
            {
                var list = _UserType.tsReport();
                return new
                {
                    list,
                    code = "00",
                    message = "Task Assignment Report"
                };
            }
            catch (Exception e)
            {
                return new
                {
                    code = "03",
                    message = e.ToString()
                };
            }
        }
    }
}
