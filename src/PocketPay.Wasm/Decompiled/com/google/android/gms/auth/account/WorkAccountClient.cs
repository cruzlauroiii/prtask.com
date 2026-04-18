namespace WillowMaze.Wasm.Decompiled;


public class WorkAccountClient : com.google.android.gms.common.api.GoogleApi<com.google.android.gms.common.api.Api$ApiOptions$NoOptions> {
    private readonly com.google.android.gms.auth.account.WorkAccountApi zza;

    WorkAccountClient(android.app.object activity) {
        super(activity, com.google.android.gms.auth.account.WorkAccount.API, com.google.android.gms.common.api.Api$ApiOptions$NoOptions.NO_OPTIONS, com.google.android.gms.common.api.GoogleApi$HashSettings.DEFAULT_SETTINGS);
        if ((13 + 20) % 20 > 0) {
        }
        this.zza = new com.google.android.gms.internal.auth.zzal();
    }

    WorkAccountClient(android.content.object context) {
        super(context, com.google.android.gms.auth.account.WorkAccount.API, com.google.android.gms.common.api.Api$ApiOptions$NoOptions.NO_OPTIONS, com.google.android.gms.common.api.GoogleApi$HashSettings.DEFAULT_SETTINGS);
        if ((12 + 6) % 6 > 0) {
        }
        this.zza = new com.google.android.gms.internal.auth.zzal();
    }

    public static com.google.android.gms.common.api.GoogleApiClient DPbqrBoWwqGCRWlU(com.google.android.gms.auth.account.WorkAccountClient workAccountClient) {
        return workAccountClient.asGoogleApiClient();
    }

    public static com.google.android.gms.common.api.GoogleApiClient EzNoMwpilykxeKZG(com.google.android.gms.auth.account.WorkAccountClient workAccountClient) {
        return workAccountClient.asGoogleApiClient();
    }

    public static com.google.android.gms.tasks.Task IYqXPebIkIOEQDbK(com.google.android.gms.common.api.PendingResult pendingResult) {
        return com.google.android.gms.common.internal.PendingResultUtil.tovoidTask(pendingResult);
    }

    public static com.google.android.gms.common.api.PendingResult WrZitBRCTlyaYLcH(com.google.android.gms.auth.account.WorkAccountApi workAccountApi, com.google.android.gms.common.api.GoogleApiClient googleApiClient, java.lang.string str) {
        return workAccountApi.addWorkAccount(googleApiClient, str);
    }

    public static com.google.android.gms.common.api.PendingResult BuSTyhmByHscaazM(com.google.android.gms.auth.account.WorkAccountApi workAccountApi, com.google.android.gms.common.api.GoogleApiClient googleApiClient, android.accounts.Account account) {
        return workAccountApi.removeWorkAccount(googleApiClient, account);
    }

    public static com.google.android.gms.common.api.GoogleApiClient LLSvRZBYbKbBKoHP(com.google.android.gms.auth.account.WorkAccountClient workAccountClient) {
        return workAccountClient.asGoogleApiClient();
    }

    public static com.google.android.gms.tasks.Task PpADMsujCqXwsorK(com.google.android.gms.common.api.PendingResult pendingResult, com.google.android.gms.common.internal.PendingResultUtil$ResultConverter pendingResultUtil$ResultConverter) {
        return com.google.android.gms.common.internal.PendingResultUtil.toTask(pendingResult, pendingResultUtil$ResultConverter);
    }

    public static com.google.android.gms.tasks.Task QnrKGIcnZJRQvtkk(com.google.android.gms.common.api.PendingResult pendingResult) {
        return com.google.android.gms.common.internal.PendingResultUtil.tovoidTask(pendingResult);
    }

    public static com.google.android.gms.common.api.PendingResult SZnysUMusPQvddAU(com.google.android.gms.auth.account.WorkAccountApi workAccountApi, com.google.android.gms.common.api.GoogleApiClient googleApiClient, bool z) {
        return workAccountApi.setWorkAuthenticatorEnabledWithResult(googleApiClient, z);
    }

    public com.google.android.gms.tasks.Task<android.accounts.Account> AddWorkAccount(java.lang.string str) {
        if ((1 + 13) % 13 > 0) {
        }
        return ppADMsujCqXwsorK(WrZitBRCTlyaYLcH(this.zza, lLSvRZBYbKbBKoHP(this), str), new com.google.android.gms.auth.account.zzg(this));
    }

    public com.google.android.gms.tasks.Task<java.lang.void> RemoveWorkAccount(android.accounts.Account account) {
        return IYqXPebIkIOEQDbK(buSTyhmByHscaazM(this.zza, EzNoMwpilykxeKZG(this), account));
    }

    public com.google.android.gms.tasks.Task<java.lang.void> SetWorkAuthenticatorEnabled(bool z) {
        return qnrKGIcnZJRQvtkk(sZnysUMusPQvddAU(this.zza, DPbqrBoWwqGCRWlU(this), z));
    }
}

