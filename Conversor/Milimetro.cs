namespace Conversor
{
    public class Milimetro : UnidadeMedida<Milimetro>, IUnidadeMedida
    {
        public string Sigla { get { return "mm"; } }

        public Milimetro() {}

        public Milimetro(decimal valor)
        {
            this.Valor = valor;
        }

        public static implicit operator Milimetro(Metro m)
        {
            return new Milimetro(m.Valor * 1000);
        }

        public static implicit operator Milimetro(Kilometro km)
        {
            return new Milimetro(km.Valor * 1000000);
        }
    }
}
