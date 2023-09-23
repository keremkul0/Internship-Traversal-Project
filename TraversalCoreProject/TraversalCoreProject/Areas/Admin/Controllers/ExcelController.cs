using BusinessLayer.Abstract;
using ClosedXML.Excel;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using OfficeOpenXml.ExternalReferences;
using Org.BouncyCastle.Utilities;
using TraversalCoreProject.Models;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    public class ExcelController : Controller
    {
        private readonly IExcelService _excelService;

        public ExcelController(IExcelService excelService)
        {
            _excelService = excelService;
        }

        public IActionResult Index()
        {
            return View();
        }


        public List<DestinationModel> DestinationList()
        {
            List<DestinationModel> destinationModels = new List<DestinationModel>();
            using (var c = new Context())
            {
                destinationModels = c.Destinations.Select(x => new DestinationModel
                {
                    City = x.City,
                    DayNight = x.DayNight,
                    Price = x.Price,
                    Capacity = x.Capacity,
                }).ToList();
            }
            return destinationModels;
        }

        public IActionResult StaticExcelReport()
        {
            return File(_excelService.ExcelList(DestinationList()), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "NewExcel.xlsx");

        }

        public IActionResult DestinationExcelReport()
        {
            using (var workBook = new XLWorkbook())
            {
                var workSheet = workBook.Worksheets.Add("Tour List");
                workSheet.Cell(1, 1).Value = "City";
                workSheet.Cell(1, 2).Value = "length of stay";
                workSheet.Cell(1, 3).Value = "Price";
                workSheet.Cell(1, 4).Value = "Capacity";

                int RowCount = 2;
                foreach (var item in DestinationList())
                {
                    workSheet.Cell(RowCount, 1).Value = item.City;
                    workSheet.Cell(RowCount, 2).Value = item.DayNight;
                    workSheet.Cell(RowCount, 3).Value = item.Price;
                    workSheet.Cell(RowCount, 4).Value = item.Capacity;
                }
                using (var stream = new MemoryStream())
                {
                    workBook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "NewList.xls");
                }
            }
        }
    }
}
