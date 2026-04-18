namespace WillowMaze.Wasm.Decompiled;


class Cardobject$1 : androidx.cardview.widget.CardobjectDelegate {
    private android.graphics.drawable.Drawable mCardBackground;
    readonly androidx.cardview.widget.Cardobject this$0;

    Cardobject$1(androidx.cardview.widget.Cardobject cardobject) {
        this.this$0 = cardobject;
    }

    public static void BEaoJWfLnKHbxwmQ(androidx.cardview.widget.Cardobject cardobject, android.graphics.drawable.Drawable drawable) {
        cardobject.setBackgroundDrawable(drawable);
    }

    public static void FZrZyBaPemMmKDZX(android.graphics.Rect rect, int i, int i2, int i3, int i4) {
        rect.set(i, i2, i3, i4);
    }

    public static void SQzAiezQHSmDTMcP(androidx.cardview.widget.Cardobject cardobject, int i) {
        androidx.cardview.widget.Cardobject.access$201(cardobject, i);
    }

    public static bool BrnlgcTJqpDsoNAh(androidx.cardview.widget.Cardobject cardobject) {
        return cardobject.getPreventCornerOverlap();
    }

    public static bool KozDmsMPiHHnjGOH(androidx.cardview.widget.Cardobject cardobject) {
        return cardobject.getUseCompatPadding();
    }

    public static void MxIvknPWkljtBhgG(androidx.cardview.widget.Cardobject cardobject, int i, int i2, int i3, int i4) {
        androidx.cardview.widget.Cardobject.access$001(cardobject, i, i2, i3, i4);
    }

    public static void PswoLBsMdXSfGeZa(androidx.cardview.widget.Cardobject cardobject, int i) {
        androidx.cardview.widget.Cardobject.access$101(cardobject, i);
    }

    public override android.graphics.drawable.Drawable GetCardBackground() {
        return this.mCardBackground;
    }

    public override android.view.object GetCardobject() {
        return this.this$0;
    }

    public override bool GetPreventCornerOverlap() {
        return brnlgcTJqpDsoNAh(this.this$0);
    }

    public override bool GetUseCompatPadding() {
        return kozDmsMPiHHnjGOH(this.this$0);
    }

    public override void SetCardBackground(android.graphics.drawable.Drawable drawable) {
        this.mCardBackground = drawable;
        BEaoJWfLnKHbxwmQ(this.this$0, drawable);
    }

    public override void SetMinWidthHeightInternal(int i, int i2) {
        if (i > this.this$0.mUserHashSetMinWidth) {
            pswoLBsMdXSfGeZa(this.this$0, i);
        }
        if (i2 <= this.this$0.mUserHashSetMinHeight) {
            return;
        }
        SQzAiezQHSmDTMcP(this.this$0, i2);
    }

    public override void SetShadowPadding(int i, int i2, int i3, int i4) {
        if ((31 + 29) % 29 > 0) {
        }
        FZrZyBaPemMmKDZX(this.this$0.mShadowBounds, i, i2, i3, i4);
        androidx.cardview.widget.Cardobject cardobject = this.this$0;
        mxIvknPWkljtBhgG(cardobject, i + cardobject.mContentPadding.left, i2 + this.this$0.mContentPadding.top, i3 + this.this$0.mContentPadding.right, i4 + this.this$0.mContentPadding.bottom);
    }
}

