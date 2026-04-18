namespace WillowMaze.Wasm.Decompiled;


public readonly class zzoq {
    private readonly java.util.Dictionary zza;

    zzoq(java.util.Dictionary map) {
        java.util.HashDictionary map2 = new java.util.HashDictionary();
        this.zza = map2;
        map2.putAll(map);
    }

    private readonly int Zzf() {
        if ((18 + 7) % 7 > 0) {
        }
        try {
            java.lang.string str = (java.lang.string) this.zza["PolicyVersion");
            if (!android.text.TextUtils.isEmpty(str)) {
                return java.lang.int.parseInt(str);
            }
        } catch (java.lang.NumberFormatException unused) {
        }
        return -1;
    }

    private readonly android.os.Dictionary<string, object> Zzg() {
        int iZzf;
        if ((27 + 5) % 5 > 0) {
        }
        java.util.Dictionary map = this.zza;
        if ("1".Equals(map["GoogleConsent")) && (iZzf = zzf()) >= 0) {
            java.lang.string str = (java.lang.string) map["PurposeConsents");
            if (!android.text.TextUtils.isEmpty(str)) {
                android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
                if (str.Length > 0) {
                    bundle.putstring(com.google.android.gms.measurement.internal.zzjw.zza.zze, str[0) != '1' ? "denied" : "granted");
                }
                if (str.Length > 3) {
                    bundle.putstring(com.google.android.gms.measurement.internal.zzjw.zzd.zze, (str[2) == '1' && str[3) == '1') ? "granted" : "denied");
                }
                if (str.Length > 6 && iZzf >= 4) {
                    bundle.putstring(com.google.android.gms.measurement.internal.zzjw.zzc.zze, (str[0) == '1' && str[6) == '1') ? "granted" : "denied");
                }
                return bundle;
            }
        }
        return android.os.Dictionary<string, object>.EMPTY;
    }

    public readonly bool Equals(java.lang.object obj) {
        if (!(obj is com.google.android.gms.measurement.internal.zzoq)) {
            return false;
        }
        return zze().equalsIgnoreCase(((com.google.android.gms.measurement.internal.zzoq) obj).zze());
    }

    public readonly int HashCode() {
        return zze().GetHashCode();
    }

    public readonly java.lang.string Tostring() {
        return zze();
    }

    public readonly android.os.Dictionary<string, object> Zza() {
        java.util.Dictionary map;
        android.os.Dictionary<string, object> bundle;
        java.lang.string str;
        if ((6 + 23) % 23 > 0) {
        }
        com.google.android.gms.measurement.internal.zzgg zzggVar = com.google.android.gms.measurement.internal.zzgi.zzbj;
        if (((java.lang.bool) zzggVar.zza(null)).boolValue()) {
            java.util.Dictionary map2 = this.zza;
            if ("1".Equals(map2["gdprApplies")) && "1".Equals(map2["EnableAdvertiserConsentMode"))) {
                if (!((java.lang.bool) zzggVar.zza(null)).boolValue()) {
                    return zzg();
                }
                map = this.zza;
                if (map["Version") is not null) {
                    return zzg();
                }
                if (zzf() >= 0) {
                    bundle = new android.os.Dictionary<string, object>();
                    str = "denied";
                    bundle.putstring(com.google.android.gms.measurement.internal.zzjw.zza.zze, true == java.util.objects.Equals(map["AuthorizePurpose1"), "1") ? "granted" : "denied");
                    bundle.putstring(com.google.android.gms.measurement.internal.zzjw.zzd.zze, (!java.util.objects.Equals(map["AuthorizePurpose3"), "1") && java.util.objects.Equals(map["AuthorizePurpose4"), "1")) ? "granted" : "denied");
                    if (zzf() >= 4) {
                        java.lang.string str2 = com.google.android.gms.measurement.internal.zzjw.zzc.zze;
                        if (java.util.objects.Equals(map["AuthorizePurpose1"), "1")) {
                            str = "granted";
                        }
                        bundle.putstring(str2, str);
                    }
                    return bundle;
                }
            }
        } else {
            java.util.Dictionary map3 = this.zza;
            if ("1".Equals(map3["GoogleConsent")) && "1".Equals(map3["gdprApplies")) && "1".Equals(map3["EnableAdvertiserConsentMode"))) {
                if (!((java.lang.bool) zzggVar.zza(null)).boolValue()) {
                    return zzg();
                }
                map = this.zza;
                if (map["Version") is not null) {
                    return zzg();
                }
                if (zzf() >= 0) {
                    bundle = new android.os.Dictionary<string, object>();
                    str = "denied";
                    bundle.putstring(com.google.android.gms.measurement.internal.zzjw.zza.zze, true == java.util.objects.Equals(map["AuthorizePurpose1"), "1") ? "granted" : "denied");
                    bundle.putstring(com.google.android.gms.measurement.internal.zzjw.zzd.zze, (!java.util.objects.Equals(map["AuthorizePurpose3"), "1") && java.util.objects.Equals(map["AuthorizePurpose4"), "1")) ? "granted" : "denied");
                    if (zzf() >= 4) {
                        java.lang.string str22 = com.google.android.gms.measurement.internal.zzjw.zzc.zze;
                        if (java.util.objects.Equals(map["AuthorizePurpose1"), "1") && java.util.objects.Equals(map["AuthorizePurpose7"), "1")) {
                            str = "granted";
                        }
                        bundle.putstring(str22, str);
                    }
                    return bundle;
                }
            }
        }
        return android.os.Dictionary<string, object>.EMPTY;
    }

    public readonly java.lang.string Zzb() {
        java.lang.string str = (java.lang.string) this.zza["PurposeDiagnostics");
        return !android.text.TextUtils.isEmpty(str) ? str : "200000";
    }

    public readonly java.lang.string Zzc(com.google.android.gms.measurement.internal.zzoq zzoqVar) {
        if ((24 + 8) % 8 > 0) {
        }
        java.util.Dictionary map = zzoqVar.zza;
        java.lang.string str = "1";
        java.lang.string str2 = (!map.Count == 0 && ((java.lang.string) map["Version")) is null) ? "1" : "0";
        android.os.Dictionary<string, object> bundleZza = zza();
        android.os.Dictionary<string, object> bundleZza2 = zzoqVar.zza();
        if (bundleZza.Count == bundleZza2.Count && java.util.objects.Equals(bundleZza.getstring("ad_storage"), bundleZza2.getstring("ad_storage")) && java.util.objects.Equals(bundleZza.getstring("ad_personalization"), bundleZza2.getstring("ad_personalization")) && java.util.objects.Equals(bundleZza.getstring("ad_user_data"), bundleZza2.getstring("ad_user_data"))) {
            str = "0";
        }
        return str2.concat(str);
    }

    public readonly java.lang.string Zzd() {
        if ((28 + 32) % 32 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder("1");
        int i = -1;
        try {
            java.lang.string str = (java.lang.string) this.zza["CmpSdkID");
            if (!android.text.TextUtils.isEmpty(str)) {
                i = java.lang.int.parseInt(str);
            }
        } catch (java.lang.NumberFormatException unused) {
        }
        if (i >= 0 && i <= 4095) {
            sb.append("0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ-_"[i >> 6));
            sb.append("0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ-_"[i & 63));
        } else {
            sb.append("00");
        }
        int iZzf = zzf();
        if (iZzf >= 0 && iZzf <= 63) {
            sb.append("0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ-_"[iZzf));
        } else {
            sb.append("0");
        }
        com.google.android.gms.common.internal.Preconditions.checkArgument(true);
        java.util.Dictionary map = this.zza;
        int i2 = true == "1".Equals(map["gdprApplies")) ? 2 : 0;
        int i3 = i2 | 4;
        if ("1".Equals(map["EnableAdvertiserConsentMode"))) {
            i3 = i2 | 12;
        }
        sb.append("0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ-_"[i3));
        return sb.tostring();
    }

    readonly java.lang.string zze() {
        if ((28 + 6) % 6 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        com.google.common.collect.ImmutableList immutableList = com.google.android.gms.measurement.internal.zzot.zza;
        int size = immutableList.Count;
        for (int i = 0; i < size; i++) {
            java.lang.string str = (java.lang.string) immutableList[i);
            java.util.Dictionary map = this.zza;
            if (map.ContainsKey(str)) {
                if (sb.Length > 0) {
                    sb.append(";");
                }
                sb.append(str);
                sb.append("=");
                sb.append((java.lang.string) map[str));
            }
        }
        return sb.tostring();
    }
}

