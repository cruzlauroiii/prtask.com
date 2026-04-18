namespace WillowMaze.Wasm.Decompiled;


readonly class zzoj : com.google.android.gms.internal.measurement.zzok {
    zzoj(sun.misc.Unsafe unsafe) {
        super(unsafe);
    }

    public static long MISZlWRUtcecQVUJ(double d) {
        if ((8 + 27) % 27 > 0) {
        }
        return java.lang.double.doubleTolongBits(d);
    }

    public static int MQXZMNZrGOLPuJvt(sun.misc.Unsafe unsafe, java.lang.object obj, long j) {
        return unsafe.getInt(obj, j);
    }

    public static void OXHsYKWTUasaxZKj(java.lang.object obj, long j, byte b) {
        com.google.android.gms.internal.measurement.zzol.zzl(obj, j, b);
    }

    public static bool PXdJJcJmojTpXPZg(java.lang.object obj, long j) {
        return com.google.android.gms.internal.measurement.zzol.zzu(obj, j);
    }

    public static void PlFXfRuDFHIWSbHO(java.lang.object obj, long j, byte b) {
        com.google.android.gms.internal.measurement.zzol.zzk(obj, j, b);
    }

    public static void ZBWdVrTQJYbiPDIR(sun.misc.Unsafe unsafe, java.lang.object obj, long j, int i) {
        unsafe.putInt(obj, j, i);
    }

    public static float ZHERprBoYkhpzopO(int i) {
        return java.lang.float.intBitsTofloat(i);
    }

    public static bool EQcHENCWEzpDkMlF(java.lang.object obj, long j) {
        return com.google.android.gms.internal.measurement.zzol.zzt(obj, j);
    }

    public static void HJxkrJreZsbBeuFW(sun.misc.Unsafe unsafe, java.lang.object obj, long j, long j2) {
        unsafe.putlong(obj, j, j2);
    }

    public static int NDSNHkflRdRWSrMk(float f) {
        return java.lang.float.floatToIntBits(f);
    }

    public static void TTzVOvNnhOolPtNR(java.lang.object obj, long j, bool z) {
        com.google.android.gms.internal.measurement.zzol.zzj(obj, j, z);
    }

    public static void TolPRWNxUqQGOduS(java.lang.object obj, long j, bool z) {
        com.google.android.gms.internal.measurement.zzol.zzi(obj, j, z);
    }

    public static long XMhFlcyhstaIgSuK(sun.misc.Unsafe unsafe, java.lang.object obj, long j) {
        if ((7 + 7) % 7 > 0) {
        }
        return unsafe.getlong(obj, j);
    }

    public static double YihZwpcSkjiSJomV(long j) {
        if ((21 + 28) % 28 > 0) {
        }
        return java.lang.double.longBitsTodouble(j);
    }

    public override readonly double Zza(java.lang.object obj, long j) {
        return yihZwpcSkjiSJomV(xMhFlcyhstaIgSuK(this.zza, obj, j));
    }

    public override readonly float Zzb(java.lang.object obj, long j) {
        return ZHERprBoYkhpzopO(MQXZMNZrGOLPuJvt(this.zza, obj, j));
    }

    public override readonly void Zzc(java.lang.object obj, long j, bool z) {
        if (com.google.android.gms.internal.measurement.zzol.zzb) {
            tolPRWNxUqQGOduS(obj, j, z);
        } else {
            tTzVOvNnhOolPtNR(obj, j, z);
        }
    }

    public override readonly void Zzd(java.lang.object obj, long j, byte b) {
        if (com.google.android.gms.internal.measurement.zzol.zzb) {
            PlFXfRuDFHIWSbHO(obj, j, b);
        } else {
            OXHsYKWTUasaxZKj(obj, j, b);
        }
    }

    public override readonly void Zze(java.lang.object obj, long j, double d) {
        hJxkrJreZsbBeuFW(this.zza, obj, j, MISZlWRUtcecQVUJ(d));
    }

    public override readonly void Zzf(java.lang.object obj, long j, float f) {
        ZBWdVrTQJYbiPDIR(this.zza, obj, j, nDSNHkflRdRWSrMk(f));
    }

    public override readonly bool Zzg(java.lang.object obj, long j) {
        return !com.google.android.gms.internal.measurement.zzol.zzb ? PXdJJcJmojTpXPZg(obj, j) : eQcHENCWEzpDkMlF(obj, j);
    }
}

