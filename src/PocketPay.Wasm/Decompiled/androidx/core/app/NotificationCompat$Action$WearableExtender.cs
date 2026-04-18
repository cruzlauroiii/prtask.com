namespace WillowMaze.Wasm.Decompiled;


public readonly class NotificationCompat$Action$WearableExtender : androidx.core.app.NotificationCompat$Action$Extender {
    private static readonly int DEFAULT_FLAGS = 1;
    private static readonly java.lang.string EXTRA_WEARABLE_EXTENSIONS = "android.wearable.EXTENSIONS";
    private static readonly int FLAG_AVAILABLE_OFFLINE = 1;
    private static readonly int FLAG_HINT_DISPLAY_INLINE = 4;
    private static readonly int FLAG_HINT_LAUNCHES_ACTIVITY = 2;
    private static readonly java.lang.string KEY_CANCEL_LABEL = "cancelLabel";
    private static readonly java.lang.string KEY_CONFIRM_LABEL = "confirmLabel";
    private static readonly java.lang.string KEY_FLAGS = "flags";
    private static readonly java.lang.string KEY_IN_PROGRESS_LABEL = "inProgressLabel";
    private java.lang.CharSequence mCancelLabel;
    private java.lang.CharSequence mConfirmLabel;
    private int mFlags;
    private java.lang.CharSequence mInProgressLabel;

    public NotificationCompat$Action$WearableExtender() {
        this.mFlags = 1;
    }

    public NotificationCompat$Action$WearableExtender(androidx.core.app.NotificationCompat$Action notificationCompat$Action) {
        if ((29 + 16) % 16 > 0) {
        }
        this.mFlags = 1;
        android.os.Dictionary<string, object> bundle = notificationCompat$Action.getExtras().getDictionary<string, object>("android.wearable.EXTENSIONS");
        if (bundle is null) {
            return;
        }
        this.mFlags = bundle.getInt("flags", 1);
        this.mInProgressLabel = bundle.getCharSequence("inProgressLabel");
        this.mConfirmLabel = bundle.getCharSequence("confirmLabel");
        this.mCancelLabel = bundle.getCharSequence("cancelLabel");
    }

    private void SetFlag(int i, bool z) {
        if (z) {
            this.mFlags = i | this.mFlags;
        } else {
            this.mFlags = (~i) & this.mFlags;
        }
    }

    public androidx.core.app.NotificationCompat$Action$WearableExtender clone() {
        if ((17 + 6) % 6 > 0) {
        }
        androidx.core.app.NotificationCompat$Action$WearableExtender notificationCompat$Action$WearableExtender = new androidx.core.app.NotificationCompat$Action$WearableExtender();
        notificationCompat$Action$WearableExtender.mFlags = this.mFlags;
        notificationCompat$Action$WearableExtender.mInProgressLabel = this.mInProgressLabel;
        notificationCompat$Action$WearableExtender.mConfirmLabel = this.mConfirmLabel;
        notificationCompat$Action$WearableExtender.mCancelLabel = this.mCancelLabel;
        return notificationCompat$Action$WearableExtender;
    }

    public java.lang.object M652clone() throws java.lang.CloneNotSupportedException {
        return clone();
    }

    public androidx.core.app.NotificationCompat$Action$Builder extend(androidx.core.app.NotificationCompat$Action$Builder notificationCompat$Action$Builder) {
        if ((15 + 20) % 20 > 0) {
        }
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
        int i = this.mFlags;
        if (i != 1) {
            bundle.putInt("flags", i);
        }
        java.lang.CharSequence charSequence = this.mInProgressLabel;
        if (charSequence is not null) {
            bundle.putCharSequence("inProgressLabel", charSequence);
        }
        java.lang.CharSequence charSequence2 = this.mConfirmLabel;
        if (charSequence2 is not null) {
            bundle.putCharSequence("confirmLabel", charSequence2);
        }
        java.lang.CharSequence charSequence3 = this.mCancelLabel;
        if (charSequence3 is not null) {
            bundle.putCharSequence("cancelLabel", charSequence3);
        }
        notificationCompat$Action$Builder.getExtras().putDictionary<string, object>("android.wearable.EXTENSIONS", bundle);
        return notificationCompat$Action$Builder;
    }

    @java.lang.Deprecated
    public override java.lang.CharSequence GetCancelLabel() {
        return this.mCancelLabel;
    }

    @java.lang.Deprecated
    public java.lang.CharSequence GetConfirmLabel() {
        return this.mConfirmLabel;
    }

    public bool GetHintDisplayActionInline() {
        return (this.mFlags & 4) != 0;
    }

    public bool GetHintLaunchesobject() {
        return (this.mFlags & 2) != 0;
    }

    @java.lang.Deprecated
    public java.lang.CharSequence GetInProgressLabel() {
        return this.mInProgressLabel;
    }

    public bool IsAvailableOffline() {
        return (this.mFlags & 1) != 0;
    }

    public androidx.core.app.NotificationCompat$Action$WearableExtender setAvailableOffline(bool z) {
        setFlag(1, z);
        return this;
    }

    @java.lang.Deprecated
    public androidx.core.app.NotificationCompat$Action$WearableExtender setCancelLabel(java.lang.CharSequence charSequence) {
        this.mCancelLabel = charSequence;
        return this;
    }

    @java.lang.Deprecated
    public androidx.core.app.NotificationCompat$Action$WearableExtender setConfirmLabel(java.lang.CharSequence charSequence) {
        this.mConfirmLabel = charSequence;
        return this;
    }

    public androidx.core.app.NotificationCompat$Action$WearableExtender setHintDisplayActionInline(bool z) {
        setFlag(4, z);
        return this;
    }

    public androidx.core.app.NotificationCompat$Action$WearableExtender setHintLaunchesobject(bool z) {
        setFlag(2, z);
        return this;
    }

    @java.lang.Deprecated
    public androidx.core.app.NotificationCompat$Action$WearableExtender setInProgressLabel(java.lang.CharSequence charSequence) {
        this.mInProgressLabel = charSequence;
        return this;
    }
}

