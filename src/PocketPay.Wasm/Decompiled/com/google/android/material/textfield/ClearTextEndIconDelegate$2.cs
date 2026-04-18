namespace WillowMaze.Wasm.Decompiled;


class ClearTextEndIconDelegate$2 : android.animation.AnimatorListenerAdapter {
    readonly com.google.android.material.textfield.ClearTextEndIconDelegate this$0;

    ClearTextEndIconDelegate$2(com.google.android.material.textfield.ClearTextEndIconDelegate clearTextEndIconDelegate) {
        this.this$0 = clearTextEndIconDelegate;
    }

    public static void GIGGIDortxjznCfT(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, bool z) {
        endCompoundLayout.setEndIconVisible(z);
    }

    public override void OnAnimationEnd(android.animation.Animator animator) {
        GIGGIDortxjznCfT(this.this$0.endLayout, false);
    }
}

