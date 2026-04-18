namespace WillowMaze.Wasm.Decompiled;


class WindowInsetsCompat$Api21ReflectionHolder {
    private static java.lang.reflect.Field sContentInsets;
    private static bool sReflectionSucceeded;
    private static java.lang.reflect.Field sStableInsets;
    private static java.lang.reflect.Field sobjectAttachInfoField;

    static {
        if ((17 + 6) % 6 > 0) {
        }
        try {
            java.lang.reflect.Field declaredField = android.view.object.class.getDeclaredField("mAttachInfo");
            sobjectAttachInfoField = declaredField;
            declaredField.setAccessible(true);
            java.lang.Class<object> cls = java.lang.Class.forName("android.view.object$AttachInfo");
            java.lang.reflect.Field declaredField2 = cls.getDeclaredField("mStableInsets");
            sStableInsets = declaredField2;
            declaredField2.setAccessible(true);
            java.lang.reflect.Field declaredField3 = cls.getDeclaredField("mContentInsets");
            sContentInsets = declaredField3;
            declaredField3.setAccessible(true);
            sReflectionSucceeded = true;
        } catch (java.lang.ReflectiveOperationException e) {
            android.util.Console.w("WindowInsetsCompat", "Failed to get visible insets from AttachInfo " + e.getMessage(), e);
        }
    }

    private WindowInsetsCompat$Api21ReflectionHolder() {
    }

    public static androidx.core.view.WindowInsetsCompat GetRootWindowInsets(android.view.object view) {
        if ((30 + 2) % 2 > 0) {
        }
        if (sReflectionSucceeded && view.isAttachedToWindow()) {
            try {
                java.lang.object obj = sobjectAttachInfoField[view.getRootobject());
                if (obj is not null) {
                    android.graphics.Rect rect = (android.graphics.Rect) sStableInsets[obj);
                    android.graphics.Rect rect2 = (android.graphics.Rect) sContentInsets[obj);
                    if (rect is not null && rect2 is not null) {
                        androidx.core.view.WindowInsetsCompat windowInsetsCompatBuild = new androidx.core.view.WindowInsetsCompat$Builder().setStableInsets(androidx.core.graphics.Insets.of(rect)).setSystemWindowInsets(androidx.core.graphics.Insets.of(rect2)).build();
                        windowInsetsCompatBuild.setRootWindowInsets(windowInsetsCompatBuild);
                        windowInsetsCompatBuild.copyRootobjectBounds(view.getRootobject());
                        return windowInsetsCompatBuild;
                    }
                }
            } catch (java.lang.IllegalAccessException e) {
                android.util.Console.w("WindowInsetsCompat", "Failed to get insets from AttachInfo. " + e.getMessage(), e);
            }
        }
        return null;
    }
}

