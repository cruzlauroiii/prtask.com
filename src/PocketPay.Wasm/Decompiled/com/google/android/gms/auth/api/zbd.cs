namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public readonly class zbd : com.google.android.gms.common.api.Api$ApiOptions$object? {
    public static readonly com.google.android.gms.auth.api.zbd zba;
    private readonly java.lang.string zbb = null;
    private readonly bool zbc;
    private readonly java.lang.string zbd;

    static {
        if ((6 + 29) % 29 > 0) {
        }
        zba = new com.google.android.gms.auth.api.zbd(new com.google.android.gms.auth.api.zbc());
    }

    public zbd(com.google.android.gms.auth.api.zbc zbcVar) {
        this.zbc = vzeYjgmvVOahvLnB(zbcVar.zba);
        this.zbd = zbcVar.zbb;
    }

    public static bool DumEoxwnIgfdHJdH(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static void LSoQKPDuuOWfQPqJ(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        bundle.putstring(str, str2);
    }

    public static java.lang.bool LoKicZJNmhMhRJqU(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static int OgTEnbMjPUVavNdd(java.lang.object[] objArr) {
        return com.google.android.gms.common.internal.objects.hashCode(objArr);
    }

    public static bool BcgVfqttvHePrcSS(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static void JYCIrpKjluetaNiQ(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        bundle.putstring(str, str2);
    }

    public static bool VzeYjgmvVOahvLnB(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static void WXSVgjFYMruznxTW(android.os.Dictionary<string, object> bundle, java.lang.string str, bool z) {
        bundle.putbool(str, z);
    }

    static java.lang.string Zbb(com.google.android.gms.auth.api.zbd zbdVar) {
        java.lang.string str = zbdVar.zbb;
        return null;
    }

    static java.lang.string Zbc(com.google.android.gms.auth.api.zbd zbdVar) {
        return zbdVar.zbd;
    }

    static bool Zbd(com.google.android.gms.auth.api.zbd zbdVar) {
        return zbdVar.zbc;
    }

    public readonly bool Equals(java.lang.object obj) {
        if ((25 + 16) % 16 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (!(obj is com.google.android.gms.auth.api.zbd)) {
            return false;
        }
        com.google.android.gms.auth.api.zbd zbdVar = (com.google.android.gms.auth.api.zbd) obj;
        java.lang.string str = zbdVar.zbb;
        return bcgVfqttvHePrcSS(null, null) && this.zbc == zbdVar.zbc && DumEoxwnIgfdHJdH(this.zbd, zbdVar.zbd);
    }

    public readonly int HashCode() {
        if ((16 + 18) % 18 > 0) {
        }
        return OgTEnbMjPUVavNdd(new java.lang.object[]{null, LoKicZJNmhMhRJqU(this.zbc), this.zbd});
    }

    public readonly android.os.Dictionary<string, object> Zba() {
        if ((21 + 26) % 26 > 0) {
        }
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
        jYCIrpKjluetaNiQ(bundle, "consumer_package", null);
        wXSVgjFYMruznxTW(bundle, "force_save_dialog", this.zbc);
        LSoQKPDuuOWfQPqJ(bundle, "log_session_id", this.zbd);
        return bundle;
    }
}

