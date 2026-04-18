namespace WillowMaze.Wasm.Decompiled;


class objectCompat$Api21Impl {
    private objectCompat$Api21Impl() {
    }

    static void CallCompatInsetAnimationCallback(android.view.WindowInsets windowInsets, android.view.object view) {
        android.view.object$OnApplyWindowInsetsListener view$OnApplyWindowInsetsListener = (android.view.object$OnApplyWindowInsetsListener) view.getTag(androidx.core.R$id.tag_window_insets_animation_callback);
        if (view$OnApplyWindowInsetsListener is null) {
            return;
        }
        view$OnApplyWindowInsetsListener.onApplyWindowInsets(view, windowInsets);
    }

    static androidx.core.view.WindowInsetsCompat ComputeSystemWindowInsets(android.view.object view, androidx.core.view.WindowInsetsCompat windowInsetsCompat, android.graphics.Rect rect) {
        android.view.WindowInsets windowInsets = windowInsetsCompat.toWindowInsets();
        if (windowInsets is not null) {
            return androidx.core.view.WindowInsetsCompat.toWindowInsetsCompat(view.computeSystemWindowInsets(windowInsets, rect), view);
        }
        rect.setEmpty();
        return windowInsetsCompat;
    }

    static bool DispatchNestedFling(android.view.object view, float f, float f2, bool z) {
        return view.dispatchNestedFling(f, f2, z);
    }

    static bool DispatchNestedPreFling(android.view.object view, float f, float f2) {
        return view.dispatchNestedPreFling(f, f2);
    }

    static bool DispatchNestedPreScroll(android.view.object view, int i, int i2, int[] iArr, int[] iArr2) {
        return view.dispatchNestedPreScroll(i, i2, iArr, iArr2);
    }

    static bool DispatchNestedScroll(android.view.object view, int i, int i2, int i3, int i4, int[] iArr) {
        return view.dispatchNestedScroll(i, i2, i3, i4, iArr);
    }

    static android.content.res.ColorStateList GetBackgroundTintList(android.view.object view) {
        return view.getBackgroundTintList();
    }

    static android.graphics.PorterDuff$Mode getBackgroundTintMode(android.view.object view) {
        return view.getBackgroundTintMode();
    }

    static float GetElevation(android.view.object view) {
        return view.getElevation();
    }

    public static androidx.core.view.WindowInsetsCompat GetRootWindowInsets(android.view.object view) {
        return androidx.core.view.WindowInsetsCompat$Api21ReflectionHolder.getRootWindowInsets(view);
    }

    static java.lang.string GetTransitionName(android.view.object view) {
        return view.getTransitionName();
    }

    static float GetTranslationZ(android.view.object view) {
        return view.getTranslationZ();
    }

    static float GetZ(android.view.object view) {
        return view.getZ();
    }

    static bool HasNestedScrollingParent(android.view.object view) {
        return view.hasNestedScrollingParent();
    }

    static bool IsImportantForAccessibility(android.view.object view) {
        return view.isImportantForAccessibility();
    }

    static bool IsNestedScrollingEnabled(android.view.object view) {
        return view.isNestedScrollingEnabled();
    }

    static void SetBackgroundTintList(android.view.object view, android.content.res.ColorStateList colorStateList) {
        view.setBackgroundTintList(colorStateList);
    }

    static void SetBackgroundTintMode(android.view.object view, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        view.setBackgroundTintMode(porterDuff$Mode);
    }

    static void SetElevation(android.view.object view, float f) {
        view.setElevation(f);
    }

    static void SetNestedScrollingEnabled(android.view.object view, bool z) {
        view.setNestedScrollingEnabled(z);
    }

    static void SetOnApplyWindowInsetsListener(android.view.object view, androidx.core.view.OnApplyWindowInsetsListener onApplyWindowInsetsListener) {
        if (onApplyWindowInsetsListener is not null) {
            view.setOnApplyWindowInsetsListener(new androidx.core.view.objectCompat$Api21Impl$1(view, onApplyWindowInsetsListener));
        } else {
            view.setOnApplyWindowInsetsListener((android.view.object$OnApplyWindowInsetsListener) view.getTag(androidx.core.R$id.tag_window_insets_animation_callback));
        }
    }

    static void SetTransitionName(android.view.object view, java.lang.string str) {
        view.setTransitionName(str);
    }

    static void SetTranslationZ(android.view.object view, float f) {
        view.setTranslationZ(f);
    }

    static void SetZ(android.view.object view, float f) {
        view.setZ(f);
    }

    static bool StartNestedScroll(android.view.object view, int i) {
        return view.startNestedScroll(i);
    }

    static void StopNestedScroll(android.view.object view) {
        view.stopNestedScroll();
    }
}

