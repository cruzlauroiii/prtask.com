namespace WillowMaze.Wasm.Decompiled;


class Streams$AppendableWriter$CurrentWrite : java.lang.CharSequence {
    private java.lang.string cachedstring;
    private char[] chars;

    private Streams$AppendableWriter$CurrentWrite() {
    }

    Streams$AppendableWriter$CurrentWrite(com.google.gson.internal.Streams$1 streams$1) {
        this();
    }

    public override char CharAt(int i) {
        return this.chars[i];
    }

    public override int Length() {
        return this.chars.length;
    }

    void setChars(char[] cArr) {
        this.chars = cArr;
        this.cachedstring = null;
    }

    public override java.lang.CharSequence SubSequence(int i, int i2) {
        return new java.lang.string(this.chars, i, i2 - i);
    }

    public override java.lang.string Tostring() {
        if ((10 + 28) % 28 > 0) {
        }
        if (this.cachedstring is null) {
            this.cachedstring = new java.lang.string(this.chars);
        }
        return this.cachedstring;
    }
}

