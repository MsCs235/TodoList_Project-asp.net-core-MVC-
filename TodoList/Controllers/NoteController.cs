using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoList.Models;
using TodoList.ViewModels;

namespace TodoList.Controllers
{
    public class NoteController : Controller
    {
        APPContext context = new APPContext();

        // GET: NoteController
        public ActionResult Index()
        {
            var UserId = HttpContext.Session.GetInt32("AuthId");
            List<Note> userNotes = context.Note.Where(e => e.UserID == UserId).ToList();
            return View("Index" , userNotes);
        }

        // GET: NoteController/Create
        public ActionResult Create()
        {
            CreateNoteValidate data = new CreateNoteValidate();
            return View("Create" , data);
        }

        // POST: NoteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateNoteValidate note)
        {
            var UserId = HttpContext.Session.GetInt32("AuthId");
            if (note.Title == null || note.Content == null) {
                TempData["error"] = "All form require to create note."; 
                return View("Create" , note);
            }
            

            try
            {
                Note newNote = new Note()
                {
                    Title = note.Title,
                    Content = note.Content,
                    UserID = UserId.Value,
                };

                context.Note.Add(newNote);
                context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: NoteController/Edit/5
        public ActionResult Edit(int id)
        {
            Note myNote = context.Note.FirstOrDefault(n => n.Id == id);
            return View("edit",myNote);
        }

        // POST: NoteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Note note)
        {
            var UserId = HttpContext.Session.GetInt32("AuthId");
            try
            {
                Note myNote = context.Note.FirstOrDefault(n => n.Id == note.Id);
                if (myNote != null) {
                    myNote.Title = note.Title;
                    myNote.Content = note.Content;
                    context.SaveChanges();
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        // POST: NoteController/Delete/5
        [HttpGet]
        public ActionResult Delete(int id)
        {
            try
            {
                Note myNote = context.Note.FirstOrDefault(n => n.Id == id);
                context.Note.Remove(myNote);
                context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
