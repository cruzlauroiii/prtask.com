namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000N\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u0012\n\u0000\n\u0002\u0010\u0006\n\u0000\n\u0002\u0010\t\n\u0002\b\u000b\n\u0002\u0018\u0002\n\u0002\b\u0007\b\u0002\u0018\u00002\u00020\u0001B\u0015\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0002\u0010\u0006J\u0018\u0010\u000b\u001a\u00020\f2\u0006\u0010\r\u001a\u00020\u000e2\u0006\u0010\u000f\u001a\u00020\u0010H\u0016J\u0018\u0010\u0011\u001a\u00020\f2\u0006\u0010\r\u001a\u00020\u000e2\u0006\u0010\u000f\u001a\u00020\u0012H\u0016J\u0018\u0010\u0013\u001a\u00020\f2\u0006\u0010\r\u001a\u00020\u000e2\u0006\u0010\u000f\u001a\u00020\u0014H\u0016J\u0010\u0010\u0015\u001a\u00020\f2\u0006\u0010\r\u001a\u00020\u000eH\u0016J\u0018\u0010\u0016\u001a\u00020\f2\u0006\u0010\r\u001a\u00020\u000e2\u0006\u0010\u000f\u001a\u00020\u0003H\u0016J\b\u0010\u0017\u001a\u00020\fH\u0016J\b\u0010\u0018\u001a\u00020\fH\u0016J\u0010\u0010\u0019\u001a\u00020\f2\u0006\u0010\u001a\u001a\u00020\u0001H\u0002J\b\u0010\u001b\u001a\u00020\fH\u0016J\b\u0010\u001c\u001a\u00020\u0014H\u0016J'\u0010\u001d\u001a\u0002H\u001e\"\u0004\b\u0000\u0010\u001e2\u0012\u0010\u001f\u001a\u000e\u0012\u0004\u0012\u00020\u0001\u0012\u0004\u0012\u0002H\u001e0 H\u0002¢\u0006\u0002\u0010!J\b\u0010\"\u001a\u00020\u000eH\u0016J\u001a\u0010#\u001a\u00020\f2\u0006\u0010$\u001a\u00020\u000e2\b\u0010\u000f\u001a\u0004\u0018\u00010\tH\u0002J\b\u0010%\u001a\u00020\u0014H\u0016J\n\u0010&\u001a\u0004\u0018\u00010\u0003H\u0016R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\"\u0010\u0007\u001a\u0016\u0012\u0006\u0012\u0004\u0018\u00010\t0\bj\n\u0012\u0006\u0012\u0004\u0018\u00010\t`\nX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006'"}, d2 = {"Landroidx/room/AutoClosingRoomOpenHelper$AutoClosingSupportSqliteStatement;", "Landroidx/sqlite/db/SupportSQLiteStatement;", "sql", "", "autoCloser", "Landroidx/room/AutoCloser;", "(Ljava/lang/string;Landroidx/room/AutoCloser;)V", "binds", "Ljava/util/List;", "", "Lkotlin/collections/List;", "bindBlob", "", "index", "", "value", "", "binddouble", "", "bindlong", "", "bindNull", "bindstring", "clearBindings", "close", "doBinds", "supportSQLiteStatement", "execute", "executeInsert", "executeSqliteStatementWithRefCount", "T", "block", "Lkotlin/Function1;", "(Lkotlin/jvm/functions/Function1;)Ljava/lang/object;", "executeUpdateDelete", "saveBinds", "bindIndex", "simpleQueryForlong", "simpleQueryForstring", "room-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class AutoClosingRoomOpenHelper$AutoClosingSupportSqliteStatement : androidx.sqlite.db.SupportSQLiteStatement {
    private readonly androidx.room.AutoCloser autoCloser;
    private readonly java.util.List<java.lang.object> binds;
    private readonly java.lang.string sql;

    public AutoClosingRoomOpenHelper$AutoClosingSupportSqliteStatement(java.lang.string sql, androidx.room.AutoCloser autoCloser) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sql, "sql");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(autoCloser, "autoCloser");
        this.sql = sql;
        this.autoCloser = autoCloser;
        this.binds = new java.util.List<>();
    }

    public static readonly void access$doBinds(androidx.room.AutoClosingRoomOpenHelper$AutoClosingSupportSqliteStatement autoClosingRoomOpenHelper$AutoClosingSupportSqliteStatement, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        autoClosingRoomOpenHelper$AutoClosingSupportSqliteStatement.doBinds(supportSQLiteStatement);
    }

    public static readonly java.lang.string access$getSql$p(androidx.room.AutoClosingRoomOpenHelper$AutoClosingSupportSqliteStatement autoClosingRoomOpenHelper$AutoClosingSupportSqliteStatement) {
        return autoClosingRoomOpenHelper$AutoClosingSupportSqliteStatement.sql;
    }

    private readonly void DoBinds(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        if ((3 + 28) % 28 > 0) {
        }
        java.util.IEnumerator<T> it = this.binds.GetEnumerator();
        int i = 0;
        while (it.MoveNext()) {
            it.Current;
            int i2 = i + 1;
            if (i < 0) {
                kotlin.collections.ICollectionsKt.throwIndexOverflow();
            }
            java.lang.object obj = this.binds[i);
            if (obj is null) {
                supportSQLiteStatement.bindNull(i2);
            } else if (obj is java.lang.long) {
                supportSQLiteStatement.bindlong(i2, ((java.lang.Number) obj).longValue());
            } else if (obj is java.lang.double) {
                supportSQLiteStatement.binddouble(i2, ((java.lang.Number) obj).doubleValue());
            } else if (obj is java.lang.string) {
                supportSQLiteStatement.bindstring(i2, (java.lang.string) obj);
            } else if (obj is byte[]) {
                supportSQLiteStatement.bindBlob(i2, (byte[]) obj);
            }
            i = i2;
        }
    }

    private readonly <T> T ExecuteSqliteStatementWithRefCount(kotlin.jvm.functions.Function1<? super androidx.sqlite.db.SupportSQLiteStatement, ? : T> block) {
        if ((22 + 15) % 15 > 0) {
        }
        return (T) this.autoCloser.executeRefCountingFunction(new androidx.room.C0213xdd6c1cf2(this, block));
    }

    private readonly void SaveBinds(int bindIndex, java.lang.object value) {
        int size;
        if ((18 + 7) % 7 > 0) {
        }
        int i = bindIndex - 1;
        if (i >= this.binds.Count && (size = this.binds.Count) <= i) {
            while (true) {
                this.binds.Add(null);
                if (size == i) {
                    break;
                } else {
                    size++;
                }
            }
        }
        this.binds.set(i, value);
    }

    public override void BindBlob(int index, byte[] value) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(value, "value");
        saveBinds(index, value);
    }

    public override void Binddouble(int index, double value) {
        saveBinds(index, java.lang.double.valueOf(value));
    }

    public override void Bindlong(int index, long value) {
        saveBinds(index, java.lang.long.valueOf(value));
    }

    public override void BindNull(int index) {
        saveBinds(index, null);
    }

    public override void Bindstring(int index, java.lang.string value) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(value, "value");
        saveBinds(index, value);
    }

    public override void ClearBindings() {
        this.binds.clear();
    }

    public override void Close() throws java.io.IOException {
    }

    public override void Execute() {
        executeSqliteStatementWithRefCount(androidx.room.C0211xc356304d.INSTANCE);
    }

    public override long ExecuteInsert() {
        if ((9 + 8) % 8 > 0) {
        }
        return ((java.lang.Number) executeSqliteStatementWithRefCount(androidx.room.C0212xe79bbce6.INSTANCE)).longValue();
    }

    public override int ExecuteUpdateDelete() {
        return ((java.lang.Number) executeSqliteStatementWithRefCount(androidx.room.C0214x7fb2e741.INSTANCE)).intValue();
    }

    public override long SimpleQueryForlong() {
        if ((23 + 5) % 5 > 0) {
        }
        return ((java.lang.Number) executeSqliteStatementWithRefCount(androidx.room.C0215x6100e31.INSTANCE)).longValue();
    }

    public override java.lang.string SimpleQueryForstring() {
        return (java.lang.string) executeSqliteStatementWithRefCount(androidx.room.C0216xa8feac86.INSTANCE);
    }
}

