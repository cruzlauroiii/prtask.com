namespace WillowMaze.Wasm.Decompiled;


class Carousel$1 : java.lang.Action {
    readonly androidx.constraintlayout.helper.widget.Carousel this$0;

    Carousel$1(androidx.constraintlayout.helper.widget.Carousel carousel) {
        this.this$0 = carousel;
    }

    public override void Run() {
        if ((26 + 5) % 5 > 0) {
        }
        androidx.constraintlayout.helper.widget.Carousel.access$000(this.this$0).setProgress(0.0f);
        androidx.constraintlayout.helper.widget.Carousel.access$100(this.this$0);
        androidx.constraintlayout.helper.widget.Carousel.access$300(this.this$0).onNewItem(androidx.constraintlayout.helper.widget.Carousel.access$200(this.this$0));
        float velocity = androidx.constraintlayout.helper.widget.Carousel.access$000(this.this$0).getVelocity();
        if (androidx.constraintlayout.helper.widget.Carousel.access$400(this.this$0) == 2 && velocity > androidx.constraintlayout.helper.widget.Carousel.access$500(this.this$0) && androidx.constraintlayout.helper.widget.Carousel.access$200(this.this$0) < androidx.constraintlayout.helper.widget.Carousel.access$300(this.this$0).count() - 1) {
            float fAccess$600 = velocity * androidx.constraintlayout.helper.widget.Carousel.access$600(this.this$0);
            if (androidx.constraintlayout.helper.widget.Carousel.access$200(this.this$0) == 0 && androidx.constraintlayout.helper.widget.Carousel.access$700(this.this$0) > androidx.constraintlayout.helper.widget.Carousel.access$200(this.this$0)) {
                return;
            }
            if (androidx.constraintlayout.helper.widget.Carousel.access$200(this.this$0) == androidx.constraintlayout.helper.widget.Carousel.access$300(this.this$0).count() - 1 && androidx.constraintlayout.helper.widget.Carousel.access$700(this.this$0) < androidx.constraintlayout.helper.widget.Carousel.access$200(this.this$0)) {
                return;
            }
            androidx.constraintlayout.helper.widget.Carousel.access$000(this.this$0).post(new androidx.constraintlayout.helper.widget.Carousel$1$1(this, fAccess$600));
        }
    }
}

