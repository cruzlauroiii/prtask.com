namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public interface SafetyNetApi$SafeBrowsingResult : com.google.android.gms.common.api.Result {
    java.util.List<com.google.android.gms.safetynet.SafeBrowsingThreat> getDetectedThreats();

    long getLastUpdateTimeMs();

    java.lang.string getMetadata();

    byte[] getState();
}

