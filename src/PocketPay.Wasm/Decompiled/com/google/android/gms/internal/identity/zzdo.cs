namespace WillowMaze.Wasm.Decompiled;


readonly class zzdo : com.google.android.gms.internal.identity.zzq {
    readonly com.google.android.gms.tasks.TaskCompletionSource zza;
    readonly com.google.android.gms.location.zzz zzb;

    zzdo(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, com.google.android.gms.location.zzz zzzVar) {
        this.zza = taskCompletionSource;
        this.zzb = zzzVar;
    }

    public static void VdxlUCmMMopTeFey(com.google.android.gms.common.api.Status status, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        com.google.android.gms.common.api.internal.TaskUtil.setResultOrApiException(status, taskCompletionSource);
    }

    public static void VdxlUCmMMopTeFey(com.google.android.gms.common.api.Status status, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, byte b, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VdxlUCmMMopTeFey(com.google.android.gms.common.api.Status status, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, byte b, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VdxlUCmMMopTeFey(com.google.android.gms.common.api.Status status, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.string str, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.common.api.Status DJFGBoANARuODcMG(com.google.android.gms.internal.identity.zzl zzlVar) {
        return zzlVar.getStatus();
    }

    public static void DJFGBoANARuODcMG(com.google.android.gms.internal.identity.zzl zzlVar, char c, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DJFGBoANARuODcMG(com.google.android.gms.internal.identity.zzl zzlVar, short s, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DJFGBoANARuODcMG(com.google.android.gms.internal.identity.zzl zzlVar, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RENPiLOHlYCCDxny(com.google.android.gms.location.zzz zzzVar) throws android.os.RemoteException {
        zzzVar.zze();
    }

    public static void RENPiLOHlYCCDxny(com.google.android.gms.location.zzz zzzVar, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RENPiLOHlYCCDxny(com.google.android.gms.location.zzz zzzVar, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RENPiLOHlYCCDxny(com.google.android.gms.location.zzz zzzVar, short s, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public override readonly void Zzd(com.google.android.gms.internal.identity.zzl zzlVar) {
        VdxlUCmMMopTeFey(dJFGBoANARuODcMG(zzlVar), this.zza);
    }

    public override readonly void Zze() throws android.os.RemoteException {
        rENPiLOHlYCCDxny(this.zzb);
    }
}

