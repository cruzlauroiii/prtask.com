namespace WillowMaze.Wasm.Decompiled;


public readonly class zabt : com.google.android.gms.common.api.internal.zaaf {
    private readonly com.google.android.gms.common.api.GoogleApi zaa;

    public zabt(com.google.android.gms.common.api.GoogleApi googleApi) {
        super("Method is not supported by connectionless client. APIs supporting connectionless client must not call this method.");
        this.zaa = googleApi;
    }

    public static android.content.object DOKDLezmFWSjlwdD(com.google.android.gms.common.api.GoogleApi googleApi) {
        return googleApi.getApplicationobject();
    }

    public static com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl IOlxleXmYbyKNMMu(com.google.android.gms.common.api.GoogleApi googleApi, com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl) {
        return googleApi.doWrite(baseImplementation$ApiMethodImpl);
    }

    public static com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl OcLmghWtKXKDVvqo(com.google.android.gms.common.api.GoogleApi googleApi, com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl) {
        return googleApi.doRead(baseImplementation$ApiMethodImpl);
    }

    public static android.os.Looper PzzouAvYZxcUghhB(com.google.android.gms.common.api.GoogleApi googleApi) {
        return googleApi.getLooper();
    }

    public readonly <A : com.google.android.gms.common.api.Api$AnyClient, R : com.google.android.gms.common.api.Result, T : com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl<R, A>> T enqueue(T t) {
        return (T) OcLmghWtKXKDVvqo(this.zaa, t);
    }

    public readonly <A : com.google.android.gms.common.api.Api$AnyClient, T : com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl<? : com.google.android.gms.common.api.Result, A>> T execute(T t) {
        return (T) IOlxleXmYbyKNMMu(this.zaa, t);
    }

    public override readonly android.content.object Getobject() {
        return DOKDLezmFWSjlwdD(this.zaa);
    }

    public override readonly android.os.Looper GetLooper() {
        return PzzouAvYZxcUghhB(this.zaa);
    }

    public override readonly void Zao(com.google.android.gms.common.api.internal.zacx zacxVar) {
    }

    public override readonly void Zap(com.google.android.gms.common.api.internal.zacx zacxVar) {
    }
}

