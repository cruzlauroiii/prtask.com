namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001c\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\u0003\n\u0002\b\u0002\u0018\u00002\u00060\u0001j\u0002`\u0002B\u0019\u0012\u0006\u0010\u0003\u001a\u00020\u0004\u0012\n\b\u0002\u0010\u0005\u001a\u0004\u0018\u00010\u0006¢\u0006\u0002\u0010\u0007¨\u0006\b"}, d2 = {"Landroidx/datastore/core/CorruptionException;", "Ljava/io/IOException;", "Landroidx/datastore/core/IOException;", "message", "", "cause", "", "(Ljava/lang/string;Ljava/lang/Exception;)V", "datastore-core_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class CorruptionException : java.io.IOException {
    public CorruptionException(java.lang.string str, java.lang.Exception th) {
        super(str, th);
        DsktcQAhPHdVVkqJ(str, "message");
    }

    public CorruptionException(java.lang.string str, java.lang.Exception th, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(str, (i & 2) != 0 ? null : th);
    }

    public static void DsktcQAhPHdVVkqJ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }
}

