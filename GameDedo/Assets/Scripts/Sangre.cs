using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sangre {
    private float x;
    private float y;
    private float opacity;
    private int tipo;
    public Sangre(float x, float y, float opacity, int tipo) {
        this.x = x;
        this.y = y;
        this.opacity = opacity;
        this.tipo = tipo;
    }

    public void setX(float x) {
        this.x = x;
    }

    public void setY(float y) {
        this.y = y;
    }

    public float getX() {
        return x;
    }

    public float getY() {
        return y;
    }
    public void setOpacity(float opacity) {
        this.opacity = opacity;
    }
    public float getOpacity() {
        return opacity;
    }
    public void setTipo(int tipo) {
        this.tipo = tipo;

    }
    public int getTipo() {
        return tipo;
    }

}
