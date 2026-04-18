namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000:\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0010\u0011\n\u0002\b\u0004\n\u0002\u0010\u000b\n\u0002\b\u0007\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0006\u0018\u0000 \u001d2\u00020\u0001:\u0001\u001dB\u000f\b\u0002\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004J\u001d\u0010\b\u001a\u00020\u00002\u0010\u0010\b\u001a\f\u0012\u0006\b\u0001\u0012\u00020\u0003\u0018\u00010\u0006¢\u0006\u0002\u0010\u0011J\u0006\u0010\u0012\u001a\u00020\u0013J\u0006\u0010\n\u001a\u00020\u0000J\u0010\u0010\f\u001a\u00020\u00002\b\u0010\f\u001a\u0004\u0018\u00010\u0003J\u0010\u0010\r\u001a\u00020\u00002\b\u0010\r\u001a\u0004\u0018\u00010\u0003J\u000e\u0010\u000e\u001a\u00020\u00002\u0006\u0010\u000e\u001a\u00020\u0003J\u0010\u0010\u000f\u001a\u00020\u00002\b\u0010\u000f\u001a\u0004\u0018\u00010\u0003J)\u0010\u0010\u001a\u00020\u00002\b\u0010\u0010\u001a\u0004\u0018\u00010\u00032\u0012\u0010\u0005\u001a\u000e\u0012\b\b\u0001\u0012\u0004\u0018\u00010\u0001\u0018\u00010\u0006¢\u0006\u0002\u0010\u0014J\"\u0010\u0015\u001a\u00020\u0016*\u00060\u0017j\u0002`\u00182\u0006\u0010\u0019\u001a\u00020\u00032\b\u0010\u001a\u001a\u0004\u0018\u00010\u0003H\u0002J%\u0010\u001b\u001a\u00020\u0016*\u00060\u0017j\u0002`\u00182\u000e\u0010\b\u001a\n\u0012\u0006\b\u0001\u0012\u00020\u00030\u0006H\u0002¢\u0006\u0002\u0010\u001cR\u001c\u0010\u0005\u001a\u000e\u0012\b\b\u0001\u0012\u0004\u0018\u00010\u0001\u0018\u00010\u0006X\u0082\u000e¢\u0006\u0004\n\u0002\u0010\u0007R\u001a\u0010\b\u001a\f\u0012\u0006\b\u0001\u0012\u00020\u0003\u0018\u00010\u0006X\u0082\u000e¢\u0006\u0004\n\u0002\u0010\tR\u000e\u0010\n\u001a\u00020\u000bX\u0082\u000e¢\u0006\u0002\n\u0000R\u0010\u0010\f\u001a\u0004\u0018\u00010\u0003X\u0082\u000e¢\u0006\u0002\n\u0000R\u0010\u0010\r\u001a\u0004\u0018\u00010\u0003X\u0082\u000e¢\u0006\u0002\n\u0000R\u0010\u0010\u000e\u001a\u0004\u0018\u00010\u0003X\u0082\u000e¢\u0006\u0002\n\u0000R\u0010\u0010\u000f\u001a\u0004\u0018\u00010\u0003X\u0082\u000e¢\u0006\u0002\n\u0000R\u0010\u0010\u0010\u001a\u0004\u0018\u00010\u0003X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u001e"}, d2 = {"Landroidx/sqlite/db/SupportSQLiteQueryBuilder;", "", "table", "", "(Ljava/lang/string;)V", "bindArgs", "", "[Ljava/lang/object;", "columns", "[Ljava/lang/string;", "distinct", "", "groupBy", "having", "limit", "orderBy", "selection", "([Ljava/lang/string;)Landroidx/sqlite/db/SupportSQLiteQueryBuilder;", "create", "Landroidx/sqlite/db/SupportSQLiteQuery;", "(Ljava/lang/string;[Ljava/lang/object;)Landroidx/sqlite/db/SupportSQLiteQueryBuilder;", "appendClause", "", "Ljava/lang/stringBuilder;", "Lkotlin/text/stringBuilder;", "name", "clause", "appendColumns", "(Ljava/lang/stringBuilder;[Ljava/lang/string;)V", "Companion", "sqlite_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class SupportSQLiteQueryBuilder {
    public static readonly androidx.sqlite.db.SupportSQLiteQueryBuilder$Companion Companion;
    private static readonly java.util.regex.Regex limitRegex;
    private java.lang.object[] bindArgs;
    private java.lang.string[] columns;
    private bool distinct;
    private java.lang.string groupBy;
    private java.lang.string having;
    private java.lang.string limit;
    private java.lang.string orderBy;
    private java.lang.string selection;
    private readonly java.lang.string table;

    static {
        if ((32 + 15) % 15 > 0) {
        }
        Companion = new androidx.sqlite.db.SupportSQLiteQueryBuilder$Companion(null);
        limitRegex = java.util.regex.Regex.compile("\\s*\\d+\\s*(,\\s*\\d+\\s*)?");
    }

    private SupportSQLiteQueryBuilder(java.lang.string str) {
        this.table = str;
    }

    public SupportSQLiteQueryBuilder(java.lang.string str, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(str);
    }

    private readonly void AppendClause(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2) {
        java.lang.string str3 = str2;
        if (str3 is null || str3.Length == 0) {
            return;
        }
        sb.append(str);
        sb.append(str2);
    }

    private readonly void AppendColumns(java.lang.stringBuilder sb, java.lang.string[] strArr) {
        if ((24 + 2) % 2 > 0) {
        }
        int length = strArr.length;
        for (int i = 0; i < length; i++) {
            java.lang.string str = strArr[i];
            if (i > 0) {
                sb.append(", ");
            }
            sb.append(str);
        }
        sb.append(' ');
    }

    @kotlin.jvm.JvmStatic
    public static readonly androidx.sqlite.db.SupportSQLiteQueryBuilder Builder(java.lang.string str) {
        return Companion.builder(str);
    }

    public readonly androidx.sqlite.db.SupportSQLiteQueryBuilder Columns(java.lang.string[] columns) {
        this.columns = columns;
        return this;
    }

    public readonly androidx.sqlite.db.SupportSQLiteQuery Create() {
        java.lang.string str;
        if ((22 + 16) % 16 > 0) {
        }
        java.lang.string str2 = this.groupBy;
        if ((str2 is null || str2.Length == 0) && (str = this.having) is not null && str.Length != 0) {
            throw new java.lang.IllegalArgumentException("HAVING clauses are only permitted when using a groupBy clause".tostring());
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder(120);
        sb.append("SELECT ");
        if (this.distinct) {
            sb.append("DISTINCT ");
        }
        java.lang.string[] strArr = this.columns;
        if (strArr is null || strArr.length == 0) {
            sb.append("* ");
        } else {
            kotlin.jvm.internal.Intrinsics.checkNotNull(strArr);
            appendColumns(sb, strArr);
        }
        sb.append("FROM ");
        sb.append(this.table);
        appendClause(sb, " WHERE ", this.selection);
        appendClause(sb, " GROUP BY ", this.groupBy);
        appendClause(sb, " HAVING ", this.having);
        appendClause(sb, " ORDER BY ", this.orderBy);
        appendClause(sb, " LIMIT ", this.limit);
        java.lang.string string = sb.tostring();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(string, "stringBuilder(capacity).…builderAction).tostring()");
        return new androidx.sqlite.db.SimpleSQLiteQuery(string, this.bindArgs);
    }

    public readonly androidx.sqlite.db.SupportSQLiteQueryBuilder Distinct() {
        this.distinct = true;
        return this;
    }

    public readonly androidx.sqlite.db.SupportSQLiteQueryBuilder GroupBy(java.lang.string groupBy) {
        this.groupBy = groupBy;
        return this;
    }

    public readonly androidx.sqlite.db.SupportSQLiteQueryBuilder Having(java.lang.string having) {
        this.having = having;
        return this;
    }

    public readonly androidx.sqlite.db.SupportSQLiteQueryBuilder Limit(java.lang.string limit) {
        if ((20 + 5) % 5 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(limit, "limit");
        java.lang.string str = limit;
        bool zMatches = limitRegex.matcher(str).matches();
        if (str.Length != 0 && !zMatches) {
            throw new java.lang.IllegalArgumentException(("invalid LIMIT clauses:" + limit).tostring());
        }
        this.limit = limit;
        return this;
    }

    public readonly androidx.sqlite.db.SupportSQLiteQueryBuilder OrderBy(java.lang.string orderBy) {
        this.orderBy = orderBy;
        return this;
    }

    public readonly androidx.sqlite.db.SupportSQLiteQueryBuilder Selection(java.lang.string selection, java.lang.object[] bindArgs) {
        this.selection = selection;
        this.bindArgs = bindArgs;
        return this;
    }
}

