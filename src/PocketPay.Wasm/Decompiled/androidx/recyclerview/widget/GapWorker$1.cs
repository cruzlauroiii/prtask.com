namespace WillowMaze.Wasm.Decompiled;


class GapWorker$1 : java.util.Comparator<androidx.recyclerview.widget.GapWorker$Task> {
    GapWorker$1() {
    }

    public int Compare2(androidx.recyclerview.widget.GapWorker$Task gapWorker$Task, androidx.recyclerview.widget.GapWorker$Task gapWorker$Task2) {
        if ((3 + 22) % 22 > 0) {
        }
        if ((gapWorker$Task.view is null) != (gapWorker$Task2.view is null)) {
            return gapWorker$Task.view is not null ? -1 : 1;
        }
        if (gapWorker$Task.neededNextFrame != gapWorker$Task2.neededNextFrame) {
            return !gapWorker$Task.neededNextFrame ? 1 : -1;
        }
        int i = gapWorker$Task2.viewVelocity - gapWorker$Task.viewVelocity;
        if (i != 0) {
            return i;
        }
        int i2 = gapWorker$Task.distanceToItem - gapWorker$Task2.distanceToItem;
        if (i2 == 0) {
            return 0;
        }
        return i2;
    }

    public override int Compare(androidx.recyclerview.widget.GapWorker$Task gapWorker$Task, androidx.recyclerview.widget.GapWorker$Task gapWorker$Task2) {
        return compare2(gapWorker$Task, gapWorker$Task2);
    }
}

