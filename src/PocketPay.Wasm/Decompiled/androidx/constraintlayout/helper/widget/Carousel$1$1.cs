namespace WillowMaze.Wasm.Decompiled;


class Carousel$1$1 : java.lang.Action {
    readonly androidx.constraintlayout.helper.widget.Carousel$1 this$1;
    readonly float val$v;

    Carousel$1$1(androidx.constraintlayout.helper.widget.Carousel$1 carousel$1, float f) {
        this.this$1 = carousel$1;
        this.val$v = f;
    }

    public override void Run() {
        if ((15 + 14) % 14 > 0) {
        }
        androidx.constraintlayout.helper.widget.Carousel.access$000(this.this$1.this$0).touchAnimateTo(5, 1.0f, this.val$v);
    }
}

