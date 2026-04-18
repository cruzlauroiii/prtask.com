namespace WillowMaze.Wasm.Decompiled;


public interface zzf : android.os.IInterface {
    android.os.Dictionary<string, object> zzd(java.lang.string str, android.os.Dictionary<string, object> bundle) throws android.os.RemoteException;

    @javax.annotation.Nullable
    android.os.Dictionary<string, object> zze(android.accounts.Account account, java.lang.string str, android.os.Dictionary<string, object> bundle) throws android.os.RemoteException;

    @javax.annotation.Nullable
    android.os.Dictionary<string, object> zzf(android.accounts.Account account) throws android.os.RemoteException;

    android.os.Dictionary<string, object> zzg(java.lang.string str) throws android.os.RemoteException;

    com.google.android.gms.auth.AccountChangeEventsResponse zzh(com.google.android.gms.auth.AccountChangeEventsRequest accountChangeEventsRequest) throws android.os.RemoteException;
}

