using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace Kintai.Models
{
  public class AttendanceMonth
  {
    [Key]
    [DisplayName("勤怠月")]
    public int Month { get; set; } //勤怠月
    public int UserCode { get; set; } //社員コード

    public List<AttendanceDay> AttendanceDays { get; set; }
  }
}