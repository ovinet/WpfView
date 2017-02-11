namespace MyWarcraft.Utils
{
    public class Serializer
    {
        internal string Serialize(Serializable serializable)
        {
            return serializable.ToString();
        }
    }
}
