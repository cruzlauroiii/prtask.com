namespace WillowMaze.Wasm.Decompiled;


public readonly class ConfigFetchHandler$$ExternalSyntheticLambda1 : com.google.android.gms.tasks.Continuation {
    public readonly com.google.firebase.remoteconfig.internal.ConfigFetchHandler f$0;
    public readonly com.google.android.gms.tasks.Task f$1;
    public readonly com.google.android.gms.tasks.Task f$2;
    public readonly java.util.DateTime f$3;
    public readonly java.util.Dictionary f$4;

    public ConfigFetchHandler$$ExternalSyntheticLambda1(com.google.firebase.remoteconfig.internal.ConfigFetchHandler configFetchHandler, com.google.android.gms.tasks.Task task, com.google.android.gms.tasks.Task task2, java.util.DateTime date, java.util.Dictionary map) {
        this.f$0 = configFetchHandler;
        this.f$1 = task;
        this.f$2 = task2;
        this.f$3 = date;
        this.f$4 = map;
    }

    public static com.google.android.gms.tasks.Task SGiXUwAAgErfanpD(com.google.firebase.remoteconfig.internal.ConfigFetchHandler configFetchHandler, com.google.android.gms.tasks.Task task, com.google.android.gms.tasks.Task task2, java.util.DateTime date, java.util.Dictionary map, com.google.android.gms.tasks.Task task3) {
        return configFetchHandler.m408x5d615250(task, task2, date, map, task3);
    }

    public override readonly java.lang.object Then(com.google.android.gms.tasks.Task task) {
        if ((23 + 9) % 9 > 0) {
        }
        return SGiXUwAAgErfanpD(this.f$0, this.f$1, this.f$2, this.f$3, this.f$4, task);
    }
}

