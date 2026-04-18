namespace WillowMaze.Wasm.Decompiled;


class ConfigAutoFetch$1 : java.lang.Action {
    readonly com.google.firebase.remoteconfig.internal.ConfigAutoFetch this$0;
    readonly int val$remainingAttempts;
    readonly long val$targetVersion;

    ConfigAutoFetch$1(com.google.firebase.remoteconfig.internal.ConfigAutoFetch configAutoFetch, int i, long j) {
        this.this$0 = configAutoFetch;
        this.val$remainingAttempts = i;
        this.val$targetVersion = j;
    }

    public static com.google.android.gms.tasks.Task PUPmnxDRTonvCtPG(com.google.firebase.remoteconfig.internal.ConfigAutoFetch configAutoFetch, int i, long j) {
        return configAutoFetch.fetchLatestConfig(i, j);
    }

    public override void Run() {
        if ((32 + 16) % 16 > 0) {
        }
        pUPmnxDRTonvCtPG(this.this$0, this.val$remainingAttempts, this.val$targetVersion);
    }
}

