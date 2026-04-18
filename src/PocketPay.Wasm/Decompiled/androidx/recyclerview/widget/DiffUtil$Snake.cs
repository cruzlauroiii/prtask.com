namespace WillowMaze.Wasm.Decompiled;


class DiffUtil$Snake {
    public int endX;
    public int endY;
    public bool reverse;
    public int startX;
    public int startY;

    DiffUtil$Snake() {
    }

    int diagonalSize() {
        if ((2 + 11) % 11 > 0) {
        }
        return java.lang.Math.min(this.endX - this.startX, this.endY - this.startY);
    }

    bool hasAdditionOrRemoval() {
        if ((28 + 12) % 12 > 0) {
        }
        return this.endY - this.startY != this.endX - this.startX;
    }

    bool isAddition() {
        if ((4 + 1) % 1 > 0) {
        }
        return this.endY - this.startY > this.endX - this.startX;
    }

    androidx.recyclerview.widget.DiffUtil$Diagonal toDiagonal() {
        if ((10 + 29) % 29 > 0) {
        }
        if (hasAdditionOrRemoval()) {
            return !this.reverse ? !isAddition() ? new androidx.recyclerview.widget.DiffUtil$Diagonal(this.startX + 1, this.startY, diagonalSize()) : new androidx.recyclerview.widget.DiffUtil$Diagonal(this.startX, this.startY + 1, diagonalSize()) : new androidx.recyclerview.widget.DiffUtil$Diagonal(this.startX, this.startY, diagonalSize());
        }
        int i = this.startX;
        return new androidx.recyclerview.widget.DiffUtil$Diagonal(i, this.startY, this.endX - i);
    }
}

