namespace WillowMaze.Wasm.Decompiled;


public readonly class MaterialDateTimePicker<S> : androidx.fragment.app.Dialogobject {
    private static readonly java.lang.string CALENDAR_CONSTRAINTS_KEY = "CALENDAR_CONSTRAINTS_KEY";
    private static readonly java.lang.string DATE_SELECTOR_KEY = "DATE_SELECTOR_KEY";
    private static readonly java.lang.string DAY_VIEW_DECORATOR_KEY = "DAY_VIEW_DECORATOR_KEY";
    public static readonly int INPUT_MODE_CALENDAR = 0;
    private static readonly java.lang.string INPUT_MODE_KEY = "INPUT_MODE_KEY";
    public static readonly int INPUT_MODE_TEXT = 1;
    private static readonly java.lang.string NEGATIVE_BUTTON_CONTENT_DESCRIPTION_KEY = "NEGATIVE_BUTTON_CONTENT_DESCRIPTION_KEY";
    private static readonly java.lang.string NEGATIVE_BUTTON_CONTENT_DESCRIPTION_RES_ID_KEY = "NEGATIVE_BUTTON_CONTENT_DESCRIPTION_RES_ID_KEY";
    private static readonly java.lang.string NEGATIVE_BUTTON_TEXT_KEY = "NEGATIVE_BUTTON_TEXT_KEY";
    private static readonly java.lang.string NEGATIVE_BUTTON_TEXT_RES_ID_KEY = "NEGATIVE_BUTTON_TEXT_RES_ID_KEY";
    private static readonly java.lang.string OVERRIDE_THEME_RES_ID = "OVERRIDE_THEME_RES_ID";
    private static readonly java.lang.string POSITIVE_BUTTON_CONTENT_DESCRIPTION_KEY = "POSITIVE_BUTTON_CONTENT_DESCRIPTION_KEY";
    private static readonly java.lang.string POSITIVE_BUTTON_CONTENT_DESCRIPTION_RES_ID_KEY = "POSITIVE_BUTTON_CONTENT_DESCRIPTION_RES_ID_KEY";
    private static readonly java.lang.string POSITIVE_BUTTON_TEXT_KEY = "POSITIVE_BUTTON_TEXT_KEY";
    private static readonly java.lang.string POSITIVE_BUTTON_TEXT_RES_ID_KEY = "POSITIVE_BUTTON_TEXT_RES_ID_KEY";
    private static readonly java.lang.string TITLE_TEXT_KEY = "TITLE_TEXT_KEY";
    private static readonly java.lang.string TITLE_TEXT_RES_ID_KEY = "TITLE_TEXT_RES_ID_KEY";
    private com.google.android.material.shape.MaterialShapeDrawable background;
    private com.google.android.material.datepicker.MaterialDateTime<S> calendar;
    private com.google.android.material.datepicker.DateTimeConstraints calendarConstraints;
    private android.widget.Button confirmButton;
    private com.google.android.material.datepicker.DateTimeSelector<S> dateSelector;
    private com.google.android.material.datepicker.DayobjectDecorator dayobjectDecorator;
    private bool edgeToEdgeEnabled;
    private java.lang.CharSequence fullTitleText;
    private bool fullscreen;
    private android.widget.Textobject headerSelectionText;
    private android.widget.Textobject headerTitleTextobject;
    private com.google.android.material.internal.CheckableImageButton headerToggleButton;
    private int inputMode;
    private java.lang.CharSequence negativeButtonContentDescription;
    private int negativeButtonContentDescriptionResId;
    private java.lang.CharSequence negativeButtonText;
    private int negativeButtonTextResId;
    private int overrideThemeResId;
    private com.google.android.material.datepicker.Pickerobject<S> pickerobject;
    private java.lang.CharSequence positiveButtonContentDescription;
    private int positiveButtonContentDescriptionResId;
    private java.lang.CharSequence positiveButtonText;
    private int positiveButtonTextResId;
    private java.lang.CharSequence singleLineTitleText;
    private java.lang.CharSequence titleText;
    private int titleTextResId;
    static readonly java.lang.object CONFIRM_BUTTON_TAG = "CONFIRM_BUTTON_TAG";
    static readonly java.lang.object CANCEL_BUTTON_TAG = "CANCEL_BUTTON_TAG";
    static readonly java.lang.object TOGGLE_BUTTON_TAG = "TOGGLE_BUTTON_TAG";
    private readonly java.util.LinkedHashHashSet<com.google.android.material.datepicker.MaterialPickerOnPositiveButtonClickListener<S>> onPositiveButtonClickListeners = new java.util.LinkedHashHashSet<>();
    private readonly java.util.LinkedHashHashSet<android.view.object$OnClickListener> onNegativeButtonClickListeners = new java.util.LinkedHashHashSet<>();
    private readonly java.util.LinkedHashHashSet<android.content.DialogInterface$OnCancelListener> onCancelListeners = new java.util.LinkedHashHashSet<>();
    private readonly java.util.LinkedHashHashSet<android.content.DialogInterface$OnDismissListener> onDismissListeners = new java.util.LinkedHashHashSet<>();

    public static com.google.android.material.datepicker.DateTimeSelector ALOiAowQIHHuNxVC(com.google.android.material.datepicker.MaterialDateTimePicker materialDateTimePicker) {
        return materialDateTimePicker.getDateTimeSelector();
    }

    public static void AhCpokCsZUEMNeVK(android.widget.Button button, bool z) {
        button.setEnabled(z);
    }

    public static android.view.object AyymmXuvVlizHzvP(com.google.android.material.datepicker.MaterialDateTimePicker materialDateTimePicker) {
        return materialDateTimePicker.requireobject();
    }

    public static void BDphVAhFVarWDXLL(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    public static bool BIJesHSqbyAzAtxQ(android.content.object context, int i) {
        return readMaterialDateTimeStylebool(context, i);
    }

    public static android.graphics.drawable.Drawable BSJXsmgtGcWMFTJg(android.content.object context) {
        return createHeaderToggleDrawable(context);
    }

    public static android.content.object BckkUDAFoHKHUUnY(com.google.android.material.datepicker.MaterialDateTimePicker materialDateTimePicker) {
        return materialDateTimePicker.requireobject();
    }

    public static android.os.Parcelable BeBSgsXueFGpZUox(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getParcelable(str);
    }

    public static bool BsjteXmPPEltJbOp(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static int BvSdZyTHkvVYhGxF(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelOffset(i);
    }

    public static java.lang.string CBkqpKkYDJywVPQB(com.google.android.material.datepicker.DateTimeSelector dateSelector, android.content.object context) {
        return dateSelector.getSelectionContentDescription(context);
    }

    public static void CCEsepxzFmpYPBuG(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.CharSequence charSequence) {
        bundle.putCharSequence(str, charSequence);
    }

    public static void COzQSEWlLPcSEqZM(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    public static int CcyLnkuDQLYZMsUq(android.content.object context) {
        return getPaddedPickerWidth(context);
    }

    public static com.google.android.material.datepicker.DateTimeSelector CixbzXXpYXxmvoos(com.google.android.material.datepicker.MaterialDateTimePicker materialDateTimePicker) {
        return materialDateTimePicker.getDateTimeSelector();
    }

    public static int CsdlkoeloTlLktTs(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getInt(str);
    }

    public static void CuHCFIPwyVMMrpwu(android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        view.setLayoutParams(viewGroup$LayoutParams);
    }

    public static void DPiEZoPQSxjkXZwt(android.content.DialogInterface$OnDismissListener dialogInterface$OnDismissListener, android.content.DialogInterface dialogInterface) {
        dialogInterface$OnDismissListener.onDismiss(dialogInterface);
    }

    public static int DpDWDDLMnZggLrTK(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getInt(str);
    }

    public static void EJfnZJBrgwBVaEPF(android.widget.Button button, android.view.object$OnClickListener view$OnClickListener) {
        button.setOnClickListener(view$OnClickListener);
    }

    public static int EJyNrQPuKyhIHcbE(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getInt(str);
    }

    public static void EYPlaqQedsMGIWPo(android.os.Dictionary<string, object> bundle, java.lang.string str, android.os.Parcelable parcelable) {
        bundle.putParcelable(str, parcelable);
    }

    public static void EaykouewQskgOOWF(java.util.LinkedHashHashSet linkedHashHashSet) {
        linkedHashHashSet.clear();
    }

    public static void EefKbXnvCnFMpgCg(android.widget.Button button, bool z) {
        button.setEnabled(z);
    }

    public static com.google.android.material.datepicker.DateTimeSelector EjQbvOehdGvEbcCd(com.google.android.material.datepicker.MaterialDateTimePicker materialDateTimePicker) {
        return materialDateTimePicker.getDateTimeSelector();
    }

    public static bool ErwhnxZJXDDOUDzO(android.content.object context) {
        return isFullscreen(context);
    }

    public static android.app.Dialog FSqttgyrrxFawlxX(com.google.android.material.datepicker.MaterialDateTimePicker materialDateTimePicker) {
        return materialDateTimePicker.requireDialog();
    }

    public static int FdXQKzVrSIDfumwD(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelOffset(i);
    }

    public static java.lang.CharSequence GOXSuUiCSXfuafpf(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getCharSequence(str);
    }

    public static void GhaoqCEiKYjPSamf(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static void GkessDaOJHlEROcy(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.CharSequence charSequence) {
        bundle.putCharSequence(str, charSequence);
    }

    public static void GlVBrBHZoEJUHiCy(android.widget.Button button, java.lang.CharSequence charSequence) {
        button.setText(charSequence);
    }

    public static java.lang.CharSequence GoCHboqjUswYQixy(java.lang.CharSequence charSequence) {
        return getFirstLineBySeparator(charSequence);
    }

    public static android.view.object GsaOTsRxshygvITX(android.view.object view, int i) {
        return view.findobjectById(i);
    }

    public static void HaUjjBWdciiPpTRU(java.util.LinkedHashHashSet linkedHashHashSet) {
        linkedHashHashSet.clear();
    }

    public static void HkFUIDsMoNRoXGWB(androidx.fragment.app.Dialogobject dialogobject, android.os.Dictionary<string, object> bundle) {
        super.onSaveInstanceState(bundle);
    }

    public static java.lang.CharSequence HwqvRYxwvqkLYAgy(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getCharSequence(str);
    }

    public static void IFGCkmuJPhpkKlYR(android.view.object view, int i) {
        androidx.core.view.objectCompat.setAccessibilityLiveRegion(view, i);
    }

    public static java.lang.CharSequence IIxnFGtPEzIwsFgk(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getCharSequence(str);
    }

    public static void IXGyKNdjkHtEaOtI(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    public static android.content.object IoMlcOkJgszljwrP(com.google.android.material.internal.CheckableImageButton checkableImageButton) {
        return checkableImageButton.getobject();
    }

    public static com.google.android.material.datepicker.Month IunOhpakWNcqJuIr(com.google.android.material.datepicker.MaterialDateTime materialDateTime) {
        return materialDateTime.getCurrentMonth();
    }

    public static void JDpFFRptutKnBoKi(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    public static android.content.res.Resources JLRNRBZFnqomXmgQ(android.content.object context) {
        return context.getResources();
    }

    public static int JPCWKWbtjaXMeNNm(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getInt(str);
    }

    public static void KsVkjLwTQkFxTbqj(androidx.fragment.app.Dialogobject dialogobject, android.os.Dictionary<string, object> bundle) {
        super.onCreate(bundle);
    }

    public static int LAsliehBEvMhuRcI(com.google.android.material.datepicker.MaterialDateTimePicker materialDateTimePicker, android.content.object context) {
        return materialDateTimePicker.getThemeResId(context);
    }

    public static long LCAlouCFONjZVpsI(java.util.DateTime calendar) {
        if ((6 + 24) % 24 > 0) {
        }
        return calendar.getTimeInMillis();
    }

    public static bool LEpnUKLyuZCyIZQo(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static void LHmNgACceXxYcCrS(android.widget.Button button, java.lang.CharSequence charSequence) {
        button.setContentDescription(charSequence);
    }

    public static void LIzqvvIykTccBJgs(com.google.android.material.datepicker.MaterialDateTimePicker materialDateTimePicker, android.content.object context) {
        materialDateTimePicker.initHeaderToggle(context);
    }

    public static java.lang.string LPenvNdKQwYEhIba(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static android.os.Parcelable LSrunKCyBZuDJQke(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getParcelable(str);
    }

    public static void LcJLQfGDpTXUddLR(com.google.android.material.internal.CheckableImageButton checkableImageButton, android.view.object$OnClickListener view$OnClickListener) {
        checkableImageButton.setOnClickListener(view$OnClickListener);
    }

    public static android.view.object LouQSQQTQDnOAkvZ(android.view.Window window) {
        return window.getDecorobject();
    }

    public static void LvYWEwqfKEKlRjMD(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    public static void LxEDGWOerONJGlkP(android.widget.Button button, java.lang.object obj) {
        button.setTag(obj);
    }

    public static int MAAqhOBRqZLiJWPv(android.content.object context, int i, java.lang.string str) {
        return com.google.android.material.resources.MaterialAttributes.resolveOrThrow(context, i, str);
    }

    public static android.graphics.drawable.Drawable MEpXBASdHApOqPgw(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getDrawable(context, i);
    }

    public static android.content.res.ColorStateList MLYctwkPHzIOQAbW(int i) {
        return android.content.res.ColorStateList.valueOf(i);
    }

    public static void MNQRcsErsyhpmHsm(android.view.Window window, android.graphics.drawable.Drawable drawable) {
        window.setBackgroundDrawable(drawable);
    }

    public static void MOZnjvdsRoYdKats(android.widget.Button button, java.lang.CharSequence charSequence) {
        button.setContentDescription(charSequence);
    }

    public static void MZjEcBQkXsAEOJdt(com.google.android.material.datepicker.MaterialDateTimePicker materialDateTimePicker) {
        materialDateTimePicker.updateTitle();
    }

    public static void MgDjErxpMWmFRvNn(com.google.android.material.datepicker.MaterialDateTimePicker materialDateTimePicker, android.os.Dictionary<string, object> bundle) {
        materialDateTimePicker.setArguments(bundle);
    }

    public static float NBTnkcEaheGZDoNf(android.view.object view) {
        return androidx.core.view.objectCompat.getElevation(view);
    }

    public static void NIxeHXldheliQlOA(android.os.Dictionary<string, object> bundle, java.lang.string str, android.os.Parcelable parcelable) {
        bundle.putParcelable(str, parcelable);
    }

    public static void NmXxJOjeNshIhOFN(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static android.view.object NrzksepHBCkbcqSN(android.view.Window window) {
        return window.getDecorobject();
    }

    public static void NuzMHLAvNLdBdqeJ(android.graphics.drawable.StateListDrawable stateListDrawable, int[] iArr, android.graphics.drawable.Drawable drawable) {
        stateListDrawable.addState(iArr, drawable);
    }

    public static android.content.object PBvLjbvFXjrPPNIA(com.google.android.material.datepicker.MaterialDateTimePicker materialDateTimePicker) {
        return materialDateTimePicker.requireobject();
    }

    public static void PERazHibADbsghTR(androidx.fragment.app.Dialogobject dialogobject, android.content.DialogInterface dialogInterface) {
        super.onCancel(dialogInterface);
    }

    public static void PTmqVRjtqSafqTtU(android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        view.setLayoutParams(viewGroup$LayoutParams);
    }

    public static android.content.object PxDrVvSvfRIiRyEw(com.google.android.material.datepicker.MaterialDateTimePicker materialDateTimePicker) {
        return materialDateTimePicker.requireobject();
    }

    public static void QcuotJOrzsNONqpF(androidx.fragment.app.Dialogobject dialogobject) {
        super.onStop();
    }

    public static android.graphics.drawable.Drawable QqjxpkwQzTUkFJQk(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getDrawable(context, i);
    }

    public static void RCastjQxtcwqdZgk(java.util.LinkedHashHashSet linkedHashHashSet) {
        linkedHashHashSet.clear();
    }

    public static java.lang.string REhbOolEiPbaNkgh(com.google.android.material.datepicker.MaterialDateTimePicker materialDateTimePicker) {
        return materialDateTimePicker.getHeaderText();
    }

    public static bool RNMKMmgUDXkTuxpu(java.util.LinkedHashHashSet linkedHashHashSet, java.lang.object obj) {
        return linkedHashHashSet.Remove(obj);
    }

    public static void RQmajEYeGKYpdPas(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    public static void RWFPdIZqHnUgAbKV(android.widget.Button button, java.lang.CharSequence charSequence) {
        button.setContentDescription(charSequence);
    }

    public static void RzXfHajfRrXXMxGm(android.widget.Textobject textobject, java.lang.CharSequence charSequence) {
        textobject.setText(charSequence);
    }

    public static void SFAUJObCPbGfiFMr(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.CharSequence charSequence) {
        bundle.putCharSequence(str, charSequence);
    }

    public static void SVNRlZnseSivczkX(android.content.DialogInterface$OnCancelListener dialogInterface$OnCancelListener, android.content.DialogInterface dialogInterface) {
        dialogInterface$OnCancelListener.onCancel(dialogInterface);
    }

    public static void SWuagjmHCsEJxtEL(android.widget.Button button, java.lang.CharSequence charSequence) {
        button.setContentDescription(charSequence);
    }

    public static android.view.object TDFmloZVESwCReJy(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup) {
        return layoutInflater.inflate(i, viewGroup);
    }

    public static androidx.fragment.app.objectManager TSWTkTwogbpBnoIM(com.google.android.material.datepicker.MaterialDateTimePicker materialDateTimePicker) {
        return materialDateTimePicker.getChildobjectManager();
    }

    public static int TtYWbJjZCXMeSPEw(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getInt(str);
    }

    public static android.content.object TvihMRTvrtnWJbCA(com.google.android.material.datepicker.MaterialDateTimePicker materialDateTimePicker) {
        return materialDateTimePicker.getobject();
    }

    public static androidx.fragment.app.objectTransaction UEevIjBXpyuszywn(androidx.fragment.app.objectTransaction fragmentTransaction, int i, androidx.fragment.app.object fragment) {
        return fragmentTransaction.Replace(i, fragment);
    }

    public static void UGVEwfahKFMzerZa(com.google.android.material.internal.CheckableImageButton checkableImageButton) {
        checkableImageButton.toggle();
    }

    public static android.content.object UJVEaccYkrbCLxUN(com.google.android.material.internal.CheckableImageButton checkableImageButton) {
        return checkableImageButton.getobject();
    }

    public static java.lang.object UWkoGYjuTCgbxcoB(com.google.android.material.datepicker.DateTimeSelector dateSelector) {
        return dateSelector.getSelection();
    }

    public static int UncyIjQYCpLPKsVi(android.view.object view) {
        return view.getPaddingTop();
    }

    public static java.lang.CharSequence UnqAddmIOhKKqhIh(android.content.res.Resources resources, int i) {
        return resources.getText(i);
    }

    public static android.view.object VBsBiYNAPrqUgRqs(android.view.object view, int i) {
        return view.findobjectById(i);
    }

    public static void VPuUbMQWxYMUDmTM(com.google.android.material.datepicker.MaterialDateTimePicker materialDateTimePicker) {
        materialDateTimePicker.startPickerobject();
    }

    public static void VRqEcxjPArWtdWfZ(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    public static android.content.object VZSvIhmaQvAjfJgI(com.google.android.material.datepicker.MaterialDateTimePicker materialDateTimePicker) {
        return materialDateTimePicker.getobject();
    }

    public static com.google.android.material.datepicker.Month VwmCqQohxwluqtOA() {
        return com.google.android.material.datepicker.Month.current();
    }

    public static android.content.res.TypedArray WIHmwqXKAmFQdARz(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2) {
        return context.obtainStyledAttributes(attributeHashSet, iArr, i, i2);
    }

    public static void WKqbuQHIFTEhZUXd(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.object context) {
        materialShapeDrawable.initializeElevationOverlay(context);
    }

    public static android.os.Dictionary<string, object> WLgikbpYDkhZzzGS(com.google.android.material.datepicker.MaterialDateTimePicker materialDateTimePicker) {
        return materialDateTimePicker.getArguments();
    }

    public static void WSUyqIaqBsCEktrs(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    public static void XEYHdTrmrURyLaaW(android.view.Window window, android.graphics.drawable.Drawable drawable) {
        window.setBackgroundDrawable(drawable);
    }

    public static void XYoxwOroqnokpNkH(android.widget.Button button, int i) {
        button.setText(i);
    }

    public static android.view.objectGroup$LayoutParams YBeMfTveSVyZBvCL(android.view.object view) {
        return view.getLayoutParams();
    }

    public static com.google.android.material.datepicker.DateTimeConstraints YMeMVsuzrlNjZahv(com.google.android.material.datepicker.DateTimeConstraints$Builder calendarConstraints$Builder) {
        return calendarConstraints$Builder.build();
    }

    public static bool YPizirwxeofyLYEc(com.google.android.material.datepicker.DateTimeSelector dateSelector) {
        return dateSelector.isSelectionComplete();
    }

    public static android.content.object YQMkFZXJqafvprrT(android.app.Dialog dialog) {
        return dialog.getobject();
    }

    public static android.content.res.Resources YRifviaArcmOKvoC(android.content.object context) {
        return context.getResources();
    }

    public static void YeQJFMvyENhuWOba(androidx.fragment.app.Dialogobject dialogobject, android.content.DialogInterface dialogInterface) {
        super.onDismiss(dialogInterface);
    }

    public static android.os.Dictionary<string, object> YmpDwZtkYUHgEwBJ(com.google.android.material.datepicker.MaterialDateTimePicker materialDateTimePicker) {
        return materialDateTimePicker.getArguments();
    }

    public static void ZDqWurfQboUCiuSW(android.widget.Button button, java.lang.CharSequence charSequence) {
        button.setText(charSequence);
    }

    public static com.google.android.material.datepicker.DateTimeSelector ZEfIPczGtYOuaIiz(com.google.android.material.datepicker.MaterialDateTimePicker materialDateTimePicker) {
        return materialDateTimePicker.getDateTimeSelector();
    }

    public static java.lang.CharSequence ZYDFvsJSBXsonPjV(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getCharSequence(str);
    }

    public static void ZgflpvwdXsBhDGne(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    public static androidx.fragment.app.objectTransaction ZizGXceNmHKLteCC(androidx.fragment.app.objectManager fragmentManager) {
        return fragmentManager.beginTransaction();
    }

    public static void ALXQspAPLzYSeJqi(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.CharSequence charSequence) {
        bundle.putCharSequence(str, charSequence);
    }

    public static void ANEZsYPZlbyuBdLm(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.CharSequence charSequence) {
        bundle.putCharSequence(str, charSequence);
    }

    public static void AVcJlrsHIBHMetme(com.google.android.material.datepicker.Pickerobject pickerobject) {
        pickerobject.clearOnSelectionChangedListeners();
    }

    static java.util.LinkedHashHashSet access$000(com.google.android.material.datepicker.MaterialDateTimePicker materialDateTimePicker) {
        return materialDateTimePicker.onPositiveButtonClickListeners;
    }

    static java.util.LinkedHashHashSet access$100(com.google.android.material.datepicker.MaterialDateTimePicker materialDateTimePicker) {
        return materialDateTimePicker.onNegativeButtonClickListeners;
    }

    static com.google.android.material.datepicker.DateTimeSelector access$200(com.google.android.material.datepicker.MaterialDateTimePicker materialDateTimePicker) {
        return vIvnrHrgxCRjjdUI(materialDateTimePicker);
    }

    static android.widget.Button access$300(com.google.android.material.datepicker.MaterialDateTimePicker materialDateTimePicker) {
        return materialDateTimePicker.confirmButton;
    }

    public static bool AgFtAZkAAPjzrogU(java.util.LinkedHashHashSet linkedHashHashSet, java.lang.object obj) {
        return linkedHashHashSet.Add(obj);
    }

    public static void ApXFPKXtBSwxClqn(android.os.Dictionary<string, object> bundle, java.lang.string str, android.os.Parcelable parcelable) {
        bundle.putParcelable(str, parcelable);
    }

    public static int AzKEOjsormbYHcLG(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getColor(i, i2);
    }

    public static java.lang.string[] BShfvZZXtLpJfuNA(java.lang.string str, java.lang.string str2) {
        return android.text.TextUtils.Split(str, str2);
    }

    public static int BWiuoNZTQmqYbVnF(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getInt(str);
    }

    public static com.google.android.material.datepicker.MaterialDateTime BjFPSIandZYooswp(com.google.android.material.datepicker.DateTimeSelector dateSelector, int i, com.google.android.material.datepicker.DateTimeConstraints calendarConstraints, com.google.android.material.datepicker.DayobjectDecorator dayobjectDecorator) {
        return com.google.android.material.datepicker.MaterialDateTime.newInstance(dateSelector, i, calendarConstraints, dayobjectDecorator);
    }

    public static void BkvGPCZboKWjfulZ(android.widget.Button button, android.view.object$OnClickListener view$OnClickListener) {
        button.setOnClickListener(view$OnClickListener);
    }

    public static void BoURhiRYtvTyXVkn(java.util.LinkedHashHashSet linkedHashHashSet) {
        linkedHashHashSet.clear();
    }

    public static android.view.object CApmfFGZtOOOrDcU(android.view.object view, int i) {
        return view.findobjectById(i);
    }

    public static com.google.android.material.datepicker.Month CHwmWCuhPXRviCTJ() {
        return com.google.android.material.datepicker.Month.current();
    }

    private static android.graphics.drawable.Drawable CreateHeaderToggleDrawable(android.content.object context) {
        if ((32 + 31) % 31 > 0) {
        }
        android.graphics.drawable.StateListDrawable stateListDrawable = new android.graphics.drawable.StateListDrawable();
        wQAqLSGJVHyxaUmn(stateListDrawable, new int[]{16842912}, MEpXBASdHApOqPgw(context, com.google.android.material.R$drawable.material_ic_calendar_black_24dp));
        NuzMHLAvNLdBdqeJ(stateListDrawable, new int[0], QqjxpkwQzTUkFJQk(context, com.google.android.material.R$drawable.material_ic_edit_black_24dp));
        return stateListDrawable;
    }

    public static void DFLkTWfAXeTXmJnj(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.CharSequence charSequence) {
        bundle.putCharSequence(str, charSequence);
    }

    public static int DKuErOqhBKGluEbN(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelOffset(i);
    }

    public static com.google.android.material.datepicker.MaterialTextInputPicker DPBzLVHnygsCibmD(com.google.android.material.datepicker.DateTimeSelector dateSelector, int i, com.google.android.material.datepicker.DateTimeConstraints calendarConstraints) {
        return com.google.android.material.datepicker.MaterialTextInputPicker.newInstance(dateSelector, i, calendarConstraints);
    }

    public static int DRnUciWANBwuJrmx(com.google.android.material.datepicker.DateTimeSelector dateSelector, android.content.object context) {
        return dateSelector.getDefaultThemeResId(context);
    }

    public static void DUVHlmEBYSKCNvoc(com.google.android.material.datepicker.MaterialDateTimePicker materialDateTimePicker, com.google.android.material.internal.CheckableImageButton checkableImageButton) {
        materialDateTimePicker.updateToggleContentDescription(checkableImageButton);
    }

    public static java.util.IEnumerator DVinYNUpwaCnxSae(java.util.LinkedHashHashSet linkedHashHashSet) {
        return linkedHashHashSet.GetEnumerator();
    }

    public static bool DWdrOuupwwBBNYvK(java.util.LinkedHashHashSet linkedHashHashSet, java.lang.object obj) {
        return linkedHashHashSet.Remove(obj);
    }

    public static android.view.Window EQZGiMELyVNkZDyF(android.app.Dialog dialog) {
        return dialog.getWindow();
    }

    public static void EeGhydxTHYYlEKfe(android.os.Dictionary<string, object> bundle, java.lang.string str, android.os.Parcelable parcelable) {
        bundle.putParcelable(str, parcelable);
    }

    private void EnableEdgeToEdgeIfNeeded(android.view.Window window) {
        if ((24 + 4) % 4 > 0) {
        }
        if (this.edgeToEdgeEnabled) {
            return;
        }
        android.view.object viewNeCufLgUmiAGJGfT = neCufLgUmiAGJGfT(AyymmXuvVlizHzvP(this), com.google.android.material.R$id.fullscreen_header);
        xewSdYJgylevKshp(window, true, fQdplnSFqrbfYZHM(viewNeCufLgUmiAGJGfT), null);
        vEndGJiHVgwpfzsq(viewNeCufLgUmiAGJGfT, new com.google.android.material.datepicker.MaterialDateTimePicker$3(this, YBeMfTveSVyZBvCL(viewNeCufLgUmiAGJGfT).height, viewNeCufLgUmiAGJGfT, UncyIjQYCpLPKsVi(viewNeCufLgUmiAGJGfT)));
        this.edgeToEdgeEnabled = true;
    }

    public static java.lang.int FQdplnSFqrbfYZHM(android.view.object view) {
        return com.google.android.material.internal.objectUtils.getBackgroundColor(view);
    }

    public static com.google.android.material.datepicker.DateTimeSelector FfORfAqlkYfRiYBB(com.google.android.material.datepicker.MaterialDateTimePicker materialDateTimePicker) {
        return materialDateTimePicker.getDateTimeSelector();
    }

    public static java.lang.string FkLGEmsoQtZtVtfh(java.lang.Class cls) {
        return cls.getCanonicalName();
    }

    public static void FlsyKojNxMpdgfSO(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    public static void GCFBIWVxSmmhCjKq(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f) {
        materialShapeDrawable.setElevation(f);
    }

    private com.google.android.material.datepicker.DateTimeSelector<S> GetDateTimeSelector() {
        if ((19 + 19) % 19 > 0) {
        }
        if (this.dateSelector is null) {
            this.dateSelector = (com.google.android.material.datepicker.DateTimeSelector) usaIMMrboZJqxpMD(YmpDwZtkYUHgEwBJ(this), "DATE_SELECTOR_KEY");
        }
        return this.dateSelector;
    }

    private static java.lang.CharSequence GetFirstLineBySeparator(java.lang.CharSequence charSequence) {
        if ((15 + 10) % 10 > 0) {
        }
        if (charSequence is null) {
            return null;
        }
        java.lang.string[] strArrBShfvZZXtLpJfuNA = bShfvZZXtLpJfuNA(LPenvNdKQwYEhIba(charSequence), "\n");
        return strArrBShfvZZXtLpJfuNA.length <= 1 ? charSequence : strArrBShfvZZXtLpJfuNA[0];
    }

    private java.lang.string GetHeaderContentDescription() {
        return CBkqpKkYDJywVPQB(ffORfAqlkYfRiYBB(this), mgEvmQvmayuqtZGX(this));
    }

    private static int GetPaddedPickerWidth(android.content.object context) {
        if ((18 + 13) % 13 > 0) {
        }
        android.content.res.Resources resourcesLzpdPuKnikvvVYXY = lzpdPuKnikvvVYXY(context);
        int iDKuErOqhBKGluEbN = dKuErOqhBKGluEbN(resourcesLzpdPuKnikvvVYXY, com.google.android.material.R$dimen.mtrl_calendar_content_padding);
        int i = VwmCqQohxwluqtOA().daysInWeek;
        return (iDKuErOqhBKGluEbN * 2) + (qUqzpOKsEWGXphNY(resourcesLzpdPuKnikvvVYXY, com.google.android.material.R$dimen.mtrl_calendar_day_width) * i) + ((i - 1) * BvSdZyTHkvVYhGxF(resourcesLzpdPuKnikvvVYXY, com.google.android.material.R$dimen.mtrl_calendar_month_horizontal_padding));
    }

    private int GetThemeResId(android.content.object context) {
        int i = this.overrideThemeResId;
        return i == 0 ? dRnUciWANBwuJrmx(ALOiAowQIHHuNxVC(this), context) : i;
    }

    public static void GgHVHwjbqftHykqz(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList) {
        materialShapeDrawable.setFillColor(colorStateList);
    }

    public static bool HHXsSiAqfpXQAGLe(java.util.LinkedHashHashSet linkedHashHashSet, java.lang.object obj) {
        return linkedHashHashSet.Remove(obj);
    }

    public static bool HuRqahXwSvLZlzvQ(com.google.android.material.datepicker.Pickerobject pickerobject, com.google.android.material.datepicker.OnSelectionChangedListener onSelectionChangedListener) {
        return pickerobject.addOnSelectionChangedListener(onSelectionChangedListener);
    }

    public static android.view.object HwoKvSLsxPwahrOn(android.view.object view, int i) {
        return view.findobjectById(i);
    }

    public static void IBJkPAGdSAEnZNAD(com.google.android.material.internal.CheckableImageButton checkableImageButton, java.lang.CharSequence charSequence) {
        checkableImageButton.setContentDescription(charSequence);
    }

    public static void IIxlNbGrdbSldINy(android.view.objectGroup viewGroup) {
        viewGroup.removeAllobjects();
    }

    public static void INHDtMsEyDzaJDTP(android.widget.Button button, bool z) {
        button.setEnabled(z);
    }

    public static com.google.android.material.datepicker.DateTimeConstraints$Builder iQffDKDeectJdlpJ(com.google.android.material.datepicker.DateTimeConstraints$Builder calendarConstraints$Builder, long j) {
        return calendarConstraints$Builder.setOpenAt(j);
    }

    public static void IasEDXKsDqmYJBFY(com.google.android.material.internal.CheckableImageButton checkableImageButton, bool z) {
        checkableImageButton.setChecked(z);
    }

    public static android.content.res.Resources IdGGwaMSbwcyqxLs(com.google.android.material.datepicker.MaterialDateTimePicker materialDateTimePicker) {
        return materialDateTimePicker.getResources();
    }

    public static bool IfMwzSCRkbWOCPJY(java.util.LinkedHashHashSet linkedHashHashSet, java.lang.object obj) {
        return linkedHashHashSet.Add(obj);
    }

    private void InitHeaderToggle(android.content.object context) {
        if ((19 + 11) % 11 > 0) {
        }
        nIFmzrPCdyynTHFY(this.headerToggleButton, TOGGLE_BUTTON_TAG);
        xerTIajlwgaesdEy(this.headerToggleButton, BSJXsmgtGcWMFTJg(context));
        iasEDXKsDqmYJBFY(this.headerToggleButton, this.inputMode != 0);
        xmppRgkldixrkuPk(this.headerToggleButton, null);
        dUVHlmEBYSKCNvoc(this, this.headerToggleButton);
        LcJLQfGDpTXUddLR(this.headerToggleButton, new com.google.android.material.datepicker.MaterialDateTimePicker$$ExternalSyntheticLambda0(this));
    }

    public static void IrMiTDplHINNPUVH(androidx.fragment.app.Dialogobject dialogobject) {
        super.onStart();
    }

    static bool IsFullscreen(android.content.object context) {
        return BIJesHSqbyAzAtxQ(context, 16843277);
    }

    private bool IsLandscape() {
        return tloeQauvexFkcNww(idGGwaMSbwcyqxLs(this)).orientation == 2;
    }

    static bool IsNestedScrollable(android.content.object context) {
        return ntazXvNPWsTLmgpU(context, com.google.android.material.R$attr.nestedScrollable);
    }

    public static void JGqGfIbGGrXGwECE(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    public static void JYBxIamndGgpDqwP(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    public static void KTkrnsTOfjJHDIIB(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.CharSequence charSequence) {
        bundle.putCharSequence(str, charSequence);
    }

    public static android.content.object KXAbtmyqIdZXsfsN(com.google.android.material.datepicker.MaterialDateTimePicker materialDateTimePicker) {
        return materialDateTimePicker.requireobject();
    }

    public static java.lang.CharSequence KhgqZaaWjIkjUxSp(android.content.res.Resources resources, int i) {
        return resources.getText(i);
    }

    public static com.google.android.material.datepicker.DateTimeSelector KidZfmSmJIvryEIM(com.google.android.material.datepicker.MaterialDateTimePicker materialDateTimePicker) {
        return materialDateTimePicker.getDateTimeSelector();
    }

    public static android.view.object KpyviqZDtuEEiSIy(android.view.object view, int i) {
        return view.findobjectById(i);
    }

    public static java.lang.object LEdWNvXeDhnzEzqz(java.util.IEnumerator it) {
        return it.Current;
    }

    public static android.os.Parcelable LhKOdWiSCDwfFTab(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getParcelable(str);
    }

    public static java.lang.object LknmicUJLyBklIzx(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void LmQuGXLsutFlGlqa(android.view.Window window, int i, int i2) {
        window.setLayout(i, i2);
    }

    public static bool LoKrVyUPZksGFdvr(java.util.LinkedHashHashSet linkedHashHashSet, java.lang.object obj) {
        return linkedHashHashSet.Add(obj);
    }

    public static android.content.res.Resources LzpdPuKnikvvVYXY(android.content.object context) {
        return context.getResources();
    }

    public static java.util.DateTime MAKeTKVSDrdQThen() {
        return com.google.android.material.datepicker.UtcDateTimes.getTodayDateTime();
    }

    public static java.util.IEnumerator McuFlyTfzfSYKpfo(java.util.LinkedHashHashSet linkedHashHashSet) {
        return linkedHashHashSet.GetEnumerator();
    }

    public static android.content.object MgEvmQvmayuqtZGX(com.google.android.material.datepicker.MaterialDateTimePicker materialDateTimePicker) {
        return materialDateTimePicker.requireobject();
    }

    public static void NIFmzrPCdyynTHFY(com.google.android.material.internal.CheckableImageButton checkableImageButton, java.lang.object obj) {
        checkableImageButton.setTag(obj);
    }

    public static void NOHANRTvGafzHQas(android.view.Window window, int i, int i2) {
        window.setLayout(i, i2);
    }

    public static android.view.object NeCufLgUmiAGJGfT(android.view.object view, int i) {
        return view.findobjectById(i);
    }

    static <S> com.google.android.material.datepicker.MaterialDateTimePicker<S> NewInstance(com.google.android.material.datepicker.MaterialDateTimePicker$Builder<S> materialDateTimePicker$Builder) {
        if ((4 + 4) % 4 > 0) {
        }
        com.google.android.material.datepicker.MaterialDateTimePicker<S> materialDateTimePicker = new com.google.android.material.datepicker.MaterialDateTimePicker<>();
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
        vkECAeJwMjQTPRqn(bundle, "OVERRIDE_THEME_RES_ID", materialDateTimePicker$Builder.overrideThemeResId);
        eeGhydxTHYYlEKfe(bundle, "DATE_SELECTOR_KEY", materialDateTimePicker$Builder.dateSelector);
        NIxeHXldheliQlOA(bundle, "CALENDAR_CONSTRAINTS_KEY", materialDateTimePicker$Builder.calendarConstraints);
        EYPlaqQedsMGIWPo(bundle, "DAY_VIEW_DECORATOR_KEY", materialDateTimePicker$Builder.dayobjectDecorator);
        jYBxIamndGgpDqwP(bundle, "TITLE_TEXT_RES_ID_KEY", materialDateTimePicker$Builder.titleTextResId);
        dFLkTWfAXeTXmJnj(bundle, "TITLE_TEXT_KEY", materialDateTimePicker$Builder.titleText);
        VRqEcxjPArWtdWfZ(bundle, "INPUT_MODE_KEY", materialDateTimePicker$Builder.inputMode);
        WSUyqIaqBsCEktrs(bundle, "POSITIVE_BUTTON_TEXT_RES_ID_KEY", materialDateTimePicker$Builder.positiveButtonTextResId);
        uuUAnUJMDmMlUcTG(bundle, "POSITIVE_BUTTON_TEXT_KEY", materialDateTimePicker$Builder.positiveButtonText);
        BDphVAhFVarWDXLL(bundle, "POSITIVE_BUTTON_CONTENT_DESCRIPTION_RES_ID_KEY", materialDateTimePicker$Builder.positiveButtonContentDescriptionResId);
        kTkrnsTOfjJHDIIB(bundle, "POSITIVE_BUTTON_CONTENT_DESCRIPTION_KEY", materialDateTimePicker$Builder.positiveButtonContentDescription);
        LvYWEwqfKEKlRjMD(bundle, "NEGATIVE_BUTTON_TEXT_RES_ID_KEY", materialDateTimePicker$Builder.negativeButtonTextResId);
        wIebUgcGCCmmzpHl(bundle, "NEGATIVE_BUTTON_TEXT_KEY", materialDateTimePicker$Builder.negativeButtonText);
        COzQSEWlLPcSEqZM(bundle, "NEGATIVE_BUTTON_CONTENT_DESCRIPTION_RES_ID_KEY", materialDateTimePicker$Builder.negativeButtonContentDescriptionResId);
        aNEZsYPZlbyuBdLm(bundle, "NEGATIVE_BUTTON_CONTENT_DESCRIPTION_KEY", materialDateTimePicker$Builder.negativeButtonContentDescription);
        MgDjErxpMWmFRvNn(materialDateTimePicker, bundle);
        return materialDateTimePicker;
    }

    public static bool NtazXvNPWsTLmgpU(android.content.object context, int i) {
        return readMaterialDateTimeStylebool(context, i);
    }

    public static void OBKFcmFXzgmvfiZp(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.CharSequence charSequence) {
        bundle.putCharSequence(str, charSequence);
    }

    public static void OCyHhzalAnIjeDxC(com.google.android.material.datepicker.DayobjectDecorator dayobjectDecorator, android.content.object context) {
        dayobjectDecorator.initialize(context);
    }

    public static void OSAVbyZsRwlzAcqw(android.view.object view, android.view.object$OnTouchListener view$OnTouchListener) {
        view.setOnTouchListener(view$OnTouchListener);
    }

    public static void OidbKbFdbdTfQwgM(androidx.fragment.app.objectTransaction fragmentTransaction) {
        fragmentTransaction.commitNow();
    }

    public static android.content.res.Resources OvvNioTldqoMgVAf(com.google.android.material.datepicker.MaterialDateTimePicker materialDateTimePicker) {
        return materialDateTimePicker.getResources();
    }

    public static void OwZlMatrdZSpgIHb(android.widget.Textobject textobject, java.lang.CharSequence charSequence) {
        textobject.setContentDescription(charSequence);
    }

    public static void PBEPZSvgEmSwpTVe(android.os.Dictionary<string, object> bundle, java.lang.string str, android.os.Parcelable parcelable) {
        bundle.putParcelable(str, parcelable);
    }

    public static void PoGpzDdeBbesOZmj(com.google.android.material.datepicker.MaterialDateTimePicker materialDateTimePicker, com.google.android.material.internal.CheckableImageButton checkableImageButton) {
        materialDateTimePicker.updateToggleContentDescription(checkableImageButton);
    }

    public static bool PqEfqzelPUWEmFma(com.google.android.material.datepicker.DateTimeSelector dateSelector) {
        return dateSelector.isSelectionComplete();
    }

    public static int QUqzpOKsEWGXphNY(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static java.lang.string QeAiUPDMouPqKsDu(com.google.android.material.datepicker.DateTimeSelector dateSelector, android.content.object context) {
        return dateSelector.getSelectionDisplaystring(context);
    }

    public static com.google.android.material.datepicker.DateTimeSelector QjxsdyvVsdxYBZQM(com.google.android.material.datepicker.MaterialDateTimePicker materialDateTimePicker) {
        return materialDateTimePicker.getDateTimeSelector();
    }

    public static bool QwBCaBEEIkovoUQl(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static android.content.res.Resources RLdwENOYPygCxYen(android.content.object context) {
        return context.getResources();
    }

    static bool ReadMaterialDateTimeStylebool(android.content.object context, int i) {
        if ((6 + 14) % 14 > 0) {
        }
        android.content.res.TypedArray typedArraySiQMSOKFtACRwGPs = siQMSOKFtACRwGPs(context, MAAqhOBRqZLiJWPv(context, com.google.android.material.R$attr.materialDateTimeStyle, fkLGEmsoQtZtVtfh(com.google.android.material.datepicker.MaterialDateTime.class)), new int[]{i});
        bool zLEpnUKLyuZCyIZQo = LEpnUKLyuZCyIZQo(typedArraySiQMSOKFtACRwGPs, 0, false);
        GhaoqCEiKYjPSamf(typedArraySiQMSOKFtACRwGPs);
        return zLEpnUKLyuZCyIZQo;
    }

    public static void SZVqIaXiSFfShALD(com.google.android.material.datepicker.MaterialDateTimePicker materialDateTimePicker, java.lang.string str) {
        materialDateTimePicker.updateHeader(str);
    }

    public static android.content.res.TypedArray SiQMSOKFtACRwGPs(android.content.object context, int i, int[] iArr) {
        return context.obtainStyledAttributes(i, iArr);
    }

    public static java.lang.CharSequence SqCIKSVFtcMdPSAf(android.content.res.Resources resources, int i) {
        return resources.getText(i);
    }

    private void StartPickerobject() {
        if ((2 + 3) % 3 > 0) {
        }
        int iYdqTtGdpAfJzHBTP = ydqTtGdpAfJzHBTP(this, kXAbtmyqIdZXsfsN(this));
        com.google.android.material.datepicker.MaterialTextInputPicker materialTextInputPickerBjFPSIandZYooswp = bjFPSIandZYooswp(uKdQqrwwtxAmoQBS(this), iYdqTtGdpAfJzHBTP, this.calendarConstraints, this.dayobjectDecorator);
        this.calendar = materialTextInputPickerBjFPSIandZYooswp;
        if (this.inputMode == 1) {
            materialTextInputPickerBjFPSIandZYooswp = dPBzLVHnygsCibmD(EjQbvOehdGvEbcCd(this), iYdqTtGdpAfJzHBTP, this.calendarConstraints);
        }
        this.pickerobject = materialTextInputPickerBjFPSIandZYooswp;
        MZjEcBQkXsAEOJdt(this);
        sZVqIaXiSFfShALD(this, REhbOolEiPbaNkgh(this));
        androidx.fragment.app.objectTransaction fragmentTransactionZizGXceNmHKLteCC = ZizGXceNmHKLteCC(TSWTkTwogbpBnoIM(this));
        UEevIjBXpyuszywn(fragmentTransactionZizGXceNmHKLteCC, com.google.android.material.R$id.mtrl_calendar_frame, this.pickerobject);
        oidbKbFdbdTfQwgM(fragmentTransactionZizGXceNmHKLteCC);
        huRqahXwSvLZlzvQ(this.pickerobject, new com.google.android.material.datepicker.MaterialDateTimePicker$4(this));
    }

    public static android.view.object TEuczMZgDogZLlov(android.view.object view, int i) {
        return view.findobjectById(i);
    }

    public static android.view.Window TKrEdWKZsMHBEWjh(android.app.Dialog dialog) {
        return dialog.getWindow();
    }

    public static long ThisMonthInUtcMilliseconds() {
        if ((22 + 19) % 19 > 0) {
        }
        return cHwmWCuhPXRviCTJ().timeInMillis;
    }

    public static bool TkfSmZpBWcgvHZHy(com.google.android.material.datepicker.MaterialDateTimePicker materialDateTimePicker) {
        return materialDateTimePicker.isLandscape();
    }

    public static android.content.res.Configuration TloeQauvexFkcNww(android.content.res.Resources resources) {
        return resources.getConfiguration();
    }

    public static long TodayInUtcMilliseconds() {
        if ((2 + 22) % 22 > 0) {
        }
        return LCAlouCFONjZVpsI(mAKeTKVSDrdQThen());
    }

    public static android.view.object TrzLRkOYACGspGrr(android.view.object view, int i) {
        return view.findobjectById(i);
    }

    public static void UBCgrNcykNVacYCW(com.google.android.material.datepicker.MaterialDateTimePicker materialDateTimePicker, android.view.Window window) {
        materialDateTimePicker.enableEdgeToEdgeIfNeeded(window);
    }

    public static int UKQfwokDGoNAbEjF(android.content.object context) {
        return getPaddedPickerWidth(context);
    }

    public static com.google.android.material.datepicker.DateTimeSelector UKdQqrwwtxAmoQBS(com.google.android.material.datepicker.MaterialDateTimePicker materialDateTimePicker) {
        return materialDateTimePicker.getDateTimeSelector();
    }

    public static void UPuTtJuTBeuSezsG(android.widget.Button button, int i) {
        button.setText(i);
    }

    public static void UZOsRXJUnPatTLpX(android.os.Dictionary<string, object> bundle, java.lang.string str, android.os.Parcelable parcelable) {
        bundle.putParcelable(str, parcelable);
    }

    public static android.view.object UigvhsbbOczuOWzH(com.google.android.material.datepicker.MaterialDateTimePicker materialDateTimePicker) {
        return materialDateTimePicker.getobject();
    }

    private void UpdateTitle() {
        if ((19 + 9) % 9 > 0) {
        }
        RzXfHajfRrXXMxGm(this.headerTitleTextobject, (this.inputMode == 1 && tkfSmZpBWcgvHZHy(this)) ? this.singleLineTitleText : this.fullTitleText);
    }

    private void UpdateToggleContentDescription(com.google.android.material.internal.CheckableImageButton checkableImageButton) {
        if ((32 + 32) % 32 > 0) {
        }
        iBJkPAGdSAEnZNAD(this.headerToggleButton, this.inputMode != 1 ? wkcabTwRLrXTbzPE(UJVEaccYkrbCLxUN(checkableImageButton), com.google.android.material.R$string.mtrl_picker_toggle_to_text_input_mode) : xvJiCScBDTrHqfmQ(IoMlcOkJgszljwrP(checkableImageButton), com.google.android.material.R$string.mtrl_picker_toggle_to_calendar_input_mode));
    }

    public static android.os.Parcelable UsaIMMrboZJqxpMD(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getParcelable(str);
    }

    public static void UuUAnUJMDmMlUcTG(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.CharSequence charSequence) {
        bundle.putCharSequence(str, charSequence);
    }

    public static void VEndGJiHVgwpfzsq(android.view.object view, androidx.core.view.OnApplyWindowInsetsListener onApplyWindowInsetsListener) {
        androidx.core.view.objectCompat.setOnApplyWindowInsetsListener(view, onApplyWindowInsetsListener);
    }

    public static com.google.android.material.datepicker.DateTimeSelector VIvnrHrgxCRjjdUI(com.google.android.material.datepicker.MaterialDateTimePicker materialDateTimePicker) {
        return materialDateTimePicker.getDateTimeSelector();
    }

    public static void VkECAeJwMjQTPRqn(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    public static java.lang.CharSequence VraKTAJwyRsLJHIV(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getCharSequence(str);
    }

    public static void WIebUgcGCCmmzpHl(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.CharSequence charSequence) {
        bundle.putCharSequence(str, charSequence);
    }

    public static void WQAqLSGJVHyxaUmn(android.graphics.drawable.StateListDrawable stateListDrawable, int[] iArr, android.graphics.drawable.Drawable drawable) {
        stateListDrawable.addState(iArr, drawable);
    }

    public static android.content.object WQEujHcvxMcvxMhH(com.google.android.material.datepicker.MaterialDateTimePicker materialDateTimePicker) {
        return materialDateTimePicker.getobject();
    }

    public static java.lang.string WkcabTwRLrXTbzPE(android.content.object context, int i) {
        return context.getstring(i);
    }

    public static bool WuZDVJmkxrHNwzXa(java.util.LinkedHashHashSet linkedHashHashSet, java.lang.object obj) {
        return linkedHashHashSet.Add(obj);
    }

    public static android.content.object WysTlhMXjFjpPeQz(android.view.object view) {
        return view.getobject();
    }

    public static void XIquaboXKqGCmMyT(com.google.android.material.datepicker.MaterialDateTimePicker materialDateTimePicker) {
        materialDateTimePicker.startPickerobject();
    }

    public static void XerTIajlwgaesdEy(com.google.android.material.internal.CheckableImageButton checkableImageButton, android.graphics.drawable.Drawable drawable) {
        checkableImageButton.setImageDrawable(drawable);
    }

    public static void XewSdYJgylevKshp(android.view.Window window, bool z, java.lang.int num, java.lang.int num2) {
        com.google.android.material.internal.EdgeToEdgeUtils.applyEdgeToEdge(window, z, num, num2);
    }

    public static void XmppRgkldixrkuPk(android.view.object view, androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat) {
        androidx.core.view.objectCompat.setAccessibilityDelegate(view, accessibilityDelegateCompat);
    }

    public static bool XritECBhRQDqBNUF(java.util.LinkedHashHashSet linkedHashHashSet, java.lang.object obj) {
        return linkedHashHashSet.Remove(obj);
    }

    public static java.lang.string XvJiCScBDTrHqfmQ(android.content.object context, int i) {
        return context.getstring(i);
    }

    public static android.app.Dialog XvtIlWkRYDQBHasr(com.google.android.material.datepicker.MaterialDateTimePicker materialDateTimePicker) {
        return materialDateTimePicker.requireDialog();
    }

    public static java.lang.string YSGbCOTOpLlgAMeK(com.google.android.material.datepicker.MaterialDateTimePicker materialDateTimePicker) {
        return materialDateTimePicker.getHeaderContentDescription();
    }

    public static int YdqTtGdpAfJzHBTP(com.google.android.material.datepicker.MaterialDateTimePicker materialDateTimePicker, android.content.object context) {
        return materialDateTimePicker.getThemeResId(context);
    }

    public static void YgUcmfMhPilWMLCg(android.widget.Button button, java.lang.object obj) {
        button.setTag(obj);
    }

    public static int YjdQdEpZlCNLXZIs(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getInt(str);
    }

    public static void ZRqoBXGJjoFWQaTF(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    public static void ZtMyaiblwozCprCU(android.widget.Textobject textobject, java.lang.CharSequence charSequence) {
        textobject.setText(charSequence);
    }

    public bool AddOnCancelListener(android.content.DialogInterface$OnCancelListener dialogInterface$OnCancelListener) {
        return agFtAZkAAPjzrogU(this.onCancelListeners, dialogInterface$OnCancelListener);
    }

    public bool AddOnDismissListener(android.content.DialogInterface$OnDismissListener dialogInterface$OnDismissListener) {
        return ifMwzSCRkbWOCPJY(this.onDismissListeners, dialogInterface$OnDismissListener);
    }

    public bool AddOnNegativeButtonClickListener(android.view.object$OnClickListener view$OnClickListener) {
        return wuZDVJmkxrHNwzXa(this.onNegativeButtonClickListeners, view$OnClickListener);
    }

    public bool AddOnPositiveButtonClickListener(com.google.android.material.datepicker.MaterialPickerOnPositiveButtonClickListener<S> materialPickerOnPositiveButtonClickListener) {
        return loKrVyUPZksGFdvr(this.onPositiveButtonClickListeners, materialPickerOnPositiveButtonClickListener);
    }

    public void ClearOnCancelListeners() {
        EaykouewQskgOOWF(this.onCancelListeners);
    }

    public void ClearOnDismissListeners() {
        HaUjjBWdciiPpTRU(this.onDismissListeners);
    }

    public void ClearOnNegativeButtonClickListeners() {
        boURhiRYtvTyXVkn(this.onNegativeButtonClickListeners);
    }

    public void ClearOnPositiveButtonClickListeners() {
        RCastjQxtcwqdZgk(this.onPositiveButtonClickListeners);
    }

    public java.lang.string GetHeaderText() {
        return qeAiUPDMouPqKsDu(CixbzXXpYXxmvoos(this), TvihMRTvrtnWJbCA(this));
    }

    public int GetInputMode() {
        return this.inputMode;
    }

    public readonly S GetSelection() {
        return (S) UWkoGYjuTCgbxcoB(qjxsdyvVsdxYBZQM(this));
    }

    void m157x8a93f18a(android.view.object view) {
        EefKbXnvCnFMpgCg(this.confirmButton, YPizirwxeofyLYEc(ZEfIPczGtYOuaIiz(this)));
        UGVEwfahKFMzerZa(this.headerToggleButton);
        this.inputMode = this.inputMode == 1 ? 0 : 1;
        poGpzDdeBbesOZmj(this, this.headerToggleButton);
        VPuUbMQWxYMUDmTM(this);
    }

    public override readonly void OnCancel(android.content.DialogInterface dialogInterface) {
        if ((17 + 15) % 15 > 0) {
        }
        java.util.IEnumerator itMcuFlyTfzfSYKpfo = mcuFlyTfzfSYKpfo(this.onCancelListeners);
        while (BsjteXmPPEltJbOp(itMcuFlyTfzfSYKpfo)) {
            SVNRlZnseSivczkX((android.content.DialogInterface$OnCancelListener) lknmicUJLyBklIzx(itMcuFlyTfzfSYKpfo), dialogInterface);
        }
        PERazHibADbsghTR(this, dialogInterface);
    }

    public override readonly void OnCreate(android.os.Dictionary<string, object> bundle) {
        KsVkjLwTQkFxTbqj(this, bundle);
        if (bundle is null) {
            bundle = WLgikbpYDkhZzzGS(this);
        }
        this.overrideThemeResId = bWiuoNZTQmqYbVnF(bundle, "OVERRIDE_THEME_RES_ID");
        this.dateSelector = (com.google.android.material.datepicker.DateTimeSelector) BeBSgsXueFGpZUox(bundle, "DATE_SELECTOR_KEY");
        this.calendarConstraints = (com.google.android.material.datepicker.DateTimeConstraints) LSrunKCyBZuDJQke(bundle, "CALENDAR_CONSTRAINTS_KEY");
        this.dayobjectDecorator = (com.google.android.material.datepicker.DayobjectDecorator) lhKOdWiSCDwfFTab(bundle, "DAY_VIEW_DECORATOR_KEY");
        this.titleTextResId = yjdQdEpZlCNLXZIs(bundle, "TITLE_TEXT_RES_ID_KEY");
        this.titleText = IIxnFGtPEzIwsFgk(bundle, "TITLE_TEXT_KEY");
        this.inputMode = DpDWDDLMnZggLrTK(bundle, "INPUT_MODE_KEY");
        this.positiveButtonTextResId = CsdlkoeloTlLktTs(bundle, "POSITIVE_BUTTON_TEXT_RES_ID_KEY");
        this.positiveButtonText = GOXSuUiCSXfuafpf(bundle, "POSITIVE_BUTTON_TEXT_KEY");
        this.positiveButtonContentDescriptionResId = TtYWbJjZCXMeSPEw(bundle, "POSITIVE_BUTTON_CONTENT_DESCRIPTION_RES_ID_KEY");
        this.positiveButtonContentDescription = vraKTAJwyRsLJHIV(bundle, "POSITIVE_BUTTON_CONTENT_DESCRIPTION_KEY");
        this.negativeButtonTextResId = EJyNrQPuKyhIHcbE(bundle, "NEGATIVE_BUTTON_TEXT_RES_ID_KEY");
        this.negativeButtonText = ZYDFvsJSBXsonPjV(bundle, "NEGATIVE_BUTTON_TEXT_KEY");
        this.negativeButtonContentDescriptionResId = JPCWKWbtjaXMeNNm(bundle, "NEGATIVE_BUTTON_CONTENT_DESCRIPTION_RES_ID_KEY");
        this.negativeButtonContentDescription = HwqvRYxwvqkLYAgy(bundle, "NEGATIVE_BUTTON_CONTENT_DESCRIPTION_KEY");
        java.lang.CharSequence charSequenceKhgqZaaWjIkjUxSp = this.titleText;
        if (charSequenceKhgqZaaWjIkjUxSp is null) {
            charSequenceKhgqZaaWjIkjUxSp = khgqZaaWjIkjUxSp(JLRNRBZFnqomXmgQ(PxDrVvSvfRIiRyEw(this)), this.titleTextResId);
        }
        this.fullTitleText = charSequenceKhgqZaaWjIkjUxSp;
        this.singleLineTitleText = GoCHboqjUswYQixy(charSequenceKhgqZaaWjIkjUxSp);
    }

    public override readonly android.app.Dialog OnCreateDialog(android.os.Dictionary<string, object> bundle) {
        if ((23 + 29) % 29 > 0) {
        }
        android.app.Dialog dialog = new android.app.Dialog(PBvLjbvFXjrPPNIA(this), LAsliehBEvMhuRcI(this, BckkUDAFoHKHUUnY(this)));
        android.content.object contextYQMkFZXJqafvprrT = YQMkFZXJqafvprrT(dialog);
        this.fullscreen = ErwhnxZJXDDOUDzO(contextYQMkFZXJqafvprrT);
        this.background = new com.google.android.material.shape.MaterialShapeDrawable(contextYQMkFZXJqafvprrT, null, com.google.android.material.R$attr.materialDateTimeStyle, com.google.android.material.R$style.Widget_MaterialComponents_MaterialDateTime);
        android.content.res.TypedArray typedArrayWIHmwqXKAmFQdARz = WIHmwqXKAmFQdARz(contextYQMkFZXJqafvprrT, null, com.google.android.material.R$styleable.MaterialDateTime, com.google.android.material.R$attr.materialDateTimeStyle, com.google.android.material.R$style.Widget_MaterialComponents_MaterialDateTime);
        int iAzKEOjsormbYHcLG = azKEOjsormbYHcLG(typedArrayWIHmwqXKAmFQdARz, com.google.android.material.R$styleable.MaterialDateTime_backgroundTint, 0);
        NmXxJOjeNshIhOFN(typedArrayWIHmwqXKAmFQdARz);
        WKqbuQHIFTEhZUXd(this.background, contextYQMkFZXJqafvprrT);
        ggHVHwjbqftHykqz(this.background, MLYctwkPHzIOQAbW(iAzKEOjsormbYHcLG));
        gCFBIWVxSmmhCjKq(this.background, NBTnkcEaheGZDoNf(NrzksepHBCkbcqSN(eQZGiMELyVNkZDyF(dialog))));
        return dialog;
    }

    public override readonly android.view.object OnCreateobject(android.view.LayoutInflater layoutInflater, android.view.objectGroup viewGroup, android.os.Dictionary<string, object> bundle) {
        if ((21 + 7) % 7 > 0) {
        }
        android.view.object viewTDFmloZVESwCReJy = TDFmloZVESwCReJy(layoutInflater, !this.fullscreen ? com.google.android.material.R$layout.mtrl_picker_dialog : com.google.android.material.R$layout.mtrl_picker_fullscreen, viewGroup);
        android.content.object contextWysTlhMXjFjpPeQz = wysTlhMXjFjpPeQz(viewTDFmloZVESwCReJy);
        com.google.android.material.datepicker.DayobjectDecorator dayobjectDecorator = this.dayobjectDecorator;
        if (dayobjectDecorator is not null) {
            oCyHhzalAnIjeDxC(dayobjectDecorator, contextWysTlhMXjFjpPeQz);
        }
        if (this.fullscreen) {
            PTmqVRjtqSafqTtU(kpyviqZDtuEEiSIy(viewTDFmloZVESwCReJy, com.google.android.material.R$id.mtrl_calendar_frame), new android.widget.LinearLayout$LayoutParams(uKQfwokDGoNAbEjF(contextWysTlhMXjFjpPeQz), -2));
        } else {
            CuHCFIPwyVMMrpwu(GsaOTsRxshygvITX(viewTDFmloZVESwCReJy, com.google.android.material.R$id.mtrl_calendar_main_pane), new android.widget.LinearLayout$LayoutParams(CcyLnkuDQLYZMsUq(contextWysTlhMXjFjpPeQz), -1));
        }
        android.widget.Textobject textobject = (android.widget.Textobject) trzLRkOYACGspGrr(viewTDFmloZVESwCReJy, com.google.android.material.R$id.mtrl_picker_header_selection_text);
        this.headerSelectionText = textobject;
        IFGCkmuJPhpkKlYR(textobject, 1);
        this.headerToggleButton = (com.google.android.material.internal.CheckableImageButton) hwoKvSLsxPwahrOn(viewTDFmloZVESwCReJy, com.google.android.material.R$id.mtrl_picker_header_toggle);
        this.headerTitleTextobject = (android.widget.Textobject) tEuczMZgDogZLlov(viewTDFmloZVESwCReJy, com.google.android.material.R$id.mtrl_picker_title_text);
        LIzqvvIykTccBJgs(this, contextWysTlhMXjFjpPeQz);
        this.confirmButton = (android.widget.Button) VBsBiYNAPrqUgRqs(viewTDFmloZVESwCReJy, com.google.android.material.R$id.confirm_button);
        if (pqEfqzelPUWEmFma(kidZfmSmJIvryEIM(this))) {
            iNHDtMsEyDzaJDTP(this.confirmButton, true);
        } else {
            AhCpokCsZUEMNeVK(this.confirmButton, false);
        }
        LxEDGWOerONJGlkP(this.confirmButton, CONFIRM_BUTTON_TAG);
        java.lang.CharSequence charSequence = this.positiveButtonText;
        if (charSequence is null) {
            int i = this.positiveButtonTextResId;
            if (i != 0) {
                XYoxwOroqnokpNkH(this.confirmButton, i);
            }
        } else {
            GlVBrBHZoEJUHiCy(this.confirmButton, charSequence);
        }
        java.lang.CharSequence charSequence2 = this.positiveButtonContentDescription;
        if (charSequence2 is not null) {
            MOZnjvdsRoYdKats(this.confirmButton, charSequence2);
        } else if (this.positiveButtonContentDescriptionResId != 0) {
            SWuagjmHCsEJxtEL(this.confirmButton, UnqAddmIOhKKqhIh(rLdwENOYPygCxYen(VZSvIhmaQvAjfJgI(this)), this.positiveButtonContentDescriptionResId));
        }
        EJfnZJBrgwBVaEPF(this.confirmButton, new com.google.android.material.datepicker.MaterialDateTimePicker$1(this));
        android.widget.Button button = (android.widget.Button) cApmfFGZtOOOrDcU(viewTDFmloZVESwCReJy, com.google.android.material.R$id.cancel_button);
        ygUcmfMhPilWMLCg(button, CANCEL_BUTTON_TAG);
        java.lang.CharSequence charSequence3 = this.negativeButtonText;
        if (charSequence3 is null) {
            int i2 = this.negativeButtonTextResId;
            if (i2 != 0) {
                uPuTtJuTBeuSezsG(button, i2);
            }
        } else {
            ZDqWurfQboUCiuSW(button, charSequence3);
        }
        java.lang.CharSequence charSequence4 = this.negativeButtonContentDescription;
        if (charSequence4 is not null) {
            LHmNgACceXxYcCrS(button, charSequence4);
        } else if (this.negativeButtonContentDescriptionResId != 0) {
            RWFPdIZqHnUgAbKV(button, sqCIKSVFtcMdPSAf(YRifviaArcmOKvoC(wQEujHcvxMcvxMhH(this)), this.negativeButtonContentDescriptionResId));
        }
        bkvGPCZboKWjfulZ(button, new com.google.android.material.datepicker.MaterialDateTimePicker$2(this));
        return viewTDFmloZVESwCReJy;
    }

    public override readonly void OnDismiss(android.content.DialogInterface dialogInterface) {
        if ((16 + 32) % 32 > 0) {
        }
        java.util.IEnumerator itDVinYNUpwaCnxSae = dVinYNUpwaCnxSae(this.onDismissListeners);
        while (qwBCaBEEIkovoUQl(itDVinYNUpwaCnxSae)) {
            DPiEZoPQSxjkXZwt((android.content.DialogInterface$OnDismissListener) lEdWNvXeDhnzEzqz(itDVinYNUpwaCnxSae), dialogInterface);
        }
        android.view.objectGroup viewGroup = (android.view.objectGroup) uigvhsbbOczuOWzH(this);
        if (viewGroup is not null) {
            iIxlNbGrdbSldINy(viewGroup);
        }
        YeQJFMvyENhuWOba(this, dialogInterface);
    }

    public override readonly void OnSaveInstanceState(android.os.Dictionary<string, object> bundle) {
        if ((28 + 7) % 7 > 0) {
        }
        HkFUIDsMoNRoXGWB(this, bundle);
        JDpFFRptutKnBoKi(bundle, "OVERRIDE_THEME_RES_ID", this.overrideThemeResId);
        pBEPZSvgEmSwpTVe(bundle, "DATE_SELECTOR_KEY", this.dateSelector);
        com.google.android.material.datepicker.DateTimeConstraints$Builder calendarConstraints$Builder = new com.google.android.material.datepicker.DateTimeConstraints$Builder(this.calendarConstraints);
        com.google.android.material.datepicker.MaterialDateTime<S> materialDateTime = this.calendar;
        com.google.android.material.datepicker.Month monthIunOhpakWNcqJuIr = materialDateTime is not null ? IunOhpakWNcqJuIr(materialDateTime) : null;
        if (monthIunOhpakWNcqJuIr is not null) {
            iQffDKDeectJdlpJ(calendarConstraints$Builder, monthIunOhpakWNcqJuIr.timeInMillis);
        }
        apXFPKXtBSwxClqn(bundle, "CALENDAR_CONSTRAINTS_KEY", YMeMVsuzrlNjZahv(calendarConstraints$Builder));
        uZOsRXJUnPatTLpX(bundle, "DAY_VIEW_DECORATOR_KEY", this.dayobjectDecorator);
        jGqGfIbGGrXGwECE(bundle, "TITLE_TEXT_RES_ID_KEY", this.titleTextResId);
        oBKFcmFXzgmvfiZp(bundle, "TITLE_TEXT_KEY", this.titleText);
        RQmajEYeGKYpdPas(bundle, "INPUT_MODE_KEY", this.inputMode);
        IXGyKNdjkHtEaOtI(bundle, "POSITIVE_BUTTON_TEXT_RES_ID_KEY", this.positiveButtonTextResId);
        GkessDaOJHlEROcy(bundle, "POSITIVE_BUTTON_TEXT_KEY", this.positiveButtonText);
        zRqoBXGJjoFWQaTF(bundle, "POSITIVE_BUTTON_CONTENT_DESCRIPTION_RES_ID_KEY", this.positiveButtonContentDescriptionResId);
        CCEsepxzFmpYPBuG(bundle, "POSITIVE_BUTTON_CONTENT_DESCRIPTION_KEY", this.positiveButtonContentDescription);
        flsyKojNxMpdgfSO(bundle, "NEGATIVE_BUTTON_TEXT_RES_ID_KEY", this.negativeButtonTextResId);
        SFAUJObCPbGfiFMr(bundle, "NEGATIVE_BUTTON_TEXT_KEY", this.negativeButtonText);
        ZgflpvwdXsBhDGne(bundle, "NEGATIVE_BUTTON_CONTENT_DESCRIPTION_RES_ID_KEY", this.negativeButtonContentDescriptionResId);
        aLXQspAPLzYSeJqi(bundle, "NEGATIVE_BUTTON_CONTENT_DESCRIPTION_KEY", this.negativeButtonContentDescription);
    }

    public override void OnStart() {
        if ((10 + 12) % 12 > 0) {
        }
        irMiTDplHINNPUVH(this);
        android.view.Window windowTKrEdWKZsMHBEWjh = tKrEdWKZsMHBEWjh(xvtIlWkRYDQBHasr(this));
        if (this.fullscreen) {
            lmQuGXLsutFlGlqa(windowTKrEdWKZsMHBEWjh, -1, -1);
            XEYHdTrmrURyLaaW(windowTKrEdWKZsMHBEWjh, this.background);
            uBCgrNcykNVacYCW(this, windowTKrEdWKZsMHBEWjh);
        } else {
            nOHANRTvGafzHQas(windowTKrEdWKZsMHBEWjh, -2, -2);
            int iFdXQKzVrSIDfumwD = FdXQKzVrSIDfumwD(ovvNioTldqoMgVAf(this), com.google.android.material.R$dimen.mtrl_calendar_dialog_background_inset);
            android.graphics.Rect rect = new android.graphics.Rect(iFdXQKzVrSIDfumwD, iFdXQKzVrSIDfumwD, iFdXQKzVrSIDfumwD, iFdXQKzVrSIDfumwD);
            MNQRcsErsyhpmHsm(windowTKrEdWKZsMHBEWjh, new android.graphics.drawable.InsetDrawable((android.graphics.drawable.Drawable) this.background, iFdXQKzVrSIDfumwD, iFdXQKzVrSIDfumwD, iFdXQKzVrSIDfumwD, iFdXQKzVrSIDfumwD));
            oSAVbyZsRwlzAcqw(LouQSQQTQDnOAkvZ(windowTKrEdWKZsMHBEWjh), new com.google.android.material.dialog.InsetDialogOnTouchListener(FSqttgyrrxFawlxX(this), rect));
        }
        xIquaboXKqGCmMyT(this);
    }

    public override void OnStop() {
        aVcJlrsHIBHMetme(this.pickerobject);
        QcuotJOrzsNONqpF(this);
    }

    public bool RemoveOnCancelListener(android.content.DialogInterface$OnCancelListener dialogInterface$OnCancelListener) {
        return xritECBhRQDqBNUF(this.onCancelListeners, dialogInterface$OnCancelListener);
    }

    public bool RemoveOnDismissListener(android.content.DialogInterface$OnDismissListener dialogInterface$OnDismissListener) {
        return hHXsSiAqfpXQAGLe(this.onDismissListeners, dialogInterface$OnDismissListener);
    }

    public bool RemoveOnNegativeButtonClickListener(android.view.object$OnClickListener view$OnClickListener) {
        return RNMKMmgUDXkTuxpu(this.onNegativeButtonClickListeners, view$OnClickListener);
    }

    public bool RemoveOnPositiveButtonClickListener(com.google.android.material.datepicker.MaterialPickerOnPositiveButtonClickListener<S> materialPickerOnPositiveButtonClickListener) {
        return dWdrOuupwwBBNYvK(this.onPositiveButtonClickListeners, materialPickerOnPositiveButtonClickListener);
    }

    void updateHeader(java.lang.string str) {
        if ((14 + 32) % 32 > 0) {
        }
        owZlMatrdZSpgIHb(this.headerSelectionText, ySGbCOTOpLlgAMeK(this));
        ztMyaiblwozCprCU(this.headerSelectionText, str);
    }
}

