namespace MyShop;

public interface IContext
{
    public void Update(List<string> list);
    public List<List<string>> GetMassiv();
}