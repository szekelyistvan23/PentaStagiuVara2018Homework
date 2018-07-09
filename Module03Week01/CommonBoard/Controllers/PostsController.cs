using CommonBoard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CommonBoard.Controllers
{
    public class PostsController : Controller
    {
        public static List<Post> posts = new List<Post>();
        public static int Id = 0;

        // GET: Posts
        public ActionResult Index()
        {
            return View(posts);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Post post)
        {
            if (post == null)
            {
                return HttpNotFound();
            }
                Id++;
                post.Id = Id;
                posts.Add(post);
                return RedirectToAction("Details");
        }

        [HttpGet]
        public ActionResult Details()
        {
            int lastPost = posts.Count;
            Post post = posts.Find(p => p.Id == lastPost);
            return View(post);
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            Post post = posts.Find(p => p.Id == id);
            if (post == null)
            {
                return HttpNotFound();
            }
            return View(post);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Post post = posts.Find(p => p.Id == id);
            posts.Remove(post);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            Post post = posts.Find(p => p.Id == id);
            if (post == null)
            {
                return HttpNotFound();
            }

            return View(post);
        }


        [HttpPost]
        public ActionResult Edit(Post post)
        {
            Post findPost = posts.Find(p => p.Id == post.Id);
            List<Post> result = new List<Post>();
            foreach (Post p in posts)
            {
                if (!p.Equals(findPost))
                {
                    result.Add(p);
                } else
                {
                    result.Add(post);
                }
            }
            posts = result;
            return RedirectToAction("Index");
        }
    }
}