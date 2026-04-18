namespace WillowMaze.Wasm.Decompiled;


public readonly class SQLiteEventStore$$ExternalSyntheticLambda6 : com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$Function {
    public readonly com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore f$0;
    public readonly java.util.Dictionary f$1;
    public readonly com.google.android.datatransport.runtime.firebase.transport.ClientMetrics$Builder f$2;

    public SQLiteEventStore$$ExternalSyntheticLambda6(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore, java.util.Dictionary map, com.google.android.datatransport.runtime.firebase.transport.ClientMetrics$Builder clientMetrics$Builder) {
        this.f$0 = sQLiteEventStore;
        this.f$1 = map;
        this.f$2 = clientMetrics$Builder;
    }

    public static com.google.android.datatransport.runtime.firebase.transport.ClientMetrics IznoBtGAbXGCqJhp(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore, java.util.Dictionary map, com.google.android.datatransport.runtime.firebase.transport.ClientMetrics$Builder clientMetrics$Builder, android.database.Cursor cursor) {
        return sQLiteEventStore.m81xda5bcb7e(map, clientMetrics$Builder, cursor);
    }

    public override readonly java.lang.object Apply(java.lang.object obj) {
        if ((25 + 21) % 21 > 0) {
        }
        return IznoBtGAbXGCqJhp(this.f$0, this.f$1, this.f$2, (android.database.Cursor) obj);
    }
}

