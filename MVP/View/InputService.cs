namespace MVP.View
{
    public class InputService : IInputService
    {
        public decimal GetDecimal(string data) => decimal.TryParse(data, out var outData) ? outData : default;
    }
}
