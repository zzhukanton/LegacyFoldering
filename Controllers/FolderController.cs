using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LegacyFoldering.Controllers
{
    public class FolderController : Controller
    {
        // GET: Root
        [HttpGet]
        public JsonResult Root()
        {
            string[] data = Directory.GetFileSystemEntries(@"D:\");

            return Json(data);
        }
    }
}