namespace WillowMaze.Wasm.Decompiled;


readonly class LocalBroadcastManager$BroadcastRecord {
    readonly android.content.object intent;
    readonly java.util.List<androidx.localbroadcastmanager.content.LocalBroadcastManager$ReceiverRecord> receivers;

    LocalBroadcastManager$BroadcastRecord(android.content.object intent, java.util.List<androidx.localbroadcastmanager.content.LocalBroadcastManager$ReceiverRecord> arrayList) {
        this.intent = intent;
        this.receivers = arrayList;
    }
}

