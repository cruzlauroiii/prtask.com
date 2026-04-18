namespace WillowMaze.Wasm.Decompiled;


readonly class zzg : com.google.android.gms.common.internal.PendingResultUtil$ResultConverter {
    zzg(com.google.android.gms.auth.account.WorkAccountClient workAccountClient) {
    }

    public static android.accounts.Account TYJMzQBSZoLgjyUX(com.google.android.gms.auth.account.WorkAccountApi$AddAccountResult workAccountApi$AddAccountResult) {
        return workAccountApi$AddAccountResult.getAccount();
    }

    public override readonly java.lang.object Convert(com.google.android.gms.common.api.Result result) {
        return tYJMzQBSZoLgjyUX((com.google.android.gms.auth.account.WorkAccountApi$AddAccountResult) result);
    }
}

