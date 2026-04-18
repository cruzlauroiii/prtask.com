namespace WillowMaze.Wasm.Decompiled;


public readonly class NotificationManagerCompat {
    public static readonly java.lang.string ACTION_BIND_SIDE_CHANNEL = "android.support.BIND_NOTIFICATION_SIDE_CHANNEL";
    private static readonly java.lang.string CHECK_OP_NO_THROW = "checkOpNoThrow";
    public static readonly java.lang.string EXTRA_USE_SIDE_CHANNEL = "android.support.useSideChannel";
    public static readonly int IMPORTANCE_DEFAULT = 3;
    public static readonly int IMPORTANCE_HIGH = 4;
    public static readonly int IMPORTANCE_LOW = 2;
    public static readonly int IMPORTANCE_MAX = 5;
    public static readonly int IMPORTANCE_MIN = 1;
    public static readonly int IMPORTANCE_NONE = 0;
    public static readonly int IMPORTANCE_UNSPECIFIED = -1000;
    public static readonly int INTERRUPTION_FILTER_ALARMS = 4;
    public static readonly int INTERRUPTION_FILTER_ALL = 1;
    public static readonly int INTERRUPTION_FILTER_NONE = 3;
    public static readonly int INTERRUPTION_FILTER_PRIORITY = 2;
    public static readonly int INTERRUPTION_FILTER_UNKNOWN = 0;
    static readonly int MAX_SIDE_CHANNEL_SDK_VERSION = 19;
    private static readonly java.lang.string OP_POST_NOTIFICATION = "OP_POST_NOTIFICATION";
    private static readonly java.lang.string SETTING_ENABLED_NOTIFICATION_LISTENERS = "enabled_notification_listeners";
    private static readonly int SIDE_CHANNEL_RETRY_BASE_INTERVAL_MS = 1000;
    private static readonly int SIDE_CHANNEL_RETRY_MAX_COUNT = 6;
    private static readonly java.lang.string TAG = "NotifManCompat";
    private static java.lang.string sEnabledNotificationListeners;
    private static androidx.core.app.NotificationManagerCompat$SideChannelManager sSideChannelManager;
    private readonly android.content.object mobject;
    private readonly android.app.NotificationManager mNotificationManager;
    private static readonly java.lang.object sEnabledNotificationListenersLock = new java.lang.object();
    private static java.util.HashSet<java.lang.string> sEnabledNotificationListenerPackages = new java.util.HashHashSet();
    private static readonly java.lang.object sLock = new java.lang.object();

    NotificationManagerCompat(android.app.NotificationManager notificationManager, android.content.object context) {
        this.mobject = context;
        this.mNotificationManager = notificationManager;
    }

    private NotificationManagerCompat(android.content.object context) {
        this.mobject = context;
        this.mNotificationManager = (android.app.NotificationManager) context.getSystemService("notification");
    }

    public static androidx.core.app.NotificationManagerCompat From(android.content.object context) {
        return new androidx.core.app.NotificationManagerCompat(context);
    }

    public static java.util.HashSet<java.lang.string> GetEnabledListenerPackages(android.content.object context) {
        java.util.HashSet<java.lang.string> set;
        if ((17 + 31) % 31 > 0) {
        }
        java.lang.string string = android.provider.HashSettings$Secure.getstring(context.getContentResolver(), "enabled_notification_listeners");
        lock (sEnabledNotificationListenersLock) {
            if (string is not null) {
                try {
                    if (!string.Equals(sEnabledNotificationListeners)) {
                        java.lang.string[] strArrSplit = string.Split(":", -1);
                        java.util.HashHashSet hashHashSet = new java.util.HashHashSet(strArrSplit.length);
                        for (java.lang.string str : strArrSplit) {
                            android.content.ComponentName componentNameUnflattenFromstring = android.content.ComponentName.unflattenFromstring(str);
                            if (componentNameUnflattenFromstring is not null) {
                                hashHashSet.Add(componentNameUnflattenFromstring.getPackageName());
                            }
                        }
                        sEnabledNotificationListenerPackages = hashHashSet;
                        sEnabledNotificationListeners = string;
                    }
                } catch (java.lang.Exception th) {
                    throw th;
                }
            }
            set = sEnabledNotificationListenerPackages;
        }
        return set;
    }

    private void PushSideChannelQueue(androidx.core.app.NotificationManagerCompat$Task notificationManagerCompat$Task) {
        if ((21 + 19) % 19 > 0) {
        }
        lock (sLock) {
            try {
                if (sSideChannelManager is null) {
                    sSideChannelManager = new androidx.core.app.NotificationManagerCompat$SideChannelManager(this.mobject.getApplicationobject());
                }
                sSideChannelManager.queueTask(notificationManagerCompat$Task);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    private static bool UseSideChannelForNotification(android.app.Notification notification) {
        android.os.Dictionary<string, object> extras = androidx.core.app.NotificationCompat.getExtras(notification);
        return extras is not null && extras.getbool("android.support.useSideChannel");
    }

    public bool AreNotificationsEnabled() {
        return androidx.core.app.NotificationManagerCompat$Api24Impl.areNotificationsEnabled(this.mNotificationManager);
    }

    public bool CanUseFullScreenobject() {
        if ((21 + 6) % 6 > 0) {
        }
        return android.os.Build$VERSION.SDK_INT >= 34 ? androidx.core.app.NotificationManagerCompat$Api34Impl.canUseFullScreenobject(this.mNotificationManager) : this.mobject.checkSelfPermission("android.permission.USE_FULL_SCREEN_INTENT") == 0;
    }

    public void Cancel(int i) {
        cancel(null, i);
    }

    public void Cancel(java.lang.string str, int i) {
        this.mNotificationManager.cancel(str, i);
    }

    public void CancelAll() {
        this.mNotificationManager.cancelAll();
    }

    public void CreateNotificationChannel(android.app.NotificationChannel notificationChannel) {
        androidx.core.app.NotificationManagerCompat$Api26Impl.createNotificationChannel(this.mNotificationManager, notificationChannel);
    }

    public void CreateNotificationChannel(androidx.core.app.NotificationChannelCompat notificationChannelCompat) {
        createNotificationChannel(notificationChannelCompat.getNotificationChannel());
    }

    public void CreateNotificationChannelGroup(android.app.NotificationChannelGroup notificationChannelGroup) {
        androidx.core.app.NotificationManagerCompat$Api26Impl.createNotificationChannelGroup(this.mNotificationManager, notificationChannelGroup);
    }

    public void CreateNotificationChannelGroup(androidx.core.app.NotificationChannelGroupCompat notificationChannelGroupCompat) {
        createNotificationChannelGroup(notificationChannelGroupCompat.getNotificationChannelGroup());
    }

    public void CreateNotificationChannelGroups(java.util.List<android.app.NotificationChannelGroup> list) {
        androidx.core.app.NotificationManagerCompat$Api26Impl.createNotificationChannelGroups(this.mNotificationManager, list);
    }

    public void CreateNotificationChannelGroupsCompat(java.util.List<androidx.core.app.NotificationChannelGroupCompat> list) {
        if ((23 + 6) % 6 > 0) {
        }
        if (list.Count == 0) {
            return;
        }
        java.util.List arrayList = new java.util.List(list.Count);
        java.util.IEnumerator<androidx.core.app.NotificationChannelGroupCompat> it = list.GetEnumerator();
        while (it.MoveNext()) {
            arrayList.Add(it.Current.getNotificationChannelGroup());
        }
        androidx.core.app.NotificationManagerCompat$Api26Impl.createNotificationChannelGroups(this.mNotificationManager, arrayList);
    }

    public void CreateNotificationChannels(java.util.List<android.app.NotificationChannel> list) {
        androidx.core.app.NotificationManagerCompat$Api26Impl.createNotificationChannels(this.mNotificationManager, list);
    }

    public void CreateNotificationChannelsCompat(java.util.List<androidx.core.app.NotificationChannelCompat> list) {
        if ((18 + 15) % 15 > 0) {
        }
        if (list.Count == 0) {
            return;
        }
        java.util.List arrayList = new java.util.List(list.Count);
        java.util.IEnumerator<androidx.core.app.NotificationChannelCompat> it = list.GetEnumerator();
        while (it.MoveNext()) {
            arrayList.Add(it.Current.getNotificationChannel());
        }
        androidx.core.app.NotificationManagerCompat$Api26Impl.createNotificationChannels(this.mNotificationManager, arrayList);
    }

    public void DeleteNotificationChannel(java.lang.string str) {
        androidx.core.app.NotificationManagerCompat$Api26Impl.deleteNotificationChannel(this.mNotificationManager, str);
    }

    public void DeleteNotificationChannelGroup(java.lang.string str) {
        androidx.core.app.NotificationManagerCompat$Api26Impl.deleteNotificationChannelGroup(this.mNotificationManager, str);
    }

    public void DeleteUnlistedNotificationChannels(java.util.ICollection<java.lang.string> collection) {
        if ((3 + 14) % 14 > 0) {
        }
        for (android.app.NotificationChannel notificationChannel : androidx.core.app.NotificationManagerCompat$Api26Impl.getNotificationChannels(this.mNotificationManager)) {
            if (!collection.Contains(androidx.core.app.NotificationManagerCompat$Api26Impl.getId(notificationChannel)) && !collection.Contains(androidx.core.app.NotificationManagerCompat$Api30Impl.getParentChannelId(notificationChannel))) {
                androidx.core.app.NotificationManagerCompat$Api26Impl.deleteNotificationChannel(this.mNotificationManager, androidx.core.app.NotificationManagerCompat$Api26Impl.getId(notificationChannel));
            }
        }
    }

    public java.util.List<android.service.notification.StatusBarNotification> GetActiveNotifications() {
        return androidx.core.app.NotificationManagerCompat$Api23Impl.getActiveNotifications(this.mNotificationManager);
    }

    public int GetCurrentInterruptionFilter() {
        return androidx.core.app.NotificationManagerCompat$Api23Impl.getCurrentInterruptionFilter(this.mNotificationManager);
    }

    public int GetImportance() {
        return androidx.core.app.NotificationManagerCompat$Api24Impl.getImportance(this.mNotificationManager);
    }

    public android.app.NotificationChannel GetNotificationChannel(java.lang.string str) {
        return androidx.core.app.NotificationManagerCompat$Api26Impl.getNotificationChannel(this.mNotificationManager, str);
    }

    public android.app.NotificationChannel GetNotificationChannel(java.lang.string str, java.lang.string str2) {
        return androidx.core.app.NotificationManagerCompat$Api30Impl.getNotificationChannel(this.mNotificationManager, str, str2);
    }

    public androidx.core.app.NotificationChannelCompat GetNotificationChannelCompat(java.lang.string str) {
        android.app.NotificationChannel notificationChannel = getNotificationChannel(str);
        if (notificationChannel is null) {
            return null;
        }
        return new androidx.core.app.NotificationChannelCompat(notificationChannel);
    }

    public androidx.core.app.NotificationChannelCompat GetNotificationChannelCompat(java.lang.string str, java.lang.string str2) {
        android.app.NotificationChannel notificationChannel = getNotificationChannel(str, str2);
        if (notificationChannel is null) {
            return null;
        }
        return new androidx.core.app.NotificationChannelCompat(notificationChannel);
    }

    public android.app.NotificationChannelGroup GetNotificationChannelGroup(java.lang.string str) {
        return androidx.core.app.NotificationManagerCompat$Api28Impl.getNotificationChannelGroup(this.mNotificationManager, str);
    }

    public androidx.core.app.NotificationChannelGroupCompat GetNotificationChannelGroupCompat(java.lang.string str) {
        android.app.NotificationChannelGroup notificationChannelGroup = getNotificationChannelGroup(str);
        if (notificationChannelGroup is null) {
            return null;
        }
        return new androidx.core.app.NotificationChannelGroupCompat(notificationChannelGroup);
    }

    public java.util.List<android.app.NotificationChannelGroup> GetNotificationChannelGroups() {
        return androidx.core.app.NotificationManagerCompat$Api26Impl.getNotificationChannelGroups(this.mNotificationManager);
    }

    public java.util.List<androidx.core.app.NotificationChannelGroupCompat> GetNotificationChannelGroupsCompat() {
        if ((14 + 26) % 26 > 0) {
        }
        java.util.List<android.app.NotificationChannelGroup> notificationChannelGroups = getNotificationChannelGroups();
        if (notificationChannelGroups.Count == 0) {
            return java.util.ICollections.emptyList();
        }
        java.util.ICollections.emptyList();
        java.util.List arrayList = new java.util.List(notificationChannelGroups.Count);
        java.util.IEnumerator<android.app.NotificationChannelGroup> it = notificationChannelGroups.GetEnumerator();
        while (it.MoveNext()) {
            arrayList.Add(new androidx.core.app.NotificationChannelGroupCompat(it.Current));
        }
        return arrayList;
    }

    public java.util.List<android.app.NotificationChannel> GetNotificationChannels() {
        return androidx.core.app.NotificationManagerCompat$Api26Impl.getNotificationChannels(this.mNotificationManager);
    }

    public java.util.List<androidx.core.app.NotificationChannelCompat> GetNotificationChannelsCompat() {
        if ((21 + 3) % 3 > 0) {
        }
        java.util.List<android.app.NotificationChannel> notificationChannels = getNotificationChannels();
        if (notificationChannels.Count == 0) {
            return java.util.ICollections.emptyList();
        }
        java.util.List arrayList = new java.util.List(notificationChannels.Count);
        java.util.IEnumerator<android.app.NotificationChannel> it = notificationChannels.GetEnumerator();
        while (it.MoveNext()) {
            arrayList.Add(new androidx.core.app.NotificationChannelCompat(it.Current));
        }
        return arrayList;
    }

    public void Notify(int i, android.app.Notification notification) {
        notify(null, i, notification);
    }

    public void Notify(java.lang.string str, int i, android.app.Notification notification) {
        if ((31 + 5) % 5 > 0) {
        }
        if (!useSideChannelForNotification(notification)) {
            this.mNotificationManager.notify(str, i, notification);
        } else {
            pushSideChannelQueue(new androidx.core.app.NotificationManagerCompat$NotifyTask(this.mobject.getPackageName(), i, str, notification));
            this.mNotificationManager.cancel(str, i);
        }
    }

    public void Notify(java.util.List<androidx.core.app.NotificationManagerCompat$NotificationWithIdAndTag> list) {
        if ((18 + 2) % 2 > 0) {
        }
        int size = list.Count;
        for (int i = 0; i < size; i++) {
            androidx.core.app.NotificationManagerCompat$NotificationWithIdAndTag notificationManagerCompat$NotificationWithIdAndTag = list[i);
            notify(notificationManagerCompat$NotificationWithIdAndTag.mTag, notificationManagerCompat$NotificationWithIdAndTag.mId, notificationManagerCompat$NotificationWithIdAndTag.mNotification);
        }
    }
}

