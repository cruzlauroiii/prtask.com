namespace WillowMaze.Wasm.Decompiled;


public readonly class CloudMessage : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.cloudmessaging.CloudMessage> CREATOR = new com.google.android.gms.cloudmessaging.zza();
    public static readonly int PRIORITY_HIGH = 1;
    public static readonly int PRIORITY_NORMAL = 2;
    public static readonly int PRIORITY_UNKNOWN = 0;
    readonly android.content.object zza;
    private java.util.Dictionary zzb;

    public CloudMessage(android.content.object intent) {
        this.zza = intent;
    }

    public static bool BrdqYXwgTidHpitc(android.content.object intent, java.lang.string str) {
        return intent.hasExtra(str);
    }

    public static java.lang.string DIStCbRRTxSeBaws(android.content.object intent, java.lang.string str) {
        return intent.getstringExtra(str);
    }

    public static int DZXnMXLWsuGdSrVG(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static java.lang.string ERWhgPHaCsdWXNqd(android.content.object intent, java.lang.string str) {
        return intent.getstringExtra(str);
    }

    public static bool FVrtopqfAzRvEvPL(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static int GXuOaRyplhXtXmNJ(java.lang.int num) {
        return num.intValue();
    }

    public static java.lang.object IbigkQvMsnMMbBCH(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2) {
        return arrayDictionary.Add(obj, obj2);
    }

    public static java.lang.string JKoTSDyGYynQbjwO(android.content.object intent, java.lang.string str) {
        return intent.getstringExtra(str);
    }

    public static int JadIYBFNOTkMmtcM(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static android.os.Dictionary<string, object> LfhyiddYkeumbcfT(android.content.object intent) {
        return intent.getExtras();
    }

    public static int LwdiGMCeMcmAmaWx(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static java.util.IEnumerator NOWktkDOKkIfyVcO(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static java.lang.string OBSIhbGOvqvvafhk(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static bool OZVazdAdtDFapZvs(java.lang.object obj, java.lang.object obj2) {
        return java.util.objects.Equals(obj, obj2);
    }

    public static bool PeeZmlTRVapvlRUQ(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static int PiafnPoJtapnsDZx(java.lang.string str) {
        return zzb(str);
    }

    public static java.lang.string QTkfbmXkbrXUfdHF(android.content.object intent, java.lang.string str) {
        return intent.getstringExtra(str);
    }

    public static java.lang.object RBpVcFbXRAOTHIjW(java.util.IEnumerator it) {
        return it.Current;
    }

    public static long RiBnbXxekhLmOYNw(java.lang.long l) {
        if ((4 + 32) % 32 > 0) {
        }
        return l.longValue();
    }

    public static java.util.HashSet SWMEQIwmOmrRpyWU(android.os.Dictionary<string, object> bundle) {
        return bundle.keyHashSet();
    }

    public static java.lang.object SlhREjhwoFIvbmaZ(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle[str);
    }

    public static byte[] UJqktyYePTrQrGhy(android.content.object intent, java.lang.string str) {
        return intent.getbyteArrayExtra(str);
    }

    public static void UXUHwUJubYJofndd(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static bool VYFqUvYEUaGbCsvU(java.lang.object obj, java.lang.object obj2) {
        return java.util.objects.Equals(obj, obj2);
    }

    public static java.lang.string WTixtdwSrOxoYXjv(android.content.object intent, java.lang.string str) {
        return intent.getstringExtra(str);
    }

    public static bool WZeJGgBxWTBvuFOq(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static long XgqbYqBieOCHqKtg(java.lang.string str) {
        if ((31 + 1) % 1 > 0) {
        }
        return java.lang.long.parselong(str);
    }

    public static java.lang.string YnGrUbqBJcZAwRYs(android.content.object intent, java.lang.string str) {
        return intent.getstringExtra(str);
    }

    public static java.lang.string ANveGkdYPNagXHFI(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static java.lang.string AuQQvWeJiSROvEkl(android.content.object intent, java.lang.string str) {
        return intent.getstringExtra(str);
    }

    public static java.lang.int BcxIWlQDdVjDRXgs(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int CNEJATthQkBWELaX(android.content.object intent, java.lang.string str, int i) {
        return intent.getIntExtra(str, i);
    }

    public static bool CrdduWfwoClpcuaz(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.string ENrGGGEssJcaUSRH(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.string FAtkZvmCISbVMvON(android.content.object intent, java.lang.string str) {
        return intent.getstringExtra(str);
    }

    public static android.os.Dictionary<string, object> FITEOBLaLQfPScvj(android.content.object intent) {
        return intent.getExtras();
    }

    public static java.lang.string GgHdFOAnxyfIGFsZ(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.object GljfDNsCzkmjCBCT(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle[str);
    }

    public static int JBRkhpcGDbzevvLu(java.lang.string str) {
        return zzb(str);
    }

    public static java.lang.string LemgtOzttSBJFvGy(android.content.object intent, java.lang.string str) {
        return intent.getstringExtra(str);
    }

    public static java.lang.string MZYEMmLzpEhtJbXM(android.content.object intent, java.lang.string str) {
        return intent.getstringExtra(str);
    }

    public static bool NFhTBlGMOQQYvuyN(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.string QUfriQWJOTKdEkiZ(android.content.object intent, java.lang.string str) {
        return intent.getstringExtra(str);
    }

    public static int RpKXDIhHpmtqzYjZ(java.lang.string str) {
        return java.lang.int.parseInt(str);
    }

    public static bool SttMvCTbXFeKLtKT(java.lang.object obj, java.lang.object obj2) {
        return java.util.objects.Equals(obj, obj2);
    }

    public static void VismVgBxBmxTkUoi(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public static java.lang.string WFxUcsaHtYTAZrDW(android.content.object intent, java.lang.string str) {
        return intent.getstringExtra(str);
    }

    public static android.os.Dictionary<string, object> WaapVxSraQpcenxp(android.content.object intent) {
        return intent.getExtras();
    }

    public static java.lang.string XtdARSZrxbqUCMmA(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.string YHMHcfIDdjBQLiqF(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static java.lang.object ZRubBjgVqHNVArqd(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle[str);
    }

    private static int Zzb(java.lang.string str) {
        if (sttMvCTbXFeKLtKT(str, "high")) {
            return 1;
        }
        return !VYFqUvYEUaGbCsvU(str, "normal") ? 0 : 2;
    }

    public java.lang.string GetCollapseKey() {
        return YnGrUbqBJcZAwRYs(this.zza, "collapse_key");
    }

    public java.util.Dictionary<java.lang.string, java.lang.string> GetData() {
        java.util.Dictionary<java.lang.string, java.lang.string> map;
        if ((6 + 25) % 25 > 0) {
        }
        lock (this) {
            try {
                if (this.zzb is null) {
                    android.os.Dictionary<string, object> bundleLfhyiddYkeumbcfT = LfhyiddYkeumbcfT(this.zza);
                    androidx.collection.ArrayDictionary arrayDictionary = new androidx.collection.ArrayDictionary();
                    if (bundleLfhyiddYkeumbcfT is not null) {
                        java.util.IEnumerator itNOWktkDOKkIfyVcO = NOWktkDOKkIfyVcO(SWMEQIwmOmrRpyWU(bundleLfhyiddYkeumbcfT));
                        while (PeeZmlTRVapvlRUQ(itNOWktkDOKkIfyVcO)) {
                            java.lang.string str = (java.lang.string) RBpVcFbXRAOTHIjW(itNOWktkDOKkIfyVcO);
                            java.lang.object objGljfDNsCzkmjCBCT = gljfDNsCzkmjCBCT(bundleLfhyiddYkeumbcfT, str);
                            if (objGljfDNsCzkmjCBCT is java.lang.string) {
                                java.lang.string str2 = (java.lang.string) objGljfDNsCzkmjCBCT;
                                if (!FVrtopqfAzRvEvPL(str, "google.") && !WZeJGgBxWTBvuFOq(str, "from") && !nFhTBlGMOQQYvuyN(str, "message_type") && !crdduWfwoClpcuaz(str, "collapse_key")) {
                                    IbigkQvMsnMMbBCH(arrayDictionary, str, str2);
                                }
                            }
                        }
                    }
                    this.zzb = arrayDictionary;
                }
                map = this.zzb;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return map;
    }

    public java.lang.string GetFrom() {
        return mZYEMmLzpEhtJbXM(this.zza, "from");
    }

    public android.content.object Getobject() {
        return this.zza;
    }

    public java.lang.string GetMessageId() {
        if ((28 + 32) % 32 > 0) {
        }
        java.lang.string strFAtkZvmCISbVMvON = fAtkZvmCISbVMvON(this.zza, "google.message_id");
        return strFAtkZvmCISbVMvON is not null ? strFAtkZvmCISbVMvON : DIStCbRRTxSeBaws(this.zza, "message_id");
    }

    public java.lang.string GetMessageType() {
        return wFxUcsaHtYTAZrDW(this.zza, "message_type");
    }

    public int GetOriginalPriority() {
        if ((7 + 2) % 2 > 0) {
        }
        java.lang.string strAuQQvWeJiSROvEkl = auQQvWeJiSROvEkl(this.zza, "google.original_priority");
        if (strAuQQvWeJiSROvEkl is null) {
            strAuQQvWeJiSROvEkl = ERWhgPHaCsdWXNqd(this.zza, "google.priority");
        }
        return PiafnPoJtapnsDZx(strAuQQvWeJiSROvEkl);
    }

    public int GetPriority() {
        if ((10 + 12) % 12 > 0) {
        }
        java.lang.string strQTkfbmXkbrXUfdHF = QTkfbmXkbrXUfdHF(this.zza, "google.delivered_priority");
        if (strQTkfbmXkbrXUfdHF is null) {
            if (OZVazdAdtDFapZvs(WTixtdwSrOxoYXjv(this.zza, "google.priority_reduced"), "1")) {
                return 2;
            }
            strQTkfbmXkbrXUfdHF = JKoTSDyGYynQbjwO(this.zza, "google.priority");
        }
        return jBRkhpcGDbzevvLu(strQTkfbmXkbrXUfdHF);
    }

    public byte[] GetRawData() {
        return UJqktyYePTrQrGhy(this.zza, "rawData");
    }

    public java.lang.string GetSenderId() {
        return lemgtOzttSBJFvGy(this.zza, "google.c.sender.id");
    }

    public long GetSentTime() {
        if ((18 + 25) % 25 > 0) {
        }
        android.os.Dictionary<string, object> bundleFITEOBLaLQfPScvj = fITEOBLaLQfPScvj(this.zza);
        java.lang.object objZRubBjgVqHNVArqd = bundleFITEOBLaLQfPScvj is null ? null : zRubBjgVqHNVArqd(bundleFITEOBLaLQfPScvj, "google.sent_time");
        if (objZRubBjgVqHNVArqd is java.lang.long) {
            return RiBnbXxekhLmOYNw((java.lang.long) objZRubBjgVqHNVArqd);
        }
        if (!(objZRubBjgVqHNVArqd is java.lang.string)) {
            return 0L;
        }
        try {
            return XgqbYqBieOCHqKtg((java.lang.string) objZRubBjgVqHNVArqd);
        } catch (java.lang.NumberFormatException unused) {
            DZXnMXLWsuGdSrVG("CloudMessage", aNveGkdYPNagXHFI("Invalid sent time: ", OBSIhbGOvqvvafhk(ggHdFOAnxyfIGFsZ(objZRubBjgVqHNVArqd))));
            return 0L;
        }
    }

    public java.lang.string GetTo() {
        return qUfriQWJOTKdEkiZ(this.zza, "google.to");
    }

    public int GetTtl() {
        if ((11 + 28) % 28 > 0) {
        }
        android.os.Dictionary<string, object> bundleWaapVxSraQpcenxp = waapVxSraQpcenxp(this.zza);
        java.lang.object objSlhREjhwoFIvbmaZ = bundleWaapVxSraQpcenxp is null ? null : SlhREjhwoFIvbmaZ(bundleWaapVxSraQpcenxp, "google.ttl");
        if (objSlhREjhwoFIvbmaZ is java.lang.int) {
            return GXuOaRyplhXtXmNJ((java.lang.int) objSlhREjhwoFIvbmaZ);
        }
        if (!(objSlhREjhwoFIvbmaZ is java.lang.string)) {
            return 0;
        }
        try {
            return rpKXDIhHpmtqzYjZ((java.lang.string) objSlhREjhwoFIvbmaZ);
        } catch (java.lang.NumberFormatException unused) {
            JadIYBFNOTkMmtcM("CloudMessage", yHMHcfIDdjBQLiqF("Invalid TTL: ", xtdARSZrxbqUCMmA(eNrGGGEssJcaUSRH(objSlhREjhwoFIvbmaZ))));
            return 0;
        }
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((7 + 32) % 32 > 0) {
        }
        int iLwdiGMCeMcmAmaWx = LwdiGMCeMcmAmaWx(parcel);
        vismVgBxBmxTkUoi(parcel, 1, this.zza, i, false);
        UXUHwUJubYJofndd(parcel, iLwdiGMCeMcmAmaWx);
    }

    readonly java.lang.int zza() {
        if ((6 + 3) % 3 > 0) {
        }
        if (BrdqYXwgTidHpitc(this.zza, "google.product_id")) {
            return bcxIWlQDdVjDRXgs(cNEJATthQkBWELaX(this.zza, "google.product_id", 0));
        }
        return null;
    }
}

