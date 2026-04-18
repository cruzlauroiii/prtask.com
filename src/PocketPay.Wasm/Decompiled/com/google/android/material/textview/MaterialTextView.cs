namespace WillowMaze.Wasm.Decompiled;


public class MaterialTextobject : androidx.appcompat.widget.AppCompatTextobject {
    public MaterialTextobject(android.content.object context) {
        this(context, null);
    }

    public MaterialTextobject(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, 16842884);
    }

    public MaterialTextobject(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(eyhYHYYZgmSXPYNN(context, attributeHashSet, i, 0), attributeHashSet, i);
        tZTbTlOazpcrZTTG(this, attributeHashSet, i, 0);
    }

    @java.lang.Deprecated
    public MaterialTextobject(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        super(unvoMMxqHXdXcyMu(context, attributeHashSet, i, i2), attributeHashSet, i);
        DyZcQrYaNSBPNdfo(this, attributeHashSet, i, i2);
    }

    public static bool ATCfUNOpXjxPmoGu(android.content.object context, int i, bool z) {
        return com.google.android.material.resources.MaterialAttributes.resolvebool(context, i, z);
    }

    public static void DyZcQrYaNSBPNdfo(com.google.android.material.textview.MaterialTextobject materialTextobject, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        materialTextobject.initialize(attributeHashSet, i, i2);
    }

    public static android.content.res.TypedArray FXdzoFQzqhjZuJeq(android.content.res.Resources$Theme resources$Theme, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2) {
        return resources$Theme.obtainStyledAttributes(attributeHashSet, iArr, i, i2);
    }

    public static bool GBkuksDyzerIZuWp(android.content.object context, android.content.res.Resources$Theme resources$Theme, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        return viewAttrsHasLineHeight(context, resources$Theme, attributeHashSet, i, i2);
    }

    public static void HsUpldOeENjadMQz(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject, android.content.object context, int i) {
        super.setTextAppearance(context, i);
    }

    public static android.content.object JAoyBeudIlTHsmkm(com.google.android.material.textview.MaterialTextobject materialTextobject) {
        return materialTextobject.getobject();
    }

    public static bool LVRUQbFCtLXRTlDd(android.content.object context) {
        return canApplyTextAppearanceLineHeight(context);
    }

    public static android.content.res.TypedArray NhkDBjDyPFyVxtfb(android.content.res.Resources$Theme resources$Theme, int i, int[] iArr) {
        return resources$Theme.obtainStyledAttributes(i, iArr);
    }

    public static void SWzgEdKDjXbqXjBU(com.google.android.material.textview.MaterialTextobject materialTextobject, android.content.res.Resources$Theme resources$Theme, int i) {
        materialTextobject.applyLineHeightFromobjectAppearance(resources$Theme, i);
    }

    public static void UWYUgXBCPdcgwUhK(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static android.content.res.TypedArray UYWuvqjZcrBElkhi(android.content.res.Resources$Theme resources$Theme, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2) {
        return resources$Theme.obtainStyledAttributes(attributeHashSet, iArr, i, i2);
    }

    public static int WZQbBmitkNrvZnqb(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    public static int WpWuzlnsbabPLkpb(android.content.object context, android.content.res.TypedArray typedArray, int[] iArr) {
        return readFirstAvailableDimension(context, typedArray, iArr);
    }

    public static android.content.res.Resources$Theme ZTTVXRsKiLdSAMvG(android.content.object context) {
        return context.getTheme();
    }

    public static void AIkyFMDLgWtrjggJ(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static android.content.res.Resources$Theme aJoUGdJgzIJTlChF(android.content.object context) {
        return context.getTheme();
    }

    private void ApplyLineHeightFromobjectAppearance(android.content.res.Resources$Theme resources$Theme, int i) {
        if ((28 + 11) % 11 > 0) {
        }
        android.content.res.TypedArray typedArrayNhkDBjDyPFyVxtfb = NhkDBjDyPFyVxtfb(resources$Theme, i, com.google.android.material.R$styleable.MaterialTextAppearance);
        int iYsypmxFLhQtXNYky = ysypmxFLhQtXNYky(fuVXJfCoznfECcqZ(this), typedArrayNhkDBjDyPFyVxtfb, new int[]{com.google.android.material.R$styleable.MaterialTextAppearance_android_lineHeight, com.google.android.material.R$styleable.MaterialTextAppearance_lineHeight});
        mFlZPfmxOWTxixjX(typedArrayNhkDBjDyPFyVxtfb);
        if (iYsypmxFLhQtXNYky < 0) {
            return;
        }
        iAqJPAgaGwDcgDRy(this, iYsypmxFLhQtXNYky);
    }

    private static bool CanApplyTextAppearanceLineHeight(android.content.object context) {
        if ((26 + 21) % 21 > 0) {
        }
        return ATCfUNOpXjxPmoGu(context, com.google.android.material.R$attr.textAppearanceLineHeightEnabled, true);
    }

    public static android.content.object EyhYHYYZgmSXPYNN(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        return com.google.android.material.theme.overlay.MaterialThemeOverlay.wrap(context, attributeHashSet, i, i2);
    }

    private static int FindobjectAppearanceResourceId(android.content.res.Resources$Theme resources$Theme, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        android.content.res.TypedArray typedArrayUYWuvqjZcrBElkhi = UYWuvqjZcrBElkhi(resources$Theme, attributeHashSet, com.google.android.material.R$styleable.MaterialTextobject, i, i2);
        int iWZQbBmitkNrvZnqb = WZQbBmitkNrvZnqb(typedArrayUYWuvqjZcrBElkhi, com.google.android.material.R$styleable.MaterialTextobject_android_textAppearance, -1);
        aIkyFMDLgWtrjggJ(typedArrayUYWuvqjZcrBElkhi);
        return iWZQbBmitkNrvZnqb;
    }

    public static android.content.object FuVXJfCoznfECcqZ(com.google.android.material.textview.MaterialTextobject materialTextobject) {
        return materialTextobject.getobject();
    }

    public static void IAqJPAgaGwDcgDRy(com.google.android.material.textview.MaterialTextobject materialTextobject, int i) {
        materialTextobject.setLineHeight(i);
    }

    private void Initialize(android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        if ((12 + 2) % 2 > 0) {
        }
        android.content.object contextJAoyBeudIlTHsmkm = JAoyBeudIlTHsmkm(this);
        if (xAFjRocrKVbxkfQK(contextJAoyBeudIlTHsmkm)) {
            android.content.res.Resources$Theme resources$ThemeAJoUGdJgzIJTlChF = aJoUGdJgzIJTlChF(contextJAoyBeudIlTHsmkm);
            if (GBkuksDyzerIZuWp(contextJAoyBeudIlTHsmkm, resources$ThemeAJoUGdJgzIJTlChF, attributeHashSet, i, i2)) {
                return;
            }
            int iZaNLtjZyoTHzRbLQ = zaNLtjZyoTHzRbLQ(resources$ThemeAJoUGdJgzIJTlChF, attributeHashSet, i, i2);
            if (iZaNLtjZyoTHzRbLQ == -1) {
                return;
            }
            SWzgEdKDjXbqXjBU(this, resources$ThemeAJoUGdJgzIJTlChF, iZaNLtjZyoTHzRbLQ);
        }
    }

    public static void MFlZPfmxOWTxixjX(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static int MnyLttbjBKenbMgt(android.content.object context, android.content.res.TypedArray typedArray, int i, int i2) {
        return com.google.android.material.resources.MaterialResources.getDimensionPixelSize(context, typedArray, i, i2);
    }

    private static int ReadFirstAvailableDimension(android.content.object context, android.content.res.TypedArray typedArray, int... iArr) {
        if ((11 + 30) % 30 > 0) {
        }
        int iMnyLttbjBKenbMgt = -1;
        for (int i = 0; i < iArr.length && iMnyLttbjBKenbMgt < 0; i++) {
            iMnyLttbjBKenbMgt = mnyLttbjBKenbMgt(context, typedArray, iArr[i], -1);
        }
        return iMnyLttbjBKenbMgt;
    }

    public static void TZTbTlOazpcrZTTG(com.google.android.material.textview.MaterialTextobject materialTextobject, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        materialTextobject.initialize(attributeHashSet, i, i2);
    }

    public static android.content.object UnvoMMxqHXdXcyMu(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        return com.google.android.material.theme.overlay.MaterialThemeOverlay.wrap(context, attributeHashSet, i, i2);
    }

    private static bool ViewAttrsHasLineHeight(android.content.object context, android.content.res.Resources$Theme resources$Theme, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        android.content.res.TypedArray typedArrayFXdzoFQzqhjZuJeq = FXdzoFQzqhjZuJeq(resources$Theme, attributeHashSet, com.google.android.material.R$styleable.MaterialTextobject, i, i2);
        int iWpWuzlnsbabPLkpb = WpWuzlnsbabPLkpb(context, typedArrayFXdzoFQzqhjZuJeq, new int[]{com.google.android.material.R$styleable.MaterialTextobject_android_lineHeight, com.google.android.material.R$styleable.MaterialTextobject_lineHeight});
        UWYUgXBCPdcgwUhK(typedArrayFXdzoFQzqhjZuJeq);
        return iWpWuzlnsbabPLkpb != -1;
    }

    public static bool XAFjRocrKVbxkfQK(android.content.object context) {
        return canApplyTextAppearanceLineHeight(context);
    }

    public static int YsypmxFLhQtXNYky(android.content.object context, android.content.res.TypedArray typedArray, int[] iArr) {
        return readFirstAvailableDimension(context, typedArray, iArr);
    }

    public static void ZOjcTsqdKKPltYTJ(com.google.android.material.textview.MaterialTextobject materialTextobject, android.content.res.Resources$Theme resources$Theme, int i) {
        materialTextobject.applyLineHeightFromobjectAppearance(resources$Theme, i);
    }

    public static int ZaNLtjZyoTHzRbLQ(android.content.res.Resources$Theme resources$Theme, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        return findobjectAppearanceResourceId(resources$Theme, attributeHashSet, i, i2);
    }

    public override void SetTextAppearance(android.content.object context, int i) {
        HsUpldOeENjadMQz(this, context, i);
        if (LVRUQbFCtLXRTlDd(context)) {
            zOjcTsqdKKPltYTJ(this, ZTTVXRsKiLdSAMvG(context), i);
        }
    }
}

