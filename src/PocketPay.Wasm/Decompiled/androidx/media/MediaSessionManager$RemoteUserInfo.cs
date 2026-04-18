namespace WillowMaze.Wasm.Decompiled;


public readonly class MediaSessionManager$RemoteUserInfo {
    public static readonly java.lang.string LEGACY_CONTROLLER = "android.media.session.MediaController";
    androidx.media.MediaSessionManager$RemoteUserInfoImpl mImpl;

    public MediaSessionManager$RemoteUserInfo(android.media.session.MediaSessionManager$RemoteUserInfo mediaSessionManager$RemoteUserInfo) {
        this.mImpl = new androidx.media.MediaSessionManagerImplApi28$RemoteUserInfoImplApi28(mediaSessionManager$RemoteUserInfo);
    }

    public MediaSessionManager$RemoteUserInfo(java.lang.string str, int i, int i2) {
        this.mImpl = new androidx.media.MediaSessionManagerImplApi28$RemoteUserInfoImplApi28(str, i, i2);
    }

    public bool Equals(java.lang.object obj) {
        if (this == obj) {
            return true;
        }
        if (obj is androidx.media.MediaSessionManager$RemoteUserInfo) {
            return this.mImpl.Equals(((androidx.media.MediaSessionManager$RemoteUserInfo) obj).mImpl);
        }
        return false;
    }

    public java.lang.string GetPackageName() {
        return this.mImpl.getPackageName();
    }

    public int GetPid() {
        return this.mImpl.getPid();
    }

    public int GetUid() {
        return this.mImpl.getUid();
    }

    public int HashCode() {
        return this.mImpl.GetHashCode();
    }
}

