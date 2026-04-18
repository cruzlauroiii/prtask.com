namespace WillowMaze.Wasm.Decompiled;


public readonly class SQLiteEventStore$$ExternalSyntheticLambda19 : com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$Function {
    public readonly com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore f$0;

    public SQLiteEventStore$$ExternalSyntheticLambda19(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore) {
        this.f$0 = sQLiteEventStore;
    }

    public static java.lang.object QDJrfRKxemertuNk(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore, android.database.Cursor cursor) {
        return sQLiteEventStore.m77xc84244d8(cursor);
    }

    public override readonly java.lang.object Apply(java.lang.object obj) {
        return QDJrfRKxemertuNk(this.f$0, (android.database.Cursor) obj);
    }
}

