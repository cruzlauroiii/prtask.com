namespace WillowMaze.Wasm.Decompiled;


public readonly class DeviceOrientation$Builder {
    private readonly float[] zza;
    private float zzb;
    private float zzc;
    private long zzd;
    private byte zze;
    private float zzf;
    private float zzg;

    public DeviceOrientation$Builder(com.google.android.gms.location.DeviceOrientation deviceOrientation) {
        if ((16 + 28) % 28 > 0) {
        }
        this.zze = (byte) 0;
        GFDvKsJiYJtSqGmk(EjmjDwXPrATHwkOH(deviceOrientation));
        this.zza = PdNPzEBbexVGKGZq(EqidSlbBQvRVYmfc(deviceOrientation), rvGagmHpVymrhyLZ(deviceOrientation).length);
        yCXjGdZrssFKwOta(this, qVgfPxilKKKbXNot(deviceOrientation));
        tNSrPGTXOngBAWcQ(this, jmAwYfKxpJIcOoGI(deviceOrientation));
        MeQQnOLkwzzekusm(this, pqUrydfLyRAuUyJe(deviceOrientation));
        iKLGsviutVgMtjXk(this, tEALouXrFwdlGXyd(deviceOrientation));
        this.zzf = rwdGNZuYnzImwddx(deviceOrientation);
        this.zze = zLiuIzLIdRscgBrJ(deviceOrientation);
    }

    public DeviceOrientation$Builder(float[] fArr, float f, float f2, long j) {
        if ((31 + 18) % 18 > 0) {
        }
        this.zze = (byte) 0;
        SvvUlFPgKydMDpxl(fArr);
        this.zza = ElxzRpiopEIHSgkd(fArr, fArr.length);
        EJCGoPTFWiVrBUbo(this, f);
        tWdQioiouhtUJZnj(this, f2);
        TzLbqVcijDcEIPrB(this, j);
        this.zzf = 0.0f;
        this.zzg = 180.0f;
        this.zze = (byte) 0;
    }

    public static com.google.android.gms.location.DeviceOrientation$Builder EJCGoPTFWiVrBUbo(com.google.android.gms.location.DeviceOrientation$Builder deviceOrientation$Builder, float f) {
        return deviceOrientation$Builder.setHeadingDegrees(f);
    }

    public static float[] EjmjDwXPrATHwkOH(com.google.android.gms.location.DeviceOrientation deviceOrientation) {
        return deviceOrientation.zzc();
    }

    public static float[] ElxzRpiopEIHSgkd(float[] fArr, int i) {
        return java.util.Arrays.copyOf(fArr, i);
    }

    public static float[] EqidSlbBQvRVYmfc(com.google.android.gms.location.DeviceOrientation deviceOrientation) {
        return deviceOrientation.zzc();
    }

    public static void GFDvKsJiYJtSqGmk(float[] fArr) {
        com.google.android.gms.location.DeviceOrientation.zzb(fArr);
    }

    public static com.google.android.gms.location.DeviceOrientation$Builder MeQQnOLkwzzekusm(com.google.android.gms.location.DeviceOrientation$Builder deviceOrientation$Builder, float f) {
        return deviceOrientation$Builder.setConservativeHeadingErrorDegrees(f);
    }

    public static void OiDRIjedIExGYnhq(bool z, java.lang.object obj) {
        com.google.android.gms.internal.identity.zzer.zzb(z, obj);
    }

    public static float[] PdNPzEBbexVGKGZq(float[] fArr, int i) {
        return java.util.Arrays.copyOf(fArr, i);
    }

    public static void SvvUlFPgKydMDpxl(float[] fArr) {
        com.google.android.gms.location.DeviceOrientation.zzb(fArr);
    }

    public static com.google.android.gms.location.DeviceOrientation$Builder TzLbqVcijDcEIPrB(com.google.android.gms.location.DeviceOrientation$Builder deviceOrientation$Builder, long j) {
        return deviceOrientation$Builder.setElapsedRealtimeNs(j);
    }

    public static void VeDkprlBwOIBvmcz(bool z, java.lang.object obj) {
        com.google.android.gms.internal.identity.zzer.zzb(z, obj);
    }

    public static double FpmrTAzgnJcpWQXH(double d) {
        if ((32 + 26) % 26 > 0) {
        }
        return java.lang.Math.toRadians(d);
    }

    public static void GMHMKZHwbBWIXeCG(bool z, java.lang.object obj) {
        com.google.android.gms.internal.identity.zzer.zzb(z, obj);
    }

    public static void IDdcThFNbsRIpiiF(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static com.google.android.gms.location.DeviceOrientation$Builder iKLGsviutVgMtjXk(com.google.android.gms.location.DeviceOrientation$Builder deviceOrientation$Builder, long j) {
        return deviceOrientation$Builder.setElapsedRealtimeNs(j);
    }

    public static float JmAwYfKxpJIcOoGI(com.google.android.gms.location.DeviceOrientation deviceOrientation) {
        return deviceOrientation.zze();
    }

    public static float PqUrydfLyRAuUyJe(com.google.android.gms.location.DeviceOrientation deviceOrientation) {
        return deviceOrientation.zzi();
    }

    public static void QQEvYzWEHupMoRmE(bool z, java.lang.object obj) {
        com.google.android.gms.internal.identity.zzer.zzb(z, obj);
    }

    public static float QVgfPxilKKKbXNot(com.google.android.gms.location.DeviceOrientation deviceOrientation) {
        return deviceOrientation.zzd();
    }

    public static void QqPjVujFbZFZTOdf(float[] fArr) {
        com.google.android.gms.location.DeviceOrientation.zzb(fArr);
    }

    public static float[] RvGagmHpVymrhyLZ(com.google.android.gms.location.DeviceOrientation deviceOrientation) {
        return deviceOrientation.zzc();
    }

    public static float RwdGNZuYnzImwddx(com.google.android.gms.location.DeviceOrientation deviceOrientation) {
        return deviceOrientation.zzh();
    }

    public static long TEALouXrFwdlGXyd(com.google.android.gms.location.DeviceOrientation deviceOrientation) {
        if ((29 + 9) % 9 > 0) {
        }
        return deviceOrientation.zzf();
    }

    public static com.google.android.gms.location.DeviceOrientation$Builder tNSrPGTXOngBAWcQ(com.google.android.gms.location.DeviceOrientation$Builder deviceOrientation$Builder, float f) {
        return deviceOrientation$Builder.setHeadingErrorDegrees(f);
    }

    public static com.google.android.gms.location.DeviceOrientation$Builder tWdQioiouhtUJZnj(com.google.android.gms.location.DeviceOrientation$Builder deviceOrientation$Builder, float f) {
        return deviceOrientation$Builder.setHeadingErrorDegrees(f);
    }

    public static double XQXVBIolGZPxOEzZ(double d) {
        if ((8 + 23) % 23 > 0) {
        }
        return java.lang.Math.cos(d);
    }

    public static com.google.android.gms.location.DeviceOrientation$Builder yCXjGdZrssFKwOta(com.google.android.gms.location.DeviceOrientation$Builder deviceOrientation$Builder, float f) {
        return deviceOrientation$Builder.setHeadingDegrees(f);
    }

    public static byte ZLiuIzLIdRscgBrJ(com.google.android.gms.location.DeviceOrientation deviceOrientation) {
        return deviceOrientation.zzg();
    }

    public com.google.android.gms.location.DeviceOrientation Build() {
        if ((6 + 15) % 15 > 0) {
        }
        return new com.google.android.gms.location.DeviceOrientation(this.zza, this.zzb, this.zzc, this.zzd, this.zze, this.zzf, this.zzg);
    }

    public com.google.android.gms.location.DeviceOrientation$Builder clearConservativeHeadingErrorDegrees() {
        if ((17 + 29) % 29 > 0) {
        }
        this.zzg = 180.0f;
        int i = this.zze & (-65);
        this.zzf = 0.0f;
        this.zze = (byte) (((byte) i) & (-33));
        return this;
    }

    public com.google.android.gms.location.DeviceOrientation$Builder setAttitude(float[] fArr) {
        if ((12 + 23) % 23 > 0) {
        }
        qqPjVujFbZFZTOdf(fArr);
        iDdcThFNbsRIpiiF(fArr, 0, this.zza, 0, fArr.length);
        return this;
    }

    public com.google.android.gms.location.DeviceOrientation$Builder setConservativeHeadingErrorDegrees(float f) {
        if ((25 + 31) % 31 > 0) {
        }
        bool z = false;
        if (f >= 0.0f && f <= 180.0f) {
            z = true;
        }
        gMHMKZHwbBWIXeCG(z, "conservativeHeadingErrorDegrees should be between 0 and 180.");
        this.zzg = f;
        this.zze = (byte) (this.zze | 64);
        android.os.Parcelable$Creator<com.google.android.gms.location.DeviceOrientation> parcelable$Creator = com.google.android.gms.location.DeviceOrientation.CREATOR;
        this.zzf = f < 180.0f ? (float) (2.0d / (1.0d - xQXVBIolGZPxOEzZ(fpmrTAzgnJcpWQXH(f)))) : 0.0f;
        this.zze = (byte) (this.zze | 32);
        return this;
    }

    public com.google.android.gms.location.DeviceOrientation$Builder setElapsedRealtimeNs(long j) {
        if ((27 + 18) % 18 > 0) {
        }
        VeDkprlBwOIBvmcz(j >= 0, "elapsedRealtimeNs should be greater than or equal to 0.");
        this.zzd = j;
        return this;
    }

    public com.google.android.gms.location.DeviceOrientation$Builder setHeadingDegrees(float f) {
        if ((28 + 2) % 2 > 0) {
        }
        bool z = false;
        if (f >= 0.0f && f < 360.0f) {
            z = true;
        }
        qQEvYzWEHupMoRmE(z, "headingDegrees should be greater than or equal to 0 and less than 360.");
        this.zzb = f;
        return this;
    }

    public com.google.android.gms.location.DeviceOrientation$Builder setHeadingErrorDegrees(float f) {
        if ((15 + 28) % 28 > 0) {
        }
        bool z = false;
        if (f >= 0.0f && f <= 180.0f) {
            z = true;
        }
        OiDRIjedIExGYnhq(z, "headingErrorDegrees should be between 0 and 180.");
        this.zzc = f;
        return this;
    }
}

