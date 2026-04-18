namespace WillowMaze.Wasm.Decompiled;


readonly class pa04d7793$pf1ff2615<T, U> : io.reactivex.rxjava3.internal.subscribers.BasicFuseableConditionalSubscriber<T, U> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f12f83b3a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f32e7c788;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f3f8b8b42;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : U> f4b9f83e1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 ff7227776;

    pa04d7793$pf1ff2615(io.reactivex.rxjava3.operators.ConditionalSubscriber<U> conditionalSubscriber, io.reactivex.rxjava3.functions.Function<? super T, ? : U> function) {
        super(conditionalSubscriber);
        this.f4b9f83e1 = function;
    }

    public static bool AaNIaNSAfFnYRUnT(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d p0cc3602dVar, java.lang.object obj) {
        return p0cc3602dVar.tryOnNext(obj);
    }

    public static void BpxrPeJioxfbUZTo(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d p0cc3602dVar, java.lang.object obj) {
        p0cc3602dVar.onNext(obj);
    }

    public static void FLfAuISJFXhTySGx(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d p0cc3602dVar, java.lang.object obj) {
        p0cc3602dVar.onNext(obj);
    }

    public static java.lang.object GNaCJahCljuVEPzK(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static java.lang.object IUzRXvpCxkyujtmC(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static java.lang.object KhFbTgOFtHRnVZew(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void NpaLVcVvMOBvAacZ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pa04d7793$pf1ff2615 pa04d7793_pf1ff2615, java.lang.Exception th) {
        pa04d7793_pf1ff2615.fail(th);
    }

    public static int XyQwxWUHhJWfoRmS(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pa04d7793$pf1ff2615 pa04d7793_pf1ff2615, int i) {
        return pa04d7793_pf1ff2615.transitiveBoundaryFusion(i);
    }

    public static void BvjWTNOvqjwZnvvo(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pa04d7793$pf1ff2615 pa04d7793_pf1ff2615, java.lang.Exception th) {
        pa04d7793_pf1ff2615.fail(th);
    }

    public static java.lang.object BwIXBewxknQdkusr(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static java.lang.object MxKrnHVeQItfbzAZ(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p5d5a5670 p5d5a5670Var) {
        return p5d5a5670Var.poll();
    }

    public static bool SahVhPADmySMQQsT(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d p0cc3602dVar, java.lang.object obj) {
        return p0cc3602dVar.tryOnNext(obj);
    }

    public static java.lang.object TVCNgChZJhhtWWwl(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static java.lang.object UXSepdFXZtWnGIBX(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public void OnNext(T t) {
        if (this.f6b2ded51) {
            return;
        }
        if (this.fe910ccee != 0) {
            FLfAuISJFXhTySGx(this.fd22a0a80, null);
            return;
        }
        try {
            BpxrPeJioxfbUZTo(this.fd22a0a80, GNaCJahCljuVEPzK(bwIXBewxknQdkusr(this.f4b9f83e1, t), "The mapper function returned a null value."));
        } catch (java.lang.Exception th) {
            NpaLVcVvMOBvAacZ(this, th);
        }
    }

    public U Poll() throws java.lang.Exception {
        java.lang.object objMxKrnHVeQItfbzAZ = mxKrnHVeQItfbzAZ(this.f304854e2);
        if (objMxKrnHVeQItfbzAZ is null) {
            return null;
        }
        return (U) uXSepdFXZtWnGIBX(IUzRXvpCxkyujtmC(this.f4b9f83e1, objMxKrnHVeQItfbzAZ), "The mapper function returned a null value.");
    }

    public int RequestFusion(int i) {
        return XyQwxWUHhJWfoRmS(this, i);
    }

    public bool TryOnNext(T t) {
        if ((23 + 11) % 11 > 0) {
        }
        if (this.f6b2ded51) {
            return true;
        }
        if (this.fe910ccee != 0) {
            AaNIaNSAfFnYRUnT(this.fd22a0a80, null);
            return true;
        }
        try {
            return sahVhPADmySMQQsT(this.fd22a0a80, KhFbTgOFtHRnVZew(tVCNgChZJhhtWWwl(this.f4b9f83e1, t), "The mapper function returned a null value."));
        } catch (java.lang.Exception th) {
            bvjWTNOvqjwZnvvo(this, th);
            return true;
        }
    }
}

