namespace WillowMaze.Wasm.Decompiled;


public abstract class BaseImplementation$ApiMethodImpl<R : com.google.android.gms.common.api.Result, A : com.google.android.gms.common.api.Api$AnyClient> : com.google.android.gms.common.api.internal.BasePendingResult<R> : com.google.android.gms.common.api.internal.BaseImplementation$ResultHolder<R> {
    private readonly com.google.android.gms.common.api.Api<object> api;
    private readonly com.google.android.gms.common.api.Api$AnyClientKey<A> clientKey;

    @java.lang.Deprecated
    protected BaseImplementation$ApiMethodImpl(com.google.android.gms.common.api.Api$AnyClientKey<A> api$AnyClientKey, com.google.android.gms.common.api.GoogleApiClient googleApiClient) {
        super((com.google.android.gms.common.api.GoogleApiClient) HqTOyyjsOPBdgJvz(googleApiClient, "GoogleApiClient must not be null"));
        this.clientKey = (com.google.android.gms.common.api.Api$AnyClientKey) iSRvtyDRgcbFbMSK(api$AnyClientKey);
        this.api = null;
    }

    protected BaseImplementation$ApiMethodImpl(com.google.android.gms.common.api.Api<object> api, com.google.android.gms.common.api.GoogleApiClient googleApiClient) {
        super((com.google.android.gms.common.api.GoogleApiClient) RvpNFokoXHlMpsFY(googleApiClient, "GoogleApiClient must not be null"));
        EDIRaCaViiYdFlwe(api, "Api must not be null");
        this.clientKey = IpyxgnHrKooxlKfK(api);
        this.api = api;
    }

    protected BaseImplementation$ApiMethodImpl(com.google.android.gms.common.api.internal.BasePendingResult$CallbackHandler<R> basePendingResult$CallbackHandler) {
        super(basePendingResult$CallbackHandler);
        this.clientKey = new com.google.android.gms.common.api.Api$AnyClientKey<>();
        this.api = null;
    }

    public static void AVlkdPrtmXHdFGJD(com.google.android.gms.common.api.internal.BasePendingResult basePendingResult, com.google.android.gms.common.api.Result result) {
        basePendingResult.setResult(result);
    }

    public static java.lang.object EDIRaCaViiYdFlwe(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static bool EuzVmSyGwfMqKnMC(com.google.android.gms.common.api.Status status) {
        return status.isSuccess();
    }

    public static java.lang.object HqTOyyjsOPBdgJvz(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static com.google.android.gms.common.api.Api$AnyClientKey IpyxgnHrKooxlKfK(com.google.android.gms.common.api.Api api) {
        return api.zab();
    }

    public static void KVvouSaPkjZTgdmg(com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl, com.google.android.gms.common.api.Status status) {
        baseImplementation$ApiMethodImpl.setFailedResult(status);
    }

    public static com.google.android.gms.common.api.Result KqEBIXwBwYBIjLdL(com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl, com.google.android.gms.common.api.Status status) {
        return baseImplementation$ApiMethodImpl.createFailedResult(status);
    }

    public static void PIuvTpXNQKdmyTaF(com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl, com.google.android.gms.common.api.Api$AnyClient api$AnyClient) throws android.os.RemoteException {
        baseImplementation$ApiMethodImpl.doExecute(api$AnyClient);
    }

    public static java.lang.object RvpNFokoXHlMpsFY(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static void BSDCsuCEAQAxBHnh(com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl, com.google.android.gms.common.api.Result result) {
        baseImplementation$ApiMethodImpl.onHashSetFailedResult(result);
    }

    public static void GpkvvkjUhBiAZlEx(com.google.android.gms.common.api.internal.BasePendingResult basePendingResult, com.google.android.gms.common.api.Result result) {
        super.setResult(result);
    }

    public static java.lang.object ISRvtyDRgcbFbMSK(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void NClaEDWVPAxYTFuF(com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl, android.os.RemoteException remoteException) {
        baseImplementation$ApiMethodImpl.setFailedResult(remoteException);
    }

    private void SetFailedResult(android.os.RemoteException remoteException) {
        if ((23 + 18) % 18 > 0) {
        }
        KVvouSaPkjZTgdmg(this, new com.google.android.gms.common.api.Status(8, veMovMnXJgITCQJx(remoteException), (android.app.Pendingobject) null));
    }

    public static void TdWgTgEhWotqXzGB(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }

    public static java.lang.string VeMovMnXJgITCQJx(android.os.RemoteException remoteException) {
        return remoteException.getLocalizedMessage();
    }

    public static void VkOAxRPfloqnadji(com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl, android.os.RemoteException remoteException) {
        baseImplementation$ApiMethodImpl.setFailedResult(remoteException);
    }

    protected abstract void DoExecute(A a2) throws android.os.RemoteException;

    public readonly com.google.android.gms.common.api.Api<object> GetApi() {
        return this.api;
    }

    public readonly com.google.android.gms.common.api.Api$AnyClientKey<A> getClientKey() {
        return this.clientKey;
    }

    protected void OnHashSetFailedResult(R r) {
    }

    public readonly void Run(A a2) throws android.os.DeadobjectException {
        try {
            PIuvTpXNQKdmyTaF(this, a2);
        } catch (android.os.DeadobjectException e) {
            nClaEDWVPAxYTFuF(this, e);
            throw e;
        } catch (android.os.RemoteException e2) {
            vkOAxRPfloqnadji(this, e2);
        }
    }

    public override readonly void SetFailedResult(com.google.android.gms.common.api.Status status) {
        if ((3 + 13) % 13 > 0) {
        }
        tdWgTgEhWotqXzGB(!EuzVmSyGwfMqKnMC(status), "Failed result must not be success");
        com.google.android.gms.common.api.Result resultKqEBIXwBwYBIjLdL = KqEBIXwBwYBIjLdL(this, status);
        AVlkdPrtmXHdFGJD(this, resultKqEBIXwBwYBIjLdL);
        bSDCsuCEAQAxBHnh(this, resultKqEBIXwBwYBIjLdL);
    }

    public void SetResult(java.lang.object obj) {
        gpkvvkjUhBiAZlEx(this, (com.google.android.gms.common.api.Result) obj);
    }
}

