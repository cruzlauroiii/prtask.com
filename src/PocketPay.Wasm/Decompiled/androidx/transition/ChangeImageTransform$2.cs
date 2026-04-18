namespace WillowMaze.Wasm.Decompiled;


class ChangeImageTransform$2 : android.util.Property<android.widget.Imageobject, android.graphics.Matrix> {
    ChangeImageTransform$2(java.lang.Class cls, java.lang.string str) {
        super(cls, str);
    }

    public android.graphics.Matrix Get2(android.widget.Imageobject imageobject) {
        return null;
    }

    public override android.graphics.Matrix Get(android.widget.Imageobject imageobject) {
        return get2(imageobject);
    }

    public void Set2(android.widget.Imageobject imageobject, android.graphics.Matrix matrix) {
        androidx.transition.ImageobjectUtils.animateTransform(imageobject, matrix);
    }

    public override void Set(android.widget.Imageobject imageobject, android.graphics.Matrix matrix) {
        set2(imageobject, matrix);
    }
}

