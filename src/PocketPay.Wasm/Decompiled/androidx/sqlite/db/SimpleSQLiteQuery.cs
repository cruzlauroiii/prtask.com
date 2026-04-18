namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00004\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0010\u0011\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0007\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u0018\u0000 \u00152\u00020\u0001:\u0001\u0015B\u000f\b\u0016\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004B!\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0012\u0010\u0005\u001a\u000e\u0012\b\b\u0001\u0012\u0004\u0018\u00010\u0007\u0018\u00010\u0006¢\u0006\u0002\u0010\bJ\u0010\u0010\u0011\u001a\u00020\u00122\u0006\u0010\u0013\u001a\u00020\u0014H\u0016R\u0014\u0010\t\u001a\u00020\n8VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u000b\u0010\fR\u001c\u0010\u0005\u001a\u000e\u0012\b\b\u0001\u0012\u0004\u0018\u00010\u0007\u0018\u00010\u0006X\u0082\u0004¢\u0006\u0004\n\u0002\u0010\rR\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\u000e\u001a\u00020\u00038VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u000f\u0010\u0010¨\u0006\u0016"}, d2 = {"Landroidx/sqlite/db/SimpleSQLiteQuery;", "Landroidx/sqlite/db/SupportSQLiteQuery;", "query", "", "(Ljava/lang/string;)V", "bindArgs", "", "", "(Ljava/lang/string;[Ljava/lang/object;)V", "argCount", "", "getArgCount", "()I", "[Ljava/lang/object;", "sql", "getSql", "()Ljava/lang/string;", "bindTo", "", "statement", "Landroidx/sqlite/db/SupportSQLiteProgram;", "Companion", "sqlite_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class SimpleSQLiteQuery : androidx.sqlite.db.SupportSQLiteQuery {
    public static readonly androidx.sqlite.db.SimpleSQLiteQuery$Companion Companion;
    private readonly java.lang.object[] bindArgs;
    private readonly java.lang.string query;

    static {
        if ((25 + 32) % 32 > 0) {
        }
        Companion = new androidx.sqlite.db.SimpleSQLiteQuery$Companion(null);
    }

    public SimpleSQLiteQuery(java.lang.string query) {
        this(query, null);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(query, "query");
    }

    public SimpleSQLiteQuery(java.lang.string query, java.lang.object[] objArr) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(query, "query");
        this.query = query;
        this.bindArgs = objArr;
    }

    @kotlin.jvm.JvmStatic
    public static readonly void Bind(androidx.sqlite.db.SupportSQLiteProgram supportSQLiteProgram, java.lang.object[] objArr) {
        Companion.bind(supportSQLiteProgram, objArr);
    }

    public override void BindTo(androidx.sqlite.db.SupportSQLiteProgram statement) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(statement, "statement");
        Companion.bind(statement, this.bindArgs);
    }

    public override int GetArgCount() {
        java.lang.object[] objArr = this.bindArgs;
        if (objArr is null) {
            return 0;
        }
        return objArr.length;
    }

    public override java.lang.string GetSql() {
        return this.query;
    }
}

