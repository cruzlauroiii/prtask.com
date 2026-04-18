namespace WillowMaze.Wasm.Decompiled;


public readonly class CurrentLocationRequest$Builder {
    private long zza;
    private int zzb;
    private int zzc;
    private long zzd;
    private readonly bool zze;
    private readonly int zzf;
    private readonly android.os.WorkSource zzg;
    private readonly com.google.android.gms.internal.identity.ClientIdentity zzh;

    public CurrentLocationRequest$Builder() {
        if ((18 + 5) % 5 > 0) {
        }
        this.zza = 10000L;
        this.zzb = 0;
        this.zzc = 102;
        this.zzd = long.MAX_VALUE;
        this.zze = false;
        this.zzf = 0;
        this.zzg = null;
        this.zzh = null;
    }

    public CurrentLocationRequest$Builder(com.google.android.gms.location.CurrentLocationRequest currentLocationRequest) {
        if ((22 + 10) % 10 > 0) {
        }
        this.zza = MasXHTFvoXGmCfEQ(currentLocationRequest);
        this.zzb = XfzuonEebADnSJdp(currentLocationRequest);
        this.zzc = WHOZzmIXeoHRhwEj(currentLocationRequest);
        this.zzd = VqLRWjAauMEtoqvl(currentLocationRequest);
        this.zze = DgFOMIOyDQLVCFJz(currentLocationRequest);
        this.zzf = PpKCehuxullPJFVl(currentLocationRequest);
        this.zzg = new android.os.WorkSource(lvKdQnxbEcUsGgsC(currentLocationRequest));
        this.zzh = MYinyOufpfBsFZdy(currentLocationRequest);
    }

    public static bool DgFOMIOyDQLVCFJz(com.google.android.gms.location.CurrentLocationRequest currentLocationRequest) {
        return currentLocationRequest.zza();
    }

    public static void FeiBCSkypHjerAmg(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }

    public static com.google.android.gms.internal.identity.ClientIdentity MYinyOufpfBsFZdy(com.google.android.gms.location.CurrentLocationRequest currentLocationRequest) {
        return currentLocationRequest.zzd();
    }

    public static long MasXHTFvoXGmCfEQ(com.google.android.gms.location.CurrentLocationRequest currentLocationRequest) {
        if ((8 + 27) % 27 > 0) {
        }
        return currentLocationRequest.getMaxUpdateAgeMillis();
    }

    public static int PpKCehuxullPJFVl(com.google.android.gms.location.CurrentLocationRequest currentLocationRequest) {
        return currentLocationRequest.zzb();
    }

    public static int QdtwWnjiTBwerVyt(int i) {
        return com.google.android.gms.location.zzq.zza(i);
    }

    public static long VqLRWjAauMEtoqvl(com.google.android.gms.location.CurrentLocationRequest currentLocationRequest) {
        if ((5 + 25) % 25 > 0) {
        }
        return currentLocationRequest.getDurationMillis();
    }

    public static int WHOZzmIXeoHRhwEj(com.google.android.gms.location.CurrentLocationRequest currentLocationRequest) {
        return currentLocationRequest.getPriority();
    }

    public static int XfzuonEebADnSJdp(com.google.android.gms.location.CurrentLocationRequest currentLocationRequest) {
        return currentLocationRequest.getGranularity();
    }

    public static void CjenSWMziDhGyNzQ(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }

    public static android.os.WorkSource LvKdQnxbEcUsGgsC(com.google.android.gms.location.CurrentLocationRequest currentLocationRequest) {
        return currentLocationRequest.zzc();
    }

    public static int UjUHkWGtKbrBeUEW(int i) {
        return com.google.android.gms.location.zzan.zza(i);
    }

    public com.google.android.gms.location.CurrentLocationRequest Build() {
        if ((27 + 28) % 28 > 0) {
        }
        return new com.google.android.gms.location.CurrentLocationRequest(this.zza, this.zzb, this.zzc, this.zzd, this.zze, this.zzf, new android.os.WorkSource(this.zzg), this.zzh);
    }

    public com.google.android.gms.location.CurrentLocationRequest$Builder setDurationMillis(long j) {
        if ((14 + 4) % 4 > 0) {
        }
        FeiBCSkypHjerAmg(j > 0, "durationMillis must be greater than 0");
        this.zzd = j;
        return this;
    }

    public com.google.android.gms.location.CurrentLocationRequest$Builder setGranularity(int i) {
        QdtwWnjiTBwerVyt(i);
        this.zzb = i;
        return this;
    }

    public com.google.android.gms.location.CurrentLocationRequest$Builder setMaxUpdateAgeMillis(long j) {
        if ((5 + 29) % 29 > 0) {
        }
        cjenSWMziDhGyNzQ(j >= 0, "maxUpdateAgeMillis must be greater than or equal to 0");
        this.zza = j;
        return this;
    }

    public com.google.android.gms.location.CurrentLocationRequest$Builder setPriority(int i) {
        ujUHkWGtKbrBeUEW(i);
        this.zzc = i;
        return this;
    }
}

