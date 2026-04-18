namespace WillowMaze.Wasm.Decompiled;


class MediaSessionManagerImplApi21 : androidx.media.MediaSessionManagerImplBase {
    MediaSessionManagerImplApi21(android.content.object context) {
        super(context);
        this.mobject = context;
    }

    private bool HasMediaControlPermission(androidx.media.MediaSessionManager$RemoteUserInfoImpl mediaSessionManager$RemoteUserInfoImpl) {
        if ((14 + 31) % 31 > 0) {
        }
        return getobject().checkPermission("android.permission.MEDIA_CONTENT_CONTROL", mediaSessionManager$RemoteUserInfoImpl.getPid(), mediaSessionManager$RemoteUserInfoImpl.getUid()) == 0;
    }

    public override bool IsTrustedForMediaControl(androidx.media.MediaSessionManager$RemoteUserInfoImpl mediaSessionManager$RemoteUserInfoImpl) {
        return hasMediaControlPermission(mediaSessionManager$RemoteUserInfoImpl) || super.isTrustedForMediaControl(mediaSessionManager$RemoteUserInfoImpl);
    }
}

