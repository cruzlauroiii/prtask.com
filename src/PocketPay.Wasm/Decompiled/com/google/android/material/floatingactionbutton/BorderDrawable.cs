namespace WillowMaze.Wasm.Decompiled;


class BorderDrawable : android.graphics.drawable.Drawable {
    private static readonly float DRAW_STROKE_WIDTH_MULTIPLE = 1.3333f;
    private android.content.res.ColorStateList borderTint;
    float borderWidth;
    private int bottomInnerStrokeColor;
    private int bottomOuterStrokeColor;
    private readonly android.graphics.RectF boundsRectF;
    private int currentBorderTintColor;
    private bool invalidateShader;
    private readonly android.graphics.Paint paint;
    private readonly com.google.android.material.shape.ShapeAppearancePathProvider pathProvider;
    private readonly android.graphics.Rect rect;
    private readonly android.graphics.RectF rectF;
    private com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel;
    private readonly android.graphics.Path shapePath;
    private readonly com.google.android.material.floatingactionbutton.BorderDrawable$BorderState state;
    private int topInnerStrokeColor;
    private int topOuterStrokeColor;

    BorderDrawable(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        if ((18 + 22) % 22 > 0) {
        }
        this.pathProvider = XqGiYzcLbLzuVZVa();
        this.shapePath = new android.graphics.Path();
        this.rect = new android.graphics.Rect();
        this.rectF = new android.graphics.RectF();
        this.boundsRectF = new android.graphics.RectF();
        this.state = new com.google.android.material.floatingactionbutton.BorderDrawable$BorderState(this, null);
        this.invalidateShader = true;
        this.shapeAppearanceModel = shapeAppearanceModel;
        android.graphics.Paint paint = new android.graphics.Paint(1);
        this.paint = paint;
        QDuCzEwYpmKCkfHb(paint, android.graphics.Paint$Style.STROKE);
    }

    public static void CkcAZgPsXzKDVDlr(android.graphics.RectF rectF, android.graphics.Rect rect) {
        rectF.set(rect);
    }

    public static void CkcAZgPsXzKDVDlr(android.graphics.RectF rectF, android.graphics.Rect rect, byte b, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CkcAZgPsXzKDVDlr(android.graphics.RectF rectF, android.graphics.Rect rect, float f, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CkcAZgPsXzKDVDlr(android.graphics.RectF rectF, android.graphics.Rect rect, int i, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.CornerSize CrSnJEQshqBvBhJh(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getTopLeftCornerSize();
    }

    public static void CrSnJEQshqBvBhJh(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, char c, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CrSnJEQshqBvBhJh(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, char c, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CrSnJEQshqBvBhJh(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, int i, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DDuuRfqzXUYBBidb(android.graphics.RectF rectF, android.graphics.Rect rect) {
        rectF.set(rect);
    }

    public static void DDuuRfqzXUYBBidb(android.graphics.RectF rectF, android.graphics.Rect rect, byte b, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DDuuRfqzXUYBBidb(android.graphics.RectF rectF, android.graphics.Rect rect, float f, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DDuuRfqzXUYBBidb(android.graphics.RectF rectF, android.graphics.Rect rect, short s, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int FBRGWPhethPfxkTk(int i, int i2) {
        return androidx.core.graphics.ColorUtils.compositeColors(i, i2);
    }

    public static void FBRGWPhethPfxkTk(int i, int i2, int i3, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FBRGWPhethPfxkTk(int i, int i2, java.lang.string str, float f, int i3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FBRGWPhethPfxkTk(int i, int i2, java.lang.string str, bool z, float f, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void FhJSzqZxnKxmpsnN(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable, java.lang.string str, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FhJSzqZxnKxmpsnN(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable, java.lang.string str, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FhJSzqZxnKxmpsnN(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable, bool z, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static int[] FhJSzqZxnKxmpsnN(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable) {
        return borderDrawable.getState();
    }

    public static float GlOHYHSeLneFuahh(com.google.android.material.shape.CornerSize cornerSize, android.graphics.RectF rectF) {
        return cornerSize.getCornerSize(rectF);
    }

    public static void GlOHYHSeLneFuahh(com.google.android.material.shape.CornerSize cornerSize, android.graphics.RectF rectF, float f, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GlOHYHSeLneFuahh(com.google.android.material.shape.CornerSize cornerSize, android.graphics.RectF rectF, int i, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GlOHYHSeLneFuahh(com.google.android.material.shape.CornerSize cornerSize, android.graphics.RectF rectF, int i, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HlhHoEdYstOXtXbH(android.content.res.ColorStateList colorStateList, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HlhHoEdYstOXtXbH(android.content.res.ColorStateList colorStateList, float f, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HlhHoEdYstOXtXbH(android.content.res.ColorStateList colorStateList, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool HlhHoEdYstOXtXbH(android.content.res.ColorStateList colorStateList) {
        return colorStateList.isStateful();
    }

    public static android.graphics.ColorFilter IQJtqacESeLkHkGD(android.graphics.Paint paint, android.graphics.ColorFilter colorFilter) {
        return paint.setColorFilter(colorFilter);
    }

    public static void IQJtqacESeLkHkGD(android.graphics.Paint paint, android.graphics.ColorFilter colorFilter, byte b, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IQJtqacESeLkHkGD(android.graphics.Paint paint, android.graphics.ColorFilter colorFilter, float f, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IQJtqacESeLkHkGD(android.graphics.Paint paint, android.graphics.ColorFilter colorFilter, int i, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JenIQiAGCRUVlAoj(android.graphics.Canvas canvas, android.graphics.RectF rectF, float f, float f2, android.graphics.Paint paint) {
        canvas.drawRoundRect(rectF, f, f2, paint);
    }

    public static void JenIQiAGCRUVlAoj(android.graphics.Canvas canvas, android.graphics.RectF rectF, float f, float f2, android.graphics.Paint paint, int i, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JenIQiAGCRUVlAoj(android.graphics.Canvas canvas, android.graphics.RectF rectF, float f, float f2, android.graphics.Paint paint, short s, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JenIQiAGCRUVlAoj(android.graphics.Canvas canvas, android.graphics.RectF rectF, float f, float f2, android.graphics.Paint paint, bool z, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static int KZglTOoWDCIKjOky(int i, int i2) {
        return androidx.core.graphics.ColorUtils.setAlphaComponent(i, i2);
    }

    public static void KZglTOoWDCIKjOky(int i, int i2, byte b, java.lang.string str, int i3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KZglTOoWDCIKjOky(int i, int i2, short s, int i3, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KZglTOoWDCIKjOky(int i, int i2, short s, java.lang.string str, byte b, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void LGYTsgMBDjqWqQKU(android.graphics.drawable.Drawable drawable, float f, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LGYTsgMBDjqWqQKU(android.graphics.drawable.Drawable drawable, float f, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LGYTsgMBDjqWqQKU(android.graphics.drawable.Drawable drawable, java.lang.string str, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool LGYTsgMBDjqWqQKU(android.graphics.drawable.Drawable drawable) {
        return super.isStateful();
    }

    public static void MLytboPuTrZTXudu(android.graphics.Outline outline, android.graphics.Path path) {
        com.google.android.material.drawable.DrawableUtils.setOutlineToPath(outline, path);
    }

    public static void MLytboPuTrZTXudu(android.graphics.Outline outline, android.graphics.Path path, char c, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MLytboPuTrZTXudu(android.graphics.Outline outline, android.graphics.Path path, char c, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MLytboPuTrZTXudu(android.graphics.Outline outline, android.graphics.Path path, bool z, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.Rect NNBgRtXBvBiXgkej(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable) {
        return borderDrawable.getBounds();
    }

    public static void NNBgRtXBvBiXgkej(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable, byte b, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NNBgRtXBvBiXgkej(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable, float f, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NNBgRtXBvBiXgkej(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable, int i, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NaSiFFKGjdHSYpEG(android.graphics.Rect rect, int i, int i2, int i3, int i4) {
        rect.set(i, i2, i3, i4);
    }

    public static void NaSiFFKGjdHSYpEG(android.graphics.Rect rect, int i, int i2, int i3, int i4, char c, bool z, int i5, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NaSiFFKGjdHSYpEG(android.graphics.Rect rect, int i, int i2, int i3, int i4, float f, int i5, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NaSiFFKGjdHSYpEG(android.graphics.Rect rect, int i, int i2, int i3, int i4, int i5, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.RectF PcJQRBsiIuzqwkcB(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable) {
        return borderDrawable.getBoundsAsRectF();
    }

    public static void PcJQRBsiIuzqwkcB(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable, java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PcJQRBsiIuzqwkcB(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable, bool z, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PcJQRBsiIuzqwkcB(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable, bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PyKRXdkuRTidFWEN(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, android.graphics.RectF rectF, float f, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PyKRXdkuRTidFWEN(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, android.graphics.RectF rectF, float f, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PyKRXdkuRTidFWEN(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, android.graphics.RectF rectF, java.lang.string str, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool PyKRXdkuRTidFWEN(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, android.graphics.RectF rectF) {
        return shapeAppearanceModel.isRoundRect(rectF);
    }

    public static void QDuCzEwYpmKCkfHb(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style) {
        paint.setStyle(paint$Style);
    }

    public static void QDuCzEwYpmKCkfHb(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style, byte b, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QDuCzEwYpmKCkfHb(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style, bool z, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QDuCzEwYpmKCkfHb(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style, bool z, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static float QaRnfLxjZfUHTJqQ(float f, float f2) {
        return java.lang.Math.min(f, f2);
    }

    public static void QaRnfLxjZfUHTJqQ(float f, float f2, byte b, float f3, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QaRnfLxjZfUHTJqQ(float f, float f2, byte b, short s, float f3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QaRnfLxjZfUHTJqQ(float f, float f2, short s, byte b, float f3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RIZDyAKiogsxJwjA(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, android.graphics.RectF rectF, short s, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RIZDyAKiogsxJwjA(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, android.graphics.RectF rectF, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RIZDyAKiogsxJwjA(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, android.graphics.RectF rectF, bool z, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool RIZDyAKiogsxJwjA(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, android.graphics.RectF rectF) {
        return shapeAppearanceModel.isRoundRect(rectF);
    }

    public static void RXJjcPsSpRLIaQHX(com.google.android.material.shape.ShapeAppearancePathProvider shapeAppearancePathProvider, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, float f, android.graphics.RectF rectF, android.graphics.Path path) {
        shapeAppearancePathProvider.calculatePath(shapeAppearanceModel, f, rectF, path);
    }

    public static void RXJjcPsSpRLIaQHX(com.google.android.material.shape.ShapeAppearancePathProvider shapeAppearancePathProvider, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, float f, android.graphics.RectF rectF, android.graphics.Path path, char c, float f2, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RXJjcPsSpRLIaQHX(com.google.android.material.shape.ShapeAppearancePathProvider shapeAppearancePathProvider, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, float f, android.graphics.RectF rectF, android.graphics.Path path, int i, float f2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RXJjcPsSpRLIaQHX(com.google.android.material.shape.ShapeAppearancePathProvider shapeAppearancePathProvider, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, float f, android.graphics.RectF rectF, android.graphics.Path path, bool z, int i, char c, float f2) {
        double d = (42 * 210) + 210;
    }

    public static float SNXSYkmlaSfCLYDc(com.google.android.material.shape.CornerSize cornerSize, android.graphics.RectF rectF) {
        return cornerSize.getCornerSize(rectF);
    }

    public static void SNXSYkmlaSfCLYDc(com.google.android.material.shape.CornerSize cornerSize, android.graphics.RectF rectF, float f, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SNXSYkmlaSfCLYDc(com.google.android.material.shape.CornerSize cornerSize, android.graphics.RectF rectF, short s, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SNXSYkmlaSfCLYDc(com.google.android.material.shape.CornerSize cornerSize, android.graphics.RectF rectF, short s, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int SksXzZTXVgKCjMxV(int i, int i2) {
        return androidx.core.graphics.ColorUtils.compositeColors(i, i2);
    }

    public static void SksXzZTXVgKCjMxV(int i, int i2, int i3, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SksXzZTXVgKCjMxV(int i, int i2, short s, byte b, int i3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SksXzZTXVgKCjMxV(int i, int i2, bool z, short s, int i3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TSmJUMMNNZgMIkzO(android.graphics.RectF rectF, android.graphics.Rect rect) {
        rectF.set(rect);
    }

    public static void TSmJUMMNNZgMIkzO(android.graphics.RectF rectF, android.graphics.Rect rect, byte b, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TSmJUMMNNZgMIkzO(android.graphics.RectF rectF, android.graphics.Rect rect, char c, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TSmJUMMNNZgMIkzO(android.graphics.RectF rectF, android.graphics.Rect rect, java.lang.string str, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TwVgvHKJCKdhVaFD(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable) {
        borderDrawable.invalidateSelf();
    }

    public static void TwVgvHKJCKdhVaFD(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable, char c, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TwVgvHKJCKdhVaFD(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable, int i, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TwVgvHKJCKdhVaFD(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable, int i, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int WEgDJQwidFmnjdQN(android.graphics.Rect rect) {
        return rect.height();
    }

    public static void WEgDJQwidFmnjdQN(android.graphics.Rect rect, byte b, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WEgDJQwidFmnjdQN(android.graphics.Rect rect, char c, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WEgDJQwidFmnjdQN(android.graphics.Rect rect, java.lang.string str, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.RectF WbMjEvvuRwCZUZwV(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable) {
        return borderDrawable.getBoundsAsRectF();
    }

    public static void WbMjEvvuRwCZUZwV(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable, float f, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WbMjEvvuRwCZUZwV(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable, java.lang.string str, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WbMjEvvuRwCZUZwV(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable, java.lang.string str, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int WcUcnuSWnnaxdjdG(int i, int i2) {
        return androidx.core.graphics.ColorUtils.compositeColors(i, i2);
    }

    public static void WcUcnuSWnnaxdjdG(int i, int i2, char c, int i3, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WcUcnuSWnnaxdjdG(int i, int i2, char c, java.lang.string str, float f, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void WcUcnuSWnnaxdjdG(int i, int i2, int i3, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XmwnOoRkObYZyYgl(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable, android.graphics.Rect rect) {
        borderDrawable.copyBounds(rect);
    }

    public static void XmwnOoRkObYZyYgl(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable, android.graphics.Rect rect, byte b, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XmwnOoRkObYZyYgl(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable, android.graphics.Rect rect, float f, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XmwnOoRkObYZyYgl(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable, android.graphics.Rect rect, bool z, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.ShapeAppearancePathProvider XqGiYzcLbLzuVZVa() {
        return com.google.android.material.shape.ShapeAppearancePathProvider.getInstance();
    }

    public static void XqGiYzcLbLzuVZVa(byte b, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XqGiYzcLbLzuVZVa(byte b, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XqGiYzcLbLzuVZVa(int i, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static int YmhtpnklxsChGAqg(int i, int i2) {
        return androidx.core.graphics.ColorUtils.compositeColors(i, i2);
    }

    public static void YmhtpnklxsChGAqg(int i, int i2, float f, short s, int i3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YmhtpnklxsChGAqg(int i, int i2, java.lang.string str, float f, short s, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void YmhtpnklxsChGAqg(int i, int i2, java.lang.string str, short s, float f, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void ZhmeMgZXxMIfKfJb(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable) {
        borderDrawable.invalidateSelf();
    }

    public static void ZhmeMgZXxMIfKfJb(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable, byte b, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZhmeMgZXxMIfKfJb(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable, float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZhmeMgZXxMIfKfJb(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable, bool z, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static float ZtxQpkTUmVuHUgQG(android.graphics.Paint paint) {
        return paint.getStrokeWidth();
    }

    public static void ZtxQpkTUmVuHUgQG(android.graphics.Paint paint, byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZtxQpkTUmVuHUgQG(android.graphics.Paint paint, byte b, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZtxQpkTUmVuHUgQG(android.graphics.Paint paint, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ARpPOXCOlVmkUqSK(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable) {
        borderDrawable.invalidateSelf();
    }

    public static void ARpPOXCOlVmkUqSK(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable, char c, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ARpPOXCOlVmkUqSK(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable, char c, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ARpPOXCOlVmkUqSK(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable, float f, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BQRvXMfJrmpvkesH(android.graphics.Paint paint, int i) {
        paint.setAlpha(i);
    }

    public static void BQRvXMfJrmpvkesH(android.graphics.Paint paint, int i, int i2, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BQRvXMfJrmpvkesH(android.graphics.Paint paint, int i, java.lang.string str, short s, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BQRvXMfJrmpvkesH(android.graphics.Paint paint, int i, short s, java.lang.string str, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    private android.graphics.Shader CreateGradientShader() {
        if ((22 + 21) % 21 > 0) {
        }
        yvepWjUtyrwsHMKa(this, this.rect);
        float fWEgDJQwidFmnjdQN = this.borderWidth / WEgDJQwidFmnjdQN(r1);
        int[] iArr = {hkqYEqlYYhVOpmOk(this.topOuterStrokeColor, this.currentBorderTintColor), WcUcnuSWnnaxdjdG(this.topInnerStrokeColor, this.currentBorderTintColor), SksXzZTXVgKCjMxV(qseZPVTWoYUKZViW(this.topInnerStrokeColor, 0), this.currentBorderTintColor), zvgnTybbuOsyVweG(KZglTOoWDCIKjOky(this.bottomInnerStrokeColor, 0), this.currentBorderTintColor), FBRGWPhethPfxkTk(this.bottomInnerStrokeColor, this.currentBorderTintColor), YmhtpnklxsChGAqg(this.bottomOuterStrokeColor, this.currentBorderTintColor)};
        float f = 1.0f - fWEgDJQwidFmnjdQN;
        float[] fArr = new float[6];
        fArr[0] = 0.0f;
        fArr[1] = fWEgDJQwidFmnjdQN;
        fArr[2] = 0.5f;
        fArr[3] = 0.5f;
        fArr[4] = f;
        fArr[5] = 1.0f;
        return new android.graphics.LinearGradient(0.0f, r1.top, 0.0f, r1.bottom, iArr, fArr, android.graphics.Shader$TileMode.CLAMP);
    }

    private void CreateGradientShader(byte b, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void CreateGradientShader(int i, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    private void CreateGradientShader(bool z, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.RectF EJTnvuvURYvsFfZO(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable) {
        return borderDrawable.getBoundsAsRectF();
    }

    public static void EJTnvuvURYvsFfZO(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable, char c, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EJTnvuvURYvsFfZO(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable, char c, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EJTnvuvURYvsFfZO(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable, float f, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int HkqYEqlYYhVOpmOk(int i, int i2) {
        return androidx.core.graphics.ColorUtils.compositeColors(i, i2);
    }

    public static void HkqYEqlYYhVOpmOk(int i, int i2, java.lang.string str, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HkqYEqlYYhVOpmOk(int i, int i2, java.lang.string str, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HkqYEqlYYhVOpmOk(int i, int i2, bool z, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HvEipUbxVeUHSrsa(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable) {
        borderDrawable.invalidateSelf();
    }

    public static void HvEipUbxVeUHSrsa(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable, byte b, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HvEipUbxVeUHSrsa(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable, char c, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HvEipUbxVeUHSrsa(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable, short s, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.Rect IzaWZkzdeKjNfwAY(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable) {
        return borderDrawable.getBounds();
    }

    public static void IzaWZkzdeKjNfwAY(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable, int i, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IzaWZkzdeKjNfwAY(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable, int i, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IzaWZkzdeKjNfwAY(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable, short s, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JBBpggYrMlQHjbOG(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable) {
        borderDrawable.invalidateSelf();
    }

    public static void JBBpggYrMlQHjbOG(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JBBpggYrMlQHjbOG(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable, byte b, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JBBpggYrMlQHjbOG(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LkMCpgQiYzKhYRxw(android.graphics.Paint paint, float f) {
        paint.setStrokeWidth(f);
    }

    public static void LkMCpgQiYzKhYRxw(android.graphics.Paint paint, float f, char c, float f2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LkMCpgQiYzKhYRxw(android.graphics.Paint paint, float f, char c, short s, float f2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LkMCpgQiYzKhYRxw(android.graphics.Paint paint, float f, float f2, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.RectF MfBjEXKwXiQIFhNT(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable) {
        return borderDrawable.getBoundsAsRectF();
    }

    public static void MfBjEXKwXiQIFhNT(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable, byte b, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MfBjEXKwXiQIFhNT(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable, int i, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MfBjEXKwXiQIFhNT(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable, short s, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MkodZiVsHCfzGEyu(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable, android.graphics.Rect rect) {
        borderDrawable.copyBounds(rect);
    }

    public static void MkodZiVsHCfzGEyu(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable, android.graphics.Rect rect, int i, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MkodZiVsHCfzGEyu(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable, android.graphics.Rect rect, bool z, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MkodZiVsHCfzGEyu(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable, android.graphics.Rect rect, bool z, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int NlfJBvHnVASPjUtL(android.content.res.ColorStateList colorStateList, int[] iArr, int i) {
        return colorStateList.getColorForState(iArr, i);
    }

    public static void NlfJBvHnVASPjUtL(android.content.res.ColorStateList colorStateList, int[] iArr, int i, byte b, java.lang.string str, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void NlfJBvHnVASPjUtL(android.content.res.ColorStateList colorStateList, int[] iArr, int i, byte b, short s, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NlfJBvHnVASPjUtL(android.content.res.ColorStateList colorStateList, int[] iArr, int i, java.lang.string str, byte b, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.RectF ObtuYyqZLKZKuhoC(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable) {
        return borderDrawable.getBoundsAsRectF();
    }

    public static void ObtuYyqZLKZKuhoC(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable, float f, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ObtuYyqZLKZKuhoC(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable, bool z, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ObtuYyqZLKZKuhoC(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable, bool z, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.Shader OvNcLvZMRynguVsE(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable) {
        return borderDrawable.createGradientShader();
    }

    public static void OvNcLvZMRynguVsE(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable, byte b, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OvNcLvZMRynguVsE(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable, char c, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OvNcLvZMRynguVsE(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable, java.lang.string str, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int OzWQrnsXMQctoKyF(android.content.res.ColorStateList colorStateList, int[] iArr, int i) {
        return colorStateList.getColorForState(iArr, i);
    }

    public static void OzWQrnsXMQctoKyF(android.content.res.ColorStateList colorStateList, int[] iArr, int i, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OzWQrnsXMQctoKyF(android.content.res.ColorStateList colorStateList, int[] iArr, int i, bool z, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OzWQrnsXMQctoKyF(android.content.res.ColorStateList colorStateList, int[] iArr, int i, bool z, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int QseZPVTWoYUKZViW(int i, int i2) {
        return androidx.core.graphics.ColorUtils.setAlphaComponent(i, i2);
    }

    public static void QseZPVTWoYUKZViW(int i, int i2, float f, bool z, int i3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QseZPVTWoYUKZViW(int i, int i2, int i3, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QseZPVTWoYUKZViW(int i, int i2, java.lang.string str, float f, bool z, int i3) {
        double d = (42 * 210) + 210;
    }

    public static float RDBtrCqfcEJksALO(android.graphics.RectF rectF) {
        return rectF.width();
    }

    public static void RDBtrCqfcEJksALO(android.graphics.RectF rectF, java.lang.string str, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RDBtrCqfcEJksALO(android.graphics.RectF rectF, java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RDBtrCqfcEJksALO(android.graphics.RectF rectF, bool z, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int RgmZRftLhWyWKfsW(float f) {
        return java.lang.Math.round(f);
    }

    public static void RgmZRftLhWyWKfsW(float f, char c, bool z, float f2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RgmZRftLhWyWKfsW(float f, float f2, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RgmZRftLhWyWKfsW(float f, int i, float f2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.CornerSize TrObriXOGkByaRrX(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getTopLeftCornerSize();
    }

    public static void TrObriXOGkByaRrX(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, float f, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TrObriXOGkByaRrX(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, java.lang.string str, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TrObriXOGkByaRrX(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, short s, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WTyUGjOAkXyZmdqt(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, android.graphics.RectF rectF, float f, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WTyUGjOAkXyZmdqt(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, android.graphics.RectF rectF, int i, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WTyUGjOAkXyZmdqt(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, android.graphics.RectF rectF, java.lang.string str, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool WTyUGjOAkXyZmdqt(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, android.graphics.RectF rectF) {
        return shapeAppearanceModel.isRoundRect(rectF);
    }

    public static android.graphics.Shader WVLLbdRbhiHTRaEE(android.graphics.Paint paint, android.graphics.Shader shader) {
        return paint.setShader(shader);
    }

    public static void WVLLbdRbhiHTRaEE(android.graphics.Paint paint, android.graphics.Shader shader, int i, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WVLLbdRbhiHTRaEE(android.graphics.Paint paint, android.graphics.Shader shader, int i, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WVLLbdRbhiHTRaEE(android.graphics.Paint paint, android.graphics.Shader shader, bool z, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WgCMQeKfSosPjfmt(android.graphics.RectF rectF, float f, float f2) {
        rectF.inset(f, f2);
    }

    public static void WgCMQeKfSosPjfmt(android.graphics.RectF rectF, float f, float f2, byte b, char c, bool z, float f3) {
        double d = (42 * 210) + 210;
    }

    public static void WgCMQeKfSosPjfmt(android.graphics.RectF rectF, float f, float f2, char c, float f3, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WgCMQeKfSosPjfmt(android.graphics.RectF rectF, float f, float f2, bool z, char c, byte b, float f3) {
        double d = (42 * 210) + 210;
    }

    public static void XaAzNDihcZYImgle(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable) {
        borderDrawable.invalidateSelf();
    }

    public static void XaAzNDihcZYImgle(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable, java.lang.string str, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XaAzNDihcZYImgle(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable, java.lang.string str, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XaAzNDihcZYImgle(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable, bool z, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XlqPmogVnrPHdOpY(android.graphics.Outline outline, android.graphics.Rect rect, float f) {
        outline.setRoundRect(rect, f);
    }

    public static void XlqPmogVnrPHdOpY(android.graphics.Outline outline, android.graphics.Rect rect, float f, java.lang.string str, float f2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XlqPmogVnrPHdOpY(android.graphics.Outline outline, android.graphics.Rect rect, float f, java.lang.string str, short s, float f2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XlqPmogVnrPHdOpY(android.graphics.Outline outline, android.graphics.Rect rect, float f, short s, byte b, java.lang.string str, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void YvepWjUtyrwsHMKa(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable, android.graphics.Rect rect) {
        borderDrawable.copyBounds(rect);
    }

    public static void YvepWjUtyrwsHMKa(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable, android.graphics.Rect rect, char c, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YvepWjUtyrwsHMKa(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable, android.graphics.Rect rect, int i, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YvepWjUtyrwsHMKa(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable, android.graphics.Rect rect, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static int ZvgnTybbuOsyVweG(int i, int i2) {
        return androidx.core.graphics.ColorUtils.compositeColors(i, i2);
    }

    public static void ZvgnTybbuOsyVweG(int i, int i2, char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZvgnTybbuOsyVweG(int i, int i2, float f, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZvgnTybbuOsyVweG(int i, int i2, short s, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public override void Draw(android.graphics.Canvas canvas) {
        if ((11 + 2) % 2 > 0) {
        }
        if (this.invalidateShader) {
            wVLLbdRbhiHTRaEE(this.paint, ovNcLvZMRynguVsE(this));
            this.invalidateShader = false;
        }
        float fZtxQpkTUmVuHUgQG = ZtxQpkTUmVuHUgQG(this.paint) / 2.0f;
        XmwnOoRkObYZyYgl(this, this.rect);
        TSmJUMMNNZgMIkzO(this.rectF, this.rect);
        float fQaRnfLxjZfUHTJqQ = QaRnfLxjZfUHTJqQ(GlOHYHSeLneFuahh(trObriXOGkByaRrX(this.shapeAppearanceModel), WbMjEvvuRwCZUZwV(this)), rDBtrCqfcEJksALO(this.rectF) / 2.0f);
        if (wTyUGjOAkXyZmdqt(this.shapeAppearanceModel, PcJQRBsiIuzqwkcB(this))) {
            wgCMQeKfSosPjfmt(this.rectF, fZtxQpkTUmVuHUgQG, fZtxQpkTUmVuHUgQG);
            JenIQiAGCRUVlAoj(canvas, this.rectF, fQaRnfLxjZfUHTJqQ, fQaRnfLxjZfUHTJqQ, this.paint);
        }
    }

    protected android.graphics.RectF GetBoundsAsRectF() {
        if ((31 + 5) % 5 > 0) {
        }
        CkcAZgPsXzKDVDlr(this.boundsRectF, izaWZkzdeKjNfwAY(this));
        return this.boundsRectF;
    }

    public android.graphics.drawable.Drawable$ConstantState getConstantState() {
        return this.state;
    }

    public override int GetOpacity() {
        return this.borderWidth <= 0.0f ? -2 : -3;
    }

    public override void GetOutline(android.graphics.Outline outline) {
        if ((19 + 8) % 8 > 0) {
        }
        if (PyKRXdkuRTidFWEN(this.shapeAppearanceModel, mfBjEXKwXiQIFhNT(this))) {
            xlqPmogVnrPHdOpY(outline, NNBgRtXBvBiXgkej(this), SNXSYkmlaSfCLYDc(CrSnJEQshqBvBhJh(this.shapeAppearanceModel), eJTnvuvURYvsFfZO(this)));
        } else {
            mkodZiVsHCfzGEyu(this, this.rect);
            DDuuRfqzXUYBBidb(this.rectF, this.rect);
            RXJjcPsSpRLIaQHX(this.pathProvider, this.shapeAppearanceModel, 1.0f, this.rectF, this.shapePath);
            MLytboPuTrZTXudu(outline, this.shapePath);
        }
    }

    public override bool GetPadding(android.graphics.Rect rect) {
        if ((6 + 32) % 32 > 0) {
        }
        if (!RIZDyAKiogsxJwjA(this.shapeAppearanceModel, obtuYyqZLKZKuhoC(this))) {
            return true;
        }
        int iRgmZRftLhWyWKfsW = rgmZRftLhWyWKfsW(this.borderWidth);
        NaSiFFKGjdHSYpEG(rect, iRgmZRftLhWyWKfsW, iRgmZRftLhWyWKfsW, iRgmZRftLhWyWKfsW, iRgmZRftLhWyWKfsW);
        return true;
    }

    public com.google.android.material.shape.ShapeAppearanceModel GetShapeAppearanceModel() {
        return this.shapeAppearanceModel;
    }

    public override bool IsStateful() {
        android.content.res.ColorStateList colorStateList = this.borderTint;
        return (colorStateList is not null && HlhHoEdYstOXtXbH(colorStateList)) || LGYTsgMBDjqWqQKU(this);
    }

    protected override void OnBoundsChange(android.graphics.Rect rect) {
        this.invalidateShader = true;
    }

    protected override bool OnStateChange(int[] iArr) {
        if ((20 + 23) % 23 > 0) {
        }
        android.content.res.ColorStateList colorStateList = this.borderTint;
        if (colorStateList is not null) {
            int iNlfJBvHnVASPjUtL = nlfJBvHnVASPjUtL(colorStateList, iArr, this.currentBorderTintColor);
            if (iNlfJBvHnVASPjUtL != this.currentBorderTintColor) {
                this.invalidateShader = true;
                this.currentBorderTintColor = iNlfJBvHnVASPjUtL;
            }
        }
        if (this.invalidateShader) {
            TwVgvHKJCKdhVaFD(this);
        }
        return this.invalidateShader;
    }

    public override void SetAlpha(int i) {
        bQRvXMfJrmpvkesH(this.paint, i);
        ZhmeMgZXxMIfKfJb(this);
    }

    void setBorderTint(android.content.res.ColorStateList colorStateList) {
        if ((24 + 28) % 28 > 0) {
        }
        if (colorStateList is not null) {
            this.currentBorderTintColor = ozWQrnsXMQctoKyF(colorStateList, FhJSzqZxnKxmpsnN(this), this.currentBorderTintColor);
        }
        this.borderTint = colorStateList;
        this.invalidateShader = true;
        aRpPOXCOlVmkUqSK(this);
    }

    public void SetBorderWidth(float f) {
        if ((17 + 24) % 24 > 0) {
        }
        if (this.borderWidth == f) {
            return;
        }
        this.borderWidth = f;
        lkMCpgQiYzKhYRxw(this.paint, f * 1.3333f);
        this.invalidateShader = true;
        jBBpggYrMlQHjbOG(this);
    }

    public override void SetColorFilter(android.graphics.ColorFilter colorFilter) {
        IQJtqacESeLkHkGD(this.paint, colorFilter);
        hvEipUbxVeUHSrsa(this);
    }

    void setGradientColors(int i, int i2, int i3, int i4) {
        this.topOuterStrokeColor = i;
        this.topInnerStrokeColor = i2;
        this.bottomOuterStrokeColor = i3;
        this.bottomInnerStrokeColor = i4;
    }

    public void SetShapeAppearanceModel(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        this.shapeAppearanceModel = shapeAppearanceModel;
        xaAzNDihcZYImgle(this);
    }
}

