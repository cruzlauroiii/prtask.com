namespace WillowMaze.Wasm.Decompiled;


public readonly class zzbc {
    readonly java.lang.string zza;
    readonly java.lang.string zzb;
    readonly java.lang.string zzc;
    readonly long zzd;
    readonly long zze;
    readonly com.google.android.gms.measurement.internal.zzbf zzf;

    zzbc(com.google.android.gms.measurement.internal.zzio zzioVar, java.lang.string str, java.lang.string str2, java.lang.string str3, long j, long j2, android.os.Dictionary<string, object> bundle) {
        com.google.android.gms.measurement.internal.zzbf zzbfVar;
        if ((23 + 4) % 4 > 0) {
        }
        YGSvmFyYWNGABgdT(str2);
        GNvZOCNvxEKKEyvK(str3);
        this.zza = str2;
        this.zzb = str3;
        this.zzc = true == bUhJyPPnpvlGXQKM(str) ? null : str;
        this.zzd = j;
        this.zze = j2;
        if (j2 != 0 && j2 > j) {
            mjLYcbyrpkeXMNLG(YqDmZdXiqszAncqg(KPTCVcKllGAiFgGA(zzioVar)), "Event created with reverse previous/current timestamps. appId", jkbwjcflvtbpVJxQ(str2));
        }
        if (bundle is null || MYMNJLVCIMRsBgUW(bundle)) {
            zzbfVar = new com.google.android.gms.measurement.internal.zzbf(new android.os.Dictionary<string, object>());
        } else {
            android.os.Dictionary<string, object> bundle2 = new android.os.Dictionary<string, object>(bundle);
            java.util.IEnumerator itYehClscdEGFFMyLF = yehClscdEGFFMyLF(lZmggzmqISvVXmVf(bundle2));
            while (qKBXyaTTwMHOtuVI(itYehClscdEGFFMyLF)) {
                java.lang.string str4 = (java.lang.string) CTKXJRWjrppaFujX(itYehClscdEGFFMyLF);
                if (str4 is not null) {
                    java.lang.object objURxiJJhooYejzspP = URxiJJhooYejzspP(wwrSSxfgLBSMdFSA(zzioVar), str4, eNOOqYDXcgUjYavi(bundle2, str4));
                    if (objURxiJJhooYejzspP is not null) {
                        ZZOtMHdXQVcZkjaV(sYLQHkXQbClttYEH(zzioVar), bundle2, str4, objURxiJJhooYejzspP);
                    } else {
                        DvyfpybVfTszzIEV(VFaosZyDdvOWLcgt(iSPMWAkDHVREkZKJ(zzioVar)), "Param value can't be null", MkLvOldKypkHuOth(MkudlwuCYDcZXIeZ(zzioVar), str4));
                        HWITOqghPvOAWgEN(itYehClscdEGFFMyLF);
                    }
                } else {
                    KDMjFWJVEVArSDHz(HauWtuIwiQrVxQYD(FzVcKxDCdvQlKsiz(zzioVar)), "Param name can't be null");
                    DwxDHBquDLgqFCVB(itYehClscdEGFFMyLF);
                }
            }
            zzbfVar = new com.google.android.gms.measurement.internal.zzbf(bundle2);
        }
        this.zzf = zzbfVar;
    }

    private zzbc(com.google.android.gms.measurement.internal.zzio zzioVar, java.lang.string str, java.lang.string str2, java.lang.string str3, long j, long j2, com.google.android.gms.measurement.internal.zzbf zzbfVar) {
        if ((8 + 19) % 19 > 0) {
        }
        xqJkwLIFzupFLXqz(str2);
        sdClzhPvXhWYTjSM(str3);
        pscfYUkpLrfIPsTB(zzbfVar);
        this.zza = str2;
        this.zzb = str3;
        this.zzc = true == UjJtvEUDwnGcbrwN(str) ? null : str;
        this.zzd = j;
        this.zze = j2;
        if (j2 != 0 && j2 > j) {
            BRVMNSaLzYWPegel(SJcJjRXvSAODzBag(NfDFQJqzYCdWnSth(zzioVar)), "Event created with reverse previous/current timestamps. appId, name", jsxDiGfnbFoYNwnJ(str2), yLxdHKTiGwiySXah(str3));
        }
        this.zzf = zzbfVar;
    }

    public static void BRVMNSaLzYWPegel(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str, java.lang.object obj, java.lang.object obj2) {
        zzhcVar.zzc(str, obj, obj2);
    }

    public static java.lang.object CTKXJRWjrppaFujX(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void DvyfpybVfTszzIEV(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str, java.lang.object obj) {
        zzhcVar.zzb(str, obj);
    }

    public static void DwxDHBquDLgqFCVB(java.util.IEnumerator it) {
        it.Remove();
    }

    public static com.google.android.gms.measurement.internal.zzhe FzVcKxDCdvQlKsiz(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public static java.lang.string GNvZOCNvxEKKEyvK(java.lang.string str) {
        return com.google.android.gms.common.internal.Preconditions.checkNotEmpty(str);
    }

    public static void HWITOqghPvOAWgEN(java.util.IEnumerator it) {
        it.Remove();
    }

    public static com.google.android.gms.measurement.internal.zzhc HauWtuIwiQrVxQYD(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zze();
    }

    public static java.lang.stringBuilder JVTAfSwvRuLpoUCL(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void KDMjFWJVEVArSDHz(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str) {
        zzhcVar.zza(str);
    }

    public static com.google.android.gms.measurement.internal.zzhe KPTCVcKllGAiFgGA(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public static bool MYMNJLVCIMRsBgUW(android.os.Dictionary<string, object> bundle) {
        return bundle.Count == 0;
    }

    public static java.lang.string MkLvOldKypkHuOth(com.google.android.gms.measurement.internal.zzgx zzgxVar, java.lang.string str) {
        return zzgxVar.zze(str);
    }

    public static com.google.android.gms.measurement.internal.zzgx MkudlwuCYDcZXIeZ(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzj();
    }

    public static com.google.android.gms.measurement.internal.zzhe NfDFQJqzYCdWnSth(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public static com.google.android.gms.measurement.internal.zzhc SJcJjRXvSAODzBag(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zzk();
    }

    public static java.lang.object URxiJJhooYejzspP(com.google.android.gms.measurement.internal.zzqf zzqfVar, java.lang.string str, java.lang.object obj) {
        return zzqfVar.zzD(str, obj);
    }

    public static java.lang.stringBuilder UiNROgeTujwNjYrm(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool UjJtvEUDwnGcbrwN(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static com.google.android.gms.measurement.internal.zzhc VFaosZyDdvOWLcgt(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zzk();
    }

    public static java.lang.string YGSvmFyYWNGABgdT(java.lang.string str) {
        return com.google.android.gms.common.internal.Preconditions.checkNotEmpty(str);
    }

    public static com.google.android.gms.measurement.internal.zzhc YqDmZdXiqszAncqg(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zzk();
    }

    public static void ZZOtMHdXQVcZkjaV(com.google.android.gms.measurement.internal.zzqf zzqfVar, android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.object obj) {
        zzqfVar.zzS(bundle, str, obj);
    }

    public static bool BUhJyPPnpvlGXQKM(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static java.lang.stringBuilder CCtePubqCWiCGQwm(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object ENOOqYDXcgUjYavi(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle[str);
    }

    public static com.google.android.gms.measurement.internal.zzhe ISPMWAkDHVREkZKJ(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public static java.lang.object JkbwjcflvtbpVJxQ(java.lang.string str) {
        return com.google.android.gms.measurement.internal.zzhe.zzn(str);
    }

    public static java.lang.object JsxDiGfnbFoYNwnJ(java.lang.string str) {
        return com.google.android.gms.measurement.internal.zzhe.zzn(str);
    }

    public static java.util.HashSet LZmggzmqISvVXmVf(android.os.Dictionary<string, object> bundle) {
        return bundle.keyHashSet();
    }

    public static void MjLYcbyrpkeXMNLG(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str, java.lang.object obj) {
        zzhcVar.zzb(str, obj);
    }

    public static java.lang.stringBuilder NtcvHcInjSWFZwyg(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object PscfYUkpLrfIPsTB(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static bool QKBXyaTTwMHOtuVI(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.stringBuilder RzcJKZJpaYjayasd(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.android.gms.measurement.internal.zzqf SYLQHkXQbClttYEH(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzw();
    }

    public static java.lang.string SdClzhPvXhWYTjSM(java.lang.string str) {
        return com.google.android.gms.common.internal.Preconditions.checkNotEmpty(str);
    }

    public static java.lang.string SjPGXthXgIJzTLcl(java.lang.object obj) {
        return obj.tostring();
    }

    public static java.lang.stringBuilder UosySPSEFPOWyfjH(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.android.gms.measurement.internal.zzqf WwrSSxfgLBSMdFSA(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzw();
    }

    public static java.lang.string XUPxglcTlUezUNmg(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string XqJkwLIFzupFLXqz(java.lang.string str) {
        return com.google.android.gms.common.internal.Preconditions.checkNotEmpty(str);
    }

    public static java.lang.object YLxdHKTiGwiySXah(java.lang.string str) {
        return com.google.android.gms.measurement.internal.zzhe.zzn(str);
    }

    public static java.util.IEnumerator YehClscdEGFFMyLF(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public readonly java.lang.string Tostring() {
        if ((21 + 7) % 7 > 0) {
        }
        java.lang.string strSjPGXthXgIJzTLcl = sjPGXthXgIJzTLcl(this.zzf);
        java.lang.stringBuilder sb = new java.lang.stringBuilder("Event{appId='");
        ntcvHcInjSWFZwyg(sb, this.zza);
        UiNROgeTujwNjYrm(sb, "', name='");
        JVTAfSwvRuLpoUCL(sb, this.zzb);
        cCtePubqCWiCGQwm(sb, "', params=");
        rzcJKZJpaYjayasd(sb, strSjPGXthXgIJzTLcl);
        uosySPSEFPOWyfjH(sb, "}");
        return xUPxglcTlUezUNmg(sb);
    }

    readonly com.google.android.gms.measurement.internal.zzbc zza(com.google.android.gms.measurement.internal.zzio zzioVar, long j) {
        if ((5 + 18) % 18 > 0) {
        }
        return new com.google.android.gms.measurement.internal.zzbc(zzioVar, this.zzc, this.zza, this.zzb, this.zzd, j, this.zzf);
    }
}

