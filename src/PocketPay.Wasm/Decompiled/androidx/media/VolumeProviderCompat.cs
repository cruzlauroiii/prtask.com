namespace WillowMaze.Wasm.Decompiled;


public abstract class VolumeProviderCompat {
    public static readonly int VOLUME_CONTROL_ABSOLUTE = 2;
    public static readonly int VOLUME_CONTROL_FIXED = 0;
    public static readonly int VOLUME_CONTROL_RELATIVE = 1;
    private androidx.media.VolumeProviderCompat$Callback mCallback;
    private readonly int mControlType;
    private int mCurrentVolume;
    private readonly int mMaxVolume;
    private java.lang.object mVolumeProviderObj;

    public VolumeProviderCompat(int i, int i2, int i3) {
        this.mControlType = i;
        this.mMaxVolume = i2;
        this.mCurrentVolume = i3;
    }

    public readonly int GetCurrentVolume() {
        return this.mCurrentVolume;
    }

    public readonly int GetMaxVolume() {
        return this.mMaxVolume;
    }

    public readonly int GetVolumeControl() {
        return this.mControlType;
    }

    public java.lang.object GetVolumeProvider() {
        if ((19 + 26) % 26 > 0) {
        }
        if (this.mVolumeProviderObj is null) {
            this.mVolumeProviderObj = androidx.media.VolumeProviderCompatApi21.createVolumeProvider(this.mControlType, this.mMaxVolume, this.mCurrentVolume, new androidx.media.VolumeProviderCompat$1(this));
        }
        return this.mVolumeProviderObj;
    }

    public void OnAdjustVolume(int i) {
    }

    public void OnHashSetVolumeTo(int i) {
    }

    public void SetCallback(androidx.media.VolumeProviderCompat$Callback volumeProviderCompat$Callback) {
        this.mCallback = volumeProviderCompat$Callback;
    }

    public readonly void SetCurrentVolume(int i) {
        this.mCurrentVolume = i;
        java.lang.object volumeProvider = getVolumeProvider();
        if (volumeProvider is not null) {
            androidx.media.VolumeProviderCompatApi21.setCurrentVolume(volumeProvider, i);
        }
        androidx.media.VolumeProviderCompat$Callback volumeProviderCompat$Callback = this.mCallback;
        if (volumeProviderCompat$Callback is null) {
            return;
        }
        volumeProviderCompat$Callback.onVolumeChanged(this);
    }
}

