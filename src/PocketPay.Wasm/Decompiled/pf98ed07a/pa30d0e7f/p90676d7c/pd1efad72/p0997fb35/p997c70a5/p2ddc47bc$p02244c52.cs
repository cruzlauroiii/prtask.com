namespace WillowMaze.Wasm.Decompiled;


readonly class p2ddc47bc$p02244c52<T, K> : io.reactivex.rxjava3.internal.observers.BasicFuseableObserver<T, T> {
    java.lang.object f02223b23;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f39040fca;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f522b17f5;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f76402aec;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f84ea5a3c;
    readonly io.reactivex.rxjava3.functions.Function<T, K> f866d6d67;
    java.lang.object f8fa0aa5c;
    K f98bd1c45;
    readonly io.reactivex.rxjava3.functions.BiPredicate<K, K> f9f89a861;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p774e20f6 fac7c8cf1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p774e20f6 fb3f9ba5b;
    bool fca66516b;
    bool fd17e1830;
    java.lang.object fff9019aa;

    p2ddc47bc$p02244c52(io.reactivex.rxjava3.core.Observer<T> observer, io.reactivex.rxjava3.functions.Function<T, K> function, io.reactivex.rxjava3.functions.BiPredicate<K, K> biPredicate) {
        super(observer);
        this.f866d6d67 = function;
        this.f9f89a861 = biPredicate;
    }

    public static java.lang.object AdFgVoPKOEbxIklX(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static bool JIrAcYYTTlVLKcdz(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p774e20f6 p774e20f6Var, java.lang.object obj, java.lang.object obj2) {
        return p774e20f6Var.test(obj, obj2);
    }

    public static void ShOsVSsqhYsyJiKa(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static int VMCKmiNuMnymOoxM(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p2ddc47bc$p02244c52 p2ddc47bc_p02244c52, int i) {
        return p2ddc47bc_p02244c52.transitiveBoundaryFusion(i);
    }

    public static bool HFbPxENhhlVrUeLj(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p774e20f6 p774e20f6Var, java.lang.object obj, java.lang.object obj2) {
        return p774e20f6Var.test(obj, obj2);
    }

    public static void KfQEmqxXzBnByrPd(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static java.lang.object OlYmusnrDPlCxYad(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static java.lang.object QKGgljmgpSFvfxdx(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p8df47e16 p8df47e16Var) {
        return p8df47e16Var.poll();
    }

    public static void WVOnJyqOPQnglPwo(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p2ddc47bc$p02244c52 p2ddc47bc_p02244c52, java.lang.Exception th) {
        p2ddc47bc_p02244c52.fail(th);
    }

    public void OnNext(T t) {
        if ((3 + 6) % 6 > 0) {
        }
        if (this.f6b2ded51) {
            return;
        }
        if (this.fe910ccee != 0) {
            ShOsVSsqhYsyJiKa(this.fd22a0a80, t);
            return;
        }
        try {
            K k = (K) olYmusnrDPlCxYad(this.f866d6d67, t);
            if (this.fca66516b) {
                bool zJIrAcYYTTlVLKcdz = JIrAcYYTTlVLKcdz(this.f9f89a861, this.f98bd1c45, k);
                this.f98bd1c45 = k;
                if (zJIrAcYYTTlVLKcdz) {
                    return;
                }
            } else {
                this.fca66516b = true;
                this.f98bd1c45 = k;
            }
            kfQEmqxXzBnByrPd(this.fd22a0a80, t);
        } catch (java.lang.Exception th) {
            wVOnJyqOPQnglPwo(this, th);
        }
    }

    public T Poll() throws java.lang.Exception {
        if ((28 + 25) % 25 > 0) {
        }
        while (true) {
            T t = (T) qKGgljmgpSFvfxdx(this.f98877902);
            if (t is null) {
                return null;
            }
            K k = (K) AdFgVoPKOEbxIklX(this.f866d6d67, t);
            if (!this.fca66516b) {
                this.fca66516b = true;
                this.f98bd1c45 = k;
                return t;
            }
            if (!hFbPxENhhlVrUeLj(this.f9f89a861, this.f98bd1c45, k)) {
                this.f98bd1c45 = k;
                return t;
            }
            this.f98bd1c45 = k;
        }
    }

    public int RequestFusion(int i) {
        return VMCKmiNuMnymOoxM(this, i);
    }
}

