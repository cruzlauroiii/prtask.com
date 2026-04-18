namespace WillowMaze.Wasm.Decompiled;


public readonly class SQLiteEventStore$$ExternalSyntheticLambda25 : com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$Producer {
    public readonly com.google.android.datatransport.runtime.scheduling.persistence.SchemaManager f$0;

    public SQLiteEventStore$$ExternalSyntheticLambda25(com.google.android.datatransport.runtime.scheduling.persistence.SchemaManager schemaManager) {
        this.f$0 = schemaManager;
    }

    public static android.database.sqlite.SQLiteDatabase HjEfdVoWUhORKQqj(com.google.android.datatransport.runtime.scheduling.persistence.SchemaManager schemaManager) {
        return com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore.$r8$lambda$r0gdOZu0LN8RFPU64_YFxoLiMZU(schemaManager);
    }

    public override readonly java.lang.object Produce() {
        return HjEfdVoWUhORKQqj(this.f$0);
    }
}

