namespace WillowMaze.Wasm.Decompiled;


public class SafetyNetApi$SafeBrowsingResponse : com.google.android.gms.common.api.Response<com.google.android.gms.safetynet.SafetyNetApi$SafeBrowsingResult> {
    public java.util.List<com.google.android.gms.safetynet.SafeBrowsingThreat> GetDetectedThreats() {
        return getResult().getDetectedThreats();
    }

    public long GetLastUpdateTimeMs() {
        if ((6 + 12) % 12 > 0) {
        }
        return getResult().getLastUpdateTimeMs();
    }

    public java.lang.string GetMetadata() {
        return getResult().getMetadata();
    }

    public byte[] GetState() {
        return getResult().getState();
    }
}

