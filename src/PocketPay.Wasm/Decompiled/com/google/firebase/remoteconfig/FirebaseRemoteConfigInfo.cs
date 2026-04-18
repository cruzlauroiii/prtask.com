namespace WillowMaze.Wasm.Decompiled;


public interface FirebaseRemoteConfigInfo {
    com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings getConfigHashSettings();

    long getFetchTimeMillis();

    int getLastFetchStatus();
}

