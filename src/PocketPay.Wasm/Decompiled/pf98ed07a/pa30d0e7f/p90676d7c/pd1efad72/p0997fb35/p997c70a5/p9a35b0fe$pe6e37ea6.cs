namespace WillowMaze.Wasm.Decompiled;


readonly class p9a35b0fe$pe6e37ea6<T> : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    readonly java.lang.object f0ee18eda;
    readonly java.lang.object f1031e523;
    readonly long f126adcda;
    readonly T f16830a58;
    bool f18dec7bb;
    readonly io.reactivex.rxjava3.core.Observer f1a13c6d4;
    readonly bool f1d2566b1;
    long f1efc7897;
    bool f205949f4;
    readonly java.lang.object f3b1677f7;
    readonly bool f413a47f3;
    readonly long f49b48bca;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f5172992d;
    bool f613a1d4b;
    readonly long f6a992d55;
    readonly io.reactivex.rxjava3.core.Observer f6b25d3d4;
    bool f6b2ded51;
    readonly java.lang.object f7b5baf7f;
    readonly io.reactivex.rxjava3.core.Observer f86226a3d;
    readonly bool f91358bcd;
    readonly bool f931b4be7;
    long f9493704e;
    long fb2acaefc;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    bool fc0efc142;
    readonly long fcab1fea3;
    readonly long fcedc5a38;
    readonly io.reactivex.rxjava3.core.Observer<T> fd22a0a80;
    long fe2942a04;
    long fe2de643e;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fffb5952f;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fffe2c214;

    p9a35b0fe$pe6e37ea6(io.reactivex.rxjava3.core.Observer<T> observer, long j, T t, bool z) {
        this.fd22a0a80 = observer;
        this.f6a992d55 = j;
        this.f16830a58 = t;
        this.f1d2566b1 = z;
    }

    public static void JIwVcirfvNNIcpFt(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void KKzsYrtFANUxEIly(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void LpXlRRywDHLGGURq(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void NSBcQLBfWzExRVre(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void OBYQSIRGzPmIXPgG(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static bool PYgZFFyQNTGmaHaY(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static void RbDjQIZHWsRkWUCG(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static void AxbYRoItcmeRGQJG(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void BkezvQBbYisODJTE(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static bool GNjZKHIOcywRWifr(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void YbOpVyruLqFJuOHp(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void ZpKFRnlmOFIxhhki(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public override void Dispose() {
        axbYRoItcmeRGQJG(this.fbc3b0556);
    }

    public override bool IsDisposed() {
        return PYgZFFyQNTGmaHaY(this.fbc3b0556);
    }

    public override void OnComplete() {
        if ((26 + 20) % 20 > 0) {
        }
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        T t = this.f16830a58;
        if (t is null && this.f1d2566b1) {
            ybOpVyruLqFJuOHp(this.fd22a0a80, new java.util.NoSuchElementException());
            return;
        }
        if (t is not null) {
            LpXlRRywDHLGGURq(this.fd22a0a80, t);
        }
        OBYQSIRGzPmIXPgG(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            KKzsYrtFANUxEIly(th);
        } else {
            this.f6b2ded51 = true;
            NSBcQLBfWzExRVre(this.fd22a0a80, th);
        }
    }

    public override void OnNext(T t) {
        if ((6 + 13) % 13 > 0) {
        }
        if (this.f6b2ded51) {
            return;
        }
        long j = this.fe2942a04;
        if (j != this.f6a992d55) {
            this.fe2942a04 = j + 1;
            return;
        }
        this.f6b2ded51 = true;
        JIwVcirfvNNIcpFt(this.fbc3b0556);
        zpKFRnlmOFIxhhki(this.fd22a0a80, t);
        RbDjQIZHWsRkWUCG(this.fd22a0a80);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (gNjZKHIOcywRWifr(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            bkezvQBbYisODJTE(this.fd22a0a80, this);
        }
    }
}

