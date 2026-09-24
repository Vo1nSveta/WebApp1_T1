using System.ComponentModel.DataAnnotations;

namespace WebApp1_T1.Data
{
    public class Workshop
    {
        [Key]
        public int Id { get; set; }
        
        public string workshop { get; set; }

        public string equipment { get; set; }
    }
}
