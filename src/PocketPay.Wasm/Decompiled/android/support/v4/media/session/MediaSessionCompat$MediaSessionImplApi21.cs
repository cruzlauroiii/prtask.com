namespace WillowMaze.Wasm.Decompiled;


class MediaSessionCompat$MediaSessionImplApi21 : android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl {
    bool mCaptioningEnabled;
    bool mDestroyed;
    readonly android.os.RemoteCallbackList<android.support.v4.media.session.IMediaControllerCallback> mExtraControllerCallbacks;
    android.support.v4.media.MediaMetadataCompat mMetadata;
    android.support.v4.media.session.PlaybackStateCompat mPlaybackState;
    java.util.List<android.support.v4.media.session.MediaSessionCompat$QueueItem> mQueue;
    int mRatingType;
    int mRepeatMode;
    readonly java.lang.object mSessionObj;
    int mShuffleMode;
    readonly android.support.v4.media.session.MediaSessionCompat$Token mToken;

    MediaSessionCompat$MediaSessionImplApi21(android.content.object context, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        this.mDestroyed = false;
        this.mExtraControllerCallbacks = new android.os.RemoteCallbackList<>();
        java.lang.object objCjZmxpqkYOEPtUiF = CjZmxpqkYOEPtUiF(context, str);
        this.mSessionObj = objCjZmxpqkYOEPtUiF;
        this.mToken = new android.support.v4.media.session.MediaSessionCompat$Token(jSoxAQZaPIojENGC(objCjZmxpqkYOEPtUiF), new android.support.v4.media.session.MediaSessionCompat$MediaSessionImplApi21$ExtraSession(this), bundle);
    }

    MediaSessionCompat$MediaSessionImplApi21(java.lang.object obj) {
        if ((20 + 22) % 22 > 0) {
        }
        this.mDestroyed = false;
        this.mExtraControllerCallbacks = new android.os.RemoteCallbackList<>();
        java.lang.object objCdErGveUphWhSNMD = CdErGveUphWhSNMD(obj);
        this.mSessionObj = objCdErGveUphWhSNMD;
        this.mToken = new android.support.v4.media.session.MediaSessionCompat$Token(ChSwyoOPvlWXUlex(objCdErGveUphWhSNMD), new android.support.v4.media.session.MediaSessionCompat$MediaSessionImplApi21$ExtraSession(this));
    }

    public static void AkGZFQtCmVVlGUdm(java.lang.object obj, android.app.Pendingobject pendingobject) {
        android.support.v4.media.session.MediaSessionCompatApi21.setSessionobject(obj, pendingobject);
    }

    public static void AkGZFQtCmVVlGUdm(java.lang.object obj, android.app.Pendingobject pendingobject, char c, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AkGZFQtCmVVlGUdm(java.lang.object obj, android.app.Pendingobject pendingobject, char c, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AkGZFQtCmVVlGUdm(java.lang.object obj, android.app.Pendingobject pendingobject, short s, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object CdErGveUphWhSNMD(java.lang.object obj) {
        return android.support.v4.media.session.MediaSessionCompatApi21.verifySession(obj);
    }

    public static void CdErGveUphWhSNMD(java.lang.object obj, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CdErGveUphWhSNMD(java.lang.object obj, java.lang.string str, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CdErGveUphWhSNMD(java.lang.object obj, short s, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Parcelable ChSwyoOPvlWXUlex(java.lang.object obj) {
        return android.support.v4.media.session.MediaSessionCompatApi21.getSessionToken(obj);
    }

    public static void ChSwyoOPvlWXUlex(java.lang.object obj, int i, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ChSwyoOPvlWXUlex(java.lang.object obj, int i, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ChSwyoOPvlWXUlex(java.lang.object obj, int i, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object CjZmxpqkYOEPtUiF(android.content.object context, java.lang.string str) {
        return android.support.v4.media.session.MediaSessionCompatApi21.createSession(context, str);
    }

    public static void CjZmxpqkYOEPtUiF(android.content.object context, java.lang.string str, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CjZmxpqkYOEPtUiF(android.content.object context, java.lang.string str, int i, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CjZmxpqkYOEPtUiF(android.content.object context, java.lang.string str, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object ETjoVvwVMqASuLQx(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat) {
        return mediaMetadataCompat.getMediaMetadata();
    }

    public static void ETjoVvwVMqASuLQx(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, int i, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ETjoVvwVMqASuLQx(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, java.lang.string str, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ETjoVvwVMqASuLQx(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, short s, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string IOcNnAxnzAMsfzFU(java.lang.object obj) {
        return android.support.v4.media.session.MediaSessionCompatApi24.getCallingPackage(obj);
    }

    public static void IOcNnAxnzAMsfzFU(java.lang.object obj, java.lang.string str, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IOcNnAxnzAMsfzFU(java.lang.object obj, java.lang.string str, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IOcNnAxnzAMsfzFU(java.lang.object obj, short s, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JOfwKnMMQkDintqi(java.lang.object obj, android.app.Pendingobject pendingobject) {
        android.support.v4.media.session.MediaSessionCompatApi21.setMediaButtonReceiver(obj, pendingobject);
    }

    public static void JOfwKnMMQkDintqi(java.lang.object obj, android.app.Pendingobject pendingobject, byte b, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JOfwKnMMQkDintqi(java.lang.object obj, android.app.Pendingobject pendingobject, byte b, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JOfwKnMMQkDintqi(java.lang.object obj, android.app.Pendingobject pendingobject, byte b, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JfGWgSKNmLlQlJzO(android.os.RemoteCallbackList remoteCallbackList) {
        remoteCallbackList.finishBroadcast();
    }

    public static void JfGWgSKNmLlQlJzO(android.os.RemoteCallbackList remoteCallbackList, int i, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JfGWgSKNmLlQlJzO(android.os.RemoteCallbackList remoteCallbackList, java.lang.string str, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JfGWgSKNmLlQlJzO(android.os.RemoteCallbackList remoteCallbackList, java.lang.string str, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int JhIYlqTLOCXcAWVX(android.os.RemoteCallbackList remoteCallbackList) {
        return remoteCallbackList.beginBroadcast();
    }

    public static void JhIYlqTLOCXcAWVX(android.os.RemoteCallbackList remoteCallbackList, int i, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JhIYlqTLOCXcAWVX(android.os.RemoteCallbackList remoteCallbackList, int i, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JhIYlqTLOCXcAWVX(android.os.RemoteCallbackList remoteCallbackList, java.lang.string str, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object KZOTKQvzGKaoArgb(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat) {
        return playbackStateCompat.getPlaybackState();
    }

    public static void KZOTKQvzGKaoArgb(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, byte b, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KZOTKQvzGKaoArgb(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, char c, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KZOTKQvzGKaoArgb(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, java.lang.string str, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LqQMEkdfwMXMLJHB(java.lang.object obj) {
        android.support.v4.media.session.MediaSessionCompatApi21.release(obj);
    }

    public static void LqQMEkdfwMXMLJHB(java.lang.object obj, char c, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LqQMEkdfwMXMLJHB(java.lang.object obj, int i, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LqQMEkdfwMXMLJHB(java.lang.object obj, bool z, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NPHZEKFybbLKObVA(java.lang.object obj, java.util.List list) {
        android.support.v4.media.session.MediaSessionCompatApi21.setQueue(obj, list);
    }

    public static void NPHZEKFybbLKObVA(java.lang.object obj, java.util.List list, float f, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NPHZEKFybbLKObVA(java.lang.object obj, java.util.List list, float f, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NPHZEKFybbLKObVA(java.lang.object obj, java.util.List list, int i, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OwvTSgITvYknSagM(android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, int i) throws android.os.RemoteException {
        iMediaControllerCallback.onShuffleModeChanged(i);
    }

    public static void OwvTSgITvYknSagM(android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, int i, byte b, float f, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void OwvTSgITvYknSagM(android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, int i, int i2, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OwvTSgITvYknSagM(android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, int i, int i2, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QeZbZBKhlkQFDbTR(java.lang.object obj, int i) {
        android.support.v4.media.session.MediaSessionCompatApi21.setFlags(obj, i);
    }

    public static void QeZbZBKhlkQFDbTR(java.lang.object obj, int i, char c, short s, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QeZbZBKhlkQFDbTR(java.lang.object obj, int i, float f, short s, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QeZbZBKhlkQFDbTR(java.lang.object obj, int i, int i2, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QgkIdKvTWiozEpPo(java.lang.object obj, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        android.support.v4.media.session.MediaSessionCompatApi21.sendSessionEvent(obj, str, bundle);
    }

    public static void QgkIdKvTWiozEpPo(java.lang.object obj, java.lang.string str, android.os.Dictionary<string, object> bundle, java.lang.string str2, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QgkIdKvTWiozEpPo(java.lang.object obj, java.lang.string str, android.os.Dictionary<string, object> bundle, bool z, byte b, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void QgkIdKvTWiozEpPo(java.lang.object obj, java.lang.string str, android.os.Dictionary<string, object> bundle, bool z, int i, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static int QscPmZRKfKSxLhEu(android.os.RemoteCallbackList remoteCallbackList) {
        return remoteCallbackList.beginBroadcast();
    }

    public static void QscPmZRKfKSxLhEu(android.os.RemoteCallbackList remoteCallbackList, char c, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QscPmZRKfKSxLhEu(android.os.RemoteCallbackList remoteCallbackList, char c, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QscPmZRKfKSxLhEu(android.os.RemoteCallbackList remoteCallbackList, int i, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ROkFNUUuyZNWIIru(android.os.RemoteCallbackList remoteCallbackList) {
        remoteCallbackList.finishBroadcast();
    }

    public static void ROkFNUUuyZNWIIru(android.os.RemoteCallbackList remoteCallbackList, byte b, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ROkFNUUuyZNWIIru(android.os.RemoteCallbackList remoteCallbackList, byte b, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ROkFNUUuyZNWIIru(android.os.RemoteCallbackList remoteCallbackList, bool z, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RPygIVEBIAPUsCfR(java.lang.object obj, android.os.Dictionary<string, object> bundle) {
        android.support.v4.media.session.MediaSessionCompatApi21.setExtras(obj, bundle);
    }

    public static void RPygIVEBIAPUsCfR(java.lang.object obj, android.os.Dictionary<string, object> bundle, byte b, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RPygIVEBIAPUsCfR(java.lang.object obj, android.os.Dictionary<string, object> bundle, java.lang.string str, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RPygIVEBIAPUsCfR(java.lang.object obj, android.os.Dictionary<string, object> bundle, short s, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TNKmgXEGTfehokqV(java.lang.object obj, java.lang.CharSequence charSequence) {
        android.support.v4.media.session.MediaSessionCompatApi21.setQueueTitle(obj, charSequence);
    }

    public static void TNKmgXEGTfehokqV(java.lang.object obj, java.lang.CharSequence charSequence, char c, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TNKmgXEGTfehokqV(java.lang.object obj, java.lang.CharSequence charSequence, java.lang.string str, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TNKmgXEGTfehokqV(java.lang.object obj, java.lang.CharSequence charSequence, java.lang.string str, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.os.IInterface UUkbnNNXaFwjifkE(android.os.RemoteCallbackList remoteCallbackList, int i) {
        return remoteCallbackList.getBroadcastItem(i);
    }

    public static void UUkbnNNXaFwjifkE(android.os.RemoteCallbackList remoteCallbackList, int i, int i2, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UUkbnNNXaFwjifkE(android.os.RemoteCallbackList remoteCallbackList, int i, short s, char c, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UUkbnNNXaFwjifkE(android.os.RemoteCallbackList remoteCallbackList, int i, bool z, char c, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void UqRBYzcHBsQrkvIV(java.lang.object obj, int i, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UqRBYzcHBsQrkvIV(java.lang.object obj, int i, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UqRBYzcHBsQrkvIV(java.lang.object obj, short s, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool UqRBYzcHBsQrkvIV(java.lang.object obj) {
        return android.support.v4.media.session.MediaSessionCompatApi21.isActive(obj);
    }

    public static int WBZDyYCBFWHvTmPd(android.os.RemoteCallbackList remoteCallbackList) {
        return remoteCallbackList.beginBroadcast();
    }

    public static void WBZDyYCBFWHvTmPd(android.os.RemoteCallbackList remoteCallbackList, byte b, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WBZDyYCBFWHvTmPd(android.os.RemoteCallbackList remoteCallbackList, char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WBZDyYCBFWHvTmPd(android.os.RemoteCallbackList remoteCallbackList, char c, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YsUxvJCBhVcNHAWQ(java.lang.object obj, java.lang.object obj2) {
        android.support.v4.media.session.MediaSessionCompatApi21.setMetadata(obj, obj2);
    }

    public static void YsUxvJCBhVcNHAWQ(java.lang.object obj, java.lang.object obj2, java.lang.string str, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YsUxvJCBhVcNHAWQ(java.lang.object obj, java.lang.object obj2, short s, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YsUxvJCBhVcNHAWQ(java.lang.object obj, java.lang.object obj2, short s, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZOPDwaodwFWIZeUr(android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, int i) throws android.os.RemoteException {
        iMediaControllerCallback.onRepeatModeChanged(i);
    }

    public static void ZOPDwaodwFWIZeUr(android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, int i, byte b, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZOPDwaodwFWIZeUr(android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, int i, byte b, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZOPDwaodwFWIZeUr(android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, int i, float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object ZmUXRimPyOclYjIj(android.support.v4.media.session.MediaSessionCompat$QueueItem mediaSessionCompat$QueueItem) {
        return mediaSessionCompat$QueueItem.getQueueItem();
    }

    public static void ZmUXRimPyOclYjIj(android.support.v4.media.session.MediaSessionCompat$QueueItem mediaSessionCompat$QueueItem, float f, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZmUXRimPyOclYjIj(android.support.v4.media.session.MediaSessionCompat$QueueItem mediaSessionCompat$QueueItem, short s, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZmUXRimPyOclYjIj(android.support.v4.media.session.MediaSessionCompat$QueueItem mediaSessionCompat$QueueItem, bool z, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZpQjtxehoOqYbqHU(java.util.IEnumerator it, byte b, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZpQjtxehoOqYbqHU(java.util.IEnumerator it, byte b, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZpQjtxehoOqYbqHU(java.util.IEnumerator it, float f, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool ZpQjtxehoOqYbqHU(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.object DvAogvmCkQHmdBid(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void DvAogvmCkQHmdBid(java.util.IEnumerator it, float f, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DvAogvmCkQHmdBid(java.util.IEnumerator it, bool z, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DvAogvmCkQHmdBid(java.util.IEnumerator it, bool z, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.os.IInterface GBbMIEDNFjOThWEG(android.os.RemoteCallbackList remoteCallbackList, int i) {
        return remoteCallbackList.getBroadcastItem(i);
    }

    public static void GBbMIEDNFjOThWEG(android.os.RemoteCallbackList remoteCallbackList, int i, byte b, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GBbMIEDNFjOThWEG(android.os.RemoteCallbackList remoteCallbackList, int i, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GBbMIEDNFjOThWEG(android.os.RemoteCallbackList remoteCallbackList, int i, float f, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GMYvLNvZkhdABEJh(android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, bool z) throws android.os.RemoteException {
        iMediaControllerCallback.onCaptioningEnabledChanged(z);
    }

    public static void GMYvLNvZkhdABEJh(android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, bool z, byte b, short s, bool z2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GMYvLNvZkhdABEJh(android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, bool z, int i, byte b, short s, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void GMYvLNvZkhdABEJh(android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, bool z, short s, byte b, int i, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void GOvruodSpgNwUXhr(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, android.os.Handler handler) {
        mediaSessionCompat$Callback.setSessionImpl(mediaSessionCompat$MediaSessionImpl, handler);
    }

    public static void GOvruodSpgNwUXhr(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, android.os.Handler handler, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GOvruodSpgNwUXhr(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, android.os.Handler handler, float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GOvruodSpgNwUXhr(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, android.support.v4.media.session.MediaSessionCompat$MediaSessionImpl mediaSessionCompat$MediaSessionImpl, android.os.Handler handler, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int GTeePMhWhTcDpNYq(android.os.RemoteCallbackList remoteCallbackList) {
        return remoteCallbackList.beginBroadcast();
    }

    public static void GTeePMhWhTcDpNYq(android.os.RemoteCallbackList remoteCallbackList, float f, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GTeePMhWhTcDpNYq(android.os.RemoteCallbackList remoteCallbackList, java.lang.string str, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GTeePMhWhTcDpNYq(android.os.RemoteCallbackList remoteCallbackList, java.lang.string str, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GVScmKCBkSNoURwY(java.util.List list, java.lang.object obj, byte b, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GVScmKCBkSNoURwY(java.util.List list, java.lang.object obj, char c, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GVScmKCBkSNoURwY(java.util.List list, java.lang.object obj, float f, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool GVScmKCBkSNoURwY(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void HCfWcwVQhLxynLTn(java.lang.object obj, int i) {
        android.support.v4.media.session.MediaSessionCompatApi22.setRatingType(obj, i);
    }

    public static void HCfWcwVQhLxynLTn(java.lang.object obj, int i, bool z, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HCfWcwVQhLxynLTn(java.lang.object obj, int i, bool z, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HCfWcwVQhLxynLTn(java.lang.object obj, int i, bool z, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IUKQlZmLgFvhmqnr(java.lang.object obj, java.lang.object obj2) {
        android.support.v4.media.session.MediaSessionCompatApi21.setPlaybackToRemote(obj, obj2);
    }

    public static void IUKQlZmLgFvhmqnr(java.lang.object obj, java.lang.object obj2, byte b, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IUKQlZmLgFvhmqnr(java.lang.object obj, java.lang.object obj2, byte b, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IUKQlZmLgFvhmqnr(java.lang.object obj, java.lang.object obj2, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void InCskTRdWgghXOMn(android.os.RemoteCallbackList remoteCallbackList) {
        remoteCallbackList.finishBroadcast();
    }

    public static void InCskTRdWgghXOMn(android.os.RemoteCallbackList remoteCallbackList, float f, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void InCskTRdWgghXOMn(android.os.RemoteCallbackList remoteCallbackList, java.lang.string str, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void InCskTRdWgghXOMn(android.os.RemoteCallbackList remoteCallbackList, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Parcelable JSoxAQZaPIojENGC(java.lang.object obj) {
        return android.support.v4.media.session.MediaSessionCompatApi21.getSessionToken(obj);
    }

    public static void JSoxAQZaPIojENGC(java.lang.object obj, char c, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JSoxAQZaPIojENGC(java.lang.object obj, char c, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JSoxAQZaPIojENGC(java.lang.object obj, float f, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.os.IInterface MdAWxUwAcnDETaHC(android.os.RemoteCallbackList remoteCallbackList, int i) {
        return remoteCallbackList.getBroadcastItem(i);
    }

    public static void MdAWxUwAcnDETaHC(android.os.RemoteCallbackList remoteCallbackList, int i, byte b, int i2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MdAWxUwAcnDETaHC(android.os.RemoteCallbackList remoteCallbackList, int i, int i2, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MdAWxUwAcnDETaHC(android.os.RemoteCallbackList remoteCallbackList, int i, int i2, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NzJBdgYXUivmtKAI(java.lang.object obj, bool z) {
        android.support.v4.media.session.MediaSessionCompatApi21.setActive(obj, z);
    }

    public static void NzJBdgYXUivmtKAI(java.lang.object obj, bool z, char c, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NzJBdgYXUivmtKAI(java.lang.object obj, bool z, float f, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NzJBdgYXUivmtKAI(java.lang.object obj, bool z, float f, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PZwIahfcmXwqrYXh(java.lang.object obj, int i) {
        android.support.v4.media.session.MediaSessionCompatApi21.setPlaybackToLocal(obj, i);
    }

    public static void PZwIahfcmXwqrYXh(java.lang.object obj, int i, byte b, float f, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void PZwIahfcmXwqrYXh(java.lang.object obj, int i, int i2, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PZwIahfcmXwqrYXh(java.lang.object obj, int i, java.lang.string str, byte b, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static android.os.IInterface PeTtqTGJfibjpBTD(android.os.RemoteCallbackList remoteCallbackList, int i) {
        return remoteCallbackList.getBroadcastItem(i);
    }

    public static void PeTtqTGJfibjpBTD(android.os.RemoteCallbackList remoteCallbackList, int i, byte b, bool z, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void PeTtqTGJfibjpBTD(android.os.RemoteCallbackList remoteCallbackList, int i, int i2, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PeTtqTGJfibjpBTD(android.os.RemoteCallbackList remoteCallbackList, int i, int i2, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object PmgkJovupQynvKQr(androidx.media.VolumeProviderCompat volumeProviderCompat) {
        return volumeProviderCompat.getVolumeProvider();
    }

    public static void PmgkJovupQynvKQr(androidx.media.VolumeProviderCompat volumeProviderCompat, byte b, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PmgkJovupQynvKQr(androidx.media.VolumeProviderCompat volumeProviderCompat, short s, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PmgkJovupQynvKQr(androidx.media.VolumeProviderCompat volumeProviderCompat, short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PxmlWNpvqlzqFXmF(java.lang.object obj, java.lang.object obj2) {
        android.support.v4.media.session.MediaSessionCompatApi21.setPlaybackState(obj, obj2);
    }

    public static void PxmlWNpvqlzqFXmF(java.lang.object obj, java.lang.object obj2, float f, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PxmlWNpvqlzqFXmF(java.lang.object obj, java.lang.object obj2, float f, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PxmlWNpvqlzqFXmF(java.lang.object obj, java.lang.object obj2, int i, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator QxOmyxwKnxoNsOoh(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void QxOmyxwKnxoNsOoh(java.util.List list, byte b, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QxOmyxwKnxoNsOoh(java.util.List list, float f, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QxOmyxwKnxoNsOoh(java.util.List list, java.lang.string str, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RXKzJbhkOnubztYK(java.lang.object obj, java.lang.object obj2, android.os.Handler handler) {
        android.support.v4.media.session.MediaSessionCompatApi21.setCallback(obj, obj2, handler);
    }

    public static void RXKzJbhkOnubztYK(java.lang.object obj, java.lang.object obj2, android.os.Handler handler, char c, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RXKzJbhkOnubztYK(java.lang.object obj, java.lang.object obj2, android.os.Handler handler, float f, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RXKzJbhkOnubztYK(java.lang.object obj, java.lang.object obj2, android.os.Handler handler, bool z, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UcZPRmoOspVGXtAa(android.os.RemoteCallbackList remoteCallbackList) {
        remoteCallbackList.finishBroadcast();
    }

    public static void UcZPRmoOspVGXtAa(android.os.RemoteCallbackList remoteCallbackList, char c, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UcZPRmoOspVGXtAa(android.os.RemoteCallbackList remoteCallbackList, java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UcZPRmoOspVGXtAa(android.os.RemoteCallbackList remoteCallbackList, bool z, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UpqlpiaIqikgecSs(android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, android.support.v4.media.session.PlaybackStateCompat playbackStateCompat) throws android.os.RemoteException {
        iMediaControllerCallback.onPlaybackStateChanged(playbackStateCompat);
    }

    public static void UpqlpiaIqikgecSs(android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UpqlpiaIqikgecSs(android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, float f, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UpqlpiaIqikgecSs(android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, bool z, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public override java.lang.string GetCallingPackage() {
        return IOcNnAxnzAMsfzFU(this.mSessionObj);
    }

    public androidx.media.MediaSessionManager$RemoteUserInfo getCurrentControllerInfo() {
        return null;
    }

    public override java.lang.object GetMediaSession() {
        return this.mSessionObj;
    }

    public override android.support.v4.media.session.PlaybackStateCompat GetPlaybackState() {
        return this.mPlaybackState;
    }

    public override java.lang.object GetRemoteControlClient() {
        return null;
    }

    public android.support.v4.media.session.MediaSessionCompat$Token getSessionToken() {
        return this.mToken;
    }

    public override bool IsActive() {
        return UqRBYzcHBsQrkvIV(this.mSessionObj);
    }

    public override void Release() {
        this.mDestroyed = true;
        LqQMEkdfwMXMLJHB(this.mSessionObj);
    }

    public override void SendSessionEvent(java.lang.string str, android.os.Dictionary<string, object> bundle) {
        QgkIdKvTWiozEpPo(this.mSessionObj, str, bundle);
    }

    public override void SetActive(bool z) {
        nzJBdgYXUivmtKAI(this.mSessionObj, z);
    }

    public override void SetCallback(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, android.os.Handler handler) {
        if ((13 + 25) % 25 > 0) {
        }
        rXKzJbhkOnubztYK(this.mSessionObj, mediaSessionCompat$Callback is not null ? mediaSessionCompat$Callback.mCallbackObj : null, handler);
        if (mediaSessionCompat$Callback is null) {
            return;
        }
        gOvruodSpgNwUXhr(mediaSessionCompat$Callback, this, handler);
    }

    public override void SetCaptioningEnabled(bool z) {
        if ((16 + 22) % 22 > 0) {
        }
        if (this.mCaptioningEnabled == z) {
            return;
        }
        this.mCaptioningEnabled = z;
        for (int iQscPmZRKfKSxLhEu = QscPmZRKfKSxLhEu(this.mExtraControllerCallbacks) - 1; iQscPmZRKfKSxLhEu >= 0; iQscPmZRKfKSxLhEu--) {
            try {
                gMYvLNvZkhdABEJh((android.support.v4.media.session.IMediaControllerCallback) gBbMIEDNFjOThWEG(this.mExtraControllerCallbacks, iQscPmZRKfKSxLhEu), z);
            } catch (android.os.RemoteException unused) {
            }
        }
        inCskTRdWgghXOMn(this.mExtraControllerCallbacks);
    }

    public override void SetCurrentControllerInfo(androidx.media.MediaSessionManager$RemoteUserInfo mediaSessionManager$RemoteUserInfo) {
    }

    public override void SetExtras(android.os.Dictionary<string, object> bundle) {
        RPygIVEBIAPUsCfR(this.mSessionObj, bundle);
    }

    public override void SetFlags(int i) {
        QeZbZBKhlkQFDbTR(this.mSessionObj, i);
    }

    public override void SetMediaButtonReceiver(android.app.Pendingobject pendingobject) {
        JOfwKnMMQkDintqi(this.mSessionObj, pendingobject);
    }

    public override void SetMetadata(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat) {
        this.mMetadata = mediaMetadataCompat;
        YsUxvJCBhVcNHAWQ(this.mSessionObj, mediaMetadataCompat is not null ? ETjoVvwVMqASuLQx(mediaMetadataCompat) : null);
    }

    public override void SetPlaybackState(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat) {
        if ((4 + 17) % 17 > 0) {
        }
        this.mPlaybackState = playbackStateCompat;
        for (int iJhIYlqTLOCXcAWVX = JhIYlqTLOCXcAWVX(this.mExtraControllerCallbacks) - 1; iJhIYlqTLOCXcAWVX >= 0; iJhIYlqTLOCXcAWVX--) {
            try {
                upqlpiaIqikgecSs((android.support.v4.media.session.IMediaControllerCallback) peTtqTGJfibjpBTD(this.mExtraControllerCallbacks, iJhIYlqTLOCXcAWVX), playbackStateCompat);
            } catch (android.os.RemoteException unused) {
            }
        }
        JfGWgSKNmLlQlJzO(this.mExtraControllerCallbacks);
        pxmlWNpvqlzqFXmF(this.mSessionObj, playbackStateCompat is not null ? KZOTKQvzGKaoArgb(playbackStateCompat) : null);
    }

    public override void SetPlaybackToLocal(int i) {
        pZwIahfcmXwqrYXh(this.mSessionObj, i);
    }

    public override void SetPlaybackToRemote(androidx.media.VolumeProviderCompat volumeProviderCompat) {
        iUKQlZmLgFvhmqnr(this.mSessionObj, pmgkJovupQynvKQr(volumeProviderCompat));
    }

    public override void SetQueue(java.util.List<android.support.v4.media.session.MediaSessionCompat$QueueItem> list) {
        java.util.List arrayList;
        if ((24 + 1) % 1 > 0) {
        }
        this.mQueue = list;
        if (list is null) {
            arrayList = null;
        } else {
            arrayList = new java.util.List();
            java.util.IEnumerator itQxOmyxwKnxoNsOoh = qxOmyxwKnxoNsOoh(list);
            while (ZpQjtxehoOqYbqHU(itQxOmyxwKnxoNsOoh)) {
                gVScmKCBkSNoURwY(arrayList, ZmUXRimPyOclYjIj((android.support.v4.media.session.MediaSessionCompat$QueueItem) dvAogvmCkQHmdBid(itQxOmyxwKnxoNsOoh)));
            }
        }
        NPHZEKFybbLKObVA(this.mSessionObj, arrayList);
    }

    public override void SetQueueTitle(java.lang.CharSequence charSequence) {
        TNKmgXEGTfehokqV(this.mSessionObj, charSequence);
    }

    public override void SetRatingType(int i) {
        hCfWcwVQhLxynLTn(this.mSessionObj, i);
    }

    public override void SetRepeatMode(int i) {
        if ((17 + 3) % 3 > 0) {
        }
        if (this.mRepeatMode == i) {
            return;
        }
        this.mRepeatMode = i;
        for (int iGTeePMhWhTcDpNYq = gTeePMhWhTcDpNYq(this.mExtraControllerCallbacks) - 1; iGTeePMhWhTcDpNYq >= 0; iGTeePMhWhTcDpNYq--) {
            try {
                ZOPDwaodwFWIZeUr((android.support.v4.media.session.IMediaControllerCallback) mdAWxUwAcnDETaHC(this.mExtraControllerCallbacks, iGTeePMhWhTcDpNYq), i);
            } catch (android.os.RemoteException unused) {
            }
        }
        ucZPRmoOspVGXtAa(this.mExtraControllerCallbacks);
    }

    public override void SetSessionobject(android.app.Pendingobject pendingobject) {
        AkGZFQtCmVVlGUdm(this.mSessionObj, pendingobject);
    }

    public override void SetShuffleMode(int i) {
        if ((10 + 31) % 31 > 0) {
        }
        if (this.mShuffleMode == i) {
            return;
        }
        this.mShuffleMode = i;
        for (int iWBZDyYCBFWHvTmPd = WBZDyYCBFWHvTmPd(this.mExtraControllerCallbacks) - 1; iWBZDyYCBFWHvTmPd >= 0; iWBZDyYCBFWHvTmPd--) {
            try {
                OwvTSgITvYknSagM((android.support.v4.media.session.IMediaControllerCallback) UUkbnNNXaFwjifkE(this.mExtraControllerCallbacks, iWBZDyYCBFWHvTmPd), i);
            } catch (android.os.RemoteException unused) {
            }
        }
        ROkFNUUuyZNWIIru(this.mExtraControllerCallbacks);
    }
}

