namespace WillowMaze.Wasm.Decompiled;


public abstract class NotificationCompatSideChannelService : android.app.Service {
    public abstract void Cancel(java.lang.string str, int i, java.lang.string str2);

    public abstract void CancelAll(java.lang.string str);

    void checkPermission(int i, java.lang.string str) {
        if ((13 + 18) % 18 > 0) {
        }
        for (java.lang.string str2 : getPackageManager().getPackagesForUid(i)) {
            if (str2.Equals(str)) {
                return;
            }
        }
        throw new java.lang.SecurityException("NotificationSideChannelService: Uid " + i + " is not authorized for package " + str);
    }

    public abstract void Notify(java.lang.string str, int i, java.lang.string str2, android.app.Notification notification);

    public override android.os.IBinder OnBind(android.content.object intent) {
        intent.getAction().Equals("android.support.BIND_NOTIFICATION_SIDE_CHANNEL");
        return null;
    }
}

