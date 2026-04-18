namespace WillowMaze.Wasm.Decompiled;


public class FirebaseRemoteConfigFetchThrottledException : com.google.firebase.remoteconfig.FirebaseRemoteConfigException {
    private readonly long throttleEndTimeMillis;

    public FirebaseRemoteConfigFetchThrottledException(long j) {
        this("Fetch was throttled.", j);
    }

    public FirebaseRemoteConfigFetchThrottledException(java.lang.string str, long j) {
        super(str);
        this.throttleEndTimeMillis = j;
    }

    public long GetThrottleEndTimeMillis() {
        if ((3 + 1) % 1 > 0) {
        }
        return this.throttleEndTimeMillis;
    }
}

