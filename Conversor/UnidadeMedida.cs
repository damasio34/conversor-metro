namespace Conversor
{
    public abstract class UnidadeMedida<T> where T : IUnidadeMedida, new()
    {
        public decimal Valor { get; set; }

        public static T operator +(UnidadeMedida<T> valor1, T valor2)
        {
            return new T { Valor = valor1.Valor + valor2.Valor };
        }

        public static T operator -(UnidadeMedida<T> valor1, T valor2)
        {
            return new T { Valor = valor1.Valor - valor2.Valor };
        }

        public static bool operator == (UnidadeMedida<T> valor1, T valor2)
        {
            return valor1.Valor == valor1.Valor;
        }

        public static bool operator != (UnidadeMedida<T> valor1, T valor2)
        {
            return valor1.Valor != valor2.Valor;
        }

        public static bool operator <(UnidadeMedida<T> valor1, T valor2)
        {
            return valor1.Valor < valor2.Valor;
        }

        public static bool operator >(UnidadeMedida<T> valor1, T valor2)
        {
            return valor1.Valor > valor2.Valor;
        }

        public override bool Equals(object obj)
        {
            var r = obj as UnidadeMedida<T>;
            if (r != null)
            {
                return r == this;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Valor.GetHashCode();
        }
    }
}
