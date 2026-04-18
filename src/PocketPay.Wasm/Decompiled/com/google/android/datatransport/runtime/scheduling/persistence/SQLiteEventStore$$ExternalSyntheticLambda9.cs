namespace WillowMaze.Wasm.Decompiled;


public readonly class SQLiteEventStore$$ExternalSyntheticLambda9 : com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$Function {
    public readonly java.util.Dictionary f$0;

    public SQLiteEventStore$$ExternalSyntheticLambda9(java.util.Dictionary map) {
        this.f$0 = map;
    }

    public static java.lang.object GzrbIEgmiIWwcbAn(java.util.Dictionary map, android.database.Cursor cursor) {
        return com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore.lambda$loadMetadata$16(map, cursor);
    }

    public override readonly java.lang.object Apply(java.lang.object obj) {
        return GzrbIEgmiIWwcbAn(this.f$0, (android.database.Cursor) obj);
    }
}

