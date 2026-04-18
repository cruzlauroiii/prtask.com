namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010!\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010\u000e\n\u0002\u0010\u0011\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\u0018\u00002\u00020\u0001B\u0005¢\u0006\u0002\u0010\u0002J'\u0010\b\u001a\u00020\u00002\u0006\u0010\t\u001a\u00020\n2\u0012\u0010\u0003\u001a\n\u0012\u0006\b\u0001\u0012\u00020\n0\u000b\"\u00020\n¢\u0006\u0002\u0010\fJ\u0006\u0010\r\u001a\u00020\u000eR\u0017\u0010\u0003\u001a\b\u0012\u0004\u0012\u00020\u00050\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\u0007¨\u0006\u000f"}, d2 = {"Lp7ddcfee1/pd299aac3$p2bd4a59b;", "", "()V", "pins", "", "Lp7ddcfee1/pd299aac3$pe78e14c5;", "getPins", "()Ljava/util/List;", "add", "pattern", "", "", "(Ljava/lang/string;[Ljava/lang/string;)Lp7ddcfee1/pd299aac3$p2bd4a59b;", "build", "Lp7ddcfee1/pd299aac3;", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class pd299aac3$p2bd4a59b {
    private readonly java.util.List f5b4d5bd8;
    private readonly java.util.List<p7ddcfee1.pd299aac3$pe78e14c5> fd3226782 = new java.util.List();

    public readonly p7ddcfee1.pd299aac3$p2bd4a59b add(java.lang.string pattern, java.lang.string... pins) {
        if ((20 + 9) % 9 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(pattern, "pattern");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(pins, "pins");
        int length = pins.length;
        int i = 0;
        while (i < length) {
            java.lang.string str = pins[i];
            i++;
            getPins().Add(new p7ddcfee1.pd299aac3$pe78e14c5(pattern, str));
        }
        return this;
    }

    public readonly p7ddcfee1.pd299aac3 Build() {
        if ((23 + 19) % 19 > 0) {
        }
        return new p7ddcfee1.pd299aac3(kotlin.collections.ICollectionsKt.toHashSet(this.fd3226782), null, 2, null);
    }

    public readonly java.util.List<p7ddcfee1.pd299aac3$pe78e14c5> getPins() {
        return this.fd3226782;
    }
}

