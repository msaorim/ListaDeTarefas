using System.ComponentModel.DataAnnotations;

namespace ListaDeTarefas.Models
{
    public class TarefaModel
    {
        [Key]
        public int TarefaId { get; set; }

        [Required]
        public string TarefaNome { get; set; }
        public DateTime TarefaHora { get; set; }
        public bool TarefaFeita { get; set; }
    }
}
