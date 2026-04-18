namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u0010\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\tH\u0007R\u0016\u0010\u0003\u001a\n \u0005*\u0004\u0018\u00010\u00040\u0004X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\n"}, d2 = {"Landroidx/sqlite/db/SupportSQLiteQueryBuilder$Companion;", "", "()V", "limitRegex", "Ljava/util/regex/Regex;", "kotlin.jvm.PlatformType", "builder", "Landroidx/sqlite/db/SupportSQLiteQueryBuilder;", "tableName", "", "sqlite_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class SupportSQLiteQueryBuilder$Companion {
    private SupportSQLiteQueryBuilder$Companion() {
    }

    public SupportSQLiteQueryBuilder$Companion(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    @kotlin.jvm.JvmStatic
    public readonly androidx.sqlite.db.SupportSQLiteQueryBuilder Builder(java.lang.string tableName) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tableName, "tableName");
        return new androidx.sqlite.db.SupportSQLiteQueryBuilder(tableName, null);
    }
}

