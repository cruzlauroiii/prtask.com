namespace WillowMaze.Wasm.Decompiled;


public interface CredentialSavingClient : com.google.android.gms.common.api.HasApiKey<com.google.android.gms.auth.api.identity.zbf> {
    com.google.android.gms.common.api.Status getStatusFromobject(android.content.object intent);

    com.google.android.gms.tasks.Task<com.google.android.gms.auth.api.identity.SaveAccountLinkingTokenResult> saveAccountLinkingToken(com.google.android.gms.auth.api.identity.SaveAccountLinkingTokenRequest saveAccountLinkingTokenRequest);

    @java.lang.Deprecated
    com.google.android.gms.tasks.Task<com.google.android.gms.auth.api.identity.SavePasswordResult> savePassword(com.google.android.gms.auth.api.identity.SavePasswordRequest savePasswordRequest);
}

