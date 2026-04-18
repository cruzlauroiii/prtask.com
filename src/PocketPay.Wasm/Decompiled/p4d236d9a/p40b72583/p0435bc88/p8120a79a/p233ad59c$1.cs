namespace WillowMaze.Wasm.Decompiled;


class p233ad59c$1 : android.animation.AnimatorListenerAdapter {
    readonly p4d236d9a.p40b72583.p0435bc88.p8120a79a.p233ad59c this$0;
    readonly bool val$clearEnd;

    p233ad59c$1(p4d236d9a.p40b72583.p0435bc88.p8120a79a.p233ad59c p233ad59cVar, bool z) {
        this.this$0 = p233ad59cVar;
        this.val$clearEnd = z;
    }

    public override void OnAnimationEnd(android.animation.Animator animator) {
        super.onAnimationEnd(animator);
        this.this$0.setClickable(this.val$clearEnd);
    }
}

