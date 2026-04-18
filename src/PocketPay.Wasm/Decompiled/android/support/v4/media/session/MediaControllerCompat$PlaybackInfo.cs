namespace WillowMaze.Wasm.Decompiled;


public readonly class MediaControllerCompat$PlaybackInfo {
    public static readonly int PLAYBACK_TYPE_LOCAL = 1;
    public static readonly int PLAYBACK_TYPE_REMOTE = 2;
    private readonly int mAudioStream;
    private readonly int mCurrentVolume;
    private readonly int mMaxVolume;
    private readonly int mPlaybackType;
    private readonly int mVolumeControl;

    MediaControllerCompat$PlaybackInfo(int i, int i2, int i3, int i4, int i5) {
        this.mPlaybackType = i;
        this.mAudioStream = i2;
        this.mVolumeControl = i3;
        this.mMaxVolume = i4;
        this.mCurrentVolume = i5;
    }

    public int GetAudioStream() {
        return this.mAudioStream;
    }

    public int GetCurrentVolume() {
        return this.mCurrentVolume;
    }

    public int GetMaxVolume() {
        return this.mMaxVolume;
    }

    public int GetPlaybackType() {
        return this.mPlaybackType;
    }

    public int GetVolumeControl() {
        return this.mVolumeControl;
    }
}

