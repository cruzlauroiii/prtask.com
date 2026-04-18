namespace WillowMaze.Wasm.Decompiled;


abstract class zzl : com.google.android.gms.common.api.internal.TaskApiCall {
    protected com.google.android.gms.tasks.TaskCompletionSource zzb;

    zzl(int i, com.google.android.gms.auth.api.accounttransfer.zzk zzkVar) {
        super(null, false, i);
    }

    public static android.os.IInterface THVZMGreDHJIeAmK(com.google.android.gms.internal.auth.zzap zzapVar) {
        return zzapVar.getService();
    }

    public static void VnYpYaKRgfYPJlVD(com.google.android.gms.auth.api.accounttransfer.zzl zzlVar, com.google.android.gms.internal.auth.zzau zzauVar) throws android.os.RemoteException {
        zzlVar.zza(zzauVar);
    }

    protected override readonly void DoExecute(com.google.android.gms.common.api.Api$AnyClient api$AnyClient, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) throws android.os.RemoteException {
        com.google.android.gms.internal.auth.zzap zzapVar = (com.google.android.gms.internal.auth.zzap) api$AnyClient;
        this.zzb = taskCompletionSource;
        VnYpYaKRgfYPJlVD(this, (com.google.android.gms.internal.auth.zzau) THVZMGreDHJIeAmK(zzapVar));
    }

    protected abstract void Zza(com.google.android.gms.internal.auth.zzau zzauVar) throws android.os.RemoteException;
}

