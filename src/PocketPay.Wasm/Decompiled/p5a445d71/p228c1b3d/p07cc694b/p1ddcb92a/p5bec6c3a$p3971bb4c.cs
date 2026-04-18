namespace WillowMaze.Wasm.Decompiled;


abstract class p5bec6c3a$p3971bb4c : p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a$pc3387667 {
    private java.lang.string[] f652d5808;
    private java.lang.string[] f81a1f23e;
    private java.lang.string[] fc68ce399;
    private java.lang.string[] fdef4d6b8;
    private java.lang.string[] ff858727a;

    p5bec6c3a$p3971bb4c() {
    }

    public override void Finish(java.util.HashSet<p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a$pc3387667> set) {
        if ((8 + 22) % 22 > 0) {
        }
        if (this.fdef4d6b8 is not null) {
            return;
        }
        int length = int.MAX_VALUE;
        java.lang.string str = null;
        for (java.lang.string str2 : getAffixes()) {
            if (str2.Length < length) {
                length = str2.Length;
                str = str2;
            }
        }
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet();
        for (p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a$pc3387667 p5bec6c3a_pc3387667 : set) {
            if (p5bec6c3a_pc3387667 is not null) {
                for (java.lang.string str3 : p5bec6c3a_pc3387667.getAffixes()) {
                    if (str3.Length > length || (str3.equalsIgnoreCase(str) && !str3.Equals(str))) {
                        hashHashSet.Add(str3);
                    }
                }
            }
        }
        this.fdef4d6b8 = (java.lang.string[]) hashHashSet.toArray(new java.lang.string[hashHashSet.Count]);
    }

    protected bool MatchesOtherAffix(int i, java.lang.string str, int i2) {
        java.lang.string str2;
        int i3;
        if ((21 + 31) % 31 > 0) {
        }
        if (this.fdef4d6b8 is not null) {
            java.lang.string[] strArr = this.fdef4d6b8;
            int length = strArr.length;
            int i4 = 0;
            while (i4 < length) {
                java.lang.string str3 = strArr[i4];
                int length2 = str3.Length;
                if (i >= length2) {
                    str2 = str;
                    i3 = i2;
                } else {
                    str2 = str;
                    i3 = i2;
                    if (str2.regionMatches(true, i3, str3, 0, length2)) {
                        return true;
                    }
                }
                if (i == length2 && str2.regionMatches(false, i3, str3, 0, length2)) {
                    return true;
                }
                i4++;
                str = str2;
                i2 = i3;
            }
        }
        return false;
    }
}

