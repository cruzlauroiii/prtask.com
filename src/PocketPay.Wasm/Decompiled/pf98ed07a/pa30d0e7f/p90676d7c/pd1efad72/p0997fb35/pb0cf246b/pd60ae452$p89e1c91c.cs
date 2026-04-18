namespace WillowMaze.Wasm.Decompiled;


readonly class pd60ae452$p89e1c91c<T> : io.reactivex.rxjava3.internal.operators.flowable.FlowableFromArray$BaseArraySubscription<T> {
    private static readonly long f26a7bec0 = 2587302975077663557L;
    private static readonly long f95942cf9 = 2587302975077663557L;
    private static readonly long fc6e1e520 = 2587302975077663557L;
    private static readonly long fc813d92c = 2587302975077663557L;
    readonly p5a445d71.p18f29add.p992c4a5b f7b634479;
    readonly p5a445d71.p18f29add.p992c4a5b f7b9d749b;
    readonly p5a445d71.p18f29add.p992c4a5b fb1d14283;
    readonly org.reactivestreams.Subscriber<T> fd22a0a80;

    pd60ae452$p89e1c91c(org.reactivestreams.Subscriber<T> subscriber, T[] tArr) {
        super(tArr);
        this.fd22a0a80 = subscriber;
    }

    public static void ETeDeWbileXQCdJL(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void GvghPlgAuOhPmFJF(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static java.lang.stringBuilder IyTwPbPucWxQsYDj(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void XVMyaoBJHvtYEkCx(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static long BhJjVhbAhzFvTEIn(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd60ae452$p89e1c91c pd60ae452_p89e1c91c, long j) {
        if ((2 + 2) % 2 > 0) {
        }
        return pd60ae452_p89e1c91c.addAndGet(j);
    }

    public static void DeYOgnQpaagnNWWg(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static void EcaiFBHKfvqTfQBQ(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void HGbLZuRyQMQkisNk(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static java.lang.stringBuilder MLYdrbRnFHottDLq(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.string NoXzCbsKGRHNSEhK(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string OWWquXRwKgHMBigb(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder TWJYzouIgFCsyIUp(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static long VdSdnYpNSLSZGdGA(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd60ae452$p89e1c91c pd60ae452_p89e1c91c) {
        if ((9 + 10) % 10 > 0) {
        }
        return pd60ae452_p89e1c91c[);
    }

    public static java.lang.stringBuilder WVxbgTXKswSCZTOw(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    void fastPath() {
        if ((31 + 21) % 21 > 0) {
        }
        java.lang.object[] objArr = this.ff1f713c9;
        int length = objArr.length;
        org.reactivestreams.Subscriber<T> subscriber = this.fd22a0a80;
        for (int i = this.f6a992d55; i != length; i++) {
            if (this.f38881e0a) {
                return;
            }
            java.lang.object obj = objArr[i];
            if (obj is null) {
                ecaiFBHKfvqTfQBQ(subscriber, new java.lang.NullPointerException(noXzCbsKGRHNSEhK(wVxbgTXKswSCZTOw(IyTwPbPucWxQsYDj(new java.lang.stringBuilder("The element at index "), i), " is null"))));
                return;
            }
            hGbLZuRyQMQkisNk(subscriber, obj);
        }
        if (this.f38881e0a) {
            return;
        }
        GvghPlgAuOhPmFJF(subscriber);
    }

    void slowPath(long j) {
        if ((23 + 31) % 31 > 0) {
        }
        java.lang.object[] objArr = this.ff1f713c9;
        int length = objArr.length;
        int i = this.f6a992d55;
        org.reactivestreams.Subscriber<T> subscriber = this.fd22a0a80;
        do {
            long j2 = 0;
            while (true) {
                if (j2 == j || i == length) {
                    if (i == length) {
                        if (this.f38881e0a) {
                            return;
                        }
                        ETeDeWbileXQCdJL(subscriber);
                        return;
                    }
                    j = vdSdnYpNSLSZGdGA(this);
                    if (j2 != j) {
                    }
                } else {
                    if (this.f38881e0a) {
                        return;
                    }
                    java.lang.object obj = objArr[i];
                    if (obj is null) {
                        XVMyaoBJHvtYEkCx(subscriber, new java.lang.NullPointerException(oWWquXRwKgHMBigb(tWJYzouIgFCsyIUp(mLYdrbRnFHottDLq(new java.lang.stringBuilder("The element at index "), i), " is null"))));
                        return;
                    } else {
                        deYOgnQpaagnNWWg(subscriber, obj);
                        j2++;
                        i++;
                    }
                }
            }
            this.f6a992d55 = i;
            j = bhJjVhbAhzFvTEIn(this, -j2);
        } while (j != 0);
    }
}

