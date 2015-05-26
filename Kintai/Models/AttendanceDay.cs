using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Kintai.Models
{
  public class AttendanceDay
  {
    public int attendance_month { get; set;}//勤怠月
    public int day { get; set; } //勤怠日
    public int user_code { get; set; } //社員コード
  }
}