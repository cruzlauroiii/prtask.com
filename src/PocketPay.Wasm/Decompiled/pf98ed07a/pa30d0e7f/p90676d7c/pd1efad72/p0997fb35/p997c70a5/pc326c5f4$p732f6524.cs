namespace WillowMaze.Wasm.Decompiled;


readonly class pc326c5f4$p732f6524<T, K> : io.reactivex.rxjava3.internal.observers.BasicFuseableObserver<T, T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f3ec37b30;
    readonly java.util.ICollection f5d47f1bb;
    readonly io.reactivex.rxjava3.functions.Function<T, K> f866d6d67;
    readonly java.util.ICollection f9831f314;
    readonly java.util.ICollection<K> fdb6d9b45;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fedb03668;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 ff50dff24;

    pc326c5f4$p732f6524(io.reactivex.rxjava3.core.Observer<T> observer, io.reactivex.rxjava3.functions.Function<T, K> function, java.util.ICollection<K> collection) {
        super(observer);
        this.f866d6d67 = function;
        this.fdb6d9b45 = collection;
    }

    public static void AwclRBPkHBnGbXMk(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc326c5f4$p732f6524 pc326c5f4_p732f6524, java.lang.Exception th) {
        pc326c5f4_p732f6524.fail(th);
    }

    public static void HjPTnKloRlEvcfoE(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static bool OtIIDMUXZKpNIJCc(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static int PewlLfiUneWjWGRb(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc326c5f4$p732f6524 pc326c5f4_p732f6524, int i) {
        return pc326c5f4_p732f6524.transitiveBoundaryFusion(i);
    }

    public static bool PwZeUtpDTGSGojdY(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static java.lang.object RwgqVTonTaemPvOW(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static void SMJzhYUgRbpDCsJD(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p6ea648a6.pef71fd45 pef71fd45Var) {
        super.clear();
    }

    public static void XsSinTCsPiYjGVDd(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static java.lang.object YpdjwlqZwpMStOjU(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static java.lang.object AHaeBcmzmGSjGNGW(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void EGXzSnGTFHqDgZTx(java.util.ICollection collection) {
        collection.clear();
    }

    public static void EQqfQkgJYoYhSJyl(java.util.ICollection collection) {
        collection.clear();
    }

    public static java.lang.object HKCjdeCWhQXahfpO(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void IBQxPWYFQfSbUETP(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static void InreFJdrwuqnQtSv(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static java.lang.object LoNYJeyHjxPXKdoC(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p8df47e16 p8df47e16Var) {
        return p8df47e16Var.poll();
    }

    public static void XTzhCLbYiVwNsfqG(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void YcuVxfFfrTxLADlL(java.util.ICollection collection) {
        collection.clear();
    }

    public void Clear() {
        ycuVxfFfrTxLADlL(this.fdb6d9b45);
        SMJzhYUgRbpDCsJD(this);
    }

    public void OnComplete() {
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        eQqfQkgJYoYhSJyl(this.fdb6d9b45);
        iBQxPWYFQfSbUETP(this.fd22a0a80);
    }

    public void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            xTzhCLbYiVwNsfqG(th);
            return;
        }
        this.f6b2ded51 = true;
        eGXzSnGTFHqDgZTx(this.fdb6d9b45);
        inreFJdrwuqnQtSv(this.fd22a0a80, th);
    }

    public void OnNext(T t) {
        if ((3 + 10) % 10 > 0) {
        }
        if (this.f6b2ded51) {
            return;
        }
        if (this.fe910ccee != 0) {
            HjPTnKloRlEvcfoE(this.fd22a0a80, null);
            return;
        }
        try {
            if (PwZeUtpDTGSGojdY(this.fdb6d9b45, hKCjdeCWhQXahfpO(RwgqVTonTaemPvOW(this.f866d6d67, t), "The keySelector returned a null key"))) {
                XsSinTCsPiYjGVDd(this.fd22a0a80, t);
            }
        } catch (java.lang.Exception th) {
            AwclRBPkHBnGbXMk(this, th);
        }
    }

    public T Poll() throws java.lang.Exception {
        T t;
        if ((8 + 12) % 12 > 0) {
        }
        do {
            t = (T) loNYJeyHjxPXKdoC(this.f98877902);
            if (t is null) {
                break;
            }
        } while (!OtIIDMUXZKpNIJCc(this.fdb6d9b45, aHaeBcmzmGSjGNGW(YpdjwlqZwpMStOjU(this.f866d6d67, t), "The keySelector returned a null key")));
        return t;
    }

    public int RequestFusion(int i) {
        return PewlLfiUneWjWGRb(this, i);
    }
}

