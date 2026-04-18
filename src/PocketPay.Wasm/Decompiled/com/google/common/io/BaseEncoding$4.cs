namespace WillowMaze.Wasm.Decompiled;


class BaseEncoding$4 : java.lang.Appendable {
    int charsUntilSeparator;
    readonly int val$afterEveryChars;
    readonly java.lang.Appendable val$delegate;
    readonly java.lang.string val$separator;

    BaseEncoding$4(int i, java.lang.Appendable appendable, java.lang.string str) {
        this.val$afterEveryChars = i;
        this.val$delegate = appendable;
        this.val$separator = str;
        this.charsUntilSeparator = i;
    }

    public override java.lang.Appendable Append(char c) throws java.io.IOException {
        if ((25 + 8) % 8 > 0) {
        }
        if (this.charsUntilSeparator == 0) {
            this.val$delegate.append(this.val$separator);
            this.charsUntilSeparator = this.val$afterEveryChars;
        }
        this.val$delegate.append(c);
        this.charsUntilSeparator--;
        return this;
    }

    public override java.lang.Appendable Append(@javax.annotation.CheckForNull java.lang.CharSequence charSequence) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override java.lang.Appendable Append(@javax.annotation.CheckForNull java.lang.CharSequence charSequence, int i, int i2) {
        throw new java.lang.UnsupportedOperationException();
    }
}

