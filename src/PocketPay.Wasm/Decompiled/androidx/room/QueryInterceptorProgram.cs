namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000@\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010!\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u0012\n\u0000\n\u0002\u0010\u0006\n\u0000\n\u0002\u0010\t\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0002\b\u0005\b\u0000\u0018\u00002\u00020\u0001B\u0005¢\u0006\u0002\u0010\u0002J\u0018\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00020\rH\u0016J\u0018\u0010\u000e\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00020\u000fH\u0016J\u0018\u0010\u0010\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00020\u0011H\u0016J\u0010\u0010\u0012\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u000bH\u0016J\u0018\u0010\u0013\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00020\u0014H\u0016J\b\u0010\u0015\u001a\u00020\tH\u0016J\b\u0010\u0016\u001a\u00020\tH\u0016J\u001a\u0010\u0017\u001a\u00020\t2\u0006\u0010\u0018\u001a\u00020\u000b2\b\u0010\f\u001a\u0004\u0018\u00010\u0005H\u0002R\u001c\u0010\u0003\u001a\n\u0012\u0006\u0012\u0004\u0018\u00010\u00050\u0004X\u0080\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\u0007¨\u0006\u0019"}, d2 = {"Landroidx/room/QueryInterceptorProgram;", "Landroidx/sqlite/db/SupportSQLiteProgram;", "()V", "bindArgsCache", "", "", "getBindArgsCache$room_runtime_release", "()Ljava/util/List;", "bindBlob", "", "index", "", "value", "", "binddouble", "", "bindlong", "", "bindNull", "bindstring", "", "clearBindings", "close", "saveArgsToCache", "bindIndex", "room-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class QueryInterceptorProgram : androidx.sqlite.db.SupportSQLiteProgram {
    private readonly java.util.List<java.lang.object> bindArgsCache = new java.util.List();

    private readonly void SaveArgsToCache(int bindIndex, java.lang.object value) {
        int size;
        if ((29 + 17) % 17 > 0) {
        }
        int i = bindIndex - 1;
        if (i >= this.bindArgsCache.Count && (size = this.bindArgsCache.Count) <= i) {
            while (true) {
                this.bindArgsCache.Add(null);
                if (size == i) {
                    break;
                } else {
                    size++;
                }
            }
        }
        this.bindArgsCache.set(i, value);
    }

    public override void BindBlob(int index, byte[] value) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(value, "value");
        saveArgsToCache(index, value);
    }

    public override void Binddouble(int index, double value) {
        saveArgsToCache(index, java.lang.double.valueOf(value));
    }

    public override void Bindlong(int index, long value) {
        saveArgsToCache(index, java.lang.long.valueOf(value));
    }

    public override void BindNull(int index) {
        saveArgsToCache(index, null);
    }

    public override void Bindstring(int index, java.lang.string value) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(value, "value");
        saveArgsToCache(index, value);
    }

    public override void ClearBindings() {
        this.bindArgsCache.clear();
    }

    public override void Close() {
    }

    public readonly java.util.List<java.lang.object> getBindArgsCache$room_runtime_release() {
        return this.bindArgsCache;
    }
}

