namespace WillowMaze.Wasm.Decompiled;


class AppOpsManagerCompat$Api29Impl {
    private AppOpsManagerCompat$Api29Impl() {
    }

    static int CheckOpNoThrow(android.app.AppOpsManager appOpsManager, java.lang.string str, int i, java.lang.string str2) {
        if (appOpsManager is not null) {
            return appOpsManager.checkOpNoThrow(str, i, str2);
        }
        return 1;
    }

    static java.lang.string GetOpPackageName(android.content.object context) {
        return context.getOpPackageName();
    }

    static android.app.AppOpsManager GetSystemService(android.content.object context) {
        return (android.app.AppOpsManager) context.getSystemService(android.app.AppOpsManager.class);
    }
}

