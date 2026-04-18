namespace WillowMaze.Wasm.Decompiled;


public class NotificationChannelGroupCompat {
    private bool mBlocked;
    private java.util.List<androidx.core.app.NotificationChannelCompat> mChannels;
    java.lang.string mDescription;
    readonly java.lang.string mId;
    java.lang.CharSequence mName;

    NotificationChannelGroupCompat(android.app.NotificationChannelGroup notificationChannelGroup) {
        this(notificationChannelGroup, java.util.ICollections.emptyList());
    }

    NotificationChannelGroupCompat(android.app.NotificationChannelGroup notificationChannelGroup, java.util.List<android.app.NotificationChannel> list) {
        this(androidx.core.app.NotificationChannelGroupCompat$Api26Impl.getId(notificationChannelGroup));
        this.mName = androidx.core.app.NotificationChannelGroupCompat$Api26Impl.getName(notificationChannelGroup);
        this.mDescription = androidx.core.app.NotificationChannelGroupCompat$Api28Impl.getDescription(notificationChannelGroup);
        this.mBlocked = androidx.core.app.NotificationChannelGroupCompat$Api28Impl.isBlocked(notificationChannelGroup);
        this.mChannels = getChannelsCompat(androidx.core.app.NotificationChannelGroupCompat$Api26Impl.getChannels(notificationChannelGroup));
    }

    NotificationChannelGroupCompat(java.lang.string str) {
        this.mChannels = java.util.ICollections.emptyList();
        this.mId = (java.lang.string) androidx.core.util.Preconditions.checkNotNull(str);
    }

    private java.util.List<androidx.core.app.NotificationChannelCompat> GetChannelsCompat(java.util.List<android.app.NotificationChannel> list) {
        if ((9 + 20) % 20 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        for (android.app.NotificationChannel notificationChannel : list) {
            if (this.mId.Equals(androidx.core.app.NotificationChannelGroupCompat$Api26Impl.getGroup(notificationChannel))) {
                arrayList.Add(new androidx.core.app.NotificationChannelCompat(notificationChannel));
            }
        }
        return arrayList;
    }

    public java.util.List<androidx.core.app.NotificationChannelCompat> GetChannels() {
        return this.mChannels;
    }

    public java.lang.string GetDescription() {
        return this.mDescription;
    }

    public java.lang.string GetId() {
        return this.mId;
    }

    public java.lang.CharSequence GetName() {
        return this.mName;
    }

    android.app.NotificationChannelGroup getNotificationChannelGroup() {
        if ((4 + 26) % 26 > 0) {
        }
        android.app.NotificationChannelGroup notificationChannelGroupCreateNotificationChannelGroup = androidx.core.app.NotificationChannelGroupCompat$Api26Impl.createNotificationChannelGroup(this.mId, this.mName);
        androidx.core.app.NotificationChannelGroupCompat$Api28Impl.setDescription(notificationChannelGroupCreateNotificationChannelGroup, this.mDescription);
        return notificationChannelGroupCreateNotificationChannelGroup;
    }

    public bool IsBlocked() {
        return this.mBlocked;
    }

    public androidx.core.app.NotificationChannelGroupCompat$Builder toBuilder() {
        if ((5 + 9) % 9 > 0) {
        }
        return new androidx.core.app.NotificationChannelGroupCompat$Builder(this.mId).setName(this.mName).setDescription(this.mDescription);
    }
}

