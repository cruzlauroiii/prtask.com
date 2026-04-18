namespace WillowMaze.Wasm.Decompiled;


class ClockFaceobject : com.google.android.material.timepicker.RadialobjectGroup : com.google.android.material.timepicker.ClockHandobject$OnRotateListener {
    private static readonly float EPSILON = 0.001f;
    private static readonly int INITIAL_CAPACITY = 12;
    private static readonly java.lang.string VALUE_PLACEHOLDER = "";
    private readonly int clockHandPadding;
    private readonly com.google.android.material.timepicker.ClockHandobject clockHandobject;
    private readonly int clockSize;
    private float currentHandRotation;
    private readonly int[] gradientColors;
    private readonly float[] gradientPositions;
    private readonly int minimumHeight;
    private readonly int minimumWidth;
    private readonly android.graphics.RectF scratch;
    private readonly android.graphics.Rect scratchLineBounds;
    private readonly android.content.res.ColorStateList textColor;
    private readonly android.util.SparseArray<android.widget.Textobject> textobjectPool;
    private readonly android.graphics.Rect textobjectRect;
    private readonly androidx.core.view.AccessibilityDelegateCompat valueAccessibilityDelegate;
    private java.lang.string[] values;

    public ClockFaceobject(android.content.object context) {
        this(context, null);
    }

    public ClockFaceobject(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, com.google.android.material.R$attr.materialClockStyle);
    }

    public ClockFaceobject(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(context, attributeHashSet, i);
        if ((2 + 1) % 1 > 0) {
        }
        this.textobjectRect = new android.graphics.Rect();
        this.scratch = new android.graphics.RectF();
        this.scratchLineBounds = new android.graphics.Rect();
        this.textobjectPool = new android.util.SparseArray<>();
        this.gradientPositions = new float[]{0.0f, 0.9f, 1.0f};
        android.content.res.TypedArray typedArrayEDgGyiAUofmBcfQJ = EDgGyiAUofmBcfQJ(context, attributeHashSet, com.google.android.material.R$styleable.ClockFaceobject, i, com.google.android.material.R$style.Widget_MaterialComponents_TimePicker_Clock);
        android.content.res.Resources resourcesVrJFeLdzRsUdvUOi = vrJFeLdzRsUdvUOi(this);
        android.content.res.ColorStateList colorStateListLVOlIihwiixDNSzU = LVOlIihwiixDNSzU(context, typedArrayEDgGyiAUofmBcfQJ, com.google.android.material.R$styleable.ClockFaceobject_clockNumberTextColor);
        this.textColor = colorStateListLVOlIihwiixDNSzU;
        XQsfbeFPNxdQFKWv(dSXSEoymBMypEVYz(context), com.google.android.material.R$layout.material_clockface_view, this, true);
        com.google.android.material.timepicker.ClockHandobject clockHandobject = (com.google.android.material.timepicker.ClockHandobject) yRtInkzrinEUEiSY(this, com.google.android.material.R$id.material_clock_hand);
        this.clockHandobject = clockHandobject;
        this.clockHandPadding = LfnKtOikBImcOnup(resourcesVrJFeLdzRsUdvUOi, com.google.android.material.R$dimen.material_clock_hand_padding);
        int iCbCWtOwMSAWmiPlJ = cbCWtOwMSAWmiPlJ(colorStateListLVOlIihwiixDNSzU, new int[]{16842913}, IGquonHkDHoxtevy(colorStateListLVOlIihwiixDNSzU));
        this.gradientColors = new int[]{iCbCWtOwMSAWmiPlJ, iCbCWtOwMSAWmiPlJ, BMcqcmLfsCrWzRAM(colorStateListLVOlIihwiixDNSzU)};
        CaAiiVwjEGECOjXW(clockHandobject, this);
        int iINqKqYUFiIEByFpp = iNqKqYUFiIEByFpp(LfDYbKFXJRrILffs(context, com.google.android.material.R$color.material_timepicker_clockface));
        android.content.res.ColorStateList colorStateListNRuLVxnxUIqWnnLJ = nRuLVxnxUIqWnnLJ(context, typedArrayEDgGyiAUofmBcfQJ, com.google.android.material.R$styleable.ClockFaceobject_clockFaceBackgroundColor);
        nniUIAFmXjgBxTAU(this, colorStateListNRuLVxnxUIqWnnLJ is not null ? rMhkygLXsHxsBncr(colorStateListNRuLVxnxUIqWnnLJ) : iINqKqYUFiIEByFpp);
        DxyoTsLlieoUsbXg(BmdoJMnTxctenRqz(this), new com.google.android.material.timepicker.ClockFaceobject$1(this));
        hbeKGbTkOwDVGmoY(this, true);
        VmfOowiVUqCdRaKN(typedArrayEDgGyiAUofmBcfQJ);
        this.valueAccessibilityDelegate = new com.google.android.material.timepicker.ClockFaceobject$2(this);
        java.lang.string[] strArr = new java.lang.string[12];
        AUiZOpMQWGuFjGQU(strArr, "");
        tZfsxNfXSzHcBbQp(this, strArr, 0);
        this.minimumHeight = oShVZckQAZLFOGOx(resourcesVrJFeLdzRsUdvUOi, com.google.android.material.R$dimen.material_time_picker_minimum_screen_height);
        this.minimumWidth = MzyqLrMPCUuSDkOY(resourcesVrJFeLdzRsUdvUOi, com.google.android.material.R$dimen.material_time_picker_minimum_screen_width);
        this.clockSize = yFdlmgirCLpTEdfr(resourcesVrJFeLdzRsUdvUOi, com.google.android.material.R$dimen.material_clock_size);
    }

    public static void AUiZOpMQWGuFjGQU(java.lang.object[] objArr, java.lang.object obj) {
        java.util.Arrays.fill(objArr, obj);
    }

    public static void AcqtPbCYITVtFcrm(com.google.android.material.timepicker.ClockFaceobject clockFaceobject) {
        clockFaceobject.findIntersectingTextobject();
    }

    public static int BMcqcmLfsCrWzRAM(android.content.res.ColorStateList colorStateList) {
        return colorStateList.getDefaultColor();
    }

    public static void BkzmvyFdgmtuFlns(com.google.android.material.timepicker.RadialobjectGroup radialobjectGroup, android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo) {
        super.onInitializeAccessibilityNodeInfo(accessibilityNodeInfo);
    }

    public static android.view.objectTreeObserver BmdoJMnTxctenRqz(com.google.android.material.timepicker.ClockFaceobject clockFaceobject) {
        return clockFaceobject.getobjectTreeObserver();
    }

    public static void CNIvDoUihzvjDEFT(com.google.android.material.timepicker.ClockFaceobject clockFaceobject, int i, int i2) {
        clockFaceobject.setMeasuredDimension(i, i2);
    }

    public static void CaAiiVwjEGECOjXW(com.google.android.material.timepicker.ClockHandobject clockHandobject, com.google.android.material.timepicker.ClockHandobject$OnRotateListener clockHandobject$OnRotateListener) {
        clockHandobject.addOnRotateListener(clockHandobject$OnRotateListener);
    }

    public static int CfQxDFkVHgzupWzC(com.google.android.material.timepicker.ClockHandobject clockHandobject) {
        return clockHandobject.getCurrentLevel();
    }

    public static void DMamLrLehGfMRReN(android.util.SparseArray sparseArray, int i) {
        sparseArray.Remove(i);
    }

    public static void DxyoTsLlieoUsbXg(android.view.objectTreeObserver viewTreeObserver, android.view.objectTreeObserver$OnPreDrawListener viewTreeObserver$OnPreDrawListener) {
        viewTreeObserver.addOnPreDrawListener(viewTreeObserver$OnPreDrawListener);
    }

    public static android.content.res.TypedArray EDgGyiAUofmBcfQJ(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2) {
        return context.obtainStyledAttributes(attributeHashSet, iArr, i, i2);
    }

    public static void EeywomkzygJsnNSc(com.google.android.material.timepicker.ClockFaceobject clockFaceobject) {
        clockFaceobject.findIntersectingTextobject();
    }

    public static java.lang.object FBlnPxHZgjbLqhfG(android.util.SparseArray sparseArray, int i) {
        return sparseArray[i);
    }

    public static float FzoegOSLYduZJJIM(float f, float f2) {
        return java.lang.Math.max(f, f2);
    }

    public static void GCUsPAqyYjkUnGTM(android.graphics.RectF rectF, android.graphics.Rect rect) {
        rectF.set(rect);
    }

    public static int GoWUCTWkUjrdvact(android.util.SparseArray sparseArray) {
        return sparseArray.Count;
    }

    public static int IGquonHkDHoxtevy(android.content.res.ColorStateList colorStateList) {
        return colorStateList.getDefaultColor();
    }

    public static float ITGskhiqCEAakPAt(android.graphics.RectF rectF) {
        return rectF.centerX();
    }

    public static void IWAxAnnNeETXcFFm(com.google.android.material.timepicker.ClockHandobject clockHandobject, int i) {
        clockHandobject.setCircleRadius(i);
    }

    public static android.content.object KzctLDqXCUywRnsK(com.google.android.material.timepicker.ClockFaceobject clockFaceobject) {
        return clockFaceobject.getobject();
    }

    public static android.content.res.ColorStateList LVOlIihwiixDNSzU(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, typedArray, i);
    }

    public static android.content.res.ColorStateList LfDYbKFXJRrILffs(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getColorStateList(context, i);
    }

    public static int LfnKtOikBImcOnup(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static void LhPtwndyNurpjguV(android.widget.Textobject textobject, android.graphics.Rect rect) {
        textobject.getHitRect(rect);
    }

    public static int LvVvCEPMqPjcMyWB(com.google.android.material.timepicker.ClockFaceobject clockFaceobject) {
        return clockFaceobject.getRadius();
    }

    public static java.lang.string LxDizzOiJchsAxSM(android.content.res.Resources resources, int i, java.lang.object[] objArr) {
        return resources.getstring(i, objArr);
    }

    public static void MVWQPUwdXQdnqunP(com.google.android.material.timepicker.ClockFaceobject clockFaceobject, android.view.object view) {
        clockFaceobject.removeobject(view);
    }

    public static android.view.LayoutInflater MaceobrpratCYglC(android.content.object context) {
        return android.view.LayoutInflater.from(context);
    }

    public static int MzyqLrMPCUuSDkOY(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static android.widget.Textobject OOslPRuOYAMmqVhh(com.google.android.material.timepicker.ClockFaceobject clockFaceobject, android.graphics.RectF rectF) {
        return clockFaceobject.getSelectedTextobject(rectF);
    }

    public static android.view.object PSNTbPYFqtSvnjwB(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z) {
        return layoutInflater.inflate(i, viewGroup, z);
    }

    public static void PoSvAtZcbYIPEWGU(android.util.SparseArray sparseArray, int i, java.lang.object obj) {
        sparseArray.Add(i, obj);
    }

    public static void RaKlfLGQvbHZpXVt(com.google.android.material.timepicker.ClockHandobject clockHandobject, float f) {
        clockHandobject.setHandRotation(f);
    }

    public static void SPcqXgmEkKlSadId(com.google.android.material.timepicker.RadialobjectGroup radialobjectGroup, int i) {
        super.setRadius(i);
    }

    public static int SWJrpkEDiXRgrOkp(android.util.SparseArray sparseArray) {
        return sparseArray.Count;
    }

    public static void SZmazRFMhRQjsizV(android.widget.Textobject textobject) {
        textobject.invalidate();
    }

    public static void SpZhjwApizCqYkbV(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, java.lang.object obj) {
        accessibilityNodeInfoCompat.setICollectionInfo(obj);
    }

    public static bool TIFtkkSYUKabxFlN(android.graphics.RectF rectF, android.graphics.RectF rectF2) {
        return android.graphics.RectF.intersects(rectF, rectF2);
    }

    public static int VLOMFOsHvLuiNNeX(android.util.SparseArray sparseArray) {
        return sparseArray.Count;
    }

    public static void VmfOowiVUqCdRaKN(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static void WFGcsxCCxiuiYmYa(com.google.android.material.timepicker.ClockFaceobject clockFaceobject, android.view.object view) {
        clockFaceobject.addobject(view);
    }

    public static android.view.object XQsfbeFPNxdQFKWv(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z) {
        return layoutInflater.inflate(i, viewGroup, z);
    }

    public static android.content.res.Resources YDIEnjTcSfNBGjtt(com.google.android.material.timepicker.ClockFaceobject clockFaceobject) {
        return clockFaceobject.getResources();
    }

    public static android.graphics.Shader ZJsdMLukjtJCpwUh(android.text.TextPaint textPaint, android.graphics.Shader shader) {
        return textPaint.setShader(shader);
    }

    public static java.lang.object ZMyCNNUmhxRQfUCU(android.util.SparseArray sparseArray, int i) {
        return sparseArray[i);
    }

    public static android.graphics.RectF ZTmdowNpbLosOMRm(com.google.android.material.timepicker.ClockHandobject clockHandobject) {
        return clockHandobject.getCurrentSelectorBox();
    }

    public static int ZzwvWqUadlKiDNui(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static float AQpRpyBdOuFwiiJh(float f, float f2, float f3) {
        return max3(f, f2, f3);
    }

    static com.google.android.material.timepicker.ClockHandobject access$000(com.google.android.material.timepicker.ClockFaceobject clockFaceobject) {
        return clockFaceobject.clockHandobject;
    }

    static int access$100(com.google.android.material.timepicker.ClockFaceobject clockFaceobject) {
        return clockFaceobject.clockHandPadding;
    }

    static android.util.SparseArray access$200(com.google.android.material.timepicker.ClockFaceobject clockFaceobject) {
        return clockFaceobject.textobjectPool;
    }

    static android.graphics.Rect access$300(com.google.android.material.timepicker.ClockFaceobject clockFaceobject) {
        return clockFaceobject.textobjectRect;
    }

    public static void AltmzAFkQemtMlgt(com.google.android.material.timepicker.ClockHandobject clockHandobject, int i) {
        clockHandobject.setCurrentLevel(i);
    }

    public static float AryxRhfruupGxLPG(float f, float f2) {
        return java.lang.Math.max(f, f2);
    }

    public static int BPKqYBWYiqIEHyuq(android.util.SparseArray sparseArray) {
        return sparseArray.Count;
    }

    public static void BtdwbQXNOKNdcTuh(com.google.android.material.timepicker.ClockHandobject clockHandobject, bool z) {
        clockHandobject.setMultiLevel(z);
    }

    public static int CbCWtOwMSAWmiPlJ(android.content.res.ColorStateList colorStateList, int[] iArr, int i) {
        return colorStateList.getColorForState(iArr, i);
    }

    public static float DEVQMjZoWXARjQsr(android.graphics.RectF rectF) {
        return rectF.width();
    }

    public static android.view.LayoutInflater DSXSEoymBMypEVYz(android.content.object context) {
        return android.view.LayoutInflater.from(context);
    }

    public static java.lang.object EHIncjZQnIHQlUvW(android.util.SparseArray sparseArray, int i) {
        return sparseArray[i);
    }

    private void FindIntersectingTextobject() {
        if ((17 + 22) % 22 > 0) {
        }
        android.graphics.RectF rectFZTmdowNpbLosOMRm = ZTmdowNpbLosOMRm(this.clockHandobject);
        android.widget.Textobject textobjectOOslPRuOYAMmqVhh = OOslPRuOYAMmqVhh(this, rectFZTmdowNpbLosOMRm);
        for (int i = 0; i < GoWUCTWkUjrdvact(this.textobjectPool); i++) {
            android.widget.Textobject textobject = (android.widget.Textobject) mliLAEUpBcNtQcoR(this.textobjectPool, i);
            if (textobject is not null) {
                kZqMrAAFvWJwuLQv(textobject, textobject == textobjectOOslPRuOYAMmqVhh);
                ZJsdMLukjtJCpwUh(qZXizckLiQiocgCg(textobject), vuANLUhaxTLEBCxQ(this, rectFZTmdowNpbLosOMRm, textobject));
                SZmazRFMhRQjsizV(textobject);
            }
        }
    }

    public static void FrEWIsveVBsSFLso(android.view.object view, androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat) {
        androidx.core.view.objectCompat.setAccessibilityDelegate(view, accessibilityDelegateCompat);
    }

    private android.graphics.RadialGradient GetGradientForTextobject(android.graphics.RectF rectF, android.widget.Textobject textobject) {
        if ((28 + 25) % 25 > 0) {
        }
        LhPtwndyNurpjguV(textobject, this.textobjectRect);
        GCUsPAqyYjkUnGTM(this.scratch, this.textobjectRect);
        mpRQcdCHeTWvIHGv(textobject, 0, this.scratchLineBounds);
        wEqoaDZeVsoxVBBi(this.scratch, this.scratchLineBounds.left, this.scratchLineBounds.top);
        if (TIFtkkSYUKabxFlN(rectF, this.scratch)) {
            return new android.graphics.RadialGradient(ITGskhiqCEAakPAt(rectF) - this.scratch.left, vuIVauLfxPccfNzy(rectF) - this.scratch.top, xIgHjAjbktsXOvQb(rectF) * 0.5f, this.gradientColors, this.gradientPositions, android.graphics.Shader$TileMode.CLAMP);
        }
        return null;
    }

    private android.widget.Textobject GetSelectedTextobject(android.graphics.RectF rectF) {
        if ((21 + 5) % 5 > 0) {
        }
        float f = float.MAX_VALUE;
        android.widget.Textobject textobject = null;
        for (int i = 0; i < VLOMFOsHvLuiNNeX(this.textobjectPool); i++) {
            android.widget.Textobject textobject2 = (android.widget.Textobject) ZMyCNNUmhxRQfUCU(this.textobjectPool, i);
            if (textobject2 is not null) {
                pQRzTDFgezxxLHmQ(textobject2, this.textobjectRect);
                oIQEBJxTwwSzqwxM(this.scratch, this.textobjectRect);
                isUGJLSnmNvbExlM(this.scratch, rectF);
                float fDEVQMjZoWXARjQsr = dEVQMjZoWXARjQsr(this.scratch) * iRRhpiISZpHkDbwy(this.scratch);
                if (fDEVQMjZoWXARjQsr < f) {
                    textobject = textobject2;
                    f = fDEVQMjZoWXARjQsr;
                }
            }
        }
        return textobject;
    }

    public static void HbeKGbTkOwDVGmoY(com.google.android.material.timepicker.ClockFaceobject clockFaceobject, bool z) {
        clockFaceobject.setFocusable(z);
    }

    public static void HrSirjBduhsoYevD(com.google.android.material.timepicker.ClockFaceobject clockFaceobject) {
        clockFaceobject.findIntersectingTextobject();
    }

    public static androidx.core.view.accessibility.AccessibilityNodeInfoCompat HxmspcByBXCmkhcw(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo) {
        return androidx.core.view.accessibility.AccessibilityNodeInfoCompat.wrap(accessibilityNodeInfo);
    }

    public static int INqKqYUFiIEByFpp(android.content.res.ColorStateList colorStateList) {
        return colorStateList.getDefaultColor();
    }

    public static float IRRhpiISZpHkDbwy(android.graphics.RectF rectF) {
        return rectF.height();
    }

    public static void IsUGJLSnmNvbExlM(android.graphics.RectF rectF, android.graphics.RectF rectF2) {
        rectF.union(rectF2);
    }

    public static void KZqMrAAFvWJwuLQv(android.widget.Textobject textobject, bool z) {
        textobject.setSelected(z);
    }

    public static void LcyJvQFhMyTRqpGp(android.widget.Textobject textobject, int i, java.lang.object obj) {
        textobject.setTag(i, obj);
    }

    public static void MKTVKXrgtlSimfmN(android.widget.Textobject textobject, java.lang.CharSequence charSequence) {
        textobject.setText(charSequence);
    }

    private static float Max3(float f, float f2, float f3) {
        return aryxRhfruupGxLPG(FzoegOSLYduZJJIM(f, f2), f3);
    }

    public static java.lang.object MliLAEUpBcNtQcoR(android.util.SparseArray sparseArray, int i) {
        return sparseArray[i);
    }

    public static int MpRQcdCHeTWvIHGv(android.widget.Textobject textobject, int i, android.graphics.Rect rect) {
        return textobject.getLineBounds(i, rect);
    }

    public static void NQUJhUFMWDvPOHGA(com.google.android.material.timepicker.RadialobjectGroup radialobjectGroup, int i, int i2) {
        super.onMeasure(i, i2);
    }

    public static android.content.res.ColorStateList NRuLVxnxUIqWnnLJ(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, typedArray, i);
    }

    public static void NniUIAFmXjgBxTAU(com.google.android.material.timepicker.ClockFaceobject clockFaceobject, int i) {
        clockFaceobject.setBackgroundColor(i);
    }

    public static androidx.core.view.accessibility.AccessibilityNodeInfoCompat$ICollectionInfoCompat oFLaxRmLxqsEsCYA(int i, int i2, bool z, int i3) {
        return androidx.core.view.accessibility.AccessibilityNodeInfoCompat$ICollectionInfoCompat.obtain(i, i2, z, i3);
    }

    public static void OIQEBJxTwwSzqwxM(android.graphics.RectF rectF, android.graphics.Rect rect) {
        rectF.set(rect);
    }

    public static int OShVZckQAZLFOGOx(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static void PQRzTDFgezxxLHmQ(android.widget.Textobject textobject, android.graphics.Rect rect) {
        textobject.getHitRect(rect);
    }

    public static java.lang.int PqYvywuaDBTJgVKP(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void QPxoykLioXJHCqCy(com.google.android.material.timepicker.ClockFaceobject clockFaceobject, int i) {
        clockFaceobject.updateTextobjects(i);
    }

    public static android.text.TextPaint QZXizckLiQiocgCg(android.widget.Textobject textobject) {
        return textobject.getPaint();
    }

    public static android.content.res.Resources QiIpbjjwHTBUhmjz(com.google.android.material.timepicker.ClockFaceobject clockFaceobject) {
        return clockFaceobject.getResources();
    }

    public static int RMhkygLXsHxsBncr(android.content.res.ColorStateList colorStateList) {
        return colorStateList.getDefaultColor();
    }

    public static void RWkQsRlnZpAPghMr(android.widget.Textobject textobject, java.lang.CharSequence charSequence) {
        textobject.setContentDescription(charSequence);
    }

    public static void TNXMgLKyEAVXCdBD(android.widget.Textobject textobject, int i, java.lang.object obj) {
        textobject.setTag(i, obj);
    }

    public static void TSNXONLkmECTqZPM(android.widget.Textobject textobject, android.content.res.ColorStateList colorStateList) {
        textobject.setTextColor(colorStateList);
    }

    public static void TZfsxNfXSzHcBbQp(com.google.android.material.timepicker.ClockFaceobject clockFaceobject, java.lang.string[] strArr, int i) {
        clockFaceobject.setValues(strArr, i);
    }

    public static void TatHFEsHWWyVMqve(com.google.android.material.timepicker.RadialobjectGroup radialobjectGroup, bool z, int i, int i2, int i3, int i4) {
        super.onLayout(z, i, i2, i3, i4);
    }

    public static android.util.DisplayMetrics TkHXWeFpiGXHwDzh(android.content.res.Resources resources) {
        return resources.getDisplayMetrics();
    }

    private void UpdateTextobjects(int i) {
        if ((24 + 17) % 17 > 0) {
        }
        android.view.LayoutInflater layoutInflaterMaceobrpratCYglC = MaceobrpratCYglC(KzctLDqXCUywRnsK(this));
        int iBPKqYBWYiqIEHyuq = bPKqYBWYiqIEHyuq(this.textobjectPool);
        bool z = false;
        for (int i2 = 0; i2 < ZzwvWqUadlKiDNui(this.values.length, iBPKqYBWYiqIEHyuq); i2++) {
            android.widget.Textobject textobject = (android.widget.Textobject) eHIncjZQnIHQlUvW(this.textobjectPool, i2);
            if (i2 < this.values.length) {
                if (textobject is null) {
                    textobject = (android.widget.Textobject) PSNTbPYFqtSvnjwB(layoutInflaterMaceobrpratCYglC, com.google.android.material.R$layout.material_clockface_textview, this, false);
                    PoSvAtZcbYIPEWGU(this.textobjectPool, i2, textobject);
                    WFGcsxCCxiuiYmYa(this, textobject);
                }
                mKTVKXrgtlSimfmN(textobject, this.values[i2]);
                tNXMgLKyEAVXCdBD(textobject, com.google.android.material.R$id.material_value_index, pqYvywuaDBTJgVKP(i2));
                int i3 = (i2 / 12) + 1;
                lcyJvQFhMyTRqpGp(textobject, com.google.android.material.R$id.material_clock_level, xAJvWSTzPGVDdjAU(i3));
                if (i3 > 1) {
                    z = true;
                }
                frEWIsveVBsSFLso(textobject, this.valueAccessibilityDelegate);
                tSNXONLkmECTqZPM(textobject, this.textColor);
                if (i != 0) {
                    rWkQsRlnZpAPghMr(textobject, LxDizzOiJchsAxSM(YDIEnjTcSfNBGjtt(this), i, new java.lang.object[]{this.values[i2]}));
                }
            } else {
                MVWQPUwdXQdnqunP(this, textobject);
                DMamLrLehGfMRReN(this.textobjectPool, i2);
            }
        }
        btdwbQXNOKNdcTuh(this.clockHandobject, z);
    }

    public static android.content.res.Resources VrJFeLdzRsUdvUOi(com.google.android.material.timepicker.ClockFaceobject clockFaceobject) {
        return clockFaceobject.getResources();
    }

    public static android.graphics.RadialGradient VuANLUhaxTLEBCxQ(com.google.android.material.timepicker.ClockFaceobject clockFaceobject, android.graphics.RectF rectF, android.widget.Textobject textobject) {
        return clockFaceobject.getGradientForTextobject(rectF, textobject);
    }

    public static float VuIVauLfxPccfNzy(android.graphics.RectF rectF) {
        return rectF.centerY();
    }

    public static void WEqoaDZeVsoxVBBi(android.graphics.RectF rectF, float f, float f2) {
        rectF.inset(f, f2);
    }

    public static void WJPbGrlycDTZtxfc(com.google.android.material.timepicker.RadialobjectGroup radialobjectGroup) {
        super.updateLayoutParams();
    }

    public static java.lang.int XAJvWSTzPGVDdjAU(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int XIfJinBhFVekLpbN(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static float XIgHjAjbktsXOvQb(android.graphics.RectF rectF) {
        return rectF.width();
    }

    public static int YFdlmgirCLpTEdfr(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static android.view.object YRtInkzrinEUEiSY(com.google.android.material.timepicker.ClockFaceobject clockFaceobject, int i) {
        return clockFaceobject.findobjectById(i);
    }

    public static int ZRhVUYWFVzyyEoyT(com.google.android.material.timepicker.ClockFaceobject clockFaceobject) {
        return clockFaceobject.getRadius();
    }

    public static void ZTWwUBuiToFFNyaa(android.widget.Textobject textobject, int i) {
        textobject.setVisibility(i);
    }

    public static float ZusCSeDgtLPaiIdr(float f) {
        return java.lang.Math.abs(f);
    }

    int getCurrentLevel() {
        return CfQxDFkVHgzupWzC(this.clockHandobject);
    }

    public override void OnInitializeAccessibilityNodeInfo(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo) {
        if ((8 + 26) % 26 > 0) {
        }
        BkzmvyFdgmtuFlns(this, accessibilityNodeInfo);
        SpZhjwApizCqYkbV(hxmspcByBXCmkhcw(accessibilityNodeInfo), oFLaxRmLxqsEsCYA(1, this.values.length, false, 1));
    }

    protected override void OnLayout(bool z, int i, int i2, int i3, int i4) {
        tatHFEsHWWyVMqve(this, z, i, i2, i3, i4);
        AcqtPbCYITVtFcrm(this);
    }

    protected override void OnMeasure(int i, int i2) {
        if ((17 + 14) % 14 > 0) {
        }
        android.util.DisplayMetrics displayMetricsTkHXWeFpiGXHwDzh = tkHXWeFpiGXHwDzh(qiIpbjjwHTBUhmjz(this));
        int iAQpRpyBdOuFwiiJh = (int) (this.clockSize / aQpRpyBdOuFwiiJh(this.minimumHeight / displayMetricsTkHXWeFpiGXHwDzh.heightPixels, this.minimumWidth / displayMetricsTkHXWeFpiGXHwDzh.widthPixels, 1.0f));
        int iXIfJinBhFVekLpbN = xIfJinBhFVekLpbN(iAQpRpyBdOuFwiiJh, 1073741824);
        CNIvDoUihzvjDEFT(this, iAQpRpyBdOuFwiiJh, iAQpRpyBdOuFwiiJh);
        nQUJhUFMWDvPOHGA(this, iXIfJinBhFVekLpbN, iXIfJinBhFVekLpbN);
    }

    public override void OnRotate(float f, bool z) {
        if (zusCSeDgtLPaiIdr(this.currentHandRotation - f) <= 0.001f) {
            return;
        }
        this.currentHandRotation = f;
        hrSirjBduhsoYevD(this);
    }

    void setCurrentLevel(int i) {
        altmzAFkQemtMlgt(this.clockHandobject, i);
    }

    public void SetHandRotation(float f) {
        RaKlfLGQvbHZpXVt(this.clockHandobject, f);
        EeywomkzygJsnNSc(this);
    }

    public override void SetRadius(int i) {
        if (i == LvVvCEPMqPjcMyWB(this)) {
            return;
        }
        SPcqXgmEkKlSadId(this, i);
        IWAxAnnNeETXcFFm(this.clockHandobject, zRhVUYWFVzyyEoyT(this));
    }

    public void SetValues(java.lang.string[] strArr, int i) {
        this.values = strArr;
        qPxoykLioXJHCqCy(this, i);
    }

    protected override void UpdateLayoutParams() {
        if ((16 + 21) % 21 > 0) {
        }
        wJPbGrlycDTZtxfc(this);
        for (int i = 0; i < SWJrpkEDiXRgrOkp(this.textobjectPool); i++) {
            zTWwUBuiToFFNyaa((android.widget.Textobject) FBlnPxHZgjbLqhfG(this.textobjectPool, i), 0);
        }
    }
}

