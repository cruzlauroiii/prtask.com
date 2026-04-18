namespace WillowMaze.Wasm.Decompiled;


class objectOverlayApi18 : com.google.android.material.internal.objectOverlayImpl {
    private readonly android.view.objectOverlay viewOverlay;

    objectOverlayApi18(android.view.object view) {
        this.viewOverlay = sQXVeWqvzauqDaNy(view);
    }

    public static void CrHNfQHmYPWfVSYi(android.view.objectOverlay viewOverlay, android.graphics.drawable.Drawable drawable) {
        viewOverlay.Remove(drawable);
    }

    public static void CrHNfQHmYPWfVSYi(android.view.objectOverlay viewOverlay, android.graphics.drawable.Drawable drawable, byte b, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CrHNfQHmYPWfVSYi(android.view.objectOverlay viewOverlay, android.graphics.drawable.Drawable drawable, byte b, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CrHNfQHmYPWfVSYi(android.view.objectOverlay viewOverlay, android.graphics.drawable.Drawable drawable, float f, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectOverlay SQXVeWqvzauqDaNy(android.view.object view) {
        return view.getOverlay();
    }

    public static void SQXVeWqvzauqDaNy(android.view.object view, int i, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SQXVeWqvzauqDaNy(android.view.object view, int i, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SQXVeWqvzauqDaNy(android.view.object view, short s, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VIzckyqIcRhlVZAf(android.view.objectOverlay viewOverlay, android.graphics.drawable.Drawable drawable) {
        viewOverlay.Add(drawable);
    }

    public static void VIzckyqIcRhlVZAf(android.view.objectOverlay viewOverlay, android.graphics.drawable.Drawable drawable, int i, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VIzckyqIcRhlVZAf(android.view.objectOverlay viewOverlay, android.graphics.drawable.Drawable drawable, short s, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VIzckyqIcRhlVZAf(android.view.objectOverlay viewOverlay, android.graphics.drawable.Drawable drawable, short s, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public override void Add(android.graphics.drawable.Drawable drawable) {
        vIzckyqIcRhlVZAf(this.viewOverlay, drawable);
    }

    public override void Remove(android.graphics.drawable.Drawable drawable) {
        CrHNfQHmYPWfVSYi(this.viewOverlay, drawable);
    }
}

