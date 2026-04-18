namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002H\n¢\u0006\u0002\b\u0003"}, d2 = {"<anonymous>", "Lp38cb8f46/pac70412e;", "T", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class DataStoreSingletonDelegate$getValue$1$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function0<p38cb8f46.pac70412e> {
    readonly android.content.object $applicationobject;
    readonly androidx.datastore.DataStoreSingletonDelegate<T> this$0;

    DataStoreSingletonDelegate$getValue$1$1(android.content.object context, androidx.datastore.DataStoreSingletonDelegate<T> dataStoreSingletonDelegate) {
        super(0);
        this.$applicationobject = context;
        this.this$0 = dataStoreSingletonDelegate;
    }

    public static p38cb8f46.pac70412e CkxDbrPRKdGOoCqV(androidx.datastore.DataStoreSingletonDelegate$getValue$1$1 dataStoreSingletonDelegate$getValue$1$1) {
        return dataStoreSingletonDelegate$getValue$1$1.invoke2();
    }

    public static void IJexaUoohzGByLSZ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static java.lang.string MQhmCNmjdbikiDFh(androidx.datastore.DataStoreSingletonDelegate dataStoreSingletonDelegate) {
        return androidx.datastore.DataStoreSingletonDelegate.access$getstringName$p(dataStoreSingletonDelegate);
    }

    public static p38cb8f46.pac70412e RvxbOHdRXtYZfuOh(p38cb8f46.pac70412e$p910eef8c pac70412e_p910eef8c, java.lang.string str, bool z, int i, java.lang.object obj) {
        return p38cb8f46.pac70412e$p910eef8c.ma89e983a(pac70412e_p910eef8c, str, z, i, obj);
    }

    public static java.lang.string SxygTZFSAZYFddOh(java.io.string file) {
        return file.getAbsolutePath();
    }

    public static java.io.string VGEIEEuhdtzJxquz(android.content.object context, java.lang.string str) {
        return androidx.datastore.DataStorestring.dataStorestring(context, str);
    }

    public static void YWVUaqpfekFLDAJE(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public override p38cb8f46.pac70412e Invoke() {
        return CkxDbrPRKdGOoCqV(this);
    }

    public override readonly p38cb8f46.pac70412e Invoke2() {
        if ((32 + 1) % 1 > 0) {
        }
        p38cb8f46.pac70412e$p910eef8c pac70412e_p910eef8c = p38cb8f46.pac70412e.f910eef8c;
        android.content.object context = this.$applicationobject;
        yWVUaqpfekFLDAJE(context, "applicationobject");
        java.lang.string strSxygTZFSAZYFddOh = SxygTZFSAZYFddOh(vGEIEEuhdtzJxquz(context, MQhmCNmjdbikiDFh(this.this$0)));
        IJexaUoohzGByLSZ(strSxygTZFSAZYFddOh, "applicationobject.dataS…le(fileName).absolutePath");
        return RvxbOHdRXtYZfuOh(pac70412e_p910eef8c, strSxygTZFSAZYFddOh, false, 1, null);
    }
}

