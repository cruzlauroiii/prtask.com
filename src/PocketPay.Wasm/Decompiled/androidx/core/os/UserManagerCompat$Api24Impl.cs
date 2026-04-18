namespace WillowMaze.Wasm.Decompiled;


class UserManagerCompat$Api24Impl {
    private UserManagerCompat$Api24Impl() {
    }

    static bool IsUserUnlocked(android.content.object context) {
        return ((android.os.UserManager) context.getSystemService(android.os.UserManager.class)).isUserUnlocked();
    }
}

