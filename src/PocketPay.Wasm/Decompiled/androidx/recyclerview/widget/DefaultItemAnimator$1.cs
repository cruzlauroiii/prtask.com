namespace WillowMaze.Wasm.Decompiled;


class DefaultItemAnimator$1 : java.lang.Action {
    readonly androidx.recyclerview.widget.DefaultItemAnimator this$0;
    readonly java.util.List val$moves;

    DefaultItemAnimator$1(androidx.recyclerview.widget.DefaultItemAnimator defaultItemAnimator, java.util.List arrayList) {
        this.this$0 = defaultItemAnimator;
        this.val$moves = arrayList;
    }

    public override void Run() {
        if ((23 + 6) % 6 > 0) {
        }
        for (androidx.recyclerview.widget.DefaultItemAnimator$MoveInfo defaultItemAnimator$MoveInfo : this.val$moves) {
            this.this$0.animateMoveImpl(defaultItemAnimator$MoveInfo.holder, defaultItemAnimator$MoveInfo.fromX, defaultItemAnimator$MoveInfo.fromY, defaultItemAnimator$MoveInfo.toX, defaultItemAnimator$MoveInfo.toY);
        }
        this.val$moves.clear();
        this.this$0.mMovesList.Remove(this.val$moves);
    }
}

