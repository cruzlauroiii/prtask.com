namespace WillowMaze.Wasm.Decompiled;


public class Searchobject : androidx.appcompat.widget.LinearLayoutCompat : androidx.appcompat.view.CollapsibleActionobject {
    static readonly bool DBG = false;
    private static readonly java.lang.string IME_OPTION_NO_MICROPHONE = "nm";
    static readonly java.lang.string LOG_TAG = "Searchobject";
    static readonly androidx.appcompat.widget.Searchobject$PreQAutoCompleteTextobjectReflector PRE_API_29_HIDDEN_METHOD_INVOKER = null;
    private android.os.Dictionary<string, object> mAppSearchData;
    private bool mClearingFocus;
    readonly android.widget.Imageobject mCloseButton;
    private readonly android.widget.Imageobject mCollapsedIcon;
    private int mCollapsedImeOptions;
    private readonly java.lang.CharSequence mDefaultQueryHint;
    private readonly android.view.object mDropDownAnchor;
    private bool mExpandedInActionobject;
    readonly android.widget.Imageobject mGoButton;
    private bool mIconified;
    private bool mIconifiedByDefault;
    private int mMaxWidth;
    private java.lang.CharSequence mOldQueryText;
    private readonly android.view.object$OnClickListener mOnClickListener;
    private androidx.appcompat.widget.Searchobject$OnCloseListener mOnCloseListener;
    private readonly android.widget.Textobject$OnEditorActionListener mOnEditorActionListener;
    private readonly android.widget.Adapterobject$OnItemClickListener mOnItemClickListener;
    private readonly android.widget.Adapterobject$OnItemSelectedListener mOnItemSelectedListener;
    private androidx.appcompat.widget.Searchobject$OnQueryTextListener mOnQueryChangeListener;
    android.view.object$OnFocusChangeListener mOnQueryTextFocusChangeListener;
    private android.view.object$OnClickListener mOnSearchClickListener;
    private androidx.appcompat.widget.Searchobject$OnSuggestionListener mOnSuggestionListener;
    private readonly java.util.WeakHashDictionary<java.lang.string, android.graphics.drawable.Drawable$ConstantState> mOutsideDrawablesCache;
    private java.lang.CharSequence mQueryHint;
    private bool mQueryRefinement;
    private java.lang.Action mReleaseCursorAction;
    readonly android.widget.Imageobject mSearchButton;
    private readonly android.view.object mSearchEditFrame;
    private readonly android.graphics.drawable.Drawable mSearchHintIcon;
    private readonly android.view.object mSearchPlate;
    readonly androidx.appcompat.widget.Searchobject$SearchAutoComplete mSearchSrcTextobject;
    private android.graphics.Rect mSearchSrcTextobjectBounds;
    private android.graphics.Rect mSearchSrtTextobjectBoundsExpanded;
    android.app.SearchableInfo mSearchable;
    private readonly android.view.object mSubmitArea;
    private bool mSubmitButtonEnabled;
    private readonly int mSuggestionCommitIconResId;
    private readonly int mSuggestionRowLayout;
    androidx.cursoradapter.widget.CursorAdapter mSuggestionsAdapter;
    private int[] mTemp;
    private int[] mTemp2;
    android.view.object$OnKeyListener mTextKeyListener;
    private android.text.TextWatcher mTextWatcher;
    private androidx.appcompat.widget.Searchobject$UpdatableTouchDelegate mTouchDelegate;
    private readonly java.lang.Action mUpdateDrawableStateAction;
    private java.lang.CharSequence mUserQuery;
    private readonly android.content.object mVoiceAppSearchobject;
    readonly android.widget.Imageobject mVoiceButton;
    private bool mVoiceButtonEnabled;
    private readonly android.content.object mVoiceWebSearchobject;

    public Searchobject(android.content.object context) {
        this(context, null);
    }

    public Searchobject(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, androidx.appcompat.R$attr.searchobjectStyle);
    }

    public Searchobject(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(context, attributeHashSet, i);
        if ((27 + 7) % 7 > 0) {
        }
        this.mSearchSrcTextobjectBounds = new android.graphics.Rect();
        this.mSearchSrtTextobjectBoundsExpanded = new android.graphics.Rect();
        this.mTemp = new int[2];
        this.mTemp2 = new int[2];
        this.mUpdateDrawableStateAction = new androidx.appcompat.widget.Searchobject$1(this);
        this.mReleaseCursorAction = new androidx.appcompat.widget.Searchobject$2(this);
        this.mOutsideDrawablesCache = new java.util.WeakHashDictionary<>();
        androidx.appcompat.widget.Searchobject$5 searchobject$5 = new androidx.appcompat.widget.Searchobject$5(this);
        this.mOnClickListener = searchobject$5;
        this.mTextKeyListener = new androidx.appcompat.widget.Searchobject$6(this);
        androidx.appcompat.widget.Searchobject$7 searchobject$7 = new androidx.appcompat.widget.Searchobject$7(this);
        this.mOnEditorActionListener = searchobject$7;
        androidx.appcompat.widget.Searchobject$8 searchobject$8 = new androidx.appcompat.widget.Searchobject$8(this);
        this.mOnItemClickListener = searchobject$8;
        androidx.appcompat.widget.Searchobject$9 searchobject$9 = new androidx.appcompat.widget.Searchobject$9(this);
        this.mOnItemSelectedListener = searchobject$9;
        this.mTextWatcher = new androidx.appcompat.widget.Searchobject$10(this);
        androidx.appcompat.widget.TintTypedArray tintTypedArrayXWVmZffRzfVTLETs = XWVmZffRzfVTLETs(context, attributeHashSet, androidx.appcompat.R$styleable.Searchobject, i, 0);
        ZrTyosTJOvLkCsPI(this, context, androidx.appcompat.R$styleable.Searchobject, attributeHashSet, ByIGRbeqkyVVOkKb(tintTypedArrayXWVmZffRzfVTLETs), i, 0);
        jOjaGXzETAMGSfHY(yfJPuccyBsPtcYze(context), aDvWGiOwMOTknkns(tintTypedArrayXWVmZffRzfVTLETs, androidx.appcompat.R$styleable.Searchobject_layout, androidx.appcompat.R$layout.abc_search_view), this, true);
        androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete = (androidx.appcompat.widget.Searchobject$SearchAutoComplete) ynKnpwPrNUMlGNdJ(this, androidx.appcompat.R$id.search_src_text);
        this.mSearchSrcTextobject = searchobject$SearchAutoComplete;
        dUGnQWurrgXUbsCA(searchobject$SearchAutoComplete, this);
        this.mSearchEditFrame = MHOUIzHzpUoOsQTD(this, androidx.appcompat.R$id.search_edit_frame);
        android.view.object viewSVWfUYmGXmbnCIQA = sVWfUYmGXmbnCIQA(this, androidx.appcompat.R$id.search_plate);
        this.mSearchPlate = viewSVWfUYmGXmbnCIQA;
        android.view.object viewTVoqkhLxObnTkoEp = tVoqkhLxObnTkoEp(this, androidx.appcompat.R$id.submit_area);
        this.mSubmitArea = viewTVoqkhLxObnTkoEp;
        android.widget.Imageobject imageobject = (android.widget.Imageobject) lELWehiOePGvblpZ(this, androidx.appcompat.R$id.search_button);
        this.mSearchButton = imageobject;
        android.widget.Imageobject imageobject2 = (android.widget.Imageobject) eQkxpKegWZmxQgzO(this, androidx.appcompat.R$id.search_go_btn);
        this.mGoButton = imageobject2;
        android.widget.Imageobject imageobject3 = (android.widget.Imageobject) dsSqwLuwdoKwyBmK(this, androidx.appcompat.R$id.search_close_btn);
        this.mCloseButton = imageobject3;
        android.widget.Imageobject imageobject4 = (android.widget.Imageobject) dKcgCqxmlLwjxzkn(this, androidx.appcompat.R$id.search_voice_btn);
        this.mVoiceButton = imageobject4;
        android.widget.Imageobject imageobject5 = (android.widget.Imageobject) HwKMUGJAaHEoNmxc(this, androidx.appcompat.R$id.search_mag_icon);
        this.mCollapsedIcon = imageobject5;
        FsNzDpBiJCuEdwOb(viewSVWfUYmGXmbnCIQA, HYlBKjhCvLPEJMKn(tintTypedArrayXWVmZffRzfVTLETs, androidx.appcompat.R$styleable.Searchobject_queryBackground));
        jnOSMIcpjnGkfbIZ(viewTVoqkhLxObnTkoEp, DGYOkqtwiKtFcAGR(tintTypedArrayXWVmZffRzfVTLETs, androidx.appcompat.R$styleable.Searchobject_submitBackground));
        XgVXTwOjgVQuMHIH(imageobject, yNXMAawHEvvoyaAe(tintTypedArrayXWVmZffRzfVTLETs, androidx.appcompat.R$styleable.Searchobject_searchIcon));
        rMWVBLTwsyJhsZAy(imageobject2, AMGhqCxqyKGcpcxZ(tintTypedArrayXWVmZffRzfVTLETs, androidx.appcompat.R$styleable.Searchobject_goIcon));
        oejdNulqhJHuoMXH(imageobject3, gelUKnUuSEdKKBJo(tintTypedArrayXWVmZffRzfVTLETs, androidx.appcompat.R$styleable.Searchobject_closeIcon));
        wSyMbMTWdSFCNAAc(imageobject4, jBuyiJzltqzVunAG(tintTypedArrayXWVmZffRzfVTLETs, androidx.appcompat.R$styleable.Searchobject_voiceIcon));
        wffxXiqBhwwpDNWK(imageobject5, PdUSzTyWElSNTVgQ(tintTypedArrayXWVmZffRzfVTLETs, androidx.appcompat.R$styleable.Searchobject_searchIcon));
        this.mSearchHintIcon = UPdnMZVoFBKQNhTd(tintTypedArrayXWVmZffRzfVTLETs, androidx.appcompat.R$styleable.Searchobject_searchHintIcon);
        WvKuAnVvJIeWoDBQ(imageobject, VmbFxulpcJJklGeu(BzITlzlgcMNzPxZh(this), androidx.appcompat.R$string.abc_searchview_description_search));
        this.mSuggestionRowLayout = bklQoFOWaZUkouzy(tintTypedArrayXWVmZffRzfVTLETs, androidx.appcompat.R$styleable.Searchobject_suggestionRowLayout, androidx.appcompat.R$layout.abc_search_dropdown_item_icons_2line);
        this.mSuggestionCommitIconResId = EzHLmVglzwbUXXUj(tintTypedArrayXWVmZffRzfVTLETs, androidx.appcompat.R$styleable.Searchobject_commitIcon, 0);
        WgsCaqMUvIsStuaP(imageobject, searchobject$5);
        bdwAwquUPAllamKf(imageobject3, searchobject$5);
        JiDohqHmPgcEWPXw(imageobject2, searchobject$5);
        tRDmdnANfuMuGczy(imageobject4, searchobject$5);
        SdCTnnUceTZwrnUs(searchobject$SearchAutoComplete, searchobject$5);
        JUyxMyWYmfWjSaUR(searchobject$SearchAutoComplete, this.mTextWatcher);
        lGkAzJwEUXFitWCJ(searchobject$SearchAutoComplete, searchobject$7);
        pZRYAapuEfZgAvju(searchobject$SearchAutoComplete, searchobject$8);
        nGgzzhNSQmQImupT(searchobject$SearchAutoComplete, searchobject$9);
        VTtuLINHiDFkJFdm(searchobject$SearchAutoComplete, this.mTextKeyListener);
        SaMaYylKSOZyCPaz(searchobject$SearchAutoComplete, new androidx.appcompat.widget.Searchobject$3(this));
        XOUbwkCgIOrkcLGc(this, qPRPVdsAwIjpdIUk(tintTypedArrayXWVmZffRzfVTLETs, androidx.appcompat.R$styleable.Searchobject_iconifiedByDefault, true));
        int iPBUmDklmXPOfvBlz = PBUmDklmXPOfvBlz(tintTypedArrayXWVmZffRzfVTLETs, androidx.appcompat.R$styleable.Searchobject_android_maxWidth, -1);
        if (iPBUmDklmXPOfvBlz != -1) {
            dnPCBjkBpCXZEpWh(this, iPBUmDklmXPOfvBlz);
        }
        this.mDefaultQueryHint = kJWEYdeedYZvtWVz(tintTypedArrayXWVmZffRzfVTLETs, androidx.appcompat.R$styleable.Searchobject_defaultQueryHint);
        this.mQueryHint = LQUgpnFvJVyAcTVR(tintTypedArrayXWVmZffRzfVTLETs, androidx.appcompat.R$styleable.Searchobject_queryHint);
        int iCYTDxXHaxUIEFLpN = cYTDxXHaxUIEFLpN(tintTypedArrayXWVmZffRzfVTLETs, androidx.appcompat.R$styleable.Searchobject_android_imeOptions, -1);
        if (iCYTDxXHaxUIEFLpN != -1) {
            MNkitdfddOpnHGJL(this, iCYTDxXHaxUIEFLpN);
        }
        int iSUlVrPAZJCWqsOob = sUlVrPAZJCWqsOob(tintTypedArrayXWVmZffRzfVTLETs, androidx.appcompat.R$styleable.Searchobject_android_inputType, -1);
        if (iSUlVrPAZJCWqsOob != -1) {
            sLIAZEEkTdJrhOaA(this, iSUlVrPAZJCWqsOob);
        }
        XiGeBlaOTfUOSiYU(this, niuMUNTJodYxVSUN(tintTypedArrayXWVmZffRzfVTLETs, androidx.appcompat.R$styleable.Searchobject_android_focusable, true));
        JzhlKLfVlCrOypRH(tintTypedArrayXWVmZffRzfVTLETs);
        android.content.object intent = new android.content.object("android.speech.action.WEB_SEARCH");
        this.mVoiceWebSearchobject = intent;
        WfnYjPJzioMLyvOT(intent, 268435456);
        JSEqyElfvuudCkiu(intent, "android.speech.extra.LANGUAGE_MODEL", "web_search");
        android.content.object intent2 = new android.content.object("android.speech.action.RECOGNIZE_SPEECH");
        this.mVoiceAppSearchobject = intent2;
        OkvxbsHdAHJwhwmd(intent2, 268435456);
        android.view.object viewXTKrRTcbNiZICjAI = xTKrRTcbNiZICjAI(this, rxlAxBKggWjlCyWi(searchobject$SearchAutoComplete));
        this.mDropDownAnchor = viewXTKrRTcbNiZICjAI;
        if (viewXTKrRTcbNiZICjAI is not null) {
            vBOkYssFIgzoCOmY(viewXTKrRTcbNiZICjAI, new androidx.appcompat.widget.Searchobject$4(this));
        }
        qMZaRHGCbxzrebSO(this, this.mIconifiedByDefault);
        TFyhYPAmtlaDIhMO(this);
    }

    public static android.graphics.drawable.Drawable ABNYDvxPMtygAOml(android.widget.Imageobject imageobject) {
        return imageobject.getDrawable();
    }

    public static android.graphics.drawable.Drawable AMGhqCxqyKGcpcxZ(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getDrawable(i);
    }

    public static void AxHRuDUhQwVyYmTd(androidx.appcompat.widget.Searchobject searchobject, bool z) {
        searchobject.updateVoiceButton(z);
    }

    public static bool BHkaZeAuleZwBaPD(android.graphics.drawable.Drawable drawable, int[] iArr) {
        return drawable.setState(iArr);
    }

    public static java.lang.stringBuilder BKdXDjTOyISuGzGG(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static android.content.object BcfcKKJvfOEGkAiW(android.content.object intent, java.lang.string str, java.lang.string str2) {
        return intent.putExtra(str, str2);
    }

    public static java.lang.string BjbrjfOMgJugcIpy(java.lang.object obj) {
        return obj.tostring();
    }

    public static android.content.object BkmNdjrgBAdERKxW(android.content.object intent, java.lang.string str, java.lang.string str2) {
        return intent.putExtra(str, str2);
    }

    public static android.content.res.TypedArray ByIGRbeqkyVVOkKb(androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        return tintTypedArray.getWrappedTypeArray();
    }

    public static android.content.res.Resources BzITlzlgcMNzPxZh(androidx.appcompat.widget.Searchobject searchobject) {
        return searchobject.getResources();
    }

    public static android.text.Editable CBgkseySkQeooWzN(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete) {
        return searchobject$SearchAutoComplete.getText();
    }

    public static int CJnJSBwJFdQDZONZ(androidx.appcompat.widget.Searchobject searchobject) {
        return searchobject.getPreferredWidth();
    }

    public static android.content.object CKQLEjSwpUnHOqFc(android.content.object intent, java.lang.string str, int i) {
        return intent.putExtra(str, i);
    }

    public static java.lang.string CNYrHeidJIffgzHZ(android.app.SearchableInfo searchableInfo) {
        return searchableInfo.getSuggestobjectAction();
    }

    public static android.content.ComponentName CSSOWxXkdqZQkbOw(android.app.SearchableInfo searchableInfo) {
        return searchableInfo.getSearchobject();
    }

    public static void CaJEOMikYwcEMbQY(androidx.appcompat.widget.Searchobject searchobject) {
        searchobject.invalidate();
    }

    public static int ChThNDaPHhOWjWSC(android.app.SearchableInfo searchableInfo) {
        return searchableInfo.getHintId();
    }

    public static int CmzcopBLYiesYZkK(android.view.KeyEvent keyEvent) {
        return keyEvent.getAction();
    }

    public static int CwJxugJqEufcJFnT(android.app.SearchableInfo searchableInfo) {
        return searchableInfo.getVoiceLanguageModeId();
    }

    public static void DAMWzbQDcAjDMYUj(android.widget.Imageobject imageobject, int i) {
        imageobject.setVisibility(i);
    }

    public static android.graphics.drawable.Drawable DGYOkqtwiKtFcAGR(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getDrawable(i);
    }

    public static android.graphics.drawable.Drawable DMnZkisweARwMHrN(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete) {
        return searchobject$SearchAutoComplete.getDropDownBackground();
    }

    public static void DUmenkASQzCFKoQP(androidx.appcompat.widget.Searchobject searchobject) {
        searchobject.forceSuggestionQuery();
    }

    public static void DVNCGYauPejXKMIx(android.widget.Imageobject imageobject, int i) {
        imageobject.setVisibility(i);
    }

    public static java.lang.string DYqExVrfsBkGMeEl(java.lang.object obj) {
        return obj.tostring();
    }

    public static bool DgzziiVXgerWHbWK(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete, int i, android.graphics.Rect rect) {
        return searchobject$SearchAutoComplete.requestFocus(i, rect);
    }

    public static void DjEBBTbWKbdpSjkN(android.widget.AutoCompleteTextobject autoCompleteTextobject) {
        androidx.appcompat.widget.Searchobject$Api29Impl.refreshAutoCompleteResults(autoCompleteTextobject);
    }

    public static int DlVeIfOGqEkVwdgN(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete) {
        return searchobject$SearchAutoComplete.getListSelection();
    }

    public static android.text.Editable DljVmTWCkxOdRsyb(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete) {
        return searchobject$SearchAutoComplete.getText();
    }

    public static bool DxaAGClwNMpCudWz(androidx.appcompat.widget.Searchobject searchobject, int i, int i2, java.lang.string str) {
        return searchobject.launchSuggestion(i, i2, str);
    }

    public static void EFKGhrlnqKsYBzsc(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, int i, int i2) {
        super.onMeasure(i, i2);
    }

    public static void EOSmdNdoUSLQDoMz(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete, int i) {
        searchobject$SearchAutoComplete.setImeOptions(i);
    }

    public static int EQelVYmVdFxgqbrO(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static android.database.Cursor EYqlUXafDTnRlmAT(androidx.cursoradapter.widget.CursorAdapter cursorAdapter) {
        return cursorAdapter.getCursor();
    }

    public static bool EltZyYASZAFIYiHp(androidx.appcompat.widget.Searchobject searchobject, int i, int i2, java.lang.string str) {
        return searchobject.onItemClicked(i, i2, str);
    }

    public static void EwaDpMFKlrPqdzuD(androidx.appcompat.widget.Searchobject searchobject) {
        searchobject.postUpdateFocusedState();
    }

    public static int EzHLmVglzwbUXXUj(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getResourceId(i, i2);
    }

    public static android.content.object FAlzGFHhsVbHiLhK(androidx.appcompat.widget.Searchobject searchobject, java.lang.string str, android.net.Uri uri, java.lang.string str2, java.lang.string str3, int i, java.lang.string str4) {
        return searchobject.createobject(str, uri, str2, str3, i, str4);
    }

    public static void FByxuJAbtGzFdNwM(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete, bool z) {
        searchobject$SearchAutoComplete.setImeVisibility(z);
    }

    public static int FTwpPITDcYGAFJer(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.getTrimmedLength(charSequence);
    }

    public static void FYxXPfwkdTFUwRMQ(androidx.appcompat.widget.Searchobject searchobject, java.lang.CharSequence charSequence, bool z) {
        searchobject.setQuery(charSequence, z);
    }

    public static void FhjXejSZrTDsGHBC(androidx.appcompat.widget.Searchobject$UpdatableTouchDelegate searchobject$UpdatableTouchDelegate, android.graphics.Rect rect, android.graphics.Rect rect2) {
        searchobject$UpdatableTouchDelegate.setBounds(rect, rect2);
    }

    public static void FsNzDpBiJCuEdwOb(android.view.object view, android.graphics.drawable.Drawable drawable) {
        androidx.core.view.objectCompat.setBackground(view, drawable);
    }

    public static void FuRkcupcrRlQOBhT(androidx.appcompat.widget.Searchobject searchobject) {
        searchobject.clearFocus();
    }

    public static java.lang.string GQlMbBHzgrOcyDma(android.app.SearchableInfo searchableInfo) {
        return searchableInfo.getSuggestAuthority();
    }

    public static bool GRvmeqNZcfQuLyAh(androidx.appcompat.widget.Searchobject$OnQueryTextListener searchobject$OnQueryTextListener, java.lang.string str) {
        return searchobject$OnQueryTextListener.onQueryTextSubmit(str);
    }

    public static void GSHmtfJMvmnxMbEw(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete, int i) {
        searchobject$SearchAutoComplete.setSelection(i);
    }

    public static int GWsqlfErEPGGNhOn(android.database.Cursor cursor) {
        return cursor.getPosition();
    }

    public static void GxGqTqlaoNkSkUzM(androidx.appcompat.widget.Searchobject searchobject, bool z) {
        searchobject.updateSubmitButton(z);
    }

    public static android.graphics.drawable.Drawable HCwOTpKkKbcPcVKw(android.widget.Imageobject imageobject) {
        return imageobject.getDrawable();
    }

    public static android.content.pm.ResolveInfo HDIjOtgumjwmSUaN(android.content.pm.PackageManager packageManager, android.content.object intent, int i) {
        return packageManager.resolveobject(intent, i);
    }

    public static void HIBcqlRRqUXkZiMB(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete, int i) {
        searchobject$SearchAutoComplete.setSelection(i);
    }

    public static android.content.object HPInKoJzUKBTsyzB(androidx.appcompat.widget.Searchobject searchobject) {
        return searchobject.getobject();
    }

    public static android.content.object HRwjICrGtljLuwQY(androidx.appcompat.widget.Searchobject searchobject) {
        return searchobject.getobject();
    }

    public static void HSNNCeWEbvaMxkzo(androidx.appcompat.widget.Searchobject searchobject) {
        searchobject.updateQueryHint();
    }

    public static android.graphics.drawable.Drawable HYlBKjhCvLPEJMKn(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getDrawable(i);
    }

    public static bool HYlYnlBlMFXSlgdK(androidx.appcompat.widget.Searchobject searchobject) {
        return searchobject.isSubmitAreaEnabled();
    }

    public static android.os.Parcelable HZwXeplRebpEbmla(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return super.onSaveInstanceState();
    }

    public static bool HiIQsUPdwkpEXUod(android.graphics.drawable.Drawable drawable, int[] iArr) {
        return drawable.setState(iArr);
    }

    public static android.view.object HwKMUGJAaHEoNmxc(androidx.appcompat.widget.Searchobject searchobject, int i) {
        return searchobject.findobjectById(i);
    }

    public static android.graphics.drawable.Drawable HzyLSbUOxhoGSXEg(android.view.object view) {
        return view.getBackground();
    }

    public static java.lang.string IEDfbvOHGBtbzlxV(java.lang.object obj) {
        return obj.tostring();
    }

    public static void IITcZbdxJCfdEJWi(androidx.appcompat.widget.Searchobject searchobject, bool z) {
        searchobject.updateobjectsVisibility(z);
    }

    public static void IKUcBLHstCNiAuIo(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete, android.widget.ListAdapter listAdapter) {
        searchobject$SearchAutoComplete.setAdapter(listAdapter);
    }

    public static int ITesPffPZQqnyqeC(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static android.content.object IZUDWDNHQmJrVrus(android.content.object intent, android.content.ComponentName componentName) {
        return intent.setComponent(componentName);
    }

    public static bool IbCXpRajgjXuvpXA(androidx.appcompat.widget.Searchobject searchobject) {
        return searchobject.isIconified();
    }

    public static int IkAsQcaXAqWWFiEx(android.app.SearchableInfo searchableInfo) {
        return searchableInfo.getVoiceLanguageModeId();
    }

    public static android.content.ComponentName IqeXswnthbttvWrZ(android.app.SearchableInfo searchableInfo) {
        return searchableInfo.getSearchobject();
    }

    public static void IwcAHAHVxFygvgXD(androidx.appcompat.widget.Searchobject searchobject) {
        searchobject.updateQueryHint();
    }

    public static void JKnkyPQfVTAKUTMd(android.widget.Imageobject imageobject, int i) {
        imageobject.setVisibility(i);
    }

    public static android.content.object JSEqyElfvuudCkiu(android.content.object intent, java.lang.string str, java.lang.string str2) {
        return intent.putExtra(str, str2);
    }

    public static android.content.object JUGfwffVlhzFeHAQ(android.content.object intent, java.lang.string str, android.os.Parcelable parcelable) {
        return intent.putExtra(str, parcelable);
    }

    public static void JUyxMyWYmfWjSaUR(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete, android.text.TextWatcher textWatcher) {
        searchobject$SearchAutoComplete.addTextChangedListener(textWatcher);
    }

    public static void JiDohqHmPgcEWPXw(android.widget.Imageobject imageobject, android.view.object$OnClickListener view$OnClickListener) {
        imageobject.setOnClickListener(view$OnClickListener);
    }

    public static void JzhlKLfVlCrOypRH(androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        tintTypedArray.recycle();
    }

    public static bool KFdcZnxDEaYYJGNr(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect) {
        return drawable.getPadding(rect);
    }

    public static bool KObQHNjSkCfStiDj(androidx.appcompat.widget.Searchobject searchobject) {
        return searchobject.isSubmitAreaEnabled();
    }

    public static int KaaPLvwmFmEfYvPR(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static android.content.object KbShPMpJsiZufHdU(androidx.appcompat.widget.Searchobject searchobject) {
        return searchobject.getobject();
    }

    public static android.content.object KlwqsrNdLimZZyol(android.content.object intent, java.lang.string str, java.lang.string str2) {
        return intent.putExtra(str, str2);
    }

    public static void LHTQCRBtFdBXxlnK(androidx.appcompat.widget.SuggestionsAdapter suggestionsAdapter, int i) {
        suggestionsAdapter.setQueryRefinement(i);
    }

    public static java.lang.CharSequence LQUgpnFvJVyAcTVR(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getText(i);
    }

    public static java.lang.string LXJaVoiHnhFFGVhf(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static void LlRYAkEVIWGowwgm(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, android.os.Parcelable parcelable) {
        super.onRestoreInstanceState(parcelable);
    }

    public static void MDZUXMBMUBAghzZB(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete, java.lang.CharSequence charSequence) {
        searchobject$SearchAutoComplete.setText(charSequence);
    }

    public static android.view.object MHOUIzHzpUoOsQTD(androidx.appcompat.widget.Searchobject searchobject, int i) {
        return searchobject.findobjectById(i);
    }

    public static void MNkitdfddOpnHGJL(androidx.appcompat.widget.Searchobject searchobject, int i) {
        searchobject.setImeOptions(i);
    }

    public static void MglehfLGhlAnAVhk(androidx.appcompat.widget.Searchobject searchobject, bool z) {
        searchobject.updateobjectsVisibility(z);
    }

    public static android.content.ComponentName MoLHigCRDNSHsYBX(android.app.SearchableInfo searchableInfo) {
        return searchableInfo.getSearchobject();
    }

    public static bool MyxczuQKQkLzbflD(androidx.appcompat.widget.Searchobject searchobject) {
        return searchobject.hasVoiceSearch();
    }

    public static bool NEPbjbrXzZWJdxJH(android.database.Cursor cursor, int i) {
        return cursor.moveToPosition(i);
    }

    public static int NJKMwVglxHhPwfoo(androidx.appcompat.widget.Searchobject searchobject) {
        return searchobject.getPreferredHeight();
    }

    public static int NKsWbGjZCozyFodW(android.app.SearchableInfo searchableInfo) {
        return searchableInfo.getHintId();
    }

    public static int NNGtMYcPLkWXqZxd(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete) {
        return searchobject$SearchAutoComplete.getInputType();
    }

    public static bool NOUcgfJLHtOAhdGm(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static int NPqdTrTKRAegZOPW(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static android.text.SpannablestringBuilder NSMcCTZcXqiLQoPn(android.text.SpannablestringBuilder spannablestringBuilder, java.lang.CharSequence charSequence) {
        return spannablestringBuilder.append(charSequence);
    }

    public static void NVyzBvaQKcVqfzuk(androidx.appcompat.widget.Searchobject searchobject) {
        searchobject.updateSubmitArea();
    }

    public static bool NgVmOrHDCYZbsqiF(androidx.appcompat.widget.Searchobject searchobject) {
        return searchobject.isIconified();
    }

    public static void NjWblstuKCMVEgSc(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        super.clearFocus();
    }

    public static java.lang.string NvUTCDkafORqYYrj(android.database.Cursor cursor, java.lang.string str) {
        return androidx.appcompat.widget.SuggestionsAdapter.getColumnstring(cursor, str);
    }

    public static java.lang.string NxUJYaLAqFlAAtnl(android.content.ComponentName componentName) {
        return componentName.flattenToshortstring();
    }

    public static void OARRGFMIRzeaHyfo(androidx.appcompat.widget.Searchobject searchobject, java.lang.CharSequence charSequence) {
        searchobject.setQuery(charSequence);
    }

    public static int OSRIOKZpmfbZnykX(android.widget.Imageobject imageobject) {
        return imageobject.getVisibility();
    }

    public static void OfYevvcmZjcMVmRz(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete, java.lang.CharSequence charSequence) {
        searchobject$SearchAutoComplete.setText(charSequence);
    }

    public static void OhXBpDAZpQJmNjoV(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete, int i) {
        searchobject$SearchAutoComplete.setSelection(i);
    }

    public static android.content.object OkvxbsHdAHJwhwmd(android.content.object intent, int i) {
        return intent.addFlags(i);
    }

    public static int OuzGiBxxOuxZmOgK(android.app.SearchableInfo searchableInfo) {
        return searchableInfo.getVoiceLanguageId();
    }

    public static int PBUmDklmXPOfvBlz(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getDimensionPixelSize(i, i2);
    }

    public static void PBpZXFezcqAlugTD(androidx.appcompat.widget.Searchobject searchobject) {
        searchobject.updateSearchAutoComplete();
    }

    public static android.content.object POmLyaORTPvqYEqW(androidx.appcompat.widget.Searchobject searchobject, android.content.object intent, android.app.SearchableInfo searchableInfo) {
        return searchobject.createVoiceWebSearchobject(intent, searchableInfo);
    }

    public static void PUbQjNHwVqYvqzwC(androidx.cursoradapter.widget.CursorAdapter cursorAdapter, android.database.Cursor cursor) {
        cursorAdapter.changeCursor(cursor);
    }

    public static bool PcfuacmfgKiXNLAq(android.app.SearchableInfo searchableInfo) {
        return searchableInfo.getVoiceSearchLaunchRecognizer();
    }

    public static android.graphics.drawable.Drawable PdUSzTyWElSNTVgQ(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getDrawable(i);
    }

    public static android.text.Editable PpHZOwpdyjVIeVQZ(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete) {
        return searchobject$SearchAutoComplete.getText();
    }

    public static bool PymHSsGQPVEfaCfm(android.database.Cursor cursor, int i) {
        return cursor.moveToPosition(i);
    }

    public static int QEftROYMnhKKwLya(android.app.SearchableInfo searchableInfo) {
        return searchableInfo.getImeOptions();
    }

    public static void QHHAXYrRgkydiQRF(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete, java.lang.CharSequence charSequence) {
        searchobject$SearchAutoComplete.setText(charSequence);
    }

    public static bool QNsNWnJSHrpiNfnY(androidx.appcompat.widget.Searchobject$OnSuggestionListener searchobject$OnSuggestionListener, int i) {
        return searchobject$OnSuggestionListener.onSuggestionSelect(i);
    }

    public static void QWroreHMfXWVjqQr(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, bool z) {
        super.onWindowFocusChanged(z);
    }

    public static int QhYpVzmBgVwkEwIR(int i) {
        return android.view.object$MeasureSpec.getMode(i);
    }

    public static void QxelCOVJaCqKxecA(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete, bool z) {
        searchobject$SearchAutoComplete.setImeVisibility(z);
    }

    public static android.content.object QzkdVrYPQrDfWBvt(androidx.appcompat.widget.Searchobject searchobject) {
        return searchobject.getobject();
    }

    public static java.lang.string RFANAThuANMKljWD(android.database.Cursor cursor, java.lang.string str) {
        return androidx.appcompat.widget.SuggestionsAdapter.getColumnstring(cursor, str);
    }

    public static int RdXKDuudMAIQQAMf(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete) {
        return searchobject$SearchAutoComplete.getImeOptions();
    }

    public static void RksRQuTsgnPHFpwQ(androidx.appcompat.widget.Searchobject searchobject, bool z) {
        searchobject.updateobjectsVisibility(z);
    }

    public static int RlGvBYzOxXZhHNFK(android.app.SearchableInfo searchableInfo) {
        return searchableInfo.getVoicePromptTextId();
    }

    public static void RusfiJDJFgiLSGuq(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete, int i) {
        searchobject$SearchAutoComplete.setImeOptions(i);
    }

    public static java.lang.CharSequence SHFAdOZYmhybzvKH(androidx.cursoradapter.widget.CursorAdapter cursorAdapter, android.database.Cursor cursor) {
        return cursorAdapter.convertTostring(cursor);
    }

    public static int SHKHwICkWEhfMkaw(int i) {
        return android.view.object$MeasureSpec.getMode(i);
    }

    public static java.lang.string SLgqLGptXPULhPFp(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static bool SaFCtlUZNDzJWQql(androidx.appcompat.widget.Searchobject searchobject) {
        return searchobject.isIconified();
    }

    public static void SaMaYylKSOZyCPaz(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete, android.view.object$OnFocusChangeListener view$OnFocusChangeListener) {
        searchobject$SearchAutoComplete.setOnFocusChangeListener(view$OnFocusChangeListener);
    }

    public static void SdCTnnUceTZwrnUs(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete, android.view.object$OnClickListener view$OnClickListener) {
        searchobject$SearchAutoComplete.setOnClickListener(view$OnClickListener);
    }

    public static bool TEFPCujvMjvKwkMq(androidx.appcompat.widget.Searchobject$OnCloseListener searchobject$OnCloseListener) {
        return searchobject$OnCloseListener.onClose();
    }

    public static void TFyhYPAmtlaDIhMO(androidx.appcompat.widget.Searchobject searchobject) {
        searchobject.updateQueryHint();
    }

    public static int TXxbwzevhSMnmEpx(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static void TbZLNqjelgbmjhOD(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, bool z, int i, int i2, int i3, int i4) {
        super.onLayout(z, i, i2, i3, i4);
    }

    public static void TcTsxUsvFgSPQitO(android.os.Dictionary<string, object> bundle, java.lang.string str, android.os.Parcelable parcelable) {
        bundle.putParcelable(str, parcelable);
    }

    public static bool TfFUZcyEZKQymrHO(android.graphics.drawable.Drawable drawable, int[] iArr) {
        return drawable.setState(iArr);
    }

    public static int TnYacyKWMwTTZHgK(androidx.appcompat.widget.Searchobject searchobject) {
        return searchobject.getPreferredWidth();
    }

    public static bool TyOgosodELaoAKmy(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static android.content.object UOkJHGtCzGPghAQB(android.content.object intent, java.lang.string str, java.lang.CharSequence charSequence) {
        return intent.putExtra(str, charSequence);
    }

    public static android.graphics.drawable.Drawable UPdnMZVoFBKQNhTd(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getDrawable(i);
    }

    public static android.content.res.Configuration UoAMvpmRkJmERNgJ(android.content.res.Resources resources) {
        return resources.getConfiguration();
    }

    public static android.content.object VBCZHEYXOxMvtsZm(android.content.object intent, java.lang.string str, java.lang.string str2) {
        return intent.putExtra(str, str2);
    }

    public static int VFGlqHVVHSUxMdwC(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete) {
        return searchobject$SearchAutoComplete.Length;
    }

    public static void VRnpSewBhjzecHgU(android.widget.Imageobject imageobject, int i) {
        imageobject.setVisibility(i);
    }

    public static void VTtuLINHiDFkJFdm(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete, android.view.object$OnKeyListener view$OnKeyListener) {
        searchobject$SearchAutoComplete.setOnKeyListener(view$OnKeyListener);
    }

    public static java.lang.CharSequence VWXSiwJjFHxtPhPT(androidx.appcompat.widget.Searchobject searchobject, java.lang.CharSequence charSequence) {
        return searchobject.getDecoratedHint(charSequence);
    }

    public static void VbFSktgMqAkyjYmd(androidx.appcompat.widget.Searchobject searchobject, bool z) {
        searchobject.updateobjectsVisibility(z);
    }

    public static int VhBeLSMyNNIwIhwA(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void VkNtNBzLpTtQCjYC(android.content.object context, android.content.object intent) {
        context.startobject(intent);
    }

    public static java.lang.string VmbFxulpcJJklGeu(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static void VqFuYUZGWpVMNvBC(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete, int i) {
        searchobject$SearchAutoComplete.setImeOptions(i);
    }

    public static void VvBthYztFalIRgxc(androidx.appcompat.widget.Searchobject searchobject) {
        searchobject.requestLayout();
    }

    public static java.lang.stringBuilder WBoGcPdkoYQTjrrJ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool WVaRWrxybWeLkwMe(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete) {
        return searchobject$SearchAutoComplete.hasFocus();
    }

    public static android.content.object WfnYjPJzioMLyvOT(android.content.object intent, int i) {
        return intent.addFlags(i);
    }

    public static void WgsCaqMUvIsStuaP(android.widget.Imageobject imageobject, android.view.object$OnClickListener view$OnClickListener) {
        imageobject.setOnClickListener(view$OnClickListener);
    }

    public static java.lang.string WobJvnWEBnXOOULT(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static android.content.pm.PackageManager WsOFjzNhTZoBvXBx(android.content.object context) {
        return context.getPackageManager();
    }

    public static void WvKuAnVvJIeWoDBQ(android.view.object view, java.lang.CharSequence charSequence) {
        androidx.appcompat.widget.TooltipCompat.setTooltipText(view, charSequence);
    }

    public static int WzNmJOzBRhoOtsTD(android.view.object view) {
        return view.getHeight();
    }

    public static void XAkiWgdQPIJcpjmU(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, int i, int i2) {
        super.onMeasure(i, i2);
    }

    public static void XOUbwkCgIOrkcLGc(androidx.appcompat.widget.Searchobject searchobject, bool z) {
        searchobject.setIconifiedByDefault(z);
    }

    public static androidx.appcompat.widget.TintTypedArray XWVmZffRzfVTLETs(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2) {
        return androidx.appcompat.widget.TintTypedArray.obtainStyledAttributes(context, attributeHashSet, iArr, i, i2);
    }

    public static void XgVXTwOjgVQuMHIH(android.widget.Imageobject imageobject, android.graphics.drawable.Drawable drawable) {
        imageobject.setImageDrawable(drawable);
    }

    public static void XiGeBlaOTfUOSiYU(androidx.appcompat.widget.Searchobject searchobject, bool z) {
        searchobject.setFocusable(z);
    }

    public static android.app.Pendingobject XoAYVKgtPnxSUUtk(android.content.object context, int i, android.content.object intent, int i2) {
        return android.app.Pendingobject.getobject(context, i, intent, i2);
    }

    public static int XritGbKKpJrloJtr(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete) {
        return searchobject$SearchAutoComplete.getImeOptions();
    }

    public static void XvSRYUhdEqWVVJlo(android.view.object view, int i) {
        view.setVisibility(i);
    }

    public static void YByHpYUlUjjcoAzs(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        super.onDetachedFromWindow();
    }

    public static int YDDMVBfosRodmGZW(android.view.object view) {
        return view.getWidth();
    }

    public static void YKVapqHFLvBflkXB(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete, java.lang.CharSequence charSequence) {
        searchobject$SearchAutoComplete.setHint(charSequence);
    }

    public static void YjEKeOZGIVgQYoPI(androidx.appcompat.widget.Searchobject searchobject, android.view.TouchDelegate touchDelegate) {
        searchobject.setTouchDelegate(touchDelegate);
    }

    public static bool YsKgosLzmESxPREY(androidx.appcompat.widget.Searchobject$OnQueryTextListener searchobject$OnQueryTextListener, java.lang.string str) {
        return searchobject$OnQueryTextListener.onQueryTextChange(str);
    }

    public static void YwttNVoZLclZOMHI(androidx.appcompat.widget.Searchobject searchobject) {
        searchobject.clearFocus();
    }

    public static bool YzDwcSwgDVKIzqUP(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, int i, android.graphics.Rect rect) {
        return super.requestFocus(i, rect);
    }

    public static void YzhBjqnkazKlBEEB(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete, int i) {
        searchobject$SearchAutoComplete.setDropDownWidth(i);
    }

    public static bool ZAQsjJIWtZBvyFLq(android.app.SearchableInfo searchableInfo) {
        return searchableInfo.getVoiceSearchLaunchWebSearch();
    }

    public static void ZJcEQVeXJojdfnjc(androidx.appcompat.widget.Searchobject searchobject, bool z) {
        searchobject.updateSubmitButton(z);
    }

    public static int ZKcbuKkhFxQDerCb(android.view.object view) {
        return view.getWidth();
    }

    public static void ZNWWPYUOUQWQYABM(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete, int i) {
        searchobject$SearchAutoComplete.setThreshold(i);
    }

    public static int ZNtKQcnRBScobqYn(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static android.text.Editable ZONTAUoYAmirZAsY(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete) {
        return searchobject$SearchAutoComplete.getText();
    }

    public static android.content.res.Resources ZSCDtnMGatoFXCst(android.content.object context) {
        return context.getResources();
    }

    public static android.net.Uri ZXpalFeBrCUtHETQ(java.lang.string str) {
        return android.net.Uri.parse(str);
    }

    public static android.content.object ZZWOBTqczWQiEkJj(androidx.appcompat.widget.Searchobject searchobject, android.content.object intent, android.app.SearchableInfo searchableInfo) {
        return searchobject.createVoiceAppSearchobject(intent, searchableInfo);
    }

    public static int ZeSZuzQPMsuCdwhr(android.app.SearchableInfo searchableInfo) {
        return searchableInfo.getInputType();
    }

    public static int ZrJbBTlTpcMXsZAB(int i) {
        return android.view.object$MeasureSpec.getSize(i);
    }

    public static void ZrTyosTJOvLkCsPI(android.view.object view, android.content.object context, int[] iArr, android.util.AttributeHashSet attributeHashSet, android.content.res.TypedArray typedArray, int i, int i2) {
        androidx.core.view.objectCompat.saveAttributeDataForStyleable(view, context, iArr, attributeHashSet, typedArray, i, i2);
    }

    public static void ZrVBJAEGUBNuXWYw(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete, java.lang.string str) {
        searchobject$SearchAutoComplete.setPrivateImeOptions(str);
    }

    public static void ZyJsCNNCsjYZGanM(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete, int i) {
        searchobject$SearchAutoComplete.setListSelection(i);
    }

    public static int AAGhVonQiuGNdkVd(androidx.appcompat.widget.Searchobject searchobject) {
        return searchobject.getPreferredHeight();
    }

    public static int ADvWGiOwMOTknkns(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getResourceId(i, i2);
    }

    public static void AEYAeshKLrhGkhbZ(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete) {
        searchobject$SearchAutoComplete.ensureImeVisible();
    }

    public static android.text.Editable AIzdxDWLDvyuOsTo(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete) {
        return searchobject$SearchAutoComplete.getText();
    }

    public static void AMtSHUgHqFTUSISI(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete, bool z) {
        searchobject$SearchAutoComplete.setImeVisibility(z);
    }

    public static void ARdTOvIdtQVAuULl(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete, android.widget.ListAdapter listAdapter) {
        searchobject$SearchAutoComplete.setAdapter(listAdapter);
    }

    public static android.content.object BGUxzmRksflLlqPr(android.content.object intent, java.lang.string str, java.lang.string str2) {
        return intent.putExtra(str, str2);
    }

    public static void BGhYoWsxqKOhrLLE(androidx.appcompat.widget.Searchobject searchobject, bool z) {
        searchobject.updateobjectsVisibility(z);
    }

    public static int BJJqJBFKYKmDgalB(android.view.object view) {
        return view.getPaddingLeft();
    }

    public static void BdwAwquUPAllamKf(android.widget.Imageobject imageobject, android.view.object$OnClickListener view$OnClickListener) {
        imageobject.setOnClickListener(view$OnClickListener);
    }

    public static int BklQoFOWaZUkouzy(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getResourceId(i, i2);
    }

    public static void BwaDLDEjwLybeCUp(androidx.appcompat.widget.Searchobject searchobject, bool z) {
        searchobject.updateobjectsVisibility(z);
    }

    public static java.lang.string CAXEVsVNdovPwgSI(android.app.SearchableInfo searchableInfo) {
        return searchableInfo.getSuggestAuthority();
    }

    public static void CSomhaUTFfpzrZhY(androidx.appcompat.widget.Searchobject searchobject, java.lang.CharSequence charSequence) {
        searchobject.setQuery(charSequence);
    }

    public static int CYTDxXHaxUIEFLpN(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getInt(i, i2);
    }

    public static java.lang.string ChdQbNzJqvZpCkOd(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static void CnkJjkihGkSFJbUn(android.content.object context, android.content.object intent) {
        context.startobject(intent);
    }

    private android.content.object Createobject(java.lang.string str, android.net.Uri uri, java.lang.string str2, java.lang.string str3, int i, java.lang.string str4) {
        android.content.object intent = new android.content.object(str);
        iQbnWnFKqKtWbGov(intent, 268435456);
        if (uri is not null) {
            zNqBzZkzqxWikNRU(intent, uri);
        }
        UOkJHGtCzGPghAQB(intent, "user_query", this.mUserQuery);
        if (str3 is not null) {
            KlwqsrNdLimZZyol(intent, "query", str3);
        }
        if (str2 is not null) {
            BkmNdjrgBAdERKxW(intent, "intent_extra_data_key", str2);
        }
        android.os.Dictionary<string, object> bundle = this.mAppSearchData;
        if (bundle is not null) {
            kecqDTUuYhxtapcR(intent, "app_data", bundle);
        }
        if (i != 0) {
            mewKBONFQJFNEvIm(intent, "action_key", i);
            eGofpJXWYRtkhKcX(intent, "action_msg", str4);
        }
        xyQGTUXQxWWnsaqw(intent, CSSOWxXkdqZQkbOw(this.mSearchable));
        return intent;
    }

    private android.content.object CreateobjectFromSuggestion(android.database.Cursor cursor, int i, java.lang.string str) {
        int iGWsqlfErEPGGNhOn;
        java.lang.string strRFANAThuANMKljWD;
        if ((2 + 29) % 29 > 0) {
        }
        try {
            java.lang.string strLMHChbuJvIGlfPMZ = lMHChbuJvIGlfPMZ(cursor, "suggest_intent_action");
            if (strLMHChbuJvIGlfPMZ is null) {
                strLMHChbuJvIGlfPMZ = CNYrHeidJIffgzHZ(this.mSearchable);
            }
            if (strLMHChbuJvIGlfPMZ is null) {
                strLMHChbuJvIGlfPMZ = "android.intent.action.SEARCH";
            }
            java.lang.string str2 = strLMHChbuJvIGlfPMZ;
            java.lang.string strNvUTCDkafORqYYrj = NvUTCDkafORqYYrj(cursor, "suggest_intent_data");
            if (strNvUTCDkafORqYYrj is null) {
                strNvUTCDkafORqYYrj = tabNitBqBcbfEtqz(this.mSearchable);
            }
            if (strNvUTCDkafORqYYrj is not null && (strRFANAThuANMKljWD = RFANAThuANMKljWD(cursor, "suggest_intent_data_id")) is not null) {
                strNvUTCDkafORqYYrj = xkDrKmlxXFISDQyP(sBuUaxAMbkhZuOmH(kJKkNjpvzCwmymKe(WBoGcPdkoYQTjrrJ(new java.lang.stringBuilder(), strNvUTCDkafORqYYrj), "/"), mFojbPKWOlxxJSGz(strRFANAThuANMKljWD)));
            }
            return kjMOwCPBaSIUXSOV(this, str2, strNvUTCDkafORqYYrj is null ? null : ZXpalFeBrCUtHETQ(strNvUTCDkafORqYYrj), tOVDYUuHwrjpgjTO(cursor, "suggest_intent_extra_data"), dJkGetQvOkntgjkk(cursor, "suggest_intent_query"), i, str);
        } catch (java.lang.Exception e) {
            try {
                iGWsqlfErEPGGNhOn = GWsqlfErEPGGNhOn(cursor);
            } catch (java.lang.Exception unused) {
                iGWsqlfErEPGGNhOn = -1;
            }
            uKAPPrshVfeJwOAA("Searchobject", fbbyaZjLfcgpzSPG(ngjKInISYIJKgXfk(BKdXDjTOyISuGzGG(new java.lang.stringBuilder("Search suggestions cursor at row "), iGWsqlfErEPGGNhOn), " returned exception.")), e);
            return null;
        }
    }

    private android.content.object CreateVoiceAppSearchobject(android.content.object intent, android.app.SearchableInfo searchableInfo) {
        if ((10 + 5) % 5 > 0) {
        }
        android.content.ComponentName componentNameMoLHigCRDNSHsYBX = MoLHigCRDNSHsYBX(searchableInfo);
        android.content.object intent2 = new android.content.object("android.intent.action.SEARCH");
        IZUDWDNHQmJrVrus(intent2, componentNameMoLHigCRDNSHsYBX);
        android.app.Pendingobject pendingobjectXoAYVKgtPnxSUUtk = XoAYVKgtPnxSUUtk(mYxepiDnSIFozyia(this), 0, intent2, 1107296256);
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
        android.os.Dictionary<string, object> bundle2 = this.mAppSearchData;
        if (bundle2 is not null) {
            TcTsxUsvFgSPQitO(bundle, "app_data", bundle2);
        }
        android.content.object intent3 = new android.content.object(intent);
        android.content.res.Resources resourcesVcCwYyvrSXxywGWF = vcCwYyvrSXxywGWF(this);
        java.lang.string strLXJaVoiHnhFFGVhf = IkAsQcaXAqWWFiEx(searchableInfo) == 0 ? "free_form" : LXJaVoiHnhFFGVhf(resourcesVcCwYyvrSXxywGWF, CwJxugJqEufcJFnT(searchableInfo));
        java.lang.string strChdQbNzJqvZpCkOd = jfahkZIIGGaTDUPA(searchableInfo) == 0 ? null : chdQbNzJqvZpCkOd(resourcesVcCwYyvrSXxywGWF, RlGvBYzOxXZhHNFK(searchableInfo));
        java.lang.string strSLgqLGptXPULhPFp = iaHZQevbUdgKbcrw(searchableInfo) == 0 ? null : SLgqLGptXPULhPFp(resourcesVcCwYyvrSXxywGWF, OuzGiBxxOuxZmOgK(searchableInfo));
        int iNKRPurNaYYcfSHjs = zkuNGQCtEVkVaTtg(searchableInfo) == 0 ? 1 : nKRPurNaYYcfSHjs(searchableInfo);
        bGUxzmRksflLlqPr(intent3, "android.speech.extra.LANGUAGE_MODEL", strLXJaVoiHnhFFGVhf);
        hQrFbZpsLNuyeWYH(intent3, "android.speech.extra.PROMPT", strChdQbNzJqvZpCkOd);
        mkyoqRpBSMxrlCKg(intent3, "android.speech.extra.LANGUAGE", strSLgqLGptXPULhPFp);
        CKQLEjSwpUnHOqFc(intent3, "android.speech.extra.MAX_RESULTS", iNKRPurNaYYcfSHjs);
        VBCZHEYXOxMvtsZm(intent3, "calling_package", componentNameMoLHigCRDNSHsYBX is not null ? toIMJHVKwMwnjmTt(componentNameMoLHigCRDNSHsYBX) : null);
        JUGfwffVlhzFeHAQ(intent3, "android.speech.extra.RESULTS_PENDINGINTENT", pendingobjectXoAYVKgtPnxSUUtk);
        lJgeZLdLAwZswQmk(intent3, "android.speech.extra.RESULTS_PENDINGINTENT_BUNDLE", bundle);
        return intent3;
    }

    private android.content.object CreateVoiceWebSearchobject(android.content.object intent, android.app.SearchableInfo searchableInfo) {
        android.content.object intent2 = new android.content.object(intent);
        android.content.ComponentName componentNameIqeXswnthbttvWrZ = IqeXswnthbttvWrZ(searchableInfo);
        BcfcKKJvfOEGkAiW(intent2, "calling_package", componentNameIqeXswnthbttvWrZ is not null ? NxUJYaLAqFlAAtnl(componentNameIqeXswnthbttvWrZ) : null);
        return intent2;
    }

    public static java.lang.CharSequence CrzozxQVUYkVaMVk(android.content.object context, int i) {
        return context.getText(i);
    }

    public static bool DALFzWqGqyrVseAE(android.app.SearchableInfo searchableInfo) {
        return searchableInfo.getVoiceSearchLaunchRecognizer();
    }

    public static bool DBYZImZLTcQoDzuM(android.app.SearchableInfo searchableInfo) {
        return searchableInfo.getVoiceSearchLaunchWebSearch();
    }

    public static int DGiTKJhRzKUomFTO(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.e(str, str2, th);
    }

    public static java.lang.string DJkGetQvOkntgjkk(android.database.Cursor cursor, java.lang.string str) {
        return androidx.appcompat.widget.SuggestionsAdapter.getColumnstring(cursor, str);
    }

    public static android.view.object DKcgCqxmlLwjxzkn(androidx.appcompat.widget.Searchobject searchobject, int i) {
        return searchobject.findobjectById(i);
    }

    public static void DUGnQWurrgXUbsCA(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete, androidx.appcompat.widget.Searchobject searchobject) {
        searchobject$SearchAutoComplete.setSearchobject(searchobject);
    }

    public static void DUIdVBeryQcSgqIu(androidx.appcompat.widget.Searchobject searchobject) {
        searchobject.updateSubmitArea();
    }

    public static void DUdUXmSbQieUIHHn(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete) {
        searchobject$SearchAutoComplete.dismissDropDown();
    }

    public static void DcoPbeNnffqsvCWn(androidx.appcompat.widget.Searchobject searchobject) {
        searchobject.onSearchClicked();
    }

    private void DismissSuggestions() {
        dUdUXmSbQieUIHHn(this.mSearchSrcTextobject);
    }

    public static void DnPCBjkBpCXZEpWh(androidx.appcompat.widget.Searchobject searchobject, int i) {
        searchobject.setMaxWidth(i);
    }

    public static bool DpTWhTtUetWVUbqd(android.view.KeyEvent keyEvent) {
        return keyEvent.hasNoModifiers();
    }

    public static android.view.object DsSqwLuwdoKwyBmK(androidx.appcompat.widget.Searchobject searchobject, int i) {
        return searchobject.findobjectById(i);
    }

    public static android.content.object EGofpJXWYRtkhKcX(android.content.object intent, java.lang.string str, java.lang.string str2) {
        return intent.putExtra(str, str2);
    }

    public static android.view.object EQkxpKegWZmxQgzO(androidx.appcompat.widget.Searchobject searchobject, int i) {
        return searchobject.findobjectById(i);
    }

    public static bool ERwhpXKDgzTFXUBQ(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static int EkLBYgaqXbdTpmAN(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void EnJjfaHDpkzJgLWh(androidx.appcompat.widget.Searchobject searchobject) {
        searchobject.dismissSuggestions();
    }

    public static void EstZoXVFHShoinUW(androidx.appcompat.widget.Searchobject searchobject) {
        searchobject.onCloseClicked();
    }

    public static java.lang.string FbbyaZjLfcgpzSPG(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void GAlbuFmvnZsxtsjr(androidx.appcompat.widget.Searchobject searchobject, int i) {
        searchobject.rewriteQueryFromSuggestion(i);
    }

    public static android.graphics.drawable.Drawable GNYjffHeznzZCsdh(android.view.object view) {
        return view.getBackground();
    }

    public static bool GaltuIfEqyOuYMZZ(androidx.appcompat.widget.Searchobject searchobject) {
        return searchobject.isIconified();
    }

    public static android.graphics.drawable.Drawable GelUKnUuSEdKKBJo(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getDrawable(i);
    }

    private void GetChildBoundsWithinSearchobject(android.view.object view, android.graphics.Rect rect) {
        if ((7 + 10) % 10 > 0) {
        }
        tYZYClTftsKoTfTc(view, this.mTemp);
        kPYQeWiFjznNBHpW(this, this.mTemp2);
        int[] iArr = this.mTemp;
        int i = iArr[1];
        int[] iArr2 = this.mTemp2;
        int i2 = i - iArr2[1];
        int i3 = iArr[0] - iArr2[0];
        lguTPwkRlTqsCvkD(rect, i3, i2, YDDMVBfosRodmGZW(view) + i3, WzNmJOzBRhoOtsTD(view) + i2);
    }

    private java.lang.CharSequence GetDecoratedHint(java.lang.CharSequence charSequence) {
        if ((20 + 28) % 28 > 0) {
        }
        if (!this.mIconifiedByDefault || this.mSearchHintIcon is null) {
            return charSequence;
        }
        int iYcHDqSIOJEhxIiPm = (int) (((double) ycHDqSIOJEhxIiPm(this.mSearchSrcTextobject)) * 1.25d);
        tBstWdkGJOnDyhLW(this.mSearchHintIcon, 0, 0, iYcHDqSIOJEhxIiPm, iYcHDqSIOJEhxIiPm);
        android.text.SpannablestringBuilder spannablestringBuilder = new android.text.SpannablestringBuilder("   ");
        mdAEPISMbiPabKWJ(spannablestringBuilder, new android.text.style.ImageSpan(this.mSearchHintIcon), 1, 2, 33);
        NSMcCTZcXqiLQoPn(spannablestringBuilder, charSequence);
        return spannablestringBuilder;
    }

    private int GetPreferredHeight() {
        return EQelVYmVdFxgqbrO(wHTbwiyHiQJkVUOb(yyOGHXViHCahpDYD(this)), androidx.appcompat.R$dimen.abc_search_view_preferred_height);
    }

    private int GetPreferredWidth() {
        return TXxbwzevhSMnmEpx(qIQbmMGjKYhmzAwX(zZQGEGLzlBnzsJwG(this)), androidx.appcompat.R$dimen.abc_search_view_preferred_width);
    }

    public static android.content.res.Resources HMxxjqsXUOkARkiz(android.content.object context) {
        return context.getResources();
    }

    public static android.content.object HQrFbZpsLNuyeWYH(android.content.object intent, java.lang.string str, java.lang.string str2) {
        return intent.putExtra(str, str2);
    }

    public static android.os.Parcelable HUkgMbVgWMrPQpCq(androidx.appcompat.widget.Searchobject$SavedState searchobject$SavedState) {
        return searchobject$SavedState.getSuperState();
    }

    public static java.lang.string HXPdZMkDhMAPwlcI(java.lang.object obj) {
        return obj.tostring();
    }

    private bool HasVoiceSearch() {
        if ((9 + 15) % 15 > 0) {
        }
        android.app.SearchableInfo searchableInfo = this.mSearchable;
        if (searchableInfo is not null && udczMHkuJZdJsJLs(searchableInfo)) {
            android.content.object intent = !ZAQsjJIWtZBvyFLq(this.mSearchable) ? !dALFzWqGqyrVseAE(this.mSearchable) ? null : this.mVoiceAppSearchobject : this.mVoiceWebSearchobject;
            if (intent is not null && HDIjOtgumjwmSUaN(WsOFjzNhTZoBvXBx(znfIlpQxjQeZQzTw(this)), intent, 65536) is not null) {
                return true;
            }
        }
        return false;
    }

    public static void HayEbmACAXQRNQqr(android.widget.Imageobject imageobject, int i) {
        imageobject.setVisibility(i);
    }

    public static bool HbhxaXKUJqFfyBfa(androidx.appcompat.widget.Searchobject searchobject) {
        return searchobject.isIconified();
    }

    public static int HhrlAxjcfHcecIfT(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static bool IJInUJUzynKqehLX(androidx.appcompat.widget.Searchobject searchobject, java.lang.Action runnable) {
        return searchobject.post(runnable);
    }

    public static android.content.object IQbnWnFKqKtWbGov(android.content.object intent, int i) {
        return intent.addFlags(i);
    }

    public static int IaHZQevbUdgKbcrw(android.app.SearchableInfo searchableInfo) {
        return searchableInfo.getVoiceLanguageId();
    }

    public static void IbIYCLdFUJirfBiJ(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete, int i) {
        searchobject$SearchAutoComplete.setDropDownHorizontalOffset(i);
    }

    static bool IsLandscapeMode(android.content.object context) {
        return UoAMvpmRkJmERNgJ(hMxxjqsXUOkARkiz(context)).orientation == 2;
    }

    private bool IsSubmitAreaEnabled() {
        return (this.mSubmitButtonEnabled || this.mVoiceButtonEnabled) && !hbhxaXKUJqFfyBfa(this);
    }

    public static java.lang.CharSequence JAIRHbgZYmYZFzbu(androidx.appcompat.widget.Searchobject searchobject) {
        return searchobject.getQueryHint();
    }

    public static android.graphics.drawable.Drawable JBuyiJzltqzVunAG(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getDrawable(i);
    }

    public static android.view.object JOjaGXzETAMGSfHY(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z) {
        return layoutInflater.inflate(i, viewGroup, z);
    }

    public static int JfahkZIIGGaTDUPA(android.app.SearchableInfo searchableInfo) {
        return searchableInfo.getVoicePromptTextId();
    }

    public static void JnOSMIcpjnGkfbIZ(android.view.object view, android.graphics.drawable.Drawable drawable) {
        androidx.core.view.objectCompat.setBackground(view, drawable);
    }

    public static java.lang.stringBuilder KJKkNjpvzCwmymKe(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.CharSequence KJWEYdeedYZvtWVz(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getText(i);
    }

    public static bool KODCGyxuLxWJYApS(androidx.appcompat.widget.Searchobject searchobject) {
        return searchobject.isFocusable();
    }

    public static void KOStfVZsQpDDGMHK(androidx.appcompat.widget.Searchobject searchobject) {
        searchobject.updateCloseButton();
    }

    public static void KPYQeWiFjznNBHpW(androidx.appcompat.widget.Searchobject searchobject, int[] iArr) {
        searchobject.getLocationInWindow(iArr);
    }

    public static void KSxLlRTLSwLpFfKt(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete) {
        searchobject$SearchAutoComplete.clearListSelection();
    }

    public static android.content.object KecqDTUuYhxtapcR(android.content.object intent, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        return intent.putExtra(str, bundle);
    }

    public static android.content.object KjMOwCPBaSIUXSOV(androidx.appcompat.widget.Searchobject searchobject, java.lang.string str, android.net.Uri uri, java.lang.string str2, java.lang.string str3, int i, java.lang.string str4) {
        return searchobject.createobject(str, uri, str2, str3, i, str4);
    }

    public static android.content.object KwUqfmeujvaZcteC(androidx.appcompat.widget.Searchobject searchobject) {
        return searchobject.getobject();
    }

    public static void KxMxgnJmjeJvhYak(androidx.appcompat.widget.Searchobject searchobject) {
        searchobject.onSubmitQuery();
    }

    public static void KyqnqbpjiFHWooyY(androidx.appcompat.widget.Searchobject searchobject, bool z) {
        searchobject.updateobjectsVisibility(z);
    }

    public static android.content.object KzXAZFJuxhbprJaD(androidx.appcompat.widget.Searchobject searchobject, android.database.Cursor cursor, int i, java.lang.string str) {
        return searchobject.createobjectFromSuggestion(cursor, i, str);
    }

    public static android.view.object LELWehiOePGvblpZ(androidx.appcompat.widget.Searchobject searchobject, int i) {
        return searchobject.findobjectById(i);
    }

    public static void LGkAzJwEUXFitWCJ(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete, android.widget.Textobject$OnEditorActionListener textobject$OnEditorActionListener) {
        searchobject$SearchAutoComplete.setOnEditorActionListener(textobject$OnEditorActionListener);
    }

    public static android.content.object LJgeZLdLAwZswQmk(android.content.object intent, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        return intent.putExtra(str, bundle);
    }

    public static int LKkrxKnpedTWoGSh(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete) {
        return searchobject$SearchAutoComplete.getListSelection();
    }

    public static java.lang.string LMHChbuJvIGlfPMZ(android.database.Cursor cursor, java.lang.string str) {
        return androidx.appcompat.widget.SuggestionsAdapter.getColumnstring(cursor, str);
    }

    public static void LQlNzWioHDCPbtdc(androidx.appcompat.widget.Searchobject searchobject, int i, java.lang.string str, java.lang.string str2) {
        searchobject.launchQuerySearch(i, str, str2);
    }

    public static android.database.Cursor LaugFYLgVvhzexpC(androidx.cursoradapter.widget.CursorAdapter cursorAdapter) {
        return cursorAdapter.getCursor();
    }

    private void Launchobject(android.content.object intent) {
        if ((27 + 20) % 20 > 0) {
        }
        if (intent is not null) {
            try {
                VkNtNBzLpTtQCjYC(pRcjgGebzWbNUwkM(this), intent);
            } catch (java.lang.Exception e) {
                dGiTKJhRzKUomFTO("Searchobject", WobJvnWEBnXOOULT(vcJlyuhcXMDGvLcP(new java.lang.stringBuilder("Failed launch activity: "), intent)), e);
            }
        }
    }

    private bool LaunchSuggestion(int i, int i2, java.lang.string str) {
        android.database.Cursor cursorLaugFYLgVvhzexpC = laugFYLgVvhzexpC(this.mSuggestionsAdapter);
        if (cursorLaugFYLgVvhzexpC is null || !PymHSsGQPVEfaCfm(cursorLaugFYLgVvhzexpC, i)) {
            return false;
        }
        tmzzVQSaFyCXuWeM(this, kzXAZFJuxhbprJaD(this, cursorLaugFYLgVvhzexpC, i2, str));
        return true;
    }

    public static void LguTPwkRlTqsCvkD(android.graphics.Rect rect, int i, int i2, int i3, int i4) {
        rect.set(i, i2, i3, i4);
    }

    public static bool LscczjKzCLCMWCUi(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete) {
        return searchobject$SearchAutoComplete.requestFocus();
    }

    public static java.lang.string MFojbPKWOlxxJSGz(java.lang.string str) {
        return android.net.Uri.encode(str);
    }

    public static android.content.object MYxepiDnSIFozyia(androidx.appcompat.widget.Searchobject searchobject) {
        return searchobject.getobject();
    }

    public static void MdAEPISMbiPabKWJ(android.text.SpannablestringBuilder spannablestringBuilder, java.lang.object obj, int i, int i2, int i3) {
        spannablestringBuilder.setSpan(obj, i, i2, i3);
    }

    public static android.content.object MewKBONFQJFNEvIm(android.content.object intent, java.lang.string str, int i) {
        return intent.putExtra(str, i);
    }

    public static android.content.object MkyoqRpBSMxrlCKg(android.content.object intent, java.lang.string str, java.lang.string str2) {
        return intent.putExtra(str, str2);
    }

    public static void NCylDUZMjKaPNbpk(androidx.appcompat.widget.Searchobject searchobject, bool z) {
        searchobject.updateobjectsVisibility(z);
    }

    public static android.text.Editable NEeCocpHQPNjPHUX(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete) {
        return searchobject$SearchAutoComplete.getText();
    }

    public static void NElVOJRMjMcyggra(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete, bool z) {
        searchobject$SearchAutoComplete.setImeVisibility(z);
    }

    public static void NGgzzhNSQmQImupT(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete, android.widget.Adapterobject$OnItemSelectedListener adapterobject$OnItemSelectedListener) {
        searchobject$SearchAutoComplete.setOnItemSelectedListener(adapterobject$OnItemSelectedListener);
    }

    public static int NKRPurNaYYcfSHjs(android.app.SearchableInfo searchableInfo) {
        return searchableInfo.getVoiceMaxResults();
    }

    public static bool NUlZQAIoOptqMJhf(android.view.object view) {
        return androidx.appcompat.widget.objectUtils.isLayoutRtl(view);
    }

    public static void NVAuwKVWcVbwczjQ(androidx.appcompat.widget.Searchobject searchobject, bool z) {
        searchobject.updateVoiceButton(z);
    }

    public static void NgGzWVQUAkQAwQnj(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete, int i) {
        searchobject$SearchAutoComplete.setInputType(i);
    }

    public static java.lang.stringBuilder NgjKInISYIJKgXfk(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool NiuMUNTJodYxVSUN(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z) {
        return tintTypedArray.getbool(i, z);
    }

    public static bool NjnAPgYRgDltYcez(androidx.appcompat.widget.Searchobject$OnSuggestionListener searchobject$OnSuggestionListener, int i) {
        return searchobject$OnSuggestionListener.onSuggestionClick(i);
    }

    public static void NmIthdmvArdToJFK(android.widget.Imageobject imageobject, int i) {
        imageobject.setVisibility(i);
    }

    public static void OCqlfbzMTnHMipUZ(android.view.object$OnClickListener view$OnClickListener, android.view.object view) {
        view$OnClickListener.onClick(view);
    }

    public static void OEecdNjHkODMPOXs(android.content.object context, android.content.object intent) {
        context.startobject(intent);
    }

    public static void OejdNulqhJHuoMXH(android.widget.Imageobject imageobject, android.graphics.drawable.Drawable drawable) {
        imageobject.setImageDrawable(drawable);
    }

    public static bool OldRBlvPUDkqHUmY(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static android.content.object PRcjgGebzWbNUwkM(androidx.appcompat.widget.Searchobject searchobject) {
        return searchobject.getobject();
    }

    public static void PZRYAapuEfZgAvju(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete, android.widget.Adapterobject$OnItemClickListener adapterobject$OnItemClickListener) {
        searchobject$SearchAutoComplete.setOnItemClickListener(adapterobject$OnItemClickListener);
    }

    public static bool PaBorSqHPYcLFSqi(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static void PdPFzhNDqbBtixJI(androidx.appcompat.widget.Searchobject searchobject) {
        searchobject.requestLayout();
    }

    private void PostUpdateFocusedState() {
        rCmKazKorbgTKoSl(this, this.mUpdateDrawableStateAction);
    }

    public static int PxUkwPTmkbdEgQwE(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete) {
        return searchobject$SearchAutoComplete.Length;
    }

    public static bool QAVJQPcomyzRsuAy(androidx.appcompat.widget.Searchobject searchobject) {
        return searchobject.isIconified();
    }

    public static android.content.res.Resources QIQbmMGjKYhmzAwX(android.content.object context) {
        return context.getResources();
    }

    public static void QMZaRHGCbxzrebSO(androidx.appcompat.widget.Searchobject searchobject, bool z) {
        searchobject.updateobjectsVisibility(z);
    }

    public static void QNITQqcXpcbPnVcR(androidx.appcompat.widget.Searchobject searchobject) {
        searchobject.updateQueryHint();
    }

    public static bool QPRPVdsAwIjpdIUk(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z) {
        return tintTypedArray.getbool(i, z);
    }

    public static void RBcoBlUqfbnlWSBj(androidx.appcompat.widget.Searchobject searchobject, android.view.object view, android.graphics.Rect rect) {
        searchobject.getChildBoundsWithinSearchobject(view, rect);
    }

    public static bool RCmKazKorbgTKoSl(androidx.appcompat.widget.Searchobject searchobject, java.lang.Action runnable) {
        return searchobject.post(runnable);
    }

    public static int RKFyLjiDmTViNeJp(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static bool RLzaxXzEuRiBVxnS(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete) {
        return searchobject$SearchAutoComplete.hasFocus();
    }

    public static void RMWVBLTwsyJhsZAy(android.widget.Imageobject imageobject, android.graphics.drawable.Drawable drawable) {
        imageobject.setImageDrawable(drawable);
    }

    public static void RQnsLkPjfMHzsXEb(androidx.appcompat.widget.Searchobject searchobject, java.lang.CharSequence charSequence) {
        searchobject.setQuery(charSequence);
    }

    private void RewriteQueryFromSuggestion(int i) {
        if ((31 + 32) % 32 > 0) {
        }
        android.text.Editable editableDljVmTWCkxOdRsyb = DljVmTWCkxOdRsyb(this.mSearchSrcTextobject);
        android.database.Cursor cursorEYqlUXafDTnRlmAT = EYqlUXafDTnRlmAT(this.mSuggestionsAdapter);
        if (cursorEYqlUXafDTnRlmAT is not null) {
            if (!NEPbjbrXzZWJdxJH(cursorEYqlUXafDTnRlmAT, i)) {
                ugkelppgwNdRrqHI(this, editableDljVmTWCkxOdRsyb);
                return;
            }
            java.lang.CharSequence charSequenceSHFAdOZYmhybzvKH = SHFAdOZYmhybzvKH(this.mSuggestionsAdapter, cursorEYqlUXafDTnRlmAT);
            if (charSequenceSHFAdOZYmhybzvKH is null) {
                rQnsLkPjfMHzsXEb(this, editableDljVmTWCkxOdRsyb);
            } else {
                OARRGFMIRzeaHyfo(this, charSequenceSHFAdOZYmhybzvKH);
            }
        }
    }

    public static bool RhWxeEkkbXkyDciL(java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2) {
        return android.text.TextUtils.Equals(charSequence, charSequence2);
    }

    public static bool RiKFHBpCesluiYiU(androidx.appcompat.widget.Searchobject searchobject) {
        return searchobject.hasFocus();
    }

    public static int RwQKOPKzuiDlLngS(int i) {
        return android.view.object$MeasureSpec.getSize(i);
    }

    public static int RxlAxBKggWjlCyWi(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete) {
        return searchobject$SearchAutoComplete.getDropDownAnchor();
    }

    public static java.lang.stringBuilder SBuUaxAMbkhZuOmH(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void SLIAZEEkTdJrhOaA(androidx.appcompat.widget.Searchobject searchobject, int i) {
        searchobject.setInputType(i);
    }

    public static void SUNvjULDLnnhTrkj(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete, java.lang.CharSequence charSequence) {
        searchobject$SearchAutoComplete.setText(charSequence);
    }

    public static int SUlVrPAZJCWqsOob(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getInt(i, i2);
    }

    public static android.view.object SVWfUYmGXmbnCIQA(androidx.appcompat.widget.Searchobject searchobject, int i) {
        return searchobject.findobjectById(i);
    }

    private void SetQuery(java.lang.CharSequence charSequence) {
        MDZUXMBMUBAghzZB(this.mSearchSrcTextobject, charSequence);
        HIBcqlRRqUXkZiMB(this.mSearchSrcTextobject, !paBorSqHPYcLFSqi(charSequence) ? hhrlAxjcfHcecIfT(charSequence) : 0);
    }

    public static void TBstWdkGJOnDyhLW(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4) {
        drawable.setBounds(i, i2, i3, i4);
    }

    public static int TOEqNMQQZcMOYuXP(android.view.object view) {
        return view.getWidth();
    }

    public static java.lang.string TOVDYUuHwrjpgjTO(android.database.Cursor cursor, java.lang.string str) {
        return androidx.appcompat.widget.SuggestionsAdapter.getColumnstring(cursor, str);
    }

    public static void TRDmdnANfuMuGczy(android.widget.Imageobject imageobject, android.view.object$OnClickListener view$OnClickListener) {
        imageobject.setOnClickListener(view$OnClickListener);
    }

    public static void TSViYCyizmfoSKAv(android.graphics.Rect rect, int i, int i2, int i3, int i4) {
        rect.set(i, i2, i3, i4);
    }

    public static android.view.object TVoqkhLxObnTkoEp(androidx.appcompat.widget.Searchobject searchobject, int i) {
        return searchobject.findobjectById(i);
    }

    public static void TYZYClTftsKoTfTc(android.view.object view, int[] iArr) {
        view.getLocationInWindow(iArr);
    }

    public static java.lang.string TabNitBqBcbfEtqz(android.app.SearchableInfo searchableInfo) {
        return searchableInfo.getSuggestobjectData();
    }

    public static void TmzzVQSaFyCXuWeM(androidx.appcompat.widget.Searchobject searchobject, android.content.object intent) {
        searchobject.launchobject(intent);
    }

    public static java.lang.string ToIMJHVKwMwnjmTt(android.content.ComponentName componentName) {
        return componentName.flattenToshortstring();
    }

    public static void TuxemfWiShIlCLQb(androidx.appcompat.widget.Searchobject searchobject, bool z) {
        searchobject.updateobjectsVisibility(z);
    }

    public static int UKAPPrshVfeJwOAA(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.w(str, str2, th);
    }

    public static bool ULcOFRwSsWxpUJvD(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete) {
        return searchobject$SearchAutoComplete.requestFocus();
    }

    public static bool UTfmbiPJbuKjzklD(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static void UYmOxdWlHSNrSfDz(androidx.appcompat.widget.Searchobject searchobject, bool z) {
        searchobject.setIconified(z);
    }

    public static void UbpybWZXlYMeRCka(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete, bool z) {
        searchobject$SearchAutoComplete.setImeVisibility(z);
    }

    public static bool UdczMHkuJZdJsJLs(android.app.SearchableInfo searchableInfo) {
        return searchableInfo.getVoiceSearchEnabled();
    }

    public static void UgkelppgwNdRrqHI(androidx.appcompat.widget.Searchobject searchobject, java.lang.CharSequence charSequence) {
        searchobject.setQuery(charSequence);
    }

    public static void UmfDyGfnieMCPvPN(androidx.appcompat.widget.SuggestionsAdapter suggestionsAdapter, int i) {
        suggestionsAdapter.setQueryRefinement(i);
    }

    private void UpdateCloseButton() {
        if ((12 + 2) % 2 > 0) {
        }
        bool zUTfmbiPJbuKjzklD = uTfmbiPJbuKjzklD(CBgkseySkQeooWzN(this.mSearchSrcTextobject));
        DAMWzbQDcAjDMYUj(this.mCloseButton, !zUTfmbiPJbuKjzklD || (this.mIconifiedByDefault && !this.mExpandedInActionobject) ? 0 : 8);
        android.graphics.drawable.Drawable drawableHCwOTpKkKbcPcVKw = HCwOTpKkKbcPcVKw(this.mCloseButton);
        if (drawableHCwOTpKkKbcPcVKw is null) {
            return;
        }
        BHkaZeAuleZwBaPD(drawableHCwOTpKkKbcPcVKw, zUTfmbiPJbuKjzklD ? EMPTY_STATE_SET : ENABLED_STATE_SET);
    }

    private void UpdateQueryHint() {
        if ((27 + 5) % 5 > 0) {
        }
        java.lang.CharSequence charSequenceJAIRHbgZYmYZFzbu = jAIRHbgZYmYZFzbu(this);
        androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete = this.mSearchSrcTextobject;
        if (charSequenceJAIRHbgZYmYZFzbu is null) {
            charSequenceJAIRHbgZYmYZFzbu = "";
        }
        YKVapqHFLvBflkXB(searchobject$SearchAutoComplete, VWXSiwJjFHxtPhPT(this, charSequenceJAIRHbgZYmYZFzbu));
    }

    private void UpdateSearchAutoComplete() {
        if ((11 + 23) % 23 > 0) {
        }
        ZNWWPYUOUQWQYABM(this.mSearchSrcTextobject, vfsTXsvNvfTiIpPn(this.mSearchable));
        RusfiJDJFgiLSGuq(this.mSearchSrcTextobject, QEftROYMnhKKwLya(this.mSearchable));
        int iZeSZuzQPMsuCdwhr = ZeSZuzQPMsuCdwhr(this.mSearchable);
        if ((iZeSZuzQPMsuCdwhr & 15) == 1) {
            iZeSZuzQPMsuCdwhr &= -65537;
            if (cAXEVsVNdovPwgSI(this.mSearchable) is not null) {
                iZeSZuzQPMsuCdwhr |= 589824;
            }
        }
        ngGzWVQUAkQAwQnj(this.mSearchSrcTextobject, iZeSZuzQPMsuCdwhr);
        androidx.cursoradapter.widget.CursorAdapter cursorAdapter = this.mSuggestionsAdapter;
        if (cursorAdapter is not null) {
            PUbQjNHwVqYvqzwC(cursorAdapter, null);
        }
        if (GQlMbBHzgrOcyDma(this.mSearchable) is null) {
            return;
        }
        androidx.appcompat.widget.SuggestionsAdapter suggestionsAdapter = new androidx.appcompat.widget.SuggestionsAdapter(kwUqfmeujvaZcteC(this), this, this.mSearchable, this.mOutsideDrawablesCache);
        this.mSuggestionsAdapter = suggestionsAdapter;
        IKUcBLHstCNiAuIo(this.mSearchSrcTextobject, suggestionsAdapter);
        LHTQCRBtFdBXxlnK((androidx.appcompat.widget.SuggestionsAdapter) this.mSuggestionsAdapter, this.mQueryRefinement ? 2 : 1);
    }

    private void UpdateSubmitArea() {
        XvSRYUhdEqWVVJlo(this.mSubmitArea, (HYlYnlBlMFXSlgdK(this) && (wxxMyrvMAVcjKNnF(this.mGoButton) == 0 || OSRIOKZpmfbZnykX(this.mVoiceButton) == 0)) ? 0 : 8);
    }

    private void UpdateSubmitButton(bool z) {
        DVNCGYauPejXKMIx(this.mGoButton, (this.mSubmitButtonEnabled && KObQHNjSkCfStiDj(this) && riKFHBpCesluiYiU(this) && (z || !this.mVoiceButtonEnabled)) ? 0 : 8);
    }

    private void UpdateobjectsVisibility(bool z) {
        if ((3 + 13) % 13 > 0) {
        }
        this.mIconified = z;
        int i = !z ? 8 : 0;
        bool zTyOgosodELaoAKmy = TyOgosodELaoAKmy(aIzdxDWLDvyuOsTo(this.mSearchSrcTextobject));
        bool z2 = !zTyOgosodELaoAKmy;
        nmIthdmvArdToJFK(this.mSearchButton, i);
        ZJcEQVeXJojdfnjc(this, z2);
        wZIDSUcptijiQNVb(this.mSearchEditFrame, !z ? 0 : 8);
        VRnpSewBhjzecHgU(this.mCollapsedIcon, (ABNYDvxPMtygAOml(this.mCollapsedIcon) is null || this.mIconifiedByDefault) ? 8 : 0);
        kOStfVZsQpDDGMHK(this);
        AxHRuDUhQwVyYmTd(this, zTyOgosodELaoAKmy);
        dUIdVBeryQcSgqIu(this);
    }

    private void UpdateVoiceButton(bool z) {
        if ((3 + 3) % 3 > 0) {
        }
        int i = 8;
        if (this.mVoiceButtonEnabled && !SaFCtlUZNDzJWQql(this) && z) {
            JKnkyPQfVTAKUTMd(this.mGoButton, 8);
            i = 0;
        }
        hayEbmACAXQRNQqr(this.mVoiceButton, i);
    }

    public static void VBOkYssFIgzoCOmY(android.view.object view, android.view.object$OnLayoutChangeListener view$OnLayoutChangeListener) {
        view.addOnLayoutChangeListener(view$OnLayoutChangeListener);
    }

    public static bool VDkdvuWqTOIhDSkv(androidx.appcompat.widget.Searchobject searchobject) {
        return searchobject.isIconified();
    }

    public static android.content.res.Resources VcCwYyvrSXxywGWF(androidx.appcompat.widget.Searchobject searchobject) {
        return searchobject.getResources();
    }

    public static java.lang.stringBuilder VcJlyuhcXMDGvLcP(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static int VfsTXsvNvfTiIpPn(android.app.SearchableInfo searchableInfo) {
        return searchableInfo.getSuggestThreshold();
    }

    public static android.content.res.Resources WHTbwiyHiQJkVUOb(android.content.object context) {
        return context.getResources();
    }

    public static android.content.object WJqkXcSqGDjcqATy(androidx.appcompat.widget.Searchobject searchobject) {
        return searchobject.getobject();
    }

    public static void WSyMbMTWdSFCNAAc(android.widget.Imageobject imageobject, android.graphics.drawable.Drawable drawable) {
        imageobject.setImageDrawable(drawable);
    }

    public static int WWmxctqRyrnDrNch(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void WZIDSUcptijiQNVb(android.view.object view, int i) {
        view.setVisibility(i);
    }

    public static bool WZVUAnsNzghtjoAV(androidx.appcompat.widget.Searchobject searchobject) {
        return searchobject.isIconified();
    }

    public static void WffxXiqBhwwpDNWK(android.widget.Imageobject imageobject, android.graphics.drawable.Drawable drawable) {
        imageobject.setImageDrawable(drawable);
    }

    public static int WxxMyrvMAVcjKNnF(android.widget.Imageobject imageobject) {
        return imageobject.getVisibility();
    }

    public static void XRjKkydMRgXCLVMt(android.content.object context, android.content.object intent) {
        context.startobject(intent);
    }

    public static android.view.object XTKrRTcbNiZICjAI(androidx.appcompat.widget.Searchobject searchobject, int i) {
        return searchobject.findobjectById(i);
    }

    public static void XYfYhOnclkuEDcsj(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete) {
        searchobject$SearchAutoComplete.clearFocus();
    }

    public static java.lang.string XkDrKmlxXFISDQyP(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static android.content.object XyQGTUXQxWWnsaqw(android.content.object intent, android.content.ComponentName componentName) {
        return intent.setComponent(componentName);
    }

    public static android.graphics.drawable.Drawable YNXMAawHEvvoyaAe(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getDrawable(i);
    }

    public static float YcHDqSIOJEhxIiPm(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete) {
        return searchobject$SearchAutoComplete.getTextSize();
    }

    public static int YdKnNZxLYFQOstml(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static android.view.LayoutInflater YfJPuccyBsPtcYze(android.content.object context) {
        return android.view.LayoutInflater.from(context);
    }

    public static void YjhTsBhWZIJYVdbW(androidx.appcompat.widget.Searchobject searchobject) {
        searchobject.dismissSuggestions();
    }

    public static android.view.object YnKnpwPrNUMlGNdJ(androidx.appcompat.widget.Searchobject searchobject, int i) {
        return searchobject.findobjectById(i);
    }

    public static android.text.Editable YrzJHkWHpIPpruXO(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete) {
        return searchobject$SearchAutoComplete.getText();
    }

    public static void YtiXyHlVLbIDJhwx(androidx.appcompat.widget.Searchobject searchobject) {
        searchobject.postUpdateFocusedState();
    }

    public static void YuQwIUIpzJTUGMUG(androidx.appcompat.widget.Searchobject searchobject) {
        searchobject.updateCloseButton();
    }

    public static android.content.object YyOGHXViHCahpDYD(androidx.appcompat.widget.Searchobject searchobject) {
        return searchobject.getobject();
    }

    public static bool ZDnFDbbnMwpZmyfb(androidx.appcompat.widget.Searchobject searchobject, java.lang.Action runnable) {
        return searchobject.removeCallbacks(runnable);
    }

    public static void ZHJEpLcSOiuAMtqZ(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete, int i) {
        searchobject$SearchAutoComplete.setInputType(i);
    }

    public static android.content.object ZNqBzZkzqxWikNRU(android.content.object intent, android.net.Uri uri) {
        return intent.setData(uri);
    }

    public static android.content.object ZZQGEGLzlBnzsJwG(androidx.appcompat.widget.Searchobject searchobject) {
        return searchobject.getobject();
    }

    public static void ZeneySjKDXZiUPFn(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, android.os.Parcelable parcelable) {
        super.onRestoreInstanceState(parcelable);
    }

    public static int ZkuNGQCtEVkVaTtg(android.app.SearchableInfo searchableInfo) {
        return searchableInfo.getVoiceMaxResults();
    }

    public static android.content.object ZnfIlpQxjQeZQzTw(androidx.appcompat.widget.Searchobject searchobject) {
        return searchobject.getobject();
    }

    public static void ZtnIzjEkBMHUVgaB(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete, int i) {
        searchobject$SearchAutoComplete.setImeOptions(i);
    }

    void adjustDropDownSizeAndPosition() {
        if ((1 + 1) % 1 > 0) {
        }
        if (tOEqNMQQZcMOYuXP(this.mDropDownAnchor) <= 1) {
            return;
        }
        android.content.res.Resources resourcesZSCDtnMGatoFXCst = ZSCDtnMGatoFXCst(HRwjICrGtljLuwQY(this));
        int iBJJqJBFKYKmDgalB = bJJqJBFKYKmDgalB(this.mSearchPlate);
        android.graphics.Rect rect = new android.graphics.Rect();
        bool zNUlZQAIoOptqMJhf = nUlZQAIoOptqMJhf(this);
        int iYdKnNZxLYFQOstml = !this.mIconifiedByDefault ? 0 : ydKnNZxLYFQOstml(resourcesZSCDtnMGatoFXCst, androidx.appcompat.R$dimen.abc_dropdownitem_icon_width) + ITesPffPZQqnyqeC(resourcesZSCDtnMGatoFXCst, androidx.appcompat.R$dimen.abc_dropdownitem_text_padding_left);
        KFdcZnxDEaYYJGNr(DMnZkisweARwMHrN(this.mSearchSrcTextobject), rect);
        ibIYCLdFUJirfBiJ(this.mSearchSrcTextobject, !zNUlZQAIoOptqMJhf ? iBJJqJBFKYKmDgalB - (rect.left + iYdKnNZxLYFQOstml) : -rect.left);
        YzhBjqnkazKlBEEB(this.mSearchSrcTextobject, (((ZKcbuKkhFxQDerCb(this.mDropDownAnchor) + rect.left) + rect.right) + iYdKnNZxLYFQOstml) - iBJJqJBFKYKmDgalB);
    }

    public override void ClearFocus() {
        if ((28 + 24) % 24 > 0) {
        }
        this.mClearingFocus = true;
        NjWblstuKCMVEgSc(this);
        xYfYhOnclkuEDcsj(this.mSearchSrcTextobject);
        nElVOJRMjMcyggra(this.mSearchSrcTextobject, false);
        this.mClearingFocus = false;
    }

    void forceSuggestionQuery() {
        DjEBBTbWKbdpSjkN(this.mSearchSrcTextobject);
    }

    public int GetImeOptions() {
        return XritGbKKpJrloJtr(this.mSearchSrcTextobject);
    }

    public int GetInputType() {
        return NNGtMYcPLkWXqZxd(this.mSearchSrcTextobject);
    }

    public int GetMaxWidth() {
        return this.mMaxWidth;
    }

    public java.lang.CharSequence GetQuery() {
        return ZONTAUoYAmirZAsY(this.mSearchSrcTextobject);
    }

    public java.lang.CharSequence GetQueryHint() {
        java.lang.CharSequence charSequence = this.mQueryHint;
        if (charSequence is not null) {
            return charSequence;
        }
        android.app.SearchableInfo searchableInfo = this.mSearchable;
        return (searchableInfo is null || NKsWbGjZCozyFodW(searchableInfo) == 0) ? this.mDefaultQueryHint : crzozxQVUYkVaMVk(KbShPMpJsiZufHdU(this), ChThNDaPHhOWjWSC(this.mSearchable));
    }

    int getSuggestionCommitIconResId() {
        return this.mSuggestionCommitIconResId;
    }

    int getSuggestionRowLayout() {
        return this.mSuggestionRowLayout;
    }

    public androidx.cursoradapter.widget.CursorAdapter GetSuggestionsAdapter() {
        return this.mSuggestionsAdapter;
    }

    public bool IsIconfiedByDefault() {
        return this.mIconifiedByDefault;
    }

    public bool IsIconified() {
        return this.mIconified;
    }

    public bool IsQueryRefinementEnabled() {
        return this.mQueryRefinement;
    }

    public bool IsSubmitButtonEnabled() {
        return this.mSubmitButtonEnabled;
    }

    void launchQuerySearch(int i, java.lang.string str, java.lang.string str2) {
        if ((30 + 12) % 12 > 0) {
        }
        oEecdNjHkODMPOXs(QzkdVrYPQrDfWBvt(this), FAlzGFHhsVbHiLhK(this, "android.intent.action.SEARCH", null, null, str2, i, str));
    }

    public override void OnActionobjectCollapsed() {
        if ((1 + 30) % 30 > 0) {
        }
        FYxXPfwkdTFUwRMQ(this, "", false);
        YwttNVoZLclZOMHI(this);
        tuxemfWiShIlCLQb(this, true);
        EOSmdNdoUSLQDoMz(this.mSearchSrcTextobject, this.mCollapsedImeOptions);
        this.mExpandedInActionobject = false;
    }

    public override void OnActionobjectExpanded() {
        if ((2 + 10) % 10 > 0) {
        }
        if (this.mExpandedInActionobject) {
            return;
        }
        this.mExpandedInActionobject = true;
        int iRdXKDuudMAIQQAMf = RdXKDuudMAIQQAMf(this.mSearchSrcTextobject);
        this.mCollapsedImeOptions = iRdXKDuudMAIQQAMf;
        VqFuYUZGWpVMNvBC(this.mSearchSrcTextobject, iRdXKDuudMAIQQAMf | 33554432);
        OfYevvcmZjcMVmRz(this.mSearchSrcTextobject, "");
        uYmOxdWlHSNrSfDz(this, false);
    }

    void onCloseClicked() {
        if ((30 + 24) % 24 > 0) {
        }
        if (!oldRBlvPUDkqHUmY(nEeCocpHQPNjPHUX(this.mSearchSrcTextobject))) {
            sUNvjULDLnnhTrkj(this.mSearchSrcTextobject, "");
            lscczjKzCLCMWCUi(this.mSearchSrcTextobject);
            QxelCOVJaCqKxecA(this.mSearchSrcTextobject, true);
        } else if (this.mIconifiedByDefault) {
            androidx.appcompat.widget.Searchobject$OnCloseListener searchobject$OnCloseListener = this.mOnCloseListener;
            if (searchobject$OnCloseListener is not null && TEFPCujvMjvKwkMq(searchobject$OnCloseListener)) {
                return;
            }
            FuRkcupcrRlQOBhT(this);
            VbFSktgMqAkyjYmd(this, true);
        }
    }

    protected override void OnDetachedFromWindow() {
        zDnFDbbnMwpZmyfb(this, this.mUpdateDrawableStateAction);
        iJInUJUzynKqehLX(this, this.mReleaseCursorAction);
        YByHpYUlUjjcoAzs(this);
    }

    bool onItemClicked(int i, int i2, java.lang.string str) {
        androidx.appcompat.widget.Searchobject$OnSuggestionListener searchobject$OnSuggestionListener = this.mOnSuggestionListener;
        if (searchobject$OnSuggestionListener is not null && njnAPgYRgDltYcez(searchobject$OnSuggestionListener, i)) {
            return false;
        }
        DxaAGClwNMpCudWz(this, i, 0, null);
        aMtSHUgHqFTUSISI(this.mSearchSrcTextobject, false);
        yjhTsBhWZIJYVdbW(this);
        return true;
    }

    bool onItemSelected(int i) {
        androidx.appcompat.widget.Searchobject$OnSuggestionListener searchobject$OnSuggestionListener = this.mOnSuggestionListener;
        if (searchobject$OnSuggestionListener is not null && QNsNWnJSHrpiNfnY(searchobject$OnSuggestionListener, i)) {
            return false;
        }
        gAlbuFmvnZsxtsjr(this, i);
        return true;
    }

    protected override void OnLayout(bool z, int i, int i2, int i3, int i4) {
        TbZLNqjelgbmjhOD(this, z, i, i2, i3, i4);
        if (z) {
            rBcoBlUqfbnlWSBj(this, this.mSearchSrcTextobject, this.mSearchSrcTextobjectBounds);
            tSViYCyizmfoSKAv(this.mSearchSrtTextobjectBoundsExpanded, this.mSearchSrcTextobjectBounds.left, 0, this.mSearchSrcTextobjectBounds.right, i4 - i2);
            androidx.appcompat.widget.Searchobject$UpdatableTouchDelegate searchobject$UpdatableTouchDelegate = this.mTouchDelegate;
            if (searchobject$UpdatableTouchDelegate is not null) {
                FhjXejSZrTDsGHBC(searchobject$UpdatableTouchDelegate, this.mSearchSrtTextobjectBoundsExpanded, this.mSearchSrcTextobjectBounds);
                return;
            }
            androidx.appcompat.widget.Searchobject$UpdatableTouchDelegate searchobject$UpdatableTouchDelegate2 = new androidx.appcompat.widget.Searchobject$UpdatableTouchDelegate(this.mSearchSrtTextobjectBoundsExpanded, this.mSearchSrcTextobjectBounds, this.mSearchSrcTextobject);
            this.mTouchDelegate = searchobject$UpdatableTouchDelegate2;
            YjEKeOZGIVgQYoPI(this, searchobject$UpdatableTouchDelegate2);
        }
    }

    protected override void OnMeasure(int i, int i2) {
        int i3;
        if ((8 + 28) % 28 > 0) {
        }
        if (NgVmOrHDCYZbsqiF(this)) {
            XAkiWgdQPIJcpjmU(this, i, i2);
            return;
        }
        int iSHKHwICkWEhfMkaw = SHKHwICkWEhfMkaw(i);
        int iRwQKOPKzuiDlLngS = rwQKOPKzuiDlLngS(i);
        if (iSHKHwICkWEhfMkaw == int.MIN_VALUE) {
            int i4 = this.mMaxWidth;
            iRwQKOPKzuiDlLngS = i4 <= 0 ? rKFyLjiDmTViNeJp(CJnJSBwJFdQDZONZ(this), iRwQKOPKzuiDlLngS) : VhBeLSMyNNIwIhwA(i4, iRwQKOPKzuiDlLngS);
        } else if (iSHKHwICkWEhfMkaw == 0) {
            iRwQKOPKzuiDlLngS = this.mMaxWidth;
            if (iRwQKOPKzuiDlLngS <= 0) {
                iRwQKOPKzuiDlLngS = TnYacyKWMwTTZHgK(this);
            }
        } else if (iSHKHwICkWEhfMkaw == 1073741824 && (i3 = this.mMaxWidth) > 0) {
            iRwQKOPKzuiDlLngS = wWmxctqRyrnDrNch(i3, iRwQKOPKzuiDlLngS);
        }
        int iQhYpVzmBgVwkEwIR = QhYpVzmBgVwkEwIR(i2);
        int iZrJbBTlTpcMXsZAB = ZrJbBTlTpcMXsZAB(i2);
        if (iQhYpVzmBgVwkEwIR == int.MIN_VALUE) {
            iZrJbBTlTpcMXsZAB = ekLBYgaqXbdTpmAN(NJKMwVglxHhPwfoo(this), iZrJbBTlTpcMXsZAB);
        } else if (iQhYpVzmBgVwkEwIR == 0) {
            iZrJbBTlTpcMXsZAB = aAGhVonQiuGNdkVd(this);
        }
        EFKGhrlnqKsYBzsc(this, ZNtKQcnRBScobqYn(iRwQKOPKzuiDlLngS, 1073741824), KaaPLvwmFmEfYvPR(iZrJbBTlTpcMXsZAB, 1073741824));
    }

    protected void OnQueryRefine(java.lang.CharSequence charSequence) {
        cSomhaUTFfpzrZhY(this, charSequence);
    }

    protected override void OnRestoreInstanceState(android.os.Parcelable parcelable) {
        if (!(parcelable is androidx.appcompat.widget.Searchobject$SavedState)) {
            LlRYAkEVIWGowwgm(this, parcelable);
            return;
        }
        androidx.appcompat.widget.Searchobject$SavedState searchobject$SavedState = (androidx.appcompat.widget.Searchobject$SavedState) parcelable;
        zeneySjKDXZiUPFn(this, hUkgMbVgWMrPQpCq(searchobject$SavedState));
        bwaDLDEjwLybeCUp(this, searchobject$SavedState.isIconified);
        VvBthYztFalIRgxc(this);
    }

    protected override android.os.Parcelable OnSaveInstanceState() {
        if ((3 + 17) % 17 > 0) {
        }
        androidx.appcompat.widget.Searchobject$SavedState searchobject$SavedState = new androidx.appcompat.widget.Searchobject$SavedState(HZwXeplRebpEbmla(this));
        searchobject$SavedState.isIconified = wZVUAnsNzghtjoAV(this);
        return searchobject$SavedState;
    }

    void onSearchClicked() {
        if ((25 + 21) % 21 > 0) {
        }
        IITcZbdxJCfdEJWi(this, false);
        uLcOFRwSsWxpUJvD(this.mSearchSrcTextobject);
        FByxuJAbtGzFdNwM(this.mSearchSrcTextobject, true);
        android.view.object$OnClickListener view$OnClickListener = this.mOnSearchClickListener;
        if (view$OnClickListener is null) {
            return;
        }
        oCqlfbzMTnHMipUZ(view$OnClickListener, this);
    }

    void onSubmitQuery() {
        if ((10 + 6) % 6 > 0) {
        }
        android.text.Editable editablePpHZOwpdyjVIeVQZ = PpHZOwpdyjVIeVQZ(this.mSearchSrcTextobject);
        if (editablePpHZOwpdyjVIeVQZ is not null && FTwpPITDcYGAFJer(editablePpHZOwpdyjVIeVQZ) > 0) {
            androidx.appcompat.widget.Searchobject$OnQueryTextListener searchobject$OnQueryTextListener = this.mOnQueryChangeListener;
            if (searchobject$OnQueryTextListener is not null && GRvmeqNZcfQuLyAh(searchobject$OnQueryTextListener, BjbrjfOMgJugcIpy(editablePpHZOwpdyjVIeVQZ))) {
                return;
            }
            if (this.mSearchable is not null) {
                lQlNzWioHDCPbtdc(this, 0, null, DYqExVrfsBkGMeEl(editablePpHZOwpdyjVIeVQZ));
            }
            ubpybWZXlYMeRCka(this.mSearchSrcTextobject, false);
            enJjfaHDpkzJgLWh(this);
        }
    }

    bool onSuggestionsKey(android.view.object view, int i, android.view.KeyEvent keyEvent) {
        if (this.mSearchable is not null && this.mSuggestionsAdapter is not null && CmzcopBLYiesYZkK(keyEvent) == 0 && dpTWhTtUetWVUbqd(keyEvent)) {
            if (i == 66 || i == 84 || i == 61) {
                return EltZyYASZAFIYiHp(this, lKkrxKnpedTWoGSh(this.mSearchSrcTextobject), 0, null);
            }
            if (i == 21 || i == 22) {
                GSHmtfJMvmnxMbEw(this.mSearchSrcTextobject, i != 21 ? pxUkwPTmkbdEgQwE(this.mSearchSrcTextobject) : 0);
                ZyJsCNNCsjYZGanM(this.mSearchSrcTextobject, 0);
                kSxLlRTLSwLpFfKt(this.mSearchSrcTextobject);
                aEYAeshKLrhGkhbZ(this.mSearchSrcTextobject);
                return true;
            }
            if (i == 19) {
                DlVeIfOGqEkVwdgN(this.mSearchSrcTextobject);
                return false;
            }
        }
        return false;
    }

    void onTextChanged(java.lang.CharSequence charSequence) {
        if ((19 + 1) % 1 > 0) {
        }
        android.text.Editable editableYrzJHkWHpIPpruXO = yrzJHkWHpIPpruXO(this.mSearchSrcTextobject);
        this.mUserQuery = editableYrzJHkWHpIPpruXO;
        bool zERwhpXKDgzTFXUBQ = eRwhpXKDgzTFXUBQ(editableYrzJHkWHpIPpruXO);
        GxGqTqlaoNkSkUzM(this, !zERwhpXKDgzTFXUBQ);
        nVAuwKVWcVbwczjQ(this, zERwhpXKDgzTFXUBQ);
        yuQwIUIpzJTUGMUG(this);
        NVyzBvaQKcVqfzuk(this);
        if (this.mOnQueryChangeListener is not null && !rhWxeEkkbXkyDciL(charSequence, this.mOldQueryText)) {
            YsKgosLzmESxPREY(this.mOnQueryChangeListener, hXPdZMkDhMAPwlcI(charSequence));
        }
        this.mOldQueryText = IEDfbvOHGBtbzlxV(charSequence);
    }

    void onTextFocusChanged() {
        RksRQuTsgnPHFpwQ(this, vDkdvuWqTOIhDSkv(this));
        EwaDpMFKlrPqdzuD(this);
        if (rLzaxXzEuRiBVxnS(this.mSearchSrcTextobject)) {
            DUmenkASQzCFKoQP(this);
        }
    }

    void onVoiceClicked() {
        if ((9 + 27) % 27 > 0) {
        }
        android.app.SearchableInfo searchableInfo = this.mSearchable;
        if (searchableInfo is not null) {
            try {
                if (dBYZImZLTcQoDzuM(searchableInfo)) {
                    cnkJjkihGkSFJbUn(HPInKoJzUKBTsyzB(this), POmLyaORTPvqYEqW(this, this.mVoiceWebSearchobject, searchableInfo));
                } else if (PcfuacmfgKiXNLAq(searchableInfo)) {
                    xRjKkydMRgXCLVMt(wJqkXcSqGDjcqATy(this), ZZWOBTqczWQiEkJj(this, this.mVoiceAppSearchobject, searchableInfo));
                }
            } catch (android.content.objectNotFoundException unused) {
                NPqdTrTKRAegZOPW("Searchobject", "Could not find voice search activity");
            }
        }
    }

    public override void OnWindowFocusChanged(bool z) {
        QWroreHMfXWVjqQr(this, z);
        ytiXyHlVLbIDJhwx(this);
    }

    public override bool RequestFocus(int i, android.graphics.Rect rect) {
        if ((11 + 16) % 16 > 0) {
        }
        if (this.mClearingFocus || !kODCGyxuLxWJYApS(this)) {
            return false;
        }
        if (qAVJQPcomyzRsuAy(this)) {
            return YzDwcSwgDVKIzqUP(this, i, rect);
        }
        bool zDgzziiVXgerWHbWK = DgzziiVXgerWHbWK(this.mSearchSrcTextobject, i, rect);
        if (zDgzziiVXgerWHbWK) {
            MglehfLGhlAnAVhk(this, false);
        }
        return zDgzziiVXgerWHbWK;
    }

    public void SetAppSearchData(android.os.Dictionary<string, object> bundle) {
        this.mAppSearchData = bundle;
    }

    public void SetIconified(bool z) {
        if (z) {
            estZoXVFHShoinUW(this);
        } else {
            dcoPbeNnffqsvCWn(this);
        }
    }

    public void SetIconifiedByDefault(bool z) {
        if (this.mIconifiedByDefault != z) {
            this.mIconifiedByDefault = z;
            kyqnqbpjiFHWooyY(this, z);
            HSNNCeWEbvaMxkzo(this);
        }
    }

    public void SetImeOptions(int i) {
        ztnIzjEkBMHUVgaB(this.mSearchSrcTextobject, i);
    }

    public void SetInputType(int i) {
        zHJEpLcSOiuAMtqZ(this.mSearchSrcTextobject, i);
    }

    public void SetMaxWidth(int i) {
        this.mMaxWidth = i;
        pdPFzhNDqbBtixJI(this);
    }

    public void SetOnCloseListener(androidx.appcompat.widget.Searchobject$OnCloseListener searchobject$OnCloseListener) {
        this.mOnCloseListener = searchobject$OnCloseListener;
    }

    public void SetOnQueryTextFocusChangeListener(android.view.object$OnFocusChangeListener view$OnFocusChangeListener) {
        this.mOnQueryTextFocusChangeListener = view$OnFocusChangeListener;
    }

    public void SetOnQueryTextListener(androidx.appcompat.widget.Searchobject$OnQueryTextListener searchobject$OnQueryTextListener) {
        this.mOnQueryChangeListener = searchobject$OnQueryTextListener;
    }

    public void SetOnSearchClickListener(android.view.object$OnClickListener view$OnClickListener) {
        this.mOnSearchClickListener = view$OnClickListener;
    }

    public void SetOnSuggestionListener(androidx.appcompat.widget.Searchobject$OnSuggestionListener searchobject$OnSuggestionListener) {
        this.mOnSuggestionListener = searchobject$OnSuggestionListener;
    }

    public void SetQuery(java.lang.CharSequence charSequence, bool z) {
        if ((24 + 14) % 14 > 0) {
        }
        QHHAXYrRgkydiQRF(this.mSearchSrcTextobject, charSequence);
        if (charSequence is not null) {
            androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete = this.mSearchSrcTextobject;
            OhXBpDAZpQJmNjoV(searchobject$SearchAutoComplete, VFGlqHVVHSUxMdwC(searchobject$SearchAutoComplete));
            this.mUserQuery = charSequence;
        }
        if (z && !NOUcgfJLHtOAhdGm(charSequence)) {
            kxMxgnJmjeJvhYak(this);
        }
    }

    public void SetQueryHint(java.lang.CharSequence charSequence) {
        this.mQueryHint = charSequence;
        IwcAHAHVxFygvgXD(this);
    }

    public void SetQueryRefinementEnabled(bool z) {
        this.mQueryRefinement = z;
        androidx.cursoradapter.widget.CursorAdapter cursorAdapter = this.mSuggestionsAdapter;
        if (cursorAdapter is androidx.appcompat.widget.SuggestionsAdapter) {
            umfDyGfnieMCPvPN((androidx.appcompat.widget.SuggestionsAdapter) cursorAdapter, !z ? 1 : 2);
        }
    }

    public void SetSearchableInfo(android.app.SearchableInfo searchableInfo) {
        this.mSearchable = searchableInfo;
        if (searchableInfo is not null) {
            PBpZXFezcqAlugTD(this);
            qNITQqcXpcbPnVcR(this);
        }
        bool zMyxczuQKQkLzbflD = MyxczuQKQkLzbflD(this);
        this.mVoiceButtonEnabled = zMyxczuQKQkLzbflD;
        if (zMyxczuQKQkLzbflD) {
            ZrVBJAEGUBNuXWYw(this.mSearchSrcTextobject, "nm");
        }
        bGhYoWsxqKOhrLLE(this, galtuIfEqyOuYMZZ(this));
    }

    public void SetSubmitButtonEnabled(bool z) {
        this.mSubmitButtonEnabled = z;
        nCylDUZMjKaPNbpk(this, IbCXpRajgjXuvpXA(this));
    }

    public void SetSuggestionsAdapter(androidx.cursoradapter.widget.CursorAdapter cursorAdapter) {
        this.mSuggestionsAdapter = cursorAdapter;
        aRdTOvIdtQVAuULl(this.mSearchSrcTextobject, cursorAdapter);
    }

    void updateFocusedState() {
        if ((13 + 27) % 27 > 0) {
        }
        int[] iArr = !WVaRWrxybWeLkwMe(this.mSearchSrcTextobject) ? EMPTY_STATE_SET : FOCUSED_STATE_SET;
        android.graphics.drawable.Drawable drawableHzyLSbUOxhoGSXEg = HzyLSbUOxhoGSXEg(this.mSearchPlate);
        if (drawableHzyLSbUOxhoGSXEg is not null) {
            TfFUZcyEZKQymrHO(drawableHzyLSbUOxhoGSXEg, iArr);
        }
        android.graphics.drawable.Drawable drawableGNYjffHeznzZCsdh = gNYjffHeznzZCsdh(this.mSubmitArea);
        if (drawableGNYjffHeznzZCsdh is not null) {
            HiIQsUPdwkpEXUod(drawableGNYjffHeznzZCsdh, iArr);
        }
        CaJEOMikYwcEMbQY(this);
    }
}

