namespace WillowMaze.Wasm.Decompiled;


class ClearTextEndIconDelegate$1 : android.animation.AnimatorListenerAdapter {
    readonly com.google.android.material.textfield.ClearTextEndIconDelegate this$0;

    ClearTextEndIconDelegate$1(com.google.android.material.textfield.ClearTextEndIconDelegate clearTextEndIconDelegate) {
        this.this$0 = clearTextEndIconDelegate;
    }

    public static void WFTraKnEerWOnfKA(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, bool z) {
        endCompoundLayout.setEndIconVisible(z);
    }

    public override void OnAnimationStart(android.animation.Animator animator) {
        WFTraKnEerWOnfKA(this.this$0.endLayout, true);
    }
}

