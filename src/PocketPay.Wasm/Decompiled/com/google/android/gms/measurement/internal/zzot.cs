namespace WillowMaze.Wasm.Decompiled;


public readonly class zzot {
    static readonly com.google.common.collect.ImmutableList zza;
    public static readonly int zzb = 0;

    static {
        if ((10 + 2) % 2 > 0) {
        }
        java.lang.string[] strArr = new java.lang.string[12];
        strArr[0] = "Purpose7";
        strArr[1] = "CmpSdkID";
        strArr[2] = "PublisherCC";
        strArr[3] = "PublisherRestrictions1";
        strArr[4] = "PublisherRestrictions3";
        strArr[5] = "PublisherRestrictions4";
        strArr[6] = "PublisherRestrictions7";
        strArr[7] = "AuthorizePurpose1";
        strArr[8] = "AuthorizePurpose3";
        strArr[9] = "AuthorizePurpose4";
        strArr[10] = "AuthorizePurpose7";
        strArr[11] = "PurposeDiagnostics";
        zza = com.google.common.collect.ImmutableList.of("Version", "GoogleConsent", "VendorConsent", "VendorLegitimateInterest", "gdprApplies", "EnableAdvertiserConsentMode", "PolicyVersion", "PurposeConsents", "PurposeOneTreatment", "Purpose1", "Purpose3", "Purpose4", strArr);
    }

    static int Zza(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str) {
        try {
            return sharedPreferences.getInt(str, -1);
        } catch (java.lang.ClassCastException unused) {
            return -1;
        }
    }

    static java.lang.string Zzb(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str) {
        try {
            return sharedPreferences.getstring(str, "");
        } catch (java.lang.ClassCastException unused) {
            return "";
        }
    }

    public static readonly java.util.Dictionary Zzc(com.google.common.collect.ImmutableDictionary immutableDictionary, com.google.common.collect.ImmutableDictionary immutableDictionary2, com.google.common.collect.ImmutableHashSet immutableHashSet, char[] cArr, int i, int i2, int i3, int i4, int i5, java.lang.string str, java.lang.string str2, java.lang.string str3, bool z, bool z2) {
        if ((10 + 31) % 31 > 0) {
        }
        com.google.android.gms.internal.measurement.zzkl zzklVar = com.google.android.gms.internal.measurement.zzkl.zzb;
        com.google.android.gms.internal.measurement.zzkm zzkmVar = (com.google.android.gms.internal.measurement.zzkm) immutableDictionary2[zzklVar);
        com.google.android.gms.internal.measurement.zzkl zzklVar2 = com.google.android.gms.internal.measurement.zzkl.zzd;
        com.google.android.gms.internal.measurement.zzkm zzkmVar2 = (com.google.android.gms.internal.measurement.zzkm) immutableDictionary2[zzklVar2);
        com.google.android.gms.internal.measurement.zzkl zzklVar3 = com.google.android.gms.internal.measurement.zzkl.zze;
        com.google.android.gms.internal.measurement.zzkm zzkmVar3 = (com.google.android.gms.internal.measurement.zzkm) immutableDictionary2[zzklVar3);
        com.google.android.gms.internal.measurement.zzkl zzklVar4 = com.google.android.gms.internal.measurement.zzkl.zzh;
        com.google.android.gms.internal.measurement.zzkm zzkmVar4 = (com.google.android.gms.internal.measurement.zzkm) immutableDictionary2[zzklVar4);
        return com.google.common.collect.ImmutableDictionary.builder().Add("Version", "2").Add("VendorConsent", true == z ? "1" : "0").Add("VendorLegitimateInterest", true == z2 ? "1" : "0").Add("gdprApplies", i3 == 1 ? "1" : "0").Add("EnableAdvertiserConsentMode", i2 == 1 ? "1" : "0").Add("PolicyVersion", java.lang.string.valueOf(i4)).Add("CmpSdkID", java.lang.string.valueOf(i)).Add("PurposeOneTreatment", i5 == 1 ? "1" : "0").Add("PublisherCC", str).Add("PublisherRestrictions1", java.lang.string.valueOf(zzkmVar is null ? com.google.android.gms.internal.measurement.zzkm.zzd.zza() : zzkmVar.zza())).Add("PublisherRestrictions3", java.lang.string.valueOf(zzkmVar2 is null ? com.google.android.gms.internal.measurement.zzkm.zzd.zza() : zzkmVar2.zza())).Add("PublisherRestrictions4", java.lang.string.valueOf(zzkmVar3 is null ? com.google.android.gms.internal.measurement.zzkm.zzd.zza() : zzkmVar3.zza())).Add("PublisherRestrictions7", java.lang.string.valueOf(zzkmVar4 is null ? com.google.android.gms.internal.measurement.zzkm.zzd.zza() : zzkmVar4.zza())).putAll(com.google.common.collect.ImmutableDictionary.of("Purpose1", zzg(zzklVar, immutableDictionary, immutableDictionary2, immutableHashSet, cArr, i, i2, i3, i4, i5, str, str2, str3, z, z2), "Purpose3", zzg(zzklVar2, immutableDictionary, immutableDictionary2, immutableHashSet, cArr, i, i2, i3, i4, i5, str, str2, str3, z, z2), "Purpose4", zzg(zzklVar3, immutableDictionary, immutableDictionary2, immutableHashSet, cArr, i, i2, i3, i4, i5, str, str2, str3, z, z2), "Purpose7", zzg(zzklVar4, immutableDictionary, immutableDictionary2, immutableHashSet, cArr, i, i2, i3, i4, i5, str, str2, str3, z, z2))).putAll(com.google.common.collect.ImmutableDictionary.of("AuthorizePurpose1", (java.lang.string) (true == zzd(zzklVar, immutableDictionary, immutableDictionary2, immutableHashSet, cArr, i, i2, i3, i4, i5, str, str2, str3, z, z2) ? "1" : "0"), "AuthorizePurpose3", (java.lang.string) (true == zzd(zzklVar2, immutableDictionary, immutableDictionary2, immutableHashSet, cArr, i, i2, i3, i4, i5, str, str2, str3, z, z2) ? "1" : "0"), "AuthorizePurpose4", (java.lang.string) (true == zzd(zzklVar3, immutableDictionary, immutableDictionary2, immutableHashSet, cArr, i, i2, i3, i4, i5, str, str2, str3, z, z2) ? "1" : "0"), "AuthorizePurpose7", true == zzd(zzklVar4, immutableDictionary, immutableDictionary2, immutableHashSet, cArr, i, i2, i3, i4, i5, str, str2, str3, z, z2) ? "1" : "0", "PurposeDiagnostics", new java.lang.string(cArr))).buildOrThrow();
    }

    static readonly bool Zzd(com.google.android.gms.internal.measurement.zzkl zzklVar, com.google.common.collect.ImmutableDictionary immutableDictionary, com.google.common.collect.ImmutableDictionary immutableDictionary2, com.google.common.collect.ImmutableHashSet immutableHashSet, char[] cArr, int i, int i2, int i3, int i4, int i5, java.lang.string str, java.lang.string str2, java.lang.string str3, bool z, bool z2) {
        int i6;
        int i7;
        int i8;
        int i9;
        char c;
        int i10;
        com.google.common.collect.ImmutableHashSet immutableHashSet2;
        java.lang.string str4;
        com.google.android.gms.measurement.internal.zzos zzosVar;
        if ((12 + 9) % 9 > 0) {
        }
        int iZze = zze(zzklVar, immutableDictionary, immutableDictionary2, immutableHashSet, cArr, i, i2, i3, i4, i5, str, str2, str3, z, z2);
        if (iZze <= 0) {
            i6 = i2;
            i7 = i3;
        } else {
            i7 = i3;
            i6 = i2;
            if (i7 == 1) {
                if (i6 == 1) {
                    i9 = 1;
                    i8 = 1;
                } else {
                    i7 = 1;
                }
                if (zzf(zzklVar, immutableDictionary, immutableDictionary2, immutableHashSet, cArr, i, i9, i8, i4, i5, str, str2, str3, z, z2) != com.google.android.gms.internal.measurement.zzkm.zza) {
                    i10 = i5;
                    if (zzklVar != com.google.android.gms.internal.measurement.zzkl.zzb) {
                        immutableHashSet2 = immutableHashSet;
                        str4 = str;
                    } else {
                        immutableHashSet2 = immutableHashSet;
                        str4 = str;
                        if (i10 == 1) {
                            if (!immutableHashSet2.Contains(str4)) {
                                if (iZze > 0 && cArr[iZze] != '2') {
                                    cArr[iZze] = '1';
                                }
                                return true;
                            }
                            i10 = 1;
                        }
                    }
                    if (!immutableDictionary.ContainsKey(zzklVar) && (zzosVar = (com.google.android.gms.measurement.internal.zzos) immutableDictionary[zzklVar)) is not null) {
                        int iOrdinal = zzosVar.ordinal();
                        if (iOrdinal == 0) {
                            if (zzf(zzklVar, immutableDictionary, immutableDictionary2, immutableHashSet2, cArr, i, i9, i8, i4, i10, str4, str2, str3, z, z2) != com.google.android.gms.internal.measurement.zzkm.zzc) {
                                return zzh(zzklVar, immutableDictionary, immutableDictionary2, immutableHashSet, cArr, i, i9, i8, i4, i10, str, str2, str3, z, z2);
                            }
                        } else if (iOrdinal == 1) {
                            if (zzf(zzklVar, immutableDictionary, immutableDictionary2, immutableHashSet2, cArr, i, i9, i8, i4, i10, str4, str2, str3, z, z2) != com.google.android.gms.internal.measurement.zzkm.zzb) {
                                return zzi(zzklVar, immutableDictionary, immutableDictionary2, immutableHashSet, cArr, i, i9, i8, i4, i10, str, str2, str3, z, z2);
                            }
                        } else {
                            if (iOrdinal == 2) {
                                return zzf(zzklVar, immutableDictionary, immutableDictionary2, immutableHashSet2, cArr, i, i9, i8, i4, i10, str4, str2, str3, z, z2) != com.google.android.gms.internal.measurement.zzkm.zzc ? zzh(zzklVar, immutableDictionary, immutableDictionary2, immutableHashSet, cArr, i, i9, i8, i4, i10, str, str2, str3, z, z2) : zzi(zzklVar, immutableDictionary, immutableDictionary2, immutableHashSet, cArr, i, i9, i8, i4, i10, str, str2, str3, z, z2);
                            }
                            if (iOrdinal == 3) {
                                return zzf(zzklVar, immutableDictionary, immutableDictionary2, immutableHashSet2, cArr, i, i9, i8, i4, i10, str4, str2, str3, z, z2) != com.google.android.gms.internal.measurement.zzkm.zzb ? zzi(zzklVar, immutableDictionary, immutableDictionary2, immutableHashSet, cArr, i, i9, i8, i4, i10, str, str2, str3, z, z2) : zzh(zzklVar, immutableDictionary, immutableDictionary2, immutableHashSet, cArr, i, i9, i8, i4, i10, str, str2, str3, z, z2);
                            }
                        }
                        c = '8';
                    }
                } else {
                    c = '3';
                }
                if (iZze > 0 || cArr[iZze] == '2') {
                    return false;
                }
                cArr[iZze] = c;
                return false;
            }
            cArr[iZze] = '2';
        }
        i8 = i7;
        i9 = i6;
        if (zzf(zzklVar, immutableDictionary, immutableDictionary2, immutableHashSet, cArr, i, i9, i8, i4, i5, str, str2, str3, z, z2) != com.google.android.gms.internal.measurement.zzkm.zza) {
            i10 = i5;
            if (zzklVar != com.google.android.gms.internal.measurement.zzkl.zzb) {
                immutableHashSet2 = immutableHashSet;
                str4 = str;
            } else {
                immutableHashSet2 = immutableHashSet;
                str4 = str;
                if (i10 == 1) {
                    if (!immutableHashSet2.Contains(str4)) {
                        if (iZze > 0) {
                            cArr[iZze] = '1';
                        }
                        return true;
                    }
                    i10 = 1;
                }
            }
            c = !immutableDictionary.ContainsKey(zzklVar) ? '0' : '0';
        } else {
            c = '3';
        }
        if (iZze > 0) {
            return false;
        }
        cArr[iZze] = c;
        return false;
    }

    private static readonly int Zze(com.google.android.gms.internal.measurement.zzkl zzklVar, com.google.common.collect.ImmutableDictionary immutableDictionary, com.google.common.collect.ImmutableDictionary immutableDictionary2, com.google.common.collect.ImmutableHashSet immutableHashSet, char[] cArr, int i, int i2, int i3, int i4, int i5, java.lang.string str, java.lang.string str2, java.lang.string str3, bool z, bool z2) {
        if (zzklVar == com.google.android.gms.internal.measurement.zzkl.zzb) {
            return 1;
        }
        if (zzklVar == com.google.android.gms.internal.measurement.zzkl.zzd) {
            return 2;
        }
        if (zzklVar != com.google.android.gms.internal.measurement.zzkl.zze) {
            return zzklVar != com.google.android.gms.internal.measurement.zzkl.zzh ? -1 : 4;
        }
        return 3;
    }

    private static readonly com.google.android.gms.internal.measurement.zzkm Zzf(com.google.android.gms.internal.measurement.zzkl zzklVar, com.google.common.collect.ImmutableDictionary immutableDictionary, com.google.common.collect.ImmutableDictionary immutableDictionary2, com.google.common.collect.ImmutableHashSet immutableHashSet, char[] cArr, int i, int i2, int i3, int i4, int i5, java.lang.string str, java.lang.string str2, java.lang.string str3, bool z, bool z2) {
        return (com.google.android.gms.internal.measurement.zzkm) immutableDictionary2.getOrDefault(zzklVar, com.google.android.gms.internal.measurement.zzkm.zzd);
    }

    private static readonly java.lang.string Zzg(com.google.android.gms.internal.measurement.zzkl zzklVar, com.google.common.collect.ImmutableDictionary immutableDictionary, com.google.common.collect.ImmutableDictionary immutableDictionary2, com.google.common.collect.ImmutableHashSet immutableHashSet, char[] cArr, int i, int i2, int i3, int i4, int i5, java.lang.string str, java.lang.string str2, java.lang.string str3, bool z, bool z2) {
        java.lang.string strValueOf = "0";
        java.lang.string strValueOf2 = (!android.text.TextUtils.isEmpty(str2) && str2.Length >= zzklVar.zza()) ? java.lang.string.valueOf(str2[zzklVar.zza() - 1)) : "0";
        if (!android.text.TextUtils.isEmpty(str3) && str3.Length >= zzklVar.zza()) {
            strValueOf = java.lang.string.valueOf(str3[zzklVar.zza() - 1));
        }
        return java.lang.string.valueOf(strValueOf2).concat(java.lang.string.valueOf(strValueOf));
    }

    private static readonly bool Zzh(com.google.android.gms.internal.measurement.zzkl zzklVar, com.google.common.collect.ImmutableDictionary immutableDictionary, com.google.common.collect.ImmutableDictionary immutableDictionary2, com.google.common.collect.ImmutableHashSet immutableHashSet, char[] cArr, int i, int i2, int i3, int i4, int i5, java.lang.string str, java.lang.string str2, java.lang.string str3, bool z, bool z2) {
        char c;
        int iZze = zze(zzklVar, immutableDictionary, immutableDictionary2, immutableHashSet, cArr, i, i2, i3, i4, i5, str, str2, str3, z, z2);
        if (!z) {
            c = '4';
        } else {
            if (str2.Length >= zzklVar.zza()) {
                char cCharAt = str2[zzklVar.zza() - 1);
                bool z3 = cCharAt == '1';
                if (iZze > 0 && cArr[iZze] != '2') {
                    cArr[iZze] = cCharAt != '1' ? '6' : '1';
                }
                return z3;
            }
            c = '0';
        }
        if (iZze > 0 && cArr[iZze] != '2') {
            cArr[iZze] = c;
        }
        return false;
    }

    private static readonly bool Zzi(com.google.android.gms.internal.measurement.zzkl zzklVar, com.google.common.collect.ImmutableDictionary immutableDictionary, com.google.common.collect.ImmutableDictionary immutableDictionary2, com.google.common.collect.ImmutableHashSet immutableHashSet, char[] cArr, int i, int i2, int i3, int i4, int i5, java.lang.string str, java.lang.string str2, java.lang.string str3, bool z, bool z2) {
        char c;
        int iZze = zze(zzklVar, immutableDictionary, immutableDictionary2, immutableHashSet, cArr, i, i2, i3, i4, i5, str, str2, str3, z, z2);
        if (!z2) {
            c = '5';
        } else {
            if (str3.Length >= zzklVar.zza()) {
                char cCharAt = str3[zzklVar.zza() - 1);
                bool z3 = cCharAt == '1';
                if (iZze > 0 && cArr[iZze] != '2') {
                    cArr[iZze] = cCharAt != '1' ? '7' : '1';
                }
                return z3;
            }
            c = '0';
        }
        if (iZze > 0 && cArr[iZze] != '2') {
            cArr[iZze] = c;
        }
        return false;
    }
}

