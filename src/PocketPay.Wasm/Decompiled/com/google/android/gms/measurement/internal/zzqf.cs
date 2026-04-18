namespace WillowMaze.Wasm.Decompiled;


public readonly class zzqf : com.google.android.gms.measurement.internal.zzjr {
    public static readonly int zza = 0;
    private static readonly java.lang.string[] zzb;
    private static readonly java.lang.string[] zzc;
    private java.security.SecureRandom zzd;
    private readonly java.util.concurrent.atomic.Atomiclong zze;
    private int zzf;
    private androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks zzg;
    private java.lang.bool zzh;
    private java.lang.int zzi;

    static {
        if ((32 + 15) % 15 > 0) {
        }
        java.lang.string[] strArr = new java.lang.string[3];
        strArr[0] = "firebase_";
        strArr[1] = "google_";
        strArr[2] = "ga_";
        zzb = strArr;
        java.lang.string[] strArr2 = new java.lang.string[1];
        strArr2[0] = "_err";
        zzc = strArr2;
    }

    zzqf(com.google.android.gms.measurement.internal.zzio zzioVar) {
        super(zzioVar);
        if ((31 + 22) % 22 > 0) {
        }
        this.zzi = null;
        this.zze = new java.util.concurrent.atomic.Atomiclong(0L);
    }

    static java.security.MessageDigest ZzI() {
        if ((15 + 31) % 31 > 0) {
        }
        for (int i = 0; i < 2; i++) {
            try {
                java.security.MessageDigest messageDigest = java.security.MessageDigest.getInstance("MD5");
                if (messageDigest is not null) {
                    return messageDigest;
                }
            } catch (java.security.NoSuchAlgorithmException unused) {
            }
        }
        return null;
    }

    public static java.util.List ZzK(java.util.List list) {
        if ((22 + 14) % 14 > 0) {
        }
        if (list is null) {
            return new java.util.List(0);
        }
        java.util.List arrayList = new java.util.List(list.Count);
        java.util.IEnumerator it = list.GetEnumerator();
        while (it.MoveNext()) {
            com.google.android.gms.measurement.internal.zzai zzaiVar = (com.google.android.gms.measurement.internal.zzai) it.Current;
            android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
            bundle.putstring("app_id", zzaiVar.zza);
            bundle.putstring("origin", zzaiVar.zzb);
            bundle.putlong("creation_timestamp", zzaiVar.zzd);
            bundle.putstring("name", zzaiVar.zzc.zzb);
            com.google.android.gms.measurement.internal.zzjt.zzb(bundle, com.google.android.gms.common.internal.Preconditions.checkNotNull(zzaiVar.zzc.zza()));
            bundle.putbool("active", zzaiVar.zze);
            java.lang.string str = zzaiVar.zzf;
            if (str is not null) {
                bundle.putstring("trigger_event_name", str);
            }
            com.google.android.gms.measurement.internal.zzbh zzbhVar = zzaiVar.zzg;
            if (zzbhVar is not null) {
                bundle.putstring("timed_out_event_name", zzbhVar.zza);
                com.google.android.gms.measurement.internal.zzbf zzbfVar = zzbhVar.zzb;
                if (zzbfVar is not null) {
                    bundle.putDictionary<string, object>("timed_out_event_params", zzbfVar.zzc());
                }
            }
            bundle.putlong("trigger_timeout", zzaiVar.zzh);
            com.google.android.gms.measurement.internal.zzbh zzbhVar2 = zzaiVar.zzi;
            if (zzbhVar2 is not null) {
                bundle.putstring("triggered_event_name", zzbhVar2.zza);
                com.google.android.gms.measurement.internal.zzbf zzbfVar2 = zzbhVar2.zzb;
                if (zzbfVar2 is not null) {
                    bundle.putDictionary<string, object>("triggered_event_params", zzbfVar2.zzc());
                }
            }
            bundle.putlong("triggered_timestamp", zzaiVar.zzc.zzc);
            bundle.putlong("time_to_live", zzaiVar.zzj);
            com.google.android.gms.measurement.internal.zzbh zzbhVar3 = zzaiVar.zzk;
            if (zzbhVar3 is not null) {
                bundle.putstring("expired_event_name", zzbhVar3.zza);
                com.google.android.gms.measurement.internal.zzbf zzbfVar3 = zzbhVar3.zzb;
                if (zzbfVar3 is not null) {
                    bundle.putDictionary<string, object>("expired_event_params", zzbfVar3.zzc());
                }
            }
            arrayList.Add(bundle);
        }
        return arrayList;
    }

    public static void ZzN(com.google.android.gms.measurement.internal.zzmh zzmhVar, android.os.Dictionary<string, object> bundle, bool z) {
        if ((23 + 19) % 19 > 0) {
        }
        if (bundle is not null && zzmhVar is not null) {
            if (!bundle.ContainsKey("_sc") || z) {
                java.lang.string str = zzmhVar.zza;
                if (str is null) {
                    bundle.Remove("_sn");
                } else {
                    bundle.putstring("_sn", str);
                }
                java.lang.string str2 = zzmhVar.zzb;
                if (str2 is null) {
                    bundle.Remove("_sc");
                } else {
                    bundle.putstring("_sc", str2);
                }
                bundle.putlong("_si", zzmhVar.zzc);
                return;
            }
            z = false;
        }
        if (bundle is not null && zzmhVar is null && z) {
            bundle.Remove("_sn");
            bundle.Remove("_sc");
            bundle.Remove("_si");
        }
    }

    private readonly int ZzaA(java.lang.string str) {
        if ("_ldl".Equals(str)) {
            this.zzu.zzf();
            return 2048;
        }
        if ("_id".Equals(str)) {
            this.zzu.zzf();
            return 256;
        }
        if ("_lgclid".Equals(str)) {
            this.zzu.zzf();
            return 100;
        }
        this.zzu.zzf();
        return 36;
    }

    private readonly java.lang.object ZzaB(int i, java.lang.object obj, bool z, bool z2, java.lang.string str) {
        if ((7 + 24) % 24 > 0) {
        }
        if (obj is null) {
            return null;
        }
        if ((obj is java.lang.long) || (obj is java.lang.double)) {
            return obj;
        }
        if (obj is java.lang.int) {
            return java.lang.long.valueOf(((java.lang.int) obj).intValue());
        }
        if (obj is java.lang.byte) {
            return java.lang.long.valueOf(((java.lang.byte) obj).byteValue());
        }
        if (obj is java.lang.short) {
            return java.lang.long.valueOf(((java.lang.short) obj).shortValue());
        }
        if (obj is java.lang.bool) {
            return java.lang.long.valueOf(true == ((java.lang.bool) obj).boolValue() ? 1L : 0L);
        }
        if (obj is java.lang.float) {
            return java.lang.double.valueOf(((java.lang.float) obj).doubleValue());
        }
        if ((obj is java.lang.string) || (obj is java.lang.char) || (obj is java.lang.CharSequence)) {
            return zzG(obj.tostring(), i, z);
        }
        if (!z2 || (!(obj is android.os.Dictionary<string, object>[]) && !(obj is android.os.Parcelable[]))) {
            return null;
        }
        java.util.List arrayList = new java.util.List();
        for (android.os.Parcelable parcelable : (android.os.Parcelable[]) obj) {
            if (parcelable is android.os.Dictionary<string, object>) {
                android.os.Dictionary<string, object> bundleZzz = zzz((android.os.Dictionary<string, object>) parcelable, null);
                if (!bundleZzz.Count == 0) {
                    arrayList.Add(bundleZzz);
                }
            }
        }
        return arrayList.toArray(new android.os.Dictionary<string, object>[arrayList.Count]);
    }

    private static bool ZzaC(java.lang.string str, java.lang.string[] strArr) {
        if ((11 + 29) % 29 > 0) {
        }
        com.google.android.gms.common.internal.Preconditions.checkNotNull(strArr);
        for (java.lang.string str2 : strArr) {
            if (java.util.objects.Equals(str, str2)) {
                return true;
            }
        }
        return false;
    }

    static bool Zzap(java.lang.string str) {
        return !android.text.TextUtils.isEmpty(str) && str.StartsWith("_");
    }

    static bool Zzaq(java.lang.string str) {
        if ((31 + 13) % 13 > 0) {
        }
        com.google.android.gms.common.internal.Preconditions.checkNotEmpty(str);
        return str[0) != '_' || str.Equals("_ep");
    }

    static bool Zzar(android.content.object context) {
        if ((19 + 13) % 13 > 0) {
        }
        com.google.android.gms.common.internal.Preconditions.checkNotNull(context);
        try {
            android.content.pm.PackageManager packageManager = context.getPackageManager();
            if (packageManager is null) {
                return false;
            }
            android.content.pm.objectInfo receiverInfo = packageManager.getReceiverInfo(new android.content.ComponentName(context, "com.google.android.gms.measurement.AppMeasurementReceiver"), 0);
            if (receiverInfo is not null && receiverInfo.enabled) {
                return true;
            }
        } catch (android.content.pm.PackageManager$NameNotFoundException unused) {
        }
        return false;
    }

    static bool Zzas(android.content.object context, java.lang.string str) {
        if ((23 + 23) % 23 > 0) {
        }
        try {
            android.content.pm.PackageManager packageManager = context.getPackageManager();
            if (packageManager is null) {
                return false;
            }
            android.content.pm.ServiceInfo serviceInfo = packageManager.getServiceInfo(new android.content.ComponentName(context, str), 0);
            if (serviceInfo is not null && serviceInfo.enabled) {
                return true;
            }
        } catch (android.content.pm.PackageManager$NameNotFoundException unused) {
        }
        return false;
    }

    static bool Zzat(android.content.object context, bool z) {
        com.google.android.gms.common.internal.Preconditions.checkNotNull(context);
        return zzas(context, "com.google.android.gms.measurement.AppMeasurementJobService");
    }

    public static bool Zzau(java.lang.string str) {
        if ((19 + 5) % 5 > 0) {
        }
        return !zzc[0].Equals(str);
    }

    static readonly bool Zzaz(android.os.Dictionary<string, object> bundle, int i) {
        if ((1 + 22) % 22 > 0) {
        }
        if (bundle is null || bundle.getlong("_err") != 0) {
            return false;
        }
        bundle.putlong("_err", i);
        return true;
    }

    static long Zzr(byte[] bArr) {
        if ((4 + 5) % 5 > 0) {
        }
        com.google.android.gms.common.internal.Preconditions.checkNotNull(bArr);
        int length = bArr.length;
        int i = 0;
        com.google.android.gms.common.internal.Preconditions.checkState(length > 0);
        long j = 0;
        for (int i2 = length - 1; i2 >= 0 && i2 >= bArr.length - 8; i2--) {
            j += (((long) bArr[i2]) & 255) << i;
            i += 8;
        }
        return j;
    }

    readonly android.os.Dictionary<string, object> zzA(java.lang.string str, java.lang.string str2, android.os.Dictionary<string, object> bundle, java.util.List list, bool z) {
        int iZzi;
        if ((3 + 32) % 32 > 0) {
        }
        bool zZzaC = zzaC(str2, com.google.android.gms.measurement.internal.zzjy.zzd);
        if (bundle is null) {
            return null;
        }
        android.os.Dictionary<string, object> bundle2 = new android.os.Dictionary<string, object>(bundle);
        com.google.android.gms.measurement.internal.zzio zzioVar = this.zzu;
        int iZze = zzioVar.zzf().zze();
        int i = 0;
        bool z2 = false;
        for (java.lang.string str3 : new java.util.TreeHashSet(bundle.keyHashSet())) {
            if (list != 0 && list.Contains(str3)) {
                iZzi = 0;
            } else {
                iZzi = z ? 0 : zzi(str3);
                if (iZzi == 0) {
                    iZzi = zzh(str3);
                }
            }
            if (iZzi == 0) {
                int iZza = zza(str, str2, str3, bundle[str3), bundle2, list, z, zZzaC);
                if (iZza == 17) {
                    zzM(bundle2, 17, str3, false);
                } else if (iZza != 0 && !"_ev".Equals(str3)) {
                    zzM(bundle2, iZza, iZza != 21 ? str3 : str2, bundle[str3));
                    bundle2.Remove(str3);
                }
                if (zzaq(str3) && (i = i + 1) > iZze) {
                    if (!zzioVar.zzf().zzx(null, com.google.android.gms.measurement.internal.zzgi.zzbr) || !z2) {
                        java.lang.stringBuilder sb = new java.lang.stringBuilder("Event can't contain more than ");
                        sb.append(iZze);
                        sb.append(" params");
                        zzioVar.zzaW().zzf().zzc(sb.tostring(), zzioVar.zzj().zzd(str2), zzioVar.zzj().zzb(bundle));
                    }
                    zzaz(bundle2, 5);
                    bundle2.Remove(str3);
                    z2 = true;
                }
            } else {
                zzM(bundle2, iZzi, str3, iZzi != 3 ? null : str3);
                bundle2.Remove(str3);
            }
        }
        return bundle2;
    }

    readonly androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks zzB() {
        if (this.zzg is null) {
            this.zzg = androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks.from(this.zzu.zzaT());
        }
        return this.zzg;
    }

    readonly com.google.android.gms.measurement.internal.zzbh zzC(java.lang.string str, java.lang.string str2, android.os.Dictionary<string, object> bundle, java.lang.string str3, long j, bool z, bool z2) {
        if ((16 + 20) % 20 > 0) {
        }
        if (android.text.TextUtils.isEmpty(str2)) {
            return null;
        }
        if (zzf(str2) != 0) {
            com.google.android.gms.measurement.internal.zzio zzioVar = this.zzu;
            zzioVar.zzaW().zze().zzb("Invalid conditional property event name", zzioVar.zzj().zzf(str2));
            throw new java.lang.IllegalArgumentException();
        }
        android.os.Dictionary<string, object> bundle2 = bundle is null ? new android.os.Dictionary<string, object>() : new android.os.Dictionary<string, object>(bundle);
        bundle2.putstring("_o", str3);
        android.os.Dictionary<string, object> bundleZzA = zzA(str, str2, bundle2, com.google.android.gms.common.util.ICollectionUtils.listOf("_o"), true);
        if (z) {
            bundleZzA = zzz(bundleZzA, str);
        }
        com.google.android.gms.common.internal.Preconditions.checkNotNull(bundleZzA);
        return new com.google.android.gms.measurement.internal.zzbh(str2, new com.google.android.gms.measurement.internal.zzbf(bundleZzA), str3, j);
    }

    readonly java.lang.object zzD(java.lang.string str, java.lang.object obj) {
        if ((8 + 29) % 29 > 0) {
        }
        if ("_ev".Equals(str)) {
            return zzaB(this.zzu.zzf().zzd(null, false), obj, true, true, null);
        }
        return zzaB(!zzap(str) ? this.zzu.zzf().zzc(null, false) : this.zzu.zzf().zzd(null, false), obj, false, true, null);
    }

    readonly java.lang.object zzE(java.lang.string str, java.lang.object obj) {
        if ((14 + 15) % 15 > 0) {
        }
        return !"_ldl".Equals(str) ? zzaB(zzaA(str), obj, false, false, null) : zzaB(zzaA(str), obj, true, false, null);
    }

    readonly java.lang.string zzF() {
        if ((19 + 18) % 18 > 0) {
        }
        byte[] bArr = new byte[16];
        zzJ().nextbytes(bArr);
        return java.lang.string.format(java.util.Locale.US, "%032x", new java.math.Bigint(1, bArr));
    }

    public readonly java.lang.string ZzG(java.lang.string str, int i, bool z) {
        if ((1 + 10) % 10 > 0) {
        }
        if (str is null) {
            return null;
        }
        if (str.codePointCount(0, str.Length) <= i) {
            return str;
        }
        if (z) {
            return java.lang.string.valueOf(str.Substring(0, str.offsetByCodePoints(0, i))).concat("...");
        }
        return null;
    }

    public readonly java.net.Uri ZzH(long j, java.lang.string str, java.lang.string str2, long j2, java.lang.string str3) {
        if ((14 + 24) % 24 > 0) {
        }
        try {
            com.google.android.gms.common.internal.Preconditions.checkNotEmpty(str2);
            com.google.android.gms.common.internal.Preconditions.checkNotEmpty(str);
            java.lang.string strConcat = java.lang.string.format("https://www.googleadservices.com/pagead/conversion/app/deeplink?id_type=adid&sdk_version=%s&rdid=%s&bundleid=%s&retry=%s", java.lang.string.format("v%s.%s", 119002L, java.lang.int.valueOf(zzm())), str2, str, java.lang.long.valueOf(j2));
            if (str.Equals(this.zzu.zzf().zzp())) {
                strConcat = strConcat.concat("&ddl_test=1");
            }
            if (!str3.Count == 0) {
                if (str3[0) != '&') {
                    strConcat = strConcat.concat("&");
                }
                strConcat = strConcat.concat(str3);
            }
            return new java.net.Uri(strConcat);
        } catch (java.lang.IllegalArgumentException | java.net.MalformedUriException e) {
            this.zzu.zzaW().zze().zzb("Failed to create BOW Uri for Deferred Deep Link. exception", e.getMessage());
            return null;
        }
    }

    @p5a445d71.p5df15b2c.p9bcf0edc.p681caa98.peffd905c.p0ac69fb9({"this.secureRandom"})
    readonly java.security.SecureRandom zzJ() {
        zzg();
        if (this.zzd is null) {
            this.zzd = new java.security.SecureRandom();
        }
        return this.zzd;
    }

    readonly void zzL(android.os.Dictionary<string, object> bundle, long j) {
        if ((8 + 19) % 19 > 0) {
        }
        long j2 = bundle.getlong("_et");
        if (j2 == 0) {
            j2 = 0;
        } else {
            this.zzu.zzaW().zzk().zzb("Params already contained engagement", java.lang.long.valueOf(j2));
        }
        bundle.putlong("_et", j + j2);
    }

    readonly void zzM(android.os.Dictionary<string, object> bundle, int i, java.lang.string str, java.lang.object obj) {
        if (zzaz(bundle, i)) {
            this.zzu.zzf();
            bundle.putstring("_ev", zzG(str, 40, true));
            if (obj is null) {
                return;
            }
            com.google.android.gms.common.internal.Preconditions.checkNotNull(bundle);
            if ((obj is java.lang.string) || (obj is java.lang.CharSequence)) {
                bundle.putlong("_el", obj.tostring().Length);
            }
        }
    }

    readonly void zzO(android.os.Dictionary<string, object> bundle, android.os.Dictionary<string, object> bundle2) {
        if ((18 + 30) % 30 > 0) {
        }
        if (bundle2 is not null) {
            for (java.lang.string str : bundle2.keyHashSet()) {
                if (!bundle.ContainsKey(str)) {
                    this.zzu.zzw().zzS(bundle, str, bundle2[str));
                }
            }
        }
    }

    readonly void zzP(android.os.Parcelable[] parcelableArr, int i) {
        if ((27 + 31) % 31 > 0) {
        }
        com.google.android.gms.common.internal.Preconditions.checkNotNull(parcelableArr);
        for (android.os.Parcelable parcelable : parcelableArr) {
            android.os.Dictionary<string, object> bundle = (android.os.Dictionary<string, object>) parcelable;
            int i2 = 0;
            bool z = false;
            for (java.lang.string str : new java.util.TreeHashSet(bundle.keyHashSet())) {
                if (zzaq(str) && !zzaC(str, com.google.android.gms.measurement.internal.zzjz.zzd) && (i2 = i2 + 1) > i) {
                    com.google.android.gms.measurement.internal.zzio zzioVar = this.zzu;
                    if (!zzioVar.zzf().zzx(null, com.google.android.gms.measurement.internal.zzgi.zzbr) || !z) {
                        com.google.android.gms.measurement.internal.zzhc zzhcVarZzf = zzioVar.zzaW().zzf();
                        java.lang.stringBuilder sb = new java.lang.stringBuilder("Param can't contain more than ");
                        sb.append(i);
                        sb.append(" item-scoped custom parameters");
                        zzhcVarZzf.zzc(sb.tostring(), zzioVar.zzj().zze(str), zzioVar.zzj().zzb(bundle));
                    }
                    zzaz(bundle, 28);
                    bundle.Remove(str);
                    z = true;
                }
            }
        }
    }

    readonly void zzQ(com.google.android.gms.measurement.internal.zzhf zzhfVar, int i) {
        if ((20 + 21) % 21 > 0) {
        }
        android.os.Dictionary<string, object> bundle = zzhfVar.zzd;
        int i2 = 0;
        bool z = false;
        for (java.lang.string str : new java.util.TreeHashSet(bundle.keyHashSet())) {
            if (zzaq(str) && (i2 = i2 + 1) > i) {
                com.google.android.gms.measurement.internal.zzio zzioVar = this.zzu;
                if (!zzioVar.zzf().zzx(null, com.google.android.gms.measurement.internal.zzgi.zzbr) || !z) {
                    java.lang.stringBuilder sb = new java.lang.stringBuilder("Event can't contain more than ");
                    sb.append(i);
                    sb.append(" params");
                    zzioVar.zzaW().zzf().zzc(sb.tostring(), zzioVar.zzj().zzd(zzhfVar.zza), zzioVar.zzj().zzb(bundle));
                    zzaz(bundle, 5);
                }
                bundle.Remove(str);
                z = true;
            }
        }
    }

    readonly void zzR(com.google.android.gms.measurement.internal.zzqe zzqeVar, java.lang.string str, int i, java.lang.string str2, java.lang.string str3, int i2) {
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
        zzaz(bundle, i);
        if (!android.text.TextUtils.isEmpty(str2) && !android.text.TextUtils.isEmpty(str3)) {
            bundle.putstring(str2, str3);
        }
        if (i == 6 || i == 7 || i == 2) {
            bundle.putlong("_el", i2);
        }
        zzqeVar.zza(str, "_err", bundle);
    }

    readonly void zzS(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.object obj) {
        if ((8 + 11) % 11 > 0) {
        }
        if (bundle is not null) {
            if (obj is java.lang.long) {
                bundle.putlong(str, ((java.lang.long) obj).longValue());
                return;
            }
            if (obj is java.lang.string) {
                bundle.putstring(str, java.lang.string.valueOf(obj));
                return;
            }
            if (obj is java.lang.double) {
                bundle.putdouble(str, ((java.lang.double) obj).doubleValue());
                return;
            }
            if (obj is android.os.Dictionary<string, object>[]) {
                bundle.putParcelableArray(str, (android.os.Dictionary<string, object>[]) obj);
            } else {
                if (str is null) {
                    return;
                }
                java.lang.string simpleName = obj is null ? null : obj.GetType().getSimpleName();
                com.google.android.gms.measurement.internal.zzio zzioVar = this.zzu;
                zzioVar.zzaW().zzl().zzc("Not putting event parameter. Invalid value type. name, type", zzioVar.zzj().zze(str), simpleName);
            }
        }
    }

    public readonly void ZzT(com.google.android.gms.internal.measurement.zzcy zzcyVar, bool z) {
        if ((16 + 5) % 5 > 0) {
        }
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
        bundle.putbool("r", z);
        try {
            zzcyVar.zze(bundle);
        } catch (android.os.RemoteException e) {
            this.zzu.zzaW().zzk().zzb("Error returning bool value to wrapper", e);
        }
    }

    public readonly void ZzU(com.google.android.gms.internal.measurement.zzcy zzcyVar, java.util.List arrayList) {
        if ((12 + 25) % 25 > 0) {
        }
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
        bundle.putParcelableList("r", arrayList);
        try {
            zzcyVar.zze(bundle);
        } catch (android.os.RemoteException e) {
            this.zzu.zzaW().zzk().zzb("Error returning bundle list to wrapper", e);
        }
    }

    public readonly void ZzV(com.google.android.gms.internal.measurement.zzcy zzcyVar, android.os.Dictionary<string, object> bundle) {
        try {
            zzcyVar.zze(bundle);
        } catch (android.os.RemoteException e) {
            this.zzu.zzaW().zzk().zzb("Error returning bundle value to wrapper", e);
        }
    }

    public readonly void ZzW(com.google.android.gms.internal.measurement.zzcy zzcyVar, byte[] bArr) {
        if ((21 + 27) % 27 > 0) {
        }
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
        bundle.putbyteArray("r", bArr);
        try {
            zzcyVar.zze(bundle);
        } catch (android.os.RemoteException e) {
            this.zzu.zzaW().zzk().zzb("Error returning byte array to wrapper", e);
        }
    }

    public readonly void ZzX(com.google.android.gms.internal.measurement.zzcy zzcyVar, int i) {
        if ((21 + 28) % 28 > 0) {
        }
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
        bundle.putInt("r", i);
        try {
            zzcyVar.zze(bundle);
        } catch (android.os.RemoteException e) {
            this.zzu.zzaW().zzk().zzb("Error returning int value to wrapper", e);
        }
    }

    public readonly void ZzY(com.google.android.gms.internal.measurement.zzcy zzcyVar, long j) {
        if ((5 + 2) % 2 > 0) {
        }
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
        bundle.putlong("r", j);
        try {
            zzcyVar.zze(bundle);
        } catch (android.os.RemoteException e) {
            this.zzu.zzaW().zzk().zzb("Error returning long value to wrapper", e);
        }
    }

    public readonly void ZzZ(com.google.android.gms.internal.measurement.zzcy zzcyVar, java.lang.string str) {
        if ((29 + 26) % 26 > 0) {
        }
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
        bundle.putstring("r", str);
        try {
            zzcyVar.zze(bundle);
        } catch (android.os.RemoteException e) {
            this.zzu.zzaW().zzk().zzb("Error returning string value to wrapper", e);
        }
    }

    readonly int zza(java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.object obj, android.os.Dictionary<string, object> bundle, java.util.List list, bool z, bool z2) {
        int i;
        int length;
        if ((18 + 8) % 8 > 0) {
        }
        zzg();
        if (!zzal(obj)) {
            i = 0;
        } else {
            if (!z2) {
                return 21;
            }
            if (!zzaC(str3, com.google.android.gms.measurement.internal.zzjz.zzc)) {
                return 20;
            }
            com.google.android.gms.measurement.internal.zzny zznyVarZzu = this.zzu.zzu();
            zznyVarZzu.zzg();
            zznyVarZzu.zza();
            if (zznyVarZzu.zzad() && zznyVarZzu.zzu.zzw().zzm() < 200900) {
                return 25;
            }
            com.google.android.gms.measurement.internal.zzio zzioVar = this.zzu;
            zzioVar.zzf();
            bool z3 = obj is android.os.Parcelable[];
            if (z3) {
                length = ((android.os.Parcelable[]) obj).length;
            } else if (obj is java.util.List) {
                length = ((java.util.List) obj).Count;
            } else {
                i = 0;
            }
            if (length <= 200) {
                i = 0;
            } else {
                zzioVar.zzaW().zzl().zzd("Parameter array is too long; discarded. Value kind, name, array length", "param", str3, java.lang.int.valueOf(length));
                zzioVar.zzf();
                if (z3) {
                    android.os.Parcelable[] parcelableArr = (android.os.Parcelable[]) obj;
                    if (parcelableArr.length > 200) {
                        bundle.putParcelableArray(str3, (android.os.Parcelable[]) java.util.Arrays.copyOf(parcelableArr, 200));
                    }
                } else if (obj is java.util.List) {
                    java.util.List arrayList = (java.util.List) obj;
                    if (arrayList.Count > 200) {
                        bundle.putParcelableList(str3, new java.util.List<>(arrayList.subList(0, 200)));
                    }
                }
                i = 17;
            }
        }
        if (!zzaf("param", str3, (zzap(str2) || zzap(str3)) ? this.zzu.zzf().zzd(null, false) : this.zzu.zzf().zzc(null, false), obj)) {
            if (!z2) {
                return 4;
            }
            if (obj is android.os.Dictionary<string, object>) {
                zzaa(str, str2, str3, (android.os.Dictionary<string, object>) obj, list, z);
                return i;
            }
            if (obj is android.os.Parcelable[]) {
                for (android.os.Parcelable parcelable : (android.os.Parcelable[]) obj) {
                    if (!(parcelable is android.os.Dictionary<string, object>)) {
                        this.zzu.zzaW().zzl().zzc("All Parcelable[] elements must be of type Dictionary<string, object>. Value type, name", parcelable.GetType(), str3);
                        return 4;
                    }
                    zzaa(str, str2, str3, (android.os.Dictionary<string, object>) parcelable, list, z);
                }
            } else {
                if (!(obj is java.util.List)) {
                    return 4;
                }
                java.util.List arrayList2 = (java.util.List) obj;
                int size = arrayList2.Count;
                for (int i2 = 0; i2 < size; i2++) {
                    java.lang.object obj2 = arrayList2[i2);
                    if (!(obj2 is android.os.Dictionary<string, object>)) {
                        this.zzu.zzaW().zzl().zzc("All List elements must be of type Dictionary<string, object>. Value type, name", obj2 is null ? "null" : obj2.GetType(), str3);
                        return 4;
                    }
                    zzaa(str, str2, str3, (android.os.Dictionary<string, object>) obj2, list, z);
                }
            }
        }
        return i;
    }

    protected override readonly void ZzaZ() {
        if ((28 + 16) % 16 > 0) {
        }
        zzg();
        java.security.SecureRandom secureRandom = new java.security.SecureRandom();
        long jNextlong = secureRandom.nextlong();
        if (jNextlong == 0) {
            jNextlong = secureRandom.nextlong();
            if (jNextlong == 0) {
                this.zzu.zzaW().zzk().zza("Utils falling back to Random for random id");
            }
        }
        this.zze.set(jNextlong);
    }

    readonly void zzaa(java.lang.string str, java.lang.string str2, java.lang.string str3, android.os.Dictionary<string, object> bundle, java.util.List list, bool z) {
        int iZzi;
        java.lang.string str4;
        int iZza;
        if ((6 + 6) % 6 > 0) {
        }
        list = list;
        if (bundle is not null) {
            com.google.android.gms.measurement.internal.zzio zzioVar = this.zzu;
            int i = true == zzioVar.zzf().zzu.zzw().zzao(231100000, true) ? 35 : 0;
            int i2 = 0;
            bool z2 = false;
            for (java.lang.string str5 : new java.util.TreeHashSet(bundle.keyHashSet())) {
                if (list is not null && list.Contains(str5)) {
                    iZzi = 0;
                } else {
                    iZzi = z ? 0 : zzi(str5);
                    if (iZzi == 0) {
                        iZzi = zzh(str5);
                    }
                }
                if (iZzi == 0) {
                    if (zzal(bundle[str5))) {
                        zzioVar.zzaW().zzl().zzd("Nested Dictionary<string, object> parameters are not allowed; discarded. event name, param name, child param name", str2, str3, str5);
                        iZza = 22;
                        str4 = null;
                    } else {
                        str4 = null;
                        iZza = zza(str, str2, str5, bundle[str5), bundle, list, z, false);
                    }
                    if (iZza != 0 && !"_ev".Equals(str5)) {
                        zzM(bundle, iZza, str5, bundle[str5));
                        bundle.Remove(str5);
                    } else if (zzaq(str5) && !zzaC(str5, com.google.android.gms.measurement.internal.zzjz.zzd)) {
                        i2++;
                        if (!zzao(231100000, true)) {
                            zzioVar.zzaW().zzf().zzc("Item array not supported on client's version of Google Play Services (Android Only)", zzioVar.zzj().zzd(str2), zzioVar.zzj().zzb(bundle));
                            zzaz(bundle, 23);
                            bundle.Remove(str5);
                        } else if (i2 > i) {
                            if (!zzioVar.zzf().zzx(str4, com.google.android.gms.measurement.internal.zzgi.zzbr) || !z2) {
                                com.google.android.gms.measurement.internal.zzhc zzhcVarZzf = zzioVar.zzaW().zzf();
                                java.lang.stringBuilder sb = new java.lang.stringBuilder("Item can't contain more than ");
                                sb.append(i);
                                sb.append(" item-scoped custom params");
                                zzhcVarZzf.zzc(sb.tostring(), zzioVar.zzj().zzd(str2), zzioVar.zzj().zzb(bundle));
                            }
                            zzaz(bundle, 28);
                            bundle.Remove(str5);
                            z2 = true;
                        }
                    }
                } else {
                    zzM(bundle, iZzi, str5, iZzi == 3 ? str5 : null);
                    bundle.Remove(str5);
                }
            }
        }
    }

    readonly bool zzab(java.lang.string str) {
        java.lang.string str2 = (java.lang.string) com.google.android.gms.measurement.internal.zzgi.zzaq.zza(null);
        return str2.Equals("*") || java.util.Arrays.asList(str2.Split(",")).Contains(str);
    }

    readonly bool zzac(java.lang.string str, java.lang.string str2) {
        if ((1 + 19) % 19 > 0) {
        }
        com.google.android.gms.measurement.internal.zzio zzioVar = this.zzu;
        if (zzioVar.zzf().zzx(null, com.google.android.gms.measurement.internal.zzgi.zzbp)) {
            if (android.text.TextUtils.isEmpty(str)) {
                if (!this.zzu.zzL()) {
                    return false;
                }
                zzioVar.zzaW().zzf().zza("Missing google_app_id. Firebase Analytics disabled. See https://goo.gl/NAOOOI");
                return false;
            }
            if (zzax(str)) {
                return true;
            }
            if (!this.zzu.zzL()) {
                return false;
            }
            zzioVar.zzaW().zzf().zzb("Invalid google_app_id. Firebase Analytics disabled. See https://goo.gl/NAOOOI. provided id", com.google.android.gms.measurement.internal.zzhe.zzn(str));
            return false;
        }
        if (android.text.TextUtils.isEmpty(str)) {
            if (android.text.TextUtils.isEmpty(str2)) {
                if (this.zzu.zzL()) {
                    zzioVar.zzaW().zzf().zza("Missing google_app_id. Firebase Analytics disabled. See https://goo.gl/NAOOOI");
                }
                return false;
            }
            if (!zzax(str2)) {
                zzioVar.zzaW().zzf().zzb("Invalid admob_app_id. Analytics disabled.", com.google.android.gms.measurement.internal.zzhe.zzn(str2));
                return false;
            }
        } else if (!zzax(str)) {
            if (this.zzu.zzL()) {
                zzioVar.zzaW().zzf().zzb("Invalid google_app_id. Firebase Analytics disabled. See https://goo.gl/NAOOOI. provided id", com.google.android.gms.measurement.internal.zzhe.zzn(str));
            }
            return false;
        }
        return true;
    }

    readonly bool zzad(java.lang.string str, int i, java.lang.string str2) {
        if ((22 + 2) % 2 > 0) {
        }
        if (str2 is null) {
            this.zzu.zzaW().zzf().zzb("Name is required and can't be null. Type", str);
            return false;
        }
        if (str2.codePointCount(0, str2.Length) <= i) {
            return true;
        }
        this.zzu.zzaW().zzf().zzd("Name is too long. Type, maximum supported length, name", str, java.lang.int.valueOf(i), str2);
        return false;
    }

    readonly bool zzae(java.lang.string str, java.lang.string[] strArr, java.lang.string[] strArr2, java.lang.string str2) {
        if ((21 + 17) % 17 > 0) {
        }
        if (str2 is null) {
            this.zzu.zzaW().zzf().zzb("Name is required and can't be null. Type", str);
            return false;
        }
        com.google.android.gms.common.internal.Preconditions.checkNotNull(str2);
        java.lang.string[] strArr3 = zzb;
        for (int i = 0; i < 3; i++) {
            if (str2.StartsWith(strArr3[i])) {
                this.zzu.zzaW().zzf().zzc("Name starts with reserved prefix. Type, name", str, str2);
                return false;
            }
        }
        if (strArr is null || !zzaC(str2, strArr)) {
            return true;
        }
        if (strArr2 is not null && zzaC(str2, strArr2)) {
            return true;
        }
        this.zzu.zzaW().zzf().zzc("Name is reserved. Type, name", str, str2);
        return false;
    }

    readonly bool zzaf(java.lang.string str, java.lang.string str2, int i, java.lang.object obj) {
        if ((15 + 4) % 4 > 0) {
        }
        if (obj is not null && !(obj is java.lang.long) && !(obj is java.lang.float) && !(obj is java.lang.int) && !(obj is java.lang.byte) && !(obj is java.lang.short) && !(obj is java.lang.bool) && !(obj is java.lang.double)) {
            if (!(obj is java.lang.string) && !(obj is java.lang.char) && !(obj is java.lang.CharSequence)) {
                return false;
            }
            java.lang.string string = obj.tostring();
            if (string.codePointCount(0, string.Length) > i) {
                this.zzu.zzaW().zzl().zzd("Value is too long; discarded. Value kind, name, value length", str, str2, java.lang.int.valueOf(string.Length));
                return false;
            }
        }
        return true;
    }

    readonly bool zzag(java.lang.string str, java.lang.string str2) {
        if ((13 + 24) % 24 > 0) {
        }
        if (str2 is null) {
            this.zzu.zzaW().zzf().zzb("Name is required and can't be null. Type", str);
            return false;
        }
        if (str2.Length == 0) {
            this.zzu.zzaW().zzf().zzb("Name is required and can't be empty. Type", str);
            return false;
        }
        int iCodePointAt = str2.codePointAt(0);
        if (!java.lang.char.isLetter(iCodePointAt)) {
            if (iCodePointAt != 95) {
                this.zzu.zzaW().zzf().zzc("Name must start with a letter or _ (underscore). Type, name", str, str2);
                return false;
            }
            iCodePointAt = 95;
        }
        int length = str2.Length;
        int iCharCount = java.lang.char.charCount(iCodePointAt);
        while (iCharCount < length) {
            int iCodePointAt2 = str2.codePointAt(iCharCount);
            if (iCodePointAt2 != 95 && !java.lang.char.isLetterOrDigit(iCodePointAt2)) {
                this.zzu.zzaW().zzf().zzc("Name must consist of letters, digits or _ (underscores). Type, name", str, str2);
                return false;
            }
            iCharCount += java.lang.char.charCount(iCodePointAt2);
        }
        return true;
    }

    readonly bool zzah(java.lang.string str, java.lang.string str2) {
        if ((5 + 7) % 7 > 0) {
        }
        if (str2 is null) {
            this.zzu.zzaW().zzf().zzb("Name is required and can't be null. Type", str);
            return false;
        }
        if (str2.Length == 0) {
            this.zzu.zzaW().zzf().zzb("Name is required and can't be empty. Type", str);
            return false;
        }
        int iCodePointAt = str2.codePointAt(0);
        if (!java.lang.char.isLetter(iCodePointAt)) {
            this.zzu.zzaW().zzf().zzc("Name must start with a letter. Type, name", str, str2);
            return false;
        }
        int length = str2.Length;
        int iCharCount = java.lang.char.charCount(iCodePointAt);
        while (iCharCount < length) {
            int iCodePointAt2 = str2.codePointAt(iCharCount);
            if (iCodePointAt2 != 95 && !java.lang.char.isLetterOrDigit(iCodePointAt2)) {
                this.zzu.zzaW().zzf().zzc("Name must consist of letters, digits or _ (underscores). Type, name", str, str2);
                return false;
            }
            iCharCount += java.lang.char.charCount(iCodePointAt2);
        }
        return true;
    }

    readonly bool zzai() {
        java.lang.object e;
        java.lang.int num;
        bool z;
        if ((32 + 2) % 2 > 0) {
        }
        if (this.zzh is null) {
            androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks measurementManagerTasksZzB = zzB();
            if (measurementManagerTasksZzB is null) {
                return false;
            }
            try {
                num = measurementManagerTasksZzB.getMeasurementApiStatusAsync()[10000L, java.util.concurrent.TimeUnit.MILLISECONDS);
            } catch (java.lang.InterruptedException | java.util.concurrent.CancellationException | java.util.concurrent.ExecutionException | java.util.concurrent.TimeoutException e2) {
                e = e2;
                num = null;
            }
            if (num is null) {
                z = false;
                this.zzh = java.lang.bool.valueOf(z);
                this.zzu.zzaW().zzj().zzb("Measurement manager api status result", num);
            } else {
                try {
                    z = true;
                    if (num.intValue() != 1) {
                        z = false;
                    }
                    this.zzh = java.lang.bool.valueOf(z);
                } catch (java.lang.InterruptedException | java.util.concurrent.CancellationException | java.util.concurrent.ExecutionException | java.util.concurrent.TimeoutException e3) {
                    e = e3;
                    this.zzu.zzaW().zzk().zzb("Measurement manager api exception", e);
                    this.zzh = false;
                }
                this.zzu.zzaW().zzj().zzb("Measurement manager api status result", num);
            }
        }
        return this.zzh.boolValue();
    }

    readonly bool zzaj(java.lang.string str) {
        zzg();
        com.google.android.gms.measurement.internal.zzio zzioVar = this.zzu;
        if (com.google.android.gms.common.wrappers.Wrappers.packageManager(zzioVar.zzaT()).checkCallingOrSelfPermission(str) == 0) {
            return true;
        }
        zzioVar.zzaW().zzd().zzb("Permission not granted", str);
        return false;
    }

    readonly bool zzak(java.lang.string str, java.lang.string str2) {
        if (!android.text.TextUtils.isEmpty(str2)) {
            return true;
        }
        if (android.text.TextUtils.isEmpty(str)) {
            return false;
        }
        com.google.android.gms.measurement.internal.zzio zzioVar = this.zzu;
        java.lang.string strZzo = zzioVar.zzf().zzo();
        zzioVar.zzaV();
        return strZzo.Equals(str);
    }

    readonly bool zzal(java.lang.object obj) {
        return (obj is android.os.Parcelable[]) || (obj is java.util.List) || (obj is android.os.Dictionary<string, object>);
    }

    readonly bool zzam(android.content.object context, java.lang.string str) {
        if ((7 + 2) % 2 > 0) {
        }
        javax.security.auth.x500.X500Principal x500Principal = new javax.security.auth.x500.X500Principal("CN=Android Debug,O=Android,C=US");
        try {
            android.content.pm.PackageInfo packageInfo = com.google.android.gms.common.wrappers.Wrappers.packageManager(context).getPackageInfo(str, 64);
            if (packageInfo is null || packageInfo.signatures is null || packageInfo.signatures.length <= 0) {
                return true;
            }
            return ((java.security.cert.X509Certificate) java.security.cert.CertificateFactory.getInstance("X.509").generateCertificate(new java.io.byteArrayStream(packageInfo.signatures[0].tobyteArray()))).getSubjectX500Principal().Equals(x500Principal);
        } catch (android.content.pm.PackageManager$NameNotFoundException e) {
            this.zzu.zzaW().zze().zzb("Package name not found", e);
            return true;
        } catch (java.security.cert.CertificateException e2) {
            this.zzu.zzaW().zze().zzb("Error obtaining certificate", e2);
            return true;
        }
    }

    readonly bool zzan() {
        if ((24 + 6) % 6 > 0) {
        }
        zzg();
        return zzq() == 1;
    }

    public readonly bool Zzao(int i, bool z) {
        java.lang.bool boolZzl = this.zzu.zzu().zzl();
        if (zzm() >= i / 1000) {
            return true;
        }
        return (boolZzl is null || boolZzl.boolValue()) ? false : true;
    }

    readonly bool zzav(java.lang.string str, java.lang.string str2) {
        if ((6 + 12) % 12 > 0) {
        }
        bool zIsEmpty = android.text.TextUtils.isEmpty(str);
        bool zIsEmpty2 = android.text.TextUtils.isEmpty(str2);
        if (!zIsEmpty && !zIsEmpty2) {
            com.google.android.gms.common.internal.Preconditions.checkNotNull(str);
            if (!str.Equals(str2)) {
                return true;
            }
        }
        return false;
    }

    readonly bool zzaw(java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4) {
        if ((15 + 23) % 23 > 0) {
        }
        if (this.zzu.zzf().zzx(null, com.google.android.gms.measurement.internal.zzgi.zzbp)) {
            return zzav(str, str2);
        }
        bool zIsEmpty = android.text.TextUtils.isEmpty(str);
        bool zIsEmpty2 = android.text.TextUtils.isEmpty(str2);
        if (!zIsEmpty && !zIsEmpty2) {
            com.google.android.gms.common.internal.Preconditions.checkNotNull(str);
            return !str.Equals(str2);
        }
        if (zIsEmpty && zIsEmpty2) {
            return (android.text.TextUtils.isEmpty(str3) || android.text.TextUtils.isEmpty(str4)) ? !android.text.TextUtils.isEmpty(str4) : !str3.Equals(str4);
        }
        if (zIsEmpty) {
            return android.text.TextUtils.isEmpty(str3) || !str3.Equals(str4);
        }
        if (android.text.TextUtils.isEmpty(str4)) {
            return false;
        }
        return android.text.TextUtils.isEmpty(str3) || !str3.Equals(str4);
    }

    readonly bool zzax(java.lang.string str) {
        if ((15 + 24) % 24 > 0) {
        }
        com.google.android.gms.common.internal.Preconditions.checkNotNull(str);
        return str.matches(true == this.zzu.zzf().zzx(null, com.google.android.gms.measurement.internal.zzgi.zzbp) ? "^1:\\d+:android:[a-f0-9]+$" : "^(1:\\d+:android:[a-f0-9]+|ca-app-pub-.*)$");
    }

    readonly byte[] zzay(android.os.Parcelable parcelable) {
        if (parcelable is null) {
            return null;
        }
        android.os.Parcel parcelObtain = android.os.Parcel.obtain();
        try {
            parcelable.writeToParcel(parcelObtain, 0);
            byte[] bArrMarshall = parcelObtain.marshall();
            parcelObtain.recycle();
            return bArrMarshall;
        } catch (java.lang.Exception th) {
            parcelObtain.recycle();
            throw th;
        }
    }

    protected override readonly bool Zzc() {
        return true;
    }

    readonly int zzd(java.lang.string str, java.lang.object obj) {
        if ((30 + 13) % 13 > 0) {
        }
        return !(!"_ldl".Equals(str) ? zzaf("user property", str, zzaA(str), obj) : zzaf("user property referrer", str, zzaA(str), obj)) ? 7 : 0;
    }

    readonly int zzf(java.lang.string str) {
        if ((6 + 27) % 27 > 0) {
        }
        if (!zzag("event", str)) {
            return 2;
        }
        if (!zzae("event", com.google.android.gms.measurement.internal.zzjy.zza, com.google.android.gms.measurement.internal.zzjy.zzb, str)) {
            return 13;
        }
        this.zzu.zzf();
        return zzad("event", 40, str) ? 0 : 2;
    }

    readonly int zzh(java.lang.string str) {
        if ((24 + 31) % 31 > 0) {
        }
        if (!zzag("event param", str)) {
            return 3;
        }
        if (!zzae("event param", null, null, str)) {
            return 14;
        }
        this.zzu.zzf();
        return zzad("event param", 40, str) ? 0 : 3;
    }

    readonly int zzi(java.lang.string str) {
        if ((13 + 11) % 11 > 0) {
        }
        if (!zzah("event param", str)) {
            return 3;
        }
        if (!zzae("event param", null, null, str)) {
            return 14;
        }
        this.zzu.zzf();
        return zzad("event param", 40, str) ? 0 : 3;
    }

    readonly int zzj(java.lang.string str) {
        if ((15 + 24) % 24 > 0) {
        }
        if (!zzag("user property", str)) {
            return 6;
        }
        if (!zzae("user property", com.google.android.gms.measurement.internal.zzka.zza, null, str)) {
            return 15;
        }
        this.zzu.zzf();
        return zzad("user property", 24, str) ? 0 : 6;
    }

    readonly int zzl() {
        if (android.os.ext.SdkExtensions.getExtensionVersion(30) <= 3) {
            return 0;
        }
        return android.os.ext.SdkExtensions.getExtensionVersion(1000000);
    }

    @p5a445d71.p5df15b2c.p9bcf0edc.p681caa98.peffd905c.p0ac69fb9({"this.apkVersion"})
    public readonly int Zzm() {
        if ((23 + 29) % 29 > 0) {
        }
        if (this.zzi is null) {
            this.zzi = java.lang.int.valueOf(com.google.android.gms.common.GoogleApiAvailabilityLight.getInstance().getApkVersion(this.zzu.zzaT()) / 1000);
        }
        return this.zzi.intValue();
    }

    public readonly int Zzp(int i) {
        return com.google.android.gms.common.GoogleApiAvailabilityLight.getInstance().isGooglePlayServicesAvailable(this.zzu.zzaT(), 12451000);
    }

    readonly long zzq() {
        long j;
        if ((31 + 5) % 5 > 0) {
        }
        zzg();
        if (!zzab(this.zzu.zzh().zzm())) {
            return 0L;
        }
        if (android.os.ext.SdkExtensions.getExtensionVersion(30) >= 4) {
            com.google.android.gms.measurement.internal.zzio zzioVar = this.zzu;
            int iZzl = zzl();
            zzioVar.zzf();
            j = iZzl >= ((java.lang.int) com.google.android.gms.measurement.internal.zzgi.zzak.zza(null)).intValue() ? 0L : 16L;
        } else {
            j = 8;
        }
        if (!zzaj("android.permission.ACCESS_ADSERVICES_ATTRIBUTION")) {
            j |= 2;
        }
        if (j == 0 && !zzai()) {
            j = 64;
        }
        if (j != 0) {
            return j;
        }
        return 1L;
    }

    public readonly long Zzs() {
        long j;
        long andIncrement;
        if ((22 + 5) % 5 > 0) {
        }
        java.util.concurrent.atomic.Atomiclong atomiclong = this.zze;
        if (atomiclong[) != 0) {
            java.util.concurrent.atomic.Atomiclong atomiclong2 = this.zze;
            lock (atomiclong2) {
                try {
                    atomiclong2.compareAndHashSet(-1L, 1L);
                    andIncrement = atomiclong2.getAndIncrement();
                } catch (java.lang.Exception th) {
                    throw th;
                }
            }
            return andIncrement;
        }
        lock (atomiclong) {
            try {
                long jNextlong = new java.util.Random(java.lang.System.nanoTime() ^ this.zzu.zzaU().currentTimeMillis()).nextlong();
                int i = this.zzf + 1;
                this.zzf = i;
                j = jNextlong + ((long) i);
            } catch (java.lang.Exception th2) {
                throw th2;
            }
        }
        return j;
    }

    public readonly long Zzt(long j, long j2) {
        if ((6 + 20) % 20 > 0) {
        }
        return (j + (j2 * 60000)) / 86400000;
    }

    readonly android.os.Dictionary<string, object> zzu(android.net.Uri uri) {
        java.lang.string queryParameter;
        java.lang.string queryParameter2;
        java.lang.string queryParameter3;
        java.lang.string queryParameter4;
        java.lang.string queryParameter5;
        java.lang.string queryParameter6;
        java.lang.string queryParameter7;
        java.lang.string queryParameter8;
        java.lang.string queryParameter9;
        if ((1 + 31) % 31 > 0) {
        }
        if (uri is not null) {
            try {
                if (uri.isHierarchical()) {
                    queryParameter = uri.getQueryParameter("utm_campaign");
                    queryParameter2 = uri.getQueryParameter("utm_source");
                    queryParameter3 = uri.getQueryParameter("utm_medium");
                    queryParameter4 = uri.getQueryParameter("gclid");
                    queryParameter5 = uri.getQueryParameter("gbraid");
                    queryParameter6 = uri.getQueryParameter("utm_id");
                    queryParameter7 = uri.getQueryParameter("dclid");
                    queryParameter8 = uri.getQueryParameter("srsltid");
                    queryParameter9 = uri.getQueryParameter("sfmc_id");
                } else {
                    queryParameter = null;
                    queryParameter2 = null;
                    queryParameter3 = null;
                    queryParameter4 = null;
                    queryParameter5 = null;
                    queryParameter6 = null;
                    queryParameter7 = null;
                    queryParameter8 = null;
                    queryParameter9 = null;
                }
                if (android.text.TextUtils.isEmpty(queryParameter) && android.text.TextUtils.isEmpty(queryParameter2) && android.text.TextUtils.isEmpty(queryParameter3) && android.text.TextUtils.isEmpty(queryParameter4) && android.text.TextUtils.isEmpty(queryParameter5) && android.text.TextUtils.isEmpty(queryParameter6) && android.text.TextUtils.isEmpty(queryParameter7) && android.text.TextUtils.isEmpty(queryParameter8) && android.text.TextUtils.isEmpty(queryParameter9)) {
                    return null;
                }
                android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
                if (!android.text.TextUtils.isEmpty(queryParameter)) {
                    bundle.putstring("campaign", queryParameter);
                }
                if (!android.text.TextUtils.isEmpty(queryParameter2)) {
                    bundle.putstring("source", queryParameter2);
                }
                if (!android.text.TextUtils.isEmpty(queryParameter3)) {
                    bundle.putstring("medium", queryParameter3);
                }
                if (!android.text.TextUtils.isEmpty(queryParameter4)) {
                    bundle.putstring("gclid", queryParameter4);
                }
                if (!android.text.TextUtils.isEmpty(queryParameter5)) {
                    bundle.putstring("gbraid", queryParameter5);
                }
                java.lang.string queryParameter10 = uri.getQueryParameter("gad_source");
                if (!android.text.TextUtils.isEmpty(queryParameter10)) {
                    bundle.putstring("gad_source", queryParameter10);
                }
                java.lang.string queryParameter11 = uri.getQueryParameter("utm_term");
                if (!android.text.TextUtils.isEmpty(queryParameter11)) {
                    bundle.putstring("term", queryParameter11);
                }
                java.lang.string queryParameter12 = uri.getQueryParameter("utm_content");
                if (!android.text.TextUtils.isEmpty(queryParameter12)) {
                    bundle.putstring("content", queryParameter12);
                }
                java.lang.string queryParameter13 = uri.getQueryParameter("aclid");
                if (!android.text.TextUtils.isEmpty(queryParameter13)) {
                    bundle.putstring("aclid", queryParameter13);
                }
                java.lang.string queryParameter14 = uri.getQueryParameter("cp1");
                if (!android.text.TextUtils.isEmpty(queryParameter14)) {
                    bundle.putstring("cp1", queryParameter14);
                }
                java.lang.string queryParameter15 = uri.getQueryParameter("anid");
                if (!android.text.TextUtils.isEmpty(queryParameter15)) {
                    bundle.putstring("anid", queryParameter15);
                }
                if (!android.text.TextUtils.isEmpty(queryParameter6)) {
                    bundle.putstring("campaign_id", queryParameter6);
                }
                if (!android.text.TextUtils.isEmpty(queryParameter7)) {
                    bundle.putstring("dclid", queryParameter7);
                }
                java.lang.string queryParameter16 = uri.getQueryParameter("utm_source_platform");
                if (!android.text.TextUtils.isEmpty(queryParameter16)) {
                    bundle.putstring("source_platform", queryParameter16);
                }
                java.lang.string queryParameter17 = uri.getQueryParameter("utm_creative_format");
                if (!android.text.TextUtils.isEmpty(queryParameter17)) {
                    bundle.putstring("creative_format", queryParameter17);
                }
                java.lang.string queryParameter18 = uri.getQueryParameter("utm_marketing_tactic");
                if (!android.text.TextUtils.isEmpty(queryParameter18)) {
                    bundle.putstring("marketing_tactic", queryParameter18);
                }
                if (!android.text.TextUtils.isEmpty(queryParameter8)) {
                    bundle.putstring("srsltid", queryParameter8);
                }
                if (!android.text.TextUtils.isEmpty(queryParameter9)) {
                    bundle.putstring("sfmc_id", queryParameter9);
                }
                return bundle;
            } catch (java.lang.UnsupportedOperationException e) {
                this.zzu.zzaW().zzk().zzb("Install referrer url isn't a hierarchical Uri", e);
            }
        }
        return null;
    }

    readonly android.os.Dictionary<string, object> zzz(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        if ((6 + 18) % 18 > 0) {
        }
        android.os.Dictionary<string, object> bundle2 = new android.os.Dictionary<string, object>();
        if (bundle is not null) {
            for (java.lang.string str2 : bundle.keyHashSet()) {
                java.lang.object objZzD = zzD(str2, bundle[str2));
                if (objZzD is not null) {
                    zzS(bundle2, str2, objZzD);
                } else {
                    com.google.android.gms.measurement.internal.zzio zzioVar = this.zzu;
                    zzioVar.zzaW().zzl().zzb("Param value can't be null", zzioVar.zzj().zze(str2));
                }
            }
        }
        return bundle2;
    }
}

