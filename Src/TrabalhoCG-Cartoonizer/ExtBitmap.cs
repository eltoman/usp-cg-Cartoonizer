/*
 * The Following Code was developed by Dewald Esterhuizen
 * View Documentation at: http://softwarebydefault.com
 * Licensed under Ms-PL 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;
using AForge.Imaging.Filters.Smooting;
using AForge.Imaging.Filters;
using AForge.Imaging.ColorReduction;

namespace ImageCartoonEffect
{
    public static class ExtBitmap
    {

        public static Bitmap CopyToSquareCanvas(this Bitmap sourceBitmap, int canvasWidthLenght)
        {
            float ratio = 1.0f;
            int maxSide = sourceBitmap.Width > sourceBitmap.Height ?
                          sourceBitmap.Width : sourceBitmap.Height;

            ratio = (float)maxSide / (float)canvasWidthLenght;

            Bitmap bitmapResult = (sourceBitmap.Width > sourceBitmap.Height ?
                                    new Bitmap(canvasWidthLenght, (int)(sourceBitmap.Height / ratio))
                                    : new Bitmap((int)(sourceBitmap.Width / ratio), canvasWidthLenght));

            using (Graphics graphicsResult = Graphics.FromImage(bitmapResult))
            {
                graphicsResult.CompositingQuality = CompositingQuality.HighQuality;
                graphicsResult.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphicsResult.PixelOffsetMode = PixelOffsetMode.HighQuality;

                graphicsResult.DrawImage(sourceBitmap,
                                        new Rectangle(0, 0,
                                            bitmapResult.Width, bitmapResult.Height),
                                        new Rectangle(0, 0,
                                            sourceBitmap.Width, sourceBitmap.Height),
                                            GraphicsUnit.Pixel);
                graphicsResult.Flush();
            }

            return bitmapResult;
        }
        
        public static Bitmap CartoonEffectFilter(this Bitmap sourceBitmap, MainForm form, SmoothingFilterType smoothFilter = SmoothingFilterType.Nenhum)
        {


            sourceBitmap = sourceBitmap.SmoothingFilter(form,smoothFilter);
            return sourceBitmap;
        }




        public static Bitmap MedianFilter(this Bitmap sourceBitmap,
                                          int matrixSize)
        {
            BitmapData sourceData =
                       sourceBitmap.LockBits(new Rectangle(0, 0,
                       sourceBitmap.Width, sourceBitmap.Height),
                       ImageLockMode.ReadOnly,
                       PixelFormat.Format32bppArgb);

            byte[] pixelBuffer = new byte[sourceData.Stride *
                                          sourceData.Height];

            byte[] resultBuffer = new byte[sourceData.Stride *
                                           sourceData.Height];

            Marshal.Copy(sourceData.Scan0, pixelBuffer, 0,
                                       pixelBuffer.Length);

            sourceBitmap.UnlockBits(sourceData);

            int filterOffset = (matrixSize - 1) / 2;
            int calcOffset = 0;

            int byteOffset = 0;

            List<int> neighbourPixels = new List<int>();
            byte[] middlePixel;

            for (int offsetY = filterOffset; offsetY <
                sourceBitmap.Height - filterOffset; offsetY++)
            {
                for (int offsetX = filterOffset; offsetX <
                    sourceBitmap.Width - filterOffset; offsetX++)
                {
                    byteOffset = offsetY *
                                 sourceData.Stride +
                                 offsetX * 4;

                    neighbourPixels.Clear();

                    for (int filterY = -filterOffset;
                        filterY <= filterOffset; filterY++)
                    {
                        for (int filterX = -filterOffset;
                            filterX <= filterOffset; filterX++)
                        {

                            calcOffset = byteOffset +
                                         (filterX * 4) +
                                         (filterY * sourceData.Stride);

                            neighbourPixels.Add(BitConverter.ToInt32(
                                             pixelBuffer, calcOffset));
                        }
                    }

                    neighbourPixels.Sort();

                    middlePixel = BitConverter.GetBytes(
                                       neighbourPixels[filterOffset]);

                    resultBuffer[byteOffset] = middlePixel[0];
                    resultBuffer[byteOffset + 1] = middlePixel[1];
                    resultBuffer[byteOffset + 2] = middlePixel[2];
                    resultBuffer[byteOffset + 3] = middlePixel[3];
                }
            }

            Bitmap resultBitmap = new Bitmap(sourceBitmap.Width,
                                             sourceBitmap.Height);

            BitmapData resultData =
                       resultBitmap.LockBits(new Rectangle(0, 0,
                       resultBitmap.Width, resultBitmap.Height),
                       ImageLockMode.WriteOnly,
                       PixelFormat.Format32bppArgb);

            Marshal.Copy(resultBuffer, 0, resultData.Scan0,
                                       resultBuffer.Length);

            resultBitmap.UnlockBits(resultData);

            return resultBitmap;
        }



        public static Bitmap SmoothingFilter(this Bitmap sourceBitmap, MainForm form,
                                    SmoothingFilterType smoothFilter =
                                    SmoothingFilterType.Nenhum)
        {
            Bitmap inputBitmap = null;

            //Progress bar
            form.algorithmProgress = 0;

            switch (smoothFilter)
            {
                case SmoothingFilterType.Nenhum:
                    {
                        inputBitmap = sourceBitmap;
                    } break;
                case SmoothingFilterType.Gaussiano3x3:
                    {
                        inputBitmap = sourceBitmap.ConvolutionFilter(
                                   Matrix.Gaussian3x3, 1.0 / 16.0, 0);
                    } break;
                case SmoothingFilterType.Gaussiano5x5:
                    {
                        inputBitmap = sourceBitmap.ConvolutionFilter(
                                  Matrix.Gaussian5x5, 1.0 / 159.0, 0);
                    } break;
                case SmoothingFilterType.Gaussiano7x7:
                    {
                        inputBitmap = sourceBitmap.ConvolutionFilter(
                                  Matrix.Gaussian7x7, 1.0 / 136.0, 0);
                    } break;
                case SmoothingFilterType.Mediano3x3:
                    {
                        inputBitmap = sourceBitmap.MedianFilter(3);
                    } break;
                case SmoothingFilterType.Mediano5x5:
                    {
                        inputBitmap = sourceBitmap.MedianFilter(5);
                    } break;
                case SmoothingFilterType.Mediano7x7:
                    {
                        inputBitmap = sourceBitmap.MedianFilter(7);
                    } break;
                case SmoothingFilterType.Mediano9x9:
                    {
                        inputBitmap = sourceBitmap.MedianFilter(9);
                    } break;
                case SmoothingFilterType.Mean3x3:
                    {
                        inputBitmap = sourceBitmap.ConvolutionFilter(
                                      Matrix.Mean3x3, 1.0 / 9.0, 0);
                    } break;
                case SmoothingFilterType.Mean5x5:
                    {
                        inputBitmap = sourceBitmap.ConvolutionFilter(
                                      Matrix.Mean5x5, 1.0 / 25.0, 0);
                    } break;
                case SmoothingFilterType.LowPass3x3:
                    {
                        inputBitmap = sourceBitmap.ConvolutionFilter(
                                      Matrix.LowPass3x3, 1.0 / 16.0, 0);
                    } break;
                case SmoothingFilterType.LowPass5x5:
                    {
                        inputBitmap = sourceBitmap.ConvolutionFilter(
                                      Matrix.LowPass5x5, 1.0 / 60.0, 0);
                    } break;
                case SmoothingFilterType.Sharpen3x3:
                    {
                        inputBitmap = sourceBitmap.ConvolutionFilter(
                                      Matrix.Sharpen3x3, 1.0 / 8.0, 0);
                    } break;
            }

            //Progress bar
            form.algorithmProgress = 20;


            // START additional filters ADDED BY GABRIEL
            inputBitmap = AForge.Imaging.Image.Clone(inputBitmap, PixelFormat.Format24bppRgb); //Accepted format
            Bilateral               filterB = new Bilateral();
            Grayscale               filterG = new Grayscale(0.2125, 0.7154, 0.0721); //arbitrary values
            CannyEdgeDetector       filterE = new CannyEdgeDetector();
            ColorImageQuantizer     filterC = new ColorImageQuantizer(new MedianCutQuantizer());
            Dilatation              filterD = new Dilatation();

            //Bilateral filter as present in the article
            filterB.KernelSize = form.kernelValue; 
            filterB.SpatialFactor = form.spatialFactor;
            filterB.ColorFactor = form.colorFactor;
            filterB.ColorPower = form.colorPower;
            filterB.ApplyInPlace(inputBitmap);

            form.algorithmProgress = 40;

            /* GENERATING BORDERS */
            //Generate a grayscale version for edge detection
            Bitmap edges = filterG.Apply(inputBitmap);
            filterE.HighThreshold = form.highThreshold;
            filterE.LowThreshold = form.lowThreshold;
            filterE.ApplyInPlace(edges); // a new image, edges, is created here defining the edges of inputBitmap
            //Dilatation filter
            edges = filterD.Apply(edges);
            generateBorder(edges);
            //Making bg transparent
            edges.MakeTransparent(Color.White);


            form.algorithmProgress = 70;


            // Color reduction as present in the article
            inputBitmap = filterC.ReduceColors(inputBitmap, form.colorReductionFactor); // reduces to 24 variation

            inputBitmap = AForge.Imaging.Image.Clone(inputBitmap, PixelFormat.Format32bppArgb); //Accepted format

            // images merge
            Bitmap bitmapResult = new Bitmap(inputBitmap.Width, inputBitmap.Height, inputBitmap.PixelFormat);
            Graphics g = Graphics.FromImage(bitmapResult);
            g.DrawImage(inputBitmap, 0, 0, inputBitmap.Width, inputBitmap.Height);
            g.DrawImage(edges, 0, 0, inputBitmap.Width, inputBitmap.Height);
            // END additional filters ADDED BY GABRIEL

            form.algorithmProgress = 100;

            return bitmapResult; // it was returning input Bitmap before
        }

        // Simplifies the borders, and make them black
        private static void generateBorder(Bitmap a) {

            PixelFormat pxf = PixelFormat.Format24bppRgb;
            int separator = 30; // defines the tonality level in wich we will distinguish black or white

            // Lock the bitmap's bits.
            Rectangle rect = new Rectangle(0, 0, a.Width, a.Height);
            BitmapData bmpData =
            a.LockBits(rect, ImageLockMode.ReadWrite,
                         pxf);

            // Get the address of the first line.
            IntPtr ptr = bmpData.Scan0;

            // Declare an array to hold the bytes of the bitmap. 
            // int numBytes = bmp.Width * bmp.Height * 3; 
            int numBytes = bmpData.Stride * a.Height;
            byte[] rgbValues = new byte[numBytes];

            // Copy the RGB values into the array.
            Marshal.Copy(ptr, rgbValues, 0, numBytes);

            // Manipulate the bitmap, such as changing the 
            // blue value for every other pixel in the the bitmap. 
            for (int counter = 0; counter < rgbValues.Length-2; counter += 3) {
                if (rgbValues[counter] < separator && rgbValues[counter+1] < separator && rgbValues[counter+2] < separator) {
                    rgbValues[counter] = 255;
                    rgbValues[counter+1] = 255;
                    rgbValues[counter+2] = 255;
                }else {
                    rgbValues[counter] = 0;
                    rgbValues[counter + 1] = 0;
                    rgbValues[counter + 2] = 0;
                }
            }
                

            // Copy the RGB values back to the bitmap
            Marshal.Copy(rgbValues, 0, ptr, numBytes);

            // Unlock the bits.
            a.UnlockBits(bmpData);

        }


        private static Bitmap ConvolutionFilter(this Bitmap sourceBitmap,
                                                  double[,] filterMatrix,
                                                       double factor = 1,
                                                            int bias = 0)
        {
            BitmapData sourceData = sourceBitmap.LockBits(new Rectangle(0, 0,
                                     sourceBitmap.Width, sourceBitmap.Height),
                                                       ImageLockMode.ReadOnly,
                                                 PixelFormat.Format32bppArgb);

            byte[] pixelBuffer = new byte[sourceData.Stride * sourceData.Height];
            byte[] resultBuffer = new byte[sourceData.Stride * sourceData.Height];

            Marshal.Copy(sourceData.Scan0, pixelBuffer, 0, pixelBuffer.Length);
            sourceBitmap.UnlockBits(sourceData);

            double blue = 0.0;
            double green = 0.0;
            double red = 0.0;

            int filterWidth = filterMatrix.GetLength(1);
            int filterHeight = filterMatrix.GetLength(0);

            int filterOffset = (filterWidth - 1) / 2;
            int calcOffset = 0;

            int byteOffset = 0;

            for (int offsetY = filterOffset; offsetY <
                sourceBitmap.Height - filterOffset; offsetY++)
            {
                for (int offsetX = filterOffset; offsetX <
                    sourceBitmap.Width - filterOffset; offsetX++)
                {
                    blue = 0;
                    green = 0;
                    red = 0;

                    byteOffset = offsetY *
                                 sourceData.Stride +
                                 offsetX * 4;

                    for (int filterY = -filterOffset;
                        filterY <= filterOffset; filterY++)
                    {
                        for (int filterX = -filterOffset;
                            filterX <= filterOffset; filterX++)
                        {

                            calcOffset = byteOffset +
                                         (filterX * 4) +
                                         (filterY * sourceData.Stride);

                            blue += (double)(pixelBuffer[calcOffset]) *
                                    filterMatrix[filterY + filterOffset,
                                                        filterX + filterOffset];

                            green += (double)(pixelBuffer[calcOffset + 1]) *
                                     filterMatrix[filterY + filterOffset,
                                                        filterX + filterOffset];

                            red += (double)(pixelBuffer[calcOffset + 2]) *
                                   filterMatrix[filterY + filterOffset,
                                                      filterX + filterOffset];
                        }
                    }

                    blue = factor * blue + bias;
                    green = factor * green + bias;
                    red = factor * red + bias;

                    blue = (blue > 255 ? 255 :
                           (blue < 0 ? 0 :
                            blue));

                    green = (green > 255 ? 255 :
                            (green < 0 ? 0 :
                             green));

                    red = (red > 255 ? 255 :
                          (red < 0 ? 0 :
                           red)); 

                    resultBuffer[byteOffset] = (byte)(blue);
                    resultBuffer[byteOffset + 1] = (byte)(green);
                    resultBuffer[byteOffset + 2] = (byte)(red);
                    resultBuffer[byteOffset + 3] = 255;
                }
            }

            Bitmap resultBitmap = new Bitmap(sourceBitmap.Width, sourceBitmap.Height);

            BitmapData resultData = resultBitmap.LockBits(new Rectangle(0, 0,
                                     resultBitmap.Width, resultBitmap.Height),
                                                      ImageLockMode.WriteOnly,
                                                 PixelFormat.Format32bppArgb);

            Marshal.Copy(resultBuffer, 0, resultData.Scan0, resultBuffer.Length);
            resultBitmap.UnlockBits(resultData);

            return resultBitmap;
        }



        public enum SmoothingFilterType
        {
            Nenhum,
            Gaussiano3x3,
            Gaussiano5x5,
            Gaussiano7x7,
            Mediano3x3,
            Mediano5x5,
            Mediano7x7,
            Mediano9x9,
            Mean3x3,
            Mean5x5,
            LowPass3x3,
            LowPass5x5,
            Sharpen3x3
        }
    }  
}
