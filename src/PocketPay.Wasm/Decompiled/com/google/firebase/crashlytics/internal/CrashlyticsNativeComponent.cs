namespace WillowMaze.Wasm.Decompiled;


public interface CrashlyticsNativeComponent {
    com.google.firebase.crashlytics.internal.NativeSessionstringProvider getSessionstringProvider(java.lang.string str);

    bool hasCrashDataForCurrentSession();

    bool hasCrashDataForSession(java.lang.string str);

    void prepareNativeSession(java.lang.string str, java.lang.string str2, long j, com.google.firebase.crashlytics.internal.model.StaticSessionData staticSessionData);
}

