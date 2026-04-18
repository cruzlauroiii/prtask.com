namespace WillowMaze.Wasm.Decompiled;


public class Constraint$VAnchor : androidx.constraintlayout.core.dsl.Constraint$Anchor {
    readonly androidx.constraintlayout.core.dsl.Constraint this$0;

    Constraint$VAnchor(androidx.constraintlayout.core.dsl.Constraint constraint, androidx.constraintlayout.core.dsl.Constraint$VSide constraint$VSide) {
        super(constraint, androidx.constraintlayout.core.dsl.Constraint$Side.valueOf(constraint$VSide.name()));
        this.this$0 = constraint;
    }
}

