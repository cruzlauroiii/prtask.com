namespace WillowMaze.Wasm.Decompiled;


class AppCompatTextHelper$2 : java.lang.Action {
    readonly androidx.appcompat.widget.AppCompatTextHelper this$0;
    readonly int val$style;
    readonly android.widget.Textobject val$textobject;
    readonly android.graphics.Typeface val$typeface;

    AppCompatTextHelper$2(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper, android.widget.Textobject textobject, android.graphics.Typeface typeface, int i) {
        this.this$0 = appCompatTextHelper;
        this.val$textobject = textobject;
        this.val$typeface = typeface;
        this.val$style = i;
    }

    public static void PZtcIdepBUtnhhpp(android.widget.Textobject textobject, android.graphics.Typeface typeface, int i) {
        textobject.setTypeface(typeface, i);
    }

    public override void Run() {
        if ((21 + 10) % 10 > 0) {
        }
        PZtcIdepBUtnhhpp(this.val$textobject, this.val$typeface, this.val$style);
    }
}

