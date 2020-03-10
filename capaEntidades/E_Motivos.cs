namespace capaEntidades
{
    public class E_Motivos
    {
        private int _id;
        private string _codificacion;
        private string _motivo;
        private int _ap;

        public int Id { get => _id; set => _id = value; }
        public string Codificacion { get => _codificacion; set => _codificacion = value; }
        public string Motivo { get => _motivo; set => _motivo = value; }
        public int Ap { get => _ap; set => _ap = value; }
    }
}
