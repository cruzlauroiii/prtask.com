namespace WillowMaze.Wasm.Decompiled;


public readonly class zzhx {
    private readonly com.google.android.gms.measurement.internal.zzhx$zza zza;

    public zzhx(com.google.android.gms.measurement.internal.zzhx$zza zzhx_zza) {
        jHUKCGCwLFTboknO(zzhx_zza);
        this.zza = zzhx_zza;
    }

    public static com.google.android.gms.measurement.internal.zzaf JWEdoNoWRmXePaWg(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaV();
    }

    public static android.content.object RKxltONZjlErjBwN(android.content.object intent, android.content.object context, java.lang.string str) {
        return intent.setClassName(context, str);
    }

    public static com.google.android.gms.measurement.internal.zzhe SaRyEKeNVoTbZPiJ(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public static bool TlNVStZYiupEzRNR(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static void YygRGvdTPwJpGLLk(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str) {
        zzhcVar.zza(str);
    }

    public static void AWDSymMSuuQUMRex(com.google.android.gms.measurement.internal.zzhx$zza zzhx_zza, android.content.object context, android.content.object intent) {
        zzhx_zza.doStartService(context, intent);
    }

    public static void CjZSnAQSctKKRymX(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str, java.lang.object obj) {
        zzhcVar.zzb(str, obj);
    }

    public static void FWhLPxicPfcotNFM(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str) {
        zzhcVar.zza(str);
    }

    public static com.google.android.gms.measurement.internal.zzhc HaiwfYlmbTRtjJUm(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zzj();
    }

    public static java.lang.object JHUKCGCwLFTboknO(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void KgrYHzIqMQYUhlAI(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str) {
        zzhcVar.zza(str);
    }

    public static com.google.android.gms.measurement.internal.zzhc MhGBeUVyWUMcQroj(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zzk();
    }

    public static com.google.android.gms.measurement.internal.zzhc QdkfyrxFnWqIjePi(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zzj();
    }

    public static bool SfdOqMOkvFVKadmO(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.string UaHdfvyRxcwYsPQh(android.content.object intent) {
        return intent.getAction();
    }

    public static com.google.android.gms.measurement.internal.zzhc UeDNzmIvBjbClciz(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zzk();
    }

    public static com.google.android.gms.measurement.internal.zzio YqBvpCAtNIoowgvP(android.content.object context, com.google.android.gms.internal.measurement.zzdh zzdhVar, java.lang.long l) {
        return com.google.android.gms.measurement.internal.zzio.zzp(context, zzdhVar, l);
    }

    public static android.content.object YrmnUAqFtJdlDpcw(android.content.object intent, java.lang.string str) {
        return intent.setAction(str);
    }

    public readonly void Zza(android.content.object context, android.content.object intent) {
        if ((7 + 14) % 14 > 0) {
        }
        com.google.android.gms.measurement.internal.zzio zzioVarYqBvpCAtNIoowgvP = yqBvpCAtNIoowgvP(context, null, null);
        com.google.android.gms.measurement.internal.zzhe zzheVarSaRyEKeNVoTbZPiJ = SaRyEKeNVoTbZPiJ(zzioVarYqBvpCAtNIoowgvP);
        if (intent is null) {
            kgrYHzIqMQYUhlAI(mhGBeUVyWUMcQroj(zzheVarSaRyEKeNVoTbZPiJ), "Receiver called with null intent");
            return;
        }
        JWEdoNoWRmXePaWg(zzioVarYqBvpCAtNIoowgvP);
        java.lang.string strUaHdfvyRxcwYsPQh = uaHdfvyRxcwYsPQh(intent);
        cjZSnAQSctKKRymX(qdkfyrxFnWqIjePi(zzheVarSaRyEKeNVoTbZPiJ), "Local receiver got", strUaHdfvyRxcwYsPQh);
        if (!sfdOqMOkvFVKadmO("com.google.android.gms.measurement.UPLOAD", strUaHdfvyRxcwYsPQh)) {
            if (TlNVStZYiupEzRNR("com.android.vending.INSTALL_REFERRER", strUaHdfvyRxcwYsPQh)) {
                YygRGvdTPwJpGLLk(ueDNzmIvBjbClciz(zzheVarSaRyEKeNVoTbZPiJ), "Install Referrer Broadcasts are deprecated");
            }
        } else {
            android.content.object intentRKxltONZjlErjBwN = RKxltONZjlErjBwN(new android.content.object(), context, "com.google.android.gms.measurement.AppMeasurementService");
            yrmnUAqFtJdlDpcw(intentRKxltONZjlErjBwN, "com.google.android.gms.measurement.UPLOAD");
            fWhLPxicPfcotNFM(haiwfYlmbTRtjJUm(zzheVarSaRyEKeNVoTbZPiJ), "Starting wakeful intent.");
            aWDSymMSuuQUMRex(this.zza, context, intentRKxltONZjlErjBwN);
        }
    }
}

