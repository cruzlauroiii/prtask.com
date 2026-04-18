namespace WillowMaze.Wasm.Decompiled;


public readonly class SQLiteEventStore$$ExternalSyntheticLambda20 : com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$Producer {
    public readonly android.database.sqlite.SQLiteDatabase f$0;

    public SQLiteEventStore$$ExternalSyntheticLambda20(android.database.sqlite.SQLiteDatabase sQLiteDatabase) {
        this.f$0 = sQLiteDatabase;
    }

    public static java.lang.object GtonedcBgWTHUcaq(android.database.sqlite.SQLiteDatabase sQLiteDatabase) {
        return com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore.lambda$ensureBeginTransaction$24(sQLiteDatabase);
    }

    public override readonly java.lang.object Produce() {
        return gtonedcBgWTHUcaq(this.f$0);
    }
}

