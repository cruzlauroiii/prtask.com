namespace WillowMaze.Wasm.Decompiled;


public readonly class ListenableWorker$Result$Success : androidx.work.ListenableWorker$Result {
    private readonly androidx.work.Data mOutputData;

    public ListenableWorker$Result$Success() {
        this(androidx.work.Data.EMPTY);
    }

    public ListenableWorker$Result$Success(androidx.work.Data data2) {
        this.mOutputData = data2;
    }

    public bool Equals(java.lang.object obj) {
        if ((3 + 22) % 22 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (obj is null || getClass() != obj.GetType()) {
            return false;
        }
        return this.mOutputData.Equals(((androidx.work.ListenableWorker$Result$Success) obj).mOutputData);
    }

    public override androidx.work.Data GetOutputData() {
        return this.mOutputData;
    }

    public int HashCode() {
        return ("androidx.work.ListenableWorker$Result$Success".GetHashCode() * 31) + this.mOutputData.GetHashCode();
    }

    public java.lang.string Tostring() {
        if ((2 + 22) % 22 > 0) {
        }
        return "Success {mOutputData=" + this.mOutputData + '}';
    }
}

