namespace EstabelecimentoMRR
{
    public sealed class Session
    {
        public static readonly Session Instance = new Session();

        private Session() {}

        public int IdUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public string EmailUsuario { get; set; }

    }
}
