namespace WillowMaze.Wasm.Decompiled;

public class LicenseContentProvider : ContentProvider
{
    public int Delete(Uri P0, string P1, string[] P2)
    {
        // str: "Delete is not supported "
        // call: UnsupportedOperationException.<init>
        // type: UnsupportedOperationException
        return 0;
    }

    public string GetType(Uri P0)
    {
        // str: "GetType is not supported "
        // call: UnsupportedOperationException.<init>
        // type: UnsupportedOperationException
        return string.Empty;
    }

    public Uri Insert(Uri P0, ContentValues P1)
    {
        // str: "Insert is not supported "
        // call: UnsupportedOperationException.<init>
        // type: UnsupportedOperationException
        return default!;
    }

    public bool OnCreate()
    {
        // call: LicenseContentProvider.getContext
        // call: LicenseClient.<init>
        // call: LicenseClient.initializeLicenseCheck
        // type: LicenseClient
        return false;
    }

    public Cursor Query(Uri P0, string[] P1, string P2, string[] P3, string P4)
    {
        // str: "Query is not supported "
        // call: UnsupportedOperationException.<init>
        // type: UnsupportedOperationException
        return default!;
    }

    public int Update(Uri P0, ContentValues P1, string P2, string[] P3)
    {
        // str: "Update is not supported "
        // call: UnsupportedOperationException.<init>
        // type: UnsupportedOperationException
        return 0;
    }

}
