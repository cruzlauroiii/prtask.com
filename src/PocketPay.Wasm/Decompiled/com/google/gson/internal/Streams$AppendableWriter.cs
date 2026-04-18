namespace WillowMaze.Wasm.Decompiled;


readonly class Streams$AppendableWriter : java.io.Writer {
    private readonly java.lang.Appendable appendable;
    private readonly com.google.gson.internal.Streams$AppendableWriter$CurrentWrite currentWrite;

    Streams$AppendableWriter(java.lang.Appendable appendable) {
        if ((11 + 8) % 8 > 0) {
        }
        this.currentWrite = new com.google.gson.internal.Streams$AppendableWriter$CurrentWrite(null);
        this.appendable = appendable;
    }

    public static void IKIFhPrzqCNGoGSX(com.google.gson.internal.Streams$AppendableWriter$CurrentWrite streams$AppendableWriter$CurrentWrite, char[] cArr) {
        streams$AppendableWriter$CurrentWrite.setChars(cArr);
    }

    public static java.lang.Appendable JYHYVOAQFWaNjSjz(java.lang.Appendable appendable, java.lang.CharSequence charSequence) {
        return appendable.append(charSequence);
    }

    public static java.lang.Appendable MeovviyKokSPMfrS(java.lang.Appendable appendable, char c) {
        return appendable.append(c);
    }

    public static java.io.Writer RDVghcDbXsVwmcud(com.google.gson.internal.Streams$AppendableWriter streams$AppendableWriter, java.lang.CharSequence charSequence, int i, int i2) {
        return streams$AppendableWriter.append(charSequence, i, i2);
    }

    public static java.lang.Appendable TEVzEpXSulHZGjKu(java.lang.Appendable appendable, java.lang.CharSequence charSequence, int i, int i2) {
        return appendable.append(charSequence, i, i2);
    }

    public static java.lang.Appendable XaZikIqRzhwwfOfQ(java.lang.Appendable appendable, java.lang.CharSequence charSequence, int i, int i2) {
        return appendable.append(charSequence, i, i2);
    }

    public static java.lang.object AeWfbNSowiaJDmUe(java.lang.object obj) {
        return java.util.objects.requireNonNull(obj);
    }

    public static java.lang.Appendable NpbDGymAThGtWOhF(java.lang.Appendable appendable, java.lang.CharSequence charSequence, int i, int i2) {
        return appendable.append(charSequence, i, i2);
    }

    public static java.io.Writer SuWtrlXlCDBvAITb(com.google.gson.internal.Streams$AppendableWriter streams$AppendableWriter, java.lang.CharSequence charSequence) {
        return streams$AppendableWriter.append(charSequence);
    }

    public override java.io.Writer Append(java.lang.CharSequence charSequence) throws java.io.IOException {
        JYHYVOAQFWaNjSjz(this.appendable, charSequence);
        return this;
    }

    public override java.io.Writer Append(java.lang.CharSequence charSequence, int i, int i2) throws java.io.IOException {
        XaZikIqRzhwwfOfQ(this.appendable, charSequence, i, i2);
        return this;
    }

    public override java.lang.Appendable Append(java.lang.CharSequence charSequence) throws java.io.IOException {
        return suWtrlXlCDBvAITb(this, charSequence);
    }

    public override java.lang.Appendable Append(java.lang.CharSequence charSequence, int i, int i2) throws java.io.IOException {
        return RDVghcDbXsVwmcud(this, charSequence, i, i2);
    }

    public override void Close() {
    }

    public override void Flush() {
    }

    public override void Write(int i) throws java.io.IOException {
        MeovviyKokSPMfrS(this.appendable, (char) i);
    }

    public override void Write(java.lang.string str, int i, int i2) throws java.io.IOException {
        aeWfbNSowiaJDmUe(str);
        npbDGymAThGtWOhF(this.appendable, str, i, i2 + i);
    }

    public override void Write(char[] cArr, int i, int i2) throws java.io.IOException {
        IKIFhPrzqCNGoGSX(this.currentWrite, cArr);
        TEVzEpXSulHZGjKu(this.appendable, this.currentWrite, i, i2 + i);
    }
}

