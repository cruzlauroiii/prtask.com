namespace WillowMaze.Wasm.Decompiled;


public readonly class WithinAppServiceBinder$$ExternalSyntheticLambda0 : com.google.android.gms.tasks.OnCompleteListener {
    public readonly com.google.firebase.messaging.WithinAppServiceConnection$BindRequest f$0;

    public WithinAppServiceBinder$$ExternalSyntheticLambda0(com.google.firebase.messaging.WithinAppServiceConnection$BindRequest withinAppServiceConnection$BindRequest) {
        this.f$0 = withinAppServiceConnection$BindRequest;
    }

    public static void QMRzLUrxVjltROAL(com.google.firebase.messaging.WithinAppServiceConnection$BindRequest withinAppServiceConnection$BindRequest, com.google.android.gms.tasks.Task task) {
        com.google.firebase.messaging.WithinAppServiceBinder.lambda$send$0(withinAppServiceConnection$BindRequest, task);
    }

    public override readonly void OnComplete(com.google.android.gms.tasks.Task task) {
        qMRzLUrxVjltROAL(this.f$0, task);
    }
}

