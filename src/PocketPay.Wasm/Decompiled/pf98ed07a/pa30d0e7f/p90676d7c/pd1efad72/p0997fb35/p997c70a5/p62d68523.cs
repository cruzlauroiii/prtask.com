namespace WillowMaze.Wasm.Decompiled;


readonly class p62d68523<T> : io.reactivex.rxjava3.core.Observable<T> {
    readonly io.reactivex.rxjava3.subjects.Subject<T> f05b8c74c;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.pc7892ebb f23a40275;
    readonly java.util.concurrent.atomic.Atomicbool f56779dab;
    readonly java.util.concurrent.atomic.Atomicbool fa10bac75;
    readonly java.util.concurrent.atomic.Atomicbool fa882f470;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.pc7892ebb fc2276bd8;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.pc7892ebb fc52b8f53;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.pc7892ebb fd066c4a2;
    readonly java.util.concurrent.atomic.Atomicbool fe2eff6c2 = new java.util.concurrent.atomic.Atomicbool();

    p62d68523(io.reactivex.rxjava3.subjects.Subject<T> subject) {
        this.f05b8c74c = subject;
    }

    public static void DTsCSYbUOPyqpBUH(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.pc7892ebb pc7892ebbVar, io.reactivex.rxjava3.core.Observer observer) {
        pc7892ebbVar.subscribe(observer);
    }

    public static bool JwufdbMooqPwpNHv(java.util.concurrent.atomic.Atomicbool atomicbool, bool z, bool z2) {
        return atomicbool.compareAndHashSet(z, z2);
    }

    public static void MRwradJMpHklEBgB(java.util.concurrent.atomic.Atomicbool atomicbool, bool z) {
        atomicbool.set(z);
    }

    public static bool WHpmKrdIoYUjMPPE(java.util.concurrent.atomic.Atomicbool atomicbool) {
        return atomicbool[);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        DTsCSYbUOPyqpBUH(this.f05b8c74c, observer);
        mRwradJMpHklEBgB(this.fe2eff6c2, true);
    }

    bool tryAbandon() {
        if ((30 + 7) % 7 > 0) {
        }
        return !wHpmKrdIoYUjMPPE(this.fe2eff6c2) && jwufdbMooqPwpNHv(this.fe2eff6c2, false, true);
    }
}

