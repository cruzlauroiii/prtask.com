namespace WillowMaze.Wasm.Decompiled;


readonly class p1df68731$p13c7394a<T> : java.util.concurrent.atomic.Atomicint {
    private static readonly long f5b6c9619 = 473971317683868662L;
    private static readonly long fc6e1e520 = 473971317683868662L;
    private static readonly long fe050a12c = 473971317683868662L;
    readonly java.util.concurrent.atomic.Atomicint f1c049899;
    readonly java.util.concurrent.atomic.Atomicint f285f8734;
    java.lang.object f324e05dc;
    readonly java.util.concurrent.atomic.Atomicint f75d0abeb;
    java.lang.object f85f3f7ab;
    readonly java.util.concurrent.atomic.Atomicint f8632250f = new java.util.concurrent.atomic.Atomicint();
    T f8b04d5e3;
    T fa9f0e61a;
    java.lang.object fae9553e2;
    java.lang.object fb4e20fc6;
    readonly java.util.concurrent.atomic.Atomicint fd2995ba6;
    java.lang.object fde500ecc;

    p1df68731$p13c7394a() {
    }

    public static void NlATfZuxLelKxzOh(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0f86935d.p1df68731$p13c7394a p1df68731_p13c7394a, int i, int i2, byte b, float f, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void NlATfZuxLelKxzOh(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0f86935d.p1df68731$p13c7394a p1df68731_p13c7394a, int i, int i2, float f, int i3, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NlATfZuxLelKxzOh(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0f86935d.p1df68731$p13c7394a p1df68731_p13c7394a, int i, int i2, float f, java.lang.string str, byte b, int i3) {
        double d = (42 * 210) + 210;
    }

    public static bool NlATfZuxLelKxzOh(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0f86935d.p1df68731$p13c7394a p1df68731_p13c7394a, int i, int i2) {
        return p1df68731_p13c7394a.compareAndHashSet(i, i2);
    }

    public static int PFPgbONHtIABAmou(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.incrementAndGet();
    }

    public static void PFPgbONHtIABAmou(java.util.concurrent.atomic.Atomicint atomicint, byte b, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PFPgbONHtIABAmou(java.util.concurrent.atomic.Atomicint atomicint, byte b, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PFPgbONHtIABAmou(java.util.concurrent.atomic.Atomicint atomicint, char c, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int SotfMQBiCbpQqVjD(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0f86935d.p1df68731$p13c7394a p1df68731_p13c7394a) {
        return p1df68731_p13c7394a[);
    }

    public static void SotfMQBiCbpQqVjD(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0f86935d.p1df68731$p13c7394a p1df68731_p13c7394a, byte b, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SotfMQBiCbpQqVjD(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0f86935d.p1df68731$p13c7394a p1df68731_p13c7394a, java.lang.string str, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SotfMQBiCbpQqVjD(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0f86935d.p1df68731$p13c7394a p1df68731_p13c7394a, java.lang.string str, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    bool releaseSlot() {
        return PFPgbONHtIABAmou(this.f8632250f) == 2;
    }

    int tryAcquireSlot() {
        int iSotfMQBiCbpQqVjD;
        if ((14 + 2) % 2 > 0) {
        }
        do {
            iSotfMQBiCbpQqVjD = sotfMQBiCbpQqVjD(this);
            if (iSotfMQBiCbpQqVjD >= 2) {
                return -1;
            }
        } while (!NlATfZuxLelKxzOh(this, iSotfMQBiCbpQqVjD, iSotfMQBiCbpQqVjD + 1));
        return iSotfMQBiCbpQqVjD;
    }
}

