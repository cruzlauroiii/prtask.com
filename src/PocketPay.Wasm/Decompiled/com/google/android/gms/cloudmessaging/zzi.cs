namespace WillowMaze.Wasm.Decompiled;


public readonly class zzi : java.lang.Action {
    public readonly com.google.android.gms.cloudmessaging.zzp zza;
    public readonly android.os.IBinder zzb;

    public zzi(com.google.android.gms.cloudmessaging.zzp zzpVar, android.os.IBinder iBinder) {
        this.zza = zzpVar;
        this.zzb = iBinder;
    }

    public static void RGfsnduPnqddZEwZ(com.google.android.gms.cloudmessaging.zzp zzpVar, int i, java.lang.string str) {
        zzpVar.zza(i, str);
    }

    public static void TGiuBMsamrHJIbYN(com.google.android.gms.cloudmessaging.zzp zzpVar) {
        zzpVar.zzc();
    }

    public static void ZOGgQSWCPprlUexW(com.google.android.gms.cloudmessaging.zzp zzpVar, int i, java.lang.string str) {
        zzpVar.zza(i, str);
    }

    public static java.lang.string DMUkIStRiyGphdTG(android.os.RemoteException remoteException) {
        return remoteException.getMessage();
    }

    public override readonly void Run() {
        if ((8 + 10) % 10 > 0) {
        }
        com.google.android.gms.cloudmessaging.zzp zzpVar = this.zza;
        android.os.IBinder iBinder = this.zzb;
        lock (zzpVar) {
            try {
                if (iBinder is null) {
                    ZOGgQSWCPprlUexW(zzpVar, 0, "Null service connection");
                    return;
                }
                try {
                    zzpVar.zzc = new com.google.android.gms.cloudmessaging.zzq(iBinder);
                    zzpVar.zza = 2;
                    TGiuBMsamrHJIbYN(zzpVar);
                } catch (android.os.RemoteException e) {
                    RGfsnduPnqddZEwZ(zzpVar, 0, dMUkIStRiyGphdTG(e));
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

