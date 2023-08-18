namespace EmprestimoLivros.Models
{
    public class EmprestimosModel
    {
        public int id { get; set; }
        public string recebedor { get; set; }
        public string fornecedor { get; set; }
        public string livroEmprestado { get; set; }
        public DateTime dataUltimaAtualizacao { get; set; } =  DateTime.Now;

    }
}
