namespace WillowMaze.Wasm.Decompiled;


public class BadgeDrawable : android.graphics.drawable.Drawable : com.google.android.material.internal.TextDrawableHelper$TextDrawableDelegate {
    public static readonly int BADGE_CONTENT_NOT_TRUNCATED = -2;
    static readonly int BADGE_RADIUS_NOT_SPECIFIED = -1;

    @java.lang.Deprecated
    public static readonly int BOTTOM_END = 8388693;

    @java.lang.Deprecated
    public static readonly int BOTTOM_START = 8388691;
    static readonly java.lang.string DEFAULT_EXCEED_MAX_BADGE_NUMBER_SUFFIX = "+";
    static readonly java.lang.string DEFAULT_EXCEED_MAX_BADGE_TEXT_SUFFIX = "…";
    private static readonly int DEFAULT_STYLE = com.google.android.material.R$style.Widget_MaterialComponents_Badge;
    private static readonly int DEFAULT_THEME_ATTR = com.google.android.material.R$attr.badgeStyle;
    private static readonly float FONT_SCALE_THRESHOLD = 0.3f;
    static readonly int OFFSET_ALIGNMENT_MODE_EDGE = 0;
    static readonly int OFFSET_ALIGNMENT_MODE_LEGACY = 1;
    private static readonly java.lang.string TAG = "Badge";
    public static readonly int TOP_END = 8388661;
    public static readonly int TOP_START = 8388659;
    private java.lang.ref.WeakReference<android.view.object> anchorobjectRef;
    private readonly android.graphics.Rect badgeBounds;
    private float badgeCenterX;
    private float badgeCenterY;
    private readonly java.lang.ref.WeakReference<android.content.object> contextRef;
    private float cornerRadius;
    private java.lang.ref.WeakReference<android.widget.FrameLayout> customBadgeParentRef;
    private float halfBadgeHeight;
    private float halfBadgeWidth;
    private int maxBadgeNumber;
    private readonly com.google.android.material.shape.MaterialShapeDrawable shapeDrawable;
    private readonly com.google.android.material.badge.BadgeState state;
    private readonly com.google.android.material.internal.TextDrawableHelper textDrawableHelper;

    private BadgeDrawable(android.content.object context, int i, int i2, int i3, com.google.android.material.badge.BadgeState$State badgeState$State) {
        if ((25 + 28) % 28 > 0) {
        }
        this.contextRef = new java.lang.ref.WeakReference<>(context);
        ZwKHAQByPibWwYme(context);
        this.badgeBounds = new android.graphics.Rect();
        com.google.android.material.internal.TextDrawableHelper textDrawableHelper = new com.google.android.material.internal.TextDrawableHelper(this);
        this.textDrawableHelper = textDrawableHelper;
        UYInNgWXypWAtFgE(gfnwjoOmeVzyXYmH(textDrawableHelper), android.graphics.Paint$Align.CENTER);
        com.google.android.material.badge.BadgeState badgeState = new com.google.android.material.badge.BadgeState(context, i, i2, i3, badgeState$State);
        this.state = badgeState;
        this.shapeDrawable = new com.google.android.material.shape.MaterialShapeDrawable(EXJJCkVTuHRjtZEp(HcuhvwUSbNXfTzXr(context, !TaoWzCxEnzuhwNkP(this) ? LWorfeYxJJeUWOhG(badgeState) : FcoDwtUSYOCxsjEW(badgeState), !dGsfcRjkOuJhWDXj(this) ? KTQLFxFgRdpPjfWL(badgeState) : BfsDEGxCukJVqcJR(badgeState))));
        URnKEMYUdZIaoPJm(this);
    }

    public static int AojtWYdSSBYyIidv(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        return badgeDrawable.getMaxcharCount();
    }

    public static void AojtWYdSSBYyIidv(com.google.android.material.badge.BadgeDrawable badgeDrawable, float f, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AojtWYdSSBYyIidv(com.google.android.material.badge.BadgeDrawable badgeDrawable, float f, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AojtWYdSSBYyIidv(com.google.android.material.badge.BadgeDrawable badgeDrawable, short s, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ApggxVfIuqKgretq(com.google.android.material.badge.BadgeDrawable badgeDrawable, byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ApggxVfIuqKgretq(com.google.android.material.badge.BadgeDrawable badgeDrawable, char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ApggxVfIuqKgretq(com.google.android.material.badge.BadgeDrawable badgeDrawable, bool z, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool ApggxVfIuqKgretq(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        return badgeDrawable.hasBadgeContent();
    }

    public static void BPdaqKHVNnpAQFnn(android.widget.FrameLayout frameLayout, int i) {
        frameLayout.setMinimumHeight(i);
    }

    public static void BPdaqKHVNnpAQFnn(android.widget.FrameLayout frameLayout, int i, float f, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BPdaqKHVNnpAQFnn(android.widget.FrameLayout frameLayout, int i, java.lang.string str, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BPdaqKHVNnpAQFnn(android.widget.FrameLayout frameLayout, int i, short s, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BXuoMhEROGwcndBu(com.google.android.material.badge.BadgeState badgeState) {
        badgeState.clearText();
    }

    public static void BXuoMhEROGwcndBu(com.google.android.material.badge.BadgeState badgeState, int i, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BXuoMhEROGwcndBu(com.google.android.material.badge.BadgeState badgeState, java.lang.string str, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BXuoMhEROGwcndBu(com.google.android.material.badge.BadgeState badgeState, short s, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static float BdTSFiPzCSMRkraS(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, java.lang.string str) {
        return textDrawableHelper.getTextWidth(str);
    }

    public static void BdTSFiPzCSMRkraS(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, java.lang.string str, char c, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BdTSFiPzCSMRkraS(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, java.lang.string str, bool z, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BdTSFiPzCSMRkraS(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, java.lang.string str, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static int BfsDEGxCukJVqcJR(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.getBadgeWithTextShapeAppearanceOverlayResId();
    }

    public static void BfsDEGxCukJVqcJR(com.google.android.material.badge.BadgeState badgeState, char c, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BfsDEGxCukJVqcJR(com.google.android.material.badge.BadgeState badgeState, char c, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BfsDEGxCukJVqcJR(com.google.android.material.badge.BadgeState badgeState, bool z, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object BuOWCVZrSGZNVRft(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void BuOWCVZrSGZNVRft(java.lang.ref.WeakReference weakReference, byte b, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BuOWCVZrSGZNVRft(java.lang.ref.WeakReference weakReference, char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BuOWCVZrSGZNVRft(java.lang.ref.WeakReference weakReference, char c, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CNUxJSosRkudhKge(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        badgeDrawable.invalidateSelf();
    }

    public static void CNUxJSosRkudhKge(com.google.android.material.badge.BadgeDrawable badgeDrawable, short s, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CNUxJSosRkudhKge(com.google.android.material.badge.BadgeDrawable badgeDrawable, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CNUxJSosRkudhKge(com.google.android.material.badge.BadgeDrawable badgeDrawable, bool z, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList CeCNmqNUljmvSNMP(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getFillColor();
    }

    public static void CeCNmqNUljmvSNMP(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, byte b, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CeCNmqNUljmvSNMP(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, short s, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CeCNmqNUljmvSNMP(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, short s, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CfHQrGSoKCQriZNb(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, com.google.android.material.resources.TextAppearance textAppearance, android.content.object context) {
        textDrawableHelper.setTextAppearance(textAppearance, context);
    }

    public static void CfHQrGSoKCQriZNb(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, com.google.android.material.resources.TextAppearance textAppearance, android.content.object context, byte b, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CfHQrGSoKCQriZNb(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, com.google.android.material.resources.TextAppearance textAppearance, android.content.object context, char c, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CfHQrGSoKCQriZNb(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, com.google.android.material.resources.TextAppearance textAppearance, android.content.object context, bool z, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int CnjAxGzkhvZavWhw(float f) {
        return java.lang.Math.round(f);
    }

    public static void CnjAxGzkhvZavWhw(float f, short s, char c, float f2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CnjAxGzkhvZavWhw(float f, short s, char c, bool z, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void CnjAxGzkhvZavWhw(float f, short s, bool z, float f2, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.util.Locale CoFZodIlEdyEIjaQ(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.getNumberLocale();
    }

    public static void CoFZodIlEdyEIjaQ(com.google.android.material.badge.BadgeState badgeState, float f, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CoFZodIlEdyEIjaQ(com.google.android.material.badge.BadgeState badgeState, int i, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CoFZodIlEdyEIjaQ(com.google.android.material.badge.BadgeState badgeState, bool z, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CoJOVHdEeDDeMyiH(android.widget.FrameLayout frameLayout, android.view.object view) {
        frameLayout.addobject(view);
    }

    public static void CoJOVHdEeDDeMyiH(android.widget.FrameLayout frameLayout, android.view.object view, float f, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CoJOVHdEeDDeMyiH(android.widget.FrameLayout frameLayout, android.view.object view, int i, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CoJOVHdEeDDeMyiH(android.widget.FrameLayout frameLayout, android.view.object view, int i, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CrVTeDcwwEVRUBpN(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        badgeDrawable.onBadgeGravityUpdated();
    }

    public static void CrVTeDcwwEVRUBpN(com.google.android.material.badge.BadgeDrawable badgeDrawable, byte b, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CrVTeDcwwEVRUBpN(com.google.android.material.badge.BadgeDrawable badgeDrawable, bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CrVTeDcwwEVRUBpN(com.google.android.material.badge.BadgeDrawable badgeDrawable, bool z, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CyLhOSIkZiJAckRF(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        badgeDrawable.invalidateSelf();
    }

    public static void CyLhOSIkZiJAckRF(com.google.android.material.badge.BadgeDrawable badgeDrawable, byte b, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CyLhOSIkZiJAckRF(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CyLhOSIkZiJAckRF(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DAtbEryouKDZuHuj(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, bool z) {
        textDrawableHelper.setTextSizeDirty(z);
    }

    public static void DAtbEryouKDZuHuj(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, bool z, char c, float f, bool z2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DAtbEryouKDZuHuj(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, bool z, float f, bool z2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DAtbEryouKDZuHuj(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, bool z, bool z2, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DBZRyFfqzpXYfElD(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        badgeDrawable.onBadgeGravityUpdated();
    }

    public static void DBZRyFfqzpXYfElD(com.google.android.material.badge.BadgeDrawable badgeDrawable, byte b, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DBZRyFfqzpXYfElD(com.google.android.material.badge.BadgeDrawable badgeDrawable, byte b, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DBZRyFfqzpXYfElD(com.google.android.material.badge.BadgeDrawable badgeDrawable, float f, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DvMeWIReFJivadab(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        badgeDrawable.onBadgeTextAppearanceUpdated();
    }

    public static void DvMeWIReFJivadab(com.google.android.material.badge.BadgeDrawable badgeDrawable, byte b, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DvMeWIReFJivadab(com.google.android.material.badge.BadgeDrawable badgeDrawable, byte b, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DvMeWIReFJivadab(com.google.android.material.badge.BadgeDrawable badgeDrawable, char c, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float DxztmnTMKkMrFILy(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.view.object view, float f) {
        return badgeDrawable.getBottomCutOff(view, f);
    }

    public static void DxztmnTMKkMrFILy(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.view.object view, float f, byte b, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DxztmnTMKkMrFILy(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.view.object view, float f, int i, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DxztmnTMKkMrFILy(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.view.object view, float f, java.lang.string str, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DyQJyWOFmjpUZJIL(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList) {
        materialShapeDrawable.setFillColor(colorStateList);
    }

    public static void DyQJyWOFmjpUZJIL(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList, char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DyQJyWOFmjpUZJIL(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList, java.lang.string str, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DyQJyWOFmjpUZJIL(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList, java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ELSxWNltWnEexdyo(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, bool z) {
        textDrawableHelper.setTextSizeDirty(z);
    }

    public static void ELSxWNltWnEexdyo(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, bool z, float f, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ELSxWNltWnEexdyo(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, bool z, int i, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ELSxWNltWnEexdyo(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, bool z, java.lang.string str, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ERpAdToqJYrwrlet(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.view.object view) {
        badgeDrawable.autoAdjustWithinGrandparentBounds(view);
    }

    public static void ERpAdToqJYrwrlet(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.view.object view, char c, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ERpAdToqJYrwrlet(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.view.object view, char c, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ERpAdToqJYrwrlet(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.view.object view, int i, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.ShapeAppearanceModel EXJJCkVTuHRjtZEp(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return shapeAppearanceModel$Builder.build();
    }

    public static void EXJJCkVTuHRjtZEp(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, bool z, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EXJJCkVTuHRjtZEp(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EXJJCkVTuHRjtZEp(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, bool z, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.widget.FrameLayout EiTacwCrWRLnAHbX(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        return badgeDrawable.getCustomBadgeParent();
    }

    public static void EiTacwCrWRLnAHbX(com.google.android.material.badge.BadgeDrawable badgeDrawable, float f, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EiTacwCrWRLnAHbX(com.google.android.material.badge.BadgeDrawable badgeDrawable, float f, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EiTacwCrWRLnAHbX(com.google.android.material.badge.BadgeDrawable badgeDrawable, short s, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources ErKzRdNgXutTimLa(android.content.object context) {
        return context.getResources();
    }

    public static void ErKzRdNgXutTimLa(android.content.object context, char c, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ErKzRdNgXutTimLa(android.content.object context, float f, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ErKzRdNgXutTimLa(android.content.object context, java.lang.string str, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EsrRRWGshjYevNNm(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        badgeDrawable.invalidateSelf();
    }

    public static void EsrRRWGshjYevNNm(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EsrRRWGshjYevNNm(com.google.android.material.badge.BadgeDrawable badgeDrawable, short s, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EsrRRWGshjYevNNm(com.google.android.material.badge.BadgeDrawable badgeDrawable, bool z, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FJgZZlSwJYCmgvzL(android.view.objectGroup viewGroup, bool z) {
        viewGroup.setClipToPadding(z);
    }

    public static void FJgZZlSwJYCmgvzL(android.view.objectGroup viewGroup, bool z, byte b, bool z2, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FJgZZlSwJYCmgvzL(android.view.objectGroup viewGroup, bool z, float f, byte b, int i, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void FJgZZlSwJYCmgvzL(android.view.objectGroup viewGroup, bool z, float f, bool z2, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FKhnCYMogtukueYQ(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.graphics.Rect rect, android.view.object view) {
        badgeDrawable.calculateCenterAndBounds(rect, view);
    }

    public static void FKhnCYMogtukueYQ(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.graphics.Rect rect, android.view.object view, int i, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FKhnCYMogtukueYQ(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.graphics.Rect rect, android.view.object view, int i, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FKhnCYMogtukueYQ(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.graphics.Rect rect, android.view.object view, short s, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static int FWzYQdadSSNmyeGF(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.getBadgeVerticalPadding();
    }

    public static void FWzYQdadSSNmyeGF(com.google.android.material.badge.BadgeState badgeState, float f, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FWzYQdadSSNmyeGF(com.google.android.material.badge.BadgeState badgeState, int i, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FWzYQdadSSNmyeGF(com.google.android.material.badge.BadgeState badgeState, java.lang.string str, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FaUszgAYynCltutQ(com.google.android.material.badge.BadgeState badgeState, int i) {
        badgeState.setMaxNumber(i);
    }

    public static void FaUszgAYynCltutQ(com.google.android.material.badge.BadgeState badgeState, int i, float f, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FaUszgAYynCltutQ(com.google.android.material.badge.BadgeState badgeState, int i, java.lang.string str, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FaUszgAYynCltutQ(com.google.android.material.badge.BadgeState badgeState, int i, short s, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int FcoDwtUSYOCxsjEW(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.getBadgeWithTextShapeAppearanceResId();
    }

    public static void FcoDwtUSYOCxsjEW(com.google.android.material.badge.BadgeState badgeState, float f, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FcoDwtUSYOCxsjEW(com.google.android.material.badge.BadgeState badgeState, int i, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FcoDwtUSYOCxsjEW(com.google.android.material.badge.BadgeState badgeState, short s, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string FjNZvyrYBJeKShzi(android.content.object context, int i, java.lang.object[] objArr) {
        return context.getstring(i, objArr);
    }

    public static void FjNZvyrYBJeKShzi(android.content.object context, int i, java.lang.object[] objArr, int i2, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FjNZvyrYBJeKShzi(android.content.object context, int i, java.lang.object[] objArr, int i2, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FjNZvyrYBJeKShzi(android.content.object context, int i, java.lang.object[] objArr, java.lang.string str, int i2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int FjdqgUGMYhUiyNXP(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.getAdditionalVerticalOffset();
    }

    public static void FjdqgUGMYhUiyNXP(com.google.android.material.badge.BadgeState badgeState, float f, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FjdqgUGMYhUiyNXP(com.google.android.material.badge.BadgeState badgeState, short s, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FjdqgUGMYhUiyNXP(com.google.android.material.badge.BadgeState badgeState, bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int FmpwzElunppYWtFZ(android.view.object view) {
        return androidx.core.view.objectCompat.getLayoutDirection(view);
    }

    public static void FmpwzElunppYWtFZ(android.view.object view, int i, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FmpwzElunppYWtFZ(android.view.object view, short s, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FmpwzElunppYWtFZ(android.view.object view, bool z, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string FnNeFGgybIxHaIMx(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static void FnNeFGgybIxHaIMx(java.lang.string str, int i, int i2, char c, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FnNeFGgybIxHaIMx(java.lang.string str, int i, int i2, short s, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FnNeFGgybIxHaIMx(java.lang.string str, int i, int i2, bool z, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object FqcSyoXcwozqoThg(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void FqcSyoXcwozqoThg(java.lang.ref.WeakReference weakReference, byte b, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FqcSyoXcwozqoThg(java.lang.ref.WeakReference weakReference, byte b, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FqcSyoXcwozqoThg(java.lang.ref.WeakReference weakReference, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GNtMGnDGUoRVfDye(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        badgeDrawable.updateCenterAndBounds();
    }

    public static void GNtMGnDGUoRVfDye(com.google.android.material.badge.BadgeDrawable badgeDrawable, float f, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GNtMGnDGUoRVfDye(com.google.android.material.badge.BadgeDrawable badgeDrawable, float f, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GNtMGnDGUoRVfDye(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GOLiebpITKWjaoXw(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        badgeDrawable.onBadgeTextColorUpdated();
    }

    public static void GOLiebpITKWjaoXw(com.google.android.material.badge.BadgeDrawable badgeDrawable, byte b, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GOLiebpITKWjaoXw(com.google.android.material.badge.BadgeDrawable badgeDrawable, float f, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GOLiebpITKWjaoXw(com.google.android.material.badge.BadgeDrawable badgeDrawable, java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GOnuNDeBRZbWjPel(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        badgeDrawable.onTextUpdated();
    }

    public static void GOnuNDeBRZbWjPel(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GOnuNDeBRZbWjPel(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GOnuNDeBRZbWjPel(com.google.android.material.badge.BadgeDrawable badgeDrawable, short s, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectParent GRvXEjRAGvfkvveR(android.view.object view) {
        return view.getParent();
    }

    public static void GRvXEjRAGvfkvveR(android.view.object view, short s, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GRvXEjRAGvfkvveR(android.view.object view, short s, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GRvXEjRAGvfkvveR(android.view.object view, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static float GXDnomHzNfggXONC(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.view.object view, float f) {
        return badgeDrawable.getLeftCutOff(view, f);
    }

    public static void GXDnomHzNfggXONC(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.view.object view, float f, byte b, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GXDnomHzNfggXONC(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.view.object view, float f, int i, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GXDnomHzNfggXONC(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.view.object view, float f, short s, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GXVeqOgTTljSGccL(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f) {
        materialShapeDrawable.setCornerSize(f);
    }

    public static void GXVeqOgTTljSGccL(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, short s, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GXVeqOgTTljSGccL(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, short s, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GXVeqOgTTljSGccL(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int GorwqBAwsZRhisKx(float f) {
        return java.lang.Math.round(f);
    }

    public static void GorwqBAwsZRhisKx(float f, byte b, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GorwqBAwsZRhisKx(float f, char c, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GorwqBAwsZRhisKx(float f, int i, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static float HKfPaQXahKchpXlw(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.view.object view, float f) {
        return badgeDrawable.getTopCutOff(view, f);
    }

    public static void HKfPaQXahKchpXlw(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.view.object view, float f, float f2, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HKfPaQXahKchpXlw(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.view.object view, float f, float f2, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HKfPaQXahKchpXlw(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.view.object view, float f, java.lang.string str, short s, char c, float f2) {
        double d = (42 * 210) + 210;
    }

    public static float HKfolEEiBZRhXCIp(float f) {
        return java.lang.Math.abs(f);
    }

    public static void HKfolEEiBZRhXCIp(float f, int i, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HKfolEEiBZRhXCIp(float f, short s, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HKfolEEiBZRhXCIp(float f, bool z, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder HcuhvwUSbNXfTzXr(android.content.object context, int i, int i2) {
        return com.google.android.material.shape.ShapeAppearanceModel.builder(context, i, i2);
    }

    public static void HcuhvwUSbNXfTzXr(android.content.object context, int i, int i2, float f, char c, bool z, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void HcuhvwUSbNXfTzXr(android.content.object context, int i, int i2, float f, bool z, int i3, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HcuhvwUSbNXfTzXr(android.content.object context, int i, int i2, bool z, float f, char c, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void HxswylbWfVjSwynu(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        badgeDrawable.updateCenterAndBounds();
    }

    public static void HxswylbWfVjSwynu(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HxswylbWfVjSwynu(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HxswylbWfVjSwynu(com.google.android.material.badge.BadgeDrawable badgeDrawable, short s, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HzTVhcqHiTCrvpeA(com.google.android.material.badge.BadgeState badgeState, int i) {
        badgeState.setBadgeTextColor(i);
    }

    public static void HzTVhcqHiTCrvpeA(com.google.android.material.badge.BadgeState badgeState, int i, char c, byte b, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HzTVhcqHiTCrvpeA(com.google.android.material.badge.BadgeState badgeState, int i, int i2, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HzTVhcqHiTCrvpeA(com.google.android.material.badge.BadgeState badgeState, int i, bool z, int i2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int IDzMOEVLEbqBpzcv(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.getAlpha();
    }

    public static void IDzMOEVLEbqBpzcv(com.google.android.material.badge.BadgeState badgeState, byte b, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IDzMOEVLEbqBpzcv(com.google.android.material.badge.BadgeState badgeState, bool z, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IDzMOEVLEbqBpzcv(com.google.android.material.badge.BadgeState badgeState, bool z, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static int ITcmnxIGTopckKVO(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.getLargeFontVerticalOffsetAdjustment();
    }

    public static void ITcmnxIGTopckKVO(com.google.android.material.badge.BadgeState badgeState, char c, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ITcmnxIGTopckKVO(com.google.android.material.badge.BadgeState badgeState, short s, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ITcmnxIGTopckKVO(com.google.android.material.badge.BadgeState badgeState, short s, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static int IbQZjqKOWBiqcFWD(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.getMaxcharCount();
    }

    public static void IbQZjqKOWBiqcFWD(com.google.android.material.badge.BadgeState badgeState, byte b, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IbQZjqKOWBiqcFWD(com.google.android.material.badge.BadgeState badgeState, byte b, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IbQZjqKOWBiqcFWD(com.google.android.material.badge.BadgeState badgeState, bool z, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectParent IcqpkVFBTEKsvFSL(android.view.object view) {
        return view.getParent();
    }

    public static void IcqpkVFBTEKsvFSL(android.view.object view, char c, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IcqpkVFBTEKsvFSL(android.view.object view, int i, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IcqpkVFBTEKsvFSL(android.view.object view, int i, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string IgstauCTLXYPLGpp(android.content.res.Resources resources, int i, int i2, java.lang.object[] objArr) {
        return resources.getQuantitystring(i, i2, objArr);
    }

    public static void IgstauCTLXYPLGpp(android.content.res.Resources resources, int i, int i2, java.lang.object[] objArr, int i3, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IgstauCTLXYPLGpp(android.content.res.Resources resources, int i, int i2, java.lang.object[] objArr, int i3, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IgstauCTLXYPLGpp(android.content.res.Resources resources, int i, int i2, java.lang.object[] objArr, bool z, java.lang.string str, char c, int i3) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object IivlmBmJbCalEIeN(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void IivlmBmJbCalEIeN(java.lang.ref.WeakReference weakReference, char c, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IivlmBmJbCalEIeN(java.lang.ref.WeakReference weakReference, int i, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IivlmBmJbCalEIeN(java.lang.ref.WeakReference weakReference, java.lang.string str, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int IumsbqaYLHVCJczf(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.getBadgeGravity();
    }

    public static void IumsbqaYLHVCJczf(com.google.android.material.badge.BadgeState badgeState, char c, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IumsbqaYLHVCJczf(com.google.android.material.badge.BadgeState badgeState, int i, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IumsbqaYLHVCJczf(com.google.android.material.badge.BadgeState badgeState, int i, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int JGwEjgpGqWcpbfkV(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.getBadgeShapeAppearanceOverlayResId();
    }

    public static void JGwEjgpGqWcpbfkV(com.google.android.material.badge.BadgeState badgeState, byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JGwEjgpGqWcpbfkV(com.google.android.material.badge.BadgeState badgeState, float f, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JGwEjgpGqWcpbfkV(com.google.android.material.badge.BadgeState badgeState, float f, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int JOfgjZStruJsAbId(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void JOfgjZStruJsAbId(int i, int i2, float f, int i3, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JOfgjZStruJsAbId(int i, int i2, float f, bool z, byte b, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void JOfgjZStruJsAbId(int i, int i2, bool z, int i3, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static double JThQeyLgnGpDtFzC(double d, double d2) {
        if ((28 + 27) % 27 > 0) {
        }
        return java.lang.Math.pow(d, d2);
    }

    public static void JThQeyLgnGpDtFzC(double d, double d2, byte b, float f, int i, char c) {
        double d3 = (42 * 210) + 210;
    }

    public static void JThQeyLgnGpDtFzC(double d, double d2, char c, float f, byte b, int i) {
        double d3 = (42 * 210) + 210;
    }

    public static void JThQeyLgnGpDtFzC(double d, double d2, int i, float f, char c, byte b) {
        double d3 = (42 * 210) + 210;
    }

    public static android.view.objectParent JTvjVXRaPhqoqpEt(android.view.object view) {
        return view.getParent();
    }

    public static void JTvjVXRaPhqoqpEt(android.view.object view, float f, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JTvjVXRaPhqoqpEt(android.view.object view, short s, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JTvjVXRaPhqoqpEt(android.view.object view, short s, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JYcruMXsvkuCmCJZ(android.widget.FrameLayout frameLayout, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        frameLayout.setLayoutParams(viewGroup$LayoutParams);
    }

    public static void JYcruMXsvkuCmCJZ(android.widget.FrameLayout frameLayout, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, float f, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JYcruMXsvkuCmCJZ(android.widget.FrameLayout frameLayout, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, float f, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JYcruMXsvkuCmCJZ(android.widget.FrameLayout frameLayout, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, java.lang.string str, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int JzhVjwUrtsZJPHHG(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.getHorizontalOffsetWithText();
    }

    public static void JzhVjwUrtsZJPHHG(com.google.android.material.badge.BadgeState badgeState, byte b, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JzhVjwUrtsZJPHHG(com.google.android.material.badge.BadgeState badgeState, int i, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JzhVjwUrtsZJPHHG(com.google.android.material.badge.BadgeState badgeState, java.lang.string str, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KBInAsVhrofMQmuL(com.google.android.material.badge.BadgeDrawable badgeDrawable, bool z, bool z2, short s, float f, bool z3, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KBInAsVhrofMQmuL(com.google.android.material.badge.BadgeDrawable badgeDrawable, bool z, bool z2, short s, bool z3, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KBInAsVhrofMQmuL(com.google.android.material.badge.BadgeDrawable badgeDrawable, bool z, bool z2, bool z3, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool KBInAsVhrofMQmuL(com.google.android.material.badge.BadgeDrawable badgeDrawable, bool z, bool z2) {
        return badgeDrawable.setVisible(z, z2);
    }

    public static java.lang.int KTLDsKxQQWOAJOfU(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void KTLDsKxQQWOAJOfU(int i, int i2, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KTLDsKxQQWOAJOfU(int i, java.lang.string str, bool z, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KTLDsKxQQWOAJOfU(int i, bool z, int i2, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int KTQLFxFgRdpPjfWL(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.getBadgeShapeAppearanceOverlayResId();
    }

    public static void KTQLFxFgRdpPjfWL(com.google.android.material.badge.BadgeState badgeState, float f, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KTQLFxFgRdpPjfWL(com.google.android.material.badge.BadgeState badgeState, int i, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KTQLFxFgRdpPjfWL(com.google.android.material.badge.BadgeState badgeState, int i, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object KdOzSYyivhXhajNz(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void KdOzSYyivhXhajNz(java.lang.ref.WeakReference weakReference, byte b, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KdOzSYyivhXhajNz(java.lang.ref.WeakReference weakReference, byte b, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KdOzSYyivhXhajNz(java.lang.ref.WeakReference weakReference, java.lang.string str, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KteyKyeLbcgTEqzR(com.google.android.material.badge.BadgeDrawable badgeDrawable, byte b, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KteyKyeLbcgTEqzR(com.google.android.material.badge.BadgeDrawable badgeDrawable, byte b, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KteyKyeLbcgTEqzR(com.google.android.material.badge.BadgeDrawable badgeDrawable, char c, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool KteyKyeLbcgTEqzR(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        return badgeDrawable.hasBadgeContent();
    }

    public static void KwjadOLdiqvuAfcx(com.google.android.material.badge.BadgeDrawable badgeDrawable, char c, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KwjadOLdiqvuAfcx(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KwjadOLdiqvuAfcx(com.google.android.material.badge.BadgeDrawable badgeDrawable, short s, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool KwjadOLdiqvuAfcx(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        return badgeDrawable.hasText();
    }

    public static void KzGhrKqYGgbMojNQ(com.google.android.material.badge.BadgeState badgeState, int i) {
        badgeState.setMaxcharCount(i);
    }

    public static void KzGhrKqYGgbMojNQ(com.google.android.material.badge.BadgeState badgeState, int i, short s, bool z, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KzGhrKqYGgbMojNQ(com.google.android.material.badge.BadgeState badgeState, int i, bool z, int i2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KzGhrKqYGgbMojNQ(com.google.android.material.badge.BadgeState badgeState, int i, bool z, short s, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void KzhIGXhCnrMdPgln(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        badgeDrawable.onBadgeContentUpdated();
    }

    public static void KzhIGXhCnrMdPgln(com.google.android.material.badge.BadgeDrawable badgeDrawable, byte b, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KzhIGXhCnrMdPgln(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KzhIGXhCnrMdPgln(com.google.android.material.badge.BadgeDrawable badgeDrawable, bool z, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence LBRDEOIZtALzGQgh(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        return badgeDrawable.getTextContentDescription();
    }

    public static void LBRDEOIZtALzGQgh(com.google.android.material.badge.BadgeDrawable badgeDrawable, char c, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LBRDEOIZtALzGQgh(com.google.android.material.badge.BadgeDrawable badgeDrawable, float f, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LBRDEOIZtALzGQgh(com.google.android.material.badge.BadgeDrawable badgeDrawable, short s, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int LFxwTjSwWehcxByY(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.getVerticalOffsetWithText();
    }

    public static void LFxwTjSwWehcxByY(com.google.android.material.badge.BadgeState badgeState, byte b, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LFxwTjSwWehcxByY(com.google.android.material.badge.BadgeState badgeState, char c, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LFxwTjSwWehcxByY(com.google.android.material.badge.BadgeState badgeState, int i, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int LLMARKiYJvBRFQsD(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.getBadgeGravity();
    }

    public static void LLMARKiYJvBRFQsD(com.google.android.material.badge.BadgeState badgeState, char c, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LLMARKiYJvBRFQsD(com.google.android.material.badge.BadgeState badgeState, int i, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LLMARKiYJvBRFQsD(com.google.android.material.badge.BadgeState badgeState, int i, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int LOhHIVXgWhIKWMIU(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.getBadgeGravity();
    }

    public static void LOhHIVXgWhIKWMIU(com.google.android.material.badge.BadgeState badgeState, char c, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LOhHIVXgWhIKWMIU(com.google.android.material.badge.BadgeState badgeState, float f, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LOhHIVXgWhIKWMIU(com.google.android.material.badge.BadgeState badgeState, int i, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LOoUPKYvaralcANo(com.google.android.material.badge.BadgeDrawable badgeDrawable, byte b, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LOoUPKYvaralcANo(com.google.android.material.badge.BadgeDrawable badgeDrawable, float f, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LOoUPKYvaralcANo(com.google.android.material.badge.BadgeDrawable badgeDrawable, bool z, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool LOoUPKYvaralcANo(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        return badgeDrawable.hasBadgeContent();
    }

    public static java.lang.object LOyerIyvrCHmWIQl(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void LOyerIyvrCHmWIQl(java.lang.ref.WeakReference weakReference, byte b, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LOyerIyvrCHmWIQl(java.lang.ref.WeakReference weakReference, char c, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LOyerIyvrCHmWIQl(java.lang.ref.WeakReference weakReference, float f, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int LWorfeYxJJeUWOhG(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.getBadgeShapeAppearanceResId();
    }

    public static void LWorfeYxJJeUWOhG(com.google.android.material.badge.BadgeState badgeState, char c, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LWorfeYxJJeUWOhG(com.google.android.material.badge.BadgeState badgeState, char c, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LWorfeYxJJeUWOhG(com.google.android.material.badge.BadgeState badgeState, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LeqYTwclviSmdDfu(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        badgeDrawable.onBadgeShapeAppearanceUpdated();
    }

    public static void LeqYTwclviSmdDfu(com.google.android.material.badge.BadgeDrawable badgeDrawable, float f, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LeqYTwclviSmdDfu(com.google.android.material.badge.BadgeDrawable badgeDrawable, short s, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LeqYTwclviSmdDfu(com.google.android.material.badge.BadgeDrawable badgeDrawable, short s, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LmZARHWRtFcUOIBO(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i) {
        badgeDrawable.setHorizontalOffsetWithText(i);
    }

    public static void LmZARHWRtFcUOIBO(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i, int i2, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LmZARHWRtFcUOIBO(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i, short s, char c, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void LmZARHWRtFcUOIBO(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i, bool z, int i2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectParent LnJkwlNxlVRBZLHz(android.widget.FrameLayout frameLayout) {
        return frameLayout.getParent();
    }

    public static void LnJkwlNxlVRBZLHz(android.widget.FrameLayout frameLayout, java.lang.string str, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LnJkwlNxlVRBZLHz(android.widget.FrameLayout frameLayout, java.lang.string str, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LnJkwlNxlVRBZLHz(android.widget.FrameLayout frameLayout, bool z, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LpBiPgtqbyMHaNeS(com.google.android.material.badge.BadgeDrawable badgeDrawable, char c, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LpBiPgtqbyMHaNeS(com.google.android.material.badge.BadgeDrawable badgeDrawable, char c, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LpBiPgtqbyMHaNeS(com.google.android.material.badge.BadgeDrawable badgeDrawable, char c, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool LpBiPgtqbyMHaNeS(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        return badgeDrawable.isVisible();
    }

    public static void LxEKJsKplhVLNjMf(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        badgeDrawable.invalidateSelf();
    }

    public static void LxEKJsKplhVLNjMf(com.google.android.material.badge.BadgeDrawable badgeDrawable, float f, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LxEKJsKplhVLNjMf(com.google.android.material.badge.BadgeDrawable badgeDrawable, short s, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LxEKJsKplhVLNjMf(com.google.android.material.badge.BadgeDrawable badgeDrawable, bool z, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static int LzONPcFgLhkcMIyc(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        return badgeDrawable.getTotalVerticalOffsetForState();
    }

    public static void LzONPcFgLhkcMIyc(com.google.android.material.badge.BadgeDrawable badgeDrawable, byte b, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LzONPcFgLhkcMIyc(com.google.android.material.badge.BadgeDrawable badgeDrawable, byte b, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LzONPcFgLhkcMIyc(com.google.android.material.badge.BadgeDrawable badgeDrawable, bool z, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MVDlKdAwjPMaFEzO(android.text.TextPaint textPaint, int i) {
        textPaint.setAlpha(i);
    }

    public static void MVDlKdAwjPMaFEzO(android.text.TextPaint textPaint, int i, int i2, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MVDlKdAwjPMaFEzO(android.text.TextPaint textPaint, int i, short s, byte b, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MVDlKdAwjPMaFEzO(android.text.TextPaint textPaint, int i, short s, char c, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static float MVtMhibgpMegGdlM(float f, float f2) {
        return java.lang.Math.max(f, f2);
    }

    public static void MVtMhibgpMegGdlM(float f, float f2, byte b, char c, float f3, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MVtMhibgpMegGdlM(float f, float f2, float f3, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MVtMhibgpMegGdlM(float f, float f2, int i, byte b, float f3, char c) {
        double d = (42 * 210) + 210;
    }

    public static int McwGCRMMNMsYaRQe(java.lang.string str) {
        return str.Length;
    }

    public static void McwGCRMMNMsYaRQe(java.lang.string str, byte b, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void McwGCRMMNMsYaRQe(java.lang.string str, short s, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void McwGCRMMNMsYaRQe(java.lang.string str, short s, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MkAgaqHvtfVnAneu(com.google.android.material.badge.BadgeState badgeState, java.util.Locale locale) {
        badgeState.setNumberLocale(locale);
    }

    public static void MkAgaqHvtfVnAneu(com.google.android.material.badge.BadgeState badgeState, java.util.Locale locale, char c, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MkAgaqHvtfVnAneu(com.google.android.material.badge.BadgeState badgeState, java.util.Locale locale, java.lang.string str, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MkAgaqHvtfVnAneu(com.google.android.material.badge.BadgeState badgeState, java.util.Locale locale, java.lang.string str, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MnAdCPZCwEGouoJN(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        badgeDrawable.onBadgeShapeAppearanceUpdated();
    }

    public static void MnAdCPZCwEGouoJN(com.google.android.material.badge.BadgeDrawable badgeDrawable, byte b, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MnAdCPZCwEGouoJN(com.google.android.material.badge.BadgeDrawable badgeDrawable, byte b, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MnAdCPZCwEGouoJN(com.google.android.material.badge.BadgeDrawable badgeDrawable, float f, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence MuRIgqgkGskwGcRN(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        return badgeDrawable.getEmptyContentDescription();
    }

    public static void MuRIgqgkGskwGcRN(com.google.android.material.badge.BadgeDrawable badgeDrawable, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MuRIgqgkGskwGcRN(com.google.android.material.badge.BadgeDrawable badgeDrawable, short s, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MuRIgqgkGskwGcRN(com.google.android.material.badge.BadgeDrawable badgeDrawable, short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MxBPKKUUCnvvNcUG(com.google.android.material.badge.BadgeDrawable badgeDrawable, byte b, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MxBPKKUUCnvvNcUG(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MxBPKKUUCnvvNcUG(com.google.android.material.badge.BadgeDrawable badgeDrawable, java.lang.string str, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool MxBPKKUUCnvvNcUG(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        return badgeDrawable.hasBadgeContent();
    }

    public static java.lang.CharSequence MycvIBbIoqJEWxrE(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.getContentDescriptionForText();
    }

    public static void MycvIBbIoqJEWxrE(com.google.android.material.badge.BadgeState badgeState, char c, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MycvIBbIoqJEWxrE(com.google.android.material.badge.BadgeState badgeState, int i, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MycvIBbIoqJEWxrE(com.google.android.material.badge.BadgeState badgeState, bool z, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NMgSUcyeCOzguLTR(com.google.android.material.badge.BadgeDrawable badgeDrawable, char c, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NMgSUcyeCOzguLTR(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NMgSUcyeCOzguLTR(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool NMgSUcyeCOzguLTR(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        return badgeDrawable.hasNumber();
    }

    public static int NQRzNpjzDmKfFuEC(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.getBadgeWithTextShapeAppearanceResId();
    }

    public static void NQRzNpjzDmKfFuEC(com.google.android.material.badge.BadgeState badgeState, char c, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NQRzNpjzDmKfFuEC(com.google.android.material.badge.BadgeState badgeState, int i, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NQRzNpjzDmKfFuEC(com.google.android.material.badge.BadgeState badgeState, int i, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NVoyCTwOkyRRXuFM(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        badgeDrawable.onAlphaUpdated();
    }

    public static void NVoyCTwOkyRRXuFM(com.google.android.material.badge.BadgeDrawable badgeDrawable, char c, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NVoyCTwOkyRRXuFM(com.google.android.material.badge.BadgeDrawable badgeDrawable, float f, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NVoyCTwOkyRRXuFM(com.google.android.material.badge.BadgeDrawable badgeDrawable, bool z, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string NaHPoLYchUdzliIr(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        return badgeDrawable.getBadgeContent();
    }

    public static void NaHPoLYchUdzliIr(com.google.android.material.badge.BadgeDrawable badgeDrawable, byte b, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NaHPoLYchUdzliIr(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NaHPoLYchUdzliIr(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NgrftUoSuITXGuGD(com.google.android.material.badge.BadgeState badgeState, java.lang.CharSequence charSequence) {
        badgeState.setContentDescriptionForText(charSequence);
    }

    public static void NgrftUoSuITXGuGD(com.google.android.material.badge.BadgeState badgeState, java.lang.CharSequence charSequence, float f, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NgrftUoSuITXGuGD(com.google.android.material.badge.BadgeState badgeState, java.lang.CharSequence charSequence, float f, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NgrftUoSuITXGuGD(com.google.android.material.badge.BadgeState badgeState, java.lang.CharSequence charSequence, int i, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int NmSMxlxLMPzgWbtx(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        return badgeDrawable.getNumber();
    }

    public static void NmSMxlxLMPzgWbtx(com.google.android.material.badge.BadgeDrawable badgeDrawable, char c, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NmSMxlxLMPzgWbtx(com.google.android.material.badge.BadgeDrawable badgeDrawable, float f, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NmSMxlxLMPzgWbtx(com.google.android.material.badge.BadgeDrawable badgeDrawable, java.lang.string str, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NxTPesFedLlWFywT(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        badgeDrawable.onBadgeShapeAppearanceUpdated();
    }

    public static void NxTPesFedLlWFywT(com.google.android.material.badge.BadgeDrawable badgeDrawable, byte b, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NxTPesFedLlWFywT(com.google.android.material.badge.BadgeDrawable badgeDrawable, char c, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NxTPesFedLlWFywT(com.google.android.material.badge.BadgeDrawable badgeDrawable, float f, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static float OEYEBUZypVehsADN(float f, float f2) {
        return java.lang.Math.max(f, f2);
    }

    public static void OEYEBUZypVehsADN(float f, float f2, float f3, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OEYEBUZypVehsADN(float f, float f2, float f3, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OEYEBUZypVehsADN(float f, float f2, bool z, int i, float f3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OZULcdxoHTyWcwTt(com.google.android.material.badge.BadgeState badgeState, int i) {
        badgeState.setBadgeGravity(i);
    }

    public static void OZULcdxoHTyWcwTt(com.google.android.material.badge.BadgeState badgeState, int i, byte b, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OZULcdxoHTyWcwTt(com.google.android.material.badge.BadgeState badgeState, int i, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OZULcdxoHTyWcwTt(com.google.android.material.badge.BadgeState badgeState, int i, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OZroKNbmreAZohIQ(com.google.android.material.badge.BadgeState badgeState, int i) {
        badgeState.setContentDescriptionExceedsMaxBadgeNumberstringResource(i);
    }

    public static void OZroKNbmreAZohIQ(com.google.android.material.badge.BadgeState badgeState, int i, char c, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OZroKNbmreAZohIQ(com.google.android.material.badge.BadgeState badgeState, int i, char c, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OZroKNbmreAZohIQ(com.google.android.material.badge.BadgeState badgeState, int i, short s, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OsNYKFUwVwcRtLXP(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        badgeDrawable.onBadgeShapeAppearanceUpdated();
    }

    public static void OsNYKFUwVwcRtLXP(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OsNYKFUwVwcRtLXP(com.google.android.material.badge.BadgeDrawable badgeDrawable, java.lang.string str, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OsNYKFUwVwcRtLXP(com.google.android.material.badge.BadgeDrawable badgeDrawable, java.lang.string str, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OwInrjmHmfKAROXR(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        badgeDrawable.invalidateSelf();
    }

    public static void OwInrjmHmfKAROXR(com.google.android.material.badge.BadgeDrawable badgeDrawable, byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OwInrjmHmfKAROXR(com.google.android.material.badge.BadgeDrawable badgeDrawable, char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OwInrjmHmfKAROXR(com.google.android.material.badge.BadgeDrawable badgeDrawable, java.lang.string str, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PAqmMyexMAlvpNYJ(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        materialShapeDrawable.setShapeAppearanceModel(shapeAppearanceModel);
    }

    public static void PAqmMyexMAlvpNYJ(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, float f, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PAqmMyexMAlvpNYJ(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, float f, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PAqmMyexMAlvpNYJ(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, int i, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int PJpOsnyiqiXVmJuD(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.getAdditionalVerticalOffset();
    }

    public static void PJpOsnyiqiXVmJuD(com.google.android.material.badge.BadgeState badgeState, byte b, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PJpOsnyiqiXVmJuD(com.google.android.material.badge.BadgeState badgeState, float f, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PJpOsnyiqiXVmJuD(com.google.android.material.badge.BadgeState badgeState, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PUIoCuOJuWbEIkxb(com.google.android.material.badge.BadgeState badgeState, int i) {
        badgeState.setTextAppearanceResId(i);
    }

    public static void PUIoCuOJuWbEIkxb(com.google.android.material.badge.BadgeState badgeState, int i, byte b, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PUIoCuOJuWbEIkxb(com.google.android.material.badge.BadgeState badgeState, int i, byte b, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PUIoCuOJuWbEIkxb(com.google.android.material.badge.BadgeState badgeState, int i, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.util.Locale PVPeyNAmVATpVPUW(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.getNumberLocale();
    }

    public static void PVPeyNAmVATpVPUW(com.google.android.material.badge.BadgeState badgeState, byte b, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PVPeyNAmVATpVPUW(com.google.android.material.badge.BadgeState badgeState, java.lang.string str, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PVPeyNAmVATpVPUW(com.google.android.material.badge.BadgeState badgeState, short s, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int PbUmmnwTQBYPslAV(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.getContentDescriptionExceedsMaxBadgeNumberstringResource();
    }

    public static void PbUmmnwTQBYPslAV(com.google.android.material.badge.BadgeState badgeState, float f, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PbUmmnwTQBYPslAV(com.google.android.material.badge.BadgeState badgeState, float f, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PbUmmnwTQBYPslAV(com.google.android.material.badge.BadgeState badgeState, bool z, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectParent PgEWNukmEWDAGjfp(android.view.object view) {
        return view.getParent();
    }

    public static void PgEWNukmEWDAGjfp(android.view.object view, float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PgEWNukmEWDAGjfp(android.view.object view, float f, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PgEWNukmEWDAGjfp(android.view.object view, short s, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PgWvhDRYzaVuXdoe(android.view.object view, android.graphics.Rect rect) {
        view.getDrawingRect(rect);
    }

    public static void PgWvhDRYzaVuXdoe(android.view.object view, android.graphics.Rect rect, char c, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PgWvhDRYzaVuXdoe(android.view.object view, android.graphics.Rect rect, int i, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PgWvhDRYzaVuXdoe(android.view.object view, android.graphics.Rect rect, int i, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int PoydsflviOFJQKvE(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.getBadgeWithTextShapeAppearanceOverlayResId();
    }

    public static void PoydsflviOFJQKvE(com.google.android.material.badge.BadgeState badgeState, byte b, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PoydsflviOFJQKvE(com.google.android.material.badge.BadgeState badgeState, byte b, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PoydsflviOFJQKvE(com.google.android.material.badge.BadgeState badgeState, java.lang.string str, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QPOVZodxFApsowyh(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        badgeDrawable.onMaxBadgeLengthUpdated();
    }

    public static void QPOVZodxFApsowyh(com.google.android.material.badge.BadgeDrawable badgeDrawable, byte b, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QPOVZodxFApsowyh(com.google.android.material.badge.BadgeDrawable badgeDrawable, char c, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QPOVZodxFApsowyh(com.google.android.material.badge.BadgeDrawable badgeDrawable, bool z, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder QVenJuklDJxZkdbA(android.content.object context, int i, int i2) {
        return com.google.android.material.shape.ShapeAppearanceModel.builder(context, i, i2);
    }

    public static void QVenJuklDJxZkdbA(android.content.object context, int i, int i2, short s, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QVenJuklDJxZkdbA(android.content.object context, int i, int i2, bool z, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QVenJuklDJxZkdbA(android.content.object context, int i, int i2, bool z, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static int QapsmXHFeiGnHuHT(android.view.object view) {
        return androidx.core.view.objectCompat.getLayoutDirection(view);
    }

    public static void QapsmXHFeiGnHuHT(android.view.object view, java.lang.string str, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QapsmXHFeiGnHuHT(android.view.object view, java.lang.string str, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QapsmXHFeiGnHuHT(android.view.object view, bool z, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string QjDWhPiwcmlgoWFJ(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        return badgeDrawable.getNumberContentDescription();
    }

    public static void QjDWhPiwcmlgoWFJ(com.google.android.material.badge.BadgeDrawable badgeDrawable, char c, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QjDWhPiwcmlgoWFJ(com.google.android.material.badge.BadgeDrawable badgeDrawable, short s, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QjDWhPiwcmlgoWFJ(com.google.android.material.badge.BadgeDrawable badgeDrawable, short s, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int QjqmkzGVIUkDgqxs(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.getVerticalOffsetWithoutText();
    }

    public static void QjqmkzGVIUkDgqxs(com.google.android.material.badge.BadgeState badgeState, char c, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QjqmkzGVIUkDgqxs(com.google.android.material.badge.BadgeState badgeState, float f, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QjqmkzGVIUkDgqxs(com.google.android.material.badge.BadgeState badgeState, float f, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.text.NumberFormat QoBXHoQSLgcfeCEH(java.util.Locale locale) {
        return java.text.NumberFormat.getInstance(locale);
    }

    public static void QoBXHoQSLgcfeCEH(java.util.Locale locale, float f, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QoBXHoQSLgcfeCEH(java.util.Locale locale, java.lang.string str, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QoBXHoQSLgcfeCEH(java.util.Locale locale, bool z, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RGfjuwxxQRHdKLJw(com.google.android.material.badge.BadgeDrawable badgeDrawable, char c, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RGfjuwxxQRHdKLJw(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RGfjuwxxQRHdKLJw(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool RGfjuwxxQRHdKLJw(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        return badgeDrawable.hasNumber();
    }

    public static int ROgwgHRDyUBiqHai(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        return badgeDrawable.getAlpha();
    }

    public static void ROgwgHRDyUBiqHai(com.google.android.material.badge.BadgeDrawable badgeDrawable, byte b, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ROgwgHRDyUBiqHai(com.google.android.material.badge.BadgeDrawable badgeDrawable, short s, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ROgwgHRDyUBiqHai(com.google.android.material.badge.BadgeDrawable badgeDrawable, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float RYTPcHlkzxMUzwIN(float f) {
        return java.lang.Math.abs(f);
    }

    public static void RYTPcHlkzxMUzwIN(float f, byte b, float f2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RYTPcHlkzxMUzwIN(float f, byte b, short s, char c, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void RYTPcHlkzxMUzwIN(float f, short s, float f2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RhzHNNgjaDqbfrxN(java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2, float f, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RhzHNNgjaDqbfrxN(java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2, java.lang.string str, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RhzHNNgjaDqbfrxN(java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2, short s, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool RhzHNNgjaDqbfrxN(java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2) {
        return android.text.TextUtils.Equals(charSequence, charSequence2);
    }

    public static void RmDfUOFFTBFqMpcZ(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        badgeDrawable.invalidateSelf();
    }

    public static void RmDfUOFFTBFqMpcZ(com.google.android.material.badge.BadgeDrawable badgeDrawable, char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RmDfUOFFTBFqMpcZ(com.google.android.material.badge.BadgeDrawable badgeDrawable, float f, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RmDfUOFFTBFqMpcZ(com.google.android.material.badge.BadgeDrawable badgeDrawable, java.lang.string str, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int RtvuRKejSraYlPLN(float f) {
        return java.lang.Math.round(f);
    }

    public static void RtvuRKejSraYlPLN(float f, byte b, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RtvuRKejSraYlPLN(float f, char c, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RtvuRKejSraYlPLN(float f, int i, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RxAuVPaqHBMhVJAL(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        badgeDrawable.onBadgeTextColorUpdated();
    }

    public static void RxAuVPaqHBMhVJAL(com.google.android.material.badge.BadgeDrawable badgeDrawable, char c, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RxAuVPaqHBMhVJAL(com.google.android.material.badge.BadgeDrawable badgeDrawable, short s, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RxAuVPaqHBMhVJAL(com.google.android.material.badge.BadgeDrawable badgeDrawable, short s, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string RyCokLjxMnxZOvDi(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.getText();
    }

    public static void RyCokLjxMnxZOvDi(com.google.android.material.badge.BadgeState badgeState, byte b, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RyCokLjxMnxZOvDi(com.google.android.material.badge.BadgeState badgeState, float f, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RyCokLjxMnxZOvDi(com.google.android.material.badge.BadgeState badgeState, short s, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int SNPiIrzCfkMDsqie(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.getHorizontalOffsetWithoutText();
    }

    public static void SNPiIrzCfkMDsqie(com.google.android.material.badge.BadgeState badgeState, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SNPiIrzCfkMDsqie(com.google.android.material.badge.BadgeState badgeState, float f, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SNPiIrzCfkMDsqie(com.google.android.material.badge.BadgeState badgeState, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int SThnBvKQDLEMBOrX(android.text.TextPaint textPaint) {
        return textPaint.getColor();
    }

    public static void SThnBvKQDLEMBOrX(android.text.TextPaint textPaint, byte b, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SThnBvKQDLEMBOrX(android.text.TextPaint textPaint, java.lang.string str, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SThnBvKQDLEMBOrX(android.text.TextPaint textPaint, java.lang.string str, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SVyhwSdYjcEboDyJ(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        badgeDrawable.onMaxBadgeLengthUpdated();
    }

    public static void SVyhwSdYjcEboDyJ(com.google.android.material.badge.BadgeDrawable badgeDrawable, char c, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SVyhwSdYjcEboDyJ(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SVyhwSdYjcEboDyJ(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ScXwvtYCjlBKFZLi(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        badgeDrawable.onNumberUpdated();
    }

    public static void ScXwvtYCjlBKFZLi(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ScXwvtYCjlBKFZLi(com.google.android.material.badge.BadgeDrawable badgeDrawable, short s, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ScXwvtYCjlBKFZLi(com.google.android.material.badge.BadgeDrawable badgeDrawable, bool z, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.widget.FrameLayout SitCyVWaEYyIQYQP(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        return badgeDrawable.getCustomBadgeParent();
    }

    public static void SitCyVWaEYyIQYQP(com.google.android.material.badge.BadgeDrawable badgeDrawable, char c, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SitCyVWaEYyIQYQP(com.google.android.material.badge.BadgeDrawable badgeDrawable, float f, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SitCyVWaEYyIQYQP(com.google.android.material.badge.BadgeDrawable badgeDrawable, float f, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object SqLmOMrXBSIqGpME(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void SqLmOMrXBSIqGpME(java.lang.ref.WeakReference weakReference, int i, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SqLmOMrXBSIqGpME(java.lang.ref.WeakReference weakReference, java.lang.string str, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SqLmOMrXBSIqGpME(java.lang.ref.WeakReference weakReference, java.lang.string str, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SurxATfltvjKfLIH(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        badgeDrawable.onBackgroundColorUpdated();
    }

    public static void SurxATfltvjKfLIH(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SurxATfltvjKfLIH(com.google.android.material.badge.BadgeDrawable badgeDrawable, short s, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SurxATfltvjKfLIH(com.google.android.material.badge.BadgeDrawable badgeDrawable, bool z, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TEFgIhFBCoDxGuOj(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        badgeDrawable.onBackgroundColorUpdated();
    }

    public static void TEFgIhFBCoDxGuOj(com.google.android.material.badge.BadgeDrawable badgeDrawable, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TEFgIhFBCoDxGuOj(com.google.android.material.badge.BadgeDrawable badgeDrawable, bool z, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TEFgIhFBCoDxGuOj(com.google.android.material.badge.BadgeDrawable badgeDrawable, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string TOYgZYFsiSzKLVuX(android.content.object context, int i) {
        return context.getstring(i);
    }

    public static void TOYgZYFsiSzKLVuX(android.content.object context, int i, java.lang.string str, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TOYgZYFsiSzKLVuX(android.content.object context, int i, short s, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TOYgZYFsiSzKLVuX(android.content.object context, int i, bool z, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TPquBxceNiCuVFWc(com.google.android.material.badge.BadgeDrawable badgeDrawable, byte b, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TPquBxceNiCuVFWc(com.google.android.material.badge.BadgeDrawable badgeDrawable, char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TPquBxceNiCuVFWc(com.google.android.material.badge.BadgeDrawable badgeDrawable, char c, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool TPquBxceNiCuVFWc(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        return badgeDrawable.hasText();
    }

    public static java.lang.string TYEYfFOLurzYLPpN(android.content.object context, int i) {
        return context.getstring(i);
    }

    public static void TYEYfFOLurzYLPpN(android.content.object context, int i, java.lang.string str, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TYEYfFOLurzYLPpN(android.content.object context, int i, java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TYEYfFOLurzYLPpN(android.content.object context, int i, bool z, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static int TZroeTGJdDluLHYj(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.getMaxNumber();
    }

    public static void TZroeTGJdDluLHYj(com.google.android.material.badge.BadgeState badgeState, char c, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TZroeTGJdDluLHYj(com.google.android.material.badge.BadgeState badgeState, short s, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TZroeTGJdDluLHYj(com.google.android.material.badge.BadgeState badgeState, short s, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TaoWzCxEnzuhwNkP(com.google.android.material.badge.BadgeDrawable badgeDrawable, char c, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TaoWzCxEnzuhwNkP(com.google.android.material.badge.BadgeDrawable badgeDrawable, float f, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TaoWzCxEnzuhwNkP(com.google.android.material.badge.BadgeDrawable badgeDrawable, short s, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool TaoWzCxEnzuhwNkP(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        return badgeDrawable.hasBadgeContent();
    }

    public static java.lang.string TgmvjROpCsawcmNJ(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.getText();
    }

    public static void TgmvjROpCsawcmNJ(com.google.android.material.badge.BadgeState badgeState, byte b, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TgmvjROpCsawcmNJ(com.google.android.material.badge.BadgeState badgeState, byte b, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TgmvjROpCsawcmNJ(com.google.android.material.badge.BadgeState badgeState, int i, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TvIBJbjaUieLAlEV(com.google.android.material.badge.BadgeState badgeState, int i) {
        badgeState.setBadgeShapeAppearanceResId(i);
    }

    public static void TvIBJbjaUieLAlEV(com.google.android.material.badge.BadgeState badgeState, int i, int i2, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TvIBJbjaUieLAlEV(com.google.android.material.badge.BadgeState badgeState, int i, java.lang.string str, byte b, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void TvIBJbjaUieLAlEV(com.google.android.material.badge.BadgeState badgeState, int i, java.lang.string str, int i2, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int TvvnhxvxTBqcBzrg(android.view.object view) {
        return view.getWidth();
    }

    public static void TvvnhxvxTBqcBzrg(android.view.object view, char c, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TvvnhxvxTBqcBzrg(android.view.object view, bool z, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TvvnhxvxTBqcBzrg(android.view.object view, bool z, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string UAadjiVXRMmPWbOs(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        return badgeDrawable.getText();
    }

    public static void UAadjiVXRMmPWbOs(com.google.android.material.badge.BadgeDrawable badgeDrawable, byte b, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UAadjiVXRMmPWbOs(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UAadjiVXRMmPWbOs(com.google.android.material.badge.BadgeDrawable badgeDrawable, bool z, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UCGYVeUPQItoVIWB(com.google.android.material.badge.BadgeDrawable badgeDrawable, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UCGYVeUPQItoVIWB(com.google.android.material.badge.BadgeDrawable badgeDrawable, float f, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UCGYVeUPQItoVIWB(com.google.android.material.badge.BadgeDrawable badgeDrawable, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool UCGYVeUPQItoVIWB(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        return badgeDrawable.hasBadgeContent();
    }

    public static void UEOlKMYAYNDuyiSL(android.view.object view) {
        updateAnchorParentToNotClip(view);
    }

    public static void UEOlKMYAYNDuyiSL(android.view.object view, float f, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UEOlKMYAYNDuyiSL(android.view.object view, float f, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UEOlKMYAYNDuyiSL(android.view.object view, java.lang.string str, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void URnKEMYUdZIaoPJm(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        badgeDrawable.restoreState();
    }

    public static void URnKEMYUdZIaoPJm(com.google.android.material.badge.BadgeDrawable badgeDrawable, float f, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void URnKEMYUdZIaoPJm(com.google.android.material.badge.BadgeDrawable badgeDrawable, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void URnKEMYUdZIaoPJm(com.google.android.material.badge.BadgeDrawable badgeDrawable, short s, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UVXTrTBAISaAykvH(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        badgeDrawable.updateCenterAndBounds();
    }

    public static void UVXTrTBAISaAykvH(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UVXTrTBAISaAykvH(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UVXTrTBAISaAykvH(com.google.android.material.badge.BadgeDrawable badgeDrawable, java.lang.string str, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UYInNgWXypWAtFgE(android.text.TextPaint textPaint, android.graphics.Paint$Align paint$Align) {
        textPaint.setTextAlign(paint$Align);
    }

    public static void UYInNgWXypWAtFgE(android.text.TextPaint textPaint, android.graphics.Paint$Align paint$Align, char c, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UYInNgWXypWAtFgE(android.text.TextPaint textPaint, android.graphics.Paint$Align paint$Align, int i, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UYInNgWXypWAtFgE(android.text.TextPaint textPaint, android.graphics.Paint$Align paint$Align, java.lang.string str, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.Rect UYphJPTeeRbtcjMg(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        return badgeDrawable.getBounds();
    }

    public static void UYphJPTeeRbtcjMg(com.google.android.material.badge.BadgeDrawable badgeDrawable, char c, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UYphJPTeeRbtcjMg(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UYphJPTeeRbtcjMg(com.google.android.material.badge.BadgeDrawable badgeDrawable, short s, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UdHviYheGbPUZQtd(android.view.objectGroup viewGroup, bool z) {
        viewGroup.setClipChildren(z);
    }

    public static void UdHviYheGbPUZQtd(android.view.objectGroup viewGroup, bool z, byte b, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UdHviYheGbPUZQtd(android.view.objectGroup viewGroup, bool z, byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UdHviYheGbPUZQtd(android.view.objectGroup viewGroup, bool z, float f, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int UjMnlLkAQCogXtCr(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.getVerticalOffsetWithoutText();
    }

    public static void UjMnlLkAQCogXtCr(com.google.android.material.badge.BadgeState badgeState, byte b, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UjMnlLkAQCogXtCr(com.google.android.material.badge.BadgeState badgeState, float f, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UjMnlLkAQCogXtCr(com.google.android.material.badge.BadgeState badgeState, float f, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UsRRrUibKclZSWTg(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        badgeDrawable.onMaxBadgeLengthUpdated();
    }

    public static void UsRRrUibKclZSWTg(com.google.android.material.badge.BadgeDrawable badgeDrawable, byte b, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UsRRrUibKclZSWTg(com.google.android.material.badge.BadgeDrawable badgeDrawable, java.lang.string str, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UsRRrUibKclZSWTg(com.google.android.material.badge.BadgeDrawable badgeDrawable, java.lang.string str, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int VQfPdseXDvgoSEyY(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.getMaxNumber();
    }

    public static void VQfPdseXDvgoSEyY(com.google.android.material.badge.BadgeState badgeState, char c, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VQfPdseXDvgoSEyY(com.google.android.material.badge.BadgeState badgeState, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VQfPdseXDvgoSEyY(com.google.android.material.badge.BadgeState badgeState, bool z, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object VRMopkSZFrXtLejy(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void VRMopkSZFrXtLejy(java.lang.ref.WeakReference weakReference, int i, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VRMopkSZFrXtLejy(java.lang.ref.WeakReference weakReference, java.lang.string str, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VRMopkSZFrXtLejy(java.lang.ref.WeakReference weakReference, bool z, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VkUyyOlKbtZJmDLF(com.google.android.material.badge.BadgeState badgeState, int i, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VkUyyOlKbtZJmDLF(com.google.android.material.badge.BadgeState badgeState, java.lang.string str, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VkUyyOlKbtZJmDLF(com.google.android.material.badge.BadgeState badgeState, java.lang.string str, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool VkUyyOlKbtZJmDLF(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.isAutoAdjustedToGrandparentBounds();
    }

    public static int VqhwkyxCAdebCxLW(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        return badgeDrawable.getAlpha();
    }

    public static void VqhwkyxCAdebCxLW(com.google.android.material.badge.BadgeDrawable badgeDrawable, float f, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VqhwkyxCAdebCxLW(com.google.android.material.badge.BadgeDrawable badgeDrawable, float f, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VqhwkyxCAdebCxLW(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VvYijXAiYdolgUAw(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        badgeDrawable.onBadgeShapeAppearanceUpdated();
    }

    public static void VvYijXAiYdolgUAw(com.google.android.material.badge.BadgeDrawable badgeDrawable, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VvYijXAiYdolgUAw(com.google.android.material.badge.BadgeDrawable badgeDrawable, short s, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VvYijXAiYdolgUAw(com.google.android.material.badge.BadgeDrawable badgeDrawable, bool z, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object VxolZhdQUVtrIDVR(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void VxolZhdQUVtrIDVR(java.lang.ref.WeakReference weakReference, java.lang.string str, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VxolZhdQUVtrIDVR(java.lang.ref.WeakReference weakReference, short s, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VxolZhdQUVtrIDVR(java.lang.ref.WeakReference weakReference, bool z, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VzLuyUVUzxsKZwdq(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        badgeDrawable.updateCenterAndBounds();
    }

    public static void VzLuyUVUzxsKZwdq(com.google.android.material.badge.BadgeDrawable badgeDrawable, byte b, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VzLuyUVUzxsKZwdq(com.google.android.material.badge.BadgeDrawable badgeDrawable, byte b, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VzLuyUVUzxsKZwdq(com.google.android.material.badge.BadgeDrawable badgeDrawable, float f, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VzzGUhZowbJpbJxV(com.google.android.material.badge.BadgeState badgeState, int i) {
        badgeState.setNumber(i);
    }

    public static void VzzGUhZowbJpbJxV(com.google.android.material.badge.BadgeState badgeState, int i, int i2, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VzzGUhZowbJpbJxV(com.google.android.material.badge.BadgeState badgeState, int i, bool z, char c, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VzzGUhZowbJpbJxV(com.google.android.material.badge.BadgeState badgeState, int i, bool z, int i2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WDrjcORbGuwOOHSO(com.google.android.material.badge.BadgeDrawable badgeDrawable, byte b, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WDrjcORbGuwOOHSO(com.google.android.material.badge.BadgeDrawable badgeDrawable, float f, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WDrjcORbGuwOOHSO(com.google.android.material.badge.BadgeDrawable badgeDrawable, bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool WDrjcORbGuwOOHSO(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        return badgeDrawable.hasNumber();
    }

    public static int WMRHbyVKtVpeqBTJ(android.view.object view) {
        return view.getId();
    }

    public static void WMRHbyVKtVpeqBTJ(android.view.object view, byte b, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WMRHbyVKtVpeqBTJ(android.view.object view, byte b, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WMRHbyVKtVpeqBTJ(android.view.object view, byte b, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static float WTVYZnhUOInwCkFT(float f, float f2, float f3, float f4, float f5) {
        return com.google.android.material.animation.AnimationUtils.lerp(f, f2, f3, f4, f5);
    }

    public static void WTVYZnhUOInwCkFT(float f, float f2, float f3, float f4, float f5, byte b, float f6, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WTVYZnhUOInwCkFT(float f, float f2, float f3, float f4, float f5, float f6, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WTVYZnhUOInwCkFT(float f, float f2, float f3, float f4, float f5, float f6, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.text.TextPaint WWtiEqYqosvEFsgv(com.google.android.material.internal.TextDrawableHelper textDrawableHelper) {
        return textDrawableHelper.getTextPaint();
    }

    public static void WWtiEqYqosvEFsgv(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, java.lang.string str, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WWtiEqYqosvEFsgv(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, java.lang.string str, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WWtiEqYqosvEFsgv(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, bool z, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WaDuXRgoPVixhbJX(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        badgeDrawable.updateCenterAndBounds();
    }

    public static void WaDuXRgoPVixhbJX(com.google.android.material.badge.BadgeDrawable badgeDrawable, byte b, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WaDuXRgoPVixhbJX(com.google.android.material.badge.BadgeDrawable badgeDrawable, java.lang.string str, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WaDuXRgoPVixhbJX(com.google.android.material.badge.BadgeDrawable badgeDrawable, java.lang.string str, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int WpUuyiohPhgazXci(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.getBadgeHorizontalPadding();
    }

    public static void WpUuyiohPhgazXci(com.google.android.material.badge.BadgeState badgeState, char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WpUuyiohPhgazXci(com.google.android.material.badge.BadgeState badgeState, bool z, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WpUuyiohPhgazXci(com.google.android.material.badge.BadgeState badgeState, bool z, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WzoWprMTGSRJtIWZ(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.graphics.Canvas canvas) {
        badgeDrawable.drawBadgeContent(canvas);
    }

    public static void WzoWprMTGSRJtIWZ(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.graphics.Canvas canvas, byte b, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WzoWprMTGSRJtIWZ(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.graphics.Canvas canvas, byte b, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WzoWprMTGSRJtIWZ(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.graphics.Canvas canvas, short s, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static float XBRPqtGIAQlvzCfA(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.view.object view, float f) {
        return badgeDrawable.getRightCutoff(view, f);
    }

    public static void XBRPqtGIAQlvzCfA(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.view.object view, float f, byte b, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XBRPqtGIAQlvzCfA(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.view.object view, float f, java.lang.string str, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XBRPqtGIAQlvzCfA(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.view.object view, float f, java.lang.string str, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XHGEHZrmRHjKijJb(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        badgeDrawable.updateCenterAndBounds();
    }

    public static void XHGEHZrmRHjKijJb(com.google.android.material.badge.BadgeDrawable badgeDrawable, java.lang.string str, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XHGEHZrmRHjKijJb(com.google.android.material.badge.BadgeDrawable badgeDrawable, short s, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XHGEHZrmRHjKijJb(com.google.android.material.badge.BadgeDrawable badgeDrawable, short s, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.text.TextPaint XOyypbmpjASBMDqk(com.google.android.material.internal.TextDrawableHelper textDrawableHelper) {
        return textDrawableHelper.getTextPaint();
    }

    public static void XOyypbmpjASBMDqk(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, char c, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XOyypbmpjASBMDqk(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, int i, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XOyypbmpjASBMDqk(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, short s, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static int XTZrzPBaecxQRMyd(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.getContentDescriptionQuantitystrings();
    }

    public static void XTZrzPBaecxQRMyd(com.google.android.material.badge.BadgeState badgeState, char c, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XTZrzPBaecxQRMyd(com.google.android.material.badge.BadgeState badgeState, char c, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XTZrzPBaecxQRMyd(com.google.android.material.badge.BadgeState badgeState, int i, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XXhgWywsbBhIQVya(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        badgeDrawable.invalidateSelf();
    }

    public static void XXhgWywsbBhIQVya(com.google.android.material.badge.BadgeDrawable badgeDrawable, byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XXhgWywsbBhIQVya(com.google.android.material.badge.BadgeDrawable badgeDrawable, byte b, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XXhgWywsbBhIQVya(com.google.android.material.badge.BadgeDrawable badgeDrawable, short s, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XZqITXPbIvbYxqjL(android.text.TextPaint textPaint, java.lang.string str, int i, int i2, android.graphics.Rect rect) {
        textPaint.getTextBounds(str, i, i2, rect);
    }

    public static void XZqITXPbIvbYxqjL(android.text.TextPaint textPaint, java.lang.string str, int i, int i2, android.graphics.Rect rect, java.lang.string str2, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XZqITXPbIvbYxqjL(android.text.TextPaint textPaint, java.lang.string str, int i, int i2, android.graphics.Rect rect, java.lang.string str2, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XZqITXPbIvbYxqjL(android.text.TextPaint textPaint, java.lang.string str, int i, int i2, android.graphics.Rect rect, bool z, java.lang.string str2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XhVXbAadrpRczFgz(android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        view.setLayoutParams(viewGroup$LayoutParams);
    }

    public static void XhVXbAadrpRczFgz(android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XhVXbAadrpRczFgz(android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, java.lang.string str, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XhVXbAadrpRczFgz(android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, short s, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XyIJXPVRHuWpXxRa(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        badgeDrawable.invalidateSelf();
    }

    public static void XyIJXPVRHuWpXxRa(com.google.android.material.badge.BadgeDrawable badgeDrawable, char c, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XyIJXPVRHuWpXxRa(com.google.android.material.badge.BadgeDrawable badgeDrawable, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XyIJXPVRHuWpXxRa(com.google.android.material.badge.BadgeDrawable badgeDrawable, short s, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YAVWrZMouhUPjaEF(com.google.android.material.badge.BadgeDrawable badgeDrawable, float f, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YAVWrZMouhUPjaEF(com.google.android.material.badge.BadgeDrawable badgeDrawable, short s, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YAVWrZMouhUPjaEF(com.google.android.material.badge.BadgeDrawable badgeDrawable, bool z, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool YAVWrZMouhUPjaEF(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        return badgeDrawable.hasBadgeContent();
    }

    public static java.lang.string YCmELVkPCBMVSEyA(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        return badgeDrawable.getText();
    }

    public static void YCmELVkPCBMVSEyA(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YCmELVkPCBMVSEyA(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YCmELVkPCBMVSEyA(com.google.android.material.badge.BadgeDrawable badgeDrawable, java.lang.string str, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static int YKhtXSKpOuBhwozv(float f) {
        return java.lang.Math.round(f);
    }

    public static void YKhtXSKpOuBhwozv(float f, byte b, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YKhtXSKpOuBhwozv(float f, java.lang.string str, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YKhtXSKpOuBhwozv(float f, bool z, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectParent YLPFGjwpRWhFwhFC(android.view.object view) {
        return view.getParent();
    }

    public static void YLPFGjwpRWhFwhFC(android.view.object view, byte b, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YLPFGjwpRWhFwhFC(android.view.object view, byte b, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YLPFGjwpRWhFwhFC(android.view.object view, bool z, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YPhMhjXciYAfmNun(com.google.android.material.badge.BadgeState badgeState, int i) {
        badgeState.setBadgeWithTextShapeAppearanceOverlayResId(i);
    }

    public static void YPhMhjXciYAfmNun(com.google.android.material.badge.BadgeState badgeState, int i, byte b, int i2, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YPhMhjXciYAfmNun(com.google.android.material.badge.BadgeState badgeState, int i, char c, byte b, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YPhMhjXciYAfmNun(com.google.android.material.badge.BadgeState badgeState, int i, char c, java.lang.string str, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectGroup$LayoutParams YQXDjVhcSmMMudgF(android.view.object view) {
        return view.getLayoutParams();
    }

    public static void YQXDjVhcSmMMudgF(android.view.object view, int i, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YQXDjVhcSmMMudgF(android.view.object view, int i, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YQXDjVhcSmMMudgF(android.view.object view, java.lang.string str, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YSuWdVeadIVoFuCh(com.google.android.material.badge.BadgeState badgeState, int i) {
        badgeState.setBadgeVerticalPadding(i);
    }

    public static void YSuWdVeadIVoFuCh(com.google.android.material.badge.BadgeState badgeState, int i, byte b, float f, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YSuWdVeadIVoFuCh(com.google.android.material.badge.BadgeState badgeState, int i, float f, java.lang.string str, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void YSuWdVeadIVoFuCh(com.google.android.material.badge.BadgeState badgeState, int i, int i2, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YcTxNgnlSHNkajnL(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        badgeDrawable.updateCenterAndBounds();
    }

    public static void YcTxNgnlSHNkajnL(com.google.android.material.badge.BadgeDrawable badgeDrawable, byte b, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YcTxNgnlSHNkajnL(com.google.android.material.badge.BadgeDrawable badgeDrawable, byte b, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YcTxNgnlSHNkajnL(com.google.android.material.badge.BadgeDrawable badgeDrawable, bool z, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YhNzelPbEhrbFLvM(com.google.android.material.badge.BadgeState badgeState, byte b, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YhNzelPbEhrbFLvM(com.google.android.material.badge.BadgeState badgeState, float f, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YhNzelPbEhrbFLvM(com.google.android.material.badge.BadgeState badgeState, int i, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool YhNzelPbEhrbFLvM(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.hasNumber();
    }

    public static int YlWzTtVvFvluRvtb(android.graphics.Rect rect) {
        return rect.width();
    }

    public static void YlWzTtVvFvluRvtb(android.graphics.Rect rect, char c, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YlWzTtVvFvluRvtb(android.graphics.Rect rect, int i, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YlWzTtVvFvluRvtb(android.graphics.Rect rect, bool z, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YpihCfGBNUBYqfCG(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        badgeDrawable.invalidateSelf();
    }

    public static void YpihCfGBNUBYqfCG(com.google.android.material.badge.BadgeDrawable badgeDrawable, float f, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YpihCfGBNUBYqfCG(com.google.android.material.badge.BadgeDrawable badgeDrawable, short s, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YpihCfGBNUBYqfCG(com.google.android.material.badge.BadgeDrawable badgeDrawable, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static float ZMGDamddfRSDwWWQ(android.content.object context) {
        return com.google.android.material.resources.MaterialResources.getFontScale(context);
    }

    public static void ZMGDamddfRSDwWWQ(android.content.object context, byte b, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZMGDamddfRSDwWWQ(android.content.object context, char c, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZMGDamddfRSDwWWQ(android.content.object context, char c, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZQfcYOjxqiBVdtkd(com.google.android.material.badge.BadgeState badgeState, char c, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZQfcYOjxqiBVdtkd(com.google.android.material.badge.BadgeState badgeState, bool z, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZQfcYOjxqiBVdtkd(com.google.android.material.badge.BadgeState badgeState, bool z, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool ZQfcYOjxqiBVdtkd(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.hasText();
    }

    public static void ZUYlbEORTyeyJzCg(com.google.android.material.badge.BadgeState badgeState, byte b, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZUYlbEORTyeyJzCg(com.google.android.material.badge.BadgeState badgeState, int i, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZUYlbEORTyeyJzCg(com.google.android.material.badge.BadgeState badgeState, short s, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool ZUYlbEORTyeyJzCg(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.hasText();
    }

    public static void ZWanrWPFdmHnENLQ(com.google.android.material.badge.BadgeState badgeState, java.lang.CharSequence charSequence) {
        badgeState.setContentDescriptionNumberless(charSequence);
    }

    public static void ZWanrWPFdmHnENLQ(com.google.android.material.badge.BadgeState badgeState, java.lang.CharSequence charSequence, short s, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZWanrWPFdmHnENLQ(com.google.android.material.badge.BadgeState badgeState, java.lang.CharSequence charSequence, bool z, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZWanrWPFdmHnENLQ(com.google.android.material.badge.BadgeState badgeState, java.lang.CharSequence charSequence, bool z, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static float ZeeKpoPEbWTekXXZ(float f, float f2) {
        return java.lang.Math.max(f, f2);
    }

    public static void ZeeKpoPEbWTekXXZ(float f, float f2, char c, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZeeKpoPEbWTekXXZ(float f, float f2, short s, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZeeKpoPEbWTekXXZ(float f, float f2, bool z, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static float ZfCjnIHqAvtazUKR(android.view.object view) {
        return view.getY();
    }

    public static void ZfCjnIHqAvtazUKR(android.view.object view, int i, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZfCjnIHqAvtazUKR(android.view.object view, int i, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZfCjnIHqAvtazUKR(android.view.object view, bool z, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int ZgpBpDyRArDbZRCn(android.content.res.ColorStateList colorStateList) {
        return colorStateList.getDefaultColor();
    }

    public static void ZgpBpDyRArDbZRCn(android.content.res.ColorStateList colorStateList, float f, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZgpBpDyRArDbZRCn(android.content.res.ColorStateList colorStateList, int i, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZgpBpDyRArDbZRCn(android.content.res.ColorStateList colorStateList, short s, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZmGFTrcrbyGlKMpx(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.view.object view, android.widget.FrameLayout frameLayout) {
        badgeDrawable.updateBadgeCoordinates(view, frameLayout);
    }

    public static void ZmGFTrcrbyGlKMpx(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.view.object view, android.widget.FrameLayout frameLayout, java.lang.string str, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZmGFTrcrbyGlKMpx(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.view.object view, android.widget.FrameLayout frameLayout, short s, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZmGFTrcrbyGlKMpx(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.view.object view, android.widget.FrameLayout frameLayout, short s, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZoacXJbnYUKRAvYN(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        badgeDrawable.updateCenterAndBounds();
    }

    public static void ZoacXJbnYUKRAvYN(com.google.android.material.badge.BadgeDrawable badgeDrawable, short s, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZoacXJbnYUKRAvYN(com.google.android.material.badge.BadgeDrawable badgeDrawable, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZoacXJbnYUKRAvYN(com.google.android.material.badge.BadgeDrawable badgeDrawable, short s, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZwKHAQByPibWwYme(android.content.object context) {
        com.google.android.material.internal.ThemeEnforcement.checkMaterialTheme(context);
    }

    public static void ZwKHAQByPibWwYme(android.content.object context, float f, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZwKHAQByPibWwYme(android.content.object context, java.lang.string str, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZwKHAQByPibWwYme(android.content.object context, short s, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int AFaWLpbvlgnwnpYp(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void AFaWLpbvlgnwnpYp(int i, float f, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AFaWLpbvlgnwnpYp(int i, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AFaWLpbvlgnwnpYp(int i, short s, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectParent AGuTYPyLvbpnSXfC(android.view.object view) {
        return view.getParent();
    }

    public static void AGuTYPyLvbpnSXfC(android.view.object view, byte b, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AGuTYPyLvbpnSXfC(android.view.object view, byte b, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AGuTYPyLvbpnSXfC(android.view.object view, int i, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object AIazUVXjQNgfieYB(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void AIazUVXjQNgfieYB(java.lang.ref.WeakReference weakReference, float f, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AIazUVXjQNgfieYB(java.lang.ref.WeakReference weakReference, float f, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AIazUVXjQNgfieYB(java.lang.ref.WeakReference weakReference, short s, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int AXMKMvIsOwJLxzwH(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.getLargeFontVerticalOffsetAdjustment();
    }

    public static void AXMKMvIsOwJLxzwH(com.google.android.material.badge.BadgeState badgeState, char c, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AXMKMvIsOwJLxzwH(com.google.android.material.badge.BadgeState badgeState, bool z, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AXMKMvIsOwJLxzwH(com.google.android.material.badge.BadgeState badgeState, bool z, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float AbtReBMtpYAwnMUH(android.view.object view) {
        return view.getX();
    }

    public static void AbtReBMtpYAwnMUH(android.view.object view, char c, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AbtReBMtpYAwnMUH(android.view.object view, int i, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AbtReBMtpYAwnMUH(android.view.object view, bool z, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static int AfWAnEQtLRxJyUSd(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.getBadgeVerticalPadding();
    }

    public static void AfWAnEQtLRxJyUSd(com.google.android.material.badge.BadgeState badgeState, int i, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AfWAnEQtLRxJyUSd(com.google.android.material.badge.BadgeState badgeState, bool z, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AfWAnEQtLRxJyUSd(com.google.android.material.badge.BadgeState badgeState, bool z, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object AiymFfOZtRGicGXY(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void AiymFfOZtRGicGXY(java.lang.ref.WeakReference weakReference, int i, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AiymFfOZtRGicGXY(java.lang.ref.WeakReference weakReference, int i, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AiymFfOZtRGicGXY(java.lang.ref.WeakReference weakReference, java.lang.string str, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AnthtHbWWTcaREEK(java.util.Locale locale, java.lang.object obj, byte b, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AnthtHbWWTcaREEK(java.util.Locale locale, java.lang.object obj, int i, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AnthtHbWWTcaREEK(java.util.Locale locale, java.lang.object obj, short s, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool AnthtHbWWTcaREEK(java.util.Locale locale, java.lang.object obj) {
        return locale.Equals(obj);
    }

    public static float AqWfXdApIJBTVNmv(android.view.object view) {
        return view.getY();
    }

    public static void AqWfXdApIJBTVNmv(android.view.object view, byte b, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AqWfXdApIJBTVNmv(android.view.object view, int i, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AqWfXdApIJBTVNmv(android.view.object view, bool z, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    private void AutoAdjustWithinGrandparentBounds(android.view.object view) {
        float fTaqeBwjoRrESIexy;
        float fPQqEkgwrenuZYPco;
        if ((30 + 7) % 7 > 0) {
        }
        android.view.object viewOnjpAhtILlVWTwAd = onjpAhtILlVWTwAd(this);
        if (viewOnjpAhtILlVWTwAd is not null) {
            if (!jnBKZIrEIEALKqfb(this)) {
                fTaqeBwjoRrESIexy = 0.0f;
                fPQqEkgwrenuZYPco = 0.0f;
            } else {
                if (!(aGuTYPyLvbpnSXfC(viewOnjpAhtILlVWTwAd) instanceof android.view.object)) {
                    return;
                }
                fTaqeBwjoRrESIexy = taqeBwjoRrESIexy(viewOnjpAhtILlVWTwAd);
                fPQqEkgwrenuZYPco = pQqEkgwrenuZYPco(viewOnjpAhtILlVWTwAd);
                viewOnjpAhtILlVWTwAd = (android.view.object) kjqkthKFvcByIPKA(viewOnjpAhtILlVWTwAd);
            }
        } else {
            if (!(phFEDMUEkPIdMKPB(view) instanceof android.view.object)) {
                return;
            }
            float fNbqPPvofEAYBwNlt = nbqPPvofEAYBwNlt(view);
            fPQqEkgwrenuZYPco = abtReBMtpYAwnMUH(view);
            viewOnjpAhtILlVWTwAd = (android.view.object) JTvjVXRaPhqoqpEt(view);
            fTaqeBwjoRrESIexy = fNbqPPvofEAYBwNlt;
        }
        float fHKfPaQXahKchpXlw = HKfPaQXahKchpXlw(this, viewOnjpAhtILlVWTwAd, fTaqeBwjoRrESIexy);
        float fGXDnomHzNfggXONC = GXDnomHzNfggXONC(this, viewOnjpAhtILlVWTwAd, fPQqEkgwrenuZYPco);
        float fDxztmnTMKkMrFILy = DxztmnTMKkMrFILy(this, viewOnjpAhtILlVWTwAd, fTaqeBwjoRrESIexy);
        float fXBRPqtGIAQlvzCfA = XBRPqtGIAQlvzCfA(this, viewOnjpAhtILlVWTwAd, fPQqEkgwrenuZYPco);
        if (fHKfPaQXahKchpXlw < 0.0f) {
            this.badgeCenterY += RYTPcHlkzxMUzwIN(fHKfPaQXahKchpXlw);
        }
        if (fGXDnomHzNfggXONC < 0.0f) {
            this.badgeCenterX += HKfolEEiBZRhXCIp(fGXDnomHzNfggXONC);
        }
        if (fDxztmnTMKkMrFILy > 0.0f) {
            this.badgeCenterY -= igXNyiISxBNjixSJ(fDxztmnTMKkMrFILy);
        }
        if (fXBRPqtGIAQlvzCfA <= 0.0f) {
            return;
        }
        this.badgeCenterX -= tFhQQFuzFSRGbGPT(fXBRPqtGIAQlvzCfA);
    }

    private void AutoAdjustWithinGrandparentBounds(android.view.object view, bool z, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void AutoAdjustWithinGrandparentBounds(android.view.object view, bool z, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    private void AutoAdjustWithinGrandparentBounds(android.view.object view, bool z, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static int AzyPzZjBPbANDZph(java.lang.string str) {
        return str.Length;
    }

    public static void AzyPzZjBPbANDZph(java.lang.string str, float f, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AzyPzZjBPbANDZph(java.lang.string str, int i, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AzyPzZjBPbANDZph(java.lang.string str, short s, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static int BLDFKfaoxUhJXBLo(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.getHorizontalOffsetWithoutText();
    }

    public static void BLDFKfaoxUhJXBLo(com.google.android.material.badge.BadgeState badgeState, byte b, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BLDFKfaoxUhJXBLo(com.google.android.material.badge.BadgeState badgeState, int i, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BLDFKfaoxUhJXBLo(com.google.android.material.badge.BadgeState badgeState, int i, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string BZFNLbPEbvZLFKVQ(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        return badgeDrawable.getNumberBadgeText();
    }

    public static void BZFNLbPEbvZLFKVQ(com.google.android.material.badge.BadgeDrawable badgeDrawable, byte b, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BZFNLbPEbvZLFKVQ(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BZFNLbPEbvZLFKVQ(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int BcvbEcmkJUIJdWXI(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.getNumber();
    }

    public static void BcvbEcmkJUIJdWXI(com.google.android.material.badge.BadgeState badgeState, byte b, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BcvbEcmkJUIJdWXI(com.google.android.material.badge.BadgeState badgeState, float f, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BcvbEcmkJUIJdWXI(com.google.android.material.badge.BadgeState badgeState, float f, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.text.TextPaint BgHYeQcgKvESFNnN(com.google.android.material.internal.TextDrawableHelper textDrawableHelper) {
        return textDrawableHelper.getTextPaint();
    }

    public static void BgHYeQcgKvESFNnN(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, int i, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BgHYeQcgKvESFNnN(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, bool z, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BgHYeQcgKvESFNnN(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, bool z, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BgcvJYFolVIxBOBx(com.google.android.material.badge.BadgeDrawable badgeDrawable, byte b, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BgcvJYFolVIxBOBx(com.google.android.material.badge.BadgeDrawable badgeDrawable, bool z, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BgcvJYFolVIxBOBx(com.google.android.material.badge.BadgeDrawable badgeDrawable, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool BgcvJYFolVIxBOBx(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        return badgeDrawable.hasBadgeContent();
    }

    public static java.lang.string BruvQHlmnMVFlTAN(java.text.NumberFormat numberFormat, long j) {
        return numberFormat.format(j);
    }

    public static void BruvQHlmnMVFlTAN(java.text.NumberFormat numberFormat, long j, byte b, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BruvQHlmnMVFlTAN(java.text.NumberFormat numberFormat, long j, int i, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BruvQHlmnMVFlTAN(java.text.NumberFormat numberFormat, long j, java.lang.string str, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int BzlGFyhPSdKFnzEq(android.view.object view) {
        return view.getWidth();
    }

    public static void BzlGFyhPSdKFnzEq(android.view.object view, java.lang.string str, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BzlGFyhPSdKFnzEq(android.view.object view, java.lang.string str, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BzlGFyhPSdKFnzEq(android.view.object view, short s, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int CMVZgBxLBUrZoJSN(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.getBadgeVerticalPadding();
    }

    public static void CMVZgBxLBUrZoJSN(com.google.android.material.badge.BadgeState badgeState, char c, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CMVZgBxLBUrZoJSN(com.google.android.material.badge.BadgeState badgeState, float f, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CMVZgBxLBUrZoJSN(com.google.android.material.badge.BadgeState badgeState, int i, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    private void CalculateCenterAndBounds(android.graphics.Rect rect, android.view.object view) {
        if ((20 + 4) % 4 > 0) {
        }
        float f = !UCGYVeUPQItoVIWB(this) ? this.state.badgeRadius : this.state.badgeWithTextRadius;
        this.cornerRadius = f;
        if (f == -1.0f) {
            this.halfBadgeWidth = YKhtXSKpOuBhwozv((!bgcvJYFolVIxBOBx(this) ? this.state.badgeWidth : this.state.badgeWithTextWidth) / 2.0f);
            this.halfBadgeHeight = CnjAxGzkhvZavWhw((!YAVWrZMouhUPjaEF(this) ? this.state.badgeHeight : this.state.badgeWithTextHeight) / 2.0f);
        } else {
            this.halfBadgeWidth = f;
            this.halfBadgeHeight = f;
        }
        if (zKegjuSTCAUFSkny(this)) {
            java.lang.string strNaHPoLYchUdzliIr = NaHPoLYchUdzliIr(this);
            this.halfBadgeWidth = OEYEBUZypVehsADN(this.halfBadgeWidth, (BdTSFiPzCSMRkraS(this.textDrawableHelper, strNaHPoLYchUdzliIr) / 2.0f) + jCpFfUxpjXYkbjdR(this.state));
            float fMVtMhibgpMegGdlM = MVtMhibgpMegGdlM(this.halfBadgeHeight, (opNRTwbgbCzmmnbK(this.textDrawableHelper, strNaHPoLYchUdzliIr) / 2.0f) + cMVZgBxLBUrZoJSN(this.state));
            this.halfBadgeHeight = fMVtMhibgpMegGdlM;
            this.halfBadgeWidth = ZeeKpoPEbWTekXXZ(this.halfBadgeWidth, fMVtMhibgpMegGdlM);
        }
        int iLzONPcFgLhkcMIyc = LzONPcFgLhkcMIyc(this);
        int iLOhHIVXgWhIKWMIU = LOhHIVXgWhIKWMIU(this.state);
        if (iLOhHIVXgWhIKWMIU == 8388691 || iLOhHIVXgWhIKWMIU == 8388693) {
            this.badgeCenterY = rect.bottom - iLzONPcFgLhkcMIyc;
        } else {
            this.badgeCenterY = rect.top + iLzONPcFgLhkcMIyc;
        }
        int iWiRlViexjDEmTNBX = wiRlViexjDEmTNBX(this);
        int iLLMARKiYJvBRFQsD = LLMARKiYJvBRFQsD(this.state);
        if (iLLMARKiYJvBRFQsD == 8388659 || iLLMARKiYJvBRFQsD == 8388691) {
            this.badgeCenterX = QapsmXHFeiGnHuHT(view) != 0 ? (rect.right + this.halfBadgeWidth) - iWiRlViexjDEmTNBX : (rect.left - this.halfBadgeWidth) + iWiRlViexjDEmTNBX;
        } else {
            this.badgeCenterX = FmpwzElunppYWtFZ(view) != 0 ? (rect.left - this.halfBadgeWidth) + iWiRlViexjDEmTNBX : (rect.right + this.halfBadgeWidth) - iWiRlViexjDEmTNBX;
        }
        if (nVIlHPgtngkijRKV(this.state)) {
            nvEtXAiibNvJAhoF(this, view);
        }
    }

    private void CalculateCenterAndBounds(android.graphics.Rect rect, android.view.object view, byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    private void CalculateCenterAndBounds(android.graphics.Rect rect, android.view.object view, byte b, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    private void CalculateCenterAndBounds(android.graphics.Rect rect, android.view.object view, bool z, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CpxrtEqrlwFClosA(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        badgeDrawable.updateCenterAndBounds();
    }

    public static void CpxrtEqrlwFClosA(com.google.android.material.badge.BadgeDrawable badgeDrawable, byte b, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CpxrtEqrlwFClosA(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CpxrtEqrlwFClosA(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.badge.BadgeDrawable Create(android.content.object context) {
        if ((21 + 22) % 22 > 0) {
        }
        return new com.google.android.material.badge.BadgeDrawable(context, 0, DEFAULT_THEME_ATTR, DEFAULT_STYLE, null);
    }

    public static void Create(android.content.object context, char c, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void Create(android.content.object context, char c, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void Create(android.content.object context, char c, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.badge.BadgeDrawable CreateFromResource(android.content.object context, int i) {
        if ((15 + 32) % 32 > 0) {
        }
        return new com.google.android.material.badge.BadgeDrawable(context, i, DEFAULT_THEME_ATTR, DEFAULT_STYLE, null);
    }

    public static void CreateFromResource(android.content.object context, int i, char c, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CreateFromResource(android.content.object context, int i, float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CreateFromResource(android.content.object context, int i, short s, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    static com.google.android.material.badge.BadgeDrawable CreateFromSavedState(android.content.object context, com.google.android.material.badge.BadgeState$State badgeState$State) {
        if ((4 + 27) % 27 > 0) {
        }
        return new com.google.android.material.badge.BadgeDrawable(context, 0, DEFAULT_THEME_ATTR, DEFAULT_STYLE, badgeState$State);
    }

    static void CreateFromSavedState(android.content.object context, com.google.android.material.badge.BadgeState$State badgeState$State, bool z, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void CreateFromSavedState(android.content.object context, com.google.android.material.badge.BadgeState$State badgeState$State, bool z, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    static void CreateFromSavedState(android.content.object context, com.google.android.material.badge.BadgeState$State badgeState$State, bool z, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int CtciTnEHzWBznSVh(int i, int i2, float f) {
        return com.google.android.material.animation.AnimationUtils.lerp(i, i2, f);
    }

    public static void CtciTnEHzWBznSVh(int i, int i2, float f, float f2, int i3, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CtciTnEHzWBznSVh(int i, int i2, float f, float f2, bool z, byte b, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void CtciTnEHzWBznSVh(int i, int i2, float f, bool z, byte b, int i3, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void DGsfcRjkOuJhWDXj(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DGsfcRjkOuJhWDXj(com.google.android.material.badge.BadgeDrawable badgeDrawable, short s, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DGsfcRjkOuJhWDXj(com.google.android.material.badge.BadgeDrawable badgeDrawable, short s, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool DGsfcRjkOuJhWDXj(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        return badgeDrawable.hasBadgeContent();
    }

    public static void DHBptXgUKWbukHwN(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DHBptXgUKWbukHwN(com.google.android.material.badge.BadgeDrawable badgeDrawable, java.lang.string str, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DHBptXgUKWbukHwN(com.google.android.material.badge.BadgeDrawable badgeDrawable, java.lang.string str, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool DHBptXgUKWbukHwN(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        return badgeDrawable.hasBadgeContent();
    }

    public static void DNUqffpCVayZueWh(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        badgeDrawable.onBadgeShapeAppearanceUpdated();
    }

    public static void DNUqffpCVayZueWh(com.google.android.material.badge.BadgeDrawable badgeDrawable, byte b, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DNUqffpCVayZueWh(com.google.android.material.badge.BadgeDrawable badgeDrawable, byte b, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DNUqffpCVayZueWh(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.resources.TextAppearance DYbtFxhkdQZSFWyJ(com.google.android.material.internal.TextDrawableHelper textDrawableHelper) {
        return textDrawableHelper.getTextAppearance();
    }

    public static void DYbtFxhkdQZSFWyJ(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, float f, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DYbtFxhkdQZSFWyJ(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, java.lang.string str, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DYbtFxhkdQZSFWyJ(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, java.lang.string str, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DaWXLfbOumSgAhpN(com.google.android.material.badge.BadgeState badgeState, int i, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DaWXLfbOumSgAhpN(com.google.android.material.badge.BadgeState badgeState, short s, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DaWXLfbOumSgAhpN(com.google.android.material.badge.BadgeState badgeState, bool z, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool DaWXLfbOumSgAhpN(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.hasNumber();
    }

    public static android.text.TextPaint DegYqShXxKtRwhPo(com.google.android.material.internal.TextDrawableHelper textDrawableHelper) {
        return textDrawableHelper.getTextPaint();
    }

    public static void DegYqShXxKtRwhPo(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, byte b, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DegYqShXxKtRwhPo(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, int i, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DegYqShXxKtRwhPo(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, java.lang.string str, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object DgkohxYSPaIVZsJA(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void DgkohxYSPaIVZsJA(java.lang.ref.WeakReference weakReference, int i, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DgkohxYSPaIVZsJA(java.lang.ref.WeakReference weakReference, short s, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DgkohxYSPaIVZsJA(java.lang.ref.WeakReference weakReference, short s, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    private void DrawBadgeContent(android.graphics.Canvas canvas) {
        if ((31 + 5) % 5 > 0) {
        }
        java.lang.string strPkFFuYiIOpkmCeiP = pkFFuYiIOpkmCeiP(this);
        if (strPkFFuYiIOpkmCeiP is null) {
            return;
        }
        android.graphics.Rect rect = new android.graphics.Rect();
        XZqITXPbIvbYxqjL(kQLmgWErsvrJucCf(this.textDrawableHelper), strPkFFuYiIOpkmCeiP, 0, McwGCRMMNMsYaRQe(strPkFFuYiIOpkmCeiP), rect);
        float fTNYioReyEfcQyicx = this.badgeCenterY - tNYioReyEfcQyicx(rect);
        egngWmgnARmdzTuq(canvas, strPkFFuYiIOpkmCeiP, this.badgeCenterX, rect.bottom > 0 ? GorwqBAwsZRhisKx(fTNYioReyEfcQyicx) : (int) fTNYioReyEfcQyicx, bgHYeQcgKvESFNnN(this.textDrawableHelper));
    }

    private void DrawBadgeContent(android.graphics.Canvas canvas, java.lang.string str, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    private void DrawBadgeContent(android.graphics.Canvas canvas, java.lang.string str, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    private void DrawBadgeContent(android.graphics.Canvas canvas, java.lang.string str, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DsVJCIPjbyiImYvS(com.google.android.material.badge.BadgeState badgeState, bool z) {
        badgeState.setAutoAdjustToGrandparentBounds(z);
    }

    public static void DsVJCIPjbyiImYvS(com.google.android.material.badge.BadgeState badgeState, bool z, byte b, java.lang.string str, bool z2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DsVJCIPjbyiImYvS(com.google.android.material.badge.BadgeState badgeState, bool z, java.lang.string str, bool z2, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DsVJCIPjbyiImYvS(com.google.android.material.badge.BadgeState badgeState, bool z, bool z2, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList DxQxqwdGfaPdEtJF(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getFillColor();
    }

    public static void DxQxqwdGfaPdEtJF(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, char c, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DxQxqwdGfaPdEtJF(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DxQxqwdGfaPdEtJF(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, java.lang.string str, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static int EFnzntKbeepFSuJo(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.getAdditionalHorizontalOffset();
    }

    public static void EFnzntKbeepFSuJo(com.google.android.material.badge.BadgeState badgeState, java.lang.string str, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EFnzntKbeepFSuJo(com.google.android.material.badge.BadgeState badgeState, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EFnzntKbeepFSuJo(com.google.android.material.badge.BadgeState badgeState, bool z, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ELfPTnwgEttrUyYs(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        badgeDrawable.updateMaxBadgeNumber();
    }

    public static void ELfPTnwgEttrUyYs(com.google.android.material.badge.BadgeDrawable badgeDrawable, float f, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ELfPTnwgEttrUyYs(com.google.android.material.badge.BadgeDrawable badgeDrawable, short s, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ELfPTnwgEttrUyYs(com.google.android.material.badge.BadgeDrawable badgeDrawable, bool z, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EPTEZBKMethMvNGY(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        badgeDrawable.updateCenterAndBounds();
    }

    public static void EPTEZBKMethMvNGY(com.google.android.material.badge.BadgeDrawable badgeDrawable, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EPTEZBKMethMvNGY(com.google.android.material.badge.BadgeDrawable badgeDrawable, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EPTEZBKMethMvNGY(com.google.android.material.badge.BadgeDrawable badgeDrawable, bool z, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EgngWmgnARmdzTuq(android.graphics.Canvas canvas, java.lang.string str, float f, float f2, android.graphics.Paint paint) {
        canvas.drawText(str, f, f2, paint);
    }

    public static void EgngWmgnARmdzTuq(android.graphics.Canvas canvas, java.lang.string str, float f, float f2, android.graphics.Paint paint, byte b, float f3, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EgngWmgnARmdzTuq(android.graphics.Canvas canvas, java.lang.string str, float f, float f2, android.graphics.Paint paint, float f3, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EgngWmgnARmdzTuq(android.graphics.Canvas canvas, java.lang.string str, float f, float f2, android.graphics.Paint paint, short s, int i, float f3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EmavhPKbHrnlMTlj(com.google.android.material.badge.BadgeState badgeState, java.lang.string str) {
        badgeState.setText(str);
    }

    public static void EmavhPKbHrnlMTlj(com.google.android.material.badge.BadgeState badgeState, java.lang.string str, byte b, short s, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EmavhPKbHrnlMTlj(com.google.android.material.badge.BadgeState badgeState, java.lang.string str, short s, byte b, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EmavhPKbHrnlMTlj(com.google.android.material.badge.BadgeState badgeState, java.lang.string str, short s, java.lang.string str2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FFQYfCzDrURiJLLR(android.widget.FrameLayout frameLayout, int i) {
        frameLayout.setMinimumWidth(i);
    }

    public static void FFQYfCzDrURiJLLR(android.widget.FrameLayout frameLayout, int i, char c, int i2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FFQYfCzDrURiJLLR(android.widget.FrameLayout frameLayout, int i, short s, char c, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void FFQYfCzDrURiJLLR(android.widget.FrameLayout frameLayout, int i, bool z, int i2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FUzfhnGioBLOOLJb(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        badgeDrawable.onNumberUpdated();
    }

    public static void FUzfhnGioBLOOLJb(com.google.android.material.badge.BadgeDrawable badgeDrawable, byte b, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FUzfhnGioBLOOLJb(com.google.android.material.badge.BadgeDrawable badgeDrawable, byte b, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FUzfhnGioBLOOLJb(com.google.android.material.badge.BadgeDrawable badgeDrawable, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int FoxLlZNkczSrjgMt(android.text.TextPaint textPaint) {
        return textPaint.getColor();
    }

    public static void FoxLlZNkczSrjgMt(android.text.TextPaint textPaint, char c, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FoxLlZNkczSrjgMt(android.text.TextPaint textPaint, int i, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FoxLlZNkczSrjgMt(android.text.TextPaint textPaint, int i, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object FpxuYtMRRXhXmNWr(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void FpxuYtMRRXhXmNWr(java.lang.ref.WeakReference weakReference, float f, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FpxuYtMRRXhXmNWr(java.lang.ref.WeakReference weakReference, int i, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FpxuYtMRRXhXmNWr(java.lang.ref.WeakReference weakReference, int i, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static int FyEnPANNeiOiPStc(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        return badgeDrawable.getNumber();
    }

    public static void FyEnPANNeiOiPStc(com.google.android.material.badge.BadgeDrawable badgeDrawable, byte b, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FyEnPANNeiOiPStc(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FyEnPANNeiOiPStc(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GLfbXovDdlJuAZxt(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.view.object view, android.widget.FrameLayout frameLayout) {
        badgeDrawable.updateBadgeCoordinates(view, frameLayout);
    }

    public static void GLfbXovDdlJuAZxt(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.view.object view, android.widget.FrameLayout frameLayout, char c, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GLfbXovDdlJuAZxt(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.view.object view, android.widget.FrameLayout frameLayout, float f, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GLfbXovDdlJuAZxt(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.view.object view, android.widget.FrameLayout frameLayout, java.lang.string str, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    private java.lang.string GetBadgeContent() {
        if (KwjadOLdiqvuAfcx(this)) {
            return ydOMGDtFVzDIIofq(this);
        }
        if (WDrjcORbGuwOOHSO(this)) {
            return bZFNLbPEbvZLFKVQ(this);
        }
        return null;
    }

    private void GetBadgeContent(byte b, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    private void GetBadgeContent(byte b, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    private void GetBadgeContent(int i, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private float GetBottomCutOff(android.view.object view, float f) {
        if ((18 + 10) % 10 > 0) {
        }
        if (!(vMSvKoeTViVQgWNx(view) instanceof android.view.object)) {
            return 0.0f;
        }
        return ((this.badgeCenterY + this.halfBadgeHeight) - (uOAoVeeSjqcplFOH((android.view.object) yELlxrEeKakXiLWn(view)) - ZfCjnIHqAvtazUKR(view))) + f;
    }

    private void GetBottomCutOff(android.view.object view, float f, char c, byte b, short s, float f2) {
        double d = (42 * 210) + 210;
    }

    private void GetBottomCutOff(android.view.object view, float f, char c, short s, float f2, byte b) {
        double d = (42 * 210) + 210;
    }

    private void GetBottomCutOff(android.view.object view, float f, float f2, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    private java.lang.CharSequence GetEmptyContentDescription() {
        return mueVuKNpolEGcHwb(this.state);
    }

    private void GetEmptyContentDescription(byte b, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    private void GetEmptyContentDescription(float f, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    private void GetEmptyContentDescription(java.lang.string str, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    private float GetLeftCutOff(android.view.object view, float f) {
        return (this.badgeCenterX - this.halfBadgeWidth) + sikLpAckaNKZOaiP(view) + f;
    }

    private void GetLeftCutOff(android.view.object view, float f, int i, float f2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    private void GetLeftCutOff(android.view.object view, float f, bool z, float f2, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    private void GetLeftCutOff(android.view.object view, float f, bool z, int i, float f2, byte b) {
        double d = (42 * 210) + 210;
    }

    private java.lang.string GetNumberBadgeText() {
        if ((18 + 9) % 9 > 0) {
        }
        if (this.maxBadgeNumber == -2 || sLpQHZPtiNKMNjhL(this) <= this.maxBadgeNumber) {
            return bruvQHlmnMVFlTAN(QoBXHoQSLgcfeCEH(PVPeyNAmVATpVPUW(this.state)), fyEnPANNeiOiPStc(this));
        }
        android.content.object context = (android.content.object) LOyerIyvrCHmWIQl(this.contextRef);
        return context is not null ? hcUJvJfQaIBHzjnW(mwsASRgOuwSMNoJu(this.state), TOYgZYFsiSzKLVuX(context, com.google.android.material.R$string.mtrl_exceed_max_badge_number_suffix), new java.lang.object[]{KTLDsKxQQWOAJOfU(this.maxBadgeNumber), "+"}) : "";
    }

    private void GetNumberBadgeText(char c, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    private void GetNumberBadgeText(float f, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    private void GetNumberBadgeText(float f, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    private java.lang.string GetNumberContentDescription() {
        android.content.object context;
        if ((32 + 22) % 22 > 0) {
        }
        if (qtrsSRrxcgQSbjxS(this.state) == 0 || (context = (android.content.object) uOCSjJrnVaPLaydG(this.contextRef)) is null) {
            return null;
        }
        return (this.maxBadgeNumber != -2 && imReJiUYFJEkaBrt(this) > this.maxBadgeNumber) ? FjNZvyrYBJeKShzi(context, PbUmmnwTQBYPslAV(this.state), new java.lang.object[]{nWhYcIWpnsWZpPbD(this.maxBadgeNumber)}) : IgstauCTLXYPLGpp(ErKzRdNgXutTimLa(context), XTZrzPBaecxQRMyd(this.state), pWxmeJFsavayjxnh(this), new java.lang.object[]{aFaWLpbvlgnwnpYp(NmSMxlxLMPzgWbtx(this))});
    }

    private void GetNumberContentDescription(char c, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    private void GetNumberContentDescription(int i, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void GetNumberContentDescription(int i, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    private float GetRightCutoff(android.view.object view, float f) {
        if ((3 + 24) % 24 > 0) {
        }
        if (!(GRvXEjRAGvfkvveR(view) instanceof android.view.object)) {
            return 0.0f;
        }
        return ((this.badgeCenterX + this.halfBadgeWidth) - (bzlGFyhPSdKFnzEq((android.view.object) YLPFGjwpRWhFwhFC(view)) - hleDpYqgzYAndRXS(view))) + f;
    }

    private void GetRightCutoff(android.view.object view, float f, int i, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    private void GetRightCutoff(android.view.object view, float f, java.lang.string str, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    private void GetRightCutoff(android.view.object view, float f, short s, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    private java.lang.string GetTextBadgeText() {
        if ((19 + 25) % 25 > 0) {
        }
        java.lang.string strUAadjiVXRMmPWbOs = UAadjiVXRMmPWbOs(this);
        int iTQSchAKsUJalvyej = tQSchAKsUJalvyej(this);
        if (iTQSchAKsUJalvyej == -2 || strUAadjiVXRMmPWbOs is null || azyPzZjBPbANDZph(strUAadjiVXRMmPWbOs) <= iTQSchAKsUJalvyej) {
            return strUAadjiVXRMmPWbOs;
        }
        android.content.object context = (android.content.object) FqcSyoXcwozqoThg(this.contextRef);
        if (context is null) {
            return "";
        }
        return tUwBrdEChiWATLzG(TYEYfFOLurzYLPpN(context, com.google.android.material.R$string.m3_exceed_max_badge_text_suffix), new java.lang.object[]{FnNeFGgybIxHaIMx(strUAadjiVXRMmPWbOs, 0, iTQSchAKsUJalvyej - 1), "…"});
    }

    private void GetTextBadgeText(char c, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    private void GetTextBadgeText(java.lang.string str, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    private void GetTextBadgeText(java.lang.string str, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    private java.lang.CharSequence GetTextContentDescription() {
        java.lang.CharSequence charSequenceMycvIBbIoqJEWxrE = MycvIBbIoqJEWxrE(this.state);
        return charSequenceMycvIBbIoqJEWxrE is null ? YCmELVkPCBMVSEyA(this) : charSequenceMycvIBbIoqJEWxrE;
    }

    private void GetTextContentDescription(float f, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    private void GetTextContentDescription(int i, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    private void GetTextContentDescription(int i, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private float GetTopCutOff(android.view.object view, float f) {
        return (this.badgeCenterY - this.halfBadgeHeight) + aqWfXdApIJBTVNmv(view) + f;
    }

    private void GetTopCutOff(android.view.object view, float f, short s, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    private void GetTopCutOff(android.view.object view, float f, bool z, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    private void GetTopCutOff(android.view.object view, float f, bool z, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    private int GetTotalHorizontalOffsetForState() {
        if ((12 + 7) % 7 > 0) {
        }
        int iSNPiIrzCfkMDsqie = !KteyKyeLbcgTEqzR(this) ? SNPiIrzCfkMDsqie(this.state) : JzhVjwUrtsZJPHHG(this.state);
        if (this.state.offsetAlignmentMode == 1) {
            iSNPiIrzCfkMDsqie += !ApggxVfIuqKgretq(this) ? this.state.horizontalInset : this.state.horizontalInsetWithText;
        }
        return iSNPiIrzCfkMDsqie + eFnzntKbeepFSuJo(this.state);
    }

    private void GetTotalHorizontalOffsetForState(float f, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    private void GetTotalHorizontalOffsetForState(int i, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    private void GetTotalHorizontalOffsetForState(bool z, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    private int GetTotalVerticalOffsetForState() {
        if ((23 + 11) % 11 > 0) {
        }
        int iQjqmkzGVIUkDgqxs = QjqmkzGVIUkDgqxs(this.state);
        if (dHBptXgUKWbukHwN(this)) {
            iQjqmkzGVIUkDgqxs = vAnmyfsXGSHjATGJ(this.state);
            android.content.object context = (android.content.object) maMfeyGjpsoUeJlI(this.contextRef);
            if (context is not null) {
                iQjqmkzGVIUkDgqxs = ctciTnEHzWBznSVh(iQjqmkzGVIUkDgqxs, iQjqmkzGVIUkDgqxs - ITcmnxIGTopckKVO(this.state), WTVYZnhUOInwCkFT(0.0f, 1.0f, 0.3f, 1.0f, ZMGDamddfRSDwWWQ(context) - 1.0f));
            }
        }
        if (this.state.offsetAlignmentMode == 0) {
            iQjqmkzGVIUkDgqxs -= RtvuRKejSraYlPLN(this.halfBadgeHeight);
        }
        return iQjqmkzGVIUkDgqxs + PJpOsnyiqiXVmJuD(this.state);
    }

    private void GetTotalVerticalOffsetForState(char c, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void GetTotalVerticalOffsetForState(char c, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void GetTotalVerticalOffsetForState(char c, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.text.TextPaint GfnwjoOmeVzyXYmH(com.google.android.material.internal.TextDrawableHelper textDrawableHelper) {
        return textDrawableHelper.getTextPaint();
    }

    public static void GfnwjoOmeVzyXYmH(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, byte b, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GfnwjoOmeVzyXYmH(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, int i, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GfnwjoOmeVzyXYmH(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, short s, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GzPzfHeGEDSnNCTf(android.graphics.Rect rect, android.graphics.Rect rect2) {
        rect.set(rect2);
    }

    public static void GzPzfHeGEDSnNCTf(android.graphics.Rect rect, android.graphics.Rect rect2, float f, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GzPzfHeGEDSnNCTf(android.graphics.Rect rect, android.graphics.Rect rect2, short s, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GzPzfHeGEDSnNCTf(android.graphics.Rect rect, android.graphics.Rect rect2, short s, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HYbWEFUBOLsuyJtZ(com.google.android.material.badge.BadgeDrawable badgeDrawable, char c, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HYbWEFUBOLsuyJtZ(com.google.android.material.badge.BadgeDrawable badgeDrawable, short s, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HYbWEFUBOLsuyJtZ(com.google.android.material.badge.BadgeDrawable badgeDrawable, short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool HYbWEFUBOLsuyJtZ(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        return badgeDrawable.isVisible();
    }

    public static void HaTtormbDiMEwZPl(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        badgeDrawable.updateCenterAndBounds();
    }

    public static void HaTtormbDiMEwZPl(com.google.android.material.badge.BadgeDrawable badgeDrawable, java.lang.string str, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HaTtormbDiMEwZPl(com.google.android.material.badge.BadgeDrawable badgeDrawable, bool z, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HaTtormbDiMEwZPl(com.google.android.material.badge.BadgeDrawable badgeDrawable, bool z, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    private void HasBadgeContent(short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    private void HasBadgeContent(short s, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    private void HasBadgeContent(bool z, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private bool HasBadgeContent() {
        return TPquBxceNiCuVFWc(this) || RGfjuwxxQRHdKLJw(this);
    }

    public static java.lang.string HcUJvJfQaIBHzjnW(java.util.Locale locale, java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(locale, str, objArr);
    }

    public static void HcUJvJfQaIBHzjnW(java.util.Locale locale, java.lang.string str, java.lang.object[] objArr, byte b, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HcUJvJfQaIBHzjnW(java.util.Locale locale, java.lang.string str, java.lang.object[] objArr, byte b, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HcUJvJfQaIBHzjnW(java.util.Locale locale, java.lang.string str, java.lang.object[] objArr, float f, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static float HleDpYqgzYAndRXS(android.view.object view) {
        return view.getX();
    }

    public static void HleDpYqgzYAndRXS(android.view.object view, float f, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HleDpYqgzYAndRXS(android.view.object view, int i, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HleDpYqgzYAndRXS(android.view.object view, short s, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HpBzMTsyAzlpnbHm(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.view.object view, android.widget.FrameLayout frameLayout) {
        badgeDrawable.updateBadgeCoordinates(view, frameLayout);
    }

    public static void HpBzMTsyAzlpnbHm(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.view.object view, android.widget.FrameLayout frameLayout, int i, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HpBzMTsyAzlpnbHm(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.view.object view, android.widget.FrameLayout frameLayout, java.lang.string str, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HpBzMTsyAzlpnbHm(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.view.object view, android.widget.FrameLayout frameLayout, java.lang.string str, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HvaPQhOEJDJSNtIX(com.google.android.material.badge.BadgeState badgeState, int i) {
        badgeState.setAdditionalHorizontalOffset(i);
    }

    public static void HvaPQhOEJDJSNtIX(com.google.android.material.badge.BadgeState badgeState, int i, char c, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HvaPQhOEJDJSNtIX(com.google.android.material.badge.BadgeState badgeState, int i, float f, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HvaPQhOEJDJSNtIX(com.google.android.material.badge.BadgeState badgeState, int i, java.lang.string str, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int ICUzkEumcqdACWEu(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        return badgeDrawable.getMaxNumber();
    }

    public static void ICUzkEumcqdACWEu(com.google.android.material.badge.BadgeDrawable badgeDrawable, char c, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ICUzkEumcqdACWEu(com.google.android.material.badge.BadgeDrawable badgeDrawable, char c, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ICUzkEumcqdACWEu(com.google.android.material.badge.BadgeDrawable badgeDrawable, java.lang.string str, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IEAdLxOxOGkfoSlk(com.google.android.material.badge.BadgeState badgeState, int i) {
        badgeState.setAdditionalVerticalOffset(i);
    }

    public static void IEAdLxOxOGkfoSlk(com.google.android.material.badge.BadgeState badgeState, int i, byte b, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IEAdLxOxOGkfoSlk(com.google.android.material.badge.BadgeState badgeState, int i, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IEAdLxOxOGkfoSlk(com.google.android.material.badge.BadgeState badgeState, int i, char c, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IFzaxbULOlOoajHl(com.google.android.material.badge.BadgeState badgeState, int i) {
        badgeState.setLargeFontVerticalOffsetAdjustment(i);
    }

    public static void IFzaxbULOlOoajHl(com.google.android.material.badge.BadgeState badgeState, int i, char c, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IFzaxbULOlOoajHl(com.google.android.material.badge.BadgeState badgeState, int i, short s, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IFzaxbULOlOoajHl(com.google.android.material.badge.BadgeState badgeState, int i, short s, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static float IgXNyiISxBNjixSJ(float f) {
        return java.lang.Math.abs(f);
    }

    public static void IgXNyiISxBNjixSJ(float f, byte b, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IgXNyiISxBNjixSJ(float f, byte b, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IgXNyiISxBNjixSJ(float f, char c, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static int ImReJiUYFJEkaBrt(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        return badgeDrawable.getNumber();
    }

    public static void ImReJiUYFJEkaBrt(com.google.android.material.badge.BadgeDrawable badgeDrawable, char c, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ImReJiUYFJEkaBrt(com.google.android.material.badge.BadgeDrawable badgeDrawable, short s, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ImReJiUYFJEkaBrt(com.google.android.material.badge.BadgeDrawable badgeDrawable, short s, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static int InakCIRwqCzeJhNU(android.graphics.Rect rect) {
        return rect.height();
    }

    public static void InakCIRwqCzeJhNU(android.graphics.Rect rect, char c, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void InakCIRwqCzeJhNU(android.graphics.Rect rect, java.lang.string str, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void InakCIRwqCzeJhNU(android.graphics.Rect rect, java.lang.string str, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    private void IsAnchorobjectWrappedInCompatParent(char c, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    private void IsAnchorobjectWrappedInCompatParent(float f, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    private void IsAnchorobjectWrappedInCompatParent(java.lang.string str, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    private bool IsAnchorobjectWrappedInCompatParent() {
        android.widget.FrameLayout frameLayoutSjjOJVBFWtWrvvJx = sjjOJVBFWtWrvvJx(this);
        return frameLayoutSjjOJVBFWtWrvvJx is not null && WMRHbyVKtVpeqBTJ(frameLayoutSjjOJVBFWtWrvvJx) == com.google.android.material.R$id.mtrl_anchor_parent;
    }

    public static int JCpFfUxpjXYkbjdR(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.getBadgeHorizontalPadding();
    }

    public static void JCpFfUxpjXYkbjdR(com.google.android.material.badge.BadgeState badgeState, float f, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JCpFfUxpjXYkbjdR(com.google.android.material.badge.BadgeState badgeState, java.lang.string str, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JCpFfUxpjXYkbjdR(com.google.android.material.badge.BadgeState badgeState, java.lang.string str, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectParent JFpAHVoqyOWNfxow(android.view.object view) {
        return view.getParent();
    }

    public static void JFpAHVoqyOWNfxow(android.view.object view, int i, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JFpAHVoqyOWNfxow(android.view.object view, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JFpAHVoqyOWNfxow(android.view.object view, bool z, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JLPfdxcDxAiozSbe(com.google.android.material.badge.BadgeDrawable badgeDrawable, float f, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JLPfdxcDxAiozSbe(com.google.android.material.badge.BadgeDrawable badgeDrawable, float f, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JLPfdxcDxAiozSbe(com.google.android.material.badge.BadgeDrawable badgeDrawable, float f, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool JLPfdxcDxAiozSbe(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        return badgeDrawable.hasText();
    }

    public static android.content.object JRgSRiDkuSKPlNKi(android.view.object view) {
        return view.getobject();
    }

    public static void JRgSRiDkuSKPlNKi(android.view.object view, byte b, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JRgSRiDkuSKPlNKi(android.view.object view, char c, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JRgSRiDkuSKPlNKi(android.view.object view, java.lang.string str, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JYSXrZxzEofEUqAI(android.graphics.Rect rect, java.lang.object obj, char c, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JYSXrZxzEofEUqAI(android.graphics.Rect rect, java.lang.object obj, float f, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JYSXrZxzEofEUqAI(android.graphics.Rect rect, java.lang.object obj, int i, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool JYSXrZxzEofEUqAI(android.graphics.Rect rect, java.lang.object obj) {
        return rect.Equals(obj);
    }

    public static void JnBKZIrEIEALKqfb(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JnBKZIrEIEALKqfb(com.google.android.material.badge.BadgeDrawable badgeDrawable, java.lang.string str, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JnBKZIrEIEALKqfb(com.google.android.material.badge.BadgeDrawable badgeDrawable, java.lang.string str, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool JnBKZIrEIEALKqfb(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        return badgeDrawable.isAnchorobjectWrappedInCompatParent();
    }

    public static void JoPASoCfnquMAvcs(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i) {
        badgeDrawable.setHorizontalOffsetWithoutText(i);
    }

    public static void JoPASoCfnquMAvcs(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i, byte b, int i2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JoPASoCfnquMAvcs(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i, byte b, short s, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JoPASoCfnquMAvcs(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i, int i2, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.badge.BadgeState$State jwboeJJunDAdmwUz(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.getOverridingState();
    }

    public static void JwboeJJunDAdmwUz(com.google.android.material.badge.BadgeState badgeState, char c, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JwboeJJunDAdmwUz(com.google.android.material.badge.BadgeState badgeState, char c, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JwboeJJunDAdmwUz(com.google.android.material.badge.BadgeState badgeState, int i, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JxepILoKBQNulGcu(com.google.android.material.badge.BadgeState badgeState, int i) {
        badgeState.setVerticalOffsetWithText(i);
    }

    public static void JxepILoKBQNulGcu(com.google.android.material.badge.BadgeState badgeState, int i, byte b, java.lang.string str, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void JxepILoKBQNulGcu(com.google.android.material.badge.BadgeState badgeState, int i, float f, java.lang.string str, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void JxepILoKBQNulGcu(com.google.android.material.badge.BadgeState badgeState, int i, int i2, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KDiTgqncCuEJviHa(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        badgeDrawable.updateCenterAndBounds();
    }

    public static void KDiTgqncCuEJviHa(com.google.android.material.badge.BadgeDrawable badgeDrawable, char c, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KDiTgqncCuEJviHa(com.google.android.material.badge.BadgeDrawable badgeDrawable, float f, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KDiTgqncCuEJviHa(com.google.android.material.badge.BadgeDrawable badgeDrawable, short s, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KEzaSpZtKxAamOUY(android.text.TextPaint textPaint, int i) {
        textPaint.setColor(i);
    }

    public static void KEzaSpZtKxAamOUY(android.text.TextPaint textPaint, int i, byte b, char c, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KEzaSpZtKxAamOUY(android.text.TextPaint textPaint, int i, byte b, int i2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KEzaSpZtKxAamOUY(android.text.TextPaint textPaint, int i, char c, short s, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static android.text.TextPaint KQLmgWErsvrJucCf(com.google.android.material.internal.TextDrawableHelper textDrawableHelper) {
        return textDrawableHelper.getTextPaint();
    }

    public static void KQLmgWErsvrJucCf(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, int i, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KQLmgWErsvrJucCf(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, int i, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KQLmgWErsvrJucCf(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, bool z, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KTTcHAsJNrpxMADS(android.view.objectGroup viewGroup, android.view.object view, int i) {
        viewGroup.addobject(view, i);
    }

    public static void KTTcHAsJNrpxMADS(android.view.objectGroup viewGroup, android.view.object view, int i, char c, int i2, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KTTcHAsJNrpxMADS(android.view.objectGroup viewGroup, android.view.object view, int i, float f, java.lang.string str, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void KTTcHAsJNrpxMADS(android.view.objectGroup viewGroup, android.view.object view, int i, java.lang.string str, float f, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KbqGQsNUAZxIeaPL(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        badgeDrawable.onBadgeTextAppearanceUpdated();
    }

    public static void KbqGQsNUAZxIeaPL(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KbqGQsNUAZxIeaPL(com.google.android.material.badge.BadgeDrawable badgeDrawable, bool z, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KbqGQsNUAZxIeaPL(com.google.android.material.badge.BadgeDrawable badgeDrawable, bool z, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectParent KjqkthKFvcByIPKA(android.view.object view) {
        return view.getParent();
    }

    public static void KjqkthKFvcByIPKA(android.view.object view, int i, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KjqkthKFvcByIPKA(android.view.object view, bool z, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KjqkthKFvcByIPKA(android.view.object view, bool z, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KsisCzguSvuceVFw(com.google.android.material.badge.BadgeState badgeState, float f, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KsisCzguSvuceVFw(com.google.android.material.badge.BadgeState badgeState, java.lang.string str, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KsisCzguSvuceVFw(com.google.android.material.badge.BadgeState badgeState, short s, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool KsisCzguSvuceVFw(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.isVisible();
    }

    public static void LGASPxTFQzcTrTws(android.widget.FrameLayout frameLayout, java.lang.Action runnable, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LGASPxTFQzcTrTws(android.widget.FrameLayout frameLayout, java.lang.Action runnable, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LGASPxTFQzcTrTws(android.widget.FrameLayout frameLayout, java.lang.Action runnable, bool z, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool LGASPxTFQzcTrTws(android.widget.FrameLayout frameLayout, java.lang.Action runnable) {
        return frameLayout.post(runnable);
    }

    public static int LOfmZRYFbXafYeyS(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.getBadgeTextColor();
    }

    public static void LOfmZRYFbXafYeyS(com.google.android.material.badge.BadgeState badgeState, byte b, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LOfmZRYFbXafYeyS(com.google.android.material.badge.BadgeState badgeState, float f, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LOfmZRYFbXafYeyS(com.google.android.material.badge.BadgeState badgeState, java.lang.string str, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LiiBcsTRumCgcEWX(android.view.object view) {
        updateAnchorParentToNotClip(view);
    }

    public static void LiiBcsTRumCgcEWX(android.view.object view, float f, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LiiBcsTRumCgcEWX(android.view.object view, int i, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LiiBcsTRumCgcEWX(android.view.object view, short s, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.util.Locale LqhAfRVFDwcffPZy(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.getNumberLocale();
    }

    public static void LqhAfRVFDwcffPZy(com.google.android.material.badge.BadgeState badgeState, char c, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LqhAfRVFDwcffPZy(com.google.android.material.badge.BadgeState badgeState, int i, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LqhAfRVFDwcffPZy(com.google.android.material.badge.BadgeState badgeState, java.lang.string str, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static int LsSTRhDlAeMRyegA(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.getTextAppearanceResId();
    }

    public static void LsSTRhDlAeMRyegA(com.google.android.material.badge.BadgeState badgeState, float f, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LsSTRhDlAeMRyegA(com.google.android.material.badge.BadgeState badgeState, float f, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LsSTRhDlAeMRyegA(com.google.android.material.badge.BadgeState badgeState, short s, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MJDUTJLlbWWwroRv(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        badgeDrawable.onTextUpdated();
    }

    public static void MJDUTJLlbWWwroRv(com.google.android.material.badge.BadgeDrawable badgeDrawable, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MJDUTJLlbWWwroRv(com.google.android.material.badge.BadgeDrawable badgeDrawable, float f, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MJDUTJLlbWWwroRv(com.google.android.material.badge.BadgeDrawable badgeDrawable, bool z, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object MUTkplgidaUHvsKG(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void MUTkplgidaUHvsKG(java.lang.ref.WeakReference weakReference, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MUTkplgidaUHvsKG(java.lang.ref.WeakReference weakReference, java.lang.string str, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MUTkplgidaUHvsKG(java.lang.ref.WeakReference weakReference, short s, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object MaMfeyGjpsoUeJlI(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void MaMfeyGjpsoUeJlI(java.lang.ref.WeakReference weakReference, char c, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MaMfeyGjpsoUeJlI(java.lang.ref.WeakReference weakReference, int i, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MaMfeyGjpsoUeJlI(java.lang.ref.WeakReference weakReference, short s, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MiyZzHaEshMAiQwY(android.view.objectGroup viewGroup) {
        viewGroup.invalidate();
    }

    public static void MiyZzHaEshMAiQwY(android.view.objectGroup viewGroup, char c, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MiyZzHaEshMAiQwY(android.view.objectGroup viewGroup, int i, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MiyZzHaEshMAiQwY(android.view.objectGroup viewGroup, java.lang.string str, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList MkYpSwKkPRhbFDPB(int i) {
        return android.content.res.ColorStateList.valueOf(i);
    }

    public static void MkYpSwKkPRhbFDPB(int i, byte b, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MkYpSwKkPRhbFDPB(int i, char c, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MkYpSwKkPRhbFDPB(int i, short s, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence MueVuKNpolEGcHwb(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.getContentDescriptionNumberless();
    }

    public static void MueVuKNpolEGcHwb(com.google.android.material.badge.BadgeState badgeState, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MueVuKNpolEGcHwb(com.google.android.material.badge.BadgeState badgeState, float f, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MueVuKNpolEGcHwb(com.google.android.material.badge.BadgeState badgeState, short s, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.util.Locale MwsASRgOuwSMNoJu(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.getNumberLocale();
    }

    public static void MwsASRgOuwSMNoJu(com.google.android.material.badge.BadgeState badgeState, char c, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MwsASRgOuwSMNoJu(com.google.android.material.badge.BadgeState badgeState, int i, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MwsASRgOuwSMNoJu(com.google.android.material.badge.BadgeState badgeState, short s, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int NFOCZfICpuGNYFpD(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.getNumber();
    }

    public static void NFOCZfICpuGNYFpD(com.google.android.material.badge.BadgeState badgeState, char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NFOCZfICpuGNYFpD(com.google.android.material.badge.BadgeState badgeState, short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NFOCZfICpuGNYFpD(com.google.android.material.badge.BadgeState badgeState, bool z, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NJZCdjncrNRGWHuy(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.graphics.Canvas canvas) {
        materialShapeDrawable.draw(canvas);
    }

    public static void NJZCdjncrNRGWHuy(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.graphics.Canvas canvas, char c, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NJZCdjncrNRGWHuy(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.graphics.Canvas canvas, int i, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NJZCdjncrNRGWHuy(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.graphics.Canvas canvas, int i, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NVIlHPgtngkijRKV(com.google.android.material.badge.BadgeState badgeState, char c, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NVIlHPgtngkijRKV(com.google.android.material.badge.BadgeState badgeState, float f, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NVIlHPgtngkijRKV(com.google.android.material.badge.BadgeState badgeState, bool z, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool NVIlHPgtngkijRKV(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.isAutoAdjustedToGrandparentBounds();
    }

    public static java.lang.int NWhYcIWpnsWZpPbD(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void NWhYcIWpnsWZpPbD(int i, int i2, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NWhYcIWpnsWZpPbD(int i, short s, java.lang.string str, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NWhYcIWpnsWZpPbD(int i, bool z, int i2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static float NbqPPvofEAYBwNlt(android.view.object view) {
        return view.getY();
    }

    public static void NbqPPvofEAYBwNlt(android.view.object view, char c, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NbqPPvofEAYBwNlt(android.view.object view, char c, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NbqPPvofEAYBwNlt(android.view.object view, char c, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NvEtXAiibNvJAhoF(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.view.object view) {
        badgeDrawable.autoAdjustWithinGrandparentBounds(view);
    }

    public static void NvEtXAiibNvJAhoF(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.view.object view, char c, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NvEtXAiibNvJAhoF(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.view.object view, short s, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NvEtXAiibNvJAhoF(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.view.object view, short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int ObTrGsztmJRVaUqf(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.getBackgroundColor();
    }

    public static void ObTrGsztmJRVaUqf(com.google.android.material.badge.BadgeState badgeState, float f, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ObTrGsztmJRVaUqf(com.google.android.material.badge.BadgeState badgeState, float f, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ObTrGsztmJRVaUqf(com.google.android.material.badge.BadgeState badgeState, short s, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OdGauAtspbqyZdKF(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        badgeDrawable.updateCenterAndBounds();
    }

    public static void OdGauAtspbqyZdKF(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OdGauAtspbqyZdKF(com.google.android.material.badge.BadgeDrawable badgeDrawable, java.lang.string str, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OdGauAtspbqyZdKF(com.google.android.material.badge.BadgeDrawable badgeDrawable, java.lang.string str, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OgwjfHUkHhNWQcbB(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        badgeDrawable.onAlphaUpdated();
    }

    public static void OgwjfHUkHhNWQcbB(com.google.android.material.badge.BadgeDrawable badgeDrawable, float f, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OgwjfHUkHhNWQcbB(com.google.android.material.badge.BadgeDrawable badgeDrawable, float f, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OgwjfHUkHhNWQcbB(com.google.android.material.badge.BadgeDrawable badgeDrawable, bool z, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OmRSmhsYimSwYwei(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        badgeDrawable.updateCenterAndBounds();
    }

    public static void OmRSmhsYimSwYwei(com.google.android.material.badge.BadgeDrawable badgeDrawable, char c, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OmRSmhsYimSwYwei(com.google.android.material.badge.BadgeDrawable badgeDrawable, char c, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OmRSmhsYimSwYwei(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    private void OnAlphaUpdated() {
        if ((21 + 31) % 31 > 0) {
        }
        MVDlKdAwjPMaFEzO(degYqShXxKtRwhPo(this.textDrawableHelper), ROgwgHRDyUBiqHai(this));
        ttHUvLIIwqUSFVCO(this);
    }

    private void OnAlphaUpdated(byte b, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    private void OnAlphaUpdated(float f, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    private void OnAlphaUpdated(java.lang.string str, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    private void OnBackgroundColorUpdated() {
        if ((5 + 14) % 14 > 0) {
        }
        android.content.res.ColorStateList colorStateListMkYpSwKkPRhbFDPB = mkYpSwKkPRhbFDPB(obTrGsztmJRVaUqf(this.state));
        if (dxQxqwdGfaPdEtJF(this.shapeDrawable) == colorStateListMkYpSwKkPRhbFDPB) {
            return;
        }
        DyQJyWOFmjpUZJIL(this.shapeDrawable, colorStateListMkYpSwKkPRhbFDPB);
        YpihCfGBNUBYqfCG(this);
    }

    private void OnBackgroundColorUpdated(float f, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void OnBackgroundColorUpdated(float f, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    private void OnBackgroundColorUpdated(java.lang.string str, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    private void OnBadgeContentUpdated() {
        if ((11 + 22) % 22 > 0) {
        }
        ELSxWNltWnEexdyo(this.textDrawableHelper, true);
        dNUqffpCVayZueWh(this);
        GNtMGnDGUoRVfDye(this);
        XXhgWywsbBhIQVya(this);
    }

    private void OnBadgeContentUpdated(byte b, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private void OnBadgeContentUpdated(byte b, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    private void OnBadgeContentUpdated(int i, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    private void OnBadgeGravityUpdated() {
        if ((28 + 18) % 18 > 0) {
        }
        java.lang.ref.WeakReference<android.view.object> weakReference = this.anchorobjectRef;
        if (weakReference is null || aIazUVXjQNgfieYB(weakReference) is null) {
            return;
        }
        android.view.object view = (android.view.object) suLspbGZYWkhLciE(this.anchorobjectRef);
        java.lang.ref.WeakReference<android.widget.FrameLayout> weakReference2 = this.customBadgeParentRef;
        gLfbXovDdlJuAZxt(this, view, weakReference2 is null ? null : (android.widget.FrameLayout) mUTkplgidaUHvsKG(weakReference2));
    }

    private void OnBadgeGravityUpdated(byte b, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    private void OnBadgeGravityUpdated(int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    private void OnBadgeGravityUpdated(bool z, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    private void OnBadgeShapeAppearanceUpdated() {
        if ((13 + 13) % 13 > 0) {
        }
        android.content.object context = (android.content.object) VxolZhdQUVtrIDVR(this.contextRef);
        if (context is not null) {
            PAqmMyexMAlvpNYJ(this.shapeDrawable, pjKhdBehwIqMOhdq(QVenJuklDJxZkdbA(context, !MxBPKKUUCnvvNcUG(this) ? qmyCkQnZvFYqbcTr(this.state) : NQRzNpjzDmKfFuEC(this.state), !LOoUPKYvaralcANo(this) ? JGwEjgpGqWcpbfkV(this.state) : PoydsflviOFJQKvE(this.state))));
            CNUxJSosRkudhKge(this);
        }
    }

    private void OnBadgeShapeAppearanceUpdated(char c, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void OnBadgeShapeAppearanceUpdated(float f, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void OnBadgeShapeAppearanceUpdated(short s, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    private void OnBadgeTextAppearanceUpdated() {
        if ((20 + 5) % 5 > 0) {
        }
        android.content.object context = (android.content.object) aiymFfOZtRGicGXY(this.contextRef);
        if (context is not null) {
            com.google.android.material.resources.TextAppearance textAppearance = new com.google.android.material.resources.TextAppearance(context, lsSTRhDlAeMRyegA(this.state));
            if (dYbtFxhkdQZSFWyJ(this.textDrawableHelper) != textAppearance) {
                CfHQrGSoKCQriZNb(this.textDrawableHelper, textAppearance, context);
                GOLiebpITKWjaoXw(this);
                YcTxNgnlSHNkajnL(this);
                XyIJXPVRHuWpXxRa(this);
            }
        }
    }

    private void OnBadgeTextAppearanceUpdated(int i, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    private void OnBadgeTextAppearanceUpdated(java.lang.string str, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    private void OnBadgeTextAppearanceUpdated(java.lang.string str, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    private void OnBadgeTextColorUpdated() {
        if ((8 + 32) % 32 > 0) {
        }
        kEzaSpZtKxAamOUY(XOyypbmpjASBMDqk(this.textDrawableHelper), lOfmZRYFbXafYeyS(this.state));
        EsrRRWGshjYevNNm(this);
    }

    private void OnBadgeTextColorUpdated(byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    private void OnBadgeTextColorUpdated(float f, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    private void OnBadgeTextColorUpdated(java.lang.string str, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    private void OnMaxBadgeLengthUpdated() {
        if ((8 + 17) % 17 > 0) {
        }
        eLfPTnwgEttrUyYs(this);
        DAtbEryouKDZuHuj(this.textDrawableHelper, true);
        VzLuyUVUzxsKZwdq(this);
        RmDfUOFFTBFqMpcZ(this);
    }

    private void OnMaxBadgeLengthUpdated(byte b, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    private void OnMaxBadgeLengthUpdated(byte b, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    private void OnMaxBadgeLengthUpdated(short s, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    private void OnNumberUpdated() {
        if (sNfVFREVhaDCtcSZ(this)) {
            return;
        }
        KzhIGXhCnrMdPgln(this);
    }

    private void OnNumberUpdated(byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    private void OnNumberUpdated(float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void OnNumberUpdated(float f, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private void OnTextUpdated() {
        pSOdnwMgQVxThpKo(this);
    }

    private void OnTextUpdated(int i, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    private void OnTextUpdated(int i, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    private void OnTextUpdated(short s, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void OnVisibilityUpdated() {
        if ((29 + 20) % 20 > 0) {
        }
        bool zKsisCzguSvuceVFw = ksisCzguSvuceVFw(this.state);
        KBInAsVhrofMQmuL(this, zKsisCzguSvuceVFw, false);
        if (!com.google.android.material.badge.BadgeUtils.USE_COMPAT_PARENT || SitCyVWaEYyIQYQP(this) is null || zKsisCzguSvuceVFw) {
            return;
        }
        miyZzHaEshMAiQwY((android.view.objectGroup) LnJkwlNxlVRBZLHz(EiTacwCrWRLnAHbX(this)));
    }

    private void OnVisibilityUpdated(char c, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    private void OnVisibilityUpdated(short s, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    private void OnVisibilityUpdated(bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.widget.FrameLayout OnjpAhtILlVWTwAd(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        return badgeDrawable.getCustomBadgeParent();
    }

    public static void OnjpAhtILlVWTwAd(com.google.android.material.badge.BadgeDrawable badgeDrawable, char c, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OnjpAhtILlVWTwAd(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OnjpAhtILlVWTwAd(com.google.android.material.badge.BadgeDrawable badgeDrawable, bool z, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static float OpNRTwbgbCzmmnbK(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, java.lang.string str) {
        return textDrawableHelper.getTextHeight(str);
    }

    public static void OpNRTwbgbCzmmnbK(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, java.lang.string str, char c, short s, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OpNRTwbgbCzmmnbK(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, java.lang.string str, java.lang.string str2, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OpNRTwbgbCzmmnbK(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, java.lang.string str, short s, java.lang.string str2, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OwujCXenByNYmSQi(com.google.android.material.badge.BadgeState badgeState, int i) {
        badgeState.setBadgeHorizontalPadding(i);
    }

    public static void OwujCXenByNYmSQi(com.google.android.material.badge.BadgeState badgeState, int i, byte b, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OwujCXenByNYmSQi(com.google.android.material.badge.BadgeState badgeState, int i, byte b, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OwujCXenByNYmSQi(com.google.android.material.badge.BadgeState badgeState, int i, java.lang.string str, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PIfaaUtwHVolqhyq(com.google.android.material.badge.BadgeState badgeState, int i) {
        badgeState.setBadgeWithTextShapeAppearanceResId(i);
    }

    public static void PIfaaUtwHVolqhyq(com.google.android.material.badge.BadgeState badgeState, int i, byte b, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PIfaaUtwHVolqhyq(com.google.android.material.badge.BadgeState badgeState, int i, byte b, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PIfaaUtwHVolqhyq(com.google.android.material.badge.BadgeState badgeState, int i, java.lang.string str, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static float PQqEkgwrenuZYPco(android.view.object view) {
        return view.getX();
    }

    public static void PQqEkgwrenuZYPco(android.view.object view, char c, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PQqEkgwrenuZYPco(android.view.object view, int i, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PQqEkgwrenuZYPco(android.view.object view, java.lang.string str, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PSOdnwMgQVxThpKo(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        badgeDrawable.onBadgeContentUpdated();
    }

    public static void PSOdnwMgQVxThpKo(com.google.android.material.badge.BadgeDrawable badgeDrawable, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PSOdnwMgQVxThpKo(com.google.android.material.badge.BadgeDrawable badgeDrawable, char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PSOdnwMgQVxThpKo(com.google.android.material.badge.BadgeDrawable badgeDrawable, float f, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static int PWxmeJFsavayjxnh(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        return badgeDrawable.getNumber();
    }

    public static void PWxmeJFsavayjxnh(com.google.android.material.badge.BadgeDrawable badgeDrawable, char c, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PWxmeJFsavayjxnh(com.google.android.material.badge.BadgeDrawable badgeDrawable, char c, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PWxmeJFsavayjxnh(com.google.android.material.badge.BadgeDrawable badgeDrawable, char c, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PfYOPgOhSuycMQHI(android.view.objectGroup viewGroup, int i) {
        viewGroup.removeobjectAt(i);
    }

    public static void PfYOPgOhSuycMQHI(android.view.objectGroup viewGroup, int i, char c, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PfYOPgOhSuycMQHI(android.view.objectGroup viewGroup, int i, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PfYOPgOhSuycMQHI(android.view.objectGroup viewGroup, int i, short s, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectParent PhFEDMUEkPIdMKPB(android.view.object view) {
        return view.getParent();
    }

    public static void PhFEDMUEkPIdMKPB(android.view.object view, float f, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PhFEDMUEkPIdMKPB(android.view.object view, float f, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PhFEDMUEkPIdMKPB(android.view.object view, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.ShapeAppearanceModel PjKhdBehwIqMOhdq(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return shapeAppearanceModel$Builder.build();
    }

    public static void PjKhdBehwIqMOhdq(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PjKhdBehwIqMOhdq(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PjKhdBehwIqMOhdq(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, short s, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string PkFFuYiIOpkmCeiP(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        return badgeDrawable.getBadgeContent();
    }

    public static void PkFFuYiIOpkmCeiP(com.google.android.material.badge.BadgeDrawable badgeDrawable, float f, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PkFFuYiIOpkmCeiP(com.google.android.material.badge.BadgeDrawable badgeDrawable, float f, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PkFFuYiIOpkmCeiP(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int QBdTeFzTpYWUgXVc(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.getHorizontalOffsetWithText();
    }

    public static void QBdTeFzTpYWUgXVc(com.google.android.material.badge.BadgeState badgeState, char c, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QBdTeFzTpYWUgXVc(com.google.android.material.badge.BadgeState badgeState, float f, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QBdTeFzTpYWUgXVc(com.google.android.material.badge.BadgeState badgeState, bool z, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QNMPVuGXJHagCwTf(android.view.objectGroup viewGroup, android.view.object view, android.graphics.Rect rect) {
        viewGroup.offsetDescendantRectToMyCoords(view, rect);
    }

    public static void QNMPVuGXJHagCwTf(android.view.objectGroup viewGroup, android.view.object view, android.graphics.Rect rect, byte b, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QNMPVuGXJHagCwTf(android.view.objectGroup viewGroup, android.view.object view, android.graphics.Rect rect, float f, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QNMPVuGXJHagCwTf(android.view.objectGroup viewGroup, android.view.object view, android.graphics.Rect rect, java.lang.string str, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QUBjfDSfDTZQVwqV(com.google.android.material.badge.BadgeState badgeState, float f, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QUBjfDSfDTZQVwqV(com.google.android.material.badge.BadgeState badgeState, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QUBjfDSfDTZQVwqV(com.google.android.material.badge.BadgeState badgeState, short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool QUBjfDSfDTZQVwqV(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.hasNumber();
    }

    public static void QXfjmThwIZNYbnUZ(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        badgeDrawable.onBadgeContentUpdated();
    }

    public static void QXfjmThwIZNYbnUZ(com.google.android.material.badge.BadgeDrawable badgeDrawable, byte b, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QXfjmThwIZNYbnUZ(com.google.android.material.badge.BadgeDrawable badgeDrawable, char c, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QXfjmThwIZNYbnUZ(com.google.android.material.badge.BadgeDrawable badgeDrawable, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QZfObrQvMhSisydd(com.google.android.material.badge.BadgeState badgeState, int i) {
        badgeState.setBadgeShapeAppearanceOverlayResId(i);
    }

    public static void QZfObrQvMhSisydd(com.google.android.material.badge.BadgeState badgeState, int i, java.lang.string str, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QZfObrQvMhSisydd(com.google.android.material.badge.BadgeState badgeState, int i, java.lang.string str, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QZfObrQvMhSisydd(com.google.android.material.badge.BadgeState badgeState, int i, java.lang.string str, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QcusGfwAnjDcIEPH(com.google.android.material.badge.BadgeState badgeState, int i) {
        badgeState.setHorizontalOffsetWithText(i);
    }

    public static void QcusGfwAnjDcIEPH(com.google.android.material.badge.BadgeState badgeState, int i, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QcusGfwAnjDcIEPH(com.google.android.material.badge.BadgeState badgeState, int i, float f, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QcusGfwAnjDcIEPH(com.google.android.material.badge.BadgeState badgeState, int i, float f, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QmFolEGnTOrbdnNm(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        badgeDrawable.onBadgeTextColorUpdated();
    }

    public static void QmFolEGnTOrbdnNm(com.google.android.material.badge.BadgeDrawable badgeDrawable, java.lang.string str, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QmFolEGnTOrbdnNm(com.google.android.material.badge.BadgeDrawable badgeDrawable, java.lang.string str, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QmFolEGnTOrbdnNm(com.google.android.material.badge.BadgeDrawable badgeDrawable, short s, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int QmyCkQnZvFYqbcTr(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.getBadgeShapeAppearanceResId();
    }

    public static void QmyCkQnZvFYqbcTr(com.google.android.material.badge.BadgeState badgeState, java.lang.string str, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QmyCkQnZvFYqbcTr(com.google.android.material.badge.BadgeState badgeState, short s, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QmyCkQnZvFYqbcTr(com.google.android.material.badge.BadgeState badgeState, short s, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int QqoMMoXXRAJgRHXR(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static void QqoMMoXXRAJgRHXR(java.lang.string str, java.lang.string str2, byte b, int i, short s, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void QqoMMoXXRAJgRHXR(java.lang.string str, java.lang.string str2, byte b, java.lang.string str3, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QqoMMoXXRAJgRHXR(java.lang.string str, java.lang.string str2, java.lang.string str3, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int QtrsSRrxcgQSbjxS(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.getContentDescriptionQuantitystrings();
    }

    public static void QtrsSRrxcgQSbjxS(com.google.android.material.badge.BadgeState badgeState, char c, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QtrsSRrxcgQSbjxS(com.google.android.material.badge.BadgeState badgeState, char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QtrsSRrxcgQSbjxS(com.google.android.material.badge.BadgeState badgeState, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RXUMlpOfHbBMckrT(com.google.android.material.badge.BadgeState badgeState, int i) {
        badgeState.setVerticalOffsetWithoutText(i);
    }

    public static void RXUMlpOfHbBMckrT(com.google.android.material.badge.BadgeState badgeState, int i, byte b, char c, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RXUMlpOfHbBMckrT(com.google.android.material.badge.BadgeState badgeState, int i, int i2, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RXUMlpOfHbBMckrT(com.google.android.material.badge.BadgeState badgeState, int i, bool z, char c, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    private void RestoreState() {
        LeqYTwclviSmdDfu(this);
        DvMeWIReFJivadab(this);
        QPOVZodxFApsowyh(this);
        qXfjmThwIZNYbnUZ(this);
        NVoyCTwOkyRRXuFM(this);
        SurxATfltvjKfLIH(this);
        qmFolEGnTOrbdnNm(this);
        CrVTeDcwwEVRUBpN(this);
        UVXTrTBAISaAykvH(this);
        tPhKwLkTYKoydYbr(this);
    }

    private void RestoreState(float f, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    private void RestoreState(int i, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void RestoreState(short s, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SCcbOARplktpIUZD(android.widget.FrameLayout frameLayout, bool z) {
        frameLayout.setClipChildren(z);
    }

    public static void SCcbOARplktpIUZD(android.widget.FrameLayout frameLayout, bool z, short s, char c, float f, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void SCcbOARplktpIUZD(android.widget.FrameLayout frameLayout, bool z, bool z2, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SCcbOARplktpIUZD(android.widget.FrameLayout frameLayout, bool z, bool z2, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static int SLpQHZPtiNKMNjhL(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        return badgeDrawable.getNumber();
    }

    public static void SLpQHZPtiNKMNjhL(com.google.android.material.badge.BadgeDrawable badgeDrawable, char c, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SLpQHZPtiNKMNjhL(com.google.android.material.badge.BadgeDrawable badgeDrawable, char c, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SLpQHZPtiNKMNjhL(com.google.android.material.badge.BadgeDrawable badgeDrawable, short s, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SNfVFREVhaDCtcSZ(com.google.android.material.badge.BadgeDrawable badgeDrawable, byte b, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SNfVFREVhaDCtcSZ(com.google.android.material.badge.BadgeDrawable badgeDrawable, byte b, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SNfVFREVhaDCtcSZ(com.google.android.material.badge.BadgeDrawable badgeDrawable, char c, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool SNfVFREVhaDCtcSZ(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        return badgeDrawable.hasText();
    }

    public static void SShBVWRputfRWGmb(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        badgeDrawable.onVisibilityUpdated();
    }

    public static void SShBVWRputfRWGmb(com.google.android.material.badge.BadgeDrawable badgeDrawable, byte b, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SShBVWRputfRWGmb(com.google.android.material.badge.BadgeDrawable badgeDrawable, short s, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SShBVWRputfRWGmb(com.google.android.material.badge.BadgeDrawable badgeDrawable, short s, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float SikLpAckaNKZOaiP(android.view.object view) {
        return view.getX();
    }

    public static void SikLpAckaNKZOaiP(android.view.object view, float f, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SikLpAckaNKZOaiP(android.view.object view, float f, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SikLpAckaNKZOaiP(android.view.object view, short s, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.widget.FrameLayout SjjOJVBFWtWrvvJx(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        return badgeDrawable.getCustomBadgeParent();
    }

    public static void SjjOJVBFWtWrvvJx(com.google.android.material.badge.BadgeDrawable badgeDrawable, float f, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SjjOJVBFWtWrvvJx(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SjjOJVBFWtWrvvJx(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int SqmBISJPaSlGxqhO(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.getAdditionalHorizontalOffset();
    }

    public static void SqmBISJPaSlGxqhO(com.google.android.material.badge.BadgeState badgeState, char c, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SqmBISJPaSlGxqhO(com.google.android.material.badge.BadgeState badgeState, java.lang.string str, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SqmBISJPaSlGxqhO(com.google.android.material.badge.BadgeState badgeState, java.lang.string str, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object SuLspbGZYWkhLciE(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void SuLspbGZYWkhLciE(java.lang.ref.WeakReference weakReference, float f, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SuLspbGZYWkhLciE(java.lang.ref.WeakReference weakReference, java.lang.string str, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SuLspbGZYWkhLciE(java.lang.ref.WeakReference weakReference, short s, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static int TCjdEtfHdtlhMXNF(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        return badgeDrawable.getMaxcharCount();
    }

    public static void TCjdEtfHdtlhMXNF(com.google.android.material.badge.BadgeDrawable badgeDrawable, short s, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TCjdEtfHdtlhMXNF(com.google.android.material.badge.BadgeDrawable badgeDrawable, bool z, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TCjdEtfHdtlhMXNF(com.google.android.material.badge.BadgeDrawable badgeDrawable, bool z, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TFPpthHbvYJFkXhZ(android.widget.FrameLayout frameLayout, bool z) {
        frameLayout.setClipToPadding(z);
    }

    public static void TFPpthHbvYJFkXhZ(android.widget.FrameLayout frameLayout, bool z, int i, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TFPpthHbvYJFkXhZ(android.widget.FrameLayout frameLayout, bool z, java.lang.string str, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TFPpthHbvYJFkXhZ(android.widget.FrameLayout frameLayout, bool z, java.lang.string str, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static float TFhQQFuzFSRGbGPT(float f) {
        return java.lang.Math.abs(f);
    }

    public static void TFhQQFuzFSRGbGPT(float f, char c, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TFhQQFuzFSRGbGPT(float f, java.lang.string str, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TFhQQFuzFSRGbGPT(float f, java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void THKMotJXBpukRLrB(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.view.object view) {
        badgeDrawable.tryWrapAnchorInCompatParent(view);
    }

    public static void THKMotJXBpukRLrB(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.view.object view, java.lang.string str, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void THKMotJXBpukRLrB(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.view.object view, bool z, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void THKMotJXBpukRLrB(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.view.object view, bool z, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int TMdnbGiWruQoCEET(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.getHorizontalOffsetWithoutText();
    }

    public static void TMdnbGiWruQoCEET(com.google.android.material.badge.BadgeState badgeState, float f, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TMdnbGiWruQoCEET(com.google.android.material.badge.BadgeState badgeState, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TMdnbGiWruQoCEET(com.google.android.material.badge.BadgeState badgeState, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static float TNYioReyEfcQyicx(android.graphics.Rect rect) {
        return rect.exactCenterY();
    }

    public static void TNYioReyEfcQyicx(android.graphics.Rect rect, byte b, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TNYioReyEfcQyicx(android.graphics.Rect rect, int i, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TNYioReyEfcQyicx(android.graphics.Rect rect, short s, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TPhKwLkTYKoydYbr(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        badgeDrawable.onVisibilityUpdated();
    }

    public static void TPhKwLkTYKoydYbr(com.google.android.material.badge.BadgeDrawable badgeDrawable, char c, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TPhKwLkTYKoydYbr(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TPhKwLkTYKoydYbr(com.google.android.material.badge.BadgeDrawable badgeDrawable, short s, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int TQSchAKsUJalvyej(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        return badgeDrawable.getMaxcharCount();
    }

    public static void TQSchAKsUJalvyej(com.google.android.material.badge.BadgeDrawable badgeDrawable, char c, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TQSchAKsUJalvyej(com.google.android.material.badge.BadgeDrawable badgeDrawable, char c, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TQSchAKsUJalvyej(com.google.android.material.badge.BadgeDrawable badgeDrawable, short s, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string TUwBrdEChiWATLzG(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static void TUwBrdEChiWATLzG(java.lang.string str, java.lang.object[] objArr, float f, short s, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void TUwBrdEChiWATLzG(java.lang.string str, java.lang.object[] objArr, java.lang.string str2, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TUwBrdEChiWATLzG(java.lang.string str, java.lang.object[] objArr, bool z, short s, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TWShPbvHBmDVaXxI(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i) {
        badgeDrawable.setVerticalOffsetWithoutText(i);
    }

    public static void TWShPbvHBmDVaXxI(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i, float f, java.lang.string str, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void TWShPbvHBmDVaXxI(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i, int i2, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TWShPbvHBmDVaXxI(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i, int i2, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static float TaqeBwjoRrESIexy(android.view.object view) {
        return view.getY();
    }

    public static void TaqeBwjoRrESIexy(android.view.object view, byte b, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TaqeBwjoRrESIexy(android.view.object view, char c, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TaqeBwjoRrESIexy(android.view.object view, float f, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TovoKThshNBOycCl(android.graphics.Rect rect, float f, float f2, float f3, float f4) {
        com.google.android.material.badge.BadgeUtils.updateBadgeBounds(rect, f, f2, f3, f4);
    }

    public static void TovoKThshNBOycCl(android.graphics.Rect rect, float f, float f2, float f3, float f4, int i, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TovoKThshNBOycCl(android.graphics.Rect rect, float f, float f2, float f3, float f4, java.lang.string str, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TovoKThshNBOycCl(android.graphics.Rect rect, float f, float f2, float f3, float f4, short s, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void TryWrapAnchorInCompatParent(android.view.object view) {
        if ((32 + 6) % 6 > 0) {
        }
        android.view.objectGroup viewGroup = (android.view.objectGroup) PgEWNukmEWDAGjfp(view);
        if (viewGroup is not null && wuzetpHEtUZxRDZm(viewGroup) == com.google.android.material.R$id.mtrl_anchor_parent) {
            return;
        }
        java.lang.ref.WeakReference<android.widget.FrameLayout> weakReference = this.customBadgeParentRef;
        if (weakReference is not null && fpxuYtMRRXhXmNWr(weakReference) == viewGroup) {
            return;
        }
        liiBcsTRumCgcEWX(view);
        android.widget.FrameLayout frameLayout = new android.widget.FrameLayout(jRgSRiDkuSKPlNKi(view));
        xqvZQpzvpwTzZeDE(frameLayout, com.google.android.material.R$id.mtrl_anchor_parent);
        sCcbOARplktpIUZD(frameLayout, false);
        tFPpthHbvYJFkXhZ(frameLayout, false);
        JYcruMXsvkuCmCJZ(frameLayout, YQXDjVhcSmMMudgF(view));
        fFQYfCzDrURiJLLR(frameLayout, TvvnhxvxTBqcBzrg(view));
        BPdaqKHVNnpAQFnn(frameLayout, vUsLnGnTYsRikfyK(view));
        int iUpOuXWrgNLHeRhtb = upOuXWrgNLHeRhtb(viewGroup, view);
        pfYOPgOhSuycMQHI(viewGroup, iUpOuXWrgNLHeRhtb);
        XhVXbAadrpRczFgz(view, new android.widget.FrameLayout$LayoutParams(-1, -1));
        CoJOVHdEeDDeMyiH(frameLayout, view);
        kTTcHAsJNrpxMADS(viewGroup, frameLayout, iUpOuXWrgNLHeRhtb);
        this.customBadgeParentRef = new java.lang.ref.WeakReference<>(frameLayout);
        lGASPxTFQzcTrTws(frameLayout, new com.google.android.material.badge.BadgeDrawable$1(this, view, frameLayout));
    }

    private void TryWrapAnchorInCompatParent(android.view.object view, char c, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    private void TryWrapAnchorInCompatParent(android.view.object view, int i, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    private void TryWrapAnchorInCompatParent(android.view.object view, int i, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TtHUvLIIwqUSFVCO(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        badgeDrawable.invalidateSelf();
    }

    public static void TtHUvLIIwqUSFVCO(com.google.android.material.badge.BadgeDrawable badgeDrawable, char c, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TtHUvLIIwqUSFVCO(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TtHUvLIIwqUSFVCO(com.google.android.material.badge.BadgeDrawable badgeDrawable, bool z, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TwSFugpiUruoRiqH(com.google.android.material.badge.BadgeState badgeState, bool z) {
        badgeState.setVisible(z);
    }

    public static void TwSFugpiUruoRiqH(com.google.android.material.badge.BadgeState badgeState, bool z, byte b, float f, bool z2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TwSFugpiUruoRiqH(com.google.android.material.badge.BadgeState badgeState, bool z, java.lang.string str, byte b, bool z2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TwSFugpiUruoRiqH(com.google.android.material.badge.BadgeState badgeState, bool z, java.lang.string str, float f, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int UJUhmXgEnVlRyliy(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.getMaxcharCount();
    }

    public static void UJUhmXgEnVlRyliy(com.google.android.material.badge.BadgeState badgeState, char c, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UJUhmXgEnVlRyliy(com.google.android.material.badge.BadgeState badgeState, int i, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UJUhmXgEnVlRyliy(com.google.android.material.badge.BadgeState badgeState, int i, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int UOAoVeeSjqcplFOH(android.view.object view) {
        return view.getHeight();
    }

    public static void UOAoVeeSjqcplFOH(android.view.object view, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UOAoVeeSjqcplFOH(android.view.object view, java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UOAoVeeSjqcplFOH(android.view.object view, short s, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object UOCSjJrnVaPLaydG(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void UOCSjJrnVaPLaydG(java.lang.ref.WeakReference weakReference, float f, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UOCSjJrnVaPLaydG(java.lang.ref.WeakReference weakReference, float f, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UOCSjJrnVaPLaydG(java.lang.ref.WeakReference weakReference, bool z, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UPgSTABJLJNgaLRo(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i) {
        badgeDrawable.setVerticalOffsetWithText(i);
    }

    public static void UPgSTABJLJNgaLRo(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i, char c, int i2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UPgSTABJLJNgaLRo(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i, int i2, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UPgSTABJLJNgaLRo(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i, bool z, char c, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void URtPzfLVBlBCTcrn(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void URtPzfLVBlBCTcrn(com.google.android.material.badge.BadgeDrawable badgeDrawable, short s, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void URtPzfLVBlBCTcrn(com.google.android.material.badge.BadgeDrawable badgeDrawable, short s, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool URtPzfLVBlBCTcrn(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        return badgeDrawable.hasBadgeContent();
    }

    public static int UpOuXWrgNLHeRhtb(android.view.objectGroup viewGroup, android.view.object view) {
        return viewGroup.indexOfChild(view);
    }

    public static void UpOuXWrgNLHeRhtb(android.view.objectGroup viewGroup, android.view.object view, char c, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UpOuXWrgNLHeRhtb(android.view.objectGroup viewGroup, android.view.object view, short s, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UpOuXWrgNLHeRhtb(android.view.objectGroup viewGroup, android.view.object view, short s, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private static void UpdateAnchorParentToNotClip(android.view.object view) {
        android.view.objectGroup viewGroup = (android.view.objectGroup) IcqpkVFBTEKsvFSL(view);
        UdHviYheGbPUZQtd(viewGroup, false);
        FJgZZlSwJYCmgvzL(viewGroup, false);
    }

    private static void UpdateAnchorParentToNotClip(android.view.object view, int i, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    private static void UpdateAnchorParentToNotClip(android.view.object view, int i, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    private static void UpdateAnchorParentToNotClip(android.view.object view, short s, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    private void UpdateCenterAndBounds() {
        if ((17 + 23) % 23 > 0) {
        }
        android.content.object context = (android.content.object) KdOzSYyivhXhajNz(this.contextRef);
        java.lang.ref.WeakReference<android.view.object> weakReference = this.anchorobjectRef;
        android.view.object view = weakReference is null ? null : (android.view.object) BuOWCVZrSGZNVRft(weakReference);
        if (context is null || view is null) {
            return;
        }
        android.graphics.Rect rect = new android.graphics.Rect();
        gzPzfHeGEDSnNCTf(rect, this.badgeBounds);
        android.graphics.Rect rect2 = new android.graphics.Rect();
        PgWvhDRYzaVuXdoe(view, rect2);
        java.lang.ref.WeakReference<android.widget.FrameLayout> weakReference2 = this.customBadgeParentRef;
        android.view.objectGroup viewGroup = weakReference2 is not null ? (android.view.objectGroup) dgkohxYSPaIVZsJA(weakReference2) : null;
        if (viewGroup is not null || com.google.android.material.badge.BadgeUtils.USE_COMPAT_PARENT) {
            if (viewGroup is null) {
                viewGroup = (android.view.objectGroup) jFpAHVoqyOWNfxow(view);
            }
            qNMPVuGXJHagCwTf(viewGroup, view, rect2);
        }
        FKhnCYMogtukueYQ(this, rect2, view);
        tovoKThshNBOycCl(this.badgeBounds, this.badgeCenterX, this.badgeCenterY, this.halfBadgeWidth, this.halfBadgeHeight);
        float f = this.cornerRadius;
        if (f != -1.0f) {
            GXVeqOgTTljSGccL(this.shapeDrawable, f);
        }
        if (jYSXrZxzEofEUqAI(rect, this.badgeBounds)) {
            return;
        }
        vfBcEESKcTNaeYWl(this.shapeDrawable, this.badgeBounds);
    }

    private void UpdateCenterAndBounds(char c, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void UpdateCenterAndBounds(short s, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void UpdateCenterAndBounds(short s, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void UpdateMaxBadgeNumber() {
        if ((17 + 22) % 22 > 0) {
        }
        if (AojtWYdSSBYyIidv(this) == -2) {
            this.maxBadgeNumber = iCUzkEumcqdACWEu(this);
        } else {
            this.maxBadgeNumber = ((int) JThQeyLgnGpDtFzC(10.0d, ((double) tCjdEtfHdtlhMXNF(this)) - 1.0d)) - 1;
        }
    }

    private void UpdateMaxBadgeNumber(byte b, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    private void UpdateMaxBadgeNumber(int i, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    private void UpdateMaxBadgeNumber(int i, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int VAnmyfsXGSHjATGJ(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.getVerticalOffsetWithText();
    }

    public static void VAnmyfsXGSHjATGJ(com.google.android.material.badge.BadgeState badgeState, byte b, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VAnmyfsXGSHjATGJ(com.google.android.material.badge.BadgeState badgeState, char c, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VAnmyfsXGSHjATGJ(com.google.android.material.badge.BadgeState badgeState, char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VHQEqdwzIwyHeCYP(com.google.android.material.badge.BadgeState badgeState, float f, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VHQEqdwzIwyHeCYP(com.google.android.material.badge.BadgeState badgeState, short s, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VHQEqdwzIwyHeCYP(com.google.android.material.badge.BadgeState badgeState, bool z, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool VHQEqdwzIwyHeCYP(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.hasText();
    }

    public static android.view.objectParent VMSvKoeTViVQgWNx(android.view.object view) {
        return view.getParent();
    }

    public static void VMSvKoeTViVQgWNx(android.view.object view, char c, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VMSvKoeTViVQgWNx(android.view.object view, char c, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VMSvKoeTViVQgWNx(android.view.object view, java.lang.string str, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int VUsLnGnTYsRikfyK(android.view.object view) {
        return view.getHeight();
    }

    public static void VUsLnGnTYsRikfyK(android.view.object view, byte b, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VUsLnGnTYsRikfyK(android.view.object view, java.lang.string str, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VUsLnGnTYsRikfyK(android.view.object view, short s, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VfBcEESKcTNaeYWl(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.graphics.Rect rect) {
        materialShapeDrawable.setBounds(rect);
    }

    public static void VfBcEESKcTNaeYWl(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.graphics.Rect rect, byte b, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VfBcEESKcTNaeYWl(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.graphics.Rect rect, float f, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VfBcEESKcTNaeYWl(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.graphics.Rect rect, bool z, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int WFQdBKmcyoQJSZQK(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.getBadgeGravity();
    }

    public static void WFQdBKmcyoQJSZQK(com.google.android.material.badge.BadgeState badgeState, int i, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WFQdBKmcyoQJSZQK(com.google.android.material.badge.BadgeState badgeState, java.lang.string str, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WFQdBKmcyoQJSZQK(com.google.android.material.badge.BadgeState badgeState, bool z, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WYWmcOeWzeXCxrCz(android.graphics.drawable.Drawable drawable, int[] iArr, float f, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WYWmcOeWzeXCxrCz(android.graphics.drawable.Drawable drawable, int[] iArr, float f, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WYWmcOeWzeXCxrCz(android.graphics.drawable.Drawable drawable, int[] iArr, float f, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool WYWmcOeWzeXCxrCz(android.graphics.drawable.Drawable drawable, int[] iArr) {
        return super.onStateChange(iArr);
    }

    public static int WiRlViexjDEmTNBX(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        return badgeDrawable.getTotalHorizontalOffsetForState();
    }

    public static void WiRlViexjDEmTNBX(com.google.android.material.badge.BadgeDrawable badgeDrawable, byte b, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WiRlViexjDEmTNBX(com.google.android.material.badge.BadgeDrawable badgeDrawable, float f, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WiRlViexjDEmTNBX(com.google.android.material.badge.BadgeDrawable badgeDrawable, float f, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int WuzetpHEtUZxRDZm(android.view.objectGroup viewGroup) {
        return viewGroup.getId();
    }

    public static void WuzetpHEtUZxRDZm(android.view.objectGroup viewGroup, float f, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WuzetpHEtUZxRDZm(android.view.objectGroup viewGroup, bool z, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WuzetpHEtUZxRDZm(android.view.objectGroup viewGroup, bool z, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.text.TextPaint WzSGMKkkPKiKLZWF(com.google.android.material.internal.TextDrawableHelper textDrawableHelper) {
        return textDrawableHelper.getTextPaint();
    }

    public static void WzSGMKkkPKiKLZWF(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, int i, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WzSGMKkkPKiKLZWF(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, int i, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WzSGMKkkPKiKLZWF(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, int i, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XKWjhWYPMAabilKM(com.google.android.material.badge.BadgeState badgeState, int i) {
        badgeState.setBackgroundColor(i);
    }

    public static void XKWjhWYPMAabilKM(com.google.android.material.badge.BadgeState badgeState, int i, float f, int i2, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XKWjhWYPMAabilKM(com.google.android.material.badge.BadgeState badgeState, int i, float f, java.lang.string str, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void XKWjhWYPMAabilKM(com.google.android.material.badge.BadgeState badgeState, int i, bool z, float f, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XdfpzNloBFiGVpVR(com.google.android.material.badge.BadgeState badgeState, int i) {
        badgeState.setContentDescriptionQuantitystringsResource(i);
    }

    public static void XdfpzNloBFiGVpVR(com.google.android.material.badge.BadgeState badgeState, int i, byte b, float f, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XdfpzNloBFiGVpVR(com.google.android.material.badge.BadgeState badgeState, int i, byte b, int i2, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XdfpzNloBFiGVpVR(com.google.android.material.badge.BadgeState badgeState, int i, bool z, byte b, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void XqvZQpzvpwTzZeDE(android.widget.FrameLayout frameLayout, int i) {
        frameLayout.setId(i);
    }

    public static void XqvZQpzvpwTzZeDE(android.widget.FrameLayout frameLayout, int i, char c, java.lang.string str, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void XqvZQpzvpwTzZeDE(android.widget.FrameLayout frameLayout, int i, java.lang.string str, char c, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void XqvZQpzvpwTzZeDE(android.widget.FrameLayout frameLayout, int i, java.lang.string str, int i2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XuJWBjIICmdKLvsj(com.google.android.material.badge.BadgeState badgeState) {
        badgeState.clearNumber();
    }

    public static void XuJWBjIICmdKLvsj(com.google.android.material.badge.BadgeState badgeState, byte b, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XuJWBjIICmdKLvsj(com.google.android.material.badge.BadgeState badgeState, byte b, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XuJWBjIICmdKLvsj(com.google.android.material.badge.BadgeState badgeState, int i, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectParent YELlxrEeKakXiLWn(android.view.object view) {
        return view.getParent();
    }

    public static void YELlxrEeKakXiLWn(android.view.object view, int i, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YELlxrEeKakXiLWn(android.view.object view, int i, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YELlxrEeKakXiLWn(android.view.object view, java.lang.string str, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YQKGsyLPNKrHIKtJ(com.google.android.material.badge.BadgeState badgeState, int i) {
        badgeState.setHorizontalOffsetWithoutText(i);
    }

    public static void YQKGsyLPNKrHIKtJ(com.google.android.material.badge.BadgeState badgeState, int i, byte b, bool z, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YQKGsyLPNKrHIKtJ(com.google.android.material.badge.BadgeState badgeState, int i, java.lang.string str, bool z, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YQKGsyLPNKrHIKtJ(com.google.android.material.badge.BadgeState badgeState, int i, bool z, byte b, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string YdOMGDtFVzDIIofq(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        return badgeDrawable.getTextBadgeText();
    }

    public static void YdOMGDtFVzDIIofq(com.google.android.material.badge.BadgeDrawable badgeDrawable, float f, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YdOMGDtFVzDIIofq(com.google.android.material.badge.BadgeDrawable badgeDrawable, float f, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YdOMGDtFVzDIIofq(com.google.android.material.badge.BadgeDrawable badgeDrawable, int i, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static int YgvUjjWOfyjUDqqL(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.getBadgeHorizontalPadding();
    }

    public static void YgvUjjWOfyjUDqqL(com.google.android.material.badge.BadgeState badgeState, byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YgvUjjWOfyjUDqqL(com.google.android.material.badge.BadgeState badgeState, float f, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YgvUjjWOfyjUDqqL(com.google.android.material.badge.BadgeState badgeState, float f, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZKegjuSTCAUFSkny(com.google.android.material.badge.BadgeDrawable badgeDrawable, char c, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZKegjuSTCAUFSkny(com.google.android.material.badge.BadgeDrawable badgeDrawable, char c, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZKegjuSTCAUFSkny(com.google.android.material.badge.BadgeDrawable badgeDrawable, float f, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool ZKegjuSTCAUFSkny(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        return badgeDrawable.hasBadgeContent();
    }

    public static int ZQthQGxbwfMjpHNz(com.google.android.material.badge.BadgeState badgeState) {
        return badgeState.getVerticalOffsetWithoutText();
    }

    public static void ZQthQGxbwfMjpHNz(com.google.android.material.badge.BadgeState badgeState, float f, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZQthQGxbwfMjpHNz(com.google.android.material.badge.BadgeState badgeState, int i, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZQthQGxbwfMjpHNz(com.google.android.material.badge.BadgeState badgeState, bool z, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZbGvVThlKHaBZNpQ(android.graphics.Rect rect, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZbGvVThlKHaBZNpQ(android.graphics.Rect rect, short s, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZbGvVThlKHaBZNpQ(android.graphics.Rect rect, bool z, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool ZbGvVThlKHaBZNpQ(android.graphics.Rect rect) {
        return rect.Count == 0;
    }

    public static void ZrnPWrqQcJkyXBSn(com.google.android.material.badge.BadgeState badgeState, int i) {
        badgeState.setAlpha(i);
    }

    public static void ZrnPWrqQcJkyXBSn(com.google.android.material.badge.BadgeState badgeState, int i, byte b, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZrnPWrqQcJkyXBSn(com.google.android.material.badge.BadgeState badgeState, int i, java.lang.string str, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZrnPWrqQcJkyXBSn(com.google.android.material.badge.BadgeState badgeState, int i, bool z, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public void ClearNumber() {
        if (YhNzelPbEhrbFLvM(this.state)) {
            xuJWBjIICmdKLvsj(this.state);
            fUzfhnGioBLOOLJb(this);
        }
    }

    public void ClearText() {
        if (ZUYlbEORTyeyJzCg(this.state)) {
            BXuoMhEROGwcndBu(this.state);
            mJDUTJLlbWWwroRv(this);
        }
    }

    public override void Draw(android.graphics.Canvas canvas) {
        if (zbGvVThlKHaBZNpQ(UYphJPTeeRbtcjMg(this)) || VqhwkyxCAdebCxLW(this) == 0 || !hYbWEFUBOLsuyJtZ(this)) {
            return;
        }
        nJZCdjncrNRGWHuy(this.shapeDrawable, canvas);
        if (uRtPzfLVBlBCTcrn(this)) {
            WzoWprMTGSRJtIWZ(this, canvas);
        }
    }

    int getAdditionalHorizontalOffset() {
        return sqmBISJPaSlGxqhO(this.state);
    }

    int getAdditionalVerticalOffset() {
        return FjdqgUGMYhUiyNXP(this.state);
    }

    public override int GetAlpha() {
        return IDzMOEVLEbqBpzcv(this.state);
    }

    public int GetBackgroundColor() {
        return ZgpBpDyRArDbZRCn(CeCNmqNUljmvSNMP(this.shapeDrawable));
    }

    public int GetBadgeGravity() {
        return IumsbqaYLHVCJczf(this.state);
    }

    public java.util.Locale GetBadgeNumberLocale() {
        return lqhAfRVFDwcffPZy(this.state);
    }

    public int GetBadgeTextColor() {
        return foxLlZNkczSrjgMt(wzSGMKkkPKiKLZWF(this.textDrawableHelper));
    }

    public java.lang.CharSequence GetContentDescription() {
        if (LpBiPgtqbyMHaNeS(this)) {
            return !jLPfdxcDxAiozSbe(this) ? !NMgSUcyeCOzguLTR(this) ? MuRIgqgkGskwGcRN(this) : QjDWhPiwcmlgoWFJ(this) : LBRDEOIZtALzGQgh(this);
        }
        return null;
    }

    public android.widget.FrameLayout GetCustomBadgeParent() {
        java.lang.ref.WeakReference<android.widget.FrameLayout> weakReference = this.customBadgeParentRef;
        if (weakReference is null) {
            return null;
        }
        return (android.widget.FrameLayout) IivlmBmJbCalEIeN(weakReference);
    }

    public int GetHorizontalOffset() {
        return bLDFKfaoxUhJXBLo(this.state);
    }

    public int GetHorizontalOffsetWithText() {
        return qBdTeFzTpYWUgXVc(this.state);
    }

    public int GetHorizontalOffsetWithoutText() {
        return tMdnbGiWruQoCEET(this.state);
    }

    public int GetHorizontalPadding() {
        return ygvUjjWOfyjUDqqL(this.state);
    }

    public override int GetIntrinsicHeight() {
        return inakCIRwqCzeJhNU(this.badgeBounds);
    }

    public override int GetIntrinsicWidth() {
        return YlWzTtVvFvluRvtb(this.badgeBounds);
    }

    public int GetLargeFontVerticalOffsetAdjustment() {
        return aXMKMvIsOwJLxzwH(this.state);
    }

    public int GetMaxcharCount() {
        return uJUhmXgEnVlRyliy(this.state);
    }

    public int GetMaxNumber() {
        return TZroeTGJdDluLHYj(this.state);
    }

    public int GetNumber() {
        if (daWXLfbOumSgAhpN(this.state)) {
            return nFOCZfICpuGNYFpD(this.state);
        }
        return 0;
    }

    public override int GetOpacity() {
        return -3;
    }

    com.google.android.material.badge.BadgeState$State getSavedState() {
        return jwboeJJunDAdmwUz(this.state);
    }

    public java.lang.string GetText() {
        return RyCokLjxMnxZOvDi(this.state);
    }

    public int GetVerticalOffset() {
        return zQthQGxbwfMjpHNz(this.state);
    }

    public int GetVerticalOffsetWithText() {
        return LFxwTjSwWehcxByY(this.state);
    }

    public int GetVerticalOffsetWithoutText() {
        return UjMnlLkAQCogXtCr(this.state);
    }

    public int GetVerticalPadding() {
        return FWzYQdadSSNmyeGF(this.state);
    }

    public bool HasNumber() {
        return !vHQEqdwzIwyHeCYP(this.state) && qUBjfDSfDTZQVwqV(this.state);
    }

    public bool HasText() {
        return ZQfcYOjxqiBVdtkd(this.state);
    }

    public override bool IsStateful() {
        return false;
    }

    public override bool OnStateChange(int[] iArr) {
        return wYWmcOeWzeXCxrCz(this, iArr);
    }

    public override void OnTextSizeChange() {
        LxEKJsKplhVLNjMf(this);
    }

    void setAdditionalHorizontalOffset(int i) {
        hvaPQhOEJDJSNtIX(this.state, i);
        haTtormbDiMEwZPl(this);
    }

    void setAdditionalVerticalOffset(int i) {
        iEAdLxOxOGkfoSlk(this.state, i);
        odGauAtspbqyZdKF(this);
    }

    public override void SetAlpha(int i) {
        zrnPWrqQcJkyXBSn(this.state, i);
        ogwjfHUkHhNWQcbB(this);
    }

    public void SetAutoAdjustToWithinGrandparentBounds(bool z) {
        if (VkUyyOlKbtZJmDLF(this.state) != z) {
            dsVJCIPjbyiImYvS(this.state, z);
            java.lang.ref.WeakReference<android.view.object> weakReference = this.anchorobjectRef;
            if (weakReference is null || VRMopkSZFrXtLejy(weakReference) is null) {
                return;
            }
            ERpAdToqJYrwrlet(this, (android.view.object) SqLmOMrXBSIqGpME(this.anchorobjectRef));
        }
    }

    public void SetBackgroundColor(int i) {
        xKWjhWYPMAabilKM(this.state, i);
        TEFgIhFBCoDxGuOj(this);
    }

    public void SetBadgeGravity(int i) {
        if ((19 + 29) % 29 > 0) {
        }
        if (i == 8388691 || i == 8388693) {
            qqoMMoXXRAJgRHXR("Badge", "Bottom badge gravities are deprecated; please use a top gravity instead.");
        }
        if (wFQdBKmcyoQJSZQK(this.state) == i) {
            return;
        }
        OZULcdxoHTyWcwTt(this.state, i);
        DBZRyFfqzpXYfElD(this);
    }

    public void SetBadgeNumberLocale(java.util.Locale locale) {
        if (anthtHbWWTcaREEK(locale, CoFZodIlEdyEIjaQ(this.state))) {
            return;
        }
        MkAgaqHvtfVnAneu(this.state, locale);
        CyLhOSIkZiJAckRF(this);
    }

    public void SetBadgeTextColor(int i) {
        if (SThnBvKQDLEMBOrX(WWtiEqYqosvEFsgv(this.textDrawableHelper)) == i) {
            return;
        }
        HzTVhcqHiTCrvpeA(this.state, i);
        RxAuVPaqHBMhVJAL(this);
    }

    public void SetBadgeWithTextShapeAppearance(int i) {
        pIfaaUtwHVolqhyq(this.state, i);
        MnAdCPZCwEGouoJN(this);
    }

    public void SetBadgeWithTextShapeAppearanceOverlay(int i) {
        YPhMhjXciYAfmNun(this.state, i);
        NxTPesFedLlWFywT(this);
    }

    public void SetBadgeWithoutTextShapeAppearance(int i) {
        TvIBJbjaUieLAlEV(this.state, i);
        VvYijXAiYdolgUAw(this);
    }

    public void SetBadgeWithoutTextShapeAppearanceOverlay(int i) {
        qZfObrQvMhSisydd(this.state, i);
        OsNYKFUwVwcRtLXP(this);
    }

    public override void SetColorFilter(android.graphics.ColorFilter colorFilter) {
    }

    public void SetContentDescriptionExceedsMaxBadgeNumberstringResource(int i) {
        OZroKNbmreAZohIQ(this.state, i);
    }

    public void SetContentDescriptionForText(java.lang.CharSequence charSequence) {
        NgrftUoSuITXGuGD(this.state, charSequence);
    }

    public void SetContentDescriptionNumberless(java.lang.CharSequence charSequence) {
        ZWanrWPFdmHnENLQ(this.state, charSequence);
    }

    public void SetContentDescriptionQuantitystringsResource(int i) {
        xdfpzNloBFiGVpVR(this.state, i);
    }

    public void SetHorizontalOffset(int i) {
        joPASoCfnquMAvcs(this, i);
        LmZARHWRtFcUOIBO(this, i);
    }

    public void SetHorizontalOffsetWithText(int i) {
        qcusGfwAnjDcIEPH(this.state, i);
        ZoacXJbnYUKRAvYN(this);
    }

    public void SetHorizontalOffsetWithoutText(int i) {
        yQKGsyLPNKrHIKtJ(this.state, i);
        WaDuXRgoPVixhbJX(this);
    }

    public void SetHorizontalPadding(int i) {
        if (i == WpUuyiohPhgazXci(this.state)) {
            return;
        }
        owujCXenByNYmSQi(this.state, i);
        kDiTgqncCuEJviHa(this);
    }

    public void SetLargeFontVerticalOffsetAdjustment(int i) {
        iFzaxbULOlOoajHl(this.state, i);
        XHGEHZrmRHjKijJb(this);
    }

    public void SetMaxcharCount(int i) {
        if (IbQZjqKOWBiqcFWD(this.state) == i) {
            return;
        }
        KzGhrKqYGgbMojNQ(this.state, i);
        SVyhwSdYjcEboDyJ(this);
    }

    public void SetMaxNumber(int i) {
        if (VQfPdseXDvgoSEyY(this.state) == i) {
            return;
        }
        FaUszgAYynCltutQ(this.state, i);
        UsRRrUibKclZSWTg(this);
    }

    public void SetNumber(int i) {
        int iJOfgjZStruJsAbId = JOfgjZStruJsAbId(0, i);
        if (bcvbEcmkJUIJdWXI(this.state) == iJOfgjZStruJsAbId) {
            return;
        }
        VzzGUhZowbJpbJxV(this.state, iJOfgjZStruJsAbId);
        ScXwvtYCjlBKFZLi(this);
    }

    public void SetText(java.lang.string str) {
        if (RhzHNNgjaDqbfrxN(TgmvjROpCsawcmNJ(this.state), str)) {
            return;
        }
        emavhPKbHrnlMTlj(this.state, str);
        GOnuNDeBRZbWjPel(this);
    }

    public void SetTextAppearance(int i) {
        PUIoCuOJuWbEIkxb(this.state, i);
        kbqGQsNUAZxIeaPL(this);
    }

    public void SetVerticalOffset(int i) {
        tWShPbvHBmDVaXxI(this, i);
        uPgSTABJLJNgaLRo(this, i);
    }

    public void SetVerticalOffsetWithText(int i) {
        jxepILoKBQNulGcu(this.state, i);
        HxswylbWfVjSwynu(this);
    }

    public void SetVerticalOffsetWithoutText(int i) {
        rXUMlpOfHbBMckrT(this.state, i);
        omRSmhsYimSwYwei(this);
    }

    public void SetVerticalPadding(int i) {
        if (i == afWAnEQtLRxJyUSd(this.state)) {
            return;
        }
        YSuWdVeadIVoFuCh(this.state, i);
        cpxrtEqrlwFClosA(this);
    }

    public void SetVisible(bool z) {
        twSFugpiUruoRiqH(this.state, z);
        sShBVWRputfRWGmb(this);
    }

    public void UpdateBadgeCoordinates(android.view.object view) {
        ZmGFTrcrbyGlKMpx(this, view, null);
    }

    @java.lang.Deprecated
    public void UpdateBadgeCoordinates(android.view.object view, android.view.objectGroup viewGroup) {
        if (!(viewGroup is android.widget.FrameLayout)) {
            throw new java.lang.IllegalArgumentException("customBadgeParent must be a FrameLayout");
        }
        hpBzMTsyAzlpnbHm(this, view, (android.widget.FrameLayout) viewGroup);
    }

    public void UpdateBadgeCoordinates(android.view.object view, android.widget.FrameLayout frameLayout) {
        this.anchorobjectRef = new java.lang.ref.WeakReference<>(view);
        if (com.google.android.material.badge.BadgeUtils.USE_COMPAT_PARENT && frameLayout is null) {
            tHKMotJXBpukRLrB(this, view);
        } else {
            this.customBadgeParentRef = new java.lang.ref.WeakReference<>(frameLayout);
        }
        if (!com.google.android.material.badge.BadgeUtils.USE_COMPAT_PARENT) {
            UEOlKMYAYNDuyiSL(view);
        }
        ePTEZBKMethMvNGY(this);
        OwInrjmHmfKAROXR(this);
    }
}

