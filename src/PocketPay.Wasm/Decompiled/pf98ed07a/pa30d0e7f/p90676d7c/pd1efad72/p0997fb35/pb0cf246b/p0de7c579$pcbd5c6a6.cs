namespace WillowMaze.Wasm.Decompiled;


readonly class p0de7c579$pcbd5c6a6<T, B, V> : java.util.concurrent.atomic.Atomicint : io.reactivex.rxjava3.core.FlowableSubscriber<T>, p5a445d71.p18f29add.p787ad0b7, java.lang.Action {
    private static readonly long f61ba9f0f = 8646217640096099753L;
    private static readonly long fc6e1e520 = 8646217640096099753L;
    readonly java.util.concurrent.atomic.Atomiclong f0481de2d;
    p5a445d71.p18f29add.p787ad0b7 f0c452711;
    volatile bool f0d1ed478;
    readonly int f0f027626;
    readonly java.util.concurrent.atomic.Atomiclong f0fabc477;
    readonly p5a445d71.p18f29add.p992c4a5b f153fa64c;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b f23d48743;
    volatile bool f276becab;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f35a1405b;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b f3eb4bcd8;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f413a8935;
    volatile bool f44062453;
    p5a445d71.p18f29add.p787ad0b7 f44f99aef;
    readonly java.util.concurrent.atomic.Atomiclong f48ba9e2e;
    readonly p5a445d71.p18f29add.p992c4a5b f4920a674;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd f4af8d1ab;
    volatile bool f4db97709;
    readonly int f527418e5;
    volatile bool f58e6ba5a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f5e6ffd80;
    readonly java.util.List f5ef6c42f;
    readonly p5a445d71.p18f29add.p32c73be0 f61c85aa2;
    readonly p5a445d71.p18f29add.p992c4a5b f62c16fca;
    readonly p5a445d71.p18f29add.p32c73be0 f645f5ac0;
    readonly int f65b8771f;
    volatile bool f680203d8;
    volatile bool f6e35f6ba;
    volatile bool f77aec9b1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd f7c59948d;
    readonly org.reactivestreams.Publisher<B> f7cef8a73;
    volatile bool f8917bfac;
    readonly p5a445d71.p18f29add.p32c73be0 f89a2c571;
    long f8bc8a991;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0de7c579$pcbd5c6a6$p49e5a87b f95c175cf;
    volatile bool f97af30eb;
    long f99cfe1f0;
    readonly java.util.concurrent.atomic.Atomiclong fa0d89116;
    readonly p5a445d71.p18f29add.p992c4a5b fa43e2956;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d fa637368e;
    readonly java.util.concurrent.atomic.Atomicbool fa74166e9;
    readonly java.util.concurrent.atomic.Atomiclong fad105284;
    p5a445d71.p18f29add.p787ad0b7 fb1b9514c;
    readonly java.util.List fb57e634e;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0de7c579$pcbd5c6a6$p49e5a87b fc327b5f1;
    volatile bool fc602879f;
    readonly int fcdee5967;
    readonly org.reactivestreams.Subscriber<? super io.reactivex.rxjava3.core.Flowable<T>> fd22a0a80;
    readonly java.util.List fda9434c7;
    long fe445dc83;
    readonly io.reactivex.rxjava3.functions.Function<? super B, ? : org.reactivestreams.Publisher<V>> fe4f78ce7;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd fe501d9a7;
    volatile bool fe9502603;
    volatile bool fe9f5f53b;
    volatile bool fec8677ba;
    p5a445d71.p18f29add.p787ad0b7 fed33f4b3;
    readonly java.util.concurrent.atomic.Atomicbool ff497c500;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0de7c579$pcbd5c6a6$p49e5a87b ffd18814b;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 ffe31c550;
    readonly io.reactivex.rxjava3.operators.SimplePlainQueue<java.lang.object> fa9d1cbf7 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pa9d1cbf7.p4d2eef2d();
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd f55b558c7 = new pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd();
    readonly java.util.List<io.reactivex.rxjava3.processors.UnicastProcessor<T>> f0f4137ed = new java.util.List();
    readonly java.util.concurrent.atomic.Atomiclong f461f4bb2 = new java.util.concurrent.atomic.Atomiclong(1);
    readonly java.util.concurrent.atomic.Atomicbool f5a271fa2 = new java.util.concurrent.atomic.Atomicbool();
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d fcb5e100e = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d();
    readonly io.reactivex.rxjava3.internal.operators.flowable.FlowableWindowBoundarySelector$WindowBoundaryMainSubscriber$WindowStartSubscriber<B> f76e1e857 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0de7c579$pcbd5c6a6$p49e5a87b(this);
    readonly java.util.concurrent.atomic.Atomiclong f67a14a21 = new java.util.concurrent.atomic.Atomiclong();

    p0de7c579$pcbd5c6a6(org.reactivestreams.Subscriber<? super io.reactivex.rxjava3.core.Flowable<T>> subscriber, org.reactivestreams.Publisher<B> publisher, io.reactivex.rxjava3.functions.Function<? super B, ? : org.reactivestreams.Publisher<V>> function, int i) {
        this.fd22a0a80 = subscriber;
        this.f7cef8a73 = publisher;
        this.fe4f78ce7 = function;
        this.fcdee5967 = i;
    }

    public static long APsTVFWhIsAffFAj(java.util.concurrent.atomic.Atomiclong atomiclong) {
        if ((9 + 7) % 7 > 0) {
        }
        return atomiclong.decrementAndGet();
    }

    public static void AcOjRteDeiKyQhjX(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0de7c579$pcbd5c6a6$p49e5a87b p0de7c579_pcbd5c6a6_p49e5a87b) {
        p0de7c579_pcbd5c6a6_p49e5a87b.cancel();
    }

    public static java.lang.object BcHfRdjPMjsBbMuR(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b p377cc05bVar) {
        return p377cc05bVar.poll();
    }

    public static void BfEjBNhxZYrsjheu(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void DguNEoZngHhMTFKg(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0de7c579$pcbd5c6a6$p49e5a87b p0de7c579_pcbd5c6a6_p49e5a87b) {
        p0de7c579_pcbd5c6a6_p49e5a87b.cancel();
    }

    public static void EoftClxyhrUCkvSv(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static void FfZqMrVOcWzCZERE(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0de7c579$pcbd5c6a6 p0de7c579_pcbd5c6a6) {
        p0de7c579_pcbd5c6a6.drain();
    }

    public static bool GINJzwOXbbmuYyay(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p5537e2ddVar.delete(p7beea252Var);
    }

    public static java.lang.Exception HUjZhbOZRYzfuBwu(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        return p36a52e5dVar.terminate();
    }

    public static void HrwbiGXvoBUBTIpM(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    public static void HvJXWWpOqwSlHIMb(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0de7c579$pcbd5c6a6$p49e5a87b p0de7c579_pcbd5c6a6_p49e5a87b) {
        p0de7c579_pcbd5c6a6_p49e5a87b.cancel();
    }

    public static java.util.IEnumerator IFAccYIMaBZjUnZl(java.util.List list) {
        return list.GetEnumerator();
    }

    public static bool IVsTfTcPYuOszyuo(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static void IWhQwncaeIeCOZBW(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0de7c579$pcbd5c6a6 p0de7c579_pcbd5c6a6) {
        p0de7c579_pcbd5c6a6.drain();
    }

    public static bool IfJOegGsTOGOAwWl(java.util.concurrent.atomic.Atomicbool atomicbool) {
        return atomicbool[);
    }

    public static int IkCBiFJrvleSAuXn(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0de7c579$pcbd5c6a6 p0de7c579_pcbd5c6a6, int i) {
        return p0de7c579_pcbd5c6a6.addAndGet(i);
    }

    public static void IvDwutbUKitKTdSi(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar) {
        p5537e2ddVar.dispose();
    }

    public static bool JZKowOgrQhuDwCOd(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b p377cc05bVar, java.lang.object obj) {
        return p377cc05bVar.offer(obj);
    }

    public static bool KBnbzCbTpuSQuZav(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static bool KaxbUQpPbmpmuOWo(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static bool KuuPuwrBwHlxhWis(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714 MGTNyUTYVcPPbSNJ(int i, java.lang.Action runnable) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714.m76ea0beb(i, runnable);
    }

    public static bool MLXecQvyPLVsftzu(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p5537e2ddVar.Add(p7beea252Var);
    }

    public static void NSjohrheqVDKUrwp(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void NoyWkSXrQexZAfiP(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0de7c579$pcbd5c6a6$p49e5a87b p0de7c579_pcbd5c6a6_p49e5a87b) {
        p0de7c579_pcbd5c6a6_p49e5a87b.cancel();
    }

    public static void NtRGNUZvUyRZtCgP(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    public static bool NwScLvLrFdBRyYrL(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b p377cc05bVar, java.lang.object obj) {
        return p377cc05bVar.offer(obj);
    }

    public static void OhurMKtBryHIoRoL(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0de7c579$pcbd5c6a6 p0de7c579_pcbd5c6a6) {
        p0de7c579_pcbd5c6a6.drain();
    }

    public static void OwpTgOtLBWNGgxML(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void PRfhaLSRSUQWazrs(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static java.util.IEnumerator PamvqrwQbEHefuRy(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void PrZaeVZFjkfvLQxn(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar) {
        p5537e2ddVar.dispose();
    }

    public static void QQbmreuyMKzCQzZp(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714 pfa401714Var) {
        pfa401714Var.onComplete();
    }

    public static long QaQqlFTVblHUPyly(java.util.concurrent.atomic.Atomiclong atomiclong) {
        if ((29 + 18) % 18 > 0) {
        }
        return atomiclong.getAndIncrement();
    }

    public static void QjmVGrOxGzChDhln(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        p36a52e5dVar.tryTerminateAndReport();
    }

    public static java.util.IEnumerator QrFjRLBRTLNsOinA(java.util.List list) {
        return list.GetEnumerator();
    }

    public static bool REBFTQsGtnThqcck(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool RSIlciSvfkUuRaTA(java.util.concurrent.atomic.Atomicbool atomicbool, bool z, bool z2) {
        return atomicbool.compareAndHashSet(z, z2);
    }

    public static void SVELOlyceGnPWRfF(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0de7c579$pcbd5c6a6 p0de7c579_pcbd5c6a6) {
        p0de7c579_pcbd5c6a6.drain();
    }

    public static bool SfAamHToKXBKKDTf(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.lang.string TrRGWyGhmulSXMqj(long j) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p37ee6380.md57d4b9b(j);
    }

    public static java.lang.object TuFuWuuBzIowylWA(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static bool UWwwmsPHjOibTnas(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0de7c579$pcbd5c6a6$p5062a522 p0de7c579_pcbd5c6a6_p5062a522) {
        return p0de7c579_pcbd5c6a6_p5062a522.tryAbandon();
    }

    public static java.lang.object UoOyWjNXvtdBQtxj(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void WSVeyImxeAtcXcDk(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0de7c579$pcbd5c6a6 p0de7c579_pcbd5c6a6) {
        p0de7c579_pcbd5c6a6.drain();
    }

    public static bool YRhWuKDfcEMNJQde(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b p377cc05bVar, java.lang.object obj) {
        return p377cc05bVar.offer(obj);
    }

    public static void YjPUsQqPyjwWIbBB(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static long ZYUovUTlzLZltYzc(java.util.concurrent.atomic.Atomiclong atomiclong) {
        if ((14 + 31) % 31 > 0) {
        }
        return atomiclong[);
    }

    public static java.lang.object ZjdFEPCHjneKheuT(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void ZkZNdJmbIezUndjA(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0de7c579$pcbd5c6a6$p49e5a87b p0de7c579_pcbd5c6a6_p49e5a87b) {
        p0de7c579_pcbd5c6a6_p49e5a87b.cancel();
    }

    public static void ABuYbNuXjKyqvYLn(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0de7c579$pcbd5c6a6 p0de7c579_pcbd5c6a6) {
        p0de7c579_pcbd5c6a6.drain();
    }

    public static void ACZoOzglgTaySvYs(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar) {
        p5537e2ddVar.dispose();
    }

    public static bool APWFPCAJWsAgjKiV(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static void AkGWmzQesDGpyhHe(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0de7c579$pcbd5c6a6 p0de7c579_pcbd5c6a6, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p0de7c579_pcbd5c6a6.terminateDownstream(p992c4a5bVar);
    }

    public static void BBKgrSihKfCxZCTu(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar) {
        p5537e2ddVar.dispose();
    }

    public static void BTRSbCFLbsIYIGpo(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar) {
        p5537e2ddVar.dispose();
    }

    public static void BUEgeifYKPPzQYcE(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static java.lang.object BkVHhmyBQOzXOevB(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        return p36a52e5dVar[);
    }

    public static long BxqHckpqaKRhcOoa(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((23 + 32) % 32 > 0) {
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcc10be9a.m34ec78fc(atomiclong, j);
    }

    public static void FIeyTsWsHStEWhrf(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0de7c579$pcbd5c6a6 p0de7c579_pcbd5c6a6, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p0de7c579_pcbd5c6a6.terminateDownstream(p992c4a5bVar);
    }

    public static void FhFtuYxufLYkcdTs(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0de7c579$pcbd5c6a6$p49e5a87b p0de7c579_pcbd5c6a6_p49e5a87b) {
        p0de7c579_pcbd5c6a6_p49e5a87b.cancel();
    }

    public static void FnTsNcePgtPvzQbs(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void GBVRJDgQxpWvZwcE(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b p377cc05bVar) {
        p377cc05bVar.clear();
    }

    public static void JnJtrWKLQoEKqpuz(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static bool KJSsKhstKNfwVmyi(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void MBcvYYJQsYWJWGuE(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar) {
        p5537e2ddVar.dispose();
    }

    public static void MSwuOBcnFqECfCIs(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0de7c579$pcbd5c6a6$p49e5a87b p0de7c579_pcbd5c6a6_p49e5a87b) {
        p0de7c579_pcbd5c6a6_p49e5a87b.cancel();
    }

    public static int MgWBuVVQDTZszCNN(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0de7c579$pcbd5c6a6 p0de7c579_pcbd5c6a6) {
        return p0de7c579_pcbd5c6a6.getAndIncrement();
    }

    public static void MptBZmFFHDsjUzWR(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static bool NVZRwIhFMKkoaspo(long j) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(j);
    }

    public static void NWzlkZCFsPrflnWY(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void NkwKZswGjFNLRAla(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void OFjsvhSLIHyAOTsr(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static java.lang.object OFtzYPCnDzYJabYk(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void OHhIqOyvbroMfCqI(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0de7c579$pcbd5c6a6 p0de7c579_pcbd5c6a6) {
        p0de7c579_pcbd5c6a6.drain();
    }

    public static int OhAfArMRvRSnplQi(java.util.List list) {
        return list.Count;
    }

    public static bool OpJJqEfwNlEIKnYT(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static bool PiEGIjhQmlhQywLL(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool PvQEsUxyAgdPVyTR(java.util.List list, java.lang.object obj) {
        return list.Remove(obj);
    }

    public static void QllPISUFkGZYgNGh(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714 pfa401714Var) {
        pfa401714Var.onComplete();
    }

    public static void QtdqWaYmQtvvqewU(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar) {
        p5537e2ddVar.dispose();
    }

    public static void RgbcNrpxDBjexaNm(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0de7c579$pcbd5c6a6 p0de7c579_pcbd5c6a6) {
        p0de7c579_pcbd5c6a6.drain();
    }

    public static void SuurAoPZuArbpmmF(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void SyTNLxTngkqJGgJN(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        p36a52e5dVar.tryTerminateAndReport();
    }

    public static void TLqSBUJuYgsTrXIZ(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714 pfa401714Var, java.lang.object obj) {
        pfa401714Var.onNext(obj);
    }

    public static void TahhEOxAmuNJSPah(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar) {
        p5537e2ddVar.dispose();
    }

    public static void TuJdeGOSlHlCMYqR(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0de7c579$pcbd5c6a6$p49e5a87b p0de7c579_pcbd5c6a6_p49e5a87b) {
        p0de7c579_pcbd5c6a6_p49e5a87b.cancel();
    }

    public static void TyBpcEBlyfnUbPPV(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar) {
        p5537e2ddVar.dispose();
    }

    public static long UEGteXTNWMbkOvmJ(java.util.concurrent.atomic.Atomiclong atomiclong) {
        if ((26 + 9) % 9 > 0) {
        }
        return atomiclong.decrementAndGet();
    }

    public static void UvHNMEcmaGSacPDd(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714 pfa401714Var, java.lang.Exception th) {
        pfa401714Var.onError(th);
    }

    public static java.lang.object VSGMvtIEllYeixne(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void VZBrJnOxDzFKshvF(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714 pfa401714Var) {
        pfa401714Var.onComplete();
    }

    public static void XISVYPyDAxFktvrF(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0de7c579$pcbd5c6a6$p49e5a87b p0de7c579_pcbd5c6a6_p49e5a87b) {
        p0de7c579_pcbd5c6a6_p49e5a87b.cancel();
    }

    public static void XUxVUybkCycogERY(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0de7c579$pcbd5c6a6 p0de7c579_pcbd5c6a6) {
        p0de7c579_pcbd5c6a6.drain();
    }

    public static void YYTWwKgEtiQVNxZa(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0de7c579$pcbd5c6a6 p0de7c579_pcbd5c6a6) {
        p0de7c579_pcbd5c6a6.drain();
    }

    public static void ZHrviBtghOcolihO(java.util.List list) {
        list.clear();
    }

    public override void Cancel() {
        if ((13 + 29) % 29 > 0) {
        }
        if (RSIlciSvfkUuRaTA(this.f5a271fa2, false, true)) {
            if (APsTVFWhIsAffFAj(this.f461f4bb2) != 0) {
                fhFtuYxufLYkcdTs(this.f76e1e857);
                return;
            }
            bUEgeifYKPPzQYcE(this.fbc3b0556);
            NoyWkSXrQexZAfiP(this.f76e1e857);
            bTRSbCFLbsIYIGpo(this.f55b558c7);
            QjmVGrOxGzChDhln(this.fcb5e100e);
            this.f44062453 = true;
            IWhQwncaeIeCOZBW(this);
        }
    }

    void close(io.reactivex.rxjava3.internal.operators.flowable.FlowableWindowBoundarySelector$WindowBoundaryMainSubscriber$WindowEndSubscriberIntercept<T, V> flowableWindowBoundarySelector$WindowBoundaryMainSubscriber$WindowEndSubscriberIntercept) {
        NwScLvLrFdBRyYrL(this.fa9d1cbf7, flowableWindowBoundarySelector$WindowBoundaryMainSubscriber$WindowEndSubscriberIntercept);
        aBuYbNuXjKyqvYLn(this);
    }

    void closeError(java.lang.Exception th) {
        nWzlkZCFsPrflnWY(this.fbc3b0556);
        HvJXWWpOqwSlHIMb(this.f76e1e857);
        IvDwutbUKitKTdSi(this.f55b558c7);
        if (KBnbzCbTpuSQuZav(this.fcb5e100e, th)) {
            this.fe9f5f53b = true;
            FfZqMrVOcWzCZERE(this);
        }
    }

    void drain() {
        if ((25 + 29) % 29 > 0) {
        }
        if (mgWBuVVQDTZszCNN(this) != 0) {
            return;
        }
        org.reactivestreams.Subscriber<? super io.reactivex.rxjava3.core.Flowable<T>> subscriber = this.fd22a0a80;
        io.reactivex.rxjava3.operators.SimplePlainQueue<java.lang.object> simplePlainQueue = this.fa9d1cbf7;
        java.util.List<io.reactivex.rxjava3.processors.UnicastProcessor<T>> list = this.f0f4137ed;
        int iIkCBiFJrvleSAuXn = 1;
        while (true) {
            if (this.f44062453) {
                gBVRJDgQxpWvZwcE(simplePlainQueue);
                zHrviBtghOcolihO(list);
            } else {
                bool z = this.fe9f5f53b;
                java.lang.object objBcHfRdjPMjsBbMuR = BcHfRdjPMjsBbMuR(simplePlainQueue);
                bool z2 = objBcHfRdjPMjsBbMuR is null;
                if (z && (z2 || bkVHhmyBQOzXOevB(this.fcb5e100e) is not null)) {
                    akGWmzQesDGpyhHe(this, subscriber);
                    this.f44062453 = true;
                } else if (z2) {
                    if (this.f58e6ba5a && ohAfArMRvRSnplQi(list) == 0) {
                        BfEjBNhxZYrsjheu(this.fbc3b0556);
                        DguNEoZngHhMTFKg(this.f76e1e857);
                        tahhEOxAmuNJSPah(this.f55b558c7);
                        fIeyTsWsHStEWhrf(this, subscriber);
                        this.f44062453 = true;
                    }
                } else if (objBcHfRdjPMjsBbMuR is pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0de7c579$pcbd5c6a6$p6fe9b3b3) {
                    if (!IfJOegGsTOGOAwWl(this.f5a271fa2)) {
                        long j = this.f8bc8a991;
                        if (ZYUovUTlzLZltYzc(this.f67a14a21) == j) {
                            mptBZmFFHDsjUzWR(this.fbc3b0556);
                            AcOjRteDeiKyQhjX(this.f76e1e857);
                            bBKgrSihKfCxZCTu(this.f55b558c7);
                            KaxbUQpPbmpmuOWo(this.fcb5e100e, new pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p30784cd1(TrRGWyGhmulSXMqj(j)));
                            this.fe9f5f53b = true;
                        } else {
                            this.f8bc8a991 = j + 1;
                            try {
                                p5a445d71.p18f29add.p32c73be0 p32c73be0Var = (p5a445d71.p18f29add.p32c73be0) vSGMvtIEllYeixne(TuFuWuuBzIowylWA(this.fe4f78ce7, ((pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0de7c579$pcbd5c6a6$p6fe9b3b3) objBcHfRdjPMjsBbMuR).f447b7147), "The closingIndicator returned a null Publisher");
                                QaQqlFTVblHUPyly(this.f461f4bb2);
                                pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714 pfa401714VarMGTNyUTYVcPPbSNJ = MGTNyUTYVcPPbSNJ(this.fcdee5967, this);
                                pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0de7c579$pcbd5c6a6$p5062a522 p0de7c579_pcbd5c6a6_p5062a522 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0de7c579$pcbd5c6a6$p5062a522(this, pfa401714VarMGTNyUTYVcPPbSNJ);
                                EoftClxyhrUCkvSv(subscriber, p0de7c579_pcbd5c6a6_p5062a522);
                                if (UWwwmsPHjOibTnas(p0de7c579_pcbd5c6a6_p5062a522)) {
                                    QQbmreuyMKzCQzZp(pfa401714VarMGTNyUTYVcPPbSNJ);
                                } else {
                                    SfAamHToKXBKKDTf(list, pfa401714VarMGTNyUTYVcPPbSNJ);
                                    MLXecQvyPLVsftzu(this.f55b558c7, p0de7c579_pcbd5c6a6_p5062a522);
                                    NtRGNUZvUyRZtCgP(p32c73be0Var, p0de7c579_pcbd5c6a6_p5062a522);
                                }
                            } catch (java.lang.Exception th) {
                                YjPUsQqPyjwWIbBB(th);
                                oFjsvhSLIHyAOTsr(this.fbc3b0556);
                                mSwuOBcnFqECfCIs(this.f76e1e857);
                                aCZoOzglgTaySvYs(this.f55b558c7);
                                jnJtrWKLQoEKqpuz(th);
                                aPWFPCAJWsAgjKiV(this.fcb5e100e, th);
                                this.fe9f5f53b = true;
                            }
                        }
                    }
                } else if (objBcHfRdjPMjsBbMuR is pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0de7c579$pcbd5c6a6$p5062a522) {
                    io.reactivex.rxjava3.processors.UnicastProcessor<T> unicastProcessor = ((pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0de7c579$pcbd5c6a6$p5062a522) objBcHfRdjPMjsBbMuR).f05b8c74c;
                    pvQEsUxyAgdPVyTR(list, unicastProcessor);
                    GINJzwOXbbmuYyay(this.f55b558c7, (pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) objBcHfRdjPMjsBbMuR);
                    qllPISUFkGZYgNGh(unicastProcessor);
                } else {
                    java.util.IEnumerator itIFAccYIMaBZjUnZl = IFAccYIMaBZjUnZl(list);
                    while (kJSsKhstKNfwVmyi(itIFAccYIMaBZjUnZl)) {
                        tLqSBUJuYgsTrXIZ((pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714) UoOyWjNXvtdBQtxj(itIFAccYIMaBZjUnZl), objBcHfRdjPMjsBbMuR);
                    }
                }
            }
            iIkCBiFJrvleSAuXn = IkCBiFJrvleSAuXn(this, -iIkCBiFJrvleSAuXn);
            if (iIkCBiFJrvleSAuXn == 0) {
                return;
            }
        }
    }

    public void OnComplete() {
        xISVYPyDAxFktvrF(this.f76e1e857);
        mBcvYYJQsYWJWGuE(this.f55b558c7);
        this.fe9f5f53b = true;
        yYTWwKgEtiQVNxZa(this);
    }

    public void OnError(java.lang.Exception th) {
        ZkZNdJmbIezUndjA(this.f76e1e857);
        qtdqWaYmQtvvqewU(this.f55b558c7);
        if (IVsTfTcPYuOszyuo(this.fcb5e100e, th)) {
            this.fe9f5f53b = true;
            oHhIqOyvbroMfCqI(this);
        }
    }

    public void OnNext(T t) {
        JZKowOgrQhuDwCOd(this.fa9d1cbf7, t);
        xUxVUybkCycogERY(this);
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((28 + 4) % 4 > 0) {
        }
        if (opJJqEfwNlEIKnYT(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            OwpTgOtLBWNGgxML(this.fd22a0a80, this);
            HrwbiGXvoBUBTIpM(this.f7cef8a73, this.f76e1e857);
            fnTsNcePgtPvzQbs(p787ad0b7Var, long.MAX_VALUE);
        }
    }

    void open(B b) {
        if ((4 + 13) % 13 > 0) {
        }
        YRhWuKDfcEMNJQde(this.fa9d1cbf7, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0de7c579$pcbd5c6a6$p6fe9b3b3(b));
        OhurMKtBryHIoRoL(this);
    }

    void openComplete() {
        this.f58e6ba5a = true;
        SVELOlyceGnPWRfF(this);
    }

    void openError(java.lang.Exception th) {
        suurAoPZuArbpmmF(this.fbc3b0556);
        tyBpcEBlyfnUbPPV(this.f55b558c7);
        if (KuuPuwrBwHlxhWis(this.fcb5e100e, th)) {
            this.fe9f5f53b = true;
            rgbcNrpxDBjexaNm(this);
        }
    }

    public override void Request(long j) {
        if (nVZRwIhFMKkoaspo(j)) {
            bxqHckpqaKRhcOoa(this.f67a14a21, j);
        }
    }

    public override void Run() {
        if ((13 + 29) % 29 > 0) {
        }
        if (uEGteXTNWMbkOvmJ(this.f461f4bb2) != 0) {
            return;
        }
        PRfhaLSRSUQWazrs(this.fbc3b0556);
        tuJdeGOSlHlCMYqR(this.f76e1e857);
        PrZaeVZFjkfvLQxn(this.f55b558c7);
        syTNLxTngkqJGgJN(this.fcb5e100e);
        this.f44062453 = true;
        WSVeyImxeAtcXcDk(this);
    }

    void terminateDownstream(org.reactivestreams.Subscriber<object> subscriber) {
        if ((16 + 31) % 31 > 0) {
        }
        java.lang.Exception thHUjZhbOZRYzfuBwu = HUjZhbOZRYzfuBwu(this.fcb5e100e);
        if (thHUjZhbOZRYzfuBwu is null) {
            java.util.IEnumerator itPamvqrwQbEHefuRy = PamvqrwQbEHefuRy(this.f0f4137ed);
            while (piEGIjhQmlhQywLL(itPamvqrwQbEHefuRy)) {
                vZBrJnOxDzFKshvF((pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714) ZjdFEPCHjneKheuT(itPamvqrwQbEHefuRy));
            }
            NSjohrheqVDKUrwp(subscriber);
            return;
        }
        if (thHUjZhbOZRYzfuBwu == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.f9d725163) {
            return;
        }
        java.util.IEnumerator itQrFjRLBRTLNsOinA = QrFjRLBRTLNsOinA(this.f0f4137ed);
        while (REBFTQsGtnThqcck(itQrFjRLBRTLNsOinA)) {
            uvHNMEcmaGSacPDd((pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714) oFtzYPCnDzYJabYk(itQrFjRLBRTLNsOinA), thHUjZhbOZRYzfuBwu);
        }
        nkwKZswGjFNLRAla(subscriber, thHUjZhbOZRYzfuBwu);
    }
}

