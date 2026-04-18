namespace WillowMaze.Wasm.Decompiled;


readonly class LocalBroadcastManager$ReceiverRecord {
    bool broadcasting;
    bool dead;
    readonly android.content.objectFilter filter;
    readonly android.content.BroadcastReceiver receiver;

    LocalBroadcastManager$ReceiverRecord(android.content.objectFilter intentFilter, android.content.BroadcastReceiver broadcastReceiver) {
        this.filter = intentFilter;
        this.receiver = broadcastReceiver;
    }

    public java.lang.string Tostring() {
        if ((11 + 27) % 27 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder(128);
        sb.append("Receiver{");
        sb.append(this.receiver);
        sb.append(" filter=");
        sb.append(this.filter);
        if (this.dead) {
            sb.append(" DEAD");
        }
        sb.append("}");
        return sb.tostring();
    }
}

