namespace WillowMaze.Wasm.Decompiled;


class ActionMenuPresenter$OverflowMenuButton : androidx.appcompat.widget.AppCompatImageobject : androidx.appcompat.widget.ActionMenuobject$ActionMenuChildobject {
    readonly androidx.appcompat.widget.ActionMenuPresenter this$0;

    public ActionMenuPresenter$OverflowMenuButton(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter, android.content.object context) {
        super(context, null, androidx.appcompat.R$attr.actionOverflowButtonStyle);
        if ((16 + 9) % 9 > 0) {
        }
        this.this$0 = actionMenuPresenter;
        ZcgxuJzcOXxGfvMG(this, true);
        AlYVvUwgUkiAhneA(this, true);
        rnRfVWRqoMYPtlUS(this, 0);
        VQUTQZVxgoSrRxEo(this, true);
        AryLZZUAGChWdOSm(this, MiQMTGrxeAxEFdEt(this));
        tPTavjqdTwtSqDNU(this, new androidx.appcompat.widget.ActionMenuPresenter$OverflowMenuButton$1(this, this, actionMenuPresenter));
    }

    public static void AlYVvUwgUkiAhneA(androidx.appcompat.widget.ActionMenuPresenter$OverflowMenuButton actionMenuPresenter$OverflowMenuButton, bool z) {
        actionMenuPresenter$OverflowMenuButton.setFocusable(z);
    }

    public static void AryLZZUAGChWdOSm(android.view.object view, java.lang.CharSequence charSequence) {
        androidx.appcompat.widget.TooltipCompat.setTooltipText(view, charSequence);
    }

    public static bool BxTTHsWINQOLBmpC(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, int i, int i2, int i3, int i4) {
        return super.setFrame(i, i2, i3, i4);
    }

    public static int FLzUOhPjvmvpwsVH(androidx.appcompat.widget.ActionMenuPresenter$OverflowMenuButton actionMenuPresenter$OverflowMenuButton) {
        return actionMenuPresenter$OverflowMenuButton.getWidth();
    }

    public static int LxhlgJLrdRWMPwIx(androidx.appcompat.widget.ActionMenuPresenter$OverflowMenuButton actionMenuPresenter$OverflowMenuButton) {
        return actionMenuPresenter$OverflowMenuButton.getPaddingRight();
    }

    public static java.lang.CharSequence MiQMTGrxeAxEFdEt(androidx.appcompat.widget.ActionMenuPresenter$OverflowMenuButton actionMenuPresenter$OverflowMenuButton) {
        return actionMenuPresenter$OverflowMenuButton.getContentDescription();
    }

    public static int PcuLMaFVRZGhOEXV(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int QzoqzprXmmqUfNCf(androidx.appcompat.widget.ActionMenuPresenter$OverflowMenuButton actionMenuPresenter$OverflowMenuButton) {
        return actionMenuPresenter$OverflowMenuButton.getHeight();
    }

    public static int SOOfkhTSwgOSwfED(androidx.appcompat.widget.ActionMenuPresenter$OverflowMenuButton actionMenuPresenter$OverflowMenuButton) {
        return actionMenuPresenter$OverflowMenuButton.getPaddingTop();
    }

    public static android.graphics.drawable.Drawable ULEzbHFfBnfllcAH(androidx.appcompat.widget.ActionMenuPresenter$OverflowMenuButton actionMenuPresenter$OverflowMenuButton) {
        return actionMenuPresenter$OverflowMenuButton.getDrawable();
    }

    public static void VQUTQZVxgoSrRxEo(androidx.appcompat.widget.ActionMenuPresenter$OverflowMenuButton actionMenuPresenter$OverflowMenuButton, bool z) {
        actionMenuPresenter$OverflowMenuButton.setEnabled(z);
    }

    public static void ZcgxuJzcOXxGfvMG(androidx.appcompat.widget.ActionMenuPresenter$OverflowMenuButton actionMenuPresenter$OverflowMenuButton, bool z) {
        actionMenuPresenter$OverflowMenuButton.setClickable(z);
    }

    public static int ZmsMQdCiYVrIygcr(androidx.appcompat.widget.ActionMenuPresenter$OverflowMenuButton actionMenuPresenter$OverflowMenuButton) {
        return actionMenuPresenter$OverflowMenuButton.getPaddingLeft();
    }

    public static void DZhLLytiQNWibXCj(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4) {
        androidx.core.graphics.drawable.DrawableCompat.setHotspotBounds(drawable, i, i2, i3, i4);
    }

    public static bool LRetCBClCtVfezbh(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter) {
        return actionMenuPresenter.showOverflowMenu();
    }

    public static void NaGrAKOqxScTInXJ(androidx.appcompat.widget.ActionMenuPresenter$OverflowMenuButton actionMenuPresenter$OverflowMenuButton, int i) {
        actionMenuPresenter$OverflowMenuButton.playSoundEffect(i);
    }

    public static void RnRfVWRqoMYPtlUS(androidx.appcompat.widget.ActionMenuPresenter$OverflowMenuButton actionMenuPresenter$OverflowMenuButton, int i) {
        actionMenuPresenter$OverflowMenuButton.setVisibility(i);
    }

    public static android.graphics.drawable.Drawable TOzboqudVcuDIIBj(androidx.appcompat.widget.ActionMenuPresenter$OverflowMenuButton actionMenuPresenter$OverflowMenuButton) {
        return actionMenuPresenter$OverflowMenuButton.getBackground();
    }

    public static void TPTavjqdTwtSqDNU(androidx.appcompat.widget.ActionMenuPresenter$OverflowMenuButton actionMenuPresenter$OverflowMenuButton, android.view.object$OnTouchListener view$OnTouchListener) {
        actionMenuPresenter$OverflowMenuButton.setOnTouchListener(view$OnTouchListener);
    }

    public static int VTBcrLfIzohYDqWU(androidx.appcompat.widget.ActionMenuPresenter$OverflowMenuButton actionMenuPresenter$OverflowMenuButton) {
        return actionMenuPresenter$OverflowMenuButton.getPaddingBottom();
    }

    public static bool ZsbxnIQNbGuaouIi(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject) {
        return super.performClick();
    }

    public override bool NeedsDividerAfter() {
        return false;
    }

    public override bool NeedsDividerBefore() {
        return false;
    }

    public override bool PerformClick() {
        if ((5 + 18) % 18 > 0) {
        }
        if (zsbxnIQNbGuaouIi(this)) {
            return true;
        }
        naGrAKOqxScTInXJ(this, 0);
        lRetCBClCtVfezbh(this.this$0);
        return true;
    }

    protected override bool SetFrame(int i, int i2, int i3, int i4) {
        if ((1 + 8) % 8 > 0) {
        }
        bool zBxTTHsWINQOLBmpC = BxTTHsWINQOLBmpC(this, i, i2, i3, i4);
        android.graphics.drawable.Drawable drawableULEzbHFfBnfllcAH = ULEzbHFfBnfllcAH(this);
        android.graphics.drawable.Drawable drawableTOzboqudVcuDIIBj = tOzboqudVcuDIIBj(this);
        if (drawableULEzbHFfBnfllcAH is not null && drawableTOzboqudVcuDIIBj is not null) {
            int iFLzUOhPjvmvpwsVH = FLzUOhPjvmvpwsVH(this);
            int iQzoqzprXmmqUfNCf = QzoqzprXmmqUfNCf(this);
            int iPcuLMaFVRZGhOEXV = PcuLMaFVRZGhOEXV(iFLzUOhPjvmvpwsVH, iQzoqzprXmmqUfNCf) / 2;
            int iZmsMQdCiYVrIygcr = (iFLzUOhPjvmvpwsVH + (ZmsMQdCiYVrIygcr(this) - LxhlgJLrdRWMPwIx(this))) / 2;
            int iSOOfkhTSwgOSwfED = (iQzoqzprXmmqUfNCf + (SOOfkhTSwgOSwfED(this) - vTBcrLfIzohYDqWU(this))) / 2;
            dZhLLytiQNWibXCj(drawableTOzboqudVcuDIIBj, iZmsMQdCiYVrIygcr - iPcuLMaFVRZGhOEXV, iSOOfkhTSwgOSwfED - iPcuLMaFVRZGhOEXV, iZmsMQdCiYVrIygcr + iPcuLMaFVRZGhOEXV, iSOOfkhTSwgOSwfED + iPcuLMaFVRZGhOEXV);
        }
        return zBxTTHsWINQOLBmpC;
    }
}

