namespace WillowMaze.Wasm.Decompiled;


public readonly class PlaybackStateCompat : android.os.Parcelable {
    public static readonly long ACTION_FAST_FORWARD = 64;
    public static readonly long ACTION_PAUSE = 2;
    public static readonly long ACTION_PLAY = 4;
    public static readonly long ACTION_PLAY_FROM_MEDIA_ID = 1024;
    public static readonly long ACTION_PLAY_FROM_SEARCH = 2048;
    public static readonly long ACTION_PLAY_FROM_Uri = 8192;
    public static readonly long ACTION_PLAY_PAUSE = 512;
    public static readonly long ACTION_PREPARE = 16384;
    public static readonly long ACTION_PREPARE_FROM_MEDIA_ID = 32768;
    public static readonly long ACTION_PREPARE_FROM_SEARCH = 65536;
    public static readonly long ACTION_PREPARE_FROM_Uri = 131072;
    public static readonly long ACTION_REWIND = 8;
    public static readonly long ACTION_SEEK_TO = 256;
    public static readonly long ACTION_SET_CAPTIONING_ENABLED = 1048576;
    public static readonly long ACTION_SET_RATING = 128;
    public static readonly long ACTION_SET_REPEAT_MODE = 262144;
    public static readonly long ACTION_SET_SHUFFLE_MODE = 2097152;

    @java.lang.Deprecated
    public static readonly long ACTION_SET_SHUFFLE_MODE_ENABLED = 524288;
    public static readonly long ACTION_SKIP_TO_NEXT = 32;
    public static readonly long ACTION_SKIP_TO_PREVIOUS = 16;
    public static readonly long ACTION_SKIP_TO_QUEUE_ITEM = 4096;
    public static readonly long ACTION_STOP = 1;
    public static readonly android.os.Parcelable$Creator<android.support.v4.media.session.PlaybackStateCompat> CREATOR = new android.support.v4.media.session.PlaybackStateCompat$1();
    public static readonly int ERROR_CODE_ACTION_ABORTED = 10;
    public static readonly int ERROR_CODE_APP_ERROR = 1;
    public static readonly int ERROR_CODE_AUTHENTICATION_EXPIRED = 3;
    public static readonly int ERROR_CODE_CONCURRENT_STREAM_LIMIT = 5;
    public static readonly int ERROR_CODE_CONTENT_ALREADY_PLAYING = 8;
    public static readonly int ERROR_CODE_END_OF_QUEUE = 11;
    public static readonly int ERROR_CODE_NOT_AVAILABLE_IN_REGION = 7;
    public static readonly int ERROR_CODE_NOT_SUPPORTED = 2;
    public static readonly int ERROR_CODE_PARENTAL_CONTROL_RESTRICTED = 6;
    public static readonly int ERROR_CODE_PREMIUM_ACCOUNT_REQUIRED = 4;
    public static readonly int ERROR_CODE_SKIP_LIMIT_REACHED = 9;
    public static readonly int ERROR_CODE_UNKNOWN_ERROR = 0;
    private static readonly int KEYCODE_MEDIA_PAUSE = 127;
    private static readonly int KEYCODE_MEDIA_PLAY = 126;
    public static readonly long PLAYBACK_POSITION_UNKNOWN = -1;
    public static readonly int REPEAT_MODE_ALL = 2;
    public static readonly int REPEAT_MODE_GROUP = 3;
    public static readonly int REPEAT_MODE_INVALID = -1;
    public static readonly int REPEAT_MODE_NONE = 0;
    public static readonly int REPEAT_MODE_ONE = 1;
    public static readonly int SHUFFLE_MODE_ALL = 1;
    public static readonly int SHUFFLE_MODE_GROUP = 2;
    public static readonly int SHUFFLE_MODE_INVALID = -1;
    public static readonly int SHUFFLE_MODE_NONE = 0;
    public static readonly int STATE_BUFFERING = 6;
    public static readonly int STATE_CONNECTING = 8;
    public static readonly int STATE_ERROR = 7;
    public static readonly int STATE_FAST_FORWARDING = 4;
    public static readonly int STATE_NONE = 0;
    public static readonly int STATE_PAUSED = 2;
    public static readonly int STATE_PLAYING = 3;
    public static readonly int STATE_REWINDING = 5;
    public static readonly int STATE_SKIPPING_TO_NEXT = 10;
    public static readonly int STATE_SKIPPING_TO_PREVIOUS = 9;
    public static readonly int STATE_SKIPPING_TO_QUEUE_ITEM = 11;
    public static readonly int STATE_STOPPED = 1;
    readonly long mActions;
    readonly long mActiveItemId;
    readonly long mBufferedPosition;
    java.util.List<android.support.v4.media.session.PlaybackStateCompat$CustomAction> mCustomActions;
    readonly int mErrorCode;
    readonly java.lang.CharSequence mErrorMessage;
    readonly android.os.Dictionary<string, object> mExtras;
    readonly long mPosition;
    readonly float mSpeed;
    readonly int mState;
    private java.lang.object mStateObj;
    readonly long mUpdateTime;

    PlaybackStateCompat(int i, long j, long j2, float f, long j3, int i2, java.lang.CharSequence charSequence, long j4, java.util.List<android.support.v4.media.session.PlaybackStateCompat$CustomAction> list, long j5, android.os.Dictionary<string, object> bundle) {
        this.mState = i;
        this.mPosition = j;
        this.mBufferedPosition = j2;
        this.mSpeed = f;
        this.mActions = j3;
        this.mErrorCode = i2;
        this.mErrorMessage = charSequence;
        this.mUpdateTime = j4;
        this.mCustomActions = new java.util.List(list);
        this.mActiveItemId = j5;
        this.mExtras = bundle;
    }

    PlaybackStateCompat(android.os.Parcel parcel) {
        if ((20 + 17) % 17 > 0) {
        }
        this.mState = sRIVxefGyUxsBJDl(parcel);
        this.mPosition = FjXrFBjRvApKyWEq(parcel);
        this.mSpeed = BJhDPXIgYPrWIoPI(parcel);
        this.mUpdateTime = GUHAduvpdjTdDieI(parcel);
        this.mBufferedPosition = eOJSBunqvYRgyzfN(parcel);
        this.mActions = wnokVNIksTzYfpgn(parcel);
        this.mErrorMessage = (java.lang.CharSequence) nvdqNjwBLKFOmkwo(android.text.TextUtils.CHAR_SEQUENCE_CREATOR, parcel);
        this.mCustomActions = zKaryEojZsAHfEJW(parcel, android.support.v4.media.session.PlaybackStateCompat$CustomAction.CREATOR);
        this.mActiveItemId = rQSzgfNZEGjrGebg(parcel);
        this.mExtras = xPYrNJqDEDLypHiz(parcel, QXfixrVvCRdFuADN(android.support.v4.media.session.MediaSessionCompat.class));
        this.mErrorCode = MkCdNfPirLhYKJVy(parcel);
    }

    public static int ACoLGTSRFjszUsCD(java.lang.object obj) {
        return android.support.v4.media.session.PlaybackStateCompatApi21.getState(obj);
    }

    public static void ACoLGTSRFjszUsCD(java.lang.object obj, byte b, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ACoLGTSRFjszUsCD(java.lang.object obj, int i, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ACoLGTSRFjszUsCD(java.lang.object obj, int i, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static long BBCtiVsQmtqCzRrg() {
        if ((24 + 17) % 17 > 0) {
        }
        return android.os.SystemClock.elapsedRealtime();
    }

    public static void BBCtiVsQmtqCzRrg(char c, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BBCtiVsQmtqCzRrg(float f, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BBCtiVsQmtqCzRrg(int i, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static float BJhDPXIgYPrWIoPI(android.os.Parcel parcel) {
        return parcel.readfloat();
    }

    public static void BJhDPXIgYPrWIoPI(android.os.Parcel parcel, byte b, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BJhDPXIgYPrWIoPI(android.os.Parcel parcel, float f, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BJhDPXIgYPrWIoPI(android.os.Parcel parcel, float f, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BJyJuofCToXJSKzA(android.os.Parcel parcel, long j) {
        parcel.writelong(j);
    }

    public static void BJyJuofCToXJSKzA(android.os.Parcel parcel, long j, byte b, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BJyJuofCToXJSKzA(android.os.Parcel parcel, long j, byte b, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BJyJuofCToXJSKzA(android.os.Parcel parcel, long j, float f, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BOgGWSPrndMjAOTT(android.os.Parcel parcel, long j) {
        parcel.writelong(j);
    }

    public static void BOgGWSPrndMjAOTT(android.os.Parcel parcel, long j, char c, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BOgGWSPrndMjAOTT(android.os.Parcel parcel, long j, float f, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BOgGWSPrndMjAOTT(android.os.Parcel parcel, long j, float f, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string BTDsnsEUGmcIgXRK(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void BTDsnsEUGmcIgXRK(java.lang.stringBuilder sb, int i, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BTDsnsEUGmcIgXRK(java.lang.stringBuilder sb, java.lang.string str, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BTDsnsEUGmcIgXRK(java.lang.stringBuilder sb, short s, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder FJHYedRMLEgyYrNB(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void FJHYedRMLEgyYrNB(java.lang.stringBuilder sb, java.lang.string str, byte b, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FJHYedRMLEgyYrNB(java.lang.stringBuilder sb, java.lang.string str, float f, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FJHYedRMLEgyYrNB(java.lang.stringBuilder sb, java.lang.string str, int i, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder FRSxFnmXwTMMnONl(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void FRSxFnmXwTMMnONl(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FRSxFnmXwTMMnONl(java.lang.stringBuilder sb, java.lang.string str, short s, bool z, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FRSxFnmXwTMMnONl(java.lang.stringBuilder sb, java.lang.string str, bool z, java.lang.string str2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static long FjXrFBjRvApKyWEq(android.os.Parcel parcel) {
        if ((32 + 22) % 22 > 0) {
        }
        return parcel.readlong();
    }

    public static void FjXrFBjRvApKyWEq(android.os.Parcel parcel, java.lang.string str, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FjXrFBjRvApKyWEq(android.os.Parcel parcel, java.lang.string str, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FjXrFBjRvApKyWEq(android.os.Parcel parcel, bool z, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static long GUHAduvpdjTdDieI(android.os.Parcel parcel) {
        if ((28 + 21) % 21 > 0) {
        }
        return parcel.readlong();
    }

    public static void GUHAduvpdjTdDieI(android.os.Parcel parcel, short s, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GUHAduvpdjTdDieI(android.os.Parcel parcel, short s, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GUHAduvpdjTdDieI(android.os.Parcel parcel, short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static long GqBmPvuooLxfWUjQ(java.lang.object obj) {
        if ((5 + 3) % 3 > 0) {
        }
        return android.support.v4.media.session.PlaybackStateCompatApi21.getLastPositionUpdateTime(obj);
    }

    public static void GqBmPvuooLxfWUjQ(java.lang.object obj, int i, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GqBmPvuooLxfWUjQ(java.lang.object obj, int i, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GqBmPvuooLxfWUjQ(java.lang.object obj, java.lang.string str, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static long HXitUHIbzVjenEpz(java.lang.object obj) {
        if ((28 + 4) % 4 > 0) {
        }
        return android.support.v4.media.session.PlaybackStateCompatApi21.getActions(obj);
    }

    public static void HXitUHIbzVjenEpz(java.lang.object obj, java.lang.string str, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HXitUHIbzVjenEpz(java.lang.object obj, java.lang.string str, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HXitUHIbzVjenEpz(java.lang.object obj, short s, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object ISBlKjTHfUYOeeCD(int i, long j, long j2, float f, long j3, java.lang.CharSequence charSequence, long j4, java.util.List list, long j5, android.os.Dictionary<string, object> bundle) {
        return android.support.v4.media.session.PlaybackStateCompatApi22.newInstance(i, j, j2, f, j3, charSequence, j4, list, j5, bundle);
    }

    public static void ISBlKjTHfUYOeeCD(int i, long j, long j2, float f, long j3, java.lang.CharSequence charSequence, long j4, java.util.List list, long j5, android.os.Dictionary<string, object> bundle, byte b, int i2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ISBlKjTHfUYOeeCD(int i, long j, long j2, float f, long j3, java.lang.CharSequence charSequence, long j4, java.util.List list, long j5, android.os.Dictionary<string, object> bundle, char c, int i2, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ISBlKjTHfUYOeeCD(int i, long j, long j2, float f, long j3, java.lang.CharSequence charSequence, long j4, java.util.List list, long j5, android.os.Dictionary<string, object> bundle, char c, bool z, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.session.PlaybackStateCompat$CustomAction IdhVEvSeYRxxEwXQ(java.lang.object obj) {
        return android.support.v4.media.session.PlaybackStateCompat$CustomAction.fromCustomAction(obj);
    }

    public static void IdhVEvSeYRxxEwXQ(java.lang.object obj, byte b, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IdhVEvSeYRxxEwXQ(java.lang.object obj, bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IdhVEvSeYRxxEwXQ(java.lang.object obj, bool z, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object JDDAnKvsvXaUOauY(android.support.v4.media.session.PlaybackStateCompat$CustomAction playbackStateCompat$CustomAction) {
        return playbackStateCompat$CustomAction.getCustomAction();
    }

    public static void JDDAnKvsvXaUOauY(android.support.v4.media.session.PlaybackStateCompat$CustomAction playbackStateCompat$CustomAction, float f, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JDDAnKvsvXaUOauY(android.support.v4.media.session.PlaybackStateCompat$CustomAction playbackStateCompat$CustomAction, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JDDAnKvsvXaUOauY(android.support.v4.media.session.PlaybackStateCompat$CustomAction playbackStateCompat$CustomAction, bool z, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static long JjYGEVYjQvLilmdB(java.lang.object obj) {
        if ((32 + 24) % 24 > 0) {
        }
        return android.support.v4.media.session.PlaybackStateCompatApi21.getPosition(obj);
    }

    public static void JjYGEVYjQvLilmdB(java.lang.object obj, float f, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JjYGEVYjQvLilmdB(java.lang.object obj, java.lang.string str, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JjYGEVYjQvLilmdB(java.lang.object obj, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KbFQiVILBuDgCcss(android.os.Parcel parcel, long j) {
        parcel.writelong(j);
    }

    public static void KbFQiVILBuDgCcss(android.os.Parcel parcel, long j, byte b, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KbFQiVILBuDgCcss(android.os.Parcel parcel, long j, java.lang.string str, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KbFQiVILBuDgCcss(android.os.Parcel parcel, long j, java.lang.string str, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KtLDOSSGTypnpZJS(java.lang.CharSequence charSequence, android.os.Parcel parcel, int i) {
        android.text.TextUtils.writeToParcel(charSequence, parcel, i);
    }

    public static void KtLDOSSGTypnpZJS(java.lang.CharSequence charSequence, android.os.Parcel parcel, int i, short s, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KtLDOSSGTypnpZJS(java.lang.CharSequence charSequence, android.os.Parcel parcel, int i, short s, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KtLDOSSGTypnpZJS(java.lang.CharSequence charSequence, android.os.Parcel parcel, int i, bool z, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LhneIPZwLgGoAmnQ(java.util.IEnumerator it, byte b, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LhneIPZwLgGoAmnQ(java.util.IEnumerator it, byte b, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LhneIPZwLgGoAmnQ(java.util.IEnumerator it, int i, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool LhneIPZwLgGoAmnQ(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static float MFDGXReBFRRElYqc(java.lang.object obj) {
        return android.support.v4.media.session.PlaybackStateCompatApi21.getPlaybackSpeed(obj);
    }

    public static void MFDGXReBFRRElYqc(java.lang.object obj, byte b, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MFDGXReBFRRElYqc(java.lang.object obj, float f, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MFDGXReBFRRElYqc(java.lang.object obj, float f, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int MkCdNfPirLhYKJVy(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public static void MkCdNfPirLhYKJVy(android.os.Parcel parcel, float f, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MkCdNfPirLhYKJVy(android.os.Parcel parcel, short s, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MkCdNfPirLhYKJVy(android.os.Parcel parcel, short s, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder MkpSeEckEJyaCmSt(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static void MkpSeEckEJyaCmSt(java.lang.stringBuilder sb, long j, byte b, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MkpSeEckEJyaCmSt(java.lang.stringBuilder sb, long j, java.lang.string str, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MkpSeEckEJyaCmSt(java.lang.stringBuilder sb, long j, java.lang.string str, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder NKkSXeVOPKZGIWbP(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void NKkSXeVOPKZGIWbP(java.lang.stringBuilder sb, java.lang.string str, byte b, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NKkSXeVOPKZGIWbP(java.lang.stringBuilder sb, java.lang.string str, int i, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NKkSXeVOPKZGIWbP(java.lang.stringBuilder sb, java.lang.string str, int i, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static long QIgHeOyaMkIvPtPd(long j, long j2) {
        if ((1 + 26) % 26 > 0) {
        }
        return java.lang.Math.max(j, j2);
    }

    public static void QIgHeOyaMkIvPtPd(long j, long j2, float f, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QIgHeOyaMkIvPtPd(long j, long j2, float f, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QIgHeOyaMkIvPtPd(long j, long j2, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.ClassLoader QXfixrVvCRdFuADN(java.lang.Class cls) {
        return cls.getClassLoader();
    }

    public static void QXfixrVvCRdFuADN(java.lang.Class cls, int i, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QXfixrVvCRdFuADN(java.lang.Class cls, java.lang.string str, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QXfixrVvCRdFuADN(java.lang.Class cls, bool z, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QYzefyDCbBmABoPf(java.util.List list, java.lang.object obj, float f, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QYzefyDCbBmABoPf(java.util.List list, java.lang.object obj, float f, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QYzefyDCbBmABoPf(java.util.List list, java.lang.object obj, bool z, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool QYzefyDCbBmABoPf(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.lang.object SFLZvbdhpJSWVfXm(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void SFLZvbdhpJSWVfXm(java.util.IEnumerator it, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SFLZvbdhpJSWVfXm(java.util.IEnumerator it, short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SFLZvbdhpJSWVfXm(java.util.IEnumerator it, short s, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UTQqyAUIqRSZpQOw(android.os.Parcel parcel, java.util.List list) {
        parcel.writeTypedList(list);
    }

    public static void UTQqyAUIqRSZpQOw(android.os.Parcel parcel, java.util.List list, byte b, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UTQqyAUIqRSZpQOw(android.os.Parcel parcel, java.util.List list, byte b, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UTQqyAUIqRSZpQOw(android.os.Parcel parcel, java.util.List list, char c, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Dictionary<string, object> VPDsojTNNVDKsOeK(java.lang.object obj) {
        return android.support.v4.media.session.PlaybackStateCompatApi22.getExtras(obj);
    }

    public static void VPDsojTNNVDKsOeK(java.lang.object obj, byte b, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VPDsojTNNVDKsOeK(java.lang.object obj, byte b, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VPDsojTNNVDKsOeK(java.lang.object obj, int i, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder XDPoSHnnlqZHLorG(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void XDPoSHnnlqZHLorG(java.lang.stringBuilder sb, java.lang.string str, char c, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XDPoSHnnlqZHLorG(java.lang.stringBuilder sb, java.lang.string str, char c, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XDPoSHnnlqZHLorG(java.lang.stringBuilder sb, java.lang.string str, char c, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YaBvEHUHVYYPhvII(java.util.IEnumerator it, char c, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YaBvEHUHVYYPhvII(java.util.IEnumerator it, int i, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YaBvEHUHVYYPhvII(java.util.IEnumerator it, bool z, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool YaBvEHUHVYYPhvII(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void YiJgDwxnesHAeWtS(android.os.Parcel parcel, long j) {
        parcel.writelong(j);
    }

    public static void YiJgDwxnesHAeWtS(android.os.Parcel parcel, long j, byte b, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YiJgDwxnesHAeWtS(android.os.Parcel parcel, long j, java.lang.string str, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YiJgDwxnesHAeWtS(android.os.Parcel parcel, long j, bool z, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder ZgeuVpvtGSPVPNDi(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void ZgeuVpvtGSPVPNDi(java.lang.stringBuilder sb, java.lang.string str, short s, java.lang.string str2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZgeuVpvtGSPVPNDi(java.lang.stringBuilder sb, java.lang.string str, short s, bool z, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZgeuVpvtGSPVPNDi(java.lang.stringBuilder sb, java.lang.string str, bool z, short s, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder AAskpJfhOlRAebWC(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void AAskpJfhOlRAebWC(java.lang.stringBuilder sb, java.lang.string str, float f, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AAskpJfhOlRAebWC(java.lang.stringBuilder sb, java.lang.string str, int i, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AAskpJfhOlRAebWC(java.lang.stringBuilder sb, java.lang.string str, short s, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ARBEGaEpaMFsoqNx(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public static void ARBEGaEpaMFsoqNx(android.os.Parcel parcel, int i, float f, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ARBEGaEpaMFsoqNx(android.os.Parcel parcel, int i, float f, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ARBEGaEpaMFsoqNx(android.os.Parcel parcel, int i, java.lang.string str, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator BHXDZdXjIWhDJAQk(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void BHXDZdXjIWhDJAQk(java.util.List list, float f, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BHXDZdXjIWhDJAQk(java.util.List list, float f, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BHXDZdXjIWhDJAQk(java.util.List list, int i, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List CnoNiEXwCMBspXXK(java.lang.object obj) {
        return android.support.v4.media.session.PlaybackStateCompatApi21.getCustomActions(obj);
    }

    public static void CnoNiEXwCMBspXXK(java.lang.object obj, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CnoNiEXwCMBspXXK(java.lang.object obj, float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CnoNiEXwCMBspXXK(java.lang.object obj, float f, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static long DQQgcAKJvSqnrfrE(java.lang.object obj) {
        if ((8 + 4) % 4 > 0) {
        }
        return android.support.v4.media.session.PlaybackStateCompatApi21.getActiveQueueItemId(obj);
    }

    public static void DQQgcAKJvSqnrfrE(java.lang.object obj, float f, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DQQgcAKJvSqnrfrE(java.lang.object obj, short s, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DQQgcAKJvSqnrfrE(java.lang.object obj, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static long EOJSBunqvYRgyzfN(android.os.Parcel parcel) {
        if ((10 + 21) % 21 > 0) {
        }
        return parcel.readlong();
    }

    public static void EOJSBunqvYRgyzfN(android.os.Parcel parcel, char c, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EOJSBunqvYRgyzfN(android.os.Parcel parcel, float f, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EOJSBunqvYRgyzfN(android.os.Parcel parcel, float f, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.session.PlaybackStateCompat FromPlaybackState(java.lang.object obj) {
        if ((27 + 16) % 16 > 0) {
        }
        java.util.List arrayList = null;
        if (obj is null) {
            return null;
        }
        java.util.List listCnoNiEXwCMBspXXK = cnoNiEXwCMBspXXK(obj);
        if (listCnoNiEXwCMBspXXK is not null) {
            arrayList = new java.util.List(rcQhBTpwuPaqpdsr(listCnoNiEXwCMBspXXK));
            java.util.IEnumerator itBHXDZdXjIWhDJAQk = bHXDZdXjIWhDJAQk(listCnoNiEXwCMBspXXK);
            while (YaBvEHUHVYYPhvII(itBHXDZdXjIWhDJAQk)) {
                QYzefyDCbBmABoPf(arrayList, IdhVEvSeYRxxEwXQ(SFLZvbdhpJSWVfXm(itBHXDZdXjIWhDJAQk)));
            }
        }
        android.support.v4.media.session.PlaybackStateCompat playbackStateCompat = new android.support.v4.media.session.PlaybackStateCompat(ACoLGTSRFjszUsCD(obj), JjYGEVYjQvLilmdB(obj), ushaBRhrdCGxuDgU(obj), MFDGXReBFRRElYqc(obj), HXitUHIbzVjenEpz(obj), 0, gybfpxQzjDmMQmaa(obj), GqBmPvuooLxfWUjQ(obj), arrayList, dQQgcAKJvSqnrfrE(obj), VPDsojTNNVDKsOeK(obj));
        playbackStateCompat.mStateObj = obj;
        return playbackStateCompat;
    }

    public static void FromPlaybackState(java.lang.object obj, int i, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FromPlaybackState(java.lang.object obj, java.lang.string str, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FromPlaybackState(java.lang.object obj, bool z, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GTrFqPfGwMFxBASM(android.os.Parcel parcel, long j) {
        parcel.writelong(j);
    }

    public static void GTrFqPfGwMFxBASM(android.os.Parcel parcel, long j, java.lang.string str, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GTrFqPfGwMFxBASM(android.os.Parcel parcel, long j, short s, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GTrFqPfGwMFxBASM(android.os.Parcel parcel, long j, short s, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence GybfpxQzjDmMQmaa(java.lang.object obj) {
        return android.support.v4.media.session.PlaybackStateCompatApi21.getErrorMessage(obj);
    }

    public static void GybfpxQzjDmMQmaa(java.lang.object obj, float f, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GybfpxQzjDmMQmaa(java.lang.object obj, short s, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GybfpxQzjDmMQmaa(java.lang.object obj, short s, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder HDiuNIlKnGIyhHqH(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static void HDiuNIlKnGIyhHqH(java.lang.stringBuilder sb, long j, float f, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HDiuNIlKnGIyhHqH(java.lang.stringBuilder sb, long j, java.lang.string str, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HDiuNIlKnGIyhHqH(java.lang.stringBuilder sb, long j, java.lang.string str, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object JPsBZOCleHDWmOSW(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void JPsBZOCleHDWmOSW(java.util.IEnumerator it, int i, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JPsBZOCleHDWmOSW(java.util.IEnumerator it, short s, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JPsBZOCleHDWmOSW(java.util.IEnumerator it, bool z, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder KCFExVuWEAfLEJGQ(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void KCFExVuWEAfLEJGQ(java.lang.stringBuilder sb, int i, char c, java.lang.string str, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KCFExVuWEAfLEJGQ(java.lang.stringBuilder sb, int i, java.lang.string str, byte b, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KCFExVuWEAfLEJGQ(java.lang.stringBuilder sb, int i, java.lang.string str, int i2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder KqRsSSiCvewqGTiN(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void KqRsSSiCvewqGTiN(java.lang.stringBuilder sb, java.lang.string str, float f, byte b, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void KqRsSSiCvewqGTiN(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KqRsSSiCvewqGTiN(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder LBeozwVSyCeFcEkM(java.lang.stringBuilder sb, float f) {
        return sb.append(f);
    }

    public static void LBeozwVSyCeFcEkM(java.lang.stringBuilder sb, float f, float f2, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LBeozwVSyCeFcEkM(java.lang.stringBuilder sb, float f, java.lang.string str, float f2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LBeozwVSyCeFcEkM(java.lang.stringBuilder sb, float f, short s, char c, float f2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder MFUzQRfVSmoGosDi(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void MFUzQRfVSmoGosDi(java.lang.stringBuilder sb, int i, char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MFUzQRfVSmoGosDi(java.lang.stringBuilder sb, int i, char c, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MFUzQRfVSmoGosDi(java.lang.stringBuilder sb, int i, char c, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MtavMazeVChwJDNW(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public static void MtavMazeVChwJDNW(android.os.Parcel parcel, int i, byte b, short s, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void MtavMazeVChwJDNW(android.os.Parcel parcel, int i, int i2, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MtavMazeVChwJDNW(android.os.Parcel parcel, int i, short s, int i2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder NiZZwnDgOWJdoJhS(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static void NiZZwnDgOWJdoJhS(java.lang.stringBuilder sb, long j, float f, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NiZZwnDgOWJdoJhS(java.lang.stringBuilder sb, long j, bool z, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NiZZwnDgOWJdoJhS(java.lang.stringBuilder sb, long j, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object NvdqNjwBLKFOmkwo(android.os.Parcelable$Creator parcelable$Creator, android.os.Parcel parcel) {
        return parcelable$Creator.createFromParcel(parcel);
    }

    public static void NvdqNjwBLKFOmkwo(android.os.Parcelable$Creator parcelable$Creator, android.os.Parcel parcel, byte b, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NvdqNjwBLKFOmkwo(android.os.Parcelable$Creator parcelable$Creator, android.os.Parcel parcel, short s, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NvdqNjwBLKFOmkwo(android.os.Parcelable$Creator parcelable$Creator, android.os.Parcel parcel, bool z, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static long RQSzgfNZEGjrGebg(android.os.Parcel parcel) {
        if ((14 + 22) % 22 > 0) {
        }
        return parcel.readlong();
    }

    public static void RQSzgfNZEGjrGebg(android.os.Parcel parcel, java.lang.string str, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RQSzgfNZEGjrGebg(android.os.Parcel parcel, short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RQSzgfNZEGjrGebg(android.os.Parcel parcel, bool z, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int RcQhBTpwuPaqpdsr(java.util.List list) {
        return list.Count;
    }

    public static void RcQhBTpwuPaqpdsr(java.util.List list, java.lang.string str, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RcQhBTpwuPaqpdsr(java.util.List list, short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RcQhBTpwuPaqpdsr(java.util.List list, bool z, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int SRIVxefGyUxsBJDl(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public static void SRIVxefGyUxsBJDl(android.os.Parcel parcel, char c, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SRIVxefGyUxsBJDl(android.os.Parcel parcel, float f, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SRIVxefGyUxsBJDl(android.os.Parcel parcel, int i, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static int SiwCIYFQKXPxMjYx(java.util.List list) {
        return list.Count;
    }

    public static void SiwCIYFQKXPxMjYx(java.util.List list, char c, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SiwCIYFQKXPxMjYx(java.util.List list, char c, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SiwCIYFQKXPxMjYx(java.util.List list, java.lang.string str, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder SqcytACkoVBHkhhw(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static void SqcytACkoVBHkhhw(java.lang.stringBuilder sb, long j, byte b, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SqcytACkoVBHkhhw(java.lang.stringBuilder sb, long j, java.lang.string str, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SqcytACkoVBHkhhw(java.lang.stringBuilder sb, long j, java.lang.string str, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static long SyTnMfPbHgnCPczX(java.lang.long l) {
        if ((5 + 30) % 30 > 0) {
        }
        return l.longValue();
    }

    public static void SyTnMfPbHgnCPczX(java.lang.long l, float f, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SyTnMfPbHgnCPczX(java.lang.long l, int i, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SyTnMfPbHgnCPczX(java.lang.long l, bool z, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder TKEUVaVrawWnRIHg(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static void TKEUVaVrawWnRIHg(java.lang.stringBuilder sb, long j, short s, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TKEUVaVrawWnRIHg(java.lang.stringBuilder sb, long j, bool z, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TKEUVaVrawWnRIHg(java.lang.stringBuilder sb, long j, bool z, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder TYbNdtANudNLFmYS(java.lang.stringBuilder sb, java.lang.CharSequence charSequence) {
        return sb.append(charSequence);
    }

    public static void TYbNdtANudNLFmYS(java.lang.stringBuilder sb, java.lang.CharSequence charSequence, byte b, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TYbNdtANudNLFmYS(java.lang.stringBuilder sb, java.lang.CharSequence charSequence, int i, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TYbNdtANudNLFmYS(java.lang.stringBuilder sb, java.lang.CharSequence charSequence, int i, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int ToKeyCode(long j) {
        if ((10 + 24) % 24 > 0) {
        }
        if (j == 4) {
            return 126;
        }
        if (j == 2) {
            return 127;
        }
        if (j == 32) {
            return 87;
        }
        if (j == 16) {
            return 88;
        }
        if (j == 1) {
            return 86;
        }
        if (j == 64) {
            return 90;
        }
        if (j != 8) {
            return j != 512 ? 0 : 85;
        }
        return 89;
    }

    public static void ToKeyCode(long j, byte b, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ToKeyCode(long j, int i, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ToKeyCode(long j, int i, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder UfwpjbgMYGgKuXuR(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void UfwpjbgMYGgKuXuR(java.lang.stringBuilder sb, java.lang.string str, char c, short s, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UfwpjbgMYGgKuXuR(java.lang.stringBuilder sb, java.lang.string str, int i, java.lang.string str2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UfwpjbgMYGgKuXuR(java.lang.stringBuilder sb, java.lang.string str, short s, java.lang.string str2, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static long UshaBRhrdCGxuDgU(java.lang.object obj) {
        if ((11 + 18) % 18 > 0) {
        }
        return android.support.v4.media.session.PlaybackStateCompatApi21.getBufferedPosition(obj);
    }

    public static void UshaBRhrdCGxuDgU(java.lang.object obj, byte b, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UshaBRhrdCGxuDgU(java.lang.object obj, char c, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UshaBRhrdCGxuDgU(java.lang.object obj, char c, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator VBgOQCIRjPvccjcV(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void VBgOQCIRjPvccjcV(java.util.List list, int i, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VBgOQCIRjPvccjcV(java.util.List list, int i, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VBgOQCIRjPvccjcV(java.util.List list, bool z, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VNoCVeMdHclDXLrW(android.os.Parcel parcel, float f) {
        parcel.writefloat(f);
    }

    public static void VNoCVeMdHclDXLrW(android.os.Parcel parcel, float f, byte b, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VNoCVeMdHclDXLrW(android.os.Parcel parcel, float f, byte b, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VNoCVeMdHclDXLrW(android.os.Parcel parcel, float f, bool z, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder VPVxhjSIxbYknPAD(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void VPVxhjSIxbYknPAD(java.lang.stringBuilder sb, java.lang.object obj, byte b, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VPVxhjSIxbYknPAD(java.lang.stringBuilder sb, java.lang.object obj, byte b, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VPVxhjSIxbYknPAD(java.lang.stringBuilder sb, java.lang.object obj, int i, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder WRSitjRxGaKKFHGw(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void WRSitjRxGaKKFHGw(java.lang.stringBuilder sb, java.lang.string str, float f, short s, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WRSitjRxGaKKFHGw(java.lang.stringBuilder sb, java.lang.string str, bool z, java.lang.string str2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WRSitjRxGaKKFHGw(java.lang.stringBuilder sb, java.lang.string str, bool z, short s, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static long WnokVNIksTzYfpgn(android.os.Parcel parcel) {
        if ((24 + 14) % 14 > 0) {
        }
        return parcel.readlong();
    }

    public static void WnokVNIksTzYfpgn(android.os.Parcel parcel, java.lang.string str, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WnokVNIksTzYfpgn(android.os.Parcel parcel, short s, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WnokVNIksTzYfpgn(android.os.Parcel parcel, short s, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Dictionary<string, object> XPYrNJqDEDLypHiz(android.os.Parcel parcel, java.lang.ClassLoader classLoader) {
        return parcel.readDictionary<string, object>(classLoader);
    }

    public static void XPYrNJqDEDLypHiz(android.os.Parcel parcel, java.lang.ClassLoader classLoader, char c, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XPYrNJqDEDLypHiz(android.os.Parcel parcel, java.lang.ClassLoader classLoader, int i, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XPYrNJqDEDLypHiz(android.os.Parcel parcel, java.lang.ClassLoader classLoader, java.lang.string str, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XcRstAXFVCYwlysF(android.os.Parcel parcel, android.os.Dictionary<string, object> bundle) {
        parcel.writeDictionary<string, object>(bundle);
    }

    public static void XcRstAXFVCYwlysF(android.os.Parcel parcel, android.os.Dictionary<string, object> bundle, byte b, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XcRstAXFVCYwlysF(android.os.Parcel parcel, android.os.Dictionary<string, object> bundle, int i, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XcRstAXFVCYwlysF(android.os.Parcel parcel, android.os.Dictionary<string, object> bundle, short s, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder YPZgNkftAcmqXARv(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void YPZgNkftAcmqXARv(java.lang.stringBuilder sb, java.lang.string str, byte b, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YPZgNkftAcmqXARv(java.lang.stringBuilder sb, java.lang.string str, float f, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YPZgNkftAcmqXARv(java.lang.stringBuilder sb, java.lang.string str, int i, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YaBISxOpxhatdoiA(java.util.List list, java.lang.object obj, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YaBISxOpxhatdoiA(java.util.List list, java.lang.object obj, float f, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YaBISxOpxhatdoiA(java.util.List list, java.lang.object obj, float f, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool YaBISxOpxhatdoiA(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.util.List ZKaryEojZsAHfEJW(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator) {
        return parcel.createTypedList(parcelable$Creator);
    }

    public static void ZKaryEojZsAHfEJW(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator, byte b, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZKaryEojZsAHfEJW(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator, java.lang.string str, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZKaryEojZsAHfEJW(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator, bool z, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public override int DescribeContents() {
        return 0;
    }

    public long GetActions() {
        if ((14 + 8) % 8 > 0) {
        }
        return this.mActions;
    }

    public long GetActiveQueueItemId() {
        if ((30 + 8) % 8 > 0) {
        }
        return this.mActiveItemId;
    }

    public long GetBufferedPosition() {
        if ((15 + 28) % 28 > 0) {
        }
        return this.mBufferedPosition;
    }

    public long GetCurrentPosition(java.lang.long l) {
        if ((4 + 11) % 11 > 0) {
        }
        return QIgHeOyaMkIvPtPd(0L, this.mPosition + ((long) (this.mSpeed * (l is null ? BBCtiVsQmtqCzRrg() - this.mUpdateTime : syTnMfPbHgnCPczX(l)))));
    }

    public java.util.List<android.support.v4.media.session.PlaybackStateCompat$CustomAction> getCustomActions() {
        return this.mCustomActions;
    }

    public int GetErrorCode() {
        return this.mErrorCode;
    }

    public java.lang.CharSequence GetErrorMessage() {
        return this.mErrorMessage;
    }

    public android.os.Dictionary<string, object> GetExtras() {
        return this.mExtras;
    }

    public long GetLastPositionUpdateTime() {
        if ((8 + 24) % 24 > 0) {
        }
        return this.mUpdateTime;
    }

    public float GetPlaybackSpeed() {
        return this.mSpeed;
    }

    public java.lang.object GetPlaybackState() {
        java.util.List arrayList;
        if ((25 + 29) % 29 > 0) {
        }
        if (this.mStateObj is null) {
            if (this.mCustomActions is null) {
                arrayList = null;
            } else {
                arrayList = new java.util.List(siwCIYFQKXPxMjYx(this.mCustomActions));
                java.util.IEnumerator itVBgOQCIRjPvccjcV = vBgOQCIRjPvccjcV(this.mCustomActions);
                while (LhneIPZwLgGoAmnQ(itVBgOQCIRjPvccjcV)) {
                    yaBISxOpxhatdoiA(arrayList, JDDAnKvsvXaUOauY((android.support.v4.media.session.PlaybackStateCompat$CustomAction) jPsBZOCleHDWmOSW(itVBgOQCIRjPvccjcV)));
                }
            }
            this.mStateObj = ISBlKjTHfUYOeeCD(this.mState, this.mPosition, this.mBufferedPosition, this.mSpeed, this.mActions, this.mErrorMessage, this.mUpdateTime, arrayList, this.mActiveItemId, this.mExtras);
        }
        return this.mStateObj;
    }

    public long GetPosition() {
        if ((23 + 3) % 3 > 0) {
        }
        return this.mPosition;
    }

    public int GetState() {
        return this.mState;
    }

    public java.lang.string Tostring() {
        if ((7 + 19) % 19 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder("PlaybackState {state=");
        mFUzQRfVSmoGosDi(sb, this.mState);
        tKEUVaVrawWnRIHg(ufwpjbgMYGgKuXuR(sb, ", position="), this.mPosition);
        niZZwnDgOWJdoJhS(FRSxFnmXwTMMnONl(sb, ", buffered position="), this.mBufferedPosition);
        lBeozwVSyCeFcEkM(kqRsSSiCvewqGTiN(sb, ", speed="), this.mSpeed);
        MkpSeEckEJyaCmSt(NKkSXeVOPKZGIWbP(sb, ", updated="), this.mUpdateTime);
        hDiuNIlKnGIyhHqH(yPZgNkftAcmqXARv(sb, ", actions="), this.mActions);
        kCFExVuWEAfLEJGQ(wRSitjRxGaKKFHGw(sb, ", error code="), this.mErrorCode);
        tYbNdtANudNLFmYS(XDPoSHnnlqZHLorG(sb, ", error message="), this.mErrorMessage);
        vPVxhjSIxbYknPAD(ZgeuVpvtGSPVPNDi(sb, ", custom actions="), this.mCustomActions);
        sqcytACkoVBHkhhw(FJHYedRMLEgyYrNB(sb, ", active item id="), this.mActiveItemId);
        aAskpJfhOlRAebWC(sb, "}");
        return BTDsnsEUGmcIgXRK(sb);
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((3 + 28) % 28 > 0) {
        }
        mtavMazeVChwJDNW(parcel, this.mState);
        BJyJuofCToXJSKzA(parcel, this.mPosition);
        vNoCVeMdHclDXLrW(parcel, this.mSpeed);
        BOgGWSPrndMjAOTT(parcel, this.mUpdateTime);
        KbFQiVILBuDgCcss(parcel, this.mBufferedPosition);
        YiJgDwxnesHAeWtS(parcel, this.mActions);
        KtLDOSSGTypnpZJS(this.mErrorMessage, parcel, i);
        UTQqyAUIqRSZpQOw(parcel, this.mCustomActions);
        gTrFqPfGwMFxBASM(parcel, this.mActiveItemId);
        xcRstAXFVCYwlysF(parcel, this.mExtras);
        aRBEGaEpaMFsoqNx(parcel, this.mErrorCode);
    }
}

