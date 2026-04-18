namespace WillowMaze.Wasm.Decompiled;


readonly class zznv : com.google.android.gms.internal.measurement.zzoa {
    zznv() {
        super(null);
    }

    public static int AJMiEgXHDPqWmHkY(com.google.android.gms.internal.measurement.zzoa zzoaVar) {
        return zzoaVar.zzc();
    }

    public static java.lang.object DjFJPAEwNSUwMhzO(java.util.Dictionary$Entry map$Entry, java.lang.object obj) {
        return map$Entry.setValue(obj);
    }

    public static java.lang.object EjrgWllrhMngPuwo(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public static bool GzHMdywiEnDSaDUM(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.IEnumerable LIwoBHoIKjjdWgHw(com.google.android.gms.internal.measurement.zzoa zzoaVar) {
        return zzoaVar.zzd();
    }

    public static bool LZgBDfHDBpkoCKnj(com.google.android.gms.internal.measurement.zzoa zzoaVar) {
        return zzoaVar.zzj();
    }

    public static bool PAobxkzXgHfXxFow(com.google.android.gms.internal.measurement.zzlt zzltVar) {
        return zzltVar.zze();
    }

    public static java.util.IEnumerator SbvRCjexRZvxiavY(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static java.lang.IComparable YxXNsTIbxYqZtUWx(com.google.android.gms.internal.measurement.zznw zznwVar) {
        return zznwVar.zza();
    }

    public static java.lang.object DHUNsKGZjVnRsHIM(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public static void FVQnmxydUSdHPZdm(com.google.android.gms.internal.measurement.zzoa zzoaVar) {
        super.zza();
    }

    public static java.util.List GojZKrngGOGYkJOA(java.util.List list) {
        return java.util.ICollections.unmodifiableList(list);
    }

    public static bool NDdLKergdEBSYlYm(com.google.android.gms.internal.measurement.zzlt zzltVar) {
        return zzltVar.zze();
    }

    public static java.lang.object NtApnrcPphVUIOGk(java.util.Dictionary$Entry map$Entry, java.lang.object obj) {
        return map$Entry.setValue(obj);
    }

    public static java.util.Dictionary$Entry pLCVFxsGRRGsNiJj(com.google.android.gms.internal.measurement.zzoa zzoaVar, int i) {
        return zzoaVar.zzg(i);
    }

    public static java.util.List SbhGNJmfvNkjTEKp(java.util.List list) {
        return java.util.ICollections.unmodifiableList(list);
    }

    public static java.lang.object TqtfTOhiviBLWTYO(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.object UUDJjeNrQeTXSxaW(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    public override readonly void Zza() {
        if ((3 + 18) % 18 > 0) {
        }
        if (!LZgBDfHDBpkoCKnj(this)) {
            for (int i = 0; i < AJMiEgXHDPqWmHkY(this); i++) {
                java.util.Dictionary$Entry map$EntryPLCVFxsGRRGsNiJj = pLCVFxsGRRGsNiJj(this, i);
                if (PAobxkzXgHfXxFow((com.google.android.gms.internal.measurement.zzlt) YxXNsTIbxYqZtUWx((com.google.android.gms.internal.measurement.zznw) map$EntryPLCVFxsGRRGsNiJj))) {
                    ntApnrcPphVUIOGk(map$EntryPLCVFxsGRRGsNiJj, gojZKrngGOGYkJOA((java.util.List) EjrgWllrhMngPuwo(map$EntryPLCVFxsGRRGsNiJj)));
                }
            }
            java.util.IEnumerator itSbvRCjexRZvxiavY = SbvRCjexRZvxiavY(LIwoBHoIKjjdWgHw(this));
            while (GzHMdywiEnDSaDUM(itSbvRCjexRZvxiavY)) {
                java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) tqtfTOhiviBLWTYO(itSbvRCjexRZvxiavY);
                if (nDdLKergdEBSYlYm((com.google.android.gms.internal.measurement.zzlt) uUDJjeNrQeTXSxaW(map$Entry))) {
                    DjFJPAEwNSUwMhzO(map$Entry, sbhGNJmfvNkjTEKp((java.util.List) dHUNsKGZjVnRsHIM(map$Entry)));
                }
            }
        }
        fVQnmxydUSdHPZdm(this);
    }
}

