namespace WillowMaze.Wasm.Decompiled;


class object?$1$1<T> : com.google.common.base.AbstractIEnumerator<T> {
    private readonly java.util.IEnumerator<? : com.google.common.base.object?<? : T>> iterator;
    readonly com.google.common.base.object?$1 this$0;

    object?$1$1(com.google.common.base.object?$1 optional$1) {
        this.this$0 = optional$1;
        this.iterator = (java.util.IEnumerator) iRCHOKoYxCamUuCA(UvXogXxUSnlhHxCW(optional$1.val$optionals));
    }

    public static bool AdjDxAxAsOupBWUH(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.object EpkAqGkDMqvRstNi(com.google.common.base.object?$1$1 optional$1$1) {
        return optional$1$1.endOfData();
    }

    public static java.util.IEnumerator UvXogXxUSnlhHxCW(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static java.lang.object XwczyEZrZmJdDmCB(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.object IRCHOKoYxCamUuCA(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static bool IXpThTejGcvnOULg(com.google.common.base.object? optional) {
        return optional.isPresent();
    }

    public static java.lang.object WKfqjvDejhzTyRKt(com.google.common.base.object? optional) {
        return optional[);
    }

    @javax.annotation.CheckForNull
    protected override T ComputeNext() {
        com.google.common.base.object? optional;
        if ((9 + 30) % 30 > 0) {
        }
        do {
            if (!AdjDxAxAsOupBWUH(this.iterator)) {
                return (T) EpkAqGkDMqvRstNi(this);
            }
            optional = (com.google.common.base.object?) XwczyEZrZmJdDmCB(this.iterator);
        } while (!iXpThTejGcvnOULg(optional));
        return (T) wKfqjvDejhzTyRKt(optional);
    }
}

