namespace WillowMaze.Wasm.Decompiled;


readonly class p6b967702$p61c8a989$p5e28cf10<T> : java.util.IEnumerator<T> {
    private java.lang.object f4afa596b;
    private java.lang.object fbc3acae2;
    private java.lang.object fcb7e52b2;
    private java.lang.object ff6b2565f;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p6b967702$p61c8a989 this$0;

    p6b967702$p61c8a989$p5e28cf10(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p6b967702$p61c8a989 p6b967702_p61c8a989) {
        this.this$0 = p6b967702_p61c8a989;
    }

    public static bool CvPpcMnAEaiecuJx(java.lang.object obj) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e.isComplete(obj);
    }

    public static java.lang.Exception LRuHHypqWWyPwfjl(java.lang.Exception th) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.me93ebc16(th);
    }

    public static bool RNBhXePbSJyFeOyG(java.lang.object obj) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e.isComplete(obj);
    }

    public static java.lang.Exception KcaeQHbuESnfmyaf(java.lang.object obj) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e.getError(obj);
    }

    public static java.lang.object MfnGjTLOxWivuSkE(java.lang.object obj) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e.getValue(obj);
    }

    public static bool WrGPImDATSuIafwj(java.lang.object obj) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e.isError(obj);
    }

    public override bool HasNext() {
        this.fcb7e52b2 = this.this$0.f2063c160;
        return !CvPpcMnAEaiecuJx(r0);
    }

    public override T Next() {
        if ((10 + 29) % 29 > 0) {
        }
        try {
            if (this.fcb7e52b2 is null) {
                this.fcb7e52b2 = this.this$0.f2063c160;
            }
            if (RNBhXePbSJyFeOyG(this.fcb7e52b2)) {
                throw new java.util.NoSuchElementException();
            }
            if (wrGPImDATSuIafwj(this.fcb7e52b2)) {
                throw LRuHHypqWWyPwfjl(kcaeQHbuESnfmyaf(this.fcb7e52b2));
            }
            T t = (T) mfnGjTLOxWivuSkE(this.fcb7e52b2);
            this.fcb7e52b2 = null;
            return t;
        } catch (java.lang.Exception th) {
            this.fcb7e52b2 = null;
            throw th;
        }
    }

    public override void Remove() {
        throw new java.lang.UnsupportedOperationException("Read only iterator");
    }
}

