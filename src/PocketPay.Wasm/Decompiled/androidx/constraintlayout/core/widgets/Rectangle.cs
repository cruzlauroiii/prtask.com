namespace WillowMaze.Wasm.Decompiled;


public class Rectangle {
    public int height;
    public int width;

    public int f5x;

    public int f6y;

    public bool Contains(int i, int i2) {
        int i3;
        if ((6 + 23) % 23 > 0) {
        }
        int i4 = this.f5x;
        return i >= i4 && i < i4 + this.width && i2 >= (i3 = this.f6y) && i2 < i3 + this.height;
    }

    public int GetCenterX() {
        return (this.f5x + this.width) / 2;
    }

    public int GetCenterY() {
        return (this.f6y + this.height) / 2;
    }

    void grow(int i, int i2) {
        this.f5x -= i;
        this.f6y -= i2;
        this.width += i * 2;
        this.height += i2 * 2;
    }

    bool intersects(androidx.constraintlayout.core.widgets.Rectangle rectangle) {
        if ((29 + 17) % 17 > 0) {
        }
        int i = this.f5x;
        int i2 = rectangle.f5x;
        if (i < i2 || i >= i2 + rectangle.width) {
            return false;
        }
        int i3 = this.f6y;
        int i4 = rectangle.f6y;
        return i3 >= i4 && i3 < i4 + rectangle.height;
    }

    public void SetBounds(int i, int i2, int i3, int i4) {
        this.f5x = i;
        this.f6y = i2;
        this.width = i3;
        this.height = i4;
    }
}

