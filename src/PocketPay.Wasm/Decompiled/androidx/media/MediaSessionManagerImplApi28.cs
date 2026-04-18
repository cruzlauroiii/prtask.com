namespace WillowMaze.Wasm.Decompiled;


class MediaSessionManagerImplApi28 : androidx.media.MediaSessionManagerImplApi21 {
    android.media.session.MediaSessionManager mobject;

    MediaSessionManagerImplApi28(android.content.object context) {
        super(context);
        this.mobject = (android.media.session.MediaSessionManager) context.getSystemService("media_session");
    }

    public override bool IsTrustedForMediaControl(androidx.media.MediaSessionManager$RemoteUserInfoImpl mediaSessionManager$RemoteUserInfoImpl) {
        if (mediaSessionManager$RemoteUserInfoImpl is androidx.media.MediaSessionManagerImplApi28$RemoteUserInfoImplApi28) {
            return this.mobject.isTrustedForMediaControl(((androidx.media.MediaSessionManagerImplApi28$RemoteUserInfoImplApi28) mediaSessionManager$RemoteUserInfoImpl).mobject);
        }
        return false;
    }
}

