using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace WindowsFormsApplication1
{
    public class ConvolutionMatrix3x3
    {
        public int TopLeft = 0, TopMid = 0, TopRight = 0;
        public int MidLeft = 0, Pixel = 1, MidRight = 0;
        public int BottomLeft = 0, BottomMid = 0, BottomRight = 0;
        public int Factor = 1;
        public int Offset = 0;

        public void setAll(int inValue)
        {
            TopLeft = TopMid = TopRight = MidLeft = Pixel = MidRight = BottomLeft = BottomMid = BottomRight 
                = inValue;
        }
    }

    public class ConvolutionMatrix5x5
    {
        public int[] values = new int[25];
        public int Factor = 1;
        public int Offset = 0;
    }

    class Convolution
    {
        private static int correctPixelIfOutOfRange(int pixel)
        {
            if (pixel < 0)
            {
                return 0;
            }
            if (pixel > 255)
            {
                return 255;
            }
            return pixel;
        }

        private static Bitmap getConverted(Bitmap inBitmap, ConvolutionMatrix3x3 inMatrix)
        {
            if (inMatrix.Factor == 0)
            {
                throw new ArithmeticException("Divide by zero error!");
            }

            Bitmap buffer = (Bitmap)inBitmap.Clone();

            BitmapData bitmapData = inBitmap.LockBits(new Rectangle(0, 0, inBitmap.Width, inBitmap.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData bitmapSource = buffer.LockBits(new Rectangle(0, 0, buffer.Width, buffer.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int stride = bitmapData.Stride;
            int stride2 = stride * 2;
            int offset = stride - inBitmap.Width * 3;

            int width = inBitmap.Width - 2;
            int height = inBitmap.Height - 2;

            System.IntPtr Scan0 = bitmapData.Scan0;
            System.IntPtr SrcScan0 = bitmapSource.Scan0;

            unsafe
            {
                byte* pointer = (byte*)(void*)Scan0;
                byte* sourceBitmapPointer = (byte*)(void*)SrcScan0;

                int pixel;

                for (int y = 0; y < height; ++y)
                {
                    for (int x = 0; x < width; ++x)
                    {
                        pixel = ((((sourceBitmapPointer[2] * inMatrix.TopLeft) +
                                    (sourceBitmapPointer[5] * inMatrix.TopMid) +
                                    (sourceBitmapPointer[8] * inMatrix.TopRight) +

                                    (sourceBitmapPointer[2 + stride] * inMatrix.MidLeft) +
                                    (sourceBitmapPointer[5 + stride] * inMatrix.Pixel) +
                                    (sourceBitmapPointer[8 + stride] * inMatrix.MidRight) +

                                    (sourceBitmapPointer[2 + stride2] * inMatrix.BottomLeft) +
                                    (sourceBitmapPointer[5 + stride2] * inMatrix.BottomMid) +
                                    (sourceBitmapPointer[8 + stride2] * inMatrix.BottomRight)) / inMatrix.Factor) + inMatrix.Offset);

                        pixel = correctPixelIfOutOfRange(pixel);

                        pointer[5 + stride] = (byte)pixel;

                        pixel = ((((sourceBitmapPointer[1] * inMatrix.TopLeft) +
                                    (sourceBitmapPointer[4] * inMatrix.TopMid) +
                                    (sourceBitmapPointer[7] * inMatrix.TopRight) +

                                    (sourceBitmapPointer[1 + stride] * inMatrix.MidLeft) +
                                    (sourceBitmapPointer[4 + stride] * inMatrix.Pixel) +
                                    (sourceBitmapPointer[7 + stride] * inMatrix.MidRight) +

                                    (sourceBitmapPointer[1 + stride2] * inMatrix.BottomLeft) +
                                    (sourceBitmapPointer[4 + stride2] * inMatrix.BottomMid) +
                                    (sourceBitmapPointer[7 + stride2] * inMatrix.BottomRight)) / inMatrix.Factor) + inMatrix.Offset);

                        pixel = correctPixelIfOutOfRange(pixel);

                        pointer[4 + stride] = (byte)pixel;

                        pixel = ((((sourceBitmapPointer[0] * inMatrix.TopLeft) +
                                       (sourceBitmapPointer[3] * inMatrix.TopMid) +
                                       (sourceBitmapPointer[6] * inMatrix.TopRight) +

                                       (sourceBitmapPointer[0 + stride] * inMatrix.MidLeft) +
                                       (sourceBitmapPointer[3 + stride] * inMatrix.Pixel) +
                                       (sourceBitmapPointer[6 + stride] * inMatrix.MidRight) +

                                       (sourceBitmapPointer[0 + stride2] * inMatrix.BottomLeft) +
                                       (sourceBitmapPointer[3 + stride2] * inMatrix.BottomMid) +
                                       (sourceBitmapPointer[6 + stride2] * inMatrix.BottomRight)) / inMatrix.Factor) + inMatrix.Offset);

                        pixel = correctPixelIfOutOfRange(pixel);

                        pointer[3 + stride] = (byte)pixel;

                        pointer += 3;
                        sourceBitmapPointer += 3;
                    }

                    pointer += offset;
                    sourceBitmapPointer += offset;
                }
            }

            inBitmap.UnlockBits(bitmapData);
            buffer.UnlockBits(bitmapSource);

            return inBitmap;
        }

        public static Bitmap getConverted(Bitmap inBitmap, ConvolutionMatrix5x5 inMatrix)
        {
            int[] matrixValues = inMatrix.values;
            int matrixOffset = inMatrix.Offset;

            if (0 == inMatrix.Factor)
            {
                throw new ArithmeticException("Divide by zero error!");
            }

            Bitmap sourceBitmap = (Bitmap)inBitmap.Clone();

            BitmapData bitmapData = inBitmap.LockBits(new Rectangle(0, 0, inBitmap.Width, inBitmap.Height), ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            BitmapData sourceBitmapData = sourceBitmap.LockBits(new Rectangle(0, 0, sourceBitmap.Width, sourceBitmap.Height), ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);

            int stride = bitmapData.Stride;
            int stride2 = stride * 2;
            int stride3 = stride * 3;
            int stride4 = stride * 4;

            int length = (int)Math.Sqrt(matrixValues.Length);

            System.IntPtr Scan0 = bitmapData.Scan0;
            System.IntPtr SrcScan0 = sourceBitmapData.Scan0;

            unsafe
            {
                byte* pointer = (byte*)(void*)Scan0;
                byte* sourceBitmapPointer = (byte*)(void*)SrcScan0;

                int width = inBitmap.Width - 4;
                int height = inBitmap.Height - 4;

                int pixel;

                //gora
                for (int y = 0; y < 3; ++y)
                {
                    for (int x = 3; x < inBitmap.Width - 4; ++x)
                    {
                        pixel = (((sourceBitmapPointer[0 + stride2] * matrixValues[0]) +
                                        (sourceBitmapPointer[4 + stride2] * matrixValues[1]) +
                                        (sourceBitmapPointer[8 + stride2] * matrixValues[2]) +
                                        (sourceBitmapPointer[12 + stride2] * matrixValues[3]) +
                                        (sourceBitmapPointer[16 + stride2] * matrixValues[4]) +

                                        (sourceBitmapPointer[0 + stride] * matrixValues[5]) +
                                        (sourceBitmapPointer[4 + stride] * matrixValues[6]) +
                                        (sourceBitmapPointer[8 + stride] * matrixValues[7]) +
                                        (sourceBitmapPointer[12 + stride] * matrixValues[8]) +
                                        (sourceBitmapPointer[16 + stride] * matrixValues[9]) +

                                        (sourceBitmapPointer[0] * matrixValues[10]) +
                                        (sourceBitmapPointer[4] * matrixValues[11]) +
                                        (sourceBitmapPointer[8] * matrixValues[12]) +
                                        (sourceBitmapPointer[12] * matrixValues[13]) +
                                        (sourceBitmapPointer[16] * matrixValues[14]) +

                                        (sourceBitmapPointer[0 + stride] * matrixValues[15]) +
                                        (sourceBitmapPointer[4 + stride] * matrixValues[16]) +
                                        (sourceBitmapPointer[8 + stride] * matrixValues[17]) +
                                        (sourceBitmapPointer[12 + stride] * matrixValues[18]) +
                                        (sourceBitmapPointer[16 + stride] * matrixValues[19]) +

                                        (sourceBitmapPointer[0 + stride2] * matrixValues[20]) +
                                        (sourceBitmapPointer[4 + stride2] * matrixValues[21]) +
                                        (sourceBitmapPointer[8 + stride2] * matrixValues[22]) +
                                        (sourceBitmapPointer[12 + stride2] * matrixValues[23]) +
                                        (sourceBitmapPointer[16 + stride2] * matrixValues[24])) / inMatrix.Factor) + matrixOffset;

                        pixel = correctPixelIfOutOfRange(pixel);

                        pointer[2] = (byte)pixel;

                        pixel = (((sourceBitmapPointer[1 + stride2] * matrixValues[0]) +
                                        (sourceBitmapPointer[5 + stride2] * matrixValues[1]) +
                                        (sourceBitmapPointer[9 + stride2] * matrixValues[2]) +
                                        (sourceBitmapPointer[13 + stride2] * matrixValues[3]) +
                                        (sourceBitmapPointer[17 + stride2] * matrixValues[4]) +

                                        (sourceBitmapPointer[1 + stride] * matrixValues[5]) +
                                        (sourceBitmapPointer[5 + stride] * matrixValues[6]) +
                                        (sourceBitmapPointer[9 + stride] * matrixValues[7]) +
                                        (sourceBitmapPointer[13 + stride] * matrixValues[8]) +
                                        (sourceBitmapPointer[17 + stride] * matrixValues[9]) +

                                        (sourceBitmapPointer[1] * matrixValues[10]) +
                                        (sourceBitmapPointer[5] * matrixValues[11]) +
                                        (sourceBitmapPointer[9] * matrixValues[12]) +
                                        (sourceBitmapPointer[13] * matrixValues[13]) +
                                        (sourceBitmapPointer[17] * matrixValues[14]) +

                                        (sourceBitmapPointer[1 + stride] * matrixValues[15]) +
                                        (sourceBitmapPointer[5 + stride] * matrixValues[16]) +
                                        (sourceBitmapPointer[9 + stride] * matrixValues[17]) +
                                        (sourceBitmapPointer[13 + stride] * matrixValues[18]) +
                                        (sourceBitmapPointer[17 + stride] * matrixValues[19]) +

                                        (sourceBitmapPointer[1 + stride2] * matrixValues[20]) +
                                        (sourceBitmapPointer[5 + stride2] * matrixValues[21]) +
                                        (sourceBitmapPointer[9 + stride2] * matrixValues[22]) +
                                        (sourceBitmapPointer[13 + stride2] * matrixValues[23]) +
                                        (sourceBitmapPointer[17 + stride2] * matrixValues[24])) / inMatrix.Factor) + matrixOffset;

                        pixel = correctPixelIfOutOfRange(pixel);

                        pointer[1] = (byte)pixel;

                        pixel = (((sourceBitmapPointer[2 + stride2] * matrixValues[0]) +
                                        (sourceBitmapPointer[6 + stride2] * matrixValues[1]) +
                                        (sourceBitmapPointer[10 + stride2] * matrixValues[2]) +
                                        (sourceBitmapPointer[14 + stride2] * matrixValues[3]) +
                                        (sourceBitmapPointer[18 + stride2] * matrixValues[4]) +

                                        (sourceBitmapPointer[2 + stride] * matrixValues[5]) +
                                        (sourceBitmapPointer[6 + stride] * matrixValues[6]) +
                                        (sourceBitmapPointer[10 + stride] * matrixValues[7]) +
                                        (sourceBitmapPointer[14 + stride] * matrixValues[8]) +
                                        (sourceBitmapPointer[18 + stride] * matrixValues[9]) +

                                        (sourceBitmapPointer[2] * matrixValues[10]) +
                                        (sourceBitmapPointer[6] * matrixValues[11]) +
                                        (sourceBitmapPointer[10] * matrixValues[12]) +
                                        (sourceBitmapPointer[14] * matrixValues[13]) +
                                        (sourceBitmapPointer[18] * matrixValues[14]) +

                                        (sourceBitmapPointer[2 + stride] * matrixValues[15]) +
                                        (sourceBitmapPointer[6 + stride] * matrixValues[16]) +
                                        (sourceBitmapPointer[10 + stride] * matrixValues[17]) +
                                        (sourceBitmapPointer[14 + stride] * matrixValues[18]) +
                                        (sourceBitmapPointer[18 + stride] * matrixValues[19]) +

                                        (sourceBitmapPointer[2 + stride2] * matrixValues[20]) +
                                        (sourceBitmapPointer[6 + stride2] * matrixValues[21]) +
                                        (sourceBitmapPointer[10 + stride2] * matrixValues[22]) +
                                        (sourceBitmapPointer[14 + stride2] * matrixValues[23]) +
                                        (sourceBitmapPointer[18 + stride2] * matrixValues[24])) / inMatrix.Factor) + matrixOffset;

                        pixel = correctPixelIfOutOfRange(pixel);

                        pointer[0] = (byte)pixel;

                        pointer += 4;
                        sourceBitmapPointer += 4;
                    }
                    pointer += (length - 1) * 4;
                    sourceBitmapPointer += (length - 1) * 4;
                }

                pointer = (byte*)(void*)Scan0;
                sourceBitmapPointer = (byte*)(void*)SrcScan0;

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        pixel = (((sourceBitmapPointer[0] * matrixValues[0]) +
                                    (sourceBitmapPointer[4] * matrixValues[1]) +
                                    (sourceBitmapPointer[8] * matrixValues[2]) +
                                    (sourceBitmapPointer[12] * matrixValues[3]) +
                                    (sourceBitmapPointer[16] * matrixValues[4]) +

                                    (sourceBitmapPointer[0 + stride] * matrixValues[5]) +
                                    (sourceBitmapPointer[4 + stride] * matrixValues[6]) +
                                    (sourceBitmapPointer[8 + stride] * matrixValues[7]) +
                                    (sourceBitmapPointer[12 + stride] * matrixValues[8]) +
                                    (sourceBitmapPointer[16 + stride] * matrixValues[9]) +

                                    (sourceBitmapPointer[0 + stride2] * matrixValues[10]) +
                                    (sourceBitmapPointer[4 + stride2] * matrixValues[11]) +
                                    (sourceBitmapPointer[8 + stride2] * matrixValues[12]) +
                                    (sourceBitmapPointer[12 + stride2] * matrixValues[13]) +
                                    (sourceBitmapPointer[16 + stride2] * matrixValues[14]) +

                                    (sourceBitmapPointer[0 + stride3] * matrixValues[15]) +
                                    (sourceBitmapPointer[4 + stride3] * matrixValues[16]) +
                                    (sourceBitmapPointer[8 + stride3] * matrixValues[17]) +
                                    (sourceBitmapPointer[12 + stride3] * matrixValues[18]) +
                                    (sourceBitmapPointer[16 + stride3] * matrixValues[19]) +

                                    (sourceBitmapPointer[0 + stride4] * matrixValues[20]) +
                                    (sourceBitmapPointer[4 + stride4] * matrixValues[21]) +
                                    (sourceBitmapPointer[8 + stride4] * matrixValues[22]) +
                                    (sourceBitmapPointer[12 + stride4] * matrixValues[23]) +
                                    (sourceBitmapPointer[16 + stride4] * matrixValues[24])) / inMatrix.Factor) + matrixOffset;

                        pixel = correctPixelIfOutOfRange(pixel);

                        pointer[8 + stride2] = (byte)pixel;

                        pixel = (((sourceBitmapPointer[1] * matrixValues[0]) +
                                    (sourceBitmapPointer[5] * matrixValues[1]) +
                                    (sourceBitmapPointer[9] * matrixValues[2]) +
                                    (sourceBitmapPointer[13] * matrixValues[3]) +
                                    (sourceBitmapPointer[17] * matrixValues[4]) +

                                    (sourceBitmapPointer[1 + stride] * matrixValues[5]) +
                                    (sourceBitmapPointer[5 + stride] * matrixValues[6]) +
                                    (sourceBitmapPointer[9 + stride] * matrixValues[7]) +
                                    (sourceBitmapPointer[13 + stride] * matrixValues[8]) +
                                    (sourceBitmapPointer[17 + stride] * matrixValues[9]) +

                                    (sourceBitmapPointer[1 + stride2] * matrixValues[10]) +
                                    (sourceBitmapPointer[5 + stride2] * matrixValues[11]) +
                                    (sourceBitmapPointer[9 + stride2] * matrixValues[12]) +
                                    (sourceBitmapPointer[13 + stride2] * matrixValues[13]) +
                                    (sourceBitmapPointer[17 + stride2] * matrixValues[14]) +

                                    (sourceBitmapPointer[1 + stride3] * matrixValues[15]) +
                                    (sourceBitmapPointer[5 + stride3] * matrixValues[16]) +
                                    (sourceBitmapPointer[9 + stride3] * matrixValues[17]) +
                                    (sourceBitmapPointer[13 + stride3] * matrixValues[18]) +
                                    (sourceBitmapPointer[17 + stride3] * matrixValues[19]) +

                                    (sourceBitmapPointer[1 + stride4] * matrixValues[20]) +
                                    (sourceBitmapPointer[5 + stride4] * matrixValues[21]) +
                                    (sourceBitmapPointer[9 + stride4] * matrixValues[22]) +
                                    (sourceBitmapPointer[13 + stride4] * matrixValues[23]) +
                                    (sourceBitmapPointer[17 + stride4] * matrixValues[24])) / inMatrix.Factor) + matrixOffset;

                        pixel = correctPixelIfOutOfRange(pixel);

                        pointer[9 + stride2] = (byte)pixel;

                        pixel = (((sourceBitmapPointer[2] * matrixValues[0]) +
                                    (sourceBitmapPointer[6] * matrixValues[1]) +
                                    (sourceBitmapPointer[10] * matrixValues[2]) +
                                    (sourceBitmapPointer[14] * matrixValues[3]) +
                                    (sourceBitmapPointer[18] * matrixValues[4]) +

                                    (sourceBitmapPointer[2 + stride] * matrixValues[5]) +
                                    (sourceBitmapPointer[6 + stride] * matrixValues[6]) +
                                    (sourceBitmapPointer[10 + stride] * matrixValues[7]) +
                                    (sourceBitmapPointer[14 + stride] * matrixValues[8]) +
                                    (sourceBitmapPointer[18 + stride] * matrixValues[9]) +

                                    (sourceBitmapPointer[2 + stride2] * matrixValues[10]) +
                                    (sourceBitmapPointer[6 + stride2] * matrixValues[11]) +
                                    (sourceBitmapPointer[10 + stride2] * matrixValues[12]) +
                                    (sourceBitmapPointer[14 + stride2] * matrixValues[13]) +
                                    (sourceBitmapPointer[18 + stride2] * matrixValues[14]) +

                                    (sourceBitmapPointer[2 + stride3] * matrixValues[15]) +
                                    (sourceBitmapPointer[6 + stride3] * matrixValues[16]) +
                                    (sourceBitmapPointer[10 + stride3] * matrixValues[17]) +
                                    (sourceBitmapPointer[14 + stride3] * matrixValues[18]) +
                                    (sourceBitmapPointer[18 + stride3] * matrixValues[19]) +

                                    (sourceBitmapPointer[2 + stride4] * matrixValues[20]) +
                                    (sourceBitmapPointer[6 + stride4] * matrixValues[21]) +
                                    (sourceBitmapPointer[10 + stride4] * matrixValues[22]) +
                                    (sourceBitmapPointer[14 + stride4] * matrixValues[23]) +
                                    (sourceBitmapPointer[18 + stride4] * matrixValues[24])) / inMatrix.Factor) + matrixOffset;

                        pixel = correctPixelIfOutOfRange(pixel);

                        pointer[10 + stride2] = (byte)pixel;

                        pointer += 4;
                        sourceBitmapPointer += 4;
                    }

                    pointer += (length - 1) * 4;
                    sourceBitmapPointer += (length - 1) * 4;
                }
            }

            inBitmap.UnlockBits(bitmapData);
            sourceBitmap.UnlockBits(sourceBitmapData);

            return inBitmap;
        }

        public static Bitmap getBlurred(Bitmap inBitmap)
        {
            Bitmap bitmap = inBitmap;

            ConvolutionMatrix3x3 matrix = new ConvolutionMatrix3x3();

            matrix.setAll(1);

            matrix.Pixel = 1;
            matrix.Factor = 9;

            try
            {
                bitmap = getConverted(bitmap, matrix);
            }
            catch (ArithmeticException e)
            {
                MessageBox.Show(e.Message.ToString());
            }

            return bitmap;
        }

        public static Bitmap getGausianBlurred(Bitmap inBitmap)
        {
            Bitmap bitmap = inBitmap;

            ConvolutionMatrix3x3 matrix = new ConvolutionMatrix3x3();

            matrix.TopLeft = 1;
            matrix.TopMid = 2;
            matrix.TopRight = 1;

            matrix.MidLeft = 2;
            matrix.Pixel = 4;
            matrix.MidRight = 2;

            matrix.BottomLeft = 1;
            matrix.BottomMid = 2;
            matrix.BottomRight = 1;

            matrix.Factor = 16;

            try
            {
                bitmap = getConverted(bitmap, matrix);
            }
            catch (ArithmeticException e)
            {
                MessageBox.Show(e.Message.ToString());
            }

            return bitmap;
        }

        public static Bitmap getSharpen(Bitmap inBitmap)
        {
            Bitmap bitmap = inBitmap;

            ConvolutionMatrix3x3 matrix = new ConvolutionMatrix3x3();

            matrix.TopLeft = 0;
            matrix.TopMid = -1;
            matrix.TopRight = 0;

            matrix.MidLeft = -1;
            matrix.Pixel = 5;
            matrix.MidRight = -1;

            matrix.BottomLeft = 0;
            matrix.BottomMid = -1;
            matrix.BottomRight = 0;

            matrix.Factor = 1;

            try
            {
                bitmap = getConverted(bitmap, matrix);
            }
            catch (ArithmeticException e)
            {
                MessageBox.Show(e.Message.ToString());
            }

            return bitmap;
        }

        public static Bitmap custom(Bitmap inBitmap, ConvolutionMatrix3x3 matrix)
        {
            try
            {
                inBitmap = getConverted(inBitmap, matrix);
            }
            catch (ArithmeticException e)
            {
                MessageBox.Show(e.Message.ToString());
            }

            return inBitmap;
        }

        public static Bitmap custom(Bitmap inBitmap, ConvolutionMatrix5x5 matrix)
        {
            try
            {
                inBitmap = getConverted(inBitmap, matrix);
            }
            catch (ArithmeticException e)
            {
                MessageBox.Show(e.Message.ToString());
            }

            return inBitmap;
        }
    }
}
