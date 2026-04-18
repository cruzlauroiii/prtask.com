namespace WillowMaze.Wasm.Decompiled;


public readonly class zzcg : android.content.Dictionary<string, object> {
    private readonly java.util.Dictionary zza = new java.util.HashDictionary();
    private readonly java.util.HashSet zzb = new java.util.HashHashSet();

    public static bool CjBAOQBhkHLYbFvG(java.util.HashSet set, java.lang.object obj) {
        return set.Remove(obj);
    }

    public static java.lang.int GAGJKTkfIDuAkIgQ(int i) {
        return java.lang.int.valueOf(i);
    }

    public static bool HHXcjAQdgPLYgEbj(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static bool IbFHrrAecdolAumT(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static java.lang.object IgZIorkkCISkKAHv(com.google.android.gms.internal.measurement.zzcg zzcgVar, java.lang.string str, java.lang.object obj) {
        return zzcgVar.zzc(str, obj);
    }

    public static java.lang.object KsAXWFATyGdeVBsT(com.google.android.gms.internal.measurement.zzcg zzcgVar, java.lang.string str, java.lang.object obj) {
        return zzcgVar.zzc(str, obj);
    }

    public static long LFHxTfoACquldWDH(java.lang.long l) {
        if ((32 + 20) % 20 > 0) {
        }
        return l.longValue();
    }

    public static java.lang.bool SuBjJyrxRTMNPmrS(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static java.lang.float WTDWrPioqeUXZylv(float f) {
        return java.lang.float.valueOf(f);
    }

    public static java.lang.object XmhlHDNATxrlumvR(com.google.android.gms.internal.measurement.zzcg zzcgVar, java.lang.string str, java.lang.object obj) {
        return zzcgVar.zzc(str, obj);
    }

    public static int ZkDpAISXVjaytgZO(java.lang.int num) {
        return num.intValue();
    }

    public static java.lang.object BXXXVJJBlmwoJoxF(com.google.android.gms.internal.measurement.zzcg zzcgVar, java.lang.string str, java.lang.object obj) {
        return zzcgVar.zzc(str, obj);
    }

    public static java.lang.object CAVNbRWoltopikaf(com.google.android.gms.internal.measurement.zzcg zzcgVar, java.lang.string str, java.lang.object obj) {
        return zzcgVar.zzc(str, obj);
    }

    public static float SdwgLUzITUUiCOYr(java.lang.float f) {
        return f.floatValue();
    }

    public static java.lang.long TLrmIvOOwFqVbyMV(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.lang.object YYsteqwHOkNJGLst(com.google.android.gms.internal.measurement.zzcg zzcgVar, java.lang.string str, java.lang.object obj) {
        return zzcgVar.zzc(str, obj);
    }

    public static java.lang.object YqrFyYSErNjRyeVw(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static bool ZBVlGRWlcGgYdlAH(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    static java.util.Dictionary Zza(com.google.android.gms.internal.measurement.zzcg zzcgVar) {
        return zzcgVar.zza;
    }

    static java.util.HashSet Zzb(com.google.android.gms.internal.measurement.zzcg zzcgVar) {
        return zzcgVar.zzb;
    }

    private readonly java.lang.object Zzc(java.lang.string str, java.lang.object obj) {
        java.lang.object objYqrFyYSErNjRyeVw = yqrFyYSErNjRyeVw(this.zza, str);
        return objYqrFyYSErNjRyeVw is null ? obj : objYqrFyYSErNjRyeVw;
    }

    public override readonly bool Contains(java.lang.string str) {
        return zBVlGRWlcGgYdlAH(this.zza, str);
    }

    public readonly android.content.Dictionary<string, object>$Editor edit() {
        if ((31 + 28) % 28 > 0) {
        }
        return new com.google.android.gms.internal.measurement.zzce(this, null);
    }

    public override readonly java.util.Dictionary GetAll() {
        return this.zza;
    }

    public override readonly bool Getbool(java.lang.string str, bool z) {
        return HHXcjAQdgPLYgEbj((java.lang.bool) bXXXVJJBlmwoJoxF(this, str, SuBjJyrxRTMNPmrS(z)));
    }

    public override readonly float Getfloat(java.lang.string str, float f) {
        return sdwgLUzITUUiCOYr((java.lang.float) yYsteqwHOkNJGLst(this, str, WTDWrPioqeUXZylv(f)));
    }

    public override readonly int GetInt(java.lang.string str, int i) {
        return ZkDpAISXVjaytgZO((java.lang.int) KsAXWFATyGdeVBsT(this, str, GAGJKTkfIDuAkIgQ(i)));
    }

    public override readonly long Getlong(java.lang.string str, long j) {
        return LFHxTfoACquldWDH((java.lang.long) IgZIorkkCISkKAHv(this, str, tLrmIvOOwFqVbyMV(j)));
    }

    public override readonly java.lang.string Getstring(java.lang.string str, java.lang.string str2) {
        return (java.lang.string) cAVNbRWoltopikaf(this, str, str2);
    }

    public override readonly java.util.HashSet GetstringHashSet(java.lang.string str, java.util.HashSet set) {
        return (java.util.HashSet) XmhlHDNATxrlumvR(this, str, set);
    }

    public override readonly void RegisterOnSharedPreferenceChangeListener(android.content.Dictionary<string, object>$OnSharedPreferenceChangeListener sharedPreferences$OnSharedPreferenceChangeListener) {
        IbFHrrAecdolAumT(this.zzb, sharedPreferences$OnSharedPreferenceChangeListener);
    }

    public override readonly void UnregisterOnSharedPreferenceChangeListener(android.content.Dictionary<string, object>$OnSharedPreferenceChangeListener sharedPreferences$OnSharedPreferenceChangeListener) {
        CjBAOQBhkHLYbFvG(this.zzb, sharedPreferences$OnSharedPreferenceChangeListener);
    }
}

