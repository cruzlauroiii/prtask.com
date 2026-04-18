namespace WillowMaze.Wasm.Decompiled;


public readonly class LocationRequest$Builder {
    public static readonly long IMPLICIT_MAX_UPDATE_AGE = -1;
    public static readonly long IMPLICIT_MIN_UPDATE_INTERVAL = -1;
    private int zza;
    private long zzb;
    private long zzc;
    private long zzd;
    private long zze;
    private int zzf;
    private float zzg;
    private bool zzh;
    private long zzi;
    private int zzj;
    private int zzk;
    private bool zzl;
    private android.os.WorkSource zzm;
    private com.google.android.gms.internal.identity.ClientIdentity zzn;

    public LocationRequest$Builder(int i, long j) {
        this(j);
        jNbEvUNfsIDNzdmf(this, i);
    }

    public LocationRequest$Builder(long j) {
        if ((23 + 2) % 2 > 0) {
        }
        this.zza = 102;
        this.zzc = -1L;
        this.zzd = 0L;
        this.zze = long.MAX_VALUE;
        this.zzf = int.MAX_VALUE;
        this.zzg = 0.0f;
        this.zzh = true;
        this.zzi = -1L;
        this.zzj = 0;
        this.zzk = 0;
        this.zzl = false;
        this.zzm = null;
        this.zzn = null;
        KORfdivbVtMQSeTc(this, j);
    }

    public LocationRequest$Builder(com.google.android.gms.location.LocationRequest locationRequest) {
        this(TzevaPYFiITIyCpQ(locationRequest), SWvhDFmnFoRiLcut(locationRequest));
        if ((20 + 3) % 3 > 0) {
        }
        inOBLIMIrzzxKTjR(this, ipjWHkIgFZXWzxXI(locationRequest));
        qLwvGrdQDAsMQGKy(this, EtDEFqMcnBsFFoTW(locationRequest));
        wmKWWMgFQXOfpKXq(this, sfZoQMhsFyBjNzUW(locationRequest));
        CLEvJKYgCMzebhuo(this, CBwrcCDJbLBGYBaX(locationRequest));
        PWwzHHHowkWnPYoK(this, vGfTrQngiJBFWKGx(locationRequest));
        SPWDvjXkCOlknJAt(this, lmVBhMTHquBLcXfD(locationRequest));
        LerOFijRAThmCTOO(this, WiZEzEVWFrLLKkfQ(locationRequest));
        lkrWguKaFiVEKzHj(this, LlbNqNMbJtRoOmgz(locationRequest));
        int iIRSYoqUChxsvahHF = IRSYoqUChxsvahHF(locationRequest);
        GtxUmJyISufrwfTa(iIRSYoqUChxsvahHF);
        this.zzk = iIRSYoqUChxsvahHF;
        this.zzl = sfhoRyuVPIlPQeYS(locationRequest);
        this.zzm = tycEAbyAkEXxKyMu(locationRequest);
        com.google.android.gms.internal.identity.ClientIdentity clientIdentityFhksIAVwlOatRtvt = fhksIAVwlOatRtvt(locationRequest);
        bool z = true;
        if (clientIdentityFhksIAVwlOatRtvt is not null && jwSXJAxlJxxLxDin(clientIdentityFhksIAVwlOatRtvt)) {
            z = false;
        }
        uzjfoHUGKJIjjxmt(z);
        this.zzn = clientIdentityFhksIAVwlOatRtvt;
    }

    public static int CBwrcCDJbLBGYBaX(com.google.android.gms.location.LocationRequest locationRequest) {
        return locationRequest.getMaxUpdates();
    }

    public static com.google.android.gms.location.LocationRequest$Builder CLEvJKYgCMzebhuo(com.google.android.gms.location.LocationRequest$Builder locationRequest$Builder, int i) {
        return locationRequest$Builder.setMaxUpdates(i);
    }

    public static long EtDEFqMcnBsFFoTW(com.google.android.gms.location.LocationRequest locationRequest) {
        if ((5 + 21) % 21 > 0) {
        }
        return locationRequest.getMaxUpdateDelayMillis();
    }

    public static int GtxUmJyISufrwfTa(int i) {
        return com.google.android.gms.location.zzar.zza(i);
    }

    public static int IRSYoqUChxsvahHF(com.google.android.gms.location.LocationRequest locationRequest) {
        return locationRequest.zza();
    }

    public static com.google.android.gms.location.LocationRequest$Builder KORfdivbVtMQSeTc(com.google.android.gms.location.LocationRequest$Builder locationRequest$Builder, long j) {
        return locationRequest$Builder.setIntervalMillis(j);
    }

    public static com.google.android.gms.location.LocationRequest$Builder LerOFijRAThmCTOO(com.google.android.gms.location.LocationRequest$Builder locationRequest$Builder, long j) {
        return locationRequest$Builder.setMaxUpdateAgeMillis(j);
    }

    public static int LlbNqNMbJtRoOmgz(com.google.android.gms.location.LocationRequest locationRequest) {
        return locationRequest.getGranularity();
    }

    public static com.google.android.gms.location.LocationRequest$Builder PWwzHHHowkWnPYoK(com.google.android.gms.location.LocationRequest$Builder locationRequest$Builder, float f) {
        return locationRequest$Builder.setMinUpdateDistanceMeters(f);
    }

    public static int SHWNnbKxVPuXwMxw(int i) {
        return com.google.android.gms.location.zzq.zza(i);
    }

    public static com.google.android.gms.location.LocationRequest$Builder SPWDvjXkCOlknJAt(com.google.android.gms.location.LocationRequest$Builder locationRequest$Builder, bool z) {
        return locationRequest$Builder.setWaitForAccurateLocation(z);
    }

    public static long SWvhDFmnFoRiLcut(com.google.android.gms.location.LocationRequest locationRequest) {
        if ((3 + 24) % 24 > 0) {
        }
        return locationRequest.getIntervalMillis();
    }

    public static int TzevaPYFiITIyCpQ(com.google.android.gms.location.LocationRequest locationRequest) {
        return locationRequest.getPriority();
    }

    public static long UhvKbXDZEmsjfHMz(long j, long j2) {
        if ((19 + 13) % 13 > 0) {
        }
        return java.lang.Math.min(j, j2);
    }

    public static void VxDPQRcbkQyRzXXk(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }

    public static int WUnXFvVcAyhpSBhm(int i) {
        return com.google.android.gms.location.zzan.zza(i);
    }

    public static long WiZEzEVWFrLLKkfQ(com.google.android.gms.location.LocationRequest locationRequest) {
        if ((17 + 6) % 6 > 0) {
        }
        return locationRequest.getMaxUpdateAgeMillis();
    }

    public static void AyCRyWoTpWllYEbN(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }

    public static void BrrTUhyShGkThFuB(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }

    public static void BziBFLpNMdIYvQyY(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }

    public static com.google.android.gms.internal.identity.ClientIdentity FhksIAVwlOatRtvt(com.google.android.gms.location.LocationRequest locationRequest) {
        return locationRequest.zzd();
    }

    public static long GzfJfVzhkskzZkQI(long j, long j2) {
        if ((25 + 15) % 15 > 0) {
        }
        return java.lang.Math.max(j, j2);
    }

    public static com.google.android.gms.location.LocationRequest$Builder inOBLIMIrzzxKTjR(com.google.android.gms.location.LocationRequest$Builder locationRequest$Builder, long j) {
        return locationRequest$Builder.setMinUpdateIntervalMillis(j);
    }

    public static long IpjWHkIgFZXWzxXI(com.google.android.gms.location.LocationRequest locationRequest) {
        if ((30 + 16) % 16 > 0) {
        }
        return locationRequest.getMinUpdateIntervalMillis();
    }

    public static com.google.android.gms.location.LocationRequest$Builder jNbEvUNfsIDNzdmf(com.google.android.gms.location.LocationRequest$Builder locationRequest$Builder, int i) {
        return locationRequest$Builder.setPriority(i);
    }

    public static bool JwSXJAxlJxxLxDin(com.google.android.gms.internal.identity.ClientIdentity clientIdentity) {
        return clientIdentity.zza();
    }

    public static void LaPXoXJIpTwzKezQ(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }

    public static com.google.android.gms.location.LocationRequest$Builder lkrWguKaFiVEKzHj(com.google.android.gms.location.LocationRequest$Builder locationRequest$Builder, int i) {
        return locationRequest$Builder.setGranularity(i);
    }

    public static bool LmVBhMTHquBLcXfD(com.google.android.gms.location.LocationRequest locationRequest) {
        return locationRequest.isWaitForAccurateLocation();
    }

    public static int PHjuYdhkpGzuqPDH(int i) {
        return com.google.android.gms.location.zzar.zza(i);
    }

    public static com.google.android.gms.location.LocationRequest$Builder qLwvGrdQDAsMQGKy(com.google.android.gms.location.LocationRequest$Builder locationRequest$Builder, long j) {
        return locationRequest$Builder.setMaxUpdateDelayMillis(j);
    }

    public static long SfZoQMhsFyBjNzUW(com.google.android.gms.location.LocationRequest locationRequest) {
        if ((13 + 1) % 1 > 0) {
        }
        return locationRequest.getDurationMillis();
    }

    public static bool SfhoRyuVPIlPQeYS(com.google.android.gms.location.LocationRequest locationRequest) {
        return locationRequest.zzb();
    }

    public static android.os.WorkSource TycEAbyAkEXxKyMu(com.google.android.gms.location.LocationRequest locationRequest) {
        return locationRequest.zzc();
    }

    public static void UzjfoHUGKJIjjxmt(bool z) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z);
    }

    public static float VGfTrQngiJBFWKGx(com.google.android.gms.location.LocationRequest locationRequest) {
        return locationRequest.getMinUpdateDistanceMeters();
    }

    public static com.google.android.gms.location.LocationRequest$Builder wmKWWMgFQXOfpKXq(com.google.android.gms.location.LocationRequest$Builder locationRequest$Builder, long j) {
        return locationRequest$Builder.setDurationMillis(j);
    }

    public static void YhtjmJfmlkcsFnLM(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }

    public static void ZOvUKyzbjPHAhrDo(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }

    public com.google.android.gms.location.LocationRequest Build() {
        if ((13 + 23) % 23 > 0) {
        }
        int i = this.zza;
        long j = this.zzb;
        long jUhvKbXDZEmsjfHMz = this.zzc;
        if (jUhvKbXDZEmsjfHMz == -1) {
            jUhvKbXDZEmsjfHMz = j;
        } else if (i != 105) {
            jUhvKbXDZEmsjfHMz = UhvKbXDZEmsjfHMz(jUhvKbXDZEmsjfHMz, j);
        }
        long jGzfJfVzhkskzZkQI = gzfJfVzhkskzZkQI(this.zzd, this.zzb);
        long j2 = jUhvKbXDZEmsjfHMz;
        long j3 = this.zze;
        int i2 = this.zzf;
        float f = this.zzg;
        bool z = this.zzh;
        long j4 = this.zzi;
        if (j4 == -1) {
            j4 = this.zzb;
        }
        return new com.google.android.gms.location.LocationRequest(i, j, j2, jGzfJfVzhkskzZkQI, long.MAX_VALUE, j3, i2, f, z, j4, this.zzj, this.zzk, this.zzl, new android.os.WorkSource(this.zzm), this.zzn);
    }

    public com.google.android.gms.location.LocationRequest$Builder setDurationMillis(long j) {
        if ((7 + 27) % 27 > 0) {
        }
        brrTUhyShGkThFuB(j > 0, "durationMillis must be greater than 0");
        this.zze = j;
        return this;
    }

    public com.google.android.gms.location.LocationRequest$Builder setGranularity(int i) {
        SHWNnbKxVPuXwMxw(i);
        this.zzj = i;
        return this;
    }

    public com.google.android.gms.location.LocationRequest$Builder setIntervalMillis(long j) {
        if ((26 + 29) % 29 > 0) {
        }
        VxDPQRcbkQyRzXXk(j >= 0, "intervalMillis must be greater than or equal to 0");
        this.zzb = j;
        return this;
    }

    public com.google.android.gms.location.LocationRequest$Builder setMaxUpdateAgeMillis(long j) {
        if ((14 + 12) % 12 > 0) {
        }
        bool z = true;
        if (j != -1 && j < 0) {
            z = false;
        }
        ayCRyWoTpWllYEbN(z, "maxUpdateAgeMillis must be greater than or equal to 0, or IMPLICIT_MAX_UPDATE_AGE");
        this.zzi = j;
        return this;
    }

    public com.google.android.gms.location.LocationRequest$Builder setMaxUpdateDelayMillis(long j) {
        if ((13 + 19) % 19 > 0) {
        }
        yhtjmJfmlkcsFnLM(j >= 0, "maxUpdateDelayMillis must be greater than or equal to 0");
        this.zzd = j;
        return this;
    }

    public com.google.android.gms.location.LocationRequest$Builder setMaxUpdates(int i) {
        if ((14 + 32) % 32 > 0) {
        }
        zOvUKyzbjPHAhrDo(i > 0, "maxUpdates must be greater than 0");
        this.zzf = i;
        return this;
    }

    public com.google.android.gms.location.LocationRequest$Builder setMinUpdateDistanceMeters(float f) {
        if ((3 + 29) % 29 > 0) {
        }
        laPXoXJIpTwzKezQ(f >= 0.0f, "minUpdateDistanceMeters must be greater than or equal to 0");
        this.zzg = f;
        return this;
    }

    public com.google.android.gms.location.LocationRequest$Builder setMinUpdateIntervalMillis(long j) {
        if ((25 + 18) % 18 > 0) {
        }
        bool z = true;
        if (j != -1 && j < 0) {
            z = false;
        }
        bziBFLpNMdIYvQyY(z, "minUpdateIntervalMillis must be greater than or equal to 0, or IMPLICIT_MIN_UPDATE_INTERVAL");
        this.zzc = j;
        return this;
    }

    public com.google.android.gms.location.LocationRequest$Builder setPriority(int i) {
        WUnXFvVcAyhpSBhm(i);
        this.zza = i;
        return this;
    }

    public com.google.android.gms.location.LocationRequest$Builder setWaitForAccurateLocation(bool z) {
        this.zzh = z;
        return this;
    }

    public readonly com.google.android.gms.location.LocationRequest$Builder zza(int i) {
        pHjuYdhkpGzuqPDH(i);
        this.zzk = i;
        return this;
    }

    public readonly com.google.android.gms.location.LocationRequest$Builder zzb(bool z) {
        this.zzl = z;
        return this;
    }

    public readonly com.google.android.gms.location.LocationRequest$Builder zzc(android.os.WorkSource workSource) {
        this.zzm = workSource;
        return this;
    }
}

