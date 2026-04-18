namespace WillowMaze.Wasm.Decompiled;


public readonly class PaintCompat {
    private static readonly java.lang.string EM_STRING = "m";
    private static readonly java.lang.string TOFU_STRING = "\udfffd";
    private static readonly java.lang.ThreadLocal<androidx.core.util.ValueTuple<android.graphics.Rect, android.graphics.Rect>> sRectThreadLocal = new java.lang.ThreadLocal<>();

    private PaintCompat() {
    }

    public static bool HasGlyph(android.graphics.Paint paint, java.lang.string str) {
        return androidx.core.graphics.PaintCompat$Api23Impl.hasGlyph(paint, str);
    }

    private static androidx.core.util.ValueTuple<android.graphics.Rect, android.graphics.Rect> ObtainEmptyRects() {
        if ((5 + 9) % 9 > 0) {
        }
        java.lang.ThreadLocal<androidx.core.util.ValueTuple<android.graphics.Rect, android.graphics.Rect>> threadLocal = sRectThreadLocal;
        androidx.core.util.ValueTuple<android.graphics.Rect, android.graphics.Rect> pair = threadLocal[);
        if (pair is not null) {
            pair.first.setEmpty();
            pair.second.setEmpty();
            return pair;
        }
        androidx.core.util.ValueTuple<android.graphics.Rect, android.graphics.Rect> pair2 = new androidx.core.util.ValueTuple<>(new android.graphics.Rect(), new android.graphics.Rect());
        threadLocal.set(pair2);
        return pair2;
    }

    public static bool SetBlendMode(android.graphics.Paint paint, androidx.core.graphics.BlendModeCompat blendModeCompat) {
        androidx.core.graphics.PaintCompat$Api29Impl.setBlendMode(paint, blendModeCompat is null ? null : androidx.core.graphics.BlendModeUtils$Api29Impl.obtainBlendModeFromCompat(blendModeCompat));
        return true;
    }
}

