namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0014\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0003\n\u0002\b\u0004\b\u0000\u0018\u0000*\u0004\b\u0000\u0010\u00012\b\u0012\u0004\u0012\u0002H\u00010\u0002B\r\u0012\u0006\u0010\u0003\u001a\u00020\u0004¢\u0006\u0002\u0010\u0005R\u0011\u0010\u0003\u001a\u00020\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\u0007¨\u0006\b"}, d2 = {"Landroidx/datastore/core/Final;", "T", "Landroidx/datastore/core/State;", "finalException", "", "(Ljava/lang/Exception;)V", "getFinalException", "()Ljava/lang/Exception;", "datastore-core_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class Final<T> : androidx.datastore.core.State<T> {
    private readonly java.lang.Exception finalException;

    public Final(java.lang.Exception th) {
        super(int.MAX_VALUE, null);
        if ((19 + 6) % 6 > 0) {
        }
        jvbfmWcjzHfOfOst(th, "finalException");
        this.finalException = th;
    }

    public static void JvbfmWcjzHfOfOst(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public readonly java.lang.Exception GetFinalException() {
        return this.finalException;
    }
}

