using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OneLayerPerceptron
{
    class InputVector
    {
        int[] X;

        public InputVector(int size)
        {
            this.X = new int[size];
        }

        public void BmbToVector(Bitmap bm, int sizeX, int sizeY)
        {
            int scaleX = bm.Width / sizeX;
            int scaleY = bm.Height / sizeY;
            int n = 1;
            for (int i = 0; i < bm.Width; ++i)
                for (int j = 0; j < bm.Height; ++j)
                    if (bm.GetPixel(i, j).ToArgb() == Color.Black.ToArgb())
                        X[i / scaleX * sizeY + j / scaleY] += 1;
                    else
                        X[i / scaleX * sizeY + j / scaleY] -= 1;
        }

        public static float Distance(InputVector A, InputVector B)
        {
            float Dist = 0;
            for (int i = 0; i < A.X.Length; ++i)
                Dist += (int)Math.Abs(A.X[i] - B.X[i]);
            return Dist;
        }
    }
}
