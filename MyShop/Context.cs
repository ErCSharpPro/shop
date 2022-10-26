namespace MyShop;

public class Context:IContext
{
    private static  List<List<string>> proList = new List<List<string>>();
    public void Update(List<string> list)
    {
        proList.Add(list);
    }

    public List<List<string>> GetMassiv()
    {
        return proList;
    }
}