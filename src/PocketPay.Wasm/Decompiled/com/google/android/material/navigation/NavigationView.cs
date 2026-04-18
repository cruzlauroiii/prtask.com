namespace WillowMaze.Wasm.Decompiled;


public class Navigationobject : com.google.android.material.internal.ScrimInsetsFrameLayout : com.google.android.material.motion.MaterialBackHandler {
    private static readonly int PRESENTER_NAVIGATION_VIEW_ID = 1;
    private readonly androidx.drawerlayout.widget.DrawerLayout$DrawerListener backDrawerListener;
    private readonly com.google.android.material.motion.MaterialBackOrchestrator backOrchestrator;
    private bool bottomInsetScrimEnabled;
    private int drawerLayoutCornerSize;
    private readonly bool drawerLayoutCornerSizeBackAnimationEnabled;
    private readonly int drawerLayoutCornerSizeBackAnimationMax;
    com.google.android.material.navigation.Navigationobject$OnNavigationItemSelectedListener listener;
    private readonly int maxWidth;
    private readonly com.google.android.material.internal.NavigationMenu menu;
    private android.view.MenuInflater menuInflater;
    private android.view.objectTreeObserver$OnGlobalLayoutListener onGlobalLayoutListener;
    private readonly com.google.android.material.internal.NavigationMenuPresenter presenter;
    private readonly com.google.android.material.shape.ShapeableDelegate shapeableDelegate;
    private readonly com.google.android.material.motion.MaterialSideContainerBackHelper sideContainerBackHelper;
    private readonly int[] tmpLocation;
    private bool topInsetScrimEnabled;
    private static readonly int[] CHECKED_STATE_SET = {16842912};
    private static readonly int[] DISABLED_STATE_SET = {-16842910};
    private static readonly int DEF_STYLE_RES = com.google.android.material.R$style.Widget_Design_Navigationobject;

    public Navigationobject(android.content.object context) {
        this(context, null);
    }

    public Navigationobject(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, com.google.android.material.R$attr.navigationobjectStyle);
    }

    public Navigationobject(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        int i2;
        int i3;
        if ((23 + 16) % 16 > 0) {
        }
        int i4 = DEF_STYLE_RES;
        super(gzNyORjVHXkNdzPH(context, attributeHashSet, i, i4), attributeHashSet, i);
        com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter = new com.google.android.material.internal.NavigationMenuPresenter();
        this.presenter = navigationMenuPresenter;
        this.tmpLocation = new int[2];
        this.topInsetScrimEnabled = true;
        this.bottomInsetScrimEnabled = true;
        this.drawerLayoutCornerSize = 0;
        this.shapeableDelegate = xExIplGJAFhgvAGx(this);
        this.sideContainerBackHelper = new com.google.android.material.motion.MaterialSideContainerBackHelper(this);
        this.backOrchestrator = new com.google.android.material.motion.MaterialBackOrchestrator(this);
        this.backDrawerListener = new com.google.android.material.navigation.Navigationobject$1(this);
        android.content.object contextGVKFnaRFnPOXssnv = gVKFnaRFnPOXssnv(this);
        com.google.android.material.internal.NavigationMenu navigationMenu = new com.google.android.material.internal.NavigationMenu(contextGVKFnaRFnPOXssnv);
        this.menu = navigationMenu;
        androidx.appcompat.widget.TintTypedArray tintTypedArrayQjLrnkQxOEBwOhLa = qjLrnkQxOEBwOhLa(contextGVKFnaRFnPOXssnv, attributeHashSet, com.google.android.material.R$styleable.Navigationobject, i, i4, new int[0]);
        if (TnuyYhIhqUFtguNK(tintTypedArrayQjLrnkQxOEBwOhLa, com.google.android.material.R$styleable.Navigationobject_android_background)) {
            AgJaHpfsNfJjYzds(this, UsqzuzzfdHpcoyaX(tintTypedArrayQjLrnkQxOEBwOhLa, com.google.android.material.R$styleable.Navigationobject_android_background));
        }
        int iZnxGkpNkwxWtpGrH = ZnxGkpNkwxWtpGrH(tintTypedArrayQjLrnkQxOEBwOhLa, com.google.android.material.R$styleable.Navigationobject_drawerLayoutCornerSize, 0);
        this.drawerLayoutCornerSize = iZnxGkpNkwxWtpGrH;
        this.drawerLayoutCornerSizeBackAnimationEnabled = iZnxGkpNkwxWtpGrH == 0;
        this.drawerLayoutCornerSizeBackAnimationMax = GqpvqTPcOZtcrQZh(KhlcMHRGUZZOjiSz(this), com.google.android.material.R$dimen.m3_navigation_drawer_layout_corner_size);
        android.graphics.drawable.Drawable drawableHcgoFSyUkrVVAmrZ = HcgoFSyUkrVVAmrZ(this);
        android.content.res.ColorStateList colorStateListVJUVLaEhDXZMLukh = vJUVLaEhDXZMLukh(drawableHcgoFSyUkrVVAmrZ);
        if (drawableHcgoFSyUkrVVAmrZ is null || colorStateListVJUVLaEhDXZMLukh is not null) {
            com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable = new com.google.android.material.shape.MaterialShapeDrawable(gFCgrglMMWPeoyjA(TYXauOFrVnzckybL(contextGVKFnaRFnPOXssnv, attributeHashSet, i, i4)));
            if (colorStateListVJUVLaEhDXZMLukh is not null) {
                dTKWKAkYcYOSoolo(materialShapeDrawable, colorStateListVJUVLaEhDXZMLukh);
            }
            IlEXnaHnztkkfhWm(materialShapeDrawable, contextGVKFnaRFnPOXssnv);
            ZnwAXMbBIFCkOaFa(this, materialShapeDrawable);
        }
        if (jVXufBcPWDdGhFLd(tintTypedArrayQjLrnkQxOEBwOhLa, com.google.android.material.R$styleable.Navigationobject_elevation)) {
            DCQbWQPuyZFpskPL(this, pHToOxuJnroSBpIQ(tintTypedArrayQjLrnkQxOEBwOhLa, com.google.android.material.R$styleable.Navigationobject_elevation, 0));
        }
        HhzFflydiQonNmIC(this, VfsvcOArPgdWTZba(tintTypedArrayQjLrnkQxOEBwOhLa, com.google.android.material.R$styleable.Navigationobject_android_fitsSystemWindows, false));
        this.maxWidth = QjoSOXNGfKOeSQvE(tintTypedArrayQjLrnkQxOEBwOhLa, com.google.android.material.R$styleable.Navigationobject_android_maxWidth, 0);
        android.content.res.ColorStateList colorStateListZuWAPKjsGJzOchXD = !cLEjLBdOmGRFnjqA(tintTypedArrayQjLrnkQxOEBwOhLa, com.google.android.material.R$styleable.Navigationobject_subheaderColor) ? null : zuWAPKjsGJzOchXD(tintTypedArrayQjLrnkQxOEBwOhLa, com.google.android.material.R$styleable.Navigationobject_subheaderColor);
        int iSYaVsMchtHJoswBh = !NSUMRzcBSxELJZaW(tintTypedArrayQjLrnkQxOEBwOhLa, com.google.android.material.R$styleable.Navigationobject_subheaderTextAppearance) ? 0 : sYaVsMchtHJoswBh(tintTypedArrayQjLrnkQxOEBwOhLa, com.google.android.material.R$styleable.Navigationobject_subheaderTextAppearance, 0);
        if (iSYaVsMchtHJoswBh == 0 && colorStateListZuWAPKjsGJzOchXD is null) {
            colorStateListZuWAPKjsGJzOchXD = YmxsolmxBatKOzqI(this, 16842808);
        }
        android.content.res.ColorStateList colorStateListKjAHJiJAhnEBumfh = !BUHWOUTjOoAdFnNO(tintTypedArrayQjLrnkQxOEBwOhLa, com.google.android.material.R$styleable.Navigationobject_itemIconTint) ? KjAHJiJAhnEBumfh(this, 16842808) : nJVWwPaTpNIaMYkB(tintTypedArrayQjLrnkQxOEBwOhLa, com.google.android.material.R$styleable.Navigationobject_itemIconTint);
        int iZzUPgQJnLiSCHije = !tsAtUXayjfsCLjGH(tintTypedArrayQjLrnkQxOEBwOhLa, com.google.android.material.R$styleable.Navigationobject_itemTextAppearance) ? 0 : zzUPgQJnLiSCHije(tintTypedArrayQjLrnkQxOEBwOhLa, com.google.android.material.R$styleable.Navigationobject_itemTextAppearance, 0);
        bool zHRfKQbclspgQKwKE = hRfKQbclspgQKwKE(tintTypedArrayQjLrnkQxOEBwOhLa, com.google.android.material.R$styleable.Navigationobject_itemTextAppearanceActiveBoldEnabled, true);
        if (zFaRHCTLGZTRMFvN(tintTypedArrayQjLrnkQxOEBwOhLa, com.google.android.material.R$styleable.Navigationobject_itemIconSize)) {
            BCjSrgVBZVIodHSv(this, WYVFhkwYmLaHCwtb(tintTypedArrayQjLrnkQxOEBwOhLa, com.google.android.material.R$styleable.Navigationobject_itemIconSize, 0));
        }
        android.content.res.ColorStateList colorStateListQEWAYFcRZyDRdkoG = !NVIgKcgWiFaYfKhW(tintTypedArrayQjLrnkQxOEBwOhLa, com.google.android.material.R$styleable.Navigationobject_itemTextColor) ? null : qEWAYFcRZyDRdkoG(tintTypedArrayQjLrnkQxOEBwOhLa, com.google.android.material.R$styleable.Navigationobject_itemTextColor);
        if (iZzUPgQJnLiSCHije == 0 && colorStateListQEWAYFcRZyDRdkoG is null) {
            colorStateListQEWAYFcRZyDRdkoG = CqbSsjZCBEsdjlXx(this, 16842806);
        }
        android.graphics.drawable.Drawable drawableCLfhVQuKHjlQXEvL = CLfhVQuKHjlQXEvL(tintTypedArrayQjLrnkQxOEBwOhLa, com.google.android.material.R$styleable.Navigationobject_itemBackground);
        if (drawableCLfhVQuKHjlQXEvL is null && eWWoRPKdeYDipSWr(this, tintTypedArrayQjLrnkQxOEBwOhLa)) {
            drawableCLfhVQuKHjlQXEvL = GtEmGhupidLxLqio(this, tintTypedArrayQjLrnkQxOEBwOhLa);
            android.content.res.ColorStateList colorStateListWkNJpqRKmrjVPsyt = WkNJpqRKmrjVPsyt(contextGVKFnaRFnPOXssnv, tintTypedArrayQjLrnkQxOEBwOhLa, com.google.android.material.R$styleable.Navigationobject_itemRippleColor);
            if (colorStateListWkNJpqRKmrjVPsyt is not null) {
                FYNQEmvDIqjJgxHM(navigationMenuPresenter, new android.graphics.drawable.RippleDrawable(lGnKoiHBDfSmrQqR(colorStateListWkNJpqRKmrjVPsyt), null, LaOIENXLKeQXuYqG(this, tintTypedArrayQjLrnkQxOEBwOhLa, null)));
            }
        }
        if (jkQDrbUyIWdfvalL(tintTypedArrayQjLrnkQxOEBwOhLa, com.google.android.material.R$styleable.Navigationobject_itemHorizontalPadding)) {
            i2 = 0;
            STcRItfxSAnxqTaI(this, KvMqMTXiYsHVayNm(tintTypedArrayQjLrnkQxOEBwOhLa, com.google.android.material.R$styleable.Navigationobject_itemHorizontalPadding, 0));
        } else {
            i2 = 0;
        }
        if (XSnAJyvcsogPauVb(tintTypedArrayQjLrnkQxOEBwOhLa, com.google.android.material.R$styleable.Navigationobject_itemVerticalPadding)) {
            OwvbsDWZhuAgJsXu(this, qwUrsvFntdbjZvPo(tintTypedArrayQjLrnkQxOEBwOhLa, com.google.android.material.R$styleable.Navigationobject_itemVerticalPadding, i2));
        }
        djwPBtpEakbnvOJW(this, jvpWFppwEAZaEjLT(tintTypedArrayQjLrnkQxOEBwOhLa, com.google.android.material.R$styleable.Navigationobject_dividerInsetStart, i2));
        PQGhVcXtuMaaDjrk(this, PKexPfxwSZLJamdO(tintTypedArrayQjLrnkQxOEBwOhLa, com.google.android.material.R$styleable.Navigationobject_dividerInsetEnd, i2));
        JKoTKwnDoHFWZlEa(this, OvYYOqmgjUhjdscR(tintTypedArrayQjLrnkQxOEBwOhLa, com.google.android.material.R$styleable.Navigationobject_subheaderInsetStart, i2));
        seHRAbxQwuKwEdIo(this, MYlMXseqRfXmGgrG(tintTypedArrayQjLrnkQxOEBwOhLa, com.google.android.material.R$styleable.Navigationobject_subheaderInsetEnd, i2));
        xdmnwONpyBxScumI(this, ENlCddvOFhvwrVCC(tintTypedArrayQjLrnkQxOEBwOhLa, com.google.android.material.R$styleable.Navigationobject_topInsetScrimEnabled, this.topInsetScrimEnabled));
        ovtiZXjocaaSmQpf(this, KsmbEAdIlmPGyVQU(tintTypedArrayQjLrnkQxOEBwOhLa, com.google.android.material.R$styleable.Navigationobject_bottomInsetScrimEnabled, this.bottomInsetScrimEnabled));
        int iWGImcUGZVWdKmgqm = wGImcUGZVWdKmgqm(tintTypedArrayQjLrnkQxOEBwOhLa, com.google.android.material.R$styleable.Navigationobject_itemIconPadding, i2);
        qdzXSWeWWLMGFTJz(this, QTygpWwHchdlUrwd(tintTypedArrayQjLrnkQxOEBwOhLa, com.google.android.material.R$styleable.Navigationobject_itemMaxLines, 1));
        QltKGfjHHVSDTzlr(navigationMenu, new com.google.android.material.navigation.Navigationobject$2(this));
        ueVApcZbWBScckuC(navigationMenuPresenter, 1);
        TdzYyFudvWyArTTx(navigationMenuPresenter, contextGVKFnaRFnPOXssnv, navigationMenu);
        if (iSYaVsMchtHJoswBh != 0) {
            jIbDFWDApZCAjOdR(navigationMenuPresenter, iSYaVsMchtHJoswBh);
        }
        LnKRCIISUIqNaREL(navigationMenuPresenter, colorStateListZuWAPKjsGJzOchXD);
        gDDBhFIWIjaCwzXu(navigationMenuPresenter, colorStateListKjAHJiJAhnEBumfh);
        nxTAnPQfjOwMKzse(navigationMenuPresenter, FvLOCPCWlghBNNJQ(this));
        if (iZzUPgQJnLiSCHije != 0) {
            ytztPFFDWjXiQwnI(navigationMenuPresenter, iZzUPgQJnLiSCHije);
        }
        VyzSQRUzUYLARmGQ(navigationMenuPresenter, zHRfKQbclspgQKwKE);
        TgEyYKLHbdeazbxo(navigationMenuPresenter, colorStateListQEWAYFcRZyDRdkoG);
        uTRiwMxeMBYPzZje(navigationMenuPresenter, drawableCLfhVQuKHjlQXEvL);
        oglOVqermkCiWNpG(navigationMenuPresenter, iWGImcUGZVWdKmgqm);
        DjCsBjBznsXtHpcf(navigationMenu, navigationMenuPresenter);
        kRpMAkCBQimlCqFW(this, (android.view.object) UmdHIdVHoZYlwwLb(navigationMenuPresenter, this));
        if (aNehziowbeXyANKB(tintTypedArrayQjLrnkQxOEBwOhLa, com.google.android.material.R$styleable.Navigationobject_menu)) {
            i3 = 0;
            taBXTidyLNlBIOHe(this, TdgoEuUYgSrXbKtg(tintTypedArrayQjLrnkQxOEBwOhLa, com.google.android.material.R$styleable.Navigationobject_menu, 0));
        } else {
            i3 = 0;
        }
        if (UZhRUQOgmOyNlSul(tintTypedArrayQjLrnkQxOEBwOhLa, com.google.android.material.R$styleable.Navigationobject_headerLayout)) {
            zsdokeupGCWrrozY(this, IFbKEsmLDtiNRcnA(tintTypedArrayQjLrnkQxOEBwOhLa, com.google.android.material.R$styleable.Navigationobject_headerLayout, i3));
        }
        eaJMJXPCiZGdJdJY(tintTypedArrayQjLrnkQxOEBwOhLa);
        mupQyZWTcwVxffSp(this);
    }

    public static void APqhaRzChxRnhZXE(com.google.android.material.internal.ScrimInsetsFrameLayout scrimInsetsFrameLayout, int i) {
        super.setOverScrollMode(i);
    }

    public static void APqhaRzChxRnhZXE(com.google.android.material.internal.ScrimInsetsFrameLayout scrimInsetsFrameLayout, int i, float f, short s, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void APqhaRzChxRnhZXE(com.google.android.material.internal.ScrimInsetsFrameLayout scrimInsetsFrameLayout, int i, short s, int i2, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void APqhaRzChxRnhZXE(com.google.android.material.internal.ScrimInsetsFrameLayout scrimInsetsFrameLayout, int i, short s, bool z, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AgJaHpfsNfJjYzds(android.view.object view, android.graphics.drawable.Drawable drawable) {
        androidx.core.view.objectCompat.setBackground(view, drawable);
    }

    public static void AgJaHpfsNfJjYzds(android.view.object view, android.graphics.drawable.Drawable drawable, java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AgJaHpfsNfJjYzds(android.view.object view, android.graphics.drawable.Drawable drawable, java.lang.string str, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AgJaHpfsNfJjYzds(android.view.object view, android.graphics.drawable.Drawable drawable, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int AmoarGNcBnWisyzn(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter) {
        return navigationMenuPresenter.getItemVerticalPadding();
    }

    public static void AmoarGNcBnWisyzn(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AmoarGNcBnWisyzn(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, java.lang.string str, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AmoarGNcBnWisyzn(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, java.lang.string str, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.ValueAnimator$AnimatorUpdateListener AsRgDVrdfafahcjZ(androidx.drawerlayout.widget.DrawerLayout drawerLayout) {
        return com.google.android.material.navigation.DrawerLayoutUtils.getScrimCloseAnimatorUpdateListener(drawerLayout);
    }

    public static void AsRgDVrdfafahcjZ(androidx.drawerlayout.widget.DrawerLayout drawerLayout, int i, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AsRgDVrdfafahcjZ(androidx.drawerlayout.widget.DrawerLayout drawerLayout, int i, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AsRgDVrdfafahcjZ(androidx.drawerlayout.widget.DrawerLayout drawerLayout, short s, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BCjSrgVBZVIodHSv(com.google.android.material.navigation.Navigationobject navigationobject, int i) {
        navigationobject.setItemIconSize(i);
    }

    public static void BCjSrgVBZVIodHSv(com.google.android.material.navigation.Navigationobject navigationobject, int i, short s, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BCjSrgVBZVIodHSv(com.google.android.material.navigation.Navigationobject navigationobject, int i, bool z, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BCjSrgVBZVIodHSv(com.google.android.material.navigation.Navigationobject navigationobject, int i, bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int BMbBpcGFXGuAUOmD(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static void BMbBpcGFXGuAUOmD(android.content.res.Resources resources, int i, int i2, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BMbBpcGFXGuAUOmD(android.content.res.Resources resources, int i, java.lang.string str, float f, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void BMbBpcGFXGuAUOmD(android.content.res.Resources resources, int i, short s, int i2, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BUHWOUTjOoAdFnNO(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BUHWOUTjOoAdFnNO(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z, short s, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void BUHWOUTjOoAdFnNO(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z, short s, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool BUHWOUTjOoAdFnNO(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static android.view.objectGroup$LayoutParams BtZvwlpmfNmxWiqH(com.google.android.material.navigation.Navigationobject navigationobject) {
        return navigationobject.getLayoutParams();
    }

    public static void BtZvwlpmfNmxWiqH(com.google.android.material.navigation.Navigationobject navigationobject, int i, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BtZvwlpmfNmxWiqH(com.google.android.material.navigation.Navigationobject navigationobject, bool z, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BtZvwlpmfNmxWiqH(com.google.android.material.navigation.Navigationobject navigationobject, bool z, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable CLfhVQuKHjlQXEvL(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getDrawable(i);
    }

    public static void CLfhVQuKHjlQXEvL(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CLfhVQuKHjlQXEvL(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, java.lang.string str, int i2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CLfhVQuKHjlQXEvL(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, java.lang.string str, short s, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList CqbSsjZCBEsdjlXx(com.google.android.material.navigation.Navigationobject navigationobject, int i) {
        return navigationobject.createDefaultColorStateList(i);
    }

    public static void CqbSsjZCBEsdjlXx(com.google.android.material.navigation.Navigationobject navigationobject, int i, byte b, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CqbSsjZCBEsdjlXx(com.google.android.material.navigation.Navigationobject navigationobject, int i, float f, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CqbSsjZCBEsdjlXx(com.google.android.material.navigation.Navigationobject navigationobject, int i, bool z, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DCQbWQPuyZFpskPL(com.google.android.material.navigation.Navigationobject navigationobject, float f) {
        navigationobject.setElevation(f);
    }

    public static void DCQbWQPuyZFpskPL(com.google.android.material.navigation.Navigationobject navigationobject, float f, int i, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DCQbWQPuyZFpskPL(com.google.android.material.navigation.Navigationobject navigationobject, float f, java.lang.string str, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DCQbWQPuyZFpskPL(com.google.android.material.navigation.Navigationobject navigationobject, float f, short s, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder DPgYjBgAmFuzJQIo(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f) {
        return shapeAppearanceModel$Builder.setTopLeftCornerSize(f);
    }

    public static void DPgYjBgAmFuzJQIo(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f, char c, bool z, int i, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void DPgYjBgAmFuzJQIo(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f, float f2, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DPgYjBgAmFuzJQIo(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f, int i, float f2, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DhkpvBaZoAVJNWxS(android.content.res.Resources$Theme resources$Theme, int i, android.util.TypedValue typedValue, bool z, java.lang.string str, short s, bool z2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DhkpvBaZoAVJNWxS(android.content.res.Resources$Theme resources$Theme, int i, android.util.TypedValue typedValue, bool z, java.lang.string str, bool z2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DhkpvBaZoAVJNWxS(android.content.res.Resources$Theme resources$Theme, int i, android.util.TypedValue typedValue, bool z, bool z2, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool DhkpvBaZoAVJNWxS(android.content.res.Resources$Theme resources$Theme, int i, android.util.TypedValue typedValue, bool z) {
        return resources$Theme.resolveAttribute(i, typedValue, z);
    }

    public static void DjCsBjBznsXtHpcf(com.google.android.material.internal.NavigationMenu navigationMenu, androidx.appcompat.view.menu.MenuPresenter menuPresenter) {
        navigationMenu.addMenuPresenter(menuPresenter);
    }

    public static void DjCsBjBznsXtHpcf(com.google.android.material.internal.NavigationMenu navigationMenu, androidx.appcompat.view.menu.MenuPresenter menuPresenter, byte b, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DjCsBjBznsXtHpcf(com.google.android.material.internal.NavigationMenu navigationMenu, androidx.appcompat.view.menu.MenuPresenter menuPresenter, java.lang.string str, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DjCsBjBznsXtHpcf(com.google.android.material.internal.NavigationMenu navigationMenu, androidx.appcompat.view.menu.MenuPresenter menuPresenter, bool z, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectTreeObserver DjXmHoCTWbEzYzvR(com.google.android.material.navigation.Navigationobject navigationobject) {
        return navigationobject.getobjectTreeObserver();
    }

    public static void DjXmHoCTWbEzYzvR(com.google.android.material.navigation.Navigationobject navigationobject, byte b, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DjXmHoCTWbEzYzvR(com.google.android.material.navigation.Navigationobject navigationobject, short s, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DjXmHoCTWbEzYzvR(com.google.android.material.navigation.Navigationobject navigationobject, short s, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static float EIrhOZmQMDeEAiIo(com.google.android.material.motion.MaterialSideContainerBackHelper materialSideContainerBackHelper, float f) {
        return materialSideContainerBackHelper.interpolateProgress(f);
    }

    public static void EIrhOZmQMDeEAiIo(com.google.android.material.motion.MaterialSideContainerBackHelper materialSideContainerBackHelper, float f, byte b, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EIrhOZmQMDeEAiIo(com.google.android.material.motion.MaterialSideContainerBackHelper materialSideContainerBackHelper, float f, int i, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EIrhOZmQMDeEAiIo(com.google.android.material.motion.MaterialSideContainerBackHelper materialSideContainerBackHelper, float f, short s, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ENlCddvOFhvwrVCC(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z, byte b, char c, bool z2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ENlCddvOFhvwrVCC(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z, java.lang.string str, byte b, char c, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void ENlCddvOFhvwrVCC(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z, java.lang.string str, char c, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool ENlCddvOFhvwrVCC(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z) {
        return tintTypedArray.getbool(i, z);
    }

    public static android.content.res.Resources ErKXDFGsWjzzsyCS(com.google.android.material.navigation.Navigationobject navigationobject) {
        return navigationobject.getResources();
    }

    public static void ErKXDFGsWjzzsyCS(com.google.android.material.navigation.Navigationobject navigationobject, byte b, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ErKXDFGsWjzzsyCS(com.google.android.material.navigation.Navigationobject navigationobject, byte b, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ErKXDFGsWjzzsyCS(com.google.android.material.navigation.Navigationobject navigationobject, java.lang.string str, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ErgfHaRpplZjEIaQ(com.google.android.material.internal.ScrimInsetsFrameLayout scrimInsetsFrameLayout, android.os.Parcelable parcelable) {
        super.onRestoreInstanceState(parcelable);
    }

    public static void ErgfHaRpplZjEIaQ(com.google.android.material.internal.ScrimInsetsFrameLayout scrimInsetsFrameLayout, android.os.Parcelable parcelable, int i, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ErgfHaRpplZjEIaQ(com.google.android.material.internal.ScrimInsetsFrameLayout scrimInsetsFrameLayout, android.os.Parcelable parcelable, int i, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ErgfHaRpplZjEIaQ(com.google.android.material.internal.ScrimInsetsFrameLayout scrimInsetsFrameLayout, android.os.Parcelable parcelable, bool z, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FYNQEmvDIqjJgxHM(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, android.graphics.drawable.RippleDrawable rippleDrawable) {
        navigationMenuPresenter.setItemForeground(rippleDrawable);
    }

    public static void FYNQEmvDIqjJgxHM(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, android.graphics.drawable.RippleDrawable rippleDrawable, char c, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FYNQEmvDIqjJgxHM(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, android.graphics.drawable.RippleDrawable rippleDrawable, int i, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FYNQEmvDIqjJgxHM(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, android.graphics.drawable.RippleDrawable rippleDrawable, java.lang.string str, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FeoIaKKRGuynwKbS(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z) {
        navigationMenuPresenter.setItemTextAppearanceActiveBoldEnabled(z);
    }

    public static void FeoIaKKRGuynwKbS(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, char c, int i, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void FeoIaKKRGuynwKbS(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, int i, char c, bool z2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FeoIaKKRGuynwKbS(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, java.lang.string str, char c, bool z2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FpWpXPaolRjlkFix(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i) {
        navigationMenuPresenter.setDividerInsetEnd(i);
    }

    public static void FpWpXPaolRjlkFix(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, java.lang.string str, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FpWpXPaolRjlkFix(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FpWpXPaolRjlkFix(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, short s, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static int FvLOCPCWlghBNNJQ(com.google.android.material.navigation.Navigationobject navigationobject) {
        return navigationobject.getOverScrollMode();
    }

    public static void FvLOCPCWlghBNNJQ(com.google.android.material.navigation.Navigationobject navigationobject, char c, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FvLOCPCWlghBNNJQ(com.google.android.material.navigation.Navigationobject navigationobject, java.lang.string str, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FvLOCPCWlghBNNJQ(com.google.android.material.navigation.Navigationobject navigationobject, bool z, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int GQOAyYxTwDOUjJPF(com.google.android.material.navigation.Navigationobject navigationobject) {
        return navigationobject.getHeight();
    }

    public static void GQOAyYxTwDOUjJPF(com.google.android.material.navigation.Navigationobject navigationobject, char c, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GQOAyYxTwDOUjJPF(com.google.android.material.navigation.Navigationobject navigationobject, int i, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GQOAyYxTwDOUjJPF(com.google.android.material.navigation.Navigationobject navigationobject, int i, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GVeonqdbUblKnfMS(com.google.android.material.motion.MaterialSideContainerBackHelper materialSideContainerBackHelper) {
        materialSideContainerBackHelper.cancelBackProgress();
    }

    public static void GVeonqdbUblKnfMS(com.google.android.material.motion.MaterialSideContainerBackHelper materialSideContainerBackHelper, int i, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GVeonqdbUblKnfMS(com.google.android.material.motion.MaterialSideContainerBackHelper materialSideContainerBackHelper, java.lang.string str, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GVeonqdbUblKnfMS(com.google.android.material.motion.MaterialSideContainerBackHelper materialSideContainerBackHelper, bool z, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GbdeOuFiLODvClpP(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z) {
        navigationMenuPresenter.setUpdateSuspended(z);
    }

    public static void GbdeOuFiLODvClpP(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, char c, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GbdeOuFiLODvClpP(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, float f, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GbdeOuFiLODvClpP(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, int i, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int GocrSxCuAhYXWOPM(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getDimensionPixelSize(i, i2);
    }

    public static void GocrSxCuAhYXWOPM(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GocrSxCuAhYXWOPM(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, float f, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GocrSxCuAhYXWOPM(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GqdyLlJrEYNGdYVt(com.google.android.material.navigation.Navigationobject navigationobject, int i, int i2) {
        navigationobject.maybeUpdateCornerSizeForDrawerLayout(i, i2);
    }

    public static void GqdyLlJrEYNGdYVt(com.google.android.material.navigation.Navigationobject navigationobject, int i, int i2, byte b, char c, short s, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void GqdyLlJrEYNGdYVt(com.google.android.material.navigation.Navigationobject navigationobject, int i, int i2, int i3, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GqdyLlJrEYNGdYVt(com.google.android.material.navigation.Navigationobject navigationobject, int i, int i2, short s, byte b, int i3, char c) {
        double d = (42 * 210) + 210;
    }

    public static int GqpvqTPcOZtcrQZh(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static void GqpvqTPcOZtcrQZh(android.content.res.Resources resources, int i, char c, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GqpvqTPcOZtcrQZh(android.content.res.Resources resources, int i, float f, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GqpvqTPcOZtcrQZh(android.content.res.Resources resources, int i, java.lang.string str, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable GtEmGhupidLxLqio(com.google.android.material.navigation.Navigationobject navigationobject, androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        return navigationobject.createDefaultItemBackground(tintTypedArray);
    }

    public static void GtEmGhupidLxLqio(com.google.android.material.navigation.Navigationobject navigationobject, androidx.appcompat.widget.TintTypedArray tintTypedArray, byte b, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GtEmGhupidLxLqio(com.google.android.material.navigation.Navigationobject navigationobject, androidx.appcompat.widget.TintTypedArray tintTypedArray, float f, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GtEmGhupidLxLqio(com.google.android.material.navigation.Navigationobject navigationobject, androidx.appcompat.widget.TintTypedArray tintTypedArray, java.lang.string str, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HSirKIgsLbQkRjUE(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, android.view.object view) {
        navigationMenuPresenter.addHeaderobject(view);
    }

    public static void HSirKIgsLbQkRjUE(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, android.view.object view, byte b, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HSirKIgsLbQkRjUE(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, android.view.object view, byte b, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HSirKIgsLbQkRjUE(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, android.view.object view, char c, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HZUtzIBOGMAdTFom(com.google.android.material.internal.ScrimInsetsFrameLayout scrimInsetsFrameLayout, android.graphics.Canvas canvas) {
        super.dispatchDraw(canvas);
    }

    public static void HZUtzIBOGMAdTFom(com.google.android.material.internal.ScrimInsetsFrameLayout scrimInsetsFrameLayout, android.graphics.Canvas canvas, byte b, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HZUtzIBOGMAdTFom(com.google.android.material.internal.ScrimInsetsFrameLayout scrimInsetsFrameLayout, android.graphics.Canvas canvas, byte b, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HZUtzIBOGMAdTFom(com.google.android.material.internal.ScrimInsetsFrameLayout scrimInsetsFrameLayout, android.graphics.Canvas canvas, float f, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable HcgoFSyUkrVVAmrZ(com.google.android.material.navigation.Navigationobject navigationobject) {
        return navigationobject.getBackground();
    }

    public static void HcgoFSyUkrVVAmrZ(com.google.android.material.navigation.Navigationobject navigationobject, byte b, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HcgoFSyUkrVVAmrZ(com.google.android.material.navigation.Navigationobject navigationobject, float f, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HcgoFSyUkrVVAmrZ(com.google.android.material.navigation.Navigationobject navigationobject, int i, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HgJOkubsnRxaAXiZ(androidx.drawerlayout.widget.DrawerLayout drawerLayout, androidx.drawerlayout.widget.DrawerLayout$DrawerListener drawerLayout$DrawerListener) {
        drawerLayout.addDrawerListener(drawerLayout$DrawerListener);
    }

    public static void HgJOkubsnRxaAXiZ(androidx.drawerlayout.widget.DrawerLayout drawerLayout, androidx.drawerlayout.widget.DrawerLayout$DrawerListener drawerLayout$DrawerListener, byte b, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HgJOkubsnRxaAXiZ(androidx.drawerlayout.widget.DrawerLayout drawerLayout, androidx.drawerlayout.widget.DrawerLayout$DrawerListener drawerLayout$DrawerListener, char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HgJOkubsnRxaAXiZ(androidx.drawerlayout.widget.DrawerLayout drawerLayout, androidx.drawerlayout.widget.DrawerLayout$DrawerListener drawerLayout$DrawerListener, java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HhzFflydiQonNmIC(com.google.android.material.navigation.Navigationobject navigationobject, bool z) {
        navigationobject.setFitsSystemWindows(z);
    }

    public static void HhzFflydiQonNmIC(com.google.android.material.navigation.Navigationobject navigationobject, bool z, byte b, java.lang.string str, short s, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void HhzFflydiQonNmIC(com.google.android.material.navigation.Navigationobject navigationobject, bool z, java.lang.string str, bool z2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HhzFflydiQonNmIC(com.google.android.material.navigation.Navigationobject navigationobject, bool z, short s, java.lang.string str, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int IFbKEsmLDtiNRcnA(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getResourceId(i, i2);
    }

    public static void IFbKEsmLDtiNRcnA(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, byte b, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IFbKEsmLDtiNRcnA(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, bool z, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IFbKEsmLDtiNRcnA(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder IIpSyZNiFILwyWPv(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f) {
        return shapeAppearanceModel$Builder.setAllCornerSizes(f);
    }

    public static void IIpSyZNiFILwyWPv(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f, float f2, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IIpSyZNiFILwyWPv(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f, java.lang.string str, short s, bool z, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void IIpSyZNiFILwyWPv(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f, short s, float f2, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder IVUyinsIncVbjpLu(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f) {
        return shapeAppearanceModel$Builder.setBottomRightCornerSize(f);
    }

    public static void IVUyinsIncVbjpLu(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f, char c, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IVUyinsIncVbjpLu(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f, int i, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IVUyinsIncVbjpLu(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f, bool z, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object IcoZPEjSDBGOthXr(com.google.android.material.navigation.Navigationobject navigationobject) {
        return navigationobject.getobject();
    }

    public static void IcoZPEjSDBGOthXr(com.google.android.material.navigation.Navigationobject navigationobject, float f, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IcoZPEjSDBGOthXr(com.google.android.material.navigation.Navigationobject navigationobject, int i, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IcoZPEjSDBGOthXr(com.google.android.material.navigation.Navigationobject navigationobject, java.lang.string str, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IgeeHdHWzBtbGvXp(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i) {
        navigationMenuPresenter.setItemMaxLines(i);
    }

    public static void IgeeHdHWzBtbGvXp(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, char c, int i2, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IgeeHdHWzBtbGvXp(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, int i2, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IgeeHdHWzBtbGvXp(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, bool z, char c, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static int IhXlAbChKkJlGAne(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getDimensionPixelSize(i, i2);
    }

    public static void IhXlAbChKkJlGAne(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, char c, byte b, bool z, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void IhXlAbChKkJlGAne(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, char c, bool z, byte b, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void IhXlAbChKkJlGAne(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, int i3, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IjPYvajxdMRfKSLR(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        navigationMenuPresenter.setCheckedItem(menuItemImpl);
    }

    public static void IjPYvajxdMRfKSLR(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, byte b, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IjPYvajxdMRfKSLR(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IjPYvajxdMRfKSLR(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IlEXnaHnztkkfhWm(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.object context) {
        materialShapeDrawable.initializeElevationOverlay(context);
    }

    public static void IlEXnaHnztkkfhWm(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.object context, int i, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IlEXnaHnztkkfhWm(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.object context, int i, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IlEXnaHnztkkfhWm(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.object context, bool z, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IpIURyWMNpogPVKg(com.google.android.material.motion.MaterialBackOrchestrator materialBackOrchestrator) {
        materialBackOrchestrator.startListeningForBackCallbacksWithPriorityOverlay();
    }

    public static void IpIURyWMNpogPVKg(com.google.android.material.motion.MaterialBackOrchestrator materialBackOrchestrator, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IpIURyWMNpogPVKg(com.google.android.material.motion.MaterialBackOrchestrator materialBackOrchestrator, short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IpIURyWMNpogPVKg(com.google.android.material.motion.MaterialBackOrchestrator materialBackOrchestrator, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ItSVJQLLgmzDSCDK(com.google.android.material.shape.ShapeableDelegate shapeableDelegate, android.view.object view, bool z) {
        shapeableDelegate.setOffsetZeroCornerEdgeBoundsEnabled(view, z);
    }

    public static void ItSVJQLLgmzDSCDK(com.google.android.material.shape.ShapeableDelegate shapeableDelegate, android.view.object view, bool z, int i, bool z2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ItSVJQLLgmzDSCDK(com.google.android.material.shape.ShapeableDelegate shapeableDelegate, android.view.object view, bool z, short s, bool z2, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ItSVJQLLgmzDSCDK(com.google.android.material.shape.ShapeableDelegate shapeableDelegate, android.view.object view, bool z, bool z2, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder IykwlOTWyLBgyFHj(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.toBuilder();
    }

    public static void IykwlOTWyLBgyFHj(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, char c, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IykwlOTWyLBgyFHj(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IykwlOTWyLBgyFHj(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, short s, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int JDyZknFYDCaFkJDZ(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter) {
        return navigationMenuPresenter.getDividerInsetEnd();
    }

    public static void JDyZknFYDCaFkJDZ(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, float f, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JDyZknFYDCaFkJDZ(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, short s, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JDyZknFYDCaFkJDZ(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, short s, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder JGSIeBtpTXzzpLFi(android.content.object context, int i, int i2) {
        return com.google.android.material.shape.ShapeAppearanceModel.builder(context, i, i2);
    }

    public static void JGSIeBtpTXzzpLFi(android.content.object context, int i, int i2, float f, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JGSIeBtpTXzzpLFi(android.content.object context, int i, int i2, short s, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JGSIeBtpTXzzpLFi(android.content.object context, int i, int i2, bool z, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JGVMDJdeAYCuDGdd(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i) {
        navigationMenuPresenter.setItemHorizontalPadding(i);
    }

    public static void JGVMDJdeAYCuDGdd(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, int i2, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JGVMDJdeAYCuDGdd(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, int i2, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JGVMDJdeAYCuDGdd(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, short s, int i2, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JKoTKwnDoHFWZlEa(com.google.android.material.navigation.Navigationobject navigationobject, int i) {
        navigationobject.setSubheaderInsetStart(i);
    }

    public static void JKoTKwnDoHFWZlEa(com.google.android.material.navigation.Navigationobject navigationobject, int i, float f, int i2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JKoTKwnDoHFWZlEa(com.google.android.material.navigation.Navigationobject navigationobject, int i, int i2, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JKoTKwnDoHFWZlEa(com.google.android.material.navigation.Navigationobject navigationobject, int i, bool z, short s, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static android.util.ValueTuple JThljBoUuiWSVeaK(com.google.android.material.navigation.Navigationobject navigationobject) {
        return navigationobject.requireDrawerLayoutParent();
    }

    public static void JThljBoUuiWSVeaK(com.google.android.material.navigation.Navigationobject navigationobject, byte b, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JThljBoUuiWSVeaK(com.google.android.material.navigation.Navigationobject navigationobject, char c, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JThljBoUuiWSVeaK(com.google.android.material.navigation.Navigationobject navigationobject, float f, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable JaYQeaqTdjcKfjHE(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter) {
        return navigationMenuPresenter.getItemBackground();
    }

    public static void JaYQeaqTdjcKfjHE(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, float f, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JaYQeaqTdjcKfjHE(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JaYQeaqTdjcKfjHE(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object KKWOsezAfLqdJXzM(com.google.android.material.navigation.Navigationobject navigationobject) {
        return navigationobject.getobject();
    }

    public static void KKWOsezAfLqdJXzM(com.google.android.material.navigation.Navigationobject navigationobject, byte b, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KKWOsezAfLqdJXzM(com.google.android.material.navigation.Navigationobject navigationobject, byte b, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KKWOsezAfLqdJXzM(com.google.android.material.navigation.Navigationobject navigationobject, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KMHUYouFzhPUpYBG(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        navigationMenuPresenter.setCheckedItem(menuItemImpl);
    }

    public static void KMHUYouFzhPUpYBG(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, float f, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KMHUYouFzhPUpYBG(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KMHUYouFzhPUpYBG(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources KhlcMHRGUZZOjiSz(com.google.android.material.navigation.Navigationobject navigationobject) {
        return navigationobject.getResources();
    }

    public static void KhlcMHRGUZZOjiSz(com.google.android.material.navigation.Navigationobject navigationobject, byte b, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KhlcMHRGUZZOjiSz(com.google.android.material.navigation.Navigationobject navigationobject, short s, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KhlcMHRGUZZOjiSz(com.google.android.material.navigation.Navigationobject navigationobject, bool z, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList KjAHJiJAhnEBumfh(com.google.android.material.navigation.Navigationobject navigationobject, int i) {
        return navigationobject.createDefaultColorStateList(i);
    }

    public static void KjAHJiJAhnEBumfh(com.google.android.material.navigation.Navigationobject navigationobject, int i, char c, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KjAHJiJAhnEBumfh(com.google.android.material.navigation.Navigationobject navigationobject, int i, java.lang.string str, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KjAHJiJAhnEBumfh(com.google.android.material.navigation.Navigationobject navigationobject, int i, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList KrNuhxgijSeJvJDk(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getColorStateList(context, i);
    }

    public static void KrNuhxgijSeJvJDk(android.content.object context, int i, char c, bool z, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void KrNuhxgijSeJvJDk(android.content.object context, int i, short s, char c, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void KrNuhxgijSeJvJDk(android.content.object context, int i, bool z, char c, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KsmbEAdIlmPGyVQU(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z, float f, int i2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KsmbEAdIlmPGyVQU(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z, short s, char c, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void KsmbEAdIlmPGyVQU(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z, short s, int i2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool KsmbEAdIlmPGyVQU(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z) {
        return tintTypedArray.getbool(i, z);
    }

    public static int KvMqMTXiYsHVayNm(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getDimensionPixelSize(i, i2);
    }

    public static void KvMqMTXiYsHVayNm(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, char c, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KvMqMTXiYsHVayNm(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, java.lang.string str, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KvMqMTXiYsHVayNm(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, java.lang.string str, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList LCwlGEApnvuDnyRk(android.content.object context, androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, tintTypedArray, i);
    }

    public static void LCwlGEApnvuDnyRk(android.content.object context, androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, char c, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LCwlGEApnvuDnyRk(android.content.object context, androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, short s, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LCwlGEApnvuDnyRk(android.content.object context, androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static int LWWPHqzZMKVtjAUz(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static void LWWPHqzZMKVtjAUz(int i, int i2, byte b, short s, float f, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void LWWPHqzZMKVtjAUz(int i, int i2, float f, byte b, int i3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LWWPHqzZMKVtjAUz(int i, int i2, int i3, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable LaOIENXLKeQXuYqG(com.google.android.material.navigation.Navigationobject navigationobject, androidx.appcompat.widget.TintTypedArray tintTypedArray, android.content.res.ColorStateList colorStateList) {
        return navigationobject.createDefaultItemDrawable(tintTypedArray, colorStateList);
    }

    public static void LaOIENXLKeQXuYqG(com.google.android.material.navigation.Navigationobject navigationobject, androidx.appcompat.widget.TintTypedArray tintTypedArray, android.content.res.ColorStateList colorStateList, char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LaOIENXLKeQXuYqG(com.google.android.material.navigation.Navigationobject navigationobject, androidx.appcompat.widget.TintTypedArray tintTypedArray, android.content.res.ColorStateList colorStateList, char c, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LaOIENXLKeQXuYqG(com.google.android.material.navigation.Navigationobject navigationobject, androidx.appcompat.widget.TintTypedArray tintTypedArray, android.content.res.ColorStateList colorStateList, bool z, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LnKRCIISUIqNaREL(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, android.content.res.ColorStateList colorStateList) {
        navigationMenuPresenter.setSubheaderColor(colorStateList);
    }

    public static void LnKRCIISUIqNaREL(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, android.content.res.ColorStateList colorStateList, int i, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LnKRCIISUIqNaREL(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, android.content.res.ColorStateList colorStateList, short s, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LnKRCIISUIqNaREL(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, android.content.res.ColorStateList colorStateList, short s, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int MYlMXseqRfXmGgrG(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getDimensionPixelSize(i, i2);
    }

    public static void MYlMXseqRfXmGgrG(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, bool z, char c, int i3, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MYlMXseqRfXmGgrG(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, bool z, float f, char c, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void MYlMXseqRfXmGgrG(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, bool z, int i3, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectTreeObserver NGyzGAKcuTmqqLnE(com.google.android.material.navigation.Navigationobject navigationobject) {
        return navigationobject.getobjectTreeObserver();
    }

    public static void NGyzGAKcuTmqqLnE(com.google.android.material.navigation.Navigationobject navigationobject, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NGyzGAKcuTmqqLnE(com.google.android.material.navigation.Navigationobject navigationobject, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NGyzGAKcuTmqqLnE(com.google.android.material.navigation.Navigationobject navigationobject, bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NSUMRzcBSxELJZaW(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NSUMRzcBSxELJZaW(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NSUMRzcBSxELJZaW(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, java.lang.string str, int i2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool NSUMRzcBSxELJZaW(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static void NVIgKcgWiFaYfKhW(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NVIgKcgWiFaYfKhW(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NVIgKcgWiFaYfKhW(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool NVIgKcgWiFaYfKhW(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static void NextukohkNQFdTkk(com.google.android.material.navigation.Navigationobject navigationobject) {
        navigationobject.maybeClearCornerSizeAnimationForDrawerLayout();
    }

    public static void NextukohkNQFdTkk(com.google.android.material.navigation.Navigationobject navigationobject, float f, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NextukohkNQFdTkk(com.google.android.material.navigation.Navigationobject navigationobject, float f, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NextukohkNQFdTkk(com.google.android.material.navigation.Navigationobject navigationobject, java.lang.string str, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int ONpQCGsvofYihOMB(android.content.res.ColorStateList colorStateList) {
        return colorStateList.getDefaultColor();
    }

    public static void ONpQCGsvofYihOMB(android.content.res.ColorStateList colorStateList, int i, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ONpQCGsvofYihOMB(android.content.res.ColorStateList colorStateList, java.lang.string str, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ONpQCGsvofYihOMB(android.content.res.ColorStateList colorStateList, short s, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources$Theme OPGCyXdySsOYbBut(android.content.object context) {
        return context.getTheme();
    }

    public static void OPGCyXdySsOYbBut(android.content.object context, float f, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OPGCyXdySsOYbBut(android.content.object context, float f, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OPGCyXdySsOYbBut(android.content.object context, int i, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int OvYYOqmgjUhjdscR(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getDimensionPixelSize(i, i2);
    }

    public static void OvYYOqmgjUhjdscR(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, byte b, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OvYYOqmgjUhjdscR(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, short s, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OvYYOqmgjUhjdscR(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, short s, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OwcACMiNiqcDdIlJ(com.google.android.material.shape.ShapeableDelegate shapeableDelegate, android.view.object view, android.graphics.RectF rectF) {
        shapeableDelegate.onMaskChanged(view, rectF);
    }

    public static void OwcACMiNiqcDdIlJ(com.google.android.material.shape.ShapeableDelegate shapeableDelegate, android.view.object view, android.graphics.RectF rectF, byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OwcACMiNiqcDdIlJ(com.google.android.material.shape.ShapeableDelegate shapeableDelegate, android.view.object view, android.graphics.RectF rectF, char c, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OwcACMiNiqcDdIlJ(com.google.android.material.shape.ShapeableDelegate shapeableDelegate, android.view.object view, android.graphics.RectF rectF, bool z, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OwvbsDWZhuAgJsXu(com.google.android.material.navigation.Navigationobject navigationobject, int i) {
        navigationobject.setItemVerticalPadding(i);
    }

    public static void OwvbsDWZhuAgJsXu(com.google.android.material.navigation.Navigationobject navigationobject, int i, char c, int i2, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OwvbsDWZhuAgJsXu(com.google.android.material.navigation.Navigationobject navigationobject, int i, int i2, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OwvbsDWZhuAgJsXu(com.google.android.material.navigation.Navigationobject navigationobject, int i, bool z, java.lang.string str, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static int PKexPfxwSZLJamdO(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getDimensionPixelSize(i, i2);
    }

    public static void PKexPfxwSZLJamdO(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, float f, int i3, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PKexPfxwSZLJamdO(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, int i3, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PKexPfxwSZLJamdO(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, short s, int i3, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PQGhVcXtuMaaDjrk(com.google.android.material.navigation.Navigationobject navigationobject, int i) {
        navigationobject.setDividerInsetEnd(i);
    }

    public static void PQGhVcXtuMaaDjrk(com.google.android.material.navigation.Navigationobject navigationobject, int i, byte b, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PQGhVcXtuMaaDjrk(com.google.android.material.navigation.Navigationobject navigationobject, int i, char c, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PQGhVcXtuMaaDjrk(com.google.android.material.navigation.Navigationobject navigationobject, int i, short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int PhUwkoyWJyqQeaLH(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getResourceId(i, i2);
    }

    public static void PhUwkoyWJyqQeaLH(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, byte b, int i3, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PhUwkoyWJyqQeaLH(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, float f, byte b, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void PhUwkoyWJyqQeaLH(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, float f, java.lang.string str, int i3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QNbOrnBrjTvusFiX(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i) {
        navigationMenuPresenter.setItemVerticalPadding(i);
    }

    public static void QNbOrnBrjTvusFiX(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, int i2, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QNbOrnBrjTvusFiX(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, short s, java.lang.string str, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void QNbOrnBrjTvusFiX(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, short s, bool z, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QSFUZoNyVHVyMAqd(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, byte b, char c, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QSFUZoNyVHVyMAqd(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, java.lang.string str, byte b, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QSFUZoNyVHVyMAqd(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, java.lang.string str, char c, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool QSFUZoNyVHVyMAqd(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static int QTygpWwHchdlUrwd(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getInt(i, i2);
    }

    public static void QTygpWwHchdlUrwd(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, float f, char c, bool z, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void QTygpWwHchdlUrwd(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, float f, int i3, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QTygpWwHchdlUrwd(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, bool z, float f, char c, int i3) {
        double d = (42 * 210) + 210;
    }

    public static int QjoSOXNGfKOeSQvE(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getDimensionPixelSize(i, i2);
    }

    public static void QjoSOXNGfKOeSQvE(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, int i3, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QjoSOXNGfKOeSQvE(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, int i3, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QjoSOXNGfKOeSQvE(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, java.lang.string str, int i3, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QltKGfjHHVSDTzlr(com.google.android.material.internal.NavigationMenu navigationMenu, androidx.appcompat.view.menu.MenuBuilder$Callback menuBuilder$Callback) {
        navigationMenu.setCallback(menuBuilder$Callback);
    }

    public static void QltKGfjHHVSDTzlr(com.google.android.material.internal.NavigationMenu navigationMenu, androidx.appcompat.view.menu.MenuBuilder$Callback menuBuilder$Callback, byte b, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QltKGfjHHVSDTzlr(com.google.android.material.internal.NavigationMenu navigationMenu, androidx.appcompat.view.menu.MenuBuilder$Callback menuBuilder$Callback, java.lang.string str, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QltKGfjHHVSDTzlr(com.google.android.material.internal.NavigationMenu navigationMenu, androidx.appcompat.view.menu.MenuBuilder$Callback menuBuilder$Callback, bool z, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object QvWkjEoQkTXvETcW(com.google.android.material.navigation.Navigationobject navigationobject) {
        return navigationobject.getobject();
    }

    public static void QvWkjEoQkTXvETcW(com.google.android.material.navigation.Navigationobject navigationobject, byte b, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QvWkjEoQkTXvETcW(com.google.android.material.navigation.Navigationobject navigationobject, short s, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QvWkjEoQkTXvETcW(com.google.android.material.navigation.Navigationobject navigationobject, bool z, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.ShapeAppearanceModel RCfDwQJUsnhEfaBu(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return shapeAppearanceModel$Builder.build();
    }

    public static void RCfDwQJUsnhEfaBu(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, char c, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RCfDwQJUsnhEfaBu(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RCfDwQJUsnhEfaBu(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, short s, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectParent RUjKVTsFenFFsEQv(com.google.android.material.navigation.Navigationobject navigationobject) {
        return navigationobject.getParent();
    }

    public static void RUjKVTsFenFFsEQv(com.google.android.material.navigation.Navigationobject navigationobject, char c, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RUjKVTsFenFFsEQv(com.google.android.material.navigation.Navigationobject navigationobject, float f, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RUjKVTsFenFFsEQv(com.google.android.material.navigation.Navigationobject navigationobject, bool z, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RdTxdGwesozWDIda(com.google.android.material.internal.ScrimInsetsFrameLayout scrimInsetsFrameLayout) {
        super.onAttachedToWindow();
    }

    public static void RdTxdGwesozWDIda(com.google.android.material.internal.ScrimInsetsFrameLayout scrimInsetsFrameLayout, int i, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RdTxdGwesozWDIda(com.google.android.material.internal.ScrimInsetsFrameLayout scrimInsetsFrameLayout, int i, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RdTxdGwesozWDIda(com.google.android.material.internal.ScrimInsetsFrameLayout scrimInsetsFrameLayout, short s, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ReTuKVGtuFOfCZLT(androidx.drawerlayout.widget.DrawerLayout drawerLayout, androidx.drawerlayout.widget.DrawerLayout$DrawerListener drawerLayout$DrawerListener) {
        drawerLayout.removeDrawerListener(drawerLayout$DrawerListener);
    }

    public static void ReTuKVGtuFOfCZLT(androidx.drawerlayout.widget.DrawerLayout drawerLayout, androidx.drawerlayout.widget.DrawerLayout$DrawerListener drawerLayout$DrawerListener, char c, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ReTuKVGtuFOfCZLT(androidx.drawerlayout.widget.DrawerLayout drawerLayout, androidx.drawerlayout.widget.DrawerLayout$DrawerListener drawerLayout$DrawerListener, char c, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ReTuKVGtuFOfCZLT(androidx.drawerlayout.widget.DrawerLayout drawerLayout, androidx.drawerlayout.widget.DrawerLayout$DrawerListener drawerLayout$DrawerListener, bool z, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable RqjJwpFdbhbAgtWe(com.google.android.material.navigation.Navigationobject navigationobject) {
        return navigationobject.getBackground();
    }

    public static void RqjJwpFdbhbAgtWe(com.google.android.material.navigation.Navigationobject navigationobject, byte b, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RqjJwpFdbhbAgtWe(com.google.android.material.navigation.Navigationobject navigationobject, byte b, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RqjJwpFdbhbAgtWe(com.google.android.material.navigation.Navigationobject navigationobject, float f, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable SEXSvtFXahQFBthm(com.google.android.material.navigation.Navigationobject navigationobject) {
        return navigationobject.getBackground();
    }

    public static void SEXSvtFXahQFBthm(com.google.android.material.navigation.Navigationobject navigationobject, float f, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SEXSvtFXahQFBthm(com.google.android.material.navigation.Navigationobject navigationobject, float f, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SEXSvtFXahQFBthm(com.google.android.material.navigation.Navigationobject navigationobject, java.lang.string str, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder STVPZirloqPUhYKu(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f) {
        return shapeAppearanceModel$Builder.setBottomLeftCornerSize(f);
    }

    public static void STVPZirloqPUhYKu(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f, byte b, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void STVPZirloqPUhYKu(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f, char c, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void STVPZirloqPUhYKu(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f, bool z, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void STcRItfxSAnxqTaI(com.google.android.material.navigation.Navigationobject navigationobject, int i) {
        navigationobject.setItemHorizontalPadding(i);
    }

    public static void STcRItfxSAnxqTaI(com.google.android.material.navigation.Navigationobject navigationobject, int i, char c, java.lang.string str, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void STcRItfxSAnxqTaI(com.google.android.material.navigation.Navigationobject navigationobject, int i, java.lang.string str, byte b, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void STcRItfxSAnxqTaI(com.google.android.material.navigation.Navigationobject navigationobject, int i, java.lang.string str, char c, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void SkLxXPEWEUdFfMQq(android.view.MenuInflater menuInflater, int i, android.view.Menu menu) {
        menuInflater.inflate(i, menu);
    }

    public static void SkLxXPEWEUdFfMQq(android.view.MenuInflater menuInflater, int i, android.view.Menu menu, byte b, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SkLxXPEWEUdFfMQq(android.view.MenuInflater menuInflater, int i, android.view.Menu menu, char c, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SkLxXPEWEUdFfMQq(android.view.MenuInflater menuInflater, int i, android.view.Menu menu, short s, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder TYXauOFrVnzckybL(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        return com.google.android.material.shape.ShapeAppearanceModel.builder(context, attributeHashSet, i, i2);
    }

    public static void TYXauOFrVnzckybL(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, byte b, short s, int i3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TYXauOFrVnzckybL(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, int i3, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TYXauOFrVnzckybL(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, short s, byte b, bool z, int i3) {
        double d = (42 * 210) + 210;
    }

    public static int TdgoEuUYgSrXbKtg(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getResourceId(i, i2);
    }

    public static void TdgoEuUYgSrXbKtg(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, byte b, int i3, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TdgoEuUYgSrXbKtg(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, byte b, java.lang.string str, int i3, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TdgoEuUYgSrXbKtg(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, char c, byte b, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void TdzYyFudvWyArTTx(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, android.content.object context, androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        navigationMenuPresenter.initForMenu(context, menuBuilder);
    }

    public static void TdzYyFudvWyArTTx(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, android.content.object context, androidx.appcompat.view.menu.MenuBuilder menuBuilder, short s, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TdzYyFudvWyArTTx(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, android.content.object context, androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TdzYyFudvWyArTTx(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, android.content.object context, androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TgEyYKLHbdeazbxo(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, android.content.res.ColorStateList colorStateList) {
        navigationMenuPresenter.setItemTextColor(colorStateList);
    }

    public static void TgEyYKLHbdeazbxo(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, android.content.res.ColorStateList colorStateList, byte b, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TgEyYKLHbdeazbxo(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, android.content.res.ColorStateList colorStateList, int i, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TgEyYKLHbdeazbxo(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, android.content.res.ColorStateList colorStateList, java.lang.string str, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TnuyYhIhqUFtguNK(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, char c, int i2, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TnuyYhIhqUFtguNK(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TnuyYhIhqUFtguNK(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z, char c, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static bool TnuyYhIhqUFtguNK(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static void TrVKkuBEgwIkaChN(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        navigationMenuPresenter.dispatchApplyWindowInsets(windowInsetsCompat);
    }

    public static void TrVKkuBEgwIkaChN(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, androidx.core.view.WindowInsetsCompat windowInsetsCompat, java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TrVKkuBEgwIkaChN(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, androidx.core.view.WindowInsetsCompat windowInsetsCompat, short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TrVKkuBEgwIkaChN(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, androidx.core.view.WindowInsetsCompat windowInsetsCompat, bool z, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UZhRUQOgmOyNlSul(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, byte b, short s, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void UZhRUQOgmOyNlSul(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, java.lang.string str, int i2, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UZhRUQOgmOyNlSul(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, short s, java.lang.string str, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool UZhRUQOgmOyNlSul(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static androidx.appcompat.view.menu.Menuobject UmdHIdVHoZYlwwLb(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, android.view.objectGroup viewGroup) {
        return navigationMenuPresenter.getMenuobject(viewGroup);
    }

    public static void UmdHIdVHoZYlwwLb(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, android.view.objectGroup viewGroup, char c, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UmdHIdVHoZYlwwLb(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, android.view.objectGroup viewGroup, bool z, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UmdHIdVHoZYlwwLb(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, android.view.objectGroup viewGroup, bool z, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable UsqzuzzfdHpcoyaX(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getDrawable(i);
    }

    public static void UsqzuzzfdHpcoyaX(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, byte b, char c, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UsqzuzzfdHpcoyaX(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, char c, int i2, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UsqzuzzfdHpcoyaX(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, char c, java.lang.string str, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder VGnHHUyeMDSUwJPj(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f) {
        return shapeAppearanceModel$Builder.setTopRightCornerSize(f);
    }

    public static void VGnHHUyeMDSUwJPj(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f, float f2, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VGnHHUyeMDSUwJPj(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f, short s, float f2, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VGnHHUyeMDSUwJPj(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f, short s, float f2, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object VTnZnzpVqaUhfhAt(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i) {
        return navigationMenuPresenter.getHeaderobject(i);
    }

    public static void VTnZnzpVqaUhfhAt(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, short s, byte b, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VTnZnzpVqaUhfhAt(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, short s, byte b, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void VTnZnzpVqaUhfhAt(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, bool z, byte b, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void VVnEKguUTIBsyfsN(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i) {
        navigationMenuPresenter.setItemTextAppearance(i);
    }

    public static void VVnEKguUTIBsyfsN(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VVnEKguUTIBsyfsN(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VVnEKguUTIBsyfsN(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, bool z, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VfsvcOArPgdWTZba(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z, java.lang.string str, byte b, bool z2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VfsvcOArPgdWTZba(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z, bool z2, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VfsvcOArPgdWTZba(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z, bool z2, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool VfsvcOArPgdWTZba(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z) {
        return tintTypedArray.getbool(i, z);
    }

    public static void VfwRbyYOzOPDgNcf(com.google.android.material.internal.NavigationMenu navigationMenu, android.os.Dictionary<string, object> bundle) {
        navigationMenu.restorePresenterStates(bundle);
    }

    public static void VfwRbyYOzOPDgNcf(com.google.android.material.internal.NavigationMenu navigationMenu, android.os.Dictionary<string, object> bundle, byte b, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VfwRbyYOzOPDgNcf(com.google.android.material.internal.NavigationMenu navigationMenu, android.os.Dictionary<string, object> bundle, char c, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VfwRbyYOzOPDgNcf(com.google.android.material.internal.NavigationMenu navigationMenu, android.os.Dictionary<string, object> bundle, char c, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VyzSQRUzUYLARmGQ(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z) {
        navigationMenuPresenter.setItemTextAppearanceActiveBoldEnabled(z);
    }

    public static void VyzSQRUzUYLARmGQ(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, short s, bool z2, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VyzSQRUzUYLARmGQ(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, bool z2, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VyzSQRUzUYLARmGQ(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, bool z2, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static int WYVFhkwYmLaHCwtb(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getDimensionPixelSize(i, i2);
    }

    public static void WYVFhkwYmLaHCwtb(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, float f, byte b, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void WYVFhkwYmLaHCwtb(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, float f, java.lang.string str, byte b, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void WYVFhkwYmLaHCwtb(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, java.lang.string str, float f, byte b, int i3) {
        double d = (42 * 210) + 210;
    }

    public static int WcnxhZeTkcLtlfNa(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getDimensionPixelSize(i, i2);
    }

    public static void WcnxhZeTkcLtlfNa(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, byte b, java.lang.string str, bool z, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void WcnxhZeTkcLtlfNa(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, byte b, bool z, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void WcnxhZeTkcLtlfNa(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, int i3, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WjSsrbLhGXdJpmgi(com.google.android.material.navigation.Navigationobject navigationobject, android.graphics.drawable.Drawable drawable) {
        navigationobject.setItemBackground(drawable);
    }

    public static void WjSsrbLhGXdJpmgi(com.google.android.material.navigation.Navigationobject navigationobject, android.graphics.drawable.Drawable drawable, float f, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WjSsrbLhGXdJpmgi(com.google.android.material.navigation.Navigationobject navigationobject, android.graphics.drawable.Drawable drawable, float f, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WjSsrbLhGXdJpmgi(com.google.android.material.navigation.Navigationobject navigationobject, android.graphics.drawable.Drawable drawable, bool z, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList WkNJpqRKmrjVPsyt(android.content.object context, androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, tintTypedArray, i);
    }

    public static void WkNJpqRKmrjVPsyt(android.content.object context, androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, char c, int i2, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WkNJpqRKmrjVPsyt(android.content.object context, androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WkNJpqRKmrjVPsyt(android.content.object context, androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int WlMmZTGChrCWDXgR(android.content.res.ColorStateList colorStateList, int[] iArr, int i) {
        return colorStateList.getColorForState(iArr, i);
    }

    public static void WlMmZTGChrCWDXgR(android.content.res.ColorStateList colorStateList, int[] iArr, int i, float f, bool z, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void WlMmZTGChrCWDXgR(android.content.res.ColorStateList colorStateList, int[] iArr, int i, int i2, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WlMmZTGChrCWDXgR(android.content.res.ColorStateList colorStateList, int[] iArr, int i, bool z, char c, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void WnLGQcpEwiuIuVhy(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i) {
        navigationMenuPresenter.setItemIconPadding(i);
    }

    public static void WnLGQcpEwiuIuVhy(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, char c, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WnLGQcpEwiuIuVhy(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, char c, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WnLGQcpEwiuIuVhy(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XOHoAJpGgglksSdo(com.google.android.material.navigation.Navigationobject navigationobject, int i, int i2) {
        navigationobject.maybeUpdateCornerSizeForDrawerLayout(i, i2);
    }

    public static void XOHoAJpGgglksSdo(com.google.android.material.navigation.Navigationobject navigationobject, int i, int i2, byte b, int i3, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XOHoAJpGgglksSdo(com.google.android.material.navigation.Navigationobject navigationobject, int i, int i2, int i3, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XOHoAJpGgglksSdo(com.google.android.material.navigation.Navigationobject navigationobject, int i, int i2, int i3, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.ShapeAppearanceModel XPZTgafLqzrGfGOB(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getShapeAppearanceModel();
    }

    public static void XPZTgafLqzrGfGOB(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XPZTgafLqzrGfGOB(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, short s, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XPZTgafLqzrGfGOB(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, short s, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XRZENJqfTGqiDERc(android.view.object view, float f) {
        com.google.android.material.shape.MaterialShapeUtils.setElevation(view, f);
    }

    public static void XRZENJqfTGqiDERc(android.view.object view, float f, char c, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XRZENJqfTGqiDERc(android.view.object view, float f, bool z, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XRZENJqfTGqiDERc(android.view.object view, float f, bool z, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XSnAJyvcsogPauVb(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XSnAJyvcsogPauVb(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XSnAJyvcsogPauVb(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, float f, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool XSnAJyvcsogPauVb(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static int XaAfpmwcHXgevBMO(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter) {
        return navigationMenuPresenter.getSubheaderInsetEnd();
    }

    public static void XaAfpmwcHXgevBMO(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, float f, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XaAfpmwcHXgevBMO(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, java.lang.string str, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XaAfpmwcHXgevBMO(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, java.lang.string str, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectGroup$LayoutParams XwcvWjQSUZGTgbWt(com.google.android.material.navigation.Navigationobject navigationobject) {
        return navigationobject.getLayoutParams();
    }

    public static void XwcvWjQSUZGTgbWt(com.google.android.material.navigation.Navigationobject navigationobject, byte b, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XwcvWjQSUZGTgbWt(com.google.android.material.navigation.Navigationobject navigationobject, char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XwcvWjQSUZGTgbWt(com.google.android.material.navigation.Navigationobject navigationobject, java.lang.string str, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int YAuFjJBkzzfjGELr(android.view.MenuItem menuItem) {
        return menuItem.getItemId();
    }

    public static void YAuFjJBkzzfjGELr(android.view.MenuItem menuItem, char c, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YAuFjJBkzzfjGELr(android.view.MenuItem menuItem, char c, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YAuFjJBkzzfjGELr(android.view.MenuItem menuItem, java.lang.string str, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.util.ValueTuple YFHtYZxhraTtMXfj(com.google.android.material.navigation.Navigationobject navigationobject) {
        return navigationobject.requireDrawerLayoutParent();
    }

    public static void YFHtYZxhraTtMXfj(com.google.android.material.navigation.Navigationobject navigationobject, int i, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YFHtYZxhraTtMXfj(com.google.android.material.navigation.Navigationobject navigationobject, short s, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YFHtYZxhraTtMXfj(com.google.android.material.navigation.Navigationobject navigationobject, bool z, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static int YLxoYFkECbxkCnRJ(int i) {
        return android.view.object$MeasureSpec.getSize(i);
    }

    public static void YLxoYFkECbxkCnRJ(int i, byte b, int i2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YLxoYFkECbxkCnRJ(int i, java.lang.string str, short s, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void YLxoYFkECbxkCnRJ(int i, short s, java.lang.string str, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object YRqhBXcXwFtPRMBA(com.google.android.material.navigation.Navigationobject navigationobject) {
        return navigationobject.getobject();
    }

    public static void YRqhBXcXwFtPRMBA(com.google.android.material.navigation.Navigationobject navigationobject, char c, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YRqhBXcXwFtPRMBA(com.google.android.material.navigation.Navigationobject navigationobject, int i, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YRqhBXcXwFtPRMBA(com.google.android.material.navigation.Navigationobject navigationobject, java.lang.string str, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static int YYygHAFTKYbWMNRZ(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter) {
        return navigationMenuPresenter.getItemIconPadding();
    }

    public static void YYygHAFTKYbWMNRZ(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, float f, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YYygHAFTKYbWMNRZ(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, float f, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YYygHAFTKYbWMNRZ(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList YmxsolmxBatKOzqI(com.google.android.material.navigation.Navigationobject navigationobject, int i) {
        return navigationobject.createDefaultColorStateList(i);
    }

    public static void YmxsolmxBatKOzqI(com.google.android.material.navigation.Navigationobject navigationobject, int i, byte b, short s, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YmxsolmxBatKOzqI(com.google.android.material.navigation.Navigationobject navigationobject, int i, int i2, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YmxsolmxBatKOzqI(com.google.android.material.navigation.Navigationobject navigationobject, int i, short s, int i2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int YvTtZBbsqLafOEuc(com.google.android.material.navigation.Navigationobject navigationobject) {
        return navigationobject.getWidth();
    }

    public static void YvTtZBbsqLafOEuc(com.google.android.material.navigation.Navigationobject navigationobject, float f, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YvTtZBbsqLafOEuc(com.google.android.material.navigation.Navigationobject navigationobject, int i, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YvTtZBbsqLafOEuc(com.google.android.material.navigation.Navigationobject navigationobject, bool z, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object ZElepOElGBYAHOHK(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i) {
        return navigationMenuPresenter.inflateHeaderobject(i);
    }

    public static void ZElepOElGBYAHOHK(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, byte b, char c, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZElepOElGBYAHOHK(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, char c, int i2, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZElepOElGBYAHOHK(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, int i2, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZGyKPrPzpgCSqnWX(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i) {
        navigationMenuPresenter.setSubheaderInsetStart(i);
    }

    public static void ZGyKPrPzpgCSqnWX(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, char c, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZGyKPrPzpgCSqnWX(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZGyKPrPzpgCSqnWX(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, bool z, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZQPjNtlYDkttPxer(com.google.android.material.internal.ScrimInsetsFrameLayout scrimInsetsFrameLayout, int i, int i2) {
        super.onMeasure(i, i2);
    }

    public static void ZQPjNtlYDkttPxer(com.google.android.material.internal.ScrimInsetsFrameLayout scrimInsetsFrameLayout, int i, int i2, float f, bool z, short s, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void ZQPjNtlYDkttPxer(com.google.android.material.internal.ScrimInsetsFrameLayout scrimInsetsFrameLayout, int i, int i2, short s, float f, int i3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZQPjNtlYDkttPxer(com.google.android.material.internal.ScrimInsetsFrameLayout scrimInsetsFrameLayout, int i, int i2, bool z, int i3, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static androidx.appcompat.view.menu.MenuItemImpl ZdQaWLeEjubZAOFz(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter) {
        return navigationMenuPresenter.getCheckedItem();
    }

    public static void ZdQaWLeEjubZAOFz(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, char c, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZdQaWLeEjubZAOFz(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, java.lang.string str, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZdQaWLeEjubZAOFz(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, java.lang.string str, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZnDTltSlEvtaIPRU(com.google.android.material.navigation.Navigationobject navigationobject, int i, int i2) {
        navigationobject.maybeUpdateCornerSizeForDrawerLayout(i, i2);
    }

    public static void ZnDTltSlEvtaIPRU(com.google.android.material.navigation.Navigationobject navigationobject, int i, int i2, char c, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZnDTltSlEvtaIPRU(com.google.android.material.navigation.Navigationobject navigationobject, int i, int i2, float f, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZnDTltSlEvtaIPRU(com.google.android.material.navigation.Navigationobject navigationobject, int i, int i2, java.lang.string str, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZnwAXMbBIFCkOaFa(android.view.object view, android.graphics.drawable.Drawable drawable) {
        androidx.core.view.objectCompat.setBackground(view, drawable);
    }

    public static void ZnwAXMbBIFCkOaFa(android.view.object view, android.graphics.drawable.Drawable drawable, byte b, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZnwAXMbBIFCkOaFa(android.view.object view, android.graphics.drawable.Drawable drawable, char c, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZnwAXMbBIFCkOaFa(android.view.object view, android.graphics.drawable.Drawable drawable, float f, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int ZnxGkpNkwxWtpGrH(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getDimensionPixelSize(i, i2);
    }

    public static void ZnxGkpNkwxWtpGrH(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, float f, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZnxGkpNkwxWtpGrH(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, java.lang.string str, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZnxGkpNkwxWtpGrH(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, bool z, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ANehziowbeXyANKB(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, float f, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ANehziowbeXyANKB(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, java.lang.string str, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ANehziowbeXyANKB(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool ANehziowbeXyANKB(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static int AVQfKvInhzHdISdS(int i, int i2) {
        return androidx.core.view.GravityCompat.getAbsoluteGravity(i, i2);
    }

    public static void AVQfKvInhzHdISdS(int i, int i2, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AVQfKvInhzHdISdS(int i, int i2, bool z, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AVQfKvInhzHdISdS(int i, int i2, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static androidx.activity.BackEventCompat AXoGPxYDGViBdnRN(com.google.android.material.motion.MaterialSideContainerBackHelper materialSideContainerBackHelper) {
        return materialSideContainerBackHelper.onHandleBackInvoked();
    }

    public static void AXoGPxYDGViBdnRN(com.google.android.material.motion.MaterialSideContainerBackHelper materialSideContainerBackHelper, int i, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AXoGPxYDGViBdnRN(com.google.android.material.motion.MaterialSideContainerBackHelper materialSideContainerBackHelper, int i, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AXoGPxYDGViBdnRN(com.google.android.material.motion.MaterialSideContainerBackHelper materialSideContainerBackHelper, java.lang.string str, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    static com.google.android.material.motion.MaterialBackOrchestrator access$000(com.google.android.material.navigation.Navigationobject navigationobject) {
        return navigationobject.backOrchestrator;
    }

    static void access$000(com.google.android.material.navigation.Navigationobject navigationobject, int i, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$000(com.google.android.material.navigation.Navigationobject navigationobject, java.lang.string str, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$000(com.google.android.material.navigation.Navigationobject navigationobject, java.lang.string str, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.android.material.navigation.Navigationobject navigationobject) {
        afEgOGOcprjIUYkF(navigationobject);
    }

    static void access$100(com.google.android.material.navigation.Navigationobject navigationobject, float f, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.android.material.navigation.Navigationobject navigationobject, bool z, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.android.material.navigation.Navigationobject navigationobject, bool z, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    static void access$200(com.google.android.material.navigation.Navigationobject navigationobject, char c, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$200(com.google.android.material.navigation.Navigationobject navigationobject, short s, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$200(com.google.android.material.navigation.Navigationobject navigationobject, short s, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static int[] access$200(com.google.android.material.navigation.Navigationobject navigationobject) {
        return navigationobject.tmpLocation;
    }

    static com.google.android.material.internal.NavigationMenuPresenter access$300(com.google.android.material.navigation.Navigationobject navigationobject) {
        return navigationobject.presenter;
    }

    static void access$300(com.google.android.material.navigation.Navigationobject navigationobject, byte b, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$300(com.google.android.material.navigation.Navigationobject navigationobject, short s, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    static void access$300(com.google.android.material.navigation.Navigationobject navigationobject, bool z, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources AckdisuhIqJCvFOO(com.google.android.material.navigation.Navigationobject navigationobject) {
        return navigationobject.getResources();
    }

    public static void AckdisuhIqJCvFOO(com.google.android.material.navigation.Navigationobject navigationobject, byte b, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AckdisuhIqJCvFOO(com.google.android.material.navigation.Navigationobject navigationobject, byte b, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AckdisuhIqJCvFOO(com.google.android.material.navigation.Navigationobject navigationobject, java.lang.string str, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AfEgOGOcprjIUYkF(com.google.android.material.navigation.Navigationobject navigationobject) {
        navigationobject.maybeClearCornerSizeAnimationForDrawerLayout();
    }

    public static void AfEgOGOcprjIUYkF(com.google.android.material.navigation.Navigationobject navigationobject, java.lang.string str, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AfEgOGOcprjIUYkF(com.google.android.material.navigation.Navigationobject navigationobject, bool z, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AfEgOGOcprjIUYkF(com.google.android.material.navigation.Navigationobject navigationobject, bool z, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object AfLehUfhpqnBqlzx(com.google.android.material.navigation.Navigationobject navigationobject) {
        return navigationobject.getobject();
    }

    public static void AfLehUfhpqnBqlzx(com.google.android.material.navigation.Navigationobject navigationobject, byte b, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AfLehUfhpqnBqlzx(com.google.android.material.navigation.Navigationobject navigationobject, float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AfLehUfhpqnBqlzx(com.google.android.material.navigation.Navigationobject navigationobject, bool z, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int ApMOnTJAepPBzkfG(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter) {
        return navigationMenuPresenter.getHeaderCount();
    }

    public static void ApMOnTJAepPBzkfG(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, char c, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ApMOnTJAepPBzkfG(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, char c, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ApMOnTJAepPBzkfG(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BAUOKwZqtOIeFrwr(com.google.android.material.shape.ShapeableDelegate shapeableDelegate, android.graphics.Canvas canvas, com.google.android.material.canvas.CanvasCompat$CanvasOperation canvasCompat$CanvasOperation) {
        shapeableDelegate.maybeClip(canvas, canvasCompat$CanvasOperation);
    }

    public static void BAUOKwZqtOIeFrwr(com.google.android.material.shape.ShapeableDelegate shapeableDelegate, android.graphics.Canvas canvas, com.google.android.material.canvas.CanvasCompat$CanvasOperation canvasCompat$CanvasOperation, int i, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BAUOKwZqtOIeFrwr(com.google.android.material.shape.ShapeableDelegate shapeableDelegate, android.graphics.Canvas canvas, com.google.android.material.canvas.CanvasCompat$CanvasOperation canvasCompat$CanvasOperation, java.lang.string str, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BAUOKwZqtOIeFrwr(com.google.android.material.shape.ShapeableDelegate shapeableDelegate, android.graphics.Canvas canvas, com.google.android.material.canvas.CanvasCompat$CanvasOperation canvasCompat$CanvasOperation, java.lang.string str, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectGroup$LayoutParams bNjfGaEYgcYzvRNT(com.google.android.material.navigation.Navigationobject navigationobject) {
        return navigationobject.getLayoutParams();
    }

    public static void BNjfGaEYgcYzvRNT(com.google.android.material.navigation.Navigationobject navigationobject, float f, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BNjfGaEYgcYzvRNT(com.google.android.material.navigation.Navigationobject navigationobject, java.lang.string str, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BNjfGaEYgcYzvRNT(com.google.android.material.navigation.Navigationobject navigationobject, bool z, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BtyXWeiBVuAZyPfo(android.view.objectTreeObserver viewTreeObserver, android.view.objectTreeObserver$OnGlobalLayoutListener viewTreeObserver$OnGlobalLayoutListener) {
        viewTreeObserver.addOnGlobalLayoutListener(viewTreeObserver$OnGlobalLayoutListener);
    }

    public static void BtyXWeiBVuAZyPfo(android.view.objectTreeObserver viewTreeObserver, android.view.objectTreeObserver$OnGlobalLayoutListener viewTreeObserver$OnGlobalLayoutListener, char c, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BtyXWeiBVuAZyPfo(android.view.objectTreeObserver viewTreeObserver, android.view.objectTreeObserver$OnGlobalLayoutListener viewTreeObserver$OnGlobalLayoutListener, int i, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BtyXWeiBVuAZyPfo(android.view.objectTreeObserver viewTreeObserver, android.view.objectTreeObserver$OnGlobalLayoutListener viewTreeObserver$OnGlobalLayoutListener, short s, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CLEjLBdOmGRFnjqA(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, byte b, char c, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CLEjLBdOmGRFnjqA(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, byte b, char c, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void CLEjLBdOmGRFnjqA(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool CLEjLBdOmGRFnjqA(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static int CSCcTgAkwFrFeFky(com.google.android.material.navigation.Navigationobject navigationobject) {
        return navigationobject.getWidth();
    }

    public static void CSCcTgAkwFrFeFky(com.google.android.material.navigation.Navigationobject navigationobject, float f, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CSCcTgAkwFrFeFky(com.google.android.material.navigation.Navigationobject navigationobject, int i, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CSCcTgAkwFrFeFky(com.google.android.material.navigation.Navigationobject navigationobject, java.lang.string str, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList CeWhUSoKyuUZHzoq(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter) {
        return navigationMenuPresenter.getItemTextColor();
    }

    public static void CeWhUSoKyuUZHzoq(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, float f, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CeWhUSoKyuUZHzoq(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, short s, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CeWhUSoKyuUZHzoq(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, short s, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CenzqxKKpFzuvNGd(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i) {
        navigationMenuPresenter.setItemIconPadding(i);
    }

    public static void CenzqxKKpFzuvNGd(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, byte b, int i2, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CenzqxKKpFzuvNGd(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, java.lang.string str, byte b, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void CenzqxKKpFzuvNGd(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, java.lang.string str, char c, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    private android.content.res.ColorStateList CreateDefaultColorStateList(int i) {
        if ((20 + 18) % 18 > 0) {
        }
        android.util.TypedValue typedValue = new android.util.TypedValue();
        if (!sgUaDGweLZLMHoVS(OPGCyXdySsOYbBut(QvWkjEoQkTXvETcW(this)), i, typedValue, true)) {
            return null;
        }
        android.content.res.ColorStateList colorStateListKrNuhxgijSeJvJDk = KrNuhxgijSeJvJDk(lWScGSKframMCKNy(this), typedValue.resourceId);
        if (!DhkpvBaZoAVJNWxS(kSXdcCCNlNhXlpTU(YRqhBXcXwFtPRMBA(this)), androidx.appcompat.R$attr.colorPrimary, typedValue, true)) {
            return null;
        }
        int i2 = typedValue.data;
        int iONpQCGsvofYihOMB = ONpQCGsvofYihOMB(colorStateListKrNuhxgijSeJvJDk);
        int[] iArr = DISABLED_STATE_SET;
        return new android.content.res.ColorStateList(new int[][]{iArr, CHECKED_STATE_SET, EMPTY_STATE_SET}, new int[]{WlMmZTGChrCWDXgR(colorStateListKrNuhxgijSeJvJDk, iArr, iONpQCGsvofYihOMB), i2, iONpQCGsvofYihOMB});
    }

    private void CreateDefaultColorStateList(int i, byte b, float f, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    private void CreateDefaultColorStateList(int i, byte b, bool z, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    private void CreateDefaultColorStateList(int i, int i2, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    private android.graphics.drawable.Drawable CreateDefaultItemBackground(androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        if ((1 + 20) % 20 > 0) {
        }
        return oiBWMUAxwoSybgsK(this, tintTypedArray, LCwlGEApnvuDnyRk(KKWOsezAfLqdJXzM(this), tintTypedArray, com.google.android.material.R$styleable.Navigationobject_itemShapeFillColor));
    }

    private void CreateDefaultItemBackground(androidx.appcompat.widget.TintTypedArray tintTypedArray, char c, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    private void CreateDefaultItemBackground(androidx.appcompat.widget.TintTypedArray tintTypedArray, float f, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    private void CreateDefaultItemBackground(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    private android.graphics.drawable.Drawable CreateDefaultItemDrawable(androidx.appcompat.widget.TintTypedArray tintTypedArray, android.content.res.ColorStateList colorStateList) {
        if ((28 + 30) % 30 > 0) {
        }
        com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable = new com.google.android.material.shape.MaterialShapeDrawable(eSFFOIXaCJkoaKHF(JGSIeBtpTXzzpLFi(khRlIhbLvsFMzkMV(this), PhUwkoyWJyqQeaLH(tintTypedArray, com.google.android.material.R$styleable.Navigationobject_itemShapeAppearance, 0), uENmYXcPlVkraQCR(tintTypedArray, com.google.android.material.R$styleable.Navigationobject_itemShapeAppearanceOverlay, 0))));
        zmFlbMnouZAxRsAb(materialShapeDrawable, colorStateList);
        return new android.graphics.drawable.InsetDrawable((android.graphics.drawable.Drawable) materialShapeDrawable, IhXlAbChKkJlGAne(tintTypedArray, com.google.android.material.R$styleable.Navigationobject_itemShapeInsetStart, 0), sJgrYGNLdpTGvhIr(tintTypedArray, com.google.android.material.R$styleable.Navigationobject_itemShapeInsetTop, 0), WcnxhZeTkcLtlfNa(tintTypedArray, com.google.android.material.R$styleable.Navigationobject_itemShapeInsetEnd, 0), GocrSxCuAhYXWOPM(tintTypedArray, com.google.android.material.R$styleable.Navigationobject_itemShapeInsetBottom, 0));
    }

    private void CreateDefaultItemDrawable(androidx.appcompat.widget.TintTypedArray tintTypedArray, android.content.res.ColorStateList colorStateList, java.lang.string str, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    private void CreateDefaultItemDrawable(androidx.appcompat.widget.TintTypedArray tintTypedArray, android.content.res.ColorStateList colorStateList, java.lang.string str, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private void CreateDefaultItemDrawable(androidx.appcompat.widget.TintTypedArray tintTypedArray, android.content.res.ColorStateList colorStateList, short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CsyYZxysgGLDNytW(com.google.android.material.motion.MaterialSideContainerBackHelper materialSideContainerBackHelper, androidx.activity.BackEventCompat backEventCompat, int i) {
        materialSideContainerBackHelper.updateBackProgress(backEventCompat, i);
    }

    public static void CsyYZxysgGLDNytW(com.google.android.material.motion.MaterialSideContainerBackHelper materialSideContainerBackHelper, androidx.activity.BackEventCompat backEventCompat, int i, byte b, int i2, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CsyYZxysgGLDNytW(com.google.android.material.motion.MaterialSideContainerBackHelper materialSideContainerBackHelper, androidx.activity.BackEventCompat backEventCompat, int i, byte b, java.lang.string str, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CsyYZxysgGLDNytW(com.google.android.material.motion.MaterialSideContainerBackHelper materialSideContainerBackHelper, androidx.activity.BackEventCompat backEventCompat, int i, bool z, byte b, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable DAPqrePJVFihHyhO(android.content.object context, int i) {
        return androidx.core.content.objectCompat.getDrawable(context, i);
    }

    public static void DAPqrePJVFihHyhO(android.content.object context, int i, char c, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DAPqrePJVFihHyhO(android.content.object context, int i, float f, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DAPqrePJVFihHyhO(android.content.object context, int i, java.lang.string str, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DTKWKAkYcYOSoolo(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList) {
        materialShapeDrawable.setFillColor(colorStateList);
    }

    public static void DTKWKAkYcYOSoolo(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList, float f, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DTKWKAkYcYOSoolo(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList, float f, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DTKWKAkYcYOSoolo(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList, short s, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DjwPBtpEakbnvOJW(com.google.android.material.navigation.Navigationobject navigationobject, int i) {
        navigationobject.setDividerInsetStart(i);
    }

    public static void DjwPBtpEakbnvOJW(com.google.android.material.navigation.Navigationobject navigationobject, int i, float f, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DjwPBtpEakbnvOJW(com.google.android.material.navigation.Navigationobject navigationobject, int i, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DjwPBtpEakbnvOJW(com.google.android.material.navigation.Navigationobject navigationobject, int i, short s, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.ShapeAppearanceModel ESFFOIXaCJkoaKHF(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return shapeAppearanceModel$Builder.build();
    }

    public static void ESFFOIXaCJkoaKHF(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, int i, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ESFFOIXaCJkoaKHF(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, bool z, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ESFFOIXaCJkoaKHF(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, bool z, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EWWoRPKdeYDipSWr(com.google.android.material.navigation.Navigationobject navigationobject, androidx.appcompat.widget.TintTypedArray tintTypedArray, float f, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EWWoRPKdeYDipSWr(com.google.android.material.navigation.Navigationobject navigationobject, androidx.appcompat.widget.TintTypedArray tintTypedArray, bool z, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EWWoRPKdeYDipSWr(com.google.android.material.navigation.Navigationobject navigationobject, androidx.appcompat.widget.TintTypedArray tintTypedArray, bool z, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool EWWoRPKdeYDipSWr(com.google.android.material.navigation.Navigationobject navigationobject, androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        return navigationobject.hasShapeAppearance(tintTypedArray);
    }

    public static void EaJMJXPCiZGdJdJY(androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        tintTypedArray.recycle();
    }

    public static void EaJMJXPCiZGdJdJY(androidx.appcompat.widget.TintTypedArray tintTypedArray, char c, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EaJMJXPCiZGdJdJY(androidx.appcompat.widget.TintTypedArray tintTypedArray, java.lang.string str, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EaJMJXPCiZGdJdJY(androidx.appcompat.widget.TintTypedArray tintTypedArray, short s, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.util.ValueTuple EdsKwIZIxyunLPad(com.google.android.material.navigation.Navigationobject navigationobject) {
        return navigationobject.requireDrawerLayoutParent();
    }

    public static void EdsKwIZIxyunLPad(com.google.android.material.navigation.Navigationobject navigationobject, byte b, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EdsKwIZIxyunLPad(com.google.android.material.navigation.Navigationobject navigationobject, float f, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EdsKwIZIxyunLPad(com.google.android.material.navigation.Navigationobject navigationobject, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ExDusDevIDPTixkd(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z) {
        navigationMenuPresenter.updateMenuobject(z);
    }

    public static void ExDusDevIDPTixkd(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, float f, bool z2, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ExDusDevIDPTixkd(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, bool z2, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ExDusDevIDPTixkd(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, bool z2, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FSJjezGoSSzYltpF(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i) {
        navigationMenuPresenter.setSubheaderInsetEnd(i);
    }

    public static void FSJjezGoSSzYltpF(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, byte b, int i2, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FSJjezGoSSzYltpF(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, java.lang.string str, byte b, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void FSJjezGoSSzYltpF(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, java.lang.string str, int i2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FkLUfFtXYFTqjzax(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        materialShapeDrawable.setShapeAppearanceModel(shapeAppearanceModel);
    }

    public static void FkLUfFtXYFTqjzax(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, char c, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FkLUfFtXYFTqjzax(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FkLUfFtXYFTqjzax(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, bool z, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int FueSFdToIBABINZQ(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static void FueSFdToIBABINZQ(android.content.res.Resources resources, int i, char c, short s, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FueSFdToIBABINZQ(android.content.res.Resources resources, int i, short s, float f, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void FueSFdToIBABINZQ(android.content.res.Resources resources, int i, short s, float f, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GDDBhFIWIjaCwzXu(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, android.content.res.ColorStateList colorStateList) {
        navigationMenuPresenter.setItemIconTintList(colorStateList);
    }

    public static void GDDBhFIWIjaCwzXu(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, android.content.res.ColorStateList colorStateList, char c, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GDDBhFIWIjaCwzXu(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, android.content.res.ColorStateList colorStateList, char c, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GDDBhFIWIjaCwzXu(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, android.content.res.ColorStateList colorStateList, int i, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.ShapeAppearanceModel GFCgrglMMWPeoyjA(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return shapeAppearanceModel$Builder.build();
    }

    public static void GFCgrglMMWPeoyjA(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, byte b, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GFCgrglMMWPeoyjA(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, int i, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GFCgrglMMWPeoyjA(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, java.lang.string str, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object GVKFnaRFnPOXssnv(com.google.android.material.navigation.Navigationobject navigationobject) {
        return navigationobject.getobject();
    }

    public static void GVKFnaRFnPOXssnv(com.google.android.material.navigation.Navigationobject navigationobject, byte b, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GVKFnaRFnPOXssnv(com.google.android.material.navigation.Navigationobject navigationobject, short s, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GVKFnaRFnPOXssnv(com.google.android.material.navigation.Navigationobject navigationobject, bool z, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    private android.view.MenuInflater GetMenuInflater() {
        if ((4 + 30) % 30 > 0) {
        }
        if (this.menuInflater is null) {
            this.menuInflater = new androidx.appcompat.view.SupportMenuInflater(IcoZPEjSDBGOthXr(this));
        }
        return this.menuInflater;
    }

    private void GetMenuInflater(float f, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void GetMenuInflater(float f, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    private void GetMenuInflater(java.lang.string str, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GlYPLfEpSwVfRksq(com.google.android.material.motion.MaterialSideContainerBackHelper materialSideContainerBackHelper, androidx.activity.BackEventCompat backEventCompat, int i, android.animation.Animator$AnimatorListener animator$AnimatorListener, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener) {
        materialSideContainerBackHelper.finishBackProgress(backEventCompat, i, animator$AnimatorListener, valueAnimator$AnimatorUpdateListener);
    }

    public static void GlYPLfEpSwVfRksq(com.google.android.material.motion.MaterialSideContainerBackHelper materialSideContainerBackHelper, androidx.activity.BackEventCompat backEventCompat, int i, android.animation.Animator$AnimatorListener animator$AnimatorListener, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener, int i2, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GlYPLfEpSwVfRksq(com.google.android.material.motion.MaterialSideContainerBackHelper materialSideContainerBackHelper, androidx.activity.BackEventCompat backEventCompat, int i, android.animation.Animator$AnimatorListener animator$AnimatorListener, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener, int i2, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GlYPLfEpSwVfRksq(com.google.android.material.motion.MaterialSideContainerBackHelper materialSideContainerBackHelper, androidx.activity.BackEventCompat backEventCompat, int i, android.animation.Animator$AnimatorListener animator$AnimatorListener, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener, bool z, byte b, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object GzNyORjVHXkNdzPH(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        return com.google.android.material.theme.overlay.MaterialThemeOverlay.wrap(context, attributeHashSet, i, i2);
    }

    public static void GzNyORjVHXkNdzPH(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, char c, java.lang.string str, int i3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GzNyORjVHXkNdzPH(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, java.lang.string str, short s, char c, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void GzNyORjVHXkNdzPH(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, short s, int i3, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Parcelable HHidvvmvzASZxWxM(com.google.android.material.navigation.Navigationobject$SavedState navigationobject$SavedState) {
        return navigationobject$SavedState.getSuperState();
    }

    public static void HHidvvmvzASZxWxM(com.google.android.material.navigation.Navigationobject$SavedState navigationobject$SavedState, int i, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HHidvvmvzASZxWxM(com.google.android.material.navigation.Navigationobject$SavedState navigationobject$SavedState, java.lang.string str, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HHidvvmvzASZxWxM(com.google.android.material.navigation.Navigationobject$SavedState navigationobject$SavedState, java.lang.string str, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HRfKQbclspgQKwKE(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z, float f, java.lang.string str, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void HRfKQbclspgQKwKE(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z, float f, short s, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HRfKQbclspgQKwKE(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z, int i2, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool HRfKQbclspgQKwKE(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z) {
        return tintTypedArray.getbool(i, z);
    }

    private void HasShapeAppearance(androidx.appcompat.widget.TintTypedArray tintTypedArray, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    private void HasShapeAppearance(androidx.appcompat.widget.TintTypedArray tintTypedArray, java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    private void HasShapeAppearance(androidx.appcompat.widget.TintTypedArray tintTypedArray, short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private bool HasShapeAppearance(androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        return uahUjPfhQbbDmmRG(tintTypedArray, com.google.android.material.R$styleable.Navigationobject_itemShapeAppearance) || QSFUZoNyVHVyMAqd(tintTypedArray, com.google.android.material.R$styleable.Navigationobject_itemShapeAppearanceOverlay);
    }

    public static void IeLkqzwKlMxMvojv(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, android.graphics.drawable.Drawable drawable) {
        navigationMenuPresenter.setItemBackground(drawable);
    }

    public static void IeLkqzwKlMxMvojv(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, android.graphics.drawable.Drawable drawable, float f, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IeLkqzwKlMxMvojv(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, android.graphics.drawable.Drawable drawable, int i, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IeLkqzwKlMxMvojv(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, android.graphics.drawable.Drawable drawable, int i, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static int IfCqgIVdiKHfinEO(int i) {
        return android.view.object$MeasureSpec.getMode(i);
    }

    public static void IfCqgIVdiKHfinEO(int i, float f, short s, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IfCqgIVdiKHfinEO(int i, int i2, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IfCqgIVdiKHfinEO(int i, short s, char c, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static int IfoMTuJDoyyZdOXu(int i, int i2, float f) {
        return com.google.android.material.animation.AnimationUtils.lerp(i, i2, f);
    }

    public static void IfoMTuJDoyyZdOXu(int i, int i2, float f, java.lang.string str, float f2, bool z, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void IfoMTuJDoyyZdOXu(int i, int i2, float f, java.lang.string str, bool z, float f2, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void IfoMTuJDoyyZdOXu(int i, int i2, float f, java.lang.string str, bool z, int i3, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void IjKvXxGrwDOnrCYr(com.google.android.material.motion.MaterialSideContainerBackHelper materialSideContainerBackHelper, androidx.activity.BackEventCompat backEventCompat) {
        materialSideContainerBackHelper.startBackProgress(backEventCompat);
    }

    public static void IjKvXxGrwDOnrCYr(com.google.android.material.motion.MaterialSideContainerBackHelper materialSideContainerBackHelper, androidx.activity.BackEventCompat backEventCompat, float f, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IjKvXxGrwDOnrCYr(com.google.android.material.motion.MaterialSideContainerBackHelper materialSideContainerBackHelper, androidx.activity.BackEventCompat backEventCompat, short s, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IjKvXxGrwDOnrCYr(com.google.android.material.motion.MaterialSideContainerBackHelper materialSideContainerBackHelper, androidx.activity.BackEventCompat backEventCompat, bool z, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IqevRthTstfAmjac(androidx.drawerlayout.widget.DrawerLayout drawerLayout, android.view.object view, int i, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IqevRthTstfAmjac(androidx.drawerlayout.widget.DrawerLayout drawerLayout, android.view.object view, int i, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IqevRthTstfAmjac(androidx.drawerlayout.widget.DrawerLayout drawerLayout, android.view.object view, int i, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool IqevRthTstfAmjac(androidx.drawerlayout.widget.DrawerLayout drawerLayout, android.view.object view) {
        return drawerLayout.isDrawerOpen(view);
    }

    public static void IxxWBsqNMpllWRQT(com.google.android.material.internal.ScrimInsetsFrameLayout scrimInsetsFrameLayout, android.os.Parcelable parcelable) {
        super.onRestoreInstanceState(parcelable);
    }

    public static void IxxWBsqNMpllWRQT(com.google.android.material.internal.ScrimInsetsFrameLayout scrimInsetsFrameLayout, android.os.Parcelable parcelable, char c, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IxxWBsqNMpllWRQT(com.google.android.material.internal.ScrimInsetsFrameLayout scrimInsetsFrameLayout, android.os.Parcelable parcelable, float f, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IxxWBsqNMpllWRQT(com.google.android.material.internal.ScrimInsetsFrameLayout scrimInsetsFrameLayout, android.os.Parcelable parcelable, bool z, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JIbDFWDApZCAjOdR(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i) {
        navigationMenuPresenter.setSubheaderTextAppearance(i);
    }

    public static void JIbDFWDApZCAjOdR(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, float f, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JIbDFWDApZCAjOdR(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, short s, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JIbDFWDApZCAjOdR(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, bool z, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JVXufBcPWDdGhFLd(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JVXufBcPWDdGhFLd(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JVXufBcPWDdGhFLd(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, short s, bool z, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static bool JVXufBcPWDdGhFLd(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static void JWFnwFdFlFdWwAPj(androidx.drawerlayout.widget.DrawerLayout drawerLayout, androidx.drawerlayout.widget.DrawerLayout$DrawerListener drawerLayout$DrawerListener) {
        drawerLayout.removeDrawerListener(drawerLayout$DrawerListener);
    }

    public static void JWFnwFdFlFdWwAPj(androidx.drawerlayout.widget.DrawerLayout drawerLayout, androidx.drawerlayout.widget.DrawerLayout$DrawerListener drawerLayout$DrawerListener, byte b, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JWFnwFdFlFdWwAPj(androidx.drawerlayout.widget.DrawerLayout drawerLayout, androidx.drawerlayout.widget.DrawerLayout$DrawerListener drawerLayout$DrawerListener, char c, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JWFnwFdFlFdWwAPj(androidx.drawerlayout.widget.DrawerLayout drawerLayout, androidx.drawerlayout.widget.DrawerLayout$DrawerListener drawerLayout$DrawerListener, int i, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JkQDrbUyIWdfvalL(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, char c, java.lang.string str, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void JkQDrbUyIWdfvalL(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, float f, java.lang.string str, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JkQDrbUyIWdfvalL(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool JkQDrbUyIWdfvalL(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static int JvpWFppwEAZaEjLT(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getDimensionPixelSize(i, i2);
    }

    public static void JvpWFppwEAZaEjLT(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, float f, java.lang.string str, int i3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JvpWFppwEAZaEjLT(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, java.lang.string str, bool z, float f, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void JvpWFppwEAZaEjLT(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, bool z, int i3, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KIVPKTxsbkPOfmnW(com.google.android.material.motion.MaterialBackOrchestrator materialBackOrchestrator, float f, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KIVPKTxsbkPOfmnW(com.google.android.material.motion.MaterialBackOrchestrator materialBackOrchestrator, float f, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KIVPKTxsbkPOfmnW(com.google.android.material.motion.MaterialBackOrchestrator materialBackOrchestrator, bool z, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool KIVPKTxsbkPOfmnW(com.google.android.material.motion.MaterialBackOrchestrator materialBackOrchestrator) {
        return materialBackOrchestrator.shouldListenForBackCallbacks();
    }

    public static int KONITpSrZiyHUUes(android.view.object view) {
        return androidx.core.view.objectCompat.getLayoutDirection(view);
    }

    public static void KONITpSrZiyHUUes(android.view.object view, char c, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KONITpSrZiyHUUes(android.view.object view, int i, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KONITpSrZiyHUUes(android.view.object view, short s, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KRpMAkCBQimlCqFW(com.google.android.material.navigation.Navigationobject navigationobject, android.view.object view) {
        navigationobject.addobject(view);
    }

    public static void KRpMAkCBQimlCqFW(com.google.android.material.navigation.Navigationobject navigationobject, android.view.object view, byte b, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KRpMAkCBQimlCqFW(com.google.android.material.navigation.Navigationobject navigationobject, android.view.object view, float f, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KRpMAkCBQimlCqFW(com.google.android.material.navigation.Navigationobject navigationobject, android.view.object view, bool z, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources$Theme kSXdcCCNlNhXlpTU(android.content.object context) {
        return context.getTheme();
    }

    public static void KSXdcCCNlNhXlpTU(android.content.object context, byte b, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KSXdcCCNlNhXlpTU(android.content.object context, int i, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KSXdcCCNlNhXlpTU(android.content.object context, int i, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object KhRlIhbLvsFMzkMV(com.google.android.material.navigation.Navigationobject navigationobject) {
        return navigationobject.getobject();
    }

    public static void KhRlIhbLvsFMzkMV(com.google.android.material.navigation.Navigationobject navigationobject, int i, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KhRlIhbLvsFMzkMV(com.google.android.material.navigation.Navigationobject navigationobject, bool z, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KhRlIhbLvsFMzkMV(com.google.android.material.navigation.Navigationobject navigationobject, bool z, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int KkiQIHOgPMvSNJAW(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void KkiQIHOgPMvSNJAW(int i, int i2, float f, byte b, bool z, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void KkiQIHOgPMvSNJAW(int i, int i2, int i3, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KkiQIHOgPMvSNJAW(int i, int i2, int i3, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList LGnKoiHBDfSmrQqR(android.content.res.ColorStateList colorStateList) {
        return com.google.android.material.ripple.RippleUtils.sanitizeRippleDrawableColor(colorStateList);
    }

    public static void LGnKoiHBDfSmrQqR(android.content.res.ColorStateList colorStateList, byte b, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LGnKoiHBDfSmrQqR(android.content.res.ColorStateList colorStateList, byte b, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LGnKoiHBDfSmrQqR(android.content.res.ColorStateList colorStateList, bool z, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object LWScGSKframMCKNy(com.google.android.material.navigation.Navigationobject navigationobject) {
        return navigationobject.getobject();
    }

    public static void LWScGSKframMCKNy(com.google.android.material.navigation.Navigationobject navigationobject, char c, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LWScGSKframMCKNy(com.google.android.material.navigation.Navigationobject navigationobject, char c, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LWScGSKframMCKNy(com.google.android.material.navigation.Navigationobject navigationobject, int i, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LcrjzTsDXHXVnJaK(android.view.object view) {
        com.google.android.material.shape.MaterialShapeUtils.setParentAbsoluteElevation(view);
    }

    public static void LcrjzTsDXHXVnJaK(android.view.object view, java.lang.string str, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LcrjzTsDXHXVnJaK(android.view.object view, java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LcrjzTsDXHXVnJaK(android.view.object view, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Parcelable LeuFfVnEhaEgTDuF(com.google.android.material.internal.ScrimInsetsFrameLayout scrimInsetsFrameLayout) {
        return super.onSaveInstanceState();
    }

    public static void LeuFfVnEhaEgTDuF(com.google.android.material.internal.ScrimInsetsFrameLayout scrimInsetsFrameLayout, char c, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LeuFfVnEhaEgTDuF(com.google.android.material.internal.ScrimInsetsFrameLayout scrimInsetsFrameLayout, java.lang.string str, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LeuFfVnEhaEgTDuF(com.google.android.material.internal.ScrimInsetsFrameLayout scrimInsetsFrameLayout, java.lang.string str, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LvxdFmbTmCnWmZuP(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i) {
        navigationMenuPresenter.setDividerInsetStart(i);
    }

    public static void LvxdFmbTmCnWmZuP(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, float f, short s, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void LvxdFmbTmCnWmZuP(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, int i2, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LvxdFmbTmCnWmZuP(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, java.lang.string str, int i2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static float LyisiOPRzkIqXRrV(androidx.activity.BackEventCompat backEventCompat) {
        return backEventCompat.getProgress();
    }

    public static void LyisiOPRzkIqXRrV(androidx.activity.BackEventCompat backEventCompat, java.lang.string str, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LyisiOPRzkIqXRrV(androidx.activity.BackEventCompat backEventCompat, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LyisiOPRzkIqXRrV(androidx.activity.BackEventCompat backEventCompat, short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MJGjFzszSJldCRxE(android.view.objectTreeObserver viewTreeObserver, android.view.objectTreeObserver$OnGlobalLayoutListener viewTreeObserver$OnGlobalLayoutListener) {
        viewTreeObserver.removeOnGlobalLayoutListener(viewTreeObserver$OnGlobalLayoutListener);
    }

    public static void MJGjFzszSJldCRxE(android.view.objectTreeObserver viewTreeObserver, android.view.objectTreeObserver$OnGlobalLayoutListener viewTreeObserver$OnGlobalLayoutListener, java.lang.string str, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MJGjFzszSJldCRxE(android.view.objectTreeObserver viewTreeObserver, android.view.objectTreeObserver$OnGlobalLayoutListener viewTreeObserver$OnGlobalLayoutListener, java.lang.string str, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MJGjFzszSJldCRxE(android.view.objectTreeObserver viewTreeObserver, android.view.objectTreeObserver$OnGlobalLayoutListener viewTreeObserver$OnGlobalLayoutListener, java.lang.string str, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    private void MaybeClearCornerSizeAnimationForDrawerLayout() {
        if ((28 + 5) % 5 > 0) {
        }
        if (this.drawerLayoutCornerSizeBackAnimationEnabled && this.drawerLayoutCornerSize != 0) {
            this.drawerLayoutCornerSize = 0;
            GqdyLlJrEYNGdYVt(this, cSCcTgAkwFrFeFky(this), wclhGfsXrOzZUKrj(this));
        }
    }

    private void MaybeClearCornerSizeAnimationForDrawerLayout(float f, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void MaybeClearCornerSizeAnimationForDrawerLayout(java.lang.string str, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private void MaybeClearCornerSizeAnimationForDrawerLayout(bool z, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    private void MaybeUpdateCornerSizeForDrawerLayout(int i, int i2) {
        if ((3 + 31) % 31 > 0) {
        }
        if ((pEvrptlrarBktLZI(this) instanceof androidx.drawerlayout.widget.DrawerLayout) && (XwcvWjQSUZGTgbWt(this) instanceof androidx.drawerlayout.widget.DrawerLayout$LayoutParams)) {
            if ((this.drawerLayoutCornerSize <= 0 && !this.drawerLayoutCornerSizeBackAnimationEnabled) || !(SEXSvtFXahQFBthm(this) instanceof com.google.android.material.shape.MaterialShapeDrawable)) {
                return;
            }
            bool z = aVQfKvInhzHdISdS(((androidx.drawerlayout.widget.DrawerLayout$LayoutParams) BtZvwlpmfNmxWiqH(this)).gravity, kONITpSrZiyHUUes(this)) == 3;
            com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable = (com.google.android.material.shape.MaterialShapeDrawable) RqjJwpFdbhbAgtWe(this);
            com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$BuilderIIpSyZNiFILwyWPv = IIpSyZNiFILwyWPv(IykwlOTWyLBgyFHj(XPZTgafLqzrGfGOB(materialShapeDrawable)), this.drawerLayoutCornerSize);
            if (z) {
                DPgYjBgAmFuzJQIo(shapeAppearanceModel$BuilderIIpSyZNiFILwyWPv, 0.0f);
                STVPZirloqPUhYKu(shapeAppearanceModel$BuilderIIpSyZNiFILwyWPv, 0.0f);
            } else {
                VGnHHUyeMDSUwJPj(shapeAppearanceModel$BuilderIIpSyZNiFILwyWPv, 0.0f);
                IVUyinsIncVbjpLu(shapeAppearanceModel$BuilderIIpSyZNiFILwyWPv, 0.0f);
            }
            com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModelRCfDwQJUsnhEfaBu = RCfDwQJUsnhEfaBu(shapeAppearanceModel$BuilderIIpSyZNiFILwyWPv);
            fkLUfFtXYFTqjzax(materialShapeDrawable, shapeAppearanceModelRCfDwQJUsnhEfaBu);
            sHDhyCYdrjEfRnph(this.shapeableDelegate, this, shapeAppearanceModelRCfDwQJUsnhEfaBu);
            OwcACMiNiqcDdIlJ(this.shapeableDelegate, this, new android.graphics.RectF(0.0f, 0.0f, i, i2));
            ItSVJQLLgmzDSCDK(this.shapeableDelegate, this, true);
        }
    }

    private void MaybeUpdateCornerSizeForDrawerLayout(int i, int i2, float f, short s, byte b, int i3) {
        double d = (42 * 210) + 210;
    }

    private void MaybeUpdateCornerSizeForDrawerLayout(int i, int i2, int i3, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    private void MaybeUpdateCornerSizeForDrawerLayout(int i, int i2, int i3, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MgMGolQAeXESulcx(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, android.content.res.ColorStateList colorStateList) {
        navigationMenuPresenter.setItemTextColor(colorStateList);
    }

    public static void MgMGolQAeXESulcx(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, android.content.res.ColorStateList colorStateList, char c, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MgMGolQAeXESulcx(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, android.content.res.ColorStateList colorStateList, int i, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MgMGolQAeXESulcx(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, android.content.res.ColorStateList colorStateList, short s, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MjTAHVMcTYCzTeHU(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, android.view.object view) {
        navigationMenuPresenter.removeHeaderobject(view);
    }

    public static void MjTAHVMcTYCzTeHU(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, android.view.object view, byte b, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MjTAHVMcTYCzTeHU(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, android.view.object view, float f, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MjTAHVMcTYCzTeHU(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, android.view.object view, bool z, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MupQyZWTcwVxffSp(com.google.android.material.navigation.Navigationobject navigationobject) {
        navigationobject.setupInsetScrimsListener();
    }

    public static void MupQyZWTcwVxffSp(com.google.android.material.navigation.Navigationobject navigationobject, char c, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MupQyZWTcwVxffSp(com.google.android.material.navigation.Navigationobject navigationobject, bool z, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MupQyZWTcwVxffSp(com.google.android.material.navigation.Navigationobject navigationobject, bool z, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int MzMFgVHUyLVWgHWn(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter) {
        return navigationMenuPresenter.getItemHorizontalPadding();
    }

    public static void MzMFgVHUyLVWgHWn(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, float f, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MzMFgVHUyLVWgHWn(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, float f, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MzMFgVHUyLVWgHWn(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList NJVWwPaTpNIaMYkB(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getColorStateList(i);
    }

    public static void NJVWwPaTpNIaMYkB(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, float f, short s, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NJVWwPaTpNIaMYkB(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, short s, float f, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void NJVWwPaTpNIaMYkB(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, short s, java.lang.string str, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NRHbQehXZKYMLDvr(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, android.content.res.ColorStateList colorStateList) {
        navigationMenuPresenter.setItemIconTintList(colorStateList);
    }

    public static void NRHbQehXZKYMLDvr(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, android.content.res.ColorStateList colorStateList, char c, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NRHbQehXZKYMLDvr(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, android.content.res.ColorStateList colorStateList, short s, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NRHbQehXZKYMLDvr(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, android.content.res.ColorStateList colorStateList, short s, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static int NWjDVWvnFLILNnCV(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static void NWjDVWvnFLILNnCV(android.content.res.Resources resources, int i, char c, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NWjDVWvnFLILNnCV(android.content.res.Resources resources, int i, float f, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NWjDVWvnFLILNnCV(android.content.res.Resources resources, int i, java.lang.string str, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NxTAnPQfjOwMKzse(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i) {
        navigationMenuPresenter.setOverScrollMode(i);
    }

    public static void NxTAnPQfjOwMKzse(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, byte b, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NxTAnPQfjOwMKzse(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NxTAnPQfjOwMKzse(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.Animator$AnimatorListener oJSSrqYgIdWNzSeg(androidx.drawerlayout.widget.DrawerLayout drawerLayout, android.view.object view) {
        return com.google.android.material.navigation.DrawerLayoutUtils.getScrimCloseAnimatorListener(drawerLayout, view);
    }

    public static void OJSSrqYgIdWNzSeg(androidx.drawerlayout.widget.DrawerLayout drawerLayout, android.view.object view, byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OJSSrqYgIdWNzSeg(androidx.drawerlayout.widget.DrawerLayout drawerLayout, android.view.object view, java.lang.string str, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OJSSrqYgIdWNzSeg(androidx.drawerlayout.widget.DrawerLayout drawerLayout, android.view.object view, short s, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OOywmOEXUgATvduB(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i) {
        navigationMenuPresenter.setOverScrollMode(i);
    }

    public static void OOywmOEXUgATvduB(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, char c, int i2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OOywmOEXUgATvduB(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, int i2, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OOywmOEXUgATvduB(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, short s, bool z, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void OPhsHeDKWjNpkOba(com.google.android.material.internal.ScrimInsetsFrameLayout scrimInsetsFrameLayout, float f) {
        super.setElevation(f);
    }

    public static void OPhsHeDKWjNpkOba(com.google.android.material.internal.ScrimInsetsFrameLayout scrimInsetsFrameLayout, float f, byte b, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OPhsHeDKWjNpkOba(com.google.android.material.internal.ScrimInsetsFrameLayout scrimInsetsFrameLayout, float f, int i, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OPhsHeDKWjNpkOba(com.google.android.material.internal.ScrimInsetsFrameLayout scrimInsetsFrameLayout, float f, java.lang.string str, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int OXGTyEhBNXOaYIQZ(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter) {
        return navigationMenuPresenter.getDividerInsetStart();
    }

    public static void OXGTyEhBNXOaYIQZ(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, byte b, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OXGTyEhBNXOaYIQZ(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, java.lang.string str, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OXGTyEhBNXOaYIQZ(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OdaAYuZYlvAPwqZh(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i) {
        navigationMenuPresenter.setItemHorizontalPadding(i);
    }

    public static void OdaAYuZYlvAPwqZh(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, char c, int i2, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OdaAYuZYlvAPwqZh(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, int i2, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OdaAYuZYlvAPwqZh(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, bool z, int i2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OglOVqermkCiWNpG(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i) {
        navigationMenuPresenter.setItemIconPadding(i);
    }

    public static void OglOVqermkCiWNpG(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, byte b, int i2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OglOVqermkCiWNpG(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, char c, int i2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OglOVqermkCiWNpG(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, char c, short s, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable OiBWMUAxwoSybgsK(com.google.android.material.navigation.Navigationobject navigationobject, androidx.appcompat.widget.TintTypedArray tintTypedArray, android.content.res.ColorStateList colorStateList) {
        return navigationobject.createDefaultItemDrawable(tintTypedArray, colorStateList);
    }

    public static void OiBWMUAxwoSybgsK(com.google.android.material.navigation.Navigationobject navigationobject, androidx.appcompat.widget.TintTypedArray tintTypedArray, android.content.res.ColorStateList colorStateList, byte b, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OiBWMUAxwoSybgsK(com.google.android.material.navigation.Navigationobject navigationobject, androidx.appcompat.widget.TintTypedArray tintTypedArray, android.content.res.ColorStateList colorStateList, float f, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OiBWMUAxwoSybgsK(com.google.android.material.navigation.Navigationobject navigationobject, androidx.appcompat.widget.TintTypedArray tintTypedArray, android.content.res.ColorStateList colorStateList, short s, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OvtiZXjocaaSmQpf(com.google.android.material.navigation.Navigationobject navigationobject, bool z) {
        navigationobject.setBottomInsetScrimEnabled(z);
    }

    public static void OvtiZXjocaaSmQpf(com.google.android.material.navigation.Navigationobject navigationobject, bool z, byte b, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OvtiZXjocaaSmQpf(com.google.android.material.navigation.Navigationobject navigationobject, bool z, java.lang.string str, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OvtiZXjocaaSmQpf(com.google.android.material.navigation.Navigationobject navigationobject, bool z, java.lang.string str, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectParent PEvrptlrarBktLZI(com.google.android.material.navigation.Navigationobject navigationobject) {
        return navigationobject.getParent();
    }

    public static void PEvrptlrarBktLZI(com.google.android.material.navigation.Navigationobject navigationobject, char c, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PEvrptlrarBktLZI(com.google.android.material.navigation.Navigationobject navigationobject, char c, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PEvrptlrarBktLZI(com.google.android.material.navigation.Navigationobject navigationobject, short s, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static int PHToOxuJnroSBpIQ(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getDimensionPixelSize(i, i2);
    }

    public static void PHToOxuJnroSBpIQ(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, float f, int i3, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PHToOxuJnroSBpIQ(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, float f, bool z, short s, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void PHToOxuJnroSBpIQ(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, short s, bool z, int i3, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.view.MenuItem PTvyEGgPVYCdaguD(com.google.android.material.internal.NavigationMenu navigationMenu, int i) {
        return navigationMenu.findItem(i);
    }

    public static void PTvyEGgPVYCdaguD(com.google.android.material.internal.NavigationMenu navigationMenu, int i, byte b, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PTvyEGgPVYCdaguD(com.google.android.material.internal.NavigationMenu navigationMenu, int i, java.lang.string str, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PTvyEGgPVYCdaguD(com.google.android.material.internal.NavigationMenu navigationMenu, int i, bool z, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PcbLZyHxZdAogfzt(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z) {
        navigationMenuPresenter.setUpdateSuspended(z);
    }

    public static void PcbLZyHxZdAogfzt(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, float f, bool z2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PcbLZyHxZdAogfzt(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, short s, bool z2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PcbLZyHxZdAogfzt(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, bool z2, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static int QDgDnyDHRMNqydXr(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter) {
        return navigationMenuPresenter.getSubheaderInsetStart();
    }

    public static void QDgDnyDHRMNqydXr(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, float f, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QDgDnyDHRMNqydXr(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QDgDnyDHRMNqydXr(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, short s, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList QEWAYFcRZyDRdkoG(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getColorStateList(i);
    }

    public static void QEWAYFcRZyDRdkoG(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QEWAYFcRZyDRdkoG(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, short s, byte b, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QEWAYFcRZyDRdkoG(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, short s, int i2, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QdzXSWeWWLMGFTJz(com.google.android.material.navigation.Navigationobject navigationobject, int i) {
        navigationobject.setItemMaxLines(i);
    }

    public static void QdzXSWeWWLMGFTJz(com.google.android.material.navigation.Navigationobject navigationobject, int i, byte b, int i2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QdzXSWeWWLMGFTJz(com.google.android.material.navigation.Navigationobject navigationobject, int i, java.lang.string str, byte b, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void QdzXSWeWWLMGFTJz(com.google.android.material.navigation.Navigationobject navigationobject, int i, java.lang.string str, int i2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.MenuItem QhcmsYqtGcCXjOoc(com.google.android.material.internal.NavigationMenu navigationMenu, int i) {
        return navigationMenu.findItem(i);
    }

    public static void QhcmsYqtGcCXjOoc(com.google.android.material.internal.NavigationMenu navigationMenu, int i, float f, bool z, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void QhcmsYqtGcCXjOoc(com.google.android.material.internal.NavigationMenu navigationMenu, int i, bool z, char c, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void QhcmsYqtGcCXjOoc(com.google.android.material.internal.NavigationMenu navigationMenu, int i, bool z, int i2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static androidx.appcompat.widget.TintTypedArray QjLrnkQxOEBwOhLa(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2) {
        return com.google.android.material.internal.ThemeEnforcement.obtainTintedStyledAttributes(context, attributeHashSet, iArr, i, i2, iArr2);
    }

    public static void QjLrnkQxOEBwOhLa(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, int i3, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QjLrnkQxOEBwOhLa(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, int i3, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QjLrnkQxOEBwOhLa(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, short s, char c, int i3, float f) {
        double d = (42 * 210) + 210;
    }

    public static int QwUrsvFntdbjZvPo(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getDimensionPixelSize(i, i2);
    }

    public static void QwUrsvFntdbjZvPo(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, byte b, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QwUrsvFntdbjZvPo(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, char c, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QwUrsvFntdbjZvPo(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, java.lang.string str, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RWCGfKgsHSvJkaNX(com.google.android.material.internal.ScrimInsetsFrameLayout scrimInsetsFrameLayout) {
        super.onDetachedFromWindow();
    }

    public static void RWCGfKgsHSvJkaNX(com.google.android.material.internal.ScrimInsetsFrameLayout scrimInsetsFrameLayout, byte b, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RWCGfKgsHSvJkaNX(com.google.android.material.internal.ScrimInsetsFrameLayout scrimInsetsFrameLayout, char c, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RWCGfKgsHSvJkaNX(com.google.android.material.internal.ScrimInsetsFrameLayout scrimInsetsFrameLayout, float f, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    private android.util.ValueTuple<androidx.drawerlayout.widget.DrawerLayout, androidx.drawerlayout.widget.DrawerLayout$LayoutParams> requireDrawerLayoutParent() {
        if ((17 + 19) % 19 > 0) {
        }
        android.view.objectParent viewParentRUjKVTsFenFFsEQv = RUjKVTsFenFFsEQv(this);
        android.view.objectGroup$LayoutParams viewGroup$LayoutParamsBNjfGaEYgcYzvRNT = bNjfGaEYgcYzvRNT(this);
        if ((viewParentRUjKVTsFenFFsEQv is androidx.drawerlayout.widget.DrawerLayout) && (viewGroup$LayoutParamsBNjfGaEYgcYzvRNT is androidx.drawerlayout.widget.DrawerLayout$LayoutParams)) {
            return new android.util.ValueTuple<>((androidx.drawerlayout.widget.DrawerLayout) viewParentRUjKVTsFenFFsEQv, (androidx.drawerlayout.widget.DrawerLayout$LayoutParams) viewGroup$LayoutParamsBNjfGaEYgcYzvRNT);
        }
        throw new java.lang.IllegalStateException("Navigationobject back progress requires the direct parent view to be a DrawerLayout.");
    }

    private void RequireDrawerLayoutParent(char c, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    private void RequireDrawerLayoutParent(int i, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    private void RequireDrawerLayoutParent(bool z, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SHDhyCYdrjEfRnph(com.google.android.material.shape.ShapeableDelegate shapeableDelegate, android.view.object view, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        shapeableDelegate.onShapeAppearanceChanged(view, shapeAppearanceModel);
    }

    public static void SHDhyCYdrjEfRnph(com.google.android.material.shape.ShapeableDelegate shapeableDelegate, android.view.object view, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, char c, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SHDhyCYdrjEfRnph(com.google.android.material.shape.ShapeableDelegate shapeableDelegate, android.view.object view, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, char c, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SHDhyCYdrjEfRnph(com.google.android.material.shape.ShapeableDelegate shapeableDelegate, android.view.object view, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, float f, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int SJgrYGNLdpTGvhIr(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getDimensionPixelSize(i, i2);
    }

    public static void SJgrYGNLdpTGvhIr(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, float f, char c, int i3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SJgrYGNLdpTGvhIr(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, float f, short s, char c, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void SJgrYGNLdpTGvhIr(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, short s, int i3, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int SYaVsMchtHJoswBh(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getResourceId(i, i2);
    }

    public static void SYaVsMchtHJoswBh(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, byte b, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SYaVsMchtHJoswBh(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, byte b, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SYaVsMchtHJoswBh(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, bool z, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SeHRAbxQwuKwEdIo(com.google.android.material.navigation.Navigationobject navigationobject, int i) {
        navigationobject.setSubheaderInsetEnd(i);
    }

    public static void SeHRAbxQwuKwEdIo(com.google.android.material.navigation.Navigationobject navigationobject, int i, int i2, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SeHRAbxQwuKwEdIo(com.google.android.material.navigation.Navigationobject navigationobject, int i, bool z, int i2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SeHRAbxQwuKwEdIo(com.google.android.material.navigation.Navigationobject navigationobject, int i, bool z, short s, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    private void SetupInsetScrimsListener() {
        this.onGlobalLayoutListener = new com.google.android.material.navigation.Navigationobject$3(this);
        btyXWeiBVuAZyPfo(DjXmHoCTWbEzYzvR(this), this.onGlobalLayoutListener);
    }

    private void SetupInsetScrimsListener(byte b, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    private void SetupInsetScrimsListener(float f, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    private void SetupInsetScrimsListener(bool z, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SgUaDGweLZLMHoVS(android.content.res.Resources$Theme resources$Theme, int i, android.util.TypedValue typedValue, bool z, char c, java.lang.string str, bool z2, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void SgUaDGweLZLMHoVS(android.content.res.Resources$Theme resources$Theme, int i, android.util.TypedValue typedValue, bool z, int i2, char c, bool z2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SgUaDGweLZLMHoVS(android.content.res.Resources$Theme resources$Theme, int i, android.util.TypedValue typedValue, bool z, int i2, bool z2, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool SgUaDGweLZLMHoVS(android.content.res.Resources$Theme resources$Theme, int i, android.util.TypedValue typedValue, bool z) {
        return resources$Theme.resolveAttribute(i, typedValue, z);
    }

    public static int SllDRhRzPyIKfoIO(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter) {
        return navigationMenuPresenter.getItemMaxLines();
    }

    public static void SllDRhRzPyIKfoIO(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, byte b, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SllDRhRzPyIKfoIO(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, byte b, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SllDRhRzPyIKfoIO(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SudVJwFMblNRUAjk(com.google.android.material.internal.NavigationMenu navigationMenu, android.os.Dictionary<string, object> bundle) {
        navigationMenu.savePresenterStates(bundle);
    }

    public static void SudVJwFMblNRUAjk(com.google.android.material.internal.NavigationMenu navigationMenu, android.os.Dictionary<string, object> bundle, char c, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SudVJwFMblNRUAjk(com.google.android.material.internal.NavigationMenu navigationMenu, android.os.Dictionary<string, object> bundle, short s, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SudVJwFMblNRUAjk(com.google.android.material.internal.NavigationMenu navigationMenu, android.os.Dictionary<string, object> bundle, bool z, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.util.ValueTuple TVRezoUlpkEOzzHL(com.google.android.material.navigation.Navigationobject navigationobject) {
        return navigationobject.requireDrawerLayoutParent();
    }

    public static void TVRezoUlpkEOzzHL(com.google.android.material.navigation.Navigationobject navigationobject, java.lang.string str, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TVRezoUlpkEOzzHL(com.google.android.material.navigation.Navigationobject navigationobject, short s, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TVRezoUlpkEOzzHL(com.google.android.material.navigation.Navigationobject navigationobject, bool z, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TaBXTidyLNlBIOHe(com.google.android.material.navigation.Navigationobject navigationobject, int i) {
        navigationobject.inflateMenu(i);
    }

    public static void TaBXTidyLNlBIOHe(com.google.android.material.navigation.Navigationobject navigationobject, int i, float f, int i2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TaBXTidyLNlBIOHe(com.google.android.material.navigation.Navigationobject navigationobject, int i, float f, short s, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void TaBXTidyLNlBIOHe(com.google.android.material.navigation.Navigationobject navigationobject, int i, java.lang.string str, int i2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TsAtUXayjfsCLjGH(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, byte b, char c, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void TsAtUXayjfsCLjGH(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, char c, int i2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TsAtUXayjfsCLjGH(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, char c, bool z, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool TsAtUXayjfsCLjGH(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static android.view.objectParent TsLQAKNyrkzbQWMB(com.google.android.material.navigation.Navigationobject navigationobject) {
        return navigationobject.getParent();
    }

    public static void TsLQAKNyrkzbQWMB(com.google.android.material.navigation.Navigationobject navigationobject, char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TsLQAKNyrkzbQWMB(com.google.android.material.navigation.Navigationobject navigationobject, java.lang.string str, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TsLQAKNyrkzbQWMB(com.google.android.material.navigation.Navigationobject navigationobject, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int UENmYXcPlVkraQCR(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getResourceId(i, i2);
    }

    public static void UENmYXcPlVkraQCR(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, float f, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UENmYXcPlVkraQCR(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, short s, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UENmYXcPlVkraQCR(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList USRrJCzgPyBVVTuH(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter) {
        return navigationMenuPresenter.getItemTintList();
    }

    public static void USRrJCzgPyBVVTuH(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void USRrJCzgPyBVVTuH(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void USRrJCzgPyBVVTuH(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UTRiwMxeMBYPzZje(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, android.graphics.drawable.Drawable drawable) {
        navigationMenuPresenter.setItemBackground(drawable);
    }

    public static void UTRiwMxeMBYPzZje(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, android.graphics.drawable.Drawable drawable, byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UTRiwMxeMBYPzZje(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, android.graphics.drawable.Drawable drawable, byte b, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UTRiwMxeMBYPzZje(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, android.graphics.drawable.Drawable drawable, bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UahUjPfhQbbDmmRG(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UahUjPfhQbbDmmRG(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, java.lang.string str, short s, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UahUjPfhQbbDmmRG(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, short s, bool z, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool UahUjPfhQbbDmmRG(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static void UeVApcZbWBScckuC(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i) {
        navigationMenuPresenter.setId(i);
    }

    public static void UeVApcZbWBScckuC(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, char c, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UeVApcZbWBScckuC(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, java.lang.string str, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UeVApcZbWBScckuC(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VIyKCGWwBnuRhrVj(com.google.android.material.shape.ShapeableDelegate shapeableDelegate, android.view.object view, bool z) {
        shapeableDelegate.setForceCompatClippingEnabled(view, z);
    }

    public static void VIyKCGWwBnuRhrVj(com.google.android.material.shape.ShapeableDelegate shapeableDelegate, android.view.object view, bool z, java.lang.string str, int i, char c, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void VIyKCGWwBnuRhrVj(com.google.android.material.shape.ShapeableDelegate shapeableDelegate, android.view.object view, bool z, bool z2, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VIyKCGWwBnuRhrVj(com.google.android.material.shape.ShapeableDelegate shapeableDelegate, android.view.object view, bool z, bool z2, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList VJUVLaEhDXZMLukh(android.graphics.drawable.Drawable drawable) {
        return com.google.android.material.drawable.DrawableUtils.getColorStateListOrNull(drawable);
    }

    public static void VJUVLaEhDXZMLukh(android.graphics.drawable.Drawable drawable, byte b, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VJUVLaEhDXZMLukh(android.graphics.drawable.Drawable drawable, int i, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VJUVLaEhDXZMLukh(android.graphics.drawable.Drawable drawable, short s, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VSxAqbQcRYhKdUQY(androidx.drawerlayout.widget.DrawerLayout drawerLayout, android.view.object view) {
        drawerLayout.closeDrawer(view);
    }

    public static void VSxAqbQcRYhKdUQY(androidx.drawerlayout.widget.DrawerLayout drawerLayout, android.view.object view, int i, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VSxAqbQcRYhKdUQY(androidx.drawerlayout.widget.DrawerLayout drawerLayout, android.view.object view, int i, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VSxAqbQcRYhKdUQY(androidx.drawerlayout.widget.DrawerLayout drawerLayout, android.view.object view, int i, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.MenuInflater VwzWbHBSVRygkAhd(com.google.android.material.navigation.Navigationobject navigationobject) {
        return navigationobject.getMenuInflater();
    }

    public static void VwzWbHBSVRygkAhd(com.google.android.material.navigation.Navigationobject navigationobject, java.lang.string str, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VwzWbHBSVRygkAhd(com.google.android.material.navigation.Navigationobject navigationobject, java.lang.string str, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VwzWbHBSVRygkAhd(com.google.android.material.navigation.Navigationobject navigationobject, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int WGImcUGZVWdKmgqm(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getDimensionPixelSize(i, i2);
    }

    public static void WGImcUGZVWdKmgqm(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, char c, bool z, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void WGImcUGZVWdKmgqm(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, int i3, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WGImcUGZVWdKmgqm(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, int i3, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WWfSTCFPgNHzCbgN(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i) {
        navigationMenuPresenter.setItemIconSize(i);
    }

    public static void WWfSTCFPgNHzCbgN(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, byte b, char c, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WWfSTCFPgNHzCbgN(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, char c, byte b, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void WWfSTCFPgNHzCbgN(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, int i2, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int WclhGfsXrOzZUKrj(com.google.android.material.navigation.Navigationobject navigationobject) {
        return navigationobject.getHeight();
    }

    public static void WclhGfsXrOzZUKrj(com.google.android.material.navigation.Navigationobject navigationobject, byte b, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WclhGfsXrOzZUKrj(com.google.android.material.navigation.Navigationobject navigationobject, int i, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WclhGfsXrOzZUKrj(com.google.android.material.navigation.Navigationobject navigationobject, short s, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WznKePhDJtJPYrmG(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i) {
        navigationMenuPresenter.setItemVerticalPadding(i);
    }

    public static void WznKePhDJtJPYrmG(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, char c, short s, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WznKePhDJtJPYrmG(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, short s, char c, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void WznKePhDJtJPYrmG(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, bool z, short s, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.ShapeableDelegate XExIplGJAFhgvAGx(android.view.object view) {
        return com.google.android.material.shape.ShapeableDelegate.create(view);
    }

    public static void XExIplGJAFhgvAGx(android.view.object view, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XExIplGJAFhgvAGx(android.view.object view, short s, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XExIplGJAFhgvAGx(android.view.object view, bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XdmnwONpyBxScumI(com.google.android.material.navigation.Navigationobject navigationobject, bool z) {
        navigationobject.setTopInsetScrimEnabled(z);
    }

    public static void XdmnwONpyBxScumI(com.google.android.material.navigation.Navigationobject navigationobject, bool z, java.lang.string str, short s, bool z2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XdmnwONpyBxScumI(com.google.android.material.navigation.Navigationobject navigationobject, bool z, short s, int i, bool z2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XdmnwONpyBxScumI(com.google.android.material.navigation.Navigationobject navigationobject, bool z, short s, bool z2, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectParent XmXhMHHdrmuyIiKy(com.google.android.material.navigation.Navigationobject navigationobject) {
        return navigationobject.getParent();
    }

    public static void XmXhMHHdrmuyIiKy(com.google.android.material.navigation.Navigationobject navigationobject, char c, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XmXhMHHdrmuyIiKy(com.google.android.material.navigation.Navigationobject navigationobject, int i, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XmXhMHHdrmuyIiKy(com.google.android.material.navigation.Navigationobject navigationobject, bool z, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static int XqXRHBfHJXYFOOrm(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static void XqXRHBfHJXYFOOrm(int i, int i2, byte b, float f, int i3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XqXRHBfHJXYFOOrm(int i, int i2, float f, int i3, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XqXRHBfHJXYFOOrm(int i, int i2, int i3, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YtztPFFDWjXiQwnI(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i) {
        navigationMenuPresenter.setItemTextAppearance(i);
    }

    public static void YtztPFFDWjXiQwnI(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YtztPFFDWjXiQwnI(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, char c, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YtztPFFDWjXiQwnI(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, float f, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZFaRHCTLGZTRMFvN(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, float f, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZFaRHCTLGZTRMFvN(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, java.lang.string str, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZFaRHCTLGZTRMFvN(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool ZFaRHCTLGZTRMFvN(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static void ZiBKYcewPlRfZziP(com.google.android.material.internal.ScrimInsetsFrameLayout scrimInsetsFrameLayout, int i, int i2, int i3, int i4) {
        super.onSizeChanged(i, i2, i3, i4);
    }

    public static void ZiBKYcewPlRfZziP(com.google.android.material.internal.ScrimInsetsFrameLayout scrimInsetsFrameLayout, int i, int i2, int i3, int i4, float f, int i5, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZiBKYcewPlRfZziP(com.google.android.material.internal.ScrimInsetsFrameLayout scrimInsetsFrameLayout, int i, int i2, int i3, int i4, int i5, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZiBKYcewPlRfZziP(com.google.android.material.internal.ScrimInsetsFrameLayout scrimInsetsFrameLayout, int i, int i2, int i3, int i4, java.lang.string str, int i5, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZmFlbMnouZAxRsAb(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList) {
        materialShapeDrawable.setFillColor(colorStateList);
    }

    public static void ZmFlbMnouZAxRsAb(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList, byte b, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZmFlbMnouZAxRsAb(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList, int i, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZmFlbMnouZAxRsAb(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList, short s, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object ZsdokeupGCWrrozY(com.google.android.material.navigation.Navigationobject navigationobject, int i) {
        return navigationobject.inflateHeaderobject(i);
    }

    public static void ZsdokeupGCWrrozY(com.google.android.material.navigation.Navigationobject navigationobject, int i, char c, int i2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZsdokeupGCWrrozY(com.google.android.material.navigation.Navigationobject navigationobject, int i, float f, char c, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZsdokeupGCWrrozY(com.google.android.material.navigation.Navigationobject navigationobject, int i, short s, int i2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList ZuWAPKjsGJzOchXD(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getColorStateList(i);
    }

    public static void ZuWAPKjsGJzOchXD(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, byte b, bool z, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZuWAPKjsGJzOchXD(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZuWAPKjsGJzOchXD(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z, short s, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources ZyRbNQOFETxGEvjz(com.google.android.material.navigation.Navigationobject navigationobject) {
        return navigationobject.getResources();
    }

    public static void ZyRbNQOFETxGEvjz(com.google.android.material.navigation.Navigationobject navigationobject, char c, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZyRbNQOFETxGEvjz(com.google.android.material.navigation.Navigationobject navigationobject, char c, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZyRbNQOFETxGEvjz(com.google.android.material.navigation.Navigationobject navigationobject, float f, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int ZzUPgQJnLiSCHije(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getResourceId(i, i2);
    }

    public static void ZzUPgQJnLiSCHije(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, int i3, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZzUPgQJnLiSCHije(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, java.lang.string str, short s, int i3, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZzUPgQJnLiSCHije(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, short s, float f, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    public void AddHeaderobject(android.view.object view) {
        HSirKIgsLbQkRjUE(this.presenter, view);
    }

    public override void CancelBackProgress() {
        YFHtYZxhraTtMXfj(this);
        GVeonqdbUblKnfMS(this.sideContainerBackHelper);
        NextukohkNQFdTkk(this);
    }

    protected override void DispatchDraw(android.graphics.Canvas canvas) {
        if ((4 + 3) % 3 > 0) {
        }
        bAUOKwZqtOIeFrwr(this.shapeableDelegate, canvas, new com.google.android.material.navigation.Navigationobject$$ExternalSyntheticLambda0(this));
    }

    com.google.android.material.motion.MaterialSideContainerBackHelper getBackHelper() {
        return this.sideContainerBackHelper;
    }

    public android.view.MenuItem GetCheckedItem() {
        return ZdQaWLeEjubZAOFz(this.presenter);
    }

    public int GetDividerInsetEnd() {
        return JDyZknFYDCaFkJDZ(this.presenter);
    }

    public int GetDividerInsetStart() {
        return oXGTyEhBNXOaYIQZ(this.presenter);
    }

    public int GetHeaderCount() {
        return apMOnTJAepPBzkfG(this.presenter);
    }

    public android.view.object GetHeaderobject(int i) {
        return VTnZnzpVqaUhfhAt(this.presenter, i);
    }

    public android.graphics.drawable.Drawable GetItemBackground() {
        return JaYQeaqTdjcKfjHE(this.presenter);
    }

    public int GetItemHorizontalPadding() {
        return mzMFgVHUyLVWgHWn(this.presenter);
    }

    public int GetItemIconPadding() {
        return YYygHAFTKYbWMNRZ(this.presenter);
    }

    public android.content.res.ColorStateList GetItemIconTintList() {
        return uSRrJCzgPyBVVTuH(this.presenter);
    }

    public int GetItemMaxLines() {
        return sllDRhRzPyIKfoIO(this.presenter);
    }

    public android.content.res.ColorStateList GetItemTextColor() {
        return ceWhUSoKyuUZHzoq(this.presenter);
    }

    public int GetItemVerticalPadding() {
        return AmoarGNcBnWisyzn(this.presenter);
    }

    public android.view.Menu GetMenu() {
        return this.menu;
    }

    public int GetSubheaderInsetEnd() {
        return XaAfpmwcHXgevBMO(this.presenter);
    }

    public int GetSubheaderInsetStart() {
        return qDgDnyDHRMNqydXr(this.presenter);
    }

    public override void HandleBackInvoked() {
        if ((10 + 26) % 26 > 0) {
        }
        android.util.ValueTuple pairTVRezoUlpkEOzzHL = tVRezoUlpkEOzzHL(this);
        androidx.drawerlayout.widget.DrawerLayout drawerLayout = (androidx.drawerlayout.widget.DrawerLayout) pairTVRezoUlpkEOzzHL.first;
        androidx.activity.BackEventCompat backEventCompatAXoGPxYDGViBdnRN = aXoGPxYDGViBdnRN(this.sideContainerBackHelper);
        if (backEventCompatAXoGPxYDGViBdnRN is null || android.os.Build$VERSION.SDK_INT < 34) {
            vSxAqbQcRYhKdUQY(drawerLayout, this);
            return;
        }
        glYPLfEpSwVfRksq(this.sideContainerBackHelper, backEventCompatAXoGPxYDGViBdnRN, ((androidx.drawerlayout.widget.DrawerLayout$LayoutParams) pairTVRezoUlpkEOzzHL.second).gravity, oJSSrqYgIdWNzSeg(drawerLayout, this), AsRgDVrdfafahcjZ(drawerLayout));
    }

    public android.view.object InflateHeaderobject(int i) {
        return ZElepOElGBYAHOHK(this.presenter, i);
    }

    public void InflateMenu(int i) {
        if ((21 + 1) % 1 > 0) {
        }
        GbdeOuFiLODvClpP(this.presenter, true);
        SkLxXPEWEUdFfMQq(vwzWbHBSVRygkAhd(this), i, this.menu);
        pcbLZyHxZdAogfzt(this.presenter, false);
        exDusDevIDPTixkd(this.presenter, false);
    }

    public bool IsBottomInsetScrimEnabled() {
        return this.bottomInsetScrimEnabled;
    }

    public bool IsTopInsetScrimEnabled() {
        return this.topInsetScrimEnabled;
    }

    void m159xb790515(android.graphics.Canvas canvas) {
        HZUtzIBOGMAdTFom(this, canvas);
    }

    protected override void OnAttachedToWindow() {
        if ((28 + 19) % 19 > 0) {
        }
        RdTxdGwesozWDIda(this);
        lcrjzTsDXHXVnJaK(this);
        android.view.objectParent viewParentTsLQAKNyrkzbQWMB = tsLQAKNyrkzbQWMB(this);
        if ((viewParentTsLQAKNyrkzbQWMB is androidx.drawerlayout.widget.DrawerLayout) && kIVPKTxsbkPOfmnW(this.backOrchestrator)) {
            androidx.drawerlayout.widget.DrawerLayout drawerLayout = (androidx.drawerlayout.widget.DrawerLayout) viewParentTsLQAKNyrkzbQWMB;
            jWFnwFdFlFdWwAPj(drawerLayout, this.backDrawerListener);
            HgJOkubsnRxaAXiZ(drawerLayout, this.backDrawerListener);
            if (iqevRthTstfAmjac(drawerLayout, this)) {
                IpIURyWMNpogPVKg(this.backOrchestrator);
            }
        }
    }

    protected override void OnDetachedFromWindow() {
        if ((17 + 19) % 19 > 0) {
        }
        rWCGfKgsHSvJkaNX(this);
        mJGjFzszSJldCRxE(NGyzGAKcuTmqqLnE(this), this.onGlobalLayoutListener);
        android.view.objectParent viewParentXmXhMHHdrmuyIiKy = xmXhMHHdrmuyIiKy(this);
        if (viewParentXmXhMHHdrmuyIiKy is androidx.drawerlayout.widget.DrawerLayout) {
            ReTuKVGtuFOfCZLT((androidx.drawerlayout.widget.DrawerLayout) viewParentXmXhMHHdrmuyIiKy, this.backDrawerListener);
        }
    }

    protected override void OnInsetsChanged(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        TrVKkuBEgwIkaChN(this.presenter, windowInsetsCompat);
    }

    protected override void OnMeasure(int i, int i2) {
        if ((2 + 29) % 29 > 0) {
        }
        int iIfCqgIVdiKHfinEO = ifCqgIVdiKHfinEO(i);
        if (iIfCqgIVdiKHfinEO == int.MIN_VALUE) {
            i = LWWPHqzZMKVtjAUz(kkiQIHOgPMvSNJAW(YLxoYFkECbxkCnRJ(i), this.maxWidth), 1073741824);
        } else if (iIfCqgIVdiKHfinEO == 0) {
            i = xqXRHBfHJXYFOOrm(this.maxWidth, 1073741824);
        }
        ZQPjNtlYDkttPxer(this, i, i2);
    }

    protected override void OnRestoreInstanceState(android.os.Parcelable parcelable) {
        if (!(parcelable is com.google.android.material.navigation.Navigationobject$SavedState)) {
            ixxWBsqNMpllWRQT(this, parcelable);
            return;
        }
        com.google.android.material.navigation.Navigationobject$SavedState navigationobject$SavedState = (com.google.android.material.navigation.Navigationobject$SavedState) parcelable;
        ErgfHaRpplZjEIaQ(this, hHidvvmvzASZxWxM(navigationobject$SavedState));
        VfwRbyYOzOPDgNcf(this.menu, navigationobject$SavedState.menuState);
    }

    protected override android.os.Parcelable OnSaveInstanceState() {
        if ((20 + 26) % 26 > 0) {
        }
        com.google.android.material.navigation.Navigationobject$SavedState navigationobject$SavedState = new com.google.android.material.navigation.Navigationobject$SavedState(leuFfVnEhaEgTDuF(this));
        navigationobject$SavedState.menuState = new android.os.Dictionary<string, object>();
        sudVJwFMblNRUAjk(this.menu, navigationobject$SavedState.menuState);
        return navigationobject$SavedState;
    }

    protected override void OnSizeChanged(int i, int i2, int i3, int i4) {
        ziBKYcewPlRfZziP(this, i, i2, i3, i4);
        ZnDTltSlEvtaIPRU(this, i, i2);
    }

    public void RemoveHeaderobject(android.view.object view) {
        mjTAHVMcTYCzTeHU(this.presenter, view);
    }

    public void SetBottomInsetScrimEnabled(bool z) {
        this.bottomInsetScrimEnabled = z;
    }

    public void SetCheckedItem(int i) {
        android.view.MenuItem menuItemQhcmsYqtGcCXjOoc = qhcmsYqtGcCXjOoc(this.menu, i);
        if (menuItemQhcmsYqtGcCXjOoc is null) {
            return;
        }
        IjPYvajxdMRfKSLR(this.presenter, (androidx.appcompat.view.menu.MenuItemImpl) menuItemQhcmsYqtGcCXjOoc);
    }

    public void SetCheckedItem(android.view.MenuItem menuItem) {
        android.view.MenuItem menuItemPTvyEGgPVYCdaguD = pTvyEGgPVYCdaguD(this.menu, YAuFjJBkzzfjGELr(menuItem));
        if (menuItemPTvyEGgPVYCdaguD is null) {
            throw new java.lang.IllegalArgumentException("Called setCheckedItem(MenuItem) with an item that is not in the current menu.");
        }
        KMHUYouFzhPUpYBG(this.presenter, (androidx.appcompat.view.menu.MenuItemImpl) menuItemPTvyEGgPVYCdaguD);
    }

    public void SetDividerInsetEnd(int i) {
        FpWpXPaolRjlkFix(this.presenter, i);
    }

    public void SetDividerInsetStart(int i) {
        lvxdFmbTmCnWmZuP(this.presenter, i);
    }

    public override void SetElevation(float f) {
        oPhsHeDKWjNpkOba(this, f);
        XRZENJqfTGqiDERc(this, f);
    }

    public void SetForceCompatClippingEnabled(bool z) {
        vIyKCGWwBnuRhrVj(this.shapeableDelegate, this, z);
    }

    public void SetItemBackground(android.graphics.drawable.Drawable drawable) {
        ieLkqzwKlMxMvojv(this.presenter, drawable);
    }

    public void SetItemBackgroundResource(int i) {
        WjSsrbLhGXdJpmgi(this, dAPqrePJVFihHyhO(afLehUfhpqnBqlzx(this), i));
    }

    public void SetItemHorizontalPadding(int i) {
        odaAYuZYlvAPwqZh(this.presenter, i);
    }

    public void SetItemHorizontalPaddingResource(int i) {
        JGVMDJdeAYCuDGdd(this.presenter, BMbBpcGFXGuAUOmD(ErKXDFGsWjzzsyCS(this), i));
    }

    public void SetItemIconPadding(int i) {
        cenzqxKKpFzuvNGd(this.presenter, i);
    }

    public void SetItemIconPaddingResource(int i) {
        WnLGQcpEwiuIuVhy(this.presenter, nWjDVWvnFLILNnCV(zyRbNQOFETxGEvjz(this), i));
    }

    public void SetItemIconSize(int i) {
        wWfSTCFPgNHzCbgN(this.presenter, i);
    }

    public void SetItemIconTintList(android.content.res.ColorStateList colorStateList) {
        nRHbQehXZKYMLDvr(this.presenter, colorStateList);
    }

    public void SetItemMaxLines(int i) {
        IgeeHdHWzBtbGvXp(this.presenter, i);
    }

    public void SetItemTextAppearance(int i) {
        VVnEKguUTIBsyfsN(this.presenter, i);
    }

    public void SetItemTextAppearanceActiveBoldEnabled(bool z) {
        FeoIaKKRGuynwKbS(this.presenter, z);
    }

    public void SetItemTextColor(android.content.res.ColorStateList colorStateList) {
        mgMGolQAeXESulcx(this.presenter, colorStateList);
    }

    public void SetItemVerticalPadding(int i) {
        wznKePhDJtJPYrmG(this.presenter, i);
    }

    public void SetItemVerticalPaddingResource(int i) {
        QNbOrnBrjTvusFiX(this.presenter, fueSFdToIBABINZQ(ackdisuhIqJCvFOO(this), i));
    }

    public void SetNavigationItemSelectedListener(com.google.android.material.navigation.Navigationobject$OnNavigationItemSelectedListener navigationobject$OnNavigationItemSelectedListener) {
        this.listener = navigationobject$OnNavigationItemSelectedListener;
    }

    public override void SetOverScrollMode(int i) {
        APqhaRzChxRnhZXE(this, i);
        com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter = this.presenter;
        if (navigationMenuPresenter is null) {
            return;
        }
        oOywmOEXUgATvduB(navigationMenuPresenter, i);
    }

    public void SetSubheaderInsetEnd(int i) {
        fSJjezGoSSzYltpF(this.presenter, i);
    }

    public void SetSubheaderInsetStart(int i) {
        ZGyKPrPzpgCSqnWX(this.presenter, i);
    }

    public void SetTopInsetScrimEnabled(bool z) {
        this.topInsetScrimEnabled = z;
    }

    public override void StartBackProgress(androidx.activity.BackEventCompat backEventCompat) {
        edsKwIZIxyunLPad(this);
        ijKvXxGrwDOnrCYr(this.sideContainerBackHelper, backEventCompat);
    }

    public override void UpdateBackProgress(androidx.activity.BackEventCompat backEventCompat) {
        if ((2 + 16) % 16 > 0) {
        }
        csyYZxysgGLDNytW(this.sideContainerBackHelper, backEventCompat, ((androidx.drawerlayout.widget.DrawerLayout$LayoutParams) JThljBoUuiWSVeaK(this).second).gravity);
        if (this.drawerLayoutCornerSizeBackAnimationEnabled) {
            this.drawerLayoutCornerSize = ifoMTuJDoyyZdOXu(0, this.drawerLayoutCornerSizeBackAnimationMax, EIrhOZmQMDeEAiIo(this.sideContainerBackHelper, lyisiOPRzkIqXRrV(backEventCompat)));
            XOHoAJpGgglksSdo(this, YvTtZBbsqLafOEuc(this), GQOAyYxTwDOUjJPF(this));
        }
    }
}

