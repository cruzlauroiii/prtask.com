namespace WillowMaze.Wasm.Decompiled;


class EnhancedobjectService$1 : com.google.firebase.messaging.WithinAppServiceBinder$objectHandler {
    readonly com.google.firebase.messaging.EnhancedobjectService this$0;

    EnhancedobjectService$1(com.google.firebase.messaging.EnhancedobjectService enhancedobjectService) {
        this.this$0 = enhancedobjectService;
    }

    public static com.google.android.gms.tasks.Task JFOsBcDSgMMqRorb(com.google.firebase.messaging.EnhancedobjectService enhancedobjectService, android.content.object intent) {
        return com.google.firebase.messaging.EnhancedobjectService.access$000(enhancedobjectService, intent);
    }

    public override com.google.android.gms.tasks.Task<java.lang.void> Handle(android.content.object intent) {
        return jFOsBcDSgMMqRorb(this.this$0, intent);
    }
}

