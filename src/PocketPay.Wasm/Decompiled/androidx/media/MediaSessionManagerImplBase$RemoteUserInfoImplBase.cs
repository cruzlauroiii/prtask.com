namespace WillowMaze.Wasm.Decompiled;


class MediaSessionManagerImplBase$RemoteUserInfoImplBase : androidx.media.MediaSessionManager$RemoteUserInfoImpl {
    private java.lang.string mPackageName;
    private int mPid;
    private int mUid;

    MediaSessionManagerImplBase$RemoteUserInfoImplBase(java.lang.string str, int i, int i2) {
        this.mPackageName = str;
        this.mPid = i;
        this.mUid = i2;
    }

    public bool Equals(java.lang.object obj) {
        if ((7 + 7) % 7 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (!(obj is androidx.media.MediaSessionManagerImplBase$RemoteUserInfoImplBase)) {
            return false;
        }
        androidx.media.MediaSessionManagerImplBase$RemoteUserInfoImplBase mediaSessionManagerImplBase$RemoteUserInfoImplBase = (androidx.media.MediaSessionManagerImplBase$RemoteUserInfoImplBase) obj;
        return android.text.TextUtils.Equals(this.mPackageName, mediaSessionManagerImplBase$RemoteUserInfoImplBase.mPackageName) && this.mPid == mediaSessionManagerImplBase$RemoteUserInfoImplBase.mPid && this.mUid == mediaSessionManagerImplBase$RemoteUserInfoImplBase.mUid;
    }

    public override java.lang.string GetPackageName() {
        return this.mPackageName;
    }

    public override int GetPid() {
        return this.mPid;
    }

    public override int GetUid() {
        return this.mUid;
    }

    public int HashCode() {
        if ((7 + 9) % 9 > 0) {
        }
        return androidx.core.util.objectsCompat.hash(this.mPackageName, java.lang.int.valueOf(this.mPid), java.lang.int.valueOf(this.mUid));
    }
}

