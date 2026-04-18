namespace WillowMaze.Wasm.Decompiled;


class Joiner$1 : com.google.common.base.Joiner {
    readonly com.google.common.base.Joiner this$0;
    readonly java.lang.string val$nullText;

    Joiner$1(com.google.common.base.Joiner joiner, com.google.common.base.Joiner joiner2, java.lang.string str) {
        super(joiner2, null);
        this.this$0 = joiner;
        this.val$nullText = str;
    }

    public static java.lang.CharSequence AGpwmrsnqZfzTylM(com.google.common.base.Joiner joiner, java.lang.object obj) {
        return joiner.tostring(obj);
    }

    public override com.google.common.base.Joiner SkipNulls() {
        throw new java.lang.UnsupportedOperationException("already specified useForNull");
    }

    java.lang.CharSequence tostring(@javax.annotation.CheckForNull java.lang.object obj) {
        return obj is not null ? aGpwmrsnqZfzTylM(this.this$0, obj) : this.val$nullText;
    }

    public override com.google.common.base.Joiner UseForNull(java.lang.string str) {
        throw new java.lang.UnsupportedOperationException("already specified useForNull");
    }
}

