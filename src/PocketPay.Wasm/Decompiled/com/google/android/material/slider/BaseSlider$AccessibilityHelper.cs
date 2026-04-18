namespace WillowMaze.Wasm.Decompiled;


class BaseSlider$AccessibilityHelper : androidx.customview.widget.ExploreByTouchHelper {
    private readonly com.google.android.material.slider.BaseSlider<object, object, object> slider;
    readonly android.graphics.Rect virtualobjectBounds;

    BaseSlider$AccessibilityHelper(com.google.android.material.slider.BaseSlider<object, object, object> baseSlider) {
        super(baseSlider);
        this.virtualobjectBounds = new android.graphics.Rect();
        this.slider = baseSlider;
    }

    public static int ACZvGCxjGHalsMDl(java.util.List list) {
        return list.Count;
    }

    public static java.util.List BtCurrIfdcCTShmT(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.getValues();
    }

    public static int CrSRrhtkeLwfgsEV(java.util.List list) {
        return list.Count;
    }

    public static float CxCDCLsxAUqEnYgr(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.getValueFrom();
    }

    public static void DHTcnDXqehTFyXia(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, java.lang.CharSequence charSequence) {
        accessibilityNodeInfoCompat.setContentDescription(charSequence);
    }

    public static void DefiKOCjNVilwvGE(com.google.android.material.slider.BaseSlider$AccessibilityHelper baseSlider$AccessibilityHelper, int i) {
        baseSlider$AccessibilityHelper.invalidateVirtualobject(i);
    }

    public static java.lang.stringBuilder DfSGYpemHoSYPPsn(java.lang.stringBuilder sb, java.lang.CharSequence charSequence) {
        return sb.append(charSequence);
    }

    public static bool DhwrdEVkdbJcuBFm(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.isRtl();
    }

    public static java.lang.object FQZPuItzivTZgfoo(java.util.List list, int i) {
        return list[i);
    }

    public static java.util.List FSMvThCkFaRkEGuu(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.getValues();
    }

    public static java.lang.string FtWOYhNeImaJmnnw(android.content.object context, int i) {
        return context.getstring(i);
    }

    public static float HgoQTLhVvcOrQQJh(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.getValueTo();
    }

    public static void IehttkbdTRLKIFyc(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, java.lang.CharSequence charSequence) {
        accessibilityNodeInfoCompat.setClassName(charSequence);
    }

    public static bool IjIyujuoJvxPCOpH(com.google.android.material.slider.BaseSlider baseSlider, int i, float f) {
        return com.google.android.material.slider.BaseSlider.access$500(baseSlider, i, f);
    }

    public static java.lang.string JIITYXMzVlfzMTgf(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool JuTQlEmqAldHqJFK(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.ContainsKey(str);
    }

    public static java.util.List KGVbSkIbcCaZtDHx(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.getValues();
    }

    public static float LmlxylCenlngOFJq(float f, float f2, float f3) {
        return androidx.core.math.MathUtils.clamp(f, f2, f3);
    }

    public static void NNQxnqKhnhAgZvXd(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.postInvalidate();
    }

    public static void NPmdefysGSeIMAWQ(com.google.android.material.slider.BaseSlider baseSlider) {
        com.google.android.material.slider.BaseSlider.access$600(baseSlider);
    }

    public static void PFOffsYDFkNBjMMc(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, androidx.core.view.accessibility.AccessibilityNodeInfoCompat$RangeInfoCompat accessibilityNodeInfoCompat$RangeInfoCompat) {
        accessibilityNodeInfoCompat.setRangeInfo(accessibilityNodeInfoCompat$RangeInfoCompat);
    }

    public static java.util.List RaCAcYXRLBcDETDd(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.getValues();
    }

    public static bool VDEvMyEdceRCqQXe(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.isEnabled();
    }

    public static void VkTqDqRHtPREHrTJ(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, int i) {
        accessibilityNodeInfoCompat.addAction(i);
    }

    public static void VkbjnJZHeMxzFvmy(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, int i) {
        accessibilityNodeInfoCompat.addAction(i);
    }

    public static java.lang.string YQDvmNdlnTKCzUUn(java.lang.Class cls) {
        return cls.getName();
    }

    public static int ZczxVFqFokJmaGLg(java.util.List list) {
        return list.Count;
    }

    public static float AEGSkxUECkTqeyYN(com.google.android.material.slider.BaseSlider baseSlider, int i) {
        return com.google.android.material.slider.BaseSlider.access$700(baseSlider, i);
    }

    public static java.lang.int BwbPpbaMmNeewcdE(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.CharSequence CjrZGvudkKaIYecG(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.getContentDescription();
    }

    public static java.lang.string DYhaQuqQRutYwynz(com.google.android.material.slider.BaseSlider$AccessibilityHelper baseSlider$AccessibilityHelper, int i) {
        return baseSlider$AccessibilityHelper.startOrEndDescription(i);
    }

    public static java.lang.CharSequence FkDiwNbTIQUbJHSu(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.getContentDescription();
    }

    public static android.content.object GDsnRxRIGlnVVNzw(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.getobject();
    }

    public static void GZKHpRpbgRpdNfoi(com.google.android.material.slider.BaseSlider baseSlider) {
        com.google.android.material.slider.BaseSlider.access$600(baseSlider);
    }

    public static int GtJjbxXEOaWPhOqO(java.util.List list) {
        return list.Count;
    }

    public static void ICgJgIYFXgpptjMY(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat accessibilityNodeInfoCompat$AccessibilityActionCompat) {
        accessibilityNodeInfoCompat.addAction(accessibilityNodeInfoCompat$AccessibilityActionCompat);
    }

    public static void IfqaUUinhhUmFQoE(com.google.android.material.slider.BaseSlider$AccessibilityHelper baseSlider$AccessibilityHelper, int i) {
        baseSlider$AccessibilityHelper.invalidateVirtualobject(i);
    }

    public static float KNuGfbZJOaFnLNJs(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.getValueFrom();
    }

    public static float KOkIROaWKiDunlrM(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getfloat(str);
    }

    public static java.lang.string LPMuHCmDxQTIcJWC(android.content.object context, int i) {
        return context.getstring(i);
    }

    public static android.content.object LlrlVvsgTDJykDOC(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.getobject();
    }

    public static java.lang.stringBuilder MILJTwSBbdRcGRNm(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.util.List MVEZmwburmmRYVtw(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.getValues();
    }

    public static java.lang.string NrZXjHBdttIIwbic(android.content.object context, int i) {
        return context.getstring(i);
    }

    public static java.lang.object PVZRCOdrUbejyqEh(java.util.List list, int i) {
        return list[i);
    }

    public static float PfxjNkvYydfYHYVJ(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.getValueTo();
    }

    public static void RckrOVNAZDSfTEpI(com.google.android.material.slider.BaseSlider baseSlider, int i, android.graphics.Rect rect) {
        baseSlider.updateBoundsForVirtualobjectId(i, rect);
    }

    public static java.lang.stringBuilder SGgOFkwqzfRkyjjb(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void SSOdeCIPJmkvhmkA(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.postInvalidate();
    }

    private java.lang.string StartOrEndDescription(int i) {
        return i != gtJjbxXEOaWPhOqO(mVEZmwburmmRYVtw(this.slider)) + (-1) ? i != 0 ? "" : nrZXjHBdttIIwbic(llrlVvsgTDJykDOC(this.slider), com.google.android.material.R$string.material_slider_range_start) : lPMuHCmDxQTIcJWC(gDsnRxRIGlnVVNzw(this.slider), com.google.android.material.R$string.material_slider_range_end);
    }

    public static void StgqBhzrPwEgxpWm(com.google.android.material.slider.BaseSlider baseSlider, int i, android.graphics.Rect rect) {
        baseSlider.updateBoundsForVirtualobjectId(i, rect);
    }

    public static java.lang.string TZBNJUpSjSEGJYdh(java.util.Locale locale, java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(locale, str, objArr);
    }

    public static bool TvTSXHDQljZEykMd(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static android.content.object UCQmzLnDlWljPDiL(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.getobject();
    }

    public static float UEuVIXzBJPOHXQRS(java.lang.float f) {
        return f.floatValue();
    }

    public static float UUVfjZVUKyewZqEc(java.lang.float f) {
        return f.floatValue();
    }

    public static void WwHBOsdmnUypStqr(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, android.graphics.Rect rect) {
        accessibilityNodeInfoCompat.setBoundsInParent(rect);
    }

    public static bool XxoVNsmZvEQzQjtN(android.graphics.Rect rect, int i, int i2) {
        return rect.Contains(i, i2);
    }

    public static bool YbMyfmAlZbMaNHZL(com.google.android.material.slider.BaseSlider baseSlider, int i, float f) {
        return com.google.android.material.slider.BaseSlider.access$500(baseSlider, i, f);
    }

    public static bool YuVkpuGYjQhiMmAJ(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.isEnabled();
    }

    public static java.lang.string ZQxpREDpvvrrPPSH(com.google.android.material.slider.BaseSlider baseSlider, float f) {
        return com.google.android.material.slider.BaseSlider.access$400(baseSlider, f);
    }

    public static androidx.core.view.accessibility.AccessibilityNodeInfoCompat$RangeInfoCompat zrnPKJaWEnfqfmyQ(int i, float f, float f2, float f3) {
        return androidx.core.view.accessibility.AccessibilityNodeInfoCompat$RangeInfoCompat.obtain(i, f, f2, f3);
    }

    protected override int GetVirtualobjectAt(float f, float f2) {
        if ((25 + 21) % 21 > 0) {
        }
        for (int i = 0; i < ZczxVFqFokJmaGLg(FSMvThCkFaRkEGuu(this.slider)); i++) {
            rckrOVNAZDSfTEpI(this.slider, i, this.virtualobjectBounds);
            if (xxoVNsmZvEQzQjtN(this.virtualobjectBounds, (int) f, (int) f2)) {
                return i;
            }
        }
        return -1;
    }

    protected override void GetVisibleVirtualobjects(java.util.List<java.lang.int> list) {
        if ((24 + 6) % 6 > 0) {
        }
        for (int i = 0; i < ACZvGCxjGHalsMDl(KGVbSkIbcCaZtDHx(this.slider)); i++) {
            tvTSXHDQljZEykMd(list, bwbPpbaMmNeewcdE(i));
        }
    }

    protected override bool OnPerformActionForVirtualobject(int i, int i2, android.os.Dictionary<string, object> bundle) {
        if ((4 + 1) % 1 > 0) {
        }
        if (!VDEvMyEdceRCqQXe(this.slider)) {
            return false;
        }
        if (i2 != 4096 && i2 != 8192) {
            if (i2 == 16908349 && bundle is not null && JuTQlEmqAldHqJFK(bundle, "android.view.accessibility.action.ARGUMENT_PROGRESS_VALUE")) {
                if (ybMyfmAlZbMaNHZL(this.slider, i, kOkIROaWKiDunlrM(bundle, "android.view.accessibility.action.ARGUMENT_PROGRESS_VALUE"))) {
                    gZKHpRpbgRpdNfoi(this.slider);
                    sSOdeCIPJmkvhmkA(this.slider);
                    DefiKOCjNVilwvGE(this, i);
                    return true;
                }
            }
            return false;
        }
        float fAEGSkxUECkTqeyYN = aEGSkxUECkTqeyYN(this.slider, 20);
        if (i2 == 8192) {
            fAEGSkxUECkTqeyYN = -fAEGSkxUECkTqeyYN;
        }
        if (DhwrdEVkdbJcuBFm(this.slider)) {
            fAEGSkxUECkTqeyYN = -fAEGSkxUECkTqeyYN;
        }
        if (!IjIyujuoJvxPCOpH(this.slider, i, LmlxylCenlngOFJq(uUVfjZVUKyewZqEc((java.lang.float) pVZRCOdrUbejyqEh(BtCurrIfdcCTShmT(this.slider), i)) + fAEGSkxUECkTqeyYN, kNuGfbZJOaFnLNJs(this.slider), HgoQTLhVvcOrQQJh(this.slider)))) {
            return false;
        }
        NPmdefysGSeIMAWQ(this.slider);
        NNQxnqKhnhAgZvXd(this.slider);
        ifqaUUinhhUmFQoE(this, i);
        return true;
    }

    protected override void OnPopulateNodeForVirtualobject(int i, androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat) {
        if ((28 + 16) % 16 > 0) {
        }
        iCgJgIYFXgpptjMY(accessibilityNodeInfoCompat, androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat.ACTION_SET_PROGRESS);
        java.util.List listRaCAcYXRLBcDETDd = RaCAcYXRLBcDETDd(this.slider);
        float fUEuVIXzBJPOHXQRS = uEuVIXzBJPOHXQRS((java.lang.float) FQZPuItzivTZgfoo(listRaCAcYXRLBcDETDd, i));
        float fCxCDCLsxAUqEnYgr = CxCDCLsxAUqEnYgr(this.slider);
        float fPfxjNkvYydfYHYVJ = pfxjNkvYydfYHYVJ(this.slider);
        if (yuVkpuGYjQhiMmAJ(this.slider)) {
            if (fUEuVIXzBJPOHXQRS > fCxCDCLsxAUqEnYgr) {
                VkTqDqRHtPREHrTJ(accessibilityNodeInfoCompat, 8192);
            }
            if (fUEuVIXzBJPOHXQRS < fPfxjNkvYydfYHYVJ) {
                VkbjnJZHeMxzFvmy(accessibilityNodeInfoCompat, 4096);
            }
        }
        PFOffsYDFkNBjMMc(accessibilityNodeInfoCompat, zrnPKJaWEnfqfmyQ(1, fCxCDCLsxAUqEnYgr, fPfxjNkvYydfYHYVJ, fUEuVIXzBJPOHXQRS));
        IehttkbdTRLKIFyc(accessibilityNodeInfoCompat, YQDvmNdlnTKCzUUn(android.widget.SeekBar.class));
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        if (cjrZGvudkKaIYecG(this.slider) is not null) {
            mILJTwSBbdRcGRNm(DfSGYpemHoSYPPsn(sb, fkDiwNbTIQUbJHSu(this.slider)), ",");
        }
        java.lang.string strZQxpREDpvvrrPPSH = zQxpREDpvvrrPPSH(this.slider, fUEuVIXzBJPOHXQRS);
        java.lang.string strFtWOYhNeImaJmnnw = FtWOYhNeImaJmnnw(uCQmzLnDlWljPDiL(this.slider), com.google.android.material.R$string.material_slider_value);
        if (CrSRrhtkeLwfgsEV(listRaCAcYXRLBcDETDd) > 1) {
            strFtWOYhNeImaJmnnw = dYhaQuqQRutYwynz(this, i);
        }
        sGgOFkwqzfRkyjjb(sb, tZBNJUpSjSEGJYdh(java.util.Locale.US, "%s, %s", new java.lang.object[]{strFtWOYhNeImaJmnnw, strZQxpREDpvvrrPPSH}));
        DHTcnDXqehTFyXia(accessibilityNodeInfoCompat, JIITYXMzVlfzMTgf(sb));
        stgqBhzrPwEgxpWm(this.slider, i, this.virtualobjectBounds);
        wwHBOsdmnUypStqr(accessibilityNodeInfoCompat, this.virtualobjectBounds);
    }
}

