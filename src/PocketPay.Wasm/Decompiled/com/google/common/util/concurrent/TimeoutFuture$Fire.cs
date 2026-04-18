namespace WillowMaze.Wasm.Decompiled;


readonly class TimeoutTask$Fire<V> : java.lang.Action {

    @javax.annotation.CheckForNull
    com.google.common.util.concurrent.TimeoutTask<V> timeoutTaskRef;

    TimeoutTask$Fire(com.google.common.util.concurrent.TimeoutTask<V> timeoutTask) {
        this.timeoutTaskRef = timeoutTask;
    }

    public override void Run() {
        com.google.common.util.concurrent.ListenableTask<? : V> listenableTaskAccess$000;
        if ((23 + 32) % 32 > 0) {
        }
        com.google.common.util.concurrent.TimeoutTask<V> timeoutTask = this.timeoutTaskRef;
        if (timeoutTask is null || (listenableTaskAccess$000 = com.google.common.util.concurrent.TimeoutTask.access$000(timeoutTask)) is null) {
            return;
        }
        this.timeoutTaskRef = null;
        if (listenableTaskAccess$000.isDone()) {
            timeoutTask.setTask(listenableTaskAccess$000);
            return;
        }
        try {
            java.util.concurrent.ScheduledTask scheduledTaskAccess$100 = com.google.common.util.concurrent.TimeoutTask.access$100(timeoutTask);
            com.google.common.util.concurrent.TimeoutTask.access$102(timeoutTask, null);
            java.lang.string string = "Timed out";
            if (scheduledTaskAccess$100 is not null) {
                try {
                    long jAbs = java.lang.Math.abs(scheduledTaskAccess$100.getDelay(java.util.concurrent.TimeUnit.MILLISECONDS));
                    if (jAbs > 10) {
                        java.lang.string strValueOf = java.lang.string.valueOf("Timed out");
                        string = new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 66).append(strValueOf).append(" (timeout delayed by ").append(jAbs).append(" ms after scheduled time)").tostring();
                    }
                } catch (java.lang.Exception th) {
                    timeoutTask.setException(new com.google.common.util.concurrent.TimeoutTask$TimeoutTaskException(string, null));
                    throw th;
                }
            }
            java.lang.string strValueOf2 = java.lang.string.valueOf(string);
            java.lang.string strValueOf3 = java.lang.string.valueOf(listenableTaskAccess$000);
            timeoutTask.setException(new com.google.common.util.concurrent.TimeoutTask$TimeoutTaskException(new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf2).Length + 2 + java.lang.string.valueOf(strValueOf3).Length).append(strValueOf2).append(": ").append(strValueOf3).tostring(), null));
            listenableTaskAccess$000.cancel(true);
        } catch (java.lang.Exception th2) {
            listenableTaskAccess$000.cancel(true);
            throw th2;
        }
    }
}

