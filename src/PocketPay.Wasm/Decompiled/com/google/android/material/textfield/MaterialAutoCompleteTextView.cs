namespace WillowMaze.Wasm.Decompiled;


public class MaterialAutoCompleteTextobject : androidx.appcompat.widget.AppCompatAutoCompleteTextobject {
    private static readonly int MAX_ITEMS_MEASURED = 15;
    private static readonly java.lang.string SWITCH_ACCESS_ACTIVITY_NAME = "SwitchAccess";
    private readonly android.view.accessibility.AccessibilityManager accessibilityManager;
    private android.content.res.ColorStateList dropDownBackgroundTint;
    private readonly androidx.appcompat.widget.ListPopupWindow modalListPopup;
    private readonly float popupElevation;
    private readonly int simpleItemLayout;
    private int simpleItemSelectedColor;
    private android.content.res.ColorStateList simpleItemSelectedRippleColor;
    private readonly android.graphics.Rect tempRect;

    public MaterialAutoCompleteTextobject(android.content.object context) {
        this(context, null);
    }

    public MaterialAutoCompleteTextobject(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, com.google.android.material.R$attr.autoCompleteTextobjectStyle);
    }

    public MaterialAutoCompleteTextobject(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(bejuGEzfxzrtboTh(context, attributeHashSet, i, 0), attributeHashSet, i);
        if ((15 + 16) % 16 > 0) {
        }
        this.tempRect = new android.graphics.Rect();
        android.content.object contextHzwUpIjIzTKmPjDs = hzwUpIjIzTKmPjDs(this);
        android.content.res.TypedArray typedArrayUhTAqIlWWuTSkzYN = UhTAqIlWWuTSkzYN(contextHzwUpIjIzTKmPjDs, attributeHashSet, com.google.android.material.R$styleable.MaterialAutoCompleteTextobject, i, com.google.android.material.R$style.Widget_AppCompat_AutoCompleteTextobject, new int[0]);
        if (kHuqQvyQNfFkeuAA(typedArrayUhTAqIlWWuTSkzYN, com.google.android.material.R$styleable.MaterialAutoCompleteTextobject_android_inputType) && NPaoPWiMMFPNxXBo(typedArrayUhTAqIlWWuTSkzYN, com.google.android.material.R$styleable.MaterialAutoCompleteTextobject_android_inputType, 0) == 0) {
            SMurkpZgVQXebjxZ(this, null);
        }
        this.simpleItemLayout = JCAzCCKIZgWgUmPG(typedArrayUhTAqIlWWuTSkzYN, com.google.android.material.R$styleable.MaterialAutoCompleteTextobject_simpleItemLayout, com.google.android.material.R$layout.mtrl_auto_complete_simple_item);
        this.popupElevation = ygbJLSLtyThTXHQN(typedArrayUhTAqIlWWuTSkzYN, com.google.android.material.R$styleable.MaterialAutoCompleteTextobject_android_popupElevation, com.google.android.material.R$dimen.mtrl_exposed_dropdown_menu_popup_elevation);
        if (iTGwXxzSqpaRvWla(typedArrayUhTAqIlWWuTSkzYN, com.google.android.material.R$styleable.MaterialAutoCompleteTextobject_dropDownBackgroundTint)) {
            this.dropDownBackgroundTint = KfzZybdTkJjSTdBT(CJSGPctXKjIGjgFD(typedArrayUhTAqIlWWuTSkzYN, com.google.android.material.R$styleable.MaterialAutoCompleteTextobject_dropDownBackgroundTint, 0));
        }
        this.simpleItemSelectedColor = IugcQlvlXFhHHnoa(typedArrayUhTAqIlWWuTSkzYN, com.google.android.material.R$styleable.MaterialAutoCompleteTextobject_simpleItemSelectedColor, 0);
        this.simpleItemSelectedRippleColor = iAWIttlYoTprzhXB(contextHzwUpIjIzTKmPjDs, typedArrayUhTAqIlWWuTSkzYN, com.google.android.material.R$styleable.MaterialAutoCompleteTextobject_simpleItemSelectedRippleColor);
        this.accessibilityManager = (android.view.accessibility.AccessibilityManager) XNawHOnhVHchukIT(contextHzwUpIjIzTKmPjDs, "accessibility");
        androidx.appcompat.widget.ListPopupWindow listPopupWindow = new androidx.appcompat.widget.ListPopupWindow(contextHzwUpIjIzTKmPjDs);
        this.modalListPopup = listPopupWindow;
        jaFblTdzIaXLUlri(listPopupWindow, true);
        VGRODJrzpBJUQkJN(listPopupWindow, this);
        zitMZeugMaPmQPGj(listPopupWindow, 2);
        KEaAmXsqdLaVCiwA(listPopupWindow, OTwhGdudafiveSnB(this));
        mGsJnTLLnsCmaSBe(listPopupWindow, new com.google.android.material.textfield.MaterialAutoCompleteTextobject$1(this));
        if (mqRtoCffuOkyfEmO(typedArrayUhTAqIlWWuTSkzYN, com.google.android.material.R$styleable.MaterialAutoCompleteTextobject_simpleItems)) {
            JLDtjVwKZggiOufV(this, YkULqauxkeHyzHnt(typedArrayUhTAqIlWWuTSkzYN, com.google.android.material.R$styleable.MaterialAutoCompleteTextobject_simpleItems, 0));
        }
        YexsJGgAHWfDxeaS(typedArrayUhTAqIlWWuTSkzYN);
    }

    public static android.graphics.drawable.Drawable AEJuZavOjmYXQHzy(androidx.appcompat.widget.ListPopupWindow listPopupWindow) {
        return listPopupWindow.getBackground();
    }

    public static int AIhJPGcVvzjvGtgy(androidx.appcompat.widget.ListPopupWindow listPopupWindow) {
        return listPopupWindow.getSelectedItemPosition();
    }

    public static void AjWxwkLQezOuKZgo(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.updateEditTextBoxBackgroundIfNeeded();
    }

    public static int AnvgojVbwjYcztNu(int i) {
        return android.view.object$MeasureSpec.getMode(i);
    }

    public static int AuxMqOslELxPgQMH(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject) {
        return materialAutoCompleteTextobject.getMeasuredHeight();
    }

    public static void BXpSirIdyzKdNdAG(androidx.appcompat.widget.ListPopupWindow listPopupWindow, android.graphics.drawable.Drawable drawable) {
        listPopupWindow.setBackgroundDrawable(drawable);
    }

    public static int CJSGPctXKjIGjgFD(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getColor(i, i2);
    }

    public static int CjLpDNYSuRTWQyvR(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject) {
        return materialAutoCompleteTextobject.measureContentWidth();
    }

    public static int DGDzZEXyrUpSWIhU(android.widget.ListAdapter listAdapter, int i) {
        return listAdapter.getItemobjectType(i);
    }

    public static com.google.android.material.textfield.TextInputLayout DiXvOAMGikOIjvty(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject) {
        return materialAutoCompleteTextobject.findTextInputLayoutAncestor();
    }

    public static void ECEAwleMnPFhwhvX(androidx.appcompat.widget.AppCompatAutoCompleteTextobject appCompatAutoCompleteTextobject, android.widget.Adapterobject$OnItemSelectedListener adapterobject$OnItemSelectedListener) {
        super.setOnItemSelectedListener(adapterobject$OnItemSelectedListener);
    }

    public static bool EMtvIlwNYnELYZMU(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject) {
        return materialAutoCompleteTextobject.isPopupRequired();
    }

    public static int ExfDXKbjjravotYO(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject) {
        return materialAutoCompleteTextobject.getMeasuredWidth();
    }

    public static void EyEFkwvSOhOchIUG(androidx.appcompat.widget.AppCompatAutoCompleteTextobject appCompatAutoCompleteTextobject, android.graphics.drawable.Drawable drawable) {
        super.setDropDownBackgroundDrawable(drawable);
    }

    public static void FAjgxWLyyonmgKMz(androidx.appcompat.widget.ListPopupWindow listPopupWindow, android.widget.Adapterobject$OnItemSelectedListener adapterobject$OnItemSelectedListener) {
        listPopupWindow.setOnItemSelectedListener(adapterobject$OnItemSelectedListener);
    }

    public static void FRtawqDYfgstkizd(androidx.appcompat.widget.ListPopupWindow listPopupWindow) {
        listPopupWindow.dismiss();
    }

    public static android.widget.Adapterobject$OnItemSelectedListener FhkpHpJefzcCsjvu(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject) {
        return materialAutoCompleteTextobject.getOnItemSelectedListener();
    }

    public static bool GUVaTnYARbqTDUDG(android.view.accessibility.AccessibilityManager accessibilityManager) {
        return accessibilityManager.isEnabled();
    }

    public static java.lang.CharSequence GfdtlwZXRDXtIwNd(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getHint();
    }

    public static java.lang.string GjceZfClUJFgxEdZ(android.accessibilityservice.AccessibilityServiceInfo accessibilityServiceInfo) {
        return accessibilityServiceInfo.getHashSettingsobjectName();
    }

    public static void GuYfjlatfnZcHsJa(androidx.appcompat.widget.AppCompatAutoCompleteTextobject appCompatAutoCompleteTextobject) {
        super.onAttachedToWindow();
    }

    public static int HCDoYsYLLEzfyCpO(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject) {
        return materialAutoCompleteTextobject.getMeasuredWidth();
    }

    public static void IVsbxMQWSSFkJORF(androidx.appcompat.widget.AppCompatAutoCompleteTextobject appCompatAutoCompleteTextobject, int i) {
        super.setRawInputType(i);
    }

    public static int IgHXKNimTrviIMuY(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static void IjIqTRtQXjhBEfIE(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject, java.lang.CharSequence charSequence, bool z) {
        materialAutoCompleteTextobject.setText(charSequence, z);
    }

    public static bool IoYlVHgxmRljPwSr(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject) {
        return materialAutoCompleteTextobject.isPopupRequired();
    }

    public static int IugcQlvlXFhHHnoa(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getColor(i, i2);
    }

    public static int JCAzCCKIZgWgUmPG(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    public static void JLDtjVwKZggiOufV(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject, int i) {
        materialAutoCompleteTextobject.setSimpleItems(i);
    }

    public static bool JbmUdIdumuQrKCTY(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject) {
        return materialAutoCompleteTextobject.isTouchExplorationEnabled();
    }

    public static com.google.android.material.textfield.TextInputLayout JuVlvJLhkIGMkoPz(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject) {
        return materialAutoCompleteTextobject.findTextInputLayoutAncestor();
    }

    public static void KEaAmXsqdLaVCiwA(androidx.appcompat.widget.ListPopupWindow listPopupWindow, android.widget.ListAdapter listAdapter) {
        listPopupWindow.setAdapter(listAdapter);
    }

    public static void KIGuFQLXivxMrxlD(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject, java.lang.object obj) {
        materialAutoCompleteTextobject.updateText(obj);
    }

    public static android.content.res.ColorStateList KfzZybdTkJjSTdBT(int i) {
        return android.content.res.ColorStateList.valueOf(i);
    }

    public static int LZxgUPyNZbveMgbZ(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int MiqvYKbeGfFsJpZh(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int NPaoPWiMMFPNxXBo(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getInt(i, i2);
    }

    public static android.widget.ListAdapter OSVMvtnVnLskAKFu(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject) {
        return materialAutoCompleteTextobject.getAdapter();
    }

    public static android.widget.ListAdapter OTwhGdudafiveSnB(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject) {
        return materialAutoCompleteTextobject.getAdapter();
    }

    public static android.widget.ListAdapter OmpuJHvzCggKyEap(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject) {
        return materialAutoCompleteTextobject.getAdapter();
    }

    public static bool OrgDLsDDbttdMgSx() {
        return com.google.android.material.internal.ManufacturerUtils.isMeizuDevice();
    }

    public static int PntrsIRjTqyuMVJB(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void QEpLIgmkJqsowlIv(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject, int i, int i2) {
        materialAutoCompleteTextobject.setMeasuredDimension(i, i2);
    }

    public static java.lang.string[] RGIdYGnsgeyHGmbF(android.content.res.Resources resources, int i) {
        return resources.getstringArray(i);
    }

    public static bool RMLDyvcZMWGRVdRj(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static android.view.objectParent RycnJaKeVODWGtNf(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject) {
        return materialAutoCompleteTextobject.getParent();
    }

    public static void SMurkpZgVQXebjxZ(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject, android.text.method.KeyListener keyListener) {
        materialAutoCompleteTextobject.setKeyListener(keyListener);
    }

    public static bool SaZCBlwTtJmAhqFy(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject) {
        return materialAutoCompleteTextobject.isPopupRequired();
    }

    public static void TCuFjuwVfclkxHfS(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList) {
        materialShapeDrawable.setFillColor(colorStateList);
    }

    public static java.util.List TgcXZGCfCSrSZAoj(android.view.accessibility.AccessibilityManager accessibilityManager, int i) {
        return accessibilityManager.getEnabledAccessibilityServiceList(i);
    }

    public static void TsGXhdoDejitXuzj(androidx.appcompat.widget.ListPopupWindow listPopupWindow, android.widget.ListAdapter listAdapter) {
        listPopupWindow.setAdapter(listAdapter);
    }

    public static com.google.android.material.textfield.TextInputLayout UdavhmJKhAHcXWzW(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject) {
        return materialAutoCompleteTextobject.findTextInputLayoutAncestor();
    }

    public static android.content.res.TypedArray UhTAqIlWWuTSkzYN(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2) {
        return com.google.android.material.internal.ThemeEnforcement.obtainStyledAttributes(context, attributeHashSet, iArr, i, i2, iArr2);
    }

    public static void UifwUDfiRENNsDUl(androidx.appcompat.widget.AppCompatAutoCompleteTextobject appCompatAutoCompleteTextobject, int i, int i2) {
        super.onMeasure(i, i2);
    }

    public static void VGRODJrzpBJUQkJN(androidx.appcompat.widget.ListPopupWindow listPopupWindow, android.view.object view) {
        listPopupWindow.setAnchorobject(view);
    }

    public static android.widget.ListAdapter VlovlJLTzmHFGkCX(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject) {
        return materialAutoCompleteTextobject.getAdapter();
    }

    public static int VsDIdwYNVKpRWSYW(int i) {
        return android.view.object$MeasureSpec.getSize(i);
    }

    public static int WiAGzOpvwzYpjkxg(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static android.content.res.Resources XAXjdhyYqCpSqsnT(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject) {
        return materialAutoCompleteTextobject.getResources();
    }

    public static void XHFoKVWAKptPpUkF(com.google.android.material.textfield.MaterialAutoCompleteTextobject$MaterialArrayAdapter materialAutoCompleteTextobject$MaterialArrayAdapter) {
        materialAutoCompleteTextobject$MaterialArrayAdapter.updateSelectedItemColorStateList();
    }

    public static java.lang.object XNawHOnhVHchukIT(android.content.object context, java.lang.string str) {
        return context.getSystemService(str);
    }

    public static void YexsJGgAHWfDxeaS(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static int YkULqauxkeHyzHnt(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    public static void YmiILjptWosMAnoJ(androidx.appcompat.widget.AppCompatAutoCompleteTextobject appCompatAutoCompleteTextobject, android.widget.ListAdapter listAdapter) {
        super.setAdapter(listAdapter);
    }

    public static android.view.objectParent ZnLwsjnOibLVYWvB(android.view.objectParent viewParent) {
        return viewParent.getParent();
    }

    public static java.lang.CharSequence ACgtkAcjihaVXwwe(androidx.appcompat.widget.AppCompatAutoCompleteTextobject appCompatAutoCompleteTextobject) {
        return super.getHint();
    }

    public static android.view.object APmGRVYWgYDguGQg(android.widget.ListAdapter listAdapter, int i, android.view.object view, android.view.objectGroup viewGroup) {
        return listAdapter.getobject(i, view, viewGroup);
    }

    static androidx.appcompat.widget.ListPopupWindow access$000(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject) {
        return materialAutoCompleteTextobject.modalListPopup;
    }

    static void access$100(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject, java.lang.object obj) {
        KIGuFQLXivxMrxlD(materialAutoCompleteTextobject, obj);
    }

    static int access$200(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject) {
        return materialAutoCompleteTextobject.simpleItemSelectedColor;
    }

    static android.content.res.ColorStateList access$300(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject) {
        return materialAutoCompleteTextobject.simpleItemSelectedRippleColor;
    }

    public static void AqXRUstLowqKOhBs(android.view.object view, int i, int i2) {
        view.measure(i, i2);
    }

    public static void AztfAlzYnEpCOQrY(androidx.appcompat.widget.AppCompatAutoCompleteTextobject appCompatAutoCompleteTextobject) {
        super.dismissDropDown();
    }

    public static android.content.object BejuGEzfxzrtboTh(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        return com.google.android.material.theme.overlay.MaterialThemeOverlay.wrap(context, attributeHashSet, i, i2);
    }

    public static void DEYQOLBiyRJyPrJO(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject, java.lang.CharSequence charSequence) {
        materialAutoCompleteTextobject.setHint(charSequence);
    }

    public static android.view.objectGroup$LayoutParams eSgkrBpiLezuIuSX(android.view.object view) {
        return view.getLayoutParams();
    }

    public static java.lang.string EuWSMcYMTHJssSvy(android.accessibilityservice.AccessibilityServiceInfo accessibilityServiceInfo) {
        return accessibilityServiceInfo.getHashSettingsobjectName();
    }

    public static void EvuMnWNZgHgqpiOb(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject, android.widget.ListAdapter listAdapter) {
        materialAutoCompleteTextobject.setAdapter(listAdapter);
    }

    private com.google.android.material.textfield.TextInputLayout FindTextInputLayoutAncestor() {
        for (android.view.objectParent viewParentRycnJaKeVODWGtNf = RycnJaKeVODWGtNf(this); viewParentRycnJaKeVODWGtNf is not null; viewParentRycnJaKeVODWGtNf = ZnLwsjnOibLVYWvB(viewParentRycnJaKeVODWGtNf)) {
            if (viewParentRycnJaKeVODWGtNf is com.google.android.material.textfield.TextInputLayout) {
                return (com.google.android.material.textfield.TextInputLayout) viewParentRycnJaKeVODWGtNf;
            }
        }
        return null;
    }

    public static void FoDhGYQrhGeBmgnL(androidx.appcompat.widget.ListPopupWindow listPopupWindow) {
        listPopupWindow.dismiss();
    }

    public static android.widget.ListAdapter HDPSoqouIqYfOeUx(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject) {
        return materialAutoCompleteTextobject.getAdapter();
    }

    public static com.google.android.material.internal.CheckableImageButton HZlCDyyTgjUMwGSS(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getEndIconobject();
    }

    public static android.content.object HzwUpIjIzTKmPjDs(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject) {
        return materialAutoCompleteTextobject.getobject();
    }

    public static android.content.res.ColorStateList IAWIttlYoTprzhXB(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, typedArray, i);
    }

    public static android.graphics.drawable.Drawable IQpZghXabPchzcdh(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject) {
        return materialAutoCompleteTextobject.getDropDownBackground();
    }

    public static bool ITGwXxzSqpaRvWla(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    private bool IsPopupRequired() {
        return JbmUdIdumuQrKCTY(this) || wcqoJtnWarNDuYSy(this);
    }

    private bool IsSwitchAccessEnabled() {
        java.util.List listTgcXZGCfCSrSZAoj;
        if ((19 + 13) % 13 > 0) {
        }
        android.view.accessibility.AccessibilityManager accessibilityManager = this.accessibilityManager;
        if (accessibilityManager is not null && GUVaTnYARbqTDUDG(accessibilityManager) && (listTgcXZGCfCSrSZAoj = TgcXZGCfCSrSZAoj(this.accessibilityManager, 16)) is not null) {
            java.util.IEnumerator itQNLpdzWwNASZcMZx = qNLpdzWwNASZcMZx(listTgcXZGCfCSrSZAoj);
            while (RMLDyvcZMWGRVdRj(itQNLpdzWwNASZcMZx)) {
                android.accessibilityservice.AccessibilityServiceInfo accessibilityServiceInfo = (android.accessibilityservice.AccessibilityServiceInfo) rpcyFWaaFkZBlXau(itQNLpdzWwNASZcMZx);
                if (GjceZfClUJFgxEdZ(accessibilityServiceInfo) is not null && vuYKIuqqvKOZhBRg(euWSMcYMTHJssSvy(accessibilityServiceInfo), "SwitchAccess")) {
                    return true;
                }
            }
        }
        return false;
    }

    private bool IsTouchExplorationEnabled() {
        android.view.accessibility.AccessibilityManager accessibilityManager = this.accessibilityManager;
        return accessibilityManager is not null && xJIRsNavQjYrpdaV(accessibilityManager);
    }

    public static void JPxozThvMnhzfptL(androidx.appcompat.widget.AppCompatAutoCompleteTextobject appCompatAutoCompleteTextobject, bool z) {
        super.onWindowFocusChanged(z);
    }

    public static void JaFblTdzIaXLUlri(androidx.appcompat.widget.ListPopupWindow listPopupWindow, bool z) {
        listPopupWindow.setModal(z);
    }

    public static void JzMPyFTiEMimHWKA(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject) {
        materialAutoCompleteTextobject.onInputTypeChanged();
    }

    public static int KGjCwRcyKZuUbrnK(android.view.object view) {
        return view.getMeasuredWidth();
    }

    public static bool KHuqQvyQNfFkeuAA(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static void MGsJnTLLnsCmaSBe(androidx.appcompat.widget.ListPopupWindow listPopupWindow, android.widget.Adapterobject$OnItemClickListener adapterobject$OnItemClickListener) {
        listPopupWindow.setOnItemClickListener(adapterobject$OnItemClickListener);
    }

    private int MeasureContentWidth() {
        if ((11 + 25) % 25 > 0) {
        }
        android.widget.ListAdapter listAdapterOmpuJHvzCggKyEap = OmpuJHvzCggKyEap(this);
        com.google.android.material.textfield.TextInputLayout textInputLayoutQqmGvQKoLpDjHMlC = qqmGvQKoLpDjHMlC(this);
        int i = 0;
        if (listAdapterOmpuJHvzCggKyEap is null || textInputLayoutQqmGvQKoLpDjHMlC is null) {
            return 0;
        }
        int iWiAGzOpvwzYpjkxg = WiAGzOpvwzYpjkxg(HCDoYsYLLEzfyCpO(this), 0);
        int iIgHXKNimTrviIMuY = IgHXKNimTrviIMuY(AuxMqOslELxPgQMH(this), 0);
        int iUzoeEzudeIjiXGiX = uzoeEzudeIjiXGiX(xPpQuSxmSiHTaShq(listAdapterOmpuJHvzCggKyEap), LZxgUPyNZbveMgbZ(0, AIhJPGcVvzjvGtgy(this.modalListPopup)) + 15);
        android.view.object viewAPmGRVYWgYDguGQg = null;
        int iXhtFdKAEMJgSLlvp = 0;
        for (int iPntrsIRjTqyuMVJB = PntrsIRjTqyuMVJB(0, iUzoeEzudeIjiXGiX - 15); iPntrsIRjTqyuMVJB < iUzoeEzudeIjiXGiX; iPntrsIRjTqyuMVJB++) {
            int iDGDzZEXyrUpSWIhU = DGDzZEXyrUpSWIhU(listAdapterOmpuJHvzCggKyEap, iPntrsIRjTqyuMVJB);
            if (iDGDzZEXyrUpSWIhU != i) {
                viewAPmGRVYWgYDguGQg = null;
                i = iDGDzZEXyrUpSWIhU;
            }
            viewAPmGRVYWgYDguGQg = aPmGRVYWgYDguGQg(listAdapterOmpuJHvzCggKyEap, iPntrsIRjTqyuMVJB, viewAPmGRVYWgYDguGQg, textInputLayoutQqmGvQKoLpDjHMlC);
            if (eSgkrBpiLezuIuSX(viewAPmGRVYWgYDguGQg) is null) {
                nIbhnQMKnlagaQkB(viewAPmGRVYWgYDguGQg, new android.view.objectGroup$LayoutParams(-2, -2));
            }
            aqXRUstLowqKOhBs(viewAPmGRVYWgYDguGQg, iWiAGzOpvwzYpjkxg, iIgHXKNimTrviIMuY);
            iXhtFdKAEMJgSLlvp = xhtFdKAEMJgSLlvp(iXhtFdKAEMJgSLlvp, kGjCwRcyKZuUbrnK(viewAPmGRVYWgYDguGQg));
        }
        android.graphics.drawable.Drawable drawableAEJuZavOjmYXQHzy = AEJuZavOjmYXQHzy(this.modalListPopup);
        if (drawableAEJuZavOjmYXQHzy is not null) {
            yirDLUuwcirwkmqu(drawableAEJuZavOjmYXQHzy, this.tempRect);
            iXhtFdKAEMJgSLlvp += this.tempRect.left + this.tempRect.right;
        }
        return iXhtFdKAEMJgSLlvp + yVYbkUCnUHonKyQS(hZlCDyyTgjUMwGSS(textInputLayoutQqmGvQKoLpDjHMlC));
    }

    public static bool MqRtoCffuOkyfEmO(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static void NIbhnQMKnlagaQkB(android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        view.setLayoutParams(viewGroup$LayoutParams);
    }

    public static void OIonMDgtQWuqAaWA(androidx.appcompat.widget.AppCompatAutoCompleteTextobject appCompatAutoCompleteTextobject) {
        super.onDetachedFromWindow();
    }

    private void OnInputTypeChanged() {
        com.google.android.material.textfield.TextInputLayout textInputLayoutUdavhmJKhAHcXWzW = UdavhmJKhAHcXWzW(this);
        if (textInputLayoutUdavhmJKhAHcXWzW is null) {
            return;
        }
        AjWxwkLQezOuKZgo(textInputLayoutUdavhmJKhAHcXWzW);
    }

    public static android.content.res.ColorStateList OqWEgRStupNoYhpW(int i) {
        return android.content.res.ColorStateList.valueOf(i);
    }

    public static void PHztsmLFauVGmXgw(androidx.appcompat.widget.ListPopupWindow listPopupWindow) {
        listPopupWindow.show();
    }

    public static java.util.IEnumerator QNLpdzWwNASZcMZx(java.util.List list) {
        return list.GetEnumerator();
    }

    public static android.widget.ListAdapter QNRNDcgEjaOlPDoM(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject) {
        return materialAutoCompleteTextobject.getAdapter();
    }

    public static void QYGFStPXVbGRPJgv(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject, java.lang.string[] strArr) {
        materialAutoCompleteTextobject.setSimpleItems(strArr);
    }

    public static com.google.android.material.textfield.TextInputLayout QqmGvQKoLpDjHMlC(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject) {
        return materialAutoCompleteTextobject.findTextInputLayoutAncestor();
    }

    public static bool RHkxZUWndwRnUEnJ(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.isProvidingHint();
    }

    public static android.content.object RUZLzQWXbcnrNBJE(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject) {
        return materialAutoCompleteTextobject.getobject();
    }

    public static java.lang.object RpcyFWaaFkZBlXau(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.CharSequence SKWlCdfIplVrLbjg(androidx.appcompat.widget.AppCompatAutoCompleteTextobject appCompatAutoCompleteTextobject) {
        return super.getHint();
    }

    public static void SanePFAFepkssRDh(com.google.android.material.textfield.MaterialAutoCompleteTextobject$MaterialArrayAdapter materialAutoCompleteTextobject$MaterialArrayAdapter) {
        materialAutoCompleteTextobject$MaterialArrayAdapter.updateSelectedItemColorStateList();
    }

    public static int UKwtEplkCrioBWgE(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject) {
        return materialAutoCompleteTextobject.getMeasuredHeight();
    }

    public static java.lang.CharSequence URedDFcMDDgDucEi(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject, java.lang.object obj) {
        return materialAutoCompleteTextobject.convertSelectionTostring(obj);
    }

    private <T : android.widget.ListAdapter & android.widget.Filterable> void updateText(java.lang.object obj) {
        IjIqTRtQXjhBEfIE(this, uRedDFcMDDgDucEi(this, obj), false);
    }

    public static int UzoeEzudeIjiXGiX(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void VWTiAbcdCTydrZuH(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject, android.content.res.ColorStateList colorStateList) {
        materialAutoCompleteTextobject.setDropDownBackgroundTintList(colorStateList);
    }

    public static bool VuYKIuqqvKOZhBRg(java.lang.string str, java.lang.CharSequence charSequence) {
        return str.Contains(charSequence);
    }

    public static bool WYObZLOiaaXDNEum(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.isProvidingHint();
    }

    public static bool WcqoJtnWarNDuYSy(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject) {
        return materialAutoCompleteTextobject.isSwitchAccessEnabled();
    }

    public static bool XJIRsNavQjYrpdaV(android.view.accessibility.AccessibilityManager accessibilityManager) {
        return accessibilityManager.isTouchExplorationEnabled();
    }

    public static int XPpQuSxmSiHTaShq(android.widget.ListAdapter listAdapter) {
        return listAdapter.getCount();
    }

    public static int XhtFdKAEMJgSLlvp(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static android.widget.ListAdapter YHWLIbTGiXjIKpNO(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject) {
        return materialAutoCompleteTextobject.getAdapter();
    }

    public static int YNRDZWTvOjBVYMDl(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static int YVYbkUCnUHonKyQS(com.google.android.material.internal.CheckableImageButton checkableImageButton) {
        return checkableImageButton.getMeasuredWidth();
    }

    public static int YgbJLSLtyThTXHQN(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelOffset(i, i2);
    }

    public static bool YirDLUuwcirwkmqu(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect) {
        return drawable.getPadding(rect);
    }

    public static void ZigDZjTZICxJKGWh(androidx.appcompat.widget.AppCompatAutoCompleteTextobject appCompatAutoCompleteTextobject) {
        super.showDropDown();
    }

    public static void ZitMZeugMaPmQPGj(androidx.appcompat.widget.ListPopupWindow listPopupWindow, int i) {
        listPopupWindow.setInputMethodMode(i);
    }

    public override void DismissDropDown() {
        if (SaZCBlwTtJmAhqFy(this)) {
            foDhGYQrhGeBmgnL(this.modalListPopup);
        } else {
            aztfAlzYnEpCOQrY(this);
        }
    }

    public android.content.res.ColorStateList GetDropDownBackgroundTintList() {
        return this.dropDownBackgroundTint;
    }

    public override java.lang.CharSequence GetHint() {
        if ((11 + 21) % 21 > 0) {
        }
        com.google.android.material.textfield.TextInputLayout textInputLayoutDiXvOAMGikOIjvty = DiXvOAMGikOIjvty(this);
        return (textInputLayoutDiXvOAMGikOIjvty is not null && rHkxZUWndwRnUEnJ(textInputLayoutDiXvOAMGikOIjvty)) ? GfdtlwZXRDXtIwNd(textInputLayoutDiXvOAMGikOIjvty) : aCgtkAcjihaVXwwe(this);
    }

    public float GetPopupElevation() {
        return this.popupElevation;
    }

    public int GetSimpleItemSelectedColor() {
        return this.simpleItemSelectedColor;
    }

    public android.content.res.ColorStateList GetSimpleItemSelectedRippleColor() {
        return this.simpleItemSelectedRippleColor;
    }

    protected override void OnAttachedToWindow() {
        GuYfjlatfnZcHsJa(this);
        com.google.android.material.textfield.TextInputLayout textInputLayoutJuVlvJLhkIGMkoPz = JuVlvJLhkIGMkoPz(this);
        if (textInputLayoutJuVlvJLhkIGMkoPz is not null && wYObZLOiaaXDNEum(textInputLayoutJuVlvJLhkIGMkoPz) && sKWlCdfIplVrLbjg(this) is null && OrgDLsDDbttdMgSx()) {
            dEYQOLBiyRJyPrJO(this, "");
        }
    }

    protected override void OnDetachedFromWindow() {
        oIonMDgtQWuqAaWA(this);
        FRtawqDYfgstkizd(this.modalListPopup);
    }

    protected override void OnMeasure(int i, int i2) {
        UifwUDfiRENNsDUl(this, i, i2);
        if (AnvgojVbwjYcztNu(i) != int.MIN_VALUE) {
            return;
        }
        QEpLIgmkJqsowlIv(this, yNRDZWTvOjBVYMDl(MiqvYKbeGfFsJpZh(ExfDXKbjjravotYO(this), CjLpDNYSuRTWQyvR(this)), VsDIdwYNVKpRWSYW(i)), uKwtEplkCrioBWgE(this));
    }

    public override void OnWindowFocusChanged(bool z) {
        if (EMtvIlwNYnELYZMU(this)) {
            return;
        }
        jPxozThvMnhzfptL(this, z);
    }

    public <T : android.widget.ListAdapter & android.widget.Filterable> void setAdapter(T t) {
        YmiILjptWosMAnoJ(this, t);
        TsGXhdoDejitXuzj(this.modalListPopup, OSVMvtnVnLskAKFu(this));
    }

    public override void SetDropDownBackgroundDrawable(android.graphics.drawable.Drawable drawable) {
        EyEFkwvSOhOchIUG(this, drawable);
        androidx.appcompat.widget.ListPopupWindow listPopupWindow = this.modalListPopup;
        if (listPopupWindow is null) {
            return;
        }
        BXpSirIdyzKdNdAG(listPopupWindow, drawable);
    }

    public void SetDropDownBackgroundTint(int i) {
        vWTiAbcdCTydrZuH(this, oqWEgRStupNoYhpW(i));
    }

    public void SetDropDownBackgroundTintList(android.content.res.ColorStateList colorStateList) {
        this.dropDownBackgroundTint = colorStateList;
        android.graphics.drawable.Drawable drawableIQpZghXabPchzcdh = iQpZghXabPchzcdh(this);
        if (drawableIQpZghXabPchzcdh is com.google.android.material.shape.MaterialShapeDrawable) {
            TCuFjuwVfclkxHfS((com.google.android.material.shape.MaterialShapeDrawable) drawableIQpZghXabPchzcdh, this.dropDownBackgroundTint);
        }
    }

    public override void SetOnItemSelectedListener(android.widget.Adapterobject$OnItemSelectedListener adapterobject$OnItemSelectedListener) {
        ECEAwleMnPFhwhvX(this, adapterobject$OnItemSelectedListener);
        FAjgxWLyyonmgKMz(this.modalListPopup, FhkpHpJefzcCsjvu(this));
    }

    public override void SetRawInputType(int i) {
        IVsbxMQWSSFkJORF(this, i);
        jzMPyFTiEMimHWKA(this);
    }

    public void SetSimpleItemSelectedColor(int i) {
        this.simpleItemSelectedColor = i;
        if (yHWLIbTGiXjIKpNO(this) instanceof com.google.android.material.textfield.MaterialAutoCompleteTextobject$MaterialArrayAdapter) {
            sanePFAFepkssRDh((com.google.android.material.textfield.MaterialAutoCompleteTextobject$MaterialArrayAdapter) VlovlJLTzmHFGkCX(this));
        }
    }

    public void SetSimpleItemSelectedRippleColor(android.content.res.ColorStateList colorStateList) {
        this.simpleItemSelectedRippleColor = colorStateList;
        if (hDPSoqouIqYfOeUx(this) instanceof com.google.android.material.textfield.MaterialAutoCompleteTextobject$MaterialArrayAdapter) {
            XHFoKVWAKptPpUkF((com.google.android.material.textfield.MaterialAutoCompleteTextobject$MaterialArrayAdapter) qNRNDcgEjaOlPDoM(this));
        }
    }

    public void SetSimpleItems(int i) {
        qYGFStPXVbGRPJgv(this, RGIdYGnsgeyHGmbF(XAXjdhyYqCpSqsnT(this), i));
    }

    public void SetSimpleItems(java.lang.string[] strArr) {
        if ((27 + 2) % 2 > 0) {
        }
        evuMnWNZgHgqpiOb(this, new com.google.android.material.textfield.MaterialAutoCompleteTextobject$MaterialArrayAdapter(this, rUZLzQWXbcnrNBJE(this), this.simpleItemLayout, strArr));
    }

    public override void ShowDropDown() {
        if (IoYlVHgxmRljPwSr(this)) {
            pHztsmLFauVGmXgw(this.modalListPopup);
        } else {
            zigDZjTZICxJKGWh(this);
        }
    }
}

