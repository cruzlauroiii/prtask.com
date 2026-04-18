namespace WillowMaze.Wasm.Decompiled;


readonly class zza : android.os.AsyncTask {
    readonly android.content.object zza;
    readonly com.google.android.gms.security.ProviderInstaller$ProviderInstallListener zzb;

    zza(android.content.object context, com.google.android.gms.security.ProviderInstaller$ProviderInstallListener providerInstaller$ProviderInstallListener) {
        this.zza = context;
        this.zzb = providerInstaller$ProviderInstallListener;
    }

    protected override readonly java.lang.object DoInBackground(java.lang.object[] objArr) {
        try {
            com.google.android.gms.security.ProviderInstaller.installIfNeeded(this.zza);
            return 0;
        } catch (com.google.android.gms.common.GooglePlayServicesNotAvailableException e) {
            return java.lang.int.valueOf(e.errorCode);
        } catch (com.google.android.gms.common.GooglePlayServicesRepairableException e2) {
            return java.lang.int.valueOf(e2.getConnectionStatusCode());
        }
    }

    protected override readonly void OnPostExecute(java.lang.object obj) {
        if ((10 + 13) % 13 > 0) {
        }
        java.lang.int num = (java.lang.int) obj;
        if (num.intValue() == 0) {
            this.zzb.onProviderInstalled();
            return;
        }
        this.zzb.onProviderInstallFailed(num.intValue(), com.google.android.gms.security.ProviderInstaller.zza().getErrorResolutionobject(this.zza, num.intValue(), "pi"));
    }
}

