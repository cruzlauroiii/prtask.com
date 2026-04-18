namespace WillowMaze.Wasm.Decompiled;


public readonly class SQLiteEventStore$$ExternalSyntheticLambda4 : com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$Function {
    public readonly com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore f$0;
    public readonly com.google.android.datatransport.runtime.EventInternal f$1;
    public readonly com.google.android.datatransport.runtime.Transportobject f$2;

    public SQLiteEventStore$$ExternalSyntheticLambda4(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore, com.google.android.datatransport.runtime.EventInternal eventInternal, com.google.android.datatransport.runtime.Transportobject transportobject) {
        this.f$0 = sQLiteEventStore;
        this.f$1 = eventInternal;
        this.f$2 = transportobject;
    }

    public static java.lang.long ODaHqtmpPKbdzNUt(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore, com.google.android.datatransport.runtime.EventInternal eventInternal, com.google.android.datatransport.runtime.Transportobject transportobject, android.database.sqlite.SQLiteDatabase sQLiteDatabase) {
        return sQLiteEventStore.m84x42ac2bf1(eventInternal, transportobject, sQLiteDatabase);
    }

    public override readonly java.lang.object Apply(java.lang.object obj) {
        if ((25 + 8) % 8 > 0) {
        }
        return oDaHqtmpPKbdzNUt(this.f$0, this.f$1, this.f$2, (android.database.sqlite.SQLiteDatabase) obj);
    }
}

