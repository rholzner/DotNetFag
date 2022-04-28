public class EndPointApiGet
{
    private IEnumerable<CoolItem> Data;

    public EndPointApiGet()
    {
        Data = new CoolItem[] { new CoolItem(1, "Kalle anka"), new CoolItem(2, "Batman"), new CoolItem(3, "Robin"), new CoolItem(4, "SuperMan"), new CoolItem(5, "Arnold"), };
    }

    public IEnumerable<CoolItem> GetAll()
    {
        return Data;
    }

    public CoolItem Get(int id)
    {
        return Data.FirstOrDefault(x => x.id == id) ?? throw new ArgumentException("no result");
    }
}

public record CoolItem(int id, string name);


