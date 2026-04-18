namespace WillowMaze.Wasm.Decompiled;


readonly class p9934b3b6$p1fc0aadb<T> : io.reactivex.rxjava3.core.SingleObserver<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    readonly io.reactivex.rxjava3.functions.Consumer<T> f22a1f716;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f37c781dc;
    readonly io.reactivex.rxjava3.core.SingleObserver f4dbd352c;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f63748f9e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 fa3d12e17;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 fc7109a16;
    readonly io.reactivex.rxjava3.core.SingleObserver<T> fd22a0a80;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 fdb9a4f8b;
    readonly io.reactivex.rxjava3.core.SingleObserver fdf01a611;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 fe26fc62d;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fe944d05e;

    p9934b3b6$p1fc0aadb(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver, io.reactivex.rxjava3.functions.Consumer<T> consumer) {
        this.fd22a0a80 = singleObserver;
        this.f22a1f716 = consumer;
    }

    public static bool QAvvDdknlHexJByp(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static void QtDrntpaevEOUbsD(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void VxHBYBuTAKoWesHl(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 pf8afcf86Var, java.lang.object obj) throws java.lang.Exception {
        pf8afcf86Var.accept(obj);
    }

    public static void BXCFNGKiZNnAPEdx(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void DEufPQOaxlriSIDs(io.reactivex.rxjava3.core.SingleObserver singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        singleObserver.onSubscribe(p7beea252Var);
    }

    public static bool KizAUEMjaSnzKlan(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void LGjjSzcfLCsuDLHw(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public static void MaTJGdqtaNZoCePr(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void REjUnAjibqjfMztP(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public override void Dispose() {
        maTJGdqtaNZoCePr(this.fbc3b0556);
    }

    public override bool IsDisposed() {
        return QAvvDdknlHexJByp(this.fbc3b0556);
    }

    public override void OnError(java.lang.Exception th) {
        rEjUnAjibqjfMztP(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (kizAUEMjaSnzKlan(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            dEufPQOaxlriSIDs(this.fd22a0a80, this);
        }
    }

    public override void OnSuccess(T t) {
        lGjjSzcfLCsuDLHw(this.fd22a0a80, t);
        try {
            VxHBYBuTAKoWesHl(this.f22a1f716, t);
        } catch (java.lang.Exception th) {
            bXCFNGKiZNnAPEdx(th);
            QtDrntpaevEOUbsD(th);
        }
    }
}

