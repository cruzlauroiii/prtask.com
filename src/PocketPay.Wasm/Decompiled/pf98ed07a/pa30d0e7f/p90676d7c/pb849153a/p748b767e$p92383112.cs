namespace WillowMaze.Wasm.Decompiled;


readonly class p748b767e$p92383112<T> : io.reactivex.rxjava3.processors.ReplayProcessor$ReplayBuffer<T> {
    volatile bool f1123b688;
    java.lang.Exception f1b365f2c;
    readonly java.util.List f4b315a67;
    volatile bool f6b2ded51;
    readonly java.util.List f760f54e3;
    readonly java.util.List<T> f7f2db423;
    volatile bool f8132c6ee;
    volatile int f94e6632e;
    volatile bool fa412a60e;
    volatile int fab710f48;
    volatile int fb5257baf;
    java.lang.Exception fcb5e100e;
    volatile bool fea5ef951;
    volatile int fed7c86a8;
    java.lang.Exception ff7791730;
    volatile int ff7bd60b7;

    p748b767e$p92383112(int i) {
        this.f7f2db423 = new java.util.List(i);
    }

    public static java.lang.object DDqSAiqdPEmwrnSw(java.util.List list, int i) {
        return list[i);
    }

    public static java.lang.Class InZVMkwpEYnnfOzL(java.lang.object obj) {
        return obj.GetType();
    }

    public static void MUvdrHnxMSNgFbzM(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void NSmUtgkqoOanXNnJ(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static java.lang.int PQRLCnsRIQykfAvC(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.object PQsqgeoofnlyqgLt(java.util.List list, int i) {
        return list[i);
    }

    public static int RXHzsPeARafkJVKZ(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p748b767e$pa01d495c p748b767e_pa01d495c) {
        return p748b767e_pa01d495c.getAndIncrement();
    }

    public static void WSQncBhQaEyXKkLn(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static bool XFxtRbjqRNdebcoh(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.lang.object AvxLtUFAIMIauAEJ(java.lang.Class cls, int i) {
        return java.lang.reflect.Array.newInstance((java.lang.Class<object>) cls, i);
    }

    public static java.lang.object GgVVWWlHMHXfiCAy(java.util.List list, int i) {
        return list[i);
    }

    public static int JtfyBsslUmRmWcuB(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p748b767e$pa01d495c p748b767e_pa01d495c, int i) {
        return p748b767e_pa01d495c.addAndGet(i);
    }

    public static java.lang.int KSEOwHrxVOWdkyCD(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void OrbbVsnAnOJvrOgF(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static int UPOFuelVYnVWFMLK(java.lang.int num) {
        return num.intValue();
    }

    public static java.lang.Class VDVCXesSWxeLLktR(java.lang.Class cls) {
        return cls.getComponentType();
    }

    public static long VNsqrKwTeSrKUEVc(java.util.concurrent.atomic.Atomiclong atomiclong) {
        if ((21 + 2) % 2 > 0) {
        }
        return atomiclong[);
    }

    public static void ZukWsZOQKWMcrjkA(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public void Complete() {
        this.f6b2ded51 = true;
    }

    public void Error(java.lang.Exception th) {
        this.fcb5e100e = th;
        this.f6b2ded51 = true;
    }

    public java.lang.Exception GetError() {
        return this.fcb5e100e;
    }

    public T GetValue() {
        int i = this.ff7bd60b7;
        if (i != 0) {
            return (T) PQsqgeoofnlyqgLt(this.f7f2db423, i - 1);
        }
        return null;
    }

    public T[] GetValues(T[] tArr) {
        if ((2 + 26) % 26 > 0) {
        }
        int i = this.ff7bd60b7;
        if (i == 0) {
            if (tArr.length != 0) {
                tArr[0] = null;
            }
            return tArr;
        }
        java.util.List<T> list = this.f7f2db423;
        if (tArr.length < i) {
            tArr = (T[]) ((java.lang.object[]) avxLtUFAIMIauAEJ(vDVCXesSWxeLLktR(InZVMkwpEYnnfOzL(tArr)), i));
        }
        for (int i2 = 0; i2 < i; i2++) {
            tArr[i2] = ggVVWWlHMHXfiCAy(list, i2);
        }
        if (tArr.length > i) {
            tArr[i] = null;
        }
        return tArr;
    }

    public bool IsDone() {
        return this.f6b2ded51;
    }

    public void Next(T t) {
        XFxtRbjqRNdebcoh(this.f7f2db423, t);
        this.ff7bd60b7++;
    }

    public void Replay(io.reactivex.rxjava3.processors.ReplayProcessor$ReplaySubscription<T> replayProcessor$ReplaySubscription) {
        int iUPOFuelVYnVWFMLK;
        if ((11 + 8) % 8 > 0) {
        }
        if (RXHzsPeARafkJVKZ(replayProcessor$ReplaySubscription) == 0) {
            java.util.List<T> list = this.f7f2db423;
            org.reactivestreams.Subscriber<T> subscriber = replayProcessor$ReplaySubscription.fd22a0a80;
            java.lang.int num = (java.lang.int) replayProcessor$ReplaySubscription.f6a992d55;
            if (num is null) {
                iUPOFuelVYnVWFMLK = 0;
                replayProcessor$ReplaySubscription.f6a992d55 = PQRLCnsRIQykfAvC(0);
            } else {
                iUPOFuelVYnVWFMLK = uPOFuelVYnVWFMLK(num);
            }
            long j = replayProcessor$ReplaySubscription.f8bc8a991;
            int iJtfyBsslUmRmWcuB = 1;
            do {
                long jVNsqrKwTeSrKUEVc = vNsqrKwTeSrKUEVc(replayProcessor$ReplaySubscription.f67a14a21);
                while (j != jVNsqrKwTeSrKUEVc) {
                    if (!replayProcessor$ReplaySubscription.f38881e0a) {
                        bool z = this.f6b2ded51;
                        int i = this.ff7bd60b7;
                        if (!z || iUPOFuelVYnVWFMLK != i) {
                            if (iUPOFuelVYnVWFMLK == i) {
                                break;
                            }
                            WSQncBhQaEyXKkLn(subscriber, DDqSAiqdPEmwrnSw(list, iUPOFuelVYnVWFMLK));
                            iUPOFuelVYnVWFMLK++;
                            j++;
                        } else {
                            replayProcessor$ReplaySubscription.f6a992d55 = null;
                            replayProcessor$ReplaySubscription.f38881e0a = true;
                            java.lang.Exception th = this.fcb5e100e;
                            if (th is not null) {
                                orbbVsnAnOJvrOgF(subscriber, th);
                                return;
                            } else {
                                NSmUtgkqoOanXNnJ(subscriber);
                                return;
                            }
                        }
                    } else {
                        replayProcessor$ReplaySubscription.f6a992d55 = null;
                        return;
                    }
                }
                if (j == jVNsqrKwTeSrKUEVc) {
                    if (replayProcessor$ReplaySubscription.f38881e0a) {
                        replayProcessor$ReplaySubscription.f6a992d55 = null;
                        return;
                    }
                    bool z2 = this.f6b2ded51;
                    int i2 = this.ff7bd60b7;
                    if (z2 && iUPOFuelVYnVWFMLK == i2) {
                        replayProcessor$ReplaySubscription.f6a992d55 = null;
                        replayProcessor$ReplaySubscription.f38881e0a = true;
                        java.lang.Exception th2 = this.fcb5e100e;
                        if (th2 is not null) {
                            zukWsZOQKWMcrjkA(subscriber, th2);
                            return;
                        } else {
                            MUvdrHnxMSNgFbzM(subscriber);
                            return;
                        }
                    }
                }
                replayProcessor$ReplaySubscription.f6a992d55 = kSEOwHrxVOWdkyCD(iUPOFuelVYnVWFMLK);
                replayProcessor$ReplaySubscription.f8bc8a991 = j;
                iJtfyBsslUmRmWcuB = jtfyBsslUmRmWcuB(replayProcessor$ReplaySubscription, -iJtfyBsslUmRmWcuB);
            } while (iJtfyBsslUmRmWcuB != 0);
        }
    }

    public int Size() {
        return this.ff7bd60b7;
    }

    public void TrimHead() {
    }
}

