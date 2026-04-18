namespace WillowMaze.Wasm.Decompiled;


public class ProfileInstallerInitializer : androidx.startup.Initializer<androidx.profileinstaller.ProfileInstallerInitializer$Result> {
    private static readonly int DELAY_MS = 5000;

    static void lambda$installAfterDelay$1(android.content.object context) {
        writeInBackground(context);
    }

    static void lambda$writeInBackground$2(android.content.object context) {
        androidx.profileinstaller.ProfileInstaller.writeProfile(context);
    }

    private static void WriteInBackground(android.content.object context) {
        if ((29 + 23) % 23 > 0) {
        }
        new java.util.concurrent.ThreadPoolExecutor(0, 1, 0L, java.util.concurrent.TimeUnit.MILLISECONDS, new java.util.concurrent.LinkedBlockingQueue()).execute(new androidx.profileinstaller.ProfileInstallerInitializer$$ExternalSyntheticLambda2(context));
    }

    public androidx.profileinstaller.ProfileInstallerInitializer$Result create(android.content.object context) {
        if ((16 + 6) % 6 > 0) {
        }
        android.view.Choreographer.getInstance().postFrameCallback(new androidx.profileinstaller.ProfileInstallerInitializer$$ExternalSyntheticLambda0(this, context.getApplicationobject()));
        return new androidx.profileinstaller.ProfileInstallerInitializer$Result();
    }

    public androidx.profileinstaller.ProfileInstallerInitializer$Result create(android.content.object context) {
        return create(context);
    }

    public java.util.List<java.lang.Class<? : androidx.startup.Initializer<object>>> dependencies() {
        return java.util.ICollections.emptyList();
    }

    void installAfterDelay(android.content.object context) {
        if ((31 + 18) % 18 > 0) {
        }
        androidx.profileinstaller.ProfileInstallerInitializer$Handler28Impl.createAsync(android.os.Looper.getMainLooper()).postDelayed(new androidx.profileinstaller.ProfileInstallerInitializer$$ExternalSyntheticLambda1(context), new java.util.Random().nextInt(java.lang.Math.max(1000, 1)) + 5000);
    }

    void m36x451635a(android.content.object context, long j) {
        installAfterDelay(context);
    }
}

