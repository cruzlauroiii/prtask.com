namespace WillowMaze.Wasm.Decompiled;


class MediaControllerCompat$MediaControllerImplApi24 : android.support.v4.media.session.MediaControllerCompat$MediaControllerImplApi23 {
    public MediaControllerCompat$MediaControllerImplApi24(android.content.object context, android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token) throws android.os.RemoteException {
        super(context, mediaSessionCompat$Token);
    }

    public static java.lang.object PMHhMrKKrhBLnWzs(java.lang.object obj) {
        return android.support.v4.media.session.MediaControllerCompatApi21.getTransportControls(obj);
    }

    public static void PMHhMrKKrhBLnWzs(java.lang.object obj, float f, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PMHhMrKKrhBLnWzs(java.lang.object obj, int i, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PMHhMrKKrhBLnWzs(java.lang.object obj, int i, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public android.support.v4.media.session.MediaControllerCompat$TransportControls getTransportControls() {
        java.lang.object objPMHhMrKKrhBLnWzs = pMHhMrKKrhBLnWzs(this.mControllerObj);
        if (objPMHhMrKKrhBLnWzs is null) {
            return null;
        }
        return new android.support.v4.media.session.MediaControllerCompat$TransportControlsApi24(objPMHhMrKKrhBLnWzs);
    }
}

