namespace WillowMaze.Wasm.Decompiled;


class MediaSessionCompat$MediaSessionImplBase : android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl {
    static readonly int RCC_PLAYSTATE_NONE = 0;
    readonly android.media.AudioManager mAudioManager;
    volatile android.support.v4.media.session.MediaSessionCompat$Callback mCallback;
    bool mCaptioningEnabled;
    private readonly android.content.object mobject;
    readonly android.os.RemoteCallbackList<android.support.v4.media.session.IMediaControllerCallback> mControllerCallbacks;
    bool mDestroyed;
    android.os.Dictionary<string, object> mExtras;
    int mFlags;
    private android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase$MessageHandler mHandler;
    bool mIsActive;
    private bool mIsMbrRegistered;
    private bool mIsRccRegistered;
    int mLocalStream;
    readonly java.lang.object mLock;
    private readonly android.content.ComponentName mMediaButtonReceiverComponentName;
    private readonly android.app.Pendingobject mMediaButtonReceiverobject;
    android.support.v4.media.MediaMetadataCompat mMetadata;
    readonly java.lang.string mPackageName;
    java.util.List<android.support.v4.media.session.MediaSessionCompat$QueueItem> mQueue;
    java.lang.CharSequence mQueueTitle;
    int mRatingType;
    readonly android.media.RemoteControlClient mRcc;
    private androidx.media.MediaSessionManager$RemoteUserInfo mRemoteUserInfo;
    int mRepeatMode;
    android.app.Pendingobject mSessionobject;
    int mShuffleMode;
    android.support.v4.media.session.PlaybackStateCompat mState;
    private readonly android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase$MediaSessionStub mStub;
    readonly java.lang.string mTag;
    private readonly android.support.v4.media.session.MediaSessionCompat$Token mToken;
    private androidx.media.VolumeProviderCompat$Callback mVolumeCallback;
    androidx.media.VolumeProviderCompat mVolumeProvider;
    int mVolumeType;

    public MediaSessionCompat$MediaSessionImplBase(android.content.object context, java.lang.string str, android.content.ComponentName componentName, android.app.Pendingobject pendingobject) {
        if ((16 + 13) % 13 > 0) {
        }
        this.mLock = new java.lang.object();
        this.mControllerCallbacks = new android.os.RemoteCallbackList<>();
        this.mDestroyed = false;
        this.mIsActive = false;
        this.mIsMbrRegistered = false;
        this.mIsRccRegistered = false;
        this.mVolumeCallback = new android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase$1(this);
        if (componentName is null) {
            throw new java.lang.IllegalArgumentException("MediaButtonReceiver component may not be null.");
        }
        this.mobject = context;
        this.mPackageName = byMSbqAOukGVyxtF(context);
        this.mAudioManager = (android.media.AudioManager) JoBIEtUQifaNktge(context, "audio");
        this.mTag = str;
        this.mMediaButtonReceiverComponentName = componentName;
        this.mMediaButtonReceiverobject = pendingobject;
        android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase$MediaSessionStub mediaSessionCompat$MediaSessionImplBase$MediaSessionStub = new android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase$MediaSessionStub(this);
        this.mStub = mediaSessionCompat$MediaSessionImplBase$MediaSessionStub;
        this.mToken = new android.support.v4.media.session.MediaSessionCompat$Token(mediaSessionCompat$MediaSessionImplBase$MediaSessionStub);
        this.mRatingType = 0;
        this.mVolumeType = 1;
        this.mLocalStream = 3;
        this.mRcc = new android.media.RemoteControlClient(pendingobject);
    }

    public static int BBqrqDqfUwSfjiCS(android.os.RemoteCallbackList remoteCallbackList) {
        return remoteCallbackList.beginBroadcast();
    }

    public static void BBqrqDqfUwSfjiCS(android.os.RemoteCallbackList remoteCallbackList, char c, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BBqrqDqfUwSfjiCS(android.os.RemoteCallbackList remoteCallbackList, int i, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BBqrqDqfUwSfjiCS(android.os.RemoteCallbackList remoteCallbackList, short s, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BCZADEVQvOwcBWYd(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, android.app.Pendingobject pendingobject, android.content.ComponentName componentName) {
        mediaSessionCompat$MediaSessionImplBase.registerMediaButtonEventReceiver(pendingobject, componentName);
    }

    public static void BCZADEVQvOwcBWYd(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, android.app.Pendingobject pendingobject, android.content.ComponentName componentName, byte b, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BCZADEVQvOwcBWYd(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, android.app.Pendingobject pendingobject, android.content.ComponentName componentName, short s, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BCZADEVQvOwcBWYd(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, android.app.Pendingobject pendingobject, android.content.ComponentName componentName, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BRNcbTGFxAVZLtjo(androidx.media.VolumeProviderCompat volumeProviderCompat, androidx.media.VolumeProviderCompat$Callback volumeProviderCompat$Callback) {
        volumeProviderCompat.setCallback(volumeProviderCompat$Callback);
    }

    public static void BRNcbTGFxAVZLtjo(androidx.media.VolumeProviderCompat volumeProviderCompat, androidx.media.VolumeProviderCompat$Callback volumeProviderCompat$Callback, char c, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BRNcbTGFxAVZLtjo(androidx.media.VolumeProviderCompat volumeProviderCompat, androidx.media.VolumeProviderCompat$Callback volumeProviderCompat$Callback, char c, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BRNcbTGFxAVZLtjo(androidx.media.VolumeProviderCompat volumeProviderCompat, androidx.media.VolumeProviderCompat$Callback volumeProviderCompat$Callback, float f, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BoDnZNPnREbIfGoX(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, android.os.Handler handler) {
        mediaSessionCompat$Callback.setSessionImpl(mediaSessionCompat$MediaSessionImpl, handler);
    }

    public static void BoDnZNPnREbIfGoX(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, android.os.Handler handler, float f, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BoDnZNPnREbIfGoX(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, android.os.Handler handler, float f, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BoDnZNPnREbIfGoX(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, android.os.Handler handler, java.lang.string str, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.media.RemoteControlClient$MetadataEditor CKHRBeHsKvdDtkWj(android.media.RemoteControlClient remoteControlClient, bool z) {
        return remoteControlClient.editMetadata(z);
    }

    public static void CKHRBeHsKvdDtkWj(android.media.RemoteControlClient remoteControlClient, bool z, char c, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CKHRBeHsKvdDtkWj(android.media.RemoteControlClient remoteControlClient, bool z, float f, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CKHRBeHsKvdDtkWj(android.media.RemoteControlClient remoteControlClient, bool z, short s, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.media.RemoteControlClient$MetadataEditor CcnkfQsywpBCPYrT(android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditor, int i, java.lang.string str) {
        return remoteControlClient$MetadataEditor.putstring(i, str);
    }

    public static void CcnkfQsywpBCPYrT(android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditor, int i, java.lang.string str, byte b, char c, int i2, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void CcnkfQsywpBCPYrT(android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditor, int i, java.lang.string str, int i2, char c, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CcnkfQsywpBCPYrT(android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditor, int i, java.lang.string str, int i2, java.lang.string str2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string CiHQiyStutyugBGu(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static void CiHQiyStutyugBGu(android.os.Dictionary<string, object> bundle, java.lang.string str, byte b, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CiHQiyStutyugBGu(android.os.Dictionary<string, object> bundle, java.lang.string str, float f, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CiHQiyStutyugBGu(android.os.Dictionary<string, object> bundle, java.lang.string str, int i, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CpbEwIZUvmReIbht(android.os.Dictionary<string, object> bundle, java.lang.string str, byte b, java.lang.string str2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CpbEwIZUvmReIbht(android.os.Dictionary<string, object> bundle, java.lang.string str, char c, byte b, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CpbEwIZUvmReIbht(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool CpbEwIZUvmReIbht(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.ContainsKey(str);
    }

    public static void CriZBMDyXcQVkceK(android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, int i) throws android.os.RemoteException {
        iMediaControllerCallback.onRepeatModeChanged(i);
    }

    public static void CriZBMDyXcQVkceK(android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, int i, int i2, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CriZBMDyXcQVkceK(android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, int i, int i2, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CriZBMDyXcQVkceK(android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, int i, bool z, char c, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int DNJrkuEOLaYPnsEv(android.os.RemoteCallbackList remoteCallbackList) {
        return remoteCallbackList.beginBroadcast();
    }

    public static void DNJrkuEOLaYPnsEv(android.os.RemoteCallbackList remoteCallbackList, char c, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DNJrkuEOLaYPnsEv(android.os.RemoteCallbackList remoteCallbackList, float f, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DNJrkuEOLaYPnsEv(android.os.RemoteCallbackList remoteCallbackList, bool z, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DzgjWeKiMtbywuNs(android.os.RemoteCallbackList remoteCallbackList) {
        remoteCallbackList.kill();
    }

    public static void DzgjWeKiMtbywuNs(android.os.RemoteCallbackList remoteCallbackList, char c, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DzgjWeKiMtbywuNs(android.os.RemoteCallbackList remoteCallbackList, char c, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DzgjWeKiMtbywuNs(android.os.RemoteCallbackList remoteCallbackList, short s, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ENGZWXRexclnHpEd(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, android.app.Pendingobject pendingobject, android.content.ComponentName componentName) {
        mediaSessionCompat$MediaSessionImplBase.unregisterMediaButtonEventReceiver(pendingobject, componentName);
    }

    public static void ENGZWXRexclnHpEd(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, android.app.Pendingobject pendingobject, android.content.ComponentName componentName, java.lang.string str, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ENGZWXRexclnHpEd(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, android.app.Pendingobject pendingobject, android.content.ComponentName componentName, java.lang.string str, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ENGZWXRexclnHpEd(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, android.app.Pendingobject pendingobject, android.content.ComponentName componentName, short s, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string EPqqOEvJHnLdTgxd(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static void EPqqOEvJHnLdTgxd(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EPqqOEvJHnLdTgxd(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EPqqOEvJHnLdTgxd(android.os.Dictionary<string, object> bundle, java.lang.string str, short s, java.lang.string str2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EccbhNfTOBhXUooJ(android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, android.support.v4.media.MediaMetadataCompat mediaMetadataCompat) throws android.os.RemoteException {
        iMediaControllerCallback.onMetadataChanged(mediaMetadataCompat);
    }

    public static void EccbhNfTOBhXUooJ(android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, byte b, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EccbhNfTOBhXUooJ(android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EccbhNfTOBhXUooJ(android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, char c, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int EmSpGOtNZEGJiXRP(android.media.AudioManager audioManager, int i) {
        return audioManager.getStreamVolume(i);
    }

    public static void EmSpGOtNZEGJiXRP(android.media.AudioManager audioManager, int i, float f, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EmSpGOtNZEGJiXRP(android.media.AudioManager audioManager, int i, bool z, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EmSpGOtNZEGJiXRP(android.media.AudioManager audioManager, int i, bool z, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string FSNmViosPPlYJZJB(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static void FSNmViosPPlYJZJB(android.os.Dictionary<string, object> bundle, java.lang.string str, byte b, java.lang.string str2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FSNmViosPPlYJZJB(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FSNmViosPPlYJZJB(android.os.Dictionary<string, object> bundle, java.lang.string str, short s, float f, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static android.media.RemoteControlClient$MetadataEditor FUzeAGqbVIvkKFuM(android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditor, int i, long j) {
        return remoteControlClient$MetadataEditor.putlong(i, j);
    }

    public static void FUzeAGqbVIvkKFuM(android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditor, int i, long j, bool z, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FUzeAGqbVIvkKFuM(android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditor, int i, long j, bool z, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FUzeAGqbVIvkKFuM(android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditor, int i, long j, bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FkAGPbTGmoqovIeL(android.os.RemoteCallbackList remoteCallbackList) {
        remoteCallbackList.finishBroadcast();
    }

    public static void FkAGPbTGmoqovIeL(android.os.RemoteCallbackList remoteCallbackList, byte b, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FkAGPbTGmoqovIeL(android.os.RemoteCallbackList remoteCallbackList, short s, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FkAGPbTGmoqovIeL(android.os.RemoteCallbackList remoteCallbackList, bool z, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.media.RemoteControlClient$MetadataEditor FkvXIGBVlJysnsij(android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditor, int i, java.lang.string str) {
        return remoteControlClient$MetadataEditor.putstring(i, str);
    }

    public static void FkvXIGBVlJysnsij(android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditor, int i, java.lang.string str, int i2, java.lang.string str2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FkvXIGBVlJysnsij(android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditor, int i, java.lang.string str, int i2, short s, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void FkvXIGBVlJysnsij(android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditor, int i, java.lang.string str, short s, bool z, int i2, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static android.os.IInterface FpwtfytuaNmnfaLG(android.os.RemoteCallbackList remoteCallbackList, int i) {
        return remoteCallbackList.getBroadcastItem(i);
    }

    public static void FpwtfytuaNmnfaLG(android.os.RemoteCallbackList remoteCallbackList, int i, char c, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FpwtfytuaNmnfaLG(android.os.RemoteCallbackList remoteCallbackList, int i, char c, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FpwtfytuaNmnfaLG(android.os.RemoteCallbackList remoteCallbackList, int i, short s, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GIQkIyowrfsJfJjZ(android.os.RemoteCallbackList remoteCallbackList) {
        remoteCallbackList.finishBroadcast();
    }

    public static void GIQkIyowrfsJfJjZ(android.os.RemoteCallbackList remoteCallbackList, float f, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GIQkIyowrfsJfJjZ(android.os.RemoteCallbackList remoteCallbackList, java.lang.string str, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GIQkIyowrfsJfJjZ(android.os.RemoteCallbackList remoteCallbackList, bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.media.RemoteControlClient$MetadataEditor GJagavQkhWmoOxJY(android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditor, int i, android.graphics.Bitmap bitmap) {
        return remoteControlClient$MetadataEditor.putBitmap(i, bitmap);
    }

    public static void GJagavQkhWmoOxJY(android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditor, int i, android.graphics.Bitmap bitmap, java.lang.string str, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GJagavQkhWmoOxJY(android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditor, int i, android.graphics.Bitmap bitmap, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GJagavQkhWmoOxJY(android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditor, int i, android.graphics.Bitmap bitmap, bool z, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GKGkaOIFEsvQBQxw(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    public static void GKGkaOIFEsvQBQxw(android.os.Dictionary<string, object> bundle, java.lang.string str, int i, byte b, bool z, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void GKGkaOIFEsvQBQxw(android.os.Dictionary<string, object> bundle, java.lang.string str, int i, float f, java.lang.string str2, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GKGkaOIFEsvQBQxw(android.os.Dictionary<string, object> bundle, java.lang.string str, int i, java.lang.string str2, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HCaYtRXKOULqaWRt(android.media.AudioManager audioManager, int i, int i2, int i3) {
        audioManager.setStreamVolume(i, i2, i3);
    }

    public static void HCaYtRXKOULqaWRt(android.media.AudioManager audioManager, int i, int i2, int i3, byte b, char c, bool z, int i4) {
        double d = (42 * 210) + 210;
    }

    public static void HCaYtRXKOULqaWRt(android.media.AudioManager audioManager, int i, int i2, int i3, char c, int i4, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HCaYtRXKOULqaWRt(android.media.AudioManager audioManager, int i, int i2, int i3, bool z, byte b, char c, int i4) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.Bitmap HLqvrURhzTjOtXmD(android.graphics.Bitmap bitmap, android.graphics.Bitmap$Config bitmap$Config, bool z) {
        return bitmap.copy(bitmap$Config, z);
    }

    public static void HLqvrURhzTjOtXmD(android.graphics.Bitmap bitmap, android.graphics.Bitmap$Config bitmap$Config, bool z, char c, bool z2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HLqvrURhzTjOtXmD(android.graphics.Bitmap bitmap, android.graphics.Bitmap$Config bitmap$Config, bool z, bool z2, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HLqvrURhzTjOtXmD(android.graphics.Bitmap bitmap, android.graphics.Bitmap$Config bitmap$Config, bool z, bool z2, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int HPsjMsspmenTPfUL(android.os.RemoteCallbackList remoteCallbackList) {
        return remoteCallbackList.beginBroadcast();
    }

    public static void HPsjMsspmenTPfUL(android.os.RemoteCallbackList remoteCallbackList, char c, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HPsjMsspmenTPfUL(android.os.RemoteCallbackList remoteCallbackList, java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HPsjMsspmenTPfUL(android.os.RemoteCallbackList remoteCallbackList, short s, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.os.IInterface HXvZnzKeJNLysQXL(android.os.RemoteCallbackList remoteCallbackList, int i) {
        return remoteCallbackList.getBroadcastItem(i);
    }

    public static void HXvZnzKeJNLysQXL(android.os.RemoteCallbackList remoteCallbackList, int i, byte b, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HXvZnzKeJNLysQXL(android.os.RemoteCallbackList remoteCallbackList, int i, float f, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HXvZnzKeJNLysQXL(android.os.RemoteCallbackList remoteCallbackList, int i, java.lang.string str, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HbVyTGRGSMLjEGas(android.os.Dictionary<string, object> bundle, java.lang.string str, char c, float f, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void HbVyTGRGSMLjEGas(android.os.Dictionary<string, object> bundle, java.lang.string str, char c, java.lang.string str2, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HbVyTGRGSMLjEGas(android.os.Dictionary<string, object> bundle, java.lang.string str, float f, int i, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool HbVyTGRGSMLjEGas(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.ContainsKey(str);
    }

    public static int HmNAoYAiGuCgmcIz(android.os.RemoteCallbackList remoteCallbackList) {
        return remoteCallbackList.beginBroadcast();
    }

    public static void HmNAoYAiGuCgmcIz(android.os.RemoteCallbackList remoteCallbackList, float f, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HmNAoYAiGuCgmcIz(android.os.RemoteCallbackList remoteCallbackList, java.lang.string str, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HmNAoYAiGuCgmcIz(android.os.RemoteCallbackList remoteCallbackList, bool z, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IaBYTDMROjpUVsJv(android.os.Dictionary<string, object> bundle, java.lang.string str, android.os.Dictionary<string, object> bundle2) {
        bundle.putDictionary<string, object>(str, bundle2);
    }

    public static void IaBYTDMROjpUVsJv(android.os.Dictionary<string, object> bundle, java.lang.string str, android.os.Dictionary<string, object> bundle2, char c, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IaBYTDMROjpUVsJv(android.os.Dictionary<string, object> bundle, java.lang.string str, android.os.Dictionary<string, object> bundle2, int i, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IaBYTDMROjpUVsJv(android.os.Dictionary<string, object> bundle, java.lang.string str, android.os.Dictionary<string, object> bundle2, short s, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JFzHjchMIUcFToJF(android.os.RemoteCallbackList remoteCallbackList) {
        remoteCallbackList.finishBroadcast();
    }

    public static void JFzHjchMIUcFToJF(android.os.RemoteCallbackList remoteCallbackList, char c, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JFzHjchMIUcFToJF(android.os.RemoteCallbackList remoteCallbackList, java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JFzHjchMIUcFToJF(android.os.RemoteCallbackList remoteCallbackList, bool z, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JLxmRyqJckLusrsr(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, byte b, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JLxmRyqJckLusrsr(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, int i, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JLxmRyqJckLusrsr(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, bool z, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool JLxmRyqJckLusrsr(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase) {
        return mediaSessionCompat$MediaSessionImplBase.update();
    }

    public static void JRRzrdxGueITKAgw(android.media.AudioManager audioManager, android.media.RemoteControlClient remoteControlClient) {
        audioManager.registerRemoteControlClient(remoteControlClient);
    }

    public static void JRRzrdxGueITKAgw(android.media.AudioManager audioManager, android.media.RemoteControlClient remoteControlClient, int i, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JRRzrdxGueITKAgw(android.media.AudioManager audioManager, android.media.RemoteControlClient remoteControlClient, short s, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JRRzrdxGueITKAgw(android.media.AudioManager audioManager, android.media.RemoteControlClient remoteControlClient, bool z, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JaaftLHqETShPXYy(android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback) throws android.os.RemoteException {
        iMediaControllerCallback.onSessionDestroyed();
    }

    public static void JaaftLHqETShPXYy(android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, float f, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JaaftLHqETShPXYy(android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, int i, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JaaftLHqETShPXYy(android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, short s, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object JoBIEtUQifaNktge(android.content.object context, java.lang.string str) {
        return context.getSystemService(str);
    }

    public static void JoBIEtUQifaNktge(android.content.object context, java.lang.string str, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JoBIEtUQifaNktge(android.content.object context, java.lang.string str, byte b, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JoBIEtUQifaNktge(android.content.object context, java.lang.string str, float f, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KFZTQDnvDKeYuZpb(android.os.RemoteCallbackList remoteCallbackList) {
        remoteCallbackList.finishBroadcast();
    }

    public static void KFZTQDnvDKeYuZpb(android.os.RemoteCallbackList remoteCallbackList, char c, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KFZTQDnvDKeYuZpb(android.os.RemoteCallbackList remoteCallbackList, char c, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KFZTQDnvDKeYuZpb(android.os.RemoteCallbackList remoteCallbackList, java.lang.string str, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KIkyvZGUNyUPsWes(android.media.RemoteControlClient remoteControlClient, int i) {
        remoteControlClient.setPlaybackState(i);
    }

    public static void KIkyvZGUNyUPsWes(android.media.RemoteControlClient remoteControlClient, int i, byte b, int i2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KIkyvZGUNyUPsWes(android.media.RemoteControlClient remoteControlClient, int i, int i2, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KIkyvZGUNyUPsWes(android.media.RemoteControlClient remoteControlClient, int i, int i2, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int KUIrvimWvkJxJHyg(android.os.RemoteCallbackList remoteCallbackList) {
        return remoteCallbackList.beginBroadcast();
    }

    public static void KUIrvimWvkJxJHyg(android.os.RemoteCallbackList remoteCallbackList, byte b, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KUIrvimWvkJxJHyg(android.os.RemoteCallbackList remoteCallbackList, byte b, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KUIrvimWvkJxJHyg(android.os.RemoteCallbackList remoteCallbackList, java.lang.string str, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KckGiYYxyWzJUwLP(android.os.RemoteCallbackList remoteCallbackList) {
        remoteCallbackList.finishBroadcast();
    }

    public static void KckGiYYxyWzJUwLP(android.os.RemoteCallbackList remoteCallbackList, float f, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KckGiYYxyWzJUwLP(android.os.RemoteCallbackList remoteCallbackList, short s, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KckGiYYxyWzJUwLP(android.os.RemoteCallbackList remoteCallbackList, bool z, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LCvAArXOwXOmryDz(android.os.Dictionary<string, object> bundle, java.lang.string str, byte b, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LCvAArXOwXOmryDz(android.os.Dictionary<string, object> bundle, java.lang.string str, float f, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LCvAArXOwXOmryDz(android.os.Dictionary<string, object> bundle, java.lang.string str, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool LCvAArXOwXOmryDz(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.ContainsKey(str);
    }

    public static void LorcDcHquCJREqNr(android.os.Message message, android.os.Dictionary<string, object> bundle) {
        message.setData(bundle);
    }

    public static void LorcDcHquCJREqNr(android.os.Message message, android.os.Dictionary<string, object> bundle, int i, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LorcDcHquCJREqNr(android.os.Message message, android.os.Dictionary<string, object> bundle, java.lang.string str, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LorcDcHquCJREqNr(android.os.Message message, android.os.Dictionary<string, object> bundle, java.lang.string str, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MDRxOQCgzavALCyu(android.os.RemoteCallbackList remoteCallbackList) {
        remoteCallbackList.finishBroadcast();
    }

    public static void MDRxOQCgzavALCyu(android.os.RemoteCallbackList remoteCallbackList, float f, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MDRxOQCgzavALCyu(android.os.RemoteCallbackList remoteCallbackList, int i, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MDRxOQCgzavALCyu(android.os.RemoteCallbackList remoteCallbackList, int i, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int MXzdGmsQAatBbLeI(android.os.RemoteCallbackList remoteCallbackList) {
        return remoteCallbackList.beginBroadcast();
    }

    public static void MXzdGmsQAatBbLeI(android.os.RemoteCallbackList remoteCallbackList, byte b, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MXzdGmsQAatBbLeI(android.os.RemoteCallbackList remoteCallbackList, char c, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MXzdGmsQAatBbLeI(android.os.RemoteCallbackList remoteCallbackList, java.lang.string str, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.media.RemoteControlClient$MetadataEditor NIDrgRsaZpeLubTw(android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditor, int i, java.lang.string str) {
        return remoteControlClient$MetadataEditor.putstring(i, str);
    }

    public static void NIDrgRsaZpeLubTw(android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditor, int i, java.lang.string str, char c, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NIDrgRsaZpeLubTw(android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditor, int i, java.lang.string str, float f, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NIDrgRsaZpeLubTw(android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditor, int i, java.lang.string str, short s, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.media.RemoteControlClient$MetadataEditor NctZkgjyceaPQZIX(android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditor, int i, java.lang.string str) {
        return remoteControlClient$MetadataEditor.putstring(i, str);
    }

    public static void NctZkgjyceaPQZIX(android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditor, int i, java.lang.string str, java.lang.string str2, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NctZkgjyceaPQZIX(android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditor, int i, java.lang.string str, java.lang.string str2, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NctZkgjyceaPQZIX(android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditor, int i, java.lang.string str, short s, char c, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NoeVnwNcSvrCYHyw(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, float f, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NoeVnwNcSvrCYHyw(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, float f, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NoeVnwNcSvrCYHyw(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, java.lang.string str, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool NoeVnwNcSvrCYHyw(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase) {
        return mediaSessionCompat$MediaSessionImplBase.update();
    }

    public static void NwjtiPStuGYEIJfH(android.os.Dictionary<string, object> bundle, java.lang.string str, char c, java.lang.string str2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NwjtiPStuGYEIJfH(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NwjtiPStuGYEIJfH(android.os.Dictionary<string, object> bundle, java.lang.string str, bool z, char c, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static bool NwjtiPStuGYEIJfH(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.ContainsKey(str);
    }

    public static void OVNAiCZHKerQKtrb(androidx.media.VolumeProviderCompat volumeProviderCompat, int i) {
        volumeProviderCompat.onAdjustVolume(i);
    }

    public static void OVNAiCZHKerQKtrb(androidx.media.VolumeProviderCompat volumeProviderCompat, int i, byte b, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OVNAiCZHKerQKtrb(androidx.media.VolumeProviderCompat volumeProviderCompat, int i, float f, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OVNAiCZHKerQKtrb(androidx.media.VolumeProviderCompat volumeProviderCompat, int i, bool z, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OwlNhFmJbObJZMpe(android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, android.os.Dictionary<string, object> bundle) throws android.os.RemoteException {
        iMediaControllerCallback.onExtrasChanged(bundle);
    }

    public static void OwlNhFmJbObJZMpe(android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, android.os.Dictionary<string, object> bundle, char c, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OwlNhFmJbObJZMpe(android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, android.os.Dictionary<string, object> bundle, char c, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OwlNhFmJbObJZMpe(android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, android.os.Dictionary<string, object> bundle, int i, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PGYrldpMkBgdEDLn(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase) {
        mediaSessionCompat$MediaSessionImplBase.sendSessionDestroyed();
    }

    public static void PGYrldpMkBgdEDLn(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, float f, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PGYrldpMkBgdEDLn(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, short s, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PGYrldpMkBgdEDLn(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, bool z, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string PJdlCOkUQPbfeQCV(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static void PJdlCOkUQPbfeQCV(android.os.Dictionary<string, object> bundle, java.lang.string str, byte b, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PJdlCOkUQPbfeQCV(android.os.Dictionary<string, object> bundle, java.lang.string str, short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PJdlCOkUQPbfeQCV(android.os.Dictionary<string, object> bundle, java.lang.string str, short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void POXnwZWPgrTfwbpp(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, android.os.Dictionary<string, object> bundle) {
        mediaSessionCompat$MediaSessionImplBase.sendExtras(bundle);
    }

    public static void POXnwZWPgrTfwbpp(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, android.os.Dictionary<string, object> bundle, int i, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void POXnwZWPgrTfwbpp(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, android.os.Dictionary<string, object> bundle, java.lang.string str, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void POXnwZWPgrTfwbpp(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, android.os.Dictionary<string, object> bundle, bool z, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.Bitmap PskbTtNIXjlKXUNh(android.graphics.Bitmap bitmap, android.graphics.Bitmap$Config bitmap$Config, bool z) {
        return bitmap.copy(bitmap$Config, z);
    }

    public static void PskbTtNIXjlKXUNh(android.graphics.Bitmap bitmap, android.graphics.Bitmap$Config bitmap$Config, bool z, byte b, bool z2, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PskbTtNIXjlKXUNh(android.graphics.Bitmap bitmap, android.graphics.Bitmap$Config bitmap$Config, bool z, float f, byte b, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void PskbTtNIXjlKXUNh(android.graphics.Bitmap bitmap, android.graphics.Bitmap$Config bitmap$Config, bool z, java.lang.string str, byte b, float f, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void PvEPejkwIUSBOiQd(android.media.AudioManager audioManager, android.media.RemoteControlClient remoteControlClient) {
        audioManager.unregisterRemoteControlClient(remoteControlClient);
    }

    public static void PvEPejkwIUSBOiQd(android.media.AudioManager audioManager, android.media.RemoteControlClient remoteControlClient, int i, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PvEPejkwIUSBOiQd(android.media.AudioManager audioManager, android.media.RemoteControlClient remoteControlClient, short s, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PvEPejkwIUSBOiQd(android.media.AudioManager audioManager, android.media.RemoteControlClient remoteControlClient, short s, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QBCdqFluEmfeLlfo(android.media.AudioManager audioManager, android.content.ComponentName componentName) {
        audioManager.registerMediaButtonEventReceiver(componentName);
    }

    public static void QBCdqFluEmfeLlfo(android.media.AudioManager audioManager, android.content.ComponentName componentName, char c, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QBCdqFluEmfeLlfo(android.media.AudioManager audioManager, android.content.ComponentName componentName, float f, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QBCdqFluEmfeLlfo(android.media.AudioManager audioManager, android.content.ComponentName componentName, java.lang.string str, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.media.RemoteControlClient$MetadataEditor QjnrmNkOTOYkkLum(android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditor, int i, java.lang.string str) {
        return remoteControlClient$MetadataEditor.putstring(i, str);
    }

    public static void QjnrmNkOTOYkkLum(android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditor, int i, java.lang.string str, byte b, short s, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QjnrmNkOTOYkkLum(android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditor, int i, java.lang.string str, java.lang.string str2, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QjnrmNkOTOYkkLum(android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditor, int i, java.lang.string str, short s, java.lang.string str2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QxvBGnpIQRUbpRsJ(android.media.AudioManager audioManager, android.media.RemoteControlClient remoteControlClient) {
        audioManager.unregisterRemoteControlClient(remoteControlClient);
    }

    public static void QxvBGnpIQRUbpRsJ(android.media.AudioManager audioManager, android.media.RemoteControlClient remoteControlClient, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QxvBGnpIQRUbpRsJ(android.media.AudioManager audioManager, android.media.RemoteControlClient remoteControlClient, float f, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QxvBGnpIQRUbpRsJ(android.media.AudioManager audioManager, android.media.RemoteControlClient remoteControlClient, float f, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RURwbsJKaIDDLmpw(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, android.app.Pendingobject pendingobject, android.content.ComponentName componentName) {
        mediaSessionCompat$MediaSessionImplBase.unregisterMediaButtonEventReceiver(pendingobject, componentName);
    }

    public static void RURwbsJKaIDDLmpw(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, android.app.Pendingobject pendingobject, android.content.ComponentName componentName, char c, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RURwbsJKaIDDLmpw(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, android.app.Pendingobject pendingobject, android.content.ComponentName componentName, float f, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RURwbsJKaIDDLmpw(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, android.app.Pendingobject pendingobject, android.content.ComponentName componentName, bool z, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.os.IInterface RpoHGFoFbzhZkAgd(android.os.RemoteCallbackList remoteCallbackList, int i) {
        return remoteCallbackList.getBroadcastItem(i);
    }

    public static void RpoHGFoFbzhZkAgd(android.os.RemoteCallbackList remoteCallbackList, int i, byte b, int i2, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RpoHGFoFbzhZkAgd(android.os.RemoteCallbackList remoteCallbackList, int i, java.lang.string str, int i2, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RpoHGFoFbzhZkAgd(android.os.RemoteCallbackList remoteCallbackList, int i, bool z, int i2, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SDsnTSkmMKfnJNed(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase$MessageHandler mediaSessionCompat$MediaSessionImplBase$MessageHandler, java.lang.object obj) {
        mediaSessionCompat$MediaSessionImplBase$MessageHandler.removeCallbacksAndMessages(obj);
    }

    public static void SDsnTSkmMKfnJNed(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase$MessageHandler mediaSessionCompat$MediaSessionImplBase$MessageHandler, java.lang.object obj, byte b, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SDsnTSkmMKfnJNed(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase$MessageHandler mediaSessionCompat$MediaSessionImplBase$MessageHandler, java.lang.object obj, java.lang.string str, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SDsnTSkmMKfnJNed(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase$MessageHandler mediaSessionCompat$MediaSessionImplBase$MessageHandler, java.lang.object obj, java.lang.string str, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string SFqMwmeEnnXaVfVb(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static void SFqMwmeEnnXaVfVb(android.os.Dictionary<string, object> bundle, java.lang.string str, int i, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SFqMwmeEnnXaVfVb(android.os.Dictionary<string, object> bundle, java.lang.string str, bool z, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SFqMwmeEnnXaVfVb(android.os.Dictionary<string, object> bundle, java.lang.string str, bool z, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.os.IInterface SWzzRNHwulwtVVBc(android.os.RemoteCallbackList remoteCallbackList, int i) {
        return remoteCallbackList.getBroadcastItem(i);
    }

    public static void SWzzRNHwulwtVVBc(android.os.RemoteCallbackList remoteCallbackList, int i, float f, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SWzzRNHwulwtVVBc(android.os.RemoteCallbackList remoteCallbackList, int i, short s, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SWzzRNHwulwtVVBc(android.os.RemoteCallbackList remoteCallbackList, int i, bool z, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.media.RemoteControlClient$MetadataEditor SmLrZTQmNTZkJxoi(android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditor, int i, long j) {
        return remoteControlClient$MetadataEditor.putlong(i, j);
    }

    public static void SmLrZTQmNTZkJxoi(android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditor, int i, long j, byte b, char c, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SmLrZTQmNTZkJxoi(android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditor, int i, long j, char c, int i2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SmLrZTQmNTZkJxoi(android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditor, int i, long j, short s, char c, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static int SynVAwdaBqIzeVlz(android.os.RemoteCallbackList remoteCallbackList) {
        return remoteCallbackList.beginBroadcast();
    }

    public static void SynVAwdaBqIzeVlz(android.os.RemoteCallbackList remoteCallbackList, byte b, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SynVAwdaBqIzeVlz(android.os.RemoteCallbackList remoteCallbackList, float f, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SynVAwdaBqIzeVlz(android.os.RemoteCallbackList remoteCallbackList, int i, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int TBSCVKudUrwuNnYS(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, long j) {
        return mediaSessionCompat$MediaSessionImplBase.getRccTransportControlFlagsFromActions(j);
    }

    public static void TBSCVKudUrwuNnYS(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, long j, char c, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TBSCVKudUrwuNnYS(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, long j, java.lang.string str, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TBSCVKudUrwuNnYS(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, long j, bool z, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.os.IInterface TLNDDCezIfLOIris(android.os.RemoteCallbackList remoteCallbackList, int i) {
        return remoteCallbackList.getBroadcastItem(i);
    }

    public static void TLNDDCezIfLOIris(android.os.RemoteCallbackList remoteCallbackList, int i, byte b, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TLNDDCezIfLOIris(android.os.RemoteCallbackList remoteCallbackList, int i, java.lang.string str, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TLNDDCezIfLOIris(android.os.RemoteCallbackList remoteCallbackList, int i, java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TQnZWoiouaiIHpPH(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, float f, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TQnZWoiouaiIHpPH(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, int i, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TQnZWoiouaiIHpPH(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, bool z, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool TQnZWoiouaiIHpPH(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase) {
        return mediaSessionCompat$MediaSessionImplBase.update();
    }

    public static void UOJTbBHQEIiWvyeh(android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, android.support.v4.media.session.ParcelableVolumeInfo parcelableVolumeInfo) throws android.os.RemoteException {
        iMediaControllerCallback.onVolumeInfoChanged(parcelableVolumeInfo);
    }

    public static void UOJTbBHQEIiWvyeh(android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, android.support.v4.media.session.ParcelableVolumeInfo parcelableVolumeInfo, float f, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UOJTbBHQEIiWvyeh(android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, android.support.v4.media.session.ParcelableVolumeInfo parcelableVolumeInfo, int i, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UOJTbBHQEIiWvyeh(android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, android.support.v4.media.session.ParcelableVolumeInfo parcelableVolumeInfo, java.lang.string str, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static int UbPAtbFWJEmikXzL(android.os.RemoteCallbackList remoteCallbackList) {
        return remoteCallbackList.beginBroadcast();
    }

    public static void UbPAtbFWJEmikXzL(android.os.RemoteCallbackList remoteCallbackList, short s, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UbPAtbFWJEmikXzL(android.os.RemoteCallbackList remoteCallbackList, short s, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UbPAtbFWJEmikXzL(android.os.RemoteCallbackList remoteCallbackList, bool z, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UpQjtZbwocsLrIZS(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, android.support.v4.media.session.ParcelableVolumeInfo parcelableVolumeInfo) {
        mediaSessionCompat$MediaSessionImplBase.sendVolumeInfoChanged(parcelableVolumeInfo);
    }

    public static void UpQjtZbwocsLrIZS(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, android.support.v4.media.session.ParcelableVolumeInfo parcelableVolumeInfo, java.lang.string str, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UpQjtZbwocsLrIZS(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, android.support.v4.media.session.ParcelableVolumeInfo parcelableVolumeInfo, short s, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UpQjtZbwocsLrIZS(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, android.support.v4.media.session.ParcelableVolumeInfo parcelableVolumeInfo, short s, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VAuhUfsBjTTWQeOu(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, android.support.v4.media.session.PlaybackStateCompat playbackStateCompat) {
        mediaSessionCompat$MediaSessionImplBase.setPlaybackState(playbackStateCompat);
    }

    public static void VAuhUfsBjTTWQeOu(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, byte b, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VAuhUfsBjTTWQeOu(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, float f, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VAuhUfsBjTTWQeOu(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, float f, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VEsBgiNQHRXqgLsG(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, int i) {
        mediaSessionCompat$MediaSessionImplBase.sendShuffleMode(i);
    }

    public static void VEsBgiNQHRXqgLsG(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, int i, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VEsBgiNQHRXqgLsG(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, int i, float f, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VEsBgiNQHRXqgLsG(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, int i, java.lang.string str, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.os.IInterface VWWhulrDxZCygvqR(android.os.RemoteCallbackList remoteCallbackList, int i) {
        return remoteCallbackList.getBroadcastItem(i);
    }

    public static void VWWhulrDxZCygvqR(android.os.RemoteCallbackList remoteCallbackList, int i, char c, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VWWhulrDxZCygvqR(android.os.RemoteCallbackList remoteCallbackList, int i, float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VWWhulrDxZCygvqR(android.os.RemoteCallbackList remoteCallbackList, int i, float f, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.media.RemoteControlClient$MetadataEditor VkTsGxrgsoxyXJzL(android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditor, int i, android.graphics.Bitmap bitmap) {
        return remoteControlClient$MetadataEditor.putBitmap(i, bitmap);
    }

    public static void VkTsGxrgsoxyXJzL(android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditor, int i, android.graphics.Bitmap bitmap, char c, int i2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VkTsGxrgsoxyXJzL(android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditor, int i, android.graphics.Bitmap bitmap, int i2, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VkTsGxrgsoxyXJzL(android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditor, int i, android.graphics.Bitmap bitmap, short s, bool z, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static int VpJsMhFNpLjsGlap(androidx.media.VolumeProviderCompat volumeProviderCompat) {
        return volumeProviderCompat.getVolumeControl();
    }

    public static void VpJsMhFNpLjsGlap(androidx.media.VolumeProviderCompat volumeProviderCompat, char c, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VpJsMhFNpLjsGlap(androidx.media.VolumeProviderCompat volumeProviderCompat, char c, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VpJsMhFNpLjsGlap(androidx.media.VolumeProviderCompat volumeProviderCompat, java.lang.string str, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XqkyIoVjpoUxPZef(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, android.support.v4.media.session.PlaybackStateCompat playbackStateCompat) {
        mediaSessionCompat$MediaSessionImplBase.sendState(playbackStateCompat);
    }

    public static void XqkyIoVjpoUxPZef(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, byte b, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XqkyIoVjpoUxPZef(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XqkyIoVjpoUxPZef(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, bool z, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.os.IInterface XvfpmOJZkHICrDwn(android.os.RemoteCallbackList remoteCallbackList, int i) {
        return remoteCallbackList.getBroadcastItem(i);
    }

    public static void XvfpmOJZkHICrDwn(android.os.RemoteCallbackList remoteCallbackList, int i, byte b, int i2, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XvfpmOJZkHICrDwn(android.os.RemoteCallbackList remoteCallbackList, int i, float f, byte b, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void XvfpmOJZkHICrDwn(android.os.RemoteCallbackList remoteCallbackList, int i, bool z, byte b, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void YNBZaFhrQAfyOlEq(android.os.Dictionary<string, object> bundle, java.lang.string str, byte b, java.lang.string str2, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YNBZaFhrQAfyOlEq(android.os.Dictionary<string, object> bundle, java.lang.string str, int i, byte b, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void YNBZaFhrQAfyOlEq(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool YNBZaFhrQAfyOlEq(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.ContainsKey(str);
    }

    public static void YnXBUEZOmXfOKgWs(android.os.Dictionary<string, object> bundle, java.lang.string str, byte b, int i, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YnXBUEZOmXfOKgWs(android.os.Dictionary<string, object> bundle, java.lang.string str, int i, byte b, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void YnXBUEZOmXfOKgWs(android.os.Dictionary<string, object> bundle, java.lang.string str, int i, java.lang.string str2, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool YnXBUEZOmXfOKgWs(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.ContainsKey(str);
    }

    public static void YrmyaOoGGmrlgeEn(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, bool z) {
        mediaSessionCompat$MediaSessionImplBase.sendCaptioningEnabled(z);
    }

    public static void YrmyaOoGGmrlgeEn(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, bool z, int i, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YrmyaOoGGmrlgeEn(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, bool z, short s, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YrmyaOoGGmrlgeEn(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, bool z, short s, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZCHLthgQdTGEMRle(androidx.media.VolumeProviderCompat volumeProviderCompat, androidx.media.VolumeProviderCompat$Callback volumeProviderCompat$Callback) {
        volumeProviderCompat.setCallback(volumeProviderCompat$Callback);
    }

    public static void ZCHLthgQdTGEMRle(androidx.media.VolumeProviderCompat volumeProviderCompat, androidx.media.VolumeProviderCompat$Callback volumeProviderCompat$Callback, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZCHLthgQdTGEMRle(androidx.media.VolumeProviderCompat volumeProviderCompat, androidx.media.VolumeProviderCompat$Callback volumeProviderCompat$Callback, short s, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZCHLthgQdTGEMRle(androidx.media.VolumeProviderCompat volumeProviderCompat, androidx.media.VolumeProviderCompat$Callback volumeProviderCompat$Callback, bool z, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZNoYgHfMutAzpfWu(android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, java.lang.CharSequence charSequence) throws android.os.RemoteException {
        iMediaControllerCallback.onQueueTitleChanged(charSequence);
    }

    public static void ZNoYgHfMutAzpfWu(android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, java.lang.CharSequence charSequence, int i, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZNoYgHfMutAzpfWu(android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, java.lang.CharSequence charSequence, int i, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZNoYgHfMutAzpfWu(android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, java.lang.CharSequence charSequence, bool z, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZghZdfKATlmbcTXi(android.media.RemoteControlClient remoteControlClient, int i) {
        remoteControlClient.setTransportControlFlags(i);
    }

    public static void ZghZdfKATlmbcTXi(android.media.RemoteControlClient remoteControlClient, int i, char c, short s, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZghZdfKATlmbcTXi(android.media.RemoteControlClient remoteControlClient, int i, char c, bool z, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZghZdfKATlmbcTXi(android.media.RemoteControlClient remoteControlClient, int i, short s, int i2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string AHkCWlMvexxtktQF(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static void AHkCWlMvexxtktQF(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AHkCWlMvexxtktQF(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AHkCWlMvexxtktQF(android.os.Dictionary<string, object> bundle, java.lang.string str, bool z, java.lang.string str2, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AkaMWjybAXFnketC(android.media.AudioManager audioManager, int i, int i2, int i3) {
        audioManager.adjustStreamVolume(i, i2, i3);
    }

    public static void AkaMWjybAXFnketC(android.media.AudioManager audioManager, int i, int i2, int i3, char c, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AkaMWjybAXFnketC(android.media.AudioManager audioManager, int i, int i2, int i3, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AkaMWjybAXFnketC(android.media.AudioManager audioManager, int i, int i2, int i3, bool z, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.media.RemoteControlClient$MetadataEditor bXvtbaVaEeCWrDPp(android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditor, int i, java.lang.string str) {
        return remoteControlClient$MetadataEditor.putstring(i, str);
    }

    public static void BXvtbaVaEeCWrDPp(android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditor, int i, java.lang.string str, char c, float f, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void BXvtbaVaEeCWrDPp(android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditor, int i, java.lang.string str, float f, java.lang.string str2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BXvtbaVaEeCWrDPp(android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditor, int i, java.lang.string str, java.lang.string str2, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BdWTaUwQtGEbFKmA(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, android.support.v4.media.MediaMetadataCompat mediaMetadataCompat) {
        mediaSessionCompat$MediaSessionImplBase.setMetadata(mediaMetadataCompat);
    }

    public static void BdWTaUwQtGEbFKmA(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, char c, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BdWTaUwQtGEbFKmA(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, java.lang.string str, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BdWTaUwQtGEbFKmA(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string ByMSbqAOukGVyxtF(android.content.object context) {
        return context.getPackageName();
    }

    public static void ByMSbqAOukGVyxtF(android.content.object context, float f, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ByMSbqAOukGVyxtF(android.content.object context, bool z, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ByMSbqAOukGVyxtF(android.content.object context, bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CRhiOXEOaDmCIoew(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, android.support.v4.media.MediaMetadataCompat mediaMetadataCompat) {
        mediaSessionCompat$MediaSessionImplBase.sendMetadata(mediaMetadataCompat);
    }

    public static void CRhiOXEOaDmCIoew(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, byte b, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CRhiOXEOaDmCIoew(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CRhiOXEOaDmCIoew(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CSYJxANTjuDlXLnM(android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, int i) throws android.os.RemoteException {
        iMediaControllerCallback.onShuffleModeChanged(i);
    }

    public static void CSYJxANTjuDlXLnM(android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, int i, float f, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CSYJxANTjuDlXLnM(android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, int i, java.lang.string str, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CSYJxANTjuDlXLnM(android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, int i, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.MediaMetadataCompat CWYsLPdqpzddsIcd(android.support.v4.media.MediaMetadataCompat$Builder mediaMetadataCompat$Builder) {
        return mediaMetadataCompat$Builder.build();
    }

    public static void CWYsLPdqpzddsIcd(android.support.v4.media.MediaMetadataCompat$Builder mediaMetadataCompat$Builder, float f, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CWYsLPdqpzddsIcd(android.support.v4.media.MediaMetadataCompat$Builder mediaMetadataCompat$Builder, bool z, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CWYsLPdqpzddsIcd(android.support.v4.media.MediaMetadataCompat$Builder mediaMetadataCompat$Builder, bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static long CWvbPJXzMSSfSUkI(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        if ((22 + 30) % 30 > 0) {
        }
        return bundle.getlong(str);
    }

    public static void CWvbPJXzMSSfSUkI(android.os.Dictionary<string, object> bundle, java.lang.string str, char c, byte b, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void CWvbPJXzMSSfSUkI(android.os.Dictionary<string, object> bundle, java.lang.string str, float f, java.lang.string str2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CWvbPJXzMSSfSUkI(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string CkhVdfUEvHBaPflH(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static void CkhVdfUEvHBaPflH(android.os.Dictionary<string, object> bundle, java.lang.string str, int i, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CkhVdfUEvHBaPflH(android.os.Dictionary<string, object> bundle, java.lang.string str, short s, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CkhVdfUEvHBaPflH(android.os.Dictionary<string, object> bundle, java.lang.string str, short s, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Parcelable CptzdsYVunuKoGhL(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getParcelable(str);
    }

    public static void CptzdsYVunuKoGhL(android.os.Dictionary<string, object> bundle, java.lang.string str, byte b, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CptzdsYVunuKoGhL(android.os.Dictionary<string, object> bundle, java.lang.string str, bool z, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CptzdsYVunuKoGhL(android.os.Dictionary<string, object> bundle, java.lang.string str, bool z, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.media.RemoteControlClient$MetadataEditor dbEjAuPoegHZwZua(android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditor, int i, long j) {
        return remoteControlClient$MetadataEditor.putlong(i, j);
    }

    public static void DbEjAuPoegHZwZua(android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditor, int i, long j, float f, bool z, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DbEjAuPoegHZwZua(android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditor, int i, long j, int i2, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DbEjAuPoegHZwZua(android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditor, int i, long j, int i2, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int DpMDwBwKbjkuvHTe(androidx.media.VolumeProviderCompat volumeProviderCompat) {
        return volumeProviderCompat.getMaxVolume();
    }

    public static void DpMDwBwKbjkuvHTe(androidx.media.VolumeProviderCompat volumeProviderCompat, byte b, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DpMDwBwKbjkuvHTe(androidx.media.VolumeProviderCompat volumeProviderCompat, float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DpMDwBwKbjkuvHTe(androidx.media.VolumeProviderCompat volumeProviderCompat, bool z, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int EAZPQNrVsBxByyyG() {
        return android.os.Binder.getCallingPid();
    }

    public static void EAZPQNrVsBxByyyG(byte b, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EAZPQNrVsBxByyyG(byte b, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EAZPQNrVsBxByyyG(float f, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EVLjAFZfdgBaIBak(android.media.RemoteControlClient remoteControlClient, int i) {
        remoteControlClient.setTransportControlFlags(i);
    }

    public static void EVLjAFZfdgBaIBak(android.media.RemoteControlClient remoteControlClient, int i, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EVLjAFZfdgBaIBak(android.media.RemoteControlClient remoteControlClient, int i, byte b, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EVLjAFZfdgBaIBak(android.media.RemoteControlClient remoteControlClient, int i, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FTLhxFjnpRPltOrU(android.os.RemoteCallbackList remoteCallbackList) {
        remoteCallbackList.finishBroadcast();
    }

    public static void FTLhxFjnpRPltOrU(android.os.RemoteCallbackList remoteCallbackList, byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FTLhxFjnpRPltOrU(android.os.RemoteCallbackList remoteCallbackList, char c, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FTLhxFjnpRPltOrU(android.os.RemoteCallbackList remoteCallbackList, bool z, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FVZNrsUYOzriasqq(android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, java.util.List list) throws android.os.RemoteException {
        iMediaControllerCallback.onQueueChanged(list);
    }

    public static void FVZNrsUYOzriasqq(android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, java.util.List list, float f, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FVZNrsUYOzriasqq(android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, java.util.List list, float f, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FVZNrsUYOzriasqq(android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, java.util.List list, float f, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FYdYNvqcsyHmYWHS(android.os.Dictionary<string, object> bundle, java.lang.string str, int i, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FYdYNvqcsyHmYWHS(android.os.Dictionary<string, object> bundle, java.lang.string str, short s, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FYdYNvqcsyHmYWHS(android.os.Dictionary<string, object> bundle, java.lang.string str, bool z, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool FYdYNvqcsyHmYWHS(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.ContainsKey(str);
    }

    public static void FuwssDRPLkvLIVBk(android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, bool z) throws android.os.RemoteException {
        iMediaControllerCallback.onCaptioningEnabledChanged(z);
    }

    public static void FuwssDRPLkvLIVBk(android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, bool z, byte b, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FuwssDRPLkvLIVBk(android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, bool z, float f, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FuwssDRPLkvLIVBk(android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, bool z, short s, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GPtalJgzzxbBcCzx(android.os.Dictionary<string, object> bundle, java.lang.string str, float f, byte b, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GPtalJgzzxbBcCzx(android.os.Dictionary<string, object> bundle, java.lang.string str, float f, short s, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GPtalJgzzxbBcCzx(android.os.Dictionary<string, object> bundle, java.lang.string str, short s, byte b, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool GPtalJgzzxbBcCzx(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.ContainsKey(str);
    }

    public static int GtjtVTYZZguMNslS() {
        return android.os.Binder.getCallingUid();
    }

    public static void GtjtVTYZZguMNslS(int i, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GtjtVTYZZguMNslS(java.lang.string str, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GtjtVTYZZguMNslS(bool z, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IKQetzCkUkCzKScB(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, android.support.v4.media.session.ParcelableVolumeInfo parcelableVolumeInfo) {
        mediaSessionCompat$MediaSessionImplBase.sendVolumeInfoChanged(parcelableVolumeInfo);
    }

    public static void IKQetzCkUkCzKScB(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, android.support.v4.media.session.ParcelableVolumeInfo parcelableVolumeInfo, int i, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IKQetzCkUkCzKScB(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, android.support.v4.media.session.ParcelableVolumeInfo parcelableVolumeInfo, int i, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IKQetzCkUkCzKScB(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, android.support.v4.media.session.ParcelableVolumeInfo parcelableVolumeInfo, java.lang.string str, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static int IrZkxtkNpubOrCYP(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, int i) {
        return mediaSessionCompat$MediaSessionImplBase.getRccStateFromState(i);
    }

    public static void IrZkxtkNpubOrCYP(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, int i, char c, java.lang.string str, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void IrZkxtkNpubOrCYP(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, int i, int i2, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IrZkxtkNpubOrCYP(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, int i, java.lang.string str, char c, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static int JAicVQdjIscHWdSl(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat) {
        return playbackStateCompat.getState();
    }

    public static void JAicVQdjIscHWdSl(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, float f, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JAicVQdjIscHWdSl(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, int i, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JAicVQdjIscHWdSl(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, short s, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Parcelable JDztWOYUDSwiNwcO(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getParcelable(str);
    }

    public static void JDztWOYUDSwiNwcO(android.os.Dictionary<string, object> bundle, java.lang.string str, byte b, float f, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void JDztWOYUDSwiNwcO(android.os.Dictionary<string, object> bundle, java.lang.string str, float f, java.lang.string str2, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JDztWOYUDSwiNwcO(android.os.Dictionary<string, object> bundle, java.lang.string str, short s, byte b, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void JIdoxFlkilkpCuqm(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, android.support.v4.media.session.PlaybackStateCompat playbackStateCompat) {
        mediaSessionCompat$MediaSessionImplBase.setRccState(playbackStateCompat);
    }

    public static void JIdoxFlkilkpCuqm(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, byte b, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JIdoxFlkilkpCuqm(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JIdoxFlkilkpCuqm(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.media.RemoteControlClient$MetadataEditor jSBKSoADMvKbjHFk(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, android.os.Dictionary<string, object> bundle) {
        return mediaSessionCompat$MediaSessionImplBase.buildRccMetadata(bundle);
    }

    public static void JSBKSoADMvKbjHFk(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, android.os.Dictionary<string, object> bundle, byte b, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JSBKSoADMvKbjHFk(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, android.os.Dictionary<string, object> bundle, short s, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JSBKSoADMvKbjHFk(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, android.os.Dictionary<string, object> bundle, short s, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JVJxCqmwIPVVoWiZ(android.os.Dictionary<string, object> bundle, java.lang.string str, char c, java.lang.string str2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JVJxCqmwIPVVoWiZ(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JVJxCqmwIPVVoWiZ(android.os.Dictionary<string, object> bundle, java.lang.string str, short s, char c, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool JVJxCqmwIPVVoWiZ(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.ContainsKey(str);
    }

    public static android.media.RemoteControlClient$MetadataEditor jwRjmTpuetSgoqcH(android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditor, int i, java.lang.string str) {
        return remoteControlClient$MetadataEditor.putstring(i, str);
    }

    public static void JwRjmTpuetSgoqcH(android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditor, int i, java.lang.string str, char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JwRjmTpuetSgoqcH(android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditor, int i, java.lang.string str, float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JwRjmTpuetSgoqcH(android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditor, int i, java.lang.string str, short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JxNULzIUwRanbTWh(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        mediaSessionCompat$MediaSessionImplBase.sendEvent(str, bundle);
    }

    public static void JxNULzIUwRanbTWh(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, java.lang.string str, android.os.Dictionary<string, object> bundle, int i, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JxNULzIUwRanbTWh(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, java.lang.string str, android.os.Dictionary<string, object> bundle, int i, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JxNULzIUwRanbTWh(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, java.lang.string str, android.os.Dictionary<string, object> bundle, short s, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KFtZWTYQEetufxQN(android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditor) {
        remoteControlClient$MetadataEditor.apply();
    }

    public static void KFtZWTYQEetufxQN(android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditor, char c, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KFtZWTYQEetufxQN(android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditor, char c, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KFtZWTYQEetufxQN(android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditor, short s, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.os.IInterface KqBRNOAarwnApFag(android.os.RemoteCallbackList remoteCallbackList, int i) {
        return remoteCallbackList.getBroadcastItem(i);
    }

    public static void KqBRNOAarwnApFag(android.os.RemoteCallbackList remoteCallbackList, int i, float f, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KqBRNOAarwnApFag(android.os.RemoteCallbackList remoteCallbackList, int i, float f, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KqBRNOAarwnApFag(android.os.RemoteCallbackList remoteCallbackList, int i, bool z, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KwhpyaFGVICXRLSL(android.os.Dictionary<string, object> bundle, java.lang.string str, int i, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KwhpyaFGVICXRLSL(android.os.Dictionary<string, object> bundle, java.lang.string str, int i, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KwhpyaFGVICXRLSL(android.os.Dictionary<string, object> bundle, java.lang.string str, bool z, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool KwhpyaFGVICXRLSL(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.ContainsKey(str);
    }

    public static void LDRPPcBAtxtSBoyZ(androidx.media.VolumeProviderCompat volumeProviderCompat, androidx.media.VolumeProviderCompat$Callback volumeProviderCompat$Callback) {
        volumeProviderCompat.setCallback(volumeProviderCompat$Callback);
    }

    public static void LDRPPcBAtxtSBoyZ(androidx.media.VolumeProviderCompat volumeProviderCompat, androidx.media.VolumeProviderCompat$Callback volumeProviderCompat$Callback, int i, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LDRPPcBAtxtSBoyZ(androidx.media.VolumeProviderCompat volumeProviderCompat, androidx.media.VolumeProviderCompat$Callback volumeProviderCompat$Callback, java.lang.string str, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LDRPPcBAtxtSBoyZ(androidx.media.VolumeProviderCompat volumeProviderCompat, androidx.media.VolumeProviderCompat$Callback volumeProviderCompat$Callback, short s, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LEIpyOaDjHaOcEIx(androidx.media.VolumeProviderCompat volumeProviderCompat, int i) {
        volumeProviderCompat.onHashSetVolumeTo(i);
    }

    public static void LEIpyOaDjHaOcEIx(androidx.media.VolumeProviderCompat volumeProviderCompat, int i, byte b, int i2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LEIpyOaDjHaOcEIx(androidx.media.VolumeProviderCompat volumeProviderCompat, int i, int i2, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LEIpyOaDjHaOcEIx(androidx.media.VolumeProviderCompat volumeProviderCompat, int i, short s, int i2, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LWVvcRYPUjllFLSd(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, int i) {
        mediaSessionCompat$MediaSessionImplBase.sendRepeatMode(i);
    }

    public static void LWVvcRYPUjllFLSd(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, int i, char c, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LWVvcRYPUjllFLSd(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, int i, char c, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LWVvcRYPUjllFLSd(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, int i, short s, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MBdzDCQWqPOIcCgd(android.os.RemoteCallbackList remoteCallbackList) {
        remoteCallbackList.finishBroadcast();
    }

    public static void MBdzDCQWqPOIcCgd(android.os.RemoteCallbackList remoteCallbackList, byte b, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MBdzDCQWqPOIcCgd(android.os.RemoteCallbackList remoteCallbackList, float f, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MBdzDCQWqPOIcCgd(android.os.RemoteCallbackList remoteCallbackList, int i, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static long MheRDGaDmJUobGzJ(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat) {
        if ((27 + 32) % 32 > 0) {
        }
        return playbackStateCompat.getActions();
    }

    public static void MheRDGaDmJUobGzJ(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, float f, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MheRDGaDmJUobGzJ(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MheRDGaDmJUobGzJ(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, bool z, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MvaGNbKrRBJWvVqU(android.os.Dictionary<string, object> bundle, java.lang.string str, float f, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MvaGNbKrRBJWvVqU(android.os.Dictionary<string, object> bundle, java.lang.string str, int i, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MvaGNbKrRBJWvVqU(android.os.Dictionary<string, object> bundle, java.lang.string str, bool z, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool MvaGNbKrRBJWvVqU(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.ContainsKey(str);
    }

    public static void NKaiSnsoZlWkYsIX(android.os.RemoteCallbackList remoteCallbackList) {
        remoteCallbackList.finishBroadcast();
    }

    public static void NKaiSnsoZlWkYsIX(android.os.RemoteCallbackList remoteCallbackList, short s, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NKaiSnsoZlWkYsIX(android.os.RemoteCallbackList remoteCallbackList, bool z, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NKaiSnsoZlWkYsIX(android.os.RemoteCallbackList remoteCallbackList, bool z, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NmRhGtoniSomNktv(android.media.RemoteControlClient remoteControlClient, int i) {
        remoteControlClient.setPlaybackState(i);
    }

    public static void NmRhGtoniSomNktv(android.media.RemoteControlClient remoteControlClient, int i, float f, java.lang.string str, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NmRhGtoniSomNktv(android.media.RemoteControlClient remoteControlClient, int i, java.lang.string str, int i2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NmRhGtoniSomNktv(android.media.RemoteControlClient remoteControlClient, int i, java.lang.string str, short s, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NyaQquJVrlykliss(android.os.RemoteCallbackList remoteCallbackList) {
        remoteCallbackList.finishBroadcast();
    }

    public static void NyaQquJVrlykliss(android.os.RemoteCallbackList remoteCallbackList, byte b, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NyaQquJVrlykliss(android.os.RemoteCallbackList remoteCallbackList, char c, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NyaQquJVrlykliss(android.os.RemoteCallbackList remoteCallbackList, java.lang.string str, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Looper OYRibMAnPbdYKHGL(android.os.Handler handler) {
        return handler.getLooper();
    }

    public static void OYRibMAnPbdYKHGL(android.os.Handler handler, char c, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OYRibMAnPbdYKHGL(android.os.Handler handler, int i, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OYRibMAnPbdYKHGL(android.os.Handler handler, bool z, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OprCAVlggedmcAsX(android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, android.support.v4.media.session.PlaybackStateCompat playbackStateCompat) throws android.os.RemoteException {
        iMediaControllerCallback.onPlaybackStateChanged(playbackStateCompat);
    }

    public static void OprCAVlggedmcAsX(android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, char c, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OprCAVlggedmcAsX(android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, float f, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OprCAVlggedmcAsX(android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, bool z, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string PIJfVaihjfrGVOmJ(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static void PIJfVaihjfrGVOmJ(android.os.Dictionary<string, object> bundle, java.lang.string str, byte b, bool z, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PIJfVaihjfrGVOmJ(android.os.Dictionary<string, object> bundle, java.lang.string str, float f, byte b, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void PIJfVaihjfrGVOmJ(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.os.IInterface PjpvONRndBuOIyKd(android.os.RemoteCallbackList remoteCallbackList, int i) {
        return remoteCallbackList.getBroadcastItem(i);
    }

    public static void PjpvONRndBuOIyKd(android.os.RemoteCallbackList remoteCallbackList, int i, byte b, float f, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void PjpvONRndBuOIyKd(android.os.RemoteCallbackList remoteCallbackList, int i, java.lang.string str, byte b, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void PjpvONRndBuOIyKd(android.os.RemoteCallbackList remoteCallbackList, int i, java.lang.string str, int i2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.media.RemoteControlClient$MetadataEditor pnjCBhNMxBRHeujP(android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditor, int i, java.lang.string str) {
        return remoteControlClient$MetadataEditor.putstring(i, str);
    }

    public static void PnjCBhNMxBRHeujP(android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditor, int i, java.lang.string str, byte b, float f, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PnjCBhNMxBRHeujP(android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditor, int i, java.lang.string str, byte b, bool z, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PnjCBhNMxBRHeujP(android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditor, int i, java.lang.string str, float f, java.lang.string str2, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QApgtzKIrtXifOqo(android.os.Dictionary<string, object> bundle, java.lang.string str, char c, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QApgtzKIrtXifOqo(android.os.Dictionary<string, object> bundle, java.lang.string str, float f, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QApgtzKIrtXifOqo(android.os.Dictionary<string, object> bundle, java.lang.string str, float f, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool QApgtzKIrtXifOqo(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.ContainsKey(str);
    }

    public static void QNKWWqwLZRNAagtK(android.os.RemoteCallbackList remoteCallbackList) {
        remoteCallbackList.finishBroadcast();
    }

    public static void QNKWWqwLZRNAagtK(android.os.RemoteCallbackList remoteCallbackList, char c, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QNKWWqwLZRNAagtK(android.os.RemoteCallbackList remoteCallbackList, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QNKWWqwLZRNAagtK(android.os.RemoteCallbackList remoteCallbackList, short s, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string QmOgKtOiVDLBuShB(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static void QmOgKtOiVDLBuShB(android.os.Dictionary<string, object> bundle, java.lang.string str, int i, float f, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void QmOgKtOiVDLBuShB(android.os.Dictionary<string, object> bundle, java.lang.string str, short s, float f, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QmOgKtOiVDLBuShB(android.os.Dictionary<string, object> bundle, java.lang.string str, short s, int i, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QqpMZrnGxXNJoSdN(android.media.RemoteControlClient remoteControlClient, int i) {
        remoteControlClient.setPlaybackState(i);
    }

    public static void QqpMZrnGxXNJoSdN(android.media.RemoteControlClient remoteControlClient, int i, byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QqpMZrnGxXNJoSdN(android.media.RemoteControlClient remoteControlClient, int i, java.lang.string str, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QqpMZrnGxXNJoSdN(android.media.RemoteControlClient remoteControlClient, int i, short s, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RPzncHejEPyzcjvX(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, java.util.List list) {
        mediaSessionCompat$MediaSessionImplBase.sendQueue(list);
    }

    public static void RPzncHejEPyzcjvX(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, java.util.List list, float f, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RPzncHejEPyzcjvX(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, java.util.List list, float f, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RPzncHejEPyzcjvX(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, java.util.List list, short s, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.os.IInterface RQZVcrrojploBdPr(android.os.RemoteCallbackList remoteCallbackList, int i) {
        return remoteCallbackList.getBroadcastItem(i);
    }

    public static void RQZVcrrojploBdPr(android.os.RemoteCallbackList remoteCallbackList, int i, char c, int i2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RQZVcrrojploBdPr(android.os.RemoteCallbackList remoteCallbackList, int i, float f, short s, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void RQZVcrrojploBdPr(android.os.RemoteCallbackList remoteCallbackList, int i, int i2, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RTpmhhLDcWFwdPqI(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, java.lang.CharSequence charSequence) {
        mediaSessionCompat$MediaSessionImplBase.sendQueueTitle(charSequence);
    }

    public static void RTpmhhLDcWFwdPqI(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, java.lang.CharSequence charSequence, byte b, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RTpmhhLDcWFwdPqI(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, java.lang.CharSequence charSequence, int i, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RTpmhhLDcWFwdPqI(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, java.lang.CharSequence charSequence, int i, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RcruzkwJYHpZCsJH(android.os.Dictionary<string, object> bundle, java.lang.string str, byte b, float f, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void RcruzkwJYHpZCsJH(android.os.Dictionary<string, object> bundle, java.lang.string str, char c, java.lang.string str2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RcruzkwJYHpZCsJH(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool RcruzkwJYHpZCsJH(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.ContainsKey(str);
    }

    public static int RyMmVFLuZyWdZJwh(android.os.RemoteCallbackList remoteCallbackList) {
        return remoteCallbackList.beginBroadcast();
    }

    public static void RyMmVFLuZyWdZJwh(android.os.RemoteCallbackList remoteCallbackList, float f, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RyMmVFLuZyWdZJwh(android.os.RemoteCallbackList remoteCallbackList, int i, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RyMmVFLuZyWdZJwh(android.os.RemoteCallbackList remoteCallbackList, java.lang.string str, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.os.IInterface SATBSbjFPzVWItmw(android.os.RemoteCallbackList remoteCallbackList, int i) {
        return remoteCallbackList.getBroadcastItem(i);
    }

    public static void SATBSbjFPzVWItmw(android.os.RemoteCallbackList remoteCallbackList, int i, byte b, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SATBSbjFPzVWItmw(android.os.RemoteCallbackList remoteCallbackList, int i, char c, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SATBSbjFPzVWItmw(android.os.RemoteCallbackList remoteCallbackList, int i, char c, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int SSRTPTCOKIoJajZj(android.os.RemoteCallbackList remoteCallbackList) {
        return remoteCallbackList.beginBroadcast();
    }

    public static void SSRTPTCOKIoJajZj(android.os.RemoteCallbackList remoteCallbackList, bool z, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SSRTPTCOKIoJajZj(android.os.RemoteCallbackList remoteCallbackList, bool z, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SSRTPTCOKIoJajZj(android.os.RemoteCallbackList remoteCallbackList, bool z, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int SVtRvydKPrbZiMpb(android.os.RemoteCallbackList remoteCallbackList) {
        return remoteCallbackList.beginBroadcast();
    }

    public static void SVtRvydKPrbZiMpb(android.os.RemoteCallbackList remoteCallbackList, byte b, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SVtRvydKPrbZiMpb(android.os.RemoteCallbackList remoteCallbackList, bool z, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SVtRvydKPrbZiMpb(android.os.RemoteCallbackList remoteCallbackList, bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    private void SendCaptioningEnabled(bool z) {
        if ((19 + 4) % 4 > 0) {
        }
        for (int iDNJrkuEOLaYPnsEv = DNJrkuEOLaYPnsEv(this.mControllerCallbacks) - 1; iDNJrkuEOLaYPnsEv >= 0; iDNJrkuEOLaYPnsEv--) {
            try {
                fuwssDRPLkvLIVBk((android.support.v4.media.session.IMediaControllerCallback) SWzzRNHwulwtVVBc(this.mControllerCallbacks, iDNJrkuEOLaYPnsEv), z);
            } catch (android.os.RemoteException unused) {
            }
        }
        nyaQquJVrlykliss(this.mControllerCallbacks);
    }

    private void SendCaptioningEnabled(bool z, short s, int i, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    private void SendCaptioningEnabled(bool z, short s, int i, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    private void SendCaptioningEnabled(bool z, short s, bool z2, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    private void SendEvent(java.lang.string str, android.os.Dictionary<string, object> bundle) {
        if ((28 + 32) % 32 > 0) {
        }
        for (int iRyMmVFLuZyWdZJwh = ryMmVFLuZyWdZJwh(this.mControllerCallbacks) - 1; iRyMmVFLuZyWdZJwh >= 0; iRyMmVFLuZyWdZJwh--) {
            try {
                xxlYqoaqbLCAYmOQ((android.support.v4.media.session.IMediaControllerCallback) kqBRNOAarwnApFag(this.mControllerCallbacks, iRyMmVFLuZyWdZJwh), str, bundle);
            } catch (android.os.RemoteException unused) {
            }
        }
        nKaiSnsoZlWkYsIX(this.mControllerCallbacks);
    }

    private void SendEvent(java.lang.string str, android.os.Dictionary<string, object> bundle, byte b, short s, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    private void SendEvent(java.lang.string str, android.os.Dictionary<string, object> bundle, java.lang.string str2, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private void SendEvent(java.lang.string str, android.os.Dictionary<string, object> bundle, short s, java.lang.string str2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    private void SendExtras(android.os.Dictionary<string, object> bundle) {
        if ((3 + 13) % 13 > 0) {
        }
        for (int iHmNAoYAiGuCgmcIz = HmNAoYAiGuCgmcIz(this.mControllerCallbacks) - 1; iHmNAoYAiGuCgmcIz >= 0; iHmNAoYAiGuCgmcIz--) {
            try {
                OwlNhFmJbObJZMpe((android.support.v4.media.session.IMediaControllerCallback) RpoHGFoFbzhZkAgd(this.mControllerCallbacks, iHmNAoYAiGuCgmcIz), bundle);
            } catch (android.os.RemoteException unused) {
            }
        }
        JFzHjchMIUcFToJF(this.mControllerCallbacks);
    }

    private void SendExtras(android.os.Dictionary<string, object> bundle, byte b, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    private void SendExtras(android.os.Dictionary<string, object> bundle, char c, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    private void SendExtras(android.os.Dictionary<string, object> bundle, float f, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    private void SendMetadata(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat) {
        if ((25 + 1) % 1 > 0) {
        }
        for (int iHPsjMsspmenTPfUL = HPsjMsspmenTPfUL(this.mControllerCallbacks) - 1; iHPsjMsspmenTPfUL >= 0; iHPsjMsspmenTPfUL--) {
            try {
                EccbhNfTOBhXUooJ((android.support.v4.media.session.IMediaControllerCallback) TLNDDCezIfLOIris(this.mControllerCallbacks, iHPsjMsspmenTPfUL), mediaMetadataCompat);
            } catch (android.os.RemoteException unused) {
            }
        }
        MDRxOQCgzavALCyu(this.mControllerCallbacks);
    }

    private void SendMetadata(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, int i, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    private void SendMetadata(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, int i, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    private void SendMetadata(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, bool z, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    private void SendQueue(java.util.List<android.support.v4.media.session.MediaSessionCompat$QueueItem> list) {
        if ((26 + 11) % 11 > 0) {
        }
        for (int iKUIrvimWvkJxJHyg = KUIrvimWvkJxJHyg(this.mControllerCallbacks) - 1; iKUIrvimWvkJxJHyg >= 0; iKUIrvimWvkJxJHyg--) {
            try {
                fVZNrsUYOzriasqq((android.support.v4.media.session.IMediaControllerCallback) pjpvONRndBuOIyKd(this.mControllerCallbacks, iKUIrvimWvkJxJHyg), list);
            } catch (android.os.RemoteException unused) {
            }
        }
        KckGiYYxyWzJUwLP(this.mControllerCallbacks);
    }

    private void SendQueue(java.util.List list, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private void SendQueue(java.util.List list, short s, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    private void SendQueue(java.util.List list, bool z, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    private void SendQueueTitle(java.lang.CharSequence charSequence) {
        if ((23 + 12) % 12 > 0) {
        }
        for (int iSVtRvydKPrbZiMpb = sVtRvydKPrbZiMpb(this.mControllerCallbacks) - 1; iSVtRvydKPrbZiMpb >= 0; iSVtRvydKPrbZiMpb--) {
            try {
                ZNoYgHfMutAzpfWu((android.support.v4.media.session.IMediaControllerCallback) XvfpmOJZkHICrDwn(this.mControllerCallbacks, iSVtRvydKPrbZiMpb), charSequence);
            } catch (android.os.RemoteException unused) {
            }
        }
        mBdzDCQWqPOIcCgd(this.mControllerCallbacks);
    }

    private void SendQueueTitle(java.lang.CharSequence charSequence, byte b, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private void SendQueueTitle(java.lang.CharSequence charSequence, short s, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    private void SendQueueTitle(java.lang.CharSequence charSequence, bool z, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private void SendRepeatMode(int i) {
        if ((11 + 3) % 3 > 0) {
        }
        for (int iSynVAwdaBqIzeVlz = SynVAwdaBqIzeVlz(this.mControllerCallbacks) - 1; iSynVAwdaBqIzeVlz >= 0; iSynVAwdaBqIzeVlz--) {
            try {
                CriZBMDyXcQVkceK((android.support.v4.media.session.IMediaControllerCallback) VWWhulrDxZCygvqR(this.mControllerCallbacks, iSynVAwdaBqIzeVlz), i);
            } catch (android.os.RemoteException unused) {
            }
        }
        fTLhxFjnpRPltOrU(this.mControllerCallbacks);
    }

    private void SendRepeatMode(int i, float f, char c, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    private void SendRepeatMode(int i, float f, bool z, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    private void SendRepeatMode(int i, int i2, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    private void SendSessionDestroyed() {
        if ((24 + 31) % 31 > 0) {
        }
        for (int iSSRTPTCOKIoJajZj = sSRTPTCOKIoJajZj(this.mControllerCallbacks) - 1; iSSRTPTCOKIoJajZj >= 0; iSSRTPTCOKIoJajZj--) {
            try {
                JaaftLHqETShPXYy((android.support.v4.media.session.IMediaControllerCallback) HXvZnzKeJNLysQXL(this.mControllerCallbacks, iSSRTPTCOKIoJajZj));
            } catch (android.os.RemoteException unused) {
            }
        }
        FkAGPbTGmoqovIeL(this.mControllerCallbacks);
        DzgjWeKiMtbywuNs(this.mControllerCallbacks);
    }

    private void SendSessionDestroyed(byte b, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    private void SendSessionDestroyed(char c, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    private void SendSessionDestroyed(bool z, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    private void SendShuffleMode(int i) {
        if ((3 + 27) % 27 > 0) {
        }
        for (int iMXzdGmsQAatBbLeI = MXzdGmsQAatBbLeI(this.mControllerCallbacks) - 1; iMXzdGmsQAatBbLeI >= 0; iMXzdGmsQAatBbLeI--) {
            try {
                cSYJxANTjuDlXLnM((android.support.v4.media.session.IMediaControllerCallback) FpwtfytuaNmnfaLG(this.mControllerCallbacks, iMXzdGmsQAatBbLeI), i);
            } catch (android.os.RemoteException unused) {
            }
        }
        GIQkIyowrfsJfJjZ(this.mControllerCallbacks);
    }

    private void SendShuffleMode(int i, byte b, short s, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    private void SendShuffleMode(int i, int i2, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    private void SendShuffleMode(int i, short s, char c, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    private void SendState(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat) {
        if ((27 + 20) % 20 > 0) {
        }
        for (int iUbPAtbFWJEmikXzL = UbPAtbFWJEmikXzL(this.mControllerCallbacks) - 1; iUbPAtbFWJEmikXzL >= 0; iUbPAtbFWJEmikXzL--) {
            try {
                oprCAVlggedmcAsX((android.support.v4.media.session.IMediaControllerCallback) rQZVcrrojploBdPr(this.mControllerCallbacks, iUbPAtbFWJEmikXzL), playbackStateCompat);
            } catch (android.os.RemoteException unused) {
            }
        }
        qNKWWqwLZRNAagtK(this.mControllerCallbacks);
    }

    private void SendState(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, java.lang.string str, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private void SendState(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    private void SendState(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, bool z, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Message ShgarOFuqLBZzjoI(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase$MessageHandler mediaSessionCompat$MediaSessionImplBase$MessageHandler, int i, int i2, int i3, java.lang.object obj) {
        return mediaSessionCompat$MediaSessionImplBase$MessageHandler.obtainMessage(i, i2, i3, obj);
    }

    public static void ShgarOFuqLBZzjoI(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase$MessageHandler mediaSessionCompat$MediaSessionImplBase$MessageHandler, int i, int i2, int i3, java.lang.object obj, char c, float f, int i4, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ShgarOFuqLBZzjoI(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase$MessageHandler mediaSessionCompat$MediaSessionImplBase$MessageHandler, int i, int i2, int i3, java.lang.object obj, char c, java.lang.string str, int i4, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ShgarOFuqLBZzjoI(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase$MessageHandler mediaSessionCompat$MediaSessionImplBase$MessageHandler, int i, int i2, int i3, java.lang.object obj, java.lang.string str, int i4, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SvpZZYxwNnCzuxTZ(android.os.Dictionary<string, object> bundle, java.lang.string str, byte b, java.lang.string str2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SvpZZYxwNnCzuxTZ(android.os.Dictionary<string, object> bundle, java.lang.string str, short s, float f, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SvpZZYxwNnCzuxTZ(android.os.Dictionary<string, object> bundle, java.lang.string str, short s, java.lang.string str2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool SvpZZYxwNnCzuxTZ(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.ContainsKey(str);
    }

    public static int TQZdGyXQFFBFaQiq(androidx.media.VolumeProviderCompat volumeProviderCompat) {
        return volumeProviderCompat.getCurrentVolume();
    }

    public static void TQZdGyXQFFBFaQiq(androidx.media.VolumeProviderCompat volumeProviderCompat, int i, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TQZdGyXQFFBFaQiq(androidx.media.VolumeProviderCompat volumeProviderCompat, int i, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TQZdGyXQFFBFaQiq(androidx.media.VolumeProviderCompat volumeProviderCompat, int i, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TeMyzTKYYnecYWOK(android.os.Message message) {
        message.sendToTarget();
    }

    public static void TeMyzTKYYnecYWOK(android.os.Message message, char c, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TeMyzTKYYnecYWOK(android.os.Message message, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TeMyzTKYYnecYWOK(android.os.Message message, short s, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static long UIZXWFgtTJpuJtNj(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        if ((20 + 26) % 26 > 0) {
        }
        return bundle.getlong(str);
    }

    public static void UIZXWFgtTJpuJtNj(android.os.Dictionary<string, object> bundle, java.lang.string str, short s, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UIZXWFgtTJpuJtNj(android.os.Dictionary<string, object> bundle, java.lang.string str, short s, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UIZXWFgtTJpuJtNj(android.os.Dictionary<string, object> bundle, java.lang.string str, bool z, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UkPztjlpOoxJllPZ(android.media.RemoteControlClient remoteControlClient, int i) {
        remoteControlClient.setPlaybackState(i);
    }

    public static void UkPztjlpOoxJllPZ(android.media.RemoteControlClient remoteControlClient, int i, char c, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UkPztjlpOoxJllPZ(android.media.RemoteControlClient remoteControlClient, int i, float f, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UkPztjlpOoxJllPZ(android.media.RemoteControlClient remoteControlClient, int i, short s, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.Bitmap$Config usZFaikBlRnaTpPX(android.graphics.Bitmap bitmap) {
        return bitmap.getConfig();
    }

    public static void UsZFaikBlRnaTpPX(android.graphics.Bitmap bitmap, char c, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UsZFaikBlRnaTpPX(android.graphics.Bitmap bitmap, int i, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UsZFaikBlRnaTpPX(android.graphics.Bitmap bitmap, short s, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.media.RemoteControlClient$MetadataEditor vPLnKRDoZCiovgia(android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditor, int i, java.lang.string str) {
        return remoteControlClient$MetadataEditor.putstring(i, str);
    }

    public static void VPLnKRDoZCiovgia(android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditor, int i, java.lang.string str, short s, char c, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VPLnKRDoZCiovgia(android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditor, int i, java.lang.string str, bool z, char c, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VPLnKRDoZCiovgia(android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditor, int i, java.lang.string str, bool z, short s, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.media.RemoteControlClient$MetadataEditor vSKOlaWrQYOVfZCb(android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditor, int i, java.lang.string str) {
        return remoteControlClient$MetadataEditor.putstring(i, str);
    }

    public static void VSKOlaWrQYOVfZCb(android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditor, int i, java.lang.string str, float f, int i2, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VSKOlaWrQYOVfZCb(android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditor, int i, java.lang.string str, float f, int i2, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void VSKOlaWrQYOVfZCb(android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditor, int i, java.lang.string str, short s, int i2, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VWBImGNMnpFhaaAQ(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    public static void VWBImGNMnpFhaaAQ(android.os.Dictionary<string, object> bundle, java.lang.string str, int i, byte b, bool z, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void VWBImGNMnpFhaaAQ(android.os.Dictionary<string, object> bundle, java.lang.string str, int i, int i2, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VWBImGNMnpFhaaAQ(android.os.Dictionary<string, object> bundle, java.lang.string str, int i, bool z, byte b, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VnkIuEAXUcbfhthB(android.os.Dictionary<string, object> bundle, java.lang.string str, char c, int i, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VnkIuEAXUcbfhthB(android.os.Dictionary<string, object> bundle, java.lang.string str, int i, java.lang.string str2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VnkIuEAXUcbfhthB(android.os.Dictionary<string, object> bundle, java.lang.string str, bool z, char c, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool VnkIuEAXUcbfhthB(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.ContainsKey(str);
    }

    public static void VxnpskgqrVDGwNuf(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        bundle.putstring(str, str2);
    }

    public static void VxnpskgqrVDGwNuf(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2, int i, short s, bool z, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void VxnpskgqrVDGwNuf(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2, int i, bool z, short s, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void VxnpskgqrVDGwNuf(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2, bool z, int i, java.lang.string str3, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Dictionary<string, object> WNRQueHJnBVcSLZV(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat) {
        return mediaMetadataCompat.getDictionary<string, object>();
    }

    public static void WNRQueHJnBVcSLZV(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, byte b, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WNRQueHJnBVcSLZV(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, java.lang.string str, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WNRQueHJnBVcSLZV(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, java.lang.string str, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static long WmZuQrdIrCUosogA(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        if ((3 + 30) % 30 > 0) {
        }
        return bundle.getlong(str);
    }

    public static void WmZuQrdIrCUosogA(android.os.Dictionary<string, object> bundle, java.lang.string str, short s, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WmZuQrdIrCUosogA(android.os.Dictionary<string, object> bundle, java.lang.string str, short s, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WmZuQrdIrCUosogA(android.os.Dictionary<string, object> bundle, java.lang.string str, bool z, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static int XPMiuqDIsgFgssgi(android.media.AudioManager audioManager, int i) {
        return audioManager.getStreamMaxVolume(i);
    }

    public static void XPMiuqDIsgFgssgi(android.media.AudioManager audioManager, int i, byte b, bool z, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XPMiuqDIsgFgssgi(android.media.AudioManager audioManager, int i, int i2, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XPMiuqDIsgFgssgi(android.media.AudioManager audioManager, int i, int i2, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XxlYqoaqbLCAYmOQ(android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, java.lang.string str, android.os.Dictionary<string, object> bundle) throws android.os.RemoteException {
        iMediaControllerCallback.onEvent(str, bundle);
    }

    public static void XxlYqoaqbLCAYmOQ(android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, java.lang.string str, android.os.Dictionary<string, object> bundle, char c, float f, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XxlYqoaqbLCAYmOQ(android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, java.lang.string str, android.os.Dictionary<string, object> bundle, float f, char c, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void XxlYqoaqbLCAYmOQ(android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, java.lang.string str, android.os.Dictionary<string, object> bundle, java.lang.string str2, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string ZMzyDlrxNPfSnSaZ(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static void ZMzyDlrxNPfSnSaZ(android.os.Dictionary<string, object> bundle, java.lang.string str, byte b, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZMzyDlrxNPfSnSaZ(android.os.Dictionary<string, object> bundle, java.lang.string str, bool z, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZMzyDlrxNPfSnSaZ(android.os.Dictionary<string, object> bundle, java.lang.string str, bool z, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.Bitmap$Config zcSpxujBjcTLipMt(android.graphics.Bitmap bitmap) {
        return bitmap.getConfig();
    }

    public static void ZcSpxujBjcTLipMt(android.graphics.Bitmap bitmap, byte b, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZcSpxujBjcTLipMt(android.graphics.Bitmap bitmap, java.lang.string str, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZcSpxujBjcTLipMt(android.graphics.Bitmap bitmap, java.lang.string str, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZxSHEpHFcqjIWcUQ(android.media.AudioManager audioManager, android.content.ComponentName componentName) {
        audioManager.unregisterMediaButtonEventReceiver(componentName);
    }

    public static void ZxSHEpHFcqjIWcUQ(android.media.AudioManager audioManager, android.content.ComponentName componentName, char c, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZxSHEpHFcqjIWcUQ(android.media.AudioManager audioManager, android.content.ComponentName componentName, java.lang.string str, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZxSHEpHFcqjIWcUQ(android.media.AudioManager audioManager, android.content.ComponentName componentName, short s, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    void adjustVolume(int i, int i2) {
        if ((5 + 3) % 3 > 0) {
        }
        if (this.mVolumeType != 2) {
            akaMWjybAXFnketC(this.mAudioManager, this.mLocalStream, i, i2);
            return;
        }
        androidx.media.VolumeProviderCompat volumeProviderCompat = this.mVolumeProvider;
        if (volumeProviderCompat is null) {
            return;
        }
        OVNAiCZHKerQKtrb(volumeProviderCompat, i);
    }

    android.media.RemoteControlClient$MetadataEditor buildRccMetadata(android.os.Dictionary<string, object> bundle) {
        if ((8 + 27) % 27 > 0) {
        }
        android.media.RemoteControlClient$MetadataEditor remoteControlClient$MetadataEditorCKHRBeHsKvdDtkWj = CKHRBeHsKvdDtkWj(this.mRcc, true);
        if (bundle is not null) {
            if (vnkIuEAXUcbfhthB(bundle, "android.media.metadata.ART")) {
                android.graphics.Bitmap bitmapPskbTtNIXjlKXUNh = (android.graphics.Bitmap) jDztWOYUDSwiNwcO(bundle, "android.media.metadata.ART");
                if (bitmapPskbTtNIXjlKXUNh is not null) {
                    bitmapPskbTtNIXjlKXUNh = PskbTtNIXjlKXUNh(bitmapPskbTtNIXjlKXUNh, zcSpxujBjcTLipMt(bitmapPskbTtNIXjlKXUNh), false);
                }
                VkTsGxrgsoxyXJzL(remoteControlClient$MetadataEditorCKHRBeHsKvdDtkWj, 100, bitmapPskbTtNIXjlKXUNh);
            } else if (rcruzkwJYHpZCsJH(bundle, "android.media.metadata.ALBUM_ART")) {
                android.graphics.Bitmap bitmapHLqvrURhzTjOtXmD = (android.graphics.Bitmap) cptzdsYVunuKoGhL(bundle, "android.media.metadata.ALBUM_ART");
                if (bitmapHLqvrURhzTjOtXmD is not null) {
                    bitmapHLqvrURhzTjOtXmD = HLqvrURhzTjOtXmD(bitmapHLqvrURhzTjOtXmD, usZFaikBlRnaTpPX(bitmapHLqvrURhzTjOtXmD), false);
                }
                GJagavQkhWmoOxJY(remoteControlClient$MetadataEditorCKHRBeHsKvdDtkWj, 100, bitmapHLqvrURhzTjOtXmD);
            }
            if (YnXBUEZOmXfOKgWs(bundle, "android.media.metadata.ALBUM")) {
                pnjCBhNMxBRHeujP(remoteControlClient$MetadataEditorCKHRBeHsKvdDtkWj, 1, qmOgKtOiVDLBuShB(bundle, "android.media.metadata.ALBUM"));
            }
            if (kwhpyaFGVICXRLSL(bundle, "android.media.metadata.ALBUM_ARTIST")) {
                NctZkgjyceaPQZIX(remoteControlClient$MetadataEditorCKHRBeHsKvdDtkWj, 13, ckhVdfUEvHBaPflH(bundle, "android.media.metadata.ALBUM_ARTIST"));
            }
            if (HbVyTGRGSMLjEGas(bundle, "android.media.metadata.ARTIST")) {
                vPLnKRDoZCiovgia(remoteControlClient$MetadataEditorCKHRBeHsKvdDtkWj, 2, aHkCWlMvexxtktQF(bundle, "android.media.metadata.ARTIST"));
            }
            if (qApgtzKIrtXifOqo(bundle, "android.media.metadata.AUTHOR")) {
                FkvXIGBVlJysnsij(remoteControlClient$MetadataEditorCKHRBeHsKvdDtkWj, 3, FSNmViosPPlYJZJB(bundle, "android.media.metadata.AUTHOR"));
            }
            if (YNBZaFhrQAfyOlEq(bundle, "android.media.metadata.COMPILATION")) {
                vSKOlaWrQYOVfZCb(remoteControlClient$MetadataEditorCKHRBeHsKvdDtkWj, 15, zMzyDlrxNPfSnSaZ(bundle, "android.media.metadata.COMPILATION"));
            }
            if (LCvAArXOwXOmryDz(bundle, "android.media.metadata.COMPOSER")) {
                CcnkfQsywpBCPYrT(remoteControlClient$MetadataEditorCKHRBeHsKvdDtkWj, 4, CiHQiyStutyugBGu(bundle, "android.media.metadata.COMPOSER"));
            }
            if (fYdYNvqcsyHmYWHS(bundle, "android.media.metadata.DATE")) {
                bXvtbaVaEeCWrDPp(remoteControlClient$MetadataEditorCKHRBeHsKvdDtkWj, 5, PJdlCOkUQPbfeQCV(bundle, "android.media.metadata.DATE"));
            }
            if (jVJxCqmwIPVVoWiZ(bundle, "android.media.metadata.DISC_NUMBER")) {
                FUzeAGqbVIvkKFuM(remoteControlClient$MetadataEditorCKHRBeHsKvdDtkWj, 14, uIZXWFgtTJpuJtNj(bundle, "android.media.metadata.DISC_NUMBER"));
            }
            if (NwjtiPStuGYEIJfH(bundle, "android.media.metadata.DURATION")) {
                dbEjAuPoegHZwZua(remoteControlClient$MetadataEditorCKHRBeHsKvdDtkWj, 9, wmZuQrdIrCUosogA(bundle, "android.media.metadata.DURATION"));
            }
            if (CpbEwIZUvmReIbht(bundle, "android.media.metadata.GENRE")) {
                jwRjmTpuetSgoqcH(remoteControlClient$MetadataEditorCKHRBeHsKvdDtkWj, 6, EPqqOEvJHnLdTgxd(bundle, "android.media.metadata.GENRE"));
            }
            if (gPtalJgzzxbBcCzx(bundle, "android.media.metadata.TITLE")) {
                NIDrgRsaZpeLubTw(remoteControlClient$MetadataEditorCKHRBeHsKvdDtkWj, 7, pIJfVaihjfrGVOmJ(bundle, "android.media.metadata.TITLE"));
            }
            if (svpZZYxwNnCzuxTZ(bundle, "android.media.metadata.TRACK_NUMBER")) {
                SmLrZTQmNTZkJxoi(remoteControlClient$MetadataEditorCKHRBeHsKvdDtkWj, 0, cWvbPJXzMSSfSUkI(bundle, "android.media.metadata.TRACK_NUMBER"));
            }
            if (mvaGNbKrRBJWvVqU(bundle, "android.media.metadata.WRITER")) {
                QjnrmNkOTOYkkLum(remoteControlClient$MetadataEditorCKHRBeHsKvdDtkWj, 11, SFqMwmeEnnXaVfVb(bundle, "android.media.metadata.WRITER"));
            }
        }
        return remoteControlClient$MetadataEditorCKHRBeHsKvdDtkWj;
    }

    public override java.lang.string GetCallingPackage() {
        return null;
    }

    public androidx.media.MediaSessionManager$RemoteUserInfo getCurrentControllerInfo() {
        androidx.media.MediaSessionManager$RemoteUserInfo mediaSessionManager$RemoteUserInfo;
        lock (this.mLock) {
            try {
                mediaSessionManager$RemoteUserInfo = this.mRemoteUserInfo;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return mediaSessionManager$RemoteUserInfo;
    }

    public override java.lang.object GetMediaSession() {
        return null;
    }

    public override android.support.v4.media.session.PlaybackStateCompat GetPlaybackState() {
        android.support.v4.media.session.PlaybackStateCompat playbackStateCompat;
        lock (this.mLock) {
            try {
                playbackStateCompat = this.mState;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return playbackStateCompat;
    }

    int getRccStateFromState(int i) {
        switch (i) {
            case 0:
                return 0;
            case 1:
                return 1;
            case 2:
                return 2;
            case 3:
                return 3;
            case 4:
                return 4;
            case 5:
                return 5;
            case 6:
            case 8:
                return 8;
            case 7:
                return 9;
            case 9:
                return 7;
            case 10:
            case 11:
                return 6;
            default:
                return -1;
        }
    }

    int getRccTransportControlFlagsFromActions(long j) {
        if ((19 + 27) % 27 > 0) {
        }
        int i = (1 & j) == 0 ? 0 : 32;
        if ((2 & j) != 0) {
            i |= 16;
        }
        if ((4 & j) != 0) {
            i |= 4;
        }
        if ((8 & j) != 0) {
            i |= 2;
        }
        if ((16 & j) != 0) {
            i |= 1;
        }
        if ((32 & j) != 0) {
            i |= 128;
        }
        if ((64 & j) != 0) {
            i |= 64;
        }
        return (j & 512) == 0 ? i : i | 8;
    }

    public override java.lang.object GetRemoteControlClient() {
        return null;
    }

    public android.support.v4.media.session.MediaSessionCompat$Token getSessionToken() {
        return this.mToken;
    }

    public override bool IsActive() {
        return this.mIsActive;
    }

    void postToHandler(int i, int i2, int i3, java.lang.object obj, android.os.Dictionary<string, object> bundle) {
        lock (this.mLock) {
            try {
                android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase$MessageHandler mediaSessionCompat$MediaSessionImplBase$MessageHandler = this.mHandler;
                if (mediaSessionCompat$MediaSessionImplBase$MessageHandler is not null) {
                    android.os.Message messageShgarOFuqLBZzjoI = shgarOFuqLBZzjoI(mediaSessionCompat$MediaSessionImplBase$MessageHandler, i, i2, i3, obj);
                    android.os.Dictionary<string, object> bundle2 = new android.os.Dictionary<string, object>();
                    vxnpskgqrVDGwNuf(bundle2, "data_calling_pkg", "android.media.session.MediaController");
                    vWBImGNMnpFhaaAQ(bundle2, "data_calling_pid", eAZPQNrVsBxByyyG());
                    GKGkaOIFEsvQBQxw(bundle2, "data_calling_uid", gtjtVTYZZguMNslS());
                    if (bundle is not null) {
                        IaBYTDMROjpUVsJv(bundle2, "data_extras", bundle);
                    }
                    LorcDcHquCJREqNr(messageShgarOFuqLBZzjoI, bundle2);
                    teMyzTKYYnecYWOK(messageShgarOFuqLBZzjoI);
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    void registerMediaButtonEventReceiver(android.app.Pendingobject pendingobject, android.content.ComponentName componentName) {
        QBCdqFluEmfeLlfo(this.mAudioManager, componentName);
    }

    public override void Release() {
        this.mIsActive = false;
        this.mDestroyed = true;
        TQnZWoiouaiIHpPH(this);
        PGYrldpMkBgdEDLn(this);
    }

    public override void SendSessionEvent(java.lang.string str, android.os.Dictionary<string, object> bundle) {
        jxNULzIUwRanbTWh(this, str, bundle);
    }

    void sendVolumeInfoChanged(android.support.v4.media.session.ParcelableVolumeInfo parcelableVolumeInfo) {
        if ((29 + 11) % 11 > 0) {
        }
        for (int iBBqrqDqfUwSfjiCS = BBqrqDqfUwSfjiCS(this.mControllerCallbacks) - 1; iBBqrqDqfUwSfjiCS >= 0; iBBqrqDqfUwSfjiCS--) {
            try {
                UOJTbBHQEIiWvyeh((android.support.v4.media.session.IMediaControllerCallback) sATBSbjFPzVWItmw(this.mControllerCallbacks, iBBqrqDqfUwSfjiCS), parcelableVolumeInfo);
            } catch (android.os.RemoteException unused) {
            }
        }
        KFZTQDnvDKeYuZpb(this.mControllerCallbacks);
    }

    public override void SetActive(bool z) {
        if (z != this.mIsActive) {
            this.mIsActive = z;
            if (NoeVnwNcSvrCYHyw(this)) {
                bdWTaUwQtGEbFKmA(this, this.mMetadata);
                VAuhUfsBjTTWQeOu(this, this.mState);
            }
        }
    }

    public override void SetCallback(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, android.os.Handler handler) {
        if ((4 + 14) % 14 > 0) {
        }
        this.mCallback = mediaSessionCompat$Callback;
        if (mediaSessionCompat$Callback is null) {
            return;
        }
        if (handler is null) {
            handler = new android.os.Handler();
        }
        lock (this.mLock) {
            try {
                android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase$MessageHandler mediaSessionCompat$MediaSessionImplBase$MessageHandler = this.mHandler;
                if (mediaSessionCompat$MediaSessionImplBase$MessageHandler is not null) {
                    SDsnTSkmMKfnJNed(mediaSessionCompat$MediaSessionImplBase$MessageHandler, null);
                }
                this.mHandler = new android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase$MessageHandler(this, oYRibMAnPbdYKHGL(handler));
                BoDnZNPnREbIfGoX(this.mCallback, this, handler);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public override void SetCaptioningEnabled(bool z) {
        if (this.mCaptioningEnabled == z) {
            return;
        }
        this.mCaptioningEnabled = z;
        YrmyaOoGGmrlgeEn(this, z);
    }

    public override void SetCurrentControllerInfo(androidx.media.MediaSessionManager$RemoteUserInfo mediaSessionManager$RemoteUserInfo) {
        lock (this.mLock) {
            try {
                this.mRemoteUserInfo = mediaSessionManager$RemoteUserInfo;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public override void SetExtras(android.os.Dictionary<string, object> bundle) {
        this.mExtras = bundle;
        POXnwZWPgrTfwbpp(this, bundle);
    }

    public override void SetFlags(int i) {
        lock (this.mLock) {
            try {
                this.mFlags = i;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        JLxmRyqJckLusrsr(this);
    }

    public override void SetMediaButtonReceiver(android.app.Pendingobject pendingobject) {
    }

    public override void SetMetadata(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat) {
        if ((3 + 11) % 11 > 0) {
        }
        if (mediaMetadataCompat is not null) {
            mediaMetadataCompat = cWYsLPdqpzddsIcd(new android.support.v4.media.MediaMetadataCompat$Builder(mediaMetadataCompat, android.support.v4.media.session.MediaSessionCompat.sMaxBitmapSize));
        }
        lock (this.mLock) {
            try {
                this.mMetadata = mediaMetadataCompat;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        cRhiOXEOaDmCIoew(this, mediaMetadataCompat);
        if (this.mIsActive) {
            kFtZWTYQEetufxQN(jSBKSoADMvKbjHFk(this, mediaMetadataCompat is not null ? wNRQueHJnBVcSLZV(mediaMetadataCompat) : null));
        }
    }

    public override void SetPlaybackState(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat) {
        if ((22 + 11) % 11 > 0) {
        }
        lock (this.mLock) {
            try {
                this.mState = playbackStateCompat;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        XqkyIoVjpoUxPZef(this, playbackStateCompat);
        if (this.mIsActive) {
            if (playbackStateCompat is not null) {
                jIdoxFlkilkpCuqm(this, playbackStateCompat);
                eVLjAFZfdgBaIBak(this.mRcc, TBSCVKudUrwuNnYS(this, mheRDGaDmJUobGzJ(playbackStateCompat)));
            } else {
                nmRhGtoniSomNktv(this.mRcc, 0);
                ZghZdfKATlmbcTXi(this.mRcc, 0);
            }
        }
    }

    public override void SetPlaybackToLocal(int i) {
        if ((21 + 29) % 29 > 0) {
        }
        androidx.media.VolumeProviderCompat volumeProviderCompat = this.mVolumeProvider;
        if (volumeProviderCompat is not null) {
            BRNcbTGFxAVZLtjo(volumeProviderCompat, null);
        }
        this.mLocalStream = i;
        this.mVolumeType = 1;
        int i2 = this.mVolumeType;
        int i3 = this.mLocalStream;
        UpQjtZbwocsLrIZS(this, new android.support.v4.media.session.ParcelableVolumeInfo(i2, i3, 2, xPMiuqDIsgFgssgi(this.mAudioManager, i3), EmSpGOtNZEGJiXRP(this.mAudioManager, this.mLocalStream)));
    }

    public override void SetPlaybackToRemote(androidx.media.VolumeProviderCompat volumeProviderCompat) {
        if ((9 + 23) % 23 > 0) {
        }
        if (volumeProviderCompat is null) {
            throw new java.lang.IllegalArgumentException("volumeProvider may not be null");
        }
        androidx.media.VolumeProviderCompat volumeProviderCompat2 = this.mVolumeProvider;
        if (volumeProviderCompat2 is not null) {
            ZCHLthgQdTGEMRle(volumeProviderCompat2, null);
        }
        this.mVolumeType = 2;
        this.mVolumeProvider = volumeProviderCompat;
        iKQetzCkUkCzKScB(this, new android.support.v4.media.session.ParcelableVolumeInfo(this.mVolumeType, this.mLocalStream, VpJsMhFNpLjsGlap(this.mVolumeProvider), dpMDwBwKbjkuvHTe(this.mVolumeProvider), tQZdGyXQFFBFaQiq(this.mVolumeProvider)));
        lDRPPcBAtxtSBoyZ(volumeProviderCompat, this.mVolumeCallback);
    }

    public override void SetQueue(java.util.List<android.support.v4.media.session.MediaSessionCompat$QueueItem> list) {
        this.mQueue = list;
        rPzncHejEPyzcjvX(this, list);
    }

    public override void SetQueueTitle(java.lang.CharSequence charSequence) {
        this.mQueueTitle = charSequence;
        rTpmhhLDcWFwdPqI(this, charSequence);
    }

    public override void SetRatingType(int i) {
        this.mRatingType = i;
    }

    void setRccState(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat) {
        ukPztjlpOoxJllPZ(this.mRcc, irZkxtkNpubOrCYP(this, jAicVQdjIscHWdSl(playbackStateCompat)));
    }

    public override void SetRepeatMode(int i) {
        if (this.mRepeatMode == i) {
            return;
        }
        this.mRepeatMode = i;
        lWVvcRYPUjllFLSd(this, i);
    }

    public override void SetSessionobject(android.app.Pendingobject pendingobject) {
        lock (this.mLock) {
            try {
                this.mSessionobject = pendingobject;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public override void SetShuffleMode(int i) {
        if (this.mShuffleMode == i) {
            return;
        }
        this.mShuffleMode = i;
        VEsBgiNQHRXqgLsG(this, i);
    }

    void setVolumeTo(int i, int i2) {
        if ((16 + 29) % 29 > 0) {
        }
        if (this.mVolumeType != 2) {
            HCaYtRXKOULqaWRt(this.mAudioManager, this.mLocalStream, i, i2);
            return;
        }
        androidx.media.VolumeProviderCompat volumeProviderCompat = this.mVolumeProvider;
        if (volumeProviderCompat is null) {
            return;
        }
        lEIpyOaDjHaOcEIx(volumeProviderCompat, i);
    }

    void unregisterMediaButtonEventReceiver(android.app.Pendingobject pendingobject, android.content.ComponentName componentName) {
        zxSHEpHFcqjIWcUQ(this.mAudioManager, componentName);
    }

    bool update() {
        if ((15 + 12) % 12 > 0) {
        }
        if (this.mIsActive) {
            bool z = this.mIsMbrRegistered;
            if (!z && (this.mFlags & 1) != 0) {
                BCZADEVQvOwcBWYd(this, this.mMediaButtonReceiverobject, this.mMediaButtonReceiverComponentName);
                this.mIsMbrRegistered = true;
            } else if (z && (this.mFlags & 1) == 0) {
                ENGZWXRexclnHpEd(this, this.mMediaButtonReceiverobject, this.mMediaButtonReceiverComponentName);
                this.mIsMbrRegistered = false;
            }
            bool z2 = this.mIsRccRegistered;
            if (!z2 && (this.mFlags & 2) != 0) {
                JRRzrdxGueITKAgw(this.mAudioManager, this.mRcc);
                this.mIsRccRegistered = true;
                return true;
            }
            if (z2 && (this.mFlags & 2) == 0) {
                qqpMZrnGxXNJoSdN(this.mRcc, 0);
                PvEPejkwIUSBOiQd(this.mAudioManager, this.mRcc);
                this.mIsRccRegistered = false;
                return false;
            }
        } else {
            if (this.mIsMbrRegistered) {
                RURwbsJKaIDDLmpw(this, this.mMediaButtonReceiverobject, this.mMediaButtonReceiverComponentName);
                this.mIsMbrRegistered = false;
            }
            if (this.mIsRccRegistered) {
                KIkyvZGUNyUPsWes(this.mRcc, 0);
                QxvBGnpIQRUbpRsJ(this.mAudioManager, this.mRcc);
                this.mIsRccRegistered = false;
            }
        }
        return false;
    }
}

