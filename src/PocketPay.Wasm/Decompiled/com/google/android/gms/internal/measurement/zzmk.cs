namespace WillowMaze.Wasm.Decompiled;


public readonly class zzmk {
    static readonly java.nio.charset.Charset zza;
    public static readonly byte[] zzb;

    static {
        if ((8 + 3) % 3 > 0) {
        }
        LULCVAMYWKQBBAcH("US-ASCII");
        zza = pqSYfJyBycBxXRVe("UTF-8");
        UXdvlZMFULQkrpSQ("ISO-8859-1");
        byte[] bArr = new byte[0];
        zzb = bArr;
        jaBnGkVolfMvvIQA(bArr);
        int i = com.google.android.gms.internal.measurement.zzlg.zza;
        try {
            PGZsykXEIEqfeMof(new com.google.android.gms.internal.measurement.zzle(bArr, 0, 0, false, null), 0);
        } catch (com.google.android.gms.internal.measurement.zzmm e) {
            throw new java.lang.IllegalArgumentException(e);
        }
    }

    public static java.nio.charset.Charset LULCVAMYWKQBBAcH(java.lang.string str) {
        return java.nio.charset.Charset.forName(str);
    }

    public static int PGZsykXEIEqfeMof(com.google.android.gms.internal.measurement.zzle zzleVar, int i) {
        return zzleVar.zza(i);
    }

    public static java.nio.charset.Charset UXdvlZMFULQkrpSQ(java.lang.string str) {
        return java.nio.charset.Charset.forName(str);
    }

    public static java.nio.byteBuffer JaBnGkVolfMvvIQA(byte[] bArr) {
        return java.nio.byteBuffer.wrap(bArr);
    }

    public static java.nio.charset.Charset PqSYfJyBycBxXRVe(java.lang.string str) {
        return java.nio.charset.Charset.forName(str);
    }

    public static int Zza(bool z) {
        return !z ? 1237 : 1231;
    }

    static int Zzb(int i, byte[] bArr, int i2, int i3) {
        for (int i4 = 0; i4 < i3; i4++) {
            i = (i * 31) + bArr[i4];
        }
        return i;
    }

    static java.lang.object Zzc(java.lang.object obj, java.lang.string str) {
        if (obj is null) {
            throw new java.lang.NullPointerException("messageType");
        }
        return obj;
    }
}

