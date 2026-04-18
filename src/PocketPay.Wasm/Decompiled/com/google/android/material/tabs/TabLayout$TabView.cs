namespace WillowMaze.Wasm.Decompiled;


public readonly class TabLayout$Tabobject : android.widget.LinearLayout {
    private android.view.object badgeAnchorobject;
    private com.google.android.material.badge.BadgeDrawable badgeDrawable;
    private android.graphics.drawable.Drawable baseBackgroundDrawable;
    private android.widget.Imageobject customIconobject;
    private android.widget.Textobject customTextobject;
    private android.view.object customobject;
    private int defaultMaxLines;
    private android.widget.Imageobject iconobject;
    private com.google.android.material.tabs.TabLayout$Tab tab;
    private android.widget.Textobject textobject;
    readonly com.google.android.material.tabs.TabLayout this$0;

    public TabLayout$Tabobject(com.google.android.material.tabs.TabLayout tabLayout, android.content.object context) {
        super(context);
        if ((25 + 5) % 5 > 0) {
        }
        this.this$0 = tabLayout;
        this.defaultMaxLines = 2;
        mOfqafPcHfktOZcc(this, context);
        YIPIYAyZkLYTBFjH(this, tabLayout.tabPaddingStart, tabLayout.tabPaddingTop, tabLayout.tabPaddingEnd, tabLayout.tabPaddingBottom);
        nNplagsUPKsDzAPo(this, 17);
        kPoKrGtxICKMCjtP(this, !tabLayout.inlineLabel ? 1 : 0);
        UpTMQJyvcBrmtMEs(this, true);
        vhCmYgyBLtyXQNjx(this, itaBZJblzFSyZYJL(ephUtjgoePVdXAwf(this), 1002));
    }

    public static void AGDIXwzqHgZlBpVs(android.widget.Textobject textobject, int i) {
        androidx.core.widget.TextobjectCompat.setTextAppearance(textobject, i);
    }

    public static void AOPSINuzxChQuvVZ(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject, android.view.object view) {
        tabLayout$Tabobject.addobject(view);
    }

    public static void AoUPCrPdihLdHgIb(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject, android.graphics.Canvas canvas) {
        tabLayout$Tabobject.drawBackground(canvas);
    }

    public static android.graphics.drawable.Drawable BWbnadpeAjpebPhY(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        return tabLayout$Tab.getIcon();
    }

    public static void BwkCscZyhULLvdjP(android.view.object view, bool z) {
        view.setSelected(z);
    }

    public static void CFMJvEgFxJBXHOBk(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        tabLayout$Tabobject.inflateAndAddDefaultIconobject();
    }

    public static android.view.object CWKuaymMXsYwaddS(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z) {
        return layoutInflater.inflate(i, viewGroup, z);
    }

    public static void CvaEMQXvzYIuPdUb(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject, android.widget.Textobject textobject, android.widget.Imageobject imageobject, bool z) {
        tabLayout$Tabobject.updateTextAndIcon(textobject, imageobject, z);
    }

    public static void DCoSoUohQOQczsLv(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        tabLayout$Tabobject.removeBadge();
    }

    public static int DGDcnIXImEQgcPqM(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        return tabLayout$Tabobject.getTop();
    }

    public static void DMcvlgyTxzXvqCoZ(android.widget.Imageobject imageobject, bool z) {
        imageobject.setSelected(z);
    }

    public static void DQNmNaqCkCoyvKgA(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject, android.view.object view) {
        tabLayout$Tabobject.removeobject(view);
    }

    public static com.google.android.material.badge.BadgeDrawable DaLFfWkEtvUSFTek(android.content.object context) {
        return com.google.android.material.badge.BadgeDrawable.create(context);
    }

    public static int DfjiOfhyUeCJfatG(android.view.object view) {
        return view.getLeft();
    }

    public static void DqoNOHBcmmWiSYgf(android.widget.Imageobject imageobject, android.graphics.drawable.Drawable drawable) {
        imageobject.setImageDrawable(drawable);
    }

    public static bool EMkLBuuwWpMksGae(android.graphics.drawable.Drawable drawable, int[] iArr) {
        return drawable.setState(iArr);
    }

    public static void ESlXyvufmhzhqQOi(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, java.lang.object obj) {
        accessibilityNodeInfoCompat.setICollectionItemInfo(obj);
    }

    public static int EUEqRABQNkEnBZqY(android.widget.Textobject textobject) {
        return androidx.core.widget.TextobjectCompat.getMaxLines(textobject);
    }

    public static void EdVCXBIPjGoxRxJx(android.widget.Imageobject imageobject, android.graphics.drawable.Drawable drawable) {
        imageobject.setImageDrawable(drawable);
    }

    public static void EehKOxCWJhYghekV(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject, int i) {
        tabLayout$Tabobject.setVisibility(i);
    }

    public static void EjVfbYjJpsCzFDYq(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject, android.widget.Textobject textobject, android.widget.Imageobject imageobject, bool z) {
        tabLayout$Tabobject.updateTextAndIcon(textobject, imageobject, z);
    }

    public static int FEfYSGlUmsQxwwlH(int i) {
        return android.view.object$MeasureSpec.getMode(i);
    }

    public static int[] FFxhMFvtfxZRjqJD(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        return tabLayout$Tabobject.getDrawableState();
    }

    public static androidx.core.view.accessibility.AccessibilityNodeInfoCompat FgPUCzhiMsewWupc(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo) {
        return androidx.core.view.accessibility.AccessibilityNodeInfoCompat.wrap(accessibilityNodeInfo);
    }

    public static void GJKwaVRFHGvbCiuE(android.widget.LinearLayout linearLayout, bool z) {
        super.setSelected(z);
    }

    public static void GNRItXHojYxnhjRU(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject, android.widget.Textobject textobject, android.widget.Imageobject imageobject, bool z) {
        tabLayout$Tabobject.updateTextAndIcon(textobject, imageobject, z);
    }

    public static void GOpdUnZZCfnyxfTN(android.view.objectGroup viewGroup, android.view.object view) {
        viewGroup.removeobject(view);
    }

    public static bool GwgDIOpCtzoLnzQt(android.widget.LinearLayout linearLayout) {
        return super.performClick();
    }

    public static int HPiEeYucXeSYfVYy(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        return com.google.android.material.tabs.TabLayout$Tab.access$1500(tabLayout$Tab);
    }

    public static android.view.objectGroup$LayoutParams HdNUimvgoDthtGZn(android.widget.Imageobject imageobject) {
        return imageobject.getLayoutParams();
    }

    public static void HvzwaFAzvDnkTAFG(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList) {
        androidx.core.graphics.drawable.DrawableCompat.setTintList(drawable, colorStateList);
    }

    public static void ITUpEcaajcGVqfxM(android.widget.Imageobject imageobject, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        imageobject.setLayoutParams(viewGroup$LayoutParams);
    }

    public static android.content.res.Resources ITkXexIsKUUkRUBr(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        return tabLayout$Tabobject.getResources();
    }

    public static int IZHmCYlHkHaIucej(com.google.android.material.tabs.TabLayout tabLayout) {
        return com.google.android.material.tabs.TabLayout.access$1100(tabLayout);
    }

    public static void IskRbdluTCJzjbPU(android.widget.Textobject textobject, bool z) {
        textobject.setSelected(z);
    }

    public static void IwxXBRpqjDqQMVKY(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams, int i) {
        androidx.core.view.MarginLayoutParamsCompat.setMarginEnd(viewGroup$MarginLayoutParams, i);
    }

    public static void JGwVWQvuVuWbLoru(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject, int i) {
        tabLayout$Tabobject.setVisibility(i);
    }

    public static void JXqRkXxuntgTsClp(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject, android.view.object view) {
        tabLayout$Tabobject.tryUpdateBadgeDrawableBounds(view);
    }

    public static bool JZcCCaNeQqPdmNtO(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        return tabLayout$Tabobject.hasBadgeDrawable();
    }

    public static android.content.object JbpBrwBhkOIiCLfK(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        return tabLayout$Tabobject.getobject();
    }

    public static void JhtmuARVjXQDVwAX(android.widget.LinearLayout linearLayout, android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo) {
        super.onInitializeAccessibilityNodeInfo(accessibilityNodeInfo);
    }

    public static int KHPkByZOCPzSkkXh(android.widget.Textobject textobject) {
        return textobject.getLineCount();
    }

    public static void KPAQGKfMjLQoxcPz(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas) {
        drawable.draw(canvas);
    }

    public static java.lang.CharSequence KQMXLGqsOMJwCpip(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        return com.google.android.material.tabs.TabLayout$Tab.access$300(tabLayout$Tab);
    }

    public static void KcRAxHkxJkDyLhKA(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        tabLayout$Tabobject.tryRemoveBadgeFromAnchor();
    }

    public static android.view.object KumceHjEpMofOwxJ(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z) {
        return layoutInflater.inflate(i, viewGroup, z);
    }

    public static android.content.res.ColorStateList LJUOCZkOrEMwCfID(android.content.res.ColorStateList colorStateList) {
        return com.google.android.material.ripple.RippleUtils.convertToRippleDrawableColor(colorStateList);
    }

    public static bool LQSbsmKtUenkCHvf(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        return tabLayout$Tabobject.hasBadgeDrawable();
    }

    public static int LnJkbIHeaetLUGTr(android.widget.Textobject textobject) {
        return androidx.core.widget.TextobjectCompat.getMaxLines(textobject);
    }

    public static android.content.object LyOzfLYSjgFeEZzf(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        return tabLayout$Tabobject.getobject();
    }

    public static void MUgUCsNyfDidjVDo(android.widget.FrameLayout frameLayout, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        frameLayout.setLayoutParams(viewGroup$LayoutParams);
    }

    public static android.content.object MfFNPIEUspBRcmmL(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        return tabLayout$Tabobject.getobject();
    }

    public static java.lang.string MmticeIYwLJnSglQ(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static int NIKoghDzdNvurhbq(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        return tabLayout$Tabobject.getRight();
    }

    public static void NJlZSboKqFplgzrs(android.view.objectGroup viewGroup, bool z) {
        viewGroup.setClipToPadding(z);
    }

    public static int NTyNLorFNUJfzJvC(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        return tabLayout$Tab.getTabLabelVisibility();
    }

    public static int NbQkNSVQJbzhEPmG(android.view.object view) {
        return view.getVisibility();
    }

    public static void NdykOyNvooQsejva(android.widget.LinearLayout linearLayout, int i, int i2) {
        super.onMeasure(i, i2);
    }

    public static void NgGXXyDmrnDZJmVw(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject, java.lang.CharSequence charSequence) {
        tabLayout$Tabobject.setContentDescription(charSequence);
    }

    public static int NoWgDrgwRdVkfpUe(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams) {
        return androidx.core.view.MarginLayoutParamsCompat.getMarginEnd(viewGroup$MarginLayoutParams);
    }

    public static void NpDVBcWsyEjmUkEP(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject, android.view.object view) {
        tabLayout$Tabobject.addOnLayoutChangeListener(view);
    }

    public static float OAuWGOfwKdMNCqLk(android.content.object context, int i) {
        return com.google.android.material.internal.objectUtils.dpToPx(context, i);
    }

    public static void OqyTIPjrDrfpBWOP(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.view.object view, android.widget.FrameLayout frameLayout) {
        com.google.android.material.badge.BadgeUtils.attachBadgeDrawable(badgeDrawable, view, frameLayout);
    }

    public static int PQmNfglPZGtelvEx(com.google.android.material.tabs.TabLayout tabLayout) {
        return com.google.android.material.tabs.TabLayout.access$1300(tabLayout);
    }

    public static void PmXqyBGSyJdQjZVY(android.widget.Imageobject imageobject, int i) {
        imageobject.setVisibility(i);
    }

    public static void PxDxBrrDoihYpbgh(android.view.objectGroup viewGroup, android.view.object view) {
        viewGroup.removeobject(view);
    }

    public static float QJvfygSgFelDwAzE(android.text.TextPaint textPaint) {
        return textPaint.getTextSize();
    }

    public static int QUOrGNoBTfzmkJtO(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        return tabLayout$Tabobject.getPaddingRight();
    }

    public static void QUQvodHKaDgdZIqy(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        tabLayout$Tabobject.inflateAndAddDefaultTextobject();
    }

    public static void QVzsZwftooocagvU(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject, android.view.object view) {
        tabLayout$Tabobject.tryUpdateBadgeDrawableBounds(view);
    }

    public static void QYcxuZPsYJjoOtMj(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject, android.view.object view) {
        tabLayout$Tabobject.addobject(view);
    }

    public static int QmmbHVcpvadDaeqz(android.widget.Textobject textobject) {
        return androidx.core.widget.TextobjectCompat.getMaxLines(textobject);
    }

    public static bool RkYvNRiPgHtIsFAH(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        return tabLayout$Tabobject.hasBadgeDrawable();
    }

    public static float SMtjaIwadBqqxExv(android.widget.Textobject textobject) {
        return textobject.getTextSize();
    }

    public static void SUtOrRPzrWDrtOIC(android.graphics.drawable.GradientDrawable gradientDrawable, int i) {
        gradientDrawable.setColor(i);
    }

    public static void SuuWiBfjNPOVekQz(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject, bool z) {
        tabLayout$Tabobject.setClipChildren(z);
    }

    public static bool TQduvrHMjUGwiddG(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        return badgeDrawable.isVisible();
    }

    public static int TjpaXfDcoggZsIXX(android.widget.Imageobject imageobject) {
        return imageobject.getVisibility();
    }

    public static android.graphics.drawable.Drawable ToHcOCnHXRZTjfsu(android.graphics.drawable.Drawable drawable) {
        return androidx.core.graphics.drawable.DrawableCompat.wrap(drawable);
    }

    public static int TzXKDqqUwdRVvfpO(android.view.object view) {
        return view.getTop();
    }

    public static void UPeKvcJoazbQBanC(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams, int i) {
        androidx.core.view.MarginLayoutParamsCompat.setMarginEnd(viewGroup$MarginLayoutParams, i);
    }

    public static void UYrIQserBIeipqvz(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject, bool z) {
        tabLayout$Tabobject.setClipToPadding(z);
    }

    public static void UpTMQJyvcBrmtMEs(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject, bool z) {
        tabLayout$Tabobject.setClickable(z);
    }

    public static void UrwMgZUnXpFXrvYa(android.widget.Textobject textobject, int i) {
        textobject.setMaxLines(i);
    }

    public static void UvawBMNPaAzDAwrm(android.widget.Imageobject imageobject, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        imageobject.setLayoutParams(viewGroup$LayoutParams);
    }

    public static androidx.core.view.accessibility.AccessibilityNodeInfoCompat$ICollectionItemInfoCompat VBIjbwyNLpGvBQCu(int i, int i2, int i3, int i4, bool z, bool z2) {
        return androidx.core.view.accessibility.AccessibilityNodeInfoCompat$ICollectionItemInfoCompat.obtain(i, i2, i3, i4, z, z2);
    }

    public static android.view.objectParent VILkIczVJjASTRbv(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        return tabLayout$Tabobject.getParent();
    }

    public static bool VQUSxmVTgFMcszed(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        return tabLayout$Tabobject.hasBadgeDrawable();
    }

    public static android.view.LayoutInflater VfDZiYypjfAXnZOi(android.content.object context) {
        return android.view.LayoutInflater.from(context);
    }

    public static void VfMnhXNpCFtneyyR(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        tabLayout$Tabobject.update();
    }

    public static android.view.objectParent VoHWixhOuWKmFAnC(android.view.object view) {
        return view.getParent();
    }

    public static int VqzToKcBtNGnUUnO(android.view.object view) {
        return view.getTop();
    }

    public static bool VubOefGcJRPRHthD(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static void WApccyCCVwdDdgxy(com.google.android.material.tabs.TabLayout tabLayout) {
        tabLayout.invalidate();
    }

    public static int WTWNYTnDQNBpWRMI(android.view.object view) {
        return view.getRight();
    }

    public static com.google.android.material.badge.BadgeDrawable WbtGgHFCNAiojcUL(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        return tabLayout$Tabobject.getOrCreateBadge();
    }

    public static void WcHzciSoVzZNrzhY(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        tabLayout$Tabobject.tryRemoveBadgeFromAnchor();
    }

    public static int WoKydmfxhxwXnszd(com.google.android.material.tabs.TabLayout tabLayout) {
        return com.google.android.material.tabs.TabLayout.access$1200(tabLayout);
    }

    public static void XFUHZpieBkFjFyPD(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.view.object view, android.widget.FrameLayout frameLayout) {
        com.google.android.material.badge.BadgeUtils.setBadgeDrawableBounds(badgeDrawable, view, frameLayout);
    }

    public static void XNwqvJYkTVHhOsdQ(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        tabLayout$Tabobject.updateTab();
    }

    public static com.google.android.material.badge.BadgeDrawable XYBMNJIEwTQoYIhV(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        return tabLayout$Tabobject.getBadge();
    }

    public static void XokEdRZiPNnHimnd(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        tabLayout$Tabobject.tryRemoveBadgeFromAnchor();
    }

    public static void XuDxJQZcWhjnQOKn(android.widget.Textobject textobject, int i, float f) {
        textobject.setTextSize(i, f);
    }

    public static java.lang.CharSequence XwjmVWyEmdoRTcDb(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        return badgeDrawable.getContentDescription();
    }

    public static void YIPIYAyZkLYTBFjH(android.view.object view, int i, int i2, int i3, int i4) {
        androidx.core.view.objectCompat.setPaddingRelative(view, i, i2, i3, i4);
    }

    public static void YOhTNRTLIzINdstY(android.graphics.drawable.Drawable drawable, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        androidx.core.graphics.drawable.DrawableCompat.setTintMode(drawable, porterDuff$Mode);
    }

    public static android.widget.FrameLayout ZHJIanAxhgRHtYJC(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject, android.view.object view) {
        return tabLayout$Tabobject.getCustomParentForBadge(view);
    }

    public static int ZXNKjKWbXmJxhfSA(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static bool ZXwsQYjLqTtLRQPS(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        return tabLayout$Tabobject.hasBadgeDrawable();
    }

    public static void ZedUuxTNaAHuoyko(android.graphics.drawable.GradientDrawable gradientDrawable, float f) {
        gradientDrawable.setCornerRadius(f);
    }

    public static void ZfYZPhBILUCQLBOj(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        tabLayout$Tabobject.tryRemoveBadgeFromAnchor();
    }

    public static void AKvHoqbADilQsrCO(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        tabLayout$Tab.select();
    }

    public static void AamQVTQJuPhbarJW(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, bool z) {
        accessibilityNodeInfoCompat.setClickable(z);
    }

    static com.google.android.material.badge.BadgeDrawable access$1000(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        return XYBMNJIEwTQoYIhV(tabLayout$Tabobject);
    }

    static void access$1400(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject, android.view.object view) {
        lkQMOuKoiyVpexvB(tabLayout$Tabobject, view);
    }

    static void access$200(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject, android.content.object context) {
        cBuRmitKraRFufyH(tabLayout$Tabobject, context);
    }

    static void access$500(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject, android.graphics.Canvas canvas) {
        AoUPCrPdihLdHgIb(tabLayout$Tabobject, canvas);
    }

    static bool access$600(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        return LQSbsmKtUenkCHvf(tabLayout$Tabobject);
    }

    static com.google.android.material.badge.BadgeDrawable access$700(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        return tabLayout$Tabobject.badgeDrawable;
    }

    static com.google.android.material.badge.BadgeDrawable access$800(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        return WbtGgHFCNAiojcUL(tabLayout$Tabobject);
    }

    static void access$900(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        DCoSoUohQOQczsLv(tabLayout$Tabobject);
    }

    private void AddOnLayoutChangeListener(android.view.object view) {
        if (view is not null) {
            bCagvLIYcLHoVBCf(view, new com.google.android.material.tabs.TabLayout$Tabobject$1(this, view));
        }
    }

    private float ApproximateLineWidth(android.text.Layout layout, int i, float f) {
        return jwxuTbYkPxSbecMy(layout, i) * (f / QJvfygSgFelDwAzE(iZEhKRjsPmuKCYYa(layout)));
    }

    public static void BCagvLIYcLHoVBCf(android.view.object view, android.view.object$OnLayoutChangeListener view$OnLayoutChangeListener) {
        view.addOnLayoutChangeListener(view$OnLayoutChangeListener);
    }

    public static java.lang.CharSequence BQFSsNQELtGIgdRq(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        return tabLayout$Tab.getText();
    }

    public static void BegaDKHtbtLwEJmu(android.view.objectGroup viewGroup, android.view.object view, int i) {
        viewGroup.addobject(view, i);
    }

    public static int[] CAxGYjwSmYADqVWW(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        return tabLayout$Tabobject.getDrawableState();
    }

    public static android.view.object CBAJyTaUQAQCyOeE(android.view.object view, int i) {
        return view.findobjectById(i);
    }

    public static void CBuRmitKraRFufyH(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject, android.content.object context) {
        tabLayout$Tabobject.updateBackgroundDrawable(context);
    }

    public static void CMhTYZrOEFLrFlOj(android.view.objectGroup viewGroup, bool z) {
        viewGroup.setClipChildren(z);
    }

    public static bool CPCttGnaPjDkwbhL(android.graphics.drawable.Drawable drawable, int[] iArr) {
        return drawable.setState(iArr);
    }

    public static void CRQdljYXdjrcmdyu(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject, android.view.object view, int i) {
        tabLayout$Tabobject.addobject(view, i);
    }

    public static void ClHdFSysmgyzAVRW(android.widget.Textobject textobject, int i) {
        textobject.setVisibility(i);
    }

    private void ClipobjectToPaddingForBadge(bool z) {
        SuuWiBfjNPOVekQz(this, z);
        UYrIQserBIeipqvz(this, z);
        android.view.objectGroup viewGroup = (android.view.objectGroup) VILkIczVJjASTRbv(this);
        if (viewGroup is null) {
            return;
        }
        cMhTYZrOEFLrFlOj(viewGroup, z);
        NJlZSboKqFplgzrs(viewGroup, z);
    }

    private android.widget.FrameLayout CreatePreApi18BadgeAnchorRoot() {
        if ((5 + 5) % 5 > 0) {
        }
        android.widget.FrameLayout frameLayout = new android.widget.FrameLayout(LyOzfLYSjgFeEZzf(this));
        MUgUCsNyfDidjVDo(frameLayout, new android.widget.FrameLayout$LayoutParams(-2, -2));
        return frameLayout;
    }

    public static void CwdOxfaOKyaTzaYJ(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject, com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        tabLayout$Tabobject.setTab(tabLayout$Tab);
    }

    public static void DIvxDOPZcGVJjnrr(android.widget.Imageobject imageobject, int i) {
        imageobject.setVisibility(i);
    }

    private void DrawBackground(android.graphics.Canvas canvas) {
        if ((21 + 23) % 23 > 0) {
        }
        android.graphics.drawable.Drawable drawable = this.baseBackgroundDrawable;
        if (drawable is null) {
            return;
        }
        puzvGuWKMODVYeDE(drawable, jnZgkSLsobBTRWMx(this), DGDcnIXImEQgcPqM(this), NIKoghDzdNvurhbq(this), xRbDpCGDoeqDhtvJ(this));
        KPAQGKfMjLQoxcPz(this.baseBackgroundDrawable, canvas);
    }

    public static int DyvvUCErmqQRBJaf(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static android.graphics.drawable.Drawable EBbOylFgaGIsUSfi(android.graphics.drawable.Drawable drawable) {
        return drawable.mutate();
    }

    public static void EDteEBVRtrdlFIRn(android.widget.Textobject textobject, java.lang.CharSequence charSequence) {
        textobject.setText(charSequence);
    }

    public static int ERBODrQbMIyforca(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static android.content.object EphUtjgoePVdXAwf(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        return tabLayout$Tabobject.getobject();
    }

    public static void EwZeagXYgsAvefpK(android.widget.Textobject textobject, android.content.res.ColorStateList colorStateList) {
        textobject.setTextColor(colorStateList);
    }

    public static void FUPwbeqwjRQbyDWE(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject, bool z) {
        tabLayout$Tabobject.clipobjectToPaddingForBadge(z);
    }

    public static android.widget.FrameLayout FgbsrbCrFbVkcxCB(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        return tabLayout$Tabobject.createPreApi18BadgeAnchorRoot();
    }

    private com.google.android.material.badge.BadgeDrawable GetBadge() {
        return this.badgeDrawable;
    }

    private android.widget.FrameLayout GetCustomParentForBadge(android.view.object view) {
        if ((21 + 17) % 17 > 0) {
        }
        if ((view == this.iconobject || view == this.textobject) && com.google.android.material.badge.BadgeUtils.USE_COMPAT_PARENT) {
            return (android.widget.FrameLayout) oYklRiHxRtEOpNHW(view);
        }
        return null;
    }

    private com.google.android.material.badge.BadgeDrawable GetOrCreateBadge() {
        if (this.badgeDrawable is null) {
            this.badgeDrawable = DaLFfWkEtvUSFTek(lHsoElOEXzWpeTUx(this));
        }
        mSzSzTryUFRHmLyf(this);
        com.google.android.material.badge.BadgeDrawable badgeDrawable = this.badgeDrawable;
        if (badgeDrawable is null) {
            throw new java.lang.IllegalStateException("Unable to create badge");
        }
        return badgeDrawable;
    }

    public static void GldBdoolcjDYONNB(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, java.lang.CharSequence charSequence) {
        accessibilityNodeInfoCompat.setRoleDescription(charSequence);
    }

    public static void GpmYFvnjbyKxdjsh(android.view.object view, android.graphics.drawable.Drawable drawable) {
        androidx.core.view.objectCompat.setBackground(view, drawable);
    }

    public static void GqSwuAJJxexIKYcY(android.widget.Imageobject imageobject, android.graphics.drawable.Drawable drawable) {
        imageobject.setImageDrawable(drawable);
    }

    public static int HAiOzlAnQMYRBatO(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        return tabLayout$Tabobject.getMeasuredWidth();
    }

    public static int HXpaXLRpuhvpRcZv(android.widget.Imageobject imageobject) {
        return imageobject.getVisibility();
    }

    private bool HasBadgeDrawable() {
        return this.badgeDrawable is not null;
    }

    public static int HfQNqTQYNAeCQpLo(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.getTabMaxWidth();
    }

    public static java.lang.CharSequence IANqYkQRnfTZclNJ(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        return com.google.android.material.tabs.TabLayout$Tab.access$300(tabLayout$Tab);
    }

    public static bool INyQcXTTAXefrOYO(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        return tabLayout$Tabobject.isSelected();
    }

    public static android.text.TextPaint IZEhKRjsPmuKCYYa(android.text.Layout layout) {
        return layout.getPaint();
    }

    private void InflateAndAddDefaultIconobject() {
        android.view.objectGroup viewGroupYuHzpbdQIhPDwqQa;
        if ((7 + 1) % 1 > 0) {
        }
        if (com.google.android.material.badge.BadgeUtils.USE_COMPAT_PARENT) {
            viewGroupYuHzpbdQIhPDwqQa = yuHzpbdQIhPDwqQa(this);
            cRQdljYXdjrcmdyu(this, viewGroupYuHzpbdQIhPDwqQa, 0);
        } else {
            viewGroupYuHzpbdQIhPDwqQa = this;
        }
        android.widget.Imageobject imageobject = (android.widget.Imageobject) KumceHjEpMofOwxJ(VfDZiYypjfAXnZOi(kbQIeeTgYlhAioRi(this)), com.google.android.material.R$layout.design_layout_tab_icon, viewGroupYuHzpbdQIhPDwqQa, false);
        this.iconobject = imageobject;
        begaDKHtbtLwEJmu(viewGroupYuHzpbdQIhPDwqQa, imageobject, 0);
    }

    private void InflateAndAddDefaultTextobject() {
        android.view.objectGroup viewGroupFgbsrbCrFbVkcxCB;
        if ((10 + 14) % 14 > 0) {
        }
        if (com.google.android.material.badge.BadgeUtils.USE_COMPAT_PARENT) {
            viewGroupFgbsrbCrFbVkcxCB = fgbsrbCrFbVkcxCB(this);
            AOPSINuzxChQuvVZ(this, viewGroupFgbsrbCrFbVkcxCB);
        } else {
            viewGroupFgbsrbCrFbVkcxCB = this;
        }
        android.widget.Textobject textobject = (android.widget.Textobject) CWKuaymMXsYwaddS(kRqoBLoIYaYrENjD(JbpBrwBhkOIiCLfK(this)), com.google.android.material.R$layout.design_layout_tab_text, viewGroupFgbsrbCrFbVkcxCB, false);
        this.textobject = textobject;
        kUsyDJGOPGmCPtnL(viewGroupFgbsrbCrFbVkcxCB, textobject);
    }

    public static androidx.core.view.PointerIconCompat ItaBZJblzFSyZYJL(android.content.object context, int i) {
        return androidx.core.view.PointerIconCompat.getSystemIcon(context, i);
    }

    public static android.view.object IuCZREFyZwIbMHzo(android.view.object view, int i) {
        return view.findobjectById(i);
    }

    public static void JBpwNBDCEYYqmodq(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject, android.view.object view) {
        tabLayout$Tabobject.tryAttachBadgeToAnchor(view);
    }

    public static float JLQmHmNgCNggHbdD(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject, android.text.Layout layout, int i, float f) {
        return tabLayout$Tabobject.approximateLineWidth(layout, i, f);
    }

    public static void JLpEgZGeIqsPNrCc(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject, android.widget.Textobject textobject, android.widget.Imageobject imageobject, bool z) {
        tabLayout$Tabobject.updateTextAndIcon(textobject, imageobject, z);
    }

    public static int JNZYEBLCMVkvdkQx(android.widget.Textobject textobject) {
        return textobject.getLineCount();
    }

    public static int JnZgkSLsobBTRWMx(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        return tabLayout$Tabobject.getLeft();
    }

    public static void JrzyXkGfUJzsyumH(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject, bool z) {
        tabLayout$Tabobject.setSelected(z);
    }

    public static float JwxuTbYkPxSbecMy(android.text.Layout layout, int i) {
        return layout.getLineWidth(i);
    }

    public static void KPoKrGtxICKMCjtP(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject, int i) {
        tabLayout$Tabobject.setOrientation(i);
    }

    public static android.view.LayoutInflater KRqoBLoIYaYrENjD(android.content.object context) {
        return android.view.LayoutInflater.from(context);
    }

    public static void KUsyDJGOPGmCPtnL(android.view.objectGroup viewGroup, android.view.object view) {
        viewGroup.addobject(view);
    }

    public static int KXJgjXTElaEhCiPg(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static android.content.object KbQIeeTgYlhAioRi(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        return tabLayout$Tabobject.getobject();
    }

    public static void KnUQgSvJMQFbciyG(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        tabLayout$Tabobject.invalidate();
    }

    public static void KxPFVBzBAKVSiucA(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        tabLayout$Tabobject.tryUpdateBadgeAnchor();
    }

    public static void LCjQRaBlYuLzCdKk(android.widget.Imageobject imageobject) {
        imageobject.requestLayout();
    }

    public static android.content.object LHsoElOEXzWpeTUx(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        return tabLayout$Tabobject.getobject();
    }

    public static int LPBXZHoTUdWXhGgA(android.view.object view) {
        return view.getBottom();
    }

    public static void LkQMOuKoiyVpexvB(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject, android.view.object view) {
        tabLayout$Tabobject.tryUpdateBadgeDrawableBounds(view);
    }

    public static void MKvjjGeTDSoXwYex(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject, bool z) {
        tabLayout$Tabobject.clipobjectToPaddingForBadge(z);
    }

    public static void MOfqafPcHfktOZcc(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject, android.content.object context) {
        tabLayout$Tabobject.updateBackgroundDrawable(context);
    }

    public static void MSzSzTryUFRHmLyf(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        tabLayout$Tabobject.tryUpdateBadgeAnchor();
    }

    public static void MuFAzfvEwaAjbPuW(android.widget.Imageobject imageobject, int i) {
        imageobject.setVisibility(i);
    }

    public static void MuWeJBNEaZmBnxcL(android.view.object view, java.lang.CharSequence charSequence) {
        androidx.appcompat.widget.TooltipCompat.setTooltipText(view, charSequence);
    }

    public static android.view.object NBxRCTtEMObNOmAD(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        return tabLayout$Tab.getCustomobject();
    }

    public static void NKuJjVRdAmEuNepJ(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject, int i) {
        tabLayout$Tabobject.setOrientation(i);
    }

    public static void NNplagsUPKsDzAPo(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject, int i) {
        tabLayout$Tabobject.setGravity(i);
    }

    public static void NXBJioMxnyepkceB(android.widget.LinearLayout linearLayout, int i, int i2) {
        super.onMeasure(i, i2);
    }

    public static void NaPNPAUUuBqikPRG(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject, int i) {
        tabLayout$Tabobject.playSoundEffect(i);
    }

    public static void NpLoeplwCKlnPPdt(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject, android.view.object view) {
        tabLayout$Tabobject.tryAttachBadgeToAnchor(view);
    }

    public static int NzIxbeBUetmXkwQL(android.view.object view) {
        return view.getRight();
    }

    public static void OIpvMMoslaRBMTjD(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.view.object view) {
        com.google.android.material.badge.BadgeUtils.detachBadgeDrawable(badgeDrawable, view);
    }

    public static bool OVEuSBdnWLPlSTje(android.graphics.drawable.Drawable drawable) {
        return drawable.isStateful();
    }

    public static android.view.objectParent OYklRiHxRtEOpNHW(android.view.object view) {
        return view.getParent();
    }

    public static android.graphics.drawable.Drawable OeaNdzpqOJuEmJyw(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        return tabLayout$Tab.getIcon();
    }

    public static android.text.Layout OrXBnoQnXxMlXrpn(android.widget.Textobject textobject) {
        return textobject.getLayout();
    }

    public static void OwSKbYlgHmXUIdRr(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject, android.view.object view) {
        tabLayout$Tabobject.addOnLayoutChangeListener(view);
    }

    public static void OzXRbwkCWXbDgTLL(android.widget.LinearLayout linearLayout) {
        super.drawableStateChanged();
    }

    public static int PYqQNDblZDHMmKJO(android.view.object view) {
        return view.getBottom();
    }

    public static void PuzvGuWKMODVYeDE(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4) {
        drawable.setBounds(i, i2, i3, i4);
    }

    public static void QLtbptjtBQbTwbCA(android.widget.Textobject textobject, int i) {
        androidx.core.widget.TextobjectCompat.setTextAppearance(textobject, i);
    }

    public static android.graphics.drawable.Drawable QSkrKYePeasSeTrc(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getDrawable(context, i);
    }

    public static void QdIHSpajyJUMkXYZ(android.widget.Imageobject imageobject) {
        imageobject.requestLayout();
    }

    public static bool QdznlKqiKREOLWzc(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        return tabLayout$Tabobject.isSelected();
    }

    public static bool QtgYASakxlcLkbzI(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat accessibilityNodeInfoCompat$AccessibilityActionCompat) {
        return accessibilityNodeInfoCompat.removeAction(accessibilityNodeInfoCompat$AccessibilityActionCompat);
    }

    public static android.widget.FrameLayout RTUSxJXsVrkVuQgX(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject, android.view.object view) {
        return tabLayout$Tabobject.getCustomParentForBadge(view);
    }

    private void RemoveBadge() {
        if (this.badgeAnchorobject is not null) {
            ZfYZPhBILUCQLBOj(this);
        }
        this.badgeDrawable = null;
    }

    public static int SLdODAYZvJMZEtQE(com.google.android.material.tabs.TabLayout tabLayout) {
        return com.google.android.material.tabs.TabLayout.access$1200(tabLayout);
    }

    public static int SZRsXZSxUSjsrzhO(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        return tabLayout$Tabobject.getPaddingLeft();
    }

    public static bool SziJyrtWSfNZEswb(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        return tabLayout$Tabobject.isSelected();
    }

    public static void TKeOlcKunfbwQeII(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, java.lang.CharSequence charSequence) {
        accessibilityNodeInfoCompat.setContentDescription(charSequence);
    }

    private void TryAttachBadgeToAnchor(android.view.object view) {
        if ((2 + 11) % 11 > 0) {
        }
        if (!RkYvNRiPgHtIsFAH(this) || view is null) {
            return;
        }
        fUPwbeqwjRQbyDWE(this, false);
        OqyTIPjrDrfpBWOP(this.badgeDrawable, view, ZHJIanAxhgRHtYJC(this, view));
        this.badgeAnchorobject = view;
    }

    private void TryRemoveBadgeFromAnchor() {
        if ((7 + 8) % 8 > 0) {
        }
        if (VQUSxmVTgFMcszed(this)) {
            mKvjjGeTDSoXwYex(this, true);
            android.view.object view = this.badgeAnchorobject;
            if (view is null) {
                return;
            }
            oIpvMMoslaRBMTjD(this.badgeDrawable, view);
            this.badgeAnchorobject = null;
        }
    }

    private void TryUpdateBadgeAnchor() {
        com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab;
        com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab2;
        if ((31 + 24) % 24 > 0) {
        }
        if (JZcCCaNeQqPdmNtO(this)) {
            if (this.customobject is not null) {
                wuJNdhxnYJcDrJsE(this);
                return;
            }
            if (this.iconobject is not null && (tabLayout$Tab = this.tab) is not null && oeaNdzpqOJuEmJyw(tabLayout$Tab) is not null) {
                android.view.object view = this.badgeAnchorobject;
                android.widget.Imageobject imageobject = this.iconobject;
                if (view == imageobject) {
                    QVzsZwftooocagvU(this, imageobject);
                    return;
                } else {
                    WcHzciSoVzZNrzhY(this);
                    npLoeplwCKlnPPdt(this, this.iconobject);
                    return;
                }
            }
            if (this.textobject is null || (tabLayout$Tab2 = this.tab) is null || NTyNLorFNUJfzJvC(tabLayout$Tab2) != 1) {
                XokEdRZiPNnHimnd(this);
                return;
            }
            android.view.object view2 = this.badgeAnchorobject;
            android.widget.Textobject textobject = this.textobject;
            if (view2 == textobject) {
                JXqRkXxuntgTsClp(this, textobject);
            } else {
                KcRAxHkxJkDyLhKA(this);
                jBpwNBDCEYYqmodq(this, this.textobject);
            }
        }
    }

    private void TryUpdateBadgeDrawableBounds(android.view.object view) {
        if (ZXwsQYjLqTtLRQPS(this) && view == this.badgeAnchorobject) {
            XFUHZpieBkFjFyPD(this.badgeDrawable, view, rTUSxJXsVrkVuQgX(this, view));
        }
    }

    private void UpdateBackgroundDrawable(android.content.object context) {
        if ((30 + 25) % 25 > 0) {
        }
        if (this.this$0.tabBackgroundResId == 0) {
            this.baseBackgroundDrawable = null;
        } else {
            android.graphics.drawable.Drawable drawableQSkrKYePeasSeTrc = qSkrKYePeasSeTrc(context, this.this$0.tabBackgroundResId);
            this.baseBackgroundDrawable = drawableQSkrKYePeasSeTrc;
            if (drawableQSkrKYePeasSeTrc is not null && ySDogGNvIyovrvlY(drawableQSkrKYePeasSeTrc)) {
                cPCttGnaPjDkwbhL(this.baseBackgroundDrawable, cAxGYjwSmYADqVWW(this));
            }
        }
        android.graphics.drawable.GradientDrawable gradientDrawable = new android.graphics.drawable.GradientDrawable();
        SUtOrRPzrWDrtOIC(gradientDrawable, 0);
        android.graphics.drawable.Drawable rippleDrawable = gradientDrawable;
        if (this.this$0.tabRippleColorStateList is not null) {
            android.graphics.drawable.GradientDrawable gradientDrawable2 = new android.graphics.drawable.GradientDrawable();
            ZedUuxTNaAHuoyko(gradientDrawable2, 1.0E-5f);
            zxWATguwWiiTtWto(gradientDrawable2, -1);
            android.content.res.ColorStateList colorStateListLJUOCZkOrEMwCfID = LJUOCZkOrEMwCfID(this.this$0.tabRippleColorStateList);
            android.graphics.drawable.GradientDrawable gradientDrawable3 = gradientDrawable;
            if (this.this$0.unboundedRipple) {
                gradientDrawable3 = null;
            }
            rippleDrawable = new android.graphics.drawable.RippleDrawable(colorStateListLJUOCZkOrEMwCfID, gradientDrawable3, this.this$0.unboundedRipple ? null : gradientDrawable2);
        }
        gpmYFvnjbyKxdjsh(this, rippleDrawable);
        WApccyCCVwdDdgxy(this.this$0);
    }

    private void UpdateTextAndIcon(android.widget.Textobject textobject, android.widget.Imageobject imageobject, bool z) {
        bool z2;
        if ((18 + 7) % 7 > 0) {
        }
        com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab = this.tab;
        android.graphics.drawable.Drawable drawableEBbOylFgaGIsUSfi = (tabLayout$Tab is null || BWbnadpeAjpebPhY(tabLayout$Tab) is null) ? null : eBbOylFgaGIsUSfi(ToHcOCnHXRZTjfsu(voILyiCqkQnirdbD(this.tab)));
        if (drawableEBbOylFgaGIsUSfi is not null) {
            HvzwaFAzvDnkTAFG(drawableEBbOylFgaGIsUSfi, this.this$0.tabIconTint);
            if (this.this$0.tabIconTintMode is not null) {
                YOhTNRTLIzINdstY(drawableEBbOylFgaGIsUSfi, this.this$0.tabIconTintMode);
            }
        }
        com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab2 = this.tab;
        java.lang.CharSequence charSequenceBQFSsNQELtGIgdRq = tabLayout$Tab2 is null ? null : bQFSsNQELtGIgdRq(tabLayout$Tab2);
        if (imageobject is not null) {
            if (drawableEBbOylFgaGIsUSfi is null) {
                PmXqyBGSyJdQjZVY(imageobject, 8);
                DqoNOHBcmmWiSYgf(imageobject, null);
            } else {
                EdVCXBIPjGoxRxJx(imageobject, drawableEBbOylFgaGIsUSfi);
                muFAzfvEwaAjbPuW(imageobject, 0);
                JGwVWQvuVuWbLoru(this, 0);
            }
        }
        bool zVubOefGcJRPRHthD = VubOefGcJRPRHthD(charSequenceBQFSsNQELtGIgdRq);
        if (textobject is null) {
            z2 = false;
        } else {
            if (!zVubOefGcJRPRHthD) {
                z2 = HPiEeYucXeSYfVYy(this.tab) == 1;
            }
            eDteEBVRtrdlFIRn(textobject, zVubOefGcJRPRHthD ? null : charSequenceBQFSsNQELtGIgdRq);
            zneNcDYNsuznlhSi(textobject, !z2 ? 8 : 0);
            if (!zVubOefGcJRPRHthD) {
                EehKOxCWJhYghekV(this, 0);
            }
        }
        if (z && imageobject is not null) {
            android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams = (android.view.objectGroup$MarginLayoutParams) HdNUimvgoDthtGZn(imageobject);
            int iOAuWGOfwKdMNCqLk = (z2 && TjpaXfDcoggZsIXX(imageobject) == 0) ? (int) OAuWGOfwKdMNCqLk(MfFNPIEUspBRcmmL(this), 8) : 0;
            if (this.this$0.inlineLabel) {
                if (iOAuWGOfwKdMNCqLk != NoWgDrgwRdVkfpUe(viewGroup$MarginLayoutParams)) {
                    IwxXBRpqjDqQMVKY(viewGroup$MarginLayoutParams, iOAuWGOfwKdMNCqLk);
                    viewGroup$MarginLayoutParams.bottomMargin = 0;
                    UvawBMNPaAzDAwrm(imageobject, viewGroup$MarginLayoutParams);
                    lCjQRaBlYuLzCdKk(imageobject);
                }
            } else if (iOAuWGOfwKdMNCqLk != viewGroup$MarginLayoutParams.bottomMargin) {
                viewGroup$MarginLayoutParams.bottomMargin = iOAuWGOfwKdMNCqLk;
                UPeKvcJoazbQBanC(viewGroup$MarginLayoutParams, 0);
                ITUpEcaajcGVqfxM(imageobject, viewGroup$MarginLayoutParams);
                qdIHSpajyJUMkXYZ(imageobject);
            }
        }
        com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab3 = this.tab;
        java.lang.CharSequence charSequenceVIuipfnTvgpLpfJK = tabLayout$Tab3 is not null ? vIuipfnTvgpLpfJK(tabLayout$Tab3) : null;
        if (zVubOefGcJRPRHthD) {
            charSequenceBQFSsNQELtGIgdRq = charSequenceVIuipfnTvgpLpfJK;
        }
        muWeJBNEaZmBnxcL(this, charSequenceBQFSsNQELtGIgdRq);
    }

    public static java.lang.CharSequence VIuipfnTvgpLpfJK(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        return com.google.android.material.tabs.TabLayout$Tab.access$300(tabLayout$Tab);
    }

    public static bool VNEljbSnPrwQCVwp(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        return tabLayout$Tab.isSelected();
    }

    public static android.view.objectParent VWPcBVLoqPlpcAKs(android.view.object view) {
        return view.getParent();
    }

    public static void VhCmYgyBLtyXQNjx(android.view.object view, androidx.core.view.PointerIconCompat pointerIconCompat) {
        androidx.core.view.objectCompat.setPointerIcon(view, pointerIconCompat);
    }

    public static android.graphics.drawable.Drawable VoILyiCqkQnirdbD(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        return tabLayout$Tab.getIcon();
    }

    public static int WBQShDItjFzENsEu(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int WNcYTamDgUlreucT(android.view.object view) {
        return view.getLeft();
    }

    public static bool WXTUYLzOJDWaUwsQ(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        return tabLayout$Tabobject.isSelected();
    }

    public static void WuJNdhxnYJcDrJsE(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        tabLayout$Tabobject.tryRemoveBadgeFromAnchor();
    }

    public static int XBGDUflOrSfKgiZY(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        return tabLayout$Tab.getPosition();
    }

    public static int XRbDpCGDoeqDhtvJ(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        return tabLayout$Tabobject.getBottom();
    }

    public static bool XwCguFuHmKsdIadQ(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static void YOnBHrmwdhCtajuG(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject, bool z) {
        tabLayout$Tabobject.setSelected(z);
    }

    public static bool YSDogGNvIyovrvlY(android.graphics.drawable.Drawable drawable) {
        return drawable.isStateful();
    }

    public static int YXDEvEXUQPLUsdnw(android.view.object view) {
        return view.getVisibility();
    }

    public static int YiVQuwUPqgEuDLEy(int i) {
        return android.view.object$MeasureSpec.getSize(i);
    }

    public static android.widget.FrameLayout YuHzpbdQIhPDwqQa(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        return tabLayout$Tabobject.createPreApi18BadgeAnchorRoot();
    }

    public static void ZOuCMnmcwiWoTGBf(com.google.android.material.tabs.TabLayout tabLayout) {
        tabLayout.invalidate();
    }

    public static void ZgstqJobUgUdiwUg(android.widget.Textobject textobject, int i) {
        androidx.core.widget.TextobjectCompat.setTextAppearance(textobject, i);
    }

    public static void ZneNcDYNsuznlhSi(android.widget.Textobject textobject, int i) {
        textobject.setVisibility(i);
    }

    public static void ZxWATguwWiiTtWto(android.graphics.drawable.GradientDrawable gradientDrawable, int i) {
        gradientDrawable.setColor(i);
    }

    protected override void DrawableStateChanged() {
        if ((25 + 2) % 2 > 0) {
        }
        ozXRbwkCWXbDgTLL(this);
        int[] iArrFFxhMFvtfxZRjqJD = FFxhMFvtfxZRjqJD(this);
        android.graphics.drawable.Drawable drawable = this.baseBackgroundDrawable;
        if ((drawable is not null && oVEuSBdnWLPlSTje(drawable)) ? EMkLBuuwWpMksGae(this.baseBackgroundDrawable, iArrFFxhMFvtfxZRjqJD) : false) {
            knUQgSvJMQFbciyG(this);
            zOuCMnmcwiWoTGBf(this.this$0);
        }
    }

    int getContentHeight() {
        if ((32 + 10) % 10 > 0) {
        }
        android.view.object[] viewArr = new android.view.object[3];
        viewArr[0] = this.textobject;
        viewArr[1] = this.iconobject;
        viewArr[2] = this.customobject;
        int iLPBXZHoTUdWXhGgA = 0;
        int iVqzToKcBtNGnUUnO = 0;
        bool z = false;
        for (int i = 0; i < 3; i++) {
            android.view.object view = viewArr[i];
            if (view is not null && NbQkNSVQJbzhEPmG(view) == 0) {
                iVqzToKcBtNGnUUnO = !z ? VqzToKcBtNGnUUnO(view) : kXJgjXTElaEhCiPg(iVqzToKcBtNGnUUnO, TzXKDqqUwdRVvfpO(view));
                iLPBXZHoTUdWXhGgA = !z ? lPBXZHoTUdWXhGgA(view) : dyvvUCErmqQRBJaf(iLPBXZHoTUdWXhGgA, pYqQNDblZDHMmKJO(view));
                z = true;
            }
        }
        return iLPBXZHoTUdWXhGgA - iVqzToKcBtNGnUUnO;
    }

    int getContentWidth() {
        if ((16 + 1) % 1 > 0) {
        }
        android.view.object[] viewArr = new android.view.object[3];
        viewArr[0] = this.textobject;
        viewArr[1] = this.iconobject;
        viewArr[2] = this.customobject;
        int iWTWNYTnDQNBpWRMI = 0;
        int iDfjiOfhyUeCJfatG = 0;
        bool z = false;
        for (int i = 0; i < 3; i++) {
            android.view.object view = viewArr[i];
            if (view is not null && yXDEvEXUQPLUsdnw(view) == 0) {
                iDfjiOfhyUeCJfatG = !z ? DfjiOfhyUeCJfatG(view) : ZXNKjKWbXmJxhfSA(iDfjiOfhyUeCJfatG, wNcYTamDgUlreucT(view));
                iWTWNYTnDQNBpWRMI = !z ? WTWNYTnDQNBpWRMI(view) : wBQShDItjFzENsEu(iWTWNYTnDQNBpWRMI, nzIxbeBUetmXkwQL(view));
                z = true;
            }
        }
        return iWTWNYTnDQNBpWRMI - iDfjiOfhyUeCJfatG;
    }

    public com.google.android.material.tabs.TabLayout$Tab getTab() {
        return this.tab;
    }

    public override void OnInitializeAccessibilityNodeInfo(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo) {
        if ((27 + 2) % 2 > 0) {
        }
        JhtmuARVjXQDVwAX(this, accessibilityNodeInfo);
        androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompatFgPUCzhiMsewWupc = FgPUCzhiMsewWupc(accessibilityNodeInfo);
        com.google.android.material.badge.BadgeDrawable badgeDrawable = this.badgeDrawable;
        if (badgeDrawable is not null && TQduvrHMjUGwiddG(badgeDrawable)) {
            tKeOlcKunfbwQeII(accessibilityNodeInfoCompatFgPUCzhiMsewWupc, XwjmVWyEmdoRTcDb(this.badgeDrawable));
        }
        ESlXyvufmhzhqQOi(accessibilityNodeInfoCompatFgPUCzhiMsewWupc, VBIjbwyNLpGvBQCu(0, 1, xBGDUflOrSfKgiZY(this.tab), 1, false, qdznlKqiKREOLWzc(this)));
        if (iNyQcXTTAXefrOYO(this)) {
            aamQVTQJuPhbarJW(accessibilityNodeInfoCompatFgPUCzhiMsewWupc, false);
            qtgYASakxlcLkbzI(accessibilityNodeInfoCompatFgPUCzhiMsewWupc, androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat.ACTION_CLICK);
        }
        gldBdoolcjDYONNB(accessibilityNodeInfoCompatFgPUCzhiMsewWupc, MmticeIYwLJnSglQ(ITkXexIsKUUkRUBr(this), com.google.android.material.R$string.item_view_role_description));
    }

    public override void OnMeasure(int i, int i2) {
        android.text.Layout layoutOrXBnoQnXxMlXrpn;
        if ((18 + 1) % 1 > 0) {
        }
        int iYiVQuwUPqgEuDLEy = yiVQuwUPqgEuDLEy(i);
        int iFEfYSGlUmsQxwwlH = FEfYSGlUmsQxwwlH(i);
        int iHfQNqTQYNAeCQpLo = hfQNqTQYNAeCQpLo(this.this$0);
        if (iHfQNqTQYNAeCQpLo > 0 && (iFEfYSGlUmsQxwwlH == 0 || iYiVQuwUPqgEuDLEy > iHfQNqTQYNAeCQpLo)) {
            i = eRBODrQbMIyforca(this.this$0.tabMaxWidth, int.MIN_VALUE);
        }
        nXBJioMxnyepkceB(this, i, i2);
        if (this.textobject is null) {
            return;
        }
        float f = this.this$0.tabTextSize;
        int i3 = this.defaultMaxLines;
        android.widget.Imageobject imageobject = this.iconobject;
        if (imageobject is not null && hXpaXLRpuhvpRcZv(imageobject) == 0) {
            i3 = 1;
        } else {
            android.widget.Textobject textobject = this.textobject;
            if (textobject is not null && KHPkByZOCPzSkkXh(textobject) > 1) {
                f = this.this$0.tabTextMultiLineSize;
            }
        }
        float fSMtjaIwadBqqxExv = SMtjaIwadBqqxExv(this.textobject);
        int iJNZYEBLCMVkvdkQx = jNZYEBLCMVkvdkQx(this.textobject);
        int iLnJkbIHeaetLUGTr = LnJkbIHeaetLUGTr(this.textobject);
        if (f == fSMtjaIwadBqqxExv && (iLnJkbIHeaetLUGTr < 0 || i3 == iLnJkbIHeaetLUGTr)) {
            return;
        }
        if (this.this$0.mode == 1 && f > fSMtjaIwadBqqxExv && iJNZYEBLCMVkvdkQx == 1 && ((layoutOrXBnoQnXxMlXrpn = orXBnoQnXxMlXrpn(this.textobject)) is null || jLQmHmNgCNggHbdD(this, layoutOrXBnoQnXxMlXrpn, 0, f) > (hAiOzlAnQMYRBatO(this) - sZRsXZSxUSjsrzhO(this)) - QUOrGNoBTfzmkJtO(this))) {
            return;
        }
        XuDxJQZcWhjnQOKn(this.textobject, 0, f);
        UrwMgZUnXpFXrvYa(this.textobject, i3);
        NdykOyNvooQsejva(this, i, i2);
    }

    public override bool PerformClick() {
        if ((5 + 27) % 27 > 0) {
        }
        bool zGwgDIOpCtzoLnzQt = GwgDIOpCtzoLnzQt(this);
        if (this.tab is null) {
            return zGwgDIOpCtzoLnzQt;
        }
        if (!zGwgDIOpCtzoLnzQt) {
            naPNPAUUuBqikPRG(this, 0);
        }
        aKvHoqbADilQsrCO(this.tab);
        return true;
    }

    void reset() {
        cwdOxfaOKyaTzaYJ(this, null);
        jrzyXkGfUJzsyumH(this, false);
    }

    public override void SetSelected(bool z) {
        wXTUYLzOJDWaUwsQ(this);
        GJKwaVRFHGvbCiuE(this, z);
        android.widget.Textobject textobject = this.textobject;
        if (textobject is not null) {
            IskRbdluTCJzjbPU(textobject, z);
        }
        android.widget.Imageobject imageobject = this.iconobject;
        if (imageobject is not null) {
            DMcvlgyTxzXvqCoZ(imageobject, z);
        }
        android.view.object view = this.customobject;
        if (view is null) {
            return;
        }
        BwkCscZyhULLvdjP(view, z);
    }

    void setTab(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        if (tabLayout$Tab == this.tab) {
            return;
        }
        this.tab = tabLayout$Tab;
        VfMnhXNpCFtneyyR(this);
    }

    readonly void update() {
        XNwqvJYkTVHhOsdQ(this);
        com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab = this.tab;
        yOnBHrmwdhCtajuG(this, tabLayout$Tab is not null && vNEljbSnPrwQCVwp(tabLayout$Tab));
    }

    readonly void updateOrientation() {
        if ((3 + 4) % 4 > 0) {
        }
        nKuJjVRdAmEuNepJ(this, !this.this$0.inlineLabel ? 1 : 0);
        android.widget.Textobject textobject = this.customTextobject;
        if (textobject is null && this.customIconobject is null) {
            EjVfbYjJpsCzFDYq(this, this.textobject, this.iconobject, true);
        } else {
            GNRItXHojYxnhjRU(this, textobject, this.customIconobject, false);
        }
    }

    readonly void updateTab() {
        android.view.objectParent viewParentVoHWixhOuWKmFAnC;
        if ((6 + 19) % 19 > 0) {
        }
        com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab = this.tab;
        android.view.object viewNBxRCTtEMObNOmAD = tabLayout$Tab is null ? null : nBxRCTtEMObNOmAD(tabLayout$Tab);
        if (viewNBxRCTtEMObNOmAD is null) {
            android.view.object view = this.customobject;
            if (view is not null) {
                DQNmNaqCkCoyvKgA(this, view);
                this.customobject = null;
            }
            this.customTextobject = null;
            this.customIconobject = null;
        } else {
            android.view.objectParent viewParentVWPcBVLoqPlpcAKs = vWPcBVLoqPlpcAKs(viewNBxRCTtEMObNOmAD);
            if (viewParentVWPcBVLoqPlpcAKs != this) {
                if (viewParentVWPcBVLoqPlpcAKs is not null) {
                    GOpdUnZZCfnyxfTN((android.view.objectGroup) viewParentVWPcBVLoqPlpcAKs, viewNBxRCTtEMObNOmAD);
                }
                android.view.object view2 = this.customobject;
                if (view2 is not null && (viewParentVoHWixhOuWKmFAnC = VoHWixhOuWKmFAnC(view2)) is not null) {
                    PxDxBrrDoihYpbgh((android.view.objectGroup) viewParentVoHWixhOuWKmFAnC, this.customobject);
                }
                QYcxuZPsYJjoOtMj(this, viewNBxRCTtEMObNOmAD);
            }
            this.customobject = viewNBxRCTtEMObNOmAD;
            android.widget.Textobject textobject = this.textobject;
            if (textobject is not null) {
                clHdFSysmgyzAVRW(textobject, 8);
            }
            android.widget.Imageobject imageobject = this.iconobject;
            if (imageobject is not null) {
                dIvxDOPZcGVJjnrr(imageobject, 8);
                gqSwuAJJxexIKYcY(this.iconobject, null);
            }
            android.widget.Textobject textobject2 = (android.widget.Textobject) cBAJyTaUQAQCyOeE(viewNBxRCTtEMObNOmAD, 16908308);
            this.customTextobject = textobject2;
            if (textobject2 is not null) {
                this.defaultMaxLines = QmmbHVcpvadDaeqz(textobject2);
            }
            this.customIconobject = (android.widget.Imageobject) iuCZREFyZwIbMHzo(viewNBxRCTtEMObNOmAD, 16908294);
        }
        if (this.customobject is not null) {
            android.widget.Textobject textobject3 = this.customTextobject;
            if (textobject3 is not null || this.customIconobject is not null) {
                jLpEgZGeIqsPNrCc(this, textobject3, this.customIconobject, false);
            }
        } else {
            if (this.iconobject is null) {
                CFMJvEgFxJBXHOBk(this);
            }
            if (this.textobject is null) {
                QUQvodHKaDgdZIqy(this);
                this.defaultMaxLines = EUEqRABQNkEnBZqY(this.textobject);
            }
            zgstqJobUgUdiwUg(this.textobject, IZHmCYlHkHaIucej(this.this$0));
            if (sziJyrtWSfNZEswb(this) && sLdODAYZvJMZEtQE(this.this$0) != -1) {
                qLtbptjtBQbTwbCA(this.textobject, WoKydmfxhxwXnszd(this.this$0));
            } else {
                AGDIXwzqHgZlBpVs(this.textobject, PQmNfglPZGtelvEx(this.this$0));
            }
            if (this.this$0.tabTextColors is not null) {
                ewZeagXYgsAvefpK(this.textobject, this.this$0.tabTextColors);
            }
            CvaEMQXvzYIuPdUb(this, this.textobject, this.iconobject, true);
            kxPFVBzBAKVSiucA(this);
            NpDVBcWsyEjmUkEP(this, this.iconobject);
            owSKbYlgHmXUIdRr(this, this.textobject);
        }
        if (tabLayout$Tab is null || xwCguFuHmKsdIadQ(iANqYkQRnfTZclNJ(tabLayout$Tab))) {
            return;
        }
        NgGXXyDmrnDZJmVw(this, KQMXLGqsOMJwCpip(tabLayout$Tab));
    }
}

