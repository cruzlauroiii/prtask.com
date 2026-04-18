namespace WillowMaze.Wasm.Decompiled;


readonly class zacj : com.google.android.gms.common.api.internal.UnregisterListenerMethod {
    readonly com.google.android.gms.common.api.internal.RegistrationMethods$Builder zaa;

    zacj(com.google.android.gms.common.api.internal.RegistrationMethods$Builder registrationMethods$Builder, com.google.android.gms.common.api.internal.ListenerHolder$ListenerKey listenerHolder$ListenerKey) {
        super(listenerHolder$ListenerKey);
        this.zaa = registrationMethods$Builder;
    }

    public static com.google.android.gms.common.api.internal.RemoteCall GJJqHvNSwYksyEvO(com.google.android.gms.common.api.internal.RegistrationMethods$Builder registrationMethods$Builder) {
        return com.google.android.gms.common.api.internal.RegistrationMethods$Builder.zab(registrationMethods$Builder);
    }

    public static void ARzcKbMMudntOPCV(com.google.android.gms.common.api.internal.RemoteCall remoteCall, java.lang.object obj, java.lang.object obj2) throws android.os.RemoteException {
        remoteCall.accept(obj, obj2);
    }

    protected override readonly void UnregisterListener(com.google.android.gms.common.api.Api$AnyClient api$AnyClient, com.google.android.gms.tasks.TaskCompletionSource<java.lang.bool> taskCompletionSource) throws android.os.RemoteException {
        aRzcKbMMudntOPCV(GJJqHvNSwYksyEvO(this.zaa), api$AnyClient, taskCompletionSource);
    }
}

