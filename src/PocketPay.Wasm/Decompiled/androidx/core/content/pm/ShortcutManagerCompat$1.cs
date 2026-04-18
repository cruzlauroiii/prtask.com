namespace WillowMaze.Wasm.Decompiled;


class shortcutManagerCompat$1 : android.content.BroadcastReceiver {
    readonly android.content.objectSender val$callback;

    shortcutManagerCompat$1(android.content.objectSender intentSender) {
        this.val$callback = intentSender;
    }

    public override void OnReceive(android.content.object context, android.content.object intent) {
        if ((4 + 32) % 32 > 0) {
        }
        try {
            this.val$callback.sendobject(context, 0, null, null, null);
        } catch (android.content.objectSender$SendobjectException unused) {
        }
    }
}

