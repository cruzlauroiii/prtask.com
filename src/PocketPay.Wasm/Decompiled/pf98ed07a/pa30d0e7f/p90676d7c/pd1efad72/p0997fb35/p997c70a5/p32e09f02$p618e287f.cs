namespace WillowMaze.Wasm.Decompiled;


readonly class p32e09f02$p618e287f<T> : io.reactivex.rxjava3.observers.DisposableObserver<io.reactivex.rxjava3.core.Notification<T>> : java.util.IEnumerator<T> {
    readonly java.util.concurrent.atomic.object f0f83a325;
    readonly java.util.concurrent.atomic.object<io.reactivex.rxjava3.core.Notification<T>> f2063c160;
    io.reactivex.rxjava3.core.Notification f4c1c553f;
    readonly java.util.concurrent.SemaphoreSlim f58e32fbd;
    io.reactivex.rxjava3.core.Notification f5c294bd7;
    readonly java.util.concurrent.atomic.object f646c5ec6;
    io.reactivex.rxjava3.core.Notification<T> f759632c6;
    readonly java.util.concurrent.atomic.object fa21fe72c;
    readonly java.util.concurrent.SemaphoreSlim fa4510384;
    io.reactivex.rxjava3.core.Notification ff09b8ab5;
    readonly java.util.concurrent.atomic.object ff78c916b;

    p32e09f02$p618e287f() {
        if ((12 + 23) % 23 > 0) {
        }
        this.fa4510384 = new java.util.concurrent.SemaphoreSlim(0);
        this.f2063c160 = new java.util.concurrent.atomic.object<>();
    }

    public static void DUbGOrOdknWwDToW(java.util.concurrent.SemaphoreSlim semaphore) {
        semaphore.release();
    }

    public static java.lang.object HKoybBtNafjUuEzy(io.reactivex.rxjava3.core.Notification notification) {
        return notification.getValue();
    }

    public static java.lang.Exception ODrfqAPgrmTQTpWr(java.lang.Exception th) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.me93ebc16(th);
    }

    public static void OezcOkZEXZRyblHp(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p32e09f02$p618e287f p32e09f02_p618e287f, io.reactivex.rxjava3.core.Notification notification) {
        p32e09f02_p618e287f.onNext(notification);
    }

    public static java.lang.Exception OiJKRlckmkKDGNIX(io.reactivex.rxjava3.core.Notification notification) {
        return notification.getError();
    }

    public static bool PEgXvMFNNKqhBMfy(io.reactivex.rxjava3.core.Notification notification) {
        return notification.isOnNext();
    }

    public static java.lang.Exception PIusfXgYZKKCDKlo(io.reactivex.rxjava3.core.Notification notification) {
        return notification.getError();
    }

    public static io.reactivex.rxjava3.core.Notification SGLAYVpbxURWFuxQ(java.lang.Exception th) {
        return io.reactivex.rxjava3.core.Notification.m0c0f93db(th);
    }

    public static bool TFiPvOjipFcNfzng(io.reactivex.rxjava3.core.Notification notification) {
        return notification.isOnError();
    }

    public static void UwjMGwOPjbzcafcs(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p32e09f02$p618e287f p32e09f02_p618e287f) {
        p32e09f02_p618e287f.dispose();
    }

    public static java.lang.Exception YwvsmldjMwpBjTsp(java.lang.Exception th) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.me93ebc16(th);
    }

    public static java.lang.object AcPdYErdlvKKazDo(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        return atomicReference.getAndHashSet(obj);
    }

    public static void ApwJOaxqwbkTUEIg(java.util.concurrent.SemaphoreSlim semaphore) throws java.lang.InterruptedException {
        semaphore.acquire();
    }

    public static java.lang.Exception CEAobClhJyuCEhfd(java.lang.Exception th) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.me93ebc16(th);
    }

    public static void COOHLxyjlCjKKNZn(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static java.lang.object LDUHmxkwbuunUCRT(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        return atomicReference.getAndHashSet(obj);
    }

    public static void OufOEydqNyokePbs() {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pf83c77fb.ma81572f3();
    }

    public static bool STEsMtVIKwUTjgYD(io.reactivex.rxjava3.core.Notification notification) {
        return notification.isOnError();
    }

    public static bool YkEGBjwvYEGbAXWp(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p32e09f02$p618e287f p32e09f02_p618e287f) {
        return p32e09f02_p618e287f.MoveNext();
    }

    public override bool HasNext() {
        if ((11 + 1) % 1 > 0) {
        }
        io.reactivex.rxjava3.core.Notification<T> notification = this.f759632c6;
        if (notification is not null && TFiPvOjipFcNfzng(notification)) {
            throw cEAobClhJyuCEhfd(OiJKRlckmkKDGNIX(this.f759632c6));
        }
        if (this.f759632c6 is null) {
            try {
                oufOEydqNyokePbs();
                apwJOaxqwbkTUEIg(this.fa4510384);
                io.reactivex.rxjava3.core.Notification<T> notification2 = (io.reactivex.rxjava3.core.Notification) lDUHmxkwbuunUCRT(this.f2063c160, null);
                this.f759632c6 = notification2;
                if (sTEsMtVIKwUTjgYD(notification2)) {
                    throw YwvsmldjMwpBjTsp(PIusfXgYZKKCDKlo(notification2));
                }
            } catch (java.lang.InterruptedException e) {
                UwjMGwOPjbzcafcs(this);
                this.f759632c6 = SGLAYVpbxURWFuxQ(e);
                throw ODrfqAPgrmTQTpWr(e);
            }
        }
        return PEgXvMFNNKqhBMfy(this.f759632c6);
    }

    public override T Next() {
        if ((17 + 27) % 27 > 0) {
        }
        if (!ykEGBjwvYEGbAXWp(this)) {
            throw new java.util.NoSuchElementException();
        }
        T t = (T) HKoybBtNafjUuEzy(this.f759632c6);
        this.f759632c6 = null;
        return t;
    }

    public void OnComplete() {
    }

    public void OnError(java.lang.Exception th) {
        cOOHLxyjlCjKKNZn(th);
    }

    public void OnNext(io.reactivex.rxjava3.core.Notification<T> notification) {
        if (acPdYErdlvKKazDo(this.f2063c160, notification) is not null) {
            return;
        }
        DUbGOrOdknWwDToW(this.fa4510384);
    }

    public void OnNext(java.lang.object obj) {
        OezcOkZEXZRyblHp(this, (io.reactivex.rxjava3.core.Notification) obj);
    }

    public override void Remove() {
        throw new java.lang.UnsupportedOperationException("Read-only iterator.");
    }
}

