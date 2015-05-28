namespace MvcApplication.Controllers
{
  using System.Web.Mvc;
  using System.Web.Security;
  using Kintai.Models;
  using System.Linq;

  public class UserController : Controller
  {
    //
    // GET: /User/Login

    [HttpGet]
    public ActionResult Login()
    {
      return this.View();
    }

    //
    // POST: /User/Login

    [HttpPost]
    public ActionResult Login(User model, string returnUrl)
    {
      using (var context = new KintaiContext())
      {
        var login_user = context.Users.Where(x => x.Code == model.Code);

        if (model.Code == "100" && model.Password == "hoge")
        {
          // ユーザー認証 成功
          FormsAuthentication.SetAuthCookie(model.Code, model.RememberMe);
          return this.Redirect(returnUrl);
        }
        else
        {
          // ユーザー認証 失敗
          this.ModelState.AddModelError(string.Empty, "指定されたユーザー名またはパスワードが正しくありません。");
          return this.View(model);
        }
      }
    }

  }
}