using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Kintai.Models
{
  public class AttendanceDay
  {
    [Key]
    public int AttendanceMonthId { get; set; }//勤怠月
    public int Day { get; set; } //勤怠日
    public int UserCode { get; set; } //社員コード
    public DateTime StartTime { get; set; } //出社時間
    public DateTime EndTime { get; set; } //退社時間
    public DateTime RestTime { get; set; } //休憩時間
  }
}