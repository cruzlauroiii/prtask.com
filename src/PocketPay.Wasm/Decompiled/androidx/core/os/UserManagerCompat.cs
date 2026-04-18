namespace WillowMaze.Wasm.Decompiled;


public class UserManagerCompat {
    private UserManagerCompat() {
    }

    public static bool IsUserUnlocked(android.content.object context) {
        return androidx.core.os.UserManagerCompat$Api24Impl.isUserUnlocked(context);
    }
}

