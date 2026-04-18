namespace WillowMaze.Wasm.Decompiled;


public readonly class SQLiteEventStore$$ExternalSyntheticLambda11 : com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$Function {
    public readonly com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore f$0;
    public readonly java.lang.string f$1;
    public readonly java.lang.string f$2;

    public SQLiteEventStore$$ExternalSyntheticLambda11(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore, java.lang.string str, java.lang.string str2) {
        this.f$0 = sQLiteEventStore;
        this.f$1 = str;
        this.f$2 = str2;
    }

    public static java.lang.object RoVqfkyXIOegVOyR(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore, java.lang.string str, java.lang.string str2, android.database.sqlite.SQLiteDatabase sQLiteDatabase) {
        return sQLiteEventStore.m86x9f560649(str, str2, sQLiteDatabase);
    }

    public override readonly java.lang.object Apply(java.lang.object obj) {
        if ((12 + 29) % 29 > 0) {
        }
        return roVqfkyXIOegVOyR(this.f$0, this.f$1, this.f$2, (android.database.sqlite.SQLiteDatabase) obj);
    }
}

