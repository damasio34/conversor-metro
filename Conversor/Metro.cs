namespace Conversor
{
    public class Metro : UnidadeMedida<Metro>, IUnidadeMedida
    {
        public string Sigla { get { return "m"; } }

        public Metro() {}

        public Metro(decimal valor)
        {
            this.Valor = valor;
        }

        public static implicit operator Metro(Kilometro km)
        {
            return new Metro(km.Valor * 1000);
        }

        public static implicit operator Metro(Milimetro mm)
        {
            return new Metro(mm.Valor / 1000);
        }
    }
}
