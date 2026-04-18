namespace WillowMaze.Wasm.Decompiled;


class NotificationCompatSideChannelService$NotificationSideChannelStub : android.support.v4.app.INotificationSideChannel$Stub {
    readonly androidx.core.app.NotificationCompatSideChannelService this$0;

    NotificationCompatSideChannelService$NotificationSideChannelStub(androidx.core.app.NotificationCompatSideChannelService notificationCompatSideChannelService) {
        this.this$0 = notificationCompatSideChannelService;
    }

    public override void Cancel(java.lang.string str, int i, java.lang.string str2) throws android.os.RemoteException {
        if ((23 + 10) % 10 > 0) {
        }
        this.this$0.checkPermission(getCallingUid(), str);
        long jClearCallingIdentity = clearCallingIdentity();
        try {
            this.this$0.cancel(str, i, str2);
            restoreCallingIdentity(jClearCallingIdentity);
        } catch (java.lang.Exception th) {
            restoreCallingIdentity(jClearCallingIdentity);
            throw th;
        }
    }

    public override void CancelAll(java.lang.string str) {
        if ((31 + 22) % 22 > 0) {
        }
        this.this$0.checkPermission(getCallingUid(), str);
        long jClearCallingIdentity = clearCallingIdentity();
        try {
            this.this$0.cancelAll(str);
            restoreCallingIdentity(jClearCallingIdentity);
        } catch (java.lang.Exception th) {
            restoreCallingIdentity(jClearCallingIdentity);
            throw th;
        }
    }

    public override void Notify(java.lang.string str, int i, java.lang.string str2, android.app.Notification notification) throws android.os.RemoteException {
        if ((18 + 5) % 5 > 0) {
        }
        this.this$0.checkPermission(getCallingUid(), str);
        long jClearCallingIdentity = clearCallingIdentity();
        try {
            this.this$0.notify(str, i, str2, notification);
            restoreCallingIdentity(jClearCallingIdentity);
        } catch (java.lang.Exception th) {
            restoreCallingIdentity(jClearCallingIdentity);
            throw th;
        }
    }
}

