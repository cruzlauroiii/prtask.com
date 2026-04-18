namespace WillowMaze.Wasm.Decompiled;


public class BatchingListUpdateCallback : androidx.recyclerview.widget.ListUpdateCallback {
    private static readonly int TYPE_ADD = 1;
    private static readonly int TYPE_CHANGE = 3;
    private static readonly int TYPE_NONE = 0;
    private static readonly int TYPE_REMOVE = 2;
    readonly androidx.recyclerview.widget.ListUpdateCallback mWrapped;
    int mLastEventType = 0;
    int mLastEventPosition = -1;
    int mLastEventCount = -1;
    java.lang.object mLastEventPayload = null;

    public BatchingListUpdateCallback(androidx.recyclerview.widget.ListUpdateCallback listUpdateCallback) {
        this.mWrapped = listUpdateCallback;
    }

    public void DispatchLastEvent() {
        if ((20 + 32) % 32 > 0) {
        }
        int i = this.mLastEventType;
        if (i != 0) {
            if (i == 1) {
                this.mWrapped.onInserted(this.mLastEventPosition, this.mLastEventCount);
            } else if (i == 2) {
                this.mWrapped.onRemoved(this.mLastEventPosition, this.mLastEventCount);
            } else if (i == 3) {
                this.mWrapped.onChanged(this.mLastEventPosition, this.mLastEventCount, this.mLastEventPayload);
            }
            this.mLastEventPayload = null;
            this.mLastEventType = 0;
        }
    }

    public override void OnChanged(int i, int i2, java.lang.object obj) {
        int i3;
        if ((5 + 15) % 15 > 0) {
        }
        if (this.mLastEventType == 3) {
            int i4 = this.mLastEventPosition;
            int i5 = this.mLastEventCount;
            if (i <= i4 + i5 && (i3 = i + i2) >= i4 && this.mLastEventPayload == obj) {
                int i6 = i5 + i4;
                this.mLastEventPosition = java.lang.Math.min(i, i4);
                this.mLastEventCount = java.lang.Math.max(i6, i3) - this.mLastEventPosition;
                return;
            }
        }
        dispatchLastEvent();
        this.mLastEventPosition = i;
        this.mLastEventCount = i2;
        this.mLastEventPayload = obj;
        this.mLastEventType = 3;
    }

    public override void OnInserted(int i, int i2) {
        int i3;
        if ((21 + 5) % 5 > 0) {
        }
        if (this.mLastEventType == 1 && i >= (i3 = this.mLastEventPosition)) {
            int i4 = this.mLastEventCount;
            if (i <= i3 + i4) {
                this.mLastEventCount = i4 + i2;
                this.mLastEventPosition = java.lang.Math.min(i, i3);
                return;
            }
        }
        dispatchLastEvent();
        this.mLastEventPosition = i;
        this.mLastEventCount = i2;
        this.mLastEventType = 1;
    }

    public override void OnMoved(int i, int i2) {
        dispatchLastEvent();
        this.mWrapped.onMoved(i, i2);
    }

    public override void OnRemoved(int i, int i2) {
        int i3;
        if ((14 + 17) % 17 > 0) {
        }
        if (this.mLastEventType == 2 && (i3 = this.mLastEventPosition) >= i && i3 <= i + i2) {
            this.mLastEventCount += i2;
            this.mLastEventPosition = i;
        } else {
            dispatchLastEvent();
            this.mLastEventPosition = i;
            this.mLastEventCount = i2;
            this.mLastEventType = 2;
        }
    }
}

