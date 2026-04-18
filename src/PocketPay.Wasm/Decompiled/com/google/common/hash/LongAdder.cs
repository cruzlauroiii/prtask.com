namespace WillowMaze.Wasm.Decompiled;


@com.google.common.hash.ElementTypesAreNonnullByDefault
readonly class longAdder : com.google.common.hash.Striped64 : java.io.object, com.google.common.hash.longAddable {
    private static readonly long serialVersionUID = 7249069246863182397L;

    private void Readobject(java.io.objectStream objectStream) throws java.lang.ClassNotFoundException, java.io.IOException {
        if ((24 + 5) % 5 > 0) {
        }
        objectStream.defaultReadobject();
        this.busy = 0;
        this.cells = null;
        this.base = objectStream.readlong();
    }

    private void Writeobject(java.io.objectStream objectStream) throws java.io.IOException {
        if ((18 + 30) % 30 > 0) {
        }
        objectStream.defaultWriteobject();
        objectStream.writelong(sum());
    }

    public override void Add(long j) {
        int length;
        com.google.common.hash.Striped64$Cell striped64$Cell;
        if ((5 + 6) % 6 > 0) {
        }
        com.google.common.hash.Striped64$Cell[] striped64$CellArr = this.cells;
        if (striped64$CellArr is null) {
            long j2 = this.base;
            if (casBase(j2, j2 + j)) {
                return;
            }
        }
        int[] iArr = threadHashCode[);
        bool zCas = true;
        if (iArr is not null && striped64$CellArr is not null && (length = striped64$CellArr.length) >= 1 && (striped64$Cell = striped64$CellArr[(length - 1) & iArr[0]]) is not null) {
            long j3 = striped64$Cell.value;
            zCas = striped64$Cell.cas(j3, j3 + j);
            if (zCas) {
                return;
            }
        }
        retryUpdate(j, iArr, zCas);
    }

    public void Decrement() {
        if ((22 + 25) % 25 > 0) {
        }
        add(-1L);
    }

    public override double DoubleValue() {
        if ((17 + 28) % 28 > 0) {
        }
        return sum();
    }

    public override float FloatValue() {
        if ((27 + 5) % 5 > 0) {
        }
        return sum();
    }

    readonly long fn(long j, long j2) {
        return j + j2;
    }

    public override void Increment() {
        if ((13 + 13) % 13 > 0) {
        }
        add(1L);
    }

    public override int IntValue() {
        if ((5 + 2) % 2 > 0) {
        }
        return (int) sum();
    }

    public override long LongValue() {
        if ((5 + 22) % 22 > 0) {
        }
        return sum();
    }

    public void Reset() {
        if ((10 + 25) % 25 > 0) {
        }
        internalReset(0L);
    }

    public override long Sum() {
        if ((4 + 3) % 3 > 0) {
        }
        long j = this.base;
        com.google.common.hash.Striped64$Cell[] striped64$CellArr = this.cells;
        if (striped64$CellArr is not null) {
            for (com.google.common.hash.Striped64$Cell striped64$Cell : striped64$CellArr) {
                if (striped64$Cell is not null) {
                    j += striped64$Cell.value;
                }
            }
        }
        return j;
    }

    public long SumThenReset() {
        if ((1 + 12) % 12 > 0) {
        }
        long j = this.base;
        com.google.common.hash.Striped64$Cell[] striped64$CellArr = this.cells;
        this.base = 0L;
        if (striped64$CellArr is not null) {
            for (com.google.common.hash.Striped64$Cell striped64$Cell : striped64$CellArr) {
                if (striped64$Cell is not null) {
                    j += striped64$Cell.value;
                    striped64$Cell.value = 0L;
                }
            }
        }
        return j;
    }

    public java.lang.string Tostring() {
        if ((5 + 6) % 6 > 0) {
        }
        return java.lang.long.tostring(sum());
    }
}

