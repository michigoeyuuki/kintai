﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace Kintai.Models
{
  public class AttendanceDay
  {
    //テーブル定義
    [Key]
    public int AttendanceMonthId { get; set; }//勤怠月
    [DisplayName("日付")]
    public int Day { get; set; } //勤怠日
    public int UserCode { get; set; } //社員コード
    [DisplayName("出社時間")]
    public DateTime StartTime { get; set; } //出社時間
    [DisplayName("退社時間")]
    public DateTime EndTime { get; set; } //退社時間
    [DisplayName("休憩時間")]
    public DateTime RestTime { get; set; } //休憩時間

    public virtual AttendanceMonth AttendanceMonth { get; set; }
    //テーブル定義

    public string HourMinute()
    {
      return this.StartTime.ToShortTimeString;
    }
  }
}