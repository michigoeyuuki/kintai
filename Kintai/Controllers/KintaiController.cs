using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kintai.Models;

namespace Kintai.Controllers
{
  public class KintaiController : Controller
  {
    private KintaiContext db = new KintaiContext();

    //
    // GET: /Kintai/
    // 初期画面表示時

    public ActionResult Index()
    {
      //とりあえず全件
      //ログインしたユーザーのUserCodeと現在の年を検索条件で検索かける？
      return View(db.AttendanceMonths.ToList());
    }

    //
    // GET: /Kintai/Create
    //  新規登録初期表示

    public ActionResult Create()
    {
      return View();
    }

    //
    // POST: /Kintai/Create
    //  新規登録画面　保存押下時

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(AttendanceMonth attendancemonth)
    {
      if (ModelState.IsValid)
      {
        db.AttendanceMonths.Add(attendancemonth);
        db.SaveChanges();
        return RedirectToAction("Index");
      }

      return View(attendancemonth);
    }

    //
    // GET: /Kintai/Edit/5
    // 編集画面初期表示
    public ActionResult Edit(int id = 0)
    {
      AttendanceMonth attendancemonth = db.AttendanceMonths.Find(id);
      if (attendancemonth == null)
      {
        return HttpNotFound();
      }
      return View(attendancemonth);
    }

    //
    //  POST: /Kintai/Edit/5
    //  編集画面　保存ボタン押下時
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(AttendanceMonth attendancemonth)
    {
      if (ModelState.IsValid)
      {
        db.Entry(attendancemonth).State = EntityState.Modified;
        db.SaveChanges();
        return RedirectToAction("Index");
      }
      return View(attendancemonth);
    }

  }
}