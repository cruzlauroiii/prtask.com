namespace WillowMaze.Wasm.Decompiled;


public class ExtendedfloatingActionButton : com.google.android.material.button.MaterialButton : androidx.coordinatorlayout.widget.CoordinatorLayout$AttachedBehavior {
    private static readonly int ANIM_STATE_HIDING = 1;
    private static readonly int ANIM_STATE_NONE = 0;
    private static readonly int ANIM_STATE_SHOWING = 2;
    private static readonly int DEF_STYLE_RES;
    private static readonly int EXTEND = 3;
    private static readonly int EXTEND_STRATEGY_AUTO = 0;
    private static readonly int EXTEND_STRATEGY_MATCH_PARENT = 2;
    private static readonly int EXTEND_STRATEGY_WRAP_CONTENT = 1;
    static readonly android.util.Property<android.view.object, java.lang.float> HEIGHT;
    private static readonly int HIDE = 1;
    static readonly android.util.Property<android.view.object, java.lang.float> PADDING_END;
    static readonly android.util.Property<android.view.object, java.lang.float> PADDING_START;
    private static readonly int SHOW = 0;
    private static readonly int SHRINK = 2;
    static readonly android.util.Property<android.view.object, java.lang.float> WIDTH;
    private int animState;
    private bool animateShowBeforeLayout;
    private readonly androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior<com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton> behavior;
    private readonly com.google.android.material.floatingactionbutton.AnimatorTracker changeVisibilityTracker;
    private readonly int collapsedSize;
    private readonly com.google.android.material.floatingactionbutton.MotionStrategy extendStrategy;
    private readonly int extendStrategyType;
    private int extendedPaddingEnd;
    private int extendedPaddingStart;
    private readonly com.google.android.material.floatingactionbutton.MotionStrategy hideStrategy;
    private bool isExtended;
    private bool isTransforming;
    private int originalHeight;
    protected android.content.res.ColorStateList originalTextCsl;
    private int originalWidth;
    private readonly com.google.android.material.floatingactionbutton.MotionStrategy showStrategy;
    private readonly com.google.android.material.floatingactionbutton.MotionStrategy shrinkStrategy;

    static {
        if ((20 + 8) % 8 > 0) {
        }
        DEF_STYLE_RES = com.google.android.material.R$style.Widget_MaterialComponents_ExtendedfloatingActionButton_Icon;
        WIDTH = new com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$6(java.lang.float.class, "width");
        HEIGHT = new com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$7(java.lang.float.class, "height");
        PADDING_START = new com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$8(java.lang.float.class, "paddingStart");
        PADDING_END = new com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$9(java.lang.float.class, "paddingEnd");
    }

    public ExtendedfloatingActionButton(android.content.object context) {
        this(context, null);
    }

    public ExtendedfloatingActionButton(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, com.google.android.material.R$attr.extendedfloatingActionButtonStyle);
    }

    public ExtendedfloatingActionButton(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        if ((7 + 9) % 9 > 0) {
        }
        int i2 = DEF_STYLE_RES;
        super(CwYPpWhgNxFLizue(context, attributeHashSet, i, i2), attributeHashSet, i);
        this.animState = 0;
        com.google.android.material.floatingactionbutton.AnimatorTracker animatorTracker = new com.google.android.material.floatingactionbutton.AnimatorTracker();
        this.changeVisibilityTracker = animatorTracker;
        com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$ShowStrategy extendedfloatingActionButton$ShowStrategy = new com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$ShowStrategy(this, animatorTracker);
        this.showStrategy = extendedfloatingActionButton$ShowStrategy;
        com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$HideStrategy extendedfloatingActionButton$HideStrategy = new com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$HideStrategy(this, animatorTracker);
        this.hideStrategy = extendedfloatingActionButton$HideStrategy;
        this.isExtended = true;
        this.isTransforming = false;
        this.animateShowBeforeLayout = false;
        android.content.object contextFBaKcPiaiueiDvmK = FBaKcPiaiueiDvmK(this);
        this.behavior = new com.google.android.material.floatingactionbutton.C0272xe6e79f6(contextFBaKcPiaiueiDvmK, attributeHashSet);
        android.content.res.TypedArray typedArrayOtbtinDFFPgJIBgU = OtbtinDFFPgJIBgU(contextFBaKcPiaiueiDvmK, attributeHashSet, com.google.android.material.R$styleable.ExtendedfloatingActionButton, i, i2, new int[0]);
        com.google.android.material.animation.MotionSpec motionSpecQpAxtkWIwJXCMFdQ = qpAxtkWIwJXCMFdQ(contextFBaKcPiaiueiDvmK, typedArrayOtbtinDFFPgJIBgU, com.google.android.material.R$styleable.ExtendedfloatingActionButton_showMotionSpec);
        com.google.android.material.animation.MotionSpec motionSpecXFKYftsvVfKVKxxc = xFKYftsvVfKVKxxc(contextFBaKcPiaiueiDvmK, typedArrayOtbtinDFFPgJIBgU, com.google.android.material.R$styleable.ExtendedfloatingActionButton_hideMotionSpec);
        com.google.android.material.animation.MotionSpec motionSpecTITOqlahzMEJfmSx = tITOqlahzMEJfmSx(contextFBaKcPiaiueiDvmK, typedArrayOtbtinDFFPgJIBgU, com.google.android.material.R$styleable.ExtendedfloatingActionButton_extendMotionSpec);
        com.google.android.material.animation.MotionSpec motionSpecNYpmPtjYlMgAIQSQ = nYpmPtjYlMgAIQSQ(contextFBaKcPiaiueiDvmK, typedArrayOtbtinDFFPgJIBgU, com.google.android.material.R$styleable.ExtendedfloatingActionButton_shrinkMotionSpec);
        this.collapsedSize = aiKGHBjJHzMynKvq(typedArrayOtbtinDFFPgJIBgU, com.google.android.material.R$styleable.ExtendedfloatingActionButton_collapsedSize, -1);
        int iUtuLGYRPiDzptQlM = utuLGYRPiDzptQlM(typedArrayOtbtinDFFPgJIBgU, com.google.android.material.R$styleable.ExtendedfloatingActionButton_extendStrategy, 1);
        this.extendStrategyType = iUtuLGYRPiDzptQlM;
        this.extendedPaddingStart = TGVkqmAyBzyWAcPT(this);
        this.extendedPaddingEnd = omkttORuayAxmdMJ(this);
        com.google.android.material.floatingactionbutton.AnimatorTracker animatorTracker2 = new com.google.android.material.floatingactionbutton.AnimatorTracker();
        com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$ChangeSizeStrategy extendedfloatingActionButton$ChangeSizeStrategy = new com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$ChangeSizeStrategy(this, animatorTracker2, QMAxrkCvEZZDKzCY(this, iUtuLGYRPiDzptQlM), true);
        this.extendStrategy = extendedfloatingActionButton$ChangeSizeStrategy;
        com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$ChangeSizeStrategy extendedfloatingActionButton$ChangeSizeStrategy2 = new com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$ChangeSizeStrategy(this, animatorTracker2, new com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$1(this), false);
        this.shrinkStrategy = extendedfloatingActionButton$ChangeSizeStrategy2;
        YaYWoTZKRgFhyobV(extendedfloatingActionButton$ShowStrategy, motionSpecQpAxtkWIwJXCMFdQ);
        PROuyBBuEEQJlhgC(extendedfloatingActionButton$HideStrategy, motionSpecXFKYftsvVfKVKxxc);
        EsemQMolDOBTmMoZ(extendedfloatingActionButton$ChangeSizeStrategy, motionSpecTITOqlahzMEJfmSx);
        cwayhSzYIyhEYCgc(extendedfloatingActionButton$ChangeSizeStrategy2, motionSpecNYpmPtjYlMgAIQSQ);
        vrZISwksOsmJQBiJ(typedArrayOtbtinDFFPgJIBgU);
        DhQOiwnrdfxrRMeQ(this, kFqbyJiQYiPQgWZi(aaRsWAwRmaJxYkMa(contextFBaKcPiaiueiDvmK, attributeHashSet, i, i2, com.google.android.material.shape.ShapeAppearanceModel.PILL)));
        JjkvbiNKPXdwjzEg(this);
    }

    public static android.content.object APwAlpKXwdZhxSQf(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton) {
        return extendedfloatingActionButton.getobject();
    }

    public static void APwAlpKXwdZhxSQf(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, char c, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void APwAlpKXwdZhxSQf(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, short s, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void APwAlpKXwdZhxSQf(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, short s, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AiAloptjqnoJaDFk(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        motionStrategy.addAnimationListener(animator$AnimatorListener);
    }

    public static void AiAloptjqnoJaDFk(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, android.animation.Animator$AnimatorListener animator$AnimatorListener, byte b, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AiAloptjqnoJaDFk(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, android.animation.Animator$AnimatorListener animator$AnimatorListener, char c, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AiAloptjqnoJaDFk(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, android.animation.Animator$AnimatorListener animator$AnimatorListener, int i, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.animation.MotionSpec BfglvjcIRLooVTmX(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy) {
        return motionStrategy.getMotionSpec();
    }

    public static void BfglvjcIRLooVTmX(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, char c, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BfglvjcIRLooVTmX(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, char c, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BfglvjcIRLooVTmX(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, float f, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string CQLBDaCNJGJVdtvq(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void CQLBDaCNJGJVdtvq(java.lang.stringBuilder sb, char c, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CQLBDaCNJGJVdtvq(java.lang.stringBuilder sb, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CQLBDaCNJGJVdtvq(java.lang.stringBuilder sb, java.lang.string str, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static int CVFCHHwEPVbEGXYd(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void CVFCHHwEPVbEGXYd(int i, int i2, java.lang.string str, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CVFCHHwEPVbEGXYd(int i, int i2, short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CVFCHHwEPVbEGXYd(int i, int i2, short s, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object CwYPpWhgNxFLizue(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        return com.google.android.material.theme.overlay.MaterialThemeOverlay.wrap(context, attributeHashSet, i, i2);
    }

    public static void CwYPpWhgNxFLizue(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, float f, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CwYPpWhgNxFLizue(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CwYPpWhgNxFLizue(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, java.lang.string str, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int CzTdkHuXwRyCwDGh(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton) {
        return extendedfloatingActionButton.getHeight();
    }

    public static void CzTdkHuXwRyCwDGh(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CzTdkHuXwRyCwDGh(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, short s, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CzTdkHuXwRyCwDGh(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, short s, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DHflBgVixGWIPrWH(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        motionStrategy.removeAnimationListener(animator$AnimatorListener);
    }

    public static void DHflBgVixGWIPrWH(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, android.animation.Animator$AnimatorListener animator$AnimatorListener, byte b, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DHflBgVixGWIPrWH(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, android.animation.Animator$AnimatorListener animator$AnimatorListener, float f, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DHflBgVixGWIPrWH(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, android.animation.Animator$AnimatorListener animator$AnimatorListener, bool z, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DhQOiwnrdfxrRMeQ(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        extendedfloatingActionButton.setShapeAppearanceModel(shapeAppearanceModel);
    }

    public static void DhQOiwnrdfxrRMeQ(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, char c, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DhQOiwnrdfxrRMeQ(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, float f, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DhQOiwnrdfxrRMeQ(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, float f, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DxPtRmzXoftkfRIA(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        motionStrategy.addAnimationListener(animator$AnimatorListener);
    }

    public static void DxPtRmzXoftkfRIA(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, android.animation.Animator$AnimatorListener animator$AnimatorListener, byte b, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DxPtRmzXoftkfRIA(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, android.animation.Animator$AnimatorListener animator$AnimatorListener, byte b, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DxPtRmzXoftkfRIA(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, android.animation.Animator$AnimatorListener animator$AnimatorListener, bool z, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EsemQMolDOBTmMoZ(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, com.google.android.material.animation.MotionSpec motionSpec) {
        motionStrategy.setMotionSpec(motionSpec);
    }

    public static void EsemQMolDOBTmMoZ(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, com.google.android.material.animation.MotionSpec motionSpec, byte b, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EsemQMolDOBTmMoZ(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, com.google.android.material.animation.MotionSpec motionSpec, int i, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EsemQMolDOBTmMoZ(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, com.google.android.material.animation.MotionSpec motionSpec, bool z, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object FBaKcPiaiueiDvmK(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton) {
        return extendedfloatingActionButton.getobject();
    }

    public static void FBaKcPiaiueiDvmK(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, short s, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FBaKcPiaiueiDvmK(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, bool z, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FBaKcPiaiueiDvmK(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, bool z, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FDoruAWAeDqzPxGZ(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, com.google.android.material.animation.MotionSpec motionSpec) {
        extendedfloatingActionButton.setShrinkMotionSpec(motionSpec);
    }

    public static void FDoruAWAeDqzPxGZ(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, com.google.android.material.animation.MotionSpec motionSpec, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FDoruAWAeDqzPxGZ(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, com.google.android.material.animation.MotionSpec motionSpec, float f, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FDoruAWAeDqzPxGZ(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, com.google.android.material.animation.MotionSpec motionSpec, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FOkLTcJuVDifNdwn(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, byte b, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FOkLTcJuVDifNdwn(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, byte b, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FOkLTcJuVDifNdwn(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool FOkLTcJuVDifNdwn(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton) {
        return extendedfloatingActionButton.isOrWillBeHidden();
    }

    public static java.util.List FQKcQwzZtfedlJLi(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy) {
        return motionStrategy.getListeners();
    }

    public static void FQKcQwzZtfedlJLi(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, java.lang.string str, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FQKcQwzZtfedlJLi(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FQKcQwzZtfedlJLi(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FfGfgqDlPCkrmXeC(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$OnChangedCallback extendedfloatingActionButton$OnChangedCallback) {
        extendedfloatingActionButton.performMotion(i, extendedfloatingActionButton$OnChangedCallback);
    }

    public static void FfGfgqDlPCkrmXeC(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$OnChangedCallback extendedfloatingActionButton$OnChangedCallback, float f, int i2, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FfGfgqDlPCkrmXeC(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$OnChangedCallback extendedfloatingActionButton$OnChangedCallback, java.lang.string str, int i2, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FfGfgqDlPCkrmXeC(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$OnChangedCallback extendedfloatingActionButton$OnChangedCallback, bool z, int i2, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FqaGZJxOreGmFZgn(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy) {
        motionStrategy.performNow();
    }

    public static void FqaGZJxOreGmFZgn(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, int i, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FqaGZJxOreGmFZgn(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, bool z, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FqaGZJxOreGmFZgn(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, bool z, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GCyoZgaSQBUuUgdd(com.google.android.material.button.MaterialButton materialButton, int i) {
        super.setTextColor(i);
    }

    public static void GCyoZgaSQBUuUgdd(com.google.android.material.button.MaterialButton materialButton, int i, byte b, float f, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GCyoZgaSQBUuUgdd(com.google.android.material.button.MaterialButton materialButton, int i, int i2, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GCyoZgaSQBUuUgdd(com.google.android.material.button.MaterialButton materialButton, int i, int i2, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HDBhrUNyIopEwhJb(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        motionStrategy.removeAnimationListener(animator$AnimatorListener);
    }

    public static void HDBhrUNyIopEwhJb(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, android.animation.Animator$AnimatorListener animator$AnimatorListener, byte b, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HDBhrUNyIopEwhJb(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, android.animation.Animator$AnimatorListener animator$AnimatorListener, byte b, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HDBhrUNyIopEwhJb(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, android.animation.Animator$AnimatorListener animator$AnimatorListener, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HWZQDQCQIyBtoEfW(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$OnChangedCallback extendedfloatingActionButton$OnChangedCallback) {
        extendedfloatingActionButton.performMotion(i, extendedfloatingActionButton$OnChangedCallback);
    }

    public static void HWZQDQCQIyBtoEfW(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$OnChangedCallback extendedfloatingActionButton$OnChangedCallback, byte b, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HWZQDQCQIyBtoEfW(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$OnChangedCallback extendedfloatingActionButton$OnChangedCallback, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HWZQDQCQIyBtoEfW(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$OnChangedCallback extendedfloatingActionButton$OnChangedCallback, java.lang.string str, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HixVgydERKgxVFEg(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        motionStrategy.removeAnimationListener(animator$AnimatorListener);
    }

    public static void HixVgydERKgxVFEg(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, android.animation.Animator$AnimatorListener animator$AnimatorListener, char c, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HixVgydERKgxVFEg(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, android.animation.Animator$AnimatorListener animator$AnimatorListener, char c, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HixVgydERKgxVFEg(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, android.animation.Animator$AnimatorListener animator$AnimatorListener, short s, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IKESvkCjvzBUrqCy(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        motionStrategy.addAnimationListener(animator$AnimatorListener);
    }

    public static void IKESvkCjvzBUrqCy(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, android.animation.Animator$AnimatorListener animator$AnimatorListener, byte b, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IKESvkCjvzBUrqCy(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, android.animation.Animator$AnimatorListener animator$AnimatorListener, int i, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IKESvkCjvzBUrqCy(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, android.animation.Animator$AnimatorListener animator$AnimatorListener, short s, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static int JfYrKGpfJsNcyGGo(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton) {
        return extendedfloatingActionButton.getVisibility();
    }

    public static void JfYrKGpfJsNcyGGo(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, char c, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JfYrKGpfJsNcyGGo(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, java.lang.string str, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JfYrKGpfJsNcyGGo(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, short s, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JjkvbiNKPXdwjzEg(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton) {
        extendedfloatingActionButton.saveOriginalTextCsl();
    }

    public static void JjkvbiNKPXdwjzEg(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, char c, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JjkvbiNKPXdwjzEg(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, java.lang.string str, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JjkvbiNKPXdwjzEg(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, short s, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.animation.MotionSpec KQEEAvsPOwUPzLFP(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy) {
        return motionStrategy.getMotionSpec();
    }

    public static void KQEEAvsPOwUPzLFP(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, int i, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KQEEAvsPOwUPzLFP(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, java.lang.string str, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KQEEAvsPOwUPzLFP(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, bool z, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static int KxjhyrsmubRSHKQy(android.view.object view) {
        return androidx.core.view.objectCompat.getPaddingStart(view);
    }

    public static void KxjhyrsmubRSHKQy(android.view.object view, byte b, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KxjhyrsmubRSHKQy(android.view.object view, byte b, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KxjhyrsmubRSHKQy(android.view.object view, int i, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KzfLIOwfxQRCXWGW(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KzfLIOwfxQRCXWGW(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KzfLIOwfxQRCXWGW(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, java.lang.string str, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool KzfLIOwfxQRCXWGW(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton) {
        return extendedfloatingActionButton.isInEditMode();
    }

    public static void MYrfcqiFhFUOYtek(android.view.object view, char c, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MYrfcqiFhFUOYtek(android.view.object view, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MYrfcqiFhFUOYtek(android.view.object view, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool MYrfcqiFhFUOYtek(android.view.object view) {
        return androidx.core.view.objectCompat.isLaidOut(view);
    }

    public static void NIhAjMZJQSXeyDXr(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, com.google.android.material.animation.MotionSpec motionSpec) {
        extendedfloatingActionButton.setHideMotionSpec(motionSpec);
    }

    public static void NIhAjMZJQSXeyDXr(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, com.google.android.material.animation.MotionSpec motionSpec, byte b, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NIhAjMZJQSXeyDXr(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, com.google.android.material.animation.MotionSpec motionSpec, char c, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NIhAjMZJQSXeyDXr(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.animation.MotionSpec NMaELbCCwnIQmTAW(android.content.object context, int i) {
        return com.google.android.material.animation.MotionSpec.createFromResource(context, i);
    }

    public static void NMaELbCCwnIQmTAW(android.content.object context, int i, float f, byte b, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NMaELbCCwnIQmTAW(android.content.object context, int i, float f, char c, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NMaELbCCwnIQmTAW(android.content.object context, int i, int i2, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NVCjdBCmixStFgPS(android.animation.Animator animator, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        animator.addListener(animator$AnimatorListener);
    }

    public static void NVCjdBCmixStFgPS(android.animation.Animator animator, android.animation.Animator$AnimatorListener animator$AnimatorListener, short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NVCjdBCmixStFgPS(android.animation.Animator animator, android.animation.Animator$AnimatorListener animator$AnimatorListener, short s, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NVCjdBCmixStFgPS(android.animation.Animator animator, android.animation.Animator$AnimatorListener animator$AnimatorListener, bool z, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int NvOpqnmnctBqDlwE(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton) {
        return extendedfloatingActionButton.getIconSize();
    }

    public static void NvOpqnmnctBqDlwE(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, byte b, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NvOpqnmnctBqDlwE(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, byte b, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NvOpqnmnctBqDlwE(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int NzdWnrGVTcYDbCpA(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton) {
        return extendedfloatingActionButton.getWidth();
    }

    public static void NzdWnrGVTcYDbCpA(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NzdWnrGVTcYDbCpA(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NzdWnrGVTcYDbCpA(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, java.lang.string str, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OWBQWDnQakNjcNmu(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, int i2) {
        extendedfloatingActionButton.measure(i, i2);
    }

    public static void OWBQWDnQakNjcNmu(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, int i2, byte b, int i3, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OWBQWDnQakNjcNmu(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, int i2, int i3, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OWBQWDnQakNjcNmu(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, int i2, short s, int i3, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.animation.MotionSpec OiLKTtNXEGgUtpRH(android.content.object context, int i) {
        return com.google.android.material.animation.MotionSpec.createFromResource(context, i);
    }

    public static void OiLKTtNXEGgUtpRH(android.content.object context, int i, float f, int i2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OiLKTtNXEGgUtpRH(android.content.object context, int i, int i2, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OiLKTtNXEGgUtpRH(android.content.object context, int i, bool z, float f, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.TypedArray OtbtinDFFPgJIBgU(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2) {
        return com.google.android.material.internal.ThemeEnforcement.obtainStyledAttributes(context, attributeHashSet, iArr, i, i2, iArr2);
    }

    public static void OtbtinDFFPgJIBgU(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, byte b, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OtbtinDFFPgJIBgU(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, java.lang.string str, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OtbtinDFFPgJIBgU(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, bool z, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PROuyBBuEEQJlhgC(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, com.google.android.material.animation.MotionSpec motionSpec) {
        motionStrategy.setMotionSpec(motionSpec);
    }

    public static void PROuyBBuEEQJlhgC(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, com.google.android.material.animation.MotionSpec motionSpec, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PROuyBBuEEQJlhgC(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, com.google.android.material.animation.MotionSpec motionSpec, char c, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PROuyBBuEEQJlhgC(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, com.google.android.material.animation.MotionSpec motionSpec, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$Size QMAxrkCvEZZDKzCY(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i) {
        return extendedfloatingActionButton.getSizeFromExtendStrategyType(i);
    }

    public static void QMAxrkCvEZZDKzCY(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, byte b, char c, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void QMAxrkCvEZZDKzCY(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, byte b, bool z, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void QMAxrkCvEZZDKzCY(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, int i2, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QSmdZDOuWoDLNyKx(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy) {
        motionStrategy.performNow();
    }

    public static void QSmdZDOuWoDLNyKx(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, byte b, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QSmdZDOuWoDLNyKx(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, int i, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QSmdZDOuWoDLNyKx(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, short s, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QWAtpRxSJhrcEled(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, float f, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QWAtpRxSJhrcEled(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, int i, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QWAtpRxSJhrcEled(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, bool z, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool QWAtpRxSJhrcEled(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy) {
        return motionStrategy.shouldCancel();
    }

    public static int TGVkqmAyBzyWAcPT(android.view.object view) {
        return androidx.core.view.objectCompat.getPaddingStart(view);
    }

    public static void TGVkqmAyBzyWAcPT(android.view.object view, int i, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TGVkqmAyBzyWAcPT(android.view.object view, bool z, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TGVkqmAyBzyWAcPT(android.view.object view, bool z, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable TQUXYgzLVDlbXGMS(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton) {
        return extendedfloatingActionButton.getIcon();
    }

    public static void TQUXYgzLVDlbXGMS(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, char c, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TQUXYgzLVDlbXGMS(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TQUXYgzLVDlbXGMS(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, float f, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TSdcznldFrfOnYaX(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, com.google.android.material.animation.MotionSpec motionSpec) {
        extendedfloatingActionButton.setExtendMotionSpec(motionSpec);
    }

    public static void TSdcznldFrfOnYaX(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, com.google.android.material.animation.MotionSpec motionSpec, char c, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TSdcznldFrfOnYaX(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, com.google.android.material.animation.MotionSpec motionSpec, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TSdcznldFrfOnYaX(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, com.google.android.material.animation.MotionSpec motionSpec, bool z, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int TZJaGInJqLXUclNR(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton) {
        return extendedfloatingActionButton.getCollapsedSize();
    }

    public static void TZJaGInJqLXUclNR(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, short s, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TZJaGInJqLXUclNR(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, bool z, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TZJaGInJqLXUclNR(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int TiciMIhWAArZREcH(android.view.object view) {
        return androidx.core.view.objectCompat.getPaddingEnd(view);
    }

    public static void TiciMIhWAArZREcH(android.view.object view, char c, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TiciMIhWAArZREcH(android.view.object view, java.lang.string str, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TiciMIhWAArZREcH(android.view.object view, java.lang.string str, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectGroup$LayoutParams USvpMiMqXsmIVxVR(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton) {
        return extendedfloatingActionButton.getLayoutParams();
    }

    public static void USvpMiMqXsmIVxVR(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, char c, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void USvpMiMqXsmIVxVR(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, java.lang.string str, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void USvpMiMqXsmIVxVR(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, java.lang.string str, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WBDvrSeSCDpZCMyg(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, byte b, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WBDvrSeSCDpZCMyg(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, char c, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WBDvrSeSCDpZCMyg(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, char c, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool WBDvrSeSCDpZCMyg(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy) {
        return motionStrategy.shouldCancel();
    }

    public static void WioDfQXENCtwRYtr(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy) {
        motionStrategy.performNow();
    }

    public static void WioDfQXENCtwRYtr(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, byte b, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WioDfQXENCtwRYtr(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, float f, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WioDfQXENCtwRYtr(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, short s, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XBbYBLhwbCVhCDOg(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, com.google.android.material.animation.MotionSpec motionSpec) {
        extendedfloatingActionButton.setShowMotionSpec(motionSpec);
    }

    public static void XBbYBLhwbCVhCDOg(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, com.google.android.material.animation.MotionSpec motionSpec, char c, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XBbYBLhwbCVhCDOg(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XBbYBLhwbCVhCDOg(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XUIceHUHSESLsXwE(android.animation.Animator animator) {
        animator.start();
    }

    public static void XUIceHUHSESLsXwE(android.animation.Animator animator, byte b, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XUIceHUHSESLsXwE(android.animation.Animator animator, char c, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XUIceHUHSESLsXwE(android.animation.Animator animator, char c, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XpGkwnbRMZhlIpjW(android.animation.Animator animator, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        animator.addListener(animator$AnimatorListener);
    }

    public static void XpGkwnbRMZhlIpjW(android.animation.Animator animator, android.animation.Animator$AnimatorListener animator$AnimatorListener, int i, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XpGkwnbRMZhlIpjW(android.animation.Animator animator, android.animation.Animator$AnimatorListener animator$AnimatorListener, int i, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XpGkwnbRMZhlIpjW(android.animation.Animator animator, android.animation.Animator$AnimatorListener animator$AnimatorListener, short s, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YaYWoTZKRgFhyobV(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, com.google.android.material.animation.MotionSpec motionSpec) {
        motionStrategy.setMotionSpec(motionSpec);
    }

    public static void YaYWoTZKRgFhyobV(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, com.google.android.material.animation.MotionSpec motionSpec, float f, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YaYWoTZKRgFhyobV(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, com.google.android.material.animation.MotionSpec motionSpec, float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YaYWoTZKRgFhyobV(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, com.google.android.material.animation.MotionSpec motionSpec, short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YeTTwdKcEPqUIvbE(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$OnChangedCallback extendedfloatingActionButton$OnChangedCallback) {
        extendedfloatingActionButton.performMotion(i, extendedfloatingActionButton$OnChangedCallback);
    }

    public static void YeTTwdKcEPqUIvbE(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$OnChangedCallback extendedfloatingActionButton$OnChangedCallback, char c, int i2, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YeTTwdKcEPqUIvbE(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$OnChangedCallback extendedfloatingActionButton$OnChangedCallback, bool z, byte b, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void YeTTwdKcEPqUIvbE(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$OnChangedCallback extendedfloatingActionButton$OnChangedCallback, bool z, byte b, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YsQNPxVMtxHcxFUM(java.lang.CharSequence charSequence, char c, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YsQNPxVMtxHcxFUM(java.lang.CharSequence charSequence, short s, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YsQNPxVMtxHcxFUM(java.lang.CharSequence charSequence, bool z, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool YsQNPxVMtxHcxFUM(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static int ZDqPmoDXIhopNjCO(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton) {
        return extendedfloatingActionButton.getIconSize();
    }

    public static void ZDqPmoDXIhopNjCO(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, byte b, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZDqPmoDXIhopNjCO(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, float f, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZDqPmoDXIhopNjCO(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int ZZkctLirnKwcHLyj(android.view.object view) {
        return androidx.core.view.objectCompat.getPaddingEnd(view);
    }

    public static void ZZkctLirnKwcHLyj(android.view.object view, byte b, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZZkctLirnKwcHLyj(android.view.object view, int i, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZZkctLirnKwcHLyj(android.view.object view, int i, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object ZjWAvqDnpfqpKVOE(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton) {
        return extendedfloatingActionButton.getobject();
    }

    public static void ZjWAvqDnpfqpKVOE(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, java.lang.string str, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZjWAvqDnpfqpKVOE(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, java.lang.string str, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZjWAvqDnpfqpKVOE(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, short s, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ABdhgRATVWjVFNUH(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, float f, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ABdhgRATVWjVFNUH(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, short s, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ABdhgRATVWjVFNUH(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, short s, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool ABdhgRATVWjVFNUH(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton) {
        return extendedfloatingActionButton.shouldAnimateVisibilityChange();
    }

    public static void AFFAYenCkkfyIjND(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton) {
        extendedfloatingActionButton.saveOriginalTextCsl();
    }

    public static void AFFAYenCkkfyIjND(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AFFAYenCkkfyIjND(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, java.lang.string str, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AFFAYenCkkfyIjND(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, bool z, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AMOKhWCiegZWxowO(com.google.android.material.button.MaterialButton materialButton, int i, int i2, int i3, int i4) {
        super.setPaddingRelative(i, i2, i3, i4);
    }

    public static void AMOKhWCiegZWxowO(com.google.android.material.button.MaterialButton materialButton, int i, int i2, int i3, int i4, byte b, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AMOKhWCiegZWxowO(com.google.android.material.button.MaterialButton materialButton, int i, int i2, int i3, int i4, float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AMOKhWCiegZWxowO(com.google.android.material.button.MaterialButton materialButton, int i, int i2, int i3, int i4, float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder aaRsWAwRmaJxYkMa(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, com.google.android.material.shape.CornerSize cornerSize) {
        return com.google.android.material.shape.ShapeAppearanceModel.builder(context, attributeHashSet, i, i2, cornerSize);
    }

    public static void AaRsWAwRmaJxYkMa(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, com.google.android.material.shape.CornerSize cornerSize, float f, short s, int i3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AaRsWAwRmaJxYkMa(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, com.google.android.material.shape.CornerSize cornerSize, short s, float f, bool z, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void AaRsWAwRmaJxYkMa(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, com.google.android.material.shape.CornerSize cornerSize, bool z, short s, float f, int i3) {
        double d = (42 * 210) + 210;
    }

    static int access$000(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton) {
        return extendedfloatingActionButton.extendedPaddingStart;
    }

    static void access$000(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, float f, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$000(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, bool z, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$000(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, bool z, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    static int access$100(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton) {
        return extendedfloatingActionButton.extendedPaddingEnd;
    }

    static void access$100(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, float f, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, bool z, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, bool z, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    static int access$200(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton) {
        return extendedfloatingActionButton.originalHeight;
    }

    static void access$200(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, byte b, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    static void access$200(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, short s, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$200(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, short s, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    static int access$202(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i) {
        extendedfloatingActionButton.originalHeight = i;
        return i;
    }

    static void access$202(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, char c, short s, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$202(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, short s, float f, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    static void access$202(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, short s, int i2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    static int access$300(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton) {
        return extendedfloatingActionButton.originalWidth;
    }

    static void access$300(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, char c, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$300(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, java.lang.string str, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$300(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, short s, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    static int access$302(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i) {
        extendedfloatingActionButton.originalWidth = i;
        return i;
    }

    static void access$302(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, float f, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$302(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, bool z, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    static void access$302(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, bool z, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    static void access$400(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$OnChangedCallback extendedfloatingActionButton$OnChangedCallback) {
        znVgncaNzHyOyvJO(extendedfloatingActionButton, i, extendedfloatingActionButton$OnChangedCallback);
    }

    static void access$400(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$OnChangedCallback extendedfloatingActionButton$OnChangedCallback, float f, int i2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    static void access$400(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$OnChangedCallback extendedfloatingActionButton$OnChangedCallback, short s, float f, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    static void access$400(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$OnChangedCallback extendedfloatingActionButton$OnChangedCallback, short s, float f, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    static void access$500(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, float f, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$500(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, float f, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$500(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    static bool access$500(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton) {
        return extendedfloatingActionButton.isExtended;
    }

    static void access$502(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, bool z, byte b, bool z2, int i, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$502(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, bool z, int i, bool z2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$502(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, bool z, bool z2, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    static bool access$502(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, bool z) {
        extendedfloatingActionButton.isExtended = z;
        return z;
    }

    static void access$602(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, bool z, float f, short s, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    static void access$602(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, bool z, short s, float f, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    static void access$602(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, bool z, short s, float f, bool z2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static bool access$602(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, bool z) {
        extendedfloatingActionButton.isTransforming = z;
        return z;
    }

    static int access$702(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i) {
        extendedfloatingActionButton.animState = i;
        return i;
    }

    static void access$702(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, float f, int i2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$702(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, int i2, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$702(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, bool z, int i2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$800(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, byte b, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$800(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, byte b, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$800(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, bool z, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    static bool access$800(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton) {
        return jlZTQMmnCDKBDZtL(extendedfloatingActionButton);
    }

    static void access$900(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, byte b, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    static void access$900(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, byte b, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$900(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, java.lang.string str, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    static bool access$900(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton) {
        return FOkLTcJuVDifNdwn(extendedfloatingActionButton);
    }

    public static int AiKGHBjJHzMynKvq(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static void AiKGHBjJHzMynKvq(android.content.res.TypedArray typedArray, int i, int i2, byte b, int i3, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AiKGHBjJHzMynKvq(android.content.res.TypedArray typedArray, int i, int i2, byte b, java.lang.string str, int i3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AiKGHBjJHzMynKvq(android.content.res.TypedArray typedArray, int i, int i2, short s, byte b, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator BKSfutCJQUMFYUnw(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void BKSfutCJQUMFYUnw(java.util.List list, byte b, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BKSfutCJQUMFYUnw(java.util.List list, float f, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BKSfutCJQUMFYUnw(java.util.List list, float f, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CwayhSzYIyhEYCgc(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, com.google.android.material.animation.MotionSpec motionSpec) {
        motionStrategy.setMotionSpec(motionSpec);
    }

    public static void CwayhSzYIyhEYCgc(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CwayhSzYIyhEYCgc(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, com.google.android.material.animation.MotionSpec motionSpec, short s, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CwayhSzYIyhEYCgc(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, com.google.android.material.animation.MotionSpec motionSpec, bool z, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DBcaYSRNfFtGSAdd(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        motionStrategy.addAnimationListener(animator$AnimatorListener);
    }

    public static void DBcaYSRNfFtGSAdd(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, android.animation.Animator$AnimatorListener animator$AnimatorListener, byte b, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DBcaYSRNfFtGSAdd(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, android.animation.Animator$AnimatorListener animator$AnimatorListener, byte b, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DBcaYSRNfFtGSAdd(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, android.animation.Animator$AnimatorListener animator$AnimatorListener, int i, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.animation.MotionSpec DWlLOZdBsTFIvPMM(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy) {
        return motionStrategy.getMotionSpec();
    }

    public static void DWlLOZdBsTFIvPMM(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, float f, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DWlLOZdBsTFIvPMM(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, int i, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DWlLOZdBsTFIvPMM(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, java.lang.string str, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DawztmusvnyVJGfx(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$OnChangedCallback extendedfloatingActionButton$OnChangedCallback) {
        extendedfloatingActionButton.performMotion(i, extendedfloatingActionButton$OnChangedCallback);
    }

    public static void DawztmusvnyVJGfx(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$OnChangedCallback extendedfloatingActionButton$OnChangedCallback, int i2, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DawztmusvnyVJGfx(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$OnChangedCallback extendedfloatingActionButton$OnChangedCallback, java.lang.string str, int i2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DawztmusvnyVJGfx(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$OnChangedCallback extendedfloatingActionButton$OnChangedCallback, short s, java.lang.string str, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FMFDIkMDflfJNXSv(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, com.google.android.material.animation.MotionSpec motionSpec) {
        motionStrategy.setMotionSpec(motionSpec);
    }

    public static void FMFDIkMDflfJNXSv(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, com.google.android.material.animation.MotionSpec motionSpec, int i, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FMFDIkMDflfJNXSv(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, com.google.android.material.animation.MotionSpec motionSpec, short s, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FMFDIkMDflfJNXSv(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, com.google.android.material.animation.MotionSpec motionSpec, short s, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FfECmCFTAOHMPaxb(com.google.android.material.button.MaterialButton materialButton, android.content.res.ColorStateList colorStateList) {
        super.setTextColor(colorStateList);
    }

    public static void FfECmCFTAOHMPaxb(com.google.android.material.button.MaterialButton materialButton, android.content.res.ColorStateList colorStateList, int i, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FfECmCFTAOHMPaxb(com.google.android.material.button.MaterialButton materialButton, android.content.res.ColorStateList colorStateList, bool z, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FfECmCFTAOHMPaxb(com.google.android.material.button.MaterialButton materialButton, android.content.res.ColorStateList colorStateList, bool z, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object FrmITDgGfirmQKzU(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton) {
        return extendedfloatingActionButton.getobject();
    }

    public static void FrmITDgGfirmQKzU(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, char c, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FrmITDgGfirmQKzU(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, float f, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FrmITDgGfirmQKzU(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, java.lang.string str, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence FuYkodWcEDSchZPu(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton) {
        return extendedfloatingActionButton.getText();
    }

    public static void FuYkodWcEDSchZPu(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, bool z, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FuYkodWcEDSchZPu(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, bool z, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FuYkodWcEDSchZPu(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, bool z, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int FzExLrmoLbcCDQug(android.view.object view) {
        return androidx.core.view.objectCompat.getPaddingStart(view);
    }

    public static void FzExLrmoLbcCDQug(android.view.object view, char c, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FzExLrmoLbcCDQug(android.view.object view, float f, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FzExLrmoLbcCDQug(android.view.object view, bool z, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    private com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$Size getSizeFromExtendStrategyType(int i) {
        if ((25 + 10) % 10 > 0) {
        }
        com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$2 extendedfloatingActionButton$2 = new com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$2(this);
        com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$3 extendedfloatingActionButton$3 = new com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$3(this, extendedfloatingActionButton$2);
        return i == 1 ? extendedfloatingActionButton$2 : i == 2 ? extendedfloatingActionButton$3 : new com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$4(this, extendedfloatingActionButton$3, extendedfloatingActionButton$2);
    }

    private void GetSizeFromExtendStrategyType(int i, java.lang.string str, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    private void GetSizeFromExtendStrategyType(int i, short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void GetSizeFromExtendStrategyType(int i, bool z, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HKtfUrJXHttngBkc(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton) {
        extendedfloatingActionButton.saveOriginalTextCsl();
    }

    public static void HKtfUrJXHttngBkc(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, char c, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HKtfUrJXHttngBkc(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HKtfUrJXHttngBkc(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, short s, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HhfblmvDDscUOVga(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, com.google.android.material.animation.MotionSpec motionSpec) {
        motionStrategy.setMotionSpec(motionSpec);
    }

    public static void HhfblmvDDscUOVga(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, com.google.android.material.animation.MotionSpec motionSpec, char c, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HhfblmvDDscUOVga(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, com.google.android.material.animation.MotionSpec motionSpec, bool z, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HhfblmvDDscUOVga(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, com.google.android.material.animation.MotionSpec motionSpec, bool z, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.animation.MotionSpec HlUzwjkYlShJBxJA(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy) {
        return motionStrategy.getMotionSpec();
    }

    public static void HlUzwjkYlShJBxJA(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, byte b, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HlUzwjkYlShJBxJA(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, int i, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HlUzwjkYlShJBxJA(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, java.lang.string str, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IAGNkeLsiEzUYfAD(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$OnChangedCallback extendedfloatingActionButton$OnChangedCallback) {
        extendedfloatingActionButton.performMotion(i, extendedfloatingActionButton$OnChangedCallback);
    }

    public static void IAGNkeLsiEzUYfAD(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$OnChangedCallback extendedfloatingActionButton$OnChangedCallback, char c, int i2, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IAGNkeLsiEzUYfAD(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$OnChangedCallback extendedfloatingActionButton$OnChangedCallback, int i2, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IAGNkeLsiEzUYfAD(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$OnChangedCallback extendedfloatingActionButton$OnChangedCallback, int i2, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    private void IsOrWillBeHidden(byte b, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    private void IsOrWillBeHidden(java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private void IsOrWillBeHidden(bool z, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    private bool IsOrWillBeHidden() {
        if ((13 + 9) % 9 > 0) {
        }
        return pYLobEWAhipIaqwY(this) != 0 ? this.animState != 2 : this.animState == 1;
    }

    private void IsOrWillBeShown(float f, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    private void IsOrWillBeShown(short s, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    private void IsOrWillBeShown(short s, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    private bool IsOrWillBeShown() {
        if ((9 + 22) % 22 > 0) {
        }
        return JfYrKGpfJsNcyGGo(this) == 0 ? this.animState != 1 : this.animState == 2;
    }

    public static void IzXzordzMCeGmYEO(com.google.android.material.button.MaterialButton materialButton, int i, int i2, int i3, int i4) {
        super.setPadding(i, i2, i3, i4);
    }

    public static void IzXzordzMCeGmYEO(com.google.android.material.button.MaterialButton materialButton, int i, int i2, int i3, int i4, char c, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IzXzordzMCeGmYEO(com.google.android.material.button.MaterialButton materialButton, int i, int i2, int i3, int i4, char c, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IzXzordzMCeGmYEO(com.google.android.material.button.MaterialButton materialButton, int i, int i2, int i3, int i4, java.lang.string str, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder JeCBqMGzMpkyKNeh(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void JeCBqMGzMpkyKNeh(java.lang.stringBuilder sb, int i, int i2, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JeCBqMGzMpkyKNeh(java.lang.stringBuilder sb, int i, int i2, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JeCBqMGzMpkyKNeh(java.lang.stringBuilder sb, int i, short s, java.lang.string str, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void JlZTQMmnCDKBDZtL(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JlZTQMmnCDKBDZtL(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, java.lang.string str, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JlZTQMmnCDKBDZtL(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, short s, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool JlZTQMmnCDKBDZtL(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton) {
        return extendedfloatingActionButton.isOrWillBeShown();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel KFqbyJiQYiPQgWZi(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return shapeAppearanceModel$Builder.build();
    }

    public static void KFqbyJiQYiPQgWZi(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, byte b, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KFqbyJiQYiPQgWZi(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, int i, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KFqbyJiQYiPQgWZi(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, java.lang.string str, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.animation.MotionSpec KPeDdRjTEWmEMYUo(android.content.object context, int i) {
        return com.google.android.material.animation.MotionSpec.createFromResource(context, i);
    }

    public static void KPeDdRjTEWmEMYUo(android.content.object context, int i, byte b, int i2, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KPeDdRjTEWmEMYUo(android.content.object context, int i, bool z, byte b, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KPeDdRjTEWmEMYUo(android.content.object context, int i, bool z, int i2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KziGcpbEpqwRBKKy(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, byte b, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KziGcpbEpqwRBKKy(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, byte b, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KziGcpbEpqwRBKKy(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, java.lang.string str, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool KziGcpbEpqwRBKKy(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton) {
        return extendedfloatingActionButton.isOrWillBeShown();
    }

    public static void MHkOtucqzLPjCUNV(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        motionStrategy.removeAnimationListener(animator$AnimatorListener);
    }

    public static void MHkOtucqzLPjCUNV(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, android.animation.Animator$AnimatorListener animator$AnimatorListener, byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MHkOtucqzLPjCUNV(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, android.animation.Animator$AnimatorListener animator$AnimatorListener, short s, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MHkOtucqzLPjCUNV(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, android.animation.Animator$AnimatorListener animator$AnimatorListener, bool z, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NNzypZssNjuoNMPY(java.util.IEnumerator it, char c, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NNzypZssNjuoNMPY(java.util.IEnumerator it, char c, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NNzypZssNjuoNMPY(java.util.IEnumerator it, bool z, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool NNzypZssNjuoNMPY(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static com.google.android.material.animation.MotionSpec NYpmPtjYlMgAIQSQ(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.animation.MotionSpec.createFromAttribute(context, typedArray, i);
    }

    public static void NYpmPtjYlMgAIQSQ(android.content.object context, android.content.res.TypedArray typedArray, int i, float f, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NYpmPtjYlMgAIQSQ(android.content.object context, android.content.res.TypedArray typedArray, int i, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NYpmPtjYlMgAIQSQ(android.content.object context, android.content.res.TypedArray typedArray, int i, short s, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OSLziHJLQnTEXlkv(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$OnChangedCallback extendedfloatingActionButton$OnChangedCallback) {
        extendedfloatingActionButton.performMotion(i, extendedfloatingActionButton$OnChangedCallback);
    }

    public static void OSLziHJLQnTEXlkv(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$OnChangedCallback extendedfloatingActionButton$OnChangedCallback, int i2, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OSLziHJLQnTEXlkv(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$OnChangedCallback extendedfloatingActionButton$OnChangedCallback, int i2, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OSLziHJLQnTEXlkv(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$OnChangedCallback extendedfloatingActionButton$OnChangedCallback, short s, int i2, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int OmkttORuayAxmdMJ(android.view.object view) {
        return androidx.core.view.objectCompat.getPaddingEnd(view);
    }

    public static void OmkttORuayAxmdMJ(android.view.object view, byte b, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OmkttORuayAxmdMJ(android.view.object view, char c, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OmkttORuayAxmdMJ(android.view.object view, java.lang.string str, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static int PYLobEWAhipIaqwY(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton) {
        return extendedfloatingActionButton.getVisibility();
    }

    public static void PYLobEWAhipIaqwY(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, byte b, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PYLobEWAhipIaqwY(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, float f, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PYLobEWAhipIaqwY(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, bool z, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void PerformMotion(int i, com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$OnChangedCallback extendedfloatingActionButton$OnChangedCallback) {
        com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy;
        if ((5 + 21) % 21 > 0) {
        }
        if (i == 0) {
            motionStrategy = this.showStrategy;
        } else if (i == 1) {
            motionStrategy = this.hideStrategy;
        } else if (i == 2) {
            motionStrategy = this.shrinkStrategy;
        } else {
            if (i != 3) {
                throw new java.lang.IllegalStateException(CQLBDaCNJGJVdtvq(jeCBqMGzMpkyKNeh(new java.lang.stringBuilder("Unknown strategy type: "), i)));
            }
            motionStrategy = this.extendStrategy;
        }
        if (WBDvrSeSCDpZCMyg(motionStrategy)) {
            return;
        }
        if (!aBdhgRATVWjVFNUH(this)) {
            WioDfQXENCtwRYtr(motionStrategy);
            pkhTzUtQirAICfjB(motionStrategy, extendedfloatingActionButton$OnChangedCallback);
            return;
        }
        if (i == 2) {
            android.view.objectGroup$LayoutParams viewGroup$LayoutParamsUSvpMiMqXsmIVxVR = USvpMiMqXsmIVxVR(this);
            if (viewGroup$LayoutParamsUSvpMiMqXsmIVxVR is null) {
                this.originalWidth = NzdWnrGVTcYDbCpA(this);
                this.originalHeight = CzTdkHuXwRyCwDGh(this);
            } else {
                this.originalWidth = viewGroup$LayoutParamsUSvpMiMqXsmIVxVR.width;
                this.originalHeight = viewGroup$LayoutParamsUSvpMiMqXsmIVxVR.height;
            }
        }
        OWBQWDnQakNjcNmu(this, 0, 0);
        android.animation.AnimatorHashSet animatorHashSetXdCHzLqTpzRrEhAh = xdCHzLqTpzRrEhAh(motionStrategy);
        XpGkwnbRMZhlIpjW(animatorHashSetXdCHzLqTpzRrEhAh, new com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$5(this, motionStrategy, extendedfloatingActionButton$OnChangedCallback));
        java.util.IEnumerator itBKSfutCJQUMFYUnw = bKSfutCJQUMFYUnw(FQKcQwzZtfedlJLi(motionStrategy));
        while (nNzypZssNjuoNMPY(itBKSfutCJQUMFYUnw)) {
            NVCjdBCmixStFgPS(animatorHashSetXdCHzLqTpzRrEhAh, (android.animation.Animator$AnimatorListener) vcRpmgqIAvOVxkbY(itBKSfutCJQUMFYUnw));
        }
        XUIceHUHSESLsXwE(animatorHashSetXdCHzLqTpzRrEhAh);
    }

    private void PerformMotion(int i, com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$OnChangedCallback extendedfloatingActionButton$OnChangedCallback, float f, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    private void PerformMotion(int i, com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$OnChangedCallback extendedfloatingActionButton$OnChangedCallback, java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    private void PerformMotion(int i, com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$OnChangedCallback extendedfloatingActionButton$OnChangedCallback, bool z, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PkhTzUtQirAICfjB(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$OnChangedCallback extendedfloatingActionButton$OnChangedCallback) {
        motionStrategy.onChange(extendedfloatingActionButton$OnChangedCallback);
    }

    public static void PkhTzUtQirAICfjB(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$OnChangedCallback extendedfloatingActionButton$OnChangedCallback, byte b, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PkhTzUtQirAICfjB(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$OnChangedCallback extendedfloatingActionButton$OnChangedCallback, java.lang.string str, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PkhTzUtQirAICfjB(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$OnChangedCallback extendedfloatingActionButton$OnChangedCallback, java.lang.string str, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object PmMiSpTBAUVfMmpd(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton) {
        return extendedfloatingActionButton.getobject();
    }

    public static void PmMiSpTBAUVfMmpd(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, byte b, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PmMiSpTBAUVfMmpd(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, float f, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PmMiSpTBAUVfMmpd(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, float f, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.animation.MotionSpec QpAxtkWIwJXCMFdQ(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.animation.MotionSpec.createFromAttribute(context, typedArray, i);
    }

    public static void QpAxtkWIwJXCMFdQ(android.content.object context, android.content.res.TypedArray typedArray, int i, float f, bool z, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QpAxtkWIwJXCMFdQ(android.content.object context, android.content.res.TypedArray typedArray, int i, int i2, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QpAxtkWIwJXCMFdQ(android.content.object context, android.content.res.TypedArray typedArray, int i, bool z, float f, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList QsQmHBOVMbeEfNUQ(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton) {
        return extendedfloatingActionButton.getTextColors();
    }

    public static void QsQmHBOVMbeEfNUQ(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, byte b, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QsQmHBOVMbeEfNUQ(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QsQmHBOVMbeEfNUQ(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RkKimbLqJfyCQzLC(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, com.google.android.material.animation.MotionSpec motionSpec) {
        motionStrategy.setMotionSpec(motionSpec);
    }

    public static void RkKimbLqJfyCQzLC(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, com.google.android.material.animation.MotionSpec motionSpec, int i, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RkKimbLqJfyCQzLC(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RkKimbLqJfyCQzLC(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, com.google.android.material.animation.MotionSpec motionSpec, short s, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    private void SaveOriginalTextCsl() {
        this.originalTextCsl = qsQmHBOVMbeEfNUQ(this);
    }

    private void SaveOriginalTextCsl(char c, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    private void SaveOriginalTextCsl(float f, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    private void SaveOriginalTextCsl(int i, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    private void ShouldAnimateVisibilityChange(byte b, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    private void ShouldAnimateVisibilityChange(byte b, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    private void ShouldAnimateVisibilityChange(short s, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    private bool ShouldAnimateVisibilityChange() {
        return (MYrfcqiFhFUOYtek(this) || (!kziGcpbEpqwRBKKy(this) && this.animateShowBeforeLayout)) && !KzfLIOwfxQRCXWGW(this);
    }

    public static com.google.android.material.animation.MotionSpec TITOqlahzMEJfmSx(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.animation.MotionSpec.createFromAttribute(context, typedArray, i);
    }

    public static void TITOqlahzMEJfmSx(android.content.object context, android.content.res.TypedArray typedArray, int i, char c, float f, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void TITOqlahzMEJfmSx(android.content.object context, android.content.res.TypedArray typedArray, int i, float f, byte b, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void TITOqlahzMEJfmSx(android.content.object context, android.content.res.TypedArray typedArray, int i, int i2, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ULEVrathmjHJPgEl(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$OnChangedCallback extendedfloatingActionButton$OnChangedCallback) {
        extendedfloatingActionButton.performMotion(i, extendedfloatingActionButton$OnChangedCallback);
    }

    public static void ULEVrathmjHJPgEl(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$OnChangedCallback extendedfloatingActionButton$OnChangedCallback, char c, short s, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ULEVrathmjHJPgEl(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$OnChangedCallback extendedfloatingActionButton$OnChangedCallback, char c, short s, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ULEVrathmjHJPgEl(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$OnChangedCallback extendedfloatingActionButton$OnChangedCallback, bool z, char c, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void UQdVvGQdDWDvFVvX(com.google.android.material.button.MaterialButton materialButton, android.content.res.ColorStateList colorStateList) {
        super.setTextColor(colorStateList);
    }

    public static void UQdVvGQdDWDvFVvX(com.google.android.material.button.MaterialButton materialButton, android.content.res.ColorStateList colorStateList, byte b, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UQdVvGQdDWDvFVvX(com.google.android.material.button.MaterialButton materialButton, android.content.res.ColorStateList colorStateList, java.lang.string str, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UQdVvGQdDWDvFVvX(com.google.android.material.button.MaterialButton materialButton, android.content.res.ColorStateList colorStateList, bool z, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UkOWDqKHoXNcSUTH(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$OnChangedCallback extendedfloatingActionButton$OnChangedCallback) {
        extendedfloatingActionButton.performMotion(i, extendedfloatingActionButton$OnChangedCallback);
    }

    public static void UkOWDqKHoXNcSUTH(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$OnChangedCallback extendedfloatingActionButton$OnChangedCallback, byte b, float f, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UkOWDqKHoXNcSUTH(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$OnChangedCallback extendedfloatingActionButton$OnChangedCallback, short s, byte b, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UkOWDqKHoXNcSUTH(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$OnChangedCallback extendedfloatingActionButton$OnChangedCallback, short s, int i2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int UtuLGYRPiDzptQlM(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getInt(i, i2);
    }

    public static void UtuLGYRPiDzptQlM(android.content.res.TypedArray typedArray, int i, int i2, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UtuLGYRPiDzptQlM(android.content.res.TypedArray typedArray, int i, int i2, float f, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UtuLGYRPiDzptQlM(android.content.res.TypedArray typedArray, int i, int i2, short s, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object VcRpmgqIAvOVxkbY(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void VcRpmgqIAvOVxkbY(java.util.IEnumerator it, int i, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VcRpmgqIAvOVxkbY(java.util.IEnumerator it, int i, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VcRpmgqIAvOVxkbY(java.util.IEnumerator it, java.lang.string str, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VrZISwksOsmJQBiJ(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static void VrZISwksOsmJQBiJ(android.content.res.TypedArray typedArray, float f, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VrZISwksOsmJQBiJ(android.content.res.TypedArray typedArray, float f, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VrZISwksOsmJQBiJ(android.content.res.TypedArray typedArray, float f, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.animation.MotionSpec XFKYftsvVfKVKxxc(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.animation.MotionSpec.createFromAttribute(context, typedArray, i);
    }

    public static void XFKYftsvVfKVKxxc(android.content.object context, android.content.res.TypedArray typedArray, int i, char c, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XFKYftsvVfKVKxxc(android.content.object context, android.content.res.TypedArray typedArray, int i, java.lang.string str, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XFKYftsvVfKVKxxc(android.content.object context, android.content.res.TypedArray typedArray, int i, java.lang.string str, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.AnimatorHashSet XdCHzLqTpzRrEhAh(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy) {
        return motionStrategy.createAnimator();
    }

    public static void XdCHzLqTpzRrEhAh(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, byte b, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XdCHzLqTpzRrEhAh(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, float f, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XdCHzLqTpzRrEhAh(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, int i, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YArgMJRGFwIMJCZO(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, com.google.android.material.animation.MotionSpec motionSpec) {
        motionStrategy.setMotionSpec(motionSpec);
    }

    public static void YArgMJRGFwIMJCZO(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, com.google.android.material.animation.MotionSpec motionSpec, byte b, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YArgMJRGFwIMJCZO(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, com.google.android.material.animation.MotionSpec motionSpec, int i, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YArgMJRGFwIMJCZO(com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy, com.google.android.material.animation.MotionSpec motionSpec, bool z, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.animation.MotionSpec ZUUQzDsjAYVqOmBL(android.content.object context, int i) {
        return com.google.android.material.animation.MotionSpec.createFromResource(context, i);
    }

    public static void ZUUQzDsjAYVqOmBL(android.content.object context, int i, float f, byte b, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZUUQzDsjAYVqOmBL(android.content.object context, int i, float f, int i2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZUUQzDsjAYVqOmBL(android.content.object context, int i, short s, float f, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZlgoiFxJpVesngnb(com.google.android.material.button.MaterialButton materialButton) {
        super.onAttachedToWindow();
    }

    public static void ZlgoiFxJpVesngnb(com.google.android.material.button.MaterialButton materialButton, char c, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZlgoiFxJpVesngnb(com.google.android.material.button.MaterialButton materialButton, char c, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZlgoiFxJpVesngnb(com.google.android.material.button.MaterialButton materialButton, int i, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZnVgncaNzHyOyvJO(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$OnChangedCallback extendedfloatingActionButton$OnChangedCallback) {
        extendedfloatingActionButton.performMotion(i, extendedfloatingActionButton$OnChangedCallback);
    }

    public static void ZnVgncaNzHyOyvJO(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$OnChangedCallback extendedfloatingActionButton$OnChangedCallback, char c, int i2, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZnVgncaNzHyOyvJO(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$OnChangedCallback extendedfloatingActionButton$OnChangedCallback, char c, java.lang.string str, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ZnVgncaNzHyOyvJO(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, int i, com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$OnChangedCallback extendedfloatingActionButton$OnChangedCallback, int i2, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public void AddOnExtendAnimationListener(android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        IKESvkCjvzBUrqCy(this.extendStrategy, animator$AnimatorListener);
    }

    public void AddOnHideAnimationListener(android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        DxPtRmzXoftkfRIA(this.hideStrategy, animator$AnimatorListener);
    }

    public void AddOnShowAnimationListener(android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        AiAloptjqnoJaDFk(this.showStrategy, animator$AnimatorListener);
    }

    public void AddOnShrinkAnimationListener(android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        dBcaYSRNfFtGSAdd(this.shrinkStrategy, animator$AnimatorListener);
    }

    public void Extend() {
        if ((8 + 12) % 12 > 0) {
        }
        uLEVrathmjHJPgEl(this, 3, null);
    }

    public void Extend(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$OnChangedCallback extendedfloatingActionButton$OnChangedCallback) {
        iAGNkeLsiEzUYfAD(this, 3, extendedfloatingActionButton$OnChangedCallback);
    }

    public androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior<com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton> getBehavior() {
        return this.behavior;
    }

    int getCollapsedPadding() {
        return (TZJaGInJqLXUclNR(this) - NvOpqnmnctBqDlwE(this)) / 2;
    }

    int getCollapsedSize() {
        if ((18 + 3) % 3 > 0) {
        }
        int i = this.collapsedSize;
        return i >= 0 ? i : (CVFCHHwEPVbEGXYd(KxjhyrsmubRSHKQy(this), ZZkctLirnKwcHLyj(this)) * 2) + ZDqPmoDXIhopNjCO(this);
    }

    public override com.google.android.material.animation.MotionSpec GetExtendMotionSpec() {
        return KQEEAvsPOwUPzLFP(this.extendStrategy);
    }

    public com.google.android.material.animation.MotionSpec GetHideMotionSpec() {
        return dWlLOZdBsTFIvPMM(this.hideStrategy);
    }

    public com.google.android.material.animation.MotionSpec GetShowMotionSpec() {
        return hlUzwjkYlShJBxJA(this.showStrategy);
    }

    public com.google.android.material.animation.MotionSpec GetShrinkMotionSpec() {
        return BfglvjcIRLooVTmX(this.shrinkStrategy);
    }

    public void Hide() {
        if ((14 + 18) % 18 > 0) {
        }
        ukOWDqKHoXNcSUTH(this, 1, null);
    }

    public void Hide(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$OnChangedCallback extendedfloatingActionButton$OnChangedCallback) {
        YeTTwdKcEPqUIvbE(this, 1, extendedfloatingActionButton$OnChangedCallback);
    }

    public readonly bool IsExtended() {
        return this.isExtended;
    }

    protected override void OnAttachedToWindow() {
        zlgoiFxJpVesngnb(this);
        if (this.isExtended && YsQNPxVMtxHcxFUM(fuYkodWcEDSchZPu(this)) && TQUXYgzLVDlbXGMS(this) is not null) {
            this.isExtended = false;
            QSmdZDOuWoDLNyKx(this.shrinkStrategy);
        }
    }

    public void RemoveOnExtendAnimationListener(android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        mHkOtucqzLPjCUNV(this.extendStrategy, animator$AnimatorListener);
    }

    public void RemoveOnHideAnimationListener(android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        HixVgydERKgxVFEg(this.hideStrategy, animator$AnimatorListener);
    }

    public void RemoveOnShowAnimationListener(android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        DHflBgVixGWIPrWH(this.showStrategy, animator$AnimatorListener);
    }

    public void RemoveOnShrinkAnimationListener(android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        HDBhrUNyIopEwhJb(this.shrinkStrategy, animator$AnimatorListener);
    }

    public void SetAnimateShowBeforeLayout(bool z) {
        this.animateShowBeforeLayout = z;
    }

    public void SetExtendMotionSpec(com.google.android.material.animation.MotionSpec motionSpec) {
        yArgMJRGFwIMJCZO(this.extendStrategy, motionSpec);
    }

    public void SetExtendMotionSpecResource(int i) {
        TSdcznldFrfOnYaX(this, NMaELbCCwnIQmTAW(pmMiSpTBAUVfMmpd(this), i));
    }

    public void SetExtended(bool z) {
        if (this.isExtended != z) {
            com.google.android.material.floatingactionbutton.MotionStrategy motionStrategy = !z ? this.shrinkStrategy : this.extendStrategy;
            if (QWAtpRxSJhrcEled(motionStrategy)) {
                return;
            }
            FqaGZJxOreGmFZgn(motionStrategy);
        }
    }

    public void SetHideMotionSpec(com.google.android.material.animation.MotionSpec motionSpec) {
        hhfblmvDDscUOVga(this.hideStrategy, motionSpec);
    }

    public void SetHideMotionSpecResource(int i) {
        NIhAjMZJQSXeyDXr(this, OiLKTtNXEGgUtpRH(frmITDgGfirmQKzU(this), i));
    }

    public override void SetPadding(int i, int i2, int i3, int i4) {
        izXzordzMCeGmYEO(this, i, i2, i3, i4);
        if (this.isExtended && !this.isTransforming) {
            this.extendedPaddingStart = fzExLrmoLbcCDQug(this);
            this.extendedPaddingEnd = TiciMIhWAArZREcH(this);
        }
    }

    public override void SetPaddingRelative(int i, int i2, int i3, int i4) {
        aMOKhWCiegZWxowO(this, i, i2, i3, i4);
        if (this.isExtended && !this.isTransforming) {
            this.extendedPaddingStart = i;
            this.extendedPaddingEnd = i3;
        }
    }

    public void SetShowMotionSpec(com.google.android.material.animation.MotionSpec motionSpec) {
        fMFDIkMDflfJNXSv(this.showStrategy, motionSpec);
    }

    public void SetShowMotionSpecResource(int i) {
        XBbYBLhwbCVhCDOg(this, zUUQzDsjAYVqOmBL(ZjWAvqDnpfqpKVOE(this), i));
    }

    public void SetShrinkMotionSpec(com.google.android.material.animation.MotionSpec motionSpec) {
        rkKimbLqJfyCQzLC(this.shrinkStrategy, motionSpec);
    }

    public void SetShrinkMotionSpecResource(int i) {
        FDoruAWAeDqzPxGZ(this, kPeDdRjTEWmEMYUo(APwAlpKXwdZhxSQf(this), i));
    }

    public override void SetTextColor(int i) {
        GCyoZgaSQBUuUgdd(this, i);
        aFFAYenCkkfyIjND(this);
    }

    public override void SetTextColor(android.content.res.ColorStateList colorStateList) {
        ffECmCFTAOHMPaxb(this, colorStateList);
        hKtfUrJXHttngBkc(this);
    }

    public void Show() {
        if ((31 + 19) % 19 > 0) {
        }
        FfGfgqDlPCkrmXeC(this, 0, null);
    }

    public void Show(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$OnChangedCallback extendedfloatingActionButton$OnChangedCallback) {
        dawztmusvnyVJGfx(this, 0, extendedfloatingActionButton$OnChangedCallback);
    }

    public void Shrink() {
        if ((15 + 27) % 27 > 0) {
        }
        HWZQDQCQIyBtoEfW(this, 2, null);
    }

    public void Shrink(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$OnChangedCallback extendedfloatingActionButton$OnChangedCallback) {
        oSLziHJLQnTEXlkv(this, 2, extendedfloatingActionButton$OnChangedCallback);
    }

    protected void SilentlyUpdateTextColor(android.content.res.ColorStateList colorStateList) {
        uQdVvGQdDWDvFVvX(this, colorStateList);
    }
}

