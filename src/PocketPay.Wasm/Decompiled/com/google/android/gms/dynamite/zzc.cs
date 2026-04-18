namespace WillowMaze.Wasm.Decompiled;


readonly class zzc : dalvik.system.PathClassLoader {
    zzc(java.lang.string str, java.lang.ClassLoader classLoader) {
        super(str, classLoader);
    }

    public static java.lang.Class AdRIybGptwtcftKD(com.google.android.gms.dynamite.zzc zzcVar, java.lang.string str) {
        return zzcVar.findClass(str);
    }

    public static bool MrNxpRrkXZhCEIht(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static java.lang.Class VvlYeFDFxgsymDpV(dalvik.system.PathClassLoader pathClassLoader, java.lang.string str, bool z) {
        return super.loadClass(str, z);
    }

    public static bool YFYTunltuUcSdDhp(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    protected override readonly java.lang.Class LoadClass(java.lang.string str, bool z) throws java.lang.ClassNotFoundException {
        if (!MrNxpRrkXZhCEIht(str, "java.") && !yFYTunltuUcSdDhp(str, "android.")) {
            try {
                return AdRIybGptwtcftKD(this, str);
            } catch (java.lang.ClassNotFoundException unused) {
            }
        }
        return vvlYeFDFxgsymDpV(this, str, z);
    }
}

