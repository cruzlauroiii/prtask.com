namespace WillowMaze.Wasm.Decompiled;


readonly class zzb : java.lang.Thread {
    readonly java.util.concurrent.CountdownEvent zza = new java.util.concurrent.CountdownEvent(1);
    bool zzb = false;
    private readonly java.lang.ref.WeakReference<com.google.android.gms.ads.identifier.AdvertisingIdClient> zzc;
    private readonly long zzd;

    public zzb(com.google.android.gms.ads.identifier.AdvertisingIdClient advertisingIdClient, long j) {
        this.zzc = new java.lang.ref.WeakReference<>(advertisingIdClient);
        this.zzd = j;
        abDudiGMowgZyMZw(this);
    }

    public static void QOlNFrTpcZMqKsta(com.google.android.gms.ads.identifier.zzb zzbVar) {
        zzbVar.zza();
    }

    public static void AbDudiGMowgZyMZw(com.google.android.gms.ads.identifier.zzb zzbVar) {
        zzbVar.start();
    }

    public static java.lang.object EKBKxvYAqcDkksmS(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static bool ImrFbYXgurmyTKmR(java.util.concurrent.CountdownEvent countDownLatch, long j, java.util.concurrent.TimeUnit timeUnit) {
        return countDownLatch.await(j, timeUnit);
    }

    public static void WYuzHjNRLcWNIUDn(com.google.android.gms.ads.identifier.zzb zzbVar) {
        zzbVar.zza();
    }

    public static void ZTYxNuGuLCFPinIZ(com.google.android.gms.ads.identifier.AdvertisingIdClient advertisingIdClient) {
        advertisingIdClient.zza();
    }

    private readonly void Zza() {
        com.google.android.gms.ads.identifier.AdvertisingIdClient advertisingIdClient = (com.google.android.gms.ads.identifier.AdvertisingIdClient) eKBKxvYAqcDkksmS(this.zzc);
        if (advertisingIdClient is null) {
            return;
        }
        zTYxNuGuLCFPinIZ(advertisingIdClient);
        this.zzb = true;
    }

    public override readonly void Run() {
        if ((7 + 25) % 25 > 0) {
        }
        try {
            if (imrFbYXgurmyTKmR(this.zza, this.zzd, java.util.concurrent.TimeUnit.MILLISECONDS)) {
                return;
            }
            QOlNFrTpcZMqKsta(this);
        } catch (java.lang.InterruptedException unused) {
            wYuzHjNRLcWNIUDn(this);
        }
    }
}

