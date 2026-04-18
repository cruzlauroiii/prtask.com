namespace WillowMaze.Wasm.Decompiled;


readonly class bg : com.google.android.play.core.integrity.bm {

    readonly com.google.android.play.core.integrity.StandardIntegrityManager$StandardIntegrityTokenRequest f194a;

    readonly long f195b;

    readonly long f196c;

    readonly com.google.android.gms.tasks.TaskCompletionSource f197d;

    readonly com.google.android.play.core.integrity.bn f198e;

    bg(com.google.android.play.core.integrity.bn bnVar, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, int i, com.google.android.play.core.integrity.StandardIntegrityManager$StandardIntegrityTokenRequest standardIntegrityManager$StandardIntegrityTokenRequest, long j, long j2, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource2) {
        super(bnVar, taskCompletionSource);
        this.f194a = standardIntegrityManager$StandardIntegrityTokenRequest;
        this.f195b = j;
        this.f196c = j2;
        this.f197d = taskCompletionSource2;
        this.f198e = bnVar;
    }

    public static void BDhfHisFpOHyKkZQ(com.google.android.play.core.integrity.bm bmVar, java.lang.Exception exc) {
        super.mo204a(exc);
    }

    public static bool CVlcVHFrGknvqwIC(com.google.android.play.core.integrity.bn bnVar) {
        return com.google.android.play.core.integrity.bn.m240l(bnVar);
    }

    public static android.os.Dictionary<string, object> XAJnGgaPPDKzYlsG(com.google.android.play.core.integrity.bn bnVar, com.google.android.play.core.integrity.StandardIntegrityManager$StandardIntegrityTokenRequest standardIntegrityManager$StandardIntegrityTokenRequest, long j, long j2, int i) {
        return com.google.android.play.core.integrity.bn.m232a(bnVar, standardIntegrityManager$StandardIntegrityTokenRequest, j, j2, i);
    }

    public static int EqHTPLJMSOteAbhf(com.google.android.play.integrity.internal.C0326s c0326s, java.lang.Exception th, java.lang.string str, java.lang.object[] objArr) {
        return c0326s.m328c(th, str, objArr);
    }

    public static java.util.HashSet GKUVUhNaLyOhUAyR(com.google.android.play.core.integrity.StandardIntegrityManager$StandardIntegrityTokenRequest standardIntegrityManager$StandardIntegrityTokenRequest) {
        return standardIntegrityManager$StandardIntegrityTokenRequest.verdictOptOut();
    }

    public static java.lang.long HTlBnsAVoGKYIZTj(long j) {
        return java.lang.long.valueOf(j);
    }

    public static void JlYoOKJvAGYYYKDp(com.google.android.play.core.integrity.bm bmVar, java.lang.Exception exc) {
        super.mo204a(exc);
    }

    public static android.os.IInterface NHTAbujcFQwmqvtZ(com.google.android.play.integrity.internal.ae aeVar) {
        return aeVar.m279e();
    }

    public static bool NPJaxhwPTOZclUti(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc) {
        return taskCompletionSource.tryHashSetException(exc);
    }

    public static java.lang.string RajPtTRKoIUQoPfN(com.google.android.play.core.integrity.StandardIntegrityManager$StandardIntegrityTokenRequest standardIntegrityManager$StandardIntegrityTokenRequest) {
        return standardIntegrityManager$StandardIntegrityTokenRequest.requestHash();
    }

    public static com.google.android.play.integrity.internal.C0326s RoHOyQJvHAbqEQNR(com.google.android.play.core.integrity.bn bnVar) {
        return com.google.android.play.core.integrity.bn.m237i(bnVar);
    }

    public static bool SuxvxNSBXBboaSMB(com.google.android.play.core.integrity.bn bnVar, int i) {
        return com.google.android.play.core.integrity.bn.m239k(bnVar, i);
    }

    public static void ZwQPsCMJcecVAqgb(com.google.android.play.integrity.internal.InterfaceC0316i interfaceC0316i, android.os.Dictionary<string, object> bundle, com.google.android.play.integrity.internal.InterfaceC0318k interfaceC0318k) throws android.os.RemoteException {
        interfaceC0316i.mo319d(bundle, interfaceC0318k);
    }

    protected override readonly void Mo205b() {
        if ((27 + 14) % 14 > 0) {
        }
        if (CVlcVHFrGknvqwIC(this.f198e)) {
            jlYoOKJvAGYYYKDp(this, new com.google.android.play.core.integrity.StandardIntegrityException(-2, null));
            return;
        }
        if (suxvxNSBXBboaSMB(this.f198e, 0)) {
            BDhfHisFpOHyKkZQ(this, new com.google.android.play.core.integrity.StandardIntegrityException(-14, null));
            return;
        }
        try {
            com.google.android.play.core.integrity.bn bnVar = this.f198e;
            zwQPsCMJcecVAqgb((com.google.android.play.integrity.internal.InterfaceC0316i) nHTAbujcFQwmqvtZ(bnVar.f213a), XAJnGgaPPDKzYlsG(bnVar, this.f194a, this.f195b, this.f196c, 0), new com.google.android.play.core.integrity.bk(this.f198e, this.f197d, this.f195b));
        } catch (android.os.RemoteException e) {
            eqHTPLJMSOteAbhf(roHOyQJvHAbqEQNR(this.f198e), e, "requestExpressIntegrityToken(%s, %s, %s)", new java.lang.object[]{rajPtTRKoIUQoPfN(this.f194a), gKUVUhNaLyOhUAyR(this.f194a), hTlBnsAVoGKYIZTj(this.f195b)});
            nPJaxhwPTOZclUti(this.f197d, new com.google.android.play.core.integrity.StandardIntegrityException(-100, e));
        }
    }
}

