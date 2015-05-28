using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace Kintai.Models
{
  public class User
  {
    [Key]
    [DisplayName("社員コード")]
    public string Code { get; set;}//社員コード
    [DisplayName("社員名")]
    public string Name { get; set; }//社員名

    public string Password { get; set; }//ログインパスワード

    public bool RememberMe { get; set; }//ログイン保持フラグ
  }
}