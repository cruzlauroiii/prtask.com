namespace WillowMaze.Wasm.Decompiled;


readonly class pafdeb810$p93060f92<TLeft, TRight, TLeftEnd, TRightEnd, R> : java.util.concurrent.atomic.Atomicint : p5a445d71.p18f29add.p787ad0b7, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$pebedbfbf {
    static readonly java.lang.int f1fdb7346 = null;
    static readonly java.lang.int f201fb973 = null;
    static readonly java.lang.int f2c69e518 = null;
    static readonly java.lang.int f33b4f61e = null;
    static readonly java.lang.int f498470c3 = null;
    static readonly java.lang.int f52a7c59f = null;
    private static readonly long f694b7f4d = -6071216598687999801L;
    static readonly java.lang.int f92e05363 = null;
    static readonly java.lang.int fba914b61 = null;
    private static readonly long fc6e1e520 = -6071216598687999801L;
    static readonly java.lang.int fcd95be98 = null;
    static readonly java.lang.int fd15e79b9 = null;
    static readonly java.lang.int fe93783c5 = null;
    readonly java.util.Dictionary f02bd3f11;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f07a4bd58;
    volatile bool f12ee22b4;
    readonly java.util.concurrent.atomic.Atomiclong f19f418c7;
    readonly java.util.Dictionary f1c1c76b6;
    readonly java.util.Dictionary f293f5816;
    volatile bool f2e348685;
    readonly java.util.concurrent.atomic.Atomicint f2ecae999;
    readonly io.reactivex.rxjava3.functions.Function<? super TRight, ? : org.reactivestreams.Publisher<TRightEnd>> f2fbf087c;
    volatile bool f38881e0a;
    readonly java.util.concurrent.atomic.Atomiclong f3d52f898;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f4109ea5d;
    readonly io.reactivex.rxjava3.functions.Function<? super TLeft, ? : org.reactivestreams.Publisher<TLeftEnd>> f412d0c77;
    int f415e97ed;
    readonly java.util.Dictionary f5a2902a9;
    int f5bbe53d7;
    readonly io.reactivex.rxjava3.functions.BiFunction<? super TLeft, ? super io.reactivex.rxjava3.core.Flowable<TRight>, ? : R> f63de7122;
    readonly java.util.Dictionary f697d5f45;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c f80ca2799;
    readonly java.util.concurrent.atomic.object f83290d4b;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c f9152ed3a;
    int f9a0aab1f;
    int f9ea0fc4d;
    readonly java.util.concurrent.atomic.Atomiclong face9663f;
    readonly java.util.concurrent.atomic.Atomicint faf6448fa;
    readonly java.util.concurrent.atomic.Atomiclong fbc4e5a4e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c fc4795d6e;
    readonly java.util.Dictionary fc89e2366;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fcdf437b5;
    readonly p5a445d71.p18f29add.p992c4a5b fd07e70a1;
    readonly org.reactivestreams.Subscriber<R> fd22a0a80;
    int fd43e76f0;
    readonly java.util.concurrent.atomic.Atomicint fd92aeb73;
    readonly p5a445d71.p18f29add.p992c4a5b fe5ae8e72;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd fec0ee0b6;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba fec8fe4db;
    int fedc10311;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba feebb1ecc;
    volatile bool ff650b088;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c ff923c4de;
    readonly java.util.Dictionary ffc396d5a;
    static readonly java.lang.int f323b32a7 = GISGDjmozagMJPJQ(1);
    static readonly java.lang.int f651af744 = EkRoYQecPZRudsHg(2);
    static readonly java.lang.int f65f10819 = LCmFfKwwNzycZjLN(3);
    static readonly java.lang.int fd902d608 = cmAWQYsLBVVXwAul(4);
    readonly java.util.concurrent.atomic.Atomiclong f67a14a21 = new java.util.concurrent.atomic.Atomiclong();
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd f52905679 = new pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd();
    readonly io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<java.lang.object> fa9d1cbf7 = new pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c(ygSDXXriuVjWqNtP());
    readonly java.util.Dictionary<java.lang.int, io.reactivex.rxjava3.processors.UnicastProcessor<TRight>> f42c5db7a = new java.util.LinkedHashDictionary();
    readonly java.util.Dictionary<java.lang.int, TRight> f27b37152 = new java.util.LinkedHashDictionary();
    readonly java.util.concurrent.atomic.object<java.lang.Exception> fcb5e100e = new java.util.concurrent.atomic.object<>();
    readonly java.util.concurrent.atomic.Atomicint fc76a5e84 = new java.util.concurrent.atomic.Atomicint(2);

    pafdeb810$p93060f92(org.reactivestreams.Subscriber<R> subscriber, io.reactivex.rxjava3.functions.Function<? super TLeft, ? : org.reactivestreams.Publisher<TLeftEnd>> function, io.reactivex.rxjava3.functions.Function<? super TRight, ? : org.reactivestreams.Publisher<TRightEnd>> function2, io.reactivex.rxjava3.functions.BiFunction<? super TLeft, ? super io.reactivex.rxjava3.core.Flowable<TRight>, ? : R> biFunction) {
        this.fd22a0a80 = subscriber;
        this.f412d0c77 = function;
        this.f2fbf087c = function2;
        this.f63de7122 = biFunction;
    }

    public static void AWOVvOFfjvpwPiUB(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static void AYkhsvmsuZBGSjDX(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static int AdhrnLrQEXFiGxIv(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.decrementAndGet();
    }

    public static void AkmvRafnXsukssWB(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714 pfa401714Var, java.lang.object obj) {
        pfa401714Var.onNext(obj);
    }

    public static bool AmdhQvzoxJPmtYaR(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p5537e2ddVar.Remove(p7beea252Var);
    }

    public static void BKCStyYtdAiQYVcK(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714 pfa401714Var, java.lang.Exception th) {
        pfa401714Var.onError(th);
    }

    public static void BfaZXpBuMJZvobrT(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$p93060f92 pafdeb810_p93060f92, java.lang.Exception th, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        pafdeb810_p93060f92.fail(th, p992c4a5bVar, pe1601823Var);
    }

    public static bool BkoHFocjUBcsGhWV(long j) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(j);
    }

    public static int CCLlAWvPdSozaWHT(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint[);
    }

    public static java.lang.object CDNrNqPPcMNQzRSK(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return p50dc035cVar.poll();
    }

    public static java.util.ICollection CHuNcgLxYWUwqCpd(java.util.Dictionary map) {
        return map.Values;
    }

    public static void CgiiWLFEUOkJLonr(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714 pfa401714Var) {
        pfa401714Var.onComplete();
    }

    public static java.lang.int DItgwaYbzpzHMYNH(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void EEYJzmGtlRSbkmvF(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static bool EYopAReRvGAjheDg(java.util.concurrent.atomic.object atomicReference, java.lang.Exception th) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.m9373b63a(atomicReference, th);
    }

    public static java.lang.int EkRoYQecPZRudsHg(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void EwEWRIvdMIDtLsym(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$p93060f92 pafdeb810_p93060f92) {
        pafdeb810_p93060f92.drain();
    }

    public static void FEAEJqkQdPPDiHvh(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$p93060f92 pafdeb810_p93060f92) {
        pafdeb810_p93060f92.cancelAll();
    }

    public static java.lang.int GISGDjmozagMJPJQ(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.object GXUwcugfKpPuNJPu(java.util.IEnumerator it) {
        return it.Current;
    }

    public static bool GkXGIFrXlAFlwKzd(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar, java.lang.object obj, java.lang.object obj2) {
        return p50dc035cVar.offer(obj, obj2);
    }

    public static bool GyAzCtdFLMTlnoTo(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.object HCTthpzmFkYcxYHH(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static java.lang.object HqjlVEbVlaKBHxRv(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static java.lang.object IKUjZsXSKQYaOsqK(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void IwSjKCQanInPyxoO(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static void JlnpCJAFJpfghIuO(java.util.Dictionary map) {
        map.clear();
    }

    public static java.lang.object JlrTDTQrbVETCqsB(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static java.util.IEnumerator KCTfcmOwNUpQYJVf(java.util.ICollection collection) {
        return collection.GetEnumerator();
    }

    public static java.lang.object KRJJUpxnmucHWsby(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static bool KmiJCDvzQDHcaAWt(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p5537e2ddVar.Add(p7beea252Var);
    }

    public static java.lang.int LCmFfKwwNzycZjLN(int i) {
        return java.lang.int.valueOf(i);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714 MbEmOekiCBqdwHBt() {
        return pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714.m76ea0beb();
    }

    public static void MqHKbRXnVXxjvZxL(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714 pfa401714Var, java.lang.object obj) {
        pfa401714Var.onNext(obj);
    }

    public static long NQTzoeWvYxPXEVGf(java.util.concurrent.atomic.Atomiclong atomiclong) {
        if ((7 + 23) % 23 > 0) {
        }
        return atomiclong[);
    }

    public static java.lang.object OKjnufUoUrsJRCBG(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return p50dc035cVar.poll();
    }

    public static int OOXblJGUsnRvDjRe(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.decrementAndGet();
    }

    public static void PbHiKVnUoNYYFXzB(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void PqQDnHHcBGJgKvzv(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$p93060f92 pafdeb810_p93060f92) {
        pafdeb810_p93060f92.cancelAll();
    }

    public static void PtFBWVzMjlTZZCBD(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$p93060f92 pafdeb810_p93060f92) {
        pafdeb810_p93060f92.drain();
    }

    public static bool PvCxsGvrFRQDFnYo(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p5537e2ddVar.delete(p7beea252Var);
    }

    public static void PvnANWZAcskHJkZO(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$p93060f92 pafdeb810_p93060f92) {
        pafdeb810_p93060f92.cancelAll();
    }

    public static long QObyzWGkSItLBNlc(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((11 + 29) % 29 > 0) {
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcc10be9a.m5051d8ee(atomiclong, j);
    }

    public static java.lang.object QjyvGnlXnJYYAjDQ(java.util.Dictionary map, java.lang.object obj) {
        return map.Remove(obj);
    }

    public static void RMFxETdWeOkhMWdK(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$p93060f92 pafdeb810_p93060f92) {
        pafdeb810_p93060f92.drain();
    }

    public static java.lang.object RuwEyfrCuymgeFRr(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba pa3d429baVar, java.lang.object obj, java.lang.object obj2) {
        return pa3d429baVar.apply(obj, obj2);
    }

    public static java.lang.object SBgUBNnTPcakUMOm(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static java.lang.object TFDkJgmnAPZvLlcs(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static java.lang.int TjKXclJnvhPfKgfw(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void UBHdOnYLInyRGqXo(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static void UcdpENBlfhnxqzhY(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static bool VBECIcikUZDsWGHf(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.object VOqlbDuZYtRJCtQI(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static java.lang.Exception VYRWnknbfFwEIDTb(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.m1459e53d(atomicReference);
    }

    public static void VxmEBijIGPLnoZrW(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$p93060f92 pafdeb810_p93060f92, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        pafdeb810_p93060f92.errorAll(p992c4a5bVar);
    }

    public static java.lang.object WIyxhpfMNGyOTUIU(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.object WOiIaQuekasGOIBU(java.util.Dictionary map, java.lang.object obj) {
        return map.Remove(obj);
    }

    public static java.util.IEnumerator WaAaPzJFEVIroCJi(java.util.ICollection collection) {
        return collection.GetEnumerator();
    }

    public static void WtvInkRpGlQZqODH(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    public static java.util.IEnumerator XGZCIFfxevNUivVU(java.util.ICollection collection) {
        return collection.GetEnumerator();
    }

    public static void XlbfpeeCifzvkjrm(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static java.lang.object ZUnvUuPUtIqmwvWl(java.util.IEnumerator it) {
        return it.Current;
    }

    public static bool ZaCZpJjwpEPygpBA(java.util.concurrent.atomic.object atomicReference, java.lang.Exception th) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.m9373b63a(atomicReference, th);
    }

    public static void ZdQkbRhtqnLDgQrt(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$p93060f92 pafdeb810_p93060f92, java.lang.Exception th, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        pafdeb810_p93060f92.fail(th, p992c4a5bVar, pe1601823Var);
    }

    public static void BCFzFyElypvEsign(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static bool CPoqIbWQNqfJqmOP(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p5537e2ddVar.Add(p7beea252Var);
    }

    public static java.lang.int CmAWQYsLBVVXwAul(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void EHciRRPyxWHyKUql(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$p93060f92 pafdeb810_p93060f92, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        pafdeb810_p93060f92.errorAll(p992c4a5bVar);
    }

    public static void ElRntxUQgxsPFjNM(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714 pfa401714Var) {
        pfa401714Var.onComplete();
    }

    public static bool EwLdcnvPbMqDueWr(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar, java.lang.object obj, java.lang.object obj2) {
        return p50dc035cVar.offer(obj, obj2);
    }

    public static void HDMBpKNjRWyACWIt(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$p93060f92 pafdeb810_p93060f92) {
        pafdeb810_p93060f92.cancelAll();
    }

    public static bool HEYbkeqEfcyFJyEK(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void HddbRblmqykfleJd(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void HtmYcHJECbvVQHfX(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        pe1601823Var.clear();
    }

    public static void IBIAtEXxkcirepyr(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$p93060f92 pafdeb810_p93060f92) {
        pafdeb810_p93060f92.cancelAll();
    }

    public static java.lang.int IYPpROZUgmGLXQvK(int i) {
        return java.lang.int.valueOf(i);
    }

    public static bool IdzKLAlfiuyUOIjZ(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void IzmpQKslQBwkuSBS(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar) {
        p5537e2ddVar.dispose();
    }

    public static java.lang.int KlCDpfpcZNWvBFND(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.util.ICollection LFIswaNwJrBwLtCt(java.util.Dictionary map) {
        return map.Values;
    }

    public static void LOZYzdlmkwViNWZG(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$p93060f92 pafdeb810_p93060f92, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        pafdeb810_p93060f92.errorAll(p992c4a5bVar);
    }

    public static void MDhFPHpSfIjxschm(java.util.Dictionary map) {
        map.clear();
    }

    public static java.util.ICollection MpEeifrdojIYiZlM(java.util.Dictionary map) {
        return map.Values;
    }

    public static void MsMbPihdvjZDaZdt(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$p93060f92 pafdeb810_p93060f92, java.lang.Exception th, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        pafdeb810_p93060f92.fail(th, p992c4a5bVar, pe1601823Var);
    }

    public static void NsbIJrGfXfgKJVkc(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$p93060f92 pafdeb810_p93060f92) {
        pafdeb810_p93060f92.drain();
    }

    public static java.util.IEnumerator OaGVuDGOvPTHBFTM(java.util.ICollection collection) {
        return collection.GetEnumerator();
    }

    public static int OdujjTjQtdFDpjEI(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$p93060f92 pafdeb810_p93060f92) {
        return pafdeb810_p93060f92.getAndIncrement();
    }

    public static bool OsrqztbdaJuPuCsP(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p5537e2ddVar.Remove(p7beea252Var);
    }

    public static void PjymhxIkzUWmkPdG(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$p93060f92 pafdeb810_p93060f92, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        pafdeb810_p93060f92.errorAll(p992c4a5bVar);
    }

    public static void QKnxHlqrQmJYQtRD(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$p93060f92 pafdeb810_p93060f92, java.lang.Exception th, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        pafdeb810_p93060f92.fail(th, p992c4a5bVar, pe1601823Var);
    }

    public static int RBqFpqsAUGBCsoqy(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$p93060f92 pafdeb810_p93060f92, int i) {
        return pafdeb810_p93060f92.addAndGet(i);
    }

    public static java.lang.object SKgLNdaeyfrFtvzu(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.util.ICollection SnAqIUfHujGljizM(java.util.Dictionary map) {
        return map.Values;
    }

    public static void SnhHnHwsaIqbZtNp(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar) {
        p5537e2ddVar.dispose();
    }

    public static long SodzbOkxyrraAbXc(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((22 + 24) % 24 > 0) {
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcc10be9a.m34ec78fc(atomiclong, j);
    }

    public static void SxMeHUFamSJhZyDU(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    public static void TwHgErhfKDcyArvE(java.util.Dictionary map) {
        map.clear();
    }

    public static bool UcOAIokZRtohPItq(java.util.concurrent.atomic.object atomicReference, java.lang.Exception th) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.m9373b63a(atomicReference, th);
    }

    public static void UyaUbYpDKJMYWViR(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static int VNYDIPnenzmsHetv(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$p93060f92 pafdeb810_p93060f92) {
        return pafdeb810_p93060f92.getAndIncrement();
    }

    public static void VziUZCCfoZmwIJPT(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$p93060f92 pafdeb810_p93060f92) {
        pafdeb810_p93060f92.drain();
    }

    public static void WIoCTBtMXbDBpdtD(java.util.Dictionary map) {
        map.clear();
    }

    public static java.lang.object YGGuSPDvZiQaHddw(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static int YgSDXXriuVjWqNtP() {
        return io.reactivex.rxjava3.core.Flowable.mcdee5967();
    }

    public static java.lang.object ZaCHBMBnIwWqqNNa(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public override void Cancel() {
        if (this.f38881e0a) {
            return;
        }
        this.f38881e0a = true;
        hDMBpKNjRWyACWIt(this);
        if (vNYDIPnenzmsHetv(this) != 0) {
            return;
        }
        uyaUbYpDKJMYWViR(this.fa9d1cbf7);
    }

    void cancelAll() {
        snhHnHwsaIqbZtNp(this.f52905679);
    }

    void drain() {
        if ((3 + 5) % 5 > 0) {
        }
        if (odujjTjQtdFDpjEI(this) == 0) {
            io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<java.lang.object> spscLinkedArrayQueue = this.fa9d1cbf7;
            org.reactivestreams.Subscriber<R> subscriber = this.fd22a0a80;
            int iRBqFpqsAUGBCsoqy = 1;
            while (!this.f38881e0a) {
                if (((java.lang.Exception) HCTthpzmFkYcxYHH(this.fcb5e100e)) is not null) {
                    IwSjKCQanInPyxoO(spscLinkedArrayQueue);
                    iBIAtEXxkcirepyr(this);
                    pjymhxIkzUWmkPdG(this, subscriber);
                    return;
                }
                bool z = CCLlAWvPdSozaWHT(this.fc76a5e84) == 0;
                java.lang.int num = (java.lang.int) CDNrNqPPcMNQzRSK(spscLinkedArrayQueue);
                bool z2 = num is null;
                if (z && z2) {
                    java.util.IEnumerator itOaGVuDGOvPTHBFTM = oaGVuDGOvPTHBFTM(snAqIUfHujGljizM(this.f42c5db7a));
                    while (hEYbkeqEfcyFJyEK(itOaGVuDGOvPTHBFTM)) {
                        CgiiWLFEUOkJLonr((pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714) IKUjZsXSKQYaOsqK(itOaGVuDGOvPTHBFTM));
                    }
                    twHgErhfKDcyArvE(this.f42c5db7a);
                    wIoCTBtMXbDBpdtD(this.f27b37152);
                    izmpQKslQBwkuSBS(this.f52905679);
                    UcdpENBlfhnxqzhY(subscriber);
                    return;
                }
                if (z2) {
                    iRBqFpqsAUGBCsoqy = rBqFpqsAUGBCsoqy(this, -iRBqFpqsAUGBCsoqy);
                    if (iRBqFpqsAUGBCsoqy == 0) {
                        return;
                    }
                } else {
                    java.lang.object objOKjnufUoUrsJRCBG = OKjnufUoUrsJRCBG(spscLinkedArrayQueue);
                    if (num == f323b32a7) {
                        pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714 pfa401714VarMbEmOekiCBqdwHBt = MbEmOekiCBqdwHBt();
                        int i = this.fedc10311;
                        this.fedc10311 = i + 1;
                        sKgLNdaeyfrFtvzu(this.f42c5db7a, klCDpfpcZNWvBFND(i), pfa401714VarMbEmOekiCBqdwHBt);
                        try {
                            p5a445d71.p18f29add.p32c73be0 p32c73be0Var = (p5a445d71.p18f29add.p32c73be0) VOqlbDuZYtRJCtQI(KRJJUpxnmucHWsby(this.f412d0c77, objOKjnufUoUrsJRCBG), "The leftEnd returned a null Publisher");
                            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$pf62ac110 pafdeb810_pf62ac110 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$pf62ac110(this, true, i);
                            cPoqIbWQNqfJqmOP(this.f52905679, pafdeb810_pf62ac110);
                            WtvInkRpGlQZqODH(p32c73be0Var, pafdeb810_pf62ac110);
                            if (((java.lang.Exception) SBgUBNnTPcakUMOm(this.fcb5e100e)) is not null) {
                                AWOVvOFfjvpwPiUB(spscLinkedArrayQueue);
                                PvnANWZAcskHJkZO(this);
                                VxmEBijIGPLnoZrW(this, subscriber);
                                return;
                            }
                            try {
                                java.lang.object objTFDkJgmnAPZvLlcs = TFDkJgmnAPZvLlcs(RuwEyfrCuymgeFRr(this.f63de7122, objOKjnufUoUrsJRCBG, pfa401714VarMbEmOekiCBqdwHBt), "The resultSelector returned a null value");
                                if (NQTzoeWvYxPXEVGf(this.f67a14a21) == 0) {
                                    msMbPihdvjZDaZdt(this, new pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p30784cd1("Could not emit value due to lack of requests"), subscriber, spscLinkedArrayQueue);
                                    return;
                                }
                                AYkhsvmsuZBGSjDX(subscriber, objTFDkJgmnAPZvLlcs);
                                QObyzWGkSItLBNlc(this.f67a14a21, 1L);
                                java.util.IEnumerator itXGZCIFfxevNUivVU = XGZCIFfxevNUivVU(CHuNcgLxYWUwqCpd(this.f27b37152));
                                while (VBECIcikUZDsWGHf(itXGZCIFfxevNUivVU)) {
                                    AkmvRafnXsukssWB(pfa401714VarMbEmOekiCBqdwHBt, WIyxhpfMNGyOTUIU(itXGZCIFfxevNUivVU));
                                }
                            } catch (java.lang.Exception th) {
                                ZdQkbRhtqnLDgQrt(this, th, subscriber, spscLinkedArrayQueue);
                                return;
                            }
                        } catch (java.lang.Exception th2) {
                            BfaZXpBuMJZvobrT(this, th2, subscriber, spscLinkedArrayQueue);
                            return;
                        }
                    } else if (num == f651af744) {
                        int i2 = this.f415e97ed;
                        this.f415e97ed = i2 + 1;
                        yGGuSPDvZiQaHddw(this.f27b37152, iYPpROZUgmGLXQvK(i2), objOKjnufUoUrsJRCBG);
                        try {
                            p5a445d71.p18f29add.p32c73be0 p32c73be0Var2 = (p5a445d71.p18f29add.p32c73be0) HqjlVEbVlaKBHxRv(zaCHBMBnIwWqqNNa(this.f2fbf087c, objOKjnufUoUrsJRCBG), "The rightEnd returned a null Publisher");
                            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$pf62ac110 pafdeb810_pf62ac1102 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$pf62ac110(this, false, i2);
                            KmiJCDvzQDHcaAWt(this.f52905679, pafdeb810_pf62ac1102);
                            sxMeHUFamSJhZyDU(p32c73be0Var2, pafdeb810_pf62ac1102);
                            if (((java.lang.Exception) JlrTDTQrbVETCqsB(this.fcb5e100e)) is not null) {
                                UBHdOnYLInyRGqXo(spscLinkedArrayQueue);
                                FEAEJqkQdPPDiHvh(this);
                                eHciRRPyxWHyKUql(this, subscriber);
                                return;
                            } else {
                                java.util.IEnumerator itKCTfcmOwNUpQYJVf = KCTfcmOwNUpQYJVf(mpEeifrdojIYiZlM(this.f42c5db7a));
                                while (GyAzCtdFLMTlnoTo(itKCTfcmOwNUpQYJVf)) {
                                    MqHKbRXnVXxjvZxL((pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714) GXUwcugfKpPuNJPu(itKCTfcmOwNUpQYJVf), objOKjnufUoUrsJRCBG);
                                }
                            }
                        } catch (java.lang.Exception th3) {
                            qKnxHlqrQmJYQtRD(this, th3, subscriber, spscLinkedArrayQueue);
                            return;
                        }
                    } else if (num != f65f10819) {
                        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$pf62ac110 pafdeb810_pf62ac1103 = (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$pf62ac110) objOKjnufUoUrsJRCBG;
                        WOiIaQuekasGOIBU(this.f27b37152, TjKXclJnvhPfKgfw(pafdeb810_pf62ac1103.f6a992d55));
                        osrqztbdaJuPuCsP(this.f52905679, pafdeb810_pf62ac1103);
                    } else {
                        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$pf62ac110 pafdeb810_pf62ac1104 = (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$pf62ac110) objOKjnufUoUrsJRCBG;
                        pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714 pfa401714Var = (pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714) QjyvGnlXnJYYAjDQ(this.f42c5db7a, DItgwaYbzpzHMYNH(pafdeb810_pf62ac1104.f6a992d55));
                        AmdhQvzoxJPmtYaR(this.f52905679, pafdeb810_pf62ac1104);
                        if (pfa401714Var is not null) {
                            elRntxUQgxsPFjNM(pfa401714Var);
                        }
                    }
                }
            }
            EEYJzmGtlRSbkmvF(spscLinkedArrayQueue);
        }
    }

    void errorAll(org.reactivestreams.Subscriber<object> subscriber) {
        if ((10 + 10) % 10 > 0) {
        }
        java.lang.Exception thVYRWnknbfFwEIDTb = VYRWnknbfFwEIDTb(this.fcb5e100e);
        java.util.IEnumerator itWaAaPzJFEVIroCJi = WaAaPzJFEVIroCJi(lFIswaNwJrBwLtCt(this.f42c5db7a));
        while (idzKLAlfiuyUOIjZ(itWaAaPzJFEVIroCJi)) {
            BKCStyYtdAiQYVcK((pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714) ZUnvUuPUtIqmwvWl(itWaAaPzJFEVIroCJi), thVYRWnknbfFwEIDTb);
        }
        JlnpCJAFJpfghIuO(this.f42c5db7a);
        mDhFPHpSfIjxschm(this.f27b37152);
        XlbfpeeCifzvkjrm(subscriber, thVYRWnknbfFwEIDTb);
    }

    void fail(java.lang.Exception th, org.reactivestreams.Subscriber<object> subscriber, io.reactivex.rxjava3.operators.SimpleQueue<object> simpleQueue) {
        bCFzFyElypvEsign(th);
        ZaCZpJjwpEPygpBA(this.fcb5e100e, th);
        htmYcHJECbvVQHfX(simpleQueue);
        PqQDnHHcBGJgKvzv(this);
        lOZYzdlmkwViNWZG(this, subscriber);
    }

    /*  JADX ERROR: JadxException in pass: BlockProcessor
        jadx.core.utils.exceptions.JadxException: Found unreachable blocks
        	at jadx.core.dex.visitors.blocks.DominatorTree.sortBlocks(DominatorTree.java:34)
        	at jadx.core.dex.visitors.blocks.DominatorTree.compute(DominatorTree.java:24)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.computeDominators(BlockProcessor.java:290)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.processBlocksTree(BlockProcessor.java:56)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.visit(BlockProcessor.java:50)
        */
    public override void InnerClose(bool r2, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$pf62ac110 r3) {
        /*
            r1 = this;
            goto L15
        L4:
            EwEWRIvdMIDtLsym(r1)
            goto Lb
        Lb:
            return
        Lc:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> Lc
            goto L2e
        L12:
            goto L18
        L15:
            goto L2f
        L18:
            goto L1c
        L1c:
            monitor-enter(r1)
            io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<java.lang.object> r0 = r1.fa9d1cbf7     // Catch: java.lang.Exception -> Lc
            if (r2 == 0) goto L24
            java.lang.int r2 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$p93060f92.f65f10819     // Catch: java.lang.Exception -> Lc
            goto L26
        L24:
            java.lang.int r2 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$p93060f92.fd902d608     // Catch: java.lang.Exception -> Lc
        L26:
            GkXGIFrXlAFlwKzd(r0, r2, r3)     // Catch: java.lang.Exception -> Lc
            monitor-exit(r1)     // Catch: java.lang.Exception -> Lc
            goto L4
        L2e:
            throw r2
        L2f:
            goto L12
        */
        throw new UnsupportedOperationException("Method not decompiled: pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$p93060f92.innerClose(bool, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$pf62ac110):void");
    }

    public override void InnerCloseError(java.lang.Exception th) {
        if (ucOAIokZRtohPItq(this.fcb5e100e, th)) {
            nsbIJrGfXfgKJVkc(this);
        } else {
            PbHiKVnUoNYYFXzB(th);
        }
    }

    public override void InnerComplete(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$p4c9f5644 pafdeb810_p4c9f5644) {
        PvCxsGvrFRQDFnYo(this.f52905679, pafdeb810_p4c9f5644);
        OOXblJGUsnRvDjRe(this.fc76a5e84);
        PtFBWVzMjlTZZCBD(this);
    }

    public override void InnerError(java.lang.Exception th) {
        if (!EYopAReRvGAjheDg(this.fcb5e100e, th)) {
            hddbRblmqykfleJd(th);
        } else {
            AdhrnLrQEXFiGxIv(this.fc76a5e84);
            vziUZCCfoZmwIJPT(this);
        }
    }

    /*  JADX ERROR: JadxException in pass: BlockProcessor
        jadx.core.utils.exceptions.JadxException: Found unreachable blocks
        	at jadx.core.dex.visitors.blocks.DominatorTree.sortBlocks(DominatorTree.java:34)
        	at jadx.core.dex.visitors.blocks.DominatorTree.compute(DominatorTree.java:24)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.computeDominators(BlockProcessor.java:290)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.processBlocksTree(BlockProcessor.java:56)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.visit(BlockProcessor.java:50)
        */
    public override void InnerValue(bool r2, java.lang.object r3) {
        /*
            r1 = this;
            goto Lb
        L4:
            RMFxETdWeOkhMWdK(r1)
            goto L12
        Lb:
            goto L1a
        Le:
            goto L1e
        L12:
            return
        L13:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L13
            goto L19
        L19:
            throw r2
        L1a:
            goto L30
        L1e:
            monitor-enter(r1)
            io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<java.lang.object> r0 = r1.fa9d1cbf7     // Catch: java.lang.Exception -> L13
            if (r2 == 0) goto L26
            java.lang.int r2 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$p93060f92.f323b32a7     // Catch: java.lang.Exception -> L13
            goto L28
        L26:
            java.lang.int r2 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$p93060f92.f651af744     // Catch: java.lang.Exception -> L13
        L28:
            ewLdcnvPbMqDueWr(r0, r2, r3)     // Catch: java.lang.Exception -> L13
            monitor-exit(r1)     // Catch: java.lang.Exception -> L13
            goto L4
        L30:
            goto Le
        */
        throw new UnsupportedOperationException("Method not decompiled: pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$p93060f92.innerValue(bool, java.lang.object):void");
    }

    public override void Request(long j) {
        if (BkoHFocjUBcsGhWV(j)) {
            sodzbOkxyrraAbXc(this.f67a14a21, j);
        }
    }
}

