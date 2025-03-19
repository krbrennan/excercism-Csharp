public class Orm
{
    private Database database;

    public Orm(Database database)
    {
        this.database = database;
    }

    public void Begin()
    {
        database.BeginTransaction();
    }


    public void Write(string data)
    {
        try
        {
            database.Write(data);
        }
        catch (Exception)
        {
            database.Dispose();
            //throw new ArgumentException("bad write");
        }
    }

    public void Commit()
    {

    }
}
