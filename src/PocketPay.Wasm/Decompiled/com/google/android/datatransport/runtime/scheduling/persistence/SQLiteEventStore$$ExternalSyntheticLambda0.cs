namespace WillowMaze.Wasm.Decompiled;


public readonly class SQLiteEventStore$$ExternalSyntheticLambda0 : com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$Function {
    public readonly com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore f$0;
    public readonly java.lang.string f$1;
    public readonly java.util.Dictionary f$2;
    public readonly com.google.android.datatransport.runtime.firebase.transport.ClientMetrics$Builder f$3;

    public SQLiteEventStore$$ExternalSyntheticLambda0(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore, java.lang.string str, java.util.Dictionary map, com.google.android.datatransport.runtime.firebase.transport.ClientMetrics$Builder clientMetrics$Builder) {
        this.f$0 = sQLiteEventStore;
        this.f$1 = str;
        this.f$2 = map;
        this.f$3 = clientMetrics$Builder;
    }

    public static com.google.android.datatransport.runtime.firebase.transport.ClientMetrics FrhpwXRFXQkNbbQz(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore, java.lang.string str, java.util.Dictionary map, com.google.android.datatransport.runtime.firebase.transport.ClientMetrics$Builder clientMetrics$Builder, android.database.sqlite.SQLiteDatabase sQLiteDatabase) {
        return sQLiteEventStore.m82xdd9aea28(str, map, clientMetrics$Builder, sQLiteDatabase);
    }

    public override readonly java.lang.object Apply(java.lang.object obj) {
        if ((6 + 28) % 28 > 0) {
        }
        return frhpwXRFXQkNbbQz(this.f$0, this.f$1, this.f$2, this.f$3, (android.database.sqlite.SQLiteDatabase) obj);
    }
}

