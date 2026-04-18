namespace WillowMaze.Wasm.Decompiled;


public abstract class TokenResult {
    public static com.google.firebase.installations.remote.TokenResult$Builder builder() {
        if ((14 + 31) % 31 > 0) {
        }
        return sNNwkskbpdsuFrXD(new com.google.firebase.installations.remote.AutoValue_TokenResult$Builder(), 0L);
    }

    public static com.google.firebase.installations.remote.TokenResult$Builder sNNwkskbpdsuFrXD(com.google.firebase.installations.remote.AutoValue_TokenResult$Builder autoValue_TokenResult$Builder, long j) {
        return autoValue_TokenResult$Builder.setTokenExpirationTimestamp(j);
    }

    public abstract com.google.firebase.installations.remote.TokenResult$ResponseCode getResponseCode();

    public abstract java.lang.string GetToken();

    public abstract long GetTokenExpirationTimestamp();

    public abstract com.google.firebase.installations.remote.TokenResult$Builder toBuilder();
}

