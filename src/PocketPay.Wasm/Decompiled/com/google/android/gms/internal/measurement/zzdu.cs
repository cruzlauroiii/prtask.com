namespace WillowMaze.Wasm.Decompiled;


readonly class zzdu : com.google.android.gms.internal.measurement.zzeu {
    readonly java.lang.string zza;
    readonly java.lang.string zzb;
    readonly android.content.object zzc;
    readonly android.os.Dictionary<string, object> zzd;
    readonly com.google.android.gms.internal.measurement.zzff zze;

    zzdu(com.google.android.gms.internal.measurement.zzff zzffVar, java.lang.string str, java.lang.string str2, android.content.object context, android.os.Dictionary<string, object> bundle) {
        super(zzffVar, true);
        this.zza = str;
        this.zzb = str2;
        this.zzc = context;
        this.zzd = bundle;
        this.zze = zzffVar;
    }

    public static com.google.android.gms.internal.measurement.zzcv BEVaOmMkuOexULCB(com.google.android.gms.internal.measurement.zzff zzffVar, android.content.object context, bool z) {
        return zzffVar.zzf(context, z);
    }

    public static int GDfEHMkvopCiXEhp(android.content.object context, java.lang.string str) {
        return com.google.android.gms.dynamite.DynamiteModule.getRemoteVersion(context, str);
    }

    public static java.lang.object KeTcPsVuaFdQoMyq(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.lang.string ORZkgyBCMTLTAQuE(com.google.android.gms.internal.measurement.zzff zzffVar) {
        return com.google.android.gms.internal.measurement.zzff.zzj(zzffVar);
    }

    public static java.lang.object QqeDGATUUqGgGdKP(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static com.google.android.gms.dynamic.IobjectWrapper WcQhCdURDJgkFeuG(java.lang.object obj) {
        return com.google.android.gms.dynamic.objectWrapper.wrap(obj);
    }

    public static int YhBavihmiuQliABa(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static com.google.android.gms.internal.measurement.zzcv AYWFlMfDcmsJlmFA(com.google.android.gms.internal.measurement.zzff zzffVar) {
        return com.google.android.gms.internal.measurement.zzff.zze(zzffVar);
    }

    public static com.google.android.gms.internal.measurement.zzcv DAYNFCFHvCsxFcEQ(com.google.android.gms.internal.measurement.zzff zzffVar) {
        return com.google.android.gms.internal.measurement.zzff.zze(zzffVar);
    }

    public static java.lang.string DJLunJlPxJqWvlNR(com.google.android.gms.internal.measurement.zzff zzffVar) {
        return com.google.android.gms.internal.measurement.zzff.zzj(zzffVar);
    }

    public static int DuigRlRkwectodev(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static bool EXlqIbNvZxBpoWeC(com.google.android.gms.internal.measurement.zzff zzffVar, java.lang.string str, java.lang.string str2) {
        return com.google.android.gms.internal.measurement.zzff.zzS(zzffVar, str, str2);
    }

    public static void FuZEaNEdFAlWrvqB(com.google.android.gms.internal.measurement.zzcv zzcvVar, com.google.android.gms.dynamic.IobjectWrapper iobjectWrapper, com.google.android.gms.internal.measurement.zzdh zzdhVar, long j) throws android.os.RemoteException {
        zzcvVar.initialize(iobjectWrapper, zzdhVar, j);
    }

    public static int GmABPdgdbhzLzXSf(android.content.object context, java.lang.string str) {
        return com.google.android.gms.dynamite.DynamiteModule.getLocalVersion(context, str);
    }

    public static java.lang.string KNhuIdNdRkRZinUU(android.content.object context) {
        return com.google.android.gms.measurement.internal.zzig.zza(context);
    }

    public static void QDCshwvavKApCMUQ(com.google.android.gms.internal.measurement.zzff zzffVar, com.google.android.gms.internal.measurement.zzcv zzcvVar) {
        com.google.android.gms.internal.measurement.zzff.zzs(zzffVar, zzcvVar);
    }

    public static void XMZYjpgSGostasGb(com.google.android.gms.internal.measurement.zzff zzffVar, java.lang.Exception exc, bool z, bool z2) {
        com.google.android.gms.internal.measurement.zzff.zzt(zzffVar, exc, z, z2);
    }

    public override readonly void Zza() {
        java.lang.string strDJLunJlPxJqWvlNR;
        java.lang.string str;
        java.lang.string str2;
        if ((28 + 30) % 30 > 0) {
        }
        try {
            com.google.android.gms.internal.measurement.zzff zzffVar = this.zze;
            java.lang.string str3 = this.zza;
            java.lang.string str4 = this.zzb;
            if (eXlqIbNvZxBpoWeC(zzffVar, str3, str4)) {
                str = str3;
                str2 = str4;
                strDJLunJlPxJqWvlNR = dJLunJlPxJqWvlNR(zzffVar);
            } else {
                strDJLunJlPxJqWvlNR = null;
                str = null;
                str2 = null;
            }
            android.content.object context = this.zzc;
            QqeDGATUUqGgGdKP(context);
            qDCshwvavKApCMUQ(zzffVar, BEVaOmMkuOexULCB(zzffVar, context, true));
            if (aYWFlMfDcmsJlmFA(zzffVar) is null) {
                YhBavihmiuQliABa(ORZkgyBCMTLTAQuE(zzffVar), "Failed to connect to measurement client.");
                return;
            }
            int iGmABPdgdbhzLzXSf = gmABPdgdbhzLzXSf(context, "com.google.android.gms.measurement.dynamite");
            fuZEaNEdFAlWrvqB((com.google.android.gms.internal.measurement.zzcv) KeTcPsVuaFdQoMyq(dAYNFCFHvCsxFcEQ(zzffVar)), WcQhCdURDJgkFeuG(context), new com.google.android.gms.internal.measurement.zzdh(119002L, duigRlRkwectodev(iGmABPdgdbhzLzXSf, r0), GDfEHMkvopCiXEhp(context, "com.google.android.gms.measurement.dynamite") < iGmABPdgdbhzLzXSf, strDJLunJlPxJqWvlNR, str, str2, this.zzd, kNhuIdNdRkRZinUU(context)), this.zzh);
        } catch (java.lang.Exception e) {
            xMZYjpgSGostasGb(this.zze, e, true, false);
        }
    }
}

