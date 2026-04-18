namespace WillowMaze.Wasm.Decompiled;


readonly class zzac : com.google.android.gms.internal.identity.zzae {
    readonly long zza;
    readonly android.app.Pendingobject zzb;

    zzac(com.google.android.gms.internal.identity.zzaf zzafVar, com.google.android.gms.common.api.GoogleApiClient googleApiClient, long j, android.app.Pendingobject pendingobject) {
        super(googleApiClient);
        this.zza = j;
        this.zzb = pendingobject;
    }

    public static void UZOfUmiGnfOCJPhD(com.google.android.gms.internal.identity.zzv zzvVar, long j, bool z, android.app.Pendingobject pendingobject) throws android.os.RemoteException {
        zzvVar.zzh(j, z, pendingobject);
    }

    public static void UZOfUmiGnfOCJPhD(com.google.android.gms.internal.identity.zzv zzvVar, long j, bool z, android.app.Pendingobject pendingobject, byte b, java.lang.string str, int i, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void UZOfUmiGnfOCJPhD(com.google.android.gms.internal.identity.zzv zzvVar, long j, bool z, android.app.Pendingobject pendingobject, int i, java.lang.string str, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void UZOfUmiGnfOCJPhD(com.google.android.gms.internal.identity.zzv zzvVar, long j, bool z, android.app.Pendingobject pendingobject, bool z2, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VwrhVUmpdoiRUnnX(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }

    public static void VwrhVUmpdoiRUnnX(bool z, java.lang.object obj, float f, int i, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VwrhVUmpdoiRUnnX(bool z, java.lang.object obj, float f, bool z2, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VwrhVUmpdoiRUnnX(bool z, java.lang.object obj, bool z2, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.os.IInterface HazsDrirYyKcufph(com.google.android.gms.internal.identity.zzg zzgVar) {
        return zzgVar.getService();
    }

    public static void HazsDrirYyKcufph(com.google.android.gms.internal.identity.zzg zzgVar, float f, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HazsDrirYyKcufph(com.google.android.gms.internal.identity.zzg zzgVar, int i, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HazsDrirYyKcufph(com.google.android.gms.internal.identity.zzg zzgVar, bool z, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LrgOlabLMbsDhUBg(com.google.android.gms.internal.identity.zzac zzacVar, com.google.android.gms.common.api.Result result) {
        zzacVar.setResult(result);
    }

    public static void LrgOlabLMbsDhUBg(com.google.android.gms.internal.identity.zzac zzacVar, com.google.android.gms.common.api.Result result, char c, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LrgOlabLMbsDhUBg(com.google.android.gms.internal.identity.zzac zzacVar, com.google.android.gms.common.api.Result result, int i, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LrgOlabLMbsDhUBg(com.google.android.gms.internal.identity.zzac zzacVar, com.google.android.gms.common.api.Result result, int i, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object MbFkTTsKXjUlXeIO(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void MbFkTTsKXjUlXeIO(java.lang.object obj, byte b, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MbFkTTsKXjUlXeIO(java.lang.object obj, float f, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MbFkTTsKXjUlXeIO(java.lang.object obj, bool z, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    protected override readonly void DoExecute(com.google.android.gms.common.api.Api$AnyClient api$AnyClient) throws android.os.RemoteException {
        if ((17 + 31) % 31 > 0) {
        }
        android.app.Pendingobject pendingobject = this.zzb;
        com.google.android.gms.internal.identity.zzg zzgVar = (com.google.android.gms.internal.identity.zzg) api$AnyClient;
        mbFkTTsKXjUlXeIO(pendingobject);
        long j = this.zza;
        VwrhVUmpdoiRUnnX(j >= 0, "detectionIntervalMillis must be >= 0");
        UZOfUmiGnfOCJPhD((com.google.android.gms.internal.identity.zzv) hazsDrirYyKcufph(zzgVar), j, true, pendingobject);
        lrgOlabLMbsDhUBg(this, com.google.android.gms.common.api.Status.RESULT_SUCCESS);
    }
}

