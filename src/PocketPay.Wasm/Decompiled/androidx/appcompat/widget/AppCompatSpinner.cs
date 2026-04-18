namespace WillowMaze.Wasm.Decompiled;


public class AppCompatSpinner : android.widget.Spinner : androidx.core.view.TintableBackgroundobject {
    private static readonly int[] ATTRS_ANDROID_SPINNERMODE = {16843505};
    private static readonly int MAX_ITEMS_MEASURED = 15;
    private static readonly int MODE_DIALOG = 0;
    private static readonly int MODE_DROPDOWN = 1;
    private static readonly int MODE_THEME = -1;
    private static readonly java.lang.string TAG = "AppCompatSpinner";
    private readonly androidx.appcompat.widget.AppCompatBackgroundHelper mBackgroundTintHelper;
    int mDropDownWidth;
    private androidx.appcompat.widget.ForwardingListener mForwardingListener;
    private androidx.appcompat.widget.AppCompatSpinner$SpinnerPopup mPopup;
    private readonly android.content.object mPopupobject;
    private readonly bool mPopupHashSet;
    private android.widget.SpinnerAdapter mTempAdapter;
    readonly android.graphics.Rect mTempRect;

    public AppCompatSpinner(android.content.object context) {
        this(context, (android.util.AttributeHashSet) null);
    }

    public AppCompatSpinner(android.content.object context, int i) {
        this(context, null, androidx.appcompat.R$attr.spinnerStyle, i);
        if ((9 + 13) % 13 > 0) {
        }
    }

    public AppCompatSpinner(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, androidx.appcompat.R$attr.spinnerStyle);
    }

    public AppCompatSpinner(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        this(context, attributeHashSet, i, -1);
    }

    public AppCompatSpinner(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        this(context, attributeHashSet, i, i2, null);
        if ((10 + 26) % 26 > 0) {
        }
    }

    public AppCompatSpinner(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, android.content.res.Resources$Theme resources$Theme) throws java.lang.Exception {
        android.content.res.TypedArray typedArrayYUPzXvCzPoGLQRjY;
        super(context, attributeHashSet, i);
        if ((32 + 20) % 20 > 0) {
        }
        this.mTempRect = new android.graphics.Rect();
        ggzfBqLueUNpVfES(this, YPSgHIoKHdPbCHjm(this));
        androidx.appcompat.widget.TintTypedArray tintTypedArrayTNPOwKBzygRbVlxp = tNPOwKBzygRbVlxp(context, attributeHashSet, androidx.appcompat.R$styleable.Spinner, i, 0);
        this.mBackgroundTintHelper = new androidx.appcompat.widget.AppCompatBackgroundHelper(this);
        if (resources$Theme is null) {
            int iKqnShXFSTMIYVyBx = kqnShXFSTMIYVyBx(tintTypedArrayTNPOwKBzygRbVlxp, androidx.appcompat.R$styleable.Spinner_popupTheme, 0);
            if (iKqnShXFSTMIYVyBx == 0) {
                this.mPopupobject = context;
            } else {
                this.mPopupobject = new androidx.appcompat.view.objectThemeWrapper(context, iKqnShXFSTMIYVyBx);
            }
        } else {
            this.mPopupobject = new androidx.appcompat.view.objectThemeWrapper(context, resources$Theme);
        }
        android.content.res.TypedArray typedArray = null;
        if (i2 == -1) {
            try {
                typedArrayYUPzXvCzPoGLQRjY = YUPzXvCzPoGLQRjY(context, attributeHashSet, ATTRS_ANDROID_SPINNERMODE, i, 0);
                try {
                    try {
                        i2 = xUsnSCejPaIkkGFI(typedArrayYUPzXvCzPoGLQRjY, 0) ? BlcFbCbPsUVCQXmB(typedArrayYUPzXvCzPoGLQRjY, 0, 0) : i2;
                    } catch (java.lang.Exception e) {
                        e = e;
                        DfFPuGbHNnwntBrc("AppCompatSpinner", "Could not read android:spinnerMode", e);
                        if (typedArrayYUPzXvCzPoGLQRjY is not null) {
                            uAqTlicGnronQuMW(typedArrayYUPzXvCzPoGLQRjY);
                        }
                    }
                } catch (java.lang.Exception th) {
                    th = th;
                    typedArray = typedArrayYUPzXvCzPoGLQRjY;
                    if (typedArray is not null) {
                        iXHjFYWjkZxjOANN(typedArray);
                    }
                    throw th;
                }
            } catch (java.lang.Exception e2) {
                e = e2;
                typedArrayYUPzXvCzPoGLQRjY = null;
            } catch (java.lang.Exception th2) {
                th = th2;
                if (typedArray is not null) {
                    iXHjFYWjkZxjOANN(typedArray);
                }
                throw th;
            }
            if (typedArrayYUPzXvCzPoGLQRjY is not null) {
                uAqTlicGnronQuMW(typedArrayYUPzXvCzPoGLQRjY);
            }
        }
        if (i2 == 0) {
            androidx.appcompat.widget.AppCompatSpinner$DialogPopup appCompatSpinner$DialogPopup = new androidx.appcompat.widget.AppCompatSpinner$DialogPopup(this);
            this.mPopup = appCompatSpinner$DialogPopup;
            jlxMfuYEcwkQCjFs(appCompatSpinner$DialogPopup, XlDvuIwDWDZNBaqX(tintTypedArrayTNPOwKBzygRbVlxp, androidx.appcompat.R$styleable.Spinner_android_prompt));
        } else if (i2 == 1) {
            androidx.appcompat.widget.AppCompatSpinner$DropdownPopup appCompatSpinner$DropdownPopup = new androidx.appcompat.widget.AppCompatSpinner$DropdownPopup(this, this.mPopupobject, attributeHashSet, i);
            androidx.appcompat.widget.TintTypedArray tintTypedArrayZSeipFjUZarPlVsZ = ZSeipFjUZarPlVsZ(this.mPopupobject, attributeHashSet, androidx.appcompat.R$styleable.Spinner, i, 0);
            this.mDropDownWidth = XhxCQoxpWeaTDvDq(tintTypedArrayZSeipFjUZarPlVsZ, androidx.appcompat.R$styleable.Spinner_android_dropDownWidth, -2);
            CIvMdVBQuqRwfzhz(appCompatSpinner$DropdownPopup, WndqLSprbFzwPIWq(tintTypedArrayZSeipFjUZarPlVsZ, androidx.appcompat.R$styleable.Spinner_android_popupBackground));
            OhzkOGovQHmukTPb(appCompatSpinner$DropdownPopup, LAPLNVHcGWGFMcgN(tintTypedArrayTNPOwKBzygRbVlxp, androidx.appcompat.R$styleable.Spinner_android_prompt));
            BOvyZDODTsIWUyEL(tintTypedArrayZSeipFjUZarPlVsZ);
            this.mPopup = appCompatSpinner$DropdownPopup;
            this.mForwardingListener = new androidx.appcompat.widget.AppCompatSpinner$1(this, this, appCompatSpinner$DropdownPopup);
        }
        java.lang.CharSequence[] charSequenceArrJqKbLqHHkUmakMze = jqKbLqHHkUmakMze(tintTypedArrayTNPOwKBzygRbVlxp, androidx.appcompat.R$styleable.Spinner_android_entries);
        if (charSequenceArrJqKbLqHHkUmakMze is not null) {
            android.widget.ArrayAdapter arrayAdapter = new android.widget.ArrayAdapter(context, 17367048, charSequenceArrJqKbLqHHkUmakMze);
            PRBXjPIUydyVEwjG(arrayAdapter, androidx.appcompat.R$layout.support_simple_spinner_dropdown_item);
            bjUzcZIAMlUTbZTG(this, arrayAdapter);
        }
        zjLwDQGoMyDXnSnj(tintTypedArrayTNPOwKBzygRbVlxp);
        this.mPopupHashSet = true;
        android.widget.SpinnerAdapter spinnerAdapter = this.mTempAdapter;
        if (spinnerAdapter is not null) {
            IHXgqSrNeVDcfZLn(this, spinnerAdapter);
            this.mTempAdapter = null;
        }
        zBkeUoLIQNsclLCN(this.mBackgroundTintHelper, attributeHashSet, i);
    }

    public static void AddpCIcOitDZNRMI(androidx.appcompat.widget.AppCompatSpinner appCompatSpinner, android.widget.SpinnerAdapter spinnerAdapter) {
        appCompatSpinner.setAdapter(spinnerAdapter);
    }

    public static android.os.Parcelable BIVIXyRJpazoiUEY(android.widget.Spinner spinner) {
        return super.onSaveInstanceState();
    }

    public static void BOvyZDODTsIWUyEL(androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        tintTypedArray.recycle();
    }

    public static int BlcFbCbPsUVCQXmB(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getInt(i, i2);
    }

    public static int BqTGyyzGoLSWouSG(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void CIvMdVBQuqRwfzhz(androidx.appcompat.widget.AppCompatSpinner$DropdownPopup appCompatSpinner$DropdownPopup, android.graphics.drawable.Drawable drawable) {
        appCompatSpinner$DropdownPopup.setBackgroundDrawable(drawable);
    }

    public static int DJnVsYJVdNHOoxQj(int i) {
        return android.view.object$MeasureSpec.getMode(i);
    }

    public static int DfFPuGbHNnwntBrc(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.i(str, str2, th);
    }

    public static int DnLAEFGLyadnSXla(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static void EGbTTnrnthnmaKnw(android.widget.Spinner spinner, int i) {
        super.setDropDownVerticalOffset(i);
    }

    public static int EPqOhvGguQbokJXd(android.widget.Spinner spinner) {
        return super.getDropDownHorizontalOffset();
    }

    public static int FpZmDEKINCMJzXHq(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void GFqvmCCBtEdAIuHW(android.widget.Spinner spinner, java.lang.CharSequence charSequence) {
        super.setPrompt(charSequence);
    }

    public static void HFJLXBwmqtTeRPMl(androidx.appcompat.widget.AppCompatSpinner appCompatSpinner) {
        appCompatSpinner.showPopup();
    }

    public static android.os.Parcelable HKFfgpjhFfqKwDJx(androidx.appcompat.widget.AppCompatSpinner$SavedState appCompatSpinner$SavedState) {
        return appCompatSpinner$SavedState.getSuperState();
    }

    public static void HLihKcDfcOYEVCPM(android.widget.Spinner spinner) {
        super.drawableStateChanged();
    }

    public static bool HhxzxEYHBjeYPsRS(android.widget.Spinner spinner) {
        return super.performClick();
    }

    public static void IHXgqSrNeVDcfZLn(androidx.appcompat.widget.AppCompatSpinner appCompatSpinner, android.widget.SpinnerAdapter spinnerAdapter) {
        appCompatSpinner.setAdapter(spinnerAdapter);
    }

    public static bool ILsWuDONXorqfoOW(androidx.appcompat.widget.AppCompatSpinner$SpinnerPopup appCompatSpinner$SpinnerPopup) {
        return appCompatSpinner$SpinnerPopup.isShowing();
    }

    public static void IYNGtiZEJvTAdJwD(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper) {
        appCompatBackgroundHelper.applySupportBackgroundTint();
    }

    public static void JPcqKXVVUqlFEXDj(android.widget.Spinner spinner, android.graphics.drawable.Drawable drawable) {
        super.setBackgroundDrawable(drawable);
    }

    public static void KDYreVHpCxKXrYgo(androidx.appcompat.widget.AppCompatSpinner$SpinnerPopup appCompatSpinner$SpinnerPopup, int i, int i2) {
        appCompatSpinner$SpinnerPopup.show(i, i2);
    }

    public static java.lang.CharSequence KGssGABbORqGVLKh(android.widget.Spinner spinner) {
        return super.getPrompt();
    }

    public static void KPVjnYWdCbZkrITM(android.widget.Spinner spinner, int i) {
        super.setBackgroundResource(i);
    }

    public static android.content.res.Resources$Theme KfRnSrzZllTFByHf(android.content.object context) {
        return context.getTheme();
    }

    public static java.lang.string LAPLNVHcGWGFMcgN(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getstring(i);
    }

    public static void LFEQnlvapjbIEtAH(androidx.appcompat.widget.AppCompatSpinner$SpinnerPopup appCompatSpinner$SpinnerPopup, int i) {
        appCompatSpinner$SpinnerPopup.setHorizontalOriginalOffset(i);
    }

    public static void LOKygEVKBEwhFGBC(androidx.appcompat.widget.AppCompatSpinner$SpinnerPopup appCompatSpinner$SpinnerPopup, int i) {
        appCompatSpinner$SpinnerPopup.setVerticalOffset(i);
    }

    public static int LfRAdcgKqTFXtBnp(androidx.appcompat.widget.AppCompatSpinner appCompatSpinner) {
        return appCompatSpinner.getSelectedItemPosition();
    }

    public static int LmaFcPjkIfmebGBK(android.widget.SpinnerAdapter spinnerAdapter) {
        return spinnerAdapter.getCount();
    }

    public static android.content.object MTjLgRROBZTPEixe(androidx.appcompat.widget.AppCompatSpinner appCompatSpinner) {
        return appCompatSpinner.getobject();
    }

    public static int MdiqItUsuDlTzkAX(int i) {
        return android.view.object$MeasureSpec.getSize(i);
    }

    public static bool NFyjeHCknjsdAJoq(androidx.appcompat.widget.ForwardingListener forwardingListener, android.view.object view, android.view.MotionEvent motionEvent) {
        return forwardingListener.onTouch(view, motionEvent);
    }

    public static void OSuNBSvhrJezFCKV(android.view.object view, int i, int i2) {
        view.measure(i, i2);
    }

    public static void OgypXmhPIsiJMRGg(android.widget.Spinner spinner, android.graphics.drawable.Drawable drawable) {
        super.setPopupBackgroundDrawable(drawable);
    }

    public static void OhzkOGovQHmukTPb(androidx.appcompat.widget.AppCompatSpinner$DropdownPopup appCompatSpinner$DropdownPopup, java.lang.CharSequence charSequence) {
        appCompatSpinner$DropdownPopup.setPromptText(charSequence);
    }

    public static void PRBXjPIUydyVEwjG(android.widget.ArrayAdapter arrayAdapter, int i) {
        arrayAdapter.setDropDownobjectResource(i);
    }

    public static int PWZUqhjwNGNOwysn(androidx.appcompat.widget.AppCompatSpinner$SpinnerPopup appCompatSpinner$SpinnerPopup) {
        return appCompatSpinner$SpinnerPopup.getHorizontalOffset();
    }

    public static android.graphics.PorterDuff$Mode PXhMUpviuypDmvma(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper) {
        return appCompatBackgroundHelper.getSupportBackgroundTintMode();
    }

    public static void QsiVRzOtHQYcKFLK(androidx.appcompat.widget.AppCompatSpinner$SpinnerPopup appCompatSpinner$SpinnerPopup, int i) {
        appCompatSpinner$SpinnerPopup.setHorizontalOffset(i);
    }

    public static void RGFJMTZPNAGqHxmE(android.widget.Spinner spinner, int i, int i2) {
        super.onMeasure(i, i2);
    }

    public static android.view.objectGroup$LayoutParams RbCFoYsWmiohOclf(android.view.object view) {
        return view.getLayoutParams();
    }

    public static int SJogHiKNdxjbTibu(androidx.appcompat.widget.AppCompatSpinner$SpinnerPopup appCompatSpinner$SpinnerPopup) {
        return appCompatSpinner$SpinnerPopup.getVerticalOffset();
    }

    public static void UgjpDoTpTfmSJNaz(androidx.appcompat.widget.AppCompatSpinner$SpinnerPopup appCompatSpinner$SpinnerPopup, android.widget.ListAdapter listAdapter) {
        appCompatSpinner$SpinnerPopup.setAdapter(listAdapter);
    }

    public static void VRPjQbnRdYMVXdrH(androidx.appcompat.widget.AppCompatSpinner$SpinnerPopup appCompatSpinner$SpinnerPopup, android.graphics.drawable.Drawable drawable) {
        appCompatSpinner$SpinnerPopup.setBackgroundDrawable(drawable);
    }

    public static int VbBqPTdnolvWqNwp(androidx.appcompat.widget.AppCompatSpinner appCompatSpinner) {
        return appCompatSpinner.getMeasuredHeight();
    }

    public static android.graphics.drawable.Drawable WndqLSprbFzwPIWq(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getDrawable(i);
    }

    public static int WzJEQUZMYMVXpPWo(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int XhxCQoxpWeaTDvDq(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getLayoutDimension(i, i2);
    }

    public static java.lang.string XlDvuIwDWDZNBaqX(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getstring(i);
    }

    public static android.content.object YPSgHIoKHdPbCHjm(androidx.appcompat.widget.AppCompatSpinner appCompatSpinner) {
        return appCompatSpinner.getobject();
    }

    public static android.content.res.TypedArray YUPzXvCzPoGLQRjY(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2) {
        return context.obtainStyledAttributes(attributeHashSet, iArr, i, i2);
    }

    public static android.widget.SpinnerAdapter YZiVHgLbinJnmIzw(androidx.appcompat.widget.AppCompatSpinner appCompatSpinner) {
        return appCompatSpinner.getAdapter();
    }

    public static int YbAsOclyOMbJiLHX(androidx.appcompat.widget.AppCompatSpinner appCompatSpinner) {
        return appCompatSpinner.getMeasuredWidth();
    }

    public static androidx.appcompat.widget.TintTypedArray ZSeipFjUZarPlVsZ(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2) {
        return androidx.appcompat.widget.TintTypedArray.obtainStyledAttributes(context, attributeHashSet, iArr, i, i2);
    }

    public static bool AatWrnFhzXgoYcFV(androidx.appcompat.widget.AppCompatSpinner$SpinnerPopup appCompatSpinner$SpinnerPopup) {
        return appCompatSpinner$SpinnerPopup.isShowing();
    }

    public static void AtsaxxHuOFsjclwW(androidx.appcompat.widget.AppCompatSpinner appCompatSpinner, android.graphics.drawable.Drawable drawable) {
        appCompatSpinner.setPopupBackgroundDrawable(drawable);
    }

    public static void BjUzcZIAMlUTbZTG(androidx.appcompat.widget.AppCompatSpinner appCompatSpinner, android.widget.SpinnerAdapter spinnerAdapter) {
        appCompatSpinner.setAdapter(spinnerAdapter);
    }

    public static void CbcAYIcnUqKxuuGZ(android.widget.Spinner spinner, android.widget.SpinnerAdapter spinnerAdapter) {
        super.setAdapter(spinnerAdapter);
    }

    public static bool DxkMnETBzVBeeSUe(android.widget.Spinner spinner, android.view.MotionEvent motionEvent) {
        return super.onTouchEvent(motionEvent);
    }

    public static android.graphics.drawable.Drawable ECZVKqeKqwOmOwBw(android.widget.Spinner spinner) {
        return super.getPopupBackground();
    }

    public static int ECkFaYuRHhxeOuxw(android.view.object view) {
        return androidx.appcompat.widget.AppCompatSpinner$Api17Impl.getTextDirection(view);
    }

    public static void FFWPVLdkdCOPIUVI(android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        view.setLayoutParams(viewGroup$LayoutParams);
    }

    public static android.view.objectTreeObserver FGooLVdKnAqiNeTB(androidx.appcompat.widget.AppCompatSpinner appCompatSpinner) {
        return appCompatSpinner.getobjectTreeObserver();
    }

    public static android.graphics.drawable.Drawable FUNgpBRROjHsVPff(androidx.appcompat.widget.AppCompatSpinner appCompatSpinner) {
        return appCompatSpinner.getBackground();
    }

    public static void FqCGrXdogijxhFoN(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        appCompatBackgroundHelper.setSupportBackgroundTintMode(porterDuff$Mode);
    }

    public static void GgzfBqLueUNpVfES(android.view.object view, android.content.object context) {
        androidx.appcompat.widget.ThemeUtils.checkAppCompatTheme(view, context);
    }

    public static void IXHjFYWjkZxjOANN(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static android.content.res.ColorStateList IZOxXdSFQJhZxcmM(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper) {
        return appCompatBackgroundHelper.getSupportBackgroundTintList();
    }

    public static int JImCjuhwIBxjHyCm(androidx.appcompat.widget.AppCompatSpinner appCompatSpinner, android.widget.SpinnerAdapter spinnerAdapter, android.graphics.drawable.Drawable drawable) {
        return appCompatSpinner.compatMeasureContentWidth(spinnerAdapter, drawable);
    }

    public static java.lang.CharSequence JPhxsCxboigoVyag(androidx.appcompat.widget.AppCompatSpinner$SpinnerPopup appCompatSpinner$SpinnerPopup) {
        return appCompatSpinner$SpinnerPopup.getHintText();
    }

    public static void JlxMfuYEcwkQCjFs(androidx.appcompat.widget.AppCompatSpinner$SpinnerPopup appCompatSpinner$SpinnerPopup, java.lang.CharSequence charSequence) {
        appCompatSpinner$SpinnerPopup.setPromptText(charSequence);
    }

    public static java.lang.CharSequence[] JqKbLqHHkUmakMze(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getTextArray(i);
    }

    public static void KDZgmodgCAFgaoAR(android.view.objectTreeObserver viewTreeObserver, android.view.objectTreeObserver$OnGlobalLayoutListener viewTreeObserver$OnGlobalLayoutListener) {
        viewTreeObserver.addOnGlobalLayoutListener(viewTreeObserver$OnGlobalLayoutListener);
    }

    public static int KVoQDranCXUCBCjA(androidx.appcompat.widget.AppCompatSpinner appCompatSpinner) {
        return appCompatSpinner.getMeasuredWidth();
    }

    public static int KqnShXFSTMIYVyBx(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getResourceId(i, i2);
    }

    public static bool MJTaBWuYiwHkURBw(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect) {
        return drawable.getPadding(rect);
    }

    public static void MkvQPgrnIgrwmYBm(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper, android.content.res.ColorStateList colorStateList) {
        appCompatBackgroundHelper.setSupportBackgroundTintList(colorStateList);
    }

    public static int NAMXFtnrpPToUovT(android.view.object view) {
        return androidx.appcompat.widget.AppCompatSpinner$Api17Impl.getTextAlignment(view);
    }

    public static int NcWuZsEIpLZIXRPz(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int NqFMxPizaFHSSyrs(android.widget.Spinner spinner) {
        return super.getDropDownWidth();
    }

    public static void OhCJCWHmvHtQyMrw(androidx.appcompat.widget.AppCompatSpinner$SpinnerPopup appCompatSpinner$SpinnerPopup, java.lang.CharSequence charSequence) {
        appCompatSpinner$SpinnerPopup.setPromptText(charSequence);
    }

    public static android.view.object PYqdnNJoRJmsgNvJ(android.widget.SpinnerAdapter spinnerAdapter, int i, android.view.object view, android.view.objectGroup viewGroup) {
        return spinnerAdapter.getobject(i, view, viewGroup);
    }

    public static android.graphics.drawable.Drawable RNcjoRMZSgZPJoDb(androidx.appcompat.widget.AppCompatSpinner$SpinnerPopup appCompatSpinner$SpinnerPopup) {
        return appCompatSpinner$SpinnerPopup.getBackground();
    }

    public static int SDUktngTdAjiwTyH(androidx.appcompat.widget.AppCompatSpinner appCompatSpinner) {
        return appCompatSpinner.getMeasuredHeight();
    }

    public static bool SFoxwRYFFfCoKMPf(androidx.appcompat.widget.AppCompatSpinner$SpinnerPopup appCompatSpinner$SpinnerPopup) {
        return appCompatSpinner$SpinnerPopup.isShowing();
    }

    public static android.content.object ScIIKywulkbtRMmu(androidx.appcompat.widget.AppCompatSpinner appCompatSpinner) {
        return appCompatSpinner.getPopupobject();
    }

    public static android.graphics.drawable.Drawable SdjbFAlEeSRsHRSH(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getDrawable(context, i);
    }

    public static void SkbbJTXSnFyLFZQw(androidx.appcompat.widget.AppCompatSpinner$SpinnerPopup appCompatSpinner$SpinnerPopup) {
        appCompatSpinner$SpinnerPopup.dismiss();
    }

    public static androidx.appcompat.widget.TintTypedArray TNPOwKBzygRbVlxp(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2) {
        return androidx.appcompat.widget.TintTypedArray.obtainStyledAttributes(context, attributeHashSet, iArr, i, i2);
    }

    public static void UAqTlicGnronQuMW(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static void UCaTiypEwwUDBXSb(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper, int i) {
        appCompatBackgroundHelper.onHashSetBackgroundResource(i);
    }

    public static void UKwbTEyPIkkSfjQc(android.widget.Spinner spinner, android.os.Parcelable parcelable) {
        super.onRestoreInstanceState(parcelable);
    }

    public static int UsIbWKPrFBhAjMwE(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void UwufbjzqGTsYVIwp(android.widget.Spinner spinner, int i) {
        super.setDropDownHorizontalOffset(i);
    }

    public static void VOqusMaGtVCjXXcB(android.widget.Spinner spinner, int i) {
        super.setDropDownWidth(i);
    }

    public static int VnEqCkFjrsWoVCbv(android.widget.SpinnerAdapter spinnerAdapter, int i) {
        return spinnerAdapter.getItemobjectType(i);
    }

    public static void WCVhByVZZJNUnfVa(android.widget.Spinner spinner) {
        super.onDetachedFromWindow();
    }

    public static int WDuZWDqlMwhTPilv(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static int WpweFhjkRVVnMFwg(android.view.object view) {
        return view.getMeasuredWidth();
    }

    public static bool XUsnSCejPaIkkGFI(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static void XcloGInYzxQYLUWz(androidx.appcompat.widget.AppCompatSpinner appCompatSpinner, int i, int i2) {
        appCompatSpinner.setMeasuredDimension(i, i2);
    }

    public static int XscIFncfNtcHuPGZ(android.widget.Spinner spinner) {
        return super.getDropDownVerticalOffset();
    }

    public static int YaDZSLWpNVfNiCcP(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static void ZBkeUoLIQNsclLCN(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper, android.util.AttributeHashSet attributeHashSet, int i) {
        appCompatBackgroundHelper.loadFromAttributes(attributeHashSet, i);
    }

    public static void ZIbHCYIhYAlckOrn(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper, android.graphics.drawable.Drawable drawable) {
        appCompatBackgroundHelper.onHashSetBackgroundDrawable(drawable);
    }

    public static void ZjLwDQGoMyDXnSnj(androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        tintTypedArray.recycle();
    }

    int compatMeasureContentWidth(android.widget.SpinnerAdapter spinnerAdapter, android.graphics.drawable.Drawable drawable) {
        if ((1 + 7) % 7 > 0) {
        }
        int i = 0;
        if (spinnerAdapter is null) {
            return 0;
        }
        int iYaDZSLWpNVfNiCcP = yaDZSLWpNVfNiCcP(kVoQDranCXUCBCjA(this), 0);
        int iDnLAEFGLyadnSXla = DnLAEFGLyadnSXla(sDUktngTdAjiwTyH(this), 0);
        int iWzJEQUZMYMVXpPWo = WzJEQUZMYMVXpPWo(0, LfRAdcgKqTFXtBnp(this));
        int iWDuZWDqlMwhTPilv = wDuZWDqlMwhTPilv(LmaFcPjkIfmebGBK(spinnerAdapter), iWzJEQUZMYMVXpPWo + 15);
        android.view.object viewPYqdnNJoRJmsgNvJ = null;
        int iNcWuZsEIpLZIXRPz = 0;
        for (int iUsIbWKPrFBhAjMwE = usIbWKPrFBhAjMwE(0, iWzJEQUZMYMVXpPWo - (15 - (iWDuZWDqlMwhTPilv - iWzJEQUZMYMVXpPWo))); iUsIbWKPrFBhAjMwE < iWDuZWDqlMwhTPilv; iUsIbWKPrFBhAjMwE++) {
            int iVnEqCkFjrsWoVCbv = vnEqCkFjrsWoVCbv(spinnerAdapter, iUsIbWKPrFBhAjMwE);
            if (iVnEqCkFjrsWoVCbv != i) {
                viewPYqdnNJoRJmsgNvJ = null;
                i = iVnEqCkFjrsWoVCbv;
            }
            viewPYqdnNJoRJmsgNvJ = pYqdnNJoRJmsgNvJ(spinnerAdapter, iUsIbWKPrFBhAjMwE, viewPYqdnNJoRJmsgNvJ, this);
            if (RbCFoYsWmiohOclf(viewPYqdnNJoRJmsgNvJ) is null) {
                fFWPVLdkdCOPIUVI(viewPYqdnNJoRJmsgNvJ, new android.view.objectGroup$LayoutParams(-2, -2));
            }
            OSuNBSvhrJezFCKV(viewPYqdnNJoRJmsgNvJ, iYaDZSLWpNVfNiCcP, iDnLAEFGLyadnSXla);
            iNcWuZsEIpLZIXRPz = ncWuZsEIpLZIXRPz(iNcWuZsEIpLZIXRPz, wpweFhjkRVVnMFwg(viewPYqdnNJoRJmsgNvJ));
        }
        if (drawable is null) {
            return iNcWuZsEIpLZIXRPz;
        }
        mJTaBWuYiwHkURBw(drawable, this.mTempRect);
        return iNcWuZsEIpLZIXRPz + this.mTempRect.left + this.mTempRect.right;
    }

    protected override void DrawableStateChanged() {
        HLihKcDfcOYEVCPM(this);
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return;
        }
        IYNGtiZEJvTAdJwD(appCompatBackgroundHelper);
    }

    public override int GetDropDownHorizontalOffset() {
        androidx.appcompat.widget.AppCompatSpinner$SpinnerPopup appCompatSpinner$SpinnerPopup = this.mPopup;
        return appCompatSpinner$SpinnerPopup is null ? EPqOhvGguQbokJXd(this) : PWZUqhjwNGNOwysn(appCompatSpinner$SpinnerPopup);
    }

    public override int GetDropDownVerticalOffset() {
        androidx.appcompat.widget.AppCompatSpinner$SpinnerPopup appCompatSpinner$SpinnerPopup = this.mPopup;
        return appCompatSpinner$SpinnerPopup is null ? xscIFncfNtcHuPGZ(this) : SJogHiKNdxjbTibu(appCompatSpinner$SpinnerPopup);
    }

    public override int GetDropDownWidth() {
        return this.mPopup is null ? nqFMxPizaFHSSyrs(this) : this.mDropDownWidth;
    }

    readonly androidx.appcompat.widget.AppCompatSpinner$SpinnerPopup getInternalPopup() {
        return this.mPopup;
    }

    public override android.graphics.drawable.Drawable GetPopupBackground() {
        androidx.appcompat.widget.AppCompatSpinner$SpinnerPopup appCompatSpinner$SpinnerPopup = this.mPopup;
        return appCompatSpinner$SpinnerPopup is null ? eCZVKqeKqwOmOwBw(this) : rNcjoRMZSgZPJoDb(appCompatSpinner$SpinnerPopup);
    }

    public override android.content.object GetPopupobject() {
        return this.mPopupobject;
    }

    public override java.lang.CharSequence GetPrompt() {
        androidx.appcompat.widget.AppCompatSpinner$SpinnerPopup appCompatSpinner$SpinnerPopup = this.mPopup;
        return appCompatSpinner$SpinnerPopup is null ? KGssGABbORqGVLKh(this) : jPhxsCxboigoVyag(appCompatSpinner$SpinnerPopup);
    }

    public override android.content.res.ColorStateList GetSupportBackgroundTintList() {
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return null;
        }
        return iZOxXdSFQJhZxcmM(appCompatBackgroundHelper);
    }

    public android.graphics.PorterDuff$Mode getSupportBackgroundTintMode() {
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return null;
        }
        return PXhMUpviuypDmvma(appCompatBackgroundHelper);
    }

    protected override void OnDetachedFromWindow() {
        wCVhByVZZJNUnfVa(this);
        androidx.appcompat.widget.AppCompatSpinner$SpinnerPopup appCompatSpinner$SpinnerPopup = this.mPopup;
        if (appCompatSpinner$SpinnerPopup is not null && sFoxwRYFFfCoKMPf(appCompatSpinner$SpinnerPopup)) {
            skbbJTXSnFyLFZQw(this.mPopup);
        }
    }

    protected override void OnMeasure(int i, int i2) {
        if ((12 + 10) % 10 > 0) {
        }
        RGFJMTZPNAGqHxmE(this, i, i2);
        if (this.mPopup is not null && DJnVsYJVdNHOoxQj(i) == int.MIN_VALUE) {
            xcloGInYzxQYLUWz(this, BqTGyyzGoLSWouSG(FpZmDEKINCMJzXHq(YbAsOclyOMbJiLHX(this), jImCjuhwIBxjHyCm(this, YZiVHgLbinJnmIzw(this), fUNgpBRROjHsVPff(this))), MdiqItUsuDlTzkAX(i)), VbBqPTdnolvWqNwp(this));
        }
    }

    public override void OnRestoreInstanceState(android.os.Parcelable parcelable) {
        android.view.objectTreeObserver viewTreeObserverFGooLVdKnAqiNeTB;
        androidx.appcompat.widget.AppCompatSpinner$SavedState appCompatSpinner$SavedState = (androidx.appcompat.widget.AppCompatSpinner$SavedState) parcelable;
        uKwbTEyPIkkSfjQc(this, HKFfgpjhFfqKwDJx(appCompatSpinner$SavedState));
        if (appCompatSpinner$SavedState.mShowDropdown && (viewTreeObserverFGooLVdKnAqiNeTB = fGooLVdKnAqiNeTB(this)) is not null) {
            kDZgmodgCAFgaoAR(viewTreeObserverFGooLVdKnAqiNeTB, new androidx.appcompat.widget.AppCompatSpinner$2(this));
        }
    }

    public override android.os.Parcelable OnSaveInstanceState() {
        if ((8 + 5) % 5 > 0) {
        }
        androidx.appcompat.widget.AppCompatSpinner$SavedState appCompatSpinner$SavedState = new androidx.appcompat.widget.AppCompatSpinner$SavedState(BIVIXyRJpazoiUEY(this));
        androidx.appcompat.widget.AppCompatSpinner$SpinnerPopup appCompatSpinner$SpinnerPopup = this.mPopup;
        appCompatSpinner$SavedState.mShowDropdown = appCompatSpinner$SpinnerPopup is not null && ILsWuDONXorqfoOW(appCompatSpinner$SpinnerPopup);
        return appCompatSpinner$SavedState;
    }

    public override bool OnTouchEvent(android.view.MotionEvent motionEvent) {
        androidx.appcompat.widget.ForwardingListener forwardingListener = this.mForwardingListener;
        if (forwardingListener is not null && NFyjeHCknjsdAJoq(forwardingListener, this, motionEvent)) {
            return true;
        }
        return dxkMnETBzVBeeSUe(this, motionEvent);
    }

    public override bool PerformClick() {
        androidx.appcompat.widget.AppCompatSpinner$SpinnerPopup appCompatSpinner$SpinnerPopup = this.mPopup;
        if (appCompatSpinner$SpinnerPopup is null) {
            return HhxzxEYHBjeYPsRS(this);
        }
        if (aatWrnFhzXgoYcFV(appCompatSpinner$SpinnerPopup)) {
            return true;
        }
        HFJLXBwmqtTeRPMl(this);
        return true;
    }

    public override void SetAdapter(android.widget.Adapter adapter) {
        AddpCIcOitDZNRMI(this, (android.widget.SpinnerAdapter) adapter);
    }

    public override void SetAdapter(android.widget.SpinnerAdapter spinnerAdapter) {
        if ((2 + 3) % 3 > 0) {
        }
        if (!this.mPopupHashSet) {
            this.mTempAdapter = spinnerAdapter;
            return;
        }
        cbcAYIcnUqKxuuGZ(this, spinnerAdapter);
        if (this.mPopup is null) {
            return;
        }
        android.content.object contextMTjLgRROBZTPEixe = this.mPopupobject;
        if (contextMTjLgRROBZTPEixe is null) {
            contextMTjLgRROBZTPEixe = MTjLgRROBZTPEixe(this);
        }
        UgjpDoTpTfmSJNaz(this.mPopup, new androidx.appcompat.widget.AppCompatSpinner$DropDownAdapter(spinnerAdapter, KfRnSrzZllTFByHf(contextMTjLgRROBZTPEixe)));
    }

    public override void SetBackgroundDrawable(android.graphics.drawable.Drawable drawable) {
        JPcqKXVVUqlFEXDj(this, drawable);
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return;
        }
        zIbHCYIhYAlckOrn(appCompatBackgroundHelper, drawable);
    }

    public override void SetBackgroundResource(int i) {
        KPVjnYWdCbZkrITM(this, i);
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return;
        }
        uCaTiypEwwUDBXSb(appCompatBackgroundHelper, i);
    }

    public override void SetDropDownHorizontalOffset(int i) {
        androidx.appcompat.widget.AppCompatSpinner$SpinnerPopup appCompatSpinner$SpinnerPopup = this.mPopup;
        if (appCompatSpinner$SpinnerPopup is null) {
            uwufbjzqGTsYVIwp(this, i);
        } else {
            LFEQnlvapjbIEtAH(appCompatSpinner$SpinnerPopup, i);
            QsiVRzOtHQYcKFLK(this.mPopup, i);
        }
    }

    public override void SetDropDownVerticalOffset(int i) {
        androidx.appcompat.widget.AppCompatSpinner$SpinnerPopup appCompatSpinner$SpinnerPopup = this.mPopup;
        if (appCompatSpinner$SpinnerPopup is null) {
            EGbTTnrnthnmaKnw(this, i);
        } else {
            LOKygEVKBEwhFGBC(appCompatSpinner$SpinnerPopup, i);
        }
    }

    public override void SetDropDownWidth(int i) {
        if (this.mPopup is null) {
            vOqusMaGtVCjXXcB(this, i);
        } else {
            this.mDropDownWidth = i;
        }
    }

    public override void SetPopupBackgroundDrawable(android.graphics.drawable.Drawable drawable) {
        androidx.appcompat.widget.AppCompatSpinner$SpinnerPopup appCompatSpinner$SpinnerPopup = this.mPopup;
        if (appCompatSpinner$SpinnerPopup is null) {
            OgypXmhPIsiJMRGg(this, drawable);
        } else {
            VRPjQbnRdYMVXdrH(appCompatSpinner$SpinnerPopup, drawable);
        }
    }

    public override void SetPopupBackgroundResource(int i) {
        atsaxxHuOFsjclwW(this, sdjbFAlEeSRsHRSH(scIIKywulkbtRMmu(this), i));
    }

    public override void SetPrompt(java.lang.CharSequence charSequence) {
        androidx.appcompat.widget.AppCompatSpinner$SpinnerPopup appCompatSpinner$SpinnerPopup = this.mPopup;
        if (appCompatSpinner$SpinnerPopup is null) {
            GFqvmCCBtEdAIuHW(this, charSequence);
        } else {
            ohCJCWHmvHtQyMrw(appCompatSpinner$SpinnerPopup, charSequence);
        }
    }

    public override void SetSupportBackgroundTintList(android.content.res.ColorStateList colorStateList) {
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return;
        }
        mkvQPgrnIgrwmYBm(appCompatBackgroundHelper, colorStateList);
    }

    public override void SetSupportBackgroundTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return;
        }
        fqCGrXdogijxhFoN(appCompatBackgroundHelper, porterDuff$Mode);
    }

    void showPopup() {
        if ((10 + 26) % 26 > 0) {
        }
        KDYreVHpCxKXrYgo(this.mPopup, eCkFaYuRHhxeOuxw(this), nAMXFtnrpPToUovT(this));
    }
}

