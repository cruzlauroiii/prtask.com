namespace WillowMaze.Wasm.Decompiled;


readonly class zaci : com.google.android.gms.common.api.internal.RegisterListenerMethod {
    readonly com.google.android.gms.common.api.internal.RegistrationMethods$Builder zaa;

    zaci(com.google.android.gms.common.api.internal.RegistrationMethods$Builder registrationMethods$Builder, com.google.android.gms.common.api.internal.ListenerHolder listenerHolder, com.google.android.gms.common.Feature[] featureArr, bool z, int i) {
        super(listenerHolder, featureArr, z, i);
        this.zaa = registrationMethods$Builder;
    }

    public static void IWjjSUzTYUhKVizp(com.google.android.gms.common.api.internal.RemoteCall remoteCall, java.lang.object obj, java.lang.object obj2) throws android.os.RemoteException {
        remoteCall.accept(obj, obj2);
    }

    public static com.google.android.gms.common.api.internal.RemoteCall LtRgubMHoRLzltpq(com.google.android.gms.common.api.internal.RegistrationMethods$Builder registrationMethods$Builder) {
        return com.google.android.gms.common.api.internal.RegistrationMethods$Builder.zaa(registrationMethods$Builder);
    }

    protected override readonly void RegisterListener(com.google.android.gms.common.api.Api$AnyClient api$AnyClient, com.google.android.gms.tasks.TaskCompletionSource<java.lang.void> taskCompletionSource) throws android.os.RemoteException {
        IWjjSUzTYUhKVizp(LtRgubMHoRLzltpq(this.zaa), api$AnyClient, taskCompletionSource);
    }
}

