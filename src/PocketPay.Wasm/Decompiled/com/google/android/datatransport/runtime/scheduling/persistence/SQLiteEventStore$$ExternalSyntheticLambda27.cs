namespace WillowMaze.Wasm.Decompiled;


public readonly class SQLiteEventStore$$ExternalSyntheticLambda27 : com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$Function {
    public readonly com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore f$0;

    public SQLiteEventStore$$ExternalSyntheticLambda27(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore) {
        this.f$0 = sQLiteEventStore;
    }

    public static java.lang.object QbgXezrakEphxJyU(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore, android.database.Cursor cursor) {
        return sQLiteEventStore.m85x70a49c2a(cursor);
    }

    public override readonly java.lang.object Apply(java.lang.object obj) {
        return QbgXezrakEphxJyU(this.f$0, (android.database.Cursor) obj);
    }
}

