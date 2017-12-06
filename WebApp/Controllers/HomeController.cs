using DataAccess;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        UploadRepository repository;

        public HomeController()
        {
            repository = new UploadRepository();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Upload()
        {
            ViewBag.Message = "Uploads to date";

            var uploads = GetUploads();

            return View(uploads);
        }

        public ActionResult UploadFile(HttpPostedFileBase file)
        {
            // Read bytes from http input stream
            BinaryReader binaryReader = new BinaryReader(file.InputStream);
            byte[] binaryData = binaryReader.ReadBytes(file.ContentLength);

            string payload = Encoding.UTF8.GetString(binaryData);

            repository.InsertUpload(payload);

            var uploads = GetUploads();

            return View("Upload", uploads);
        }

        private IEnumerable<Models.Upload> GetUploads()
        {
            var uploads = repository.ReadUploads();
            var mapped = new List<Models.Upload>();

            if (uploads.Count() > 0)
            {
                mapped = uploads.Select(x =>
                    new Models.Upload
                    {
                        FirstName = x.User.FirstName,
                        LastName = x.User.LastName,
                        Payload = x.Payload,
                        Uploaded = x.Created
                    }).ToList();
            }

            return mapped;
        }
    }
}