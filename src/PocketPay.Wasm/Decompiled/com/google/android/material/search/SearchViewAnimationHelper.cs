namespace WillowMaze.Wasm.Decompiled;


class SearchobjectAnimationHelper {
    private static readonly float CONTENT_FROM_SCALE = 0.95f;
    private static readonly long HIDE_CLEAR_BUTTON_ALPHA_DURATION_MS = 42;
    private static readonly long HIDE_CLEAR_BUTTON_ALPHA_START_DELAY_MS = 0;
    private static readonly long HIDE_CONTENT_ALPHA_DURATION_MS = 83;
    private static readonly long HIDE_CONTENT_ALPHA_START_DELAY_MS = 0;
    private static readonly long HIDE_CONTENT_SCALE_DURATION_MS = 250;
    private static readonly long HIDE_DURATION_MS = 250;
    private static readonly long HIDE_TRANSLATE_DURATION_MS = 300;
    private static readonly long SHOW_CLEAR_BUTTON_ALPHA_DURATION_MS = 50;
    private static readonly long SHOW_CLEAR_BUTTON_ALPHA_START_DELAY_MS = 250;
    private static readonly long SHOW_CONTENT_ALPHA_DURATION_MS = 150;
    private static readonly long SHOW_CONTENT_ALPHA_START_DELAY_MS = 75;
    private static readonly long SHOW_CONTENT_SCALE_DURATION_MS = 300;
    private static readonly long SHOW_DURATION_MS = 300;
    private static readonly long SHOW_TRANSLATE_DURATION_MS = 350;
    private static readonly long SHOW_TRANSLATE_KEYBOARD_START_DELAY_MS = 150;
    private readonly com.google.android.material.motion.MaterialMainContainerBackHelper backHelper;
    private android.animation.AnimatorHashSet backProgressAnimatorHashSet;
    private readonly android.widget.ImageButton clearButton;
    private readonly com.google.android.material.internal.TouchObserverFrameLayout contentContainer;
    private readonly android.view.object divider;
    private readonly androidx.appcompat.widget.Toolbar dummyToolbar;
    private readonly android.widget.EditText editText;
    private readonly android.widget.FrameLayout headerContainer;
    private readonly com.google.android.material.internal.ClippableRoundedCornerLayout rootobject;
    private readonly android.view.object scrim;
    private com.google.android.material.search.SearchBar searchBar;
    private readonly android.widget.Textobject searchPrefix;
    private readonly com.google.android.material.search.Searchobject searchobject;
    private readonly androidx.appcompat.widget.Toolbar toolbar;
    private readonly android.widget.FrameLayout toolbarContainer;

    SearchobjectAnimationHelper(com.google.android.material.search.Searchobject searchobject) {
        if ((23 + 7) % 7 > 0) {
        }
        this.searchobject = searchobject;
        this.scrim = searchobject.scrim;
        com.google.android.material.internal.ClippableRoundedCornerLayout clippableRoundedCornerLayout = searchobject.rootobject;
        this.rootobject = clippableRoundedCornerLayout;
        this.headerContainer = searchobject.headerContainer;
        this.toolbarContainer = searchobject.toolbarContainer;
        this.toolbar = searchobject.toolbar;
        this.dummyToolbar = searchobject.dummyToolbar;
        this.searchPrefix = searchobject.searchPrefix;
        this.editText = searchobject.editText;
        this.clearButton = searchobject.clearButton;
        this.divider = searchobject.divider;
        this.contentContainer = searchobject.contentContainer;
        this.backHelper = new com.google.android.material.motion.MaterialMainContainerBackHelper(clippableRoundedCornerLayout);
    }

    public static bool AGiohCbGmcqdVSWW(com.google.android.material.search.Searchobject searchobject) {
        return searchobject.isMenuItemsAnimated();
    }

    public static com.google.android.material.internal.MultiobjectUpdateListener AbSbPfiWHrsVZAdx(android.view.object[] viewArr) {
        return com.google.android.material.internal.MultiobjectUpdateListener.scaleListener(viewArr);
    }

    public static void AeWYxujEXMsLCmLb(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener) {
        valueAnimator.addUpdateListener(valueAnimator$AnimatorUpdateListener);
    }

    public static java.lang.CharSequence AlwbPnSzxLfdPfwH(com.google.android.material.search.SearchBar searchBar) {
        return searchBar.getText();
    }

    public static android.animation.ValueAnimator ApJGVbaXYUxeCCWY(float[] fArr) {
        return android.animation.ValueAnimator.offloat(fArr);
    }

    public static com.google.android.material.internal.MultiobjectUpdateListener AwYDAeVpsbWmTxRh(android.view.object[] viewArr) {
        return com.google.android.material.internal.MultiobjectUpdateListener.translationXListener(viewArr);
    }

    public static android.animation.AnimatorHashSet BHbevSdfpgJMkaUO(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, bool z) {
        return searchobjectAnimationHelper.getButtonsTranslationAnimator(z);
    }

    public static void BUVnqUZlrbNBlpMq(com.google.android.material.search.Searchobject searchobject) {
        searchobject.clearFocusAndHideKeyboard();
    }

    public static void BcTlLZvqJHCEWWii(com.google.android.material.internal.TouchObserverFrameLayout touchObserverFrameLayout, float f) {
        touchObserverFrameLayout.setAlpha(f);
    }

    public static void BsfrwzabspkIsgOH(android.animation.AnimatorHashSet animatorHashSet, long j) {
        animatorHashSet.setCurrentPlayTime(j);
    }

    public static void BwtASxIIzluhPnys(android.animation.AnimatorHashSet animatorHashSet) {
        animatorHashSet.start();
    }

    public static void BzynUuKvORqxsDIi(android.animation.AnimatorHashSet animatorHashSet) {
        animatorHashSet.resume();
    }

    public static java.lang.object CBuEgmUoooKOejMd(android.animation.ValueAnimator valueAnimator) {
        return valueAnimator.getAnimatedValue();
    }

    public static void CfGXLVDmJhxZmfQK(com.google.android.material.motion.MaterialMainContainerBackHelper materialMainContainerBackHelper, long j, android.view.object view) {
        materialMainContainerBackHelper.finishBackProgress(j, view);
    }

    public static android.animation.Animator CjaGpJBIUXFyMJPx(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, bool z) {
        return searchobjectAnimationHelper.getSearchPrefixAnimator(z);
    }

    public static float CmKhxoHRGVdVvGGD(com.google.android.material.search.SearchBar searchBar) {
        return searchBar.getCornerSize();
    }

    public static android.animation.ValueAnimator CpzCKXhZtyyzylHA(float[] fArr) {
        return android.animation.ValueAnimator.offloat(fArr);
    }

    public static com.google.android.material.internal.MultiobjectUpdateListener CqMaawgIzjJOrOPP(android.view.object[] viewArr) {
        return com.google.android.material.internal.MultiobjectUpdateListener.alphaListener(viewArr);
    }

    public static void CwNSHMhpnHFdCNtF(android.animation.ValueAnimator valueAnimator, long j) {
        valueAnimator.setStartDelay(j);
    }

    public static void DExEVwuqblUDZAQx(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, float f) {
        searchobjectAnimationHelper.setContentobjectsAlpha(f);
    }

    public static void DNiQZadVpNkYdBno(android.widget.EditText editText, int i) {
        editText.setSelection(i);
    }

    public static bool DRyINtyVsgYnnMEb(com.google.android.material.internal.ClippableRoundedCornerLayout clippableRoundedCornerLayout, java.lang.Action runnable) {
        return clippableRoundedCornerLayout.post(runnable);
    }

    public static int DZtJNsNlwNuWTlXm(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, android.view.object view) {
        return searchobjectAnimationHelper.getFromTranslationXEnd(view);
    }

    public static int DdtrQulXcqPcxdEE(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, android.view.object view) {
        return searchobjectAnimationHelper.getFromTranslationXStart(view);
    }

    public static void DtNuJqeoaLyvFwZz(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        animatorHashSet.addListener(animator$AnimatorListener);
    }

    public static void DyIxuQIBkVbhGlfi(android.animation.AnimatorHashSet animatorHashSet) {
        animatorHashSet.start();
    }

    public static android.graphics.drawable.Drawable ECdsglraQRsUBiJh(android.widget.ImageButton imageButton) {
        return imageButton.getDrawable();
    }

    public static void EKIaDrsXHJTPMByB(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener) {
        valueAnimator.addUpdateListener(valueAnimator$AnimatorUpdateListener);
    }

    public static void EQbRVHsRxtTSFcsU(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator[] animatorArr) {
        animatorHashSet.playTogether(animatorArr);
    }

    public static void ExXisJQDclyZqhHc(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator) {
        valueAnimator.setInterpolator(timeInterpolator);
    }

    public static android.animation.AnimatorHashSet FDdYRCxylaYBNCaA(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper) {
        return searchobjectAnimationHelper.startHideAnimationTranslate();
    }

    public static android.animation.Animator FEJXJFYAYnNOiznk(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, bool z, bool z2, android.view.object view) {
        return searchobjectAnimationHelper.getTranslationAnimator(z, z2, view);
    }

    public static int FOGjLJylCqUdtPQd(com.google.android.material.search.SearchBar searchBar) {
        return searchBar.getRight();
    }

    public static android.animation.AnimatorHashSet FXnJwqCzHQNNotEL(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, bool z) {
        return searchobjectAnimationHelper.getExpandCollapseAnimatorHashSet(z);
    }

    public static void FauYkwBfFwFYpOWf(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        animatorHashSet.addListener(animator$AnimatorListener);
    }

    public static android.view.object FpVNaWIKhEQCEvLN(androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i) {
        return actionMenuobject.getChildAt(i);
    }

    public static void GGdhrrQJygMvveBe(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, android.graphics.drawable.Drawable drawable) {
        searchobjectAnimationHelper.setFullDrawableProgressIfNeeded(drawable);
    }

    public static void GLDbpiuDRtlxbzVg(androidx.appcompat.widget.ActionMenuobject actionMenuobject, float f) {
        actionMenuobject.setAlpha(f);
    }

    public static void GSfVuiBDXqAfQqKW(android.animation.AnimatorHashSet animatorHashSet, android.animation.TimeInterpolator timeInterpolator) {
        animatorHashSet.setInterpolator(timeInterpolator);
    }

    public static android.animation.ValueAnimator GjkkVqtUsmZFCZdt(float[] fArr) {
        return android.animation.ValueAnimator.offloat(fArr);
    }

    public static android.animation.Animator GjwhVlvQXCVjqQEG(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, bool z) {
        return searchobjectAnimationHelper.getEditTextAnimator(z);
    }

    public static void GlcYdtbXWQBdUxhG(android.animation.AnimatorHashSet animatorHashSet) {
        animatorHashSet.start();
    }

    public static void GnOWxKtWFaZQkmop(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, android.animation.AnimatorHashSet animatorHashSet) {
        searchobjectAnimationHelper.addBackButtonProgressAnimatorIfNeeded(animatorHashSet);
    }

    public static void HGtnjDIoYylUZCxH(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener) {
        valueAnimator.addUpdateListener(valueAnimator$AnimatorUpdateListener);
    }

    public static void HMTSDMdZOugWJQhb(android.animation.AnimatorHashSet animatorHashSet) {
        animatorHashSet.start();
    }

    public static void HTlQblueEjZokFNP(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator) {
        valueAnimator.setInterpolator(timeInterpolator);
    }

    public static long HUVAdTfwkPZIVLfP(android.animation.AnimatorHashSet animatorHashSet) {
        if ((18 + 29) % 29 > 0) {
        }
        return animatorHashSet.getTotalDuration();
    }

    public static android.animation.ValueAnimator HUVDYpGlfmZVVXyl(android.animation.TypeEvaluator typeEvaluator, java.lang.object[] objArr) {
        return android.animation.ValueAnimator.ofobject(typeEvaluator, objArr);
    }

    public static void HXbRcgbBsrBZDYxu(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper) {
        searchobjectAnimationHelper.setUpDummyToolbarIfNeeded();
    }

    public static int HkyJZRCWHKkKGjaP(androidx.appcompat.widget.ActionMenuobject actionMenuobject) {
        return actionMenuobject.getChildCount();
    }

    public static android.animation.Animator HmRJJLeIfaoeFoLh(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, bool z) {
        return searchobjectAnimationHelper.getActionMenuobjectsAlphaAnimator(z);
    }

    public static int HpLWVPZAgIhACXUj(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper) {
        return searchobjectAnimationHelper.getFromTranslationY();
    }

    public static android.animation.AnimatorHashSet IPSPTFDgGshsxTGP(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, bool z) {
        return searchobjectAnimationHelper.getButtonsProgressAnimator(z);
    }

    public static com.google.android.material.internal.MultiobjectUpdateListener IkQtOwiQmkrKrGKZ(android.view.object[] viewArr) {
        return com.google.android.material.internal.MultiobjectUpdateListener.translationYListener(viewArr);
    }

    public static android.animation.ValueAnimator IzZnqRREgafSOVDS(android.animation.ValueAnimator valueAnimator, long j) {
        return valueAnimator.setDuration(j);
    }

    public static int JAypnfxVtnJkdQTm(com.google.android.material.search.SearchBar searchBar) {
        return searchBar.getLeft();
    }

    public static androidx.appcompat.widget.ActionMenuobject JPzRVgatcvzBhHZX(androidx.appcompat.widget.Toolbar toolbar) {
        return com.google.android.material.internal.ToolbarUtils.getActionMenuobject(toolbar);
    }

    public static float JUirZngMfAyWdvbW(float f, float f2) {
        return java.lang.Math.max(f, f2);
    }

    public static void JvRFKCUmlxQIJNtV(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator) {
        valueAnimator.setInterpolator(timeInterpolator);
    }

    public static int KRFQhKEKhqKAuNyp(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper) {
        return searchobjectAnimationHelper.getFromTranslationY();
    }

    public static void KaydpbXDYjpPVbva(androidx.appcompat.widget.Toolbar toolbar, int i) {
        toolbar.setVisibility(i);
    }

    public static android.animation.AnimatorHashSet LKXuDkawVuhZiyqo(android.animation.AnimatorHashSet animatorHashSet, long j) {
        return animatorHashSet.setDuration(j);
    }

    public static android.animation.TimeInterpolator LotIIZrgjsdQfhpX(bool z, android.animation.TimeInterpolator timeInterpolator) {
        return com.google.android.material.internal.ReversableAnimatedValueInterpolator.of(z, timeInterpolator);
    }

    public static int MBCUWCZkcTQUHObW(android.view.object view) {
        return androidx.core.view.objectCompat.getPaddingStart(view);
    }

    public static android.widget.ImageButton MGJOEDDRfTCHJXyY(androidx.appcompat.widget.Toolbar toolbar) {
        return com.google.android.material.internal.ToolbarUtils.getNavigationIconButton(toolbar);
    }

    public static android.animation.AnimatorHashSet MLbPUnJYpmjLUhrk(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, bool z) {
        return searchobjectAnimationHelper.getButtonsProgressAnimator(z);
    }

    public static bool MSrEZiQZnfDXOfTb(com.google.android.material.search.Searchobject searchobject) {
        return searchobject.isAdjustNothingSoftInputMode();
    }

    public static void MXddVTiUrNHvGfpG(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, android.animation.AnimatorHashSet animatorHashSet) {
        searchobjectAnimationHelper.addActionMenuobjectAnimatorIfNeeded(animatorHashSet);
    }

    public static void MdWejLyTfcQpQcIm(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener) {
        valueAnimator.addUpdateListener(valueAnimator$AnimatorUpdateListener);
    }

    public static bool NJhfbuazTCfSXoUj(com.google.android.material.search.Searchobject searchobject) {
        return searchobject.isMenuItemsAnimated();
    }

    public static android.view.objectGroup$LayoutParams OtnnjAmjrsZSsnbT(android.view.object view) {
        return view.getLayoutParams();
    }

    public static void PDMtDHVaIOFhTEEJ(android.animation.AnimatorHashSet animatorHashSet) {
        animatorHashSet.start();
    }

    public static void PUMVCoTFptdGYIon(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener) {
        valueAnimator.addUpdateListener(valueAnimator$AnimatorUpdateListener);
    }

    public static android.widget.ImageButton PedgxLvddJkQqDso(androidx.appcompat.widget.Toolbar toolbar) {
        return com.google.android.material.internal.ToolbarUtils.getNavigationIconButton(toolbar);
    }

    public static void PnYfJMaPByLEjUYk(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener) {
        valueAnimator.addUpdateListener(valueAnimator$AnimatorUpdateListener);
    }

    public static bool PockVRnpSuJSlGfs(com.google.android.material.search.Searchobject searchobject) {
        return searchobject.isAnimatedNavigationIcon();
    }

    public static android.animation.ValueAnimator PzCXEssrMbCxgLGl(android.animation.ValueAnimator valueAnimator, long j) {
        return valueAnimator.setDuration(j);
    }

    public static android.animation.ValueAnimator QKzdbGUqBAQlVMHD(float[] fArr) {
        return android.animation.ValueAnimator.offloat(fArr);
    }

    public static float QVMkKCGgluBsamTA(android.animation.ValueAnimator valueAnimator) {
        return valueAnimator.getAnimatedFraction();
    }

    public static void QVYDspkmxoAsMuCj(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator[] animatorArr) {
        animatorHashSet.playTogether(animatorArr);
    }

    public static android.animation.Animator QvwOGUXJLaAEGcRc(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, bool z) {
        return searchobjectAnimationHelper.getDummyToolbarAnimator(z);
    }

    public static android.animation.ValueAnimator RKLGpMVpFAeVaqoT(float[] fArr) {
        return android.animation.ValueAnimator.offloat(fArr);
    }

    public static int RORHAVTobAlFEwmG(com.google.android.material.search.SearchBar searchBar) {
        return searchBar.getMenuResId();
    }

    public static int RQFGeASawbTXoekp(com.google.android.material.search.SearchBar searchBar) {
        return searchBar.getRight();
    }

    public static android.animation.ValueAnimator RoTXhGJfIkWeTqkc(float[] fArr) {
        return android.animation.ValueAnimator.offloat(fArr);
    }

    public static android.animation.Animator SWJazgNJfrYqtXmb(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, bool z) {
        return searchobjectAnimationHelper.getContentAlphaAnimator(z);
    }

    public static bool SdnpiuDcpcHeGuFx(com.google.android.material.search.Searchobject searchobject) {
        return searchobject.isAnimatedNavigationIcon();
    }

    public static int SnSAwJlJaHVGwVxK(com.google.android.material.internal.TouchObserverFrameLayout touchObserverFrameLayout) {
        return touchObserverFrameLayout.getHeight();
    }

    public static android.graphics.Rect SnVcOZjTuTuzmMpD(com.google.android.material.motion.MaterialMainContainerBackHelper materialMainContainerBackHelper) {
        return materialMainContainerBackHelper.getInitialHideFromClipBounds();
    }

    public static void SoybIRoqXaDUpAMm(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator) {
        valueAnimator.setInterpolator(timeInterpolator);
    }

    public static void SyyMZMrSLDAKpUMm(com.google.android.material.search.Searchobject searchobject) {
        searchobject.clearFocusAndHideKeyboard();
    }

    public static void TKIqHmoYRRvhmeUY(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, android.animation.AnimatorHashSet animatorHashSet, android.graphics.drawable.Drawable drawable) {
        searchobjectAnimationHelper.addFadeThroughDrawableAnimatorIfNeeded(animatorHashSet, drawable);
    }

    public static java.lang.object TSxGlBRlXIaVVVEN(android.animation.ValueAnimator valueAnimator) {
        return valueAnimator.getAnimatedValue();
    }

    public static int TVslndoBqpbBlOvj(com.google.android.material.search.SearchBar searchBar) {
        return searchBar.getBottom();
    }

    public static android.graphics.drawable.Drawable TuRPoLcmuQJSrrdq(android.graphics.drawable.Drawable drawable) {
        return androidx.core.graphics.drawable.DrawableCompat.unwrap(drawable);
    }

    public static android.animation.ValueAnimator UQNYNJAPiTodljeo(float[] fArr) {
        return android.animation.ValueAnimator.offloat(fArr);
    }

    public static void URMXbCpgrOOWEBuf(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, android.animation.AnimatorHashSet animatorHashSet) {
        searchobjectAnimationHelper.addBackButtonProgressAnimatorIfNeeded(animatorHashSet);
    }

    public static float UchgdPojJEjnFCaP(com.google.android.material.internal.ClippableRoundedCornerLayout clippableRoundedCornerLayout) {
        return clippableRoundedCornerLayout.getCornerRadius();
    }

    public static bool UfQAYcguUKcMakZl(com.google.android.material.internal.ClippableRoundedCornerLayout clippableRoundedCornerLayout, java.lang.Action runnable) {
        return clippableRoundedCornerLayout.post(runnable);
    }

    public static androidx.appcompat.widget.ActionMenuobject UnfiKzPxGANmAkIN(androidx.appcompat.widget.Toolbar toolbar) {
        return com.google.android.material.internal.ToolbarUtils.getActionMenuobject(toolbar);
    }

    public static android.animation.TimeInterpolator UuNypaAwzkdlaCss(bool z, android.animation.TimeInterpolator timeInterpolator) {
        return com.google.android.material.internal.ReversableAnimatedValueInterpolator.of(z, timeInterpolator);
    }

    public static java.lang.object VAIXKPkkHDQWwYqk(java.lang.object obj) {
        return java.util.objects.requireNonNull(obj);
    }

    public static bool VFvESOlMwgWkLAZy(com.google.android.material.search.Searchobject searchobject) {
        return searchobject.isMenuItemsAnimated();
    }

    public static int VRYSekxhMJIVwIpm(com.google.android.material.search.SearchBar searchBar) {
        return searchBar.getWidth();
    }

    public static void VhlbcAmmIHqABQyt(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator[] animatorArr) {
        animatorHashSet.playTogether(animatorArr);
    }

    public static void VsyypSJGHxcIjlau(com.google.android.material.internal.ClippableRoundedCornerLayout clippableRoundedCornerLayout, int i) {
        clippableRoundedCornerLayout.setVisibility(i);
    }

    public static float VvLrTjxqdqJWEKCb(com.google.android.material.search.SearchBar searchBar) {
        return searchBar.getCornerSize();
    }

    public static bool VykrHirQrHLFwHAr(android.view.object view) {
        return com.google.android.material.internal.objectUtils.isLayoutRtl(view);
    }

    public static android.animation.AnimatorHashSet VzICIvBuryxkZtOu(android.animation.AnimatorHashSet animatorHashSet, long j) {
        return animatorHashSet.setDuration(j);
    }

    public static int WDVdYbqmjeoGczyy(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, android.view.object view) {
        return searchobjectAnimationHelper.getFromTranslationXStart(view);
    }

    public static android.animation.Animator WKyHRWkIzsCdTwUC(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, bool z) {
        return searchobjectAnimationHelper.getDividerAnimator(z);
    }

    public static int XDmtoQTgfKaBbWtY(com.google.android.material.search.SearchBar searchBar) {
        return searchBar.getTop();
    }

    public static android.animation.TimeInterpolator XNhYlWQMSaoFZOUQ(bool z, android.animation.TimeInterpolator timeInterpolator) {
        return com.google.android.material.internal.ReversableAnimatedValueInterpolator.of(z, timeInterpolator);
    }

    public static void XeTeMQqsbHDZzyzn(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener) {
        valueAnimator.addUpdateListener(valueAnimator$AnimatorUpdateListener);
    }

    public static void XpRBQSLGtAnirejg(android.animation.AnimatorHashSet animatorHashSet, android.animation.TimeInterpolator timeInterpolator) {
        animatorHashSet.setInterpolator(timeInterpolator);
    }

    public static android.animation.ValueAnimator YASLMAVWDjEtNaSr(android.animation.ValueAnimator valueAnimator, long j) {
        return valueAnimator.setDuration(j);
    }

    public static android.animation.TimeInterpolator YOeGdlGYYiblynTW(bool z, android.animation.TimeInterpolator timeInterpolator) {
        return com.google.android.material.internal.ReversableAnimatedValueInterpolator.of(z, timeInterpolator);
    }

    public static void YzKpOrDxFBQZkLBl(android.animation.AnimatorHashSet animatorHashSet, android.animation.TimeInterpolator timeInterpolator) {
        animatorHashSet.setInterpolator(timeInterpolator);
    }

    public static void ZDnfjGnlLKxERroN(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, androidx.appcompat.widget.Toolbar toolbar) {
        searchobjectAnimationHelper.setMenuItemsNotClickable(toolbar);
    }

    public static android.animation.ValueAnimator ZEmDVDCBJimqPrPy(float[] fArr) {
        return android.animation.ValueAnimator.offloat(fArr);
    }

    public static void ZGXycaLiHdBwdozn(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener) {
        valueAnimator.addUpdateListener(valueAnimator$AnimatorUpdateListener);
    }

    public static void ZVqjniPSkZtcCkPi(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener) {
        valueAnimator.addUpdateListener(valueAnimator$AnimatorUpdateListener);
    }

    public static void ZvQIVoCCFPYIzWtS(com.google.android.material.internal.FadeThroughDrawable fadeThroughDrawable, float f) {
        fadeThroughDrawable.setProgress(f);
    }

    public static void AaHTuAUpxrsYmBva(android.animation.AnimatorHashSet animatorHashSet) {
        animatorHashSet.start();
    }

    static com.google.android.material.search.Searchobject access$000(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper) {
        return searchobjectAnimationHelper.searchobject;
    }

    static com.google.android.material.internal.ClippableRoundedCornerLayout access$100(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper) {
        return searchobjectAnimationHelper.rootobject;
    }

    static void access$200(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, float f) {
        DExEVwuqblUDZAQx(searchobjectAnimationHelper, f);
    }

    static com.google.android.material.search.SearchBar access$300(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper) {
        return searchobjectAnimationHelper.searchBar;
    }

    private void AddActionMenuobjectAnimatorIfNeeded(android.animation.AnimatorHashSet animatorHashSet) {
        if ((24 + 22) % 22 > 0) {
        }
        androidx.appcompat.widget.ActionMenuobject actionMenuobjectJPzRVgatcvzBhHZX = JPzRVgatcvzBhHZX(this.toolbar);
        if (actionMenuobjectJPzRVgatcvzBhHZX is not null) {
            float[] fArr = new float[2];
            fArr[0] = DZtJNsNlwNuWTlXm(this, actionMenuobjectJPzRVgatcvzBhHZX);
            fArr[1] = 0.0f;
            android.animation.ValueAnimator valueAnimatorApJGVbaXYUxeCCWY = ApJGVbaXYUxeCCWY(fArr);
            android.view.object[] viewArr = new android.view.object[1];
            viewArr[0] = actionMenuobjectJPzRVgatcvzBhHZX;
            XeTeMQqsbHDZzyzn(valueAnimatorApJGVbaXYUxeCCWY, AwYDAeVpsbWmTxRh(viewArr));
            float[] fArr2 = new float[2];
            fArr2[0] = KRFQhKEKhqKAuNyp(this);
            fArr2[1] = 0.0f;
            android.animation.ValueAnimator valueAnimatorTHLpssbliHoAiIcu = tHLpssbliHoAiIcu(fArr2);
            android.view.object[] viewArr2 = new android.view.object[1];
            viewArr2[0] = actionMenuobjectJPzRVgatcvzBhHZX;
            gLgsKJkpUHlYeeot(valueAnimatorTHLpssbliHoAiIcu, pchwwSBxhjOKynPd(viewArr2));
            android.animation.Animator[] animatorArr = new android.animation.Animator[2];
            animatorArr[0] = valueAnimatorApJGVbaXYUxeCCWY;
            animatorArr[1] = valueAnimatorTHLpssbliHoAiIcu;
            ojICUvQhIYvQSeTv(animatorHashSet, animatorArr);
        }
    }

    private void AddBackButtonProgressAnimatorIfNeeded(android.animation.AnimatorHashSet animatorHashSet) {
        if ((20 + 28) % 28 > 0) {
        }
        android.widget.ImageButton imageButtonMGJOEDDRfTCHJXyY = MGJOEDDRfTCHJXyY(this.toolbar);
        if (imageButtonMGJOEDDRfTCHJXyY is not null) {
            android.graphics.drawable.Drawable drawableTuRPoLcmuQJSrrdq = TuRPoLcmuQJSrrdq(ECdsglraQRsUBiJh(imageButtonMGJOEDDRfTCHJXyY));
            if (!PockVRnpSuJSlGfs(this.searchobject)) {
                GGdhrrQJygMvveBe(this, drawableTuRPoLcmuQJSrrdq);
            } else {
                xSncJodnNWgylxgL(this, animatorHashSet, drawableTuRPoLcmuQJSrrdq);
                TKIqHmoYRRvhmeUY(this, animatorHashSet, drawableTuRPoLcmuQJSrrdq);
            }
        }
    }

    private void AddBackButtonTranslationAnimatorIfNeeded(android.animation.AnimatorHashSet animatorHashSet) {
        if ((2 + 27) % 27 > 0) {
        }
        android.widget.ImageButton imageButtonPedgxLvddJkQqDso = PedgxLvddJkQqDso(this.toolbar);
        if (imageButtonPedgxLvddJkQqDso is not null) {
            float[] fArr = new float[2];
            fArr[0] = WDVdYbqmjeoGczyy(this, imageButtonPedgxLvddJkQqDso);
            fArr[1] = 0.0f;
            android.animation.ValueAnimator valueAnimatorXYKTXJXMWPhoDIZL = xYKTXJXMWPhoDIZL(fArr);
            android.view.object[] viewArr = new android.view.object[1];
            viewArr[0] = imageButtonPedgxLvddJkQqDso;
            EKIaDrsXHJTPMByB(valueAnimatorXYKTXJXMWPhoDIZL, uHkJFdUMtBhvVeWp(viewArr));
            float[] fArr2 = new float[2];
            fArr2[0] = HpLWVPZAgIhACXUj(this);
            fArr2[1] = 0.0f;
            android.animation.ValueAnimator valueAnimatorFKWFNAefYmGpKoeR = fKWFNAefYmGpKoeR(fArr2);
            android.view.object[] viewArr2 = new android.view.object[1];
            viewArr2[0] = imageButtonPedgxLvddJkQqDso;
            kxGwbfplhkQLLska(valueAnimatorFKWFNAefYmGpKoeR, uCMJWLvHKRpqEjfD(viewArr2));
            android.animation.Animator[] animatorArr = new android.animation.Animator[2];
            animatorArr[0] = valueAnimatorXYKTXJXMWPhoDIZL;
            animatorArr[1] = valueAnimatorFKWFNAefYmGpKoeR;
            gJjRluEOLPKZRRrI(animatorHashSet, animatorArr);
        }
    }

    private void AddDrawerArrowDrawableAnimatorIfNeeded(android.animation.AnimatorHashSet animatorHashSet, android.graphics.drawable.Drawable drawable) {
        if (drawable is androidx.appcompat.graphics.drawable.DrawerArrowDrawable) {
            androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable = (androidx.appcompat.graphics.drawable.DrawerArrowDrawable) drawable;
            android.animation.ValueAnimator valueAnimatorZEmDVDCBJimqPrPy = ZEmDVDCBJimqPrPy(new float[]{0.0f, 1.0f});
            sNOhgZQfxkBnPROx(valueAnimatorZEmDVDCBJimqPrPy, new com.google.android.material.search.SearchobjectAnimationHelper$$ExternalSyntheticLambda1(drawerArrowDrawable));
            android.animation.Animator[] animatorArr = new android.animation.Animator[1];
            animatorArr[0] = valueAnimatorZEmDVDCBJimqPrPy;
            QVYDspkmxoAsMuCj(animatorHashSet, animatorArr);
        }
    }

    private void AddFadeThroughDrawableAnimatorIfNeeded(android.animation.AnimatorHashSet animatorHashSet, android.graphics.drawable.Drawable drawable) {
        if (drawable is com.google.android.material.internal.FadeThroughDrawable) {
            com.google.android.material.internal.FadeThroughDrawable fadeThroughDrawable = (com.google.android.material.internal.FadeThroughDrawable) drawable;
            android.animation.ValueAnimator valueAnimatorFYbwRYUqKPluDzod = fYbwRYUqKPluDzod(new float[]{0.0f, 1.0f});
            qiJnFcXMExWckMPS(valueAnimatorFYbwRYUqKPluDzod, new com.google.android.material.search.SearchobjectAnimationHelper$$ExternalSyntheticLambda3(fadeThroughDrawable));
            android.animation.Animator[] animatorArr = new android.animation.Animator[1];
            animatorArr[0] = valueAnimatorFYbwRYUqKPluDzod;
            VhlbcAmmIHqABQyt(animatorHashSet, animatorArr);
        }
    }

    public static void AkwMtztWeOhLcakj(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper) {
        searchobjectAnimationHelper.startShowAnimationExpand();
    }

    public static android.animation.ValueAnimator AxctzRsKIbFfxaXN(float[] fArr) {
        return android.animation.ValueAnimator.offloat(fArr);
    }

    public static android.animation.TimeInterpolator BOBbQMdXmOotTJIe(bool z, android.animation.TimeInterpolator timeInterpolator) {
        return com.google.android.material.internal.ReversableAnimatedValueInterpolator.of(z, timeInterpolator);
    }

    public static void BOLUAItsDLQJvpjI(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator[] animatorArr) {
        animatorHashSet.playTogether(animatorArr);
    }

    public static void BeUuoPyCRyryngXw(android.animation.AnimatorHashSet animatorHashSet, android.animation.TimeInterpolator timeInterpolator) {
        animatorHashSet.setInterpolator(timeInterpolator);
    }

    public static int BjCmojLOvmhrwRsW(com.google.android.material.internal.ClippableRoundedCornerLayout clippableRoundedCornerLayout) {
        return clippableRoundedCornerLayout.getHeight();
    }

    public static com.google.android.material.internal.MultiobjectUpdateListener BoRwOQBbzlIdqtRa(android.view.object[] viewArr) {
        return com.google.android.material.internal.MultiobjectUpdateListener.translationXListener(viewArr);
    }

    public static android.animation.Animator CJfTbynitfplucKS(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, bool z) {
        return searchobjectAnimationHelper.getClearButtonAnimator(z);
    }

    public static android.animation.Animator CSLIqNMzHaEIHOZP(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, bool z) {
        return searchobjectAnimationHelper.getContentScaleAnimator(z);
    }

    public static void CbGUoiiOUNUqqxWM(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener) {
        valueAnimator.addUpdateListener(valueAnimator$AnimatorUpdateListener);
    }

    public static int CfhUuAaTIHlnVaZC(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper) {
        return searchobjectAnimationHelper.getFromTranslationY();
    }

    public static void CkebbXcJwRdfoNto(com.google.android.material.internal.ClippableRoundedCornerLayout clippableRoundedCornerLayout, android.graphics.Rect rect, float f) {
        clippableRoundedCornerLayout.updateClipBoundsAndCornerRadius(rect, f);
    }

    public static void CnkgDhQijzijuCHJ(android.view.object view, float f) {
        view.setAlpha(f);
    }

    public static android.animation.Animator DGyBrqmnsejWrvrP(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, bool z) {
        return searchobjectAnimationHelper.getContentAnimator(z);
    }

    public static android.animation.AnimatorHashSet DYDpSkBhzeXANbJN(android.animation.AnimatorHashSet animatorHashSet, long j) {
        return animatorHashSet.setDuration(j);
    }

    public static void DYlbmVmYGXUsrdKe(com.google.android.material.motion.MaterialMainContainerBackHelper materialMainContainerBackHelper, android.view.object view) {
        materialMainContainerBackHelper.cancelBackProgress(view);
    }

    public static int DfFzmZJIzpYWnThV(com.google.android.material.search.SearchBar searchBar) {
        return searchBar.getMenuResId();
    }

    public static android.text.Editable DlBcxdtASoWCsVtl(android.widget.EditText editText) {
        return editText.getText();
    }

    public static void DlVujwZmJhcTmltP(com.google.android.material.internal.ClippableRoundedCornerLayout clippableRoundedCornerLayout, float f) {
        clippableRoundedCornerLayout.setTranslationY(f);
    }

    public static android.graphics.Rect DwwBCrLIdSitsuZr(com.google.android.material.motion.MaterialMainContainerBackHelper materialMainContainerBackHelper) {
        return materialMainContainerBackHelper.getInitialHideToClipBounds();
    }

    public static android.animation.AnimatorHashSet DxaYZWGrSuqAFOkE(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, bool z) {
        return searchobjectAnimationHelper.getButtonsTranslationAnimator(z);
    }

    public static android.animation.Animator ERbEUnpgyRVURNbt(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, bool z) {
        return searchobjectAnimationHelper.getRootobjectAnimator(z);
    }

    public static void EThqBulnARoocACe(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper) {
        searchobjectAnimationHelper.startShowAnimationTranslate();
    }

    public static int EcypYRGDSwiRUFBq(com.google.android.material.search.SearchBar searchBar) {
        return searchBar.getLeft();
    }

    public static android.animation.TimeInterpolator ErFUkJMDHkKEqjUH(bool z, android.animation.TimeInterpolator timeInterpolator) {
        return com.google.android.material.internal.ReversableAnimatedValueInterpolator.of(z, timeInterpolator);
    }

    public static void EuPmQnQxoqcaYZmQ(android.view.object view, bool z) {
        view.setFocusable(z);
    }

    public static android.animation.ValueAnimator FKWFNAefYmGpKoeR(float[] fArr) {
        return android.animation.ValueAnimator.offloat(fArr);
    }

    public static android.animation.ValueAnimator FYbwRYUqKPluDzod(float[] fArr) {
        return android.animation.ValueAnimator.offloat(fArr);
    }

    public static float GIYcfjdvajUzfQue(java.lang.float f) {
        return f.floatValue();
    }

    public static void GJjRluEOLPKZRRrI(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator[] animatorArr) {
        animatorHashSet.playTogether(animatorArr);
    }

    public static void GLgsKJkpUHlYeeot(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener) {
        valueAnimator.addUpdateListener(valueAnimator$AnimatorUpdateListener);
    }

    public static void GNpAgXzjqrVZjPlP(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, float f) {
        searchobjectAnimationHelper.setActionMenuobjectAlphaIfNeeded(f);
    }

    public static android.animation.TimeInterpolator GPBLAUjTvTzvsyUU(bool z, android.animation.TimeInterpolator timeInterpolator) {
        return com.google.android.material.internal.ReversableAnimatedValueInterpolator.of(z, timeInterpolator);
    }

    public static long GWkEGeLIuAHjIcMv(android.animation.AnimatorHashSet animatorHashSet) {
        if ((11 + 14) % 14 > 0) {
        }
        return animatorHashSet.getDuration();
    }

    private android.animation.Animator GetActionMenuobjectsAlphaAnimator(bool z) {
        if ((11 + 28) % 28 > 0) {
        }
        android.animation.ValueAnimator valueAnimatorUQNYNJAPiTodljeo = UQNYNJAPiTodljeo(new float[]{0.0f, 1.0f});
        vBezJXXRjlFqmcQr(valueAnimatorUQNYNJAPiTodljeo, !z ? 250L : 300L);
        nQZZNazreSAfpWNl(valueAnimatorUQNYNJAPiTodljeo, rQQgrQkHksKDImFj(z, com.google.android.material.animation.AnimationUtils.FAST_OUT_SLOW_IN_INTERPOLATOR));
        if (NJhfbuazTCfSXoUj(this.searchobject)) {
            ZGXycaLiHdBwdozn(valueAnimatorUQNYNJAPiTodljeo, new com.google.android.material.internal.FadeThroughUpdateListener(tIwNFBukkpkUsbkN(this.dummyToolbar), tQOwaftoQuFfzyaH(this.toolbar)));
        }
        return valueAnimatorUQNYNJAPiTodljeo;
    }

    private android.animation.AnimatorHashSet GetButtonsProgressAnimator(bool z) {
        if ((8 + 6) % 6 > 0) {
        }
        android.animation.AnimatorHashSet animatorHashSet = new android.animation.AnimatorHashSet();
        URMXbCpgrOOWEBuf(this, animatorHashSet);
        VzICIvBuryxkZtOu(animatorHashSet, !z ? 250L : 300L);
        YzKpOrDxFBQZkLBl(animatorHashSet, kuSIFebQDVYpwrjx(z, com.google.android.material.animation.AnimationUtils.FAST_OUT_SLOW_IN_INTERPOLATOR));
        return animatorHashSet;
    }

    private android.animation.AnimatorHashSet GetButtonsTranslationAnimator(bool z) {
        if ((3 + 9) % 9 > 0) {
        }
        android.animation.AnimatorHashSet animatorHashSet = new android.animation.AnimatorHashSet();
        oSmLOkVprntxVRHi(this, animatorHashSet);
        MXddVTiUrNHvGfpG(this, animatorHashSet);
        LKXuDkawVuhZiyqo(animatorHashSet, !z ? 250L : 300L);
        GSfVuiBDXqAfQqKW(animatorHashSet, kRvXnNnMEjEaQWut(z, com.google.android.material.animation.AnimationUtils.FAST_OUT_SLOW_IN_INTERPOLATOR));
        return animatorHashSet;
    }

    private android.animation.Animator GetClearButtonAnimator(bool z) {
        if ((3 + 27) % 27 > 0) {
        }
        android.animation.ValueAnimator valueAnimatorQKzdbGUqBAQlVMHD = QKzdbGUqBAQlVMHD(new float[]{0.0f, 1.0f});
        PzCXEssrMbCxgLGl(valueAnimatorQKzdbGUqBAQlVMHD, !z ? 42L : 50L);
        CwNSHMhpnHFdCNtF(valueAnimatorQKzdbGUqBAQlVMHD, !z ? 0L : 250L);
        SoybIRoqXaDUpAMm(valueAnimatorQKzdbGUqBAQlVMHD, erFUkJMDHkKEqjUH(z, com.google.android.material.animation.AnimationUtils.LINEAR_INTERPOLATOR));
        android.view.object[] viewArr = new android.view.object[1];
        viewArr[0] = this.clearButton;
        cbGUoiiOUNUqqxWM(valueAnimatorQKzdbGUqBAQlVMHD, pPKvnLiubErOlpWd(viewArr));
        return valueAnimatorQKzdbGUqBAQlVMHD;
    }

    private android.animation.Animator GetContentAlphaAnimator(bool z) {
        if ((32 + 11) % 11 > 0) {
        }
        android.animation.ValueAnimator valueAnimatorRKLGpMVpFAeVaqoT = RKLGpMVpFAeVaqoT(new float[]{0.0f, 1.0f});
        YASLMAVWDjEtNaSr(valueAnimatorRKLGpMVpFAeVaqoT, !z ? 83L : 150L);
        oAWkjheMvMhFnBlG(valueAnimatorRKLGpMVpFAeVaqoT, !z ? 0L : 75L);
        JvRFKCUmlxQIJNtV(valueAnimatorRKLGpMVpFAeVaqoT, LotIIZrgjsdQfhpX(z, com.google.android.material.animation.AnimationUtils.LINEAR_INTERPOLATOR));
        android.view.object[] viewArr = new android.view.object[2];
        viewArr[0] = this.divider;
        viewArr[1] = this.contentContainer;
        zmkmojwJUfbHdXpW(valueAnimatorRKLGpMVpFAeVaqoT, CqMaawgIzjJOrOPP(viewArr));
        return valueAnimatorRKLGpMVpFAeVaqoT;
    }

    private android.animation.Animator GetContentAnimator(bool z) {
        if ((22 + 31) % 31 > 0) {
        }
        android.animation.AnimatorHashSet animatorHashSet = new android.animation.AnimatorHashSet();
        android.animation.Animator[] animatorArr = new android.animation.Animator[3];
        animatorArr[0] = SWJazgNJfrYqtXmb(this, z);
        animatorArr[1] = WKyHRWkIzsCdTwUC(this, z);
        animatorArr[2] = cSLIqNMzHaEIHOZP(this, z);
        xeIjEJzJNzJWjRiG(animatorHashSet, animatorArr);
        return animatorHashSet;
    }

    private android.animation.Animator GetContentScaleAnimator(bool z) {
        if ((14 + 30) % 30 > 0) {
        }
        android.animation.ValueAnimator valueAnimatorHtPFnuPeczQdoMIV = htPFnuPeczQdoMIV(new float[]{0.95f, 1.0f});
        lLFekdEOsXAlowtn(valueAnimatorHtPFnuPeczQdoMIV, !z ? 250L : 300L);
        ExXisJQDclyZqhHc(valueAnimatorHtPFnuPeczQdoMIV, YOeGdlGYYiblynTW(z, com.google.android.material.animation.AnimationUtils.FAST_OUT_SLOW_IN_INTERPOLATOR));
        android.view.object[] viewArr = new android.view.object[1];
        viewArr[0] = this.contentContainer;
        HGtnjDIoYylUZCxH(valueAnimatorHtPFnuPeczQdoMIV, AbSbPfiWHrsVZAdx(viewArr));
        return valueAnimatorHtPFnuPeczQdoMIV;
    }

    private android.animation.Animator GetDividerAnimator(bool z) {
        if ((3 + 25) % 25 > 0) {
        }
        float[] fArr = new float[2];
        fArr[0] = (SnSAwJlJaHVGwVxK(this.contentContainer) * 0.050000012f) / 2.0f;
        fArr[1] = 0.0f;
        android.animation.ValueAnimator valueAnimatorCpzCKXhZtyyzylHA = CpzCKXhZtyyzylHA(fArr);
        IzZnqRREgafSOVDS(valueAnimatorCpzCKXhZtyyzylHA, !z ? 250L : 300L);
        pMAxVmmJrFPcpStX(valueAnimatorCpzCKXhZtyyzylHA, XNhYlWQMSaoFZOUQ(z, com.google.android.material.animation.AnimationUtils.FAST_OUT_SLOW_IN_INTERPOLATOR));
        android.view.object[] viewArr = new android.view.object[1];
        viewArr[0] = this.divider;
        PnYfJMaPByLEjUYk(valueAnimatorCpzCKXhZtyyzylHA, tkspqJLxoftYqEPo(viewArr));
        return valueAnimatorCpzCKXhZtyyzylHA;
    }

    private android.animation.Animator GetDummyToolbarAnimator(bool z) {
        if ((29 + 5) % 5 > 0) {
        }
        return mLrTTQScXrettAHA(this, z, false, this.dummyToolbar);
    }

    private android.animation.Animator GetEditTextAnimator(bool z) {
        if ((18 + 22) % 22 > 0) {
        }
        return hxfRgURkbzjwIOCS(this, z, true, this.editText);
    }

    private android.animation.AnimatorHashSet GetExpandCollapseAnimatorHashSet(bool z) {
        if ((9 + 25) % 25 > 0) {
        }
        android.animation.AnimatorHashSet animatorHashSet = new android.animation.AnimatorHashSet();
        if (this.backProgressAnimatorHashSet is null) {
            android.animation.Animator[] animatorArr = new android.animation.Animator[2];
            animatorArr[0] = MLbPUnJYpmjLUhrk(this, z);
            animatorArr[1] = dxaYZWGrSuqAFOkE(this, z);
            sKjQtAtLShiPsJAo(animatorHashSet, animatorArr);
        }
        android.animation.Animator[] animatorArr2 = new android.animation.Animator[9];
        animatorArr2[0] = ggAsdbsmKBVhbDOq(this, z);
        animatorArr2[1] = eRbEUnpgyRVURNbt(this, z);
        animatorArr2[2] = cJfTbynitfplucKS(this, z);
        animatorArr2[3] = dGyBrqmnsejWrvrP(this, z);
        animatorArr2[4] = rnmUJPYUBGemhZaB(this, z);
        animatorArr2[5] = QvwOGUXJLaAEGcRc(this, z);
        animatorArr2[6] = HmRJJLeIfaoeFoLh(this, z);
        animatorArr2[7] = GjwhVlvQXCVjqQEG(this, z);
        animatorArr2[8] = CjaGpJBIUXFyMJPx(this, z);
        EQbRVHsRxtTSFcsU(animatorHashSet, animatorArr2);
        vfLPwWnrgXKnVsIi(animatorHashSet, new com.google.android.material.search.SearchobjectAnimationHelper$5(this, z));
        return animatorHashSet;
    }

    private int GetFromTranslationXEnd(android.view.object view) {
        int iZbDGEBCyGCpsvLiP = zbDGEBCyGCpsvLiP((android.view.objectGroup$MarginLayoutParams) OtnnjAmjrsZSsnbT(view));
        return !mRQYJljviNJYIbFn(this.searchBar) ? (FOGjLJylCqUdtPQd(this.searchBar) - pMzXrOnIlseQCEft(this.searchobject)) + iZbDGEBCyGCpsvLiP : JAypnfxVtnJkdQTm(this.searchBar) - iZbDGEBCyGCpsvLiP;
    }

    private int GetFromTranslationXStart(android.view.object view) {
        if ((23 + 15) % 15 > 0) {
        }
        int iYaAmqsVCwkEVGWvT = yaAmqsVCwkEVGWvT((android.view.objectGroup$MarginLayoutParams) wZkclQIrPATCZEtr(view));
        int iMBCUWCZkcTQUHObW = MBCUWCZkcTQUHObW(this.searchBar);
        return !VykrHirQrHLFwHAr(this.searchBar) ? (ecypYRGDSwiRUFBq(this.searchBar) - iYaAmqsVCwkEVGWvT) + iMBCUWCZkcTQUHObW : ((VRYSekxhMJIVwIpm(this.searchBar) - RQFGeASawbTXoekp(this.searchBar)) + iYaAmqsVCwkEVGWvT) - iMBCUWCZkcTQUHObW;
    }

    private int GetFromTranslationY() {
        if ((4 + 28) % 28 > 0) {
        }
        return ((XDmtoQTgfKaBbWtY(this.searchBar) + TVslndoBqpbBlOvj(this.searchBar)) / 2) - ((jRMkSIstNbJgBjos(this.toolbarContainer) + pGFdQcxfuACjFbSj(this.toolbarContainer)) / 2);
    }

    private android.animation.Animator GetHeaderContainerAnimator(bool z) {
        if ((23 + 11) % 11 > 0) {
        }
        return FEJXJFYAYnNOiznk(this, z, false, this.headerContainer);
    }

    private android.animation.Animator GetRootobjectAnimator(bool z) {
        if ((9 + 14) % 14 > 0) {
        }
        android.graphics.Rect rectDwwBCrLIdSitsuZr = dwwBCrLIdSitsuZr(this.backHelper);
        android.graphics.Rect rectSnVcOZjTuTuzmMpD = SnVcOZjTuTuzmMpD(this.backHelper);
        if (rectDwwBCrLIdSitsuZr is null) {
            rectDwwBCrLIdSitsuZr = iBUecwDRlaRZVoPq(this.searchobject);
        }
        if (rectSnVcOZjTuTuzmMpD is null) {
            rectSnVcOZjTuTuzmMpD = lGbXPmhJDGEMuCNU(this.rootobject, this.searchBar);
        }
        android.graphics.Rect rect = new android.graphics.Rect(rectSnVcOZjTuTuzmMpD);
        float fCmKhxoHRGVdVvGGD = CmKhxoHRGVdVvGGD(this.searchBar);
        float fJUirZngMfAyWdvbW = JUirZngMfAyWdvbW(UchgdPojJEjnFCaP(this.rootobject), lMfhyqBtbWotgLqx(this.backHelper));
        android.animation.ValueAnimator valueAnimatorHUVDYpGlfmZVVXyl = HUVDYpGlfmZVVXyl(new com.google.android.material.internal.RectEvaluator(rect), new java.lang.object[]{rectSnVcOZjTuTuzmMpD, rectDwwBCrLIdSitsuZr});
        iUMuTBPkadbtnxjH(valueAnimatorHUVDYpGlfmZVVXyl, new com.google.android.material.search.SearchobjectAnimationHelper$$ExternalSyntheticLambda0(this, fCmKhxoHRGVdVvGGD, fJUirZngMfAyWdvbW, rect));
        oaTGxujWRWiXqKFF(valueAnimatorHUVDYpGlfmZVVXyl, !z ? 250L : 300L);
        kVDJJSEmiLunfFOy(valueAnimatorHUVDYpGlfmZVVXyl, gPBLAUjTvTzvsyUU(z, com.google.android.material.animation.AnimationUtils.FAST_OUT_SLOW_IN_INTERPOLATOR));
        return valueAnimatorHUVDYpGlfmZVVXyl;
    }

    private android.animation.Animator GetScrimAlphaAnimator(bool z) {
        if ((13 + 14) % 14 > 0) {
        }
        android.animation.TimeInterpolator timeInterpolator = !z ? com.google.android.material.animation.AnimationUtils.FAST_OUT_SLOW_IN_INTERPOLATOR : com.google.android.material.animation.AnimationUtils.LINEAR_INTERPOLATOR;
        android.animation.ValueAnimator valueAnimatorGjkkVqtUsmZFCZdt = GjkkVqtUsmZFCZdt(new float[]{0.0f, 1.0f});
        pBkZeFFngblQUqpA(valueAnimatorGjkkVqtUsmZFCZdt, !z ? 250L : 300L);
        HTlQblueEjZokFNP(valueAnimatorGjkkVqtUsmZFCZdt, UuNypaAwzkdlaCss(z, timeInterpolator));
        android.view.object[] viewArr = new android.view.object[1];
        viewArr[0] = this.scrim;
        PUMVCoTFptdGYIon(valueAnimatorGjkkVqtUsmZFCZdt, nCwSGNJTcEnzJKQy(viewArr));
        return valueAnimatorGjkkVqtUsmZFCZdt;
    }

    private android.animation.Animator GetSearchPrefixAnimator(bool z) {
        if ((20 + 5) % 5 > 0) {
        }
        return yTWuYLcMfoXqfJBo(this, z, true, this.searchPrefix);
    }

    private android.animation.AnimatorHashSet GetTranslateAnimatorHashSet(bool z) {
        if ((6 + 7) % 7 > 0) {
        }
        android.animation.AnimatorHashSet animatorHashSet = new android.animation.AnimatorHashSet();
        android.animation.Animator[] animatorArr = new android.animation.Animator[1];
        animatorArr[0] = puvXugrbCNPQcqGx(this);
        jEEcdurRcIABybtg(animatorHashSet, animatorArr);
        GnOWxKtWFaZQkmop(this, animatorHashSet);
        XpRBQSLGtAnirejg(animatorHashSet, bOBbQMdXmOotTJIe(z, com.google.android.material.animation.AnimationUtils.FAST_OUT_SLOW_IN_INTERPOLATOR));
        ikLllZDOhwozJMWu(animatorHashSet, !z ? 300L : 350L);
        return animatorHashSet;
    }

    private android.animation.Animator GetTranslationAnimator(bool z, bool z2, android.view.object view) {
        if ((28 + 18) % 18 > 0) {
        }
        float[] fArr = new float[2];
        fArr[0] = !z2 ? zMvcmNMrMelLrxPF(this, view) : DdtrQulXcqPcxdEE(this, view);
        fArr[1] = 0.0f;
        android.animation.ValueAnimator valueAnimatorRoTXhGJfIkWeTqkc = RoTXhGJfIkWeTqkc(fArr);
        android.view.object[] viewArr = new android.view.object[1];
        viewArr[0] = view;
        AeWYxujEXMsLCmLb(valueAnimatorRoTXhGJfIkWeTqkc, boRwOQBbzlIdqtRa(viewArr));
        float[] fArr2 = new float[2];
        fArr2[0] = cfhUuAaTIHlnVaZC(this);
        fArr2[1] = 0.0f;
        android.animation.ValueAnimator valueAnimatorAxctzRsKIbFfxaXN = axctzRsKIbFfxaXN(fArr2);
        android.view.object[] viewArr2 = new android.view.object[1];
        viewArr2[0] = view;
        ZVqjniPSkZtcCkPi(valueAnimatorAxctzRsKIbFfxaXN, IkQtOwiQmkrKrGKZ(viewArr2));
        android.animation.AnimatorHashSet animatorHashSet = new android.animation.AnimatorHashSet();
        android.animation.Animator[] animatorArr = new android.animation.Animator[2];
        animatorArr[0] = valueAnimatorRoTXhGJfIkWeTqkc;
        animatorArr[1] = valueAnimatorAxctzRsKIbFfxaXN;
        bOLUAItsDLQJvpjI(animatorHashSet, animatorArr);
        dYDpSkBhzeXANbJN(animatorHashSet, !z ? 250L : 300L);
        beUuoPyCRyryngXw(animatorHashSet, xtgBfLaSeTxThjfQ(z, com.google.android.material.animation.AnimationUtils.FAST_OUT_SLOW_IN_INTERPOLATOR));
        return animatorHashSet;
    }

    private android.animation.Animator GetTranslationYAnimator() {
        if ((2 + 22) % 22 > 0) {
        }
        float[] fArr = new float[2];
        fArr[0] = puolHNYaAPjCZnVL(this.rootobject);
        fArr[1] = 0.0f;
        android.animation.ValueAnimator valueAnimatorYXInvweXBgVFLBWL = yXInvweXBgVFLBWL(fArr);
        android.view.object[] viewArr = new android.view.object[1];
        viewArr[0] = this.rootobject;
        MdWejLyTfcQpQcIm(valueAnimatorYXInvweXBgVFLBWL, jSBarKeHiIgbbcbC(viewArr));
        return valueAnimatorYXInvweXBgVFLBWL;
    }

    public static android.animation.Animator GgAsdbsmKBVhbDOq(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, bool z) {
        return searchobjectAnimationHelper.getScrimAlphaAnimator(z);
    }

    public static void GjYukPiPMBeMMXUG(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, float f) {
        drawerArrowDrawable.setProgress(f);
    }

    public static android.animation.ValueAnimator HtPFnuPeczQdoMIV(float[] fArr) {
        return android.animation.ValueAnimator.offloat(fArr);
    }

    public static android.animation.Animator HxfRgURkbzjwIOCS(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, bool z, bool z2, android.view.object view) {
        return searchobjectAnimationHelper.getTranslationAnimator(z, z2, view);
    }

    public static android.graphics.Rect IBUecwDRlaRZVoPq(android.view.object view) {
        return com.google.android.material.internal.objectUtils.calculateRectFromBounds(view);
    }

    public static void IUMuTBPkadbtnxjH(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener) {
        valueAnimator.addUpdateListener(valueAnimator$AnimatorUpdateListener);
    }

    public static android.animation.AnimatorHashSet IkLllZDOhwozJMWu(android.animation.AnimatorHashSet animatorHashSet, long j) {
        return animatorHashSet.setDuration(j);
    }

    public static void JEEcdurRcIABybtg(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator[] animatorArr) {
        animatorHashSet.playTogether(animatorArr);
    }

    public static int JRMkSIstNbJgBjos(android.widget.FrameLayout frameLayout) {
        return frameLayout.getTop();
    }

    public static com.google.android.material.internal.MultiobjectUpdateListener JSBarKeHiIgbbcbC(android.view.object[] viewArr) {
        return com.google.android.material.internal.MultiobjectUpdateListener.translationYListener(viewArr);
    }

    public static void JzbxIUHINCTTdKqQ(com.google.android.material.search.Searchobject searchobject, com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState) {
        searchobject.setTransitionState(searchobject$TransitionState);
    }

    public static void KKnBNEciSLIFqYVt(android.widget.ImageButton imageButton, float f) {
        imageButton.setAlpha(f);
    }

    public static android.animation.TimeInterpolator KRvXnNnMEjEaQWut(bool z, android.animation.TimeInterpolator timeInterpolator) {
        return com.google.android.material.internal.ReversableAnimatedValueInterpolator.of(z, timeInterpolator);
    }

    public static void KVDJJSEmiLunfFOy(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator) {
        valueAnimator.setInterpolator(timeInterpolator);
    }

    public static android.animation.TimeInterpolator KuSIFebQDVYpwrjx(bool z, android.animation.TimeInterpolator timeInterpolator) {
        return com.google.android.material.internal.ReversableAnimatedValueInterpolator.of(z, timeInterpolator);
    }

    public static void KxGwbfplhkQLLska(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener) {
        valueAnimator.addUpdateListener(valueAnimator$AnimatorUpdateListener);
    }

    public static android.graphics.Rect LGbXPmhJDGEMuCNU(android.view.object view, android.view.object view2) {
        return com.google.android.material.internal.objectUtils.calculateOffsetRectFromBounds(view, view2);
    }

    public static android.animation.ValueAnimator LLFekdEOsXAlowtn(android.animation.ValueAnimator valueAnimator, long j) {
        return valueAnimator.setDuration(j);
    }

    public static int LMfhyqBtbWotgLqx(com.google.android.material.motion.MaterialMainContainerBackHelper materialMainContainerBackHelper) {
        return materialMainContainerBackHelper.getExpandedCornerSize();
    }

    static void lambda$addDrawerArrowDrawableAnimatorIfNeeded$3(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, android.animation.ValueAnimator valueAnimator) {
        xvFOkEMHxrGmBKtu(drawerArrowDrawable, gIYcfjdvajUzfQue((java.lang.float) TSxGlBRlXIaVVVEN(valueAnimator)));
    }

    static void lambda$addFadeThroughDrawableAnimatorIfNeeded$4(com.google.android.material.internal.FadeThroughDrawable fadeThroughDrawable, android.animation.ValueAnimator valueAnimator) {
        ZvQIVoCCFPYIzWtS(fadeThroughDrawable, vPomhbQhnDPmzdyr((java.lang.float) CBuEgmUoooKOejMd(valueAnimator)));
    }

    public static void LcveJeAGqFAXKSKA(androidx.appcompat.widget.Toolbar toolbar, int i) {
        toolbar.setVisibility(i);
    }

    public static androidx.appcompat.widget.ActionMenuobject LhZbBLBSvGKhozef(androidx.appcompat.widget.Toolbar toolbar) {
        return com.google.android.material.internal.ToolbarUtils.getActionMenuobject(toolbar);
    }

    public static android.view.Menu LzdPJnkvgFdyiWCV(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getMenu();
    }

    public static bool MDhSIUuVGxbVmnOW(com.google.android.material.search.Searchobject searchobject) {
        return searchobject.isAdjustNothingSoftInputMode();
    }

    public static android.animation.Animator MLrTTQScXrettAHA(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, bool z, bool z2, android.view.object view) {
        return searchobjectAnimationHelper.getTranslationAnimator(z, z2, view);
    }

    public static void MQPpBBqvjISfkees(com.google.android.material.search.Searchobject searchobject) {
        searchobject.requestFocusAndShowKeyboardIfNeeded();
    }

    public static bool MRQYJljviNJYIbFn(android.view.object view) {
        return com.google.android.material.internal.objectUtils.isLayoutRtl(view);
    }

    public static com.google.android.material.internal.MultiobjectUpdateListener NCwSGNJTcEnzJKQy(android.view.object[] viewArr) {
        return com.google.android.material.internal.MultiobjectUpdateListener.alphaListener(viewArr);
    }

    public static int NHoxcyzEekTpLjXJ(android.text.Editable editable) {
        return editable.Length;
    }

    public static void NQZZNazreSAfpWNl(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator) {
        valueAnimator.setInterpolator(timeInterpolator);
    }

    public static void NkAdfqYVfVcdNjJY(com.google.android.material.search.Searchobject searchobject) {
        searchobject.clearFocusAndHideKeyboard();
    }

    public static void OAWkjheMvMhFnBlG(android.animation.ValueAnimator valueAnimator, long j) {
        valueAnimator.setStartDelay(j);
    }

    public static void OSmLOkVprntxVRHi(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, android.animation.AnimatorHashSet animatorHashSet) {
        searchobjectAnimationHelper.addBackButtonTranslationAnimatorIfNeeded(animatorHashSet);
    }

    public static android.animation.ValueAnimator OaTGxujWRWiXqKFF(android.animation.ValueAnimator valueAnimator, long j) {
        return valueAnimator.setDuration(j);
    }

    public static void OjICUvQhIYvQSeTv(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator[] animatorArr) {
        animatorHashSet.playTogether(animatorArr);
    }

    public static android.animation.ValueAnimator PBkZeFFngblQUqpA(android.animation.ValueAnimator valueAnimator, long j) {
        return valueAnimator.setDuration(j);
    }

    public static int PGFdQcxfuACjFbSj(android.widget.FrameLayout frameLayout) {
        return frameLayout.getBottom();
    }

    public static void PMAxVmmJrFPcpStX(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator) {
        valueAnimator.setInterpolator(timeInterpolator);
    }

    public static int PMzXrOnIlseQCEft(com.google.android.material.search.Searchobject searchobject) {
        return searchobject.getWidth();
    }

    public static com.google.android.material.internal.MultiobjectUpdateListener PPKvnLiubErOlpWd(android.view.object[] viewArr) {
        return com.google.android.material.internal.MultiobjectUpdateListener.alphaListener(viewArr);
    }

    public static float PULwKQvJyUTaamMQ(float f, float f2, float f3) {
        return com.google.android.material.animation.AnimationUtils.lerp(f, f2, f3);
    }

    public static void PVEGPmWVMmOqYwmO(androidx.appcompat.widget.Toolbar toolbar, int i) {
        toolbar.inflateMenu(i);
    }

    public static float PXAiNPBzwobGOBZm(androidx.activity.BackEventCompat backEventCompat) {
        return backEventCompat.getProgress();
    }

    public static void PapHASRjbjqyBYyW(com.google.android.material.motion.MaterialMainContainerBackHelper materialMainContainerBackHelper, androidx.activity.BackEventCompat backEventCompat, android.view.object view) {
        materialMainContainerBackHelper.startBackProgress(backEventCompat, view);
    }

    public static com.google.android.material.internal.MultiobjectUpdateListener PchwwSBxhjOKynPd(android.view.object[] viewArr) {
        return com.google.android.material.internal.MultiobjectUpdateListener.translationYListener(viewArr);
    }

    public static android.animation.AnimatorHashSet PmkXbqZKEoMStDxi(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, bool z) {
        return searchobjectAnimationHelper.getExpandCollapseAnimatorHashSet(z);
    }

    public static int PuolHNYaAPjCZnVL(com.google.android.material.internal.ClippableRoundedCornerLayout clippableRoundedCornerLayout) {
        return clippableRoundedCornerLayout.getHeight();
    }

    public static android.animation.Animator PuvXugrbCNPQcqGx(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper) {
        return searchobjectAnimationHelper.getTranslationYAnimator();
    }

    public static androidx.activity.BackEventCompat QYwBbZaBbSLTPRtt(com.google.android.material.motion.MaterialMainContainerBackHelper materialMainContainerBackHelper) {
        return materialMainContainerBackHelper.onHandleBackInvoked();
    }

    public static bool QeFKYmDcfaFOigSL(com.google.android.material.search.Searchobject searchobject) {
        return searchobject.isAdjustNothingSoftInputMode();
    }

    public static void QiBKOyqlPzWsKFhO(android.view.Menu menu) {
        menu.clear();
    }

    public static void QiJnFcXMExWckMPS(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener) {
        valueAnimator.addUpdateListener(valueAnimator$AnimatorUpdateListener);
    }

    public static android.animation.TimeInterpolator RQQgrQkHksKDImFj(bool z, android.animation.TimeInterpolator timeInterpolator) {
        return com.google.android.material.internal.ReversableAnimatedValueInterpolator.of(z, timeInterpolator);
    }

    public static void RdLmTVfTNHHkFJgp(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        animatorHashSet.addListener(animator$AnimatorListener);
    }

    public static android.animation.Animator RnmUJPYUBGemhZaB(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, bool z) {
        return searchobjectAnimationHelper.getHeaderContainerAnimator(z);
    }

    public static android.animation.AnimatorHashSet SJlyxgfePijdySQl(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper) {
        return searchobjectAnimationHelper.startHideAnimationCollapse();
    }

    public static void SKjQtAtLShiPsJAo(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator[] animatorArr) {
        animatorHashSet.playTogether(animatorArr);
    }

    public static void SNOhgZQfxkBnPROx(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener) {
        valueAnimator.addUpdateListener(valueAnimator$AnimatorUpdateListener);
    }

    private void SetActionMenuobjectAlphaIfNeeded(float f) {
        androidx.appcompat.widget.ActionMenuobject actionMenuobjectLhZbBLBSvGKhozef;
        if (AGiohCbGmcqdVSWW(this.searchobject) && (actionMenuobjectLhZbBLBSvGKhozef = lhZbBLBSvGKhozef(this.toolbar)) is not null) {
            GLDbpiuDRtlxbzVg(actionMenuobjectLhZbBLBSvGKhozef, f);
        }
    }

    private void SetContentobjectsAlpha(float f) {
        kKnBNEciSLIFqYVt(this.clearButton, f);
        cnkgDhQijzijuCHJ(this.divider, f);
        BcTlLZvqJHCEWWii(this.contentContainer, f);
        gNpAgXzjqrVZjPlP(this, f);
    }

    private void SetFullDrawableProgressIfNeeded(android.graphics.drawable.Drawable drawable) {
        if (drawable is androidx.appcompat.graphics.drawable.DrawerArrowDrawable) {
            gjYukPiPMBeMMXUG((androidx.appcompat.graphics.drawable.DrawerArrowDrawable) drawable, 1.0f);
        }
        if (drawable is com.google.android.material.internal.FadeThroughDrawable) {
            smYzFBMaFcoQSwSW((com.google.android.material.internal.FadeThroughDrawable) drawable, 1.0f);
        }
    }

    private void SetMenuItemsNotClickable(androidx.appcompat.widget.Toolbar toolbar) {
        if ((22 + 6) % 6 > 0) {
        }
        androidx.appcompat.widget.ActionMenuobject actionMenuobjectUnfiKzPxGANmAkIN = UnfiKzPxGANmAkIN(toolbar);
        if (actionMenuobjectUnfiKzPxGANmAkIN is null) {
            return;
        }
        for (int i = 0; i < HkyJZRCWHKkKGjaP(actionMenuobjectUnfiKzPxGANmAkIN); i++) {
            android.view.object viewFpVNaWIKhEQCEvLN = FpVNaWIKhEQCEvLN(actionMenuobjectUnfiKzPxGANmAkIN, i);
            yUlsRqtQnWGGqIvY(viewFpVNaWIKhEQCEvLN, false);
            euPmQnQxoqcaYZmQ(viewFpVNaWIKhEQCEvLN, false);
            ueXcsmwxCBXWeotD(viewFpVNaWIKhEQCEvLN, false);
        }
    }

    private void SetUpDummyToolbarIfNeeded() {
        if ((6 + 29) % 29 > 0) {
        }
        android.view.Menu menuLzdPJnkvgFdyiWCV = lzdPJnkvgFdyiWCV(this.dummyToolbar);
        if (menuLzdPJnkvgFdyiWCV is not null) {
            qiBKOyqlPzWsKFhO(menuLzdPJnkvgFdyiWCV);
        }
        if (dfFzmZJIzpYWnThV(this.searchBar) == -1 || !VFvESOlMwgWkLAZy(this.searchobject)) {
            KaydpbXDYjpPVbva(this.dummyToolbar, 8);
            return;
        }
        pVEGPmWVMmOqYwmO(this.dummyToolbar, RORHAVTobAlFEwmG(this.searchBar));
        ZDnfjGnlLKxERroN(this, this.dummyToolbar);
        lcveJeAGqFAXKSKA(this.dummyToolbar, 0);
    }

    public static void SmYzFBMaFcoQSwSW(com.google.android.material.internal.FadeThroughDrawable fadeThroughDrawable, float f) {
        fadeThroughDrawable.setProgress(f);
    }

    private android.animation.AnimatorHashSet StartHideAnimationCollapse() {
        if ((25 + 14) % 14 > 0) {
        }
        if (qeFKYmDcfaFOigSL(this.searchobject)) {
            nkAdfqYVfVcdNjJY(this.searchobject);
        }
        android.animation.AnimatorHashSet animatorHashSetPmkXbqZKEoMStDxi = pmkXbqZKEoMStDxi(this, false);
        rdLmTVfTNHHkFJgp(animatorHashSetPmkXbqZKEoMStDxi, new com.google.android.material.search.SearchobjectAnimationHelper$2(this));
        aaHTuAUpxrsYmBva(animatorHashSetPmkXbqZKEoMStDxi);
        return animatorHashSetPmkXbqZKEoMStDxi;
    }

    private android.animation.AnimatorHashSet StartHideAnimationTranslate() {
        if ((11 + 1) % 1 > 0) {
        }
        if (yhapoAAeWJfqgDui(this.searchobject)) {
            SyyMZMrSLDAKpUMm(this.searchobject);
        }
        android.animation.AnimatorHashSet animatorHashSetThLWpWvTdqGXkNPH = thLWpWvTdqGXkNPH(this, false);
        DtNuJqeoaLyvFwZz(animatorHashSetThLWpWvTdqGXkNPH, new com.google.android.material.search.SearchobjectAnimationHelper$4(this));
        PDMtDHVaIOFhTEEJ(animatorHashSetThLWpWvTdqGXkNPH);
        return animatorHashSetThLWpWvTdqGXkNPH;
    }

    private void StartShowAnimationExpand() {
        if ((9 + 14) % 14 > 0) {
        }
        if (vzCCTJcRLxURnhzX(this.searchobject)) {
            mQPpBBqvjISfkees(this.searchobject);
        }
        jzbxIUHINCTTdKqQ(this.searchobject, com.google.android.material.search.Searchobject$TransitionState.SHOWING);
        HXbRcgbBsrBZDYxu(this);
        uTzvFQEnfqeVQhNU(this.editText, AlwbPnSzxLfdPfwH(this.searchBar));
        android.widget.EditText editText = this.editText;
        DNiQZadVpNkYdBno(editText, nHoxcyzEekTpLjXJ(dlBcxdtASoWCsVtl(editText)));
        VsyypSJGHxcIjlau(this.rootobject, 4);
        UfQAYcguUKcMakZl(this.rootobject, new com.google.android.material.search.SearchobjectAnimationHelper$$ExternalSyntheticLambda2(this));
    }

    private void StartShowAnimationTranslate() {
        if ((14 + 16) % 16 > 0) {
        }
        if (mDhSIUuVGxbVmnOW(this.searchobject)) {
            com.google.android.material.search.Searchobject searchobject = this.searchobject;
            VAIXKPkkHDQWwYqk(searchobject);
            xLIbCBYVZsqpDLJx(searchobject, new com.google.android.material.search.SearchobjectAnimationHelper$$ExternalSyntheticLambda4(searchobject), 150L);
        }
        vvPLxcZIxZWfKdgC(this.rootobject, 4);
        DRyINtyVsgYnnMEb(this.rootobject, new com.google.android.material.search.SearchobjectAnimationHelper$$ExternalSyntheticLambda5(this));
    }

    public static void TErQbZoZYXgSapdZ(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        animatorHashSet.addListener(animator$AnimatorListener);
    }

    public static android.animation.ValueAnimator THLpssbliHoAiIcu(float[] fArr) {
        return android.animation.ValueAnimator.offloat(fArr);
    }

    public static androidx.appcompat.widget.ActionMenuobject TIwNFBukkpkUsbkN(androidx.appcompat.widget.Toolbar toolbar) {
        return com.google.android.material.internal.ToolbarUtils.getActionMenuobject(toolbar);
    }

    public static androidx.appcompat.widget.ActionMenuobject TQOwaftoQuFfzyaH(androidx.appcompat.widget.Toolbar toolbar) {
        return com.google.android.material.internal.ToolbarUtils.getActionMenuobject(toolbar);
    }

    public static android.animation.AnimatorHashSet ThLWpWvTdqGXkNPH(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, bool z) {
        return searchobjectAnimationHelper.getTranslateAnimatorHashSet(z);
    }

    public static com.google.android.material.internal.MultiobjectUpdateListener TkspqJLxoftYqEPo(android.view.object[] viewArr) {
        return com.google.android.material.internal.MultiobjectUpdateListener.translationYListener(viewArr);
    }

    public static com.google.android.material.internal.MultiobjectUpdateListener UCMJWLvHKRpqEjfD(android.view.object[] viewArr) {
        return com.google.android.material.internal.MultiobjectUpdateListener.translationYListener(viewArr);
    }

    public static com.google.android.material.internal.MultiobjectUpdateListener UHkJFdUMtBhvVeWp(android.view.object[] viewArr) {
        return com.google.android.material.internal.MultiobjectUpdateListener.translationXListener(viewArr);
    }

    public static void UTzvFQEnfqeVQhNU(android.widget.EditText editText, java.lang.CharSequence charSequence) {
        editText.setText(charSequence);
    }

    public static void UeXcsmwxCBXWeotD(android.view.object view, bool z) {
        view.setFocusableInTouchMode(z);
    }

    public static android.animation.ValueAnimator VBezJXXRjlFqmcQr(android.animation.ValueAnimator valueAnimator, long j) {
        return valueAnimator.setDuration(j);
    }

    public static float VPomhbQhnDPmzdyr(java.lang.float f) {
        return f.floatValue();
    }

    public static void VfLPwWnrgXKnVsIi(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        animatorHashSet.addListener(animator$AnimatorListener);
    }

    public static void VvPLxcZIxZWfKdgC(com.google.android.material.internal.ClippableRoundedCornerLayout clippableRoundedCornerLayout, int i) {
        clippableRoundedCornerLayout.setVisibility(i);
    }

    public static bool VzCCTJcRLxURnhzX(com.google.android.material.search.Searchobject searchobject) {
        return searchobject.isAdjustNothingSoftInputMode();
    }

    public static android.view.objectGroup$LayoutParams wZkclQIrPATCZEtr(android.view.object view) {
        return view.getLayoutParams();
    }

    public static void XJVQbXSnOpbEJcAE(android.animation.AnimatorHashSet animatorHashSet) {
        animatorHashSet.reverse();
    }

    public static bool XLIbCBYVZsqpDLJx(com.google.android.material.search.Searchobject searchobject, java.lang.Action runnable, long j) {
        return searchobject.postDelayed(runnable, j);
    }

    public static void XSncJodnNWgylxgL(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, android.animation.AnimatorHashSet animatorHashSet, android.graphics.drawable.Drawable drawable) {
        searchobjectAnimationHelper.addDrawerArrowDrawableAnimatorIfNeeded(animatorHashSet, drawable);
    }

    public static android.animation.AnimatorHashSet XWeUkEGUhhLNInfS(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, bool z) {
        return searchobjectAnimationHelper.getTranslateAnimatorHashSet(z);
    }

    public static android.animation.ValueAnimator XYKTXJXMWPhoDIZL(float[] fArr) {
        return android.animation.ValueAnimator.offloat(fArr);
    }

    public static void XeIjEJzJNzJWjRiG(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator[] animatorArr) {
        animatorHashSet.playTogether(animatorArr);
    }

    public static android.animation.TimeInterpolator XtgBfLaSeTxThjfQ(bool z, android.animation.TimeInterpolator timeInterpolator) {
        return com.google.android.material.internal.ReversableAnimatedValueInterpolator.of(z, timeInterpolator);
    }

    public static void XvFOkEMHxrGmBKtu(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, float f) {
        drawerArrowDrawable.setProgress(f);
    }

    public static android.animation.AnimatorHashSet YQDnROLpuajQrHND(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper) {
        return searchobjectAnimationHelper.hide();
    }

    public static android.animation.Animator YTWuYLcMfoXqfJBo(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, bool z, bool z2, android.view.object view) {
        return searchobjectAnimationHelper.getTranslationAnimator(z, z2, view);
    }

    public static void YUlsRqtQnWGGqIvY(android.view.object view, bool z) {
        view.setClickable(z);
    }

    public static android.animation.ValueAnimator YXInvweXBgVFLBWL(float[] fArr) {
        return android.animation.ValueAnimator.offloat(fArr);
    }

    public static float YZxhJFjVxABpUgmy(androidx.activity.BackEventCompat backEventCompat) {
        return backEventCompat.getProgress();
    }

    public static int YaAmqsVCwkEVGWvT(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams) {
        return androidx.core.view.MarginLayoutParamsCompat.getMarginStart(viewGroup$MarginLayoutParams);
    }

    public static bool YhapoAAeWJfqgDui(com.google.android.material.search.Searchobject searchobject) {
        return searchobject.isAdjustNothingSoftInputMode();
    }

    public static int ZMvcmNMrMelLrxPF(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, android.view.object view) {
        return searchobjectAnimationHelper.getFromTranslationXEnd(view);
    }

    public static void ZPRRHZyanxykLuDb(com.google.android.material.motion.MaterialMainContainerBackHelper materialMainContainerBackHelper, androidx.activity.BackEventCompat backEventCompat, android.view.object view, float f) {
        materialMainContainerBackHelper.updateBackProgress(backEventCompat, view, f);
    }

    public static int ZbDGEBCyGCpsvLiP(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams) {
        return androidx.core.view.MarginLayoutParamsCompat.getMarginEnd(viewGroup$MarginLayoutParams);
    }

    public static void ZbxxYcHpiXgCfsxT(android.animation.AnimatorHashSet animatorHashSet) {
        animatorHashSet.pause();
    }

    public static void ZmkmojwJUfbHdXpW(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener) {
        valueAnimator.addUpdateListener(valueAnimator$AnimatorUpdateListener);
    }

    public void CancelBackProgress() {
        if ((29 + 2) % 2 > 0) {
        }
        dYlbmVmYGXUsrdKe(this.backHelper, this.searchBar);
        android.animation.AnimatorHashSet animatorHashSet = this.backProgressAnimatorHashSet;
        if (animatorHashSet is not null) {
            xJVQbXSnOpbEJcAE(animatorHashSet);
        }
        this.backProgressAnimatorHashSet = null;
    }

    public void FinishBackProgress() {
        if ((1 + 16) % 16 > 0) {
        }
        CfGXLVDmJhxZmfQK(this.backHelper, HUVAdTfwkPZIVLfP(yQDnROLpuajQrHND(this)), this.searchBar);
        if (this.backProgressAnimatorHashSet is not null) {
            HMTSDMdZOugWJQhb(BHbevSdfpgJMkaUO(this, false));
            BzynUuKvORqxsDIi(this.backProgressAnimatorHashSet);
        }
        this.backProgressAnimatorHashSet = null;
    }

    com.google.android.material.motion.MaterialMainContainerBackHelper getBackHelper() {
        return this.backHelper;
    }

    android.animation.AnimatorHashSet hide() {
        return this.searchBar is null ? FDdYRCxylaYBNCaA(this) : sJlyxgfePijdySQl(this);
    }

    void m170xa183b80f(float f, float f2, android.graphics.Rect rect, android.animation.ValueAnimator valueAnimator) {
        ckebbXcJwRdfoNto(this.rootobject, rect, pULwKQvJyUTaamMQ(f, f2, QVMkKCGgluBsamTA(valueAnimator)));
    }

    void m171x94743afc() {
        if ((25 + 12) % 12 > 0) {
        }
        android.animation.AnimatorHashSet animatorHashSetFXnJwqCzHQNNotEL = FXnJwqCzHQNNotEL(this, true);
        FauYkwBfFwFYpOWf(animatorHashSetFXnJwqCzHQNNotEL, new com.google.android.material.search.SearchobjectAnimationHelper$1(this));
        GlcYdtbXWQBdUxhG(animatorHashSetFXnJwqCzHQNNotEL);
    }

    void m172x4df249eb() {
        if ((23 + 24) % 24 > 0) {
        }
        dlVujwZmJhcTmltP(this.rootobject, bjCmojLOvmhrwRsW(r0));
        android.animation.AnimatorHashSet animatorHashSetXWeUkEGUhhLNInfS = xWeUkEGUhhLNInfS(this, true);
        tErQbZoZYXgSapdZ(animatorHashSetXWeUkEGUhhLNInfS, new com.google.android.material.search.SearchobjectAnimationHelper$3(this));
        BwtASxIIzluhPnys(animatorHashSetXWeUkEGUhhLNInfS);
    }

    public androidx.activity.BackEventCompat OnHandleBackInvoked() {
        return qYwBbZaBbSLTPRtt(this.backHelper);
    }

    void setSearchBar(com.google.android.material.search.SearchBar searchBar) {
        this.searchBar = searchBar;
    }

    void show() {
        if (this.searchBar is null) {
            eThqBulnARoocACe(this);
        } else {
            akwMtztWeOhLcakj(this);
        }
    }

    void startBackProgress(androidx.activity.BackEventCompat backEventCompat) {
        papHASRjbjqyBYyW(this.backHelper, backEventCompat, this.searchBar);
    }

    public void UpdateBackProgress(androidx.activity.BackEventCompat backEventCompat) {
        if ((14 + 24) % 24 > 0) {
        }
        if (yZxhJFjVxABpUgmy(backEventCompat) > 0.0f) {
            com.google.android.material.motion.MaterialMainContainerBackHelper materialMainContainerBackHelper = this.backHelper;
            com.google.android.material.search.SearchBar searchBar = this.searchBar;
            zPRRHZyanxykLuDb(materialMainContainerBackHelper, backEventCompat, searchBar, VvLrTjxqdqJWEKCb(searchBar));
            android.animation.AnimatorHashSet animatorHashSet = this.backProgressAnimatorHashSet;
            if (animatorHashSet is not null) {
                BsfrwzabspkIsgOH(animatorHashSet, (long) (pXAiNPBzwobGOBZm(backEventCompat) * gWkEGeLIuAHjIcMv(this.backProgressAnimatorHashSet)));
                return;
            }
            if (MSrEZiQZnfDXOfTb(this.searchobject)) {
                BUVnqUZlrbNBlpMq(this.searchobject);
            }
            if (SdnpiuDcpcHeGuFx(this.searchobject)) {
                android.animation.AnimatorHashSet animatorHashSetIPSPTFDgGshsxTGP = IPSPTFDgGshsxTGP(this, false);
                this.backProgressAnimatorHashSet = animatorHashSetIPSPTFDgGshsxTGP;
                DyIxuQIBkVbhGlfi(animatorHashSetIPSPTFDgGshsxTGP);
                zbxxYcHpiXgCfsxT(this.backProgressAnimatorHashSet);
            }
        }
    }
}

