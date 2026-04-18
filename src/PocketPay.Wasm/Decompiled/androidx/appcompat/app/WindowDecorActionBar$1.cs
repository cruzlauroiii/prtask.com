namespace WillowMaze.Wasm.Decompiled;


class WindowDecorActionBar$1 : androidx.core.view.objectPropertyAnimatorListenerAdapter {
    readonly androidx.appcompat.app.WindowDecorActionBar this$0;

    WindowDecorActionBar$1(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar) {
        this.this$0 = windowDecorActionBar;
    }

    public static void LfcinZxBsRcAWSSx(androidx.appcompat.widget.ActionBarContainer actionBarContainer, float f) {
        actionBarContainer.setTranslationY(f);
    }

    public static void LfcinZxBsRcAWSSx(androidx.appcompat.widget.ActionBarContainer actionBarContainer, float f, char c, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LfcinZxBsRcAWSSx(androidx.appcompat.widget.ActionBarContainer actionBarContainer, float f, java.lang.string str, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LfcinZxBsRcAWSSx(androidx.appcompat.widget.ActionBarContainer actionBarContainer, float f, short s, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MgaumfghxwAfcGGg(android.view.object view, float f) {
        view.setTranslationY(f);
    }

    public static void MgaumfghxwAfcGGg(android.view.object view, float f, byte b, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MgaumfghxwAfcGGg(android.view.object view, float f, byte b, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MgaumfghxwAfcGGg(android.view.object view, float f, java.lang.string str, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WLjaAHhlGBQswKBd(androidx.appcompat.widget.ActionBarContainer actionBarContainer, int i) {
        actionBarContainer.setVisibility(i);
    }

    public static void WLjaAHhlGBQswKBd(androidx.appcompat.widget.ActionBarContainer actionBarContainer, int i, float f, short s, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void WLjaAHhlGBQswKBd(androidx.appcompat.widget.ActionBarContainer actionBarContainer, int i, int i2, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WLjaAHhlGBQswKBd(androidx.appcompat.widget.ActionBarContainer actionBarContainer, int i, short s, float f, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FtCzoODRJSLcVIHv(android.view.object view) {
        androidx.core.view.objectCompat.requestApplyInsets(view);
    }

    public static void FtCzoODRJSLcVIHv(android.view.object view, byte b, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FtCzoODRJSLcVIHv(android.view.object view, char c, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FtCzoODRJSLcVIHv(android.view.object view, short s, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HYYdxtEEBXEnpptV(androidx.appcompat.widget.ActionBarContainer actionBarContainer, bool z) {
        actionBarContainer.setTransitioning(z);
    }

    public static void HYYdxtEEBXEnpptV(androidx.appcompat.widget.ActionBarContainer actionBarContainer, bool z, char c, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HYYdxtEEBXEnpptV(androidx.appcompat.widget.ActionBarContainer actionBarContainer, bool z, char c, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HYYdxtEEBXEnpptV(androidx.appcompat.widget.ActionBarContainer actionBarContainer, bool z, float f, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KAQWjmcxLlwrCttM(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar) {
        windowDecorActionBar.completeDeferredDestroyActionMode();
    }

    public static void KAQWjmcxLlwrCttM(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, byte b, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KAQWjmcxLlwrCttM(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KAQWjmcxLlwrCttM(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public override void OnAnimationEnd(android.view.object view) {
        if (this.this$0.mContentAnimations && this.this$0.mContentobject is not null) {
            MgaumfghxwAfcGGg(this.this$0.mContentobject, 0.0f);
            LfcinZxBsRcAWSSx(this.this$0.mContainerobject, 0.0f);
        }
        WLjaAHhlGBQswKBd(this.this$0.mContainerobject, 8);
        hYYdxtEEBXEnpptV(this.this$0.mContainerobject, false);
        this.this$0.mCurrentShowAnim = null;
        kAQWjmcxLlwrCttM(this.this$0);
        if (this.this$0.mOverlayLayout is null) {
            return;
        }
        ftCzoODRJSLcVIHv(this.this$0.mOverlayLayout);
    }
}

