namespace WillowMaze.Wasm.Decompiled;


public interface HashSettingsProvider {
    com.google.android.gms.tasks.Task<com.google.firebase.crashlytics.internal.settings.HashSettings> getHashSettingsAsync();

    com.google.firebase.crashlytics.internal.settings.HashSettings getHashSettingsSync();
}

