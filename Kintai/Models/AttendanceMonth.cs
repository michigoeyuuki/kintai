using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Kintai.Models
{
  public class AttendanceMonth
  {
    [Key]
    public int Month { get; set; } //勤怠月
    public int UserCode { get; set; } //社員コード

    public virtual ICollection<AttendanceDay> AttendanceDays { get; set; }
  }
}