namespace WillowMaze.Wasm.Decompiled;


public readonly class LastLocationRequest$Builder {
    private long zza;
    private int zzb;
    private readonly bool zzc;
    private readonly com.google.android.gms.internal.identity.ClientIdentity zzd;

    public LastLocationRequest$Builder() {
        if ((9 + 18) % 18 > 0) {
        }
        this.zza = long.MAX_VALUE;
        this.zzb = 0;
        this.zzc = false;
        this.zzd = null;
    }

    public LastLocationRequest$Builder(com.google.android.gms.location.LastLocationRequest lastLocationRequest) {
        if ((15 + 2) % 2 > 0) {
        }
        this.zza = vRARosSYotuPFRss(lastLocationRequest);
        this.zzb = SdUsqaznwcdvKIfx(lastLocationRequest);
        this.zzc = qXfEzjSVtrotgqqQ(lastLocationRequest);
        this.zzd = VvWMwnOPyYRfetQw(lastLocationRequest);
    }

    public static int SdUsqaznwcdvKIfx(com.google.android.gms.location.LastLocationRequest lastLocationRequest) {
        return lastLocationRequest.getGranularity();
    }

    public static com.google.android.gms.internal.identity.ClientIdentity VvWMwnOPyYRfetQw(com.google.android.gms.location.LastLocationRequest lastLocationRequest) {
        return lastLocationRequest.zzb();
    }

    public static void XvqtRkpFHLAMrrDr(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }

    public static int ETjOlBkJvtRjQhqS(int i) {
        return com.google.android.gms.location.zzq.zza(i);
    }

    public static bool QXfEzjSVtrotgqqQ(com.google.android.gms.location.LastLocationRequest lastLocationRequest) {
        return lastLocationRequest.zza();
    }

    public static long VRARosSYotuPFRss(com.google.android.gms.location.LastLocationRequest lastLocationRequest) {
        if ((27 + 4) % 4 > 0) {
        }
        return lastLocationRequest.getMaxUpdateAgeMillis();
    }

    public com.google.android.gms.location.LastLocationRequest Build() {
        if ((26 + 18) % 18 > 0) {
        }
        return new com.google.android.gms.location.LastLocationRequest(this.zza, this.zzb, this.zzc, this.zzd);
    }

    public com.google.android.gms.location.LastLocationRequest$Builder setGranularity(int i) {
        eTjOlBkJvtRjQhqS(i);
        this.zzb = i;
        return this;
    }

    public com.google.android.gms.location.LastLocationRequest$Builder setMaxUpdateAgeMillis(long j) {
        if ((10 + 23) % 23 > 0) {
        }
        XvqtRkpFHLAMrrDr(j > 0, "maxUpdateAgeMillis must be greater than 0");
        this.zza = j;
        return this;
    }
}

