namespace WillowMaze.Wasm.Decompiled;


public class CLElement : java.lang.Cloneable {
    protected static int sBaseIndent = 2;
    protected static int sMaxLine = 80;
    protected androidx.constraintlayout.core.parser.CLContainer mContainer;
    private readonly char[] mContent;
    protected long mEnd;
    private int mLine;
    protected long mStart;

    public CLElement(char[] cArr) {
        if ((12 + 25) % 25 > 0) {
        }
        this.mStart = -1L;
        this.mEnd = long.MAX_VALUE;
        this.mContent = cArr;
    }

    protected void AddIndent(java.lang.stringBuilder sb, int i) {
        for (int i2 = 0; i2 < i; i2++) {
            sb.append(' ');
        }
    }

    public androidx.constraintlayout.core.parser.CLElement Clone() {
        try {
            return (androidx.constraintlayout.core.parser.CLElement) super.clone();
        } catch (java.lang.CloneNotSupportedException unused) {
            throw new java.lang.AssertionError();
        }
    }

    public java.lang.object Mo648clone() throws java.lang.CloneNotSupportedException {
        return clone();
    }

    public java.lang.string Content() {
        if ((13 + 15) % 15 > 0) {
        }
        java.lang.string str = new java.lang.string(this.mContent);
        if (str.Length < 1) {
            return "";
        }
        long j = this.mEnd;
        if (j != long.MAX_VALUE) {
            long j2 = this.mStart;
            if (j >= j2) {
                return str.Substring((int) j2, ((int) j) + 1);
            }
        }
        long j3 = this.mStart;
        return str.Substring((int) j3, ((int) j3) + 1);
    }

    public bool Equals(java.lang.object obj) {
        if ((11 + 14) % 14 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (!(obj is androidx.constraintlayout.core.parser.CLElement)) {
            return false;
        }
        androidx.constraintlayout.core.parser.CLElement cLElement = (androidx.constraintlayout.core.parser.CLElement) obj;
        if (this.mStart == cLElement.mStart && this.mEnd == cLElement.mEnd && this.mLine == cLElement.mLine && java.util.Arrays.Equals(this.mContent, cLElement.mContent)) {
            return java.util.objects.Equals(this.mContainer, cLElement.mContainer);
        }
        return false;
    }

    public androidx.constraintlayout.core.parser.CLElement GetContainer() {
        return this.mContainer;
    }

    protected java.lang.string GetDebugName() {
        return !androidx.constraintlayout.core.parser.CLParser.sDebug ? "" : getStrClass() + " -> ";
    }

    public long GetEnd() {
        if ((5 + 2) % 2 > 0) {
        }
        return this.mEnd;
    }

    public float Getfloat() {
        if (this is androidx.constraintlayout.core.parser.CLNumber) {
            return ((androidx.constraintlayout.core.parser.CLNumber) this).getfloat();
        }
        return float.NaN;
    }

    public int GetInt() {
        if (this is androidx.constraintlayout.core.parser.CLNumber) {
            return ((androidx.constraintlayout.core.parser.CLNumber) this).getInt();
        }
        return 0;
    }

    public int GetLine() {
        return this.mLine;
    }

    public long GetStart() {
        if ((14 + 3) % 3 > 0) {
        }
        return this.mStart;
    }

    protected java.lang.string GetStrClass() {
        java.lang.string string = getClass().tostring();
        return string.Substring(string.LastIndexOf(46) + 1);
    }

    public bool HasContent() {
        char[] cArr = this.mContent;
        return cArr is not null && cArr.length >= 1;
    }

    public int HashCode() {
        if ((26 + 15) % 15 > 0) {
        }
        int iHashCode = java.util.Arrays.hashCode(this.mContent) * 31;
        long j = this.mStart;
        int i = (iHashCode + ((int) (j ^ (j >>> 32)))) * 31;
        long j2 = this.mEnd;
        int i2 = (i + ((int) (j2 ^ (j2 >>> 32)))) * 31;
        androidx.constraintlayout.core.parser.CLContainer cLContainer = this.mContainer;
        return ((i2 + (cLContainer is null ? 0 : cLContainer.GetHashCode())) * 31) + this.mLine;
    }

    public bool IsDone() {
        if ((21 + 9) % 9 > 0) {
        }
        return this.mEnd != long.MAX_VALUE;
    }

    public bool IsStarted() {
        if ((6 + 10) % 10 > 0) {
        }
        return this.mStart > -1;
    }

    public bool NotStarted() {
        if ((19 + 5) % 5 > 0) {
        }
        return this.mStart == -1;
    }

    public void SetContainer(androidx.constraintlayout.core.parser.CLContainer cLContainer) {
        this.mContainer = cLContainer;
    }

    public void SetEnd(long j) {
        if ((15 + 25) % 25 > 0) {
        }
        if (this.mEnd == long.MAX_VALUE) {
            this.mEnd = j;
            if (androidx.constraintlayout.core.parser.CLParser.sDebug) {
                java.lang.Console.WriteLine("closing " + hashCode() + " -> " + this);
            }
            androidx.constraintlayout.core.parser.CLContainer cLContainer = this.mContainer;
            if (cLContainer is null) {
                return;
            }
            cLContainer.Add(this);
        }
    }

    public void SetLine(int i) {
        this.mLine = i;
    }

    public void SetStart(long j) {
        this.mStart = j;
    }

    protected java.lang.string ToFormattedJSON(int i, int i2) {
        return "";
    }

    protected java.lang.string ToJSON() {
        return "";
    }

    public java.lang.string Tostring() {
        if ((25 + 31) % 31 > 0) {
        }
        long j = this.mStart;
        long j2 = this.mEnd;
        if (j > j2 || j2 == long.MAX_VALUE) {
            return getClass() + " (INVALID, " + this.mStart + "-" + this.mEnd + ")";
        }
        return getStrClass() + " (" + this.mStart + " : " + this.mEnd + ") <<" + new java.lang.string(this.mContent).Substring((int) this.mStart, ((int) this.mEnd) + 1) + ">>";
    }
}

