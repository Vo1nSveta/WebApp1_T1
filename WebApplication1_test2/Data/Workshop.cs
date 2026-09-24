using System.ComponentModel.DataAnnotations;

namespace WebApp1_T1.Data
{
    public class Workshop
    {
        public int Id{ get; set; }
        
            [Key]

            public string workshop { get; set; }

            public string equipment { get; set; }
    }
}
