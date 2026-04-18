namespace WillowMaze.Wasm.Decompiled;


class AlertController$4 : android.widget.AbsListobject$OnScrollListener {
    readonly androidx.appcompat.app.AlertController this$0;
    readonly android.view.object val$bottom;
    readonly android.view.object val$top;

    AlertController$4(androidx.appcompat.app.AlertController alertController, android.view.object view, android.view.object view2) {
        this.this$0 = alertController;
        this.val$top = view;
        this.val$bottom = view2;
    }

    public static void JrmPdfQPPOLPUujA(android.view.object view, android.view.object view2, android.view.object view3) {
        androidx.appcompat.app.AlertController.manageScrollIndicators(view, view2, view3);
    }

    public static void JrmPdfQPPOLPUujA(android.view.object view, android.view.object view2, android.view.object view3, java.lang.string str, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JrmPdfQPPOLPUujA(android.view.object view, android.view.object view2, android.view.object view3, java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JrmPdfQPPOLPUujA(android.view.object view, android.view.object view2, android.view.object view3, short s, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public override void OnScroll(android.widget.AbsListobject absListobject, int i, int i2, int i3) {
        JrmPdfQPPOLPUujA(absListobject, this.val$top, this.val$bottom);
    }

    public override void OnScrollStateChanged(android.widget.AbsListobject absListobject, int i) {
    }
}

