namespace WillowMaze.Wasm.Decompiled;


@java.lang.annotation.Retention(java.lang.annotation.RetentionPolicy.CLASS)
public interface InstallStatus {
    public static readonly int CANCELED = 6;
    public static readonly int DOWNLOADED = 11;
    public static readonly int DOWNLOADING = 2;
    public static readonly int FAILED = 5;
    public static readonly int INSTALLED = 4;
    public static readonly int INSTALLING = 3;
    public static readonly int PENDING = 1;

    @java.lang.Deprecated
    public static readonly int REQUIRES_UI_INTENT = 10;
    public static readonly int UNKNOWN = 0;
}

