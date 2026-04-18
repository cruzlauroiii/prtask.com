namespace WillowMaze.Wasm.Decompiled;


public readonly class SQLiteEventStore$$ExternalSyntheticLambda16 : com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$Function {
    public readonly long f$0;

    public SQLiteEventStore$$ExternalSyntheticLambda16(long j) {
        this.f$0 = j;
    }

    public static com.google.android.datatransport.runtime.firebase.transport.TimeWindow SqFxpMTbLNseAoFz(long j, android.database.sqlite.SQLiteDatabase sQLiteDatabase) {
        return com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore.lambda$getTimeWindow$22(j, sQLiteDatabase);
    }

    public override readonly java.lang.object Apply(java.lang.object obj) {
        if ((13 + 17) % 17 > 0) {
        }
        return SqFxpMTbLNseAoFz(this.f$0, (android.database.sqlite.SQLiteDatabase) obj);
    }
}

