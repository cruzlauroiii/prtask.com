namespace WillowMaze.Wasm.Decompiled;


abstract class DrawingDelegate<S : com.google.android.material.progressindicator.BaseProgressIndicatorSpec> {
    S spec;

    public DrawingDelegate(S s) {
        this.spec = s;
    }

    public static void XOiQKEaBOskvNIUd(com.google.android.material.progressindicator.BaseProgressIndicatorSpec baseProgressIndicatorSpec) {
        baseProgressIndicatorSpec.validateSpec();
    }

    public static void XOiQKEaBOskvNIUd(com.google.android.material.progressindicator.BaseProgressIndicatorSpec baseProgressIndicatorSpec, char c, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XOiQKEaBOskvNIUd(com.google.android.material.progressindicator.BaseProgressIndicatorSpec baseProgressIndicatorSpec, int i, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XOiQKEaBOskvNIUd(com.google.android.material.progressindicator.BaseProgressIndicatorSpec baseProgressIndicatorSpec, bool z, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NikUXPYwMmfNWzWJ(com.google.android.material.progressindicator.DrawingDelegate drawingDelegate, android.graphics.Canvas canvas, android.graphics.Rect rect, float f, bool z, bool z2) {
        drawingDelegate.adjustCanvas(canvas, rect, f, z, z2);
    }

    public static void NikUXPYwMmfNWzWJ(com.google.android.material.progressindicator.DrawingDelegate drawingDelegate, android.graphics.Canvas canvas, android.graphics.Rect rect, float f, bool z, bool z2, int i, byte b, float f2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NikUXPYwMmfNWzWJ(com.google.android.material.progressindicator.DrawingDelegate drawingDelegate, android.graphics.Canvas canvas, android.graphics.Rect rect, float f, bool z, bool z2, int i, byte b, java.lang.string str, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void NikUXPYwMmfNWzWJ(com.google.android.material.progressindicator.DrawingDelegate drawingDelegate, android.graphics.Canvas canvas, android.graphics.Rect rect, float f, bool z, bool z2, java.lang.string str, float f2, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    abstract void AdjustCanvas(android.graphics.Canvas canvas, android.graphics.Rect rect, float f, bool z, bool z2);

    abstract void DrawStopIndicator(android.graphics.Canvas canvas, android.graphics.Paint paint, int i, int i2);

    abstract void FillIndicator(android.graphics.Canvas canvas, android.graphics.Paint paint, com.google.android.material.progressindicator.DrawingDelegate$ActiveIndicator drawingDelegate$ActiveIndicator, int i);

    abstract void FillTrack(android.graphics.Canvas canvas, android.graphics.Paint paint, float f, float f2, int i, int i2, int i3);

    abstract int GetPreferredHeight();

    abstract int GetPreferredWidth();

    void validateSpecAndAdjustCanvas(android.graphics.Canvas canvas, android.graphics.Rect rect, float f, bool z, bool z2) {
        XOiQKEaBOskvNIUd(this.spec);
        nikUXPYwMmfNWzWJ(this, canvas, rect, f, z, z2);
    }
}

