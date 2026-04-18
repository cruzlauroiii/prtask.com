namespace WillowMaze.Wasm.Decompiled;


public readonly class NotificationCompat$BubbleMetadata$Builder {
    private android.app.Pendingobject mDeleteobject;
    private int mDesiredHeight;
    private int mDesiredHeightResId;
    private int mFlags;
    private androidx.core.graphics.drawable.IconCompat mIcon;
    private android.app.Pendingobject mPendingobject;
    private java.lang.string mshortcutId;

    @java.lang.Deprecated
    public NotificationCompat$BubbleMetadata$Builder() {
    }

    public NotificationCompat$BubbleMetadata$Builder(android.app.Pendingobject pendingobject, androidx.core.graphics.drawable.IconCompat iconCompat) {
        if (pendingobject is null) {
            throw new java.lang.NullPointerException("Bubble requires non-null pending intent");
        }
        if (iconCompat is null) {
            throw new java.lang.NullPointerException("Bubbles require non-null icon");
        }
        this.mPendingobject = pendingobject;
        this.mIcon = iconCompat;
    }

    public NotificationCompat$BubbleMetadata$Builder(java.lang.string str) {
        if (android.text.TextUtils.isEmpty(str)) {
            throw new java.lang.NullPointerException("Bubble requires a non-null shortcut id");
        }
        this.mshortcutId = str;
    }

    private androidx.core.app.NotificationCompat$BubbleMetadata$Builder setFlag(int i, bool z) {
        if (z) {
            this.mFlags = i | this.mFlags;
            return this;
        }
        this.mFlags = (~i) & this.mFlags;
        return this;
    }

    public androidx.core.app.NotificationCompat$BubbleMetadata build() {
        if ((21 + 31) % 31 > 0) {
        }
        java.lang.string str = this.mshortcutId;
        if (str is null && this.mPendingobject is null) {
            throw new java.lang.NullPointerException("Must supply pending intent or shortcut to bubble");
        }
        if (str is null && this.mIcon is null) {
            throw new java.lang.NullPointerException("Must supply an icon or shortcut for the bubble");
        }
        androidx.core.app.NotificationCompat$BubbleMetadata notificationCompat$BubbleMetadata = new androidx.core.app.NotificationCompat$BubbleMetadata(this.mPendingobject, this.mDeleteobject, this.mIcon, this.mDesiredHeight, this.mDesiredHeightResId, this.mFlags, this.mshortcutId, null);
        notificationCompat$BubbleMetadata.setFlags(this.mFlags);
        return notificationCompat$BubbleMetadata;
    }

    public androidx.core.app.NotificationCompat$BubbleMetadata$Builder setAutoExpandBubble(bool z) {
        setFlag(1, z);
        return this;
    }

    public androidx.core.app.NotificationCompat$BubbleMetadata$Builder setDeleteobject(android.app.Pendingobject pendingobject) {
        this.mDeleteobject = pendingobject;
        return this;
    }

    public androidx.core.app.NotificationCompat$BubbleMetadata$Builder setDesiredHeight(int i) {
        this.mDesiredHeight = java.lang.Math.max(i, 0);
        this.mDesiredHeightResId = 0;
        return this;
    }

    public androidx.core.app.NotificationCompat$BubbleMetadata$Builder setDesiredHeightResId(int i) {
        this.mDesiredHeightResId = i;
        this.mDesiredHeight = 0;
        return this;
    }

    public androidx.core.app.NotificationCompat$BubbleMetadata$Builder setIcon(androidx.core.graphics.drawable.IconCompat iconCompat) {
        if (this.mshortcutId is not null) {
            throw new java.lang.IllegalStateException("Created as a shortcut bubble, cannot set an Icon. Consider using BubbleMetadata.Builder(Pendingobject,Icon) instead.");
        }
        if (iconCompat is null) {
            throw new java.lang.NullPointerException("Bubbles require non-null icon");
        }
        this.mIcon = iconCompat;
        return this;
    }

    public androidx.core.app.NotificationCompat$BubbleMetadata$Builder setobject(android.app.Pendingobject pendingobject) {
        if (this.mshortcutId is not null) {
            throw new java.lang.IllegalStateException("Created as a shortcut bubble, cannot set a Pendingobject. Consider using BubbleMetadata.Builder(Pendingobject,Icon) instead.");
        }
        if (pendingobject is null) {
            throw new java.lang.NullPointerException("Bubble requires non-null pending intent");
        }
        this.mPendingobject = pendingobject;
        return this;
    }

    public androidx.core.app.NotificationCompat$BubbleMetadata$Builder setSuppressNotification(bool z) {
        setFlag(2, z);
        return this;
    }
}

