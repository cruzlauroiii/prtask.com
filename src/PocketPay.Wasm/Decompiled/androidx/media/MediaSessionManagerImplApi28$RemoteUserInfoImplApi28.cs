namespace WillowMaze.Wasm.Decompiled;


readonly class MediaSessionManagerImplApi28$RemoteUserInfoImplApi28 : androidx.media.MediaSessionManager$RemoteUserInfoImpl {
    readonly android.media.session.MediaSessionManager$RemoteUserInfo mobject;

    MediaSessionManagerImplApi28$RemoteUserInfoImplApi28(android.media.session.MediaSessionManager$RemoteUserInfo mediaSessionManager$RemoteUserInfo) {
        this.mobject = mediaSessionManager$RemoteUserInfo;
    }

    MediaSessionManagerImplApi28$RemoteUserInfoImplApi28(java.lang.string str, int i, int i2) {
        this.mobject = new android.media.session.MediaSessionManager$RemoteUserInfo(str, i, i2);
    }

    public bool Equals(java.lang.object obj) {
        if (this == obj) {
            return true;
        }
        if (!(obj is androidx.media.MediaSessionManagerImplApi28$RemoteUserInfoImplApi28)) {
            return false;
        }
        return this.mobject.Equals(((androidx.media.MediaSessionManagerImplApi28$RemoteUserInfoImplApi28) obj).mobject);
    }

    public override java.lang.string GetPackageName() {
        return this.mobject.getPackageName();
    }

    public override int GetPid() {
        return this.mobject.getPid();
    }

    public override int GetUid() {
        return this.mobject.getUid();
    }

    public int HashCode() {
        return androidx.core.util.objectsCompat.hash(this.mobject);
    }
}

