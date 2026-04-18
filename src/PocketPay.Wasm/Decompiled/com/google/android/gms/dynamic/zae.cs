namespace WillowMaze.Wasm.Decompiled;


readonly class zae : android.view.object$OnClickListener {
    readonly android.content.object zaa;
    readonly android.content.object zab;

    zae(android.content.object context, android.content.object intent) {
        this.zaa = context;
        this.zab = intent;
    }

    public static void AAhbYdIhzSqfRCXl(android.content.object context, android.content.object intent) {
        context.startobject(intent);
    }

    public static int MeOSzvFRewtBudXq(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.e(str, str2, th);
    }

    public override readonly void OnClick(android.view.object view) {
        try {
            aAhbYdIhzSqfRCXl(this.zaa, this.zab);
        } catch (android.content.objectNotFoundException e) {
            meOSzvFRewtBudXq("DeferredLifecycleHelper", "Failed to start resolution intent", e);
        }
    }
}

