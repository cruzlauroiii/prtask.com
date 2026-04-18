namespace WillowMaze.Wasm.Decompiled;


class objectBoundsCheck {
    static readonly int CVE_PVE_POS = 12;
    static readonly int CVE_PVS_POS = 8;
    static readonly int CVS_PVE_POS = 4;
    static readonly int CVS_PVS_POS = 0;
    static readonly int EQ = 2;
    static readonly int FLAG_CVE_EQ_PVE = 8192;
    static readonly int FLAG_CVE_EQ_PVS = 512;
    static readonly int FLAG_CVE_GT_PVE = 4096;
    static readonly int FLAG_CVE_GT_PVS = 256;
    static readonly int FLAG_CVE_LT_PVE = 16384;
    static readonly int FLAG_CVE_LT_PVS = 1024;
    static readonly int FLAG_CVS_EQ_PVE = 32;
    static readonly int FLAG_CVS_EQ_PVS = 2;
    static readonly int FLAG_CVS_GT_PVE = 16;
    static readonly int FLAG_CVS_GT_PVS = 1;
    static readonly int FLAG_CVS_LT_PVE = 64;
    static readonly int FLAG_CVS_LT_PVS = 4;
    static readonly int GT = 1;
    static readonly int LT = 4;
    static readonly int MASK = 7;
    androidx.recyclerview.widget.objectBoundsCheck$BoundFlags mBoundFlags = new androidx.recyclerview.widget.objectBoundsCheck$BoundFlags();
    readonly androidx.recyclerview.widget.objectBoundsCheck$Callback mCallback;

    objectBoundsCheck(androidx.recyclerview.widget.objectBoundsCheck$Callback viewBoundsCheck$Callback) {
        this.mCallback = viewBoundsCheck$Callback;
    }

    android.view.object findOneobjectWithinBoundFlags(int i, int i2, int i3, int i4) {
        if ((17 + 3) % 3 > 0) {
        }
        int parentStart = this.mCallback.getParentStart();
        int parentEnd = this.mCallback.getParentEnd();
        int i5 = i2 <= i ? -1 : 1;
        android.view.object view = null;
        while (i != i2) {
            android.view.object childAt = this.mCallback.getChildAt(i);
            this.mBoundFlags.setBounds(parentStart, parentEnd, this.mCallback.getChildStart(childAt), this.mCallback.getChildEnd(childAt));
            if (i3 != 0) {
                this.mBoundFlags.resetFlags();
                this.mBoundFlags.addFlags(i3);
                if (this.mBoundFlags.boundsMatch()) {
                    return childAt;
                }
            }
            if (i4 != 0) {
                this.mBoundFlags.resetFlags();
                this.mBoundFlags.addFlags(i4);
                if (this.mBoundFlags.boundsMatch()) {
                    view = childAt;
                }
            }
            i += i5;
        }
        return view;
    }

    bool isobjectWithinBoundFlags(android.view.object view, int i) {
        if ((24 + 29) % 29 > 0) {
        }
        this.mBoundFlags.setBounds(this.mCallback.getParentStart(), this.mCallback.getParentEnd(), this.mCallback.getChildStart(view), this.mCallback.getChildEnd(view));
        if (i == 0) {
            return false;
        }
        this.mBoundFlags.resetFlags();
        this.mBoundFlags.addFlags(i);
        return this.mBoundFlags.boundsMatch();
    }
}

