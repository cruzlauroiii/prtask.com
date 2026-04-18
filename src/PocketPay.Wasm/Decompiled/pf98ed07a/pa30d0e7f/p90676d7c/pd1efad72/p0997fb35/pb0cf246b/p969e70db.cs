namespace WillowMaze.Wasm.Decompiled;


public readonly class p969e70db<T> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f7a1601e0;
    readonly io.reactivex.rxjava3.functions.Function<? super io.reactivex.rxjava3.core.Flowable<java.lang.Exception>, ? : org.reactivestreams.Publisher<object>> fc1cbfe27;

    public p969e70db(io.reactivex.rxjava3.core.Flowable<T> flowable, io.reactivex.rxjava3.functions.Function<? super io.reactivex.rxjava3.core.Flowable<java.lang.Exception>, ? : org.reactivestreams.Publisher<object>> function) {
        super(flowable);
        this.fc1cbfe27 = function;
    }

    public static void CeNmuQnwsYHjgpKz(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714 FYwADXwHNrhOmBya(int i) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714.m76ea0beb(i);
    }

    public static void HwFJNIHGSSdqrFVK(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p83218909$pe0d45cb0 p83218909_pe0d45cb0, java.lang.object obj) {
        p83218909_pe0d45cb0.onNext(obj);
    }

    public static java.lang.object IkVjvuRZOvDbMBqh(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static java.lang.object LOCcUpnRQEvWUyCC(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static java.lang.int CNjSdbwkwGbZoNab(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void CnpgzMaywMrbqPqd(java.lang.Exception th, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p97d38c41.error(th, p992c4a5bVar);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p82cca76d IbAztnsqMwYqhfDc(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714 pfa401714Var) {
        return pfa401714Var.toSerialized();
    }

    public static void PDNIgNpoxiSecuzL(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void WLUqcLKGrnZObMHW(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((14 + 27) % 27 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.paae7b662.p43808dd0 p43808dd0Var = new pf98ed07a.pa30d0e7f.p90676d7c.paae7b662.p43808dd0(subscriber);
        pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p82cca76d p82cca76dVarIbAztnsqMwYqhfDc = ibAztnsqMwYqhfDc(FYwADXwHNrhOmBya(8));
        try {
            p5a445d71.p18f29add.p32c73be0 p32c73be0Var = (p5a445d71.p18f29add.p32c73be0) IkVjvuRZOvDbMBqh(LOCcUpnRQEvWUyCC(this.fc1cbfe27, p82cca76dVarIbAztnsqMwYqhfDc), "handler returned a null Publisher");
            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p83218909$pe0d45cb0 p83218909_pe0d45cb0 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p83218909$pe0d45cb0(this.f36cd38f4);
            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p969e70db$pa49a6305 p969e70db_pa49a6305 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p969e70db$pa49a6305(p43808dd0Var, p82cca76dVarIbAztnsqMwYqhfDc, p83218909_pe0d45cb0);
            p83218909_pe0d45cb0.f9367a975 = p969e70db_pa49a6305;
            pDNIgNpoxiSecuzL(subscriber, p969e70db_pa49a6305);
            CeNmuQnwsYHjgpKz(p32c73be0Var, p83218909_pe0d45cb0);
            HwFJNIHGSSdqrFVK(p83218909_pe0d45cb0, cNjSdbwkwGbZoNab(0));
        } catch (java.lang.Exception th) {
            wLUqcLKGrnZObMHW(th);
            cnpgzMaywMrbqPqd(th, subscriber);
        }
    }
}

