namespace WillowMaze.Wasm.Decompiled;


public readonly class ImageDownload$$ExternalSyntheticLambda0 : java.lang.Action {
    public readonly com.google.firebase.messaging.ImageDownload f$0;
    public readonly com.google.android.gms.tasks.TaskCompletionSource f$1;

    public ImageDownload$$ExternalSyntheticLambda0(com.google.firebase.messaging.ImageDownload imageDownload, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        this.f$0 = imageDownload;
        this.f$1 = taskCompletionSource;
    }

    public static void ZCuaadmKPTJNNDkn(com.google.firebase.messaging.ImageDownload imageDownload, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        imageDownload.m909lambda$start$0$comgooglefirebasemessagingImageDownload(taskCompletionSource);
    }

    public override readonly void Run() {
        zCuaadmKPTJNNDkn(this.f$0, this.f$1);
    }
}

