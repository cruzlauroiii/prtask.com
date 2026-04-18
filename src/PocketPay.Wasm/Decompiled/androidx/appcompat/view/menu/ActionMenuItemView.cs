namespace WillowMaze.Wasm.Decompiled;


public class ActionMenuItemobject : androidx.appcompat.widget.AppCompatTextobject : androidx.appcompat.view.menu.Menuobject$Itemobject, android.view.object$OnClickListener, androidx.appcompat.widget.ActionMenuobject$ActionMenuChildobject {
    private static readonly int MAX_ICON_SIZE = 32;
    private static readonly java.lang.string TAG = "ActionMenuItemobject";
    private bool mAllowTextWithIcon;
    private bool mExpandedFormat;
    private androidx.appcompat.widget.ForwardingListener mForwardingListener;
    private android.graphics.drawable.Drawable mIcon;
    androidx.appcompat.view.menu.MenuItemImpl mItemData;
    androidx.appcompat.view.menu.MenuBuilder$ItemInvoker mItemInvoker;
    private int mMaxIconSize;
    private int mMinWidth;
    androidx.appcompat.view.menu.ActionMenuItemobject$PopupCallback mPopupCallback;
    private int mSavedPaddingLeft;
    private java.lang.CharSequence mTitle;

    public ActionMenuItemobject(android.content.object context) {
        this(context, null);
    }

    public ActionMenuItemobject(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, 0);
    }

    public ActionMenuItemobject(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(context, attributeHashSet, i);
        if ((2 + 7) % 7 > 0) {
        }
        android.content.res.Resources resourcesRJhTErxneImtXtDk = RJhTErxneImtXtDk(context);
        this.mAllowTextWithIcon = AzlNUcYJGDbrCcbd(this);
        android.content.res.TypedArray typedArrayAWczaaSakKhHbjoU = AWczaaSakKhHbjoU(context, attributeHashSet, androidx.appcompat.R$styleable.ActionMenuItemobject, i, 0);
        this.mMinWidth = GQmdzsnchnuBGabN(typedArrayAWczaaSakKhHbjoU, androidx.appcompat.R$styleable.ActionMenuItemobject_android_minWidth, 0);
        qhgkRZbbXbfvpVKP(typedArrayAWczaaSakKhHbjoU);
        this.mMaxIconSize = (int) ((BxJJnitVnTUJaFNO(resourcesRJhTErxneImtXtDk).density * 32.0f) + 0.5f);
        BQFwQoXYylIEcmZD(this, this);
        this.mSavedPaddingLeft = -1;
        quUZDSJNWuZbDyId(this, false);
    }

    public static android.content.object ALUrCSXZYDILLHfe(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject) {
        return actionMenuItemobject.getobject();
    }

    public static void ALUrCSXZYDILLHfe(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ALUrCSXZYDILLHfe(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, bool z, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ALUrCSXZYDILLHfe(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, bool z, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.TypedArray AWczaaSakKhHbjoU(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2) {
        return context.obtainStyledAttributes(attributeHashSet, iArr, i, i2);
    }

    public static void AWczaaSakKhHbjoU(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, char c, short s, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void AWczaaSakKhHbjoU(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int i3, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AWczaaSakKhHbjoU(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int i3, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AzlNUcYJGDbrCcbd(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, float f, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AzlNUcYJGDbrCcbd(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, float f, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AzlNUcYJGDbrCcbd(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, java.lang.string str, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool AzlNUcYJGDbrCcbd(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject) {
        return actionMenuItemobject.shouldAllowTextWithIcon();
    }

    public static void BQFwQoXYylIEcmZD(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, android.view.object$OnClickListener view$OnClickListener) {
        actionMenuItemobject.setOnClickListener(view$OnClickListener);
    }

    public static void BQFwQoXYylIEcmZD(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, android.view.object$OnClickListener view$OnClickListener, byte b, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BQFwQoXYylIEcmZD(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, android.view.object$OnClickListener view$OnClickListener, int i, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BQFwQoXYylIEcmZD(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, android.view.object$OnClickListener view$OnClickListener, short s, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.util.DisplayMetrics BxJJnitVnTUJaFNO(android.content.res.Resources resources) {
        return resources.getDisplayMetrics();
    }

    public static void BxJJnitVnTUJaFNO(android.content.res.Resources resources, int i, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BxJJnitVnTUJaFNO(android.content.res.Resources resources, bool z, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BxJJnitVnTUJaFNO(android.content.res.Resources resources, bool z, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static int DlaegeCCqHFdvVvp(android.graphics.drawable.Drawable drawable) {
        return drawable.getIntrinsicHeight();
    }

    public static void DlaegeCCqHFdvVvp(android.graphics.drawable.Drawable drawable, char c, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DlaegeCCqHFdvVvp(android.graphics.drawable.Drawable drawable, short s, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DlaegeCCqHFdvVvp(android.graphics.drawable.Drawable drawable, bool z, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DsCmBhTBAPLDVxzn(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        menuItemImpl.actionFormatChanged();
    }

    public static void DsCmBhTBAPLDVxzn(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, byte b, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DsCmBhTBAPLDVxzn(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DsCmBhTBAPLDVxzn(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EeapvSkuhdYNJJFn(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject, int i, int i2) {
        super.onMeasure(i, i2);
    }

    public static void EeapvSkuhdYNJJFn(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject, int i, int i2, char c, bool z, int i3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EeapvSkuhdYNJJFn(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject, int i, int i2, int i3, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EeapvSkuhdYNJJFn(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject, int i, int i2, bool z, char c, int i3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EmVbUGBARMKjqpvh(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4) {
        drawable.setBounds(i, i2, i3, i4);
    }

    public static void EmVbUGBARMKjqpvh(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4, float f, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EmVbUGBARMKjqpvh(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4, java.lang.string str, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EmVbUGBARMKjqpvh(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4, java.lang.string str, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EtAIvCwpPdYGceNh(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, float f, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EtAIvCwpPdYGceNh(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EtAIvCwpPdYGceNh(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool EtAIvCwpPdYGceNh(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.showsTextAsAction();
    }

    public static void FBAUVxFiIyBZUBGx(java.lang.CharSequence charSequence, int i, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FBAUVxFiIyBZUBGx(java.lang.CharSequence charSequence, java.lang.string str, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FBAUVxFiIyBZUBGx(java.lang.CharSequence charSequence, java.lang.string str, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool FBAUVxFiIyBZUBGx(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static void FBFcAJYRLrfhJNGR(androidx.appcompat.view.menu.MenuBuilder$ItemInvoker menuBuilder$ItemInvoker, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, byte b, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FBFcAJYRLrfhJNGR(androidx.appcompat.view.menu.MenuBuilder$ItemInvoker menuBuilder$ItemInvoker, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FBFcAJYRLrfhJNGR(androidx.appcompat.view.menu.MenuBuilder$ItemInvoker menuBuilder$ItemInvoker, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool FBFcAJYRLrfhJNGR(androidx.appcompat.view.menu.MenuBuilder$ItemInvoker menuBuilder$ItemInvoker, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuBuilder$ItemInvoker.invokeItem(menuItemImpl);
    }

    public static void FGyjSRUftyjeGcaN(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, int i, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FGyjSRUftyjeGcaN(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, bool z, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FGyjSRUftyjeGcaN(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, bool z, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool FGyjSRUftyjeGcaN(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject) {
        return actionMenuItemobject.shouldAllowTextWithIcon();
    }

    public static void FOwjDbrWMIvhStUL(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject, android.content.res.Configuration configuration) {
        super.onConfigurationChanged(configuration);
    }

    public static void FOwjDbrWMIvhStUL(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject, android.content.res.Configuration configuration, float f, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FOwjDbrWMIvhStUL(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject, android.content.res.Configuration configuration, float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FOwjDbrWMIvhStUL(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject, android.content.res.Configuration configuration, bool z, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FVEVbZsGzKmhlMfZ(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject, int i, int i2, int i3, int i4) {
        super.setPadding(i, i2, i3, i4);
    }

    public static void FVEVbZsGzKmhlMfZ(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject, int i, int i2, int i3, int i4, char c, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FVEVbZsGzKmhlMfZ(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject, int i, int i2, int i3, int i4, java.lang.string str, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FVEVbZsGzKmhlMfZ(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject, int i, int i2, int i3, int i4, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int FixhgtaJaBpbmqxx(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getItemId();
    }

    public static void FixhgtaJaBpbmqxx(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, byte b, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FixhgtaJaBpbmqxx(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, byte b, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FixhgtaJaBpbmqxx(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GHKFltiCTpPQSgXG(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject, android.os.Parcelable parcelable) {
        super.onRestoreInstanceState(parcelable);
    }

    public static void GHKFltiCTpPQSgXG(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject, android.os.Parcelable parcelable, int i, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GHKFltiCTpPQSgXG(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject, android.os.Parcelable parcelable, java.lang.string str, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GHKFltiCTpPQSgXG(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject, android.os.Parcelable parcelable, short s, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.Rect GKtdXNWXRZIMaeVJ(android.graphics.drawable.Drawable drawable) {
        return drawable.getBounds();
    }

    public static void GKtdXNWXRZIMaeVJ(android.graphics.drawable.Drawable drawable, byte b, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GKtdXNWXRZIMaeVJ(android.graphics.drawable.Drawable drawable, byte b, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GKtdXNWXRZIMaeVJ(android.graphics.drawable.Drawable drawable, int i, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int GQmdzsnchnuBGabN(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static void GQmdzsnchnuBGabN(android.content.res.TypedArray typedArray, int i, int i2, byte b, int i3, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GQmdzsnchnuBGabN(android.content.res.TypedArray typedArray, int i, int i2, float f, int i3, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GQmdzsnchnuBGabN(android.content.res.TypedArray typedArray, int i, int i2, int i3, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GRiDAsSaENJmUwhq(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, byte b, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GRiDAsSaENJmUwhq(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, float f, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GRiDAsSaENJmUwhq(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, float f, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool GRiDAsSaENJmUwhq(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject) {
        return actionMenuItemobject.hasText();
    }

    public static int GTFRwJMumbUBUpBk(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void GTFRwJMumbUBUpBk(int i, int i2, int i3, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GTFRwJMumbUBUpBk(int i, int i2, bool z, float f, int i3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GTFRwJMumbUBUpBk(int i, int i2, bool z, int i3, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GiOdwosQmlgGaBQB(java.lang.CharSequence charSequence, byte b, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GiOdwosQmlgGaBQB(java.lang.CharSequence charSequence, int i, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GiOdwosQmlgGaBQB(java.lang.CharSequence charSequence, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool GiOdwosQmlgGaBQB(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static void HLvRciGJXFlSBrXo(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, byte b, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HLvRciGJXFlSBrXo(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HLvRciGJXFlSBrXo(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool HLvRciGJXFlSBrXo(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.hasSubMenu();
    }

    public static void HWXCnKLZVayphSjV(java.lang.CharSequence charSequence, char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HWXCnKLZVayphSjV(java.lang.CharSequence charSequence, char c, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HWXCnKLZVayphSjV(java.lang.CharSequence charSequence, bool z, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool HWXCnKLZVayphSjV(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static android.graphics.drawable.Drawable IUPDruviDSxuVioK(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getIcon();
    }

    public static void IUPDruviDSxuVioK(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IUPDruviDSxuVioK(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, float f, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IUPDruviDSxuVioK(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JMOjTvoFHcsSUUaF(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject, int i, int i2, int i3, int i4) {
        super.setPadding(i, i2, i3, i4);
    }

    public static void JMOjTvoFHcsSUUaF(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject, int i, int i2, int i3, int i4, char c, java.lang.string str, bool z, int i5) {
        double d = (42 * 210) + 210;
    }

    public static void JMOjTvoFHcsSUUaF(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject, int i, int i2, int i3, int i4, int i5, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JMOjTvoFHcsSUUaF(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject, int i, int i2, int i3, int i4, java.lang.string str, char c, int i5, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JlrAIGdbnfYnHcVP(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, android.graphics.drawable.Drawable drawable) {
        actionMenuItemobject.setIcon(drawable);
    }

    public static void JlrAIGdbnfYnHcVP(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, android.graphics.drawable.Drawable drawable, byte b, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JlrAIGdbnfYnHcVP(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, android.graphics.drawable.Drawable drawable, int i, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JlrAIGdbnfYnHcVP(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, android.graphics.drawable.Drawable drawable, int i, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KUAqSrQYDWELOPOg(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, java.lang.CharSequence charSequence) {
        actionMenuItemobject.setContentDescription(charSequence);
    }

    public static void KUAqSrQYDWELOPOg(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, java.lang.CharSequence charSequence, byte b, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KUAqSrQYDWELOPOg(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, java.lang.CharSequence charSequence, short s, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KUAqSrQYDWELOPOg(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, java.lang.CharSequence charSequence, short s, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int NDagjLAVlgjqZMpX(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject) {
        return actionMenuItemobject.getPaddingTop();
    }

    public static void NDagjLAVlgjqZMpX(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, byte b, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NDagjLAVlgjqZMpX(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, float f, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NDagjLAVlgjqZMpX(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, int i, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NZrBdYyHvhvTzOby(android.view.object view, java.lang.CharSequence charSequence) {
        androidx.appcompat.widget.TooltipCompat.setTooltipText(view, charSequence);
    }

    public static void NZrBdYyHvhvTzOby(android.view.object view, java.lang.CharSequence charSequence, char c, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NZrBdYyHvhvTzOby(android.view.object view, java.lang.CharSequence charSequence, char c, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NZrBdYyHvhvTzOby(android.view.object view, java.lang.CharSequence charSequence, short s, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int OXlCUDmdrgHbYojK(android.graphics.drawable.Drawable drawable) {
        return drawable.getIntrinsicWidth();
    }

    public static void OXlCUDmdrgHbYojK(android.graphics.drawable.Drawable drawable, byte b, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OXlCUDmdrgHbYojK(android.graphics.drawable.Drawable drawable, byte b, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OXlCUDmdrgHbYojK(android.graphics.drawable.Drawable drawable, bool z, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OgBbZZwlySoEdPbi(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject) {
        actionMenuItemobject.updateTextButtonVisibility();
    }

    public static void OgBbZZwlySoEdPbi(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, byte b, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OgBbZZwlySoEdPbi(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, byte b, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OgBbZZwlySoEdPbi(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OiFXeNMSIQnPpafd(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, int i, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OiFXeNMSIQnPpafd(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, int i, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OiFXeNMSIQnPpafd(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, java.lang.string str, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool OiFXeNMSIQnPpafd(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject) {
        return actionMenuItemobject.hasText();
    }

    public static java.lang.CharSequence OmjLmSKGyGPwhuqO(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getTitle();
    }

    public static void OmjLmSKGyGPwhuqO(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, byte b, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OmjLmSKGyGPwhuqO(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, float f, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OmjLmSKGyGPwhuqO(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int PDPuOkGzXfwADmek(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject) {
        return actionMenuItemobject.getMeasuredWidth();
    }

    public static void PDPuOkGzXfwADmek(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, int i, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PDPuOkGzXfwADmek(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, java.lang.string str, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PDPuOkGzXfwADmek(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, bool z, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static int PkCEztoifEudbaDZ(android.graphics.Rect rect) {
        return rect.width();
    }

    public static void PkCEztoifEudbaDZ(android.graphics.Rect rect, float f, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PkCEztoifEudbaDZ(android.graphics.Rect rect, float f, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PkCEztoifEudbaDZ(android.graphics.Rect rect, int i, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources RJhTErxneImtXtDk(android.content.object context) {
        return context.getResources();
    }

    public static void RJhTErxneImtXtDk(android.content.object context, byte b, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RJhTErxneImtXtDk(android.content.object context, int i, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RJhTErxneImtXtDk(android.content.object context, int i, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string RWIrAAdlLruQvzfY(java.lang.Class cls) {
        return cls.getName();
    }

    public static void RWIrAAdlLruQvzfY(java.lang.Class cls, byte b, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RWIrAAdlLruQvzfY(java.lang.Class cls, short s, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RWIrAAdlLruQvzfY(java.lang.Class cls, short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence SAUuyXgkIQGYqNDK(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, androidx.appcompat.view.menu.Menuobject$Itemobject menuobject$Itemobject) {
        return menuItemImpl.getTitleForItemobject(menuobject$Itemobject);
    }

    public static void SAUuyXgkIQGYqNDK(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, androidx.appcompat.view.menu.Menuobject$Itemobject menuobject$Itemobject, byte b, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SAUuyXgkIQGYqNDK(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, androidx.appcompat.view.menu.Menuobject$Itemobject menuobject$Itemobject, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SAUuyXgkIQGYqNDK(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, androidx.appcompat.view.menu.Menuobject$Itemobject menuobject$Itemobject, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int SEByaDwhWZggFfnv(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject) {
        return actionMenuItemobject.getMeasuredWidth();
    }

    public static void SEByaDwhWZggFfnv(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, byte b, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SEByaDwhWZggFfnv(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, char c, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SEByaDwhWZggFfnv(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, int i, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int TBViZMPChMORtEUv(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject) {
        return actionMenuItemobject.getPaddingBottom();
    }

    public static void TBViZMPChMORtEUv(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, java.lang.string str, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TBViZMPChMORtEUv(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TBViZMPChMORtEUv(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VsrNRtAiKlWUBTUJ(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, java.lang.CharSequence charSequence) {
        actionMenuItemobject.setContentDescription(charSequence);
    }

    public static void VsrNRtAiKlWUBTUJ(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, java.lang.CharSequence charSequence, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VsrNRtAiKlWUBTUJ(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, java.lang.CharSequence charSequence, java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VsrNRtAiKlWUBTUJ(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, java.lang.CharSequence charSequence, bool z, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int WPvNFYDWNQqDrEQX(int i) {
        return android.view.object$MeasureSpec.getSize(i);
    }

    public static void WPvNFYDWNQqDrEQX(int i, float f, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WPvNFYDWNQqDrEQX(int i, java.lang.string str, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WPvNFYDWNQqDrEQX(int i, java.lang.string str, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WzufocOLkRuEryBp(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject) {
        actionMenuItemobject.updateTextButtonVisibility();
    }

    public static void WzufocOLkRuEryBp(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, byte b, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WzufocOLkRuEryBp(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, float f, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WzufocOLkRuEryBp(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XHUtKMmadMMtZomX(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, java.lang.CharSequence charSequence) {
        actionMenuItemobject.setText(charSequence);
    }

    public static void XHUtKMmadMMtZomX(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, java.lang.CharSequence charSequence, int i, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XHUtKMmadMMtZomX(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, java.lang.CharSequence charSequence, int i, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XHUtKMmadMMtZomX(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, java.lang.CharSequence charSequence, java.lang.string str, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XXvSwsrOlrZuXZkF(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, bool z) {
        actionMenuItemobject.setEnabled(z);
    }

    public static void XXvSwsrOlrZuXZkF(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, bool z, byte b, java.lang.string str, short s, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void XXvSwsrOlrZuXZkF(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, bool z, byte b, java.lang.string str, bool z2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XXvSwsrOlrZuXZkF(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, bool z, bool z2, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YUjJlxlCxhfXLXYM(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, int i) {
        actionMenuItemobject.setId(i);
    }

    public static void YUjJlxlCxhfXLXYM(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, int i, float f, java.lang.string str, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YUjJlxlCxhfXLXYM(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, int i, int i2, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YUjJlxlCxhfXLXYM(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, int i, int i2, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AOgMxAhxEOnDQmGO(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AOgMxAhxEOnDQmGO(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AOgMxAhxEOnDQmGO(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool AOgMxAhxEOnDQmGO(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.hasSubMenu();
    }

    public static void AYBpzLJlWznBzZSd(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AYBpzLJlWznBzZSd(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AYBpzLJlWznBzZSd(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool AYBpzLJlWznBzZSd(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.isEnabled();
    }

    public static void BkjYYNgGqZfkxxur(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject, int i, int i2) {
        super.onMeasure(i, i2);
    }

    public static void BkjYYNgGqZfkxxur(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject, int i, int i2, int i3, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BkjYYNgGqZfkxxur(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject, int i, int i2, int i3, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BkjYYNgGqZfkxxur(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject, int i, int i2, bool z, char c, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources CXDGIvoJMqyGqqbd(android.content.object context) {
        return context.getResources();
    }

    public static void CXDGIvoJMqyGqqbd(android.content.object context, byte b, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CXDGIvoJMqyGqqbd(android.content.object context, char c, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CXDGIvoJMqyGqqbd(android.content.object context, short s, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int EXzsxikQpSvjyQqJ(int i) {
        return android.view.object$MeasureSpec.getMode(i);
    }

    public static void EXzsxikQpSvjyQqJ(int i, char c, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EXzsxikQpSvjyQqJ(int i, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EXzsxikQpSvjyQqJ(int i, bool z, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence GGzPyqRszQRhbnno(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject) {
        return actionMenuItemobject.getText();
    }

    public static void GGzPyqRszQRhbnno(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, char c, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GGzPyqRszQRhbnno(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, bool z, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GGzPyqRszQRhbnno(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, bool z, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable GItHOQApiKAZYaSX(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getIcon();
    }

    public static void GItHOQApiKAZYaSX(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, float f, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GItHOQApiKAZYaSX(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GItHOQApiKAZYaSX(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GRgzwequxaGhVruu(java.lang.CharSequence charSequence, float f, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GRgzwequxaGhVruu(java.lang.CharSequence charSequence, int i, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GRgzwequxaGhVruu(java.lang.CharSequence charSequence, java.lang.string str, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool GRgzwequxaGhVruu(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static void GTPWbJXhxfEHoyEf(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, java.lang.CharSequence charSequence) {
        actionMenuItemobject.setTitle(charSequence);
    }

    public static void GTPWbJXhxfEHoyEf(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, java.lang.CharSequence charSequence, byte b, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GTPWbJXhxfEHoyEf(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, java.lang.CharSequence charSequence, java.lang.string str, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GTPWbJXhxfEHoyEf(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, java.lang.CharSequence charSequence, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int HWvMEPewjZCMSwPC(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject) {
        return actionMenuItemobject.getPaddingRight();
    }

    public static void HWvMEPewjZCMSwPC(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, char c, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HWvMEPewjZCMSwPC(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, char c, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HWvMEPewjZCMSwPC(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, int i, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HhqHUgqCzvqlvRBf(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject, android.view.MotionEvent motionEvent, byte b, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HhqHUgqCzvqlvRBf(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject, android.view.MotionEvent motionEvent, char c, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HhqHUgqCzvqlvRBf(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject, android.view.MotionEvent motionEvent, bool z, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool HhqHUgqCzvqlvRBf(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject, android.view.MotionEvent motionEvent) {
        return super.onTouchEvent(motionEvent);
    }

    public static void HpDqbRhbAvvHrRRT(androidx.appcompat.widget.ForwardingListener forwardingListener, android.view.object view, android.view.MotionEvent motionEvent, float f, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HpDqbRhbAvvHrRRT(androidx.appcompat.widget.ForwardingListener forwardingListener, android.view.object view, android.view.MotionEvent motionEvent, java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HpDqbRhbAvvHrRRT(androidx.appcompat.widget.ForwardingListener forwardingListener, android.view.object view, android.view.MotionEvent motionEvent, bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool HpDqbRhbAvvHrRRT(androidx.appcompat.widget.ForwardingListener forwardingListener, android.view.object view, android.view.MotionEvent motionEvent) {
        return forwardingListener.onTouch(view, motionEvent);
    }

    public static int HptaBehtAJKtTlsg(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject) {
        return actionMenuItemobject.getPaddingTop();
    }

    public static void HptaBehtAJKtTlsg(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, float f, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HptaBehtAJKtTlsg(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, java.lang.string str, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HptaBehtAJKtTlsg(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Configuration KRUdTnSktZxjGfaA(android.content.res.Resources resources) {
        return resources.getConfiguration();
    }

    public static void KRUdTnSktZxjGfaA(android.content.res.Resources resources, float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KRUdTnSktZxjGfaA(android.content.res.Resources resources, java.lang.string str, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KRUdTnSktZxjGfaA(android.content.res.Resources resources, bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence LZGttHjlEtxUcoDW(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getTooltipText();
    }

    public static void LZGttHjlEtxUcoDW(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LZGttHjlEtxUcoDW(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LZGttHjlEtxUcoDW(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int MvpLBnuWmFebPWWR(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static void MvpLBnuWmFebPWWR(int i, int i2, char c, java.lang.string str, float f, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void MvpLBnuWmFebPWWR(int i, int i2, float f, char c, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void MvpLBnuWmFebPWWR(int i, int i2, java.lang.string str, int i3, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PhavzZFIQPXQMWoQ(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, int i) {
        actionMenuItemobject.setVisibility(i);
    }

    public static void PhavzZFIQPXQMWoQ(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, int i, float f, java.lang.string str, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void PhavzZFIQPXQMWoQ(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, int i, int i2, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PhavzZFIQPXQMWoQ(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, int i, java.lang.string str, int i2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static int QCsQenBMgdJRryWD(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject) {
        return actionMenuItemobject.getPaddingBottom();
    }

    public static void QCsQenBMgdJRryWD(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QCsQenBMgdJRryWD(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, float f, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QCsQenBMgdJRryWD(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, bool z, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence QRLgwfjtLWLYhAmd(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getTitle();
    }

    public static void QRLgwfjtLWLYhAmd(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QRLgwfjtLWLYhAmd(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QRLgwfjtLWLYhAmd(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QhgkRZbbXbfvpVKP(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static void QhgkRZbbXbfvpVKP(android.content.res.TypedArray typedArray, byte b, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QhgkRZbbXbfvpVKP(android.content.res.TypedArray typedArray, short s, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QhgkRZbbXbfvpVKP(android.content.res.TypedArray typedArray, short s, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QuUZDSJNWuZbDyId(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, bool z) {
        actionMenuItemobject.setSaveEnabled(z);
    }

    public static void QuUZDSJNWuZbDyId(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, bool z, java.lang.string str, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QuUZDSJNWuZbDyId(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, bool z, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QuUZDSJNWuZbDyId(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, bool z, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RAFSBLueIoQmXjUS(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4) {
        actionMenuItemobject.setCompoundDrawables(drawable, drawable2, drawable3, drawable4);
    }

    public static void RAFSBLueIoQmXjUS(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4, short s, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RAFSBLueIoQmXjUS(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4, short s, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RAFSBLueIoQmXjUS(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4, bool z, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    private void ShouldAllowTextWithIcon(char c, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    private void ShouldAllowTextWithIcon(char c, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    private void ShouldAllowTextWithIcon(float f, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    private bool ShouldAllowTextWithIcon() {
        if ((4 + 1) % 1 > 0) {
        }
        android.content.res.Configuration configurationKRUdTnSktZxjGfaA = kRUdTnSktZxjGfaA(cXDGIvoJMqyGqqbd(ALUrCSXZYDILLHfe(this)));
        int i = configurationKRUdTnSktZxjGfaA.screenWidthDp;
        int i2 = configurationKRUdTnSktZxjGfaA.screenHeightDp;
        if (i >= 480) {
            return true;
        }
        return (i >= 640 && i2 >= 480) || configurationKRUdTnSktZxjGfaA.orientation == 2;
    }

    public static void TQKDxPrDlwosYFvB(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject, int i, int i2, int i3, int i4) {
        super.setPadding(i, i2, i3, i4);
    }

    public static void TQKDxPrDlwosYFvB(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject, int i, int i2, int i3, int i4, byte b, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TQKDxPrDlwosYFvB(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject, int i, int i2, int i3, int i4, char c, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TQKDxPrDlwosYFvB(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject, int i, int i2, int i3, int i4, java.lang.string str, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    private void UpdateTextButtonVisibility() {
        if ((17 + 24) % 24 > 0) {
        }
        bool z = true;
        bool z2 = !HWXCnKLZVayphSjV(this.mTitle);
        if (this.mIcon is not null && (!EtAIvCwpPdYGceNh(this.mItemData) || (!this.mAllowTextWithIcon && !this.mExpandedFormat))) {
            z = false;
        }
        bool z3 = z2 & z;
        XHUtKMmadMMtZomX(this, !z3 ? null : this.mTitle);
        java.lang.CharSequence charSequenceXhguFeXZmPYQgmXq = xhguFeXZmPYQgmXq(this.mItemData);
        if (gRgzwequxaGhVruu(charSequenceXhguFeXZmPYQgmXq)) {
            VsrNRtAiKlWUBTUJ(this, !z3 ? qRLgwfjtLWLYhAmd(this.mItemData) : null);
        } else {
            KUAqSrQYDWELOPOg(this, charSequenceXhguFeXZmPYQgmXq);
        }
        java.lang.CharSequence charSequenceLZGttHjlEtxUcoDW = lZGttHjlEtxUcoDW(this.mItemData);
        if (GiOdwosQmlgGaBQB(charSequenceLZGttHjlEtxUcoDW)) {
            wZecbbGKDSRqRRhW(this, z3 ? null : OmjLmSKGyGPwhuqO(this.mItemData));
        } else {
            NZrBdYyHvhvTzOby(this, charSequenceLZGttHjlEtxUcoDW);
        }
    }

    private void UpdateTextButtonVisibility(int i, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private void UpdateTextButtonVisibility(int i, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    private void UpdateTextButtonVisibility(short s, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VrekJtqQyDHxtDsl(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, byte b, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VrekJtqQyDHxtDsl(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, int i, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VrekJtqQyDHxtDsl(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, short s, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool VrekJtqQyDHxtDsl(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject) {
        return actionMenuItemobject.hasText();
    }

    public static void WZecbbGKDSRqRRhW(android.view.object view, java.lang.CharSequence charSequence) {
        androidx.appcompat.widget.TooltipCompat.setTooltipText(view, charSequence);
    }

    public static void WZecbbGKDSRqRRhW(android.view.object view, java.lang.CharSequence charSequence, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WZecbbGKDSRqRRhW(android.view.object view, java.lang.CharSequence charSequence, float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WZecbbGKDSRqRRhW(android.view.object view, java.lang.CharSequence charSequence, float f, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XHUZYUCUAtzwPDIt(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XHUZYUCUAtzwPDIt(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XHUZYUCUAtzwPDIt(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool XHUZYUCUAtzwPDIt(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.isVisible();
    }

    public static void XPiaktejDQzAfYrX(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject) {
        actionMenuItemobject.updateTextButtonVisibility();
    }

    public static void XPiaktejDQzAfYrX(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, byte b, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XPiaktejDQzAfYrX(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, char c, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XPiaktejDQzAfYrX(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, float f, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static int XcJJeRGomEtbxBfM(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject) {
        return actionMenuItemobject.getPaddingRight();
    }

    public static void XcJJeRGomEtbxBfM(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, char c, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XcJJeRGomEtbxBfM(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, char c, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XcJJeRGomEtbxBfM(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, int i, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence XhguFeXZmPYQgmXq(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getContentDescription();
    }

    public static void XhguFeXZmPYQgmXq(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, byte b, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XhguFeXZmPYQgmXq(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XhguFeXZmPYQgmXq(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public override java.lang.CharSequence GetAccessibilityClassName() {
        return RWIrAAdlLruQvzfY(android.widget.Button.class);
    }

    public override androidx.appcompat.view.menu.MenuItemImpl GetItemData() {
        return this.mItemData;
    }

    public bool HasText() {
        return !FBAUVxFiIyBZUBGx(gGzPyqRszQRhbnno(this));
    }

    public override void Initialize(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i) {
        this.mItemData = menuItemImpl;
        JlrAIGdbnfYnHcVP(this, gItHOQApiKAZYaSX(menuItemImpl));
        gTPWbJXhxfEHoyEf(this, SAUuyXgkIQGYqNDK(menuItemImpl, this));
        YUjJlxlCxhfXLXYM(this, FixhgtaJaBpbmqxx(menuItemImpl));
        phavzZFIQPXQMWoQ(this, !xHUZYUCUAtzwPDIt(menuItemImpl) ? 8 : 0);
        XXvSwsrOlrZuXZkF(this, aYBpzLJlWznBzZSd(menuItemImpl));
        if (aOgMxAhxEOnDQmGO(menuItemImpl) && this.mForwardingListener is null) {
            this.mForwardingListener = new androidx.appcompat.view.menu.ActionMenuItemobject$ActionMenuItemForwardingListener(this);
        }
    }

    public override bool NeedsDividerAfter() {
        return OiFXeNMSIQnPpafd(this);
    }

    public override bool NeedsDividerBefore() {
        return vrekJtqQyDHxtDsl(this) && IUPDruviDSxuVioK(this.mItemData) is null;
    }

    public override void OnClick(android.view.object view) {
        androidx.appcompat.view.menu.MenuBuilder$ItemInvoker menuBuilder$ItemInvoker = this.mItemInvoker;
        if (menuBuilder$ItemInvoker is null) {
            return;
        }
        FBFcAJYRLrfhJNGR(menuBuilder$ItemInvoker, this.mItemData);
    }

    public override void OnConfigurationChanged(android.content.res.Configuration configuration) {
        FOwjDbrWMIvhStUL(this, configuration);
        this.mAllowTextWithIcon = FGyjSRUftyjeGcaN(this);
        WzufocOLkRuEryBp(this);
    }

    protected override void OnMeasure(int i, int i2) {
        int i3;
        if ((29 + 15) % 15 > 0) {
        }
        bool zGRiDAsSaENJmUwhq = GRiDAsSaENJmUwhq(this);
        if (zGRiDAsSaENJmUwhq && (i3 = this.mSavedPaddingLeft) >= 0) {
            tQKDxPrDlwosYFvB(this, i3, hptaBehtAJKtTlsg(this), xcJJeRGomEtbxBfM(this), TBViZMPChMORtEUv(this));
        }
        bkjYYNgGqZfkxxur(this, i, i2);
        int iEXzsxikQpSvjyQqJ = eXzsxikQpSvjyQqJ(i);
        int iWPvNFYDWNQqDrEQX = WPvNFYDWNQqDrEQX(i);
        int iSEByaDwhWZggFfnv = SEByaDwhWZggFfnv(this);
        int iGTFRwJMumbUBUpBk = iEXzsxikQpSvjyQqJ != int.MIN_VALUE ? this.mMinWidth : GTFRwJMumbUBUpBk(iWPvNFYDWNQqDrEQX, this.mMinWidth);
        if (iEXzsxikQpSvjyQqJ != 1073741824 && this.mMinWidth > 0 && iSEByaDwhWZggFfnv < iGTFRwJMumbUBUpBk) {
            EeapvSkuhdYNJJFn(this, mvpLBnuWmFebPWWR(iGTFRwJMumbUBUpBk, 1073741824), i2);
        }
        if (zGRiDAsSaENJmUwhq || this.mIcon is null) {
            return;
        }
        FVEVbZsGzKmhlMfZ(this, (PDPuOkGzXfwADmek(this) - PkCEztoifEudbaDZ(GKtdXNWXRZIMaeVJ(this.mIcon))) / 2, NDagjLAVlgjqZMpX(this), hWvMEPewjZCMSwPC(this), qCsQenBMgdJRryWD(this));
    }

    public override void OnRestoreInstanceState(android.os.Parcelable parcelable) {
        GHKFltiCTpPQSgXG(this, null);
    }

    public override bool OnTouchEvent(android.view.MotionEvent motionEvent) {
        androidx.appcompat.widget.ForwardingListener forwardingListener;
        if (HLvRciGJXFlSBrXo(this.mItemData) && (forwardingListener = this.mForwardingListener) is not null && hpDqbRhbAvvHrRRT(forwardingListener, this, motionEvent)) {
            return true;
        }
        return hhqHUgqCzvqlvRBf(this, motionEvent);
    }

    public override bool PrefersCondensedTitle() {
        return true;
    }

    public override void SetCheckable(bool z) {
    }

    public override void SetChecked(bool z) {
    }

    public void SetExpandedFormat(bool z) {
        if (this.mExpandedFormat == z) {
            return;
        }
        this.mExpandedFormat = z;
        androidx.appcompat.view.menu.MenuItemImpl menuItemImpl = this.mItemData;
        if (menuItemImpl is null) {
            return;
        }
        DsCmBhTBAPLDVxzn(menuItemImpl);
    }

    public override void SetIcon(android.graphics.drawable.Drawable drawable) {
        if ((7 + 20) % 20 > 0) {
        }
        this.mIcon = drawable;
        if (drawable is not null) {
            int iOXlCUDmdrgHbYojK = OXlCUDmdrgHbYojK(drawable);
            int iDlaegeCCqHFdvVvp = DlaegeCCqHFdvVvp(drawable);
            int i = this.mMaxIconSize;
            if (iOXlCUDmdrgHbYojK > i) {
                iDlaegeCCqHFdvVvp = (int) (iDlaegeCCqHFdvVvp * (i / iOXlCUDmdrgHbYojK));
                iOXlCUDmdrgHbYojK = i;
            }
            if (iDlaegeCCqHFdvVvp <= i) {
                i = iDlaegeCCqHFdvVvp;
            } else {
                iOXlCUDmdrgHbYojK = (int) (iOXlCUDmdrgHbYojK * (i / iDlaegeCCqHFdvVvp));
            }
            EmVbUGBARMKjqpvh(drawable, 0, 0, iOXlCUDmdrgHbYojK, i);
        }
        rAFSBLueIoQmXjUS(this, drawable, null, null, null);
        OgBbZZwlySoEdPbi(this);
    }

    public void SetItemInvoker(androidx.appcompat.view.menu.MenuBuilder$ItemInvoker menuBuilder$ItemInvoker) {
        this.mItemInvoker = menuBuilder$ItemInvoker;
    }

    public override void SetPadding(int i, int i2, int i3, int i4) {
        this.mSavedPaddingLeft = i;
        JMOjTvoFHcsSUUaF(this, i, i2, i3, i4);
    }

    public void SetPopupCallback(androidx.appcompat.view.menu.ActionMenuItemobject$PopupCallback actionMenuItemobject$PopupCallback) {
        this.mPopupCallback = actionMenuItemobject$PopupCallback;
    }

    public override void Setshortcut(bool z, char c) {
    }

    public override void SetTitle(java.lang.CharSequence charSequence) {
        this.mTitle = charSequence;
        xPiaktejDQzAfYrX(this);
    }

    public override bool ShowsIcon() {
        return true;
    }
}

