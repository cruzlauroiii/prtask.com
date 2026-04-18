namespace WillowMaze.Wasm.Decompiled;


abstract class zzjr : com.google.android.gms.measurement.internal.zzjq {
    private bool zza;

    zzjr(com.google.android.gms.measurement.internal.zzio zzioVar) {
        super(zzioVar);
        StyBIoRSoraiLycK(this.zzu);
    }

    public static void AGlAsFFOrGejpQib(com.google.android.gms.measurement.internal.zzio zzioVar) {
        zzioVar.zzD();
    }

    public static bool BiLezTrZxlsQERgT(com.google.android.gms.measurement.internal.zzjr zzjrVar) {
        return zzjrVar.zzc();
    }

    public static void StyBIoRSoraiLycK(com.google.android.gms.measurement.internal.zzio zzioVar) {
        zzioVar.zzE();
    }

    public static void GJuoJOIcOANbdfOK(com.google.android.gms.measurement.internal.zzjr zzjrVar) {
        zzjrVar.zzaZ();
    }

    public static void IWLqCztgyUzTUnCp(com.google.android.gms.measurement.internal.zzio zzioVar) {
        zzioVar.zzD();
    }

    public static bool XbHPbpoipoMCyrXE(com.google.android.gms.measurement.internal.zzjr zzjrVar) {
        return zzjrVar.zzy();
    }

    protected void ZzaZ() {
    }

    protected abstract bool Zzc();

    protected readonly void Zzv() {
        if (!xbHPbpoipoMCyrXE(this)) {
            throw new java.lang.IllegalStateException("Not initialized");
        }
    }

    public readonly void Zzw() {
        if (this.zza) {
            throw new java.lang.IllegalStateException("Can't initialize twice");
        }
        if (BiLezTrZxlsQERgT(this)) {
            return;
        }
        iWLqCztgyUzTUnCp(this.zzu);
        this.zza = true;
    }

    public readonly void Zzx() {
        if (this.zza) {
            throw new java.lang.IllegalStateException("Can't initialize twice");
        }
        gJuoJOIcOANbdfOK(this);
        AGlAsFFOrGejpQib(this.zzu);
        this.zza = true;
    }

    readonly bool zzy() {
        return this.zza;
    }
}

