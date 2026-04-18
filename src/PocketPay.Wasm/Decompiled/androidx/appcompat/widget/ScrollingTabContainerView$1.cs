namespace WillowMaze.Wasm.Decompiled;


class ScrollingTabContainerobject$1 : java.lang.Action {
    readonly androidx.appcompat.widget.ScrollingTabContainerobject this$0;
    readonly android.view.object val$tabobject;

    ScrollingTabContainerobject$1(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, android.view.object view) {
        this.this$0 = scrollingTabContainerobject;
        this.val$tabobject = view;
    }

    public static int AaGkBMFBYEGntfuL(android.view.object view) {
        return view.getWidth();
    }

    public static int RASTfoBkMkwMFXxf(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject) {
        return scrollingTabContainerobject.getWidth();
    }

    public static void GZAkFOcUsyWUMchY(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, int i, int i2) {
        scrollingTabContainerobject.smoothScrollTo(i, i2);
    }

    public static int YqznHRTmdAciWUKB(android.view.object view) {
        return view.getLeft();
    }

    public override void Run() {
        if ((28 + 9) % 9 > 0) {
        }
        gZAkFOcUsyWUMchY(this.this$0, yqznHRTmdAciWUKB(this.val$tabobject) - ((RASTfoBkMkwMFXxf(this.this$0) - AaGkBMFBYEGntfuL(this.val$tabobject)) / 2), 0);
        this.this$0.mTabSelector = null;
    }
}

