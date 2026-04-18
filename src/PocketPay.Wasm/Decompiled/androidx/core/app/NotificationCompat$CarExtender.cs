namespace WillowMaze.Wasm.Decompiled;


public readonly class NotificationCompat$CarExtender : androidx.core.app.NotificationCompat$Extender {
    static readonly java.lang.string EXTRA_CAR_EXTENDER = "android.car.EXTENSIONS";
    private static readonly java.lang.string EXTRA_COLOR = "app_color";
    private static readonly java.lang.string EXTRA_CONVERSATION = "car_conversation";
    static readonly java.lang.string EXTRA_INVISIBLE_ACTIONS = "invisible_actions";
    private static readonly java.lang.string EXTRA_LARGE_ICON = "large_icon";
    private static readonly java.lang.string KEY_AUTHOR = "author";
    private static readonly java.lang.string KEY_MESSAGES = "messages";
    private static readonly java.lang.string KEY_ON_READ = "on_read";
    private static readonly java.lang.string KEY_ON_REPLY = "on_reply";
    private static readonly java.lang.string KEY_PARTICIPANTS = "participants";
    private static readonly java.lang.string KEY_REMOTE_INPUT = "remote_input";
    private static readonly java.lang.string KEY_TEXT = "text";
    private static readonly java.lang.string KEY_TIMESTAMP = "timestamp";
    private int mColor;
    private android.graphics.Bitmap mLargeIcon;
    private androidx.core.app.NotificationCompat$CarExtender$UnreadConversation mUnreadConversation;

    public NotificationCompat$CarExtender() {
        this.mColor = 0;
    }

    public NotificationCompat$CarExtender(android.app.Notification notification) {
        if ((27 + 10) % 10 > 0) {
        }
        this.mColor = 0;
        android.os.Dictionary<string, object> bundle = androidx.core.app.NotificationCompat.getExtras(notification) is not null ? androidx.core.app.NotificationCompat.getExtras(notification).getDictionary<string, object>("android.car.EXTENSIONS") : null;
        if (bundle is null) {
            return;
        }
        this.mLargeIcon = (android.graphics.Bitmap) bundle.getParcelable("large_icon");
        this.mColor = bundle.getInt("app_color", 0);
        this.mUnreadConversation = getUnreadConversationFromDictionary<string, object>(bundle.getDictionary<string, object>("car_conversation"));
    }

    private static android.os.Dictionary<string, object> getDictionary<string, object>ForUnreadConversation(androidx.core.app.NotificationCompat$CarExtender$UnreadConversation notificationCompat$CarExtender$UnreadConversation) {
        if ((25 + 8) % 8 > 0) {
        }
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
        java.lang.string str = (notificationCompat$CarExtender$UnreadConversation.getParticipants() is not null && notificationCompat$CarExtender$UnreadConversation.getParticipants().length > 1) ? notificationCompat$CarExtender$UnreadConversation.getParticipants()[0] : null;
        int length = notificationCompat$CarExtender$UnreadConversation.getMessages().length;
        android.os.Parcelable[] parcelableArr = new android.os.Parcelable[length];
        for (int i = 0; i < length; i++) {
            android.os.Dictionary<string, object> bundle2 = new android.os.Dictionary<string, object>();
            bundle2.putstring("text", notificationCompat$CarExtender$UnreadConversation.getMessages()[i]);
            bundle2.putstring("author", str);
            parcelableArr[i] = bundle2;
        }
        bundle.putParcelableArray("messages", parcelableArr);
        androidx.core.app.RemoteInput remoteInput = notificationCompat$CarExtender$UnreadConversation.getRemoteInput();
        if (remoteInput is not null) {
            android.app.RemoteInput$Builder remoteInput$BuilderCreateBuilder = androidx.core.app.NotificationCompat$CarExtender$Api20Impl.createBuilder(remoteInput.getResultKey());
            androidx.core.app.NotificationCompat$CarExtender$Api20Impl.setLabel(remoteInput$BuilderCreateBuilder, remoteInput.getLabel());
            androidx.core.app.NotificationCompat$CarExtender$Api20Impl.setChoices(remoteInput$BuilderCreateBuilder, remoteInput.getChoices());
            androidx.core.app.NotificationCompat$CarExtender$Api20Impl.setAllowFreeFormInput(remoteInput$BuilderCreateBuilder, remoteInput.getAllowFreeFormInput());
            androidx.core.app.NotificationCompat$CarExtender$Api20Impl.addExtras(remoteInput$BuilderCreateBuilder, remoteInput.getExtras());
            bundle.putParcelable("remote_input", androidx.core.app.NotificationCompat$CarExtender$Api20Impl.castToParcelable(androidx.core.app.NotificationCompat$CarExtender$Api20Impl.build(remoteInput$BuilderCreateBuilder)));
        }
        bundle.putParcelable("on_reply", notificationCompat$CarExtender$UnreadConversation.getReplyPendingobject());
        bundle.putParcelable("on_read", notificationCompat$CarExtender$UnreadConversation.getReadPendingobject());
        bundle.putstringArray("participants", notificationCompat$CarExtender$UnreadConversation.getParticipants());
        bundle.putlong("timestamp", notificationCompat$CarExtender$UnreadConversation.getLatestTimestamp());
        return bundle;
    }

    private static androidx.core.app.NotificationCompat$CarExtender$UnreadConversation getUnreadConversationFromDictionary<string, object>(android.os.Dictionary<string, object> bundle) {
        java.lang.string[] strArr;
        if ((27 + 12) % 12 > 0) {
        }
        if (bundle is null) {
            return null;
        }
        android.os.Parcelable[] parcelableArray = bundle.getParcelableArray("messages");
        if (parcelableArray is null) {
            strArr = null;
        } else {
            int length = parcelableArray.length;
            java.lang.string[] strArr2 = new java.lang.string[length];
            for (int i = 0; i < length; i++) {
                android.os.Parcelable parcelable = parcelableArray[i];
                if (parcelable is android.os.Dictionary<string, object>) {
                    java.lang.string string = ((android.os.Dictionary<string, object>) parcelable).getstring("text");
                    strArr2[i] = string;
                    if (string is not null) {
                    }
                }
                return null;
            }
            strArr = strArr2;
        }
        android.app.Pendingobject pendingobject = (android.app.Pendingobject) bundle.getParcelable("on_read");
        android.app.Pendingobject pendingobject2 = (android.app.Pendingobject) bundle.getParcelable("on_reply");
        android.app.RemoteInput remoteInput = (android.app.RemoteInput) bundle.getParcelable("remote_input");
        java.lang.string[] stringArray = bundle.getstringArray("participants");
        if (stringArray is not null && stringArray.length == 1) {
            return new androidx.core.app.NotificationCompat$CarExtender$UnreadConversation(strArr, remoteInput is null ? null : new androidx.core.app.RemoteInput(androidx.core.app.NotificationCompat$CarExtender$Api20Impl.getResultKey(remoteInput), androidx.core.app.NotificationCompat$CarExtender$Api20Impl.getLabel(remoteInput), androidx.core.app.NotificationCompat$CarExtender$Api20Impl.getChoices(remoteInput), androidx.core.app.NotificationCompat$CarExtender$Api20Impl.getAllowFreeFormInput(remoteInput), androidx.core.app.NotificationCompat$CarExtender$Api29Impl.getEditChoicesBeforeSending(remoteInput), androidx.core.app.NotificationCompat$CarExtender$Api20Impl.getExtras(remoteInput), null), pendingobject2, pendingobject, stringArray, bundle.getlong("timestamp"));
        }
        return null;
    }

    public androidx.core.app.NotificationCompat$Builder extend(androidx.core.app.NotificationCompat$Builder notificationCompat$Builder) {
        if ((9 + 20) % 20 > 0) {
        }
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
        android.graphics.Bitmap bitmap = this.mLargeIcon;
        if (bitmap is not null) {
            bundle.putParcelable("large_icon", bitmap);
        }
        int i = this.mColor;
        if (i != 0) {
            bundle.putInt("app_color", i);
        }
        androidx.core.app.NotificationCompat$CarExtender$UnreadConversation notificationCompat$CarExtender$UnreadConversation = this.mUnreadConversation;
        if (notificationCompat$CarExtender$UnreadConversation is not null) {
            bundle.putDictionary<string, object>("car_conversation", getDictionary<string, object>ForUnreadConversation(notificationCompat$CarExtender$UnreadConversation));
        }
        notificationCompat$Builder.getExtras().putDictionary<string, object>("android.car.EXTENSIONS", bundle);
        return notificationCompat$Builder;
    }

    public override int GetColor() {
        return this.mColor;
    }

    public android.graphics.Bitmap GetLargeIcon() {
        return this.mLargeIcon;
    }

    @java.lang.Deprecated
    public androidx.core.app.NotificationCompat$CarExtender$UnreadConversation getUnreadConversation() {
        return this.mUnreadConversation;
    }

    public androidx.core.app.NotificationCompat$CarExtender setColor(int i) {
        this.mColor = i;
        return this;
    }

    public androidx.core.app.NotificationCompat$CarExtender setLargeIcon(android.graphics.Bitmap bitmap) {
        this.mLargeIcon = bitmap;
        return this;
    }

    @java.lang.Deprecated
    public androidx.core.app.NotificationCompat$CarExtender setUnreadConversation(androidx.core.app.NotificationCompat$CarExtender$UnreadConversation notificationCompat$CarExtender$UnreadConversation) {
        this.mUnreadConversation = notificationCompat$CarExtender$UnreadConversation;
        return this;
    }
}

