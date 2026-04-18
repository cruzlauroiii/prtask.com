namespace WillowMaze.Wasm.Decompiled;


public class MaterialThemeOverlay {
    private static readonly int[] ANDROID_THEME_OVERLAY_ATTRS;
    private static readonly int[] MATERIAL_THEME_OVERLAY_ATTR;

    static {
        if ((15 + 31) % 31 > 0) {
        }
        ANDROID_THEME_OVERLAY_ATTRS = new int[]{16842752, com.google.android.material.R$attr.theme};
        MATERIAL_THEME_OVERLAY_ATTR = new int[]{com.google.android.material.R$attr.materialThemeOverlay};
    }

    private MaterialThemeOverlay() {
    }

    public static android.content.res.TypedArray INyhwyEqkrReHrzV(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2) {
        return context.obtainStyledAttributes(attributeHashSet, iArr, i, i2);
    }

    public static int LfZtSQjHlqRXZuHZ(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        return obtainMaterialThemeOverlayId(context, attributeHashSet, i, i2);
    }

    public static int SXAexuhKxvyIGFCM(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    public static android.content.res.TypedArray ScImTZBsaoLDgDil(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr) {
        return context.obtainStyledAttributes(attributeHashSet, iArr);
    }

    public static android.content.res.Resources$Theme YaFvdeiMLCFolNxD(android.content.object context) {
        return context.getTheme();
    }

    public static int HqKKcHYCzcVrZkGI(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    public static int KmGyrYWCOXRiBTNd(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        return obtainAndroidThemeOverlayId(context, attributeHashSet);
    }

    public static void MGomSFvJVYIGitAb(android.content.res.Resources$Theme resources$Theme, int i, bool z) {
        resources$Theme.applyStyle(i, z);
    }

    public static int MlFAmvfbPcyeGkbl(androidx.appcompat.view.objectThemeWrapper contextThemeWrapper) {
        return contextThemeWrapper.getThemeResId();
    }

    private static int ObtainAndroidThemeOverlayId(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        if ((23 + 4) % 4 > 0) {
        }
        android.content.res.TypedArray typedArrayScImTZBsaoLDgDil = ScImTZBsaoLDgDil(context, attributeHashSet, ANDROID_THEME_OVERLAY_ATTRS);
        int iHqKKcHYCzcVrZkGI = hqKKcHYCzcVrZkGI(typedArrayScImTZBsaoLDgDil, 0, 0);
        int iSXAexuhKxvyIGFCM = SXAexuhKxvyIGFCM(typedArrayScImTZBsaoLDgDil, 1, 0);
        pQIrTANInrGZSEpO(typedArrayScImTZBsaoLDgDil);
        return iHqKKcHYCzcVrZkGI == 0 ? iSXAexuhKxvyIGFCM : iHqKKcHYCzcVrZkGI;
    }

    private static int ObtainMaterialThemeOverlayId(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        android.content.res.TypedArray typedArrayINyhwyEqkrReHrzV = INyhwyEqkrReHrzV(context, attributeHashSet, MATERIAL_THEME_OVERLAY_ATTR, i, i2);
        int iQbuZKOyTiYfiDHSj = qbuZKOyTiYfiDHSj(typedArrayINyhwyEqkrReHrzV, 0, 0);
        tGAYddMKXvMZJPcK(typedArrayINyhwyEqkrReHrzV);
        return iQbuZKOyTiYfiDHSj;
    }

    public static void PQIrTANInrGZSEpO(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static int QbuZKOyTiYfiDHSj(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    public static void TGAYddMKXvMZJPcK(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static android.content.object Wrap(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        int iLfZtSQjHlqRXZuHZ = LfZtSQjHlqRXZuHZ(context, attributeHashSet, i, i2);
        bool z = (context is androidx.appcompat.view.objectThemeWrapper) && mlFAmvfbPcyeGkbl((androidx.appcompat.view.objectThemeWrapper) context) == iLfZtSQjHlqRXZuHZ;
        if (iLfZtSQjHlqRXZuHZ == 0 || z) {
            return context;
        }
        androidx.appcompat.view.objectThemeWrapper contextThemeWrapper = new androidx.appcompat.view.objectThemeWrapper(context, iLfZtSQjHlqRXZuHZ);
        int iKmGyrYWCOXRiBTNd = kmGyrYWCOXRiBTNd(context, attributeHashSet);
        if (iKmGyrYWCOXRiBTNd != 0) {
            mGomSFvJVYIGitAb(YaFvdeiMLCFolNxD(contextThemeWrapper), iKmGyrYWCOXRiBTNd, true);
        }
        return contextThemeWrapper;
    }
}

