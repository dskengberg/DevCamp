using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MyHybridSite.Models;

namespace MyHybridSite.Controllers
{
    public class MvcLogController : Controller
    {
        // GET: MvcLog
        public async Task<ActionResult> Index()
        {
            Guid logId = Guid.NewGuid();
            Log log = new Log();
            log.Id = logId;
            log.TimeStamp = DateTime.Now;
            log.Message = "Message 1";
            Log.LogList.Add(logId, log);
            logId = Guid.NewGuid();
            log = new Log();
            log.Id = logId;
            log.TimeStamp = DateTime.Now;
            log.Message = "Message 2";
            Log.LogList.Add(logId, log);

            return View("Index", Log.LogList.Values);
        }

        // GET: MvcPerson/Edit/5
        public async Task<ActionResult> Edit(Guid id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Log log;
            if (!Log.LogList.TryGetValue(id, out log))
                return HttpNotFound();

            return View("Edit", log);
        }
    }
}
