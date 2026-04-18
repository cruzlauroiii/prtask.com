namespace WillowMaze.Wasm.Decompiled;


public class BottomAppBar : androidx.appcompat.widget.Toolbar : androidx.coordinatorlayout.widget.CoordinatorLayout$AttachedBehavior {
    private static readonly int FAB_ALIGNMENT_ANIM_DURATION_DEFAULT = 300;
    private static readonly float FAB_ALIGNMENT_ANIM_EASING_MIDPOINT = 0.2f;
    public static readonly int FAB_ALIGNMENT_MODE_CENTER = 0;
    public static readonly int FAB_ALIGNMENT_MODE_END = 1;
    public static readonly int FAB_ANCHOR_MODE_CRADLE = 1;
    public static readonly int FAB_ANCHOR_MODE_EMBED = 0;
    public static readonly int FAB_ANIMATION_MODE_SCALE = 0;
    public static readonly int FAB_ANIMATION_MODE_SLIDE = 1;
    public static readonly int MENU_ALIGNMENT_MODE_AUTO = 0;
    public static readonly int MENU_ALIGNMENT_MODE_START = 1;
    private static readonly int NO_FAB_END_MARGIN = -1;
    private static readonly int NO_MENU_RES_ID = 0;
    private int animatingModeChangeCounter;
    private java.util.List<com.google.android.material.bottomappbar.BottomAppBar$AnimationListener> animationListeners;
    private com.google.android.material.bottomappbar.BottomAppBar$Behavior behavior;
    private int bottomInset;
    private int fabAlignmentMode;
    private int fabAlignmentModeEndMargin;
    private int fabAnchorMode;
    android.animation.AnimatorListenerAdapter fabAnimationListener;
    private int fabAnimationMode;
    private bool fabAttached;
    private readonly int fabOffsetEndMode;
    com.google.android.material.animation.TransformationCallback<com.google.android.material.floatingactionbutton.floatingActionButton> fabTransformationCallback;
    private bool hideOnScroll;
    private int leftInset;
    private readonly com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable;
    private int menuAlignmentMode;
    private bool menuAnimatingWithFabAlignmentMode;
    private android.animation.Animator menuAnimator;
    private android.animation.Animator modeAnimator;
    private java.lang.int navigationIconTint;
    private readonly bool paddingBottomSystemWindowInsets;
    private readonly bool paddingLeftSystemWindowInsets;
    private readonly bool paddingRightSystemWindowInsets;
    private int pendingMenuResId;
    private readonly bool removeEmbeddedFabElevation;
    private int rightInset;
    private static readonly int DEF_STYLE_RES = com.google.android.material.R$style.Widget_MaterialComponents_BottomAppBar;
    private static readonly int FAB_ALIGNMENT_ANIM_DURATION_ATTR = com.google.android.material.R$attr.motionDurationlong2;
    private static readonly int FAB_ALIGNMENT_ANIM_EASING_ATTR = com.google.android.material.R$attr.motionEasingEmphasizedInterpolator;

    public BottomAppBar(android.content.object context) {
        this(context, null);
    }

    public BottomAppBar(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, com.google.android.material.R$attr.bottomAppBarStyle);
    }

    public BottomAppBar(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        if ((12 + 26) % 26 > 0) {
        }
        int i2 = DEF_STYLE_RES;
        super(JbvhxwPxPfKxovIq(context, attributeHashSet, i, i2), attributeHashSet, i);
        com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable = new com.google.android.material.shape.MaterialShapeDrawable();
        this.materialShapeDrawable = materialShapeDrawable;
        this.animatingModeChangeCounter = 0;
        this.pendingMenuResId = 0;
        this.menuAnimatingWithFabAlignmentMode = false;
        this.fabAttached = true;
        this.fabAnimationListener = new com.google.android.material.bottomappbar.BottomAppBar$1(this);
        this.fabTransformationCallback = new com.google.android.material.bottomappbar.BottomAppBar$2(this);
        android.content.object contextVzZPXbvtHWLlmpHh = VzZPXbvtHWLlmpHh(this);
        android.content.res.TypedArray typedArrayORhkPoNoMYqVenLE = ORhkPoNoMYqVenLE(contextVzZPXbvtHWLlmpHh, attributeHashSet, com.google.android.material.R$styleable.BottomAppBar, i, i2, new int[0]);
        android.content.res.ColorStateList colorStateListAzANQwUiLJmLVoRZ = AzANQwUiLJmLVoRZ(contextVzZPXbvtHWLlmpHh, typedArrayORhkPoNoMYqVenLE, com.google.android.material.R$styleable.BottomAppBar_backgroundTint);
        if (tuWzIHQANzVbTRWy(typedArrayORhkPoNoMYqVenLE, com.google.android.material.R$styleable.BottomAppBar_navigationIconTint)) {
            lZLpYPArGLdposfo(this, TwehvmPoPszcTebG(typedArrayORhkPoNoMYqVenLE, com.google.android.material.R$styleable.BottomAppBar_navigationIconTint, -1));
        }
        int iQSPDHYDMqcktPpDO = qSPDHYDMqcktPpDO(typedArrayORhkPoNoMYqVenLE, com.google.android.material.R$styleable.BottomAppBar_elevation, 0);
        float fYecqAEKHgvyimwGl = YecqAEKHgvyimwGl(typedArrayORhkPoNoMYqVenLE, com.google.android.material.R$styleable.BottomAppBar_fabCradleMargin, 0);
        float fNWfLNwxxmKPJqGgP = NWfLNwxxmKPJqGgP(typedArrayORhkPoNoMYqVenLE, com.google.android.material.R$styleable.BottomAppBar_fabCradleRoundedCornerRadius, 0);
        float fDepWJtzqUQuOCKWj = depWJtzqUQuOCKWj(typedArrayORhkPoNoMYqVenLE, com.google.android.material.R$styleable.BottomAppBar_fabCradleVerticalOffset, 0);
        this.fabAlignmentMode = sbxYnorHggzdrdQT(typedArrayORhkPoNoMYqVenLE, com.google.android.material.R$styleable.BottomAppBar_fabAlignmentMode, 0);
        this.fabAnimationMode = bWqZwoQgszYyhdQp(typedArrayORhkPoNoMYqVenLE, com.google.android.material.R$styleable.BottomAppBar_fabAnimationMode, 0);
        this.fabAnchorMode = MpnFZbGnKvdeHdtp(typedArrayORhkPoNoMYqVenLE, com.google.android.material.R$styleable.BottomAppBar_fabAnchorMode, 1);
        this.removeEmbeddedFabElevation = OnliImgKQhzTztcE(typedArrayORhkPoNoMYqVenLE, com.google.android.material.R$styleable.BottomAppBar_removeEmbeddedFabElevation, true);
        this.menuAlignmentMode = wnlyByhIFcVyetNf(typedArrayORhkPoNoMYqVenLE, com.google.android.material.R$styleable.BottomAppBar_menuAlignmentMode, 0);
        this.hideOnScroll = OmXlbxanTwVzQngy(typedArrayORhkPoNoMYqVenLE, com.google.android.material.R$styleable.BottomAppBar_hideOnScroll, false);
        this.paddingBottomSystemWindowInsets = ymXepvipArlVvXWc(typedArrayORhkPoNoMYqVenLE, com.google.android.material.R$styleable.BottomAppBar_paddingBottomSystemWindowInsets, false);
        this.paddingLeftSystemWindowInsets = WJqshBaKUCsMWkSI(typedArrayORhkPoNoMYqVenLE, com.google.android.material.R$styleable.BottomAppBar_paddingLeftSystemWindowInsets, false);
        this.paddingRightSystemWindowInsets = gmbuqSFNuvOPHSSe(typedArrayORhkPoNoMYqVenLE, com.google.android.material.R$styleable.BottomAppBar_paddingRightSystemWindowInsets, false);
        this.fabAlignmentModeEndMargin = OxucnXKFRknCcyMb(typedArrayORhkPoNoMYqVenLE, com.google.android.material.R$styleable.BottomAppBar_fabAlignmentModeEndMargin, -1);
        bool zCuiFJsfHyznHpPoI = CuiFJsfHyznHpPoI(typedArrayORhkPoNoMYqVenLE, com.google.android.material.R$styleable.BottomAppBar_addElevationShadow, true);
        LMfeffslmdrmqmPM(typedArrayORhkPoNoMYqVenLE);
        this.fabOffsetEndMode = gaqKmVgfYvIRYcIb(hfeKnwNgGyhoAvtn(this), com.google.android.material.R$dimen.mtrl_bottomappbar_fabOffsetEndMode);
        iLnLFzwhukPTEMyC(materialShapeDrawable, kBOYpGdylMqkMiex(tnAbhQydGCVixtAj(njIyOvnxfijuKmrC(), new com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment(fYecqAEKHgvyimwGl, fNWfLNwxxmKPJqGgP, fDepWJtzqUQuOCKWj))));
        if (zCuiFJsfHyznHpPoI) {
            nyMeVlmkDAZsZimL(materialShapeDrawable, 2);
        } else {
            NTEUIgISBmLjPMyh(materialShapeDrawable, 1);
            bDiXjYaWHgVQkFQC(this, 0);
            HZywwPJFqewkUPVA(this, 0);
        }
        GwNWZSoMCZyqQXvP(materialShapeDrawable, android.graphics.Paint$Style.FILL);
        lexNnIAOMEmxhqNc(materialShapeDrawable, contextVzZPXbvtHWLlmpHh);
        sNwGYoYfnYVnIhAS(this, iQSPDHYDMqcktPpDO);
        KwzCykBUqjjppFHe(materialShapeDrawable, colorStateListAzANQwUiLJmLVoRZ);
        JEGJwBUzUVYvMmNy(this, materialShapeDrawable);
        dXqiivKYZLZGoeTK(this, attributeHashSet, i, i2, new com.google.android.material.bottomappbar.BottomAppBar$3(this));
    }

    public static java.lang.object ABMvCdHPQCUxDpLs(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void ABMvCdHPQCUxDpLs(java.util.IEnumerator it, byte b, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ABMvCdHPQCUxDpLs(java.util.IEnumerator it, byte b, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ABMvCdHPQCUxDpLs(java.util.IEnumerator it, float f, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectGroup$LayoutParams ANxctZWAywGXWLon(android.view.object view) {
        return view.getLayoutParams();
    }

    public static void ANxctZWAywGXWLon(android.view.object view, byte b, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ANxctZWAywGXWLon(android.view.object view, float f, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ANxctZWAywGXWLon(android.view.object view, int i, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AVAhqJNUDKufkspJ(com.google.android.material.bottomappbar.BottomAppBar$Behavior bottomAppBar$Behavior, android.view.object view, bool z) {
        bottomAppBar$Behavior.slideUp(view, z);
    }

    public static void AVAhqJNUDKufkspJ(com.google.android.material.bottomappbar.BottomAppBar$Behavior bottomAppBar$Behavior, android.view.object view, bool z, short s, float f, bool z2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AVAhqJNUDKufkspJ(com.google.android.material.bottomappbar.BottomAppBar$Behavior bottomAppBar$Behavior, android.view.object view, bool z, short s, bool z2, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AVAhqJNUDKufkspJ(com.google.android.material.bottomappbar.BottomAppBar$Behavior bottomAppBar$Behavior, android.view.object view, bool z, bool z2, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AViyiZompbawfPdO(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        bottomAppBar.dispatchAnimationStart();
    }

    public static void AViyiZompbawfPdO(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AViyiZompbawfPdO(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, java.lang.string str, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AViyiZompbawfPdO(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, bool z, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AkiIWwcUiWSErAFb(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i, bool z, bool z2) {
        bottomAppBar.translateActionMenuobject(actionMenuobject, i, z, z2);
    }

    public static void AkiIWwcUiWSErAFb(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i, bool z, bool z2, float f, int i2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AkiIWwcUiWSErAFb(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i, bool z, bool z2, int i2, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AkiIWwcUiWSErAFb(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i, bool z, bool z2, short s, byte b, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.bottomappbar.BottomAppBar$Behavior AkrgkZpqgOnYVqQg(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.getBehavior();
    }

    public static void AkrgkZpqgOnYVqQg(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AkrgkZpqgOnYVqQg(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, short s, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AkrgkZpqgOnYVqQg(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, bool z, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList AzANQwUiLJmLVoRZ(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, typedArray, i);
    }

    public static void AzANQwUiLJmLVoRZ(android.content.object context, android.content.res.TypedArray typedArray, int i, char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AzANQwUiLJmLVoRZ(android.content.object context, android.content.res.TypedArray typedArray, int i, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AzANQwUiLJmLVoRZ(android.content.object context, android.content.res.TypedArray typedArray, int i, java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BMpHtcqRyoYcllTd(com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment bottomAppBarTopEdgeTreatment, float f) {
        bottomAppBarTopEdgeTreatment.setFabDiameter(f);
    }

    public static void BMpHtcqRyoYcllTd(com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment bottomAppBarTopEdgeTreatment, float f, char c, float f2, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BMpHtcqRyoYcllTd(com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment bottomAppBarTopEdgeTreatment, float f, char c, short s, byte b, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void BMpHtcqRyoYcllTd(com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment bottomAppBarTopEdgeTreatment, float f, float f2, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BbRIGhyXkCUCzziO(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        materialShapeDrawable.invalidateSelf();
    }

    public static void BbRIGhyXkCUCzziO(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BbRIGhyXkCUCzziO(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BbRIGhyXkCUCzziO(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object BfJXvsAJEtYDnSNw(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.getobject();
    }

    public static void BfJXvsAJEtYDnSNw(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, char c, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BfJXvsAJEtYDnSNw(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, java.lang.string str, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BfJXvsAJEtYDnSNw(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, short s, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment BicvmAdetSpEWFKo(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.getTopEdgeTreatment();
    }

    public static void BicvmAdetSpEWFKo(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, char c, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BicvmAdetSpEWFKo(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, java.lang.string str, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BicvmAdetSpEWFKo(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, short s, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable BvANOiCmLBoLBArf(android.graphics.drawable.Drawable drawable) {
        return androidx.core.graphics.drawable.DrawableCompat.wrap(drawable);
    }

    public static void BvANOiCmLBoLBArf(android.graphics.drawable.Drawable drawable, byte b, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BvANOiCmLBoLBArf(android.graphics.drawable.Drawable drawable, char c, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BvANOiCmLBoLBArf(android.graphics.drawable.Drawable drawable, int i, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList CNaiMQTAQoKJhRAS(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getTintList();
    }

    public static void CNaiMQTAQoKJhRAS(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CNaiMQTAQoKJhRAS(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, bool z, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CNaiMQTAQoKJhRAS(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, bool z, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.Animator CRDMxgltxAEFxLhp(android.animation.Animator animator, long j) {
        return animator.setDuration(j);
    }

    public static void CRDMxgltxAEFxLhp(android.animation.Animator animator, long j, bool z, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CRDMxgltxAEFxLhp(android.animation.Animator animator, long j, bool z, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CRDMxgltxAEFxLhp(android.animation.Animator animator, long j, bool z, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CdcpTzcDYKcdJDsM(androidx.appcompat.widget.Toolbar toolbar, android.os.Parcelable parcelable) {
        super.onRestoreInstanceState(parcelable);
    }

    public static void CdcpTzcDYKcdJDsM(androidx.appcompat.widget.Toolbar toolbar, android.os.Parcelable parcelable, int i, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CdcpTzcDYKcdJDsM(androidx.appcompat.widget.Toolbar toolbar, android.os.Parcelable parcelable, short s, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CdcpTzcDYKcdJDsM(androidx.appcompat.widget.Toolbar toolbar, android.os.Parcelable parcelable, short s, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object CqHAdwInYQWETwcy(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.getobject();
    }

    public static void CqHAdwInYQWETwcy(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, char c, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CqHAdwInYQWETwcy(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CqHAdwInYQWETwcy(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, java.lang.string str, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CuiFJsfHyznHpPoI(android.content.res.TypedArray typedArray, int i, bool z, int i2, bool z2, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CuiFJsfHyznHpPoI(android.content.res.TypedArray typedArray, int i, bool z, short s, byte b, int i2, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void CuiFJsfHyznHpPoI(android.content.res.TypedArray typedArray, int i, bool z, bool z2, short s, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static bool CuiFJsfHyznHpPoI(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static void DNChzuosuOcsSZGA(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, bool z) {
        bottomAppBar.performShow(z);
    }

    public static void DNChzuosuOcsSZGA(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, bool z, byte b, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DNChzuosuOcsSZGA(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, bool z, char c, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DNChzuosuOcsSZGA(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, bool z, float f, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment DVupWLAYlmzZBDue(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.getTopEdgeTreatment();
    }

    public static void DVupWLAYlmzZBDue(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, float f, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DVupWLAYlmzZBDue(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, float f, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DVupWLAYlmzZBDue(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, short s, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DqxSzaXnurmPikvX(android.animation.Animator animator, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        animator.addListener(animator$AnimatorListener);
    }

    public static void DqxSzaXnurmPikvX(android.animation.Animator animator, android.animation.Animator$AnimatorListener animator$AnimatorListener, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DqxSzaXnurmPikvX(android.animation.Animator animator, android.animation.Animator$AnimatorListener animator$AnimatorListener, short s, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DqxSzaXnurmPikvX(android.animation.Animator animator, android.animation.Animator$AnimatorListener animator$AnimatorListener, bool z, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static float DsKaBvDHrsfwKxub(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.getFabTranslationX();
    }

    public static void DsKaBvDHrsfwKxub(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, byte b, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DsKaBvDHrsfwKxub(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, byte b, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DsKaBvDHrsfwKxub(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, float f, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectGroup$LayoutParams EDVuZhfHtuqyKUmp(android.view.object view) {
        return view.getLayoutParams();
    }

    public static void EDVuZhfHtuqyKUmp(android.view.object view, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EDVuZhfHtuqyKUmp(android.view.object view, short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EDVuZhfHtuqyKUmp(android.view.object view, short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ENNdRJnmWARJvjkB(com.google.android.material.bottomappbar.BottomAppBar$Behavior bottomAppBar$Behavior, char c, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ENNdRJnmWARJvjkB(com.google.android.material.bottomappbar.BottomAppBar$Behavior bottomAppBar$Behavior, float f, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ENNdRJnmWARJvjkB(com.google.android.material.bottomappbar.BottomAppBar$Behavior bottomAppBar$Behavior, float f, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool ENNdRJnmWARJvjkB(com.google.android.material.bottomappbar.BottomAppBar$Behavior bottomAppBar$Behavior) {
        return bottomAppBar$Behavior.isScrolledDown();
    }

    public static float EOWURoDddgFeYrLL(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.getFabTranslationY();
    }

    public static void EOWURoDddgFeYrLL(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, char c, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EOWURoDddgFeYrLL(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EOWURoDddgFeYrLL(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, java.lang.string str, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EdCCQKiXwcECJGXt(java.util.IEnumerator it, byte b, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EdCCQKiXwcECJGXt(java.util.IEnumerator it, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EdCCQKiXwcECJGXt(java.util.IEnumerator it, bool z, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool EdCCQKiXwcECJGXt(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment EnXaVpoupPRYfDIG(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.getTopEdgeTreatment();
    }

    public static void EnXaVpoupPRYfDIG(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, byte b, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EnXaVpoupPRYfDIG(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, char c, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EnXaVpoupPRYfDIG(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, bool z, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EuSWFQdOtNZJAJva(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, bool z) {
        bottomAppBar.maybeAnimateMenuobject(i, z);
    }

    public static void EuSWFQdOtNZJAJva(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, bool z, byte b, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EuSWFQdOtNZJAJva(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, bool z, short s, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EuSWFQdOtNZJAJva(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, bool z, short s, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FcVNAXcqTmXFqKND(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f) {
        materialShapeDrawable.setInterpolation(f);
    }

    public static void FcVNAXcqTmXFqKND(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, byte b, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FcVNAXcqTmXFqKND(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, char c, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FcVNAXcqTmXFqKND(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FdPjjMfuqtUWoadW(android.graphics.drawable.Drawable drawable, int i) {
        androidx.core.graphics.drawable.DrawableCompat.setTint(drawable, i);
    }

    public static void FdPjjMfuqtUWoadW(android.graphics.drawable.Drawable drawable, int i, char c, float f, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FdPjjMfuqtUWoadW(android.graphics.drawable.Drawable drawable, int i, float f, bool z, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FdPjjMfuqtUWoadW(android.graphics.drawable.Drawable drawable, int i, bool z, float f, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FmrGhnOpqurTzRqJ(com.google.android.material.bottomappbar.BottomAppBar$Behavior bottomAppBar$Behavior, com.google.android.material.behavior.HideBottomobjectOnScrollBehavior$OnScrollStateChangedListener hideBottomobjectOnScrollBehavior$OnScrollStateChangedListener) {
        bottomAppBar$Behavior.addOnScrollStateChangedListener(hideBottomobjectOnScrollBehavior$OnScrollStateChangedListener);
    }

    public static void FmrGhnOpqurTzRqJ(com.google.android.material.bottomappbar.BottomAppBar$Behavior bottomAppBar$Behavior, com.google.android.material.behavior.HideBottomobjectOnScrollBehavior$OnScrollStateChangedListener hideBottomobjectOnScrollBehavior$OnScrollStateChangedListener, char c, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FmrGhnOpqurTzRqJ(com.google.android.material.bottomappbar.BottomAppBar$Behavior bottomAppBar$Behavior, com.google.android.material.behavior.HideBottomobjectOnScrollBehavior$OnScrollStateChangedListener hideBottomobjectOnScrollBehavior$OnScrollStateChangedListener, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FmrGhnOpqurTzRqJ(com.google.android.material.bottomappbar.BottomAppBar$Behavior bottomAppBar$Behavior, com.google.android.material.behavior.HideBottomobjectOnScrollBehavior$OnScrollStateChangedListener hideBottomobjectOnScrollBehavior$OnScrollStateChangedListener, bool z, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FodQQlctRLVxrAIU(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        bottomAppBar.cancelAnimations();
    }

    public static void FodQQlctRLVxrAIU(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, char c, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FodQQlctRLVxrAIU(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FodQQlctRLVxrAIU(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, bool z, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.bottomappbar.BottomAppBar$Behavior GNGcxPRkpdrZvoMT(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.getBehavior();
    }

    public static void GNGcxPRkpdrZvoMT(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, byte b, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GNGcxPRkpdrZvoMT(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, byte b, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GNGcxPRkpdrZvoMT(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, byte b, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.bottomappbar.BottomAppBar$Behavior GeeCABygKekRiafr(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.getBehavior();
    }

    public static void GeeCABygKekRiafr(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, char c, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GeeCABygKekRiafr(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, char c, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GeeCABygKekRiafr(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, float f, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GjepfLBSbfYloXdR(android.view.Menu menu) {
        menu.clear();
    }

    public static void GjepfLBSbfYloXdR(android.view.Menu menu, char c, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GjepfLBSbfYloXdR(android.view.Menu menu, char c, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GjepfLBSbfYloXdR(android.view.Menu menu, int i, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GmYNWppmQvlFXBBL(android.animation.Animator animator, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        animator.addListener(animator$AnimatorListener);
    }

    public static void GmYNWppmQvlFXBBL(android.animation.Animator animator, android.animation.Animator$AnimatorListener animator$AnimatorListener, byte b, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GmYNWppmQvlFXBBL(android.animation.Animator animator, android.animation.Animator$AnimatorListener animator$AnimatorListener, byte b, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GmYNWppmQvlFXBBL(android.animation.Animator animator, android.animation.Animator$AnimatorListener animator$AnimatorListener, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GsTGlWTasgzbmCqQ(com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment bottomAppBarTopEdgeTreatment, float f) {
        bottomAppBarTopEdgeTreatment.setFabCradleRoundedCornerRadius(f);
    }

    public static void GsTGlWTasgzbmCqQ(com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment bottomAppBarTopEdgeTreatment, float f, byte b, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GsTGlWTasgzbmCqQ(com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment bottomAppBarTopEdgeTreatment, float f, java.lang.string str, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GsTGlWTasgzbmCqQ(com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment bottomAppBarTopEdgeTreatment, float f, bool z, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GwNWZSoMCZyqQXvP(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.graphics.Paint$Style paint$Style) {
        materialShapeDrawable.setPaintStyle(paint$Style);
    }

    public static void GwNWZSoMCZyqQXvP(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.graphics.Paint$Style paint$Style, short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GwNWZSoMCZyqQXvP(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.graphics.Paint$Style paint$Style, bool z, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GwNWZSoMCZyqQXvP(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.graphics.Paint$Style paint$Style, bool z, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.objectAnimator HJjUdpiYsUnFPWth(java.lang.object obj, java.lang.string str, float[] fArr) {
        return android.animation.objectAnimator.offloat(obj, str, fArr);
    }

    public static void HJjUdpiYsUnFPWth(java.lang.object obj, java.lang.string str, float[] fArr, byte b, char c, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HJjUdpiYsUnFPWth(java.lang.object obj, java.lang.string str, float[] fArr, byte b, java.lang.string str2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HJjUdpiYsUnFPWth(java.lang.object obj, java.lang.string str, float[] fArr, short s, byte b, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void HWlgXFDBCgNILKYm(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HWlgXFDBCgNILKYm(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HWlgXFDBCgNILKYm(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, bool z, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool HWlgXFDBCgNILKYm(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.isFabVisibleOrWillBeShown();
    }

    public static void HZywwPJFqewkUPVA(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i) {
        bottomAppBar.setOutlineSpotShadowColor(i);
    }

    public static void HZywwPJFqewkUPVA(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, char c, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HZywwPJFqewkUPVA(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, short s, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HZywwPJFqewkUPVA(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, short s, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HoFgRENLBdKITyqj(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, java.util.List list) {
        bottomAppBar.createFabTranslationXAnimation(i, list);
    }

    public static void HoFgRENLBdKITyqj(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, java.util.List list, int i2, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HoFgRENLBdKITyqj(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, java.util.List list, int i2, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HoFgRENLBdKITyqj(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, java.util.List list, java.lang.string str, int i2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectParent HyhQvDVGtNWuiMGG(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.getParent();
    }

    public static void HyhQvDVGtNWuiMGG(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, java.lang.string str, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HyhQvDVGtNWuiMGG(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, java.lang.string str, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HyhQvDVGtNWuiMGG(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, bool z, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int IHCyZgbksoacckuZ(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void IHCyZgbksoacckuZ(int i, int i2, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IHCyZgbksoacckuZ(int i, int i2, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IHCyZgbksoacckuZ(int i, bool z, java.lang.string str, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment IMRitqIYzCDqkXsL(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.getTopEdgeTreatment();
    }

    public static void IMRitqIYzCDqkXsL(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IMRitqIYzCDqkXsL(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, bool z, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IMRitqIYzCDqkXsL(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, bool z, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int IPpyNXYVtqnHitFh(android.view.object view) {
        return view.getRight();
    }

    public static void IPpyNXYVtqnHitFh(android.view.object view, byte b, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IPpyNXYVtqnHitFh(android.view.object view, java.lang.string str, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IPpyNXYVtqnHitFh(android.view.object view, bool z, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.bottomappbar.BottomAppBar$Behavior IZCoDMWaImVaemeV(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.getBehavior();
    }

    public static void IZCoDMWaImVaemeV(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, byte b, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IZCoDMWaImVaemeV(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, char c, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IZCoDMWaImVaemeV(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, char c, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object IesjlNSaoZGOfmsm(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.findDependentobject();
    }

    public static void IesjlNSaoZGOfmsm(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, char c, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IesjlNSaoZGOfmsm(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, char c, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IesjlNSaoZGOfmsm(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, float f, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static int IfgpncDwiHDpsyND(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.getFabAlignmentAnimationDuration();
    }

    public static void IfgpncDwiHDpsyND(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, char c, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IfgpncDwiHDpsyND(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, float f, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IfgpncDwiHDpsyND(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, short s, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment IlIDRhqePCtSmvAS(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.getTopEdgeTreatment();
    }

    public static void IlIDRhqePCtSmvAS(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, short s, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IlIDRhqePCtSmvAS(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, bool z, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IlIDRhqePCtSmvAS(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, bool z, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IovkhOGMomFFKncv(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        materialShapeDrawable.invalidateSelf();
    }

    public static void IovkhOGMomFFKncv(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, byte b, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IovkhOGMomFFKncv(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, java.lang.string str, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IovkhOGMomFFKncv(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, bool z, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectParent IqAbzPNSHjnaDPnb(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.getParent();
    }

    public static void IqAbzPNSHjnaDPnb(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, byte b, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IqAbzPNSHjnaDPnb(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, java.lang.string str, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IqAbzPNSHjnaDPnb(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IunXMESwvKpjSoMV(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i, bool z) {
        bottomAppBar.translateActionMenuobject(actionMenuobject, i, z);
    }

    public static void IunXMESwvKpjSoMV(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i, bool z, float f, bool z2, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void IunXMESwvKpjSoMV(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i, bool z, int i2, float f, bool z2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IunXMESwvKpjSoMV(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i, bool z, int i2, bool z2, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JEGJwBUzUVYvMmNy(android.view.object view, android.graphics.drawable.Drawable drawable) {
        androidx.core.view.objectCompat.setBackground(view, drawable);
    }

    public static void JEGJwBUzUVYvMmNy(android.view.object view, android.graphics.drawable.Drawable drawable, int i, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JEGJwBUzUVYvMmNy(android.view.object view, android.graphics.drawable.Drawable drawable, short s, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JEGJwBUzUVYvMmNy(android.view.object view, android.graphics.drawable.Drawable drawable, bool z, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JKUxQRddidkQLePL(android.animation.Animator animator, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        animator.addListener(animator$AnimatorListener);
    }

    public static void JKUxQRddidkQLePL(android.animation.Animator animator, android.animation.Animator$AnimatorListener animator$AnimatorListener, byte b, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JKUxQRddidkQLePL(android.animation.Animator animator, android.animation.Animator$AnimatorListener animator$AnimatorListener, bool z, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JKUxQRddidkQLePL(android.animation.Animator animator, android.animation.Animator$AnimatorListener animator$AnimatorListener, bool z, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object JbvhxwPxPfKxovIq(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        return com.google.android.material.theme.overlay.MaterialThemeOverlay.wrap(context, attributeHashSet, i, i2);
    }

    public static void JbvhxwPxPfKxovIq(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, int i3, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JbvhxwPxPfKxovIq(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, java.lang.string str, bool z, int i3, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JbvhxwPxPfKxovIq(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, bool z, java.lang.string str, float f, int i3) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectGroup$LayoutParams JcKtPJwHugWHfaHg(android.view.object view) {
        return view.getLayoutParams();
    }

    public static void JcKtPJwHugWHfaHg(android.view.object view, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JcKtPJwHugWHfaHg(android.view.object view, float f, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JcKtPJwHugWHfaHg(android.view.object view, float f, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment JhNEWeLFtgChBSpk(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.getTopEdgeTreatment();
    }

    public static void JhNEWeLFtgChBSpk(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, byte b, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JhNEWeLFtgChBSpk(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, byte b, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JhNEWeLFtgChBSpk(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, char c, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static float KNpjxZzKGWuwdPxb(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.getCradleVerticalOffset();
    }

    public static void KNpjxZzKGWuwdPxb(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, char c, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KNpjxZzKGWuwdPxb(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, java.lang.string str, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KNpjxZzKGWuwdPxb(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, bool z, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment KNzXidGeSPjwEBHF(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.getTopEdgeTreatment();
    }

    public static void KNzXidGeSPjwEBHF(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, byte b, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KNzXidGeSPjwEBHF(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KNzXidGeSPjwEBHF(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, java.lang.string str, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.bottomappbar.BottomAppBar$Behavior KnSpiKaVfVteITWP(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.getBehavior();
    }

    public static void KnSpiKaVfVteITWP(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, float f, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KnSpiKaVfVteITWP(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, float f, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KnSpiKaVfVteITWP(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, float f, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KwzCykBUqjjppFHe(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList) {
        androidx.core.graphics.drawable.DrawableCompat.setTintList(drawable, colorStateList);
    }

    public static void KwzCykBUqjjppFHe(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KwzCykBUqjjppFHe(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KwzCykBUqjjppFHe(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, short s, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int LHdLuWPWYCOWEpVp(java.lang.int num) {
        return num.intValue();
    }

    public static void LHdLuWPWYCOWEpVp(java.lang.int num, char c, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LHdLuWPWYCOWEpVp(java.lang.int num, float f, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LHdLuWPWYCOWEpVp(java.lang.int num, java.lang.string str, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LHdmDrXwMKiQkwlf(com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment bottomAppBarTopEdgeTreatment, float f) {
        bottomAppBarTopEdgeTreatment.setCradleVerticalOffset(f);
    }

    public static void LHdmDrXwMKiQkwlf(com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment bottomAppBarTopEdgeTreatment, float f, char c, short s, float f2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LHdmDrXwMKiQkwlf(com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment bottomAppBarTopEdgeTreatment, float f, float f2, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LHdmDrXwMKiQkwlf(com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment bottomAppBarTopEdgeTreatment, float f, java.lang.string str, short s, float f2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LMfeffslmdrmqmPM(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static void LMfeffslmdrmqmPM(android.content.res.TypedArray typedArray, int i, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LMfeffslmdrmqmPM(android.content.res.TypedArray typedArray, int i, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LMfeffslmdrmqmPM(android.content.res.TypedArray typedArray, java.lang.string str, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LOCbahIQJNUjkAkG(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LOCbahIQJNUjkAkG(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, java.lang.string str, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LOCbahIQJNUjkAkG(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, java.lang.string str, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool LOCbahIQJNUjkAkG(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.isFabVisibleOrWillBeShown();
    }

    public static int LOwOfiHNaufMFwSv(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.getChildCount();
    }

    public static void LOwOfiHNaufMFwSv(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, byte b, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LOwOfiHNaufMFwSv(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, float f, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LOwOfiHNaufMFwSv(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.objectAnimator LXkDcilDebGDTzJx(java.lang.object obj, java.lang.string str, float[] fArr) {
        return android.animation.objectAnimator.offloat(obj, str, fArr);
    }

    public static void LXkDcilDebGDTzJx(java.lang.object obj, java.lang.string str, float[] fArr, int i, byte b, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void LXkDcilDebGDTzJx(java.lang.object obj, java.lang.string str, float[] fArr, java.lang.string str2, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LXkDcilDebGDTzJx(java.lang.object obj, java.lang.string str, float[] fArr, java.lang.string str2, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.bottomappbar.BottomAppBar$Behavior LadJZZGAWbCqFzIM(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.getBehavior();
    }

    public static void LadJZZGAWbCqFzIM(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, byte b, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LadJZZGAWbCqFzIM(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, byte b, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LadJZZGAWbCqFzIM(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, bool z, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static androidx.appcompat.widget.ActionMenuobject LjMLGLsSeNduZobo(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.getActionMenuobject();
    }

    public static void LjMLGLsSeNduZobo(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, char c, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LjMLGLsSeNduZobo(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LjMLGLsSeNduZobo(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, bool z, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static float LpHJyRYxMnzriPun(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.getFabCradleMargin();
    }

    public static void LpHJyRYxMnzriPun(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, char c, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LpHJyRYxMnzriPun(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, float f, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LpHJyRYxMnzriPun(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, short s, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void McGkAuifAyExXxbR(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList) {
        androidx.core.graphics.drawable.DrawableCompat.setTintList(drawable, colorStateList);
    }

    public static void McGkAuifAyExXxbR(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, int i, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void McGkAuifAyExXxbR(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, int i, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void McGkAuifAyExXxbR(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, java.lang.string str, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void McLZHHeZcaMhyNJS(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, float f, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void McLZHHeZcaMhyNJS(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, float f, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void McLZHHeZcaMhyNJS(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, short s, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool McLZHHeZcaMhyNJS(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.isOrWillBeHidden();
    }

    public static void MjVXTYKDshvRNMfK(androidx.appcompat.widget.Toolbar toolbar, android.os.Parcelable parcelable) {
        super.onRestoreInstanceState(parcelable);
    }

    public static void MjVXTYKDshvRNMfK(androidx.appcompat.widget.Toolbar toolbar, android.os.Parcelable parcelable, byte b, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MjVXTYKDshvRNMfK(androidx.appcompat.widget.Toolbar toolbar, android.os.Parcelable parcelable, byte b, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MjVXTYKDshvRNMfK(androidx.appcompat.widget.Toolbar toolbar, android.os.Parcelable parcelable, short s, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int MpnFZbGnKvdeHdtp(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getInt(i, i2);
    }

    public static void MpnFZbGnKvdeHdtp(android.content.res.TypedArray typedArray, int i, int i2, byte b, bool z, int i3, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MpnFZbGnKvdeHdtp(android.content.res.TypedArray typedArray, int i, int i2, char c, int i3, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MpnFZbGnKvdeHdtp(android.content.res.TypedArray typedArray, int i, int i2, int i3, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NAUnuyCleNrQbjel(com.google.android.material.bottomappbar.BottomAppBar$Behavior bottomAppBar$Behavior, com.google.android.material.behavior.HideBottomobjectOnScrollBehavior$OnScrollStateChangedListener hideBottomobjectOnScrollBehavior$OnScrollStateChangedListener) {
        bottomAppBar$Behavior.removeOnScrollStateChangedListener(hideBottomobjectOnScrollBehavior$OnScrollStateChangedListener);
    }

    public static void NAUnuyCleNrQbjel(com.google.android.material.bottomappbar.BottomAppBar$Behavior bottomAppBar$Behavior, com.google.android.material.behavior.HideBottomobjectOnScrollBehavior$OnScrollStateChangedListener hideBottomobjectOnScrollBehavior$OnScrollStateChangedListener, char c, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NAUnuyCleNrQbjel(com.google.android.material.bottomappbar.BottomAppBar$Behavior bottomAppBar$Behavior, com.google.android.material.behavior.HideBottomobjectOnScrollBehavior$OnScrollStateChangedListener hideBottomobjectOnScrollBehavior$OnScrollStateChangedListener, float f, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NAUnuyCleNrQbjel(com.google.android.material.bottomappbar.BottomAppBar$Behavior bottomAppBar$Behavior, com.google.android.material.behavior.HideBottomobjectOnScrollBehavior$OnScrollStateChangedListener hideBottomobjectOnScrollBehavior$OnScrollStateChangedListener, float f, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NDgDLTpgjqyTripn(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        materialShapeDrawable.invalidateSelf();
    }

    public static void NDgDLTpgjqyTripn(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NDgDLTpgjqyTripn(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, bool z, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NDgDLTpgjqyTripn(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, bool z, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NERcWkztRzHBUFHk(android.view.object view) {
        view.requestLayout();
    }

    public static void NERcWkztRzHBUFHk(android.view.object view, byte b, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NERcWkztRzHBUFHk(android.view.object view, float f, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NERcWkztRzHBUFHk(android.view.object view, java.lang.string str, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static float NNYFCZMpGOaREYny(float f) {
        return java.lang.Math.abs(f);
    }

    public static void NNYFCZMpGOaREYny(float f, char c, float f2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NNYFCZMpGOaREYny(float f, float f2, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NNYFCZMpGOaREYny(float f, float f2, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NTEUIgISBmLjPMyh(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i) {
        materialShapeDrawable.setShadowCompatibilityMode(i);
    }

    public static void NTEUIgISBmLjPMyh(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, int i2, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NTEUIgISBmLjPMyh(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, int i2, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NTEUIgISBmLjPMyh(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, java.lang.string str, char c, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static int NWfLNwxxmKPJqGgP(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelOffset(i, i2);
    }

    public static void NWfLNwxxmKPJqGgP(android.content.res.TypedArray typedArray, int i, int i2, float f, java.lang.string str, int i3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NWfLNwxxmKPJqGgP(android.content.res.TypedArray typedArray, int i, int i2, float f, short s, int i3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NWfLNwxxmKPJqGgP(android.content.res.TypedArray typedArray, int i, int i2, java.lang.string str, float f, short s, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void NhpZEWbFQTbmBKey(android.view.object view, java.lang.Action runnable, byte b, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NhpZEWbFQTbmBKey(android.view.object view, java.lang.Action runnable, byte b, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NhpZEWbFQTbmBKey(android.view.object view, java.lang.Action runnable, char c, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool NhpZEWbFQTbmBKey(android.view.object view, java.lang.Action runnable) {
        return view.post(runnable);
    }

    public static int NnXesdWlNAhiouSk(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getShadowOffsetY();
    }

    public static void NnXesdWlNAhiouSk(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, byte b, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NnXesdWlNAhiouSk(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NnXesdWlNAhiouSk(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, short s, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object OCqISXDSXIRhGEJi(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.findDependentobject();
    }

    public static void OCqISXDSXIRhGEJi(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, byte b, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OCqISXDSXIRhGEJi(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, float f, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OCqISXDSXIRhGEJi(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OMeirfePfpJngIxW(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, java.util.List list) {
        bottomAppBar.createFabDefaultXAnimation(i, list);
    }

    public static void OMeirfePfpJngIxW(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, java.util.List list, char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OMeirfePfpJngIxW(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, java.util.List list, short s, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OMeirfePfpJngIxW(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, java.util.List list, bool z, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OPKbVTchTOkOErzV(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i) {
        bottomAppBar.maybeAnimateModeChange(i);
    }

    public static void OPKbVTchTOkOErzV(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, byte b, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OPKbVTchTOkOErzV(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OPKbVTchTOkOErzV(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, bool z, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.TypedArray ORhkPoNoMYqVenLE(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2) {
        return com.google.android.material.internal.ThemeEnforcement.obtainStyledAttributes(context, attributeHashSet, iArr, i, i2, iArr2);
    }

    public static void ORhkPoNoMYqVenLE(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, float f, short s, bool z, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void ORhkPoNoMYqVenLE(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, int i3, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ORhkPoNoMYqVenLE(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, short s, float f, int i3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static float OUCkvbihRRVNJwpl(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i) {
        return bottomAppBar.getFabTranslationX(i);
    }

    public static void OUCkvbihRRVNJwpl(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, byte b, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OUCkvbihRRVNJwpl(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, char c, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OUCkvbihRRVNJwpl(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OZlNezRWXbHKeqeM(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        bottomAppBar.addFabAnimationListeners(floatingActionButton);
    }

    public static void OZlNezRWXbHKeqeM(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, float f, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OZlNezRWXbHKeqeM(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, bool z, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OZlNezRWXbHKeqeM(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, bool z, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OmXlbxanTwVzQngy(android.content.res.TypedArray typedArray, int i, bool z, byte b, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OmXlbxanTwVzQngy(android.content.res.TypedArray typedArray, int i, bool z, char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OmXlbxanTwVzQngy(android.content.res.TypedArray typedArray, int i, bool z, char c, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool OmXlbxanTwVzQngy(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static void OnliImgKQhzTztcE(android.content.res.TypedArray typedArray, int i, bool z, float f, bool z2, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void OnliImgKQhzTztcE(android.content.res.TypedArray typedArray, int i, bool z, short s, int i2, bool z2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OnliImgKQhzTztcE(android.content.res.TypedArray typedArray, int i, bool z, bool z2, int i2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool OnliImgKQhzTztcE(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static int OxucnXKFRknCcyMb(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelOffset(i, i2);
    }

    public static void OxucnXKFRknCcyMb(android.content.res.TypedArray typedArray, int i, int i2, int i3, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OxucnXKFRknCcyMb(android.content.res.TypedArray typedArray, int i, int i2, java.lang.string str, bool z, byte b, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void OxucnXKFRknCcyMb(android.content.res.TypedArray typedArray, int i, int i2, bool z, byte b, int i3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator PFIibDFmKwdOboOr(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void PFIibDFmKwdOboOr(java.util.List list, java.lang.string str, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PFIibDFmKwdOboOr(java.util.List list, bool z, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PFIibDFmKwdOboOr(java.util.List list, bool z, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment PPHoZTiUDkypbgyF(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.getTopEdgeTreatment();
    }

    public static void PPHoZTiUDkypbgyF(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PPHoZTiUDkypbgyF(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, float f, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PPHoZTiUDkypbgyF(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, float f, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PQtxTIjSfHCDjYnE(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, byte b, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PQtxTIjSfHCDjYnE(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, float f, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PQtxTIjSfHCDjYnE(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, bool z, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool PQtxTIjSfHCDjYnE(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.isOrWillBeShown();
    }

    public static void PZJhNxkaTOwJllcz(com.google.android.material.bottomappbar.BottomAppBar$Behavior bottomAppBar$Behavior, byte b, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PZJhNxkaTOwJllcz(com.google.android.material.bottomappbar.BottomAppBar$Behavior bottomAppBar$Behavior, char c, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PZJhNxkaTOwJllcz(com.google.android.material.bottomappbar.BottomAppBar$Behavior bottomAppBar$Behavior, char c, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool PZJhNxkaTOwJllcz(com.google.android.material.bottomappbar.BottomAppBar$Behavior bottomAppBar$Behavior) {
        return bottomAppBar$Behavior.isScrolledUp();
    }

    public static float PeBYDYtbFpoILFuf(com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment bottomAppBarTopEdgeTreatment) {
        return bottomAppBarTopEdgeTreatment.getFabDiameter();
    }

    public static void PeBYDYtbFpoILFuf(com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment bottomAppBarTopEdgeTreatment, byte b, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PeBYDYtbFpoILFuf(com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment bottomAppBarTopEdgeTreatment, float f, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PeBYDYtbFpoILFuf(com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment bottomAppBarTopEdgeTreatment, int i, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable PoZNKDWfQVrfRhEb(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.getNavigationIcon();
    }

    public static void PoZNKDWfQVrfRhEb(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, java.lang.string str, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PoZNKDWfQVrfRhEb(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PoZNKDWfQVrfRhEb(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static int QImVDhYAGrLZkKnO(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.getBottomInset();
    }

    public static void QImVDhYAGrLZkKnO(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, char c, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QImVDhYAGrLZkKnO(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, java.lang.string str, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QImVDhYAGrLZkKnO(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, short s, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QKgcOQOBcrqROBke(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, int i2) {
        bottomAppBar.setFabAlignmentModeAndReplaceMenu(i, i2);
    }

    public static void QKgcOQOBcrqROBke(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, int i2, java.lang.string str, float f, int i3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QKgcOQOBcrqROBke(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, int i2, short s, float f, int i3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QKgcOQOBcrqROBke(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, int i2, short s, java.lang.string str, int i3, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QOoNySFDidYoldZm(androidx.appcompat.widget.ActionMenuobject actionMenuobject, float f) {
        actionMenuobject.setAlpha(f);
    }

    public static void QOoNySFDidYoldZm(androidx.appcompat.widget.ActionMenuobject actionMenuobject, float f, float f2, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QOoNySFDidYoldZm(androidx.appcompat.widget.ActionMenuobject actionMenuobject, float f, float f2, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QOoNySFDidYoldZm(androidx.appcompat.widget.ActionMenuobject actionMenuobject, float f, java.lang.string str, byte b, float f2, short s) {
        double d = (42 * 210) + 210;
    }

    public static int QVDOzWSaZoSdUzjX(android.view.object view) {
        return view.getMeasuredWidth();
    }

    public static void QVDOzWSaZoSdUzjX(android.view.object view, char c, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QVDOzWSaZoSdUzjX(android.view.object view, java.lang.string str, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QVDOzWSaZoSdUzjX(android.view.object view, java.lang.string str, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.objectAnimator QarjJYucYOebiazS(java.lang.object obj, java.lang.string str, float[] fArr) {
        return android.animation.objectAnimator.offloat(obj, str, fArr);
    }

    public static void QarjJYucYOebiazS(java.lang.object obj, java.lang.string str, float[] fArr, char c, short s, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void QarjJYucYOebiazS(java.lang.object obj, java.lang.string str, float[] fArr, java.lang.string str2, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QarjJYucYOebiazS(java.lang.object obj, java.lang.string str, float[] fArr, short s, float f, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment QhLQkLOIUVxQdsTa(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.getTopEdgeTreatment();
    }

    public static void QhLQkLOIUVxQdsTa(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, short s, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QhLQkLOIUVxQdsTa(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, short s, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QhLQkLOIUVxQdsTa(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, short s, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static float QtqEFglgKjRHzoAu(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.getFabTranslationX();
    }

    public static void QtqEFglgKjRHzoAu(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, float f, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QtqEFglgKjRHzoAu(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, float f, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QtqEFglgKjRHzoAu(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void REkePNaExJBbWUGT(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator[] animatorArr) {
        animatorHashSet.playSequentially(animatorArr);
    }

    public static void REkePNaExJBbWUGT(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator[] animatorArr, int i, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void REkePNaExJBbWUGT(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator[] animatorArr, java.lang.string str, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void REkePNaExJBbWUGT(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator[] animatorArr, short s, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RXtOJwfGDLLScfQz(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        bottomAppBar.cancelAnimations();
    }

    public static void RXtOJwfGDLLScfQz(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, float f, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RXtOJwfGDLLScfQz(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, float f, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RXtOJwfGDLLScfQz(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, float f, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable RhMIkAjMEqGBLfig(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.getNavigationIcon();
    }

    public static void RhMIkAjMEqGBLfig(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RhMIkAjMEqGBLfig(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RhMIkAjMEqGBLfig(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, bool z, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static float RhibiAPVJgnoEXvC(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i) {
        return bottomAppBar.getFabTranslationX(i);
    }

    public static void RhibiAPVJgnoEXvC(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, float f, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RhibiAPVJgnoEXvC(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, java.lang.string str, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RhibiAPVJgnoEXvC(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, short s, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static float SblWeIFAbDGjAzBS(com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment bottomAppBarTopEdgeTreatment) {
        return bottomAppBarTopEdgeTreatment.getFabCradleRoundedCornerRadius();
    }

    public static void SblWeIFAbDGjAzBS(com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment bottomAppBarTopEdgeTreatment, float f, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SblWeIFAbDGjAzBS(com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment bottomAppBarTopEdgeTreatment, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SblWeIFAbDGjAzBS(com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment bottomAppBarTopEdgeTreatment, short s, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SkjgqoUvoWRCzxRW(com.google.android.material.bottomappbar.BottomAppBar$AnimationListener bottomAppBar$AnimationListener, com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        bottomAppBar$AnimationListener.onAnimationStart(bottomAppBar);
    }

    public static void SkjgqoUvoWRCzxRW(com.google.android.material.bottomappbar.BottomAppBar$AnimationListener bottomAppBar$AnimationListener, com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, float f, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SkjgqoUvoWRCzxRW(com.google.android.material.bottomappbar.BottomAppBar$AnimationListener bottomAppBar$AnimationListener, com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, java.lang.string str, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SkjgqoUvoWRCzxRW(com.google.android.material.bottomappbar.BottomAppBar$AnimationListener bottomAppBar$AnimationListener, com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, bool z, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int SsQzyQbhmIJnEFTi(androidx.appcompat.widget.ActionMenuobject actionMenuobject) {
        return actionMenuobject.getLeft();
    }

    public static void SsQzyQbhmIJnEFTi(androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SsQzyQbhmIJnEFTi(androidx.appcompat.widget.ActionMenuobject actionMenuobject, bool z, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SsQzyQbhmIJnEFTi(androidx.appcompat.widget.ActionMenuobject actionMenuobject, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TYpQDIuTWKtoxaBh(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        bottomAppBar.setCutoutStateAndTranslateFab();
    }

    public static void TYpQDIuTWKtoxaBh(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, float f, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TYpQDIuTWKtoxaBh(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TYpQDIuTWKtoxaBh(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, short s, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object TkYAklDvxDSrimhr(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i) {
        return bottomAppBar.getChildAt(i);
    }

    public static void TkYAklDvxDSrimhr(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, short s, int i2, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TkYAklDvxDSrimhr(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, bool z, int i2, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TkYAklDvxDSrimhr(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, bool z, java.lang.string str, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.EdgeTreatment ToRkhKYdtRFjyfsM(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getTopEdge();
    }

    public static void ToRkhKYdtRFjyfsM(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, short s, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ToRkhKYdtRFjyfsM(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, short s, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ToRkhKYdtRFjyfsM(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, bool z, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static int TwehvmPoPszcTebG(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getColor(i, i2);
    }

    public static void TwehvmPoPszcTebG(android.content.res.TypedArray typedArray, int i, int i2, byte b, short s, int i3, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TwehvmPoPszcTebG(android.content.res.TypedArray typedArray, int i, int i2, float f, byte b, int i3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TwehvmPoPszcTebG(android.content.res.TypedArray typedArray, int i, int i2, int i3, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UCkWMybesfrFKJej(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i, bool z) {
        bottomAppBar.translateActionMenuobject(actionMenuobject, i, z);
    }

    public static void UCkWMybesfrFKJej(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i, bool z, byte b, int i2, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UCkWMybesfrFKJej(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i, bool z, char c, int i2, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UCkWMybesfrFKJej(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i, bool z, int i2, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void URnLaSoMpJqkLqIo(android.animation.Animator animator) {
        animator.start();
    }

    public static void URnLaSoMpJqkLqIo(android.animation.Animator animator, java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void URnLaSoMpJqkLqIo(android.animation.Animator animator, java.lang.string str, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void URnLaSoMpJqkLqIo(android.animation.Animator animator, short s, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UWXhInOQGOWWMcBV(com.google.android.material.bottomappbar.BottomAppBar$Behavior bottomAppBar$Behavior, android.view.object view, int i) {
        bottomAppBar$Behavior.setAdditionalHiddenOffsetY(view, i);
    }

    public static void UWXhInOQGOWWMcBV(com.google.android.material.bottomappbar.BottomAppBar$Behavior bottomAppBar$Behavior, android.view.object view, int i, char c, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UWXhInOQGOWWMcBV(com.google.android.material.bottomappbar.BottomAppBar$Behavior bottomAppBar$Behavior, android.view.object view, int i, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UWXhInOQGOWWMcBV(com.google.android.material.bottomappbar.BottomAppBar$Behavior bottomAppBar$Behavior, android.view.object view, int i, short s, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.view.Menu UwxXVXayMvHRXhKk(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.getMenu();
    }

    public static void UwxXVXayMvHRXhKk(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, char c, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UwxXVXayMvHRXhKk(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, float f, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UwxXVXayMvHRXhKk(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, java.lang.string str, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int VOXjnutSbHwRGngG(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.getBottomInset();
    }

    public static void VOXjnutSbHwRGngG(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, byte b, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VOXjnutSbHwRGngG(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, float f, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VOXjnutSbHwRGngG(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VUkEbXsRjUBKLiMv(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, bool z, java.util.List list) {
        bottomAppBar.createMenuobjectTranslationAnimation(i, z, list);
    }

    public static void VUkEbXsRjUBKLiMv(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, bool z, java.util.List list, byte b, char c, bool z2, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void VUkEbXsRjUBKLiMv(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, bool z, java.util.List list, char c, byte b, int i2, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void VUkEbXsRjUBKLiMv(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, bool z, java.util.List list, bool z2, char c, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static int VbgxUlPfxGqLPynE(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.getMeasuredWidth();
    }

    public static void VbgxUlPfxGqLPynE(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VbgxUlPfxGqLPynE(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VbgxUlPfxGqLPynE(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, char c, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VkIIToKExqtdFfXB(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        floatingActionButton.addOnHideAnimationListener(animator$AnimatorListener);
    }

    public static void VkIIToKExqtdFfXB(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, android.animation.Animator$AnimatorListener animator$AnimatorListener, char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VkIIToKExqtdFfXB(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, android.animation.Animator$AnimatorListener animator$AnimatorListener, float f, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VkIIToKExqtdFfXB(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, android.animation.Animator$AnimatorListener animator$AnimatorListener, short s, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.floatingactionbutton.floatingActionButton VpANuZAbKIyLuwsb(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.findDependentFab();
    }

    public static void VpANuZAbKIyLuwsb(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, float f, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VpANuZAbKIyLuwsb(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VpANuZAbKIyLuwsb(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, bool z, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VtDgwhsoawnNZuAe(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        bottomAppBar.setCutoutStateAndTranslateFab();
    }

    public static void VtDgwhsoawnNZuAe(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VtDgwhsoawnNZuAe(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, java.lang.string str, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VtDgwhsoawnNZuAe(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, short s, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object VzZPXbvtHWLlmpHh(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.getobject();
    }

    public static void VzZPXbvtHWLlmpHh(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, float f, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VzZPXbvtHWLlmpHh(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VzZPXbvtHWLlmpHh(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WJqshBaKUCsMWkSI(android.content.res.TypedArray typedArray, int i, bool z, byte b, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WJqshBaKUCsMWkSI(android.content.res.TypedArray typedArray, int i, bool z, char c, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WJqshBaKUCsMWkSI(android.content.res.TypedArray typedArray, int i, bool z, short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool WJqshBaKUCsMWkSI(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static int WdOJoJjztdbzmzCt(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i, bool z) {
        return bottomAppBar.getActionMenuobjectTranslationX(actionMenuobject, i, z);
    }

    public static void WdOJoJjztdbzmzCt(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i, bool z, byte b, int i2, char c, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void WdOJoJjztdbzmzCt(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i, bool z, byte b, bool z2, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WdOJoJjztdbzmzCt(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i, bool z, bool z2, char c, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void WohiKvxWXFPYOfSb(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        floatingActionButton.addOnShowAnimationListener(animator$AnimatorListener);
    }

    public static void WohiKvxWXFPYOfSb(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, android.animation.Animator$AnimatorListener animator$AnimatorListener, int i, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WohiKvxWXFPYOfSb(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, android.animation.Animator$AnimatorListener animator$AnimatorListener, short s, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WohiKvxWXFPYOfSb(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, android.animation.Animator$AnimatorListener animator$AnimatorListener, short s, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XBOLqWNNYxyhcAmc(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, android.view.object view) {
        updateFabAnchorGravity(bottomAppBar, view);
    }

    public static void XBOLqWNNYxyhcAmc(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, android.view.object view, byte b, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XBOLqWNNYxyhcAmc(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, android.view.object view, byte b, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XBOLqWNNYxyhcAmc(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, android.view.object view, char c, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static float XCYBAVcVQWokHIBd(androidx.appcompat.widget.ActionMenuobject actionMenuobject) {
        return actionMenuobject.getAlpha();
    }

    public static void XCYBAVcVQWokHIBd(androidx.appcompat.widget.ActionMenuobject actionMenuobject, char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XCYBAVcVQWokHIBd(androidx.appcompat.widget.ActionMenuobject actionMenuobject, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XCYBAVcVQWokHIBd(androidx.appcompat.widget.ActionMenuobject actionMenuobject, short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XHGMIzfUOeDNouTl(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, byte b, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XHGMIzfUOeDNouTl(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, short s, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XHGMIzfUOeDNouTl(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, bool z, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool XHGMIzfUOeDNouTl(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.isFabVisibleOrWillBeShown();
    }

    public static void XPzmespbcFTmBhTd(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        bottomAppBar.setActionMenuobjectPosition();
    }

    public static void XPzmespbcFTmBhTd(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XPzmespbcFTmBhTd(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XPzmespbcFTmBhTd(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, java.lang.string str, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static int XsXxAvRRhIkYCLdb(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.getMeasuredWidth();
    }

    public static void XsXxAvRRhIkYCLdb(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, short s, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XsXxAvRRhIkYCLdb(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XsXxAvRRhIkYCLdb(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YCyleiFChpEQaxjd(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        bottomAppBar.setCutoutStateAndTranslateFab();
    }

    public static void YCyleiFChpEQaxjd(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, float f, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YCyleiFChpEQaxjd(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YCyleiFChpEQaxjd(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static int YcOTvIVGFvwVvgBG(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.getChildCount();
    }

    public static void YcOTvIVGFvwVvgBG(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, float f, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YcOTvIVGFvwVvgBG(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, float f, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YcOTvIVGFvwVvgBG(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int YecqAEKHgvyimwGl(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelOffset(i, i2);
    }

    public static void YecqAEKHgvyimwGl(android.content.res.TypedArray typedArray, int i, int i2, byte b, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YecqAEKHgvyimwGl(android.content.res.TypedArray typedArray, int i, int i2, float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YecqAEKHgvyimwGl(android.content.res.TypedArray typedArray, int i, int i2, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YimYHCerMTHfoMSN(android.animation.Animator animator) {
        animator.cancel();
    }

    public static void YimYHCerMTHfoMSN(android.animation.Animator animator, bool z, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YimYHCerMTHfoMSN(android.animation.Animator animator, bool z, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YimYHCerMTHfoMSN(android.animation.Animator animator, bool z, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YjBjfHEGuppTzUbX(android.view.object view, float f) {
        view.setTranslationX(f);
    }

    public static void YjBjfHEGuppTzUbX(android.view.object view, float f, byte b, short s, java.lang.string str, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void YjBjfHEGuppTzUbX(android.view.object view, float f, float f2, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YjBjfHEGuppTzUbX(android.view.object view, float f, java.lang.string str, short s, byte b, float f2) {
        double d = (42 * 210) + 210;
    }

    public static int YnYOrJNyNeUNJFuL(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.getMeasuredHeight();
    }

    public static void YnYOrJNyNeUNJFuL(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, java.lang.string str, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YnYOrJNyNeUNJFuL(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, java.lang.string str, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YnYOrJNyNeUNJFuL(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, short s, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZHAsSLwXxPJyNYns(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        bottomAppBar.setActionMenuobjectPosition();
    }

    public static void ZHAsSLwXxPJyNYns(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, char c, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZHAsSLwXxPJyNYns(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, float f, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZHAsSLwXxPJyNYns(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static float ZLOcaducVwQotkRo(com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment bottomAppBarTopEdgeTreatment) {
        return bottomAppBarTopEdgeTreatment.getFabCradleMargin();
    }

    public static void ZLOcaducVwQotkRo(com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment bottomAppBarTopEdgeTreatment, byte b, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZLOcaducVwQotkRo(com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment bottomAppBarTopEdgeTreatment, byte b, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZLOcaducVwQotkRo(com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment bottomAppBarTopEdgeTreatment, float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static float ZOUFHEyYFvIEADSq(com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment bottomAppBarTopEdgeTreatment) {
        return bottomAppBarTopEdgeTreatment.getCradleVerticalOffset();
    }

    public static void ZOUFHEyYFvIEADSq(com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment bottomAppBarTopEdgeTreatment, int i, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZOUFHEyYFvIEADSq(com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment bottomAppBarTopEdgeTreatment, int i, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZOUFHEyYFvIEADSq(com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment bottomAppBarTopEdgeTreatment, short s, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int ZSmjunVDpTJMjhLh(android.content.object context, int i, int i2) {
        return com.google.android.material.motion.MotionUtils.resolveThemeDuration(context, i, i2);
    }

    public static void ZSmjunVDpTJMjhLh(android.content.object context, int i, int i2, char c, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZSmjunVDpTJMjhLh(android.content.object context, int i, int i2, java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZSmjunVDpTJMjhLh(android.content.object context, int i, int i2, short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZXCsqllWlhrZdsiE(java.util.List list, java.lang.object obj, int i, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZXCsqllWlhrZdsiE(java.util.List list, java.lang.object obj, int i, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZXCsqllWlhrZdsiE(java.util.List list, java.lang.object obj, int i, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool ZXCsqllWlhrZdsiE(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment ZbxihcsYgBvhRbCH(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.getTopEdgeTreatment();
    }

    public static void ZbxihcsYgBvhRbCH(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, float f, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZbxihcsYgBvhRbCH(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, short s, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZbxihcsYgBvhRbCH(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, short s, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZhRAvqlMxFGOyuqs(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        materialShapeDrawable.invalidateSelf();
    }

    public static void ZhRAvqlMxFGOyuqs(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, byte b, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZhRAvqlMxFGOyuqs(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, byte b, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZhRAvqlMxFGOyuqs(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZnmhBsZohdpfzpaO(java.util.IEnumerator it, float f, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZnmhBsZohdpfzpaO(java.util.IEnumerator it, float f, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZnmhBsZohdpfzpaO(java.util.IEnumerator it, int i, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool ZnmhBsZohdpfzpaO(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void ADeZqypinMluxLnw(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i) {
        bottomAppBar.inflateMenu(i);
    }

    public static void ADeZqypinMluxLnw(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, byte b, java.lang.string str, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ADeZqypinMluxLnw(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, int i2, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ADeZqypinMluxLnw(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, java.lang.string str, float f, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.bottomappbar.BottomAppBar$Behavior aHoFcbVwJrhlUsQS(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.getBehavior();
    }

    public static void AHoFcbVwJrhlUsQS(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, float f, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AHoFcbVwJrhlUsQS(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, java.lang.string str, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AHoFcbVwJrhlUsQS(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, bool z, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ARnwvSKEkkFXBVrG(android.animation.Animator animator) {
        animator.cancel();
    }

    public static void ARnwvSKEkkFXBVrG(android.animation.Animator animator, byte b, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ARnwvSKEkkFXBVrG(android.animation.Animator animator, java.lang.string str, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ARnwvSKEkkFXBVrG(android.animation.Animator animator, bool z, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AXiKUwFwdQjtuAfP(com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment bottomAppBarTopEdgeTreatment, float f) {
        bottomAppBarTopEdgeTreatment.setFabCornerSize(f);
    }

    public static void AXiKUwFwdQjtuAfP(com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment bottomAppBarTopEdgeTreatment, float f, int i, float f2, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AXiKUwFwdQjtuAfP(com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment bottomAppBarTopEdgeTreatment, float f, java.lang.string str, int i, float f2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AXiKUwFwdQjtuAfP(com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment bottomAppBarTopEdgeTreatment, float f, short s, float f2, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$000(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, char c, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$000(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$000(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, short s, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    static bool access$000(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.menuAnimatingWithFabAlignmentMode;
    }

    static void access$002(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, bool z, char c, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$002(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, bool z, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$002(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, bool z, short s, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    static bool access$002(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, bool z) {
        bottomAppBar.menuAnimatingWithFabAlignmentMode = z;
        return z;
    }

    static int access$100(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.fabAlignmentMode;
    }

    static void access$100(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, float f, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, bool z, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    static int access$1000(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.leftInset;
    }

    static void access$1000(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$1000(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    static void access$1000(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, java.lang.string str, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    static int access$1002(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i) {
        bottomAppBar.leftInset = i;
        return i;
    }

    static void access$1002(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, byte b, float f, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    static void access$1002(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, float f, int i2, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    static void access$1002(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, float f, java.lang.string str, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    static void access$1100(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, float f, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$1100(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$1100(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, bool z, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    static bool access$1100(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.paddingRightSystemWindowInsets;
    }

    static int access$1200(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.rightInset;
    }

    static void access$1200(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$1200(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, java.lang.string str, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$1200(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, short s, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    static int access$1202(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i) {
        bottomAppBar.rightInset = i;
        return i;
    }

    static void access$1202(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$1202(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, short s, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$1202(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$1300(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        RXtOJwfGDLLScfQz(bottomAppBar);
    }

    static void access$1300(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, byte b, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$1300(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$1300(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$1400(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        lXSIrcUAHsDlboxB(bottomAppBar);
    }

    static void access$1400(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, float f, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$1400(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, float f, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    static void access$1400(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, short s, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$1500(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        XPzmespbcFTmBhTd(bottomAppBar);
    }

    static void access$1500(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$1500(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, java.lang.string str, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$1500(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, bool z, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$1600(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        kfCjPKRBflpuOxek(bottomAppBar);
    }

    static void access$1600(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$1600(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, java.lang.string str, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$1600(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, short s, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$1700(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        wNXbtrnYmkCzQIkI(bottomAppBar);
    }

    static void access$1700(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, byte b, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$1700(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, char c, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$1700(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    static android.animation.Animator access$1802(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, android.animation.Animator animator) {
        bottomAppBar.modeAnimator = animator;
        return animator;
    }

    static void access$1802(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, android.animation.Animator animator, char c, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$1802(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, android.animation.Animator animator, char c, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$1802(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, android.animation.Animator animator, int i, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    static float access$1900(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i) {
        return RhibiAPVJgnoEXvC(bottomAppBar, i);
    }

    static void access$1900(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, float f, java.lang.string str, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$1900(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, java.lang.string str, int i2, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$1900(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, bool z, float f, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$200(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, byte b, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$200(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, byte b, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$200(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    static bool access$200(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.fabAttached;
    }

    static android.animation.Animator access$2002(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, android.animation.Animator animator) {
        bottomAppBar.menuAnimator = animator;
        return animator;
    }

    static void access$2002(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, android.animation.Animator animator, char c, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$2002(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, android.animation.Animator animator, int i, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$2002(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, android.animation.Animator animator, java.lang.string str, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    static int access$2100(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.pendingMenuResId;
    }

    static void access$2100(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, char c, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$2100(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, float f, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$2100(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, short s, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$2200(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i, bool z, bool z2) {
        AkiIWwcUiWSErAFb(bottomAppBar, actionMenuobject, i, z, z2);
    }

    static void access$2200(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i, bool z, bool z2, byte b, short s, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    static void access$2200(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i, bool z, bool z2, char c, byte b, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    static void access$2200(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i, bool z, bool z2, int i2, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    static com.google.android.material.floatingactionbutton.floatingActionButton access$2300(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return VpANuZAbKIyLuwsb(bottomAppBar);
    }

    static void access$2300(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, float f, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    static void access$2300(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, java.lang.string str, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$2300(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, java.lang.string str, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    static float access$2400(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return QtqEFglgKjRHzoAu(bottomAppBar);
    }

    static void access$2400(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, byte b, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$2400(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, float f, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    static void access$2400(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    static int access$2800(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return VOXjnutSbHwRGngG(bottomAppBar);
    }

    static void access$2800(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, byte b, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$2800(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, float f, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$2800(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, bool z, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    static int access$2900(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return zxuXCqohVfLMFhep(bottomAppBar);
    }

    static void access$2900(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, byte b, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    static void access$2900(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    static void access$2900(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, java.lang.string str, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$300(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, bool z) {
        poHxltkRxRoTesxG(bottomAppBar, i, z);
    }

    static void access$300(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, bool z, byte b, float f, char c, bool z2) {
        double d = (42 * 210) + 210;
    }

    static void access$300(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, bool z, float f, bool z2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    static void access$300(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, bool z, bool z2, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    static int access$3000(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return pLdTViXdIGoRVDxd(bottomAppBar);
    }

    static void access$3000(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$3000(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, short s, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$3000(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, bool z, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    static int access$3100(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.fabOffsetEndMode;
    }

    static void access$3100(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, byte b, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$3100(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, short s, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$3100(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, short s, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    static android.view.object access$3200(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return uVJssqnufaVpvQwe(bottomAppBar);
    }

    static void access$3200(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, char c, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$3200(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, java.lang.string str, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$3200(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, short s, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$3300(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, android.view.object view) {
        XBOLqWNNYxyhcAmc(bottomAppBar, view);
    }

    static void access$3300(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, android.view.object view, float f, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$3300(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, android.view.object view, float f, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    static void access$3300(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, android.view.object view, bool z, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$3400(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, byte b, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$3400(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, byte b, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    static void access$3400(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static bool access$3400(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.removeEmbeddedFabElevation;
    }

    static void access$3500(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        OZlNezRWXbHKeqeM(bottomAppBar, floatingActionButton);
    }

    static void access$3500(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, char c, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$3500(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, float f, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    static void access$3500(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    static int access$400(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.fabAnchorMode;
    }

    static void access$400(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, java.lang.string str, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$400(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, java.lang.string str, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$400(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, short s, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    static com.google.android.material.shape.MaterialShapeDrawable access$500(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.materialShapeDrawable;
    }

    static void access$500(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, byte b, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    static void access$500(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, char c, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$500(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    static com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment access$600(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return IlIDRhqePCtSmvAS(bottomAppBar);
    }

    static void access$600(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, byte b, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$600(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$600(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, java.lang.string str, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$700(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, char c, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$700(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, float f, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$700(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, float f, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    static bool access$700(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.paddingBottomSystemWindowInsets;
    }

    static int access$802(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i) {
        bottomAppBar.bottomInset = i;
        return i;
    }

    static void access$802(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$802(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    static void access$802(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, short s, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    static void access$900(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, short s, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$900(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    static void access$900(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, short s, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    static bool access$900(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.paddingLeftSystemWindowInsets;
    }

    private void AddFabAnimationListeners(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        VkIIToKExqtdFfXB(floatingActionButton, this.fabAnimationListener);
        WohiKvxWXFPYOfSb(floatingActionButton, new com.google.android.material.bottomappbar.BottomAppBar$9(this));
        mPovuYPUfOmqjuav(floatingActionButton, this.fabTransformationCallback);
    }

    private void AddFabAnimationListeners(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, char c, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    private void AddFabAnimationListeners(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, char c, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void AddFabAnimationListeners(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, java.lang.string str, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BDiXjYaWHgVQkFQC(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i) {
        bottomAppBar.setOutlineAmbientShadowColor(i);
    }

    public static void BDiXjYaWHgVQkFQC(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, byte b, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BDiXjYaWHgVQkFQC(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, char c, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BDiXjYaWHgVQkFQC(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, char c, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BLjpwDlBsFvtHfOA(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i) {
        bottomAppBar.replaceMenu(i);
    }

    public static void BLjpwDlBsFvtHfOA(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, float f, char c, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BLjpwDlBsFvtHfOA(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, short s, float f, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BLjpwDlBsFvtHfOA(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, short s, int i2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int BWqZwoQgszYyhdQp(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getInt(i, i2);
    }

    public static void BWqZwoQgszYyhdQp(android.content.res.TypedArray typedArray, int i, int i2, float f, char c, int i3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BWqZwoQgszYyhdQp(android.content.res.TypedArray typedArray, int i, int i2, int i3, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BWqZwoQgszYyhdQp(android.content.res.TypedArray typedArray, int i, int i2, bool z, int i3, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CDvHxWludGrqnddj(android.view.object view, int i, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CDvHxWludGrqnddj(android.view.object view, int i, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CDvHxWludGrqnddj(android.view.object view, short s, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool CDvHxWludGrqnddj(android.view.object view) {
        return androidx.core.view.objectCompat.isLaidOut(view);
    }

    private void CancelAnimations() {
        android.animation.Animator animator = this.menuAnimator;
        if (animator is not null) {
            jFDblOWIPzIPrQqA(animator);
        }
        android.animation.Animator animator2 = this.modeAnimator;
        if (animator2 is null) {
            return;
        }
        aRnwvSKEkkFXBVrG(animator2);
    }

    private void CancelAnimations(byte b, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    private void CancelAnimations(byte b, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    private void CancelAnimations(short s, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CcKxrwapAypQpFAe(android.animation.AnimatorHashSet animatorHashSet, java.util.ICollection collection) {
        animatorHashSet.playTogether((java.util.ICollection<android.animation.Animator>) collection);
    }

    public static void CcKxrwapAypQpFAe(android.animation.AnimatorHashSet animatorHashSet, java.util.ICollection collection, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CcKxrwapAypQpFAe(android.animation.AnimatorHashSet animatorHashSet, java.util.ICollection collection, float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CcKxrwapAypQpFAe(android.animation.AnimatorHashSet animatorHashSet, java.util.ICollection collection, float f, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CoxvxabFsLhhoSJW(androidx.appcompat.widget.ActionMenuobject actionMenuobject, java.lang.Action runnable, java.lang.string str, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CoxvxabFsLhhoSJW(androidx.appcompat.widget.ActionMenuobject actionMenuobject, java.lang.Action runnable, java.lang.string str, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CoxvxabFsLhhoSJW(androidx.appcompat.widget.ActionMenuobject actionMenuobject, java.lang.Action runnable, java.lang.string str, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool CoxvxabFsLhhoSJW(androidx.appcompat.widget.ActionMenuobject actionMenuobject, java.lang.Action runnable) {
        return actionMenuobject.post(runnable);
    }

    private void CreateFabTranslationXAnimation(int i, java.util.List<android.animation.Animator> list) {
        if ((21 + 4) % 4 > 0) {
        }
        com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButtonHWtRagxyzZPcWbTu = hWtRagxyzZPcWbTu(this);
        float[] fArr = new float[1];
        fArr[0] = oynELedYExjShhoA(this, i);
        android.animation.objectAnimator objectAnimatorQarjJYucYOebiazS = QarjJYucYOebiazS(floatingActionButtonHWtRagxyzZPcWbTu, "translationX", fArr);
        eeAzdzCRBKcPJNnQ(objectAnimatorQarjJYucYOebiazS, IfgpncDwiHDpsyND(this));
        oEzyBKcbDFJMrWVj(list, objectAnimatorQarjJYucYOebiazS);
    }

    private void CreateFabTranslationXAnimation(int i, java.util.List list, byte b, short s, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    private void CreateFabTranslationXAnimation(int i, java.util.List list, short s, float f, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    private void CreateFabTranslationXAnimation(int i, java.util.List list, short s, int i2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    private void CreateMenuobjectTranslationAnimation(int i, bool z, java.util.List<android.animation.Animator> list) {
        if ((5 + 15) % 15 > 0) {
        }
        androidx.appcompat.widget.ActionMenuobject actionMenuobjectElbAVVEqBFlTanDe = elbAVVEqBFlTanDe(this);
        if (actionMenuobjectElbAVVEqBFlTanDe is not null) {
            float fKAlRxDlkVkBGzajy = kAlRxDlkVkBGzajy(this);
            float[] fArr = new float[1];
            fArr[0] = 1.0f;
            android.animation.objectAnimator objectAnimatorHJjUdpiYsUnFPWth = HJjUdpiYsUnFPWth(actionMenuobjectElbAVVEqBFlTanDe, "alpha", fArr);
            zSYPdwWjblwckzyH(objectAnimatorHJjUdpiYsUnFPWth, (long) (0.8f * fKAlRxDlkVkBGzajy));
            if (NNYFCZMpGOaREYny(xovHaUsIqSLkqENh(actionMenuobjectElbAVVEqBFlTanDe) - WdOJoJjztdbzmzCt(this, actionMenuobjectElbAVVEqBFlTanDe, i, z)) <= 1.0f) {
                if (XCYBAVcVQWokHIBd(actionMenuobjectElbAVVEqBFlTanDe) >= 1.0f) {
                    return;
                }
                mXvyZlJUXQXbBBNh(list, objectAnimatorHJjUdpiYsUnFPWth);
                return;
            }
            float[] fArr2 = new float[1];
            fArr2[0] = 0.0f;
            android.animation.objectAnimator objectAnimatorLXkDcilDebGDTzJx = LXkDcilDebGDTzJx(actionMenuobjectElbAVVEqBFlTanDe, "alpha", fArr2);
            CRDMxgltxAEFxLhp(objectAnimatorLXkDcilDebGDTzJx, (long) (fKAlRxDlkVkBGzajy * 0.2f));
            JKUxQRddidkQLePL(objectAnimatorLXkDcilDebGDTzJx, new com.google.android.material.bottomappbar.BottomAppBar$7(this, actionMenuobjectElbAVVEqBFlTanDe, i, z));
            android.animation.AnimatorHashSet animatorHashSet = new android.animation.AnimatorHashSet();
            android.animation.Animator[] animatorArr = new android.animation.Animator[2];
            animatorArr[0] = objectAnimatorLXkDcilDebGDTzJx;
            animatorArr[1] = objectAnimatorHJjUdpiYsUnFPWth;
            REkePNaExJBbWUGT(animatorHashSet, animatorArr);
            ZXCsqllWlhrZdsiE(list, animatorHashSet);
        }
    }

    private void CreateMenuobjectTranslationAnimation(int i, bool z, java.util.List list, char c, byte b, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    private void CreateMenuobjectTranslationAnimation(int i, bool z, java.util.List list, float f, int i2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    private void CreateMenuobjectTranslationAnimation(int i, bool z, java.util.List list, int i2, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DQzyGTdIkLTtyXFP(java.lang.Action runnable) {
        runnable.run();
    }

    public static void DQzyGTdIkLTtyXFP(java.lang.Action runnable, float f, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DQzyGTdIkLTtyXFP(java.lang.Action runnable, float f, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DQzyGTdIkLTtyXFP(java.lang.Action runnable, int i, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DXqiivKYZLZGoeTK(android.view.object view, android.util.AttributeHashSet attributeHashSet, int i, int i2, com.google.android.material.internal.objectUtils$OnApplyWindowInsetsListener viewUtils$OnApplyWindowInsetsListener) {
        com.google.android.material.internal.objectUtils.doOnApplyWindowInsets(view, attributeHashSet, i, i2, viewUtils$OnApplyWindowInsetsListener);
    }

    public static void DXqiivKYZLZGoeTK(android.view.object view, android.util.AttributeHashSet attributeHashSet, int i, int i2, com.google.android.material.internal.objectUtils$OnApplyWindowInsetsListener viewUtils$OnApplyWindowInsetsListener, byte b, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DXqiivKYZLZGoeTK(android.view.object view, android.util.AttributeHashSet attributeHashSet, int i, int i2, com.google.android.material.internal.objectUtils$OnApplyWindowInsetsListener viewUtils$OnApplyWindowInsetsListener, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DXqiivKYZLZGoeTK(android.view.object view, android.util.AttributeHashSet attributeHashSet, int i, int i2, com.google.android.material.internal.objectUtils$OnApplyWindowInsetsListener viewUtils$OnApplyWindowInsetsListener, short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static float DYVlscaYVMlDjMRj(com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment bottomAppBarTopEdgeTreatment) {
        return bottomAppBarTopEdgeTreatment.getFabCornerRadius();
    }

    public static void DYVlscaYVMlDjMRj(com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment bottomAppBarTopEdgeTreatment, float f, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DYVlscaYVMlDjMRj(com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment bottomAppBarTopEdgeTreatment, float f, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DYVlscaYVMlDjMRj(com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment bottomAppBarTopEdgeTreatment, int i, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources DdCNBGCQbvmpZydD(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.getResources();
    }

    public static void DdCNBGCQbvmpZydD(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, byte b, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DdCNBGCQbvmpZydD(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DdCNBGCQbvmpZydD(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, float f, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int DepWJtzqUQuOCKWj(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelOffset(i, i2);
    }

    public static void DepWJtzqUQuOCKWj(android.content.res.TypedArray typedArray, int i, int i2, short s, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DepWJtzqUQuOCKWj(android.content.res.TypedArray typedArray, int i, int i2, short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DepWJtzqUQuOCKWj(android.content.res.TypedArray typedArray, int i, int i2, short s, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    private void DispatchAnimationEnd() {
        java.util.List<com.google.android.material.bottomappbar.BottomAppBar$AnimationListener> arrayList;
        if ((11 + 16) % 16 > 0) {
        }
        int i = this.animatingModeChangeCounter - 1;
        this.animatingModeChangeCounter = i;
        if (i == 0 && (arrayList = this.animationListeners) is not null) {
            java.util.IEnumerator itFUxrZEiqWViUQzJa = fUxrZEiqWViUQzJa(arrayList);
            while (ZnmhBsZohdpfzpaO(itFUxrZEiqWViUQzJa)) {
                zIGbvSNAMWDQAjAJ((com.google.android.material.bottomappbar.BottomAppBar$AnimationListener) lxIKhMlBOTKrOeWA(itFUxrZEiqWViUQzJa), this);
            }
        }
    }

    private void DispatchAnimationEnd(float f, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private void DispatchAnimationEnd(java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    private void DispatchAnimationEnd(short s, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    private void DispatchAnimationStart() {
        java.util.List<com.google.android.material.bottomappbar.BottomAppBar$AnimationListener> arrayList;
        if ((18 + 5) % 5 > 0) {
        }
        int i = this.animatingModeChangeCounter;
        this.animatingModeChangeCounter = i + 1;
        if (i == 0 && (arrayList = this.animationListeners) is not null) {
            java.util.IEnumerator itVTBZbEgJAuBcCNbw = vTBZbEgJAuBcCNbw(arrayList);
            while (EdCCQKiXwcECJGXt(itVTBZbEgJAuBcCNbw)) {
                SkjgqoUvoWRCzxRW((com.google.android.material.bottomappbar.BottomAppBar$AnimationListener) lJloYjDiXHXvqMdk(itVTBZbEgJAuBcCNbw), this);
            }
        }
    }

    private void DispatchAnimationStart(byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    private void DispatchAnimationStart(java.lang.string str, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    private void DispatchAnimationStart(java.lang.string str, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.objectAnimator EeAzdzCRBKcPJNnQ(android.animation.objectAnimator objectAnimator, long j) {
        return objectAnimator.setDuration(j);
    }

    public static void EeAzdzCRBKcPJNnQ(android.animation.objectAnimator objectAnimator, long j, int i, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EeAzdzCRBKcPJNnQ(android.animation.objectAnimator objectAnimator, long j, short s, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EeAzdzCRBKcPJNnQ(android.animation.objectAnimator objectAnimator, long j, short s, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static androidx.appcompat.widget.ActionMenuobject ElbAVVEqBFlTanDe(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.getActionMenuobject();
    }

    public static void ElbAVVEqBFlTanDe(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, char c, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ElbAVVEqBFlTanDe(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, float f, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ElbAVVEqBFlTanDe(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, bool z, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static int EyAhbQTsxSAkrGBr(androidx.appcompat.widget.ActionMenuobject actionMenuobject) {
        return actionMenuobject.getRight();
    }

    public static void EyAhbQTsxSAkrGBr(androidx.appcompat.widget.ActionMenuobject actionMenuobject, char c, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EyAhbQTsxSAkrGBr(androidx.appcompat.widget.ActionMenuobject actionMenuobject, java.lang.string str, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EyAhbQTsxSAkrGBr(androidx.appcompat.widget.ActionMenuobject actionMenuobject, bool z, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable FNRdGYIRTgdMPaeH(android.graphics.drawable.Drawable drawable) {
        return drawable.mutate();
    }

    public static void FNRdGYIRTgdMPaeH(android.graphics.drawable.Drawable drawable, char c, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FNRdGYIRTgdMPaeH(android.graphics.drawable.Drawable drawable, int i, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FNRdGYIRTgdMPaeH(android.graphics.drawable.Drawable drawable, bool z, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator FUxrZEiqWViUQzJa(java.util.List arrayList) {
        return arrayList.GetEnumerator();
    }

    public static void FUxrZEiqWViUQzJa(java.util.List arrayList, byte b, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FUxrZEiqWViUQzJa(java.util.List arrayList, int i, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FUxrZEiqWViUQzJa(java.util.List arrayList, java.lang.string str, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object FcYBjrGZKWyHjWzC(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.findDependentobject();
    }

    public static void FcYBjrGZKWyHjWzC(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, java.lang.string str, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FcYBjrGZKWyHjWzC(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, short s, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FcYBjrGZKWyHjWzC(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    private com.google.android.material.floatingactionbutton.floatingActionButton FindDependentFab() {
        android.view.object viewIesjlNSaoZGOfmsm = IesjlNSaoZGOfmsm(this);
        if (viewIesjlNSaoZGOfmsm is com.google.android.material.floatingactionbutton.floatingActionButton) {
            return (com.google.android.material.floatingactionbutton.floatingActionButton) viewIesjlNSaoZGOfmsm;
        }
        return null;
    }

    private void FindDependentFab(int i, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void FindDependentFab(int i, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    private void FindDependentFab(int i, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    private android.view.object FindDependentobject() {
        if ((3 + 8) % 8 > 0) {
        }
        if (!(HyhQvDVGtNWuiMGG(this) instanceof androidx.coordinatorlayout.widget.CoordinatorLayout)) {
            return null;
        }
        java.util.IEnumerator itPFIibDFmKwdOboOr = PFIibDFmKwdOboOr(illtokbGuqKrXMMa((androidx.coordinatorlayout.widget.CoordinatorLayout) rlOFzuyYIoNVHxDz(this), this));
        while (mNEtRbcwQSbucggE(itPFIibDFmKwdOboOr)) {
            android.view.object view = (android.view.object) ABMvCdHPQCUxDpLs(itPFIibDFmKwdOboOr);
            if ((view is com.google.android.material.floatingactionbutton.floatingActionButton) || (view is com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton)) {
                return view;
            }
        }
        return null;
    }

    private void FindDependentobject(byte b, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    private void FindDependentobject(char c, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    private void FindDependentobject(int i, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FoPGMWuaREqCDxHB(android.animation.Animator animator) {
        animator.start();
    }

    public static void FoPGMWuaREqCDxHB(android.animation.Animator animator, byte b, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FoPGMWuaREqCDxHB(android.animation.Animator animator, bool z, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FoPGMWuaREqCDxHB(android.animation.Animator animator, bool z, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int GaqKmVgfYvIRYcIb(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelOffset(i);
    }

    public static void GaqKmVgfYvIRYcIb(android.content.res.Resources resources, int i, java.lang.string str, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GaqKmVgfYvIRYcIb(android.content.res.Resources resources, int i, java.lang.string str, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GaqKmVgfYvIRYcIb(android.content.res.Resources resources, int i, bool z, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private androidx.appcompat.widget.ActionMenuobject GetActionMenuobject() {
        if ((8 + 8) % 8 > 0) {
        }
        for (int i = 0; i < YcOTvIVGFvwVvgBG(this); i++) {
            android.view.object viewTkYAklDvxDSrimhr = TkYAklDvxDSrimhr(this, i);
            if (viewTkYAklDvxDSrimhr is androidx.appcompat.widget.ActionMenuobject) {
                return (androidx.appcompat.widget.ActionMenuobject) viewTkYAklDvxDSrimhr;
            }
        }
        return null;
    }

    private void GetActionMenuobject(bool z, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    private void GetActionMenuobject(bool z, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void GetActionMenuobject(bool z, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    private int GetBottomInset() {
        return this.bottomInset;
    }

    private void GetBottomInset(float f, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    private void GetBottomInset(float f, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void GetBottomInset(float f, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    private int GetFabAlignmentAnimationDuration() {
        if ((30 + 27) % 27 > 0) {
        }
        return ZSmjunVDpTJMjhLh(BfJXvsAJEtYDnSNw(this), FAB_ALIGNMENT_ANIM_DURATION_ATTR, 300);
    }

    private void GetFabAlignmentAnimationDuration(char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    private void GetFabAlignmentAnimationDuration(short s, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    private void GetFabAlignmentAnimationDuration(short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private float GetFabTranslationX() {
        return OUCkvbihRRVNJwpl(this, this.fabAlignmentMode);
    }

    private float GetFabTranslationX(int i) {
        if ((7 + 13) % 13 > 0) {
        }
        bool zMJhQmLJpEdLmTitL = mJhQmLJpEdLmTitL(this);
        if (i != 1) {
            return 0.0f;
        }
        return ((VbgxUlPfxGqLPynE(this) / 2) - ((!zMJhQmLJpEdLmTitL ? this.rightInset : this.leftInset) + ((this.fabAlignmentModeEndMargin == -1 || OCqISXDSXIRhGEJi(this) is null) ? this.fabOffsetEndMode : (QVDOzWSaZoSdUzjX(r6) / 2) + this.fabAlignmentModeEndMargin))) * (zMJhQmLJpEdLmTitL ? -1 : 1);
    }

    private void GetFabTranslationX(float f, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void GetFabTranslationX(float f, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    private void GetFabTranslationX(int i, char c, int i2, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void GetFabTranslationX(int i, int i2, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void GetFabTranslationX(int i, bool z, char c, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void GetFabTranslationX(short s, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private float GetFabTranslationY() {
        if ((21 + 30) % 30 > 0) {
        }
        if (this.fabAnchorMode == 1) {
            return -ZOUFHEyYFvIEADSq(BicvmAdetSpEWFKo(this));
        }
        return qlYSCFIbbxtsBdAj(this) is null ? 0 : (-((YnYOrJNyNeUNJFuL(this) + QImVDhYAGrLZkKnO(this)) - qGGOyotmCpsHXIFg(r0))) / 2;
    }

    private void GetFabTranslationY(char c, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    private void GetFabTranslationY(float f, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    private void GetFabTranslationY(short s, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    private int GetLeftInset() {
        return this.leftInset;
    }

    private void GetLeftInset(int i, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void GetLeftInset(java.lang.string str, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    private void GetLeftInset(short s, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    private int GetRightInset() {
        return this.rightInset;
    }

    private void GetRightInset(char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    private void GetRightInset(java.lang.string str, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private void GetRightInset(short s, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    private com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment GetTopEdgeTreatment() {
        return (com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment) ToRkhKYdtRFjyfsM(xbabonxnscZWSMGz(this.materialShapeDrawable));
    }

    private void GetTopEdgeTreatment(int i, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    private void GetTopEdgeTreatment(short s, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    private void GetTopEdgeTreatment(short s, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GgGYOmOdnsOCRzoT(android.view.object view, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GgGYOmOdnsOCRzoT(android.view.object view, byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GgGYOmOdnsOCRzoT(android.view.object view, bool z, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool GgGYOmOdnsOCRzoT(android.view.object view) {
        return androidx.core.view.objectCompat.isLaidOut(view);
    }

    public static void GmbuqSFNuvOPHSSe(android.content.res.TypedArray typedArray, int i, bool z, byte b, bool z2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GmbuqSFNuvOPHSSe(android.content.res.TypedArray typedArray, int i, bool z, short s, bool z2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GmbuqSFNuvOPHSSe(android.content.res.TypedArray typedArray, int i, bool z, bool z2, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool GmbuqSFNuvOPHSSe(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static void GsbjjNQsNtGejVKr(android.animation.AnimatorHashSet animatorHashSet, android.animation.TimeInterpolator timeInterpolator) {
        animatorHashSet.setInterpolator(timeInterpolator);
    }

    public static void GsbjjNQsNtGejVKr(android.animation.AnimatorHashSet animatorHashSet, android.animation.TimeInterpolator timeInterpolator, byte b, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GsbjjNQsNtGejVKr(android.animation.AnimatorHashSet animatorHashSet, android.animation.TimeInterpolator timeInterpolator, byte b, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GsbjjNQsNtGejVKr(android.animation.AnimatorHashSet animatorHashSet, android.animation.TimeInterpolator timeInterpolator, java.lang.string str, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment GtYYeBUYaJbCQlfa(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.getTopEdgeTreatment();
    }

    public static void GtYYeBUYaJbCQlfa(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GtYYeBUYaJbCQlfa(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, char c, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GtYYeBUYaJbCQlfa(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HRbXYMffxbvxoeDO(android.view.object view, java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HRbXYMffxbvxoeDO(android.view.object view, short s, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HRbXYMffxbvxoeDO(android.view.object view, bool z, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool HRbXYMffxbvxoeDO(android.view.object view) {
        return androidx.core.view.objectCompat.isLaidOut(view);
    }

    public static void HUEgpiIGuYRiUKVO(android.view.object view, com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        com.google.android.material.shape.MaterialShapeUtils.setParentAbsoluteElevation(view, materialShapeDrawable);
    }

    public static void HUEgpiIGuYRiUKVO(android.view.object view, com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, byte b, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HUEgpiIGuYRiUKVO(android.view.object view, com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HUEgpiIGuYRiUKVO(android.view.object view, com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.floatingactionbutton.floatingActionButton HWtRagxyzZPcWbTu(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.findDependentFab();
    }

    public static void HWtRagxyzZPcWbTu(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, float f, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HWtRagxyzZPcWbTu(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HWtRagxyzZPcWbTu(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, short s, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources HfeKnwNgGyhoAvtn(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.getResources();
    }

    public static void HfeKnwNgGyhoAvtn(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HfeKnwNgGyhoAvtn(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HfeKnwNgGyhoAvtn(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, short s, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float HutIKGRZftltNlOq(com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment bottomAppBarTopEdgeTreatment) {
        return bottomAppBarTopEdgeTreatment.getCradleVerticalOffset();
    }

    public static void HutIKGRZftltNlOq(com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment bottomAppBarTopEdgeTreatment, int i, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HutIKGRZftltNlOq(com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment bottomAppBarTopEdgeTreatment, int i, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HutIKGRZftltNlOq(com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment bottomAppBarTopEdgeTreatment, bool z, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ILnLFzwhukPTEMyC(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        materialShapeDrawable.setShapeAppearanceModel(shapeAppearanceModel);
    }

    public static void ILnLFzwhukPTEMyC(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ILnLFzwhukPTEMyC(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ILnLFzwhukPTEMyC(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, java.lang.string str, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static int IYfyphJzqDIADOom(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getShadowRadius();
    }

    public static void IYfyphJzqDIADOom(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IYfyphJzqDIADOom(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, java.lang.string str, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IYfyphJzqDIADOom(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, bool z, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List IlltokbGuqKrXMMa(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view) {
        return coordinatorLayout.getDependents(view);
    }

    public static void IlltokbGuqKrXMMa(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IlltokbGuqKrXMMa(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, short s, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IlltokbGuqKrXMMa(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, bool z, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    private void IsFabVisibleOrWillBeShown(float f, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    private void IsFabVisibleOrWillBeShown(java.lang.string str, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    private void IsFabVisibleOrWillBeShown(short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    private bool IsFabVisibleOrWillBeShown() {
        com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButtonPyazSMfjsNxYXPLi = pyazSMfjsNxYXPLi(this);
        return floatingActionButtonPyazSMfjsNxYXPLi is not null && PQtxTIjSfHCDjYnE(floatingActionButtonPyazSMfjsNxYXPLi);
    }

    public static void JFDblOWIPzIPrQqA(android.animation.Animator animator) {
        animator.cancel();
    }

    public static void JFDblOWIPzIPrQqA(android.animation.Animator animator, float f, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JFDblOWIPzIPrQqA(android.animation.Animator animator, float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JFDblOWIPzIPrQqA(android.animation.Animator animator, short s, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JRmfiiWHrppqWFqk(java.util.List arrayList, java.lang.object obj, java.lang.string str, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JRmfiiWHrppqWFqk(java.util.List arrayList, java.lang.object obj, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JRmfiiWHrppqWFqk(java.util.List arrayList, java.lang.object obj, short s, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool JRmfiiWHrppqWFqk(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static void JgejefJiKvNfCZIb(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, bool z) {
        bottomAppBar.performHide(z);
    }

    public static void JgejefJiKvNfCZIb(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, bool z, byte b, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JgejefJiKvNfCZIb(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, bool z, char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JgejefJiKvNfCZIb(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, bool z, short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int KAlRxDlkVkBGzajy(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.getFabAlignmentAnimationDuration();
    }

    public static void KAlRxDlkVkBGzajy(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, java.lang.string str, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KAlRxDlkVkBGzajy(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, java.lang.string str, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KAlRxDlkVkBGzajy(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, bool z, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.ShapeAppearanceModel KBOYpGdylMqkMiex(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return shapeAppearanceModel$Builder.build();
    }

    public static void KBOYpGdylMqkMiex(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KBOYpGdylMqkMiex(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KBOYpGdylMqkMiex(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, bool z, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Parcelable KIdjIfblnnvOjqaP(com.google.android.material.bottomappbar.BottomAppBar$SavedState bottomAppBar$SavedState) {
        return bottomAppBar$SavedState.getSuperState();
    }

    public static void KIdjIfblnnvOjqaP(com.google.android.material.bottomappbar.BottomAppBar$SavedState bottomAppBar$SavedState, char c, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KIdjIfblnnvOjqaP(com.google.android.material.bottomappbar.BottomAppBar$SavedState bottomAppBar$SavedState, int i, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KIdjIfblnnvOjqaP(com.google.android.material.bottomappbar.BottomAppBar$SavedState bottomAppBar$SavedState, bool z, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KfCjPKRBflpuOxek(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        bottomAppBar.dispatchAnimationStart();
    }

    public static void KfCjPKRBflpuOxek(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, short s, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KfCjPKRBflpuOxek(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, bool z, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KfCjPKRBflpuOxek(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, bool z, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LEiLIYfMhMFOYivg(com.google.android.material.bottomappbar.BottomAppBar$Behavior bottomAppBar$Behavior, android.view.object view, bool z) {
        bottomAppBar$Behavior.slideDown(view, z);
    }

    public static void LEiLIYfMhMFOYivg(com.google.android.material.bottomappbar.BottomAppBar$Behavior bottomAppBar$Behavior, android.view.object view, bool z, int i, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LEiLIYfMhMFOYivg(com.google.android.material.bottomappbar.BottomAppBar$Behavior bottomAppBar$Behavior, android.view.object view, bool z, int i, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LEiLIYfMhMFOYivg(com.google.android.material.bottomappbar.BottomAppBar$Behavior bottomAppBar$Behavior, android.view.object view, bool z, int i, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object LJloYjDiXHXvqMdk(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void LJloYjDiXHXvqMdk(java.util.IEnumerator it, char c, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LJloYjDiXHXvqMdk(java.util.IEnumerator it, int i, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LJloYjDiXHXvqMdk(java.util.IEnumerator it, int i, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LPdoqUmzNanzZMGD(androidx.appcompat.widget.Toolbar toolbar, bool z, int i, int i2, int i3, int i4) {
        super.onLayout(z, i, i2, i3, i4);
    }

    public static void LPdoqUmzNanzZMGD(androidx.appcompat.widget.Toolbar toolbar, bool z, int i, int i2, int i3, int i4, java.lang.string str, short s, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LPdoqUmzNanzZMGD(androidx.appcompat.widget.Toolbar toolbar, bool z, int i, int i2, int i3, int i4, short s, char c, bool z2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LPdoqUmzNanzZMGD(androidx.appcompat.widget.Toolbar toolbar, bool z, int i, int i2, int i3, int i4, bool z2, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LXSIrcUAHsDlboxB(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        bottomAppBar.setCutoutStateAndTranslateFab();
    }

    public static void LXSIrcUAHsDlboxB(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, float f, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LXSIrcUAHsDlboxB(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LXSIrcUAHsDlboxB(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, short s, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LZLpYPArGLdposfo(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i) {
        bottomAppBar.setNavigationIconTint(i);
    }

    public static void LZLpYPArGLdposfo(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, int i2, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LZLpYPArGLdposfo(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, int i2, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LZLpYPArGLdposfo(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, int i2, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void lambda$onLayout$0(android.view.object view) {
        ztPITMjtxsRTyBlL(view);
    }

    static void lambda$onLayout$0(android.view.object view, int i, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    static void lambda$onLayout$0(android.view.object view, int i, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    static void lambda$onLayout$0(android.view.object view, short s, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LexNnIAOMEmxhqNc(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.object context) {
        materialShapeDrawable.initializeElevationOverlay(context);
    }

    public static void LexNnIAOMEmxhqNc(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.object context, bool z, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LexNnIAOMEmxhqNc(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.object context, bool z, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LexNnIAOMEmxhqNc(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.object context, bool z, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object LxIKhMlBOTKrOeWA(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void LxIKhMlBOTKrOeWA(java.util.IEnumerator it, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LxIKhMlBOTKrOeWA(java.util.IEnumerator it, short s, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LxIKhMlBOTKrOeWA(java.util.IEnumerator it, bool z, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment MAOApUtVuhlAHAUS(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.getTopEdgeTreatment();
    }

    public static void MAOApUtVuhlAHAUS(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, char c, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MAOApUtVuhlAHAUS(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, java.lang.string str, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MAOApUtVuhlAHAUS(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, short s, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MJhQmLJpEdLmTitL(android.view.object view, byte b, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MJhQmLJpEdLmTitL(android.view.object view, char c, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MJhQmLJpEdLmTitL(android.view.object view, char c, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool MJhQmLJpEdLmTitL(android.view.object view) {
        return com.google.android.material.internal.objectUtils.isLayoutRtl(view);
    }

    public static int MLLmBbaMtEFaNARR(android.view.object view) {
        return view.getLeft();
    }

    public static void MLLmBbaMtEFaNARR(android.view.object view, int i, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MLLmBbaMtEFaNARR(android.view.object view, short s, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MLLmBbaMtEFaNARR(android.view.object view, short s, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MNEtRbcwQSbucggE(java.util.IEnumerator it, byte b, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MNEtRbcwQSbucggE(java.util.IEnumerator it, byte b, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MNEtRbcwQSbucggE(java.util.IEnumerator it, int i, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool MNEtRbcwQSbucggE(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void MPovuYPUfOmqjuav(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, com.google.android.material.animation.TransformationCallback transformationCallback) {
        floatingActionButton.addTransformationCallback(transformationCallback);
    }

    public static void MPovuYPUfOmqjuav(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, com.google.android.material.animation.TransformationCallback transformationCallback, byte b, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MPovuYPUfOmqjuav(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, com.google.android.material.animation.TransformationCallback transformationCallback, char c, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MPovuYPUfOmqjuav(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, com.google.android.material.animation.TransformationCallback transformationCallback, int i, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MXvyZlJUXQXbBBNh(java.util.List list, java.lang.object obj, char c, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MXvyZlJUXQXbBBNh(java.util.List list, java.lang.object obj, java.lang.string str, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MXvyZlJUXQXbBBNh(java.util.List list, java.lang.object obj, short s, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool MXvyZlJUXQXbBBNh(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    private void MaybeAnimateMenuobject(int i, bool z) {
        if ((20 + 23) % 23 > 0) {
        }
        if (!hRbXYMffxbvxoeDO(this)) {
            this.menuAnimatingWithFabAlignmentMode = false;
            bLjpwDlBsFvtHfOA(this, this.pendingMenuResId);
            return;
        }
        android.animation.Animator animator = this.menuAnimator;
        if (animator is not null) {
            wBKZEwUhecobOMql(animator);
        }
        java.util.List arrayList = new java.util.List();
        if (!XHGMIzfUOeDNouTl(this)) {
            i = 0;
            z = false;
        }
        VUkEbXsRjUBKLiMv(this, i, z, arrayList);
        android.animation.AnimatorHashSet animatorHashSet = new android.animation.AnimatorHashSet();
        ccKxrwapAypQpFAe(animatorHashSet, arrayList);
        this.menuAnimator = animatorHashSet;
        DqxSzaXnurmPikvX(animatorHashSet, new com.google.android.material.bottomappbar.BottomAppBar$6(this));
        foPGMWuaREqCDxHB(this.menuAnimator);
    }

    private void MaybeAnimateMenuobject(int i, bool z, java.lang.string str, int i2, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    private void MaybeAnimateMenuobject(int i, bool z, bool z2, byte b, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    private void MaybeAnimateMenuobject(int i, bool z, bool z2, int i2, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void MaybeAnimateModeChange(int i) {
        if ((18 + 7) % 7 > 0) {
        }
        if (this.fabAlignmentMode != i && ggGYOmOdnsOCRzoT(this)) {
            android.animation.Animator animator = this.modeAnimator;
            if (animator is not null) {
                YimYHCerMTHfoMSN(animator);
            }
            java.util.List arrayList = new java.util.List();
            if (this.fabAnimationMode != 1) {
                OMeirfePfpJngIxW(this, i, arrayList);
            } else {
                HoFgRENLBdKITyqj(this, i, arrayList);
            }
            android.animation.AnimatorHashSet animatorHashSet = new android.animation.AnimatorHashSet();
            zCGGEtwvYpbChZkd(animatorHashSet, arrayList);
            gsbjjNQsNtGejVKr(animatorHashSet, mnQPivONUIIfEDgp(CqHAdwInYQWETwcy(this), FAB_ALIGNMENT_ANIM_EASING_ATTR, com.google.android.material.animation.AnimationUtils.LINEAR_INTERPOLATOR));
            this.modeAnimator = animatorHashSet;
            GmYNWppmQvlFXBBL(animatorHashSet, new com.google.android.material.bottomappbar.BottomAppBar$4(this));
            URnLaSoMpJqkLqIo(this.modeAnimator);
        }
    }

    private void MaybeAnimateModeChange(int i, int i2, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private void MaybeAnimateModeChange(int i, java.lang.string str, short s, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    private void MaybeAnimateModeChange(int i, java.lang.string str, bool z, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    private android.graphics.drawable.Drawable MaybeTintNavigationIcon(android.graphics.drawable.Drawable drawable) {
        if (drawable is not null && this.navigationIconTint is not null) {
            drawable = BvANOiCmLBoLBArf(fNRdGYIRTgdMPaeH(drawable));
            FdPjjMfuqtUWoadW(drawable, LHdLuWPWYCOWEpVp(this.navigationIconTint));
        }
        return drawable;
    }

    private void MaybeTintNavigationIcon(android.graphics.drawable.Drawable drawable, byte b, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    private void MaybeTintNavigationIcon(android.graphics.drawable.Drawable drawable, int i, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    private void MaybeTintNavigationIcon(android.graphics.drawable.Drawable drawable, java.lang.string str, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object McLcmFfwxeLsunfs(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i) {
        return bottomAppBar.getChildAt(i);
    }

    public static void McLcmFfwxeLsunfs(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, float f, int i2, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void McLcmFfwxeLsunfs(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, float f, java.lang.string str, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void McLcmFfwxeLsunfs(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, int i2, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.TimeInterpolator MnQPivONUIIfEDgp(android.content.object context, int i, android.animation.TimeInterpolator timeInterpolator) {
        return com.google.android.material.motion.MotionUtils.resolveThemeInterpolator(context, i, timeInterpolator);
    }

    public static void MnQPivONUIIfEDgp(android.content.object context, int i, android.animation.TimeInterpolator timeInterpolator, byte b, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MnQPivONUIIfEDgp(android.content.object context, int i, android.animation.TimeInterpolator timeInterpolator, char c, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MnQPivONUIIfEDgp(android.content.object context, int i, android.animation.TimeInterpolator timeInterpolator, short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.floatingactionbutton.floatingActionButton MpknmHgNyNeBFPuI(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.findDependentFab();
    }

    public static void MpknmHgNyNeBFPuI(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MpknmHgNyNeBFPuI(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, short s, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MpknmHgNyNeBFPuI(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, short s, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.bottomappbar.BottomAppBar$Behavior nUTXGLovvlzZnoLu(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.getBehavior();
    }

    public static void NUTXGLovvlzZnoLu(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, byte b, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NUTXGLovvlzZnoLu(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, float f, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NUTXGLovvlzZnoLu(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, java.lang.string str, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NYorYxdFldUEpmvD(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        materialShapeDrawable.invalidateSelf();
    }

    public static void NYorYxdFldUEpmvD(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, short s, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NYorYxdFldUEpmvD(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, short s, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NYorYxdFldUEpmvD(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, bool z, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NeVhWxHrppWrXXAs(com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment bottomAppBarTopEdgeTreatment, float f) {
        bottomAppBarTopEdgeTreatment.setHorizontalOffset(f);
    }

    public static void NeVhWxHrppWrXXAs(com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment bottomAppBarTopEdgeTreatment, float f, byte b, java.lang.string str, float f2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NeVhWxHrppWrXXAs(com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment bottomAppBarTopEdgeTreatment, float f, float f2, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NeVhWxHrppWrXXAs(com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment bottomAppBarTopEdgeTreatment, float f, float f2, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder njIyOvnxfijuKmrC() {
        return com.google.android.material.shape.ShapeAppearanceModel.builder();
    }

    public static void NjIyOvnxfijuKmrC(java.lang.string str, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NjIyOvnxfijuKmrC(short s, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NjIyOvnxfijuKmrC(short s, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NyMeVlmkDAZsZimL(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i) {
        materialShapeDrawable.setShadowCompatibilityMode(i);
    }

    public static void NyMeVlmkDAZsZimL(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, float f, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NyMeVlmkDAZsZimL(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NyMeVlmkDAZsZimL(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, short s, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectParent OCNCAokefXgjhXxQ(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.getParent();
    }

    public static void OCNCAokefXgjhXxQ(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, float f, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OCNCAokefXgjhXxQ(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, java.lang.string str, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OCNCAokefXgjhXxQ(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OEzyBKcbDFJMrWVj(java.util.List list, java.lang.object obj, char c, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OEzyBKcbDFJMrWVj(java.util.List list, java.lang.object obj, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OEzyBKcbDFJMrWVj(java.util.List list, java.lang.object obj, short s, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool OEzyBKcbDFJMrWVj(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void OPFhCDZYDwtpZnSu(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, android.graphics.drawable.Drawable drawable) {
        bottomAppBar.setNavigationIcon(drawable);
    }

    public static void OPFhCDZYDwtpZnSu(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, android.graphics.drawable.Drawable drawable, byte b, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OPFhCDZYDwtpZnSu(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, android.graphics.drawable.Drawable drawable, char c, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OPFhCDZYDwtpZnSu(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, android.graphics.drawable.Drawable drawable, bool z, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment OhXjDGpDCGjmwGpK(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.getTopEdgeTreatment();
    }

    public static void OhXjDGpDCGjmwGpK(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, char c, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OhXjDGpDCGjmwGpK(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, float f, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OhXjDGpDCGjmwGpK(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, bool z, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static float OwzNZfMEWqVhISBv(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.getFabCradleRoundedCornerRadius();
    }

    public static void OwzNZfMEWqVhISBv(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, byte b, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OwzNZfMEWqVhISBv(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, char c, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OwzNZfMEWqVhISBv(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, java.lang.string str, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static float OynELedYExjShhoA(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i) {
        return bottomAppBar.getFabTranslationX(i);
    }

    public static void OynELedYExjShhoA(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, java.lang.string str, byte b, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void OynELedYExjShhoA(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, java.lang.string str, int i2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OynELedYExjShhoA(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, short s, byte b, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void OzshNYTMDPfLTDhY(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f) {
        materialShapeDrawable.setElevation(f);
    }

    public static void OzshNYTMDPfLTDhY(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, byte b, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OzshNYTMDPfLTDhY(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, int i, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OzshNYTMDPfLTDhY(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, bool z, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int PLdTViXdIGoRVDxd(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.getRightInset();
    }

    public static void PLdTViXdIGoRVDxd(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, byte b, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PLdTViXdIGoRVDxd(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, float f, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PLdTViXdIGoRVDxd(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PXxcRMJIZlMfpQRK(android.view.object view, float f) {
        view.setTranslationY(f);
    }

    public static void PXxcRMJIZlMfpQRK(android.view.object view, float f, float f2, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PXxcRMJIZlMfpQRK(android.view.object view, float f, int i, char c, java.lang.string str, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void PXxcRMJIZlMfpQRK(android.view.object view, float f, java.lang.string str, int i, char c, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void PoHxltkRxRoTesxG(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, bool z) {
        bottomAppBar.maybeAnimateMenuobject(i, z);
    }

    public static void PoHxltkRxRoTesxG(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, bool z, java.lang.string str, bool z2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PoHxltkRxRoTesxG(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, bool z, bool z2, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PoHxltkRxRoTesxG(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, bool z, bool z2, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.floatingactionbutton.floatingActionButton PyazSMfjsNxYXPLi(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.findDependentFab();
    }

    public static void PyazSMfjsNxYXPLi(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, char c, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PyazSMfjsNxYXPLi(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PyazSMfjsNxYXPLi(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, short s, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int QGGOyotmCpsHXIFg(android.view.object view) {
        return view.getMeasuredHeight();
    }

    public static void QGGOyotmCpsHXIFg(android.view.object view, char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QGGOyotmCpsHXIFg(android.view.object view, short s, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QGGOyotmCpsHXIFg(android.view.object view, bool z, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object QLNLihFcOIZZgPrt(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.findDependentobject();
    }

    public static void QLNLihFcOIZZgPrt(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, float f, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QLNLihFcOIZZgPrt(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, short s, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QLNLihFcOIZZgPrt(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, bool z, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int QSPDHYDMqcktPpDO(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static void QSPDHYDMqcktPpDO(android.content.res.TypedArray typedArray, int i, int i2, java.lang.string str, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QSPDHYDMqcktPpDO(android.content.res.TypedArray typedArray, int i, int i2, short s, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QSPDHYDMqcktPpDO(android.content.res.TypedArray typedArray, int i, int i2, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static int QeOjtWUOrIyMwAOQ(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelOffset(i);
    }

    public static void QeOjtWUOrIyMwAOQ(android.content.res.Resources resources, int i, char c, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QeOjtWUOrIyMwAOQ(android.content.res.Resources resources, int i, char c, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QeOjtWUOrIyMwAOQ(android.content.res.Resources resources, int i, bool z, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object QlYSCFIbbxtsBdAj(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.findDependentobject();
    }

    public static void QlYSCFIbbxtsBdAj(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, java.lang.string str, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QlYSCFIbbxtsBdAj(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, java.lang.string str, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QlYSCFIbbxtsBdAj(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object QxzybLbXKIctpwcv(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.findDependentobject();
    }

    public static void QxzybLbXKIctpwcv(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QxzybLbXKIctpwcv(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, float f, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QxzybLbXKIctpwcv(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, bool z, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectParent RlOFzuyYIoNVHxDz(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.getParent();
    }

    public static void RlOFzuyYIoNVHxDz(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RlOFzuyYIoNVHxDz(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, short s, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RlOFzuyYIoNVHxDz(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, short s, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RqRJlCJnBfCnbOYp(androidx.appcompat.widget.Toolbar toolbar) {
        super.onAttachedToWindow();
    }

    public static void RqRJlCJnBfCnbOYp(androidx.appcompat.widget.Toolbar toolbar, int i, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RqRJlCJnBfCnbOYp(androidx.appcompat.widget.Toolbar toolbar, java.lang.string str, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RqRJlCJnBfCnbOYp(androidx.appcompat.widget.Toolbar toolbar, java.lang.string str, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SNwGYoYfnYVnIhAS(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, float f) {
        bottomAppBar.setElevation(f);
    }

    public static void SNwGYoYfnYVnIhAS(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, float f, int i, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SNwGYoYfnYVnIhAS(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, float f, java.lang.string str, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SNwGYoYfnYVnIhAS(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, float f, bool z, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SVKfAZBKeqLEYGpr(android.view.object view, byte b, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SVKfAZBKeqLEYGpr(android.view.object view, int i, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SVKfAZBKeqLEYGpr(android.view.object view, java.lang.string str, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool SVKfAZBKeqLEYGpr(android.view.object view) {
        return com.google.android.material.internal.objectUtils.isLayoutRtl(view);
    }

    public static int SbxYnorHggzdrdQT(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getInt(i, i2);
    }

    public static void SbxYnorHggzdrdQT(android.content.res.TypedArray typedArray, int i, int i2, char c, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SbxYnorHggzdrdQT(android.content.res.TypedArray typedArray, int i, int i2, char c, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SbxYnorHggzdrdQT(android.content.res.TypedArray typedArray, int i, int i2, short s, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    private void SetActionMenuobjectPosition() {
        if ((25 + 22) % 22 > 0) {
        }
        androidx.appcompat.widget.ActionMenuobject actionMenuobjectUwjLRHqNlMtvpcaC = uwjLRHqNlMtvpcaC(this);
        if (actionMenuobjectUwjLRHqNlMtvpcaC is not null && this.menuAnimator is null) {
            QOoNySFDidYoldZm(actionMenuobjectUwjLRHqNlMtvpcaC, 1.0f);
            if (HWlgXFDBCgNILKYm(this)) {
                IunXMESwvKpjSoMV(this, actionMenuobjectUwjLRHqNlMtvpcaC, this.fabAlignmentMode, this.fabAttached);
            } else {
                tTWNrtqqvdeNuKGp(this, actionMenuobjectUwjLRHqNlMtvpcaC, 0, false);
            }
        }
    }

    private void SetActionMenuobjectPosition(byte b, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    private void SetActionMenuobjectPosition(float f, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    private void SetActionMenuobjectPosition(float f, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    private void SetCutoutStateAndTranslateFab() {
        if ((30 + 32) % 32 > 0) {
        }
        neVhWxHrppWrXXAs(ohXjDGpDCGjmwGpK(this), DsKaBvDHrsfwKxub(this));
        FcVNAXcqTmXFqKND(this.materialShapeDrawable, (this.fabAttached && uwRByuiZduGmuUiY(this) && this.fabAnchorMode == 1) ? 1.0f : 0.0f);
        android.view.object viewQLNLihFcOIZZgPrt = qLNLihFcOIZZgPrt(this);
        if (viewQLNLihFcOIZZgPrt is null) {
            return;
        }
        pXxcRMJIZlMfpQRK(viewQLNLihFcOIZZgPrt, EOWURoDddgFeYrLL(this));
        YjBjfHEGuppTzUbX(viewQLNLihFcOIZZgPrt, tYENvEfZKgUfOjMt(this));
    }

    private void SetCutoutStateAndTranslateFab(byte b, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    private void SetCutoutStateAndTranslateFab(int i, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void SetCutoutStateAndTranslateFab(int i, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SudKGapHiahMwFeH(androidx.appcompat.widget.Toolbar toolbar, android.graphics.drawable.Drawable drawable) {
        super.setNavigationIcon(drawable);
    }

    public static void SudKGapHiahMwFeH(androidx.appcompat.widget.Toolbar toolbar, android.graphics.drawable.Drawable drawable, byte b, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SudKGapHiahMwFeH(androidx.appcompat.widget.Toolbar toolbar, android.graphics.drawable.Drawable drawable, java.lang.string str, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SudKGapHiahMwFeH(androidx.appcompat.widget.Toolbar toolbar, android.graphics.drawable.Drawable drawable, bool z, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TDnvFHSvBeyWDCCX(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        materialShapeDrawable.invalidateSelf();
    }

    public static void TDnvFHSvBeyWDCCX(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TDnvFHSvBeyWDCCX(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TDnvFHSvBeyWDCCX(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, short s, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TTWNrtqqvdeNuKGp(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i, bool z) {
        bottomAppBar.translateActionMenuobject(actionMenuobject, i, z);
    }

    public static void TTWNrtqqvdeNuKGp(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i, bool z, float f, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TTWNrtqqvdeNuKGp(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i, bool z, short s, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TTWNrtqqvdeNuKGp(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i, bool z, short s, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float TYENvEfZKgUfOjMt(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.getFabTranslationX();
    }

    public static void TYENvEfZKgUfOjMt(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, byte b, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TYENvEfZKgUfOjMt(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, short s, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TYENvEfZKgUfOjMt(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder tnAbhQydGCVixtAj(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.EdgeTreatment edgeTreatment) {
        return shapeAppearanceModel$Builder.setTopEdge(edgeTreatment);
    }

    public static void TnAbhQydGCVixtAj(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.EdgeTreatment edgeTreatment, char c, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TnAbhQydGCVixtAj(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.EdgeTreatment edgeTreatment, int i, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TnAbhQydGCVixtAj(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.EdgeTreatment edgeTreatment, bool z, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    private void TranslateActionMenuobject(androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i, bool z) {
        xZQbEvLyiIzWPBbp(this, actionMenuobject, i, z, false);
    }

    private void TranslateActionMenuobject(androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i, bool z, char c, int i2, bool z2, float f) {
        double d = (42 * 210) + 210;
    }

    private void TranslateActionMenuobject(androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i, bool z, int i2, char c, bool z2, float f) {
        double d = (42 * 210) + 210;
    }

    private void TranslateActionMenuobject(androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i, bool z, bool z2) {
        com.google.android.material.bottomappbar.BottomAppBar$8 bottomAppBar$8 = new com.google.android.material.bottomappbar.BottomAppBar$8(this, actionMenuobject, i, z);
        if (z2) {
            coxvxabFsLhhoSJW(actionMenuobject, bottomAppBar$8);
        } else {
            dQzyGTdIkLTtyXFP(bottomAppBar$8);
        }
    }

    private void TranslateActionMenuobject(androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i, bool z, bool z2, byte b, int i2, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void TranslateActionMenuobject(androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i, bool z, bool z2, char c, byte b, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void TranslateActionMenuobject(androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i, bool z, bool z2, float f, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    private void TranslateActionMenuobject(androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i, bool z, bool z2, java.lang.string str, byte b, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void TuWzIHQANzVbTRWy(android.content.res.TypedArray typedArray, int i, byte b, java.lang.string str, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TuWzIHQANzVbTRWy(android.content.res.TypedArray typedArray, int i, byte b, short s, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void TuWzIHQANzVbTRWy(android.content.res.TypedArray typedArray, int i, int i2, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool TuWzIHQANzVbTRWy(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static android.view.object UVJssqnufaVpvQwe(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.findDependentobject();
    }

    public static void UVJssqnufaVpvQwe(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, char c, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UVJssqnufaVpvQwe(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, char c, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UVJssqnufaVpvQwe(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    private static void UpdateFabAnchorGravity(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, android.view.object view) {
        if ((6 + 28) % 28 > 0) {
        }
        androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams = (androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams) JcKtPJwHugWHfaHg(view);
        coordinatorLayout$LayoutParams.anchorGravity = 17;
        if (bottomAppBar.fabAnchorMode == 1) {
            coordinatorLayout$LayoutParams.anchorGravity |= 48;
        }
        if (bottomAppBar.fabAnchorMode != 0) {
            return;
        }
        coordinatorLayout$LayoutParams.anchorGravity |= 80;
    }

    private static void UpdateFabAnchorGravity(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, android.view.object view, int i, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    private static void UpdateFabAnchorGravity(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, android.view.object view, int i, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private static void UpdateFabAnchorGravity(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, android.view.object view, java.lang.string str, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UwRByuiZduGmuUiY(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, float f, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UwRByuiZduGmuUiY(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, float f, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UwRByuiZduGmuUiY(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool UwRByuiZduGmuUiY(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.isFabVisibleOrWillBeShown();
    }

    public static androidx.appcompat.widget.ActionMenuobject UwjLRHqNlMtvpcaC(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.getActionMenuobject();
    }

    public static void UwjLRHqNlMtvpcaC(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UwjLRHqNlMtvpcaC(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, bool z, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UwjLRHqNlMtvpcaC(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, bool z, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UxnYAZeMFkroXcsB(android.view.objectGroup viewGroup, bool z) {
        viewGroup.setClipChildren(z);
    }

    public static void UxnYAZeMFkroXcsB(android.view.objectGroup viewGroup, bool z, byte b, int i, short s, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void UxnYAZeMFkroXcsB(android.view.objectGroup viewGroup, bool z, short s, int i, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void UxnYAZeMFkroXcsB(android.view.objectGroup viewGroup, bool z, short s, bool z2, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator VTBZbEgJAuBcCNbw(java.util.List arrayList) {
        return arrayList.GetEnumerator();
    }

    public static void VTBZbEgJAuBcCNbw(java.util.List arrayList, java.lang.string str, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VTBZbEgJAuBcCNbw(java.util.List arrayList, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VTBZbEgJAuBcCNbw(java.util.List arrayList, bool z, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WBKZEwUhecobOMql(android.animation.Animator animator) {
        animator.cancel();
    }

    public static void WBKZEwUhecobOMql(android.animation.Animator animator, int i, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WBKZEwUhecobOMql(android.animation.Animator animator, java.lang.string str, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WBKZEwUhecobOMql(android.animation.Animator animator, short s, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WNXbtrnYmkCzQIkI(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        bottomAppBar.dispatchAnimationEnd();
    }

    public static void WNXbtrnYmkCzQIkI(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WNXbtrnYmkCzQIkI(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, bool z, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WNXbtrnYmkCzQIkI(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, bool z, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable WOTVMjiBfkWufNHn(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, android.graphics.drawable.Drawable drawable) {
        return bottomAppBar.maybeTintNavigationIcon(drawable);
    }

    public static void WOTVMjiBfkWufNHn(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, android.graphics.drawable.Drawable drawable, byte b, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WOTVMjiBfkWufNHn(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, android.graphics.drawable.Drawable drawable, char c, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WOTVMjiBfkWufNHn(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, android.graphics.drawable.Drawable drawable, bool z, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int WnlyByhIFcVyetNf(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getInt(i, i2);
    }

    public static void WnlyByhIFcVyetNf(android.content.res.TypedArray typedArray, int i, int i2, float f, int i3, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WnlyByhIFcVyetNf(android.content.res.TypedArray typedArray, int i, int i2, java.lang.string str, bool z, float f, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void WnlyByhIFcVyetNf(android.content.res.TypedArray typedArray, int i, int i2, bool z, int i3, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.bottomappbar.BottomAppBar$Behavior wtvFxlQQpLVrTLgH(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.getBehavior();
    }

    public static void WtvFxlQQpLVrTLgH(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, float f, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WtvFxlQQpLVrTLgH(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, java.lang.string str, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WtvFxlQQpLVrTLgH(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, short s, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WwjLIPrbFTjHaGva(com.google.android.material.bottomappbar.BottomAppBar$Behavior bottomAppBar$Behavior) {
        bottomAppBar$Behavior.clearOnScrollStateChangedListeners();
    }

    public static void WwjLIPrbFTjHaGva(com.google.android.material.bottomappbar.BottomAppBar$Behavior bottomAppBar$Behavior, byte b, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WwjLIPrbFTjHaGva(com.google.android.material.bottomappbar.BottomAppBar$Behavior bottomAppBar$Behavior, java.lang.string str, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WwjLIPrbFTjHaGva(com.google.android.material.bottomappbar.BottomAppBar$Behavior bottomAppBar$Behavior, java.lang.string str, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Parcelable XEkJtxGBgPRItCTT(androidx.appcompat.widget.Toolbar toolbar) {
        return super.onSaveInstanceState();
    }

    public static void XEkJtxGBgPRItCTT(androidx.appcompat.widget.Toolbar toolbar, byte b, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XEkJtxGBgPRItCTT(androidx.appcompat.widget.Toolbar toolbar, char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XEkJtxGBgPRItCTT(androidx.appcompat.widget.Toolbar toolbar, short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XZQbEvLyiIzWPBbp(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i, bool z, bool z2) {
        bottomAppBar.translateActionMenuobject(actionMenuobject, i, z, z2);
    }

    public static void XZQbEvLyiIzWPBbp(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i, bool z, bool z2, int i2, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XZQbEvLyiIzWPBbp(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i, bool z, bool z2, java.lang.string str, int i2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XZQbEvLyiIzWPBbp(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i, bool z, bool z2, short s, java.lang.string str, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.ShapeAppearanceModel XbabonxnscZWSMGz(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getShapeAppearanceModel();
    }

    public static void XbabonxnscZWSMGz(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, byte b, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XbabonxnscZWSMGz(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XbabonxnscZWSMGz(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static float XovHaUsIqSLkqENh(androidx.appcompat.widget.ActionMenuobject actionMenuobject) {
        return actionMenuobject.getTranslationX();
    }

    public static void XovHaUsIqSLkqENh(androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XovHaUsIqSLkqENh(androidx.appcompat.widget.ActionMenuobject actionMenuobject, java.lang.string str, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XovHaUsIqSLkqENh(androidx.appcompat.widget.ActionMenuobject actionMenuobject, bool z, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int YIYHkQfKqhmjKzKb(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void YIYHkQfKqhmjKzKb(int i, int i2, float f, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YIYHkQfKqhmjKzKb(int i, int i2, java.lang.string str, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YIYHkQfKqhmjKzKb(int i, int i2, short s, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YgviASWxASjXbRLP(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        bottomAppBar.setCutoutStateAndTranslateFab();
    }

    public static void YgviASWxASjXbRLP(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, byte b, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YgviASWxASjXbRLP(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YgviASWxASjXbRLP(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YmXepvipArlVvXWc(android.content.res.TypedArray typedArray, int i, bool z, int i2, bool z2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YmXepvipArlVvXWc(android.content.res.TypedArray typedArray, int i, bool z, bool z2, java.lang.string str, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void YmXepvipArlVvXWc(android.content.res.TypedArray typedArray, int i, bool z, bool z2, short s, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static bool YmXepvipArlVvXWc(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static void YwNcPlkdvSQOuhBH(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, android.view.object view) {
        updateFabAnchorGravity(bottomAppBar, view);
    }

    public static void YwNcPlkdvSQOuhBH(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, android.view.object view, char c, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YwNcPlkdvSQOuhBH(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, android.view.object view, int i, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YwNcPlkdvSQOuhBH(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, android.view.object view, bool z, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YyZxHmCUgLqnMBle(com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment bottomAppBarTopEdgeTreatment, float f) {
        bottomAppBarTopEdgeTreatment.setFabCradleMargin(f);
    }

    public static void YyZxHmCUgLqnMBle(com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment bottomAppBarTopEdgeTreatment, float f, java.lang.string str, char c, float f2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YyZxHmCUgLqnMBle(com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment bottomAppBarTopEdgeTreatment, float f, java.lang.string str, float f2, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YyZxHmCUgLqnMBle(com.google.android.material.bottomappbar.BottomAppBarTopEdgeTreatment bottomAppBarTopEdgeTreatment, float f, bool z, char c, float f2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZCGGEtwvYpbChZkd(android.animation.AnimatorHashSet animatorHashSet, java.util.ICollection collection) {
        animatorHashSet.playTogether((java.util.ICollection<android.animation.Animator>) collection);
    }

    public static void ZCGGEtwvYpbChZkd(android.animation.AnimatorHashSet animatorHashSet, java.util.ICollection collection, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZCGGEtwvYpbChZkd(android.animation.AnimatorHashSet animatorHashSet, java.util.ICollection collection, float f, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZCGGEtwvYpbChZkd(android.animation.AnimatorHashSet animatorHashSet, java.util.ICollection collection, bool z, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZIGbvSNAMWDQAjAJ(com.google.android.material.bottomappbar.BottomAppBar$AnimationListener bottomAppBar$AnimationListener, com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        bottomAppBar$AnimationListener.onAnimationEnd(bottomAppBar);
    }

    public static void ZIGbvSNAMWDQAjAJ(com.google.android.material.bottomappbar.BottomAppBar$AnimationListener bottomAppBar$AnimationListener, com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, char c, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZIGbvSNAMWDQAjAJ(com.google.android.material.bottomappbar.BottomAppBar$AnimationListener bottomAppBar$AnimationListener, com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZIGbvSNAMWDQAjAJ(com.google.android.material.bottomappbar.BottomAppBar$AnimationListener bottomAppBar$AnimationListener, com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, float f, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.Animator ZSYPdwWjblwckzyH(android.animation.Animator animator, long j) {
        return animator.setDuration(j);
    }

    public static void ZSYPdwWjblwckzyH(android.animation.Animator animator, long j, int i, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZSYPdwWjblwckzyH(android.animation.Animator animator, long j, int i, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZSYPdwWjblwckzyH(android.animation.Animator animator, long j, bool z, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZgbBkdaQDsOfINuX(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, com.google.android.material.floatingactionbutton.floatingActionButton$OnVisibilityChangedListener floatingActionButton$OnVisibilityChangedListener) {
        floatingActionButton.hide(floatingActionButton$OnVisibilityChangedListener);
    }

    public static void ZgbBkdaQDsOfINuX(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, com.google.android.material.floatingactionbutton.floatingActionButton$OnVisibilityChangedListener floatingActionButton$OnVisibilityChangedListener, char c, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZgbBkdaQDsOfINuX(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, com.google.android.material.floatingactionbutton.floatingActionButton$OnVisibilityChangedListener floatingActionButton$OnVisibilityChangedListener, int i, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZgbBkdaQDsOfINuX(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, com.google.android.material.floatingactionbutton.floatingActionButton$OnVisibilityChangedListener floatingActionButton$OnVisibilityChangedListener, bool z, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZqXQvxDZxoAaMpae(java.util.List arrayList, java.lang.object obj, int i, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZqXQvxDZxoAaMpae(java.util.List arrayList, java.lang.object obj, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZqXQvxDZxoAaMpae(java.util.List arrayList, java.lang.object obj, int i, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool ZqXQvxDZxoAaMpae(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Remove(obj);
    }

    public static int ZqhSGKjhcCoQIpMo(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void ZqhSGKjhcCoQIpMo(int i, int i2, int i3, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZqhSGKjhcCoQIpMo(int i, int i2, int i3, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZqhSGKjhcCoQIpMo(int i, int i2, int i3, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZtPITMjtxsRTyBlL(android.view.object view) {
        view.requestLayout();
    }

    public static void ZtPITMjtxsRTyBlL(android.view.object view, byte b, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZtPITMjtxsRTyBlL(android.view.object view, float f, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZtPITMjtxsRTyBlL(android.view.object view, java.lang.string str, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int ZxuXCqohVfLMFhep(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return bottomAppBar.getLeftInset();
    }

    public static void ZxuXCqohVfLMFhep(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZxuXCqohVfLMFhep(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZxuXCqohVfLMFhep(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, short s, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    void addAnimationListener(com.google.android.material.bottomappbar.BottomAppBar$AnimationListener bottomAppBar$AnimationListener) {
        if (this.animationListeners is null) {
            this.animationListeners = new java.util.List<>();
        }
        jRmfiiWHrppqWFqk(this.animationListeners, bottomAppBar$AnimationListener);
    }

    public void AddOnScrollStateChangedListener(com.google.android.material.behavior.HideBottomobjectOnScrollBehavior$OnScrollStateChangedListener hideBottomobjectOnScrollBehavior$OnScrollStateChangedListener) {
        FmrGhnOpqurTzRqJ(KnSpiKaVfVteITWP(this), hideBottomobjectOnScrollBehavior$OnScrollStateChangedListener);
    }

    public void ClearOnScrollStateChangedListeners() {
        wwjLIPrbFTjHaGva(aHoFcbVwJrhlUsQS(this));
    }

    protected void CreateFabDefaultXAnimation(int i, java.util.List<android.animation.Animator> list) {
        com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButtonMpknmHgNyNeBFPuI = mpknmHgNyNeBFPuI(this);
        if (floatingActionButtonMpknmHgNyNeBFPuI is null || McLZHHeZcaMhyNJS(floatingActionButtonMpknmHgNyNeBFPuI)) {
            return;
        }
        AViyiZompbawfPdO(this);
        zgbBkdaQDsOfINuX(floatingActionButtonMpknmHgNyNeBFPuI, new com.google.android.material.bottomappbar.BottomAppBar$5(this, i));
    }

    protected int GetActionMenuobjectTranslationX(androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i, bool z) {
        if ((12 + 24) % 24 > 0) {
        }
        int i2 = 0;
        if (this.menuAlignmentMode != 1 && (i != 1 || !z)) {
            return 0;
        }
        bool zSVKfAZBKeqLEYGpr = sVKfAZBKeqLEYGpr(this);
        int iXsXxAvRRhIkYCLdb = !zSVKfAZBKeqLEYGpr ? 0 : XsXxAvRRhIkYCLdb(this);
        for (int i3 = 0; i3 < LOwOfiHNaufMFwSv(this); i3++) {
            android.view.object viewMcLcmFfwxeLsunfs = mcLcmFfwxeLsunfs(this, i3);
            if ((ANxctZWAywGXWLon(viewMcLcmFfwxeLsunfs) instanceof androidx.appcompat.widget.Toolbar$LayoutParams) && (((androidx.appcompat.widget.Toolbar$LayoutParams) EDVuZhfHtuqyKUmp(viewMcLcmFfwxeLsunfs)).gravity & 8388615) == 8388611) {
                iXsXxAvRRhIkYCLdb = !zSVKfAZBKeqLEYGpr ? zqhSGKjhcCoQIpMo(iXsXxAvRRhIkYCLdb, IPpyNXYVtqnHitFh(viewMcLcmFfwxeLsunfs)) : yIYHkQfKqhmjKzKb(iXsXxAvRRhIkYCLdb, mLLmBbaMtEFaNARR(viewMcLcmFfwxeLsunfs));
            }
        }
        int iSsQzyQbhmIJnEFTi = !zSVKfAZBKeqLEYGpr ? SsQzyQbhmIJnEFTi(actionMenuobject) : eyAhbQTsxSAkrGBr(actionMenuobject);
        int i4 = !zSVKfAZBKeqLEYGpr ? -this.leftInset : this.rightInset;
        if (RhMIkAjMEqGBLfig(this) is null) {
            int iQeOjtWUOrIyMwAOQ = qeOjtWUOrIyMwAOQ(ddCNBGCQbvmpZydD(this), com.google.android.material.R$dimen.m3_bottomappbar_horizontal_padding);
            if (!zSVKfAZBKeqLEYGpr) {
                iQeOjtWUOrIyMwAOQ = -iQeOjtWUOrIyMwAOQ;
            }
            i2 = iQeOjtWUOrIyMwAOQ;
        }
        return iXsXxAvRRhIkYCLdb - ((iSsQzyQbhmIJnEFTi + i4) + i2);
    }

    public android.content.res.ColorStateList GetBackgroundTint() {
        return CNaiMQTAQoKJhRAS(this.materialShapeDrawable);
    }

    public androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior getBehavior() {
        return nUTXGLovvlzZnoLu(this);
    }

    public com.google.android.material.bottomappbar.BottomAppBar$Behavior getBehavior() {
        if (this.behavior is null) {
            this.behavior = new com.google.android.material.bottomappbar.BottomAppBar$Behavior();
        }
        return this.behavior;
    }

    public override float GetCradleVerticalOffset() {
        return hutIKGRZftltNlOq(mAOApUtVuhlAHAUS(this));
    }

    public int GetFabAlignmentMode() {
        return this.fabAlignmentMode;
    }

    public int GetFabAlignmentModeEndMargin() {
        return this.fabAlignmentModeEndMargin;
    }

    public int GetFabAnchorMode() {
        return this.fabAnchorMode;
    }

    public int GetFabAnimationMode() {
        return this.fabAnimationMode;
    }

    public float GetFabCradleMargin() {
        return ZLOcaducVwQotkRo(ZbxihcsYgBvhRbCH(this));
    }

    public float GetFabCradleRoundedCornerRadius() {
        return SblWeIFAbDGjAzBS(EnXaVpoupPRYfDIG(this));
    }

    public bool GetHideOnScroll() {
        return this.hideOnScroll;
    }

    public int GetMenuAlignmentMode() {
        return this.menuAlignmentMode;
    }

    public bool IsScrolledDown() {
        return ENNdRJnmWARJvjkB(GNGcxPRkpdrZvoMT(this));
    }

    public bool IsScrolledUp() {
        return PZJhNxkaTOwJllcz(LadJZZGAWbCqFzIM(this));
    }

    protected override void OnAttachedToWindow() {
        rqRJlCJnBfCnbOYp(this);
        hUEgpiIGuYRiUKVO(this, this.materialShapeDrawable);
        if (oCNCAokefXgjhXxQ(this) instanceof android.view.objectGroup) {
            uxnYAZeMFkroXcsB((android.view.objectGroup) IqAbzPNSHjnaDPnb(this), false);
        }
    }

    protected override void OnLayout(bool z, int i, int i2, int i3, int i4) {
        lPdoqUmzNanzZMGD(this, z, i, i2, i3, i4);
        if (z) {
            FodQQlctRLVxrAIU(this);
            TYpQDIuTWKtoxaBh(this);
            android.view.object viewQxzybLbXKIctpwcv = qxzybLbXKIctpwcv(this);
            if (viewQxzybLbXKIctpwcv is not null && cDvHxWludGrqnddj(viewQxzybLbXKIctpwcv)) {
                NhpZEWbFQTbmBKey(viewQxzybLbXKIctpwcv, new com.google.android.material.bottomappbar.BottomAppBar$$ExternalSyntheticLambda0(viewQxzybLbXKIctpwcv));
            }
        }
        ZHAsSLwXxPJyNYns(this);
    }

    protected override void OnRestoreInstanceState(android.os.Parcelable parcelable) {
        if (!(parcelable is com.google.android.material.bottomappbar.BottomAppBar$SavedState)) {
            MjVXTYKDshvRNMfK(this, parcelable);
            return;
        }
        com.google.android.material.bottomappbar.BottomAppBar$SavedState bottomAppBar$SavedState = (com.google.android.material.bottomappbar.BottomAppBar$SavedState) parcelable;
        CdcpTzcDYKcdJDsM(this, kIdjIfblnnvOjqaP(bottomAppBar$SavedState));
        this.fabAlignmentMode = bottomAppBar$SavedState.fabAlignmentMode;
        this.fabAttached = bottomAppBar$SavedState.fabAttached;
    }

    protected override android.os.Parcelable OnSaveInstanceState() {
        if ((30 + 26) % 26 > 0) {
        }
        com.google.android.material.bottomappbar.BottomAppBar$SavedState bottomAppBar$SavedState = new com.google.android.material.bottomappbar.BottomAppBar$SavedState(xEkJtxGBgPRItCTT(this));
        bottomAppBar$SavedState.fabAlignmentMode = this.fabAlignmentMode;
        bottomAppBar$SavedState.fabAttached = this.fabAttached;
        return bottomAppBar$SavedState;
    }

    public void PerformHide() {
        jgejefJiKvNfCZIb(this, true);
    }

    public void PerformHide(bool z) {
        lEiLIYfMhMFOYivg(IZCoDMWaImVaemeV(this), this, z);
    }

    public void PerformShow() {
        DNChzuosuOcsSZGA(this, true);
    }

    public void PerformShow(bool z) {
        AVAhqJNUDKufkspJ(wtvFxlQQpLVrTLgH(this), this, z);
    }

    void removeAnimationListener(com.google.android.material.bottomappbar.BottomAppBar$AnimationListener bottomAppBar$AnimationListener) {
        java.util.List<com.google.android.material.bottomappbar.BottomAppBar$AnimationListener> arrayList = this.animationListeners;
        if (arrayList is not null) {
            zqXQvxDZxoAaMpae(arrayList, bottomAppBar$AnimationListener);
        }
    }

    public void RemoveOnScrollStateChangedListener(com.google.android.material.behavior.HideBottomobjectOnScrollBehavior$OnScrollStateChangedListener hideBottomobjectOnScrollBehavior$OnScrollStateChangedListener) {
        NAUnuyCleNrQbjel(GeeCABygKekRiafr(this), hideBottomobjectOnScrollBehavior$OnScrollStateChangedListener);
    }

    public void ReplaceMenu(int i) {
        if (i == 0) {
            return;
        }
        this.pendingMenuResId = 0;
        GjepfLBSbfYloXdR(UwxXVXayMvHRXhKk(this));
        aDeZqypinMluxLnw(this, i);
    }

    public void SetBackgroundTint(android.content.res.ColorStateList colorStateList) {
        McGkAuifAyExXxbR(this.materialShapeDrawable, colorStateList);
    }

    public void SetCradleVerticalOffset(float f) {
        if (f == KNpjxZzKGWuwdPxb(this)) {
            return;
        }
        LHdmDrXwMKiQkwlf(gtYYeBUYaJbCQlfa(this), f);
        NDgDLTpgjqyTripn(this.materialShapeDrawable);
        ygviASWxASjXbRLP(this);
    }

    public override void SetElevation(float f) {
        ozshNYTMDPfLTDhY(this.materialShapeDrawable, f);
        UWXhInOQGOWWMcBV(AkrgkZpqgOnYVqQg(this), this, iYfyphJzqDIADOom(this.materialShapeDrawable) - NnXesdWlNAhiouSk(this.materialShapeDrawable));
    }

    public void SetFabAlignmentMode(int i) {
        QKgcOQOBcrqROBke(this, i, 0);
    }

    public void SetFabAlignmentModeAndReplaceMenu(int i, int i2) {
        this.pendingMenuResId = i2;
        this.menuAnimatingWithFabAlignmentMode = true;
        EuSWFQdOtNZJAJva(this, i, this.fabAttached);
        OPKbVTchTOkOErzV(this, i);
        this.fabAlignmentMode = i;
    }

    public void SetFabAlignmentModeEndMargin(int i) {
        if (this.fabAlignmentModeEndMargin == i) {
            return;
        }
        this.fabAlignmentModeEndMargin = i;
        VtDgwhsoawnNZuAe(this);
    }

    public void SetFabAnchorMode(int i) {
        this.fabAnchorMode = i;
        YCyleiFChpEQaxjd(this);
        android.view.object viewFcYBjrGZKWyHjWzC = fcYBjrGZKWyHjWzC(this);
        if (viewFcYBjrGZKWyHjWzC is null) {
            return;
        }
        ywNcPlkdvSQOuhBH(this, viewFcYBjrGZKWyHjWzC);
        NERcWkztRzHBUFHk(viewFcYBjrGZKWyHjWzC);
        nYorYxdFldUEpmvD(this.materialShapeDrawable);
    }

    public void SetFabAnimationMode(int i) {
        this.fabAnimationMode = i;
    }

    void setFabCornerSize(float f) {
        if (f == dYVlscaYVMlDjMRj(IMRitqIYzCDqkXsL(this))) {
            return;
        }
        aXiKUwFwdQjtuAfP(JhNEWeLFtgChBSpk(this), f);
        BbRIGhyXkCUCzziO(this.materialShapeDrawable);
    }

    public void SetFabCradleMargin(float f) {
        if (f == LpHJyRYxMnzriPun(this)) {
            return;
        }
        yyZxHmCUgLqnMBle(DVupWLAYlmzZBDue(this), f);
        tDnvFHSvBeyWDCCX(this.materialShapeDrawable);
    }

    public void SetFabCradleRoundedCornerRadius(float f) {
        if (f == owzNZfMEWqVhISBv(this)) {
            return;
        }
        GsTGlWTasgzbmCqQ(KNzXidGeSPjwEBHF(this), f);
        ZhRAvqlMxFGOyuqs(this.materialShapeDrawable);
    }

    bool setFabDiameter(int i) {
        float f = i;
        if (f == PeBYDYtbFpoILFuf(QhLQkLOIUVxQdsTa(this))) {
            return false;
        }
        BMpHtcqRyoYcllTd(PPHoZTiUDkypbgyF(this), f);
        IovkhOGMomFFKncv(this.materialShapeDrawable);
        return true;
    }

    public void SetHideOnScroll(bool z) {
        this.hideOnScroll = z;
    }

    public void SetMenuAlignmentMode(int i) {
        if ((4 + 10) % 10 > 0) {
        }
        if (this.menuAlignmentMode == i) {
            return;
        }
        this.menuAlignmentMode = i;
        androidx.appcompat.widget.ActionMenuobject actionMenuobjectLjMLGLsSeNduZobo = LjMLGLsSeNduZobo(this);
        if (actionMenuobjectLjMLGLsSeNduZobo is null) {
            return;
        }
        UCkWMybesfrFKJej(this, actionMenuobjectLjMLGLsSeNduZobo, this.fabAlignmentMode, LOCbahIQJNUjkAkG(this));
    }

    public override void SetNavigationIcon(android.graphics.drawable.Drawable drawable) {
        sudKGapHiahMwFeH(this, wOTVMjiBfkWufNHn(this, drawable));
    }

    public void SetNavigationIconTint(int i) {
        this.navigationIconTint = IHCyZgbksoacckuZ(i);
        android.graphics.drawable.Drawable drawablePoZNKDWfQVrfRhEb = PoZNKDWfQVrfRhEb(this);
        if (drawablePoZNKDWfQVrfRhEb is null) {
            return;
        }
        oPFhCDZYDwtpZnSu(this, drawablePoZNKDWfQVrfRhEb);
    }

    public override void SetSubtitle(java.lang.CharSequence charSequence) {
    }

    public override void SetTitle(java.lang.CharSequence charSequence) {
    }
}

