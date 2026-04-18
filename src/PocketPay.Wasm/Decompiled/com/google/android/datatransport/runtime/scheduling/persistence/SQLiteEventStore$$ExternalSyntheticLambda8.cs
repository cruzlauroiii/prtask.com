namespace WillowMaze.Wasm.Decompiled;


public readonly class SQLiteEventStore$$ExternalSyntheticLambda8 : com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$Function {
    public readonly com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore f$0;

    public SQLiteEventStore$$ExternalSyntheticLambda8(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore) {
        this.f$0 = sQLiteEventStore;
    }

    public static java.lang.object PmbCJeDAWDUyvYNl(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore, android.database.sqlite.SQLiteDatabase sQLiteDatabase) {
        return sQLiteEventStore.m87x18ea3bd6(sQLiteDatabase);
    }

    public override readonly java.lang.object Apply(java.lang.object obj) {
        return PmbCJeDAWDUyvYNl(this.f$0, (android.database.sqlite.SQLiteDatabase) obj);
    }
}

