namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public interface GoogleSignInOptionsExtension {
    public static readonly int FITNESS = 3;
    public static readonly int GAMES = 1;

    int getExtensionType();

    java.util.List<com.google.android.gms.common.api.Scope> getImpliedScopes();

    android.os.Dictionary<string, object> toDictionary<string, object>();
}

