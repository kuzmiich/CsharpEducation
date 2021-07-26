using System.Text;
using DesignPatterns.GeneratingPatterns.Builder.ProductComponent;

namespace DesignPatterns.GeneratingPatterns.Builder.Product
{
    class Bread
    {
        public Bread()
        {
        }

        public Bread(Flour flour, Salt salt, Additive additives)
        {
            Flour = flour;
            Salt = salt;
            Additives = additives;
        }

        public Flour Flour { get; set; }
        public Salt Salt { get; set; }
        public Additive Additives { get; set; }
        private StringBuilder _stringBuilder = new StringBuilder();

        public override string ToString()
        {
            if (Flour != null)
                _stringBuilder.Append($"{Flour.Type}\n");

            if (Salt != null)
                _stringBuilder.Append("Salt \n");

            if (Additives != null)
                _stringBuilder.Append($"Additives - {Additives.Name}\n");

            return _stringBuilder.ToString();
        }
    }
}
