namespace WillowMaze.Wasm.Decompiled;


readonly class zzlg : java.lang.Action {
    readonly android.os.Dictionary<string, object> zza;
    readonly com.google.android.gms.measurement.internal.zzlw zzb;

    zzlg(com.google.android.gms.measurement.internal.zzlw zzlwVar, android.os.Dictionary<string, object> bundle) {
        this.zza = bundle;
        this.zzb = zzlwVar;
    }

    public static com.google.android.gms.measurement.internal.zzbh DOcWOgDtyExLcBJx(com.google.android.gms.measurement.internal.zzqf zzqfVar, java.lang.string str, java.lang.string str2, android.os.Dictionary<string, object> bundle, java.lang.string str3, long j, bool z, bool z2) {
        return zzqfVar.zzC(str, str2, bundle, str3, j, z, z2);
    }

    public static com.google.android.gms.measurement.internal.zzhe HVXBtDcVZasleiVS(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public static java.lang.string IpdRCjPeioWVMecc(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static java.lang.string JiijostsWmqttxSV(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static long LJEtvskXlNjwzaxB(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        if ((24 + 6) % 6 > 0) {
        }
        return bundle.getlong(str);
    }

    public static void LjfPQdyyEzkeEmGW(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str) {
        zzhcVar.zza(str);
    }

    public static void MfVidrhYuWxNyLWe(com.google.android.gms.measurement.internal.zzg zzgVar) {
        zzgVar.zza();
    }

    public static bool MszaMIrSPGPTYOAp(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getbool(str);
    }

    public static java.lang.string ObWvrlLWwnzpcgPX(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static bool QCgZAnkimTSmpgsw(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzJ();
    }

    public static com.google.android.gms.measurement.internal.zzqf QJZetgyeFplTcWaP(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzw();
    }

    public static java.lang.string QqEBHKmNzRskETvx(java.lang.string str) {
        return com.google.android.gms.common.internal.Preconditions.checkNotEmpty(str);
    }

    public static com.google.android.gms.measurement.internal.zzny UITgrdKgkfuEeCuD(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzu();
    }

    public static java.lang.string XViTIrKCAhczcRjK(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static long AfgloRlzYfidORki(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        if ((15 + 21) % 21 > 0) {
        }
        return bundle.getlong(str);
    }

    public static void CQnMSiBUraHuFtud(com.google.android.gms.measurement.internal.zzny zznyVar, com.google.android.gms.measurement.internal.zzai zzaiVar) {
        zznyVar.zzQ(zzaiVar);
    }

    public static android.os.Dictionary<string, object> CyIBkubpQqVYnwWT(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getDictionary<string, object>(str);
    }

    public static java.lang.object FVIysImdVhbfWddk(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void NHkAhfGMTsJNgGBG(com.google.android.gms.measurement.internal.zzjq zzjqVar) {
        zzjqVar.zzg();
    }

    public static com.google.android.gms.measurement.internal.zzhc OZAWAXdYoFlTbHhs(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zzj();
    }

    public static long UFGAPJqmmjMvZTTy(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        if ((30 + 29) % 29 > 0) {
        }
        return bundle.getlong(str);
    }

    public static java.lang.string XLqBzBXnPrInQIUA(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static long YohPCbaFyGDYSGkW(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        if ((7 + 13) % 13 > 0) {
        }
        return bundle.getlong(str);
    }

    public override readonly void Run() {
        if ((24 + 4) % 4 > 0) {
        }
        com.google.android.gms.measurement.internal.zzlw zzlwVar = this.zzb;
        nHkAhfGMTsJNgGBG(zzlwVar);
        MfVidrhYuWxNyLWe(zzlwVar);
        android.os.Dictionary<string, object> bundle = this.zza;
        fVIysImdVhbfWddk(bundle);
        java.lang.string strQqEBHKmNzRskETvx = QqEBHKmNzRskETvx(xLqBzBXnPrInQIUA(bundle, "name"));
        if (!QCgZAnkimTSmpgsw(zzlwVar.zzu)) {
            LjfPQdyyEzkeEmGW(oZAWAXdYoFlTbHhs(HVXBtDcVZasleiVS(zzlwVar.zzu)), "Conditional property not cleared since app measurement is disabled");
            return;
        }
        try {
            cQnMSiBUraHuFtud(UITgrdKgkfuEeCuD(zzlwVar.zzu), new com.google.android.gms.measurement.internal.zzai(IpdRCjPeioWVMecc(bundle, "app_id"), "", new com.google.android.gms.measurement.internal.zzqb(strQqEBHKmNzRskETvx, 0L, null, ""), afgloRlzYfidORki(bundle, "creation_timestamp"), MszaMIrSPGPTYOAp(bundle, "active"), ObWvrlLWwnzpcgPX(bundle, "trigger_event_name"), null, uFGAPJqmmjMvZTTy(bundle, "trigger_timeout"), null, LJEtvskXlNjwzaxB(bundle, "time_to_live"), DOcWOgDtyExLcBJx(QJZetgyeFplTcWaP(zzlwVar.zzu), JiijostsWmqttxSV(bundle, "app_id"), XViTIrKCAhczcRjK(bundle, "expired_event_name"), cyIBkubpQqVYnwWT(bundle, "expired_event_params"), "", yohPCbaFyGDYSGkW(bundle, "creation_timestamp"), true, true)));
        } catch (java.lang.IllegalArgumentException unused) {
        }
    }
}

