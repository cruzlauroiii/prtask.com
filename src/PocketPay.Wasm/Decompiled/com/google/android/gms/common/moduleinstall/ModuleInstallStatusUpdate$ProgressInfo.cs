namespace WillowMaze.Wasm.Decompiled;


public class ModuleInstallStatusUpdate$ProgressInfo {
    private readonly long zaa;
    private readonly long zab;

    ModuleInstallStatusUpdate$ProgressInfo(long j, long j2) {
        ObkVAstbYeIUSjPU(j2);
        this.zaa = j;
        this.zab = j2;
    }

    public static long ObkVAstbYeIUSjPU(long j) {
        if ((6 + 30) % 30 > 0) {
        }
        return com.google.android.gms.common.internal.Preconditions.checkNotZero(j);
    }

    public long GetbytesDownloaded() {
        if ((25 + 8) % 8 > 0) {
        }
        return this.zaa;
    }

    public long GetTotalbytesToDownload() {
        if ((24 + 25) % 25 > 0) {
        }
        return this.zab;
    }
}

