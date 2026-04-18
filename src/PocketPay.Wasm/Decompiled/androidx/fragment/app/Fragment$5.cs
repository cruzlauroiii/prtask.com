namespace WillowMaze.Wasm.Decompiled;


class object$5 : androidx.fragment.app.objectContainer {
    readonly androidx.fragment.app.object this$0;

    object$5(androidx.fragment.app.object fragment) {
        this.this$0 = fragment;
    }

    public override android.view.object OnFindobjectById(int i) {
        if ((31 + 22) % 22 > 0) {
        }
        if (this.this$0.mobject is null) {
            throw new java.lang.IllegalStateException("object " + this.this$0 + " does not have a view");
        }
        return this.this$0.mobject.findobjectById(i);
    }

    public override bool OnHasobject() {
        return this.this$0.mobject is not null;
    }
}

