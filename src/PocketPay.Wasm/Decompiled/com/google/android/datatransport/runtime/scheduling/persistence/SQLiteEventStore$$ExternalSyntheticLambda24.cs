namespace WillowMaze.Wasm.Decompiled;


public readonly class SQLiteEventStore$$ExternalSyntheticLambda24 : com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$Function {
    public readonly com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore f$0;
    public readonly com.google.android.datatransport.runtime.Transportobject f$1;

    public SQLiteEventStore$$ExternalSyntheticLambda24(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore, com.google.android.datatransport.runtime.Transportobject transportobject) {
        this.f$0 = sQLiteEventStore;
        this.f$1 = transportobject;
    }

    public static java.util.List GDiwmxBhPrZWEdIU(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore, com.google.android.datatransport.runtime.Transportobject transportobject, android.database.sqlite.SQLiteDatabase sQLiteDatabase) {
        return sQLiteEventStore.m80x21bf8b6a(transportobject, sQLiteDatabase);
    }

    public override readonly java.lang.object Apply(java.lang.object obj) {
        return gDiwmxBhPrZWEdIU(this.f$0, this.f$1, (android.database.sqlite.SQLiteDatabase) obj);
    }
}

