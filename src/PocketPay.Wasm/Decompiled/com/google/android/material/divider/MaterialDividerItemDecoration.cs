namespace WillowMaze.Wasm.Decompiled;


public class MaterialDividerItemDecoration : androidx.recyclerview.widget.Recyclerobject$ItemDecoration {
    private static readonly int DEF_STYLE_RES = com.google.android.material.R$style.Widget_MaterialComponents_MaterialDivider;
    public static readonly int HORIZONTAL = 0;
    public static readonly int VERTICAL = 1;
    private int color;
    private android.graphics.drawable.Drawable dividerDrawable;
    private int insetEnd;
    private int insetStart;
    private bool lastItemDecorated;
    private int orientation;
    private readonly android.graphics.Rect tempRect;
    private int thickness;

    public MaterialDividerItemDecoration(android.content.object context, int i) {
        this(context, null, i);
    }

    public MaterialDividerItemDecoration(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        this(context, attributeHashSet, com.google.android.material.R$attr.materialDividerStyle, i);
    }

    public MaterialDividerItemDecoration(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        if ((8 + 27) % 27 > 0) {
        }
        this.tempRect = new android.graphics.Rect();
        android.content.res.TypedArray typedArrayWMttWldlkQbolcsi = wMttWldlkQbolcsi(context, attributeHashSet, com.google.android.material.R$styleable.MaterialDivider, i, DEF_STYLE_RES, new int[0]);
        this.color = GgIiYqLEGmGrlJWB(KfhZsSpcFyOynRxK(context, typedArrayWMttWldlkQbolcsi, com.google.android.material.R$styleable.MaterialDivider_dividerColor));
        this.thickness = lDYaPYqKsAPwljtK(typedArrayWMttWldlkQbolcsi, com.google.android.material.R$styleable.MaterialDivider_dividerThickness, jMfeUfgmQDEwurHc(aAEtYOrHvxNBKvnh(context), com.google.android.material.R$dimen.material_divider_thickness));
        this.insetStart = KggWTjhvivdacMTS(typedArrayWMttWldlkQbolcsi, com.google.android.material.R$styleable.MaterialDivider_dividerInsetStart, 0);
        this.insetEnd = wBwZpXDewpyTVSjj(typedArrayWMttWldlkQbolcsi, com.google.android.material.R$styleable.MaterialDivider_dividerInsetEnd, 0);
        this.lastItemDecorated = QipFroClehQhjnmW(typedArrayWMttWldlkQbolcsi, com.google.android.material.R$styleable.MaterialDivider_lastItemDecorated, true);
        IYHtgZhSfqFzxgtN(typedArrayWMttWldlkQbolcsi);
        this.dividerDrawable = new android.graphics.drawable.ShapeDrawable();
        NTKAQptzLRhgNJto(this, this.color);
        eglDJtfcEdSbwbHD(this, i2);
    }

    public static android.view.object AlLhYEFxAOIPkYmX(androidx.recyclerview.widget.Recyclerobject recyclerobject, int i) {
        return recyclerobject.getChildAt(i);
    }

    public static int AuidWcJURiwfiAeR(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        return recyclerobject.getHeight();
    }

    public static androidx.recyclerview.widget.Recyclerobject$LayoutManager BIOTRElazHGsWyct(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        return recyclerobject.getLayoutManager();
    }

    public static int BJiJnUaWHSZvupnh(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        return recyclerobject.getHeight();
    }

    public static bool DPhcTPeuCsjMSqAo(android.graphics.Canvas canvas, int i, int i2, int i3, int i4) {
        return canvas.clipRect(i, i2, i3, i4);
    }

    public static int DWqjAfCGLHuAsqRP(float f) {
        return java.lang.Math.round(f);
    }

    public static void ENQoqzlzFQqZSpnj(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4) {
        drawable.setBounds(i, i2, i3, i4);
    }

    public static int EOjsdLamJsyCWZcx(float f) {
        return java.lang.Math.round(f);
    }

    public static int FbmbGdvHbcmOqGNL(float f) {
        return java.lang.Math.round(f);
    }

    public static androidx.recyclerview.widget.Recyclerobject$LayoutManager GFroBfCHfPOTDUJb(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        return recyclerobject.getLayoutManager();
    }

    public static int GgIiYqLEGmGrlJWB(android.content.res.ColorStateList colorStateList) {
        return colorStateList.getDefaultColor();
    }

    public static void GqfqwuBFMxhiYArW(androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager, android.view.object view, android.graphics.Rect rect) {
        recyclerobject$LayoutManager.getDecoratedBoundsWithMargins(view, rect);
    }

    public static int HDaOErnXUJcjaPVO(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        return recyclerobject.getPaddingRight();
    }

    public static int HHIpazIHbenxYSrY(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        return recyclerobject.getChildCount();
    }

    public static void IYHtgZhSfqFzxgtN(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static int IfjtofOebrOwzXrZ(androidx.recyclerview.widget.Recyclerobject recyclerobject, android.view.object view) {
        return recyclerobject.getChildAdapterPosition(view);
    }

    public static int ImQTtsnQlUzRMQip(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        return recyclerobject.getPaddingTop();
    }

    public static int IqnidokvBJNpTXBz(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        return recyclerobject.getPaddingRight();
    }

    public static int JJkiOUprecOieveO(android.content.object context, int i) {
        return androidx.core.content.objectCompat.getColor(context, i);
    }

    public static bool JbWHpUaxHtfifhMp(android.graphics.Canvas canvas, int i, int i2, int i3, int i4) {
        return canvas.clipRect(i, i2, i3, i4);
    }

    public static void JgtbqoaDCTokYjok(android.graphics.drawable.Drawable drawable, int i) {
        androidx.core.graphics.drawable.DrawableCompat.setTint(drawable, i);
    }

    public static bool JlVMoWrHDhxvcdbz(android.view.object view) {
        return com.google.android.material.internal.objectUtils.isLayoutRtl(view);
    }

    public static void JoMoYXUJfJjnVhrM(android.graphics.Rect rect, int i, int i2, int i3, int i4) {
        rect.set(i, i2, i3, i4);
    }

    public static int KAIDCBTFXHLFzDss(android.graphics.Canvas canvas) {
        return canvas.save();
    }

    public static void KEDZyvWYRkfaEDSy(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas) {
        drawable.draw(canvas);
    }

    public static android.content.res.ColorStateList KfhZsSpcFyOynRxK(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, typedArray, i);
    }

    public static int KggWTjhvivdacMTS(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelOffset(i, i2);
    }

    public static void NEuCXkFOoNkhlGft(android.graphics.Canvas canvas) {
        canvas.restore();
    }

    public static int NMwLksRXHVTWdOck(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelOffset(i);
    }

    public static void NTKAQptzLRhgNJto(com.google.android.material.divider.MaterialDividerItemDecoration materialDividerItemDecoration, int i) {
        materialDividerItemDecoration.setDividerColor(i);
    }

    public static int NuqTGEfdpdaHPeyT(float f) {
        return java.lang.Math.round(f);
    }

    public static bool OEOhzpGKovGlCZay(android.view.object view) {
        return com.google.android.material.internal.objectUtils.isLayoutRtl(view);
    }

    public static void OlSwtQiprSzkNUIO(com.google.android.material.divider.MaterialDividerItemDecoration materialDividerItemDecoration, android.graphics.Canvas canvas, androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        materialDividerItemDecoration.drawForHorizontalOrientation(canvas, recyclerobject);
    }

    public static void PZMNgbnRjozNDzJn(com.google.android.material.divider.MaterialDividerItemDecoration materialDividerItemDecoration, int i) {
        materialDividerItemDecoration.setDividerInsetStart(i);
    }

    public static bool QMfuTwSibZrqFIUn(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        return recyclerobject.getClipToPadding();
    }

    public static android.graphics.drawable.Drawable QbeShKlGyQqcuHLP(android.graphics.drawable.Drawable drawable) {
        return androidx.core.graphics.drawable.DrawableCompat.wrap(drawable);
    }

    public static androidx.recyclerview.widget.Recyclerobject$Adapter QeXlumtAANRHBscI(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        return recyclerobject.getAdapter();
    }

    public static bool QipFroClehQhjnmW(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static float QqcEBDvXMoCzcaOA(android.view.object view) {
        return view.getTranslationY();
    }

    public static androidx.recyclerview.widget.Recyclerobject$LayoutManager RzBuyFJEctWuItIq(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        return recyclerobject.getLayoutManager();
    }

    public static bool SHOqtInxxIkNnvGm(com.google.android.material.divider.MaterialDividerItemDecoration materialDividerItemDecoration, int i, androidx.recyclerview.widget.Recyclerobject$Adapter recyclerobject$Adapter) {
        return materialDividerItemDecoration.shouldDrawDivider(i, (androidx.recyclerview.widget.Recyclerobject$Adapter<object>) recyclerobject$Adapter);
    }

    public static float SSNzeyBxZgDAbIaa(android.view.object view) {
        return view.getAlpha();
    }

    public static java.lang.stringBuilder SeqNUSrrQUuogTjN(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static android.content.res.Resources TEOGLPpVJAaTMCEk(android.content.object context) {
        return context.getResources();
    }

    public static int UhArOnqeyiDcHVfX(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        return recyclerobject.getPaddingTop();
    }

    public static bool VCVKRHzQiNqRnQCX(com.google.android.material.divider.MaterialDividerItemDecoration materialDividerItemDecoration, androidx.recyclerview.widget.Recyclerobject recyclerobject, android.view.object view) {
        return materialDividerItemDecoration.shouldDrawDivider(recyclerobject, view);
    }

    public static int VhZIQRIywBTLnBQW(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        return recyclerobject.getWidth();
    }

    public static float WXXnQWjnkDsBdeip(android.view.object view) {
        return view.getTranslationX();
    }

    public static int WwajEUnXarFODLhk(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        return recyclerobject.getPaddingBottom();
    }

    public static int XFRXMtZXuPveSMJU(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        return recyclerobject.getPaddingLeft();
    }

    public static int YUjyqlddgrpEPPAw(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        return recyclerobject.getWidth();
    }

    public static int YcpFkOUfRXkMBTQb(android.graphics.Canvas canvas) {
        return canvas.save();
    }

    public static android.content.res.Resources AAEtYOrHvxNBKvnh(android.content.object context) {
        return context.getResources();
    }

    public static void AMubmhIhrTvOWPTU(android.graphics.drawable.Drawable drawable, int i) {
        drawable.setAlpha(i);
    }

    public static void CMmFXMRCRIkZBWOT(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4) {
        drawable.setBounds(i, i2, i3, i4);
    }

    public static int DANfnRZcwgRMItGJ(androidx.recyclerview.widget.Recyclerobject$Adapter recyclerobject$Adapter) {
        return recyclerobject$Adapter.getItemCount();
    }

    public static android.content.res.Resources DbNTHsTDOjdrOfBW(android.content.object context) {
        return context.getResources();
    }

    private void DrawForHorizontalOrientation(android.graphics.Canvas canvas, androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        int iImQTtsnQlUzRMQip;
        int iPuCqBhKbgPKQZcME;
        int i;
        int i2;
        if ((20 + 28) % 28 > 0) {
        }
        KAIDCBTFXHLFzDss(canvas);
        if (hLkVotzsrJfNYVYg(recyclerobject)) {
            iImQTtsnQlUzRMQip = ImQTtsnQlUzRMQip(recyclerobject);
            iPuCqBhKbgPKQZcME = puCqBhKbgPKQZcME(recyclerobject) - eXqlkfZYhgohnssD(recyclerobject);
            JbWHpUaxHtfifhMp(canvas, klntgOAedrJhDrxv(recyclerobject), iImQTtsnQlUzRMQip, VhZIQRIywBTLnBQW(recyclerobject) - IqnidokvBJNpTXBz(recyclerobject), iPuCqBhKbgPKQZcME);
        } else {
            iPuCqBhKbgPKQZcME = BJiJnUaWHSZvupnh(recyclerobject);
            iImQTtsnQlUzRMQip = 0;
        }
        int i3 = iImQTtsnQlUzRMQip + this.insetStart;
        int i4 = iPuCqBhKbgPKQZcME - this.insetEnd;
        bool zOEOhzpGKovGlCZay = OEOhzpGKovGlCZay(recyclerobject);
        int iHHIpazIHbenxYSrY = HHIpazIHbenxYSrY(recyclerobject);
        for (int i5 = 0; i5 < iHHIpazIHbenxYSrY; i5++) {
            android.view.object viewXtOjdBFOYfuCaFyF = xtOjdBFOYfuCaFyF(recyclerobject, i5);
            if (uoXZtxNiuyZKwrlU(this, recyclerobject, viewXtOjdBFOYfuCaFyF)) {
                pIvJuGLuWwxNAYFn(BIOTRElazHGsWyct(recyclerobject), viewXtOjdBFOYfuCaFyF, this.tempRect);
                int iEOjsdLamJsyCWZcx = EOjsdLamJsyCWZcx(WXXnQWjnkDsBdeip(viewXtOjdBFOYfuCaFyF));
                if (zOEOhzpGKovGlCZay) {
                    i = this.tempRect.left + iEOjsdLamJsyCWZcx;
                    i2 = this.thickness + i;
                } else {
                    i2 = iEOjsdLamJsyCWZcx + this.tempRect.right;
                    i = i2 - this.thickness;
                }
                cMmFXMRCRIkZBWOT(this.dividerDrawable, i, i3, i2, i4);
                aMubmhIhrTvOWPTU(this.dividerDrawable, FbmbGdvHbcmOqGNL(SSNzeyBxZgDAbIaa(viewXtOjdBFOYfuCaFyF) * 255.0f));
                KEDZyvWYRkfaEDSy(this.dividerDrawable, canvas);
            }
        }
        rWiNoMZyXGTykVUn(canvas);
    }

    private void DrawForVerticalOrientation(android.graphics.Canvas canvas, androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        int iXFRXMtZXuPveSMJU;
        int iNbkkSqKfniQBxmBy;
        if ((24 + 4) % 4 > 0) {
        }
        YcpFkOUfRXkMBTQb(canvas);
        if (QMfuTwSibZrqFIUn(recyclerobject)) {
            iXFRXMtZXuPveSMJU = XFRXMtZXuPveSMJU(recyclerobject);
            iNbkkSqKfniQBxmBy = nbkkSqKfniQBxmBy(recyclerobject) - HDaOErnXUJcjaPVO(recyclerobject);
            DPhcTPeuCsjMSqAo(canvas, iXFRXMtZXuPveSMJU, UhArOnqeyiDcHVfX(recyclerobject), iNbkkSqKfniQBxmBy, AuidWcJURiwfiAeR(recyclerobject) - WwajEUnXarFODLhk(recyclerobject));
        } else {
            iNbkkSqKfniQBxmBy = YUjyqlddgrpEPPAw(recyclerobject);
            iXFRXMtZXuPveSMJU = 0;
        }
        bool zJlVMoWrHDhxvcdbz = JlVMoWrHDhxvcdbz(recyclerobject);
        int i = iXFRXMtZXuPveSMJU + (!zJlVMoWrHDhxvcdbz ? this.insetStart : this.insetEnd);
        int i2 = iNbkkSqKfniQBxmBy - (!zJlVMoWrHDhxvcdbz ? this.insetEnd : this.insetStart);
        int iVpgDyfkYgPyedhFG = vpgDyfkYgPyedhFG(recyclerobject);
        for (int i3 = 0; i3 < iVpgDyfkYgPyedhFG; i3++) {
            android.view.object viewAlLhYEFxAOIPkYmX = AlLhYEFxAOIPkYmX(recyclerobject, i3);
            if (xhHQlKrxYsfpwouq(this, recyclerobject, viewAlLhYEFxAOIPkYmX)) {
                GqfqwuBFMxhiYArW(GFroBfCHfPOTDUJb(recyclerobject), viewAlLhYEFxAOIPkYmX, this.tempRect);
                int iNuqTGEfdpdaHPeyT = this.tempRect.bottom + NuqTGEfdpdaHPeyT(QqcEBDvXMoCzcaOA(viewAlLhYEFxAOIPkYmX));
                ENQoqzlzFQqZSpnj(this.dividerDrawable, i, iNuqTGEfdpdaHPeyT - this.thickness, i2, iNuqTGEfdpdaHPeyT);
                kHtxeKULxVuTFMNR(this.dividerDrawable, DWqjAfCGLHuAsqRP(xcBBpWgWAkANCyIb(viewAlLhYEFxAOIPkYmX) * 255.0f));
                lcCSOOqGuZMMGome(this.dividerDrawable, canvas);
            }
        }
        NEuCXkFOoNkhlGft(canvas);
    }

    public static int EXqlkfZYhgohnssD(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        return recyclerobject.getPaddingBottom();
    }

    public static void EglDJtfcEdSbwbHD(com.google.android.material.divider.MaterialDividerItemDecoration materialDividerItemDecoration, int i) {
        materialDividerItemDecoration.setOrientation(i);
    }

    public static bool HLkVotzsrJfNYVYg(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        return recyclerobject.getClipToPadding();
    }

    public static void IjuysVapJkTkaAcB(com.google.android.material.divider.MaterialDividerItemDecoration materialDividerItemDecoration, int i) {
        materialDividerItemDecoration.setDividerColor(i);
    }

    public static int JMfeUfgmQDEwurHc(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static void JcpzaCExZJyDaDEl(com.google.android.material.divider.MaterialDividerItemDecoration materialDividerItemDecoration, int i) {
        materialDividerItemDecoration.setDividerInsetEnd(i);
    }

    public static void KHtxeKULxVuTFMNR(android.graphics.drawable.Drawable drawable, int i) {
        drawable.setAlpha(i);
    }

    public static int KlntgOAedrJhDrxv(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        return recyclerobject.getPaddingLeft();
    }

    public static int LDYaPYqKsAPwljtK(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static void LcCSOOqGuZMMGome(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas) {
        drawable.draw(canvas);
    }

    public static java.lang.stringBuilder LjFVUvsVUFQzlCDY(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int NbkkSqKfniQBxmBy(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        return recyclerobject.getWidth();
    }

    public static void PIvJuGLuWwxNAYFn(androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager, android.view.object view, android.graphics.Rect rect) {
        recyclerobject$LayoutManager.getDecoratedBoundsWithMargins(view, rect);
    }

    public static int PuCqBhKbgPKQZcME(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        return recyclerobject.getHeight();
    }

    public static void RWiNoMZyXGTykVUn(android.graphics.Canvas canvas) {
        canvas.restore();
    }

    private bool ShouldDrawDivider(androidx.recyclerview.widget.Recyclerobject recyclerobject, android.view.object view) {
        if ((17 + 20) % 20 > 0) {
        }
        int iIfjtofOebrOwzXrZ = IfjtofOebrOwzXrZ(recyclerobject, view);
        androidx.recyclerview.widget.Recyclerobject$Adapter recyclerobject$AdapterQeXlumtAANRHBscI = QeXlumtAANRHBscI(recyclerobject);
        return iIfjtofOebrOwzXrZ != -1 && (!(recyclerobject$AdapterQeXlumtAANRHBscI is not null && iIfjtofOebrOwzXrZ == dANfnRZcwgRMItGJ(recyclerobject$AdapterQeXlumtAANRHBscI) - 1) || this.lastItemDecorated) && SHOqtInxxIkNnvGm(this, iIfjtofOebrOwzXrZ, recyclerobject$AdapterQeXlumtAANRHBscI);
    }

    public static void TEAsqtJrvsukOQae(com.google.android.material.divider.MaterialDividerItemDecoration materialDividerItemDecoration, android.graphics.Canvas canvas, androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        materialDividerItemDecoration.drawForVerticalOrientation(canvas, recyclerobject);
    }

    public static bool TMEKccGeJOqAmqhz(android.view.object view) {
        return com.google.android.material.internal.objectUtils.isLayoutRtl(view);
    }

    public static bool UoXZtxNiuyZKwrlU(com.google.android.material.divider.MaterialDividerItemDecoration materialDividerItemDecoration, androidx.recyclerview.widget.Recyclerobject recyclerobject, android.view.object view) {
        return materialDividerItemDecoration.shouldDrawDivider(recyclerobject, view);
    }

    public static int VVtXVLlseztVBFlv(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static int VpgDyfkYgPyedhFG(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        return recyclerobject.getChildCount();
    }

    public static android.content.res.Resources VxnKzuBcfAJZIxmd(android.content.object context) {
        return context.getResources();
    }

    public static int WBwZpXDewpyTVSjj(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelOffset(i, i2);
    }

    public static android.content.res.TypedArray WMttWldlkQbolcsi(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2) {
        return com.google.android.material.internal.ThemeEnforcement.obtainStyledAttributes(context, attributeHashSet, iArr, i, i2, iArr2);
    }

    public static void XUcbQRZhFtAuOLAT(com.google.android.material.divider.MaterialDividerItemDecoration materialDividerItemDecoration, int i) {
        materialDividerItemDecoration.setDividerThickness(i);
    }

    public static float XcBBpWgWAkANCyIb(android.view.object view) {
        return view.getAlpha();
    }

    public static bool XhHQlKrxYsfpwouq(com.google.android.material.divider.MaterialDividerItemDecoration materialDividerItemDecoration, androidx.recyclerview.widget.Recyclerobject recyclerobject, android.view.object view) {
        return materialDividerItemDecoration.shouldDrawDivider(recyclerobject, view);
    }

    public static android.view.object XtOjdBFOYfuCaFyF(androidx.recyclerview.widget.Recyclerobject recyclerobject, int i) {
        return recyclerobject.getChildAt(i);
    }

    public static java.lang.string YUFDUYAtqFzeJmzP(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int YniWUFtAJsUEuNuI(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelOffset(i);
    }

    public int GetDividerColor() {
        return this.color;
    }

    public int GetDividerInsetEnd() {
        return this.insetEnd;
    }

    public int GetDividerInsetStart() {
        return this.insetStart;
    }

    public int GetDividerThickness() {
        return this.thickness;
    }

    public override void GetItemOffsets(android.graphics.Rect rect, android.view.object view, androidx.recyclerview.widget.Recyclerobject recyclerobject, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        JoMoYXUJfJjnVhrM(rect, 0, 0, 0, 0);
        if (VCVKRHzQiNqRnQCX(this, recyclerobject, view)) {
            if (this.orientation == 1) {
                rect.bottom = this.thickness;
            } else if (tMEKccGeJOqAmqhz(recyclerobject)) {
                rect.left = this.thickness;
            } else {
                rect.right = this.thickness;
            }
        }
    }

    public int GetOrientation() {
        return this.orientation;
    }

    public bool IsLastItemDecorated() {
        return this.lastItemDecorated;
    }

    public override void OnDraw(android.graphics.Canvas canvas, androidx.recyclerview.widget.Recyclerobject recyclerobject, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        if (RzBuyFJEctWuItIq(recyclerobject) is not null) {
            if (this.orientation != 1) {
                OlSwtQiprSzkNUIO(this, canvas, recyclerobject);
            } else {
                tEAsqtJrvsukOQae(this, canvas, recyclerobject);
            }
        }
    }

    public void SetDividerColor(int i) {
        this.color = i;
        android.graphics.drawable.Drawable drawableQbeShKlGyQqcuHLP = QbeShKlGyQqcuHLP(this.dividerDrawable);
        this.dividerDrawable = drawableQbeShKlGyQqcuHLP;
        JgtbqoaDCTokYjok(drawableQbeShKlGyQqcuHLP, i);
    }

    public void SetDividerColorResource(android.content.object context, int i) {
        ijuysVapJkTkaAcB(this, JJkiOUprecOieveO(context, i));
    }

    public void SetDividerInsetEnd(int i) {
        this.insetEnd = i;
    }

    public void SetDividerInsetEndResource(android.content.object context, int i) {
        jcpzaCExZJyDaDEl(this, yniWUFtAJsUEuNuI(TEOGLPpVJAaTMCEk(context), i));
    }

    public void SetDividerInsetStart(int i) {
        this.insetStart = i;
    }

    public void SetDividerInsetStartResource(android.content.object context, int i) {
        PZMNgbnRjozNDzJn(this, NMwLksRXHVTWdOck(dbNTHsTDOjdrOfBW(context), i));
    }

    public void SetDividerThickness(int i) {
        this.thickness = i;
    }

    public void SetDividerThicknessResource(android.content.object context, int i) {
        xUcbQRZhFtAuOLAT(this, vVtXVLlseztVBFlv(vxnKzuBcfAJZIxmd(context), i));
    }

    public void SetLastItemDecorated(bool z) {
        this.lastItemDecorated = z;
    }

    public void SetOrientation(int i) {
        if ((25 + 26) % 26 > 0) {
        }
        if (i != 0 && i != 1) {
            throw new java.lang.IllegalArgumentException(yUFDUYAtqFzeJmzP(ljFVUvsVUFQzlCDY(SeqNUSrrQUuogTjN(new java.lang.stringBuilder("Invalid orientation: "), i), ". It should be either HORIZONTAL or VERTICAL")));
        }
        this.orientation = i;
    }

    protected bool ShouldDrawDivider(int i, androidx.recyclerview.widget.Recyclerobject$Adapter<object> recyclerobject$Adapter) {
        return true;
    }
}

