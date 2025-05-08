using System.Collections.Generic;
using System.Drawing;

public static class Transform2D
{
    public static List<PointF> Translate(List<PointF> shape, float dx, float dy)
    {
        List<PointF> result = new List<PointF>();
        for (int i = 0; i < shape.Count; i++)
        {
            float newX = shape[i].X + dx;
            float newY = shape[i].Y + dy;
            result.Add(new PointF(newX, newY));
        }
        return result;
    }

    public static List<PointF> Scale(List<PointF> shape, float sx, float sy)
    {
        List<PointF> result = new List<PointF>();

        for (int i = 0; i < shape.Count; i++)
        {
            float newX = shape[i].X * sx;
            float newY = shape[i].Y * sy;
            result.Add(new PointF(newX, newY));
        }

        return result;
    }
    public static float Sin(float x)
    {
        float result = 0;
        int terms = 10; // more terms = more accuracy

        for (int i = 0; i < terms; i++)
        {
            int sign = (i % 2 == 0) ? 1 : -1;
            float term = Power(x, 2 * i + 1) / Factorial(2 * i + 1);
            result += sign * term;
        }

        return result;
    }

    public static float Cos(float x)
    {
        float result = 0;
        int terms = 10;

        for (int i = 0; i < terms; i++)
        {
            int sign = (i % 2 == 0) ? 1 : -1;
            float term = Power(x, 2 * i) / Factorial(2 * i);
            result += sign * term;
        }

        return result;
    }

    private static float Power(float baseVal, int exp)
    {
        float result = 1;
        for (int i = 0; i < exp; i++)
            result *= baseVal;
        return result;
    }

    private static float Factorial(int n)
    {
        float result = 1;
        for (int i = 2; i <= n; i++)
            result *= i;
        return result;
    }


    public static List<PointF> Rotate(List<PointF> shape, float angleDegrees)
    {
        List<PointF> result = new List<PointF>();
        float radians = angleDegrees * (3.14159265f / 180f); // manually convert to radians

        float cos = Cos(radians);
        float sin = Sin(radians);

        for (int i = 0; i < shape.Count; i++)
        {
            float x = shape[i].X;
            float y = shape[i].Y;

            float newX = x * cos - y * sin;
            float newY = x * sin + y * cos;

            result.Add(new PointF(newX, newY));
        }

        return result;
    }
    public static List<PointF> Reflect(List<PointF> shape, string axis)
    {
        List<PointF> result = new List<PointF>();

        for (int i = 0; i < shape.Count; i++)
        {
            float x = shape[i].X;
            float y = shape[i].Y;

            if (axis == "X")
                result.Add(new PointF(x, -y));
            else if (axis == "Y")
                result.Add(new PointF(-x, y));
            else if (axis == "Origin")
                result.Add(new PointF(-x, -y));
        }

        return result;
    }
    public static List<PointF> ShearX(List<PointF> shape, float shx)
    {
        List<PointF> result = new List<PointF>();

        for (int i = 0; i < shape.Count; i++)
        {
            float x = shape[i].X + shx * shape[i].Y;
            float y = shape[i].Y;
            result.Add(new PointF(x, y));
        }

        return result;
    }

    public static List<PointF> ShearY(List<PointF> shape, float shy)
    {
        List<PointF> result = new List<PointF>();

        for (int i = 0; i < shape.Count; i++)
        {
            float x = shape[i].X;
            float y = shape[i].Y + shy * shape[i].X;
            result.Add(new PointF(x, y));
        }

        return result;
    }


}
