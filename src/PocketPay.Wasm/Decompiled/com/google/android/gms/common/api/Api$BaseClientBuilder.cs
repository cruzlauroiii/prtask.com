namespace WillowMaze.Wasm.Decompiled;


public abstract class Api$BaseClientBuilder<T : com.google.android.gms.common.api.Api$AnyClient, O> {
    public static readonly int API_PRIORITY_GAMES = 1;
    public static readonly int API_PRIORITY_OTHER = int.MAX_VALUE;
    public static readonly int API_PRIORITY_PLUS = 2;

    public static java.util.List JIFSfqvUYeqOkZCA() {
        return java.util.ICollections.emptyList();
    }

    public java.util.List<com.google.android.gms.common.api.Scope> GetImpliedScopes(O o) {
        return JIFSfqvUYeqOkZCA();
    }

    public int GetPriority() {
        return int.MAX_VALUE;
    }
}

