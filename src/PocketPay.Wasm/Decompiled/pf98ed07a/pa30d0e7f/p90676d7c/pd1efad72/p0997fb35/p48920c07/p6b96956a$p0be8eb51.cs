namespace WillowMaze.Wasm.Decompiled;


abstract class p6b96956a$p0be8eb51<T> : java.util.concurrent.atomic.Atomicint : io.reactivex.rxjava3.core.FlowableSubscriber<T>, p5a445d71.p18f29add.p787ad0b7, java.lang.Action {
    private static readonly long fbb94788f = 9222303586456402150L;
    private static readonly long fc6e1e520 = 9222303586456402150L;
    readonly int f06f3cbf5;
    readonly int f11baf91b;
    p5a445d71.p18f29add.p787ad0b7 f1c400895;
    volatile bool f38881e0a;
    int f48fe8558;
    p5a445d71.p18f29add.p787ad0b7 f49a221d5;
    readonly int f4c203b76;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pb8a628fd f519a99ba;
    java.lang.Exception f56f378cd;
    int f59884f4c;
    readonly java.util.concurrent.atomic.Atomiclong f5d7941f3;
    volatile bool f6115d6fc;
    readonly java.util.concurrent.atomic.Atomiclong f67a14a21 = new java.util.concurrent.atomic.Atomiclong();
    p5a445d71.p18f29add.p787ad0b7 f68702272;
    volatile bool f6b2ded51;
    readonly io.reactivex.rxjava3.core.Scheduler$Worker f6f4480a6;
    readonly int f78e9a766;
    readonly io.reactivex.rxjava3.core.Scheduler$Worker f7d086dc1;
    p5a445d71.p18f29add.p787ad0b7 f835bac67;
    volatile bool fa064dd17;
    readonly io.reactivex.rxjava3.operators.SpscArrayQueue<T> fa9d1cbf7;
    readonly int faa9f73ee;
    volatile bool fb4315a6c;
    readonly io.reactivex.rxjava3.core.Scheduler$Worker fb61822e8;
    volatile bool fb92a6da1;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    readonly java.util.concurrent.atomic.Atomiclong fc36330be;
    readonly io.reactivex.rxjava3.core.Scheduler$Worker fc99b8070;
    java.lang.Exception fcb5e100e;
    volatile bool fd697c357;
    int ffac36f21;

    p6b96956a$p0be8eb51(int i, io.reactivex.rxjava3.operators.SpscArrayQueue<T> spscArrayQueue, io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        this.f4c203b76 = i;
        this.fa9d1cbf7 = spscArrayQueue;
        this.faa9f73ee = i - (i >> 2);
        this.fb61822e8 = scheduler$Worker;
    }

    public static void LbkkAFGSVywIsPtY(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p6b96956a$p0be8eb51 p6b96956a_p0be8eb51) {
        p6b96956a_p0be8eb51.schedule();
    }

    public static void WZJyBbufggAhKMio(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p6b96956a$p0be8eb51 p6b96956a_p0be8eb51) {
        p6b96956a_p0be8eb51.schedule();
    }

    public static long CZiQTkpCOpdDKlSC(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((12 + 28) % 28 > 0) {
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcc10be9a.m34ec78fc(atomiclong, j);
    }

    public static void EWJkRKcKqvtZhyWn(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void FVDkWJMkmgFaqEcP(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pb8a628fd pb8a628fdVar) {
        pb8a628fdVar.clear();
    }

    public static void IOTihMTRyYtjSOYM(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void JLJFwiHlTXzFVrFg(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p6b96956a$p0be8eb51 p6b96956a_p0be8eb51) {
        p6b96956a_p0be8eb51.schedule();
    }

    public static void LLbyuYUiyaiKANNi(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void MbccWOadWlBGPhmj(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p6b96956a$p0be8eb51 p6b96956a_p0be8eb51) {
        p6b96956a_p0be8eb51.schedule();
    }

    public static bool MnnBxdgGkVjYCXTK(long j) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(j);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 OopWsmyoCZJrGKUw(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker, java.lang.Action runnable) {
        return scheduler$Worker.schedule(runnable);
    }

    public static int PIaKAVyYPhuHFuSb(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p6b96956a$p0be8eb51 p6b96956a_p0be8eb51) {
        return p6b96956a_p0be8eb51.getAndIncrement();
    }

    public static void PhUEKHJpKxUJvwGZ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p6b96956a$p0be8eb51 p6b96956a_p0be8eb51, java.lang.Exception th) {
        p6b96956a_p0be8eb51.onError(th);
    }

    public static bool PxIaUWEqWJbkMRQX(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pb8a628fd pb8a628fdVar, java.lang.object obj) {
        return pb8a628fdVar.offer(obj);
    }

    public static int SwRceDAeySoHRcyA(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p6b96956a$p0be8eb51 p6b96956a_p0be8eb51) {
        return p6b96956a_p0be8eb51.getAndIncrement();
    }

    public static void ZUMyHEtaEmJlNgHS(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        scheduler$Worker.dispose();
    }

    public override readonly void Cancel() {
        if (this.f38881e0a) {
            return;
        }
        this.f38881e0a = true;
        iOTihMTRyYtjSOYM(this.fbc3b0556);
        zUMyHEtaEmJlNgHS(this.fb61822e8);
        if (swRceDAeySoHRcyA(this) != 0) {
            return;
        }
        fVDkWJMkmgFaqEcP(this.fa9d1cbf7);
    }

    public readonly void OnComplete() {
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        jLJFwiHlTXzFVrFg(this);
    }

    public readonly void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            eWJkRKcKqvtZhyWn(th);
            return;
        }
        this.fcb5e100e = th;
        this.f6b2ded51 = true;
        LbkkAFGSVywIsPtY(this);
    }

    public readonly void OnNext(T t) {
        if (this.f6b2ded51) {
            return;
        }
        if (pxIaUWEqWJbkMRQX(this.fa9d1cbf7, t)) {
            mbccWOadWlBGPhmj(this);
        } else {
            lLbyuYUiyaiKANNi(this.fbc3b0556);
            phUEKHJpKxUJvwGZ(this, new pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p30784cd1("Queue is full?!"));
        }
    }

    public override readonly void Request(long j) {
        if (mnnBxdgGkVjYCXTK(j)) {
            cZiQTkpCOpdDKlSC(this.f67a14a21, j);
            WZJyBbufggAhKMio(this);
        }
    }

    readonly void schedule() {
        if (pIaKAVyYPhuHFuSb(this) != 0) {
            return;
        }
        oopWsmyoCZJrGKUw(this.fb61822e8, this);
    }
}

