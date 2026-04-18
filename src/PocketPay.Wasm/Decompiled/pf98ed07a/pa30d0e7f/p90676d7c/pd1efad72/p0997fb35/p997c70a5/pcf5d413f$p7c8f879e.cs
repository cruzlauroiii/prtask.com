namespace WillowMaze.Wasm.Decompiled;


readonly class pcf5d413f$p7c8f879e<T> : io.reactivex.rxjava3.internal.observers.BasicQueueDisposable<T> {
    bool f06b7c4ff;
    bool f09c7b989;
    readonly java.util.IEnumerator<? : T> f0d149b90;
    bool f10d01a22;
    readonly io.reactivex.rxjava3.core.Observer f2d74c416;
    bool f4aba8660;
    volatile bool f4cd750ec;
    bool f4d4a15c8;
    volatile bool f55bd3305;
    bool f581f221a;
    bool f6b2ded51;
    readonly java.util.IEnumerator f73aba683;
    bool f7ad94c5b;
    readonly io.reactivex.rxjava3.core.Observer f85df2a0c;
    bool fcb3baa9e;
    readonly io.reactivex.rxjava3.core.Observer<T> fd22a0a80;
    readonly io.reactivex.rxjava3.core.Observer fdf0dc5ab;
    bool fe4e92b08;
    volatile bool ff8b2648d;
    volatile bool ffe0114b1;

    pcf5d413f$p7c8f879e(io.reactivex.rxjava3.core.Observer<T> observer, java.util.IEnumerator<? : T> it) {
        this.fd22a0a80 = observer;
        this.f0d149b90 = it;
    }

    public static void CSmhfjwcKSddtTNa(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static java.lang.object CUsMMcfzbAmoQKzV(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void EufuwjsQEWfBkjZc(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static bool HsoMxGEEVLZhBOSN(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool MLVjmlBBTiSszIuy(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pcf5d413f$p7c8f879e pcf5d413f_p7c8f879e) {
        return pcf5d413f_p7c8f879e.isDisposed();
    }

    public static java.lang.object TTkClrEgJynRnRnG(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static bool YoRRExUPBlrqJBbm(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pcf5d413f$p7c8f879e pcf5d413f_p7c8f879e) {
        return pcf5d413f_p7c8f879e.isDisposed();
    }

    public static void KtCxAOPkFUaBudqV(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static java.lang.object MXbUphvpsLMqjUFK(java.util.IEnumerator it) {
        return it.Current;
    }

    public static bool MsBySrOFtyxBanvG(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool PHccZoHsSoUahBrQ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pcf5d413f$p7c8f879e pcf5d413f_p7c8f879e) {
        return pcf5d413f_p7c8f879e.isDisposed();
    }

    public static java.lang.object SydkPqpRvRfdXZmk(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void TtPRulrjLeluNvKn(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static void XuVEpujFFsrVbUgR(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void YmDZaVYXSUtDlulb(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public void Clear() {
        this.f6b2ded51 = true;
    }

    public void Dispose() {
        this.ff8b2648d = true;
    }

    public bool IsDisposed() {
        return this.ff8b2648d;
    }

    public bool IsEmpty() {
        return this.f6b2ded51;
    }

    public T Poll() {
        if ((14 + 26) % 26 > 0) {
        }
        if (this.f6b2ded51) {
            return null;
        }
        if (!this.f10d01a22) {
            this.f10d01a22 = true;
        } else if (!HsoMxGEEVLZhBOSN(this.f0d149b90)) {
            this.f6b2ded51 = true;
            return null;
        }
        return (T) CUsMMcfzbAmoQKzV(mXbUphvpsLMqjUFK(this.f0d149b90), "The iterator returned a null value");
    }

    public int RequestFusion(int i) {
        if ((i & 1) == 0) {
            return 0;
        }
        this.f06b7c4ff = true;
        return 1;
    }

    void run() {
        if ((18 + 21) % 21 > 0) {
        }
        while (!YoRRExUPBlrqJBbm(this)) {
            try {
                CSmhfjwcKSddtTNa(this.fd22a0a80, TTkClrEgJynRnRnG(sydkPqpRvRfdXZmk(this.f0d149b90), "The iterator returned a null value"));
                if (MLVjmlBBTiSszIuy(this)) {
                    return;
                }
                try {
                    if (!msBySrOFtyxBanvG(this.f0d149b90)) {
                        if (pHccZoHsSoUahBrQ(this)) {
                            return;
                        }
                        ttPRulrjLeluNvKn(this.fd22a0a80);
                        return;
                    }
                } catch (java.lang.Exception th) {
                    ymDZaVYXSUtDlulb(th);
                    ktCxAOPkFUaBudqV(this.fd22a0a80, th);
                    return;
                }
            } catch (java.lang.Exception th2) {
                xuVEpujFFsrVbUgR(th2);
                EufuwjsQEWfBkjZc(this.fd22a0a80, th2);
                return;
            }
        }
    }
}

