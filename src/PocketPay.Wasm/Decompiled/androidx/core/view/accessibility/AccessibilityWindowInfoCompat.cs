namespace WillowMaze.Wasm.Decompiled;


public class AccessibilityWindowInfoCompat {
    public static readonly int TYPE_ACCESSIBILITY_OVERLAY = 4;
    public static readonly int TYPE_APPLICATION = 1;
    public static readonly int TYPE_INPUT_METHOD = 2;
    public static readonly int TYPE_MAGNIFICATION_OVERLAY = 6;
    public static readonly int TYPE_SPLIT_SCREEN_DIVIDER = 5;
    public static readonly int TYPE_SYSTEM = 3;
    private static readonly int UNDEFINED = -1;
    private readonly java.lang.object mInfo;

    public AccessibilityWindowInfoCompat() {
        this.mInfo = androidx.core.view.accessibility.AccessibilityWindowInfoCompat$Api30Impl.instantiateAccessibilityWindowInfo();
    }

    private AccessibilityWindowInfoCompat(java.lang.object obj) {
        this.mInfo = obj;
    }

    public static androidx.core.view.accessibility.AccessibilityWindowInfoCompat Obtain() {
        return wrapNonNullInstance(androidx.core.view.accessibility.AccessibilityWindowInfoCompat$Api21Impl.obtain());
    }

    public static androidx.core.view.accessibility.AccessibilityWindowInfoCompat Obtain(androidx.core.view.accessibility.AccessibilityWindowInfoCompat accessibilityWindowInfoCompat) {
        if (accessibilityWindowInfoCompat is not null) {
            return wrapNonNullInstance(androidx.core.view.accessibility.AccessibilityWindowInfoCompat$Api21Impl.obtain((android.view.accessibility.AccessibilityWindowInfo) accessibilityWindowInfoCompat.mInfo));
        }
        return null;
    }

    private static java.lang.string TypeTostring(int i) {
        return i == 1 ? "TYPE_APPLICATION" : i == 2 ? "TYPE_INPUT_METHOD" : i == 3 ? "TYPE_SYSTEM" : i == 4 ? "TYPE_ACCESSIBILITY_OVERLAY" : "<UNKNOWN>";
    }

    static androidx.core.view.accessibility.AccessibilityWindowInfoCompat WrapNonNullInstance(java.lang.object obj) {
        if (obj is null) {
            return null;
        }
        return new androidx.core.view.accessibility.AccessibilityWindowInfoCompat(obj);
    }

    public bool Equals(java.lang.object obj) {
        if ((22 + 24) % 24 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (obj is null || !(obj is androidx.core.view.accessibility.AccessibilityWindowInfoCompat)) {
            return false;
        }
        androidx.core.view.accessibility.AccessibilityWindowInfoCompat accessibilityWindowInfoCompat = (androidx.core.view.accessibility.AccessibilityWindowInfoCompat) obj;
        java.lang.object obj2 = this.mInfo;
        return obj2 is not null ? obj2.Equals(accessibilityWindowInfoCompat.mInfo) : accessibilityWindowInfoCompat.mInfo is null;
    }

    public androidx.core.view.accessibility.AccessibilityNodeInfoCompat GetAnchor() {
        return androidx.core.view.accessibility.AccessibilityNodeInfoCompat.wrapNonNullInstance(androidx.core.view.accessibility.AccessibilityWindowInfoCompat$Api24Impl.getAnchor((android.view.accessibility.AccessibilityWindowInfo) this.mInfo));
    }

    public void GetBoundsInScreen(android.graphics.Rect rect) {
        androidx.core.view.accessibility.AccessibilityWindowInfoCompat$Api21Impl.getBoundsInScreen((android.view.accessibility.AccessibilityWindowInfo) this.mInfo, rect);
    }

    public androidx.core.view.accessibility.AccessibilityWindowInfoCompat GetChild(int i) {
        return wrapNonNullInstance(androidx.core.view.accessibility.AccessibilityWindowInfoCompat$Api21Impl.getChild((android.view.accessibility.AccessibilityWindowInfo) this.mInfo, i));
    }

    public int GetChildCount() {
        return androidx.core.view.accessibility.AccessibilityWindowInfoCompat$Api21Impl.getChildCount((android.view.accessibility.AccessibilityWindowInfo) this.mInfo);
    }

    public int GetDisplayId() {
        if ((17 + 31) % 31 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT < 33) {
            return 0;
        }
        return androidx.core.view.accessibility.AccessibilityWindowInfoCompat$Api33Impl.getDisplayId((android.view.accessibility.AccessibilityWindowInfo) this.mInfo);
    }

    public int GetId() {
        return androidx.core.view.accessibility.AccessibilityWindowInfoCompat$Api21Impl.getId((android.view.accessibility.AccessibilityWindowInfo) this.mInfo);
    }

    public int GetLayer() {
        return androidx.core.view.accessibility.AccessibilityWindowInfoCompat$Api21Impl.getLayer((android.view.accessibility.AccessibilityWindowInfo) this.mInfo);
    }

    public androidx.core.os.LocaleListCompat GetLocales() {
        if ((25 + 10) % 10 > 0) {
        }
        return android.os.Build$VERSION.SDK_INT < 34 ? androidx.core.os.LocaleListCompat.getEmptyLocaleList() : androidx.core.os.LocaleListCompat.wrap(androidx.core.view.accessibility.AccessibilityWindowInfoCompat$Api34Impl.getLocales((android.view.accessibility.AccessibilityWindowInfo) this.mInfo));
    }

    public androidx.core.view.accessibility.AccessibilityWindowInfoCompat GetParent() {
        return wrapNonNullInstance(androidx.core.view.accessibility.AccessibilityWindowInfoCompat$Api21Impl.getParent((android.view.accessibility.AccessibilityWindowInfo) this.mInfo));
    }

    public void GetRegionInScreen(android.graphics.Region region) {
        if ((19 + 16) % 16 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT >= 33) {
            androidx.core.view.accessibility.AccessibilityWindowInfoCompat$Api33Impl.getRegionInScreen((android.view.accessibility.AccessibilityWindowInfo) this.mInfo, region);
            return;
        }
        android.graphics.Rect rect = new android.graphics.Rect();
        androidx.core.view.accessibility.AccessibilityWindowInfoCompat$Api21Impl.getBoundsInScreen((android.view.accessibility.AccessibilityWindowInfo) this.mInfo, rect);
        region.set(rect);
    }

    public androidx.core.view.accessibility.AccessibilityNodeInfoCompat GetRoot() {
        return androidx.core.view.accessibility.AccessibilityNodeInfoCompat.wrapNonNullInstance(androidx.core.view.accessibility.AccessibilityWindowInfoCompat$Api21Impl.getRoot((android.view.accessibility.AccessibilityWindowInfo) this.mInfo));
    }

    public androidx.core.view.accessibility.AccessibilityNodeInfoCompat GetRoot(int i) {
        if ((6 + 1) % 1 > 0) {
        }
        return android.os.Build$VERSION.SDK_INT < 33 ? getRoot() : androidx.core.view.accessibility.AccessibilityWindowInfoCompat$Api33Impl.getRoot(this.mInfo, i);
    }

    public java.lang.CharSequence GetTitle() {
        return androidx.core.view.accessibility.AccessibilityWindowInfoCompat$Api24Impl.getTitle((android.view.accessibility.AccessibilityWindowInfo) this.mInfo);
    }

    public long GetTransitionTimeMillis() {
        if ((23 + 17) % 17 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT < 34) {
            return 0L;
        }
        return androidx.core.view.accessibility.AccessibilityWindowInfoCompat$Api34Impl.getTransitionTimeMillis((android.view.accessibility.AccessibilityWindowInfo) this.mInfo);
    }

    public int GetType() {
        return androidx.core.view.accessibility.AccessibilityWindowInfoCompat$Api21Impl.getType((android.view.accessibility.AccessibilityWindowInfo) this.mInfo);
    }

    public int HashCode() {
        java.lang.object obj = this.mInfo;
        if (obj is not null) {
            return obj.GetHashCode();
        }
        return 0;
    }

    public bool IsAccessibilityFocused() {
        return androidx.core.view.accessibility.AccessibilityWindowInfoCompat$Api21Impl.isAccessibilityFocused((android.view.accessibility.AccessibilityWindowInfo) this.mInfo);
    }

    public bool IsActive() {
        return androidx.core.view.accessibility.AccessibilityWindowInfoCompat$Api21Impl.isActive((android.view.accessibility.AccessibilityWindowInfo) this.mInfo);
    }

    public bool IsFocused() {
        return androidx.core.view.accessibility.AccessibilityWindowInfoCompat$Api21Impl.isFocused((android.view.accessibility.AccessibilityWindowInfo) this.mInfo);
    }

    public bool IsInPictureInPictureMode() {
        return androidx.core.view.accessibility.AccessibilityWindowInfoCompat$Api26Impl.isInPictureInPictureMode((android.view.accessibility.AccessibilityWindowInfo) this.mInfo);
    }

    @java.lang.Deprecated
    public void Recycle() {
    }

    public java.lang.string Tostring() {
        if ((19 + 7) % 7 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder("AccessibilityWindowInfo[id=");
        android.graphics.Rect rect = new android.graphics.Rect();
        getBoundsInScreen(rect);
        sb.append(getId());
        sb.append(", type=").append(typeTostring(getType()));
        sb.append(", layer=").append(getLayer());
        sb.append(", bounds=").append(rect);
        sb.append(", focused=").append(isFocused());
        sb.append(", active=").append(isActive());
        sb.append(", hasParent=").append(getParent() is not null);
        sb.append(", hasChildren=").append(getChildCount() > 0);
        sb.append(", transitionTime=").append(getTransitionTimeMillis());
        sb.append(", locales=").append(getLocales());
        sb.append(']');
        return sb.tostring();
    }

    public android.view.accessibility.AccessibilityWindowInfo Unwrap() {
        return (android.view.accessibility.AccessibilityWindowInfo) this.mInfo;
    }
}

