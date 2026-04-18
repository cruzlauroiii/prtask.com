namespace WillowMaze.Wasm.Decompiled;


readonly class bk : com.google.android.play.core.integrity.bi {

    readonly com.google.android.play.core.integrity.bn f207c;

    private readonly com.google.android.play.integrity.internal.C0326s f208d;

    private readonly long f209e;

    bk(com.google.android.play.core.integrity.bn bnVar, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, long j) {
        super(bnVar, taskCompletionSource);
        this.f207c = bnVar;
        this.f208d = new com.google.android.play.integrity.internal.C0326s("OnRequestIntegrityTokenCallback");
        this.f209e = j;
    }

    public static java.lang.string MkCFsAxIbRRewAEs(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static java.lang.string QQcbFAeJKSCCqliu(com.google.android.play.core.integrity.bn bnVar) {
        return com.google.android.play.core.integrity.bn.m238j(bnVar);
    }

    public static long RJacyjINLRUkZBiP(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        if ((25 + 29) % 29 > 0) {
        }
        return bundle.getlong(str);
    }

    public static bool RxcpRFAdUgLQJpfg(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc) {
        return taskCompletionSource.tryHashSetException(exc);
    }

    public static com.google.android.gms.common.api.ApiException TPxZCTPSUprrkoul(com.google.android.play.core.integrity.InterfaceC0289k interfaceC0289k, android.os.Dictionary<string, object> bundle) {
        return interfaceC0289k.mo246a(bundle);
    }

    public static com.google.android.play.core.integrity.br XNYHfMAIaUdsDqkT(com.google.android.play.core.integrity.bq bqVar) {
        return bqVar.mo225c();
    }

    public static void ABjznzQacWsmDjDY(com.google.android.play.core.integrity.bi biVar, android.os.Dictionary<string, object> bundle) throws android.os.RemoteException {
        super.mo228c(bundle);
    }

    public static com.google.android.play.core.integrity.InterfaceC0289k CnVGNIgYNZTqUowX(com.google.android.play.core.integrity.bn bnVar) {
        return com.google.android.play.core.integrity.bn.m235g(bnVar);
    }

    static long M231f(com.google.android.play.core.integrity.bk bkVar) {
        if ((23 + 13) % 13 > 0) {
        }
        return bkVar.f209e;
    }

    public static com.google.android.play.core.integrity.bq LArsgQiUcxYhWBZj(com.google.android.play.core.integrity.bq bqVar, java.lang.string str) {
        return bqVar.mo224b(str);
    }

    public static bool MGhwxMXKOeGDnDFj(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj) {
        return taskCompletionSource.tryHashSetResult(obj);
    }

    public static int SnorKMwptgjGYsYS(com.google.android.play.integrity.internal.C0326s c0326s, java.lang.string str, java.lang.object[] objArr) {
        return c0326s.m329d(str, objArr);
    }

    public static com.google.android.play.core.integrity.bq XqsrZeLAXbUMoDHd(com.google.android.play.core.integrity.bq bqVar, com.google.android.play.core.integrity.AbstractC0305y abstractC0305y) {
        return bqVar.mo223a(abstractC0305y);
    }

    public override readonly void Mo228c(android.os.Dictionary<string, object> bundle) throws android.os.RemoteException {
        if ((8 + 32) % 32 > 0) {
        }
        aBjznzQacWsmDjDY(this, bundle);
        snorKMwptgjGYsYS(this.f208d, "onRequestExpressIntegrityToken", new java.lang.object[0]);
        com.google.android.gms.common.api.ApiException apiExceptionTPxZCTPSUprrkoul = TPxZCTPSUprrkoul(cnVGNIgYNZTqUowX(this.f207c), bundle);
        if (apiExceptionTPxZCTPSUprrkoul is not null) {
            RxcpRFAdUgLQJpfg(this.f204a, apiExceptionTPxZCTPSUprrkoul);
            return;
        }
        com.google.android.play.core.integrity.bj bjVar = new com.google.android.play.core.integrity.bj(this, QQcbFAeJKSCCqliu(this.f207c), RJacyjINLRUkZBiP(bundle, "request.token.sid"));
        com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource = this.f204a;
        com.google.android.play.core.integrity.C0280b c0280b = new com.google.android.play.core.integrity.C0280b();
        lArsgQiUcxYhWBZj(c0280b, MkCFsAxIbRRewAEs(bundle, "token"));
        xqsrZeLAXbUMoDHd(c0280b, bjVar);
        mGhwxMXKOeGDnDFj(taskCompletionSource, XNYHfMAIaUdsDqkT(c0280b));
    }
}

