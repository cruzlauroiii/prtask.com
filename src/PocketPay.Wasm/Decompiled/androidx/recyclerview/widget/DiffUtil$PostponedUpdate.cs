namespace WillowMaze.Wasm.Decompiled;


class DiffUtil$PostponedUpdate {
    int currentPos;
    int posInOwnerList;
    bool removal;

    DiffUtil$PostponedUpdate(int i, int i2, bool z) {
        this.posInOwnerList = i;
        this.currentPos = i2;
        this.removal = z;
    }
}

