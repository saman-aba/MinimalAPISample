using System.ComponentModel.DataAnnotations;

namespace SixMinApi.Dtos
{
    public class CommandReadDto
    {        
        public int Id { get; set; }
        
        public string? Howto { get; set; }        
        
        public string? CommandLine { get; set; }
        public string? Platform { get; set; }
    }
}