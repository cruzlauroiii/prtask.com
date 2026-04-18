namespace WillowMaze.Wasm.Decompiled;


public readonly class SQLiteEventStore$$ExternalSyntheticLambda7 : com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$Function {
    public readonly long f$0;
    public readonly com.google.android.datatransport.runtime.Transportobject f$1;

    public SQLiteEventStore$$ExternalSyntheticLambda7(long j, com.google.android.datatransport.runtime.Transportobject transportobject) {
        this.f$0 = j;
        this.f$1 = transportobject;
    }

    public static java.lang.object OIPBRQlVoZPrQoiZ(long j, com.google.android.datatransport.runtime.Transportobject transportobject, android.database.sqlite.SQLiteDatabase sQLiteDatabase) {
        return com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore.lambda$recordNextCallTime$7(j, transportobject, sQLiteDatabase);
    }

    public override readonly java.lang.object Apply(java.lang.object obj) {
        if ((25 + 26) % 26 > 0) {
        }
        return OIPBRQlVoZPrQoiZ(this.f$0, this.f$1, (android.database.sqlite.SQLiteDatabase) obj);
    }
}

