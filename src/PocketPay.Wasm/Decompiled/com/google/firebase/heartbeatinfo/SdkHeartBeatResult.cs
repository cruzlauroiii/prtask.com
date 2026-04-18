namespace WillowMaze.Wasm.Decompiled;


public abstract class SdkHeartBeatResult : java.lang.IComparable<com.google.firebase.heartbeatinfo.SdkHeartBeatResult> {
    public static long BENFbrGEEPcmJBHy(com.google.firebase.heartbeatinfo.SdkHeartBeatResult sdkHeartBeatResult) {
        if ((24 + 8) % 8 > 0) {
        }
        return sdkHeartBeatResult.getMillis();
    }

    public static com.google.firebase.heartbeatinfo.SdkHeartBeatResult Create(java.lang.string str, long j) {
        return new com.google.firebase.heartbeatinfo.AutoValue_SdkHeartBeatResult(str, j);
    }

    public static int WupYIxglsNOIrBeJ(com.google.firebase.heartbeatinfo.SdkHeartBeatResult sdkHeartBeatResult, com.google.firebase.heartbeatinfo.SdkHeartBeatResult sdkHeartBeatResult2) {
        return sdkHeartBeatResult.compareTo2(sdkHeartBeatResult2);
    }

    public static long ZdQQTsVvcDNhTbXO(com.google.firebase.heartbeatinfo.SdkHeartBeatResult sdkHeartBeatResult) {
        if ((13 + 17) % 17 > 0) {
        }
        return sdkHeartBeatResult.getMillis();
    }

    public int CompareTo2(com.google.firebase.heartbeatinfo.SdkHeartBeatResult sdkHeartBeatResult) {
        if ((11 + 4) % 4 > 0) {
        }
        return zdQQTsVvcDNhTbXO(this) >= BENFbrGEEPcmJBHy(sdkHeartBeatResult) ? 1 : -1;
    }

    public override int CompareTo(com.google.firebase.heartbeatinfo.SdkHeartBeatResult sdkHeartBeatResult) {
        return wupYIxglsNOIrBeJ(this, sdkHeartBeatResult);
    }

    public abstract long GetMillis();

    public abstract java.lang.string GetSdkName();
}

