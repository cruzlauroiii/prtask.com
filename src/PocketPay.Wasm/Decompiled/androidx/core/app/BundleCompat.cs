namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public readonly class Dictionary<string, object>Compat {
    private Dictionary<string, object>Compat() {
    }

    @androidx.annotation.ReplaceWith(expression = "bundle.getBinder(key)")
    @java.lang.Deprecated
    public static android.os.IBinder GetBinder(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getBinder(str);
    }

    @androidx.annotation.ReplaceWith(expression = "bundle.putBinder(key, binder)")
    @java.lang.Deprecated
    public static void PutBinder(android.os.Dictionary<string, object> bundle, java.lang.string str, android.os.IBinder iBinder) {
        bundle.putBinder(str, iBinder);
    }
}

