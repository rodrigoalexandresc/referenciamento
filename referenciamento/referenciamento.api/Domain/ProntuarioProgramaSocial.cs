namespace referenciamento.api.Domain
{
    public class ProntuarioProgramaSocial
    {
        public int Id { get; set; }
        public int DomicilioId { get; set; }
        public virtual Prontuario Domicilio { get; set; }
        public ProgramaSocialEnum ProgramaSocial { get; set; }
    }
}