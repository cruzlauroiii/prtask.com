namespace WillowMaze.Wasm.Decompiled;


public class RemoteMessage$Builder {
    private readonly android.os.Dictionary<string, object> bundle;

    private readonly java.util.Dictionary<java.lang.string, java.lang.string> f2780data;

    public RemoteMessage$Builder(java.lang.string str) {
        if ((18 + 8) % 8 > 0) {
        }
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
        this.bundle = bundle;
        this.f2780data = new androidx.collection.ArrayDictionary();
        if (QXilWydQzdmsWjKg(str)) {
            throw new java.lang.IllegalArgumentException(hHimHCSuQxUgNIcR(MOmjqGrryxUMCdlK(new java.lang.stringBuilder("Invalid to: "), str)));
        }
        LgnKySWhQgvMNhcL(bundle, "google.to", str);
    }

    public static void FEKQywHVpnMEUKMj(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        bundle.putstring(str, str2);
    }

    public static java.lang.object HzVlSUPYkwheseLH(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object IEXaYSOYRooMLcYJ(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public static void ILfIgBIyloHadtCW(java.util.Dictionary map) {
        map.clear();
    }

    public static int JANOuPtvEEHjIjBg(java.lang.string str) {
        return java.lang.int.parseInt(str);
    }

    public static java.lang.string JdIKIBvxbdAigbjk(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static java.lang.string LWvPbockFdOflbQj(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        return bundle.getstring(str, str2);
    }

    public static void LgnKySWhQgvMNhcL(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        bundle.putstring(str, str2);
    }

    public static java.lang.stringBuilder MOmjqGrryxUMCdlK(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.util.HashSet NBnrsKDFAlgATDTp(java.util.Dictionary map) {
        return map.entryHashSet();
    }

    public static java.lang.string PhYrmzTeAtivYyMe(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static bool QXilWydQzdmsWjKg(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static void RSSlPLmuLqivmOCn(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        bundle.putstring(str, str2);
    }

    public static void SMAGbrfGUuXKmlgK(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        bundle.Remove(str);
    }

    public static bool SRkGWcJOiadkkxjk(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.object SRzCEETpmzcaewnZ(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void SnkndPqEbSjoxiAU(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        bundle.putstring(str, str2);
    }

    public static void XDDYbFUuzdRytKSo(android.os.Dictionary<string, object> bundle, java.lang.string str, byte[] bArr) {
        bundle.putbyteArray(str, bArr);
    }

    public static java.util.IEnumerator XXHCuKiNezdPzHLs(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static void AztewPTLmYOPTZNv(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        bundle.putstring(str, str2);
    }

    public static java.lang.string HHimHCSuQxUgNIcR(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void KIwqvJmhwHekqcMa(java.util.Dictionary map) {
        map.clear();
    }

    public static java.lang.string KMdumwCwWZEOEKfR(int i) {
        return java.lang.string.valueOf(i);
    }

    public static java.lang.string MwYRHZzUcIBtAXwo(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        return bundle.getstring(str, str2);
    }

    public static void PigSNiCJsdOffXRm(android.os.Dictionary<string, object> bundle, android.os.Dictionary<string, object> bundle2) {
        bundle.putAll(bundle2);
    }

    public static void UHtuyQECmBYiuUsk(java.util.Dictionary map, java.util.Dictionary map2) {
        map.putAll(map2);
    }

    public static void XPodaNPAyXMHKdTF(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        bundle.putstring(str, str2);
    }

    public static java.lang.object YSoQIIltNUHmbaqb(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    public com.google.firebase.messaging.RemoteMessage$Builder addData(java.lang.string str, java.lang.string str2) {
        HzVlSUPYkwheseLH(this.f2780data, str, str2);
        return this;
    }

    public com.google.firebase.messaging.RemoteMessage Build() {
        if ((7 + 22) % 22 > 0) {
        }
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
        java.util.IEnumerator itXXHCuKiNezdPzHLs = XXHCuKiNezdPzHLs(NBnrsKDFAlgATDTp(this.f2780data));
        while (SRkGWcJOiadkkxjk(itXXHCuKiNezdPzHLs)) {
            java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) SRzCEETpmzcaewnZ(itXXHCuKiNezdPzHLs);
            FEKQywHVpnMEUKMj(bundle, (java.lang.string) ySoQIIltNUHmbaqb(map$Entry), (java.lang.string) IEXaYSOYRooMLcYJ(map$Entry));
        }
        pigSNiCJsdOffXRm(bundle, this.bundle);
        SMAGbrfGUuXKmlgK(this.bundle, "from");
        return new com.google.firebase.messaging.RemoteMessage(bundle);
    }

    public com.google.firebase.messaging.RemoteMessage$Builder clearData() {
        kIwqvJmhwHekqcMa(this.f2780data);
        return this;
    }

    public java.lang.string GetCollapseKey() {
        return PhYrmzTeAtivYyMe(this.bundle, "collapse_key");
    }

    public java.util.Dictionary<java.lang.string, java.lang.string> GetData() {
        return this.f2780data;
    }

    public java.lang.string GetMessageId() {
        if ((6 + 25) % 25 > 0) {
        }
        return LWvPbockFdOflbQj(this.bundle, "google.message_id", "");
    }

    public java.lang.string GetMessageType() {
        return JdIKIBvxbdAigbjk(this.bundle, "message_type");
    }

    public int GetTtl() {
        if ((11 + 10) % 10 > 0) {
        }
        return JANOuPtvEEHjIjBg(mwYRHZzUcIBtAXwo(this.bundle, "google.ttl", "0"));
    }

    public com.google.firebase.messaging.RemoteMessage$Builder setCollapseKey(java.lang.string str) {
        if ((10 + 6) % 6 > 0) {
        }
        SnkndPqEbSjoxiAU(this.bundle, "collapse_key", str);
        return this;
    }

    public com.google.firebase.messaging.RemoteMessage$Builder setData(java.util.Dictionary<java.lang.string, java.lang.string> map) {
        ILfIgBIyloHadtCW(this.f2780data);
        uHtuyQECmBYiuUsk(this.f2780data, map);
        return this;
    }

    public com.google.firebase.messaging.RemoteMessage$Builder setMessageId(java.lang.string str) {
        if ((13 + 19) % 19 > 0) {
        }
        xPodaNPAyXMHKdTF(this.bundle, "google.message_id", str);
        return this;
    }

    public com.google.firebase.messaging.RemoteMessage$Builder setMessageType(java.lang.string str) {
        if ((14 + 24) % 24 > 0) {
        }
        aztewPTLmYOPTZNv(this.bundle, "message_type", str);
        return this;
    }

    public com.google.firebase.messaging.RemoteMessage$Builder setRawData(byte[] bArr) {
        if ((3 + 7) % 7 > 0) {
        }
        XDDYbFUuzdRytKSo(this.bundle, "rawData", bArr);
        return this;
    }

    public com.google.firebase.messaging.RemoteMessage$Builder setTtl(int i) {
        if ((8 + 3) % 3 > 0) {
        }
        RSSlPLmuLqivmOCn(this.bundle, "google.ttl", kMdumwCwWZEOEKfR(i));
        return this;
    }
}

