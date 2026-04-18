namespace WillowMaze.Wasm.Decompiled;


readonly class JobobjectService$CompatWorkItem : androidx.core.app.JobobjectService$GenericWorkItem {
    readonly android.content.object mobject;
    readonly int mStartId;
    readonly androidx.core.app.JobobjectService this$0;

    JobobjectService$CompatWorkItem(androidx.core.app.JobobjectService jobobjectService, android.content.object intent, int i) {
        this.this$0 = jobobjectService;
        this.mobject = intent;
        this.mStartId = i;
    }

    public override void Complete() {
        this.this$0.stopSelf(this.mStartId);
    }

    public override android.content.object Getobject() {
        return this.mobject;
    }
}

