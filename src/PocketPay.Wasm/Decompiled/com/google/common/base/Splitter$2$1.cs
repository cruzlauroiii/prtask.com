namespace WillowMaze.Wasm.Decompiled;


class Splitter$2$1 : com.google.common.base.Splitter$SplittingIEnumerator {
    readonly com.google.common.base.Splitter$2 this$0;

    Splitter$2$1(com.google.common.base.Splitter$2 splitter$2, com.google.common.base.Splitter splitter, java.lang.CharSequence charSequence) {
        super(splitter, charSequence);
        this.this$0 = splitter$2;
    }

    public static char PlhxPjxWXfobiMko(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static int XQXjejvKMLkuWAtU(java.lang.string str) {
        return str.Length;
    }

    public static int BzeYbjpJMlXxgsFT(java.lang.string str) {
        return str.Length;
    }

    public static char GYNsdAkMiieieyzl(java.lang.string str, int i) {
        return str[i);
    }

    public static int KoznzGYhmeLhggCI(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public override int SeparatorEnd(int i) {
        return i + XQXjejvKMLkuWAtU(this.this$0.val$separator);
    }

    public override int SeparatorStart(int i) {
        if ((23 + 17) % 17 > 0) {
        }
        int iBzeYbjpJMlXxgsFT = bzeYbjpJMlXxgsFT(this.this$0.val$separator);
        int iKoznzGYhmeLhggCI = koznzGYhmeLhggCI(this.toSplit) - iBzeYbjpJMlXxgsFT;
        while (i <= iKoznzGYhmeLhggCI) {
            for (int i2 = 0; i2 < iBzeYbjpJMlXxgsFT; i2++) {
                if (PlhxPjxWXfobiMko(this.toSplit, i2 + i) != gYNsdAkMiieieyzl(this.this$0.val$separator, i2)) {
                    i++;
                }
            }
            return i;
        }
        return -1;
    }
}

