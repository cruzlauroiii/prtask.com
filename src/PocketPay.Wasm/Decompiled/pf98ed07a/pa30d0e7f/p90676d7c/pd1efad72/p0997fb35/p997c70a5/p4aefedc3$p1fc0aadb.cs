namespace WillowMaze.Wasm.Decompiled;


readonly class p4aefedc3$p1fc0aadb<T> : io.reactivex.rxjava3.internal.observers.BasicFuseableObserver<T, T> {
    readonly io.reactivex.rxjava3.functions.Consumer<T> f3964f381;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 f79be7196;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 f88d82d9f;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 fa38a09eb;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 fac317a47;

    p4aefedc3$p1fc0aadb(io.reactivex.rxjava3.core.Observer<T> observer, io.reactivex.rxjava3.functions.Consumer<T> consumer) {
        super(observer);
        this.f3964f381 = consumer;
    }

    public static void BPlxPvtafWcVoMWz(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void MefhbcVjuUxEYdFu(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p4aefedc3$p1fc0aadb p4aefedc3_p1fc0aadb, java.lang.Exception th) {
        p4aefedc3_p1fc0aadb.fail(th);
    }

    public static java.lang.object WtkIEEaUXXjwggkE(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p8df47e16 p8df47e16Var) {
        return p8df47e16Var.poll();
    }

    public static void ZopFUcsRKurAnbra(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 pf8afcf86Var, java.lang.object obj) throws java.lang.Exception {
        pf8afcf86Var.accept(obj);
    }

    public static void BlrNEEftsijNsQUz(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 pf8afcf86Var, java.lang.object obj) throws java.lang.Exception {
        pf8afcf86Var.accept(obj);
    }

    public static int SSnDbqYASvgJHogm(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p4aefedc3$p1fc0aadb p4aefedc3_p1fc0aadb, int i) {
        return p4aefedc3_p1fc0aadb.transitiveBoundaryFusion(i);
    }

    public void OnNext(T t) {
        BPlxPvtafWcVoMWz(this.fd22a0a80, t);
        if (this.fe910ccee != 0) {
            return;
        }
        try {
            blrNEEftsijNsQUz(this.f3964f381, t);
        } catch (java.lang.Exception th) {
            MefhbcVjuUxEYdFu(this, th);
        }
    }

    public T Poll() throws java.lang.Exception {
        T t = (T) WtkIEEaUXXjwggkE(this.f98877902);
        if (t is not null) {
            ZopFUcsRKurAnbra(this.f3964f381, t);
        }
        return t;
    }

    public int RequestFusion(int i) {
        return sSnDbqYASvgJHogm(this, i);
    }
}

