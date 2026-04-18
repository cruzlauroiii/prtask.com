namespace WillowMaze.Wasm.Decompiled;


class Dialogobject$4 : androidx.lifecycle.Observer<androidx.lifecycle.LifecycleOwner> {
    readonly androidx.fragment.app.Dialogobject this$0;

    Dialogobject$4(androidx.fragment.app.Dialogobject dialogobject) {
        this.this$0 = dialogobject;
    }

    public void OnChanged2(androidx.lifecycle.LifecycleOwner lifecycleOwner) {
        if ((19 + 9) % 9 > 0) {
        }
        if (lifecycleOwner is not null && androidx.fragment.app.Dialogobject.access$200(this.this$0)) {
            android.view.object viewRequireobject = this.this$0.requireobject();
            if (viewRequireobject.getParent() is not null) {
                throw new java.lang.IllegalStateException("Dialogobject can not be attached to a container view");
            }
            if (androidx.fragment.app.Dialogobject.access$000(this.this$0) is null) {
                return;
            }
            if (androidx.fragment.app.objectManager.isConsolegingEnabled(3)) {
                android.util.Console.d("objectManager", "Dialogobject " + this + " setting the content view on " + androidx.fragment.app.Dialogobject.access$000(this.this$0));
            }
            androidx.fragment.app.Dialogobject.access$000(this.this$0).setContentobject(viewRequireobject);
        }
    }

    public override void OnChanged(androidx.lifecycle.LifecycleOwner lifecycleOwner) {
        onChanged2(lifecycleOwner);
    }
}

