namespace Conversor
{
    public class Kilometro : UnidadeMedida<Kilometro>, IUnidadeMedida
    {
        public string Sigla { get { return "km"; } }

        public Kilometro() {}

        public Kilometro(decimal valor)
        {
            this.Valor = valor;
        }

        public static implicit operator Kilometro(Metro m)
        {
            return new Kilometro(m.Valor / 1000);
        }

        public static implicit operator Kilometro(Milimetro mm)
        {
            return new Kilometro(mm.Valor / 1000000);
        }
    }
}
