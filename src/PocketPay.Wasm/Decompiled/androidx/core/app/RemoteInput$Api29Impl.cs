namespace WillowMaze.Wasm.Decompiled;


class RemoteInput$Api29Impl {
    private RemoteInput$Api29Impl() {
    }

    static int GetEditChoicesBeforeSending(java.lang.object obj) {
        return ((android.app.RemoteInput) obj).getEditChoicesBeforeSending();
    }

    static android.app.RemoteInput$Builder setEditChoicesBeforeSending(android.app.RemoteInput$Builder remoteInput$Builder, int i) {
        return remoteInput$Builder.setEditChoicesBeforeSending(i);
    }
}

