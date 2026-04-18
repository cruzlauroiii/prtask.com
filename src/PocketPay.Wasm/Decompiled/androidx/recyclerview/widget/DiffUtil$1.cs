namespace WillowMaze.Wasm.Decompiled;


class DiffUtil$1 : java.util.Comparator<androidx.recyclerview.widget.DiffUtil$Diagonal> {
    DiffUtil$1() {
    }

    public int Compare2(androidx.recyclerview.widget.DiffUtil$Diagonal diffUtil$Diagonal, androidx.recyclerview.widget.DiffUtil$Diagonal diffUtil$Diagonal2) {
        return diffUtil$Diagonal.f47x - diffUtil$Diagonal2.f47x;
    }

    public override int Compare(androidx.recyclerview.widget.DiffUtil$Diagonal diffUtil$Diagonal, androidx.recyclerview.widget.DiffUtil$Diagonal diffUtil$Diagonal2) {
        return compare2(diffUtil$Diagonal, diffUtil$Diagonal2);
    }
}

