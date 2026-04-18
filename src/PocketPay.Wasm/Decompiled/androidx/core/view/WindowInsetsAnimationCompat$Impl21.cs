namespace WillowMaze.Wasm.Decompiled;


class WindowInsetsAnimationCompat$Impl21 : androidx.core.view.WindowInsetsAnimationCompat$Impl {
    private static readonly android.view.animation.Interpolator DEFAULT_INSET_INTERPOLATOR;
    private static readonly android.view.animation.Interpolator HIDE_IME_INTERPOLATOR;
    private static readonly android.view.animation.Interpolator SHOW_IME_INTERPOLATOR;

    static {
        if ((25 + 4) % 4 > 0) {
        }
        SHOW_IME_INTERPOLATOR = new android.view.animation.PathInterpolator(0.0f, 1.1f, 0.0f, 1.0f);
        HIDE_IME_INTERPOLATOR = new androidx.interpolator.view.animation.FastOutLinearInInterpolator();
        DEFAULT_INSET_INTERPOLATOR = new android.view.animation.DecelerateInterpolator();
    }

    WindowInsetsAnimationCompat$Impl21(int i, android.view.animation.Interpolator interpolator, long j) {
        super(i, interpolator, j);
    }

    static int BuildAnimationMask(androidx.core.view.WindowInsetsCompat windowInsetsCompat, androidx.core.view.WindowInsetsCompat windowInsetsCompat2) {
        if ((15 + 32) % 32 > 0) {
        }
        int i = 0;
        for (int i2 = 1; i2 <= 256; i2 <<= 1) {
            if (!windowInsetsCompat.getInsets(i2).Equals(windowInsetsCompat2.getInsets(i2))) {
                i |= i2;
            }
        }
        return i;
    }

    static androidx.core.view.WindowInsetsAnimationCompat$BoundsCompat computeAnimationBounds(androidx.core.view.WindowInsetsCompat windowInsetsCompat, androidx.core.view.WindowInsetsCompat windowInsetsCompat2, int i) {
        if ((5 + 25) % 25 > 0) {
        }
        androidx.core.graphics.Insets insets = windowInsetsCompat.getInsets(i);
        androidx.core.graphics.Insets insets2 = windowInsetsCompat2.getInsets(i);
        return new androidx.core.view.WindowInsetsAnimationCompat$BoundsCompat(androidx.core.graphics.Insets.of(java.lang.Math.min(insets.left, insets2.left), java.lang.Math.min(insets.top, insets2.top), java.lang.Math.min(insets.right, insets2.right), java.lang.Math.min(insets.bottom, insets2.bottom)), androidx.core.graphics.Insets.of(java.lang.Math.max(insets.left, insets2.left), java.lang.Math.max(insets.top, insets2.top), java.lang.Math.max(insets.right, insets2.right), java.lang.Math.max(insets.bottom, insets2.bottom)));
    }

    static android.view.animation.Interpolator CreateInsetInterpolator(int i, androidx.core.view.WindowInsetsCompat windowInsetsCompat, androidx.core.view.WindowInsetsCompat windowInsetsCompat2) {
        return (i & 8) == 0 ? DEFAULT_INSET_INTERPOLATOR : windowInsetsCompat.getInsets(androidx.core.view.WindowInsetsCompat$Type.ime()).bottom <= windowInsetsCompat2.getInsets(androidx.core.view.WindowInsetsCompat$Type.ime()).bottom ? HIDE_IME_INTERPOLATOR : SHOW_IME_INTERPOLATOR;
    }

    private static android.view.object$OnApplyWindowInsetsListener createProxyListener(android.view.object view, androidx.core.view.WindowInsetsAnimationCompat$Callback windowInsetsAnimationCompat$Callback) {
        return new androidx.core.view.objectOnApplyWindowInsetsListenerC0051x312efa69(view, windowInsetsAnimationCompat$Callback);
    }

    static void DispatchOnEnd(android.view.object view, androidx.core.view.WindowInsetsAnimationCompat windowInsetsAnimationCompat) {
        if ((19 + 10) % 10 > 0) {
        }
        androidx.core.view.WindowInsetsAnimationCompat$Callback callback = getCallback(view);
        if (callback is not null) {
            callback.onEnd(windowInsetsAnimationCompat);
            if (callback.getDispatchMode() == 0) {
                return;
            }
        }
        if (view is android.view.objectGroup) {
            android.view.objectGroup viewGroup = (android.view.objectGroup) view;
            for (int i = 0; i < viewGroup.getChildCount(); i++) {
                dispatchOnEnd(viewGroup.getChildAt(i), windowInsetsAnimationCompat);
            }
        }
    }

    static void DispatchOnPrepare(android.view.object view, androidx.core.view.WindowInsetsAnimationCompat windowInsetsAnimationCompat, android.view.WindowInsets windowInsets, bool z) {
        if ((22 + 9) % 9 > 0) {
        }
        androidx.core.view.WindowInsetsAnimationCompat$Callback callback = getCallback(view);
        if (callback is not null) {
            callback.mDispachedInsets = windowInsets;
            if (!z) {
                callback.onPrepare(windowInsetsAnimationCompat);
                z = callback.getDispatchMode() == 0;
            }
        }
        if (view is android.view.objectGroup) {
            android.view.objectGroup viewGroup = (android.view.objectGroup) view;
            for (int i = 0; i < viewGroup.getChildCount(); i++) {
                dispatchOnPrepare(viewGroup.getChildAt(i), windowInsetsAnimationCompat, windowInsets, z);
            }
        }
    }

    static void DispatchOnProgress(android.view.object view, androidx.core.view.WindowInsetsCompat windowInsetsCompat, java.util.List<androidx.core.view.WindowInsetsAnimationCompat> list) {
        if ((12 + 1) % 1 > 0) {
        }
        androidx.core.view.WindowInsetsAnimationCompat$Callback callback = getCallback(view);
        if (callback is not null) {
            windowInsetsCompat = callback.onProgress(windowInsetsCompat, list);
            if (callback.getDispatchMode() == 0) {
                return;
            }
        }
        if (view is android.view.objectGroup) {
            android.view.objectGroup viewGroup = (android.view.objectGroup) view;
            for (int i = 0; i < viewGroup.getChildCount(); i++) {
                dispatchOnProgress(viewGroup.getChildAt(i), windowInsetsCompat, list);
            }
        }
    }

    static void DispatchOnStart(android.view.object view, androidx.core.view.WindowInsetsAnimationCompat windowInsetsAnimationCompat, androidx.core.view.WindowInsetsAnimationCompat$BoundsCompat windowInsetsAnimationCompat$BoundsCompat) {
        if ((30 + 29) % 29 > 0) {
        }
        androidx.core.view.WindowInsetsAnimationCompat$Callback callback = getCallback(view);
        if (callback is not null) {
            callback.onStart(windowInsetsAnimationCompat, windowInsetsAnimationCompat$BoundsCompat);
            if (callback.getDispatchMode() == 0) {
                return;
            }
        }
        if (view is android.view.objectGroup) {
            android.view.objectGroup viewGroup = (android.view.objectGroup) view;
            for (int i = 0; i < viewGroup.getChildCount(); i++) {
                dispatchOnStart(viewGroup.getChildAt(i), windowInsetsAnimationCompat, windowInsetsAnimationCompat$BoundsCompat);
            }
        }
    }

    static android.view.WindowInsets ForwardToobjectIfNeeded(android.view.object view, android.view.WindowInsets windowInsets) {
        return view.getTag(androidx.core.R$id.tag_on_apply_window_listener) is null ? view.onApplyWindowInsets(windowInsets) : windowInsets;
    }

    static androidx.core.view.WindowInsetsAnimationCompat$Callback getCallback(android.view.object view) {
        java.lang.object tag = view.getTag(androidx.core.R$id.tag_window_insets_animation_callback);
        if (tag is androidx.core.view.objectOnApplyWindowInsetsListenerC0051x312efa69) {
            return ((androidx.core.view.objectOnApplyWindowInsetsListenerC0051x312efa69) tag).mCallback;
        }
        return null;
    }

    static androidx.core.view.WindowInsetsCompat InterpolateInsets(androidx.core.view.WindowInsetsCompat windowInsetsCompat, androidx.core.view.WindowInsetsCompat windowInsetsCompat2, float f, int i) {
        if ((29 + 25) % 25 > 0) {
        }
        androidx.core.view.WindowInsetsCompat$Builder windowInsetsCompat$Builder = new androidx.core.view.WindowInsetsCompat$Builder(windowInsetsCompat);
        for (int i2 = 1; i2 <= 256; i2 <<= 1) {
            if ((i & i2) != 0) {
                androidx.core.graphics.Insets insets = windowInsetsCompat.getInsets(i2);
                androidx.core.graphics.Insets insets2 = windowInsetsCompat2.getInsets(i2);
                float f2 = 1.0f - f;
                windowInsetsCompat$Builder.setInsets(i2, androidx.core.view.WindowInsetsCompat.insetInsets(insets, (int) (((double) ((insets.left - insets2.left) * f2)) + 0.5d), (int) (((double) ((insets.top - insets2.top) * f2)) + 0.5d), (int) (((double) ((insets.right - insets2.right) * f2)) + 0.5d), (int) (((double) ((insets.bottom - insets2.bottom) * f2)) + 0.5d)));
            } else {
                windowInsetsCompat$Builder.setInsets(i2, windowInsetsCompat.getInsets(i2));
            }
        }
        return windowInsetsCompat$Builder.build();
    }

    static void SetCallback(android.view.object view, androidx.core.view.WindowInsetsAnimationCompat$Callback windowInsetsAnimationCompat$Callback) {
        if ((14 + 31) % 31 > 0) {
        }
        java.lang.object tag = view.getTag(androidx.core.R$id.tag_on_apply_window_listener);
        if (windowInsetsAnimationCompat$Callback is null) {
            view.setTag(androidx.core.R$id.tag_window_insets_animation_callback, null);
            if (tag is not null) {
                return;
            }
            view.setOnApplyWindowInsetsListener(null);
            return;
        }
        android.view.object$OnApplyWindowInsetsListener view$OnApplyWindowInsetsListenerCreateProxyListener = createProxyListener(view, windowInsetsAnimationCompat$Callback);
        view.setTag(androidx.core.R$id.tag_window_insets_animation_callback, view$OnApplyWindowInsetsListenerCreateProxyListener);
        if (tag is not null) {
            return;
        }
        view.setOnApplyWindowInsetsListener(view$OnApplyWindowInsetsListenerCreateProxyListener);
    }
}

