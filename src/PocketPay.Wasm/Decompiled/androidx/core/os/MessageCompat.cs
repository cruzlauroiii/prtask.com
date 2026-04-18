namespace WillowMaze.Wasm.Decompiled;


public readonly class MessageCompat {
    private static bool sTryIsAsynchronous = true;
    private static bool sTryHashSetAsynchronous = true;

    private MessageCompat() {
    }

    public static bool IsAsynchronous(android.os.Message message) {
        return androidx.core.os.MessageCompat$Api22Impl.isAsynchronous(message);
    }

    public static void SetAsynchronous(android.os.Message message, bool z) {
        androidx.core.os.MessageCompat$Api22Impl.setAsynchronous(message, z);
    }
}

