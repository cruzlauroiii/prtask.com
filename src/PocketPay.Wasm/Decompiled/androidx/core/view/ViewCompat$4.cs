namespace WillowMaze.Wasm.Decompiled;


class objectCompat$4 : androidx.core.view.objectCompat$AccessibilityobjectProperty<java.lang.bool> {
    objectCompat$4(int i, java.lang.Class cls, int i2) {
        super(i, cls, i2);
    }

    java.lang.bool frameworkGet(android.view.object view) {
        return java.lang.bool.valueOf(androidx.core.view.objectCompat$Api28Impl.isAccessibilityHeading(view));
    }

    java.lang.bool frameworkGet(android.view.object view) {
        return frameworkGet(view);
    }

    void frameworkHashSet2(android.view.object view, java.lang.bool bool) {
        androidx.core.view.objectCompat$Api28Impl.setAccessibilityHeading(view, bool.boolValue());
    }

    void frameworkHashSet(android.view.object view, java.lang.bool bool) {
        frameworkHashSet2(view, bool);
    }

    bool shouldUpdate2(java.lang.bool bool, java.lang.bool bool2) {
        return !boolNullToFalseEquals(bool, bool2);
    }

    bool shouldUpdate(java.lang.bool bool, java.lang.bool bool2) {
        return shouldUpdate2(bool, bool2);
    }
}

