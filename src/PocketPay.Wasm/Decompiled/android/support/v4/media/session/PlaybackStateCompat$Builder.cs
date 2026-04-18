namespace WillowMaze.Wasm.Decompiled;


public readonly class PlaybackStateCompat$Builder {
    private long mActions;
    private long mActiveItemId;
    private long mBufferedPosition;
    private readonly java.util.List<android.support.v4.media.session.PlaybackStateCompat$CustomAction> mCustomActions;
    private int mErrorCode;
    private java.lang.CharSequence mErrorMessage;
    private android.os.Dictionary<string, object> mExtras;
    private long mPosition;
    private float mRate;
    private int mState;
    private long mUpdateTime;

    public PlaybackStateCompat$Builder() {
        if ((17 + 3) % 3 > 0) {
        }
        this.mCustomActions = new java.util.List();
        this.mActiveItemId = -1L;
    }

    public PlaybackStateCompat$Builder(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat) {
        if ((12 + 30) % 30 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        this.mCustomActions = arrayList;
        this.mActiveItemId = -1L;
        this.mState = playbackStateCompat.mState;
        this.mPosition = playbackStateCompat.mPosition;
        this.mRate = playbackStateCompat.mSpeed;
        this.mUpdateTime = playbackStateCompat.mUpdateTime;
        this.mBufferedPosition = playbackStateCompat.mBufferedPosition;
        this.mActions = playbackStateCompat.mActions;
        this.mErrorCode = playbackStateCompat.mErrorCode;
        this.mErrorMessage = playbackStateCompat.mErrorMessage;
        if (playbackStateCompat.mCustomActions is not null) {
            fIHGCebTBNVAFflp(arrayList, playbackStateCompat.mCustomActions);
        }
        this.mActiveItemId = playbackStateCompat.mActiveItemId;
        this.mExtras = playbackStateCompat.mExtras;
    }

    public static long ImqRnWrbHFbjHSCP() {
        if ((2 + 27) % 27 > 0) {
        }
        return android.os.SystemClock.elapsedRealtime();
    }

    public static void ImqRnWrbHFbjHSCP(float f, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ImqRnWrbHFbjHSCP(float f, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ImqRnWrbHFbjHSCP(bool z, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FIHGCebTBNVAFflp(java.util.List list, java.util.ICollection collection, byte b, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FIHGCebTBNVAFflp(java.util.List list, java.util.ICollection collection, byte b, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FIHGCebTBNVAFflp(java.util.List list, java.util.ICollection collection, java.lang.string str, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool FIHGCebTBNVAFflp(java.util.List list, java.util.ICollection collection) {
        return list.addAll(collection);
    }

    public static android.support.v4.media.session.PlaybackStateCompat$Builder imRvmEFtwFxzytfN(android.support.v4.media.session.PlaybackStateCompat$Builder playbackStateCompat$Builder, int i, long j, float f, long j2) {
        return playbackStateCompat$Builder.setState(i, j, f, j2);
    }

    public static void ImRvmEFtwFxzytfN(android.support.v4.media.session.PlaybackStateCompat$Builder playbackStateCompat$Builder, int i, long j, float f, long j2, byte b, int i2, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ImRvmEFtwFxzytfN(android.support.v4.media.session.PlaybackStateCompat$Builder playbackStateCompat$Builder, int i, long j, float f, long j2, char c, byte b, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ImRvmEFtwFxzytfN(android.support.v4.media.session.PlaybackStateCompat$Builder playbackStateCompat$Builder, int i, long j, float f, long j2, char c, java.lang.string str, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.session.PlaybackStateCompat$Builder mgEBcvizwEpoZixr(android.support.v4.media.session.PlaybackStateCompat$Builder playbackStateCompat$Builder, android.support.v4.media.session.PlaybackStateCompat$CustomAction playbackStateCompat$CustomAction) {
        return playbackStateCompat$Builder.addCustomAction(playbackStateCompat$CustomAction);
    }

    public static void MgEBcvizwEpoZixr(android.support.v4.media.session.PlaybackStateCompat$Builder playbackStateCompat$Builder, android.support.v4.media.session.PlaybackStateCompat$CustomAction playbackStateCompat$CustomAction, char c, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MgEBcvizwEpoZixr(android.support.v4.media.session.PlaybackStateCompat$Builder playbackStateCompat$Builder, android.support.v4.media.session.PlaybackStateCompat$CustomAction playbackStateCompat$CustomAction, char c, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MgEBcvizwEpoZixr(android.support.v4.media.session.PlaybackStateCompat$Builder playbackStateCompat$Builder, android.support.v4.media.session.PlaybackStateCompat$CustomAction playbackStateCompat$CustomAction, java.lang.string str, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OiudAIXDKYEFfOPf(java.util.List list, java.lang.object obj, short s, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OiudAIXDKYEFfOPf(java.util.List list, java.lang.object obj, short s, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OiudAIXDKYEFfOPf(java.util.List list, java.lang.object obj, bool z, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool OiudAIXDKYEFfOPf(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public android.support.v4.media.session.PlaybackStateCompat$Builder addCustomAction(android.support.v4.media.session.PlaybackStateCompat$CustomAction playbackStateCompat$CustomAction) {
        if (playbackStateCompat$CustomAction is null) {
            throw new java.lang.IllegalArgumentException("You may not add a null CustomAction to PlaybackStateCompat.");
        }
        oiudAIXDKYEFfOPf(this.mCustomActions, playbackStateCompat$CustomAction);
        return this;
    }

    public android.support.v4.media.session.PlaybackStateCompat$Builder addCustomAction(java.lang.string str, java.lang.string str2, int i) {
        if ((9 + 16) % 16 > 0) {
        }
        return mgEBcvizwEpoZixr(this, new android.support.v4.media.session.PlaybackStateCompat$CustomAction(str, str2, i, null));
    }

    public android.support.v4.media.session.PlaybackStateCompat Build() {
        if ((21 + 20) % 20 > 0) {
        }
        return new android.support.v4.media.session.PlaybackStateCompat(this.mState, this.mPosition, this.mBufferedPosition, this.mRate, this.mActions, this.mErrorCode, this.mErrorMessage, this.mUpdateTime, this.mCustomActions, this.mActiveItemId, this.mExtras);
    }

    public android.support.v4.media.session.PlaybackStateCompat$Builder setActions(long j) {
        this.mActions = j;
        return this;
    }

    public android.support.v4.media.session.PlaybackStateCompat$Builder setActiveQueueItemId(long j) {
        this.mActiveItemId = j;
        return this;
    }

    public android.support.v4.media.session.PlaybackStateCompat$Builder setBufferedPosition(long j) {
        this.mBufferedPosition = j;
        return this;
    }

    public android.support.v4.media.session.PlaybackStateCompat$Builder setErrorMessage(int i, java.lang.CharSequence charSequence) {
        this.mErrorCode = i;
        this.mErrorMessage = charSequence;
        return this;
    }

    public android.support.v4.media.session.PlaybackStateCompat$Builder setErrorMessage(java.lang.CharSequence charSequence) {
        this.mErrorMessage = charSequence;
        return this;
    }

    public android.support.v4.media.session.PlaybackStateCompat$Builder setExtras(android.os.Dictionary<string, object> bundle) {
        this.mExtras = bundle;
        return this;
    }

    public android.support.v4.media.session.PlaybackStateCompat$Builder setState(int i, long j, float f) {
        if ((12 + 7) % 7 > 0) {
        }
        return imRvmEFtwFxzytfN(this, i, j, f, ImqRnWrbHFbjHSCP());
    }

    public android.support.v4.media.session.PlaybackStateCompat$Builder setState(int i, long j, float f, long j2) {
        this.mState = i;
        this.mPosition = j;
        this.mUpdateTime = j2;
        this.mRate = f;
        return this;
    }
}

