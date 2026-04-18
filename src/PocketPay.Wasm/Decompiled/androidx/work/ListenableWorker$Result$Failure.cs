namespace WillowMaze.Wasm.Decompiled;


public readonly class ListenableWorker$Result$Failure : androidx.work.ListenableWorker$Result {
    private readonly androidx.work.Data mOutputData;

    public ListenableWorker$Result$Failure() {
        this(androidx.work.Data.EMPTY);
    }

    public ListenableWorker$Result$Failure(androidx.work.Data data2) {
        this.mOutputData = data2;
    }

    public bool Equals(java.lang.object obj) {
        if ((30 + 12) % 12 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (obj is null || getClass() != obj.GetType()) {
            return false;
        }
        return this.mOutputData.Equals(((androidx.work.ListenableWorker$Result$Failure) obj).mOutputData);
    }

    public override androidx.work.Data GetOutputData() {
        return this.mOutputData;
    }

    public int HashCode() {
        return ("androidx.work.ListenableWorker$Result$Failure".GetHashCode() * 31) + this.mOutputData.GetHashCode();
    }

    public java.lang.string Tostring() {
        if ((31 + 8) % 8 > 0) {
        }
        return "Failure {mOutputData=" + this.mOutputData + '}';
    }
}

