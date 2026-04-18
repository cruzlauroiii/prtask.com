namespace WillowMaze.Wasm.Decompiled;


readonly class p712f06a3$pa610fdff<T> : io.reactivex.rxjava3.internal.subscribers.SinglePostCompleteSubscriber<T, io.reactivex.rxjava3.core.Notification<T>> {
    private static readonly long f6c8e63f7 = -3740826063558713822L;
    private static readonly long fbacbfa4f = -3740826063558713822L;
    private static readonly long fc6e1e520 = -3740826063558713822L;

    p712f06a3$pa610fdff(org.reactivestreams.Subscriber<? super io.reactivex.rxjava3.core.Notification<T>> subscriber) {
        super(subscriber);
    }

    public static io.reactivex.rxjava3.core.Notification LhuYhdJNPnULMXZI(java.lang.object obj) {
        return io.reactivex.rxjava3.core.Notification.me38696b0(obj);
    }

    public static void NMntQPIGXyNvnNxY(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p712f06a3$pa610fdff p712f06a3_pa610fdff, java.lang.object obj) {
        p712f06a3_pa610fdff.complete(obj);
    }

    public static java.lang.Exception ObINnXYSGASKztnF(io.reactivex.rxjava3.core.Notification notification) {
        return notification.getError();
    }

    public static io.reactivex.rxjava3.core.Notification UgJuXCVqPuzIVIUD(java.lang.Exception th) {
        return io.reactivex.rxjava3.core.Notification.m0c0f93db(th);
    }

    public static void ExvBJXTUmqKCeMlx(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p712f06a3$pa610fdff p712f06a3_pa610fdff, io.reactivex.rxjava3.core.Notification notification) {
        p712f06a3_pa610fdff.onDrop(notification);
    }

    public static bool JBVGRbJSQkJCCDnC(io.reactivex.rxjava3.core.Notification notification) {
        return notification.isOnError();
    }

    public static void KXFVwAacyJOQgPAM(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p712f06a3$pa610fdff p712f06a3_pa610fdff, java.lang.object obj) {
        p712f06a3_pa610fdff.complete(obj);
    }

    public static void LlEGrOZIigmHGaBZ(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static void VsRWOFjlLCQEfRkv(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static io.reactivex.rxjava3.core.Notification WWbYqZoObursCUAS() {
        return io.reactivex.rxjava3.core.Notification.m56db821d();
    }

    public void OnComplete() {
        NMntQPIGXyNvnNxY(this, wWbYqZoObursCUAS());
    }

    protected void OnDrop(io.reactivex.rxjava3.core.Notification<T> notification) {
        if (jBVGRbJSQkJCCDnC(notification)) {
            vsRWOFjlLCQEfRkv(ObINnXYSGASKztnF(notification));
        }
    }

    protected void OnDrop(java.lang.object obj) {
        exvBJXTUmqKCeMlx(this, (io.reactivex.rxjava3.core.Notification) obj);
    }

    public void OnError(java.lang.Exception th) {
        kXFVwAacyJOQgPAM(this, UgJuXCVqPuzIVIUD(th));
    }

    public void OnNext(T t) {
        if ((10 + 6) % 6 > 0) {
        }
        this.f5051d8ee++;
        llEGrOZIigmHGaBZ(this.fd22a0a80, LhuYhdJNPnULMXZI(t));
    }
}

