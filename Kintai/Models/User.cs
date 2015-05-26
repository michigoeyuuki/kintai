using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Kintai.Models
{
  public class User
  {
    [Key]
    public int code { get; set;}//社員コード
    public string name { get; set;}//社員名
  }
}