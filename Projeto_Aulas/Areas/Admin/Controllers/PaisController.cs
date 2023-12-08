using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using App.Context;
using App.Models;
using App.Filters;
using X.PagedList;
using System.Xml;
using System.Text;

namespace Grafico.Controllers
{
    [Area("Admin")]
    [AdminAuthorize]
    public class PaisController : Controller
    {
        private readonly AppDbContext _context;

        public PaisController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Pais
        public IActionResult Index(string botao, string? txtFiltro, string? selOrdenacao, int pagina = 1)
        {
            int pageSize = 10; // Número de itens por página

            IQueryable<Pais> listaView = _context.Paises.Include(c => c.Continente);

            if (botao == "Relatorio")
            {
                pageSize = listaView.Count();
            }

            if (txtFiltro != null && txtFiltro != "")
            {
                ViewData["txtFiltro"] = txtFiltro;
                listaView = listaView.Where(item => item.Nome.ToLower().Contains(txtFiltro.ToLower())
                                                || item.Capital.ToLower().Contains(txtFiltro.ToLower())
                                                    || item.Continente.Nome.ToLower().Contains(txtFiltro.ToLower()));
            }

            ViewData["Ordem"] = selOrdenacao;

            if (selOrdenacao == "Pais" || selOrdenacao == null)
            {
                listaView = listaView.OrderBy(item => item.Nome.ToLower());
            }
            else if (selOrdenacao == "Capital")
            {
                listaView = listaView.OrderByDescending(item => item.Capital.ToLower());
            }
            else if (selOrdenacao == "MenorPopulação")
            {
                listaView = listaView.OrderBy(item => item.Populacao);
            }
            else if (selOrdenacao == "MaiorPopulação")
            {
                listaView = listaView.OrderByDescending(item => item.Populacao);
            }
            else if (selOrdenacao == "Continente")
            {
                listaView = listaView.OrderBy(item => item.Continente);
            }

            //Verificando se o botão clicado foi o XML
            if (botao == "XML")
            {
                //Chamando o método para exportar o XML enviando como parâmentro a lista já filtrada
                return ExportarXML(listaView.ToList());
            }
            else if (botao == "Json")
            {
                //Chamando o método para exportar o Json enviando como parâmentro a lista já filtrada
                return ExportarJson(listaView.ToList());
            }

            return View(listaView.ToPagedList(pagina, pageSize));
        }

        private IActionResult ExportarXML(List<Pais> listaView)
        {
            var stream = new StringWriter();
            var xml = new XmlTextWriter(stream);

            xml.Formatting = System.Xml.Formatting.Indented;

            xml.WriteStartDocument();
            xml.WriteStartElement("Dados");

            xml.WriteStartElement("Países");
            foreach (var pais in listaView)
            {
                xml.WriteStartElement("País");
                xml.WriteElementString("Id", pais.IdPaises.ToString());
                xml.WriteElementString("Nome", pais.Nome);
                xml.WriteElementString("Capital", pais.Capital);
                xml.WriteElementString("População", pais.Populacao.ToString());
                xml.WriteElementString("Continente", pais.Continente.Nome);
                xml.WriteEndElement(); // </Pais>
            }
            xml.WriteEndElement(); // </Paises>

            xml.WriteEndElement(); // </Data>
            return File(Encoding.UTF8.GetBytes(stream.ToString()), "application/xml", "dados_paises.xml");
        }

        private IActionResult ExportarJson(List<Pais> listaView)
        {
            var json = new StringBuilder();
            json.AppendLine("{");
            json.AppendLine("  \"Países\": [");
            int total = 0;
            foreach (var pais in listaView)
            {
                json.AppendLine("    {");
                json.AppendLine($"      \"Id\": {pais.IdPaises},");
                json.AppendLine($"      \"Nome\": \"{pais.Nome}\",");
                json.AppendLine($"      \"Capital\": \"{pais.Capital}\",");
                json.AppendLine($"      \"Continente\": \"{pais.Continente.Nome}\",");
                json.AppendLine($"      \"População\": {pais.Populacao.ToString()}");
                json.AppendLine("    }");
                total++;
                if (total < listaView.Count())
                {
                    json.AppendLine("    ,");
                }
            }
            json.AppendLine("  ]");
            json.AppendLine("}");

            return File(Encoding.UTF8.GetBytes(json.ToString()), "application/json", "dados_paises.json");
        }

        // GET: Pais/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null || _context.Paises == null)
            {
                return NotFound();
            }

            var pais = _context.Paises
                .Include(p => p.Continente)
                .FirstOrDefault(m => m.IdPaises == id);
            if (pais == null)
            {
                return NotFound();
            }

            return View(pais);
        }

        // GET: Pais/Create
        public IActionResult Create()
        {
            ViewData["continenteID"] = new SelectList(_context.Continentes, "continenteID", "Nome");
            return View();
        }

        // POST: Pais/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Pais pais)
        {
            _context.Add(pais);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }

        // GET: Pais/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null || _context.Paises == null)
            {
                return NotFound();
            }

            var pais = _context.Paises.Find(id);
            if (pais == null)
            {
                return NotFound();
            }
            ViewData["continenteID"] = new SelectList(_context.Continentes, "continenteID", "Nome", pais.continenteID);
            return View(pais);
        }

        // POST: Pais/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Pais pais)
        {
            if (id != pais.IdPaises)
            {
                return NotFound();
            }

            try
            {
                _context.Update(pais);
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PaisExists(pais.IdPaises))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));

        }

        // GET: Pais/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null || _context.Paises == null)
            {
                return NotFound();
            }

            var pais = _context.Paises
                .Include(p => p.Continente)
                .FirstOrDefault(m => m.IdPaises == id);
            if (pais == null)
            {
                return NotFound();
            }

            return View(pais);
        }

        // POST: Pais/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            if (_context.Paises == null)
            {
                return Problem("Entity set 'AppDbContext.Paises'  is null.");
            }
            var pais = _context.Paises.Find(id);
            if (pais != null)
            {
                _context.Paises.Remove(pais);
            }

            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        private bool PaisExists(int id)
        {
            return (_context.Paises?.Any(e => e.IdPaises == id)).GetValueOrDefault();
        }

        public IActionResult Grafico()
        {
            return View();
        }

        public IActionResult ObterDadosParaGrafico()
        {
            var dados = _context.Paises.ToList();
            return Json(dados);
        }
    }
}
