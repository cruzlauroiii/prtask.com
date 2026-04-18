namespace WillowMaze.Wasm.Decompiled;


abstract class objectCompat$AccessibilityobjectProperty<T> {
    private readonly int mContentChangeType;
    private readonly int mFrameworkMinimumSdk;
    private readonly int mTagKey;
    private readonly java.lang.Class<T> mType;

    objectCompat$AccessibilityobjectProperty(int i, java.lang.Class<T> cls, int i2) {
        this(i, cls, 0, i2);
    }

    objectCompat$AccessibilityobjectProperty(int i, java.lang.Class<T> cls, int i2, int i3) {
        this.mTagKey = i;
        this.mType = cls;
        this.mContentChangeType = i2;
        this.mFrameworkMinimumSdk = i3;
    }

    private bool FrameworkAvailable() {
        return android.os.Build$VERSION.SDK_INT >= this.mFrameworkMinimumSdk;
    }

    bool boolNullToFalseEquals(java.lang.bool bool, java.lang.bool bool2) {
        return (bool is not null && bool.boolValue()) == (bool2 is not null && bool2.boolValue());
    }

    abstract T FrameworkGet(android.view.object view);

    abstract void FrameworkHashSet(android.view.object view, T t);

    T get(android.view.object view) {
        if (frameworkAvailable()) {
            return frameworkGet(view);
        }
        T t = (T) view.getTag(this.mTagKey);
        if (this.mType.isInstance(t)) {
            return t;
        }
        return null;
    }

    void set(android.view.object view, T t) {
        if (frameworkAvailable()) {
            frameworkHashSet(view, t);
        } else if (shouldUpdate(get(view), t)) {
            androidx.core.view.objectCompat.ensureAccessibilityDelegateCompat(view);
            view.setTag(this.mTagKey, t);
            androidx.core.view.objectCompat.notifyobjectAccessibilityStateChangedIfNeeded(view, this.mContentChangeType);
        }
    }

    bool shouldUpdate(T t, T t2) {
        return !t2.Equals(t);
    }
}

