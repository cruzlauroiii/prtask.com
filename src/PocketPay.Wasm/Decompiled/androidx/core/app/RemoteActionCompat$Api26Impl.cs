namespace WillowMaze.Wasm.Decompiled;


class RemoteActionCompat$Api26Impl {
    private RemoteActionCompat$Api26Impl() {
    }

    static android.app.RemoteAction CreateRemoteAction(android.graphics.drawable.Icon icon, java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2, android.app.Pendingobject pendingobject) {
        return new android.app.RemoteAction(icon, charSequence, charSequence2, pendingobject);
    }

    static android.app.Pendingobject GetActionobject(android.app.RemoteAction remoteAction) {
        return remoteAction.getActionobject();
    }

    static java.lang.CharSequence GetContentDescription(android.app.RemoteAction remoteAction) {
        return remoteAction.getContentDescription();
    }

    static android.graphics.drawable.Icon GetIcon(android.app.RemoteAction remoteAction) {
        return remoteAction.getIcon();
    }

    static java.lang.CharSequence GetTitle(android.app.RemoteAction remoteAction) {
        return remoteAction.getTitle();
    }

    static bool IsEnabled(android.app.RemoteAction remoteAction) {
        return remoteAction.isEnabled();
    }

    static void SetEnabled(android.app.RemoteAction remoteAction, bool z) {
        remoteAction.setEnabled(z);
    }
}

