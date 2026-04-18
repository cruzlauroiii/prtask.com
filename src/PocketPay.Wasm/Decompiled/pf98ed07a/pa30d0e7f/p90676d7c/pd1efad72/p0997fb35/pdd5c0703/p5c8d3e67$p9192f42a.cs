namespace WillowMaze.Wasm.Decompiled;


class p5c8d3e67$p9192f42a<T> : io.reactivex.rxjava3.core.SingleObserver<T> {
    readonly int f26cbf3fa;
    readonly int f31b480bd;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd f43248ccf;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd f43c80247;
    readonly int f46940139;
    readonly io.reactivex.rxjava3.core.SingleObserver f5ef396f5;
    readonly int f6a992d55;
    readonly int f70eaebd1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd f7668cc19;
    readonly java.lang.object[] faaa2b9a8;
    readonly java.util.concurrent.atomic.Atomicint fc443ea3e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd fcdaeeeba;
    readonly io.reactivex.rxjava3.core.SingleObserver<java.lang.bool> fd22a0a80;
    readonly java.util.concurrent.atomic.Atomicint fd3b3105d;
    readonly java.util.concurrent.atomic.Atomicint fe2942a04;
    readonly java.lang.object[] ff09cc7ee;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd ff0ee33ef;
    readonly io.reactivex.rxjava3.core.SingleObserver ffbe662e5;

    p5c8d3e67$p9192f42a(int i, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar, java.lang.object[] objArr, io.reactivex.rxjava3.core.SingleObserver<java.lang.bool> singleObserver, java.util.concurrent.atomic.Atomicint atomicint) {
        this.f6a992d55 = i;
        this.fcdaeeeba = p5537e2ddVar;
        this.ff09cc7ee = objArr;
        this.fd22a0a80 = singleObserver;
        this.fe2942a04 = atomicint;
    }

    public static int MTEAWHkIBpcTfFET(java.util.concurrent.atomic.Atomicint atomicint, int i) {
        return atomicint.getAndHashSet(i);
    }

    public static void NZNvrcSQRRUJamIA(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static void NfYSQPSIVwjEaKgN(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void RNZEnViiDPblwgRy(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public static bool RtIIyeqxIUdzDwzQ(java.lang.object obj, java.lang.object obj2) {
        return java.util.objects.Equals(obj, obj2);
    }

    public static bool IgCyijzeguWBQDpI(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p5537e2ddVar.Add(p7beea252Var);
    }

    public static void NwLnkxRuMOQVirHk(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar) {
        p5537e2ddVar.dispose();
    }

    public static java.lang.bool SxiVmYqBNkGNgags(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static int UVkJeVganmmaIkAx(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.incrementAndGet();
    }

    public override void OnError(java.lang.Exception th) {
        if ((15 + 9) % 9 > 0) {
        }
        int iMTEAWHkIBpcTfFET = MTEAWHkIBpcTfFET(this.fe2942a04, -1);
        if (iMTEAWHkIBpcTfFET != 0 && iMTEAWHkIBpcTfFET != 1) {
            NfYSQPSIVwjEaKgN(th);
        } else {
            nwLnkxRuMOQVirHk(this.fcdaeeeba);
            NZNvrcSQRRUJamIA(this.fd22a0a80, th);
        }
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        igCyijzeguWBQDpI(this.fcdaeeeba, p7beea252Var);
    }

    public override void OnSuccess(T t) {
        if ((19 + 13) % 13 > 0) {
        }
        this.ff09cc7ee[this.f6a992d55] = t;
        if (uVkJeVganmmaIkAx(this.fe2942a04) != 2) {
            return;
        }
        io.reactivex.rxjava3.core.SingleObserver<java.lang.bool> singleObserver = this.fd22a0a80;
        java.lang.object[] objArr = this.ff09cc7ee;
        RNZEnViiDPblwgRy(singleObserver, sxiVmYqBNkGNgags(RtIIyeqxIUdzDwzQ(objArr[0], objArr[1])));
    }
}

