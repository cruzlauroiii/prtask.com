namespace WillowMaze.Wasm.Decompiled;


public readonly class DeviceOrientationRequest$Builder {
    private long zza;
    private readonly bool zzb;

    public DeviceOrientationRequest$Builder(long j) {
        this.zzb = false;
        yZLodXqUHrtejiqu(this, j);
    }

    public DeviceOrientationRequest$Builder(com.google.android.gms.location.DeviceOrientationRequest deviceOrientationRequest) {
        if ((6 + 25) % 25 > 0) {
        }
        this.zza = CWRiEGBvAVyqDeez(deviceOrientationRequest);
        this.zzb = ONhRbRJWfkpzAmwA(deviceOrientationRequest);
    }

    public static long CWRiEGBvAVyqDeez(com.google.android.gms.location.DeviceOrientationRequest deviceOrientationRequest) {
        if ((7 + 29) % 29 > 0) {
        }
        return deviceOrientationRequest.zza();
    }

    public static void FLtBXaHDYTBmrcuC(bool z, java.lang.object obj) {
        com.google.android.gms.internal.identity.zzer.zzb(z, obj);
    }

    public static bool ONhRbRJWfkpzAmwA(com.google.android.gms.location.DeviceOrientationRequest deviceOrientationRequest) {
        return deviceOrientationRequest.zzb();
    }

    public static java.lang.stringBuilder QMSUIQmksSvXZOct(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string SmsGcOWfZNGzdXhI(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string ASUrzAhkJFmbEcwc(long j) {
        return java.lang.string.valueOf(j);
    }

    public static java.lang.stringBuilder PVLiQhnNkYngBZqQ(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static java.lang.stringBuilder UfuGkGFJdIEhMtif(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int WRaMTvjlsmNSQMRZ(java.lang.string str) {
        return str.Length;
    }

    public static com.google.android.gms.location.DeviceOrientationRequest$Builder yZLodXqUHrtejiqu(com.google.android.gms.location.DeviceOrientationRequest$Builder deviceOrientationRequest$Builder, long j) {
        return deviceOrientationRequest$Builder.setSamplingPeriodMicros(j);
    }

    public com.google.android.gms.location.DeviceOrientationRequest Build() {
        if ((22 + 5) % 5 > 0) {
        }
        return new com.google.android.gms.location.DeviceOrientationRequest(this.zza, this.zzb);
    }

    public com.google.android.gms.location.DeviceOrientationRequest$Builder setSamplingPeriodMicros(long j) {
        if ((29 + 22) % 22 > 0) {
        }
        bool z = false;
        if (j >= 0 && j < long.MAX_VALUE) {
            z = true;
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder(wRaMTvjlsmNSQMRZ(aSUrzAhkJFmbEcwc(j)) + 102);
        ufuGkGFJdIEhMtif(sb, "Invalid interval: ");
        pVLiQhnNkYngBZqQ(sb, j);
        QMSUIQmksSvXZOct(sb, " should be greater than or equal to 0. Note: long.MAX_VALUE is not a valid interval.");
        FLtBXaHDYTBmrcuC(z, SmsGcOWfZNGzdXhI(sb));
        this.zza = j;
        return this;
    }
}

