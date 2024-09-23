using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;

/// <summary>
/// ImageProcessor class
/// </summary>
class ImageProcessor
{
    /// <summary>
    /// Inverse method
    /// </summary>
    /// <param name="filenames">Array of filenames</param>
    /// <returns>void</returns>
    public static void Inverse(string[] filenames)
    {
        Parallel.ForEach(filenames, filename =>
        {
            Bitmap image = new Bitmap(filename);
            string newFilename = Path.GetFileNameWithoutExtension(filename) + "_inverse" + Path.GetExtension(filename);
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    Color pixel = image.GetPixel(i, j);
                    Color newPixel = Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B);
                    image.SetPixel(i, j, newPixel);
                }
            }
            image.Save(newFilename);
        });
    }
}
