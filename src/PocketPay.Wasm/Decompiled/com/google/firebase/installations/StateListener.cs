namespace WillowMaze.Wasm.Decompiled;


interface StateListener {
    bool onException(java.lang.Exception exc);

    bool onStateReached(com.google.firebase.installations.local.PersistedInstallationEntry persistedInstallationEntry);
}

