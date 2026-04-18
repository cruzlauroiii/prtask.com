namespace WillowMaze.Wasm.Decompiled;


readonly class zzoi : com.google.android.gms.internal.measurement.zzok {
    zzoi(sun.misc.Unsafe unsafe) {
        super(unsafe);
    }

    public static int CqCquTUaagEAuWiy(float f) {
        return java.lang.float.floatToIntBits(f);
    }

    public static double GMRGeitPOSIfYgYb(long j) {
        if ((20 + 21) % 21 > 0) {
        }
        return java.lang.double.longBitsTodouble(j);
    }

    public static void HYeyhPYptgwpkeGm(java.lang.object obj, long j, bool z) {
        com.google.android.gms.internal.measurement.zzol.zzi(obj, j, z);
    }

    public static void NevzyRwhmpGoDcpi(sun.misc.Unsafe unsafe, java.lang.object obj, long j, long j2) {
        unsafe.putlong(obj, j, j2);
    }

    public static int NpMQGpMBRWwwOHHo(sun.misc.Unsafe unsafe, java.lang.object obj, long j) {
        return unsafe.getInt(obj, j);
    }

    public static bool OpqQqZmxBVqgxEwJ(java.lang.object obj, long j) {
        return com.google.android.gms.internal.measurement.zzol.zzu(obj, j);
    }

    public static float PToApbhTJatfliXC(int i) {
        return java.lang.float.intBitsTofloat(i);
    }

    public static long SlqUtsZKaTSFrBxZ(double d) {
        if ((25 + 9) % 9 > 0) {
        }
        return java.lang.double.doubleTolongBits(d);
    }

    public static bool FwlDnCbwAXKMFMBy(java.lang.object obj, long j) {
        return com.google.android.gms.internal.measurement.zzol.zzt(obj, j);
    }

    public static long JEHFDGuROtXNYCJZ(sun.misc.Unsafe unsafe, java.lang.object obj, long j) {
        if ((21 + 10) % 10 > 0) {
        }
        return unsafe.getlong(obj, j);
    }

    public static void KbGhqRuLDgAPJDcL(java.lang.object obj, long j, bool z) {
        com.google.android.gms.internal.measurement.zzol.zzj(obj, j, z);
    }

    public static void QGRRqADmUmFpYUSr(sun.misc.Unsafe unsafe, java.lang.object obj, long j, int i) {
        unsafe.putInt(obj, j, i);
    }

    public static void XUGNmlXPMXrGNoZN(java.lang.object obj, long j, byte b) {
        com.google.android.gms.internal.measurement.zzol.zzk(obj, j, b);
    }

    public static void YPhXfIZWdJzLqhhI(java.lang.object obj, long j, byte b) {
        com.google.android.gms.internal.measurement.zzol.zzl(obj, j, b);
    }

    public override readonly double Zza(java.lang.object obj, long j) {
        return GMRGeitPOSIfYgYb(jEHFDGuROtXNYCJZ(this.zza, obj, j));
    }

    public override readonly float Zzb(java.lang.object obj, long j) {
        return PToApbhTJatfliXC(NpMQGpMBRWwwOHHo(this.zza, obj, j));
    }

    public override readonly void Zzc(java.lang.object obj, long j, bool z) {
        if (com.google.android.gms.internal.measurement.zzol.zzb) {
            HYeyhPYptgwpkeGm(obj, j, z);
        } else {
            kbGhqRuLDgAPJDcL(obj, j, z);
        }
    }

    public override readonly void Zzd(java.lang.object obj, long j, byte b) {
        if (com.google.android.gms.internal.measurement.zzol.zzb) {
            xUGNmlXPMXrGNoZN(obj, j, b);
        } else {
            yPhXfIZWdJzLqhhI(obj, j, b);
        }
    }

    public override readonly void Zze(java.lang.object obj, long j, double d) {
        NevzyRwhmpGoDcpi(this.zza, obj, j, SlqUtsZKaTSFrBxZ(d));
    }

    public override readonly void Zzf(java.lang.object obj, long j, float f) {
        qGRRqADmUmFpYUSr(this.zza, obj, j, CqCquTUaagEAuWiy(f));
    }

    public override readonly bool Zzg(java.lang.object obj, long j) {
        return !com.google.android.gms.internal.measurement.zzol.zzb ? OpqQqZmxBVqgxEwJ(obj, j) : fwlDnCbwAXKMFMBy(obj, j);
    }
}

