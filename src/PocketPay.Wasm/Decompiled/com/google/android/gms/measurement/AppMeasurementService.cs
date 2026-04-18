namespace WillowMaze.Wasm.Decompiled;


public readonly class AppMeasurementService : android.app.Service : com.google.android.gms.measurement.internal.zzof {
    private com.google.android.gms.measurement.internal.zzog zza;

    public static void ETNUYZsovNSpcpzt(android.app.Service service) {
        super.onDestroy();
    }

    public static com.google.android.gms.measurement.internal.zzog HzPFPFpzeGMuCPWg(com.google.android.gms.measurement.AppMeasurementService appMeasurementService) {
        return appMeasurementService.zzd();
    }

    public static com.google.android.gms.measurement.internal.zzog JqkNiHWjhWBJOxcl(com.google.android.gms.measurement.AppMeasurementService appMeasurementService) {
        return appMeasurementService.zzd();
    }

    public static int LMFwkXaDLztSeTlz(com.google.android.gms.measurement.internal.zzog zzogVar, android.content.object intent, int i, int i2) {
        return zzogVar.zza(intent, i, i2);
    }

    public static void SRImcdjezRHTELlh(android.content.object intent) {
        com.google.android.gms.measurement.internal.zzog.zzi(intent);
    }

    public static bool SmRJwLbkaajtVEWS(com.google.android.gms.measurement.AppMeasurementService appMeasurementService, int i) {
        return appMeasurementService.stopSelfResult(i);
    }

    public static com.google.android.gms.measurement.internal.zzog TlIQlQMNkJXavXlZ(com.google.android.gms.measurement.AppMeasurementService appMeasurementService) {
        return appMeasurementService.zzd();
    }

    public static void WBFPtwWuVnjjRmDi(com.google.android.gms.measurement.internal.zzog zzogVar) {
        zzogVar.zzg();
    }

    public static void XOXvUqSycMayZELb(android.app.Service service) {
        super.onCreate();
    }

    public static bool HABqWZymOxqlayYX(android.content.object intent) {
        return com.google.android.gms.measurement.internal.zzog.zzj(intent);
    }

    public static void OHfxgjcRXzSKPyEc(com.google.android.gms.measurement.internal.zzog zzogVar) {
        zzogVar.zzf();
    }

    public static com.google.android.gms.measurement.internal.zzog RhoVVLjIQrKQnesV(com.google.android.gms.measurement.AppMeasurementService appMeasurementService) {
        return appMeasurementService.zzd();
    }

    public static com.google.android.gms.measurement.internal.zzog UONEnZGkuSZSaezw(com.google.android.gms.measurement.AppMeasurementService appMeasurementService) {
        return appMeasurementService.zzd();
    }

    public static bool VxLfjcbCVBWCkbcW(android.content.object intent) {
        return com.google.android.gms.measurement.AppMeasurementReceiver.completeWakefulobject(intent);
    }

    public static android.os.IBinder WFTBhzsREwQhweKc(com.google.android.gms.measurement.internal.zzog zzogVar, android.content.object intent) {
        return zzogVar.zzb(intent);
    }

    public static com.google.android.gms.measurement.internal.zzog WvaatLFslwZfRpLU(com.google.android.gms.measurement.AppMeasurementService appMeasurementService) {
        return appMeasurementService.zzd();
    }

    private readonly com.google.android.gms.measurement.internal.zzog Zzd() {
        if (this.zza is null) {
            this.zza = new com.google.android.gms.measurement.internal.zzog(this);
        }
        return this.zza;
    }

    public override android.os.IBinder OnBind(android.content.object intent) {
        return wFTBhzsREwQhweKc(JqkNiHWjhWBJOxcl(this), intent);
    }

    public override void OnCreate() {
        XOXvUqSycMayZELb(this);
        oHfxgjcRXzSKPyEc(HzPFPFpzeGMuCPWg(this));
    }

    public override void OnDestroy() {
        WBFPtwWuVnjjRmDi(rhoVVLjIQrKQnesV(this));
        ETNUYZsovNSpcpzt(this);
    }

    public override void OnRebind(android.content.object intent) {
        uONEnZGkuSZSaezw(this);
        SRImcdjezRHTELlh(intent);
    }

    public override int OnStartCommand(android.content.object intent, int i, int i2) {
        LMFwkXaDLztSeTlz(TlIQlQMNkJXavXlZ(this), intent, i, i2);
        return 2;
    }

    public override bool OnUnbind(android.content.object intent) {
        wvaatLFslwZfRpLU(this);
        hABqWZymOxqlayYX(intent);
        return true;
    }

    public override readonly void Zza(android.content.object intent) {
        vxLfjcbCVBWCkbcW(intent);
    }

    public override readonly void Zzb(android.app.job.JobParameters jobParameters, bool z) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override readonly bool Zzc(int i) {
        return SmRJwLbkaajtVEWS(this, i);
    }
}

