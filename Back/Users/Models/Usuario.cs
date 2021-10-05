namespace Users.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string UsuarioName { get; set; }
        public string UsuarioAge { get; set; }
        public string UsuarioEmail { get; set; }
        private string UsuarioPassword { get; set; }
        private string UsuarioGender { get; set; }
    }
}