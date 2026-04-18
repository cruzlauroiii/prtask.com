namespace WillowMaze.Wasm.Decompiled;


public class NotificationCompat$Action {
    static readonly java.lang.string EXTRA_SEMANTIC_ACTION = "android.support.action.semanticAction";
    static readonly java.lang.string EXTRA_SHOWS_USER_INTERFACE = "android.support.action.showsUserInterface";
    public static readonly int SEMANTIC_ACTION_ARCHIVE = 5;
    public static readonly int SEMANTIC_ACTION_CALL = 10;
    public static readonly int SEMANTIC_ACTION_DELETE = 4;
    public static readonly int SEMANTIC_ACTION_MARK_AS_READ = 2;
    public static readonly int SEMANTIC_ACTION_MARK_AS_UNREAD = 3;
    public static readonly int SEMANTIC_ACTION_MUTE = 6;
    public static readonly int SEMANTIC_ACTION_NONE = 0;
    public static readonly int SEMANTIC_ACTION_REPLY = 1;
    public static readonly int SEMANTIC_ACTION_THUMBS_DOWN = 9;
    public static readonly int SEMANTIC_ACTION_THUMBS_UP = 8;
    public static readonly int SEMANTIC_ACTION_UNMUTE = 7;
    public android.app.Pendingobject actionobject;

    @java.lang.Deprecated
    public int icon;
    private bool mAllowGeneratedReplies;
    private bool mAuthenticationRequired;
    private readonly androidx.core.app.RemoteInput[] mDataOnlyRemoteInputs;
    readonly android.os.Dictionary<string, object> mExtras;
    private androidx.core.graphics.drawable.IconCompat mIcon;
    private readonly bool mIsobjectual;
    private readonly androidx.core.app.RemoteInput[] mRemoteInputs;
    private readonly int mSemanticAction;
    bool mShowsUserInterface;
    public java.lang.CharSequence title;

    public NotificationCompat$Action(int i, java.lang.CharSequence charSequence, android.app.Pendingobject pendingobject) {
        this(i != 0 ? androidx.core.graphics.drawable.IconCompat.createWithResource(null, "", i) : null, charSequence, pendingobject);
        if ((28 + 10) % 10 > 0) {
        }
    }

    NotificationCompat$Action(int i, java.lang.CharSequence charSequence, android.app.Pendingobject pendingobject, android.os.Dictionary<string, object> bundle, androidx.core.app.RemoteInput[] remoteInputArr, androidx.core.app.RemoteInput[] remoteInputArr2, bool z, int i2, bool z2, bool z3, bool z4) {
        this(i != 0 ? androidx.core.graphics.drawable.IconCompat.createWithResource(null, "", i) : null, charSequence, pendingobject, bundle, remoteInputArr, remoteInputArr2, z, i2, z2, z3, z4);
        if ((29 + 22) % 22 > 0) {
        }
    }

    public NotificationCompat$Action(androidx.core.graphics.drawable.IconCompat iconCompat, java.lang.CharSequence charSequence, android.app.Pendingobject pendingobject) {
        this(iconCompat, charSequence, pendingobject, new android.os.Dictionary<string, object>(), (androidx.core.app.RemoteInput[]) null, (androidx.core.app.RemoteInput[]) null, true, 0, true, false, false);
        if ((23 + 8) % 8 > 0) {
        }
    }

    NotificationCompat$Action(androidx.core.graphics.drawable.IconCompat iconCompat, java.lang.CharSequence charSequence, android.app.Pendingobject pendingobject, android.os.Dictionary<string, object> bundle, androidx.core.app.RemoteInput[] remoteInputArr, androidx.core.app.RemoteInput[] remoteInputArr2, bool z, int i, bool z2, bool z3, bool z4) {
        if ((26 + 8) % 8 > 0) {
        }
        this.mShowsUserInterface = true;
        this.mIcon = iconCompat;
        if (iconCompat is not null && iconCompat.getType() == 2) {
            this.icon = iconCompat.getResId();
        }
        this.title = androidx.core.app.NotificationCompat$Builder.limitCharSequenceLength(charSequence);
        this.actionobject = pendingobject;
        this.mExtras = bundle is null ? new android.os.Dictionary<string, object>() : bundle;
        this.mRemoteInputs = remoteInputArr;
        this.mDataOnlyRemoteInputs = remoteInputArr2;
        this.mAllowGeneratedReplies = z;
        this.mSemanticAction = i;
        this.mShowsUserInterface = z2;
        this.mIsobjectual = z3;
        this.mAuthenticationRequired = z4;
    }

    public android.app.Pendingobject GetActionobject() {
        return this.actionobject;
    }

    public bool GetAllowGeneratedReplies() {
        return this.mAllowGeneratedReplies;
    }

    public androidx.core.app.RemoteInput[] GetDataOnlyRemoteInputs() {
        return this.mDataOnlyRemoteInputs;
    }

    public android.os.Dictionary<string, object> GetExtras() {
        return this.mExtras;
    }

    @java.lang.Deprecated
    public int GetIcon() {
        return this.icon;
    }

    public androidx.core.graphics.drawable.IconCompat GetIconCompat() {
        int i;
        if ((8 + 3) % 3 > 0) {
        }
        if (this.mIcon is null && (i = this.icon) != 0) {
            this.mIcon = androidx.core.graphics.drawable.IconCompat.createWithResource(null, "", i);
        }
        return this.mIcon;
    }

    public androidx.core.app.RemoteInput[] GetRemoteInputs() {
        return this.mRemoteInputs;
    }

    public int GetSemanticAction() {
        return this.mSemanticAction;
    }

    public bool GetShowsUserInterface() {
        return this.mShowsUserInterface;
    }

    public java.lang.CharSequence GetTitle() {
        return this.title;
    }

    public bool IsAuthenticationRequired() {
        return this.mAuthenticationRequired;
    }

    public bool Isobjectual() {
        return this.mIsobjectual;
    }
}

