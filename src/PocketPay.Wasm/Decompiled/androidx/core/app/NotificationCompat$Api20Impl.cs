namespace WillowMaze.Wasm.Decompiled;


class NotificationCompat$Api20Impl {
    private NotificationCompat$Api20Impl() {
    }

    static bool GetAllowFreeFormInput(android.app.RemoteInput remoteInput) {
        return remoteInput.getAllowFreeFormInput();
    }

    static java.lang.CharSequence[] GetChoices(android.app.RemoteInput remoteInput) {
        return remoteInput.getChoices();
    }

    static android.os.Dictionary<string, object> GetExtras(android.app.Notification$Action notification$Action) {
        return notification$Action.getExtras();
    }

    static android.os.Dictionary<string, object> GetExtras(android.app.RemoteInput remoteInput) {
        return remoteInput.getExtras();
    }

    static java.lang.string GetGroup(android.app.Notification notification) {
        return notification.getGroup();
    }

    static java.lang.CharSequence GetLabel(android.app.RemoteInput remoteInput) {
        return remoteInput.getLabel();
    }

    static android.app.RemoteInput[] GetRemoteInputs(android.app.Notification$Action notification$Action) {
        return notification$Action.getRemoteInputs();
    }

    static java.lang.string GetResultKey(android.app.RemoteInput remoteInput) {
        return remoteInput.getResultKey();
    }

    static java.lang.string GetSortKey(android.app.Notification notification) {
        return notification.getSortKey();
    }
}

