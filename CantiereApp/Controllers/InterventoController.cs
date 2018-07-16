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
    public class InterventoController : Controller
    {
        // GET: Intervento
        public ActionResult Index()
        {
            return View("NuovoIntervento");
        }

        public ActionResult NuovoIntervento(string NomeCliente, string luogo)
        {
            //NuovoIntervento n = new NuovoIntervento()
            //{
            //    NomeCliente = NomeCliente,
            //    Luogo = luogo

            //};
            return View();
        }

        public async Task<IActionResult> InserisciIntervento ([FromForm] Intervento i)
        {
            Intervento intervento = new Intervento()
            {
                NomeCliente = i.NomeCliente,
                Data = DateTime.Now,
                Luogo = i.Luogo,
                Lavoro = i.Lavoro,
                Tipologia = i.Tipologia,
                Note = i.Note,
                Prezzo = i.Prezzo,
                Foto = ""
            };

            if (i.Tipologia == "elettrico")
            {
                using (SqlConnection connection = new SqlConnection(""))
                {
                    var query = "INSERT INTO [dbo].[InterventoEsterno]" +
                                "([NomeCliente], [Luogo] , [Data], [Lavoro], [Foto]) " +
                                "VALUES (@NomeCliente, @Luogo, @Data, @Lavoro, @Foto)";

                    connection.Execute(query, intervento);

                    connection.Close();
                }

            }
            
           
           
            if (i.Tipologia != "elettrico")
            {
                using (SqlConnection connection = new SqlConnection(""))
                {
                    var query = "INSERT INTO [dbo].[Intervento]" +
                                "([NomeCliente], [Luogo] , [Data], [Lavoro], [Tipologia], [Note], [Prezzo], [Foto]) " +
                                "VALUES (@NomeCliente, @Luogo, @Data, @Lavoro, @Tipologia, @Note, @Prezzo, @Foto)";

                    connection.Execute(query, intervento);

                    connection.Close();
                }
            }

            return RedirectToAction("Index", "Cantiere");
        }


        // GET: Intervento/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Intervento/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Intervento/Create
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

        // GET: Intervento/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Intervento/Edit/5
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

        // GET: Intervento/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Intervento/Delete/5
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