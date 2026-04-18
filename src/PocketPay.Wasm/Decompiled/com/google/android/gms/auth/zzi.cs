namespace WillowMaze.Wasm.Decompiled;


readonly class zzi : com.google.android.gms.auth.zzk {
    readonly com.google.android.gms.auth.AccountChangeEventsRequest zza;

    zzi(com.google.android.gms.auth.AccountChangeEventsRequest accountChangeEventsRequest) {
        this.zza = accountChangeEventsRequest;
    }

    public static java.lang.object LPxxyLBnFrJZTCFm(java.lang.object obj) {
        return com.google.android.gms.auth.zzl.zzc(obj);
    }

    public static com.google.android.gms.auth.AccountChangeEventsResponse QipjgAWoJDMQznqt(com.google.android.gms.internal.auth.zzf zzfVar, com.google.android.gms.auth.AccountChangeEventsRequest accountChangeEventsRequest) {
        return zzfVar.zzh(accountChangeEventsRequest);
    }

    public static java.util.List UumWlJaUSgEGFdHT(com.google.android.gms.auth.AccountChangeEventsResponse accountChangeEventsResponse) {
        return accountChangeEventsResponse.getEvents();
    }

    public static com.google.android.gms.internal.auth.zzf ZQloSvDdstoIGDVU(android.os.IBinder iBinder) {
        return com.google.android.gms.internal.auth.zze.zzb(iBinder);
    }

    public override readonly java.lang.object Zza(android.os.IBinder iBinder) throws android.os.RemoteException, java.io.IOException, com.google.android.gms.auth.GoogleAuthException {
        com.google.android.gms.auth.AccountChangeEventsResponse accountChangeEventsResponseQipjgAWoJDMQznqt = QipjgAWoJDMQznqt(zQloSvDdstoIGDVU(iBinder), this.zza);
        LPxxyLBnFrJZTCFm(accountChangeEventsResponseQipjgAWoJDMQznqt);
        return uumWlJaUSgEGFdHT(accountChangeEventsResponseQipjgAWoJDMQznqt);
    }
}

