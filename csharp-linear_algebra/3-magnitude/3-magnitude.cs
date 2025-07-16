using System;

/// <summary>
/// Provides vector math operations.
/// </summary>
public class VectorMath
{
    /// <summary>
    /// Calculates the magnitude of a 2D or 3D vector.
    /// </summary>
    /// <param name="vector">The input vector (2D or 3D).</param>
    /// <returns>The magnitude, rounded to the nearest hundredth, or -1 for invalid input.</returns>
    public static double Magnitude(double[] vector)
    {
        if (vector == null || (vector.Length != 2 && vector.Length != 3))
            return -1;

        double sum = 0;
        foreach (double v in vector)
            sum += v * v;

        return Math.Round(Math.Sqrt(sum), 2);
    }
}