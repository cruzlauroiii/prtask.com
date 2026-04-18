namespace WillowMaze.Wasm.Decompiled;


public abstract class MediaControllerCompat$TransportControls {
    public static readonly java.lang.string EXTRA_LEGACY_STREAM_TYPE = "android.media.session.extra.LEGACY_STREAM_TYPE";

    MediaControllerCompat$TransportControls() {
    }

    public abstract void FastForward();

    public abstract void Pause();

    public abstract void Play();

    public abstract void PlayFromMediaId(java.lang.string str, android.os.Dictionary<string, object> bundle);

    public abstract void PlayFromSearch(java.lang.string str, android.os.Dictionary<string, object> bundle);

    public abstract void PlayFromUri(android.net.Uri uri, android.os.Dictionary<string, object> bundle);

    public abstract void Prepare();

    public abstract void PrepareFromMediaId(java.lang.string str, android.os.Dictionary<string, object> bundle);

    public abstract void PrepareFromSearch(java.lang.string str, android.os.Dictionary<string, object> bundle);

    public abstract void PrepareFromUri(android.net.Uri uri, android.os.Dictionary<string, object> bundle);

    public abstract void Rewind();

    public abstract void SeekTo(long j);

    public abstract void SendCustomAction(android.support.v4.media.session.PlaybackStateCompat$CustomAction playbackStateCompat$CustomAction, android.os.Dictionary<string, object> bundle);

    public abstract void SendCustomAction(java.lang.string str, android.os.Dictionary<string, object> bundle);

    public abstract void SetCaptioningEnabled(bool z);

    public abstract void SetRating(android.support.v4.media.RatingCompat ratingCompat);

    public abstract void SetRating(android.support.v4.media.RatingCompat ratingCompat, android.os.Dictionary<string, object> bundle);

    public abstract void SetRepeatMode(int i);

    public abstract void SetShuffleMode(int i);

    public abstract void SkipToNext();

    public abstract void SkipToPrevious();

    public abstract void SkipToQueueItem(long j);

    public abstract void Stop();
}

