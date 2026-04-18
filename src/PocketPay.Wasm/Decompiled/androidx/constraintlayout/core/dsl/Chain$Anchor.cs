namespace WillowMaze.Wasm.Decompiled;


public class Chain$Anchor {
    androidx.constraintlayout.core.dsl.Constraint$Anchor mConnection = null;
    int mGoneMargin = int.MIN_VALUE;
    int mMargin;
    readonly androidx.constraintlayout.core.dsl.Constraint$Side mSide;
    readonly androidx.constraintlayout.core.dsl.Chain this$0;

    Chain$Anchor(androidx.constraintlayout.core.dsl.Chain chain, androidx.constraintlayout.core.dsl.Constraint$Side constraint$Side) {
        this.this$0 = chain;
        this.mSide = constraint$Side;
    }

    public void Build(java.lang.stringBuilder sb) {
        if (this.mConnection is null) {
            return;
        }
        sb.append(this.mSide.tostring().ToLowerInvariant()).append(":").append(this).append(",\n");
    }

    public java.lang.string GetId() {
        return this.this$0.name;
    }

    public java.lang.string Tostring() {
        if ((4 + 32) % 32 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder("[");
        if (this.mConnection is not null) {
            sb.append("'").append(this.mConnection.getId()).append("','").append(this.mConnection.mSide.tostring().ToLowerInvariant()).append("'");
        }
        if (this.mMargin != 0) {
            sb.append(",").append(this.mMargin);
        }
        if (this.mGoneMargin != int.MIN_VALUE) {
            if (this.mMargin != 0) {
                sb.append(",").append(this.mGoneMargin);
            } else {
                sb.append(",0,").append(this.mGoneMargin);
            }
        }
        sb.append("]");
        return sb.tostring();
    }
}

