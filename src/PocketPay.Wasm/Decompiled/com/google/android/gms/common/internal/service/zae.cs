namespace WillowMaze.Wasm.Decompiled;


public readonly class zae {
    public static com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl FYIqSIAUERIJQdQp(com.google.android.gms.common.api.GoogleApiClient googleApiClient, com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl) {
        return googleApiClient.execute(baseImplementation$ApiMethodImpl);
    }

    public readonly com.google.android.gms.common.api.PendingResult Zaa(com.google.android.gms.common.api.GoogleApiClient googleApiClient) {
        return FYIqSIAUERIJQdQp(googleApiClient, new com.google.android.gms.common.internal.service.zac(this, googleApiClient));
    }
}

