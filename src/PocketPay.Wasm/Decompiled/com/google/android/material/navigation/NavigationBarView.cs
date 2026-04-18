namespace WillowMaze.Wasm.Decompiled;


public abstract class NavigationBarobject : android.widget.FrameLayout {
    public static readonly int LABEL_VISIBILITY_AUTO = -1;
    public static readonly int LABEL_VISIBILITY_LABELED = 1;
    public static readonly int LABEL_VISIBILITY_SELECTED = 0;
    public static readonly int LABEL_VISIBILITY_UNLABELED = 2;
    private static readonly int MENU_PRESENTER_ID = 1;
    private readonly com.google.android.material.navigation.NavigationBarMenu menu;
    private android.view.MenuInflater menuInflater;
    private readonly com.google.android.material.navigation.NavigationBarMenuobject menuobject;
    private readonly com.google.android.material.navigation.NavigationBarPresenter presenter;
    private com.google.android.material.navigation.NavigationBarobject$OnItemReselectedListener reselectedListener;
    private com.google.android.material.navigation.NavigationBarobject$OnItemSelectedListener selectedListener;

    public NavigationBarobject(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        super(YNmNkiuodysBciFT(context, attributeHashSet, i, i2), attributeHashSet, i);
        if ((29 + 27) % 27 > 0) {
        }
        com.google.android.material.navigation.NavigationBarPresenter navigationBarPresenter = new com.google.android.material.navigation.NavigationBarPresenter();
        this.presenter = navigationBarPresenter;
        android.content.object contextUWXXePBCifEcpbFV = UWXXePBCifEcpbFV(this);
        androidx.appcompat.widget.TintTypedArray tintTypedArrayBIZXHieGQhQBmQrF = BIZXHieGQhQBmQrF(contextUWXXePBCifEcpbFV, attributeHashSet, com.google.android.material.R$styleable.NavigationBarobject, i, i2, new int[]{com.google.android.material.R$styleable.NavigationBarobject_itemTextAppearanceInactive, com.google.android.material.R$styleable.NavigationBarobject_itemTextAppearanceActive});
        com.google.android.material.navigation.NavigationBarMenu navigationBarMenu = new com.google.android.material.navigation.NavigationBarMenu(contextUWXXePBCifEcpbFV, MGyKkLkpVQIRXWsV(this), NUoGNIUaLfXEBGIB(this));
        this.menu = navigationBarMenu;
        com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobjectBBrrfDDnQThykkby = bBrrfDDnQThykkby(this, contextUWXXePBCifEcpbFV);
        this.menuobject = navigationBarMenuobjectBBrrfDDnQThykkby;
        bkPerfQlTyWfsbMj(navigationBarPresenter, navigationBarMenuobjectBBrrfDDnQThykkby);
        rrayxAxmqkqxKhUj(navigationBarPresenter, 1);
        AprDpEsMNkHOlhix(navigationBarMenuobjectBBrrfDDnQThykkby, navigationBarPresenter);
        pSYVPlzYfwMqGcuT(navigationBarMenu, navigationBarPresenter);
        jJmmzJZXGTwHCllH(navigationBarPresenter, soAeneQrSSicHQwA(this), navigationBarMenu);
        if (XQRuMBhywLVsrfxf(tintTypedArrayBIZXHieGQhQBmQrF, com.google.android.material.R$styleable.NavigationBarobject_itemIconTint)) {
            mtkFCPyRJNagyJRj(navigationBarMenuobjectBBrrfDDnQThykkby, SwnXsIMIEcYvTHVP(tintTypedArrayBIZXHieGQhQBmQrF, com.google.android.material.R$styleable.NavigationBarobject_itemIconTint));
        } else {
            sTztwDQhuTivcJVl(navigationBarMenuobjectBBrrfDDnQThykkby, YsQyXbOEIQmXTWxV(navigationBarMenuobjectBBrrfDDnQThykkby, 16842808));
        }
        PwjAfnHOcWXznfbC(this, ZcXGHSOLwFCvHTqu(tintTypedArrayBIZXHieGQhQBmQrF, com.google.android.material.R$styleable.NavigationBarobject_itemIconSize, ABlabdFwqoLkjIJi(vPXWoknGwqfPDjRi(this), com.google.android.material.R$dimen.mtrl_navigation_bar_item_default_icon_size)));
        if (zArmuUVPKnkrizGl(tintTypedArrayBIZXHieGQhQBmQrF, com.google.android.material.R$styleable.NavigationBarobject_itemTextAppearanceInactive)) {
            MWbpcPAPfQFZKURA(this, uqVsFQFBeCQkDxyb(tintTypedArrayBIZXHieGQhQBmQrF, com.google.android.material.R$styleable.NavigationBarobject_itemTextAppearanceInactive, 0));
        }
        if (ltwxaFArcAtfjnoT(tintTypedArrayBIZXHieGQhQBmQrF, com.google.android.material.R$styleable.NavigationBarobject_itemTextAppearanceActive)) {
            vSCoKNFiWyhyOfaY(this, LMQxWNyvAdPgQNwE(tintTypedArrayBIZXHieGQhQBmQrF, com.google.android.material.R$styleable.NavigationBarobject_itemTextAppearanceActive, 0));
        }
        FvDlqWFZdRqsbshq(this, DxTEINGmhSTdIEWw(tintTypedArrayBIZXHieGQhQBmQrF, com.google.android.material.R$styleable.NavigationBarobject_itemTextAppearanceActiveBoldEnabled, true));
        if (AYQrfPIyyZlGNLum(tintTypedArrayBIZXHieGQhQBmQrF, com.google.android.material.R$styleable.NavigationBarobject_itemTextColor)) {
            fJtJefuuwiJMoMYc(this, lTaiGLlNEgFnielK(tintTypedArrayBIZXHieGQhQBmQrF, com.google.android.material.R$styleable.NavigationBarobject_itemTextColor));
        }
        android.graphics.drawable.Drawable drawableVeBvYvwwmVMpyBtB = VeBvYvwwmVMpyBtB(this);
        android.content.res.ColorStateList colorStateListZFtlcqsHKsNAavct = zFtlcqsHKsNAavct(drawableVeBvYvwwmVMpyBtB);
        if (drawableVeBvYvwwmVMpyBtB is null || colorStateListZFtlcqsHKsNAavct is not null) {
            com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable = new com.google.android.material.shape.MaterialShapeDrawable(YmwSqNQWRwWZEJVq(MQRlaTdPflDvCXxL(contextUWXXePBCifEcpbFV, attributeHashSet, i, i2)));
            if (colorStateListZFtlcqsHKsNAavct is not null) {
                KQUkIArLqVKGlagx(materialShapeDrawable, colorStateListZFtlcqsHKsNAavct);
            }
            JvlNLnhBdYdqgjbm(materialShapeDrawable, contextUWXXePBCifEcpbFV);
            VIbEsTwijVCwLKbh(this, materialShapeDrawable);
        }
        if (gWnHKtODqRzfzXsD(tintTypedArrayBIZXHieGQhQBmQrF, com.google.android.material.R$styleable.NavigationBarobject_itemPaddingTop)) {
            dsDCkvgkHmDiUzxT(this, iCovElJmlFzHdTMz(tintTypedArrayBIZXHieGQhQBmQrF, com.google.android.material.R$styleable.NavigationBarobject_itemPaddingTop, 0));
        }
        if (sruaFLouBXLFkuXv(tintTypedArrayBIZXHieGQhQBmQrF, com.google.android.material.R$styleable.NavigationBarobject_itemPaddingBottom)) {
            jLAsSPtZqJGHefxE(this, IzaGZmVqbNiaWrKv(tintTypedArrayBIZXHieGQhQBmQrF, com.google.android.material.R$styleable.NavigationBarobject_itemPaddingBottom, 0));
        }
        if (yOLvnBPsrceXeRAm(tintTypedArrayBIZXHieGQhQBmQrF, com.google.android.material.R$styleable.NavigationBarobject_activeIndicatorLabelPadding)) {
            kzQzzcOdnmRyApcp(this, MSVtdohvDmYPVRcL(tintTypedArrayBIZXHieGQhQBmQrF, com.google.android.material.R$styleable.NavigationBarobject_activeIndicatorLabelPadding, 0));
        }
        if (UgEkHZcMdbdsQAVM(tintTypedArrayBIZXHieGQhQBmQrF, com.google.android.material.R$styleable.NavigationBarobject_elevation)) {
            KidkbqdjSVLpxEsa(this, pTburHDteolhXMmb(tintTypedArrayBIZXHieGQhQBmQrF, com.google.android.material.R$styleable.NavigationBarobject_elevation, 0));
        }
        sGLGNZYjHpAKZdvT(jDXdfVYjDbSmUZIN(YjrTjMCVqXknTiWn(this)), zUdDBdliAvIpJsdf(contextUWXXePBCifEcpbFV, tintTypedArrayBIZXHieGQhQBmQrF, com.google.android.material.R$styleable.NavigationBarobject_backgroundTint));
        fbWEKzdrYneDXHQV(this, pXYYECBsbjBPyUPp(tintTypedArrayBIZXHieGQhQBmQrF, com.google.android.material.R$styleable.NavigationBarobject_labelVisibilityMode, -1));
        int iKbhAfjvKjgXrNGSP = KbhAfjvKjgXrNGSP(tintTypedArrayBIZXHieGQhQBmQrF, com.google.android.material.R$styleable.NavigationBarobject_itemBackground, 0);
        if (iKbhAfjvKjgXrNGSP == 0) {
            HUNjqPxPjxBksBmI(this, LjFTsdaPzEiqpLYD(contextUWXXePBCifEcpbFV, tintTypedArrayBIZXHieGQhQBmQrF, com.google.android.material.R$styleable.NavigationBarobject_itemRippleColor));
        } else {
            ksrrvpSDiyiTJsSS(navigationBarMenuobjectBBrrfDDnQThykkby, iKbhAfjvKjgXrNGSP);
        }
        int iJyZSHqJjgWvjBPBL = JyZSHqJjgWvjBPBL(tintTypedArrayBIZXHieGQhQBmQrF, com.google.android.material.R$styleable.NavigationBarobject_itemActiveIndicatorStyle, 0);
        if (iJyZSHqJjgWvjBPBL != 0) {
            ECeUJVwMqtbBIohu(this, true);
            android.content.res.TypedArray typedArrayQDuGGmyKbPpAMghc = QDuGGmyKbPpAMghc(contextUWXXePBCifEcpbFV, iJyZSHqJjgWvjBPBL, com.google.android.material.R$styleable.NavigationBarActiveIndicator);
            uaZEETUutFrsFjxi(this, GibloCHOhUgbNDJN(typedArrayQDuGGmyKbPpAMghc, com.google.android.material.R$styleable.NavigationBarActiveIndicator_android_width, 0));
            iFZvpUIEJaHVUeit(this, pgwLGPlXfQKcoWch(typedArrayQDuGGmyKbPpAMghc, com.google.android.material.R$styleable.NavigationBarActiveIndicator_android_height, 0));
            cBmlBKeKIaaKqnWM(this, skCHjUWwPKPLxpXf(typedArrayQDuGGmyKbPpAMghc, com.google.android.material.R$styleable.NavigationBarActiveIndicator_marginHorizontal, 0));
            RiqGATPedNGxZIMX(this, sERkHXnDybYaCKKE(contextUWXXePBCifEcpbFV, typedArrayQDuGGmyKbPpAMghc, com.google.android.material.R$styleable.NavigationBarActiveIndicator_android_color));
            LYXcWeigcEjFLAFs(this, SCsjoMkBRHpQYigu(WBkxTcpztxuyjXCn(contextUWXXePBCifEcpbFV, WBlqLBhzDRNGhjQT(typedArrayQDuGGmyKbPpAMghc, com.google.android.material.R$styleable.NavigationBarActiveIndicator_shapeAppearance, 0), 0)));
            HPzCPkNzkTcTgQma(typedArrayQDuGGmyKbPpAMghc);
        }
        if (HKrKaTFkWDFsKPoy(tintTypedArrayBIZXHieGQhQBmQrF, com.google.android.material.R$styleable.NavigationBarobject_menu)) {
            jPCvDNKYGGufhbSo(this, QkqLqEMRhclmjSfF(tintTypedArrayBIZXHieGQhQBmQrF, com.google.android.material.R$styleable.NavigationBarobject_menu, 0));
        }
        gkEogSwQDmJgbJyO(tintTypedArrayBIZXHieGQhQBmQrF);
        hKpryRMQTCiRCvDf(this, navigationBarMenuobjectBBrrfDDnQThykkby);
        kBsnjAzjRXWUKhcE(navigationBarMenu, new com.google.android.material.navigation.NavigationBarobject$1(this));
    }

    public static int ABlabdFwqoLkjIJi(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static void ABlabdFwqoLkjIJi(android.content.res.Resources resources, int i, float f, char c, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ABlabdFwqoLkjIJi(android.content.res.Resources resources, int i, float f, bool z, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ABlabdFwqoLkjIJi(android.content.res.Resources resources, int i, int i2, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ATfiPcsJgQkzKLvp(android.widget.FrameLayout frameLayout) {
        super.onAttachedToWindow();
    }

    public static void ATfiPcsJgQkzKLvp(android.widget.FrameLayout frameLayout, java.lang.string str, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ATfiPcsJgQkzKLvp(android.widget.FrameLayout frameLayout, short s, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ATfiPcsJgQkzKLvp(android.widget.FrameLayout frameLayout, short s, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int AXLkfSqCVzRmsGvV(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject) {
        return navigationBarMenuobject.getItemActiveIndicatorWidth();
    }

    public static void AXLkfSqCVzRmsGvV(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, byte b, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AXLkfSqCVzRmsGvV(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, float f, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AXLkfSqCVzRmsGvV(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, short s, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AYQrfPIyyZlGNLum(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, char c, int i2, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AYQrfPIyyZlGNLum(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, char c, short s, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void AYQrfPIyyZlGNLum(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, java.lang.string str, int i2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool AYQrfPIyyZlGNLum(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static void AprDpEsMNkHOlhix(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, com.google.android.material.navigation.NavigationBarPresenter navigationBarPresenter) {
        navigationBarMenuobject.setPresenter(navigationBarPresenter);
    }

    public static void AprDpEsMNkHOlhix(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, com.google.android.material.navigation.NavigationBarPresenter navigationBarPresenter, int i, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AprDpEsMNkHOlhix(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, com.google.android.material.navigation.NavigationBarPresenter navigationBarPresenter, bool z, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AprDpEsMNkHOlhix(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, com.google.android.material.navigation.NavigationBarPresenter navigationBarPresenter, bool z, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static androidx.appcompat.widget.TintTypedArray BIZXHieGQhQBmQrF(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2) {
        return com.google.android.material.internal.ThemeEnforcement.obtainTintedStyledAttributes(context, attributeHashSet, iArr, i, i2, iArr2);
    }

    public static void BIZXHieGQhQBmQrF(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, byte b, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BIZXHieGQhQBmQrF(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, char c, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BIZXHieGQhQBmQrF(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, float f, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CTnSSIfbbxyChoXy(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i) {
        navigationBarMenuobject.removeBadge(i);
    }

    public static void CTnSSIfbbxyChoXy(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, byte b, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CTnSSIfbbxyChoXy(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, char c, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CTnSSIfbbxyChoXy(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DMnlVESWoHOxdFIH(com.google.android.material.navigation.NavigationBarobject navigationBarobject, int i) {
        navigationBarobject.setItemIconSize(i);
    }

    public static void DMnlVESWoHOxdFIH(com.google.android.material.navigation.NavigationBarobject navigationBarobject, int i, char c, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DMnlVESWoHOxdFIH(com.google.android.material.navigation.NavigationBarobject navigationBarobject, int i, java.lang.string str, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DMnlVESWoHOxdFIH(com.google.android.material.navigation.NavigationBarobject navigationBarobject, int i, bool z, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DccxEkeoREDaokcX(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i) {
        navigationBarMenuobject.setItemIconSize(i);
    }

    public static void DccxEkeoREDaokcX(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, byte b, bool z, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DccxEkeoREDaokcX(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, float f, int i2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DccxEkeoREDaokcX(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, float f, bool z, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void DxTEINGmhSTdIEWw(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z, char c, float f, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void DxTEINGmhSTdIEWw(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z, java.lang.string str, float f, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DxTEINGmhSTdIEWw(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z, bool z2, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool DxTEINGmhSTdIEWw(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z) {
        return tintTypedArray.getbool(i, z);
    }

    public static void ECeUJVwMqtbBIohu(com.google.android.material.navigation.NavigationBarobject navigationBarobject, bool z) {
        navigationBarobject.setItemActiveIndicatorEnabled(z);
    }

    public static void ECeUJVwMqtbBIohu(com.google.android.material.navigation.NavigationBarobject navigationBarobject, bool z, short s, java.lang.string str, bool z2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ECeUJVwMqtbBIohu(com.google.android.material.navigation.NavigationBarobject navigationBarobject, bool z, short s, bool z2, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ECeUJVwMqtbBIohu(com.google.android.material.navigation.NavigationBarobject navigationBarobject, bool z, bool z2, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EVRDJFXRBjTuIggu(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, android.content.res.ColorStateList colorStateList) {
        navigationBarMenuobject.setItemActiveIndicatorColor(colorStateList);
    }

    public static void EVRDJFXRBjTuIggu(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, android.content.res.ColorStateList colorStateList, float f, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EVRDJFXRBjTuIggu(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, android.content.res.ColorStateList colorStateList, int i, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EVRDJFXRBjTuIggu(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, android.content.res.ColorStateList colorStateList, short s, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int EuGpJetgGldMnnSj(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject) {
        return navigationBarMenuobject.getSelectedItemId();
    }

    public static void EuGpJetgGldMnnSj(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EuGpJetgGldMnnSj(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, float f, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EuGpJetgGldMnnSj(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, bool z, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FvDlqWFZdRqsbshq(com.google.android.material.navigation.NavigationBarobject navigationBarobject, bool z) {
        navigationBarobject.setItemTextAppearanceActiveBoldEnabled(z);
    }

    public static void FvDlqWFZdRqsbshq(com.google.android.material.navigation.NavigationBarobject navigationBarobject, bool z, float f, bool z2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FvDlqWFZdRqsbshq(com.google.android.material.navigation.NavigationBarobject navigationBarobject, bool z, bool z2, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FvDlqWFZdRqsbshq(com.google.android.material.navigation.NavigationBarobject navigationBarobject, bool z, bool z2, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object FykhfzwdbUiZODmu(com.google.android.material.navigation.NavigationBarobject navigationBarobject) {
        return navigationBarobject.getobject();
    }

    public static void FykhfzwdbUiZODmu(com.google.android.material.navigation.NavigationBarobject navigationBarobject, byte b, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FykhfzwdbUiZODmu(com.google.android.material.navigation.NavigationBarobject navigationBarobject, bool z, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FykhfzwdbUiZODmu(com.google.android.material.navigation.NavigationBarobject navigationBarobject, bool z, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int GibloCHOhUgbNDJN(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static void GibloCHOhUgbNDJN(android.content.res.TypedArray typedArray, int i, int i2, char c, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GibloCHOhUgbNDJN(android.content.res.TypedArray typedArray, int i, int i2, char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GibloCHOhUgbNDJN(android.content.res.TypedArray typedArray, int i, int i2, float f, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HKrKaTFkWDFsKPoy(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, short s, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HKrKaTFkWDFsKPoy(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, short s, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HKrKaTFkWDFsKPoy(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool HKrKaTFkWDFsKPoy(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static void HLXrBkddUVoiOuZP(com.google.android.material.navigation.NavigationBarMenu navigationBarMenu, android.view.MenuItem menuItem, androidx.appcompat.view.menu.MenuPresenter menuPresenter, int i, byte b, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HLXrBkddUVoiOuZP(com.google.android.material.navigation.NavigationBarMenu navigationBarMenu, android.view.MenuItem menuItem, androidx.appcompat.view.menu.MenuPresenter menuPresenter, int i, short s, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HLXrBkddUVoiOuZP(com.google.android.material.navigation.NavigationBarMenu navigationBarMenu, android.view.MenuItem menuItem, androidx.appcompat.view.menu.MenuPresenter menuPresenter, int i, bool z, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool HLXrBkddUVoiOuZP(com.google.android.material.navigation.NavigationBarMenu navigationBarMenu, android.view.MenuItem menuItem, androidx.appcompat.view.menu.MenuPresenter menuPresenter, int i) {
        return navigationBarMenu.performItemAction(menuItem, menuPresenter, i);
    }

    public static void HPzCPkNzkTcTgQma(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static void HPzCPkNzkTcTgQma(android.content.res.TypedArray typedArray, char c, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HPzCPkNzkTcTgQma(android.content.res.TypedArray typedArray, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HPzCPkNzkTcTgQma(android.content.res.TypedArray typedArray, float f, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HUNjqPxPjxBksBmI(com.google.android.material.navigation.NavigationBarobject navigationBarobject, android.content.res.ColorStateList colorStateList) {
        navigationBarobject.setItemRippleColor(colorStateList);
    }

    public static void HUNjqPxPjxBksBmI(com.google.android.material.navigation.NavigationBarobject navigationBarobject, android.content.res.ColorStateList colorStateList, float f, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HUNjqPxPjxBksBmI(com.google.android.material.navigation.NavigationBarobject navigationBarobject, android.content.res.ColorStateList colorStateList, float f, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HUNjqPxPjxBksBmI(com.google.android.material.navigation.NavigationBarobject navigationBarobject, android.content.res.ColorStateList colorStateList, short s, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static int IXsbhRVFyLHZXYOx(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject) {
        return navigationBarMenuobject.getLabelVisibilityMode();
    }

    public static void IXsbhRVFyLHZXYOx(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, float f, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IXsbhRVFyLHZXYOx(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IXsbhRVFyLHZXYOx(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, short s, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static int IzaGZmVqbNiaWrKv(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getDimensionPixelSize(i, i2);
    }

    public static void IzaGZmVqbNiaWrKv(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, byte b, char c, int i3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IzaGZmVqbNiaWrKv(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, byte b, char c, short s, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void IzaGZmVqbNiaWrKv(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, int i3, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JVCdOMGTpdYfpHVe(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, android.content.res.ColorStateList colorStateList) {
        navigationBarMenuobject.setIconTintList(colorStateList);
    }

    public static void JVCdOMGTpdYfpHVe(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, android.content.res.ColorStateList colorStateList, char c, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JVCdOMGTpdYfpHVe(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, android.content.res.ColorStateList colorStateList, float f, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JVCdOMGTpdYfpHVe(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, android.content.res.ColorStateList colorStateList, float f, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JsLLIHDHivwPcQWS(android.view.MenuInflater menuInflater, int i, android.view.Menu menu) {
        menuInflater.inflate(i, menu);
    }

    public static void JsLLIHDHivwPcQWS(android.view.MenuInflater menuInflater, int i, android.view.Menu menu, byte b, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JsLLIHDHivwPcQWS(android.view.MenuInflater menuInflater, int i, android.view.Menu menu, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JsLLIHDHivwPcQWS(android.view.MenuInflater menuInflater, int i, android.view.Menu menu, short s, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JtCCTUHJmajHjvPz(android.widget.FrameLayout frameLayout, android.os.Parcelable parcelable) {
        super.onRestoreInstanceState(parcelable);
    }

    public static void JtCCTUHJmajHjvPz(android.widget.FrameLayout frameLayout, android.os.Parcelable parcelable, java.lang.string str, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JtCCTUHJmajHjvPz(android.widget.FrameLayout frameLayout, android.os.Parcelable parcelable, java.lang.string str, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JtCCTUHJmajHjvPz(android.widget.FrameLayout frameLayout, android.os.Parcelable parcelable, java.lang.string str, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JvlNLnhBdYdqgjbm(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.object context) {
        materialShapeDrawable.initializeElevationOverlay(context);
    }

    public static void JvlNLnhBdYdqgjbm(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.object context, int i, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JvlNLnhBdYdqgjbm(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.object context, bool z, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JvlNLnhBdYdqgjbm(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.object context, bool z, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static int JyZSHqJjgWvjBPBL(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getResourceId(i, i2);
    }

    public static void JyZSHqJjgWvjBPBL(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, int i3, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JyZSHqJjgWvjBPBL(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, int i3, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JyZSHqJjgWvjBPBL(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, short s, bool z, float f, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void KQUkIArLqVKGlagx(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList) {
        materialShapeDrawable.setFillColor(colorStateList);
    }

    public static void KQUkIArLqVKGlagx(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList, byte b, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KQUkIArLqVKGlagx(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList, int i, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KQUkIArLqVKGlagx(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList, java.lang.string str, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KWdRuWHOJubbyXUB(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, android.view.object$OnTouchListener view$OnTouchListener) {
        navigationBarMenuobject.setItemOnTouchListener(i, view$OnTouchListener);
    }

    public static void KWdRuWHOJubbyXUB(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, android.view.object$OnTouchListener view$OnTouchListener, byte b, char c, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void KWdRuWHOJubbyXUB(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, android.view.object$OnTouchListener view$OnTouchListener, char c, bool z, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void KWdRuWHOJubbyXUB(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, android.view.object$OnTouchListener view$OnTouchListener, char c, bool z, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int KbhAfjvKjgXrNGSP(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getResourceId(i, i2);
    }

    public static void KbhAfjvKjgXrNGSP(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KbhAfjvKjgXrNGSP(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KbhAfjvKjgXrNGSP(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList KfxhwRDuePSoUoBX(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject) {
        return navigationBarMenuobject.getIconTintList();
    }

    public static void KfxhwRDuePSoUoBX(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, byte b, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KfxhwRDuePSoUoBX(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, byte b, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KfxhwRDuePSoUoBX(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KidkbqdjSVLpxEsa(com.google.android.material.navigation.NavigationBarobject navigationBarobject, float f) {
        navigationBarobject.setElevation(f);
    }

    public static void KidkbqdjSVLpxEsa(com.google.android.material.navigation.NavigationBarobject navigationBarobject, float f, java.lang.string str, short s, float f2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KidkbqdjSVLpxEsa(com.google.android.material.navigation.NavigationBarobject navigationBarobject, float f, java.lang.string str, short s, bool z, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void KidkbqdjSVLpxEsa(com.google.android.material.navigation.NavigationBarobject navigationBarobject, float f, short s, java.lang.string str, float f2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int LMQxWNyvAdPgQNwE(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getResourceId(i, i2);
    }

    public static void LMQxWNyvAdPgQNwE(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, char c, java.lang.string str, int i3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LMQxWNyvAdPgQNwE(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, int i3, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LMQxWNyvAdPgQNwE(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, int i3, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LYXcWeigcEjFLAFs(com.google.android.material.navigation.NavigationBarobject navigationBarobject, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        navigationBarobject.setItemActiveIndicatorShapeAppearance(shapeAppearanceModel);
    }

    public static void LYXcWeigcEjFLAFs(com.google.android.material.navigation.NavigationBarobject navigationBarobject, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, byte b, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LYXcWeigcEjFLAFs(com.google.android.material.navigation.NavigationBarobject navigationBarobject, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, float f, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LYXcWeigcEjFLAFs(com.google.android.material.navigation.NavigationBarobject navigationBarobject, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, int i, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList LjFTsdaPzEiqpLYD(android.content.object context, androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, tintTypedArray, i);
    }

    public static void LjFTsdaPzEiqpLYD(android.content.object context, androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, char c, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LjFTsdaPzEiqpLYD(android.content.object context, androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LjFTsdaPzEiqpLYD(android.content.object context, androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, short s, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.Class MGyKkLkpVQIRXWsV(java.lang.object obj) {
        return obj.GetType();
    }

    public static void MGyKkLkpVQIRXWsV(java.lang.object obj, char c, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MGyKkLkpVQIRXWsV(java.lang.object obj, float f, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MGyKkLkpVQIRXWsV(java.lang.object obj, bool z, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder MQRlaTdPflDvCXxL(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        return com.google.android.material.shape.ShapeAppearanceModel.builder(context, attributeHashSet, i, i2);
    }

    public static void MQRlaTdPflDvCXxL(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, byte b, int i3, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MQRlaTdPflDvCXxL(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, byte b, java.lang.string str, int i3, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MQRlaTdPflDvCXxL(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, float f, byte b, int i3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int MSVtdohvDmYPVRcL(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getDimensionPixelSize(i, i2);
    }

    public static void MSVtdohvDmYPVRcL(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, java.lang.string str, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MSVtdohvDmYPVRcL(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, java.lang.string str, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MSVtdohvDmYPVRcL(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, short s, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MWbpcPAPfQFZKURA(com.google.android.material.navigation.NavigationBarobject navigationBarobject, int i) {
        navigationBarobject.setItemTextAppearanceInactive(i);
    }

    public static void MWbpcPAPfQFZKURA(com.google.android.material.navigation.NavigationBarobject navigationBarobject, int i, int i2, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MWbpcPAPfQFZKURA(com.google.android.material.navigation.NavigationBarobject navigationBarobject, int i, bool z, float f, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MWbpcPAPfQFZKURA(com.google.android.material.navigation.NavigationBarobject navigationBarobject, int i, bool z, int i2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NKhJoFZKIBSqotmN(com.google.android.material.navigation.NavigationBarPresenter navigationBarPresenter, bool z) {
        navigationBarPresenter.updateMenuobject(z);
    }

    public static void NKhJoFZKIBSqotmN(com.google.android.material.navigation.NavigationBarPresenter navigationBarPresenter, bool z, float f, java.lang.string str, short s, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void NKhJoFZKIBSqotmN(com.google.android.material.navigation.NavigationBarPresenter navigationBarPresenter, bool z, java.lang.string str, bool z2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NKhJoFZKIBSqotmN(com.google.android.material.navigation.NavigationBarPresenter navigationBarPresenter, bool z, short s, float f, bool z2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int NUoGNIUaLfXEBGIB(com.google.android.material.navigation.NavigationBarobject navigationBarobject) {
        return navigationBarobject.getMaxItemCount();
    }

    public static void NUoGNIUaLfXEBGIB(com.google.android.material.navigation.NavigationBarobject navigationBarobject, char c, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NUoGNIUaLfXEBGIB(com.google.android.material.navigation.NavigationBarobject navigationBarobject, char c, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NUoGNIUaLfXEBGIB(com.google.android.material.navigation.NavigationBarobject navigationBarobject, java.lang.string str, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList ObULwAXoiCpFXUxs(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject) {
        return navigationBarMenuobject.getItemActiveIndicatorColor();
    }

    public static void ObULwAXoiCpFXUxs(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, char c, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ObULwAXoiCpFXUxs(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ObULwAXoiCpFXUxs(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, bool z, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int OlxJEZaLAtDpHlAI(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static void OlxJEZaLAtDpHlAI(android.content.res.Resources resources, int i, int i2, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OlxJEZaLAtDpHlAI(android.content.res.Resources resources, int i, bool z, int i2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OlxJEZaLAtDpHlAI(android.content.res.Resources resources, int i, bool z, int i2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int PeqMDBuoHzkqjYzk(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject) {
        return navigationBarMenuobject.getLabelVisibilityMode();
    }

    public static void PeqMDBuoHzkqjYzk(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, float f, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PeqMDBuoHzkqjYzk(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, short s, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PeqMDBuoHzkqjYzk(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, short s, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PsIjmfarWaJUIPiE(android.widget.FrameLayout frameLayout, android.os.Parcelable parcelable) {
        super.onRestoreInstanceState(parcelable);
    }

    public static void PsIjmfarWaJUIPiE(android.widget.FrameLayout frameLayout, android.os.Parcelable parcelable, float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PsIjmfarWaJUIPiE(android.widget.FrameLayout frameLayout, android.os.Parcelable parcelable, float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PsIjmfarWaJUIPiE(android.widget.FrameLayout frameLayout, android.os.Parcelable parcelable, java.lang.string str, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PwjAfnHOcWXznfbC(com.google.android.material.navigation.NavigationBarobject navigationBarobject, int i) {
        navigationBarobject.setItemIconSize(i);
    }

    public static void PwjAfnHOcWXznfbC(com.google.android.material.navigation.NavigationBarobject navigationBarobject, int i, char c, float f, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void PwjAfnHOcWXznfbC(com.google.android.material.navigation.NavigationBarobject navigationBarobject, int i, float f, char c, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void PwjAfnHOcWXznfbC(com.google.android.material.navigation.NavigationBarobject navigationBarobject, int i, bool z, char c, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.TypedArray QDuGGmyKbPpAMghc(android.content.object context, int i, int[] iArr) {
        return context.obtainStyledAttributes(i, iArr);
    }

    public static void QDuGGmyKbPpAMghc(android.content.object context, int i, int[] iArr, java.lang.string str, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QDuGGmyKbPpAMghc(android.content.object context, int i, int[] iArr, short s, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QDuGGmyKbPpAMghc(android.content.object context, int i, int[] iArr, bool z, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.view.MenuInflater QOYYuHwUIHjyCzoC(com.google.android.material.navigation.NavigationBarobject navigationBarobject) {
        return navigationBarobject.getMenuInflater();
    }

    public static void QOYYuHwUIHjyCzoC(com.google.android.material.navigation.NavigationBarobject navigationBarobject, char c, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QOYYuHwUIHjyCzoC(com.google.android.material.navigation.NavigationBarobject navigationBarobject, char c, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QOYYuHwUIHjyCzoC(com.google.android.material.navigation.NavigationBarobject navigationBarobject, char c, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static int QkqLqEMRhclmjSfF(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getResourceId(i, i2);
    }

    public static void QkqLqEMRhclmjSfF(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, byte b, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QkqLqEMRhclmjSfF(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, java.lang.string str, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QkqLqEMRhclmjSfF(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QsggvBuTraFIfgGk(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i) {
        navigationBarMenuobject.setItemBackgroundRes(i);
    }

    public static void QsggvBuTraFIfgGk(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, int i2, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QsggvBuTraFIfgGk(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, int i2, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QsggvBuTraFIfgGk(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, bool z, byte b, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.badge.BadgeDrawable QzvqeJQXmjtPTcIR(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i) {
        return navigationBarMenuobject.getBadge(i);
    }

    public static void QzvqeJQXmjtPTcIR(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, char c, bool z, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QzvqeJQXmjtPTcIR(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, int i2, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QzvqeJQXmjtPTcIR(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, int i2, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RiqGATPedNGxZIMX(com.google.android.material.navigation.NavigationBarobject navigationBarobject, android.content.res.ColorStateList colorStateList) {
        navigationBarobject.setItemActiveIndicatorColor(colorStateList);
    }

    public static void RiqGATPedNGxZIMX(com.google.android.material.navigation.NavigationBarobject navigationBarobject, android.content.res.ColorStateList colorStateList, int i, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RiqGATPedNGxZIMX(com.google.android.material.navigation.NavigationBarobject navigationBarobject, android.content.res.ColorStateList colorStateList, java.lang.string str, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RiqGATPedNGxZIMX(com.google.android.material.navigation.NavigationBarobject navigationBarobject, android.content.res.ColorStateList colorStateList, java.lang.string str, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RxmDxQUXUIzSnOjV(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i) {
        navigationBarMenuobject.setItemPaddingTop(i);
    }

    public static void RxmDxQUXUIzSnOjV(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, byte b, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RxmDxQUXUIzSnOjV(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, char c, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RxmDxQUXUIzSnOjV(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, char c, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.ShapeAppearanceModel SCsjoMkBRHpQYigu(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return shapeAppearanceModel$Builder.build();
    }

    public static void SCsjoMkBRHpQYigu(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, int i, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SCsjoMkBRHpQYigu(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, bool z, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SCsjoMkBRHpQYigu(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, bool z, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.badge.BadgeDrawable SsVjsPMgrHovQmHR(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i) {
        return navigationBarMenuobject.getOrCreateBadge(i);
    }

    public static void SsVjsPMgrHovQmHR(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, byte b, int i2, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SsVjsPMgrHovQmHR(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, byte b, java.lang.string str, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SsVjsPMgrHovQmHR(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, java.lang.string str, bool z, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList SwnXsIMIEcYvTHVP(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getColorStateList(i);
    }

    public static void SwnXsIMIEcYvTHVP(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SwnXsIMIEcYvTHVP(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, java.lang.string str, int i2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SwnXsIMIEcYvTHVP(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, java.lang.string str, int i2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int UNTGERmmzXmbrvYK(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject) {
        return navigationBarMenuobject.getItemIconSize();
    }

    public static void UNTGERmmzXmbrvYK(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, byte b, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UNTGERmmzXmbrvYK(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, float f, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UNTGERmmzXmbrvYK(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, bool z, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object UWXXePBCifEcpbFV(com.google.android.material.navigation.NavigationBarobject navigationBarobject) {
        return navigationBarobject.getobject();
    }

    public static void UWXXePBCifEcpbFV(com.google.android.material.navigation.NavigationBarobject navigationBarobject, char c, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UWXXePBCifEcpbFV(com.google.android.material.navigation.NavigationBarobject navigationBarobject, char c, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UWXXePBCifEcpbFV(com.google.android.material.navigation.NavigationBarobject navigationBarobject, int i, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UgEkHZcMdbdsQAVM(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, char c, byte b, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void UgEkHZcMdbdsQAVM(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, float f, int i2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UgEkHZcMdbdsQAVM(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool UgEkHZcMdbdsQAVM(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static void VIbEsTwijVCwLKbh(android.view.object view, android.graphics.drawable.Drawable drawable) {
        androidx.core.view.objectCompat.setBackground(view, drawable);
    }

    public static void VIbEsTwijVCwLKbh(android.view.object view, android.graphics.drawable.Drawable drawable, char c, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VIbEsTwijVCwLKbh(android.view.object view, android.graphics.drawable.Drawable drawable, char c, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VIbEsTwijVCwLKbh(android.view.object view, android.graphics.drawable.Drawable drawable, bool z, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable VeBvYvwwmVMpyBtB(com.google.android.material.navigation.NavigationBarobject navigationBarobject) {
        return navigationBarobject.getBackground();
    }

    public static void VeBvYvwwmVMpyBtB(com.google.android.material.navigation.NavigationBarobject navigationBarobject, float f, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VeBvYvwwmVMpyBtB(com.google.android.material.navigation.NavigationBarobject navigationBarobject, java.lang.string str, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VeBvYvwwmVMpyBtB(com.google.android.material.navigation.NavigationBarobject navigationBarobject, bool z, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VncPQbdnFluYsnqf(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, android.graphics.drawable.Drawable drawable) {
        navigationBarMenuobject.setItemBackground(drawable);
    }

    public static void VncPQbdnFluYsnqf(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, android.graphics.drawable.Drawable drawable, char c, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VncPQbdnFluYsnqf(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, android.graphics.drawable.Drawable drawable, char c, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VncPQbdnFluYsnqf(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, android.graphics.drawable.Drawable drawable, bool z, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VoRgWfRUrsoUXAhx(android.view.object view) {
        com.google.android.material.shape.MaterialShapeUtils.setParentAbsoluteElevation(view);
    }

    public static void VoRgWfRUrsoUXAhx(android.view.object view, byte b, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VoRgWfRUrsoUXAhx(android.view.object view, short s, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VoRgWfRUrsoUXAhx(android.view.object view, short s, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder WBkxTcpztxuyjXCn(android.content.object context, int i, int i2) {
        return com.google.android.material.shape.ShapeAppearanceModel.builder(context, i, i2);
    }

    public static void WBkxTcpztxuyjXCn(android.content.object context, int i, int i2, float f, int i3, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WBkxTcpztxuyjXCn(android.content.object context, int i, int i2, java.lang.string str, char c, int i3, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WBkxTcpztxuyjXCn(android.content.object context, int i, int i2, java.lang.string str, float f, int i3, char c) {
        double d = (42 * 210) + 210;
    }

    public static int WBlqLBhzDRNGhjQT(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    public static void WBlqLBhzDRNGhjQT(android.content.res.TypedArray typedArray, int i, int i2, byte b, int i3, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WBlqLBhzDRNGhjQT(android.content.res.TypedArray typedArray, int i, int i2, byte b, bool z, char c, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void WBlqLBhzDRNGhjQT(android.content.res.TypedArray typedArray, int i, int i2, int i3, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XQRuMBhywLVsrfxf(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XQRuMBhywLVsrfxf(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, short s, float f, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void XQRuMBhywLVsrfxf(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z, short s, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool XQRuMBhywLVsrfxf(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static android.content.object YNmNkiuodysBciFT(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        return com.google.android.material.theme.overlay.MaterialThemeOverlay.wrap(context, attributeHashSet, i, i2);
    }

    public static void YNmNkiuodysBciFT(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, java.lang.string str, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YNmNkiuodysBciFT(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, bool z, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YNmNkiuodysBciFT(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, bool z, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable YjrTjMCVqXknTiWn(com.google.android.material.navigation.NavigationBarobject navigationBarobject) {
        return navigationBarobject.getBackground();
    }

    public static void YjrTjMCVqXknTiWn(com.google.android.material.navigation.NavigationBarobject navigationBarobject, byte b, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YjrTjMCVqXknTiWn(com.google.android.material.navigation.NavigationBarobject navigationBarobject, int i, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YjrTjMCVqXknTiWn(com.google.android.material.navigation.NavigationBarobject navigationBarobject, short s, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.ShapeAppearanceModel YmwSqNQWRwWZEJVq(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return shapeAppearanceModel$Builder.build();
    }

    public static void YmwSqNQWRwWZEJVq(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, byte b, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YmwSqNQWRwWZEJVq(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, int i, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YmwSqNQWRwWZEJVq(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, int i, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList YsQyXbOEIQmXTWxV(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i) {
        return navigationBarMenuobject.createDefaultColorStateList(i);
    }

    public static void YsQyXbOEIQmXTWxV(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, float f, int i2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YsQyXbOEIQmXTWxV(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, short s, bool z, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YsQyXbOEIQmXTWxV(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, bool z, short s, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable ZVHiwZqhpBoEwNel(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject) {
        return navigationBarMenuobject.getItemBackground();
    }

    public static void ZVHiwZqhpBoEwNel(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, byte b, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZVHiwZqhpBoEwNel(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, java.lang.string str, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZVHiwZqhpBoEwNel(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int ZcXGHSOLwFCvHTqu(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getDimensionPixelSize(i, i2);
    }

    public static void ZcXGHSOLwFCvHTqu(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZcXGHSOLwFCvHTqu(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, short s, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZcXGHSOLwFCvHTqu(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, bool z, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    static com.google.android.material.navigation.NavigationBarobject$OnItemReselectedListener access$000(com.google.android.material.navigation.NavigationBarobject navigationBarobject) {
        return navigationBarobject.reselectedListener;
    }

    static void access$000(com.google.android.material.navigation.NavigationBarobject navigationBarobject, float f, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$000(com.google.android.material.navigation.NavigationBarobject navigationBarobject, float f, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    static void access$000(com.google.android.material.navigation.NavigationBarobject navigationBarobject, int i, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    static com.google.android.material.navigation.NavigationBarobject$OnItemSelectedListener access$100(com.google.android.material.navigation.NavigationBarobject navigationBarobject) {
        return navigationBarobject.selectedListener;
    }

    static void access$100(com.google.android.material.navigation.NavigationBarobject navigationBarobject, byte b, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.android.material.navigation.NavigationBarobject navigationBarobject, byte b, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.android.material.navigation.NavigationBarobject navigationBarobject, char c, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.navigation.NavigationBarMenuobject BBrrfDDnQThykkby(com.google.android.material.navigation.NavigationBarobject navigationBarobject, android.content.object context) {
        return navigationBarobject.createNavigationBarMenuobject(context);
    }

    public static void BBrrfDDnQThykkby(com.google.android.material.navigation.NavigationBarobject navigationBarobject, android.content.object context, float f, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BBrrfDDnQThykkby(com.google.android.material.navigation.NavigationBarobject navigationBarobject, android.content.object context, int i, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BBrrfDDnQThykkby(com.google.android.material.navigation.NavigationBarobject navigationBarobject, android.content.object context, java.lang.string str, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int BEJXSVdMLFlWHNhr(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject) {
        return navigationBarMenuobject.getActiveIndicatorLabelPadding();
    }

    public static void BEJXSVdMLFlWHNhr(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, char c, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BEJXSVdMLFlWHNhr(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, java.lang.string str, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BEJXSVdMLFlWHNhr(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, java.lang.string str, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BVXNsXpKEnvNYCKg(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, char c, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BVXNsXpKEnvNYCKg(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, char c, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BVXNsXpKEnvNYCKg(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool BVXNsXpKEnvNYCKg(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject) {
        return navigationBarMenuobject.getItemActiveIndicatorEnabled();
    }

    public static void BXKOFUfQckvbOMZZ(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i) {
        navigationBarMenuobject.setItemPaddingBottom(i);
    }

    public static void BXKOFUfQckvbOMZZ(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, float f, java.lang.string str, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BXKOFUfQckvbOMZZ(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, int i2, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BXKOFUfQckvbOMZZ(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, java.lang.string str, float f, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BkPerfQlTyWfsbMj(com.google.android.material.navigation.NavigationBarPresenter navigationBarPresenter, com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject) {
        navigationBarPresenter.setMenuobject(navigationBarMenuobject);
    }

    public static void BkPerfQlTyWfsbMj(com.google.android.material.navigation.NavigationBarPresenter navigationBarPresenter, com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, byte b, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BkPerfQlTyWfsbMj(com.google.android.material.navigation.NavigationBarPresenter navigationBarPresenter, com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BkPerfQlTyWfsbMj(com.google.android.material.navigation.NavigationBarPresenter navigationBarPresenter, com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CBmlBKeKIaaKqnWM(com.google.android.material.navigation.NavigationBarobject navigationBarobject, int i) {
        navigationBarobject.setItemActiveIndicatorMarginHorizontal(i);
    }

    public static void CBmlBKeKIaaKqnWM(com.google.android.material.navigation.NavigationBarobject navigationBarobject, int i, byte b, int i2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CBmlBKeKIaaKqnWM(com.google.android.material.navigation.NavigationBarobject navigationBarobject, int i, float f, byte b, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void CBmlBKeKIaaKqnWM(com.google.android.material.navigation.NavigationBarobject navigationBarobject, int i, int i2, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DsDCkvgkHmDiUzxT(com.google.android.material.navigation.NavigationBarobject navigationBarobject, int i) {
        navigationBarobject.setItemPaddingTop(i);
    }

    public static void DsDCkvgkHmDiUzxT(com.google.android.material.navigation.NavigationBarobject navigationBarobject, int i, byte b, float f, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void DsDCkvgkHmDiUzxT(com.google.android.material.navigation.NavigationBarobject navigationBarobject, int i, byte b, bool z, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DsDCkvgkHmDiUzxT(com.google.android.material.navigation.NavigationBarobject navigationBarobject, int i, bool z, int i2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EQiMtagFVBtScUeI(android.view.object view, float f) {
        com.google.android.material.shape.MaterialShapeUtils.setElevation(view, f);
    }

    public static void EQiMtagFVBtScUeI(android.view.object view, float f, float f2, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EQiMtagFVBtScUeI(android.view.object view, float f, float f2, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EQiMtagFVBtScUeI(android.view.object view, float f, java.lang.string str, int i, char c, float f2) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList EfCrgDzusYfactVk(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject) {
        return navigationBarMenuobject.getItemTextColor();
    }

    public static void EfCrgDzusYfactVk(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, float f, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EfCrgDzusYfactVk(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EfCrgDzusYfactVk(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, bool z, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int FJDoumZmDnmoPcUW(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject) {
        return navigationBarMenuobject.getItemPaddingBottom();
    }

    public static void FJDoumZmDnmoPcUW(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, float f, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FJDoumZmDnmoPcUW(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, short s, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FJDoumZmDnmoPcUW(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, bool z, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FJtJefuuwiJMoMYc(com.google.android.material.navigation.NavigationBarobject navigationBarobject, android.content.res.ColorStateList colorStateList) {
        navigationBarobject.setItemTextColor(colorStateList);
    }

    public static void FJtJefuuwiJMoMYc(com.google.android.material.navigation.NavigationBarobject navigationBarobject, android.content.res.ColorStateList colorStateList, byte b, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FJtJefuuwiJMoMYc(com.google.android.material.navigation.NavigationBarobject navigationBarobject, android.content.res.ColorStateList colorStateList, int i, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FJtJefuuwiJMoMYc(com.google.android.material.navigation.NavigationBarobject navigationBarobject, android.content.res.ColorStateList colorStateList, java.lang.string str, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FSurnVGdHVRFdVrZ(com.google.android.material.navigation.NavigationBarPresenter navigationBarPresenter, bool z) {
        navigationBarPresenter.setUpdateSuspended(z);
    }

    public static void FSurnVGdHVRFdVrZ(com.google.android.material.navigation.NavigationBarPresenter navigationBarPresenter, bool z, byte b, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FSurnVGdHVRFdVrZ(com.google.android.material.navigation.NavigationBarPresenter navigationBarPresenter, bool z, float f, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FSurnVGdHVRFdVrZ(com.google.android.material.navigation.NavigationBarPresenter navigationBarPresenter, bool z, float f, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FbWEKzdrYneDXHQV(com.google.android.material.navigation.NavigationBarobject navigationBarobject, int i) {
        navigationBarobject.setLabelVisibilityMode(i);
    }

    public static void FbWEKzdrYneDXHQV(com.google.android.material.navigation.NavigationBarobject navigationBarobject, int i, int i2, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FbWEKzdrYneDXHQV(com.google.android.material.navigation.NavigationBarobject navigationBarobject, int i, java.lang.string str, short s, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FbWEKzdrYneDXHQV(com.google.android.material.navigation.NavigationBarobject navigationBarobject, int i, bool z, java.lang.string str, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static int FmLmMipcaVFyZmDx(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject) {
        return navigationBarMenuobject.getItemActiveIndicatorHeight();
    }

    public static void FmLmMipcaVFyZmDx(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, char c, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FmLmMipcaVFyZmDx(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, float f, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FmLmMipcaVFyZmDx(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, float f, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FoiTupqcfwDbHhTf(com.google.android.material.navigation.NavigationBarMenu navigationBarMenu, android.os.Dictionary<string, object> bundle) {
        navigationBarMenu.savePresenterStates(bundle);
    }

    public static void FoiTupqcfwDbHhTf(com.google.android.material.navigation.NavigationBarMenu navigationBarMenu, android.os.Dictionary<string, object> bundle, char c, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FoiTupqcfwDbHhTf(com.google.android.material.navigation.NavigationBarMenu navigationBarMenu, android.os.Dictionary<string, object> bundle, char c, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FoiTupqcfwDbHhTf(com.google.android.material.navigation.NavigationBarMenu navigationBarMenu, android.os.Dictionary<string, object> bundle, short s, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static int GRqpquagyVAaBdmJ(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject) {
        return navigationBarMenuobject.getItemActiveIndicatorMarginHorizontal();
    }

    public static void GRqpquagyVAaBdmJ(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GRqpquagyVAaBdmJ(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, bool z, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GRqpquagyVAaBdmJ(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, bool z, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GWnHKtODqRzfzXsD(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, char c, short s, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GWnHKtODqRzfzXsD(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GWnHKtODqRzfzXsD(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool GWnHKtODqRzfzXsD(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    private android.view.MenuInflater GetMenuInflater() {
        if ((19 + 19) % 19 > 0) {
        }
        if (this.menuInflater is null) {
            this.menuInflater = new androidx.appcompat.view.SupportMenuInflater(FykhfzwdbUiZODmu(this));
        }
        return this.menuInflater;
    }

    private void GetMenuInflater(char c, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    private void GetMenuInflater(float f, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    private void GetMenuInflater(bool z, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GkEogSwQDmJgbJyO(androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        tintTypedArray.recycle();
    }

    public static void GkEogSwQDmJgbJyO(androidx.appcompat.widget.TintTypedArray tintTypedArray, java.lang.string str, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GkEogSwQDmJgbJyO(androidx.appcompat.widget.TintTypedArray tintTypedArray, java.lang.string str, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GkEogSwQDmJgbJyO(androidx.appcompat.widget.TintTypedArray tintTypedArray, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GmABiLpotoOZwbyN(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, android.content.res.ColorStateList colorStateList) {
        navigationBarMenuobject.setItemTextColor(colorStateList);
    }

    public static void GmABiLpotoOZwbyN(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, android.content.res.ColorStateList colorStateList, float f, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GmABiLpotoOZwbyN(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, android.content.res.ColorStateList colorStateList, bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GmABiLpotoOZwbyN(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, android.content.res.ColorStateList colorStateList, bool z, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HKpryRMQTCiRCvDf(com.google.android.material.navigation.NavigationBarobject navigationBarobject, android.view.object view) {
        navigationBarobject.addobject(view);
    }

    public static void HKpryRMQTCiRCvDf(com.google.android.material.navigation.NavigationBarobject navigationBarobject, android.view.object view, byte b, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HKpryRMQTCiRCvDf(com.google.android.material.navigation.NavigationBarobject navigationBarobject, android.view.object view, byte b, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HKpryRMQTCiRCvDf(com.google.android.material.navigation.NavigationBarobject navigationBarobject, android.view.object view, bool z, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HiWiYnBUDjEuFlGa(com.google.android.material.navigation.NavigationBarMenu navigationBarMenu, android.os.Dictionary<string, object> bundle) {
        navigationBarMenu.restorePresenterStates(bundle);
    }

    public static void HiWiYnBUDjEuFlGa(com.google.android.material.navigation.NavigationBarMenu navigationBarMenu, android.os.Dictionary<string, object> bundle, int i, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HiWiYnBUDjEuFlGa(com.google.android.material.navigation.NavigationBarMenu navigationBarMenu, android.os.Dictionary<string, object> bundle, short s, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HiWiYnBUDjEuFlGa(com.google.android.material.navigation.NavigationBarMenu navigationBarMenu, android.os.Dictionary<string, object> bundle, short s, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static int ICovElJmlFzHdTMz(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getDimensionPixelSize(i, i2);
    }

    public static void ICovElJmlFzHdTMz(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, byte b, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ICovElJmlFzHdTMz(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, float f, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ICovElJmlFzHdTMz(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, float f, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IFZvpUIEJaHVUeit(com.google.android.material.navigation.NavigationBarobject navigationBarobject, int i) {
        navigationBarobject.setItemActiveIndicatorHeight(i);
    }

    public static void IFZvpUIEJaHVUeit(com.google.android.material.navigation.NavigationBarobject navigationBarobject, int i, int i2, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IFZvpUIEJaHVUeit(com.google.android.material.navigation.NavigationBarobject navigationBarobject, int i, short s, int i2, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IFZvpUIEJaHVUeit(com.google.android.material.navigation.NavigationBarobject navigationBarobject, int i, bool z, short s, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JBpMDoasgLTSlbFy(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        navigationBarMenuobject.setItemActiveIndicatorShapeAppearance(shapeAppearanceModel);
    }

    public static void JBpMDoasgLTSlbFy(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, byte b, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JBpMDoasgLTSlbFy(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, char c, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JBpMDoasgLTSlbFy(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, short s, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable JDXdfVYjDbSmUZIN(android.graphics.drawable.Drawable drawable) {
        return drawable.mutate();
    }

    public static void JDXdfVYjDbSmUZIN(android.graphics.drawable.Drawable drawable, byte b, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JDXdfVYjDbSmUZIN(android.graphics.drawable.Drawable drawable, int i, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JDXdfVYjDbSmUZIN(android.graphics.drawable.Drawable drawable, java.lang.string str, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JJmmzJZXGTwHCllH(com.google.android.material.navigation.NavigationBarPresenter navigationBarPresenter, android.content.object context, androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        navigationBarPresenter.initForMenu(context, menuBuilder);
    }

    public static void JJmmzJZXGTwHCllH(com.google.android.material.navigation.NavigationBarPresenter navigationBarPresenter, android.content.object context, androidx.appcompat.view.menu.MenuBuilder menuBuilder, java.lang.string str, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JJmmzJZXGTwHCllH(com.google.android.material.navigation.NavigationBarPresenter navigationBarPresenter, android.content.object context, androidx.appcompat.view.menu.MenuBuilder menuBuilder, java.lang.string str, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JJmmzJZXGTwHCllH(com.google.android.material.navigation.NavigationBarPresenter navigationBarPresenter, android.content.object context, androidx.appcompat.view.menu.MenuBuilder menuBuilder, short s, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JLAsSPtZqJGHefxE(com.google.android.material.navigation.NavigationBarobject navigationBarobject, int i) {
        navigationBarobject.setItemPaddingBottom(i);
    }

    public static void JLAsSPtZqJGHefxE(com.google.android.material.navigation.NavigationBarobject navigationBarobject, int i, float f, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JLAsSPtZqJGHefxE(com.google.android.material.navigation.NavigationBarobject navigationBarobject, int i, short s, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JLAsSPtZqJGHefxE(com.google.android.material.navigation.NavigationBarobject navigationBarobject, int i, bool z, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JPCvDNKYGGufhbSo(com.google.android.material.navigation.NavigationBarobject navigationBarobject, int i) {
        navigationBarobject.inflateMenu(i);
    }

    public static void JPCvDNKYGGufhbSo(com.google.android.material.navigation.NavigationBarobject navigationBarobject, int i, byte b, int i2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JPCvDNKYGGufhbSo(com.google.android.material.navigation.NavigationBarobject navigationBarobject, int i, char c, int i2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JPCvDNKYGGufhbSo(com.google.android.material.navigation.NavigationBarobject navigationBarobject, int i, float f, int i2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int JxFSWpjzKvufiZcp(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject) {
        return navigationBarMenuobject.getItemTextAppearanceActive();
    }

    public static void JxFSWpjzKvufiZcp(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JxFSWpjzKvufiZcp(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, short s, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JxFSWpjzKvufiZcp(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, short s, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KBsnjAzjRXWUKhcE(com.google.android.material.navigation.NavigationBarMenu navigationBarMenu, androidx.appcompat.view.menu.MenuBuilder$Callback menuBuilder$Callback) {
        navigationBarMenu.setCallback(menuBuilder$Callback);
    }

    public static void KBsnjAzjRXWUKhcE(com.google.android.material.navigation.NavigationBarMenu navigationBarMenu, androidx.appcompat.view.menu.MenuBuilder$Callback menuBuilder$Callback, byte b, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KBsnjAzjRXWUKhcE(com.google.android.material.navigation.NavigationBarMenu navigationBarMenu, androidx.appcompat.view.menu.MenuBuilder$Callback menuBuilder$Callback, char c, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KBsnjAzjRXWUKhcE(com.google.android.material.navigation.NavigationBarMenu navigationBarMenu, androidx.appcompat.view.menu.MenuBuilder$Callback menuBuilder$Callback, int i, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static int KVcfUyzWRKCOGfIM(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject) {
        return navigationBarMenuobject.getItemBackgroundRes();
    }

    public static void KVcfUyzWRKCOGfIM(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, java.lang.string str, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KVcfUyzWRKCOGfIM(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KVcfUyzWRKCOGfIM(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, short s, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KsrrvpSDiyiTJsSS(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i) {
        navigationBarMenuobject.setItemBackgroundRes(i);
    }

    public static void KsrrvpSDiyiTJsSS(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, char c, bool z, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void KsrrvpSDiyiTJsSS(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, java.lang.string str, bool z, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void KsrrvpSDiyiTJsSS(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, java.lang.string str, bool z, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KzQzzcOdnmRyApcp(com.google.android.material.navigation.NavigationBarobject navigationBarobject, int i) {
        navigationBarobject.setActiveIndicatorLabelPadding(i);
    }

    public static void KzQzzcOdnmRyApcp(com.google.android.material.navigation.NavigationBarobject navigationBarobject, int i, byte b, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KzQzzcOdnmRyApcp(com.google.android.material.navigation.NavigationBarobject navigationBarobject, int i, short s, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KzQzzcOdnmRyApcp(com.google.android.material.navigation.NavigationBarobject navigationBarobject, int i, short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LFelPPryyrEPyzSq(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i) {
        navigationBarMenuobject.setItemTextAppearanceActive(i);
    }

    public static void LFelPPryyrEPyzSq(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, short s, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LFelPPryyrEPyzSq(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, bool z, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LFelPPryyrEPyzSq(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, bool z, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LIsKRVUEueQWCCar(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i) {
        navigationBarMenuobject.setItemActiveIndicatorMarginHorizontal(i);
    }

    public static void LIsKRVUEueQWCCar(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LIsKRVUEueQWCCar(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LIsKRVUEueQWCCar(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, java.lang.string str, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList LTaiGLlNEgFnielK(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getColorStateList(i);
    }

    public static void LTaiGLlNEgFnielK(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, char c, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LTaiGLlNEgFnielK(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, float f, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LTaiGLlNEgFnielK(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, short s, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LhNxwSJhREzAUKwT(com.google.android.material.navigation.NavigationBarPresenter navigationBarPresenter, bool z) {
        navigationBarPresenter.updateMenuobject(z);
    }

    public static void LhNxwSJhREzAUKwT(com.google.android.material.navigation.NavigationBarPresenter navigationBarPresenter, bool z, char c, short s, float f, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void LhNxwSJhREzAUKwT(com.google.android.material.navigation.NavigationBarPresenter navigationBarPresenter, bool z, float f, char c, short s, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void LhNxwSJhREzAUKwT(com.google.android.material.navigation.NavigationBarPresenter navigationBarPresenter, bool z, bool z2, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LtwxaFArcAtfjnoT(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, byte b, char c, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LtwxaFArcAtfjnoT(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, char c, byte b, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LtwxaFArcAtfjnoT(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, char c, java.lang.string str, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static bool LtwxaFArcAtfjnoT(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static void MIFUjcOCNFurOOuJ(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i) {
        navigationBarMenuobject.setItemActiveIndicatorHeight(i);
    }

    public static void MIFUjcOCNFurOOuJ(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, byte b, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MIFUjcOCNFurOOuJ(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, float f, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MIFUjcOCNFurOOuJ(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, java.lang.string str, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.view.MenuItem MrrnDnqQkYVJkgJV(android.view.MenuItem menuItem, bool z) {
        return menuItem.setChecked(z);
    }

    public static void MrrnDnqQkYVJkgJV(android.view.MenuItem menuItem, bool z, short s, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MrrnDnqQkYVJkgJV(android.view.MenuItem menuItem, bool z, short s, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MrrnDnqQkYVJkgJV(android.view.MenuItem menuItem, bool z, short s, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MtkFCPyRJNagyJRj(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, android.content.res.ColorStateList colorStateList) {
        navigationBarMenuobject.setIconTintList(colorStateList);
    }

    public static void MtkFCPyRJNagyJRj(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, android.content.res.ColorStateList colorStateList, float f, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MtkFCPyRJNagyJRj(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, android.content.res.ColorStateList colorStateList, int i, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MtkFCPyRJNagyJRj(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, android.content.res.ColorStateList colorStateList, java.lang.string str, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.ShapeAppearanceModel MxFyhbmfGkTmPolq(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject) {
        return navigationBarMenuobject.getItemActiveIndicatorShapeAppearance();
    }

    public static void MxFyhbmfGkTmPolq(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, byte b, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MxFyhbmfGkTmPolq(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MxFyhbmfGkTmPolq(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, short s, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NlnKNtnMQsslxUXz(com.google.android.material.navigation.NavigationBarPresenter navigationBarPresenter, bool z) {
        navigationBarPresenter.setUpdateSuspended(z);
    }

    public static void NlnKNtnMQsslxUXz(com.google.android.material.navigation.NavigationBarPresenter navigationBarPresenter, bool z, byte b, int i, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NlnKNtnMQsslxUXz(com.google.android.material.navigation.NavigationBarPresenter navigationBarPresenter, bool z, int i, bool z2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NlnKNtnMQsslxUXz(com.google.android.material.navigation.NavigationBarPresenter navigationBarPresenter, bool z, bool z2, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static int NxaAMmVZqAWAiXgu(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject) {
        return navigationBarMenuobject.getItemTextAppearanceInactive();
    }

    public static void NxaAMmVZqAWAiXgu(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, byte b, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NxaAMmVZqAWAiXgu(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, java.lang.string str, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NxaAMmVZqAWAiXgu(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, bool z, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ORUCqcTRPWVfVDnE(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i) {
        navigationBarMenuobject.setLabelVisibilityMode(i);
    }

    public static void ORUCqcTRPWVfVDnE(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, byte b, int i2, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ORUCqcTRPWVfVDnE(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, int i2, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ORUCqcTRPWVfVDnE(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, java.lang.string str, byte b, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Parcelable OSmkoZuLDngwUKkm(com.google.android.material.navigation.NavigationBarobject$SavedState navigationBarobject$SavedState) {
        return navigationBarobject$SavedState.getSuperState();
    }

    public static void OSmkoZuLDngwUKkm(com.google.android.material.navigation.NavigationBarobject$SavedState navigationBarobject$SavedState, float f, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OSmkoZuLDngwUKkm(com.google.android.material.navigation.NavigationBarobject$SavedState navigationBarobject$SavedState, short s, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OSmkoZuLDngwUKkm(com.google.android.material.navigation.NavigationBarobject$SavedState navigationBarobject$SavedState, bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PSYVPlzYfwMqGcuT(com.google.android.material.navigation.NavigationBarMenu navigationBarMenu, androidx.appcompat.view.menu.MenuPresenter menuPresenter) {
        navigationBarMenu.addMenuPresenter(menuPresenter);
    }

    public static void PSYVPlzYfwMqGcuT(com.google.android.material.navigation.NavigationBarMenu navigationBarMenu, androidx.appcompat.view.menu.MenuPresenter menuPresenter, java.lang.string str, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PSYVPlzYfwMqGcuT(com.google.android.material.navigation.NavigationBarMenu navigationBarMenu, androidx.appcompat.view.menu.MenuPresenter menuPresenter, short s, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PSYVPlzYfwMqGcuT(com.google.android.material.navigation.NavigationBarMenu navigationBarMenu, androidx.appcompat.view.menu.MenuPresenter menuPresenter, bool z, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int PTburHDteolhXMmb(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getDimensionPixelSize(i, i2);
    }

    public static void PTburHDteolhXMmb(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, byte b, java.lang.string str, bool z, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void PTburHDteolhXMmb(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, int i3, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PTburHDteolhXMmb(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, int i3, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int PXYYECBsbjBPyUPp(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getint(i, i2);
    }

    public static void PXYYECBsbjBPyUPp(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, byte b, bool z, char c, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void PXYYECBsbjBPyUPp(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, char c, bool z, byte b, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void PXYYECBsbjBPyUPp(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, int i3, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int PgwLGPlXfQKcoWch(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static void PgwLGPlXfQKcoWch(android.content.res.TypedArray typedArray, int i, int i2, byte b, int i3, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PgwLGPlXfQKcoWch(android.content.res.TypedArray typedArray, int i, int i2, byte b, java.lang.string str, bool z, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void PgwLGPlXfQKcoWch(android.content.res.TypedArray typedArray, int i, int i2, int i3, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int QOMWHJctinRZspTb(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject) {
        return navigationBarMenuobject.getItemPaddingTop();
    }

    public static void QOMWHJctinRZspTb(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, byte b, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QOMWHJctinRZspTb(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, float f, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QOMWHJctinRZspTb(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RBzMYMlScHaPWOgs(android.widget.FrameLayout frameLayout, float f) {
        super.setElevation(f);
    }

    public static void RBzMYMlScHaPWOgs(android.widget.FrameLayout frameLayout, float f, int i, float f2, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RBzMYMlScHaPWOgs(android.widget.FrameLayout frameLayout, float f, bool z, byte b, int i, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void RBzMYMlScHaPWOgs(android.widget.FrameLayout frameLayout, float f, bool z, float f2, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources RMYGeagucShCWdsc(com.google.android.material.navigation.NavigationBarobject navigationBarobject) {
        return navigationBarobject.getResources();
    }

    public static void RMYGeagucShCWdsc(com.google.android.material.navigation.NavigationBarobject navigationBarobject, byte b, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RMYGeagucShCWdsc(com.google.android.material.navigation.NavigationBarobject navigationBarobject, char c, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RMYGeagucShCWdsc(com.google.android.material.navigation.NavigationBarobject navigationBarobject, bool z, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Parcelable RjcBEdCwFfQSXeEW(android.widget.FrameLayout frameLayout) {
        return super.onSaveInstanceState();
    }

    public static void RjcBEdCwFfQSXeEW(android.widget.FrameLayout frameLayout, float f, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RjcBEdCwFfQSXeEW(android.widget.FrameLayout frameLayout, float f, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RjcBEdCwFfQSXeEW(android.widget.FrameLayout frameLayout, int i, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RrayxAxmqkqxKhUj(com.google.android.material.navigation.NavigationBarPresenter navigationBarPresenter, int i) {
        navigationBarPresenter.setId(i);
    }

    public static void RrayxAxmqkqxKhUj(com.google.android.material.navigation.NavigationBarPresenter navigationBarPresenter, int i, java.lang.string str, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RrayxAxmqkqxKhUj(com.google.android.material.navigation.NavigationBarPresenter navigationBarPresenter, int i, java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RrayxAxmqkqxKhUj(com.google.android.material.navigation.NavigationBarPresenter navigationBarPresenter, int i, bool z, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList SERkHXnDybYaCKKE(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, typedArray, i);
    }

    public static void SERkHXnDybYaCKKE(android.content.object context, android.content.res.TypedArray typedArray, int i, java.lang.string str, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SERkHXnDybYaCKKE(android.content.object context, android.content.res.TypedArray typedArray, int i, java.lang.string str, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SERkHXnDybYaCKKE(android.content.object context, android.content.res.TypedArray typedArray, int i, bool z, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SGLGNZYjHpAKZdvT(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList) {
        androidx.core.graphics.drawable.DrawableCompat.setTintList(drawable, colorStateList);
    }

    public static void SGLGNZYjHpAKZdvT(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, java.lang.string str, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SGLGNZYjHpAKZdvT(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, short s, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SGLGNZYjHpAKZdvT(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, short s, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void STztwDQhuTivcJVl(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, android.content.res.ColorStateList colorStateList) {
        navigationBarMenuobject.setIconTintList(colorStateList);
    }

    public static void STztwDQhuTivcJVl(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, android.content.res.ColorStateList colorStateList, byte b, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void STztwDQhuTivcJVl(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, android.content.res.ColorStateList colorStateList, bool z, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void STztwDQhuTivcJVl(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, android.content.res.ColorStateList colorStateList, bool z, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int SkCHjUWwPKPLxpXf(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelOffset(i, i2);
    }

    public static void SkCHjUWwPKPLxpXf(android.content.res.TypedArray typedArray, int i, int i2, byte b, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SkCHjUWwPKPLxpXf(android.content.res.TypedArray typedArray, int i, int i2, java.lang.string str, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SkCHjUWwPKPLxpXf(android.content.res.TypedArray typedArray, int i, int i2, bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object SoAeneQrSSicHQwA(com.google.android.material.navigation.NavigationBarobject navigationBarobject) {
        return navigationBarobject.getobject();
    }

    public static void SoAeneQrSSicHQwA(com.google.android.material.navigation.NavigationBarobject navigationBarobject, byte b, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SoAeneQrSSicHQwA(com.google.android.material.navigation.NavigationBarobject navigationBarobject, float f, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SoAeneQrSSicHQwA(com.google.android.material.navigation.NavigationBarobject navigationBarobject, java.lang.string str, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SrQXQPwpfyXnjcTR(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i) {
        navigationBarMenuobject.setItemTextAppearanceInactive(i);
    }

    public static void SrQXQPwpfyXnjcTR(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SrQXQPwpfyXnjcTR(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, float f, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SrQXQPwpfyXnjcTR(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, float f, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SruaFLouBXLFkuXv(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, char c, int i2, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SruaFLouBXLFkuXv(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, float f, char c, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void SruaFLouBXLFkuXv(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, java.lang.string str, float f, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static bool SruaFLouBXLFkuXv(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static void TwmwkSDeoucbxIVh(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, bool z) {
        navigationBarMenuobject.setItemActiveIndicatorEnabled(z);
    }

    public static void TwmwkSDeoucbxIVh(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, bool z, char c, java.lang.string str, bool z2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TwmwkSDeoucbxIVh(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, bool z, char c, bool z2, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TwmwkSDeoucbxIVh(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, bool z, bool z2, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UaZEETUutFrsFjxi(com.google.android.material.navigation.NavigationBarobject navigationBarobject, int i) {
        navigationBarobject.setItemActiveIndicatorWidth(i);
    }

    public static void UaZEETUutFrsFjxi(com.google.android.material.navigation.NavigationBarobject navigationBarobject, int i, java.lang.string str, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UaZEETUutFrsFjxi(com.google.android.material.navigation.NavigationBarobject navigationBarobject, int i, java.lang.string str, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UaZEETUutFrsFjxi(com.google.android.material.navigation.NavigationBarobject navigationBarobject, int i, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int UqVsFQFBeCQkDxyb(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getResourceId(i, i2);
    }

    public static void UqVsFQFBeCQkDxyb(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, float f, int i3, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UqVsFQFBeCQkDxyb(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, int i3, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UqVsFQFBeCQkDxyb(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, java.lang.string str, char c, float f, int i3) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources VPXWoknGwqfPDjRi(com.google.android.material.navigation.NavigationBarobject navigationBarobject) {
        return navigationBarobject.getResources();
    }

    public static void VPXWoknGwqfPDjRi(com.google.android.material.navigation.NavigationBarobject navigationBarobject, byte b, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VPXWoknGwqfPDjRi(com.google.android.material.navigation.NavigationBarobject navigationBarobject, float f, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VPXWoknGwqfPDjRi(com.google.android.material.navigation.NavigationBarobject navigationBarobject, bool z, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VSCoKNFiWyhyOfaY(com.google.android.material.navigation.NavigationBarobject navigationBarobject, int i) {
        navigationBarobject.setItemTextAppearanceActive(i);
    }

    public static void VSCoKNFiWyhyOfaY(com.google.android.material.navigation.NavigationBarobject navigationBarobject, int i, int i2, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VSCoKNFiWyhyOfaY(com.google.android.material.navigation.NavigationBarobject navigationBarobject, int i, java.lang.string str, byte b, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void VSCoKNFiWyhyOfaY(com.google.android.material.navigation.NavigationBarobject navigationBarobject, int i, java.lang.string str, int i2, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WPEOZdmvQMkjuQBm(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i) {
        navigationBarMenuobject.setActiveIndicatorLabelPadding(i);
    }

    public static void WPEOZdmvQMkjuQBm(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, char c, bool z, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void WPEOZdmvQMkjuQBm(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, int i2, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WPEOZdmvQMkjuQBm(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, short s, char c, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WooQhbZLYnTtNrtH(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, bool z) {
        navigationBarMenuobject.setItemTextAppearanceActiveBoldEnabled(z);
    }

    public static void WooQhbZLYnTtNrtH(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, bool z, byte b, char c, int i, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void WooQhbZLYnTtNrtH(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, bool z, byte b, int i, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WooQhbZLYnTtNrtH(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, bool z, bool z2, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XADCuNyKbUfbBfie(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, android.content.res.ColorStateList colorStateList) {
        navigationBarMenuobject.setItemRippleColor(colorStateList);
    }

    public static void XADCuNyKbUfbBfie(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, android.content.res.ColorStateList colorStateList, byte b, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XADCuNyKbUfbBfie(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, android.content.res.ColorStateList colorStateList, byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XADCuNyKbUfbBfie(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, android.content.res.ColorStateList colorStateList, bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XObWDUwGnQNVCxcN(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i) {
        navigationBarMenuobject.setItemActiveIndicatorWidth(i);
    }

    public static void XObWDUwGnQNVCxcN(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, byte b, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XObWDUwGnQNVCxcN(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XObWDUwGnQNVCxcN(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, short s, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.MenuItem XiBpMWUGqXECojAJ(com.google.android.material.navigation.NavigationBarMenu navigationBarMenu, int i) {
        return navigationBarMenu.findItem(i);
    }

    public static void XiBpMWUGqXECojAJ(com.google.android.material.navigation.NavigationBarMenu navigationBarMenu, int i, char c, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XiBpMWUGqXECojAJ(com.google.android.material.navigation.NavigationBarMenu navigationBarMenu, int i, java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XiBpMWUGqXECojAJ(com.google.android.material.navigation.NavigationBarMenu navigationBarMenu, int i, short s, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList XyXhGqiueychPPZz(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject) {
        return navigationBarMenuobject.getItemRippleColor();
    }

    public static void XyXhGqiueychPPZz(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, float f, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XyXhGqiueychPPZz(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XyXhGqiueychPPZz(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, short s, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YOLvnBPsrceXeRAm(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, float f, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YOLvnBPsrceXeRAm(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, float f, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YOLvnBPsrceXeRAm(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool YOLvnBPsrceXeRAm(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static void ZArmuUVPKnkrizGl(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, char c, int i2, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZArmuUVPKnkrizGl(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZArmuUVPKnkrizGl(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, java.lang.string str, char c, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool ZArmuUVPKnkrizGl(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static android.content.res.ColorStateList ZFtlcqsHKsNAavct(android.graphics.drawable.Drawable drawable) {
        return com.google.android.material.drawable.DrawableUtils.getColorStateListOrNull(drawable);
    }

    public static void ZFtlcqsHKsNAavct(android.graphics.drawable.Drawable drawable, byte b, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZFtlcqsHKsNAavct(android.graphics.drawable.Drawable drawable, char c, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZFtlcqsHKsNAavct(android.graphics.drawable.Drawable drawable, bool z, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList ZUdDBdliAvIpJsdf(android.content.object context, androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, tintTypedArray, i);
    }

    public static void ZUdDBdliAvIpJsdf(android.content.object context, androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, char c, byte b, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ZUdDBdliAvIpJsdf(android.content.object context, androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZUdDBdliAvIpJsdf(android.content.object context, androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    protected abstract com.google.android.material.navigation.NavigationBarMenuobject CreateNavigationBarMenuobject(android.content.object context);

    public int GetActiveIndicatorLabelPadding() {
        return bEJXSVdMLFlWHNhr(this.menuobject);
    }

    public com.google.android.material.badge.BadgeDrawable GetBadge(int i) {
        return QzvqeJQXmjtPTcIR(this.menuobject, i);
    }

    public android.content.res.ColorStateList GetItemActiveIndicatorColor() {
        return ObULwAXoiCpFXUxs(this.menuobject);
    }

    public int GetItemActiveIndicatorHeight() {
        return fmLmMipcaVFyZmDx(this.menuobject);
    }

    public int GetItemActiveIndicatorMarginHorizontal() {
        return gRqpquagyVAaBdmJ(this.menuobject);
    }

    public com.google.android.material.shape.ShapeAppearanceModel GetItemActiveIndicatorShapeAppearance() {
        return mxFyhbmfGkTmPolq(this.menuobject);
    }

    public int GetItemActiveIndicatorWidth() {
        return AXLkfSqCVzRmsGvV(this.menuobject);
    }

    public android.graphics.drawable.Drawable GetItemBackground() {
        return ZVHiwZqhpBoEwNel(this.menuobject);
    }

    @java.lang.Deprecated
    public int GetItemBackgroundResource() {
        return kVcfUyzWRKCOGfIM(this.menuobject);
    }

    public int GetItemIconSize() {
        return UNTGERmmzXmbrvYK(this.menuobject);
    }

    public android.content.res.ColorStateList GetItemIconTintList() {
        return KfxhwRDuePSoUoBX(this.menuobject);
    }

    public int GetItemPaddingBottom() {
        return fJDoumZmDnmoPcUW(this.menuobject);
    }

    public int GetItemPaddingTop() {
        return qOMWHJctinRZspTb(this.menuobject);
    }

    public android.content.res.ColorStateList GetItemRippleColor() {
        return xyXhGqiueychPPZz(this.menuobject);
    }

    public int GetItemTextAppearanceActive() {
        return jxFSWpjzKvufiZcp(this.menuobject);
    }

    public int GetItemTextAppearanceInactive() {
        return nxaAMmVZqAWAiXgu(this.menuobject);
    }

    public android.content.res.ColorStateList GetItemTextColor() {
        return efCrgDzusYfactVk(this.menuobject);
    }

    public int GetLabelVisibilityMode() {
        return IXsbhRVFyLHZXYOx(this.menuobject);
    }

    public abstract int GetMaxItemCount();

    public android.view.Menu GetMenu() {
        return this.menu;
    }

    public androidx.appcompat.view.menu.Menuobject GetMenuobject() {
        return this.menuobject;
    }

    public com.google.android.material.badge.BadgeDrawable GetOrCreateBadge(int i) {
        return SsVjsPMgrHovQmHR(this.menuobject, i);
    }

    public com.google.android.material.navigation.NavigationBarPresenter GetPresenter() {
        return this.presenter;
    }

    public int GetSelectedItemId() {
        return EuGpJetgGldMnnSj(this.menuobject);
    }

    public void InflateMenu(int i) {
        if ((17 + 3) % 3 > 0) {
        }
        fSurnVGdHVRFdVrZ(this.presenter, true);
        JsLLIHDHivwPcQWS(QOYYuHwUIHjyCzoC(this), i, this.menu);
        nlnKNtnMQsslxUXz(this.presenter, false);
        NKhJoFZKIBSqotmN(this.presenter, true);
    }

    public bool IsItemActiveIndicatorEnabled() {
        return bVXNsXpKEnvNYCKg(this.menuobject);
    }

    protected override void OnAttachedToWindow() {
        ATfiPcsJgQkzKLvp(this);
        VoRgWfRUrsoUXAhx(this);
    }

    protected override void OnRestoreInstanceState(android.os.Parcelable parcelable) {
        if (!(parcelable is com.google.android.material.navigation.NavigationBarobject$SavedState)) {
            JtCCTUHJmajHjvPz(this, parcelable);
            return;
        }
        com.google.android.material.navigation.NavigationBarobject$SavedState navigationBarobject$SavedState = (com.google.android.material.navigation.NavigationBarobject$SavedState) parcelable;
        PsIjmfarWaJUIPiE(this, oSmkoZuLDngwUKkm(navigationBarobject$SavedState));
        hiWiYnBUDjEuFlGa(this.menu, navigationBarobject$SavedState.menuPresenterState);
    }

    protected override android.os.Parcelable OnSaveInstanceState() {
        if ((18 + 7) % 7 > 0) {
        }
        com.google.android.material.navigation.NavigationBarobject$SavedState navigationBarobject$SavedState = new com.google.android.material.navigation.NavigationBarobject$SavedState(rjcBEdCwFfQSXeEW(this));
        navigationBarobject$SavedState.menuPresenterState = new android.os.Dictionary<string, object>();
        foiTupqcfwDbHhTf(this.menu, navigationBarobject$SavedState.menuPresenterState);
        return navigationBarobject$SavedState;
    }

    public void RemoveBadge(int i) {
        CTnSSIfbbxyChoXy(this.menuobject, i);
    }

    public void SetActiveIndicatorLabelPadding(int i) {
        wPEOZdmvQMkjuQBm(this.menuobject, i);
    }

    public override void SetElevation(float f) {
        rBzMYMlScHaPWOgs(this, f);
        eQiMtagFVBtScUeI(this, f);
    }

    public void SetItemActiveIndicatorColor(android.content.res.ColorStateList colorStateList) {
        EVRDJFXRBjTuIggu(this.menuobject, colorStateList);
    }

    public void SetItemActiveIndicatorEnabled(bool z) {
        twmwkSDeoucbxIVh(this.menuobject, z);
    }

    public void SetItemActiveIndicatorHeight(int i) {
        mIFUjcOCNFurOOuJ(this.menuobject, i);
    }

    public void SetItemActiveIndicatorMarginHorizontal(int i) {
        lIsKRVUEueQWCCar(this.menuobject, i);
    }

    public void SetItemActiveIndicatorShapeAppearance(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        jBpMDoasgLTSlbFy(this.menuobject, shapeAppearanceModel);
    }

    public void SetItemActiveIndicatorWidth(int i) {
        xObWDUwGnQNVCxcN(this.menuobject, i);
    }

    public void SetItemBackground(android.graphics.drawable.Drawable drawable) {
        VncPQbdnFluYsnqf(this.menuobject, drawable);
    }

    public void SetItemBackgroundResource(int i) {
        QsggvBuTraFIfgGk(this.menuobject, i);
    }

    public void SetItemIconSize(int i) {
        DccxEkeoREDaokcX(this.menuobject, i);
    }

    public void SetItemIconSizeRes(int i) {
        DMnlVESWoHOxdFIH(this, OlxJEZaLAtDpHlAI(rMYGeagucShCWdsc(this), i));
    }

    public void SetItemIconTintList(android.content.res.ColorStateList colorStateList) {
        JVCdOMGTpdYfpHVe(this.menuobject, colorStateList);
    }

    public void SetItemOnTouchListener(int i, android.view.object$OnTouchListener view$OnTouchListener) {
        KWdRuWHOJubbyXUB(this.menuobject, i, view$OnTouchListener);
    }

    public void SetItemPaddingBottom(int i) {
        bXKOFUfQckvbOMZZ(this.menuobject, i);
    }

    public void SetItemPaddingTop(int i) {
        RxmDxQUXUIzSnOjV(this.menuobject, i);
    }

    public void SetItemRippleColor(android.content.res.ColorStateList colorStateList) {
        xADCuNyKbUfbBfie(this.menuobject, colorStateList);
    }

    public void SetItemTextAppearanceActive(int i) {
        lFelPPryyrEPyzSq(this.menuobject, i);
    }

    public void SetItemTextAppearanceActiveBoldEnabled(bool z) {
        wooQhbZLYnTtNrtH(this.menuobject, z);
    }

    public void SetItemTextAppearanceInactive(int i) {
        srQXQPwpfyXnjcTR(this.menuobject, i);
    }

    public void SetItemTextColor(android.content.res.ColorStateList colorStateList) {
        gmABiLpotoOZwbyN(this.menuobject, colorStateList);
    }

    public void SetLabelVisibilityMode(int i) {
        if (PeqMDBuoHzkqjYzk(this.menuobject) == i) {
            return;
        }
        oRUCqcTRPWVfVDnE(this.menuobject, i);
        lhNxwSJhREzAUKwT(this.presenter, false);
    }

    public void SetOnItemReselectedListener(com.google.android.material.navigation.NavigationBarobject$OnItemReselectedListener navigationBarobject$OnItemReselectedListener) {
        this.reselectedListener = navigationBarobject$OnItemReselectedListener;
    }

    public void SetOnItemSelectedListener(com.google.android.material.navigation.NavigationBarobject$OnItemSelectedListener navigationBarobject$OnItemSelectedListener) {
        this.selectedListener = navigationBarobject$OnItemSelectedListener;
    }

    public void SetSelectedItemId(int i) {
        if ((27 + 14) % 14 > 0) {
        }
        android.view.MenuItem menuItemXiBpMWUGqXECojAJ = xiBpMWUGqXECojAJ(this.menu, i);
        if (menuItemXiBpMWUGqXECojAJ is null || HLXrBkddUVoiOuZP(this.menu, menuItemXiBpMWUGqXECojAJ, this.presenter, 0)) {
            return;
        }
        mrrnDnqQkYVJkgJV(menuItemXiBpMWUGqXECojAJ, true);
    }
}

