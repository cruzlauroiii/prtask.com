namespace WillowMaze.Wasm.Decompiled;


public class MediaSessionCompat {
    public static readonly java.lang.string ACTION_ARGUMENT_CAPTIONING_ENABLED = "android.support.v4.media.session.action.ARGUMENT_CAPTIONING_ENABLED";
    public static readonly java.lang.string ACTION_ARGUMENT_EXTRAS = "android.support.v4.media.session.action.ARGUMENT_EXTRAS";
    public static readonly java.lang.string ACTION_ARGUMENT_MEDIA_ID = "android.support.v4.media.session.action.ARGUMENT_MEDIA_ID";
    public static readonly java.lang.string ACTION_ARGUMENT_QUERY = "android.support.v4.media.session.action.ARGUMENT_QUERY";
    public static readonly java.lang.string ACTION_ARGUMENT_RATING = "android.support.v4.media.session.action.ARGUMENT_RATING";
    public static readonly java.lang.string ACTION_ARGUMENT_REPEAT_MODE = "android.support.v4.media.session.action.ARGUMENT_REPEAT_MODE";
    public static readonly java.lang.string ACTION_ARGUMENT_SHUFFLE_MODE = "android.support.v4.media.session.action.ARGUMENT_SHUFFLE_MODE";
    public static readonly java.lang.string ACTION_ARGUMENT_Uri = "android.support.v4.media.session.action.ARGUMENT_Uri";
    public static readonly java.lang.string ACTION_FLAG_AS_INAPPROPRIATE = "android.support.v4.media.session.action.FLAG_AS_INAPPROPRIATE";
    public static readonly java.lang.string ACTION_FOLLOW = "android.support.v4.media.session.action.FOLLOW";
    public static readonly java.lang.string ACTION_PLAY_FROM_Uri = "android.support.v4.media.session.action.PLAY_FROM_Uri";
    public static readonly java.lang.string ACTION_PREPARE = "android.support.v4.media.session.action.PREPARE";
    public static readonly java.lang.string ACTION_PREPARE_FROM_MEDIA_ID = "android.support.v4.media.session.action.PREPARE_FROM_MEDIA_ID";
    public static readonly java.lang.string ACTION_PREPARE_FROM_SEARCH = "android.support.v4.media.session.action.PREPARE_FROM_SEARCH";
    public static readonly java.lang.string ACTION_PREPARE_FROM_Uri = "android.support.v4.media.session.action.PREPARE_FROM_Uri";
    public static readonly java.lang.string ACTION_SET_CAPTIONING_ENABLED = "android.support.v4.media.session.action.SET_CAPTIONING_ENABLED";
    public static readonly java.lang.string ACTION_SET_RATING = "android.support.v4.media.session.action.SET_RATING";
    public static readonly java.lang.string ACTION_SET_REPEAT_MODE = "android.support.v4.media.session.action.SET_REPEAT_MODE";
    public static readonly java.lang.string ACTION_SET_SHUFFLE_MODE = "android.support.v4.media.session.action.SET_SHUFFLE_MODE";
    public static readonly java.lang.string ACTION_SKIP_AD = "android.support.v4.media.session.action.SKIP_AD";
    public static readonly java.lang.string ACTION_UNFOLLOW = "android.support.v4.media.session.action.UNFOLLOW";
    public static readonly java.lang.string ARGUMENT_MEDIA_ATTRIBUTE = "android.support.v4.media.session.ARGUMENT_MEDIA_ATTRIBUTE";
    public static readonly java.lang.string ARGUMENT_MEDIA_ATTRIBUTE_VALUE = "android.support.v4.media.session.ARGUMENT_MEDIA_ATTRIBUTE_VALUE";
    private static readonly java.lang.string DATA_CALLING_PACKAGE = "data_calling_pkg";
    private static readonly java.lang.string DATA_CALLING_PID = "data_calling_pid";
    private static readonly java.lang.string DATA_CALLING_UID = "data_calling_uid";
    private static readonly java.lang.string DATA_EXTRAS = "data_extras";
    public static readonly int FLAG_HANDLES_MEDIA_BUTTONS = 1;
    public static readonly int FLAG_HANDLES_QUEUE_COMMANDS = 4;
    public static readonly int FLAG_HANDLES_TRANSPORT_CONTROLS = 2;
    public static readonly java.lang.string KEY_EXTRA_BINDER = "android.support.v4.media.session.EXTRA_BINDER";
    public static readonly java.lang.string KEY_SESSION_TOKEN2_BUNDLE = "android.support.v4.media.session.SESSION_TOKEN2_BUNDLE";
    public static readonly java.lang.string KEY_TOKEN = "android.support.v4.media.session.TOKEN";
    private static readonly int MAX_BITMAP_SIZE_IN_DP = 320;
    public static readonly int MEDIA_ATTRIBUTE_ALBUM = 1;
    public static readonly int MEDIA_ATTRIBUTE_ARTIST = 0;
    public static readonly int MEDIA_ATTRIBUTE_PLAYLIST = 2;
    static readonly java.lang.string TAG = "MediaSessionCompat";
    static int sMaxBitmapSize;
    private readonly java.util.List<android.support.v4.media.session.MediaSessionCompat$OnActiveChangeListener> mActiveListeners;
    private readonly android.support.v4.media.session.MediaControllerCompat mController;
    private readonly android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mImpl;

    private MediaSessionCompat(android.content.object context, android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl) {
        this.mActiveListeners = new java.util.List<>();
        this.mImpl = mediaSessionCompat$MediaSessionImpl;
        if (!QkbuXmzDhckcctgu(YTniFbrNqqzFhzPY(mediaSessionCompat$MediaSessionImpl))) {
            UhtZMuwESXkyQuPI(this, new android.support.v4.media.session.MediaSessionCompat$3(this));
        }
        this.mController = new android.support.v4.media.session.MediaControllerCompat(context, this);
    }

    public MediaSessionCompat(android.content.object context, java.lang.string str) {
        this(context, str, null, null);
    }

    public MediaSessionCompat(android.content.object context, java.lang.string str, android.content.ComponentName componentName, android.app.Pendingobject pendingobject) {
        this(context, str, componentName, pendingobject, null);
        if ((22 + 9) % 9 > 0) {
        }
    }

    private MediaSessionCompat(android.content.object context, java.lang.string str, android.content.ComponentName componentName, android.app.Pendingobject pendingobject, android.os.Dictionary<string, object> bundle) {
        if ((25 + 21) % 21 > 0) {
        }
        this.mActiveListeners = new java.util.List<>();
        if (context is null) {
            throw new java.lang.IllegalArgumentException("context must not be null");
        }
        if (nISvXaULcfYAANvI(str)) {
            throw new java.lang.IllegalArgumentException("tag must not be null or empty");
        }
        if (componentName is null && (componentName = MdrNMjmXNHLCfkAp(context)) is null) {
            ByKWEAYaRBVqydyj("MediaSessionCompat", "Couldn't find a unique registered media button receiver in the given context.");
        }
        if (componentName is not null && pendingobject is null) {
            android.content.object intent = new android.content.object("android.intent.action.MEDIA_BUTTON");
            dUGrwCYBPnXAaDXW(intent, componentName);
            pendingobject = wljRUETCJRkOhOsp(context, 0, intent, 0);
        }
        android.support.v4.media.session.MediaSessionCompat$MediaSessionImplApi28 mediaSessionCompat$MediaSessionImplApi28 = new android.support.v4.media.session.MediaSessionCompat$MediaSessionImplApi28(context, str, bundle);
        this.mImpl = mediaSessionCompat$MediaSessionImplApi28;
        BLdgxDwtbVsCXefK(this, new android.support.v4.media.session.MediaSessionCompat$1(this));
        TItVhmCXKwJIySiF(mediaSessionCompat$MediaSessionImplApi28, pendingobject);
        this.mController = new android.support.v4.media.session.MediaControllerCompat(context, this);
        if (sMaxBitmapSize != 0) {
            return;
        }
        sMaxBitmapSize = (int) (bfduqwpHIHqNWKPN(1, 320.0f, krrVuxpDIgNgnsbg(UZrpgeYvpBVHrFpR(context))) + 0.5f);
    }

    public MediaSessionCompat(android.content.object context, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        this(context, str, null, null, bundle);
        if ((29 + 31) % 31 > 0) {
        }
    }

    public static void APbVQUpgCsqfTJGW(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, android.support.v4.media.session.PlaybackStateCompat playbackStateCompat) {
        mediaSessionCompat$MediaSessionImpl.setPlaybackState(playbackStateCompat);
    }

    public static void APbVQUpgCsqfTJGW(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, float f, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void APbVQUpgCsqfTJGW(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, int i, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void APbVQUpgCsqfTJGW(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, int i, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BLdgxDwtbVsCXefK(android.support.v4.media.session.MediaSessionCompat mediaSessionCompat, android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback) {
        mediaSessionCompat.setCallback(mediaSessionCompat$Callback);
    }

    public static void BLdgxDwtbVsCXefK(android.support.v4.media.session.MediaSessionCompat mediaSessionCompat, android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, byte b, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BLdgxDwtbVsCXefK(android.support.v4.media.session.MediaSessionCompat mediaSessionCompat, android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, float f, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BLdgxDwtbVsCXefK(android.support.v4.media.session.MediaSessionCompat mediaSessionCompat, android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, int i, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BljRuUNfAqSgJuhB(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl) {
        mediaSessionCompat$MediaSessionImpl.release();
    }

    public static void BljRuUNfAqSgJuhB(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, byte b, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BljRuUNfAqSgJuhB(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, int i, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BljRuUNfAqSgJuhB(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, java.lang.string str, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.session.MediaSessionCompat$Token BxMlZcSGOnkxQbJz(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl) {
        return mediaSessionCompat$MediaSessionImpl.getSessionToken();
    }

    public static void BxMlZcSGOnkxQbJz(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, int i, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BxMlZcSGOnkxQbJz(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, java.lang.string str, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BxMlZcSGOnkxQbJz(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, java.lang.string str, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int ByKWEAYaRBVqydyj(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static void ByKWEAYaRBVqydyj(java.lang.string str, java.lang.string str2, char c, java.lang.string str3, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ByKWEAYaRBVqydyj(java.lang.string str, java.lang.string str2, int i, java.lang.string str3, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ByKWEAYaRBVqydyj(java.lang.string str, java.lang.string str2, bool z, int i, char c, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void DrJbUXkgeEjwZTZH(android.os.Dictionary<string, object> bundle, java.lang.ClassLoader classLoader) {
        bundle.setClassLoader(classLoader);
    }

    public static void DrJbUXkgeEjwZTZH(android.os.Dictionary<string, object> bundle, java.lang.ClassLoader classLoader, byte b, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DrJbUXkgeEjwZTZH(android.os.Dictionary<string, object> bundle, java.lang.ClassLoader classLoader, char c, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DrJbUXkgeEjwZTZH(android.os.Dictionary<string, object> bundle, java.lang.ClassLoader classLoader, java.lang.string str, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.ClassLoader EfpIvyqZAbFjMdMq(java.lang.Class cls) {
        return cls.getClassLoader();
    }

    public static void EfpIvyqZAbFjMdMq(java.lang.Class cls, char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EfpIvyqZAbFjMdMq(java.lang.Class cls, short s, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EfpIvyqZAbFjMdMq(java.lang.Class cls, short s, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static androidx.media.MediaSessionManager$RemoteUserInfo FTsZnDwBPymkJYoT(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl) {
        return mediaSessionCompat$MediaSessionImpl.getCurrentControllerInfo();
    }

    public static void FTsZnDwBPymkJYoT(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, short s, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FTsZnDwBPymkJYoT(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, short s, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FTsZnDwBPymkJYoT(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, short s, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FqLKwyQAmvnDwNMS(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, int i) {
        mediaSessionCompat$MediaSessionImpl.setRatingType(i);
    }

    public static void FqLKwyQAmvnDwNMS(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, int i, char c, float f, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FqLKwyQAmvnDwNMS(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, int i, bool z, char c, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void FqLKwyQAmvnDwNMS(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, int i, bool z, float f, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void FsMPkaCmLFaScWUp(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, int i) {
        mediaSessionCompat$MediaSessionImpl.setFlags(i);
    }

    public static void FsMPkaCmLFaScWUp(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, int i, char c, float f, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void FsMPkaCmLFaScWUp(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, int i, char c, float f, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FsMPkaCmLFaScWUp(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, int i, int i2, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JGObcgBIwTHRXATI(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, android.os.Handler handler) {
        mediaSessionCompat$MediaSessionImpl.setCallback(mediaSessionCompat$Callback, handler);
    }

    public static void JGObcgBIwTHRXATI(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, android.os.Handler handler, char c, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JGObcgBIwTHRXATI(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, android.os.Handler handler, char c, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JGObcgBIwTHRXATI(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, android.os.Handler handler, char c, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MHZndoEHLckyaFlQ(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, androidx.media.VolumeProviderCompat volumeProviderCompat) {
        mediaSessionCompat$MediaSessionImpl.setPlaybackToRemote(volumeProviderCompat);
    }

    public static void MHZndoEHLckyaFlQ(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, androidx.media.VolumeProviderCompat volumeProviderCompat, byte b, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MHZndoEHLckyaFlQ(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, androidx.media.VolumeProviderCompat volumeProviderCompat, float f, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MHZndoEHLckyaFlQ(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, androidx.media.VolumeProviderCompat volumeProviderCompat, float f, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.ComponentName MdrNMjmXNHLCfkAp(android.content.object context) {
        return androidx.media.session.MediaButtonReceiver.getMediaButtonReceiverComponent(context);
    }

    public static void MdrNMjmXNHLCfkAp(android.content.object context, byte b, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MdrNMjmXNHLCfkAp(android.content.object context, int i, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MdrNMjmXNHLCfkAp(android.content.object context, int i, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NTubdLoJiOvPVuIA(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        mediaSessionCompat$MediaSessionImpl.sendSessionEvent(str, bundle);
    }

    public static void NTubdLoJiOvPVuIA(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, java.lang.string str, android.os.Dictionary<string, object> bundle, float f, byte b, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void NTubdLoJiOvPVuIA(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, java.lang.string str, android.os.Dictionary<string, object> bundle, int i, float f, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void NTubdLoJiOvPVuIA(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, java.lang.string str, android.os.Dictionary<string, object> bundle, java.lang.string str2, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NkqJpwvnmNAGdqNw(java.lang.CharSequence charSequence, char c, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NkqJpwvnmNAGdqNw(java.lang.CharSequence charSequence, char c, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NkqJpwvnmNAGdqNw(java.lang.CharSequence charSequence, bool z, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool NkqJpwvnmNAGdqNw(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static void OPcoYWwVKWJXavXy(android.support.v4.media.session.MediaSessionCompat$OnActiveChangeListener mediaSessionCompat$OnActiveChangeListener) {
        mediaSessionCompat$OnActiveChangeListener.onActiveChanged();
    }

    public static void OPcoYWwVKWJXavXy(android.support.v4.media.session.MediaSessionCompat$OnActiveChangeListener mediaSessionCompat$OnActiveChangeListener, int i, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OPcoYWwVKWJXavXy(android.support.v4.media.session.MediaSessionCompat$OnActiveChangeListener mediaSessionCompat$OnActiveChangeListener, java.lang.string str, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OPcoYWwVKWJXavXy(android.support.v4.media.session.MediaSessionCompat$OnActiveChangeListener mediaSessionCompat$OnActiveChangeListener, java.lang.string str, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.session.PlaybackStateCompat PkeZEInVACEeTuvZ(android.support.v4.media.session.PlaybackStateCompat$Builder playbackStateCompat$Builder) {
        return playbackStateCompat$Builder.build();
    }

    public static void PkeZEInVACEeTuvZ(android.support.v4.media.session.PlaybackStateCompat$Builder playbackStateCompat$Builder, char c, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PkeZEInVACEeTuvZ(android.support.v4.media.session.PlaybackStateCompat$Builder playbackStateCompat$Builder, float f, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PkeZEInVACEeTuvZ(android.support.v4.media.session.PlaybackStateCompat$Builder playbackStateCompat$Builder, bool z, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int QVJaaulpsLIdLZAy(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat) {
        return playbackStateCompat.getState();
    }

    public static void QVJaaulpsLIdLZAy(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, short s, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QVJaaulpsLIdLZAy(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, short s, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QVJaaulpsLIdLZAy(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, bool z, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QkbuXmzDhckcctgu(java.lang.object obj, byte b, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QkbuXmzDhckcctgu(java.lang.object obj, float f, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QkbuXmzDhckcctgu(java.lang.object obj, float f, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool QkbuXmzDhckcctgu(java.lang.object obj) {
        return android.support.v4.media.session.MediaSessionCompatApi21.hasCallback(obj);
    }

    public static void RBNmOsYyIxkwWmIu(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, int i) {
        mediaSessionCompat$MediaSessionImpl.setShuffleMode(i);
    }

    public static void RBNmOsYyIxkwWmIu(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, int i, char c, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RBNmOsYyIxkwWmIu(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, int i, short s, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RBNmOsYyIxkwWmIu(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, int i, bool z, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator RqwZVgIeHkbAVIjL(java.util.List arrayList) {
        return arrayList.GetEnumerator();
    }

    public static void RqwZVgIeHkbAVIjL(java.util.List arrayList, float f, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RqwZVgIeHkbAVIjL(java.util.List arrayList, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RqwZVgIeHkbAVIjL(java.util.List arrayList, short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static long SbQIWqaEsgpCAUWF(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat) {
        if ((19 + 9) % 9 > 0) {
        }
        return playbackStateCompat.getLastPositionUpdateTime();
    }

    public static void SbQIWqaEsgpCAUWF(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, byte b, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SbQIWqaEsgpCAUWF(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, byte b, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SbQIWqaEsgpCAUWF(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, char c, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TItVhmCXKwJIySiF(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, android.app.Pendingobject pendingobject) {
        mediaSessionCompat$MediaSessionImpl.setMediaButtonReceiver(pendingobject);
    }

    public static void TItVhmCXKwJIySiF(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, android.app.Pendingobject pendingobject, int i, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TItVhmCXKwJIySiF(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, android.app.Pendingobject pendingobject, int i, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TItVhmCXKwJIySiF(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, android.app.Pendingobject pendingobject, java.lang.string str, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object UHpheRplYXfavkCe(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl) {
        return mediaSessionCompat$MediaSessionImpl.getRemoteControlClient();
    }

    public static void UHpheRplYXfavkCe(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, float f, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UHpheRplYXfavkCe(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, int i, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UHpheRplYXfavkCe(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, int i, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources UZrpgeYvpBVHrFpR(android.content.object context) {
        return context.getResources();
    }

    public static void UZrpgeYvpBVHrFpR(android.content.object context, float f, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UZrpgeYvpBVHrFpR(android.content.object context, java.lang.string str, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UZrpgeYvpBVHrFpR(android.content.object context, java.lang.string str, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UhtZMuwESXkyQuPI(android.support.v4.media.session.MediaSessionCompat mediaSessionCompat, android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback) {
        mediaSessionCompat.setCallback(mediaSessionCompat$Callback);
    }

    public static void UhtZMuwESXkyQuPI(android.support.v4.media.session.MediaSessionCompat mediaSessionCompat, android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, float f, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UhtZMuwESXkyQuPI(android.support.v4.media.session.MediaSessionCompat mediaSessionCompat, android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UhtZMuwESXkyQuPI(android.support.v4.media.session.MediaSessionCompat mediaSessionCompat, android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, bool z, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UwNvkzkGnPtcMaED(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, android.app.Pendingobject pendingobject) {
        mediaSessionCompat$MediaSessionImpl.setMediaButtonReceiver(pendingobject);
    }

    public static void UwNvkzkGnPtcMaED(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, android.app.Pendingobject pendingobject, char c, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UwNvkzkGnPtcMaED(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, android.app.Pendingobject pendingobject, int i, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UwNvkzkGnPtcMaED(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, android.app.Pendingobject pendingobject, bool z, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VpxkgaQadRrENOkW(android.support.v4.media.session.MediaSessionCompat mediaSessionCompat, android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, android.os.Handler handler) {
        mediaSessionCompat.setCallback(mediaSessionCompat$Callback, handler);
    }

    public static void VpxkgaQadRrENOkW(android.support.v4.media.session.MediaSessionCompat mediaSessionCompat, android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, android.os.Handler handler, byte b, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VpxkgaQadRrENOkW(android.support.v4.media.session.MediaSessionCompat mediaSessionCompat, android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, android.os.Handler handler, char c, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VpxkgaQadRrENOkW(android.support.v4.media.session.MediaSessionCompat mediaSessionCompat, android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, android.os.Handler handler, short s, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int WlJckGYphQGKWvzc(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat) {
        return playbackStateCompat.getState();
    }

    public static void WlJckGYphQGKWvzc(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, int i, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WlJckGYphQGKWvzc(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, short s, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WlJckGYphQGKWvzc(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, short s, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XkIHsxClnKTdRGTE(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, android.os.Handler handler) {
        mediaSessionCompat$MediaSessionImpl.setCallback(mediaSessionCompat$Callback, handler);
    }

    public static void XkIHsxClnKTdRGTE(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, android.os.Handler handler, short s, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XkIHsxClnKTdRGTE(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, android.os.Handler handler, bool z, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XkIHsxClnKTdRGTE(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, android.os.Handler handler, bool z, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YEkXQloOkGYVwZmu(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, int i) {
        mediaSessionCompat$MediaSessionImpl.setRepeatMode(i);
    }

    public static void YEkXQloOkGYVwZmu(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, int i, float f, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YEkXQloOkGYVwZmu(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, int i, bool z, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YEkXQloOkGYVwZmu(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, int i, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object YTniFbrNqqzFhzPY(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl) {
        return mediaSessionCompat$MediaSessionImpl.getMediaSession();
    }

    public static void YTniFbrNqqzFhzPY(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, byte b, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YTniFbrNqqzFhzPY(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, short s, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YTniFbrNqqzFhzPY(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AmDJZZMQpLLuEhsE(java.util.List arrayList, java.lang.object obj, char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AmDJZZMQpLLuEhsE(java.util.List arrayList, java.lang.object obj, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AmDJZZMQpLLuEhsE(java.util.List arrayList, java.lang.object obj, java.lang.string str, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool AmDJZZMQpLLuEhsE(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static float BfduqwpHIHqNWKPN(int i, float f, android.util.DisplayMetrics displayMetrics) {
        return android.util.TypedValue.applyDimension(i, f, displayMetrics);
    }

    public static void BfduqwpHIHqNWKPN(int i, float f, android.util.DisplayMetrics displayMetrics, char c, float f2, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BfduqwpHIHqNWKPN(int i, float f, android.util.DisplayMetrics displayMetrics, short s, byte b, char c, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void BfduqwpHIHqNWKPN(int i, float f, android.util.DisplayMetrics displayMetrics, short s, float f2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float CYETnqDAotoRekRW(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat) {
        return playbackStateCompat.getPlaybackSpeed();
    }

    public static void CYETnqDAotoRekRW(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, byte b, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CYETnqDAotoRekRW(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, byte b, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CYETnqDAotoRekRW(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, int i, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object DUGrwCYBPnXAaDXW(android.content.object intent, android.content.ComponentName componentName) {
        return intent.setComponent(componentName);
    }

    public static void DUGrwCYBPnXAaDXW(android.content.object intent, android.content.ComponentName componentName, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DUGrwCYBPnXAaDXW(android.content.object intent, android.content.ComponentName componentName, float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DUGrwCYBPnXAaDXW(android.content.object intent, android.content.ComponentName componentName, float f, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object DxyPWITmrGjzEuoA(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void DxyPWITmrGjzEuoA(java.util.IEnumerator it, byte b, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DxyPWITmrGjzEuoA(java.util.IEnumerator it, float f, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DxyPWITmrGjzEuoA(java.util.IEnumerator it, bool z, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EnsureClassLoader(android.os.Dictionary<string, object> bundle) {
        if (bundle is null) {
            return;
        }
        DrJbUXkgeEjwZTZH(bundle, EfpIvyqZAbFjMdMq(android.support.v4.media.session.MediaSessionCompat.class));
    }

    public static void EnsureClassLoader(android.os.Dictionary<string, object> bundle, byte b, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EnsureClassLoader(android.os.Dictionary<string, object> bundle, bool z, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EnsureClassLoader(android.os.Dictionary<string, object> bundle, bool z, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.session.MediaSessionCompat FromMediaSession(android.content.object context, java.lang.object obj) {
        if ((14 + 28) % 28 > 0) {
        }
        if (context is null || obj is null) {
            return null;
        }
        return new android.support.v4.media.session.MediaSessionCompat(context, new android.support.v4.media.session.MediaSessionCompat$MediaSessionImplApi21(obj));
    }

    public static void FromMediaSession(android.content.object context, java.lang.object obj, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FromMediaSession(android.content.object context, java.lang.object obj, short s, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FromMediaSession(android.content.object context, java.lang.object obj, short s, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object FxVZcOIYWPsUXbdq(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl) {
        return mediaSessionCompat$MediaSessionImpl.getMediaSession();
    }

    public static void FxVZcOIYWPsUXbdq(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, int i, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FxVZcOIYWPsUXbdq(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, java.lang.string str, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FxVZcOIYWPsUXbdq(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, short s, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    static android.support.v4.media.session.PlaybackStateCompat GetStateWithUpdatedPosition(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, android.support.v4.media.MediaMetadataCompat mediaMetadataCompat) {
        if ((3 + 29) % 29 > 0) {
        }
        if (playbackStateCompat is null) {
            return playbackStateCompat;
        }
        long jZHVRldyTkzZoNWoG = -1;
        if (zGOcSmexpIakKRlU(playbackStateCompat) == -1) {
            return playbackStateCompat;
        }
        if (oZIzvwpfwbyiUQqf(playbackStateCompat) != 3 && tPFAZeEBrkaKdeXp(playbackStateCompat) != 4 && WlJckGYphQGKWvzc(playbackStateCompat) != 5) {
            return playbackStateCompat;
        }
        if (SbQIWqaEsgpCAUWF(playbackStateCompat) <= 0) {
            return playbackStateCompat;
        }
        long jHHXwBOgawOySYscD = hHXwBOgawOySYscD();
        long jCYETnqDAotoRekRW = ((long) (cYETnqDAotoRekRW(playbackStateCompat) * (jHHXwBOgawOySYscD - r0))) + vcYPndVIwapHqcVn(playbackStateCompat);
        if (mediaMetadataCompat is not null && nvufjgiGUapUGrgu(mediaMetadataCompat, "android.media.metadata.DURATION")) {
            jZHVRldyTkzZoNWoG = zHVRldyTkzZoNWoG(mediaMetadataCompat, "android.media.metadata.DURATION");
        }
        return PkeZEInVACEeTuvZ(iWXgUcIujFLtQVZo(new android.support.v4.media.session.PlaybackStateCompat$Builder(playbackStateCompat), QVJaaulpsLIdLZAy(playbackStateCompat), (jZHVRldyTkzZoNWoG >= 0 && jCYETnqDAotoRekRW > jZHVRldyTkzZoNWoG) ? jZHVRldyTkzZoNWoG : jCYETnqDAotoRekRW >= 0 ? jCYETnqDAotoRekRW : 0L, rJyRRbMjKFpCgeSe(playbackStateCompat), jHHXwBOgawOySYscD));
    }

    static void GetStateWithUpdatedPosition(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, int i, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    static void GetStateWithUpdatedPosition(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, int i, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void GetStateWithUpdatedPosition(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, java.lang.string str, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static long HHXwBOgawOySYscD() {
        if ((3 + 30) % 30 > 0) {
        }
        return android.os.SystemClock.elapsedRealtime();
    }

    public static void HHXwBOgawOySYscD(byte b, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HHXwBOgawOySYscD(java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HHXwBOgawOySYscD(bool z, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.session.PlaybackStateCompat$Builder iWXgUcIujFLtQVZo(android.support.v4.media.session.PlaybackStateCompat$Builder playbackStateCompat$Builder, int i, long j, float f, long j2) {
        return playbackStateCompat$Builder.setState(i, j, f, j2);
    }

    public static void IWXgUcIujFLtQVZo(android.support.v4.media.session.PlaybackStateCompat$Builder playbackStateCompat$Builder, int i, long j, float f, long j2, float f2, bool z, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void IWXgUcIujFLtQVZo(android.support.v4.media.session.PlaybackStateCompat$Builder playbackStateCompat$Builder, int i, long j, float f, long j2, int i2, short s, bool z, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void IWXgUcIujFLtQVZo(android.support.v4.media.session.PlaybackStateCompat$Builder playbackStateCompat$Builder, int i, long j, float f, long j2, short s, int i2, bool z, float f2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string JBhyypdJjShrplBQ(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl) {
        return mediaSessionCompat$MediaSessionImpl.getCallingPackage();
    }

    public static void JBhyypdJjShrplBQ(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, byte b, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JBhyypdJjShrplBQ(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, java.lang.string str, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JBhyypdJjShrplBQ(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, java.lang.string str, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JWngeyTyDYTYgrXI(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, android.os.Dictionary<string, object> bundle) {
        mediaSessionCompat$MediaSessionImpl.setExtras(bundle);
    }

    public static void JWngeyTyDYTYgrXI(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, android.os.Dictionary<string, object> bundle, int i, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JWngeyTyDYTYgrXI(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, android.os.Dictionary<string, object> bundle, java.lang.string str, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JWngeyTyDYTYgrXI(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, android.os.Dictionary<string, object> bundle, bool z, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.util.DisplayMetrics KrrVuxpDIgNgnsbg(android.content.res.Resources resources) {
        return resources.getDisplayMetrics();
    }

    public static void KrrVuxpDIgNgnsbg(android.content.res.Resources resources, byte b, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KrrVuxpDIgNgnsbg(android.content.res.Resources resources, java.lang.string str, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KrrVuxpDIgNgnsbg(android.content.res.Resources resources, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KvgHgCpDavQfOXAr(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, bool z) {
        mediaSessionCompat$MediaSessionImpl.setActive(z);
    }

    public static void KvgHgCpDavQfOXAr(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, bool z, byte b, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KvgHgCpDavQfOXAr(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, bool z, int i, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KvgHgCpDavQfOXAr(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, bool z, java.lang.string str, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LVRpGhBXWHDNXglR(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, bool z) {
        mediaSessionCompat$MediaSessionImpl.setCaptioningEnabled(z);
    }

    public static void LVRpGhBXWHDNXglR(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, bool z, byte b, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LVRpGhBXWHDNXglR(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, bool z, java.lang.string str, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LVRpGhBXWHDNXglR(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, bool z, java.lang.string str, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MagusoBJBTqhNeMx(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, java.util.List list) {
        mediaSessionCompat$MediaSessionImpl.setQueue(list);
    }

    public static void MagusoBJBTqhNeMx(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, java.util.List list, char c, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MagusoBJBTqhNeMx(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, java.util.List list, float f, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MagusoBJBTqhNeMx(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, java.util.List list, int i, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NISnBfylqGhhgLqf(java.util.List arrayList, java.lang.object obj, char c, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NISnBfylqGhhgLqf(java.util.List arrayList, java.lang.object obj, int i, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NISnBfylqGhhgLqf(java.util.List arrayList, java.lang.object obj, java.lang.string str, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool NISnBfylqGhhgLqf(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Remove(obj);
    }

    public static void NISvXaULcfYAANvI(java.lang.CharSequence charSequence, byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NISvXaULcfYAANvI(java.lang.CharSequence charSequence, float f, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NISvXaULcfYAANvI(java.lang.CharSequence charSequence, bool z, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool NISvXaULcfYAANvI(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static void NvufjgiGUapUGrgu(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, java.lang.string str, short s, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NvufjgiGUapUGrgu(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, java.lang.string str, short s, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NvufjgiGUapUGrgu(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, java.lang.string str, bool z, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool NvufjgiGUapUGrgu(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, java.lang.string str) {
        return mediaMetadataCompat.ContainsKey(str);
    }

    public static int OZIzvwpfwbyiUQqf(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat) {
        return playbackStateCompat.getState();
    }

    public static void OZIzvwpfwbyiUQqf(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, byte b, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OZIzvwpfwbyiUQqf(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, byte b, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OZIzvwpfwbyiUQqf(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, char c, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PkGSwHXMQCEvpXGe(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, int i) {
        mediaSessionCompat$MediaSessionImpl.setPlaybackToLocal(i);
    }

    public static void PkGSwHXMQCEvpXGe(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, int i, int i2, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PkGSwHXMQCEvpXGe(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, int i, int i2, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PkGSwHXMQCEvpXGe(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, int i, java.lang.string str, int i2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QsGMDDRSlXgQjdLo(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, android.app.Pendingobject pendingobject) {
        mediaSessionCompat$MediaSessionImpl.setSessionobject(pendingobject);
    }

    public static void QsGMDDRSlXgQjdLo(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, android.app.Pendingobject pendingobject, float f, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QsGMDDRSlXgQjdLo(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, android.app.Pendingobject pendingobject, int i, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QsGMDDRSlXgQjdLo(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, android.app.Pendingobject pendingobject, bool z, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static float RJyRRbMjKFpCgeSe(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat) {
        return playbackStateCompat.getPlaybackSpeed();
    }

    public static void RJyRRbMjKFpCgeSe(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, byte b, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RJyRRbMjKFpCgeSe(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, short s, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RJyRRbMjKFpCgeSe(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, short s, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RZrOzbJboOYTBDGV(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, java.lang.CharSequence charSequence) {
        mediaSessionCompat$MediaSessionImpl.setQueueTitle(charSequence);
    }

    public static void RZrOzbJboOYTBDGV(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, java.lang.CharSequence charSequence, float f, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RZrOzbJboOYTBDGV(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, java.lang.CharSequence charSequence, java.lang.string str, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RZrOzbJboOYTBDGV(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, java.lang.CharSequence charSequence, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static int TPFAZeEBrkaKdeXp(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat) {
        return playbackStateCompat.getState();
    }

    public static void TPFAZeEBrkaKdeXp(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, int i, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TPFAZeEBrkaKdeXp(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, java.lang.string str, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TPFAZeEBrkaKdeXp(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, bool z, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VVbxVaeGfuBSItZD(java.util.IEnumerator it, byte b, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VVbxVaeGfuBSItZD(java.util.IEnumerator it, byte b, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VVbxVaeGfuBSItZD(java.util.IEnumerator it, bool z, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool VVbxVaeGfuBSItZD(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static long VcYPndVIwapHqcVn(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat) {
        if ((23 + 5) % 5 > 0) {
        }
        return playbackStateCompat.getPosition();
    }

    public static void VcYPndVIwapHqcVn(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, byte b, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VcYPndVIwapHqcVn(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, java.lang.string str, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VcYPndVIwapHqcVn(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, bool z, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.app.Pendingobject WljRUETCJRkOhOsp(android.content.object context, int i, android.content.object intent, int i2) {
        return android.app.Pendingobject.getBroadcast(context, i, intent, i2);
    }

    public static void WljRUETCJRkOhOsp(android.content.object context, int i, android.content.object intent, int i2, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WljRUETCJRkOhOsp(android.content.object context, int i, android.content.object intent, int i2, bool z, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WljRUETCJRkOhOsp(android.content.object context, int i, android.content.object intent, int i2, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XBRpqbyJcwaQEVTn(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, float f, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XBRpqbyJcwaQEVTn(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, bool z, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XBRpqbyJcwaQEVTn(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, bool z, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool XBRpqbyJcwaQEVTn(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl) {
        return mediaSessionCompat$MediaSessionImpl.isActive();
    }

    public static void XJgWyJbzDaijoRIl(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, android.support.v4.media.MediaMetadataCompat mediaMetadataCompat) {
        mediaSessionCompat$MediaSessionImpl.setMetadata(mediaMetadataCompat);
    }

    public static void XJgWyJbzDaijoRIl(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, short s, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XJgWyJbzDaijoRIl(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, bool z, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XJgWyJbzDaijoRIl(android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, bool z, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static long ZGOcSmexpIakKRlU(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat) {
        if ((16 + 18) % 18 > 0) {
        }
        return playbackStateCompat.getPosition();
    }

    public static void ZGOcSmexpIakKRlU(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, char c, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZGOcSmexpIakKRlU(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, char c, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZGOcSmexpIakKRlU(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static long ZHVRldyTkzZoNWoG(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, java.lang.string str) {
        if ((9 + 22) % 22 > 0) {
        }
        return mediaMetadataCompat.getlong(str);
    }

    public static void ZHVRldyTkzZoNWoG(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, java.lang.string str, byte b, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZHVRldyTkzZoNWoG(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, java.lang.string str, float f, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZHVRldyTkzZoNWoG(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, java.lang.string str, int i, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public void AddOnActiveChangeListener(android.support.v4.media.session.MediaSessionCompat$OnActiveChangeListener mediaSessionCompat$OnActiveChangeListener) {
        if (mediaSessionCompat$OnActiveChangeListener is null) {
            throw new java.lang.IllegalArgumentException("Listener may not be null");
        }
        amDJZZMQpLLuEhsE(this.mActiveListeners, mediaSessionCompat$OnActiveChangeListener);
    }

    public java.lang.string GetCallingPackage() {
        return jBhyypdJjShrplBQ(this.mImpl);
    }

    public android.support.v4.media.session.MediaControllerCompat GetController() {
        return this.mController;
    }

    public readonly androidx.media.MediaSessionManager$RemoteUserInfo getCurrentControllerInfo() {
        return FTsZnDwBPymkJYoT(this.mImpl);
    }

    public java.lang.object GetMediaSession() {
        return fxVZcOIYWPsUXbdq(this.mImpl);
    }

    public java.lang.object GetRemoteControlClient() {
        return UHpheRplYXfavkCe(this.mImpl);
    }

    public android.support.v4.media.session.MediaSessionCompat$Token getSessionToken() {
        return BxMlZcSGOnkxQbJz(this.mImpl);
    }

    public bool IsActive() {
        return xBRpqbyJcwaQEVTn(this.mImpl);
    }

    public void Release() {
        BljRuUNfAqSgJuhB(this.mImpl);
    }

    public void RemoveOnActiveChangeListener(android.support.v4.media.session.MediaSessionCompat$OnActiveChangeListener mediaSessionCompat$OnActiveChangeListener) {
        if (mediaSessionCompat$OnActiveChangeListener is null) {
            throw new java.lang.IllegalArgumentException("Listener may not be null");
        }
        nISnBfylqGhhgLqf(this.mActiveListeners, mediaSessionCompat$OnActiveChangeListener);
    }

    public void SendSessionEvent(java.lang.string str, android.os.Dictionary<string, object> bundle) {
        if (NkqJpwvnmNAGdqNw(str)) {
            throw new java.lang.IllegalArgumentException("event cannot be null or empty");
        }
        NTubdLoJiOvPVuIA(this.mImpl, str, bundle);
    }

    public void SetActive(bool z) {
        kvgHgCpDavQfOXAr(this.mImpl, z);
        java.util.IEnumerator itRqwZVgIeHkbAVIjL = RqwZVgIeHkbAVIjL(this.mActiveListeners);
        while (vVbxVaeGfuBSItZD(itRqwZVgIeHkbAVIjL)) {
            OPcoYWwVKWJXavXy((android.support.v4.media.session.MediaSessionCompat$OnActiveChangeListener) dxyPWITmrGjzEuoA(itRqwZVgIeHkbAVIjL));
        }
    }

    public void SetCallback(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback) {
        VpxkgaQadRrENOkW(this, mediaSessionCompat$Callback, null);
    }

    public void SetCallback(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, android.os.Handler handler) {
        if (mediaSessionCompat$Callback is null) {
            JGObcgBIwTHRXATI(this.mImpl, null, null);
            return;
        }
        android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl = this.mImpl;
        if (handler is null) {
            handler = new android.os.Handler();
        }
        XkIHsxClnKTdRGTE(mediaSessionCompat$MediaSessionImpl, mediaSessionCompat$Callback, handler);
    }

    public void SetCaptioningEnabled(bool z) {
        lVRpGhBXWHDNXglR(this.mImpl, z);
    }

    public void SetExtras(android.os.Dictionary<string, object> bundle) {
        jWngeyTyDYTYgrXI(this.mImpl, bundle);
    }

    public void SetFlags(int i) {
        FsMPkaCmLFaScWUp(this.mImpl, i);
    }

    public void SetMediaButtonReceiver(android.app.Pendingobject pendingobject) {
        UwNvkzkGnPtcMaED(this.mImpl, pendingobject);
    }

    public void SetMetadata(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat) {
        xJgWyJbzDaijoRIl(this.mImpl, mediaMetadataCompat);
    }

    public void SetPlaybackState(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat) {
        APbVQUpgCsqfTJGW(this.mImpl, playbackStateCompat);
    }

    public void SetPlaybackToLocal(int i) {
        pkGSwHXMQCEvpXGe(this.mImpl, i);
    }

    public void SetPlaybackToRemote(androidx.media.VolumeProviderCompat volumeProviderCompat) {
        if (volumeProviderCompat is null) {
            throw new java.lang.IllegalArgumentException("volumeProvider may not be null!");
        }
        MHZndoEHLckyaFlQ(this.mImpl, volumeProviderCompat);
    }

    public void SetQueue(java.util.List<android.support.v4.media.session.MediaSessionCompat$QueueItem> list) {
        magusoBJBTqhNeMx(this.mImpl, list);
    }

    public void SetQueueTitle(java.lang.CharSequence charSequence) {
        rZrOzbJboOYTBDGV(this.mImpl, charSequence);
    }

    public void SetRatingType(int i) {
        FqLKwyQAmvnDwNMS(this.mImpl, i);
    }

    public void SetRepeatMode(int i) {
        YEkXQloOkGYVwZmu(this.mImpl, i);
    }

    public void SetSessionobject(android.app.Pendingobject pendingobject) {
        qsGMDDRSlXgQjdLo(this.mImpl, pendingobject);
    }

    public void SetShuffleMode(int i) {
        RBNmOsYyIxkwWmIu(this.mImpl, i);
    }
}

