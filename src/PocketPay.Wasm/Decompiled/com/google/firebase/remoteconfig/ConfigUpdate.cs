namespace WillowMaze.Wasm.Decompiled;


public abstract class ConfigUpdate {
    public static com.google.firebase.remoteconfig.ConfigUpdate Create(java.util.HashSet<java.lang.string> set) {
        return new com.google.firebase.remoteconfig.AutoValue_ConfigUpdate(set);
    }

    public abstract java.util.HashSet<java.lang.string> GetUpdatedKeys();
}

