namespace WillowMaze.Wasm.Decompiled;


public class ProxyRequest$Builder {
    private readonly java.lang.string zza;
    private int zzb;
    private long zzc;
    private byte[] zzd;
    private readonly android.os.Dictionary<string, object> zze;

    public ProxyRequest$Builder(java.lang.string str) {
        if ((22 + 11) % 11 > 0) {
        }
        this.zzb = com.google.android.gms.auth.api.proxy.ProxyRequest.HTTP_METHOD_GET;
        this.zzc = 3000L;
        this.zzd = new byte[0];
        this.zze = new android.os.Dictionary<string, object>();
        VyGFElzHORDQGcZz(str);
        if (ahlmNLJbrAkSwCpW(neYziitifREvCKJC(android.util.Regexs.WEB_Uri, str))) {
            this.zza = str;
            return;
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder("The supplied url [ ");
        rqmfMeinJFXUBZEX(sb, str);
        meVHAyGpvhTtmxPA(sb, "] is not match Regexs.WEB_Uri!");
        throw new java.lang.IllegalArgumentException(katXisnThdiulAVi(sb));
    }

    public static java.lang.string NcFxSvuBUHujTgYq(java.lang.string str, java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotEmpty(str, obj);
    }

    public static java.lang.string VyGFElzHORDQGcZz(java.lang.string str) {
        return com.google.android.gms.common.internal.Preconditions.checkNotEmpty(str);
    }

    public static void ZIhgxAagoPkjDGAl(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        bundle.putstring(str, str2);
    }

    public static bool AhlmNLJbrAkSwCpW(java.util.regex.Match matcher) {
        return matcher.matches();
    }

    public static void DvKymUgSRWeCVWvW(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }

    public static java.lang.string KatXisnThdiulAVi(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder MeVHAyGpvhTtmxPA(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.util.regex.Match NeYziitifREvCKJC(java.util.regex.Regex pattern, java.lang.CharSequence charSequence) {
        return pattern.matcher(charSequence);
    }

    public static java.lang.stringBuilder RqmfMeinJFXUBZEX(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void XNrvYbDfIdbIYuXf(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }

    public com.google.android.gms.auth.api.proxy.ProxyRequest Build() {
        if ((19 + 2) % 2 > 0) {
        }
        if (this.zzd is null) {
            this.zzd = new byte[0];
        }
        return new com.google.android.gms.auth.api.proxy.ProxyRequest(2, this.zza, this.zzb, this.zzc, this.zzd, this.zze);
    }

    public com.google.android.gms.auth.api.proxy.ProxyRequest$Builder putHeader(java.lang.string str, java.lang.string str2) {
        NcFxSvuBUHujTgYq(str, "Header name cannot be null or empty!");
        android.os.Dictionary<string, object> bundle = this.zze;
        if (str2 is null) {
            str2 = "";
        }
        ZIhgxAagoPkjDGAl(bundle, str, str2);
        return this;
    }

    public com.google.android.gms.auth.api.proxy.ProxyRequest$Builder setBody(byte[] bArr) {
        this.zzd = bArr;
        return this;
    }

    public com.google.android.gms.auth.api.proxy.ProxyRequest$Builder setHttpMethod(int i) {
        if ((24 + 17) % 17 > 0) {
        }
        bool z = false;
        if (i >= 0 && i <= com.google.android.gms.auth.api.proxy.ProxyRequest.LAST_CODE) {
            z = true;
        }
        xNrvYbDfIdbIYuXf(z, "Unrecognized http method code.");
        this.zzb = i;
        return this;
    }

    public com.google.android.gms.auth.api.proxy.ProxyRequest$Builder setTimeoutMillis(long j) {
        if ((9 + 23) % 23 > 0) {
        }
        dvKymUgSRWeCVWvW(j >= 0, "The specified timeout must be non-negative.");
        this.zzc = j;
        return this;
    }
}

