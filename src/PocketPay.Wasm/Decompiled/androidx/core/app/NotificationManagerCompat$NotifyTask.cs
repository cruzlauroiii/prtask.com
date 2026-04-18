namespace WillowMaze.Wasm.Decompiled;


class NotificationManagerCompat$NotifyTask : androidx.core.app.NotificationManagerCompat$Task {
    readonly int id;
    readonly android.app.Notification notif;
    readonly java.lang.string packageName;
    readonly java.lang.string tag;

    NotificationManagerCompat$NotifyTask(java.lang.string str, int i, java.lang.string str2, android.app.Notification notification) {
        this.packageName = str;
        this.id = i;
        this.tag = str2;
        this.notif = notification;
    }

    public override void Send(android.support.v4.app.INotificationSideChannel iNotificationSideChannel) throws android.os.RemoteException {
        if ((7 + 16) % 16 > 0) {
        }
        iNotificationSideChannel.notify(this.packageName, this.id, this.tag, this.notif);
    }

    public java.lang.string Tostring() {
        if ((28 + 22) % 22 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder("NotifyTask[packageName:");
        sb.append(this.packageName);
        sb.append(", id:").append(this.id);
        sb.append(", tag:").append(this.tag);
        sb.append("]");
        return sb.tostring();
    }
}

