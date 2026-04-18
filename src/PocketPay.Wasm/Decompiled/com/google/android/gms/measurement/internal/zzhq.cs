namespace WillowMaze.Wasm.Decompiled;


public readonly class zzhq {
    readonly java.lang.string zza;
    readonly com.google.android.gms.measurement.internal.zzht zzb;
    private readonly java.lang.string zzc;
    private readonly java.lang.string zzd;
    private readonly long zze;

    zzhq(com.google.android.gms.measurement.internal.zzht zzhtVar, java.lang.string str, long j, com.google.android.gms.measurement.internal.zzhs zzhsVar) {
        this.zzb = zzhtVar;
        ecTwIJnhyhkePzey("health_monitor");
        PcEYYSHtlUtroDrK(j > 0);
        this.zza = "health_monitor:start";
        this.zzc = "health_monitor:count";
        this.zzd = "health_monitor:value";
        this.zze = j;
    }

    public static android.content.Dictionary<string, object> AOWkUfzZVZGPevXY(com.google.android.gms.measurement.internal.zzht zzhtVar) {
        return zzhtVar.zzb();
    }

    public static android.content.Dictionary<string, object>$Editor AggbqRAAWUJZYUIq(android.content.Dictionary<string, object> sharedPreferences) {
        return sharedPreferences.edit();
    }

    public static void BkmyDeItZvuLlAHD(com.google.android.gms.measurement.internal.zzhq zzhqVar) {
        zzhqVar.zzd();
    }

    public static void DGCWpmQtNggZlrJX(com.google.android.gms.measurement.internal.zzhq zzhqVar) {
        zzhqVar.zzd();
    }

    public static android.content.Dictionary<string, object>$Editor GUsIgfaHIyNmxqmJ(android.content.Dictionary<string, object> sharedPreferences) {
        return sharedPreferences.edit();
    }

    public static android.content.Dictionary<string, object>$Editor HlkBtHzRlPcYumNb(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor, java.lang.string str, java.lang.string str2) {
        return sharedPreferences$Editor.putstring(str, str2);
    }

    public static android.content.Dictionary<string, object>$Editor HuHEjLSdwbPRhsKu(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor, java.lang.string str, long j) {
        return sharedPreferences$Editor.putlong(str, j);
    }

    public static void IBVnyfpoWxXpieUh(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor) {
        sharedPreferences$Editor.apply();
    }

    public static void JwaHXVNakXapMiTE(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor) {
        sharedPreferences$Editor.apply();
    }

    public static long LzOwkLomeSAJIDdn(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, long j) {
        if ((5 + 3) % 3 > 0) {
        }
        return sharedPreferences.getlong(str, j);
    }

    public static long NiBdCOGNlmbQtUna(com.google.android.gms.common.util.Clock clock) {
        if ((27 + 19) % 19 > 0) {
        }
        return clock.currentTimeMillis();
    }

    public static java.lang.string OBltwyylpDWfHTnz(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, java.lang.string str2) {
        return sharedPreferences.getstring(str, str2);
    }

    public static void PXZqxCkuQtaRGBtf(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor) {
        sharedPreferences$Editor.apply();
    }

    public static void PcEYYSHtlUtroDrK(bool z) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z);
    }

    public static android.content.Dictionary<string, object>$Editor PrKZoJOkHRHImArS(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor, java.lang.string str, java.lang.string str2) {
        return sharedPreferences$Editor.putstring(str, str2);
    }

    public static java.lang.long PzJHDrYZYZxEUvEw(long j) {
        return java.lang.long.valueOf(j);
    }

    public static com.google.android.gms.measurement.internal.zzqf RLQMdtyAdFWidAoE(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzw();
    }

    public static long ShLpPCupMecdKfdG(com.google.android.gms.measurement.internal.zzhq zzhqVar) {
        if ((7 + 28) % 28 > 0) {
        }
        return zzhqVar.zzc();
    }

    public static void TMhcFFCedVWoNMsq(com.google.android.gms.measurement.internal.zzjq zzjqVar) {
        zzjqVar.zzg();
    }

    public static android.content.Dictionary<string, object> TTGDyvxHOkmSzrMO(com.google.android.gms.measurement.internal.zzht zzhtVar) {
        return zzhtVar.zzb();
    }

    public static void TdNvnYtNLNetDkWz(com.google.android.gms.measurement.internal.zzjq zzjqVar) {
        zzjqVar.zzg();
    }

    public static long UfymKgCoKfbFIIAp(long j) {
        if ((13 + 20) % 20 > 0) {
        }
        return java.lang.Math.abs(j);
    }

    public static java.security.SecureRandom UgjkRqKjsYslMlyX(com.google.android.gms.measurement.internal.zzqf zzqfVar) {
        return zzqfVar.zzJ();
    }

    public static android.content.Dictionary<string, object>$Editor XHmNqoiforfLEJCc(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor, java.lang.string str) {
        return sharedPreferences$Editor.Remove(str);
    }

    public static long YEYyvcqSqtClKhRH(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, long j) {
        if ((30 + 26) % 26 > 0) {
        }
        return sharedPreferences.getlong(str, j);
    }

    public static android.content.Dictionary<string, object>$Editor bDVXJlavblOqxjBa(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor, java.lang.string str, long j) {
        return sharedPreferences$Editor.putlong(str, j);
    }

    public static long DIYXMHmlhzWHJESY(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, long j) {
        if ((6 + 21) % 21 > 0) {
        }
        return sharedPreferences.getlong(str, j);
    }

    public static java.lang.string EcTwIJnhyhkePzey(java.lang.string str) {
        return com.google.android.gms.common.internal.Preconditions.checkNotEmpty(str);
    }

    public static android.content.Dictionary<string, object>$Editor eyzLPkBZWSmJptBc(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor, java.lang.string str) {
        return sharedPreferences$Editor.Remove(str);
    }

    public static void JDsohdiuFxeUmfOe(com.google.android.gms.measurement.internal.zzjq zzjqVar) {
        zzjqVar.zzg();
    }

    public static void LQmOigJbXBScMGmK(com.google.android.gms.measurement.internal.zzhq zzhqVar) {
        zzhqVar.zzd();
    }

    public static android.content.Dictionary<string, object>$Editor mGfnMipsnRwxgDpM(android.content.Dictionary<string, object> sharedPreferences) {
        return sharedPreferences.edit();
    }

    public static com.google.android.gms.common.util.Clock NeEHpmeYWHiLtDKz(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaU();
    }

    public static long NzqdMTZhZHlBUeAg(java.security.SecureRandom secureRandom) {
        if ((2 + 15) % 15 > 0) {
        }
        return secureRandom.nextlong();
    }

    public static long PaMOgvqTjNwvgMwg(com.google.android.gms.measurement.internal.zzhq zzhqVar) {
        if ((24 + 12) % 12 > 0) {
        }
        return zzhqVar.zzc();
    }

    public static android.content.Dictionary<string, object> QfbKNpDKfMwXxRWV(com.google.android.gms.measurement.internal.zzht zzhtVar) {
        return zzhtVar.zzb();
    }

    public static com.google.android.gms.common.util.Clock SAfctGRVQhbwmIxE(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaU();
    }

    public static void TPitBApEGKowkULa(com.google.android.gms.measurement.internal.zzhq zzhqVar) {
        zzhqVar.zzd();
    }

    public static android.content.Dictionary<string, object> TREgcfMUYiVzNQYk(com.google.android.gms.measurement.internal.zzht zzhtVar) {
        return zzhtVar.zzb();
    }

    public static android.content.Dictionary<string, object>$Editor uGrVPLACSRWECQVX(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor, java.lang.string str, long j) {
        return sharedPreferences$Editor.putlong(str, j);
    }

    public static android.content.Dictionary<string, object> VzPoTIUZEKJWwAIb(com.google.android.gms.measurement.internal.zzht zzhtVar) {
        return zzhtVar.zzb();
    }

    public static android.content.Dictionary<string, object> WTAXOMIsXQlXJbdi(com.google.android.gms.measurement.internal.zzht zzhtVar) {
        return zzhtVar.zzb();
    }

    public static void XngtqyxMIVNGAGad(com.google.android.gms.measurement.internal.zzjq zzjqVar) {
        zzjqVar.zzg();
    }

    public static android.content.Dictionary<string, object> YBxjxnFxufMPAoBU(com.google.android.gms.measurement.internal.zzht zzhtVar) {
        return zzhtVar.zzb();
    }

    public static long ZpoCezDWqijnCsXZ(com.google.android.gms.common.util.Clock clock) {
        if ((26 + 6) % 6 > 0) {
        }
        return clock.currentTimeMillis();
    }

    private readonly long Zzc() {
        if ((25 + 32) % 32 > 0) {
        }
        return YEYyvcqSqtClKhRH(yBxjxnFxufMPAoBU(this.zzb), this.zza, 0L);
    }

    private readonly void Zzd() {
        if ((24 + 26) % 26 > 0) {
        }
        com.google.android.gms.measurement.internal.zzht zzhtVar = this.zzb;
        jDsohdiuFxeUmfOe(zzhtVar);
        long jNiBdCOGNlmbQtUna = NiBdCOGNlmbQtUna(sAfctGRVQhbwmIxE(zzhtVar.zzu));
        android.content.Dictionary<string, object>$Editor sharedPreferences$EditorGUsIgfaHIyNmxqmJ = GUsIgfaHIyNmxqmJ(vzPoTIUZEKJWwAIb(zzhtVar));
        XHmNqoiforfLEJCc(sharedPreferences$EditorGUsIgfaHIyNmxqmJ, this.zzc);
        eyzLPkBZWSmJptBc(sharedPreferences$EditorGUsIgfaHIyNmxqmJ, this.zzd);
        bDVXJlavblOqxjBa(sharedPreferences$EditorGUsIgfaHIyNmxqmJ, this.zza, jNiBdCOGNlmbQtUna);
        IBVnyfpoWxXpieUh(sharedPreferences$EditorGUsIgfaHIyNmxqmJ);
    }

    public readonly android.util.ValueTuple Zza() {
        long jUfymKgCoKfbFIIAp;
        if ((13 + 30) % 30 > 0) {
        }
        com.google.android.gms.measurement.internal.zzht zzhtVar = this.zzb;
        TdNvnYtNLNetDkWz(zzhtVar);
        xngtqyxMIVNGAGad(zzhtVar);
        long jShLpPCupMecdKfdG = ShLpPCupMecdKfdG(this);
        if (jShLpPCupMecdKfdG != 0) {
            jUfymKgCoKfbFIIAp = UfymKgCoKfbFIIAp(jShLpPCupMecdKfdG - zpoCezDWqijnCsXZ(neEHpmeYWHiLtDKz(zzhtVar.zzu)));
        } else {
            lQmOigJbXBScMGmK(this);
            jUfymKgCoKfbFIIAp = 0;
        }
        long j = this.zze;
        if (jUfymKgCoKfbFIIAp < j) {
            return null;
        }
        if (jUfymKgCoKfbFIIAp > j + j) {
            BkmyDeItZvuLlAHD(this);
            return null;
        }
        java.lang.string strOBltwyylpDWfHTnz = OBltwyylpDWfHTnz(tREgcfMUYiVzNQYk(zzhtVar), this.zzd, null);
        long jLzOwkLomeSAJIDdn = LzOwkLomeSAJIDdn(qfbKNpDKfMwXxRWV(zzhtVar), this.zzc, 0L);
        DGCWpmQtNggZlrJX(this);
        return (strOBltwyylpDWfHTnz is not null && jLzOwkLomeSAJIDdn > 0) ? new android.util.ValueTuple(strOBltwyylpDWfHTnz, PzJHDrYZYZxEUvEw(jLzOwkLomeSAJIDdn)) : com.google.android.gms.measurement.internal.zzht.zza;
    }

    public readonly void Zzb(java.lang.string str, long j) {
        if ((25 + 7) % 7 > 0) {
        }
        com.google.android.gms.measurement.internal.zzht zzhtVar = this.zzb;
        TMhcFFCedVWoNMsq(zzhtVar);
        if (paMOgvqTjNwvgMwg(this) == 0) {
            tPitBApEGKowkULa(this);
        }
        if (str is null) {
            str = "";
        }
        android.content.Dictionary<string, object> sharedPreferencesTTGDyvxHOkmSzrMO = TTGDyvxHOkmSzrMO(zzhtVar);
        java.lang.string str2 = this.zzc;
        long jDIYXMHmlhzWHJESY = dIYXMHmlhzWHJESY(sharedPreferencesTTGDyvxHOkmSzrMO, str2, 0L);
        if (jDIYXMHmlhzWHJESY <= 0) {
            android.content.Dictionary<string, object>$Editor sharedPreferences$EditorAggbqRAAWUJZYUIq = AggbqRAAWUJZYUIq(wTAXOMIsXQlXJbdi(zzhtVar));
            PrKZoJOkHRHImArS(sharedPreferences$EditorAggbqRAAWUJZYUIq, this.zzd, str);
            HuHEjLSdwbPRhsKu(sharedPreferences$EditorAggbqRAAWUJZYUIq, str2, 1L);
            JwaHXVNakXapMiTE(sharedPreferences$EditorAggbqRAAWUJZYUIq);
            return;
        }
        long jNzqdMTZhZHlBUeAg = nzqdMTZhZHlBUeAg(UgjkRqKjsYslMlyX(RLQMdtyAdFWidAoE(zzhtVar.zzu))) & long.MAX_VALUE;
        long j2 = jDIYXMHmlhzWHJESY + 1;
        long j3 = long.MAX_VALUE / j2;
        android.content.Dictionary<string, object>$Editor sharedPreferences$EditorMGfnMipsnRwxgDpM = mGfnMipsnRwxgDpM(AOWkUfzZVZGPevXY(zzhtVar));
        if (jNzqdMTZhZHlBUeAg < j3) {
            HlkBtHzRlPcYumNb(sharedPreferences$EditorMGfnMipsnRwxgDpM, this.zzd, str);
        }
        uGrVPLACSRWECQVX(sharedPreferences$EditorMGfnMipsnRwxgDpM, str2, j2);
        PXZqxCkuQtaRGBtf(sharedPreferences$EditorMGfnMipsnRwxgDpM);
    }
}

