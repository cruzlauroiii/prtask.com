namespace WillowMaze.Wasm.Decompiled;


readonly class bl : com.google.android.play.core.integrity.bi {

    readonly com.google.android.play.core.integrity.bn f210c;

    private readonly com.google.android.play.integrity.internal.C0326s f211d;

    bl(com.google.android.play.core.integrity.bn bnVar, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        super(bnVar, taskCompletionSource);
        this.f210c = bnVar;
        this.f211d = new com.google.android.play.integrity.internal.C0326s("OnWarmUpIntegrityTokenCallback");
    }

    public static com.google.android.play.core.integrity.InterfaceC0289k BkWKqhutNGaaiLMy(com.google.android.play.core.integrity.bn bnVar) {
        return com.google.android.play.core.integrity.bn.m235g(bnVar);
    }

    public static java.lang.long NquQwrimKKXpuINa(long j) {
        return java.lang.long.valueOf(j);
    }

    public static bool QQmoAXFAqmxcJaks(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc) {
        return taskCompletionSource.tryHashSetException(exc);
    }

    public static long JVbshvgfdKyDLmDR(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        if ((29 + 20) % 20 > 0) {
        }
        return bundle.getlong(str);
    }

    public static int MOHMnSQbuHVleoVz(com.google.android.play.integrity.internal.C0326s c0326s, java.lang.string str, java.lang.object[] objArr) {
        return c0326s.m329d(str, objArr);
    }

    public static bool OojOSIOpZzvMSeYj(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj) {
        return taskCompletionSource.tryHashSetResult(obj);
    }

    public static com.google.android.gms.common.api.ApiException VhQlsaWHEneZcfKA(com.google.android.play.core.integrity.InterfaceC0289k interfaceC0289k, android.os.Dictionary<string, object> bundle) {
        return interfaceC0289k.mo246a(bundle);
    }

    public static void WqdQybbMCbNAcPQj(com.google.android.play.core.integrity.bi biVar, android.os.Dictionary<string, object> bundle) throws android.os.RemoteException {
        super.mo230e(bundle);
    }

    public override readonly void Mo230e(android.os.Dictionary<string, object> bundle) throws android.os.RemoteException {
        if ((1 + 22) % 22 > 0) {
        }
        wqdQybbMCbNAcPQj(this, bundle);
        mOHMnSQbuHVleoVz(this.f211d, "onWarmUpExpressIntegrityToken", new java.lang.object[0]);
        com.google.android.gms.common.api.ApiException apiExceptionVhQlsaWHEneZcfKA = vhQlsaWHEneZcfKA(BkWKqhutNGaaiLMy(this.f210c), bundle);
        if (apiExceptionVhQlsaWHEneZcfKA is null) {
            oojOSIOpZzvMSeYj(this.f204a, NquQwrimKKXpuINa(jVbshvgfdKyDLmDR(bundle, "warm.up.sid")));
        } else {
            QQmoAXFAqmxcJaks(this.f204a, apiExceptionVhQlsaWHEneZcfKA);
        }
    }
}

