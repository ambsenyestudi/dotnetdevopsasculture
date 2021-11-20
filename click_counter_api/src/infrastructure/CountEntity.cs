using System.ComponentModel.DataAnnotations;

namespace ClickCounter.Infrastructure
{
    public class CountEntity
    {   
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
