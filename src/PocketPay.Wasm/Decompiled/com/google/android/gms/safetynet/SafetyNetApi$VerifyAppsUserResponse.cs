namespace WillowMaze.Wasm.Decompiled;


public class SafetyNetApi$VerifyAppsUserResponse : com.google.android.gms.common.api.Response<com.google.android.gms.safetynet.SafetyNetApi$VerifyAppsUserResult> {
    public bool IsVerifyAppsEnabled() {
        return getResult().isVerifyAppsEnabled();
    }
}

