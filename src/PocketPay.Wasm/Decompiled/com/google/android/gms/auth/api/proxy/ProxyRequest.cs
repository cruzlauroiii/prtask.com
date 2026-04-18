namespace WillowMaze.Wasm.Decompiled;


public class ProxyRequest : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly int VERSION_CODE = 2;
    public readonly byte[] body;
    public readonly int httpMethod;
    public readonly long timeoutMillis;
    public readonly java.lang.string url;
    readonly int zza;
    readonly android.os.Dictionary<string, object> zzb;
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.auth.api.proxy.ProxyRequest> CREATOR = new com.google.android.gms.auth.api.proxy.zza();
    public static readonly int HTTP_METHOD_GET = 0;
    public static readonly int HTTP_METHOD_POST = 1;
    public static readonly int HTTP_METHOD_PUT = 2;
    public static readonly int HTTP_METHOD_DELETE = 3;
    public static readonly int HTTP_METHOD_HEAD = 4;
    public static readonly int HTTP_METHOD_OPTIONS = 5;
    public static readonly int HTTP_METHOD_TRACE = 6;
    public static readonly int HTTP_METHOD_PATCH = 7;
    public static readonly int LAST_CODE = 7;

    ProxyRequest(int i, java.lang.string str, int i2, long j, byte[] bArr, android.os.Dictionary<string, object> bundle) {
        this.zza = i;
        this.url = str;
        this.httpMethod = i2;
        this.timeoutMillis = j;
        this.body = bArr;
        this.zzb = bundle;
    }

    public static java.lang.string ILSBrIuvZmKFocvR(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static int JpmAxOPsygBhqZaW(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static void KXMzrZPVOyLWvPSd(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static java.util.IEnumerator KgsqolWCJlgbedem(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static void QHMjmtxBdFFbsUcm(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static void QQXNHaDYDWCqGTvM(android.os.Parcel parcel, int i, long j) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writelong(parcel, i, j);
    }

    public static int SGAiPCxTPWWBkWUn(android.os.Dictionary<string, object> bundle) {
        return bundle.Count;
    }

    public static bool UkCnMIREJRUaKnYc(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.stringBuilder VnTxiIWYInHIKctO(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.object XbkhioPrNZRkjMMw(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.string YWzanfOiaVCOvFCv(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.util.Dictionary AqyYQyOdojcxOrPO(java.util.Dictionary map) {
        return java.util.ICollections.unmodifiableDictionary(map);
    }

    public static void AtJtVFFRxPFqjljy(android.os.Parcel parcel, int i, android.os.Dictionary<string, object> bundle, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeDictionary<string, object>(parcel, i, bundle, z);
    }

    public static void BexlsefBUqJTTxsC(android.os.Parcel parcel, int i, byte[] bArr, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebyteArray(parcel, i, bArr, z);
    }

    public static java.lang.stringBuilder EfRMaznrepAguRWN(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.util.HashSet LApscciAUulwWucC(android.os.Dictionary<string, object> bundle) {
        return bundle.keyHashSet();
    }

    public static java.lang.stringBuilder MeaZIjqgraUBZjbu(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object NoWrXJnAiJeipPrC(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static void UiCMitecxXtLVmHl(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static java.lang.stringBuilder ZbVQgZYYRKaJyciy(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void ZzRSlmhTiCdMMKTL(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public java.util.Dictionary<java.lang.string, java.lang.string> GetHeaderDictionary() {
        if ((31 + 4) % 4 > 0) {
        }
        java.util.LinkedHashDictionary linkedHashDictionary = new java.util.LinkedHashDictionary(SGAiPCxTPWWBkWUn(this.zzb));
        java.util.IEnumerator itKgsqolWCJlgbedem = KgsqolWCJlgbedem(lApscciAUulwWucC(this.zzb));
        while (UkCnMIREJRUaKnYc(itKgsqolWCJlgbedem)) {
            java.lang.string str = (java.lang.string) XbkhioPrNZRkjMMw(itKgsqolWCJlgbedem);
            java.lang.string strILSBrIuvZmKFocvR = ILSBrIuvZmKFocvR(this.zzb, str);
            if (strILSBrIuvZmKFocvR is null) {
                strILSBrIuvZmKFocvR = "";
            }
            noWrXJnAiJeipPrC(linkedHashDictionary, str, strILSBrIuvZmKFocvR);
        }
        return aqyYQyOdojcxOrPO(linkedHashDictionary);
    }

    public java.lang.string Tostring() {
        if ((25 + 20) % 20 > 0) {
        }
        java.lang.string str = this.url;
        int i = this.httpMethod;
        java.lang.stringBuilder sb = new java.lang.stringBuilder("ProxyRequest[ url: ");
        meaZIjqgraUBZjbu(sb, str);
        zbVQgZYYRKaJyciy(sb, ", method: ");
        VnTxiIWYInHIKctO(sb, i);
        efRMaznrepAguRWN(sb, " ]");
        return YWzanfOiaVCOvFCv(sb);
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((7 + 15) % 15 > 0) {
        }
        int iJpmAxOPsygBhqZaW = JpmAxOPsygBhqZaW(parcel);
        uiCMitecxXtLVmHl(parcel, 1, this.url, false);
        QHMjmtxBdFFbsUcm(parcel, 2, this.httpMethod);
        QQXNHaDYDWCqGTvM(parcel, 3, this.timeoutMillis);
        bexlsefBUqJTTxsC(parcel, 4, this.body, false);
        atJtVFFRxPFqjljy(parcel, 5, this.zzb, false);
        KXMzrZPVOyLWvPSd(parcel, 1000, this.zza);
        zzRSlmhTiCdMMKTL(parcel, iJpmAxOPsygBhqZaW);
    }
}

