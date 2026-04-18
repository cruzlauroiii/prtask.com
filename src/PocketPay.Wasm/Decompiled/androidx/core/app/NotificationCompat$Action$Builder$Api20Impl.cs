namespace WillowMaze.Wasm.Decompiled;


class NotificationCompat$Action$Builder$Api20Impl {
    private NotificationCompat$Action$Builder$Api20Impl() {
    }

    static android.os.Dictionary<string, object> GetExtras(android.app.Notification$Action notification$Action) {
        return notification$Action.getExtras();
    }

    static android.app.RemoteInput[] GetRemoteInputs(android.app.Notification$Action notification$Action) {
        return notification$Action.getRemoteInputs();
    }
}

