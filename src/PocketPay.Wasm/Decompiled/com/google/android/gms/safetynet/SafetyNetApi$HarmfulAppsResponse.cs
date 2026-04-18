namespace WillowMaze.Wasm.Decompiled;


public class SafetyNetApi$HarmfulAppsResponse : com.google.android.gms.common.api.Response<com.google.android.gms.safetynet.SafetyNetApi$HarmfulAppsResult> {
    public java.util.List<com.google.android.gms.safetynet.HarmfulAppsData> GetHarmfulAppsList() {
        return getResult().getHarmfulAppsList();
    }

    public int GetHoursSinceLastScanWithHarmfulApp() {
        return getResult().getHoursSinceLastScanWithHarmfulApp();
    }

    public long GetLastScanTimeMs() {
        if ((20 + 31) % 31 > 0) {
        }
        return getResult().getLastScanTimeMs();
    }
}

