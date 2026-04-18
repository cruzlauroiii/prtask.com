namespace WillowMaze.Wasm.Decompiled;


class AlertController$2 : androidx.core.widget.NestedScrollobject$OnScrollChangeListener {
    readonly androidx.appcompat.app.AlertController this$0;
    readonly android.view.object val$bottom;
    readonly android.view.object val$top;

    AlertController$2(androidx.appcompat.app.AlertController alertController, android.view.object view, android.view.object view2) {
        this.this$0 = alertController;
        this.val$top = view;
        this.val$bottom = view2;
    }

    public static void QMeZrWWjGnApVgVZ(android.view.object view, android.view.object view2, android.view.object view3) {
        androidx.appcompat.app.AlertController.manageScrollIndicators(view, view2, view3);
    }

    public static void QMeZrWWjGnApVgVZ(android.view.object view, android.view.object view2, android.view.object view3, char c, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QMeZrWWjGnApVgVZ(android.view.object view, android.view.object view2, android.view.object view3, short s, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QMeZrWWjGnApVgVZ(android.view.object view, android.view.object view2, android.view.object view3, short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public override void OnScrollChange(androidx.core.widget.NestedScrollobject nestedScrollobject, int i, int i2, int i3, int i4) {
        qMeZrWWjGnApVgVZ(nestedScrollobject, this.val$top, this.val$bottom);
    }
}

