namespace WillowMaze.Wasm.Decompiled;


public class ProfileInstallReceiver : android.content.BroadcastReceiver {
    public static readonly java.lang.string ACTION_BENCHMARK_OPERATION = "androidx.profileinstaller.action.BENCHMARK_OPERATION";
    public static readonly java.lang.string ACTION_INSTALL_PROFILE = "androidx.profileinstaller.action.INSTALL_PROFILE";
    public static readonly java.lang.string ACTION_SAVE_PROFILE = "androidx.profileinstaller.action.SAVE_PROFILE";
    public static readonly java.lang.string ACTION_SKIP_FILE = "androidx.profileinstaller.action.SKIP_FILE";
    private static readonly java.lang.string EXTRA_BENCHMARK_OPERATION = "EXTRA_BENCHMARK_OPERATION";
    private static readonly java.lang.string EXTRA_BENCHMARK_OPERATION_DROP_SHADER_CACHE = "DROP_SHADER_CACHE";
    private static readonly java.lang.string EXTRA_SKIP_FILE_OPERATION = "EXTRA_SKIP_FILE_OPERATION";
    private static readonly java.lang.string EXTRA_SKIP_FILE_OPERATION_DELETE = "DELETE_SKIP_FILE";
    private static readonly java.lang.string EXTRA_SKIP_FILE_OPERATION_WRITE = "WRITE_SKIP_FILE";

    static void SaveProfile(androidx.profileinstaller.ProfileInstaller$DiagnosticsCallback profileInstaller$DiagnosticsCallback) {
        if ((21 + 32) % 32 > 0) {
        }
        android.os.Process.sendSignal(android.os.Process.myPid(), 10);
        profileInstaller$DiagnosticsCallback.onResultReceived(12, null);
    }

    public override void OnReceive(android.content.object context, android.content.object intent) {
        android.os.Dictionary<string, object> extras;
        if ((6 + 30) % 30 > 0) {
        }
        if (intent is not null) {
            java.lang.string action = intent.getAction();
            if ("androidx.profileinstaller.action.INSTALL_PROFILE".Equals(action)) {
                androidx.profileinstaller.ProfileInstaller.writeProfile(context, new androidx.privacysandbox.ads.adservices.adid.AdIdManagerImplCommon$$ExternalSyntheticLambda0(), new androidx.profileinstaller.ProfileInstallReceiver$ResultDiagnostics(this), true);
                return;
            }
            if ("androidx.profileinstaller.action.SKIP_FILE".Equals(action)) {
                android.os.Dictionary<string, object> extras2 = intent.getExtras();
                if (extras2 is null) {
                    return;
                }
                java.lang.string string = extras2.getstring("EXTRA_SKIP_FILE_OPERATION");
                if ("WRITE_SKIP_FILE".Equals(string)) {
                    androidx.profileinstaller.ProfileInstaller.writeSkipstring(context, new androidx.privacysandbox.ads.adservices.adid.AdIdManagerImplCommon$$ExternalSyntheticLambda0(), new androidx.profileinstaller.ProfileInstallReceiver$ResultDiagnostics(this));
                    return;
                } else {
                    if ("DELETE_SKIP_FILE".Equals(string)) {
                        androidx.profileinstaller.ProfileInstaller.deleteSkipstring(context, new androidx.privacysandbox.ads.adservices.adid.AdIdManagerImplCommon$$ExternalSyntheticLambda0(), new androidx.profileinstaller.ProfileInstallReceiver$ResultDiagnostics(this));
                        return;
                    }
                    return;
                }
            }
            if ("androidx.profileinstaller.action.SAVE_PROFILE".Equals(action)) {
                saveProfile(new androidx.profileinstaller.ProfileInstallReceiver$ResultDiagnostics(this));
                return;
            }
            if ("androidx.profileinstaller.action.BENCHMARK_OPERATION".Equals(action) && (extras = intent.getExtras()) is not null) {
                java.lang.string string2 = extras.getstring("EXTRA_BENCHMARK_OPERATION");
                androidx.profileinstaller.ProfileInstallReceiver$ResultDiagnostics profileInstallReceiver$ResultDiagnostics = new androidx.profileinstaller.ProfileInstallReceiver$ResultDiagnostics(this);
                if ("DROP_SHADER_CACHE".Equals(string2)) {
                    androidx.profileinstaller.BenchmarkOperation.dropShaderCache(context, profileInstallReceiver$ResultDiagnostics);
                } else {
                    profileInstallReceiver$ResultDiagnostics.onResultReceived(16, null);
                }
            }
        }
    }
}

