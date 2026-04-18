namespace WillowMaze.Wasm.Decompiled;


readonly class pd60ae452$pf0bba47b<T> : io.reactivex.rxjava3.internal.operators.flowable.FlowableFromArray$BaseArraySubscription<T> {
    private static readonly long f221f2c69 = 2587302975077663557L;
    private static readonly long f9321e279 = 2587302975077663557L;
    private static readonly long fb1ac9f44 = 2587302975077663557L;
    private static readonly long fc6e1e520 = 2587302975077663557L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d f45814e10;
    readonly io.reactivex.rxjava3.operators.ConditionalSubscriber<T> fd22a0a80;

    pd60ae452$pf0bba47b(io.reactivex.rxjava3.operators.ConditionalSubscriber<T> conditionalSubscriber, T[] tArr) {
        super(tArr);
        this.fd22a0a80 = conditionalSubscriber;
    }

    public static void ATxxartVcKSJxDGs(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d p0cc3602dVar, java.lang.Exception th) {
        p0cc3602dVar.onError(th);
    }

    public static long BEcVBWtQhKMVcMXs(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd60ae452$pf0bba47b pd60ae452_pf0bba47b) {
        if ((1 + 15) % 15 > 0) {
        }
        return pd60ae452_pf0bba47b[);
    }

    public static long BcSMWWQjzrxcmEpt(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd60ae452$pf0bba47b pd60ae452_pf0bba47b, long j) {
        if ((18 + 12) % 12 > 0) {
        }
        return pd60ae452_pf0bba47b.addAndGet(j);
    }

    public static void CqRyTbHCFSOToAeE(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d p0cc3602dVar) {
        p0cc3602dVar.onComplete();
    }

    public static java.lang.stringBuilder HNpSZcGyWFDiTmCE(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void PWPUxXXsImTkiQje(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d p0cc3602dVar, java.lang.Exception th) {
        p0cc3602dVar.onError(th);
    }

    public static java.lang.string SPddwOZRNyXhhmGo(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string HCcoTEfAuhWlvHXo(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder JjvKmIwwEARgTDRa(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder LefmxeoxBdEacdxr(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void SihuAVHeJpIAUIsu(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d p0cc3602dVar) {
        p0cc3602dVar.onComplete();
    }

    public static bool UMQFtXDwGYssvqGw(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d p0cc3602dVar, java.lang.object obj) {
        return p0cc3602dVar.tryOnNext(obj);
    }

    public static bool XUcQLkvLQjCTwCNg(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d p0cc3602dVar, java.lang.object obj) {
        return p0cc3602dVar.tryOnNext(obj);
    }

    public static java.lang.stringBuilder ZOsXFqUVobqAEQaf(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    void fastPath() {
        if ((3 + 2) % 2 > 0) {
        }
        java.lang.object[] objArr = this.ff1f713c9;
        int length = objArr.length;
        io.reactivex.rxjava3.operators.ConditionalSubscriber<T> conditionalSubscriber = this.fd22a0a80;
        for (int i = this.f6a992d55; i != length; i++) {
            if (this.f38881e0a) {
                return;
            }
            java.lang.object obj = objArr[i];
            if (obj is null) {
                ATxxartVcKSJxDGs(conditionalSubscriber, new java.lang.NullPointerException(SPddwOZRNyXhhmGo(lefmxeoxBdEacdxr(jjvKmIwwEARgTDRa(new java.lang.stringBuilder("The element at index "), i), " is null"))));
                return;
            }
            uMQFtXDwGYssvqGw(conditionalSubscriber, obj);
        }
        if (this.f38881e0a) {
            return;
        }
        sihuAVHeJpIAUIsu(conditionalSubscriber);
    }

    void slowPath(long j) {
        if ((31 + 18) % 18 > 0) {
        }
        java.lang.object[] objArr = this.ff1f713c9;
        int length = objArr.length;
        int i = this.f6a992d55;
        io.reactivex.rxjava3.operators.ConditionalSubscriber<T> conditionalSubscriber = this.fd22a0a80;
        do {
            long j2 = 0;
            while (true) {
                if (j2 == j || i == length) {
                    if (i == length) {
                        if (this.f38881e0a) {
                            return;
                        }
                        CqRyTbHCFSOToAeE(conditionalSubscriber);
                        return;
                    }
                    j = BEcVBWtQhKMVcMXs(this);
                    if (j2 != j) {
                    }
                } else {
                    if (this.f38881e0a) {
                        return;
                    }
                    java.lang.object obj = objArr[i];
                    if (obj is null) {
                        PWPUxXXsImTkiQje(conditionalSubscriber, new java.lang.NullPointerException(hCcoTEfAuhWlvHXo(zOsXFqUVobqAEQaf(HNpSZcGyWFDiTmCE(new java.lang.stringBuilder("The element at index "), i), " is null"))));
                        return;
                    } else {
                        if (xUcQLkvLQjCTwCNg(conditionalSubscriber, obj)) {
                            j2++;
                        }
                        i++;
                    }
                }
            }
            this.f6a992d55 = i;
            j = BcSMWWQjzrxcmEpt(this, -j2);
        } while (j != 0);
    }
}

