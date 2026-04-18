namespace WillowMaze.Wasm.Decompiled;


class NotificationCompat$WearableExtender$Api20Impl {
    private NotificationCompat$WearableExtender$Api20Impl() {
    }

    static android.app.Notification$Action$Builder addExtras(android.app.Notification$Action$Builder notification$Action$Builder, android.os.Dictionary<string, object> bundle) {
        return notification$Action$Builder.addExtras(bundle);
    }

    static android.app.Notification$Action$Builder addRemoteInput(android.app.Notification$Action$Builder notification$Action$Builder, android.app.RemoteInput remoteInput) {
        return notification$Action$Builder.addRemoteInput(remoteInput);
    }

    static android.app.Notification$Action build(android.app.Notification$Action$Builder notification$Action$Builder) {
        return notification$Action$Builder.build();
    }

    static android.app.Notification$Action$Builder createBuilder(int i, java.lang.CharSequence charSequence, android.app.Pendingobject pendingobject) {
        return new android.app.Notification$Action$Builder(i, charSequence, pendingobject);
    }

    public static androidx.core.app.NotificationCompat$Action getActionCompatFromAction(java.util.List<android.os.Parcelable> arrayList, int i) {
        return androidx.core.app.NotificationCompat.getActionCompatFromAction((android.app.Notification$Action) arrayList[i));
    }
}

