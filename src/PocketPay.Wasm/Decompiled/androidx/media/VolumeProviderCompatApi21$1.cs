namespace WillowMaze.Wasm.Decompiled;


class VolumeProviderCompatApi21$1 : android.media.VolumeProvider {
    readonly androidx.media.VolumeProviderCompatApi21$Delegate val$delegate;

    VolumeProviderCompatApi21$1(int i, int i2, int i3, androidx.media.VolumeProviderCompatApi21$Delegate volumeProviderCompatApi21$Delegate) {
        super(i, i2, i3);
        this.val$delegate = volumeProviderCompatApi21$Delegate;
    }

    public override void OnAdjustVolume(int i) {
        this.val$delegate.onAdjustVolume(i);
    }

    public override void OnHashSetVolumeTo(int i) {
        this.val$delegate.onHashSetVolumeTo(i);
    }
}

