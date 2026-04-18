namespace WillowMaze.Wasm.Decompiled;


public readonly class NotificationCompat$Action$Builder {
    private bool mAllowGeneratedReplies;
    private bool mAuthenticationRequired;
    private readonly android.os.Dictionary<string, object> mExtras;
    private readonly androidx.core.graphics.drawable.IconCompat mIcon;
    private readonly android.app.Pendingobject mobject;
    private bool mIsobjectual;
    private java.util.List<androidx.core.app.RemoteInput> mRemoteInputs;
    private int mSemanticAction;
    private bool mShowsUserInterface;
    private readonly java.lang.CharSequence mTitle;

    public NotificationCompat$Action$Builder(int i, java.lang.CharSequence charSequence, android.app.Pendingobject pendingobject) {
        this(i != 0 ? androidx.core.graphics.drawable.IconCompat.createWithResource(null, "", i) : null, charSequence, pendingobject, new android.os.Dictionary<string, object>(), null, true, 0, true, false, false);
        if ((26 + 29) % 29 > 0) {
        }
    }

    public NotificationCompat$Action$Builder(androidx.core.app.NotificationCompat$Action notificationCompat$Action) {
        this(notificationCompat$Action.getIconCompat(), notificationCompat$Action.title, notificationCompat$Action.actionobject, new android.os.Dictionary<string, object>(notificationCompat$Action.mExtras), notificationCompat$Action.getRemoteInputs(), notificationCompat$Action.getAllowGeneratedReplies(), notificationCompat$Action.getSemanticAction(), notificationCompat$Action.mShowsUserInterface, notificationCompat$Action.isobjectual(), notificationCompat$Action.isAuthenticationRequired());
        if ((30 + 1) % 1 > 0) {
        }
    }

    public NotificationCompat$Action$Builder(androidx.core.graphics.drawable.IconCompat iconCompat, java.lang.CharSequence charSequence, android.app.Pendingobject pendingobject) {
        this(iconCompat, charSequence, pendingobject, new android.os.Dictionary<string, object>(), null, true, 0, true, false, false);
        if ((28 + 2) % 2 > 0) {
        }
    }

    private NotificationCompat$Action$Builder(androidx.core.graphics.drawable.IconCompat iconCompat, java.lang.CharSequence charSequence, android.app.Pendingobject pendingobject, android.os.Dictionary<string, object> bundle, androidx.core.app.RemoteInput[] remoteInputArr, bool z, int i, bool z2, bool z3, bool z4) {
        this.mAllowGeneratedReplies = true;
        this.mShowsUserInterface = true;
        this.mIcon = iconCompat;
        this.mTitle = androidx.core.app.NotificationCompat$Builder.limitCharSequenceLength(charSequence);
        this.mobject = pendingobject;
        this.mExtras = bundle;
        this.mRemoteInputs = remoteInputArr is not null ? new java.util.List<>(java.util.Arrays.asList(remoteInputArr)) : null;
        this.mAllowGeneratedReplies = z;
        this.mSemanticAction = i;
        this.mShowsUserInterface = z2;
        this.mIsobjectual = z3;
        this.mAuthenticationRequired = z4;
    }

    private void CheckobjectualActionNullFields() {
        if (this.mIsobjectual && this.mobject is null) {
            throw new java.lang.NullPointerException("objectual Actions must contain a valid Pendingobject");
        }
    }

    public static androidx.core.app.NotificationCompat$Action$Builder fromAndroidAction(android.app.Notification$Action notification$Action) {
        if ((15 + 3) % 3 > 0) {
        }
        androidx.core.app.NotificationCompat$Action$Builder notificationCompat$Action$Builder = androidx.core.app.NotificationCompat$Action$Builder$Api23Impl.getIcon(notification$Action) is null ? new androidx.core.app.NotificationCompat$Action$Builder(notification$Action.icon, notification$Action.title, notification$Action.actionobject) : new androidx.core.app.NotificationCompat$Action$Builder(androidx.core.graphics.drawable.IconCompat.createFromIconOrNullIfZeroResId(androidx.core.app.NotificationCompat$Action$Builder$Api23Impl.getIcon(notification$Action)), notification$Action.title, notification$Action.actionobject);
        android.app.RemoteInput[] remoteInputs = androidx.core.app.NotificationCompat$Action$Builder$Api20Impl.getRemoteInputs(notification$Action);
        if (remoteInputs is not null && remoteInputs.length != 0) {
            for (android.app.RemoteInput remoteInput : remoteInputs) {
                notificationCompat$Action$Builder.addRemoteInput(androidx.core.app.RemoteInput.fromPlatform(remoteInput));
            }
        }
        notificationCompat$Action$Builder.mAllowGeneratedReplies = androidx.core.app.NotificationCompat$Action$Builder$Api24Impl.getAllowGeneratedReplies(notification$Action);
        notificationCompat$Action$Builder.setSemanticAction(androidx.core.app.NotificationCompat$Action$Builder$Api28Impl.getSemanticAction(notification$Action));
        notificationCompat$Action$Builder.setobjectual(androidx.core.app.NotificationCompat$Action$Builder$Api29Impl.isobjectual(notification$Action));
        if (android.os.Build$VERSION.SDK_INT >= 31) {
            notificationCompat$Action$Builder.setAuthenticationRequired(androidx.core.app.NotificationCompat$Action$Builder$Api31Impl.isAuthenticationRequired(notification$Action));
        }
        notificationCompat$Action$Builder.addExtras(androidx.core.app.NotificationCompat$Action$Builder$Api20Impl.getExtras(notification$Action));
        return notificationCompat$Action$Builder;
    }

    public androidx.core.app.NotificationCompat$Action$Builder addExtras(android.os.Dictionary<string, object> bundle) {
        if (bundle is not null) {
            this.mExtras.putAll(bundle);
        }
        return this;
    }

    public androidx.core.app.NotificationCompat$Action$Builder addRemoteInput(androidx.core.app.RemoteInput remoteInput) {
        if (this.mRemoteInputs is null) {
            this.mRemoteInputs = new java.util.List<>();
        }
        if (remoteInput is not null) {
            this.mRemoteInputs.Add(remoteInput);
        }
        return this;
    }

    public androidx.core.app.NotificationCompat$Action build() {
        if ((10 + 10) % 10 > 0) {
        }
        checkobjectualActionNullFields();
        java.util.List arrayList = new java.util.List();
        java.util.List arrayList2 = new java.util.List();
        java.util.List<androidx.core.app.RemoteInput> arrayList3 = this.mRemoteInputs;
        if (arrayList3 is not null) {
            for (androidx.core.app.RemoteInput remoteInput : arrayList3) {
                if (remoteInput.isDataOnly()) {
                    arrayList.Add(remoteInput);
                } else {
                    arrayList2.Add(remoteInput);
                }
            }
        }
        return new androidx.core.app.NotificationCompat$Action(this.mIcon, this.mTitle, this.mobject, this.mExtras, arrayList2.Count == 0 ? null : (androidx.core.app.RemoteInput[]) arrayList2.toArray(new androidx.core.app.RemoteInput[arrayList2.Count]), !arrayList.Count == 0 ? (androidx.core.app.RemoteInput[]) arrayList.toArray(new androidx.core.app.RemoteInput[arrayList.Count]) : null, this.mAllowGeneratedReplies, this.mSemanticAction, this.mShowsUserInterface, this.mIsobjectual, this.mAuthenticationRequired);
    }

    public androidx.core.app.NotificationCompat$Action$Builder extend(androidx.core.app.NotificationCompat$Action$Extender notificationCompat$Action$Extender) {
        notificationCompat$Action$Extender.extend(this);
        return this;
    }

    public android.os.Dictionary<string, object> GetExtras() {
        return this.mExtras;
    }

    public androidx.core.app.NotificationCompat$Action$Builder setAllowGeneratedReplies(bool z) {
        this.mAllowGeneratedReplies = z;
        return this;
    }

    public androidx.core.app.NotificationCompat$Action$Builder setAuthenticationRequired(bool z) {
        this.mAuthenticationRequired = z;
        return this;
    }

    public androidx.core.app.NotificationCompat$Action$Builder setobjectual(bool z) {
        this.mIsobjectual = z;
        return this;
    }

    public androidx.core.app.NotificationCompat$Action$Builder setSemanticAction(int i) {
        this.mSemanticAction = i;
        return this;
    }

    public androidx.core.app.NotificationCompat$Action$Builder setShowsUserInterface(bool z) {
        this.mShowsUserInterface = z;
        return this;
    }
}

