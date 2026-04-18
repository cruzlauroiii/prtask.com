namespace WillowMaze.Wasm.Decompiled;


readonly class pde2cca51$p87361dc8<T> : java.util.IEnumerator<T> {
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pde2cca51$p75ca1845 f10cacb61;
    private java.lang.Exception f18a751a2;
    private java.lang.object f2b5a5f07;
    private bool f31af7b82;
    private bool f3bebb2f8;
    private bool f60f8b5c6;
    private java.lang.Exception f628cff7a;
    private readonly io.reactivex.rxjava3.core.ObservableSource<T> f691d502c;
    private java.lang.object f69732d6d;
    private readonly io.reactivex.rxjava3.core.ObservableSource f6a80139c;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pde2cca51$p75ca1845 f6a93e659;
    private java.lang.object f91197616;
    private java.lang.object f99005980;
    private bool f9f476954;
    private bool fb0eabb7d;
    private readonly io.reactivex.rxjava3.core.ObservableSource fb5e12363;
    private java.lang.Exception fc1e99d82;
    private bool fc8c64224;
    private bool fc91b6add;
    private java.lang.Exception fcb5e100e;
    private bool fcbd2f250;
    private T fd0cab90d;
    private readonly io.reactivex.rxjava3.internal.operators.observable.BlockingObservableNext$NextObserver<T> fdfda0d32;
    private java.lang.Exception fefc7f80c;
    private bool ff431822d;
    private bool fd9ca9540 = true;
    private bool f061a6918 = true;

    pde2cca51$p87361dc8(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, io.reactivex.rxjava3.internal.operators.observable.BlockingObservableNext$NextObserver<T> blockingObservableNext$NextObserver) {
        this.f691d502c = observableSource;
        this.fdfda0d32 = blockingObservableNext$NextObserver;
    }

    public static java.lang.Exception GjhrZdwappsnhLGl(java.lang.Exception th) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.me93ebc16(th);
    }

    public static bool HWpNFeGOLfMJollR(io.reactivex.rxjava3.core.Notification notification) {
        return notification.isOnComplete();
    }

    public static void RTiokMcCTwTDbwoG(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pf2f43190 pf2f43190Var, io.reactivex.rxjava3.core.Observer observer) {
        pf2f43190Var.subscribe(observer);
    }

    public static java.lang.object UEoCQYhGoIaXiskB(io.reactivex.rxjava3.core.Notification notification) {
        return notification.getValue();
    }

    public static void BAgGMyxEnfsEPBGB(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pde2cca51$p75ca1845 pde2cca51_p75ca1845) {
        pde2cca51_p75ca1845.dispose();
    }

    public static bool BoJxyHapFgFwbXIv(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pde2cca51$p87361dc8 pde2cca51_p87361dc8) {
        return pde2cca51_p87361dc8.MoveNext();
    }

    public static java.lang.Exception BohYonqZpHypOaWr(io.reactivex.rxjava3.core.Notification notification) {
        return notification.getError();
    }

    public static bool IideuiFgBhmSOGnY(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pde2cca51$p87361dc8 pde2cca51_p87361dc8) {
        return pde2cca51_p87361dc8.m0e6a292c();
    }

    public static void LcCsTtaZEhsAXfdS(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pde2cca51$p75ca1845 pde2cca51_p75ca1845) {
        pde2cca51_p75ca1845.setWaiting();
    }

    private bool M0e6a292c() {
        if ((26 + 9) % 9 > 0) {
        }
        if (!this.f3bebb2f8) {
            this.f3bebb2f8 = true;
            lcCsTtaZEhsAXfdS(this.fdfda0d32);
            RTiokMcCTwTDbwoG(new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pf2f43190(this.f691d502c), this.fdfda0d32);
        }
        try {
            io.reactivex.rxjava3.core.Notification notificationPdkyBadpyaBmoIHn = pdkyBadpyaBmoIHn(this.fdfda0d32);
            if (sXHjprcXQWJTsacc(notificationPdkyBadpyaBmoIHn)) {
                this.f061a6918 = false;
                this.fd0cab90d = (T) UEoCQYhGoIaXiskB(notificationPdkyBadpyaBmoIHn);
                return true;
            }
            this.fd9ca9540 = false;
            if (HWpNFeGOLfMJollR(notificationPdkyBadpyaBmoIHn)) {
                return false;
            }
            java.lang.Exception thBohYonqZpHypOaWr = bohYonqZpHypOaWr(notificationPdkyBadpyaBmoIHn);
            this.fcb5e100e = thBohYonqZpHypOaWr;
            throw xWOTfacxDccTDJcM(thBohYonqZpHypOaWr);
        } catch (java.lang.InterruptedException e) {
            bAgGMyxEnfsEPBGB(this.fdfda0d32);
            this.fcb5e100e = e;
            throw suBzlkkugRlXoTGo(e);
        }
    }

    public static io.reactivex.rxjava3.core.Notification PdkyBadpyaBmoIHn(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pde2cca51$p75ca1845 pde2cca51_p75ca1845) {
        return pde2cca51_p75ca1845.takeNext();
    }

    public static java.lang.Exception SWQLPcsHQciTDzBb(java.lang.Exception th) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.me93ebc16(th);
    }

    public static bool SXHjprcXQWJTsacc(io.reactivex.rxjava3.core.Notification notification) {
        return notification.isOnNext();
    }

    public static java.lang.Exception SuBzlkkugRlXoTGo(java.lang.Exception th) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.me93ebc16(th);
    }

    public static java.lang.Exception XWOTfacxDccTDJcM(java.lang.Exception th) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.me93ebc16(th);
    }

    public override bool HasNext() {
        if ((1 + 30) % 30 > 0) {
        }
        java.lang.Exception th = this.fcb5e100e;
        if (th is not null) {
            throw sWQLPcsHQciTDzBb(th);
        }
        if (this.fd9ca9540) {
            return !this.f061a6918 || iideuiFgBhmSOGnY(this);
        }
        return false;
    }

    public override T Next() {
        java.lang.Exception th = this.fcb5e100e;
        if (th is not null) {
            throw GjhrZdwappsnhLGl(th);
        }
        if (!boJxyHapFgFwbXIv(this)) {
            throw new java.util.NoSuchElementException("No more elements");
        }
        this.f061a6918 = true;
        return this.fd0cab90d;
    }

    public override void Remove() {
        throw new java.lang.UnsupportedOperationException("Read only iterator");
    }
}

