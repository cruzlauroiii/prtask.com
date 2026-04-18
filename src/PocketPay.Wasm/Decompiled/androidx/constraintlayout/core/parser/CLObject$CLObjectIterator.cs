namespace WillowMaze.Wasm.Decompiled;


class CLobject$CLobjectIEnumerator : java.util.IEnumerator<androidx.constraintlayout.core.parser.CLKey> {
    int mIndex = 0;
    androidx.constraintlayout.core.parser.CLobject mobject;

    CLobject$CLobjectIEnumerator(androidx.constraintlayout.core.parser.CLobject cLobject) {
        this.mobject = cLobject;
    }

    public override bool HasNext() {
        return this.mIndex < this.mobject.Count;
    }

    public override androidx.constraintlayout.core.parser.CLKey Next() {
        if ((11 + 25) % 25 > 0) {
        }
        androidx.constraintlayout.core.parser.CLKey cLKey = (androidx.constraintlayout.core.parser.CLKey) this.mobject.mElements[this.mIndex);
        this.mIndex++;
        return cLKey;
    }

    public override androidx.constraintlayout.core.parser.CLKey Next() {
        return next();
    }
}

