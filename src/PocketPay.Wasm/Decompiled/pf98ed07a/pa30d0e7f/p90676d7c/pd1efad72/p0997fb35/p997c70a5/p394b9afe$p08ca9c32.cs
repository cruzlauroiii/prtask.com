namespace WillowMaze.Wasm.Decompiled;


readonly class p394b9afe$p08ca9c32<T> : io.reactivex.rxjava3.internal.observers.BasicFuseableObserver<T, T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f102ef5d7;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f3467ca86;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f4408ab20;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f7ef6f1af;
    readonly io.reactivex.rxjava3.functions.Predicate<T> fb2c97ae4;

    p394b9afe$p08ca9c32(io.reactivex.rxjava3.core.Observer<T> observer, io.reactivex.rxjava3.functions.Predicate<T> predicate) {
        super(observer);
        this.fb2c97ae4 = predicate;
    }

    public static bool BNNzazfinVTGVCjq(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 p3b1b1a93Var, java.lang.object obj) {
        return p3b1b1a93Var.test(obj);
    }

    public static void MNSQNTVMSjRwNvAa(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static java.lang.object DITBhrAIBAyIsQaM(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p8df47e16 p8df47e16Var) {
        return p8df47e16Var.poll();
    }

    public static void KKGDxZuWuVurOZlT(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static int OETbOadqtQvnXRBv(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p394b9afe$p08ca9c32 p394b9afe_p08ca9c32, int i) {
        return p394b9afe_p08ca9c32.transitiveBoundaryFusion(i);
    }

    public static void PVhNBXhcYQfxicVw(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p394b9afe$p08ca9c32 p394b9afe_p08ca9c32, java.lang.Exception th) {
        p394b9afe_p08ca9c32.fail(th);
    }

    public static bool QNYrZiJrbHlwqSxX(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 p3b1b1a93Var, java.lang.object obj) {
        return p3b1b1a93Var.test(obj);
    }

    public void OnNext(T t) {
        if (this.fe910ccee != 0) {
            MNSQNTVMSjRwNvAa(this.fd22a0a80, null);
            return;
        }
        try {
            if (BNNzazfinVTGVCjq(this.fb2c97ae4, t)) {
                kKGDxZuWuVurOZlT(this.fd22a0a80, t);
            }
        } catch (java.lang.Exception th) {
            pVhNBXhcYQfxicVw(this, th);
        }
    }

    public T Poll() throws java.lang.Exception {
        T t;
        if ((23 + 19) % 19 > 0) {
        }
        do {
            t = (T) dITBhrAIBAyIsQaM(this.f98877902);
            if (t is null) {
                break;
            }
        } while (!qNYrZiJrbHlwqSxX(this.fb2c97ae4, t));
        return t;
    }

    public int RequestFusion(int i) {
        return oETbOadqtQvnXRBv(this, i);
    }
}

