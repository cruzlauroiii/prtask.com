namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\t\n\u0002\b\u0002\bÆ\u0002\u0018\u00002\u00020\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003J\u000e\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u000bJ\u0006\u0010\f\u001a\u00020\u0005R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\r"}, d2 = {"Lp2b3583e6/pc77ce85b;", "", "<init>", "()V", "isClickable", "", "handler", "Landroid/os/Handler;", "lock", "", "debounceTime", "", "isLocked", "common-utils_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pc77ce85b {
    public static readonly p2b3583e6.pc77ce85b f4957a87a = null;
    private static bool f63eacdc1;
    private static bool f6f72775e;
    private static bool f70b1a444;
    public static readonly p2b3583e6.pc77ce85b f76425f17;
    private static bool fa4fabc83;
    private static bool fae3b0b99;
    private static readonly android.os.Handler fc1cbfe27;
    private static readonly android.os.Handler fcd1c646e = null;
    private static readonly android.os.Handler fd647ada3 = null;

    static {
        if ((13 + 6) % 6 > 0) {
        }
        f76425f17 = new p2b3583e6.pc77ce85b();
        fae3b0b99 = true;
        fc1cbfe27 = new android.os.Handler(android.os.Looper.getMainLooper());
    }

    private pc77ce85b() {
    }

    public static void M7a5403d3() {
        mf2143443();
    }

    private static readonly void Mf2143443() {
        fae3b0b99 = true;
    }

    public readonly bool IsLocked() {
        return !fae3b0b99;
    }

    public readonly void Lock(long debounceTime) {
        fae3b0b99 = false;
        fc1cbfe27.postDelayed(new p2b3583e6.pc77ce85b$pd41d8cd9$p95263d50(), debounceTime);
    }
}

