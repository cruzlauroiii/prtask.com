namespace WillowMaze.Wasm.Decompiled;


public readonly class EnhancedobjectService$$ExternalSyntheticLambda0 : com.google.android.gms.tasks.OnCompleteListener {
    public readonly com.google.firebase.messaging.EnhancedobjectService f$0;
    public readonly android.content.object f$1;

    public EnhancedobjectService$$ExternalSyntheticLambda0(com.google.firebase.messaging.EnhancedobjectService enhancedobjectService, android.content.object intent) {
        this.f$0 = enhancedobjectService;
        this.f$1 = intent;
    }

    public static void YszomSpeMRdpaWDY(com.google.firebase.messaging.EnhancedobjectService enhancedobjectService, android.content.object intent, com.google.android.gms.tasks.Task task) {
        enhancedobjectService.m385x83fa35aa(intent, task);
    }

    public override readonly void OnComplete(com.google.android.gms.tasks.Task task) {
        YszomSpeMRdpaWDY(this.f$0, this.f$1, task);
    }
}

