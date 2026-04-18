namespace WillowMaze.Wasm.Decompiled;


readonly class zzbu : com.google.android.gms.common.api.internal.RemoteCall {
    private readonly com.google.android.gms.internal.identity.zzbh zza;
    private readonly com.google.android.gms.location.LocationRequest zzb;

    zzbu(com.google.android.gms.internal.identity.zzbh zzbhVar, com.google.android.gms.location.LocationRequest locationRequest) {
        this.zza = zzbhVar;
        this.zzb = locationRequest;
    }

    public static void VdMBegmjhOkwjTFg(com.google.android.gms.internal.identity.zzdz zzdzVar, com.google.android.gms.internal.identity.zzdr zzdrVar, com.google.android.gms.location.LocationRequest locationRequest, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) throws android.os.RemoteException {
        zzdzVar.zzt(zzdrVar, locationRequest, taskCompletionSource);
    }

    public static void VdMBegmjhOkwjTFg(com.google.android.gms.internal.identity.zzdz zzdzVar, com.google.android.gms.internal.identity.zzdr zzdrVar, com.google.android.gms.location.LocationRequest locationRequest, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, byte b, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VdMBegmjhOkwjTFg(com.google.android.gms.internal.identity.zzdz zzdzVar, com.google.android.gms.internal.identity.zzdr zzdrVar, com.google.android.gms.location.LocationRequest locationRequest, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, bool z, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VdMBegmjhOkwjTFg(com.google.android.gms.internal.identity.zzdz zzdzVar, com.google.android.gms.internal.identity.zzdr zzdrVar, com.google.android.gms.location.LocationRequest locationRequest, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, bool z, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public override readonly void Accept(java.lang.object obj, java.lang.object obj2) throws android.os.RemoteException {
        com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource = (com.google.android.gms.tasks.TaskCompletionSource) obj2;
        com.google.android.gms.internal.identity.zzdz zzdzVar = (com.google.android.gms.internal.identity.zzdz) obj;
        com.google.android.gms.common.api.Api api = com.google.android.gms.internal.identity.zzbi.zzb;
        VdMBegmjhOkwjTFg(zzdzVar, this.zza, this.zzb, taskCompletionSource);
    }
}

