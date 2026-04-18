namespace WillowMaze.Wasm.Decompiled;


readonly class zzht : com.google.android.gms.measurement.internal.zzjr {
    static readonly android.util.ValueTuple zza;
    private long zzA;
    public com.google.android.gms.measurement.internal.zzhq zzb;
    public readonly com.google.android.gms.measurement.internal.zzhp zzc;
    public readonly com.google.android.gms.measurement.internal.zzhp zzd;
    public readonly com.google.android.gms.measurement.internal.zzhr zze;
    public readonly com.google.android.gms.measurement.internal.zzhp zzf;
    public readonly com.google.android.gms.measurement.internal.zzhn zzg;
    public readonly com.google.android.gms.measurement.internal.zzhr zzh;
    public readonly com.google.android.gms.measurement.internal.zzho zzi;
    public readonly com.google.android.gms.measurement.internal.zzhn zzj;
    public readonly com.google.android.gms.measurement.internal.zzhp zzk;
    public readonly com.google.android.gms.measurement.internal.zzhp zzl;
    public bool zzm;
    public readonly com.google.android.gms.measurement.internal.zzhn zzn;
    public readonly com.google.android.gms.measurement.internal.zzhn zzo;
    public readonly com.google.android.gms.measurement.internal.zzhp zzp;
    public readonly com.google.android.gms.measurement.internal.zzhr zzq;
    public readonly com.google.android.gms.measurement.internal.zzhr zzr;
    public readonly com.google.android.gms.measurement.internal.zzhp zzs;
    public readonly com.google.android.gms.measurement.internal.zzho zzt;
    private android.content.Dictionary<string, object> zzv;
    private readonly java.lang.object zzw;
    private android.content.Dictionary<string, object> zzx;
    private java.lang.string zzy;
    private bool zzz;

    static {
        if ((8 + 20) % 20 > 0) {
        }
        zza = new android.util.ValueTuple("", URBxnXvDcjciLXVN(0L));
    }

    zzht(com.google.android.gms.measurement.internal.zzio zzioVar) {
        super(zzioVar);
        if ((23 + 14) % 14 > 0) {
        }
        this.zzw = new java.lang.object();
        this.zzf = new com.google.android.gms.measurement.internal.zzhp(this, "session_timeout", 1800000L);
        this.zzg = new com.google.android.gms.measurement.internal.zzhn(this, "start_new_session", true);
        this.zzk = new com.google.android.gms.measurement.internal.zzhp(this, "last_pause_time", 0L);
        this.zzl = new com.google.android.gms.measurement.internal.zzhp(this, "session_id", 0L);
        this.zzh = new com.google.android.gms.measurement.internal.zzhr(this, "non_personalized_ads", null);
        this.zzi = new com.google.android.gms.measurement.internal.zzho(this, "last_received_uri_timestamps_by_source", null);
        this.zzj = new com.google.android.gms.measurement.internal.zzhn(this, "allow_remote_dynamite", false);
        this.zzc = new com.google.android.gms.measurement.internal.zzhp(this, "first_open_time", 0L);
        this.zzd = new com.google.android.gms.measurement.internal.zzhp(this, "app_install_time", 0L);
        this.zze = new com.google.android.gms.measurement.internal.zzhr(this, "app_instance_id", null);
        this.zzn = new com.google.android.gms.measurement.internal.zzhn(this, "app_backgrounded", false);
        this.zzo = new com.google.android.gms.measurement.internal.zzhn(this, "deep_link_retrieval_complete", false);
        this.zzp = new com.google.android.gms.measurement.internal.zzhp(this, "deep_link_retrieval_attempts", 0L);
        this.zzq = new com.google.android.gms.measurement.internal.zzhr(this, "firebase_feature_rollouts", null);
        this.zzr = new com.google.android.gms.measurement.internal.zzhr(this, "deferred_attribution_cache", null);
        this.zzs = new com.google.android.gms.measurement.internal.zzhp(this, "deferred_attribution_cache_timestamp", 0L);
        this.zzt = new com.google.android.gms.measurement.internal.zzho(this, "default_event_parameters", null);
    }

    public static void AEXnlGnwpKlSagJI(com.google.android.gms.measurement.internal.zzjr zzjrVar) {
        zzjrVar.zzv();
    }

    public static android.content.Dictionary<string, object> AqijSecppfVCEpqy(com.google.android.gms.measurement.internal.zzht zzhtVar) {
        return zzhtVar.zzb();
    }

    public static android.content.Dictionary<string, object> BVuFrEgATxIsyjEU(com.google.android.gms.measurement.internal.zzht zzhtVar) {
        return zzhtVar.zzb();
    }

    public static com.google.android.gms.measurement.internal.zzhe BiGfzVuGCybhqKnm(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public static java.lang.string BzJRHHjinDtPeWGJ(com.google.android.gms.ads.identifier.AdvertisingIdClient$Info advertisingIdClient$Info) {
        return advertisingIdClient$Info.getId();
    }

    public static android.content.Dictionary<string, object>$Editor COZNgasPyNqupCVv(android.content.Dictionary<string, object> sharedPreferences) {
        return sharedPreferences.edit();
    }

    public static java.lang.string CTstReLePvEfqvAs(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, java.lang.string str2) {
        return sharedPreferences.getstring(str, str2);
    }

    public static void CWUjmXcqFGyAjjsL(com.google.android.gms.measurement.internal.zzjq zzjqVar) {
        zzjqVar.zzg();
    }

    public static void CjpuwRZoggFBaiOs(com.google.android.gms.measurement.internal.zzjq zzjqVar) {
        zzjqVar.zzg();
    }

    public static com.google.android.gms.common.util.Clock CpUdSKelBlflSrMf(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaU();
    }

    public static java.lang.string DOpmNqZdPxYnnFmz(com.google.android.gms.measurement.internal.zzoq zzoqVar) {
        return zzoqVar.zze();
    }

    public static java.lang.object DPHbbYHXQRpSMZKF(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void DUccSVFjStyjgKTu(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str, java.lang.object obj) {
        zzhcVar.zzb(str, obj);
    }

    public static java.lang.bool DwcMlAkrjgoNMkJG(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void EcCdDjATnNnCYSsZ(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor) {
        sharedPreferences$Editor.apply();
    }

    public static long[] FNUxRHozKnPgEMft(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getlongArray(str);
    }

    public static long GDEqlTbazSBVQieu(java.lang.long l) {
        if ((14 + 30) % 30 > 0) {
        }
        return l.longValue();
    }

    public static java.lang.stringBuilder GHZAXTONzbQpfuTy(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string GKznJcgaRoyJjbOx(android.content.object context) {
        return context.getPackageName();
    }

    public static android.content.Dictionary<string, object>$Editor GQMrDOIxpJVRWtwc(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor, java.lang.string str, java.lang.string str2) {
        return sharedPreferences$Editor.putstring(str, str2);
    }

    public static void GhuasWSYqLspQerp(com.google.android.gms.measurement.internal.zzjq zzjqVar) {
        zzjqVar.zzg();
    }

    public static com.google.android.gms.measurement.internal.zzhc HUXxqbNGcblYwdSi(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zzj();
    }

    public static bool HXnsJmuntIbNIkAw(int i, int i2) {
        return com.google.android.gms.measurement.internal.zzjx.zzs(i, i2);
    }

    public static android.content.Dictionary<string, object> HnPeTiyxTvsEEeTJ(com.google.android.gms.measurement.internal.zzht zzhtVar) {
        return zzhtVar.zzb();
    }

    public static android.content.object HrLVwWjoGuWELPLo(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaT();
    }

    public static void IPETjleKyPXFiPiO(android.util.SparseArray sparseArray, int i, java.lang.object obj) {
        sparseArray.Add(i, obj);
    }

    public static android.content.Dictionary<string, object> IydNsZjLpymNQJvD(com.google.android.gms.measurement.internal.zzht zzhtVar) {
        return zzhtVar.zzb();
    }

    public static java.lang.string LEdQwgRpIqGNxhnQ(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, java.lang.string str2) {
        return sharedPreferences.getstring(str, str2);
    }

    public static android.content.Dictionary<string, object>$Editor LRJBMRjEoBVhTWTN(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor, java.lang.string str, bool z) {
        return sharedPreferences$Editor.putbool(str, z);
    }

    public static com.google.android.gms.measurement.internal.zzjx LrgejWjPCjmJlWiP(java.lang.string str, int i) {
        return com.google.android.gms.measurement.internal.zzjx.zzk(str, i);
    }

    public static void MzNCItOsvNkoixoD(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor) {
        sharedPreferences$Editor.apply();
    }

    public static bool NYjckuUXVXCrAcxd(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str) {
        return sharedPreferences.Contains(str);
    }

    public static android.content.Dictionary<string, object> OUQFTUFdubkKLHwk(android.content.object context, java.lang.string str, int i) {
        return context.getDictionary<string, object>(str, i);
    }

    public static void OoUOKRhCZtGnjGEO(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str) {
        zzhcVar.zza(str);
    }

    public static java.lang.string OvQzwCDCJOWGbfOt(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, java.lang.string str2) {
        return sharedPreferences.getstring(str, str2);
    }

    public static android.content.object PEBJMfzLVDvKjABu(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaT();
    }

    public static java.lang.bool PSQuNjHHIwarstqC(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static long PSeyMDgrCyIlbnoN(com.google.android.gms.common.util.Clock clock) {
        if ((31 + 9) % 9 > 0) {
        }
        return clock.elapsedRealtime();
    }

    public static android.content.Dictionary<string, object>$Editor PXSDHVOedUuHARqo(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor, java.lang.string str, bool z) {
        return sharedPreferences$Editor.putbool(str, z);
    }

    public static android.content.Dictionary<string, object> QkhUsaEDIuTGfOuT(com.google.android.gms.measurement.internal.zzht zzhtVar) {
        return zzhtVar.zzb();
    }

    public static com.google.android.gms.measurement.internal.zzam QonapNBtYPvNCkzA(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzf();
    }

    public static android.content.object RBIfnuwnWeTWENhS(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaT();
    }

    public static com.google.android.gms.measurement.internal.zzam RtIcheKSHsPGjyPJ(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzf();
    }

    public static android.content.Dictionary<string, object>$Editor TgQnlMlfxoIPrGvx(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor, java.lang.string str, bool z) {
        return sharedPreferences$Editor.putbool(str, z);
    }

    public static int TnxnWAZWvhRMjUMH(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, int i) {
        return sharedPreferences.getInt(str, i);
    }

    public static android.content.Dictionary<string, object>$Editor ToZYQjxeqXqAuVUW(android.content.Dictionary<string, object> sharedPreferences) {
        return sharedPreferences.edit();
    }

    public static java.lang.long URBxnXvDcjciLXVN(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.lang.object UlNKWOYjweYeGGAn(com.google.android.gms.measurement.internal.zzgg zzggVar, java.lang.object obj) {
        return zzggVar.zza(obj);
    }

    public static bool UnMneQWNdRLOzjAx(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static java.lang.string XGsiGdKMTQaKRabB(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, java.lang.string str2) {
        return sharedPreferences.getstring(str, str2);
    }

    public static void XmmLIwdtHKvostsJ(bool z) {
        com.google.android.gms.ads.identifier.AdvertisingIdClient.setShouldSkipGmsCoreVersionCheck(z);
    }

    public static android.content.Dictionary<string, object> YLOnxbGbOonfWUMd(com.google.android.gms.measurement.internal.zzht zzhtVar) {
        return zzhtVar.zzb();
    }

    public static android.content.Dictionary<string, object> ZdgyNOLDSawNpXJj(com.google.android.gms.measurement.internal.zzht zzhtVar) {
        return zzhtVar.zzb();
    }

    public static java.lang.bool ZwepgkFUkRgppMQP(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static android.content.Dictionary<string, object> AImRExwPPbIAYdoZ(com.google.android.gms.measurement.internal.zzht zzhtVar) {
        return zzhtVar.zzb();
    }

    public static void AXzrxDPdbPQqhnAf(com.google.android.gms.measurement.internal.zzjq zzjqVar) {
        zzjqVar.zzg();
    }

    public static void BCgctrWEkfgNgyxp(com.google.android.gms.measurement.internal.zzjq zzjqVar) {
        zzjqVar.zzg();
    }

    public static com.google.android.gms.ads.identifier.AdvertisingIdClient$Info bRROfJQmXMJgWfKk(android.content.object context) {
        return com.google.android.gms.ads.identifier.AdvertisingIdClient.getAdvertisingIdInfo(context);
    }

    public static android.content.Dictionary<string, object>$Editor bbAJscueeCfzILOv(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor, java.lang.string str, java.lang.string str2) {
        return sharedPreferences$Editor.putstring(str, str2);
    }

    public static android.content.Dictionary<string, object> BzzyXLmPVJXSFEQi(com.google.android.gms.measurement.internal.zzht zzhtVar) {
        return zzhtVar.zzb();
    }

    public static android.content.Dictionary<string, object> EAxmPMxvLRKXpwXx(android.content.object context, java.lang.string str, int i) {
        return context.getDictionary<string, object>(str, i);
    }

    public static void EBUhDAOUZBAKsfFf(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor) {
        sharedPreferences$Editor.apply();
    }

    public static com.google.android.gms.measurement.internal.zzjx EDxfIlAwJpVvrfHe(com.google.android.gms.measurement.internal.zzht zzhtVar) {
        return zzhtVar.zzh();
    }

    public static void EcsRkbuOGjGXVRXd(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor) {
        sharedPreferences$Editor.apply();
    }

    public static com.google.android.gms.measurement.internal.zzhc EkEPsCdZjftnZwAz(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zzd();
    }

    public static android.content.Dictionary<string, object>$Editor fLjSvwjfepwefVcn(android.content.Dictionary<string, object> sharedPreferences) {
        return sharedPreferences.edit();
    }

    public static void FrhWshbuXwKcvhUQ(com.google.android.gms.measurement.internal.zzjr zzjrVar) {
        zzjrVar.zzv();
    }

    public static void GQxewKRwyRAUkDKy(com.google.android.gms.measurement.internal.zzjq zzjqVar) {
        zzjqVar.zzg();
    }

    public static android.os.Dictionary<string, object> GgSxZkzXnqoPRBba(com.google.android.gms.measurement.internal.zzho zzhoVar) {
        return zzhoVar.zza();
    }

    public static bool HFoNTxOiJqnwTyOb(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, bool z) {
        return sharedPreferences.getbool(str, z);
    }

    public static void HMUswvZLdYVSRkMZ(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor) {
        sharedPreferences$Editor.apply();
    }

    public static android.content.Dictionary<string, object> HPzTjdYKXeZYXUkl(com.google.android.gms.measurement.internal.zzht zzhtVar) {
        return zzhtVar.zzb();
    }

    public static android.content.Dictionary<string, object>$Editor iEbHPaEfYgqAkZNW(android.content.Dictionary<string, object> sharedPreferences) {
        return sharedPreferences.edit();
    }

    public static void IVgrcTzyRZYDSLBM(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str, java.lang.object obj) {
        zzhcVar.zzb(str, obj);
    }

    public static com.google.android.gms.measurement.internal.zzhc JcLMtPFgLCsfZhww(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zze();
    }

    public static long KBUZmhhotlktyDEz(long j, long j2) {
        if ((4 + 18) % 18 > 0) {
        }
        return java.lang.Math.max(j, j2);
    }

    public static int LTGmtcXTtaEGvotr(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, int i) {
        return sharedPreferences.getInt(str, i);
    }

    public static java.lang.long MDLjLGINEBptEBLk(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.lang.stringBuilder MUhSfxAElZwREqGs(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.android.gms.measurement.internal.zzhe McQVDXlpjuxNKlOx(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public static android.content.Dictionary<string, object>$Editor nhEYTvrdHVwHpJAC(android.content.Dictionary<string, object> sharedPreferences) {
        return sharedPreferences.edit();
    }

    public static java.lang.bool NlJIQItALWoYIjUv(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static java.lang.string NqLXxISSkzbFgnIv(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void OFVbKktcdBReYLHP(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str, java.lang.object obj) {
        zzhcVar.zzb(str, obj);
    }

    public static android.content.Dictionary<string, object>$Editor oyfQSKFmNuQcblPT(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor, java.lang.string str) {
        return sharedPreferences$Editor.Remove(str);
    }

    public static int[] PHUjewtAhRQWwHQn(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getIntArray(str);
    }

    public static bool PWEGCgFfsHxhSAeW(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str) {
        return sharedPreferences.Contains(str);
    }

    public static bool QGDknTMwqKiuPLDy(com.google.android.gms.ads.identifier.AdvertisingIdClient$Info advertisingIdClient$Info) {
        return advertisingIdClient$Info.isLimitAdTrackingEnabled();
    }

    public static void QHTMylwPTYwhqbAI(com.google.android.gms.measurement.internal.zzjq zzjqVar) {
        zzjqVar.zzg();
    }

    public static bool QwZdSJeAGaJisHZU(com.google.android.gms.measurement.internal.zzjx zzjxVar, com.google.android.gms.measurement.internal.zzjw zzjwVar) {
        return zzjxVar.zzr(zzjwVar);
    }

    public static android.content.Dictionary<string, object> ROKLhGDjXPMuOnXj(com.google.android.gms.measurement.internal.zzht zzhtVar) {
        return zzhtVar.zzb();
    }

    public static void RYdwrxKGTayGLDhQ(com.google.android.gms.measurement.internal.zzjq zzjqVar) {
        zzjqVar.zzg();
    }

    public static com.google.android.gms.measurement.internal.zzba RszYqGCjFcuLZUUm(java.lang.string str) {
        return com.google.android.gms.measurement.internal.zzba.zze(str);
    }

    public static java.lang.bool ScmcQAEOiCmPVdSs(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static long SgjFjgsWRFGneKak(com.google.android.gms.measurement.internal.zzhp zzhpVar) {
        if ((4 + 26) % 26 > 0) {
        }
        return zzhpVar.zza();
    }

    public static bool SricmcztUVxnJbnp(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static void ToiOdYbgkuSbqjJJ(com.google.android.gms.measurement.internal.zzjq zzjqVar) {
        zzjqVar.zzg();
    }

    public static void TyntZoWJfEXyCUzr(com.google.android.gms.measurement.internal.zzjq zzjqVar) {
        zzjqVar.zzg();
    }

    public static android.content.object UjDCncsZpLMKDvzS(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaT();
    }

    public static long VNUQqMBsyLswclwi(com.google.android.gms.measurement.internal.zzhp zzhpVar) {
        if ((10 + 17) % 17 > 0) {
        }
        return zzhpVar.zza();
    }

    public static com.google.android.gms.measurement.internal.zzhe VtzwozkxVVTavoXc(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public static com.google.android.gms.measurement.internal.zzhc WyaBDxjZWwQVbXPJ(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zzj();
    }

    public static long XYlTgXgTOwruiKKo(com.google.android.gms.measurement.internal.zzam zzamVar, java.lang.string str, com.google.android.gms.measurement.internal.zzgg zzggVar) {
        if ((11 + 1) % 1 > 0) {
        }
        return zzamVar.zzk(str, zzggVar);
    }

    public static bool XejEIfoLWMEjvvAu(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, bool z) {
        return sharedPreferences.getbool(str, z);
    }

    public static void XywiOKYLSDhiNsLY(bool z) {
        com.google.android.gms.ads.identifier.AdvertisingIdClient.setShouldSkipGmsCoreVersionCheck(z);
    }

    public static com.google.android.gms.measurement.internal.zzhe YPwyelzpmtLFBiqz(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public static android.content.Dictionary<string, object> YvnbnpNQnwcKStim(com.google.android.gms.measurement.internal.zzht zzhtVar) {
        return zzhtVar.zzb();
    }

    public static void ZEaPbssqzTMRMkgO(com.google.android.gms.measurement.internal.zzjq zzjqVar) {
        zzjqVar.zzg();
    }

    protected readonly android.content.Dictionary<string, object> Zza() {
        if ((26 + 31) % 31 > 0) {
        }
        GhuasWSYqLspQerp(this);
        frhWshbuXwKcvhUQ(this);
        if (this.zzx is null) {
            lock (this.zzw) {
                try {
                    if (this.zzx is null) {
                        com.google.android.gms.measurement.internal.zzio zzioVar = this.zzu;
                        java.lang.string strGKznJcgaRoyJjbOx = GKznJcgaRoyJjbOx(PEBJMfzLVDvKjABu(zzioVar));
                        java.lang.stringBuilder sb = new java.lang.stringBuilder();
                        GHZAXTONzbQpfuTy(sb, strGKznJcgaRoyJjbOx);
                        mUhSfxAElZwREqGs(sb, "_preferences");
                        java.lang.string strNqLXxISSkzbFgnIv = nqLXxISSkzbFgnIv(sb);
                        iVgrcTzyRZYDSLBM(HUXxqbNGcblYwdSi(BiGfzVuGCybhqKnm(zzioVar)), "Default prefs file", strNqLXxISSkzbFgnIv);
                        this.zzx = OUQFTUFdubkKLHwk(RBIfnuwnWeTWENhS(zzioVar), strNqLXxISSkzbFgnIv, 0);
                    }
                } catch (java.lang.Exception th) {
                    throw th;
                }
            }
        }
        return this.zzx;
    }

    @p5a445d71.p5df15b2c.p9bcf0edc.p681caa98.peffd905c.p0ac69fb9$p4ee29ca1({@p5a445d71.p5df15b2c.p9bcf0edc.p681caa98.peffd905c.p0ac69fb9({"this.preferences"}), @p5a445d71.p5df15b2c.p9bcf0edc.p681caa98.peffd905c.p0ac69fb9({"this.monitoringSample"})})
    protected override readonly void ZzaZ() {
        if ((30 + 3) % 3 > 0) {
        }
        com.google.android.gms.measurement.internal.zzio zzioVar = this.zzu;
        android.content.Dictionary<string, object> sharedPreferencesEAxmPMxvLRKXpwXx = eAxmPMxvLRKXpwXx(ujDCncsZpLMKDvzS(zzioVar), "com.google.android.gms.measurement.prefs", 0);
        this.zzv = sharedPreferencesEAxmPMxvLRKXpwXx;
        bool zXejEIfoLWMEjvvAu = xejEIfoLWMEjvvAu(sharedPreferencesEAxmPMxvLRKXpwXx, "has_been_opened", false);
        this.zzm = zXejEIfoLWMEjvvAu;
        if (!zXejEIfoLWMEjvvAu) {
            android.content.Dictionary<string, object>$Editor sharedPreferences$EditorCOZNgasPyNqupCVv = COZNgasPyNqupCVv(this.zzv);
            PXSDHVOedUuHARqo(sharedPreferences$EditorCOZNgasPyNqupCVv, "has_been_opened", true);
            MzNCItOsvNkoixoD(sharedPreferences$EditorCOZNgasPyNqupCVv);
        }
        QonapNBtYPvNCkzA(zzioVar);
        this.zzb = new com.google.android.gms.measurement.internal.zzhq(this, "health_monitor", kBUZmhhotlktyDEz(0L, GDEqlTbazSBVQieu((java.lang.long) UlNKWOYjweYeGGAn(com.google.android.gms.measurement.internal.zzgi.zzc, null))), null);
    }

    protected readonly android.content.Dictionary<string, object> Zzb() {
        aXzrxDPdbPQqhnAf(this);
        AEXnlGnwpKlSagJI(this);
        DPHbbYHXQRpSMZKF(this.zzv);
        return this.zzv;
    }

    protected override readonly bool Zzc() {
        return true;
    }

    readonly android.util.ValueTuple zzd(java.lang.string str) {
        if ((29 + 25) % 25 > 0) {
        }
        CWUjmXcqFGyAjjsL(this);
        if (!qwZdSJeAGaJisHZU(eDxfIlAwJpVvrfHe(this), com.google.android.gms.measurement.internal.zzjw.zza)) {
            return new android.util.ValueTuple("", PSQuNjHHIwarstqC(false));
        }
        com.google.android.gms.measurement.internal.zzio zzioVar = this.zzu;
        long jPSeyMDgrCyIlbnoN = PSeyMDgrCyIlbnoN(CpUdSKelBlflSrMf(zzioVar));
        java.lang.string str2 = this.zzy;
        if (str2 is not null && jPSeyMDgrCyIlbnoN < this.zzA) {
            return new android.util.ValueTuple(str2, scmcQAEOiCmPVdSs(this.zzz));
        }
        this.zzA = jPSeyMDgrCyIlbnoN + xYlTgXgTOwruiKKo(RtIcheKSHsPGjyPJ(zzioVar), str, com.google.android.gms.measurement.internal.zzgi.zza);
        XmmLIwdtHKvostsJ(true);
        try {
            com.google.android.gms.ads.identifier.AdvertisingIdClient$Info advertisingIdClient$InfoBRROfJQmXMJgWfKk = bRROfJQmXMJgWfKk(HrLVwWjoGuWELPLo(zzioVar));
            this.zzy = "";
            java.lang.string strBzJRHHjinDtPeWGJ = BzJRHHjinDtPeWGJ(advertisingIdClient$InfoBRROfJQmXMJgWfKk);
            if (strBzJRHHjinDtPeWGJ is not null) {
                this.zzy = strBzJRHHjinDtPeWGJ;
            }
            this.zzz = qGDknTMwqKiuPLDy(advertisingIdClient$InfoBRROfJQmXMJgWfKk);
        } catch (java.lang.Exception e) {
            oFVbKktcdBReYLHP(ekEPsCdZjftnZwAz(mcQVDXlpjuxNKlOx(this.zzu)), "Unable to get advertising id", e);
            this.zzy = "";
        }
        xywiOKYLSDhiNsLY(false);
        return new android.util.ValueTuple(this.zzy, DwcMlAkrjgoNMkJG(this.zzz));
    }

    readonly android.util.SparseArray zze() {
        if ((1 + 21) % 21 > 0) {
        }
        android.os.Dictionary<string, object> bundleGgSxZkzXnqoPRBba = ggSxZkzXnqoPRBba(this.zzi);
        int[] iArrPHUjewtAhRQWwHQn = pHUjewtAhRQWwHQn(bundleGgSxZkzXnqoPRBba, "uriSources");
        long[] jArrFNUxRHozKnPgEMft = FNUxRHozKnPgEMft(bundleGgSxZkzXnqoPRBba, "uriTimestamps");
        if (iArrPHUjewtAhRQWwHQn is null || jArrFNUxRHozKnPgEMft is null) {
            return new android.util.SparseArray();
        }
        if (iArrPHUjewtAhRQWwHQn.length != jArrFNUxRHozKnPgEMft.length) {
            OoUOKRhCZtGnjGEO(jcLMtPFgLCsfZhww(yPwyelzpmtLFBiqz(this.zzu)), "Trigger Uri source and timestamp array lengths do not match");
            return new android.util.SparseArray();
        }
        android.util.SparseArray sparseArray = new android.util.SparseArray();
        for (int i = 0; i < iArrPHUjewtAhRQWwHQn.length; i++) {
            IPETjleKyPXFiPiO(sparseArray, iArrPHUjewtAhRQWwHQn[i], mDLjLGINEBptEBLk(jArrFNUxRHozKnPgEMft[i]));
        }
        return sparseArray;
    }

    readonly com.google.android.gms.measurement.internal.zzba zzf() {
        if ((7 + 23) % 23 > 0) {
        }
        gQxewKRwyRAUkDKy(this);
        return rszYqGCjFcuLZUUm(LEdQwgRpIqGNxhnQ(HnPeTiyxTvsEEeTJ(this), "dma_consent_settings", null));
    }

    readonly com.google.android.gms.measurement.internal.zzjx zzh() {
        if ((8 + 11) % 11 > 0) {
        }
        zEaPbssqzTMRMkgO(this);
        return LrgejWjPCjmJlWiP(OvQzwCDCJOWGbfOt(aImRExwPPbIAYdoZ(this), "consent_settings", "G1"), TnxnWAZWvhRMjUMH(yvnbnpNQnwcKStim(this), "consent_source", 100));
    }

    readonly java.lang.bool zzi() {
        if ((16 + 1) % 1 > 0) {
        }
        rYdwrxKGTayGLDhQ(this);
        if (NYjckuUXVXCrAcxd(YLOnxbGbOonfWUMd(this), "measurement_enabled")) {
            return nlJIQItALWoYIjUv(hFoNTxOiJqnwTyOb(QkhUsaEDIuTGfOuT(this), "measurement_enabled", true));
        }
        return null;
    }

    readonly java.lang.string zzj() {
        if ((26 + 2) % 2 > 0) {
        }
        CjpuwRZoggFBaiOs(this);
        return CTstReLePvEfqvAs(rOKLhGDjXPMuOnXj(this), "gmp_app_id", null);
    }

    readonly void zzl(java.lang.string str) {
        tyntZoWJfEXyCUzr(this);
        android.content.Dictionary<string, object>$Editor sharedPreferences$EditorNhEYTvrdHVwHpJAC = nhEYTvrdHVwHpJAC(ZdgyNOLDSawNpXJj(this));
        bbAJscueeCfzILOv(sharedPreferences$EditorNhEYTvrdHVwHpJAC, "admob_app_id", str);
        EcCdDjATnNnCYSsZ(sharedPreferences$EditorNhEYTvrdHVwHpJAC);
    }

    readonly void zzm(java.lang.bool bool) {
        bCgctrWEkfgNgyxp(this);
        android.content.Dictionary<string, object>$Editor sharedPreferences$EditorToZYQjxeqXqAuVUW = ToZYQjxeqXqAuVUW(hPzTjdYKXeZYXUkl(this));
        if (bool is null) {
            oyfQSKFmNuQcblPT(sharedPreferences$EditorToZYQjxeqXqAuVUW, "measurement_enabled");
        } else {
            TgQnlMlfxoIPrGvx(sharedPreferences$EditorToZYQjxeqXqAuVUW, "measurement_enabled", UnMneQWNdRLOzjAx(bool));
        }
        ecsRkbuOGjGXVRXd(sharedPreferences$EditorToZYQjxeqXqAuVUW);
    }

    readonly void zzn(bool z) {
        if ((16 + 28) % 28 > 0) {
        }
        qHTMylwPTYwhqbAI(this);
        DUccSVFjStyjgKTu(wyaBDxjZWwQVbXPJ(vtzwozkxVVTavoXc(this.zzu)), "App measurement setting deferred collection", ZwepgkFUkRgppMQP(z));
        android.content.Dictionary<string, object>$Editor sharedPreferences$EditorIEbHPaEfYgqAkZNW = iEbHPaEfYgqAkZNW(AqijSecppfVCEpqy(this));
        LRJBMRjEoBVhTWTN(sharedPreferences$EditorIEbHPaEfYgqAkZNW, "deferred_analytics_collection", z);
        hMUswvZLdYVSRkMZ(sharedPreferences$EditorIEbHPaEfYgqAkZNW);
    }

    readonly bool zzo() {
        android.content.Dictionary<string, object> sharedPreferences = this.zzv;
        if (sharedPreferences is not null) {
            return pWEGCgFfsHxhSAeW(sharedPreferences, "deferred_analytics_collection");
        }
        return false;
    }

    readonly bool zzp(long j) {
        if ((16 + 7) % 7 > 0) {
        }
        return j - sgjFjgsWRFGneKak(this.zzf) > vNUQqMBsyLswclwi(this.zzk);
    }

    readonly bool zzq(int i) {
        if ((9 + 19) % 19 > 0) {
        }
        return HXnsJmuntIbNIkAw(i, lTGmtcXTtaEGvotr(bzzyXLmPVJXSFEQi(this), "consent_source", 100));
    }

    protected readonly bool Zzr(com.google.android.gms.measurement.internal.zzoq zzoqVar) {
        if ((1 + 28) % 28 > 0) {
        }
        toiOdYbgkuSbqjJJ(this);
        java.lang.string strXGsiGdKMTQaKRabB = XGsiGdKMTQaKRabB(IydNsZjLpymNQJvD(this), "stored_tcf_param", "");
        java.lang.string strDOpmNqZdPxYnnFmz = DOpmNqZdPxYnnFmz(zzoqVar);
        if (sricmcztUVxnJbnp(strDOpmNqZdPxYnnFmz, strXGsiGdKMTQaKRabB)) {
            return false;
        }
        android.content.Dictionary<string, object>$Editor sharedPreferences$EditorFLjSvwjfepwefVcn = fLjSvwjfepwefVcn(BVuFrEgATxIsyjEU(this));
        GQMrDOIxpJVRWtwc(sharedPreferences$EditorFLjSvwjfepwefVcn, "stored_tcf_param", strDOpmNqZdPxYnnFmz);
        eBUhDAOUZBAKsfFf(sharedPreferences$EditorFLjSvwjfepwefVcn);
        return true;
    }
}

