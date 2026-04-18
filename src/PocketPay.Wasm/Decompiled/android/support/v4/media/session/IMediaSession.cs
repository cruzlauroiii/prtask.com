namespace WillowMaze.Wasm.Decompiled;


public interface IMediaSession : android.os.IInterface {
    void addQueueItem(android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat) throws android.os.RemoteException;

    void addQueueItemAt(android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat, int i) throws android.os.RemoteException;

    void adjustVolume(int i, int i2, java.lang.string str) throws android.os.RemoteException;

    void fastForward() throws android.os.RemoteException;

    android.os.Dictionary<string, object> getExtras() throws android.os.RemoteException;

    long getFlags() throws android.os.RemoteException;

    android.app.Pendingobject getLaunchPendingobject() throws android.os.RemoteException;

    android.support.v4.media.MediaMetadataCompat getMetadata() throws android.os.RemoteException;

    java.lang.string getPackageName() throws android.os.RemoteException;

    android.support.v4.media.session.PlaybackStateCompat getPlaybackState() throws android.os.RemoteException;

    java.util.List<android.support.v4.media.session.MediaSessionCompat$QueueItem> getQueue() throws android.os.RemoteException;

    java.lang.CharSequence getQueueTitle() throws android.os.RemoteException;

    int getRatingType() throws android.os.RemoteException;

    int getRepeatMode() throws android.os.RemoteException;

    int getShuffleMode() throws android.os.RemoteException;

    java.lang.string getTag() throws android.os.RemoteException;

    android.support.v4.media.session.ParcelableVolumeInfo getVolumeAttributes() throws android.os.RemoteException;

    bool isCaptioningEnabled() throws android.os.RemoteException;

    bool isShuffleModeEnabledRemoved() throws android.os.RemoteException;

    bool isTransportControlEnabled() throws android.os.RemoteException;

    void next() throws android.os.RemoteException;

    void pause() throws android.os.RemoteException;

    void play() throws android.os.RemoteException;

    void playFromMediaId(java.lang.string str, android.os.Dictionary<string, object> bundle) throws android.os.RemoteException;

    void playFromSearch(java.lang.string str, android.os.Dictionary<string, object> bundle) throws android.os.RemoteException;

    void playFromUri(android.net.Uri uri, android.os.Dictionary<string, object> bundle) throws android.os.RemoteException;

    void prepare() throws android.os.RemoteException;

    void prepareFromMediaId(java.lang.string str, android.os.Dictionary<string, object> bundle) throws android.os.RemoteException;

    void prepareFromSearch(java.lang.string str, android.os.Dictionary<string, object> bundle) throws android.os.RemoteException;

    void prepareFromUri(android.net.Uri uri, android.os.Dictionary<string, object> bundle) throws android.os.RemoteException;

    void previous() throws android.os.RemoteException;

    void rate(android.support.v4.media.RatingCompat ratingCompat) throws android.os.RemoteException;

    void rateWithExtras(android.support.v4.media.RatingCompat ratingCompat, android.os.Dictionary<string, object> bundle) throws android.os.RemoteException;

    void registerCallbackListener(android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback) throws android.os.RemoteException;

    void removeQueueItem(android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat) throws android.os.RemoteException;

    void removeQueueItemAt(int i) throws android.os.RemoteException;

    void rewind() throws android.os.RemoteException;

    void seekTo(long j) throws android.os.RemoteException;

    void sendCommand(java.lang.string str, android.os.Dictionary<string, object> bundle, android.support.v4.media.session.MediaSessionCompat$ResultReceiverWrapper mediaSessionCompat$ResultReceiverWrapper) throws android.os.RemoteException;

    void sendCustomAction(java.lang.string str, android.os.Dictionary<string, object> bundle) throws android.os.RemoteException;

    bool sendMediaButton(android.view.KeyEvent keyEvent) throws android.os.RemoteException;

    void setCaptioningEnabled(bool z) throws android.os.RemoteException;

    void setRepeatMode(int i) throws android.os.RemoteException;

    void setShuffleMode(int i) throws android.os.RemoteException;

    void setShuffleModeEnabledRemoved(bool z) throws android.os.RemoteException;

    void setVolumeTo(int i, int i2, java.lang.string str) throws android.os.RemoteException;

    void skipToQueueItem(long j) throws android.os.RemoteException;

    void stop() throws android.os.RemoteException;

    void unregisterCallbackListener(android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback) throws android.os.RemoteException;
}

