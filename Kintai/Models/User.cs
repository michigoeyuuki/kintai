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
    public int code { get; set;}//社員コード
    [DisplayName("社員名")]
    public string name { get; set; }//社員名
  }
}