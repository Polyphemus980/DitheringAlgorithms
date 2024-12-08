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
        public Bitmap AverageDithering(DirectBitmap originalImage, DitheringParams ditheringParams)
        {
            DirectBitmap processedBitmap = new DirectBitmap(
                originalImage.Width,
                originalImage.Height
            );
            ColorValues colorValues = getColors(ditheringParams);
            int width = originalImage.Width;
            int height = originalImage.Height;
            Parallel.For(
                0,
                originalImage.Width * originalImage.Height,
                (i) =>
                {
                    int j = i;
                    Color c = originalImage.GetPixel(i % width, i / width);
                    processedBitmap.SetPixel(
                        i % width,
                        i / width,
                        Color.FromArgb(
                            GetClosestValue(c.R, colorValues.redValues),
                            GetClosestValue(c.G, colorValues.greenValues),
                            GetClosestValue(c.B, colorValues.blueValues)
                        )
                    );
                }
            );
            return processedBitmap.Bitmap;
        }

        public Bitmap PopularityAlgoritm(
            DirectBitmap originalImage,
            DitheringParams ditheringParams
        )
        {
            DirectBitmap processedBitmap = new DirectBitmap(
                originalImage.Width,
                originalImage.Height
            );
            Dictionary<Color, int> colorCounts = new Dictionary<Color, int>(
                originalImage.Width * originalImage.Width / 2
            );
            for (int i = 0; i < originalImage.Width; i++)
            {
                for (int j = 0; j < originalImage.Height; j++)
                {
                    Color c = originalImage.GetPixel(i, j);
                    if (!colorCounts.ContainsKey(c))
                    {
                        colorCounts[c] = 0;
                    }
                    colorCounts[c]++;
                }
            }

            List<Color> popularColors = colorCounts
                .OrderBy(c => c.Value)
                .Take(ditheringParams.K)
                .Select(c => c.Key)
                .ToList();
            int width = originalImage.Width;
            int height = originalImage.Height;
            Parallel.For(
                0,
                originalImage.Width * originalImage.Height,
                (i) =>
                {
                    Color c = originalImage.GetPixel(i / width, i % width);
                    processedBitmap.SetPixel(
                        i / width,
                        i % width,
                        GetClosestColor(c, popularColors)
                    );
                }
            );
            return processedBitmap.Bitmap;
        }

        public Bitmap orderedRelativeDithering(
            DirectBitmap originalImage,
            DitheringParams ditheringParams
        )
        {
            DirectBitmap processedBitmap = new DirectBitmap(
                originalImage.Width,
                originalImage.Height
            );

            float[,] bayerMatrixRed = getClosestBayerMatrix(ditheringParams.Kr);
            float[,] bayerMatrixGreen = getClosestBayerMatrix(ditheringParams.Kg);
            float[,] bayerMatrixBlue = getClosestBayerMatrix(ditheringParams.Kb);
            int redLength = bayerMatrixRed.GetLength(0);
            int blueLength = bayerMatrixBlue.GetLength(0);
            int greenLength = bayerMatrixGreen.GetLength(0);
            ColorValues colorValues = getColors(ditheringParams);

            for (int i = 0; i < originalImage.Width; i++)
            {
                for (int j = 0; j < originalImage.Height; j++)
                {
                    Color c = originalImage.GetPixel(i, j);

                    int nR = bayerMatrixRed.GetLength(0);
                    int rcol = c.R * (ditheringParams.Kr - 1) / 255;
                    int rre = c.R * (ditheringParams.Kr - 1) % 255;
                    if (rre > bayerMatrixRed[i % nR, j % nR] * 255 / (nR * nR))
                        rcol++;

                    int nG = bayerMatrixGreen.GetLength(0);
                    int gcol = c.G * (ditheringParams.Kg - 1) / 255;
                    int gre = c.G * (ditheringParams.Kg - 1) % 255;
                    if (gre > bayerMatrixGreen[i % nG, j % nG] * 255 / (nG * nG))
                        gcol++;

                    int nB = bayerMatrixBlue.GetLength(0);
                    int bcol = c.B * (ditheringParams.Kb - 1) / 255;
                    int bre = c.B * (ditheringParams.Kb - 1) % 255;
                    if (bre > bayerMatrixBlue[i % nB, j % nB] * 255 / (nB * nB))
                        bcol++;

                    Color newColor = Color.FromArgb(
                        (int)colorValues.redValues[rcol],
                        (int)colorValues.greenValues[gcol],
                        (int)colorValues.blueValues[bcol]
                    );

                    processedBitmap.SetPixel(i, j, newColor);
                }
            }

            return processedBitmap.Bitmap;
        }

        public Bitmap orderedRandomDithering(
            DirectBitmap originalImage,
            DitheringParams ditheringParams
        )
        {
            DirectBitmap processedBitmap = new DirectBitmap(
                originalImage.Width,
                originalImage.Height
            );
            Random random = new Random(DateTime.Now.Second);
            float[,] bayerMatrixRed = getClosestBayerMatrix(ditheringParams.Kr);
            float[,] bayerMatrixGreen = getClosestBayerMatrix(ditheringParams.Kg);
            float[,] bayerMatrixBlue = getClosestBayerMatrix(ditheringParams.Kb);
            int redLength = bayerMatrixRed.GetLength(0);
            int blueLength = bayerMatrixBlue.GetLength(0);
            int greenLength = bayerMatrixGreen.GetLength(0);
            ColorValues colorValues = getColors(ditheringParams);
            Random rand = new Random();
            for (int i = 0; i < originalImage.Width; i++)
            {
                for (int j = 0; j < originalImage.Height; j++)
                {
                    Color c = originalImage.GetPixel(i, j);

                    int nR = bayerMatrixRed.GetLength(0);
                    int rcol = c.R * (ditheringParams.Kr - 1) / 255;
                    int rre = c.R * (ditheringParams.Kr - 1) % 255;
                    if (
                        rre
                        > bayerMatrixRed[rand.Next(nR) % nR, rand.Next(nR) % nR] * 255 / (nR * nR)
                    )
                        rcol++;

                    int nG = bayerMatrixGreen.GetLength(0);
                    int gcol = c.G * (ditheringParams.Kg - 1) / 255;
                    int gre = c.G * (ditheringParams.Kg - 1) % 255;
                    if (
                        gre
                        > bayerMatrixGreen[rand.Next(nG) % nG, rand.Next(nG) % nG] * 255 / (nG * nG)
                    )
                        gcol++;

                    int nB = bayerMatrixBlue.GetLength(0);
                    int bcol = c.B * (ditheringParams.Kb - 1) / 255;
                    int bre = c.B * (ditheringParams.Kb - 1) % 255;
                    if (
                        bre
                        > bayerMatrixBlue[rand.Next(nB) % nB, rand.Next(nB) % nB] * 255 / (nB * nB)
                    )
                        bcol++;

                    Color newColor = Color.FromArgb(
                        (int)colorValues.redValues[rcol],
                        (int)colorValues.greenValues[gcol],
                        (int)colorValues.blueValues[bcol]
                    );

                    processedBitmap.SetPixel(i, j, newColor);
                }
            }

            return processedBitmap.Bitmap;
        }

        public Bitmap AverageDitheringWithErrorPropagation(
            DirectBitmap originalImage,
            DitheringParams ditheringParams
        )
        {
            DirectBitmap processedBitmap = new DirectBitmap(
                originalImage.Width,
                originalImage.Height
            );
            for (int i = 0; i < originalImage.Width; i++)
            {
                for (int j = 0; j < originalImage.Height; j++)
                {
                    processedBitmap.SetPixel(i, j, originalImage.GetPixel(i, j));
                }
            }
            ColorValues colorValues = getColors(ditheringParams);

            for (int i = 0; i < originalImage.Width; i++)
            {
                for (int j = 0; j < originalImage.Height; j++)
                {
                    Color originalImageColor = processedBitmap.GetPixel(i, j);
                    Color newColor = Color.FromArgb(
                        GetClosestValue(originalImageColor.R, colorValues.redValues),
                        GetClosestValue(originalImageColor.G, colorValues.greenValues),
                        GetClosestValue(originalImageColor.B, colorValues.blueValues)
                    );
                    processedBitmap.SetPixel(i, j, newColor);
                    Vector3 error = new Vector3(
                        originalImageColor.R - newColor.R,
                        originalImageColor.G - newColor.G,
                        originalImageColor.B - newColor.B
                    );
                    if (i + 1 < originalImage.Width)
                    {
                        processedBitmap.SetPixel(
                            i + 1,
                            j,
                            AddColor(processedBitmap.GetPixel(i + 1, j), error * 5 / 16)
                        );
                        if (j + 1 < originalImage.Height)
                            processedBitmap.SetPixel(
                                i + 1,
                                j + 1,
                                AddColor(processedBitmap.GetPixel(i + 1, j + 1), error * 1 / 16)
                            );
                        if (j - 1 > 0)
                            processedBitmap.SetPixel(
                                i + 1,
                                j - 1,
                                AddColor(processedBitmap.GetPixel(i + 1, j - 1), error * 3 / 16)
                            );
                    }
                    if (j + 1 < originalImage.Height)
                        processedBitmap.SetPixel(
                            i,
                            j + 1,
                            AddColor(processedBitmap.GetPixel(i, j + 1), error * 7 / 16)
                        );
                }
            }
            return processedBitmap.Bitmap;
        }
    }
}
