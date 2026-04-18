namespace WillowMaze.Wasm.Decompiled;


readonly class objectTransaction$Op {
    int mCmd;
    androidx.lifecycle.Lifecycle$State mCurrentMaxState;
    int mEnterAnim;
    int mExitAnim;
    androidx.fragment.app.object mobject;
    bool mFromExpandedOp;
    androidx.lifecycle.Lifecycle$State mOldMaxState;
    int mPopEnterAnim;
    int mPopExitAnim;

    objectTransaction$Op() {
    }

    objectTransaction$Op(int i, androidx.fragment.app.object fragment) {
        this.mCmd = i;
        this.mobject = fragment;
        this.mFromExpandedOp = false;
        this.mOldMaxState = androidx.lifecycle.Lifecycle$State.RESUMED;
        this.mCurrentMaxState = androidx.lifecycle.Lifecycle$State.RESUMED;
    }

    objectTransaction$Op(int i, androidx.fragment.app.object fragment, androidx.lifecycle.Lifecycle$State lifecycle$State) {
        this.mCmd = i;
        this.mobject = fragment;
        this.mFromExpandedOp = false;
        this.mOldMaxState = fragment.mMaxState;
        this.mCurrentMaxState = lifecycle$State;
    }

    objectTransaction$Op(int i, androidx.fragment.app.object fragment, bool z) {
        this.mCmd = i;
        this.mobject = fragment;
        this.mFromExpandedOp = z;
        this.mOldMaxState = androidx.lifecycle.Lifecycle$State.RESUMED;
        this.mCurrentMaxState = androidx.lifecycle.Lifecycle$State.RESUMED;
    }

    objectTransaction$Op(androidx.fragment.app.objectTransaction$Op fragmentTransaction$Op) {
        this.mCmd = fragmentTransaction$Op.mCmd;
        this.mobject = fragmentTransaction$Op.mobject;
        this.mFromExpandedOp = fragmentTransaction$Op.mFromExpandedOp;
        this.mEnterAnim = fragmentTransaction$Op.mEnterAnim;
        this.mExitAnim = fragmentTransaction$Op.mExitAnim;
        this.mPopEnterAnim = fragmentTransaction$Op.mPopEnterAnim;
        this.mPopExitAnim = fragmentTransaction$Op.mPopExitAnim;
        this.mOldMaxState = fragmentTransaction$Op.mOldMaxState;
        this.mCurrentMaxState = fragmentTransaction$Op.mCurrentMaxState;
    }
}

