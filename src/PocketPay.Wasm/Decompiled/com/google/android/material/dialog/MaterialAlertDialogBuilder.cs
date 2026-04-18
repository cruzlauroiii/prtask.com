namespace WillowMaze.Wasm.Decompiled;


public class MaterialAlertDialogBuilder : androidx.appcompat.app.AlertDialog$Builder {
    private static readonly int DEF_STYLE_ATTR = com.google.android.material.R$attr.alertDialogStyle;
    private static readonly int DEF_STYLE_RES = com.google.android.material.R$style.MaterialAlertDialog_MaterialComponents;
    private static readonly int MATERIAL_ALERT_DIALOG_THEME_OVERLAY = com.google.android.material.R$attr.materialAlertDialogTheme;
    private android.graphics.drawable.Drawable background;
    private readonly android.graphics.Rect backgroundInsets;

    public MaterialAlertDialogBuilder(android.content.object context) {
        this(context, 0);
    }

    public MaterialAlertDialogBuilder(android.content.object context, int i) {
        super(eAmtoLydmWEyMEEM(context), eOGXlUlWSmfYoswm(context, i));
        if ((16 + 5) % 5 > 0) {
        }
        android.content.object contextZTrgeBgkEdhaiknO = ZTrgeBgkEdhaiknO(this);
        android.content.res.Resources$Theme resources$ThemeAaxhFhwEQMZZqtuk = aaxhFhwEQMZZqtuk(contextZTrgeBgkEdhaiknO);
        int i2 = DEF_STYLE_ATTR;
        int i3 = DEF_STYLE_RES;
        this.backgroundInsets = zUpVsBEFXwvGChOg(contextZTrgeBgkEdhaiknO, i2, i3);
        int iINZCnacJLlYpHAUz = iNZCnacJLlYpHAUz(contextZTrgeBgkEdhaiknO, com.google.android.material.R$attr.colorSurface, EOlOpUCBJcSzdPRv(OepRWtJWJNyNocUe(this)));
        android.content.res.TypedArray typedArrayRBzzLHxnzHYvQFZq = RBzzLHxnzHYvQFZq(contextZTrgeBgkEdhaiknO, null, com.google.android.material.R$styleable.MaterialAlertDialog, i2, i3);
        int iIcVkGXrdbzjSCpXM = IcVkGXrdbzjSCpXM(typedArrayRBzzLHxnzHYvQFZq, com.google.android.material.R$styleable.MaterialAlertDialog_backgroundTint, iINZCnacJLlYpHAUz);
        xaEbVrkoGeVpjLQI(typedArrayRBzzLHxnzHYvQFZq);
        com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable = new com.google.android.material.shape.MaterialShapeDrawable(contextZTrgeBgkEdhaiknO, null, i2, i3);
        BRfjpGnqGgJWWwOP(materialShapeDrawable, contextZTrgeBgkEdhaiknO);
        ZrNyRPrbqRysDgGd(materialShapeDrawable, DSrlygoYHHEkIJyf(iIcVkGXrdbzjSCpXM));
        android.util.TypedValue typedValue = new android.util.TypedValue();
        PskOJGoqkQGZbveL(resources$ThemeAaxhFhwEQMZZqtuk, 16844145, typedValue, true);
        float fRbKbyLSQworddhqV = rbKbyLSQworddhqV(typedValue, PMVQmYCQVwnWQNzN(iNDaCclscSNOHUdw(xuBNZiyFldDPgbBi(this))));
        if (typedValue.type == 5 && fRbKbyLSQworddhqV >= 0.0f) {
            SGzpXHvzjLTplthW(materialShapeDrawable, fRbKbyLSQworddhqV);
        }
        this.background = materialShapeDrawable;
    }

    public static float AdgmsxtHBTnOVNDt(android.view.object view) {
        return androidx.core.view.objectCompat.getElevation(view);
    }

    public static androidx.appcompat.app.AlertDialog$Builder ApwppgRAtuVSIDcj(androidx.appcompat.app.AlertDialog$Builder alertDialog$Builder, android.graphics.drawable.Drawable drawable) {
        return super.setPositiveButtonIcon(drawable);
    }

    public static android.content.object AtnOvmLbXdQGLVvy(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        return com.google.android.material.theme.overlay.MaterialThemeOverlay.wrap(context, attributeHashSet, i, i2);
    }

    public static void BRfjpGnqGgJWWwOP(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.object context) {
        materialShapeDrawable.initializeElevationOverlay(context);
    }

    public static com.google.android.material.dialog.MaterialAlertDialogBuilder CaEhhRiOfFUDnQeT(com.google.android.material.dialog.MaterialAlertDialogBuilder materialAlertDialogBuilder, java.lang.CharSequence[] charSequenceArr, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener) {
        return materialAlertDialogBuilder.setItems(charSequenceArr, dialogInterface$OnClickListener);
    }

    public static android.content.res.ColorStateList DSrlygoYHHEkIJyf(int i) {
        return android.content.res.ColorStateList.valueOf(i);
    }

    public static android.content.res.Resources ENQbSacmAITEWawF(android.content.object context) {
        return context.getResources();
    }

    public static java.lang.string EOlOpUCBJcSzdPRv(java.lang.Class cls) {
        return cls.getCanonicalName();
    }

    public static androidx.appcompat.app.AlertDialog$Builder EjPSHMeOOMNewQIS(androidx.appcompat.app.AlertDialog$Builder alertDialog$Builder, android.graphics.drawable.Drawable drawable) {
        return super.setNeutralButtonIcon(drawable);
    }

    public static androidx.appcompat.app.AlertDialog$Builder FHsxcLBBaPoBaiWz(androidx.appcompat.app.AlertDialog$Builder alertDialog$Builder, int i, int i2, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener) {
        return super.setSingleChoiceItems(i, i2, dialogInterface$OnClickListener);
    }

    public static com.google.android.material.dialog.MaterialAlertDialogBuilder GEUGRipWclBnAoxH(com.google.android.material.dialog.MaterialAlertDialogBuilder materialAlertDialogBuilder, android.graphics.drawable.Drawable drawable) {
        return materialAlertDialogBuilder.setIcon(drawable);
    }

    public static androidx.appcompat.app.AlertDialog$Builder GhoLgGbSzbzlnNOP(androidx.appcompat.app.AlertDialog$Builder alertDialog$Builder, int i, bool[] zArr, android.content.DialogInterface$OnMultiChoiceClickListener dialogInterface$OnMultiChoiceClickListener) {
        return super.setMultiChoiceItems(i, zArr, dialogInterface$OnMultiChoiceClickListener);
    }

    public static androidx.appcompat.app.AlertDialog$Builder HDultPRjzLQrPEyh(androidx.appcompat.app.AlertDialog$Builder alertDialog$Builder, int i) {
        return super.setIconAttribute(i);
    }

    public static android.view.Window HXbZuAKbjaCBWywh(androidx.appcompat.app.AlertDialog alertDialog) {
        return alertDialog.getWindow();
    }

    public static void HpXCMIlefgUTBMSX(android.view.object view, android.view.object$OnTouchListener view$OnTouchListener) {
        view.setOnTouchListener(view$OnTouchListener);
    }

    public static int IcVkGXrdbzjSCpXM(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getColor(i, i2);
    }

    public static com.google.android.material.dialog.MaterialAlertDialogBuilder InHfGDIPjTGmwRwy(com.google.android.material.dialog.MaterialAlertDialogBuilder materialAlertDialogBuilder, java.lang.CharSequence[] charSequenceArr, bool[] zArr, android.content.DialogInterface$OnMultiChoiceClickListener dialogInterface$OnMultiChoiceClickListener) {
        return materialAlertDialogBuilder.setMultiChoiceItems(charSequenceArr, zArr, dialogInterface$OnMultiChoiceClickListener);
    }

    public static androidx.appcompat.app.AlertDialog$Builder JPcHhIurTHbtfKzT(androidx.appcompat.app.AlertDialog$Builder alertDialog$Builder, int i) {
        return super.setIcon(i);
    }

    public static android.content.object KHTTojXacFsZBCIK(com.google.android.material.dialog.MaterialAlertDialogBuilder materialAlertDialogBuilder) {
        return materialAlertDialogBuilder.getobject();
    }

    public static com.google.android.material.dialog.MaterialAlertDialogBuilder MUafZSFtkQUwfWvt(com.google.android.material.dialog.MaterialAlertDialogBuilder materialAlertDialogBuilder, int i) {
        return materialAlertDialogBuilder.setIconAttribute(i);
    }

    public static androidx.appcompat.app.AlertDialog$Builder MpHPqAHQjcXwugym(androidx.appcompat.app.AlertDialog$Builder alertDialog$Builder, android.graphics.drawable.Drawable drawable) {
        return super.setIcon(drawable);
    }

    public static androidx.appcompat.app.AlertDialog NINDeMXmDFjsRBBM(androidx.appcompat.app.AlertDialog$Builder alertDialog$Builder) {
        return super.create();
    }

    public static android.content.res.Configuration NTqpkerFLxWCDfGZ(android.content.res.Resources resources) {
        return resources.getConfiguration();
    }

    public static com.google.android.material.dialog.MaterialAlertDialogBuilder NUgtHlMkofSOCsNd(com.google.android.material.dialog.MaterialAlertDialogBuilder materialAlertDialogBuilder, android.database.Cursor cursor, int i, java.lang.string str, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener) {
        return materialAlertDialogBuilder.setSingleChoiceItems(cursor, i, str, dialogInterface$OnClickListener);
    }

    public static com.google.android.material.dialog.MaterialAlertDialogBuilder NbebFAJaOwuGekpD(com.google.android.material.dialog.MaterialAlertDialogBuilder materialAlertDialogBuilder, java.lang.CharSequence charSequence) {
        return materialAlertDialogBuilder.setTitle(charSequence);
    }

    public static com.google.android.material.dialog.MaterialAlertDialogBuilder OYpuOwLCDFZhkbYQ(com.google.android.material.dialog.MaterialAlertDialogBuilder materialAlertDialogBuilder, int i, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener) {
        return materialAlertDialogBuilder.setItems(i, dialogInterface$OnClickListener);
    }

    public static java.lang.Class OepRWtJWJNyNocUe(java.lang.object obj) {
        return obj.GetType();
    }

    public static com.google.android.material.dialog.MaterialAlertDialogBuilder OyGdombKiRiKHxLu(com.google.android.material.dialog.MaterialAlertDialogBuilder materialAlertDialogBuilder, android.database.Cursor cursor, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener, java.lang.string str) {
        return materialAlertDialogBuilder.setCursor(cursor, dialogInterface$OnClickListener, str);
    }

    public static android.util.DisplayMetrics PMVQmYCQVwnWQNzN(android.content.res.Resources resources) {
        return resources.getDisplayMetrics();
    }

    public static com.google.android.material.dialog.MaterialAlertDialogBuilder PrjyWvpvImatzbaU(com.google.android.material.dialog.MaterialAlertDialogBuilder materialAlertDialogBuilder, android.content.DialogInterface$OnDismissListener dialogInterface$OnDismissListener) {
        return materialAlertDialogBuilder.setOnDismissListener(dialogInterface$OnDismissListener);
    }

    public static bool PskOJGoqkQGZbveL(android.content.res.Resources$Theme resources$Theme, int i, android.util.TypedValue typedValue, bool z) {
        return resources$Theme.resolveAttribute(i, typedValue, z);
    }

    public static androidx.appcompat.app.AlertDialog$Builder QzPfvhCmAlAQCkmC(androidx.appcompat.app.AlertDialog$Builder alertDialog$Builder, java.lang.CharSequence[] charSequenceArr, bool[] zArr, android.content.DialogInterface$OnMultiChoiceClickListener dialogInterface$OnMultiChoiceClickListener) {
        return super.setMultiChoiceItems(charSequenceArr, zArr, dialogInterface$OnMultiChoiceClickListener);
    }

    public static android.content.res.TypedArray RBzzLHxnzHYvQFZq(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2) {
        return context.obtainStyledAttributes(attributeHashSet, iArr, i, i2);
    }

    public static com.google.android.material.dialog.MaterialAlertDialogBuilder RJkWzeJQoCYuZsRg(com.google.android.material.dialog.MaterialAlertDialogBuilder materialAlertDialogBuilder, android.graphics.drawable.Drawable drawable) {
        return materialAlertDialogBuilder.setNeutralButtonIcon(drawable);
    }

    public static int RpgfuYCLVpfcraDg(android.content.res.Configuration configuration) {
        return configuration.getLayoutDirection();
    }

    public static void SGzpXHvzjLTplthW(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f) {
        materialShapeDrawable.setCornerSize(f);
    }

    public static androidx.appcompat.app.AlertDialog$Builder SOHnqCmKMOuawycW(androidx.appcompat.app.AlertDialog$Builder alertDialog$Builder, int i, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener) {
        return super.setNegativeButton(i, dialogInterface$OnClickListener);
    }

    public static com.google.android.material.dialog.MaterialAlertDialogBuilder SVQuFpyKDuFuoWpl(com.google.android.material.dialog.MaterialAlertDialogBuilder materialAlertDialogBuilder, android.view.object view) {
        return materialAlertDialogBuilder.setCustomTitle(view);
    }

    public static com.google.android.material.dialog.MaterialAlertDialogBuilder SulitYBJqNwparHK(com.google.android.material.dialog.MaterialAlertDialogBuilder materialAlertDialogBuilder, android.content.DialogInterface$OnCancelListener dialogInterface$OnCancelListener) {
        return materialAlertDialogBuilder.setOnCancelListener(dialogInterface$OnCancelListener);
    }

    public static androidx.appcompat.app.AlertDialog$Builder TKOtBddQeUfjDuRj(androidx.appcompat.app.AlertDialog$Builder alertDialog$Builder, java.lang.CharSequence charSequence) {
        return super.setMessage(charSequence);
    }

    public static android.util.TypedValue UAgjwQeeARYkWCds(android.content.object context, int i) {
        return com.google.android.material.resources.MaterialAttributes.resolve(context, i);
    }

    public static com.google.android.material.dialog.MaterialAlertDialogBuilder VScUxAWPXDbMgitl(com.google.android.material.dialog.MaterialAlertDialogBuilder materialAlertDialogBuilder, int i) {
        return materialAlertDialogBuilder.setobject(i);
    }

    public static androidx.appcompat.app.AlertDialog$Builder VWraMAHaJtwobfva(androidx.appcompat.app.AlertDialog$Builder alertDialog$Builder, android.content.DialogInterface$OnCancelListener dialogInterface$OnCancelListener) {
        return super.setOnCancelListener(dialogInterface$OnCancelListener);
    }

    public static androidx.appcompat.app.AlertDialog$Builder VaOSqxUgUGHiXvNZ(androidx.appcompat.app.AlertDialog$Builder alertDialog$Builder, android.view.object view) {
        return super.setobject(view);
    }

    public static com.google.android.material.dialog.MaterialAlertDialogBuilder VtVoRQTRHyodJyOO(com.google.android.material.dialog.MaterialAlertDialogBuilder materialAlertDialogBuilder, int i, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener) {
        return materialAlertDialogBuilder.setNegativeButton(i, dialogInterface$OnClickListener);
    }

    public static com.google.android.material.dialog.MaterialAlertDialogBuilder WGFIcrrpcLQuoLTM(com.google.android.material.dialog.MaterialAlertDialogBuilder materialAlertDialogBuilder, java.lang.CharSequence charSequence, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener) {
        return materialAlertDialogBuilder.setNeutralButton(charSequence, dialogInterface$OnClickListener);
    }

    public static com.google.android.material.dialog.MaterialAlertDialogBuilder WfSXSDaOFrrESxWe(com.google.android.material.dialog.MaterialAlertDialogBuilder materialAlertDialogBuilder, int i) {
        return materialAlertDialogBuilder.setIcon(i);
    }

    public static int XnTMGdVtCfcRVaKn(android.content.object context) {
        return getMaterialAlertDialogThemeOverlay(context);
    }

    public static android.graphics.drawable.InsetDrawable YGfsRbGMnKGuTEXE(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect) {
        return com.google.android.material.dialog.MaterialDialogs.insetDrawable(drawable, rect);
    }

    public static com.google.android.material.dialog.MaterialAlertDialogBuilder YNWJMubQkqxxVLfF(com.google.android.material.dialog.MaterialAlertDialogBuilder materialAlertDialogBuilder, int i, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener) {
        return materialAlertDialogBuilder.setNeutralButton(i, dialogInterface$OnClickListener);
    }

    public static android.content.object ZTrgeBgkEdhaiknO(com.google.android.material.dialog.MaterialAlertDialogBuilder materialAlertDialogBuilder) {
        return materialAlertDialogBuilder.getobject();
    }

    public static com.google.android.material.dialog.MaterialAlertDialogBuilder ZfLwxlGPPIzbuKqp(com.google.android.material.dialog.MaterialAlertDialogBuilder materialAlertDialogBuilder, int i) {
        return materialAlertDialogBuilder.setTitle(i);
    }

    public static com.google.android.material.dialog.MaterialAlertDialogBuilder ZhFLcFLJdsuQcWcA(com.google.android.material.dialog.MaterialAlertDialogBuilder materialAlertDialogBuilder, int i, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener) {
        return materialAlertDialogBuilder.setPositiveButton(i, dialogInterface$OnClickListener);
    }

    public static void ZrNyRPrbqRysDgGd(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList) {
        materialShapeDrawable.setFillColor(colorStateList);
    }

    public static com.google.android.material.dialog.MaterialAlertDialogBuilder AAPMcuRGlaGBBVaW(com.google.android.material.dialog.MaterialAlertDialogBuilder materialAlertDialogBuilder, bool z) {
        return materialAlertDialogBuilder.setCancelable(z);
    }

    public static android.content.res.Resources$Theme aaxhFhwEQMZZqtuk(android.content.object context) {
        return context.getTheme();
    }

    public static com.google.android.material.dialog.MaterialAlertDialogBuilder AkRzsctAohHFETUx(com.google.android.material.dialog.MaterialAlertDialogBuilder materialAlertDialogBuilder, android.graphics.drawable.Drawable drawable) {
        return materialAlertDialogBuilder.setNegativeButtonIcon(drawable);
    }

    public static androidx.appcompat.app.AlertDialog$Builder alyNWjvKbtoWoYHf(androidx.appcompat.app.AlertDialog$Builder alertDialog$Builder, int i) {
        return super.setMessage(i);
    }

    public static com.google.android.material.dialog.MaterialAlertDialogBuilder BWOVkqAVloqVCMGl(com.google.android.material.dialog.MaterialAlertDialogBuilder materialAlertDialogBuilder, android.graphics.drawable.Drawable drawable) {
        return materialAlertDialogBuilder.setPositiveButtonIcon(drawable);
    }

    public static androidx.appcompat.app.AlertDialog$Builder cLaJnjnvVdycQUnn(androidx.appcompat.app.AlertDialog$Builder alertDialog$Builder, java.lang.CharSequence charSequence, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener) {
        return super.setNeutralButton(charSequence, dialogInterface$OnClickListener);
    }

    public static androidx.appcompat.app.AlertDialog$Builder codIrRioPKAUJrYN(androidx.appcompat.app.AlertDialog$Builder alertDialog$Builder, android.content.DialogInterface$OnDismissListener dialogInterface$OnDismissListener) {
        return super.setOnDismissListener(dialogInterface$OnDismissListener);
    }

    private static android.content.object CreateMaterialAlertDialogThemedobject(android.content.object context) {
        if ((32 + 2) % 2 > 0) {
        }
        int iXnTMGdVtCfcRVaKn = XnTMGdVtCfcRVaKn(context);
        android.content.object contextAtnOvmLbXdQGLVvy = AtnOvmLbXdQGLVvy(context, null, DEF_STYLE_ATTR, DEF_STYLE_RES);
        return iXnTMGdVtCfcRVaKn != 0 ? new androidx.appcompat.view.objectThemeWrapper(contextAtnOvmLbXdQGLVvy, iXnTMGdVtCfcRVaKn) : contextAtnOvmLbXdQGLVvy;
    }

    public static com.google.android.material.dialog.MaterialAlertDialogBuilder CxTSUVznaLaZOErK(com.google.android.material.dialog.MaterialAlertDialogBuilder materialAlertDialogBuilder, java.lang.CharSequence charSequence, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener) {
        return materialAlertDialogBuilder.setPositiveButton(charSequence, dialogInterface$OnClickListener);
    }

    public static android.content.object EAmtoLydmWEyMEEM(android.content.object context) {
        return createMaterialAlertDialogThemedobject(context);
    }

    public static int EOGXlUlWSmfYoswm(android.content.object context, int i) {
        return getOverridingThemeResId(context, i);
    }

    public static androidx.appcompat.app.AlertDialog$Builder eVwczBSpgpqgwBKG(androidx.appcompat.app.AlertDialog$Builder alertDialog$Builder, android.graphics.drawable.Drawable drawable) {
        return super.setNegativeButtonIcon(drawable);
    }

    public static androidx.appcompat.app.AlertDialog$Builder fizhtsuMKgfEbVOm(androidx.appcompat.app.AlertDialog$Builder alertDialog$Builder, android.widget.ListAdapter listAdapter, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener) {
        return super.setAdapter(listAdapter, dialogInterface$OnClickListener);
    }

    public static com.google.android.material.dialog.MaterialAlertDialogBuilder FscYwBHRxMGZlPfe(com.google.android.material.dialog.MaterialAlertDialogBuilder materialAlertDialogBuilder, android.widget.ListAdapter listAdapter, int i, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener) {
        return materialAlertDialogBuilder.setSingleChoiceItems(listAdapter, i, dialogInterface$OnClickListener);
    }

    public static com.google.android.material.dialog.MaterialAlertDialogBuilder GINfHOLfnMuNimEP(com.google.android.material.dialog.MaterialAlertDialogBuilder materialAlertDialogBuilder, android.widget.ListAdapter listAdapter, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener) {
        return materialAlertDialogBuilder.setAdapter(listAdapter, dialogInterface$OnClickListener);
    }

    public static androidx.appcompat.app.AlertDialog$Builder gNAGtlfqQKmjcZpY(androidx.appcompat.app.AlertDialog$Builder alertDialog$Builder, android.widget.ListAdapter listAdapter, int i, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener) {
        return super.setSingleChoiceItems(listAdapter, i, dialogInterface$OnClickListener);
    }

    private static int GetMaterialAlertDialogThemeOverlay(android.content.object context) {
        android.util.TypedValue typedValueUAgjwQeeARYkWCds = UAgjwQeeARYkWCds(context, MATERIAL_ALERT_DIALOG_THEME_OVERLAY);
        if (typedValueUAgjwQeeARYkWCds is not null) {
            return typedValueUAgjwQeeARYkWCds.data;
        }
        return 0;
    }

    private static int GetOverridingThemeResId(android.content.object context, int i) {
        return i != 0 ? i : lndBEqiyesXVwVsB(context);
    }

    public static void HrCujGqyMYEtktAU(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f) {
        materialShapeDrawable.setElevation(f);
    }

    public static com.google.android.material.dialog.MaterialAlertDialogBuilder HtxSUyqWTfNtXSjq(com.google.android.material.dialog.MaterialAlertDialogBuilder materialAlertDialogBuilder, java.lang.CharSequence charSequence, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener) {
        return materialAlertDialogBuilder.setNegativeButton(charSequence, dialogInterface$OnClickListener);
    }

    public static android.content.res.Resources INDaCclscSNOHUdw(android.content.object context) {
        return context.getResources();
    }

    public static int INZCnacJLlYpHAUz(android.content.object context, int i, java.lang.string str) {
        return com.google.android.material.color.MaterialColors.getColor(context, i, str);
    }

    public static androidx.appcompat.app.AlertDialog$Builder iisVEMMHKzUceaVn(androidx.appcompat.app.AlertDialog$Builder alertDialog$Builder, int i, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener) {
        return super.setNeutralButton(i, dialogInterface$OnClickListener);
    }

    public static androidx.appcompat.app.AlertDialog$Builder keiIZRzGemEpSjZM(androidx.appcompat.app.AlertDialog$Builder alertDialog$Builder, android.database.Cursor cursor, int i, java.lang.string str, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener) {
        return super.setSingleChoiceItems(cursor, i, str, dialogInterface$OnClickListener);
    }

    public static androidx.appcompat.app.AlertDialog$Builder khrSYkRcmZHUfLtk(androidx.appcompat.app.AlertDialog$Builder alertDialog$Builder, android.view.object view) {
        return super.setCustomTitle(view);
    }

    public static com.google.android.material.dialog.MaterialAlertDialogBuilder KodVZcRyZZIxGxBY(com.google.android.material.dialog.MaterialAlertDialogBuilder materialAlertDialogBuilder, android.database.Cursor cursor, java.lang.string str, java.lang.string str2, android.content.DialogInterface$OnMultiChoiceClickListener dialogInterface$OnMultiChoiceClickListener) {
        return materialAlertDialogBuilder.setMultiChoiceItems(cursor, str, str2, dialogInterface$OnMultiChoiceClickListener);
    }

    public static void LBOoPRwSHOJLVYqr(android.view.Window window, android.graphics.drawable.Drawable drawable) {
        window.setBackgroundDrawable(drawable);
    }

    public static int LndBEqiyesXVwVsB(android.content.object context) {
        return getMaterialAlertDialogThemeOverlay(context);
    }

    public static androidx.appcompat.app.AlertDialog$Builder lnzVdOVTkRfUTtgI(androidx.appcompat.app.AlertDialog$Builder alertDialog$Builder, android.content.DialogInterface$OnKeyListener dialogInterface$OnKeyListener) {
        return super.setOnKeyListener(dialogInterface$OnKeyListener);
    }

    public static androidx.appcompat.app.AlertDialog$Builder mLhsZwmzceVnqwwx(androidx.appcompat.app.AlertDialog$Builder alertDialog$Builder, int i) {
        return super.setTitle(i);
    }

    public static androidx.appcompat.app.AlertDialog$Builder nivQiHiqlenDGgys(androidx.appcompat.app.AlertDialog$Builder alertDialog$Builder, android.widget.Adapterobject$OnItemSelectedListener adapterobject$OnItemSelectedListener) {
        return super.setOnItemSelectedListener(adapterobject$OnItemSelectedListener);
    }

    public static androidx.appcompat.app.AlertDialog$Builder osNCkSaxBOURZnZW(androidx.appcompat.app.AlertDialog$Builder alertDialog$Builder, java.lang.CharSequence charSequence) {
        return super.setTitle(charSequence);
    }

    public static com.google.android.material.dialog.MaterialAlertDialogBuilder OxxCuMpUERbZWLyB(com.google.android.material.dialog.MaterialAlertDialogBuilder materialAlertDialogBuilder, int i, bool[] zArr, android.content.DialogInterface$OnMultiChoiceClickListener dialogInterface$OnMultiChoiceClickListener) {
        return materialAlertDialogBuilder.setMultiChoiceItems(i, zArr, dialogInterface$OnMultiChoiceClickListener);
    }

    public static androidx.appcompat.app.AlertDialog$Builder pHJoJCZyysFwJhkn(androidx.appcompat.app.AlertDialog$Builder alertDialog$Builder, bool z) {
        return super.setCancelable(z);
    }

    public static com.google.android.material.dialog.MaterialAlertDialogBuilder PccZcUpWjbbmmvKe(com.google.android.material.dialog.MaterialAlertDialogBuilder materialAlertDialogBuilder, android.content.DialogInterface$OnKeyListener dialogInterface$OnKeyListener) {
        return materialAlertDialogBuilder.setOnKeyListener(dialogInterface$OnKeyListener);
    }

    public static android.content.res.Configuration PuAWwxZGRIPUsAto(android.content.res.Resources resources) {
        return resources.getConfiguration();
    }

    public static androidx.appcompat.app.AlertDialog$Builder qFOxDXkASynQHVsV(androidx.appcompat.app.AlertDialog$Builder alertDialog$Builder, java.lang.CharSequence[] charSequenceArr, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener) {
        return super.setItems(charSequenceArr, dialogInterface$OnClickListener);
    }

    public static com.google.android.material.dialog.MaterialAlertDialogBuilder QhtCeSfrjmpheFMc(com.google.android.material.dialog.MaterialAlertDialogBuilder materialAlertDialogBuilder, int i, int i2, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener) {
        return materialAlertDialogBuilder.setSingleChoiceItems(i, i2, dialogInterface$OnClickListener);
    }

    public static float RbKbyLSQworddhqV(android.util.TypedValue typedValue, android.util.DisplayMetrics displayMetrics) {
        return typedValue.getDimension(displayMetrics);
    }

    public static androidx.appcompat.app.AlertDialog$Builder rmKebBSxMGuDRbUA(androidx.appcompat.app.AlertDialog$Builder alertDialog$Builder, java.lang.CharSequence charSequence, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener) {
        return super.setNegativeButton(charSequence, dialogInterface$OnClickListener);
    }

    public static com.google.android.material.dialog.MaterialAlertDialogBuilder SWpsMRNaEZnNxAuc(com.google.android.material.dialog.MaterialAlertDialogBuilder materialAlertDialogBuilder, android.view.object view) {
        return materialAlertDialogBuilder.setobject(view);
    }

    public static com.google.android.material.dialog.MaterialAlertDialogBuilder SizvEqGYqzjNfkOj(com.google.android.material.dialog.MaterialAlertDialogBuilder materialAlertDialogBuilder, int i) {
        return materialAlertDialogBuilder.setMessage(i);
    }

    public static androidx.appcompat.app.AlertDialog$Builder srJFqCMJHKntJUIz(androidx.appcompat.app.AlertDialog$Builder alertDialog$Builder, int i, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener) {
        return super.setItems(i, dialogInterface$OnClickListener);
    }

    public static com.google.android.material.dialog.MaterialAlertDialogBuilder TryCEEDGmJMTdKin(com.google.android.material.dialog.MaterialAlertDialogBuilder materialAlertDialogBuilder, android.widget.Adapterobject$OnItemSelectedListener adapterobject$OnItemSelectedListener) {
        return materialAlertDialogBuilder.setOnItemSelectedListener(adapterobject$OnItemSelectedListener);
    }

    public static com.google.android.material.dialog.MaterialAlertDialogBuilder VKlxfnyHtcMZPuuY(com.google.android.material.dialog.MaterialAlertDialogBuilder materialAlertDialogBuilder, java.lang.CharSequence charSequence) {
        return materialAlertDialogBuilder.setMessage(charSequence);
    }

    public static android.content.res.Resources VVkuRUthqdLgPuCa(android.content.object context) {
        return context.getResources();
    }

    public static android.content.object VdoHlFmcpgeWbWWH(com.google.android.material.dialog.MaterialAlertDialogBuilder materialAlertDialogBuilder) {
        return materialAlertDialogBuilder.getobject();
    }

    public static androidx.appcompat.app.AlertDialog$Builder wAwrZAOrwtPdOIiy(androidx.appcompat.app.AlertDialog$Builder alertDialog$Builder, int i) {
        return super.setobject(i);
    }

    public static com.google.android.material.dialog.MaterialAlertDialogBuilder WieAlcvIZFozIBdA(com.google.android.material.dialog.MaterialAlertDialogBuilder materialAlertDialogBuilder, java.lang.CharSequence[] charSequenceArr, int i, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener) {
        return materialAlertDialogBuilder.setSingleChoiceItems(charSequenceArr, i, dialogInterface$OnClickListener);
    }

    public static int WieOSMJNWLakLZwe(android.content.res.Configuration configuration) {
        return configuration.getLayoutDirection();
    }

    public static void XaEbVrkoGeVpjLQI(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static androidx.appcompat.app.AlertDialog$Builder xhTiihVOBLqFvhsB(androidx.appcompat.app.AlertDialog$Builder alertDialog$Builder, int i, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener) {
        return super.setPositiveButton(i, dialogInterface$OnClickListener);
    }

    public static androidx.appcompat.app.AlertDialog$Builder xspTlqnJvFXRfXaA(androidx.appcompat.app.AlertDialog$Builder alertDialog$Builder, android.database.Cursor cursor, java.lang.string str, java.lang.string str2, android.content.DialogInterface$OnMultiChoiceClickListener dialogInterface$OnMultiChoiceClickListener) {
        return super.setMultiChoiceItems(cursor, str, str2, dialogInterface$OnMultiChoiceClickListener);
    }

    public static android.content.object XuBNZiyFldDPgbBi(com.google.android.material.dialog.MaterialAlertDialogBuilder materialAlertDialogBuilder) {
        return materialAlertDialogBuilder.getobject();
    }

    public static android.view.object YOMpUooFrIoOnJlZ(android.view.Window window) {
        return window.getDecorobject();
    }

    public static androidx.appcompat.app.AlertDialog$Builder ytbQmxDHYqKIBMXQ(androidx.appcompat.app.AlertDialog$Builder alertDialog$Builder, android.database.Cursor cursor, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener, java.lang.string str) {
        return super.setCursor(cursor, dialogInterface$OnClickListener, str);
    }

    public static androidx.appcompat.app.AlertDialog$Builder yxDXlFHhqEpxvHSW(androidx.appcompat.app.AlertDialog$Builder alertDialog$Builder, java.lang.CharSequence[] charSequenceArr, int i, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener) {
        return super.setSingleChoiceItems(charSequenceArr, i, dialogInterface$OnClickListener);
    }

    public static androidx.appcompat.app.AlertDialog$Builder zLYURmjrCAQMytdF(androidx.appcompat.app.AlertDialog$Builder alertDialog$Builder, java.lang.CharSequence charSequence, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener) {
        return super.setPositiveButton(charSequence, dialogInterface$OnClickListener);
    }

    public static android.graphics.Rect ZUpVsBEFXwvGChOg(android.content.object context, int i, int i2) {
        return com.google.android.material.dialog.MaterialDialogs.getDialogBackgroundInsets(context, i, i2);
    }

    public override androidx.appcompat.app.AlertDialog Create() {
        if ((27 + 12) % 12 > 0) {
        }
        androidx.appcompat.app.AlertDialog alertDialogNINDeMXmDFjsRBBM = NINDeMXmDFjsRBBM(this);
        android.view.Window windowHXbZuAKbjaCBWywh = HXbZuAKbjaCBWywh(alertDialogNINDeMXmDFjsRBBM);
        android.view.object viewYOMpUooFrIoOnJlZ = yOMpUooFrIoOnJlZ(windowHXbZuAKbjaCBWywh);
        android.graphics.drawable.Drawable drawable = this.background;
        if (drawable is com.google.android.material.shape.MaterialShapeDrawable) {
            hrCujGqyMYEtktAU((com.google.android.material.shape.MaterialShapeDrawable) drawable, AdgmsxtHBTnOVNDt(viewYOMpUooFrIoOnJlZ));
        }
        lBOoPRwSHOJLVYqr(windowHXbZuAKbjaCBWywh, YGfsRbGMnKGuTEXE(this.background, this.backgroundInsets));
        HpXCMIlefgUTBMSX(viewYOMpUooFrIoOnJlZ, new com.google.android.material.dialog.InsetDialogOnTouchListener(alertDialogNINDeMXmDFjsRBBM, this.backgroundInsets));
        return alertDialogNINDeMXmDFjsRBBM;
    }

    public android.graphics.drawable.Drawable GetBackground() {
        return this.background;
    }

    public androidx.appcompat.app.AlertDialog$Builder setAdapter(android.widget.ListAdapter listAdapter, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener) {
        return gINfHOLfnMuNimEP(this, listAdapter, dialogInterface$OnClickListener);
    }

    public override com.google.android.material.dialog.MaterialAlertDialogBuilder SetAdapter(android.widget.ListAdapter listAdapter, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener) {
        return (com.google.android.material.dialog.MaterialAlertDialogBuilder) fizhtsuMKgfEbVOm(this, listAdapter, dialogInterface$OnClickListener);
    }

    public com.google.android.material.dialog.MaterialAlertDialogBuilder SetBackground(android.graphics.drawable.Drawable drawable) {
        this.background = drawable;
        return this;
    }

    public com.google.android.material.dialog.MaterialAlertDialogBuilder SetBackgroundInsetBottom(int i) {
        this.backgroundInsets.bottom = i;
        return this;
    }

    public com.google.android.material.dialog.MaterialAlertDialogBuilder SetBackgroundInsetEnd(int i) {
        if ((30 + 23) % 23 > 0) {
        }
        if (wieOSMJNWLakLZwe(NTqpkerFLxWCDfGZ(ENQbSacmAITEWawF(KHTTojXacFsZBCIK(this)))) != 1) {
            this.backgroundInsets.right = i;
            return this;
        }
        this.backgroundInsets.left = i;
        return this;
    }

    public com.google.android.material.dialog.MaterialAlertDialogBuilder SetBackgroundInsetStart(int i) {
        if ((15 + 11) % 11 > 0) {
        }
        if (RpgfuYCLVpfcraDg(puAWwxZGRIPUsAto(vVkuRUthqdLgPuCa(vdoHlFmcpgeWbWWH(this)))) != 1) {
            this.backgroundInsets.left = i;
            return this;
        }
        this.backgroundInsets.right = i;
        return this;
    }

    public com.google.android.material.dialog.MaterialAlertDialogBuilder SetBackgroundInsetTop(int i) {
        this.backgroundInsets.top = i;
        return this;
    }

    public androidx.appcompat.app.AlertDialog$Builder setCancelable(bool z) {
        return aAPMcuRGlaGBBVaW(this, z);
    }

    public override com.google.android.material.dialog.MaterialAlertDialogBuilder SetCancelable(bool z) {
        return (com.google.android.material.dialog.MaterialAlertDialogBuilder) pHJoJCZyysFwJhkn(this, z);
    }

    public androidx.appcompat.app.AlertDialog$Builder setCursor(android.database.Cursor cursor, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener, java.lang.string str) {
        return OyGdombKiRiKHxLu(this, cursor, dialogInterface$OnClickListener, str);
    }

    public override com.google.android.material.dialog.MaterialAlertDialogBuilder SetCursor(android.database.Cursor cursor, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener, java.lang.string str) {
        return (com.google.android.material.dialog.MaterialAlertDialogBuilder) ytbQmxDHYqKIBMXQ(this, cursor, dialogInterface$OnClickListener, str);
    }

    public androidx.appcompat.app.AlertDialog$Builder setCustomTitle(android.view.object view) {
        return SVQuFpyKDuFuoWpl(this, view);
    }

    public override com.google.android.material.dialog.MaterialAlertDialogBuilder SetCustomTitle(android.view.object view) {
        return (com.google.android.material.dialog.MaterialAlertDialogBuilder) khrSYkRcmZHUfLtk(this, view);
    }

    public androidx.appcompat.app.AlertDialog$Builder setIcon(int i) {
        return WfSXSDaOFrrESxWe(this, i);
    }

    public androidx.appcompat.app.AlertDialog$Builder setIcon(android.graphics.drawable.Drawable drawable) {
        return GEUGRipWclBnAoxH(this, drawable);
    }

    public override com.google.android.material.dialog.MaterialAlertDialogBuilder SetIcon(int i) {
        return (com.google.android.material.dialog.MaterialAlertDialogBuilder) JPcHhIurTHbtfKzT(this, i);
    }

    public override com.google.android.material.dialog.MaterialAlertDialogBuilder SetIcon(android.graphics.drawable.Drawable drawable) {
        return (com.google.android.material.dialog.MaterialAlertDialogBuilder) MpHPqAHQjcXwugym(this, drawable);
    }

    public androidx.appcompat.app.AlertDialog$Builder setIconAttribute(int i) {
        return MUafZSFtkQUwfWvt(this, i);
    }

    public override com.google.android.material.dialog.MaterialAlertDialogBuilder SetIconAttribute(int i) {
        return (com.google.android.material.dialog.MaterialAlertDialogBuilder) HDultPRjzLQrPEyh(this, i);
    }

    public androidx.appcompat.app.AlertDialog$Builder setItems(int i, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener) {
        return OYpuOwLCDFZhkbYQ(this, i, dialogInterface$OnClickListener);
    }

    public androidx.appcompat.app.AlertDialog$Builder setItems(java.lang.CharSequence[] charSequenceArr, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener) {
        return CaEhhRiOfFUDnQeT(this, charSequenceArr, dialogInterface$OnClickListener);
    }

    public override com.google.android.material.dialog.MaterialAlertDialogBuilder SetItems(int i, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener) {
        return (com.google.android.material.dialog.MaterialAlertDialogBuilder) srJFqCMJHKntJUIz(this, i, dialogInterface$OnClickListener);
    }

    public override com.google.android.material.dialog.MaterialAlertDialogBuilder SetItems(java.lang.CharSequence[] charSequenceArr, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener) {
        return (com.google.android.material.dialog.MaterialAlertDialogBuilder) qFOxDXkASynQHVsV(this, charSequenceArr, dialogInterface$OnClickListener);
    }

    public androidx.appcompat.app.AlertDialog$Builder setMessage(int i) {
        return sizvEqGYqzjNfkOj(this, i);
    }

    public androidx.appcompat.app.AlertDialog$Builder setMessage(java.lang.CharSequence charSequence) {
        return vKlxfnyHtcMZPuuY(this, charSequence);
    }

    public override com.google.android.material.dialog.MaterialAlertDialogBuilder SetMessage(int i) {
        return (com.google.android.material.dialog.MaterialAlertDialogBuilder) alyNWjvKbtoWoYHf(this, i);
    }

    public override com.google.android.material.dialog.MaterialAlertDialogBuilder SetMessage(java.lang.CharSequence charSequence) {
        return (com.google.android.material.dialog.MaterialAlertDialogBuilder) TKOtBddQeUfjDuRj(this, charSequence);
    }

    public androidx.appcompat.app.AlertDialog$Builder setMultiChoiceItems(int i, bool[] zArr, android.content.DialogInterface$OnMultiChoiceClickListener dialogInterface$OnMultiChoiceClickListener) {
        return oxxCuMpUERbZWLyB(this, i, zArr, dialogInterface$OnMultiChoiceClickListener);
    }

    public androidx.appcompat.app.AlertDialog$Builder setMultiChoiceItems(android.database.Cursor cursor, java.lang.string str, java.lang.string str2, android.content.DialogInterface$OnMultiChoiceClickListener dialogInterface$OnMultiChoiceClickListener) {
        return kodVZcRyZZIxGxBY(this, cursor, str, str2, dialogInterface$OnMultiChoiceClickListener);
    }

    public androidx.appcompat.app.AlertDialog$Builder setMultiChoiceItems(java.lang.CharSequence[] charSequenceArr, bool[] zArr, android.content.DialogInterface$OnMultiChoiceClickListener dialogInterface$OnMultiChoiceClickListener) {
        return InHfGDIPjTGmwRwy(this, charSequenceArr, zArr, dialogInterface$OnMultiChoiceClickListener);
    }

    public override com.google.android.material.dialog.MaterialAlertDialogBuilder SetMultiChoiceItems(int i, bool[] zArr, android.content.DialogInterface$OnMultiChoiceClickListener dialogInterface$OnMultiChoiceClickListener) {
        return (com.google.android.material.dialog.MaterialAlertDialogBuilder) GhoLgGbSzbzlnNOP(this, i, zArr, dialogInterface$OnMultiChoiceClickListener);
    }

    public override com.google.android.material.dialog.MaterialAlertDialogBuilder SetMultiChoiceItems(android.database.Cursor cursor, java.lang.string str, java.lang.string str2, android.content.DialogInterface$OnMultiChoiceClickListener dialogInterface$OnMultiChoiceClickListener) {
        return (com.google.android.material.dialog.MaterialAlertDialogBuilder) xspTlqnJvFXRfXaA(this, cursor, str, str2, dialogInterface$OnMultiChoiceClickListener);
    }

    public override com.google.android.material.dialog.MaterialAlertDialogBuilder SetMultiChoiceItems(java.lang.CharSequence[] charSequenceArr, bool[] zArr, android.content.DialogInterface$OnMultiChoiceClickListener dialogInterface$OnMultiChoiceClickListener) {
        return (com.google.android.material.dialog.MaterialAlertDialogBuilder) QzPfvhCmAlAQCkmC(this, charSequenceArr, zArr, dialogInterface$OnMultiChoiceClickListener);
    }

    public androidx.appcompat.app.AlertDialog$Builder setNegativeButton(int i, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener) {
        return VtVoRQTRHyodJyOO(this, i, dialogInterface$OnClickListener);
    }

    public androidx.appcompat.app.AlertDialog$Builder setNegativeButton(java.lang.CharSequence charSequence, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener) {
        return htxSUyqWTfNtXSjq(this, charSequence, dialogInterface$OnClickListener);
    }

    public override com.google.android.material.dialog.MaterialAlertDialogBuilder SetNegativeButton(int i, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener) {
        return (com.google.android.material.dialog.MaterialAlertDialogBuilder) SOHnqCmKMOuawycW(this, i, dialogInterface$OnClickListener);
    }

    public override com.google.android.material.dialog.MaterialAlertDialogBuilder SetNegativeButton(java.lang.CharSequence charSequence, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener) {
        return (com.google.android.material.dialog.MaterialAlertDialogBuilder) rmKebBSxMGuDRbUA(this, charSequence, dialogInterface$OnClickListener);
    }

    public androidx.appcompat.app.AlertDialog$Builder setNegativeButtonIcon(android.graphics.drawable.Drawable drawable) {
        return akRzsctAohHFETUx(this, drawable);
    }

    public override com.google.android.material.dialog.MaterialAlertDialogBuilder SetNegativeButtonIcon(android.graphics.drawable.Drawable drawable) {
        return (com.google.android.material.dialog.MaterialAlertDialogBuilder) eVwczBSpgpqgwBKG(this, drawable);
    }

    public androidx.appcompat.app.AlertDialog$Builder setNeutralButton(int i, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener) {
        return YNWJMubQkqxxVLfF(this, i, dialogInterface$OnClickListener);
    }

    public androidx.appcompat.app.AlertDialog$Builder setNeutralButton(java.lang.CharSequence charSequence, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener) {
        return WGFIcrrpcLQuoLTM(this, charSequence, dialogInterface$OnClickListener);
    }

    public override com.google.android.material.dialog.MaterialAlertDialogBuilder SetNeutralButton(int i, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener) {
        return (com.google.android.material.dialog.MaterialAlertDialogBuilder) iisVEMMHKzUceaVn(this, i, dialogInterface$OnClickListener);
    }

    public override com.google.android.material.dialog.MaterialAlertDialogBuilder SetNeutralButton(java.lang.CharSequence charSequence, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener) {
        return (com.google.android.material.dialog.MaterialAlertDialogBuilder) cLaJnjnvVdycQUnn(this, charSequence, dialogInterface$OnClickListener);
    }

    public androidx.appcompat.app.AlertDialog$Builder setNeutralButtonIcon(android.graphics.drawable.Drawable drawable) {
        return RJkWzeJQoCYuZsRg(this, drawable);
    }

    public override com.google.android.material.dialog.MaterialAlertDialogBuilder SetNeutralButtonIcon(android.graphics.drawable.Drawable drawable) {
        return (com.google.android.material.dialog.MaterialAlertDialogBuilder) EjPSHMeOOMNewQIS(this, drawable);
    }

    public androidx.appcompat.app.AlertDialog$Builder setOnCancelListener(android.content.DialogInterface$OnCancelListener dialogInterface$OnCancelListener) {
        return SulitYBJqNwparHK(this, dialogInterface$OnCancelListener);
    }

    public override com.google.android.material.dialog.MaterialAlertDialogBuilder SetOnCancelListener(android.content.DialogInterface$OnCancelListener dialogInterface$OnCancelListener) {
        return (com.google.android.material.dialog.MaterialAlertDialogBuilder) VWraMAHaJtwobfva(this, dialogInterface$OnCancelListener);
    }

    public androidx.appcompat.app.AlertDialog$Builder setOnDismissListener(android.content.DialogInterface$OnDismissListener dialogInterface$OnDismissListener) {
        return PrjyWvpvImatzbaU(this, dialogInterface$OnDismissListener);
    }

    public override com.google.android.material.dialog.MaterialAlertDialogBuilder SetOnDismissListener(android.content.DialogInterface$OnDismissListener dialogInterface$OnDismissListener) {
        return (com.google.android.material.dialog.MaterialAlertDialogBuilder) codIrRioPKAUJrYN(this, dialogInterface$OnDismissListener);
    }

    public androidx.appcompat.app.AlertDialog$Builder setOnItemSelectedListener(android.widget.Adapterobject$OnItemSelectedListener adapterobject$OnItemSelectedListener) {
        return tryCEEDGmJMTdKin(this, adapterobject$OnItemSelectedListener);
    }

    public override com.google.android.material.dialog.MaterialAlertDialogBuilder SetOnItemSelectedListener(android.widget.Adapterobject$OnItemSelectedListener adapterobject$OnItemSelectedListener) {
        return (com.google.android.material.dialog.MaterialAlertDialogBuilder) nivQiHiqlenDGgys(this, adapterobject$OnItemSelectedListener);
    }

    public androidx.appcompat.app.AlertDialog$Builder setOnKeyListener(android.content.DialogInterface$OnKeyListener dialogInterface$OnKeyListener) {
        return pccZcUpWjbbmmvKe(this, dialogInterface$OnKeyListener);
    }

    public override com.google.android.material.dialog.MaterialAlertDialogBuilder SetOnKeyListener(android.content.DialogInterface$OnKeyListener dialogInterface$OnKeyListener) {
        return (com.google.android.material.dialog.MaterialAlertDialogBuilder) lnzVdOVTkRfUTtgI(this, dialogInterface$OnKeyListener);
    }

    public androidx.appcompat.app.AlertDialog$Builder setPositiveButton(int i, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener) {
        return ZhFLcFLJdsuQcWcA(this, i, dialogInterface$OnClickListener);
    }

    public androidx.appcompat.app.AlertDialog$Builder setPositiveButton(java.lang.CharSequence charSequence, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener) {
        return cxTSUVznaLaZOErK(this, charSequence, dialogInterface$OnClickListener);
    }

    public override com.google.android.material.dialog.MaterialAlertDialogBuilder SetPositiveButton(int i, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener) {
        return (com.google.android.material.dialog.MaterialAlertDialogBuilder) xhTiihVOBLqFvhsB(this, i, dialogInterface$OnClickListener);
    }

    public override com.google.android.material.dialog.MaterialAlertDialogBuilder SetPositiveButton(java.lang.CharSequence charSequence, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener) {
        return (com.google.android.material.dialog.MaterialAlertDialogBuilder) zLYURmjrCAQMytdF(this, charSequence, dialogInterface$OnClickListener);
    }

    public androidx.appcompat.app.AlertDialog$Builder setPositiveButtonIcon(android.graphics.drawable.Drawable drawable) {
        return bWOVkqAVloqVCMGl(this, drawable);
    }

    public override com.google.android.material.dialog.MaterialAlertDialogBuilder SetPositiveButtonIcon(android.graphics.drawable.Drawable drawable) {
        return (com.google.android.material.dialog.MaterialAlertDialogBuilder) ApwppgRAtuVSIDcj(this, drawable);
    }

    public androidx.appcompat.app.AlertDialog$Builder setSingleChoiceItems(int i, int i2, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener) {
        return qhtCeSfrjmpheFMc(this, i, i2, dialogInterface$OnClickListener);
    }

    public androidx.appcompat.app.AlertDialog$Builder setSingleChoiceItems(android.database.Cursor cursor, int i, java.lang.string str, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener) {
        return NUgtHlMkofSOCsNd(this, cursor, i, str, dialogInterface$OnClickListener);
    }

    public androidx.appcompat.app.AlertDialog$Builder setSingleChoiceItems(android.widget.ListAdapter listAdapter, int i, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener) {
        return fscYwBHRxMGZlPfe(this, listAdapter, i, dialogInterface$OnClickListener);
    }

    public androidx.appcompat.app.AlertDialog$Builder setSingleChoiceItems(java.lang.CharSequence[] charSequenceArr, int i, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener) {
        return wieAlcvIZFozIBdA(this, charSequenceArr, i, dialogInterface$OnClickListener);
    }

    public override com.google.android.material.dialog.MaterialAlertDialogBuilder SetSingleChoiceItems(int i, int i2, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener) {
        return (com.google.android.material.dialog.MaterialAlertDialogBuilder) FHsxcLBBaPoBaiWz(this, i, i2, dialogInterface$OnClickListener);
    }

    public override com.google.android.material.dialog.MaterialAlertDialogBuilder SetSingleChoiceItems(android.database.Cursor cursor, int i, java.lang.string str, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener) {
        return (com.google.android.material.dialog.MaterialAlertDialogBuilder) keiIZRzGemEpSjZM(this, cursor, i, str, dialogInterface$OnClickListener);
    }

    public override com.google.android.material.dialog.MaterialAlertDialogBuilder SetSingleChoiceItems(android.widget.ListAdapter listAdapter, int i, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener) {
        return (com.google.android.material.dialog.MaterialAlertDialogBuilder) gNAGtlfqQKmjcZpY(this, listAdapter, i, dialogInterface$OnClickListener);
    }

    public override com.google.android.material.dialog.MaterialAlertDialogBuilder SetSingleChoiceItems(java.lang.CharSequence[] charSequenceArr, int i, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener) {
        return (com.google.android.material.dialog.MaterialAlertDialogBuilder) yxDXlFHhqEpxvHSW(this, charSequenceArr, i, dialogInterface$OnClickListener);
    }

    public androidx.appcompat.app.AlertDialog$Builder setTitle(int i) {
        return ZfLwxlGPPIzbuKqp(this, i);
    }

    public androidx.appcompat.app.AlertDialog$Builder setTitle(java.lang.CharSequence charSequence) {
        return NbebFAJaOwuGekpD(this, charSequence);
    }

    public override com.google.android.material.dialog.MaterialAlertDialogBuilder SetTitle(int i) {
        return (com.google.android.material.dialog.MaterialAlertDialogBuilder) mLhsZwmzceVnqwwx(this, i);
    }

    public override com.google.android.material.dialog.MaterialAlertDialogBuilder SetTitle(java.lang.CharSequence charSequence) {
        return (com.google.android.material.dialog.MaterialAlertDialogBuilder) osNCkSaxBOURZnZW(this, charSequence);
    }

    public androidx.appcompat.app.AlertDialog$Builder setobject(int i) {
        return VScUxAWPXDbMgitl(this, i);
    }

    public androidx.appcompat.app.AlertDialog$Builder setobject(android.view.object view) {
        return sWpsMRNaEZnNxAuc(this, view);
    }

    public override com.google.android.material.dialog.MaterialAlertDialogBuilder Setobject(int i) {
        return (com.google.android.material.dialog.MaterialAlertDialogBuilder) wAwrZAOrwtPdOIiy(this, i);
    }

    public override com.google.android.material.dialog.MaterialAlertDialogBuilder Setobject(android.view.object view) {
        return (com.google.android.material.dialog.MaterialAlertDialogBuilder) VaOSqxUgUGHiXvNZ(this, view);
    }
}

