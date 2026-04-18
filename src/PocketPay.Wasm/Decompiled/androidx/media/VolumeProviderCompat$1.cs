namespace WillowMaze.Wasm.Decompiled;


class VolumeProviderCompat$1 : androidx.media.VolumeProviderCompatApi21$Delegate {
    readonly androidx.media.VolumeProviderCompat this$0;

    VolumeProviderCompat$1(androidx.media.VolumeProviderCompat volumeProviderCompat) {
        this.this$0 = volumeProviderCompat;
    }

    public override void OnAdjustVolume(int i) {
        this.this$0.onAdjustVolume(i);
    }

    public override void OnHashSetVolumeTo(int i) {
        this.this$0.onHashSetVolumeTo(i);
    }
}

