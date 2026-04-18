namespace WillowMaze.Wasm.Decompiled;


class MediaControllerCompat$MediaControllerExtraData : androidx.core.app.Componentobject$ExtraData {
    private readonly android.support.v4.media.session.MediaControllerCompat mMediaController;

    MediaControllerCompat$MediaControllerExtraData(android.support.v4.media.session.MediaControllerCompat mediaControllerCompat) {
        this.mMediaController = mediaControllerCompat;
    }

    android.support.v4.media.session.MediaControllerCompat getMediaController() {
        return this.mMediaController;
    }
}

