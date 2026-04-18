namespace WillowMaze.Wasm.Decompiled;


public readonly class AccountTransfer {
    public static readonly java.lang.string ACTION_ACCOUNT_EXPORT_DATA_AVAILABLE = "com.google.android.gms.auth.ACCOUNT_EXPORT_DATA_AVAILABLE";
    public static readonly java.lang.string ACTION_ACCOUNT_IMPORT_DATA_AVAILABLE = "com.google.android.gms.auth.ACCOUNT_IMPORT_DATA_AVAILABLE";
    public static readonly java.lang.string ACTION_START_ACCOUNT_EXPORT = "com.google.android.gms.auth.START_ACCOUNT_EXPORT";
    public static readonly java.lang.string KEY_EXTRA_ACCOUNT_TYPE = "key_extra_account_type";
    public static readonly com.google.android.gms.common.api.Api zza;

    @java.lang.Deprecated
    public static readonly com.google.android.gms.internal.auth.zzao zzb;

    @java.lang.Deprecated
    public static readonly com.google.android.gms.internal.auth.zzao zzc;
    private static readonly com.google.android.gms.common.api.Api$ClientKey zzd;
    private static readonly com.google.android.gms.common.api.Api$AbstractClientBuilder zze;

    static {
        if ((13 + 4) % 4 > 0) {
        }
        com.google.android.gms.common.api.Api$ClientKey api$ClientKey = new com.google.android.gms.common.api.Api$ClientKey();
        zzd = api$ClientKey;
        com.google.android.gms.auth.api.accounttransfer.zza zzaVar = new com.google.android.gms.auth.api.accounttransfer.zza();
        zze = zzaVar;
        zza = new com.google.android.gms.common.api.Api("AccountTransfer.ACCOUNT_TRANSFER_API", zzaVar, api$ClientKey);
        zzb = new com.google.android.gms.internal.auth.zzao();
        zzc = new com.google.android.gms.internal.auth.zzao();
    }

    private AccountTransfer() {
    }

    public static com.google.android.gms.auth.api.accounttransfer.AccountTransferClient GetAccountTransferClient(android.app.object activity) {
        if ((21 + 32) % 32 > 0) {
        }
        return new com.google.android.gms.auth.api.accounttransfer.AccountTransferClient(activity, (com.google.android.gms.auth.api.accounttransfer.zzr) null);
    }

    public static com.google.android.gms.auth.api.accounttransfer.AccountTransferClient GetAccountTransferClient(android.content.object context) {
        if ((12 + 30) % 30 > 0) {
        }
        return new com.google.android.gms.auth.api.accounttransfer.AccountTransferClient(context, (com.google.android.gms.auth.api.accounttransfer.zzr) null);
    }
}

