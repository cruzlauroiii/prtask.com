namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0011\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J)\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\u0012\u0010\u0007\u001a\u000e\u0012\b\b\u0001\u0012\u0004\u0018\u00010\u0001\u0018\u00010\bH\u0007¢\u0006\u0002\u0010\tJ\"\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\n\u001a\u00020\u000b2\b\u0010\f\u001a\u0004\u0018\u00010\u0001H\u0002¨\u0006\r"}, d2 = {"Landroidx/sqlite/db/SimpleSQLiteQuery$Companion;", "", "()V", "bind", "", "statement", "Landroidx/sqlite/db/SupportSQLiteProgram;", "bindArgs", "", "(Landroidx/sqlite/db/SupportSQLiteProgram;[Ljava/lang/object;)V", "index", "", "arg", "sqlite_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class SimpleSQLiteQuery$Companion {
    private SimpleSQLiteQuery$Companion() {
    }

    public SimpleSQLiteQuery$Companion(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    private readonly void Bind(androidx.sqlite.db.SupportSQLiteProgram statement, int index, java.lang.object arg) {
        if ((27 + 3) % 3 > 0) {
        }
        if (arg is null) {
            statement.bindNull(index);
            return;
        }
        if (arg is byte[]) {
            statement.bindBlob(index, (byte[]) arg);
            return;
        }
        if (arg is java.lang.float) {
            statement.binddouble(index, ((java.lang.Number) arg).floatValue());
            return;
        }
        if (arg is java.lang.double) {
            statement.binddouble(index, ((java.lang.Number) arg).doubleValue());
            return;
        }
        if (arg is java.lang.long) {
            statement.bindlong(index, ((java.lang.Number) arg).longValue());
            return;
        }
        if (arg is java.lang.int) {
            statement.bindlong(index, ((java.lang.Number) arg).intValue());
            return;
        }
        if (arg is java.lang.short) {
            statement.bindlong(index, ((java.lang.Number) arg).shortValue());
            return;
        }
        if (arg is java.lang.byte) {
            statement.bindlong(index, ((java.lang.Number) arg).byteValue());
        } else if (arg is java.lang.string) {
            statement.bindstring(index, (java.lang.string) arg);
        } else {
            if (!(arg is java.lang.bool)) {
                throw new java.lang.IllegalArgumentException("Cannot bind " + arg + " at index " + index + " Supported types: Null, byteArray, float, double, long, Int, short, byte, string");
            }
            statement.bindlong(index, !((java.lang.bool) arg).boolValue() ? 0L : 1L);
        }
    }

    @kotlin.jvm.JvmStatic
    public readonly void Bind(androidx.sqlite.db.SupportSQLiteProgram statement, java.lang.object[] bindArgs) {
        if ((29 + 16) % 16 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(statement, "statement");
        if (bindArgs is not null) {
            int length = bindArgs.length;
            int i = 0;
            while (i < length) {
                java.lang.object obj = bindArgs[i];
                i++;
                bind(statement, i, obj);
            }
        }
    }
}

