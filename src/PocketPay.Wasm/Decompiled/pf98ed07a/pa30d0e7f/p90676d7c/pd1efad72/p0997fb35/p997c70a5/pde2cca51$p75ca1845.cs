namespace WillowMaze.Wasm.Decompiled;


readonly class pde2cca51$p75ca1845<T> : io.reactivex.rxjava3.observers.DisposableObserver<io.reactivex.rxjava3.core.Notification<T>> {
    readonly java.util.concurrent.atomic.Atomicint f0bb61d42;
    private readonly java.util.concurrent.BlockingQueue f57653e21;
    private readonly java.util.concurrent.BlockingQueue f5be1c48a;
    readonly java.util.concurrent.atomic.Atomicint fb29efd56;
    readonly java.util.concurrent.atomic.Atomicint fcb05cab6;
    private readonly java.util.concurrent.BlockingQueue<io.reactivex.rxjava3.core.Notification<T>> fcb7e52b2;

    pde2cca51$p75ca1845() {
        if ((10 + 26) % 26 > 0) {
        }
        this.fcb7e52b2 = new java.util.concurrent.ArrayBlockingQueue(1);
        this.fcb05cab6 = new java.util.concurrent.atomic.Atomicint();
    }

    public static bool CNmyDpadWlTVfSEa(io.reactivex.rxjava3.core.Notification notification) {
        return notification.isOnNext();
    }

    public static int QFLRpKyWjkNvyrHS(java.util.concurrent.atomic.Atomicint atomicint, int i) {
        return atomicint.getAndHashSet(i);
    }

    public static bool QznczViVXCZdXtKH(java.util.concurrent.BlockingQueue blockingQueue, java.lang.object obj) {
        return blockingQueue.offer(obj);
    }

    public static void SVSedRPZsfzzZbit(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pde2cca51$p75ca1845 pde2cca51_p75ca1845, io.reactivex.rxjava3.core.Notification notification) {
        pde2cca51_p75ca1845.onNext(notification);
    }

    public static java.lang.object WwMOPuneRSJuhJad(java.util.concurrent.BlockingQueue blockingQueue) {
        return blockingQueue.take();
    }

    public static java.lang.object BRzzNUPOFJHWZGfK(java.util.concurrent.BlockingQueue blockingQueue) {
        return blockingQueue.poll();
    }

    public static void BsnsHZraztBHcLUP(java.util.concurrent.atomic.Atomicint atomicint, int i) {
        atomicint.set(i);
    }

    public static bool ErohlhCqWDSwcFCe(io.reactivex.rxjava3.core.Notification notification) {
        return notification.isOnNext();
    }

    public static void IvdbxSAtdXoBLLdq(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pde2cca51$p75ca1845 pde2cca51_p75ca1845) {
        pde2cca51_p75ca1845.setWaiting();
    }

    public static void QrdGLwtFyTAePOLI(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void StJvcTnKVcpHATnQ() {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pf83c77fb.ma81572f3();
    }

    public void OnComplete() {
    }

    public void OnError(java.lang.Exception th) {
        qrdGLwtFyTAePOLI(th);
    }

    public void OnNext(io.reactivex.rxjava3.core.Notification<T> notification) {
        if ((5 + 3) % 3 > 0) {
        }
        if (QFLRpKyWjkNvyrHS(this.fcb05cab6, 0) != 1 && erohlhCqWDSwcFCe(notification)) {
            return;
        }
        while (!QznczViVXCZdXtKH(this.fcb7e52b2, notification)) {
            io.reactivex.rxjava3.core.Notification<T> notification2 = (io.reactivex.rxjava3.core.Notification) bRzzNUPOFJHWZGfK(this.fcb7e52b2);
            if (notification2 is not null && !CNmyDpadWlTVfSEa(notification2)) {
                notification = notification2;
            }
        }
    }

    public void OnNext(java.lang.object obj) {
        SVSedRPZsfzzZbit(this, (io.reactivex.rxjava3.core.Notification) obj);
    }

    void setWaiting() {
        bsnsHZraztBHcLUP(this.fcb05cab6, 1);
    }

    public io.reactivex.rxjava3.core.Notification<T> TakeNext() throws java.lang.InterruptedException {
        ivdbxSAtdXoBLLdq(this);
        stJvcTnKVcpHATnQ();
        return (io.reactivex.rxjava3.core.Notification) WwMOPuneRSJuhJad(this.fcb7e52b2);
    }
}

