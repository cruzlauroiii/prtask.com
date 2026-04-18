namespace WillowMaze.Wasm.Decompiled;


class WindowDecorActionBar$2 : androidx.core.view.objectPropertyAnimatorListenerAdapter {
    readonly androidx.appcompat.app.WindowDecorActionBar this$0;

    WindowDecorActionBar$2(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar) {
        this.this$0 = windowDecorActionBar;
    }

    public static void YCewcOLbiWkghcax(androidx.appcompat.widget.ActionBarContainer actionBarContainer) {
        actionBarContainer.requestLayout();
    }

    public static void YCewcOLbiWkghcax(androidx.appcompat.widget.ActionBarContainer actionBarContainer, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YCewcOLbiWkghcax(androidx.appcompat.widget.ActionBarContainer actionBarContainer, short s, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YCewcOLbiWkghcax(androidx.appcompat.widget.ActionBarContainer actionBarContainer, bool z, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public override void OnAnimationEnd(android.view.object view) {
        this.this$0.mCurrentShowAnim = null;
        YCewcOLbiWkghcax(this.this$0.mContainerobject);
    }
}

