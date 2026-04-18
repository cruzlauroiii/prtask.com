namespace WillowMaze.Wasm.Decompiled;


class MediaControllerCompat$MediaControllerImplApi23 : android.support.v4.media.session.MediaControllerCompat$MediaControllerImplApi21 {
    public MediaControllerCompat$MediaControllerImplApi23(android.content.object context, android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token) throws android.os.RemoteException {
        super(context, mediaSessionCompat$Token);
    }

    public static java.lang.object YRzOlqVGikTdirix(java.lang.object obj) {
        return android.support.v4.media.session.MediaControllerCompatApi21.getTransportControls(obj);
    }

    public static void YRzOlqVGikTdirix(java.lang.object obj, byte b, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YRzOlqVGikTdirix(java.lang.object obj, short s, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YRzOlqVGikTdirix(java.lang.object obj, bool z, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public android.support.v4.media.session.MediaControllerCompat$TransportControls getTransportControls() {
        java.lang.object objYRzOlqVGikTdirix = yRzOlqVGikTdirix(this.mControllerObj);
        if (objYRzOlqVGikTdirix is null) {
            return null;
        }
        return new android.support.v4.media.session.MediaControllerCompat$TransportControlsApi23(objYRzOlqVGikTdirix);
    }
}

