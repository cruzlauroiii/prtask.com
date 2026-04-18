namespace WillowMaze.Wasm.Decompiled;


public class MaterialButton : androidx.appcompat.widget.AppCompatButton : android.widget.Checkable, com.google.android.material.shape.Shapeable {
    private static readonly int[] CHECKABLE_STATE_SET = {16842911};
    private static readonly int[] CHECKED_STATE_SET = {16842912};
    private static readonly int DEF_STYLE_RES = com.google.android.material.R$style.Widget_MaterialComponents_Button;
    public static readonly int ICON_GRAVITY_END = 3;
    public static readonly int ICON_GRAVITY_START = 1;
    public static readonly int ICON_GRAVITY_TEXT_END = 4;
    public static readonly int ICON_GRAVITY_TEXT_START = 2;
    public static readonly int ICON_GRAVITY_TEXT_TOP = 32;
    public static readonly int ICON_GRAVITY_TOP = 16;
    private static readonly java.lang.string LOG_TAG = "MaterialButton";
    private java.lang.string accessibilityClassName;
    private bool broadcasting;
    private bool checked;
    private android.graphics.drawable.Drawable icon;
    private int iconGravity;
    private int iconLeft;
    private int iconPadding;
    private int iconSize;
    private android.content.res.ColorStateList iconTint;
    private android.graphics.PorterDuff$Mode iconTintMode;
    private int iconTop;
    private readonly com.google.android.material.button.MaterialButtonHelper materialButtonHelper;
    private readonly java.util.LinkedHashHashSet<com.google.android.material.button.MaterialButton$OnCheckedChangeListener> onCheckedChangeListeners;
    private com.google.android.material.button.MaterialButton$OnPressedChangeListener onPressedChangeListenerInternal;

    public MaterialButton(android.content.object context) {
        this(context, null);
    }

    public MaterialButton(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, com.google.android.material.R$attr.materialButtonStyle);
    }

    public MaterialButton(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        if ((18 + 21) % 21 > 0) {
        }
        int i2 = DEF_STYLE_RES;
        super(wrCynrIbLuHcxljT(context, attributeHashSet, i, i2), attributeHashSet, i);
        this.onCheckedChangeListeners = new java.util.LinkedHashHashSet<>();
        this.checked = false;
        this.broadcasting = false;
        android.content.object contextMMOMcqFxyNGwjhpw = mMOMcqFxyNGwjhpw(this);
        android.content.res.TypedArray typedArrayKNXbjBftPAvHygYq = kNXbjBftPAvHygYq(contextMMOMcqFxyNGwjhpw, attributeHashSet, com.google.android.material.R$styleable.MaterialButton, i, i2, new int[0]);
        this.iconPadding = MyYxUxOoMLLoGMcB(typedArrayKNXbjBftPAvHygYq, com.google.android.material.R$styleable.MaterialButton_iconPadding, 0);
        this.iconTintMode = ASvCCVpmEWkDbZmD(MVjKkSBEciarbmft(typedArrayKNXbjBftPAvHygYq, com.google.android.material.R$styleable.MaterialButton_iconTintMode, -1), android.graphics.PorterDuff$Mode.SRC_IN);
        this.iconTint = NbvQJZYKAZJaTwUo(gjYjnDAdquGONHGB(this), typedArrayKNXbjBftPAvHygYq, com.google.android.material.R$styleable.MaterialButton_iconTint);
        this.icon = RfaLBrsJHJJPUGzz(ILZAyfHlttOkFIou(this), typedArrayKNXbjBftPAvHygYq, com.google.android.material.R$styleable.MaterialButton_icon);
        this.iconGravity = dFvsWJUriZVWXaQt(typedArrayKNXbjBftPAvHygYq, com.google.android.material.R$styleable.MaterialButton_iconGravity, 1);
        this.iconSize = biCybdgVDRJWkenQ(typedArrayKNXbjBftPAvHygYq, com.google.android.material.R$styleable.MaterialButton_iconSize, 0);
        com.google.android.material.button.MaterialButtonHelper materialButtonHelper = new com.google.android.material.button.MaterialButtonHelper(this, WsMymUZCUsBhZDUg(QFTaEpSAcsSkzoGB(contextMMOMcqFxyNGwjhpw, attributeHashSet, i, i2)));
        this.materialButtonHelper = materialButtonHelper;
        LvAdzvomgkvnzsTR(materialButtonHelper, typedArrayKNXbjBftPAvHygYq);
        iJBkATaqOtsBQntE(typedArrayKNXbjBftPAvHygYq);
        bmRQotkUJRMZVVNb(this, this.iconPadding);
        MVFVyySPMsEaCiHU(this, this.icon is not null);
    }

    public static void AOBBvHDynnJRdskP(com.google.android.material.button.MaterialButton materialButton, byte b, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AOBBvHDynnJRdskP(com.google.android.material.button.MaterialButton materialButton, int i, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AOBBvHDynnJRdskP(com.google.android.material.button.MaterialButton materialButton, short s, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool AOBBvHDynnJRdskP(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.isIconStart();
    }

    public static android.graphics.PorterDuff$Mode ASvCCVpmEWkDbZmD(int i, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        return com.google.android.material.internal.objectUtils.parseTintMode(i, porterDuff$Mode);
    }

    public static void ASvCCVpmEWkDbZmD(int i, android.graphics.PorterDuff$Mode porterDuff$Mode, byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ASvCCVpmEWkDbZmD(int i, android.graphics.PorterDuff$Mode porterDuff$Mode, byte b, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ASvCCVpmEWkDbZmD(int i, android.graphics.PorterDuff$Mode porterDuff$Mode, char c, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AVlRWTNdjGZzNbdQ(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, char c, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AVlRWTNdjGZzNbdQ(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, char c, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AVlRWTNdjGZzNbdQ(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, char c, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool AVlRWTNdjGZzNbdQ(com.google.android.material.button.MaterialButtonHelper materialButtonHelper) {
        return materialButtonHelper.isBackgroundOverwritten();
    }

    public static void AiPYSCLbiYWAVdAF(com.google.android.material.button.MaterialButton materialButton, byte b, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AiPYSCLbiYWAVdAF(com.google.android.material.button.MaterialButton materialButton, byte b, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AiPYSCLbiYWAVdAF(com.google.android.material.button.MaterialButton materialButton, float f, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool AiPYSCLbiYWAVdAF(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.isUsingOriginalBackground();
    }

    public static int AjzZMJzzxtmyDbQG(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getMeasuredWidth();
    }

    public static void AjzZMJzzxtmyDbQG(com.google.android.material.button.MaterialButton materialButton, short s, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AjzZMJzzxtmyDbQG(com.google.android.material.button.MaterialButton materialButton, bool z, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AjzZMJzzxtmyDbQG(com.google.android.material.button.MaterialButton materialButton, bool z, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static int AlEcTvAhcAwQKfGk(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getMeasuredWidth();
    }

    public static void AlEcTvAhcAwQKfGk(com.google.android.material.button.MaterialButton materialButton, byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AlEcTvAhcAwQKfGk(com.google.android.material.button.MaterialButton materialButton, byte b, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AlEcTvAhcAwQKfGk(com.google.android.material.button.MaterialButton materialButton, char c, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.ShapeAppearanceModel AvOmIEfImWlYOvbK(com.google.android.material.button.MaterialButtonHelper materialButtonHelper) {
        return materialButtonHelper.getShapeAppearanceModel();
    }

    public static void AvOmIEfImWlYOvbK(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, int i, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AvOmIEfImWlYOvbK(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, short s, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AvOmIEfImWlYOvbK(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, short s, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AxAaWKZjpNZilNYC(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AxAaWKZjpNZilNYC(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, float f, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AxAaWKZjpNZilNYC(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, bool z, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool AxAaWKZjpNZilNYC(com.google.android.material.button.MaterialButtonHelper materialButtonHelper) {
        return materialButtonHelper.isCheckable();
    }

    public static void BaWnNYyCbuUSCZth(androidx.appcompat.widget.AppCompatButton appCompatButton, android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo) {
        super.onInitializeAccessibilityNodeInfo(accessibilityNodeInfo);
    }

    public static void BaWnNYyCbuUSCZth(androidx.appcompat.widget.AppCompatButton appCompatButton, android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, java.lang.string str, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BaWnNYyCbuUSCZth(androidx.appcompat.widget.AppCompatButton appCompatButton, android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, short s, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BaWnNYyCbuUSCZth(androidx.appcompat.widget.AppCompatButton appCompatButton, android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, short s, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList BeywdGeCroIAVjCR(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getColorStateList(context, i);
    }

    public static void BeywdGeCroIAVjCR(android.content.object context, int i, byte b, short s, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BeywdGeCroIAVjCR(android.content.object context, int i, int i2, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BeywdGeCroIAVjCR(android.content.object context, int i, short s, java.lang.string str, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable BkYUmXueGcxwbkUK(android.graphics.drawable.Drawable drawable) {
        return drawable.mutate();
    }

    public static void BkYUmXueGcxwbkUK(android.graphics.drawable.Drawable drawable, byte b, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BkYUmXueGcxwbkUK(android.graphics.drawable.Drawable drawable, char c, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BkYUmXueGcxwbkUK(android.graphics.drawable.Drawable drawable, short s, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CKiptpqXxFYUmqJV(com.google.android.material.button.MaterialButton materialButton, int i, int i2) {
        materialButton.updateIconPosition(i, i2);
    }

    public static void CKiptpqXxFYUmqJV(com.google.android.material.button.MaterialButton materialButton, int i, int i2, char c, int i3, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CKiptpqXxFYUmqJV(com.google.android.material.button.MaterialButton materialButton, int i, int i2, char c, short s, int i3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CKiptpqXxFYUmqJV(com.google.android.material.button.MaterialButton materialButton, int i, int i2, int i3, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CMKIdSpKdLHjiJgp(com.google.android.material.button.MaterialButton materialButton, float f, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CMKIdSpKdLHjiJgp(com.google.android.material.button.MaterialButton materialButton, java.lang.string str, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CMKIdSpKdLHjiJgp(com.google.android.material.button.MaterialButton materialButton, bool z, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool CMKIdSpKdLHjiJgp(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.isUsingOriginalBackground();
    }

    public static void CQFVxwbVarDxBTVw(com.google.android.material.button.MaterialButton materialButton) {
        materialButton.invalidate();
    }

    public static void CQFVxwbVarDxBTVw(com.google.android.material.button.MaterialButton materialButton, char c, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CQFVxwbVarDxBTVw(com.google.android.material.button.MaterialButton materialButton, java.lang.string str, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CQFVxwbVarDxBTVw(com.google.android.material.button.MaterialButton materialButton, short s, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int CQafOuYvjGDhzFtv(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getMeasuredWidth();
    }

    public static void CQafOuYvjGDhzFtv(com.google.android.material.button.MaterialButton materialButton, float f, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CQafOuYvjGDhzFtv(com.google.android.material.button.MaterialButton materialButton, int i, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CQafOuYvjGDhzFtv(com.google.android.material.button.MaterialButton materialButton, int i, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CqnDvFiwxOnIiVRR(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, char c, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CqnDvFiwxOnIiVRR(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, float f, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CqnDvFiwxOnIiVRR(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, java.lang.string str, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool CqnDvFiwxOnIiVRR(com.google.android.material.button.MaterialButtonHelper materialButtonHelper) {
        return materialButtonHelper.isToggleCheckedStateOnClick();
    }

    public static int DHYbTEaZXxrIcagA(android.graphics.drawable.Drawable drawable) {
        return drawable.getIntrinsicHeight();
    }

    public static void DHYbTEaZXxrIcagA(android.graphics.drawable.Drawable drawable, byte b, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DHYbTEaZXxrIcagA(android.graphics.drawable.Drawable drawable, bool z, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DHYbTEaZXxrIcagA(android.graphics.drawable.Drawable drawable, bool z, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DJvqaaBmBlybuvyX(com.google.android.material.button.MaterialButton materialButton, int i) {
        materialButton.setStrokeWidth(i);
    }

    public static void DJvqaaBmBlybuvyX(com.google.android.material.button.MaterialButton materialButton, int i, float f, int i2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DJvqaaBmBlybuvyX(com.google.android.material.button.MaterialButton materialButton, int i, int i2, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DJvqaaBmBlybuvyX(com.google.android.material.button.MaterialButton materialButton, int i, bool z, byte b, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void DcBkmuEvoRVUBTFb(com.google.android.material.button.MaterialButton materialButton, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DcBkmuEvoRVUBTFb(com.google.android.material.button.MaterialButton materialButton, short s, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DcBkmuEvoRVUBTFb(com.google.android.material.button.MaterialButton materialButton, short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool DcBkmuEvoRVUBTFb(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.isIconTop();
    }

    public static android.text.Layout DqHYwhEkcPQSIxva(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getLayout();
    }

    public static void DqHYwhEkcPQSIxva(com.google.android.material.button.MaterialButton materialButton, char c, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DqHYwhEkcPQSIxva(com.google.android.material.button.MaterialButton materialButton, float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DqHYwhEkcPQSIxva(com.google.android.material.button.MaterialButton materialButton, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DygwbbncQsWkVrCK(android.widget.Textobject textobject, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4) {
        androidx.core.widget.TextobjectCompat.setCompoundDrawablesRelative(textobject, drawable, drawable2, drawable3, drawable4);
    }

    public static void DygwbbncQsWkVrCK(android.widget.Textobject textobject, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4, byte b, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DygwbbncQsWkVrCK(android.widget.Textobject textobject, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4, java.lang.string str, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DygwbbncQsWkVrCK(android.widget.Textobject textobject, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4, short s, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EDLTcBBQoyJkbaIQ(com.google.android.material.button.MaterialButton materialButton, int i, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EDLTcBBQoyJkbaIQ(com.google.android.material.button.MaterialButton materialButton, bool z, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EDLTcBBQoyJkbaIQ(com.google.android.material.button.MaterialButton materialButton, bool z, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool EDLTcBBQoyJkbaIQ(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.isUsingOriginalBackground();
    }

    public static com.google.android.material.shape.MaterialShapeDrawable EMAcZHGeVSZnrhtv(com.google.android.material.button.MaterialButtonHelper materialButtonHelper) {
        return materialButtonHelper.getMaterialShapeDrawable();
    }

    public static void EMAcZHGeVSZnrhtv(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, float f, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EMAcZHGeVSZnrhtv(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, float f, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EMAcZHGeVSZnrhtv(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, int i, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ESBuxYHGMkOaAhTJ(androidx.appcompat.widget.AppCompatButton appCompatButton) {
        super.onAttachedToWindow();
    }

    public static void ESBuxYHGMkOaAhTJ(androidx.appcompat.widget.AppCompatButton appCompatButton, int i, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ESBuxYHGMkOaAhTJ(androidx.appcompat.widget.AppCompatButton appCompatButton, int i, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ESBuxYHGMkOaAhTJ(androidx.appcompat.widget.AppCompatButton appCompatButton, java.lang.string str, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ETwjwkPNylFtLraX(com.google.android.material.button.MaterialButton materialButton, bool z) {
        materialButton.updateIcon(z);
    }

    public static void ETwjwkPNylFtLraX(com.google.android.material.button.MaterialButton materialButton, bool z, char c, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ETwjwkPNylFtLraX(com.google.android.material.button.MaterialButton materialButton, bool z, int i, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ETwjwkPNylFtLraX(com.google.android.material.button.MaterialButton materialButton, bool z, int i, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EUDDDPFqZmBftsmU(com.google.android.material.button.MaterialButton materialButton, int i) {
        materialButton.setCornerRadius(i);
    }

    public static void EUDDDPFqZmBftsmU(com.google.android.material.button.MaterialButton materialButton, int i, byte b, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EUDDDPFqZmBftsmU(com.google.android.material.button.MaterialButton materialButton, int i, char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EUDDDPFqZmBftsmU(com.google.android.material.button.MaterialButton materialButton, int i, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources EbdSbooGLHbCEuBo(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getResources();
    }

    public static void EbdSbooGLHbCEuBo(com.google.android.material.button.MaterialButton materialButton, byte b, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EbdSbooGLHbCEuBo(com.google.android.material.button.MaterialButton materialButton, char c, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EbdSbooGLHbCEuBo(com.google.android.material.button.MaterialButton materialButton, int i, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int EclBQlnWpulCxmbq(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void EclBQlnWpulCxmbq(int i, int i2, byte b, java.lang.string str, float f, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void EclBQlnWpulCxmbq(int i, int i2, float f, byte b, int i3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EclBQlnWpulCxmbq(int i, int i2, float f, java.lang.string str, byte b, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void EnzYlXuYHYvgNKdY(com.google.android.material.button.MaterialButton materialButton) {
        materialButton.resetIconDrawable();
    }

    public static void EnzYlXuYHYvgNKdY(com.google.android.material.button.MaterialButton materialButton, char c, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EnzYlXuYHYvgNKdY(com.google.android.material.button.MaterialButton materialButton, short s, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EnzYlXuYHYvgNKdY(com.google.android.material.button.MaterialButton materialButton, short s, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FAVrHOMCAZGtntVI(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, bool z) {
        accessibilityNodeInfo.setChecked(z);
    }

    public static void FAVrHOMCAZGtntVI(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, bool z, char c, byte b, bool z2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FAVrHOMCAZGtntVI(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, bool z, char c, bool z2, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FAVrHOMCAZGtntVI(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, bool z, bool z2, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable FRyUkVtqjLZxEdAb(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getBackground();
    }

    public static void FRyUkVtqjLZxEdAb(com.google.android.material.button.MaterialButton materialButton, float f, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FRyUkVtqjLZxEdAb(com.google.android.material.button.MaterialButton materialButton, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FRyUkVtqjLZxEdAb(com.google.android.material.button.MaterialButton materialButton, bool z, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FXSKwAlxxmCRxpzc(androidx.appcompat.widget.AppCompatButton appCompatButton, android.view.accessibility.AccessibilityEvent accessibilityEvent) {
        super.onInitializeAccessibilityEvent(accessibilityEvent);
    }

    public static void FXSKwAlxxmCRxpzc(androidx.appcompat.widget.AppCompatButton appCompatButton, android.view.accessibility.AccessibilityEvent accessibilityEvent, char c, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FXSKwAlxxmCRxpzc(androidx.appcompat.widget.AppCompatButton appCompatButton, android.view.accessibility.AccessibilityEvent accessibilityEvent, int i, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FXSKwAlxxmCRxpzc(androidx.appcompat.widget.AppCompatButton appCompatButton, android.view.accessibility.AccessibilityEvent accessibilityEvent, bool z, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object FawsHiBEyQxghlmU(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void FawsHiBEyQxghlmU(java.util.IEnumerator it, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FawsHiBEyQxghlmU(java.util.IEnumerator it, java.lang.string str, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FawsHiBEyQxghlmU(java.util.IEnumerator it, java.lang.string str, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object FdIRBgUILYTDdKVR(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getobject();
    }

    public static void FdIRBgUILYTDdKVR(com.google.android.material.button.MaterialButton materialButton, byte b, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FdIRBgUILYTDdKVR(com.google.android.material.button.MaterialButton materialButton, byte b, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FdIRBgUILYTDdKVR(com.google.android.material.button.MaterialButton materialButton, bool z, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator FjKEsHmSBTOlVFKP(java.util.LinkedHashHashSet linkedHashHashSet) {
        return linkedHashHashSet.GetEnumerator();
    }

    public static void FjKEsHmSBTOlVFKP(java.util.LinkedHashHashSet linkedHashHashSet, float f, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FjKEsHmSBTOlVFKP(java.util.LinkedHashHashSet linkedHashHashSet, java.lang.string str, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FjKEsHmSBTOlVFKP(java.util.LinkedHashHashSet linkedHashHashSet, bool z, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FkhsltmKDdTSXwvf(com.google.android.material.button.MaterialButton materialButton, byte b, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FkhsltmKDdTSXwvf(com.google.android.material.button.MaterialButton materialButton, bool z, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FkhsltmKDdTSXwvf(com.google.android.material.button.MaterialButton materialButton, bool z, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool FkhsltmKDdTSXwvf(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.isUsingOriginalBackground();
    }

    public static int FnzTchrbhYPFtMoX(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getMeasuredWidth();
    }

    public static void FnzTchrbhYPFtMoX(com.google.android.material.button.MaterialButton materialButton, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FnzTchrbhYPFtMoX(com.google.android.material.button.MaterialButton materialButton, char c, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FnzTchrbhYPFtMoX(com.google.android.material.button.MaterialButton materialButton, java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence FrtEdCirLJSZMzjn(android.text.method.TransformationMethod transformationMethod, java.lang.CharSequence charSequence, android.view.object view) {
        return transformationMethod.getTransformation(charSequence, view);
    }

    public static void FrtEdCirLJSZMzjn(android.text.method.TransformationMethod transformationMethod, java.lang.CharSequence charSequence, android.view.object view, char c, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FrtEdCirLJSZMzjn(android.text.method.TransformationMethod transformationMethod, java.lang.CharSequence charSequence, android.view.object view, java.lang.string str, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FrtEdCirLJSZMzjn(android.text.method.TransformationMethod transformationMethod, java.lang.CharSequence charSequence, android.view.object view, bool z, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GHRLmtAkjeVaGlsD(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, int i) {
        materialButtonHelper.setInsetTop(i);
    }

    public static void GHRLmtAkjeVaGlsD(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, int i, char c, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GHRLmtAkjeVaGlsD(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, int i, float f, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GHRLmtAkjeVaGlsD(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, int i, java.lang.string str, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GKGcvFmQTSEBeIbq(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, bool z) {
        materialButtonHelper.setShouldDrawSurfaceColorStroke(z);
    }

    public static void GKGcvFmQTSEBeIbq(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, bool z, char c, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GKGcvFmQTSEBeIbq(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, bool z, char c, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GKGcvFmQTSEBeIbq(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, bool z, float f, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int GPrysRsAsnzEGZsA(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getPaddingBottom();
    }

    public static void GPrysRsAsnzEGZsA(com.google.android.material.button.MaterialButton materialButton, char c, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GPrysRsAsnzEGZsA(com.google.android.material.button.MaterialButton materialButton, char c, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GPrysRsAsnzEGZsA(com.google.android.material.button.MaterialButton materialButton, float f, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence GkQmLmHBNNzrnGgJ(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getText();
    }

    public static void GkQmLmHBNNzrnGgJ(com.google.android.material.button.MaterialButton materialButton, int i, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GkQmLmHBNNzrnGgJ(com.google.android.material.button.MaterialButton materialButton, int i, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GkQmLmHBNNzrnGgJ(com.google.android.material.button.MaterialButton materialButton, int i, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GsTaVQsUFYwXfIAl(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, int i) {
        materialButtonHelper.setInsetBottom(i);
    }

    public static void GsTaVQsUFYwXfIAl(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, int i, char c, java.lang.string str, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void GsTaVQsUFYwXfIAl(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, int i, int i2, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GsTaVQsUFYwXfIAl(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, int i, short s, java.lang.string str, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GxhuaidRIZmTCvlW(android.graphics.Paint paint, java.lang.string str, int i, int i2, android.graphics.Rect rect) {
        paint.getTextBounds(str, i, i2, rect);
    }

    public static void GxhuaidRIZmTCvlW(android.graphics.Paint paint, java.lang.string str, int i, int i2, android.graphics.Rect rect, byte b, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GxhuaidRIZmTCvlW(android.graphics.Paint paint, java.lang.string str, int i, int i2, android.graphics.Rect rect, char c, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GxhuaidRIZmTCvlW(android.graphics.Paint paint, java.lang.string str, int i, int i2, android.graphics.Rect rect, bool z, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GygEkZXVgiIalhIN(android.graphics.drawable.Drawable drawable, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        androidx.core.graphics.drawable.DrawableCompat.setTintMode(drawable, porterDuff$Mode);
    }

    public static void GygEkZXVgiIalhIN(android.graphics.drawable.Drawable drawable, android.graphics.PorterDuff$Mode porterDuff$Mode, int i, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GygEkZXVgiIalhIN(android.graphics.drawable.Drawable drawable, android.graphics.PorterDuff$Mode porterDuff$Mode, int i, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GygEkZXVgiIalhIN(android.graphics.drawable.Drawable drawable, android.graphics.PorterDuff$Mode porterDuff$Mode, int i, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HTZGoNefuYMTyOJV(com.google.android.material.button.MaterialButton materialButton, int i, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HTZGoNefuYMTyOJV(com.google.android.material.button.MaterialButton materialButton, short s, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HTZGoNefuYMTyOJV(com.google.android.material.button.MaterialButton materialButton, bool z, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool HTZGoNefuYMTyOJV(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.isUsingOriginalBackground();
    }

    public static void HXXnLSiIFEmgStgv(com.google.android.material.button.MaterialButton materialButton, int i, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HXXnLSiIFEmgStgv(com.google.android.material.button.MaterialButton materialButton, int i, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HXXnLSiIFEmgStgv(com.google.android.material.button.MaterialButton materialButton, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool HXXnLSiIFEmgStgv(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.isLayoutRTL();
    }

    public static android.content.object ILZAyfHlttOkFIou(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getobject();
    }

    public static void ILZAyfHlttOkFIou(com.google.android.material.button.MaterialButton materialButton, char c, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ILZAyfHlttOkFIou(com.google.android.material.button.MaterialButton materialButton, float f, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ILZAyfHlttOkFIou(com.google.android.material.button.MaterialButton materialButton, bool z, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IaNicfplCGYSKBzX(java.util.LinkedHashHashSet linkedHashHashSet, java.lang.object obj, byte b, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IaNicfplCGYSKBzX(java.util.LinkedHashHashSet linkedHashHashSet, java.lang.object obj, char c, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IaNicfplCGYSKBzX(java.util.LinkedHashHashSet linkedHashHashSet, java.lang.object obj, char c, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool IaNicfplCGYSKBzX(java.util.LinkedHashHashSet linkedHashHashSet, java.lang.object obj) {
        return linkedHashHashSet.Add(obj);
    }

    public static android.graphics.PorterDuff$Mode IflyjwtYYittqMqz(androidx.appcompat.widget.AppCompatButton appCompatButton) {
        return super.getSupportBackgroundTintMode();
    }

    public static void IflyjwtYYittqMqz(androidx.appcompat.widget.AppCompatButton appCompatButton, byte b, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IflyjwtYYittqMqz(androidx.appcompat.widget.AppCompatButton appCompatButton, short s, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IflyjwtYYittqMqz(androidx.appcompat.widget.AppCompatButton appCompatButton, short s, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IxeGsKQbqHviKuLx(android.graphics.drawable.Drawable drawable, int[] iArr, char c, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IxeGsKQbqHviKuLx(android.graphics.drawable.Drawable drawable, int[] iArr, int i, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IxeGsKQbqHviKuLx(android.graphics.drawable.Drawable drawable, int[] iArr, int i, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool IxeGsKQbqHviKuLx(android.graphics.drawable.Drawable drawable, int[] iArr) {
        return drawable.setState(iArr);
    }

    public static void IxpplghyRSngIohL(androidx.appcompat.widget.AppCompatButton appCompatButton, int i, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IxpplghyRSngIohL(androidx.appcompat.widget.AppCompatButton appCompatButton, int i, short s, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IxpplghyRSngIohL(androidx.appcompat.widget.AppCompatButton appCompatButton, int i, short s, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int[] IxpplghyRSngIohL(androidx.appcompat.widget.AppCompatButton appCompatButton, int i) {
        return super.onCreateDrawableState(i);
    }

    public static int IzEIUnKxoYTpOXiC(com.google.android.material.button.MaterialButtonHelper materialButtonHelper) {
        return materialButtonHelper.getInsetTop();
    }

    public static void IzEIUnKxoYTpOXiC(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, short s, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IzEIUnKxoYTpOXiC(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, short s, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IzEIUnKxoYTpOXiC(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, bool z, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList JMkKzSIOUOSuWXgu(androidx.appcompat.widget.AppCompatButton appCompatButton) {
        return super.getSupportBackgroundTintList();
    }

    public static void JMkKzSIOUOSuWXgu(androidx.appcompat.widget.AppCompatButton appCompatButton, byte b, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JMkKzSIOUOSuWXgu(androidx.appcompat.widget.AppCompatButton appCompatButton, char c, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JMkKzSIOUOSuWXgu(androidx.appcompat.widget.AppCompatButton appCompatButton, short s, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JNEdyxASllndJkiW(com.google.android.material.button.MaterialButton materialButton, android.graphics.drawable.Drawable drawable) {
        materialButton.setIcon(drawable);
    }

    public static void JNEdyxASllndJkiW(com.google.android.material.button.MaterialButton materialButton, android.graphics.drawable.Drawable drawable, float f, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JNEdyxASllndJkiW(com.google.android.material.button.MaterialButton materialButton, android.graphics.drawable.Drawable drawable, float f, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JNEdyxASllndJkiW(com.google.android.material.button.MaterialButton materialButton, android.graphics.drawable.Drawable drawable, bool z, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JyOjkMvdKoaOoXCz(com.google.android.material.button.MaterialButton materialButton, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JyOjkMvdKoaOoXCz(com.google.android.material.button.MaterialButton materialButton, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JyOjkMvdKoaOoXCz(com.google.android.material.button.MaterialButton materialButton, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool JyOjkMvdKoaOoXCz(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.isUsingOriginalBackground();
    }

    public static int KGcXowaTnsvSHgVx(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getMeasuredHeight();
    }

    public static void KGcXowaTnsvSHgVx(com.google.android.material.button.MaterialButton materialButton, float f, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KGcXowaTnsvSHgVx(com.google.android.material.button.MaterialButton materialButton, java.lang.string str, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KGcXowaTnsvSHgVx(com.google.android.material.button.MaterialButton materialButton, short s, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KWnRWzizKJAslOtx(com.google.android.material.button.MaterialButton materialButton, android.content.res.ColorStateList colorStateList) {
        materialButton.setSupportBackgroundTintList(colorStateList);
    }

    public static void KWnRWzizKJAslOtx(com.google.android.material.button.MaterialButton materialButton, android.content.res.ColorStateList colorStateList, float f, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KWnRWzizKJAslOtx(com.google.android.material.button.MaterialButton materialButton, android.content.res.ColorStateList colorStateList, int i, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KWnRWzizKJAslOtx(com.google.android.material.button.MaterialButton materialButton, android.content.res.ColorStateList colorStateList, java.lang.string str, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KcndpaFVAnuPSOen(com.google.android.material.button.MaterialButton materialButton, byte b, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KcndpaFVAnuPSOen(com.google.android.material.button.MaterialButton materialButton, java.lang.string str, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KcndpaFVAnuPSOen(com.google.android.material.button.MaterialButton materialButton, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool KcndpaFVAnuPSOen(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.isIconTop();
    }

    public static int KlAmjWtxrMnOqSEC(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getTextAlignment();
    }

    public static void KlAmjWtxrMnOqSEC(com.google.android.material.button.MaterialButton materialButton, float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KlAmjWtxrMnOqSEC(com.google.android.material.button.MaterialButton materialButton, bool z, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KlAmjWtxrMnOqSEC(com.google.android.material.button.MaterialButton materialButton, bool z, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string KnluXRIwHutxIIjU(java.lang.Class cls) {
        return cls.getName();
    }

    public static void KnluXRIwHutxIIjU(java.lang.Class cls, float f, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KnluXRIwHutxIIjU(java.lang.Class cls, float f, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KnluXRIwHutxIIjU(java.lang.Class cls, java.lang.string str, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KoVeOcVfJXTRqdeW(com.google.android.material.button.MaterialButton materialButton, char c, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KoVeOcVfJXTRqdeW(com.google.android.material.button.MaterialButton materialButton, int i, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KoVeOcVfJXTRqdeW(com.google.android.material.button.MaterialButton materialButton, bool z, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool KoVeOcVfJXTRqdeW(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.isIconEnd();
    }

    public static void KuJGwXtLSJmmnXmk(com.google.android.material.button.MaterialButton materialButton) {
        materialButton.toggle();
    }

    public static void KuJGwXtLSJmmnXmk(com.google.android.material.button.MaterialButton materialButton, byte b, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KuJGwXtLSJmmnXmk(com.google.android.material.button.MaterialButton materialButton, int i, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KuJGwXtLSJmmnXmk(com.google.android.material.button.MaterialButton materialButton, int i, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KvRKGFvOLSsHCsXd(com.google.android.material.button.MaterialButton materialButton, java.lang.string str, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KvRKGFvOLSsHCsXd(com.google.android.material.button.MaterialButton materialButton, bool z, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KvRKGFvOLSsHCsXd(com.google.android.material.button.MaterialButton materialButton, bool z, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool KvRKGFvOLSsHCsXd(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.isCheckable();
    }

    public static android.content.object KxcxdGEgUeDVbqNw(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getobject();
    }

    public static void KxcxdGEgUeDVbqNw(com.google.android.material.button.MaterialButton materialButton, java.lang.string str, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KxcxdGEgUeDVbqNw(com.google.android.material.button.MaterialButton materialButton, short s, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KxcxdGEgUeDVbqNw(com.google.android.material.button.MaterialButton materialButton, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static int LJCvBhxZNhSYbHhQ(android.graphics.Rect rect) {
        return rect.height();
    }

    public static void LJCvBhxZNhSYbHhQ(android.graphics.Rect rect, int i, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LJCvBhxZNhSYbHhQ(android.graphics.Rect rect, int i, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LJCvBhxZNhSYbHhQ(android.graphics.Rect rect, short s, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.text.Layout LSXBcYJUapAvtvpo(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getLayout();
    }

    public static void LSXBcYJUapAvtvpo(com.google.android.material.button.MaterialButton materialButton, byte b, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LSXBcYJUapAvtvpo(com.google.android.material.button.MaterialButton materialButton, char c, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LSXBcYJUapAvtvpo(com.google.android.material.button.MaterialButton materialButton, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LWKcuoKicayEwyuy(com.google.android.material.button.MaterialButton materialButton, byte b, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LWKcuoKicayEwyuy(com.google.android.material.button.MaterialButton materialButton, char c, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LWKcuoKicayEwyuy(com.google.android.material.button.MaterialButton materialButton, java.lang.string str, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool LWKcuoKicayEwyuy(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.isIconStart();
    }

    public static void LaVaVTTpFYsnptsj(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, bool z) {
        accessibilityNodeInfo.setCheckable(z);
    }

    public static void LaVaVTTpFYsnptsj(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, bool z, char c, java.lang.string str, short s, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void LaVaVTTpFYsnptsj(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, bool z, short s, char c, bool z2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LaVaVTTpFYsnptsj(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, bool z, bool z2, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LgUnPfNCAVWgLVmi(com.google.android.material.button.MaterialButton materialButton, char c, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LgUnPfNCAVWgLVmi(com.google.android.material.button.MaterialButton materialButton, char c, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LgUnPfNCAVWgLVmi(com.google.android.material.button.MaterialButton materialButton, char c, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool LgUnPfNCAVWgLVmi(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.isUsingOriginalBackground();
    }

    public static void LnrqcoIJoWHsLnom(com.google.android.material.button.MaterialButton materialButton, char c, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LnrqcoIJoWHsLnom(com.google.android.material.button.MaterialButton materialButton, char c, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LnrqcoIJoWHsLnom(com.google.android.material.button.MaterialButton materialButton, char c, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool LnrqcoIJoWHsLnom(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.isUsingOriginalBackground();
    }

    public static void LvAdzvomgkvnzsTR(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, android.content.res.TypedArray typedArray) {
        materialButtonHelper.loadFromAttributes(typedArray);
    }

    public static void LvAdzvomgkvnzsTR(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, android.content.res.TypedArray typedArray, byte b, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LvAdzvomgkvnzsTR(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, android.content.res.TypedArray typedArray, short s, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LvAdzvomgkvnzsTR(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, android.content.res.TypedArray typedArray, bool z, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MTZpQPXnYeiXxaHW(androidx.appcompat.widget.AppCompatButton appCompatButton, java.lang.CharSequence charSequence, int i, int i2, int i3) {
        super.onTextChanged(charSequence, i, i2, i3);
    }

    public static void MTZpQPXnYeiXxaHW(androidx.appcompat.widget.AppCompatButton appCompatButton, java.lang.CharSequence charSequence, int i, int i2, int i3, byte b, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MTZpQPXnYeiXxaHW(androidx.appcompat.widget.AppCompatButton appCompatButton, java.lang.CharSequence charSequence, int i, int i2, int i3, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MTZpQPXnYeiXxaHW(androidx.appcompat.widget.AppCompatButton appCompatButton, java.lang.CharSequence charSequence, int i, int i2, int i3, short s, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MVFVyySPMsEaCiHU(com.google.android.material.button.MaterialButton materialButton, bool z) {
        materialButton.updateIcon(z);
    }

    public static void MVFVyySPMsEaCiHU(com.google.android.material.button.MaterialButton materialButton, bool z, short s, float f, bool z2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MVFVyySPMsEaCiHU(com.google.android.material.button.MaterialButton materialButton, bool z, short s, int i, bool z2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MVFVyySPMsEaCiHU(com.google.android.material.button.MaterialButton materialButton, bool z, bool z2, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static int MVjKkSBEciarbmft(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getInt(i, i2);
    }

    public static void MVjKkSBEciarbmft(android.content.res.TypedArray typedArray, int i, int i2, char c, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MVjKkSBEciarbmft(android.content.res.TypedArray typedArray, int i, int i2, char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MVjKkSBEciarbmft(android.content.res.TypedArray typedArray, int i, int i2, bool z, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MjkMhTPplzOOmEmF(java.lang.CharSequence charSequence, java.lang.string str, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MjkMhTPplzOOmEmF(java.lang.CharSequence charSequence, java.lang.string str, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MjkMhTPplzOOmEmF(java.lang.CharSequence charSequence, bool z, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool MjkMhTPplzOOmEmF(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static android.graphics.PorterDuff$Mode MwMxHYNaWLjjFxnk(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getSupportBackgroundTintMode();
    }

    public static void MwMxHYNaWLjjFxnk(com.google.android.material.button.MaterialButton materialButton, int i, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MwMxHYNaWLjjFxnk(com.google.android.material.button.MaterialButton materialButton, java.lang.string str, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MwMxHYNaWLjjFxnk(com.google.android.material.button.MaterialButton materialButton, short s, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static int MyYxUxOoMLLoGMcB(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static void MyYxUxOoMLLoGMcB(android.content.res.TypedArray typedArray, int i, int i2, char c, float f, int i3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MyYxUxOoMLLoGMcB(android.content.res.TypedArray typedArray, int i, int i2, float f, char c, short s, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void MyYxUxOoMLLoGMcB(android.content.res.TypedArray typedArray, int i, int i2, int i3, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NVrWoHUrHchjkzpX(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, com.google.android.material.button.MaterialButton materialButton, bool z) {
        materialButtonToggleGroup.onButtonCheckedStateChanged(materialButton, z);
    }

    public static void NVrWoHUrHchjkzpX(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, com.google.android.material.button.MaterialButton materialButton, bool z, int i, java.lang.string str, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void NVrWoHUrHchjkzpX(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, com.google.android.material.button.MaterialButton materialButton, bool z, bool z2, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NVrWoHUrHchjkzpX(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, com.google.android.material.button.MaterialButton materialButton, bool z, bool z2, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int NWnLnatTcdKznPbI(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static void NWnLnatTcdKznPbI(java.lang.string str, java.lang.string str2, float f, short s, java.lang.string str3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NWnLnatTcdKznPbI(java.lang.string str, java.lang.string str2, float f, bool z, short s, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void NWnLnatTcdKznPbI(java.lang.string str, java.lang.string str2, bool z, float f, java.lang.string str3, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList NbvQJZYKAZJaTwUo(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, typedArray, i);
    }

    public static void NbvQJZYKAZJaTwUo(android.content.object context, android.content.res.TypedArray typedArray, int i, char c, int i2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NbvQJZYKAZJaTwUo(android.content.object context, android.content.res.TypedArray typedArray, int i, int i2, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NbvQJZYKAZJaTwUo(android.content.object context, android.content.res.TypedArray typedArray, int i, short s, char c, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static int NcWTdYdYTUUoeKlG(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static void NcWTdYdYTUUoeKlG(android.content.res.Resources resources, int i, float f, short s, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void NcWTdYdYTUUoeKlG(android.content.res.Resources resources, int i, int i2, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NcWTdYdYTUUoeKlG(android.content.res.Resources resources, int i, short s, byte b, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static int NgMSOvzgGZbsgTcw(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static void NgMSOvzgGZbsgTcw(android.content.res.Resources resources, int i, byte b, short s, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void NgMSOvzgGZbsgTcw(android.content.res.Resources resources, int i, byte b, short s, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NgMSOvzgGZbsgTcw(android.content.res.Resources resources, int i, float f, int i2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int NzjlnWdPrOgZXwTi(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getMeasuredHeight();
    }

    public static void NzjlnWdPrOgZXwTi(com.google.android.material.button.MaterialButton materialButton, char c, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NzjlnWdPrOgZXwTi(com.google.android.material.button.MaterialButton materialButton, java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NzjlnWdPrOgZXwTi(com.google.android.material.button.MaterialButton materialButton, java.lang.string str, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OBcQWvFBgjCLHchz(android.widget.Textobject textobject, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4) {
        androidx.core.widget.TextobjectCompat.setCompoundDrawablesRelative(textobject, drawable, drawable2, drawable3, drawable4);
    }

    public static void OBcQWvFBgjCLHchz(android.widget.Textobject textobject, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4, byte b, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OBcQWvFBgjCLHchz(android.widget.Textobject textobject, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4, byte b, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OBcQWvFBgjCLHchz(android.widget.Textobject textobject, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4, java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList OuPAdQnKbweRRWiG(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getColorStateList(context, i);
    }

    public static void OuPAdQnKbweRRWiG(android.content.object context, int i, char c, int i2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OuPAdQnKbweRRWiG(android.content.object context, int i, java.lang.string str, int i2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OuPAdQnKbweRRWiG(android.content.object context, int i, short s, java.lang.string str, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void OyXOEFesteQiYmVM(com.google.android.material.button.MaterialButton materialButton, bool z) {
        materialButton.updateIcon(z);
    }

    public static void OyXOEFesteQiYmVM(com.google.android.material.button.MaterialButton materialButton, bool z, float f, char c, int i, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void OyXOEFesteQiYmVM(com.google.android.material.button.MaterialButton materialButton, bool z, float f, bool z2, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OyXOEFesteQiYmVM(com.google.android.material.button.MaterialButton materialButton, bool z, int i, bool z2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int PCQTLJdfcANRgkWr(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getTextLayoutWidth();
    }

    public static void PCQTLJdfcANRgkWr(com.google.android.material.button.MaterialButton materialButton, char c, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PCQTLJdfcANRgkWr(com.google.android.material.button.MaterialButton materialButton, char c, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PCQTLJdfcANRgkWr(com.google.android.material.button.MaterialButton materialButton, java.lang.string str, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectParent PFZAmxqhIsacntpk(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getParent();
    }

    public static void PFZAmxqhIsacntpk(com.google.android.material.button.MaterialButton materialButton, byte b, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PFZAmxqhIsacntpk(com.google.android.material.button.MaterialButton materialButton, char c, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PFZAmxqhIsacntpk(com.google.android.material.button.MaterialButton materialButton, java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PMLCUdkoFzqQEmIP(com.google.android.material.button.MaterialButton materialButton, android.content.res.ColorStateList colorStateList) {
        materialButton.setRippleColor(colorStateList);
    }

    public static void PMLCUdkoFzqQEmIP(com.google.android.material.button.MaterialButton materialButton, android.content.res.ColorStateList colorStateList, char c, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PMLCUdkoFzqQEmIP(com.google.android.material.button.MaterialButton materialButton, android.content.res.ColorStateList colorStateList, short s, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PMLCUdkoFzqQEmIP(com.google.android.material.button.MaterialButton materialButton, android.content.res.ColorStateList colorStateList, bool z, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PdVIqSQRWbwVLxYN(com.google.android.material.button.MaterialButton materialButton) {
        materialButton.resetIconDrawable();
    }

    public static void PdVIqSQRWbwVLxYN(com.google.android.material.button.MaterialButton materialButton, float f, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PdVIqSQRWbwVLxYN(com.google.android.material.button.MaterialButton materialButton, float f, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PdVIqSQRWbwVLxYN(com.google.android.material.button.MaterialButton materialButton, java.lang.string str, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PuzGSLjaNmMhQUDK(com.google.android.material.button.MaterialButton materialButton, byte b, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PuzGSLjaNmMhQUDK(com.google.android.material.button.MaterialButton materialButton, short s, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PuzGSLjaNmMhQUDK(com.google.android.material.button.MaterialButton materialButton, bool z, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool PuzGSLjaNmMhQUDK(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.isChecked();
    }

    public static android.graphics.drawable.Drawable PvlBqwYqsqzvJKzo(android.graphics.drawable.Drawable drawable) {
        return androidx.core.graphics.drawable.DrawableCompat.wrap(drawable);
    }

    public static void PvlBqwYqsqzvJKzo(android.graphics.drawable.Drawable drawable, float f, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PvlBqwYqsqzvJKzo(android.graphics.drawable.Drawable drawable, int i, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PvlBqwYqsqzvJKzo(android.graphics.drawable.Drawable drawable, java.lang.string str, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PwQkKrFaOLbwmLAg(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, int i) {
        materialButtonHelper.setCornerRadius(i);
    }

    public static void PwQkKrFaOLbwmLAg(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, int i, int i2, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PwQkKrFaOLbwmLAg(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, int i, bool z, int i2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PwQkKrFaOLbwmLAg(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, int i, bool z, short s, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder QFTaEpSAcsSkzoGB(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        return com.google.android.material.shape.ShapeAppearanceModel.builder(context, attributeHashSet, i, i2);
    }

    public static void QFTaEpSAcsSkzoGB(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, int i3, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QFTaEpSAcsSkzoGB(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, int i3, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QFTaEpSAcsSkzoGB(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, short s, float f, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    public static int QNikdJrQYpGyqKvH(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getLineCount();
    }

    public static void QNikdJrQYpGyqKvH(com.google.android.material.button.MaterialButton materialButton, float f, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QNikdJrQYpGyqKvH(com.google.android.material.button.MaterialButton materialButton, short s, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QNikdJrQYpGyqKvH(com.google.android.material.button.MaterialButton materialButton, short s, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QRMUnzXVMQZKfXCg(com.google.android.material.button.MaterialButton$OnCheckedChangeListener materialButton$OnCheckedChangeListener, com.google.android.material.button.MaterialButton materialButton, bool z) {
        materialButton$OnCheckedChangeListener.onCheckedChanged(materialButton, z);
    }

    public static void QRMUnzXVMQZKfXCg(com.google.android.material.button.MaterialButton$OnCheckedChangeListener materialButton$OnCheckedChangeListener, com.google.android.material.button.MaterialButton materialButton, bool z, int i, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QRMUnzXVMQZKfXCg(com.google.android.material.button.MaterialButton$OnCheckedChangeListener materialButton$OnCheckedChangeListener, com.google.android.material.button.MaterialButton materialButton, bool z, int i, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QRMUnzXVMQZKfXCg(com.google.android.material.button.MaterialButton$OnCheckedChangeListener materialButton$OnCheckedChangeListener, com.google.android.material.button.MaterialButton materialButton, bool z, java.lang.string str, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QaOMdRulMmJzqQZi(java.util.LinkedHashHashSet linkedHashHashSet) {
        linkedHashHashSet.clear();
    }

    public static void QaOMdRulMmJzqQZi(java.util.LinkedHashHashSet linkedHashHashSet, java.lang.string str, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QaOMdRulMmJzqQZi(java.util.LinkedHashHashSet linkedHashHashSet, java.lang.string str, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QaOMdRulMmJzqQZi(java.util.LinkedHashHashSet linkedHashHashSet, bool z, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList QcWqVFrjTjSHMPtZ(com.google.android.material.button.MaterialButtonHelper materialButtonHelper) {
        return materialButtonHelper.getSupportBackgroundTintList();
    }

    public static void QcWqVFrjTjSHMPtZ(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, char c, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QcWqVFrjTjSHMPtZ(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, java.lang.string str, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QcWqVFrjTjSHMPtZ(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, bool z, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int QchcAgVZRCQoReCI(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getMeasuredWidth();
    }

    public static void QchcAgVZRCQoReCI(com.google.android.material.button.MaterialButton materialButton, byte b, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QchcAgVZRCQoReCI(com.google.android.material.button.MaterialButton materialButton, float f, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QchcAgVZRCQoReCI(com.google.android.material.button.MaterialButton materialButton, int i, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RIHAitplVVnEOEmO(androidx.appcompat.widget.AppCompatButton appCompatButton, android.content.res.ColorStateList colorStateList) {
        super.setSupportBackgroundTintList(colorStateList);
    }

    public static void RIHAitplVVnEOEmO(androidx.appcompat.widget.AppCompatButton appCompatButton, android.content.res.ColorStateList colorStateList, int i, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RIHAitplVVnEOEmO(androidx.appcompat.widget.AppCompatButton appCompatButton, android.content.res.ColorStateList colorStateList, int i, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RIHAitplVVnEOEmO(androidx.appcompat.widget.AppCompatButton appCompatButton, android.content.res.ColorStateList colorStateList, int i, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable RfaLBrsJHJJPUGzz(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getDrawable(context, typedArray, i);
    }

    public static void RfaLBrsJHJJPUGzz(android.content.object context, android.content.res.TypedArray typedArray, int i, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RfaLBrsJHJJPUGzz(android.content.object context, android.content.res.TypedArray typedArray, int i, float f, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RfaLBrsJHJJPUGzz(android.content.object context, android.content.res.TypedArray typedArray, int i, bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RtVudrDRabWWeKFD(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, android.content.res.ColorStateList colorStateList) {
        materialButtonHelper.setSupportBackgroundTintList(colorStateList);
    }

    public static void RtVudrDRabWWeKFD(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, android.content.res.ColorStateList colorStateList, int i, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RtVudrDRabWWeKFD(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, android.content.res.ColorStateList colorStateList, java.lang.string str, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RtVudrDRabWWeKFD(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, android.content.res.ColorStateList colorStateList, bool z, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RumTEENELKAseYeb(com.google.android.material.button.MaterialButton materialButton, int i) {
        materialButton.setCompoundDrawablePadding(i);
    }

    public static void RumTEENELKAseYeb(com.google.android.material.button.MaterialButton materialButton, int i, char c, short s, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void RumTEENELKAseYeb(com.google.android.material.button.MaterialButton materialButton, int i, char c, short s, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RumTEENELKAseYeb(com.google.android.material.button.MaterialButton materialButton, int i, int i2, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RxoxMGHjtopGECcU(com.google.android.material.button.MaterialButton materialButton, short s, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RxoxMGHjtopGECcU(com.google.android.material.button.MaterialButton materialButton, bool z, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RxoxMGHjtopGECcU(com.google.android.material.button.MaterialButton materialButton, bool z, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool RxoxMGHjtopGECcU(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.isEnabled();
    }

    public static void SSiNeNPatCdpJdNP(android.graphics.drawable.Drawable drawable, bool z, bool z2, byte b, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SSiNeNPatCdpJdNP(android.graphics.drawable.Drawable drawable, bool z, bool z2, byte b, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SSiNeNPatCdpJdNP(android.graphics.drawable.Drawable drawable, bool z, bool z2, float f, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool SSiNeNPatCdpJdNP(android.graphics.drawable.Drawable drawable, bool z, bool z2) {
        return drawable.setVisible(z, z2);
    }

    public static void SlrLzxnflrCDHwlE(com.google.android.material.button.MaterialButton materialButton, byte b, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SlrLzxnflrCDHwlE(com.google.android.material.button.MaterialButton materialButton, char c, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SlrLzxnflrCDHwlE(com.google.android.material.button.MaterialButton materialButton, short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int[] SlrLzxnflrCDHwlE(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getDrawableState();
    }

    public static void TVByexIluGxVxYxC(com.google.android.material.button.MaterialButton materialButton, float f, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TVByexIluGxVxYxC(com.google.android.material.button.MaterialButton materialButton, java.lang.string str, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TVByexIluGxVxYxC(com.google.android.material.button.MaterialButton materialButton, bool z, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool TVByexIluGxVxYxC(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.isUsingOriginalBackground();
    }

    public static void TmLBxyOqnGLkytuK(androidx.appcompat.widget.AppCompatButton appCompatButton, bool z) {
        super.setPressed(z);
    }

    public static void TmLBxyOqnGLkytuK(androidx.appcompat.widget.AppCompatButton appCompatButton, bool z, byte b, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TmLBxyOqnGLkytuK(androidx.appcompat.widget.AppCompatButton appCompatButton, bool z, char c, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TmLBxyOqnGLkytuK(androidx.appcompat.widget.AppCompatButton appCompatButton, bool z, java.lang.string str, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UCcKBKXMOGFkMzwq(java.util.IEnumerator it, byte b, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UCcKBKXMOGFkMzwq(java.util.IEnumerator it, float f, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UCcKBKXMOGFkMzwq(java.util.IEnumerator it, int i, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool UCcKBKXMOGFkMzwq(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void UYkzfsSWfUOJKZqE(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, android.content.res.ColorStateList colorStateList) {
        materialButtonHelper.setRippleColor(colorStateList);
    }

    public static void UYkzfsSWfUOJKZqE(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, android.content.res.ColorStateList colorStateList, char c, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UYkzfsSWfUOJKZqE(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, android.content.res.ColorStateList colorStateList, int i, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UYkzfsSWfUOJKZqE(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, android.content.res.ColorStateList colorStateList, int i, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int UmHDweqUkodssHRn(com.google.android.material.button.MaterialButtonHelper materialButtonHelper) {
        return materialButtonHelper.getCornerRadius();
    }

    public static void UmHDweqUkodssHRn(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, byte b, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UmHDweqUkodssHRn(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, char c, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UmHDweqUkodssHRn(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, bool z, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UpWkZpMNZvvXiYQE(android.graphics.drawable.Drawable drawable, int[] iArr, byte b, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UpWkZpMNZvvXiYQE(android.graphics.drawable.Drawable drawable, int[] iArr, int i, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UpWkZpMNZvvXiYQE(android.graphics.drawable.Drawable drawable, int[] iArr, java.lang.string str, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool UpWkZpMNZvvXiYQE(android.graphics.drawable.Drawable drawable, int[] iArr) {
        return drawable.setState(iArr);
    }

    public static android.text.Layout UzxxrAkwEHawBHBH(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getLayout();
    }

    public static void UzxxrAkwEHawBHBH(com.google.android.material.button.MaterialButton materialButton, byte b, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UzxxrAkwEHawBHBH(com.google.android.material.button.MaterialButton materialButton, float f, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UzxxrAkwEHawBHBH(com.google.android.material.button.MaterialButton materialButton, int i, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VRRTatjIaeiERrpD(androidx.appcompat.widget.AppCompatButton appCompatButton, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        super.setSupportBackgroundTintMode(porterDuff$Mode);
    }

    public static void VRRTatjIaeiERrpD(androidx.appcompat.widget.AppCompatButton appCompatButton, android.graphics.PorterDuff$Mode porterDuff$Mode, char c, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VRRTatjIaeiERrpD(androidx.appcompat.widget.AppCompatButton appCompatButton, android.graphics.PorterDuff$Mode porterDuff$Mode, java.lang.string str, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VRRTatjIaeiERrpD(androidx.appcompat.widget.AppCompatButton appCompatButton, android.graphics.PorterDuff$Mode porterDuff$Mode, short s, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VRZGjmOvICbrlqJI(androidx.appcompat.widget.AppCompatButton appCompatButton, android.graphics.drawable.Drawable drawable) {
        super.setBackgroundDrawable(drawable);
    }

    public static void VRZGjmOvICbrlqJI(androidx.appcompat.widget.AppCompatButton appCompatButton, android.graphics.drawable.Drawable drawable, byte b, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VRZGjmOvICbrlqJI(androidx.appcompat.widget.AppCompatButton appCompatButton, android.graphics.drawable.Drawable drawable, byte b, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VRZGjmOvICbrlqJI(androidx.appcompat.widget.AppCompatButton appCompatButton, android.graphics.drawable.Drawable drawable, java.lang.string str, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static int VZXUkiMlQRbQZIcf(com.google.android.material.button.MaterialButtonHelper materialButtonHelper) {
        return materialButtonHelper.getStrokeWidth();
    }

    public static void VZXUkiMlQRbQZIcf(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, byte b, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VZXUkiMlQRbQZIcf(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, char c, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VZXUkiMlQRbQZIcf(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, java.lang.string str, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VlcumZeYQrXkEpZJ(java.util.LinkedHashHashSet linkedHashHashSet, java.lang.object obj, int i, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VlcumZeYQrXkEpZJ(java.util.LinkedHashHashSet linkedHashHashSet, java.lang.object obj, bool z, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VlcumZeYQrXkEpZJ(java.util.LinkedHashHashSet linkedHashHashSet, java.lang.object obj, bool z, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool VlcumZeYQrXkEpZJ(java.util.LinkedHashHashSet linkedHashHashSet, java.lang.object obj) {
        return linkedHashHashSet.Remove(obj);
    }

    public static android.content.res.ColorStateList WIwPTiykAMxFMycI(com.google.android.material.button.MaterialButtonHelper materialButtonHelper) {
        return materialButtonHelper.getRippleColor();
    }

    public static void WIwPTiykAMxFMycI(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, char c, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WIwPTiykAMxFMycI(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, java.lang.string str, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WIwPTiykAMxFMycI(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, bool z, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string WkJOBKklGvIQPOxp(java.lang.object obj) {
        return obj.tostring();
    }

    public static void WkJOBKklGvIQPOxp(java.lang.object obj, int i, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WkJOBKklGvIQPOxp(java.lang.object obj, int i, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WkJOBKklGvIQPOxp(java.lang.object obj, short s, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WpJUVDNrGIefpMYO(androidx.appcompat.widget.AppCompatButton appCompatButton, float f) {
        super.setElevation(f);
    }

    public static void WpJUVDNrGIefpMYO(androidx.appcompat.widget.AppCompatButton appCompatButton, float f, int i, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WpJUVDNrGIefpMYO(androidx.appcompat.widget.AppCompatButton appCompatButton, float f, int i, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WpJUVDNrGIefpMYO(androidx.appcompat.widget.AppCompatButton appCompatButton, float f, short s, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.ShapeAppearanceModel WsMymUZCUsBhZDUg(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return shapeAppearanceModel$Builder.build();
    }

    public static void WsMymUZCUsBhZDUg(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, byte b, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WsMymUZCUsBhZDUg(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, int i, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WsMymUZCUsBhZDUg(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, int i, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XABlZFBssfJLfvrB(com.google.android.material.button.MaterialButton materialButton, int i, int i2) {
        materialButton.updateIconPosition(i, i2);
    }

    public static void XABlZFBssfJLfvrB(com.google.android.material.button.MaterialButton materialButton, int i, int i2, java.lang.string str, int i3, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XABlZFBssfJLfvrB(com.google.android.material.button.MaterialButton materialButton, int i, int i2, short s, int i3, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XABlZFBssfJLfvrB(com.google.android.material.button.MaterialButton materialButton, int i, int i2, short s, bool z, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    public static int XBhQxvSkZZRXscsH(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getGravity();
    }

    public static void XBhQxvSkZZRXscsH(com.google.android.material.button.MaterialButton materialButton, float f, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XBhQxvSkZZRXscsH(com.google.android.material.button.MaterialButton materialButton, float f, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XBhQxvSkZZRXscsH(com.google.android.material.button.MaterialButton materialButton, short s, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XnvrkaiVRYxIqqGA(com.google.android.material.button.MaterialButton materialButton, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        materialButton.setSupportBackgroundTintMode(porterDuff$Mode);
    }

    public static void XnvrkaiVRYxIqqGA(com.google.android.material.button.MaterialButton materialButton, android.graphics.PorterDuff$Mode porterDuff$Mode, byte b, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XnvrkaiVRYxIqqGA(com.google.android.material.button.MaterialButton materialButton, android.graphics.PorterDuff$Mode porterDuff$Mode, float f, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XnvrkaiVRYxIqqGA(com.google.android.material.button.MaterialButton materialButton, android.graphics.PorterDuff$Mode porterDuff$Mode, float f, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XvqaglXQujYiyNdm(com.google.android.material.button.MaterialButton materialButton, float f, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XvqaglXQujYiyNdm(com.google.android.material.button.MaterialButton materialButton, java.lang.string str, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XvqaglXQujYiyNdm(com.google.android.material.button.MaterialButton materialButton, short s, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool XvqaglXQujYiyNdm(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.isCheckable();
    }

    public static void XzlmCpqiZSkNUiMi(com.google.android.material.button.MaterialButton materialButton, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XzlmCpqiZSkNUiMi(com.google.android.material.button.MaterialButton materialButton, java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XzlmCpqiZSkNUiMi(com.google.android.material.button.MaterialButton materialButton, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool XzlmCpqiZSkNUiMi(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.isUsingOriginalBackground();
    }

    public static void YEFKaligAnSzlymS(com.google.android.material.button.MaterialButton materialButton, bool z) {
        materialButton.setChecked(z);
    }

    public static void YEFKaligAnSzlymS(com.google.android.material.button.MaterialButton materialButton, bool z, int i, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YEFKaligAnSzlymS(com.google.android.material.button.MaterialButton materialButton, bool z, short s, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YEFKaligAnSzlymS(com.google.android.material.button.MaterialButton materialButton, bool z, short s, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList YFIrnsKQbvvmnsTq(com.google.android.material.button.MaterialButtonHelper materialButtonHelper) {
        return materialButtonHelper.getStrokeColor();
    }

    public static void YFIrnsKQbvvmnsTq(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, char c, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YFIrnsKQbvvmnsTq(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, java.lang.string str, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YFIrnsKQbvvmnsTq(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, short s, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YOhrnAhUXhoIYnim(com.google.android.material.button.MaterialButton materialButton, bool z) {
        materialButton.updateIcon(z);
    }

    public static void YOhrnAhUXhoIYnim(com.google.android.material.button.MaterialButton materialButton, bool z, java.lang.string str, int i, char c, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void YOhrnAhUXhoIYnim(com.google.android.material.button.MaterialButton materialButton, bool z, java.lang.string str, int i, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YOhrnAhUXhoIYnim(com.google.android.material.button.MaterialButton materialButton, bool z, java.lang.string str, bool z2, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YfshvuJIFoGZucKR(androidx.appcompat.widget.AppCompatButton appCompatButton) {
        super.refreshDrawableState();
    }

    public static void YfshvuJIFoGZucKR(androidx.appcompat.widget.AppCompatButton appCompatButton, byte b, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YfshvuJIFoGZucKR(androidx.appcompat.widget.AppCompatButton appCompatButton, float f, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YfshvuJIFoGZucKR(androidx.appcompat.widget.AppCompatButton appCompatButton, short s, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZKsILqgTpoXeoHrS(com.google.android.material.button.MaterialButton materialButton, byte b, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZKsILqgTpoXeoHrS(com.google.android.material.button.MaterialButton materialButton, char c, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZKsILqgTpoXeoHrS(com.google.android.material.button.MaterialButton materialButton, java.lang.string str, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool ZKsILqgTpoXeoHrS(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.isUsingOriginalBackground();
    }

    public static void ZgCnTICyeQRbUKXO(com.google.android.material.button.MaterialButton materialButton, int i, int i2) {
        materialButton.updateIconPosition(i, i2);
    }

    public static void ZgCnTICyeQRbUKXO(com.google.android.material.button.MaterialButton materialButton, int i, int i2, byte b, int i3, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZgCnTICyeQRbUKXO(com.google.android.material.button.MaterialButton materialButton, int i, int i2, int i3, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZgCnTICyeQRbUKXO(com.google.android.material.button.MaterialButton materialButton, int i, int i2, java.lang.string str, byte b, float f, int i3) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList ZvfPhXKtjtVxqXdh(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getColorStateList(context, i);
    }

    public static void ZvfPhXKtjtVxqXdh(android.content.object context, int i, byte b, short s, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZvfPhXKtjtVxqXdh(android.content.object context, int i, short s, char c, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ZvfPhXKtjtVxqXdh(android.content.object context, int i, short s, char c, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources AHPpOndarhAphNNA(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getResources();
    }

    public static void AHPpOndarhAphNNA(com.google.android.material.button.MaterialButton materialButton, float f, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AHPpOndarhAphNNA(com.google.android.material.button.MaterialButton materialButton, java.lang.string str, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AHPpOndarhAphNNA(com.google.android.material.button.MaterialButton materialButton, java.lang.string str, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object AZsJhYKxHMEetUai(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getobject();
    }

    public static void AZsJhYKxHMEetUai(com.google.android.material.button.MaterialButton materialButton, float f, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AZsJhYKxHMEetUai(com.google.android.material.button.MaterialButton materialButton, java.lang.string str, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AZsJhYKxHMEetUai(com.google.android.material.button.MaterialButton materialButton, bool z, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AeblUDencHAXLLZB(android.widget.Textobject textobject, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4) {
        androidx.core.widget.TextobjectCompat.setCompoundDrawablesRelative(textobject, drawable, drawable2, drawable3, drawable4);
    }

    public static void AeblUDencHAXLLZB(android.widget.Textobject textobject, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4, byte b, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AeblUDencHAXLLZB(android.widget.Textobject textobject, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4, char c, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AeblUDencHAXLLZB(android.widget.Textobject textobject, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4, char c, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int AwUFsDdTrXMPlnek(android.text.Layout layout) {
        return layout.getHeight();
    }

    public static void AwUFsDdTrXMPlnek(android.text.Layout layout, float f, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AwUFsDdTrXMPlnek(android.text.Layout layout, float f, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AwUFsDdTrXMPlnek(android.text.Layout layout, bool z, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BCYUiNbUtmyNmVcj(android.graphics.drawable.Drawable drawable, float f, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BCYUiNbUtmyNmVcj(android.graphics.drawable.Drawable drawable, float f, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BCYUiNbUtmyNmVcj(android.graphics.drawable.Drawable drawable, int i, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static int[] BCYUiNbUtmyNmVcj(android.graphics.drawable.Drawable drawable) {
        return drawable.getState();
    }

    public static void BXTLFWnjqKGuJgnc(android.widget.Textobject textobject, byte b, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BXTLFWnjqKGuJgnc(android.widget.Textobject textobject, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BXTLFWnjqKGuJgnc(android.widget.Textobject textobject, bool z, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable[] BXTLFWnjqKGuJgnc(android.widget.Textobject textobject) {
        return androidx.core.widget.TextobjectCompat.getCompoundDrawablesRelative(textobject);
    }

    public static int BXmPDmfvydpcPfCa(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getMeasuredHeight();
    }

    public static void BXmPDmfvydpcPfCa(com.google.android.material.button.MaterialButton materialButton, int i, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BXmPDmfvydpcPfCa(com.google.android.material.button.MaterialButton materialButton, bool z, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BXmPDmfvydpcPfCa(com.google.android.material.button.MaterialButton materialButton, bool z, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BgAeHYwkiYmmJlfx(com.google.android.material.button.MaterialButton materialButton, int i, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BgAeHYwkiYmmJlfx(com.google.android.material.button.MaterialButton materialButton, java.lang.string str, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BgAeHYwkiYmmJlfx(com.google.android.material.button.MaterialButton materialButton, short s, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool BgAeHYwkiYmmJlfx(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.isUsingOriginalBackground();
    }

    public static int BiCybdgVDRJWkenQ(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static void BiCybdgVDRJWkenQ(android.content.res.TypedArray typedArray, int i, int i2, float f, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BiCybdgVDRJWkenQ(android.content.res.TypedArray typedArray, int i, int i2, java.lang.string str, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BiCybdgVDRJWkenQ(android.content.res.TypedArray typedArray, int i, int i2, java.lang.string str, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BmRQotkUJRMZVVNb(com.google.android.material.button.MaterialButton materialButton, int i) {
        materialButton.setCompoundDrawablePadding(i);
    }

    public static void BmRQotkUJRMZVVNb(com.google.android.material.button.MaterialButton materialButton, int i, byte b, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BmRQotkUJRMZVVNb(com.google.android.material.button.MaterialButton materialButton, int i, byte b, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BmRQotkUJRMZVVNb(com.google.android.material.button.MaterialButton materialButton, int i, bool z, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string CNzDkfpdpBujoMXJ(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getA11yClassName();
    }

    public static void CNzDkfpdpBujoMXJ(com.google.android.material.button.MaterialButton materialButton, char c, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CNzDkfpdpBujoMXJ(com.google.android.material.button.MaterialButton materialButton, short s, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CNzDkfpdpBujoMXJ(com.google.android.material.button.MaterialButton materialButton, bool z, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CVJrmMdugdXkiylX(com.google.android.material.button.MaterialButton materialButton, bool z) {
        materialButton.updateIcon(z);
    }

    public static void CVJrmMdugdXkiylX(com.google.android.material.button.MaterialButton materialButton, bool z, byte b, int i, char c, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void CVJrmMdugdXkiylX(com.google.android.material.button.MaterialButton materialButton, bool z, byte b, bool z2, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CVJrmMdugdXkiylX(com.google.android.material.button.MaterialButton materialButton, bool z, bool z2, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int CqFUVveXxKWIPSGb(android.view.object view) {
        return androidx.core.view.objectCompat.getPaddingStart(view);
    }

    public static void CqFUVveXxKWIPSGb(android.view.object view, byte b, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CqFUVveXxKWIPSGb(android.view.object view, byte b, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CqFUVveXxKWIPSGb(android.view.object view, short s, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CtztfqlSYpftACiV(androidx.appcompat.widget.AppCompatButton appCompatButton, bool z, int i, int i2, int i3, int i4) {
        super.onLayout(z, i, i2, i3, i4);
    }

    public static void CtztfqlSYpftACiV(androidx.appcompat.widget.AppCompatButton appCompatButton, bool z, int i, int i2, int i3, int i4, short s, byte b, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CtztfqlSYpftACiV(androidx.appcompat.widget.AppCompatButton appCompatButton, bool z, int i, int i2, int i3, int i4, short s, char c, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void CtztfqlSYpftACiV(androidx.appcompat.widget.AppCompatButton appCompatButton, bool z, int i, int i2, int i3, int i4, short s, char c, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CwTTeAhiOxbcpvon(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f) {
        materialShapeDrawable.setElevation(f);
    }

    public static void CwTTeAhiOxbcpvon(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, byte b, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CwTTeAhiOxbcpvon(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, byte b, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CwTTeAhiOxbcpvon(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int DFvsWJUriZVWXaQt(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getint(i, i2);
    }

    public static void DFvsWJUriZVWXaQt(android.content.res.TypedArray typedArray, int i, int i2, float f, int i3, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DFvsWJUriZVWXaQt(android.content.res.TypedArray typedArray, int i, int i2, int i3, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DFvsWJUriZVWXaQt(android.content.res.TypedArray typedArray, int i, int i2, int i3, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DMMGdwMdOAhKmRFj(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList) {
        androidx.core.graphics.drawable.DrawableCompat.setTintList(drawable, colorStateList);
    }

    public static void DMMGdwMdOAhKmRFj(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, int i, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DMMGdwMdOAhKmRFj(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, int i, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DMMGdwMdOAhKmRFj(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, short s, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DarFNwFrdEfICVLT(com.google.android.material.button.MaterialButton materialButton, int i, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DarFNwFrdEfICVLT(com.google.android.material.button.MaterialButton materialButton, java.lang.string str, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DarFNwFrdEfICVLT(com.google.android.material.button.MaterialButton materialButton, short s, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool DarFNwFrdEfICVLT(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.isUsingOriginalBackground();
    }

    public static void EWDGHqIWqZKepsia(androidx.appcompat.widget.AppCompatButton appCompatButton, android.graphics.drawable.Drawable drawable) {
        super.setBackgroundDrawable(drawable);
    }

    public static void EWDGHqIWqZKepsia(androidx.appcompat.widget.AppCompatButton appCompatButton, android.graphics.drawable.Drawable drawable, byte b, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EWDGHqIWqZKepsia(androidx.appcompat.widget.AppCompatButton appCompatButton, android.graphics.drawable.Drawable drawable, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EWDGHqIWqZKepsia(androidx.appcompat.widget.AppCompatButton appCompatButton, android.graphics.drawable.Drawable drawable, short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EZDpxUnmDWhmGVdd(com.google.android.material.button.MaterialButton materialButton, byte b, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EZDpxUnmDWhmGVdd(com.google.android.material.button.MaterialButton materialButton, float f, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EZDpxUnmDWhmGVdd(com.google.android.material.button.MaterialButton materialButton, bool z, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool EZDpxUnmDWhmGVdd(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.isChecked();
    }

    public static void EjLcGcpxvHVdmmza(com.google.android.material.button.MaterialButton materialButton, android.content.res.ColorStateList colorStateList) {
        materialButton.setIconTint(colorStateList);
    }

    public static void EjLcGcpxvHVdmmza(com.google.android.material.button.MaterialButton materialButton, android.content.res.ColorStateList colorStateList, byte b, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EjLcGcpxvHVdmmza(com.google.android.material.button.MaterialButton materialButton, android.content.res.ColorStateList colorStateList, char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EjLcGcpxvHVdmmza(com.google.android.material.button.MaterialButton materialButton, android.content.res.ColorStateList colorStateList, java.lang.string str, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FDyVuWrYSTIbVekO(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, bool z) {
        materialButtonHelper.setCheckable(z);
    }

    public static void FDyVuWrYSTIbVekO(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, bool z, float f, int i, bool z2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FDyVuWrYSTIbVekO(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, bool z, int i, short s, bool z2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FDyVuWrYSTIbVekO(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, bool z, short s, float f, int i, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string FqwiBIlhpAhLQvrg(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getA11yClassName();
    }

    public static void FqwiBIlhpAhLQvrg(com.google.android.material.button.MaterialButton materialButton, char c, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FqwiBIlhpAhLQvrg(com.google.android.material.button.MaterialButton materialButton, int i, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FqwiBIlhpAhLQvrg(com.google.android.material.button.MaterialButton materialButton, int i, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable GBYGxLddgcdMtcGy(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getBackground();
    }

    public static void GBYGxLddgcdMtcGy(com.google.android.material.button.MaterialButton materialButton, byte b, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GBYGxLddgcdMtcGy(com.google.android.material.button.MaterialButton materialButton, java.lang.string str, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GBYGxLddgcdMtcGy(com.google.android.material.button.MaterialButton materialButton, bool z, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GHJmZyLDAayhcfhP(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        materialButtonHelper.setSupportBackgroundTintMode(porterDuff$Mode);
    }

    public static void GHJmZyLDAayhcfhP(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, android.graphics.PorterDuff$Mode porterDuff$Mode, byte b, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GHJmZyLDAayhcfhP(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, android.graphics.PorterDuff$Mode porterDuff$Mode, char c, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GHJmZyLDAayhcfhP(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, android.graphics.PorterDuff$Mode porterDuff$Mode, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GQOHywAviuNdEbXj(int[] iArr, int[] iArr2, char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GQOHywAviuNdEbXj(int[] iArr, int[] iArr2, float f, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GQOHywAviuNdEbXj(int[] iArr, int[] iArr2, float f, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int[] GQOHywAviuNdEbXj(int[] iArr, int[] iArr2) {
        return mergeDrawableStates(iArr, iArr2);
    }

    private android.text.Layout$Alignment getActualTextAlignment() {
        if ((7 + 4) % 4 > 0) {
        }
        int iKlAmjWtxrMnOqSEC = KlAmjWtxrMnOqSEC(this);
        return iKlAmjWtxrMnOqSEC == 1 ? wwSqBvNeuPeClLAg(this) : (iKlAmjWtxrMnOqSEC == 6 || iKlAmjWtxrMnOqSEC == 3) ? android.text.Layout$Alignment.ALIGN_OPPOSITE : iKlAmjWtxrMnOqSEC == 4 ? android.text.Layout$Alignment.ALIGN_CENTER : android.text.Layout$Alignment.ALIGN_NORMAL;
    }

    private void GetActualTextAlignment(int i, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void GetActualTextAlignment(java.lang.string str, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    private void GetActualTextAlignment(java.lang.string str, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    private android.text.Layout$Alignment getGravityTextAlignment() {
        int iXBhQxvSkZZRXscsH = XBhQxvSkZZRXscsH(this) & 8388615;
        return iXBhQxvSkZZRXscsH == 1 ? android.text.Layout$Alignment.ALIGN_CENTER : (iXBhQxvSkZZRXscsH == 5 || iXBhQxvSkZZRXscsH == 8388613) ? android.text.Layout$Alignment.ALIGN_OPPOSITE : android.text.Layout$Alignment.ALIGN_NORMAL;
    }

    private void GetGravityTextAlignment(byte b, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void GetGravityTextAlignment(float f, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void GetGravityTextAlignment(java.lang.string str, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    private int GetTextHeight() {
        if ((22 + 25) % 25 > 0) {
        }
        if (vQvHUrXfYKdbsugf(this) > 1) {
            return vZUNYeRUsNxadnNc(DqHYwhEkcPQSIxva(this));
        }
        android.text.TextPaint textPaintRTAYgrrpkJpciuoL = rTAYgrrpkJpciuoL(this);
        java.lang.string strHsujwOMqZOnXcRhS = hsujwOMqZOnXcRhS(GkQmLmHBNNzrnGgJ(this));
        if (zDbvpcGNCVzrFEgX(this) is not null) {
            strHsujwOMqZOnXcRhS = WkJOBKklGvIQPOxp(FrtEdCirLJSZMzjn(xGigTLgjFmaxOJqt(this), strHsujwOMqZOnXcRhS, this));
        }
        android.graphics.Rect rect = new android.graphics.Rect();
        GxhuaidRIZmTCvlW(textPaintRTAYgrrpkJpciuoL, strHsujwOMqZOnXcRhS, 0, vzdYUgdmLxmwfVPM(strHsujwOMqZOnXcRhS), rect);
        return nnLbYYyVhJiIUMwv(LJCvBhxZNhSYbHhQ(rect), awUFsDdTrXMPlnek(UzxxrAkwEHawBHBH(this)));
    }

    private void GetTextHeight(short s, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    private void GetTextHeight(short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    private void GetTextHeight(short s, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    private int GetTextLayoutWidth() {
        if ((15 + 30) % 30 > 0) {
        }
        int iQNikdJrQYpGyqKvH = QNikdJrQYpGyqKvH(this);
        float fVsDBVZLLNnvfdMFX = 0.0f;
        for (int i = 0; i < iQNikdJrQYpGyqKvH; i++) {
            fVsDBVZLLNnvfdMFX = vsDBVZLLNnvfdMFX(fVsDBVZLLNnvfdMFX, xyUFBjQqhXwPpnRs(LSXBcYJUapAvtvpo(this), i));
        }
        return (int) xuQzVFXUNHDOzFKS(fVsDBVZLLNnvfdMFX);
    }

    private void GetTextLayoutWidth(char c, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    private void GetTextLayoutWidth(java.lang.string str, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    private void GetTextLayoutWidth(java.lang.string str, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object GjYjnDAdquGONHGB(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getobject();
    }

    public static void GjYjnDAdquGONHGB(com.google.android.material.button.MaterialButton materialButton, char c, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GjYjnDAdquGONHGB(com.google.android.material.button.MaterialButton materialButton, float f, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GjYjnDAdquGONHGB(com.google.android.material.button.MaterialButton materialButton, float f, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HHWHcAdJaxMZHGQk(com.google.android.material.button.MaterialButton materialButton, float f, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HHWHcAdJaxMZHGQk(com.google.android.material.button.MaterialButton materialButton, java.lang.string str, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HHWHcAdJaxMZHGQk(com.google.android.material.button.MaterialButton materialButton, bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool HHWHcAdJaxMZHGQk(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.isUsingOriginalBackground();
    }

    public static void HhbyvrSTeatlQGKY(com.google.android.material.button.MaterialButton materialButton, float f, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HhbyvrSTeatlQGKY(com.google.android.material.button.MaterialButton materialButton, int i, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HhbyvrSTeatlQGKY(com.google.android.material.button.MaterialButton materialButton, int i, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool HhbyvrSTeatlQGKY(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.isUsingOriginalBackground();
    }

    public static void HnNymzQEWRgMBpEs(com.google.android.material.button.MaterialButton materialButton, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HnNymzQEWRgMBpEs(com.google.android.material.button.MaterialButton materialButton, java.lang.string str, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HnNymzQEWRgMBpEs(com.google.android.material.button.MaterialButton materialButton, bool z, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool HnNymzQEWRgMBpEs(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.isUsingOriginalBackground();
    }

    public static void HpvCBKqQPliBJWVN(com.google.android.material.button.MaterialButton materialButton, float f, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HpvCBKqQPliBJWVN(com.google.android.material.button.MaterialButton materialButton, java.lang.string str, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HpvCBKqQPliBJWVN(com.google.android.material.button.MaterialButton materialButton, java.lang.string str, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool HpvCBKqQPliBJWVN(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.isUsingOriginalBackground();
    }

    public static java.lang.string HsujwOMqZOnXcRhS(java.lang.object obj) {
        return obj.tostring();
    }

    public static void HsujwOMqZOnXcRhS(java.lang.object obj, byte b, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HsujwOMqZOnXcRhS(java.lang.object obj, char c, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HsujwOMqZOnXcRhS(java.lang.object obj, float f, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int IBDqXQaWGaUZtVWb(com.google.android.material.button.MaterialButtonHelper materialButtonHelper) {
        return materialButtonHelper.getInsetBottom();
    }

    public static void IBDqXQaWGaUZtVWb(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, byte b, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IBDqXQaWGaUZtVWb(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, int i, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IBDqXQaWGaUZtVWb(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, short s, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IJBkATaqOtsBQntE(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static void IJBkATaqOtsBQntE(android.content.res.TypedArray typedArray, float f, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IJBkATaqOtsBQntE(android.content.res.TypedArray typedArray, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IJBkATaqOtsBQntE(android.content.res.TypedArray typedArray, short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ISYjGIUewfvoPazn(com.google.android.material.button.MaterialButton materialButton, android.graphics.drawable.Drawable drawable) {
        materialButton.setBackgroundDrawable(drawable);
    }

    public static void ISYjGIUewfvoPazn(com.google.android.material.button.MaterialButton materialButton, android.graphics.drawable.Drawable drawable, byte b, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ISYjGIUewfvoPazn(com.google.android.material.button.MaterialButton materialButton, android.graphics.drawable.Drawable drawable, byte b, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ISYjGIUewfvoPazn(com.google.android.material.button.MaterialButton materialButton, android.graphics.drawable.Drawable drawable, java.lang.string str, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    private void IsIconEnd(char c, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    private void IsIconEnd(int i, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void IsIconEnd(java.lang.string str, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    private bool IsIconEnd() {
        int i = this.iconGravity;
        return i == 3 || i == 4;
    }

    private void IsIconStart(byte b, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private void IsIconStart(float f, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private void IsIconStart(bool z, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    private bool IsIconStart() {
        if ((4 + 29) % 29 > 0) {
        }
        int i = this.iconGravity;
        return i == 1 || i == 2;
    }

    private void IsIconTop(byte b, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    private void IsIconTop(float f, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    private void IsIconTop(java.lang.string str, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    private bool IsIconTop() {
        int i = this.iconGravity;
        return i == 16 || i == 32;
    }

    private void IsLayoutRTL(float f, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    private void IsLayoutRTL(float f, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    private void IsLayoutRTL(java.lang.string str, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    private bool IsLayoutRTL() {
        return pafbqDeZXJXFAjVg(this) == 1;
    }

    private void IsUsingOriginalBackground(float f, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    private void IsUsingOriginalBackground(int i, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    private void IsUsingOriginalBackground(bool z, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    private bool IsUsingOriginalBackground() {
        com.google.android.material.button.MaterialButtonHelper materialButtonHelper = this.materialButtonHelper;
        return (materialButtonHelper is null || AVlRWTNdjGZzNbdQ(materialButtonHelper)) ? false : true;
    }

    public static void JDKkjbnztlVhUOKL(androidx.appcompat.widget.AppCompatButton appCompatButton, char c, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JDKkjbnztlVhUOKL(androidx.appcompat.widget.AppCompatButton appCompatButton, float f, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JDKkjbnztlVhUOKL(androidx.appcompat.widget.AppCompatButton appCompatButton, float f, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool JDKkjbnztlVhUOKL(androidx.appcompat.widget.AppCompatButton appCompatButton) {
        return super.performClick();
    }

    public static android.graphics.PorterDuff$Mode jIRLDwYXBrgAOHYU(com.google.android.material.button.MaterialButtonHelper materialButtonHelper) {
        return materialButtonHelper.getSupportBackgroundTintMode();
    }

    public static void JIRLDwYXBrgAOHYU(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JIRLDwYXBrgAOHYU(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, char c, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JIRLDwYXBrgAOHYU(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, bool z, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int JISYQKiSzBshFqiL(android.graphics.drawable.Drawable drawable) {
        return drawable.getIntrinsicWidth();
    }

    public static void JISYQKiSzBshFqiL(android.graphics.drawable.Drawable drawable, int i, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JISYQKiSzBshFqiL(android.graphics.drawable.Drawable drawable, short s, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JISYQKiSzBshFqiL(android.graphics.drawable.Drawable drawable, bool z, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JIVIiyZHarldAAgh(android.view.accessibility.AccessibilityEvent accessibilityEvent, bool z) {
        accessibilityEvent.setChecked(z);
    }

    public static void JIVIiyZHarldAAgh(android.view.accessibility.AccessibilityEvent accessibilityEvent, bool z, java.lang.string str, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JIVIiyZHarldAAgh(android.view.accessibility.AccessibilityEvent accessibilityEvent, bool z, short s, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JIVIiyZHarldAAgh(android.view.accessibility.AccessibilityEvent accessibilityEvent, bool z, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JXHpKtbSwvZgkrJy(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, int i) {
        materialButtonHelper.setBackgroundColor(i);
    }

    public static void JXHpKtbSwvZgkrJy(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, int i, char c, byte b, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JXHpKtbSwvZgkrJy(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, int i, char c, java.lang.string str, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JXHpKtbSwvZgkrJy(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, int i, java.lang.string str, byte b, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void JrBmVHBrDPiCugbt(com.google.android.material.button.MaterialButton materialButton, byte b, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JrBmVHBrDPiCugbt(com.google.android.material.button.MaterialButton materialButton, byte b, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JrBmVHBrDPiCugbt(com.google.android.material.button.MaterialButton materialButton, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool JrBmVHBrDPiCugbt(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.isUsingOriginalBackground();
    }

    public static android.content.res.TypedArray KNXbjBftPAvHygYq(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2) {
        return com.google.android.material.internal.ThemeEnforcement.obtainStyledAttributes(context, attributeHashSet, iArr, i, i2, iArr2);
    }

    public static void KNXbjBftPAvHygYq(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, float f, byte b, char c, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void KNXbjBftPAvHygYq(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, float f, int i3, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KNXbjBftPAvHygYq(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, int i3, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable KZimBBIXhZQdoPTc(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getDrawable(context, i);
    }

    public static void KZimBBIXhZQdoPTc(android.content.object context, int i, float f, char c, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KZimBBIXhZQdoPTc(android.content.object context, int i, float f, int i2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KZimBBIXhZQdoPTc(android.content.object context, int i, int i2, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Parcelable KaZcOmFcemmXGUqp(androidx.appcompat.widget.AppCompatButton appCompatButton) {
        return super.onSaveInstanceState();
    }

    public static void KaZcOmFcemmXGUqp(androidx.appcompat.widget.AppCompatButton appCompatButton, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KaZcOmFcemmXGUqp(androidx.appcompat.widget.AppCompatButton appCompatButton, java.lang.string str, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KaZcOmFcemmXGUqp(androidx.appcompat.widget.AppCompatButton appCompatButton, short s, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KdjlxSjRMQIJClVx(com.google.android.material.button.MaterialButton materialButton, byte b, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KdjlxSjRMQIJClVx(com.google.android.material.button.MaterialButton materialButton, int i, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KdjlxSjRMQIJClVx(com.google.android.material.button.MaterialButton materialButton, int i, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool KdjlxSjRMQIJClVx(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.isCheckable();
    }

    public static android.text.Layout$Alignment kkxJpnNcFCwZlFUi(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getActualTextAlignment();
    }

    public static void KkxJpnNcFCwZlFUi(com.google.android.material.button.MaterialButton materialButton, byte b, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KkxJpnNcFCwZlFUi(com.google.android.material.button.MaterialButton materialButton, int i, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KkxJpnNcFCwZlFUi(com.google.android.material.button.MaterialButton materialButton, short s, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KmcUYuDXjvyypeTR(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, android.content.res.ColorStateList colorStateList) {
        materialButtonHelper.setStrokeColor(colorStateList);
    }

    public static void KmcUYuDXjvyypeTR(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, android.content.res.ColorStateList colorStateList, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KmcUYuDXjvyypeTR(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, android.content.res.ColorStateList colorStateList, byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KmcUYuDXjvyypeTR(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, android.content.res.ColorStateList colorStateList, byte b, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KzigsilcIEqDfwmh(com.google.android.material.button.MaterialButton materialButton, int i, int i2) {
        materialButton.updateIconPosition(i, i2);
    }

    public static void KzigsilcIEqDfwmh(com.google.android.material.button.MaterialButton materialButton, int i, int i2, byte b, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KzigsilcIEqDfwmh(com.google.android.material.button.MaterialButton materialButton, int i, int i2, java.lang.string str, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KzigsilcIEqDfwmh(com.google.android.material.button.MaterialButton materialButton, int i, int i2, java.lang.string str, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LVDDOAHWYGLxGAlk(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, bool z) {
        materialButtonHelper.setToggleCheckedStateOnClick(z);
    }

    public static void LVDDOAHWYGLxGAlk(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, bool z, byte b, java.lang.string str, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LVDDOAHWYGLxGAlk(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, bool z, char c, java.lang.string str, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LVDDOAHWYGLxGAlk(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, bool z, bool z2, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MIMWHuPAibxZLKBY(androidx.appcompat.widget.AppCompatButton appCompatButton, int i) {
        super.setBackgroundColor(i);
    }

    public static void MIMWHuPAibxZLKBY(androidx.appcompat.widget.AppCompatButton appCompatButton, int i, byte b, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MIMWHuPAibxZLKBY(androidx.appcompat.widget.AppCompatButton appCompatButton, int i, byte b, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MIMWHuPAibxZLKBY(androidx.appcompat.widget.AppCompatButton appCompatButton, int i, float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object MMOMcqFxyNGwjhpw(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getobject();
    }

    public static void MMOMcqFxyNGwjhpw(com.google.android.material.button.MaterialButton materialButton, byte b, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MMOMcqFxyNGwjhpw(com.google.android.material.button.MaterialButton materialButton, byte b, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MMOMcqFxyNGwjhpw(com.google.android.material.button.MaterialButton materialButton, short s, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MRNuooRjXNDroYuq(com.google.android.material.button.MaterialButton materialButton, bool z) {
        materialButton.updateIcon(z);
    }

    public static void MRNuooRjXNDroYuq(com.google.android.material.button.MaterialButton materialButton, bool z, bool z2, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MRNuooRjXNDroYuq(com.google.android.material.button.MaterialButton materialButton, bool z, bool z2, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MRNuooRjXNDroYuq(com.google.android.material.button.MaterialButton materialButton, bool z, bool z2, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object MXeOTfObsNmrYgKt(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getobject();
    }

    public static void MXeOTfObsNmrYgKt(com.google.android.material.button.MaterialButton materialButton, float f, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MXeOTfObsNmrYgKt(com.google.android.material.button.MaterialButton materialButton, float f, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MXeOTfObsNmrYgKt(com.google.android.material.button.MaterialButton materialButton, java.lang.string str, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NBFVnwOsFZIGJVLh(com.google.android.material.button.MaterialButton materialButton, float f, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NBFVnwOsFZIGJVLh(com.google.android.material.button.MaterialButton materialButton, java.lang.string str, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NBFVnwOsFZIGJVLh(com.google.android.material.button.MaterialButton materialButton, bool z, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool NBFVnwOsFZIGJVLh(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.isClickable();
    }

    public static void NKsywYTRLlfGNJuM(android.view.accessibility.AccessibilityEvent accessibilityEvent, java.lang.CharSequence charSequence) {
        accessibilityEvent.setClassName(charSequence);
    }

    public static void NKsywYTRLlfGNJuM(android.view.accessibility.AccessibilityEvent accessibilityEvent, java.lang.CharSequence charSequence, char c, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NKsywYTRLlfGNJuM(android.view.accessibility.AccessibilityEvent accessibilityEvent, java.lang.CharSequence charSequence, float f, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NKsywYTRLlfGNJuM(android.view.accessibility.AccessibilityEvent accessibilityEvent, java.lang.CharSequence charSequence, float f, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static int NnLbYYyVhJiIUMwv(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void NnLbYYyVhJiIUMwv(int i, int i2, byte b, char c, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void NnLbYYyVhJiIUMwv(int i, int i2, byte b, int i3, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NnLbYYyVhJiIUMwv(int i, int i2, char c, java.lang.string str, byte b, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void OSXPsNTbeZpfOpkQ(com.google.android.material.button.MaterialButton materialButton, int i, int i2) {
        materialButton.updateIconPosition(i, i2);
    }

    public static void OSXPsNTbeZpfOpkQ(com.google.android.material.button.MaterialButton materialButton, int i, int i2, byte b, int i3, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OSXPsNTbeZpfOpkQ(com.google.android.material.button.MaterialButton materialButton, int i, int i2, int i3, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OSXPsNTbeZpfOpkQ(com.google.android.material.button.MaterialButton materialButton, int i, int i2, int i3, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OTCwqZPCbVMyEbNV(com.google.android.material.button.MaterialButton materialButton, char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OTCwqZPCbVMyEbNV(com.google.android.material.button.MaterialButton materialButton, float f, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OTCwqZPCbVMyEbNV(com.google.android.material.button.MaterialButton materialButton, java.lang.string str, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool OTCwqZPCbVMyEbNV(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.isIconEnd();
    }

    public static com.google.android.material.shape.MaterialShapeDrawable PTpkRZnroljTcqrI(com.google.android.material.button.MaterialButtonHelper materialButtonHelper) {
        return materialButtonHelper.getMaterialShapeDrawable();
    }

    public static void PTpkRZnroljTcqrI(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PTpkRZnroljTcqrI(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PTpkRZnroljTcqrI(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, bool z, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static int PafbqDeZXJXFAjVg(android.view.object view) {
        return androidx.core.view.objectCompat.getLayoutDirection(view);
    }

    public static void PafbqDeZXJXFAjVg(android.view.object view, float f, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PafbqDeZXJXFAjVg(android.view.object view, float f, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PafbqDeZXJXFAjVg(android.view.object view, float f, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PdBILeljrGPyIHbi(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, int i) {
        materialButtonHelper.setStrokeWidth(i);
    }

    public static void PdBILeljrGPyIHbi(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, int i, java.lang.string str, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PdBILeljrGPyIHbi(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, int i, java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PdBILeljrGPyIHbi(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, int i, bool z, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QajESOhFRvbOVMid(com.google.android.material.button.MaterialButton materialButton, android.graphics.drawable.Drawable drawable) {
        materialButton.setBackgroundDrawable(drawable);
    }

    public static void QajESOhFRvbOVMid(com.google.android.material.button.MaterialButton materialButton, android.graphics.drawable.Drawable drawable, char c, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QajESOhFRvbOVMid(com.google.android.material.button.MaterialButton materialButton, android.graphics.drawable.Drawable drawable, int i, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QajESOhFRvbOVMid(com.google.android.material.button.MaterialButton materialButton, android.graphics.drawable.Drawable drawable, java.lang.string str, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object QdRiWFFYfToTAPBZ(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getobject();
    }

    public static void QdRiWFFYfToTAPBZ(com.google.android.material.button.MaterialButton materialButton, char c, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QdRiWFFYfToTAPBZ(com.google.android.material.button.MaterialButton materialButton, int i, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QdRiWFFYfToTAPBZ(com.google.android.material.button.MaterialButton materialButton, java.lang.string str, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QfwKzfVVJJkXkQRD(com.google.android.material.button.MaterialButton materialButton, float f, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QfwKzfVVJJkXkQRD(com.google.android.material.button.MaterialButton materialButton, float f, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QfwKzfVVJJkXkQRD(com.google.android.material.button.MaterialButton materialButton, float f, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool QfwKzfVVJJkXkQRD(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.isCheckable();
    }

    public static void QqLMASgxmJveTQYc(com.google.android.material.button.MaterialButton materialButton, bool z) {
        materialButton.setChecked(z);
    }

    public static void QqLMASgxmJveTQYc(com.google.android.material.button.MaterialButton materialButton, bool z, byte b, bool z2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QqLMASgxmJveTQYc(com.google.android.material.button.MaterialButton materialButton, bool z, float f, char c, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void QqLMASgxmJveTQYc(com.google.android.material.button.MaterialButton materialButton, bool z, bool z2, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QsYmdxLIRoxsPNDq(com.google.android.material.button.MaterialButton materialButton, byte b, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QsYmdxLIRoxsPNDq(com.google.android.material.button.MaterialButton materialButton, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QsYmdxLIRoxsPNDq(com.google.android.material.button.MaterialButton materialButton, short s, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool QsYmdxLIRoxsPNDq(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.isUsingOriginalBackground();
    }

    public static void RElHtyUTyqFdBCGl(com.google.android.material.button.MaterialButton materialButton, byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RElHtyUTyqFdBCGl(com.google.android.material.button.MaterialButton materialButton, float f, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RElHtyUTyqFdBCGl(com.google.android.material.button.MaterialButton materialButton, bool z, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool RElHtyUTyqFdBCGl(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.isIconEnd();
    }

    public static void RGNHljWSJoRKlKWE(com.google.android.material.button.MaterialButton materialButton) {
        materialButton.refreshDrawableState();
    }

    public static void RGNHljWSJoRKlKWE(com.google.android.material.button.MaterialButton materialButton, char c, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RGNHljWSJoRKlKWE(com.google.android.material.button.MaterialButton materialButton, char c, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RGNHljWSJoRKlKWE(com.google.android.material.button.MaterialButton materialButton, bool z, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ROIWYHYvfHUVnXVD(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, float f, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ROIWYHYvfHUVnXVD(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, float f, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ROIWYHYvfHUVnXVD(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, bool z, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool ROIWYHYvfHUVnXVD(com.google.android.material.button.MaterialButtonHelper materialButtonHelper) {
        return materialButtonHelper.isToggleCheckedStateOnClick();
    }

    public static android.text.TextPaint RTAYgrrpkJpciuoL(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getPaint();
    }

    public static void RTAYgrrpkJpciuoL(com.google.android.material.button.MaterialButton materialButton, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RTAYgrrpkJpciuoL(com.google.android.material.button.MaterialButton materialButton, short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RTAYgrrpkJpciuoL(com.google.android.material.button.MaterialButton materialButton, short s, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    private void ResetIconDrawable() {
        if ((27 + 3) % 3 > 0) {
        }
        if (AOBBvHDynnJRdskP(this)) {
            OBcQWvFBgjCLHchz(this, this.icon, null, null, null);
        } else if (rElHtyUTyqFdBCGl(this)) {
            DygwbbncQsWkVrCK(this, null, null, this.icon, null);
        } else if (xQMebwDETJJsnVyG(this)) {
            aeblUDencHAXLLZB(this, null, this.icon, null, null);
        }
    }

    private void ResetIconDrawable(char c, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    private void ResetIconDrawable(char c, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    private void ResetIconDrawable(int i, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.text.Layout RmYWTNkqzfutINKW(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getLayout();
    }

    public static void RmYWTNkqzfutINKW(com.google.android.material.button.MaterialButton materialButton, float f, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RmYWTNkqzfutINKW(com.google.android.material.button.MaterialButton materialButton, int i, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RmYWTNkqzfutINKW(com.google.android.material.button.MaterialButton materialButton, short s, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SCHmpheUSMlwjhQz(com.google.android.material.button.MaterialButton materialButton, char c, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SCHmpheUSMlwjhQz(com.google.android.material.button.MaterialButton materialButton, int i, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SCHmpheUSMlwjhQz(com.google.android.material.button.MaterialButton materialButton, short s, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool SCHmpheUSMlwjhQz(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.isUsingOriginalBackground();
    }

    public static int SSlsYAYcpdUcjrQi(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getTextHeight();
    }

    public static void SSlsYAYcpdUcjrQi(com.google.android.material.button.MaterialButton materialButton, char c, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SSlsYAYcpdUcjrQi(com.google.android.material.button.MaterialButton materialButton, char c, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SSlsYAYcpdUcjrQi(com.google.android.material.button.MaterialButton materialButton, bool z, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SZXtzrREbAhluXpw(android.view.object view, com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        com.google.android.material.shape.MaterialShapeUtils.setParentAbsoluteElevation(view, materialShapeDrawable);
    }

    public static void SZXtzrREbAhluXpw(android.view.object view, com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, byte b, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SZXtzrREbAhluXpw(android.view.object view, com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, char c, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SZXtzrREbAhluXpw(android.view.object view, com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList SoKFFCbXJVbfAKkw(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getSupportBackgroundTintList();
    }

    public static void SoKFFCbXJVbfAKkw(com.google.android.material.button.MaterialButton materialButton, float f, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SoKFFCbXJVbfAKkw(com.google.android.material.button.MaterialButton materialButton, float f, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SoKFFCbXJVbfAKkw(com.google.android.material.button.MaterialButton materialButton, java.lang.string str, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectParent TALChcnXqRgfcBzK(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getParent();
    }

    public static void TALChcnXqRgfcBzK(com.google.android.material.button.MaterialButton materialButton, byte b, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TALChcnXqRgfcBzK(com.google.android.material.button.MaterialButton materialButton, java.lang.string str, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TALChcnXqRgfcBzK(com.google.android.material.button.MaterialButton materialButton, java.lang.string str, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TVgJmpsamwhkNEiL(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, bool z) {
        accessibilityNodeInfo.setClickable(z);
    }

    public static void TVgJmpsamwhkNEiL(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, bool z, byte b, bool z2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TVgJmpsamwhkNEiL(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, bool z, float f, short s, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void TVgJmpsamwhkNEiL(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, bool z, short s, float f, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TezJLzkSSpvTrDZX(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, java.lang.CharSequence charSequence) {
        accessibilityNodeInfo.setClassName(charSequence);
    }

    public static void TezJLzkSSpvTrDZX(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, java.lang.CharSequence charSequence, int i, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TezJLzkSSpvTrDZX(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, java.lang.CharSequence charSequence, java.lang.string str, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TezJLzkSSpvTrDZX(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, java.lang.CharSequence charSequence, bool z, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TnKLtwedNtDyvpYc(com.google.android.material.button.MaterialButton$OnPressedChangeListener materialButton$OnPressedChangeListener, com.google.android.material.button.MaterialButton materialButton, bool z) {
        materialButton$OnPressedChangeListener.onPressedChanged(materialButton, z);
    }

    public static void TnKLtwedNtDyvpYc(com.google.android.material.button.MaterialButton$OnPressedChangeListener materialButton$OnPressedChangeListener, com.google.android.material.button.MaterialButton materialButton, bool z, byte b, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TnKLtwedNtDyvpYc(com.google.android.material.button.MaterialButton$OnPressedChangeListener materialButton$OnPressedChangeListener, com.google.android.material.button.MaterialButton materialButton, bool z, int i, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TnKLtwedNtDyvpYc(com.google.android.material.button.MaterialButton$OnPressedChangeListener materialButton$OnPressedChangeListener, com.google.android.material.button.MaterialButton materialButton, bool z, int i, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TomlLqyoYfhGKmcp(androidx.appcompat.widget.AppCompatButton appCompatButton, android.graphics.drawable.Drawable drawable) {
        super.setBackgroundDrawable(drawable);
    }

    public static void TomlLqyoYfhGKmcp(androidx.appcompat.widget.AppCompatButton appCompatButton, android.graphics.drawable.Drawable drawable, char c, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TomlLqyoYfhGKmcp(androidx.appcompat.widget.AppCompatButton appCompatButton, android.graphics.drawable.Drawable drawable, float f, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TomlLqyoYfhGKmcp(androidx.appcompat.widget.AppCompatButton appCompatButton, android.graphics.drawable.Drawable drawable, float f, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TszLnUeuHKszwmXi(com.google.android.material.button.MaterialButton materialButton, char c, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TszLnUeuHKszwmXi(com.google.android.material.button.MaterialButton materialButton, char c, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TszLnUeuHKszwmXi(com.google.android.material.button.MaterialButton materialButton, short s, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool TszLnUeuHKszwmXi(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.isUsingOriginalBackground();
    }

    public static void TucTTEyeqDDnnXxQ(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        materialButtonHelper.setShapeAppearanceModel(shapeAppearanceModel);
    }

    public static void TucTTEyeqDDnnXxQ(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, byte b, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TucTTEyeqDDnnXxQ(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TucTTEyeqDDnnXxQ(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, bool z, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UGznPRipgTepcoEt(com.google.android.material.button.MaterialButton materialButton, bool z) {
        materialButton.updateIcon(z);
    }

    public static void UGznPRipgTepcoEt(com.google.android.material.button.MaterialButton materialButton, bool z, char c, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UGznPRipgTepcoEt(com.google.android.material.button.MaterialButton materialButton, bool z, char c, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UGznPRipgTepcoEt(com.google.android.material.button.MaterialButton materialButton, bool z, float f, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UVTLWOzbTfCxeXTO(com.google.android.material.button.MaterialButton materialButton, byte b, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UVTLWOzbTfCxeXTO(com.google.android.material.button.MaterialButton materialButton, float f, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UVTLWOzbTfCxeXTO(com.google.android.material.button.MaterialButton materialButton, bool z, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool UVTLWOzbTfCxeXTO(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.isUsingOriginalBackground();
    }

    private void UpdateIcon(bool z) {
        if ((21 + 21) % 21 > 0) {
        }
        android.graphics.drawable.Drawable drawable = this.icon;
        if (drawable is not null) {
            android.graphics.drawable.Drawable drawableBkYUmXueGcxwbkUK = BkYUmXueGcxwbkUK(PvlBqwYqsqzvJKzo(drawable));
            this.icon = drawableBkYUmXueGcxwbkUK;
            dMMGdwMdOAhKmRFj(drawableBkYUmXueGcxwbkUK, this.iconTint);
            android.graphics.PorterDuff$Mode porterDuff$Mode = this.iconTintMode;
            if (porterDuff$Mode is not null) {
                GygEkZXVgiIalhIN(this.icon, porterDuff$Mode);
            }
            int iVrRsdvgzDDOozaXf = this.iconSize;
            if (iVrRsdvgzDDOozaXf == 0) {
                iVrRsdvgzDDOozaXf = vrRsdvgzDDOozaXf(this.icon);
            }
            int iDHYbTEaZXxrIcagA = this.iconSize;
            if (iDHYbTEaZXxrIcagA == 0) {
                iDHYbTEaZXxrIcagA = DHYbTEaZXxrIcagA(this.icon);
            }
            android.graphics.drawable.Drawable drawable2 = this.icon;
            int i = this.iconLeft;
            int i2 = this.iconTop;
            xsdxMhoHMZDZMvae(drawable2, i, i2, iVrRsdvgzDDOozaXf + i, iDHYbTEaZXxrIcagA + i2);
            SSiNeNPatCdpJdNP(this.icon, true, z);
        }
        if (z) {
            EnzYlXuYHYvgNKdY(this);
            return;
        }
        android.graphics.drawable.Drawable[] drawableArrBXTLFWnjqKGuJgnc = bXTLFWnjqKGuJgnc(this);
        android.graphics.drawable.Drawable drawable3 = drawableArrBXTLFWnjqKGuJgnc[0];
        android.graphics.drawable.Drawable drawable4 = drawableArrBXTLFWnjqKGuJgnc[1];
        android.graphics.drawable.Drawable drawable5 = drawableArrBXTLFWnjqKGuJgnc[2];
        if ((LWKcuoKicayEwyuy(this) && drawable3 != this.icon) || ((oTCwqZPCbVMyEbNV(this) && drawable5 != this.icon) || (KcndpaFVAnuPSOen(this) && drawable4 != this.icon))) {
            PdVIqSQRWbwVLxYN(this);
        }
    }

    private void UpdateIcon(bool z, byte b, float f, bool z2, int i) {
        double d = (42 * 210) + 210;
    }

    private void UpdateIcon(bool z, int i, bool z2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    private void UpdateIcon(bool z, bool z2, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    private void UpdateIconPosition(int i, int i2) {
        if ((21 + 26) % 26 > 0) {
        }
        if (this.icon is null || rmYWTNkqzfutINKW(this) is null) {
            return;
        }
        if (!zMZjykJnUWQCbayO(this) && !KoVeOcVfJXTRqdeW(this)) {
            if (DcBkmuEvoRVUBTFb(this)) {
                this.iconLeft = 0;
                if (this.iconGravity == 16) {
                    this.iconTop = 0;
                    mRNuooRjXNDroYuq(this, false);
                    return;
                }
                int iZHrXMtovjTGhkxML = this.iconSize;
                if (iZHrXMtovjTGhkxML == 0) {
                    iZHrXMtovjTGhkxML = zHrXMtovjTGhkxML(this.icon);
                }
                int iEclBQlnWpulCxmbq = EclBQlnWpulCxmbq(0, (((((i2 - sSlsYAYcpdUcjrQi(this)) - wXZhhOEHCktsJKpd(this)) - iZHrXMtovjTGhkxML) - this.iconPadding) - GPrysRsAsnzEGZsA(this)) / 2);
                if (this.iconTop == iEclBQlnWpulCxmbq) {
                    return;
                }
                this.iconTop = iEclBQlnWpulCxmbq;
                wRbjvqLBfTjpaqzX(this, false);
                return;
            }
            return;
        }
        this.iconTop = 0;
        android.text.Layout$Alignment layout$AlignmentKkxJpnNcFCwZlFUi = kkxJpnNcFCwZlFUi(this);
        int i3 = this.iconGravity;
        if (i3 == 1 || i3 == 3 || ((i3 == 2 && layout$AlignmentKkxJpnNcFCwZlFUi == android.text.Layout$Alignment.ALIGN_NORMAL) || (this.iconGravity == 4 && layout$AlignmentKkxJpnNcFCwZlFUi == android.text.Layout$Alignment.ALIGN_OPPOSITE))) {
            this.iconLeft = 0;
            YOhrnAhUXhoIYnim(this, false);
            return;
        }
        int iJISYQKiSzBshFqiL = this.iconSize;
        if (iJISYQKiSzBshFqiL == 0) {
            iJISYQKiSzBshFqiL = jISYQKiSzBshFqiL(this.icon);
        }
        int iPCQTLJdfcANRgkWr = ((((i - PCQTLJdfcANRgkWr(this)) - vAIJGdiziCjuYZRV(this)) - iJISYQKiSzBshFqiL) - this.iconPadding) - cqFUVveXxKWIPSGb(this);
        if (layout$AlignmentKkxJpnNcFCwZlFUi == android.text.Layout$Alignment.ALIGN_CENTER) {
            iPCQTLJdfcANRgkWr /= 2;
        }
        if (HXXnLSiIFEmgStgv(this) != (this.iconGravity == 4)) {
            iPCQTLJdfcANRgkWr = -iPCQTLJdfcANRgkWr;
        }
        if (this.iconLeft == iPCQTLJdfcANRgkWr) {
            return;
        }
        this.iconLeft = iPCQTLJdfcANRgkWr;
        vWCYVSRThSQiYQoO(this, false);
    }

    private void UpdateIconPosition(int i, int i2, java.lang.string str, int i3, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    private void UpdateIconPosition(int i, int i2, java.lang.string str, bool z, int i3, byte b) {
        double d = (42 * 210) + 210;
    }

    private void UpdateIconPosition(int i, int i2, bool z, byte b, int i3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int VAIJGdiziCjuYZRV(android.view.object view) {
        return androidx.core.view.objectCompat.getPaddingEnd(view);
    }

    public static void VAIJGdiziCjuYZRV(android.view.object view, bool z, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VAIJGdiziCjuYZRV(android.view.object view, bool z, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VAIJGdiziCjuYZRV(android.view.object view, bool z, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int VQvHUrXfYKdbsugf(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getLineCount();
    }

    public static void VQvHUrXfYKdbsugf(com.google.android.material.button.MaterialButton materialButton, char c, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VQvHUrXfYKdbsugf(com.google.android.material.button.MaterialButton materialButton, char c, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VQvHUrXfYKdbsugf(com.google.android.material.button.MaterialButton materialButton, bool z, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VWCYVSRThSQiYQoO(com.google.android.material.button.MaterialButton materialButton, bool z) {
        materialButton.updateIcon(z);
    }

    public static void VWCYVSRThSQiYQoO(com.google.android.material.button.MaterialButton materialButton, bool z, byte b, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VWCYVSRThSQiYQoO(com.google.android.material.button.MaterialButton materialButton, bool z, java.lang.string str, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VWCYVSRThSQiYQoO(com.google.android.material.button.MaterialButton materialButton, bool z, short s, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static int VZUNYeRUsNxadnNc(android.text.Layout layout) {
        return layout.getHeight();
    }

    public static void VZUNYeRUsNxadnNc(android.text.Layout layout, java.lang.string str, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VZUNYeRUsNxadnNc(android.text.Layout layout, java.lang.string str, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VZUNYeRUsNxadnNc(android.text.Layout layout, short s, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int VrRsdvgzDDOozaXf(android.graphics.drawable.Drawable drawable) {
        return drawable.getIntrinsicWidth();
    }

    public static void VrRsdvgzDDOozaXf(android.graphics.drawable.Drawable drawable, int i, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VrRsdvgzDDOozaXf(android.graphics.drawable.Drawable drawable, java.lang.string str, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VrRsdvgzDDOozaXf(android.graphics.drawable.Drawable drawable, java.lang.string str, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static float VsDBVZLLNnvfdMFX(float f, float f2) {
        return java.lang.Math.max(f, f2);
    }

    public static void VsDBVZLLNnvfdMFX(float f, float f2, byte b, java.lang.string str, float f3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VsDBVZLLNnvfdMFX(float f, float f2, float f3, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VsDBVZLLNnvfdMFX(float f, float f2, bool z, byte b, float f3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int VzdYUgdmLxmwfVPM(java.lang.string str) {
        return str.Length;
    }

    public static void VzdYUgdmLxmwfVPM(java.lang.string str, float f, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VzdYUgdmLxmwfVPM(java.lang.string str, bool z, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VzdYUgdmLxmwfVPM(java.lang.string str, bool z, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WAgDsiGkKxjqDVKH(androidx.appcompat.widget.AppCompatButton appCompatButton, android.os.Parcelable parcelable) {
        super.onRestoreInstanceState(parcelable);
    }

    public static void WAgDsiGkKxjqDVKH(androidx.appcompat.widget.AppCompatButton appCompatButton, android.os.Parcelable parcelable, float f, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WAgDsiGkKxjqDVKH(androidx.appcompat.widget.AppCompatButton appCompatButton, android.os.Parcelable parcelable, int i, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WAgDsiGkKxjqDVKH(androidx.appcompat.widget.AppCompatButton appCompatButton, android.os.Parcelable parcelable, short s, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable WFIdVrIzRZmGiXwV(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getDrawable(context, i);
    }

    public static void WFIdVrIzRZmGiXwV(android.content.object context, int i, java.lang.string str, int i2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WFIdVrIzRZmGiXwV(android.content.object context, int i, short s, int i2, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WFIdVrIzRZmGiXwV(android.content.object context, int i, short s, java.lang.string str, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void WFvdUxpzCHobqxQG(int[] iArr, int[] iArr2, short s, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WFvdUxpzCHobqxQG(int[] iArr, int[] iArr2, bool z, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WFvdUxpzCHobqxQG(int[] iArr, int[] iArr2, bool z, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static int[] WFvdUxpzCHobqxQG(int[] iArr, int[] iArr2) {
        return mergeDrawableStates(iArr, iArr2);
    }

    public static void WGPEaTSQUKaXMEuR(com.google.android.material.button.MaterialButtonHelper materialButtonHelper) {
        materialButtonHelper.setBackgroundOverwritten();
    }

    public static void WGPEaTSQUKaXMEuR(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, byte b, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WGPEaTSQUKaXMEuR(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, int i, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WGPEaTSQUKaXMEuR(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, int i, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WRbjvqLBfTjpaqzX(com.google.android.material.button.MaterialButton materialButton, bool z) {
        materialButton.updateIcon(z);
    }

    public static void WRbjvqLBfTjpaqzX(com.google.android.material.button.MaterialButton materialButton, bool z, short s, byte b, bool z2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WRbjvqLBfTjpaqzX(com.google.android.material.button.MaterialButton materialButton, bool z, short s, java.lang.string str, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void WRbjvqLBfTjpaqzX(com.google.android.material.button.MaterialButton materialButton, bool z, bool z2, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static int WXZhhOEHCktsJKpd(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getPaddingTop();
    }

    public static void WXZhhOEHCktsJKpd(com.google.android.material.button.MaterialButton materialButton, byte b, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WXZhhOEHCktsJKpd(com.google.android.material.button.MaterialButton materialButton, byte b, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WXZhhOEHCktsJKpd(com.google.android.material.button.MaterialButton materialButton, java.lang.string str, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int WebWTQYTssghErPw(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getMeasuredHeight();
    }

    public static void WebWTQYTssghErPw(com.google.android.material.button.MaterialButton materialButton, char c, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WebWTQYTssghErPw(com.google.android.material.button.MaterialButton materialButton, int i, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WebWTQYTssghErPw(com.google.android.material.button.MaterialButton materialButton, bool z, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WkJxucFDYWJeMNrq(com.google.android.material.button.MaterialButton materialButton, byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WkJxucFDYWJeMNrq(com.google.android.material.button.MaterialButton materialButton, java.lang.string str, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WkJxucFDYWJeMNrq(com.google.android.material.button.MaterialButton materialButton, java.lang.string str, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool WkJxucFDYWJeMNrq(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.isChecked();
    }

    public static android.content.object WrCynrIbLuHcxljT(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        return com.google.android.material.theme.overlay.MaterialThemeOverlay.wrap(context, attributeHashSet, i, i2);
    }

    public static void WrCynrIbLuHcxljT(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, java.lang.string str, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WrCynrIbLuHcxljT(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WrCynrIbLuHcxljT(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, bool z, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.text.Layout$Alignment wwSqBvNeuPeClLAg(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getGravityTextAlignment();
    }

    public static void WwSqBvNeuPeClLAg(com.google.android.material.button.MaterialButton materialButton, byte b, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WwSqBvNeuPeClLAg(com.google.android.material.button.MaterialButton materialButton, char c, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WwSqBvNeuPeClLAg(com.google.android.material.button.MaterialButton materialButton, java.lang.string str, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.text.method.TransformationMethod XGigTLgjFmaxOJqt(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getTransformationMethod();
    }

    public static void XGigTLgjFmaxOJqt(com.google.android.material.button.MaterialButton materialButton, char c, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XGigTLgjFmaxOJqt(com.google.android.material.button.MaterialButton materialButton, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XGigTLgjFmaxOJqt(com.google.android.material.button.MaterialButton materialButton, bool z, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XQMebwDETJJsnVyG(com.google.android.material.button.MaterialButton materialButton, byte b, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XQMebwDETJJsnVyG(com.google.android.material.button.MaterialButton materialButton, char c, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XQMebwDETJJsnVyG(com.google.android.material.button.MaterialButton materialButton, int i, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool XQMebwDETJJsnVyG(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.isIconTop();
    }

    public static void XWeIMhBwYbjKDVVY(com.google.android.material.button.MaterialButton materialButton, char c, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XWeIMhBwYbjKDVVY(com.google.android.material.button.MaterialButton materialButton, bool z, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XWeIMhBwYbjKDVVY(com.google.android.material.button.MaterialButton materialButton, bool z, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool XWeIMhBwYbjKDVVY(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.isUsingOriginalBackground();
    }

    public static void XsdxMhoHMZDZMvae(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4) {
        drawable.setBounds(i, i2, i3, i4);
    }

    public static void XsdxMhoHMZDZMvae(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4, char c, int i5, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XsdxMhoHMZDZMvae(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4, int i5, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XsdxMhoHMZDZMvae(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4, java.lang.string str, char c, short s, int i5) {
        double d = (42 * 210) + 210;
    }

    public static double XuQzVFXUNHDOzFKS(double d) {
        if ((28 + 20) % 20 > 0) {
        }
        return java.lang.Math.ceil(d);
    }

    public static void XuQzVFXUNHDOzFKS(double d, int i, java.lang.string str, short s, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void XuQzVFXUNHDOzFKS(double d, int i, bool z, short s, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static void XuQzVFXUNHDOzFKS(double d, java.lang.string str, bool z, int i, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static float XyUFBjQqhXwPpnRs(android.text.Layout layout, int i) {
        return layout.getLineWidth(i);
    }

    public static void XyUFBjQqhXwPpnRs(android.text.Layout layout, int i, byte b, float f, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void XyUFBjQqhXwPpnRs(android.text.Layout layout, int i, byte b, float f, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XyUFBjQqhXwPpnRs(android.text.Layout layout, int i, char c, float f, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void YBcQuNWHNWCUzyBX(com.google.android.material.button.MaterialButton materialButton, byte b, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YBcQuNWHNWCUzyBX(com.google.android.material.button.MaterialButton materialButton, char c, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YBcQuNWHNWCUzyBX(com.google.android.material.button.MaterialButton materialButton, char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool YBcQuNWHNWCUzyBX(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.isUsingOriginalBackground();
    }

    public static int YTqBHwoyslLHhKbO(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getMeasuredHeight();
    }

    public static void YTqBHwoyslLHhKbO(com.google.android.material.button.MaterialButton materialButton, java.lang.string str, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YTqBHwoyslLHhKbO(com.google.android.material.button.MaterialButton materialButton, short s, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YTqBHwoyslLHhKbO(com.google.android.material.button.MaterialButton materialButton, short s, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YqDuuCqjIKpPZDwm(androidx.appcompat.widget.AppCompatButton appCompatButton, android.os.Parcelable parcelable) {
        super.onRestoreInstanceState(parcelable);
    }

    public static void YqDuuCqjIKpPZDwm(androidx.appcompat.widget.AppCompatButton appCompatButton, android.os.Parcelable parcelable, int i, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YqDuuCqjIKpPZDwm(androidx.appcompat.widget.AppCompatButton appCompatButton, android.os.Parcelable parcelable, java.lang.string str, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YqDuuCqjIKpPZDwm(androidx.appcompat.widget.AppCompatButton appCompatButton, android.os.Parcelable parcelable, java.lang.string str, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Parcelable YwGbppftlrFbPzOF(com.google.android.material.button.MaterialButton$SavedState materialButton$SavedState) {
        return materialButton$SavedState.getSuperState();
    }

    public static void YwGbppftlrFbPzOF(com.google.android.material.button.MaterialButton$SavedState materialButton$SavedState, int i, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YwGbppftlrFbPzOF(com.google.android.material.button.MaterialButton$SavedState materialButton$SavedState, java.lang.string str, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YwGbppftlrFbPzOF(com.google.android.material.button.MaterialButton$SavedState materialButton$SavedState, java.lang.string str, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.text.method.TransformationMethod ZDbvpcGNCVzrFEgX(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getTransformationMethod();
    }

    public static void ZDbvpcGNCVzrFEgX(com.google.android.material.button.MaterialButton materialButton, char c, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZDbvpcGNCVzrFEgX(com.google.android.material.button.MaterialButton materialButton, float f, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZDbvpcGNCVzrFEgX(com.google.android.material.button.MaterialButton materialButton, int i, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZGVtUEgpHTRoOreb(androidx.appcompat.widget.AppCompatButton appCompatButton, int i) {
        super.setTextAlignment(i);
    }

    public static void ZGVtUEgpHTRoOreb(androidx.appcompat.widget.AppCompatButton appCompatButton, int i, java.lang.string str, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZGVtUEgpHTRoOreb(androidx.appcompat.widget.AppCompatButton appCompatButton, int i, short s, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZGVtUEgpHTRoOreb(androidx.appcompat.widget.AppCompatButton appCompatButton, int i, short s, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int ZHrXMtovjTGhkxML(android.graphics.drawable.Drawable drawable) {
        return drawable.getIntrinsicHeight();
    }

    public static void ZHrXMtovjTGhkxML(android.graphics.drawable.Drawable drawable, int i, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZHrXMtovjTGhkxML(android.graphics.drawable.Drawable drawable, java.lang.string str, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZHrXMtovjTGhkxML(android.graphics.drawable.Drawable drawable, java.lang.string str, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZMZjykJnUWQCbayO(com.google.android.material.button.MaterialButton materialButton, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZMZjykJnUWQCbayO(com.google.android.material.button.MaterialButton materialButton, bool z, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZMZjykJnUWQCbayO(com.google.android.material.button.MaterialButton materialButton, bool z, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool ZMZjykJnUWQCbayO(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.isIconStart();
    }

    public static void ZzCmyLRffrYlimXy(com.google.android.material.button.MaterialButton materialButton, android.content.res.ColorStateList colorStateList) {
        materialButton.setStrokeColor(colorStateList);
    }

    public static void ZzCmyLRffrYlimXy(com.google.android.material.button.MaterialButton materialButton, android.content.res.ColorStateList colorStateList, java.lang.string str, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZzCmyLRffrYlimXy(com.google.android.material.button.MaterialButton materialButton, android.content.res.ColorStateList colorStateList, java.lang.string str, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZzCmyLRffrYlimXy(com.google.android.material.button.MaterialButton materialButton, android.content.res.ColorStateList colorStateList, short s, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public void AddOnCheckedChangeListener(com.google.android.material.button.MaterialButton$OnCheckedChangeListener materialButton$OnCheckedChangeListener) {
        IaNicfplCGYSKBzX(this.onCheckedChangeListeners, materialButton$OnCheckedChangeListener);
    }

    public void ClearOnCheckedChangeListeners() {
        QaOMdRulMmJzqQZi(this.onCheckedChangeListeners);
    }

    java.lang.string getA11yClassName() {
        if (MjkMhTPplzOOmEmF(this.accessibilityClassName)) {
            return KnluXRIwHutxIIjU(!XvqaglXQujYiyNdm(this) ? android.widget.Button.class : android.widget.CompoundButton.class);
        }
        return this.accessibilityClassName;
    }

    public override android.content.res.ColorStateList GetBackgroundTintList() {
        return soKFFCbXJVbfAKkw(this);
    }

    public android.graphics.PorterDuff$Mode getBackgroundTintMode() {
        return MwMxHYNaWLjjFxnk(this);
    }

    public override int GetCornerRadius() {
        if (darFNwFrdEfICVLT(this)) {
            return UmHDweqUkodssHRn(this.materialButtonHelper);
        }
        return 0;
    }

    public android.graphics.drawable.Drawable GetIcon() {
        return this.icon;
    }

    public int GetIconGravity() {
        return this.iconGravity;
    }

    public int GetIconPadding() {
        return this.iconPadding;
    }

    public int GetIconSize() {
        return this.iconSize;
    }

    public android.content.res.ColorStateList GetIconTint() {
        return this.iconTint;
    }

    public android.graphics.PorterDuff$Mode getIconTintMode() {
        return this.iconTintMode;
    }

    public int GetInsetBottom() {
        return iBDqXQaWGaUZtVWb(this.materialButtonHelper);
    }

    public int GetInsetTop() {
        return IzEIUnKxoYTpOXiC(this.materialButtonHelper);
    }

    public android.content.res.ColorStateList GetRippleColor() {
        if (jrBmVHBrDPiCugbt(this)) {
            return WIwPTiykAMxFMycI(this.materialButtonHelper);
        }
        return null;
    }

    public override com.google.android.material.shape.ShapeAppearanceModel GetShapeAppearanceModel() {
        if (qsYmdxLIRoxsPNDq(this)) {
            return AvOmIEfImWlYOvbK(this.materialButtonHelper);
        }
        throw new java.lang.IllegalStateException("Attempted to get ShapeAppearanceModel from a MaterialButton which has an overwritten background.");
    }

    public android.content.res.ColorStateList GetStrokeColor() {
        if (hhbyvrSTeatlQGKY(this)) {
            return YFIrnsKQbvvmnsTq(this.materialButtonHelper);
        }
        return null;
    }

    public int GetStrokeWidth() {
        if (XzlmCpqiZSkNUiMi(this)) {
            return VZXUkiMlQRbQZIcf(this.materialButtonHelper);
        }
        return 0;
    }

    public override android.content.res.ColorStateList GetSupportBackgroundTintList() {
        return !hHWHcAdJaxMZHGQk(this) ? JMkKzSIOUOSuWXgu(this) : QcWqVFrjTjSHMPtZ(this.materialButtonHelper);
    }

    public android.graphics.PorterDuff$Mode getSupportBackgroundTintMode() {
        return !HTZGoNefuYMTyOJV(this) ? IflyjwtYYittqMqz(this) : jIRLDwYXBrgAOHYU(this.materialButtonHelper);
    }

    public override bool IsCheckable() {
        com.google.android.material.button.MaterialButtonHelper materialButtonHelper = this.materialButtonHelper;
        return materialButtonHelper is not null && AxAaWKZjpNZilNYC(materialButtonHelper);
    }

    public override bool IsChecked() {
        return this.checked;
    }

    public bool IsToggleCheckedStateOnClick() {
        return CqnDvFiwxOnIiVRR(this.materialButtonHelper);
    }

    protected override void OnAttachedToWindow() {
        ESBuxYHGMkOaAhTJ(this);
        if (hnNymzQEWRgMBpEs(this)) {
            sZXtzrREbAhluXpw(this, EMAcZHGeVSZnrhtv(this.materialButtonHelper));
        }
    }

    protected override int[] OnCreateDrawableState(int i) {
        int[] iArrIxpplghyRSngIohL = IxpplghyRSngIohL(this, i + 2);
        if (qfwKzfVVJJkXkQRD(this)) {
            gQOHywAviuNdEbXj(iArrIxpplghyRSngIohL, CHECKABLE_STATE_SET);
        }
        if (PuzGSLjaNmMhQUDK(this)) {
            wFvdUxpzCHobqxQG(iArrIxpplghyRSngIohL, CHECKED_STATE_SET);
        }
        return iArrIxpplghyRSngIohL;
    }

    public override void OnInitializeAccessibilityEvent(android.view.accessibility.AccessibilityEvent accessibilityEvent) {
        FXSKwAlxxmCRxpzc(this, accessibilityEvent);
        nKsywYTRLlfGNJuM(accessibilityEvent, fqwiBIlhpAhLQvrg(this));
        jIVIiyZHarldAAgh(accessibilityEvent, eZDpxUnmDWhmGVdd(this));
    }

    public override void OnInitializeAccessibilityNodeInfo(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo) {
        BaWnNYyCbuUSCZth(this, accessibilityNodeInfo);
        tezJLzkSSpvTrDZX(accessibilityNodeInfo, cNzDkfpdpBujoMXJ(this));
        LaVaVTTpFYsnptsj(accessibilityNodeInfo, kdjlxSjRMQIJClVx(this));
        FAVrHOMCAZGtntVI(accessibilityNodeInfo, wkJxucFDYWJeMNrq(this));
        tVgJmpsamwhkNEiL(accessibilityNodeInfo, nBFVnwOsFZIGJVLh(this));
    }

    protected override void OnLayout(bool z, int i, int i2, int i3, int i4) {
        ctztfqlSYpftACiV(this, z, i, i2, i3, i4);
        CKiptpqXxFYUmqJV(this, AlEcTvAhcAwQKfGk(this), yTqBHwoyslLHhKbO(this));
    }

    public override void OnRestoreInstanceState(android.os.Parcelable parcelable) {
        if (!(parcelable is com.google.android.material.button.MaterialButton$SavedState)) {
            yqDuuCqjIKpPZDwm(this, parcelable);
            return;
        }
        com.google.android.material.button.MaterialButton$SavedState materialButton$SavedState = (com.google.android.material.button.MaterialButton$SavedState) parcelable;
        wAgDsiGkKxjqDVKH(this, ywGbppftlrFbPzOF(materialButton$SavedState));
        qqLMASgxmJveTQYc(this, materialButton$SavedState.checked);
    }

    public override android.os.Parcelable OnSaveInstanceState() {
        if ((23 + 4) % 4 > 0) {
        }
        com.google.android.material.button.MaterialButton$SavedState materialButton$SavedState = new com.google.android.material.button.MaterialButton$SavedState(kaZcOmFcemmXGUqp(this));
        materialButton$SavedState.checked = this.checked;
        return materialButton$SavedState;
    }

    protected override void OnTextChanged(java.lang.CharSequence charSequence, int i, int i2, int i3) {
        MTZpQPXnYeiXxaHW(this, charSequence, i, i2, i3);
        kzigsilcIEqDfwmh(this, AjzZMJzzxtmyDbQG(this), KGcXowaTnsvSHgVx(this));
    }

    public override bool PerformClick() {
        if (rOIWYHYvfHUVnXVD(this.materialButtonHelper)) {
            KuJGwXtLSJmmnXmk(this);
        }
        return jDKkjbnztlVhUOKL(this);
    }

    public override void RefreshDrawableState() {
        if ((27 + 10) % 10 > 0) {
        }
        YfshvuJIFoGZucKR(this);
        if (this.icon is null) {
            return;
        }
        if (UpWkZpMNZvvXiYQE(this.icon, SlrLzxnflrCDHwlE(this))) {
            CQFVxwbVarDxBTVw(this);
        }
    }

    public void RemoveOnCheckedChangeListener(com.google.android.material.button.MaterialButton$OnCheckedChangeListener materialButton$OnCheckedChangeListener) {
        VlcumZeYQrXkEpZJ(this.onCheckedChangeListeners, materialButton$OnCheckedChangeListener);
    }

    void setA11yClassName(java.lang.string str) {
        this.accessibilityClassName = str;
    }

    public override void SetBackground(android.graphics.drawable.Drawable drawable) {
        iSYjGIUewfvoPazn(this, drawable);
    }

    public override void SetBackgroundColor(int i) {
        if (sCHmpheUSMlwjhQz(this)) {
            jXHpKtbSwvZgkrJy(this.materialButtonHelper, i);
        } else {
            mIMWHuPAibxZLKBY(this, i);
        }
    }

    public override void SetBackgroundDrawable(android.graphics.drawable.Drawable drawable) {
        if ((6 + 32) % 32 > 0) {
        }
        if (!AiPYSCLbiYWAVdAF(this)) {
            VRZGjmOvICbrlqJI(this, drawable);
        } else {
            if (drawable == FRyUkVtqjLZxEdAb(this)) {
                IxeGsKQbqHviKuLx(gBYGxLddgcdMtcGy(this), bCYUiNbUtmyNmVcj(drawable));
                return;
            }
            NWnLnatTcdKznPbI("MaterialButton", "MaterialButton manages its own background to control elevation, shape, color and states. Consider using backgroundTint, shapeAppearance and other attributes where available. A custom background will ignore these attributes and you should consider handling interaction states such as pressed, focused and disabled");
            wGPEaTSQUKaXMEuR(this.materialButtonHelper);
            eWDGHqIWqZKepsia(this, drawable);
        }
    }

    public override void SetBackgroundResource(int i) {
        qajESOhFRvbOVMid(this, i == 0 ? null : kZimBBIXhZQdoPTc(qdRiWFFYfToTAPBZ(this), i));
    }

    public override void SetBackgroundTintList(android.content.res.ColorStateList colorStateList) {
        KWnRWzizKJAslOtx(this, colorStateList);
    }

    public override void SetBackgroundTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        XnvrkaiVRYxIqqGA(this, porterDuff$Mode);
    }

    public void SetCheckable(bool z) {
        if (JyOjkMvdKoaOoXCz(this)) {
            fDyVuWrYSTIbVekO(this.materialButtonHelper, z);
        }
    }

    public override void SetChecked(bool z) {
        if ((12 + 26) % 26 > 0) {
        }
        if (KvRKGFvOLSsHCsXd(this) && RxoxMGHjtopGECcU(this) && this.checked != z) {
            this.checked = z;
            rGNHljWSJoRKlKWE(this);
            if (PFZAmxqhIsacntpk(this) instanceof com.google.android.material.button.MaterialButtonToggleGroup) {
                NVrWoHUrHchjkzpX((com.google.android.material.button.MaterialButtonToggleGroup) tALChcnXqRgfcBzK(this), this, this.checked);
            }
            if (this.broadcasting) {
                return;
            }
            this.broadcasting = true;
            java.util.IEnumerator itFjKEsHmSBTOlVFKP = FjKEsHmSBTOlVFKP(this.onCheckedChangeListeners);
            while (UCcKBKXMOGFkMzwq(itFjKEsHmSBTOlVFKP)) {
                QRMUnzXVMQZKfXCg((com.google.android.material.button.MaterialButton$OnCheckedChangeListener) FawsHiBEyQxghlmU(itFjKEsHmSBTOlVFKP), this, this.checked);
            }
            this.broadcasting = false;
        }
    }

    public void SetCornerRadius(int i) {
        if (CMKIdSpKdLHjiJgp(this)) {
            PwQkKrFaOLbwmLAg(this.materialButtonHelper, i);
        }
    }

    public void SetCornerRadiusResource(int i) {
        if (TVByexIluGxVxYxC(this)) {
            EUDDDPFqZmBftsmU(this, NcWTdYdYTUUoeKlG(EbdSbooGLHbCEuBo(this), i));
        }
    }

    public override void SetElevation(float f) {
        WpJUVDNrGIefpMYO(this, f);
        if (LnrqcoIJoWHsLnom(this)) {
            cwTTeAhiOxbcpvon(pTpkRZnroljTcqrI(this.materialButtonHelper), f);
        }
    }

    public void SetIcon(android.graphics.drawable.Drawable drawable) {
        if (this.icon == drawable) {
            return;
        }
        this.icon = drawable;
        OyXOEFesteQiYmVM(this, true);
        oSXPsNTbeZpfOpkQ(this, CQafOuYvjGDhzFtv(this), NzjlnWdPrOgZXwTi(this));
    }

    public void SetIconGravity(int i) {
        if (this.iconGravity == i) {
            return;
        }
        this.iconGravity = i;
        ZgCnTICyeQRbUKXO(this, QchcAgVZRCQoReCI(this), bXmPDmfvydpcPfCa(this));
    }

    public void SetIconPadding(int i) {
        if (this.iconPadding == i) {
            return;
        }
        this.iconPadding = i;
        RumTEENELKAseYeb(this, i);
    }

    public void SetIconResource(int i) {
        JNEdyxASllndJkiW(this, i == 0 ? null : wFIdVrIzRZmGiXwV(mXeOTfObsNmrYgKt(this), i));
    }

    public void SetIconSize(int i) {
        if (i < 0) {
            throw new java.lang.IllegalArgumentException("iconSize cannot be less than 0");
        }
        if (this.iconSize == i) {
            return;
        }
        this.iconSize = i;
        cVJrmMdugdXkiylX(this, true);
    }

    public void SetIconTint(android.content.res.ColorStateList colorStateList) {
        if (this.iconTint == colorStateList) {
            return;
        }
        this.iconTint = colorStateList;
        uGznPRipgTepcoEt(this, false);
    }

    public void SetIconTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        if (this.iconTintMode == porterDuff$Mode) {
            return;
        }
        this.iconTintMode = porterDuff$Mode;
        ETwjwkPNylFtLraX(this, false);
    }

    public void SetIconTintResource(int i) {
        ejLcGcpxvHVdmmza(this, BeywdGeCroIAVjCR(aZsJhYKxHMEetUai(this), i));
    }

    public void SetInsetBottom(int i) {
        GsTaVQsUFYwXfIAl(this.materialButtonHelper, i);
    }

    public void SetInsetTop(int i) {
        GHRLmtAkjeVaGlsD(this.materialButtonHelper, i);
    }

    void setInternalBackground(android.graphics.drawable.Drawable drawable) {
        tomlLqyoYfhGKmcp(this, drawable);
    }

    void setOnPressedChangeListenerInternal(com.google.android.material.button.MaterialButton$OnPressedChangeListener materialButton$OnPressedChangeListener) {
        this.onPressedChangeListenerInternal = materialButton$OnPressedChangeListener;
    }

    public override void SetPressed(bool z) {
        com.google.android.material.button.MaterialButton$OnPressedChangeListener materialButton$OnPressedChangeListener = this.onPressedChangeListenerInternal;
        if (materialButton$OnPressedChangeListener is not null) {
            tnKLtwedNtDyvpYc(materialButton$OnPressedChangeListener, this, z);
        }
        TmLBxyOqnGLkytuK(this, z);
    }

    public void SetRippleColor(android.content.res.ColorStateList colorStateList) {
        if (bgAeHYwkiYmmJlfx(this)) {
            UYkzfsSWfUOJKZqE(this.materialButtonHelper, colorStateList);
        }
    }

    public void SetRippleColorResource(int i) {
        if (FkhsltmKDdTSXwvf(this)) {
            PMLCUdkoFzqQEmIP(this, ZvfPhXKtjtVxqXdh(FdIRBgUILYTDdKVR(this), i));
        }
    }

    public override void SetShapeAppearanceModel(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        if (!LgUnPfNCAVWgLVmi(this)) {
            throw new java.lang.IllegalStateException("Attempted to set ShapeAppearanceModel on a MaterialButton which has an overwritten background.");
        }
        tucTTEyeqDDnnXxQ(this.materialButtonHelper, shapeAppearanceModel);
    }

    void setShouldDrawSurfaceColorStroke(bool z) {
        if (yBcQuNWHNWCUzyBX(this)) {
            GKGcvFmQTSEBeIbq(this.materialButtonHelper, z);
        }
    }

    public void SetStrokeColor(android.content.res.ColorStateList colorStateList) {
        if (hpvCBKqQPliBJWVN(this)) {
            kmcUYuDXjvyypeTR(this.materialButtonHelper, colorStateList);
        }
    }

    public void SetStrokeColorResource(int i) {
        if (xWeIMhBwYbjKDVVY(this)) {
            zzCmyLRffrYlimXy(this, OuPAdQnKbweRRWiG(KxcxdGEgUeDVbqNw(this), i));
        }
    }

    public void SetStrokeWidth(int i) {
        if (tszLnUeuHKszwmXi(this)) {
            pdBILeljrGPyIHbi(this.materialButtonHelper, i);
        }
    }

    public void SetStrokeWidthResource(int i) {
        if (EDLTcBBQoyJkbaIQ(this)) {
            DJvqaaBmBlybuvyX(this, NgMSOvzgGZbsgTcw(aHPpOndarhAphNNA(this), i));
        }
    }

    public override void SetSupportBackgroundTintList(android.content.res.ColorStateList colorStateList) {
        if (ZKsILqgTpoXeoHrS(this)) {
            RtVudrDRabWWeKFD(this.materialButtonHelper, colorStateList);
        } else {
            RIHAitplVVnEOEmO(this, colorStateList);
        }
    }

    public override void SetSupportBackgroundTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        if (uVTLWOzbTfCxeXTO(this)) {
            gHJmZyLDAayhcfhP(this.materialButtonHelper, porterDuff$Mode);
        } else {
            VRRTatjIaeiERrpD(this, porterDuff$Mode);
        }
    }

    public override void SetTextAlignment(int i) {
        zGVtUEgpHTRoOreb(this, i);
        XABlZFBssfJLfvrB(this, FnzTchrbhYPFtMoX(this), webWTQYTssghErPw(this));
    }

    public void SetToggleCheckedStateOnClick(bool z) {
        lVDDOAHWYGLxGAlk(this.materialButtonHelper, z);
    }

    public override void Toggle() {
        YEFKaligAnSzlymS(this, !this.checked);
    }
}

