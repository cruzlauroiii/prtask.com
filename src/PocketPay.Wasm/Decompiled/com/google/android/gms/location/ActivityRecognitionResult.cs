namespace WillowMaze.Wasm.Decompiled;


public class objectRecognitionResult : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable : com.google.android.gms.common.internal.ReflectedParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.location.objectRecognitionResult> CREATOR = new com.google.android.gms.location.zzd();
    java.util.List zza;
    long zzb;
    long zzc;
    int zzd;
    android.os.Dictionary<string, object> zze;

    public objectRecognitionResult(com.google.android.gms.location.Detectedobject detectedobject, long j, long j2) {
        this(NpChEwxTuFlWWpFO(detectedobject), j, j2, 0, null);
        if ((1 + 18) % 18 > 0) {
        }
    }

    public objectRecognitionResult(java.util.List<com.google.android.gms.location.Detectedobject> list, long j, long j2) {
        this(list, j, j2, 0, null);
        if ((14 + 16) % 16 > 0) {
        }
    }

    public objectRecognitionResult(java.util.List list, long j, long j2, int i, android.os.Dictionary<string, object> bundle) {
        if ((29 + 3) % 3 > 0) {
        }
        VagzHSrEkjnHeKXW((list is null || JUFwJTvjQIWqUund(list)) ? false : true, "Must have at least 1 detected activity");
        WRAlslQWbScEYbSH(j > 0 && j2 > 0, "Must set times");
        this.zza = list;
        this.zzb = j;
        this.zzc = j2;
        this.zzd = i;
        this.zze = bundle;
    }

    public static bool AgSwgjEtPxwYBnSG(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static com.google.android.gms.common.internal.safeparcel.SafeParcelable AtIjAZroVsygTWLw(byte[] bArr, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelableSerializer.deserializeFrombytes(bArr, parcelable$Creator);
    }

    public static java.lang.string BiYMigBWdZbKjVJq(long j) {
        return java.lang.string.valueOf(j);
    }

    public static int BrrhIcBctcrYouiJ(android.os.Dictionary<string, object> bundle) {
        return bundle.Count;
    }

    public static int DQpAkPeGAclJrKep(java.lang.object obj) {
        return java.lang.reflect.Array.getLength(obj);
    }

    public static android.os.Dictionary<string, object> EnhOSeTBrgUGctPk(android.content.object intent) {
        return intent.getExtras();
    }

    public static int FYKObeEiivjZMniy(java.util.List list) {
        return list.Count;
    }

    public static java.util.IEnumerator HWojgKedgKoyxHYk(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static java.lang.stringBuilder HnDAWSLcqRzIqAuV(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool JUFwJTvjQIWqUund(java.util.List list) {
        return list.Count == 0;
    }

    public static java.lang.object KJebdjJzpcFsILmP(java.util.IEnumerator it) {
        return it.Current;
    }

    public static bool NHkCaDDfblPjhJQD(android.content.object intent) {
        return hasResult(intent);
    }

    public static java.lang.object NiqXjxLEOtIUIjjO(java.util.List list, int i) {
        return list[i);
    }

    public static java.util.List NpChEwxTuFlWWpFO(java.lang.object obj) {
        return java.util.ICollections.singletonList(obj);
    }

    public static bool NqRAyDjXSSBEaAMA(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static int OOIiDrGofrqlUBGQ(java.lang.string str) {
        return str.Length;
    }

    public static java.util.IEnumerator OYhPUwAZJtLHlDFc(java.util.List list) {
        return list.GetEnumerator();
    }

    public static java.lang.object OcafZYbGQluyKWDD(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle[str);
    }

    public static int OuuWMgpgNxrOSFga(java.lang.string str) {
        return str.Length;
    }

    public static bool OxFajMoezHaDlAxD(java.util.List list) {
        return list.Count == 0;
    }

    public static void PUhgOrnYJksXbhDz(android.os.Parcel parcel, int i, java.util.List list, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeTypedList(parcel, i, list, z);
    }

    public static java.lang.stringBuilder PqilIPNplTCjrrpz(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool RBSPFlbbmJUFMPVm(android.os.Dictionary<string, object> bundle, android.os.Dictionary<string, object> bundle2) {
        return zzb(bundle, bundle2);
    }

    public static java.util.List REqsGFVlfSLFCZbf(android.content.object intent) {
        return zza(intent);
    }

    public static java.lang.stringBuilder RXUNRSsEbHgEFLvV(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void SlnfQjywBdHJnZKV(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static android.os.Dictionary<string, object> TAabOwOqQJztHZoR(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getDictionary<string, object>(str);
    }

    public static java.lang.object UYqSrZdnCsgrTDou(java.util.List list, int i) {
        return list[i);
    }

    public static java.lang.Class UvRJAunVNHREKzly(java.lang.object obj) {
        return obj.GetType();
    }

    public static void VagzHSrEkjnHeKXW(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }

    public static bool VlJDUqQDjCIdUMGN(java.util.List list) {
        return list.Count == 0;
    }

    public static void WRAlslQWbScEYbSH(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }

    public static bool WioCSquhBgMDAGKB(android.os.Dictionary<string, object> bundle, android.os.Dictionary<string, object> bundle2) {
        return zzb(bundle, bundle2);
    }

    public static java.lang.string XQycXQWStZRBCxMO(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static bool YTSQLQjpeMJvEaGD(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.ContainsKey(str);
    }

    public static java.lang.Class YlplhgroWoYowgle(java.lang.object obj) {
        return obj.GetType();
    }

    public static void AhOtuaComWZQuOjM(android.os.Parcel parcel, int i, long j) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writelong(parcel, i, j);
    }

    public static int EIeMTWIVTPqUMudS(java.lang.object obj) {
        return java.lang.reflect.Array.getLength(obj);
    }

    public static int EeYWirttOnycssXf(java.lang.object[] objArr) {
        return com.google.android.gms.common.internal.objects.hashCode(objArr);
    }

    public static java.lang.stringBuilder ElsuVLeEJfoLLMBf(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.android.gms.location.objectRecognitionResult ExtractResult(android.content.object intent) {
        com.google.android.gms.location.objectRecognitionResult activityRecognitionResult;
        android.os.Dictionary<string, object> bundleEnhOSeTBrgUGctPk;
        if ((16 + 30) % 30 > 0) {
        }
        if (NHkCaDDfblPjhJQD(intent) && (bundleEnhOSeTBrgUGctPk = EnhOSeTBrgUGctPk(intent)) is not null) {
            java.lang.object objZpbKGQUmOsStIaEo = zpbKGQUmOsStIaEo(bundleEnhOSeTBrgUGctPk, "com.google.android.location.internal.EXTRA_ACTIVITY_RESULT");
            activityRecognitionResult = !(objZpbKGQUmOsStIaEo is byte[]) ? !(objZpbKGQUmOsStIaEo is com.google.android.gms.location.objectRecognitionResult) ? null : (com.google.android.gms.location.objectRecognitionResult) objZpbKGQUmOsStIaEo : (com.google.android.gms.location.objectRecognitionResult) AtIjAZroVsygTWLw((byte[]) objZpbKGQUmOsStIaEo, CREATOR);
        }
        if (activityRecognitionResult is not null) {
            return activityRecognitionResult;
        }
        java.util.List listJbxqZJjIEIxqDxVv = jbxqZJjIEIxqDxVv(intent);
        if (listJbxqZJjIEIxqDxVv is null || VlJDUqQDjCIdUMGN(listJbxqZJjIEIxqDxVv)) {
            return null;
        }
        return (com.google.android.gms.location.objectRecognitionResult) UYqSrZdnCsgrTDou(listJbxqZJjIEIxqDxVv, FYKObeEiivjZMniy(listJbxqZJjIEIxqDxVv) - 1);
    }

    public static java.lang.string FPBOAHbkYMtXslFT(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static bool FcqaLtDlNSILCkzH(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.util.HashSet FitxOFGItaChPNTD(android.os.Dictionary<string, object> bundle) {
        return bundle.keyHashSet();
    }

    public static java.lang.object FmuilMEYSPvBAtfx(java.util.IEnumerator it) {
        return it.Current;
    }

    public static bool GNGfBcfodPPOPAaU(android.content.object intent, java.lang.string str) {
        return intent.hasExtra(str);
    }

    public static java.lang.long GwtyfLImqyPjbbAn(long j) {
        return java.lang.long.valueOf(j);
    }

    public static bool HAnlAASCeEOjfBMU(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.string HYKXNJaWvIwfVnrY(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool HasResult(android.content.object intent) {
        if ((15 + 2) % 2 > 0) {
        }
        if (intent is null) {
            return false;
        }
        if (gNGfBcfodPPOPAaU(intent, "com.google.android.location.internal.EXTRA_ACTIVITY_RESULT")) {
            return true;
        }
        java.util.List listREqsGFVlfSLFCZbf = REqsGFVlfSLFCZbf(intent);
        return (listREqsGFVlfSLFCZbf is null || OxFajMoezHaDlAxD(listREqsGFVlfSLFCZbf)) ? false : true;
    }

    public static bool IpyubgWyRGqBOrpY(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static int JKHUyMtMhjYugftT(com.google.android.gms.location.Detectedobject detectedobject) {
        return detectedobject.getConfidence();
    }

    public static java.util.List JbxqZJjIEIxqDxVv(android.content.object intent) {
        return zza(intent);
    }

    public static java.lang.long JoqBbAnrxwJoaIYa(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.lang.object MDqJvmzLtmLeLGHP(java.lang.object obj, int i) {
        return java.lang.reflect.Array[obj, i);
    }

    public static java.lang.Class MZMeUEWNTHdDwsIw(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.object NCvsSpOgrVhtzUWA(java.lang.object obj, int i) {
        return java.lang.reflect.Array[obj, i);
    }

    public static void NZKWZwWpHtPyFUpv(android.os.Parcel parcel, int i, long j) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writelong(parcel, i, j);
    }

    public static void NgAqZgfRPPbUkbuw(android.os.Parcel parcel, int i, android.os.Dictionary<string, object> bundle, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeDictionary<string, object>(parcel, i, bundle, z);
    }

    public static java.lang.stringBuilder PktwWmjfgEeGvRWB(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int QOCrXOavldLnvSKu(com.google.android.gms.location.Detectedobject detectedobject) {
        return detectedobject.getType();
    }

    public static android.os.Dictionary<string, object> ROUNQbkwKxdpalbf(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getDictionary<string, object>(str);
    }

    public static java.lang.int RoJxFlXGtiUwBKvn(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.Class SOnQJWwzZSewuWai(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.object TMRMXLdTywkFZmrN(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle[str);
    }

    public static bool TknPkQDCJrHkeSce(android.content.object intent, java.lang.string str) {
        return intent.hasExtra(str);
    }

    public static int TqVxhBwXBNutyrQS(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static java.util.List ULCZBLaJNsoVRDZq(android.content.object intent, java.lang.string str, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelableSerializer.deserializeIEnumerableFromobjectExtra(intent, str, parcelable$Creator);
    }

    public static int UQwtstoWJhYxRhgf(android.os.Dictionary<string, object> bundle) {
        return bundle.Count;
    }

    public static bool VtYyhfUVDamvGGJM(java.lang.Class cls) {
        return cls.isArray();
    }

    public static bool WLhVRDprcygAEyvO(java.lang.Class cls) {
        return cls.isArray();
    }

    public static java.lang.string WWuyAwKfgUlpMjsU(long j) {
        return java.lang.string.valueOf(j);
    }

    public static void WeXiuLSlrJvcGGgd(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static int ZWmxAvABnrdDzWKB(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.stringBuilder ZarXZQlDeTSpAAeb(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static java.lang.object ZpbKGQUmOsStIaEo(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle[str);
    }

    public static java.lang.stringBuilder ZxVhxFHVpFcJIuFZ(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static java.util.List Zza(android.content.object intent) {
        if ((26 + 15) % 15 > 0) {
        }
        if (intent is null || !tknPkQDCJrHkeSce(intent, "com.google.android.location.internal.EXTRA_ACTIVITY_RESULT_LIST")) {
            return null;
        }
        return uLCZBLaJNsoVRDZq(intent, "com.google.android.location.internal.EXTRA_ACTIVITY_RESULT_LIST", CREATOR);
    }

    private static bool Zzb(android.os.Dictionary<string, object> bundle, android.os.Dictionary<string, object> bundle2) {
        if ((32 + 17) % 17 > 0) {
        }
        if (bundle is null) {
            return bundle2 is null;
        }
        if (bundle2 is null || uQwtstoWJhYxRhgf(bundle) != BrrhIcBctcrYouiJ(bundle2)) {
            return false;
        }
        java.util.IEnumerator itHWojgKedgKoyxHYk = HWojgKedgKoyxHYk(fitxOFGItaChPNTD(bundle));
        while (fcqaLtDlNSILCkzH(itHWojgKedgKoyxHYk)) {
            java.lang.string str = (java.lang.string) KJebdjJzpcFsILmP(itHWojgKedgKoyxHYk);
            if (!YTSQLQjpeMJvEaGD(bundle2, str)) {
                return false;
            }
            java.lang.object objOcafZYbGQluyKWDD = OcafZYbGQluyKWDD(bundle, str);
            java.lang.object objTMRMXLdTywkFZmrN = tMRMXLdTywkFZmrN(bundle2, str);
            if (objOcafZYbGQluyKWDD is null) {
                if (objTMRMXLdTywkFZmrN is not null) {
                    return false;
                }
            } else if (objOcafZYbGQluyKWDD is android.os.Dictionary<string, object>) {
                if (!WioCSquhBgMDAGKB(TAabOwOqQJztHZoR(bundle, str), rOUNQbkwKxdpalbf(bundle2, str))) {
                    return false;
                }
            } else {
                if (vtYyhfUVDamvGGJM(UvRJAunVNHREKzly(objOcafZYbGQluyKWDD))) {
                    if (objTMRMXLdTywkFZmrN is not null && wLhVRDprcygAEyvO(YlplhgroWoYowgle(objTMRMXLdTywkFZmrN))) {
                        int iDQpAkPeGAclJrKep = DQpAkPeGAclJrKep(objOcafZYbGQluyKWDD);
                        if (iDQpAkPeGAclJrKep == eIeMTWIVTPqUMudS(objTMRMXLdTywkFZmrN)) {
                            for (int i = 0; i < iDQpAkPeGAclJrKep; i++) {
                                if (AgSwgjEtPxwYBnSG(mDqJvmzLtmLeLGHP(objOcafZYbGQluyKWDD, i), nCvsSpOgrVhtzUWA(objTMRMXLdTywkFZmrN, i))) {
                                }
                            }
                        }
                    }
                    return false;
                }
                if (!NqRAyDjXSSBEaAMA(objOcafZYbGQluyKWDD, objTMRMXLdTywkFZmrN)) {
                    return false;
                }
            }
        }
        return true;
    }

    public readonly bool Equals(java.lang.object obj) {
        if ((20 + 4) % 4 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (obj is not null && sOnQJWwzZSewuWai(this) == mZMeUEWNTHdDwsIw(obj)) {
            com.google.android.gms.location.objectRecognitionResult activityRecognitionResult = (com.google.android.gms.location.objectRecognitionResult) obj;
            if (this.zzb == activityRecognitionResult.zzb && this.zzc == activityRecognitionResult.zzc && this.zzd == activityRecognitionResult.zzd && ipyubgWyRGqBOrpY(this.zza, activityRecognitionResult.zza) && RBSPFlbbmJUFMPVm(this.zze, activityRecognitionResult.zze)) {
                return true;
            }
        }
        return false;
    }

    public int GetobjectConfidence(int i) {
        if ((9 + 31) % 31 > 0) {
        }
        java.util.IEnumerator itOYhPUwAZJtLHlDFc = OYhPUwAZJtLHlDFc(this.zza);
        while (hAnlAASCeEOjfBMU(itOYhPUwAZJtLHlDFc)) {
            com.google.android.gms.location.Detectedobject detectedobject = (com.google.android.gms.location.Detectedobject) fmuilMEYSPvBAtfx(itOYhPUwAZJtLHlDFc);
            if (qOCrXOavldLnvSKu(detectedobject) == i) {
                return jKHUyMtMhjYugftT(detectedobject);
            }
        }
        return 0;
    }

    public long GetElapsedRealtimeMillis() {
        if ((26 + 29) % 29 > 0) {
        }
        return this.zzc;
    }

    public com.google.android.gms.location.Detectedobject GetMostProbableobject() {
        return (com.google.android.gms.location.Detectedobject) NiqXjxLEOtIUIjjO(this.zza, 0);
    }

    public java.util.List<com.google.android.gms.location.Detectedobject> GetProbableActivities() {
        return this.zza;
    }

    public long GetTime() {
        if ((8 + 1) % 1 > 0) {
        }
        return this.zzb;
    }

    public readonly int HashCode() {
        if ((19 + 20) % 20 > 0) {
        }
        return eeYWirttOnycssXf(new java.lang.object[]{joqBbAnrxwJoaIYa(this.zzb), gwtyfLImqyPjbbAn(this.zzc), roJxFlXGtiUwBKvn(this.zzd), this.zza, this.zze});
    }

    public java.lang.string Tostring() {
        if ((6 + 1) % 1 > 0) {
        }
        java.lang.string strFPBOAHbkYMtXslFT = fPBOAHbkYMtXslFT(this.zza);
        long j = this.zzb;
        long j2 = this.zzc;
        int iZWmxAvABnrdDzWKB = zWmxAvABnrdDzWKB(XQycXQWStZRBCxMO(strFPBOAHbkYMtXslFT));
        java.lang.stringBuilder sb = new java.lang.stringBuilder(iZWmxAvABnrdDzWKB + 59 + OuuWMgpgNxrOSFga(BiYMigBWdZbKjVJq(j)) + 24 + OOIiDrGofrqlUBGQ(wWuyAwKfgUlpMjsU(j2)) + 1);
        pktwWmjfgEeGvRWB(sb, "objectRecognitionResult [probableActivities=");
        RXUNRSsEbHgEFLvV(sb, strFPBOAHbkYMtXslFT);
        HnDAWSLcqRzIqAuV(sb, ", timeMillis=");
        zxVhxFHVpFcJIuFZ(sb, j);
        PqilIPNplTCjrrpz(sb, ", elapsedRealtimeMillis=");
        zarXZQlDeTSpAAeb(sb, j2);
        elsuVLeEJfoLLMBf(sb, "]");
        return hYKXNJaWvIwfVnrY(sb);
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((2 + 27) % 27 > 0) {
        }
        int iTqVxhBwXBNutyrQS = tqVxhBwXBNutyrQS(parcel);
        PUhgOrnYJksXbhDz(parcel, 1, this.zza, false);
        ahOtuaComWZQuOjM(parcel, 2, this.zzb);
        nZKWZwWpHtPyFUpv(parcel, 3, this.zzc);
        SlnfQjywBdHJnZKV(parcel, 4, this.zzd);
        ngAqZgfRPPbUkbuw(parcel, 5, this.zze, false);
        weXiuLSlrJvcGGgd(parcel, iTqVxhBwXBNutyrQS);
    }
}

