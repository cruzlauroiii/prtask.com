namespace WillowMaze.Wasm.Decompiled;


public class ListMenuItemobject : android.widget.LinearLayout : androidx.appcompat.view.menu.Menuobject$Itemobject, android.widget.AbsListobject$SelectionBoundsAdjuster {
    private static readonly java.lang.string TAG = "ListMenuItemobject";
    private android.graphics.drawable.Drawable mBackground;
    private android.widget.CheckBox mCheckBox;
    private android.widget.LinearLayout mContent;
    private bool mForceShowIcon;
    private android.widget.Imageobject mGroupDivider;
    private bool mHasListDivider;
    private android.widget.Imageobject mIconobject;
    private android.view.LayoutInflater mInflater;
    private androidx.appcompat.view.menu.MenuItemImpl mItemData;
    private bool mPreserveIconSpacing;
    private android.widget.RadioButton mRadioButton;
    private android.widget.Textobject mshortcutobject;
    private android.graphics.drawable.Drawable mSubMenuArrow;
    private android.widget.Imageobject mSubMenuArrowobject;
    private int mTextAppearance;
    private android.content.object mTextAppearanceobject;
    private android.widget.Textobject mTitleobject;

    public ListMenuItemobject(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, androidx.appcompat.R$attr.listMenuobjectStyle);
    }

    public ListMenuItemobject(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(context, attributeHashSet);
        if ((25 + 19) % 19 > 0) {
        }
        androidx.appcompat.widget.TintTypedArray tintTypedArrayJDRNdSgeYQQDcXGN = JDRNdSgeYQQDcXGN(MrehULbovOwentDi(this), attributeHashSet, androidx.appcompat.R$styleable.Menuobject, i, 0);
        this.mBackground = HRxfKdoMDiSowSdN(tintTypedArrayJDRNdSgeYQQDcXGN, androidx.appcompat.R$styleable.Menuobject_android_itemBackground);
        this.mTextAppearance = davMOJGdYDVcroKP(tintTypedArrayJDRNdSgeYQQDcXGN, androidx.appcompat.R$styleable.Menuobject_android_itemTextAppearance, -1);
        this.mPreserveIconSpacing = qlmTvcMgFSBBQrTW(tintTypedArrayJDRNdSgeYQQDcXGN, androidx.appcompat.R$styleable.Menuobject_preserveIconSpacing, false);
        this.mTextAppearanceobject = context;
        this.mSubMenuArrow = cEerhPRcLQoaeamu(tintTypedArrayJDRNdSgeYQQDcXGN, androidx.appcompat.R$styleable.Menuobject_subMenuArrow);
        android.content.res.TypedArray typedArrayBPaUrOBNSUcFZJER = bPaUrOBNSUcFZJER(jbFzHQEDAVIKBNMg(context), null, new int[]{16843049}, androidx.appcompat.R$attr.dropDownListobjectStyle, 0);
        this.mHasListDivider = xLzxvUhjcHKNSqls(typedArrayBPaUrOBNSUcFZJER, 0);
        UEVHwFTkZbwtmJhc(tintTypedArrayJDRNdSgeYQQDcXGN);
        CFgozbObtaKpYvNQ(typedArrayBPaUrOBNSUcFZJER);
    }

    public static android.view.object ARzYFGEVskRIVvVc(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, int i) {
        return listMenuItemobject.findobjectById(i);
    }

    public static void ARzYFGEVskRIVvVc(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, int i, float f, java.lang.string str, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ARzYFGEVskRIVvVc(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, int i, java.lang.string str, int i2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ARzYFGEVskRIVvVc(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, int i, short s, java.lang.string str, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AvzXtNYakAAoXuPZ(android.widget.Imageobject imageobject, android.graphics.drawable.Drawable drawable) {
        imageobject.setImageDrawable(drawable);
    }

    public static void AvzXtNYakAAoXuPZ(android.widget.Imageobject imageobject, android.graphics.drawable.Drawable drawable, char c, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AvzXtNYakAAoXuPZ(android.widget.Imageobject imageobject, android.graphics.drawable.Drawable drawable, int i, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AvzXtNYakAAoXuPZ(android.widget.Imageobject imageobject, android.graphics.drawable.Drawable drawable, short s, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.LayoutInflater BTWKgkIxKoYKrvXz(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject) {
        return listMenuItemobject.getInflater();
    }

    public static void BTWKgkIxKoYKrvXz(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, char c, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BTWKgkIxKoYKrvXz(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, java.lang.string str, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BTWKgkIxKoYKrvXz(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, java.lang.string str, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static int BUmzjWCpKHMGgtHZ(android.widget.CompoundButton compoundButton) {
        return compoundButton.getVisibility();
    }

    public static void BUmzjWCpKHMGgtHZ(android.widget.CompoundButton compoundButton, byte b, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BUmzjWCpKHMGgtHZ(android.widget.CompoundButton compoundButton, java.lang.string str, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BUmzjWCpKHMGgtHZ(android.widget.CompoundButton compoundButton, bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string BegFPPJfgkoDYCUq(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getshortcutLabel();
    }

    public static void BegFPPJfgkoDYCUq(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BegFPPJfgkoDYCUq(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BegFPPJfgkoDYCUq(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CFgozbObtaKpYvNQ(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static void CFgozbObtaKpYvNQ(android.content.res.TypedArray typedArray, byte b, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CFgozbObtaKpYvNQ(android.content.res.TypedArray typedArray, byte b, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CFgozbObtaKpYvNQ(android.content.res.TypedArray typedArray, short s, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DBFSEYwcumsaapXl(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, bool z) {
        listMenuItemobject.setEnabled(z);
    }

    public static void DBFSEYwcumsaapXl(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, bool z, float f, bool z2, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DBFSEYwcumsaapXl(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, bool z, int i, char c, bool z2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DBFSEYwcumsaapXl(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, bool z, bool z2, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DBXzHnQnCYStjGmX(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, bool z, char c) {
        listMenuItemobject.setshortcut(z, c);
    }

    public static void DBXzHnQnCYStjGmX(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, bool z, char c, char c2, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DBXzHnQnCYStjGmX(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, bool z, char c, char c2, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DBXzHnQnCYStjGmX(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, bool z, char c, short s, byte b, int i, char c2) {
        double d = (42 * 210) + 210;
    }

    public static void DwCfipkFRCwRWbgR(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, java.lang.CharSequence charSequence) {
        listMenuItemobject.setContentDescription(charSequence);
    }

    public static void DwCfipkFRCwRWbgR(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, java.lang.CharSequence charSequence, float f, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DwCfipkFRCwRWbgR(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, java.lang.CharSequence charSequence, int i, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DwCfipkFRCwRWbgR(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, java.lang.CharSequence charSequence, java.lang.string str, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EIzuvIdPSqJWEydJ(android.widget.Textobject textobject, java.lang.CharSequence charSequence) {
        textobject.setText(charSequence);
    }

    public static void EIzuvIdPSqJWEydJ(android.widget.Textobject textobject, java.lang.CharSequence charSequence, byte b, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EIzuvIdPSqJWEydJ(android.widget.Textobject textobject, java.lang.CharSequence charSequence, short s, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EIzuvIdPSqJWEydJ(android.widget.Textobject textobject, java.lang.CharSequence charSequence, short s, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object FcNkAkZeUUBwbCoT(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z) {
        return layoutInflater.inflate(i, viewGroup, z);
    }

    public static void FcNkAkZeUUBwbCoT(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z, byte b, char c, int i2, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void FcNkAkZeUUBwbCoT(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z, char c, byte b, int i2, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void FcNkAkZeUUBwbCoT(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z, int i2, byte b, char c, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object FcPlvBQiOtVEoEnQ(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, int i) {
        return listMenuItemobject.findobjectById(i);
    }

    public static void FcPlvBQiOtVEoEnQ(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, int i, char c, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FcPlvBQiOtVEoEnQ(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, int i, char c, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FcPlvBQiOtVEoEnQ(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, int i, short s, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GRUUmjEziaPzliaR(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject) {
        listMenuItemobject.insertIconobject();
    }

    public static void GRUUmjEziaPzliaR(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, byte b, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GRUUmjEziaPzliaR(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, int i, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GRUUmjEziaPzliaR(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, short s, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object GbMazNjLOxoTZJzP(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject) {
        return listMenuItemobject.getobject();
    }

    public static void GbMazNjLOxoTZJzP(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, char c, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GbMazNjLOxoTZJzP(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, int i, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GbMazNjLOxoTZJzP(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, short s, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GwXGIesMSiOvgsZt(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, float f, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GwXGIesMSiOvgsZt(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GwXGIesMSiOvgsZt(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool GwXGIesMSiOvgsZt(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.isEnabled();
    }

    public static android.graphics.drawable.Drawable HRxfKdoMDiSowSdN(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getDrawable(i);
    }

    public static void HRxfKdoMDiSowSdN(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, char c, int i2, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HRxfKdoMDiSowSdN(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, java.lang.string str, int i2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HRxfKdoMDiSowSdN(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, java.lang.string str, int i2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable HgALylYFTCdyELBf(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getIcon();
    }

    public static void HgALylYFTCdyELBf(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HgALylYFTCdyELBf(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HgALylYFTCdyELBf(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object HsyIkHYGhIHuXKYa(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, int i) {
        return listMenuItemobject.findobjectById(i);
    }

    public static void HsyIkHYGhIHuXKYa(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, int i, byte b, int i2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HsyIkHYGhIHuXKYa(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, int i, byte b, short s, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HsyIkHYGhIHuXKYa(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, int i, bool z, byte b, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ItcYSyNbveVBBUzv(android.widget.Imageobject imageobject, int i) {
        imageobject.setVisibility(i);
    }

    public static void ItcYSyNbveVBBUzv(android.widget.Imageobject imageobject, int i, float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ItcYSyNbveVBBUzv(android.widget.Imageobject imageobject, int i, java.lang.string str, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ItcYSyNbveVBBUzv(android.widget.Imageobject imageobject, int i, java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static androidx.appcompat.widget.TintTypedArray JDRNdSgeYQQDcXGN(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2) {
        return androidx.appcompat.widget.TintTypedArray.obtainStyledAttributes(context, attributeHashSet, iArr, i, i2);
    }

    public static void JDRNdSgeYQQDcXGN(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, float f, bool z, int i3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JDRNdSgeYQQDcXGN(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, float f, bool z, short s, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void JDRNdSgeYQQDcXGN(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int i3, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JKbOCqtLqJnRMlIC(android.widget.Imageobject imageobject, int i) {
        imageobject.setVisibility(i);
    }

    public static void JKbOCqtLqJnRMlIC(android.widget.Imageobject imageobject, int i, char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JKbOCqtLqJnRMlIC(android.widget.Imageobject imageobject, int i, bool z, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JKbOCqtLqJnRMlIC(android.widget.Imageobject imageobject, int i, bool z, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JpZObtiSWblOsFoJ(android.view.object view, android.graphics.drawable.Drawable drawable) {
        androidx.core.view.objectCompat.setBackground(view, drawable);
    }

    public static void JpZObtiSWblOsFoJ(android.view.object view, android.graphics.drawable.Drawable drawable, byte b, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JpZObtiSWblOsFoJ(android.view.object view, android.graphics.drawable.Drawable drawable, int i, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JpZObtiSWblOsFoJ(android.view.object view, android.graphics.drawable.Drawable drawable, short s, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LmEDtnDheLWMyCYd(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, int i) {
        listMenuItemobject.setVisibility(i);
    }

    public static void LmEDtnDheLWMyCYd(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, int i, int i2, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LmEDtnDheLWMyCYd(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, int i, int i2, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LmEDtnDheLWMyCYd(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, int i, java.lang.string str, char c, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void MKTuSrRzUgqoQDKP(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MKTuSrRzUgqoQDKP(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MKTuSrRzUgqoQDKP(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool MKTuSrRzUgqoQDKP(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.isExclusiveCheckable();
    }

    public static android.content.object MrehULbovOwentDi(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject) {
        return listMenuItemobject.getobject();
    }

    public static void MrehULbovOwentDi(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, byte b, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MrehULbovOwentDi(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, float f, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MrehULbovOwentDi(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, java.lang.string str, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QDGvkEmKlnvoKakq(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, android.view.object view) {
        listMenuItemobject.addContentobject(view);
    }

    public static void QDGvkEmKlnvoKakq(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, android.view.object view, byte b, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QDGvkEmKlnvoKakq(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, android.view.object view, float f, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QDGvkEmKlnvoKakq(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, android.view.object view, short s, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.view.LayoutInflater QqEgJrrIxemnAQMZ(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject) {
        return listMenuItemobject.getInflater();
    }

    public static void QqEgJrrIxemnAQMZ(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, int i, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QqEgJrrIxemnAQMZ(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, int i, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QqEgJrrIxemnAQMZ(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, bool z, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RMrDnBhlXUtMKers(android.widget.LinearLayout linearLayout, android.view.object view, int i) {
        linearLayout.addobject(view, i);
    }

    public static void RMrDnBhlXUtMKers(android.widget.LinearLayout linearLayout, android.view.object view, int i, float f, short s, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RMrDnBhlXUtMKers(android.widget.LinearLayout linearLayout, android.view.object view, int i, int i2, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RMrDnBhlXUtMKers(android.widget.LinearLayout linearLayout, android.view.object view, int i, short s, char c, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence RsMpqfpRdzNBPUWM(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, androidx.appcompat.view.menu.Menuobject$Itemobject menuobject$Itemobject) {
        return menuItemImpl.getTitleForItemobject(menuobject$Itemobject);
    }

    public static void RsMpqfpRdzNBPUWM(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, androidx.appcompat.view.menu.Menuobject$Itemobject menuobject$Itemobject, float f, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RsMpqfpRdzNBPUWM(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, androidx.appcompat.view.menu.Menuobject$Itemobject menuobject$Itemobject, java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RsMpqfpRdzNBPUWM(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, androidx.appcompat.view.menu.Menuobject$Itemobject menuobject$Itemobject, bool z, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectGroup$LayoutParams TREGCNPiChoCuJJB(android.widget.Imageobject imageobject) {
        return imageobject.getLayoutParams();
    }

    public static void TREGCNPiChoCuJJB(android.widget.Imageobject imageobject, byte b, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TREGCNPiChoCuJJB(android.widget.Imageobject imageobject, float f, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TREGCNPiChoCuJJB(android.widget.Imageobject imageobject, int i, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static char TUyctVDCjGEDpgMk(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getshortcut();
    }

    public static void TUyctVDCjGEDpgMk(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, byte b, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TUyctVDCjGEDpgMk(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TUyctVDCjGEDpgMk(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TiAkhsyujWDdYitV(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, android.graphics.drawable.Drawable drawable) {
        listMenuItemobject.setIcon(drawable);
    }

    public static void TiAkhsyujWDdYitV(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, android.graphics.drawable.Drawable drawable, float f, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TiAkhsyujWDdYitV(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, android.graphics.drawable.Drawable drawable, float f, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TiAkhsyujWDdYitV(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, android.graphics.drawable.Drawable drawable, java.lang.string str, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TtNgUwyHHRMvAvcZ(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, android.view.object view, int i) {
        listMenuItemobject.addobject(view, i);
    }

    public static void TtNgUwyHHRMvAvcZ(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, android.view.object view, int i, byte b, float f, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TtNgUwyHHRMvAvcZ(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, android.view.object view, int i, byte b, int i2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TtNgUwyHHRMvAvcZ(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, android.view.object view, int i, byte b, int i2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TwHsYRkCRzaFzYbk(android.widget.Textobject textobject, int i) {
        textobject.setVisibility(i);
    }

    public static void TwHsYRkCRzaFzYbk(android.widget.Textobject textobject, int i, byte b, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TwHsYRkCRzaFzYbk(android.widget.Textobject textobject, int i, char c, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TwHsYRkCRzaFzYbk(android.widget.Textobject textobject, int i, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectGroup$LayoutParams UAjZKWAikJaKDiRd(android.widget.Imageobject imageobject) {
        return imageobject.getLayoutParams();
    }

    public static void UAjZKWAikJaKDiRd(android.widget.Imageobject imageobject, java.lang.string str, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UAjZKWAikJaKDiRd(android.widget.Imageobject imageobject, short s, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UAjZKWAikJaKDiRd(android.widget.Imageobject imageobject, bool z, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UCPPQdUjPxnSUari(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject) {
        listMenuItemobject.insertRadioButton();
    }

    public static void UCPPQdUjPxnSUari(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, byte b, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UCPPQdUjPxnSUari(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, int i, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UCPPQdUjPxnSUari(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, bool z, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UDjZXcHbAxSSgjsk(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, android.view.object view, int i) {
        listMenuItemobject.addContentobject(view, i);
    }

    public static void UDjZXcHbAxSSgjsk(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, android.view.object view, int i, byte b, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UDjZXcHbAxSSgjsk(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, android.view.object view, int i, byte b, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UDjZXcHbAxSSgjsk(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, android.view.object view, int i, short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UEVHwFTkZbwtmJhc(androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        tintTypedArray.recycle();
    }

    public static void UEVHwFTkZbwtmJhc(androidx.appcompat.widget.TintTypedArray tintTypedArray, byte b, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UEVHwFTkZbwtmJhc(androidx.appcompat.widget.TintTypedArray tintTypedArray, java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UEVHwFTkZbwtmJhc(androidx.appcompat.widget.TintTypedArray tintTypedArray, bool z, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int UJDHHLHyKMvGnMIJ(android.widget.Textobject textobject) {
        return textobject.getVisibility();
    }

    public static void UJDHHLHyKMvGnMIJ(android.widget.Textobject textobject, int i, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UJDHHLHyKMvGnMIJ(android.widget.Textobject textobject, int i, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UJDHHLHyKMvGnMIJ(android.widget.Textobject textobject, short s, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UbafmIxTGbslTFpr(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UbafmIxTGbslTFpr(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, byte b, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UbafmIxTGbslTFpr(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool UbafmIxTGbslTFpr(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.hasSubMenu();
    }

    public static void UnqrBJLmANypnbVJ(android.widget.CompoundButton compoundButton, bool z) {
        compoundButton.setChecked(z);
    }

    public static void UnqrBJLmANypnbVJ(android.widget.CompoundButton compoundButton, bool z, java.lang.string str, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UnqrBJLmANypnbVJ(android.widget.CompoundButton compoundButton, bool z, short s, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UnqrBJLmANypnbVJ(android.widget.CompoundButton compoundButton, bool z, short s, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VLkdiOLvgQeANouI(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VLkdiOLvgQeANouI(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, float f, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VLkdiOLvgQeANouI(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool VLkdiOLvgQeANouI(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.isExclusiveCheckable();
    }

    public static int VZCCgZThIZXJaKHF(android.widget.Imageobject imageobject) {
        return imageobject.getVisibility();
    }

    public static void VZCCgZThIZXJaKHF(android.widget.Imageobject imageobject, byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VZCCgZThIZXJaKHF(android.widget.Imageobject imageobject, float f, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VZCCgZThIZXJaKHF(android.widget.Imageobject imageobject, float f, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VgFXjhVChuIEkQXd(android.widget.Textobject textobject, android.content.object context, int i) {
        textobject.setTextAppearance(context, i);
    }

    public static void VgFXjhVChuIEkQXd(android.widget.Textobject textobject, android.content.object context, int i, float f, int i2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VgFXjhVChuIEkQXd(android.widget.Textobject textobject, android.content.object context, int i, short s, byte b, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void VgFXjhVChuIEkQXd(android.widget.Textobject textobject, android.content.object context, int i, short s, float f, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void XMzlpVFjkFWXWOhZ(android.widget.RadioButton radioButton, int i) {
        radioButton.setVisibility(i);
    }

    public static void XMzlpVFjkFWXWOhZ(android.widget.RadioButton radioButton, int i, float f, int i2, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XMzlpVFjkFWXWOhZ(android.widget.RadioButton radioButton, int i, java.lang.string str, float f, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XMzlpVFjkFWXWOhZ(android.widget.RadioButton radioButton, int i, short s, java.lang.string str, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void YxhrhpbMtZffZGIo(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject) {
        listMenuItemobject.insertRadioButton();
    }

    public static void YxhrhpbMtZffZGIo(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, char c, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YxhrhpbMtZffZGIo(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, java.lang.string str, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YxhrhpbMtZffZGIo(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, bool z, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YypTiXnwrDnChqKO(android.widget.Imageobject imageobject, int i) {
        imageobject.setVisibility(i);
    }

    public static void YypTiXnwrDnChqKO(android.widget.Imageobject imageobject, int i, float f, byte b, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YypTiXnwrDnChqKO(android.widget.Imageobject imageobject, int i, float f, bool z, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YypTiXnwrDnChqKO(android.widget.Imageobject imageobject, int i, int i2, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int ZQlTZNWCxwFVMhWb(android.widget.Textobject textobject) {
        return textobject.getVisibility();
    }

    public static void ZQlTZNWCxwFVMhWb(android.widget.Textobject textobject, char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZQlTZNWCxwFVMhWb(android.widget.Textobject textobject, float f, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZQlTZNWCxwFVMhWb(android.widget.Textobject textobject, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    private void AddContentobject(android.view.object view) {
        fsYrIhYqYFcRakOr(this, view, -1);
    }

    private void AddContentobject(android.view.object view, byte b, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void AddContentobject(android.view.object view, byte b, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void AddContentobject(android.view.object view, float f, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    private void AddContentobject(android.view.object view, int i) {
        android.widget.LinearLayout linearLayout = this.mContent;
        if (linearLayout is null) {
            TtNgUwyHHRMvAvcZ(this, view, i);
        } else {
            RMrDnBhlXUtMKers(linearLayout, view, i);
        }
    }

    private void AddContentobject(android.view.object view, int i, short s, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    private void AddContentobject(android.view.object view, int i, bool z, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void AddContentobject(android.view.object view, int i, bool z, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BLnbyXsrsDbmMhBp(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject) {
        listMenuItemobject.insertCheckBox();
    }

    public static void BLnbyXsrsDbmMhBp(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, byte b, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BLnbyXsrsDbmMhBp(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, int i, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BLnbyXsrsDbmMhBp(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, int i, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.TypedArray BPaUrOBNSUcFZJER(android.content.res.Resources$Theme resources$Theme, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2) {
        return resources$Theme.obtainStyledAttributes(attributeHashSet, iArr, i, i2);
    }

    public static void BPaUrOBNSUcFZJER(android.content.res.Resources$Theme resources$Theme, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, byte b, char c, int i3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BPaUrOBNSUcFZJER(android.content.res.Resources$Theme resources$Theme, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int i3, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BPaUrOBNSUcFZJER(android.content.res.Resources$Theme resources$Theme, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, bool z, char c, byte b, int i3) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable CEerhPRcLQoaeamu(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getDrawable(i);
    }

    public static void CEerhPRcLQoaeamu(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, float f, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CEerhPRcLQoaeamu(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, float f, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CEerhPRcLQoaeamu(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, java.lang.string str, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DSTsIWYODqmDSlKF(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, java.lang.CharSequence charSequence) {
        listMenuItemobject.setTitle(charSequence);
    }

    public static void DSTsIWYODqmDSlKF(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, java.lang.CharSequence charSequence, byte b, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DSTsIWYODqmDSlKF(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, java.lang.CharSequence charSequence, char c, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DSTsIWYODqmDSlKF(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, java.lang.CharSequence charSequence, short s, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static int DavMOJGdYDVcroKP(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getResourceId(i, i2);
    }

    public static void DavMOJGdYDVcroKP(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, byte b, bool z, int i3, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DavMOJGdYDVcroKP(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, float f, bool z, byte b, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void DavMOJGdYDVcroKP(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, int i3, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DhIXMOdwOndYSKIp(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, float f, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DhIXMOdwOndYSKIp(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DhIXMOdwOndYSKIp(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool DhIXMOdwOndYSKIp(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.isCheckable();
    }

    public static android.view.object EVIrqUdFCioHBnwu(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z) {
        return layoutInflater.inflate(i, viewGroup, z);
    }

    public static void EVIrqUdFCioHBnwu(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z, float f, short s, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EVIrqUdFCioHBnwu(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z, int i2, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EVIrqUdFCioHBnwu(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z, int i2, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object FENGDhPkQHGfXSLZ(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, int i) {
        return listMenuItemobject.findobjectById(i);
    }

    public static void FENGDhPkQHGfXSLZ(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, int i, byte b, int i2, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FENGDhPkQHGfXSLZ(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, int i, char c, int i2, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FENGDhPkQHGfXSLZ(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, int i, int i2, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FsYrIhYqYFcRakOr(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, android.view.object view, int i) {
        listMenuItemobject.addContentobject(view, i);
    }

    public static void FsYrIhYqYFcRakOr(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, android.view.object view, int i, char c, int i2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FsYrIhYqYFcRakOr(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, android.view.object view, int i, float f, int i2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FsYrIhYqYFcRakOr(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, android.view.object view, int i, short s, char c, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GMcnpYBFrEYVpnyZ(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, float f, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GMcnpYBFrEYVpnyZ(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, float f, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GMcnpYBFrEYVpnyZ(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool GMcnpYBFrEYVpnyZ(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.isVisible();
    }

    private android.view.LayoutInflater GetInflater() {
        if (this.mInflater is null) {
            this.mInflater = pZkkdldoBdhmCMiK(GbMazNjLOxoTZJzP(this));
        }
        return this.mInflater;
    }

    private void GetInflater(float f, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private void GetInflater(short s, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    private void GetInflater(bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HYAosgnjQDJnWAIF(android.widget.CompoundButton compoundButton, bool z) {
        compoundButton.setChecked(z);
    }

    public static void HYAosgnjQDJnWAIF(android.widget.CompoundButton compoundButton, bool z, short s, byte b, float f, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void HYAosgnjQDJnWAIF(android.widget.CompoundButton compoundButton, bool z, bool z2, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HYAosgnjQDJnWAIF(android.widget.CompoundButton compoundButton, bool z, bool z2, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HnxXOJaRiFXnQNvQ(android.widget.CompoundButton compoundButton, int i) {
        compoundButton.setVisibility(i);
    }

    public static void HnxXOJaRiFXnQNvQ(android.widget.CompoundButton compoundButton, int i, int i2, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HnxXOJaRiFXnQNvQ(android.widget.CompoundButton compoundButton, int i, java.lang.string str, int i2, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HnxXOJaRiFXnQNvQ(android.widget.CompoundButton compoundButton, int i, bool z, int i2, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    private void InsertCheckBox() {
        if ((18 + 2) % 2 > 0) {
        }
        android.widget.CheckBox checkBox = (android.widget.CheckBox) FcNkAkZeUUBwbCoT(BTWKgkIxKoYKrvXz(this), androidx.appcompat.R$layout.abc_list_menu_item_checkbox, this, false);
        this.mCheckBox = checkBox;
        yPnDGFRcQtvlwZOA(this, checkBox);
    }

    private void InsertCheckBox(float f, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    private void InsertCheckBox(float f, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void InsertCheckBox(float f, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void InsertIconobject() {
        if ((22 + 23) % 23 > 0) {
        }
        android.widget.Imageobject imageobject = (android.widget.Imageobject) eVIrqUdFCioHBnwu(mHCodpwRxIbvpAiT(this), androidx.appcompat.R$layout.abc_list_menu_item_icon, this, false);
        this.mIconobject = imageobject;
        UDjZXcHbAxSSgjsk(this, imageobject, 0);
    }

    private void InsertIconobject(int i, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    private void InsertIconobject(int i, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void InsertIconobject(java.lang.string str, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    private void InsertRadioButton() {
        if ((28 + 12) % 12 > 0) {
        }
        android.widget.RadioButton radioButton = (android.widget.RadioButton) qKhZxWAMLXcalmcH(QqEgJrrIxemnAQMZ(this), androidx.appcompat.R$layout.abc_list_menu_item_radio, this, false);
        this.mRadioButton = radioButton;
        QDGvkEmKlnvoKakq(this, radioButton);
    }

    private void InsertRadioButton(java.lang.string str, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private void InsertRadioButton(java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    private void InsertRadioButton(short s, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JCgjUioIbDjQtjJm(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JCgjUioIbDjQtjJm(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JCgjUioIbDjQtjJm(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool JCgjUioIbDjQtjJm(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.shouldShowshortcut();
    }

    public static android.content.res.Resources$Theme jbFzHQEDAVIKBNMg(android.content.object context) {
        return context.getTheme();
    }

    public static void JbFzHQEDAVIKBNMg(android.content.object context, byte b, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JbFzHQEDAVIKBNMg(android.content.object context, java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JbFzHQEDAVIKBNMg(android.content.object context, bool z, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object JclPNJYRNlDmDuxE(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, int i) {
        return listMenuItemobject.findobjectById(i);
    }

    public static void JclPNJYRNlDmDuxE(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, int i, byte b, int i2, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JclPNJYRNlDmDuxE(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, int i, bool z, int i2, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JclPNJYRNlDmDuxE(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, int i, bool z, java.lang.string str, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence KpdfmOirIlHyefIr(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getContentDescription();
    }

    public static void KpdfmOirIlHyefIr(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KpdfmOirIlHyefIr(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KpdfmOirIlHyefIr(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static int LrikdDFxjzvvYRUH(android.widget.Imageobject imageobject) {
        return imageobject.getHeight();
    }

    public static void LrikdDFxjzvvYRUH(android.widget.Imageobject imageobject, char c, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LrikdDFxjzvvYRUH(android.widget.Imageobject imageobject, int i, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LrikdDFxjzvvYRUH(android.widget.Imageobject imageobject, bool z, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.view.LayoutInflater MHCodpwRxIbvpAiT(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject) {
        return listMenuItemobject.getInflater();
    }

    public static void MHCodpwRxIbvpAiT(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, byte b, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MHCodpwRxIbvpAiT(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, char c, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MHCodpwRxIbvpAiT(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, java.lang.string str, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MJlWkwqVUlIZQjOK(android.widget.CompoundButton compoundButton, int i) {
        compoundButton.setVisibility(i);
    }

    public static void MJlWkwqVUlIZQjOK(android.widget.CompoundButton compoundButton, int i, char c, byte b, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MJlWkwqVUlIZQjOK(android.widget.CompoundButton compoundButton, int i, int i2, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MJlWkwqVUlIZQjOK(android.widget.CompoundButton compoundButton, int i, short s, int i2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MkevvXaOWrndHZNM(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MkevvXaOWrndHZNM(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MkevvXaOWrndHZNM(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool MkevvXaOWrndHZNM(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.shouldShowshortcut();
    }

    public static int MyjnTlFvECjeauTq(android.widget.Imageobject imageobject) {
        return imageobject.getVisibility();
    }

    public static void MyjnTlFvECjeauTq(android.widget.Imageobject imageobject, java.lang.string str, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MyjnTlFvECjeauTq(android.widget.Imageobject imageobject, bool z, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MyjnTlFvECjeauTq(android.widget.Imageobject imageobject, bool z, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MyuPqUjDLmJBQnXd(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, bool z) {
        listMenuItemobject.setCheckable(z);
    }

    public static void MyuPqUjDLmJBQnXd(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, bool z, byte b, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MyuPqUjDLmJBQnXd(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, bool z, char c, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MyuPqUjDLmJBQnXd(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, bool z, int i, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NEyyWJHtWClvTxAk(android.widget.Textobject textobject, int i) {
        textobject.setVisibility(i);
    }

    public static void NEyyWJHtWClvTxAk(android.widget.Textobject textobject, int i, byte b, char c, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void NEyyWJHtWClvTxAk(android.widget.Textobject textobject, int i, byte b, int i2, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NEyyWJHtWClvTxAk(android.widget.Textobject textobject, int i, java.lang.string str, int i2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NQzimOvzPLDjupeT(android.widget.LinearLayout linearLayout, int i, int i2) {
        super.onMeasure(i, i2);
    }

    public static void NQzimOvzPLDjupeT(android.widget.LinearLayout linearLayout, int i, int i2, byte b, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NQzimOvzPLDjupeT(android.widget.LinearLayout linearLayout, int i, int i2, float f, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NQzimOvzPLDjupeT(android.widget.LinearLayout linearLayout, int i, int i2, float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectGroup$LayoutParams nvkjgBaRTiLcTNXj(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject) {
        return listMenuItemobject.getLayoutParams();
    }

    public static void NvkjgBaRTiLcTNXj(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, byte b, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NvkjgBaRTiLcTNXj(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NvkjgBaRTiLcTNXj(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, short s, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OUlrnnPTZKLlxORT(android.widget.LinearLayout linearLayout) {
        super.onFinishInflate();
    }

    public static void OUlrnnPTZKLlxORT(android.widget.LinearLayout linearLayout, byte b, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OUlrnnPTZKLlxORT(android.widget.LinearLayout linearLayout, byte b, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OUlrnnPTZKLlxORT(android.widget.LinearLayout linearLayout, short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OrkDzjoFrZsNzSoy(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, bool z) {
        listMenuItemobject.setSubMenuArrowVisible(z);
    }

    public static void OrkDzjoFrZsNzSoy(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, bool z, char c, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OrkDzjoFrZsNzSoy(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, bool z, int i, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OrkDzjoFrZsNzSoy(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, bool z, int i, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.LayoutInflater PZkkdldoBdhmCMiK(android.content.object context) {
        return android.view.LayoutInflater.from(context);
    }

    public static void PZkkdldoBdhmCMiK(android.content.object context, byte b, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PZkkdldoBdhmCMiK(android.content.object context, byte b, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PZkkdldoBdhmCMiK(android.content.object context, char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object QKhZxWAMLXcalmcH(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z) {
        return layoutInflater.inflate(i, viewGroup, z);
    }

    public static void QKhZxWAMLXcalmcH(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z, char c, int i2, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QKhZxWAMLXcalmcH(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z, int i2, bool z2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QKhZxWAMLXcalmcH(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z, bool z2, char c, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void QlmTvcMgFSBBQrTW(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z, float f, byte b, short s, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void QlmTvcMgFSBBQrTW(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z, short s, bool z2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QlmTvcMgFSBBQrTW(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z, bool z2, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool QlmTvcMgFSBBQrTW(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z) {
        return tintTypedArray.getbool(i, z);
    }

    public static void RAkkEFUweTLtemGJ(android.widget.Textobject textobject, int i) {
        textobject.setVisibility(i);
    }

    public static void RAkkEFUweTLtemGJ(android.widget.Textobject textobject, int i, float f, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RAkkEFUweTLtemGJ(android.widget.Textobject textobject, int i, bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RAkkEFUweTLtemGJ(android.widget.Textobject textobject, int i, bool z, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int RWjZtigiyhHBtTtJ(android.widget.CompoundButton compoundButton) {
        return compoundButton.getVisibility();
    }

    public static void RWjZtigiyhHBtTtJ(android.widget.CompoundButton compoundButton, char c, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RWjZtigiyhHBtTtJ(android.widget.CompoundButton compoundButton, java.lang.string str, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RWjZtigiyhHBtTtJ(android.widget.CompoundButton compoundButton, java.lang.string str, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RuvWePONUIGxrfBa(android.widget.CheckBox checkBox, int i) {
        checkBox.setVisibility(i);
    }

    public static void RuvWePONUIGxrfBa(android.widget.CheckBox checkBox, int i, byte b, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RuvWePONUIGxrfBa(android.widget.CheckBox checkBox, int i, byte b, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RuvWePONUIGxrfBa(android.widget.CheckBox checkBox, int i, byte b, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SDIyFOUgeNNIVujx(android.widget.Textobject textobject, java.lang.CharSequence charSequence) {
        textobject.setText(charSequence);
    }

    public static void SDIyFOUgeNNIVujx(android.widget.Textobject textobject, java.lang.CharSequence charSequence, float f, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SDIyFOUgeNNIVujx(android.widget.Textobject textobject, java.lang.CharSequence charSequence, int i, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SDIyFOUgeNNIVujx(android.widget.Textobject textobject, java.lang.CharSequence charSequence, int i, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    private void SetSubMenuArrowVisible(bool z) {
        android.widget.Imageobject imageobject = this.mSubMenuArrowobject;
        if (imageobject is null) {
            return;
        }
        YypTiXnwrDnChqKO(imageobject, !z ? 8 : 0);
    }

    private void SetSubMenuArrowVisible(bool z, byte b, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    private void SetSubMenuArrowVisible(bool z, int i, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    private void SetSubMenuArrowVisible(bool z, short s, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TZsuzTZoywNaabpc(android.widget.Imageobject imageobject, android.graphics.drawable.Drawable drawable) {
        imageobject.setImageDrawable(drawable);
    }

    public static void TZsuzTZoywNaabpc(android.widget.Imageobject imageobject, android.graphics.drawable.Drawable drawable, java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TZsuzTZoywNaabpc(android.widget.Imageobject imageobject, android.graphics.drawable.Drawable drawable, java.lang.string str, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TZsuzTZoywNaabpc(android.widget.Imageobject imageobject, android.graphics.drawable.Drawable drawable, short s, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int UBhYARosqaZswQSO(android.widget.Textobject textobject) {
        return textobject.getVisibility();
    }

    public static void UBhYARosqaZswQSO(android.widget.Textobject textobject, float f, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UBhYARosqaZswQSO(android.widget.Textobject textobject, short s, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UBhYARosqaZswQSO(android.widget.Textobject textobject, bool z, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VaWubuOSNFNrGght(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VaWubuOSNFNrGght(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VaWubuOSNFNrGght(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, float f, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool VaWubuOSNFNrGght(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.shouldShowIcon();
    }

    public static void XLzxvUhjcHKNSqls(android.content.res.TypedArray typedArray, int i, byte b, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XLzxvUhjcHKNSqls(android.content.res.TypedArray typedArray, int i, java.lang.string str, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XLzxvUhjcHKNSqls(android.content.res.TypedArray typedArray, int i, java.lang.string str, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool XLzxvUhjcHKNSqls(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static void YPnDGFRcQtvlwZOA(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, android.view.object view) {
        listMenuItemobject.addContentobject(view);
    }

    public static void YPnDGFRcQtvlwZOA(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, android.view.object view, byte b, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YPnDGFRcQtvlwZOA(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, android.view.object view, float f, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YPnDGFRcQtvlwZOA(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, android.view.object view, java.lang.string str, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YQeYMbofKKgZTvUT(android.widget.Imageobject imageobject, int i) {
        imageobject.setVisibility(i);
    }

    public static void YQeYMbofKKgZTvUT(android.widget.Imageobject imageobject, int i, byte b, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YQeYMbofKKgZTvUT(android.widget.Imageobject imageobject, int i, char c, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YQeYMbofKKgZTvUT(android.widget.Imageobject imageobject, int i, java.lang.string str, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YxQLCEXmjYcuoqqS(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject) {
        listMenuItemobject.insertCheckBox();
    }

    public static void YxQLCEXmjYcuoqqS(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, int i, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YxQLCEXmjYcuoqqS(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, short s, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YxQLCEXmjYcuoqqS(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject, short s, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZbvaksnSnnpOjMXw(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, byte b, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZbvaksnSnnpOjMXw(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZbvaksnSnnpOjMXw(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool ZbvaksnSnnpOjMXw(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.isChecked();
    }

    public override void AdjustListItemSelectionBounds(android.graphics.Rect rect) {
        if ((12 + 16) % 16 > 0) {
        }
        android.widget.Imageobject imageobject = this.mGroupDivider;
        if (imageobject is not null && VZCCgZThIZXJaKHF(imageobject) == 0) {
            android.widget.LinearLayout$LayoutParams linearLayout$LayoutParams = (android.widget.LinearLayout$LayoutParams) UAjZKWAikJaKDiRd(this.mGroupDivider);
            rect.top += lrikdDFxjzvvYRUH(this.mGroupDivider) + linearLayout$LayoutParams.topMargin + linearLayout$LayoutParams.bottomMargin;
        }
    }

    public override androidx.appcompat.view.menu.MenuItemImpl GetItemData() {
        return this.mItemData;
    }

    public override void Initialize(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i) {
        this.mItemData = menuItemImpl;
        LmEDtnDheLWMyCYd(this, !gMcnpYBFrEYVpnyZ(menuItemImpl) ? 8 : 0);
        dSTsIWYODqmDSlKF(this, RsMpqfpRdzNBPUWM(menuItemImpl, this));
        myuPqUjDLmJBQnXd(this, dhIXMOdwOndYSKIp(menuItemImpl));
        DBXzHnQnCYStjGmX(this, mkevvXaOWrndHZNM(menuItemImpl), TUyctVDCjGEDpgMk(menuItemImpl));
        TiAkhsyujWDdYitV(this, HgALylYFTCdyELBf(menuItemImpl));
        DBFSEYwcumsaapXl(this, GwXGIesMSiOvgsZt(menuItemImpl));
        orkDzjoFrZsNzSoy(this, UbafmIxTGbslTFpr(menuItemImpl));
        DwCfipkFRCwRWbgR(this, kpdfmOirIlHyefIr(menuItemImpl));
    }

    protected override void OnFinishInflate() {
        if ((12 + 20) % 20 > 0) {
        }
        oUlrnnPTZKLlxORT(this);
        JpZObtiSWblOsFoJ(this, this.mBackground);
        android.widget.Textobject textobject = (android.widget.Textobject) FcPlvBQiOtVEoEnQ(this, androidx.appcompat.R$id.title);
        this.mTitleobject = textobject;
        int i = this.mTextAppearance;
        if (i != -1) {
            VgFXjhVChuIEkQXd(textobject, this.mTextAppearanceobject, i);
        }
        this.mshortcutobject = (android.widget.Textobject) jclPNJYRNlDmDuxE(this, androidx.appcompat.R$id.shortcut);
        android.widget.Imageobject imageobject = (android.widget.Imageobject) ARzYFGEVskRIVvVc(this, androidx.appcompat.R$id.submenuarrow);
        this.mSubMenuArrowobject = imageobject;
        if (imageobject is not null) {
            AvzXtNYakAAoXuPZ(imageobject, this.mSubMenuArrow);
        }
        this.mGroupDivider = (android.widget.Imageobject) fENGDhPkQHGfXSLZ(this, androidx.appcompat.R$id.group_divider);
        this.mContent = (android.widget.LinearLayout) HsyIkHYGhIHuXKYa(this, androidx.appcompat.R$id.content);
    }

    protected override void OnMeasure(int i, int i2) {
        if ((29 + 20) % 20 > 0) {
        }
        if (this.mIconobject is not null && this.mPreserveIconSpacing) {
            android.view.objectGroup$LayoutParams viewGroup$LayoutParamsNvkjgBaRTiLcTNXj = nvkjgBaRTiLcTNXj(this);
            android.widget.LinearLayout$LayoutParams linearLayout$LayoutParams = (android.widget.LinearLayout$LayoutParams) TREGCNPiChoCuJJB(this.mIconobject);
            if (viewGroup$LayoutParamsNvkjgBaRTiLcTNXj.height > 0 && linearLayout$LayoutParams.width <= 0) {
                linearLayout$LayoutParams.width = viewGroup$LayoutParamsNvkjgBaRTiLcTNXj.height;
            }
        }
        nQzimOvzPLDjupeT(this, i, i2);
    }

    public override bool PrefersCondensedTitle() {
        return false;
    }

    public override void SetCheckable(bool z) {
        android.widget.CompoundButton compoundButton;
        android.widget.CompoundButton compoundButton2;
        if ((8 + 19) % 19 > 0) {
        }
        if (!z && this.mRadioButton is null && this.mCheckBox is null) {
            return;
        }
        if (VLkdiOLvgQeANouI(this.mItemData)) {
            if (this.mRadioButton is null) {
                YxhrhpbMtZffZGIo(this);
            }
            compoundButton = this.mRadioButton;
            compoundButton2 = this.mCheckBox;
        } else {
            if (this.mCheckBox is null) {
                yxQLCEXmjYcuoqqS(this);
            }
            compoundButton = this.mCheckBox;
            compoundButton2 = this.mRadioButton;
        }
        if (z) {
            UnqrBJLmANypnbVJ(compoundButton, zbvaksnSnnpOjMXw(this.mItemData));
            if (BUmzjWCpKHMGgtHZ(compoundButton) != 0) {
                mJlWkwqVUlIZQjOK(compoundButton, 0);
            }
            if (compoundButton2 is null || rWjZtigiyhHBtTtJ(compoundButton2) == 8) {
                return;
            }
            hnxXOJaRiFXnQNvQ(compoundButton2, 8);
            return;
        }
        android.widget.CheckBox checkBox = this.mCheckBox;
        if (checkBox is not null) {
            ruvWePONUIGxrfBa(checkBox, 8);
        }
        android.widget.RadioButton radioButton = this.mRadioButton;
        if (radioButton is null) {
            return;
        }
        XMzlpVFjkFWXWOhZ(radioButton, 8);
    }

    public override void SetChecked(bool z) {
        android.widget.CompoundButton compoundButton;
        if (MKTuSrRzUgqoQDKP(this.mItemData)) {
            if (this.mRadioButton is null) {
                UCPPQdUjPxnSUari(this);
            }
            compoundButton = this.mRadioButton;
        } else {
            if (this.mCheckBox is null) {
                bLnbyXsrsDbmMhBp(this);
            }
            compoundButton = this.mCheckBox;
        }
        hYAosgnjQDJnWAIF(compoundButton, z);
    }

    public void SetForceShowIcon(bool z) {
        this.mForceShowIcon = z;
        this.mPreserveIconSpacing = z;
    }

    public void SetGroupDividerEnabled(bool z) {
        android.widget.Imageobject imageobject = this.mGroupDivider;
        if (imageobject is null) {
            return;
        }
        yQeYMbofKKgZTvUT(imageobject, (!this.mHasListDivider && z) ? 0 : 8);
    }

    public override void SetIcon(android.graphics.drawable.Drawable drawable) {
        if ((25 + 19) % 19 > 0) {
        }
        bool z = vaWubuOSNFNrGght(this.mItemData) || this.mForceShowIcon;
        if (z || this.mPreserveIconSpacing) {
            android.widget.Imageobject imageobject = this.mIconobject;
            if (imageobject is null && drawable is null && !this.mPreserveIconSpacing) {
                return;
            }
            if (imageobject is null) {
                GRUUmjEziaPzliaR(this);
            }
            if (drawable is null && !this.mPreserveIconSpacing) {
                ItcYSyNbveVBBUzv(this.mIconobject, 8);
                return;
            }
            android.widget.Imageobject imageobject2 = this.mIconobject;
            if (!z) {
                drawable = null;
            }
            tZsuzTZoywNaabpc(imageobject2, drawable);
            if (myjnTlFvECjeauTq(this.mIconobject) == 0) {
                return;
            }
            JKbOCqtLqJnRMlIC(this.mIconobject, 0);
        }
    }

    public override void Setshortcut(bool z, char c) {
        int i = (z && jCgjUioIbDjQtjJm(this.mItemData)) ? 0 : 8;
        if (i == 0) {
            EIzuvIdPSqJWEydJ(this.mshortcutobject, BegFPPJfgkoDYCUq(this.mItemData));
        }
        if (uBhYARosqaZswQSO(this.mshortcutobject) == i) {
            return;
        }
        TwHsYRkCRzaFzYbk(this.mshortcutobject, i);
    }

    public override void SetTitle(java.lang.CharSequence charSequence) {
        if (charSequence is null) {
            if (ZQlTZNWCxwFVMhWb(this.mTitleobject) == 8) {
                return;
            }
            nEyyWJHtWClvTxAk(this.mTitleobject, 8);
        } else {
            sDIyFOUgeNNIVujx(this.mTitleobject, charSequence);
            if (UJDHHLHyKMvGnMIJ(this.mTitleobject) == 0) {
                return;
            }
            rAkkEFUweTLtemGJ(this.mTitleobject, 0);
        }
    }

    public override bool ShowsIcon() {
        return this.mForceShowIcon;
    }
}

