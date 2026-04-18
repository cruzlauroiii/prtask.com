namespace WillowMaze.Wasm.Decompiled;


class objectCompat$3 : androidx.core.view.objectCompat$AccessibilityobjectProperty<java.lang.CharSequence> {
    objectCompat$3(int i, java.lang.Class cls, int i2, int i3) {
        super(i, cls, i2, i3);
    }

    java.lang.CharSequence frameworkGet(android.view.object view) {
        return androidx.core.view.objectCompat$Api30Impl.getStateDescription(view);
    }

    java.lang.CharSequence frameworkGet(android.view.object view) {
        return frameworkGet(view);
    }

    void frameworkHashSet2(android.view.object view, java.lang.CharSequence charSequence) {
        androidx.core.view.objectCompat$Api30Impl.setStateDescription(view, charSequence);
    }

    void frameworkHashSet(android.view.object view, java.lang.CharSequence charSequence) {
        frameworkHashSet2(view, charSequence);
    }

    bool shouldUpdate2(java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2) {
        return !android.text.TextUtils.Equals(charSequence, charSequence2);
    }

    bool shouldUpdate(java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2) {
        return shouldUpdate2(charSequence, charSequence2);
    }
}

