using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Kintai.Models
{
  public class AttendanceMonth
  {
    public int month { get; set;} //勤怠月
    public int user_code { get; set; } //社員コード
    public virtual ICollection<AttendanceDay> Days { get; set; }
  }
}