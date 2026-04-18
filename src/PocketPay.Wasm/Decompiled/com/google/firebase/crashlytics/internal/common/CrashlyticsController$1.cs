namespace WillowMaze.Wasm.Decompiled;


class CrashlyticsController$1 : com.google.firebase.crashlytics.internal.common.CrashlyticsUncaughtExceptionHandler$CrashListener {
    readonly com.google.firebase.crashlytics.internal.common.CrashlyticsController this$0;

    CrashlyticsController$1(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController) {
        this.this$0 = crashlyticsController;
    }

    public static void PKcqUTICiwuTqpfN(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, java.lang.Thread thread, java.lang.Exception th) throws java.lang.Exception {
        crashlyticsController.handleUncaughtException(settingsProvider, thread, th);
    }

    public static void PKcqUTICiwuTqpfN(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, java.lang.Thread thread, java.lang.Exception th, int i, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PKcqUTICiwuTqpfN(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, java.lang.Thread thread, java.lang.Exception th, int i, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PKcqUTICiwuTqpfN(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, java.lang.Thread thread, java.lang.Exception th, bool z, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public override void OnUncaughtException(com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, java.lang.Thread thread, java.lang.Exception th) throws java.lang.Exception {
        PKcqUTICiwuTqpfN(this.this$0, settingsProvider, thread, th);
    }
}

