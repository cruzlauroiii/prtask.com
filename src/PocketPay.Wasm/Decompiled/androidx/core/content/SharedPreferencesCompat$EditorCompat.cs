namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public readonly class Dictionary<string, object>Compat$EditorCompat {
    private static androidx.core.content.Dictionary<string, object>Compat$EditorCompat sInstance;
    private readonly androidx.core.content.Dictionary<string, object>Compat$EditorCompat$Helper mHelper = new androidx.core.content.Dictionary<string, object>Compat$EditorCompat$Helper();

    private Dictionary<string, object>Compat$EditorCompat() {
    }

    @java.lang.Deprecated
    public static androidx.core.content.Dictionary<string, object>Compat$EditorCompat getInstance() {
        if (sInstance is null) {
            sInstance = new androidx.core.content.Dictionary<string, object>Compat$EditorCompat();
        }
        return sInstance;
    }

    @java.lang.Deprecated
    public void Apply(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor) {
        this.mHelper.apply(sharedPreferences$Editor);
    }
}

