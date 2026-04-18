namespace WillowMaze.Wasm.Decompiled;


public class floatingActionButton : com.google.android.material.internal.VisibilityAwareImageButton : androidx.core.view.TintableBackgroundobject, androidx.core.widget.TintableImageSourceobject, com.google.android.material.expandable.ExpandableTransformationWidget, com.google.android.material.shape.Shapeable, androidx.coordinatorlayout.widget.CoordinatorLayout$AttachedBehavior {
    private static readonly int AUTO_MINI_LARGEST_SCREEN_WIDTH = 470;
    private static readonly int DEF_STYLE_RES = com.google.android.material.R$style.Widget_Design_floatingActionButton;
    private static readonly java.lang.string EXPANDABLE_WIDGET_HELPER_KEY = "expandableWidgetHelper";
    private static readonly java.lang.string LOG_TAG = "floatingActionButton";
    public static readonly int NO_CUSTOM_SIZE = 0;
    public static readonly int SIZE_AUTO = -1;
    public static readonly int SIZE_MINI = 1;
    public static readonly int SIZE_NORMAL = 0;
    private android.content.res.ColorStateList backgroundTint;
    private android.graphics.PorterDuff$Mode backgroundTintMode;
    private int borderWidth;
    bool compatPadding;
    private int customSize;
    private readonly com.google.android.material.expandable.ExpandableWidgetHelper expandableWidgetHelper;
    private readonly androidx.appcompat.widget.AppCompatImageHelper imageHelper;
    private android.graphics.PorterDuff$Mode imageMode;
    private int imagePadding;
    private android.content.res.ColorStateList imageTint;
    private com.google.android.material.floatingactionbutton.floatingActionButtonImpl impl;
    private int maxImageSize;
    private android.content.res.ColorStateList rippleColor;
    readonly android.graphics.Rect shadowPadding;
    private int size;
    private readonly android.graphics.Rect touchArea;

    public floatingActionButton(android.content.object context) {
        this(context, null);
    }

    public floatingActionButton(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, com.google.android.material.R$attr.floatingActionButtonStyle);
    }

    public floatingActionButton(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        if ((5 + 2) % 2 > 0) {
        }
        int i2 = DEF_STYLE_RES;
        super(jIwkAEzXVWfhPHtR(context, attributeHashSet, i, i2), attributeHashSet, i);
        this.shadowPadding = new android.graphics.Rect();
        this.touchArea = new android.graphics.Rect();
        android.content.object contextVXQYDpCpEjjmlgeb = vXQYDpCpEjjmlgeb(this);
        android.content.res.TypedArray typedArrayIzKcAjsXvDKWDHWS = izKcAjsXvDKWDHWS(contextVXQYDpCpEjjmlgeb, attributeHashSet, com.google.android.material.R$styleable.floatingActionButton, i, i2, new int[0]);
        this.backgroundTint = XtPWTDgYzbejHyEL(contextVXQYDpCpEjjmlgeb, typedArrayIzKcAjsXvDKWDHWS, com.google.android.material.R$styleable.floatingActionButton_backgroundTint);
        this.backgroundTintMode = VLnEbrVEQqUKvrIw(GTOgFFkRGjumoWxS(typedArrayIzKcAjsXvDKWDHWS, com.google.android.material.R$styleable.floatingActionButton_backgroundTintMode, -1), null);
        this.rippleColor = YCveYXgEpAmIERug(contextVXQYDpCpEjjmlgeb, typedArrayIzKcAjsXvDKWDHWS, com.google.android.material.R$styleable.floatingActionButton_rippleColor);
        this.size = CTugXiigyZuyudUx(typedArrayIzKcAjsXvDKWDHWS, com.google.android.material.R$styleable.floatingActionButton_fabSize, -1);
        this.customSize = VyHNeBMGcfoJNLye(typedArrayIzKcAjsXvDKWDHWS, com.google.android.material.R$styleable.floatingActionButton_fabCustomSize, 0);
        this.borderWidth = UvwhDPBlGXwKIlaJ(typedArrayIzKcAjsXvDKWDHWS, com.google.android.material.R$styleable.floatingActionButton_borderWidth, 0);
        float fDaVFIvjClEhNOLNT = daVFIvjClEhNOLNT(typedArrayIzKcAjsXvDKWDHWS, com.google.android.material.R$styleable.floatingActionButton_elevation, 0.0f);
        float fLknIonNoEKSaCGiJ = lknIonNoEKSaCGiJ(typedArrayIzKcAjsXvDKWDHWS, com.google.android.material.R$styleable.floatingActionButton_hoveredFocusedTranslationZ, 0.0f);
        float fEtFChETGwQpQrWxK = EtFChETGwQpQrWxK(typedArrayIzKcAjsXvDKWDHWS, com.google.android.material.R$styleable.floatingActionButton_pressedTranslationZ, 0.0f);
        this.compatPadding = ddNuvRZvfemmOCXl(typedArrayIzKcAjsXvDKWDHWS, com.google.android.material.R$styleable.floatingActionButton_useCompatPadding, false);
        int iXehYyschphGyWThR = XehYyschphGyWThR(GjRjQqwFRGZHuWwP(this), com.google.android.material.R$dimen.mtrl_fab_min_touch_target);
        aitNWBTOFjeTdkCC(this, yNEkRJhwsUBeMXvd(typedArrayIzKcAjsXvDKWDHWS, com.google.android.material.R$styleable.floatingActionButton_maxImageSize, 0));
        com.google.android.material.animation.MotionSpec motionSpecWdyDJmOMRKknYWQy = wdyDJmOMRKknYWQy(contextVXQYDpCpEjjmlgeb, typedArrayIzKcAjsXvDKWDHWS, com.google.android.material.R$styleable.floatingActionButton_showMotionSpec);
        com.google.android.material.animation.MotionSpec motionSpecMBwAouQlXdTTZNeP = MBwAouQlXdTTZNeP(contextVXQYDpCpEjjmlgeb, typedArrayIzKcAjsXvDKWDHWS, com.google.android.material.R$styleable.floatingActionButton_hideMotionSpec);
        com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModelEuPHGZLbXXMIBbFp = EuPHGZLbXXMIBbFp(OSCOfOQlLUMwopYb(contextVXQYDpCpEjjmlgeb, attributeHashSet, i, i2, com.google.android.material.shape.ShapeAppearanceModel.PILL));
        bool zRjGLIHxKeahkCYux = RjGLIHxKeahkCYux(typedArrayIzKcAjsXvDKWDHWS, com.google.android.material.R$styleable.floatingActionButton_ensureMinTouchTargetSize, false);
        aTcdRsKbbOGIYqQQ(this, atOTsWOeIfFqyUva(typedArrayIzKcAjsXvDKWDHWS, com.google.android.material.R$styleable.floatingActionButton_android_enabled, true));
        GzLkEhgCRyXMubdq(typedArrayIzKcAjsXvDKWDHWS);
        androidx.appcompat.widget.AppCompatImageHelper appCompatImageHelper = new androidx.appcompat.widget.AppCompatImageHelper(this);
        this.imageHelper = appCompatImageHelper;
        wawRXlUksuCYsJcx(appCompatImageHelper, attributeHashSet, i);
        this.expandableWidgetHelper = new com.google.android.material.expandable.ExpandableWidgetHelper(this);
        qIDfBtfpSsqSgbIK(JpdYoxyZveHswXvb(this), shapeAppearanceModelEuPHGZLbXXMIBbFp);
        hsMqLkfAjtswRKup(GeMiAHKDEPIBaLmo(this), this.backgroundTint, this.backgroundTintMode, this.rippleColor, this.borderWidth);
        tHBcSBILQLtWJmtp(LChoWHooIBhKNGkj(this), iXehYyschphGyWThR);
        RhTvlkZYXxUMdklu(ILbLTUExyYRvkMLP(this), fDaVFIvjClEhNOLNT);
        JAiIBxkEGyPxanMb(JsgQzbzVSWLFKREA(this), fLknIonNoEKSaCGiJ);
        CvXjNKOWUZNUrcAe(RMYnMBxDTzRRlZtp(this), fEtFChETGwQpQrWxK);
        YTrcwArxBgcrpBFY(KwghvwFBNfgCaxDs(this), motionSpecWdyDJmOMRKknYWQy);
        PQdyAatKCaItpofG(eLZMCUhHpApflpcK(this), motionSpecMBwAouQlXdTTZNeP);
        jJOgkMDABBVeOXev(fSnXHZLyVwGZqsRO(this), zRjGLIHxKeahkCYux);
        GfzxKWqEHcuDtgqb(this, android.widget.Imageobject$ScaleType.MATRIX);
    }

    public static int AiSpCtwbZoeGqkzx(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getWidth();
    }

    public static void AiSpCtwbZoeGqkzx(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, char c, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AiSpCtwbZoeGqkzx(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, char c, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AiSpCtwbZoeGqkzx(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object BJzDbxAyMcshCzvH(androidx.collection.SimpleArrayDictionary simpleArrayDictionary, java.lang.object obj) {
        return simpleArrayDictionary[obj);
    }

    public static void BJzDbxAyMcshCzvH(androidx.collection.SimpleArrayDictionary simpleArrayDictionary, java.lang.object obj, byte b, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BJzDbxAyMcshCzvH(androidx.collection.SimpleArrayDictionary simpleArrayDictionary, java.lang.object obj, char c, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BJzDbxAyMcshCzvH(androidx.collection.SimpleArrayDictionary simpleArrayDictionary, java.lang.object obj, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.floatingactionbutton.floatingActionButtonImpl BjbuNwqhIPzIMyJP(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getImpl();
    }

    public static void BjbuNwqhIPzIMyJP(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, byte b, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BjbuNwqhIPzIMyJP(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BjbuNwqhIPzIMyJP(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.floatingactionbutton.floatingActionButtonImpl CDUSLSkLzzygHRnI(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getImpl();
    }

    public static void CDUSLSkLzzygHRnI(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, char c, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CDUSLSkLzzygHRnI(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, float f, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CDUSLSkLzzygHRnI(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, float f, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static int CTugXiigyZuyudUx(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getInt(i, i2);
    }

    public static void CTugXiigyZuyudUx(android.content.res.TypedArray typedArray, int i, int i2, short s, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CTugXiigyZuyudUx(android.content.res.TypedArray typedArray, int i, int i2, short s, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CTugXiigyZuyudUx(android.content.res.TypedArray typedArray, int i, int i2, bool z, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CvXjNKOWUZNUrcAe(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, float f) {
        floatingActionButtonImpl.setPressedTranslationZ(f);
    }

    public static void CvXjNKOWUZNUrcAe(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, float f, char c, int i, bool z, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void CvXjNKOWUZNUrcAe(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, float f, float f2, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CvXjNKOWUZNUrcAe(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, float f, bool z, char c, float f2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DObZqOMUnwCpifXL(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl) {
        floatingActionButtonImpl.onTranslationChanged();
    }

    public static void DObZqOMUnwCpifXL(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, int i, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DObZqOMUnwCpifXL(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, int i, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DObZqOMUnwCpifXL(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, int i, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.floatingactionbutton.floatingActionButtonImpl DYonHcpBxoonMVbV(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getImpl();
    }

    public static void DYonHcpBxoonMVbV(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, java.lang.string str, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DYonHcpBxoonMVbV(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DYonHcpBxoonMVbV(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DeRYXkVjLuamIyQu(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, android.content.res.ColorStateList colorStateList) {
        floatingActionButton.setBackgroundTintList(colorStateList);
    }

    public static void DeRYXkVjLuamIyQu(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, android.content.res.ColorStateList colorStateList, byte b, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DeRYXkVjLuamIyQu(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, android.content.res.ColorStateList colorStateList, byte b, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DeRYXkVjLuamIyQu(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, android.content.res.ColorStateList colorStateList, bool z, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.floatingactionbutton.floatingActionButtonImpl DljbXUXCqptCpmKX(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getImpl();
    }

    public static void DljbXUXCqptCpmKX(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, byte b, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DljbXUXCqptCpmKX(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, bool z, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DljbXUXCqptCpmKX(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, bool z, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.floatingactionbutton.floatingActionButtonImpl DrduYZddsvJEwdQw(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getImpl();
    }

    public static void DrduYZddsvJEwdQw(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, char c, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DrduYZddsvJEwdQw(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, char c, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DrduYZddsvJEwdQw(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EDwJmbqPjkVTOEiO(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, android.graphics.Rect rect) {
        floatingActionButton.offsetRectWithShadow(rect);
    }

    public static void EDwJmbqPjkVTOEiO(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, android.graphics.Rect rect, char c, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EDwJmbqPjkVTOEiO(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, android.graphics.Rect rect, int i, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EDwJmbqPjkVTOEiO(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, android.graphics.Rect rect, int i, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object ELlwyOwXgEhNwKXq(java.lang.object obj) {
        return androidx.core.util.Preconditions.checkNotNull(obj);
    }

    public static void ELlwyOwXgEhNwKXq(java.lang.object obj, byte b, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ELlwyOwXgEhNwKXq(java.lang.object obj, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ELlwyOwXgEhNwKXq(java.lang.object obj, short s, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ERwolORzvkXhPDYR(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, com.google.android.material.animation.MotionSpec motionSpec) {
        floatingActionButton.setHideMotionSpec(motionSpec);
    }

    public static void ERwolORzvkXhPDYR(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, com.google.android.material.animation.MotionSpec motionSpec, char c, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ERwolORzvkXhPDYR(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, com.google.android.material.animation.MotionSpec motionSpec, int i, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ERwolORzvkXhPDYR(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, com.google.android.material.animation.MotionSpec motionSpec, int i, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static float EVTZbBKFZwoCqfce(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl) {
        return floatingActionButtonImpl.getElevation();
    }

    public static void EVTZbBKFZwoCqfce(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, short s, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EVTZbBKFZwoCqfce(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, bool z, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EVTZbBKFZwoCqfce(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, bool z, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.floatingactionbutton.floatingActionButtonImpl EWxJaqVJVLBZyElg(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getImpl();
    }

    public static void EWxJaqVJVLBZyElg(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, java.lang.string str, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EWxJaqVJVLBZyElg(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, java.lang.string str, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EWxJaqVJVLBZyElg(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, bool z, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object EXfqMSLeWQIUNwIk(androidx.collection.SimpleArrayDictionary simpleArrayDictionary, java.lang.object obj, java.lang.object obj2) {
        return simpleArrayDictionary.Add(obj, obj2);
    }

    public static void EXfqMSLeWQIUNwIk(androidx.collection.SimpleArrayDictionary simpleArrayDictionary, java.lang.object obj, java.lang.object obj2, byte b, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EXfqMSLeWQIUNwIk(androidx.collection.SimpleArrayDictionary simpleArrayDictionary, java.lang.object obj, java.lang.object obj2, byte b, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EXfqMSLeWQIUNwIk(androidx.collection.SimpleArrayDictionary simpleArrayDictionary, java.lang.object obj, java.lang.object obj2, bool z, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static float EtFChETGwQpQrWxK(android.content.res.TypedArray typedArray, int i, float f) {
        return typedArray.getDimension(i, f);
    }

    public static void EtFChETGwQpQrWxK(android.content.res.TypedArray typedArray, int i, float f, int i2, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EtFChETGwQpQrWxK(android.content.res.TypedArray typedArray, int i, float f, java.lang.string str, byte b, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EtFChETGwQpQrWxK(android.content.res.TypedArray typedArray, int i, float f, short s, java.lang.string str, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.ShapeAppearanceModel EuPHGZLbXXMIBbFp(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return shapeAppearanceModel$Builder.build();
    }

    public static void EuPHGZLbXXMIBbFp(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, short s, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EuPHGZLbXXMIBbFp(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EuPHGZLbXXMIBbFp(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, bool z, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.floatingactionbutton.floatingActionButtonImpl FShTDbDIXTgxTnVH(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getImpl();
    }

    public static void FShTDbDIXTgxTnVH(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, char c, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FShTDbDIXTgxTnVH(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FShTDbDIXTgxTnVH(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, bool z, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FXRGSaMOKsMEYfhK(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, com.google.android.material.floatingactionbutton.floatingActionButton$OnVisibilityChangedListener floatingActionButton$OnVisibilityChangedListener) {
        floatingActionButton.show(floatingActionButton$OnVisibilityChangedListener);
    }

    public static void FXRGSaMOKsMEYfhK(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, com.google.android.material.floatingactionbutton.floatingActionButton$OnVisibilityChangedListener floatingActionButton$OnVisibilityChangedListener, char c, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FXRGSaMOKsMEYfhK(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, com.google.android.material.floatingactionbutton.floatingActionButton$OnVisibilityChangedListener floatingActionButton$OnVisibilityChangedListener, int i, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FXRGSaMOKsMEYfhK(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, com.google.android.material.floatingactionbutton.floatingActionButton$OnVisibilityChangedListener floatingActionButton$OnVisibilityChangedListener, bool z, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FcPxgLvwDlhaLIPu(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton) {
        super.onDetachedFromWindow();
    }

    public static void FcPxgLvwDlhaLIPu(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, byte b, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FcPxgLvwDlhaLIPu(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, int i, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FcPxgLvwDlhaLIPu(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, java.lang.string str, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GBAnpMjYTNzEovqt(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl) {
        floatingActionButtonImpl.updatePadding();
    }

    public static void GBAnpMjYTNzEovqt(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, byte b, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GBAnpMjYTNzEovqt(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, short s, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GBAnpMjYTNzEovqt(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, bool z, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.floatingactionbutton.floatingActionButtonImpl GFyVtzDHvsGhhsYw(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getImpl();
    }

    public static void GFyVtzDHvsGhhsYw(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, java.lang.string str, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GFyVtzDHvsGhhsYw(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, short s, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GFyVtzDHvsGhhsYw(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, short s, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GNBacNjYGPRPhBBp(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, byte b, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GNBacNjYGPRPhBBp(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, short s, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GNBacNjYGPRPhBBp(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int[] GNBacNjYGPRPhBBp(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getDrawableState();
    }

    public static int GTOgFFkRGjumoWxS(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getInt(i, i2);
    }

    public static void GTOgFFkRGjumoWxS(android.content.res.TypedArray typedArray, int i, int i2, byte b, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GTOgFFkRGjumoWxS(android.content.res.TypedArray typedArray, int i, int i2, char c, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GTOgFFkRGjumoWxS(android.content.res.TypedArray typedArray, int i, int i2, short s, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.animation.MotionSpec GUdxlkRmWOxHIJII(android.content.object context, int i) {
        return com.google.android.material.animation.MotionSpec.createFromResource(context, i);
    }

    public static void GUdxlkRmWOxHIJII(android.content.object context, int i, char c, float f, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GUdxlkRmWOxHIJII(android.content.object context, int i, float f, char c, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GUdxlkRmWOxHIJII(android.content.object context, int i, java.lang.string str, char c, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GWsNOqlyKxTFDyEh(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, android.graphics.Rect rect) {
        floatingActionButton.getMeasuredContentRect(rect);
    }

    public static void GWsNOqlyKxTFDyEh(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, android.graphics.Rect rect, byte b, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GWsNOqlyKxTFDyEh(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, android.graphics.Rect rect, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GWsNOqlyKxTFDyEh(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, android.graphics.Rect rect, short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GcZSxoyRcYyfbEsy(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, com.google.android.material.animation.MotionSpec motionSpec) {
        floatingActionButton.setShowMotionSpec(motionSpec);
    }

    public static void GcZSxoyRcYyfbEsy(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, com.google.android.material.animation.MotionSpec motionSpec, char c, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GcZSxoyRcYyfbEsy(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GcZSxoyRcYyfbEsy(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, com.google.android.material.animation.MotionSpec motionSpec, bool z, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object GeKIIBUsJfyUJYTD(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getobject();
    }

    public static void GeKIIBUsJfyUJYTD(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, byte b, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GeKIIBUsJfyUJYTD(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, float f, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GeKIIBUsJfyUJYTD(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, float f, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.floatingactionbutton.floatingActionButtonImpl GeMiAHKDEPIBaLmo(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getImpl();
    }

    public static void GeMiAHKDEPIBaLmo(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, char c, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GeMiAHKDEPIBaLmo(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, java.lang.string str, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GeMiAHKDEPIBaLmo(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, java.lang.string str, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GfzxKWqEHcuDtgqb(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, android.widget.Imageobject$ScaleType imageobject$ScaleType) {
        floatingActionButton.setScaleType(imageobject$ScaleType);
    }

    public static void GfzxKWqEHcuDtgqb(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, android.widget.Imageobject$ScaleType imageobject$ScaleType, byte b, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GfzxKWqEHcuDtgqb(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, android.widget.Imageobject$ScaleType imageobject$ScaleType, char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GfzxKWqEHcuDtgqb(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, android.widget.Imageobject$ScaleType imageobject$ScaleType, char c, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources GjRjQqwFRGZHuWwP(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getResources();
    }

    public static void GjRjQqwFRGZHuWwP(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GjRjQqwFRGZHuWwP(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GjRjQqwFRGZHuWwP(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, char c, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int GvrcklyCkOOPWjPx(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static void GvrcklyCkOOPWjPx(android.content.res.Resources resources, int i, java.lang.string str, bool z, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GvrcklyCkOOPWjPx(android.content.res.Resources resources, int i, bool z, char c, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void GvrcklyCkOOPWjPx(android.content.res.Resources resources, int i, bool z, java.lang.string str, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GzLkEhgCRyXMubdq(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static void GzLkEhgCRyXMubdq(android.content.res.TypedArray typedArray, byte b, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GzLkEhgCRyXMubdq(android.content.res.TypedArray typedArray, java.lang.string str, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GzLkEhgCRyXMubdq(android.content.res.TypedArray typedArray, short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int HfbPYzxBGClyVgDP(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void HfbPYzxBGClyVgDP(int i, int i2, char c, bool z, int i3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HfbPYzxBGClyVgDP(int i, int i2, short s, char c, bool z, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void HfbPYzxBGClyVgDP(int i, int i2, bool z, int i3, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HoCdWeIgnweEJIUg(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl) {
        floatingActionButtonImpl.onTranslationChanged();
    }

    public static void HoCdWeIgnweEJIUg(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, byte b, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HoCdWeIgnweEJIUg(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, int i, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HoCdWeIgnweEJIUg(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, java.lang.string str, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.floatingactionbutton.floatingActionButtonImpl ILbLTUExyYRvkMLP(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getImpl();
    }

    public static void ILbLTUExyYRvkMLP(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ILbLTUExyYRvkMLP(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, java.lang.string str, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ILbLTUExyYRvkMLP(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, short s, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IVdfycjCnsEjrlta(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, float f) {
        floatingActionButton.setCompatElevation(f);
    }

    public static void IVdfycjCnsEjrlta(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, float f, short s, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IVdfycjCnsEjrlta(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, float f, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IVdfycjCnsEjrlta(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, float f, bool z, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IiXPZWkJQPfRClhW(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        floatingActionButtonImpl.removeOnShowAnimationListener(animator$AnimatorListener);
    }

    public static void IiXPZWkJQPfRClhW(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, android.animation.Animator$AnimatorListener animator$AnimatorListener, char c, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IiXPZWkJQPfRClhW(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, android.animation.Animator$AnimatorListener animator$AnimatorListener, char c, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IiXPZWkJQPfRClhW(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, android.animation.Animator$AnimatorListener animator$AnimatorListener, java.lang.string str, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.floatingactionbutton.floatingActionButtonImpl ImLylwqMTevmpvOg(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getImpl();
    }

    public static void ImLylwqMTevmpvOg(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ImLylwqMTevmpvOg(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, java.lang.string str, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ImLylwqMTevmpvOg(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, short s, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JAiIBxkEGyPxanMb(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, float f) {
        floatingActionButtonImpl.setHoveredFocusedTranslationZ(f);
    }

    public static void JAiIBxkEGyPxanMb(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, float f, int i, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JAiIBxkEGyPxanMb(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, float f, short s, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JAiIBxkEGyPxanMb(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, float f, bool z, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JpDwyKVSDNiGMHfB(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, bool z) {
        floatingActionButtonImpl.setEnsureMinTouchTargetSize(z);
    }

    public static void JpDwyKVSDNiGMHfB(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, bool z, char c, bool z2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JpDwyKVSDNiGMHfB(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, bool z, float f, char c, short s, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void JpDwyKVSDNiGMHfB(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, bool z, float f, short s, char c, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.floatingactionbutton.floatingActionButtonImpl JpdYoxyZveHswXvb(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getImpl();
    }

    public static void JpdYoxyZveHswXvb(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, char c, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JpdYoxyZveHswXvb(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, char c, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JpdYoxyZveHswXvb(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, float f, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.floatingactionbutton.floatingActionButtonImpl JsgQzbzVSWLFKREA(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getImpl();
    }

    public static void JsgQzbzVSWLFKREA(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, short s, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JsgQzbzVSWLFKREA(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, short s, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JsgQzbzVSWLFKREA(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, bool z, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JtQvZUYmICaABABV(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl) {
        floatingActionButtonImpl.onScaleChanged();
    }

    public static void JtQvZUYmICaABABV(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, int i, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JtQvZUYmICaABABV(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, bool z, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JtQvZUYmICaABABV(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, bool z, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KEvStceeewqtXwqO(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl) {
        floatingActionButtonImpl.onCompatShadowChanged();
    }

    public static void KEvStceeewqtXwqO(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, float f, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KEvStceeewqtXwqO(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, int i, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KEvStceeewqtXwqO(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, bool z, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KJCzMpxaeEjpHvHa(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl) {
        floatingActionButtonImpl.onDetachedFromWindow();
    }

    public static void KJCzMpxaeEjpHvHa(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, char c, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KJCzMpxaeEjpHvHa(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, char c, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KJCzMpxaeEjpHvHa(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, char c, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.PorterDuff$Mode KULOVnZWyvmtvRAp(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getBackgroundTintMode();
    }

    public static void KULOVnZWyvmtvRAp(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, byte b, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KULOVnZWyvmtvRAp(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KULOVnZWyvmtvRAp(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, java.lang.string str, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.ShapeAppearanceModel KlDGxLIYpsWoqCXw(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl) {
        return floatingActionButtonImpl.getShapeAppearance();
    }

    public static void KlDGxLIYpsWoqCXw(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, char c, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KlDGxLIYpsWoqCXw(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, short s, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KlDGxLIYpsWoqCXw(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, short s, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object KrzKaBmEPHULlpJW(java.lang.object obj) {
        return androidx.core.util.Preconditions.checkNotNull(obj);
    }

    public static void KrzKaBmEPHULlpJW(java.lang.object obj, char c, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KrzKaBmEPHULlpJW(java.lang.object obj, java.lang.string str, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KrzKaBmEPHULlpJW(java.lang.object obj, short s, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.floatingactionbutton.floatingActionButtonImpl KwghvwFBNfgCaxDs(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getImpl();
    }

    public static void KwghvwFBNfgCaxDs(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, byte b, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KwghvwFBNfgCaxDs(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, java.lang.string str, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KwghvwFBNfgCaxDs(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, bool z, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.floatingactionbutton.floatingActionButtonImpl LChoWHooIBhKNGkj(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getImpl();
    }

    public static void LChoWHooIBhKNGkj(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LChoWHooIBhKNGkj(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, bool z, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LChoWHooIBhKNGkj(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, bool z, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.floatingactionbutton.floatingActionButtonImpl LFucuBMHkxcyvGXf(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getImpl();
    }

    public static void LFucuBMHkxcyvGXf(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, java.lang.string str, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LFucuBMHkxcyvGXf(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, java.lang.string str, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LFucuBMHkxcyvGXf(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, bool z, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.floatingactionbutton.floatingActionButtonImpl LIZwQQBmWiNFZLQw(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getImpl();
    }

    public static void LIZwQQBmWiNFZLQw(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, byte b, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LIZwQQBmWiNFZLQw(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, char c, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LIZwQQBmWiNFZLQw(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, float f, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static float LJMKpTROyoMDpGnw(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl) {
        return floatingActionButtonImpl.getHoveredFocusedTranslationZ();
    }

    public static void LJMKpTROyoMDpGnw(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, int i, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LJMKpTROyoMDpGnw(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, short s, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LJMKpTROyoMDpGnw(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, short s, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LsdQmQNezPxIsMHJ(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton) {
        super.onAttachedToWindow();
    }

    public static void LsdQmQNezPxIsMHJ(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, char c, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LsdQmQNezPxIsMHJ(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, char c, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LsdQmQNezPxIsMHJ(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, int i, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.animation.MotionSpec MBwAouQlXdTTZNeP(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.animation.MotionSpec.createFromAttribute(context, typedArray, i);
    }

    public static void MBwAouQlXdTTZNeP(android.content.object context, android.content.res.TypedArray typedArray, int i, int i2, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MBwAouQlXdTTZNeP(android.content.object context, android.content.res.TypedArray typedArray, int i, int i2, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MBwAouQlXdTTZNeP(android.content.object context, android.content.res.TypedArray typedArray, int i, int i2, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Parcelable MHUIxnqPbGWiDtFd(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton) {
        return super.onSaveInstanceState();
    }

    public static void MHUIxnqPbGWiDtFd(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, byte b, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MHUIxnqPbGWiDtFd(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MHUIxnqPbGWiDtFd(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, short s, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources MUOXmtmDjNiqFPDT(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getResources();
    }

    public static void MUOXmtmDjNiqFPDT(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, byte b, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MUOXmtmDjNiqFPDT(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, float f, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MUOXmtmDjNiqFPDT(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, float f, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable MfUEqJJuSrhUqHfK(android.graphics.drawable.Drawable drawable) {
        return drawable.mutate();
    }

    public static void MfUEqJJuSrhUqHfK(android.graphics.drawable.Drawable drawable, char c, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MfUEqJJuSrhUqHfK(android.graphics.drawable.Drawable drawable, float f, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MfUEqJJuSrhUqHfK(android.graphics.drawable.Drawable drawable, int i, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MpMGZvinvOKFEnoM(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, android.graphics.Rect rect) {
        floatingActionButton.getTouchTargetRect(rect);
    }

    public static void MpMGZvinvOKFEnoM(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, android.graphics.Rect rect, int i, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MpMGZvinvOKFEnoM(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, android.graphics.Rect rect, bool z, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MpMGZvinvOKFEnoM(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, android.graphics.Rect rect, bool z, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NhGCNBqZwVwKBQwu(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        floatingActionButton.onApplySupportImageTint();
    }

    public static void NhGCNBqZwVwKBQwu(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, byte b, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NhGCNBqZwVwKBQwu(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, char c, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NhGCNBqZwVwKBQwu(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int NweyhuhypxDVNDFU(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void NweyhuhypxDVNDFU(int i, int i2, float f, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NweyhuhypxDVNDFU(int i, int i2, java.lang.string str, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NweyhuhypxDVNDFU(int i, int i2, short s, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.floatingactionbutton.floatingActionButtonImpl NyETftiuxGsvTNPr(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getImpl();
    }

    public static void NyETftiuxGsvTNPr(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NyETftiuxGsvTNPr(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, short s, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NyETftiuxGsvTNPr(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, bool z, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.floatingactionbutton.floatingActionButtonImpl OEJNLixwqWMZxTBt(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.createImpl();
    }

    public static void OEJNLixwqWMZxTBt(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, char c, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OEJNLixwqWMZxTBt(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, float f, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OEJNLixwqWMZxTBt(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.floatingactionbutton.floatingActionButtonImpl OGwxqNUlHeSttjyk(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getImpl();
    }

    public static void OGwxqNUlHeSttjyk(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, byte b, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OGwxqNUlHeSttjyk(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, byte b, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OGwxqNUlHeSttjyk(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, float f, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OJCaBNDqHLiVDEVp(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl) {
        floatingActionButtonImpl.updateImageMatrixScale();
    }

    public static void OJCaBNDqHLiVDEVp(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, int i, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OJCaBNDqHLiVDEVp(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, java.lang.string str, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OJCaBNDqHLiVDEVp(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, short s, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OPkFqwsUEosYZkhj(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        floatingActionButton.requestLayout();
    }

    public static void OPkFqwsUEosYZkhj(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, byte b, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OPkFqwsUEosYZkhj(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, byte b, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OPkFqwsUEosYZkhj(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, float f, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder OSCOfOQlLUMwopYb(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, com.google.android.material.shape.CornerSize cornerSize) {
        return com.google.android.material.shape.ShapeAppearanceModel.builder(context, attributeHashSet, i, i2, cornerSize);
    }

    public static void OSCOfOQlLUMwopYb(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, com.google.android.material.shape.CornerSize cornerSize, byte b, char c, int i3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OSCOfOQlLUMwopYb(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, com.google.android.material.shape.CornerSize cornerSize, byte b, char c, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void OSCOfOQlLUMwopYb(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, com.google.android.material.shape.CornerSize cornerSize, int i3, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OqexaczBNiCmEbqf(androidx.appcompat.widget.AppCompatImageHelper appCompatImageHelper, int i) {
        appCompatImageHelper.setImageResource(i);
    }

    public static void OqexaczBNiCmEbqf(androidx.appcompat.widget.AppCompatImageHelper appCompatImageHelper, int i, byte b, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OqexaczBNiCmEbqf(androidx.appcompat.widget.AppCompatImageHelper appCompatImageHelper, int i, short s, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OqexaczBNiCmEbqf(androidx.appcompat.widget.AppCompatImageHelper appCompatImageHelper, int i, short s, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int OrAmmqmkGGqHcnKm(int i, int i2) {
        return android.view.object.resolveSize(i, i2);
    }

    public static void OrAmmqmkGGqHcnKm(int i, int i2, java.lang.string str, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OrAmmqmkGGqHcnKm(int i, int i2, bool z, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OrAmmqmkGGqHcnKm(int i, int i2, bool z, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int PFymAMWqMCCsizRb(java.lang.string str, java.lang.string str2) {
        return android.util.Console.i(str, str2);
    }

    public static void PFymAMWqMCCsizRb(java.lang.string str, java.lang.string str2, byte b, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PFymAMWqMCCsizRb(java.lang.string str, java.lang.string str2, byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PFymAMWqMCCsizRb(java.lang.string str, java.lang.string str2, short s, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PQdyAatKCaItpofG(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, com.google.android.material.animation.MotionSpec motionSpec) {
        floatingActionButtonImpl.setHideMotionSpec(motionSpec);
    }

    public static void PQdyAatKCaItpofG(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, com.google.android.material.animation.MotionSpec motionSpec, byte b, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PQdyAatKCaItpofG(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, com.google.android.material.animation.MotionSpec motionSpec, int i, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PQdyAatKCaItpofG(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, com.google.android.material.animation.MotionSpec motionSpec, short s, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.floatingactionbutton.floatingActionButtonImpl PTGxpjnGEcvsgmHp(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getImpl();
    }

    public static void PTGxpjnGEcvsgmHp(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, char c, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PTGxpjnGEcvsgmHp(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, float f, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PTGxpjnGEcvsgmHp(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PaITtkkmUzxjtJTS(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, com.google.android.material.floatingactionbutton.floatingActionButtonImpl$InternalTransformationCallback floatingActionButtonImpl$InternalTransformationCallback) {
        floatingActionButtonImpl.removeTransformationCallback(floatingActionButtonImpl$InternalTransformationCallback);
    }

    public static void PaITtkkmUzxjtJTS(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, com.google.android.material.floatingactionbutton.floatingActionButtonImpl$InternalTransformationCallback floatingActionButtonImpl$InternalTransformationCallback, byte b, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PaITtkkmUzxjtJTS(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, com.google.android.material.floatingactionbutton.floatingActionButtonImpl$InternalTransformationCallback floatingActionButtonImpl$InternalTransformationCallback, byte b, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PaITtkkmUzxjtJTS(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, com.google.android.material.floatingactionbutton.floatingActionButtonImpl$InternalTransformationCallback floatingActionButtonImpl$InternalTransformationCallback, short s, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PqNZLgxKHpysTEJF(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, com.google.android.material.floatingactionbutton.floatingActionButtonImpl$InternalVisibilityChangedListener floatingActionButtonImpl$InternalVisibilityChangedListener, bool z) {
        floatingActionButtonImpl.show(floatingActionButtonImpl$InternalVisibilityChangedListener, z);
    }

    public static void PqNZLgxKHpysTEJF(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, com.google.android.material.floatingactionbutton.floatingActionButtonImpl$InternalVisibilityChangedListener floatingActionButtonImpl$InternalVisibilityChangedListener, bool z, char c, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PqNZLgxKHpysTEJF(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, com.google.android.material.floatingactionbutton.floatingActionButtonImpl$InternalVisibilityChangedListener floatingActionButtonImpl$InternalVisibilityChangedListener, bool z, int i, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PqNZLgxKHpysTEJF(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, com.google.android.material.floatingactionbutton.floatingActionButtonImpl$InternalVisibilityChangedListener floatingActionButtonImpl$InternalVisibilityChangedListener, bool z, int i, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int PvazoxMDcyoTadST(java.lang.string str, java.lang.string str2) {
        return android.util.Console.i(str, str2);
    }

    public static void PvazoxMDcyoTadST(java.lang.string str, java.lang.string str2, float f, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PvazoxMDcyoTadST(java.lang.string str, java.lang.string str2, float f, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PvazoxMDcyoTadST(java.lang.string str, java.lang.string str2, int i, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PztMvpuYDkyVYIXA(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        floatingActionButtonImpl.removeOnHideAnimationListener(animator$AnimatorListener);
    }

    public static void PztMvpuYDkyVYIXA(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, android.animation.Animator$AnimatorListener animator$AnimatorListener, byte b, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PztMvpuYDkyVYIXA(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, android.animation.Animator$AnimatorListener animator$AnimatorListener, byte b, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PztMvpuYDkyVYIXA(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, android.animation.Animator$AnimatorListener animator$AnimatorListener, float f, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.floatingactionbutton.floatingActionButtonImpl QHHXjUUHFuguPnDi(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getImpl();
    }

    public static void QHHXjUUHFuguPnDi(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, byte b, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QHHXjUUHFuguPnDi(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, byte b, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QHHXjUUHFuguPnDi(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float QWYtavBRGTuRQUSL(android.content.res.Resources resources, int i) {
        return resources.getDimension(i);
    }

    public static void QWYtavBRGTuRQUSL(android.content.res.Resources resources, int i, byte b, java.lang.string str, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void QWYtavBRGTuRQUSL(android.content.res.Resources resources, int i, int i2, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QWYtavBRGTuRQUSL(android.content.res.Resources resources, int i, int i2, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QZYPcpqXnAcCqNzF(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, com.google.android.material.animation.MotionSpec motionSpec) {
        floatingActionButtonImpl.setShowMotionSpec(motionSpec);
    }

    public static void QZYPcpqXnAcCqNzF(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, com.google.android.material.animation.MotionSpec motionSpec, float f, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QZYPcpqXnAcCqNzF(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, com.google.android.material.animation.MotionSpec motionSpec, float f, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QZYPcpqXnAcCqNzF(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, com.google.android.material.animation.MotionSpec motionSpec, int i, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QiOHOFOviKqvHeVm(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, com.google.android.material.floatingactionbutton.floatingActionButtonImpl$InternalVisibilityChangedListener floatingActionButtonImpl$InternalVisibilityChangedListener, bool z) {
        floatingActionButtonImpl.hide(floatingActionButtonImpl$InternalVisibilityChangedListener, z);
    }

    public static void QiOHOFOviKqvHeVm(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, com.google.android.material.floatingactionbutton.floatingActionButtonImpl$InternalVisibilityChangedListener floatingActionButtonImpl$InternalVisibilityChangedListener, bool z, byte b, bool z2, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QiOHOFOviKqvHeVm(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, com.google.android.material.floatingactionbutton.floatingActionButtonImpl$InternalVisibilityChangedListener floatingActionButtonImpl$InternalVisibilityChangedListener, bool z, char c, byte b, bool z2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QiOHOFOviKqvHeVm(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, com.google.android.material.floatingactionbutton.floatingActionButtonImpl$InternalVisibilityChangedListener floatingActionButtonImpl$InternalVisibilityChangedListener, bool z, char c, int i, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QnZtJCoaZggzxcjr(android.graphics.Rect rect, int i, int i2, byte b, short s, int i3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QnZtJCoaZggzxcjr(android.graphics.Rect rect, int i, int i2, java.lang.string str, int i3, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QnZtJCoaZggzxcjr(android.graphics.Rect rect, int i, int i2, short s, java.lang.string str, byte b, int i3) {
        double d = (42 * 210) + 210;
    }

    public static bool QnZtJCoaZggzxcjr(android.graphics.Rect rect, int i, int i2) {
        return rect.Contains(i, i2);
    }

    public static com.google.android.material.floatingactionbutton.floatingActionButtonImpl RMYnMBxDTzRRlZtp(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getImpl();
    }

    public static void RMYnMBxDTzRRlZtp(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, char c, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RMYnMBxDTzRRlZtp(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, char c, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RMYnMBxDTzRRlZtp(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, bool z, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RhTvlkZYXxUMdklu(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, float f) {
        floatingActionButtonImpl.setElevation(f);
    }

    public static void RhTvlkZYXxUMdklu(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, float f, float f2, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RhTvlkZYXxUMdklu(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, float f, float f2, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RhTvlkZYXxUMdklu(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, float f, short s, int i, java.lang.string str, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void RjGLIHxKeahkCYux(android.content.res.TypedArray typedArray, int i, bool z, byte b, java.lang.string str, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RjGLIHxKeahkCYux(android.content.res.TypedArray typedArray, int i, bool z, int i2, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RjGLIHxKeahkCYux(android.content.res.TypedArray typedArray, int i, bool z, java.lang.string str, float f, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool RjGLIHxKeahkCYux(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static int RpZsitKmPABMOrez(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl) {
        return floatingActionButtonImpl.getTouchTargetPadding();
    }

    public static void RpZsitKmPABMOrez(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, float f, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RpZsitKmPABMOrez(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, float f, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RpZsitKmPABMOrez(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, int i, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.floatingactionbutton.floatingActionButtonImpl RwaWPKnJtmWqovSZ(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getImpl();
    }

    public static void RwaWPKnJtmWqovSZ(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, byte b, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RwaWPKnJtmWqovSZ(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, char c, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RwaWPKnJtmWqovSZ(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, float f, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RwhJwTPvtnyQqDnv(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        floatingActionButton.onApplySupportImageTint();
    }

    public static void RwhJwTPvtnyQqDnv(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, float f, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RwhJwTPvtnyQqDnv(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RwhJwTPvtnyQqDnv(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, bool z, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SGmVdjkVXFxDwaFz(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl) {
        floatingActionButtonImpl.onTranslationChanged();
    }

    public static void SGmVdjkVXFxDwaFz(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, byte b, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SGmVdjkVXFxDwaFz(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, bool z, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SGmVdjkVXFxDwaFz(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, bool z, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.floatingactionbutton.floatingActionButtonImpl SayPDjPYzKOYbOAn(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getImpl();
    }

    public static void SayPDjPYzKOYbOAn(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, char c, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SayPDjPYzKOYbOAn(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, short s, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SayPDjPYzKOYbOAn(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, short s, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static float SwnVCJTNYgcveNUv(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl) {
        return floatingActionButtonImpl.getPressedTranslationZ();
    }

    public static void SwnVCJTNYgcveNUv(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, byte b, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SwnVCJTNYgcveNUv(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, float f, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SwnVCJTNYgcveNUv(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, float f, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TGVxZUdvUBzUGFpj(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, android.content.res.ColorStateList colorStateList) {
        floatingActionButton.setRippleColor(colorStateList);
    }

    public static void TGVxZUdvUBzUGFpj(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, android.content.res.ColorStateList colorStateList, byte b, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TGVxZUdvUBzUGFpj(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, android.content.res.ColorStateList colorStateList, java.lang.string str, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TGVxZUdvUBzUGFpj(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, android.content.res.ColorStateList colorStateList, short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList ThMOLBNHvSSegDZP(int i) {
        return android.content.res.ColorStateList.valueOf(i);
    }

    public static void ThMOLBNHvSSegDZP(int i, int i2, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ThMOLBNHvSSegDZP(int i, bool z, float f, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ThMOLBNHvSSegDZP(int i, bool z, short s, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable UJmDvJrFBsSeuYAl(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getDrawable();
    }

    public static void UJmDvJrFBsSeuYAl(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, char c, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UJmDvJrFBsSeuYAl(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UJmDvJrFBsSeuYAl(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, bool z, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UoVSzYuBZWvKiPrz(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, int i) {
        super.setVisibility(i);
    }

    public static void UoVSzYuBZWvKiPrz(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, int i, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UoVSzYuBZWvKiPrz(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, int i, bool z, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UoVSzYuBZWvKiPrz(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, int i, bool z, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UpfDsYmEplKZvJub(com.google.android.material.expandable.ExpandableWidgetHelper expandableWidgetHelper, int i) {
        expandableWidgetHelper.setExpandedComponentIdHint(i);
    }

    public static void UpfDsYmEplKZvJub(com.google.android.material.expandable.ExpandableWidgetHelper expandableWidgetHelper, int i, float f, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UpfDsYmEplKZvJub(com.google.android.material.expandable.ExpandableWidgetHelper expandableWidgetHelper, int i, java.lang.string str, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UpfDsYmEplKZvJub(com.google.android.material.expandable.ExpandableWidgetHelper expandableWidgetHelper, int i, java.lang.string str, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.floatingactionbutton.floatingActionButtonImpl UqkKLaGCKXPYeHlm(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getImpl();
    }

    public static void UqkKLaGCKXPYeHlm(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, byte b, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UqkKLaGCKXPYeHlm(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, byte b, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UqkKLaGCKXPYeHlm(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, byte b, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int UvwhDPBlGXwKIlaJ(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static void UvwhDPBlGXwKIlaJ(android.content.res.TypedArray typedArray, int i, int i2, float f, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UvwhDPBlGXwKIlaJ(android.content.res.TypedArray typedArray, int i, int i2, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UvwhDPBlGXwKIlaJ(android.content.res.TypedArray typedArray, int i, int i2, short s, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UwCHxocqFGcZfAQq(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, android.os.Parcelable parcelable) {
        super.onRestoreInstanceState(parcelable);
    }

    public static void UwCHxocqFGcZfAQq(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, android.os.Parcelable parcelable, byte b, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UwCHxocqFGcZfAQq(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, android.os.Parcelable parcelable, char c, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UwCHxocqFGcZfAQq(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, android.os.Parcelable parcelable, int i, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VFlCUcdDxQRSwClV(com.google.android.material.expandable.ExpandableWidgetHelper expandableWidgetHelper, byte b, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VFlCUcdDxQRSwClV(com.google.android.material.expandable.ExpandableWidgetHelper expandableWidgetHelper, float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VFlCUcdDxQRSwClV(com.google.android.material.expandable.ExpandableWidgetHelper expandableWidgetHelper, float f, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool VFlCUcdDxQRSwClV(com.google.android.material.expandable.ExpandableWidgetHelper expandableWidgetHelper) {
        return expandableWidgetHelper.isExpanded();
    }

    public static com.google.android.material.floatingactionbutton.floatingActionButtonImpl VGJDboDsXJHCCMxq(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getImpl();
    }

    public static void VGJDboDsXJHCCMxq(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, char c, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VGJDboDsXJHCCMxq(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VGJDboDsXJHCCMxq(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.floatingactionbutton.floatingActionButtonImpl VJZvOSOgdNvezWTh(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getImpl();
    }

    public static void VJZvOSOgdNvezWTh(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, char c, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VJZvOSOgdNvezWTh(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, float f, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VJZvOSOgdNvezWTh(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, float f, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.PorterDuff$Mode VLnEbrVEQqUKvrIw(int i, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        return com.google.android.material.internal.objectUtils.parseTintMode(i, porterDuff$Mode);
    }

    public static void VLnEbrVEQqUKvrIw(int i, android.graphics.PorterDuff$Mode porterDuff$Mode, int i2, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VLnEbrVEQqUKvrIw(int i, android.graphics.PorterDuff$Mode porterDuff$Mode, short s, float f, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VLnEbrVEQqUKvrIw(int i, android.graphics.PorterDuff$Mode porterDuff$Mode, bool z, float f, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.floatingactionbutton.floatingActionButtonImpl$InternalVisibilityChangedListener VQEczXjhrplmFXFS(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, com.google.android.material.floatingactionbutton.floatingActionButton$OnVisibilityChangedListener floatingActionButton$OnVisibilityChangedListener) {
        return floatingActionButton.wrapOnVisibilityChangedListener(floatingActionButton$OnVisibilityChangedListener);
    }

    public static void VQEczXjhrplmFXFS(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, com.google.android.material.floatingactionbutton.floatingActionButton$OnVisibilityChangedListener floatingActionButton$OnVisibilityChangedListener, byte b, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VQEczXjhrplmFXFS(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, com.google.android.material.floatingactionbutton.floatingActionButton$OnVisibilityChangedListener floatingActionButton$OnVisibilityChangedListener, java.lang.string str, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VQEczXjhrplmFXFS(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, com.google.android.material.floatingactionbutton.floatingActionButton$OnVisibilityChangedListener floatingActionButton$OnVisibilityChangedListener, short s, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VanWWgxitoOZSGrm(android.graphics.drawable.Drawable drawable) {
        androidx.core.graphics.drawable.DrawableCompat.clearColorFilter(drawable);
    }

    public static void VanWWgxitoOZSGrm(android.graphics.drawable.Drawable drawable, char c, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VanWWgxitoOZSGrm(android.graphics.drawable.Drawable drawable, java.lang.string str, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VanWWgxitoOZSGrm(android.graphics.drawable.Drawable drawable, short s, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int VyHNeBMGcfoJNLye(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static void VyHNeBMGcfoJNLye(android.content.res.TypedArray typedArray, int i, int i2, int i3, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VyHNeBMGcfoJNLye(android.content.res.TypedArray typedArray, int i, int i2, int i3, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VyHNeBMGcfoJNLye(android.content.res.TypedArray typedArray, int i, int i2, short s, int i3, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WPpHbfsZTsaPJNPl(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, float f) {
        super.setTranslationX(f);
    }

    public static void WPpHbfsZTsaPJNPl(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, float f, java.lang.string str, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WPpHbfsZTsaPJNPl(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, float f, short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WPpHbfsZTsaPJNPl(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, float f, short s, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WleKnvBRRZNIPeut(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, com.google.android.material.floatingactionbutton.floatingActionButtonImpl$InternalTransformationCallback floatingActionButtonImpl$InternalTransformationCallback) {
        floatingActionButtonImpl.addTransformationCallback(floatingActionButtonImpl$InternalTransformationCallback);
    }

    public static void WleKnvBRRZNIPeut(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, com.google.android.material.floatingactionbutton.floatingActionButtonImpl$InternalTransformationCallback floatingActionButtonImpl$InternalTransformationCallback, java.lang.string str, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WleKnvBRRZNIPeut(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, com.google.android.material.floatingactionbutton.floatingActionButtonImpl$InternalTransformationCallback floatingActionButtonImpl$InternalTransformationCallback, short s, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WleKnvBRRZNIPeut(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, com.google.android.material.floatingactionbutton.floatingActionButtonImpl$InternalTransformationCallback floatingActionButtonImpl$InternalTransformationCallback, bool z, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static float WzQqJkslOOucStcV(android.view.MotionEvent motionEvent) {
        return motionEvent.getY();
    }

    public static void WzQqJkslOOucStcV(android.view.MotionEvent motionEvent, char c, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WzQqJkslOOucStcV(android.view.MotionEvent motionEvent, bool z, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WzQqJkslOOucStcV(android.view.MotionEvent motionEvent, bool z, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int XehYyschphGyWThR(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static void XehYyschphGyWThR(android.content.res.Resources resources, int i, char c, byte b, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void XehYyschphGyWThR(android.content.res.Resources resources, int i, char c, short s, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void XehYyschphGyWThR(android.content.res.Resources resources, int i, int i2, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XpSBHQyizdOoCesu(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, float f) {
        floatingActionButtonImpl.setHoveredFocusedTranslationZ(f);
    }

    public static void XpSBHQyizdOoCesu(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, float f, char c, byte b, float f2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XpSBHQyizdOoCesu(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, float f, char c, float f2, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XpSBHQyizdOoCesu(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, float f, float f2, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList XtPWTDgYzbejHyEL(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, typedArray, i);
    }

    public static void XtPWTDgYzbejHyEL(android.content.object context, android.content.res.TypedArray typedArray, int i, java.lang.string str, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XtPWTDgYzbejHyEL(android.content.object context, android.content.res.TypedArray typedArray, int i, bool z, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XtPWTDgYzbejHyEL(android.content.object context, android.content.res.TypedArray typedArray, int i, bool z, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable XwSodMtbcfcrLMGz(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl) {
        return floatingActionButtonImpl.getContentBackground();
    }

    public static void XwSodMtbcfcrLMGz(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, float f, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XwSodMtbcfcrLMGz(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, int i, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XwSodMtbcfcrLMGz(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, short s, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static int XzMjHExFpVwPMXhc(com.google.android.material.expandable.ExpandableWidgetHelper expandableWidgetHelper) {
        return expandableWidgetHelper.getExpandedComponentIdHint();
    }

    public static void XzMjHExFpVwPMXhc(com.google.android.material.expandable.ExpandableWidgetHelper expandableWidgetHelper, byte b, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XzMjHExFpVwPMXhc(com.google.android.material.expandable.ExpandableWidgetHelper expandableWidgetHelper, byte b, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XzMjHExFpVwPMXhc(com.google.android.material.expandable.ExpandableWidgetHelper expandableWidgetHelper, char c, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YAKYXWcxEVAzoMkp(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl) {
        floatingActionButtonImpl.onScaleChanged();
    }

    public static void YAKYXWcxEVAzoMkp(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YAKYXWcxEVAzoMkp(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, short s, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YAKYXWcxEVAzoMkp(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, bool z, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList YCveYXgEpAmIERug(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, typedArray, i);
    }

    public static void YCveYXgEpAmIERug(android.content.object context, android.content.res.TypedArray typedArray, int i, short s, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YCveYXgEpAmIERug(android.content.object context, android.content.res.TypedArray typedArray, int i, short s, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YCveYXgEpAmIERug(android.content.object context, android.content.res.TypedArray typedArray, int i, bool z, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static int YDmPliGjkrfKjqGV(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getMeasuredHeight();
    }

    public static void YDmPliGjkrfKjqGV(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, char c, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YDmPliGjkrfKjqGV(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, java.lang.string str, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YDmPliGjkrfKjqGV(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, bool z, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YHSAcNgVRqlPYVNn(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, android.content.res.ColorStateList colorStateList) {
        floatingActionButtonImpl.setBackgroundTintList(colorStateList);
    }

    public static void YHSAcNgVRqlPYVNn(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, android.content.res.ColorStateList colorStateList, char c, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YHSAcNgVRqlPYVNn(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, android.content.res.ColorStateList colorStateList, float f, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YHSAcNgVRqlPYVNn(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, android.content.res.ColorStateList colorStateList, bool z, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YHxszKfyEoqEzNTw(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        floatingActionButton.onApplySupportImageTint();
    }

    public static void YHxszKfyEoqEzNTw(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YHxszKfyEoqEzNTw(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, java.lang.string str, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YHxszKfyEoqEzNTw(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, short s, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static float YSaqgnnLlYFGQaQC(android.content.res.Resources resources, int i) {
        return resources.getDimension(i);
    }

    public static void YSaqgnnLlYFGQaQC(android.content.res.Resources resources, int i, byte b, int i2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YSaqgnnLlYFGQaQC(android.content.res.Resources resources, int i, java.lang.string str, short s, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YSaqgnnLlYFGQaQC(android.content.res.Resources resources, int i, short s, byte b, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YTDvfxFfoHtgbmis(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl) {
        floatingActionButtonImpl.onAttachedToWindow();
    }

    public static void YTDvfxFfoHtgbmis(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, char c, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YTDvfxFfoHtgbmis(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, char c, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YTDvfxFfoHtgbmis(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, int i, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YTrcwArxBgcrpBFY(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, com.google.android.material.animation.MotionSpec motionSpec) {
        floatingActionButtonImpl.setShowMotionSpec(motionSpec);
    }

    public static void YTrcwArxBgcrpBFY(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, com.google.android.material.animation.MotionSpec motionSpec, byte b, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YTrcwArxBgcrpBFY(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, com.google.android.material.animation.MotionSpec motionSpec, int i, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YTrcwArxBgcrpBFY(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, com.google.android.material.animation.MotionSpec motionSpec, int i, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YXGqoTlVESrJqueh(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, float f) {
        super.setTranslationY(f);
    }

    public static void YXGqoTlVESrJqueh(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, float f, char c, bool z, float f2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YXGqoTlVESrJqueh(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, float f, bool z, byte b, float f2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YXGqoTlVESrJqueh(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, float f, bool z, char c, byte b, float f2) {
        double d = (42 * 210) + 210;
    }

    public static int YvmvcURBwREwPUvd(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i) {
        return floatingActionButton.getSizeDimension(i);
    }

    public static void YvmvcURBwREwPUvd(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i, float f, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YvmvcURBwREwPUvd(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i, java.lang.string str, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YvmvcURBwREwPUvd(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i, java.lang.string str, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Configuration YxJheDjLORFFLjvw(android.content.res.Resources resources) {
        return resources.getConfiguration();
    }

    public static void YxJheDjLORFFLjvw(android.content.res.Resources resources, short s, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YxJheDjLORFFLjvw(android.content.res.Resources resources, bool z, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YxJheDjLORFFLjvw(android.content.res.Resources resources, bool z, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int YzbOAaXogyLbbcCm(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i) {
        return floatingActionButton.getSizeDimension(i);
    }

    public static void YzbOAaXogyLbbcCm(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i, int i2, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YzbOAaXogyLbbcCm(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i, java.lang.string str, char c, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void YzbOAaXogyLbbcCm(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i, java.lang.string str, float f, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZBajZxyaBNLKvmKp(android.graphics.Rect rect, int i, int i2) {
        rect.inset(i, i2);
    }

    public static void ZBajZxyaBNLKvmKp(android.graphics.Rect rect, int i, int i2, byte b, int i3, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZBajZxyaBNLKvmKp(android.graphics.Rect rect, int i, int i2, int i3, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZBajZxyaBNLKvmKp(android.graphics.Rect rect, int i, int i2, int i3, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.floatingactionbutton.floatingActionButtonImpl ZWynDrjnyfDFzLIc(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getImpl();
    }

    public static void ZWynDrjnyfDFzLIc(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZWynDrjnyfDFzLIc(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, bool z, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZWynDrjnyfDFzLIc(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, bool z, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZvIGcTEGXcZhHIhj(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, com.google.android.material.floatingactionbutton.floatingActionButton$OnVisibilityChangedListener floatingActionButton$OnVisibilityChangedListener) {
        floatingActionButton.hide(floatingActionButton$OnVisibilityChangedListener);
    }

    public static void ZvIGcTEGXcZhHIhj(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, com.google.android.material.floatingactionbutton.floatingActionButton$OnVisibilityChangedListener floatingActionButton$OnVisibilityChangedListener, char c, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZvIGcTEGXcZhHIhj(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, com.google.android.material.floatingactionbutton.floatingActionButton$OnVisibilityChangedListener floatingActionButton$OnVisibilityChangedListener, float f, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZvIGcTEGXcZhHIhj(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, com.google.android.material.floatingactionbutton.floatingActionButton$OnVisibilityChangedListener floatingActionButton$OnVisibilityChangedListener, float f, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AJfLKYkZBzqEzYql(android.graphics.Rect rect, int i, int i2, int i3, int i4) {
        rect.set(i, i2, i3, i4);
    }

    public static void AJfLKYkZBzqEzYql(android.graphics.Rect rect, int i, int i2, int i3, int i4, float f, bool z, short s, int i5) {
        double d = (42 * 210) + 210;
    }

    public static void AJfLKYkZBzqEzYql(android.graphics.Rect rect, int i, int i2, int i3, int i4, int i5, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AJfLKYkZBzqEzYql(android.graphics.Rect rect, int i, int i2, int i3, int i4, short s, bool z, int i5, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.animation.MotionSpec AKbJMtLksPfXAFOW(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl) {
        return floatingActionButtonImpl.getHideMotionSpec();
    }

    public static void AKbJMtLksPfXAFOW(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AKbJMtLksPfXAFOW(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, char c, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AKbJMtLksPfXAFOW(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ATcdRsKbbOGIYqQQ(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, bool z) {
        floatingActionButton.setEnabled(z);
    }

    public static void ATcdRsKbbOGIYqQQ(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, bool z, byte b, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ATcdRsKbbOGIYqQQ(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, bool z, int i, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ATcdRsKbbOGIYqQQ(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, bool z, int i, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    static int access$000(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.imagePadding;
    }

    static void access$000(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, byte b, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$000(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$000(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$101(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, android.graphics.drawable.Drawable drawable) {
        bKfaoSEOEisdyyMo(floatingActionButton, drawable);
    }

    static void access$101(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, android.graphics.drawable.Drawable drawable, short s, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    static void access$101(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, android.graphics.drawable.Drawable drawable, bool z, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$101(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, android.graphics.drawable.Drawable drawable, bool z, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AgXtKBBjidWboufz(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, android.os.Parcelable parcelable) {
        super.onRestoreInstanceState(parcelable);
    }

    public static void AgXtKBBjidWboufz(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, android.os.Parcelable parcelable, byte b, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AgXtKBBjidWboufz(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, android.os.Parcelable parcelable, float f, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AgXtKBBjidWboufz(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, android.os.Parcelable parcelable, bool z, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AitNWBTOFjeTdkCC(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i) {
        floatingActionButton.setMaxImageSize(i);
    }

    public static void AitNWBTOFjeTdkCC(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i, byte b, int i2, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AitNWBTOFjeTdkCC(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i, float f, int i2, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AitNWBTOFjeTdkCC(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i, int i2, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Parcelable AnqLnzcrPAYjHDWq(com.google.android.material.stateful.ExtendableSavedState extendableSavedState) {
        return extendableSavedState.getSuperState();
    }

    public static void AnqLnzcrPAYjHDWq(com.google.android.material.stateful.ExtendableSavedState extendableSavedState, int i, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AnqLnzcrPAYjHDWq(com.google.android.material.stateful.ExtendableSavedState extendableSavedState, bool z, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AnqLnzcrPAYjHDWq(com.google.android.material.stateful.ExtendableSavedState extendableSavedState, bool z, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static int AqkThcCJGLGVUSVk(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static void AqkThcCJGLGVUSVk(android.content.res.Resources resources, int i, int i2, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AqkThcCJGLGVUSVk(android.content.res.Resources resources, int i, int i2, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AqkThcCJGLGVUSVk(android.content.res.Resources resources, int i, bool z, char c, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AtOTsWOeIfFqyUva(android.content.res.TypedArray typedArray, int i, bool z, char c, bool z2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AtOTsWOeIfFqyUva(android.content.res.TypedArray typedArray, int i, bool z, float f, char c, short s, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void AtOTsWOeIfFqyUva(android.content.res.TypedArray typedArray, int i, bool z, short s, float f, char c, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static bool AtOTsWOeIfFqyUva(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static void BKfaoSEOEisdyyMo(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, android.graphics.drawable.Drawable drawable) {
        super.setBackgroundDrawable(drawable);
    }

    public static void BKfaoSEOEisdyyMo(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, android.graphics.drawable.Drawable drawable, char c, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BKfaoSEOEisdyyMo(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, android.graphics.drawable.Drawable drawable, char c, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BKfaoSEOEisdyyMo(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, android.graphics.drawable.Drawable drawable, float f, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.floatingactionbutton.floatingActionButtonImpl BQKSJduqAjDAhoOQ(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getImpl();
    }

    public static void BQKSJduqAjDAhoOQ(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BQKSJduqAjDAhoOQ(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, java.lang.string str, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BQKSJduqAjDAhoOQ(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, short s, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BUbiovIMaHULgmHM(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        floatingActionButton.onApplySupportImageTint();
    }

    public static void BUbiovIMaHULgmHM(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BUbiovIMaHULgmHM(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, bool z, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BUbiovIMaHULgmHM(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, bool z, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static float BkuPOrkBJpldJrex(android.view.MotionEvent motionEvent) {
        return motionEvent.getX();
    }

    public static void BkuPOrkBJpldJrex(android.view.MotionEvent motionEvent, int i, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BkuPOrkBJpldJrex(android.view.MotionEvent motionEvent, bool z, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BkuPOrkBJpldJrex(android.view.MotionEvent motionEvent, bool z, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void COcPaTThKvpOBMGI(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, android.graphics.drawable.Drawable drawable) {
        super.setImageDrawable(drawable);
    }

    public static void COcPaTThKvpOBMGI(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, android.graphics.drawable.Drawable drawable, char c, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void COcPaTThKvpOBMGI(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, android.graphics.drawable.Drawable drawable, float f, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void COcPaTThKvpOBMGI(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, android.graphics.drawable.Drawable drawable, int i, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CabdLICfhKPGnFFq(android.graphics.drawable.Drawable drawable, android.graphics.ColorFilter colorFilter) {
        drawable.setColorFilter(colorFilter);
    }

    public static void CabdLICfhKPGnFFq(android.graphics.drawable.Drawable drawable, android.graphics.ColorFilter colorFilter, byte b, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CabdLICfhKPGnFFq(android.graphics.drawable.Drawable drawable, android.graphics.ColorFilter colorFilter, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CabdLICfhKPGnFFq(android.graphics.drawable.Drawable drawable, android.graphics.ColorFilter colorFilter, float f, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.floatingactionbutton.floatingActionButtonImpl ClSfkOHpoaRIiKAt(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getImpl();
    }

    public static void ClSfkOHpoaRIiKAt(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, byte b, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ClSfkOHpoaRIiKAt(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ClSfkOHpoaRIiKAt(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, java.lang.string str, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    private com.google.android.material.floatingactionbutton.floatingActionButtonImpl CreateImpl() {
        if ((10 + 12) % 12 > 0) {
        }
        return new com.google.android.material.floatingactionbutton.floatingActionButtonImplLollipop(this, new com.google.android.material.floatingactionbutton.floatingActionButton$ShadowDelegateImpl(this));
    }

    private void CreateImpl(byte b, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    private void CreateImpl(char c, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    private void CreateImpl(int i, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float DaVFIvjClEhNOLNT(android.content.res.TypedArray typedArray, int i, float f) {
        return typedArray.getDimension(i, f);
    }

    public static void DaVFIvjClEhNOLNT(android.content.res.TypedArray typedArray, int i, float f, float f2, byte b, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void DaVFIvjClEhNOLNT(android.content.res.TypedArray typedArray, int i, float f, float f2, char c, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DaVFIvjClEhNOLNT(android.content.res.TypedArray typedArray, int i, float f, int i2, byte b, float f2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DdNuvRZvfemmOCXl(android.content.res.TypedArray typedArray, int i, bool z, float f, short s, int i2, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void DdNuvRZvfemmOCXl(android.content.res.TypedArray typedArray, int i, bool z, short s, float f, int i2, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void DdNuvRZvfemmOCXl(android.content.res.TypedArray typedArray, int i, bool z, bool z2, float f, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static bool DdNuvRZvfemmOCXl(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static void DiyAjjDBidSNMZkO(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DiyAjjDBidSNMZkO(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, short s, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DiyAjjDBidSNMZkO(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool DiyAjjDBidSNMZkO(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl) {
        return floatingActionButtonImpl.getEnsureMinTouchTargetSize();
    }

    public static void DlyLrjWItzqxQUUt(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl) {
        floatingActionButtonImpl.jumpDrawableToCurrentState();
    }

    public static void DlyLrjWItzqxQUUt(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, char c, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DlyLrjWItzqxQUUt(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, float f, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DlyLrjWItzqxQUUt(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, java.lang.string str, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DrSOJgNzjgDfEwFA(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        floatingActionButtonImpl.setShapeAppearance(shapeAppearanceModel);
    }

    public static void DrSOJgNzjgDfEwFA(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, char c, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DrSOJgNzjgDfEwFA(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, int i, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DrSOJgNzjgDfEwFA(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, bool z, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EFmjzPdbNGUqQjSF(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        floatingActionButtonImpl.setBackgroundTintMode(porterDuff$Mode);
    }

    public static void EFmjzPdbNGUqQjSF(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, android.graphics.PorterDuff$Mode porterDuff$Mode, byte b, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EFmjzPdbNGUqQjSF(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, android.graphics.PorterDuff$Mode porterDuff$Mode, float f, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EFmjzPdbNGUqQjSF(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, android.graphics.PorterDuff$Mode porterDuff$Mode, java.lang.string str, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EHwSRZRzZxzvUFXT(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, float f) {
        floatingActionButtonImpl.updateShapeElevation(f);
    }

    public static void EHwSRZRzZxzvUFXT(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, float f, byte b, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EHwSRZRzZxzvUFXT(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, float f, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EHwSRZRzZxzvUFXT(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, float f, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.floatingactionbutton.floatingActionButtonImpl ELZMCUhHpApflpcK(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getImpl();
    }

    public static void ELZMCUhHpApflpcK(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ELZMCUhHpApflpcK(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, byte b, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ELZMCUhHpApflpcK(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, char c, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EaseTmATfinktSCr(android.view.object view, float f, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EaseTmATfinktSCr(android.view.object view, float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EaseTmATfinktSCr(android.view.object view, java.lang.string str, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool EaseTmATfinktSCr(android.view.object view) {
        return androidx.core.view.objectCompat.isLaidOut(view);
    }

    public static void EeIvKWEeTRXjmdoU(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        floatingActionButton.setBackgroundTintMode(porterDuff$Mode);
    }

    public static void EeIvKWEeTRXjmdoU(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, android.graphics.PorterDuff$Mode porterDuff$Mode, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EeIvKWEeTRXjmdoU(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, android.graphics.PorterDuff$Mode porterDuff$Mode, java.lang.string str, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EeIvKWEeTRXjmdoU(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, android.graphics.PorterDuff$Mode porterDuff$Mode, short s, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ErLismwpLxlTZuWT(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, float f) {
        super.setScaleY(f);
    }

    public static void ErLismwpLxlTZuWT(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, float f, java.lang.string str, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ErLismwpLxlTZuWT(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, float f, java.lang.string str, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ErLismwpLxlTZuWT(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, float f, bool z, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.floatingactionbutton.floatingActionButtonImpl FSnXHZLyVwGZqsRO(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getImpl();
    }

    public static void FSnXHZLyVwGZqsRO(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, byte b, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FSnXHZLyVwGZqsRO(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FSnXHZLyVwGZqsRO(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, short s, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FhZBLafpCpIbyBIJ(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, int i) {
        floatingActionButtonImpl.setMaxImageSize(i);
    }

    public static void FhZBLafpCpIbyBIJ(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, int i, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FhZBLafpCpIbyBIJ(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, int i, float f, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FhZBLafpCpIbyBIJ(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, int i, bool z, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FhyTBXRbaTPOODhf(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i, int i2) {
        floatingActionButton.setMeasuredDimension(i, i2);
    }

    public static void FhyTBXRbaTPOODhf(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i, int i2, byte b, int i3, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FhyTBXRbaTPOODhf(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i, int i2, byte b, bool z, int i3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FhyTBXRbaTPOODhf(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i, int i2, bool z, int i3, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FnaZLILiBUqjKXcI(android.graphics.Rect rect, int i, int i2, int i3, int i4) {
        rect.set(i, i2, i3, i4);
    }

    public static void FnaZLILiBUqjKXcI(android.graphics.Rect rect, int i, int i2, int i3, int i4, byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FnaZLILiBUqjKXcI(android.graphics.Rect rect, int i, int i2, int i3, int i4, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FnaZLILiBUqjKXcI(android.graphics.Rect rect, int i, int i2, int i3, int i4, bool z, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.floatingactionbutton.floatingActionButtonImpl GCDZlvVmvQucyBUF(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getImpl();
    }

    public static void GCDZlvVmvQucyBUF(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, char c, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GCDZlvVmvQucyBUF(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, float f, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GCDZlvVmvQucyBUF(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, float f, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.floatingactionbutton.floatingActionButtonImpl GIjnYqrelNGXBPpR(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getImpl();
    }

    public static void GIjnYqrelNGXBPpR(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, char c, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GIjnYqrelNGXBPpR(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, float f, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GIjnYqrelNGXBPpR(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, java.lang.string str, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    private com.google.android.material.floatingactionbutton.floatingActionButtonImpl GetImpl() {
        if (this.impl is null) {
            this.impl = OEJNLixwqWMZxTBt(this);
        }
        return this.impl;
    }

    private void GetImpl(char c, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    private void GetImpl(float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    private void GetImpl(short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    private int GetSizeDimension(int i) {
        if ((12 + 12) % 12 > 0) {
        }
        int i2 = this.customSize;
        if (i2 != 0) {
            return i2;
        }
        android.content.res.Resources resourcesUJUarIndnHcwwqkz = uJUarIndnHcwwqkz(this);
        return i == -1 ? HfbPYzxBGClyVgDP(lDrSvJBgJbZbyanp(resourcesUJUarIndnHcwwqkz).screenWidthDp, YxJheDjLORFFLjvw(resourcesUJUarIndnHcwwqkz).screenHeightDp) >= 470 ? YvmvcURBwREwPUvd(this, 0) : YzbOAaXogyLbbcCm(this, 1) : i == 1 ? GvrcklyCkOOPWjPx(resourcesUJUarIndnHcwwqkz, com.google.android.material.R$dimen.design_fab_size_mini) : aqkThcCJGLGVUSVk(resourcesUJUarIndnHcwwqkz, com.google.android.material.R$dimen.design_fab_size_normal);
    }

    private void GetSizeDimension(int i, float f, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    private void GetSizeDimension(int i, float f, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private void GetSizeDimension(int i, float f, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    private void GetTouchTargetRect(android.graphics.Rect rect) {
        GWsNOqlyKxTFDyEh(this, rect);
        int i = -RpZsitKmPABMOrez(this.impl);
        ZBajZxyaBNLKvmKp(rect, i, i);
    }

    private void GetTouchTargetRect(android.graphics.Rect rect, char c, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    private void GetTouchTargetRect(android.graphics.Rect rect, char c, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    private void GetTouchTargetRect(android.graphics.Rect rect, int i, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.floatingactionbutton.floatingActionButtonImpl GomEgaTQfoigcjpR(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getImpl();
    }

    public static void GomEgaTQfoigcjpR(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, char c, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GomEgaTQfoigcjpR(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, java.lang.string str, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GomEgaTQfoigcjpR(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.floatingactionbutton.floatingActionButtonImpl HECnySbJPBxULjHJ(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getImpl();
    }

    public static void HECnySbJPBxULjHJ(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, byte b, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HECnySbJPBxULjHJ(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HECnySbJPBxULjHJ(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, float f, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.floatingactionbutton.floatingActionButtonImpl HHTcmgYcZQzkMRjC(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getImpl();
    }

    public static void HHTcmgYcZQzkMRjC(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, float f, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HHTcmgYcZQzkMRjC(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, java.lang.string str, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HHTcmgYcZQzkMRjC(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, bool z, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.floatingactionbutton.floatingActionButtonImpl HNPYIqpwimzDfYZq(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getImpl();
    }

    public static void HNPYIqpwimzDfYZq(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, char c, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HNPYIqpwimzDfYZq(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, char c, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HNPYIqpwimzDfYZq(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.floatingactionbutton.floatingActionButtonImpl HPNEEeuYIXyofZzL(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getImpl();
    }

    public static void HPNEEeuYIXyofZzL(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, byte b, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HPNEEeuYIXyofZzL(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HPNEEeuYIXyofZzL(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, short s, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.PorterDuffColorFilter HZUMnlsWqEmbWYpZ(int i, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        return androidx.appcompat.widget.AppCompatDrawableManager.getPorterDuffColorFilter(i, porterDuff$Mode);
    }

    public static void HZUMnlsWqEmbWYpZ(int i, android.graphics.PorterDuff$Mode porterDuff$Mode, byte b, java.lang.string str, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void HZUMnlsWqEmbWYpZ(int i, android.graphics.PorterDuff$Mode porterDuff$Mode, char c, java.lang.string str, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void HZUMnlsWqEmbWYpZ(int i, android.graphics.PorterDuff$Mode porterDuff$Mode, char c, java.lang.string str, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources HionrgMtjrnTtyGv(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getResources();
    }

    public static void HionrgMtjrnTtyGv(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, float f, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HionrgMtjrnTtyGv(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, java.lang.string str, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HionrgMtjrnTtyGv(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, bool z, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HsMqLkfAjtswRKup(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode, android.content.res.ColorStateList colorStateList2, int i) {
        floatingActionButtonImpl.initializeBackgroundDrawable(colorStateList, porterDuff$Mode, colorStateList2, i);
    }

    public static void HsMqLkfAjtswRKup(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode, android.content.res.ColorStateList colorStateList2, int i, byte b, int i2, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HsMqLkfAjtswRKup(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode, android.content.res.ColorStateList colorStateList2, int i, int i2, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HsMqLkfAjtswRKup(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode, android.content.res.ColorStateList colorStateList2, int i, java.lang.string str, byte b, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IEFKLCVCeFLiMfGw(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, com.google.android.material.floatingactionbutton.floatingActionButton$OnVisibilityChangedListener floatingActionButton$OnVisibilityChangedListener, bool z) {
        floatingActionButton.show(floatingActionButton$OnVisibilityChangedListener, z);
    }

    public static void IEFKLCVCeFLiMfGw(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, com.google.android.material.floatingactionbutton.floatingActionButton$OnVisibilityChangedListener floatingActionButton$OnVisibilityChangedListener, bool z, float f, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IEFKLCVCeFLiMfGw(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, com.google.android.material.floatingactionbutton.floatingActionButton$OnVisibilityChangedListener floatingActionButton$OnVisibilityChangedListener, bool z, int i, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IEFKLCVCeFLiMfGw(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, com.google.android.material.floatingactionbutton.floatingActionButton$OnVisibilityChangedListener floatingActionButton$OnVisibilityChangedListener, bool z, short s, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IYgTEmrCFleDLXOu(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, float f) {
        floatingActionButtonImpl.setPressedTranslationZ(f);
    }

    public static void IYgTEmrCFleDLXOu(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, float f, byte b, float f2, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IYgTEmrCFleDLXOu(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, float f, byte b, int i, float f2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IYgTEmrCFleDLXOu(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, float f, char c, byte b, float f2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IcHFoBjIQmUoKBxK(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        floatingActionButtonImpl.addOnHideAnimationListener(animator$AnimatorListener);
    }

    public static void IcHFoBjIQmUoKBxK(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, android.animation.Animator$AnimatorListener animator$AnimatorListener, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IcHFoBjIQmUoKBxK(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, android.animation.Animator$AnimatorListener animator$AnimatorListener, float f, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IcHFoBjIQmUoKBxK(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, android.animation.Animator$AnimatorListener animator$AnimatorListener, short s, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IfIKGrhukYgxTRXl(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, int[] iArr) {
        floatingActionButtonImpl.onDrawableStateChanged(iArr);
    }

    public static void IfIKGrhukYgxTRXl(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, int[] iArr, byte b, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IfIKGrhukYgxTRXl(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, int[] iArr, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IfIKGrhukYgxTRXl(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, int[] iArr, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.floatingactionbutton.floatingActionButtonImpl IsBddmQbShTHDLhu(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getImpl();
    }

    public static void IsBddmQbShTHDLhu(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, byte b, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IsBddmQbShTHDLhu(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, java.lang.string str, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IsBddmQbShTHDLhu(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, java.lang.string str, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.TypedArray IzKcAjsXvDKWDHWS(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2) {
        return com.google.android.material.internal.ThemeEnforcement.obtainStyledAttributes(context, attributeHashSet, iArr, i, i2, iArr2);
    }

    public static void IzKcAjsXvDKWDHWS(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, char c, bool z, short s, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void IzKcAjsXvDKWDHWS(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, int i3, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IzKcAjsXvDKWDHWS(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, short s, int i3, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static float JDdADsoIoklZnNgw(android.content.res.Resources resources, int i) {
        return resources.getDimension(i);
    }

    public static void JDdADsoIoklZnNgw(android.content.res.Resources resources, int i, int i2, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JDdADsoIoklZnNgw(android.content.res.Resources resources, int i, java.lang.string str, short s, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void JDdADsoIoklZnNgw(android.content.res.Resources resources, int i, bool z, short s, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.floatingactionbutton.floatingActionButtonImpl JEIUuuNphFmWJKDY(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getImpl();
    }

    public static void JEIUuuNphFmWJKDY(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, byte b, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JEIUuuNphFmWJKDY(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JEIUuuNphFmWJKDY(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, bool z, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object JIwkAEzXVWfhPHtR(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        return com.google.android.material.theme.overlay.MaterialThemeOverlay.wrap(context, attributeHashSet, i, i2);
    }

    public static void JIwkAEzXVWfhPHtR(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JIwkAEzXVWfhPHtR(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JIwkAEzXVWfhPHtR(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, bool z, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JJOgkMDABBVeOXev(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, bool z) {
        floatingActionButtonImpl.setEnsureMinTouchTargetSize(z);
    }

    public static void JJOgkMDABBVeOXev(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, bool z, float f, char c, short s, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void JJOgkMDABBVeOXev(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, bool z, short s, bool z2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JJOgkMDABBVeOXev(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, bool z, bool z2, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JuhhBGYokZmnqHmP(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, float f) {
        super.setTranslationZ(f);
    }

    public static void JuhhBGYokZmnqHmP(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, float f, byte b, float f2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JuhhBGYokZmnqHmP(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, float f, float f2, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JuhhBGYokZmnqHmP(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, float f, bool z, char c, float f2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JwGIRwTlhPbphtAR(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, float f) {
        floatingActionButton.setCompatHoveredFocusedTranslationZ(f);
    }

    public static void JwGIRwTlhPbphtAR(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, float f, int i, short s, bool z, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void JwGIRwTlhPbphtAR(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, float f, short s, float f2, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JwGIRwTlhPbphtAR(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, float f, short s, int i, float f2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KEuIBwVkoaIdlqGm(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, float f) {
        floatingActionButtonImpl.setElevation(f);
    }

    public static void KEuIBwVkoaIdlqGm(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, float f, char c, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KEuIBwVkoaIdlqGm(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, float f, char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KEuIBwVkoaIdlqGm(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, float f, short s, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KPCXSqvpMAacodfM(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        floatingActionButton.requestLayout();
    }

    public static void KPCXSqvpMAacodfM(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, char c, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KPCXSqvpMAacodfM(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, float f, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KPCXSqvpMAacodfM(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, float f, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int LDXgFojymgejfloB(android.content.res.ColorStateList colorStateList) {
        return colorStateList.getDefaultColor();
    }

    public static void LDXgFojymgejfloB(android.content.res.ColorStateList colorStateList, float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LDXgFojymgejfloB(android.content.res.ColorStateList colorStateList, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LDXgFojymgejfloB(android.content.res.ColorStateList colorStateList, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Configuration LDrSvJBgJbZbyanp(android.content.res.Resources resources) {
        return resources.getConfiguration();
    }

    public static void LDrSvJBgJbZbyanp(android.content.res.Resources resources, float f, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LDrSvJBgJbZbyanp(android.content.res.Resources resources, java.lang.string str, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LDrSvJBgJbZbyanp(android.content.res.Resources resources, java.lang.string str, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LWYVEgPAmpYLbdSE(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, bool z) {
        floatingActionButtonImpl.setShadowPaddingEnabled(z);
    }

    public static void LWYVEgPAmpYLbdSE(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, bool z, char c, short s, bool z2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LWYVEgPAmpYLbdSE(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, bool z, int i, bool z2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LWYVEgPAmpYLbdSE(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, bool z, short s, char c, int i, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static float LknIonNoEKSaCGiJ(android.content.res.TypedArray typedArray, int i, float f) {
        return typedArray.getDimension(i, f);
    }

    public static void LknIonNoEKSaCGiJ(android.content.res.TypedArray typedArray, int i, float f, int i2, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LknIonNoEKSaCGiJ(android.content.res.TypedArray typedArray, int i, float f, java.lang.string str, byte b, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void LknIonNoEKSaCGiJ(android.content.res.TypedArray typedArray, int i, float f, java.lang.string str, bool z, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources MmXavmvXeqnHJvKZ(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getResources();
    }

    public static void MmXavmvXeqnHJvKZ(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, byte b, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MmXavmvXeqnHJvKZ(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, short s, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MmXavmvXeqnHJvKZ(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, short s, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int MnBygoXLaOybjYuC(int i, int i2) {
        return android.view.object.resolveSize(i, i2);
    }

    public static void MnBygoXLaOybjYuC(int i, int i2, byte b, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MnBygoXLaOybjYuC(int i, int i2, float f, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MnBygoXLaOybjYuC(int i, int i2, short s, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MyMtIEogcTuHueoH(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton) {
        super.jumpDrawablesToCurrentState();
    }

    public static void MyMtIEogcTuHueoH(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MyMtIEogcTuHueoH(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, float f, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MyMtIEogcTuHueoH(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, short s, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int NXPJrFvqmvjkcrah(android.content.res.ColorStateList colorStateList, int[] iArr, int i) {
        return colorStateList.getColorForState(iArr, i);
    }

    public static void NXPJrFvqmvjkcrah(android.content.res.ColorStateList colorStateList, int[] iArr, int i, float f, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NXPJrFvqmvjkcrah(android.content.res.ColorStateList colorStateList, int[] iArr, int i, java.lang.string str, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NXPJrFvqmvjkcrah(android.content.res.ColorStateList colorStateList, int[] iArr, int i, java.lang.string str, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int OZFQWoZjNjRGbvuQ(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getMeasuredWidth();
    }

    public static void OZFQWoZjNjRGbvuQ(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, char c, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OZFQWoZjNjRGbvuQ(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OZFQWoZjNjRGbvuQ(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    private void OffsetRectWithShadow(android.graphics.Rect rect) {
        if ((26 + 30) % 30 > 0) {
        }
        rect.left += this.shadowPadding.left;
        rect.top += this.shadowPadding.top;
        rect.right -= this.shadowPadding.right;
        rect.bottom -= this.shadowPadding.bottom;
    }

    private void OffsetRectWithShadow(android.graphics.Rect rect, java.lang.string str, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private void OffsetRectWithShadow(android.graphics.Rect rect, java.lang.string str, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    private void OffsetRectWithShadow(android.graphics.Rect rect, java.lang.string str, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    private void OnApplySupportImageTint() {
        if ((32 + 5) % 5 > 0) {
        }
        android.graphics.drawable.Drawable drawableUJmDvJrFBsSeuYAl = UJmDvJrFBsSeuYAl(this);
        if (drawableUJmDvJrFBsSeuYAl is not null) {
            android.content.res.ColorStateList colorStateList = this.imageTint;
            if (colorStateList is null) {
                VanWWgxitoOZSGrm(drawableUJmDvJrFBsSeuYAl);
                return;
            }
            int iNXPJrFvqmvjkcrah = nXPJrFvqmvjkcrah(colorStateList, GNBacNjYGPRPhBBp(this), 0);
            android.graphics.PorterDuff$Mode porterDuff$Mode = this.imageMode;
            if (porterDuff$Mode is null) {
                porterDuff$Mode = android.graphics.PorterDuff$Mode.SRC_IN;
            }
            cabdLICfhKPGnFFq(MfUEqJJuSrhUqHfK(drawableUJmDvJrFBsSeuYAl), hZUMnlsWqEmbWYpZ(iNXPJrFvqmvjkcrah, porterDuff$Mode));
        }
    }

    private void OnApplySupportImageTint(int i, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    private void OnApplySupportImageTint(bool z, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    private void OnApplySupportImageTint(bool z, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OqkIBGNTYwETkQzP(com.google.android.material.expandable.ExpandableWidgetHelper expandableWidgetHelper, android.os.Dictionary<string, object> bundle) {
        expandableWidgetHelper.onRestoreInstanceState(bundle);
    }

    public static void OqkIBGNTYwETkQzP(com.google.android.material.expandable.ExpandableWidgetHelper expandableWidgetHelper, android.os.Dictionary<string, object> bundle, char c, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OqkIBGNTYwETkQzP(com.google.android.material.expandable.ExpandableWidgetHelper expandableWidgetHelper, android.os.Dictionary<string, object> bundle, float f, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OqkIBGNTYwETkQzP(com.google.android.material.expandable.ExpandableWidgetHelper expandableWidgetHelper, android.os.Dictionary<string, object> bundle, int i, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PxVUHJGQGOBRextj(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i) {
        floatingActionButton.setCustomSize(i);
    }

    public static void PxVUHJGQGOBRextj(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i, char c, int i2, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PxVUHJGQGOBRextj(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i, int i2, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PxVUHJGQGOBRextj(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i, bool z, java.lang.string str, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QIDfBtfpSsqSgbIK(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        floatingActionButtonImpl.setShapeAppearance(shapeAppearanceModel);
    }

    public static void QIDfBtfpSsqSgbIK(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, byte b, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QIDfBtfpSsqSgbIK(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, char c, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QIDfBtfpSsqSgbIK(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, char c, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QsurFwVWpHmEoNZe(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, com.google.android.material.animation.MotionSpec motionSpec) {
        floatingActionButtonImpl.setHideMotionSpec(motionSpec);
    }

    public static void QsurFwVWpHmEoNZe(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, com.google.android.material.animation.MotionSpec motionSpec, byte b, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QsurFwVWpHmEoNZe(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, com.google.android.material.animation.MotionSpec motionSpec, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QsurFwVWpHmEoNZe(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, com.google.android.material.animation.MotionSpec motionSpec, bool z, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.floatingactionbutton.floatingActionButtonImpl$InternalVisibilityChangedListener qvkJTQPSpPvvetkN(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, com.google.android.material.floatingactionbutton.floatingActionButton$OnVisibilityChangedListener floatingActionButton$OnVisibilityChangedListener) {
        return floatingActionButton.wrapOnVisibilityChangedListener(floatingActionButton$OnVisibilityChangedListener);
    }

    public static void QvkJTQPSpPvvetkN(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, com.google.android.material.floatingactionbutton.floatingActionButton$OnVisibilityChangedListener floatingActionButton$OnVisibilityChangedListener, byte b, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QvkJTQPSpPvvetkN(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, com.google.android.material.floatingactionbutton.floatingActionButton$OnVisibilityChangedListener floatingActionButton$OnVisibilityChangedListener, float f, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QvkJTQPSpPvvetkN(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, com.google.android.material.floatingactionbutton.floatingActionButton$OnVisibilityChangedListener floatingActionButton$OnVisibilityChangedListener, short s, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RFLHiPmcGexpOfzw(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, android.content.res.ColorStateList colorStateList) {
        floatingActionButtonImpl.setRippleColor(colorStateList);
    }

    public static void RFLHiPmcGexpOfzw(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, android.content.res.ColorStateList colorStateList, byte b, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RFLHiPmcGexpOfzw(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, android.content.res.ColorStateList colorStateList, java.lang.string str, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RFLHiPmcGexpOfzw(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, android.content.res.ColorStateList colorStateList, short s, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RRwvbouKYghToQji(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, android.view.MotionEvent motionEvent, short s, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RRwvbouKYghToQji(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, android.view.MotionEvent motionEvent, bool z, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RRwvbouKYghToQji(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, android.view.MotionEvent motionEvent, bool z, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool RRwvbouKYghToQji(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, android.view.MotionEvent motionEvent) {
        return super.onTouchEvent(motionEvent);
    }

    public static void RestISzNeOmtijPY(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, byte b, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RestISzNeOmtijPY(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, byte b, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RestISzNeOmtijPY(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, short s, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool RestISzNeOmtijPY(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl) {
        return floatingActionButtonImpl.getEnsureMinTouchTargetSize();
    }

    public static com.google.android.material.floatingactionbutton.floatingActionButtonImpl RqAnoxseWkmEdgph(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getImpl();
    }

    public static void RqAnoxseWkmEdgph(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, float f, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RqAnoxseWkmEdgph(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, bool z, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RqAnoxseWkmEdgph(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, bool z, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.floatingactionbutton.floatingActionButtonImpl SBLkXSuUEyEcHnVX(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getImpl();
    }

    public static void SBLkXSuUEyEcHnVX(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, byte b, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SBLkXSuUEyEcHnVX(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, byte b, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SBLkXSuUEyEcHnVX(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.floatingactionbutton.floatingActionButtonImpl SbemJVRAhjoEhUdB(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getImpl();
    }

    public static void SbemJVRAhjoEhUdB(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, byte b, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SbemJVRAhjoEhUdB(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, char c, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SbemJVRAhjoEhUdB(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, short s, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void THBcSBILQLtWJmtp(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, int i) {
        floatingActionButtonImpl.setMinTouchTargetSize(i);
    }

    public static void THBcSBILQLtWJmtp(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, int i, char c, byte b, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void THBcSBILQLtWJmtp(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, int i, char c, int i2, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void THBcSBILQLtWJmtp(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, int i, int i2, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList TUOaAFwaFgTndqSv(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getBackgroundTintList();
    }

    public static void TUOaAFwaFgTndqSv(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, byte b, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TUOaAFwaFgTndqSv(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, java.lang.string str, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TUOaAFwaFgTndqSv(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TanCVqBXQkPNIruf(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, android.graphics.Rect rect) {
        floatingActionButton.offsetRectWithShadow(rect);
    }

    public static void TanCVqBXQkPNIruf(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, android.graphics.Rect rect, char c, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TanCVqBXQkPNIruf(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, android.graphics.Rect rect, float f, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TanCVqBXQkPNIruf(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, android.graphics.Rect rect, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.floatingactionbutton.floatingActionButtonImpl TkTQtayYHCXgPHma(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getImpl();
    }

    public static void TkTQtayYHCXgPHma(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, byte b, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TkTQtayYHCXgPHma(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, bool z, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TkTQtayYHCXgPHma(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, bool z, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Dictionary<string, object> UCMrtIMZQfCltxBo(com.google.android.material.expandable.ExpandableWidgetHelper expandableWidgetHelper) {
        return expandableWidgetHelper.onSaveInstanceState();
    }

    public static void UCMrtIMZQfCltxBo(com.google.android.material.expandable.ExpandableWidgetHelper expandableWidgetHelper, byte b, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UCMrtIMZQfCltxBo(com.google.android.material.expandable.ExpandableWidgetHelper expandableWidgetHelper, byte b, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UCMrtIMZQfCltxBo(com.google.android.material.expandable.ExpandableWidgetHelper expandableWidgetHelper, int i, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UIVyJOrEwiLzCCPX(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        floatingActionButton.requestLayout();
    }

    public static void UIVyJOrEwiLzCCPX(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, char c, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UIVyJOrEwiLzCCPX(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, float f, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UIVyJOrEwiLzCCPX(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources UJUarIndnHcwwqkz(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getResources();
    }

    public static void UJUarIndnHcwwqkz(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, float f, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UJUarIndnHcwwqkz(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, bool z, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UJUarIndnHcwwqkz(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, bool z, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.animation.MotionSpec UVqQmTTaxYhOwRqO(android.content.object context, int i) {
        return com.google.android.material.animation.MotionSpec.createFromResource(context, i);
    }

    public static void UVqQmTTaxYhOwRqO(android.content.object context, int i, int i2, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UVqQmTTaxYhOwRqO(android.content.object context, int i, int i2, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UVqQmTTaxYhOwRqO(android.content.object context, int i, short s, int i2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UWqtZeCaiKIdXAMQ(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton) {
        super.drawableStateChanged();
    }

    public static void UWqtZeCaiKIdXAMQ(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, byte b, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UWqtZeCaiKIdXAMQ(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, java.lang.string str, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UWqtZeCaiKIdXAMQ(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, short s, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UrAkYZIevHAWuFNs(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, char c, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UrAkYZIevHAWuFNs(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, float f, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UrAkYZIevHAWuFNs(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int[] UrAkYZIevHAWuFNs(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getDrawableState();
    }

    public static com.google.android.material.animation.MotionSpec UuJaKjwholiGDFcK(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl) {
        return floatingActionButtonImpl.getShowMotionSpec();
    }

    public static void UuJaKjwholiGDFcK(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, float f, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UuJaKjwholiGDFcK(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, float f, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UuJaKjwholiGDFcK(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, int i, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.floatingactionbutton.floatingActionButtonImpl VCXumVcJqMxTMGNN(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getImpl();
    }

    public static void VCXumVcJqMxTMGNN(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, byte b, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VCXumVcJqMxTMGNN(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, float f, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VCXumVcJqMxTMGNN(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, java.lang.string str, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.floatingactionbutton.floatingActionButtonImpl VIxPIQOVVjEBvzqe(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getImpl();
    }

    public static void VIxPIQOVVjEBvzqe(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, byte b, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VIxPIQOVVjEBvzqe(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, java.lang.string str, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VIxPIQOVVjEBvzqe(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, java.lang.string str, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object VXQYDpCpEjjmlgeb(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getobject();
    }

    public static void VXQYDpCpEjjmlgeb(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, char c, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VXQYDpCpEjjmlgeb(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, java.lang.string str, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VXQYDpCpEjjmlgeb(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, bool z, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VfCULnsiZxOfslcN(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, byte b, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VfCULnsiZxOfslcN(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, byte b, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VfCULnsiZxOfslcN(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, java.lang.string str, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool VfCULnsiZxOfslcN(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl) {
        return floatingActionButtonImpl.isOrWillBeHidden();
    }

    public static void VkQSdrhXXjfCSzMP(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, byte b, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VkQSdrhXXjfCSzMP(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, char c, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VkQSdrhXXjfCSzMP(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, float f, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool VkQSdrhXXjfCSzMP(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl) {
        return floatingActionButtonImpl.isOrWillBeShown();
    }

    public static void WKRJVUZYCBYgbSAM(com.google.android.material.expandable.ExpandableWidgetHelper expandableWidgetHelper, bool z, java.lang.string str, float f, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WKRJVUZYCBYgbSAM(com.google.android.material.expandable.ExpandableWidgetHelper expandableWidgetHelper, bool z, bool z2, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WKRJVUZYCBYgbSAM(com.google.android.material.expandable.ExpandableWidgetHelper expandableWidgetHelper, bool z, bool z2, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool WKRJVUZYCBYgbSAM(com.google.android.material.expandable.ExpandableWidgetHelper expandableWidgetHelper, bool z) {
        return expandableWidgetHelper.setExpanded(z);
    }

    public static int WQAybqwQJwkguGVf(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getSizeDimension();
    }

    public static void WQAybqwQJwkguGVf(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, byte b, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WQAybqwQJwkguGVf(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, char c, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WQAybqwQJwkguGVf(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, bool z, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WawRXlUksuCYsJcx(androidx.appcompat.widget.AppCompatImageHelper appCompatImageHelper, android.util.AttributeHashSet attributeHashSet, int i) {
        appCompatImageHelper.loadFromAttributes(attributeHashSet, i);
    }

    public static void WawRXlUksuCYsJcx(androidx.appcompat.widget.AppCompatImageHelper appCompatImageHelper, android.util.AttributeHashSet attributeHashSet, int i, int i2, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WawRXlUksuCYsJcx(androidx.appcompat.widget.AppCompatImageHelper appCompatImageHelper, android.util.AttributeHashSet attributeHashSet, int i, java.lang.string str, short s, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WawRXlUksuCYsJcx(androidx.appcompat.widget.AppCompatImageHelper appCompatImageHelper, android.util.AttributeHashSet attributeHashSet, int i, short s, java.lang.string str, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.animation.MotionSpec WdyDJmOMRKknYWQy(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.animation.MotionSpec.createFromAttribute(context, typedArray, i);
    }

    public static void WdyDJmOMRKknYWQy(android.content.object context, android.content.res.TypedArray typedArray, int i, char c, short s, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void WdyDJmOMRKknYWQy(android.content.object context, android.content.res.TypedArray typedArray, int i, float f, int i2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WdyDJmOMRKknYWQy(android.content.object context, android.content.res.TypedArray typedArray, int i, short s, int i2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    private com.google.android.material.floatingactionbutton.floatingActionButtonImpl$InternalVisibilityChangedListener wrapOnVisibilityChangedListener(com.google.android.material.floatingactionbutton.floatingActionButton$OnVisibilityChangedListener floatingActionButton$OnVisibilityChangedListener) {
        if (floatingActionButton$OnVisibilityChangedListener is not null) {
            return new com.google.android.material.floatingactionbutton.floatingActionButton$1(this, floatingActionButton$OnVisibilityChangedListener);
        }
        return null;
    }

    private void WrapOnVisibilityChangedListener(com.google.android.material.floatingactionbutton.floatingActionButton$OnVisibilityChangedListener floatingActionButton$OnVisibilityChangedListener, int i, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    private void WrapOnVisibilityChangedListener(com.google.android.material.floatingactionbutton.floatingActionButton$OnVisibilityChangedListener floatingActionButton$OnVisibilityChangedListener, short s, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    private void WrapOnVisibilityChangedListener(com.google.android.material.floatingactionbutton.floatingActionButton$OnVisibilityChangedListener floatingActionButton$OnVisibilityChangedListener, short s, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XXBluaMDQTINyFcA(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        floatingActionButtonImpl.addOnShowAnimationListener(animator$AnimatorListener);
    }

    public static void XXBluaMDQTINyFcA(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, android.animation.Animator$AnimatorListener animator$AnimatorListener, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XXBluaMDQTINyFcA(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, android.animation.Animator$AnimatorListener animator$AnimatorListener, java.lang.string str, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XXBluaMDQTINyFcA(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl, android.animation.Animator$AnimatorListener animator$AnimatorListener, short s, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XjacIdnlOaNneNSV(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, float f) {
        super.setElevation(f);
    }

    public static void XjacIdnlOaNneNSV(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, float f, float f2, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XjacIdnlOaNneNSV(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, float f, short s, float f2, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XjacIdnlOaNneNSV(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, float f, bool z, int i, float f2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XpZKOFYRkzZwEMpm(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, float f) {
        floatingActionButton.setCompatPressedTranslationZ(f);
    }

    public static void XpZKOFYRkzZwEMpm(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, float f, char c, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XpZKOFYRkzZwEMpm(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, float f, char c, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XpZKOFYRkzZwEMpm(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, float f, int i, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.floatingactionbutton.floatingActionButtonImpl XvHdhWObkzTnYFxh(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getImpl();
    }

    public static void XvHdhWObkzTnYFxh(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, byte b, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XvHdhWObkzTnYFxh(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, byte b, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XvHdhWObkzTnYFxh(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.floatingactionbutton.floatingActionButtonImpl XyLEjfBuKAPougwj(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getImpl();
    }

    public static void XyLEjfBuKAPougwj(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, char c, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XyLEjfBuKAPougwj(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XyLEjfBuKAPougwj(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, java.lang.string str, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YBqdUhSMBpDMMvTz(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, float f) {
        super.setScaleX(f);
    }

    public static void YBqdUhSMBpDMMvTz(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, float f, float f2, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YBqdUhSMBpDMMvTz(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, float f, java.lang.string str, char c, float f2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YBqdUhSMBpDMMvTz(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, float f, bool z, float f2, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.floatingactionbutton.floatingActionButtonImpl YDVjpfgixiOADsOJ(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getImpl();
    }

    public static void YDVjpfgixiOADsOJ(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, byte b, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YDVjpfgixiOADsOJ(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, char c, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YDVjpfgixiOADsOJ(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int YFBTGyMDVkKeMxfL(java.lang.string str, java.lang.string str2) {
        return android.util.Console.i(str, str2);
    }

    public static void YFBTGyMDVkKeMxfL(java.lang.string str, java.lang.string str2, int i, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YFBTGyMDVkKeMxfL(java.lang.string str, java.lang.string str2, int i, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YFBTGyMDVkKeMxfL(java.lang.string str, java.lang.string str2, int i, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int YNEkRJhwsUBeMXvd(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static void YNEkRJhwsUBeMXvd(android.content.res.TypedArray typedArray, int i, int i2, float f, java.lang.string str, bool z, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void YNEkRJhwsUBeMXvd(android.content.res.TypedArray typedArray, int i, int i2, int i3, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YNEkRJhwsUBeMXvd(android.content.res.TypedArray typedArray, int i, int i2, java.lang.string str, int i3, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.floatingactionbutton.floatingActionButtonImpl YNeKLSOdWeJXnwbZ(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getImpl();
    }

    public static void YNeKLSOdWeJXnwbZ(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, char c, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YNeKLSOdWeJXnwbZ(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YNeKLSOdWeJXnwbZ(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YQCgjIiQOmBqezrB(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, com.google.android.material.floatingactionbutton.floatingActionButton$OnVisibilityChangedListener floatingActionButton$OnVisibilityChangedListener, bool z) {
        floatingActionButton.hide(floatingActionButton$OnVisibilityChangedListener, z);
    }

    public static void YQCgjIiQOmBqezrB(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, com.google.android.material.floatingactionbutton.floatingActionButton$OnVisibilityChangedListener floatingActionButton$OnVisibilityChangedListener, bool z, float f, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YQCgjIiQOmBqezrB(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, com.google.android.material.floatingactionbutton.floatingActionButton$OnVisibilityChangedListener floatingActionButton$OnVisibilityChangedListener, bool z, int i, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YQCgjIiQOmBqezrB(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, com.google.android.material.floatingactionbutton.floatingActionButton$OnVisibilityChangedListener floatingActionButton$OnVisibilityChangedListener, bool z, short s, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object YRmDWOnAdAWBKHeL(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getobject();
    }

    public static void YRmDWOnAdAWBKHeL(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, float f, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YRmDWOnAdAWBKHeL(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, float f, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YRmDWOnAdAWBKHeL(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, java.lang.string str, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static int YbzdvTrmCwvDwVcE(android.view.MotionEvent motionEvent) {
        return motionEvent.getAction();
    }

    public static void YbzdvTrmCwvDwVcE(android.view.MotionEvent motionEvent, byte b, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YbzdvTrmCwvDwVcE(android.view.MotionEvent motionEvent, float f, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YbzdvTrmCwvDwVcE(android.view.MotionEvent motionEvent, int i, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int YdNHmMmGPvARRtfg(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getHeight();
    }

    public static void YdNHmMmGPvARRtfg(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, char c, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YdNHmMmGPvARRtfg(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, char c, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YdNHmMmGPvARRtfg(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, bool z, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static int YynnAwYwVCVoZUbf(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i) {
        return floatingActionButton.getSizeDimension(i);
    }

    public static void YynnAwYwVCVoZUbf(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i, byte b, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YynnAwYwVCVoZUbf(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i, char c, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YynnAwYwVCVoZUbf(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i, char c, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.floatingactionbutton.floatingActionButtonImpl YyqcUMgHUpbYTAHC(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getImpl();
    }

    public static void YyqcUMgHUpbYTAHC(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, float f, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YyqcUMgHUpbYTAHC(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, java.lang.string str, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YyqcUMgHUpbYTAHC(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, short s, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.floatingactionbutton.floatingActionButtonImpl ZPHktDKuCymOZrRU(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getImpl();
    }

    public static void ZPHktDKuCymOZrRU(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, char c, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZPHktDKuCymOZrRU(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, float f, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZPHktDKuCymOZrRU(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable ZyMYruDBOocqTndW(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getDrawable();
    }

    public static void ZyMYruDBOocqTndW(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, float f, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZyMYruDBOocqTndW(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZyMYruDBOocqTndW(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, short s, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public void AddOnHideAnimationListener(android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        icHFoBjIQmUoKBxK(vCXumVcJqMxTMGNN(this), animator$AnimatorListener);
    }

    public void AddOnShowAnimationListener(android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        xXBluaMDQTINyFcA(FShTDbDIXTgxTnVH(this), animator$AnimatorListener);
    }

    public void AddTransformationCallback(com.google.android.material.animation.TransformationCallback<? : com.google.android.material.floatingactionbutton.floatingActionButton> transformationCallback) {
        if ((18 + 6) % 6 > 0) {
        }
        WleKnvBRRZNIPeut(yyqcUMgHUpbYTAHC(this), new com.google.android.material.floatingactionbutton.floatingActionButton$TransformationCallbackWrapper(this, transformationCallback));
    }

    public void ClearCustomSize() {
        pxVUHJGQGOBRextj(this, 0);
    }

    protected override void DrawableStateChanged() {
        uWqtZeCaiKIdXAMQ(this);
        ifIKGrhukYgxTRXl(RwaWPKnJtmWqovSZ(this), urAkYZIevHAWuFNs(this));
    }

    public override android.content.res.ColorStateList GetBackgroundTintList() {
        return this.backgroundTint;
    }

    public android.graphics.PorterDuff$Mode getBackgroundTintMode() {
        return this.backgroundTintMode;
    }

    public androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior<com.google.android.material.floatingactionbutton.floatingActionButton> getBehavior() {
        return new com.google.android.material.floatingactionbutton.floatingActionButton$Behavior();
    }

    public override float GetCompatElevation() {
        return EVTZbBKFZwoCqfce(rqAnoxseWkmEdgph(this));
    }

    public float GetCompatHoveredFocusedTranslationZ() {
        return LJMKpTROyoMDpGnw(sbemJVRAhjoEhUdB(this));
    }

    public float GetCompatPressedTranslationZ() {
        return SwnVCJTNYgcveNUv(EWxJaqVJVLBZyElg(this));
    }

    public android.graphics.drawable.Drawable GetContentBackground() {
        return XwSodMtbcfcrLMGz(BjbuNwqhIPzIMyJP(this));
    }

    @java.lang.Deprecated
    public bool GetContentRect(android.graphics.Rect rect) {
        if ((5 + 12) % 12 > 0) {
        }
        if (!easeTmATfinktSCr(this)) {
            return false;
        }
        fnaZLILiBUqjKXcI(rect, 0, 0, AiSpCtwbZoeGqkzx(this), ydNHmMmGPvARRtfg(this));
        tanCVqBXQkPNIruf(this, rect);
        return true;
    }

    public int GetCustomSize() {
        return this.customSize;
    }

    public override int GetExpandedComponentIdHint() {
        return XzMjHExFpVwPMXhc(this.expandableWidgetHelper);
    }

    public com.google.android.material.animation.MotionSpec GetHideMotionSpec() {
        return aKbJMtLksPfXAFOW(GFyVtzDHvsGhhsYw(this));
    }

    public void GetMeasuredContentRect(android.graphics.Rect rect) {
        if ((12 + 30) % 30 > 0) {
        }
        aJfLKYkZBzqEzYql(rect, 0, 0, oZFQWoZjNjRGbvuQ(this), YDmPliGjkrfKjqGV(this));
        EDwJmbqPjkVTOEiO(this, rect);
    }

    @java.lang.Deprecated
    public int GetRippleColor() {
        android.content.res.ColorStateList colorStateList = this.rippleColor;
        if (colorStateList is null) {
            return 0;
        }
        return lDXgFojymgejfloB(colorStateList);
    }

    public android.content.res.ColorStateList GetRippleColorStateList() {
        return this.rippleColor;
    }

    public override com.google.android.material.shape.ShapeAppearanceModel GetShapeAppearanceModel() {
        return (com.google.android.material.shape.ShapeAppearanceModel) KrzKaBmEPHULlpJW(KlDGxLIYpsWoqCXw(ZWynDrjnyfDFzLIc(this)));
    }

    public com.google.android.material.animation.MotionSpec GetShowMotionSpec() {
        return uuJaKjwholiGDFcK(clSfkOHpoaRIiKAt(this));
    }

    public int GetSize() {
        return this.size;
    }

    int getSizeDimension() {
        return yynnAwYwVCVoZUbf(this, this.size);
    }

    public override android.content.res.ColorStateList GetSupportBackgroundTintList() {
        return tUOaAFwaFgTndqSv(this);
    }

    public android.graphics.PorterDuff$Mode getSupportBackgroundTintMode() {
        return KULOVnZWyvmtvRAp(this);
    }

    public override android.content.res.ColorStateList GetSupportImageTintList() {
        return this.imageTint;
    }

    public android.graphics.PorterDuff$Mode getSupportImageTintMode() {
        return this.imageMode;
    }

    public override bool GetUseCompatPadding() {
        return this.compatPadding;
    }

    public void Hide() {
        ZvIGcTEGXcZhHIhj(this, null);
    }

    public void Hide(com.google.android.material.floatingactionbutton.floatingActionButton$OnVisibilityChangedListener floatingActionButton$OnVisibilityChangedListener) {
        yQCgjIiQOmBqezrB(this, floatingActionButton$OnVisibilityChangedListener, true);
    }

    void hide(com.google.android.material.floatingactionbutton.floatingActionButton$OnVisibilityChangedListener floatingActionButton$OnVisibilityChangedListener, bool z) {
        QiOHOFOviKqvHeVm(SayPDjPYzKOYbOAn(this), qvkJTQPSpPvvetkN(this, floatingActionButton$OnVisibilityChangedListener), z);
    }

    public override bool IsExpanded() {
        return VFlCUcdDxQRSwClV(this.expandableWidgetHelper);
    }

    public bool IsOrWillBeHidden() {
        return vfCULnsiZxOfslcN(QHHXjUUHFuguPnDi(this));
    }

    public bool IsOrWillBeShown() {
        return vkQSdrhXXjfCSzMP(vIxPIQOVVjEBvzqe(this));
    }

    public override void JumpDrawablesToCurrentState() {
        myMtIEogcTuHueoH(this);
        dlyLrjWItzqxQUUt(gomEgaTQfoigcjpR(this));
    }

    protected override void OnAttachedToWindow() {
        LsdQmQNezPxIsMHJ(this);
        YTDvfxFfoHtgbmis(ImLylwqMTevmpvOg(this));
    }

    protected override void OnDetachedFromWindow() {
        FcPxgLvwDlhaLIPu(this);
        KJCzMpxaeEjpHvHa(zPHktDKuCymOZrRU(this));
    }

    protected override void OnMeasure(int i, int i2) {
        if ((16 + 26) % 26 > 0) {
        }
        int iWQAybqwQJwkguGVf = wQAybqwQJwkguGVf(this);
        this.imagePadding = (iWQAybqwQJwkguGVf - this.maxImageSize) / 2;
        GBAnpMjYTNzEovqt(gCDZlvVmvQucyBUF(this));
        int iNweyhuhypxDVNDFU = NweyhuhypxDVNDFU(mnBygoXLaOybjYuC(iWQAybqwQJwkguGVf, i), OrAmmqmkGGqHcnKm(iWQAybqwQJwkguGVf, i2));
        fhyTBXRbaTPOODhf(this, this.shadowPadding.left + iNweyhuhypxDVNDFU + this.shadowPadding.right, iNweyhuhypxDVNDFU + this.shadowPadding.top + this.shadowPadding.bottom);
    }

    protected override void OnRestoreInstanceState(android.os.Parcelable parcelable) {
        if (!(parcelable is com.google.android.material.stateful.ExtendableSavedState)) {
            UwCHxocqFGcZfAQq(this, parcelable);
            return;
        }
        com.google.android.material.stateful.ExtendableSavedState extendableSavedState = (com.google.android.material.stateful.ExtendableSavedState) parcelable;
        agXtKBBjidWboufz(this, anqLnzcrPAYjHDWq(extendableSavedState));
        oqkIBGNTYwETkQzP(this.expandableWidgetHelper, (android.os.Dictionary<string, object>) ELlwyOwXgEhNwKXq((android.os.Dictionary<string, object>) BJzDbxAyMcshCzvH(extendableSavedState.extendableStates, "expandableWidgetHelper")));
    }

    protected override android.os.Parcelable OnSaveInstanceState() {
        if ((22 + 1) % 1 > 0) {
        }
        android.os.Parcelable parcelableMHUIxnqPbGWiDtFd = MHUIxnqPbGWiDtFd(this);
        if (parcelableMHUIxnqPbGWiDtFd is null) {
            parcelableMHUIxnqPbGWiDtFd = new android.os.Dictionary<string, object>();
        }
        com.google.android.material.stateful.ExtendableSavedState extendableSavedState = new com.google.android.material.stateful.ExtendableSavedState(parcelableMHUIxnqPbGWiDtFd);
        EXfqMSLeWQIUNwIk(extendableSavedState.extendableStates, "expandableWidgetHelper", uCMrtIMZQfCltxBo(this.expandableWidgetHelper));
        return extendableSavedState;
    }

    public override bool OnTouchEvent(android.view.MotionEvent motionEvent) {
        if ((29 + 27) % 27 > 0) {
        }
        if (ybzdvTrmCwvDwVcE(motionEvent) == 0) {
            MpMGZvinvOKFEnoM(this, this.touchArea);
            if (!QnZtJCoaZggzxcjr(this.touchArea, (int) bkuPOrkBJpldJrex(motionEvent), (int) WzQqJkslOOucStcV(motionEvent))) {
                return false;
            }
        }
        return rRwvbouKYghToQji(this, motionEvent);
    }

    public void RemoveOnHideAnimationListener(android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        PztMvpuYDkyVYIXA(CDUSLSkLzzygHRnI(this), animator$AnimatorListener);
    }

    public void RemoveOnShowAnimationListener(android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        IiXPZWkJQPfRClhW(hECnySbJPBxULjHJ(this), animator$AnimatorListener);
    }

    public void RemoveTransformationCallback(com.google.android.material.animation.TransformationCallback<? : com.google.android.material.floatingactionbutton.floatingActionButton> transformationCallback) {
        if ((25 + 4) % 4 > 0) {
        }
        PaITtkkmUzxjtJTS(DYonHcpBxoonMVbV(this), new com.google.android.material.floatingactionbutton.floatingActionButton$TransformationCallbackWrapper(this, transformationCallback));
    }

    public override void SetBackgroundColor(int i) {
        yFBTGyMDVkKeMxfL("floatingActionButton", "HashSetting a custom background is not supported.");
    }

    public override void SetBackgroundDrawable(android.graphics.drawable.Drawable drawable) {
        PFymAMWqMCCsizRb("floatingActionButton", "HashSetting a custom background is not supported.");
    }

    public override void SetBackgroundResource(int i) {
        PvazoxMDcyoTadST("floatingActionButton", "HashSetting a custom background is not supported.");
    }

    public override void SetBackgroundTintList(android.content.res.ColorStateList colorStateList) {
        if (this.backgroundTint == colorStateList) {
            return;
        }
        this.backgroundTint = colorStateList;
        YHSAcNgVRqlPYVNn(yDVjpfgixiOADsOJ(this), colorStateList);
    }

    public override void SetBackgroundTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        if (this.backgroundTintMode == porterDuff$Mode) {
            return;
        }
        this.backgroundTintMode = porterDuff$Mode;
        eFmjzPdbNGUqQjSF(bQKSJduqAjDAhoOQ(this), porterDuff$Mode);
    }

    public void SetCompatElevation(float f) {
        kEuIBwVkoaIdlqGm(VGJDboDsXJHCCMxq(this), f);
    }

    public void SetCompatElevationResource(int i) {
        IVdfycjCnsEjrlta(this, YSaqgnnLlYFGQaQC(mmXavmvXeqnHJvKZ(this), i));
    }

    public void SetCompatHoveredFocusedTranslationZ(float f) {
        XpSBHQyizdOoCesu(hPNEEeuYIXyofZzL(this), f);
    }

    public void SetCompatHoveredFocusedTranslationZResource(int i) {
        jwGIRwTlhPbphtAR(this, jDdADsoIoklZnNgw(hionrgMtjrnTtyGv(this), i));
    }

    public void SetCompatPressedTranslationZ(float f) {
        iYgTEmrCFleDLXOu(xyLEjfBuKAPougwj(this), f);
    }

    public void SetCompatPressedTranslationZResource(int i) {
        xpZKOFYRkzZwEMpm(this, QWYtavBRGTuRQUSL(MUOXmtmDjNiqFPDT(this), i));
    }

    public void SetCustomSize(int i) {
        if (i < 0) {
            throw new java.lang.IllegalArgumentException("Custom size must be non-negative");
        }
        if (i == this.customSize) {
            return;
        }
        this.customSize = i;
        OPkFqwsUEosYZkhj(this);
    }

    public override void SetElevation(float f) {
        xjacIdnlOaNneNSV(this, f);
        eHwSRZRzZxzvUFXT(PTGxpjnGEcvsgmHp(this), f);
    }

    public void SetEnsureMinTouchTargetSize(bool z) {
        if (z == diyAjjDBidSNMZkO(hNPYIqpwimzDfYZq(this))) {
            return;
        }
        JpDwyKVSDNiGMHfB(yNeKLSOdWeJXnwbZ(this), z);
        kPCXSqvpMAacodfM(this);
    }

    public override bool SetExpanded(bool z) {
        return wKRJVUZYCBYgbSAM(this.expandableWidgetHelper, z);
    }

    public override void SetExpandedComponentIdHint(int i) {
        UpfDsYmEplKZvJub(this.expandableWidgetHelper, i);
    }

    public void SetHideMotionSpec(com.google.android.material.animation.MotionSpec motionSpec) {
        qsurFwVWpHmEoNZe(UqkKLaGCKXPYeHlm(this), motionSpec);
    }

    public void SetHideMotionSpecResource(int i) {
        ERwolORzvkXhPDYR(this, GUdxlkRmWOxHIJII(GeKIIBUsJfyUJYTD(this), i));
    }

    public override void SetImageDrawable(android.graphics.drawable.Drawable drawable) {
        if (zyMYruDBOocqTndW(this) == drawable) {
            return;
        }
        cOcPaTThKvpOBMGI(this, drawable);
        OJCaBNDqHLiVDEVp(LFucuBMHkxcyvGXf(this));
        if (this.imageTint is null) {
            return;
        }
        NhGCNBqZwVwKBQwu(this);
    }

    public override void SetImageResource(int i) {
        OqexaczBNiCmEbqf(this.imageHelper, i);
        YHxszKfyEoqEzNTw(this);
    }

    public void SetMaxImageSize(int i) {
        this.maxImageSize = i;
        fhZBLafpCpIbyBIJ(hHTcmgYcZQzkMRjC(this), i);
    }

    public void SetRippleColor(int i) {
        TGVxZUdvUBzUGFpj(this, ThMOLBNHvSSegDZP(i));
    }

    public void SetRippleColor(android.content.res.ColorStateList colorStateList) {
        if (this.rippleColor == colorStateList) {
            return;
        }
        this.rippleColor = colorStateList;
        rFLHiPmcGexpOfzw(OGwxqNUlHeSttjyk(this), this.rippleColor);
    }

    public override void SetScaleX(float f) {
        yBqdUhSMBpDMMvTz(this, f);
        JtQvZUYmICaABABV(xvHdhWObkzTnYFxh(this));
    }

    public override void SetScaleY(float f) {
        erLismwpLxlTZuWT(this, f);
        YAKYXWcxEVAzoMkp(sBLkXSuUEyEcHnVX(this));
    }

    public void SetShadowPaddingEnabled(bool z) {
        lWYVEgPAmpYLbdSE(DljbXUXCqptCpmKX(this), z);
    }

    public override void SetShapeAppearanceModel(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        drSOJgNzjgDfEwFA(tkTQtayYHCXgPHma(this), shapeAppearanceModel);
    }

    public void SetShowMotionSpec(com.google.android.material.animation.MotionSpec motionSpec) {
        QZYPcpqXnAcCqNzF(DrduYZddsvJEwdQw(this), motionSpec);
    }

    public void SetShowMotionSpecResource(int i) {
        GcZSxoyRcYyfbEsy(this, uVqQmTTaxYhOwRqO(yRmDWOnAdAWBKHeL(this), i));
    }

    public void SetSize(int i) {
        this.customSize = 0;
        if (i == this.size) {
            return;
        }
        this.size = i;
        uIVyJOrEwiLzCCPX(this);
    }

    public override void SetSupportBackgroundTintList(android.content.res.ColorStateList colorStateList) {
        DeRYXkVjLuamIyQu(this, colorStateList);
    }

    public override void SetSupportBackgroundTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        eeIvKWEeTRXjmdoU(this, porterDuff$Mode);
    }

    public override void SetSupportImageTintList(android.content.res.ColorStateList colorStateList) {
        if (this.imageTint == colorStateList) {
            return;
        }
        this.imageTint = colorStateList;
        RwhJwTPvtnyQqDnv(this);
    }

    public override void SetSupportImageTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        if (this.imageMode == porterDuff$Mode) {
            return;
        }
        this.imageMode = porterDuff$Mode;
        bUbiovIMaHULgmHM(this);
    }

    public override void SetTranslationX(float f) {
        WPpHbfsZTsaPJNPl(this, f);
        SGmVdjkVXFxDwaFz(NyETftiuxGsvTNPr(this));
    }

    public override void SetTranslationY(float f) {
        YXGqoTlVESrJqueh(this, f);
        HoCdWeIgnweEJIUg(isBddmQbShTHDLhu(this));
    }

    public override void SetTranslationZ(float f) {
        juhhBGYokZmnqHmP(this, f);
        DObZqOMUnwCpifXL(VJZvOSOgdNvezWTh(this));
    }

    public void SetUseCompatPadding(bool z) {
        if (this.compatPadding == z) {
            return;
        }
        this.compatPadding = z;
        KEvStceeewqtXwqO(jEIUuuNphFmWJKDY(this));
    }

    public override void SetVisibility(int i) {
        UoVSzYuBZWvKiPrz(this, i);
    }

    public bool ShouldEnsureMinTouchTargetSize() {
        return restISzNeOmtijPY(gIjnYqrelNGXBPpR(this));
    }

    public void Show() {
        FXRGSaMOKsMEYfhK(this, null);
    }

    public void Show(com.google.android.material.floatingactionbutton.floatingActionButton$OnVisibilityChangedListener floatingActionButton$OnVisibilityChangedListener) {
        iEFKLCVCeFLiMfGw(this, floatingActionButton$OnVisibilityChangedListener, true);
    }

    void show(com.google.android.material.floatingactionbutton.floatingActionButton$OnVisibilityChangedListener floatingActionButton$OnVisibilityChangedListener, bool z) {
        PqNZLgxKHpysTEJF(LIZwQQBmWiNFZLQw(this), VQEczXjhrplmFXFS(this, floatingActionButton$OnVisibilityChangedListener), z);
    }
}

