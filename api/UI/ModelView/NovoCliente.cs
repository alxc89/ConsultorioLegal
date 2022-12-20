namespace ConsultorioLegal.api.UI.ModelView
{
    /// <summary>
    /// Objeto utilizado para inserção de um novo cliente.
    /// </summary>
    public class NovoCliente
    {
        /// <summary>
        /// Nome do Cliente.
        /// </summary>
        /// <example>João Costa</example>  
        public string Nome { get; set; }
        /// <summary>
        /// Data do nascimento do cliente.
        /// </summary>
        /// <example>1988-01-01</example>
        public DateTime DataNascimento { get; set; }
        /// <summary>
        /// Sexo do cliente: M - Masculino; F - Feminino.
        /// </summary>
        /// <example>M</example>
        public char Sexo { get; set; }
        /// <summary>
        /// Telefone do cliente.
        /// </summary>
        /// <example>17-999990000</example>
        public string Telefone { get; set; }
        /// <summary>
        /// Documento do cliente: CNH, CPF ou RG
        /// </summary>
        /// <example>1232233422</example>
        public string Documento { get; set; }
    }
}
