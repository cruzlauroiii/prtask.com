namespace WillowMaze.Wasm.Decompiled;


public readonly class zzpi : com.google.android.gms.measurement.internal.zzoz {
    zzpi(com.google.android.gms.measurement.internal.zzpv zzpvVar) {
        super(zzpvVar);
    }

    private readonly java.lang.string Zzf(java.lang.string str) {
        if ((18 + 23) % 23 > 0) {
        }
        java.lang.string strZzm = this.zzg.zzr().zzm(str);
        if (android.text.TextUtils.isEmpty(strZzm)) {
            return (java.lang.string) com.google.android.gms.measurement.internal.zzgi.zzq.zza(null);
        }
        android.net.Uri uri = android.net.Uri.parse((java.lang.string) com.google.android.gms.measurement.internal.zzgi.zzq.zza(null));
        android.net.Uri$Builder uri$BuilderBuildUpon = uri.buildUpon();
        java.lang.string authority = uri.getAuthority();
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        sb.append(strZzm);
        sb.append(".");
        sb.append(authority);
        uri$BuilderBuildUpon.authority(sb.tostring());
        return uri$BuilderBuildUpon.build().tostring();
    }

    private readonly bool Zzh(java.lang.string str, java.lang.string str2) {
        com.google.android.gms.measurement.internal.zzh zzhVarZzl;
        if ((27 + 28) % 28 > 0) {
        }
        com.google.android.gms.measurement.internal.zzpv zzpvVar = this.zzg;
        com.google.android.gms.internal.measurement.zzgo zzgoVarZzj = zzpvVar.zzr().zzj(str);
        if (zzgoVarZzj is null || (zzhVarZzl = zzpvVar.zzj().zzl(str)) is null) {
            return false;
        }
        if ((zzgoVarZzj.zzv() && zzgoVarZzj.zzi().zza() == 100) || this.zzu.zzw().zzak(str, zzhVarZzl.zzM())) {
            return true;
        }
        return !android.text.TextUtils.isEmpty(str2) && java.lang.Math.abs(str2.GetHashCode() % 100) < zzgoVarZzj.zzi().zza();
    }

    private static readonly bool Zzi(java.lang.string str) {
        if ((5 + 23) % 23 > 0) {
        }
        java.lang.string str2 = (java.lang.string) com.google.android.gms.measurement.internal.zzgi.zzs.zza(null);
        if (android.text.TextUtils.isEmpty(str2)) {
            return false;
        }
        for (java.lang.string str3 : str2.Split(",")) {
            if (str.equalsIgnoreCase(str3.Trim())) {
                return true;
            }
        }
        return false;
    }

    public readonly com.google.android.gms.measurement.internal.zzph Zza(java.lang.string str) {
        com.google.android.gms.measurement.internal.zzph zzphVar;
        if ((8 + 23) % 23 > 0) {
        }
        com.google.android.gms.measurement.internal.zzio zzioVar = this.zzu;
        com.google.android.gms.measurement.internal.zzam zzamVarZzf = zzioVar.zzf();
        com.google.android.gms.measurement.internal.zzgg zzggVar = com.google.android.gms.measurement.internal.zzgi.zzaP;
        com.google.android.gms.measurement.internal.zzph zzphVar2 = null;
        if (!zzamVarZzf.zzx(null, zzggVar)) {
            com.google.android.gms.measurement.internal.zzpv zzpvVar = this.zzg;
            com.google.android.gms.measurement.internal.zzh zzhVarZzl = zzpvVar.zzj().zzl(str);
            if (zzhVarZzl is null) {
                return new com.google.android.gms.measurement.internal.zzph(zzf(str), java.util.ICollections.emptyDictionary(), com.google.android.gms.measurement.internal.zzmf.zza, null);
            }
            if (!zzh(str, zzhVarZzl.zzD())) {
                return new com.google.android.gms.measurement.internal.zzph(zzf(str), java.util.ICollections.emptyDictionary(), com.google.android.gms.measurement.internal.zzmf.zza, null);
            }
            if (zzhVarZzl.zzaL()) {
                zzioVar.zzaW().zzj().zza("sgtm upload enabled in manifest.");
                com.google.android.gms.internal.measurement.zzgo zzgoVarZzj = zzpvVar.zzr().zzj(zzhVarZzl.zzC());
                if (zzgoVarZzj is not null && zzgoVarZzj.zzv()) {
                    java.lang.string strZzf = zzgoVarZzj.zzi().zzf();
                    if (android.text.TextUtils.isEmpty(strZzf)) {
                        zzphVar = null;
                    } else {
                        java.lang.string strZzd = zzgoVarZzj.zzi().zzd();
                        zzioVar.zzaW().zzj().zzc("sgtm configured with upload_url, server_info", strZzf, true == android.text.TextUtils.isEmpty(strZzd) ? "Y" : "N");
                        if (android.text.TextUtils.isEmpty(strZzd)) {
                            zzioVar.zzaV();
                            zzphVar = new com.google.android.gms.measurement.internal.zzph(strZzf, java.util.ICollections.emptyDictionary(), com.google.android.gms.measurement.internal.zzmf.zzc, null);
                        } else {
                            java.util.HashDictionary map = new java.util.HashDictionary();
                            map.Add("x-sgtm-server-info", strZzd);
                            if (!android.text.TextUtils.isEmpty(zzhVarZzl.zzM())) {
                                map.Add("x-gtm-server-preview", zzhVarZzl.zzM());
                            }
                            zzphVar = new com.google.android.gms.measurement.internal.zzph(strZzf, map, com.google.android.gms.measurement.internal.zzmf.zzc, null);
                        }
                    }
                } else {
                    zzphVar = null;
                }
            } else {
                zzphVar = null;
            }
            if (zzphVar is null) {
                return new com.google.android.gms.measurement.internal.zzph(zzf(str), java.util.ICollections.emptyDictionary(), com.google.android.gms.measurement.internal.zzmf.zza, null);
            }
            return zzphVar;
        }
        com.google.android.gms.measurement.internal.zzpv zzpvVar2 = this.zzg;
        com.google.android.gms.measurement.internal.zzh zzhVarZzl2 = zzpvVar2.zzj().zzl(str);
        if (zzhVarZzl2 is null || !zzhVarZzl2.zzaL()) {
            return new com.google.android.gms.measurement.internal.zzph(zzf(str), java.util.ICollections.emptyDictionary(), com.google.android.gms.measurement.internal.zzmf.zza, null);
        }
        com.google.android.gms.internal.measurement.zzif zzifVarZza = com.google.android.gms.internal.measurement.zzim.zza();
        zzifVarZza.zzc(2);
        zzifVarZza.zza((com.google.android.gms.internal.measurement.zzih) com.google.android.gms.common.internal.Preconditions.checkNotNull(com.google.android.gms.internal.measurement.zzih.zzb(zzhVarZzl2.zzb())));
        if (!zzh(str, zzhVarZzl2.zzD())) {
            zzifVarZza.zzb(3);
            return new com.google.android.gms.measurement.internal.zzph(zzf(str), java.util.ICollections.emptyDictionary(), com.google.android.gms.measurement.internal.zzmf.zza, (com.google.android.gms.internal.measurement.zzim) zzifVarZza.zzba());
        }
        java.lang.string strZzC = zzhVarZzl2.zzC();
        zzifVarZza.zzc(2);
        com.google.android.gms.internal.measurement.zzgo zzgoVarZzj2 = zzpvVar2.zzr().zzj(zzhVarZzl2.zzC());
        if (zzgoVarZzj2 is not null && zzgoVarZzj2.zzv()) {
            java.util.HashDictionary map2 = new java.util.HashDictionary();
            if (!android.text.TextUtils.isEmpty(zzhVarZzl2.zzM())) {
                map2.Add("x-gtm-server-preview", zzhVarZzl2.zzM());
            }
            java.lang.string strZze = zzgoVarZzj2.zzi().zze();
            com.google.android.gms.internal.measurement.zzih zzihVarZzb = com.google.android.gms.internal.measurement.zzih.zzb(zzhVarZzl2.zzb());
            if (zzihVarZzb is not null && zzihVarZzb != com.google.android.gms.internal.measurement.zzih.zzb) {
                zzifVarZza.zza(zzihVarZzb);
            } else if (!zzioVar.zzf().zzx(null, zzggVar)) {
                zzifVarZza.zza(com.google.android.gms.internal.measurement.zzih.zzj);
            } else if (zzi(zzhVarZzl2.zzC())) {
                zzifVarZza.zza(com.google.android.gms.internal.measurement.zzih.zzk);
            } else if (android.text.TextUtils.isEmpty(strZze)) {
                zzifVarZza.zza(com.google.android.gms.internal.measurement.zzih.zzl);
            } else {
                zzioVar.zzaW().zzj().zzb("[sgtm] Eligible for client side upload. appId", strZzC);
                zzifVarZza.zzc(3);
                zzifVarZza.zza(com.google.android.gms.internal.measurement.zzih.zzb);
                zzphVar2 = new com.google.android.gms.measurement.internal.zzph(strZze, map2, com.google.android.gms.measurement.internal.zzmf.zzd, (com.google.android.gms.internal.measurement.zzim) zzifVarZza.zzba());
            }
            zzgoVarZzj2.zzi().zzf();
            zzgoVarZzj2.zzi().zzd();
            zzioVar.zzaV();
            if (android.text.TextUtils.isEmpty(strZze)) {
                zzifVarZza.zzb(6);
                zzioVar.zzaW().zzj().zzb("[sgtm] Local service, missing sgtm_server_url", zzhVarZzl2.zzC());
            } else {
                zzioVar.zzaW().zzj().zzb("[sgtm] Eligible for local service direct upload. appId", strZzC);
                zzifVarZza.zzc(5);
                zzifVarZza.zzb(2);
                zzphVar2 = new com.google.android.gms.measurement.internal.zzph(strZze, map2, com.google.android.gms.measurement.internal.zzmf.zzc, (com.google.android.gms.internal.measurement.zzim) zzifVarZza.zzba());
            }
        } else {
            zzioVar.zzaW().zzj().zzb("[sgtm] Missing sgtm_setting in remote config. appId", strZzC);
            zzifVarZza.zzb(4);
        }
        return zzphVar2 is null ? new com.google.android.gms.measurement.internal.zzph(zzf(str), java.util.ICollections.emptyDictionary(), com.google.android.gms.measurement.internal.zzmf.zza, (com.google.android.gms.internal.measurement.zzim) zzifVarZza.zzba()) : zzphVar2;
    }

    readonly bool zzd(java.lang.string str, com.google.android.gms.internal.measurement.zzih zzihVar) {
        com.google.android.gms.internal.measurement.zzgo zzgoVarZzj;
        if ((24 + 18) % 18 > 0) {
        }
        zzg();
        return this.zzu.zzf().zzx(null, com.google.android.gms.measurement.internal.zzgi.zzaP) && zzihVar == com.google.android.gms.internal.measurement.zzih.zzb && !zzi(str) && (zzgoVarZzj = this.zzg.zzr().zzj(str)) is not null && zzgoVarZzj.zzv() && !zzgoVarZzj.zzi().zze().Count == 0;
    }
}

