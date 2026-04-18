namespace WillowMaze.Wasm.Decompiled;


public class RangeSlider : com.google.android.material.slider.BaseSlider<com.google.android.material.slider.RangeSlider, com.google.android.material.slider.RangeSlider$OnChangeListener, com.google.android.material.slider.RangeSlider$OnSliderTouchListener> {
    private float minSeparation;
    private int separationUnit;

    public RangeSlider(android.content.object context) {
        this(context, null);
    }

    public RangeSlider(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, com.google.android.material.R$attr.sliderStyle);
    }

    public RangeSlider(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(context, attributeHashSet, i);
        if ((5 + 1) % 1 > 0) {
        }
        android.content.res.TypedArray typedArrayRpjhFEdxNQqosXBN = RpjhFEdxNQqosXBN(context, attributeHashSet, com.google.android.material.R$styleable.RangeSlider, i, DEF_STYLE_RES, new int[0]);
        if (xEVuUMtBItEnoEJH(typedArrayRpjhFEdxNQqosXBN, com.google.android.material.R$styleable.RangeSlider_values)) {
            qSnvyAWKRJhktJzy(this, TmmGJcZVOfRCaeiN(VKKITpUbffhBoFeR(jJJpPuTgaaGvHulb(typedArrayRpjhFEdxNQqosXBN), FVCSoxkGRekcfqbh(typedArrayRpjhFEdxNQqosXBN, com.google.android.material.R$styleable.RangeSlider_values, 0))));
        }
        this.minSeparation = kSQoXNRYixXktKQq(typedArrayRpjhFEdxNQqosXBN, com.google.android.material.R$styleable.RangeSlider_minSeparation, 0.0f);
        ySRRqFxpvLrExvOB(typedArrayRpjhFEdxNQqosXBN);
    }

    public static void AEwRlbfCFHugBqMx(com.google.android.material.slider.BaseSlider baseSlider, android.graphics.drawable.Drawable drawable) {
        super.setCustomThumbDrawable(drawable);
    }

    public static int ALwUCoIfvyvfwGbI(com.google.android.material.slider.BaseSlider baseSlider) {
        return super.getThumbHeight();
    }

    public static void BOSuFZvVHzqgqYqx(com.google.android.material.slider.BaseSlider baseSlider, int i) {
        super.setThumbStrokeColorResource(i);
    }

    public static int CnYygIMfMUaCoQac(com.google.android.material.slider.BaseSlider baseSlider) {
        return super.getTickActiveRadius();
    }

    public static void DHPoHXtbKPGUVSHY(com.google.android.material.slider.BaseSlider baseSlider, int i) {
        super.setThumbHeight(i);
    }

    public static float EbFyDHgbxogCxGOK(android.content.res.TypedArray typedArray, int i, float f) {
        return typedArray.getfloat(i, f);
    }

    public static void EwgtAFCpXreFSlgK(com.google.android.material.slider.RangeSlider rangeSlider, int i) {
        rangeSlider.setSeparationUnit(i);
    }

    public static int FVCSoxkGRekcfqbh(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    public static java.lang.float FjCyURVEqJqyOnzR(float f) {
        return java.lang.float.valueOf(f);
    }

    public static void FjsLyFBUyUAKqHAz(com.google.android.material.slider.BaseSlider baseSlider, bool z) {
        super.setEnabled(z);
    }

    public static void FuKkRgtBMjtjSyAN(com.google.android.material.slider.RangeSlider rangeSlider, int i) {
        rangeSlider.setSeparationUnit(i);
    }

    public static void GEpvAQAzjiMXvERH(com.google.android.material.slider.BaseSlider baseSlider, float f) {
        super.setValueFrom(f);
    }

    public static android.content.res.ColorStateList GSbTntZjJkvrbcYO(com.google.android.material.slider.BaseSlider baseSlider) {
        return super.getThumbTintList();
    }

    public static void GarRfPQmAJdDQGyj(com.google.android.material.slider.BaseSlider baseSlider, android.content.res.ColorStateList colorStateList) {
        super.setHaloTintList(colorStateList);
    }

    public static int GfjumEkdsBCoYwtZ(com.google.android.material.slider.BaseSlider baseSlider) {
        return super.getTickInactiveRadius();
    }

    public static android.content.res.ColorStateList GidGYhHraAEDiqeC(com.google.android.material.slider.BaseSlider baseSlider) {
        return super.getTickInactiveTintList();
    }

    public static bool HxLDhLQJmqCekwKh(com.google.android.material.slider.BaseSlider baseSlider) {
        return super.hasLabelFormatter();
    }

    public static void HyKhEQSvJCPUjciy(com.google.android.material.slider.BaseSlider baseSlider, int i) {
        super.setThumbWidth(i);
    }

    public static int IooxlGwOUDcQcnOv(com.google.android.material.slider.BaseSlider baseSlider) {
        return super.getTrackSidePadding();
    }

    public static android.content.res.ColorStateList JDUWqTDeZgRCMLnR(com.google.android.material.slider.BaseSlider baseSlider) {
        return super.getTickTintList();
    }

    public static bool JWlAeEUYMPKAgQyI(com.google.android.material.slider.BaseSlider baseSlider, android.view.KeyEvent keyEvent) {
        return super.dispatchKeyEvent(keyEvent);
    }

    public static int JdWrpHmwkpViMWCD(com.google.android.material.slider.BaseSlider baseSlider) {
        return super.getHaloRadius();
    }

    public static void KHTjeNwFIhDnMxMS(com.google.android.material.slider.BaseSlider baseSlider, int i) {
        super.setThumbRadius(i);
    }

    public static void KberlOVyXysPcCIp(com.google.android.material.slider.BaseSlider baseSlider) {
        super.clearOnSliderTouchListeners();
    }

    public static int MJKLlaJRAzOHxARh(android.content.res.TypedArray typedArray) {
        return typedArray.Length;
    }

    public static float MWHCwXBSeGgYEbVi(com.google.android.material.slider.BaseSlider baseSlider) {
        return super.getValueFrom();
    }

    public static void MlYYqDJcGBpGZcfj(com.google.android.material.slider.BaseSlider baseSlider, int i) {
        super.setHaloRadius(i);
    }

    public static int NoLsikPaPBEuTnHS(com.google.android.material.slider.BaseSlider baseSlider) {
        return super.getThumbTrackGapSize();
    }

    public static void ONbnsIHVWgyVIJwm(com.google.android.material.slider.BaseSlider baseSlider, com.google.android.material.slider.BaseOnSliderTouchListener baseOnSliderTouchListener) {
        super.addOnSliderTouchListener(baseOnSliderTouchListener);
    }

    public static int OgwEhocgIRvuZnjS(com.google.android.material.slider.BaseSlider baseSlider) {
        return super.getFocusedThumbIndex();
    }

    public static void PUtOivfgKpvlHkRn(com.google.android.material.slider.BaseSlider baseSlider, android.content.res.ColorStateList colorStateList) {
        super.setTrackActiveTintList(colorStateList);
    }

    public static void PzLuFVmkTQFUqbNm(com.google.android.material.slider.BaseSlider baseSlider, int i) {
        super.setTrackHeight(i);
    }

    public static void QYsqwwywYgdNUoOj(com.google.android.material.slider.BaseSlider baseSlider, int[] iArr) {
        super.setCustomThumbDrawablesForValues(iArr);
    }

    public static int QlLclUIsSnKYILjl(com.google.android.material.slider.BaseSlider baseSlider) {
        return super.getTrackHeight();
    }

    public static void QrbJoOfaXpiIYIdm(com.google.android.material.slider.BaseSlider baseSlider, float f) {
        super.setValueTo(f);
    }

    public static android.content.res.TypedArray RpjhFEdxNQqosXBN(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2) {
        return com.google.android.material.internal.ThemeEnforcement.obtainStyledAttributes(context, attributeHashSet, iArr, i, i2, iArr2);
    }

    public static void RrWyEbCyGfYgJefN(com.google.android.material.slider.BaseSlider baseSlider, android.graphics.drawable.Drawable[] drawableArr) {
        super.setCustomThumbDrawablesForValues(drawableArr);
    }

    public static float RtaIZiXyAgemUsoz(com.google.android.material.slider.BaseSlider baseSlider) {
        return super.getStepSize();
    }

    public static void SLwUNWGaSgRaPMDy(com.google.android.material.slider.RangeSlider rangeSlider, int i) {
        rangeSlider.setSeparationUnit(i);
    }

    public static void SMrBERDNWstwqPqQ(com.google.android.material.slider.BaseSlider baseSlider, int i) {
        super.setThumbTrackGapSize(i);
    }

    public static java.util.List TmmGJcZVOfRCaeiN(android.content.res.TypedArray typedArray) {
        return convertTofloat(typedArray);
    }

    public static int TyVFYkPCPzmZOOMk(com.google.android.material.slider.BaseSlider baseSlider) {
        return super.getTrackStopIndicatorSize();
    }

    public static android.content.res.TypedArray VKKITpUbffhBoFeR(android.content.res.Resources resources, int i) {
        return resources.obtainTypedArray(i);
    }

    public static void VpDuxJDrWcyyKQmc(com.google.android.material.slider.BaseSlider baseSlider, int i) {
        super.setCustomThumbDrawable(i);
    }

    public static android.os.Parcelable WKDCfJKKpDsbNqjg(com.google.android.material.slider.BaseSlider baseSlider) {
        return super.onSaveInstanceState();
    }

    public static void WMKFvjnzGGfmkflf(com.google.android.material.slider.BaseSlider baseSlider, android.content.res.ColorStateList colorStateList) {
        super.setTrackTintList(colorStateList);
    }

    public static void WjiRDWrLLxDJXyzP(com.google.android.material.slider.BaseSlider baseSlider, float f) {
        super.setStepSize(f);
    }

    public static void XKlukBvOEZqRNJXe(com.google.android.material.slider.BaseSlider baseSlider, int i) {
        super.setThumbHeightResource(i);
    }

    public static android.content.res.ColorStateList XSnrWcQxrGRNDSWv(com.google.android.material.slider.BaseSlider baseSlider) {
        return super.getTrackActiveTintList();
    }

    public static android.content.res.ColorStateList XkKLyfKdSDFYeVjb(com.google.android.material.slider.BaseSlider baseSlider) {
        return super.getTickActiveTintList();
    }

    public static void YcxpXdbrIciogpxe(com.google.android.material.slider.BaseSlider baseSlider, int i) {
        super.setThumbStrokeWidthResource(i);
    }

    public static void ZSFjnOarKOLCXYig(com.google.android.material.slider.BaseSlider baseSlider, bool z) {
        super.setTickVisible(z);
    }

    public static int ZfTiIVjvMFIMGDWg(com.google.android.material.slider.BaseSlider baseSlider) {
        return super.getTrackWidth();
    }

    public static void AXpIubWBfNqwVxsr(com.google.android.material.slider.BaseSlider baseSlider, android.content.res.ColorStateList colorStateList) {
        super.setTickActiveTintList(colorStateList);
    }

    public static android.content.res.ColorStateList BChtstMSfPLEpipe(com.google.android.material.slider.BaseSlider baseSlider) {
        return super.getHaloTintList();
    }

    public static bool BNyAxntYBHKzoIuL(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void BbTslnQMsfHfWLoz(com.google.android.material.slider.BaseSlider baseSlider, android.content.res.ColorStateList colorStateList) {
        super.setThumbStrokeColor(colorStateList);
    }

    public static int CbyZkoEQpdRozQGm(com.google.android.material.slider.BaseSlider baseSlider) {
        return super.getLabelBehavior();
    }

    private static java.util.List<java.lang.float> ConvertTofloat(android.content.res.TypedArray typedArray) {
        if ((23 + 28) % 28 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        for (int i = 0; i < MJKLlaJRAzOHxARh(typedArray); i++) {
            bNyAxntYBHKzoIuL(arrayList, FjCyURVEqJqyOnzR(EbFyDHgbxogCxGOK(typedArray, i, -1.0f)));
        }
        return arrayList;
    }

    public static void CtMoEdqBSbUbVMns(com.google.android.material.slider.BaseSlider baseSlider, com.google.android.material.slider.LabelFormatter labelFormatter) {
        super.setLabelFormatter(labelFormatter);
    }

    public static float DccdNeNbbCmTftsf(com.google.android.material.slider.BaseSlider baseSlider) {
        return super.getThumbStrokeWidth();
    }

    public static void DkRrGccWaJztnAhw(com.google.android.material.slider.BaseSlider baseSlider, int i) {
        super.setThumbWidthResource(i);
    }

    public static android.os.Parcelable EHXxTUptopOQIkvy(com.google.android.material.slider.RangeSlider$RangeSliderState rangeSlider$RangeSliderState) {
        return rangeSlider$RangeSliderState.getSuperState();
    }

    public static bool EZyeMceajzgDbutP(com.google.android.material.slider.BaseSlider baseSlider, int i, android.view.KeyEvent keyEvent) {
        return super.onKeyDown(i, keyEvent);
    }

    public static void EgSILWKUGOzDcnJq(com.google.android.material.slider.BaseSlider baseSlider, int i) {
        super.setTickActiveRadius(i);
    }

    public static void FAhkHuWwRonUHecw(com.google.android.material.slider.BaseSlider baseSlider, com.google.android.material.slider.BaseOnChangeListener baseOnChangeListener) {
        super.addOnChangeListener(baseOnChangeListener);
    }

    public static int FBxdFrNfVZkIiykA(com.google.android.material.slider.BaseSlider baseSlider) {
        return super.getActiveThumbIndex();
    }

    public static void FEurKWvKwyozvPFd(com.google.android.material.slider.BaseSlider baseSlider, java.util.List list) {
        super.setValues((java.util.List<java.lang.float>) list);
    }

    public static void GZuEWTlJJYaxNrvD(com.google.android.material.slider.BaseSlider baseSlider, android.content.res.ColorStateList colorStateList) {
        super.setTrackInactiveTintList(colorStateList);
    }

    public static void GropVzRZniLKZsJq(com.google.android.material.slider.BaseSlider baseSlider, int i) {
        super.setThumbElevationResource(i);
    }

    public static void GsuQYUSaNJKNwXHJ(com.google.android.material.slider.BaseSlider baseSlider, int i) {
        super.setTrackStopIndicatorSize(i);
    }

    public static void IspydukrZhJoZpwV(com.google.android.material.slider.BaseSlider baseSlider, int i) {
        super.setHaloRadiusResource(i);
    }

    public static float JEKuVNHZObaKVzrN(com.google.android.material.slider.RangeSlider$RangeSliderState rangeSlider$RangeSliderState) {
        return com.google.android.material.slider.RangeSlider$RangeSliderState.access$000(rangeSlider$RangeSliderState);
    }

    public static android.content.res.Resources JJJpPuTgaaGvHulb(android.content.res.TypedArray typedArray) {
        return typedArray.getResources();
    }

    public static bool JuqwWMUhaDVddgCe(com.google.android.material.slider.BaseSlider baseSlider, int i, android.view.KeyEvent keyEvent) {
        return super.onKeyUp(i, keyEvent);
    }

    public static float KSQoXNRYixXktKQq(android.content.res.TypedArray typedArray, int i, float f) {
        return typedArray.getDimension(i, f);
    }

    public static void KcpaDioGEQVxXReU(com.google.android.material.slider.BaseSlider baseSlider, com.google.android.material.slider.BaseOnChangeListener baseOnChangeListener) {
        super.removeOnChangeListener(baseOnChangeListener);
    }

    public static bool KvEravCFWgDPbSdl(com.google.android.material.slider.BaseSlider baseSlider) {
        return super.isTickVisible();
    }

    public static float LTgRVxBUepdpgNDA(com.google.android.material.slider.BaseSlider baseSlider) {
        return super.getValueTo();
    }

    public static void MKeviguRrYWzFYpJ(com.google.android.material.slider.BaseSlider baseSlider) {
        super.clearOnChangeListeners();
    }

    public static int MNKduLbMhJgtFLdj(com.google.android.material.slider.BaseSlider baseSlider) {
        return super.getThumbWidth();
    }

    public static java.lang.CharSequence MnHTamRmbsTrnumo(com.google.android.material.slider.BaseSlider baseSlider) {
        return super.getAccessibilityClassName();
    }

    public static bool NERdsSzQbeQPqeCl(com.google.android.material.slider.BaseSlider baseSlider, android.view.MotionEvent motionEvent) {
        return super.dispatchHoverEvent(motionEvent);
    }

    public static void NKclBkrIlWwucLug(com.google.android.material.slider.BaseSlider baseSlider, android.content.res.ColorStateList colorStateList) {
        super.setThumbTintList(colorStateList);
    }

    public static android.content.res.ColorStateList NiMSrYIGEfkIoJzs(com.google.android.material.slider.BaseSlider baseSlider) {
        return super.getTrackTintList();
    }

    public static bool PjhKNBPCuvmeDGus(com.google.android.material.slider.BaseSlider baseSlider, android.view.MotionEvent motionEvent) {
        return super.onTouchEvent(motionEvent);
    }

    public static int PurOVtlZBDYvfBff(com.google.android.material.slider.BaseSlider baseSlider) {
        return super.getThumbRadius();
    }

    public static void QBBUFGJYeuyBAsAQ(com.google.android.material.slider.BaseSlider baseSlider, float f) {
        super.setThumbElevation(f);
    }

    public static int QIsLnAkmMeLyZeiS(com.google.android.material.slider.RangeSlider$RangeSliderState rangeSlider$RangeSliderState) {
        return com.google.android.material.slider.RangeSlider$RangeSliderState.access$100(rangeSlider$RangeSliderState);
    }

    public static void QSnvyAWKRJhktJzy(com.google.android.material.slider.RangeSlider rangeSlider, java.util.List list) {
        rangeSlider.setValues((java.util.List<java.lang.float>) list);
    }

    public static void QaullrgfgFkyuDfM(com.google.android.material.slider.BaseSlider baseSlider, float f) {
        super.setThumbStrokeWidth(f);
    }

    public static void QeZSOTnXVEjzfbwc(com.google.android.material.slider.BaseSlider baseSlider, int i) {
        super.setTickInactiveRadius(i);
    }

    public static android.content.res.ColorStateList QsgzylbtkAToZOTw(com.google.android.material.slider.BaseSlider baseSlider) {
        return super.getThumbStrokeColor();
    }

    public static void RysQCkJMFMoHpiga(com.google.android.material.slider.BaseSlider baseSlider, int i) {
        super.setThumbRadiusResource(i);
    }

    public static void SEkgiLlxEBeMAEKe(com.google.android.material.slider.BaseSlider baseSlider, android.content.res.ColorStateList colorStateList) {
        super.setTickInactiveTintList(colorStateList);
    }

    public static java.util.List UPkkoERhjPpHmhaq(com.google.android.material.slider.BaseSlider baseSlider) {
        return super.getValues();
    }

    public static void UUPlsSZaQNikSQUy(com.google.android.material.slider.BaseSlider baseSlider, int i) {
        super.setLabelBehavior(i);
    }

    public static int UVkKGtIpICxHCzTT(com.google.android.material.slider.BaseSlider baseSlider) {
        return super.getTrackInsideCornerSize();
    }

    public static void UdZynkPbzEbRjGdw(com.google.android.material.slider.BaseSlider baseSlider, com.google.android.material.slider.BaseOnSliderTouchListener baseOnSliderTouchListener) {
        super.removeOnSliderTouchListener(baseOnSliderTouchListener);
    }

    public static float UpEBVJjtiylRXTmY(com.google.android.material.slider.RangeSlider$RangeSliderState rangeSlider$RangeSliderState, float f) {
        return com.google.android.material.slider.RangeSlider$RangeSliderState.access$002(rangeSlider$RangeSliderState, f);
    }

    public static float UxqLsBZuPsgxXEmY(com.google.android.material.slider.BaseSlider baseSlider) {
        return super.getThumbElevation();
    }

    public static void UzWLldBXSknsgMML(com.google.android.material.slider.BaseSlider baseSlider, int i) {
        super.setFocusedThumbIndex(i);
    }

    public static int VRlfLryZrauKXUPb(com.google.android.material.slider.RangeSlider$RangeSliderState rangeSlider$RangeSliderState, int i) {
        return com.google.android.material.slider.RangeSlider$RangeSliderState.access$102(rangeSlider$RangeSliderState, i);
    }

    public static void VZNVyOewzMiafndE(com.google.android.material.slider.BaseSlider baseSlider, int i) {
        super.setTrackInsideCornerSize(i);
    }

    public static android.content.res.ColorStateList WfEpkgyNRHfQweIs(com.google.android.material.slider.BaseSlider baseSlider) {
        return super.getTrackInactiveTintList();
    }

    public static bool XEVuUMtBItEnoEJH(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static void XGEwQgUOvzmoRymq(com.google.android.material.slider.BaseSlider baseSlider, java.lang.float[] fArr) {
        super.setValues(fArr);
    }

    public static void YSRRqFxpvLrExvOB(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static void YpgdkmstLTANaOVv(com.google.android.material.slider.BaseSlider baseSlider, android.content.res.ColorStateList colorStateList) {
        super.setTickTintList(colorStateList);
    }

    public static void ZKlMHsEfAGDEgRTf(com.google.android.material.slider.BaseSlider baseSlider, android.os.Parcelable parcelable) {
        super.onRestoreInstanceState(parcelable);
    }

    public override void AddOnChangeListener(com.google.android.material.slider.BaseOnChangeListener baseOnChangeListener) {
        fAhkHuWwRonUHecw(this, baseOnChangeListener);
    }

    public override void AddOnSliderTouchListener(com.google.android.material.slider.BaseOnSliderTouchListener baseOnSliderTouchListener) {
        ONbnsIHVWgyVIJwm(this, baseOnSliderTouchListener);
    }

    public override void ClearOnChangeListeners() {
        mKeviguRrYWzFYpJ(this);
    }

    public override void ClearOnSliderTouchListeners() {
        KberlOVyXysPcCIp(this);
    }

    public override bool DispatchHoverEvent(android.view.MotionEvent motionEvent) {
        return nERdsSzQbeQPqeCl(this, motionEvent);
    }

    public override bool DispatchKeyEvent(android.view.KeyEvent keyEvent) {
        return JWlAeEUYMPKAgQyI(this, keyEvent);
    }

    public override java.lang.CharSequence GetAccessibilityClassName() {
        return mnHTamRmbsTrnumo(this);
    }

    public override int GetActiveThumbIndex() {
        return fBxdFrNfVZkIiykA(this);
    }

    public override int GetFocusedThumbIndex() {
        return OgwEhocgIRvuZnjS(this);
    }

    public override int GetHaloRadius() {
        return JdWrpHmwkpViMWCD(this);
    }

    public override android.content.res.ColorStateList GetHaloTintList() {
        return bChtstMSfPLEpipe(this);
    }

    public override int GetLabelBehavior() {
        return cbyZkoEQpdRozQGm(this);
    }

    public override float GetMinSeparation() {
        return this.minSeparation;
    }

    public override float GetStepSize() {
        return RtaIZiXyAgemUsoz(this);
    }

    public override float GetThumbElevation() {
        return uxqLsBZuPsgxXEmY(this);
    }

    public override int GetThumbHeight() {
        return ALwUCoIfvyvfwGbI(this);
    }

    public override int GetThumbRadius() {
        return purOVtlZBDYvfBff(this);
    }

    public override android.content.res.ColorStateList GetThumbStrokeColor() {
        return qsgzylbtkAToZOTw(this);
    }

    public override float GetThumbStrokeWidth() {
        return dccdNeNbbCmTftsf(this);
    }

    public override android.content.res.ColorStateList GetThumbTintList() {
        return GSbTntZjJkvrbcYO(this);
    }

    public override int GetThumbTrackGapSize() {
        return NoLsikPaPBEuTnHS(this);
    }

    public override int GetThumbWidth() {
        return mNKduLbMhJgtFLdj(this);
    }

    public override int GetTickActiveRadius() {
        return CnYygIMfMUaCoQac(this);
    }

    public override android.content.res.ColorStateList GetTickActiveTintList() {
        return XkKLyfKdSDFYeVjb(this);
    }

    public override int GetTickInactiveRadius() {
        return GfjumEkdsBCoYwtZ(this);
    }

    public override android.content.res.ColorStateList GetTickInactiveTintList() {
        return GidGYhHraAEDiqeC(this);
    }

    public override android.content.res.ColorStateList GetTickTintList() {
        return JDUWqTDeZgRCMLnR(this);
    }

    public override android.content.res.ColorStateList GetTrackActiveTintList() {
        return XSnrWcQxrGRNDSWv(this);
    }

    public override int GetTrackHeight() {
        return QlLclUIsSnKYILjl(this);
    }

    public override android.content.res.ColorStateList GetTrackInactiveTintList() {
        return wfEpkgyNRHfQweIs(this);
    }

    public override int GetTrackInsideCornerSize() {
        return uVkKGtIpICxHCzTT(this);
    }

    public override int GetTrackSidePadding() {
        return IooxlGwOUDcQcnOv(this);
    }

    public override int GetTrackStopIndicatorSize() {
        return TyVFYkPCPzmZOOMk(this);
    }

    public override android.content.res.ColorStateList GetTrackTintList() {
        return niMSrYIGEfkIoJzs(this);
    }

    public override int GetTrackWidth() {
        return ZfTiIVjvMFIMGDWg(this);
    }

    public override float GetValueFrom() {
        return MWHCwXBSeGgYEbVi(this);
    }

    public override float GetValueTo() {
        return lTgRVxBUepdpgNDA(this);
    }

    public override java.util.List<java.lang.float> GetValues() {
        return uPkkoERhjPpHmhaq(this);
    }

    public override bool HasLabelFormatter() {
        return HxLDhLQJmqCekwKh(this);
    }

    public override bool IsTickVisible() {
        return kvEravCFWgDPbSdl(this);
    }

    public override bool OnKeyDown(int i, android.view.KeyEvent keyEvent) {
        return eZyeMceajzgDbutP(this, i, keyEvent);
    }

    public override bool OnKeyUp(int i, android.view.KeyEvent keyEvent) {
        return juqwWMUhaDVddgCe(this, i, keyEvent);
    }

    protected override void OnRestoreInstanceState(android.os.Parcelable parcelable) {
        com.google.android.material.slider.RangeSlider$RangeSliderState rangeSlider$RangeSliderState = (com.google.android.material.slider.RangeSlider$RangeSliderState) parcelable;
        zKlMHsEfAGDEgRTf(this, eHXxTUptopOQIkvy(rangeSlider$RangeSliderState));
        this.minSeparation = jEKuVNHZObaKVzrN(rangeSlider$RangeSliderState);
        int iQIsLnAkmMeLyZeiS = qIsLnAkmMeLyZeiS(rangeSlider$RangeSliderState);
        this.separationUnit = iQIsLnAkmMeLyZeiS;
        EwgtAFCpXreFSlgK(this, iQIsLnAkmMeLyZeiS);
    }

    public override android.os.Parcelable OnSaveInstanceState() {
        if ((23 + 19) % 19 > 0) {
        }
        com.google.android.material.slider.RangeSlider$RangeSliderState rangeSlider$RangeSliderState = new com.google.android.material.slider.RangeSlider$RangeSliderState(WKDCfJKKpDsbNqjg(this));
        upEBVJjtiylRXTmY(rangeSlider$RangeSliderState, this.minSeparation);
        vRlfLryZrauKXUPb(rangeSlider$RangeSliderState, this.separationUnit);
        return rangeSlider$RangeSliderState;
    }

    public override bool OnTouchEvent(android.view.MotionEvent motionEvent) {
        return pjhKNBPCuvmeDGus(this, motionEvent);
    }

    public override void RemoveOnChangeListener(com.google.android.material.slider.BaseOnChangeListener baseOnChangeListener) {
        kcpaDioGEQVxXReU(this, baseOnChangeListener);
    }

    public override void RemoveOnSliderTouchListener(com.google.android.material.slider.BaseOnSliderTouchListener baseOnSliderTouchListener) {
        udZynkPbzEbRjGdw(this, baseOnSliderTouchListener);
    }

    public override void SetCustomThumbDrawable(int i) {
        VpDuxJDrWcyyKQmc(this, i);
    }

    public override void SetCustomThumbDrawable(android.graphics.drawable.Drawable drawable) {
        AEwRlbfCFHugBqMx(this, drawable);
    }

    public override void SetCustomThumbDrawablesForValues(int... iArr) {
        QYsqwwywYgdNUoOj(this, iArr);
    }

    public override void SetCustomThumbDrawablesForValues(android.graphics.drawable.Drawable... drawableArr) {
        RrWyEbCyGfYgJefN(this, drawableArr);
    }

    public override void SetEnabled(bool z) {
        FjsLyFBUyUAKqHAz(this, z);
    }

    public override void SetFocusedThumbIndex(int i) {
        uzWLldBXSknsgMML(this, i);
    }

    public override void SetHaloRadius(int i) {
        MlYYqDJcGBpGZcfj(this, i);
    }

    public override void SetHaloRadiusResource(int i) {
        ispydukrZhJoZpwV(this, i);
    }

    public override void SetHaloTintList(android.content.res.ColorStateList colorStateList) {
        GarRfPQmAJdDQGyj(this, colorStateList);
    }

    public override void SetLabelBehavior(int i) {
        uUPlsSZaQNikSQUy(this, i);
    }

    public override void SetLabelFormatter(com.google.android.material.slider.LabelFormatter labelFormatter) {
        ctMoEdqBSbUbVMns(this, labelFormatter);
    }

    public void SetMinSeparation(float f) {
        this.minSeparation = f;
        this.separationUnit = 0;
        SLwUNWGaSgRaPMDy(this, 0);
    }

    public void SetMinSeparationValue(float f) {
        this.minSeparation = f;
        this.separationUnit = 1;
        FuKkRgtBMjtjSyAN(this, 1);
    }

    public override void SetStepSize(float f) {
        WjiRDWrLLxDJXyzP(this, f);
    }

    public override void SetThumbElevation(float f) {
        qBBUFGJYeuyBAsAQ(this, f);
    }

    public override void SetThumbElevationResource(int i) {
        gropVzRZniLKZsJq(this, i);
    }

    public override void SetThumbHeight(int i) {
        DHPoHXtbKPGUVSHY(this, i);
    }

    public override void SetThumbHeightResource(int i) {
        XKlukBvOEZqRNJXe(this, i);
    }

    public override void SetThumbRadius(int i) {
        KHTjeNwFIhDnMxMS(this, i);
    }

    public override void SetThumbRadiusResource(int i) {
        rysQCkJMFMoHpiga(this, i);
    }

    public override void SetThumbStrokeColor(android.content.res.ColorStateList colorStateList) {
        bbTslnQMsfHfWLoz(this, colorStateList);
    }

    public override void SetThumbStrokeColorResource(int i) {
        BOSuFZvVHzqgqYqx(this, i);
    }

    public override void SetThumbStrokeWidth(float f) {
        qaullrgfgFkyuDfM(this, f);
    }

    public override void SetThumbStrokeWidthResource(int i) {
        YcxpXdbrIciogpxe(this, i);
    }

    public override void SetThumbTintList(android.content.res.ColorStateList colorStateList) {
        nKclBkrIlWwucLug(this, colorStateList);
    }

    public override void SetThumbTrackGapSize(int i) {
        SMrBERDNWstwqPqQ(this, i);
    }

    public override void SetThumbWidth(int i) {
        HyKhEQSvJCPUjciy(this, i);
    }

    public override void SetThumbWidthResource(int i) {
        dkRrGccWaJztnAhw(this, i);
    }

    public override void SetTickActiveRadius(int i) {
        egSILWKUGOzDcnJq(this, i);
    }

    public override void SetTickActiveTintList(android.content.res.ColorStateList colorStateList) {
        aXpIubWBfNqwVxsr(this, colorStateList);
    }

    public override void SetTickInactiveRadius(int i) {
        qeZSOTnXVEjzfbwc(this, i);
    }

    public override void SetTickInactiveTintList(android.content.res.ColorStateList colorStateList) {
        sEkgiLlxEBeMAEKe(this, colorStateList);
    }

    public override void SetTickTintList(android.content.res.ColorStateList colorStateList) {
        ypgdkmstLTANaOVv(this, colorStateList);
    }

    public override void SetTickVisible(bool z) {
        ZSFjnOarKOLCXYig(this, z);
    }

    public override void SetTrackActiveTintList(android.content.res.ColorStateList colorStateList) {
        PUtOivfgKpvlHkRn(this, colorStateList);
    }

    public override void SetTrackHeight(int i) {
        PzLuFVmkTQFUqbNm(this, i);
    }

    public override void SetTrackInactiveTintList(android.content.res.ColorStateList colorStateList) {
        gZuEWTlJJYaxNrvD(this, colorStateList);
    }

    public override void SetTrackInsideCornerSize(int i) {
        vZNVyOewzMiafndE(this, i);
    }

    public override void SetTrackStopIndicatorSize(int i) {
        gsuQYUSaNJKNwXHJ(this, i);
    }

    public override void SetTrackTintList(android.content.res.ColorStateList colorStateList) {
        WMKFvjnzGGfmkflf(this, colorStateList);
    }

    public override void SetValueFrom(float f) {
        GEpvAQAzjiMXvERH(this, f);
    }

    public override void SetValueTo(float f) {
        QrbJoOfaXpiIYIdm(this, f);
    }

    public override void SetValues(java.util.List<java.lang.float> list) {
        fEurKWvKwyozvPFd(this, list);
    }

    public override void SetValues(java.lang.float... fArr) {
        xGEwQgUOvzmoRymq(this, fArr);
    }
}

