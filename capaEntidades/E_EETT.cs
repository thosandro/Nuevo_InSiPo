namespace capaEntidades
{
    public class E_EETT
    {
        private int _id;
        private string _codificacion;
        private string _nombreCompleto;
        private string _sistemaAsociado;

        public int Id { get => _id; set => _id = value; }
        public string Codificacion { get => _codificacion; set => _codificacion = value; }
        public string NombreCompleto { get => _nombreCompleto; set => _nombreCompleto = value; }
        public string SistemaAsociado { get => _sistemaAsociado; set => _sistemaAsociado = value; }
    }
}
