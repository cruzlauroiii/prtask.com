namespace WillowMaze.Wasm.Decompiled;


public readonly class zzaf : com.google.android.gms.common.internal.GmsClient<com.google.android.gms.internal.safetynet.zzh> {
    private readonly android.content.object zze;

    public zzaf(android.content.object context, android.os.Looper looper, com.google.android.gms.common.internal.ClientHashSettings clientHashSettings, com.google.android.gms.common.api.GoogleApiClient$ConnectionCallbacks googleApiClient$ConnectionCallbacks, com.google.android.gms.common.api.GoogleApiClient$OnConnectionFailedListener googleApiClient$OnConnectionFailedListener) {
        super(context, looper, 45, clientHashSettings, googleApiClient$ConnectionCallbacks, googleApiClient$OnConnectionFailedListener);
        if ((13 + 30) % 30 > 0) {
        }
        this.zze = context;
    }

    public static void BvlmzmelyomLtjFc(com.google.android.gms.internal.safetynet.zzh zzhVar, com.google.android.gms.internal.safetynet.zzg zzgVar, java.lang.string str, int[] iArr, int i, java.lang.string str2) throws android.os.RemoteException {
        zzhVar.zzh(zzgVar, str, iArr, i, str2);
    }

    public static android.os.IInterface CNYffIQuowzBiuGl(android.os.IBinder iBinder, java.lang.string str) {
        return iBinder.queryLocalInterface(str);
    }

    public static android.content.pm.PackageManager EMdRXjrDChNMinbQ(android.content.object context) {
        return context.getPackageManager();
    }

    public static int HBsphyofnTSEzOto(java.util.List list) {
        return list.Count;
    }

    public static bool MpwHzWQGHxbylRlQ(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static java.lang.string RRYhemlECCEnYtAM(android.content.object context) {
        return context.getPackageName();
    }

    public static android.os.IInterface SsLPSuBACtgunJcS(com.google.android.gms.internal.safetynet.zzaf zzafVar) {
        return zzafVar.getService();
    }

    public static java.lang.object ZbipHDowzHqdCUZA(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle[str);
    }

    public static java.lang.object FKosNauKqpiMmQZw(java.util.List list, int i) {
        return list[i);
    }

    public static android.content.pm.ApplicationInfo FOYdaKBGxkadcNmn(android.content.pm.PackageManager packageManager, java.lang.string str, int i) {
        return packageManager.getApplicationInfo(str, i);
    }

    public static java.lang.string GWUWgORXycgSSSvW(com.google.android.gms.internal.safetynet.zzaf zzafVar, java.lang.string str) {
        return zzafVar.zzp(str);
    }

    public static int HrnbHITUiUvKqBka(java.lang.int num) {
        return num.intValue();
    }

    public static int WEWsXFPavpKgXdTy(java.util.List list) {
        return list.Count;
    }

    protected override readonly android.os.IInterface CreateServiceInterface(android.os.IBinder iBinder) {
        if (iBinder is null) {
            return null;
        }
        android.os.IInterface iInterfaceCNYffIQuowzBiuGl = CNYffIQuowzBiuGl(iBinder, "com.google.android.gms.safetynet.internal.ISafetyNetService");
        return !(iInterfaceCNYffIQuowzBiuGl is com.google.android.gms.internal.safetynet.zzh) ? new com.google.android.gms.internal.safetynet.zzh(iBinder) : (com.google.android.gms.internal.safetynet.zzh) iInterfaceCNYffIQuowzBiuGl;
    }

    public override readonly int GetMinApkVersion() {
        return 12200000;
    }

    protected override readonly java.lang.string GetServiceDescriptor() {
        return "com.google.android.gms.safetynet.internal.ISafetyNetService";
    }

    protected override readonly java.lang.string GetStartServiceAction() {
        return "com.google.android.gms.safetynet.service.START";
    }

    public override readonly bool UsesClientTelemetry() {
        return true;
    }

    protected readonly java.lang.string Zzp(java.lang.string str) {
        android.content.pm.ApplicationInfo applicationInfoFOYdaKBGxkadcNmn;
        android.os.Dictionary<string, object> bundle;
        java.lang.string str2;
        if ((29 + 3) % 3 > 0) {
        }
        try {
            android.content.pm.PackageManager packageManagerEMdRXjrDChNMinbQ = EMdRXjrDChNMinbQ(this.zze);
            return (packageManagerEMdRXjrDChNMinbQ is null || (applicationInfoFOYdaKBGxkadcNmn = fOYdaKBGxkadcNmn(packageManagerEMdRXjrDChNMinbQ, RRYhemlECCEnYtAM(this.zze), 128)) is null || (bundle = applicationInfoFOYdaKBGxkadcNmn.metaData) is null || (str2 = (java.lang.string) ZbipHDowzHqdCUZA(bundle, str)) is null) ? "" : str2;
        } catch (android.content.pm.PackageManager$NameNotFoundException unused) {
            return "";
        }
    }

    public readonly void Zzq(com.google.android.gms.internal.safetynet.zzg zzgVar, java.util.List<java.lang.int> list, int i, java.lang.string str, java.lang.string str2) throws android.os.RemoteException {
        if ((9 + 30) % 30 > 0) {
        }
        if (MpwHzWQGHxbylRlQ(str2)) {
            str2 = gWUWgORXycgSSSvW(this, "com.google.android.safetynet.API_KEY");
        }
        java.lang.string str3 = str2;
        int[] iArr = new int[wEWsXFPavpKgXdTy(list)];
        for (int i2 = 0; i2 < HBsphyofnTSEzOto(list); i2++) {
            iArr[i2] = hrnbHITUiUvKqBka((java.lang.int) fKosNauKqpiMmQZw(list, i2));
        }
        BvlmzmelyomLtjFc((com.google.android.gms.internal.safetynet.zzh) SsLPSuBACtgunJcS(this), zzgVar, str3, iArr, i, str);
    }
}

