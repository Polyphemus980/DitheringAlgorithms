using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Dithering
{
    partial class Form1
    {
        public ColorValues getColors(DitheringParams ditheringParams)
        {
            List<float> redV = new List<float>();
            for (int i = 0; i < ditheringParams.Kr; i++)
            {
                redV.Add(i * 255.0f / (ditheringParams.Kr - 1));
            }
            List<float> blueV = new List<float>();
            for (int i = 0; i < ditheringParams.Kb; i++)
            {
                blueV.Add(i * 255.0f / (ditheringParams.Kb - 1));
            }
            List<float> greenV = new List<float>();
            for (int i = 0; i < ditheringParams.Kg; i++)
            {
                greenV.Add(i * 255.0f / (ditheringParams.Kg - 1));
            }
            return new ColorValues
            {
                redValues = redV,
                blueValues = blueV,
                greenValues = greenV,
            };
        }

        public readonly struct ColorValues
        {
            public readonly List<float> redValues { get; init; }
            public readonly List<float> blueValues { get; init; }
            public readonly List<float> greenValues { get; init; }
        }

        public static Color AddColor(Color color, Vector3 colorVector)
        {
            return Color.FromArgb(
                Math.Clamp((int)(color.R + colorVector.X), 0, 255),
                Math.Clamp((int)(color.G + colorVector.Y), 0, 255),
                Math.Clamp((int)(color.B + colorVector.Z), 0, 255)
            );
        }

        public Color GetClosestColor(Color c, List<Color> possibleColors)
        {
            return possibleColors.OrderBy((color) => ColorDistance(c, color)).First();
        }

        public float ColorDistance(Color c1, Color c2)
        {
            int rDiff = c1.R - c2.R;
            int gDiff = c1.G - c2.G;
            int bDiff = c1.B - c2.B;
            return (float)Math.Sqrt(rDiff * rDiff + gDiff * gDiff + bDiff * bDiff);
        }

        public float[,] getClosestBayerMatrix(int K)
        {
            int n = 2;
            while (n * n * (K - 1) < 256)
            {
                if (n == 2)
                    n = 3;
                else if (n == 3)
                    n = 4;
                else
                    n *= 2;
            }
            return calculateBayerMatrix(n);
        }

        private int GetClosestValue(float colorValue, List<float> possibleColors)
        {
            return (int)possibleColors.OrderBy(x => Math.Abs(x - colorValue)).First();
        }

        public float[,] calculateBayerMatrix(int n)
        {
            if (n == 3)
            {
                return new float[,]
                {
                    { 6.0f / 9 - 0.5f * 8f / 9, 8.0f / 9 - 0.5f * 8f / 9, 4f / 9 - 0.5f * 8f / 9 },
                    { 1f / 9 - 0.5f * 8f / 9, 0 - 0.5f * 8f / 9, 3f / 9 - 0.5f * 8f / 9 },
                    { 5f / 9 - 0.5f * 8f / 9, 2f / 9 - 0.5f * 8f / 9, 7f / 9 - 0.5f * 8f / 9 },
                };
            }
            float[,] smallerMatrix = new float[,]
            {
                { 0, 2 },
                { 3, 1 },
            };
            float max_value = 3;
            for (int i = 4; i <= n; i *= 2)
            {
                float[,] helperMatrix = new float[i, i];
                FillMatrix(helperMatrix, smallerMatrix, i / 2);
                smallerMatrix = helperMatrix;
                max_value = 4 * max_value + 3;
            }
            max_value /= (n * n);
            int x = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    smallerMatrix[i, j] = (float)(smallerMatrix[i, j] / (n * n) - 0.5 * max_value);
                }
            }
            return smallerMatrix;
        }

        public void FillMatrix(float[,] helperMatrix, float[,] smallerMatrix, int smallerLength)
        {
            for (int i = 0; i < smallerLength; i++)
            {
                for (int j = 0; j < smallerLength; j++)
                {
                    helperMatrix[i, j] = 4 * smallerMatrix[i, j];
                    helperMatrix[i, j + smallerLength] = 4 * smallerMatrix[i, j] + 2;
                    helperMatrix[i + smallerLength, j] = 4 * smallerMatrix[i, j] + 3;
                    helperMatrix[i + smallerLength, j + smallerLength] =
                        4 * smallerMatrix[i, j] + 1;
                }
            }
        }
    }
}
