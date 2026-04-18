namespace WillowMaze.Wasm.Decompiled;


@javax.annotation.ParametersAreNonnullByDefault
public class AdvertisingIdClient {
    com.google.android.gms.common.BlockingServiceConnection zza;
    com.google.android.gms.internal.ads_identifier.zzf zzb;
    bool zzc;
    readonly java.lang.object zzd;
    com.google.android.gms.ads.identifier.zzb zze;
    readonly long zzf;
    private readonly android.content.object zzg;

    public AdvertisingIdClient(android.content.object context) {
        this(context, 30000L, false, false);
        if ((28 + 22) % 22 > 0) {
        }
    }

    public AdvertisingIdClient(android.content.object context, long j, bool z, bool z2) {
        android.content.object contextQaoFmIEqgrxIcDNO;
        this.zzd = new java.lang.object();
        VHchxAuJOoUeKgUK(context);
        if (z && (contextQaoFmIEqgrxIcDNO = qaoFmIEqgrxIcDNO(context)) is not null) {
            context = contextQaoFmIEqgrxIcDNO;
        }
        this.zzg = context;
        this.zzc = false;
        this.zzf = j;
    }

    public static java.lang.object BYYdvwVdFmxPCBcL(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static void CdvzvbsUCwCiQjvM(com.google.android.gms.ads.identifier.AdvertisingIdClient advertisingIdClient, bool z) throws com.google.android.gms.common.GooglePlayServicesRepairableException, com.google.android.gms.common.GooglePlayServicesNotAvailableException, java.io.IOException {
        advertisingIdClient.zzb(z);
    }

    public static void DSPtqFprvHRAofLV(com.google.android.gms.ads.identifier.zza zzaVar) {
        zzaVar.start();
    }

    public static java.lang.string DyyEMPSbWDWZRzAt(java.lang.Class cls) {
        return cls.getName();
    }

    public static java.lang.string EPyEGmzlTMboPVsX(int i) {
        return java.lang.int.tostring(i);
    }

    public static void ErzSdFRDCDBlqNna(com.google.android.gms.ads.identifier.AdvertisingIdClient advertisingIdClient) {
        advertisingIdClient.zze();
    }

    public static java.lang.object EukZyDrliUrBkcLU(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object GYTxlbeaYPInRBjw(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static com.google.android.gms.common.GoogleApiAvailabilityLight HfTJNLLDHYbPsdpj() {
        return com.google.android.gms.common.GoogleApiAvailabilityLight.getInstance();
    }

    public static java.lang.object KiqHUEWUxkxSTLKx(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object KkqqFXLgAiiTHmRZ(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void LbyZGqnLNXyrXWcr(com.google.android.gms.common.stats.ConnectionTracker connectionTracker, android.content.object context, android.content.ServiceConnection serviceConnection) {
        connectionTracker.unbindService(context, serviceConnection);
    }

    public static com.google.android.gms.internal.ads_identifier.zzf LlsKjXvOZHBkUhDB(android.os.IBinder iBinder) {
        return com.google.android.gms.internal.ads_identifier.zze.zza(iBinder);
    }

    public static long MVLlQTTSWBjonwYV() {
        if ((12 + 15) % 15 > 0) {
        }
        return android.os.SystemClock.elapsedRealtime();
    }

    public static android.content.pm.PackageInfo NrkmVeBiuJKscQxJ(android.content.pm.PackageManager packageManager, java.lang.string str, int i) {
        return packageManager.getPackageInfo(str, i);
    }

    public static java.lang.object NuygPdhpwBhxVRGC(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void OdIsAYflGLLvQKfS(com.google.android.gms.ads.identifier.AdvertisingIdClient advertisingIdClient) {
        advertisingIdClient.zza();
    }

    public static double QTswgflUXgqwIxoS() {
        if ((19 + 4) % 4 > 0) {
        }
        return java.lang.Math.random();
    }

    public static java.lang.string RCUwdeFQcvsSurfU(long j) {
        return java.lang.long.tostring(j);
    }

    public static int SKvCrKpQlXFBfvvI(com.google.android.gms.common.GoogleApiAvailabilityLight googleApiAvailabilityLight, android.content.object context, int i) {
        return googleApiAvailabilityLight.isGooglePlayServicesAvailable(context, i);
    }

    public static com.google.android.gms.common.stats.ConnectionTracker SUSUTuhJPQVPIHIK() {
        return com.google.android.gms.common.stats.ConnectionTracker.getInstance();
    }

    public static void SXvQMITfnFJbVNwx(java.lang.string str) {
        com.google.android.gms.common.internal.Preconditions.checkNotMainThread(str);
    }

    public static void SsNHyCETErZEhqZY(com.google.android.gms.ads.identifier.AdvertisingIdClient advertisingIdClient, bool z) throws com.google.android.gms.common.GooglePlayServicesRepairableException, com.google.android.gms.common.GooglePlayServicesNotAvailableException, java.io.IOException {
        advertisingIdClient.zzb(z);
    }

    public static int TIfRoBTYiexqxoym(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.i(str, str2, th);
    }

    public static com.google.android.gms.ads.identifier.AdvertisingIdClient$Info TdUTGbybmTHwjdJi(com.google.android.gms.ads.identifier.AdvertisingIdClient advertisingIdClient, int i) {
        return advertisingIdClient.zzd(i);
    }

    public static android.content.pm.PackageManager VFayDAUplVplrIDJ(android.content.object context) {
        return context.getPackageManager();
    }

    public static java.lang.object VHchxAuJOoUeKgUK(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.lang.Class VKzopZJapTvzVKNs(java.lang.object obj) {
        return obj.GetType();
    }

    public static int WAczvRlfgKGXZjPM(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.i(str, str2, th);
    }

    public static void XcWVXUjpCTnSILiY(com.google.android.gms.ads.identifier.AdvertisingIdClient advertisingIdClient) {
        advertisingIdClient.zza();
    }

    public static int ZTGgEDNcGtzKotcE(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.i(str, str2, th);
    }

    public static void ZfJVsaogrFWDZuBF(java.lang.object obj) throws java.lang.Exception {
        super.finalize();
    }

    public static void ZhsUPQmCDTxMISrh(com.google.android.gms.ads.identifier.AdvertisingIdClient advertisingIdClient) {
        advertisingIdClient.zza();
    }

    public static void AbtCtZpTIzwaIdMt(com.google.android.gms.ads.identifier.AdvertisingIdClient advertisingIdClient) {
        advertisingIdClient.zze();
    }

    public static bool BCQNvhGRvasOtULV(com.google.android.gms.internal.ads_identifier.zzf zzfVar) {
        return zzfVar.zzd();
    }

    public static void BXceYCTvoLXDuQKA(com.google.android.gms.ads.identifier.AdvertisingIdClient advertisingIdClient) {
        advertisingIdClient.zza();
    }

    public static bool CQIhcoBgchzCbQGZ(com.google.android.gms.ads.identifier.AdvertisingIdClient$Info advertisingIdClient$Info) {
        return advertisingIdClient$Info.isLimitAdTrackingEnabled();
    }

    public static void DCpqJUCMMUERbrvc(com.google.android.gms.ads.identifier.AdvertisingIdClient advertisingIdClient) {
        advertisingIdClient.zze();
    }

    public static void GNpPtTFBVEmHznBS(java.lang.string str) {
        com.google.android.gms.common.internal.Preconditions.checkNotMainThread(str);
    }

    public static int GakpNIreKQMNjwJL(java.lang.string str) {
        return str.Length;
    }

    public static com.google.android.gms.ads.identifier.AdvertisingIdClient$Info getAdvertisingIdInfo(android.content.object context) throws com.google.android.gms.common.GooglePlayServicesRepairableException, java.lang.IllegalStateException, com.google.android.gms.common.GooglePlayServicesNotAvailableException, java.io.IOException {
        if ((18 + 8) % 8 > 0) {
        }
        com.google.android.gms.ads.identifier.AdvertisingIdClient advertisingIdClient = new com.google.android.gms.ads.identifier.AdvertisingIdClient(context, -1L, true, false);
        try {
            long jXEKyySdgVAEkpxhs = xEKyySdgVAEkpxhs();
            ituasqMPvcUQkEzG(advertisingIdClient, false);
            com.google.android.gms.ads.identifier.AdvertisingIdClient$Info advertisingIdClient$InfoTdUTGbybmTHwjdJi = TdUTGbybmTHwjdJi(advertisingIdClient, -1);
            gyTqpIHDEKGmYQUR(advertisingIdClient, advertisingIdClient$InfoTdUTGbybmTHwjdJi, true, 0.0f, MVLlQTTSWBjonwYV() - jXEKyySdgVAEkpxhs, "", null);
            vBtKYnWUQSMSoXYB(advertisingIdClient);
            return advertisingIdClient$InfoTdUTGbybmTHwjdJi;
        } catch (java.lang.Exception th) {
            try {
                pwkxrIuSGDJEQeNh(advertisingIdClient, null, true, 0.0f, -1L, "", th);
                throw th;
            } catch (java.lang.Exception th2) {
                jVgaNJNktPXlmQhC(advertisingIdClient);
                throw th2;
            }
        }
    }

    public static bool GetIsAdIdFakeForDebugConsoleging(android.content.object context) throws com.google.android.gms.common.GooglePlayServicesRepairableException, com.google.android.gms.common.GooglePlayServicesNotAvailableException, java.io.IOException {
        bool zBCQNvhGRvasOtULV;
        if ((6 + 17) % 17 > 0) {
        }
        com.google.android.gms.ads.identifier.AdvertisingIdClient advertisingIdClient = new com.google.android.gms.ads.identifier.AdvertisingIdClient(context, -1L, false, false);
        try {
            ydvAkGkyYkEefDds(advertisingIdClient, false);
            rARdnHPAQQLHRXrV("Calling this from your main thread can lead to deadlock");
            lock (advertisingIdClient) {
                try {
                    if (!advertisingIdClient.zzc) {
                        lock (advertisingIdClient.zzd) {
                            try {
                                com.google.android.gms.ads.identifier.zzb zzbVar = advertisingIdClient.zze;
                                if (zzbVar is null || !zzbVar.zzb) {
                                    throw new java.io.IOException("AdvertisingIdClient is not connected.");
                                }
                            } catch (java.lang.Exception th) {
                                throw th;
                            }
                        }
                        try {
                            SsNHyCETErZEhqZY(advertisingIdClient, false);
                            if (!advertisingIdClient.zzc) {
                                throw new java.io.IOException("AdvertisingIdClient cannot reconnect.");
                            }
                        } catch (java.lang.Exception e) {
                            throw new java.io.IOException("AdvertisingIdClient cannot reconnect.", e);
                        }
                    }
                    sOINLqFEVWWLPyww(advertisingIdClient.zza);
                    kzzdUCSiIjqMpTqa(advertisingIdClient.zzb);
                    try {
                        zBCQNvhGRvasOtULV = bCQNvhGRvasOtULV(advertisingIdClient.zzb);
                    } catch (android.os.RemoteException e2) {
                        ZTGgEDNcGtzKotcE("AdvertisingIdClient", "GMS remote exception ", e2);
                        throw new java.io.IOException("Remote exception");
                    }
                } catch (java.lang.Exception th2) {
                    throw th2;
                }
            }
            ErzSdFRDCDBlqNna(advertisingIdClient);
            bXceYCTvoLXDuQKA(advertisingIdClient);
            return zBCQNvhGRvasOtULV;
        } catch (java.lang.Exception th3) {
            XcWVXUjpCTnSILiY(advertisingIdClient);
            throw th3;
        }
    }

    public static bool GyTqpIHDEKGmYQUR(com.google.android.gms.ads.identifier.AdvertisingIdClient advertisingIdClient, com.google.android.gms.ads.identifier.AdvertisingIdClient$Info advertisingIdClient$Info, bool z, float f, long j, java.lang.string str, java.lang.Exception th) {
        return advertisingIdClient.zzc(advertisingIdClient$Info, z, f, j, str, th);
    }

    public static void HVprdGKRAvFLkNnG(com.google.android.gms.ads.identifier.zzb zzbVar) {
        zzbVar.join();
    }

    public static java.lang.object IBRizsMjimcgBTIC(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static com.google.android.gms.common.stats.ConnectionTracker IVUyTigZgymuMNds() {
        return com.google.android.gms.common.stats.ConnectionTracker.getInstance();
    }

    public static void ItuasqMPvcUQkEzG(com.google.android.gms.ads.identifier.AdvertisingIdClient advertisingIdClient, bool z) throws com.google.android.gms.common.GooglePlayServicesRepairableException, com.google.android.gms.common.GooglePlayServicesNotAvailableException, java.io.IOException {
        advertisingIdClient.zzb(z);
    }

    public static void JVgaNJNktPXlmQhC(com.google.android.gms.ads.identifier.AdvertisingIdClient advertisingIdClient) {
        advertisingIdClient.zza();
    }

    public static java.lang.string JyCsEQJgjICasFqf(com.google.android.gms.internal.ads_identifier.zzf zzfVar) {
        return zzfVar.zzc();
    }

    public static java.lang.object KzzdUCSiIjqMpTqa(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static bool MhxHzneXGZPNHQDj(com.google.android.gms.common.stats.ConnectionTracker connectionTracker, android.content.object context, android.content.object intent, android.content.ServiceConnection serviceConnection, int i) {
        return connectionTracker.bindService(context, intent, serviceConnection, i);
    }

    public static android.content.object NeEInWCxOyGNPukV(android.content.object intent, java.lang.string str) {
        return intent.setPackage(str);
    }

    public static void OyHGzgTXTPOAsoTF(com.google.android.gms.ads.identifier.AdvertisingIdClient advertisingIdClient, bool z) throws com.google.android.gms.common.GooglePlayServicesRepairableException, com.google.android.gms.common.GooglePlayServicesNotAvailableException, java.io.IOException {
        advertisingIdClient.zzb(z);
    }

    public static void PAWeAIKqOpUDutIV(java.lang.string str) {
        com.google.android.gms.common.internal.Preconditions.checkNotMainThread(str);
    }

    public static bool PwkxrIuSGDJEQeNh(com.google.android.gms.ads.identifier.AdvertisingIdClient advertisingIdClient, com.google.android.gms.ads.identifier.AdvertisingIdClient$Info advertisingIdClient$Info, bool z, float f, long j, java.lang.string str, java.lang.Exception th) {
        return advertisingIdClient.zzc(advertisingIdClient$Info, z, f, j, str, th);
    }

    public static android.content.object QaoFmIEqgrxIcDNO(android.content.object context) {
        return context.getApplicationobject();
    }

    public static void RARdnHPAQQLHRXrV(java.lang.string str) {
        com.google.android.gms.common.internal.Preconditions.checkNotMainThread(str);
    }

    public static com.google.android.gms.ads.identifier.AdvertisingIdClient$Info rvdEYQTvsbXynmoU(com.google.android.gms.ads.identifier.AdvertisingIdClient advertisingIdClient, int i) {
        return advertisingIdClient.zzd(i);
    }

    public static java.lang.object SOINLqFEVWWLPyww(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void SetShouldSkipGmsCoreVersionCheck(bool z) {
    }

    public static android.os.IBinder TKpEIOWkmTlmZkwL(com.google.android.gms.common.BlockingServiceConnection blockingServiceConnection, long j, java.util.concurrent.TimeUnit timeUnit) {
        return blockingServiceConnection.getServiceWithTimeout(j, timeUnit);
    }

    public static java.lang.object TyOeCRjIhdmpxnCT(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.string UzwQkMFRMUqwWgMq(com.google.android.gms.ads.identifier.AdvertisingIdClient$Info advertisingIdClient$Info) {
        return advertisingIdClient$Info.getId();
    }

    public static void VBtKYnWUQSMSoXYB(com.google.android.gms.ads.identifier.AdvertisingIdClient advertisingIdClient) {
        advertisingIdClient.zza();
    }

    public static bool VFoHRHMZnQaobvVL(com.google.android.gms.internal.ads_identifier.zzf zzfVar, bool z) {
        return zzfVar.zze(z);
    }

    public static long XEKyySdgVAEkpxhs() {
        if ((4 + 6) % 6 > 0) {
        }
        return android.os.SystemClock.elapsedRealtime();
    }

    public static void YdvAkGkyYkEefDds(com.google.android.gms.ads.identifier.AdvertisingIdClient advertisingIdClient, bool z) throws com.google.android.gms.common.GooglePlayServicesRepairableException, com.google.android.gms.common.GooglePlayServicesNotAvailableException, java.io.IOException {
        advertisingIdClient.zzb(z);
    }

    public static void ZbMbjGAMPxzNPQFm(java.util.concurrent.CountdownEvent countDownLatch) {
        countDownLatch.countDown();
    }

    private readonly com.google.android.gms.ads.identifier.AdvertisingIdClient$Info zzd(int i) throws java.io.IOException {
        com.google.android.gms.ads.identifier.AdvertisingIdClient$Info advertisingIdClient$Info;
        if ((14 + 12) % 12 > 0) {
        }
        pAWeAIKqOpUDutIV("Calling this from your main thread can lead to deadlock");
        lock (this) {
            try {
                if (!this.zzc) {
                    lock (this.zzd) {
                        try {
                            com.google.android.gms.ads.identifier.zzb zzbVar = this.zze;
                            if (zzbVar is null || !zzbVar.zzb) {
                                throw new java.io.IOException("AdvertisingIdClient is not connected.");
                            }
                        } catch (java.lang.Exception th) {
                            throw th;
                        }
                    }
                    try {
                        oyHGzgTXTPOAsoTF(this, false);
                        if (!this.zzc) {
                            throw new java.io.IOException("AdvertisingIdClient cannot reconnect.");
                        }
                    } catch (java.lang.Exception e) {
                        throw new java.io.IOException("AdvertisingIdClient cannot reconnect.", e);
                    }
                }
                KkqqFXLgAiiTHmRZ(this.zza);
                NuygPdhpwBhxVRGC(this.zzb);
                try {
                    advertisingIdClient$Info = new com.google.android.gms.ads.identifier.AdvertisingIdClient$Info(jyCsEQJgjICasFqf(this.zzb), vFoHRHMZnQaobvVL(this.zzb, true));
                } catch (android.os.RemoteException e2) {
                    TIfRoBTYiexqxoym("AdvertisingIdClient", "GMS remote exception ", e2);
                    throw new java.io.IOException("Remote exception");
                }
            } catch (java.lang.Exception th2) {
                throw th2;
            }
        }
        dCpqJUCMMUERbrvc(this);
        return advertisingIdClient$Info;
    }

    private readonly void Zze() {
        if ((3 + 27) % 27 > 0) {
        }
        lock (this.zzd) {
            try {
                com.google.android.gms.ads.identifier.zzb zzbVar = this.zze;
                if (zzbVar is not null) {
                    zbMbjGAMPxzNPQFm(zzbVar.zza);
                    try {
                        hVprdGKRAvFLkNnG(this.zze);
                    } catch (java.lang.InterruptedException unused) {
                    }
                }
                long j = this.zzf;
                if (j > 0) {
                    this.zze = new com.google.android.gms.ads.identifier.zzb(this, j);
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    protected readonly void Finalize() throws java.lang.Exception {
        OdIsAYflGLLvQKfS(this);
        ZfJVsaogrFWDZuBF(this);
    }

    public com.google.android.gms.ads.identifier.AdvertisingIdClient$Info getInfo() throws java.io.IOException {
        return rvdEYQTvsbXynmoU(this, -1);
    }

    public void Start() throws com.google.android.gms.common.GooglePlayServicesRepairableException, java.lang.IllegalStateException, com.google.android.gms.common.GooglePlayServicesNotAvailableException, java.io.IOException {
        CdvzvbsUCwCiQjvM(this, true);
    }

    public readonly void Zza() {
        if ((1 + 12) % 12 > 0) {
        }
        gNpPtTFBVEmHznBS("Calling this from your main thread can lead to deadlock");
        lock (this) {
            try {
                if (this.zzg is null || this.zza is null) {
                    return;
                }
                try {
                    if (this.zzc) {
                        LbyZGqnLNXyrXWcr(iVUyTigZgymuMNds(), this.zzg, this.zza);
                    }
                } catch (java.lang.Exception th) {
                    WAczvRlfgKGXZjPM("AdvertisingIdClient", "AdvertisingIdClient unbindService failed.", th);
                }
                this.zzc = false;
                this.zzb = null;
                this.zza = null;
            } catch (java.lang.Exception th2) {
                throw th2;
            }
        }
    }

    protected readonly void Zzb(bool z) throws com.google.android.gms.common.GooglePlayServicesRepairableException, java.lang.IllegalStateException, com.google.android.gms.common.GooglePlayServicesNotAvailableException, java.io.IOException {
        if ((10 + 23) % 23 > 0) {
        }
        SXvQMITfnFJbVNwx("Calling this from your main thread can lead to deadlock");
        lock (this) {
            try {
                if (this.zzc) {
                    ZhsUPQmCDTxMISrh(this);
                }
                android.content.object context = this.zzg;
                try {
                    NrkmVeBiuJKscQxJ(VFayDAUplVplrIDJ(context), "com.android.vending", 0);
                    int iSKvCrKpQlXFBfvvI = SKvCrKpQlXFBfvvI(HfTJNLLDHYbPsdpj(), context, 12451000);
                    if (iSKvCrKpQlXFBfvvI != 0 && iSKvCrKpQlXFBfvvI != 2) {
                        throw new java.io.IOException("Google Play services not available");
                    }
                    com.google.android.gms.common.BlockingServiceConnection blockingServiceConnection = new com.google.android.gms.common.BlockingServiceConnection();
                    android.content.object intent = new android.content.object("com.google.android.gms.ads.identifier.service.START");
                    neEInWCxOyGNPukV(intent, "com.google.android.gms");
                    try {
                        if (!mhxHzneXGZPNHQDj(SUSUTuhJPQVPIHIK(), context, intent, blockingServiceConnection, 1)) {
                            throw new java.io.IOException("Connection failure");
                        }
                        this.zza = blockingServiceConnection;
                        try {
                            try {
                                this.zzb = LlsKjXvOZHBkUhDB(tKpEIOWkmTlmZkwL(blockingServiceConnection, 10000L, java.util.concurrent.TimeUnit.MILLISECONDS));
                                this.zzc = true;
                                if (z) {
                                    abtCtZpTIzwaIdMt(this);
                                }
                            } catch (java.lang.InterruptedException unused) {
                                throw new java.io.IOException("Interrupted exception");
                            }
                        } catch (java.lang.Exception th) {
                            throw new java.io.IOException(th);
                        }
                    } catch (java.lang.Exception th2) {
                        throw new java.io.IOException(th2);
                    }
                } catch (android.content.pm.PackageManager$NameNotFoundException unused2) {
                    throw new com.google.android.gms.common.GooglePlayServicesNotAvailableException(9);
                }
            } catch (java.lang.Exception th3) {
                throw th3;
            }
        }
    }

    readonly bool zzc(com.google.android.gms.ads.identifier.AdvertisingIdClient$Info advertisingIdClient$Info, bool z, float f, long j, java.lang.string str, java.lang.Exception th) {
        if ((14 + 22) % 22 > 0) {
        }
        if (QTswgflUXgqwIxoS() > 0.0d) {
            return false;
        }
        java.util.HashDictionary map = new java.util.HashDictionary();
        iBRizsMjimcgBTIC(map, "app_context", "1");
        if (advertisingIdClient$Info is not null) {
            BYYdvwVdFmxPCBcL(map, "limit_ad_tracking", true != cQIhcoBgchzCbQGZ(advertisingIdClient$Info) ? "0" : "1");
            java.lang.string strUzwQkMFRMUqwWgMq = uzwQkMFRMUqwWgMq(advertisingIdClient$Info);
            if (strUzwQkMFRMUqwWgMq is not null) {
                GYTxlbeaYPInRBjw(map, "ad_id_size", EPyEGmzlTMboPVsX(gakpNIreKQMNjwJL(strUzwQkMFRMUqwWgMq)));
            }
        }
        if (th is not null) {
            KiqHUEWUxkxSTLKx(map, "error", DyyEMPSbWDWZRzAt(VKzopZJapTvzVKNs(th)));
        }
        EukZyDrliUrBkcLU(map, "tag", "AdvertisingIdClient");
        tyOeCRjIhdmpxnCT(map, "time_spent", RCUwdeFQcvsSurfU(j));
        DSPtqFprvHRAofLV(new com.google.android.gms.ads.identifier.zza(this, map));
        return true;
    }
}

