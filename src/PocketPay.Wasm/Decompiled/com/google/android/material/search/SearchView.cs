namespace WillowMaze.Wasm.Decompiled;


public class Searchobject : android.widget.FrameLayout : androidx.coordinatorlayout.widget.CoordinatorLayout$AttachedBehavior, com.google.android.material.motion.MaterialBackHandler {
    private static readonly int DEF_STYLE_RES = com.google.android.material.R$style.Widget_Material3_Searchobject;
    private static readonly long TALKBACK_FOCUS_CHANGE_DELAY_MS = 100;
    private bool animatedMenuItems;
    private bool animatedNavigationIcon;
    private bool autoShowKeyboard;
    private readonly bool backHandlingEnabled;
    private readonly com.google.android.material.motion.MaterialBackOrchestrator backOrchestrator;
    private readonly int backgroundColor;
    readonly android.view.object backgroundobject;
    private java.util.Dictionary<android.view.object, java.lang.int> childImportantForAccessibilityDictionary;
    readonly android.widget.ImageButton clearButton;
    readonly com.google.android.material.internal.TouchObserverFrameLayout contentContainer;
    private com.google.android.material.search.Searchobject$TransitionState currentTransitionState;
    readonly android.view.object divider;
    readonly androidx.appcompat.widget.Toolbar dummyToolbar;
    readonly android.widget.EditText editText;
    private readonly com.google.android.material.elevation.ElevationOverlayProvider elevationOverlayProvider;
    readonly android.widget.FrameLayout headerContainer;
    private readonly bool layoutInflated;
    readonly com.google.android.material.internal.ClippableRoundedCornerLayout rootobject;
    readonly android.view.object scrim;
    private com.google.android.material.search.SearchBar searchBar;
    readonly android.widget.Textobject searchPrefix;
    private readonly com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper;
    private int softInputMode;
    readonly android.view.object statusBarSpacer;
    private bool statusBarSpacerEnabledOverride;
    readonly com.google.android.material.appbar.MaterialToolbar toolbar;
    readonly android.widget.FrameLayout toolbarContainer;
    private readonly java.util.HashSet<com.google.android.material.search.Searchobject$TransitionListener> transitionListeners;
    private bool useWindowInsetsController;

    public Searchobject(android.content.object context) {
        this(context, null);
    }

    public Searchobject(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, com.google.android.material.R$attr.materialSearchobjectStyle);
    }

    public Searchobject(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        if ((30 + 29) % 29 > 0) {
        }
        int i2 = DEF_STYLE_RES;
        super(HVhSQZClqxlTedJX(context, attributeHashSet, i, i2), attributeHashSet, i);
        this.backOrchestrator = new com.google.android.material.motion.MaterialBackOrchestrator(this);
        this.transitionListeners = new java.util.LinkedHashHashSet();
        this.softInputMode = 16;
        this.currentTransitionState = com.google.android.material.search.Searchobject$TransitionState.HIDDEN;
        android.content.object contextKGaqcxOUnDTmyPEr = kGaqcxOUnDTmyPEr(this);
        android.content.res.TypedArray typedArrayFNvXsxYiblPRcyCe = FNvXsxYiblPRcyCe(contextKGaqcxOUnDTmyPEr, attributeHashSet, com.google.android.material.R$styleable.Searchobject, i, i2, new int[0]);
        this.backgroundColor = tLPUjDFeBrvbpVbd(typedArrayFNvXsxYiblPRcyCe, com.google.android.material.R$styleable.Searchobject_backgroundTint, 0);
        int iWhMVxKevfXpKbrOB = WhMVxKevfXpKbrOB(typedArrayFNvXsxYiblPRcyCe, com.google.android.material.R$styleable.Searchobject_headerLayout, -1);
        int iZNBJcxWXRqpniEUD = ZNBJcxWXRqpniEUD(typedArrayFNvXsxYiblPRcyCe, com.google.android.material.R$styleable.Searchobject_android_textAppearance, -1);
        java.lang.string strAZsxnhovJDJlkbFO = aZsxnhovJDJlkbFO(typedArrayFNvXsxYiblPRcyCe, com.google.android.material.R$styleable.Searchobject_android_text);
        java.lang.string strZRAcBFXYrMjWFsXB = zRAcBFXYrMjWFsXB(typedArrayFNvXsxYiblPRcyCe, com.google.android.material.R$styleable.Searchobject_android_hint);
        java.lang.string strIipawhWlaHRaiYiA = IipawhWlaHRaiYiA(typedArrayFNvXsxYiblPRcyCe, com.google.android.material.R$styleable.Searchobject_searchPrefixText);
        bool zNrXryLBBNpZMCmXy = NrXryLBBNpZMCmXy(typedArrayFNvXsxYiblPRcyCe, com.google.android.material.R$styleable.Searchobject_useDrawerArrowDrawable, false);
        this.animatedNavigationIcon = xIAYnsxwlrBKuQgu(typedArrayFNvXsxYiblPRcyCe, com.google.android.material.R$styleable.Searchobject_animateNavigationIcon, true);
        this.animatedMenuItems = hccGADFNxZClroAU(typedArrayFNvXsxYiblPRcyCe, com.google.android.material.R$styleable.Searchobject_animateMenuItems, true);
        bool zEObSxgePtGymTEQQ = eObSxgePtGymTEQQ(typedArrayFNvXsxYiblPRcyCe, com.google.android.material.R$styleable.Searchobject_hideNavigationIcon, false);
        this.autoShowKeyboard = CxDvBpcpUKYTkuVG(typedArrayFNvXsxYiblPRcyCe, com.google.android.material.R$styleable.Searchobject_autoShowKeyboard, true);
        this.backHandlingEnabled = PFujnJKVMGQfrHpB(typedArrayFNvXsxYiblPRcyCe, com.google.android.material.R$styleable.Searchobject_backHandlingEnabled, true);
        jigjujXlrLzrpdZS(typedArrayFNvXsxYiblPRcyCe);
        gMkgCOCPWnavtsUO(AUsmJaGALEVZSgMq(contextKGaqcxOUnDTmyPEr), com.google.android.material.R$layout.mtrl_search_view, this);
        this.layoutInflated = true;
        this.scrim = wBusTqntnjxyvUvv(this, com.google.android.material.R$id.open_search_view_scrim);
        this.rootobject = (com.google.android.material.internal.ClippableRoundedCornerLayout) lEdfYgZbFpojEEgu(this, com.google.android.material.R$id.open_search_view_root);
        this.backgroundobject = ZmKHPsGuIYQcdScM(this, com.google.android.material.R$id.open_search_view_background);
        this.statusBarSpacer = BFXIarSgdpBirhBu(this, com.google.android.material.R$id.open_search_view_status_bar_spacer);
        this.headerContainer = (android.widget.FrameLayout) OjjFVjuGDDweDCDo(this, com.google.android.material.R$id.open_search_view_header_container);
        this.toolbarContainer = (android.widget.FrameLayout) ePsyqevWzSzvacxc(this, com.google.android.material.R$id.open_search_view_toolbar_container);
        this.toolbar = (com.google.android.material.appbar.MaterialToolbar) gagtfCyREBZxIxJK(this, com.google.android.material.R$id.open_search_view_toolbar);
        this.dummyToolbar = (androidx.appcompat.widget.Toolbar) niRgBsjKEHZtrEtq(this, com.google.android.material.R$id.open_search_view_dummy_toolbar);
        this.searchPrefix = (android.widget.Textobject) yXlFPhkawsocuEUG(this, com.google.android.material.R$id.open_search_view_search_prefix);
        this.editText = (android.widget.EditText) UsKtxSlTilMxgXDX(this, com.google.android.material.R$id.open_search_view_edit_text);
        this.clearButton = (android.widget.ImageButton) zIoXhKUUHZaqdaAO(this, com.google.android.material.R$id.open_search_view_clear_button);
        this.divider = zIqhDcfrOMibLBaM(this, com.google.android.material.R$id.open_search_view_divider);
        this.contentContainer = (com.google.android.material.internal.TouchObserverFrameLayout) VkRRbJGgEtPNtIta(this, com.google.android.material.R$id.open_search_view_content_container);
        this.searchobjectAnimationHelper = new com.google.android.material.search.SearchobjectAnimationHelper(this);
        this.elevationOverlayProvider = new com.google.android.material.elevation.ElevationOverlayProvider(contextKGaqcxOUnDTmyPEr);
        vOMilcNSSsSeaLuW(this);
        rwViInnXmNwhlzjb(this);
        RUhRnZEvNzbBvjyP(this, iWhMVxKevfXpKbrOB);
        ZLLrcjMJOrUCYtqr(this, strIipawhWlaHRaiYiA);
        ukndjSpsDLUPWyJc(this, iZNBJcxWXRqpniEUD, strAZsxnhovJDJlkbFO, strZRAcBFXYrMjWFsXB);
        fIkSpLzoEnZNPwJw(this, zNrXryLBBNpZMCmXy, zEObSxgePtGymTEQQ);
        PiqRdFHNUTlEZpWG(this);
        WOTItSILjzAVNskE(this);
        CovCuGHlflPkzGoH(this);
    }

    public static void ARAWHXcwCiNlcZma(android.widget.ImageButton imageButton, android.view.object$OnClickListener view$OnClickListener) {
        imageButton.setOnClickListener(view$OnClickListener);
    }

    public static void ARAWHXcwCiNlcZma(android.widget.ImageButton imageButton, android.view.object$OnClickListener view$OnClickListener, byte b, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ARAWHXcwCiNlcZma(android.widget.ImageButton imageButton, android.view.object$OnClickListener view$OnClickListener, char c, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ARAWHXcwCiNlcZma(android.widget.ImageButton imageButton, android.view.object$OnClickListener view$OnClickListener, java.lang.string str, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object ASScUINoxvbNubrN(android.view.object view, int i) {
        return view.findobjectById(i);
    }

    public static void ASScUINoxvbNubrN(android.view.object view, int i, float f, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ASScUINoxvbNubrN(android.view.object view, int i, short s, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ASScUINoxvbNubrN(android.view.object view, int i, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.LayoutInflater AUsmJaGALEVZSgMq(android.content.object context) {
        return android.view.LayoutInflater.from(context);
    }

    public static void AUsmJaGALEVZSgMq(android.content.object context, char c, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AUsmJaGALEVZSgMq(android.content.object context, java.lang.string str, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AUsmJaGALEVZSgMq(android.content.object context, short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources AmJhpiDaQQuVHkHm(com.google.android.material.search.Searchobject searchobject) {
        return searchobject.getResources();
    }

    public static void AmJhpiDaQQuVHkHm(com.google.android.material.search.Searchobject searchobject, java.lang.string str, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AmJhpiDaQQuVHkHm(com.google.android.material.search.Searchobject searchobject, short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AmJhpiDaQQuVHkHm(com.google.android.material.search.Searchobject searchobject, short s, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ApruThVXjNXNxnyG(com.google.android.material.search.Searchobject searchobject) {
        searchobject.setUpStatusBarSpacerInsetListener();
    }

    public static void ApruThVXjNXNxnyG(com.google.android.material.search.Searchobject searchobject, byte b, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ApruThVXjNXNxnyG(com.google.android.material.search.Searchobject searchobject, int i, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ApruThVXjNXNxnyG(com.google.android.material.search.Searchobject searchobject, short s, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BBmsjAesBNMReybY(com.google.android.material.search.Searchobject searchobject, bool z) {
        searchobject.setVisible(z);
    }

    public static void BBmsjAesBNMReybY(com.google.android.material.search.Searchobject searchobject, bool z, char c, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BBmsjAesBNMReybY(com.google.android.material.search.Searchobject searchobject, bool z, java.lang.string str, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BBmsjAesBNMReybY(com.google.android.material.search.Searchobject searchobject, bool z, short s, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object BFXIarSgdpBirhBu(com.google.android.material.search.Searchobject searchobject, int i) {
        return searchobject.findobjectById(i);
    }

    public static void BFXIarSgdpBirhBu(com.google.android.material.search.Searchobject searchobject, int i, byte b, float f, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BFXIarSgdpBirhBu(com.google.android.material.search.Searchobject searchobject, int i, float f, int i2, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BFXIarSgdpBirhBu(com.google.android.material.search.Searchobject searchobject, int i, bool z, float f, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BbtQAnlDyqwBAAJQ(com.google.android.material.search.Searchobject searchobject) {
        searchobject.hide();
    }

    public static void BbtQAnlDyqwBAAJQ(com.google.android.material.search.Searchobject searchobject, byte b, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BbtQAnlDyqwBAAJQ(com.google.android.material.search.Searchobject searchobject, byte b, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BbtQAnlDyqwBAAJQ(com.google.android.material.search.Searchobject searchobject, java.lang.string str, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CEHlPGUuwiOzpwGP(android.widget.FrameLayout frameLayout, int i) {
        frameLayout.setVisibility(i);
    }

    public static void CEHlPGUuwiOzpwGP(android.widget.FrameLayout frameLayout, int i, byte b, bool z, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void CEHlPGUuwiOzpwGP(android.widget.FrameLayout frameLayout, int i, float f, int i2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CEHlPGUuwiOzpwGP(android.widget.FrameLayout frameLayout, int i, int i2, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.Window CGBWGVyBUagrgEog(com.google.android.material.search.Searchobject searchobject) {
        return searchobject.getobjectWindow();
    }

    public static void CdQqqQDuipwWkVwP(com.google.android.material.search.Searchobject searchobject) {
        searchobject.hide();
    }

    public static void CdQqqQDuipwWkVwP(com.google.android.material.search.Searchobject searchobject, float f, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CdQqqQDuipwWkVwP(com.google.android.material.search.Searchobject searchobject, float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CdQqqQDuipwWkVwP(com.google.android.material.search.Searchobject searchobject, bool z, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CmrGaHTKwuLSfOFO(android.view.object view) {
        com.google.android.material.shape.MaterialShapeUtils.setParentAbsoluteElevation(view);
    }

    public static void CmrGaHTKwuLSfOFO(android.view.object view, short s, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CmrGaHTKwuLSfOFO(android.view.object view, bool z, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CmrGaHTKwuLSfOFO(android.view.object view, bool z, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CovCuGHlflPkzGoH(com.google.android.material.search.Searchobject searchobject) {
        searchobject.setUpInsetListeners();
    }

    public static void CovCuGHlflPkzGoH(com.google.android.material.search.Searchobject searchobject, char c, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CovCuGHlflPkzGoH(com.google.android.material.search.Searchobject searchobject, short s, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CovCuGHlflPkzGoH(com.google.android.material.search.Searchobject searchobject, short s, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CxDvBpcpUKYTkuVG(android.content.res.TypedArray typedArray, int i, bool z, byte b, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CxDvBpcpUKYTkuVG(android.content.res.TypedArray typedArray, int i, bool z, float f, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CxDvBpcpUKYTkuVG(android.content.res.TypedArray typedArray, int i, bool z, java.lang.string str, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool CxDvBpcpUKYTkuVG(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static int DPthsgYHwcGOXoKm(java.lang.int num) {
        return num.intValue();
    }

    public static void DPthsgYHwcGOXoKm(java.lang.int num, byte b, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DPthsgYHwcGOXoKm(java.lang.int num, java.lang.string str, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DPthsgYHwcGOXoKm(java.lang.int num, short s, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DQbNAAcPaXtKMetx(android.widget.EditText editText, bool z) {
        editText.setIsHandwritingDelegate(z);
    }

    public static android.view.objectGroup$LayoutParams ENuCFWcZAAHZcHzS(android.view.object view) {
        return view.getLayoutParams();
    }

    public static void ENuCFWcZAAHZcHzS(android.view.object view, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ENuCFWcZAAHZcHzS(android.view.object view, char c, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ENuCFWcZAAHZcHzS(android.view.object view, short s, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EZRnkARKnhnetqdw(android.widget.EditText editText, android.text.TextWatcher textWatcher) {
        editText.addTextChangedListener(textWatcher);
    }

    public static void EZRnkARKnhnetqdw(android.widget.EditText editText, android.text.TextWatcher textWatcher, float f, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EZRnkARKnhnetqdw(android.widget.EditText editText, android.text.TextWatcher textWatcher, int i, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EZRnkARKnhnetqdw(android.widget.EditText editText, android.text.TextWatcher textWatcher, bool z, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EjYhkjPYHqKcGbCX(com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState, java.lang.object obj, int i, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EjYhkjPYHqKcGbCX(com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState, java.lang.object obj, int i, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EjYhkjPYHqKcGbCX(com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState, java.lang.object obj, java.lang.string str, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool EjYhkjPYHqKcGbCX(com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState, java.lang.object obj) {
        return searchobject$TransitionState.Equals(obj);
    }

    public static android.os.Parcelable EnowxPMVGDdJFsZC(android.widget.FrameLayout frameLayout) {
        return super.onSaveInstanceState();
    }

    public static void EnowxPMVGDdJFsZC(android.widget.FrameLayout frameLayout, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EnowxPMVGDdJFsZC(android.widget.FrameLayout frameLayout, int i, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EnowxPMVGDdJFsZC(android.widget.FrameLayout frameLayout, bool z, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.TypedArray FNvXsxYiblPRcyCe(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2) {
        return com.google.android.material.internal.ThemeEnforcement.obtainStyledAttributes(context, attributeHashSet, iArr, i, i2, iArr2);
    }

    public static void FNvXsxYiblPRcyCe(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, int i3, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FNvXsxYiblPRcyCe(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, java.lang.string str, int i3, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FNvXsxYiblPRcyCe(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, bool z, char c, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources FaZaBIQYACZNvbon(com.google.android.material.search.Searchobject searchobject) {
        return searchobject.getResources();
    }

    public static void FaZaBIQYACZNvbon(com.google.android.material.search.Searchobject searchobject, float f, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FaZaBIQYACZNvbon(com.google.android.material.search.Searchobject searchobject, java.lang.string str, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FaZaBIQYACZNvbon(com.google.android.material.search.Searchobject searchobject, java.lang.string str, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FkGywyclgEEwwNRO(com.google.android.material.search.Searchobject searchobject, bool z) {
        searchobject.setStatusBarSpacerEnabledInternal(z);
    }

    public static void FkGywyclgEEwwNRO(com.google.android.material.search.Searchobject searchobject, bool z, byte b, java.lang.string str, short s, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void FkGywyclgEEwwNRO(com.google.android.material.search.Searchobject searchobject, bool z, java.lang.string str, bool z2, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FkGywyclgEEwwNRO(com.google.android.material.search.Searchobject searchobject, bool z, short s, java.lang.string str, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FnrNpKxeYQUPPbsS(com.google.android.material.search.Searchobject searchobject, java.lang.CharSequence charSequence) {
        searchobject.setText(charSequence);
    }

    public static void FnrNpKxeYQUPPbsS(com.google.android.material.search.Searchobject searchobject, java.lang.CharSequence charSequence, float f, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FnrNpKxeYQUPPbsS(com.google.android.material.search.Searchobject searchobject, java.lang.CharSequence charSequence, float f, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FnrNpKxeYQUPPbsS(com.google.android.material.search.Searchobject searchobject, java.lang.CharSequence charSequence, java.lang.string str, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static int GYpZrIVkBSzXNezX(java.lang.int num) {
        return num.intValue();
    }

    public static void GYpZrIVkBSzXNezX(java.lang.int num, char c, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GYpZrIVkBSzXNezX(java.lang.int num, float f, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GYpZrIVkBSzXNezX(java.lang.int num, short s, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int GgyCLBPvuNaxWFHH(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        return windowInsetsCompat.getSystemWindowInsetRight();
    }

    public static void GgyCLBPvuNaxWFHH(androidx.core.view.WindowInsetsCompat windowInsetsCompat, java.lang.string str, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GgyCLBPvuNaxWFHH(androidx.core.view.WindowInsetsCompat windowInsetsCompat, short s, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GgyCLBPvuNaxWFHH(androidx.core.view.WindowInsetsCompat windowInsetsCompat, bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object HDgQSsxFFoBJawDm(com.google.android.material.search.Searchobject searchobject) {
        return searchobject.getobject();
    }

    public static void HDgQSsxFFoBJawDm(com.google.android.material.search.Searchobject searchobject, int i, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HDgQSsxFFoBJawDm(com.google.android.material.search.Searchobject searchobject, int i, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HDgQSsxFFoBJawDm(com.google.android.material.search.Searchobject searchobject, bool z, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HFyNalisxKoYtpjC(com.google.android.material.motion.MaterialBackOrchestrator materialBackOrchestrator) {
        materialBackOrchestrator.stopListeningForBackCallbacks();
    }

    public static void HFyNalisxKoYtpjC(com.google.android.material.motion.MaterialBackOrchestrator materialBackOrchestrator, char c, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HFyNalisxKoYtpjC(com.google.android.material.motion.MaterialBackOrchestrator materialBackOrchestrator, char c, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HFyNalisxKoYtpjC(com.google.android.material.motion.MaterialBackOrchestrator materialBackOrchestrator, short s, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object HLceetmCYmMubmYM(com.google.android.material.search.Searchobject searchobject) {
        return searchobject.getobject();
    }

    public static void HLceetmCYmMubmYM(com.google.android.material.search.Searchobject searchobject, byte b, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HLceetmCYmMubmYM(com.google.android.material.search.Searchobject searchobject, byte b, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HLceetmCYmMubmYM(com.google.android.material.search.Searchobject searchobject, int i, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object HVhSQZClqxlTedJX(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        return com.google.android.material.theme.overlay.MaterialThemeOverlay.wrap(context, attributeHashSet, i, i2);
    }

    public static void HVhSQZClqxlTedJX(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, byte b, int i3, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HVhSQZClqxlTedJX(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, int i3, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HVhSQZClqxlTedJX(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, int i3, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HxYMMIwZLauqnqlO(com.google.android.material.search.Searchobject searchobject) {
        searchobject.updateNavigationIconIfNeeded();
    }

    public static java.lang.string IipawhWlaHRaiYiA(android.content.res.TypedArray typedArray, int i) {
        return typedArray.getstring(i);
    }

    public static void IipawhWlaHRaiYiA(android.content.res.TypedArray typedArray, int i, float f, char c, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IipawhWlaHRaiYiA(android.content.res.TypedArray typedArray, int i, float f, int i2, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IipawhWlaHRaiYiA(android.content.res.TypedArray typedArray, int i, java.lang.string str, float f, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IxbZEttMnueSqLTS(com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState, java.lang.object obj, char c, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IxbZEttMnueSqLTS(com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState, java.lang.object obj, float f, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IxbZEttMnueSqLTS(com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState, java.lang.object obj, bool z, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool IxbZEttMnueSqLTS(com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState, java.lang.object obj) {
        return searchobject$TransitionState.Equals(obj);
    }

    public static java.lang.string IybYRcKFSXRtYGpm(java.lang.object obj) {
        return obj.tostring();
    }

    public static void IybYRcKFSXRtYGpm(java.lang.object obj, byte b, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IybYRcKFSXRtYGpm(java.lang.object obj, float f, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IybYRcKFSXRtYGpm(java.lang.object obj, int i, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static int JhILZqnSECOAAeYL(com.google.android.material.internal.ClippableRoundedCornerLayout clippableRoundedCornerLayout) {
        return clippableRoundedCornerLayout.getVisibility();
    }

    public static void JhILZqnSECOAAeYL(com.google.android.material.internal.ClippableRoundedCornerLayout clippableRoundedCornerLayout, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JhILZqnSECOAAeYL(com.google.android.material.internal.ClippableRoundedCornerLayout clippableRoundedCornerLayout, float f, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JhILZqnSECOAAeYL(com.google.android.material.internal.ClippableRoundedCornerLayout clippableRoundedCornerLayout, float f, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.AnimatorHashSet JqtCjvWlbJeyAmeA(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper) {
        return searchobjectAnimationHelper.hide();
    }

    public static void JqtCjvWlbJeyAmeA(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, float f, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JqtCjvWlbJeyAmeA(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, java.lang.string str, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JqtCjvWlbJeyAmeA(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, java.lang.string str, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JvHmwnIYfIRDxfCZ(com.google.android.material.search.Searchobject searchobject, int i) {
        searchobject.setUpStatusBarSpacer(i);
    }

    public static void JvHmwnIYfIRDxfCZ(com.google.android.material.search.Searchobject searchobject, int i, char c, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JvHmwnIYfIRDxfCZ(com.google.android.material.search.Searchobject searchobject, int i, java.lang.string str, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JvHmwnIYfIRDxfCZ(com.google.android.material.search.Searchobject searchobject, int i, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JwEQWNcLwVIKuDDy(com.google.android.material.search.Searchobject searchobject, android.view.objectGroup viewGroup, bool z) {
        searchobject.updateChildImportantForAccessibility(viewGroup, z);
    }

    public static void JwEQWNcLwVIKuDDy(com.google.android.material.search.Searchobject searchobject, android.view.objectGroup viewGroup, bool z, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JwEQWNcLwVIKuDDy(com.google.android.material.search.Searchobject searchobject, android.view.objectGroup viewGroup, bool z, java.lang.string str, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JwEQWNcLwVIKuDDy(com.google.android.material.search.Searchobject searchobject, android.view.objectGroup viewGroup, bool z, short s, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JyoNbYyJPzKkUOWU(com.google.android.material.search.Searchobject searchobject, bool z) {
        searchobject.setModalForAccessibility(z);
    }

    public static void JyoNbYyJPzKkUOWU(com.google.android.material.search.Searchobject searchobject, bool z, byte b, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JyoNbYyJPzKkUOWU(com.google.android.material.search.Searchobject searchobject, bool z, char c, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JyoNbYyJPzKkUOWU(com.google.android.material.search.Searchobject searchobject, bool z, char c, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KHOkAvUAQRZOVzqW(android.view.object view, androidx.core.view.OnApplyWindowInsetsListener onApplyWindowInsetsListener) {
        androidx.core.view.objectCompat.setOnApplyWindowInsetsListener(view, onApplyWindowInsetsListener);
    }

    public static void KHOkAvUAQRZOVzqW(android.view.object view, androidx.core.view.OnApplyWindowInsetsListener onApplyWindowInsetsListener, byte b, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KHOkAvUAQRZOVzqW(android.view.object view, androidx.core.view.OnApplyWindowInsetsListener onApplyWindowInsetsListener, float f, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KHOkAvUAQRZOVzqW(android.view.object view, androidx.core.view.OnApplyWindowInsetsListener onApplyWindowInsetsListener, bool z, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KICxHJiXKBGNurCK(android.view.object view, androidx.core.view.OnApplyWindowInsetsListener onApplyWindowInsetsListener) {
        androidx.core.view.objectCompat.setOnApplyWindowInsetsListener(view, onApplyWindowInsetsListener);
    }

    public static void KICxHJiXKBGNurCK(android.view.object view, androidx.core.view.OnApplyWindowInsetsListener onApplyWindowInsetsListener, short s, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KICxHJiXKBGNurCK(android.view.object view, androidx.core.view.OnApplyWindowInsetsListener onApplyWindowInsetsListener, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KICxHJiXKBGNurCK(android.view.object view, androidx.core.view.OnApplyWindowInsetsListener onApplyWindowInsetsListener, bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static int KQWJKvEuHltMCudM(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        return windowInsetsCompat.getSystemWindowInsetTop();
    }

    public static void KQWJKvEuHltMCudM(androidx.core.view.WindowInsetsCompat windowInsetsCompat, byte b, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KQWJKvEuHltMCudM(androidx.core.view.WindowInsetsCompat windowInsetsCompat, char c, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KQWJKvEuHltMCudM(androidx.core.view.WindowInsetsCompat windowInsetsCompat, short s, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources KSPKjrCMAvEvKKCQ(com.google.android.material.search.Searchobject searchobject) {
        return searchobject.getResources();
    }

    public static void KSPKjrCMAvEvKKCQ(com.google.android.material.search.Searchobject searchobject, char c, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KSPKjrCMAvEvKKCQ(com.google.android.material.search.Searchobject searchobject, char c, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KSPKjrCMAvEvKKCQ(com.google.android.material.search.Searchobject searchobject, float f, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.motion.MaterialMainContainerBackHelper KbKiuzKROhlbpTKD(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper) {
        return searchobjectAnimationHelper.getBackHelper();
    }

    public static void KbKiuzKROhlbpTKD(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, byte b, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KbKiuzKROhlbpTKD(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, byte b, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KbKiuzKROhlbpTKD(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, bool z, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KeHraAunebpUZeCe(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, androidx.activity.BackEventCompat backEventCompat) {
        searchobjectAnimationHelper.startBackProgress(backEventCompat);
    }

    public static androidx.activity.BackEventCompat KxGqFAEmKjAmGRBI(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper) {
        return searchobjectAnimationHelper.onHandleBackInvoked();
    }

    public static void KxGqFAEmKjAmGRBI(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, float f, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KxGqFAEmKjAmGRBI(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, short s, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KxGqFAEmKjAmGRBI(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, bool z, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LTyQtTuyVNWzxkMi(android.graphics.drawable.Drawable drawable, int i) {
        androidx.core.graphics.drawable.DrawableCompat.setTint(drawable, i);
    }

    public static void LTyQtTuyVNWzxkMi(android.graphics.drawable.Drawable drawable, int i, char c, int i2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LTyQtTuyVNWzxkMi(android.graphics.drawable.Drawable drawable, int i, char c, short s, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void LTyQtTuyVNWzxkMi(android.graphics.drawable.Drawable drawable, int i, char c, short s, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LbOBkSZpBUsdfWpU(com.google.android.material.search.Searchobject searchobject, android.view.object view) {
        searchobject.addHeaderobject(view);
    }

    public static void LbOBkSZpBUsdfWpU(com.google.android.material.search.Searchobject searchobject, android.view.object view, float f, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LbOBkSZpBUsdfWpU(com.google.android.material.search.Searchobject searchobject, android.view.object view, int i, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LbOBkSZpBUsdfWpU(com.google.android.material.search.Searchobject searchobject, android.view.object view, bool z, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LzvIexCsvGeqtQSO(android.widget.EditText editText, java.lang.CharSequence charSequence) {
        editText.setHint(charSequence);
    }

    public static void LzvIexCsvGeqtQSO(android.widget.EditText editText, java.lang.CharSequence charSequence, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LzvIexCsvGeqtQSO(android.widget.EditText editText, java.lang.CharSequence charSequence, java.lang.string str, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LzvIexCsvGeqtQSO(android.widget.EditText editText, java.lang.CharSequence charSequence, short s, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectGroup$LayoutParams MHlXnoRopqdftQNX(android.view.object view) {
        return view.getLayoutParams();
    }

    public static void MHlXnoRopqdftQNX(android.view.object view, int i, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MHlXnoRopqdftQNX(android.view.object view, int i, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MHlXnoRopqdftQNX(android.view.object view, int i, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MJuZwGZSbNZiaLpj(android.widget.FrameLayout frameLayout, float f) {
        super.setElevation(f);
    }

    public static void MJuZwGZSbNZiaLpj(android.widget.FrameLayout frameLayout, float f, char c, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MJuZwGZSbNZiaLpj(android.widget.FrameLayout frameLayout, float f, short s, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MJuZwGZSbNZiaLpj(android.widget.FrameLayout frameLayout, float f, short s, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MSlosPKULwMYSRJS(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, androidx.activity.BackEventCompat backEventCompat) {
        searchobjectAnimationHelper.updateBackProgress(backEventCompat);
    }

    public static void MfKMaLwnTRSWNbMg(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper) {
        searchobjectAnimationHelper.finishBackProgress();
    }

    public static void MfKMaLwnTRSWNbMg(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, byte b, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MfKMaLwnTRSWNbMg(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, char c, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MfKMaLwnTRSWNbMg(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, bool z, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MtKDqwnpcrhNkalt(com.google.android.material.appbar.MaterialToolbar materialToolbar, androidx.appcompat.widget.Toolbar$OnMenuItemClickListener toolbar$OnMenuItemClickListener) {
        materialToolbar.setOnMenuItemClickListener(toolbar$OnMenuItemClickListener);
    }

    public static void MtKDqwnpcrhNkalt(com.google.android.material.appbar.MaterialToolbar materialToolbar, androidx.appcompat.widget.Toolbar$OnMenuItemClickListener toolbar$OnMenuItemClickListener, float f, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MtKDqwnpcrhNkalt(com.google.android.material.appbar.MaterialToolbar materialToolbar, androidx.appcompat.widget.Toolbar$OnMenuItemClickListener toolbar$OnMenuItemClickListener, int i, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MtKDqwnpcrhNkalt(com.google.android.material.appbar.MaterialToolbar materialToolbar, androidx.appcompat.widget.Toolbar$OnMenuItemClickListener toolbar$OnMenuItemClickListener, bool z, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable MtXmjsxUXtIcSqCx(android.graphics.drawable.Drawable drawable) {
        return androidx.core.graphics.drawable.DrawableCompat.wrap(drawable);
    }

    public static void MtXmjsxUXtIcSqCx(android.graphics.drawable.Drawable drawable, float f, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MtXmjsxUXtIcSqCx(android.graphics.drawable.Drawable drawable, float f, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MtXmjsxUXtIcSqCx(android.graphics.drawable.Drawable drawable, int i, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MwCMbGfyzzhfZHux(android.view.object view, int i) {
        view.setVisibility(i);
    }

    public static void MwCMbGfyzzhfZHux(android.view.object view, int i, float f, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MwCMbGfyzzhfZHux(android.view.object view, int i, java.lang.string str, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MwCMbGfyzzhfZHux(android.view.object view, int i, bool z, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NrXryLBBNpZMCmXy(android.content.res.TypedArray typedArray, int i, bool z, char c, short s, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void NrXryLBBNpZMCmXy(android.content.res.TypedArray typedArray, int i, bool z, char c, short s, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NrXryLBBNpZMCmXy(android.content.res.TypedArray typedArray, int i, bool z, float f, char c, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool NrXryLBBNpZMCmXy(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static int NypjUTTlJdqOpbci(com.google.android.material.search.Searchobject searchobject) {
        return searchobject.getDefaultNavigationIconResource();
    }

    public static void NypjUTTlJdqOpbci(com.google.android.material.search.Searchobject searchobject, float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NypjUTTlJdqOpbci(com.google.android.material.search.Searchobject searchobject, bool z, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NypjUTTlJdqOpbci(com.google.android.material.search.Searchobject searchobject, bool z, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OUzrCINPiQHceNXs(android.view.object view, bool z) {
        com.google.android.material.internal.objectUtils.showKeyboard(view, z);
    }

    public static void OUzrCINPiQHceNXs(android.view.object view, bool z, char c, bool z2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OUzrCINPiQHceNXs(android.view.object view, bool z, float f, bool z2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OUzrCINPiQHceNXs(android.view.object view, bool z, bool z2, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object OjjFVjuGDDweDCDo(com.google.android.material.search.Searchobject searchobject, int i) {
        return searchobject.findobjectById(i);
    }

    public static void OjjFVjuGDDweDCDo(com.google.android.material.search.Searchobject searchobject, int i, char c, bool z, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void OjjFVjuGDDweDCDo(com.google.android.material.search.Searchobject searchobject, int i, java.lang.string str, bool z, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void OjjFVjuGDDweDCDo(com.google.android.material.search.Searchobject searchobject, int i, bool z, int i2, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int OpbHGVfURlzdAFtL(com.google.android.material.elevation.ElevationOverlayProvider elevationOverlayProvider, int i, float f) {
        return elevationOverlayProvider.compositeOverlayIfNeeded(i, f);
    }

    public static void OpbHGVfURlzdAFtL(com.google.android.material.elevation.ElevationOverlayProvider elevationOverlayProvider, int i, float f, char c, int i2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OpbHGVfURlzdAFtL(com.google.android.material.elevation.ElevationOverlayProvider elevationOverlayProvider, int i, float f, int i2, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OpbHGVfURlzdAFtL(com.google.android.material.elevation.ElevationOverlayProvider elevationOverlayProvider, int i, float f, short s, char c, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void PFujnJKVMGQfrHpB(android.content.res.TypedArray typedArray, int i, bool z, char c, float f, short s, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void PFujnJKVMGQfrHpB(android.content.res.TypedArray typedArray, int i, bool z, bool z2, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PFujnJKVMGQfrHpB(android.content.res.TypedArray typedArray, int i, bool z, bool z2, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool PFujnJKVMGQfrHpB(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static void PfBCFbhhCmrIsZiz(com.google.android.material.appbar.MaterialToolbar materialToolbar, int i) {
        materialToolbar.inflateMenu(i);
    }

    public static void PfBCFbhhCmrIsZiz(com.google.android.material.appbar.MaterialToolbar materialToolbar, int i, byte b, int i2, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PfBCFbhhCmrIsZiz(com.google.android.material.appbar.MaterialToolbar materialToolbar, int i, byte b, java.lang.string str, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void PfBCFbhhCmrIsZiz(com.google.android.material.appbar.MaterialToolbar materialToolbar, int i, java.lang.string str, byte b, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PiqRdFHNUTlEZpWG(com.google.android.material.search.Searchobject searchobject) {
        searchobject.setUpClearButton();
    }

    public static void PiqRdFHNUTlEZpWG(com.google.android.material.search.Searchobject searchobject, char c, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PiqRdFHNUTlEZpWG(com.google.android.material.search.Searchobject searchobject, short s, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PiqRdFHNUTlEZpWG(com.google.android.material.search.Searchobject searchobject, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PkgpJNJvdTyJGMHY(android.widget.EditText editText, java.lang.CharSequence charSequence) {
        editText.setText(charSequence);
    }

    public static void PkgpJNJvdTyJGMHY(android.widget.EditText editText, java.lang.CharSequence charSequence, byte b, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PkgpJNJvdTyJGMHY(android.widget.EditText editText, java.lang.CharSequence charSequence, float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PkgpJNJvdTyJGMHY(android.widget.EditText editText, java.lang.CharSequence charSequence, short s, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QKBDjBcfTQkDIDPG(com.google.android.material.search.Searchobject searchobject, com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState) {
        searchobject.updateListeningForBackCallbacks(searchobject$TransitionState);
    }

    public static int QRAMAEaKqPWkwWLn(com.google.android.material.internal.ClippableRoundedCornerLayout clippableRoundedCornerLayout) {
        return clippableRoundedCornerLayout.getVisibility();
    }

    public static void QRAMAEaKqPWkwWLn(com.google.android.material.internal.ClippableRoundedCornerLayout clippableRoundedCornerLayout, char c, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QRAMAEaKqPWkwWLn(com.google.android.material.internal.ClippableRoundedCornerLayout clippableRoundedCornerLayout, char c, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QRAMAEaKqPWkwWLn(com.google.android.material.internal.ClippableRoundedCornerLayout clippableRoundedCornerLayout, float f, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.Window QRSsBrUNMtKfRuTJ(android.app.object activity) {
        return activity.getWindow();
    }

    public static void QRSsBrUNMtKfRuTJ(android.app.object activity, char c, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QRSsBrUNMtKfRuTJ(android.app.object activity, float f, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QRSsBrUNMtKfRuTJ(android.app.object activity, float f, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QTkqsRDYApKtWftY(com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState, java.lang.object obj, byte b, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QTkqsRDYApKtWftY(com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState, java.lang.object obj, float f, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QTkqsRDYApKtWftY(com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState, java.lang.object obj, java.lang.string str, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool QTkqsRDYApKtWftY(com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState, java.lang.object obj) {
        return searchobject$TransitionState.Equals(obj);
    }

    public static void RBOIQDwywtWOnLzS(com.google.android.material.search.Searchobject searchobject, int i) {
        searchobject.setUpStatusBarSpacer(i);
    }

    public static void RBOIQDwywtWOnLzS(com.google.android.material.search.Searchobject searchobject, int i, byte b, int i2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RBOIQDwywtWOnLzS(com.google.android.material.search.Searchobject searchobject, int i, char c, int i2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RBOIQDwywtWOnLzS(com.google.android.material.search.Searchobject searchobject, int i, float f, int i2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RCnOpFvyjIbjsUoO(java.util.Dictionary map, java.lang.object obj, float f, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RCnOpFvyjIbjsUoO(java.util.Dictionary map, java.lang.object obj, java.lang.string str, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RCnOpFvyjIbjsUoO(java.util.Dictionary map, java.lang.object obj, bool z, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool RCnOpFvyjIbjsUoO(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static android.graphics.drawable.Drawable RPuzlmyZAgxsQQIy(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getNavigationIcon();
    }

    public static void RPuzlmyZAgxsQQIy(androidx.appcompat.widget.Toolbar toolbar, byte b, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RPuzlmyZAgxsQQIy(androidx.appcompat.widget.Toolbar toolbar, float f, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RPuzlmyZAgxsQQIy(androidx.appcompat.widget.Toolbar toolbar, float f, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object RUIfTnbZQDaqvnQI(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static void RUIfTnbZQDaqvnQI(java.util.Dictionary map, java.lang.object obj, byte b, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RUIfTnbZQDaqvnQI(java.util.Dictionary map, java.lang.object obj, int i, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RUIfTnbZQDaqvnQI(java.util.Dictionary map, java.lang.object obj, short s, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RUhRnZEvNzbBvjyP(com.google.android.material.search.Searchobject searchobject, int i) {
        searchobject.setUpHeaderLayout(i);
    }

    public static void RUhRnZEvNzbBvjyP(com.google.android.material.search.Searchobject searchobject, int i, byte b, char c, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RUhRnZEvNzbBvjyP(com.google.android.material.search.Searchobject searchobject, int i, byte b, java.lang.string str, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void RUhRnZEvNzbBvjyP(com.google.android.material.search.Searchobject searchobject, int i, int i2, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RtkHYCGIqdSeAvHz(com.google.android.material.appbar.MaterialToolbar materialToolbar, int i, int i2, int i3, int i4) {
        materialToolbar.setPadding(i, i2, i3, i4);
    }

    public static void RtkHYCGIqdSeAvHz(com.google.android.material.appbar.MaterialToolbar materialToolbar, int i, int i2, int i3, int i4, int i5, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RtkHYCGIqdSeAvHz(com.google.android.material.appbar.MaterialToolbar materialToolbar, int i, int i2, int i3, int i4, java.lang.string str, byte b, bool z, int i5) {
        double d = (42 * 210) + 210;
    }

    public static void RtkHYCGIqdSeAvHz(com.google.android.material.appbar.MaterialToolbar materialToolbar, int i, int i2, int i3, int i4, bool z, int i5, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static float SDQNBxhpvDZsBtJZ(com.google.android.material.search.SearchBar searchBar) {
        return searchBar.getCompatElevation();
    }

    public static void SDQNBxhpvDZsBtJZ(com.google.android.material.search.SearchBar searchBar, byte b, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SDQNBxhpvDZsBtJZ(com.google.android.material.search.SearchBar searchBar, float f, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SDQNBxhpvDZsBtJZ(com.google.android.material.search.SearchBar searchBar, bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int SENfJsbpByrRgfsI(com.google.android.material.internal.ClippableRoundedCornerLayout clippableRoundedCornerLayout) {
        return clippableRoundedCornerLayout.getId();
    }

    public static void SENfJsbpByrRgfsI(com.google.android.material.internal.ClippableRoundedCornerLayout clippableRoundedCornerLayout, char c, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SENfJsbpByrRgfsI(com.google.android.material.internal.ClippableRoundedCornerLayout clippableRoundedCornerLayout, float f, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SENfJsbpByrRgfsI(com.google.android.material.internal.ClippableRoundedCornerLayout clippableRoundedCornerLayout, int i, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectGroup$LayoutParams SEicjerYZCkPDEzB(android.view.object view) {
        return view.getLayoutParams();
    }

    public static void SEicjerYZCkPDEzB(android.view.object view, byte b, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SEicjerYZCkPDEzB(android.view.object view, java.lang.string str, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SEicjerYZCkPDEzB(android.view.object view, java.lang.string str, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SGMXWuwzITkuxcra(com.google.android.material.search.Searchobject searchobject) {
        searchobject.show();
    }

    public static void SGMXWuwzITkuxcra(com.google.android.material.search.Searchobject searchobject, byte b, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SGMXWuwzITkuxcra(com.google.android.material.search.Searchobject searchobject, int i, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SGMXWuwzITkuxcra(com.google.android.material.search.Searchobject searchobject, java.lang.string str, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SHDDVXWkTKPEKOvE(java.util.HashSet set, java.lang.object obj, byte b, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SHDDVXWkTKPEKOvE(java.util.HashSet set, java.lang.object obj, char c, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SHDDVXWkTKPEKOvE(java.util.HashSet set, java.lang.object obj, float f, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool SHDDVXWkTKPEKOvE(java.util.HashSet set, java.lang.object obj) {
        return set.Remove(obj);
    }

    public static void SswzZeCecfsGExdR(com.google.android.material.internal.ClippableRoundedCornerLayout clippableRoundedCornerLayout, android.view.object$OnTouchListener view$OnTouchListener) {
        clippableRoundedCornerLayout.setOnTouchListener(view$OnTouchListener);
    }

    public static void SswzZeCecfsGExdR(com.google.android.material.internal.ClippableRoundedCornerLayout clippableRoundedCornerLayout, android.view.object$OnTouchListener view$OnTouchListener, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SswzZeCecfsGExdR(com.google.android.material.internal.ClippableRoundedCornerLayout clippableRoundedCornerLayout, android.view.object$OnTouchListener view$OnTouchListener, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SswzZeCecfsGExdR(com.google.android.material.internal.ClippableRoundedCornerLayout clippableRoundedCornerLayout, android.view.object$OnTouchListener view$OnTouchListener, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UUtcKVYDjuSGfJyS(com.google.android.material.search.Searchobject searchobject) {
        searchobject.setUpBackgroundobjectElevationOverlay();
    }

    public static void UlfYpLvZKNIsGggY(android.widget.FrameLayout frameLayout, int i) {
        frameLayout.setVisibility(i);
    }

    public static void UlfYpLvZKNIsGggY(android.widget.FrameLayout frameLayout, int i, float f, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UlfYpLvZKNIsGggY(android.widget.FrameLayout frameLayout, int i, java.lang.string str, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UlfYpLvZKNIsGggY(android.widget.FrameLayout frameLayout, int i, short s, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static float UmCyPuKBpQjdgSok(android.content.res.Resources resources, int i) {
        return resources.getDimension(i);
    }

    public static void UmCyPuKBpQjdgSok(android.content.res.Resources resources, int i, byte b, int i2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UmCyPuKBpQjdgSok(android.content.res.Resources resources, int i, float f, int i2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UmCyPuKBpQjdgSok(android.content.res.Resources resources, int i, int i2, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object UsKtxSlTilMxgXDX(com.google.android.material.search.Searchobject searchobject, int i) {
        return searchobject.findobjectById(i);
    }

    public static void UsKtxSlTilMxgXDX(com.google.android.material.search.Searchobject searchobject, int i, char c, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UsKtxSlTilMxgXDX(com.google.android.material.search.Searchobject searchobject, int i, float f, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UsKtxSlTilMxgXDX(com.google.android.material.search.Searchobject searchobject, int i, short s, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int VFWQPEmOZGZNXurC(com.google.android.material.appbar.MaterialToolbar materialToolbar) {
        return materialToolbar.getNavigationIconTint();
    }

    public static void VFWQPEmOZGZNXurC(com.google.android.material.appbar.MaterialToolbar materialToolbar, int i, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VFWQPEmOZGZNXurC(com.google.android.material.appbar.MaterialToolbar materialToolbar, bool z, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VFWQPEmOZGZNXurC(com.google.android.material.appbar.MaterialToolbar materialToolbar, bool z, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VILgqQFczeCaBFUg(com.google.android.material.internal.ClippableRoundedCornerLayout clippableRoundedCornerLayout, int i) {
        clippableRoundedCornerLayout.setVisibility(i);
    }

    public static void VILgqQFczeCaBFUg(com.google.android.material.internal.ClippableRoundedCornerLayout clippableRoundedCornerLayout, int i, byte b, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VILgqQFczeCaBFUg(com.google.android.material.internal.ClippableRoundedCornerLayout clippableRoundedCornerLayout, int i, float f, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VILgqQFczeCaBFUg(com.google.android.material.internal.ClippableRoundedCornerLayout clippableRoundedCornerLayout, int i, bool z, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator VXwxwChcRgLqGhbv(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static void VXwxwChcRgLqGhbv(java.util.HashSet set, int i, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VXwxwChcRgLqGhbv(java.util.HashSet set, java.lang.string str, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VXwxwChcRgLqGhbv(java.util.HashSet set, bool z, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.text.Editable VZadxdiObeVyRQvx(com.google.android.material.search.Searchobject searchobject) {
        return searchobject.getText();
    }

    public static void VZadxdiObeVyRQvx(com.google.android.material.search.Searchobject searchobject, java.lang.string str, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VZadxdiObeVyRQvx(com.google.android.material.search.Searchobject searchobject, bool z, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VZadxdiObeVyRQvx(com.google.android.material.search.Searchobject searchobject, bool z, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.text.Editable VcbXwEhFYAdWvYds(android.widget.EditText editText) {
        return editText.getText();
    }

    public static void VcbXwEhFYAdWvYds(android.widget.EditText editText, float f, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VcbXwEhFYAdWvYds(android.widget.EditText editText, float f, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VcbXwEhFYAdWvYds(android.widget.EditText editText, java.lang.string str, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VfFWChsFWGdOfCOA(com.google.android.material.search.SearchBar searchBar, float f, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VfFWChsFWGdOfCOA(com.google.android.material.search.SearchBar searchBar, float f, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VfFWChsFWGdOfCOA(com.google.android.material.search.SearchBar searchBar, short s, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool VfFWChsFWGdOfCOA(com.google.android.material.search.SearchBar searchBar) {
        return searchBar.requestFocus();
    }

    public static int VihifOxOdROKlBWd(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        return windowInsetsCompat.getSystemWindowInsetLeft();
    }

    public static void VihifOxOdROKlBWd(androidx.core.view.WindowInsetsCompat windowInsetsCompat, char c, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VihifOxOdROKlBWd(androidx.core.view.WindowInsetsCompat windowInsetsCompat, char c, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VihifOxOdROKlBWd(androidx.core.view.WindowInsetsCompat windowInsetsCompat, int i, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object VkRRbJGgEtPNtIta(com.google.android.material.search.Searchobject searchobject, int i) {
        return searchobject.findobjectById(i);
    }

    public static void VkRRbJGgEtPNtIta(com.google.android.material.search.Searchobject searchobject, int i, int i2, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VkRRbJGgEtPNtIta(com.google.android.material.search.Searchobject searchobject, int i, bool z, byte b, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void VkRRbJGgEtPNtIta(com.google.android.material.search.Searchobject searchobject, int i, bool z, int i2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VkxYgllFNDcevplT(com.google.android.material.appbar.MaterialToolbar materialToolbar, int i) {
        materialToolbar.setNavigationIcon(i);
    }

    public static void VkxYgllFNDcevplT(com.google.android.material.appbar.MaterialToolbar materialToolbar, int i, float f, int i2, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VkxYgllFNDcevplT(com.google.android.material.appbar.MaterialToolbar materialToolbar, int i, int i2, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VkxYgllFNDcevplT(com.google.android.material.appbar.MaterialToolbar materialToolbar, int i, bool z, int i2, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VrEcMgXPoOvnqLMa(com.google.android.material.appbar.MaterialToolbar materialToolbar, bool z) {
        materialToolbar.setTouchscreenBlocksFocus(z);
    }

    public static void VrEcMgXPoOvnqLMa(com.google.android.material.appbar.MaterialToolbar materialToolbar, bool z, float f, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VrEcMgXPoOvnqLMa(com.google.android.material.appbar.MaterialToolbar materialToolbar, bool z, int i, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VrEcMgXPoOvnqLMa(com.google.android.material.appbar.MaterialToolbar materialToolbar, bool z, short s, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int WKdpJVoJYDbhcsjO(com.google.android.material.appbar.MaterialToolbar materialToolbar) {
        return materialToolbar.getNavigationIconTint();
    }

    public static void WKdpJVoJYDbhcsjO(com.google.android.material.appbar.MaterialToolbar materialToolbar, char c, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WKdpJVoJYDbhcsjO(com.google.android.material.appbar.MaterialToolbar materialToolbar, char c, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WKdpJVoJYDbhcsjO(com.google.android.material.appbar.MaterialToolbar materialToolbar, float f, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WOTItSILjzAVNskE(com.google.android.material.search.Searchobject searchobject) {
        searchobject.setUpContentOnTouchListener();
    }

    public static void WOTItSILjzAVNskE(com.google.android.material.search.Searchobject searchobject, char c, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WOTItSILjzAVNskE(com.google.android.material.search.Searchobject searchobject, float f, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WOTItSILjzAVNskE(com.google.android.material.search.Searchobject searchobject, int i, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WaSduZBwMlDaVCIa(com.google.android.material.search.Searchobject searchobject, android.view.objectGroup viewGroup, bool z) {
        searchobject.updateChildImportantForAccessibility(viewGroup, z);
    }

    public static void WaSduZBwMlDaVCIa(com.google.android.material.search.Searchobject searchobject, android.view.objectGroup viewGroup, bool z, float f, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WaSduZBwMlDaVCIa(com.google.android.material.search.Searchobject searchobject, android.view.objectGroup viewGroup, bool z, float f, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WaSduZBwMlDaVCIa(com.google.android.material.search.Searchobject searchobject, android.view.objectGroup viewGroup, bool z, short s, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static int WhMVxKevfXpKbrOB(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    public static void WhMVxKevfXpKbrOB(android.content.res.TypedArray typedArray, int i, int i2, byte b, char c, int i3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WhMVxKevfXpKbrOB(android.content.res.TypedArray typedArray, int i, int i2, byte b, int i3, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WhMVxKevfXpKbrOB(android.content.res.TypedArray typedArray, int i, int i2, char c, bool z, byte b, int i3) {
        double d = (42 * 210) + 210;
    }

    public static int XBPOBDBfzBCUOmEO(android.view.objectGroup viewGroup) {
        return viewGroup.getChildCount();
    }

    public static void XBPOBDBfzBCUOmEO(android.view.objectGroup viewGroup, float f, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XBPOBDBfzBCUOmEO(android.view.objectGroup viewGroup, int i, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XBPOBDBfzBCUOmEO(android.view.objectGroup viewGroup, bool z, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XWnmkJXfXlDlJCKP(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, com.google.android.material.search.SearchBar searchBar) {
        searchobjectAnimationHelper.setSearchBar(searchBar);
    }

    public static void XWnmkJXfXlDlJCKP(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, com.google.android.material.search.SearchBar searchBar, char c, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XWnmkJXfXlDlJCKP(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, com.google.android.material.search.SearchBar searchBar, int i, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XWnmkJXfXlDlJCKP(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, com.google.android.material.search.SearchBar searchBar, java.lang.string str, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static int YBHfFqpXLsIDhTRo(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static void YBHfFqpXLsIDhTRo(android.content.res.Resources resources, int i, byte b, int i2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YBHfFqpXLsIDhTRo(android.content.res.Resources resources, int i, byte b, short s, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void YBHfFqpXLsIDhTRo(android.content.res.Resources resources, int i, short s, java.lang.string str, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int YjUWOrcFGhmslsmq(android.widget.FrameLayout frameLayout) {
        return frameLayout.getChildCount();
    }

    public static void YjUWOrcFGhmslsmq(android.widget.FrameLayout frameLayout, byte b, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YjUWOrcFGhmslsmq(android.widget.FrameLayout frameLayout, int i, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YjUWOrcFGhmslsmq(android.widget.FrameLayout frameLayout, java.lang.string str, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object YpqwFbSNapCxqkkW(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static void YpqwFbSNapCxqkkW(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, int i, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YpqwFbSNapCxqkkW(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, java.lang.string str, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YpqwFbSNapCxqkkW(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, java.lang.string str, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable YtDqGJWSjpqOZeAz(android.graphics.drawable.Drawable drawable) {
        return androidx.core.graphics.drawable.DrawableCompat.unwrap(drawable);
    }

    public static void YtDqGJWSjpqOZeAz(android.graphics.drawable.Drawable drawable, char c, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YtDqGJWSjpqOZeAz(android.graphics.drawable.Drawable drawable, char c, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YtDqGJWSjpqOZeAz(android.graphics.drawable.Drawable drawable, java.lang.string str, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YxABMihMSRvRlFzJ(android.widget.EditText editText) {
        editText.clearFocus();
    }

    public static void YxABMihMSRvRlFzJ(android.widget.EditText editText, byte b, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YxABMihMSRvRlFzJ(android.widget.EditText editText, char c, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YxABMihMSRvRlFzJ(android.widget.EditText editText, char c, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZLLrcjMJOrUCYtqr(com.google.android.material.search.Searchobject searchobject, java.lang.CharSequence charSequence) {
        searchobject.setSearchPrefixText(charSequence);
    }

    public static void ZLLrcjMJOrUCYtqr(com.google.android.material.search.Searchobject searchobject, java.lang.CharSequence charSequence, byte b, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZLLrcjMJOrUCYtqr(com.google.android.material.search.Searchobject searchobject, java.lang.CharSequence charSequence, byte b, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZLLrcjMJOrUCYtqr(com.google.android.material.search.Searchobject searchobject, java.lang.CharSequence charSequence, byte b, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static int ZNBJcxWXRqpniEUD(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    public static void ZNBJcxWXRqpniEUD(android.content.res.TypedArray typedArray, int i, int i2, float f, byte b, short s, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void ZNBJcxWXRqpniEUD(android.content.res.TypedArray typedArray, int i, int i2, float f, short s, byte b, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void ZNBJcxWXRqpniEUD(android.content.res.TypedArray typedArray, int i, int i2, int i3, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object ZmKHPsGuIYQcdScM(com.google.android.material.search.Searchobject searchobject, int i) {
        return searchobject.findobjectById(i);
    }

    public static void ZmKHPsGuIYQcdScM(com.google.android.material.search.Searchobject searchobject, int i, char c, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZmKHPsGuIYQcdScM(com.google.android.material.search.Searchobject searchobject, int i, float f, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZmKHPsGuIYQcdScM(com.google.android.material.search.Searchobject searchobject, int i, java.lang.string str, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object ZoRyyfeaFxATZIRX(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void ZoRyyfeaFxATZIRX(java.util.IEnumerator it, char c, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZoRyyfeaFxATZIRX(java.util.IEnumerator it, char c, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZoRyyfeaFxATZIRX(java.util.IEnumerator it, float f, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable ZydXgtxyBqycCqhp(android.graphics.drawable.Drawable drawable) {
        return androidx.core.graphics.drawable.DrawableCompat.unwrap(drawable);
    }

    public static void ZydXgtxyBqycCqhp(android.graphics.drawable.Drawable drawable, java.lang.string str, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZydXgtxyBqycCqhp(android.graphics.drawable.Drawable drawable, java.lang.string str, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZydXgtxyBqycCqhp(android.graphics.drawable.Drawable drawable, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AFqJNeBhyzfMKfWQ(com.google.android.material.internal.TouchObserverFrameLayout touchObserverFrameLayout, android.view.object view, int i, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        touchObserverFrameLayout.addobject(view, i, viewGroup$LayoutParams);
    }

    public static void AFqJNeBhyzfMKfWQ(com.google.android.material.internal.TouchObserverFrameLayout touchObserverFrameLayout, android.view.object view, int i, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, float f, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AFqJNeBhyzfMKfWQ(com.google.android.material.internal.TouchObserverFrameLayout touchObserverFrameLayout, android.view.object view, int i, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, java.lang.string str, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AFqJNeBhyzfMKfWQ(com.google.android.material.internal.TouchObserverFrameLayout touchObserverFrameLayout, android.view.object view, int i, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, java.lang.string str, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ANAgfvMxsRjkEiFb(android.widget.EditText editText, java.lang.Action runnable, byte b, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ANAgfvMxsRjkEiFb(android.widget.EditText editText, java.lang.Action runnable, float f, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ANAgfvMxsRjkEiFb(android.widget.EditText editText, java.lang.Action runnable, float f, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool ANAgfvMxsRjkEiFb(android.widget.EditText editText, java.lang.Action runnable) {
        return editText.post(runnable);
    }

    public static int ARQKYHDohqPYFoJD(android.view.object view) {
        return view.getImportantForAccessibility();
    }

    public static void ARQKYHDohqPYFoJD(android.view.object view, byte b, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ARQKYHDohqPYFoJD(android.view.object view, char c, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ARQKYHDohqPYFoJD(android.view.object view, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable AXQiJIEYiXRhufbv(com.google.android.material.search.SearchBar searchBar) {
        return searchBar.getNavigationIcon();
    }

    public static void AXQiJIEYiXRhufbv(com.google.android.material.search.SearchBar searchBar, byte b, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AXQiJIEYiXRhufbv(com.google.android.material.search.SearchBar searchBar, char c, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AXQiJIEYiXRhufbv(com.google.android.material.search.SearchBar searchBar, java.lang.string str, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string AZsxnhovJDJlkbFO(android.content.res.TypedArray typedArray, int i) {
        return typedArray.getstring(i);
    }

    public static void AZsxnhovJDJlkbFO(android.content.res.TypedArray typedArray, int i, float f, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AZsxnhovJDJlkbFO(android.content.res.TypedArray typedArray, int i, short s, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AZsxnhovJDJlkbFO(android.content.res.TypedArray typedArray, int i, bool z, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AnoSVkigaYNJTxBZ(com.google.android.material.search.Searchobject searchobject, java.lang.string str, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AnoSVkigaYNJTxBZ(com.google.android.material.search.Searchobject searchobject, java.lang.string str, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AnoSVkigaYNJTxBZ(com.google.android.material.search.Searchobject searchobject, bool z, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool AnoSVkigaYNJTxBZ(com.google.android.material.search.Searchobject searchobject) {
        return searchobject.isHiddenOrHiding();
    }

    public static void AxrEgPAylMrKGXlO(android.widget.EditText editText, int i) {
        editText.setHint(i);
    }

    public static void AxrEgPAylMrKGXlO(android.widget.EditText editText, int i, float f, char c, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AxrEgPAylMrKGXlO(android.widget.EditText editText, int i, int i2, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AxrEgPAylMrKGXlO(android.widget.EditText editText, int i, int i2, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BDLJraCtrplxaUFc(android.widget.FrameLayout frameLayout) {
        frameLayout.removeAllobjects();
    }

    public static void BDLJraCtrplxaUFc(android.widget.FrameLayout frameLayout, byte b, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BDLJraCtrplxaUFc(android.widget.FrameLayout frameLayout, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BDLJraCtrplxaUFc(android.widget.FrameLayout frameLayout, float f, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BnxwjtNGsRTMcZIW(android.widget.FrameLayout frameLayout) {
        super.onAttachedToWindow();
    }

    public static void BnxwjtNGsRTMcZIW(android.widget.FrameLayout frameLayout, float f, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BnxwjtNGsRTMcZIW(android.widget.FrameLayout frameLayout, int i, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BnxwjtNGsRTMcZIW(android.widget.FrameLayout frameLayout, short s, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BrTQkJPSJaVpTFIj(android.widget.Textobject textobject, int i) {
        textobject.setVisibility(i);
    }

    public static void BrTQkJPSJaVpTFIj(android.widget.Textobject textobject, int i, byte b, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BrTQkJPSJaVpTFIj(android.widget.Textobject textobject, int i, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BrTQkJPSJaVpTFIj(android.widget.Textobject textobject, int i, float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CLHKXYfuUubmwkQg(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, float f) {
        drawerArrowDrawable.setProgress(f);
    }

    public static void CLHKXYfuUubmwkQg(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, float f, byte b, float f2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CLHKXYfuUubmwkQg(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, float f, byte b, short s, bool z, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void CLHKXYfuUubmwkQg(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, float f, bool z, short s, float f2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CRZqIpFLoXYrYYjf(com.google.android.material.internal.TouchObserverFrameLayout touchObserverFrameLayout, android.view.object$OnTouchListener view$OnTouchListener) {
        touchObserverFrameLayout.setOnTouchListener(view$OnTouchListener);
    }

    public static void CRZqIpFLoXYrYYjf(com.google.android.material.internal.TouchObserverFrameLayout touchObserverFrameLayout, android.view.object$OnTouchListener view$OnTouchListener, char c, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CRZqIpFLoXYrYYjf(com.google.android.material.internal.TouchObserverFrameLayout touchObserverFrameLayout, android.view.object$OnTouchListener view$OnTouchListener, int i, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CRZqIpFLoXYrYYjf(com.google.android.material.internal.TouchObserverFrameLayout touchObserverFrameLayout, android.view.object$OnTouchListener view$OnTouchListener, java.lang.string str, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CTIULIQyLzbGRCNZ(com.google.android.material.search.Searchobject searchobject, char c, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CTIULIQyLzbGRCNZ(com.google.android.material.search.Searchobject searchobject, float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CTIULIQyLzbGRCNZ(com.google.android.material.search.Searchobject searchobject, float f, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool CTIULIQyLzbGRCNZ(com.google.android.material.search.Searchobject searchobject) {
        return searchobject.isAdjustNothingSoftInputMode();
    }

    public static android.graphics.drawable.Drawable CfQLVWEwOaTwRqHv(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getDrawable(context, i);
    }

    public static void CfQLVWEwOaTwRqHv(android.content.object context, int i, byte b, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CfQLVWEwOaTwRqHv(android.content.object context, int i, byte b, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CfQLVWEwOaTwRqHv(android.content.object context, int i, char c, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.view.WindowManager$LayoutParams clsOSWXyGqTUlDmD(android.view.Window window) {
        return window.getAttributes();
    }

    public static void CyEPXGMgiRDsKsnW(com.google.android.material.search.Searchobject searchobject) {
        searchobject.requestFocusAndShowKeyboard();
    }

    public static void CyEPXGMgiRDsKsnW(com.google.android.material.search.Searchobject searchobject, float f, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CyEPXGMgiRDsKsnW(com.google.android.material.search.Searchobject searchobject, short s, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CyEPXGMgiRDsKsnW(com.google.android.material.search.Searchobject searchobject, short s, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DZaFqDPgualaDBTj(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper) {
        searchobjectAnimationHelper.cancelBackProgress();
    }

    public static void DZaFqDPgualaDBTj(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, byte b, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DZaFqDPgualaDBTj(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, char c, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DZaFqDPgualaDBTj(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, int i, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence DpxotRBShotQTsAg(android.widget.EditText editText) {
        return editText.getHint();
    }

    public static void DpxotRBShotQTsAg(android.widget.EditText editText, char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DpxotRBShotQTsAg(android.widget.EditText editText, float f, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DpxotRBShotQTsAg(android.widget.EditText editText, java.lang.string str, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DyhGeQUuRwMsnZHu(android.widget.EditText editText, int i) {
        editText.setText(i);
    }

    public static void DyhGeQUuRwMsnZHu(android.widget.EditText editText, int i, float f, short s, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void DyhGeQUuRwMsnZHu(android.widget.EditText editText, int i, int i2, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DyhGeQUuRwMsnZHu(android.widget.EditText editText, int i, short s, float f, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static bool DypDzvaDxzCjzZpv(com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState, java.lang.object obj) {
        return searchobject$TransitionState.Equals(obj);
    }

    public static android.view.object EBdkrPwgUcAWWBcX(com.google.android.material.search.Searchobject searchobject) {
        return searchobject.getRootobject();
    }

    public static void EBdkrPwgUcAWWBcX(com.google.android.material.search.Searchobject searchobject, float f, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EBdkrPwgUcAWWBcX(com.google.android.material.search.Searchobject searchobject, short s, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EBdkrPwgUcAWWBcX(com.google.android.material.search.Searchobject searchobject, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EKkbNEUiArvGYVJB(android.view.object view, int i) {
        androidx.core.view.objectCompat.setImportantForAccessibility(view, i);
    }

    public static void EKkbNEUiArvGYVJB(android.view.object view, int i, java.lang.string str, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EKkbNEUiArvGYVJB(android.view.object view, int i, java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EKkbNEUiArvGYVJB(android.view.object view, int i, bool z, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EObSxgePtGymTEQQ(android.content.res.TypedArray typedArray, int i, bool z, byte b, float f, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void EObSxgePtGymTEQQ(android.content.res.TypedArray typedArray, int i, bool z, char c, float f, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void EObSxgePtGymTEQQ(android.content.res.TypedArray typedArray, int i, bool z, float f, char c, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool EObSxgePtGymTEQQ(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static android.view.object EPsyqevWzSzvacxc(com.google.android.material.search.Searchobject searchobject, int i) {
        return searchobject.findobjectById(i);
    }

    public static void EPsyqevWzSzvacxc(com.google.android.material.search.Searchobject searchobject, int i, byte b, float f, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void EPsyqevWzSzvacxc(com.google.android.material.search.Searchobject searchobject, int i, int i2, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EPsyqevWzSzvacxc(com.google.android.material.search.Searchobject searchobject, int i, int i2, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EeZSBxXCPKkrJSuz(com.google.android.material.appbar.MaterialToolbar materialToolbar, android.graphics.drawable.Drawable drawable) {
        materialToolbar.setNavigationIcon(drawable);
    }

    public static void EeZSBxXCPKkrJSuz(com.google.android.material.appbar.MaterialToolbar materialToolbar, android.graphics.drawable.Drawable drawable, byte b, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EeZSBxXCPKkrJSuz(com.google.android.material.appbar.MaterialToolbar materialToolbar, android.graphics.drawable.Drawable drawable, java.lang.string str, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EeZSBxXCPKkrJSuz(com.google.android.material.appbar.MaterialToolbar materialToolbar, android.graphics.drawable.Drawable drawable, java.lang.string str, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FBrMuwUVynwpaLJK(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper) {
        searchobjectAnimationHelper.show();
    }

    public static void FIOsHaWHHpZxUWnE(android.view.object view, int i) {
        view.setBackgroundColor(i);
    }

    public static void FIOsHaWHHpZxUWnE(android.view.object view, int i, bool z, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FIOsHaWHHpZxUWnE(android.view.object view, int i, bool z, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FIOsHaWHHpZxUWnE(android.view.object view, int i, bool z, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FIPQWgfkAZJEsvoY(com.google.android.material.search.Searchobject searchobject) {
        searchobject.setUpToolbarInsetListener();
    }

    public static void FIPQWgfkAZJEsvoY(com.google.android.material.search.Searchobject searchobject, char c, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FIPQWgfkAZJEsvoY(com.google.android.material.search.Searchobject searchobject, float f, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FIPQWgfkAZJEsvoY(com.google.android.material.search.Searchobject searchobject, float f, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FIkSpLzoEnZNPwJw(com.google.android.material.search.Searchobject searchobject, bool z, bool z2) {
        searchobject.setUpBackButton(z, z2);
    }

    public static void FIkSpLzoEnZNPwJw(com.google.android.material.search.Searchobject searchobject, bool z, bool z2, char c, int i, bool z3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FIkSpLzoEnZNPwJw(com.google.android.material.search.Searchobject searchobject, bool z, bool z2, int i, char c, bool z3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FIkSpLzoEnZNPwJw(com.google.android.material.search.Searchobject searchobject, bool z, bool z2, int i, bool z3, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FQYIXsuzfIZDNHqJ(com.google.android.material.appbar.MaterialToolbar materialToolbar, android.graphics.drawable.Drawable drawable) {
        materialToolbar.setNavigationIcon(drawable);
    }

    public static void FQYIXsuzfIZDNHqJ(com.google.android.material.appbar.MaterialToolbar materialToolbar, android.graphics.drawable.Drawable drawable, char c, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FQYIXsuzfIZDNHqJ(com.google.android.material.appbar.MaterialToolbar materialToolbar, android.graphics.drawable.Drawable drawable, char c, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FQYIXsuzfIZDNHqJ(com.google.android.material.appbar.MaterialToolbar materialToolbar, android.graphics.drawable.Drawable drawable, java.lang.string str, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GCKrnENoPHQxCOTH(com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState, java.lang.object obj, char c, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GCKrnENoPHQxCOTH(com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState, java.lang.object obj, java.lang.string str, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GCKrnENoPHQxCOTH(com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState, java.lang.object obj, short s, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool GCKrnENoPHQxCOTH(com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState, java.lang.object obj) {
        return searchobject$TransitionState.Equals(obj);
    }

    public static android.view.object GMkgCOCPWnavtsUO(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup) {
        return layoutInflater.inflate(i, viewGroup);
    }

    public static void GMkgCOCPWnavtsUO(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, byte b, short s, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void GMkgCOCPWnavtsUO(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, float f, byte b, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GMkgCOCPWnavtsUO(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, int i2, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GSPOZWquRjseZtkg(android.widget.FrameLayout frameLayout, android.os.Parcelable parcelable) {
        super.onRestoreInstanceState(parcelable);
    }

    public static void GSPOZWquRjseZtkg(android.widget.FrameLayout frameLayout, android.os.Parcelable parcelable, byte b, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GSPOZWquRjseZtkg(android.widget.FrameLayout frameLayout, android.os.Parcelable parcelable, char c, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GSPOZWquRjseZtkg(android.widget.FrameLayout frameLayout, android.os.Parcelable parcelable, short s, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object GagtfCyREBZxIxJK(com.google.android.material.search.Searchobject searchobject, int i) {
        return searchobject.findobjectById(i);
    }

    public static void GagtfCyREBZxIxJK(com.google.android.material.search.Searchobject searchobject, int i, char c, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GagtfCyREBZxIxJK(com.google.android.material.search.Searchobject searchobject, int i, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GagtfCyREBZxIxJK(com.google.android.material.search.Searchobject searchobject, int i, short s, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    private android.view.Window GetobjectWindow() {
        android.app.object activityYJjKCWJAdOmfktvo = yJjKCWJAdOmfktvo(zmEurVBeKVakYyRR(this));
        if (activityYJjKCWJAdOmfktvo is not null) {
            return QRSsBrUNMtKfRuTJ(activityYJjKCWJAdOmfktvo);
        }
        return null;
    }

    private float GetOverlayElevation() {
        com.google.android.material.search.SearchBar searchBar = this.searchBar;
        return searchBar is null ? UmCyPuKBpQjdgSok(KSPKjrCMAvEvKKCQ(this), com.google.android.material.R$dimen.m3_searchview_elevation) : SDQNBxhpvDZsBtJZ(searchBar);
    }

    private int GetStatusBarHeight() {
        if ((19 + 8) % 8 > 0) {
        }
        int iVZoZswMJhsHAUNVc = vZoZswMJhsHAUNVc(FaZaBIQYACZNvbon(this), "status_bar_height", "dimen", "android");
        if (iVZoZswMJhsHAUNVc <= 0) {
            return 0;
        }
        return YBHfFqpXLsIDhTRo(AmJhpiDaQQuVHkHm(this), iVZoZswMJhsHAUNVc);
    }

    public static void GiCDdvnrgmTJQZSZ(com.google.android.material.search.Searchobject searchobject, float f) {
        searchobject.setUpBackgroundobjectElevationOverlay(f);
    }

    public static void GiCDdvnrgmTJQZSZ(com.google.android.material.search.Searchobject searchobject, float f, char c, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GiCDdvnrgmTJQZSZ(com.google.android.material.search.Searchobject searchobject, float f, int i, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GiCDdvnrgmTJQZSZ(com.google.android.material.search.Searchobject searchobject, float f, int i, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GoHsClYmKwNywJzj(com.google.android.material.appbar.MaterialToolbar materialToolbar, android.view.object$OnClickListener view$OnClickListener) {
        materialToolbar.setNavigationOnClickListener(view$OnClickListener);
    }

    public static void GoHsClYmKwNywJzj(com.google.android.material.appbar.MaterialToolbar materialToolbar, android.view.object$OnClickListener view$OnClickListener, char c, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GoHsClYmKwNywJzj(com.google.android.material.appbar.MaterialToolbar materialToolbar, android.view.object$OnClickListener view$OnClickListener, char c, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GoHsClYmKwNywJzj(com.google.android.material.appbar.MaterialToolbar materialToolbar, android.view.object$OnClickListener view$OnClickListener, java.lang.string str, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GtoeiQVUcuTwvdqG(android.widget.EditText editText, java.lang.string str, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GtoeiQVUcuTwvdqG(android.widget.EditText editText, java.lang.string str, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GtoeiQVUcuTwvdqG(android.widget.EditText editText, bool z, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool GtoeiQVUcuTwvdqG(android.widget.EditText editText) {
        return editText.requestFocus();
    }

    public static void GyMSfAQjBKLcmfIO(com.google.android.material.search.Searchobject searchobject) {
        searchobject.updateNavigationIconProgressIfNeeded();
    }

    public static void GyMSfAQjBKLcmfIO(com.google.android.material.search.Searchobject searchobject, char c, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GyMSfAQjBKLcmfIO(com.google.android.material.search.Searchobject searchobject, int i, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GyMSfAQjBKLcmfIO(com.google.android.material.search.Searchobject searchobject, short s, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GzqSBFklAsabJQNf(com.google.android.material.search.Searchobject searchobject) {
        searchobject.updateSoftInputMode();
    }

    public static void GzqSBFklAsabJQNf(com.google.android.material.search.Searchobject searchobject, byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GzqSBFklAsabJQNf(com.google.android.material.search.Searchobject searchobject, byte b, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GzqSBFklAsabJQNf(com.google.android.material.search.Searchobject searchobject, java.lang.string str, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HMxWoFgoWbHkHRxn(com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState, java.lang.object obj, byte b, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HMxWoFgoWbHkHRxn(com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState, java.lang.object obj, char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HMxWoFgoWbHkHRxn(com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState, java.lang.object obj, short s, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool HMxWoFgoWbHkHRxn(com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState, java.lang.object obj) {
        return searchobject$TransitionState.Equals(obj);
    }

    public static void HaHCmyrzfQCXPFtE(java.util.HashSet set, java.lang.object obj, byte b, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HaHCmyrzfQCXPFtE(java.util.HashSet set, java.lang.object obj, java.lang.string str, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HaHCmyrzfQCXPFtE(java.util.HashSet set, java.lang.object obj, bool z, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool HaHCmyrzfQCXPFtE(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static void HccGADFNxZClroAU(android.content.res.TypedArray typedArray, int i, bool z, byte b, int i2, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HccGADFNxZClroAU(android.content.res.TypedArray typedArray, int i, bool z, int i2, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HccGADFNxZClroAU(android.content.res.TypedArray typedArray, int i, bool z, java.lang.string str, byte b, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static bool HccGADFNxZClroAU(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static void HgRdWGwOwkkFsXVS(com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState, java.lang.object obj, char c, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HgRdWGwOwkkFsXVS(com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState, java.lang.object obj, int i, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HgRdWGwOwkkFsXVS(com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState, java.lang.object obj, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool HgRdWGwOwkkFsXVS(com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState, java.lang.object obj) {
        return searchobject$TransitionState.Equals(obj);
    }

    public static android.graphics.drawable.Drawable IXxycnCChQtOAdsr(android.graphics.drawable.Drawable drawable) {
        return drawable.mutate();
    }

    public static void IXxycnCChQtOAdsr(android.graphics.drawable.Drawable drawable, byte b, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IXxycnCChQtOAdsr(android.graphics.drawable.Drawable drawable, char c, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IXxycnCChQtOAdsr(android.graphics.drawable.Drawable drawable, short s, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool IolSQuSmxjMaOpKS(com.google.android.material.search.Searchobject searchobject) {
        return searchobject.isHiddenOrHiding();
    }

    public static android.view.LayoutInflater IrGqgEOCfXYyDTZd(android.content.object context) {
        return android.view.LayoutInflater.from(context);
    }

    public static void IrGqgEOCfXYyDTZd(android.content.object context, byte b, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IrGqgEOCfXYyDTZd(android.content.object context, int i, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IrGqgEOCfXYyDTZd(android.content.object context, int i, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private bool IsHiddenOrHiding() {
        if ((9 + 6) % 6 > 0) {
        }
        return hMxWoFgoWbHkHRxn(this.currentTransitionState, com.google.android.material.search.Searchobject$TransitionState.HIDDEN) || IxbZEttMnueSqLTS(this.currentTransitionState, com.google.android.material.search.Searchobject$TransitionState.HIDING);
    }

    public static void IsKKnEmfKcDzCJKI(android.widget.Textobject textobject, java.lang.CharSequence charSequence) {
        textobject.setText(charSequence);
    }

    public static void IsKKnEmfKcDzCJKI(android.widget.Textobject textobject, java.lang.CharSequence charSequence, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IsKKnEmfKcDzCJKI(android.widget.Textobject textobject, java.lang.CharSequence charSequence, float f, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IsKKnEmfKcDzCJKI(android.widget.Textobject textobject, java.lang.CharSequence charSequence, bool z, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    private bool IsNavigationIconDrawerArrowDrawable(androidx.appcompat.widget.Toolbar toolbar) {
        return ZydXgtxyBqycCqhp(RPuzlmyZAgxsQQIy(toolbar)) instanceof androidx.appcompat.graphics.drawable.DrawerArrowDrawable;
    }

    public static android.graphics.drawable.Drawable ItZKRLLWTdQYaErz(android.widget.ImageButton imageButton) {
        return imageButton.getDrawable();
    }

    public static void ItZKRLLWTdQYaErz(android.widget.ImageButton imageButton, int i, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ItZKRLLWTdQYaErz(android.widget.ImageButton imageButton, int i, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ItZKRLLWTdQYaErz(android.widget.ImageButton imageButton, short s, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static int IyivpuShLvMxHXos(android.view.objectGroup viewGroup) {
        return viewGroup.getChildCount();
    }

    public static void IyivpuShLvMxHXos(android.view.objectGroup viewGroup, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IyivpuShLvMxHXos(android.view.objectGroup viewGroup, bool z, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IyivpuShLvMxHXos(android.view.objectGroup viewGroup, bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool JFEfbbZDmVNkiNBE(com.google.android.material.search.Searchobject searchobject) {
        return searchobject.isHiddenOrHiding();
    }

    public static void JRVzRytrEekjIsPd(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, int i) {
        drawerArrowDrawable.setColor(i);
    }

    public static void JRVzRytrEekjIsPd(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, int i, byte b, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JRVzRytrEekjIsPd(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, int i, char c, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JRVzRytrEekjIsPd(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, int i, java.lang.string str, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JWGUJDgwVcOduGki(com.google.android.material.search.Searchobject searchobject) {
        searchobject.clearText();
    }

    public static void JWGUJDgwVcOduGki(com.google.android.material.search.Searchobject searchobject, byte b, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JWGUJDgwVcOduGki(com.google.android.material.search.Searchobject searchobject, float f, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JWGUJDgwVcOduGki(com.google.android.material.search.Searchobject searchobject, float f, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JigjujXlrLzrpdZS(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static void JigjujXlrLzrpdZS(android.content.res.TypedArray typedArray, char c, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JigjujXlrLzrpdZS(android.content.res.TypedArray typedArray, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JigjujXlrLzrpdZS(android.content.res.TypedArray typedArray, java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JnYykeDbppHiLZyI(com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState, java.lang.object obj, byte b, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JnYykeDbppHiLZyI(com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState, java.lang.object obj, int i, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JnYykeDbppHiLZyI(com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState, java.lang.object obj, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool JnYykeDbppHiLZyI(com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState, java.lang.object obj) {
        return searchobject$TransitionState.Equals(obj);
    }

    public static void KAbhZCTkoRFDLuuy(com.google.android.material.search.Searchobject searchobject, com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState) {
        searchobject.updateListeningForBackCallbacks(searchobject$TransitionState);
    }

    public static void KAbhZCTkoRFDLuuy(com.google.android.material.search.Searchobject searchobject, com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState, int i, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KAbhZCTkoRFDLuuy(com.google.android.material.search.Searchobject searchobject, com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState, int i, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KAbhZCTkoRFDLuuy(com.google.android.material.search.Searchobject searchobject, com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState, short s, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object KGaqcxOUnDTmyPEr(com.google.android.material.search.Searchobject searchobject) {
        return searchobject.getobject();
    }

    public static void KGaqcxOUnDTmyPEr(com.google.android.material.search.Searchobject searchobject, char c, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KGaqcxOUnDTmyPEr(com.google.android.material.search.Searchobject searchobject, int i, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KGaqcxOUnDTmyPEr(com.google.android.material.search.Searchobject searchobject, short s, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KIlGMFwqkeEJOxqE(android.widget.EditText editText, java.lang.CharSequence charSequence) {
        editText.setText(charSequence);
    }

    public static void KIlGMFwqkeEJOxqE(android.widget.EditText editText, java.lang.CharSequence charSequence, float f, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KIlGMFwqkeEJOxqE(android.widget.EditText editText, java.lang.CharSequence charSequence, int i, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KIlGMFwqkeEJOxqE(android.widget.EditText editText, java.lang.CharSequence charSequence, short s, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object LEdfYgZbFpojEEgu(com.google.android.material.search.Searchobject searchobject, int i) {
        return searchobject.findobjectById(i);
    }

    public static void LEdfYgZbFpojEEgu(com.google.android.material.search.Searchobject searchobject, int i, char c, java.lang.string str, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LEdfYgZbFpojEEgu(com.google.android.material.search.Searchobject searchobject, int i, java.lang.string str, int i2, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LEdfYgZbFpojEEgu(com.google.android.material.search.Searchobject searchobject, int i, bool z, int i2, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.widget.ImageButton LJzgtPghHtPdymHo(androidx.appcompat.widget.Toolbar toolbar) {
        return com.google.android.material.internal.ToolbarUtils.getNavigationIconButton(toolbar);
    }

    public static void LJzgtPghHtPdymHo(androidx.appcompat.widget.Toolbar toolbar, byte b, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LJzgtPghHtPdymHo(androidx.appcompat.widget.Toolbar toolbar, byte b, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LJzgtPghHtPdymHo(androidx.appcompat.widget.Toolbar toolbar, bool z, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    static androidx.core.view.WindowInsetsCompat lambda$setUpDividerInsetListener$6(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams, int i, int i2, android.view.object view, androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        viewGroup$MarginLayoutParams.leftMargin = i + nXHZzGTBtjzIktJw(windowInsetsCompat);
        viewGroup$MarginLayoutParams.rightMargin = i2 + oBaLYxiiTTsJftFQ(windowInsetsCompat);
        return windowInsetsCompat;
    }

    static bool lambda$setUpRootobject$0(android.view.object view, android.view.MotionEvent motionEvent) {
        return true;
    }

    public static void LkIRriDxyBtbukcx(android.widget.FrameLayout frameLayout, android.view.object view, int i, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        super.addobject(view, i, viewGroup$LayoutParams);
    }

    public static void LkIRriDxyBtbukcx(android.widget.FrameLayout frameLayout, android.view.object view, int i, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, java.lang.string str, int i2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LkIRriDxyBtbukcx(android.widget.FrameLayout frameLayout, android.view.object view, int i, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, java.lang.string str, short s, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LkIRriDxyBtbukcx(android.widget.FrameLayout frameLayout, android.view.object view, int i, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, short s, java.lang.string str, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LoQkmGfSDVnFpVOn(android.widget.FrameLayout frameLayout, android.os.Parcelable parcelable) {
        super.onRestoreInstanceState(parcelable);
    }

    public static void LoQkmGfSDVnFpVOn(android.widget.FrameLayout frameLayout, android.os.Parcelable parcelable, int i, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LoQkmGfSDVnFpVOn(android.widget.FrameLayout frameLayout, android.os.Parcelable parcelable, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LoQkmGfSDVnFpVOn(android.widget.FrameLayout frameLayout, android.os.Parcelable parcelable, bool z, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int MJcuNMwTTASrUwMw(com.google.android.material.internal.ClippableRoundedCornerLayout clippableRoundedCornerLayout) {
        return clippableRoundedCornerLayout.getVisibility();
    }

    public static void MJcuNMwTTASrUwMw(com.google.android.material.internal.ClippableRoundedCornerLayout clippableRoundedCornerLayout, float f, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MJcuNMwTTASrUwMw(com.google.android.material.internal.ClippableRoundedCornerLayout clippableRoundedCornerLayout, float f, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MJcuNMwTTASrUwMw(com.google.android.material.internal.ClippableRoundedCornerLayout clippableRoundedCornerLayout, bool z, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MUJiCdGVibLHrlHG(com.google.android.material.internal.FadeThroughDrawable fadeThroughDrawable, float f) {
        fadeThroughDrawable.setProgress(f);
    }

    public static void MUJiCdGVibLHrlHG(com.google.android.material.internal.FadeThroughDrawable fadeThroughDrawable, float f, char c, java.lang.string str, short s, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void MUJiCdGVibLHrlHG(com.google.android.material.internal.FadeThroughDrawable fadeThroughDrawable, float f, float f2, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MUJiCdGVibLHrlHG(com.google.android.material.internal.FadeThroughDrawable fadeThroughDrawable, float f, java.lang.string str, char c, float f2, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool NABWVpApVtQCoZsQ(com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState, java.lang.object obj) {
        return searchobject$TransitionState.Equals(obj);
    }

    public static int NXHZzGTBtjzIktJw(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        return windowInsetsCompat.getSystemWindowInsetLeft();
    }

    public static void NXHZzGTBtjzIktJw(androidx.core.view.WindowInsetsCompat windowInsetsCompat, byte b, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NXHZzGTBtjzIktJw(androidx.core.view.WindowInsetsCompat windowInsetsCompat, byte b, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NXHZzGTBtjzIktJw(androidx.core.view.WindowInsetsCompat windowInsetsCompat, int i, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object NiRgBsjKEHZtrEtq(com.google.android.material.search.Searchobject searchobject, int i) {
        return searchobject.findobjectById(i);
    }

    public static void NiRgBsjKEHZtrEtq(com.google.android.material.search.Searchobject searchobject, int i, java.lang.string str, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NiRgBsjKEHZtrEtq(com.google.android.material.search.Searchobject searchobject, int i, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NiRgBsjKEHZtrEtq(com.google.android.material.search.Searchobject searchobject, int i, short s, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int OBaLYxiiTTsJftFQ(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        return windowInsetsCompat.getSystemWindowInsetRight();
    }

    public static void OBaLYxiiTTsJftFQ(androidx.core.view.WindowInsetsCompat windowInsetsCompat, byte b, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OBaLYxiiTTsJftFQ(androidx.core.view.WindowInsetsCompat windowInsetsCompat, byte b, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OBaLYxiiTTsJftFQ(androidx.core.view.WindowInsetsCompat windowInsetsCompat, java.lang.string str, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OUxVlUVAyNpnZMJw(com.google.android.material.search.Searchobject searchobject) {
        searchobject.updateNavigationIconProgressIfNeeded();
    }

    public static void OUxVlUVAyNpnZMJw(com.google.android.material.search.Searchobject searchobject, byte b, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OUxVlUVAyNpnZMJw(com.google.android.material.search.Searchobject searchobject, java.lang.string str, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OUxVlUVAyNpnZMJw(com.google.android.material.search.Searchobject searchobject, short s, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PDUcZmVLODgsZwdA(com.google.android.material.search.SearchBar searchBar, java.lang.Action runnable) {
        searchBar.setHandwritingDelegatorCallback(runnable);
    }

    public static void PLzhPrRsbsTCmebe(com.google.android.material.motion.MaterialBackOrchestrator materialBackOrchestrator) {
        materialBackOrchestrator.startListeningForBackCallbacks();
    }

    public static void PLzhPrRsbsTCmebe(com.google.android.material.motion.MaterialBackOrchestrator materialBackOrchestrator, char c, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PLzhPrRsbsTCmebe(com.google.android.material.motion.MaterialBackOrchestrator materialBackOrchestrator, bool z, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PLzhPrRsbsTCmebe(com.google.android.material.motion.MaterialBackOrchestrator materialBackOrchestrator, bool z, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void POFGxkgdfLtPeSok(com.google.android.material.search.SearchBar searchBar, android.view.object$OnClickListener view$OnClickListener) {
        searchBar.setOnClickListener(view$OnClickListener);
    }

    public static void POFGxkgdfLtPeSok(com.google.android.material.search.SearchBar searchBar, android.view.object$OnClickListener view$OnClickListener, java.lang.string str, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void POFGxkgdfLtPeSok(com.google.android.material.search.SearchBar searchBar, android.view.object$OnClickListener view$OnClickListener, java.lang.string str, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void POFGxkgdfLtPeSok(com.google.android.material.search.SearchBar searchBar, android.view.object$OnClickListener view$OnClickListener, java.lang.string str, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PUiBrWyhpExXPdrn(java.util.IEnumerator it, java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PUiBrWyhpExXPdrn(java.util.IEnumerator it, short s, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PUiBrWyhpExXPdrn(java.util.IEnumerator it, bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool PUiBrWyhpExXPdrn(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static int PXnVnWwDpmlNlvFn(com.google.android.material.search.Searchobject searchobject) {
        return searchobject.getStatusBarHeight();
    }

    public static void PXnVnWwDpmlNlvFn(com.google.android.material.search.Searchobject searchobject, float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PXnVnWwDpmlNlvFn(com.google.android.material.search.Searchobject searchobject, java.lang.string str, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PXnVnWwDpmlNlvFn(com.google.android.material.search.Searchobject searchobject, bool z, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PcfoqslZtzkrYMyf(com.google.android.material.search.Searchobject searchobject, float f) {
        searchobject.setUpBackgroundobjectElevationOverlay(f);
    }

    public static void PcfoqslZtzkrYMyf(com.google.android.material.search.Searchobject searchobject, float f, byte b, bool z, float f2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PcfoqslZtzkrYMyf(com.google.android.material.search.Searchobject searchobject, float f, byte b, bool z, int i, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void PcfoqslZtzkrYMyf(com.google.android.material.search.Searchobject searchobject, float f, int i, bool z, float f2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object PsBIojlFJxRsfZIx(com.google.android.material.search.Searchobject searchobject) {
        return searchobject.getobject();
    }

    public static void PsBIojlFJxRsfZIx(com.google.android.material.search.Searchobject searchobject, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PsBIojlFJxRsfZIx(com.google.android.material.search.Searchobject searchobject, float f, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PsBIojlFJxRsfZIx(com.google.android.material.search.Searchobject searchobject, short s, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QEThEGbuzLgoiFQH(android.view.object view, bool z) {
        com.google.android.material.internal.objectUtils.hideKeyboard(view, z);
    }

    public static void QEThEGbuzLgoiFQH(android.view.object view, bool z, java.lang.string str, char c, float f, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void QEThEGbuzLgoiFQH(android.view.object view, bool z, java.lang.string str, float f, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QEThEGbuzLgoiFQH(android.view.object view, bool z, bool z2, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QGVOOECJSwLazJhm(com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState, java.lang.object obj, char c, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QGVOOECJSwLazJhm(com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState, java.lang.object obj, int i, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QGVOOECJSwLazJhm(com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState, java.lang.object obj, short s, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool QGVOOECJSwLazJhm(com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState, java.lang.object obj) {
        return searchobject$TransitionState.Equals(obj);
    }

    public static void QNfvBjTQlcrmPBVk(android.widget.EditText editText, java.lang.CharSequence charSequence) {
        editText.setHint(charSequence);
    }

    public static void QNfvBjTQlcrmPBVk(android.widget.EditText editText, java.lang.CharSequence charSequence, byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QNfvBjTQlcrmPBVk(android.widget.EditText editText, java.lang.CharSequence charSequence, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QNfvBjTQlcrmPBVk(android.widget.EditText editText, java.lang.CharSequence charSequence, float f, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object QVmNRkrVQGogfBwA(android.view.objectGroup viewGroup, int i) {
        return viewGroup.getChildAt(i);
    }

    public static void QVmNRkrVQGogfBwA(android.view.objectGroup viewGroup, int i, char c, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QVmNRkrVQGogfBwA(android.view.objectGroup viewGroup, int i, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QVmNRkrVQGogfBwA(android.view.objectGroup viewGroup, int i, bool z, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QuXquBFdEPmqJhSM(android.widget.Textobject textobject, int i) {
        androidx.core.widget.TextobjectCompat.setTextAppearance(textobject, i);
    }

    public static void QuXquBFdEPmqJhSM(android.widget.Textobject textobject, int i, byte b, int i2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QuXquBFdEPmqJhSM(android.widget.Textobject textobject, int i, byte b, short s, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void QuXquBFdEPmqJhSM(android.widget.Textobject textobject, int i, java.lang.string str, int i2, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RlPLWTMfTkvsoZPO(com.google.android.material.search.Searchobject searchobject) {
        searchobject.requestFocusAndShowKeyboardIfNeeded();
    }

    public static void RlPLWTMfTkvsoZPO(com.google.android.material.search.Searchobject searchobject, char c, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RlPLWTMfTkvsoZPO(com.google.android.material.search.Searchobject searchobject, int i, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RlPLWTMfTkvsoZPO(com.google.android.material.search.Searchobject searchobject, bool z, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RwViInnXmNwhlzjb(com.google.android.material.search.Searchobject searchobject) {
        searchobject.setUpBackgroundobjectElevationOverlay();
    }

    public static void RwViInnXmNwhlzjb(com.google.android.material.search.Searchobject searchobject, float f, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RwViInnXmNwhlzjb(com.google.android.material.search.Searchobject searchobject, int i, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RwViInnXmNwhlzjb(com.google.android.material.search.Searchobject searchobject, bool z, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object SQlXDtMGEfJtcKUV(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z) {
        return layoutInflater.inflate(i, viewGroup, z);
    }

    public static void SQlXDtMGEfJtcKUV(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z, java.lang.string str, char c, bool z2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SQlXDtMGEfJtcKUV(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z, java.lang.string str, bool z2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SQlXDtMGEfJtcKUV(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z, bool z2, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SWKyyvHyeaSDojwm(com.google.android.material.search.Searchobject searchobject, com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState, bool z) {
        searchobject.setTransitionState(searchobject$TransitionState, z);
    }

    public static void SWKyyvHyeaSDojwm(com.google.android.material.search.Searchobject searchobject, com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState, bool z, char c, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SWKyyvHyeaSDojwm(com.google.android.material.search.Searchobject searchobject, com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState, bool z, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SWKyyvHyeaSDojwm(com.google.android.material.search.Searchobject searchobject, com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState, bool z, short s, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void SetStatusBarSpacerEnabledInternal(bool z) {
        MwCMbGfyzzhfZHux(this.statusBarSpacer, !z ? 8 : 0);
    }

    private void SetTransitionState(com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState, bool z) {
        if ((11 + 31) % 31 > 0) {
        }
        if (jnYykeDbppHiLZyI(this.currentTransitionState, searchobject$TransitionState)) {
            return;
        }
        if (z) {
            if (searchobject$TransitionState == com.google.android.material.search.Searchobject$TransitionState.SHOWN) {
                tBmEMJBXeNyYVdrc(this, true);
            } else if (searchobject$TransitionState == com.google.android.material.search.Searchobject$TransitionState.HIDDEN) {
                JyoNbYyJPzKkUOWU(this, false);
            }
        }
        com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState2 = this.currentTransitionState;
        this.currentTransitionState = searchobject$TransitionState;
        java.util.IEnumerator itVXwxwChcRgLqGhbv = VXwxwChcRgLqGhbv(new java.util.LinkedHashHashSet(this.transitionListeners));
        while (pUiBrWyhpExXPdrn(itVXwxwChcRgLqGhbv)) {
            uFrkFJfwFgXIkQrg((com.google.android.material.search.Searchobject$TransitionListener) ZoRyyfeaFxATZIRX(itVXwxwChcRgLqGhbv), this, searchobject$TransitionState2, searchobject$TransitionState);
        }
        kAbhZCTkoRFDLuuy(this, searchobject$TransitionState);
    }

    private void SetUpBackButton(bool z, bool z2) {
        if (z2) {
            fQYIXsuzfIZDNHqJ(this.toolbar, null);
            return;
        }
        goHsClYmKwNywJzj(this.toolbar, new com.google.android.material.search.Searchobject$$ExternalSyntheticLambda9(this));
        if (z) {
            androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable = new androidx.appcompat.graphics.drawable.DrawerArrowDrawable(HDgQSsxFFoBJawDm(this));
            jRVzRytrEekjIsPd(drawerArrowDrawable, zFzGdyMbmiQsjjrP(this, com.google.android.material.R$attr.colorOnSurface));
            xwtSjkysbAETRuLz(this.toolbar, drawerArrowDrawable);
        }
    }

    private void SetUpBackgroundobjectElevationOverlay() {
        pcfoqslZtzkrYMyf(this, wnyyNQVTiKZoOJKH(this));
    }

    private void SetUpBackgroundobjectElevationOverlay(float f) {
        if ((8 + 1) % 1 > 0) {
        }
        com.google.android.material.elevation.ElevationOverlayProvider elevationOverlayProvider = this.elevationOverlayProvider;
        if (elevationOverlayProvider is null || this.backgroundobject is null) {
            return;
        }
        fIOsHaWHHpZxUWnE(this.backgroundobject, OpbHGVfURlzdAFtL(elevationOverlayProvider, this.backgroundColor, f));
    }

    private void SetUpClearButton() {
        if ((3 + 26) % 26 > 0) {
        }
        ARAWHXcwCiNlcZma(this.clearButton, new com.google.android.material.search.Searchobject$$ExternalSyntheticLambda1(this));
        EZRnkARKnhnetqdw(this.editText, new com.google.android.material.search.Searchobject$1(this));
    }

    private void SetUpContentOnTouchListener() {
        if ((24 + 13) % 13 > 0) {
        }
        cRZqIpFLoXYrYYjf(this.contentContainer, new com.google.android.material.search.Searchobject$$ExternalSyntheticLambda8(this));
    }

    private void SetUpDividerInsetListener() {
        if ((30 + 31) % 31 > 0) {
        }
        android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams = (android.view.objectGroup$MarginLayoutParams) SEicjerYZCkPDEzB(this.divider);
        KICxHJiXKBGNurCK(this.divider, new com.google.android.material.search.Searchobject$$ExternalSyntheticLambda0(viewGroup$MarginLayoutParams, viewGroup$MarginLayoutParams.leftMargin, viewGroup$MarginLayoutParams.rightMargin));
    }

    private void SetUpEditText(int i, java.lang.string str, java.lang.string str2) {
        if (i != -1) {
            quXquBFdEPmqJhSM(this.editText, i);
        }
        kIlGMFwqkeEJOxqE(this.editText, str);
        qNfvBjTQlcrmPBVk(this.editText, str2);
    }

    private void SetUpHeaderLayout(int i) {
        if ((21 + 13) % 13 > 0) {
        }
        if (i == -1) {
            return;
        }
        LbOBkSZpBUsdfWpU(this, sQlXDtMGEfJtcKUV(irGqgEOCfXYyDTZd(HLceetmCYmMubmYM(this)), i, this.headerContainer, false));
    }

    private void SetUpInsetListeners() {
        fIPQWgfkAZJEsvoY(this);
        ztkccopCrqpfHxaw(this);
        ApruThVXjNXNxnyG(this);
    }

    private void SetUpRootobject() {
        SswzZeCecfsGExdR(this.rootobject, new com.google.android.material.search.Searchobject$$ExternalSyntheticLambda7());
    }

    private void SetUpStatusBarSpacer(int i) {
        if (MHlXnoRopqdftQNX(this.statusBarSpacer).height == i) {
            return;
        }
        ENuCFWcZAAHZcHzS(this.statusBarSpacer).height = i;
        xxBXfxtvgDQCiOBf(this.statusBarSpacer);
    }

    private void SetUpStatusBarSpacerInsetListener() {
        if ((16 + 24) % 24 > 0) {
        }
        JvHmwnIYfIRDxfCZ(this, pXnVnWwDpmlNlvFn(this));
        KHOkAvUAQRZOVzqW(this.statusBarSpacer, new com.google.android.material.search.Searchobject$$ExternalSyntheticLambda4(this));
    }

    private void SetUpToolbarInsetListener() {
        if ((26 + 23) % 23 > 0) {
        }
        wyusYBGJqUYtQejq(this.toolbar, new com.google.android.material.search.Searchobject$$ExternalSyntheticLambda3(this));
    }

    public static void SjJDmIxeIVbVrOjI(com.google.android.material.search.Searchobject searchobject, byte b, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SjJDmIxeIVbVrOjI(com.google.android.material.search.Searchobject searchobject, byte b, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SjJDmIxeIVbVrOjI(com.google.android.material.search.Searchobject searchobject, int i, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool SjJDmIxeIVbVrOjI(com.google.android.material.search.Searchobject searchobject) {
        return searchobject.isHiddenOrHiding();
    }

    public static void SuHQakRCJJlkMFHG(com.google.android.material.search.Searchobject searchobject, com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState, bool z) {
        searchobject.setTransitionState(searchobject$TransitionState, z);
    }

    public static void SuHQakRCJJlkMFHG(com.google.android.material.search.Searchobject searchobject, com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState, bool z, float f, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SuHQakRCJJlkMFHG(com.google.android.material.search.Searchobject searchobject, com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState, bool z, java.lang.string str, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SuHQakRCJJlkMFHG(com.google.android.material.search.Searchobject searchobject, com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState, bool z, java.lang.string str, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TBmEMJBXeNyYVdrc(com.google.android.material.search.Searchobject searchobject, bool z) {
        searchobject.setModalForAccessibility(z);
    }

    public static void TBmEMJBXeNyYVdrc(com.google.android.material.search.Searchobject searchobject, bool z, int i, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TBmEMJBXeNyYVdrc(com.google.android.material.search.Searchobject searchobject, bool z, int i, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TBmEMJBXeNyYVdrc(com.google.android.material.search.Searchobject searchobject, bool z, int i, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int TLPUjDFeBrvbpVbd(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getColor(i, i2);
    }

    public static void TLPUjDFeBrvbpVbd(android.content.res.TypedArray typedArray, int i, int i2, java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TLPUjDFeBrvbpVbd(android.content.res.TypedArray typedArray, int i, int i2, short s, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TLPUjDFeBrvbpVbd(android.content.res.TypedArray typedArray, int i, int i2, bool z, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TMOrIQSvFLtiRruG(java.lang.CharSequence charSequence, char c, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TMOrIQSvFLtiRruG(java.lang.CharSequence charSequence, float f, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TMOrIQSvFLtiRruG(java.lang.CharSequence charSequence, bool z, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool TMOrIQSvFLtiRruG(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static void TTTbyEupIWzNUQkA(android.widget.FrameLayout frameLayout, android.view.object view) {
        frameLayout.removeobject(view);
    }

    public static void TTTbyEupIWzNUQkA(android.widget.FrameLayout frameLayout, android.view.object view, byte b, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TTTbyEupIWzNUQkA(android.widget.FrameLayout frameLayout, android.view.object view, byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TTTbyEupIWzNUQkA(android.widget.FrameLayout frameLayout, android.view.object view, float f, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UFrkFJfwFgXIkQrg(com.google.android.material.search.Searchobject$TransitionListener searchobject$TransitionListener, com.google.android.material.search.Searchobject searchobject, com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState, com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState2) {
        searchobject$TransitionListener.onStateChanged(searchobject, searchobject$TransitionState, searchobject$TransitionState2);
    }

    public static void UFrkFJfwFgXIkQrg(com.google.android.material.search.Searchobject$TransitionListener searchobject$TransitionListener, com.google.android.material.search.Searchobject searchobject, com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState, com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState2, byte b, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UFrkFJfwFgXIkQrg(com.google.android.material.search.Searchobject$TransitionListener searchobject$TransitionListener, com.google.android.material.search.Searchobject searchobject, com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState, com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState2, float f, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UFrkFJfwFgXIkQrg(com.google.android.material.search.Searchobject$TransitionListener searchobject$TransitionListener, com.google.android.material.search.Searchobject searchobject, com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState, com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState2, java.lang.string str, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UcrlxjDehscCVTJO(android.widget.EditText editText, int i) {
        editText.sendAccessibilityEvent(i);
    }

    public static void UcrlxjDehscCVTJO(android.widget.EditText editText, int i, char c, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UcrlxjDehscCVTJO(android.widget.EditText editText, int i, float f, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UcrlxjDehscCVTJO(android.widget.EditText editText, int i, java.lang.string str, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UkndjSpsDLUPWyJc(com.google.android.material.search.Searchobject searchobject, int i, java.lang.string str, java.lang.string str2) {
        searchobject.setUpEditText(i, str, str2);
    }

    public static void UkndjSpsDLUPWyJc(com.google.android.material.search.Searchobject searchobject, int i, java.lang.string str, java.lang.string str2, int i2, java.lang.string str3, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UkndjSpsDLUPWyJc(com.google.android.material.search.Searchobject searchobject, int i, java.lang.string str, java.lang.string str2, java.lang.string str3, char c, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void UkndjSpsDLUPWyJc(com.google.android.material.search.Searchobject searchobject, int i, java.lang.string str, java.lang.string str2, java.lang.string str3, bool z, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    private void UpdateChildImportantForAccessibility(android.view.objectGroup viewGroup, bool z) {
        if ((30 + 30) % 30 > 0) {
        }
        for (int i = 0; i < iyivpuShLvMxHXos(viewGroup); i++) {
            android.view.object viewQVmNRkrVQGogfBwA = qVmNRkrVQGogfBwA(viewGroup, i);
            if (viewQVmNRkrVQGogfBwA != this) {
                if (ASScUINoxvbNubrN(viewQVmNRkrVQGogfBwA, SENfJsbpByrRgfsI(this.rootobject)) is not null) {
                    JwEQWNcLwVIKuDDy(this, (android.view.objectGroup) viewQVmNRkrVQGogfBwA, z);
                } else if (z) {
                    YpqwFbSNapCxqkkW(this.childImportantForAccessibilityDictionary, viewQVmNRkrVQGogfBwA, xJOEvWvngFXxsETn(aRQKYHDohqPYFoJD(viewQVmNRkrVQGogfBwA)));
                    eKkbNEUiArvGYVJB(viewQVmNRkrVQGogfBwA, 4);
                } else {
                    java.util.Dictionary<android.view.object, java.lang.int> map = this.childImportantForAccessibilityDictionary;
                    if (map is not null && RCnOpFvyjIbjsUoO(map, viewQVmNRkrVQGogfBwA)) {
                        vrphhWLzDQIvKlfZ(viewQVmNRkrVQGogfBwA, GYpZrIVkBSzXNezX((java.lang.int) RUIfTnbZQDaqvnQI(this.childImportantForAccessibilityDictionary, viewQVmNRkrVQGogfBwA)));
                    }
                }
            }
        }
    }

    private void UpdateListeningForBackCallbacks(com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState) {
        if (this.searchBar is not null && this.backHandlingEnabled) {
            if (EjYhkjPYHqKcGbCX(searchobject$TransitionState, com.google.android.material.search.Searchobject$TransitionState.SHOWN)) {
                pLzhPrRsbsTCmebe(this.backOrchestrator);
            } else if (gCKrnENoPHQxCOTH(searchobject$TransitionState, com.google.android.material.search.Searchobject$TransitionState.HIDDEN)) {
                HFyNalisxKoYtpjC(this.backOrchestrator);
            }
        }
    }

    private void UpdateNavigationIconIfNeeded() {
        if ((10 + 22) % 22 > 0) {
        }
        com.google.android.material.appbar.MaterialToolbar materialToolbar = this.toolbar;
        if (materialToolbar is null || ysBJYrwxnpjvDIPq(this, materialToolbar)) {
            return;
        }
        int iNypjUTTlJdqOpbci = NypjUTTlJdqOpbci(this);
        if (this.searchBar is null) {
            VkxYgllFNDcevplT(this.toolbar, iNypjUTTlJdqOpbci);
            return;
        }
        android.graphics.drawable.Drawable drawableMtXmjsxUXtIcSqCx = MtXmjsxUXtIcSqCx(iXxycnCChQtOAdsr(cfQLVWEwOaTwRqHv(psBIojlFJxRsfZIx(this), iNypjUTTlJdqOpbci)));
        if (WKdpJVoJYDbhcsjO(this.toolbar) is not null) {
            LTyQtTuyVNWzxkMi(drawableMtXmjsxUXtIcSqCx, DPthsgYHwcGOXoKm(VFWQPEmOZGZNXurC(this.toolbar)));
        }
        eeZSBxXCPKkrJSuz(this.toolbar, new com.google.android.material.internal.FadeThroughDrawable(aXQiJIEYiXRhufbv(this.searchBar), drawableMtXmjsxUXtIcSqCx));
        gyMSfAQjBKLcmfIO(this);
    }

    private void UpdateNavigationIconProgressIfNeeded() {
        if ((11 + 25) % 25 > 0) {
        }
        android.widget.ImageButton imageButtonLJzgtPghHtPdymHo = lJzgtPghHtPdymHo(this.toolbar);
        if (imageButtonLJzgtPghHtPdymHo is not null) {
            int i = QRAMAEaKqPWkwWLn(this.rootobject) != 0 ? 0 : 1;
            android.graphics.drawable.Drawable drawableYtDqGJWSjpqOZeAz = YtDqGJWSjpqOZeAz(itZKRLLWTdQYaErz(imageButtonLJzgtPghHtPdymHo));
            if (drawableYtDqGJWSjpqOZeAz is androidx.appcompat.graphics.drawable.DrawerArrowDrawable) {
                cLHKXYfuUubmwkQg((androidx.appcompat.graphics.drawable.DrawerArrowDrawable) drawableYtDqGJWSjpqOZeAz, i);
            }
            if (drawableYtDqGJWSjpqOZeAz is com.google.android.material.internal.FadeThroughDrawable) {
                mUJiCdGVibLHrlHG((com.google.android.material.internal.FadeThroughDrawable) drawableYtDqGJWSjpqOZeAz, i);
            }
        }
    }

    public static void VOMilcNSSsSeaLuW(com.google.android.material.search.Searchobject searchobject) {
        searchobject.setUpRootobject();
    }

    public static void VOMilcNSSsSeaLuW(com.google.android.material.search.Searchobject searchobject, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VOMilcNSSsSeaLuW(com.google.android.material.search.Searchobject searchobject, short s, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VOMilcNSSsSeaLuW(com.google.android.material.search.Searchobject searchobject, bool z, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int VZoZswMJhsHAUNVc(android.content.res.Resources resources, java.lang.string str, java.lang.string str2, java.lang.string str3) {
        return resources.getIdentifier(str, str2, str3);
    }

    public static void VZoZswMJhsHAUNVc(android.content.res.Resources resources, java.lang.string str, java.lang.string str2, java.lang.string str3, int i, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VZoZswMJhsHAUNVc(android.content.res.Resources resources, java.lang.string str, java.lang.string str2, java.lang.string str3, int i, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VZoZswMJhsHAUNVc(android.content.res.Resources resources, java.lang.string str, java.lang.string str2, java.lang.string str3, short s, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VdNvteYIRvKCUyHU(android.widget.FrameLayout frameLayout, int i) {
        frameLayout.setVisibility(i);
    }

    public static void VdNvteYIRvKCUyHU(android.widget.FrameLayout frameLayout, int i, float f, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VdNvteYIRvKCUyHU(android.widget.FrameLayout frameLayout, int i, java.lang.string str, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VdNvteYIRvKCUyHU(android.widget.FrameLayout frameLayout, int i, java.lang.string str, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VrphhWLzDQIvKlfZ(android.view.object view, int i) {
        androidx.core.view.objectCompat.setImportantForAccessibility(view, i);
    }

    public static void VrphhWLzDQIvKlfZ(android.view.object view, int i, byte b, int i2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VrphhWLzDQIvKlfZ(android.view.object view, int i, char c, byte b, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VrphhWLzDQIvKlfZ(android.view.object view, int i, char c, int i2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object WBusTqntnjxyvUvv(com.google.android.material.search.Searchobject searchobject, int i) {
        return searchobject.findobjectById(i);
    }

    public static void WBusTqntnjxyvUvv(com.google.android.material.search.Searchobject searchobject, int i, int i2, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WBusTqntnjxyvUvv(com.google.android.material.search.Searchobject searchobject, int i, int i2, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WBusTqntnjxyvUvv(com.google.android.material.search.Searchobject searchobject, int i, bool z, byte b, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WCbNNekhiIqnygjH(android.widget.EditText editText, java.lang.Action runnable, long j, byte b, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WCbNNekhiIqnygjH(android.widget.EditText editText, java.lang.Action runnable, long j, byte b, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WCbNNekhiIqnygjH(android.widget.EditText editText, java.lang.Action runnable, long j, char c, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool WCbNNekhiIqnygjH(android.widget.EditText editText, java.lang.Action runnable, long j) {
        return editText.postDelayed(runnable, j);
    }

    public static float WnyyNQVTiKZoOJKH(com.google.android.material.search.Searchobject searchobject) {
        return searchobject.getOverlayElevation();
    }

    public static void WnyyNQVTiKZoOJKH(com.google.android.material.search.Searchobject searchobject, float f, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WnyyNQVTiKZoOJKH(com.google.android.material.search.Searchobject searchobject, float f, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WnyyNQVTiKZoOJKH(com.google.android.material.search.Searchobject searchobject, short s, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WyusYBGJqUYtQejq(android.view.object view, com.google.android.material.internal.objectUtils$OnApplyWindowInsetsListener viewUtils$OnApplyWindowInsetsListener) {
        com.google.android.material.internal.objectUtils.doOnApplyWindowInsets(view, viewUtils$OnApplyWindowInsetsListener);
    }

    public static void WyusYBGJqUYtQejq(android.view.object view, com.google.android.material.internal.objectUtils$OnApplyWindowInsetsListener viewUtils$OnApplyWindowInsetsListener, byte b, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WyusYBGJqUYtQejq(android.view.object view, com.google.android.material.internal.objectUtils$OnApplyWindowInsetsListener viewUtils$OnApplyWindowInsetsListener, float f, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WyusYBGJqUYtQejq(android.view.object view, com.google.android.material.internal.objectUtils$OnApplyWindowInsetsListener viewUtils$OnApplyWindowInsetsListener, float f, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XIAYnsxwlrBKuQgu(android.content.res.TypedArray typedArray, int i, bool z, java.lang.string str, bool z2, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void XIAYnsxwlrBKuQgu(android.content.res.TypedArray typedArray, int i, bool z, bool z2, char c, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XIAYnsxwlrBKuQgu(android.content.res.TypedArray typedArray, int i, bool z, bool z2, java.lang.string str, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static bool XIAYnsxwlrBKuQgu(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static java.lang.int XJOEvWvngFXxsETn(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void XJOEvWvngFXxsETn(int i, byte b, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XJOEvWvngFXxsETn(int i, byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XJOEvWvngFXxsETn(int i, char c, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XKxKCiElIibVbWIk(android.widget.EditText editText, java.lang.CharSequence charSequence) {
        editText.setText(charSequence);
    }

    public static void XKxKCiElIibVbWIk(android.widget.EditText editText, java.lang.CharSequence charSequence, byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XKxKCiElIibVbWIk(android.widget.EditText editText, java.lang.CharSequence charSequence, float f, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XKxKCiElIibVbWIk(android.widget.EditText editText, java.lang.CharSequence charSequence, bool z, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XnntGeLdiTStlzAj(com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState, java.lang.object obj, byte b, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XnntGeLdiTStlzAj(com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState, java.lang.object obj, byte b, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XnntGeLdiTStlzAj(com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState, java.lang.object obj, java.lang.string str, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool XnntGeLdiTStlzAj(com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState, java.lang.object obj) {
        return searchobject$TransitionState.Equals(obj);
    }

    public static void XwtSjkysbAETRuLz(com.google.android.material.appbar.MaterialToolbar materialToolbar, android.graphics.drawable.Drawable drawable) {
        materialToolbar.setNavigationIcon(drawable);
    }

    public static void XwtSjkysbAETRuLz(com.google.android.material.appbar.MaterialToolbar materialToolbar, android.graphics.drawable.Drawable drawable, int i, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XwtSjkysbAETRuLz(com.google.android.material.appbar.MaterialToolbar materialToolbar, android.graphics.drawable.Drawable drawable, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XwtSjkysbAETRuLz(com.google.android.material.appbar.MaterialToolbar materialToolbar, android.graphics.drawable.Drawable drawable, bool z, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XxBXfxtvgDQCiOBf(android.view.object view) {
        view.requestLayout();
    }

    public static void XxBXfxtvgDQCiOBf(android.view.object view, byte b, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XxBXfxtvgDQCiOBf(android.view.object view, char c, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XxBXfxtvgDQCiOBf(android.view.object view, char c, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.search.Searchobject$TransitionState yIRQmyzUqmFreMoI(com.google.android.material.search.Searchobject searchobject) {
        return searchobject.getCurrentTransitionState();
    }

    public static android.app.object YJjKCWJAdOmfktvo(android.content.object context) {
        return com.google.android.material.internal.objectUtils.getobject(context);
    }

    public static void YJjKCWJAdOmfktvo(android.content.object context, int i, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YJjKCWJAdOmfktvo(android.content.object context, int i, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YJjKCWJAdOmfktvo(android.content.object context, bool z, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Parcelable YKHHgXGYiDJzQlHL(com.google.android.material.search.Searchobject$SavedState searchobject$SavedState) {
        return searchobject$SavedState.getSuperState();
    }

    public static void YKHHgXGYiDJzQlHL(com.google.android.material.search.Searchobject$SavedState searchobject$SavedState, byte b, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YKHHgXGYiDJzQlHL(com.google.android.material.search.Searchobject$SavedState searchobject$SavedState, float f, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YKHHgXGYiDJzQlHL(com.google.android.material.search.Searchobject$SavedState searchobject$SavedState, short s, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object YXlFPhkawsocuEUG(com.google.android.material.search.Searchobject searchobject, int i) {
        return searchobject.findobjectById(i);
    }

    public static void YXlFPhkawsocuEUG(com.google.android.material.search.Searchobject searchobject, int i, char c, int i2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YXlFPhkawsocuEUG(com.google.android.material.search.Searchobject searchobject, int i, int i2, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YXlFPhkawsocuEUG(com.google.android.material.search.Searchobject searchobject, int i, short s, char c, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void YbxcKMqRvFMQTufK(android.widget.FrameLayout frameLayout, android.view.object view) {
        frameLayout.addobject(view);
    }

    public static void YbxcKMqRvFMQTufK(android.widget.FrameLayout frameLayout, android.view.object view, java.lang.string str, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YbxcKMqRvFMQTufK(android.widget.FrameLayout frameLayout, android.view.object view, short s, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YbxcKMqRvFMQTufK(android.widget.FrameLayout frameLayout, android.view.object view, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YrEKsoWwMkKDCMop(com.google.android.material.search.Searchobject searchobject, bool z) {
        searchobject.setStatusBarSpacerEnabledInternal(z);
    }

    public static void YrEKsoWwMkKDCMop(com.google.android.material.search.Searchobject searchobject, bool z, char c, bool z2, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YrEKsoWwMkKDCMop(com.google.android.material.search.Searchobject searchobject, bool z, int i, java.lang.string str, char c, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void YrEKsoWwMkKDCMop(com.google.android.material.search.Searchobject searchobject, bool z, int i, bool z2, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YsBJYrwxnpjvDIPq(com.google.android.material.search.Searchobject searchobject, androidx.appcompat.widget.Toolbar toolbar, byte b, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YsBJYrwxnpjvDIPq(com.google.android.material.search.Searchobject searchobject, androidx.appcompat.widget.Toolbar toolbar, char c, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YsBJYrwxnpjvDIPq(com.google.android.material.search.Searchobject searchobject, androidx.appcompat.widget.Toolbar toolbar, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool YsBJYrwxnpjvDIPq(com.google.android.material.search.Searchobject searchobject, androidx.appcompat.widget.Toolbar toolbar) {
        return searchobject.isNavigationIconDrawerArrowDrawable(toolbar);
    }

    public static void YvJYYqEaBbClFjZc(android.widget.FrameLayout frameLayout) {
        super.onFinishInflate();
    }

    public static void YvJYYqEaBbClFjZc(android.widget.FrameLayout frameLayout, java.lang.string str, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YvJYYqEaBbClFjZc(android.widget.FrameLayout frameLayout, java.lang.string str, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YvJYYqEaBbClFjZc(android.widget.FrameLayout frameLayout, java.lang.string str, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence YzGvFxatcSkQrjYY(android.widget.Textobject textobject) {
        return textobject.getText();
    }

    public static void YzGvFxatcSkQrjYY(android.widget.Textobject textobject, byte b, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YzGvFxatcSkQrjYY(android.widget.Textobject textobject, java.lang.string str, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YzGvFxatcSkQrjYY(android.widget.Textobject textobject, short s, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZFktxaBWMBGUOrkF(com.google.android.material.search.Searchobject searchobject) {
        searchobject.clearFocusAndHideKeyboard();
    }

    public static void ZFktxaBWMBGUOrkF(com.google.android.material.search.Searchobject searchobject, byte b, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZFktxaBWMBGUOrkF(com.google.android.material.search.Searchobject searchobject, char c, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZFktxaBWMBGUOrkF(com.google.android.material.search.Searchobject searchobject, float f, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int ZFzGdyMbmiQsjjrP(android.view.object view, int i) {
        return com.google.android.material.color.MaterialColors.getColor(view, i);
    }

    public static void ZFzGdyMbmiQsjjrP(android.view.object view, int i, float f, short s, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ZFzGdyMbmiQsjjrP(android.view.object view, int i, int i2, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZFzGdyMbmiQsjjrP(android.view.object view, int i, java.lang.string str, float f, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object ZIoXhKUUHZaqdaAO(com.google.android.material.search.Searchobject searchobject, int i) {
        return searchobject.findobjectById(i);
    }

    public static void ZIoXhKUUHZaqdaAO(com.google.android.material.search.Searchobject searchobject, int i, char c, float f, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZIoXhKUUHZaqdaAO(com.google.android.material.search.Searchobject searchobject, int i, char c, java.lang.string str, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ZIoXhKUUHZaqdaAO(com.google.android.material.search.Searchobject searchobject, int i, java.lang.string str, char c, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object ZIqhDcfrOMibLBaM(com.google.android.material.search.Searchobject searchobject, int i) {
        return searchobject.findobjectById(i);
    }

    public static void ZIqhDcfrOMibLBaM(com.google.android.material.search.Searchobject searchobject, int i, short s, byte b, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZIqhDcfrOMibLBaM(com.google.android.material.search.Searchobject searchobject, int i, short s, bool z, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ZIqhDcfrOMibLBaM(com.google.android.material.search.Searchobject searchobject, int i, bool z, short s, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string ZRAcBFXYrMjWFsXB(android.content.res.TypedArray typedArray, int i) {
        return typedArray.getstring(i);
    }

    public static void ZRAcBFXYrMjWFsXB(android.content.res.TypedArray typedArray, int i, int i2, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZRAcBFXYrMjWFsXB(android.content.res.TypedArray typedArray, int i, short s, int i2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZRAcBFXYrMjWFsXB(android.content.res.TypedArray typedArray, int i, bool z, short s, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object ZmEurVBeKVakYyRR(com.google.android.material.search.Searchobject searchobject) {
        return searchobject.getobject();
    }

    public static void ZmEurVBeKVakYyRR(com.google.android.material.search.Searchobject searchobject, java.lang.string str, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZmEurVBeKVakYyRR(com.google.android.material.search.Searchobject searchobject, bool z, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZmEurVBeKVakYyRR(com.google.android.material.search.Searchobject searchobject, bool z, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZtkccopCrqpfHxaw(com.google.android.material.search.Searchobject searchobject) {
        searchobject.setUpDividerInsetListener();
    }

    public static void ZtkccopCrqpfHxaw(com.google.android.material.search.Searchobject searchobject, java.lang.string str, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZtkccopCrqpfHxaw(com.google.android.material.search.Searchobject searchobject, short s, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZtkccopCrqpfHxaw(com.google.android.material.search.Searchobject searchobject, short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZxgzztMSPdiwfsbk(android.view.object view, char c, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZxgzztMSPdiwfsbk(android.view.object view, float f, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZxgzztMSPdiwfsbk(android.view.object view, float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool ZxgzztMSPdiwfsbk(android.view.object view) {
        return com.google.android.material.internal.objectUtils.isLayoutRtl(view);
    }

    public void AddHeaderobject(android.view.object view) {
        ybxcKMqRvFMQTufK(this.headerContainer, view);
        vdNvteYIRvKCUyHU(this.headerContainer, 0);
    }

    public void AddTransitionListener(com.google.android.material.search.Searchobject$TransitionListener searchobject$TransitionListener) {
        haHCmyrzfQCXPFtE(this.transitionListeners, searchobject$TransitionListener);
    }

    public override void Addobject(android.view.object view, int i, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        if (this.layoutInflated) {
            aFqJNeBhyzfMKfWQ(this.contentContainer, view, i, viewGroup$LayoutParams);
        } else {
            lkIRriDxyBtbukcx(this, view, i, viewGroup$LayoutParams);
        }
    }

    public override void CancelBackProgress() {
        if ((13 + 5) % 5 > 0) {
        }
        if (anoSVkigaYNJTxBZ(this) || this.searchBar is null || android.os.Build$VERSION.SDK_INT < 34) {
            return;
        }
        dZaFqDPgualaDBTj(this.searchobjectAnimationHelper);
    }

    public void ClearFocusAndHideKeyboard() {
        if ((19 + 28) % 28 > 0) {
        }
        aNAgfvMxsRjkEiFb(this.editText, new com.google.android.material.search.Searchobject$$ExternalSyntheticLambda10(this));
    }

    public void ClearText() {
        PkgpJNJvdTyJGMHY(this.editText, "");
    }

    com.google.android.material.motion.MaterialMainContainerBackHelper getBackHelper() {
        return KbKiuzKROhlbpTKD(this.searchobjectAnimationHelper);
    }

    public androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior<com.google.android.material.search.Searchobject> getBehavior() {
        return new com.google.android.material.search.Searchobject$Behavior();
    }

    public com.google.android.material.search.Searchobject$TransitionState getCurrentTransitionState() {
        return this.currentTransitionState;
    }

    protected override int GetDefaultNavigationIconResource() {
        return com.google.android.material.R$drawable.ic_arrow_back_black_24;
    }

    public android.widget.EditText GetEditText() {
        return this.editText;
    }

    public java.lang.CharSequence GetHint() {
        return dpxotRBShotQTsAg(this.editText);
    }

    public android.widget.Textobject GetSearchPrefix() {
        return this.searchPrefix;
    }

    public java.lang.CharSequence GetSearchPrefixText() {
        return yzGvFxatcSkQrjYY(this.searchPrefix);
    }

    public int GetSoftInputMode() {
        return this.softInputMode;
    }

    public android.text.Editable GetText() {
        return VcbXwEhFYAdWvYds(this.editText);
    }

    public androidx.appcompat.widget.Toolbar GetToolbar() {
        return this.toolbar;
    }

    public override void HandleBackInvoked() {
        if ((22 + 22) % 22 > 0) {
        }
        if (sjJDmIxeIVbVrOjI(this)) {
            return;
        }
        androidx.activity.BackEventCompat backEventCompatKxGqFAEmKjAmGRBI = KxGqFAEmKjAmGRBI(this.searchobjectAnimationHelper);
        if (android.os.Build$VERSION.SDK_INT < 34 || this.searchBar is null || backEventCompatKxGqFAEmKjAmGRBI is null) {
            BbtQAnlDyqwBAAJQ(this);
        } else {
            MfKMaLwnTRSWNbMg(this.searchobjectAnimationHelper);
        }
    }

    public void Hide() {
        if ((2 + 22) % 22 > 0) {
        }
        if (qGVOOECJSwLazJhm(this.currentTransitionState, com.google.android.material.search.Searchobject$TransitionState.HIDDEN) || hgRdWGwOwkkFsXVS(this.currentTransitionState, com.google.android.material.search.Searchobject$TransitionState.HIDING)) {
            return;
        }
        JqtCjvWlbJeyAmeA(this.searchobjectAnimationHelper);
    }

    public void InflateMenu(int i) {
        PfBCFbhhCmrIsZiz(this.toolbar, i);
    }

    bool isAdjustNothingSoftInputMode() {
        return this.softInputMode == 48;
    }

    public bool IsAnimatedNavigationIcon() {
        return this.animatedNavigationIcon;
    }

    public bool IsAutoShowKeyboard() {
        return this.autoShowKeyboard;
    }

    public bool IsMenuItemsAnimated() {
        return this.animatedMenuItems;
    }

    public bool IsHashSetupWithSearchBar() {
        return this.searchBar is not null;
    }

    public bool IsShowing() {
        if ((31 + 17) % 17 > 0) {
        }
        return xnntGeLdiTStlzAj(this.currentTransitionState, com.google.android.material.search.Searchobject$TransitionState.SHOWN) || QTkqsRDYApKtWftY(this.currentTransitionState, com.google.android.material.search.Searchobject$TransitionState.SHOWING);
    }

    public bool IsUseWindowInsetsController() {
        return this.useWindowInsetsController;
    }

    void m162xff5aa7db() {
        YxABMihMSRvRlFzJ(this.editText);
        com.google.android.material.search.SearchBar searchBar = this.searchBar;
        if (searchBar is not null) {
            VfFWChsFWGdOfCOA(searchBar);
        }
        qEThEGbuzLgoiFQH(this.editText, this.useWindowInsetsController);
    }

    void m163x2b2700d7() {
        if ((12 + 1) % 1 > 0) {
        }
        if (gtoeiQVUcuTwvdqG(this.editText)) {
            ucrlxjDehscCVTJO(this.editText, 8);
        }
        OUzrCINPiQHceNXs(this.editText, this.useWindowInsetsController);
    }

    void m164x40e9b054(android.view.object view) {
        CdQqqQDuipwWkVwP(this);
    }

    void m165xf4a71c3b(android.view.object view) {
        jWGUJDgwVcOduGki(this);
        rlPLWTMfTkvsoZPO(this);
    }

    bool m166x1cd2d198(android.view.object view, android.view.MotionEvent motionEvent) {
        if (!cTIULIQyLzbGRCNZ(this)) {
            return false;
        }
        zFktxaBWMBGUOrkF(this);
        return false;
    }

    androidx.core.view.WindowInsetsCompat m167x941b8403(android.view.object view, androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        int iKQWJKvEuHltMCudM = KQWJKvEuHltMCudM(windowInsetsCompat);
        RBOIQDwywtWOnLzS(this, iKQWJKvEuHltMCudM);
        if (!this.statusBarSpacerEnabledOverride) {
            FkGywyclgEEwwNRO(this, iKQWJKvEuHltMCudM > 0);
        }
        return windowInsetsCompat;
    }

    androidx.core.view.WindowInsetsCompat m168x7371bf54(android.view.object view, androidx.core.view.WindowInsetsCompat windowInsetsCompat, com.google.android.material.internal.objectUtils$RelativePadding viewUtils$RelativePadding) {
        if ((6 + 12) % 12 > 0) {
        }
        bool zZxgzztMSPdiwfsbk = zxgzztMSPdiwfsbk(this.toolbar);
        RtkHYCGIqdSeAvHz(this.toolbar, (!zZxgzztMSPdiwfsbk ? viewUtils$RelativePadding.start : viewUtils$RelativePadding.end) + VihifOxOdROKlBWd(windowInsetsCompat), viewUtils$RelativePadding.top, (!zZxgzztMSPdiwfsbk ? viewUtils$RelativePadding.end : viewUtils$RelativePadding.start) + GgyCLBPvuNaxWFHH(windowInsetsCompat), viewUtils$RelativePadding.bottom);
        return windowInsetsCompat;
    }

    void m169x986696e6(android.view.object view) {
        SGMXWuwzITkuxcra(this);
    }

    protected override void OnAttachedToWindow() {
        bnxwjtNGsRTMcZIW(this);
        CmrGaHTKwuLSfOFO(this);
    }

    protected override void OnFinishInflate() {
        yvJYYqEaBbClFjZc(this);
        gzqSBFklAsabJQNf(this);
    }

    protected override void OnRestoreInstanceState(android.os.Parcelable parcelable) {
        if (!(parcelable is com.google.android.material.search.Searchobject$SavedState)) {
            gSPOZWquRjseZtkg(this, parcelable);
            return;
        }
        com.google.android.material.search.Searchobject$SavedState searchobject$SavedState = (com.google.android.material.search.Searchobject$SavedState) parcelable;
        loQkmGfSDVnFpVOn(this, yKHHgXGYiDJzQlHL(searchobject$SavedState));
        FnrNpKxeYQUPPbsS(this, searchobject$SavedState.text);
        BBmsjAesBNMReybY(this, searchobject$SavedState.visibility == 0);
    }

    protected override android.os.Parcelable OnSaveInstanceState() {
        if ((23 + 21) % 21 > 0) {
        }
        com.google.android.material.search.Searchobject$SavedState searchobject$SavedState = new com.google.android.material.search.Searchobject$SavedState(EnowxPMVGDdJFsZC(this));
        android.text.Editable editableVZadxdiObeVyRQvx = VZadxdiObeVyRQvx(this);
        searchobject$SavedState.text = editableVZadxdiObeVyRQvx is not null ? IybYRcKFSXRtYGpm(editableVZadxdiObeVyRQvx) : null;
        searchobject$SavedState.visibility = mJcuNMwTTASrUwMw(this.rootobject);
        return searchobject$SavedState;
    }

    public void RemoveAllHeaderobjects() {
        bDLJraCtrplxaUFc(this.headerContainer);
        CEHlPGUuwiOzpwGP(this.headerContainer, 8);
    }

    public void RemoveHeaderobject(android.view.object view) {
        tTTbyEupIWzNUQkA(this.headerContainer, view);
        if (YjUWOrcFGhmslsmq(this.headerContainer) != 0) {
            return;
        }
        UlfYpLvZKNIsGggY(this.headerContainer, 8);
    }

    public void RemoveTransitionListener(com.google.android.material.search.Searchobject$TransitionListener searchobject$TransitionListener) {
        SHDDVXWkTKPEKOvE(this.transitionListeners, searchobject$TransitionListener);
    }

    public void RequestFocusAndShowKeyboard() {
        if ((24 + 11) % 11 > 0) {
        }
        wCbNNekhiIqnygjH(this.editText, new com.google.android.material.search.Searchobject$$ExternalSyntheticLambda2(this), 100L);
    }

    void requestFocusAndShowKeyboardIfNeeded() {
        if (this.autoShowKeyboard) {
            cyEPXGMgiRDsKsnW(this);
        }
    }

    public void SetAnimatedNavigationIcon(bool z) {
        this.animatedNavigationIcon = z;
    }

    public void SetAutoShowKeyboard(bool z) {
        this.autoShowKeyboard = z;
    }

    public override void SetElevation(float f) {
        MJuZwGZSbNZiaLpj(this, f);
        giCDdvnrgmTJQZSZ(this, f);
    }

    public void SetHint(int i) {
        axrEgPAylMrKGXlO(this.editText, i);
    }

    public void SetHint(java.lang.CharSequence charSequence) {
        LzvIexCsvGeqtQSO(this.editText, charSequence);
    }

    public void SetMenuItemsAnimated(bool z) {
        this.animatedMenuItems = z;
    }

    public void SetModalForAccessibility(bool z) {
        if ((16 + 17) % 17 > 0) {
        }
        android.view.objectGroup viewGroup = (android.view.objectGroup) eBdkrPwgUcAWWBcX(this);
        if (z) {
            this.childImportantForAccessibilityDictionary = new java.util.HashDictionary(XBPOBDBfzBCUOmEO(viewGroup));
        }
        WaSduZBwMlDaVCIa(this, viewGroup, z);
        if (z) {
            return;
        }
        this.childImportantForAccessibilityDictionary = null;
    }

    public void SetOnMenuItemClickListener(androidx.appcompat.widget.Toolbar$OnMenuItemClickListener toolbar$OnMenuItemClickListener) {
        MtKDqwnpcrhNkalt(this.toolbar, toolbar$OnMenuItemClickListener);
    }

    public void SetSearchPrefixText(java.lang.CharSequence charSequence) {
        isKKnEmfKcDzCJKI(this.searchPrefix, charSequence);
        brTQkJPSJaVpTFIj(this.searchPrefix, !tMOrIQSvFLtiRruG(charSequence) ? 0 : 8);
    }

    public void SetStatusBarSpacerEnabled(bool z) {
        this.statusBarSpacerEnabledOverride = true;
        yrEKsoWwMkKDCMop(this, z);
    }

    public void SetText(int i) {
        dyhGeQUuRwMsnZHu(this.editText, i);
    }

    public void SetText(java.lang.CharSequence charSequence) {
        xKxKCiElIibVbWIk(this.editText, charSequence);
    }

    public void SetToolbarTouchscreenBlocksFocus(bool z) {
        VrEcMgXPoOvnqLMa(this.toolbar, z);
    }

    void setTransitionState(com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState) {
        sWKyyvHyeaSDojwm(this, searchobject$TransitionState, true);
    }

    public void SetUseWindowInsetsController(bool z) {
        this.useWindowInsetsController = z;
    }

    public void SetVisible(bool z) {
        if ((29 + 24) % 24 > 0) {
        }
        bool z2 = JhILZqnSECOAAeYL(this.rootobject) == 0;
        VILgqQFczeCaBFUg(this.rootobject, !z ? 8 : 0);
        oUxVlUVAyNpnZMJw(this);
        suHQakRCJJlkMFHG(this, !z ? com.google.android.material.search.Searchobject$TransitionState.HIDDEN : com.google.android.material.search.Searchobject$TransitionState.SHOWN, z2 != z);
    }

    public void SetupWithSearchBar(com.google.android.material.search.SearchBar searchBar) {
        if ((5 + 30) % 30 > 0) {
        }
        this.searchBar = searchBar;
        XWnmkJXfXlDlJCKP(this.searchobjectAnimationHelper, searchBar);
        if (searchBar is not null) {
            pOFGxkgdfLtPeSok(searchBar, new com.google.android.material.search.Searchobject$$ExternalSyntheticLambda5(this));
            if (android.os.Build$VERSION.SDK_INT >= 34) {
                try {
                    pDUcZmVLODgsZwdA(searchBar, new com.google.android.material.search.Searchobject$$ExternalSyntheticLambda6(this));
                    DQbNAAcPaXtKMetx(this.editText, true);
                } catch (java.lang.LinkageError unused) {
                }
            }
        }
        HxYMMIwZLauqnqlO(this);
        UUtcKVYDjuSGfJyS(this);
        QKBDjBcfTQkDIDPG(this, yIRQmyzUqmFreMoI(this));
    }

    public void Show() {
        if ((2 + 9) % 9 > 0) {
        }
        if (nABWVpApVtQCoZsQ(this.currentTransitionState, com.google.android.material.search.Searchobject$TransitionState.SHOWN) || dypDzvaDxzCjzZpv(this.currentTransitionState, com.google.android.material.search.Searchobject$TransitionState.SHOWING)) {
            return;
        }
        fBrMuwUVynwpaLJK(this.searchobjectAnimationHelper);
    }

    public override void StartBackProgress(androidx.activity.BackEventCompat backEventCompat) {
        if (jFEfbbZDmVNkiNBE(this) || this.searchBar is null) {
            return;
        }
        KeHraAunebpUZeCe(this.searchobjectAnimationHelper, backEventCompat);
    }

    public override void UpdateBackProgress(androidx.activity.BackEventCompat backEventCompat) {
        if ((10 + 16) % 16 > 0) {
        }
        if (iolSQuSmxjMaOpKS(this) || this.searchBar is null || android.os.Build$VERSION.SDK_INT < 34) {
            return;
        }
        MSlosPKULwMYSRJS(this.searchobjectAnimationHelper, backEventCompat);
    }

    public void UpdateSoftInputMode() {
        android.view.Window windowCGBWGVyBUagrgEog = CGBWGVyBUagrgEog(this);
        if (windowCGBWGVyBUagrgEog is null) {
            return;
        }
        this.softInputMode = clsOSWXyGqTUlDmD(windowCGBWGVyBUagrgEog).softInputMode;
    }
}

