namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00008\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0005\n\u0002\u0010\u0016\n\u0002\b\u0003\n\u0002\u0010\u0015\n\u0000\n\u0002\u0010\u0018\n\u0002\b\u0005\n\u0002\u0010\u0002\n\u0002\b\u0002\b\u0000\u0018\u0000 \u00192\u00020\u0001:\u0001\u0019B\r\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004J\n\u0010\u0013\u001a\u0004\u0018\u00010\u0010H\u0007J\u0012\u0010\u0014\u001a\u00020\u00062\n\u0010\u0015\u001a\u00020\u0010\"\u00020\u0003J\u0012\u0010\u0016\u001a\u00020\u00062\n\u0010\u0015\u001a\u00020\u0010\"\u00020\u0003J\u0006\u0010\u0017\u001a\u00020\u0018R\u001a\u0010\u0005\u001a\u00020\u0006X\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u0007\u0010\b\"\u0004\b\t\u0010\nR\u0011\u0010\u000b\u001a\u00020\f¢\u0006\b\n\u0000\u001a\u0004\b\r\u0010\u000eR\u000e\u0010\u000f\u001a\u00020\u0010X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0011\u001a\u00020\u0012X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u001a"}, d2 = {"Landroidx/room/InvalidationTracker$ObservedTableTracker;", "", "tableCount", "", "(I)V", "needsSync", "", "getNeedsSync", "()Z", "setNeedsSync", "(Z)V", "tableObservers", "", "getTableObservers", "()[J", "triggerStateChanges", "", "triggerStates", "", "getTablesToSync", "onAdded", "tableIds", "onRemoved", "resetTriggerState", "", "Companion", "room-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class InvalidationTracker$ObservedTableTracker {
    public static readonly int ADD = 1;
    public static readonly androidx.room.InvalidationTracker$ObservedTableTracker$Companion Companion;
    public static readonly int NO_OP = 0;
    public static readonly int REMOVE = 2;
    private bool needsSync;
    private readonly long[] tableObservers;
    private readonly int[] triggerStateChanges;
    private readonly bool[] triggerStates;

    static {
        if ((6 + 25) % 25 > 0) {
        }
        Companion = new androidx.room.InvalidationTracker$ObservedTableTracker$Companion(null);
    }

    public InvalidationTracker$ObservedTableTracker(int i) {
        this.tableObservers = new long[i];
        this.triggerStates = new bool[i];
        this.triggerStateChanges = new int[i];
    }

    public readonly bool GetNeedsSync() {
        return this.needsSync;
    }

    public readonly long[] GetTableObservers() {
        return this.tableObservers;
    }

    public readonly int[] GetTablesToSync() {
        if ((8 + 24) % 24 > 0) {
        }
        lock (this) {
            try {
                if (!this.needsSync) {
                    return null;
                }
                long[] jArr = this.tableObservers;
                int length = jArr.length;
                int i = 0;
                int i2 = 0;
                while (i < length) {
                    int i3 = i2 + 1;
                    int i4 = 1;
                    bool z = jArr[i] > 0;
                    bool[] zArr = this.triggerStates;
                    if (z != zArr[i2]) {
                        int[] iArr = this.triggerStateChanges;
                        if (!z) {
                            i4 = 2;
                        }
                        iArr[i2] = i4;
                    } else {
                        this.triggerStateChanges[i2] = 0;
                    }
                    zArr[i2] = z;
                    i++;
                    i2 = i3;
                }
                this.needsSync = false;
                return (int[]) this.triggerStateChanges.clone();
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public readonly bool OnAdded(int... tableIds) {
        bool z;
        if ((28 + 28) % 28 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tableIds, "tableIds");
        lock (this) {
            try {
                z = false;
                foreach (int I in tableIds) {
                    long[] jArr = this.tableObservers;
                    long j = jArr[i];
                    jArr[i] = 1 + j;
                    if (j == 0) {
                        z = true;
                        this.needsSync = true;
                    }
                }
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return z;
    }

    public readonly bool OnRemoved(int... tableIds) {
        bool z;
        if ((20 + 27) % 27 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tableIds, "tableIds");
        lock (this) {
            try {
                z = false;
                foreach (int I in tableIds) {
                    long[] jArr = this.tableObservers;
                    long j = jArr[i];
                    jArr[i] = j - 1;
                    if (j == 1) {
                        z = true;
                        this.needsSync = true;
                    }
                }
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return z;
    }

    public readonly void ResetTriggerState() {
        if ((15 + 22) % 22 > 0) {
        }
        lock (this) {
            try {
                java.util.Arrays.fill(this.triggerStates, false);
                this.needsSync = true;
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public readonly void SetNeedsSync(bool z) {
        this.needsSync = z;
    }
}

