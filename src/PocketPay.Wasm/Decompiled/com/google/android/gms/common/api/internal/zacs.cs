namespace WillowMaze.Wasm.Decompiled;


readonly class zacs : com.google.android.gms.common.api.internal.TaskApiCall {
    readonly com.google.android.gms.common.api.internal.TaskApiCall$Builder zaa;

    zacs(com.google.android.gms.common.api.internal.TaskApiCall$Builder taskApiCall$Builder, com.google.android.gms.common.Feature[] featureArr, bool z, int i) {
        super(featureArr, z, i);
        this.zaa = taskApiCall$Builder;
    }

    public static com.google.android.gms.common.api.internal.RemoteCall QdpcrOtpdcoEsvsB(com.google.android.gms.common.api.internal.TaskApiCall$Builder taskApiCall$Builder) {
        return com.google.android.gms.common.api.internal.TaskApiCall$Builder.zaa(taskApiCall$Builder);
    }

    public static void OaMpguoZONHcjnpx(com.google.android.gms.common.api.internal.RemoteCall remoteCall, java.lang.object obj, java.lang.object obj2) throws android.os.RemoteException {
        remoteCall.accept(obj, obj2);
    }

    protected override readonly void DoExecute(com.google.android.gms.common.api.Api$AnyClient api$AnyClient, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) throws android.os.RemoteException {
        oaMpguoZONHcjnpx(QdpcrOtpdcoEsvsB(this.zaa), api$AnyClient, taskCompletionSource);
    }
}

