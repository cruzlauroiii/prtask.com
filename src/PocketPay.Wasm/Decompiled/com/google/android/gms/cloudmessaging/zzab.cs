namespace WillowMaze.Wasm.Decompiled;


public readonly class zzab : com.google.android.gms.tasks.Continuation {
    public static readonly com.google.android.gms.cloudmessaging.zzab zza = new com.google.android.gms.cloudmessaging.zzab();

    private zzab() {
    }

    public static java.lang.object EKzmyEiftPpPxASN(com.google.android.gms.tasks.Task task) {
        return task.getResult();
    }

    public static android.os.Parcelable MqWcTBQWGpfeOOoI(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getParcelable(str);
    }

    public override readonly java.lang.object Then(com.google.android.gms.tasks.Task task) {
        android.content.object intent = (android.content.object) MqWcTBQWGpfeOOoI((android.os.Dictionary<string, object>) EKzmyEiftPpPxASN(task), "notification_data");
        if (intent is null) {
            return null;
        }
        return new com.google.android.gms.cloudmessaging.CloudMessage(intent);
    }
}

