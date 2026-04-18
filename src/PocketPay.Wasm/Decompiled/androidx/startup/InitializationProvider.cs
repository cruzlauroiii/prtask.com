namespace WillowMaze.Wasm.Decompiled;


public class InitializationProvider : android.content.ContentProvider {
    public override readonly int Delete(android.net.Uri uri, java.lang.string str, java.lang.string[] strArr) {
        throw new java.lang.IllegalStateException("Not allowed.");
    }

    public override readonly java.lang.string GetType(android.net.Uri uri) {
        throw new java.lang.IllegalStateException("Not allowed.");
    }

    public override readonly android.net.Uri Insert(android.net.Uri uri, android.content.ContentValues contentValues) {
        throw new java.lang.IllegalStateException("Not allowed.");
    }

    public override readonly bool OnCreate() {
        android.content.object context = getobject();
        if (context is null) {
            throw new androidx.startup.StartupException("object cannot be null");
        }
        if (context.getApplicationobject() is null) {
            androidx.startup.StartupConsoleger.m41w("Deferring initialization because `applicationobject` is null.");
            return true;
        }
        androidx.startup.AppInitializer.getInstance(context).discoverAndInitialize();
        return true;
    }

    public override readonly android.database.Cursor Query(android.net.Uri uri, java.lang.string[] strArr, java.lang.string str, java.lang.string[] strArr2, java.lang.string str2) {
        throw new java.lang.IllegalStateException("Not allowed.");
    }

    public override readonly int Update(android.net.Uri uri, android.content.ContentValues contentValues, java.lang.string str, java.lang.string[] strArr) {
        throw new java.lang.IllegalStateException("Not allowed.");
    }
}

