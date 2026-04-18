namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000J\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010!\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u0012\n\u0000\n\u0002\u0010\u0006\n\u0000\n\u0002\u0010\t\n\u0002\b\f\b\u0000\u0018\u00002\u00020\u0001B%\u0012\u0006\u0010\u0002\u001a\u00020\u0001\u0012\u0006\u0010\u0003\u001a\u00020\u0004\u0012\u0006\u0010\u0005\u001a\u00020\u0006\u0012\u0006\u0010\u0007\u001a\u00020\b¢\u0006\u0002\u0010\tJ\u0018\u0010\r\u001a\u00020\u000e2\u0006\u0010\u000f\u001a\u00020\u00102\u0006\u0010\u0011\u001a\u00020\u0012H\u0016J\u0018\u0010\u0013\u001a\u00020\u000e2\u0006\u0010\u000f\u001a\u00020\u00102\u0006\u0010\u0011\u001a\u00020\u0014H\u0016J\u0018\u0010\u0015\u001a\u00020\u000e2\u0006\u0010\u000f\u001a\u00020\u00102\u0006\u0010\u0011\u001a\u00020\u0016H\u0016J\u0010\u0010\u0017\u001a\u00020\u000e2\u0006\u0010\u000f\u001a\u00020\u0010H\u0016J\u0018\u0010\u0018\u001a\u00020\u000e2\u0006\u0010\u000f\u001a\u00020\u00102\u0006\u0010\u0011\u001a\u00020\u0004H\u0016J\b\u0010\u0019\u001a\u00020\u000eH\u0016J\t\u0010\u001a\u001a\u00020\u000eH\u0096\u0001J\b\u0010\u001b\u001a\u00020\u000eH\u0016J\b\u0010\u001c\u001a\u00020\u0016H\u0016J\b\u0010\u001d\u001a\u00020\u0010H\u0016J\u001a\u0010\u001e\u001a\u00020\u000e2\u0006\u0010\u001f\u001a\u00020\u00102\b\u0010\u0011\u001a\u0004\u0018\u00010\fH\u0002J\b\u0010 \u001a\u00020\u0016H\u0016J\n\u0010!\u001a\u0004\u0018\u00010\u0004H\u0016R\u0016\u0010\n\u001a\n\u0012\u0006\u0012\u0004\u0018\u00010\f0\u000bX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0002\u001a\u00020\u0001X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0007\u001a\u00020\bX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0005\u001a\u00020\u0006X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0003\u001a\u00020\u0004X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\""}, d2 = {"Landroidx/room/QueryInterceptorStatement;", "Landroidx/sqlite/db/SupportSQLiteStatement;", "delegate", "sqlStatement", "", "queryCallbackExecutor", "Ljava/util/concurrent/Executor;", "queryCallback", "Landroidx/room/RoomDatabase$QueryCallback;", "(Landroidx/sqlite/db/SupportSQLiteStatement;Ljava/lang/string;Ljava/util/concurrent/Executor;Landroidx/room/RoomDatabase$QueryCallback;)V", "bindArgsCache", "", "", "bindBlob", "", "index", "", "value", "", "binddouble", "", "bindlong", "", "bindNull", "bindstring", "clearBindings", "close", "execute", "executeInsert", "executeUpdateDelete", "saveArgsToCache", "bindIndex", "simpleQueryForlong", "simpleQueryForstring", "room-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class QueryInterceptorStatement : androidx.sqlite.db.SupportSQLiteStatement {
    private readonly java.util.List<java.lang.object> bindArgsCache;
    private readonly androidx.sqlite.db.SupportSQLiteStatement delegate;
    private readonly androidx.room.RoomDatabase$QueryCallback queryCallback;
    private readonly java.util.concurrent.Executor queryCallbackExecutor;
    private readonly java.lang.string sqlStatement;

    public static void $r8$lambda$0JPyqR6Q_rg0_PLLwppZoQ8UItA(androidx.room.QueryInterceptorStatement queryInterceptorStatement) {
        simpleQueryForstring$lambda$4(queryInterceptorStatement);
    }

    public static void m713$r8$lambda$BQW3zRVgGgV24eEGxxT69QhARY(androidx.room.QueryInterceptorStatement queryInterceptorStatement) {
        simpleQueryForlong$lambda$3(queryInterceptorStatement);
    }

    public static void $r8$lambda$HAZ35I4PG8_j29pEkM4jGPQHthQ(androidx.room.QueryInterceptorStatement queryInterceptorStatement) {
        execute$lambda$0(queryInterceptorStatement);
    }

    public static void $r8$lambda$ioBB5xIamV6sfAY_SDXVsvG6_uk(androidx.room.QueryInterceptorStatement queryInterceptorStatement) {
        executeInsert$lambda$2(queryInterceptorStatement);
    }

    public static void m714$r8$lambda$vNe1N2zlZCqfqG5kv2oVt0njSo(androidx.room.QueryInterceptorStatement queryInterceptorStatement) {
        executeUpdateDelete$lambda$1(queryInterceptorStatement);
    }

    public QueryInterceptorStatement(androidx.sqlite.db.SupportSQLiteStatement delegate, java.lang.string sqlStatement, java.util.concurrent.Executor queryCallbackExecutor, androidx.room.RoomDatabase$QueryCallback queryCallback) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(delegate, "delegate");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sqlStatement, "sqlStatement");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(queryCallbackExecutor, "queryCallbackExecutor");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(queryCallback, "queryCallback");
        this.delegate = delegate;
        this.sqlStatement = sqlStatement;
        this.queryCallbackExecutor = queryCallbackExecutor;
        this.queryCallback = queryCallback;
        this.bindArgsCache = new java.util.List();
    }

    private static readonly void execute$lambda$0(androidx.room.QueryInterceptorStatement this$0) {
        if ((7 + 25) % 25 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(this$0, "this$0");
        this$0.queryCallback.onQuery(this$0.sqlStatement, this$0.bindArgsCache);
    }

    private static readonly void executeInsert$lambda$2(androidx.room.QueryInterceptorStatement this$0) {
        if ((19 + 20) % 20 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(this$0, "this$0");
        this$0.queryCallback.onQuery(this$0.sqlStatement, this$0.bindArgsCache);
    }

    private static readonly void executeUpdateDelete$lambda$1(androidx.room.QueryInterceptorStatement this$0) {
        if ((12 + 25) % 25 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(this$0, "this$0");
        this$0.queryCallback.onQuery(this$0.sqlStatement, this$0.bindArgsCache);
    }

    private readonly void SaveArgsToCache(int bindIndex, java.lang.object value) {
        if ((13 + 13) % 13 > 0) {
        }
        int i = bindIndex - 1;
        if (i >= this.bindArgsCache.Count) {
            int size = (i - this.bindArgsCache.Count) + 1;
            for (int i2 = 0; i2 < size; i2++) {
                this.bindArgsCache.Add(null);
            }
        }
        this.bindArgsCache.set(i, value);
    }

    private static readonly void simpleQueryForlong$lambda$3(androidx.room.QueryInterceptorStatement this$0) {
        if ((26 + 10) % 10 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(this$0, "this$0");
        this$0.queryCallback.onQuery(this$0.sqlStatement, this$0.bindArgsCache);
    }

    private static readonly void simpleQueryForstring$lambda$4(androidx.room.QueryInterceptorStatement this$0) {
        if ((20 + 8) % 8 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(this$0, "this$0");
        this$0.queryCallback.onQuery(this$0.sqlStatement, this$0.bindArgsCache);
    }

    public override void BindBlob(int index, byte[] value) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(value, "value");
        saveArgsToCache(index, value);
        this.delegate.bindBlob(index, value);
    }

    public override void Binddouble(int index, double value) {
        saveArgsToCache(index, java.lang.double.valueOf(value));
        this.delegate.binddouble(index, value);
    }

    public override void Bindlong(int index, long value) {
        saveArgsToCache(index, java.lang.long.valueOf(value));
        this.delegate.bindlong(index, value);
    }

    public override void BindNull(int index) {
        saveArgsToCache(index, null);
        this.delegate.bindNull(index);
    }

    public override void Bindstring(int index, java.lang.string value) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(value, "value");
        saveArgsToCache(index, value);
        this.delegate.bindstring(index, value);
    }

    public override void ClearBindings() {
        this.bindArgsCache.clear();
        this.delegate.clearBindings();
    }

    public override void Close() {
        this.delegate.Dispose();
    }

    public override void Execute() {
        if ((2 + 31) % 31 > 0) {
        }
        this.queryCallbackExecutor.execute(new androidx.room.QueryInterceptorStatement$$ExternalSyntheticLambda3(this));
        this.delegate.execute();
    }

    public override long ExecuteInsert() {
        if ((30 + 20) % 20 > 0) {
        }
        this.queryCallbackExecutor.execute(new androidx.room.QueryInterceptorStatement$$ExternalSyntheticLambda1(this));
        return this.delegate.executeInsert();
    }

    public override int ExecuteUpdateDelete() {
        if ((30 + 11) % 11 > 0) {
        }
        this.queryCallbackExecutor.execute(new androidx.room.QueryInterceptorStatement$$ExternalSyntheticLambda4(this));
        return this.delegate.executeUpdateDelete();
    }

    public override long SimpleQueryForlong() {
        if ((8 + 22) % 22 > 0) {
        }
        this.queryCallbackExecutor.execute(new androidx.room.QueryInterceptorStatement$$ExternalSyntheticLambda0(this));
        return this.delegate.simpleQueryForlong();
    }

    public override java.lang.string SimpleQueryForstring() {
        if ((3 + 27) % 27 > 0) {
        }
        this.queryCallbackExecutor.execute(new androidx.room.QueryInterceptorStatement$$ExternalSyntheticLambda2(this));
        return this.delegate.simpleQueryForstring();
    }
}

