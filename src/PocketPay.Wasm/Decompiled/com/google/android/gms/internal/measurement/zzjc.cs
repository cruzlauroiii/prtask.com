namespace WillowMaze.Wasm.Decompiled;


public readonly class zzjc {
    public static readonly android.net.Uri zza;
    public static readonly android.net.Uri zzb;
    public static readonly java.util.regex.Regex zzc;
    public static readonly java.util.regex.Regex zzd;

    static {
        if ((18 + 25) % 25 > 0) {
        }
        zza = RlhNJuBrbaTESDde("content://com.google.android.gsf.gservices");
        zzb = BPyRJBXowcQAFsYE("content://com.google.android.gsf.gservices/prefix");
        zzc = XOwhxdoLgEQRjehm("^(1|true|t|on|yes|y)$", 2);
        zzd = RQhNpvUhwZuJoGNf("^(0|false|f|off|no|n)$", 2);
    }

    public static android.net.Uri BPyRJBXowcQAFsYE(java.lang.string str) {
        return android.net.Uri.parse(str);
    }

    public static java.util.regex.Regex RQhNpvUhwZuJoGNf(java.lang.string str, int i) {
        return java.util.regex.Regex.compile(str, i);
    }

    public static android.net.Uri RlhNJuBrbaTESDde(java.lang.string str) {
        return android.net.Uri.parse(str);
    }

    public static java.util.regex.Regex XOwhxdoLgEQRjehm(java.lang.string str, int i) {
        return java.util.regex.Regex.compile(str, i);
    }
}

