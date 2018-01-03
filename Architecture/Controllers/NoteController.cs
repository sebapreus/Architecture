using Services;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModels.Notes;

namespace Architecture.Controllers
{
    public class NoteController : Controller
    {
        INoteService _noteService;

        public NoteController(INoteService noteService)
        {
            _noteService = noteService;
        }

        // GET: Note
        public ActionResult Index()
        {
            var notes = _noteService.GetAllNotes();
            return View(notes);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(NoteViewModel noteViewModel)
        {
            if (ModelState.IsValid)
            {
                _noteService.Create(noteViewModel);
                return RedirectToAction("Index");
            }
            return View(noteViewModel);
            
        }
    }
}