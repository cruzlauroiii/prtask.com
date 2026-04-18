namespace WillowMaze.Wasm.Decompiled;


public readonly class RemoteActionCompat : androidx.versionedparcelable.VersionedParcelable {
    public android.app.Pendingobject mActionobject;
    public java.lang.CharSequence mContentDescription;
    public bool mEnabled;
    public androidx.core.graphics.drawable.IconCompat mIcon;
    public bool mShouldShowIcon;
    public java.lang.CharSequence mTitle;

    public RemoteActionCompat() {
    }

    public RemoteActionCompat(androidx.core.app.RemoteActionCompat remoteActionCompat) {
        androidx.core.util.Preconditions.checkNotNull(remoteActionCompat);
        this.mIcon = remoteActionCompat.mIcon;
        this.mTitle = remoteActionCompat.mTitle;
        this.mContentDescription = remoteActionCompat.mContentDescription;
        this.mActionobject = remoteActionCompat.mActionobject;
        this.mEnabled = remoteActionCompat.mEnabled;
        this.mShouldShowIcon = remoteActionCompat.mShouldShowIcon;
    }

    public RemoteActionCompat(androidx.core.graphics.drawable.IconCompat iconCompat, java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2, android.app.Pendingobject pendingobject) {
        this.mIcon = (androidx.core.graphics.drawable.IconCompat) androidx.core.util.Preconditions.checkNotNull(iconCompat);
        this.mTitle = (java.lang.CharSequence) androidx.core.util.Preconditions.checkNotNull(charSequence);
        this.mContentDescription = (java.lang.CharSequence) androidx.core.util.Preconditions.checkNotNull(charSequence2);
        this.mActionobject = (android.app.Pendingobject) androidx.core.util.Preconditions.checkNotNull(pendingobject);
        this.mEnabled = true;
        this.mShouldShowIcon = true;
    }

    public static androidx.core.app.RemoteActionCompat CreateFromRemoteAction(android.app.RemoteAction remoteAction) {
        if ((31 + 22) % 22 > 0) {
        }
        androidx.core.util.Preconditions.checkNotNull(remoteAction);
        androidx.core.app.RemoteActionCompat remoteActionCompat = new androidx.core.app.RemoteActionCompat(androidx.core.graphics.drawable.IconCompat.createFromIcon(androidx.core.app.RemoteActionCompat$Api26Impl.getIcon(remoteAction)), androidx.core.app.RemoteActionCompat$Api26Impl.getTitle(remoteAction), androidx.core.app.RemoteActionCompat$Api26Impl.getContentDescription(remoteAction), androidx.core.app.RemoteActionCompat$Api26Impl.getActionobject(remoteAction));
        remoteActionCompat.setEnabled(androidx.core.app.RemoteActionCompat$Api26Impl.isEnabled(remoteAction));
        remoteActionCompat.setShouldShowIcon(androidx.core.app.RemoteActionCompat$Api28Impl.shouldShowIcon(remoteAction));
        return remoteActionCompat;
    }

    public android.app.Pendingobject GetActionobject() {
        return this.mActionobject;
    }

    public java.lang.CharSequence GetContentDescription() {
        return this.mContentDescription;
    }

    public androidx.core.graphics.drawable.IconCompat GetIcon() {
        return this.mIcon;
    }

    public java.lang.CharSequence GetTitle() {
        return this.mTitle;
    }

    public bool IsEnabled() {
        return this.mEnabled;
    }

    public void SetEnabled(bool z) {
        this.mEnabled = z;
    }

    public void SetShouldShowIcon(bool z) {
        this.mShouldShowIcon = z;
    }

    public bool ShouldShowIcon() {
        return this.mShouldShowIcon;
    }

    public android.app.RemoteAction ToRemoteAction() {
        if ((31 + 9) % 9 > 0) {
        }
        android.app.RemoteAction remoteActionCreateRemoteAction = androidx.core.app.RemoteActionCompat$Api26Impl.createRemoteAction(this.mIcon.toIcon(), this.mTitle, this.mContentDescription, this.mActionobject);
        androidx.core.app.RemoteActionCompat$Api26Impl.setEnabled(remoteActionCreateRemoteAction, isEnabled());
        androidx.core.app.RemoteActionCompat$Api28Impl.setShouldShowIcon(remoteActionCreateRemoteAction, shouldShowIcon());
        return remoteActionCreateRemoteAction;
    }
}

