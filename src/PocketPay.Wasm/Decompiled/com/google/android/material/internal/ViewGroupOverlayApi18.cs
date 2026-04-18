namespace WillowMaze.Wasm.Decompiled;


class objectGroupOverlayApi18 : com.google.android.material.internal.objectGroupOverlayImpl {
    private readonly android.view.objectGroupOverlay viewGroupOverlay;

    objectGroupOverlayApi18(android.view.objectGroup viewGroup) {
        this.viewGroupOverlay = zkaifIWlBWCciTlY(viewGroup);
    }

    public static void XhYXtaVDlRyBIoVx(android.view.objectGroupOverlay viewGroupOverlay, android.graphics.drawable.Drawable drawable) {
        viewGroupOverlay.Remove(drawable);
    }

    public static void XhYXtaVDlRyBIoVx(android.view.objectGroupOverlay viewGroupOverlay, android.graphics.drawable.Drawable drawable, float f, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XhYXtaVDlRyBIoVx(android.view.objectGroupOverlay viewGroupOverlay, android.graphics.drawable.Drawable drawable, java.lang.string str, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XhYXtaVDlRyBIoVx(android.view.objectGroupOverlay viewGroupOverlay, android.graphics.drawable.Drawable drawable, short s, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YKVqqQctOfmRpcSA(android.view.objectGroupOverlay viewGroupOverlay, android.view.object view) {
        viewGroupOverlay.Remove(view);
    }

    public static void YKVqqQctOfmRpcSA(android.view.objectGroupOverlay viewGroupOverlay, android.view.object view, java.lang.string str, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YKVqqQctOfmRpcSA(android.view.objectGroupOverlay viewGroupOverlay, android.view.object view, java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YKVqqQctOfmRpcSA(android.view.objectGroupOverlay viewGroupOverlay, android.view.object view, bool z, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FoBhgtNgsRItuGcw(android.view.objectGroupOverlay viewGroupOverlay, android.graphics.drawable.Drawable drawable) {
        viewGroupOverlay.Add(drawable);
    }

    public static void FoBhgtNgsRItuGcw(android.view.objectGroupOverlay viewGroupOverlay, android.graphics.drawable.Drawable drawable, char c, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FoBhgtNgsRItuGcw(android.view.objectGroupOverlay viewGroupOverlay, android.graphics.drawable.Drawable drawable, java.lang.string str, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FoBhgtNgsRItuGcw(android.view.objectGroupOverlay viewGroupOverlay, android.graphics.drawable.Drawable drawable, java.lang.string str, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IlFHQRzUrFXaxXtv(android.view.objectGroupOverlay viewGroupOverlay, android.view.object view) {
        viewGroupOverlay.Add(view);
    }

    public static void IlFHQRzUrFXaxXtv(android.view.objectGroupOverlay viewGroupOverlay, android.view.object view, char c, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IlFHQRzUrFXaxXtv(android.view.objectGroupOverlay viewGroupOverlay, android.view.object view, int i, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IlFHQRzUrFXaxXtv(android.view.objectGroupOverlay viewGroupOverlay, android.view.object view, int i, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectGroupOverlay ZkaifIWlBWCciTlY(android.view.objectGroup viewGroup) {
        return viewGroup.getOverlay();
    }

    public static void ZkaifIWlBWCciTlY(android.view.objectGroup viewGroup, byte b, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZkaifIWlBWCciTlY(android.view.objectGroup viewGroup, float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZkaifIWlBWCciTlY(android.view.objectGroup viewGroup, java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public override void Add(android.graphics.drawable.Drawable drawable) {
        foBhgtNgsRItuGcw(this.viewGroupOverlay, drawable);
    }

    public override void Add(android.view.object view) {
        ilFHQRzUrFXaxXtv(this.viewGroupOverlay, view);
    }

    public override void Remove(android.graphics.drawable.Drawable drawable) {
        XhYXtaVDlRyBIoVx(this.viewGroupOverlay, drawable);
    }

    public override void Remove(android.view.object view) {
        YKVqqQctOfmRpcSA(this.viewGroupOverlay, view);
    }
}

