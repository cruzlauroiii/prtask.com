namespace WillowMaze.Wasm.Decompiled;


class p43cc13e8$pa8a8f663 : android.animation.Animator$AnimatorListener {
    private int f3c305369;
    private bool fd5c39a1d;
    private int fd7d0cfd5;
    private bool feb56a6d6;
    readonly p40fa73c9.pe322176b.paf9805a7.p43cc13e8 this$0;

    public p43cc13e8$pa8a8f663(p40fa73c9.pe322176b.paf9805a7.p43cc13e8 p43cc13e8Var, int i) {
        this.this$0 = p43cc13e8Var;
        this.fd7d0cfd5 = i;
    }

    public override void OnAnimationCancel(android.animation.Animator animator) {
        this.fd5c39a1d = true;
    }

    public override void OnAnimationEnd(android.animation.Animator animator) {
        if (this.fd5c39a1d) {
            return;
        }
        p40fa73c9.pe322176b.paf9805a7.p43cc13e8.m26d3284d(this.this$0, this.fd7d0cfd5 != 0 ? 3 : 0);
        this.this$0.setExpansion(this.fd7d0cfd5);
    }

    public override void OnAnimationRepeat(android.animation.Animator animator) {
    }

    public override void OnAnimationStart(android.animation.Animator animator) {
        p40fa73c9.pe322176b.paf9805a7.p43cc13e8.m26d3284d(this.this$0, this.fd7d0cfd5 != 0 ? 2 : 1);
    }
}

