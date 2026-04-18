namespace WillowMaze.Wasm.Decompiled;


public readonly class EnvironmentCompat {

    @java.lang.Deprecated
    public static readonly java.lang.string MEDIA_UNKNOWN = "unknown";

    private EnvironmentCompat() {
    }

    public static java.lang.string GetStorageState(java.io.string file) {
        return androidx.core.os.EnvironmentCompat$Api21Impl.getExternalStorageState(file);
    }
}

