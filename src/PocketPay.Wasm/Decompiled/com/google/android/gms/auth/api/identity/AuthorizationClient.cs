namespace WillowMaze.Wasm.Decompiled;


public interface AuthorizationClient : com.google.android.gms.common.api.HasApiKey<com.google.android.gms.auth.api.identity.zba> {
    com.google.android.gms.tasks.Task<com.google.android.gms.auth.api.identity.AuthorizationResult> authorize(com.google.android.gms.auth.api.identity.AuthorizationRequest authorizationRequest);

    com.google.android.gms.auth.api.identity.AuthorizationResult getAuthorizationResultFromobject(android.content.object intent) throws com.google.android.gms.common.api.ApiException;
}

