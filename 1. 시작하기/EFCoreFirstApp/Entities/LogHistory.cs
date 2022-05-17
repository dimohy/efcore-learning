using System.ComponentModel.DataAnnotations;

namespace EFCoreFirstApp.Entities;
public class LogHistory
{
    [Key]
    public int Seq { get; set; }
    public string Detail { get; set; }
    public DateTime CreateTime { get; set; } = DateTime.Now;

    public LogHistory(string detail)
    {
        Detail = detail;
    }
}
