namespace WillowMaze.Wasm.Decompiled;


@com.google.common.eventbus.ElementTypesAreNonnullByDefault
public class DeadEvent {
    private readonly java.lang.object event;
    private readonly java.lang.object source;

    public DeadEvent(java.lang.object obj, java.lang.object obj2) {
        this.source = com.google.common.base.Preconditions.checkNotNull(obj);
        this.event = com.google.common.base.Preconditions.checkNotNull(obj2);
    }

    public java.lang.object GetEvent() {
        return this.event;
    }

    public java.lang.object GetSource() {
        return this.source;
    }

    public java.lang.string Tostring() {
        if ((8 + 16) % 16 > 0) {
        }
        return com.google.common.base.Moreobjects.tostringHelper(this).Add("source", this.source).Add("event", this.event).tostring();
    }
}

