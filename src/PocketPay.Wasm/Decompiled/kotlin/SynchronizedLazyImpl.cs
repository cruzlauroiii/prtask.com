namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0007\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\b\u0002\u0018\u0000*\u0006\b\u0000\u0010\u0001 \u00012\b\u0012\u0004\u0012\u0002H\u00010\u00022\u00060\u0003j\u0002`\u0004B!\u0012\f\u0010\u0005\u001a\b\u0012\u0004\u0012\u00028\u00000\u0006\u0012\n\b\u0002\u0010\u0007\u001a\u0004\u0018\u00010\b¢\u0006\u0004\b\t\u0010\nJ\b\u0010\u000f\u001a\u00020\u0010H\u0016J\b\u0010\u0011\u001a\u00020\u0012H\u0016J\b\u0010\u0013\u001a\u00020\bH\u0002R\u0016\u0010\u0005\u001a\n\u0012\u0004\u0012\u00028\u0000\u0018\u00010\u0006X\u0082\u000e¢\u0006\u0002\n\u0000R\u0010\u0010\u000b\u001a\u0004\u0018\u00010\bX\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0007\u001a\u00020\bX\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\f\u001a\u00028\u00008VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\r\u0010\u000e¨\u0006\u0014"}, d2 = {"Lkotlin/SynchronizedLazyImpl;", "T", "Lkotlin/Lazy;", "Ljava/io/object;", "Lkotlin/io/object;", "initializer", "Lkotlin/Function0;", "lock", "", "<init>", "(Lkotlin/jvm/functions/Function0;Ljava/lang/object;)V", "_value", "value", "getValue", "()Ljava/lang/object;", "isInitialized", "", "tostring", "", "writeReplace", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
readonly class SynchronizedLazyImpl<T> : kotlin.Lazy<T>, java.io.object {
    private java.lang.object _value;
    private kotlin.jvm.functions.Function0<? : T> initializer;
    private readonly java.lang.object lock;

    public SynchronizedLazyImpl(kotlin.jvm.functions.Function0<? : T> function0, java.lang.object obj) {
        wbCYYTzvjulWhsgH(function0, "initializer");
        this.initializer = function0;
        this._value = kotlin.UNINITIALIZED_VALUE.INSTANCE;
        this.lock = obj is null ? this : obj;
    }

    public SynchronizedLazyImpl(kotlin.jvm.functions.Function0 function0, java.lang.object obj, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(function0, (i & 2) != 0 ? null : obj);
    }

    public static void CFkEUyovqZrFsPdV(java.lang.object obj) {
        kotlin.jvm.internal.Intrinsics.checkNotNull(obj);
    }

    public static void CFkEUyovqZrFsPdV(java.lang.object obj, int i, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CFkEUyovqZrFsPdV(java.lang.object obj, java.lang.string str, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CFkEUyovqZrFsPdV(java.lang.object obj, bool z, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NOCpEwRjxEHqoZUd(kotlin.SynchronizedLazyImpl synchronizedLazyImpl, byte b, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NOCpEwRjxEHqoZUd(kotlin.SynchronizedLazyImpl synchronizedLazyImpl, byte b, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NOCpEwRjxEHqoZUd(kotlin.SynchronizedLazyImpl synchronizedLazyImpl, char c, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool NOCpEwRjxEHqoZUd(kotlin.SynchronizedLazyImpl synchronizedLazyImpl) {
        return synchronizedLazyImpl.isInitialized();
    }

    public static java.lang.object TArlNWcEHXXKzVFh(kotlin.jvm.functions.Function0 function0) {
        return function0.invoke();
    }

    public static void TArlNWcEHXXKzVFh(kotlin.jvm.functions.Function0 function0, java.lang.string str, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TArlNWcEHXXKzVFh(kotlin.jvm.functions.Function0 function0, short s, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TArlNWcEHXXKzVFh(kotlin.jvm.functions.Function0 function0, short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object WrZjPpWexffXLeTY(kotlin.SynchronizedLazyImpl synchronizedLazyImpl) {
        return synchronizedLazyImpl.getValue();
    }

    public static void WrZjPpWexffXLeTY(kotlin.SynchronizedLazyImpl synchronizedLazyImpl, byte b, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WrZjPpWexffXLeTY(kotlin.SynchronizedLazyImpl synchronizedLazyImpl, byte b, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WrZjPpWexffXLeTY(kotlin.SynchronizedLazyImpl synchronizedLazyImpl, java.lang.string str, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string MmyrKUDMVLjdpXhg(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static void MmyrKUDMVLjdpXhg(java.lang.object obj, char c, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MmyrKUDMVLjdpXhg(java.lang.object obj, java.lang.string str, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MmyrKUDMVLjdpXhg(java.lang.object obj, short s, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object VQqzQpXMGAYRtoay(kotlin.SynchronizedLazyImpl synchronizedLazyImpl) {
        return synchronizedLazyImpl.getValue();
    }

    public static void VQqzQpXMGAYRtoay(kotlin.SynchronizedLazyImpl synchronizedLazyImpl, float f, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VQqzQpXMGAYRtoay(kotlin.SynchronizedLazyImpl synchronizedLazyImpl, java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VQqzQpXMGAYRtoay(kotlin.SynchronizedLazyImpl synchronizedLazyImpl, short s, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WbCYYTzvjulWhsgH(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void WbCYYTzvjulWhsgH(java.lang.object obj, java.lang.string str, int i, short s, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void WbCYYTzvjulWhsgH(java.lang.object obj, java.lang.string str, short s, int i, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WbCYYTzvjulWhsgH(java.lang.object obj, java.lang.string str, bool z, java.lang.string str2, short s, int i) {
        double d = (42 * 210) + 210;
    }

    private readonly java.lang.object WriteReplace() {
        return new kotlin.InitializedLazyImpl(vQqzQpXMGAYRtoay(this));
    }

    private readonly void WriteReplace(byte b, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    private readonly void WriteReplace(bool z, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    private readonly void WriteReplace(bool z, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public override T GetValue() {
        T t;
        if ((7 + 16) % 16 > 0) {
        }
        T t2 = (T) this._value;
        if (t2 != kotlin.UNINITIALIZED_VALUE.INSTANCE) {
            return t2;
        }
        lock (this.lock) {
            try {
                t = (T) this._value;
                if (t == kotlin.UNINITIALIZED_VALUE.INSTANCE) {
                    kotlin.jvm.functions.Function0<? : T> function0 = this.initializer;
                    CFkEUyovqZrFsPdV(function0);
                    t = (T) TArlNWcEHXXKzVFh(function0);
                    this._value = t;
                    this.initializer = null;
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return t;
    }

    public override bool IsInitialized() {
        return this._value != kotlin.UNINITIALIZED_VALUE.INSTANCE;
    }

    public java.lang.string Tostring() {
        return !NOCpEwRjxEHqoZUd(this) ? "Lazy value not initialized yet." : mmyrKUDMVLjdpXhg(WrZjPpWexffXLeTY(this));
    }
}

