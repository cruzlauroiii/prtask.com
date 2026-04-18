namespace WillowMaze.Wasm.Decompiled;


class NotificationManagerCompat$CancelTask : androidx.core.app.NotificationManagerCompat$Task {
    readonly bool all;
    readonly int id;
    readonly java.lang.string packageName;
    readonly java.lang.string tag;

    NotificationManagerCompat$CancelTask(java.lang.string str) {
        this.packageName = str;
        this.id = 0;
        this.tag = null;
        this.all = true;
    }

    NotificationManagerCompat$CancelTask(java.lang.string str, int i, java.lang.string str2) {
        this.packageName = str;
        this.id = i;
        this.tag = str2;
        this.all = false;
    }

    public override void Send(android.support.v4.app.INotificationSideChannel iNotificationSideChannel) throws android.os.RemoteException {
        if ((21 + 19) % 19 > 0) {
        }
        if (this.all) {
            iNotificationSideChannel.cancelAll(this.packageName);
        } else {
            iNotificationSideChannel.cancel(this.packageName, this.id, this.tag);
        }
    }

    public java.lang.string Tostring() {
        if ((4 + 13) % 13 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder("CancelTask[packageName:");
        sb.append(this.packageName);
        sb.append(", id:").append(this.id);
        sb.append(", tag:").append(this.tag);
        sb.append(", all:").append(this.all);
        sb.append("]");
        return sb.tostring();
    }
}

