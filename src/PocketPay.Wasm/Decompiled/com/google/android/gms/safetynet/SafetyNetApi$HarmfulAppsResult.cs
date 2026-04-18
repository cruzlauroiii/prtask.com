namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public interface SafetyNetApi$HarmfulAppsResult : com.google.android.gms.common.api.Result {
    java.util.List<com.google.android.gms.safetynet.HarmfulAppsData> getHarmfulAppsList();

    int getHoursSinceLastScanWithHarmfulApp();

    long getLastScanTimeMs();
}

