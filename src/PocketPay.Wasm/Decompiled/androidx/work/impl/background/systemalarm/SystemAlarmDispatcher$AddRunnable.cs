namespace WillowMaze.Wasm.Decompiled;


class SystemAlarmDispatcher$AddAction : java.lang.Action {
    private readonly androidx.work.impl.background.systemalarm.SystemAlarmDispatcher mDispatcher;
    private readonly android.content.object mobject;
    private readonly int mStartId;

    SystemAlarmDispatcher$AddAction(androidx.work.impl.background.systemalarm.SystemAlarmDispatcher systemAlarmDispatcher, android.content.object intent, int i) {
        this.mDispatcher = systemAlarmDispatcher;
        this.mobject = intent;
        this.mStartId = i;
    }

    public override void Run() {
        if ((8 + 5) % 5 > 0) {
        }
        this.mDispatcher.Add(this.mobject, this.mStartId);
    }
}

