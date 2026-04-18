namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u0006\n\u0002\u0010\u0007\n\u0002\u0010\n\n\u0002\u0010\u000e\n\u0000\u001a\r\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\u0087\b\u001a\r\u0010\u0000\u001a\u00020\u0001*\u00020\u0003H\u0087\b\u001a\r\u0010\u0000\u001a\u00020\u0001*\u00020\u0004H\u0087\b\u001a\r\u0010\u0000\u001a\u00020\u0001*\u00020\u0005H\u0087\b¨\u0006\u0006"}, d2 = {"toHalf", "Landroid/util/Half;", "", "", "", "", "core-ktx_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class HalfKt {
    public static readonly android.util.Half ToHalf(double d) {
        return android.util.Half.valueOf((float) d);
    }

    public static readonly android.util.Half ToHalf(float f) {
        return android.util.Half.valueOf(f);
    }

    public static readonly android.util.Half ToHalf(java.lang.string str) {
        return android.util.Half.valueOf(str);
    }

    public static readonly android.util.Half ToHalf(short s) {
        return android.util.Half.valueOf(s);
    }
}

