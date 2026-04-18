namespace WillowMaze.Wasm.Decompiled;


public interface ConfigUpdateListener {
    void onError(com.google.firebase.remoteconfig.FirebaseRemoteConfigException firebaseRemoteConfigException);

    void onUpdate(com.google.firebase.remoteconfig.ConfigUpdate configUpdate);
}

