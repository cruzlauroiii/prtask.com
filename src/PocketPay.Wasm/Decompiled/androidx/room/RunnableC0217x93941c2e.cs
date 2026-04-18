namespace WillowMaze.Wasm.Decompiled;


public readonly class ActionC0217x93941c2e : java.lang.Action {
    public readonly androidx.room.MultiInstanceInvalidationClient f$0;
    public readonly java.lang.string[] f$1;

    public ActionC0217x93941c2e(androidx.room.MultiInstanceInvalidationClient multiInstanceInvalidationClient, java.lang.string[] strArr) {
        this.f$0 = multiInstanceInvalidationClient;
        this.f$1 = strArr;
    }

    public override readonly void Run() {
        androidx.room.MultiInstanceInvalidationClient$callback$1.$r8$lambda$J77IKsfKUHkV39IbvPEBkb2BFYg(this.f$0, this.f$1);
    }
}

