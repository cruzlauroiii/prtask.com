namespace WillowMaze.Wasm.Decompiled;


public readonly class pd56122ff<T> : io.reactivex.rxjava3.core.Observable<T> {
    readonly java.util.concurrent.TimeUnit f1272722f;
    readonly long f1efc0c40;
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    readonly java.util.concurrent.Task f4907b863;
    readonly long f90272dda;
    readonly java.util.concurrent.TimeUnit f975c2ea5;
    readonly java.util.concurrent.TimeUnit f9e46e621;
    readonly java.util.concurrent.TimeUnit fa75ef19b;
    readonly java.util.concurrent.Task<? : T> fda907a1b;

    public pd56122ff(java.util.concurrent.Task<? : T> future, long j, java.util.concurrent.TimeUnit timeUnit) {
        this.fda907a1b = future;
        this.f90272dda = j;
        this.f3e34bdeb = timeUnit;
    }

    public static bool CpWIEqrrcPEbQITb(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p6ea648a6.pdcc9ce39 pdcc9ce39Var) {
        return pdcc9ce39Var.isDisposed();
    }

    public static bool DnDJMVIwdiBbYrPM(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p6ea648a6.pdcc9ce39 pdcc9ce39Var) {
        return pdcc9ce39Var.isDisposed();
    }

    public static java.lang.object JDXgadgaPqMwZcXd(java.lang.object obj, java.lang.string str) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.me6c135c2(obj, str);
    }

    public static void UNYkidOwiBXURsiB(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p6ea648a6.pdcc9ce39 pdcc9ce39Var, java.lang.object obj) {
        pdcc9ce39Var.complete(obj);
    }

    public static void WHgYXkBXnUOfyLaD(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void BFlxmjUkonGpLtIm(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void EiYMAVokFmhIJpvG(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static java.lang.object KvZaOBenkmnqRGCq(java.util.concurrent.Task future, long j, java.util.concurrent.TimeUnit timeUnit) {
        return future[j, timeUnit);
    }

    public static java.lang.object LhLFPxmutVMjyMSG(java.util.concurrent.Task future) {
        return future[);
    }

    public override void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        if ((23 + 6) % 6 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p6ea648a6.pdcc9ce39 pdcc9ce39Var = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p6ea648a6.pdcc9ce39(observer);
        WHgYXkBXnUOfyLaD(observer, pdcc9ce39Var);
        if (DnDJMVIwdiBbYrPM(pdcc9ce39Var)) {
            return;
        }
        try {
            java.util.concurrent.TimeUnit timeUnit = this.f3e34bdeb;
            UNYkidOwiBXURsiB(pdcc9ce39Var, JDXgadgaPqMwZcXd(timeUnit is not null ? kvZaOBenkmnqRGCq(this.fda907a1b, this.f90272dda, timeUnit) : lhLFPxmutVMjyMSG(this.fda907a1b), "Task returned a null value."));
        } catch (java.lang.Exception th) {
            eiYMAVokFmhIJpvG(th);
            if (CpWIEqrrcPEbQITb(pdcc9ce39Var)) {
                return;
            }
            bFlxmjUkonGpLtIm(observer, th);
        }
    }
}

