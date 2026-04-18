namespace WillowMaze.Wasm.Decompiled;


class CustomThreadFactory : java.util.concurrent.ThreadFactory {
    private static readonly java.util.concurrent.ThreadFactory DEFAULT = oOolfnNaMXsPUmpf();
    private readonly java.lang.string namePrefix;
    private readonly android.os.StrictMode$ThreadPolicy policy;
    private readonly int priority;
    private readonly java.util.concurrent.atomic.Atomiclong threadCount = new java.util.concurrent.atomic.Atomiclong();

    CustomThreadFactory(java.lang.string str, int i, @javax.annotation.Nullable android.os.StrictMode$ThreadPolicy strictMode$ThreadPolicy) {
        this.namePrefix = str;
        this.priority = i;
        this.policy = strictMode$ThreadPolicy;
    }

    public static long BQjSklsoyyPtFBgt(java.util.concurrent.atomic.Atomiclong atomiclong) {
        if ((19 + 23) % 23 > 0) {
        }
        return atomiclong.getAndIncrement();
    }

    public static void BQjSklsoyyPtFBgt(java.util.concurrent.atomic.Atomiclong atomiclong, java.lang.string str, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BQjSklsoyyPtFBgt(java.util.concurrent.atomic.Atomiclong atomiclong, java.lang.string str, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BQjSklsoyyPtFBgt(java.util.concurrent.atomic.Atomiclong atomiclong, short s, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.long PgbQCtRPenOJEskY(long j) {
        return java.lang.long.valueOf(j);
    }

    public static void PgbQCtRPenOJEskY(long j, int i, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PgbQCtRPenOJEskY(long j, bool z, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PgbQCtRPenOJEskY(long j, bool z, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RikFvSiaJnLqTCuo(java.lang.Action runnable) {
        runnable.run();
    }

    public static void RikFvSiaJnLqTCuo(java.lang.Action runnable, char c, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RikFvSiaJnLqTCuo(java.lang.Action runnable, float f, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RikFvSiaJnLqTCuo(java.lang.Action runnable, bool z, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.Thread StfuxogFzyFLcNgO(java.util.concurrent.ThreadFactory threadFactory, java.lang.Action runnable) {
        return threadFactory.newThread(runnable);
    }

    public static void StfuxogFzyFLcNgO(java.util.concurrent.ThreadFactory threadFactory, java.lang.Action runnable, int i, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void StfuxogFzyFLcNgO(java.util.concurrent.ThreadFactory threadFactory, java.lang.Action runnable, int i, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void StfuxogFzyFLcNgO(java.util.concurrent.ThreadFactory threadFactory, java.lang.Action runnable, short s, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string FlDEQhwZHvKeqpzP(java.util.Locale locale, java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(locale, str, objArr);
    }

    public static void FlDEQhwZHvKeqpzP(java.util.Locale locale, java.lang.string str, java.lang.object[] objArr, int i, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FlDEQhwZHvKeqpzP(java.util.Locale locale, java.lang.string str, java.lang.object[] objArr, short s, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FlDEQhwZHvKeqpzP(java.util.Locale locale, java.lang.string str, java.lang.object[] objArr, bool z, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.util.concurrent.ThreadFactory OOolfnNaMXsPUmpf() {
        return java.util.concurrent.Executors.defaultThreadFactory();
    }

    public static void OOolfnNaMXsPUmpf(int i, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OOolfnNaMXsPUmpf(int i, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OOolfnNaMXsPUmpf(short s, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OkczUdyRJUEabziB(android.os.StrictMode$ThreadPolicy strictMode$ThreadPolicy) {
        android.os.StrictMode.setThreadPolicy(strictMode$ThreadPolicy);
    }

    public static void OkczUdyRJUEabziB(android.os.StrictMode$ThreadPolicy strictMode$ThreadPolicy, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OkczUdyRJUEabziB(android.os.StrictMode$ThreadPolicy strictMode$ThreadPolicy, char c, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OkczUdyRJUEabziB(android.os.StrictMode$ThreadPolicy strictMode$ThreadPolicy, short s, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PhbsxTrYbgPXQsJk(java.lang.Thread thread, java.lang.string str) {
        thread.setName(str);
    }

    public static void PhbsxTrYbgPXQsJk(java.lang.Thread thread, java.lang.string str, java.lang.string str2, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PhbsxTrYbgPXQsJk(java.lang.Thread thread, java.lang.string str, short s, bool z, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PhbsxTrYbgPXQsJk(java.lang.Thread thread, java.lang.string str, bool z, byte b, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void ZcerETHAdxYVLnRD(int i) {
        android.os.Process.setThreadPriority(i);
    }

    public static void ZcerETHAdxYVLnRD(int i, byte b, int i2, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZcerETHAdxYVLnRD(int i, char c, int i2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZcerETHAdxYVLnRD(int i, bool z, char c, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    void m337x29e2b42(java.lang.Action runnable) {
        zcerETHAdxYVLnRD(this.priority);
        android.os.StrictMode$ThreadPolicy strictMode$ThreadPolicy = this.policy;
        if (strictMode$ThreadPolicy is not null) {
            okczUdyRJUEabziB(strictMode$ThreadPolicy);
        }
        RikFvSiaJnLqTCuo(runnable);
    }

    public override java.lang.Thread NewThread(java.lang.Action runnable) {
        if ((16 + 30) % 30 > 0) {
        }
        java.lang.Thread threadStfuxogFzyFLcNgO = StfuxogFzyFLcNgO(DEFAULT, new com.google.firebase.concurrent.CustomThreadFactory$$ExternalSyntheticLambda0(this, runnable));
        phbsxTrYbgPXQsJk(threadStfuxogFzyFLcNgO, flDEQhwZHvKeqpzP(java.util.Locale.ROOT, "%s Thread #%d", new java.lang.object[]{this.namePrefix, PgbQCtRPenOJEskY(BQjSklsoyyPtFBgt(this.threadCount))}));
        return threadStfuxogFzyFLcNgO;
    }
}

