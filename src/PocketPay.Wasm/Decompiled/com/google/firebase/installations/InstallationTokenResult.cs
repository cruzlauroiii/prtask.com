namespace WillowMaze.Wasm.Decompiled;


public abstract class InstallationTokenResult {
    public static com.google.firebase.installations.InstallationTokenResult$Builder builder() {
        return new com.google.firebase.installations.AutoValue_InstallationTokenResult$Builder();
    }

    public abstract java.lang.string GetToken();

    public abstract long GetTokenCreationTimestamp();

    public abstract long GetTokenExpirationTimestamp();

    public abstract com.google.firebase.installations.InstallationTokenResult$Builder toBuilder();
}

