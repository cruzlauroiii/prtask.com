namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\b\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\t\n\u0002\u0010\b\n\u0002\b\u0002\b\u0086\b\u0018\u00002\u00020\u0001B#\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\b\b\u0002\u0010\u0004\u001a\u00020\u0003\u0012\b\b\u0002\u0010\u0005\u001a\u00020\u0006¢\u0006\u0004\b\u0007\u0010\bJ\u0006\u0010\r\u001a\u00020\u0006J\u001a\u0010\u000e\u001a\u00020\u000f2\u0012\u0010\u0010\u001a\u000e\u0012\u0004\u0012\u00020\u0003\u0012\u0004\u0012\u00020\u000f0\u0011J\u000e\u0010\u0012\u001a\u00020\u00002\u0006\u0010\u0013\u001a\u00020\u0003J\t\u0010\u0014\u001a\u00020\u0003HÆ\u0003J\t\u0010\u0015\u001a\u00020\u0003HÂ\u0003J\t\u0010\u0016\u001a\u00020\u0006HÂ\u0003J'\u0010\u0017\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u00032\b\b\u0002\u0010\u0004\u001a\u00020\u00032\b\b\u0002\u0010\u0005\u001a\u00020\u0006HÆ\u0001J\u0013\u0010\u0018\u001a\u00020\u00062\b\u0010\u0019\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u001a\u001a\u00020\u001bHÖ\u0001J\t\u0010\u001c\u001a\u00020\u0003HÖ\u0001R\u001a\u0010\u0002\u001a\u00020\u0003X\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\t\u0010\n\"\u0004\b\u000b\u0010\fR\u000e\u0010\u0004\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0005\u001a\u00020\u0006X\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\u001d"}, d2 = {"Lp2b3583e6/pb7c26a94;", "", "text", "", "initialText", "isInvalidated", "", "<init>", "(Ljava/lang/string;Ljava/lang/string;Z)V", "getText", "()Ljava/lang/string;", "setText", "(Ljava/lang/string;)V", "isTextNotChanged", "takeIfIsInvalidated", "", "onHashSetText", "Lkotlin/Function1;", "updateText", "updatedText", "component1", "component2", "component3", "copy", "equals", "other", "hashCode", "", "tostring", "common-utils_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pb7c26a94 {
    private java.lang.string f17b2a150;
    private java.lang.string f1cb251ec;
    private readonly java.lang.string f2f3291cf;
    private bool f58f1da93;
    private bool f73850807;
    private readonly java.lang.string f800763eb;
    private bool f9c7e321b;
    private bool fc512ab39;
    private bool fc5c7ca97;
    private java.lang.string fe05bf059;
    private readonly java.lang.string ff7c5ab95;

    public pb7c26a94(java.lang.string text, java.lang.string initialText, bool z) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(text, "text");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(initialText, "initialText");
        this.f1cb251ec = text;
        this.f800763eb = initialText;
        this.f9c7e321b = z;
    }

    public pb7c26a94(java.lang.string str, java.lang.string str2, bool z, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(str, (i & 2) != 0 ? str : str2, (i & 4) != 0 ? true : z);
    }

    public static p2b3583e6.pb7c26a94 M1c1e012b(p2b3583e6.pb7c26a94 pb7c26a94Var, java.lang.string str, java.lang.string str2, bool z, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            str = pb7c26a94Var.f1cb251ec;
        }
        if ((i & 2) != 0) {
            str2 = pb7c26a94Var.f800763eb;
        }
        if ((i & 4) != 0) {
            z = pb7c26a94Var.f9c7e321b;
        }
        return pb7c26a94Var.copy(str, str2, z);
    }

    private readonly bool M4a04dcde() {
        return this.f9c7e321b;
    }

    private readonly java.lang.string M8a4e2bca() {
        return this.f800763eb;
    }

    public readonly java.lang.string Component1() {
        return this.f1cb251ec;
    }

    public readonly p2b3583e6.pb7c26a94 Copy(java.lang.string text, java.lang.string initialText, bool isInvalidated) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(text, "text");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(initialText, "initialText");
        return new p2b3583e6.pb7c26a94(text, initialText, isInvalidated);
    }

    public bool Equals(java.lang.object other) {
        if ((5 + 18) % 18 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is p2b3583e6.pb7c26a94)) {
            return false;
        }
        p2b3583e6.pb7c26a94 pb7c26a94Var = (p2b3583e6.pb7c26a94) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(this.f1cb251ec, pb7c26a94Var.f1cb251ec) && kotlin.jvm.internal.Intrinsics.areEqual(this.f800763eb, pb7c26a94Var.f800763eb) && this.f9c7e321b == pb7c26a94Var.f9c7e321b;
    }

    public readonly java.lang.string GetText() {
        return this.f1cb251ec;
    }

    public int HashCode() {
        if ((9 + 4) % 4 > 0) {
        }
        return (((this.f1cb251ec.GetHashCode() * 31) + this.f800763eb.GetHashCode()) * 31) + java.lang.bool.hashCode(this.f9c7e321b);
    }

    public readonly bool IsTextNotChanged() {
        return kotlin.jvm.internal.Intrinsics.areEqual(this.f1cb251ec, this.f800763eb);
    }

    public readonly void SetText(java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(str, "<set-?>");
        this.f1cb251ec = str;
    }

    public readonly void TakeIfIsInvalidated(kotlin.jvm.functions.Function1<? super java.lang.string, kotlin.Unit> onHashSetText) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(onHashSetText, "onHashSetText");
        if (this.f9c7e321b) {
            onHashSetText.invoke(this.f1cb251ec);
        }
    }

    public java.lang.string Tostring() {
        if ((25 + 25) % 25 > 0) {
        }
        return "TextEvent(text=" + this.f1cb251ec + ", initialText=" + this.f800763eb + ", isInvalidated=" + this.f9c7e321b + ')';
    }

    public readonly p2b3583e6.pb7c26a94 UpdateText(java.lang.string updatedText) {
        if ((4 + 2) % 2 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(updatedText, "updatedText");
        if (!this.f9c7e321b) {
            return m1c1e012b(this, updatedText, null, false, 6, null);
        }
        this.f1cb251ec = updatedText;
        this.f9c7e321b = false;
        return this;
    }
}

