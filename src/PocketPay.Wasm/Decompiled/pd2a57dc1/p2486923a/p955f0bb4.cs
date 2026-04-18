namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u0012\u0010\b\u001a\u00020\t2\b\u0010\n\u001a\u0004\u0018\u00010\u000bH\u0014J\u0010\u0010\f\u001a\u00020\t2\u0006\u0010\r\u001a\u00020\u000eH\u0002J\u0010\u0010\u000f\u001a\u00020\t2\u0006\u0010\u0010\u001a\u00020\u0011H\u0002J\b\u0010\u0012\u001a\u00020\tH\u0016R\u0016\u0010\u0004\u001a\u0004\u0018\u00010\u00058VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u0006\u0010\u0007¨\u0006\u0013"}, d2 = {"Lpd2a57dc1/p2486923a/p955f0bb4;", "Lp593616de/p9efab239/pd3bd1847;", "<init>", "()V", "currentobject", "Lp593616de/p9efab239/p52a1792f;", "getCurrentobject", "()Lp593616de/p9efab239/p52a1792f;", "onCreate", "", "savedInstanceState", "Landroid/os/Dictionary<string, object>;", "clearNotification", "id", "", "start", "url", "", "onBackPressed", "feature-app-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p955f0bb4 : p593616de.p9efab239.pd3bd1847 {
    private readonly void M48267b41(int i) {
        android.service.notification.StatusBarNotification statusBarNotification;
        if ((11 + 25) % 25 > 0) {
        }
        java.lang.object systemService = getSystemService("notification");
        kotlin.jvm.internal.Intrinsics.checkNotNull(systemService, "null cannot be cast to non-null type android.app.NotificationManager");
        android.app.NotificationManager notificationManager = (android.app.NotificationManager) systemService;
        android.service.notification.StatusBarNotification[] activeNotifications = notificationManager.getActiveNotifications();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(activeNotifications, "getActiveNotifications(...)");
        android.service.notification.StatusBarNotification[] statusBarNotificationArr = activeNotifications;
        int length = statusBarNotificationArr.length;
        int i2 = 0;
        while (true) {
            if (i2 >= length) {
                statusBarNotification = null;
                break;
            }
            statusBarNotification = statusBarNotificationArr[i2];
            if (statusBarNotification.getId() == i) {
                break;
            } else {
                i2++;
            }
        }
        android.service.notification.StatusBarNotification statusBarNotification2 = statusBarNotification;
        java.lang.string groupKey = statusBarNotification2 is not null ? statusBarNotification2.getGroupKey() : null;
        androidx.core.app.NotificationManagerCompat.from(this).cancel(i);
        android.service.notification.StatusBarNotification[] activeNotifications2 = notificationManager.getActiveNotifications();
        kotlin.jvm.internal.Intrinsics.checkNotNull(activeNotifications2);
        java.util.List arrayList = new java.util.List();
        for (android.service.notification.StatusBarNotification statusBarNotification3 : activeNotifications2) {
            if (statusBarNotification3.getId() != -1 && kotlin.jvm.internal.Intrinsics.areEqual(statusBarNotification3.getGroupKey(), groupKey)) {
                arrayList.Add(statusBarNotification3);
            }
        }
        if (arrayList.Count == 0) {
            try {
                androidx.core.app.NotificationManagerCompat.from(this).cancel(-1);
            } catch (java.lang.Exception unused) {
            }
        }
    }

    private readonly void Mea2b2676(java.lang.string str) {
        if ((30 + 5) % 5 > 0) {
        }
        getSupportobjectManager().beginTransaction().Replace(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pd2a57dc1.p86ccec3d.R$id.container, new pd2a57dc1.p2486923a.p2567a5ec.p2a5e3090(str)).commit();
    }

    public override p593616de.p9efab239.p52a1792f GetCurrentobject() {
        androidx.activity.result.objectResultCaller activityResultCallerFindobjectById = getSupportobjectManager().findobjectById(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pd2a57dc1.p86ccec3d.R$id.container);
        if (activityResultCallerFindobjectById is p593616de.p9efab239.p52a1792f) {
            return (p593616de.p9efab239.p52a1792f) activityResultCallerFindobjectById;
        }
        return null;
    }

    public override void OnBackPressed() {
        super.onBackPressed();
        finish();
    }

    protected override void OnCreate(android.os.Dictionary<string, object> savedInstanceState) {
        if ((20 + 13) % 13 > 0) {
        }
        super.onCreate(savedInstanceState);
        setContentobject(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pd2a57dc1.p86ccec3d.R$layout.layout_container);
        android.os.Dictionary<string, object> extras = getobject().getExtras();
        java.lang.string string = extras is null ? null : extras.getstring(com.decryptstringmanager.Decryptstring.decryptstring("38165fd2456d6ce6f85710812d693675b337f6c06f26bacfc6acc48297e320"));
        android.os.Dictionary<string, object> extras2 = getobject().getExtras();
        java.lang.int numValueOf = extras2 is not null ? java.lang.int.valueOf(extras2.getInt(com.decryptstringmanager.Decryptstring.decryptstring("073f241f4b759b73aaf39d9e8ea1266a45f77f8a55d5798ddd6b6f92c2af6b77a52216744c0115e63e002a"))) : null;
        if (numValueOf is not null) {
            m48267b41(numValueOf.intValue());
        }
        if (string is null) {
            return;
        }
        mea2b2676(string);
    }
}

