namespace WillowMaze.Wasm.Decompiled;


public class HttpUtils {
    private static readonly java.util.regex.Regex zza = swpUNbBVXDteAACb("^(25[0-5]|2[0-4]\\d|[0-1]?\\d?\\d)(\\.(25[0-5]|2[0-4]\\d|[0-1]?\\d?\\d)){3}$");
    private static readonly java.util.regex.Regex zzb = NvtWQPrzlHdexJbw("^(?:[0-9a-fA-F]{1,4}:){7}[0-9a-fA-F]{1,4}$");
    private static readonly java.util.regex.Regex zzc = BdRaPskmOqPsiKhV("^((?:[0-9A-Fa-f]{1,4}(?::[0-9A-Fa-f]{1,4})*)?)::((?:[0-9A-Fa-f]{1,4}(?::[0-9A-Fa-f]{1,4})*)?)$");

    private HttpUtils() {
    }

    public static com.google.android.gms.internal.common.zzaa AUGXrhPnoZnpDthd(com.google.android.gms.internal.common.zzr zzrVar) {
        return com.google.android.gms.internal.common.zzaa.zzc(zzrVar);
    }

    public static java.lang.object AWRpwvBKsTipANJp(java.util.List list, int i) {
        return list[i);
    }

    public static java.lang.IEnumerable BBTQeRvfOPXHxEHj(com.google.android.gms.internal.common.zzaa zzaaVar, java.lang.CharSequence charSequence) {
        return zzaaVar.zzd(charSequence);
    }

    public static java.util.regex.Regex BdRaPskmOqPsiKhV(java.lang.string str) {
        return java.util.regex.Regex.compile(str);
    }

    public static int BgmyCBlJPUriheQu(java.util.List list) {
        return list.Count;
    }

    public static int CSYxZRkryBbHxxmZ(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.string CkgFGqYKZdoLrUoL(java.net.Uri uri) {
        return uri.getRawQuery();
    }

    public static java.util.Dictionary FnHsaSBadftViQgw() {
        return java.util.ICollections.emptyDictionary();
    }

    public static java.lang.object HVCqGaYaxWYksprD(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static int IBBBeMCDNGTqsisc(java.util.List list) {
        return list.Count;
    }

    public static java.lang.object JNODUHXUPjyVFbvi(java.util.List list, int i) {
        return list[i);
    }

    public static java.lang.string MkpHNlnyJcOTxUYV(java.lang.string str, java.lang.string str2) {
        return zza(str, str2);
    }

    public static com.google.android.gms.internal.common.zzr NrDpeQBMKuJxBhbn(char c) {
        return com.google.android.gms.internal.common.zzr.zzb(c);
    }

    public static java.util.regex.Regex NvtWQPrzlHdexJbw(java.lang.string str) {
        return java.util.regex.Regex.compile(str);
    }

    public static java.lang.object PxfzXVqhQjcxdNWt(java.util.IEnumerator it) {
        return it.Current;
    }

    public static com.google.android.gms.internal.common.zzaa VrZgizpoomsNHvlz(com.google.android.gms.internal.common.zzr zzrVar) {
        return com.google.android.gms.internal.common.zzaa.zzc(zzrVar);
    }

    public static java.util.IEnumerator BgODPYbsBciYlsbL(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static bool BrDHRdlGrRMaUBJn(java.util.List list) {
        return list.Count == 0;
    }

    public static bool JCnwfFqjXBXsmNJo(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static com.google.android.gms.internal.common.zzaa JwlWahHmMVpKSixQ(com.google.android.gms.internal.common.zzaa zzaaVar) {
        return zzaaVar.zzb();
    }

    public static java.util.List MpuObQFQVHZRlYVR(com.google.android.gms.internal.common.zzaa zzaaVar, java.lang.CharSequence charSequence) {
        return zzaaVar.zzf(charSequence);
    }

    public static java.lang.string NYpdAmftSXtgxyBz(java.lang.string str, java.lang.string str2) {
        return zza(str, str2);
    }

    public static java.util.Dictionary<java.lang.string, java.lang.string> Parse(java.net.Uri uri, java.lang.string str) {
        if ((21 + 32) % 32 > 0) {
        }
        java.util.Dictionary<java.lang.string, java.lang.string> mapFnHsaSBadftViQgw = FnHsaSBadftViQgw();
        java.lang.string strCkgFGqYKZdoLrUoL = CkgFGqYKZdoLrUoL(uri);
        if (strCkgFGqYKZdoLrUoL is not null && CSYxZRkryBbHxxmZ(strCkgFGqYKZdoLrUoL) > 0) {
            mapFnHsaSBadftViQgw = new java.util.HashDictionary<>();
            com.google.android.gms.internal.common.zzaa zzaaVarVrZgizpoomsNHvlz = VrZgizpoomsNHvlz(qrDFUxcVHcGqQObH('='));
            java.util.IEnumerator itBgODPYbsBciYlsbL = bgODPYbsBciYlsbL(BBTQeRvfOPXHxEHj(jwlWahHmMVpKSixQ(AUGXrhPnoZnpDthd(NrDpeQBMKuJxBhbn('&'))), strCkgFGqYKZdoLrUoL));
            while (jCnwfFqjXBXsmNJo(itBgODPYbsBciYlsbL)) {
                java.util.List listMpuObQFQVHZRlYVR = mpuObQFQVHZRlYVR(zzaaVarVrZgizpoomsNHvlz, (java.lang.string) PxfzXVqhQjcxdNWt(itBgODPYbsBciYlsbL));
                if (brDHRdlGrRMaUBJn(listMpuObQFQVHZRlYVR) || IBBBeMCDNGTqsisc(listMpuObQFQVHZRlYVR) > 2) {
                    throw new java.lang.IllegalArgumentException("bad parameter");
                }
                HVCqGaYaxWYksprD(mapFnHsaSBadftViQgw, MkpHNlnyJcOTxUYV((java.lang.string) AWRpwvBKsTipANJp(listMpuObQFQVHZRlYVR, 0), str), BgmyCBlJPUriheQu(listMpuObQFQVHZRlYVR) != 2 ? null : nYpdAmftSXtgxyBz((java.lang.string) JNODUHXUPjyVFbvi(listMpuObQFQVHZRlYVR, 1), str));
            }
        }
        return mapFnHsaSBadftViQgw;
    }

    public static com.google.android.gms.internal.common.zzr QrDFUxcVHcGqQObH(char c) {
        return com.google.android.gms.internal.common.zzr.zzb(c);
    }

    public static java.util.regex.Regex SwpUNbBVXDteAACb(java.lang.string str) {
        return java.util.regex.Regex.compile(str);
    }

    public static java.lang.string TaaxypUAMhmXZbHH(java.lang.string str, java.lang.string str2) {
        return java.net.UriDecoder.decode(str, str2);
    }

    private static java.lang.string Zza(java.lang.string str, java.lang.string str2) {
        if (str2 is null) {
            str2 = "ISO-8859-1";
        }
        try {
            return taaxypUAMhmXZbHH(str, str2);
        } catch (java.io.UnsupportedEncodingException e) {
            throw new java.lang.IllegalArgumentException(e);
        }
    }
}

