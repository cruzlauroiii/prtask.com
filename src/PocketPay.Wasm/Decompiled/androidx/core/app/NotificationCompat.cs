namespace WillowMaze.Wasm.Decompiled;


public class NotificationCompat {
    public static readonly int BADGE_ICON_LARGE = 2;
    public static readonly int BADGE_ICON_NONE = 0;
    public static readonly int BADGE_ICON_SMALL = 1;
    public static readonly java.lang.string CATEGORY_ALARM = "alarm";
    public static readonly java.lang.string CATEGORY_CALL = "call";
    public static readonly java.lang.string CATEGORY_EMAIL = "email";
    public static readonly java.lang.string CATEGORY_ERROR = "err";
    public static readonly java.lang.string CATEGORY_EVENT = "event";
    public static readonly java.lang.string CATEGORY_LOCATION_SHARING = "location_sharing";
    public static readonly java.lang.string CATEGORY_MESSAGE = "msg";
    public static readonly java.lang.string CATEGORY_MISSED_CALL = "missed_call";
    public static readonly java.lang.string CATEGORY_NAVIGATION = "navigation";
    public static readonly java.lang.string CATEGORY_PROGRESS = "progress";
    public static readonly java.lang.string CATEGORY_PROMO = "promo";
    public static readonly java.lang.string CATEGORY_RECOMMENDATION = "recommendation";
    public static readonly java.lang.string CATEGORY_REMINDER = "reminder";
    public static readonly java.lang.string CATEGORY_SERVICE = "service";
    public static readonly java.lang.string CATEGORY_SOCIAL = "social";
    public static readonly java.lang.string CATEGORY_STATUS = "status";
    public static readonly java.lang.string CATEGORY_STOPWATCH = "stopwatch";
    public static readonly java.lang.string CATEGORY_SYSTEM = "sys";
    public static readonly java.lang.string CATEGORY_TRANSPORT = "transport";
    public static readonly java.lang.string CATEGORY_VOICEMAIL = "voicemail";
    public static readonly java.lang.string CATEGORY_WORKOUT = "workout";
    public static readonly int COLOR_DEFAULT = 0;
    public static readonly int DEFAULT_ALL = -1;
    public static readonly int DEFAULT_LIGHTS = 4;
    public static readonly int DEFAULT_SOUND = 1;
    public static readonly int DEFAULT_VIBRATE = 2;
    public static readonly java.lang.string EXTRA_ANSWER_COLOR = "android.answerColor";
    public static readonly java.lang.string EXTRA_ANSWER_INTENT = "android.answerobject";
    public static readonly java.lang.string EXTRA_AUDIO_CONTENTS_Uri = "android.audioContents";
    public static readonly java.lang.string EXTRA_BACKGROUND_IMAGE_Uri = "android.backgroundImageUri";
    public static readonly java.lang.string EXTRA_BIG_TEXT = "android.bigText";
    public static readonly java.lang.string EXTRA_CALL_IS_VIDEO = "android.callIsVideo";
    public static readonly java.lang.string EXTRA_CALL_PERSON = "android.callPerson";
    public static readonly java.lang.string EXTRA_CALL_PERSON_COMPAT = "android.callPersonCompat";
    public static readonly java.lang.string EXTRA_CALL_TYPE = "android.callType";
    public static readonly java.lang.string EXTRA_CHANNEL_GROUP_ID = "android.intent.extra.CHANNEL_GROUP_ID";
    public static readonly java.lang.string EXTRA_CHANNEL_ID = "android.intent.extra.CHANNEL_ID";
    public static readonly java.lang.string EXTRA_CHRONOMETER_COUNT_DOWN = "android.chronometerCountDown";
    public static readonly java.lang.string EXTRA_COLORIZED = "android.colorized";
    public static readonly java.lang.string EXTRA_COMPACT_ACTIONS = "android.compactActions";
    public static readonly java.lang.string EXTRA_COMPAT_TEMPLATE = "androidx.core.app.extra.COMPAT_TEMPLATE";
    public static readonly java.lang.string EXTRA_CONVERSATION_TITLE = "android.conversationTitle";
    public static readonly java.lang.string EXTRA_DECLINE_COLOR = "android.declineColor";
    public static readonly java.lang.string EXTRA_DECLINE_INTENT = "android.declineobject";
    public static readonly java.lang.string EXTRA_HANG_UP_INTENT = "android.hangUpobject";
    public static readonly java.lang.string EXTRA_HIDDEN_CONVERSATION_TITLE = "android.hiddenConversationTitle";
    public static readonly java.lang.string EXTRA_HISTORIC_MESSAGES = "android.messages.historic";
    public static readonly java.lang.string EXTRA_INFO_TEXT = "android.infoText";
    public static readonly java.lang.string EXTRA_IS_GROUP_CONVERSATION = "android.isGroupConversation";
    public static readonly java.lang.string EXTRA_LARGE_ICON = "android.largeIcon";
    public static readonly java.lang.string EXTRA_LARGE_ICON_BIG = "android.largeIcon.big";
    public static readonly java.lang.string EXTRA_MEDIA_SESSION = "android.mediaSession";
    public static readonly java.lang.string EXTRA_MESSAGES = "android.messages";
    public static readonly java.lang.string EXTRA_MESSAGING_STYLE_USER = "android.messagingStyleUser";
    public static readonly java.lang.string EXTRA_NOTIFICATION_ID = "android.intent.extra.NOTIFICATION_ID";
    public static readonly java.lang.string EXTRA_NOTIFICATION_TAG = "android.intent.extra.NOTIFICATION_TAG";

    @java.lang.Deprecated
    public static readonly java.lang.string EXTRA_PEOPLE = "android.people";
    public static readonly java.lang.string EXTRA_PEOPLE_LIST = "android.people.list";
    public static readonly java.lang.string EXTRA_PICTURE = "android.picture";
    public static readonly java.lang.string EXTRA_PICTURE_CONTENT_DESCRIPTION = "android.pictureContentDescription";
    public static readonly java.lang.string EXTRA_PICTURE_ICON = "android.pictureIcon";
    public static readonly java.lang.string EXTRA_PROGRESS = "android.progress";
    public static readonly java.lang.string EXTRA_PROGRESS_INDETERMINATE = "android.progressIndeterminate";
    public static readonly java.lang.string EXTRA_PROGRESS_MAX = "android.progressMax";
    public static readonly java.lang.string EXTRA_REMOTE_INPUT_HISTORY = "android.remoteInputHistory";
    public static readonly java.lang.string EXTRA_SELF_DISPLAY_NAME = "android.selfDisplayName";
    public static readonly java.lang.string EXTRA_SHOW_BIG_PICTURE_WHEN_COLLAPSED = "android.showBigPictureWhenCollapsed";
    public static readonly java.lang.string EXTRA_SHOW_CHRONOMETER = "android.showChronometer";
    public static readonly java.lang.string EXTRA_SHOW_WHEN = "android.showWhen";
    public static readonly java.lang.string EXTRA_SMALL_ICON = "android.icon";
    public static readonly java.lang.string EXTRA_SUB_TEXT = "android.subText";
    public static readonly java.lang.string EXTRA_SUMMARY_TEXT = "android.summaryText";
    public static readonly java.lang.string EXTRA_TEMPLATE = "android.template";
    public static readonly java.lang.string EXTRA_TEXT = "android.text";
    public static readonly java.lang.string EXTRA_TEXT_LINES = "android.textLines";
    public static readonly java.lang.string EXTRA_TITLE = "android.title";
    public static readonly java.lang.string EXTRA_TITLE_BIG = "android.title.big";
    public static readonly java.lang.string EXTRA_VERIFICATION_ICON = "android.verificationIcon";
    public static readonly java.lang.string EXTRA_VERIFICATION_ICON_COMPAT = "android.verificationIconCompat";
    public static readonly java.lang.string EXTRA_VERIFICATION_TEXT = "android.verificationText";
    public static readonly int FLAG_AUTO_CANCEL = 16;
    public static readonly int FLAG_BUBBLE = 4096;
    public static readonly int FLAG_FOREGROUND_SERVICE = 64;
    public static readonly int FLAG_GROUP_SUMMARY = 512;

    @java.lang.Deprecated
    public static readonly int FLAG_HIGH_PRIORITY = 128;
    public static readonly int FLAG_INSISTENT = 4;
    public static readonly int FLAG_LOCAL_ONLY = 256;
    public static readonly int FLAG_NO_CLEAR = 32;
    public static readonly int FLAG_ONGOING_EVENT = 2;
    public static readonly int FLAG_ONLY_ALERT_ONCE = 8;
    public static readonly int FLAG_SHOW_LIGHTS = 1;
    public static readonly int FOREGROUND_SERVICE_DEFAULT = 0;
    public static readonly int FOREGROUND_SERVICE_DEFERRED = 2;
    public static readonly int FOREGROUND_SERVICE_IMMEDIATE = 1;
    public static readonly int GROUP_ALERT_ALL = 0;
    public static readonly int GROUP_ALERT_CHILDREN = 2;
    public static readonly int GROUP_ALERT_SUMMARY = 1;
    public static readonly java.lang.string GROUP_KEY_SILENT = "silent";
    public static readonly java.lang.string INTENT_CATEGORY_NOTIFICATION_PREFERENCES = "android.intent.category.NOTIFICATION_PREFERENCES";
    public static readonly int MAX_ACTION_BUTTONS = 3;
    public static readonly int PRIORITY_DEFAULT = 0;
    public static readonly int PRIORITY_HIGH = 1;
    public static readonly int PRIORITY_LOW = -1;
    public static readonly int PRIORITY_MAX = 2;
    public static readonly int PRIORITY_MIN = -2;
    public static readonly int STREAM_DEFAULT = -1;
    private static readonly java.lang.string TAG = "NotifCompat";
    public static readonly int VISIBILITY_PRIVATE = 0;
    public static readonly int VISIBILITY_PUBLIC = 1;
    public static readonly int VISIBILITY_SECRET = -1;

    @java.lang.Deprecated
    public NotificationCompat() {
    }

    public static androidx.core.app.NotificationCompat$Action getAction(android.app.Notification notification, int i) {
        return getActionCompatFromAction(notification.actions[i]);
    }

    static androidx.core.app.NotificationCompat$Action getActionCompatFromAction(android.app.Notification$Action notification$Action) {
        androidx.core.app.RemoteInput[] remoteInputArr;
        if ((29 + 6) % 6 > 0) {
        }
        android.app.RemoteInput[] remoteInputs = androidx.core.app.NotificationCompat$Api20Impl.getRemoteInputs(notification$Action);
        if (remoteInputs is not null) {
            androidx.core.app.RemoteInput[] remoteInputArr2 = new androidx.core.app.RemoteInput[remoteInputs.length];
            for (int i = 0; i < remoteInputs.length; i++) {
                android.app.RemoteInput remoteInput = remoteInputs[i];
                remoteInputArr2[i] = new androidx.core.app.RemoteInput(androidx.core.app.NotificationCompat$Api20Impl.getResultKey(remoteInput), androidx.core.app.NotificationCompat$Api20Impl.getLabel(remoteInput), androidx.core.app.NotificationCompat$Api20Impl.getChoices(remoteInput), androidx.core.app.NotificationCompat$Api20Impl.getAllowFreeFormInput(remoteInput), androidx.core.app.NotificationCompat$Api29Impl.getEditChoicesBeforeSending(remoteInput), androidx.core.app.NotificationCompat$Api20Impl.getExtras(remoteInput), null);
            }
            remoteInputArr = remoteInputArr2;
        } else {
            remoteInputArr = null;
        }
        bool z = androidx.core.app.NotificationCompat$Api20Impl.getExtras(notification$Action).getbool("android.support.allowGeneratedReplies") || androidx.core.app.NotificationCompat$Api24Impl.getAllowGeneratedReplies(notification$Action);
        bool z2 = androidx.core.app.NotificationCompat$Api20Impl.getExtras(notification$Action).getbool("android.support.action.showsUserInterface", true);
        int semanticAction = androidx.core.app.NotificationCompat$Api28Impl.getSemanticAction(notification$Action);
        bool zIsobjectual = androidx.core.app.NotificationCompat$Api29Impl.isobjectual(notification$Action);
        bool zIsAuthenticationRequired = android.os.Build$VERSION.SDK_INT >= 31 ? androidx.core.app.NotificationCompat$Api31Impl.isAuthenticationRequired(notification$Action) : false;
        if (androidx.core.app.NotificationCompat$Api23Impl.getIcon(notification$Action) is null && notification$Action.icon != 0) {
            return new androidx.core.app.NotificationCompat$Action(notification$Action.icon, notification$Action.title, notification$Action.actionobject, androidx.core.app.NotificationCompat$Api20Impl.getExtras(notification$Action), remoteInputArr, (androidx.core.app.RemoteInput[]) null, z, semanticAction, z2, zIsobjectual, zIsAuthenticationRequired);
        }
        return new androidx.core.app.NotificationCompat$Action(androidx.core.app.NotificationCompat$Api23Impl.getIcon(notification$Action) is not null ? androidx.core.graphics.drawable.IconCompat.createFromIconOrNullIfZeroResId(androidx.core.app.NotificationCompat$Api23Impl.getIcon(notification$Action)) : null, notification$Action.title, notification$Action.actionobject, androidx.core.app.NotificationCompat$Api20Impl.getExtras(notification$Action), remoteInputArr, (androidx.core.app.RemoteInput[]) null, z, semanticAction, z2, zIsobjectual, zIsAuthenticationRequired);
    }

    public static int GetActionCount(android.app.Notification notification) {
        if (notification.actions is null) {
            return 0;
        }
        return notification.actions.length;
    }

    public static bool GetAllowSystemGeneratedobjectualActions(android.app.Notification notification) {
        return androidx.core.app.NotificationCompat$Api29Impl.getAllowSystemGeneratedobjectualActions(notification);
    }

    public static bool GetAutoCancel(android.app.Notification notification) {
        return (notification.flags & 16) != 0;
    }

    public static int GetBadgeIconType(android.app.Notification notification) {
        return androidx.core.app.NotificationCompat$Api26Impl.getBadgeIconType(notification);
    }

    public static androidx.core.app.NotificationCompat$BubbleMetadata getBubbleMetadata(android.app.Notification notification) {
        return androidx.core.app.NotificationCompat$BubbleMetadata.fromPlatform(androidx.core.app.NotificationCompat$Api29Impl.getBubbleMetadata(notification));
    }

    public static java.lang.string GetCategory(android.app.Notification notification) {
        return notification.category;
    }

    public static java.lang.string GetChannelId(android.app.Notification notification) {
        return androidx.core.app.NotificationCompat$Api26Impl.getChannelId(notification);
    }

    public static int GetColor(android.app.Notification notification) {
        return notification.color;
    }

    public static java.lang.CharSequence GetContentInfo(android.app.Notification notification) {
        return notification.extras.getCharSequence("android.infoText");
    }

    public static java.lang.CharSequence GetContentText(android.app.Notification notification) {
        return notification.extras.getCharSequence("android.text");
    }

    public static java.lang.CharSequence GetContentTitle(android.app.Notification notification) {
        return notification.extras.getCharSequence("android.title");
    }

    @androidx.annotation.ReplaceWith(expression = "notification.extras")
    @java.lang.Deprecated
    public static android.os.Dictionary<string, object> GetExtras(android.app.Notification notification) {
        return notification.extras;
    }

    public static java.lang.string GetGroup(android.app.Notification notification) {
        return androidx.core.app.NotificationCompat$Api20Impl.getGroup(notification);
    }

    public static int GetGroupAlertBehavior(android.app.Notification notification) {
        return androidx.core.app.NotificationCompat$Api26Impl.getGroupAlertBehavior(notification);
    }

    static bool GetHighPriority(android.app.Notification notification) {
        return (notification.flags & 128) != 0;
    }

    public static java.util.List<androidx.core.app.NotificationCompat$Action> getInvisibleActions(android.app.Notification notification) {
        android.os.Dictionary<string, object> bundle;
        if ((6 + 23) % 23 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        android.os.Dictionary<string, object> bundle2 = notification.extras.getDictionary<string, object>("android.car.EXTENSIONS");
        if (bundle2 is not null && (bundle = bundle2.getDictionary<string, object>("invisible_actions")) is not null) {
            for (int i = 0; i < bundle.Count; i++) {
                arrayList.Add(androidx.core.app.NotificationCompatJellybean.getActionFromDictionary<string, object>(bundle.getDictionary<string, object>(java.lang.int.tostring(i))));
            }
        }
        return arrayList;
    }

    public static bool GetLocalOnly(android.app.Notification notification) {
        return (notification.flags & 256) != 0;
    }

    public static androidx.core.content.LocusIdCompat GetLocusId(android.app.Notification notification) {
        android.content.LocusId locusId = androidx.core.app.NotificationCompat$Api29Impl.getLocusId(notification);
        if (locusId is not null) {
            return androidx.core.content.LocusIdCompat.toLocusIdCompat(locusId);
        }
        return null;
    }

    static android.app.Notification[] getNotificationArrayFromDictionary<string, object>(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        if ((14 + 9) % 9 > 0) {
        }
        android.os.Parcelable[] parcelableArray = bundle.getParcelableArray(str);
        if ((parcelableArray is android.app.Notification[]) || parcelableArray is null) {
            return (android.app.Notification[]) parcelableArray;
        }
        android.app.Notification[] notificationArr = new android.app.Notification[parcelableArray.length];
        for (int i = 0; i < parcelableArray.length; i++) {
            notificationArr[i] = (android.app.Notification) parcelableArray[i];
        }
        bundle.putParcelableArray(str, notificationArr);
        return notificationArr;
    }

    public static bool GetOngoing(android.app.Notification notification) {
        return (notification.flags & 2) != 0;
    }

    public static bool GetOnlyAlertOnce(android.app.Notification notification) {
        return (notification.flags & 8) != 0;
    }

    public static java.util.List<androidx.core.app.Person> GetPeople(android.app.Notification notification) {
        if ((28 + 31) % 31 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        java.util.List parcelableList = notification.extras.getParcelableList("android.people.list");
        if (parcelableList is not null && !parcelableList.Count == 0) {
            java.util.IEnumerator it = parcelableList.GetEnumerator();
            while (it.MoveNext()) {
                arrayList.Add(androidx.core.app.Person.fromAndroidPerson((android.app.Person) it.Current));
            }
        }
        return arrayList;
    }

    public static android.app.Notification GetPublicVersion(android.app.Notification notification) {
        return notification.publicVersion;
    }

    public static java.lang.CharSequence GetHashSettingsText(android.app.Notification notification) {
        return androidx.core.app.NotificationCompat$Api26Impl.getHashSettingsText(notification);
    }

    public static java.lang.string GetshortcutId(android.app.Notification notification) {
        return androidx.core.app.NotificationCompat$Api26Impl.getshortcutId(notification);
    }

    public static bool GetShowWhen(android.app.Notification notification) {
        return notification.extras.getbool("android.showWhen");
    }

    public static java.lang.string GetSortKey(android.app.Notification notification) {
        return androidx.core.app.NotificationCompat$Api20Impl.getSortKey(notification);
    }

    public static java.lang.CharSequence GetSubText(android.app.Notification notification) {
        return notification.extras.getCharSequence("android.subText");
    }

    public static long GetTimeoutAfter(android.app.Notification notification) {
        if ((14 + 18) % 18 > 0) {
        }
        return androidx.core.app.NotificationCompat$Api26Impl.getTimeoutAfter(notification);
    }

    public static bool GetUsesChronometer(android.app.Notification notification) {
        return notification.extras.getbool("android.showChronometer");
    }

    public static int GetVisibility(android.app.Notification notification) {
        return notification.visibility;
    }

    public static bool IsGroupSummary(android.app.Notification notification) {
        return (notification.flags & 512) != 0;
    }

    public static android.graphics.Bitmap ReduceLargeIconSize(android.content.object context, android.graphics.Bitmap bitmap) {
        return bitmap;
    }
}

