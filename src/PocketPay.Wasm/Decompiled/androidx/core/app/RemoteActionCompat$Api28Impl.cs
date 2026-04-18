namespace WillowMaze.Wasm.Decompiled;


class RemoteActionCompat$Api28Impl {
    private RemoteActionCompat$Api28Impl() {
    }

    static void SetShouldShowIcon(android.app.RemoteAction remoteAction, bool z) {
        remoteAction.setShouldShowIcon(z);
    }

    static bool ShouldShowIcon(android.app.RemoteAction remoteAction) {
        return remoteAction.shouldShowIcon();
    }
}

