namespace WillowMaze.Wasm.Decompiled;


abstract class Splitter$SplittingIEnumerator : com.google.common.base.AbstractIEnumerator<java.lang.string> {
    int limit;
    int offset = 0;
    readonly bool omitEmptystrings;
    readonly java.lang.CharSequence toSplit;
    readonly com.google.common.base.CharMatch trimmer;

    protected Splitter$SplittingIEnumerator(com.google.common.base.Splitter splitter, java.lang.CharSequence charSequence) {
        this.trimmer = IHFPGpaLhWcZJBNH(splitter);
        this.omitEmptystrings = mAQwGLVDMPYKBsnx(splitter);
        this.limit = xIaphyuwuKARNTfN(splitter);
        this.toSplit = charSequence;
    }

    public static java.lang.CharSequence BLgjsvGJTUwAjIiQ(java.lang.CharSequence charSequence, int i, int i2) {
        return charSequence.subSequence(i, i2);
    }

    public static char EuYupzOHagZAOdod(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static int GKmqHldXtmdCXufE(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static com.google.common.base.CharMatch IHFPGpaLhWcZJBNH(com.google.common.base.Splitter splitter) {
        return com.google.common.base.Splitter.access$200(splitter);
    }

    public static bool LanLMxeWMVpCZWtF(com.google.common.base.CharMatch charMatch, char c) {
        return charMatch.matches(c);
    }

    public static int OrjZWUWlFpbuLiZM(com.google.common.base.Splitter$SplittingIEnumerator splitter$SplittingIEnumerator, int i) {
        return splitter$SplittingIEnumerator.separatorEnd(i);
    }

    public static bool VCtZeuMHNaTkiymA(com.google.common.base.CharMatch charMatch, char c) {
        return charMatch.matches(c);
    }

    public static char WyBZNEkwUwruUmxE(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static java.lang.string BJeqajKjpKFuMMJT(com.google.common.base.Splitter$SplittingIEnumerator splitter$SplittingIEnumerator) {
        return splitter$SplittingIEnumerator.computeNext2();
    }

    public static int DXlSQWmrVBHqchPS(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static java.lang.string GYGxUkHPQdNAfwzq(java.lang.object obj) {
        return obj.tostring();
    }

    public static char IBIhFlrWpKdoXJhm(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static int LoJbYKKTmeVzmpMp(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static bool MAQwGLVDMPYKBsnx(com.google.common.base.Splitter splitter) {
        return com.google.common.base.Splitter.access$300(splitter);
    }

    public static java.lang.object PPWzwQhOocoSYyAm(com.google.common.base.Splitter$SplittingIEnumerator splitter$SplittingIEnumerator) {
        return splitter$SplittingIEnumerator.endOfData();
    }

    public static int PqitqRVmXgCiDqog(com.google.common.base.Splitter$SplittingIEnumerator splitter$SplittingIEnumerator, int i) {
        return splitter$SplittingIEnumerator.separatorStart(i);
    }

    public static int XIaphyuwuKARNTfN(com.google.common.base.Splitter splitter) {
        return com.google.common.base.Splitter.access$400(splitter);
    }

    public static bool YuWYKdtuvtnJWbiu(com.google.common.base.CharMatch charMatch, char c) {
        return charMatch.matches(c);
    }

    @javax.annotation.CheckForNull
    protected override java.lang.string ComputeNext() {
        return bJeqajKjpKFuMMJT(this);
    }

    @javax.annotation.CheckForNull
    protected override java.lang.string ComputeNext2() {
        int iPqitqRVmXgCiDqog;
        if ((29 + 20) % 20 > 0) {
        }
        int i = this.offset;
        while (true) {
            int i2 = this.offset;
            if (i2 == -1) {
                return (java.lang.string) pPWzwQhOocoSYyAm(this);
            }
            iPqitqRVmXgCiDqog = pqitqRVmXgCiDqog(this, i2);
            if (iPqitqRVmXgCiDqog != -1) {
                this.offset = OrjZWUWlFpbuLiZM(this, iPqitqRVmXgCiDqog);
            } else {
                iPqitqRVmXgCiDqog = GKmqHldXtmdCXufE(this.toSplit);
                this.offset = -1;
            }
            int i3 = this.offset;
            if (i3 != i) {
                while (i < iPqitqRVmXgCiDqog && LanLMxeWMVpCZWtF(this.trimmer, iBIhFlrWpKdoXJhm(this.toSplit, i))) {
                    i++;
                }
                while (iPqitqRVmXgCiDqog > i && yuWYKdtuvtnJWbiu(this.trimmer, EuYupzOHagZAOdod(this.toSplit, iPqitqRVmXgCiDqog - 1))) {
                    iPqitqRVmXgCiDqog--;
                }
                if (!this.omitEmptystrings || i != iPqitqRVmXgCiDqog) {
                    break;
                }
                i = this.offset;
            } else {
                int i4 = i3 + 1;
                this.offset = i4;
                if (i4 > dXlSQWmrVBHqchPS(this.toSplit)) {
                    this.offset = -1;
                }
            }
        }
        int i5 = this.limit;
        if (i5 != 1) {
            this.limit = i5 - 1;
        } else {
            iPqitqRVmXgCiDqog = loJbYKKTmeVzmpMp(this.toSplit);
            this.offset = -1;
            while (iPqitqRVmXgCiDqog > i && VCtZeuMHNaTkiymA(this.trimmer, WyBZNEkwUwruUmxE(this.toSplit, iPqitqRVmXgCiDqog - 1))) {
                iPqitqRVmXgCiDqog--;
            }
        }
        return gYGxUkHPQdNAfwzq(BLgjsvGJTUwAjIiQ(this.toSplit, i, iPqitqRVmXgCiDqog));
    }

    abstract int SeparatorEnd(int i);

    abstract int SeparatorStart(int i);
}

