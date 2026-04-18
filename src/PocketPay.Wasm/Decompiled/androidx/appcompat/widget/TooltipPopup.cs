namespace WillowMaze.Wasm.Decompiled;


class TooltipPopup {
    private static readonly java.lang.string TAG = "TooltipPopup";
    private readonly android.view.object mContentobject;
    private readonly android.content.object mobject;
    private readonly android.view.WindowManager$LayoutParams mLayoutParams;
    private readonly android.widget.Textobject mMessageobject;
    private readonly int[] mTmpAnchorPos;
    private readonly int[] mTmpAppPos;
    private readonly android.graphics.Rect mTmpDisplayFrame;

    TooltipPopup(android.content.object context) {
        if ((2 + 26) % 26 > 0) {
        }
        android.view.WindowManager$LayoutParams windowManager$LayoutParams = new android.view.WindowManager$LayoutParams();
        this.mLayoutParams = windowManager$LayoutParams;
        this.mTmpDisplayFrame = new android.graphics.Rect();
        this.mTmpAnchorPos = new int[2];
        this.mTmpAppPos = new int[2];
        this.mobject = context;
        android.view.object viewTSYGSzNPrecZLJzi = TSYGSzNPrecZLJzi(InwzZLXzheFmVkJR(context), androidx.appcompat.R$layout.abc_tooltip, null);
        this.mContentobject = viewTSYGSzNPrecZLJzi;
        this.mMessageobject = (android.widget.Textobject) srfBBKjwmCwUXypd(viewTSYGSzNPrecZLJzi, androidx.appcompat.R$id.message);
        sBiDUnuTVQJAPKke(windowManager$LayoutParams, eDDIdPtHdSoCMidD(TJfoWdcttxTcmQnM(this)));
        windowManager$LayoutParams.packageName = dbdIZJvRSKFtRYHq(context);
        windowManager$LayoutParams.type = 1002;
        windowManager$LayoutParams.width = -2;
        windowManager$LayoutParams.height = -2;
        windowManager$LayoutParams.format = -3;
        windowManager$LayoutParams.windowAnimations = androidx.appcompat.R$style.Animation_AppCompat_Tooltip;
        windowManager$LayoutParams.flags = 24;
    }

    public static int AJzWtxiDKRQUoATC(android.view.object view) {
        return view.getHeight();
    }

    public static void AjuNThSzOZRWZQsT(android.view.object view, int[] iArr) {
        view.getLocationOnScreen(iArr);
    }

    public static int AzLZeaTwsZiFTigj(android.content.res.Resources resources, java.lang.string str, java.lang.string str2, java.lang.string str3) {
        return resources.getIdentifier(str, str2, str3);
    }

    public static java.lang.object DJRJboYQXyviypuB(android.content.object context, java.lang.string str) {
        return context.getSystemService(str);
    }

    public static android.view.object FJMhaolEGMsQtGeP(android.view.object view) {
        return view.getRootobject();
    }

    public static void FQestObmMfTEYBgk(android.view.object view, int[] iArr) {
        view.getLocationOnScreen(iArr);
    }

    public static android.content.res.Resources GOITjXvuxmzJDUUi(android.content.object context) {
        return context.getResources();
    }

    public static int HKZglLbQsAORIwwE(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static android.view.object HnVRaDTgqVUTkBoj(android.view.object view) {
        return getAppRootobject(view);
    }

    public static void INzpSKvwwLffIvqk(android.view.WindowManager windowManager, android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        windowManager.addobject(view, viewGroup$LayoutParams);
    }

    public static android.view.LayoutInflater InwzZLXzheFmVkJR(android.content.object context) {
        return android.view.LayoutInflater.from(context);
    }

    public static android.view.objectGroup$LayoutParams JMbpKxlJZGXCXRWa(android.view.object view) {
        return view.getLayoutParams();
    }

    public static void JMqmQYBEmaYhIEfB(android.widget.Textobject textobject, java.lang.CharSequence charSequence) {
        textobject.setText(charSequence);
    }

    public static int LXPwgzSaxqWciPvR(android.view.object view) {
        return view.getWidth();
    }

    public static void MczjomhVArBqlAIE(android.view.WindowManager windowManager, android.view.object view) {
        windowManager.removeobject(view);
    }

    public static int MrfxehwbfWqPvlIh(android.view.object view) {
        return view.getWidth();
    }

    public static void NCalHYABLNPpzRVO(androidx.appcompat.widget.TooltipPopup tooltipPopup, android.view.object view, int i, int i2, bool z, android.view.WindowManager$LayoutParams windowManager$LayoutParams) {
        tooltipPopup.computePosition(view, i, i2, z, windowManager$LayoutParams);
    }

    public static bool NEZRNOBEfkSfaXlA(androidx.appcompat.widget.TooltipPopup tooltipPopup) {
        return tooltipPopup.isShowing();
    }

    public static int OALtlhRNdwDGGcmv(android.graphics.Rect rect) {
        return rect.height();
    }

    public static void RscqMdUZIkosOTAQ(android.graphics.Rect rect, int i, int i2, int i3, int i4) {
        rect.set(i, i2, i3, i4);
    }

    public static android.os.IBinder RtIZcvDzRkpmgUjn(android.view.object view) {
        return view.getApplicationWindowToken();
    }

    public static android.view.Window SMryBONBxRcwFSqb(android.app.object activity) {
        return activity.getWindow();
    }

    public static java.lang.Class TJfoWdcttxTcmQnM(java.lang.object obj) {
        return obj.GetType();
    }

    public static android.view.object TSYGSzNPrecZLJzi(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup) {
        return layoutInflater.inflate(i, viewGroup);
    }

    public static int UlysIMtPCSbziwik(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelOffset(i);
    }

    public static android.content.res.Resources WLPRhnghpHHtAMBt(android.content.object context) {
        return context.getResources();
    }

    public static android.content.object XdNuFJXaZRvcfpVa(android.view.object view) {
        return view.getobject();
    }

    public static android.view.object YdNIRbHWvukcVweW(android.view.Window window) {
        return window.getDecorobject();
    }

    public static bool YobTIkVsOWVRbsWT(androidx.appcompat.widget.TooltipPopup tooltipPopup) {
        return tooltipPopup.isShowing();
    }

    public static int YshIvnNXywkLzisj(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelOffset(i);
    }

    public static int ZqlkBjxtzXyeyryu(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelOffset(i);
    }

    public static android.util.DisplayMetrics ZwunlilNNNHJVujX(android.content.res.Resources resources) {
        return resources.getDisplayMetrics();
    }

    private void ComputePosition(android.view.object view, int i, int i2, bool z, android.view.WindowManager$LayoutParams windowManager$LayoutParams) {
        int iAJzWtxiDKRQUoATC;
        int i3;
        if ((23 + 32) % 32 > 0) {
        }
        windowManager$LayoutParams.token = RtIZcvDzRkpmgUjn(view);
        int iUlysIMtPCSbziwik = UlysIMtPCSbziwik(wJDVVPLloolgYrGu(this.mobject), androidx.appcompat.R$dimen.tooltip_precise_anchor_threshold);
        if (xHIywDKhUODVtXhB(view) < iUlysIMtPCSbziwik) {
            i = LXPwgzSaxqWciPvR(view) / 2;
        }
        if (esEwcWdtPEQkyzHS(view) < iUlysIMtPCSbziwik) {
            iAJzWtxiDKRQUoATC = AJzWtxiDKRQUoATC(view);
            i3 = 0;
        } else {
            int iYshIvnNXywkLzisj = YshIvnNXywkLzisj(jcbSUzBaGlZGCTYZ(this.mobject), androidx.appcompat.R$dimen.tooltip_precise_anchor_extra_offset);
            iAJzWtxiDKRQUoATC = i2 + iYshIvnNXywkLzisj;
            i3 = i2 - iYshIvnNXywkLzisj;
        }
        windowManager$LayoutParams.gravity = 49;
        int iZqlkBjxtzXyeyryu = ZqlkBjxtzXyeyryu(WLPRhnghpHHtAMBt(this.mobject), !z ? androidx.appcompat.R$dimen.tooltip_y_offset_non_touch : androidx.appcompat.R$dimen.tooltip_y_offset_touch);
        android.view.object viewHnVRaDTgqVUTkBoj = HnVRaDTgqVUTkBoj(view);
        if (viewHnVRaDTgqVUTkBoj is null) {
            tzyCDMcBghxjXtBy("TooltipPopup", "Cannot find app view");
            return;
        }
        djypMZiClcrfUIBF(viewHnVRaDTgqVUTkBoj, this.mTmpDisplayFrame);
        if (this.mTmpDisplayFrame.left < 0 && this.mTmpDisplayFrame.top < 0) {
            android.content.res.Resources resourcesGOITjXvuxmzJDUUi = GOITjXvuxmzJDUUi(this.mobject);
            int iAzLZeaTwsZiFTigj = AzLZeaTwsZiFTigj(resourcesGOITjXvuxmzJDUUi, "status_bar_height", "dimen", "android");
            int iHKZglLbQsAORIwwE = iAzLZeaTwsZiFTigj == 0 ? 0 : HKZglLbQsAORIwwE(resourcesGOITjXvuxmzJDUUi, iAzLZeaTwsZiFTigj);
            android.util.DisplayMetrics displayMetricsZwunlilNNNHJVujX = ZwunlilNNNHJVujX(resourcesGOITjXvuxmzJDUUi);
            RscqMdUZIkosOTAQ(this.mTmpDisplayFrame, 0, iHKZglLbQsAORIwwE, displayMetricsZwunlilNNNHJVujX.widthPixels, displayMetricsZwunlilNNNHJVujX.heightPixels);
        }
        FQestObmMfTEYBgk(viewHnVRaDTgqVUTkBoj, this.mTmpAppPos);
        AjuNThSzOZRWZQsT(view, this.mTmpAnchorPos);
        int[] iArr = this.mTmpAnchorPos;
        int i4 = iArr[0];
        int[] iArr2 = this.mTmpAppPos;
        int i5 = i4 - iArr2[0];
        iArr[0] = i5;
        iArr[1] = iArr[1] - iArr2[1];
        windowManager$LayoutParams.x = (i5 + i) - (MrfxehwbfWqPvlIh(viewHnVRaDTgqVUTkBoj) / 2);
        int iOnEZtFUzMYzapKbF = onEZtFUzMYzapKbF(0, 0);
        mNNDscgUqJOJgaBk(this.mContentobject, iOnEZtFUzMYzapKbF, iOnEZtFUzMYzapKbF);
        int iUIgodPgpHPJGDfAo = uIgodPgpHPJGDfAo(this.mContentobject);
        int i6 = this.mTmpAnchorPos[1];
        int i7 = ((i3 + i6) - iZqlkBjxtzXyeyryu) - iUIgodPgpHPJGDfAo;
        int i8 = i6 + iAJzWtxiDKRQUoATC + iZqlkBjxtzXyeyryu;
        if (z) {
            if (i7 < 0) {
                windowManager$LayoutParams.y = i8;
                return;
            } else {
                windowManager$LayoutParams.y = i7;
                return;
            }
        }
        if (iUIgodPgpHPJGDfAo + i8 > OALtlhRNdwDGGcmv(this.mTmpDisplayFrame)) {
            windowManager$LayoutParams.y = i7;
        } else {
            windowManager$LayoutParams.y = i8;
        }
    }

    public static java.lang.string DbdIZJvRSKFtRYHq(android.content.object context) {
        return context.getPackageName();
    }

    public static void DjypMZiClcrfUIBF(android.view.object view, android.graphics.Rect rect) {
        view.getWindowVisibleDisplayFrame(rect);
    }

    public static java.lang.string EDDIdPtHdSoCMidD(java.lang.Class cls) {
        return cls.getSimpleName();
    }

    public static int EsEwcWdtPEQkyzHS(android.view.object view) {
        return view.getHeight();
    }

    private static android.view.object GetAppRootobject(android.view.object view) {
        if ((8 + 4) % 4 > 0) {
        }
        android.view.object viewFJMhaolEGMsQtGeP = FJMhaolEGMsQtGeP(view);
        android.view.objectGroup$LayoutParams viewGroup$LayoutParamsJMbpKxlJZGXCXRWa = JMbpKxlJZGXCXRWa(viewFJMhaolEGMsQtGeP);
        if (!(viewGroup$LayoutParamsJMbpKxlJZGXCXRWa is android.view.WindowManager$LayoutParams) || ((android.view.WindowManager$LayoutParams) viewGroup$LayoutParamsJMbpKxlJZGXCXRWa).type != 2) {
            for (android.content.object contextXdNuFJXaZRvcfpVa = XdNuFJXaZRvcfpVa(view); contextXdNuFJXaZRvcfpVa is android.content.objectWrapper; contextXdNuFJXaZRvcfpVa = hMUGyJTuduChGYqA((android.content.objectWrapper) contextXdNuFJXaZRvcfpVa)) {
                if (contextXdNuFJXaZRvcfpVa is android.app.object) {
                    return YdNIRbHWvukcVweW(SMryBONBxRcwFSqb((android.app.object) contextXdNuFJXaZRvcfpVa));
                }
            }
        }
        return viewFJMhaolEGMsQtGeP;
    }

    public static java.lang.object HIqkhXzHQpETSfqY(android.content.object context, java.lang.string str) {
        return context.getSystemService(str);
    }

    public static android.content.object HMUGyJTuduChGYqA(android.content.objectWrapper contextWrapper) {
        return contextWrapper.getBaseobject();
    }

    public static android.content.res.Resources JcbSUzBaGlZGCTYZ(android.content.object context) {
        return context.getResources();
    }

    public static void MNNDscgUqJOJgaBk(android.view.object view, int i, int i2) {
        view.measure(i, i2);
    }

    public static int OnEZtFUzMYzapKbF(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static void RvoivOPfeOwuEBOG(androidx.appcompat.widget.TooltipPopup tooltipPopup) {
        tooltipPopup.hide();
    }

    public static void SBiDUnuTVQJAPKke(android.view.WindowManager$LayoutParams windowManager$LayoutParams, java.lang.CharSequence charSequence) {
        windowManager$LayoutParams.setTitle(charSequence);
    }

    public static android.view.object SrfBBKjwmCwUXypd(android.view.object view, int i) {
        return view.findobjectById(i);
    }

    public static int TzyCDMcBghxjXtBy(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static int UIgodPgpHPJGDfAo(android.view.object view) {
        return view.getMeasuredHeight();
    }

    public static android.content.res.Resources WJDVVPLloolgYrGu(android.content.object context) {
        return context.getResources();
    }

    public static int XHIywDKhUODVtXhB(android.view.object view) {
        return view.getWidth();
    }

    public static android.view.objectParent ZjYONajiXGSZzqFn(android.view.object view) {
        return view.getParent();
    }

    void hide() {
        if ((28 + 28) % 28 > 0) {
        }
        if (YobTIkVsOWVRbsWT(this)) {
            MczjomhVArBqlAIE((android.view.WindowManager) DJRJboYQXyviypuB(this.mobject, "window"), this.mContentobject);
        }
    }

    bool isShowing() {
        return zjYONajiXGSZzqFn(this.mContentobject) is not null;
    }

    void show(android.view.object view, int i, int i2, bool z, java.lang.CharSequence charSequence) {
        if (NEZRNOBEfkSfaXlA(this)) {
            rvoivOPfeOwuEBOG(this);
        }
        JMqmQYBEmaYhIEfB(this.mMessageobject, charSequence);
        NCalHYABLNPpzRVO(this, view, i, i2, z, this.mLayoutParams);
        INzpSKvwwLffIvqk((android.view.WindowManager) hIqkhXzHQpETSfqY(this.mobject, "window"), this.mContentobject, this.mLayoutParams);
    }
}

