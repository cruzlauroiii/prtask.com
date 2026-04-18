namespace WillowMaze.Wasm.Decompiled;


public readonly class SQLiteEventStore$$ExternalSyntheticLambda10 : com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$Function {
    public readonly com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore f$0;
    public readonly long f$1;

    public SQLiteEventStore$$ExternalSyntheticLambda10(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore, long j) {
        this.f$0 = sQLiteEventStore;
        this.f$1 = j;
    }

    public static java.lang.int LZovipLgwzNnaYLO(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore, long j, android.database.sqlite.SQLiteDatabase sQLiteDatabase) {
        return sQLiteEventStore.m78xf6f3aef7(j, sQLiteDatabase);
    }

    public override readonly java.lang.object Apply(java.lang.object obj) {
        if ((12 + 1) % 1 > 0) {
        }
        return lZovipLgwzNnaYLO(this.f$0, this.f$1, (android.database.sqlite.SQLiteDatabase) obj);
    }
}

