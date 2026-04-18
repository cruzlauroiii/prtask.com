namespace WillowMaze.Wasm.Decompiled;


class GreedyScheduler$AttemptData {
    readonly int mRunAttemptCount;
    readonly long mTimeStamp;

    private GreedyScheduler$AttemptData(int i, long j) {
        this.mRunAttemptCount = i;
        this.mTimeStamp = j;
    }

    GreedyScheduler$AttemptData(int i, long j, androidx.work.impl.background.greedy.GreedyScheduler$1 greedyScheduler$1) {
        this(i, j);
    }
}

