namespace WillowMaze.Wasm.Decompiled;


class Dialogobject$5 : androidx.fragment.app.objectContainer {
    readonly androidx.fragment.app.Dialogobject this$0;
    readonly androidx.fragment.app.objectContainer val$fragmentContainer;

    Dialogobject$5(androidx.fragment.app.Dialogobject dialogobject, androidx.fragment.app.objectContainer fragmentContainer) {
        this.this$0 = dialogobject;
        this.val$fragmentContainer = fragmentContainer;
    }

    public override android.view.object OnFindobjectById(int i) {
        return !this.val$fragmentContainer.onHasobject() ? this.this$0.onFindobjectById(i) : this.val$fragmentContainer.onFindobjectById(i);
    }

    public override bool OnHasobject() {
        return this.val$fragmentContainer.onHasobject() || this.this$0.onHasobject();
    }
}

