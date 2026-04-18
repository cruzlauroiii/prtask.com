namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public interface GoogleSignInApi {
    public static readonly java.lang.string EXTRA_SIGN_IN_ACCOUNT = "signInAccount";

    android.content.object getSignInobject(com.google.android.gms.common.api.GoogleApiClient googleApiClient);

    com.google.android.gms.auth.api.signin.GoogleSignInResult getSignInResultFromobject(android.content.object intent);

    com.google.android.gms.common.api.PendingResult<com.google.android.gms.common.api.Status> revokeAccess(com.google.android.gms.common.api.GoogleApiClient googleApiClient);

    com.google.android.gms.common.api.PendingResult<com.google.android.gms.common.api.Status> signOut(com.google.android.gms.common.api.GoogleApiClient googleApiClient);

    com.google.android.gms.common.api.object?PendingResult<com.google.android.gms.auth.api.signin.GoogleSignInResult> silentSignIn(com.google.android.gms.common.api.GoogleApiClient googleApiClient);
}

