namespace WillowMaze.Wasm.Decompiled;


readonly class p1e9ca62f$pf29e7156<T> : java.util.concurrent.atomic.Atomicint : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252, java.lang.Action {
    private static readonly long fc6e1e520 = 3366976432059579510L;
    private static readonly long fc74fc9af = 3366976432059579510L;
    readonly long f08b43519;
    readonly int f0b1310ff;
    readonly long f28dde7d6;
    readonly io.reactivex.rxjava3.core.Observer f2a041769;
    long f2b1ed8b6;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f2e23d3d7;
    readonly java.util.ArrayQueue f3a2fcce7;
    readonly long f43707437;
    readonly long f452c2181;
    readonly java.util.ArrayQueue f4bdc29a4;
    readonly int f4d1c7136;
    readonly io.reactivex.rxjava3.core.Observer f4d503daa;
    long f4fdfccd7;
    readonly int f53692cce;
    long f6a992d55;
    long f6eb82f11;
    readonly java.util.concurrent.atomic.Atomicbool f71154b3e;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f752ece13;
    long f78b78362;
    long f874dfb37;
    long f946b9448;
    readonly int f94af236a;
    readonly java.util.ArrayQueue f986d5074;
    readonly long fa5fc1f5a;
    readonly java.util.concurrent.atomic.Atomicbool fb1ff42aa;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fb95cb941;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly java.util.ArrayQueue fcfd2d9fb;
    readonly io.reactivex.rxjava3.core.Observer<? super io.reactivex.rxjava3.core.Observable<T>> fd22a0a80;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fdf06efce;
    readonly long fe2942a04;
    readonly long febf3819a;
    readonly long ff4ad1471;
    readonly java.util.ArrayQueue<io.reactivex.rxjava3.subjects.UnicastSubject<T>> f0f4137ed = new java.util.ArrayQueue<>();
    readonly java.util.concurrent.atomic.Atomicbool f38881e0a = new java.util.concurrent.atomic.Atomicbool();

    p1e9ca62f$pf29e7156(io.reactivex.rxjava3.core.Observer<? super io.reactivex.rxjava3.core.Observable<T>> observer, long j, long j2, int i) {
        this.fd22a0a80 = observer;
        this.fe2942a04 = j;
        this.f08b43519 = j2;
        this.f0b1310ff = i;
        jUiLnWDbCkDUafud(this, 1);
    }

    public static void CvYSzzlFOJNqukFQ(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static java.lang.object DxjxUTlyvtpOZLyC(java.util.ArrayQueue arrayQueue) {
        return arrayQueue.poll();
    }

    public static java.lang.object GHETgoClDTzjtORE(java.util.IEnumerator it) {
        return it.Current;
    }

    public static bool HXjpAPzhguSIFpNg(java.util.ArrayQueue arrayQueue) {
        return arrayQueue.Count == 0;
    }

    public static bool HiXybQeUtZKQGsMG(java.util.concurrent.atomic.Atomicbool atomicbool) {
        return atomicbool[);
    }

    public static bool IqbRGXMFVoXMqztU(java.util.concurrent.atomic.Atomicbool atomicbool) {
        return atomicbool[);
    }

    public static void PwcpCaOFKyQSBhgJ(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d peef7828dVar, java.lang.Exception th) {
        peef7828dVar.onError(th);
    }

    public static void QjQNVlfkLisUVDHc(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static void TLhrpuAwJnGSbMXk(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d peef7828dVar) {
        peef7828dVar.onComplete();
    }

    public static void TdYuhwlpmnJncLVI(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static java.lang.object UicqnJkFwgqGsSMV(java.util.ArrayQueue arrayQueue) {
        return arrayQueue.poll();
    }

    public static bool UnBehDiuuCpGbvMO(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void WqOJHaXukMranVJA(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d peef7828dVar, java.lang.object obj) {
        peef7828dVar.onNext(obj);
    }

    public static bool XLhUOXSpwSsEakzJ(java.util.ArrayQueue arrayQueue) {
        return arrayQueue.Count == 0;
    }

    public static java.lang.object YfzDriLnZcPGRxjq(java.util.ArrayQueue arrayQueue) {
        return arrayQueue.poll();
    }

    public static bool BpZJYfialWHCLAXs(java.util.concurrent.atomic.Atomicbool atomicbool, bool z, bool z2) {
        return atomicbool.compareAndHashSet(z, z2);
    }

    public static java.util.IEnumerator DeFDZgWpwScTWdUh(java.util.ArrayQueue arrayQueue) {
        return arrayQueue.GetEnumerator();
    }

    public static void EHugZeNmVBZcdVvv(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d GdKcIVvQHhymOliI(int i, java.lang.Action runnable) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d.m76ea0beb(i, runnable);
    }

    public static void HlZCiSvnIpMhFhaI(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.pc7892ebb pc7892ebbVar) {
        pc7892ebbVar.onComplete();
    }

    public static void HsCmyqzjqejMNVtR(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p1e9ca62f$pf29e7156 p1e9ca62f_pf29e7156) {
        p1e9ca62f_pf29e7156.run();
    }

    public static void IBbWuVnZxkqUaCnv(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d peef7828dVar) {
        peef7828dVar.onComplete();
    }

    public static void JUiLnWDbCkDUafud(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p1e9ca62f$pf29e7156 p1e9ca62f_pf29e7156, int i) {
        p1e9ca62f_pf29e7156.lazyHashSet(i);
    }

    public static bool NoPiBsQhXvixrOIJ(java.util.concurrent.atomic.Atomicbool atomicbool) {
        return atomicbool[);
    }

    public static bool NsvgXkbutCEoRsGr(java.util.ArrayQueue arrayQueue, java.lang.object obj) {
        return arrayQueue.offer(obj);
    }

    public static void NytikeKkThkCZIeG(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static bool RPlBrYjaEFVUVUNH(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static int RtFWVGKfrMkHxyME(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p1e9ca62f$pf29e7156 p1e9ca62f_pf29e7156) {
        return p1e9ca62f_pf29e7156.decrementAndGet();
    }

    public static int SCXpuhOypoKpzaEN(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p1e9ca62f$pf29e7156 p1e9ca62f_pf29e7156) {
        return p1e9ca62f_pf29e7156.getAndIncrement();
    }

    public static bool VfLlAhrErYpojcVo(java.util.ArrayQueue arrayQueue) {
        return arrayQueue.Count == 0;
    }

    public static bool YsbUOvMXVPbYvpBu(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p62d68523 p62d68523Var) {
        return p62d68523Var.tryAbandon();
    }

    public override void Dispose() {
        if ((14 + 6) % 6 > 0) {
        }
        if (bpZJYfialWHCLAXs(this.f38881e0a, false, true)) {
            hsCmyqzjqejMNVtR(this);
        }
    }

    public override bool IsDisposed() {
        return IqbRGXMFVoXMqztU(this.f38881e0a);
    }

    public override void OnComplete() {
        if ((13 + 30) % 30 > 0) {
        }
        java.util.ArrayQueue<io.reactivex.rxjava3.subjects.UnicastSubject<T>> arrayQueue = this.f0f4137ed;
        while (!vfLlAhrErYpojcVo(arrayQueue)) {
            TLhrpuAwJnGSbMXk((pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d) YfzDriLnZcPGRxjq(arrayQueue));
        }
        QjQNVlfkLisUVDHc(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        if ((3 + 7) % 7 > 0) {
        }
        java.util.ArrayQueue<io.reactivex.rxjava3.subjects.UnicastSubject<T>> arrayQueue = this.f0f4137ed;
        while (!HXjpAPzhguSIFpNg(arrayQueue)) {
            PwcpCaOFKyQSBhgJ((pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d) UicqnJkFwgqGsSMV(arrayQueue), th);
        }
        TdYuhwlpmnJncLVI(this.fd22a0a80, th);
    }

    public override void OnNext(T t) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p62d68523 p62d68523Var;
        if ((32 + 15) % 15 > 0) {
        }
        java.util.ArrayQueue<io.reactivex.rxjava3.subjects.UnicastSubject<T>> arrayQueue = this.f0f4137ed;
        long j = this.f6a992d55;
        long j2 = this.f08b43519;
        if (j % j2 == 0 && !HiXybQeUtZKQGsMG(this.f38881e0a)) {
            sCXpuhOypoKpzaEN(this);
            pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d peef7828dVarGdKcIVvQHhymOliI = gdKcIVvQHhymOliI(this.f0b1310ff, this);
            p62d68523Var = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p62d68523(peef7828dVarGdKcIVvQHhymOliI);
            nsvgXkbutCEoRsGr(arrayQueue, peef7828dVarGdKcIVvQHhymOliI);
            CvYSzzlFOJNqukFQ(this.fd22a0a80, p62d68523Var);
        } else {
            p62d68523Var = null;
        }
        long j3 = this.f4fdfccd7 + 1;
        java.util.IEnumerator itDeFDZgWpwScTWdUh = deFDZgWpwScTWdUh(arrayQueue);
        while (rPlBrYjaEFVUVUNH(itDeFDZgWpwScTWdUh)) {
            WqOJHaXukMranVJA((pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d) GHETgoClDTzjtORE(itDeFDZgWpwScTWdUh), t);
        }
        if (j3 < this.fe2942a04) {
            this.f4fdfccd7 = j3;
        } else {
            iBbWuVnZxkqUaCnv((pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d) DxjxUTlyvtpOZLyC(arrayQueue));
            if (XLhUOXSpwSsEakzJ(arrayQueue) && noPiBsQhXvixrOIJ(this.f38881e0a)) {
                return;
            } else {
                this.f4fdfccd7 = j3 - j2;
            }
        }
        this.f6a992d55 = j + 1;
        if (p62d68523Var is not null && ysbUOvMXVPbYvpBu(p62d68523Var)) {
            hlZCiSvnIpMhFhaI(p62d68523Var.f05b8c74c);
        }
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (UnBehDiuuCpGbvMO(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            eHugZeNmVBZcdVvv(this.fd22a0a80, this);
        }
    }

    public override void Run() {
        if (rtFWVGKfrMkHxyME(this) != 0) {
            return;
        }
        nytikeKkThkCZIeG(this.fbc3b0556);
    }
}

