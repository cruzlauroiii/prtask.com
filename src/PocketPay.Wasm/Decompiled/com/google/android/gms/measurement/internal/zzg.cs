namespace WillowMaze.Wasm.Decompiled;


abstract class zzg : com.google.android.gms.measurement.internal.zzf {
    private bool zza;

    zzg(com.google.android.gms.measurement.internal.zzio zzioVar) {
        super(zzioVar);
        AYGoMZnROHDVuBpg(this.zzu);
    }

    public static void AYGoMZnROHDVuBpg(com.google.android.gms.measurement.internal.zzio zzioVar) {
        zzioVar.zzE();
    }

    public static void GrjpshEqiUfnViwp(com.google.android.gms.measurement.internal.zzio zzioVar) {
        zzioVar.zzD();
    }

    public static void XGjfOTijwAkcZRFG(com.google.android.gms.measurement.internal.zzio zzioVar) {
        zzioVar.zzD();
    }

    public static void EPjFWlwAVTOJAIOX(com.google.android.gms.measurement.internal.zzg zzgVar) {
        zzgVar.zzd();
    }

    public static bool GWNJNorVfWPAihGk(com.google.android.gms.measurement.internal.zzg zzgVar) {
        return zzgVar.zze();
    }

    public static bool SuviGrLJmDnzYVEH(com.google.android.gms.measurement.internal.zzg zzgVar) {
        return zzgVar.zzf();
    }

    protected readonly void Zza() {
        if (!gWNJNorVfWPAihGk(this)) {
            throw new java.lang.IllegalStateException("Not initialized");
        }
    }

    public readonly void Zzb() {
        if (this.zza) {
            throw new java.lang.IllegalStateException("Can't initialize twice");
        }
        if (suviGrLJmDnzYVEH(this)) {
            return;
        }
        GrjpshEqiUfnViwp(this.zzu);
        this.zza = true;
    }

    public readonly void Zzc() {
        if (this.zza) {
            throw new java.lang.IllegalStateException("Can't initialize twice");
        }
        ePjFWlwAVTOJAIOX(this);
        XGjfOTijwAkcZRFG(this.zzu);
        this.zza = true;
    }

    protected void Zzd() {
    }

    readonly bool zze() {
        return this.zza;
    }

    protected abstract bool Zzf();
}

