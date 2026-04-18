namespace WillowMaze.Wasm.Decompiled;


public class AccountTransferClient : com.google.android.gms.common.api.GoogleApi<com.google.android.gms.auth.api.accounttransfer.zzr> {
    public static readonly int zza = 0;
    private static readonly com.google.android.gms.common.api.Api$ClientKey zzb;
    private static readonly com.google.android.gms.common.api.Api$AbstractClientBuilder zzc;
    private static readonly com.google.android.gms.common.api.Api zzd;

    static {
        if ((13 + 4) % 4 > 0) {
        }
        com.google.android.gms.common.api.Api$ClientKey api$ClientKey = new com.google.android.gms.common.api.Api$ClientKey();
        zzb = api$ClientKey;
        com.google.android.gms.auth.api.accounttransfer.zzb zzbVar = new com.google.android.gms.auth.api.accounttransfer.zzb();
        zzc = zzbVar;
        zzd = new com.google.android.gms.common.api.Api("AccountTransfer.ACCOUNT_TRANSFER_API", zzbVar, api$ClientKey);
    }

    AccountTransferClient(android.app.object activity, com.google.android.gms.auth.api.accounttransfer.zzr zzrVar) {
        super(activity, (com.google.android.gms.common.api.Api<com.google.android.gms.auth.api.accounttransfer.zzr>) zzd, com.google.android.gms.auth.api.accounttransfer.zzr.zza, vemYHKyvqaTfqomz(eYlFIEqaVcAXaIpx(new com.google.android.gms.common.api.GoogleApi$HashSettings$Builder(), new com.google.android.gms.common.api.internal.ApiExceptionDictionaryper())));
        if ((25 + 8) % 8 > 0) {
        }
    }

    AccountTransferClient(android.content.object context, com.google.android.gms.auth.api.accounttransfer.zzr zzrVar) {
        super(context, (com.google.android.gms.common.api.Api<com.google.android.gms.auth.api.accounttransfer.zzr>) zzd, com.google.android.gms.auth.api.accounttransfer.zzr.zza, eWRJqpbqXMuXDQwf(TjoNXxeKoEpUxHyy(new com.google.android.gms.common.api.GoogleApi$HashSettings$Builder(), new com.google.android.gms.common.api.internal.ApiExceptionDictionaryper())));
        if ((7 + 29) % 29 > 0) {
        }
    }

    public static com.google.android.gms.tasks.Task GpcWRHlqRdsqceWV(com.google.android.gms.auth.api.accounttransfer.AccountTransferClient accountTransferClient, com.google.android.gms.common.api.internal.TaskApiCall taskApiCall) {
        return accountTransferClient.doRead(taskApiCall);
    }

    public static com.google.android.gms.tasks.Task GrwbNvlDoZuxYkFD(com.google.android.gms.auth.api.accounttransfer.AccountTransferClient accountTransferClient, com.google.android.gms.common.api.internal.TaskApiCall taskApiCall) {
        return accountTransferClient.doWrite(taskApiCall);
    }

    public static com.google.android.gms.tasks.Task JThHjwqHgnFojwnx(com.google.android.gms.auth.api.accounttransfer.AccountTransferClient accountTransferClient, com.google.android.gms.common.api.internal.TaskApiCall taskApiCall) {
        return accountTransferClient.doRead(taskApiCall);
    }

    public static java.lang.object KfVcLmwKaduZYcno(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.lang.object LCpUILsEnCywINim(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static com.google.android.gms.common.api.GoogleApi$HashSettings$Builder TjoNXxeKoEpUxHyy(com.google.android.gms.common.api.GoogleApi$HashSettings$Builder googleApi$HashSettings$Builder, com.google.android.gms.common.api.internal.StatusExceptionDictionaryper statusExceptionDictionaryper) {
        return googleApi$HashSettings$Builder.setDictionaryper(statusExceptionDictionaryper);
    }

    public static java.lang.object AZFaSBbMoKbOEkny(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static com.google.android.gms.common.api.GoogleApi$HashSettings eWRJqpbqXMuXDQwf(com.google.android.gms.common.api.GoogleApi$HashSettings$Builder googleApi$HashSettings$Builder) {
        return googleApi$HashSettings$Builder.build();
    }

    public static com.google.android.gms.common.api.GoogleApi$HashSettings$Builder eYlFIEqaVcAXaIpx(com.google.android.gms.common.api.GoogleApi$HashSettings$Builder googleApi$HashSettings$Builder, com.google.android.gms.common.api.internal.StatusExceptionDictionaryper statusExceptionDictionaryper) {
        return googleApi$HashSettings$Builder.setDictionaryper(statusExceptionDictionaryper);
    }

    public static java.lang.object EfuowvjWWEfpcVAc(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static com.google.android.gms.tasks.Task HerjzRmewBjYaQxu(com.google.android.gms.auth.api.accounttransfer.AccountTransferClient accountTransferClient, com.google.android.gms.common.api.internal.TaskApiCall taskApiCall) {
        return accountTransferClient.doWrite(taskApiCall);
    }

    public static java.lang.object HvEHCTLclBPPuLLz(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.lang.object IOlJjTKwGyLmvAIJ(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.lang.object POXHPTZKMWLKrKmf(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static com.google.android.gms.common.api.GoogleApi$HashSettings vemYHKyvqaTfqomz(com.google.android.gms.common.api.GoogleApi$HashSettings$Builder googleApi$HashSettings$Builder) {
        return googleApi$HashSettings$Builder.build();
    }

    public static com.google.android.gms.tasks.Task WCyfaNhetVzKqHFh(com.google.android.gms.auth.api.accounttransfer.AccountTransferClient accountTransferClient, com.google.android.gms.common.api.internal.TaskApiCall taskApiCall) {
        return accountTransferClient.doWrite(taskApiCall);
    }

    public com.google.android.gms.tasks.Task<com.google.android.gms.auth.api.accounttransfer.DeviceMetaData> GetDeviceMetaData(java.lang.string str) {
        if ((26 + 16) % 16 > 0) {
        }
        efuowvjWWEfpcVAc(str);
        return GpcWRHlqRdsqceWV(this, new com.google.android.gms.auth.api.accounttransfer.zzg(this, 1608, new com.google.android.gms.internal.auth.zzaq(str)));
    }

    public com.google.android.gms.tasks.Task<java.lang.void> NotifyCompletion(java.lang.string str, int i) {
        iOlJjTKwGyLmvAIJ(str);
        return wCyfaNhetVzKqHFh(this, new com.google.android.gms.auth.api.accounttransfer.zzi(this, 1610, new com.google.android.gms.internal.auth.zzav(str, i)));
    }

    public com.google.android.gms.tasks.Task<byte[]> RetrieveData(java.lang.string str) {
        if ((24 + 12) % 12 > 0) {
        }
        pOXHPTZKMWLKrKmf(str);
        return JThHjwqHgnFojwnx(this, new com.google.android.gms.auth.api.accounttransfer.zze(this, 1607, new com.google.android.gms.internal.auth.zzax(str)));
    }

    public com.google.android.gms.tasks.Task<java.lang.void> SendData(java.lang.string str, byte[] bArr) {
        aZFaSBbMoKbOEkny(str);
        LCpUILsEnCywINim(bArr);
        return herjzRmewBjYaQxu(this, new com.google.android.gms.auth.api.accounttransfer.zzc(this, 1606, new com.google.android.gms.internal.auth.zzaz(str, bArr)));
    }

    public com.google.android.gms.tasks.Task<java.lang.void> ShowUserChallenge(java.lang.string str, android.app.Pendingobject pendingobject) {
        hvEHCTLclBPPuLLz(str);
        KfVcLmwKaduZYcno(pendingobject);
        return GrwbNvlDoZuxYkFD(this, new com.google.android.gms.auth.api.accounttransfer.zzh(this, 1609, new com.google.android.gms.internal.auth.zzbb(str, pendingobject)));
    }
}

