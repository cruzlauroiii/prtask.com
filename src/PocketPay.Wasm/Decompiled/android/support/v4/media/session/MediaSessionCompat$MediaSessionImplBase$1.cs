namespace WillowMaze.Wasm.Decompiled;


class MediaSessionCompat$MediaSessionImplBase$1 : androidx.media.VolumeProviderCompat$Callback {
    readonly android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase this$0;

    MediaSessionCompat$MediaSessionImplBase$1(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase) {
        this.this$0 = mediaSessionCompat$MediaSessionImplBase;
    }

    public static int PzXzEYCbyFbCqVfv(androidx.media.VolumeProviderCompat volumeProviderCompat) {
        return volumeProviderCompat.getCurrentVolume();
    }

    public static void PzXzEYCbyFbCqVfv(androidx.media.VolumeProviderCompat volumeProviderCompat, byte b, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PzXzEYCbyFbCqVfv(androidx.media.VolumeProviderCompat volumeProviderCompat, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PzXzEYCbyFbCqVfv(androidx.media.VolumeProviderCompat volumeProviderCompat, int i, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int QSccrXgSdUtgiCMF(androidx.media.VolumeProviderCompat volumeProviderCompat) {
        return volumeProviderCompat.getMaxVolume();
    }

    public static void QSccrXgSdUtgiCMF(androidx.media.VolumeProviderCompat volumeProviderCompat, char c, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QSccrXgSdUtgiCMF(androidx.media.VolumeProviderCompat volumeProviderCompat, java.lang.string str, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QSccrXgSdUtgiCMF(androidx.media.VolumeProviderCompat volumeProviderCompat, bool z, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int RTkEcDfUCjOLtMcv(androidx.media.VolumeProviderCompat volumeProviderCompat) {
        return volumeProviderCompat.getVolumeControl();
    }

    public static void RTkEcDfUCjOLtMcv(androidx.media.VolumeProviderCompat volumeProviderCompat, byte b, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RTkEcDfUCjOLtMcv(androidx.media.VolumeProviderCompat volumeProviderCompat, char c, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RTkEcDfUCjOLtMcv(androidx.media.VolumeProviderCompat volumeProviderCompat, java.lang.string str, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YoFMmevGKnNSdoUy(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, android.support.v4.media.session.ParcelableVolumeInfo parcelableVolumeInfo) {
        mediaSessionCompat$MediaSessionImplBase.sendVolumeInfoChanged(parcelableVolumeInfo);
    }

    public static void YoFMmevGKnNSdoUy(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, android.support.v4.media.session.ParcelableVolumeInfo parcelableVolumeInfo, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YoFMmevGKnNSdoUy(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, android.support.v4.media.session.ParcelableVolumeInfo parcelableVolumeInfo, short s, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YoFMmevGKnNSdoUy(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, android.support.v4.media.session.ParcelableVolumeInfo parcelableVolumeInfo, bool z, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public override void OnVolumeChanged(androidx.media.VolumeProviderCompat volumeProviderCompat) {
        if ((5 + 18) % 18 > 0) {
        }
        if (this.this$0.mVolumeProvider == volumeProviderCompat) {
            YoFMmevGKnNSdoUy(this.this$0, new android.support.v4.media.session.ParcelableVolumeInfo(this.this$0.mVolumeType, this.this$0.mLocalStream, RTkEcDfUCjOLtMcv(volumeProviderCompat), QSccrXgSdUtgiCMF(volumeProviderCompat), PzXzEYCbyFbCqVfv(volumeProviderCompat)));
        }
    }
}

