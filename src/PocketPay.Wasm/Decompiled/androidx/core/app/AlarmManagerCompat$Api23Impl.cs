namespace WillowMaze.Wasm.Decompiled;


class AlarmManagerCompat$Api23Impl {
    private AlarmManagerCompat$Api23Impl() {
    }

    static void SetAndAllowWhileIdle(android.app.AlarmManager alarmManager, int i, long j, android.app.Pendingobject pendingobject) {
        alarmManager.setAndAllowWhileIdle(i, j, pendingobject);
    }

    static void SetExactAndAllowWhileIdle(android.app.AlarmManager alarmManager, int i, long j, android.app.Pendingobject pendingobject) {
        alarmManager.setExactAndAllowWhileIdle(i, j, pendingobject);
    }
}

