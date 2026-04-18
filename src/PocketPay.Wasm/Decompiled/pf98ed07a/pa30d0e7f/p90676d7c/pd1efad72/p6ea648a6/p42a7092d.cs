namespace WillowMaze.Wasm.Decompiled;


public readonly class p42a7092d<T> : io.reactivex.rxjava3.internal.observers.BlockingBaseObserver<T> {
    public static void IgVWBYxzGlVcMKqq(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p6ea648a6.p42a7092d p42a7092dVar) {
        p42a7092dVar.countDown();
    }

    public static void IgVWBYxzGlVcMKqq(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p6ea648a6.p42a7092d p42a7092dVar, float f, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IgVWBYxzGlVcMKqq(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p6ea648a6.p42a7092d p42a7092dVar, int i, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IgVWBYxzGlVcMKqq(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p6ea648a6.p42a7092d p42a7092dVar, bool z, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public void OnError(java.lang.Exception th) {
        this.f2063c160 = null;
        this.fcb5e100e = th;
        igVWBYxzGlVcMKqq(this);
    }

    public void OnNext(T t) {
        this.f2063c160 = t;
    }
}

