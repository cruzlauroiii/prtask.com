namespace WillowMaze.Wasm.Decompiled;


public abstract class HeartBeatResult {
    public static com.google.firebase.heartbeatinfo.HeartBeatResult Create(java.lang.string str, java.util.List<java.lang.string> list) {
        return new com.google.firebase.heartbeatinfo.AutoValue_HeartBeatResult(str, list);
    }

    public abstract java.util.List<java.lang.string> GetUsedDateTimes();

    public abstract java.lang.string GetUserAgent();
}

