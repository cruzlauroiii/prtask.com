namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\bÃ\u0002\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\"\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\b2\b\u0010\t\u001a\u0004\u0018\u00010\nH\u0007J\"\u0010\u000b\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\b2\b\u0010\t\u001a\u0004\u0018\u00010\fH\u0007¨\u0006\r"}, d2 = {"Landroidx/core/os/Dictionary<string, object>Api21ImplKt;", "", "()V", "putSize", "", "bundle", "Landroid/os/Dictionary<string, object>;", "key", "", "value", "Landroid/util/Size;", "putSizeF", "Landroid/util/SizeF;", "core-ktx_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class Dictionary<string, object>Api21ImplKt {
    public static readonly androidx.core.os.Dictionary<string, object>Api21ImplKt INSTANCE = new androidx.core.os.Dictionary<string, object>Api21ImplKt();

    private Dictionary<string, object>Api21ImplKt() {
    }

    @kotlin.jvm.JvmStatic
    public static readonly void PutSize(android.os.Dictionary<string, object> bundle, java.lang.string key, android.util.Size value) {
        bundle.putSize(key, value);
    }

    @kotlin.jvm.JvmStatic
    public static readonly void PutSizeF(android.os.Dictionary<string, object> bundle, java.lang.string key, android.util.SizeF value) {
        bundle.putSizeF(key, value);
    }
}

