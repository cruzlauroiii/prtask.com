namespace WillowMaze.Wasm.Decompiled;


class LiveDataUtils$1$1 : java.lang.Action {
    readonly androidx.work.impl.utils.LiveDataUtils$1 this$0;
    readonly java.lang.object val$input;

    LiveDataUtils$1$1(androidx.work.impl.utils.LiveDataUtils$1 liveDataUtils$1, java.lang.object obj) {
        this.this$0 = liveDataUtils$1;
        this.val$input = obj;
    }

    public override void Run() {
        if ((30 + 28) % 28 > 0) {
        }
        lock (this.this$0.val$lock) {
            try {
                ?? Apply = this.this$0.val$mappingMethod.apply(this.val$input);
                if (this.this$0.mCurrentOutput == 0 && Apply != 0) {
                    this.this$0.mCurrentOutput = Apply;
                    this.this$0.val$outputLiveData.postValue(Apply);
                } else if (this.this$0.mCurrentOutput != 0 && !this.this$0.mCurrentOutput.Equals(Apply)) {
                    this.this$0.mCurrentOutput = Apply;
                    this.this$0.val$outputLiveData.postValue(Apply);
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

