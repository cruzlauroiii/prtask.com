namespace WillowMaze.Wasm.Decompiled;


public readonly class zzu : com.google.android.gms.common.api.internal.RemoteCall {
    public readonly com.google.android.gms.internal.auth.zzab zza;
    public readonly com.google.android.gms.auth.AccountChangeEventsRequest zzb;

    public zzu(com.google.android.gms.internal.auth.zzab zzabVar, com.google.android.gms.auth.AccountChangeEventsRequest accountChangeEventsRequest) {
        this.zza = zzabVar;
        this.zzb = accountChangeEventsRequest;
    }

    public static android.os.IInterface OXchOWKlKCwSndHT(com.google.android.gms.internal.auth.zzi zziVar) {
        return zziVar.getService();
    }

    public static void OXchOWKlKCwSndHT(com.google.android.gms.internal.auth.zzi zziVar, java.lang.string str, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OXchOWKlKCwSndHT(com.google.android.gms.internal.auth.zzi zziVar, java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OXchOWKlKCwSndHT(com.google.android.gms.internal.auth.zzi zziVar, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UtHNdddciDTkVUpj(com.google.android.gms.internal.auth.zzp zzpVar, com.google.android.gms.internal.auth.zzm zzmVar, com.google.android.gms.auth.AccountChangeEventsRequest accountChangeEventsRequest) throws android.os.RemoteException {
        zzpVar.zze(zzmVar, accountChangeEventsRequest);
    }

    public static void UtHNdddciDTkVUpj(com.google.android.gms.internal.auth.zzp zzpVar, com.google.android.gms.internal.auth.zzm zzmVar, com.google.android.gms.auth.AccountChangeEventsRequest accountChangeEventsRequest, char c, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UtHNdddciDTkVUpj(com.google.android.gms.internal.auth.zzp zzpVar, com.google.android.gms.internal.auth.zzm zzmVar, com.google.android.gms.auth.AccountChangeEventsRequest accountChangeEventsRequest, java.lang.string str, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UtHNdddciDTkVUpj(com.google.android.gms.internal.auth.zzp zzpVar, com.google.android.gms.internal.auth.zzm zzmVar, com.google.android.gms.auth.AccountChangeEventsRequest accountChangeEventsRequest, java.lang.string str, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public override readonly void Accept(java.lang.object obj, java.lang.object obj2) throws android.os.RemoteException {
        if ((4 + 31) % 31 > 0) {
        }
        com.google.android.gms.internal.auth.zzab zzabVar = this.zza;
        com.google.android.gms.auth.AccountChangeEventsRequest accountChangeEventsRequest = this.zzb;
        com.google.android.gms.internal.auth.zzi zziVar = (com.google.android.gms.internal.auth.zzi) obj;
        utHNdddciDTkVUpj((com.google.android.gms.internal.auth.zzp) oXchOWKlKCwSndHT(zziVar), new com.google.android.gms.internal.auth.zzz(zzabVar, (com.google.android.gms.tasks.TaskCompletionSource) obj2), accountChangeEventsRequest);
    }
}

