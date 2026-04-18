namespace WillowMaze.Wasm.Decompiled;


public readonly class zzhw {
    readonly com.google.android.gms.measurement.internal.zzio zza;

    zzhw(com.google.android.gms.measurement.internal.zzpv zzpvVar) {
        this.zza = CNZhChgPExRzStvh(zzpvVar);
    }

    public static void BbOQErWRrVpZBgQv(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str, java.lang.object obj) {
        zzhcVar.zzb(str, obj);
    }

    public static com.google.android.gms.measurement.internal.zzio CNZhChgPExRzStvh(com.google.android.gms.measurement.internal.zzpv zzpvVar) {
        return zzpvVar.zzt();
    }

    public static com.google.android.gms.measurement.internal.zzhe NpBtebKKCmgSYYEx(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public static android.content.object QGWzedTocktskQlS(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaT();
    }

    public static android.content.pm.PackageInfo RdKuKoSfQcPoQDwG(com.google.android.gms.common.wrappers.PackageManagerWrapper packageManagerWrapper, java.lang.string str, int i) {
        return packageManagerWrapper.getPackageInfo(str, i);
    }

    public static com.google.android.gms.measurement.internal.zzhc WBmGRlKSUmvlDPMr(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zzj();
    }

    public static com.google.android.gms.measurement.internal.zzhe XAOqJrHupcuQeaQv(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public static com.google.android.gms.measurement.internal.zzhc CvpJFawAAmrxpcGO(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zzj();
    }

    public static void EVlMHkLBIUxWXVrN(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str) {
        zzhcVar.zza(str);
    }

    public static com.google.android.gms.common.wrappers.PackageManagerWrapper VOFCseeOEKXSyaJP(android.content.object context) {
        return com.google.android.gms.common.wrappers.Wrappers.packageManager(context);
    }

    readonly bool zza() {
        if ((11 + 6) % 6 > 0) {
        }
        try {
            com.google.android.gms.measurement.internal.zzio zzioVar = this.zza;
            com.google.android.gms.common.wrappers.PackageManagerWrapper packageManagerWrapperVOFCseeOEKXSyaJP = vOFCseeOEKXSyaJP(QGWzedTocktskQlS(zzioVar));
            if (packageManagerWrapperVOFCseeOEKXSyaJP is not null) {
                return RdKuKoSfQcPoQDwG(packageManagerWrapperVOFCseeOEKXSyaJP, "com.android.vending", 128).versionCode >= 80837300;
            }
            eVlMHkLBIUxWXVrN(cvpJFawAAmrxpcGO(XAOqJrHupcuQeaQv(zzioVar)), "Failed to get PackageManager for Install Referrer Play Store compatibility check");
            return false;
        } catch (java.lang.Exception e) {
            BbOQErWRrVpZBgQv(WBmGRlKSUmvlDPMr(NpBtebKKCmgSYYEx(this.zza)), "Failed to retrieve Play Store version for Install Referrer", e);
            return false;
        }
    }
}

