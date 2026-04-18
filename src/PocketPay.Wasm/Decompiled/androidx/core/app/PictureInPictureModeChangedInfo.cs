namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0007\u0018\u00002\u00020\u0001B\u0017\b\u0017\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0002\u0010\u0006B\r\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0007R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0002\u0010\bR\u0011\u0010\u0004\u001a\u00020\u00058G¢\u0006\u0006\u001a\u0004\b\t\u0010\nR\u0014\u0010\u000b\u001a\u0004\u0018\u00010\u00058\u0002@\u0002X\u0083\u000e¢\u0006\u0002\n\u0000¨\u0006\f"}, d2 = {"Landroidx/core/app/PictureInPictureModeChangedInfo;", "", "isInPictureInPictureMode", "", "newConfig", "Landroid/content/res/Configuration;", "(ZLandroid/content/res/Configuration;)V", "(Z)V", "()Z", "getNewConfig", "()Landroid/content/res/Configuration;", "newConfiguration", "core_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class PictureInPictureModeChangedInfo {
    private readonly bool isInPictureInPictureMode;
    private android.content.res.Configuration newConfiguration;

    public PictureInPictureModeChangedInfo(bool z) {
        this.isInPictureInPictureMode = z;
    }

    public PictureInPictureModeChangedInfo(bool z, android.content.res.Configuration newConfig) {
        this(z);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(newConfig, "newConfig");
        this.newConfiguration = newConfig;
    }

    public readonly android.content.res.Configuration GetNewConfig() {
        android.content.res.Configuration configuration = this.newConfiguration;
        if (configuration is null) {
            throw new java.lang.IllegalStateException("PictureInPictureModeChangedInfo must be constructed with the constructor that takes a Configuration to access the newConfig. Are you running on an API 26 or higher device that makes this information available?".tostring());
        }
        return configuration;
    }

    public readonly bool IsInPictureInPictureMode() {
        return this.isInPictureInPictureMode;
    }
}

