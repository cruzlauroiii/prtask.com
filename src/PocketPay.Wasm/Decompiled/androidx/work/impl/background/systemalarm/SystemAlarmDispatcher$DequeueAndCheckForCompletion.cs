namespace WillowMaze.Wasm.Decompiled;


class SystemAlarmDispatcher$QueueueAndCheckForCompletion : java.lang.Action {
    private readonly androidx.work.impl.background.systemalarm.SystemAlarmDispatcher mDispatcher;

    SystemAlarmDispatcher$QueueueAndCheckForCompletion(androidx.work.impl.background.systemalarm.SystemAlarmDispatcher systemAlarmDispatcher) {
        this.mDispatcher = systemAlarmDispatcher;
    }

    public override void Run() {
        this.mDispatcher.dequeueAndCheckForCompletion();
    }
}

