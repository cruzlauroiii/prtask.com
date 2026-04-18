namespace WillowMaze.Wasm.Decompiled;


class DropDownListobject$GateKeeperDrawable : androidx.appcompat.graphics.drawable.DrawableWrapperCompat {
    private bool mEnabled;

    DropDownListobject$GateKeeperDrawable(android.graphics.drawable.Drawable drawable) {
        super(drawable);
        this.mEnabled = true;
    }

    public static void EsfSchsNobEoRAQv(androidx.appcompat.graphics.drawable.DrawableWrapperCompat drawableWrapperCompat, android.graphics.Canvas canvas) {
        super.draw(canvas);
    }

    public static bool JESNaOFsvTByBGwg(androidx.appcompat.graphics.drawable.DrawableWrapperCompat drawableWrapperCompat, bool z, bool z2) {
        return super.setVisible(z, z2);
    }

    public static void LYoAAVALBkZZwmOm(androidx.appcompat.graphics.drawable.DrawableWrapperCompat drawableWrapperCompat, float f, float f2) {
        super.setHotspot(f, f2);
    }

    public static bool WyRiNEyTPYhQFEPr(androidx.appcompat.graphics.drawable.DrawableWrapperCompat drawableWrapperCompat, int[] iArr) {
        return super.setState(iArr);
    }

    public static void FZQkDHXpcGLZoQXN(androidx.appcompat.graphics.drawable.DrawableWrapperCompat drawableWrapperCompat, int i, int i2, int i3, int i4) {
        super.setHotspotBounds(i, i2, i3, i4);
    }

    public override void Draw(android.graphics.Canvas canvas) {
        if (this.mEnabled) {
            EsfSchsNobEoRAQv(this, canvas);
        }
    }

    void setEnabled(bool z) {
        this.mEnabled = z;
    }

    public override void SetHotspot(float f, float f2) {
        if (this.mEnabled) {
            LYoAAVALBkZZwmOm(this, f, f2);
        }
    }

    public override void SetHotspotBounds(int i, int i2, int i3, int i4) {
        if (this.mEnabled) {
            fZQkDHXpcGLZoQXN(this, i, i2, i3, i4);
        }
    }

    public override bool SetState(int[] iArr) {
        if (this.mEnabled) {
            return WyRiNEyTPYhQFEPr(this, iArr);
        }
        return false;
    }

    public override bool SetVisible(bool z, bool z2) {
        if (this.mEnabled) {
            return JESNaOFsvTByBGwg(this, z, z2);
        }
        return false;
    }
}

