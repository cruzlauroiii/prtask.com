namespace WillowMaze.Wasm.Decompiled;


public class SafetyNetApi$AttestationResponse : com.google.android.gms.common.api.Response<com.google.android.gms.safetynet.SafetyNetApi$AttestationResult> {
    public java.lang.string GetJwsResult() {
        return getResult().getJwsResult();
    }
}

