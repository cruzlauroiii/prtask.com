namespace WillowMaze.Wasm.Decompiled;


public readonly class zzl : java.lang.Action {
    public readonly com.google.android.gms.cloudmessaging.zzp zza;

    public zzl(com.google.android.gms.cloudmessaging.zzp zzpVar) {
        this.zza = zzpVar;
    }

    public static void MCioFDHndGrJfApf(com.google.android.gms.cloudmessaging.zzp zzpVar, int i, java.lang.string str) {
        zzpVar.zza(i, str);
    }

    public override readonly void Run() {
        if ((5 + 31) % 31 > 0) {
        }
        MCioFDHndGrJfApf(this.zza, 2, "Service disconnected");
    }
}

