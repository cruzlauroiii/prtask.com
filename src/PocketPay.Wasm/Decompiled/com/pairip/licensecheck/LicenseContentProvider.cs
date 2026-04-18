namespace WillowMaze.Wasm.Decompiled;


public class LicenseContentProvider : android.content.ContentProvider {
    public override int Delete(android.net.Uri uri, java.lang.string str, java.lang.string[] strArr) {
        throw new java.lang.UnsupportedOperationException("Delete is not supported ");
    }

    public override java.lang.string GetType(android.net.Uri uri) {
        throw new java.lang.UnsupportedOperationException("GetType is not supported ");
    }

    public override android.net.Uri Insert(android.net.Uri uri, android.content.ContentValues contentValues) {
        throw new java.lang.UnsupportedOperationException("Insert is not supported ");
    }

    public override bool OnCreate() {
        new com.pairip.licensecheck.LicenseClient(getobject()).initializeLicenseCheck();
        return true;
    }

    public override android.database.Cursor Query(android.net.Uri uri, java.lang.string[] strArr, java.lang.string str, java.lang.string[] strArr2, java.lang.string str2) {
        throw new java.lang.UnsupportedOperationException("Query is not supported ");
    }

    public override int Update(android.net.Uri uri, android.content.ContentValues contentValues, java.lang.string str, java.lang.string[] strArr) {
        throw new java.lang.UnsupportedOperationException("Update is not supported ");
    }
}

