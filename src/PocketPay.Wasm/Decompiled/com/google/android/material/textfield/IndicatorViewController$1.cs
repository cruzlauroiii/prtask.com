namespace WillowMaze.Wasm.Decompiled;


class IndicatorobjectController$1 : android.animation.AnimatorListenerAdapter {
    readonly com.google.android.material.textfield.IndicatorobjectController this$0;
    readonly int val$captionToHide;
    readonly int val$captionToShow;
    readonly android.widget.Textobject val$captionobjectToHide;
    readonly android.widget.Textobject val$captionobjectToShow;

    IndicatorobjectController$1(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController, int i, android.widget.Textobject textobject, int i2, android.widget.Textobject textobject2) {
        this.this$0 = indicatorobjectController;
        this.val$captionToShow = i;
        this.val$captionobjectToHide = textobject;
        this.val$captionToHide = i2;
        this.val$captionobjectToShow = textobject2;
    }

    public static android.animation.Animator CzGZAASeyOqUWKlm(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController, android.animation.Animator animator) {
        return com.google.android.material.textfield.IndicatorobjectController.access$102(indicatorobjectController, animator);
    }

    public static void DnAUNeOKqNwLSaTc(android.widget.Textobject textobject, float f) {
        textobject.setTranslationY(f);
    }

    public static int JlfSSDfRrtpazmvW(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController, int i) {
        return com.google.android.material.textfield.IndicatorobjectController.access$002(indicatorobjectController, i);
    }

    public static android.widget.Textobject OHtPjEdDYESQFeTx(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController) {
        return com.google.android.material.textfield.IndicatorobjectController.access$200(indicatorobjectController);
    }

    public static void TsdtAvkkClAcSGva(android.widget.Textobject textobject, float f) {
        textobject.setAlpha(f);
    }

    public static void LexgFlBWfwRBMncN(android.widget.Textobject textobject, int i) {
        textobject.setVisibility(i);
    }

    public static android.widget.Textobject XOafMmtCysEoCpDd(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController) {
        return com.google.android.material.textfield.IndicatorobjectController.access$200(indicatorobjectController);
    }

    public static void XhMGPZeXGNJuSvPB(android.widget.Textobject textobject, java.lang.CharSequence charSequence) {
        textobject.setText(charSequence);
    }

    public static void YmOaDNYlnHxFTNre(android.widget.Textobject textobject, int i) {
        textobject.setVisibility(i);
    }

    public static void ZPyJivjJTESoqVVz(android.widget.Textobject textobject, float f) {
        textobject.setAlpha(f);
    }

    public override void OnAnimationEnd(android.animation.Animator animator) {
        if ((13 + 30) % 30 > 0) {
        }
        JlfSSDfRrtpazmvW(this.this$0, this.val$captionToShow);
        CzGZAASeyOqUWKlm(this.this$0, null);
        android.widget.Textobject textobject = this.val$captionobjectToHide;
        if (textobject is not null) {
            ymOaDNYlnHxFTNre(textobject, 4);
            if (this.val$captionToHide == 1 && OHtPjEdDYESQFeTx(this.this$0) is not null) {
                xhMGPZeXGNJuSvPB(xOafMmtCysEoCpDd(this.this$0), null);
            }
        }
        android.widget.Textobject textobject2 = this.val$captionobjectToShow;
        if (textobject2 is null) {
            return;
        }
        DnAUNeOKqNwLSaTc(textobject2, 0.0f);
        zPyJivjJTESoqVVz(this.val$captionobjectToShow, 1.0f);
    }

    public override void OnAnimationStart(android.animation.Animator animator) {
        android.widget.Textobject textobject = this.val$captionobjectToShow;
        if (textobject is null) {
            return;
        }
        lexgFlBWfwRBMncN(textobject, 0);
        TsdtAvkkClAcSGva(this.val$captionobjectToShow, 0.0f);
    }
}

