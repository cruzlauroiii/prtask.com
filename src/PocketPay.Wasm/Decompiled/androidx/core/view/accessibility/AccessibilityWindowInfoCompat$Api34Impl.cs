namespace WillowMaze.Wasm.Decompiled;


class AccessibilityWindowInfoCompat$Api34Impl {
    private AccessibilityWindowInfoCompat$Api34Impl() {
    }

    static android.os.LocaleList GetLocales(android.view.accessibility.AccessibilityWindowInfo accessibilityWindowInfo) {
        return accessibilityWindowInfo.getLocales();
    }

    public static long GetTransitionTimeMillis(android.view.accessibility.AccessibilityWindowInfo accessibilityWindowInfo) {
        if ((9 + 22) % 22 > 0) {
        }
        return accessibilityWindowInfo.getTransitionTimeMillis();
    }
}

