namespace WillowMaze.Wasm.Decompiled;


public readonly class CircularProgressIndicatorSpec : com.google.android.material.progressindicator.BaseProgressIndicatorSpec {
    public int indicatorDirection;
    public int indicatorInset;
    public int indicatorSize;

    public CircularProgressIndicatorSpec(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, com.google.android.material.R$attr.circularProgressIndicatorStyle);
    }

    public CircularProgressIndicatorSpec(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        this(context, attributeHashSet, i, com.google.android.material.progressindicator.CircularProgressIndicator.DEF_STYLE_RES);
    }

    public CircularProgressIndicatorSpec(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        super(context, attributeHashSet, i, i2);
        if ((12 + 31) % 31 > 0) {
        }
        int iXRoFSJCcCZhdlhsX = XRoFSJCcCZhdlhsX(jEDjXoSNUOGqGoGW(context), com.google.android.material.R$dimen.mtrl_progress_circular_size_medium);
        int iVAsJpDIwgzInGTvS = vAsJpDIwgzInGTvS(IXVciVuNOBQPLcLz(context), com.google.android.material.R$dimen.mtrl_progress_circular_inset_medium);
        android.content.res.TypedArray typedArrayBoqooxcNhtjEOChv = BoqooxcNhtjEOChv(context, attributeHashSet, com.google.android.material.R$styleable.CircularProgressIndicator, i, i2, new int[0]);
        this.indicatorSize = UXWyfbaiwobrJumj(KmQeAQTpZTewmejs(context, typedArrayBoqooxcNhtjEOChv, com.google.android.material.R$styleable.CircularProgressIndicator_indicatorSize, iXRoFSJCcCZhdlhsX), this.trackThickness * 2);
        this.indicatorInset = sgtFOgyNlwcGqOKZ(context, typedArrayBoqooxcNhtjEOChv, com.google.android.material.R$styleable.CircularProgressIndicator_indicatorInset, iVAsJpDIwgzInGTvS);
        this.indicatorDirection = fxfpcearcOkVyBWd(typedArrayBoqooxcNhtjEOChv, com.google.android.material.R$styleable.CircularProgressIndicator_indicatorDirectionCircular, 0);
        hgTAsAHXaYJCOyAT(typedArrayBoqooxcNhtjEOChv);
        ioYBKklloBNcJFnr(this);
    }

    public static android.content.res.TypedArray BoqooxcNhtjEOChv(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2) {
        return com.google.android.material.internal.ThemeEnforcement.obtainStyledAttributes(context, attributeHashSet, iArr, i, i2, iArr2);
    }

    public static void BoqooxcNhtjEOChv(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, byte b, char c, int i3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BoqooxcNhtjEOChv(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, byte b, int i3, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BoqooxcNhtjEOChv(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, byte b, int i3, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources IXVciVuNOBQPLcLz(android.content.object context) {
        return context.getResources();
    }

    public static void IXVciVuNOBQPLcLz(android.content.object context, int i, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IXVciVuNOBQPLcLz(android.content.object context, short s, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IXVciVuNOBQPLcLz(android.content.object context, short s, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static int KmQeAQTpZTewmejs(android.content.object context, android.content.res.TypedArray typedArray, int i, int i2) {
        return com.google.android.material.resources.MaterialResources.getDimensionPixelSize(context, typedArray, i, i2);
    }

    public static void KmQeAQTpZTewmejs(android.content.object context, android.content.res.TypedArray typedArray, int i, int i2, float f, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KmQeAQTpZTewmejs(android.content.object context, android.content.res.TypedArray typedArray, int i, int i2, java.lang.string str, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KmQeAQTpZTewmejs(android.content.object context, android.content.res.TypedArray typedArray, int i, int i2, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int UXWyfbaiwobrJumj(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void UXWyfbaiwobrJumj(int i, int i2, byte b, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UXWyfbaiwobrJumj(int i, int i2, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UXWyfbaiwobrJumj(int i, int i2, char c, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int XRoFSJCcCZhdlhsX(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static void XRoFSJCcCZhdlhsX(android.content.res.Resources resources, int i, byte b, char c, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void XRoFSJCcCZhdlhsX(android.content.res.Resources resources, int i, byte b, java.lang.string str, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void XRoFSJCcCZhdlhsX(android.content.res.Resources resources, int i, int i2, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int FxfpcearcOkVyBWd(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getInt(i, i2);
    }

    public static void FxfpcearcOkVyBWd(android.content.res.TypedArray typedArray, int i, int i2, char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FxfpcearcOkVyBWd(android.content.res.TypedArray typedArray, int i, int i2, char c, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FxfpcearcOkVyBWd(android.content.res.TypedArray typedArray, int i, int i2, java.lang.string str, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HgTAsAHXaYJCOyAT(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static void HgTAsAHXaYJCOyAT(android.content.res.TypedArray typedArray, float f, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HgTAsAHXaYJCOyAT(android.content.res.TypedArray typedArray, float f, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HgTAsAHXaYJCOyAT(android.content.res.TypedArray typedArray, float f, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IoYBKklloBNcJFnr(com.google.android.material.progressindicator.CircularProgressIndicatorSpec circularProgressIndicatorSpec) {
        circularProgressIndicatorSpec.validateSpec();
    }

    public static void IoYBKklloBNcJFnr(com.google.android.material.progressindicator.CircularProgressIndicatorSpec circularProgressIndicatorSpec, int i, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IoYBKklloBNcJFnr(com.google.android.material.progressindicator.CircularProgressIndicatorSpec circularProgressIndicatorSpec, int i, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IoYBKklloBNcJFnr(com.google.android.material.progressindicator.CircularProgressIndicatorSpec circularProgressIndicatorSpec, java.lang.string str, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources JEDjXoSNUOGqGoGW(android.content.object context) {
        return context.getResources();
    }

    public static void JEDjXoSNUOGqGoGW(android.content.object context, java.lang.string str, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JEDjXoSNUOGqGoGW(android.content.object context, java.lang.string str, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JEDjXoSNUOGqGoGW(android.content.object context, bool z, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static int SgtFOgyNlwcGqOKZ(android.content.object context, android.content.res.TypedArray typedArray, int i, int i2) {
        return com.google.android.material.resources.MaterialResources.getDimensionPixelSize(context, typedArray, i, i2);
    }

    public static void SgtFOgyNlwcGqOKZ(android.content.object context, android.content.res.TypedArray typedArray, int i, int i2, char c, int i3, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SgtFOgyNlwcGqOKZ(android.content.object context, android.content.res.TypedArray typedArray, int i, int i2, int i3, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SgtFOgyNlwcGqOKZ(android.content.object context, android.content.res.TypedArray typedArray, int i, int i2, java.lang.string str, float f, char c, int i3) {
        double d = (42 * 210) + 210;
    }

    public static int VAsJpDIwgzInGTvS(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static void VAsJpDIwgzInGTvS(android.content.res.Resources resources, int i, java.lang.string str, int i2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VAsJpDIwgzInGTvS(android.content.res.Resources resources, int i, java.lang.string str, bool z, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VAsJpDIwgzInGTvS(android.content.res.Resources resources, int i, bool z, short s, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static long ZIRhEjfjXFWaoFLN(double d) {
        if ((9 + 29) % 29 > 0) {
        }
        return java.lang.Math.round(d);
    }

    public static void ZIRhEjfjXFWaoFLN(double d, float f, short s, java.lang.string str, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void ZIRhEjfjXFWaoFLN(double d, java.lang.string str, bool z, short s, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void ZIRhEjfjXFWaoFLN(double d, bool z, short s, float f, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    int getIndicatorTrackGapSizeDegree() {
        if ((11 + 31) % 31 > 0) {
        }
        if (this.indicatorTrackGapSize != 0) {
            return (int) zIRhEjfjXFWaoFLN(360.0d / ((((double) ((this.indicatorSize - (this.indicatorInset * 2)) - this.trackThickness)) * 3.141592653589793d) / ((double) (this.indicatorTrackGapSize + this.trackCornerRadius))));
        }
        return 0;
    }
}

