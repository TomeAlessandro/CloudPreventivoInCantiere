using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using CantiereApp.Models;
using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CantiereApp.Controllers
{
    public class CantiereController : Controller
    {
        // GET: Cantiere
        public async Task<ActionResult> Index()
        {
            var list = await GetCantieri();

            return View(list);
        }

        [HttpGet]
        public IActionResult NuovoCantiere()
        {
            return View();
        }

        public async Task<IEnumerable<Cantiere>> GetCantieri()
        {
            using (SqlConnection connection = new SqlConnection(""))
            {
                var query = $"select * from [dbo].[Cantiere]";

                return (await connection.QueryAsync<Cantiere>(query)).ToList();
            }
        }


        [HttpPost]
        public async Task<IActionResult> NuovoCantiere([FromForm] Cantiere c)
        {
            Cantiere ca = new Cantiere
            {
                NomeCliente = c.NomeCliente,
                Luogo = c.Luogo,
                EmailCliente=c.EmailCliente
            };

            using (SqlConnection connection = new SqlConnection(""))
            {
                var query = "INSERT INTO [dbo].[Cantiere]" +
                            "([NomeCliente], [Luogo] ,[EmailCliente])  " +
                            "VALUES (@NomeCliente, @Luogo, @EmailCliente)";

                connection.Execute(query, ca);

                connection.Close();
            }

            return View("Index");

        }

        // GET: Cantiere/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Cantiere/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cantiere/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Cantiere/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cantiere/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Cantiere/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cantiere/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}