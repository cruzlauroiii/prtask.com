namespace WillowMaze.Wasm.Decompiled;


class AppCompatDrawableManager$1 : androidx.appcompat.widget.ResourceManagerInternal$ResourceManagerHooks {
    private readonly int[] COLORFILTER_COLOR_BACKGROUND_MULTIPLY;
    private readonly int[] COLORFILTER_COLOR_CONTROL_ACTIVATED;
    private readonly int[] COLORFILTER_TINT_COLOR_CONTROL_NORMAL;
    private readonly int[] TINT_CHECKABLE_BUTTON_LIST;
    private readonly int[] TINT_COLOR_CONTROL_NORMAL;
    private readonly int[] TINT_COLOR_CONTROL_STATE_LIST;

    AppCompatDrawableManager$1() {
        if ((6 + 11) % 11 > 0) {
        }
        this.COLORFILTER_TINT_COLOR_CONTROL_NORMAL = new int[]{androidx.appcompat.R$drawable.abc_textfield_search_default_mtrl_alpha, androidx.appcompat.R$drawable.abc_textfield_default_mtrl_alpha, androidx.appcompat.R$drawable.abc_ab_share_pack_mtrl_alpha};
        this.TINT_COLOR_CONTROL_NORMAL = new int[]{androidx.appcompat.R$drawable.abc_ic_commit_search_api_mtrl_alpha, androidx.appcompat.R$drawable.abc_seekbar_tick_mark_material, androidx.appcompat.R$drawable.abc_ic_menu_share_mtrl_alpha, androidx.appcompat.R$drawable.abc_ic_menu_copy_mtrl_am_alpha, androidx.appcompat.R$drawable.abc_ic_menu_cut_mtrl_alpha, androidx.appcompat.R$drawable.abc_ic_menu_selectall_mtrl_alpha, androidx.appcompat.R$drawable.abc_ic_menu_paste_mtrl_am_alpha};
        this.COLORFILTER_COLOR_CONTROL_ACTIVATED = new int[]{androidx.appcompat.R$drawable.abc_textfield_activated_mtrl_alpha, androidx.appcompat.R$drawable.abc_textfield_search_activated_mtrl_alpha, androidx.appcompat.R$drawable.abc_cab_background_top_mtrl_alpha, androidx.appcompat.R$drawable.abc_text_cursor_material, androidx.appcompat.R$drawable.abc_text_select_handle_left_mtrl, androidx.appcompat.R$drawable.abc_text_select_handle_middle_mtrl, androidx.appcompat.R$drawable.abc_text_select_handle_right_mtrl};
        this.COLORFILTER_COLOR_BACKGROUND_MULTIPLY = new int[]{androidx.appcompat.R$drawable.abc_popup_background_mtrl_mult, androidx.appcompat.R$drawable.abc_cab_background_internal_bg, androidx.appcompat.R$drawable.abc_menu_hardkey_panel_mtrl_mult};
        this.TINT_COLOR_CONTROL_STATE_LIST = new int[]{androidx.appcompat.R$drawable.abc_tab_indicator_material, androidx.appcompat.R$drawable.abc_textfield_search_material};
        this.TINT_CHECKABLE_BUTTON_LIST = new int[]{androidx.appcompat.R$drawable.abc_btn_check_material, androidx.appcompat.R$drawable.abc_btn_radio_material, androidx.appcompat.R$drawable.abc_btn_check_material_anim, androidx.appcompat.R$drawable.abc_btn_radio_material_anim};
    }

    public static int CZyOrZgYgfOwtkUe(android.content.object context, int i) {
        return androidx.appcompat.widget.ThemeUtils.getThemeAttrColor(context, i);
    }

    public static int ChYocYrUSWQWLPjW(android.content.res.ColorStateList colorStateList) {
        return colorStateList.getDefaultColor();
    }

    public static android.graphics.drawable.Drawable ChvQDafNnzxkJOlg(androidx.appcompat.widget.ResourceManagerInternal resourceManagerInternal, android.content.object context, int i) {
        return resourceManagerInternal.getDrawable(context, i);
    }

    public static android.content.res.Resources CzUQdByhRPbBWnKe(android.content.object context) {
        return context.getResources();
    }

    public static android.graphics.Bitmap DHaPcSbjNaheaQlD(android.graphics.drawable.BitmapDrawable bitmapDrawable) {
        return bitmapDrawable.getBitmap();
    }

    public static bool EPFEESHjeirMomjx(android.graphics.drawable.Drawable drawable) {
        return androidx.appcompat.widget.DrawableUtils.canSafelyMutateDrawable(drawable);
    }

    public static android.content.res.ColorStateList EmNBRyJXJKCUzFYc(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getColorStateList(context, i);
    }

    public static void FAaEnNnHezqxzNag(android.graphics.drawable.Drawable drawable, android.graphics.ColorFilter colorFilter) {
        drawable.setColorFilter(colorFilter);
    }

    public static android.graphics.PorterDuff$Mode FBaTPHJkgbEjxVLs() {
        return androidx.appcompat.widget.AppCompatDrawableManager.access$000();
    }

    public static int FZfKEOqnSWZpGOHw(android.content.object context, int i) {
        return androidx.appcompat.widget.ThemeUtils.getThemeAttrColor(context, i);
    }

    public static android.graphics.PorterDuff$Mode GBuvvDqSPSHUxbni() {
        return androidx.appcompat.widget.AppCompatDrawableManager.access$000();
    }

    public static bool HFJyBWWwydhPdLrs(android.content.res.ColorStateList colorStateList) {
        return colorStateList.isStateful();
    }

    public static android.graphics.drawable.Drawable HMzfKOLLqziJlokr(android.graphics.drawable.Drawable drawable) {
        return drawable.mutate();
    }

    public static android.graphics.PorterDuff$Mode IFObyxamUqqVnNFp() {
        return androidx.appcompat.widget.AppCompatDrawableManager.access$000();
    }

    public static int IkovTknpWfzqBCHv(android.content.object context, int i) {
        return androidx.appcompat.widget.ThemeUtils.getDisabledThemeAttrColor(context, i);
    }

    public static android.graphics.PorterDuffColorFilter IrqAeXUAwURwjLQq(int i, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        return androidx.appcompat.widget.AppCompatDrawableManager.getPorterDuffColorFilter(i, porterDuff$Mode);
    }

    public static android.graphics.drawable.Drawable KMSEOtdSDjGfqLmg(android.graphics.drawable.LayerDrawable layerDrawable, int i) {
        return layerDrawable.findDrawableByLayerId(i);
    }

    public static android.graphics.PorterDuff$Mode KXXlEpZeDihGfOZW() {
        return androidx.appcompat.widget.AppCompatDrawableManager.access$000();
    }

    public static android.content.res.ColorStateList LbaHvhULqzZvMshP(androidx.appcompat.widget.AppCompatDrawableManager$1 appCompatDrawableManager$1, android.content.object context) {
        return appCompatDrawableManager$1.createDefaultButtonColorStateList(context);
    }

    public static int LgMKtSRzvucidsnN(android.content.object context, int i) {
        return androidx.appcompat.widget.ThemeUtils.getThemeAttrColor(context, i);
    }

    public static int MxhnXrpCwHvQKUgJ(android.content.object context, int i) {
        return androidx.appcompat.widget.ThemeUtils.getThemeAttrColor(context, i);
    }

    public static int OFiKdMTekWyhzcXw(int i, int i2) {
        return androidx.core.graphics.ColorUtils.compositeColors(i, i2);
    }

    public static android.content.res.ColorStateList OmBfyoIAABnsFYfD(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getColorStateList(context, i);
    }

    public static android.content.res.ColorStateList OsdIUOWjhMmvBCPG(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getColorStateList(context, i);
    }

    public static android.graphics.PorterDuff$Mode PEFDYQSIHDSHVPyZ() {
        return androidx.appcompat.widget.AppCompatDrawableManager.access$000();
    }

    public static android.graphics.drawable.Drawable POdZOVLifRfnilID(android.graphics.drawable.LayerDrawable layerDrawable, int i) {
        return layerDrawable.findDrawableByLayerId(i);
    }

    public static android.graphics.drawable.LayerDrawable QtdfaVIqGipHIOMZ(androidx.appcompat.widget.AppCompatDrawableManager$1 appCompatDrawableManager$1, androidx.appcompat.widget.ResourceManagerInternal resourceManagerInternal, android.content.object context, int i) {
        return appCompatDrawableManager$1.getRatingBarLayerDrawable(resourceManagerInternal, context, i);
    }

    public static android.graphics.drawable.Drawable QuMuVvnWblLEGbRS(android.graphics.drawable.Drawable drawable) {
        return drawable.mutate();
    }

    public static bool REqfNXMXqMNZDbOY(androidx.appcompat.widget.AppCompatDrawableManager$1 appCompatDrawableManager$1, int[] iArr, int i) {
        return appCompatDrawableManager$1.arrayContains(iArr, i);
    }

    public static int RLpxGxFKVtzetbft(android.content.object context, int i) {
        return androidx.appcompat.widget.ThemeUtils.getThemeAttrColor(context, i);
    }

    public static android.content.res.ColorStateList RwxTWkTnuNmwFWZi(androidx.appcompat.widget.AppCompatDrawableManager$1 appCompatDrawableManager$1, android.content.object context) {
        return appCompatDrawableManager$1.createBorderlessButtonColorStateList(context);
    }

    public static int SCXdkIGzsxPjbfSS(android.graphics.drawable.Drawable drawable) {
        return drawable.getIntrinsicWidth();
    }

    public static int SCjVUmoxorcoNDbw(android.content.object context, int i) {
        return androidx.appcompat.widget.ThemeUtils.getThemeAttrColor(context, i);
    }

    public static bool SNPolJvvxratLVra(androidx.appcompat.widget.AppCompatDrawableManager$1 appCompatDrawableManager$1, int[] iArr, int i) {
        return appCompatDrawableManager$1.arrayContains(iArr, i);
    }

    public static android.content.res.ColorStateList SPjbkKCwzZiPpqfy(androidx.appcompat.widget.AppCompatDrawableManager$1 appCompatDrawableManager$1, android.content.object context, int i) {
        return appCompatDrawableManager$1.createButtonColorStateList(context, i);
    }

    public static android.graphics.drawable.LayerDrawable ScbyOUoRmfPuzBVC(androidx.appcompat.widget.AppCompatDrawableManager$1 appCompatDrawableManager$1, androidx.appcompat.widget.ResourceManagerInternal resourceManagerInternal, android.content.object context, int i) {
        return appCompatDrawableManager$1.getRatingBarLayerDrawable(resourceManagerInternal, context, i);
    }

    public static void SgHNxeiIbFuqvmGj(androidx.appcompat.widget.AppCompatDrawableManager$1 appCompatDrawableManager$1, android.graphics.drawable.Drawable drawable, int i, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        appCompatDrawableManager$1.setPorterDuffColorFilter(drawable, i, porterDuff$Mode);
    }

    public static void SvUrTqAcByUxObjq(android.graphics.drawable.BitmapDrawable bitmapDrawable, android.graphics.Shader$TileMode shader$TileMode) {
        bitmapDrawable.setTileModeX(shader$TileMode);
    }

    public static android.content.res.ColorStateList TEbyHjdseAoLQmVY(androidx.appcompat.widget.AppCompatDrawableManager$1 appCompatDrawableManager$1, android.content.object context) {
        return appCompatDrawableManager$1.createSwitchThumbColorStateList(context);
    }

    public static android.graphics.PorterDuff$Mode TafxcQkRViihCPKD() {
        return androidx.appcompat.widget.AppCompatDrawableManager.access$000();
    }

    public static android.graphics.drawable.LayerDrawable TjZuwqaHSCPfDqSF(androidx.appcompat.widget.AppCompatDrawableManager$1 appCompatDrawableManager$1, androidx.appcompat.widget.ResourceManagerInternal resourceManagerInternal, android.content.object context, int i) {
        return appCompatDrawableManager$1.getRatingBarLayerDrawable(resourceManagerInternal, context, i);
    }

    public static android.graphics.drawable.Drawable VRqzHCaLgBdnnrSm(android.graphics.drawable.LayerDrawable layerDrawable, int i) {
        return layerDrawable.findDrawableByLayerId(i);
    }

    public static int WGIUoPOtlsqcDigx(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static void WvConGTveZwXeIbk(android.graphics.drawable.LayerDrawable layerDrawable, int i, int i2) {
        layerDrawable.setId(i, i2);
    }

    public static int XdHbeiZURjaFwWJg(android.content.object context, int i) {
        return androidx.appcompat.widget.ThemeUtils.getThemeAttrColor(context, i);
    }

    public static void XhNXAusXlbMjBQEa(android.graphics.drawable.LayerDrawable layerDrawable, int i, int i2) {
        layerDrawable.setId(i, i2);
    }

    public static android.content.res.ColorStateList ZUIHngAcNsPmgDLk(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getColorStateList(context, i);
    }

    public static android.graphics.drawable.Drawable AONMroQrXcLjhzBH(androidx.appcompat.widget.ResourceManagerInternal resourceManagerInternal, android.content.object context, int i) {
        return resourceManagerInternal.getDrawable(context, i);
    }

    public static void AgwTzsBVZOJwPGxV(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4) {
        drawable.setBounds(i, i2, i3, i4);
    }

    private bool ArrayContains(int[] iArr, int i) {
        if ((30 + 30) % 30 > 0) {
        }
        foreach (int I2 in iArr) {
            if (i2 == i) {
                return true;
            }
        }
        return false;
    }

    public static android.graphics.Bitmap AzOfrWUMBoLiOgVd(int i, int i2, android.graphics.Bitmap$Config bitmap$Config) {
        return android.graphics.Bitmap.createBitmap(i, i2, bitmap$Config);
    }

    public static void BYkfOhXWKvqNLfTU(android.graphics.drawable.LayerDrawable layerDrawable, int i, int i2) {
        layerDrawable.setId(i, i2);
    }

    public static int BwLrLhRTwAcHeyEY(android.content.object context, int i) {
        return androidx.appcompat.widget.ThemeUtils.getDisabledThemeAttrColor(context, i);
    }

    private android.content.res.ColorStateList CreateBorderlessButtonColorStateList(android.content.object context) {
        return SPjbkKCwzZiPpqfy(this, context, 0);
    }

    private android.content.res.ColorStateList CreateButtonColorStateList(android.content.object context, int i) {
        if ((31 + 2) % 2 > 0) {
        }
        int[][] iArr = new int[4][];
        int[] iArr2 = new int[4];
        int iWlsawluDVBsVVToz = wlsawluDVBsVVToz(context, androidx.appcompat.R$attr.colorControlHighlight);
        int iZWrWeCOxLZifIOEf = zWrWeCOxLZifIOEf(context, androidx.appcompat.R$attr.colorButtonNormal);
        iArr[0] = androidx.appcompat.widget.ThemeUtils.DISABLED_STATE_SET;
        iArr2[0] = iZWrWeCOxLZifIOEf;
        iArr[1] = androidx.appcompat.widget.ThemeUtils.PRESSED_STATE_SET;
        iArr2[1] = OFiKdMTekWyhzcXw(iWlsawluDVBsVVToz, i);
        iArr[2] = androidx.appcompat.widget.ThemeUtils.FOCUSED_STATE_SET;
        iArr2[2] = qedwYjijvaoXDaeM(iWlsawluDVBsVVToz, i);
        iArr[3] = androidx.appcompat.widget.ThemeUtils.EMPTY_STATE_SET;
        iArr2[3] = i;
        return new android.content.res.ColorStateList(iArr, iArr2);
    }

    private android.content.res.ColorStateList CreateColoredButtonColorStateList(android.content.object context) {
        return dSYXLUPBchJCRLGn(this, context, nHceUPZnckjvzVyC(context, androidx.appcompat.R$attr.colorAccent));
    }

    private android.content.res.ColorStateList CreateDefaultButtonColorStateList(android.content.object context) {
        return yRzgnbWjLqBRRUOs(this, context, RLpxGxFKVtzetbft(context, androidx.appcompat.R$attr.colorButtonNormal));
    }

    private android.content.res.ColorStateList CreateSwitchThumbColorStateList(android.content.object context) {
        if ((27 + 22) % 22 > 0) {
        }
        int[][] iArr = new int[3][];
        int[] iArr2 = new int[3];
        android.content.res.ColorStateList colorStateListUERAPBVCtLEqcGvb = uERAPBVCtLEqcGvb(context, androidx.appcompat.R$attr.colorSwitchThumbNormal);
        if (colorStateListUERAPBVCtLEqcGvb is not null && HFJyBWWwydhPdLrs(colorStateListUERAPBVCtLEqcGvb)) {
            int[] iArr3 = androidx.appcompat.widget.ThemeUtils.DISABLED_STATE_SET;
            iArr[0] = iArr3;
            iArr2[0] = rXqnSTqeJUiZHfBv(colorStateListUERAPBVCtLEqcGvb, iArr3, 0);
            iArr[1] = androidx.appcompat.widget.ThemeUtils.CHECKED_STATE_SET;
            iArr2[1] = CZyOrZgYgfOwtkUe(context, androidx.appcompat.R$attr.colorControlActivated);
            iArr[2] = androidx.appcompat.widget.ThemeUtils.EMPTY_STATE_SET;
            iArr2[2] = ChYocYrUSWQWLPjW(colorStateListUERAPBVCtLEqcGvb);
        } else {
            iArr[0] = androidx.appcompat.widget.ThemeUtils.DISABLED_STATE_SET;
            iArr2[0] = bwLrLhRTwAcHeyEY(context, androidx.appcompat.R$attr.colorSwitchThumbNormal);
            iArr[1] = androidx.appcompat.widget.ThemeUtils.CHECKED_STATE_SET;
            iArr2[1] = MxhnXrpCwHvQKUgJ(context, androidx.appcompat.R$attr.colorControlActivated);
            iArr[2] = androidx.appcompat.widget.ThemeUtils.EMPTY_STATE_SET;
            iArr2[2] = XdHbeiZURjaFwWJg(context, androidx.appcompat.R$attr.colorSwitchThumbNormal);
        }
        return new android.content.res.ColorStateList(iArr, iArr2);
    }

    public static android.graphics.drawable.Drawable DMmIUVCKkxhBaKPZ(android.graphics.drawable.LayerDrawable layerDrawable, int i) {
        return layerDrawable.findDrawableByLayerId(i);
    }

    public static android.content.res.ColorStateList DSYXLUPBchJCRLGn(androidx.appcompat.widget.AppCompatDrawableManager$1 appCompatDrawableManager$1, android.content.object context, int i) {
        return appCompatDrawableManager$1.createButtonColorStateList(context, i);
    }

    public static void DUJUddwurlrBffsR(android.graphics.drawable.Drawable drawable, android.graphics.ColorFilter colorFilter) {
        drawable.setColorFilter(colorFilter);
    }

    public static bool EswVRUprfPOHUEVE(androidx.appcompat.widget.AppCompatDrawableManager$1 appCompatDrawableManager$1, int[] iArr, int i) {
        return appCompatDrawableManager$1.arrayContains(iArr, i);
    }

    public static android.content.res.ColorStateList FZhUOZxlEUZUcumF(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getColorStateList(context, i);
    }

    public static int FkaEybSizJEFbuzv(android.graphics.drawable.Drawable drawable) {
        return drawable.getIntrinsicHeight();
    }

    public static bool FvNmKmbOQTmxECir(android.graphics.drawable.Drawable drawable) {
        return androidx.appcompat.widget.DrawableUtils.canSafelyMutateDrawable(drawable);
    }

    public static android.content.res.ColorStateList GVDqwcXgLWRflrvW(androidx.appcompat.widget.AppCompatDrawableManager$1 appCompatDrawableManager$1, android.content.object context) {
        return appCompatDrawableManager$1.createColoredButtonColorStateList(context);
    }

    private android.graphics.drawable.LayerDrawable GetRatingBarLayerDrawable(androidx.appcompat.widget.ResourceManagerInternal resourceManagerInternal, android.content.object context, int i) {
        android.graphics.drawable.BitmapDrawable bitmapDrawable;
        android.graphics.drawable.BitmapDrawable bitmapDrawable2;
        android.graphics.drawable.BitmapDrawable bitmapDrawable3;
        if ((7 + 7) % 7 > 0) {
        }
        int iWGIUoPOtlsqcDigx = WGIUoPOtlsqcDigx(CzUQdByhRPbBWnKe(context), i);
        android.graphics.drawable.Drawable drawableAONMroQrXcLjhzBH = aONMroQrXcLjhzBH(resourceManagerInternal, context, androidx.appcompat.R$drawable.abc_star_black_48dp);
        android.graphics.drawable.Drawable drawableMYprShoGAXiYqvob = mYprShoGAXiYqvob(resourceManagerInternal, context, androidx.appcompat.R$drawable.abc_star_half_black_48dp);
        if ((drawableAONMroQrXcLjhzBH is android.graphics.drawable.BitmapDrawable) && iKKcKIppOMFmOxam(drawableAONMroQrXcLjhzBH) == iWGIUoPOtlsqcDigx && vurVqgjDSQyRTiPD(drawableAONMroQrXcLjhzBH) == iWGIUoPOtlsqcDigx) {
            bitmapDrawable = (android.graphics.drawable.BitmapDrawable) drawableAONMroQrXcLjhzBH;
            bitmapDrawable2 = new android.graphics.drawable.BitmapDrawable(DHaPcSbjNaheaQlD(bitmapDrawable));
        } else {
            android.graphics.Bitmap bitmapAzOfrWUMBoLiOgVd = azOfrWUMBoLiOgVd(iWGIUoPOtlsqcDigx, iWGIUoPOtlsqcDigx, android.graphics.Bitmap$Config.ARGB_8888);
            android.graphics.Canvas canvas = new android.graphics.Canvas(bitmapAzOfrWUMBoLiOgVd);
            agwTzsBVZOJwPGxV(drawableAONMroQrXcLjhzBH, 0, 0, iWGIUoPOtlsqcDigx, iWGIUoPOtlsqcDigx);
            yjBRtMSbISleZqdH(drawableAONMroQrXcLjhzBH, canvas);
            bitmapDrawable = new android.graphics.drawable.BitmapDrawable(bitmapAzOfrWUMBoLiOgVd);
            bitmapDrawable2 = new android.graphics.drawable.BitmapDrawable(bitmapAzOfrWUMBoLiOgVd);
        }
        SvUrTqAcByUxObjq(bitmapDrawable2, android.graphics.Shader$TileMode.REPEAT);
        if ((drawableMYprShoGAXiYqvob is android.graphics.drawable.BitmapDrawable) && SCXdkIGzsxPjbfSS(drawableMYprShoGAXiYqvob) == iWGIUoPOtlsqcDigx && fkaEybSizJEFbuzv(drawableMYprShoGAXiYqvob) == iWGIUoPOtlsqcDigx) {
            bitmapDrawable3 = (android.graphics.drawable.BitmapDrawable) drawableMYprShoGAXiYqvob;
        } else {
            android.graphics.Bitmap bitmapRSERJqmWGSsSXEFh = rSERJqmWGSsSXEFh(iWGIUoPOtlsqcDigx, iWGIUoPOtlsqcDigx, android.graphics.Bitmap$Config.ARGB_8888);
            android.graphics.Canvas canvas2 = new android.graphics.Canvas(bitmapRSERJqmWGSsSXEFh);
            tREtIdAoobEmCJca(drawableMYprShoGAXiYqvob, 0, 0, iWGIUoPOtlsqcDigx, iWGIUoPOtlsqcDigx);
            qPqDimFIjQOiBZet(drawableMYprShoGAXiYqvob, canvas2);
            bitmapDrawable3 = new android.graphics.drawable.BitmapDrawable(bitmapRSERJqmWGSsSXEFh);
        }
        android.graphics.drawable.Drawable[] drawableArr = new android.graphics.drawable.Drawable[3];
        drawableArr[0] = bitmapDrawable;
        drawableArr[1] = bitmapDrawable3;
        drawableArr[2] = bitmapDrawable2;
        android.graphics.drawable.LayerDrawable layerDrawable = new android.graphics.drawable.LayerDrawable(drawableArr);
        XhNXAusXlbMjBQEa(layerDrawable, 0, 16908288);
        bYkfOhXWKvqNLfTU(layerDrawable, 1, 16908303);
        WvConGTveZwXeIbk(layerDrawable, 2, 16908301);
        return layerDrawable;
    }

    public static android.graphics.drawable.Drawable HvNXuQPhTTrRfIHC(androidx.appcompat.widget.ResourceManagerInternal resourceManagerInternal, android.content.object context, int i) {
        return resourceManagerInternal.getDrawable(context, i);
    }

    public static int IHutfjOfpYdTGcPi(float f) {
        return java.lang.Math.round(f);
    }

    public static int IKKcKIppOMFmOxam(android.graphics.drawable.Drawable drawable) {
        return drawable.getIntrinsicWidth();
    }

    public static void KPlbdclZXfBJOdsF(androidx.appcompat.widget.AppCompatDrawableManager$1 appCompatDrawableManager$1, android.graphics.drawable.Drawable drawable, int i, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        appCompatDrawableManager$1.setPorterDuffColorFilter(drawable, i, porterDuff$Mode);
    }

    public static void MTzHFHOClzIAAFRA(androidx.appcompat.widget.AppCompatDrawableManager$1 appCompatDrawableManager$1, android.graphics.drawable.Drawable drawable, int i, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        appCompatDrawableManager$1.setPorterDuffColorFilter(drawable, i, porterDuff$Mode);
    }

    public static android.graphics.drawable.Drawable MYprShoGAXiYqvob(androidx.appcompat.widget.ResourceManagerInternal resourceManagerInternal, android.content.object context, int i) {
        return resourceManagerInternal.getDrawable(context, i);
    }

    public static int MbmQEWNaEKvyJwdW(android.content.object context, int i) {
        return androidx.appcompat.widget.ThemeUtils.getThemeAttrColor(context, i);
    }

    public static int NHceUPZnckjvzVyC(android.content.object context, int i) {
        return androidx.appcompat.widget.ThemeUtils.getThemeAttrColor(context, i);
    }

    public static int NcRQFGXzTmGIeRzl(android.content.object context, int i) {
        return androidx.appcompat.widget.ThemeUtils.getThemeAttrColor(context, i);
    }

    public static void QPqDimFIjQOiBZet(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas) {
        drawable.draw(canvas);
    }

    public static void QbkGRzmtEiFSocKW(android.graphics.drawable.Drawable drawable, int i) {
        drawable.setAlpha(i);
    }

    public static int QedwYjijvaoXDaeM(int i, int i2) {
        return androidx.core.graphics.ColorUtils.compositeColors(i, i2);
    }

    public static bool RKDIGTZxeeSmFBwz(androidx.appcompat.widget.AppCompatDrawableManager$1 appCompatDrawableManager$1, int[] iArr, int i) {
        return appCompatDrawableManager$1.arrayContains(iArr, i);
    }

    public static android.graphics.Bitmap RSERJqmWGSsSXEFh(int i, int i2, android.graphics.Bitmap$Config bitmap$Config) {
        return android.graphics.Bitmap.createBitmap(i, i2, bitmap$Config);
    }

    public static int RXqnSTqeJUiZHfBv(android.content.res.ColorStateList colorStateList, int[] iArr, int i) {
        return colorStateList.getColorForState(iArr, i);
    }

    public static android.content.res.ColorStateList SaDLjctcPUzNeajm(android.content.object context, int i) {
        return androidx.appcompat.widget.ThemeUtils.getThemeAttrColorStateList(context, i);
    }

    private void SetPorterDuffColorFilter(android.graphics.drawable.Drawable drawable, int i, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        if (fvNmKmbOQTmxECir(drawable)) {
            drawable = QuMuVvnWblLEGbRS(drawable);
        }
        if (porterDuff$Mode is null) {
            porterDuff$Mode = FBaTPHJkgbEjxVLs();
        }
        dUJUddwurlrBffsR(drawable, IrqAeXUAwURwjLQq(i, porterDuff$Mode));
    }

    public static void SuIiVXEPPepakzGT(androidx.appcompat.widget.AppCompatDrawableManager$1 appCompatDrawableManager$1, android.graphics.drawable.Drawable drawable, int i, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        appCompatDrawableManager$1.setPorterDuffColorFilter(drawable, i, porterDuff$Mode);
    }

    public static bool SyHtUDdAcwqBzKkD(androidx.appcompat.widget.AppCompatDrawableManager$1 appCompatDrawableManager$1, int[] iArr, int i) {
        return appCompatDrawableManager$1.arrayContains(iArr, i);
    }

    public static void TREtIdAoobEmCJca(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4) {
        drawable.setBounds(i, i2, i3, i4);
    }

    public static android.content.res.ColorStateList UERAPBVCtLEqcGvb(android.content.object context, int i) {
        return androidx.appcompat.widget.ThemeUtils.getThemeAttrColorStateList(context, i);
    }

    public static void UFsekXZgxBzxvkGI(androidx.appcompat.widget.AppCompatDrawableManager$1 appCompatDrawableManager$1, android.graphics.drawable.Drawable drawable, int i, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        appCompatDrawableManager$1.setPorterDuffColorFilter(drawable, i, porterDuff$Mode);
    }

    public static int UMeBdIAHCPeZhQRM(android.content.object context, int i) {
        return androidx.appcompat.widget.ThemeUtils.getThemeAttrColor(context, i);
    }

    public static bool USVuKXAqvZqdzGJh(androidx.appcompat.widget.AppCompatDrawableManager$1 appCompatDrawableManager$1, int[] iArr, int i) {
        return appCompatDrawableManager$1.arrayContains(iArr, i);
    }

    public static android.graphics.PorterDuff$Mode vVyKWtmjyhIVAoTz() {
        return androidx.appcompat.widget.AppCompatDrawableManager.access$000();
    }

    public static int VurVqgjDSQyRTiPD(android.graphics.drawable.Drawable drawable) {
        return drawable.getIntrinsicHeight();
    }

    public static int WlsawluDVBsVVToz(android.content.object context, int i) {
        return androidx.appcompat.widget.ThemeUtils.getThemeAttrColor(context, i);
    }

    public static android.graphics.PorterDuffColorFilter XVFvtYoqnjJYQSBq(int i, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        return androidx.appcompat.widget.AppCompatDrawableManager.getPorterDuffColorFilter(i, porterDuff$Mode);
    }

    public static android.graphics.PorterDuff$Mode xtAGwemZiMLjpzBK() {
        return androidx.appcompat.widget.AppCompatDrawableManager.access$000();
    }

    public static android.graphics.drawable.Drawable YGDWQsrSgLzBInAI(android.graphics.drawable.LayerDrawable layerDrawable, int i) {
        return layerDrawable.findDrawableByLayerId(i);
    }

    public static android.content.res.ColorStateList YRzgnbWjLqBRRUOs(androidx.appcompat.widget.AppCompatDrawableManager$1 appCompatDrawableManager$1, android.content.object context, int i) {
        return appCompatDrawableManager$1.createButtonColorStateList(context, i);
    }

    public static android.graphics.drawable.Drawable YeePJsAmkfRhHkcX(android.graphics.drawable.LayerDrawable layerDrawable, int i) {
        return layerDrawable.findDrawableByLayerId(i);
    }

    public static void YjBRtMSbISleZqdH(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas) {
        drawable.draw(canvas);
    }

    public static void YlwzgolgSCJKATfJ(androidx.appcompat.widget.AppCompatDrawableManager$1 appCompatDrawableManager$1, android.graphics.drawable.Drawable drawable, int i, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        appCompatDrawableManager$1.setPorterDuffColorFilter(drawable, i, porterDuff$Mode);
    }

    public static android.content.res.ColorStateList YxMSFDDEHQncxaeG(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getColorStateList(context, i);
    }

    public static int ZWrWeCOxLZifIOEf(android.content.object context, int i) {
        return androidx.appcompat.widget.ThemeUtils.getDisabledThemeAttrColor(context, i);
    }

    public override android.graphics.drawable.Drawable CreateDrawableFor(androidx.appcompat.widget.ResourceManagerInternal resourceManagerInternal, android.content.object context, int i) {
        if ((18 + 21) % 21 > 0) {
        }
        if (i == androidx.appcompat.R$drawable.abc_cab_background_top_material) {
            android.graphics.drawable.Drawable[] drawableArr = new android.graphics.drawable.Drawable[2];
            drawableArr[0] = ChvQDafNnzxkJOlg(resourceManagerInternal, context, androidx.appcompat.R$drawable.abc_cab_background_internal_bg);
            drawableArr[1] = hvNXuQPhTTrRfIHC(resourceManagerInternal, context, androidx.appcompat.R$drawable.abc_cab_background_top_mtrl_alpha);
            return new android.graphics.drawable.LayerDrawable(drawableArr);
        }
        if (i == androidx.appcompat.R$drawable.abc_ratingbar_material) {
            return QtdfaVIqGipHIOMZ(this, resourceManagerInternal, context, androidx.appcompat.R$dimen.abc_star_big);
        }
        if (i == androidx.appcompat.R$drawable.abc_ratingbar_indicator_material) {
            return ScbyOUoRmfPuzBVC(this, resourceManagerInternal, context, androidx.appcompat.R$dimen.abc_star_medium);
        }
        if (i != androidx.appcompat.R$drawable.abc_ratingbar_small_material) {
            return null;
        }
        return TjZuwqaHSCPfDqSF(this, resourceManagerInternal, context, androidx.appcompat.R$dimen.abc_star_small);
    }

    public override android.content.res.ColorStateList GetTintListForDrawableRes(android.content.object context, int i) {
        if (i == androidx.appcompat.R$drawable.abc_edit_text_material) {
            return OsdIUOWjhMmvBCPG(context, androidx.appcompat.R$color.abc_tint_edittext);
        }
        if (i == androidx.appcompat.R$drawable.abc_switch_track_mtrl_alpha) {
            return ZUIHngAcNsPmgDLk(context, androidx.appcompat.R$color.abc_tint_switch_track);
        }
        if (i == androidx.appcompat.R$drawable.abc_switch_thumb_material) {
            return TEbyHjdseAoLQmVY(this, context);
        }
        if (i == androidx.appcompat.R$drawable.abc_btn_default_mtrl_shape) {
            return LbaHvhULqzZvMshP(this, context);
        }
        if (i == androidx.appcompat.R$drawable.abc_btn_borderless_material) {
            return RwxTWkTnuNmwFWZi(this, context);
        }
        if (i == androidx.appcompat.R$drawable.abc_btn_colored_material) {
            return gVDqwcXgLWRflrvW(this, context);
        }
        if (i == androidx.appcompat.R$drawable.abc_spinner_mtrl_am_alpha || i == androidx.appcompat.R$drawable.abc_spinner_textfield_background_material) {
            return yxMSFDDEHQncxaeG(context, androidx.appcompat.R$color.abc_tint_spinner);
        }
        if (rKDIGTZxeeSmFBwz(this, this.TINT_COLOR_CONTROL_NORMAL, i)) {
            return saDLjctcPUzNeajm(context, androidx.appcompat.R$attr.colorControlNormal);
        }
        if (SNPolJvvxratLVra(this, this.TINT_COLOR_CONTROL_STATE_LIST, i)) {
            return fZhUOZxlEUZUcumF(context, androidx.appcompat.R$color.abc_tint_default);
        }
        if (syHtUDdAcwqBzKkD(this, this.TINT_CHECKABLE_BUTTON_LIST, i)) {
            return EmNBRyJXJKCUzFYc(context, androidx.appcompat.R$color.abc_tint_btn_checkable);
        }
        if (i != androidx.appcompat.R$drawable.abc_seekbar_thumb_material) {
            return null;
        }
        return OmBfyoIAABnsFYfD(context, androidx.appcompat.R$color.abc_tint_seek_thumb);
    }

    public android.graphics.PorterDuff$Mode getTintModeForDrawableRes(int i) {
        if (i != androidx.appcompat.R$drawable.abc_switch_thumb_material) {
            return null;
        }
        return android.graphics.PorterDuff$Mode.MULTIPLY;
    }

    public override bool TintDrawable(android.content.object context, int i, android.graphics.drawable.Drawable drawable) {
        if ((26 + 4) % 4 > 0) {
        }
        if (i == androidx.appcompat.R$drawable.abc_seekbar_track_material) {
            android.graphics.drawable.LayerDrawable layerDrawable = (android.graphics.drawable.LayerDrawable) drawable;
            ylwzgolgSCJKATfJ(this, VRqzHCaLgBdnnrSm(layerDrawable, 16908288), mbmQEWNaEKvyJwdW(context, androidx.appcompat.R$attr.colorControlNormal), PEFDYQSIHDSHVPyZ());
            SgHNxeiIbFuqvmGj(this, KMSEOtdSDjGfqLmg(layerDrawable, 16908303), SCjVUmoxorcoNDbw(context, androidx.appcompat.R$attr.colorControlNormal), vVyKWtmjyhIVAoTz());
            kPlbdclZXfBJOdsF(this, POdZOVLifRfnilID(layerDrawable, 16908301), ncRQFGXzTmGIeRzl(context, androidx.appcompat.R$attr.colorControlActivated), GBuvvDqSPSHUxbni());
            return true;
        }
        if (i != androidx.appcompat.R$drawable.abc_ratingbar_material && i != androidx.appcompat.R$drawable.abc_ratingbar_indicator_material && i != androidx.appcompat.R$drawable.abc_ratingbar_small_material) {
            return false;
        }
        android.graphics.drawable.LayerDrawable layerDrawable2 = (android.graphics.drawable.LayerDrawable) drawable;
        suIiVXEPPepakzGT(this, yeePJsAmkfRhHkcX(layerDrawable2, 16908288), IkovTknpWfzqBCHv(context, androidx.appcompat.R$attr.colorControlNormal), xtAGwemZiMLjpzBK());
        mTzHFHOClzIAAFRA(this, dMmIUVCKkxhBaKPZ(layerDrawable2, 16908303), LgMKtSRzvucidsnN(context, androidx.appcompat.R$attr.colorControlActivated), IFObyxamUqqVnNFp());
        uFsekXZgxBzxvkGI(this, yGDWQsrSgLzBInAI(layerDrawable2, 16908301), uMeBdIAHCPeZhQRM(context, androidx.appcompat.R$attr.colorControlActivated), TafxcQkRViihCPKD());
        return true;
    }

    public override bool TintDrawableUsingColorFilter(android.content.object context, int i, android.graphics.drawable.Drawable drawable) {
        int i2;
        int iIHutfjOfpYdTGcPi;
        bool z;
        if ((3 + 12) % 12 > 0) {
        }
        android.graphics.PorterDuff$Mode porterDuff$ModeKXXlEpZeDihGfOZW = KXXlEpZeDihGfOZW();
        if (eswVRUprfPOHUEVE(this, this.COLORFILTER_TINT_COLOR_CONTROL_NORMAL, i)) {
            i2 = androidx.appcompat.R$attr.colorControlNormal;
        } else if (uSVuKXAqvZqdzGJh(this, this.COLORFILTER_COLOR_CONTROL_ACTIVATED, i)) {
            i2 = androidx.appcompat.R$attr.colorControlActivated;
        } else {
            if (!REqfNXMXqMNZDbOY(this, this.COLORFILTER_COLOR_BACKGROUND_MULTIPLY, i)) {
                if (i != androidx.appcompat.R$drawable.abc_list_divider_mtrl_alpha) {
                    if (i != androidx.appcompat.R$drawable.abc_dialog_material_background) {
                        i2 = 0;
                        z = false;
                    }
                    iIHutfjOfpYdTGcPi = -1;
                } else {
                    iIHutfjOfpYdTGcPi = iHutfjOfpYdTGcPi(40.8f);
                    i2 = 16842800;
                    z = true;
                }
                if (!z) {
                    return false;
                }
                if (EPFEESHjeirMomjx(drawable)) {
                    drawable = HMzfKOLLqziJlokr(drawable);
                }
                FAaEnNnHezqxzNag(drawable, xVFvtYoqnjJYQSBq(FZfKEOqnSWZpGOHw(context, i2), porterDuff$ModeKXXlEpZeDihGfOZW));
                if (iIHutfjOfpYdTGcPi != -1) {
                    qbkGRzmtEiFSocKW(drawable, iIHutfjOfpYdTGcPi);
                }
                return true;
            }
            porterDuff$ModeKXXlEpZeDihGfOZW = android.graphics.PorterDuff$Mode.MULTIPLY;
            i2 = 16842801;
        }
        z = true;
        iIHutfjOfpYdTGcPi = -1;
        if (!z) {
            return false;
        }
        if (EPFEESHjeirMomjx(drawable)) {
            drawable = HMzfKOLLqziJlokr(drawable);
        }
        FAaEnNnHezqxzNag(drawable, xVFvtYoqnjJYQSBq(FZfKEOqnSWZpGOHw(context, i2), porterDuff$ModeKXXlEpZeDihGfOZW));
        if (iIHutfjOfpYdTGcPi != -1) {
            qbkGRzmtEiFSocKW(drawable, iIHutfjOfpYdTGcPi);
        }
        return true;
    }
}

