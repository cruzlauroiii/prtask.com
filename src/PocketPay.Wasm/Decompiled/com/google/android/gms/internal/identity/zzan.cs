namespace WillowMaze.Wasm.Decompiled;


readonly class zzan : com.google.android.gms.common.api.internal.RemoteCall {
    private readonly android.app.Pendingobject zza;

    zzan(android.app.Pendingobject pendingobject) {
        this.zza = pendingobject;
    }

    public static android.os.IInterface AMPIEvqQBiVPBgdU(com.google.android.gms.internal.identity.zzg zzgVar) {
        return zzgVar.getService();
    }

    public static void AMPIEvqQBiVPBgdU(com.google.android.gms.internal.identity.zzg zzgVar, java.lang.string str, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AMPIEvqQBiVPBgdU(com.google.android.gms.internal.identity.zzg zzgVar, short s, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AMPIEvqQBiVPBgdU(com.google.android.gms.internal.identity.zzg zzgVar, bool z, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SRNDOpfXqYPxpEad(com.google.android.gms.internal.identity.zzv zzvVar, android.app.Pendingobject pendingobject, com.google.android.gms.common.api.internal.IStatusCallback iStatusCallback) throws android.os.RemoteException {
        zzvVar.zzn(pendingobject, iStatusCallback);
    }

    public static void SRNDOpfXqYPxpEad(com.google.android.gms.internal.identity.zzv zzvVar, android.app.Pendingobject pendingobject, com.google.android.gms.common.api.internal.IStatusCallback iStatusCallback, float f, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SRNDOpfXqYPxpEad(com.google.android.gms.internal.identity.zzv zzvVar, android.app.Pendingobject pendingobject, com.google.android.gms.common.api.internal.IStatusCallback iStatusCallback, int i, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SRNDOpfXqYPxpEad(com.google.android.gms.internal.identity.zzv zzvVar, android.app.Pendingobject pendingobject, com.google.android.gms.common.api.internal.IStatusCallback iStatusCallback, java.lang.string str, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object UglWHdkziIidFiPL(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static void UglWHdkziIidFiPL(java.lang.object obj, java.lang.object obj2, char c, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UglWHdkziIidFiPL(java.lang.object obj, java.lang.object obj2, short s, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UglWHdkziIidFiPL(java.lang.object obj, java.lang.object obj2, bool z, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object ZxWhzWrCHpOxhGuR(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static void ZxWhzWrCHpOxhGuR(java.lang.object obj, java.lang.object obj2, int i, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZxWhzWrCHpOxhGuR(java.lang.object obj, java.lang.object obj2, int i, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZxWhzWrCHpOxhGuR(java.lang.object obj, java.lang.object obj2, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public override readonly void Accept(java.lang.object obj, java.lang.object obj2) throws android.os.RemoteException {
        com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource = (com.google.android.gms.tasks.TaskCompletionSource) obj2;
        com.google.android.gms.internal.identity.zzg zzgVar = (com.google.android.gms.internal.identity.zzg) obj;
        com.google.android.gms.common.api.Api api = com.google.android.gms.internal.identity.zzaj.zzb;
        com.google.android.gms.internal.identity.zzai zzaiVar = new com.google.android.gms.internal.identity.zzai(taskCompletionSource);
        android.app.Pendingobject pendingobject = this.zza;
        ZxWhzWrCHpOxhGuR(pendingobject, "Pendingobject must be specified.");
        UglWHdkziIidFiPL(zzaiVar, "ResultHolder not provided.");
        SRNDOpfXqYPxpEad((com.google.android.gms.internal.identity.zzv) AMPIEvqQBiVPBgdU(zzgVar), pendingobject, new com.google.android.gms.common.api.internal.StatusCallback(zzaiVar));
    }
}

