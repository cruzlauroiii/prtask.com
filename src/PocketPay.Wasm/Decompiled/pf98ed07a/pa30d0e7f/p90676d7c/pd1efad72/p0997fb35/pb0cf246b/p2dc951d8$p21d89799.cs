namespace WillowMaze.Wasm.Decompiled;


readonly class p2dc951d8$p21d89799<T> : java.util.concurrent.atomic.Atomicbool : io.reactivex.rxjava3.core.FlowableSubscriber<T>, p5a445d71.p18f29add.p787ad0b7 {
    private static readonly long f2b3e5543 = 1015244841293359600L;
    private static readonly long f71c1be26 = 1015244841293359600L;
    private static readonly long fc6e1e520 = 1015244841293359600L;
    readonly io.reactivex.rxjava3.core.Scheduler f40f5ccf5;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly p5a445d71.p18f29add.p992c4a5b f6660e018;
    readonly io.reactivex.rxjava3.core.Scheduler f691080d2;
    readonly p5a445d71.p18f29add.p992c4a5b f72e448e8;
    readonly p5a445d71.p18f29add.p992c4a5b f9050c232;
    readonly io.reactivex.rxjava3.core.Scheduler f97e84cb3;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    p5a445d71.p18f29add.p787ad0b7 fcec81a4c;
    readonly p5a445d71.p18f29add.p992c4a5b fced930c3;
    readonly org.reactivestreams.Subscriber<T> fd22a0a80;
    readonly io.reactivex.rxjava3.core.Scheduler ffb0efc20;

    p2dc951d8$p21d89799(org.reactivestreams.Subscriber<T> subscriber, io.reactivex.rxjava3.core.Scheduler scheduler) {
        this.fd22a0a80 = subscriber;
        this.f499f31e7 = scheduler;
    }

    public static void HQwFEPKeGbXjwdPT(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static bool IXaBDjShyIfPbZnN(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static void KUUZKhZfRMUFJGOF(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static bool QkpyuGssMeAGJvZh(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p2dc951d8$p21d89799 p2dc951d8_p21d89799) {
        return p2dc951d8_p21d89799[);
    }

    public static bool RJCCbmMbazibTcVX(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p2dc951d8$p21d89799 p2dc951d8_p21d89799, bool z, bool z2) {
        return p2dc951d8_p21d89799.compareAndHashSet(z, z2);
    }

    public static bool SpKXFgoKnSlIGgvQ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p2dc951d8$p21d89799 p2dc951d8_p21d89799) {
        return p2dc951d8_p21d89799[);
    }

    public static bool YvIDjDNFmbfkpktz(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p2dc951d8$p21d89799 p2dc951d8_p21d89799) {
        return p2dc951d8_p21d89799[);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 CdhywKnHHsYUFRtS(io.reactivex.rxjava3.core.Scheduler scheduler, java.lang.Action runnable) {
        return scheduler.scheduleDirect(runnable);
    }

    public static void EpWlZmqPXHzdouhi(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void IrfEYEpKOrTXkxfs(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void JMKWaBYsCXeVoJkQ(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void TWHXPCjSTIxQJcJj(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public override void Cancel() {
        if ((10 + 31) % 31 > 0) {
        }
        if (RJCCbmMbazibTcVX(this, false, true)) {
            cdhywKnHHsYUFRtS(this.f499f31e7, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p2dc951d8$p21d89799$p3ae3f4b3(this));
        }
    }

    public void OnComplete() {
        if (YvIDjDNFmbfkpktz(this)) {
            return;
        }
        HQwFEPKeGbXjwdPT(this.fd22a0a80);
    }

    public void OnError(java.lang.Exception th) {
        if (SpKXFgoKnSlIGgvQ(this)) {
            jMKWaBYsCXeVoJkQ(th);
        } else {
            irfEYEpKOrTXkxfs(this.fd22a0a80, th);
        }
    }

    public void OnNext(T t) {
        if (QkpyuGssMeAGJvZh(this)) {
            return;
        }
        KUUZKhZfRMUFJGOF(this.fd22a0a80, t);
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if (IXaBDjShyIfPbZnN(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            tWHXPCjSTIxQJcJj(this.fd22a0a80, this);
        }
    }

    public override void Request(long j) {
        epWlZmqPXHzdouhi(this.fbc3b0556, j);
    }
}

