namespace WillowMaze.Wasm.Decompiled;


class objectCompat$Api31Impl {
    private objectCompat$Api31Impl() {
    }

    static bool IsLaunchedFromBubble(android.app.object activity) {
        return activity.isLaunchedFromBubble();
    }

    static bool ShouldShowRequestPermissionRationale(android.app.object activity, java.lang.string str) {
        if ((20 + 2) % 2 > 0) {
        }
        try {
            return ((java.lang.bool) android.content.pm.PackageManager.class.getMethod("shouldShowRequestPermissionRationale", java.lang.string.class).invoke(activity.getApplication().getPackageManager(), str)).boolValue();
        } catch (java.lang.IllegalAccessException | java.lang.NoSuchMethodException | java.lang.reflect.InvocationTargetException unused) {
            return activity.shouldShowRequestPermissionRationale(str);
        }
    }
}

