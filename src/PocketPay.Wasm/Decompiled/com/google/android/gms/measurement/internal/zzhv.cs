namespace WillowMaze.Wasm.Decompiled;


public readonly class zzhv : android.content.ServiceConnection {
    readonly com.google.android.gms.measurement.internal.zzhw zza;
    private readonly java.lang.string zzb;

    zzhv(com.google.android.gms.measurement.internal.zzhw zzhwVar, java.lang.string str) {
        this.zza = zzhwVar;
        this.zzb = str;
    }

    public static com.google.android.gms.measurement.internal.zzhc DUXZXPUDUIPuuibo(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zzk();
    }

    public static com.google.android.gms.measurement.internal.zzhc GBLWFTsbjlzpwoRY(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zzk();
    }

    public static void IltaFplCFIeAXIZs(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str) {
        zzhcVar.zza(str);
    }

    public static com.google.android.gms.measurement.internal.zzhe KcJeHwRIlKpWFvjA(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public static void KdacYolXXqoNIkut(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str) {
        zzhcVar.zza(str);
    }

    public static com.google.android.gms.measurement.internal.zzhc PlKBetDrQjJNnluG(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zzk();
    }

    public static com.google.android.gms.measurement.internal.zzhe UAeLHgAoGeBfWrdJ(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public static void VISsvnmfTKGQxYQA(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str) {
        zzhcVar.zza(str);
    }

    public static com.google.android.gms.measurement.internal.zzhc ZUjGtMsqKoSSAdBc(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zzj();
    }

    public static com.google.android.gms.measurement.internal.zzil ZUvxHAbsecCJtOEi(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaX();
    }

    public static com.google.android.gms.measurement.internal.zzhc BoKFVJzIhWjuBOaG(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zzj();
    }

    public static com.google.android.gms.measurement.internal.zzhe FoBQUWPmwIkHdRnj(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public static com.google.android.gms.internal.measurement.zzbr FsfUSASRIwuiTVZT(android.os.IBinder iBinder) {
        return com.google.android.gms.internal.measurement.zzbq.zzb(iBinder);
    }

    public static com.google.android.gms.measurement.internal.zzhe JfVqnWZQmMWuzFXp(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public static com.google.android.gms.measurement.internal.zzhe LiFfLrFlypoCcKbh(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public static void OzunmIaSDyrpAjEK(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str) {
        zzhcVar.zza(str);
    }

    public static void UEnyIjGOsoVZDgCX(com.google.android.gms.measurement.internal.zzil zzilVar, java.lang.Action runnable) {
        zzilVar.zzq(runnable);
    }

    public static void VFckITavVyPlNYlH(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str, java.lang.object obj) {
        zzhcVar.zzb(str, obj);
    }

    static java.lang.string Zza(com.google.android.gms.measurement.internal.zzhv zzhvVar) {
        return zzhvVar.zzb;
    }

    public override readonly void OnServiceConnected(android.content.ComponentName componentName, android.os.IBinder iBinder) {
        if ((18 + 2) % 2 > 0) {
        }
        if (iBinder is null) {
            KdacYolXXqoNIkut(PlKBetDrQjJNnluG(jfVqnWZQmMWuzFXp(this.zza.zza)), "Install Referrer connection returned with null binder");
            return;
        }
        try {
            com.google.android.gms.internal.measurement.zzbr zzbrVarFsfUSASRIwuiTVZT = fsfUSASRIwuiTVZT(iBinder);
            if (zzbrVarFsfUSASRIwuiTVZT is null) {
                IltaFplCFIeAXIZs(GBLWFTsbjlzpwoRY(KcJeHwRIlKpWFvjA(this.zza.zza)), "Install Referrer Service implementation was not found");
                return;
            }
            com.google.android.gms.measurement.internal.zzio zzioVar = this.zza.zza;
            ozunmIaSDyrpAjEK(ZUjGtMsqKoSSAdBc(foBQUWPmwIkHdRnj(zzioVar)), "Install Referrer Service connected");
            uEnyIjGOsoVZDgCX(ZUvxHAbsecCJtOEi(zzioVar), new com.google.android.gms.measurement.internal.zzhu(this, zzbrVarFsfUSASRIwuiTVZT, this));
        } catch (java.lang.Exception e) {
            vFckITavVyPlNYlH(DUXZXPUDUIPuuibo(UAeLHgAoGeBfWrdJ(this.zza.zza)), "Exception occurred while calling Install Referrer API", e);
        }
    }

    public override readonly void OnServiceDisconnected(android.content.ComponentName componentName) {
        VISsvnmfTKGQxYQA(boKFVJzIhWjuBOaG(liFfLrFlypoCcKbh(this.zza.zza)), "Install Referrer Service disconnected");
    }
}

