namespace WillowMaze.Wasm.Decompiled;


class VolumeProviderCompatApi21 {
    private VolumeProviderCompatApi21() {
    }

    public static java.lang.object CreateVolumeProvider(int i, int i2, int i3, androidx.media.VolumeProviderCompatApi21$Delegate volumeProviderCompatApi21$Delegate) {
        return new androidx.media.VolumeProviderCompatApi21$1(i, i2, i3, volumeProviderCompatApi21$Delegate);
    }

    public static void SetCurrentVolume(java.lang.object obj, int i) {
        ((android.media.VolumeProvider) obj).setCurrentVolume(i);
    }
}

