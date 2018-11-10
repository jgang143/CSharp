using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TwoC2P.Models;

namespace TwoC2P.Controllers
{
    public class ValidateResultController : ApiController
    {

        // GET: api/ValidateResult/CardNo/ExpiryDate
        public IHttpActionResult GetResult(string CardNo, string ExpiryDate)
        {
            using (TwoC2PEntities db = new TwoC2PEntities())
            {
                var res = db.ValidateCard(CardNo, ExpiryDate).FirstOrDefault<ValidateCard_Result>();
                if (res == null)
                    return NotFound();

                return Ok(res);
            }

        }

    }
}
