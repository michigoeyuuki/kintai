using System.Data.Entity;

namespace Kintai.Models
{
  public class KintaiContext : DbContext
  {
        // このファイルにカスタム コードを追加できます。変更は上書きされません。
        // 
        // モデル スキーマを変更するときに、自動的に Entity Framework によって
        // データベースを破棄して生成し直す場合は、次のコードを Global.asax の
        // Application_Start メソッドに追加してください。
        // 注意: モデルが変更されるたびに、データベースが破棄され、再作成されます。
        // 
        // System.Data.Entity.Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseIfModelChanges<Kintai.Models.KintaiContext>());

        public KintaiContext() : base("name=KintaiContext")
        {
        }

        public DbSet<AttendanceMonth> AttendanceMonths { get; set; }
        public DbSet<AttendanceDay> AttendanceDays { get; set; }
        public DbSet<User> Users { get; set; }
  }
}
