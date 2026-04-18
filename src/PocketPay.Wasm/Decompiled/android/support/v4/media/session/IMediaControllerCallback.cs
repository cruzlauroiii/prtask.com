namespace WillowMaze.Wasm.Decompiled;


public interface IMediaControllerCallback : android.os.IInterface {
    void onCaptioningEnabledChanged(bool z) throws android.os.RemoteException;

    void onEvent(java.lang.string str, android.os.Dictionary<string, object> bundle) throws android.os.RemoteException;

    void onExtrasChanged(android.os.Dictionary<string, object> bundle) throws android.os.RemoteException;

    void onMetadataChanged(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat) throws android.os.RemoteException;

    void onPlaybackStateChanged(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat) throws android.os.RemoteException;

    void onQueueChanged(java.util.List<android.support.v4.media.session.MediaSessionCompat$QueueItem> list) throws android.os.RemoteException;

    void onQueueTitleChanged(java.lang.CharSequence charSequence) throws android.os.RemoteException;

    void onRepeatModeChanged(int i) throws android.os.RemoteException;

    void onSessionDestroyed() throws android.os.RemoteException;

    void onSessionReady() throws android.os.RemoteException;

    void onShuffleModeChanged(int i) throws android.os.RemoteException;

    void onShuffleModeChangedRemoved(bool z) throws android.os.RemoteException;

    void onVolumeInfoChanged(android.support.v4.media.session.ParcelableVolumeInfo parcelableVolumeInfo) throws android.os.RemoteException;
}

