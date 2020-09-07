using System;

namespace TesteAutomatizadoBootStrapDash.Utils
{
    class DadosParaInputs
    {
        public string Name { get; set; } = "Matheus";

        public string Email { get; set; } = "meuemail@gmail.com";

        public string Password { get; set; } = "123";

        public string Arquivo { get; set; } = "C://temp/Arquivo.docx";

        public string City { get; set; } = "Taquara";

        public string Message { get; set; } = "Olá você está sendo testado.";

        public string UserName { get; set; } = "UsuarioTeste";

        public string Addrress1 { get; set; } = "Rua 123";

        public string Address2 { get; set; } = "Avenida 456";

        public string State { get; set; } = "Rio Grande do Sul";

        public string Pincode { get; set; } = "90000000";

        public DateTime DateOfBirth { get; set; } = DateTime.Today;

        public int Valor { get; set; } = 5;
    }
}
