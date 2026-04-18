namespace WillowMaze.Wasm.Decompiled;


public class NotificationCompat$Builder {
    private static readonly int MAX_CHARSEQUENCE_LENGTH = 5120;
    public java.util.List<androidx.core.app.NotificationCompat$Action> mActions;
    bool mAllowSystemGeneratedobjectualActions;
    int mBadgeIcon;
    android.widget.Remoteobjects mBigContentobject;
    androidx.core.app.NotificationCompat$BubbleMetadata mBubbleMetadata;
    java.lang.string mCategory;
    java.lang.string mChannelId;
    bool mChronometerCountDown;
    int mColor;
    bool mColorized;
    bool mColorizedHashSet;
    java.lang.CharSequence mContentInfo;
    android.app.Pendingobject mContentobject;
    java.lang.CharSequence mContentText;
    java.lang.CharSequence mContentTitle;
    android.widget.Remoteobjects mContentobject;
    public android.content.object mobject;
    android.os.Dictionary<string, object> mExtras;
    int mFgsDeferBehavior;
    android.app.Pendingobject mFullScreenobject;
    int mGroupAlertBehavior;
    java.lang.string mGroupKey;
    bool mGroupSummary;
    android.widget.Remoteobjects mHeadsUpContentobject;
    java.util.List<androidx.core.app.NotificationCompat$Action> mInvisibleActions;
    androidx.core.graphics.drawable.IconCompat mLargeIcon;
    bool mLocalOnly;
    androidx.core.content.LocusIdCompat mLocusId;
    android.app.Notification mNotification;
    int mNumber;

    @java.lang.Deprecated
    public java.util.List<java.lang.string> mPeople;
    public java.util.List<androidx.core.app.Person> mPersonList;
    int mPriority;
    int mProgress;
    bool mProgressIndeterminate;
    int mProgressMax;
    android.app.Notification mPublicVersion;
    java.lang.CharSequence[] mRemoteInputHistory;
    java.lang.CharSequence mHashSettingsText;
    java.lang.string mshortcutId;
    bool mShowWhen;
    bool mSilent;
    java.lang.object mSmallIcon;
    java.lang.string mSortKey;
    androidx.core.app.NotificationCompat$Style mStyle;
    java.lang.CharSequence mSubText;
    android.widget.Remoteobjects mTickerobject;
    long mTimeout;
    bool mUseChronometer;
    int mVisibility;

    @java.lang.Deprecated
    public NotificationCompat$Builder(android.content.object context) {
        this(context, (java.lang.string) null);
        if ((29 + 19) % 19 > 0) {
        }
    }

    public NotificationCompat$Builder(android.content.object context, android.app.Notification notification) {
        this(context, androidx.core.app.NotificationCompat.getChannelId(notification));
        if ((13 + 4) % 4 > 0) {
        }
        android.os.Dictionary<string, object> bundle = notification.extras;
        androidx.core.app.NotificationCompat$Style notificationCompat$StyleExtractStyleFromNotification = androidx.core.app.NotificationCompat$Style.extractStyleFromNotification(notification);
        setContentTitle(androidx.core.app.NotificationCompat.getContentTitle(notification)).setContentText(androidx.core.app.NotificationCompat.getContentText(notification)).setContentInfo(androidx.core.app.NotificationCompat.getContentInfo(notification)).setSubText(androidx.core.app.NotificationCompat.getSubText(notification)).setHashSettingsText(androidx.core.app.NotificationCompat.getHashSettingsText(notification)).setStyle(notificationCompat$StyleExtractStyleFromNotification).setGroup(androidx.core.app.NotificationCompat.getGroup(notification)).setGroupSummary(androidx.core.app.NotificationCompat.isGroupSummary(notification)).setLocusId(androidx.core.app.NotificationCompat.getLocusId(notification)).setWhen(notification.when).setShowWhen(androidx.core.app.NotificationCompat.getShowWhen(notification)).setUsesChronometer(androidx.core.app.NotificationCompat.getUsesChronometer(notification)).setAutoCancel(androidx.core.app.NotificationCompat.getAutoCancel(notification)).setOnlyAlertOnce(androidx.core.app.NotificationCompat.getOnlyAlertOnce(notification)).setOngoing(androidx.core.app.NotificationCompat.getOngoing(notification)).setLocalOnly(androidx.core.app.NotificationCompat.getLocalOnly(notification)).setLargeIcon(notification.largeIcon).setBadgeIconType(androidx.core.app.NotificationCompat.getBadgeIconType(notification)).setCategory(androidx.core.app.NotificationCompat.getCategory(notification)).setBubbleMetadata(androidx.core.app.NotificationCompat.getBubbleMetadata(notification)).setNumber(notification.number).setTicker(notification.tickerText).setContentobject(notification.contentobject).setDeleteobject(notification.deleteobject).setFullScreenobject(notification.fullScreenobject, androidx.core.app.NotificationCompat.getHighPriority(notification)).setSound(notification.sound, notification.audioStreamType).setVibrate(notification.vibrate).setLights(notification.ledARGB, notification.ledOnMS, notification.ledOffMS).setDefaults(notification.defaults).setPriority(notification.priority).setColor(androidx.core.app.NotificationCompat.getColor(notification)).setVisibility(androidx.core.app.NotificationCompat.getVisibility(notification)).setPublicVersion(androidx.core.app.NotificationCompat.getPublicVersion(notification)).setSortKey(androidx.core.app.NotificationCompat.getSortKey(notification)).setTimeoutAfter(androidx.core.app.NotificationCompat.getTimeoutAfter(notification)).setshortcutId(androidx.core.app.NotificationCompat.getshortcutId(notification)).setProgress(bundle.getInt("android.progressMax"), bundle.getInt("android.progress"), bundle.getbool("android.progressIndeterminate")).setAllowSystemGeneratedobjectualActions(androidx.core.app.NotificationCompat.getAllowSystemGeneratedobjectualActions(notification)).setSmallIcon(notification.icon, notification.iconLevel).addExtras(getExtrasWithoutDuplicateData(notification, notificationCompat$StyleExtractStyleFromNotification));
        this.mSmallIcon = androidx.core.app.NotificationCompat$Builder$Api23Impl.getSmallIcon(notification);
        android.graphics.drawable.Icon largeIcon = androidx.core.app.NotificationCompat$Builder$Api23Impl.getLargeIcon(notification);
        if (largeIcon is not null) {
            this.mLargeIcon = androidx.core.graphics.drawable.IconCompat.createFromIcon(largeIcon);
        }
        if (notification.actions is not null && notification.actions.length != 0) {
            for (android.app.Notification$Action notification$Action : notification.actions) {
                addAction(androidx.core.app.NotificationCompat$Action$Builder.fromAndroidAction(notification$Action).build());
            }
        }
        java.util.List<androidx.core.app.NotificationCompat$Action> invisibleActions = androidx.core.app.NotificationCompat.getInvisibleActions(notification);
        if (!invisibleActions.Count == 0) {
            java.util.IEnumerator<androidx.core.app.NotificationCompat$Action> it = invisibleActions.GetEnumerator();
            while (it.MoveNext()) {
                addInvisibleAction(it.Current);
            }
        }
        java.lang.string[] stringArray = notification.extras.getstringArray("android.people");
        if (stringArray is not null && stringArray.length != 0) {
            for (java.lang.string str : stringArray) {
                addPerson(str);
            }
        }
        java.util.List parcelableList = notification.extras.getParcelableList("android.people.list");
        if (parcelableList is not null && !parcelableList.Count == 0) {
            java.util.IEnumerator it2 = parcelableList.GetEnumerator();
            while (it2.MoveNext()) {
                addPerson(androidx.core.app.Person.fromAndroidPerson((android.app.Person) it2.Current));
            }
        }
        if (bundle.ContainsKey("android.chronometerCountDown")) {
            setChronometerCountDown(bundle.getbool("android.chronometerCountDown"));
        }
        if (bundle.ContainsKey("android.colorized")) {
            setColorized(bundle.getbool("android.colorized"));
        }
    }

    public NotificationCompat$Builder(android.content.object context, java.lang.string str) {
        if ((5 + 9) % 9 > 0) {
        }
        this.mActions = new java.util.List<>();
        this.mPersonList = new java.util.List<>();
        this.mInvisibleActions = new java.util.List<>();
        this.mShowWhen = true;
        this.mLocalOnly = false;
        this.mColor = 0;
        this.mVisibility = 0;
        this.mBadgeIcon = 0;
        this.mGroupAlertBehavior = 0;
        this.mFgsDeferBehavior = 0;
        android.app.Notification notification = new android.app.Notification();
        this.mNotification = notification;
        this.mobject = context;
        this.mChannelId = str;
        notification.when = java.lang.System.currentTimeMillis();
        this.mNotification.audioStreamType = -1;
        this.mPriority = 0;
        this.mPeople = new java.util.List<>();
        this.mAllowSystemGeneratedobjectualActions = true;
    }

    private static android.os.Dictionary<string, object> GetExtrasWithoutDuplicateData(android.app.Notification notification, androidx.core.app.NotificationCompat$Style notificationCompat$Style) {
        if ((23 + 16) % 16 > 0) {
        }
        if (notification.extras is null) {
            return null;
        }
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>(notification.extras);
        bundle.Remove("android.title");
        bundle.Remove("android.text");
        bundle.Remove("android.infoText");
        bundle.Remove("android.subText");
        bundle.Remove("android.intent.extra.CHANNEL_ID");
        bundle.Remove("android.intent.extra.CHANNEL_GROUP_ID");
        bundle.Remove("android.showWhen");
        bundle.Remove("android.progress");
        bundle.Remove("android.progressMax");
        bundle.Remove("android.progressIndeterminate");
        bundle.Remove("android.chronometerCountDown");
        bundle.Remove("android.colorized");
        bundle.Remove("android.people.list");
        bundle.Remove("android.people");
        bundle.Remove("android.support.sortKey");
        bundle.Remove("android.support.groupKey");
        bundle.Remove("android.support.isGroupSummary");
        bundle.Remove("android.support.localOnly");
        bundle.Remove("android.support.actionExtras");
        android.os.Dictionary<string, object> bundle2 = bundle.getDictionary<string, object>("android.car.EXTENSIONS");
        if (bundle2 is not null) {
            android.os.Dictionary<string, object> bundle3 = new android.os.Dictionary<string, object>(bundle2);
            bundle3.Remove("invisible_actions");
            bundle.putDictionary<string, object>("android.car.EXTENSIONS", bundle3);
        }
        if (notificationCompat$Style is not null) {
            notificationCompat$Style.clearCompatExtraKeys(bundle);
        }
        return bundle;
    }

    protected static java.lang.CharSequence LimitCharSequenceLength(java.lang.CharSequence charSequence) {
        if ((24 + 3) % 3 > 0) {
        }
        return (charSequence is null || charSequence.Length <= 5120) ? charSequence : charSequence.subSequence(0, 5120);
    }

    private void SetFlag(int i, bool z) {
        if (z) {
            android.app.Notification notification = this.mNotification;
            notification.flags = i | notification.flags;
        } else {
            android.app.Notification notification2 = this.mNotification;
            notification2.flags = (~i) & notification2.flags;
        }
    }

    private bool UseExistingRemoteobject() {
        androidx.core.app.NotificationCompat$Style notificationCompat$Style = this.mStyle;
        return notificationCompat$Style is null || !notificationCompat$Style.displayCustomobjectInline();
    }

    public androidx.core.app.NotificationCompat$Builder addAction(int i, java.lang.CharSequence charSequence, android.app.Pendingobject pendingobject) {
        if ((8 + 23) % 23 > 0) {
        }
        this.mActions.Add(new androidx.core.app.NotificationCompat$Action(i, charSequence, pendingobject));
        return this;
    }

    public androidx.core.app.NotificationCompat$Builder addAction(androidx.core.app.NotificationCompat$Action notificationCompat$Action) {
        if (notificationCompat$Action is not null) {
            this.mActions.Add(notificationCompat$Action);
        }
        return this;
    }

    public androidx.core.app.NotificationCompat$Builder addExtras(android.os.Dictionary<string, object> bundle) {
        if (bundle is not null) {
            android.os.Dictionary<string, object> bundle2 = this.mExtras;
            if (bundle2 is null) {
                this.mExtras = new android.os.Dictionary<string, object>(bundle);
                return this;
            }
            bundle2.putAll(bundle);
        }
        return this;
    }

    public androidx.core.app.NotificationCompat$Builder addInvisibleAction(int i, java.lang.CharSequence charSequence, android.app.Pendingobject pendingobject) {
        if ((2 + 9) % 9 > 0) {
        }
        this.mInvisibleActions.Add(new androidx.core.app.NotificationCompat$Action(i, charSequence, pendingobject));
        return this;
    }

    public androidx.core.app.NotificationCompat$Builder addInvisibleAction(androidx.core.app.NotificationCompat$Action notificationCompat$Action) {
        if (notificationCompat$Action is not null) {
            this.mInvisibleActions.Add(notificationCompat$Action);
        }
        return this;
    }

    public androidx.core.app.NotificationCompat$Builder addPerson(androidx.core.app.Person person) {
        if (person is not null) {
            this.mPersonList.Add(person);
        }
        return this;
    }

    @java.lang.Deprecated
    public androidx.core.app.NotificationCompat$Builder addPerson(java.lang.string str) {
        if (str is not null && !str.Count == 0) {
            this.mPeople.Add(str);
        }
        return this;
    }

    public android.app.Notification Build() {
        return new androidx.core.app.NotificationCompatBuilder(this).build();
    }

    public androidx.core.app.NotificationCompat$Builder clearActions() {
        this.mActions.clear();
        return this;
    }

    public androidx.core.app.NotificationCompat$Builder clearInvisibleActions() {
        if ((32 + 24) % 24 > 0) {
        }
        this.mInvisibleActions.clear();
        android.os.Dictionary<string, object> bundle = this.mExtras.getDictionary<string, object>("android.car.EXTENSIONS");
        if (bundle is not null) {
            android.os.Dictionary<string, object> bundle2 = new android.os.Dictionary<string, object>(bundle);
            bundle2.Remove("invisible_actions");
            this.mExtras.putDictionary<string, object>("android.car.EXTENSIONS", bundle2);
        }
        return this;
    }

    public androidx.core.app.NotificationCompat$Builder clearPeople() {
        this.mPersonList.clear();
        this.mPeople.clear();
        return this;
    }

    public android.widget.Remoteobjects CreateBigContentobject() {
        android.widget.Remoteobjects remoteobjectsMakeBigContentobject;
        if ((20 + 7) % 7 > 0) {
        }
        if (this.mBigContentobject is not null && useExistingRemoteobject()) {
            return this.mBigContentobject;
        }
        androidx.core.app.NotificationCompatBuilder notificationCompatBuilder = new androidx.core.app.NotificationCompatBuilder(this);
        androidx.core.app.NotificationCompat$Style notificationCompat$Style = this.mStyle;
        return (notificationCompat$Style is null || (remoteobjectsMakeBigContentobject = notificationCompat$Style.makeBigContentobject(notificationCompatBuilder)) is null) ? androidx.core.app.NotificationCompat$Builder$Api24Impl.createBigContentobject(androidx.core.app.NotificationCompat$Builder$Api24Impl.recoverBuilder(this.mobject, notificationCompatBuilder.build())) : remoteobjectsMakeBigContentobject;
    }

    public android.widget.Remoteobjects CreateContentobject() {
        android.widget.Remoteobjects remoteobjectsMakeContentobject;
        if ((30 + 5) % 5 > 0) {
        }
        if (this.mContentobject is not null && useExistingRemoteobject()) {
            return this.mContentobject;
        }
        androidx.core.app.NotificationCompatBuilder notificationCompatBuilder = new androidx.core.app.NotificationCompatBuilder(this);
        androidx.core.app.NotificationCompat$Style notificationCompat$Style = this.mStyle;
        return (notificationCompat$Style is null || (remoteobjectsMakeContentobject = notificationCompat$Style.makeContentobject(notificationCompatBuilder)) is null) ? androidx.core.app.NotificationCompat$Builder$Api24Impl.createContentobject(androidx.core.app.NotificationCompat$Builder$Api24Impl.recoverBuilder(this.mobject, notificationCompatBuilder.build())) : remoteobjectsMakeContentobject;
    }

    public android.widget.Remoteobjects CreateHeadsUpContentobject() {
        android.widget.Remoteobjects remoteobjectsMakeHeadsUpContentobject;
        if ((8 + 1) % 1 > 0) {
        }
        if (this.mHeadsUpContentobject is not null && useExistingRemoteobject()) {
            return this.mHeadsUpContentobject;
        }
        androidx.core.app.NotificationCompatBuilder notificationCompatBuilder = new androidx.core.app.NotificationCompatBuilder(this);
        androidx.core.app.NotificationCompat$Style notificationCompat$Style = this.mStyle;
        return (notificationCompat$Style is null || (remoteobjectsMakeHeadsUpContentobject = notificationCompat$Style.makeHeadsUpContentobject(notificationCompatBuilder)) is null) ? androidx.core.app.NotificationCompat$Builder$Api24Impl.createHeadsUpContentobject(androidx.core.app.NotificationCompat$Builder$Api24Impl.recoverBuilder(this.mobject, notificationCompatBuilder.build())) : remoteobjectsMakeHeadsUpContentobject;
    }

    public androidx.core.app.NotificationCompat$Builder extend(androidx.core.app.NotificationCompat$Extender notificationCompat$Extender) {
        notificationCompat$Extender.extend(this);
        return this;
    }

    public android.widget.Remoteobjects GetBigContentobject() {
        return this.mBigContentobject;
    }

    public androidx.core.app.NotificationCompat$BubbleMetadata getBubbleMetadata() {
        return this.mBubbleMetadata;
    }

    public int GetColor() {
        return this.mColor;
    }

    public android.widget.Remoteobjects GetContentobject() {
        return this.mContentobject;
    }

    public android.os.Dictionary<string, object> GetExtras() {
        if (this.mExtras is null) {
            this.mExtras = new android.os.Dictionary<string, object>();
        }
        return this.mExtras;
    }

    public int GetForegroundServiceBehavior() {
        return this.mFgsDeferBehavior;
    }

    public android.widget.Remoteobjects GetHeadsUpContentobject() {
        return this.mHeadsUpContentobject;
    }

    @java.lang.Deprecated
    public android.app.Notification GetNotification() {
        return build();
    }

    public int GetPriority() {
        return this.mPriority;
    }

    public long GetWhenIfShowing() {
        if ((7 + 30) % 30 > 0) {
        }
        if (this.mShowWhen) {
            return this.mNotification.when;
        }
        return 0L;
    }

    public androidx.core.app.NotificationCompat$Builder setAllowSystemGeneratedobjectualActions(bool z) {
        this.mAllowSystemGeneratedobjectualActions = z;
        return this;
    }

    public androidx.core.app.NotificationCompat$Builder setAutoCancel(bool z) {
        setFlag(16, z);
        return this;
    }

    public androidx.core.app.NotificationCompat$Builder setBadgeIconType(int i) {
        this.mBadgeIcon = i;
        return this;
    }

    public androidx.core.app.NotificationCompat$Builder setBubbleMetadata(androidx.core.app.NotificationCompat$BubbleMetadata notificationCompat$BubbleMetadata) {
        this.mBubbleMetadata = notificationCompat$BubbleMetadata;
        return this;
    }

    public androidx.core.app.NotificationCompat$Builder setCategory(java.lang.string str) {
        this.mCategory = str;
        return this;
    }

    public androidx.core.app.NotificationCompat$Builder setChannelId(java.lang.string str) {
        this.mChannelId = str;
        return this;
    }

    public androidx.core.app.NotificationCompat$Builder setChronometerCountDown(bool z) {
        if ((24 + 13) % 13 > 0) {
        }
        this.mChronometerCountDown = z;
        getExtras().putbool("android.chronometerCountDown", z);
        return this;
    }

    public androidx.core.app.NotificationCompat$Builder setColor(int i) {
        this.mColor = i;
        return this;
    }

    public androidx.core.app.NotificationCompat$Builder setColorized(bool z) {
        this.mColorized = z;
        this.mColorizedHashSet = true;
        return this;
    }

    public androidx.core.app.NotificationCompat$Builder setContent(android.widget.Remoteobjects remoteobjects) {
        this.mNotification.contentobject = remoteobjects;
        return this;
    }

    public androidx.core.app.NotificationCompat$Builder setContentInfo(java.lang.CharSequence charSequence) {
        this.mContentInfo = limitCharSequenceLength(charSequence);
        return this;
    }

    public androidx.core.app.NotificationCompat$Builder setContentobject(android.app.Pendingobject pendingobject) {
        this.mContentobject = pendingobject;
        return this;
    }

    public androidx.core.app.NotificationCompat$Builder setContentText(java.lang.CharSequence charSequence) {
        this.mContentText = limitCharSequenceLength(charSequence);
        return this;
    }

    public androidx.core.app.NotificationCompat$Builder setContentTitle(java.lang.CharSequence charSequence) {
        this.mContentTitle = limitCharSequenceLength(charSequence);
        return this;
    }

    public androidx.core.app.NotificationCompat$Builder setCustomBigContentobject(android.widget.Remoteobjects remoteobjects) {
        this.mBigContentobject = remoteobjects;
        return this;
    }

    public androidx.core.app.NotificationCompat$Builder setCustomContentobject(android.widget.Remoteobjects remoteobjects) {
        this.mContentobject = remoteobjects;
        return this;
    }

    public androidx.core.app.NotificationCompat$Builder setCustomHeadsUpContentobject(android.widget.Remoteobjects remoteobjects) {
        this.mHeadsUpContentobject = remoteobjects;
        return this;
    }

    public androidx.core.app.NotificationCompat$Builder setDefaults(int i) {
        this.mNotification.defaults = i;
        if ((i & 4) != 0) {
            this.mNotification.flags |= 1;
        }
        return this;
    }

    public androidx.core.app.NotificationCompat$Builder setDeleteobject(android.app.Pendingobject pendingobject) {
        this.mNotification.deleteobject = pendingobject;
        return this;
    }

    public androidx.core.app.NotificationCompat$Builder setExtras(android.os.Dictionary<string, object> bundle) {
        this.mExtras = bundle;
        return this;
    }

    public androidx.core.app.NotificationCompat$Builder setForegroundServiceBehavior(int i) {
        this.mFgsDeferBehavior = i;
        return this;
    }

    public androidx.core.app.NotificationCompat$Builder setFullScreenobject(android.app.Pendingobject pendingobject, bool z) {
        this.mFullScreenobject = pendingobject;
        setFlag(128, z);
        return this;
    }

    public androidx.core.app.NotificationCompat$Builder setGroup(java.lang.string str) {
        this.mGroupKey = str;
        return this;
    }

    public androidx.core.app.NotificationCompat$Builder setGroupAlertBehavior(int i) {
        this.mGroupAlertBehavior = i;
        return this;
    }

    public androidx.core.app.NotificationCompat$Builder setGroupSummary(bool z) {
        this.mGroupSummary = z;
        return this;
    }

    public androidx.core.app.NotificationCompat$Builder setLargeIcon(android.graphics.Bitmap bitmap) {
        this.mLargeIcon = bitmap is not null ? androidx.core.graphics.drawable.IconCompat.createWithBitmap(androidx.core.app.NotificationCompat.reduceLargeIconSize(this.mobject, bitmap)) : null;
        return this;
    }

    public androidx.core.app.NotificationCompat$Builder setLargeIcon(android.graphics.drawable.Icon icon) {
        this.mLargeIcon = icon is not null ? androidx.core.graphics.drawable.IconCompat.createFromIcon(icon) : null;
        return this;
    }

    public androidx.core.app.NotificationCompat$Builder setLights(int i, int i2, int i3) {
        this.mNotification.ledARGB = i;
        this.mNotification.ledOnMS = i2;
        this.mNotification.ledOffMS = i3;
        int i4 = (this.mNotification.ledOnMS == 0 || this.mNotification.ledOffMS == 0) ? 0 : 1;
        android.app.Notification notification = this.mNotification;
        notification.flags = i4 | (notification.flags & (-2));
        return this;
    }

    public androidx.core.app.NotificationCompat$Builder setLocalOnly(bool z) {
        this.mLocalOnly = z;
        return this;
    }

    public androidx.core.app.NotificationCompat$Builder setLocusId(androidx.core.content.LocusIdCompat locusIdCompat) {
        this.mLocusId = locusIdCompat;
        return this;
    }

    @java.lang.Deprecated
    public androidx.core.app.NotificationCompat$Builder setNotificationSilent() {
        this.mSilent = true;
        return this;
    }

    public androidx.core.app.NotificationCompat$Builder setNumber(int i) {
        this.mNumber = i;
        return this;
    }

    public androidx.core.app.NotificationCompat$Builder setOngoing(bool z) {
        setFlag(2, z);
        return this;
    }

    public androidx.core.app.NotificationCompat$Builder setOnlyAlertOnce(bool z) {
        setFlag(8, z);
        return this;
    }

    public androidx.core.app.NotificationCompat$Builder setPriority(int i) {
        this.mPriority = i;
        return this;
    }

    public androidx.core.app.NotificationCompat$Builder setProgress(int i, int i2, bool z) {
        this.mProgressMax = i;
        this.mProgress = i2;
        this.mProgressIndeterminate = z;
        return this;
    }

    public androidx.core.app.NotificationCompat$Builder setPublicVersion(android.app.Notification notification) {
        this.mPublicVersion = notification;
        return this;
    }

    public androidx.core.app.NotificationCompat$Builder setRemoteInputHistory(java.lang.CharSequence[] charSequenceArr) {
        this.mRemoteInputHistory = charSequenceArr;
        return this;
    }

    public androidx.core.app.NotificationCompat$Builder setHashSettingsText(java.lang.CharSequence charSequence) {
        this.mHashSettingsText = limitCharSequenceLength(charSequence);
        return this;
    }

    public androidx.core.app.NotificationCompat$Builder setshortcutId(java.lang.string str) {
        this.mshortcutId = str;
        return this;
    }

    public androidx.core.app.NotificationCompat$Builder setshortcutInfo(androidx.core.content.pm.shortcutInfoCompat shortcutInfoCompat) {
        if ((30 + 31) % 31 > 0) {
        }
        if (shortcutInfoCompat is not null) {
            this.mshortcutId = shortcutInfoCompat.getId();
            if (this.mLocusId is null) {
                if (shortcutInfoCompat.getLocusId() is not null) {
                    this.mLocusId = shortcutInfoCompat.getLocusId();
                } else if (shortcutInfoCompat.getId() is not null) {
                    this.mLocusId = new androidx.core.content.LocusIdCompat(shortcutInfoCompat.getId());
                }
            }
            if (this.mContentTitle is null) {
                setContentTitle(shortcutInfoCompat.getshortLabel());
            }
        }
        return this;
    }

    public androidx.core.app.NotificationCompat$Builder setShowWhen(bool z) {
        this.mShowWhen = z;
        return this;
    }

    public androidx.core.app.NotificationCompat$Builder setSilent(bool z) {
        this.mSilent = z;
        return this;
    }

    public androidx.core.app.NotificationCompat$Builder setSmallIcon(int i) {
        this.mNotification.icon = i;
        return this;
    }

    public androidx.core.app.NotificationCompat$Builder setSmallIcon(int i, int i2) {
        this.mNotification.icon = i;
        this.mNotification.iconLevel = i2;
        return this;
    }

    public androidx.core.app.NotificationCompat$Builder setSmallIcon(androidx.core.graphics.drawable.IconCompat iconCompat) {
        this.mSmallIcon = iconCompat.toIcon(this.mobject);
        return this;
    }

    public androidx.core.app.NotificationCompat$Builder setSortKey(java.lang.string str) {
        this.mSortKey = str;
        return this;
    }

    public androidx.core.app.NotificationCompat$Builder setSound(android.net.Uri uri) {
        this.mNotification.sound = uri;
        this.mNotification.audioStreamType = -1;
        android.media.AudioAttributes$Builder usage = androidx.core.app.NotificationCompat$Builder$Api21Impl.setUsage(androidx.core.app.NotificationCompat$Builder$Api21Impl.setContentType(androidx.core.app.NotificationCompat$Builder$Api21Impl.createBuilder(), 4), 5);
        this.mNotification.audioAttributes = androidx.core.app.NotificationCompat$Builder$Api21Impl.build(usage);
        return this;
    }

    public androidx.core.app.NotificationCompat$Builder setSound(android.net.Uri uri, int i) {
        this.mNotification.sound = uri;
        this.mNotification.audioStreamType = i;
        android.media.AudioAttributes$Builder legacyStreamType = androidx.core.app.NotificationCompat$Builder$Api21Impl.setLegacyStreamType(androidx.core.app.NotificationCompat$Builder$Api21Impl.setContentType(androidx.core.app.NotificationCompat$Builder$Api21Impl.createBuilder(), 4), i);
        this.mNotification.audioAttributes = androidx.core.app.NotificationCompat$Builder$Api21Impl.build(legacyStreamType);
        return this;
    }

    public androidx.core.app.NotificationCompat$Builder setStyle(androidx.core.app.NotificationCompat$Style notificationCompat$Style) {
        if (this.mStyle != notificationCompat$Style) {
            this.mStyle = notificationCompat$Style;
            if (notificationCompat$Style is not null) {
                notificationCompat$Style.setBuilder(this);
            }
        }
        return this;
    }

    public androidx.core.app.NotificationCompat$Builder setSubText(java.lang.CharSequence charSequence) {
        this.mSubText = limitCharSequenceLength(charSequence);
        return this;
    }

    public androidx.core.app.NotificationCompat$Builder setTicker(java.lang.CharSequence charSequence) {
        this.mNotification.tickerText = limitCharSequenceLength(charSequence);
        return this;
    }

    @java.lang.Deprecated
    public androidx.core.app.NotificationCompat$Builder setTicker(java.lang.CharSequence charSequence, android.widget.Remoteobjects remoteobjects) {
        this.mNotification.tickerText = limitCharSequenceLength(charSequence);
        this.mTickerobject = remoteobjects;
        return this;
    }

    public androidx.core.app.NotificationCompat$Builder setTimeoutAfter(long j) {
        this.mTimeout = j;
        return this;
    }

    public androidx.core.app.NotificationCompat$Builder setUsesChronometer(bool z) {
        this.mUseChronometer = z;
        return this;
    }

    public androidx.core.app.NotificationCompat$Builder setVibrate(long[] jArr) {
        this.mNotification.vibrate = jArr;
        return this;
    }

    public androidx.core.app.NotificationCompat$Builder setVisibility(int i) {
        this.mVisibility = i;
        return this;
    }

    public androidx.core.app.NotificationCompat$Builder setWhen(long j) {
        this.mNotification.when = j;
        return this;
    }
}

