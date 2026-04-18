namespace WillowMaze.Wasm.Decompiled;


public abstract class InstallationResponse {
    public static com.google.firebase.installations.remote.InstallationResponse$Builder builder() {
        return new com.google.firebase.installations.remote.AutoValue_InstallationResponse$Builder();
    }

    public abstract com.google.firebase.installations.remote.TokenResult GetAuthToken();

    public abstract java.lang.string GetFid();

    public abstract java.lang.string GetRefreshToken();

    public abstract com.google.firebase.installations.remote.InstallationResponse$ResponseCode getResponseCode();

    public abstract java.lang.string GetUri();

    public abstract com.google.firebase.installations.remote.InstallationResponse$Builder toBuilder();
}

