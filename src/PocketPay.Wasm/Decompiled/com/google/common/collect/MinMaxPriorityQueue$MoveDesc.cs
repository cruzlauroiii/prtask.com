namespace WillowMaze.Wasm.Decompiled;


class MinMaxPriorityQueue$MoveDesc<E> {
    readonly E replaced;
    readonly E toTrickle;

    MinMaxPriorityQueue$MoveDesc(E e, E e2) {
        this.toTrickle = e;
        this.replaced = e2;
    }
}

