using System;
using System.Collections.Generic;

namespace referenciamento.api.Domain
{
    public class Prontuario
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public string Nome { get; set; }
        public string NomeSocial { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string NIS { get; set; }
        public string Telefone { get; set; }
        public DateTime? DataRef { get; set; }
        public string TecRef { get; set; }
        public IList<ProntuarioProgramaSocial> Programas { get; set; }
        public SituacaoCadastroEnum SituacaoCadastro { get; set; }
        public int AnoAtualizacaoSituacao { get; set; }
        public int ArquivoMorto { get; set; }
    }
}
