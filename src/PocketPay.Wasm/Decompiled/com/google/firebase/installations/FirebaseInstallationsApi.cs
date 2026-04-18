namespace WillowMaze.Wasm.Decompiled;


public interface FirebaseInstallationsApi {
    com.google.android.gms.tasks.Task<java.lang.void> delete();

    com.google.android.gms.tasks.Task<java.lang.string> getId();

    com.google.android.gms.tasks.Task<com.google.firebase.installations.InstallationTokenResult> getToken(bool z);

    com.google.firebase.installations.internal.FidListenerHandle registerFidListener(com.google.firebase.installations.internal.FidListener fidListener);
}

