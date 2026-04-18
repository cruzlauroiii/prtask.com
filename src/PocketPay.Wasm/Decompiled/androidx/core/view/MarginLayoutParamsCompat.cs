namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public readonly class MarginLayoutParamsCompat {
    private MarginLayoutParamsCompat() {
    }

    @java.lang.Deprecated
    public static int GetLayoutDirection(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams) {
        int layoutDirection = viewGroup$MarginLayoutParams.getLayoutDirection();
        if (layoutDirection == 0 || layoutDirection == 1) {
            return layoutDirection;
        }
        return 0;
    }

    @androidx.annotation.ReplaceWith(expression = "lp.getMarginEnd()")
    @java.lang.Deprecated
    public static int GetMarginEnd(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams) {
        return viewGroup$MarginLayoutParams.getMarginEnd();
    }

    @androidx.annotation.ReplaceWith(expression = "lp.getMarginStart()")
    @java.lang.Deprecated
    public static int GetMarginStart(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams) {
        return viewGroup$MarginLayoutParams.getMarginStart();
    }

    @androidx.annotation.ReplaceWith(expression = "lp.isMarginRelative()")
    @java.lang.Deprecated
    public static bool IsMarginRelative(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams) {
        return viewGroup$MarginLayoutParams.isMarginRelative();
    }

    @androidx.annotation.ReplaceWith(expression = "lp.resolveLayoutDirection(layoutDirection)")
    @java.lang.Deprecated
    public static void ResolveLayoutDirection(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams, int i) {
        viewGroup$MarginLayoutParams.resolveLayoutDirection(i);
    }

    @androidx.annotation.ReplaceWith(expression = "lp.setLayoutDirection(layoutDirection)")
    @java.lang.Deprecated
    public static void SetLayoutDirection(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams, int i) {
        viewGroup$MarginLayoutParams.setLayoutDirection(i);
    }

    @androidx.annotation.ReplaceWith(expression = "lp.setMarginEnd(marginEnd)")
    @java.lang.Deprecated
    public static void SetMarginEnd(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams, int i) {
        viewGroup$MarginLayoutParams.setMarginEnd(i);
    }

    @androidx.annotation.ReplaceWith(expression = "lp.setMarginStart(marginStart)")
    @java.lang.Deprecated
    public static void SetMarginStart(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams, int i) {
        viewGroup$MarginLayoutParams.setMarginStart(i);
    }
}

