namespace WillowMaze.Wasm.Decompiled;


class DropdownMenuEndIconDelegate$1 : android.animation.AnimatorListenerAdapter {
    readonly com.google.android.material.textfield.DropdownMenuEndIconDelegate this$0;

    DropdownMenuEndIconDelegate$1(com.google.android.material.textfield.DropdownMenuEndIconDelegate dropdownMenuEndIconDelegate) {
        this.this$0 = dropdownMenuEndIconDelegate;
    }

    public static void CQPcciQsdsrkkmfY(android.animation.ValueAnimator valueAnimator) {
        valueAnimator.start();
    }

    public static void PTvBTiZRvjjeegcz(com.google.android.material.textfield.DropdownMenuEndIconDelegate dropdownMenuEndIconDelegate) {
        dropdownMenuEndIconDelegate.refreshIconState();
    }

    public static android.animation.ValueAnimator SetMxmtGiYRnDlka(com.google.android.material.textfield.DropdownMenuEndIconDelegate dropdownMenuEndIconDelegate) {
        return com.google.android.material.textfield.DropdownMenuEndIconDelegate.access$000(dropdownMenuEndIconDelegate);
    }

    public override void OnAnimationEnd(android.animation.Animator animator) {
        pTvBTiZRvjjeegcz(this.this$0);
        cQPcciQsdsrkkmfY(setMxmtGiYRnDlka(this.this$0));
    }
}

