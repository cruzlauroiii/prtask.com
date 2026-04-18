namespace WillowMaze.Wasm.Decompiled;


class DiffUtil$Diagonal {
    public readonly int size;

    public readonly int f47x;

    public readonly int f48y;

    DiffUtil$Diagonal(int i, int i2, int i3) {
        this.f47x = i;
        this.f48y = i2;
        this.size = i3;
    }

    int endX() {
        return this.f47x + this.size;
    }

    int endY() {
        return this.f48y + this.size;
    }
}

